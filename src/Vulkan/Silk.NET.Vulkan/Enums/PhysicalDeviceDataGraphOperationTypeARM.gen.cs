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
        [NativeName("Name", "VK_PHYSICAL_DEVICE_DATA_GRAPH_OPERATION_TYPE_SPIRV_EXTENDED_INSTRUCTION_SET_ARM")]
        SpirvExtendedInstructionSetArm = 0,
    }
}
