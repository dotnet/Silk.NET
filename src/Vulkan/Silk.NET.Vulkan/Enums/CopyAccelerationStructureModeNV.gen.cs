// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkCopyAccelerationStructureModeNV")]
    public enum CopyAccelerationStructureModeNV : int
    {
        [Obsolete("Deprecated in favour of \"CloneKhr\"")]
        [NativeName("Name", "VK_COPY_ACCELERATION_STRUCTURE_MODE_CLONE_KHR")]
        CopyAccelerationStructureModeCloneKhr = 0,
        [Obsolete("Deprecated in favour of \"CompactKhr\"")]
        [NativeName("Name", "VK_COPY_ACCELERATION_STRUCTURE_MODE_COMPACT_KHR")]
        CopyAccelerationStructureModeCompactKhr = 1,
        [NativeName("Name", "VK_COPY_ACCELERATION_STRUCTURE_MODE_CLONE_KHR")]
        CloneKhr = 0,
        [NativeName("Name", "VK_COPY_ACCELERATION_STRUCTURE_MODE_COMPACT_KHR")]
        CompactKhr = 1,
    }
}
