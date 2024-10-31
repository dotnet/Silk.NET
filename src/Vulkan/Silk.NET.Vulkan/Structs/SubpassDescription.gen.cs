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
    [NativeName("Name", "VkSubpassDescription")]
    public unsafe partial struct SubpassDescription
    {
        public SubpassDescription
        (
            SubpassDescriptionFlags? flags = null,
            PipelineBindPoint? pipelineBindPoint = null,
            uint? inputAttachmentCount = null,
            AttachmentReference* pInputAttachments = null,
            uint? colorAttachmentCount = null,
            AttachmentReference* pColorAttachments = null,
            AttachmentReference* pResolveAttachments = null,
            AttachmentReference* pDepthStencilAttachment = null,
            uint? preserveAttachmentCount = null,
            uint* pPreserveAttachments = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (pipelineBindPoint is not null)
            {
                PipelineBindPoint = pipelineBindPoint.Value;
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
        [NativeName("Name", "inputAttachmentCount")]
        public uint InputAttachmentCount;
/// <summary></summary>
        [NativeName("Type", "VkAttachmentReference*")]
        [NativeName("Type.Name", "VkAttachmentReference")]
        [NativeName("Name", "pInputAttachments")]
        public AttachmentReference* PInputAttachments;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "colorAttachmentCount")]
        public uint ColorAttachmentCount;
/// <summary></summary>
        [NativeName("Type", "VkAttachmentReference*")]
        [NativeName("Type.Name", "VkAttachmentReference")]
        [NativeName("Name", "pColorAttachments")]
        public AttachmentReference* PColorAttachments;
/// <summary></summary>
        [NativeName("Type", "VkAttachmentReference*")]
        [NativeName("Type.Name", "VkAttachmentReference")]
        [NativeName("Name", "pResolveAttachments")]
        public AttachmentReference* PResolveAttachments;
/// <summary></summary>
        [NativeName("Type", "VkAttachmentReference*")]
        [NativeName("Type.Name", "VkAttachmentReference")]
        [NativeName("Name", "pDepthStencilAttachment")]
        public AttachmentReference* PDepthStencilAttachment;
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
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
