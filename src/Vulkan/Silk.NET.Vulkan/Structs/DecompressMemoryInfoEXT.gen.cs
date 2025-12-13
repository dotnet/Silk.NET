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
    [NativeName("Name", "VkDecompressMemoryInfoEXT")]
    public unsafe partial struct DecompressMemoryInfoEXT : IChainable
    {
        public DecompressMemoryInfoEXT
        (
            StructureType? sType = StructureType.DecompressMemoryInfoExt,
            void* pNext = null,
            MemoryDecompressionMethodFlagsEXT? decompressionMethod = null,
            uint? regionCount = null,
            DecompressMemoryRegionEXT* pRegions = null
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

            if (decompressionMethod is not null)
            {
                DecompressionMethod = decompressionMethod.Value;
            }

            if (regionCount is not null)
            {
                RegionCount = regionCount.Value;
            }

            if (pRegions is not null)
            {
                PRegions = pRegions;
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
        [NativeName("Type", "VkMemoryDecompressionMethodFlagsEXT")]
        [NativeName("Type.Name", "VkMemoryDecompressionMethodFlagsEXT")]
        [NativeName("Name", "decompressionMethod")]
        public MemoryDecompressionMethodFlagsEXT DecompressionMethod;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "regionCount")]
        public uint RegionCount;
/// <summary></summary>
        [NativeName("Type", "VkDecompressMemoryRegionEXT*")]
        [NativeName("Type.Name", "VkDecompressMemoryRegionEXT")]
        [NativeName("Name", "pRegions")]
        public DecompressMemoryRegionEXT* PRegions;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DecompressMemoryInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
