// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.GLFW;
using Silk.NET.Windowing.Common;

namespace Silk.NET.Windowing.Desktop
{
    /// <summary>
    /// A GLFW-based backend.
    /// </summary>
    public class GlfwPlatform : IWindowPlatform
    {
        private GlfwPlatform()
        {
        }
        
        /// <summary>
        /// Gets this instance of the windowing platform.
        /// </summary>
        public static GlfwPlatform Instance { get; } = new GlfwPlatform();
        
        /// <inheritdoc />
        public bool IsViewOnly { get; } = false;

        /// <inheritdoc />
        public bool IsApplicable
        {
            get
            {
                try {
                    Glfw.GetApi(); // activate the class so we can determine if we can activate the class
                }
                catch {
                    return false;
                }

                return true;
            }
        }

        /// <inheritdoc />
        public IWindow CreateWindow(WindowOptions options) => new GlfwWindow(options);

        /// <inheritdoc />
        public IView GetView(ViewOptions? opts = null) => CreateWindow(new WindowOptions(opts ?? ViewOptions.Default));
    }
}