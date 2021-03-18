// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.GLFW
{
    /// <summary>
    /// Attributes related to sticky keys and buttons.
    /// </summary>
    /// <seealso cref="IGlfw.SetInputMode(WindowHandle*,StickyAttributes,bool)" />
    /// <seealso cref="IGlfw.GetInputMode(WindowHandle*,StickyAttributes)" />
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