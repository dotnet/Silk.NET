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
    [NativeName("Name", "VkGraphicsShaderGroupCreateInfoNV")]
    public unsafe partial struct GraphicsShaderGroupCreateInfoNV : IChainable
    {
        public GraphicsShaderGroupCreateInfoNV
        (
            StructureType? sType = StructureType.GraphicsShaderGroupCreateInfoNV,
            void* pNext = null,
            uint? stageCount = null,
            PipelineShaderStageCreateInfo* pStages = null,
            PipelineVertexInputStateCreateInfo* pVertexInputState = null,
            PipelineTessellationStateCreateInfo* pTessellationState = null
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

            if (pTessellationState is not null)
            {
                PTessellationState = pTessellationState;
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
        [NativeName("Type", "VkPipelineTessellationStateCreateInfo*")]
        [NativeName("Type.Name", "VkPipelineTessellationStateCreateInfo")]
        [NativeName("Name", "pTessellationState")]
        public PipelineTessellationStateCreateInfo* PTessellationState;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.GraphicsShaderGroupCreateInfoNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
