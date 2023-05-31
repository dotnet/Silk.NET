// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvFPRoundingMode_")]
    public enum FPRoundingMode : int
    {
        [NativeName("Name", "SpvFPRoundingModeRTE")]
        Rte = 0x0,
        [NativeName("Name", "SpvFPRoundingModeRTZ")]
        Rtz = 0x1,
        [NativeName("Name", "SpvFPRoundingModeRTP")]
        Rtp = 0x2,
        [NativeName("Name", "SpvFPRoundingModeRTN")]
        Rtn = 0x3,
        [NativeName("Name", "SpvFPRoundingModeMax")]
        Max = 0x7FFFFFFF,
    }
}
