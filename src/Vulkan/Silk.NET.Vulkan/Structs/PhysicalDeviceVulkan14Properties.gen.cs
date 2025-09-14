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
    [NativeName("Name", "VkPhysicalDeviceVulkan14Properties")]
    public unsafe partial struct PhysicalDeviceVulkan14Properties : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceVulkan14Properties
        (
            StructureType? sType = StructureType.PhysicalDeviceVulkan14Properties,
            void* pNext = null,
            uint? lineSubPixelPrecisionBits = null,
            uint? maxVertexAttribDivisor = null,
            Bool32? supportsNonZeroFirstInstance = null,
            uint? maxPushDescriptors = null,
            Bool32? dynamicRenderingLocalReadDepthStencilAttachments = null,
            Bool32? dynamicRenderingLocalReadMultisampledAttachments = null,
            Bool32? earlyFragmentMultisampleCoverageAfterSampleCounting = null,
            Bool32? earlyFragmentSampleMaskTestBeforeSampleCounting = null,
            Bool32? depthStencilSwizzleOneSupport = null,
            Bool32? polygonModePointSize = null,
            Bool32? nonStrictSinglePixelWideLinesUseParallelogram = null,
            Bool32? nonStrictWideLinesUseParallelogram = null,
            Bool32? blockTexelViewCompatibleMultipleLayers = null,
            uint? maxCombinedImageSamplerDescriptorCount = null,
            Bool32? fragmentShadingRateClampCombinerInputs = null,
            PipelineRobustnessBufferBehavior? defaultRobustnessStorageBuffers = null,
            PipelineRobustnessBufferBehavior? defaultRobustnessUniformBuffers = null,
            PipelineRobustnessBufferBehavior? defaultRobustnessVertexInputs = null,
            PipelineRobustnessImageBehavior? defaultRobustnessImages = null,
            uint? copySrcLayoutCount = null,
            ImageLayout* pCopySrcLayouts = null,
            uint? copyDstLayoutCount = null,
            ImageLayout* pCopyDstLayouts = null,
            Bool32? identicalMemoryTypeRequirements = null
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

            if (lineSubPixelPrecisionBits is not null)
            {
                LineSubPixelPrecisionBits = lineSubPixelPrecisionBits.Value;
            }

            if (maxVertexAttribDivisor is not null)
            {
                MaxVertexAttribDivisor = maxVertexAttribDivisor.Value;
            }

            if (supportsNonZeroFirstInstance is not null)
            {
                SupportsNonZeroFirstInstance = supportsNonZeroFirstInstance.Value;
            }

            if (maxPushDescriptors is not null)
            {
                MaxPushDescriptors = maxPushDescriptors.Value;
            }

            if (dynamicRenderingLocalReadDepthStencilAttachments is not null)
            {
                DynamicRenderingLocalReadDepthStencilAttachments = dynamicRenderingLocalReadDepthStencilAttachments.Value;
            }

            if (dynamicRenderingLocalReadMultisampledAttachments is not null)
            {
                DynamicRenderingLocalReadMultisampledAttachments = dynamicRenderingLocalReadMultisampledAttachments.Value;
            }

            if (earlyFragmentMultisampleCoverageAfterSampleCounting is not null)
            {
                EarlyFragmentMultisampleCoverageAfterSampleCounting = earlyFragmentMultisampleCoverageAfterSampleCounting.Value;
            }

            if (earlyFragmentSampleMaskTestBeforeSampleCounting is not null)
            {
                EarlyFragmentSampleMaskTestBeforeSampleCounting = earlyFragmentSampleMaskTestBeforeSampleCounting.Value;
            }

            if (depthStencilSwizzleOneSupport is not null)
            {
                DepthStencilSwizzleOneSupport = depthStencilSwizzleOneSupport.Value;
            }

            if (polygonModePointSize is not null)
            {
                PolygonModePointSize = polygonModePointSize.Value;
            }

            if (nonStrictSinglePixelWideLinesUseParallelogram is not null)
            {
                NonStrictSinglePixelWideLinesUseParallelogram = nonStrictSinglePixelWideLinesUseParallelogram.Value;
            }

            if (nonStrictWideLinesUseParallelogram is not null)
            {
                NonStrictWideLinesUseParallelogram = nonStrictWideLinesUseParallelogram.Value;
            }

            if (blockTexelViewCompatibleMultipleLayers is not null)
            {
                BlockTexelViewCompatibleMultipleLayers = blockTexelViewCompatibleMultipleLayers.Value;
            }

            if (maxCombinedImageSamplerDescriptorCount is not null)
            {
                MaxCombinedImageSamplerDescriptorCount = maxCombinedImageSamplerDescriptorCount.Value;
            }

            if (fragmentShadingRateClampCombinerInputs is not null)
            {
                FragmentShadingRateClampCombinerInputs = fragmentShadingRateClampCombinerInputs.Value;
            }

            if (defaultRobustnessStorageBuffers is not null)
            {
                DefaultRobustnessStorageBuffers = defaultRobustnessStorageBuffers.Value;
            }

            if (defaultRobustnessUniformBuffers is not null)
            {
                DefaultRobustnessUniformBuffers = defaultRobustnessUniformBuffers.Value;
            }

            if (defaultRobustnessVertexInputs is not null)
            {
                DefaultRobustnessVertexInputs = defaultRobustnessVertexInputs.Value;
            }

            if (defaultRobustnessImages is not null)
            {
                DefaultRobustnessImages = defaultRobustnessImages.Value;
            }

            if (copySrcLayoutCount is not null)
            {
                CopySrcLayoutCount = copySrcLayoutCount.Value;
            }

            if (pCopySrcLayouts is not null)
            {
                PCopySrcLayouts = pCopySrcLayouts;
            }

            if (copyDstLayoutCount is not null)
            {
                CopyDstLayoutCount = copyDstLayoutCount.Value;
            }

            if (pCopyDstLayouts is not null)
            {
                PCopyDstLayouts = pCopyDstLayouts;
            }

            if (identicalMemoryTypeRequirements is not null)
            {
                IdenticalMemoryTypeRequirements = identicalMemoryTypeRequirements.Value;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "lineSubPixelPrecisionBits")]
        public uint LineSubPixelPrecisionBits;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxVertexAttribDivisor")]
        public uint MaxVertexAttribDivisor;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "supportsNonZeroFirstInstance")]
        public Bool32 SupportsNonZeroFirstInstance;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPushDescriptors")]
        public uint MaxPushDescriptors;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "dynamicRenderingLocalReadDepthStencilAttachments")]
        public Bool32 DynamicRenderingLocalReadDepthStencilAttachments;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "dynamicRenderingLocalReadMultisampledAttachments")]
        public Bool32 DynamicRenderingLocalReadMultisampledAttachments;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "earlyFragmentMultisampleCoverageAfterSampleCounting")]
        public Bool32 EarlyFragmentMultisampleCoverageAfterSampleCounting;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "earlyFragmentSampleMaskTestBeforeSampleCounting")]
        public Bool32 EarlyFragmentSampleMaskTestBeforeSampleCounting;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "depthStencilSwizzleOneSupport")]
        public Bool32 DepthStencilSwizzleOneSupport;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "polygonModePointSize")]
        public Bool32 PolygonModePointSize;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "nonStrictSinglePixelWideLinesUseParallelogram")]
        public Bool32 NonStrictSinglePixelWideLinesUseParallelogram;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "nonStrictWideLinesUseParallelogram")]
        public Bool32 NonStrictWideLinesUseParallelogram;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "blockTexelViewCompatibleMultipleLayers")]
        public Bool32 BlockTexelViewCompatibleMultipleLayers;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxCombinedImageSamplerDescriptorCount")]
        public uint MaxCombinedImageSamplerDescriptorCount;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "fragmentShadingRateClampCombinerInputs")]
        public Bool32 FragmentShadingRateClampCombinerInputs;
