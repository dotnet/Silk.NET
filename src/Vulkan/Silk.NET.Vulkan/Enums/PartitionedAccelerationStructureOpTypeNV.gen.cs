// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPartitionedAccelerationStructureOpTypeNV")]
    public enum PartitionedAccelerationStructureOpTypeNV : int
    {
        [Obsolete("Deprecated in favour of \"WriteInstanceNV\"")]
        [NativeName("Name", "VK_PARTITIONED_ACCELERATION_STRUCTURE_OP_TYPE_WRITE_INSTANCE_NV")]
        PartitionedAccelerationStructureOpTypeWriteInstanceNV = 0,
        [Obsolete("Deprecated in favour of \"UpdateInstanceNV\"")]
        [NativeName("Name", "VK_PARTITIONED_ACCELERATION_STRUCTURE_OP_TYPE_UPDATE_INSTANCE_NV")]
        PartitionedAccelerationStructureOpTypeUpdateInstanceNV = 1,
        [Obsolete("Deprecated in favour of \"WritePartitionTranslationNV\"")]
        [NativeName("Name", "VK_PARTITIONED_ACCELERATION_STRUCTURE_OP_TYPE_WRITE_PARTITION_TRANSLATION_NV")]
        PartitionedAccelerationStructureOpTypeWritePartitionTranslationNV = 2,
        [NativeName("Name", "VK_PARTITIONED_ACCELERATION_STRUCTURE_OP_TYPE_WRITE_INSTANCE_NV")]
        WriteInstanceNV = 0,
        [NativeName("Name", "VK_PARTITIONED_ACCELERATION_STRUCTURE_OP_TYPE_UPDATE_INSTANCE_NV")]
        UpdateInstanceNV = 1,
        [NativeName("Name", "VK_PARTITIONED_ACCELERATION_STRUCTURE_OP_TYPE_WRITE_PARTITION_TRANSLATION_NV")]
        WritePartitionTranslationNV = 2,
    }
}
