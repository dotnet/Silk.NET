// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint MaxUpdateAfterBindDescriptorsInAllPools;
/// <summary></summary>
        public Bool32 ShaderUniformBufferArrayNonUniformIndexingNative;
/// <summary></summary>
        public Bool32 ShaderSampledImageArrayNonUniformIndexingNative;
/// <summary></summary>
        public Bool32 ShaderStorageBufferArrayNonUniformIndexingNative;
/// <summary></summary>
        public Bool32 ShaderStorageImageArrayNonUniformIndexingNative;
/// <summary></summary>
        public Bool32 ShaderInputAttachmentArrayNonUniformIndexingNative;
/// <summary></summary>
        public Bool32 RobustBufferAccessUpdateAfterBind;
/// <summary></summary>
        public Bool32 QuadDivergentImplicitLod;
/// <summary></summary>
        public uint MaxPerStageDescriptorUpdateAfterBindSamplers;
/// <summary></summary>
        public uint MaxPerStageDescriptorUpdateAfterBindUniformBuffers;
/// <summary></summary>
        public uint MaxPerStageDescriptorUpdateAfterBindStorageBuffers;
/// <summary></summary>
        public uint MaxPerStageDescriptorUpdateAfterBindSampledImages;
/// <summary></summary>
        public uint MaxPerStageDescriptorUpdateAfterBindStorageImages;
/// <summary></summary>
        public uint MaxPerStageDescriptorUpdateAfterBindInputAttachments;
/// <summary></summary>
        public uint MaxPerStageUpdateAfterBindResources;
/// <summary></summary>
        public uint MaxDescriptorSetUpdateAfterBindSamplers;
/// <summary></summary>
        public uint MaxDescriptorSetUpdateAfterBindUniformBuffers;
/// <summary></summary>
        public uint MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
/// <summary></summary>
        public uint MaxDescriptorSetUpdateAfterBindStorageBuffers;
/// <summary></summary>
        public uint MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
/// <summary></summary>
        public uint MaxDescriptorSetUpdateAfterBindSampledImages;
/// <summary></summary>
        public uint MaxDescriptorSetUpdateAfterBindStorageImages;
/// <summary></summary>
        public uint MaxDescriptorSetUpdateAfterBindInputAttachments;
    }
}
