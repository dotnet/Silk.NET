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
    [NativeName("Name", "VkBindImageMemoryInfoKHR")]
    [NativeName("AliasOf", "VkBindImageMemoryInfo")]
    public unsafe partial struct BindImageMemoryInfoKHR : IChainStart
    {
        public BindImageMemoryInfoKHR
        (
            StructureType? sType = StructureType.BindImageMemoryInfo,
            void* pNext = null,
            Image? image = null,
            DeviceMemory? memory = null,
            ulong? memoryOffset = null
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

            if (image is not null)
            {
                Image = image.Value;
            }

            if (memory is not null)
            {
                Memory = memory.Value;
            }

            if (memoryOffset is not null)
            {
                MemoryOffset = memoryOffset.Value;
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
        [NativeName("Type", "VkImage")]
        [NativeName("Type.Name", "VkImage")]
        [NativeName("Name", "image")]
        public Image Image;
/// <summary></summary>
        [NativeName("Type", "VkDeviceMemory")]
        [NativeName("Type.Name", "VkDeviceMemory")]
        [NativeName("Name", "memory")]
        public DeviceMemory Memory;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "memoryOffset")]
        public ulong MemoryOffset;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.BindImageMemoryInfo;
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
        public static unsafe ref BindImageMemoryInfoKHR Chain(
            out BindImageMemoryInfoKHR capture)
        {
            capture = new BindImageMemoryInfoKHR(StructureType.BindImageMemoryInfo);
            return ref capture;
        }
    }
}
