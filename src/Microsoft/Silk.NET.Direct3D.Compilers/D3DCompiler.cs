using System;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace Silk.NET.Direct3D.Compilers
{
    public partial class D3DCompiler
    {
        public static D3DCompiler GetApi()
        {
            return new D3DCompiler(CreateDefaultContext(new D3DCompilerLibraryNameContainer().GetLibraryNames()));
        }

        public bool TryGetExtension<T>(out T ext)
            where T:NativeExtension<D3DCompiler>
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

