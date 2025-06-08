// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkLayerSettingsCreateInfoEXT
{
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    public void* pNext;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    public uint settingCount;

    [NativeTypeName("const VkLayerSettingEXT *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    public VkLayerSettingEXT* pSettings;
}
