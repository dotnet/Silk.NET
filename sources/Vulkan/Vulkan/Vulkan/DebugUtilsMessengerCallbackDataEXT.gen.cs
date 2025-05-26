// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct DebugUtilsMessengerCallbackDataEXT
{
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public void* PNext;

    [NativeTypeName("VkDebugUtilsMessengerCallbackDataFlagsEXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public uint Flags;

    [NativeTypeName("const char *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public sbyte* PMessageIdName;

    [NativeTypeName("int32_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public int MessageIdNumber;

    [NativeTypeName("const char *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public sbyte* PMessage;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public uint QueueLabelCount;

    [NativeTypeName("const VkDebugUtilsLabelEXT *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public DebugUtilsLabelEXT* PQueueLabels;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public uint CmdBufLabelCount;

    [NativeTypeName("const VkDebugUtilsLabelEXT *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public DebugUtilsLabelEXT* PCmdBufLabels;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public uint ObjectCount;

    [NativeTypeName("const VkDebugUtilsObjectNameInfoEXT *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public DebugUtilsObjectNameInfoEXT* PObjects;
}
