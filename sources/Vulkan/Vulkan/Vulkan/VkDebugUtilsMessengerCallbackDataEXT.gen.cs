// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkDebugUtilsMessengerCallbackDataEXT
{
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public void* pNext;

    [NativeTypeName("VkDebugUtilsMessengerCallbackDataFlagsEXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public uint flags;

    [NativeTypeName("const char *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public sbyte* pMessageIdName;

    [NativeTypeName("int32_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public int messageIdNumber;

    [NativeTypeName("const char *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public sbyte* pMessage;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public uint queueLabelCount;

    [NativeTypeName("const VkDebugUtilsLabelEXT *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public VkDebugUtilsLabelEXT* pQueueLabels;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public uint cmdBufLabelCount;

    [NativeTypeName("const VkDebugUtilsLabelEXT *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public VkDebugUtilsLabelEXT* pCmdBufLabels;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public uint objectCount;

    [NativeTypeName("const VkDebugUtilsObjectNameInfoEXT *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public VkDebugUtilsObjectNameInfoEXT* pObjects;
}
