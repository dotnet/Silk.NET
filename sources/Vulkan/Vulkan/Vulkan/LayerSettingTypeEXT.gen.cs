// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum LayerSettingTypeEXT : uint
{
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    Bool32EXT = 0,

    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    Int32EXT = 1,

    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    Int64EXT = 2,

    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    Uint32EXT = 3,

    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    Uint64EXT = 4,

    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    Float32EXT = 5,

    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    Float64EXT = 6,

    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    StringEXT = 7,
}
