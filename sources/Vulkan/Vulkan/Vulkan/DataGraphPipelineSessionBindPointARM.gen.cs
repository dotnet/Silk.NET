// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "ARM", 0)]
[NativeName("VkDataGraphPipelineSessionBindPointARM")]
[SupportedApiProfile("vulkan")]
public enum DataGraphPipelineSessionBindPointARM : uint
{
    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_DATA_GRAPH_PIPELINE_SESSION_BIND_POINT_TRANSIENT_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    Transientarm = 0,
}
