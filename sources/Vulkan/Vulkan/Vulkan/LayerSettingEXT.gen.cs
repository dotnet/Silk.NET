// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameSuffix("EXT", 0)]
[NativeName("VkLayerSettingEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct LayerSettingEXT
{
    [NativeName("pLayerName")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    public sbyte* PLayerName;

    [NativeName("pSettingName")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    public sbyte* PSettingName;

    [NativeName("type")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    public LayerSettingTypeEXT Type;

    [NativeName("valueCount")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    public uint ValueCount;

    [NativeName("pValues")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    public void* PValues;
}
