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
    [NativeName("Name", "VkBuildPartitionedAccelerationStructureInfoNV")]
    public unsafe partial struct BuildPartitionedAccelerationStructureInfoNV : IChainable
    {
        public BuildPartitionedAccelerationStructureInfoNV
        (
            StructureType? sType = StructureType.BuildPartitionedAccelerationStructureInfoNV,
            void* pNext = null,
            PartitionedAccelerationStructureInstancesInputNV? input = null,
            ulong? srcAccelerationStructureData = null,
            ulong? dstAccelerationStructureData = null,
            ulong? scratchData = null,
            ulong? srcInfos = null,
            ulong? srcInfosCount = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (input is not null)
            {
                Input = input.Value;
            }

            if (srcAccelerationStructureData is not null)
            {
                SrcAccelerationStructureData = srcAccelerationStructureData.Value;
            }

            if (dstAccelerationStructureData is not null)
            {
                DstAccelerationStructureData = dstAccelerationStructureData.Value;
            }

            if (scratchData is not null)
            {
                ScratchData = scratchData.Value;
            }

            if (srcInfos is not null)
            {
                SrcInfos = srcInfos.Value;
            }

            if (srcInfosCount is not null)
            {
                SrcInfosCount = srcInfosCount.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkPartitionedAccelerationStructureInstancesInputNV")]
        [NativeName("Type.Name", "VkPartitionedAccelerationStructureInstancesInputNV")]
        [NativeName("Name", "input")]
        public PartitionedAccelerationStructureInstancesInputNV Input;
/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "srcAccelerationStructureData")]
        public ulong SrcAccelerationStructureData;
/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "dstAccelerationStructureData")]
        public ulong DstAccelerationStructureData;
/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "scratchData")]
        public ulong ScratchData;
/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "srcInfos")]
        public ulong SrcInfos;
/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "srcInfosCount")]
        public ulong SrcInfosCount;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.BuildPartitionedAccelerationStructureInfoNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
