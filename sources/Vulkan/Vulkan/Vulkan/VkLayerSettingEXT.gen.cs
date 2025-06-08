// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkLayerSettingEXT
{
    [NativeTypeName("const char *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    public sbyte* pLayerName;

    [NativeTypeName("const char *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    public sbyte* pSettingName;

    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    public VkLayerSettingTypeEXT type;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    public uint valueCount;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    public void* pValues;
}
