// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceVulkan12Properties")]
public unsafe partial struct PhysicalDeviceVulkan12Properties
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceVulkan1x2Properties;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("driverID")]
    public DriverId DriverID;

    [NativeName("driverName")]
    public PhysicalDeviceVulkan12PropertiesDriverName DriverName;

    [NativeName("driverInfo")]
    public PhysicalDeviceVulkan12PropertiesDriverInfo DriverInfo;

    [NativeName("conformanceVersion")]
    public ConformanceVersion ConformanceVersion;

    [NativeName("denormBehaviorIndependence")]
    public ShaderFloatControlsIndependence DenormBehaviorIndependence;

    [NativeName("roundingModeIndependence")]
    public ShaderFloatControlsIndependence RoundingModeIndependence;

    [NativeName("shaderSignedZeroInfNanPreserveFloat16")]
    public MaybeBool<uint> ShaderSignedZeroInfNanPreserveFloat16;

    [NativeName("shaderSignedZeroInfNanPreserveFloat32")]
    public MaybeBool<uint> ShaderSignedZeroInfNanPreserveFloat32;

    [NativeName("shaderSignedZeroInfNanPreserveFloat64")]
    public MaybeBool<uint> ShaderSignedZeroInfNanPreserveFloat64;

    [NativeName("shaderDenormPreserveFloat16")]
    public MaybeBool<uint> ShaderDenormPreserveFloat16;

    [NativeName("shaderDenormPreserveFloat32")]
    public MaybeBool<uint> ShaderDenormPreserveFloat32;

    [NativeName("shaderDenormPreserveFloat64")]
    public MaybeBool<uint> ShaderDenormPreserveFloat64;

    [NativeName("shaderDenormFlushToZeroFloat16")]
    public MaybeBool<uint> ShaderDenormFlushToZeroFloat16;

    [NativeName("shaderDenormFlushToZeroFloat32")]
    public MaybeBool<uint> ShaderDenormFlushToZeroFloat32;

    [NativeName("shaderDenormFlushToZeroFloat64")]
    public MaybeBool<uint> ShaderDenormFlushToZeroFloat64;

    [NativeName("shaderRoundingModeRTEFloat16")]
    public MaybeBool<uint> ShaderRoundingModeRteFloat16;

    [NativeName("shaderRoundingModeRTEFloat32")]
    public MaybeBool<uint> ShaderRoundingModeRteFloat32;

    [NativeName("shaderRoundingModeRTEFloat64")]
    public MaybeBool<uint> ShaderRoundingModeRteFloat64;

    [NativeName("shaderRoundingModeRTZFloat16")]
    public MaybeBool<uint> ShaderRoundingModeRtzFloat16;

    [NativeName("shaderRoundingModeRTZFloat32")]
    public MaybeBool<uint> ShaderRoundingModeRtzFloat32;

    [NativeName("shaderRoundingModeRTZFloat64")]
    public MaybeBool<uint> ShaderRoundingModeRtzFloat64;

    [NativeName("maxUpdateAfterBindDescriptorsInAllPools")]
    public uint MaxUpdateAfterBindDescriptorsInAllPools;

    [NativeName("shaderUniformBufferArrayNonUniformIndexingNative")]
    public MaybeBool<uint> ShaderUniformBufferArrayNonUniformIndexingNative;

    [NativeName("shaderSampledImageArrayNonUniformIndexingNative")]
    public MaybeBool<uint> ShaderSampledImageArrayNonUniformIndexingNative;

    [NativeName("shaderStorageBufferArrayNonUniformIndexingNative")]
    public MaybeBool<uint> ShaderStorageBufferArrayNonUniformIndexingNative;

    [NativeName("shaderStorageImageArrayNonUniformIndexingNative")]
    public MaybeBool<uint> ShaderStorageImageArrayNonUniformIndexingNative;

    [NativeName("shaderInputAttachmentArrayNonUniformIndexingNative")]
    public MaybeBool<uint> ShaderInputAttachmentArrayNonUniformIndexingNative;

    [NativeName("robustBufferAccessUpdateAfterBind")]
    public MaybeBool<uint> RobustBufferAccessUpdateAfterBind;

    [NativeName("quadDivergentImplicitLod")]
    public MaybeBool<uint> QuadDivergentImplicitLod;

    [NativeName("maxPerStageDescriptorUpdateAfterBindSamplers")]
    public uint MaxPerStageDescriptorUpdateAfterBindSamplers;

    [NativeName("maxPerStageDescriptorUpdateAfterBindUniformBuffers")]
    public uint MaxPerStageDescriptorUpdateAfterBindUniformBuffers;

    [NativeName("maxPerStageDescriptorUpdateAfterBindStorageBuffers")]
    public uint MaxPerStageDescriptorUpdateAfterBindStorageBuffers;

    [NativeName("maxPerStageDescriptorUpdateAfterBindSampledImages")]
    public uint MaxPerStageDescriptorUpdateAfterBindSampledImages;

    [NativeName("maxPerStageDescriptorUpdateAfterBindStorageImages")]
    public uint MaxPerStageDescriptorUpdateAfterBindStorageImages;

    [NativeName("maxPerStageDescriptorUpdateAfterBindInputAttachments")]
    public uint MaxPerStageDescriptorUpdateAfterBindInputAttachments;

    [NativeName("maxPerStageUpdateAfterBindResources")]
    public uint MaxPerStageUpdateAfterBindResources;

    [NativeName("maxDescriptorSetUpdateAfterBindSamplers")]
    public uint MaxDescriptorSetUpdateAfterBindSamplers;

    [NativeName("maxDescriptorSetUpdateAfterBindUniformBuffers")]
    public uint MaxDescriptorSetUpdateAfterBindUniformBuffers;

    [NativeName("maxDescriptorSetUpdateAfterBindUniformBuffersDynamic")]
    public uint MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic;

    [NativeName("maxDescriptorSetUpdateAfterBindStorageBuffers")]
    public uint MaxDescriptorSetUpdateAfterBindStorageBuffers;

    [NativeName("maxDescriptorSetUpdateAfterBindStorageBuffersDynamic")]
    public uint MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic;

    [NativeName("maxDescriptorSetUpdateAfterBindSampledImages")]
    public uint MaxDescriptorSetUpdateAfterBindSampledImages;

    [NativeName("maxDescriptorSetUpdateAfterBindStorageImages")]
    public uint MaxDescriptorSetUpdateAfterBindStorageImages;

    [NativeName("maxDescriptorSetUpdateAfterBindInputAttachments")]
    public uint MaxDescriptorSetUpdateAfterBindInputAttachments;

    [NativeName("supportedDepthResolveModes")]
    public ResolveModeFlags SupportedDepthResolveModes;

    [NativeName("supportedStencilResolveModes")]
    public ResolveModeFlags SupportedStencilResolveModes;

    [NativeName("independentResolveNone")]
    public MaybeBool<uint> IndependentResolveNone;

    [NativeName("independentResolve")]
    public MaybeBool<uint> IndependentResolve;

    [NativeName("filterMinmaxSingleComponentFormats")]
    public MaybeBool<uint> FilterMinmaxSingleComponentFormats;

    [NativeName("filterMinmaxImageComponentMapping")]
    public MaybeBool<uint> FilterMinmaxImageComponentMapping;

    [NativeName("maxTimelineSemaphoreValueDifference")]
    public ulong MaxTimelineSemaphoreValueDifference;

    [NativeName("framebufferIntegerColorSampleCounts")]
    public SampleCountFlags FramebufferIntegerColorSampleCounts;

    public PhysicalDeviceVulkan12Properties() { }
}
