// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceExtendedSparseAddressSpacePropertiesNV
{
    [SupportedApiProfile("vulkan", ["VK_NV_extended_sparse_address_space"])]
    public VkStructureType sType;

    [SupportedApiProfile("vulkan", ["VK_NV_extended_sparse_address_space"])]
    public void* pNext;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan", ["VK_NV_extended_sparse_address_space"])]
    public ulong extendedSparseAddressSpaceSize;

    [NativeTypeName("VkImageUsageFlags")]
    [SupportedApiProfile("vulkan", ["VK_NV_extended_sparse_address_space"])]
    public uint extendedSparseImageUsageFlags;

    [NativeTypeName("VkBufferUsageFlags")]
    [SupportedApiProfile("vulkan", ["VK_NV_extended_sparse_address_space"])]
    public uint extendedSparseBufferUsageFlags;
}
