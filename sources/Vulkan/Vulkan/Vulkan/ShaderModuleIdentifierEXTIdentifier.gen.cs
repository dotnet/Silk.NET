// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[InlineArray(32)]
[SupportedApiProfile(
    "vulkan",
    ["VK_EXT_shader_module_identifier"],
    ImpliesSets = [
        "VK_EXT_pipeline_creation_cache_control+VK_KHR_get_physical_device_properties2",
        "VK_EXT_pipeline_creation_cache_control+VK_VERSION_1_1",
        "VK_VERSION_1_3",
    ]
)]
public partial struct ShaderModuleIdentifierEXTIdentifier
{
    [SupportedApiProfile("vulkan")]
    public byte E0;
}
