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
    public unsafe struct SubpassDependency2KHR
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint SrcSubpass;
/// <summary></summary>
        public uint DstSubpass;
/// <summary></summary>
        public PipelineStageFlags SrcStageMask;
/// <summary></summary>
        public PipelineStageFlags DstStageMask;
/// <summary></summary>
        public AccessFlags SrcAccessMask;
/// <summary></summary>
        public AccessFlags DstAccessMask;
/// <summary></summary>
        public DependencyFlags DependencyFlags;
/// <summary></summary>
        public int ViewOffset;
    }
}
