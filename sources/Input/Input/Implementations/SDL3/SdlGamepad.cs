// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3;

internal class SdlGamepad : SdlDevice, IGamepad, IDisposable
{
    private readonly GamepadHandle _gamepad;

    private static JoystickButton? GetSilkButton(GamepadButton btn) =>
        btn switch
        {
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
            // TODO not exposed today
            _ => null,
        };

    public SdlGamepad(SdlInputBackend backend, uint joystickId)
        : base(backend)
    {
        _gamepad = backend.Sdl.OpenGamepad(joystickId);
        if (_gamepad == nullptr)
        {
            backend.Sdl.ThrowError();
        }

        var buttons = InputMarshal.CreateList<Button<JoystickButton>>();
        for (var i = 0; i < (int)GamepadButton.Count; i++)
        {
            if (GetSilkButton((GamepadButton)i) is not { } btn)
            {
                continue;
            }

            var isDown = backend.Sdl.GetGamepadButton(_gamepad, (GamepadButton)i);
            InputMarshal.SetButtonState(
                buttons,
                new Button<JoystickButton>(btn, isDown, isDown ? 1 : 0),
                true
            );
        }

        // For thumbsticks, the state is a value ranging from -32768 (up/left) to 32767 (down/right).
        // Triggers range from 0 when released to 32767 when fully pressed, and never return a negative value. Note that
        // this differs from the value reported by the lower-level SDL_GetJoystickAxis(), which normally uses the full
        // range.
        var triggers = new DualReadOnlyList<float>(
            (float)backend.Sdl.GetGamepadAxis(_gamepad, GamepadAxis.LeftTrigger) / short.MaxValue,
            (float)backend.Sdl.GetGamepadAxis(_gamepad, GamepadAxis.RightTrigger) / short.MaxValue
        );
        var thumbsticks = new DualReadOnlyList<Vector2>(
            new Vector2(
                (float)backend.Sdl.GetGamepadAxis(_gamepad, GamepadAxis.Leftx) / short.MaxValue,
                (float)backend.Sdl.GetGamepadAxis(_gamepad, GamepadAxis.Lefty) / short.MaxValue
            ),
            new Vector2(
                (float)backend.Sdl.GetGamepadAxis(_gamepad, GamepadAxis.Rightx) / short.MaxValue,
                (float)backend.Sdl.GetGamepadAxis(_gamepad, GamepadAxis.Righty) / short.MaxValue
            )
        );
        State = new GamepadState(buttons.List.AsButtonList(), thumbsticks, triggers);
    }

    // TODO this is not spec compliant, we need to use a physical device ID
    public override unsafe nint Id => (nint)_gamepad.Handle;

    public override string Name => Backend.Sdl.GetGamepadName(_gamepad).ReadToString();

    public GamepadState State { get; }

    // TODO this entire API needs to be redesigned as right now this is literally only ever going to be useful if it's
    // just left or right. The original intention was that this would be useful for things like 3D haptics, but what did
    // I know. The SDL people seem to have done a good job with their haptic API, let's see what we can do with it.
    // For now, this has the same implementation as it always has.
    public IReadOnlyList<IMotor> VibrationMotors =>
        _motors ??= [new SdlMotor(this, 0), new SdlMotor(this, 1)];

    private IMotor[]? _motors;
    private ushort[]? _motorFrequencies;

    internal ushort GetRumble(int motor) => (_motorFrequencies ??= [0, 0])[motor];

    internal void SetRumble(int motor, ushort value)
    {
        (_motorFrequencies ??= [0, 0])[motor] = value;
        if (
            !Backend.Sdl.RumbleGamepad(
                _gamepad,
                _motorFrequencies[0],
                _motorFrequencies[1],
                uint.MaxValue
            )
        )
        {
            Backend.Sdl.ThrowError();
        }
    }

    private void ReleaseUnmanagedResources() => Backend.Sdl.CloseGamepad(_gamepad);

    public void Dispose()
    {
        ReleaseUnmanagedResources();
        GC.SuppressFinalize(this);
    }

    ~SdlGamepad() => ReleaseUnmanagedResources();
}
