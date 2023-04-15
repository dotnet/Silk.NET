// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvImageOperandsShift_")]
    public enum ImageOperandsShift : int
    {
        [NativeName("Name", "SpvImageOperandsBiasShift")]
        BiasShift = 0x0,
        [NativeName("Name", "SpvImageOperandsLodShift")]
        LodShift = 0x1,
        [NativeName("Name", "SpvImageOperandsGradShift")]
        GradShift = 0x2,
        [NativeName("Name", "SpvImageOperandsConstOffsetShift")]
        ConstOffsetShift = 0x3,
        [NativeName("Name", "SpvImageOperandsOffsetShift")]
        OffsetShift = 0x4,
        [NativeName("Name", "SpvImageOperandsConstOffsetsShift")]
        ConstOffsetsShift = 0x5,
        [NativeName("Name", "SpvImageOperandsSampleShift")]
        SampleShift = 0x6,
        [NativeName("Name", "SpvImageOperandsMinLodShift")]
        MinLodShift = 0x7,
        [NativeName("Name", "SpvImageOperandsMakeTexelAvailableShift")]
        MakeTexelAvailableShift = 0x8,
        [NativeName("Name", "SpvImageOperandsMakeTexelAvailableKHRShift")]
        MakeTexelAvailableKhrShift = 0x8,
        [NativeName("Name", "SpvImageOperandsMakeTexelVisibleShift")]
        MakeTexelVisibleShift = 0x9,
        [NativeName("Name", "SpvImageOperandsMakeTexelVisibleKHRShift")]
        MakeTexelVisibleKhrShift = 0x9,
        [NativeName("Name", "SpvImageOperandsNonPrivateTexelShift")]
        NonPrivateTexelShift = 0xA,
        [NativeName("Name", "SpvImageOperandsNonPrivateTexelKHRShift")]
        NonPrivateTexelKhrShift = 0xA,
        [NativeName("Name", "SpvImageOperandsVolatileTexelShift")]
        VolatileTexelShift = 0xB,
        [NativeName("Name", "SpvImageOperandsVolatileTexelKHRShift")]
        VolatileTexelKhrShift = 0xB,
        [NativeName("Name", "SpvImageOperandsSignExtendShift")]
        SignExtendShift = 0xC,
        [NativeName("Name", "SpvImageOperandsZeroExtendShift")]
        ZeroExtendShift = 0xD,
        [NativeName("Name", "SpvImageOperandsNontemporalShift")]
        NontemporalShift = 0xE,
        [NativeName("Name", "SpvImageOperandsOffsetsShift")]
        OffsetsShift = 0x10,
        [NativeName("Name", "SpvImageOperandsMax")]
        Max = 0x7FFFFFFF,
    }
}
