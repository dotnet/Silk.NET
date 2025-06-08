// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkDebugUtilsObjectTagInfoEXT
{
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public void* pNext;

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public VkObjectType objectType;

    [NativeTypeName("uint64_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public ulong objectHandle;

    [NativeTypeName("uint64_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public ulong tagName;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public nuint tagSize;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public void* pTag;
}
