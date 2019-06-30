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
        /// Gets a dispatcher to the main GLFW thread.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Because many GLFW functions require they be run on the main thread, this is used as a workaround.
        /// </para>
        /// </remarks>
        public static Dispatcher ThreadDispatcher { get; internal set; }
        
        /// <summary>
        /// Gets a GLFW interface implementation lazily.
        /// </summary>
        public static Lazy<Glfw> GLFW { get; internal set; } = new Lazy<Glfw>(() =>
        {
            if (ThreadDispatcher == null) {
                ThreadDispatcher = new Dispatcher();
            }
            
            var glfw = Glfw.GetAPI();

            ThreadDispatcher.Invoke(() =>
            {
                glfw.Init();
                glfw.SetErrorCallback(Glfw.ErrorCallback);
            });
            
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

                ThreadDispatcher.Invoke(() =>
                {
                    glfw.Init();
                    glfw.SetErrorCallback(Glfw.ErrorCallback);
                });
                
                return glfw;
            });
        }
    }
}