// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct DebugUtilsMessengerCreateInfoEXT
{
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public void* PNext;

    [NativeTypeName("VkDebugUtilsMessengerCreateFlagsEXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public uint Flags;

    [NativeTypeName("VkDebugUtilsMessageSeverityFlagsEXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public DebugUtilsMessageSeverityFlagsEXT MessageSeverity;

    [NativeTypeName("VkDebugUtilsMessageTypeFlagsEXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public DebugUtilsMessageTypeFlagsEXT MessageType;

    [NativeTypeName("PFN_vkDebugUtilsMessengerCallbackEXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public PFNVkDebugUtilsMessengerCallbackEXT PfnUserCallback;

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public void* PUserData;
}
