// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Runtime.InteropServices;
using AdvancedDLSupport;
using AdvancedDLSupport.Loaders;
using Silk.NET.Core.Loader;
using Silk.NET.GLFW;

namespace Silk.NET.Windowing.Desktop
{
    public class GlfwLoader : IGLSymbolLoader
    {
        private ISymbolLoader _underlyingLoader = PlatformLoaderBase.PlatformLoader;

        public IntPtr LoadSymbol(IntPtr library, string symbolName)
        {
            try
            {
                return _underlyingLoader.LoadSymbol(library, symbolName);
            }
            catch (SymbolLoadingException)
            {
                IntPtr ret;
                try
                {
                    ret = GlfwProvider.GLFW.Value.GetProcAddress(symbolName);
                }
                catch (GlfwException ex)
                {
                    if (ex.ErrorCode == ErrorCode.NoContext)
                    {
                        // give a more helpful error message
                        throw new InvalidOperationException
                        (
                            "An OpenGL context isn't current on this thread. If you're using Silk.NET.Windowing, you" +
                            "can access the render thread via the Invoke method on IWindow.",
                            ex
                        );
                    }

                    throw;
                }

                if (ret == IntPtr.Zero)
                {
                    throw new SymbolLoadingException
                    (
                        $"GLFW: \"{symbolName}\" not found."
                    );
                }

                return ret;
            }
        }
    }
}
