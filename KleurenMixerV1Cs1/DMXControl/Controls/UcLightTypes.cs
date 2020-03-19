using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace DMXControl.Controls
{
    public sealed partial class UcLightTypes : UserControl, IXmlSerializable
    {
        private const BindingFlags BindingFlags = System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance;

        private int arrayIndex;

        public UcLightTypes()
        {
            InitializeComponent();
        }

        public int ArrayIndexDSte
        {
            get => arrayIndex;
            set
            {
                arrayIndex = value;
                lblIndexDste.Text = (value + 1).ToString();
            }
        }

        public bool Par56SlidersEnabledDSte
        {
            get => CbPar56Dste.Checked;
            set => CbPar56Dste.Checked = value;
        }

        public bool MovingHeadSlidersEnabledDSte
        {
            get => CbMovingHeadDste.Checked;
            set => CbMovingHeadDste.Checked = value;
        }

        public UcPar56Sliders Par56SlidersDSte { get; set; }

        public UcMovingHeadSliders MovingHeadSlidersDSte { get; set; }

        public void HideAllControls()
        {
            if (Par56SlidersDSte != null)
            {
                Par56SlidersDSte.Shown = false;
            }
        }

        private void BtnPar56Dste_Click(object sender, EventArgs e)
        {
            if (Par56SlidersDSte == null)
            {
                Par56SlidersDSte = new UcPar56Sliders(1);
                Par56SlidersEnabledDSte = true;
            }

            var eventArgs = new LightTypeEventArgs
            {
                ArrayIndex = ArrayIndexDSte, 
                Control = Par56SlidersDSte
            };

            OnSliderControlSet(eventArgs);
        }

        private void BtnMovingHeadDSte_Click(object sender, EventArgs e)
        {
            if (MovingHeadSlidersDSte == null)
            {
                MovingHeadSlidersDSte = new UcMovingHeadSliders(7);
                MovingHeadSlidersEnabledDSte = true;
            }

            var eventArgs = new LightTypeEventArgs
            {
                ArrayIndex = ArrayIndexDSte, 
                Control = MovingHeadSlidersDSte
            };

            OnSliderControlSet(eventArgs);
        }

        private void OnSliderControlSet(LightTypeEventArgs e)
        {
            SliderControlSet?.Invoke(this, e);
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            var nsMgr = new XmlNamespaceManager(new NameTable());

            reader.ReadStartElement("UcLightTypes");

            while (reader.IsStartElement())
            {
                try
                {
                    var name = reader.LocalName;
                    var field = GetType().GetProperty(name);

                    if (field == null)
                    {
                        return;
                    }
                    
                    var type = field.PropertyType;

                    if (type.Name.EndsWith("Sliders"))
                    {
                        var seri = new XmlSerializer(type);
                        var val = reader.ReadInnerXml();
                        var stream = new MemoryStream(Encoding.UTF8.GetBytes(val));

                        field.SetValue(this, seri.Deserialize(stream), null);
                    }
                    else
                    {
                        var content = reader.ReadElementContentAs(type, nsMgr);

                        field.SetValue(this, content, null);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                }
            }

            reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer)
        {
            var props = GetType().GetProperties(BindingFlags).Where((x) => x.Name.EndsWith("DSte"));

            foreach (var prop in props)
            {
                var xmlValue = prop.GetValue(this, null);

                if (xmlValue == null)
                {
                    continue;
                }

                writer.WriteStartElement(prop.Name);

                if (xmlValue is IXmlSerializable)
                {
                    var type = xmlValue.GetType();
                    var seri = new XmlSerializer(type);

                    seri.Serialize(writer, xmlValue);
                }
                else
                {
                    writer.WriteValue(xmlValue);
                }

                writer.WriteEndElement();
            }
        }

        public event EventHandler<LightTypeEventArgs> SliderControlSet;

        public class LightTypeEventArgs : EventArgs
        {
            public int ArrayIndex { get; set; }
            public Control Control { get; set; }
        }
    }
}