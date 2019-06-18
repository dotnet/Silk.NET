// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.GLFW
{
    /// <summary>
    /// Singleton providing easy GLFW implementation access.
    /// </summary>
    public static class GlfwProvider
    {
        /// <summary>
        /// Gets a GLFW interface implementation lazily.
        /// </summary>
        public static Lazy<Glfw> GLFW { get; internal set; } = new Lazy<Glfw>(() =>
        {
            var glfw = Glfw.GetAPI();
            glfw.Init();
            glfw.SetErrorCallback(Glfw.ErrorCallback);
            return glfw;
        });

        /// <summary>
        /// Unloads the loaded <see cref="GLFW" /> interface implementation.
        /// </summary>
        public static void Unload()
        {
            GLFW.Value.Terminate();
            GLFW = new Lazy<Glfw>(() =>
            {
                var glfw = Glfw.GetAPI();
                glfw.Init();
                glfw.SetErrorCallback(Glfw.ErrorCallback);
                return glfw;
            });
        }
    }
}