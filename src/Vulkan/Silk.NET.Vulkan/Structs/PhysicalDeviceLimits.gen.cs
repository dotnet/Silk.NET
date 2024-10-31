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
    [NativeName("Name", "VkPhysicalDeviceLimits")]
    public unsafe partial struct PhysicalDeviceLimits
    {
        public PhysicalDeviceLimits
        (
            uint? maxImageDimension1D = null,
            uint? maxImageDimension2D = null,
            uint? maxImageDimension3D = null,
            uint? maxImageDimensionCube = null,
            uint? maxImageArrayLayers = null,
            uint? maxTexelBufferElements = null,
            uint? maxUniformBufferRange = null,
            uint? maxStorageBufferRange = null,
            uint? maxPushConstantsSize = null,
            uint? maxMemoryAllocationCount = null,
            uint? maxSamplerAllocationCount = null,
            ulong? bufferImageGranularity = null,
            ulong? sparseAddressSpaceSize = null,
            uint? maxBoundDescriptorSets = null,
            uint? maxPerStageDescriptorSamplers = null,
            uint? maxPerStageDescriptorUniformBuffers = null,
            uint? maxPerStageDescriptorStorageBuffers = null,
            uint? maxPerStageDescriptorSampledImages = null,
            uint? maxPerStageDescriptorStorageImages = null,
            uint? maxPerStageDescriptorInputAttachments = null,
            uint? maxPerStageResources = null,
            uint? maxDescriptorSetSamplers = null,
            uint? maxDescriptorSetUniformBuffers = null,
            uint? maxDescriptorSetUniformBuffersDynamic = null,
            uint? maxDescriptorSetStorageBuffers = null,
            uint? maxDescriptorSetStorageBuffersDynamic = null,
            uint? maxDescriptorSetSampledImages = null,
            uint? maxDescriptorSetStorageImages = null,
            uint? maxDescriptorSetInputAttachments = null,
            uint? maxVertexInputAttributes = null,
            uint? maxVertexInputBindings = null,
            uint? maxVertexInputAttributeOffset = null,
            uint? maxVertexInputBindingStride = null,
            uint? maxVertexOutputComponents = null,
            uint? maxTessellationGenerationLevel = null,
            uint? maxTessellationPatchSize = null,
            uint? maxTessellationControlPerVertexInputComponents = null,
            uint? maxTessellationControlPerVertexOutputComponents = null,
            uint? maxTessellationControlPerPatchOutputComponents = null,
            uint? maxTessellationControlTotalOutputComponents = null,
            uint? maxTessellationEvaluationInputComponents = null,
            uint? maxTessellationEvaluationOutputComponents = null,
            uint? maxGeometryShaderInvocations = null,
            uint? maxGeometryInputComponents = null,
            uint? maxGeometryOutputComponents = null,
            uint? maxGeometryOutputVertices = null,
            uint? maxGeometryTotalOutputComponents = null,
            uint? maxFragmentInputComponents = null,
            uint? maxFragmentOutputAttachments = null,
            uint? maxFragmentDualSrcAttachments = null,
            uint? maxFragmentCombinedOutputResources = null,
            uint? maxComputeSharedMemorySize = null,
            uint? maxComputeWorkGroupInvocations = null,
            uint? subPixelPrecisionBits = null,
            uint? subTexelPrecisionBits = null,
            uint? mipmapPrecisionBits = null,
            uint? maxDrawIndexedIndexValue = null,
            uint? maxDrawIndirectCount = null,
            float? maxSamplerLodBias = null,
            float? maxSamplerAnisotropy = null,
            uint? maxViewports = null,
            uint? viewportSubPixelBits = null,
            nuint? minMemoryMapAlignment = null,
            ulong? minTexelBufferOffsetAlignment = null,
            ulong? minUniformBufferOffsetAlignment = null,
            ulong? minStorageBufferOffsetAlignment = null,
            int? minTexelOffset = null,
            uint? maxTexelOffset = null,
            int? minTexelGatherOffset = null,
            uint? maxTexelGatherOffset = null,
            float? minInterpolationOffset = null,
            float? maxInterpolationOffset = null,
            uint? subPixelInterpolationOffsetBits = null,
            uint? maxFramebufferWidth = null,
            uint? maxFramebufferHeight = null,
            uint? maxFramebufferLayers = null,
            SampleCountFlags? framebufferColorSampleCounts = null,
            SampleCountFlags? framebufferDepthSampleCounts = null,
            SampleCountFlags? framebufferStencilSampleCounts = null,
            SampleCountFlags? framebufferNoAttachmentsSampleCounts = null,
            uint? maxColorAttachments = null,
            SampleCountFlags? sampledImageColorSampleCounts = null,
            SampleCountFlags? sampledImageIntegerSampleCounts = null,
            SampleCountFlags? sampledImageDepthSampleCounts = null,
            SampleCountFlags? sampledImageStencilSampleCounts = null,
            SampleCountFlags? storageImageSampleCounts = null,
            uint? maxSampleMaskWords = null,
            Bool32? timestampComputeAndGraphics = null,
            float? timestampPeriod = null,
            uint? maxClipDistances = null,
            uint? maxCullDistances = null,
            uint? maxCombinedClipAndCullDistances = null,
            uint? discreteQueuePriorities = null,
            float? pointSizeGranularity = null,
            float? lineWidthGranularity = null,
            Bool32? strictLines = null,
            Bool32? standardSampleLocations = null,
            ulong? optimalBufferCopyOffsetAlignment = null,
            ulong? optimalBufferCopyRowPitchAlignment = null,
            ulong? nonCoherentAtomSize = null
        ) : this()
        {
            if (maxImageDimension1D is not null)
            {
                MaxImageDimension1D = maxImageDimension1D.Value;
            }

            if (maxImageDimension2D is not null)
            {
                MaxImageDimension2D = maxImageDimension2D.Value;
            }

            if (maxImageDimension3D is not null)
            {
                MaxImageDimension3D = maxImageDimension3D.Value;
            }

            if (maxImageDimensionCube is not null)
            {
                MaxImageDimensionCube = maxImageDimensionCube.Value;
            }

            if (maxImageArrayLayers is not null)
            {
                MaxImageArrayLayers = maxImageArrayLayers.Value;
            }

            if (maxTexelBufferElements is not null)
            {
                MaxTexelBufferElements = maxTexelBufferElements.Value;
            }

            if (maxUniformBufferRange is not null)
            {
                MaxUniformBufferRange = maxUniformBufferRange.Value;
            }

            if (maxStorageBufferRange is not null)
            {
                MaxStorageBufferRange = maxStorageBufferRange.Value;
            }

            if (maxPushConstantsSize is not null)
            {
                MaxPushConstantsSize = maxPushConstantsSize.Value;
            }

            if (maxMemoryAllocationCount is not null)
            {
                MaxMemoryAllocationCount = maxMemoryAllocationCount.Value;
            }

            if (maxSamplerAllocationCount is not null)
            {
                MaxSamplerAllocationCount = maxSamplerAllocationCount.Value;
            }

            if (bufferImageGranularity is not null)
            {
                BufferImageGranularity = bufferImageGranularity.Value;
            }

            if (sparseAddressSpaceSize is not null)
            {
                SparseAddressSpaceSize = sparseAddressSpaceSize.Value;
            }

            if (maxBoundDescriptorSets is not null)
            {
                MaxBoundDescriptorSets = maxBoundDescriptorSets.Value;
            }

            if (maxPerStageDescriptorSamplers is not null)
            {
                MaxPerStageDescriptorSamplers = maxPerStageDescriptorSamplers.Value;
            }

            if (maxPerStageDescriptorUniformBuffers is not null)
            {
                MaxPerStageDescriptorUniformBuffers = maxPerStageDescriptorUniformBuffers.Value;
            }

            if (maxPerStageDescriptorStorageBuffers is not null)
            {
                MaxPerStageDescriptorStorageBuffers = maxPerStageDescriptorStorageBuffers.Value;
            }

            if (maxPerStageDescriptorSampledImages is not null)
            {
                MaxPerStageDescriptorSampledImages = maxPerStageDescriptorSampledImages.Value;
            }

            if (maxPerStageDescriptorStorageImages is not null)
            {
                MaxPerStageDescriptorStorageImages = maxPerStageDescriptorStorageImages.Value;
            }

            if (maxPerStageDescriptorInputAttachments is not null)
            {
                MaxPerStageDescriptorInputAttachments = maxPerStageDescriptorInputAttachments.Value;
            }

            if (maxPerStageResources is not null)
            {
                MaxPerStageResources = maxPerStageResources.Value;
            }

            if (maxDescriptorSetSamplers is not null)
            {
                MaxDescriptorSetSamplers = maxDescriptorSetSamplers.Value;
            }

            if (maxDescriptorSetUniformBuffers is not null)
            {
                MaxDescriptorSetUniformBuffers = maxDescriptorSetUniformBuffers.Value;
            }

            if (maxDescriptorSetUniformBuffersDynamic is not null)
            {
                MaxDescriptorSetUniformBuffersDynamic = maxDescriptorSetUniformBuffersDynamic.Value;
            }

            if (maxDescriptorSetStorageBuffers is not null)
            {
                MaxDescriptorSetStorageBuffers = maxDescriptorSetStorageBuffers.Value;
            }

            if (maxDescriptorSetStorageBuffersDynamic is not null)
            {
                MaxDescriptorSetStorageBuffersDynamic = maxDescriptorSetStorageBuffersDynamic.Value;
            }

            if (maxDescriptorSetSampledImages is not null)
            {
                MaxDescriptorSetSampledImages = maxDescriptorSetSampledImages.Value;
            }

            if (maxDescriptorSetStorageImages is not null)
            {
                MaxDescriptorSetStorageImages = maxDescriptorSetStorageImages.Value;
            }

            if (maxDescriptorSetInputAttachments is not null)
            {
                MaxDescriptorSetInputAttachments = maxDescriptorSetInputAttachments.Value;
            }

            if (maxVertexInputAttributes is not null)
            {
                MaxVertexInputAttributes = maxVertexInputAttributes.Value;
            }

            if (maxVertexInputBindings is not null)
            {
                MaxVertexInputBindings = maxVertexInputBindings.Value;
            }

            if (maxVertexInputAttributeOffset is not null)
            {
                MaxVertexInputAttributeOffset = maxVertexInputAttributeOffset.Value;
            }

            if (maxVertexInputBindingStride is not null)
            {
                MaxVertexInputBindingStride = maxVertexInputBindingStride.Value;
            }

            if (maxVertexOutputComponents is not null)
            {
                MaxVertexOutputComponents = maxVertexOutputComponents.Value;
            }

            if (maxTessellationGenerationLevel is not null)
            {
                MaxTessellationGenerationLevel = maxTessellationGenerationLevel.Value;
            }

            if (maxTessellationPatchSize is not null)
            {
                MaxTessellationPatchSize = maxTessellationPatchSize.Value;
            }

            if (maxTessellationControlPerVertexInputComponents is not null)
            {
                MaxTessellationControlPerVertexInputComponents = maxTessellationControlPerVertexInputComponents.Value;
            }

            if (maxTessellationControlPerVertexOutputComponents is not null)
            {
                MaxTessellationControlPerVertexOutputComponents = maxTessellationControlPerVertexOutputComponents.Value;
            }

            if (maxTessellationControlPerPatchOutputComponents is not null)
            {
                MaxTessellationControlPerPatchOutputComponents = maxTessellationControlPerPatchOutputComponents.Value;
            }

            if (maxTessellationControlTotalOutputComponents is not null)
            {
                MaxTessellationControlTotalOutputComponents = maxTessellationControlTotalOutputComponents.Value;
            }

            if (maxTessellationEvaluationInputComponents is not null)
            {
                MaxTessellationEvaluationInputComponents = maxTessellationEvaluationInputComponents.Value;
            }

            if (maxTessellationEvaluationOutputComponents is not null)
            {
                MaxTessellationEvaluationOutputComponents = maxTessellationEvaluationOutputComponents.Value;
            }

            if (maxGeometryShaderInvocations is not null)
            {
                MaxGeometryShaderInvocations = maxGeometryShaderInvocations.Value;
            }

            if (maxGeometryInputComponents is not null)
            {
                MaxGeometryInputComponents = maxGeometryInputComponents.Value;
            }

            if (maxGeometryOutputComponents is not null)
            {
                MaxGeometryOutputComponents = maxGeometryOutputComponents.Value;
            }

            if (maxGeometryOutputVertices is not null)
            {
                MaxGeometryOutputVertices = maxGeometryOutputVertices.Value;
            }

            if (maxGeometryTotalOutputComponents is not null)
            {
                MaxGeometryTotalOutputComponents = maxGeometryTotalOutputComponents.Value;
            }

            if (maxFragmentInputComponents is not null)
            {
                MaxFragmentInputComponents = maxFragmentInputComponents.Value;
            }

            if (maxFragmentOutputAttachments is not null)
            {
                MaxFragmentOutputAttachments = maxFragmentOutputAttachments.Value;
            }

            if (maxFragmentDualSrcAttachments is not null)
            {
                MaxFragmentDualSrcAttachments = maxFragmentDualSrcAttachments.Value;
            }

            if (maxFragmentCombinedOutputResources is not null)
            {
                MaxFragmentCombinedOutputResources = maxFragmentCombinedOutputResources.Value;
            }

            if (maxComputeSharedMemorySize is not null)
            {
                MaxComputeSharedMemorySize = maxComputeSharedMemorySize.Value;
            }

            if (maxComputeWorkGroupInvocations is not null)
            {
                MaxComputeWorkGroupInvocations = maxComputeWorkGroupInvocations.Value;
            }

            if (subPixelPrecisionBits is not null)
            {
                SubPixelPrecisionBits = subPixelPrecisionBits.Value;
            }

            if (subTexelPrecisionBits is not null)
            {
                SubTexelPrecisionBits = subTexelPrecisionBits.Value;
            }

            if (mipmapPrecisionBits is not null)
            {
                MipmapPrecisionBits = mipmapPrecisionBits.Value;
            }

            if (maxDrawIndexedIndexValue is not null)
            {
                MaxDrawIndexedIndexValue = maxDrawIndexedIndexValue.Value;
            }

            if (maxDrawIndirectCount is not null)
            {
                MaxDrawIndirectCount = maxDrawIndirectCount.Value;
            }

            if (maxSamplerLodBias is not null)
            {
                MaxSamplerLodBias = maxSamplerLodBias.Value;
            }

            if (maxSamplerAnisotropy is not null)
            {
                MaxSamplerAnisotropy = maxSamplerAnisotropy.Value;
            }

            if (maxViewports is not null)
            {
                MaxViewports = maxViewports.Value;
            }

            if (viewportSubPixelBits is not null)
            {
                ViewportSubPixelBits = viewportSubPixelBits.Value;
            }

            if (minMemoryMapAlignment is not null)
            {
                MinMemoryMapAlignment = minMemoryMapAlignment.Value;
            }

            if (minTexelBufferOffsetAlignment is not null)
            {
                MinTexelBufferOffsetAlignment = minTexelBufferOffsetAlignment.Value;
            }

            if (minUniformBufferOffsetAlignment is not null)
            {
                MinUniformBufferOffsetAlignment = minUniformBufferOffsetAlignment.Value;
            }

            if (minStorageBufferOffsetAlignment is not null)
            {
                MinStorageBufferOffsetAlignment = minStorageBufferOffsetAlignment.Value;
            }

            if (minTexelOffset is not null)
            {
                MinTexelOffset = minTexelOffset.Value;
            }

            if (maxTexelOffset is not null)
            {
                MaxTexelOffset = maxTexelOffset.Value;
            }

            if (minTexelGatherOffset is not null)
            {
                MinTexelGatherOffset = minTexelGatherOffset.Value;
            }

            if (maxTexelGatherOffset is not null)
            {
                MaxTexelGatherOffset = maxTexelGatherOffset.Value;
            }

            if (minInterpolationOffset is not null)
            {
                MinInterpolationOffset = minInterpolationOffset.Value;
            }

            if (maxInterpolationOffset is not null)
            {
                MaxInterpolationOffset = maxInterpolationOffset.Value;
            }

            if (subPixelInterpolationOffsetBits is not null)
            {
                SubPixelInterpolationOffsetBits = subPixelInterpolationOffsetBits.Value;
            }

            if (maxFramebufferWidth is not null)
            {
                MaxFramebufferWidth = maxFramebufferWidth.Value;
            }

            if (maxFramebufferHeight is not null)
            {
                MaxFramebufferHeight = maxFramebufferHeight.Value;
            }

            if (maxFramebufferLayers is not null)
            {
                MaxFramebufferLayers = maxFramebufferLayers.Value;
            }

            if (framebufferColorSampleCounts is not null)
            {
                FramebufferColorSampleCounts = framebufferColorSampleCounts.Value;
            }

            if (framebufferDepthSampleCounts is not null)
            {
                FramebufferDepthSampleCounts = framebufferDepthSampleCounts.Value;
            }

            if (framebufferStencilSampleCounts is not null)
            {
                FramebufferStencilSampleCounts = framebufferStencilSampleCounts.Value;
            }

            if (framebufferNoAttachmentsSampleCounts is not null)
            {
                FramebufferNoAttachmentsSampleCounts = framebufferNoAttachmentsSampleCounts.Value;
            }

            if (maxColorAttachments is not null)
            {
                MaxColorAttachments = maxColorAttachments.Value;
            }

            if (sampledImageColorSampleCounts is not null)
            {
                SampledImageColorSampleCounts = sampledImageColorSampleCounts.Value;
            }

            if (sampledImageIntegerSampleCounts is not null)
            {
                SampledImageIntegerSampleCounts = sampledImageIntegerSampleCounts.Value;
            }

            if (sampledImageDepthSampleCounts is not null)
            {
                SampledImageDepthSampleCounts = sampledImageDepthSampleCounts.Value;
            }

            if (sampledImageStencilSampleCounts is not null)
            {
                SampledImageStencilSampleCounts = sampledImageStencilSampleCounts.Value;
            }

            if (storageImageSampleCounts is not null)
            {
                StorageImageSampleCounts = storageImageSampleCounts.Value;
            }

            if (maxSampleMaskWords is not null)
            {
                MaxSampleMaskWords = maxSampleMaskWords.Value;
            }

            if (timestampComputeAndGraphics is not null)
            {
                TimestampComputeAndGraphics = timestampComputeAndGraphics.Value;
            }

            if (timestampPeriod is not null)
            {
                TimestampPeriod = timestampPeriod.Value;
            }

            if (maxClipDistances is not null)
            {
                MaxClipDistances = maxClipDistances.Value;
            }

            if (maxCullDistances is not null)
            {
                MaxCullDistances = maxCullDistances.Value;
            }

            if (maxCombinedClipAndCullDistances is not null)
            {
                MaxCombinedClipAndCullDistances = maxCombinedClipAndCullDistances.Value;
            }

            if (discreteQueuePriorities is not null)
            {
                DiscreteQueuePriorities = discreteQueuePriorities.Value;
            }

            if (pointSizeGranularity is not null)
            {
                PointSizeGranularity = pointSizeGranularity.Value;
            }

            if (lineWidthGranularity is not null)
            {
                LineWidthGranularity = lineWidthGranularity.Value;
            }

            if (strictLines is not null)
            {
                StrictLines = strictLines.Value;
            }

            if (standardSampleLocations is not null)
            {
                StandardSampleLocations = standardSampleLocations.Value;
            }

            if (optimalBufferCopyOffsetAlignment is not null)
            {
                OptimalBufferCopyOffsetAlignment = optimalBufferCopyOffsetAlignment.Value;
            }

            if (optimalBufferCopyRowPitchAlignment is not null)
            {
                OptimalBufferCopyRowPitchAlignment = optimalBufferCopyRowPitchAlignment.Value;
            }

            if (nonCoherentAtomSize is not null)
            {
                NonCoherentAtomSize = nonCoherentAtomSize.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxImageDimension1D")]
        public uint MaxImageDimension1D;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxImageDimension2D")]
        public uint MaxImageDimension2D;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxImageDimension3D")]
        public uint MaxImageDimension3D;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxImageDimensionCube")]
        public uint MaxImageDimensionCube;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxImageArrayLayers")]
        public uint MaxImageArrayLayers;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxTexelBufferElements")]
        public uint MaxTexelBufferElements;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxUniformBufferRange")]
        public uint MaxUniformBufferRange;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxStorageBufferRange")]
        public uint MaxStorageBufferRange;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPushConstantsSize")]
        public uint MaxPushConstantsSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxMemoryAllocationCount")]
        public uint MaxMemoryAllocationCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxSamplerAllocationCount")]
        public uint MaxSamplerAllocationCount;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "bufferImageGranularity")]
        public ulong BufferImageGranularity;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "sparseAddressSpaceSize")]
        public ulong SparseAddressSpaceSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxBoundDescriptorSets")]
        public uint MaxBoundDescriptorSets;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPerStageDescriptorSamplers")]
        public uint MaxPerStageDescriptorSamplers;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPerStageDescriptorUniformBuffers")]
        public uint MaxPerStageDescriptorUniformBuffers;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPerStageDescriptorStorageBuffers")]
        public uint MaxPerStageDescriptorStorageBuffers;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPerStageDescriptorSampledImages")]
        public uint MaxPerStageDescriptorSampledImages;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPerStageDescriptorStorageImages")]
        public uint MaxPerStageDescriptorStorageImages;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPerStageDescriptorInputAttachments")]
        public uint MaxPerStageDescriptorInputAttachments;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPerStageResources")]
        public uint MaxPerStageResources;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorSetSamplers")]
        public uint MaxDescriptorSetSamplers;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorSetUniformBuffers")]
        public uint MaxDescriptorSetUniformBuffers;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorSetUniformBuffersDynamic")]
        public uint MaxDescriptorSetUniformBuffersDynamic;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorSetStorageBuffers")]
        public uint MaxDescriptorSetStorageBuffers;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorSetStorageBuffersDynamic")]
        public uint MaxDescriptorSetStorageBuffersDynamic;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorSetSampledImages")]
        public uint MaxDescriptorSetSampledImages;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorSetStorageImages")]
        public uint MaxDescriptorSetStorageImages;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorSetInputAttachments")]
        public uint MaxDescriptorSetInputAttachments;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxVertexInputAttributes")]
        public uint MaxVertexInputAttributes;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxVertexInputBindings")]
        public uint MaxVertexInputBindings;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxVertexInputAttributeOffset")]
        public uint MaxVertexInputAttributeOffset;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxVertexInputBindingStride")]
        public uint MaxVertexInputBindingStride;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxVertexOutputComponents")]
        public uint MaxVertexOutputComponents;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxTessellationGenerationLevel")]
        public uint MaxTessellationGenerationLevel;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxTessellationPatchSize")]
        public uint MaxTessellationPatchSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxTessellationControlPerVertexInputComponents")]
        public uint MaxTessellationControlPerVertexInputComponents;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxTessellationControlPerVertexOutputComponents")]
        public uint MaxTessellationControlPerVertexOutputComponents;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxTessellationControlPerPatchOutputComponents")]
        public uint MaxTessellationControlPerPatchOutputComponents;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxTessellationControlTotalOutputComponents")]
        public uint MaxTessellationControlTotalOutputComponents;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxTessellationEvaluationInputComponents")]
        public uint MaxTessellationEvaluationInputComponents;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxTessellationEvaluationOutputComponents")]
        public uint MaxTessellationEvaluationOutputComponents;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxGeometryShaderInvocations")]
        public uint MaxGeometryShaderInvocations;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxGeometryInputComponents")]
        public uint MaxGeometryInputComponents;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxGeometryOutputComponents")]
        public uint MaxGeometryOutputComponents;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxGeometryOutputVertices")]
        public uint MaxGeometryOutputVertices;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxGeometryTotalOutputComponents")]
        public uint MaxGeometryTotalOutputComponents;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxFragmentInputComponents")]
        public uint MaxFragmentInputComponents;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxFragmentOutputAttachments")]
        public uint MaxFragmentOutputAttachments;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxFragmentDualSrcAttachments")]
        public uint MaxFragmentDualSrcAttachments;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxFragmentCombinedOutputResources")]
        public uint MaxFragmentCombinedOutputResources;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxComputeSharedMemorySize")]
        public uint MaxComputeSharedMemorySize;
        /// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxComputeWorkGroupCount")]
        public fixed uint MaxComputeWorkGroupCount[3];
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxComputeWorkGroupInvocations")]
        public uint MaxComputeWorkGroupInvocations;
        /// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxComputeWorkGroupSize")]
        public fixed uint MaxComputeWorkGroupSize[3];
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "subPixelPrecisionBits")]
        public uint SubPixelPrecisionBits;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "subTexelPrecisionBits")]
        public uint SubTexelPrecisionBits;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "mipmapPrecisionBits")]
        public uint MipmapPrecisionBits;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDrawIndexedIndexValue")]
        public uint MaxDrawIndexedIndexValue;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDrawIndirectCount")]
        public uint MaxDrawIndirectCount;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "maxSamplerLodBias")]
        public float MaxSamplerLodBias;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "maxSamplerAnisotropy")]
        public float MaxSamplerAnisotropy;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxViewports")]
        public uint MaxViewports;
        /// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxViewportDimensions")]
        public fixed uint MaxViewportDimensions[2];
        /// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "viewportBoundsRange")]
        public fixed float ViewportBoundsRange[2];
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "viewportSubPixelBits")]
        public uint ViewportSubPixelBits;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "minMemoryMapAlignment")]
        public nuint MinMemoryMapAlignment;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "minTexelBufferOffsetAlignment")]
        public ulong MinTexelBufferOffsetAlignment;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "minUniformBufferOffsetAlignment")]
        public ulong MinUniformBufferOffsetAlignment;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "minStorageBufferOffsetAlignment")]
        public ulong MinStorageBufferOffsetAlignment;
