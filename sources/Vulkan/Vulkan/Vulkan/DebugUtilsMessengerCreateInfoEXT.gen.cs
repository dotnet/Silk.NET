// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDebugUtilsMessengerCreateInfoEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct DebugUtilsMessengerCreateInfoEXT
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

    [NativeName("messageSeverity")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public DebugUtilsMessageSeverityFlagsEXT MessageSeverity;

    [NativeName("messageType")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public DebugUtilsMessageTypeFlagsEXT MessageType;

    [NativeName("pfnUserCallback")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public PFNVkDebugUtilsMessengerCallbackEXT PfnUserCallback;

    [NativeName("pUserData")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public void* PUserData;
}
