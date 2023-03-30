// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_BREAK_CONDITION")]
    public enum BreakCondition : int
    {
        [NativeName("Name", "DWRITE_BREAK_CONDITION_NEUTRAL")]
        Neutral = 0x0,
        [NativeName("Name", "DWRITE_BREAK_CONDITION_CAN_BREAK")]
        CanBreak = 0x1,
        [NativeName("Name", "DWRITE_BREAK_CONDITION_MAY_NOT_BREAK")]
        MayNotBreak = 0x2,
        [NativeName("Name", "DWRITE_BREAK_CONDITION_MUST_BREAK")]
        MustBreak = 0x3,
    }
}
