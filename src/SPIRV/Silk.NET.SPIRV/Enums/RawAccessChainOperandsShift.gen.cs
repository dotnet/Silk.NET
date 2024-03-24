// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvRawAccessChainOperandsShift_")]
    public enum RawAccessChainOperandsShift : int
    {
        [NativeName("Name", "SpvRawAccessChainOperandsRobustnessPerComponentNVShift")]
        RobustnessPerComponentNVShift = 0x0,
        [NativeName("Name", "SpvRawAccessChainOperandsRobustnessPerElementNVShift")]
        RobustnessPerElementNVShift = 0x1,
        [NativeName("Name", "SpvRawAccessChainOperandsMax")]
        Max = 0x7FFFFFFF,
    }
}
