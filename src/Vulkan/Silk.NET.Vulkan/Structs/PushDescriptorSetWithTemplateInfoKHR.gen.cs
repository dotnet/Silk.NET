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
    [NativeName("Name", "VkPushDescriptorSetWithTemplateInfoKHR")]
    public unsafe partial struct PushDescriptorSetWithTemplateInfoKHR : IChainStart
    {
        public PushDescriptorSetWithTemplateInfoKHR
        (
            StructureType? sType = StructureType.PushDescriptorSetWithTemplateInfoKhr,
            void* pNext = null,
            DescriptorUpdateTemplate? descriptorUpdateTemplate = null,
            PipelineLayout? layout = null,
            uint? set = null,
            void* pData = null
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

            if (descriptorUpdateTemplate is not null)
            {
                DescriptorUpdateTemplate = descriptorUpdateTemplate.Value;
            }

            if (layout is not null)
            {
                Layout = layout.Value;
            }

            if (set is not null)
            {
                Set = set.Value;
            }

            if (pData is not null)
            {
                PData = pData;
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
        [NativeName("Type", "VkDescriptorUpdateTemplate")]
        [NativeName("Type.Name", "VkDescriptorUpdateTemplate")]
        [NativeName("Name", "descriptorUpdateTemplate")]
        public DescriptorUpdateTemplate DescriptorUpdateTemplate;
/// <summary></summary>
        [NativeName("Type", "VkPipelineLayout")]
        [NativeName("Type.Name", "VkPipelineLayout")]
        [NativeName("Name", "layout")]
        public PipelineLayout Layout;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "set")]
        public uint Set;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pData")]
        public void* PData;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PushDescriptorSetWithTemplateInfoKhr;
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
        public static unsafe ref PushDescriptorSetWithTemplateInfoKHR Chain(
            out PushDescriptorSetWithTemplateInfoKHR capture)
        {
            capture = new PushDescriptorSetWithTemplateInfoKHR(StructureType.PushDescriptorSetWithTemplateInfoKhr);
            return ref capture;
        }
    }
}
