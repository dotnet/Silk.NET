using System;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    public partial class DXGI
    {
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "DXGI_CREATE_FACTORY_DEBUG")]
        public const uint CreateFactoryDebug = unchecked((uint) 0x1);

        public static DXGI GetApi()
        {
             return new DXGI(CreateDefaultContext(new DXGILibraryNameContainer().GetLibraryName()));
        }

        public bool TryGetExtension<T>(out T ext)
            where T:NativeExtension<DXGI>
        {
             ext = IsExtensionPresent(ExtensionAttribute.GetExtensionAttribute(typeof(T)).Name)
                 ? (T) Activator.CreateInstance(typeof(T), Context)
                 : null;
             return !(ext is null);
        }

        public override bool IsExtensionPresent(string extension)
        {
            throw new NotImplementedException();
        }
    }
}

