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
    [NativeName("Name", "VkPipelineRobustnessCreateInfoEXT")]
    public unsafe partial struct PipelineRobustnessCreateInfoEXT : IExtendsChain<GraphicsPipelineCreateInfo>, IExtendsChain<ComputePipelineCreateInfo>, IExtendsChain<PipelineShaderStageCreateInfo>, IExtendsChain<RayTracingPipelineCreateInfoKHR>
    {
        public PipelineRobustnessCreateInfoEXT
        (
            StructureType? sType = StructureType.PipelineRobustnessCreateInfoExt,
            void* pNext = null,
            PipelineRobustnessBufferBehaviorEXT? storageBuffers = null,
            PipelineRobustnessBufferBehaviorEXT? uniformBuffers = null,
            PipelineRobustnessBufferBehaviorEXT? vertexInputs = null,
            PipelineRobustnessImageBehaviorEXT? images = null
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
        [NativeName("Type", "VkPipelineRobustnessBufferBehaviorEXT")]
        [NativeName("Type.Name", "VkPipelineRobustnessBufferBehaviorEXT")]
        [NativeName("Name", "storageBuffers")]
        public PipelineRobustnessBufferBehaviorEXT StorageBuffers;
/// <summary></summary>
        [NativeName("Type", "VkPipelineRobustnessBufferBehaviorEXT")]
        [NativeName("Type.Name", "VkPipelineRobustnessBufferBehaviorEXT")]
        [NativeName("Name", "uniformBuffers")]
        public PipelineRobustnessBufferBehaviorEXT UniformBuffers;
/// <summary></summary>
        [NativeName("Type", "VkPipelineRobustnessBufferBehaviorEXT")]
        [NativeName("Type.Name", "VkPipelineRobustnessBufferBehaviorEXT")]
        [NativeName("Name", "vertexInputs")]
        public PipelineRobustnessBufferBehaviorEXT VertexInputs;
/// <summary></summary>
        [NativeName("Type", "VkPipelineRobustnessImageBehaviorEXT")]
        [NativeName("Type.Name", "VkPipelineRobustnessImageBehaviorEXT")]
        [NativeName("Name", "images")]
        public PipelineRobustnessImageBehaviorEXT Images;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }


        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PipelineRobustnessCreateInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
