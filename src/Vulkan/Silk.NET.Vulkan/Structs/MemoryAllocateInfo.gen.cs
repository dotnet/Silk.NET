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
    [NativeName("Name", "VkMemoryAllocateInfo")]
    public unsafe partial struct MemoryAllocateInfo : IChainStart
    {
        public MemoryAllocateInfo
        (
            StructureType? sType = StructureType.MemoryAllocateInfo,
            void* pNext = null,
            ulong? allocationSize = null,
            uint? memoryTypeIndex = null
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

            if (allocationSize is not null)
            {
                AllocationSize = allocationSize.Value;
            }

            if (memoryTypeIndex is not null)
            {
                MemoryTypeIndex = memoryTypeIndex.Value;
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
        [NativeName("Name", "allocationSize")]
        public ulong AllocationSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "memoryTypeIndex")]
        public uint MemoryTypeIndex;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.MemoryAllocateInfo;
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
        public static unsafe ref MemoryAllocateInfo Chain(
            out MemoryAllocateInfo capture)
        {
            capture = new MemoryAllocateInfo(StructureType.MemoryAllocateInfo);
            return ref capture;
        }
    }
}
