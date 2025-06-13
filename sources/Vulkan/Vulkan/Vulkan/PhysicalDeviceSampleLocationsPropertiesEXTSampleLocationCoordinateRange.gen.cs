// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;
global using Silk.NET.Core;
global using static Silk.NET.Core.DSL;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

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
    [SupportedApiProfile("vulkan")]
    public float E0;
}
