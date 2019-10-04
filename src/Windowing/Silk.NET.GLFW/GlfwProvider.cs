// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Ultz.Dispatcher;

namespace Silk.NET.GLFW
{
    /// <summary>
    /// Singleton providing easy GLFW implementation access.
    /// </summary>
    public static class GlfwProvider
    {
        /// <summary>
        /// Creates a new instance of the GlfwProvider class.
        /// </summary>
        static GlfwProvider()
        {
            GLFW = new Lazy<Glfw>
            (
                () =>
                {

                    var glfw = Glfw.GetApi();
                    glfw.Init();
                    glfw.SetErrorCallback(Glfw.ErrorCallback);

                    return glfw;
                }
            );
        }
        /// <summary>
        /// Gets a GLFW interface implementation lazily.
        /// </summary>
        public static Lazy<Glfw> GLFW { get; internal set; }

        /// <summary>
        /// Unloads the loaded <see cref="GLFW" /> interface implementation.
        /// </summary>
        public static void Unload()
        {
            GLFW.Value.Terminate();
            GLFW = new Lazy<Glfw>
            (
                () =>
                {
                    var glfw = Glfw.GetApi();
                    glfw.Init();
                    glfw.SetErrorCallback(Glfw.ErrorCallback);

                    return glfw;
                }
            );
        }
    }
}