// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[InlineArray(128)]
[SupportedApiProfile(
    "vulkan",
    ["VK_ARM_data_graph"],
    ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
)]
public partial struct PhysicalDeviceDataGraphOperationSupportARMName
{
    [SupportedApiProfile("vulkan")]
    public sbyte E0;
}
