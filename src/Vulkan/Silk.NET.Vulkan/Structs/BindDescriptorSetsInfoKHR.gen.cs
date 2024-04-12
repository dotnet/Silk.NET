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
    [NativeName("Name", "VkBindDescriptorSetsInfoKHR")]
    public unsafe partial struct BindDescriptorSetsInfoKHR : IChainStart
    {
        public BindDescriptorSetsInfoKHR
        (
            StructureType? sType = StructureType.BindDescriptorSetsInfoKhr,
            void* pNext = null,
            ShaderStageFlags? stageFlags = null,
            PipelineLayout? layout = null,
            uint? firstSet = null,
            uint? descriptorSetCount = null,
            DescriptorSet* pDescriptorSets = null,
            uint? dynamicOffsetCount = null,
            uint* pDynamicOffsets = null
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

            if (stageFlags is not null)
            {
                StageFlags = stageFlags.Value;
            }

            if (layout is not null)
            {
                Layout = layout.Value;
            }

            if (firstSet is not null)
            {
                FirstSet = firstSet.Value;
            }

            if (descriptorSetCount is not null)
            {
                DescriptorSetCount = descriptorSetCount.Value;
            }

            if (pDescriptorSets is not null)
            {
                PDescriptorSets = pDescriptorSets;
            }

            if (dynamicOffsetCount is not null)
            {
                DynamicOffsetCount = dynamicOffsetCount.Value;
            }

            if (pDynamicOffsets is not null)
            {
                PDynamicOffsets = pDynamicOffsets;
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
        [NativeName("Type", "VkShaderStageFlags")]
        [NativeName("Type.Name", "VkShaderStageFlags")]
        [NativeName("Name", "stageFlags")]
        public ShaderStageFlags StageFlags;
/// <summary></summary>
        [NativeName("Type", "VkPipelineLayout")]
        [NativeName("Type.Name", "VkPipelineLayout")]
        [NativeName("Name", "layout")]
        public PipelineLayout Layout;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "firstSet")]
        public uint FirstSet;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "descriptorSetCount")]
        public uint DescriptorSetCount;
/// <summary></summary>
        [NativeName("Type", "VkDescriptorSet*")]
        [NativeName("Type.Name", "VkDescriptorSet")]
        [NativeName("Name", "pDescriptorSets")]
        public DescriptorSet* PDescriptorSets;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "dynamicOffsetCount")]
        public uint DynamicOffsetCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pDynamicOffsets")]
        public uint* PDynamicOffsets;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.BindDescriptorSetsInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }

        /// <summary>
        /// Convenience method to start a chain.
        /// </summary>
        /// <param name="capture">The newly created chain root</param>
        /// <returns>A reference to the newly created chain.</returns>
        public static unsafe ref BindDescriptorSetsInfoKHR Chain(
            out BindDescriptorSetsInfoKHR capture)
        {
            capture = new BindDescriptorSetsInfoKHR(StructureType.BindDescriptorSetsInfoKhr);
            return ref capture;
        }
    }
}
