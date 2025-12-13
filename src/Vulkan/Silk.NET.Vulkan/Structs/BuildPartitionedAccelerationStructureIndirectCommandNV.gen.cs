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
    [NativeName("Name", "VkBuildPartitionedAccelerationStructureIndirectCommandNV")]
    public unsafe partial struct BuildPartitionedAccelerationStructureIndirectCommandNV
    {
        public BuildPartitionedAccelerationStructureIndirectCommandNV
        (
            PartitionedAccelerationStructureOpTypeNV? opType = null,
            uint? argCount = null,
            StridedDeviceAddressNV? argData = null
        ) : this()
        {
            if (opType is not null)
            {
                OpType = opType.Value;
            }

            if (argCount is not null)
            {
                ArgCount = argCount.Value;
            }

            if (argData is not null)
            {
                ArgData = argData.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkPartitionedAccelerationStructureOpTypeNV")]
        [NativeName("Type.Name", "VkPartitionedAccelerationStructureOpTypeNV")]
        [NativeName("Name", "opType")]
        public PartitionedAccelerationStructureOpTypeNV OpType;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "argCount")]
        public uint ArgCount;
/// <summary></summary>
        [NativeName("Type", "VkStridedDeviceAddressNV")]
        [NativeName("Type.Name", "VkStridedDeviceAddressNV")]
        [NativeName("Name", "argData")]
        public StridedDeviceAddressNV ArgData;
    }
}
