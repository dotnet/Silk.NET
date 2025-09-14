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
    [NativeName("Name", "VkPhysicalDeviceTensorPropertiesARM")]
    public unsafe partial struct PhysicalDeviceTensorPropertiesARM : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceTensorPropertiesARM
        (
            StructureType? sType = StructureType.PhysicalDeviceTensorPropertiesArm,
            void* pNext = null,
            uint? maxTensorDimensionCount = null,
            ulong? maxTensorElements = null,
            ulong? maxPerDimensionTensorElements = null,
            long? maxTensorStride = null,
            ulong? maxTensorSize = null,
            uint? maxTensorShaderAccessArrayLength = null,
            uint? maxTensorShaderAccessSize = null,
            uint? maxDescriptorSetStorageTensors = null,
            uint? maxPerStageDescriptorSetStorageTensors = null,
            uint? maxDescriptorSetUpdateAfterBindStorageTensors = null,
            uint? maxPerStageDescriptorUpdateAfterBindStorageTensors = null,
            Bool32? shaderStorageTensorArrayNonUniformIndexingNative = null,
            ShaderStageFlags? shaderTensorSupportedStages = null
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

            if (maxTensorDimensionCount is not null)
            {
                MaxTensorDimensionCount = maxTensorDimensionCount.Value;
            }

            if (maxTensorElements is not null)
            {
                MaxTensorElements = maxTensorElements.Value;
            }

            if (maxPerDimensionTensorElements is not null)
            {
                MaxPerDimensionTensorElements = maxPerDimensionTensorElements.Value;
            }

            if (maxTensorStride is not null)
            {
                MaxTensorStride = maxTensorStride.Value;
            }

            if (maxTensorSize is not null)
            {
                MaxTensorSize = maxTensorSize.Value;
            }

            if (maxTensorShaderAccessArrayLength is not null)
            {
                MaxTensorShaderAccessArrayLength = maxTensorShaderAccessArrayLength.Value;
            }

            if (maxTensorShaderAccessSize is not null)
            {
                MaxTensorShaderAccessSize = maxTensorShaderAccessSize.Value;
            }

            if (maxDescriptorSetStorageTensors is not null)
            {
                MaxDescriptorSetStorageTensors = maxDescriptorSetStorageTensors.Value;
            }

            if (maxPerStageDescriptorSetStorageTensors is not null)
            {
                MaxPerStageDescriptorSetStorageTensors = maxPerStageDescriptorSetStorageTensors.Value;
            }

            if (maxDescriptorSetUpdateAfterBindStorageTensors is not null)
            {
                MaxDescriptorSetUpdateAfterBindStorageTensors = maxDescriptorSetUpdateAfterBindStorageTensors.Value;
            }

            if (maxPerStageDescriptorUpdateAfterBindStorageTensors is not null)
            {
                MaxPerStageDescriptorUpdateAfterBindStorageTensors = maxPerStageDescriptorUpdateAfterBindStorageTensors.Value;
            }

            if (shaderStorageTensorArrayNonUniformIndexingNative is not null)
            {
                ShaderStorageTensorArrayNonUniformIndexingNative = shaderStorageTensorArrayNonUniformIndexingNative.Value;
            }

            if (shaderTensorSupportedStages is not null)
            {
                ShaderTensorSupportedStages = shaderTensorSupportedStages.Value;
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
        [NativeName("Name", "maxTensorDimensionCount")]
        public uint MaxTensorDimensionCount;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "maxTensorElements")]
        public ulong MaxTensorElements;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "maxPerDimensionTensorElements")]
        public ulong MaxPerDimensionTensorElements;
/// <summary></summary>
        [NativeName("Type", "int64_t")]
        [NativeName("Type.Name", "int64_t")]
        [NativeName("Name", "maxTensorStride")]
        public long MaxTensorStride;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "maxTensorSize")]
        public ulong MaxTensorSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxTensorShaderAccessArrayLength")]
        public uint MaxTensorShaderAccessArrayLength;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxTensorShaderAccessSize")]
        public uint MaxTensorShaderAccessSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorSetStorageTensors")]
        public uint MaxDescriptorSetStorageTensors;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPerStageDescriptorSetStorageTensors")]
        public uint MaxPerStageDescriptorSetStorageTensors;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorSetUpdateAfterBindStorageTensors")]
        public uint MaxDescriptorSetUpdateAfterBindStorageTensors;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPerStageDescriptorUpdateAfterBindStorageTensors")]
        public uint MaxPerStageDescriptorUpdateAfterBindStorageTensors;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderStorageTensorArrayNonUniformIndexingNative")]
        public Bool32 ShaderStorageTensorArrayNonUniformIndexingNative;
/// <summary></summary>
        [NativeName("Type", "VkShaderStageFlags")]
        [NativeName("Type.Name", "VkShaderStageFlags")]
        [NativeName("Name", "shaderTensorSupportedStages")]
        public ShaderStageFlags ShaderTensorSupportedStages;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceTensorPropertiesArm;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
