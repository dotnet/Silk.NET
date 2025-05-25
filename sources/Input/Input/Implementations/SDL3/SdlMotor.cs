// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Input.SDL3;

internal class SdlMotor(SdlGamepad gamepad, int freqIdx) : IMotor
{
    public float Speed
    {
        get => (float)gamepad.GetRumble(freqIdx) / ushort.MaxValue;
        set => gamepad.SetRumble(freqIdx, (ushort)(value * ushort.MaxValue));
    }
}
