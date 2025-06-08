// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkMemoryBarrierAccessFlags3KHR
{
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance8"], ImpliesSets = ["VK_VERSION_1_1"])]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance8"], ImpliesSets = ["VK_VERSION_1_1"])]
    public void* pNext;

    [NativeTypeName("VkAccessFlags3KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance8"], ImpliesSets = ["VK_VERSION_1_1"])]
    public ulong srcAccessMask3;

    [NativeTypeName("VkAccessFlags3KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance8"], ImpliesSets = ["VK_VERSION_1_1"])]
    public ulong dstAccessMask3;
}
