// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe struct PhysicalDeviceLimits
    {
        public PhysicalDeviceLimits
        (
            uint maxImageDimension1D = default,
            uint maxImageDimension2D = default,
            uint maxImageDimension3D = default,
            uint maxImageDimensionCube = default,
            uint maxImageArrayLayers = default,
            uint maxTexelBufferElements = default,
            uint maxUniformBufferRange = default,
            uint maxStorageBufferRange = default,
            uint maxPushConstantsSize = default,
            uint maxMemoryAllocationCount = default,
            uint maxSamplerAllocationCount = default,
            ulong bufferImageGranularity = default,
            ulong sparseAddressSpaceSize = default,
            uint maxBoundDescriptorSets = default,
            uint maxPerStageDescriptorSamplers = default,
            uint maxPerStageDescriptorUniformBuffers = default,
            uint maxPerStageDescriptorStorageBuffers = default,
            uint maxPerStageDescriptorSampledImages = default,
            uint maxPerStageDescriptorStorageImages = default,
            uint maxPerStageDescriptorInputAttachments = default,
            uint maxPerStageResources = default,
            uint maxDescriptorSetSamplers = default,
            uint maxDescriptorSetUniformBuffers = default,
            uint maxDescriptorSetUniformBuffersDynamic = default,
            uint maxDescriptorSetStorageBuffers = default,
            uint maxDescriptorSetStorageBuffersDynamic = default,
            uint maxDescriptorSetSampledImages = default,
            uint maxDescriptorSetStorageImages = default,
            uint maxDescriptorSetInputAttachments = default,
            uint maxVertexInputAttributes = default,
            uint maxVertexInputBindings = default,
            uint maxVertexInputAttributeOffset = default,
            uint maxVertexInputBindingStride = default,
            uint maxVertexOutputComponents = default,
            uint maxTessellationGenerationLevel = default,
            uint maxTessellationPatchSize = default,
            uint maxTessellationControlPerVertexInputComponents = default,
            uint maxTessellationControlPerVertexOutputComponents = default,
            uint maxTessellationControlPerPatchOutputComponents = default,
            uint maxTessellationControlTotalOutputComponents = default,
            uint maxTessellationEvaluationInputComponents = default,
            uint maxTessellationEvaluationOutputComponents = default,
            uint maxGeometryShaderInvocations = default,
            uint maxGeometryInputComponents = default,
            uint maxGeometryOutputComponents = default,
            uint maxGeometryOutputVertices = default,
            uint maxGeometryTotalOutputComponents = default,
            uint maxFragmentInputComponents = default,
            uint maxFragmentOutputAttachments = default,
            uint maxFragmentDualSrcAttachments = default,
            uint maxFragmentCombinedOutputResources = default,
            uint maxComputeSharedMemorySize = default,
            uint maxComputeWorkGroupInvocations = default,
            uint subPixelPrecisionBits = default,
            uint subTexelPrecisionBits = default,
            uint mipmapPrecisionBits = default,
            uint maxDrawIndexedIndexValue = default,
            uint maxDrawIndirectCount = default,
            float maxSamplerLodBias = default,
            float maxSamplerAnisotropy = default,
            uint maxViewports = default,
            uint viewportSubPixelBits = default,
            UIntPtr minMemoryMapAlignment = default,
            ulong minTexelBufferOffsetAlignment = default,
            ulong minUniformBufferOffsetAlignment = default,
            ulong minStorageBufferOffsetAlignment = default,
            int minTexelOffset = default,
            uint maxTexelOffset = default,
            int minTexelGatherOffset = default,
            uint maxTexelGatherOffset = default,
            float minInterpolationOffset = default,
            float maxInterpolationOffset = default,
            uint subPixelInterpolationOffsetBits = default,
            uint maxFramebufferWidth = default,
            uint maxFramebufferHeight = default,
            uint maxFramebufferLayers = default,
            SampleCountFlags framebufferColorSampleCounts = default,
            SampleCountFlags framebufferDepthSampleCounts = default,
            SampleCountFlags framebufferStencilSampleCounts = default,
            SampleCountFlags framebufferNoAttachmentsSampleCounts = default,
            uint maxColorAttachments = default,
            SampleCountFlags sampledImageColorSampleCounts = default,
            SampleCountFlags sampledImageIntegerSampleCounts = default,
            SampleCountFlags sampledImageDepthSampleCounts = default,
            SampleCountFlags sampledImageStencilSampleCounts = default,
            SampleCountFlags storageImageSampleCounts = default,
            uint maxSampleMaskWords = default,
            Bool32 timestampComputeAndGraphics = default,
            float timestampPeriod = default,
            uint maxClipDistances = default,
            uint maxCullDistances = default,
            uint maxCombinedClipAndCullDistances = default,
            uint discreteQueuePriorities = default,
            float pointSizeGranularity = default,
            float lineWidthGranularity = default,
            Bool32 strictLines = default,
            Bool32 standardSampleLocations = default,
            ulong optimalBufferCopyOffsetAlignment = default,
            ulong optimalBufferCopyRowPitchAlignment = default,
            ulong nonCoherentAtomSize = default
        )
        {
           MaxImageDimension1D = maxImageDimension1D;
           MaxImageDimension2D = maxImageDimension2D;
           MaxImageDimension3D = maxImageDimension3D;
           MaxImageDimensionCube = maxImageDimensionCube;
           MaxImageArrayLayers = maxImageArrayLayers;
           MaxTexelBufferElements = maxTexelBufferElements;
           MaxUniformBufferRange = maxUniformBufferRange;
           MaxStorageBufferRange = maxStorageBufferRange;
           MaxPushConstantsSize = maxPushConstantsSize;
           MaxMemoryAllocationCount = maxMemoryAllocationCount;
           MaxSamplerAllocationCount = maxSamplerAllocationCount;
           BufferImageGranularity = bufferImageGranularity;
           SparseAddressSpaceSize = sparseAddressSpaceSize;
           MaxBoundDescriptorSets = maxBoundDescriptorSets;
           MaxPerStageDescriptorSamplers = maxPerStageDescriptorSamplers;
           MaxPerStageDescriptorUniformBuffers = maxPerStageDescriptorUniformBuffers;
           MaxPerStageDescriptorStorageBuffers = maxPerStageDescriptorStorageBuffers;
           MaxPerStageDescriptorSampledImages = maxPerStageDescriptorSampledImages;
           MaxPerStageDescriptorStorageImages = maxPerStageDescriptorStorageImages;
           MaxPerStageDescriptorInputAttachments = maxPerStageDescriptorInputAttachments;
           MaxPerStageResources = maxPerStageResources;
           MaxDescriptorSetSamplers = maxDescriptorSetSamplers;
           MaxDescriptorSetUniformBuffers = maxDescriptorSetUniformBuffers;
           MaxDescriptorSetUniformBuffersDynamic = maxDescriptorSetUniformBuffersDynamic;
           MaxDescriptorSetStorageBuffers = maxDescriptorSetStorageBuffers;
           MaxDescriptorSetStorageBuffersDynamic = maxDescriptorSetStorageBuffersDynamic;
           MaxDescriptorSetSampledImages = maxDescriptorSetSampledImages;
           MaxDescriptorSetStorageImages = maxDescriptorSetStorageImages;
           MaxDescriptorSetInputAttachments = maxDescriptorSetInputAttachments;
           MaxVertexInputAttributes = maxVertexInputAttributes;
           MaxVertexInputBindings = maxVertexInputBindings;
           MaxVertexInputAttributeOffset = maxVertexInputAttributeOffset;
           MaxVertexInputBindingStride = maxVertexInputBindingStride;
           MaxVertexOutputComponents = maxVertexOutputComponents;
           MaxTessellationGenerationLevel = maxTessellationGenerationLevel;
           MaxTessellationPatchSize = maxTessellationPatchSize;
           MaxTessellationControlPerVertexInputComponents = maxTessellationControlPerVertexInputComponents;
           MaxTessellationControlPerVertexOutputComponents = maxTessellationControlPerVertexOutputComponents;
           MaxTessellationControlPerPatchOutputComponents = maxTessellationControlPerPatchOutputComponents;
           MaxTessellationControlTotalOutputComponents = maxTessellationControlTotalOutputComponents;
           MaxTessellationEvaluationInputComponents = maxTessellationEvaluationInputComponents;
           MaxTessellationEvaluationOutputComponents = maxTessellationEvaluationOutputComponents;
           MaxGeometryShaderInvocations = maxGeometryShaderInvocations;
           MaxGeometryInputComponents = maxGeometryInputComponents;
           MaxGeometryOutputComponents = maxGeometryOutputComponents;
           MaxGeometryOutputVertices = maxGeometryOutputVertices;
           MaxGeometryTotalOutputComponents = maxGeometryTotalOutputComponents;
           MaxFragmentInputComponents = maxFragmentInputComponents;
           MaxFragmentOutputAttachments = maxFragmentOutputAttachments;
           MaxFragmentDualSrcAttachments = maxFragmentDualSrcAttachments;
           MaxFragmentCombinedOutputResources = maxFragmentCombinedOutputResources;
           MaxComputeSharedMemorySize = maxComputeSharedMemorySize;
           MaxComputeWorkGroupInvocations = maxComputeWorkGroupInvocations;
           SubPixelPrecisionBits = subPixelPrecisionBits;
           SubTexelPrecisionBits = subTexelPrecisionBits;
           MipmapPrecisionBits = mipmapPrecisionBits;
           MaxDrawIndexedIndexValue = maxDrawIndexedIndexValue;
           MaxDrawIndirectCount = maxDrawIndirectCount;
           MaxSamplerLodBias = maxSamplerLodBias;
           MaxSamplerAnisotropy = maxSamplerAnisotropy;
           MaxViewports = maxViewports;
           ViewportSubPixelBits = viewportSubPixelBits;
           MinMemoryMapAlignment = minMemoryMapAlignment;
           MinTexelBufferOffsetAlignment = minTexelBufferOffsetAlignment;
           MinUniformBufferOffsetAlignment = minUniformBufferOffsetAlignment;
           MinStorageBufferOffsetAlignment = minStorageBufferOffsetAlignment;
           MinTexelOffset = minTexelOffset;
           MaxTexelOffset = maxTexelOffset;
           MinTexelGatherOffset = minTexelGatherOffset;
           MaxTexelGatherOffset = maxTexelGatherOffset;
           MinInterpolationOffset = minInterpolationOffset;
           MaxInterpolationOffset = maxInterpolationOffset;
           SubPixelInterpolationOffsetBits = subPixelInterpolationOffsetBits;
           MaxFramebufferWidth = maxFramebufferWidth;
           MaxFramebufferHeight = maxFramebufferHeight;
           MaxFramebufferLayers = maxFramebufferLayers;
           FramebufferColorSampleCounts = framebufferColorSampleCounts;
           FramebufferDepthSampleCounts = framebufferDepthSampleCounts;
           FramebufferStencilSampleCounts = framebufferStencilSampleCounts;
           FramebufferNoAttachmentsSampleCounts = framebufferNoAttachmentsSampleCounts;
           MaxColorAttachments = maxColorAttachments;
           SampledImageColorSampleCounts = sampledImageColorSampleCounts;
           SampledImageIntegerSampleCounts = sampledImageIntegerSampleCounts;
           SampledImageDepthSampleCounts = sampledImageDepthSampleCounts;
           SampledImageStencilSampleCounts = sampledImageStencilSampleCounts;
           StorageImageSampleCounts = storageImageSampleCounts;
           MaxSampleMaskWords = maxSampleMaskWords;
           TimestampComputeAndGraphics = timestampComputeAndGraphics;
           TimestampPeriod = timestampPeriod;
           MaxClipDistances = maxClipDistances;
           MaxCullDistances = maxCullDistances;
           MaxCombinedClipAndCullDistances = maxCombinedClipAndCullDistances;
           DiscreteQueuePriorities = discreteQueuePriorities;
           PointSizeGranularity = pointSizeGranularity;
           LineWidthGranularity = lineWidthGranularity;
           StrictLines = strictLines;
           StandardSampleLocations = standardSampleLocations;
           OptimalBufferCopyOffsetAlignment = optimalBufferCopyOffsetAlignment;
           OptimalBufferCopyRowPitchAlignment = optimalBufferCopyRowPitchAlignment;
           NonCoherentAtomSize = nonCoherentAtomSize;
        }

/// <summary></summary>
        public uint MaxImageDimension1D;
/// <summary></summary>
        public uint MaxImageDimension2D;
/// <summary></summary>
        public uint MaxImageDimension3D;
/// <summary></summary>
        public uint MaxImageDimensionCube;
/// <summary></summary>
        public uint MaxImageArrayLayers;
/// <summary></summary>
        public uint MaxTexelBufferElements;
/// <summary></summary>
        public uint MaxUniformBufferRange;
/// <summary></summary>
        public uint MaxStorageBufferRange;
/// <summary></summary>
        public uint MaxPushConstantsSize;
/// <summary></summary>
        public uint MaxMemoryAllocationCount;
/// <summary></summary>
        public uint MaxSamplerAllocationCount;
/// <summary></summary>
        public ulong BufferImageGranularity;
/// <summary></summary>
        public ulong SparseAddressSpaceSize;
/// <summary></summary>
        public uint MaxBoundDescriptorSets;
/// <summary></summary>
        public uint MaxPerStageDescriptorSamplers;
/// <summary></summary>
        public uint MaxPerStageDescriptorUniformBuffers;
/// <summary></summary>
        public uint MaxPerStageDescriptorStorageBuffers;
/// <summary></summary>
        public uint MaxPerStageDescriptorSampledImages;
/// <summary></summary>
        public uint MaxPerStageDescriptorStorageImages;
/// <summary></summary>
        public uint MaxPerStageDescriptorInputAttachments;
/// <summary></summary>
        public uint MaxPerStageResources;
/// <summary></summary>
        public uint MaxDescriptorSetSamplers;
/// <summary></summary>
        public uint MaxDescriptorSetUniformBuffers;
/// <summary></summary>
        public uint MaxDescriptorSetUniformBuffersDynamic;
/// <summary></summary>
        public uint MaxDescriptorSetStorageBuffers;
/// <summary></summary>
        public uint MaxDescriptorSetStorageBuffersDynamic;
/// <summary></summary>
        public uint MaxDescriptorSetSampledImages;
/// <summary></summary>
        public uint MaxDescriptorSetStorageImages;
/// <summary></summary>
        public uint MaxDescriptorSetInputAttachments;
/// <summary></summary>
        public uint MaxVertexInputAttributes;
/// <summary></summary>
        public uint MaxVertexInputBindings;
/// <summary></summary>
        public uint MaxVertexInputAttributeOffset;
/// <summary></summary>
        public uint MaxVertexInputBindingStride;
/// <summary></summary>
        public uint MaxVertexOutputComponents;
/// <summary></summary>
        public uint MaxTessellationGenerationLevel;
/// <summary></summary>
        public uint MaxTessellationPatchSize;
/// <summary></summary>
        public uint MaxTessellationControlPerVertexInputComponents;
/// <summary></summary>
        public uint MaxTessellationControlPerVertexOutputComponents;
/// <summary></summary>
        public uint MaxTessellationControlPerPatchOutputComponents;
/// <summary></summary>
        public uint MaxTessellationControlTotalOutputComponents;
/// <summary></summary>
        public uint MaxTessellationEvaluationInputComponents;
/// <summary></summary>
        public uint MaxTessellationEvaluationOutputComponents;
/// <summary></summary>
        public uint MaxGeometryShaderInvocations;
/// <summary></summary>
        public uint MaxGeometryInputComponents;
/// <summary></summary>
        public uint MaxGeometryOutputComponents;
/// <summary></summary>
        public uint MaxGeometryOutputVertices;
/// <summary></summary>
        public uint MaxGeometryTotalOutputComponents;
/// <summary></summary>
        public uint MaxFragmentInputComponents;
/// <summary></summary>
        public uint MaxFragmentOutputAttachments;
/// <summary></summary>
        public uint MaxFragmentDualSrcAttachments;
/// <summary></summary>
        public uint MaxFragmentCombinedOutputResources;
/// <summary></summary>
        public uint MaxComputeSharedMemorySize;
        /// <summary></summary>
       public fixed uint MaxComputeWorkGroupCount[3];
/// <summary></summary>
        public uint MaxComputeWorkGroupInvocations;
        /// <summary></summary>
       public fixed uint MaxComputeWorkGroupSize[3];
/// <summary></summary>
        public uint SubPixelPrecisionBits;
/// <summary></summary>
        public uint SubTexelPrecisionBits;
/// <summary></summary>
        public uint MipmapPrecisionBits;
/// <summary></summary>
        public uint MaxDrawIndexedIndexValue;
/// <summary></summary>
        public uint MaxDrawIndirectCount;
/// <summary></summary>
        public float MaxSamplerLodBias;
/// <summary></summary>
        public float MaxSamplerAnisotropy;
/// <summary></summary>
        public uint MaxViewports;
        /// <summary></summary>
       public fixed uint MaxViewportDimensions[2];
        /// <summary></summary>
       public fixed float ViewportBoundsRange[2];
/// <summary></summary>
        public uint ViewportSubPixelBits;
/// <summary></summary>
        public UIntPtr MinMemoryMapAlignment;
/// <summary></summary>
        public ulong MinTexelBufferOffsetAlignment;
/// <summary></summary>
        public ulong MinUniformBufferOffsetAlignment;
/// <summary></summary>
        public ulong MinStorageBufferOffsetAlignment;
/// <summary></summary>
        public int MinTexelOffset;
/// <summary></summary>
        public uint MaxTexelOffset;
/// <summary></summary>
        public int MinTexelGatherOffset;
/// <summary></summary>
        public uint MaxTexelGatherOffset;
/// <summary></summary>
        public float MinInterpolationOffset;
/// <summary></summary>
        public float MaxInterpolationOffset;
/// <summary></summary>
        public uint SubPixelInterpolationOffsetBits;
/// <summary></summary>
        public uint MaxFramebufferWidth;
/// <summary></summary>
        public uint MaxFramebufferHeight;
/// <summary></summary>
        public uint MaxFramebufferLayers;
/// <summary></summary>
        public SampleCountFlags FramebufferColorSampleCounts;
/// <summary></summary>
        public SampleCountFlags FramebufferDepthSampleCounts;
/// <summary></summary>
        public SampleCountFlags FramebufferStencilSampleCounts;
/// <summary></summary>
        public SampleCountFlags FramebufferNoAttachmentsSampleCounts;
/// <summary></summary>
        public uint MaxColorAttachments;
/// <summary></summary>
        public SampleCountFlags SampledImageColorSampleCounts;
/// <summary></summary>
        public SampleCountFlags SampledImageIntegerSampleCounts;
/// <summary></summary>
        public SampleCountFlags SampledImageDepthSampleCounts;
/// <summary></summary>
        public SampleCountFlags SampledImageStencilSampleCounts;
/// <summary></summary>
        public SampleCountFlags StorageImageSampleCounts;
/// <summary></summary>
        public uint MaxSampleMaskWords;
/// <summary></summary>
        public Bool32 TimestampComputeAndGraphics;
/// <summary></summary>
        public float TimestampPeriod;
/// <summary></summary>
        public uint MaxClipDistances;
/// <summary></summary>
        public uint MaxCullDistances;
/// <summary></summary>
        public uint MaxCombinedClipAndCullDistances;
/// <summary></summary>
        public uint DiscreteQueuePriorities;
        /// <summary></summary>
       public fixed float PointSizeRange[2];
        /// <summary></summary>
       public fixed float LineWidthRange[2];
/// <summary></summary>
        public float PointSizeGranularity;
/// <summary></summary>
        public float LineWidthGranularity;
/// <summary></summary>
        public Bool32 StrictLines;
/// <summary></summary>
        public Bool32 StandardSampleLocations;
/// <summary></summary>
        public ulong OptimalBufferCopyOffsetAlignment;
/// <summary></summary>
        public ulong OptimalBufferCopyRowPitchAlignment;
/// <summary></summary>
        public ulong NonCoherentAtomSize;
    }
}
