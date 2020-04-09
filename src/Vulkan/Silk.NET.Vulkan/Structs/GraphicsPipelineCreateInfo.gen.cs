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
    public unsafe struct GraphicsPipelineCreateInfo
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public PipelineCreateFlags Flags;
/// <summary></summary>
        public uint StageCount;
/// <summary></summary>
        public PipelineShaderStageCreateInfo* PStages;
/// <summary></summary>
        public PipelineVertexInputStateCreateInfo* PVertexInputState;
/// <summary></summary>
        public PipelineInputAssemblyStateCreateInfo* PInputAssemblyState;
/// <summary></summary>
        public PipelineTessellationStateCreateInfo* PTessellationState;
/// <summary></summary>
        public PipelineViewportStateCreateInfo* PViewportState;
/// <summary></summary>
        public PipelineRasterizationStateCreateInfo* PRasterizationState;
/// <summary></summary>
        public PipelineMultisampleStateCreateInfo* PMultisampleState;
/// <summary></summary>
        public PipelineDepthStencilStateCreateInfo* PDepthStencilState;
/// <summary></summary>
        public PipelineColorBlendStateCreateInfo* PColorBlendState;
/// <summary></summary>
        public PipelineDynamicStateCreateInfo* PDynamicState;
/// <summary></summary>
        public PipelineLayout Layout;
/// <summary></summary>
        public RenderPass RenderPass;
/// <summary></summary>
        public uint Subpass;
/// <summary></summary>
        public Pipeline BasePipelineHandle;
/// <summary></summary>
        public int BasePipelineIndex;
    }
}
