// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_PREDICATION_OP")]
    public enum PredicationOp : int
    {
        [NativeName("Name", "D3D12_PREDICATION_OP_EQUAL_ZERO")]
        PredicationOpEqualZero = 0x0,
        [NativeName("Name", "D3D12_PREDICATION_OP_NOT_EQUAL_ZERO")]
        PredicationOpNotEqualZero = 0x1,
    }
}
