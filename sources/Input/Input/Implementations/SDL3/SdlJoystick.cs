// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Input.SDL3;

internal class SdlJoystick : SdlDevice, IJoystick
{
    public SdlJoystick()
        : base() { }

    public override string Name => throw new NotImplementedException();

    public JoystickState State => throw new NotImplementedException();
}