/// <summary></summary>
        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "minTexelOffset")]
        public int MinTexelOffset;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxTexelOffset")]
        public uint MaxTexelOffset;
/// <summary></summary>
        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "minTexelGatherOffset")]
        public int MinTexelGatherOffset;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxTexelGatherOffset")]
        public uint MaxTexelGatherOffset;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "minInterpolationOffset")]
        public float MinInterpolationOffset;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "maxInterpolationOffset")]
        public float MaxInterpolationOffset;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "subPixelInterpolationOffsetBits")]
        public uint SubPixelInterpolationOffsetBits;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxFramebufferWidth")]
        public uint MaxFramebufferWidth;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxFramebufferHeight")]
        public uint MaxFramebufferHeight;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxFramebufferLayers")]
        public uint MaxFramebufferLayers;
/// <summary></summary>
        [NativeName("Type", "VkSampleCountFlags")]
        [NativeName("Type.Name", "VkSampleCountFlags")]
        [NativeName("Name", "framebufferColorSampleCounts")]
        public SampleCountFlags FramebufferColorSampleCounts;
/// <summary></summary>
        [NativeName("Type", "VkSampleCountFlags")]
        [NativeName("Type.Name", "VkSampleCountFlags")]
        [NativeName("Name", "framebufferDepthSampleCounts")]
        public SampleCountFlags FramebufferDepthSampleCounts;
