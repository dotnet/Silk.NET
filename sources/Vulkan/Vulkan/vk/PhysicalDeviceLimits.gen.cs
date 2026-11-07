// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceLimits")]
public partial struct PhysicalDeviceLimits
{
    [NativeName("maxImageDimension1D")]
    public uint MaxImageDimension1D;

    [NativeName("maxImageDimension2D")]
    public uint MaxImageDimension2D;

    [NativeName("maxImageDimension3D")]
    public uint MaxImageDimension3D;

    [NativeName("maxImageDimensionCube")]
    public uint MaxImageDimensionCube;

    [NativeName("maxImageArrayLayers")]
    public uint MaxImageArrayLayers;

    [NativeName("maxTexelBufferElements")]
    public uint MaxTexelBufferElements;

    [NativeName("maxUniformBufferRange")]
    public uint MaxUniformBufferRange;

    [NativeName("maxStorageBufferRange")]
    public uint MaxStorageBufferRange;

    [NativeName("maxPushConstantsSize")]
    public uint MaxPushConstantsSize;

    [NativeName("maxMemoryAllocationCount")]
    public uint MaxMemoryAllocationCount;

    [NativeName("maxSamplerAllocationCount")]
    public uint MaxSamplerAllocationCount;

    [NativeName("bufferImageGranularity")]
    public ulong BufferImageGranularity;

    [NativeName("sparseAddressSpaceSize")]
    public ulong SparseAddressSpaceSize;

    [NativeName("maxBoundDescriptorSets")]
    public uint MaxBoundDescriptorSets;

    [NativeName("maxPerStageDescriptorSamplers")]
    public uint MaxPerStageDescriptorSamplers;

    [NativeName("maxPerStageDescriptorUniformBuffers")]
    public uint MaxPerStageDescriptorUniformBuffers;

    [NativeName("maxPerStageDescriptorStorageBuffers")]
    public uint MaxPerStageDescriptorStorageBuffers;

    [NativeName("maxPerStageDescriptorSampledImages")]
    public uint MaxPerStageDescriptorSampledImages;

    [NativeName("maxPerStageDescriptorStorageImages")]
    public uint MaxPerStageDescriptorStorageImages;

    [NativeName("maxPerStageDescriptorInputAttachments")]
    public uint MaxPerStageDescriptorInputAttachments;

    [NativeName("maxPerStageResources")]
    public uint MaxPerStageResources;

    [NativeName("maxDescriptorSetSamplers")]
    public uint MaxDescriptorSetSamplers;

    [NativeName("maxDescriptorSetUniformBuffers")]
    public uint MaxDescriptorSetUniformBuffers;

    [NativeName("maxDescriptorSetUniformBuffersDynamic")]
    public uint MaxDescriptorSetUniformBuffersDynamic;

    [NativeName("maxDescriptorSetStorageBuffers")]
    public uint MaxDescriptorSetStorageBuffers;

    [NativeName("maxDescriptorSetStorageBuffersDynamic")]
    public uint MaxDescriptorSetStorageBuffersDynamic;

    [NativeName("maxDescriptorSetSampledImages")]
    public uint MaxDescriptorSetSampledImages;

    [NativeName("maxDescriptorSetStorageImages")]
    public uint MaxDescriptorSetStorageImages;

    [NativeName("maxDescriptorSetInputAttachments")]
    public uint MaxDescriptorSetInputAttachments;

    [NativeName("maxVertexInputAttributes")]
    public uint MaxVertexInputAttributes;

    [NativeName("maxVertexInputBindings")]
    public uint MaxVertexInputBindings;

    [NativeName("maxVertexInputAttributeOffset")]
    public uint MaxVertexInputAttributeOffset;

    [NativeName("maxVertexInputBindingStride")]
    public uint MaxVertexInputBindingStride;

    [NativeName("maxVertexOutputComponents")]
    public uint MaxVertexOutputComponents;

