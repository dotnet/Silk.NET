// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkAccelerationStructureMemoryRequirementsTypeNV")]
    public enum AccelerationStructureMemoryRequirementsTypeNV : int
    {
        [Obsolete("Deprecated in favour of \"ObjectNV\"")]
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_OBJECT_NV")]
        AccelerationStructureMemoryRequirementsTypeObjectNV = 0,
        [Obsolete("Deprecated in favour of \"BuildScratchNV\"")]
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_BUILD_SCRATCH_NV")]
        AccelerationStructureMemoryRequirementsTypeBuildScratchNV = 1,
        [Obsolete("Deprecated in favour of \"UpdateScratchNV\"")]
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_UPDATE_SCRATCH_NV")]
        AccelerationStructureMemoryRequirementsTypeUpdateScratchNV = 2,
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_OBJECT_NV")]
        ObjectNV = 0,
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_BUILD_SCRATCH_NV")]
        BuildScratchNV = 1,
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_UPDATE_SCRATCH_NV")]
        UpdateScratchNV = 2,
    }
}
