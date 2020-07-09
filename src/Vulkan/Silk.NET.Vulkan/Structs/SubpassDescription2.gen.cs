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
    [NativeName("Name", "VkSubpassDescription2")]
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
    }
}
