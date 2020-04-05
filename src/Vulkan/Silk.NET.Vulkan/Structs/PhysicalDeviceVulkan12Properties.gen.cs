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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public DriverId DriverID;
        /// <summary></summary>
       public fixed byte DriverName[256];
        /// <summary></summary>
       public fixed byte DriverInfo[256];
/// <summary></summary>
        public ConformanceVersion ConformanceVersion;
/// <summary></summary>
        public ShaderFloatControlsIndependence DenormBehaviorIndependence;
/// <summary></summary>
        public ShaderFloatControlsIndependence RoundingModeIndependence;
/// <summary></summary>
        public Bool32 ShaderSignedZeroInfNanPreserveFloat16;
/// <summary></summary>
        public Bool32 ShaderSignedZeroInfNanPreserveFloat32;
/// <summary></summary>
        public Bool32 ShaderSignedZeroInfNanPreserveFloat64;
/// <summary></summary>
        public Bool32 ShaderDenormPreserveFloat16;
/// <summary></summary>
        public Bool32 ShaderDenormPreserveFloat32;
/// <summary></summary>
        public Bool32 ShaderDenormPreserveFloat64;
/// <summary></summary>
        public Bool32 ShaderDenormFlushToZeroFloat16;
/// <summary></summary>
        public Bool32 ShaderDenormFlushToZeroFloat32;
/// <summary></summary>
        public Bool32 ShaderDenormFlushToZeroFloat64;
/// <summary></summary>
        public Bool32 ShaderRoundingModeRtefloat16;
/// <summary></summary>
        public Bool32 ShaderRoundingModeRtefloat32;
/// <summary></summary>
        public Bool32 ShaderRoundingModeRtefloat64;
/// <summary></summary>
        public Bool32 ShaderRoundingModeRtzfloat16;
/// <summary></summary>
        public Bool32 ShaderRoundingModeRtzfloat32;
/// <summary></summary>
        public Bool32 ShaderRoundingModeRtzfloat64;
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
/// <summary></summary>
        public ResolveModeFlags SupportedDepthResolveModes;
/// <summary></summary>
        public ResolveModeFlags SupportedStencilResolveModes;
/// <summary></summary>
        public Bool32 IndependentResolveNone;
/// <summary></summary>
        public Bool32 IndependentResolve;
/// <summary></summary>
        public Bool32 FilterMinmaxSingleComponentFormats;
/// <summary></summary>
        public Bool32 FilterMinmaxImageComponentMapping;
/// <summary></summary>
        public ulong MaxTimelineSemaphoreValueDifference;
/// <summary></summary>
        public SampleCountFlags FramebufferIntegerColorSampleCounts;
    }
}
