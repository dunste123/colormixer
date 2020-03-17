using DMXControl.Providers;
using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace DMXControl.Serializers
{
    [TypeDescriptionProvider(typeof(LightSerializerDescriptionProvider<LightSerializerDSte, UserControl>))]
    public abstract class LightSerializerDSte : UserControl, IXmlSerializable, ILightSerializer
    {
        private const BindingFlags BindingFlags = System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance;

        protected int _startAddress = 1;

        protected virtual void AfterReading() { }
        
        //public abstract int[][] GetDmxValues();
        public abstract int[] GetDmxValues();

        public virtual int[] GetDmxRange()
        {
            return new[]
            {
                this._startAddress,
                this._startAddress + 6,
            };
        }

        public LightSerializerDSte SetStartAddress(int start)
        {
            this._startAddress = start;
            return this;
        }

        public int GetStartAddress()
        {
            return this._startAddress;
        }

        protected int DmxInx(int slot)
        {
            return this._startAddress + slot;
        }

        #region xml
        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            reader.ReadStartElement(GetType().Name);

            while (reader.IsStartElement())
            {
                try
                {
                    var name = reader.LocalName;
                    var field = GetType().GetProperty(name);
                    var content = reader.ReadElementContentAsInt();

                    if (field != null)
                    {
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

            AfterReading();
        }

        public void WriteXml(XmlWriter writer)
        {
            var props = GetType().GetProperties(BindingFlags).Where(x => x.Name.EndsWith("DMXValue"));

            foreach (var prop in props)
            {
                var xmlValue = prop.GetValue(this, null);

                writer.WriteStartElement(prop.Name);
                writer.WriteValue(xmlValue);
                writer.WriteEndElement();
            }
        }
        #endregion
    }
}
