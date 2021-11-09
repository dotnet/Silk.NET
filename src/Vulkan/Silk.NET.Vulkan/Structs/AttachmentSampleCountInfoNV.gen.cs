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
    [NativeName("Name", "VkAttachmentSampleCountInfoNV")]
    [NativeName("AliasOf", "VkAttachmentSampleCountInfoAMD")]
    public unsafe partial struct AttachmentSampleCountInfoNV : IExtendsChain<CommandBufferInheritanceInfo>, IExtendsChain<GraphicsPipelineCreateInfo>
    {
        public AttachmentSampleCountInfoNV
        (
            StructureType? sType = StructureType.AttachmentSampleCountInfoAmd,
            void* pNext = null,
            uint? colorAttachmentCount = null,
            SampleCountFlags* pColorAttachmentSamples = null,
            SampleCountFlags? depthStencilAttachmentSamples = null
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

            if (colorAttachmentCount is not null)
            {
                ColorAttachmentCount = colorAttachmentCount.Value;
            }

            if (pColorAttachmentSamples is not null)
            {
                PColorAttachmentSamples = pColorAttachmentSamples;
            }

            if (depthStencilAttachmentSamples is not null)
            {
                DepthStencilAttachmentSamples = depthStencilAttachmentSamples.Value;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "colorAttachmentCount")]
        public uint ColorAttachmentCount;
/// <summary></summary>
        [NativeName("Type", "VkSampleCountFlagBits*")]
        [NativeName("Type.Name", "VkSampleCountFlagBits")]
        [NativeName("Name", "pColorAttachmentSamples")]
        public SampleCountFlags* PColorAttachmentSamples;
/// <summary></summary>
        [NativeName("Type", "VkSampleCountFlagBits")]
        [NativeName("Type.Name", "VkSampleCountFlagBits")]
        [NativeName("Name", "depthStencilAttachmentSamples")]
        public SampleCountFlags DepthStencilAttachmentSamples;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.AttachmentSampleCountInfoAmd;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
