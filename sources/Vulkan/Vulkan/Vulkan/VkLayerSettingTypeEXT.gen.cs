// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "EXT")]
[NativeName("VkLayerSettingTypeEXT")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkLayerSettingTypeEXT : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_LAYER_SETTING_TYPE_BOOL32_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    VkLayerSettingTypeBool32 = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_LAYER_SETTING_TYPE_INT32_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    VkLayerSettingTypeInt32 = 1,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_LAYER_SETTING_TYPE_INT64_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    VkLayerSettingTypeInt64 = 2,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_LAYER_SETTING_TYPE_UINT32_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    VkLayerSettingTypeUint32 = 3,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_LAYER_SETTING_TYPE_UINT64_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    VkLayerSettingTypeUint64 = 4,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_LAYER_SETTING_TYPE_FLOAT32_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    VkLayerSettingTypeFloat32 = 5,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_LAYER_SETTING_TYPE_FLOAT64_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    VkLayerSettingTypeFloat64 = 6,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_LAYER_SETTING_TYPE_STRING_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    VkLayerSettingTypeString = 7,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_LAYER_SETTING_TYPE_MAX_ENUM_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    VkLayerSettingTypeMaxEnum = 0x7FFFFFFF,
}
