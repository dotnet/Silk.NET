// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPhysicalDeviceDescriptorIndexingProperties")]
    public unsafe struct PhysicalDeviceDescriptorIndexingProperties
    {
        public PhysicalDeviceDescriptorIndexingProperties
        (
            StructureType sType = StructureType.PhysicalDeviceDescriptorIndexingProperties,
            void* pNext = default,
            uint maxUpdateAfterBindDescriptorsInAllPools = default,
            Bool32 shaderUniformBufferArrayNonUniformIndexingNative = default,
            Bool32 shaderSampledImageArrayNonUniformIndexingNative = default,
            Bool32 shaderStorageBufferArrayNonUniformIndexingNative = default,
            Bool32 shaderStorageImageArrayNonUniformIndexingNative = default,
            Bool32 shaderInputAttachmentArrayNonUniformIndexingNative = default,
            Bool32 robustBufferAccessUpdateAfterBind = default,
            Bool32 quadDivergentImplicitLod = default,
            uint maxPerStageDescriptorUpdateAfterBindSamplers = default,
            uint maxPerStageDescriptorUpdateAfterBindUniformBuffers = default,
            uint maxPerStageDescriptorUpdateAfterBindStorageBuffers = default,
            uint maxPerStageDescriptorUpdateAfterBindSampledImages = default,
            uint maxPerStageDescriptorUpdateAfterBindStorageImages = default,
            uint maxPerStageDescriptorUpdateAfterBindInputAttachments = default,
            uint maxPerStageUpdateAfterBindResources = default,
            uint maxDescriptorSetUpdateAfterBindSamplers = default,
            uint maxDescriptorSetUpdateAfterBindUniformBuffers = default,
            uint maxDescriptorSetUpdateAfterBindUniformBuffersDynamic = default,
            uint maxDescriptorSetUpdateAfterBindStorageBuffers = default,
            uint maxDescriptorSetUpdateAfterBindStorageBuffersDynamic = default,
            uint maxDescriptorSetUpdateAfterBindSampledImages = default,
            uint maxDescriptorSetUpdateAfterBindStorageImages = default,
            uint maxDescriptorSetUpdateAfterBindInputAttachments = default
        )
        {
           SType = sType;
           PNext = pNext;
           MaxUpdateAfterBindDescriptorsInAllPools = maxUpdateAfterBindDescriptorsInAllPools;
           ShaderUniformBufferArrayNonUniformIndexingNative = shaderUniformBufferArrayNonUniformIndexingNative;
           ShaderSampledImageArrayNonUniformIndexingNative = shaderSampledImageArrayNonUniformIndexingNative;
           ShaderStorageBufferArrayNonUniformIndexingNative = shaderStorageBufferArrayNonUniformIndexingNative;
           ShaderStorageImageArrayNonUniformIndexingNative = shaderStorageImageArrayNonUniformIndexingNative;
           ShaderInputAttachmentArrayNonUniformIndexingNative = shaderInputAttachmentArrayNonUniformIndexingNative;
           RobustBufferAccessUpdateAfterBind = robustBufferAccessUpdateAfterBind;
           QuadDivergentImplicitLod = quadDivergentImplicitLod;
           MaxPerStageDescriptorUpdateAfterBindSamplers = maxPerStageDescriptorUpdateAfterBindSamplers;
           MaxPerStageDescriptorUpdateAfterBindUniformBuffers = maxPerStageDescriptorUpdateAfterBindUniformBuffers;
           MaxPerStageDescriptorUpdateAfterBindStorageBuffers = maxPerStageDescriptorUpdateAfterBindStorageBuffers;
           MaxPerStageDescriptorUpdateAfterBindSampledImages = maxPerStageDescriptorUpdateAfterBindSampledImages;
           MaxPerStageDescriptorUpdateAfterBindStorageImages = maxPerStageDescriptorUpdateAfterBindStorageImages;
           MaxPerStageDescriptorUpdateAfterBindInputAttachments = maxPerStageDescriptorUpdateAfterBindInputAttachments;
           MaxPerStageUpdateAfterBindResources = maxPerStageUpdateAfterBindResources;
           MaxDescriptorSetUpdateAfterBindSamplers = maxDescriptorSetUpdateAfterBindSamplers;
           MaxDescriptorSetUpdateAfterBindUniformBuffers = maxDescriptorSetUpdateAfterBindUniformBuffers;
           MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic = maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
           MaxDescriptorSetUpdateAfterBindStorageBuffers = maxDescriptorSetUpdateAfterBindStorageBuffers;
           MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic = maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
           MaxDescriptorSetUpdateAfterBindSampledImages = maxDescriptorSetUpdateAfterBindSampledImages;
           MaxDescriptorSetUpdateAfterBindStorageImages = maxDescriptorSetUpdateAfterBindStorageImages;
           MaxDescriptorSetUpdateAfterBindInputAttachments = maxDescriptorSetUpdateAfterBindInputAttachments;
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
    }
}
