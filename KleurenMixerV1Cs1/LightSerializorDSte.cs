using System;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace KleurenMixerV1Cs1
{
    public abstract class LightSerializerDSte : UserControl, IXmlSerializable, ILightSerializer
    {
        private static readonly BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.Instance;

        public virtual void AfterReading() { }
        public virtual void AfterWriting() { }

        public abstract int[] GetDMXRange();
        public abstract object[][] GetDMXValues();

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
            foreach (MethodInfo method in this.GetType().GetMethods(bindingFlags))
            {
                if (!method.Name.StartsWith("get_") || !method.Name.EndsWith("DMXValue"))
                {
                    continue;
                }

                var xmlName = method.Name.Split('_')[1];
                var xmlValue = method.Invoke(this, null);

                writer.WriteStartElement(xmlName);
                writer.WriteValue(xmlValue);
                writer.WriteEndElement();
            }

            this.AfterWriting();
        }
    }
}
