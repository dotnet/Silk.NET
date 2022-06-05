// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkCopyAccelerationStructureModeKHR")]
    public enum CopyAccelerationStructureModeKHR : int
    {
        [Obsolete("Deprecated in favour of \"CloneKhr\"")]
        [NativeName("Name", "VK_COPY_ACCELERATION_STRUCTURE_MODE_CLONE_KHR")]
        CopyAccelerationStructureModeCloneKhr = 0,
        [Obsolete("Deprecated in favour of \"CompactKhr\"")]
        [NativeName("Name", "VK_COPY_ACCELERATION_STRUCTURE_MODE_COMPACT_KHR")]
        CopyAccelerationStructureModeCompactKhr = 1,
        [Obsolete("Deprecated in favour of \"SerializeKhr\"")]
        [NativeName("Name", "VK_COPY_ACCELERATION_STRUCTURE_MODE_SERIALIZE_KHR")]
        CopyAccelerationStructureModeSerializeKhr = 2,
        [Obsolete("Deprecated in favour of \"DeserializeKhr\"")]
        [NativeName("Name", "VK_COPY_ACCELERATION_STRUCTURE_MODE_DESERIALIZE_KHR")]
        CopyAccelerationStructureModeDeserializeKhr = 3,
        [NativeName("Name", "VK_COPY_ACCELERATION_STRUCTURE_MODE_CLONE_KHR")]
        CloneKhr = 0,
        [NativeName("Name", "VK_COPY_ACCELERATION_STRUCTURE_MODE_COMPACT_KHR")]
        CompactKhr = 1,
        [NativeName("Name", "VK_COPY_ACCELERATION_STRUCTURE_MODE_SERIALIZE_KHR")]
        SerializeKhr = 2,
        [NativeName("Name", "VK_COPY_ACCELERATION_STRUCTURE_MODE_DESERIALIZE_KHR")]
        DeserializeKhr = 3,
    }
}
