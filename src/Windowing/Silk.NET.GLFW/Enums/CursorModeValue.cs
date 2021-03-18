// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.GLFW
{
    /// <summary>
    /// The GLFW cursor modes.
    /// See <a href="https://www.glfw.org/docs/latest/input_guide.html#cursor_mode">cursor modes</a>.
    /// </summary>
    public enum CursorModeValue
    {
        /// <summary>
        /// The regular arrow cursor (or another cursor set with <see cref="IGlfw.SetCursor" />) is used
        /// and cursor motion is not limited.
        /// </summary>
        CursorNormal = 0x00034001,

        /// <summary>
        /// Hides the arrow cursor when over a window.
        /// </summary>
        CursorHidden = 0x00034002,

        /// <summary>
        /// Will hide the cursor and lock it to the specified window.
        /// GLFW will then take care of all the details of cursor re-centering and offset calculation
        /// and providing the application with a virtual cursor position.
        /// This virtual position is provided normally via both the cursor position callback and through polling.
        /// </summary>
        CursorDisabled = 0x00034003
    }
}