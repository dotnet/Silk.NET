// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkLayerSettingEXT")]
[NameAffix("Suffix", "KhronosVendor", "EXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkLayerSettingEXT
{
    [NativeName("pLayerName")]
    [NativeTypeName("const char *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    public sbyte* PLayerName;

    [NativeName("pSettingName")]
    [NativeTypeName("const char *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    public sbyte* PSettingName;

    [NativeName("type")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    public VkLayerSettingTypeEXT Type;

    [NativeName("valueCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    public uint ValueCount;

    [NativeName("pValues")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    public void* PValues;
}
