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
    [NativeName("Name", "VkPhysicalDeviceExtendedSparseAddressSpacePropertiesNV")]
    public unsafe partial struct PhysicalDeviceExtendedSparseAddressSpacePropertiesNV : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceExtendedSparseAddressSpacePropertiesNV
        (
            StructureType? sType = StructureType.PhysicalDeviceExtendedSparseAddressSpacePropertiesNV,
            void* pNext = null,
            ulong? extendedSparseAddressSpaceSize = null,
            ImageUsageFlags? extendedSparseImageUsageFlags = null,
            BufferUsageFlags? extendedSparseBufferUsageFlags = null
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

            if (extendedSparseAddressSpaceSize is not null)
            {
                ExtendedSparseAddressSpaceSize = extendedSparseAddressSpaceSize.Value;
            }

            if (extendedSparseImageUsageFlags is not null)
            {
                ExtendedSparseImageUsageFlags = extendedSparseImageUsageFlags.Value;
            }

            if (extendedSparseBufferUsageFlags is not null)
            {
                ExtendedSparseBufferUsageFlags = extendedSparseBufferUsageFlags.Value;
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
        [NativeName("Name", "extendedSparseAddressSpaceSize")]
        public ulong ExtendedSparseAddressSpaceSize;
/// <summary></summary>
        [NativeName("Type", "VkImageUsageFlags")]
        [NativeName("Type.Name", "VkImageUsageFlags")]
        [NativeName("Name", "extendedSparseImageUsageFlags")]
        public ImageUsageFlags ExtendedSparseImageUsageFlags;
/// <summary></summary>
        [NativeName("Type", "VkBufferUsageFlags")]
        [NativeName("Type.Name", "VkBufferUsageFlags")]
        [NativeName("Name", "extendedSparseBufferUsageFlags")]
        public BufferUsageFlags ExtendedSparseBufferUsageFlags;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceExtendedSparseAddressSpacePropertiesNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
