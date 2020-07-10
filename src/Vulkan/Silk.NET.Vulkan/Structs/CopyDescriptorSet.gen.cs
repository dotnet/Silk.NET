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
    [NativeName("Name", "VkCopyDescriptorSet")]
    public unsafe partial struct CopyDescriptorSet
    {
        public CopyDescriptorSet
        (
            StructureType sType = StructureType.CopyDescriptorSet,
            void* pNext = default,
            DescriptorSet srcSet = default,
            uint srcBinding = default,
            uint srcArrayElement = default,
            DescriptorSet dstSet = default,
            uint dstBinding = default,
            uint dstArrayElement = default,
            uint descriptorCount = default
        )
        {
            SType = sType;
            PNext = pNext;
            SrcSet = srcSet;
            SrcBinding = srcBinding;
            SrcArrayElement = srcArrayElement;
            DstSet = dstSet;
            DstBinding = dstBinding;
            DstArrayElement = dstArrayElement;
            DescriptorCount = descriptorCount;
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
        [NativeName("Name", "srcSet")]
        public DescriptorSet SrcSet;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "srcBinding")]
        public uint SrcBinding;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "srcArrayElement")]
        public uint SrcArrayElement;
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
    }
}
