// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceSubgroupProperties")]
public unsafe partial struct PhysicalDeviceSubgroupProperties
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceSubgroupProperties;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("subgroupSize")]
    public uint SubgroupSize;

    [NativeName("supportedStages")]
    public ShaderStageFlags SupportedStages;

    [NativeName("supportedOperations")]
    public SubgroupFeatureFlags SupportedOperations;

    [NativeName("quadOperationsInAllStages")]
    public MaybeBool<uint> QuadOperationsInAllStages;

    public PhysicalDeviceSubgroupProperties() { }
}
