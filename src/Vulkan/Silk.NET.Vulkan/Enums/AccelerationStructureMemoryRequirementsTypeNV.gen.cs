// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkAccelerationStructureMemoryRequirementsTypeNV")]
    public enum AccelerationStructureMemoryRequirementsTypeNV : int
    {
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_OBJECT_NV")]
        AccelerationStructureMemoryRequirementsTypeObjectNV = 0,
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_BUILD_SCRATCH_NV")]
        AccelerationStructureMemoryRequirementsTypeBuildScratchNV = 1,
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_UPDATE_SCRATCH_NV")]
        AccelerationStructureMemoryRequirementsTypeUpdateScratchNV = 2,
    }
}
