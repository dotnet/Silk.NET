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
    [NativeName("Name", "VkPhysicalDeviceLimits")]
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
        public UIntPtr MinMemoryMapAlignment;
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
    }
}
