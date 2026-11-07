// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceVulkan11Properties")]
public unsafe partial struct PhysicalDeviceVulkan11Properties
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceVulkan1x1Properties;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("deviceUUID")]
    public PhysicalDeviceVulkan11PropertiesDeviceUuid DeviceUuid;

    [NativeName("driverUUID")]
    public PhysicalDeviceVulkan11PropertiesDriverUuid DriverUuid;

    [NativeName("deviceLUID")]
    public PhysicalDeviceVulkan11PropertiesDeviceLuid DeviceLuid;

    [NativeName("deviceNodeMask")]
    public uint DeviceNodeMask;

    [NativeName("deviceLUIDValid")]
    public MaybeBool<uint> DeviceLuidValid;

    [NativeName("subgroupSize")]
    public uint SubgroupSize;

    [NativeName("subgroupSupportedStages")]
    public ShaderStageFlags SubgroupSupportedStages;

    [NativeName("subgroupSupportedOperations")]
    public SubgroupFeatureFlags SubgroupSupportedOperations;

    [NativeName("subgroupQuadOperationsInAllStages")]
    public MaybeBool<uint> SubgroupQuadOperationsInAllStages;

    [NativeName("pointClippingBehavior")]
    public PointClippingBehavior PointClippingBehavior;

    [NativeName("maxMultiviewViewCount")]
    public uint MaxMultiviewViewCount;

    [NativeName("maxMultiviewInstanceIndex")]
    public uint MaxMultiviewInstanceIndex;

    [NativeName("protectedNoFault")]
    public MaybeBool<uint> ProtectedNoFault;

    [NativeName("maxPerSetDescriptors")]
    public uint MaxPerSetDescriptors;

    [NativeName("maxMemoryAllocationSize")]
    public ulong MaxMemoryAllocationSize;

    public PhysicalDeviceVulkan11Properties() { }
}
