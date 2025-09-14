// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkPartitionedAccelerationStructureInstanceFlagsNV")]
    public enum PartitionedAccelerationStructureInstanceFlagsNV : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"TriangleFacingCullDisableBitNV\"")]
        [NativeName("Name", "VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_TRIANGLE_FACING_CULL_DISABLE_BIT_NV")]
        PartitionedAccelerationStructureInstanceFlagTriangleFacingCullDisableBitNV = 1,
        [Obsolete("Deprecated in favour of \"TriangleFlipFacingBitNV\"")]
        [NativeName("Name", "VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_TRIANGLE_FLIP_FACING_BIT_NV")]
        PartitionedAccelerationStructureInstanceFlagTriangleFlipFacingBitNV = 2,
        [Obsolete("Deprecated in favour of \"ForceOpaqueBitNV\"")]
        [NativeName("Name", "VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_FORCE_OPAQUE_BIT_NV")]
        PartitionedAccelerationStructureInstanceFlagForceOpaqueBitNV = 4,
        [Obsolete("Deprecated in favour of \"ForceNoOpaqueBitNV\"")]
        [NativeName("Name", "VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_FORCE_NO_OPAQUE_BIT_NV")]
        PartitionedAccelerationStructureInstanceFlagForceNoOpaqueBitNV = 8,
        [Obsolete("Deprecated in favour of \"EnableExplicitBoundingBoxNV\"")]
        [NativeName("Name", "VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_ENABLE_EXPLICIT_BOUNDING_BOX_NV")]
        PartitionedAccelerationStructureInstanceFlagEnableExplicitBoundingBoxNV = 16,
        [NativeName("Name", "VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_TRIANGLE_FACING_CULL_DISABLE_BIT_NV")]
        TriangleFacingCullDisableBitNV = 1,
        [NativeName("Name", "VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_TRIANGLE_FLIP_FACING_BIT_NV")]
        TriangleFlipFacingBitNV = 2,
        [NativeName("Name", "VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_FORCE_OPAQUE_BIT_NV")]
        ForceOpaqueBitNV = 4,
        [NativeName("Name", "VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_FORCE_NO_OPAQUE_BIT_NV")]
        ForceNoOpaqueBitNV = 8,
        [NativeName("Name", "VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_ENABLE_EXPLICIT_BOUNDING_BOX_NV")]
        EnableExplicitBoundingBoxNV = 16,
    }
}
