// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.GLFW
{
    /// <summary>
    /// Attributes related to sticky keys and buttons.
    /// </summary>
    /// <seealso cref="IGlfw.SetInputMode(Window*,StickyAttributes,bool)" />
    /// <seealso cref="IGlfw.GetInputMode(Window*,StickyAttributes)" />
    public enum StickyAttributes
    {
        /// <summary>
        /// Specify whether keyboard input should be sticky or not.
        /// </summary>
        StickyKeys = 0x00033002,

        /// <summary>
        /// Specify whether mouse button input should be sticky or not.
        /// </summary>
        StickyMouseButtons = 0x00033003
    }
}