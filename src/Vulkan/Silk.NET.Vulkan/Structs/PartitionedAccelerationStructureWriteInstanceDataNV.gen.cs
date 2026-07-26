// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPartitionedAccelerationStructureWriteInstanceDataNV")]
    public unsafe partial struct PartitionedAccelerationStructureWriteInstanceDataNV
    {
        public PartitionedAccelerationStructureWriteInstanceDataNV
        (
            TransformMatrixKHR? transform = null,
            uint? instanceID = null,
            uint? instanceMask = null,
            uint? instanceContributionToHitGroupIndex = null,
            PartitionedAccelerationStructureInstanceFlagsNV? instanceFlags = null,
            uint? instanceIndex = null,
            uint? partitionIndex = null,
            ulong? accelerationStructure = null
        ) : this()
        {
            if (transform is not null)
            {
                Transform = transform.Value;
            }

            if (instanceID is not null)
            {
                InstanceID = instanceID.Value;
            }

            if (instanceMask is not null)
            {
                InstanceMask = instanceMask.Value;
            }

            if (instanceContributionToHitGroupIndex is not null)
            {
                InstanceContributionToHitGroupIndex = instanceContributionToHitGroupIndex.Value;
            }

            if (instanceFlags is not null)
            {
                InstanceFlags = instanceFlags.Value;
            }

            if (instanceIndex is not null)
            {
                InstanceIndex = instanceIndex.Value;
            }

            if (partitionIndex is not null)
            {
                PartitionIndex = partitionIndex.Value;
            }

            if (accelerationStructure is not null)
            {
                AccelerationStructure = accelerationStructure.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkTransformMatrixKHR")]
        [NativeName("Type.Name", "VkTransformMatrixKHR")]
        [NativeName("Name", "transform")]
        public TransformMatrixKHR Transform;
        /// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "explicitAABB")]
        public fixed float ExplicitAabb[6];
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "instanceID")]
        public uint InstanceID;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "instanceMask")]
        public uint InstanceMask;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "instanceContributionToHitGroupIndex")]
        public uint InstanceContributionToHitGroupIndex;
/// <summary></summary>
        [NativeName("Type", "VkPartitionedAccelerationStructureInstanceFlagsNV")]
        [NativeName("Type.Name", "VkPartitionedAccelerationStructureInstanceFlagsNV")]
        [NativeName("Name", "instanceFlags")]
        public PartitionedAccelerationStructureInstanceFlagsNV InstanceFlags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "instanceIndex")]
        public uint InstanceIndex;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "partitionIndex")]
        public uint PartitionIndex;
/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "accelerationStructure")]
        public ulong AccelerationStructure;
    }
}
