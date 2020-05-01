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
        public SubpassDescriptionFlags Flags;
/// <summary></summary>
        public PipelineBindPoint PipelineBindPoint;
/// <summary></summary>
        public uint InputAttachmentCount;
/// <summary></summary>
        public AttachmentReference* PInputAttachments;
/// <summary></summary>
        public uint ColorAttachmentCount;
/// <summary></summary>
        public AttachmentReference* PColorAttachments;
/// <summary></summary>
        public AttachmentReference* PResolveAttachments;
/// <summary></summary>
        public AttachmentReference* PDepthStencilAttachment;
/// <summary></summary>
        public uint PreserveAttachmentCount;
/// <summary></summary>
        public uint* PPreserveAttachments;
    }
}