    [NativeName("maxTessellationGenerationLevel")]
    public uint MaxTessellationGenerationLevel;

    [NativeName("maxTessellationPatchSize")]
    public uint MaxTessellationPatchSize;

    [NativeName("maxTessellationControlPerVertexInputComponents")]
    public uint MaxTessellationControlPerVertexInputComponents;

    [NativeName("maxTessellationControlPerVertexOutputComponents")]
    public uint MaxTessellationControlPerVertexOutputComponents;

    [NativeName("maxTessellationControlPerPatchOutputComponents")]
    public uint MaxTessellationControlPerPatchOutputComponents;

    [NativeName("maxTessellationControlTotalOutputComponents")]
    public uint MaxTessellationControlTotalOutputComponents;

    [NativeName("maxTessellationEvaluationInputComponents")]
    public uint MaxTessellationEvaluationInputComponents;

    [NativeName("maxTessellationEvaluationOutputComponents")]
    public uint MaxTessellationEvaluationOutputComponents;

    [NativeName("maxGeometryShaderInvocations")]
    public uint MaxGeometryShaderInvocations;

    [NativeName("maxGeometryInputComponents")]
    public uint MaxGeometryInputComponents;

    [NativeName("maxGeometryOutputComponents")]
    public uint MaxGeometryOutputComponents;

    [NativeName("maxGeometryOutputVertices")]
    public uint MaxGeometryOutputVertices;

    [NativeName("maxGeometryTotalOutputComponents")]
    public uint MaxGeometryTotalOutputComponents;

    [NativeName("maxFragmentInputComponents")]
    public uint MaxFragmentInputComponents;

    [NativeName("maxFragmentOutputAttachments")]
    public uint MaxFragmentOutputAttachments;

    [NativeName("maxFragmentDualSrcAttachments")]
    public uint MaxFragmentDualSrcAttachments;

    [NativeName("maxFragmentCombinedOutputResources")]
    public uint MaxFragmentCombinedOutputResources;

    [NativeName("maxComputeSharedMemorySize")]
    public uint MaxComputeSharedMemorySize;

    [NativeName("maxComputeWorkGroupCount")]
    public PhysicalDeviceLimitsMaxComputeWorkGroupCount MaxComputeWorkGroupCount;

    [NativeName("maxComputeWorkGroupInvocations")]
    public uint MaxComputeWorkGroupInvocations;

    [NativeName("maxComputeWorkGroupSize")]
    public PhysicalDeviceLimitsMaxComputeWorkGroupSize MaxComputeWorkGroupSize;

    [NativeName("subPixelPrecisionBits")]
    public uint SubPixelPrecisionBits;

    [NativeName("subTexelPrecisionBits")]
    public uint SubTexelPrecisionBits;

    [NativeName("mipmapPrecisionBits")]
    public uint MipmapPrecisionBits;

    [NativeName("maxDrawIndexedIndexValue")]
    public uint MaxDrawIndexedIndexValue;

    [NativeName("maxDrawIndirectCount")]
    public uint MaxDrawIndirectCount;

    [NativeName("maxSamplerLodBias")]
    public float MaxSamplerLodBias;

    [NativeName("maxSamplerAnisotropy")]
    public float MaxSamplerAnisotropy;

    [NativeName("maxViewports")]
    public uint MaxViewports;

    [NativeName("maxViewportDimensions")]
    public PhysicalDeviceLimitsMaxViewportDimensions MaxViewportDimensions;

    [NativeName("viewportBoundsRange")]
    public PhysicalDeviceLimitsViewportBoundsRange ViewportBoundsRange;

    [NativeName("viewportSubPixelBits")]
    public uint ViewportSubPixelBits;

    [NativeName("minMemoryMapAlignment")]
    public nuint MinMemoryMapAlignment;

    [NativeName("minTexelBufferOffsetAlignment")]
    public ulong MinTexelBufferOffsetAlignment;

    [NativeName("minUniformBufferOffsetAlignment")]
    public ulong MinUniformBufferOffsetAlignment;

