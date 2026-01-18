// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvTensorAddressingOperandsShift_")]
    public enum TensorAddressingOperandsShift : int
    {
        [NativeName("Name", "SpvTensorAddressingOperandsTensorViewShift")]
        TensorViewShift = 0x0,
        [NativeName("Name", "SpvTensorAddressingOperandsDecodeFuncShift")]
        DecodeFuncShift = 0x1,
        [NativeName("Name", "SpvTensorAddressingOperandsMax")]
        Max = 0x7FFFFFFF,
    }
}
