// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkDependencyInfo
{
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public void* pNext;

    [NativeTypeName("VkDependencyFlags")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint dependencyFlags;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint memoryBarrierCount;

    [NativeTypeName("const VkMemoryBarrier2 *")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public VkMemoryBarrier2* pMemoryBarriers;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint bufferMemoryBarrierCount;

    [NativeTypeName("const VkBufferMemoryBarrier2 *")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public VkBufferMemoryBarrier2* pBufferMemoryBarriers;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint imageMemoryBarrierCount;

    [NativeTypeName("const VkImageMemoryBarrier2 *")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public VkImageMemoryBarrier2* pImageMemoryBarriers;
}
