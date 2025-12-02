// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[NativeName("VkLayerSettingTypeEXT")]
[SupportedApiProfile("vulkan")]
public enum LayerSettingTypeEXT : uint
{
    [NativeName("VK_LAYER_SETTING_TYPE_BOOL32_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    Bool32EXT = 0,

    [NativeName("VK_LAYER_SETTING_TYPE_INT32_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    Int32EXT = 1,

    [NativeName("VK_LAYER_SETTING_TYPE_INT64_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    Int64EXT = 2,

    [NativeName("VK_LAYER_SETTING_TYPE_UINT32_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    Uint32EXT = 3,

    [NativeName("VK_LAYER_SETTING_TYPE_UINT64_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    Uint64EXT = 4,

    [NativeName("VK_LAYER_SETTING_TYPE_FLOAT32_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    Float32EXT = 5,

    [NativeName("VK_LAYER_SETTING_TYPE_FLOAT64_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    Float64EXT = 6,

    [NativeName("VK_LAYER_SETTING_TYPE_STRING_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    StringEXT = 7,
}
