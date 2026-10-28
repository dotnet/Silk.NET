// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkClusterAccelerationStructureBuildTriangleClusterInfoNV")]
public partial struct ClusterAccelerationStructureBuildTriangleClusterInfoNV
{
    [NativeName("clusterID")]
    public uint ClusterID;

    [NativeName("clusterFlags")]
    public ClusterAccelerationStructureClusterFlagsNV ClusterFlags;

    [NativeName("_bitfield")]
    public uint Bitfield;

    [NativeName("triangleCount")]
    public uint TriangleCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Bitfield & 0x1FFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~0x1FFu) | (value & 0x1FFu); }
    }

    [NativeName("vertexCount")]
    public uint VertexCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 9) & 0x1FFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1FFu << 9)) | ((value & 0x1FFu) << 9); }
    }

    [NativeName("positionTruncateBitCount")]
    public uint PositionTruncateBitCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 18) & 0x3Fu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x3Fu << 18)) | ((value & 0x3Fu) << 18); }
    }

    [NativeName("indexType")]
    public uint IndexType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 24) & 0xFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0xFu << 24)) | ((value & 0xFu) << 24); }
    }

    [NativeName("opacityMicromapIndexType")]
    public uint OpacityMicromapIndexType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 28) & 0xFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0xFu << 28)) | ((value & 0xFu) << 28); }
    }

    [NativeName("baseGeometryIndexAndGeometryFlags")]
    public ClusterAccelerationStructureGeometryIndexAndGeometryFlagsNV BaseGeometryIndexAndGeometryFlags;

    [NativeName("indexBufferStride")]
    public ushort IndexBufferStride;

    [NativeName("vertexBufferStride")]
    public ushort VertexBufferStride;

    [NativeName("geometryIndexAndFlagsBufferStride")]
    public ushort GeometryIndexAndFlagsBufferStride;

    [NativeName("opacityMicromapIndexBufferStride")]
    public ushort OpacityMicromapIndexBufferStride;

    [NativeName("indexBuffer")]
    public ulong IndexBuffer;

    [NativeName("vertexBuffer")]
    public ulong VertexBuffer;

    [NativeName("geometryIndexAndFlagsBuffer")]
    public ulong GeometryIndexAndFlagsBuffer;

    [NativeName("opacityMicromapArray")]
    public ulong OpacityMicromapArray;

    [NativeName("opacityMicromapIndexBuffer")]
    public ulong OpacityMicromapIndexBuffer;
}
