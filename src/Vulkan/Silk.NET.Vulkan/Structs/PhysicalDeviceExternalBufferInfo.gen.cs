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
    [NativeName("Name", "VkPhysicalDeviceExternalBufferInfo")]
    [NativeName("Aliases", "VkPhysicalDeviceExternalBufferInfoKHR")]
    public unsafe partial struct PhysicalDeviceExternalBufferInfo : IChainStart
    {
        public PhysicalDeviceExternalBufferInfo
        (
            StructureType? sType = StructureType.PhysicalDeviceExternalBufferInfo,
            void* pNext = null,
            BufferCreateFlags? flags = null,
            BufferUsageFlags? usage = null,
            ExternalMemoryHandleTypeFlags? handleType = null
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

            if (usage is not null)
            {
                Usage = usage.Value;
            }

            if (handleType is not null)
            {
                HandleType = handleType.Value;
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
        [NativeName("Type", "VkBufferUsageFlags")]
        [NativeName("Type.Name", "VkBufferUsageFlags")]
        [NativeName("Name", "usage")]
        public BufferUsageFlags Usage;
/// <summary></summary>
        [NativeName("Type", "VkExternalMemoryHandleTypeFlagBits")]
        [NativeName("Type.Name", "VkExternalMemoryHandleTypeFlagBits")]
        [NativeName("Name", "handleType")]
        public ExternalMemoryHandleTypeFlags HandleType;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceExternalBufferInfo;
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
        public static unsafe ref PhysicalDeviceExternalBufferInfo Chain(
            out PhysicalDeviceExternalBufferInfo capture)
        {
            capture = new PhysicalDeviceExternalBufferInfo(StructureType.PhysicalDeviceExternalBufferInfo);
            return ref capture;
        }
    }
}
