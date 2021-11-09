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
    [NativeName("Name", "VkBufferCreateInfo")]
    public unsafe partial struct BufferCreateInfo : IChainStart
    {
        public BufferCreateInfo
        (
            StructureType? sType = StructureType.BufferCreateInfo,
            void* pNext = null,
            BufferCreateFlags? flags = null,
            ulong? size = null,
            BufferUsageFlags? usage = null,
            SharingMode? sharingMode = null,
            uint? queueFamilyIndexCount = null,
            uint* pQueueFamilyIndices = null
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

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
            }

            if (usage is not null)
            {
                Usage = usage.Value;
            }

            if (sharingMode is not null)
            {
                SharingMode = sharingMode.Value;
            }

            if (queueFamilyIndexCount is not null)
            {
                QueueFamilyIndexCount = queueFamilyIndexCount.Value;
            }

            if (pQueueFamilyIndices is not null)
            {
                PQueueFamilyIndices = pQueueFamilyIndices;
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
        [NativeName("Type", "VkBufferCreateFlags")]
        [NativeName("Type.Name", "VkBufferCreateFlags")]
        [NativeName("Name", "flags")]
        public BufferCreateFlags Flags;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "size")]
        public ulong Size;
/// <summary></summary>
        [NativeName("Type", "VkBufferUsageFlags")]
        [NativeName("Type.Name", "VkBufferUsageFlags")]
        [NativeName("Name", "usage")]
        public BufferUsageFlags Usage;
/// <summary></summary>
        [NativeName("Type", "VkSharingMode")]
        [NativeName("Type.Name", "VkSharingMode")]
        [NativeName("Name", "sharingMode")]
        public SharingMode SharingMode;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "queueFamilyIndexCount")]
        public uint QueueFamilyIndexCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pQueueFamilyIndices")]
        public uint* PQueueFamilyIndices;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.BufferCreateInfo;
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
        public static unsafe ref BufferCreateInfo Chain(
            out BufferCreateInfo capture)
        {
            capture = new BufferCreateInfo(StructureType.BufferCreateInfo);
            return ref capture;
        }
    }
}
