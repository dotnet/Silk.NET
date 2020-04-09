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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint MaxInlineUniformBlockSize;
/// <summary></summary>
        public uint MaxPerStageDescriptorInlineUniformBlocks;
/// <summary></summary>
        public uint MaxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
/// <summary></summary>
        public uint MaxDescriptorSetInlineUniformBlocks;
/// <summary></summary>
        public uint MaxDescriptorSetUpdateAfterBindInlineUniformBlocks;
    }
}
