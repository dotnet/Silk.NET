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
    [NativeName("Name", "VkPhysicalDeviceVulkan12Properties")]
    public unsafe partial struct PhysicalDeviceVulkan12Properties : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceVulkan12Properties
        (
            StructureType? sType = StructureType.PhysicalDeviceVulkan12Properties,
            void* pNext = null,
            DriverId? driverID = null,
            ConformanceVersion? conformanceVersion = null,
            ShaderFloatControlsIndependence? denormBehaviorIndependence = null,
            ShaderFloatControlsIndependence? roundingModeIndependence = null,
            Bool32? shaderSignedZeroInfNanPreserveFloat16 = null,
            Bool32? shaderSignedZeroInfNanPreserveFloat32 = null,
            Bool32? shaderSignedZeroInfNanPreserveFloat64 = null,
            Bool32? shaderDenormPreserveFloat16 = null,
            Bool32? shaderDenormPreserveFloat32 = null,
            Bool32? shaderDenormPreserveFloat64 = null,
            Bool32? shaderDenormFlushToZeroFloat16 = null,
            Bool32? shaderDenormFlushToZeroFloat32 = null,
            Bool32? shaderDenormFlushToZeroFloat64 = null,
            Bool32? shaderRoundingModeRtefloat16 = null,
            Bool32? shaderRoundingModeRtefloat32 = null,
            Bool32? shaderRoundingModeRtefloat64 = null,
            Bool32? shaderRoundingModeRtzfloat16 = null,
            Bool32? shaderRoundingModeRtzfloat32 = null,
            Bool32? shaderRoundingModeRtzfloat64 = null,
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
            uint? maxDescriptorSetUpdateAfterBindInputAttachments = null,
            ResolveModeFlags? supportedDepthResolveModes = null,
            ResolveModeFlags? supportedStencilResolveModes = null,
            Bool32? independentResolveNone = null,
            Bool32? independentResolve = null,
            Bool32? filterMinmaxSingleComponentFormats = null,
            Bool32? filterMinmaxImageComponentMapping = null,
            ulong? maxTimelineSemaphoreValueDifference = null,
            SampleCountFlags? framebufferIntegerColorSampleCounts = null
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

            if (driverID is not null)
            {
                DriverID = driverID.Value;
            }

            if (conformanceVersion is not null)
            {
                ConformanceVersion = conformanceVersion.Value;
            }

            if (denormBehaviorIndependence is not null)
            {
                DenormBehaviorIndependence = denormBehaviorIndependence.Value;
            }

            if (roundingModeIndependence is not null)
            {
                RoundingModeIndependence = roundingModeIndependence.Value;
            }

            if (shaderSignedZeroInfNanPreserveFloat16 is not null)
            {
                ShaderSignedZeroInfNanPreserveFloat16 = shaderSignedZeroInfNanPreserveFloat16.Value;
            }

            if (shaderSignedZeroInfNanPreserveFloat32 is not null)
            {
                ShaderSignedZeroInfNanPreserveFloat32 = shaderSignedZeroInfNanPreserveFloat32.Value;
            }

            if (shaderSignedZeroInfNanPreserveFloat64 is not null)
            {
                ShaderSignedZeroInfNanPreserveFloat64 = shaderSignedZeroInfNanPreserveFloat64.Value;
            }

            if (shaderDenormPreserveFloat16 is not null)
            {
                ShaderDenormPreserveFloat16 = shaderDenormPreserveFloat16.Value;
            }

            if (shaderDenormPreserveFloat32 is not null)
            {
                ShaderDenormPreserveFloat32 = shaderDenormPreserveFloat32.Value;
            }

            if (shaderDenormPreserveFloat64 is not null)
            {
                ShaderDenormPreserveFloat64 = shaderDenormPreserveFloat64.Value;
            }

            if (shaderDenormFlushToZeroFloat16 is not null)
            {
                ShaderDenormFlushToZeroFloat16 = shaderDenormFlushToZeroFloat16.Value;
            }

            if (shaderDenormFlushToZeroFloat32 is not null)
            {
                ShaderDenormFlushToZeroFloat32 = shaderDenormFlushToZeroFloat32.Value;
            }

            if (shaderDenormFlushToZeroFloat64 is not null)
            {
                ShaderDenormFlushToZeroFloat64 = shaderDenormFlushToZeroFloat64.Value;
            }

            if (shaderRoundingModeRtefloat16 is not null)
            {
                ShaderRoundingModeRtefloat16 = shaderRoundingModeRtefloat16.Value;
            }

            if (shaderRoundingModeRtefloat32 is not null)
            {
                ShaderRoundingModeRtefloat32 = shaderRoundingModeRtefloat32.Value;
            }

            if (shaderRoundingModeRtefloat64 is not null)
            {
                ShaderRoundingModeRtefloat64 = shaderRoundingModeRtefloat64.Value;
            }

            if (shaderRoundingModeRtzfloat16 is not null)
            {
                ShaderRoundingModeRtzfloat16 = shaderRoundingModeRtzfloat16.Value;
            }

            if (shaderRoundingModeRtzfloat32 is not null)
            {
                ShaderRoundingModeRtzfloat32 = shaderRoundingModeRtzfloat32.Value;
            }

            if (shaderRoundingModeRtzfloat64 is not null)
            {
                ShaderRoundingModeRtzfloat64 = shaderRoundingModeRtzfloat64.Value;
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

            if (supportedDepthResolveModes is not null)
            {
                SupportedDepthResolveModes = supportedDepthResolveModes.Value;
            }

            if (supportedStencilResolveModes is not null)
            {
                SupportedStencilResolveModes = supportedStencilResolveModes.Value;
            }

            if (independentResolveNone is not null)
            {
                IndependentResolveNone = independentResolveNone.Value;
            }

            if (independentResolve is not null)
            {
                IndependentResolve = independentResolve.Value;
            }

            if (filterMinmaxSingleComponentFormats is not null)
            {
                FilterMinmaxSingleComponentFormats = filterMinmaxSingleComponentFormats.Value;
            }

            if (filterMinmaxImageComponentMapping is not null)
            {
                FilterMinmaxImageComponentMapping = filterMinmaxImageComponentMapping.Value;
            }

            if (maxTimelineSemaphoreValueDifference is not null)
            {
                MaxTimelineSemaphoreValueDifference = maxTimelineSemaphoreValueDifference.Value;
            }

            if (framebufferIntegerColorSampleCounts is not null)
            {
                FramebufferIntegerColorSampleCounts = framebufferIntegerColorSampleCounts.Value;
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

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceVulkan12Properties;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
