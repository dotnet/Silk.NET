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
    public unsafe struct RenderPassCreateInfo2KHR
    {
        public RenderPassCreateInfo2KHR
        (
            StructureType sType = StructureType.RenderPassCreateInfo2,
            void* pNext = default,
            RenderPassCreateFlags flags = default,
            uint attachmentCount = default,
            AttachmentDescription2* pAttachments = default,
            uint subpassCount = default,
            SubpassDescription2* pSubpasses = default,
            uint dependencyCount = default,
            SubpassDependency2* pDependencies = default,
            uint correlatedViewMaskCount = default,
            uint* pCorrelatedViewMasks = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           AttachmentCount = attachmentCount;
           PAttachments = pAttachments;
           SubpassCount = subpassCount;
           PSubpasses = pSubpasses;
           DependencyCount = dependencyCount;
           PDependencies = pDependencies;
           CorrelatedViewMaskCount = correlatedViewMaskCount;
           PCorrelatedViewMasks = pCorrelatedViewMasks;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public RenderPassCreateFlags Flags;
/// <summary></summary>
        public uint AttachmentCount;
/// <summary></summary>
        public AttachmentDescription2* PAttachments;
/// <summary></summary>
        public uint SubpassCount;
/// <summary></summary>
        public SubpassDescription2* PSubpasses;
/// <summary></summary>
        public uint DependencyCount;
/// <summary></summary>
        public SubpassDependency2* PDependencies;
/// <summary></summary>
        public uint CorrelatedViewMaskCount;
/// <summary></summary>
        public uint* PCorrelatedViewMasks;
    }
}
