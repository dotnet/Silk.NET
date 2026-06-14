// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDataGraphPipelineSessionNeuralStatisticsCreateInfoARM")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct DataGraphPipelineSessionNeuralStatisticsCreateInfoARM
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_ARM_data_graph_neural_accelerator_statistics"])]
    public StructureType SType =
        StructureType.DataGraphPipelineSessionNeuralStatisticsCreateInfoARM;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_ARM_data_graph_neural_accelerator_statistics"])]
    public void* PNext;

    [NativeName("mode")]
    [SupportedApiProfile("vulkan", ["VK_ARM_data_graph_neural_accelerator_statistics"])]
    public NeuralAcceleratorStatisticsModeARM Mode;

    [SupportedApiProfile("vulkan", ["VK_ARM_data_graph_neural_accelerator_statistics"])]
    public DataGraphPipelineSessionNeuralStatisticsCreateInfoARM() { }
}
