// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDataGraphPipelinePropertyARM")]
public enum DataGraphPipelinePropertyARM : uint
{
    [NativeName("VK_DATA_GRAPH_PIPELINE_PROPERTY_CREATION_LOG_ARM")]
    CreationLog = 0,

    [NativeName("VK_DATA_GRAPH_PIPELINE_PROPERTY_IDENTIFIER_ARM")]
    Identifier = 1,

    [NativeName("VK_DATA_GRAPH_PIPELINE_PROPERTY_NEURAL_ACCELERATOR_DEBUG_DATABASE_ARM")]
    NeuralAcceleratorDebugDatabase = 1000676000,

    [NativeName("VK_DATA_GRAPH_PIPELINE_PROPERTY_NEURAL_ACCELERATOR_STATISTICS_INFO_ARM")]
    NeuralAcceleratorStatisticsInfo = 1000676001,
}
