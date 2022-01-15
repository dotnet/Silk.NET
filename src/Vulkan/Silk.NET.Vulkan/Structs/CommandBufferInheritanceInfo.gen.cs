// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkCommandBufferInheritanceInfo")]
    public unsafe partial struct CommandBufferInheritanceInfo : IChainStart
    {
        public CommandBufferInheritanceInfo
        (
            StructureType? sType = StructureType.CommandBufferInheritanceInfo,
            void* pNext = null,
            RenderPass? renderPass = null,
            uint? subpass = null,
            Framebuffer? framebuffer = null,
            Bool32? occlusionQueryEnable = null,
            QueryControlFlags? queryFlags = null,
            QueryPipelineStatisticFlags? pipelineStatistics = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (renderPass is not null)
            {
                RenderPass = renderPass.Value;
            }

            if (subpass is not null)
            {
                Subpass = subpass.Value;
            }

            if (framebuffer is not null)
            {
                Framebuffer = framebuffer.Value;
            }

            if (occlusionQueryEnable is not null)
            {
                OcclusionQueryEnable = occlusionQueryEnable.Value;
            }

            if (queryFlags is not null)
            {
                QueryFlags = queryFlags.Value;
            }

            if (pipelineStatistics is not null)
            {
                PipelineStatistics = pipelineStatistics.Value;
            }
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

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.CommandBufferInheritanceInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }

        /// <summary>
        /// Convenience method to start a chain.
        /// </summary>
        /// <param name="capture">The newly created chain root</param>
        /// <returns>A reference to the newly created chain.</returns>
        public static unsafe ref CommandBufferInheritanceInfo Chain(
            out CommandBufferInheritanceInfo capture)
        {
            capture = new CommandBufferInheritanceInfo(StructureType.CommandBufferInheritanceInfo);
            return ref capture;
        }
    }
}
