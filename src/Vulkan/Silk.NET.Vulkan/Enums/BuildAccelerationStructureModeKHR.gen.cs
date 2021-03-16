// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkBuildAccelerationStructureModeKHR")]
    public enum BuildAccelerationStructureModeKHR : int
    {
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_MODE_BUILD_KHR")]
        BuildAccelerationStructureModeBuildKhr = 0,
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_MODE_UPDATE_KHR")]
        BuildAccelerationStructureModeUpdateKhr = 1,
    }
}
