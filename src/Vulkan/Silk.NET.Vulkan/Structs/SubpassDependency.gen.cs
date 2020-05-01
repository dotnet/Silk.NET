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
    public unsafe struct SubpassDependency
    {
        public SubpassDependency
        (
            uint srcSubpass = default,
            uint dstSubpass = default,
            PipelineStageFlags srcStageMask = default,
            PipelineStageFlags dstStageMask = default,
            AccessFlags srcAccessMask = default,
            AccessFlags dstAccessMask = default,
            DependencyFlags dependencyFlags = default
        )
        {
           SrcSubpass = srcSubpass;
           DstSubpass = dstSubpass;
           SrcStageMask = srcStageMask;
           DstStageMask = dstStageMask;
           SrcAccessMask = srcAccessMask;
           DstAccessMask = dstAccessMask;
           DependencyFlags = dependencyFlags;
        }

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
    }
}
