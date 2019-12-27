// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.GLFW;
using Silk.NET.Input.Common;

namespace Silk.NET.Input.Desktop
{
    /// <summary>
    /// A GLFW-based mouse cursor.
    /// </summary>
    public class GlfwCursor : ICursor
    {
        /// <inheritdoc />
        public int HotspotX { get; set; }
        
        /// <inheritdoc />
        public int HotspotY { get; set; }
        
        /// <inheritdoc />
        public int Width { get; set; }
        
        /// <inheritdoc />
        public int Height { get; set; }
        
        /// <inheritdoc />
        public byte[] Pixels { get; set; }
        
        /// <inheritdoc />
        public bool IsCursorModeSupported(CursorMode mode)
        {
            return mode switch
            {
                CursorMode.Normal => true,
                CursorMode.Hidden => true,
                CursorMode.Disabled => true,
                CursorMode.Raw => GlfwProvider.GLFW.Value.RawMouseMotionSupported(),
                _ => false
            };
        }
    }
}
