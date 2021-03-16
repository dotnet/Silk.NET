// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkAccelerationStructureCompatibilityKHR")]
    public enum AccelerationStructureCompatibilityKHR : int
    {
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_COMPATIBILITY_COMPATIBLE_KHR")]
        AccelerationStructureCompatibilityCompatibleKhr = 0,
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_COMPATIBILITY_INCOMPATIBLE_KHR")]
        AccelerationStructureCompatibilityIncompatibleKhr = 1,
    }
}
