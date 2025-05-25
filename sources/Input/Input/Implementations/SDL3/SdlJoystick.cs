// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Input.SDL3;

internal class SdlJoystick : SdlDevice, IJoystick
{
    public SdlJoystick(SdlInputBackend backend, uint joystick)
        : base(backend) { }

    public override IntPtr Id => throw new NotImplementedException();

    public override string Name => throw new NotImplementedException();

    public JoystickState State => throw new NotImplementedException();
}