    [NativeName("minStorageBufferOffsetAlignment")]
    public ulong MinStorageBufferOffsetAlignment;

    [NativeName("minTexelOffset")]
    public int MinTexelOffset;

    [NativeName("maxTexelOffset")]
    public uint MaxTexelOffset;

    [NativeName("minTexelGatherOffset")]
    public int MinTexelGatherOffset;

    [NativeName("maxTexelGatherOffset")]
    public uint MaxTexelGatherOffset;

    [NativeName("minInterpolationOffset")]
    public float MinInterpolationOffset;

    [NativeName("maxInterpolationOffset")]
    public float MaxInterpolationOffset;

    [NativeName("subPixelInterpolationOffsetBits")]
    public uint SubPixelInterpolationOffsetBits;

    [NativeName("maxFramebufferWidth")]
    public uint MaxFramebufferWidth;

    [NativeName("maxFramebufferHeight")]
    public uint MaxFramebufferHeight;

    [NativeName("maxFramebufferLayers")]
    public uint MaxFramebufferLayers;

    [NativeName("framebufferColorSampleCounts")]
    public SampleCountFlags FramebufferColorSampleCounts;

    [NativeName("framebufferDepthSampleCounts")]
    public SampleCountFlags FramebufferDepthSampleCounts;

    [NativeName("framebufferStencilSampleCounts")]
    public SampleCountFlags FramebufferStencilSampleCounts;

    [NativeName("framebufferNoAttachmentsSampleCounts")]
    public SampleCountFlags FramebufferNoAttachmentsSampleCounts;

    [NativeName("maxColorAttachments")]
    public uint MaxColorAttachments;

    [NativeName("sampledImageColorSampleCounts")]
    public SampleCountFlags SampledImageColorSampleCounts;

    [NativeName("sampledImageIntegerSampleCounts")]
    public SampleCountFlags SampledImageIntegerSampleCounts;

    [NativeName("sampledImageDepthSampleCounts")]
    public SampleCountFlags SampledImageDepthSampleCounts;

    [NativeName("sampledImageStencilSampleCounts")]
    public SampleCountFlags SampledImageStencilSampleCounts;

    [NativeName("storageImageSampleCounts")]
    public SampleCountFlags StorageImageSampleCounts;

    [NativeName("maxSampleMaskWords")]
    public uint MaxSampleMaskWords;

    [NativeName("timestampComputeAndGraphics")]
    public MaybeBool<uint> TimestampComputeAndGraphics;

    [NativeName("timestampPeriod")]
    public float TimestampPeriod;

    [NativeName("maxClipDistances")]
    public uint MaxClipDistances;

    [NativeName("maxCullDistances")]
    public uint MaxCullDistances;

    [NativeName("maxCombinedClipAndCullDistances")]
    public uint MaxCombinedClipAndCullDistances;

    [NativeName("discreteQueuePriorities")]
    public uint DiscreteQueuePriorities;

    [NativeName("pointSizeRange")]
    public PhysicalDeviceLimitsPointSizeRange PointSizeRange;

    [NativeName("lineWidthRange")]
    public PhysicalDeviceLimitsLineWidthRange LineWidthRange;

    [NativeName("pointSizeGranularity")]
    public float PointSizeGranularity;

    [NativeName("lineWidthGranularity")]
    public float LineWidthGranularity;

    [NativeName("strictLines")]
    public MaybeBool<uint> StrictLines;

    [NativeName("standardSampleLocations")]
    public MaybeBool<uint> StandardSampleLocations;

    [NativeName("optimalBufferCopyOffsetAlignment")]
    public ulong OptimalBufferCopyOffsetAlignment;

    [NativeName("optimalBufferCopyRowPitchAlignment")]
    public ulong OptimalBufferCopyRowPitchAlignment;

    [NativeName("nonCoherentAtomSize")]
    public ulong NonCoherentAtomSize;
}
