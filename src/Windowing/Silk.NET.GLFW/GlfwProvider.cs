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
        /// Creates a new instance of the GlfwProvider class.
        /// </summary>
        static unsafe GlfwProvider()
        {
            UninitializedGLFW = new Lazy<Glfw>(Glfw.GetApi);
            GLFW = new Lazy<Glfw>(GetGlfw);
        }

        private static unsafe Glfw GetGlfw()
        {
            var glfw = UninitializedGLFW.Value;

            if (!glfw.Init())
            {
                var code = glfw.GetError(out var pDesc);
                var len = new ReadOnlySpan<byte>(pDesc, int.MaxValue).IndexOf((byte) '\0');
                var desc = len <= 0 ? "Unknown" : System.Text.Encoding.UTF8.GetString(pDesc, len);
                throw new GlfwException($"GLFW Init failed, {code}: {desc}");
            }

#if DEBUG
            Console.WriteLine("GLFW initialized");
#endif

            glfw.SetErrorCallback(Glfw.ErrorCallback);

            return glfw;
        }
        
        /// <summary>
        /// Gets a GLFW interface implementation lazily.
        /// </summary>
        public static Lazy<Glfw> UninitializedGLFW { get; internal set; }

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
            GLFW.Value.Dispose();
            UninitializedGLFW = new Lazy<Glfw>(Glfw.GetApi);
            GLFW = new Lazy<Glfw>(GetGlfw);
        }
    }
}
