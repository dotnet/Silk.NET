// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPhysicalDeviceDataGraphProcessingEngineTypeARM")]
    public enum PhysicalDeviceDataGraphProcessingEngineTypeARM : int
    {
        [Obsolete("Deprecated in favour of \"DefaultArm\"")]
        [NativeName("Name", "VK_PHYSICAL_DEVICE_DATA_GRAPH_PROCESSING_ENGINE_TYPE_DEFAULT_ARM")]
        PhysicalDeviceDataGraphProcessingEngineTypeDefaultArm = 0,
        [Obsolete("Deprecated in favour of \"NeuralQCom\"")]
        [NativeName("Name", "VK_PHYSICAL_DEVICE_DATA_GRAPH_PROCESSING_ENGINE_TYPE_NEURAL_QCOM")]
        PhysicalDeviceDataGraphProcessingEngineTypeNeuralQCom = 1000629000,
        [Obsolete("Deprecated in favour of \"ComputeQCom\"")]
        [NativeName("Name", "VK_PHYSICAL_DEVICE_DATA_GRAPH_PROCESSING_ENGINE_TYPE_COMPUTE_QCOM")]
        PhysicalDeviceDataGraphProcessingEngineTypeComputeQCom = 1000629001,
        [NativeName("Name", "VK_PHYSICAL_DEVICE_DATA_GRAPH_PROCESSING_ENGINE_TYPE_DEFAULT_ARM")]
        DefaultArm = 0,
        [NativeName("Name", "VK_PHYSICAL_DEVICE_DATA_GRAPH_PROCESSING_ENGINE_TYPE_NEURAL_QCOM")]
        NeuralQCom = 1000629000,
        [NativeName("Name", "VK_PHYSICAL_DEVICE_DATA_GRAPH_PROCESSING_ENGINE_TYPE_COMPUTE_QCOM")]
        ComputeQCom = 1000629001,
    }
}
