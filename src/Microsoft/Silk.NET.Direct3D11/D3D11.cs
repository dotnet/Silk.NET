using System;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    public partial class D3D11
    {
        public static D3D11 GetApi()
        {
             return new D3D11(new DefaultNativeContext(new D3D11LibraryNameContainer().GetName()));
        }

        public bool TryGetExtension<T>(out T ext)
            where T:NativeExtension<D3D11>
        {
             ext = IsExtensionPresent(ExtensionAttribute.GetExtensionAttribute(typeof(T)).Name)
                 ? Activator.CreateInstance<T>(Context)
                 : null;
             return !(ext is null);
        }

        public override bool IsExtensionPresent(string extension)
        {
            throw new NotImplementedException();
        }
    }
}

