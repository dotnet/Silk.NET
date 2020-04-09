// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct WriteDescriptorSet
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public DescriptorSet DstSet;
/// <summary></summary>
        public uint DstBinding;
/// <summary></summary>
        public uint DstArrayElement;
/// <summary></summary>
        public uint DescriptorCount;
/// <summary></summary>
        public DescriptorType DescriptorType;
/// <summary></summary>
        public DescriptorImageInfo* PImageInfo;
/// <summary></summary>
        public DescriptorBufferInfo* PBufferInfo;
/// <summary></summary>
        public BufferView* PTexelBufferView;
    }
}
