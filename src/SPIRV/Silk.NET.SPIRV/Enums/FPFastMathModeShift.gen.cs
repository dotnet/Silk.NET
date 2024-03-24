// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [Flags]
    [NativeName("Name", "SpvFPFastMathModeShift_")]
    public enum FPFastMathModeShift : int
    {
        [NativeName("Name", "SpvFPFastMathModeNotNaNShift")]
        NotNaNShift = 0x0,
        [NativeName("Name", "SpvFPFastMathModeNotInfShift")]
        NotInfShift = 0x1,
        [NativeName("Name", "SpvFPFastMathModeNSZShift")]
        NszShift = 0x2,
        [NativeName("Name", "SpvFPFastMathModeAllowRecipShift")]
        AllowRecipShift = 0x3,
        [NativeName("Name", "SpvFPFastMathModeFastShift")]
        FastShift = 0x4,
        [NativeName("Name", "SpvFPFastMathModeAllowContractShift")]
        AllowContractShift = 0x10,
        [NativeName("Name", "SpvFPFastMathModeAllowContractFastINTELShift")]
        AllowContractFastIntelShift = 0x10,
        [NativeName("Name", "SpvFPFastMathModeAllowReassocShift")]
        AllowReassocShift = 0x11,
        [NativeName("Name", "SpvFPFastMathModeAllowReassocINTELShift")]
        AllowReassocIntelShift = 0x11,
        [NativeName("Name", "SpvFPFastMathModeAllowTransformShift")]
        AllowTransformShift = 0x12,
        [NativeName("Name", "SpvFPFastMathModeMax")]
        Max = 0x7FFFFFFF,
    }
}
