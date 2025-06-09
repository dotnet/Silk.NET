// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkLayerSettingTypeEXT : uint
{
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    VK_LAYER_SETTING_TYPE_BOOL32_EXT = 0,

    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    VK_LAYER_SETTING_TYPE_INT32_EXT = 1,

    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    VK_LAYER_SETTING_TYPE_INT64_EXT = 2,

    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    VK_LAYER_SETTING_TYPE_UINT32_EXT = 3,

    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    VK_LAYER_SETTING_TYPE_UINT64_EXT = 4,

    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    VK_LAYER_SETTING_TYPE_FLOAT32_EXT = 5,

    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    VK_LAYER_SETTING_TYPE_FLOAT64_EXT = 6,

    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    VK_LAYER_SETTING_TYPE_STRING_EXT = 7,

    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    VK_LAYER_SETTING_TYPE_MAX_ENUM_EXT = 0x7FFFFFFF,
}
