// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPhysicalDeviceDataGraphOperationTypeARM")]
    public enum PhysicalDeviceDataGraphOperationTypeARM : int
    {
        [Obsolete("Deprecated in favour of \"SpirvExtendedInstructionSetArm\"")]
        [NativeName("Name", "VK_PHYSICAL_DEVICE_DATA_GRAPH_OPERATION_TYPE_SPIRV_EXTENDED_INSTRUCTION_SET_ARM")]
        PhysicalDeviceDataGraphOperationTypeSpirvExtendedInstructionSetArm = 0,
        [Obsolete("Deprecated in favour of \"NeuralModelQCom\"")]
        [NativeName("Name", "VK_PHYSICAL_DEVICE_DATA_GRAPH_OPERATION_TYPE_NEURAL_MODEL_QCOM")]
        PhysicalDeviceDataGraphOperationTypeNeuralModelQCom = 1000629000,
        [Obsolete("Deprecated in favour of \"BuiltinModelQCom\"")]
        [NativeName("Name", "VK_PHYSICAL_DEVICE_DATA_GRAPH_OPERATION_TYPE_BUILTIN_MODEL_QCOM")]
        PhysicalDeviceDataGraphOperationTypeBuiltinModelQCom = 1000629001,
        [NativeName("Name", "VK_PHYSICAL_DEVICE_DATA_GRAPH_OPERATION_TYPE_SPIRV_EXTENDED_INSTRUCTION_SET_ARM")]
        SpirvExtendedInstructionSetArm = 0,
        [NativeName("Name", "VK_PHYSICAL_DEVICE_DATA_GRAPH_OPERATION_TYPE_NEURAL_MODEL_QCOM")]
        NeuralModelQCom = 1000629000,
        [NativeName("Name", "VK_PHYSICAL_DEVICE_DATA_GRAPH_OPERATION_TYPE_BUILTIN_MODEL_QCOM")]
        BuiltinModelQCom = 1000629001,
    }
}
