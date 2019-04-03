using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace KleurenMixerV1Cs1.Controls
{
    public partial class UcMovingHeadSliders: UserControl, IXmlSerializable
    {
        public UcMovingHeadSliders()
        {
            InitializeComponent();
        }

        public bool Shown { get; set; }
        
        public int XAxis {
            get => this.trbXDSte.Value;
            set => this.trbXDSte.Value = value;
        }
        
        public int YAxis
        {
            get => this.trbYDSte.Value;
            set => this.trbYDSte.Value = value;
        }
        
        public int DimmerStrobe
        {
            get => this.trbDmStrbDSte.Value;
            set => this.trbDmStrbDSte.Value = value;
        }

        public int Color
        {
            get => this.trbColorDSte.Value;
            set => this.trbColorDSte.Value = value;
        }

        public int Gobo {
            get => this.trbGoboDSte.Value;
            set => this.trbGoboDSte.Value = value;
        }
        

        private void BtnResetDSte_Click(object sender, EventArgs e)
        {
            this.XAxis = 0;
            this.YAxis = 0;
            this.DimmerStrobe = 0;
            this.Color = 0;
            this.Gobo = 0;
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            reader.ReadStartElement("UcMovingHeadSliders");

            while (reader.IsStartElement())
            {
                switch (reader.LocalName)
                {
                    case "XAxis":
                        this.XAxis = reader.ReadElementContentAsInt();
                        break;
                    case "YAxis":
                        this.YAxis = reader.ReadElementContentAsInt();
                        break;
                    case "DimmerStrobe":
                        this.DimmerStrobe = reader.ReadElementContentAsInt();
                        break;
                    case "Color":
                        this.Color = reader.ReadElementContentAsInt();
                        break;
                    case "Gobo":
                        this.Gobo = reader.ReadElementContentAsInt();
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
            writer.WriteStartElement("XAxis");
            writer.WriteValue(this.XAxis);
            writer.WriteEndElement();

            writer.WriteStartElement("YAxis");
            writer.WriteValue(this.YAxis);
            writer.WriteEndElement();

            writer.WriteStartElement("DimmerStrobe");
            writer.WriteValue(this.DimmerStrobe);
            writer.WriteEndElement();

            writer.WriteStartElement("Color");
            writer.WriteValue(this.Color);
            writer.WriteEndElement();

            writer.WriteStartElement("Gobo");
            writer.WriteValue(this.Gobo);
            writer.WriteEndElement();
        }
    }
}
