// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("_description_e__FixedBuffer")]
[InlineArray(256)]
[SupportedApiProfile(
    "vulkan",
    ["VK_KHR_performance_query"],
    ImpliesSets = [
        "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
        "VK_KHR_performance_query+VK_VERSION_1_1",
    ]
)]
public partial struct PerformanceCounterDescriptionKHRDescription
{
    [NativeName("e0")]
    [SupportedApiProfile("vulkan")]
    public sbyte E0;
}
