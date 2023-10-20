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
    [NativeName("Name", "VkPipelineCreationFeedbackCreateInfoEXT")]
    [NativeName("AliasOf", "VkPipelineCreationFeedbackCreateInfo")]
    public unsafe partial struct PipelineCreationFeedbackCreateInfoEXT : IExtendsChain<GraphicsPipelineCreateInfo>, IExtendsChain<ComputePipelineCreateInfo>, IExtendsChain<RayTracingPipelineCreateInfoNV>, IExtendsChain<RayTracingPipelineCreateInfoKHR>, IExtendsChain<ExecutionGraphPipelineCreateInfoAMDX>
    {
        public PipelineCreationFeedbackCreateInfoEXT
        (
            StructureType? sType = StructureType.PipelineCreationFeedbackCreateInfo,
            void* pNext = null,
            PipelineCreationFeedback* pPipelineCreationFeedback = null,
            uint? pipelineStageCreationFeedbackCount = null,
            PipelineCreationFeedback* pPipelineStageCreationFeedbacks = null
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

            if (pPipelineCreationFeedback is not null)
            {
                PPipelineCreationFeedback = pPipelineCreationFeedback;
            }

            if (pipelineStageCreationFeedbackCount is not null)
            {
                PipelineStageCreationFeedbackCount = pipelineStageCreationFeedbackCount.Value;
            }

            if (pPipelineStageCreationFeedbacks is not null)
            {
                PPipelineStageCreationFeedbacks = pPipelineStageCreationFeedbacks;
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
        [NativeName("Type", "VkPipelineCreationFeedback*")]
        [NativeName("Type.Name", "VkPipelineCreationFeedback")]
        [NativeName("Name", "pPipelineCreationFeedback")]
        public PipelineCreationFeedback* PPipelineCreationFeedback;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pipelineStageCreationFeedbackCount")]
        public uint PipelineStageCreationFeedbackCount;
/// <summary></summary>
        [NativeName("Type", "VkPipelineCreationFeedback*")]
        [NativeName("Type.Name", "VkPipelineCreationFeedback")]
        [NativeName("Name", "pPipelineStageCreationFeedbacks")]
        public PipelineCreationFeedback* PPipelineStageCreationFeedbacks;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PipelineCreationFeedbackCreateInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
