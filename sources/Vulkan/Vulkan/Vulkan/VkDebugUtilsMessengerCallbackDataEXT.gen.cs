// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDebugUtilsMessengerCallbackDataEXT")]
[NameAffix("Suffix", "KhronosVendor", "EXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkDebugUtilsMessengerCallbackDataEXT
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public VkStructureType SType;

    [NativeName("pNext")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public void* PNext;

    [NativeName("flags")]
    [NativeTypeName("VkDebugUtilsMessengerCallbackDataFlagsEXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public uint Flags;

    [NativeName("pMessageIdName")]
    [NativeTypeName("const char *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public sbyte* PMessageIdName;

    [NativeName("messageIdNumber")]
    [NativeTypeName("int32_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public int MessageIdNumber;

    [NativeName("pMessage")]
    [NativeTypeName("const char *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public sbyte* PMessage;

    [NativeName("queueLabelCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public uint QueueLabelCount;

    [NativeName("pQueueLabels")]
    [NativeTypeName("const VkDebugUtilsLabelEXT *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public VkDebugUtilsLabelEXT* PQueueLabels;

    [NativeName("cmdBufLabelCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public uint CmdBufLabelCount;

    [NativeName("pCmdBufLabels")]
    [NativeTypeName("const VkDebugUtilsLabelEXT *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public VkDebugUtilsLabelEXT* PCmdBufLabels;

    [NativeName("objectCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public uint ObjectCount;

    [NativeName("pObjects")]
    [NativeTypeName("const VkDebugUtilsObjectNameInfoEXT *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public VkDebugUtilsObjectNameInfoEXT* PObjects;
}
