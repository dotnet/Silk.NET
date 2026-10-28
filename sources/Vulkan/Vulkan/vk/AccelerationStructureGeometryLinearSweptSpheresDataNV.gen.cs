// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAccelerationStructureGeometryLinearSweptSpheresDataNV")]
public unsafe partial struct AccelerationStructureGeometryLinearSweptSpheresDataNV
{
    [NativeName("sType")]
    public StructureType SType =
        StructureType.AccelerationStructureGeometryLinearSweptSpheresDataNV;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("vertexFormat")]
    public Format VertexFormat;

    [NativeName("vertexData")]
    public DeviceOrHostAddressConstKHR VertexData;

    [NativeName("vertexStride")]
    public ulong VertexStride;

    [NativeName("radiusFormat")]
    public Format RadiusFormat;

    [NativeName("radiusData")]
    public DeviceOrHostAddressConstKHR RadiusData;

    [NativeName("radiusStride")]
    public ulong RadiusStride;

    [NativeName("indexType")]
    public IndexType IndexType;

    [NativeName("indexData")]
    public DeviceOrHostAddressConstKHR IndexData;

    [NativeName("indexStride")]
    public ulong IndexStride;

    [NativeName("indexingMode")]
    public RayTracingLssIndexingModeNV IndexingMode;

    [NativeName("endCapsMode")]
    public RayTracingLssPrimitiveEndCapsModeNV EndCapsMode;

    public AccelerationStructureGeometryLinearSweptSpheresDataNV() { }
}
