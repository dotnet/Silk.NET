// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDataGraphPipelineSessionBindPointARM")]
[SupportedApiProfile("vulkan")]
public enum DataGraphPipelineSessionBindPointARM : uint
{
    [NativeName("VK_DATA_GRAPH_PIPELINE_SESSION_BIND_POINT_TRANSIENT_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = [
            "VK_VERSION_1_3+VK_KHR_deferred_host_operations+VK_KHR_extended_flags",
            "VK_VERSION_1_3+VK_KHR_deferred_host_operations+VK_KHR_maintenance5",
        ]
    )]
    Transient = 0,

    [NativeName("VK_DATA_GRAPH_PIPELINE_SESSION_BIND_POINT_OPTICAL_FLOW_CACHE_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_optical_flow"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    OpticalFlowCache = 1000631001,

    [NativeName("VK_DATA_GRAPH_PIPELINE_SESSION_BIND_POINT_NEURAL_ACCELERATOR_STATISTICS_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_data_graph_neural_accelerator_statistics"])]
    NeuralAcceleratorStatistics = 1000676000,
}
