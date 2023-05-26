// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Silk.NET.Input
{
    /// <summary>
    /// Contains handy extensions for fetching buttons on gamepads.
    /// </summary>
    public static class GamepadExtensions
    {
        private static Button FirstButton(IGamepad gamepad, ButtonName name) // now without the LINQ
        {
            foreach (var button in gamepad.Buttons)
            {
                if (button.Name == name)
                {
                    return button;
                }
            }

            throw new PlatformNotSupportedException("This button is not supported by the input backend.");
        }

        /// <summary>
        /// Gets the <see cref="ButtonName.A" /> button.
        /// </summary>
        public static Button A(this IGamepad gamepad) => FirstButton(gamepad, ButtonName.A);

        /// <summary>
        /// Gets the <see cref="ButtonName.B" /> button.
        /// </summary>
        public static Button B(this IGamepad gamepad) => FirstButton(gamepad, ButtonName.B);

        /// <summary>
        /// Gets the <see cref="ButtonName.X" /> button.
        /// </summary>
        public static Button X(this IGamepad gamepad) => FirstButton(gamepad, ButtonName.X);

        /// <summary>
        /// Gets the <see cref="ButtonName.Y" /> button.
        /// </summary>
        public static Button Y(this IGamepad gamepad) => FirstButton(gamepad, ButtonName.Y);

        /// <summary>
        /// Gets the <see cref="ButtonName.LeftBumper" /> button.
        /// </summary>
        public static Button LeftBumper(this IGamepad gamepad) => FirstButton(gamepad, ButtonName.LeftBumper);

        /// <summary>
        /// Gets the <see cref="ButtonName.RightBumper" /> button.
        /// </summary>
        public static Button RightBumper(this IGamepad gamepad) => FirstButton(gamepad, ButtonName.RightBumper);

        /// <summary>
        /// Gets the <see cref="ButtonName.Back" /> button.
        /// </summary>
        public static Button Back(this IGamepad gamepad) => FirstButton(gamepad, ButtonName.Back);

        /// <summary>
        /// Gets the <see cref="ButtonName.Start" /> button.
        /// </summary>
        public static Button Start(this IGamepad gamepad) => FirstButton(gamepad, ButtonName.Start);

        /// <summary>
        /// Gets the <see cref="ButtonName.Home" /> button.
        /// </summary>
        public static Button Home(this IGamepad gamepad) => FirstButton(gamepad, ButtonName.Home);

        /// <summary>
        /// Gets the <see cref="ButtonName.LeftStick" /> button.
        /// </summary>
        [Obsolete($"This method is obsolete! Use {nameof(LeftThumbstickButton)}")]
        public static Button LeftStick(this IGamepad gamepad) => FirstButton(gamepad, ButtonName.LeftStick);

        /// <summary>
        /// Gets the <see cref="ButtonName.RightStick" /> button.
        /// </summary>
        [Obsolete($"This method is obsolete! Use {nameof(RightThumbstickButton)}")]
        public static Button RightStick(this IGamepad gamepad) => FirstButton(gamepad, ButtonName.RightStick);
        
        /// <summary>
        /// Gets the left <see cref="Thumbstick"/>.
        /// </summary>
        /// <remarks>
        /// If the input backend does not support this thumbstick, a <see cref="IndexOutOfRangeException"/> will be thrown.
        /// </remarks>
        public static Thumbstick LeftThumbstick(this IGamepad gamepad) => gamepad.Thumbsticks[0];
        
        /// <summary>
        /// Gets the right <see cref="Thumbstick"/>.
        /// </summary>
        /// <remarks>
        /// If the input backend does not support this thumbstick, a <see cref="IndexOutOfRangeException"/> will be thrown.
        /// </remarks>
        public static Thumbstick RightThumbstick(this IGamepad gamepad) => gamepad.Thumbsticks[1];
        
        /// <summary>
        /// Gets the <see cref="ButtonName.LeftStick" /> button.
        /// </summary>
        public static Button LeftThumbstickButton(this IGamepad gamepad) => FirstButton(gamepad, ButtonName.LeftStick);

        /// <summary>
        /// Gets the <see cref="ButtonName.RightStick" /> button.
        /// </summary>
        public static Button RightThumbstickButton(this IGamepad gamepad) => FirstButton(gamepad, ButtonName.RightStick);

        /// <summary>
        /// Gets the <see cref="ButtonName.DPadUp" /> button.
        /// </summary>
        public static Button DPadUp(this IGamepad gamepad) => FirstButton(gamepad, ButtonName.DPadUp);

        /// <summary>
        /// Gets the <see cref="ButtonName.DPadRight" /> button.
        /// </summary>
        public static Button DPadRight(this IGamepad gamepad) => FirstButton(gamepad, ButtonName.DPadRight);

        /// <summary>
        /// Gets the <see cref="ButtonName.DPadDown" /> button.
        /// </summary>
        public static Button DPadDown(this IGamepad gamepad) => FirstButton(gamepad, ButtonName.DPadDown);

        /// <summary>
        /// Gets the <see cref="ButtonName.DPadLeft" /> button.
        /// </summary>
        public static Button DPadLeft(this IGamepad gamepad) => FirstButton(gamepad, ButtonName.DPadLeft);
    }
}
