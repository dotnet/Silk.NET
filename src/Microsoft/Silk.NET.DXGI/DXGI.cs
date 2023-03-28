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
        public static DXGI GetApi()
        {
             return new DXGI(CreateDefaultContext(new DXGILibraryNameContainer().GetLibraryNames()));
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

