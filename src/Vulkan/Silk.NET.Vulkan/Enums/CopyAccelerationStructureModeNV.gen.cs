// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkCopyAccelerationStructureModeNV")]
    public enum CopyAccelerationStructureModeNV
    {
        [NativeName("Name", "VK_COPY_ACCELERATION_STRUCTURE_MODE_CLONE_KHR")]
        CopyAccelerationStructureModeCloneKhr = 0,
        [NativeName("Name", "VK_COPY_ACCELERATION_STRUCTURE_MODE_COMPACT_KHR")]
        CopyAccelerationStructureModeCompactKhr = 1,
        [NativeName("Name", "VK_COPY_ACCELERATION_STRUCTURE_MODE_SERIALIZE_KHR")]
        CopyAccelerationStructureModeSerializeKhr = 2,
        [NativeName("Name", "VK_COPY_ACCELERATION_STRUCTURE_MODE_DESERIALIZE_KHR")]
        CopyAccelerationStructureModeDeserializeKhr = 3,
    }
}
