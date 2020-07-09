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
    [NativeName("Name", "VkRenderPassCreateInfo2")]
    public unsafe struct RenderPassCreateInfo2
    {
        public RenderPassCreateInfo2
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
        [NativeName("Type", "VkRenderPassCreateFlags")]
        [NativeName("Type.Name", "VkRenderPassCreateFlags")]
        [NativeName("Name", "flags")]
        public RenderPassCreateFlags Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "attachmentCount")]
        public uint AttachmentCount;
/// <summary></summary>
        [NativeName("Type", "VkAttachmentDescription2*")]
        [NativeName("Type.Name", "VkAttachmentDescription2")]
        [NativeName("Name", "pAttachments")]
        public AttachmentDescription2* PAttachments;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "subpassCount")]
        public uint SubpassCount;
/// <summary></summary>
        [NativeName("Type", "VkSubpassDescription2*")]
        [NativeName("Type.Name", "VkSubpassDescription2")]
        [NativeName("Name", "pSubpasses")]
        public SubpassDescription2* PSubpasses;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "dependencyCount")]
        public uint DependencyCount;
/// <summary></summary>
        [NativeName("Type", "VkSubpassDependency2*")]
        [NativeName("Type.Name", "VkSubpassDependency2")]
        [NativeName("Name", "pDependencies")]
        public SubpassDependency2* PDependencies;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "correlatedViewMaskCount")]
        public uint CorrelatedViewMaskCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pCorrelatedViewMasks")]
        public uint* PCorrelatedViewMasks;
    }
}
