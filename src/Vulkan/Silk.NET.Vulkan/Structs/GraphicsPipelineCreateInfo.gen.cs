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
    [NativeName("Name", "VkGraphicsPipelineCreateInfo")]
    public unsafe partial struct GraphicsPipelineCreateInfo
    {
        public GraphicsPipelineCreateInfo
        (
            StructureType sType = StructureType.GraphicsPipelineCreateInfo,
            void* pNext = default,
            PipelineCreateFlags flags = default,
            uint stageCount = default,
            PipelineShaderStageCreateInfo* pStages = default,
            PipelineVertexInputStateCreateInfo* pVertexInputState = default,
            PipelineInputAssemblyStateCreateInfo* pInputAssemblyState = default,
            PipelineTessellationStateCreateInfo* pTessellationState = default,
            PipelineViewportStateCreateInfo* pViewportState = default,
            PipelineRasterizationStateCreateInfo* pRasterizationState = default,
            PipelineMultisampleStateCreateInfo* pMultisampleState = default,
            PipelineDepthStencilStateCreateInfo* pDepthStencilState = default,
            PipelineColorBlendStateCreateInfo* pColorBlendState = default,
            PipelineDynamicStateCreateInfo* pDynamicState = default,
            PipelineLayout layout = default,
            RenderPass renderPass = default,
            uint subpass = default,
            Pipeline basePipelineHandle = default,
            int basePipelineIndex = default
        )
        {
            SType = sType;
            PNext = pNext;
            Flags = flags;
            StageCount = stageCount;
            PStages = pStages;
            PVertexInputState = pVertexInputState;
            PInputAssemblyState = pInputAssemblyState;
            PTessellationState = pTessellationState;
            PViewportState = pViewportState;
            PRasterizationState = pRasterizationState;
            PMultisampleState = pMultisampleState;
            PDepthStencilState = pDepthStencilState;
            PColorBlendState = pColorBlendState;
            PDynamicState = pDynamicState;
            Layout = layout;
            RenderPass = renderPass;
            Subpass = subpass;
            BasePipelineHandle = basePipelineHandle;
            BasePipelineIndex = basePipelineIndex;
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
    }
}
