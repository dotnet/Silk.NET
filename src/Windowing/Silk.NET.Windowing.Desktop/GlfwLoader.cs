// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.GLFW;
using Ultz.SuperInvoke.Loader;

namespace Silk.NET.Windowing.Desktop
{
    public class GlfwLoader : GLSymbolLoader
    {
        protected override IntPtr CoreLoadFunctionPointer(IntPtr library, string symbolName)
        {
            try
            {
                return UnderlyingLoader.LoadFunctionPointer(library, symbolName);
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
