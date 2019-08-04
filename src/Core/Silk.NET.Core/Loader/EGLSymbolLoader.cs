// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Runtime.InteropServices;
using AdvancedDLSupport;
using AdvancedDLSupport.Loaders;

namespace Silk.NET.Core.Loader
{
    public class EGLSymbolLoader : ISymbolLoader
    {
        public static EGLSymbolLoader Loader { get; } = new EGLSymbolLoader();
        [NativeSymbols(Prefix = "egl")]
        public interface IEGL
        {
            IntPtr GetProcAddress(string name);
        }

        private static readonly string libExt = RuntimeInformation.IsOSPlatform(OSPlatform.OSX)
            ? ".dylib" : RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? ".dll" : ".so";
        private static readonly string lib = "libEGL" + libExt;

        private static readonly IEGL egl = new NativeLibraryBuilder(LibraryLoader.Options).ActivateInterface<IEGL>(lib);
 
        public IntPtr LoadSymbol(IntPtr library, string symbolName)
        {
            try
            {
                return PlatformLoaderBase.PlatformLoader.LoadSymbol(library, symbolName);
            }
            catch (SymbolLoadingException)
            {
                var ret = egl.GetProcAddress(symbolName);
                if (ret == IntPtr.Zero)
                {
                    throw new SymbolLoadingException("EGL: \"" + symbolName + "\" not found.");
                }

                return ret;
            }
        }
    }
}
