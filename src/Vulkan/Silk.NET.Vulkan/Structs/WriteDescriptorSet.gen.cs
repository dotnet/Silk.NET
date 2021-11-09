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
    [NativeName("Name", "VkWriteDescriptorSet")]
    public unsafe partial struct WriteDescriptorSet : IChainStart
    {
        public WriteDescriptorSet
        (
            StructureType? sType = StructureType.WriteDescriptorSet,
            void* pNext = null,
            DescriptorSet? dstSet = null,
            uint? dstBinding = null,
            uint? dstArrayElement = null,
            uint? descriptorCount = null,
            DescriptorType? descriptorType = null,
            DescriptorImageInfo* pImageInfo = null,
            DescriptorBufferInfo* pBufferInfo = null,
            BufferView* pTexelBufferView = null
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

            if (dstSet is not null)
            {
                DstSet = dstSet.Value;
            }

            if (dstBinding is not null)
            {
                DstBinding = dstBinding.Value;
            }

            if (dstArrayElement is not null)
            {
                DstArrayElement = dstArrayElement.Value;
            }

            if (descriptorCount is not null)
            {
                DescriptorCount = descriptorCount.Value;
            }

            if (descriptorType is not null)
            {
                DescriptorType = descriptorType.Value;
            }

            if (pImageInfo is not null)
            {
                PImageInfo = pImageInfo;
            }

            if (pBufferInfo is not null)
            {
                PBufferInfo = pBufferInfo;
            }

            if (pTexelBufferView is not null)
            {
                PTexelBufferView = pTexelBufferView;
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
        [NativeName("Type", "VkDescriptorSet")]
        [NativeName("Type.Name", "VkDescriptorSet")]
        [NativeName("Name", "dstSet")]
        public DescriptorSet DstSet;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "dstBinding")]
        public uint DstBinding;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "dstArrayElement")]
        public uint DstArrayElement;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "descriptorCount")]
        public uint DescriptorCount;
/// <summary></summary>
        [NativeName("Type", "VkDescriptorType")]
        [NativeName("Type.Name", "VkDescriptorType")]
        [NativeName("Name", "descriptorType")]
        public DescriptorType DescriptorType;
/// <summary></summary>
        [NativeName("Type", "VkDescriptorImageInfo*")]
        [NativeName("Type.Name", "VkDescriptorImageInfo")]
        [NativeName("Name", "pImageInfo")]
        public DescriptorImageInfo* PImageInfo;
/// <summary></summary>
        [NativeName("Type", "VkDescriptorBufferInfo*")]
        [NativeName("Type.Name", "VkDescriptorBufferInfo")]
        [NativeName("Name", "pBufferInfo")]
        public DescriptorBufferInfo* PBufferInfo;
/// <summary></summary>
        [NativeName("Type", "VkBufferView*")]
        [NativeName("Type.Name", "VkBufferView")]
        [NativeName("Name", "pTexelBufferView")]
        public BufferView* PTexelBufferView;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.WriteDescriptorSet;
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
        public static unsafe ref WriteDescriptorSet Chain(
            out WriteDescriptorSet capture)
        {
            capture = new WriteDescriptorSet(StructureType.WriteDescriptorSet);
            return ref capture;
        }
    }
}
