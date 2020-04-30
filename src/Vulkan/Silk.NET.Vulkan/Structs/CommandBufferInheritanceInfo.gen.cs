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
    public unsafe struct CommandBufferInheritanceInfo
    {
        public CommandBufferInheritanceInfo
        (
            StructureType sType = StructureType.CommandBufferInheritanceInfo,
            void* pNext = default,
            RenderPass renderPass = default,
            uint subpass = default,
            Framebuffer framebuffer = default,
            Bool32 occlusionQueryEnable = default,
            QueryControlFlags queryFlags = default,
            QueryPipelineStatisticFlags pipelineStatistics = default
        )
        {
           SType = sType;
           PNext = pNext;
           RenderPass = renderPass;
           Subpass = subpass;
           Framebuffer = framebuffer;
           OcclusionQueryEnable = occlusionQueryEnable;
           QueryFlags = queryFlags;
           PipelineStatistics = pipelineStatistics;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public RenderPass RenderPass;
/// <summary></summary>
        public uint Subpass;
/// <summary></summary>
        public Framebuffer Framebuffer;
/// <summary></summary>
        public Bool32 OcclusionQueryEnable;
/// <summary></summary>
        public QueryControlFlags QueryFlags;
/// <summary></summary>
        public QueryPipelineStatisticFlags PipelineStatistics;
    }
}
