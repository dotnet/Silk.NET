// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDataGraphPipelineSessionBindPointARM")]
public enum DataGraphPipelineSessionBindPointARM : uint
{
    [NativeName("VK_DATA_GRAPH_PIPELINE_SESSION_BIND_POINT_TRANSIENT_ARM")]
    Transient = 0,

    [NativeName("VK_DATA_GRAPH_PIPELINE_SESSION_BIND_POINT_OPTICAL_FLOW_CACHE_ARM")]
    OpticalFlowCache = 1000631001,

    [NativeName("VK_DATA_GRAPH_PIPELINE_SESSION_BIND_POINT_NEURAL_ACCELERATOR_STATISTICS_ARM")]
    NeuralAcceleratorStatistics = 1000676000,
}
