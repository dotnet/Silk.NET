// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvQuantizationModes_")]
    public enum QuantizationModes : int
    {
        [NativeName("Name", "SpvQuantizationModesTRN")]
        Trn = 0x0,
        [NativeName("Name", "SpvQuantizationModesTRN_ZERO")]
        TrnZero = 0x1,
        [NativeName("Name", "SpvQuantizationModesRND")]
        Rnd = 0x2,
        [NativeName("Name", "SpvQuantizationModesRND_ZERO")]
        RndZero = 0x3,
        [NativeName("Name", "SpvQuantizationModesRND_INF")]
        RndInf = 0x4,
        [NativeName("Name", "SpvQuantizationModesRND_MIN_INF")]
        RndMinInf = 0x5,
        [NativeName("Name", "SpvQuantizationModesRND_CONV")]
        RndConv = 0x6,
        [NativeName("Name", "SpvQuantizationModesRND_CONV_ODD")]
        RndConvOdd = 0x7,
        [NativeName("Name", "SpvQuantizationModesMax")]
        Max = 0x7FFFFFFF,
    }
}
