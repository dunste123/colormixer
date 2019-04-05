using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace KleurenMixerV1Cs1.Serializers
{
    public abstract class LightSerializerDSte : UserControl, IXmlSerializable, ILightSerializer
    {
        private static readonly BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.Instance;

        public virtual void AfterReading() { }
        public virtual void AfterWriting() { }

        public abstract int[] GetDMXRange();
        public abstract int[][] GetDMXValues();

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            reader.ReadStartElement(this.GetType().Name);

            while (reader.IsStartElement())
            {
                try
                {
                    var name = reader.LocalName;
                    var field = this.GetType().GetProperty(name);
                    var content = reader.ReadElementContentAsInt();

                    field.SetValue(this, content, null);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                }
            }

            reader.ReadEndElement();

            this.AfterReading();
        }

        public void WriteXml(XmlWriter writer)
        {
            var props = this.GetType().GetProperties(bindingFlags).Where((x) => x.Name.EndsWith("DMXValue"));

            foreach (PropertyInfo prop in props)
            {
                var xmlValue = prop.GetValue(this, null);

                writer.WriteStartElement(prop.Name);
                writer.WriteValue(xmlValue);
                writer.WriteEndElement();
            }

            this.AfterWriting();
        }
    }
}
