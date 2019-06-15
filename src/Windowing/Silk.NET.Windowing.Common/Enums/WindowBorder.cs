//
// This file is part of Silk.NET.
//
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace Silk.NET.Windowing.Common
{
    /// <summary>
    /// Represents the window border.
    /// </summary>
    public enum WindowBorder
    {
        /// <summary>
        /// The window can be resized by grabbing its border.
        /// </summary>
        Resizable = 0,

        /// <summary>
        /// The window border is visible, but cannot be resized. All window-resizings must happen solely in the code.
        /// </summary>
        Fixed,

        /// <summary>
        /// The window border is hidden.
        /// </summary>
        Hidden,
    }
}