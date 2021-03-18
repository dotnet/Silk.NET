// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Input
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
        /// <remarks>
        /// Only supported by GLFW, throws on SDL if used.
        /// </remarks>
        Disabled,

        /// <summary>
        /// Cursor is invisible, and is restricted to the center of the screen. Mouse motion is not scaled.
        /// </summary>
        Raw
    }
}
