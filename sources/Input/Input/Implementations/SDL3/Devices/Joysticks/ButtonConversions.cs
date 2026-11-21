// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Input.SDL3.DataStructures;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.Devices.Joysticks;

internal static class ButtonConversions
{
    extension(GamepadButton buttonIndex)
    {
        private JoystickButton AsSilkJoystickButton() =>
            buttonIndex switch {
                GamepadButton.South => JoystickButton.ButtonDown,
                GamepadButton.East => JoystickButton.ButtonRight,
                GamepadButton.West => JoystickButton.ButtonLeft,
                GamepadButton.North => JoystickButton.ButtonUp,
                GamepadButton.Back => JoystickButton.Back,
                GamepadButton.Guide => JoystickButton.Home,
                GamepadButton.Start => JoystickButton.Start,
                GamepadButton.LeftStick => JoystickButton.LeftStick,
                GamepadButton.RightStick => JoystickButton.RightStick,
                GamepadButton.LeftShoulder => JoystickButton.LeftBumper,
                GamepadButton.RightShoulder => JoystickButton.RightBumper,
                GamepadButton.DpadUp => JoystickButton.DPadUp,
                GamepadButton.DpadDown => JoystickButton.DPadDown,
                GamepadButton.DpadLeft => JoystickButton.DPadLeft,
                GamepadButton.DpadRight => JoystickButton.DPadRight,
                _ => (JoystickButton)buttonIndex
            };

        /// <summary>
        /// Returns the <see cref="JoystickButton"/> and index for the given <see cref="GamepadButton"/>.
        /// When returning false, out parameters are undefined.
        /// </summary>
        private bool TryGetJoystickButton(int availableLength, out JoystickButton joystickButton, out int idx)
        {
            joystickButton = buttonIndex.AsSilkJoystickButton();
            idx = joystickButton.Index();
            if (idx < 0)
            {
                InputLog.Error("Received an invalid SDL button??");
                return false;
            }

            if (idx >= availableLength)
            {
                InputLog.Error($"Received an out of range button index {idx} - {buttonIndex} ({joystickButton}). " +
                               $"Available length: {availableLength}");
                return false;
            }

            return true;
        }
    }


    /// <summary>
    /// Final registration of a button press into the gamepad's internal state.
    /// </summary>
    /// <param name="device">The device that the button was pressed on.</param>
    /// <param name="button">The button that was pressed.</param>
    /// <param name="isDown">Whether the button was pressed or released.</param>
    /// <param name="timestamp">The timestamp from <see cref="InputContext"/>.</param>
    /// <param name="rawButtonState">The button state array, modified within this method</param>
    /// <param name="buttonEvents">The button event queue this method pushes events to.</param>
    public static void UpdateFromGamepadButton(IButtonDevice<JoystickButton> device, GamepadButton button, bool isDown,
        long timestamp, Button<JoystickButton>[] rawButtonState,
        SdlInputEventQueue<ButtonChangedEvent<JoystickButton>> buttonEvents)
    {
        if (!button.TryGetJoystickButton(rawButtonState.Length, out var asJoystickButton, out var idx))
        {
            return;
        }

        ref var buttonState = ref rawButtonState[idx];

        var previous = buttonState;

        buttonState = new Button<JoystickButton>(asJoystickButton, isDown, isDown ? 1 : 0);

        // ReSharper disable once CompareOfFloatsByEqualityOperator
        if (previous.IsDown != buttonState.IsDown || previous.Pressure != buttonState.Pressure)
        {
            buttonEvents.Enqueue(new ButtonChangedEvent<JoystickButton>(device, timestamp, buttonState, previous));
        }
    }
}
