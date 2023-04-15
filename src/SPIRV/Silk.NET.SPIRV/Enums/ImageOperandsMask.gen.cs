// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [Flags]
    [NativeName("Name", "SpvImageOperandsMask_")]
    public enum ImageOperandsMask : int
    {
        [NativeName("Name", "SpvImageOperandsMaskNone")]
        MaskNone = 0x0,
        [NativeName("Name", "SpvImageOperandsBiasMask")]
        BiasMask = 0x1,
        [NativeName("Name", "SpvImageOperandsLodMask")]
        LodMask = 0x2,
        [NativeName("Name", "SpvImageOperandsGradMask")]
        GradMask = 0x4,
        [NativeName("Name", "SpvImageOperandsConstOffsetMask")]
        ConstOffsetMask = 0x8,
        [NativeName("Name", "SpvImageOperandsOffsetMask")]
        OffsetMask = 0x10,
        [NativeName("Name", "SpvImageOperandsConstOffsetsMask")]
        ConstOffsetsMask = 0x20,
        [NativeName("Name", "SpvImageOperandsSampleMask")]
        SampleMask = 0x40,
        [NativeName("Name", "SpvImageOperandsMinLodMask")]
        MinLodMask = 0x80,
        [NativeName("Name", "SpvImageOperandsMakeTexelAvailableMask")]
        MakeTexelAvailableMask = 0x100,
        [NativeName("Name", "SpvImageOperandsMakeTexelAvailableKHRMask")]
        MakeTexelAvailableKhrMask = 0x100,
        [NativeName("Name", "SpvImageOperandsMakeTexelVisibleMask")]
        MakeTexelVisibleMask = 0x200,
        [NativeName("Name", "SpvImageOperandsMakeTexelVisibleKHRMask")]
        MakeTexelVisibleKhrMask = 0x200,
        [NativeName("Name", "SpvImageOperandsNonPrivateTexelMask")]
        NonPrivateTexelMask = 0x400,
        [NativeName("Name", "SpvImageOperandsNonPrivateTexelKHRMask")]
        NonPrivateTexelKhrMask = 0x400,
        [NativeName("Name", "SpvImageOperandsVolatileTexelMask")]
        VolatileTexelMask = 0x800,
        [NativeName("Name", "SpvImageOperandsVolatileTexelKHRMask")]
        VolatileTexelKhrMask = 0x800,
        [NativeName("Name", "SpvImageOperandsSignExtendMask")]
        SignExtendMask = 0x1000,
        [NativeName("Name", "SpvImageOperandsZeroExtendMask")]
        ZeroExtendMask = 0x2000,
        [NativeName("Name", "SpvImageOperandsNontemporalMask")]
        NontemporalMask = 0x4000,
        [NativeName("Name", "SpvImageOperandsOffsetsMask")]
        OffsetsMask = 0x10000,
    }
}
