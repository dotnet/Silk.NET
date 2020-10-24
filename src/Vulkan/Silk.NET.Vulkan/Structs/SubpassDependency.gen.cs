// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkSubpassDependency")]
    public unsafe partial struct SubpassDependency
    {
        public SubpassDependency
        (
            uint? srcSubpass = null,
            uint? dstSubpass = null,
            PipelineStageFlags? srcStageMask = null,
            PipelineStageFlags? dstStageMask = null,
            AccessFlags? srcAccessMask = null,
            AccessFlags? dstAccessMask = null,
            DependencyFlags? dependencyFlags = null
        ) : this()
        {
            if (srcSubpass is not null)
            {
                SrcSubpass = srcSubpass.Value;
            }

            if (dstSubpass is not null)
            {
                DstSubpass = dstSubpass.Value;
            }

            if (srcStageMask is not null)
            {
                SrcStageMask = srcStageMask.Value;
            }

            if (dstStageMask is not null)
            {
                DstStageMask = dstStageMask.Value;
            }

            if (srcAccessMask is not null)
            {
                SrcAccessMask = srcAccessMask.Value;
            }

            if (dstAccessMask is not null)
            {
                DstAccessMask = dstAccessMask.Value;
            }

            if (dependencyFlags is not null)
            {
                DependencyFlags = dependencyFlags.Value;
            }
        }

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
    }
}
