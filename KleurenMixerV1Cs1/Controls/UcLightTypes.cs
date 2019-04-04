using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Linq;

namespace KleurenMixerV1Cs1.Controls
{
    public partial class UcLightTypes : UserControl, IXmlSerializable
    {
        private static readonly BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.Instance;

        private int arrayIndex = 0;

        public UcLightTypes()
        {
            InitializeComponent();
        }

        public int ArrayIndexDSte
        {
            get => this.arrayIndex;
            set
            {
                this.arrayIndex = value;
                this.lblIndexDste.Text = (value + 1).ToString();
            }
        }

        public bool Par56SlidersEnabledDSte
        {
            get => this.CbPar56Dste.Checked;
            set => this.CbPar56Dste.Checked = value;
        }

        public bool MovingHeadSlidersEnabledDSte
        {
            get => this.CbMovingHeadDste.Checked;
            set => this.CbMovingHeadDste.Checked = value;
        }

        public UcPar56Sliders Par56SlidersDSte { get; set; }

        public UcMovingHeadSliders MovingHeadSlidersDSte { get; set; }

        public void HideAllControls()
        {
            if (this.Par56SlidersDSte != null)
            {
                this.Par56SlidersDSte.Shown = false;
            }
        }

        private void BtnPar56Dste_Click(object sender, EventArgs e)
        {
            if (this.Par56SlidersDSte == null)
            {
                this.Par56SlidersDSte = new UcPar56Sliders();
                this.Par56SlidersEnabledDSte = true;
            }

            var eventArgs = new LightTypeEventArgs();
            eventArgs.ArrayIndex = this.ArrayIndexDSte;
            eventArgs.Control = this.Par56SlidersDSte;

            this.OnSliderControlSet(eventArgs);
        }

        private void BtnMovingHeadDSte_Click(object sender, EventArgs e)
        {
            if (this.MovingHeadSlidersDSte == null)
            {
                this.MovingHeadSlidersDSte = new UcMovingHeadSliders();
                this.MovingHeadSlidersEnabledDSte = true;
            }

            var eventArgs = new LightTypeEventArgs();
            eventArgs.ArrayIndex = this.ArrayIndexDSte;
            eventArgs.Control = this.MovingHeadSlidersDSte;

            this.OnSliderControlSet(eventArgs);
        }

        protected virtual void OnSliderControlSet(LightTypeEventArgs e)
        {
            this.SliderControlSet?.Invoke(this, e);
        }

        public XmlSchema GetSchema()
        {
            throw null;
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
                    var field = this.GetType().GetProperty(name);
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
            var props = this.GetType().GetProperties(bindingFlags).Where((x) => x.Name.EndsWith("DSte"));

            foreach (PropertyInfo prop in props)
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
