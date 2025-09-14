// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvTensorAddressingOperandsMask_")]
    public enum TensorAddressingOperandsMask : int
    {
        [NativeName("Name", "SpvTensorAddressingOperandsMaskNone")]
        MaskNone = 0x0,
        [NativeName("Name", "SpvTensorAddressingOperandsTensorViewMask")]
        TensorViewMask = 0x1,
        [NativeName("Name", "SpvTensorAddressingOperandsDecodeFuncMask")]
        DecodeFuncMask = 0x2,
    }
}
