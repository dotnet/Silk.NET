// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D_TESSELLATOR_PARTITIONING")]
    public enum D3DTessellatorPartitioning
    {
        [NativeName("Name", "D3D_TESSELLATOR_PARTITIONING_UNDEFINED")]
        D3DTessellatorPartitioningUndefined = 0x0,
        [NativeName("Name", "D3D_TESSELLATOR_PARTITIONING_INTEGER")]
        D3DTessellatorPartitioningInteger = 0x1,
        [NativeName("Name", "D3D_TESSELLATOR_PARTITIONING_POW2")]
        D3DTessellatorPartitioningPow2 = 0x2,
        [NativeName("Name", "D3D_TESSELLATOR_PARTITIONING_FRACTIONAL_ODD")]
        D3DTessellatorPartitioningFractionalOdd = 0x3,
        [NativeName("Name", "D3D_TESSELLATOR_PARTITIONING_FRACTIONAL_EVEN")]
        D3DTessellatorPartitioningFractionalEven = 0x4,
        [NativeName("Name", "D3D11_TESSELLATOR_PARTITIONING_UNDEFINED")]
        TessellatorPartitioningUndefined = 0x0,
        [NativeName("Name", "D3D11_TESSELLATOR_PARTITIONING_INTEGER")]
        TessellatorPartitioningInteger = 0x1,
        [NativeName("Name", "D3D11_TESSELLATOR_PARTITIONING_POW2")]
        TessellatorPartitioningPow2 = 0x2,
        [NativeName("Name", "D3D11_TESSELLATOR_PARTITIONING_FRACTIONAL_ODD")]
        TessellatorPartitioningFractionalOdd = 0x3,
        [NativeName("Name", "D3D11_TESSELLATOR_PARTITIONING_FRACTIONAL_EVEN")]
        TessellatorPartitioningFractionalEven = 0x4,
    }
}
