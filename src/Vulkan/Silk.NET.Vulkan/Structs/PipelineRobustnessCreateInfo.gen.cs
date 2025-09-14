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
    [NativeName("Name", "VkPipelineRobustnessCreateInfo")]
    [NativeName("Aliases", "VkPipelineRobustnessCreateInfoEXT")]
    public unsafe partial struct PipelineRobustnessCreateInfo : IExtendsChain<GraphicsPipelineCreateInfo>, IExtendsChain<ComputePipelineCreateInfo>, IExtendsChain<PipelineShaderStageCreateInfo>, IExtendsChain<RayTracingPipelineCreateInfoKHR>
    {
        public PipelineRobustnessCreateInfo
        (
            StructureType? sType = StructureType.PipelineRobustnessCreateInfo,
            void* pNext = null,
            PipelineRobustnessBufferBehavior? storageBuffers = null,
            PipelineRobustnessBufferBehavior? uniformBuffers = null,
            PipelineRobustnessBufferBehavior? vertexInputs = null,
            PipelineRobustnessImageBehavior? images = null
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

            if (storageBuffers is not null)
            {
                StorageBuffers = storageBuffers.Value;
            }

            if (uniformBuffers is not null)
            {
                UniformBuffers = uniformBuffers.Value;
            }

            if (vertexInputs is not null)
            {
                VertexInputs = vertexInputs.Value;
            }

            if (images is not null)
            {
                Images = images.Value;
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
        [NativeName("Type", "VkPipelineRobustnessBufferBehavior")]
        [NativeName("Type.Name", "VkPipelineRobustnessBufferBehavior")]
        [NativeName("Name", "storageBuffers")]
        public PipelineRobustnessBufferBehavior StorageBuffers;
/// <summary></summary>
        [NativeName("Type", "VkPipelineRobustnessBufferBehavior")]
        [NativeName("Type.Name", "VkPipelineRobustnessBufferBehavior")]
        [NativeName("Name", "uniformBuffers")]
        public PipelineRobustnessBufferBehavior UniformBuffers;
/// <summary></summary>
        [NativeName("Type", "VkPipelineRobustnessBufferBehavior")]
        [NativeName("Type.Name", "VkPipelineRobustnessBufferBehavior")]
        [NativeName("Name", "vertexInputs")]
        public PipelineRobustnessBufferBehavior VertexInputs;
/// <summary></summary>
        [NativeName("Type", "VkPipelineRobustnessImageBehavior")]
        [NativeName("Type.Name", "VkPipelineRobustnessImageBehavior")]
        [NativeName("Name", "images")]
        public PipelineRobustnessImageBehavior Images;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PipelineRobustnessCreateInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
