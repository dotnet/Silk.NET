// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("VkLayerSettingTypeEXT")]
[SupportedApiProfile("vulkan")]
public enum LayerSettingTypeEXT : uint
{
    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_LAYER_SETTING_TYPE_BOOL32_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    Bool32Ext = 0,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_LAYER_SETTING_TYPE_INT32_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    Int32Ext = 1,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_LAYER_SETTING_TYPE_INT64_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    Int64Ext = 2,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_LAYER_SETTING_TYPE_UINT32_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    Uint32Ext = 3,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_LAYER_SETTING_TYPE_UINT64_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    Uint64Ext = 4,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_LAYER_SETTING_TYPE_FLOAT32_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    Float32Ext = 5,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_LAYER_SETTING_TYPE_FLOAT64_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    Float64Ext = 6,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_LAYER_SETTING_TYPE_STRING_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    Stringext = 7,
}
