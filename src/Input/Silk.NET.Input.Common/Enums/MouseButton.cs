// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Input
{
    /// <summary>
    /// Represents the indices of the mouse buttons.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The number of buttons provided depends on the input backend currently being used.
    /// </para>
    /// </remarks>
    public enum MouseButton
    {
        /// <summary>
        /// Indicates the input backend was unable to determine a button name for the button in question, or it does not support it.
        /// </summary>
        Unknown = -1,

        /// <summary>
        /// The left mouse button.
        /// </summary>
        Left = 0,

        /// <summary>
        /// The right mouse button.
        /// </summary>
        Right,

        /// <summary>
        /// The middle mouse button.
        /// </summary>
        Middle,

        /// <summary>
        /// The fourth mouse button.
        /// </summary>
        Button4,

        /// <summary>
        /// The fifth mouse button.
        /// </summary>
        Button5,

        /// <summary>
        /// The sixth mouse button.
        /// </summary>
        Button6,

        /// <summary>
        /// The seventh mouse button.
        /// </summary>
        Button7,

        /// <summary>
        /// The eighth mouse button.
        /// </summary>
        Button8,

        /// <summary>
        /// The ninth mouse button.
        /// </summary>
        Button9,

        /// <summary>
        /// The tenth mouse button.
        /// </summary>
        Button10,

        /// <summary>
        /// The eleventh mouse button.
        /// </summary>
        Button11,

        /// <summary>
        /// The twelth mouse button.
        /// </summary>
        Button12
    }
}
