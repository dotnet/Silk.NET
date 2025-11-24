// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[InlineArray(3)]
[SupportedApiProfile(
    "vulkan",
    ["VK_NV_mesh_shader"],
    ImpliesSets = [
        "VK_NV_mesh_shader+VK_KHR_get_physical_device_properties2",
        "VK_NV_mesh_shader+VK_VERSION_1_1",
    ]
)]
public partial struct PhysicalDeviceMeshShaderPropertiesNVMaxTaskWorkGroupSize
{
    [SupportedApiProfile("vulkan")]
    public uint E0;
}
