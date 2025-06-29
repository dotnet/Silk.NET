// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3;

internal class SdlJoystick : SdlDevice, IJoystick, ISdlDevice<SdlJoystick>
{
    private readonly JoystickHandle _joystickHandle;
    private readonly JoystickType _joystickType;
    public SdlJoystick(uint sdlDeviceId, SdlInputBackend backend) : base(sdlDeviceId, backend)
    {
        _joystickHandle = backend.Sdl.OpenJoystick(sdlDeviceId);
        _joystickType = backend.Sdl.GetJoystickType(_joystickHandle);
        if (_joystickType == JoystickType.Gamepad)
        {
            throw new Exception("Joystick should have been created as a gamepad, not a joystick.");
        }
    }

    public override string Name => Backend.Sdl.GetJoystickNameForID(SdlDeviceId).ReadToString();
    public override void Release() => Backend.Sdl.CloseJoystick(_joystickHandle);

    public static SdlJoystick CreateDevice(SdlInputBackend backend, uint sdlDeviceId) => new(sdlDeviceId, backend);

    public JoystickState State => throw new NotImplementedException();
}
