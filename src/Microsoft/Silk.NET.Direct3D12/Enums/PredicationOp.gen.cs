// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_PREDICATION_OP")]
    public enum PredicationOp : int
    {
        [NativeName("Name", "D3D12_PREDICATION_OP_EQUAL_ZERO")]
        PredicationOpEqualZero = 0x0,
        [NativeName("Name", "D3D12_PREDICATION_OP_NOT_EQUAL_ZERO")]
        PredicationOpNotEqualZero = 0x1,
    }
}
