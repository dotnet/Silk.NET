// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkWriteDescriptorSet")]
    public unsafe partial struct WriteDescriptorSet
    {
        public WriteDescriptorSet
        (
            StructureType sType = StructureType.WriteDescriptorSet,
            void* pNext = default,
            DescriptorSet dstSet = default,
            uint dstBinding = default,
            uint dstArrayElement = default,
            uint descriptorCount = default,
            DescriptorType descriptorType = default,
            DescriptorImageInfo* pImageInfo = default,
            DescriptorBufferInfo* pBufferInfo = default,
            BufferView* pTexelBufferView = default
        )
        {
            SType = sType;
            PNext = pNext;
            DstSet = dstSet;
            DstBinding = dstBinding;
            DstArrayElement = dstArrayElement;
            DescriptorCount = descriptorCount;
            DescriptorType = descriptorType;
            PImageInfo = pImageInfo;
            PBufferInfo = pBufferInfo;
            PTexelBufferView = pTexelBufferView;
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
    }
}
