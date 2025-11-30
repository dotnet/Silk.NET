// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("VkDebugUtilsMessengerCallbackDataEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct DebugUtilsMessengerCallbackDataEXT
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public void* PNext;

    [NativeName("flags")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public uint Flags;

    [NativeName("pMessageIdName")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public sbyte* PMessageIdName;

    [NativeName("messageIdNumber")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public int MessageIdNumber;

    [NativeName("pMessage")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public sbyte* PMessage;

    [NativeName("queueLabelCount")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public uint QueueLabelCount;

    [NativeName("pQueueLabels")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public DebugUtilsLabelEXT* PQueueLabels;

    [NativeName("cmdBufLabelCount")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public uint CmdBufLabelCount;

    [NativeName("pCmdBufLabels")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public DebugUtilsLabelEXT* PCmdBufLabels;

    [NativeName("objectCount")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public uint ObjectCount;

    [NativeName("pObjects")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public DebugUtilsObjectNameInfoEXT* PObjects;
}
