// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkHeadlessSurfaceCreateInfoEXT
{
    [SupportedApiProfile("vulkan", ["VK_EXT_headless_surface"], ImpliesSets = ["VK_KHR_surface"])]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_headless_surface"], ImpliesSets = ["VK_KHR_surface"])]
    public void* pNext;

    [NativeTypeName("VkHeadlessSurfaceCreateFlagsEXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_headless_surface"], ImpliesSets = ["VK_KHR_surface"])]
    public uint flags;
}
