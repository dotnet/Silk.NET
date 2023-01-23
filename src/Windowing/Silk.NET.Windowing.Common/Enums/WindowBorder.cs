// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Windowing
{
    /// <summary>
    /// Represents the window border.
    /// </summary>
    public enum WindowBorder
    {
        /// <summary>
        /// The window can be resized by clicking and dragging its border.
        /// </summary>
        Resizable = 0,

        /// <summary>
        /// The window border is visible, but cannot be resized. All window-resizings must happen solely in the code.
        /// </summary>
        Fixed,

        /// <summary>
        /// The window border is hidden.
        /// </summary>
        Hidden
    }
}