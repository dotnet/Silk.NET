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
    [NativeName("Name", "VkSubpassDescription2")]
    [NativeName("Aliases", "VkSubpassDescription2KHR")]
    public unsafe partial struct SubpassDescription2 : IChainStart
    {
        public SubpassDescription2
        (
            StructureType? sType = StructureType.SubpassDescription2,
            void* pNext = null,
            SubpassDescriptionFlags? flags = null,
            PipelineBindPoint? pipelineBindPoint = null,
            uint? viewMask = null,
            uint? inputAttachmentCount = null,
            AttachmentReference2* pInputAttachments = null,
            uint? colorAttachmentCount = null,
            AttachmentReference2* pColorAttachments = null,
            AttachmentReference2* pResolveAttachments = null,
            AttachmentReference2* pDepthStencilAttachment = null,
            uint? preserveAttachmentCount = null,
            uint* pPreserveAttachments = null
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

            if (pipelineBindPoint is not null)
            {
                PipelineBindPoint = pipelineBindPoint.Value;
            }

            if (viewMask is not null)
            {
                ViewMask = viewMask.Value;
            }

            if (inputAttachmentCount is not null)
            {
                InputAttachmentCount = inputAttachmentCount.Value;
            }

            if (pInputAttachments is not null)
            {
                PInputAttachments = pInputAttachments;
            }

            if (colorAttachmentCount is not null)
            {
                ColorAttachmentCount = colorAttachmentCount.Value;
            }

            if (pColorAttachments is not null)
            {
                PColorAttachments = pColorAttachments;
            }

            if (pResolveAttachments is not null)
            {
                PResolveAttachments = pResolveAttachments;
            }

            if (pDepthStencilAttachment is not null)
            {
                PDepthStencilAttachment = pDepthStencilAttachment;
            }

            if (preserveAttachmentCount is not null)
            {
                PreserveAttachmentCount = preserveAttachmentCount.Value;
            }

            if (pPreserveAttachments is not null)
            {
                PPreserveAttachments = pPreserveAttachments;
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
        [NativeName("Type", "VkSubpassDescriptionFlags")]
        [NativeName("Type.Name", "VkSubpassDescriptionFlags")]
        [NativeName("Name", "flags")]
        public SubpassDescriptionFlags Flags;
/// <summary></summary>
        [NativeName("Type", "VkPipelineBindPoint")]
        [NativeName("Type.Name", "VkPipelineBindPoint")]
        [NativeName("Name", "pipelineBindPoint")]
        public PipelineBindPoint PipelineBindPoint;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "viewMask")]
        public uint ViewMask;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "inputAttachmentCount")]
        public uint InputAttachmentCount;
/// <summary></summary>
        [NativeName("Type", "VkAttachmentReference2*")]
        [NativeName("Type.Name", "VkAttachmentReference2")]
        [NativeName("Name", "pInputAttachments")]
        public AttachmentReference2* PInputAttachments;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "colorAttachmentCount")]
        public uint ColorAttachmentCount;
/// <summary></summary>
        [NativeName("Type", "VkAttachmentReference2*")]
        [NativeName("Type.Name", "VkAttachmentReference2")]
        [NativeName("Name", "pColorAttachments")]
        public AttachmentReference2* PColorAttachments;
/// <summary></summary>
        [NativeName("Type", "VkAttachmentReference2*")]
        [NativeName("Type.Name", "VkAttachmentReference2")]
        [NativeName("Name", "pResolveAttachments")]
        public AttachmentReference2* PResolveAttachments;
/// <summary></summary>
        [NativeName("Type", "VkAttachmentReference2*")]
        [NativeName("Type.Name", "VkAttachmentReference2")]
        [NativeName("Name", "pDepthStencilAttachment")]
        public AttachmentReference2* PDepthStencilAttachment;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "preserveAttachmentCount")]
        public uint PreserveAttachmentCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pPreserveAttachments")]
        public uint* PPreserveAttachments;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.SubpassDescription2;
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
        public static unsafe ref SubpassDescription2 Chain(
            out SubpassDescription2 capture)
        {
            capture = new SubpassDescription2(StructureType.SubpassDescription2);
            return ref capture;
        }
    }
}
