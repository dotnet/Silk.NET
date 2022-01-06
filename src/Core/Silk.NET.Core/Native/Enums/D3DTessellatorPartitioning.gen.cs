// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [Flags]
    [NativeName("Name", "D3D_TESSELLATOR_PARTITIONING")]
    public enum D3DTessellatorPartitioning : int
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
