using System;
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
                        //System.Diagnostics.Debug.WriteLine(reader.ReadInnerXml());
                        var seri = new XmlSerializer(typeof(UcPar56Sliders));

                        this.Par56Sliders = (UcPar56Sliders) seri.Deserialize(new System.IO.MemoryStream(System.Text.Encoding.UTF8.GetBytes(reader.ReadInnerXml())));
                        break;
                }
            }
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
        }

        public event EventHandler<LightTypeEventArgs> SliderControlSet;

        public class LightTypeEventArgs : EventArgs
        {
            public int ArrayIndex { get; set; }
            public Control Control { get; set; }
        }
    }
}
