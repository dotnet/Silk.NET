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
    [NativeName("Name", "VkDescriptorUpdateTemplateCreateInfo")]
    [NativeName("Aliases", "VkDescriptorUpdateTemplateCreateInfoKHR")]
    public unsafe partial struct DescriptorUpdateTemplateCreateInfo : IChainable
    {
        public DescriptorUpdateTemplateCreateInfo
        (
            StructureType? sType = StructureType.DescriptorUpdateTemplateCreateInfo,
            void* pNext = null,
            uint? flags = null,
            uint? descriptorUpdateEntryCount = null,
            DescriptorUpdateTemplateEntry* pDescriptorUpdateEntries = null,
            DescriptorUpdateTemplateType? templateType = null,
            DescriptorSetLayout? descriptorSetLayout = null,
            PipelineBindPoint? pipelineBindPoint = null,
            PipelineLayout? pipelineLayout = null,
            uint? set = null
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

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (descriptorUpdateEntryCount is not null)
            {
                DescriptorUpdateEntryCount = descriptorUpdateEntryCount.Value;
            }

            if (pDescriptorUpdateEntries is not null)
            {
                PDescriptorUpdateEntries = pDescriptorUpdateEntries;
            }

            if (templateType is not null)
            {
                TemplateType = templateType.Value;
            }

            if (descriptorSetLayout is not null)
            {
                DescriptorSetLayout = descriptorSetLayout.Value;
            }

            if (pipelineBindPoint is not null)
            {
                PipelineBindPoint = pipelineBindPoint.Value;
            }

            if (pipelineLayout is not null)
            {
                PipelineLayout = pipelineLayout.Value;
            }

            if (set is not null)
            {
                Set = set.Value;
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

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DescriptorUpdateTemplateCreateInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
