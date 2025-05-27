// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[InlineArray(3)]
[SupportedApiProfile(
    "vulkan",
    ["VK_HUAWEI_cluster_culling_shader"],
    ImpliesSets = [
        "VK_HUAWEI_cluster_culling_shader+VK_KHR_get_physical_device_properties2",
        "VK_HUAWEI_cluster_culling_shader+VK_VERSION_1_1",
    ]
)]
public partial struct PhysicalDeviceClusterCullingShaderPropertiesHuaweiMaxWorkGroupSize
{
    [SupportedApiProfile("vulkan")]
    public uint E0;
}
