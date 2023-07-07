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
    [NativeName("Name", "VkDeviceObjectReservationCreateInfo")]
    public unsafe partial struct DeviceObjectReservationCreateInfo : IExtendsChain<DeviceCreateInfo>
    {
        public DeviceObjectReservationCreateInfo
        (
            StructureType? sType = StructureType.DeviceObjectReservationCreateInfo,
            void* pNext = null,
            uint? pipelineCacheCreateInfoCount = null,
            PipelineCacheCreateInfo* pPipelineCacheCreateInfos = null,
            uint? pipelinePoolSizeCount = null,
            PipelinePoolSize* pPipelinePoolSizes = null,
            uint? semaphoreRequestCount = null,
            uint? commandBufferRequestCount = null,
            uint? fenceRequestCount = null,
            uint? deviceMemoryRequestCount = null,
            uint? bufferRequestCount = null,
            uint? imageRequestCount = null,
            uint? eventRequestCount = null,
            uint? queryPoolRequestCount = null,
            uint? bufferViewRequestCount = null,
            uint? imageViewRequestCount = null,
            uint? layeredImageViewRequestCount = null,
            uint? pipelineCacheRequestCount = null,
            uint? pipelineLayoutRequestCount = null,
            uint? renderPassRequestCount = null,
            uint? graphicsPipelineRequestCount = null,
            uint? computePipelineRequestCount = null,
            uint? descriptorSetLayoutRequestCount = null,
            uint? samplerRequestCount = null,
            uint? descriptorPoolRequestCount = null,
            uint? descriptorSetRequestCount = null,
            uint? framebufferRequestCount = null,
            uint? commandPoolRequestCount = null,
            uint? samplerYcbcrConversionRequestCount = null,
            uint? surfaceRequestCount = null,
            uint? swapchainRequestCount = null,
            uint? displayModeRequestCount = null,
            uint? subpassDescriptionRequestCount = null,
            uint? attachmentDescriptionRequestCount = null,
            uint? descriptorSetLayoutBindingRequestCount = null,
            uint? descriptorSetLayoutBindingLimit = null,
            uint? maxImageViewMipLevels = null,
            uint? maxImageViewArrayLayers = null,
            uint? maxLayeredImageViewMipLevels = null,
            uint? maxOcclusionQueriesPerPool = null,
            uint? maxPipelineStatisticsQueriesPerPool = null,
            uint? maxTimestampQueriesPerPool = null,
            uint? maxImmutableSamplersPerDescriptorSetLayout = null
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

            if (pipelineCacheCreateInfoCount is not null)
            {
                PipelineCacheCreateInfoCount = pipelineCacheCreateInfoCount.Value;
            }

            if (pPipelineCacheCreateInfos is not null)
            {
                PPipelineCacheCreateInfos = pPipelineCacheCreateInfos;
            }

            if (pipelinePoolSizeCount is not null)
            {
                PipelinePoolSizeCount = pipelinePoolSizeCount.Value;
            }

            if (pPipelinePoolSizes is not null)
            {
                PPipelinePoolSizes = pPipelinePoolSizes;
            }

            if (semaphoreRequestCount is not null)
            {
                SemaphoreRequestCount = semaphoreRequestCount.Value;
            }

            if (commandBufferRequestCount is not null)
            {
                CommandBufferRequestCount = commandBufferRequestCount.Value;
            }

            if (fenceRequestCount is not null)
            {
                FenceRequestCount = fenceRequestCount.Value;
            }

            if (deviceMemoryRequestCount is not null)
            {
                DeviceMemoryRequestCount = deviceMemoryRequestCount.Value;
            }

            if (bufferRequestCount is not null)
            {
                BufferRequestCount = bufferRequestCount.Value;
            }

            if (imageRequestCount is not null)
            {
                ImageRequestCount = imageRequestCount.Value;
            }

            if (eventRequestCount is not null)
            {
                EventRequestCount = eventRequestCount.Value;
            }

            if (queryPoolRequestCount is not null)
            {
                QueryPoolRequestCount = queryPoolRequestCount.Value;
            }

            if (bufferViewRequestCount is not null)
            {
                BufferViewRequestCount = bufferViewRequestCount.Value;
            }

            if (imageViewRequestCount is not null)
            {
                ImageViewRequestCount = imageViewRequestCount.Value;
            }

            if (layeredImageViewRequestCount is not null)
            {
                LayeredImageViewRequestCount = layeredImageViewRequestCount.Value;
            }

            if (pipelineCacheRequestCount is not null)
            {
                PipelineCacheRequestCount = pipelineCacheRequestCount.Value;
            }

            if (pipelineLayoutRequestCount is not null)
            {
                PipelineLayoutRequestCount = pipelineLayoutRequestCount.Value;
            }

            if (renderPassRequestCount is not null)
            {
                RenderPassRequestCount = renderPassRequestCount.Value;
            }

            if (graphicsPipelineRequestCount is not null)
            {
                GraphicsPipelineRequestCount = graphicsPipelineRequestCount.Value;
            }

            if (computePipelineRequestCount is not null)
            {
                ComputePipelineRequestCount = computePipelineRequestCount.Value;
            }

            if (descriptorSetLayoutRequestCount is not null)
            {
                DescriptorSetLayoutRequestCount = descriptorSetLayoutRequestCount.Value;
            }

            if (samplerRequestCount is not null)
            {
                SamplerRequestCount = samplerRequestCount.Value;
            }

            if (descriptorPoolRequestCount is not null)
            {
                DescriptorPoolRequestCount = descriptorPoolRequestCount.Value;
            }

            if (descriptorSetRequestCount is not null)
            {
                DescriptorSetRequestCount = descriptorSetRequestCount.Value;
            }

            if (framebufferRequestCount is not null)
            {
                FramebufferRequestCount = framebufferRequestCount.Value;
            }

            if (commandPoolRequestCount is not null)
            {
                CommandPoolRequestCount = commandPoolRequestCount.Value;
            }

            if (samplerYcbcrConversionRequestCount is not null)
            {
                SamplerYcbcrConversionRequestCount = samplerYcbcrConversionRequestCount.Value;
            }

            if (surfaceRequestCount is not null)
            {
                SurfaceRequestCount = surfaceRequestCount.Value;
            }

            if (swapchainRequestCount is not null)
            {
                SwapchainRequestCount = swapchainRequestCount.Value;
            }

            if (displayModeRequestCount is not null)
            {
                DisplayModeRequestCount = displayModeRequestCount.Value;
            }

            if (subpassDescriptionRequestCount is not null)
            {
                SubpassDescriptionRequestCount = subpassDescriptionRequestCount.Value;
            }

            if (attachmentDescriptionRequestCount is not null)
            {
                AttachmentDescriptionRequestCount = attachmentDescriptionRequestCount.Value;
            }

            if (descriptorSetLayoutBindingRequestCount is not null)
            {
                DescriptorSetLayoutBindingRequestCount = descriptorSetLayoutBindingRequestCount.Value;
            }

            if (descriptorSetLayoutBindingLimit is not null)
            {
                DescriptorSetLayoutBindingLimit = descriptorSetLayoutBindingLimit.Value;
            }

            if (maxImageViewMipLevels is not null)
            {
                MaxImageViewMipLevels = maxImageViewMipLevels.Value;
            }

            if (maxImageViewArrayLayers is not null)
            {
                MaxImageViewArrayLayers = maxImageViewArrayLayers.Value;
            }

            if (maxLayeredImageViewMipLevels is not null)
            {
                MaxLayeredImageViewMipLevels = maxLayeredImageViewMipLevels.Value;
            }

            if (maxOcclusionQueriesPerPool is not null)
            {
                MaxOcclusionQueriesPerPool = maxOcclusionQueriesPerPool.Value;
            }

            if (maxPipelineStatisticsQueriesPerPool is not null)
            {
                MaxPipelineStatisticsQueriesPerPool = maxPipelineStatisticsQueriesPerPool.Value;
            }

            if (maxTimestampQueriesPerPool is not null)
            {
                MaxTimestampQueriesPerPool = maxTimestampQueriesPerPool.Value;
            }

            if (maxImmutableSamplersPerDescriptorSetLayout is not null)
            {
                MaxImmutableSamplersPerDescriptorSetLayout = maxImmutableSamplersPerDescriptorSetLayout.Value;
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
        [NativeName("Name", "pipelineCacheCreateInfoCount")]
        public uint PipelineCacheCreateInfoCount;
/// <summary></summary>
        [NativeName("Type", "VkPipelineCacheCreateInfo*")]
        [NativeName("Type.Name", "VkPipelineCacheCreateInfo")]
        [NativeName("Name", "pPipelineCacheCreateInfos")]
        public PipelineCacheCreateInfo* PPipelineCacheCreateInfos;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pipelinePoolSizeCount")]
        public uint PipelinePoolSizeCount;
/// <summary></summary>
        [NativeName("Type", "VkPipelinePoolSize*")]
        [NativeName("Type.Name", "VkPipelinePoolSize")]
        [NativeName("Name", "pPipelinePoolSizes")]
        public PipelinePoolSize* PPipelinePoolSizes;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "semaphoreRequestCount")]
        public uint SemaphoreRequestCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "commandBufferRequestCount")]
        public uint CommandBufferRequestCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "fenceRequestCount")]
        public uint FenceRequestCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "deviceMemoryRequestCount")]
        public uint DeviceMemoryRequestCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "bufferRequestCount")]
        public uint BufferRequestCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "imageRequestCount")]
        public uint ImageRequestCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "eventRequestCount")]
        public uint EventRequestCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "queryPoolRequestCount")]
        public uint QueryPoolRequestCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "bufferViewRequestCount")]
        public uint BufferViewRequestCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "imageViewRequestCount")]
        public uint ImageViewRequestCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "layeredImageViewRequestCount")]
        public uint LayeredImageViewRequestCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pipelineCacheRequestCount")]
        public uint PipelineCacheRequestCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pipelineLayoutRequestCount")]
        public uint PipelineLayoutRequestCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "renderPassRequestCount")]
        public uint RenderPassRequestCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "graphicsPipelineRequestCount")]
        public uint GraphicsPipelineRequestCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "computePipelineRequestCount")]
        public uint ComputePipelineRequestCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "descriptorSetLayoutRequestCount")]
        public uint DescriptorSetLayoutRequestCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "samplerRequestCount")]
        public uint SamplerRequestCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "descriptorPoolRequestCount")]
        public uint DescriptorPoolRequestCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "descriptorSetRequestCount")]
        public uint DescriptorSetRequestCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "framebufferRequestCount")]
        public uint FramebufferRequestCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "commandPoolRequestCount")]
        public uint CommandPoolRequestCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "samplerYcbcrConversionRequestCount")]
        public uint SamplerYcbcrConversionRequestCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "surfaceRequestCount")]
        public uint SurfaceRequestCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "swapchainRequestCount")]
        public uint SwapchainRequestCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "displayModeRequestCount")]
        public uint DisplayModeRequestCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "subpassDescriptionRequestCount")]
        public uint SubpassDescriptionRequestCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "attachmentDescriptionRequestCount")]
        public uint AttachmentDescriptionRequestCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "descriptorSetLayoutBindingRequestCount")]
        public uint DescriptorSetLayoutBindingRequestCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "descriptorSetLayoutBindingLimit")]
        public uint DescriptorSetLayoutBindingLimit;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxImageViewMipLevels")]
        public uint MaxImageViewMipLevels;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxImageViewArrayLayers")]
        public uint MaxImageViewArrayLayers;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxLayeredImageViewMipLevels")]
        public uint MaxLayeredImageViewMipLevels;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxOcclusionQueriesPerPool")]
        public uint MaxOcclusionQueriesPerPool;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPipelineStatisticsQueriesPerPool")]
        public uint MaxPipelineStatisticsQueriesPerPool;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxTimestampQueriesPerPool")]
        public uint MaxTimestampQueriesPerPool;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxImmutableSamplersPerDescriptorSetLayout")]
        public uint MaxImmutableSamplersPerDescriptorSetLayout;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DeviceObjectReservationCreateInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
