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
    [NativeName("Name", "VkPhysicalDeviceInlineUniformBlockPropertiesEXT")]
    public unsafe struct PhysicalDeviceInlineUniformBlockPropertiesEXT
    {
        public PhysicalDeviceInlineUniformBlockPropertiesEXT
        (
            StructureType sType = StructureType.PhysicalDeviceInlineUniformBlockPropertiesExt,
            void* pNext = default,
            uint maxInlineUniformBlockSize = default,
            uint maxPerStageDescriptorInlineUniformBlocks = default,
            uint maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks = default,
            uint maxDescriptorSetInlineUniformBlocks = default,
            uint maxDescriptorSetUpdateAfterBindInlineUniformBlocks = default
        )
        {
           SType = sType;
           PNext = pNext;
           MaxInlineUniformBlockSize = maxInlineUniformBlockSize;
           MaxPerStageDescriptorInlineUniformBlocks = maxPerStageDescriptorInlineUniformBlocks;
           MaxPerStageDescriptorUpdateAfterBindInlineUniformBlocks = maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
           MaxDescriptorSetInlineUniformBlocks = maxDescriptorSetInlineUniformBlocks;
           MaxDescriptorSetUpdateAfterBindInlineUniformBlocks = maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxInlineUniformBlockSize")]
        public uint MaxInlineUniformBlockSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPerStageDescriptorInlineUniformBlocks")]
        public uint MaxPerStageDescriptorInlineUniformBlocks;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks")]
        public uint MaxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorSetInlineUniformBlocks")]
        public uint MaxDescriptorSetInlineUniformBlocks;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorSetUpdateAfterBindInlineUniformBlocks")]
        public uint MaxDescriptorSetUpdateAfterBindInlineUniformBlocks;
    }
}
