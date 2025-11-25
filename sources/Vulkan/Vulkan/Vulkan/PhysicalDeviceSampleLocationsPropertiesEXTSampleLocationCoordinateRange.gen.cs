// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("_sampleLocationCoordinateRange_e__FixedBuffer")]
[InlineArray(2)]
[SupportedApiProfile(
    "vulkan",
    ["VK_EXT_sample_locations"],
    ImpliesSets = [
        "VK_EXT_sample_locations+VK_KHR_get_physical_device_properties2",
        "VK_EXT_sample_locations+VK_VERSION_1_1",
    ]
)]
public partial struct PhysicalDeviceSampleLocationsPropertiesEXTSampleLocationCoordinateRange
{
    [NativeName("e0")]
    [SupportedApiProfile("vulkan")]
    public float E0;
}
