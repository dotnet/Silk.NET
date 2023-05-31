// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvOverflowModes_")]
    public enum OverflowModes : int
    {
        [NativeName("Name", "SpvOverflowModesWRAP")]
        Wrap = 0x0,
        [NativeName("Name", "SpvOverflowModesSAT")]
        Sat = 0x1,
        [NativeName("Name", "SpvOverflowModesSAT_ZERO")]
        SatZero = 0x2,
        [NativeName("Name", "SpvOverflowModesSAT_SYM")]
        SatSym = 0x3,
        [NativeName("Name", "SpvOverflowModesMax")]
        Max = 0x7FFFFFFF,
    }
}
