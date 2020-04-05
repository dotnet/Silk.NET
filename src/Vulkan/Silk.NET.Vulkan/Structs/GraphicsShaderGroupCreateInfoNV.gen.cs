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
    public unsafe struct GraphicsShaderGroupCreateInfoNV
    {
        public GraphicsShaderGroupCreateInfoNV
        (
            StructureType sType = StructureType.GraphicsShaderGroupCreateInfoNV,
            void* pNext = default,
            uint stageCount = default,
            PipelineShaderStageCreateInfo* pStages = default,
            PipelineVertexInputStateCreateInfo* pVertexInputState = default,
            PipelineTessellationStateCreateInfo* pTessellationState = default
        )
        {
           SType = sType;
           PNext = pNext;
           StageCount = stageCount;
           PStages = pStages;
           PVertexInputState = pVertexInputState;
           PTessellationState = pTessellationState;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint StageCount;
/// <summary></summary>
        public PipelineShaderStageCreateInfo* PStages;
/// <summary></summary>
        public PipelineVertexInputStateCreateInfo* PVertexInputState;
/// <summary></summary>
        public PipelineTessellationStateCreateInfo* PTessellationState;
    }
}
