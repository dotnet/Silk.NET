// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3;

internal sealed class SdlGenericJoystick : SdlJoystick, ISdlDevice<SdlGenericJoystick>
{
    public SdlGenericJoystick(uint sdlDeviceId, SdlInputBackend backend) : base(sdlDeviceId, backend)
    {
        if (JoystickType == JoystickType.Gamepad)
        {
            throw new Exception("Joystick should have been created as a gamepad, not a joystick.");
        }
    }

    public static SdlGenericJoystick CreateDevice(SdlInputBackend backend, uint sdlDeviceId) => throw new NotImplementedException();
}

/// <summary>
/// provides the IGamepad implementation for a joystick
/// </summary>
internal sealed class SdlGamepad : SdlJoystick, IGamepad, ISdlDevice<SdlGamepad>
{
    public SdlGamepad(uint sdlDeviceId, SdlInputBackend backend) : base(sdlDeviceId, backend)
    {
        var _gamepad = NativeBackend.OpenGamepad(sdlDeviceId);
        if (_gamepad == nullptr)
        {
            NativeBackend.ThrowError();
        }

        _gamepadState = new GamepadState(new ButtonReadOnlyList<JoystickButton>(Buttons), thumbsticks, triggers);
    }

    protected override void Release() => NativeBackend.CloseGamepad(_gamepad);

    private readonly GamepadState _gamepadState;
    GamepadState IGamepad.State => _gamepadState;

    public override string Name => NativeBackend.GetGamepadNameForID(SdlDeviceId).ReadToString();

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
            !NativeBackend.RumbleGamepad(
                _gamepad,
                _motorFrequencies[0],
                _motorFrequencies[1],
                uint.MaxValue
            )
        )
        {
            NativeBackend.ThrowError();
        }
    }

    public static SdlGamepad CreateDevice(SdlInputBackend backend, uint sdlDeviceId) => new(sdlDeviceId, backend);

    ~SdlGamepad() => Release();

    public void AddButtonEvent(GamepadButtonEvent sdlButton)
    {
        ProcessButtonEvent(this, sdlButton.Button, sdlButton.Down);
    }

    private static void ProcessButtonEvent<T>(T device, byte sdlButtonId, byte sdlButtonDown) where T : SdlJoystick, ISdlDevice<T>
    {
    }

}
