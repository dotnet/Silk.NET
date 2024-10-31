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
    [NativeName("Name", "VkPhysicalDeviceTexelBufferAlignmentProperties")]
    [NativeName("Aliases", "VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT")]
    public unsafe partial struct PhysicalDeviceTexelBufferAlignmentProperties : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceTexelBufferAlignmentProperties
        (
            StructureType? sType = StructureType.PhysicalDeviceTexelBufferAlignmentProperties,
            void* pNext = null,
            ulong? storageTexelBufferOffsetAlignmentBytes = null,
            Bool32? storageTexelBufferOffsetSingleTexelAlignment = null,
            ulong? uniformTexelBufferOffsetAlignmentBytes = null,
            Bool32? uniformTexelBufferOffsetSingleTexelAlignment = null
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

            if (storageTexelBufferOffsetAlignmentBytes is not null)
            {
                StorageTexelBufferOffsetAlignmentBytes = storageTexelBufferOffsetAlignmentBytes.Value;
            }

            if (storageTexelBufferOffsetSingleTexelAlignment is not null)
            {
                StorageTexelBufferOffsetSingleTexelAlignment = storageTexelBufferOffsetSingleTexelAlignment.Value;
            }

            if (uniformTexelBufferOffsetAlignmentBytes is not null)
            {
                UniformTexelBufferOffsetAlignmentBytes = uniformTexelBufferOffsetAlignmentBytes.Value;
            }

            if (uniformTexelBufferOffsetSingleTexelAlignment is not null)
            {
                UniformTexelBufferOffsetSingleTexelAlignment = uniformTexelBufferOffsetSingleTexelAlignment.Value;
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
        [NativeName("Name", "storageTexelBufferOffsetAlignmentBytes")]
        public ulong StorageTexelBufferOffsetAlignmentBytes;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "storageTexelBufferOffsetSingleTexelAlignment")]
        public Bool32 StorageTexelBufferOffsetSingleTexelAlignment;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "uniformTexelBufferOffsetAlignmentBytes")]
        public ulong UniformTexelBufferOffsetAlignmentBytes;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "uniformTexelBufferOffsetSingleTexelAlignment")]
        public Bool32 UniformTexelBufferOffsetSingleTexelAlignment;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }


        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceTexelBufferAlignmentProperties;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
