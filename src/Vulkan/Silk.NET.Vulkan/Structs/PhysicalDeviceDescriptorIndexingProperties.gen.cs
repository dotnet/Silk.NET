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
    [NativeName("Name", "VkPhysicalDeviceDescriptorIndexingProperties")]
    [NativeName("Aliases", "VkPhysicalDeviceDescriptorIndexingPropertiesEXT")]
    public unsafe partial struct PhysicalDeviceDescriptorIndexingProperties : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceDescriptorIndexingProperties
        (
            StructureType? sType = StructureType.PhysicalDeviceDescriptorIndexingProperties,
            void* pNext = null,
            uint? maxUpdateAfterBindDescriptorsInAllPools = null,
            Bool32? shaderUniformBufferArrayNonUniformIndexingNative = null,
            Bool32? shaderSampledImageArrayNonUniformIndexingNative = null,
            Bool32? shaderStorageBufferArrayNonUniformIndexingNative = null,
            Bool32? shaderStorageImageArrayNonUniformIndexingNative = null,
            Bool32? shaderInputAttachmentArrayNonUniformIndexingNative = null,
            Bool32? robustBufferAccessUpdateAfterBind = null,
            Bool32? quadDivergentImplicitLod = null,
            uint? maxPerStageDescriptorUpdateAfterBindSamplers = null,
            uint? maxPerStageDescriptorUpdateAfterBindUniformBuffers = null,
            uint? maxPerStageDescriptorUpdateAfterBindStorageBuffers = null,
            uint? maxPerStageDescriptorUpdateAfterBindSampledImages = null,
            uint? maxPerStageDescriptorUpdateAfterBindStorageImages = null,
            uint? maxPerStageDescriptorUpdateAfterBindInputAttachments = null,
            uint? maxPerStageUpdateAfterBindResources = null,
            uint? maxDescriptorSetUpdateAfterBindSamplers = null,
            uint? maxDescriptorSetUpdateAfterBindUniformBuffers = null,
            uint? maxDescriptorSetUpdateAfterBindUniformBuffersDynamic = null,
            uint? maxDescriptorSetUpdateAfterBindStorageBuffers = null,
            uint? maxDescriptorSetUpdateAfterBindStorageBuffersDynamic = null,
            uint? maxDescriptorSetUpdateAfterBindSampledImages = null,
            uint? maxDescriptorSetUpdateAfterBindStorageImages = null,
            uint? maxDescriptorSetUpdateAfterBindInputAttachments = null
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

            if (maxUpdateAfterBindDescriptorsInAllPools is not null)
            {
                MaxUpdateAfterBindDescriptorsInAllPools = maxUpdateAfterBindDescriptorsInAllPools.Value;
            }

            if (shaderUniformBufferArrayNonUniformIndexingNative is not null)
            {
                ShaderUniformBufferArrayNonUniformIndexingNative = shaderUniformBufferArrayNonUniformIndexingNative.Value;
            }

            if (shaderSampledImageArrayNonUniformIndexingNative is not null)
            {
                ShaderSampledImageArrayNonUniformIndexingNative = shaderSampledImageArrayNonUniformIndexingNative.Value;
            }

            if (shaderStorageBufferArrayNonUniformIndexingNative is not null)
            {
                ShaderStorageBufferArrayNonUniformIndexingNative = shaderStorageBufferArrayNonUniformIndexingNative.Value;
            }

            if (shaderStorageImageArrayNonUniformIndexingNative is not null)
            {
                ShaderStorageImageArrayNonUniformIndexingNative = shaderStorageImageArrayNonUniformIndexingNative.Value;
            }

            if (shaderInputAttachmentArrayNonUniformIndexingNative is not null)
            {
                ShaderInputAttachmentArrayNonUniformIndexingNative = shaderInputAttachmentArrayNonUniformIndexingNative.Value;
            }

            if (robustBufferAccessUpdateAfterBind is not null)
            {
                RobustBufferAccessUpdateAfterBind = robustBufferAccessUpdateAfterBind.Value;
            }

            if (quadDivergentImplicitLod is not null)
            {
                QuadDivergentImplicitLod = quadDivergentImplicitLod.Value;
            }

            if (maxPerStageDescriptorUpdateAfterBindSamplers is not null)
            {
                MaxPerStageDescriptorUpdateAfterBindSamplers = maxPerStageDescriptorUpdateAfterBindSamplers.Value;
            }

            if (maxPerStageDescriptorUpdateAfterBindUniformBuffers is not null)
            {
                MaxPerStageDescriptorUpdateAfterBindUniformBuffers = maxPerStageDescriptorUpdateAfterBindUniformBuffers.Value;
            }

            if (maxPerStageDescriptorUpdateAfterBindStorageBuffers is not null)
            {
                MaxPerStageDescriptorUpdateAfterBindStorageBuffers = maxPerStageDescriptorUpdateAfterBindStorageBuffers.Value;
            }

            if (maxPerStageDescriptorUpdateAfterBindSampledImages is not null)
            {
                MaxPerStageDescriptorUpdateAfterBindSampledImages = maxPerStageDescriptorUpdateAfterBindSampledImages.Value;
            }

            if (maxPerStageDescriptorUpdateAfterBindStorageImages is not null)
            {
                MaxPerStageDescriptorUpdateAfterBindStorageImages = maxPerStageDescriptorUpdateAfterBindStorageImages.Value;
            }

            if (maxPerStageDescriptorUpdateAfterBindInputAttachments is not null)
            {
                MaxPerStageDescriptorUpdateAfterBindInputAttachments = maxPerStageDescriptorUpdateAfterBindInputAttachments.Value;
            }

            if (maxPerStageUpdateAfterBindResources is not null)
            {
                MaxPerStageUpdateAfterBindResources = maxPerStageUpdateAfterBindResources.Value;
            }

            if (maxDescriptorSetUpdateAfterBindSamplers is not null)
            {
                MaxDescriptorSetUpdateAfterBindSamplers = maxDescriptorSetUpdateAfterBindSamplers.Value;
            }

            if (maxDescriptorSetUpdateAfterBindUniformBuffers is not null)
            {
                MaxDescriptorSetUpdateAfterBindUniformBuffers = maxDescriptorSetUpdateAfterBindUniformBuffers.Value;
            }

            if (maxDescriptorSetUpdateAfterBindUniformBuffersDynamic is not null)
            {
                MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic = maxDescriptorSetUpdateAfterBindUniformBuffersDynamic.Value;
            }

            if (maxDescriptorSetUpdateAfterBindStorageBuffers is not null)
            {
                MaxDescriptorSetUpdateAfterBindStorageBuffers = maxDescriptorSetUpdateAfterBindStorageBuffers.Value;
            }

            if (maxDescriptorSetUpdateAfterBindStorageBuffersDynamic is not null)
            {
                MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic = maxDescriptorSetUpdateAfterBindStorageBuffersDynamic.Value;
            }

            if (maxDescriptorSetUpdateAfterBindSampledImages is not null)
            {
                MaxDescriptorSetUpdateAfterBindSampledImages = maxDescriptorSetUpdateAfterBindSampledImages.Value;
            }

            if (maxDescriptorSetUpdateAfterBindStorageImages is not null)
            {
                MaxDescriptorSetUpdateAfterBindStorageImages = maxDescriptorSetUpdateAfterBindStorageImages.Value;
            }

            if (maxDescriptorSetUpdateAfterBindInputAttachments is not null)
            {
                MaxDescriptorSetUpdateAfterBindInputAttachments = maxDescriptorSetUpdateAfterBindInputAttachments.Value;
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
        [NativeName("Name", "maxUpdateAfterBindDescriptorsInAllPools")]
        public uint MaxUpdateAfterBindDescriptorsInAllPools;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderUniformBufferArrayNonUniformIndexingNative")]
        public Bool32 ShaderUniformBufferArrayNonUniformIndexingNative;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderSampledImageArrayNonUniformIndexingNative")]
        public Bool32 ShaderSampledImageArrayNonUniformIndexingNative;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderStorageBufferArrayNonUniformIndexingNative")]
        public Bool32 ShaderStorageBufferArrayNonUniformIndexingNative;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderStorageImageArrayNonUniformIndexingNative")]
        public Bool32 ShaderStorageImageArrayNonUniformIndexingNative;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderInputAttachmentArrayNonUniformIndexingNative")]
        public Bool32 ShaderInputAttachmentArrayNonUniformIndexingNative;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "robustBufferAccessUpdateAfterBind")]
        public Bool32 RobustBufferAccessUpdateAfterBind;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "quadDivergentImplicitLod")]
        public Bool32 QuadDivergentImplicitLod;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPerStageDescriptorUpdateAfterBindSamplers")]
        public uint MaxPerStageDescriptorUpdateAfterBindSamplers;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPerStageDescriptorUpdateAfterBindUniformBuffers")]
        public uint MaxPerStageDescriptorUpdateAfterBindUniformBuffers;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPerStageDescriptorUpdateAfterBindStorageBuffers")]
        public uint MaxPerStageDescriptorUpdateAfterBindStorageBuffers;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPerStageDescriptorUpdateAfterBindSampledImages")]
        public uint MaxPerStageDescriptorUpdateAfterBindSampledImages;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPerStageDescriptorUpdateAfterBindStorageImages")]
        public uint MaxPerStageDescriptorUpdateAfterBindStorageImages;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPerStageDescriptorUpdateAfterBindInputAttachments")]
        public uint MaxPerStageDescriptorUpdateAfterBindInputAttachments;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPerStageUpdateAfterBindResources")]
        public uint MaxPerStageUpdateAfterBindResources;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorSetUpdateAfterBindSamplers")]
        public uint MaxDescriptorSetUpdateAfterBindSamplers;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorSetUpdateAfterBindUniformBuffers")]
        public uint MaxDescriptorSetUpdateAfterBindUniformBuffers;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorSetUpdateAfterBindUniformBuffersDynamic")]
        public uint MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorSetUpdateAfterBindStorageBuffers")]
        public uint MaxDescriptorSetUpdateAfterBindStorageBuffers;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorSetUpdateAfterBindStorageBuffersDynamic")]
        public uint MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorSetUpdateAfterBindSampledImages")]
        public uint MaxDescriptorSetUpdateAfterBindSampledImages;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorSetUpdateAfterBindStorageImages")]
        public uint MaxDescriptorSetUpdateAfterBindStorageImages;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorSetUpdateAfterBindInputAttachments")]
        public uint MaxDescriptorSetUpdateAfterBindInputAttachments;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceDescriptorIndexingProperties;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
