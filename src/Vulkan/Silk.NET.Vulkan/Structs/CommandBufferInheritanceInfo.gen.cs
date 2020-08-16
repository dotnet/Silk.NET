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
    [NativeName("Name", "VkCommandBufferInheritanceInfo")]
    public unsafe partial struct CommandBufferInheritanceInfo
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
        [NativeName("Type", "VkRenderPass")]
        [NativeName("Type.Name", "VkRenderPass")]
        [NativeName("Name", "renderPass")]
        public RenderPass RenderPass;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "subpass")]
        public uint Subpass;
/// <summary></summary>
        [NativeName("Type", "VkFramebuffer")]
        [NativeName("Type.Name", "VkFramebuffer")]
        [NativeName("Name", "framebuffer")]
        public Framebuffer Framebuffer;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "occlusionQueryEnable")]
        public Bool32 OcclusionQueryEnable;
/// <summary></summary>
        [NativeName("Type", "VkQueryControlFlags")]
        [NativeName("Type.Name", "VkQueryControlFlags")]
        [NativeName("Name", "queryFlags")]
        public QueryControlFlags QueryFlags;
/// <summary></summary>
        [NativeName("Type", "VkQueryPipelineStatisticFlags")]
        [NativeName("Type.Name", "VkQueryPipelineStatisticFlags")]
        [NativeName("Name", "pipelineStatistics")]
        public QueryPipelineStatisticFlags PipelineStatistics;
    }
}
