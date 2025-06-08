// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

[InlineArray(6)]
[SupportedApiProfile(
    "vulkan",
    ["VK_NV_partitioned_acceleration_structure"],
    ImpliesSets = ["VK_KHR_acceleration_structure"]
)]
public partial struct VkPartitionedAccelerationStructureWriteInstanceDataNV_explicitAABB
{
    [SupportedApiProfile("vulkan")]
    public float e0;
}
