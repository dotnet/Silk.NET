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
    [NativeName("Name", "VkPhysicalDeviceVulkan12Properties")]
    public unsafe struct PhysicalDeviceVulkan12Properties
    {
        public PhysicalDeviceVulkan12Properties
        (
            StructureType sType = StructureType.PhysicalDeviceVulkan12Properties,
            void* pNext = default,
            DriverId driverID = default,
            ConformanceVersion conformanceVersion = default,
            ShaderFloatControlsIndependence denormBehaviorIndependence = default,
            ShaderFloatControlsIndependence roundingModeIndependence = default,
            Bool32 shaderSignedZeroInfNanPreserveFloat16 = default,
            Bool32 shaderSignedZeroInfNanPreserveFloat32 = default,
            Bool32 shaderSignedZeroInfNanPreserveFloat64 = default,
            Bool32 shaderDenormPreserveFloat16 = default,
            Bool32 shaderDenormPreserveFloat32 = default,
            Bool32 shaderDenormPreserveFloat64 = default,
            Bool32 shaderDenormFlushToZeroFloat16 = default,
            Bool32 shaderDenormFlushToZeroFloat32 = default,
            Bool32 shaderDenormFlushToZeroFloat64 = default,
            Bool32 shaderRoundingModeRtefloat16 = default,
            Bool32 shaderRoundingModeRtefloat32 = default,
            Bool32 shaderRoundingModeRtefloat64 = default,
            Bool32 shaderRoundingModeRtzfloat16 = default,
            Bool32 shaderRoundingModeRtzfloat32 = default,
            Bool32 shaderRoundingModeRtzfloat64 = default,
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
            uint maxDescriptorSetUpdateAfterBindInputAttachments = default,
            ResolveModeFlags supportedDepthResolveModes = default,
            ResolveModeFlags supportedStencilResolveModes = default,
            Bool32 independentResolveNone = default,
            Bool32 independentResolve = default,
            Bool32 filterMinmaxSingleComponentFormats = default,
            Bool32 filterMinmaxImageComponentMapping = default,
            ulong maxTimelineSemaphoreValueDifference = default,
            SampleCountFlags framebufferIntegerColorSampleCounts = default
        )
        {
           SType = sType;
           PNext = pNext;
           DriverID = driverID;
           ConformanceVersion = conformanceVersion;
           DenormBehaviorIndependence = denormBehaviorIndependence;
           RoundingModeIndependence = roundingModeIndependence;
           ShaderSignedZeroInfNanPreserveFloat16 = shaderSignedZeroInfNanPreserveFloat16;
           ShaderSignedZeroInfNanPreserveFloat32 = shaderSignedZeroInfNanPreserveFloat32;
           ShaderSignedZeroInfNanPreserveFloat64 = shaderSignedZeroInfNanPreserveFloat64;
           ShaderDenormPreserveFloat16 = shaderDenormPreserveFloat16;
           ShaderDenormPreserveFloat32 = shaderDenormPreserveFloat32;
           ShaderDenormPreserveFloat64 = shaderDenormPreserveFloat64;
           ShaderDenormFlushToZeroFloat16 = shaderDenormFlushToZeroFloat16;
           ShaderDenormFlushToZeroFloat32 = shaderDenormFlushToZeroFloat32;
           ShaderDenormFlushToZeroFloat64 = shaderDenormFlushToZeroFloat64;
           ShaderRoundingModeRtefloat16 = shaderRoundingModeRtefloat16;
           ShaderRoundingModeRtefloat32 = shaderRoundingModeRtefloat32;
           ShaderRoundingModeRtefloat64 = shaderRoundingModeRtefloat64;
           ShaderRoundingModeRtzfloat16 = shaderRoundingModeRtzfloat16;
           ShaderRoundingModeRtzfloat32 = shaderRoundingModeRtzfloat32;
           ShaderRoundingModeRtzfloat64 = shaderRoundingModeRtzfloat64;
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
           SupportedDepthResolveModes = supportedDepthResolveModes;
           SupportedStencilResolveModes = supportedStencilResolveModes;
           IndependentResolveNone = independentResolveNone;
           IndependentResolve = independentResolve;
           FilterMinmaxSingleComponentFormats = filterMinmaxSingleComponentFormats;
           FilterMinmaxImageComponentMapping = filterMinmaxImageComponentMapping;
           MaxTimelineSemaphoreValueDifference = maxTimelineSemaphoreValueDifference;
           FramebufferIntegerColorSampleCounts = framebufferIntegerColorSampleCounts;
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
        [NativeName("Type", "VkDriverId")]
        [NativeName("Type.Name", "VkDriverId")]
        [NativeName("Name", "driverID")]
        public DriverId DriverID;
        /// <summary></summary>
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "driverName")]
       public fixed byte DriverName[256];
        /// <summary></summary>
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "driverInfo")]
       public fixed byte DriverInfo[256];