/// <summary></summary>
        [NativeName("Type", "VkPipelineRobustnessBufferBehavior")]
        [NativeName("Type.Name", "VkPipelineRobustnessBufferBehavior")]
        [NativeName("Name", "defaultRobustnessStorageBuffers")]
        public PipelineRobustnessBufferBehavior DefaultRobustnessStorageBuffers;
/// <summary></summary>
        [NativeName("Type", "VkPipelineRobustnessBufferBehavior")]
        [NativeName("Type.Name", "VkPipelineRobustnessBufferBehavior")]
        [NativeName("Name", "defaultRobustnessUniformBuffers")]
        public PipelineRobustnessBufferBehavior DefaultRobustnessUniformBuffers;
/// <summary></summary>
        [NativeName("Type", "VkPipelineRobustnessBufferBehavior")]
        [NativeName("Type.Name", "VkPipelineRobustnessBufferBehavior")]
        [NativeName("Name", "defaultRobustnessVertexInputs")]
        public PipelineRobustnessBufferBehavior DefaultRobustnessVertexInputs;
/// <summary></summary>
        [NativeName("Type", "VkPipelineRobustnessImageBehavior")]
        [NativeName("Type.Name", "VkPipelineRobustnessImageBehavior")]
        [NativeName("Name", "defaultRobustnessImages")]
        public PipelineRobustnessImageBehavior DefaultRobustnessImages;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "copySrcLayoutCount")]
        public uint CopySrcLayoutCount;
/// <summary></summary>
        [NativeName("Type", "VkImageLayout*")]
        [NativeName("Type.Name", "VkImageLayout")]
        [NativeName("Name", "pCopySrcLayouts")]
        public ImageLayout* PCopySrcLayouts;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "copyDstLayoutCount")]
        public uint CopyDstLayoutCount;
/// <summary></summary>
        [NativeName("Type", "VkImageLayout*")]
        [NativeName("Type.Name", "VkImageLayout")]
        [NativeName("Name", "pCopyDstLayouts")]
        public ImageLayout* PCopyDstLayouts;
        /// <summary></summary>
        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "optimalTilingLayoutUUID")]
        public fixed byte OptimalTilingLayoutUuid[16];
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "identicalMemoryTypeRequirements")]
        public Bool32 IdenticalMemoryTypeRequirements;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceVulkan14Properties;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
