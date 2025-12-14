// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [Flags]
    [NativeName("Name", "SpvTensorOperandsMask_")]
    public enum TensorOperandsMask : int
    {
        [NativeName("Name", "SpvTensorOperandsMaskNone")]
        MaskNone = 0x0,
        [NativeName("Name", "SpvTensorOperandsNontemporalARMMask")]
        NontemporalArmMask = 0x1,
        [NativeName("Name", "SpvTensorOperandsOutOfBoundsValueARMMask")]
        OutOfBoundsValueArmMask = 0x2,
        [NativeName("Name", "SpvTensorOperandsMakeElementAvailableARMMask")]
        MakeElementAvailableArmMask = 0x4,
        [NativeName("Name", "SpvTensorOperandsMakeElementVisibleARMMask")]
        MakeElementVisibleArmMask = 0x8,
        [NativeName("Name", "SpvTensorOperandsNonPrivateElementARMMask")]
        NonPrivateElementArmMask = 0x10,
    }
}
