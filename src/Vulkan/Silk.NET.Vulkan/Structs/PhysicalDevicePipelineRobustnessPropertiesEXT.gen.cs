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
    [NativeName("Name", "VkPhysicalDevicePipelineRobustnessPropertiesEXT")]
    public unsafe partial struct PhysicalDevicePipelineRobustnessPropertiesEXT : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDevicePipelineRobustnessPropertiesEXT
        (
            StructureType? sType = StructureType.PhysicalDevicePipelineRobustnessPropertiesExt,
            void* pNext = null,
            PipelineRobustnessBufferBehaviorEXT? defaultRobustnessStorageBuffers = null,
            PipelineRobustnessBufferBehaviorEXT? defaultRobustnessUniformBuffers = null,
            PipelineRobustnessBufferBehaviorEXT? defaultRobustnessVertexInputs = null,
            PipelineRobustnessImageBehaviorEXT? defaultRobustnessImages = null
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

            if (defaultRobustnessStorageBuffers is not null)
            {
                DefaultRobustnessStorageBuffers = defaultRobustnessStorageBuffers.Value;
            }

            if (defaultRobustnessUniformBuffers is not null)
            {
                DefaultRobustnessUniformBuffers = defaultRobustnessUniformBuffers.Value;
            }

            if (defaultRobustnessVertexInputs is not null)
            {
                DefaultRobustnessVertexInputs = defaultRobustnessVertexInputs.Value;
            }

            if (defaultRobustnessImages is not null)
            {
                DefaultRobustnessImages = defaultRobustnessImages.Value;
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
        [NativeName("Name", "defaultRobustnessStorageBuffers")]
        public PipelineRobustnessBufferBehaviorEXT DefaultRobustnessStorageBuffers;
/// <summary></summary>
        [NativeName("Type", "VkPipelineRobustnessBufferBehaviorEXT")]
        [NativeName("Type.Name", "VkPipelineRobustnessBufferBehaviorEXT")]
        [NativeName("Name", "defaultRobustnessUniformBuffers")]
        public PipelineRobustnessBufferBehaviorEXT DefaultRobustnessUniformBuffers;
/// <summary></summary>
        [NativeName("Type", "VkPipelineRobustnessBufferBehaviorEXT")]
        [NativeName("Type.Name", "VkPipelineRobustnessBufferBehaviorEXT")]
        [NativeName("Name", "defaultRobustnessVertexInputs")]
        public PipelineRobustnessBufferBehaviorEXT DefaultRobustnessVertexInputs;
/// <summary></summary>
        [NativeName("Type", "VkPipelineRobustnessImageBehaviorEXT")]
        [NativeName("Type.Name", "VkPipelineRobustnessImageBehaviorEXT")]
        [NativeName("Name", "defaultRobustnessImages")]
        public PipelineRobustnessImageBehaviorEXT DefaultRobustnessImages;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDevicePipelineRobustnessPropertiesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
