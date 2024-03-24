// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvRawAccessChainOperandsMask_")]
    public enum RawAccessChainOperandsMask : int
    {
        [NativeName("Name", "SpvRawAccessChainOperandsMaskNone")]
        MaskNone = 0x0,
        [NativeName("Name", "SpvRawAccessChainOperandsRobustnessPerComponentNVMask")]
        RobustnessPerComponentNVMask = 0x1,
        [NativeName("Name", "SpvRawAccessChainOperandsRobustnessPerElementNVMask")]
        RobustnessPerElementNVMask = 0x2,
    }
}
