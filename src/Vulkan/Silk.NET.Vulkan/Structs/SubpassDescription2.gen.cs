// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct SubpassDescription2
    {
        public SubpassDescription2
        (
            StructureType sType = StructureType.SubpassDescription2,
            void* pNext = default,
            SubpassDescriptionFlags flags = default,
            PipelineBindPoint pipelineBindPoint = default,
            uint viewMask = default,
            uint inputAttachmentCount = default,
            AttachmentReference2* pInputAttachments = default,
            uint colorAttachmentCount = default,
            AttachmentReference2* pColorAttachments = default,
            AttachmentReference2* pResolveAttachments = default,
            AttachmentReference2* pDepthStencilAttachment = default,
            uint preserveAttachmentCount = default,
            uint* pPreserveAttachments = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           PipelineBindPoint = pipelineBindPoint;
           ViewMask = viewMask;
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public SubpassDescriptionFlags Flags;
/// <summary></summary>
        public PipelineBindPoint PipelineBindPoint;
/// <summary></summary>
        public uint ViewMask;
/// <summary></summary>
        public uint InputAttachmentCount;
/// <summary></summary>
        public AttachmentReference2* PInputAttachments;
/// <summary></summary>
        public uint ColorAttachmentCount;
/// <summary></summary>
        public AttachmentReference2* PColorAttachments;
/// <summary></summary>
        public AttachmentReference2* PResolveAttachments;
/// <summary></summary>
        public AttachmentReference2* PDepthStencilAttachment;
/// <summary></summary>
        public uint PreserveAttachmentCount;
/// <summary></summary>
        public uint* PPreserveAttachments;
    }
}
