// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.GLFW
{
    /// <summary>
    /// Initialization hints are set before <see cref="IGlfw.Init" /> and affect how the library behaves until termination.
    /// Hints are set with <see cref="InitHint" />.
    /// </summary>
    public enum InitHint
    {
        /// <summary>
        /// Used to specify whether to also expose joystick hats as buttons,
        /// for compatibility with earlier versions of GLFW that did not have
        /// <see cref="IGlfw.GetJoystickHats" />.
        /// Set this with <see cref="InitHint" />.
        /// </summary>
        JoystickHatButtons = 0x00050001,

        /// <summary>
        /// Used to specify whether to set the current directory to the application to the Contents/Resources
        /// subdirectory of the application's bundle, if present.
        /// Set this with <see cref="InitHint" />.
        /// </summary>
        /// <remarks>
        /// Only affects macOS; no effect on other platforms.
        /// </remarks>
        CocoaChdirResources = 0x00051001,

        /// <summary>
        /// Used to specify whether to create a basic menu bar, either from a nib or manually,
        /// when the first window is created, which is when AppKit is initialized.
        /// Set this with <see cref="InitHint" />.
        /// </summary>
        /// <remarks>
        /// Only affects macOS; no effect on other platforms.
        /// </remarks>
        CocoaMenubar = 0x00051002
    }
}