// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkLayerSettingsCreateInfoEXT")]
[NameAffix("Suffix", "KhronosVendor", "EXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkLayerSettingsCreateInfoEXT
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    public VkStructureType SType;

    [NativeName("pNext")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    public void* PNext;

    [NativeName("settingCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    public uint SettingCount;

    [NativeName("pSettings")]
    [NativeTypeName("const VkLayerSettingEXT *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    public VkLayerSettingEXT* PSettings;
}
