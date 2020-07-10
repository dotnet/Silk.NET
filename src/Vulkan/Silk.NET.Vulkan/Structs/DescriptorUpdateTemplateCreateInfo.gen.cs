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
    [NativeName("Name", "VkDescriptorUpdateTemplateCreateInfo")]
    public unsafe partial struct DescriptorUpdateTemplateCreateInfo
    {
        public DescriptorUpdateTemplateCreateInfo
        (
            StructureType sType = StructureType.DescriptorUpdateTemplateCreateInfo,
            void* pNext = default,
            uint flags = default,
            uint descriptorUpdateEntryCount = default,
            DescriptorUpdateTemplateEntry* pDescriptorUpdateEntries = default,
            DescriptorUpdateTemplateType templateType = default,
            DescriptorSetLayout descriptorSetLayout = default,
            PipelineBindPoint pipelineBindPoint = default,
            PipelineLayout pipelineLayout = default,
            uint set = default
        )
        {
            SType = sType;
            PNext = pNext;
            Flags = flags;
            DescriptorUpdateEntryCount = descriptorUpdateEntryCount;
            PDescriptorUpdateEntries = pDescriptorUpdateEntries;
            TemplateType = templateType;
            DescriptorSetLayout = descriptorSetLayout;
            PipelineBindPoint = pipelineBindPoint;
            PipelineLayout = pipelineLayout;
            Set = set;
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
        [NativeName("Type", "VkDescriptorUpdateTemplateCreateFlags")]
        [NativeName("Type.Name", "VkDescriptorUpdateTemplateCreateFlags")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "descriptorUpdateEntryCount")]
        public uint DescriptorUpdateEntryCount;
/// <summary></summary>
        [NativeName("Type", "VkDescriptorUpdateTemplateEntry*")]
        [NativeName("Type.Name", "VkDescriptorUpdateTemplateEntry")]
        [NativeName("Name", "pDescriptorUpdateEntries")]
        public DescriptorUpdateTemplateEntry* PDescriptorUpdateEntries;
/// <summary></summary>
        [NativeName("Type", "VkDescriptorUpdateTemplateType")]
        [NativeName("Type.Name", "VkDescriptorUpdateTemplateType")]
        [NativeName("Name", "templateType")]
        public DescriptorUpdateTemplateType TemplateType;
/// <summary></summary>
        [NativeName("Type", "VkDescriptorSetLayout")]
        [NativeName("Type.Name", "VkDescriptorSetLayout")]
        [NativeName("Name", "descriptorSetLayout")]
        public DescriptorSetLayout DescriptorSetLayout;
/// <summary></summary>
        [NativeName("Type", "VkPipelineBindPoint")]
        [NativeName("Type.Name", "VkPipelineBindPoint")]
        [NativeName("Name", "pipelineBindPoint")]
        public PipelineBindPoint PipelineBindPoint;
/// <summary></summary>
        [NativeName("Type", "VkPipelineLayout")]
        [NativeName("Type.Name", "VkPipelineLayout")]
        [NativeName("Name", "pipelineLayout")]
        public PipelineLayout PipelineLayout;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "set")]
        public uint Set;
    }
}
