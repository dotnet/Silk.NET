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
    [NativeName("Name", "VkSubpassDescription")]
    public unsafe struct SubpassDescription
    {
        public SubpassDescription
        (
            SubpassDescriptionFlags flags = default,
            PipelineBindPoint pipelineBindPoint = default,
            uint inputAttachmentCount = default,
            AttachmentReference* pInputAttachments = default,
            uint colorAttachmentCount = default,
            AttachmentReference* pColorAttachments = default,
            AttachmentReference* pResolveAttachments = default,
            AttachmentReference* pDepthStencilAttachment = default,
            uint preserveAttachmentCount = default,
            uint* pPreserveAttachments = default
        )
        {
           Flags = flags;
           PipelineBindPoint = pipelineBindPoint;
           InputAttachmentCount = inputAttachmentCount;
           PInputAttachments = pInputAttachments;
           ColorAttachmentCount = colorAttachmentCount;
           PColorAttachments = pColorAttachments;
           PResolveAttachments = pResolveAttachments;
           PDepthStencilAttachment = pDepthStencilAttachment;
           PreserveAttachmentCount = preserveAttachmentCount;
           PPreserveAttachments = pPreserveAttachments;
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
    }
}
