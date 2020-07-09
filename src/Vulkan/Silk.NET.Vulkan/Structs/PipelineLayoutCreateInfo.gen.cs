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
    [NativeName("Name", "VkPipelineLayoutCreateInfo")]
    public unsafe struct PipelineLayoutCreateInfo
    {
        public PipelineLayoutCreateInfo
        (
            StructureType sType = StructureType.PipelineLayoutCreateInfo,
            void* pNext = default,
            uint flags = default,
            uint setLayoutCount = default,
            DescriptorSetLayout* pSetLayouts = default,
            uint pushConstantRangeCount = default,
            PushConstantRange* pPushConstantRanges = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           SetLayoutCount = setLayoutCount;
           PSetLayouts = pSetLayouts;
           PushConstantRangeCount = pushConstantRangeCount;
           PPushConstantRanges = pPushConstantRanges;
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
        [NativeName("Type", "VkPipelineLayoutCreateFlags")]
        [NativeName("Type.Name", "VkPipelineLayoutCreateFlags")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "setLayoutCount")]
        public uint SetLayoutCount;
/// <summary></summary>
        [NativeName("Type", "VkDescriptorSetLayout*")]
        [NativeName("Type.Name", "VkDescriptorSetLayout")]
        [NativeName("Name", "pSetLayouts")]
        public DescriptorSetLayout* PSetLayouts;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pushConstantRangeCount")]
        public uint PushConstantRangeCount;
/// <summary></summary>
        [NativeName("Type", "VkPushConstantRange*")]
        [NativeName("Type.Name", "VkPushConstantRange")]
        [NativeName("Name", "pPushConstantRanges")]
        public PushConstantRange* PPushConstantRanges;
    }
}
