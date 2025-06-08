// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkDebugReportCallbackCreateInfoEXT
{
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    public void* pNext;

    [NativeTypeName("VkDebugReportFlagsEXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    public uint flags;

    [NativeTypeName("PFN_vkDebugReportCallbackEXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    public PFN_vkDebugReportCallbackEXT pfnCallback;

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    public void* pUserData;
}
