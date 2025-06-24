// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Input.SDL3;

internal class SdlJoystick : SdlDevice, IJoystick, ISdlDevice<SdlJoystick>
{
    public SdlJoystick(uint sdlDeviceId, SdlInputBackend backend) : base(sdlDeviceId, backend)
    {
    }
    public override string Name => Backend.Sdl.GetJoystickNameForID(SdlDeviceId).ReadToString();

    public static SdlJoystick CreateDevice(SdlInputBackend backend, uint sdlDeviceId) => throw new NotImplementedException();

    public JoystickState State => throw new NotImplementedException();
}
