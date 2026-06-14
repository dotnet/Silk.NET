// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDataGraphPipelinePropertyARM")]
[SupportedApiProfile("vulkan")]
public enum DataGraphPipelinePropertyARM : uint
{
    [NativeName("VK_DATA_GRAPH_PIPELINE_PROPERTY_CREATION_LOG_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = [
            "VK_VERSION_1_3+VK_KHR_deferred_host_operations+VK_KHR_extended_flags",
            "VK_VERSION_1_3+VK_KHR_deferred_host_operations+VK_KHR_maintenance5",
        ]
    )]
    CreationLog = 0,

    [NativeName("VK_DATA_GRAPH_PIPELINE_PROPERTY_IDENTIFIER_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = [
            "VK_VERSION_1_3+VK_KHR_deferred_host_operations+VK_KHR_extended_flags",
            "VK_VERSION_1_3+VK_KHR_deferred_host_operations+VK_KHR_maintenance5",
        ]
    )]
    Identifier = 1,

    [NativeName("VK_DATA_GRAPH_PIPELINE_PROPERTY_NEURAL_ACCELERATOR_DEBUG_DATABASE_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_data_graph_neural_accelerator_statistics"])]
    NeuralAcceleratorDebugDatabase = 1000676000,

    [NativeName("VK_DATA_GRAPH_PIPELINE_PROPERTY_NEURAL_ACCELERATOR_STATISTICS_INFO_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_data_graph_neural_accelerator_statistics"])]
    NeuralAcceleratorStatisticsInfo = 1000676001,
}
