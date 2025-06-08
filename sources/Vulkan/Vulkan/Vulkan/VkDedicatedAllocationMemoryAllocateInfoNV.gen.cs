// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkDedicatedAllocationMemoryAllocateInfoNV
{
    [SupportedApiProfile("vulkan", ["VK_NV_dedicated_allocation"])]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_NV_dedicated_allocation"])]
    public void* pNext;

    [NativeTypeName("VkImage")]
    [SupportedApiProfile("vulkan", ["VK_NV_dedicated_allocation"])]
    public VkImage_T* image;

    [NativeTypeName("VkBuffer")]
    [SupportedApiProfile("vulkan", ["VK_NV_dedicated_allocation"])]
    public VkBuffer_T* buffer;
}
