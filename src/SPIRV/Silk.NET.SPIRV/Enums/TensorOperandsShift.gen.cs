// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvTensorOperandsShift_")]
    public enum TensorOperandsShift : int
    {
        [NativeName("Name", "SpvTensorOperandsNontemporalARMShift")]
        NontemporalArmShift = 0x0,
        [NativeName("Name", "SpvTensorOperandsOutOfBoundsValueARMShift")]
        OutOfBoundsValueArmShift = 0x1,
        [NativeName("Name", "SpvTensorOperandsMakeElementAvailableARMShift")]
        MakeElementAvailableArmShift = 0x2,
        [NativeName("Name", "SpvTensorOperandsMakeElementVisibleARMShift")]
        MakeElementVisibleArmShift = 0x3,
        [NativeName("Name", "SpvTensorOperandsNonPrivateElementARMShift")]
        NonPrivateElementArmShift = 0x4,
        [NativeName("Name", "SpvTensorOperandsMax")]
        Max = 0x7FFFFFFF,
    }
}
