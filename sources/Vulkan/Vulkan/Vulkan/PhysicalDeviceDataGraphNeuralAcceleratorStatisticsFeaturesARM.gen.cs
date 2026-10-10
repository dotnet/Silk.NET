// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceDataGraphNeuralAcceleratorStatisticsFeaturesARM")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceDataGraphNeuralAcceleratorStatisticsFeaturesARM
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_ARM_data_graph_neural_accelerator_statistics"])]
    public StructureType SType =
        StructureType.PhysicalDeviceDataGraphNeuralAcceleratorStatisticsFeaturesARM;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_ARM_data_graph_neural_accelerator_statistics"])]
    public void* PNext;

    [NativeName("dataGraphNeuralAcceleratorStatistics")]
    [SupportedApiProfile("vulkan", ["VK_ARM_data_graph_neural_accelerator_statistics"])]
    public MaybeBool<uint> DataGraphNeuralAcceleratorStatistics;

    [SupportedApiProfile("vulkan", ["VK_ARM_data_graph_neural_accelerator_statistics"])]
    public PhysicalDeviceDataGraphNeuralAcceleratorStatisticsFeaturesARM() { }
}