/// <summary></summary>
        [NativeName("Type", "VkSampleCountFlags")]
        [NativeName("Type.Name", "VkSampleCountFlags")]
        [NativeName("Name", "framebufferStencilSampleCounts")]
        public SampleCountFlags FramebufferStencilSampleCounts;
/// <summary></summary>
        [NativeName("Type", "VkSampleCountFlags")]
        [NativeName("Type.Name", "VkSampleCountFlags")]
        [NativeName("Name", "framebufferNoAttachmentsSampleCounts")]
        public SampleCountFlags FramebufferNoAttachmentsSampleCounts;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxColorAttachments")]
        public uint MaxColorAttachments;
/// <summary></summary>
        [NativeName("Type", "VkSampleCountFlags")]
        [NativeName("Type.Name", "VkSampleCountFlags")]
        [NativeName("Name", "sampledImageColorSampleCounts")]
        public SampleCountFlags SampledImageColorSampleCounts;
/// <summary></summary>
        [NativeName("Type", "VkSampleCountFlags")]
        [NativeName("Type.Name", "VkSampleCountFlags")]
        [NativeName("Name", "sampledImageIntegerSampleCounts")]
        public SampleCountFlags SampledImageIntegerSampleCounts;
/// <summary></summary>
        [NativeName("Type", "VkSampleCountFlags")]
        [NativeName("Type.Name", "VkSampleCountFlags")]
        [NativeName("Name", "sampledImageDepthSampleCounts")]
        public SampleCountFlags SampledImageDepthSampleCounts;
