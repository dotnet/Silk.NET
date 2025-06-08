// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkDebugUtilsMessengerCreateInfoEXT
{
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public void* pNext;

    [NativeTypeName("VkDebugUtilsMessengerCreateFlagsEXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public uint flags;

    [NativeTypeName("VkDebugUtilsMessageSeverityFlagsEXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public uint messageSeverity;

    [NativeTypeName("VkDebugUtilsMessageTypeFlagsEXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public uint messageType;

    [NativeTypeName("PFN_vkDebugUtilsMessengerCallbackEXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public PFN_vkDebugUtilsMessengerCallbackEXT pfnUserCallback;

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public void* pUserData;
}
