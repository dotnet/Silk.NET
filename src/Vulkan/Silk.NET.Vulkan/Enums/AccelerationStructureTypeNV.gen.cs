// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkAccelerationStructureTypeNV")]
    public enum AccelerationStructureTypeNV : int
    {
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL_KHR")]
        AccelerationStructureTypeTopLevelKhr = 0,
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL_KHR")]
        AccelerationStructureTypeBottomLevelKhr = 1,
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_TYPE_GENERIC_KHR")]
        AccelerationStructureTypeGenericKhr = 2,
    }
}
