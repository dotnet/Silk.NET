// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceSubgroupSizeControlProperties")]
public unsafe partial struct PhysicalDeviceSubgroupSizeControlProperties
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceSubgroupSizeControlProperties;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("minSubgroupSize")]
    public uint MinSubgroupSize;

    [NativeName("maxSubgroupSize")]
    public uint MaxSubgroupSize;

    [NativeName("maxComputeWorkgroupSubgroups")]
    public uint MaxComputeWorkgroupSubgroups;

    [NativeName("requiredSubgroupSizeStages")]
    public ShaderStageFlags RequiredSubgroupSizeStages;

    public PhysicalDeviceSubgroupSizeControlProperties() { }
}
