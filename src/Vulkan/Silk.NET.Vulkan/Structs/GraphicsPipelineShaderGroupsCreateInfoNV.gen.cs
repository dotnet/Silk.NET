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
    [NativeName("Name", "VkGraphicsPipelineShaderGroupsCreateInfoNV")]
    public unsafe partial struct GraphicsPipelineShaderGroupsCreateInfoNV
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "groupCount")]
        public uint GroupCount;
/// <summary></summary>
        [NativeName("Type", "VkGraphicsShaderGroupCreateInfoNV*")]
        [NativeName("Type.Name", "VkGraphicsShaderGroupCreateInfoNV")]
        [NativeName("Name", "pGroups")]
        public GraphicsShaderGroupCreateInfoNV* PGroups;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pipelineCount")]
        public uint PipelineCount;
/// <summary></summary>
        [NativeName("Type", "VkPipeline*")]
        [NativeName("Type.Name", "VkPipeline")]
        [NativeName("Name", "pPipelines")]
        public Pipeline* PPipelines;
    }
}
