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
    [NativeName("Name", "VkAccelerationStructureBuildSizesInfoKHR")]
    public unsafe partial struct AccelerationStructureBuildSizesInfoKHR : IChainable
    {
        public AccelerationStructureBuildSizesInfoKHR
        (
            StructureType? sType = StructureType.AccelerationStructureBuildSizesInfoKhr,
            void* pNext = null,
            ulong? accelerationStructureSize = null,
            ulong? updateScratchSize = null,
            ulong? buildScratchSize = null
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

            if (accelerationStructureSize is not null)
            {
                AccelerationStructureSize = accelerationStructureSize.Value;
            }

            if (updateScratchSize is not null)
            {
                UpdateScratchSize = updateScratchSize.Value;
            }

            if (buildScratchSize is not null)
            {
                BuildScratchSize = buildScratchSize.Value;
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
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "accelerationStructureSize")]
        public ulong AccelerationStructureSize;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "updateScratchSize")]
        public ulong UpdateScratchSize;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "buildScratchSize")]
        public ulong BuildScratchSize;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.AccelerationStructureBuildSizesInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
