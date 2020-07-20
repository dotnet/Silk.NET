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
    [NativeName("Name", "VkSubpassDescriptionDepthStencilResolveKHR")]
    public unsafe partial struct SubpassDescriptionDepthStencilResolveKHR
    {
        public SubpassDescriptionDepthStencilResolveKHR
        (
            StructureType sType = StructureType.SubpassDescriptionDepthStencilResolve,
            void* pNext = default,
            ResolveModeFlags depthResolveMode = default,
            ResolveModeFlags stencilResolveMode = default,
            AttachmentReference2* pDepthStencilResolveAttachment = default
        )
        {
            SType = sType;
            PNext = pNext;
            DepthResolveMode = depthResolveMode;
            StencilResolveMode = stencilResolveMode;
            PDepthStencilResolveAttachment = pDepthStencilResolveAttachment;
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
        [NativeName("Type", "VkResolveModeFlagBits")]
        [NativeName("Type.Name", "VkResolveModeFlagBits")]
        [NativeName("Name", "depthResolveMode")]
        public ResolveModeFlags DepthResolveMode;
/// <summary></summary>
        [NativeName("Type", "VkResolveModeFlagBits")]
        [NativeName("Type.Name", "VkResolveModeFlagBits")]
        [NativeName("Name", "stencilResolveMode")]
        public ResolveModeFlags StencilResolveMode;
/// <summary></summary>
        [NativeName("Type", "VkAttachmentReference2*")]
        [NativeName("Type.Name", "VkAttachmentReference2")]
        [NativeName("Name", "pDepthStencilResolveAttachment")]
        public AttachmentReference2* PDepthStencilResolveAttachment;
    }
}
