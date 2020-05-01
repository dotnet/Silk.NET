// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe struct DescriptorUpdateTemplateCreateInfo
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint Flags;
/// <summary></summary>
        public uint DescriptorUpdateEntryCount;
/// <summary></summary>
        public DescriptorUpdateTemplateEntry* PDescriptorUpdateEntries;
/// <summary></summary>
        public DescriptorUpdateTemplateType TemplateType;
/// <summary></summary>
        public DescriptorSetLayout DescriptorSetLayout;
/// <summary></summary>
        public PipelineBindPoint PipelineBindPoint;
/// <summary></summary>
        public PipelineLayout PipelineLayout;
/// <summary></summary>
        public uint Set;
    }
}
