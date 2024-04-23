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
        static D3DCompiler()
        {
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                var loader = LibraryLoader.GetPlatformDefaultLoader();
                //d3dcompile_vkd3d on linux has a shared dependency on SPIRV-Tools, so register it
                loader.RegisterDependencies("libSPIRV-Tools-shared.so");
            }
        }

        public static D3DCompiler GetApi()
        {
            return new D3DCompiler(CreateDefaultContext(new D3DCompilerLibraryNameContainer().GetLibraryNames()));
        }

        public bool TryGetExtension<T>(out T ext)
            where T:NativeExtension<D3DCompiler>
        {
            throw new NotImplementedException();
        }

        public override bool IsExtensionPresent(string extension)
        {
            throw new NotImplementedException();
        }
    }
}

