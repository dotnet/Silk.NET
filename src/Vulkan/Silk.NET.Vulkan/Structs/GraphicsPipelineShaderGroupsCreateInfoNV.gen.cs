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
    public unsafe struct GraphicsPipelineShaderGroupsCreateInfoNV
    {
        public GraphicsPipelineShaderGroupsCreateInfoNV
        (
            StructureType sType = StructureType.GraphicsPipelineShaderGroupsCreateInfoNV,
            void* pNext = default,
            uint groupCount = default,
            GraphicsShaderGroupCreateInfoNV* pGroups = default,
            uint pipelineCount = default,
            Pipeline* pPipelines = default
        )
        {
           SType = sType;
           PNext = pNext;
           GroupCount = groupCount;
           PGroups = pGroups;
           PipelineCount = pipelineCount;
           PPipelines = pPipelines;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint GroupCount;
/// <summary></summary>
        public GraphicsShaderGroupCreateInfoNV* PGroups;
/// <summary></summary>
        public uint PipelineCount;
/// <summary></summary>
        public Pipeline* PPipelines;
    }
}
