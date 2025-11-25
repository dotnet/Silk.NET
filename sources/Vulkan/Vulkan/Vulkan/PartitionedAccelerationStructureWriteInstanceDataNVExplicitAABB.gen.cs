// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("_explicitAABB_e__FixedBuffer")]
[InlineArray(6)]
[SupportedApiProfile(
    "vulkan",
    ["VK_NV_partitioned_acceleration_structure"],
    ImpliesSets = ["VK_KHR_acceleration_structure"]
)]
public partial struct PartitionedAccelerationStructureWriteInstanceDataNVExplicitAABB
{
    [NativeName("e0")]
    [SupportedApiProfile("vulkan")]
    public float E0;
}
