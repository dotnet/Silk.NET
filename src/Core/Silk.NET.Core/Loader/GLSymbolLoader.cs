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
    public class GLSymbolLoader : ISymbolLoader
    {
        public delegate IntPtr GetProcAddress(string name);
        public static GLSymbolLoader Loader { get; } = new GLSymbolLoader();
        private IPlatformLoader _underlyingLoader = PlatformLoaderBase.PlatformLoader;
        private string _underlyingFunction = RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
            ? "wglGetProcAddress"
            : "glXGetProcAddress";
        private GetProcAddress _getProcAddress;
        public IntPtr LoadSymbol(IntPtr library, string symbolName)
        {
            try
            {
                return _underlyingLoader.LoadSymbol(library, symbolName);
            }
            catch (SymbolLoadingException)
            {
                _getProcAddress ??= Marshal.GetDelegateForFunctionPointer<GetProcAddress>
                (
                    _underlyingLoader.LoadSymbol(library, _underlyingFunction)
                );
                var ret = _getProcAddress(symbolName);
                if (ret == IntPtr.Zero)
                {
                    throw new SymbolLoadingException
                    (
                        $"{_underlyingFunction.Substring(0, 3).ToUpper()}: \"{symbolName}\" not found"
                    );
                }

                return ret;
            }
        }
    }
}
