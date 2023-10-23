// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [Flags]
    [NativeName("Name", "SpvFPFastMathModeMask_")]
    public enum FPFastMathModeMask : int
    {
        [NativeName("Name", "SpvFPFastMathModeMaskNone")]
        MaskNone = 0x0,
        [NativeName("Name", "SpvFPFastMathModeNotNaNMask")]
        NotNaNMask = 0x1,
        [NativeName("Name", "SpvFPFastMathModeNotInfMask")]
        NotInfMask = 0x2,
        [NativeName("Name", "SpvFPFastMathModeNSZMask")]
        NszMask = 0x4,
        [NativeName("Name", "SpvFPFastMathModeAllowRecipMask")]
        AllowRecipMask = 0x8,
        [NativeName("Name", "SpvFPFastMathModeFastMask")]
        FastMask = 0x10,
        [NativeName("Name", "SpvFPFastMathModeAllowContractFastINTELMask")]
        AllowContractFastIntelMask = 0x10000,
        [NativeName("Name", "SpvFPFastMathModeAllowReassocINTELMask")]
        AllowReassocIntelMask = 0x20000,
    }
}
