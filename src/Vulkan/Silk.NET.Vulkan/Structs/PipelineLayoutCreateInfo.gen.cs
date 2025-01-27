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
    [NativeName("Name", "VkPipelineLayoutCreateInfo")]
    public unsafe partial struct PipelineLayoutCreateInfo : IExtendsChain<BindDescriptorSetsInfoKHR>, IExtendsChain<PushConstantsInfoKHR>, IExtendsChain<PushDescriptorSetInfoKHR>, IExtendsChain<PushDescriptorSetWithTemplateInfoKHR>, IExtendsChain<SetDescriptorBufferOffsetsInfoEXT>, IExtendsChain<BindDescriptorBufferEmbeddedSamplersInfoEXT>, IExtendsChain<IndirectCommandsLayoutCreateInfoEXT>
    {
        public PipelineLayoutCreateInfo
        (
            StructureType? sType = StructureType.PipelineLayoutCreateInfo,
            void* pNext = null,
            PipelineLayoutCreateFlags? flags = null,
            uint? setLayoutCount = null,
            DescriptorSetLayout* pSetLayouts = null,
            uint? pushConstantRangeCount = null,
            PushConstantRange* pPushConstantRanges = null
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

            if (setLayoutCount is not null)
            {
                SetLayoutCount = setLayoutCount.Value;
            }

            if (pSetLayouts is not null)
            {
                PSetLayouts = pSetLayouts;
            }

            if (pushConstantRangeCount is not null)
            {
                PushConstantRangeCount = pushConstantRangeCount.Value;
            }

            if (pPushConstantRanges is not null)
            {
                PPushConstantRanges = pPushConstantRanges;
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
        [NativeName("Type", "VkPipelineLayoutCreateFlags")]
        [NativeName("Type.Name", "VkPipelineLayoutCreateFlags")]
        [NativeName("Name", "flags")]
        public PipelineLayoutCreateFlags Flags;
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

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PipelineLayoutCreateInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
