// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDebugUtilsMessengerCreateInfoEXT")]
[NameAffix("Suffix", "KhronosVendor", "EXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkDebugUtilsMessengerCreateInfoEXT
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public VkStructureType SType;

    [NativeName("pNext")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public void* PNext;

    [NativeName("flags")]
    [NativeTypeName("VkDebugUtilsMessengerCreateFlagsEXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public uint Flags;

    [NativeName("messageSeverity")]
    [NativeTypeName("VkDebugUtilsMessageSeverityFlagsEXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public VkDebugUtilsMessageSeverityFlagsEXT MessageSeverity;

    [NativeName("messageType")]
    [NativeTypeName("VkDebugUtilsMessageTypeFlagsEXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public VkDebugUtilsMessageTypeFlagsEXT MessageType;

    [NativeName("pfnUserCallback")]
    [NativeTypeName("PFN_vkDebugUtilsMessengerCallbackEXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public PfnVkDebugUtilsMessengerCallbackEXT PfnUserCallback;

    [NativeName("pUserData")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public void* PUserData;
}
