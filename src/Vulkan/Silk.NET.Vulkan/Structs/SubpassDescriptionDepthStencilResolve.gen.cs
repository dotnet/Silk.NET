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
    public unsafe struct SubpassDescriptionDepthStencilResolve
    {
        public SubpassDescriptionDepthStencilResolve
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public ResolveModeFlags DepthResolveMode;
/// <summary></summary>
        public ResolveModeFlags StencilResolveMode;
/// <summary></summary>
        public AttachmentReference2* PDepthStencilResolveAttachment;
    }
}
