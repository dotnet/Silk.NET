// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.IO;
using Silk.NET.GLFW;
using Silk.NET.Windowing.Common;

namespace Silk.NET.Windowing.Desktop
{
    /// <summary>
    /// A GLFW-based backend.
    /// </summary>
    public class GlfwPlatform : ISilkPlatform
    {
        /// <inheritdoc />
        public bool IsApplicable
        {
            get
            {
                try {
                    Glfw.GetAPI(); // activate the class so we can determine if we can activate the class
                }
                catch (FileNotFoundException) {
                    return false;
                }

                return true;
            }
        }

        /// <inheritdoc />
        public IWindow GetWindow(WindowOptions options)
        {
            return new GlfwWindow(options);
        }
    }
}