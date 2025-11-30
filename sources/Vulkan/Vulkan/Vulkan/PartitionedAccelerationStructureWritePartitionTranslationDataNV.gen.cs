// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "NV", 0)]
[NativeName("VkPartitionedAccelerationStructureWritePartitionTranslationDataNV")]
[SupportedApiProfile("vulkan")]
public partial struct PartitionedAccelerationStructureWritePartitionTranslationDataNV
{
    [NativeName("partitionIndex")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public uint PartitionIndex;

    [NativeName("partitionTranslation")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public PartitionedAccelerationStructureWritePartitionTranslationDataNvPartitionTranslation PartitionTranslation;
}
