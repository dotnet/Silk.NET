// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_SWEEP_DIRECTION")]
    public enum SweepDirection : int
    {
        [Obsolete("Deprecated in favour of \"CounterClockwise\"")]
        [NativeName("Name", "D2D1_SWEEP_DIRECTION_COUNTER_CLOCKWISE")]
        SweepDirectionCounterClockwise = 0x0,
        [Obsolete("Deprecated in favour of \"Clockwise\"")]
        [NativeName("Name", "D2D1_SWEEP_DIRECTION_CLOCKWISE")]
        SweepDirectionClockwise = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_SWEEP_DIRECTION_FORCE_DWORD")]
        SweepDirectionForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_SWEEP_DIRECTION_COUNTER_CLOCKWISE")]
        CounterClockwise = 0x0,
        [NativeName("Name", "D2D1_SWEEP_DIRECTION_CLOCKWISE")]
        Clockwise = 0x1,
        [NativeName("Name", "D2D1_SWEEP_DIRECTION_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
