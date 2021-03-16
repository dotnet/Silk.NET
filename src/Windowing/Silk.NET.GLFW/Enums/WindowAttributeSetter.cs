// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.GLFW
{
    /// <summary>
    /// Used to set window related attributes.
    /// </summary>
    /// <seealso cref="IGlfw.SetWindowAttrib" />
    public enum WindowAttributeSetter
    {
        /// <summary>
        /// Indicates whether the specified window is resizable by the user.
        /// This is set on creation with the window hint with the same name.
        /// </summary>
        Resizable = WindowHintBool.Resizable,

        /// <summary>
        /// Indicates whether the specified window has decorations such as a border,a close widget, etc.
        /// This is set on creation with the window hint with the same name.
        /// </summary>
        Decorated = WindowHintBool.Decorated,

        /// <summary>
        /// Specifies whether the full screen window will automatically iconify and restore
        /// the previous video mode on input focus loss.
        /// Possible values are <c>true</c> and <c>false</c>. This hint is ignored for windowed mode windows.
        /// </summary>
        AutoIconify = WindowHintBool.AutoIconify,

        /// <summary>
        /// Indicates whether the specified window is floating, also called topmost or always-on-top.
        /// This is controlled by the window hint with the same name.
        /// </summary>
        Floating = WindowHintBool.Floating,

        /// <summary>
        /// Specifies whether the window will be given input focus when <see cref="IGlfw.ShowWindow" /> is called.
        /// Possible values are <c>true</c> and <c>false</c>.
        /// </summary>
        FocusOnShow = WindowHintBool.FocusOnShow
    }
}