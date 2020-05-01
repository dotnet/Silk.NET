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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public RenderPassCreateFlags Flags;
/// <summary></summary>
        public uint AttachmentCount;
/// <summary></summary>
        public AttachmentDescription* PAttachments;
/// <summary></summary>
        public uint SubpassCount;
/// <summary></summary>
        public SubpassDescription* PSubpasses;
/// <summary></summary>
        public uint DependencyCount;
/// <summary></summary>
        public SubpassDependency* PDependencies;
    }
}
