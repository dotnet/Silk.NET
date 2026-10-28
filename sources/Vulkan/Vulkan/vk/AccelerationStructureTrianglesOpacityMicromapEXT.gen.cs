// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAccelerationStructureTrianglesOpacityMicromapEXT")]
public unsafe partial struct AccelerationStructureTrianglesOpacityMicromapEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.AccelerationStructureTrianglesOpacityMicromapEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("indexType")]
    public IndexType IndexType;

    [NativeName("indexBuffer")]
    public DeviceOrHostAddressConstKHR IndexBuffer;

    [NativeName("indexStride")]
    public ulong IndexStride;

    [NativeName("baseTriangle")]
    public uint BaseTriangle;

    [NativeName("usageCountsCount")]
    public uint UsageCountsCount;

    [NativeName("pUsageCounts")]
    public MicromapUsageEXT* PUsageCounts;

    [NativeName("ppUsageCounts")]
    public MicromapUsageEXT** PpUsageCounts;

    [NativeName("micromap")]
    public MicromapHandleEXT Micromap;

    public AccelerationStructureTrianglesOpacityMicromapEXT() { }
}
