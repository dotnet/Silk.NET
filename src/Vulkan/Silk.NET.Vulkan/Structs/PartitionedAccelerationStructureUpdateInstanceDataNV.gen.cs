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
    [NativeName("Name", "VkPartitionedAccelerationStructureUpdateInstanceDataNV")]
    public unsafe partial struct PartitionedAccelerationStructureUpdateInstanceDataNV
    {
        public PartitionedAccelerationStructureUpdateInstanceDataNV
        (
            uint? instanceIndex = null,
            uint? instanceContributionToHitGroupIndex = null,
            ulong? accelerationStructure = null
        ) : this()
        {
            if (instanceIndex is not null)
            {
                InstanceIndex = instanceIndex.Value;
            }

            if (instanceContributionToHitGroupIndex is not null)
            {
                InstanceContributionToHitGroupIndex = instanceContributionToHitGroupIndex.Value;
            }

            if (accelerationStructure is not null)
            {
                AccelerationStructure = accelerationStructure.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "instanceIndex")]
        public uint InstanceIndex;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "instanceContributionToHitGroupIndex")]
        public uint InstanceContributionToHitGroupIndex;
/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "accelerationStructure")]
        public ulong AccelerationStructure;
    }
}
