// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceExternalComputeQueuePropertiesNV
{
    [SupportedApiProfile("vulkan", ["VK_NV_external_compute_queue"])]
    public VkStructureType sType;

    [SupportedApiProfile("vulkan", ["VK_NV_external_compute_queue"])]
    public void* pNext;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_compute_queue"])]
    public uint externalDataSize;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_compute_queue"])]
    public uint maxExternalQueues;
}
