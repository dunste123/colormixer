using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace KleurenMixerV1Cs1.Controls
{
    public partial class UcLightTypes : UserControl, IXmlSerializable
    {
        private int arrayIndex = 0;

        public UcLightTypes()
        {
            InitializeComponent();
        }

        public int ArrayIndex
        {
            get => this.arrayIndex;
            set
            {
                this.arrayIndex = value;
                this.lblIndexDste.Text = (value + 1).ToString();
            }
        }

        public bool Par56SlidersEnabled
        {
            get => this.CbPar56Dste.Checked;
            set => this.CbPar56Dste.Checked = value;
        }

        public UcPar56Sliders Par56Sliders { get; set; }

        public void HideAllControls()
        {
            if (this.Par56Sliders != null)
            {
                this.Par56Sliders.Shown = false;
            }
        }

        private void BtnPar56Dste_Click(object sender, EventArgs e)
        {
            if (this.Par56Sliders == null)
            {
                this.Par56Sliders = new UcPar56Sliders();
            }

            if (!this.Par56Sliders.Shown)
            {
                this.Par56Sliders.Shown = true;

                var eventArgs = new LightTypeEventArgs();
                eventArgs.ArrayIndex = this.ArrayIndex;
                eventArgs.Control = this.Par56Sliders;

                this.OnSliderControlSet(eventArgs);
            }
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
            reader.ReadStartElement("UcLightTypes");

            while (reader.IsStartElement())
            {
                switch(reader.LocalName)
                {
                    case "ArrayIndex":
                        this.ArrayIndex = reader.ReadElementContentAsInt();
                        break;
                    case "Par56Sliders":
                        var seri = new XmlSerializer(typeof(UcPar56Sliders));
                        var val = reader.ReadInnerXml();
                        var stream = new MemoryStream(Encoding.UTF8.GetBytes(val));

                        this.Par56Sliders = (UcPar56Sliders)seri.Deserialize(stream);
                        break;
                    case "Par56SlidersEnabled":
                        this.Par56SlidersEnabled = reader.ReadElementContentAsBoolean();
                        break;
                    default:
                        reader.ReadElementContentAsString();
                        break;
                }
            }

            reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteStartElement("ArrayIndex");
            writer.WriteValue(this.ArrayIndex);
            writer.WriteEndElement();

            writer.WriteStartElement("Par56Sliders");
            var seri = new XmlSerializer(typeof(UcPar56Sliders));
            seri.Serialize(writer, this.Par56Sliders);
            writer.WriteEndElement();

            writer.WriteStartElement("Par56SlidersEnabled");
            writer.WriteValue(this.Par56SlidersEnabled);
            writer.WriteEndElement();
        }

        public event EventHandler<LightTypeEventArgs> SliderControlSet;

        public class LightTypeEventArgs : EventArgs
        {
            public int ArrayIndex { get; set; }
            public Control Control { get; set; }
        }
    }
}
