// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Silk.NET.Core.Loader;
using Ultz.SuperInvoke.Loader;

namespace Silk.NET.GLFW
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

namespace Silk.NET.Windowing.Desktop
{
    [Obsolete
    (
        "GlfwLoader has been moved to the Silk.NET.GLFW namespace, and this pass-through class will be removed " +
        "in a future release."
    )]
    public class GlfwLoader : Silk.NET.GLFW.GlfwLoader
    {
    }
}
