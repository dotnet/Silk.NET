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
    [NativeName("Name", "VkGraphicsPipelineCreateInfo")]
    public unsafe partial struct GraphicsPipelineCreateInfo : IChainStart
    {
        public GraphicsPipelineCreateInfo
        (
            StructureType? sType = StructureType.GraphicsPipelineCreateInfo,
            void* pNext = null,
            PipelineCreateFlags? flags = null,
            uint? stageCount = null,
            PipelineShaderStageCreateInfo* pStages = null,
            PipelineVertexInputStateCreateInfo* pVertexInputState = null,
            PipelineInputAssemblyStateCreateInfo* pInputAssemblyState = null,
            PipelineTessellationStateCreateInfo* pTessellationState = null,
            PipelineViewportStateCreateInfo* pViewportState = null,
            PipelineRasterizationStateCreateInfo* pRasterizationState = null,
            PipelineMultisampleStateCreateInfo* pMultisampleState = null,
            PipelineDepthStencilStateCreateInfo* pDepthStencilState = null,
            PipelineColorBlendStateCreateInfo* pColorBlendState = null,
            PipelineDynamicStateCreateInfo* pDynamicState = null,
            PipelineLayout? layout = null,
            RenderPass? renderPass = null,
            uint? subpass = null,
            Pipeline? basePipelineHandle = null,
            int? basePipelineIndex = null
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

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (stageCount is not null)
            {
                StageCount = stageCount.Value;
            }

            if (pStages is not null)
            {
                PStages = pStages;
            }

            if (pVertexInputState is not null)
            {
                PVertexInputState = pVertexInputState;
            }

            if (pInputAssemblyState is not null)
            {
                PInputAssemblyState = pInputAssemblyState;
            }

            if (pTessellationState is not null)
            {
                PTessellationState = pTessellationState;
            }

            if (pViewportState is not null)
            {
                PViewportState = pViewportState;
            }

            if (pRasterizationState is not null)
            {
                PRasterizationState = pRasterizationState;
            }

            if (pMultisampleState is not null)
            {
                PMultisampleState = pMultisampleState;
            }

            if (pDepthStencilState is not null)
            {
                PDepthStencilState = pDepthStencilState;
            }

            if (pColorBlendState is not null)
            {
                PColorBlendState = pColorBlendState;
            }

            if (pDynamicState is not null)
            {
                PDynamicState = pDynamicState;
            }

            if (layout is not null)
            {
                Layout = layout.Value;
            }

            if (renderPass is not null)
            {
                RenderPass = renderPass.Value;
            }

            if (subpass is not null)
            {
                Subpass = subpass.Value;
            }

            if (basePipelineHandle is not null)
            {
                BasePipelineHandle = basePipelineHandle.Value;
            }

            if (basePipelineIndex is not null)
            {
                BasePipelineIndex = basePipelineIndex.Value;
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
        [NativeName("Type", "VkPipelineCreateFlags")]
        [NativeName("Type.Name", "VkPipelineCreateFlags")]
        [NativeName("Name", "flags")]
        public PipelineCreateFlags Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "stageCount")]
        public uint StageCount;
/// <summary></summary>
        [NativeName("Type", "VkPipelineShaderStageCreateInfo*")]
        [NativeName("Type.Name", "VkPipelineShaderStageCreateInfo")]
        [NativeName("Name", "pStages")]
        public PipelineShaderStageCreateInfo* PStages;
/// <summary></summary>
        [NativeName("Type", "VkPipelineVertexInputStateCreateInfo*")]
        [NativeName("Type.Name", "VkPipelineVertexInputStateCreateInfo")]
        [NativeName("Name", "pVertexInputState")]
        public PipelineVertexInputStateCreateInfo* PVertexInputState;
/// <summary></summary>
        [NativeName("Type", "VkPipelineInputAssemblyStateCreateInfo*")]
        [NativeName("Type.Name", "VkPipelineInputAssemblyStateCreateInfo")]
        [NativeName("Name", "pInputAssemblyState")]
        public PipelineInputAssemblyStateCreateInfo* PInputAssemblyState;
/// <summary></summary>
        [NativeName("Type", "VkPipelineTessellationStateCreateInfo*")]
        [NativeName("Type.Name", "VkPipelineTessellationStateCreateInfo")]
        [NativeName("Name", "pTessellationState")]
        public PipelineTessellationStateCreateInfo* PTessellationState;
/// <summary></summary>
        [NativeName("Type", "VkPipelineViewportStateCreateInfo*")]
        [NativeName("Type.Name", "VkPipelineViewportStateCreateInfo")]
        [NativeName("Name", "pViewportState")]
        public PipelineViewportStateCreateInfo* PViewportState;
/// <summary></summary>
        [NativeName("Type", "VkPipelineRasterizationStateCreateInfo*")]
        [NativeName("Type.Name", "VkPipelineRasterizationStateCreateInfo")]
        [NativeName("Name", "pRasterizationState")]
        public PipelineRasterizationStateCreateInfo* PRasterizationState;
/// <summary></summary>
        [NativeName("Type", "VkPipelineMultisampleStateCreateInfo*")]
        [NativeName("Type.Name", "VkPipelineMultisampleStateCreateInfo")]
        [NativeName("Name", "pMultisampleState")]
        public PipelineMultisampleStateCreateInfo* PMultisampleState;
/// <summary></summary>
        [NativeName("Type", "VkPipelineDepthStencilStateCreateInfo*")]
        [NativeName("Type.Name", "VkPipelineDepthStencilStateCreateInfo")]
        [NativeName("Name", "pDepthStencilState")]
        public PipelineDepthStencilStateCreateInfo* PDepthStencilState;
/// <summary></summary>
        [NativeName("Type", "VkPipelineColorBlendStateCreateInfo*")]
        [NativeName("Type.Name", "VkPipelineColorBlendStateCreateInfo")]
        [NativeName("Name", "pColorBlendState")]
        public PipelineColorBlendStateCreateInfo* PColorBlendState;
/// <summary></summary>
        [NativeName("Type", "VkPipelineDynamicStateCreateInfo*")]
        [NativeName("Type.Name", "VkPipelineDynamicStateCreateInfo")]
        [NativeName("Name", "pDynamicState")]
        public PipelineDynamicStateCreateInfo* PDynamicState;
/// <summary></summary>
        [NativeName("Type", "VkPipelineLayout")]
        [NativeName("Type.Name", "VkPipelineLayout")]
        [NativeName("Name", "layout")]
        public PipelineLayout Layout;
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
        [NativeName("Type", "VkPipeline")]
        [NativeName("Type.Name", "VkPipeline")]
        [NativeName("Name", "basePipelineHandle")]
        public Pipeline BasePipelineHandle;
/// <summary></summary>
        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "basePipelineIndex")]
        public int BasePipelineIndex;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.GraphicsPipelineCreateInfo;
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
        public static unsafe ref GraphicsPipelineCreateInfo Chain(
            out GraphicsPipelineCreateInfo capture)
        {
            capture = new GraphicsPipelineCreateInfo(StructureType.GraphicsPipelineCreateInfo);
            return ref capture;
        }
    }
}
