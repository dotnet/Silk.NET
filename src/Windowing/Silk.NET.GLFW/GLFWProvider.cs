//
// This file is part of Silk.NET.
//
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;

namespace Silk.NET.GLFW
{
    /// <summary>
    /// Singleton providing easy GLFW implementation access.
    /// </summary>
    public static class GLFWProvider
    {
        /// <summary>
        /// Gets a GLFW interface implementation lazily.
        /// </summary>
        public static Lazy<GLFW> GLFW { get; internal set; } = new Lazy<GLFW>(() =>
        {
            var glfw = NET.GLFW.GLFW.GetAPI();
            glfw.Init();
            glfw.SetErrorCallback(NET.GLFW.GLFW.ErrorCallback);
            return glfw;
        });

        /// <summary>
        /// Unloads the loaded <see cref="GLFW"/> interface implementation.
        /// </summary>
        public static void Unload()
        {
            GLFW.Value.Terminate();
            GLFW = new Lazy<GLFW>(() =>
            {
                var glfw = NET.GLFW.GLFW.GetAPI();
                glfw.Init();
                glfw.SetErrorCallback(NET.GLFW.GLFW.ErrorCallback);
                return glfw;
            });
        }
    }
}
