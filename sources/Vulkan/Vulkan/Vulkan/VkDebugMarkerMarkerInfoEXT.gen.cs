// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDebugMarkerMarkerInfoEXT")]
[NameAffix("Suffix", "KhronosVendor", "EXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkDebugMarkerMarkerInfoEXT
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_marker"], ImpliesSets = ["VK_EXT_debug_report"])]
    public VkStructureType SType;

    [NativeName("pNext")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_marker"], ImpliesSets = ["VK_EXT_debug_report"])]
    public void* PNext;

    [NativeName("pMarkerName")]
    [NativeTypeName("const char *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_marker"], ImpliesSets = ["VK_EXT_debug_report"])]
    public sbyte* PMarkerName;

    [NativeName("color")]
    [NativeTypeName("float[4]")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_marker"], ImpliesSets = ["VK_EXT_debug_report"])]
    public VkDebugMarkerMarkerInfoEXTColor Color;
}
