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
    [NativeName("Name", "VkRenderPassCreateInfo")]
    public unsafe struct RenderPassCreateInfo
    {
        public RenderPassCreateInfo
        (
            StructureType sType = StructureType.RenderPassCreateInfo,
            void* pNext = default,
            RenderPassCreateFlags flags = default,
            uint attachmentCount = default,
            AttachmentDescription* pAttachments = default,
            uint subpassCount = default,
            SubpassDescription* pSubpasses = default,
            uint dependencyCount = default,
            SubpassDependency* pDependencies = default
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
        [NativeName("Type", "VkAttachmentDescription*")]
        [NativeName("Type.Name", "VkAttachmentDescription")]
        [NativeName("Name", "pAttachments")]
        public AttachmentDescription* PAttachments;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "subpassCount")]
        public uint SubpassCount;
/// <summary></summary>
        [NativeName("Type", "VkSubpassDescription*")]
        [NativeName("Type.Name", "VkSubpassDescription")]
        [NativeName("Name", "pSubpasses")]
        public SubpassDescription* PSubpasses;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "dependencyCount")]
        public uint DependencyCount;
/// <summary></summary>
        [NativeName("Type", "VkSubpassDependency*")]
        [NativeName("Type.Name", "VkSubpassDependency")]
        [NativeName("Name", "pDependencies")]
        public SubpassDependency* PDependencies;
    }
}