/// <summary></summary>
        [NativeName("Type", "VkConformanceVersion")]
        [NativeName("Type.Name", "VkConformanceVersion")]
        [NativeName("Name", "conformanceVersion")]
        public ConformanceVersion ConformanceVersion;
/// <summary></summary>
        [NativeName("Type", "VkShaderFloatControlsIndependence")]
        [NativeName("Type.Name", "VkShaderFloatControlsIndependence")]
        [NativeName("Name", "denormBehaviorIndependence")]
        public ShaderFloatControlsIndependence DenormBehaviorIndependence;
/// <summary></summary>
        [NativeName("Type", "VkShaderFloatControlsIndependence")]
        [NativeName("Type.Name", "VkShaderFloatControlsIndependence")]
        [NativeName("Name", "roundingModeIndependence")]
        public ShaderFloatControlsIndependence RoundingModeIndependence;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderSignedZeroInfNanPreserveFloat16")]
        public Bool32 ShaderSignedZeroInfNanPreserveFloat16;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderSignedZeroInfNanPreserveFloat32")]
        public Bool32 ShaderSignedZeroInfNanPreserveFloat32;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderSignedZeroInfNanPreserveFloat64")]
        public Bool32 ShaderSignedZeroInfNanPreserveFloat64;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderDenormPreserveFloat16")]
        public Bool32 ShaderDenormPreserveFloat16;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderDenormPreserveFloat32")]
        public Bool32 ShaderDenormPreserveFloat32;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderDenormPreserveFloat64")]
        public Bool32 ShaderDenormPreserveFloat64;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderDenormFlushToZeroFloat16")]
        public Bool32 ShaderDenormFlushToZeroFloat16;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderDenormFlushToZeroFloat32")]
        public Bool32 ShaderDenormFlushToZeroFloat32;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderDenormFlushToZeroFloat64")]
        public Bool32 ShaderDenormFlushToZeroFloat64;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderRoundingModeRTEFloat16")]
        public Bool32 ShaderRoundingModeRtefloat16;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderRoundingModeRTEFloat32")]
        public Bool32 ShaderRoundingModeRtefloat32;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderRoundingModeRTEFloat64")]
        public Bool32 ShaderRoundingModeRtefloat64;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderRoundingModeRTZFloat16")]
        public Bool32 ShaderRoundingModeRtzfloat16;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderRoundingModeRTZFloat32")]
        public Bool32 ShaderRoundingModeRtzfloat32;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderRoundingModeRTZFloat64")]
        public Bool32 ShaderRoundingModeRtzfloat64;
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
/// <summary></summary>
        [NativeName("Type", "VkResolveModeFlags")]
        [NativeName("Type.Name", "VkResolveModeFlags")]
        [NativeName("Name", "supportedDepthResolveModes")]
        public ResolveModeFlags SupportedDepthResolveModes;
/// <summary></summary>
        [NativeName("Type", "VkResolveModeFlags")]
        [NativeName("Type.Name", "VkResolveModeFlags")]
        [NativeName("Name", "supportedStencilResolveModes")]
        public ResolveModeFlags SupportedStencilResolveModes;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "independentResolveNone")]
        public Bool32 IndependentResolveNone;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "independentResolve")]
        public Bool32 IndependentResolve;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "filterMinmaxSingleComponentFormats")]
        public Bool32 FilterMinmaxSingleComponentFormats;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "filterMinmaxImageComponentMapping")]
        public Bool32 FilterMinmaxImageComponentMapping;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "maxTimelineSemaphoreValueDifference")]
        public ulong MaxTimelineSemaphoreValueDifference;
/// <summary></summary>
        [NativeName("Type", "VkSampleCountFlags")]
        [NativeName("Type.Name", "VkSampleCountFlags")]
        [NativeName("Name", "framebufferIntegerColorSampleCounts")]
        public SampleCountFlags FramebufferIntegerColorSampleCounts;
    }
}
