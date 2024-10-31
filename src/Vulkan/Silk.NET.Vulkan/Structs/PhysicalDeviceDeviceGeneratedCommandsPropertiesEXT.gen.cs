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
    [NativeName("Name", "VkPhysicalDeviceDeviceGeneratedCommandsPropertiesEXT")]
    public unsafe partial struct PhysicalDeviceDeviceGeneratedCommandsPropertiesEXT : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceDeviceGeneratedCommandsPropertiesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceDeviceGeneratedCommandsPropertiesExt,
            void* pNext = null,
            uint? maxIndirectPipelineCount = null,
            uint? maxIndirectShaderObjectCount = null,
            uint? maxIndirectSequenceCount = null,
            uint? maxIndirectCommandsTokenCount = null,
            uint? maxIndirectCommandsTokenOffset = null,
            uint? maxIndirectCommandsIndirectStride = null,
            IndirectCommandsInputModeFlagsEXT? supportedIndirectCommandsInputModes = null,
            ShaderStageFlags? supportedIndirectCommandsShaderStages = null,
            ShaderStageFlags? supportedIndirectCommandsShaderStagesPipelineBinding = null,
            ShaderStageFlags? supportedIndirectCommandsShaderStagesShaderBinding = null,
            Bool32? deviceGeneratedCommandsTransformFeedback = null,
            Bool32? deviceGeneratedCommandsMultiDrawIndirectCount = null
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

            if (maxIndirectPipelineCount is not null)
            {
                MaxIndirectPipelineCount = maxIndirectPipelineCount.Value;
            }

            if (maxIndirectShaderObjectCount is not null)
            {
                MaxIndirectShaderObjectCount = maxIndirectShaderObjectCount.Value;
            }

            if (maxIndirectSequenceCount is not null)
            {
                MaxIndirectSequenceCount = maxIndirectSequenceCount.Value;
            }

            if (maxIndirectCommandsTokenCount is not null)
            {
                MaxIndirectCommandsTokenCount = maxIndirectCommandsTokenCount.Value;
            }

            if (maxIndirectCommandsTokenOffset is not null)
            {
                MaxIndirectCommandsTokenOffset = maxIndirectCommandsTokenOffset.Value;
            }

            if (maxIndirectCommandsIndirectStride is not null)
            {
                MaxIndirectCommandsIndirectStride = maxIndirectCommandsIndirectStride.Value;
            }

            if (supportedIndirectCommandsInputModes is not null)
            {
                SupportedIndirectCommandsInputModes = supportedIndirectCommandsInputModes.Value;
            }

            if (supportedIndirectCommandsShaderStages is not null)
            {
                SupportedIndirectCommandsShaderStages = supportedIndirectCommandsShaderStages.Value;
            }

            if (supportedIndirectCommandsShaderStagesPipelineBinding is not null)
            {
                SupportedIndirectCommandsShaderStagesPipelineBinding = supportedIndirectCommandsShaderStagesPipelineBinding.Value;
            }

            if (supportedIndirectCommandsShaderStagesShaderBinding is not null)
            {
                SupportedIndirectCommandsShaderStagesShaderBinding = supportedIndirectCommandsShaderStagesShaderBinding.Value;
            }

            if (deviceGeneratedCommandsTransformFeedback is not null)
            {
                DeviceGeneratedCommandsTransformFeedback = deviceGeneratedCommandsTransformFeedback.Value;
            }

            if (deviceGeneratedCommandsMultiDrawIndirectCount is not null)
            {
                DeviceGeneratedCommandsMultiDrawIndirectCount = deviceGeneratedCommandsMultiDrawIndirectCount.Value;
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
        [NativeName("Name", "maxIndirectPipelineCount")]
        public uint MaxIndirectPipelineCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxIndirectShaderObjectCount")]
        public uint MaxIndirectShaderObjectCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxIndirectSequenceCount")]
        public uint MaxIndirectSequenceCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxIndirectCommandsTokenCount")]
        public uint MaxIndirectCommandsTokenCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxIndirectCommandsTokenOffset")]
        public uint MaxIndirectCommandsTokenOffset;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxIndirectCommandsIndirectStride")]
        public uint MaxIndirectCommandsIndirectStride;
/// <summary></summary>
        [NativeName("Type", "VkIndirectCommandsInputModeFlagsEXT")]
        [NativeName("Type.Name", "VkIndirectCommandsInputModeFlagsEXT")]
        [NativeName("Name", "supportedIndirectCommandsInputModes")]
        public IndirectCommandsInputModeFlagsEXT SupportedIndirectCommandsInputModes;
/// <summary></summary>
        [NativeName("Type", "VkShaderStageFlags")]
        [NativeName("Type.Name", "VkShaderStageFlags")]
        [NativeName("Name", "supportedIndirectCommandsShaderStages")]
        public ShaderStageFlags SupportedIndirectCommandsShaderStages;
/// <summary></summary>
        [NativeName("Type", "VkShaderStageFlags")]
        [NativeName("Type.Name", "VkShaderStageFlags")]
        [NativeName("Name", "supportedIndirectCommandsShaderStagesPipelineBinding")]
        public ShaderStageFlags SupportedIndirectCommandsShaderStagesPipelineBinding;
/// <summary></summary>
        [NativeName("Type", "VkShaderStageFlags")]
        [NativeName("Type.Name", "VkShaderStageFlags")]
        [NativeName("Name", "supportedIndirectCommandsShaderStagesShaderBinding")]
        public ShaderStageFlags SupportedIndirectCommandsShaderStagesShaderBinding;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "deviceGeneratedCommandsTransformFeedback")]
        public Bool32 DeviceGeneratedCommandsTransformFeedback;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "deviceGeneratedCommandsMultiDrawIndirectCount")]
        public Bool32 DeviceGeneratedCommandsMultiDrawIndirectCount;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceDeviceGeneratedCommandsPropertiesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
