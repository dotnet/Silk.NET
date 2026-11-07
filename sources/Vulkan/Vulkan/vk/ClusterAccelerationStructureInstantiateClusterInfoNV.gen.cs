// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkClusterAccelerationStructureInstantiateClusterInfoNV")]
public partial struct ClusterAccelerationStructureInstantiateClusterInfoNV
{
    [NativeName("clusterIdOffset")]
    public uint ClusterIdOffset;

    [NativeName("_bitfield")]
    public uint Bitfield;

    [NativeName("geometryIndexOffset")]
    public uint GeometryIndexOffset
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Bitfield & 0xFFFFFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~0xFFFFFFu) | (value & 0xFFFFFFu); }
    }

    [NativeName("reserved")]
    public uint Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 24) & 0xFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0xFFu << 24)) | ((value & 0xFFu) << 24); }
    }

    [NativeName("clusterTemplateAddress")]
    public ulong ClusterTemplateAddress;

    [NativeName("vertexBuffer")]
    public StridedDeviceAddressNV VertexBuffer;
}
