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
    [NativeName("Name", "VkDependencyInfo")]
    [NativeName("Aliases", "VkDependencyInfoKHR")]
    public unsafe partial struct DependencyInfo : IChainStart
    {
        public DependencyInfo
        (
            StructureType? sType = StructureType.DependencyInfo,
            void* pNext = null,
            DependencyFlags? dependencyFlags = null,
            uint? memoryBarrierCount = null,
            MemoryBarrier2* pMemoryBarriers = null,
            uint? bufferMemoryBarrierCount = null,
            BufferMemoryBarrier2* pBufferMemoryBarriers = null,
            uint? imageMemoryBarrierCount = null,
            ImageMemoryBarrier2* pImageMemoryBarriers = null
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

            if (dependencyFlags is not null)
            {
                DependencyFlags = dependencyFlags.Value;
            }

            if (memoryBarrierCount is not null)
            {
                MemoryBarrierCount = memoryBarrierCount.Value;
            }

            if (pMemoryBarriers is not null)
            {
                PMemoryBarriers = pMemoryBarriers;
            }

            if (bufferMemoryBarrierCount is not null)
            {
                BufferMemoryBarrierCount = bufferMemoryBarrierCount.Value;
            }

            if (pBufferMemoryBarriers is not null)
            {
                PBufferMemoryBarriers = pBufferMemoryBarriers;
            }

            if (imageMemoryBarrierCount is not null)
            {
                ImageMemoryBarrierCount = imageMemoryBarrierCount.Value;
            }

            if (pImageMemoryBarriers is not null)
            {
                PImageMemoryBarriers = pImageMemoryBarriers;
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
        [NativeName("Type", "VkDependencyFlags")]
        [NativeName("Type.Name", "VkDependencyFlags")]
        [NativeName("Name", "dependencyFlags")]
        public DependencyFlags DependencyFlags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "memoryBarrierCount")]
        public uint MemoryBarrierCount;
/// <summary></summary>
        [NativeName("Type", "VkMemoryBarrier2*")]
        [NativeName("Type.Name", "VkMemoryBarrier2")]
        [NativeName("Name", "pMemoryBarriers")]
        public MemoryBarrier2* PMemoryBarriers;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "bufferMemoryBarrierCount")]
        public uint BufferMemoryBarrierCount;
/// <summary></summary>
        [NativeName("Type", "VkBufferMemoryBarrier2*")]
        [NativeName("Type.Name", "VkBufferMemoryBarrier2")]
        [NativeName("Name", "pBufferMemoryBarriers")]
        public BufferMemoryBarrier2* PBufferMemoryBarriers;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "imageMemoryBarrierCount")]
        public uint ImageMemoryBarrierCount;
/// <summary></summary>
        [NativeName("Type", "VkImageMemoryBarrier2*")]
        [NativeName("Type.Name", "VkImageMemoryBarrier2")]
        [NativeName("Name", "pImageMemoryBarriers")]
        public ImageMemoryBarrier2* PImageMemoryBarriers;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DependencyInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }

        /// <summary>
        /// Convenience method to start a chain.
        /// </summary>
        /// <param name="capture">The newly created chain root</param>
        /// <returns>A reference to the newly created chain.</returns>
        public static unsafe ref DependencyInfo Chain(
            out DependencyInfo capture)
        {
            capture = new DependencyInfo(StructureType.DependencyInfo);
            return ref capture;
        }
    }
}
