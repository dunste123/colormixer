using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMXControl.Providers
{
    class LightSerializerDescriptionProvider<TAbstract, TBase> : TypeDescriptionProvider
    {

        public LightSerializerDescriptionProvider(): base(TypeDescriptor.GetProvider(typeof(TAbstract)))
        {
            // Empty
        }

        public override Type GetReflectionType(Type objectType, object instance)
        {
            if (objectType == typeof(TAbstract))
            {
                return typeof(TBase);
            }

            return base.GetReflectionType(objectType, instance);
        }

        public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
        {
            if (objectType == typeof(TAbstract))
            {
                objectType = typeof(TBase);
            }

            return base.CreateInstance(provider, objectType, argTypes, args);
        }

    }
}
