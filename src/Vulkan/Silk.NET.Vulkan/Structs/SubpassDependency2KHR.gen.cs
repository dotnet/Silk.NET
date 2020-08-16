// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkSubpassDependency2KHR")]
    public unsafe partial struct SubpassDependency2KHR
    {
        public SubpassDependency2KHR
        (
            StructureType sType = StructureType.SubpassDependency2,
            void* pNext = default,
            uint srcSubpass = default,
            uint dstSubpass = default,
            PipelineStageFlags srcStageMask = default,
            PipelineStageFlags dstStageMask = default,
            AccessFlags srcAccessMask = default,
            AccessFlags dstAccessMask = default,
            DependencyFlags dependencyFlags = default,
            int viewOffset = default
        )
        {
            SType = sType;
            PNext = pNext;
            SrcSubpass = srcSubpass;
            DstSubpass = dstSubpass;
            SrcStageMask = srcStageMask;
            DstStageMask = dstStageMask;
            SrcAccessMask = srcAccessMask;
            DstAccessMask = dstAccessMask;
            DependencyFlags = dependencyFlags;
            ViewOffset = viewOffset;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "srcSubpass")]
        public uint SrcSubpass;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "dstSubpass")]
        public uint DstSubpass;
/// <summary></summary>
        [NativeName("Type", "VkPipelineStageFlags")]
        [NativeName("Type.Name", "VkPipelineStageFlags")]
        [NativeName("Name", "srcStageMask")]
        public PipelineStageFlags SrcStageMask;
/// <summary></summary>
        [NativeName("Type", "VkPipelineStageFlags")]
        [NativeName("Type.Name", "VkPipelineStageFlags")]
        [NativeName("Name", "dstStageMask")]
        public PipelineStageFlags DstStageMask;
/// <summary></summary>
        [NativeName("Type", "VkAccessFlags")]
        [NativeName("Type.Name", "VkAccessFlags")]
        [NativeName("Name", "srcAccessMask")]
        public AccessFlags SrcAccessMask;
/// <summary></summary>
        [NativeName("Type", "VkAccessFlags")]
        [NativeName("Type.Name", "VkAccessFlags")]
        [NativeName("Name", "dstAccessMask")]
        public AccessFlags DstAccessMask;
/// <summary></summary>
        [NativeName("Type", "VkDependencyFlags")]
        [NativeName("Type.Name", "VkDependencyFlags")]
        [NativeName("Name", "dependencyFlags")]
        public DependencyFlags DependencyFlags;
/// <summary></summary>
        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "viewOffset")]
        public int ViewOffset;
    }
}
