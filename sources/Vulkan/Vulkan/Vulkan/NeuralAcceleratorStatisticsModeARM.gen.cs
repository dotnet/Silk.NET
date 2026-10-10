// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkNeuralAcceleratorStatisticsModeARM")]
[SupportedApiProfile("vulkan")]
public enum NeuralAcceleratorStatisticsModeARM : uint
{
    [NativeName("VK_NEURAL_ACCELERATOR_STATISTICS_MODE_DISABLED_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_data_graph_neural_accelerator_statistics"])]
    Disabled = 0,

    [NativeName("VK_NEURAL_ACCELERATOR_STATISTICS_MODE_STATISTICS0_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_data_graph_neural_accelerator_statistics"])]
    Statistics0 = 1,

    [NativeName("VK_NEURAL_ACCELERATOR_STATISTICS_MODE_STATISTICS1_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_data_graph_neural_accelerator_statistics"])]
    Statistics1 = 2,
}
