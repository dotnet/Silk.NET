// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.GLFW
{
    /// <summary>
    /// Attribute for setting <see cref="CursorModeValue" /> of the cursor.
    /// </summary>
    /// <seealso cref="IGlfw.SetInputMode(WindowHandle*,CursorStateAttribute,CursorModeValue)" />
    /// <seealso cref="IGlfw.GetInputMode(WindowHandle*,CursorStateAttribute)" />
    public enum CursorStateAttribute
    {
        /// <summary>
        /// Attribute for setting <see cref="CursorModeValue" /> of the cursor.
        /// </summary>
        Cursor = 0x00033001,
        /// <summary>
        /// Attribute for setting raw mouse motion of the cursor.
        /// </summary>
        RawMouseMotion = 0x00033005
    }
}