/// <summary></summary>
        [NativeName("Type", "VkSampleCountFlags")]
        [NativeName("Type.Name", "VkSampleCountFlags")]
        [NativeName("Name", "sampledImageStencilSampleCounts")]
        public SampleCountFlags SampledImageStencilSampleCounts;
/// <summary></summary>
        [NativeName("Type", "VkSampleCountFlags")]
        [NativeName("Type.Name", "VkSampleCountFlags")]
        [NativeName("Name", "storageImageSampleCounts")]
        public SampleCountFlags StorageImageSampleCounts;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxSampleMaskWords")]
        public uint MaxSampleMaskWords;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "timestampComputeAndGraphics")]
        public Bool32 TimestampComputeAndGraphics;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "timestampPeriod")]
        public float TimestampPeriod;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxClipDistances")]
        public uint MaxClipDistances;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxCullDistances")]
        public uint MaxCullDistances;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxCombinedClipAndCullDistances")]
        public uint MaxCombinedClipAndCullDistances;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "discreteQueuePriorities")]
        public uint DiscreteQueuePriorities;
        /// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "pointSizeRange")]
        public fixed float PointSizeRange[2];
        /// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "lineWidthRange")]
        public fixed float LineWidthRange[2];
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "pointSizeGranularity")]
        public float PointSizeGranularity;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "lineWidthGranularity")]
        public float LineWidthGranularity;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "strictLines")]
        public Bool32 StrictLines;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "standardSampleLocations")]
        public Bool32 StandardSampleLocations;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "optimalBufferCopyOffsetAlignment")]
        public ulong OptimalBufferCopyOffsetAlignment;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "optimalBufferCopyRowPitchAlignment")]
        public ulong OptimalBufferCopyRowPitchAlignment;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "nonCoherentAtomSize")]
        public ulong NonCoherentAtomSize;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
