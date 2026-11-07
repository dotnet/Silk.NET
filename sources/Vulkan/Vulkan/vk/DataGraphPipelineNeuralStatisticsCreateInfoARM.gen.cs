// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDataGraphPipelineNeuralStatisticsCreateInfoARM")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct DataGraphPipelineNeuralStatisticsCreateInfoARM
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_ARM_data_graph_neural_accelerator_statistics"])]
    public StructureType SType = StructureType.DataGraphPipelineNeuralStatisticsCreateInfoARM;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_ARM_data_graph_neural_accelerator_statistics"])]
    public void* PNext;

    [NativeName("allowNeuralStatistics")]
    [SupportedApiProfile("vulkan", ["VK_ARM_data_graph_neural_accelerator_statistics"])]
    public MaybeBool<uint> AllowNeuralStatistics;

    [SupportedApiProfile("vulkan", ["VK_ARM_data_graph_neural_accelerator_statistics"])]
    public DataGraphPipelineNeuralStatisticsCreateInfoARM() { }
}
