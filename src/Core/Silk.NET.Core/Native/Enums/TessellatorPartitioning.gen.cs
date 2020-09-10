// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "D3D_TESSELLATOR_PARTITIONING")]
    public enum TessellatorPartitioning
    {
        [NativeName("Name", "D3D_TESSELLATOR_PARTITIONING_UNDEFINED")]
        TessellatorPartitioningUndefined = 0x0,
        [NativeName("Name", "D3D_TESSELLATOR_PARTITIONING_INTEGER")]
        TessellatorPartitioningInteger = 0x1,
        [NativeName("Name", "D3D_TESSELLATOR_PARTITIONING_POW2")]
        TessellatorPartitioningPow2 = 0x2,
        [NativeName("Name", "D3D_TESSELLATOR_PARTITIONING_FRACTIONAL_ODD")]
        TessellatorPartitioningFractionalOdd = 0x3,
        [NativeName("Name", "D3D_TESSELLATOR_PARTITIONING_FRACTIONAL_EVEN")]
        TessellatorPartitioningFractionalEven = 0x4,
        [NativeName("Name", "D3D11_TESSELLATOR_PARTITIONING_UNDEFINED")]
        D3D11TessellatorPartitioningUndefined = 0x0,
        [NativeName("Name", "D3D11_TESSELLATOR_PARTITIONING_INTEGER")]
        D3D11TessellatorPartitioningInteger = 0x1,
        [NativeName("Name", "D3D11_TESSELLATOR_PARTITIONING_POW2")]
        D3D11TessellatorPartitioningPow2 = 0x2,
        [NativeName("Name", "D3D11_TESSELLATOR_PARTITIONING_FRACTIONAL_ODD")]
        D3D11TessellatorPartitioningFractionalOdd = 0x3,
        [NativeName("Name", "D3D11_TESSELLATOR_PARTITIONING_FRACTIONAL_EVEN")]
        D3D11TessellatorPartitioningFractionalEven = 0x4,
    }
}
