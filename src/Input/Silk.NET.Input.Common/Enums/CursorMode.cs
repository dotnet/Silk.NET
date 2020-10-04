// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Input.Common
{
    /// <summary>
    /// Mode used by a cursor.
    /// </summary>
    /// <remarks>
    /// Not every backend supports every cursor mode. Check availability with
    /// <see cref="ICursor.IsSupported(CursorMode)"/> before changing the cursor mode.
    /// </remarks>
    public enum CursorMode
    {
        /// <summary>
        /// Cursor is visible and has no restrictions on mobility.
        /// </summary>
        Normal,

        /// <summary>
        /// Cursor is invisible, and has no restrictions on mobility.
        /// </summary>
        Hidden,

        /// <summary>
        /// Cursor is invisible, and is restricted to the center of the screen.
        /// </summary>
        Disabled,

        /// <summary>
        /// Cursor is invisible, and is restricted to the center of the screen. Mouse motion is not scaled.
        /// </summary>
        Raw
    }
}
