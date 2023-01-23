using System;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.XInput
{
    public partial class XInput
    {
        public static XInput GetApi()
        {
            return new XInput(CreateDefaultContext("XInput1_3"));
        }

        public bool TryGetExtension<T>(out T ext)
            where T:NativeExtension<XInput>
        {
             ext = IsExtensionPresent(ExtensionAttribute.GetExtensionAttribute(typeof(T)).Name)
                 ? (T) Activator.CreateInstance(typeof(T), Context)
                 : null;
             return ext is not null;
        }

        public override bool IsExtensionPresent(string extension)
        {
            throw new NotImplementedException();
        }
    }
}

