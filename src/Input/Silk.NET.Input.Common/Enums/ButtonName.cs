// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Input.Common
{
    /// <summary>
    /// The different names a <see cref="Button"/> can have.
    /// </summary>
    public enum ButtonName
    {
        /// <summary>
        /// Indicates that the input backend was unable to determine a button name for the button in question, or it does not support it.
        /// </summary>
        Unknown = -1,

        /// <summary>
        /// The A button.
        /// </summary>
        A = 0,

        /// <summary>
        /// The B button.
        /// </summary>
        B,

        /// <summary>
        /// The X button.
        /// </summary>
        X,

        /// <summary>
        /// The Y button.
        /// </summary>
        Y,

        /// <summary>
        /// The left bumper.
        /// </summary>
        LeftBumper,

        /// <summary>
        /// The right bumper.
        /// </summary>
        RightBumper,

        /// <summary>
        /// The back button.
        /// </summary>
        Back,

        /// <summary>
        /// The start button.
        /// </summary>
        Start,

        /// <summary>
        /// The home button.
        /// </summary>
        Home,

        /// <summary>
        /// Clicking the left stick.
        /// </summary>
        LeftStick,

        /// <summary>
        /// Clicking the right stick.
        /// </summary>
        RightStick,

        /// <summary>
        /// Up on the D-Pad.
        /// </summary>
        DPadUp,

        /// <summary>
        /// Right on the D-Pad.
        /// </summary>
        DPadRight,

        /// <summary>
        /// Down on the D-Pad.
        /// </summary>
        DPadDown,

        /// <summary>
        /// Left on the D-Pad.
        /// </summary>
        DPadLeft
    }
}
