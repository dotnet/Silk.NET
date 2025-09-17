// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.DirectX;
using Silk.NET.Win32;
using Silk.NET.WinRT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D_TESSELLATOR_PARTITIONING.xml' path='doc/member[@name="D3D_TESSELLATOR_PARTITIONING"]/*'/>
public enum D3DTessellatorPartitioning
{
    /// <include file='D3D_TESSELLATOR_PARTITIONING.xml' path='doc/member[@name="D3D_TESSELLATOR_PARTITIONING.D3D_TESSELLATOR_PARTITIONING_UNDEFINED"]/*'/>

    DTessellatorPartitioningUndefined = 0,

    /// <include file='D3D_TESSELLATOR_PARTITIONING.xml' path='doc/member[@name="D3D_TESSELLATOR_PARTITIONING.D3D_TESSELLATOR_PARTITIONING_INTEGER"]/*'/>

    DTessellatorPartitioningInteger = 1,

    /// <include file='D3D_TESSELLATOR_PARTITIONING.xml' path='doc/member[@name="D3D_TESSELLATOR_PARTITIONING.D3D_TESSELLATOR_PARTITIONING_POW2"]/*'/>

    DTessellatorPartitioningPow2 = 2,

    /// <include file='D3D_TESSELLATOR_PARTITIONING.xml' path='doc/member[@name="D3D_TESSELLATOR_PARTITIONING.D3D_TESSELLATOR_PARTITIONING_FRACTIONAL_ODD"]/*'/>

    DTessellatorPartitioningFractionalOdd = 3,

    /// <include file='D3D_TESSELLATOR_PARTITIONING.xml' path='doc/member[@name="D3D_TESSELLATOR_PARTITIONING.D3D_TESSELLATOR_PARTITIONING_FRACTIONAL_EVEN"]/*'/>

    DTessellatorPartitioningFractionalEven = 4,

    /// <include file='D3D_TESSELLATOR_PARTITIONING.xml' path='doc/member[@name="D3D_TESSELLATOR_PARTITIONING.D3D11_TESSELLATOR_PARTITIONING_UNDEFINED"]/*'/>

    D11TessellatorPartitioningUndefined = DTessellatorPartitioningUndefined,

    /// <include file='D3D_TESSELLATOR_PARTITIONING.xml' path='doc/member[@name="D3D_TESSELLATOR_PARTITIONING.D3D11_TESSELLATOR_PARTITIONING_INTEGER"]/*'/>

    D11TessellatorPartitioningInteger = DTessellatorPartitioningInteger,

    /// <include file='D3D_TESSELLATOR_PARTITIONING.xml' path='doc/member[@name="D3D_TESSELLATOR_PARTITIONING.D3D11_TESSELLATOR_PARTITIONING_POW2"]/*'/>

    D11TessellatorPartitioningPow2 = DTessellatorPartitioningPow2,

    /// <include file='D3D_TESSELLATOR_PARTITIONING.xml' path='doc/member[@name="D3D_TESSELLATOR_PARTITIONING.D3D11_TESSELLATOR_PARTITIONING_FRACTIONAL_ODD"]/*'/>

    D11TessellatorPartitioningFractionalOdd = DTessellatorPartitioningFractionalOdd,

    /// <include file='D3D_TESSELLATOR_PARTITIONING.xml' path='doc/member[@name="D3D_TESSELLATOR_PARTITIONING.D3D11_TESSELLATOR_PARTITIONING_FRACTIONAL_EVEN"]/*'/>

    D11TessellatorPartitioningFractionalEven = DTessellatorPartitioningFractionalEven,
}
