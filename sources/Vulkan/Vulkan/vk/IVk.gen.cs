// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Core.Loader;

namespace Silk.NET.Vulkan;

public unsafe partial interface IVk
{
    public partial interface Static
    {
        [NativeName("vkAcquireDrmDisplayEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkAcquireDrmDisplayEXT")]
        static abstract Result AcquireDrmDisplayEXT(
            PhysicalDeviceHandle physicalDevice,
            int drmFd,
            DisplayHandleKHR display
        );

        [NativeName("vkAcquireNextImage2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkAcquireNextImage2KHR")]
        static abstract Result AcquireNextImage2KHR(
            DeviceHandle device,
            AcquireNextImageInfoKHR* pAcquireInfo,
            uint* pImageIndex
        );

        [NativeName("vkAcquireNextImage2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkAcquireNextImage2KHR")]
        static abstract Result AcquireNextImage2KHR(
            DeviceHandle device,
            Ref<AcquireNextImageInfoKHR> pAcquireInfo,
            Ref<uint> pImageIndex
        );

        [NativeName("vkAcquireNextImageKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkAcquireNextImageKHR")]
        static abstract Result AcquireNextImageKHR(
            DeviceHandle device,
            SwapchainHandleKHR swapchain,
            ulong timeout,
            SemaphoreHandle semaphore,
            FenceHandle fence,
            uint* pImageIndex
        );

        [NativeName("vkAcquireNextImageKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkAcquireNextImageKHR")]
        static abstract Result AcquireNextImageKHR(
            DeviceHandle device,
            SwapchainHandleKHR swapchain,
            ulong timeout,
            SemaphoreHandle semaphore,
            FenceHandle fence,
            Ref<uint> pImageIndex
        );

        [NativeName("vkAcquirePerformanceConfigurationINTEL")]
        [NativeFunction("vulkan", EntryPoint = "vkAcquirePerformanceConfigurationINTEL")]
        static abstract Result AcquirePerformanceConfigurationINTEL(
            DeviceHandle device,
            PerformanceConfigurationAcquireInfoINTEL* pAcquireInfo,
            PerformanceConfigurationHandleINTEL* pConfiguration
        );

        [NativeName("vkAcquirePerformanceConfigurationINTEL")]
        [NativeFunction("vulkan", EntryPoint = "vkAcquirePerformanceConfigurationINTEL")]
        static abstract Result AcquirePerformanceConfigurationINTEL(
            DeviceHandle device,
            Ref<PerformanceConfigurationAcquireInfoINTEL> pAcquireInfo,
            Ref<PerformanceConfigurationHandleINTEL> pConfiguration
        );

        [NativeName("vkAcquireProfilingLockKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkAcquireProfilingLockKHR")]
        static abstract Result AcquireProfilingLockKHR(
            DeviceHandle device,
            AcquireProfilingLockInfoKHR* pInfo
        );

        [NativeName("vkAcquireProfilingLockKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkAcquireProfilingLockKHR")]
        static abstract Result AcquireProfilingLockKHR(
            DeviceHandle device,
            Ref<AcquireProfilingLockInfoKHR> pInfo
        );

        [NativeName("vkAllocateCommandBuffers")]
        [NativeFunction("vulkan", EntryPoint = "vkAllocateCommandBuffers")]
        static abstract Result AllocateCommandBuffers(
            DeviceHandle device,
            CommandBufferAllocateInfo* pAllocateInfo,
            CommandBufferHandle* pCommandBuffers
        );

        [NativeName("vkAllocateCommandBuffers")]
        [NativeFunction("vulkan", EntryPoint = "vkAllocateCommandBuffers")]
        static abstract Result AllocateCommandBuffers(
            DeviceHandle device,
            Ref<CommandBufferAllocateInfo> pAllocateInfo,
            Ref<CommandBufferHandle> pCommandBuffers
        );

        [NativeName("vkAllocateDescriptorSets")]
        [NativeFunction("vulkan", EntryPoint = "vkAllocateDescriptorSets")]
        static abstract Result AllocateDescriptorSets(
            DeviceHandle device,
            DescriptorSetAllocateInfo* pAllocateInfo,
            DescriptorSetHandle* pDescriptorSets
        );

        [NativeName("vkAllocateDescriptorSets")]
        [NativeFunction("vulkan", EntryPoint = "vkAllocateDescriptorSets")]
        static abstract Result AllocateDescriptorSets(
            DeviceHandle device,
            Ref<DescriptorSetAllocateInfo> pAllocateInfo,
            Ref<DescriptorSetHandle> pDescriptorSets
        );

        [NativeName("vkAllocateMemory")]
        [NativeFunction("vulkan", EntryPoint = "vkAllocateMemory")]
        static abstract Result AllocateMemory(
            DeviceHandle device,
            MemoryAllocateInfo* pAllocateInfo,
            AllocationCallbacks* pAllocator,
            DeviceMemoryHandle* pMemory
        );

        [NativeName("vkAllocateMemory")]
        [NativeFunction("vulkan", EntryPoint = "vkAllocateMemory")]
        static abstract Result AllocateMemory(
            DeviceHandle device,
            Ref<MemoryAllocateInfo> pAllocateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<DeviceMemoryHandle> pMemory
        );

        [NativeName("vkAntiLagUpdateAMD")]
        [NativeFunction("vulkan", EntryPoint = "vkAntiLagUpdateAMD")]
        static abstract void AntiLagUpdateAMD(DeviceHandle device, AntiLagDataAMD* pData);

        [NativeName("vkAntiLagUpdateAMD")]
        [NativeFunction("vulkan", EntryPoint = "vkAntiLagUpdateAMD")]
        static abstract void AntiLagUpdateAMD(DeviceHandle device, Ref<AntiLagDataAMD> pData);

        [NativeName("vkBeginCommandBuffer")]
        [NativeFunction("vulkan", EntryPoint = "vkBeginCommandBuffer")]
        static abstract Result BeginCommandBuffer(
            CommandBufferHandle commandBuffer,
            CommandBufferBeginInfo* pBeginInfo
        );

        [NativeName("vkBeginCommandBuffer")]
        [NativeFunction("vulkan", EntryPoint = "vkBeginCommandBuffer")]
        static abstract Result BeginCommandBuffer(
            CommandBufferHandle commandBuffer,
            Ref<CommandBufferBeginInfo> pBeginInfo
        );

        [NativeName("vkBindAccelerationStructureMemoryNV")]
        [NativeFunction("vulkan", EntryPoint = "vkBindAccelerationStructureMemoryNV")]
        static abstract Result BindAccelerationStructureMemoryNV(
            DeviceHandle device,
            uint bindInfoCount,
            BindAccelerationStructureMemoryInfoNV* pBindInfos
        );

        [NativeName("vkBindAccelerationStructureMemoryNV")]
        [NativeFunction("vulkan", EntryPoint = "vkBindAccelerationStructureMemoryNV")]
        static abstract Result BindAccelerationStructureMemoryNV(
            DeviceHandle device,
            uint bindInfoCount,
            Ref<BindAccelerationStructureMemoryInfoNV> pBindInfos
        );

        [NativeName("vkBindBufferMemory")]
        [NativeFunction("vulkan", EntryPoint = "vkBindBufferMemory")]
        static abstract Result BindBufferMemory(
            DeviceHandle device,
            BufferHandle buffer,
            DeviceMemoryHandle memory,
            ulong memoryOffset
        );

        [NativeName("vkBindBufferMemory2")]
        [NativeFunction("vulkan", EntryPoint = "vkBindBufferMemory2")]
        static abstract Result BindBufferMemory2(
            DeviceHandle device,
            uint bindInfoCount,
            BindBufferMemoryInfo* pBindInfos
        );

        [NativeName("vkBindBufferMemory2")]
        [NativeFunction("vulkan", EntryPoint = "vkBindBufferMemory2")]
        static abstract Result BindBufferMemory2(
            DeviceHandle device,
            uint bindInfoCount,
            Ref<BindBufferMemoryInfo> pBindInfos
        );

        [NativeName("vkBindBufferMemory2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkBindBufferMemory2KHR")]
        static abstract Result BindBufferMemory2KHR(
            DeviceHandle device,
            uint bindInfoCount,
            BindBufferMemoryInfo* pBindInfos
        );

        [NativeName("vkBindBufferMemory2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkBindBufferMemory2KHR")]
        static abstract Result BindBufferMemory2KHR(
            DeviceHandle device,
            uint bindInfoCount,
            Ref<BindBufferMemoryInfo> pBindInfos
        );

        [NativeName("vkBindDataGraphPipelineSessionMemoryARM")]
        [NativeFunction("vulkan", EntryPoint = "vkBindDataGraphPipelineSessionMemoryARM")]
        static abstract Result BindDataGraphPipelineSessionMemoryARM(
            DeviceHandle device,
            uint bindInfoCount,
            BindDataGraphPipelineSessionMemoryInfoARM* pBindInfos
        );

        [NativeName("vkBindDataGraphPipelineSessionMemoryARM")]
        [NativeFunction("vulkan", EntryPoint = "vkBindDataGraphPipelineSessionMemoryARM")]
        static abstract Result BindDataGraphPipelineSessionMemoryARM(
            DeviceHandle device,
            uint bindInfoCount,
            Ref<BindDataGraphPipelineSessionMemoryInfoARM> pBindInfos
        );

        [NativeName("vkBindImageMemory")]
        [NativeFunction("vulkan", EntryPoint = "vkBindImageMemory")]
        static abstract Result BindImageMemory(
            DeviceHandle device,
            ImageHandle image,
            DeviceMemoryHandle memory,
            ulong memoryOffset
        );

        [NativeName("vkBindImageMemory2")]
        [NativeFunction("vulkan", EntryPoint = "vkBindImageMemory2")]
        static abstract Result BindImageMemory2(
            DeviceHandle device,
            uint bindInfoCount,
            BindImageMemoryInfo* pBindInfos
        );

        [NativeName("vkBindImageMemory2")]
        [NativeFunction("vulkan", EntryPoint = "vkBindImageMemory2")]
        static abstract Result BindImageMemory2(
            DeviceHandle device,
            uint bindInfoCount,
            Ref<BindImageMemoryInfo> pBindInfos
        );

        [NativeName("vkBindImageMemory2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkBindImageMemory2KHR")]
        static abstract Result BindImageMemory2KHR(
            DeviceHandle device,
            uint bindInfoCount,
            BindImageMemoryInfo* pBindInfos
        );

        [NativeName("vkBindImageMemory2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkBindImageMemory2KHR")]
        static abstract Result BindImageMemory2KHR(
            DeviceHandle device,
            uint bindInfoCount,
            Ref<BindImageMemoryInfo> pBindInfos
        );

        [NativeName("vkBindOpticalFlowSessionImageNV")]
        [NativeFunction("vulkan", EntryPoint = "vkBindOpticalFlowSessionImageNV")]
        static abstract Result BindOpticalFlowSessionImageNV(
            DeviceHandle device,
            OpticalFlowSessionHandleNV session,
            OpticalFlowSessionBindingPointNV bindingPoint,
            ImageViewHandle view,
            ImageLayout layout
        );

        [NativeName("vkBindTensorMemoryARM")]
        [NativeFunction("vulkan", EntryPoint = "vkBindTensorMemoryARM")]
        static abstract Result BindTensorMemoryARM(
            DeviceHandle device,
            uint bindInfoCount,
            BindTensorMemoryInfoARM* pBindInfos
        );

        [NativeName("vkBindTensorMemoryARM")]
        [NativeFunction("vulkan", EntryPoint = "vkBindTensorMemoryARM")]
        static abstract Result BindTensorMemoryARM(
            DeviceHandle device,
            uint bindInfoCount,
            Ref<BindTensorMemoryInfoARM> pBindInfos
        );

        [NativeName("vkBindVideoSessionMemoryKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkBindVideoSessionMemoryKHR")]
        static abstract Result BindVideoSessionMemoryKHR(
            DeviceHandle device,
            VideoSessionHandleKHR videoSession,
            uint bindSessionMemoryInfoCount,
            BindVideoSessionMemoryInfoKHR* pBindSessionMemoryInfos
        );

        [NativeName("vkBindVideoSessionMemoryKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkBindVideoSessionMemoryKHR")]
        static abstract Result BindVideoSessionMemoryKHR(
            DeviceHandle device,
            VideoSessionHandleKHR videoSession,
            uint bindSessionMemoryInfoCount,
            Ref<BindVideoSessionMemoryInfoKHR> pBindSessionMemoryInfos
        );

        [NativeName("vkBuildAccelerationStructuresKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkBuildAccelerationStructuresKHR")]
        static abstract Result BuildAccelerationStructuresKHR(
            DeviceHandle device,
            DeferredOperationHandleKHR deferredOperation,
            uint infoCount,
            AccelerationStructureBuildGeometryInfoKHR* pInfos,
            AccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos
        );

        [NativeName("vkBuildAccelerationStructuresKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkBuildAccelerationStructuresKHR")]
        static abstract Result BuildAccelerationStructuresKHR(
            DeviceHandle device,
            DeferredOperationHandleKHR deferredOperation,
            uint infoCount,
            Ref<AccelerationStructureBuildGeometryInfoKHR> pInfos,
            Ref2D<AccelerationStructureBuildRangeInfoKHR> ppBuildRangeInfos
        );

        [NativeName("vkBuildMicromapsEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkBuildMicromapsEXT")]
        static abstract Result BuildMicromapsEXT(
            DeviceHandle device,
            DeferredOperationHandleKHR deferredOperation,
            uint infoCount,
            MicromapBuildInfoEXT* pInfos
        );

        [NativeName("vkBuildMicromapsEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkBuildMicromapsEXT")]
        static abstract Result BuildMicromapsEXT(
            DeviceHandle device,
            DeferredOperationHandleKHR deferredOperation,
            uint infoCount,
            Ref<MicromapBuildInfoEXT> pInfos
        );

        [NativeName("vkClearShaderInstrumentationMetricsARM")]
        [NativeFunction("vulkan", EntryPoint = "vkClearShaderInstrumentationMetricsARM")]
        static abstract void ClearShaderInstrumentationMetricsARM(
            DeviceHandle device,
            ShaderInstrumentationHandleARM instrumentation
        );

        [NativeName("vkCmdBeginConditionalRendering2EXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBeginConditionalRendering2EXT")]
        static abstract void CmdBeginConditionalRendering2EXT(
            CommandBufferHandle commandBuffer,
            ConditionalRenderingBeginInfo2EXT* pConditionalRenderingBegin
        );

        [NativeName("vkCmdBeginConditionalRendering2EXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBeginConditionalRendering2EXT")]
        static abstract void CmdBeginConditionalRendering2EXT(
            CommandBufferHandle commandBuffer,
            Ref<ConditionalRenderingBeginInfo2EXT> pConditionalRenderingBegin
        );

        [NativeName("vkCmdBeginConditionalRenderingEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBeginConditionalRenderingEXT")]
        static abstract void CmdBeginConditionalRenderingEXT(
            CommandBufferHandle commandBuffer,
            ConditionalRenderingBeginInfoEXT* pConditionalRenderingBegin
        );

        [NativeName("vkCmdBeginConditionalRenderingEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBeginConditionalRenderingEXT")]
        static abstract void CmdBeginConditionalRenderingEXT(
            CommandBufferHandle commandBuffer,
            Ref<ConditionalRenderingBeginInfoEXT> pConditionalRenderingBegin
        );

        [NativeName("vkCmdBeginCustomResolveEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBeginCustomResolveEXT")]
        static abstract void CmdBeginCustomResolveEXT(
            CommandBufferHandle commandBuffer,
            BeginCustomResolveInfoEXT* pBeginCustomResolveInfo
        );

        [NativeName("vkCmdBeginCustomResolveEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBeginCustomResolveEXT")]
        static abstract void CmdBeginCustomResolveEXT(
            CommandBufferHandle commandBuffer,
            Ref<BeginCustomResolveInfoEXT> pBeginCustomResolveInfo
        );

        [NativeName("vkCmdBeginDebugUtilsLabelEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBeginDebugUtilsLabelEXT")]
        static abstract void CmdBeginDebugUtilsLabelEXT(
            CommandBufferHandle commandBuffer,
            DebugUtilsLabelEXT* pLabelInfo
        );

        [NativeName("vkCmdBeginDebugUtilsLabelEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBeginDebugUtilsLabelEXT")]
        static abstract void CmdBeginDebugUtilsLabelEXT(
            CommandBufferHandle commandBuffer,
            Ref<DebugUtilsLabelEXT> pLabelInfo
        );

        [NativeName("vkCmdBeginGpaSampleAMD")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBeginGpaSampleAMD")]
        static abstract Result CmdBeginGpaSampleAMD(
            CommandBufferHandle commandBuffer,
            GpaSessionHandleAMD gpaSession,
            GpaSampleBeginInfoAMD* pGpaSampleBeginInfo,
            uint* pSampleID
        );

        [NativeName("vkCmdBeginGpaSampleAMD")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBeginGpaSampleAMD")]
        static abstract Result CmdBeginGpaSampleAMD(
            CommandBufferHandle commandBuffer,
            GpaSessionHandleAMD gpaSession,
            Ref<GpaSampleBeginInfoAMD> pGpaSampleBeginInfo,
            Ref<uint> pSampleID
        );

        [NativeName("vkCmdBeginGpaSessionAMD")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBeginGpaSessionAMD")]
        static abstract Result CmdBeginGpaSessionAMD(
            CommandBufferHandle commandBuffer,
            GpaSessionHandleAMD gpaSession
        );

        [NativeName("vkCmdBeginPerTileExecutionQCOM")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBeginPerTileExecutionQCOM")]
        static abstract void CmdBeginPerTileExecutionQCOM(
            CommandBufferHandle commandBuffer,
            PerTileBeginInfoQCOM* pPerTileBeginInfo
        );

        [NativeName("vkCmdBeginPerTileExecutionQCOM")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBeginPerTileExecutionQCOM")]
        static abstract void CmdBeginPerTileExecutionQCOM(
            CommandBufferHandle commandBuffer,
            Ref<PerTileBeginInfoQCOM> pPerTileBeginInfo
        );

        [NativeName("vkCmdBeginQuery")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBeginQuery")]
        static abstract void CmdBeginQuery(
            CommandBufferHandle commandBuffer,
            QueryPoolHandle queryPool,
            uint query,
            QueryControlFlags flags
        );

        [NativeName("vkCmdBeginQueryIndexedEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBeginQueryIndexedEXT")]
        static abstract void CmdBeginQueryIndexedEXT(
            CommandBufferHandle commandBuffer,
            QueryPoolHandle queryPool,
            uint query,
            QueryControlFlags flags,
            uint index
        );

        [NativeName("vkCmdBeginRendering")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBeginRendering")]
        static abstract void CmdBeginRendering(
            CommandBufferHandle commandBuffer,
            RenderingInfo* pRenderingInfo
        );

        [NativeName("vkCmdBeginRendering")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBeginRendering")]
        static abstract void CmdBeginRendering(
            CommandBufferHandle commandBuffer,
            Ref<RenderingInfo> pRenderingInfo
        );

        [NativeName("vkCmdBeginRenderingKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBeginRenderingKHR")]
        static abstract void CmdBeginRenderingKHR(
            CommandBufferHandle commandBuffer,
            RenderingInfo* pRenderingInfo
        );

        [NativeName("vkCmdBeginRenderingKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBeginRenderingKHR")]
        static abstract void CmdBeginRenderingKHR(
            CommandBufferHandle commandBuffer,
            Ref<RenderingInfo> pRenderingInfo
        );

        [NativeName("vkCmdBeginRenderPass")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBeginRenderPass")]
        static abstract void CmdBeginRenderPass(
            CommandBufferHandle commandBuffer,
            RenderPassBeginInfo* pRenderPassBegin,
            SubpassContents contents
        );

        [NativeName("vkCmdBeginRenderPass")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBeginRenderPass")]
        static abstract void CmdBeginRenderPass(
            CommandBufferHandle commandBuffer,
            Ref<RenderPassBeginInfo> pRenderPassBegin,
            SubpassContents contents
        );

        [NativeName("vkCmdBeginRenderPass2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBeginRenderPass2")]
        static abstract void CmdBeginRenderPass2(
            CommandBufferHandle commandBuffer,
            RenderPassBeginInfo* pRenderPassBegin,
            SubpassBeginInfo* pSubpassBeginInfo
        );

        [NativeName("vkCmdBeginRenderPass2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBeginRenderPass2")]
        static abstract void CmdBeginRenderPass2(
            CommandBufferHandle commandBuffer,
            Ref<RenderPassBeginInfo> pRenderPassBegin,
            Ref<SubpassBeginInfo> pSubpassBeginInfo
        );

        [NativeName("vkCmdBeginRenderPass2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBeginRenderPass2KHR")]
        static abstract void CmdBeginRenderPass2KHR(
            CommandBufferHandle commandBuffer,
            RenderPassBeginInfo* pRenderPassBegin,
            SubpassBeginInfo* pSubpassBeginInfo
        );

        [NativeName("vkCmdBeginRenderPass2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBeginRenderPass2KHR")]
        static abstract void CmdBeginRenderPass2KHR(
            CommandBufferHandle commandBuffer,
            Ref<RenderPassBeginInfo> pRenderPassBegin,
            Ref<SubpassBeginInfo> pSubpassBeginInfo
        );

        [NativeName("vkCmdBeginShaderInstrumentationARM")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBeginShaderInstrumentationARM")]
        static abstract void CmdBeginShaderInstrumentationARM(
            CommandBufferHandle commandBuffer,
            ShaderInstrumentationHandleARM instrumentation
        );

        [NativeName("vkCmdBeginTransformFeedback2EXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBeginTransformFeedback2EXT")]
        static abstract void CmdBeginTransformFeedback2EXT(
            CommandBufferHandle commandBuffer,
            uint firstCounterRange,
            uint counterRangeCount,
            BindTransformFeedbackBuffer2InfoEXT* pCounterInfos
        );

        [NativeName("vkCmdBeginTransformFeedback2EXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBeginTransformFeedback2EXT")]
        static abstract void CmdBeginTransformFeedback2EXT(
            CommandBufferHandle commandBuffer,
            uint firstCounterRange,
            uint counterRangeCount,
            Ref<BindTransformFeedbackBuffer2InfoEXT> pCounterInfos
        );

        [NativeName("vkCmdBeginTransformFeedback2EXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBeginTransformFeedback2EXT")]
        static abstract void CmdBeginTransformFeedback2EXT(
            CommandBufferHandle commandBuffer,
            uint firstCounterRange,
            BindTransformFeedbackBuffer2InfoEXT pCounterInfos
        );

        [NativeName("vkCmdBeginTransformFeedbackEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBeginTransformFeedbackEXT")]
        static abstract void CmdBeginTransformFeedbackEXT(
            CommandBufferHandle commandBuffer,
            uint firstCounterBuffer,
            uint counterBufferCount,
            BufferHandle* pCounterBuffers,
            ulong* pCounterBufferOffsets
        );

        [NativeName("vkCmdBeginTransformFeedbackEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBeginTransformFeedbackEXT")]
        static abstract void CmdBeginTransformFeedbackEXT(
            CommandBufferHandle commandBuffer,
            uint firstCounterBuffer,
            uint counterBufferCount,
            Ref<BufferHandle> pCounterBuffers,
            Ref<ulong> pCounterBufferOffsets
        );

        [NativeName("vkCmdBeginVideoCodingKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBeginVideoCodingKHR")]
        static abstract void CmdBeginVideoCodingKHR(
            CommandBufferHandle commandBuffer,
            VideoBeginCodingInfoKHR* pBeginInfo
        );

        [NativeName("vkCmdBeginVideoCodingKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBeginVideoCodingKHR")]
        static abstract void CmdBeginVideoCodingKHR(
            CommandBufferHandle commandBuffer,
            Ref<VideoBeginCodingInfoKHR> pBeginInfo
        );

        [NativeName("vkCmdBindDescriptorBufferEmbeddedSamplers2EXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindDescriptorBufferEmbeddedSamplers2EXT")]
        static abstract void CmdBindDescriptorBufferEmbeddedSamplers2EXT(
            CommandBufferHandle commandBuffer,
            BindDescriptorBufferEmbeddedSamplersInfoEXT* pBindDescriptorBufferEmbeddedSamplersInfo
        );

        [NativeName("vkCmdBindDescriptorBufferEmbeddedSamplers2EXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindDescriptorBufferEmbeddedSamplers2EXT")]
        static abstract void CmdBindDescriptorBufferEmbeddedSamplers2EXT(
            CommandBufferHandle commandBuffer,
            Ref<BindDescriptorBufferEmbeddedSamplersInfoEXT> pBindDescriptorBufferEmbeddedSamplersInfo
        );

        [NativeName("vkCmdBindDescriptorBufferEmbeddedSamplersEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindDescriptorBufferEmbeddedSamplersEXT")]
        static abstract void CmdBindDescriptorBufferEmbeddedSamplersEXT(
            CommandBufferHandle commandBuffer,
            PipelineBindPoint pipelineBindPoint,
            PipelineLayoutHandle layout,
            uint set
        );

        [NativeName("vkCmdBindDescriptorBuffersEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindDescriptorBuffersEXT")]
        static abstract void CmdBindDescriptorBufferEXT(
            CommandBufferHandle commandBuffer,
            DescriptorBufferBindingInfoEXT pBindingInfos
        );

        [NativeName("vkCmdBindDescriptorBuffersEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindDescriptorBuffersEXT")]
        static abstract void CmdBindDescriptorBuffersEXT(
            CommandBufferHandle commandBuffer,
            uint bufferCount,
            DescriptorBufferBindingInfoEXT* pBindingInfos
        );

        [NativeName("vkCmdBindDescriptorBuffersEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindDescriptorBuffersEXT")]
        static abstract void CmdBindDescriptorBuffersEXT(
            CommandBufferHandle commandBuffer,
            uint bufferCount,
            Ref<DescriptorBufferBindingInfoEXT> pBindingInfos
        );

        [NativeName("vkCmdBindDescriptorSets")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindDescriptorSets")]
        static abstract void CmdBindDescriptorSets(
            CommandBufferHandle commandBuffer,
            PipelineBindPoint pipelineBindPoint,
            PipelineLayoutHandle layout,
            uint firstSet,
            uint descriptorSetCount,
            DescriptorSetHandle* pDescriptorSets,
            uint dynamicOffsetCount,
            uint* pDynamicOffsets
        );

        [NativeName("vkCmdBindDescriptorSets")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindDescriptorSets")]
        static abstract void CmdBindDescriptorSets(
            CommandBufferHandle commandBuffer,
            PipelineBindPoint pipelineBindPoint,
            PipelineLayoutHandle layout,
            uint firstSet,
            uint descriptorSetCount,
            Ref<DescriptorSetHandle> pDescriptorSets,
            uint dynamicOffsetCount,
            Ref<uint> pDynamicOffsets
        );

        [NativeName("vkCmdBindDescriptorSets2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindDescriptorSets2")]
        static abstract void CmdBindDescriptorSets2(
            CommandBufferHandle commandBuffer,
            BindDescriptorSetsInfo* pBindDescriptorSetsInfo
        );

        [NativeName("vkCmdBindDescriptorSets2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindDescriptorSets2")]
        static abstract void CmdBindDescriptorSets2(
            CommandBufferHandle commandBuffer,
            Ref<BindDescriptorSetsInfo> pBindDescriptorSetsInfo
        );

        [NativeName("vkCmdBindDescriptorSets2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindDescriptorSets2KHR")]
        static abstract void CmdBindDescriptorSets2KHR(
            CommandBufferHandle commandBuffer,
            BindDescriptorSetsInfo* pBindDescriptorSetsInfo
        );

        [NativeName("vkCmdBindDescriptorSets2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindDescriptorSets2KHR")]
        static abstract void CmdBindDescriptorSets2KHR(
            CommandBufferHandle commandBuffer,
            Ref<BindDescriptorSetsInfo> pBindDescriptorSetsInfo
        );

        [NativeName("vkCmdBindIndexBuffer")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindIndexBuffer")]
        static abstract void CmdBindIndexBuffer(
            CommandBufferHandle commandBuffer,
            BufferHandle buffer,
            ulong offset,
            IndexType indexType
        );

        [NativeName("vkCmdBindIndexBuffer2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindIndexBuffer2")]
        static abstract void CmdBindIndexBuffer2(
            CommandBufferHandle commandBuffer,
            BufferHandle buffer,
            ulong offset,
            ulong size,
            IndexType indexType
        );

        [NativeName("vkCmdBindIndexBuffer2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindIndexBuffer2KHR")]
        static abstract void CmdBindIndexBuffer2KHR(
            CommandBufferHandle commandBuffer,
            BufferHandle buffer,
            ulong offset,
            ulong size,
            IndexType indexType
        );

        [NativeName("vkCmdBindIndexBuffer3KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindIndexBuffer3KHR")]
        static abstract void CmdBindIndexBuffer3KHR(
            CommandBufferHandle commandBuffer,
            BindIndexBuffer3InfoKHR* pInfo
        );

        [NativeName("vkCmdBindIndexBuffer3KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindIndexBuffer3KHR")]
        static abstract void CmdBindIndexBuffer3KHR(
            CommandBufferHandle commandBuffer,
            Ref<BindIndexBuffer3InfoKHR> pInfo
        );

        [NativeName("vkCmdBindInvocationMaskHUAWEI")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindInvocationMaskHUAWEI")]
        static abstract void CmdBindInvocationMaskHUAWEI(
            CommandBufferHandle commandBuffer,
            ImageViewHandle imageView,
            ImageLayout imageLayout
        );

        [NativeName("vkCmdBindPipeline")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindPipeline")]
        static abstract void CmdBindPipeline(
            CommandBufferHandle commandBuffer,
            PipelineBindPoint pipelineBindPoint,
            PipelineHandle pipeline
        );

        [NativeName("vkCmdBindPipelineShaderGroupNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindPipelineShaderGroupNV")]
        static abstract void CmdBindPipelineShaderGroupNV(
            CommandBufferHandle commandBuffer,
            PipelineBindPoint pipelineBindPoint,
            PipelineHandle pipeline,
            uint groupIndex
        );

        [NativeName("vkCmdBindResourceHeapEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindResourceHeapEXT")]
        static abstract void CmdBindResourceHeapEXT(
            CommandBufferHandle commandBuffer,
            BindHeapInfoEXT* pBindInfo
        );

        [NativeName("vkCmdBindResourceHeapEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindResourceHeapEXT")]
        static abstract void CmdBindResourceHeapEXT(
            CommandBufferHandle commandBuffer,
            Ref<BindHeapInfoEXT> pBindInfo
        );

        [NativeName("vkCmdBindSamplerHeapEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindSamplerHeapEXT")]
        static abstract void CmdBindSamplerHeapEXT(
            CommandBufferHandle commandBuffer,
            BindHeapInfoEXT* pBindInfo
        );

        [NativeName("vkCmdBindSamplerHeapEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindSamplerHeapEXT")]
        static abstract void CmdBindSamplerHeapEXT(
            CommandBufferHandle commandBuffer,
            Ref<BindHeapInfoEXT> pBindInfo
        );

        [NativeName("vkCmdBindShadersEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindShadersEXT")]
        static abstract void CmdBindShadersEXT(
            CommandBufferHandle commandBuffer,
            uint stageCount,
            ShaderStageFlags* pStages,
            ShaderHandleEXT* pShaders
        );

        [NativeName("vkCmdBindShadersEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindShadersEXT")]
        static abstract void CmdBindShadersEXT(
            CommandBufferHandle commandBuffer,
            uint stageCount,
            Ref<ShaderStageFlags> pStages,
            Ref<ShaderHandleEXT> pShaders
        );

        [NativeName("vkCmdBindShadingRateImageNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindShadingRateImageNV")]
        static abstract void CmdBindShadingRateImageNV(
            CommandBufferHandle commandBuffer,
            ImageViewHandle imageView,
            ImageLayout imageLayout
        );

        [NativeName("vkCmdBindTileMemoryQCOM")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindTileMemoryQCOM")]
        static abstract void CmdBindTileMemoryQCOM(
            CommandBufferHandle commandBuffer,
            TileMemoryBindInfoQCOM* pTileMemoryBindInfo
        );

        [NativeName("vkCmdBindTileMemoryQCOM")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindTileMemoryQCOM")]
        static abstract void CmdBindTileMemoryQCOM(
            CommandBufferHandle commandBuffer,
            Ref<TileMemoryBindInfoQCOM> pTileMemoryBindInfo
        );

        [NativeName("vkCmdBindTransformFeedbackBuffers2EXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindTransformFeedbackBuffers2EXT")]
        static abstract void CmdBindTransformFeedbackBuffers2EXT(
            CommandBufferHandle commandBuffer,
            uint firstBinding,
            uint bindingCount,
            BindTransformFeedbackBuffer2InfoEXT* pBindingInfos
        );

        [NativeName("vkCmdBindTransformFeedbackBuffers2EXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindTransformFeedbackBuffers2EXT")]
        static abstract void CmdBindTransformFeedbackBuffers2EXT(
            CommandBufferHandle commandBuffer,
            uint firstBinding,
            uint bindingCount,
            Ref<BindTransformFeedbackBuffer2InfoEXT> pBindingInfos
        );

        [NativeName("vkCmdBindTransformFeedbackBuffers2EXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindTransformFeedbackBuffers2EXT")]
        static abstract void CmdBindTransformFeedbackBuffers2EXT(
            CommandBufferHandle commandBuffer,
            uint firstBinding,
            BindTransformFeedbackBuffer2InfoEXT pBindingInfos
        );

        [NativeName("vkCmdBindTransformFeedbackBuffersEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindTransformFeedbackBuffersEXT")]
        static abstract void CmdBindTransformFeedbackBuffersEXT(
            CommandBufferHandle commandBuffer,
            uint firstBinding,
            uint bindingCount,
            BufferHandle* pBuffers,
            ulong* pOffsets,
            ulong* pSizes
        );

        [NativeName("vkCmdBindTransformFeedbackBuffersEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindTransformFeedbackBuffersEXT")]
        static abstract void CmdBindTransformFeedbackBuffersEXT(
            CommandBufferHandle commandBuffer,
            uint firstBinding,
            uint bindingCount,
            Ref<BufferHandle> pBuffers,
            Ref<ulong> pOffsets,
            Ref<ulong> pSizes
        );

        [NativeName("vkCmdBindVertexBuffers")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindVertexBuffers")]
        static abstract void CmdBindVertexBuffers(
            CommandBufferHandle commandBuffer,
            uint firstBinding,
            uint bindingCount,
            BufferHandle* pBuffers,
            ulong* pOffsets
        );

        [NativeName("vkCmdBindVertexBuffers")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindVertexBuffers")]
        static abstract void CmdBindVertexBuffers(
            CommandBufferHandle commandBuffer,
            uint firstBinding,
            uint bindingCount,
            Ref<BufferHandle> pBuffers,
            Ref<ulong> pOffsets
        );

        [NativeName("vkCmdBindVertexBuffers2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindVertexBuffers2")]
        static abstract void CmdBindVertexBuffers2(
            CommandBufferHandle commandBuffer,
            uint firstBinding,
            uint bindingCount,
            BufferHandle* pBuffers,
            ulong* pOffsets,
            ulong* pSizes,
            ulong* pStrides
        );

        [NativeName("vkCmdBindVertexBuffers2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindVertexBuffers2")]
        static abstract void CmdBindVertexBuffers2(
            CommandBufferHandle commandBuffer,
            uint firstBinding,
            uint bindingCount,
            Ref<BufferHandle> pBuffers,
            Ref<ulong> pOffsets,
            Ref<ulong> pSizes,
            Ref<ulong> pStrides
        );

        [NativeName("vkCmdBindVertexBuffers2EXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindVertexBuffers2EXT")]
        static abstract void CmdBindVertexBuffers2EXT(
            CommandBufferHandle commandBuffer,
            uint firstBinding,
            uint bindingCount,
            BufferHandle* pBuffers,
            ulong* pOffsets,
            ulong* pSizes,
            ulong* pStrides
        );

        [NativeName("vkCmdBindVertexBuffers2EXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindVertexBuffers2EXT")]
        static abstract void CmdBindVertexBuffers2EXT(
            CommandBufferHandle commandBuffer,
            uint firstBinding,
            uint bindingCount,
            Ref<BufferHandle> pBuffers,
            Ref<ulong> pOffsets,
            Ref<ulong> pSizes,
            Ref<ulong> pStrides
        );

        [NativeName("vkCmdBindVertexBuffers3KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindVertexBuffers3KHR")]
        static abstract void CmdBindVertexBuffers3KHR(
            CommandBufferHandle commandBuffer,
            uint firstBinding,
            uint bindingCount,
            BindVertexBuffer3InfoKHR* pBindingInfos
        );

        [NativeName("vkCmdBindVertexBuffers3KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindVertexBuffers3KHR")]
        static abstract void CmdBindVertexBuffers3KHR(
            CommandBufferHandle commandBuffer,
            uint firstBinding,
            uint bindingCount,
            Ref<BindVertexBuffer3InfoKHR> pBindingInfos
        );

        [NativeName("vkCmdBindVertexBuffers3KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBindVertexBuffers3KHR")]
        static abstract void CmdBindVertexBuffers3KHR(
            CommandBufferHandle commandBuffer,
            uint firstBinding,
            BindVertexBuffer3InfoKHR pBindingInfos
        );

        [NativeName("vkCmdBlitImage")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBlitImage")]
        static abstract void CmdBlitImage(
            CommandBufferHandle commandBuffer,
            ImageHandle srcImage,
            ImageLayout srcImageLayout,
            ImageHandle dstImage,
            ImageLayout dstImageLayout,
            uint regionCount,
            ImageBlit* pRegions,
            Filter filter
        );

        [NativeName("vkCmdBlitImage")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBlitImage")]
        static abstract void CmdBlitImage(
            CommandBufferHandle commandBuffer,
            ImageHandle srcImage,
            ImageLayout srcImageLayout,
            ImageHandle dstImage,
            ImageLayout dstImageLayout,
            uint regionCount,
            Ref<ImageBlit> pRegions,
            Filter filter
        );

        [NativeName("vkCmdBlitImage")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBlitImage")]
        static abstract void CmdBlitImage(
            CommandBufferHandle commandBuffer,
            ImageHandle srcImage,
            ImageLayout srcImageLayout,
            ImageHandle dstImage,
            ImageLayout dstImageLayout,
            ImageBlit pRegions,
            Filter filter
        );

        [NativeName("vkCmdBlitImage2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBlitImage2")]
        static abstract void CmdBlitImage2(
            CommandBufferHandle commandBuffer,
            BlitImageInfo2* pBlitImageInfo
        );

        [NativeName("vkCmdBlitImage2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBlitImage2")]
        static abstract void CmdBlitImage2(
            CommandBufferHandle commandBuffer,
            Ref<BlitImageInfo2> pBlitImageInfo
        );

        [NativeName("vkCmdBlitImage2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBlitImage2KHR")]
        static abstract void CmdBlitImage2KHR(
            CommandBufferHandle commandBuffer,
            BlitImageInfo2* pBlitImageInfo
        );

        [NativeName("vkCmdBlitImage2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBlitImage2KHR")]
        static abstract void CmdBlitImage2KHR(
            CommandBufferHandle commandBuffer,
            Ref<BlitImageInfo2> pBlitImageInfo
        );

        [NativeName("vkCmdBuildAccelerationStructureNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBuildAccelerationStructureNV")]
        static abstract void CmdBuildAccelerationStructureNV(
            CommandBufferHandle commandBuffer,
            AccelerationStructureInfoNV* pInfo,
            BufferHandle instanceData,
            ulong instanceOffset,
            uint update,
            AccelerationStructureHandleNV dst,
            AccelerationStructureHandleNV src,
            BufferHandle scratch,
            ulong scratchOffset
        );

        [NativeName("vkCmdBuildAccelerationStructureNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBuildAccelerationStructureNV")]
        static abstract void CmdBuildAccelerationStructureNV(
            CommandBufferHandle commandBuffer,
            Ref<AccelerationStructureInfoNV> pInfo,
            BufferHandle instanceData,
            ulong instanceOffset,
            MaybeBool<uint> update,
            AccelerationStructureHandleNV dst,
            AccelerationStructureHandleNV src,
            BufferHandle scratch,
            ulong scratchOffset
        );

        [NativeName("vkCmdBuildAccelerationStructuresIndirectKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR")]
        static abstract void CmdBuildAccelerationStructuresIndirectKHR(
            CommandBufferHandle commandBuffer,
            uint infoCount,
            AccelerationStructureBuildGeometryInfoKHR* pInfos,
            ulong* pIndirectDeviceAddresses,
            uint* pIndirectStrides,
            uint** ppMaxPrimitiveCounts
        );

        [NativeName("vkCmdBuildAccelerationStructuresIndirectKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR")]
        static abstract void CmdBuildAccelerationStructuresIndirectKHR(
            CommandBufferHandle commandBuffer,
            uint infoCount,
            Ref<AccelerationStructureBuildGeometryInfoKHR> pInfos,
            Ref<ulong> pIndirectDeviceAddresses,
            Ref<uint> pIndirectStrides,
            Ref2D<uint> ppMaxPrimitiveCounts
        );

        [NativeName("vkCmdBuildAccelerationStructuresKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBuildAccelerationStructuresKHR")]
        static abstract void CmdBuildAccelerationStructuresKHR(
            CommandBufferHandle commandBuffer,
            uint infoCount,
            AccelerationStructureBuildGeometryInfoKHR* pInfos,
            AccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos
        );

        [NativeName("vkCmdBuildAccelerationStructuresKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBuildAccelerationStructuresKHR")]
        static abstract void CmdBuildAccelerationStructuresKHR(
            CommandBufferHandle commandBuffer,
            uint infoCount,
            Ref<AccelerationStructureBuildGeometryInfoKHR> pInfos,
            Ref2D<AccelerationStructureBuildRangeInfoKHR> ppBuildRangeInfos
        );

        [NativeName("vkCmdBuildClusterAccelerationStructureIndirectNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBuildClusterAccelerationStructureIndirectNV")]
        static abstract void CmdBuildClusterAccelerationStructureIndirectNV(
            CommandBufferHandle commandBuffer,
            ClusterAccelerationStructureCommandsInfoNV* pCommandInfos
        );

        [NativeName("vkCmdBuildClusterAccelerationStructureIndirectNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBuildClusterAccelerationStructureIndirectNV")]
        static abstract void CmdBuildClusterAccelerationStructureIndirectNV(
            CommandBufferHandle commandBuffer,
            Ref<ClusterAccelerationStructureCommandsInfoNV> pCommandInfos
        );

        [NativeName("vkCmdBuildMicromapsEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBuildMicromapsEXT")]
        static abstract void CmdBuildMicromapEXT(
            CommandBufferHandle commandBuffer,
            MicromapBuildInfoEXT pInfos
        );

        [NativeName("vkCmdBuildMicromapsEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBuildMicromapsEXT")]
        static abstract void CmdBuildMicromapsEXT(
            CommandBufferHandle commandBuffer,
            uint infoCount,
            MicromapBuildInfoEXT* pInfos
        );

        [NativeName("vkCmdBuildMicromapsEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBuildMicromapsEXT")]
        static abstract void CmdBuildMicromapsEXT(
            CommandBufferHandle commandBuffer,
            uint infoCount,
            Ref<MicromapBuildInfoEXT> pInfos
        );

        [NativeName("vkCmdBuildPartitionedAccelerationStructuresNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBuildPartitionedAccelerationStructuresNV")]
        static abstract void CmdBuildPartitionedAccelerationStructuresNV(
            CommandBufferHandle commandBuffer,
            BuildPartitionedAccelerationStructureInfoNV* pBuildInfo
        );

        [NativeName("vkCmdBuildPartitionedAccelerationStructuresNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdBuildPartitionedAccelerationStructuresNV")]
        static abstract void CmdBuildPartitionedAccelerationStructuresNV(
            CommandBufferHandle commandBuffer,
            Ref<BuildPartitionedAccelerationStructureInfoNV> pBuildInfo
        );

        [NativeName("vkCmdClearAttachments")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdClearAttachments")]
        static abstract void CmdClearAttachments(
            CommandBufferHandle commandBuffer,
            uint attachmentCount,
            ClearAttachment* pAttachments,
            uint rectCount,
            ClearRect* pRects
        );

        [NativeName("vkCmdClearAttachments")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdClearAttachments")]
        static abstract void CmdClearAttachments(
            CommandBufferHandle commandBuffer,
            uint attachmentCount,
            Ref<ClearAttachment> pAttachments,
            uint rectCount,
            Ref<ClearRect> pRects
        );

        [NativeName("vkCmdClearColorImage")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdClearColorImage")]
        static abstract void CmdClearColorImage(
            CommandBufferHandle commandBuffer,
            ImageHandle image,
            ImageLayout imageLayout,
            ClearColorValue* pColor,
            uint rangeCount,
            ImageSubresourceRange* pRanges
        );

        [NativeName("vkCmdClearColorImage")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdClearColorImage")]
        static abstract void CmdClearColorImage(
            CommandBufferHandle commandBuffer,
            ImageHandle image,
            ImageLayout imageLayout,
            Ref<ClearColorValue> pColor,
            uint rangeCount,
            Ref<ImageSubresourceRange> pRanges
        );

        [NativeName("vkCmdClearColorImage")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdClearColorImage")]
        static abstract void CmdClearColorImage(
            CommandBufferHandle commandBuffer,
            ImageHandle image,
            ImageLayout imageLayout,
            Ref<ClearColorValue> pColor,
            ImageSubresourceRange pRanges
        );

        [NativeName("vkCmdClearDepthStencilImage")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdClearDepthStencilImage")]
        static abstract void CmdClearDepthStencilImage(
            CommandBufferHandle commandBuffer,
            ImageHandle image,
            ImageLayout imageLayout,
            ClearDepthStencilValue* pDepthStencil,
            uint rangeCount,
            ImageSubresourceRange* pRanges
        );

        [NativeName("vkCmdClearDepthStencilImage")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdClearDepthStencilImage")]
        static abstract void CmdClearDepthStencilImage(
            CommandBufferHandle commandBuffer,
            ImageHandle image,
            ImageLayout imageLayout,
            Ref<ClearDepthStencilValue> pDepthStencil,
            uint rangeCount,
            Ref<ImageSubresourceRange> pRanges
        );

        [NativeName("vkCmdClearDepthStencilImage")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdClearDepthStencilImage")]
        static abstract void CmdClearDepthStencilImage(
            CommandBufferHandle commandBuffer,
            ImageHandle image,
            ImageLayout imageLayout,
            Ref<ClearDepthStencilValue> pDepthStencil,
            ImageSubresourceRange pRanges
        );

        [NativeName("vkCmdControlVideoCodingKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdControlVideoCodingKHR")]
        static abstract void CmdControlVideoCodingKHR(
            CommandBufferHandle commandBuffer,
            VideoCodingControlInfoKHR* pCodingControlInfo
        );

        [NativeName("vkCmdControlVideoCodingKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdControlVideoCodingKHR")]
        static abstract void CmdControlVideoCodingKHR(
            CommandBufferHandle commandBuffer,
            Ref<VideoCodingControlInfoKHR> pCodingControlInfo
        );

        [NativeName("vkCmdConvertCooperativeVectorMatrixNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdConvertCooperativeVectorMatrixNV")]
        static abstract void CmdConvertCooperativeVectorMatrixNV(
            CommandBufferHandle commandBuffer,
            uint infoCount,
            ConvertCooperativeVectorMatrixInfoNV* pInfos
        );

        [NativeName("vkCmdConvertCooperativeVectorMatrixNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdConvertCooperativeVectorMatrixNV")]
        static abstract void CmdConvertCooperativeVectorMatrixNV(
            CommandBufferHandle commandBuffer,
            uint infoCount,
            Ref<ConvertCooperativeVectorMatrixInfoNV> pInfos
        );

        [NativeName("vkCmdConvertCooperativeVectorMatrixNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdConvertCooperativeVectorMatrixNV")]
        static abstract void CmdConvertCooperativeVectorMatrixNV(
            CommandBufferHandle commandBuffer,
            ConvertCooperativeVectorMatrixInfoNV pInfos
        );

        [NativeName("vkCmdCopyAccelerationStructureKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyAccelerationStructureKHR")]
        static abstract void CmdCopyAccelerationStructureKHR(
            CommandBufferHandle commandBuffer,
            CopyAccelerationStructureInfoKHR* pInfo
        );

        [NativeName("vkCmdCopyAccelerationStructureKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyAccelerationStructureKHR")]
        static abstract void CmdCopyAccelerationStructureKHR(
            CommandBufferHandle commandBuffer,
            Ref<CopyAccelerationStructureInfoKHR> pInfo
        );

        [NativeName("vkCmdCopyAccelerationStructureNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyAccelerationStructureNV")]
        static abstract void CmdCopyAccelerationStructureNV(
            CommandBufferHandle commandBuffer,
            AccelerationStructureHandleNV dst,
            AccelerationStructureHandleNV src,
            CopyAccelerationStructureModeKHR mode
        );

        [NativeName("vkCmdCopyAccelerationStructureToMemoryKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyAccelerationStructureToMemoryKHR")]
        static abstract void CmdCopyAccelerationStructureToMemoryKHR(
            CommandBufferHandle commandBuffer,
            CopyAccelerationStructureToMemoryInfoKHR* pInfo
        );

        [NativeName("vkCmdCopyAccelerationStructureToMemoryKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyAccelerationStructureToMemoryKHR")]
        static abstract void CmdCopyAccelerationStructureToMemoryKHR(
            CommandBufferHandle commandBuffer,
            Ref<CopyAccelerationStructureToMemoryInfoKHR> pInfo
        );

        [NativeName("vkCmdCopyBuffer")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyBuffer")]
        static abstract void CmdCopyBuffer(
            CommandBufferHandle commandBuffer,
            BufferHandle srcBuffer,
            BufferHandle dstBuffer,
            uint regionCount,
            BufferCopy* pRegions
        );

        [NativeName("vkCmdCopyBuffer")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyBuffer")]
        static abstract void CmdCopyBuffer(
            CommandBufferHandle commandBuffer,
            BufferHandle srcBuffer,
            BufferHandle dstBuffer,
            uint regionCount,
            Ref<BufferCopy> pRegions
        );

        [NativeName("vkCmdCopyBuffer")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyBuffer")]
        static abstract void CmdCopyBuffer(
            CommandBufferHandle commandBuffer,
            BufferHandle srcBuffer,
            BufferHandle dstBuffer,
            BufferCopy pRegions
        );

        [NativeName("vkCmdCopyBuffer2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyBuffer2")]
        static abstract void CmdCopyBuffer2(
            CommandBufferHandle commandBuffer,
            CopyBufferInfo2* pCopyBufferInfo
        );

        [NativeName("vkCmdCopyBuffer2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyBuffer2")]
        static abstract void CmdCopyBuffer2(
            CommandBufferHandle commandBuffer,
            Ref<CopyBufferInfo2> pCopyBufferInfo
        );

        [NativeName("vkCmdCopyBuffer2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyBuffer2KHR")]
        static abstract void CmdCopyBuffer2KHR(
            CommandBufferHandle commandBuffer,
            CopyBufferInfo2* pCopyBufferInfo
        );

        [NativeName("vkCmdCopyBuffer2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyBuffer2KHR")]
        static abstract void CmdCopyBuffer2KHR(
            CommandBufferHandle commandBuffer,
            Ref<CopyBufferInfo2> pCopyBufferInfo
        );

        [NativeName("vkCmdCopyBufferToImage")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyBufferToImage")]
        static abstract void CmdCopyBufferToImage(
            CommandBufferHandle commandBuffer,
            BufferHandle srcBuffer,
            ImageHandle dstImage,
            ImageLayout dstImageLayout,
            uint regionCount,
            BufferImageCopy* pRegions
        );

        [NativeName("vkCmdCopyBufferToImage")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyBufferToImage")]
        static abstract void CmdCopyBufferToImage(
            CommandBufferHandle commandBuffer,
            BufferHandle srcBuffer,
            ImageHandle dstImage,
            ImageLayout dstImageLayout,
            uint regionCount,
            Ref<BufferImageCopy> pRegions
        );

        [NativeName("vkCmdCopyBufferToImage")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyBufferToImage")]
        static abstract void CmdCopyBufferToImage(
            CommandBufferHandle commandBuffer,
            BufferHandle srcBuffer,
            ImageHandle dstImage,
            ImageLayout dstImageLayout,
            BufferImageCopy pRegions
        );

        [NativeName("vkCmdCopyBufferToImage2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyBufferToImage2")]
        static abstract void CmdCopyBufferToImage2(
            CommandBufferHandle commandBuffer,
            CopyBufferToImageInfo2* pCopyBufferToImageInfo
        );

        [NativeName("vkCmdCopyBufferToImage2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyBufferToImage2")]
        static abstract void CmdCopyBufferToImage2(
            CommandBufferHandle commandBuffer,
            Ref<CopyBufferToImageInfo2> pCopyBufferToImageInfo
        );

        [NativeName("vkCmdCopyBufferToImage2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyBufferToImage2KHR")]
        static abstract void CmdCopyBufferToImage2KHR(
            CommandBufferHandle commandBuffer,
            CopyBufferToImageInfo2* pCopyBufferToImageInfo
        );

        [NativeName("vkCmdCopyBufferToImage2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyBufferToImage2KHR")]
        static abstract void CmdCopyBufferToImage2KHR(
            CommandBufferHandle commandBuffer,
            Ref<CopyBufferToImageInfo2> pCopyBufferToImageInfo
        );

        [NativeName("vkCmdCopyGpaSessionResultsAMD")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyGpaSessionResultsAMD")]
        static abstract void CmdCopyGpaSessionResultsAMD(
            CommandBufferHandle commandBuffer,
            GpaSessionHandleAMD gpaSession
        );

        [NativeName("vkCmdCopyImage")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyImage")]
        static abstract void CmdCopyImage(
            CommandBufferHandle commandBuffer,
            ImageHandle srcImage,
            ImageLayout srcImageLayout,
            ImageHandle dstImage,
            ImageLayout dstImageLayout,
            uint regionCount,
            ImageCopy* pRegions
        );

        [NativeName("vkCmdCopyImage")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyImage")]
        static abstract void CmdCopyImage(
            CommandBufferHandle commandBuffer,
            ImageHandle srcImage,
            ImageLayout srcImageLayout,
            ImageHandle dstImage,
            ImageLayout dstImageLayout,
            uint regionCount,
            Ref<ImageCopy> pRegions
        );

        [NativeName("vkCmdCopyImage")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyImage")]
        static abstract void CmdCopyImage(
            CommandBufferHandle commandBuffer,
            ImageHandle srcImage,
            ImageLayout srcImageLayout,
            ImageHandle dstImage,
            ImageLayout dstImageLayout,
            ImageCopy pRegions
        );

        [NativeName("vkCmdCopyImage2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyImage2")]
        static abstract void CmdCopyImage2(
            CommandBufferHandle commandBuffer,
            CopyImageInfo2* pCopyImageInfo
        );

        [NativeName("vkCmdCopyImage2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyImage2")]
        static abstract void CmdCopyImage2(
            CommandBufferHandle commandBuffer,
            Ref<CopyImageInfo2> pCopyImageInfo
        );

        [NativeName("vkCmdCopyImage2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyImage2KHR")]
        static abstract void CmdCopyImage2KHR(
            CommandBufferHandle commandBuffer,
            CopyImageInfo2* pCopyImageInfo
        );

        [NativeName("vkCmdCopyImage2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyImage2KHR")]
        static abstract void CmdCopyImage2KHR(
            CommandBufferHandle commandBuffer,
            Ref<CopyImageInfo2> pCopyImageInfo
        );

        [NativeName("vkCmdCopyImageToBuffer")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyImageToBuffer")]
        static abstract void CmdCopyImageToBuffer(
            CommandBufferHandle commandBuffer,
            ImageHandle srcImage,
            ImageLayout srcImageLayout,
            BufferHandle dstBuffer,
            uint regionCount,
            BufferImageCopy* pRegions
        );

        [NativeName("vkCmdCopyImageToBuffer")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyImageToBuffer")]
        static abstract void CmdCopyImageToBuffer(
            CommandBufferHandle commandBuffer,
            ImageHandle srcImage,
            ImageLayout srcImageLayout,
            BufferHandle dstBuffer,
            uint regionCount,
            Ref<BufferImageCopy> pRegions
        );

        [NativeName("vkCmdCopyImageToBuffer")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyImageToBuffer")]
        static abstract void CmdCopyImageToBuffer(
            CommandBufferHandle commandBuffer,
            ImageHandle srcImage,
            ImageLayout srcImageLayout,
            BufferHandle dstBuffer,
            BufferImageCopy pRegions
        );

        [NativeName("vkCmdCopyImageToBuffer2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyImageToBuffer2")]
        static abstract void CmdCopyImageToBuffer2(
            CommandBufferHandle commandBuffer,
            CopyImageToBufferInfo2* pCopyImageToBufferInfo
        );

        [NativeName("vkCmdCopyImageToBuffer2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyImageToBuffer2")]
        static abstract void CmdCopyImageToBuffer2(
            CommandBufferHandle commandBuffer,
            Ref<CopyImageToBufferInfo2> pCopyImageToBufferInfo
        );

        [NativeName("vkCmdCopyImageToBuffer2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyImageToBuffer2KHR")]
        static abstract void CmdCopyImageToBuffer2KHR(
            CommandBufferHandle commandBuffer,
            CopyImageToBufferInfo2* pCopyImageToBufferInfo
        );

        [NativeName("vkCmdCopyImageToBuffer2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyImageToBuffer2KHR")]
        static abstract void CmdCopyImageToBuffer2KHR(
            CommandBufferHandle commandBuffer,
            Ref<CopyImageToBufferInfo2> pCopyImageToBufferInfo
        );

        [NativeName("vkCmdCopyImageToMemoryKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyImageToMemoryKHR")]
        static abstract void CmdCopyImageToMemoryKHR(
            CommandBufferHandle commandBuffer,
            CopyDeviceMemoryImageInfoKHR* pCopyMemoryInfo
        );

        [NativeName("vkCmdCopyImageToMemoryKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyImageToMemoryKHR")]
        static abstract void CmdCopyImageToMemoryKHR(
            CommandBufferHandle commandBuffer,
            Ref<CopyDeviceMemoryImageInfoKHR> pCopyMemoryInfo
        );

        [NativeName("vkCmdCopyMemoryIndirectKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMemoryIndirectKHR")]
        static abstract void CmdCopyMemoryIndirectKHR(
            CommandBufferHandle commandBuffer,
            CopyMemoryIndirectInfoKHR* pCopyMemoryIndirectInfo
        );

        [NativeName("vkCmdCopyMemoryIndirectKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMemoryIndirectKHR")]
        static abstract void CmdCopyMemoryIndirectKHR(
            CommandBufferHandle commandBuffer,
            Ref<CopyMemoryIndirectInfoKHR> pCopyMemoryIndirectInfo
        );

        [NativeName("vkCmdCopyMemoryIndirectNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMemoryIndirectNV")]
        static abstract void CmdCopyMemoryIndirectNV(
            CommandBufferHandle commandBuffer,
            ulong copyBufferAddress,
            uint copyCount,
            uint stride
        );

        [NativeName("vkCmdCopyMemoryKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMemoryKHR")]
        static abstract void CmdCopyMemoryKHR(
            CommandBufferHandle commandBuffer,
            CopyDeviceMemoryInfoKHR* pCopyMemoryInfo
        );

        [NativeName("vkCmdCopyMemoryKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMemoryKHR")]
        static abstract void CmdCopyMemoryKHR(
            CommandBufferHandle commandBuffer,
            Ref<CopyDeviceMemoryInfoKHR> pCopyMemoryInfo
        );

        [NativeName("vkCmdCopyMemoryToAccelerationStructureKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMemoryToAccelerationStructureKHR")]
        static abstract void CmdCopyMemoryToAccelerationStructureKHR(
            CommandBufferHandle commandBuffer,
            CopyMemoryToAccelerationStructureInfoKHR* pInfo
        );

        [NativeName("vkCmdCopyMemoryToAccelerationStructureKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMemoryToAccelerationStructureKHR")]
        static abstract void CmdCopyMemoryToAccelerationStructureKHR(
            CommandBufferHandle commandBuffer,
            Ref<CopyMemoryToAccelerationStructureInfoKHR> pInfo
        );

        [NativeName("vkCmdCopyMemoryToImageIndirectKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMemoryToImageIndirectKHR")]
        static abstract void CmdCopyMemoryToImageIndirectKHR(
            CommandBufferHandle commandBuffer,
            CopyMemoryToImageIndirectInfoKHR* pCopyMemoryToImageIndirectInfo
        );

        [NativeName("vkCmdCopyMemoryToImageIndirectKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMemoryToImageIndirectKHR")]
        static abstract void CmdCopyMemoryToImageIndirectKHR(
            CommandBufferHandle commandBuffer,
            Ref<CopyMemoryToImageIndirectInfoKHR> pCopyMemoryToImageIndirectInfo
        );

        [NativeName("vkCmdCopyMemoryToImageIndirectNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMemoryToImageIndirectNV")]
        static abstract void CmdCopyMemoryToImageIndirectNV(
            CommandBufferHandle commandBuffer,
            ulong copyBufferAddress,
            uint copyCount,
            uint stride,
            ImageHandle dstImage,
            ImageLayout dstImageLayout,
            ImageSubresourceLayers* pImageSubresources
        );

        [NativeName("vkCmdCopyMemoryToImageIndirectNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMemoryToImageIndirectNV")]
        static abstract void CmdCopyMemoryToImageIndirectNV(
            CommandBufferHandle commandBuffer,
            ulong copyBufferAddress,
            uint copyCount,
            uint stride,
            ImageHandle dstImage,
            ImageLayout dstImageLayout,
            Ref<ImageSubresourceLayers> pImageSubresources
        );

        [NativeName("vkCmdCopyMemoryToImageIndirectNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMemoryToImageIndirectNV")]
        static abstract void CmdCopyMemoryToImageIndirectNV(
            CommandBufferHandle commandBuffer,
            ulong copyBufferAddress,
            uint stride,
            ImageHandle dstImage,
            ImageLayout dstImageLayout,
            ImageSubresourceLayers pImageSubresources
        );

        [NativeName("vkCmdCopyMemoryToImageKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMemoryToImageKHR")]
        static abstract void CmdCopyMemoryToImageKHR(
            CommandBufferHandle commandBuffer,
            CopyDeviceMemoryImageInfoKHR* pCopyMemoryInfo
        );

        [NativeName("vkCmdCopyMemoryToImageKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMemoryToImageKHR")]
        static abstract void CmdCopyMemoryToImageKHR(
            CommandBufferHandle commandBuffer,
            Ref<CopyDeviceMemoryImageInfoKHR> pCopyMemoryInfo
        );

        [NativeName("vkCmdCopyMemoryToMicromapEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMemoryToMicromapEXT")]
        static abstract void CmdCopyMemoryToMicromapEXT(
            CommandBufferHandle commandBuffer,
            CopyMemoryToMicromapInfoEXT* pInfo
        );

        [NativeName("vkCmdCopyMemoryToMicromapEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMemoryToMicromapEXT")]
        static abstract void CmdCopyMemoryToMicromapEXT(
            CommandBufferHandle commandBuffer,
            Ref<CopyMemoryToMicromapInfoEXT> pInfo
        );

        [NativeName("vkCmdCopyMicromapEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMicromapEXT")]
        static abstract void CmdCopyMicromapEXT(
            CommandBufferHandle commandBuffer,
            CopyMicromapInfoEXT* pInfo
        );

        [NativeName("vkCmdCopyMicromapEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMicromapEXT")]
        static abstract void CmdCopyMicromapEXT(
            CommandBufferHandle commandBuffer,
            Ref<CopyMicromapInfoEXT> pInfo
        );

        [NativeName("vkCmdCopyMicromapToMemoryEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMicromapToMemoryEXT")]
        static abstract void CmdCopyMicromapToMemoryEXT(
            CommandBufferHandle commandBuffer,
            CopyMicromapToMemoryInfoEXT* pInfo
        );

        [NativeName("vkCmdCopyMicromapToMemoryEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMicromapToMemoryEXT")]
        static abstract void CmdCopyMicromapToMemoryEXT(
            CommandBufferHandle commandBuffer,
            Ref<CopyMicromapToMemoryInfoEXT> pInfo
        );

        [NativeName("vkCmdCopyQueryPoolResults")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyQueryPoolResults")]
        static abstract void CmdCopyQueryPoolResults(
            CommandBufferHandle commandBuffer,
            QueryPoolHandle queryPool,
            uint firstQuery,
            uint queryCount,
            BufferHandle dstBuffer,
            ulong dstOffset,
            ulong stride,
            QueryResultFlags flags
        );

        [NativeName("vkCmdCopyQueryPoolResultsToMemoryKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyQueryPoolResultsToMemoryKHR")]
        static abstract void CmdCopyQueryPoolResultsToMemoryKHR(
            CommandBufferHandle commandBuffer,
            QueryPoolHandle queryPool,
            uint firstQuery,
            uint queryCount,
            StridedDeviceAddressRangeKHR* pDstRange,
            AddressCommandFlagsKHR dstFlags,
            QueryResultFlags queryResultFlags
        );

        [NativeName("vkCmdCopyQueryPoolResultsToMemoryKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyQueryPoolResultsToMemoryKHR")]
        static abstract void CmdCopyQueryPoolResultsToMemoryKHR(
            CommandBufferHandle commandBuffer,
            QueryPoolHandle queryPool,
            uint firstQuery,
            uint queryCount,
            Ref<StridedDeviceAddressRangeKHR> pDstRange,
            AddressCommandFlagsKHR dstFlags,
            QueryResultFlags queryResultFlags
        );

        [NativeName("vkCmdCopyTensorARM")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyTensorARM")]
        static abstract void CmdCopyTensorARM(
            CommandBufferHandle commandBuffer,
            CopyTensorInfoARM* pCopyTensorInfo
        );

        [NativeName("vkCmdCopyTensorARM")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCopyTensorARM")]
        static abstract void CmdCopyTensorARM(
            CommandBufferHandle commandBuffer,
            Ref<CopyTensorInfoARM> pCopyTensorInfo
        );

        [NativeName("vkCmdCuLaunchKernelNVX")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCuLaunchKernelNVX")]
        static abstract void CmdCuLaunchKernelNVX(
            CommandBufferHandle commandBuffer,
            CuLaunchInfoNVX* pLaunchInfo
        );

        [NativeName("vkCmdCuLaunchKernelNVX")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdCuLaunchKernelNVX")]
        static abstract void CmdCuLaunchKernelNVX(
            CommandBufferHandle commandBuffer,
            Ref<CuLaunchInfoNVX> pLaunchInfo
        );

        [NativeName("vkCmdDebugMarkerBeginEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDebugMarkerBeginEXT")]
        static abstract void CmdDebugMarkerBeginEXT(
            CommandBufferHandle commandBuffer,
            DebugMarkerMarkerInfoEXT* pMarkerInfo
        );

        [NativeName("vkCmdDebugMarkerBeginEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDebugMarkerBeginEXT")]
        static abstract void CmdDebugMarkerBeginEXT(
            CommandBufferHandle commandBuffer,
            Ref<DebugMarkerMarkerInfoEXT> pMarkerInfo
        );

        [NativeName("vkCmdDebugMarkerEndEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDebugMarkerEndEXT")]
        static abstract void CmdDebugMarkerEndEXT(CommandBufferHandle commandBuffer);

        [NativeName("vkCmdDebugMarkerInsertEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDebugMarkerInsertEXT")]
        static abstract void CmdDebugMarkerInsertEXT(
            CommandBufferHandle commandBuffer,
            DebugMarkerMarkerInfoEXT* pMarkerInfo
        );

        [NativeName("vkCmdDebugMarkerInsertEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDebugMarkerInsertEXT")]
        static abstract void CmdDebugMarkerInsertEXT(
            CommandBufferHandle commandBuffer,
            Ref<DebugMarkerMarkerInfoEXT> pMarkerInfo
        );

        [NativeName("vkCmdDecodeVideoKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDecodeVideoKHR")]
        static abstract void CmdDecodeVideoKHR(
            CommandBufferHandle commandBuffer,
            VideoDecodeInfoKHR* pDecodeInfo
        );

        [NativeName("vkCmdDecodeVideoKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDecodeVideoKHR")]
        static abstract void CmdDecodeVideoKHR(
            CommandBufferHandle commandBuffer,
            Ref<VideoDecodeInfoKHR> pDecodeInfo
        );

        [NativeName("vkCmdDecompressMemoryEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDecompressMemoryEXT")]
        static abstract void CmdDecompressMemoryEXT(
            CommandBufferHandle commandBuffer,
            DecompressMemoryInfoEXT* pDecompressMemoryInfoEXT
        );

        [NativeName("vkCmdDecompressMemoryEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDecompressMemoryEXT")]
        static abstract void CmdDecompressMemoryEXT(
            CommandBufferHandle commandBuffer,
            Ref<DecompressMemoryInfoEXT> pDecompressMemoryInfoEXT
        );

        [NativeName("vkCmdDecompressMemoryIndirectCountEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDecompressMemoryIndirectCountEXT")]
        static abstract void CmdDecompressMemoryIndirectCountEXT(
            CommandBufferHandle commandBuffer,
            MemoryDecompressionMethodFlagsEXT decompressionMethod,
            ulong indirectCommandsAddress,
            ulong indirectCommandsCountAddress,
            uint maxDecompressionCount,
            uint stride
        );

        [NativeName("vkCmdDecompressMemoryIndirectCountNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDecompressMemoryIndirectCountNV")]
        static abstract void CmdDecompressMemoryIndirectCountNV(
            CommandBufferHandle commandBuffer,
            ulong indirectCommandsAddress,
            ulong indirectCommandsCountAddress,
            uint stride
        );

        [NativeName("vkCmdDecompressMemoryNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDecompressMemoryNV")]
        static abstract void CmdDecompressMemoryNV(
            CommandBufferHandle commandBuffer,
            uint decompressRegionCount,
            DecompressMemoryRegionNV* pDecompressMemoryRegions
        );

        [NativeName("vkCmdDecompressMemoryNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDecompressMemoryNV")]
        static abstract void CmdDecompressMemoryNV(
            CommandBufferHandle commandBuffer,
            uint decompressRegionCount,
            Ref<DecompressMemoryRegionNV> pDecompressMemoryRegions
        );

        [NativeName("vkCmdDecompressMemoryNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDecompressMemoryNV")]
        static abstract void CmdDecompressMemoryNV(
            CommandBufferHandle commandBuffer,
            DecompressMemoryRegionNV pDecompressMemoryRegions
        );

        [NativeName("vkCmdDispatch")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDispatch")]
        static abstract void CmdDispatch(
            CommandBufferHandle commandBuffer,
            uint groupCountX,
            uint groupCountY,
            uint groupCountZ
        );

        [NativeName("vkCmdDispatchBase")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDispatchBase")]
        static abstract void CmdDispatchBase(
            CommandBufferHandle commandBuffer,
            uint baseGroupX,
            uint baseGroupY,
            uint baseGroupZ,
            uint groupCountX,
            uint groupCountY,
            uint groupCountZ
        );

        [NativeName("vkCmdDispatchBaseKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDispatchBaseKHR")]
        static abstract void CmdDispatchBaseKHR(
            CommandBufferHandle commandBuffer,
            uint baseGroupX,
            uint baseGroupY,
            uint baseGroupZ,
            uint groupCountX,
            uint groupCountY,
            uint groupCountZ
        );

        [NativeName("vkCmdDispatchDataGraphARM")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDispatchDataGraphARM")]
        static abstract void CmdDispatchDataGraphARM(
            CommandBufferHandle commandBuffer,
            DataGraphPipelineSessionHandleARM session,
            DataGraphPipelineDispatchInfoARM* pInfo
        );

        [NativeName("vkCmdDispatchDataGraphARM")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDispatchDataGraphARM")]
        static abstract void CmdDispatchDataGraphARM(
            CommandBufferHandle commandBuffer,
            DataGraphPipelineSessionHandleARM session,
            Ref<DataGraphPipelineDispatchInfoARM> pInfo
        );

        [NativeName("vkCmdDispatchIndirect")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDispatchIndirect")]
        static abstract void CmdDispatchIndirect(
            CommandBufferHandle commandBuffer,
            BufferHandle buffer,
            ulong offset
        );

        [NativeName("vkCmdDispatchIndirect2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDispatchIndirect2KHR")]
        static abstract void CmdDispatchIndirect2KHR(
            CommandBufferHandle commandBuffer,
            DispatchIndirect2InfoKHR* pInfo
        );

        [NativeName("vkCmdDispatchIndirect2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDispatchIndirect2KHR")]
        static abstract void CmdDispatchIndirect2KHR(
            CommandBufferHandle commandBuffer,
            Ref<DispatchIndirect2InfoKHR> pInfo
        );

        [NativeName("vkCmdDispatchTileQCOM")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDispatchTileQCOM")]
        static abstract void CmdDispatchTileQCOM(
            CommandBufferHandle commandBuffer,
            DispatchTileInfoQCOM* pDispatchTileInfo
        );

        [NativeName("vkCmdDispatchTileQCOM")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDispatchTileQCOM")]
        static abstract void CmdDispatchTileQCOM(
            CommandBufferHandle commandBuffer,
            Ref<DispatchTileInfoQCOM> pDispatchTileInfo
        );

        [NativeName("vkCmdDraw")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDraw")]
        static abstract void CmdDraw(
            CommandBufferHandle commandBuffer,
            uint vertexCount,
            uint instanceCount,
            uint firstVertex,
            uint firstInstance
        );

        [NativeName("vkCmdDrawClusterHUAWEI")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawClusterHUAWEI")]
        static abstract void CmdDrawClusterHUAWEI(
            CommandBufferHandle commandBuffer,
            uint groupCountX,
            uint groupCountY,
            uint groupCountZ
        );

        [NativeName("vkCmdDrawClusterIndirectHUAWEI")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawClusterIndirectHUAWEI")]
        static abstract void CmdDrawClusterIndirectHUAWEI(
            CommandBufferHandle commandBuffer,
            BufferHandle buffer,
            ulong offset
        );

        [NativeName("vkCmdDrawIndexed")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndexed")]
        static abstract void CmdDrawIndexed(
            CommandBufferHandle commandBuffer,
            uint indexCount,
            uint instanceCount,
            uint firstIndex,
            int vertexOffset,
            uint firstInstance
        );

        [NativeName("vkCmdDrawIndexedIndirect")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndexedIndirect")]
        static abstract void CmdDrawIndexedIndirect(
            CommandBufferHandle commandBuffer,
            BufferHandle buffer,
            ulong offset,
            uint drawCount,
            uint stride
        );

        [NativeName("vkCmdDrawIndexedIndirect2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndexedIndirect2KHR")]
        static abstract void CmdDrawIndexedIndirect2KHR(
            CommandBufferHandle commandBuffer,
            DrawIndirect2InfoKHR* pInfo
        );

        [NativeName("vkCmdDrawIndexedIndirect2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndexedIndirect2KHR")]
        static abstract void CmdDrawIndexedIndirect2KHR(
            CommandBufferHandle commandBuffer,
            Ref<DrawIndirect2InfoKHR> pInfo
        );

        [NativeName("vkCmdDrawIndexedIndirectCount")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndexedIndirectCount")]
        static abstract void CmdDrawIndexedIndirectCount(
            CommandBufferHandle commandBuffer,
            BufferHandle buffer,
            ulong offset,
            BufferHandle countBuffer,
            ulong countBufferOffset,
            uint maxDrawCount,
            uint stride
        );

        [NativeName("vkCmdDrawIndexedIndirectCount2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndexedIndirectCount2KHR")]
        static abstract void CmdDrawIndexedIndirectCount2KHR(
            CommandBufferHandle commandBuffer,
            DrawIndirectCount2InfoKHR* pInfo
        );

        [NativeName("vkCmdDrawIndexedIndirectCount2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndexedIndirectCount2KHR")]
        static abstract void CmdDrawIndexedIndirectCount2KHR(
            CommandBufferHandle commandBuffer,
            Ref<DrawIndirectCount2InfoKHR> pInfo
        );

        [NativeName("vkCmdDrawIndexedIndirectCountAMD")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndexedIndirectCountAMD")]
        static abstract void CmdDrawIndexedIndirectCountAMD(
            CommandBufferHandle commandBuffer,
            BufferHandle buffer,
            ulong offset,
            BufferHandle countBuffer,
            ulong countBufferOffset,
            uint maxDrawCount,
            uint stride
        );

        [NativeName("vkCmdDrawIndexedIndirectCountKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndexedIndirectCountKHR")]
        static abstract void CmdDrawIndexedIndirectCountKHR(
            CommandBufferHandle commandBuffer,
            BufferHandle buffer,
            ulong offset,
            BufferHandle countBuffer,
            ulong countBufferOffset,
            uint maxDrawCount,
            uint stride
        );

        [NativeName("vkCmdDrawIndirect")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndirect")]
        static abstract void CmdDrawIndirect(
            CommandBufferHandle commandBuffer,
            BufferHandle buffer,
            ulong offset,
            uint drawCount,
            uint stride
        );

        [NativeName("vkCmdDrawIndirect2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndirect2KHR")]
        static abstract void CmdDrawIndirect2KHR(
            CommandBufferHandle commandBuffer,
            DrawIndirect2InfoKHR* pInfo
        );

        [NativeName("vkCmdDrawIndirect2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndirect2KHR")]
        static abstract void CmdDrawIndirect2KHR(
            CommandBufferHandle commandBuffer,
            Ref<DrawIndirect2InfoKHR> pInfo
        );

        [NativeName("vkCmdDrawIndirectByteCount2EXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndirectByteCount2EXT")]
        static abstract void CmdDrawIndirectByteCount2EXT(
            CommandBufferHandle commandBuffer,
            uint instanceCount,
            uint firstInstance,
            BindTransformFeedbackBuffer2InfoEXT* pCounterInfo,
            uint counterOffset,
            uint vertexStride
        );

        [NativeName("vkCmdDrawIndirectByteCount2EXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndirectByteCount2EXT")]
        static abstract void CmdDrawIndirectByteCount2EXT(
            CommandBufferHandle commandBuffer,
            uint instanceCount,
            uint firstInstance,
            Ref<BindTransformFeedbackBuffer2InfoEXT> pCounterInfo,
            uint counterOffset,
            uint vertexStride
        );

        [NativeName("vkCmdDrawIndirectByteCountEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndirectByteCountEXT")]
        static abstract void CmdDrawIndirectByteCountEXT(
            CommandBufferHandle commandBuffer,
            uint instanceCount,
            uint firstInstance,
            BufferHandle counterBuffer,
            ulong counterBufferOffset,
            uint counterOffset,
            uint vertexStride
        );

        [NativeName("vkCmdDrawIndirectCount")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndirectCount")]
        static abstract void CmdDrawIndirectCount(
            CommandBufferHandle commandBuffer,
            BufferHandle buffer,
            ulong offset,
            BufferHandle countBuffer,
            ulong countBufferOffset,
            uint maxDrawCount,
            uint stride
        );

        [NativeName("vkCmdDrawIndirectCount2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndirectCount2KHR")]
        static abstract void CmdDrawIndirectCount2KHR(
            CommandBufferHandle commandBuffer,
            DrawIndirectCount2InfoKHR* pInfo
        );

        [NativeName("vkCmdDrawIndirectCount2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndirectCount2KHR")]
        static abstract void CmdDrawIndirectCount2KHR(
            CommandBufferHandle commandBuffer,
            Ref<DrawIndirectCount2InfoKHR> pInfo
        );

        [NativeName("vkCmdDrawIndirectCountAMD")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndirectCountAMD")]
        static abstract void CmdDrawIndirectCountAMD(
            CommandBufferHandle commandBuffer,
            BufferHandle buffer,
            ulong offset,
            BufferHandle countBuffer,
            ulong countBufferOffset,
            uint maxDrawCount,
            uint stride
        );

        [NativeName("vkCmdDrawIndirectCountKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndirectCountKHR")]
        static abstract void CmdDrawIndirectCountKHR(
            CommandBufferHandle commandBuffer,
            BufferHandle buffer,
            ulong offset,
            BufferHandle countBuffer,
            ulong countBufferOffset,
            uint maxDrawCount,
            uint stride
        );

        [NativeName("vkCmdDrawMeshTasksEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawMeshTasksEXT")]
        static abstract void CmdDrawMeshTasksEXT(
            CommandBufferHandle commandBuffer,
            uint groupCountX,
            uint groupCountY,
            uint groupCountZ
        );

        [NativeName("vkCmdDrawMeshTasksIndirect2EXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawMeshTasksIndirect2EXT")]
        static abstract void CmdDrawMeshTasksIndirect2EXT(
            CommandBufferHandle commandBuffer,
            DrawIndirect2InfoKHR* pInfo
        );

        [NativeName("vkCmdDrawMeshTasksIndirect2EXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawMeshTasksIndirect2EXT")]
        static abstract void CmdDrawMeshTasksIndirect2EXT(
            CommandBufferHandle commandBuffer,
            Ref<DrawIndirect2InfoKHR> pInfo
        );

        [NativeName("vkCmdDrawMeshTasksIndirectCount2EXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawMeshTasksIndirectCount2EXT")]
        static abstract void CmdDrawMeshTasksIndirectCount2EXT(
            CommandBufferHandle commandBuffer,
            DrawIndirectCount2InfoKHR* pInfo
        );

        [NativeName("vkCmdDrawMeshTasksIndirectCount2EXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawMeshTasksIndirectCount2EXT")]
        static abstract void CmdDrawMeshTasksIndirectCount2EXT(
            CommandBufferHandle commandBuffer,
            Ref<DrawIndirectCount2InfoKHR> pInfo
        );

        [NativeName("vkCmdDrawMeshTasksIndirectCountEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawMeshTasksIndirectCountEXT")]
        static abstract void CmdDrawMeshTasksIndirectCountEXT(
            CommandBufferHandle commandBuffer,
            BufferHandle buffer,
            ulong offset,
            BufferHandle countBuffer,
            ulong countBufferOffset,
            uint maxDrawCount,
            uint stride
        );

        [NativeName("vkCmdDrawMeshTasksIndirectCountNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawMeshTasksIndirectCountNV")]
        static abstract void CmdDrawMeshTasksIndirectCountNV(
            CommandBufferHandle commandBuffer,
            BufferHandle buffer,
            ulong offset,
            BufferHandle countBuffer,
            ulong countBufferOffset,
            uint maxDrawCount,
            uint stride
        );

        [NativeName("vkCmdDrawMeshTasksIndirectEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawMeshTasksIndirectEXT")]
        static abstract void CmdDrawMeshTasksIndirectEXT(
            CommandBufferHandle commandBuffer,
            BufferHandle buffer,
            ulong offset,
            uint drawCount,
            uint stride
        );

        [NativeName("vkCmdDrawMeshTasksIndirectNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawMeshTasksIndirectNV")]
        static abstract void CmdDrawMeshTasksIndirectNV(
            CommandBufferHandle commandBuffer,
            BufferHandle buffer,
            ulong offset,
            uint drawCount,
            uint stride
        );

        [NativeName("vkCmdDrawMeshTasksNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawMeshTasksNV")]
        static abstract void CmdDrawMeshTasksNV(
            CommandBufferHandle commandBuffer,
            uint taskCount,
            uint firstTask
        );

        [NativeName("vkCmdDrawMultiEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawMultiEXT")]
        static abstract void CmdDrawMultiEXT(
            CommandBufferHandle commandBuffer,
            uint drawCount,
            MultiDrawInfoEXT* pVertexInfo,
            uint instanceCount,
            uint firstInstance,
            uint stride
        );

        [NativeName("vkCmdDrawMultiEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawMultiEXT")]
        static abstract void CmdDrawMultiEXT(
            CommandBufferHandle commandBuffer,
            uint drawCount,
            Ref<MultiDrawInfoEXT> pVertexInfo,
            uint instanceCount,
            uint firstInstance,
            uint stride
        );

        [NativeName("vkCmdDrawMultiEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawMultiEXT")]
        static abstract void CmdDrawMultiEXT(
            CommandBufferHandle commandBuffer,
            MultiDrawInfoEXT pVertexInfo,
            uint instanceCount,
            uint firstInstance,
            uint stride
        );

        [NativeName("vkCmdDrawMultiIndexedEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawMultiIndexedEXT")]
        static abstract void CmdDrawMultiIndexedEXT(
            CommandBufferHandle commandBuffer,
            uint drawCount,
            MultiDrawIndexedInfoEXT* pIndexInfo,
            uint instanceCount,
            uint firstInstance,
            uint stride,
            int* pVertexOffset
        );

        [NativeName("vkCmdDrawMultiIndexedEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawMultiIndexedEXT")]
        static abstract void CmdDrawMultiIndexedEXT(
            CommandBufferHandle commandBuffer,
            uint drawCount,
            Ref<MultiDrawIndexedInfoEXT> pIndexInfo,
            uint instanceCount,
            uint firstInstance,
            uint stride,
            Ref<int> pVertexOffset
        );

        [NativeName("vkCmdDrawMultiIndexedEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdDrawMultiIndexedEXT")]
        static abstract void CmdDrawMultiIndexedEXT(
            CommandBufferHandle commandBuffer,
            MultiDrawIndexedInfoEXT pIndexInfo,
            uint instanceCount,
            uint firstInstance,
            uint stride,
            Ref<int> pVertexOffset
        );

        [NativeName("vkCmdEncodeVideoKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdEncodeVideoKHR")]
        static abstract void CmdEncodeVideoKHR(
            CommandBufferHandle commandBuffer,
            VideoEncodeInfoKHR* pEncodeInfo
        );

        [NativeName("vkCmdEncodeVideoKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdEncodeVideoKHR")]
        static abstract void CmdEncodeVideoKHR(
            CommandBufferHandle commandBuffer,
            Ref<VideoEncodeInfoKHR> pEncodeInfo
        );

        [NativeName("vkCmdEndConditionalRenderingEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdEndConditionalRenderingEXT")]
        static abstract void CmdEndConditionalRenderingEXT(CommandBufferHandle commandBuffer);

        [NativeName("vkCmdEndDebugUtilsLabelEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdEndDebugUtilsLabelEXT")]
        static abstract void CmdEndDebugUtilsLabelEXT(CommandBufferHandle commandBuffer);

        [NativeName("vkCmdEndGpaSampleAMD")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdEndGpaSampleAMD")]
        static abstract void CmdEndGpaSampleAMD(
            CommandBufferHandle commandBuffer,
            GpaSessionHandleAMD gpaSession,
            uint sampleID
        );

        [NativeName("vkCmdEndGpaSessionAMD")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdEndGpaSessionAMD")]
        static abstract Result CmdEndGpaSessionAMD(
            CommandBufferHandle commandBuffer,
            GpaSessionHandleAMD gpaSession
        );

        [NativeName("vkCmdEndPerTileExecutionQCOM")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdEndPerTileExecutionQCOM")]
        static abstract void CmdEndPerTileExecutionQCOM(
            CommandBufferHandle commandBuffer,
            PerTileEndInfoQCOM* pPerTileEndInfo
        );

        [NativeName("vkCmdEndPerTileExecutionQCOM")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdEndPerTileExecutionQCOM")]
        static abstract void CmdEndPerTileExecutionQCOM(
            CommandBufferHandle commandBuffer,
            Ref<PerTileEndInfoQCOM> pPerTileEndInfo
        );

        [NativeName("vkCmdEndQuery")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdEndQuery")]
        static abstract void CmdEndQuery(
            CommandBufferHandle commandBuffer,
            QueryPoolHandle queryPool,
            uint query
        );

        [NativeName("vkCmdEndQueryIndexedEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdEndQueryIndexedEXT")]
        static abstract void CmdEndQueryIndexedEXT(
            CommandBufferHandle commandBuffer,
            QueryPoolHandle queryPool,
            uint query,
            uint index
        );

        [NativeName("vkCmdEndRendering")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdEndRendering")]
        static abstract void CmdEndRendering(CommandBufferHandle commandBuffer);

        [NativeName("vkCmdEndRendering2EXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdEndRendering2EXT")]
        static abstract void CmdEndRendering2EXT(
            CommandBufferHandle commandBuffer,
            RenderingEndInfoKHR* pRenderingEndInfo
        );

        [NativeName("vkCmdEndRendering2EXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdEndRendering2EXT")]
        static abstract void CmdEndRendering2EXT(
            CommandBufferHandle commandBuffer,
            Ref<RenderingEndInfoKHR> pRenderingEndInfo
        );

        [NativeName("vkCmdEndRendering2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdEndRendering2KHR")]
        static abstract void CmdEndRendering2KHR(
            CommandBufferHandle commandBuffer,
            RenderingEndInfoKHR* pRenderingEndInfo
        );

        [NativeName("vkCmdEndRendering2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdEndRendering2KHR")]
        static abstract void CmdEndRendering2KHR(
            CommandBufferHandle commandBuffer,
            Ref<RenderingEndInfoKHR> pRenderingEndInfo
        );

        [NativeName("vkCmdEndRenderingKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdEndRenderingKHR")]
        static abstract void CmdEndRenderingKHR(CommandBufferHandle commandBuffer);

        [NativeName("vkCmdEndRenderPass")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdEndRenderPass")]
        static abstract void CmdEndRenderPass(CommandBufferHandle commandBuffer);

        [NativeName("vkCmdEndRenderPass2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdEndRenderPass2")]
        static abstract void CmdEndRenderPass2(
            CommandBufferHandle commandBuffer,
            SubpassEndInfo* pSubpassEndInfo
        );

        [NativeName("vkCmdEndRenderPass2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdEndRenderPass2")]
        static abstract void CmdEndRenderPass2(
            CommandBufferHandle commandBuffer,
            Ref<SubpassEndInfo> pSubpassEndInfo
        );

        [NativeName("vkCmdEndRenderPass2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdEndRenderPass2KHR")]
        static abstract void CmdEndRenderPass2KHR(
            CommandBufferHandle commandBuffer,
            SubpassEndInfo* pSubpassEndInfo
        );

        [NativeName("vkCmdEndRenderPass2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdEndRenderPass2KHR")]
        static abstract void CmdEndRenderPass2KHR(
            CommandBufferHandle commandBuffer,
            Ref<SubpassEndInfo> pSubpassEndInfo
        );

        [NativeName("vkCmdEndShaderInstrumentationARM")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdEndShaderInstrumentationARM")]
        static abstract void CmdEndShaderInstrumentationARM(CommandBufferHandle commandBuffer);

        [NativeName("vkCmdEndTransformFeedback2EXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdEndTransformFeedback2EXT")]
        static abstract void CmdEndTransformFeedback2EXT(
            CommandBufferHandle commandBuffer,
            uint firstCounterRange,
            uint counterRangeCount,
            BindTransformFeedbackBuffer2InfoEXT* pCounterInfos
        );

        [NativeName("vkCmdEndTransformFeedback2EXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdEndTransformFeedback2EXT")]
        static abstract void CmdEndTransformFeedback2EXT(
            CommandBufferHandle commandBuffer,
            uint firstCounterRange,
            uint counterRangeCount,
            Ref<BindTransformFeedbackBuffer2InfoEXT> pCounterInfos
        );

        [NativeName("vkCmdEndTransformFeedback2EXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdEndTransformFeedback2EXT")]
        static abstract void CmdEndTransformFeedback2EXT(
            CommandBufferHandle commandBuffer,
            uint firstCounterRange,
            BindTransformFeedbackBuffer2InfoEXT pCounterInfos
        );

        [NativeName("vkCmdEndTransformFeedbackEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdEndTransformFeedbackEXT")]
        static abstract void CmdEndTransformFeedbackEXT(
            CommandBufferHandle commandBuffer,
            uint firstCounterBuffer,
            uint counterBufferCount,
            BufferHandle* pCounterBuffers,
            ulong* pCounterBufferOffsets
        );

        [NativeName("vkCmdEndTransformFeedbackEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdEndTransformFeedbackEXT")]
        static abstract void CmdEndTransformFeedbackEXT(
            CommandBufferHandle commandBuffer,
            uint firstCounterBuffer,
            uint counterBufferCount,
            Ref<BufferHandle> pCounterBuffers,
            Ref<ulong> pCounterBufferOffsets
        );

        [NativeName("vkCmdEndVideoCodingKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdEndVideoCodingKHR")]
        static abstract void CmdEndVideoCodingKHR(
            CommandBufferHandle commandBuffer,
            VideoEndCodingInfoKHR* pEndCodingInfo
        );

        [NativeName("vkCmdEndVideoCodingKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdEndVideoCodingKHR")]
        static abstract void CmdEndVideoCodingKHR(
            CommandBufferHandle commandBuffer,
            Ref<VideoEndCodingInfoKHR> pEndCodingInfo
        );

        [NativeName("vkCmdExecuteCommands")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdExecuteCommands")]
        static abstract void CmdExecuteCommand(
            CommandBufferHandle commandBuffer,
            CommandBufferHandle pCommandBuffers
        );

        [NativeName("vkCmdExecuteCommands")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdExecuteCommands")]
        static abstract void CmdExecuteCommands(
            CommandBufferHandle commandBuffer,
            uint commandBufferCount,
            CommandBufferHandle* pCommandBuffers
        );

        [NativeName("vkCmdExecuteCommands")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdExecuteCommands")]
        static abstract void CmdExecuteCommands(
            CommandBufferHandle commandBuffer,
            uint commandBufferCount,
            Ref<CommandBufferHandle> pCommandBuffers
        );

        [NativeName("vkCmdExecuteGeneratedCommandsEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdExecuteGeneratedCommandsEXT")]
        static abstract void CmdExecuteGeneratedCommandsEXT(
            CommandBufferHandle commandBuffer,
            uint isPreprocessed,
            GeneratedCommandsInfoEXT* pGeneratedCommandsInfo
        );

        [NativeName("vkCmdExecuteGeneratedCommandsEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdExecuteGeneratedCommandsEXT")]
        static abstract void CmdExecuteGeneratedCommandsEXT(
            CommandBufferHandle commandBuffer,
            MaybeBool<uint> isPreprocessed,
            Ref<GeneratedCommandsInfoEXT> pGeneratedCommandsInfo
        );

        [NativeName("vkCmdExecuteGeneratedCommandsNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdExecuteGeneratedCommandsNV")]
        static abstract void CmdExecuteGeneratedCommandsNV(
            CommandBufferHandle commandBuffer,
            uint isPreprocessed,
            GeneratedCommandsInfoNV* pGeneratedCommandsInfo
        );

        [NativeName("vkCmdExecuteGeneratedCommandsNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdExecuteGeneratedCommandsNV")]
        static abstract void CmdExecuteGeneratedCommandsNV(
            CommandBufferHandle commandBuffer,
            MaybeBool<uint> isPreprocessed,
            Ref<GeneratedCommandsInfoNV> pGeneratedCommandsInfo
        );

        [NativeName("vkCmdFillBuffer")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdFillBuffer")]
        static abstract void CmdFillBuffer(
            CommandBufferHandle commandBuffer,
            BufferHandle dstBuffer,
            ulong dstOffset,
            ulong size,
            uint data
        );

        [NativeName("vkCmdFillMemoryKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdFillMemoryKHR")]
        static abstract void CmdFillMemoryKHR(
            CommandBufferHandle commandBuffer,
            DeviceAddressRangeKHR* pDstRange,
            AddressCommandFlagsKHR dstFlags,
            uint data
        );

        [NativeName("vkCmdFillMemoryKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdFillMemoryKHR")]
        static abstract void CmdFillMemoryKHR(
            CommandBufferHandle commandBuffer,
            Ref<DeviceAddressRangeKHR> pDstRange,
            AddressCommandFlagsKHR dstFlags,
            uint data
        );

        [NativeName("vkCmdInsertDebugUtilsLabelEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdInsertDebugUtilsLabelEXT")]
        static abstract void CmdInsertDebugUtilsLabelEXT(
            CommandBufferHandle commandBuffer,
            DebugUtilsLabelEXT* pLabelInfo
        );

        [NativeName("vkCmdInsertDebugUtilsLabelEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdInsertDebugUtilsLabelEXT")]
        static abstract void CmdInsertDebugUtilsLabelEXT(
            CommandBufferHandle commandBuffer,
            Ref<DebugUtilsLabelEXT> pLabelInfo
        );

        [NativeName("vkCmdNextSubpass")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdNextSubpass")]
        static abstract void CmdNextSubpass(
            CommandBufferHandle commandBuffer,
            SubpassContents contents
        );

        [NativeName("vkCmdNextSubpass2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdNextSubpass2")]
        static abstract void CmdNextSubpass2(
            CommandBufferHandle commandBuffer,
            SubpassBeginInfo* pSubpassBeginInfo,
            SubpassEndInfo* pSubpassEndInfo
        );

        [NativeName("vkCmdNextSubpass2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdNextSubpass2")]
        static abstract void CmdNextSubpass2(
            CommandBufferHandle commandBuffer,
            Ref<SubpassBeginInfo> pSubpassBeginInfo,
            Ref<SubpassEndInfo> pSubpassEndInfo
        );

        [NativeName("vkCmdNextSubpass2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdNextSubpass2KHR")]
        static abstract void CmdNextSubpass2KHR(
            CommandBufferHandle commandBuffer,
            SubpassBeginInfo* pSubpassBeginInfo,
            SubpassEndInfo* pSubpassEndInfo
        );

        [NativeName("vkCmdNextSubpass2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdNextSubpass2KHR")]
        static abstract void CmdNextSubpass2KHR(
            CommandBufferHandle commandBuffer,
            Ref<SubpassBeginInfo> pSubpassBeginInfo,
            Ref<SubpassEndInfo> pSubpassEndInfo
        );

        [NativeName("vkCmdOpticalFlowExecuteNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdOpticalFlowExecuteNV")]
        static abstract void CmdOpticalFlowExecuteNV(
            CommandBufferHandle commandBuffer,
            OpticalFlowSessionHandleNV session,
            OpticalFlowExecuteInfoNV* pExecuteInfo
        );

        [NativeName("vkCmdOpticalFlowExecuteNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdOpticalFlowExecuteNV")]
        static abstract void CmdOpticalFlowExecuteNV(
            CommandBufferHandle commandBuffer,
            OpticalFlowSessionHandleNV session,
            Ref<OpticalFlowExecuteInfoNV> pExecuteInfo
        );

        [NativeName("vkCmdPipelineBarrier")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPipelineBarrier")]
        static abstract void CmdPipelineBarrier(
            CommandBufferHandle commandBuffer,
            PipelineStageFlags srcStageMask,
            PipelineStageFlags dstStageMask,
            DependencyFlags dependencyFlags,
            uint memoryBarrierCount,
            MemoryBarrier* pMemoryBarriers,
            uint bufferMemoryBarrierCount,
            BufferMemoryBarrier* pBufferMemoryBarriers,
            uint imageMemoryBarrierCount,
            ImageMemoryBarrier* pImageMemoryBarriers
        );

        [NativeName("vkCmdPipelineBarrier")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPipelineBarrier")]
        static abstract void CmdPipelineBarrier(
            CommandBufferHandle commandBuffer,
            PipelineStageFlags srcStageMask,
            PipelineStageFlags dstStageMask,
            DependencyFlags dependencyFlags,
            uint memoryBarrierCount,
            Ref<MemoryBarrier> pMemoryBarriers,
            uint bufferMemoryBarrierCount,
            Ref<BufferMemoryBarrier> pBufferMemoryBarriers,
            uint imageMemoryBarrierCount,
            Ref<ImageMemoryBarrier> pImageMemoryBarriers
        );

        [NativeName("vkCmdPipelineBarrier2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPipelineBarrier2")]
        static abstract void CmdPipelineBarrier2(
            CommandBufferHandle commandBuffer,
            DependencyInfo* pDependencyInfo
        );

        [NativeName("vkCmdPipelineBarrier2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPipelineBarrier2")]
        static abstract void CmdPipelineBarrier2(
            CommandBufferHandle commandBuffer,
            Ref<DependencyInfo> pDependencyInfo
        );

        [NativeName("vkCmdPipelineBarrier2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPipelineBarrier2KHR")]
        static abstract void CmdPipelineBarrier2KHR(
            CommandBufferHandle commandBuffer,
            DependencyInfo* pDependencyInfo
        );

        [NativeName("vkCmdPipelineBarrier2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPipelineBarrier2KHR")]
        static abstract void CmdPipelineBarrier2KHR(
            CommandBufferHandle commandBuffer,
            Ref<DependencyInfo> pDependencyInfo
        );

        [NativeName("vkCmdPreprocessGeneratedCommandsEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPreprocessGeneratedCommandsEXT")]
        static abstract void CmdPreprocessGeneratedCommandsEXT(
            CommandBufferHandle commandBuffer,
            GeneratedCommandsInfoEXT* pGeneratedCommandsInfo,
            CommandBufferHandle stateCommandBuffer
        );

        [NativeName("vkCmdPreprocessGeneratedCommandsEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPreprocessGeneratedCommandsEXT")]
        static abstract void CmdPreprocessGeneratedCommandsEXT(
            CommandBufferHandle commandBuffer,
            Ref<GeneratedCommandsInfoEXT> pGeneratedCommandsInfo,
            CommandBufferHandle stateCommandBuffer
        );

        [NativeName("vkCmdPreprocessGeneratedCommandsNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPreprocessGeneratedCommandsNV")]
        static abstract void CmdPreprocessGeneratedCommandsNV(
            CommandBufferHandle commandBuffer,
            GeneratedCommandsInfoNV* pGeneratedCommandsInfo
        );

        [NativeName("vkCmdPreprocessGeneratedCommandsNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPreprocessGeneratedCommandsNV")]
        static abstract void CmdPreprocessGeneratedCommandsNV(
            CommandBufferHandle commandBuffer,
            Ref<GeneratedCommandsInfoNV> pGeneratedCommandsInfo
        );

        [NativeName("vkCmdPushConstants")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPushConstants")]
        static abstract void CmdPushConstants(
            CommandBufferHandle commandBuffer,
            PipelineLayoutHandle layout,
            ShaderStageFlags stageFlags,
            uint offset,
            uint size,
            void* pValues
        );

        [NativeName("vkCmdPushConstants")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPushConstants")]
        static abstract void CmdPushConstants(
            CommandBufferHandle commandBuffer,
            PipelineLayoutHandle layout,
            ShaderStageFlags stageFlags,
            uint offset,
            uint size,
            Ref pValues
        );

        [NativeName("vkCmdPushConstants2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPushConstants2")]
        static abstract void CmdPushConstants2(
            CommandBufferHandle commandBuffer,
            PushConstantsInfo* pPushConstantsInfo
        );

        [NativeName("vkCmdPushConstants2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPushConstants2")]
        static abstract void CmdPushConstants2(
            CommandBufferHandle commandBuffer,
            Ref<PushConstantsInfo> pPushConstantsInfo
        );

        [NativeName("vkCmdPushConstants2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPushConstants2KHR")]
        static abstract void CmdPushConstants2KHR(
            CommandBufferHandle commandBuffer,
            PushConstantsInfo* pPushConstantsInfo
        );

        [NativeName("vkCmdPushConstants2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPushConstants2KHR")]
        static abstract void CmdPushConstants2KHR(
            CommandBufferHandle commandBuffer,
            Ref<PushConstantsInfo> pPushConstantsInfo
        );

        [NativeName("vkCmdPushDataEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPushDataEXT")]
        static abstract void CmdPushDataEXT(
            CommandBufferHandle commandBuffer,
            PushDataInfoEXT* pPushDataInfo
        );

        [NativeName("vkCmdPushDataEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPushDataEXT")]
        static abstract void CmdPushDataEXT(
            CommandBufferHandle commandBuffer,
            Ref<PushDataInfoEXT> pPushDataInfo
        );

        [NativeName("vkCmdPushDescriptorSet")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSet")]
        static abstract void CmdPushDescriptorSet(
            CommandBufferHandle commandBuffer,
            PipelineBindPoint pipelineBindPoint,
            PipelineLayoutHandle layout,
            uint set,
            uint descriptorWriteCount,
            WriteDescriptorSet* pDescriptorWrites
        );

        [NativeName("vkCmdPushDescriptorSet")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSet")]
        static abstract void CmdPushDescriptorSet(
            CommandBufferHandle commandBuffer,
            PipelineBindPoint pipelineBindPoint,
            PipelineLayoutHandle layout,
            uint set,
            uint descriptorWriteCount,
            Ref<WriteDescriptorSet> pDescriptorWrites
        );

        [NativeName("vkCmdPushDescriptorSet")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSet")]
        static abstract void CmdPushDescriptorSet(
            CommandBufferHandle commandBuffer,
            PipelineBindPoint pipelineBindPoint,
            PipelineLayoutHandle layout,
            uint set,
            WriteDescriptorSet pDescriptorWrites
        );

        [NativeName("vkCmdPushDescriptorSet2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSet2")]
        static abstract void CmdPushDescriptorSet2(
            CommandBufferHandle commandBuffer,
            PushDescriptorSetInfo* pPushDescriptorSetInfo
        );

        [NativeName("vkCmdPushDescriptorSet2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSet2")]
        static abstract void CmdPushDescriptorSet2(
            CommandBufferHandle commandBuffer,
            Ref<PushDescriptorSetInfo> pPushDescriptorSetInfo
        );

        [NativeName("vkCmdPushDescriptorSet2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSet2KHR")]
        static abstract void CmdPushDescriptorSet2KHR(
            CommandBufferHandle commandBuffer,
            PushDescriptorSetInfo* pPushDescriptorSetInfo
        );

        [NativeName("vkCmdPushDescriptorSet2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSet2KHR")]
        static abstract void CmdPushDescriptorSet2KHR(
            CommandBufferHandle commandBuffer,
            Ref<PushDescriptorSetInfo> pPushDescriptorSetInfo
        );

        [NativeName("vkCmdPushDescriptorSetKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSetKHR")]
        static abstract void CmdPushDescriptorSetKHR(
            CommandBufferHandle commandBuffer,
            PipelineBindPoint pipelineBindPoint,
            PipelineLayoutHandle layout,
            uint set,
            uint descriptorWriteCount,
            WriteDescriptorSet* pDescriptorWrites
        );

        [NativeName("vkCmdPushDescriptorSetKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSetKHR")]
        static abstract void CmdPushDescriptorSetKHR(
            CommandBufferHandle commandBuffer,
            PipelineBindPoint pipelineBindPoint,
            PipelineLayoutHandle layout,
            uint set,
            uint descriptorWriteCount,
            Ref<WriteDescriptorSet> pDescriptorWrites
        );

        [NativeName("vkCmdPushDescriptorSetKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSetKHR")]
        static abstract void CmdPushDescriptorSetKHR(
            CommandBufferHandle commandBuffer,
            PipelineBindPoint pipelineBindPoint,
            PipelineLayoutHandle layout,
            uint set,
            WriteDescriptorSet pDescriptorWrites
        );

        [NativeName("vkCmdPushDescriptorSetWithTemplate")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSetWithTemplate")]
        static abstract void CmdPushDescriptorSetWithTemplate(
            CommandBufferHandle commandBuffer,
            DescriptorUpdateTemplateHandle descriptorUpdateTemplate,
            PipelineLayoutHandle layout,
            uint set,
            void* pData
        );

        [NativeName("vkCmdPushDescriptorSetWithTemplate")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSetWithTemplate")]
        static abstract void CmdPushDescriptorSetWithTemplate(
            CommandBufferHandle commandBuffer,
            DescriptorUpdateTemplateHandle descriptorUpdateTemplate,
            PipelineLayoutHandle layout,
            uint set,
            Ref pData
        );

        [NativeName("vkCmdPushDescriptorSetWithTemplate2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSetWithTemplate2")]
        static abstract void CmdPushDescriptorSetWithTemplate2(
            CommandBufferHandle commandBuffer,
            PushDescriptorSetWithTemplateInfo* pPushDescriptorSetWithTemplateInfo
        );

        [NativeName("vkCmdPushDescriptorSetWithTemplate2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSetWithTemplate2")]
        static abstract void CmdPushDescriptorSetWithTemplate2(
            CommandBufferHandle commandBuffer,
            Ref<PushDescriptorSetWithTemplateInfo> pPushDescriptorSetWithTemplateInfo
        );

        [NativeName("vkCmdPushDescriptorSetWithTemplate2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSetWithTemplate2KHR")]
        static abstract void CmdPushDescriptorSetWithTemplate2KHR(
            CommandBufferHandle commandBuffer,
            PushDescriptorSetWithTemplateInfo* pPushDescriptorSetWithTemplateInfo
        );

        [NativeName("vkCmdPushDescriptorSetWithTemplate2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSetWithTemplate2KHR")]
        static abstract void CmdPushDescriptorSetWithTemplate2KHR(
            CommandBufferHandle commandBuffer,
            Ref<PushDescriptorSetWithTemplateInfo> pPushDescriptorSetWithTemplateInfo
        );

        [NativeName("vkCmdPushDescriptorSetWithTemplateKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSetWithTemplateKHR")]
        static abstract void CmdPushDescriptorSetWithTemplateKHR(
            CommandBufferHandle commandBuffer,
            DescriptorUpdateTemplateHandle descriptorUpdateTemplate,
            PipelineLayoutHandle layout,
            uint set,
            void* pData
        );

        [NativeName("vkCmdPushDescriptorSetWithTemplateKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSetWithTemplateKHR")]
        static abstract void CmdPushDescriptorSetWithTemplateKHR(
            CommandBufferHandle commandBuffer,
            DescriptorUpdateTemplateHandle descriptorUpdateTemplate,
            PipelineLayoutHandle layout,
            uint set,
            Ref pData
        );

        [NativeName("vkCmdResetEvent")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdResetEvent")]
        static abstract void CmdResetEvent(
            CommandBufferHandle commandBuffer,
            EventHandle @event,
            PipelineStageFlags stageMask
        );

        [NativeName("vkCmdResetEvent2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdResetEvent2")]
        static abstract void CmdResetEvent2(
            CommandBufferHandle commandBuffer,
            EventHandle @event,
            PipelineStageFlags2 stageMask
        );

        [NativeName("vkCmdResetEvent2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdResetEvent2KHR")]
        static abstract void CmdResetEvent2KHR(
            CommandBufferHandle commandBuffer,
            EventHandle @event,
            PipelineStageFlags2 stageMask
        );

        [NativeName("vkCmdResetQueryPool")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdResetQueryPool")]
        static abstract void CmdResetQueryPool(
            CommandBufferHandle commandBuffer,
            QueryPoolHandle queryPool,
            uint firstQuery,
            uint queryCount
        );

        [NativeName("vkCmdResolveImage")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdResolveImage")]
        static abstract void CmdResolveImage(
            CommandBufferHandle commandBuffer,
            ImageHandle srcImage,
            ImageLayout srcImageLayout,
            ImageHandle dstImage,
            ImageLayout dstImageLayout,
            uint regionCount,
            ImageResolve* pRegions
        );

        [NativeName("vkCmdResolveImage")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdResolveImage")]
        static abstract void CmdResolveImage(
            CommandBufferHandle commandBuffer,
            ImageHandle srcImage,
            ImageLayout srcImageLayout,
            ImageHandle dstImage,
            ImageLayout dstImageLayout,
            uint regionCount,
            Ref<ImageResolve> pRegions
        );

        [NativeName("vkCmdResolveImage")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdResolveImage")]
        static abstract void CmdResolveImage(
            CommandBufferHandle commandBuffer,
            ImageHandle srcImage,
            ImageLayout srcImageLayout,
            ImageHandle dstImage,
            ImageLayout dstImageLayout,
            ImageResolve pRegions
        );

        [NativeName("vkCmdResolveImage2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdResolveImage2")]
        static abstract void CmdResolveImage2(
            CommandBufferHandle commandBuffer,
            ResolveImageInfo2* pResolveImageInfo
        );

        [NativeName("vkCmdResolveImage2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdResolveImage2")]
        static abstract void CmdResolveImage2(
            CommandBufferHandle commandBuffer,
            Ref<ResolveImageInfo2> pResolveImageInfo
        );

        [NativeName("vkCmdResolveImage2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdResolveImage2KHR")]
        static abstract void CmdResolveImage2KHR(
            CommandBufferHandle commandBuffer,
            ResolveImageInfo2* pResolveImageInfo
        );

        [NativeName("vkCmdResolveImage2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdResolveImage2KHR")]
        static abstract void CmdResolveImage2KHR(
            CommandBufferHandle commandBuffer,
            Ref<ResolveImageInfo2> pResolveImageInfo
        );

        [NativeName("vkCmdSetAlphaToCoverageEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetAlphaToCoverageEnableEXT")]
        static abstract void CmdSetAlphaToCoverageEnableEXT(
            CommandBufferHandle commandBuffer,
            uint alphaToCoverageEnable
        );

        [NativeName("vkCmdSetAlphaToCoverageEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetAlphaToCoverageEnableEXT")]
        static abstract void CmdSetAlphaToCoverageEnableEXT(
            CommandBufferHandle commandBuffer,
            MaybeBool<uint> alphaToCoverageEnable
        );

        [NativeName("vkCmdSetAlphaToOneEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetAlphaToOneEnableEXT")]
        static abstract void CmdSetAlphaToOneEnableEXT(
            CommandBufferHandle commandBuffer,
            uint alphaToOneEnable
        );

        [NativeName("vkCmdSetAlphaToOneEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetAlphaToOneEnableEXT")]
        static abstract void CmdSetAlphaToOneEnableEXT(
            CommandBufferHandle commandBuffer,
            MaybeBool<uint> alphaToOneEnable
        );

        [NativeName("vkCmdSetAttachmentFeedbackLoopEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetAttachmentFeedbackLoopEnableEXT")]
        static abstract void CmdSetAttachmentFeedbackLoopEnableEXT(
            CommandBufferHandle commandBuffer,
            ImageAspectFlags aspectMask
        );

        [NativeName("vkCmdSetBlendConstants")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetBlendConstants")]
        static abstract void CmdSetBlendConstants(
            CommandBufferHandle commandBuffer,
            float* blendConstants
        );

        [NativeName("vkCmdSetBlendConstants")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetBlendConstants")]
        static abstract void CmdSetBlendConstants(
            CommandBufferHandle commandBuffer,
            Ref<float> blendConstants
        );

        [NativeName("vkCmdSetCheckpointNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetCheckpointNV")]
        static abstract void CmdSetCheckpointNV(
            CommandBufferHandle commandBuffer,
            void* pCheckpointMarker
        );

        [NativeName("vkCmdSetCheckpointNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetCheckpointNV")]
        static abstract void CmdSetCheckpointNV(
            CommandBufferHandle commandBuffer,
            Ref pCheckpointMarker
        );

        [NativeName("vkCmdSetCoarseSampleOrderNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetCoarseSampleOrderNV")]
        static abstract void CmdSetCoarseSampleOrderNV(
            CommandBufferHandle commandBuffer,
            CoarseSampleOrderTypeNV sampleOrderType,
            uint customSampleOrderCount,
            CoarseSampleOrderCustomNV* pCustomSampleOrders
        );

        [NativeName("vkCmdSetCoarseSampleOrderNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetCoarseSampleOrderNV")]
        static abstract void CmdSetCoarseSampleOrderNV(
            CommandBufferHandle commandBuffer,
            CoarseSampleOrderTypeNV sampleOrderType,
            uint customSampleOrderCount,
            Ref<CoarseSampleOrderCustomNV> pCustomSampleOrders
        );

        [NativeName("vkCmdSetCoarseSampleOrderNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetCoarseSampleOrderNV")]
        static abstract void CmdSetCoarseSampleOrderNV(
            CommandBufferHandle commandBuffer,
            CoarseSampleOrderTypeNV sampleOrderType,
            CoarseSampleOrderCustomNV pCustomSampleOrders
        );

        [NativeName("vkCmdSetColorBlendAdvancedEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetColorBlendAdvancedEXT")]
        static abstract void CmdSetColorBlendAdvancedEXT(
            CommandBufferHandle commandBuffer,
            uint firstAttachment,
            uint attachmentCount,
            ColorBlendAdvancedEXT* pColorBlendAdvanced
        );

        [NativeName("vkCmdSetColorBlendAdvancedEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetColorBlendAdvancedEXT")]
        static abstract void CmdSetColorBlendAdvancedEXT(
            CommandBufferHandle commandBuffer,
            uint firstAttachment,
            uint attachmentCount,
            Ref<ColorBlendAdvancedEXT> pColorBlendAdvanced
        );

        [NativeName("vkCmdSetColorBlendAdvancedEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetColorBlendAdvancedEXT")]
        static abstract void CmdSetColorBlendAdvancedEXT(
            CommandBufferHandle commandBuffer,
            uint firstAttachment,
            ColorBlendAdvancedEXT pColorBlendAdvanced
        );

        [NativeName("vkCmdSetColorBlendEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetColorBlendEnableEXT")]
        static abstract void CmdSetColorBlendEnableEXT(
            CommandBufferHandle commandBuffer,
            uint firstAttachment,
            uint attachmentCount,
            uint* pColorBlendEnables
        );

        [NativeName("vkCmdSetColorBlendEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetColorBlendEnableEXT")]
        static abstract void CmdSetColorBlendEnableEXT(
            CommandBufferHandle commandBuffer,
            uint firstAttachment,
            uint attachmentCount,
            Ref<uint> pColorBlendEnables
        );

        [NativeName("vkCmdSetColorBlendEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetColorBlendEnableEXT")]
        static abstract void CmdSetColorBlendEnableEXT(
            CommandBufferHandle commandBuffer,
            uint firstAttachment,
            uint pColorBlendEnables
        );

        [NativeName("vkCmdSetColorBlendEquationEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetColorBlendEquationEXT")]
        static abstract void CmdSetColorBlendEquationEXT(
            CommandBufferHandle commandBuffer,
            uint firstAttachment,
            uint attachmentCount,
            ColorBlendEquationEXT* pColorBlendEquations
        );

        [NativeName("vkCmdSetColorBlendEquationEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetColorBlendEquationEXT")]
        static abstract void CmdSetColorBlendEquationEXT(
            CommandBufferHandle commandBuffer,
            uint firstAttachment,
            uint attachmentCount,
            Ref<ColorBlendEquationEXT> pColorBlendEquations
        );

        [NativeName("vkCmdSetColorBlendEquationEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetColorBlendEquationEXT")]
        static abstract void CmdSetColorBlendEquationEXT(
            CommandBufferHandle commandBuffer,
            uint firstAttachment,
            ColorBlendEquationEXT pColorBlendEquations
        );

        [NativeName("vkCmdSetColorWriteEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetColorWriteEnableEXT")]
        static abstract void CmdSetColorWriteEnableEXT(
            CommandBufferHandle commandBuffer,
            uint attachmentCount,
            uint* pColorWriteEnables
        );

        [NativeName("vkCmdSetColorWriteEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetColorWriteEnableEXT")]
        static abstract void CmdSetColorWriteEnableEXT(
            CommandBufferHandle commandBuffer,
            uint attachmentCount,
            Ref<uint> pColorWriteEnables
        );

        [NativeName("vkCmdSetColorWriteEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetColorWriteEnableEXT")]
        static abstract void CmdSetColorWriteEnableEXT(
            CommandBufferHandle commandBuffer,
            uint pColorWriteEnables
        );

        [NativeName("vkCmdSetColorWriteMaskEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetColorWriteMaskEXT")]
        static abstract void CmdSetColorWriteMaskEXT(
            CommandBufferHandle commandBuffer,
            uint firstAttachment,
            uint attachmentCount,
            ColorComponentFlags* pColorWriteMasks
        );

        [NativeName("vkCmdSetColorWriteMaskEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetColorWriteMaskEXT")]
        static abstract void CmdSetColorWriteMaskEXT(
            CommandBufferHandle commandBuffer,
            uint firstAttachment,
            uint attachmentCount,
            Ref<ColorComponentFlags> pColorWriteMasks
        );

        [NativeName("vkCmdSetColorWriteMaskEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetColorWriteMaskEXT")]
        static abstract void CmdSetColorWriteMaskEXT(
            CommandBufferHandle commandBuffer,
            uint firstAttachment,
            ColorComponentFlags pColorWriteMasks
        );

        [NativeName("vkCmdSetComputeOccupancyPriorityNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetComputeOccupancyPriorityNV")]
        static abstract void CmdSetComputeOccupancyPriorityNV(
            CommandBufferHandle commandBuffer,
            ComputeOccupancyPriorityParametersNV* pParameters
        );

        [NativeName("vkCmdSetComputeOccupancyPriorityNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetComputeOccupancyPriorityNV")]
        static abstract void CmdSetComputeOccupancyPriorityNV(
            CommandBufferHandle commandBuffer,
            Ref<ComputeOccupancyPriorityParametersNV> pParameters
        );

        [NativeName("vkCmdSetConservativeRasterizationModeEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetConservativeRasterizationModeEXT")]
        static abstract void CmdSetConservativeRasterizationModeEXT(
            CommandBufferHandle commandBuffer,
            ConservativeRasterizationModeEXT conservativeRasterizationMode
        );

        [NativeName("vkCmdSetCoverageModulationModeNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetCoverageModulationModeNV")]
        static abstract void CmdSetCoverageModulationModeNV(
            CommandBufferHandle commandBuffer,
            CoverageModulationModeNV coverageModulationMode
        );

        [NativeName("vkCmdSetCoverageModulationTableEnableNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetCoverageModulationTableEnableNV")]
        static abstract void CmdSetCoverageModulationTableEnableNV(
            CommandBufferHandle commandBuffer,
            uint coverageModulationTableEnable
        );

        [NativeName("vkCmdSetCoverageModulationTableEnableNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetCoverageModulationTableEnableNV")]
        static abstract void CmdSetCoverageModulationTableEnableNV(
            CommandBufferHandle commandBuffer,
            MaybeBool<uint> coverageModulationTableEnable
        );

        [NativeName("vkCmdSetCoverageModulationTableNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetCoverageModulationTableNV")]
        static abstract void CmdSetCoverageModulationTableNV(
            CommandBufferHandle commandBuffer,
            uint coverageModulationTableCount,
            float* pCoverageModulationTable
        );

        [NativeName("vkCmdSetCoverageModulationTableNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetCoverageModulationTableNV")]
        static abstract void CmdSetCoverageModulationTableNV(
            CommandBufferHandle commandBuffer,
            uint coverageModulationTableCount,
            Ref<float> pCoverageModulationTable
        );

        [NativeName("vkCmdSetCoverageModulationTableNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetCoverageModulationTableNV")]
        static abstract void CmdSetCoverageModulationTableNV(
            CommandBufferHandle commandBuffer,
            float pCoverageModulationTable
        );

        [NativeName("vkCmdSetCoverageReductionModeNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetCoverageReductionModeNV")]
        static abstract void CmdSetCoverageReductionModeNV(
            CommandBufferHandle commandBuffer,
            CoverageReductionModeNV coverageReductionMode
        );

        [NativeName("vkCmdSetCoverageToColorEnableNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetCoverageToColorEnableNV")]
        static abstract void CmdSetCoverageToColorEnableNV(
            CommandBufferHandle commandBuffer,
            uint coverageToColorEnable
        );

        [NativeName("vkCmdSetCoverageToColorEnableNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetCoverageToColorEnableNV")]
        static abstract void CmdSetCoverageToColorEnableNV(
            CommandBufferHandle commandBuffer,
            MaybeBool<uint> coverageToColorEnable
        );

        [NativeName("vkCmdSetCoverageToColorLocationNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetCoverageToColorLocationNV")]
        static abstract void CmdSetCoverageToColorLocationNV(
            CommandBufferHandle commandBuffer,
            uint coverageToColorLocation
        );

        [NativeName("vkCmdSetCullMode")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetCullMode")]
        static abstract void CmdSetCullMode(
            CommandBufferHandle commandBuffer,
            CullModeFlags cullMode
        );

        [NativeName("vkCmdSetCullModeEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetCullModeEXT")]
        static abstract void CmdSetCullModeEXT(
            CommandBufferHandle commandBuffer,
            CullModeFlags cullMode
        );

        [NativeName("vkCmdSetDepthBias")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthBias")]
        static abstract void CmdSetDepthBias(
            CommandBufferHandle commandBuffer,
            float depthBiasConstantFactor,
            float depthBiasClamp,
            float depthBiasSlopeFactor
        );

        [NativeName("vkCmdSetDepthBias2EXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthBias2EXT")]
        static abstract void CmdSetDepthBias2EXT(
            CommandBufferHandle commandBuffer,
            DepthBiasInfoEXT* pDepthBiasInfo
        );

        [NativeName("vkCmdSetDepthBias2EXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthBias2EXT")]
        static abstract void CmdSetDepthBias2EXT(
            CommandBufferHandle commandBuffer,
            Ref<DepthBiasInfoEXT> pDepthBiasInfo
        );

        [NativeName("vkCmdSetDepthBiasEnable")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthBiasEnable")]
        static abstract void CmdSetDepthBiasEnable(
            CommandBufferHandle commandBuffer,
            uint depthBiasEnable
        );

        [NativeName("vkCmdSetDepthBiasEnable")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthBiasEnable")]
        static abstract void CmdSetDepthBiasEnable(
            CommandBufferHandle commandBuffer,
            MaybeBool<uint> depthBiasEnable
        );

        [NativeName("vkCmdSetDepthBiasEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthBiasEnableEXT")]
        static abstract void CmdSetDepthBiasEnableEXT(
            CommandBufferHandle commandBuffer,
            uint depthBiasEnable
        );

        [NativeName("vkCmdSetDepthBiasEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthBiasEnableEXT")]
        static abstract void CmdSetDepthBiasEnableEXT(
            CommandBufferHandle commandBuffer,
            MaybeBool<uint> depthBiasEnable
        );

        [NativeName("vkCmdSetDepthBounds")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthBounds")]
        static abstract void CmdSetDepthBounds(
            CommandBufferHandle commandBuffer,
            float minDepthBounds,
            float maxDepthBounds
        );

        [NativeName("vkCmdSetDepthBoundsTestEnable")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthBoundsTestEnable")]
        static abstract void CmdSetDepthBoundsTestEnable(
            CommandBufferHandle commandBuffer,
            uint depthBoundsTestEnable
        );

        [NativeName("vkCmdSetDepthBoundsTestEnable")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthBoundsTestEnable")]
        static abstract void CmdSetDepthBoundsTestEnable(
            CommandBufferHandle commandBuffer,
            MaybeBool<uint> depthBoundsTestEnable
        );

        [NativeName("vkCmdSetDepthBoundsTestEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthBoundsTestEnableEXT")]
        static abstract void CmdSetDepthBoundsTestEnableEXT(
            CommandBufferHandle commandBuffer,
            uint depthBoundsTestEnable
        );

        [NativeName("vkCmdSetDepthBoundsTestEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthBoundsTestEnableEXT")]
        static abstract void CmdSetDepthBoundsTestEnableEXT(
            CommandBufferHandle commandBuffer,
            MaybeBool<uint> depthBoundsTestEnable
        );

        [NativeName("vkCmdSetDepthClampEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthClampEnableEXT")]
        static abstract void CmdSetDepthClampEnableEXT(
            CommandBufferHandle commandBuffer,
            uint depthClampEnable
        );

        [NativeName("vkCmdSetDepthClampEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthClampEnableEXT")]
        static abstract void CmdSetDepthClampEnableEXT(
            CommandBufferHandle commandBuffer,
            MaybeBool<uint> depthClampEnable
        );

        [NativeName("vkCmdSetDepthClampRangeEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthClampRangeEXT")]
        static abstract void CmdSetDepthClampRangeEXT(
            CommandBufferHandle commandBuffer,
            DepthClampModeEXT depthClampMode,
            DepthClampRangeEXT* pDepthClampRange
        );

        [NativeName("vkCmdSetDepthClampRangeEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthClampRangeEXT")]
        static abstract void CmdSetDepthClampRangeEXT(
            CommandBufferHandle commandBuffer,
            DepthClampModeEXT depthClampMode,
            Ref<DepthClampRangeEXT> pDepthClampRange
        );

        [NativeName("vkCmdSetDepthClipEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthClipEnableEXT")]
        static abstract void CmdSetDepthClipEnableEXT(
            CommandBufferHandle commandBuffer,
            uint depthClipEnable
        );

        [NativeName("vkCmdSetDepthClipEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthClipEnableEXT")]
        static abstract void CmdSetDepthClipEnableEXT(
            CommandBufferHandle commandBuffer,
            MaybeBool<uint> depthClipEnable
        );

        [NativeName("vkCmdSetDepthClipNegativeOneToOneEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthClipNegativeOneToOneEXT")]
        static abstract void CmdSetDepthClipNegativeOneToOneEXT(
            CommandBufferHandle commandBuffer,
            uint negativeOneToOne
        );

        [NativeName("vkCmdSetDepthClipNegativeOneToOneEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthClipNegativeOneToOneEXT")]
        static abstract void CmdSetDepthClipNegativeOneToOneEXT(
            CommandBufferHandle commandBuffer,
            MaybeBool<uint> negativeOneToOne
        );

        [NativeName("vkCmdSetDepthCompareOp")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthCompareOp")]
        static abstract void CmdSetDepthCompareOp(
            CommandBufferHandle commandBuffer,
            CompareOp depthCompareOp
        );

        [NativeName("vkCmdSetDepthCompareOpEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthCompareOpEXT")]
        static abstract void CmdSetDepthCompareOpEXT(
            CommandBufferHandle commandBuffer,
            CompareOp depthCompareOp
        );

        [NativeName("vkCmdSetDepthTestEnable")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthTestEnable")]
        static abstract void CmdSetDepthTestEnable(
            CommandBufferHandle commandBuffer,
            uint depthTestEnable
        );

        [NativeName("vkCmdSetDepthTestEnable")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthTestEnable")]
        static abstract void CmdSetDepthTestEnable(
            CommandBufferHandle commandBuffer,
            MaybeBool<uint> depthTestEnable
        );

        [NativeName("vkCmdSetDepthTestEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthTestEnableEXT")]
        static abstract void CmdSetDepthTestEnableEXT(
            CommandBufferHandle commandBuffer,
            uint depthTestEnable
        );

        [NativeName("vkCmdSetDepthTestEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthTestEnableEXT")]
        static abstract void CmdSetDepthTestEnableEXT(
            CommandBufferHandle commandBuffer,
            MaybeBool<uint> depthTestEnable
        );

        [NativeName("vkCmdSetDepthWriteEnable")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthWriteEnable")]
        static abstract void CmdSetDepthWriteEnable(
            CommandBufferHandle commandBuffer,
            uint depthWriteEnable
        );

        [NativeName("vkCmdSetDepthWriteEnable")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthWriteEnable")]
        static abstract void CmdSetDepthWriteEnable(
            CommandBufferHandle commandBuffer,
            MaybeBool<uint> depthWriteEnable
        );

        [NativeName("vkCmdSetDepthWriteEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthWriteEnableEXT")]
        static abstract void CmdSetDepthWriteEnableEXT(
            CommandBufferHandle commandBuffer,
            uint depthWriteEnable
        );

        [NativeName("vkCmdSetDepthWriteEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthWriteEnableEXT")]
        static abstract void CmdSetDepthWriteEnableEXT(
            CommandBufferHandle commandBuffer,
            MaybeBool<uint> depthWriteEnable
        );

        [NativeName("vkCmdSetDescriptorBufferOffsets2EXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDescriptorBufferOffsets2EXT")]
        static abstract void CmdSetDescriptorBufferOffsets2EXT(
            CommandBufferHandle commandBuffer,
            SetDescriptorBufferOffsetsInfoEXT* pSetDescriptorBufferOffsetsInfo
        );

        [NativeName("vkCmdSetDescriptorBufferOffsets2EXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDescriptorBufferOffsets2EXT")]
        static abstract void CmdSetDescriptorBufferOffsets2EXT(
            CommandBufferHandle commandBuffer,
            Ref<SetDescriptorBufferOffsetsInfoEXT> pSetDescriptorBufferOffsetsInfo
        );

        [NativeName("vkCmdSetDescriptorBufferOffsetsEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDescriptorBufferOffsetsEXT")]
        static abstract void CmdSetDescriptorBufferOffsetsEXT(
            CommandBufferHandle commandBuffer,
            PipelineBindPoint pipelineBindPoint,
            PipelineLayoutHandle layout,
            uint firstSet,
            uint setCount,
            uint* pBufferIndices,
            ulong* pOffsets
        );

        [NativeName("vkCmdSetDescriptorBufferOffsetsEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDescriptorBufferOffsetsEXT")]
        static abstract void CmdSetDescriptorBufferOffsetsEXT(
            CommandBufferHandle commandBuffer,
            PipelineBindPoint pipelineBindPoint,
            PipelineLayoutHandle layout,
            uint firstSet,
            uint setCount,
            Ref<uint> pBufferIndices,
            Ref<ulong> pOffsets
        );

        [NativeName("vkCmdSetDeviceMask")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDeviceMask")]
        static abstract void CmdSetDeviceMask(CommandBufferHandle commandBuffer, uint deviceMask);

        [NativeName("vkCmdSetDeviceMaskKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDeviceMaskKHR")]
        static abstract void CmdSetDeviceMaskKHR(
            CommandBufferHandle commandBuffer,
            uint deviceMask
        );

        [NativeName("vkCmdSetDiscardRectangleEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDiscardRectangleEnableEXT")]
        static abstract void CmdSetDiscardRectangleEnableEXT(
            CommandBufferHandle commandBuffer,
            uint discardRectangleEnable
        );

        [NativeName("vkCmdSetDiscardRectangleEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDiscardRectangleEnableEXT")]
        static abstract void CmdSetDiscardRectangleEnableEXT(
            CommandBufferHandle commandBuffer,
            MaybeBool<uint> discardRectangleEnable
        );

        [NativeName("vkCmdSetDiscardRectangleEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDiscardRectangleEXT")]
        static abstract void CmdSetDiscardRectangleEXT(
            CommandBufferHandle commandBuffer,
            uint firstDiscardRectangle,
            uint discardRectangleCount,
            Rect2D* pDiscardRectangles
        );

        [NativeName("vkCmdSetDiscardRectangleEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDiscardRectangleEXT")]
        static abstract void CmdSetDiscardRectangleEXT(
            CommandBufferHandle commandBuffer,
            uint firstDiscardRectangle,
            uint discardRectangleCount,
            Ref<Rect2D> pDiscardRectangles
        );

        [NativeName("vkCmdSetDiscardRectangleEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDiscardRectangleEXT")]
        static abstract void CmdSetDiscardRectangleEXT(
            CommandBufferHandle commandBuffer,
            uint firstDiscardRectangle,
            Rect2D pDiscardRectangles
        );

        [NativeName("vkCmdSetDiscardRectangleModeEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDiscardRectangleModeEXT")]
        static abstract void CmdSetDiscardRectangleModeEXT(
            CommandBufferHandle commandBuffer,
            DiscardRectangleModeEXT discardRectangleMode
        );

        [NativeName("vkCmdSetDispatchParametersARM")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDispatchParametersARM")]
        static abstract void CmdSetDispatchParametersARM(
            CommandBufferHandle commandBuffer,
            DispatchParametersARM* pDispatchParameters
        );

        [NativeName("vkCmdSetDispatchParametersARM")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetDispatchParametersARM")]
        static abstract void CmdSetDispatchParametersARM(
            CommandBufferHandle commandBuffer,
            Ref<DispatchParametersARM> pDispatchParameters
        );

        [NativeName("vkCmdSetEvent")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetEvent")]
        static abstract void CmdSetEvent(
            CommandBufferHandle commandBuffer,
            EventHandle @event,
            PipelineStageFlags stageMask
        );

        [NativeName("vkCmdSetEvent2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetEvent2")]
        static abstract void CmdSetEvent2(
            CommandBufferHandle commandBuffer,
            EventHandle @event,
            DependencyInfo* pDependencyInfo
        );

        [NativeName("vkCmdSetEvent2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetEvent2")]
        static abstract void CmdSetEvent2(
            CommandBufferHandle commandBuffer,
            EventHandle @event,
            Ref<DependencyInfo> pDependencyInfo
        );

        [NativeName("vkCmdSetEvent2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetEvent2KHR")]
        static abstract void CmdSetEvent2KHR(
            CommandBufferHandle commandBuffer,
            EventHandle @event,
            DependencyInfo* pDependencyInfo
        );

        [NativeName("vkCmdSetEvent2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetEvent2KHR")]
        static abstract void CmdSetEvent2KHR(
            CommandBufferHandle commandBuffer,
            EventHandle @event,
            Ref<DependencyInfo> pDependencyInfo
        );

        [NativeName("vkCmdSetExclusiveScissorEnableNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetExclusiveScissorEnableNV")]
        static abstract void CmdSetExclusiveScissorEnableNV(
            CommandBufferHandle commandBuffer,
            uint firstExclusiveScissor,
            uint exclusiveScissorCount,
            uint* pExclusiveScissorEnables
        );

        [NativeName("vkCmdSetExclusiveScissorEnableNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetExclusiveScissorEnableNV")]
        static abstract void CmdSetExclusiveScissorEnableNV(
            CommandBufferHandle commandBuffer,
            uint firstExclusiveScissor,
            uint exclusiveScissorCount,
            Ref<uint> pExclusiveScissorEnables
        );

        [NativeName("vkCmdSetExclusiveScissorEnableNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetExclusiveScissorEnableNV")]
        static abstract void CmdSetExclusiveScissorEnableNV(
            CommandBufferHandle commandBuffer,
            uint firstExclusiveScissor,
            uint pExclusiveScissorEnables
        );

        [NativeName("vkCmdSetExclusiveScissorNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetExclusiveScissorNV")]
        static abstract void CmdSetExclusiveScissorNV(
            CommandBufferHandle commandBuffer,
            uint firstExclusiveScissor,
            uint exclusiveScissorCount,
            Rect2D* pExclusiveScissors
        );

        [NativeName("vkCmdSetExclusiveScissorNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetExclusiveScissorNV")]
        static abstract void CmdSetExclusiveScissorNV(
            CommandBufferHandle commandBuffer,
            uint firstExclusiveScissor,
            uint exclusiveScissorCount,
            Ref<Rect2D> pExclusiveScissors
        );

        [NativeName("vkCmdSetExclusiveScissorNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetExclusiveScissorNV")]
        static abstract void CmdSetExclusiveScissorNV(
            CommandBufferHandle commandBuffer,
            uint firstExclusiveScissor,
            Rect2D pExclusiveScissors
        );

        [NativeName("vkCmdSetExtraPrimitiveOverestimationSizeEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetExtraPrimitiveOverestimationSizeEXT")]
        static abstract void CmdSetExtraPrimitiveOverestimationSizeEXT(
            CommandBufferHandle commandBuffer,
            float extraPrimitiveOverestimationSize
        );

        [NativeName("vkCmdSetFragmentShadingRateEnumNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetFragmentShadingRateEnumNV")]
        static abstract void CmdSetFragmentShadingRateEnumNV(
            CommandBufferHandle commandBuffer,
            FragmentShadingRateNV shadingRate,
            FragmentShadingRateCombinerOpKHR* combinerOps
        );

        [NativeName("vkCmdSetFragmentShadingRateEnumNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetFragmentShadingRateEnumNV")]
        static abstract void CmdSetFragmentShadingRateEnumNV(
            CommandBufferHandle commandBuffer,
            FragmentShadingRateNV shadingRate,
            Ref<FragmentShadingRateCombinerOpKHR> combinerOps
        );

        [NativeName("vkCmdSetFragmentShadingRateKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetFragmentShadingRateKHR")]
        static abstract void CmdSetFragmentShadingRateKHR(
            CommandBufferHandle commandBuffer,
            Extent2D* pFragmentSize,
            FragmentShadingRateCombinerOpKHR* combinerOps
        );

        [NativeName("vkCmdSetFragmentShadingRateKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetFragmentShadingRateKHR")]
        static abstract void CmdSetFragmentShadingRateKHR(
            CommandBufferHandle commandBuffer,
            Ref<Extent2D> pFragmentSize,
            Ref<FragmentShadingRateCombinerOpKHR> combinerOps
        );

        [NativeName("vkCmdSetFrontFace")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetFrontFace")]
        static abstract void CmdSetFrontFace(
            CommandBufferHandle commandBuffer,
            FrontFace frontFace
        );

        [NativeName("vkCmdSetFrontFaceEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetFrontFaceEXT")]
        static abstract void CmdSetFrontFaceEXT(
            CommandBufferHandle commandBuffer,
            FrontFace frontFace
        );

        [NativeName("vkCmdSetLineRasterizationModeEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetLineRasterizationModeEXT")]
        static abstract void CmdSetLineRasterizationModeEXT(
            CommandBufferHandle commandBuffer,
            LineRasterizationMode lineRasterizationMode
        );

        [NativeName("vkCmdSetLineStipple")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetLineStipple")]
        static abstract void CmdSetLineStipple(
            CommandBufferHandle commandBuffer,
            uint lineStippleFactor,
            ushort lineStipplePattern
        );

        [NativeName("vkCmdSetLineStippleEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetLineStippleEnableEXT")]
        static abstract void CmdSetLineStippleEnableEXT(
            CommandBufferHandle commandBuffer,
            uint stippledLineEnable
        );

        [NativeName("vkCmdSetLineStippleEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetLineStippleEnableEXT")]
        static abstract void CmdSetLineStippleEnableEXT(
            CommandBufferHandle commandBuffer,
            MaybeBool<uint> stippledLineEnable
        );

        [NativeName("vkCmdSetLineStippleEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetLineStippleEXT")]
        static abstract void CmdSetLineStippleEXT(
            CommandBufferHandle commandBuffer,
            uint lineStippleFactor,
            ushort lineStipplePattern
        );

        [NativeName("vkCmdSetLineStippleKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetLineStippleKHR")]
        static abstract void CmdSetLineStippleKHR(
            CommandBufferHandle commandBuffer,
            uint lineStippleFactor,
            ushort lineStipplePattern
        );

        [NativeName("vkCmdSetLineWidth")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetLineWidth")]
        static abstract void CmdSetLineWidth(CommandBufferHandle commandBuffer, float lineWidth);

        [NativeName("vkCmdSetLogicOpEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetLogicOpEnableEXT")]
        static abstract void CmdSetLogicOpEnableEXT(
            CommandBufferHandle commandBuffer,
            uint logicOpEnable
        );

        [NativeName("vkCmdSetLogicOpEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetLogicOpEnableEXT")]
        static abstract void CmdSetLogicOpEnableEXT(
            CommandBufferHandle commandBuffer,
            MaybeBool<uint> logicOpEnable
        );

        [NativeName("vkCmdSetLogicOpEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetLogicOpEXT")]
        static abstract void CmdSetLogicOpEXT(CommandBufferHandle commandBuffer, LogicOp logicOp);

        [NativeName("vkCmdSetPatchControlPointsEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetPatchControlPointsEXT")]
        static abstract void CmdSetPatchControlPointsEXT(
            CommandBufferHandle commandBuffer,
            uint patchControlPoints
        );

        [NativeName("vkCmdSetPerformanceMarkerINTEL")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetPerformanceMarkerINTEL")]
        static abstract Result CmdSetPerformanceMarkerINTEL(
            CommandBufferHandle commandBuffer,
            PerformanceMarkerInfoINTEL* pMarkerInfo
        );

        [NativeName("vkCmdSetPerformanceMarkerINTEL")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetPerformanceMarkerINTEL")]
        static abstract Result CmdSetPerformanceMarkerINTEL(
            CommandBufferHandle commandBuffer,
            Ref<PerformanceMarkerInfoINTEL> pMarkerInfo
        );

        [NativeName("vkCmdSetPerformanceOverrideINTEL")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetPerformanceOverrideINTEL")]
        static abstract Result CmdSetPerformanceOverrideINTEL(
            CommandBufferHandle commandBuffer,
            PerformanceOverrideInfoINTEL* pOverrideInfo
        );

        [NativeName("vkCmdSetPerformanceOverrideINTEL")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetPerformanceOverrideINTEL")]
        static abstract Result CmdSetPerformanceOverrideINTEL(
            CommandBufferHandle commandBuffer,
            Ref<PerformanceOverrideInfoINTEL> pOverrideInfo
        );

        [NativeName("vkCmdSetPerformanceStreamMarkerINTEL")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetPerformanceStreamMarkerINTEL")]
        static abstract Result CmdSetPerformanceStreamMarkerINTEL(
            CommandBufferHandle commandBuffer,
            PerformanceStreamMarkerInfoINTEL* pMarkerInfo
        );

        [NativeName("vkCmdSetPerformanceStreamMarkerINTEL")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetPerformanceStreamMarkerINTEL")]
        static abstract Result CmdSetPerformanceStreamMarkerINTEL(
            CommandBufferHandle commandBuffer,
            Ref<PerformanceStreamMarkerInfoINTEL> pMarkerInfo
        );

        [NativeName("vkCmdSetPolygonModeEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetPolygonModeEXT")]
        static abstract void CmdSetPolygonModeEXT(
            CommandBufferHandle commandBuffer,
            PolygonMode polygonMode
        );

        [NativeName("vkCmdSetPrimitiveRestartEnable")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetPrimitiveRestartEnable")]
        static abstract void CmdSetPrimitiveRestartEnable(
            CommandBufferHandle commandBuffer,
            uint primitiveRestartEnable
        );

        [NativeName("vkCmdSetPrimitiveRestartEnable")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetPrimitiveRestartEnable")]
        static abstract void CmdSetPrimitiveRestartEnable(
            CommandBufferHandle commandBuffer,
            MaybeBool<uint> primitiveRestartEnable
        );

        [NativeName("vkCmdSetPrimitiveRestartEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetPrimitiveRestartEnableEXT")]
        static abstract void CmdSetPrimitiveRestartEnableEXT(
            CommandBufferHandle commandBuffer,
            uint primitiveRestartEnable
        );

        [NativeName("vkCmdSetPrimitiveRestartEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetPrimitiveRestartEnableEXT")]
        static abstract void CmdSetPrimitiveRestartEnableEXT(
            CommandBufferHandle commandBuffer,
            MaybeBool<uint> primitiveRestartEnable
        );

        [NativeName("vkCmdSetPrimitiveRestartIndexEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetPrimitiveRestartIndexEXT")]
        static abstract void CmdSetPrimitiveRestartIndexEXT(
            CommandBufferHandle commandBuffer,
            uint primitiveRestartIndex
        );

        [NativeName("vkCmdSetPrimitiveTopology")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetPrimitiveTopology")]
        static abstract void CmdSetPrimitiveTopology(
            CommandBufferHandle commandBuffer,
            PrimitiveTopology primitiveTopology
        );

        [NativeName("vkCmdSetPrimitiveTopologyEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetPrimitiveTopologyEXT")]
        static abstract void CmdSetPrimitiveTopologyEXT(
            CommandBufferHandle commandBuffer,
            PrimitiveTopology primitiveTopology
        );

        [NativeName("vkCmdSetProvokingVertexModeEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetProvokingVertexModeEXT")]
        static abstract void CmdSetProvokingVertexModeEXT(
            CommandBufferHandle commandBuffer,
            ProvokingVertexModeEXT provokingVertexMode
        );

        [NativeName("vkCmdSetRasterizationSamplesEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetRasterizationSamplesEXT")]
        static abstract void CmdSetRasterizationSamplesEXT(
            CommandBufferHandle commandBuffer,
            SampleCountFlags rasterizationSamples
        );

        [NativeName("vkCmdSetRasterizationStreamEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetRasterizationStreamEXT")]
        static abstract void CmdSetRasterizationStreamEXT(
            CommandBufferHandle commandBuffer,
            uint rasterizationStream
        );

        [NativeName("vkCmdSetRasterizerDiscardEnable")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetRasterizerDiscardEnable")]
        static abstract void CmdSetRasterizerDiscardEnable(
            CommandBufferHandle commandBuffer,
            uint rasterizerDiscardEnable
        );

        [NativeName("vkCmdSetRasterizerDiscardEnable")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetRasterizerDiscardEnable")]
        static abstract void CmdSetRasterizerDiscardEnable(
            CommandBufferHandle commandBuffer,
            MaybeBool<uint> rasterizerDiscardEnable
        );

        [NativeName("vkCmdSetRasterizerDiscardEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetRasterizerDiscardEnableEXT")]
        static abstract void CmdSetRasterizerDiscardEnableEXT(
            CommandBufferHandle commandBuffer,
            uint rasterizerDiscardEnable
        );

        [NativeName("vkCmdSetRasterizerDiscardEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetRasterizerDiscardEnableEXT")]
        static abstract void CmdSetRasterizerDiscardEnableEXT(
            CommandBufferHandle commandBuffer,
            MaybeBool<uint> rasterizerDiscardEnable
        );

        [NativeName("vkCmdSetRayTracingPipelineStackSizeKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetRayTracingPipelineStackSizeKHR")]
        static abstract void CmdSetRayTracingPipelineStackSizeKHR(
            CommandBufferHandle commandBuffer,
            uint pipelineStackSize
        );

        [NativeName("vkCmdSetRenderingAttachmentLocations")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetRenderingAttachmentLocations")]
        static abstract void CmdSetRenderingAttachmentLocations(
            CommandBufferHandle commandBuffer,
            RenderingAttachmentLocationInfo* pLocationInfo
        );

        [NativeName("vkCmdSetRenderingAttachmentLocations")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetRenderingAttachmentLocations")]
        static abstract void CmdSetRenderingAttachmentLocations(
            CommandBufferHandle commandBuffer,
            Ref<RenderingAttachmentLocationInfo> pLocationInfo
        );

        [NativeName("vkCmdSetRenderingAttachmentLocationsKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetRenderingAttachmentLocationsKHR")]
        static abstract void CmdSetRenderingAttachmentLocationsKHR(
            CommandBufferHandle commandBuffer,
            RenderingAttachmentLocationInfo* pLocationInfo
        );

        [NativeName("vkCmdSetRenderingAttachmentLocationsKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetRenderingAttachmentLocationsKHR")]
        static abstract void CmdSetRenderingAttachmentLocationsKHR(
            CommandBufferHandle commandBuffer,
            Ref<RenderingAttachmentLocationInfo> pLocationInfo
        );

        [NativeName("vkCmdSetRenderingInputAttachmentIndices")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetRenderingInputAttachmentIndices")]
        static abstract void CmdSetRenderingInputAttachmentIndices(
            CommandBufferHandle commandBuffer,
            RenderingInputAttachmentIndexInfo* pInputAttachmentIndexInfo
        );

        [NativeName("vkCmdSetRenderingInputAttachmentIndices")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetRenderingInputAttachmentIndices")]
        static abstract void CmdSetRenderingInputAttachmentIndices(
            CommandBufferHandle commandBuffer,
            Ref<RenderingInputAttachmentIndexInfo> pInputAttachmentIndexInfo
        );

        [NativeName("vkCmdSetRenderingInputAttachmentIndicesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetRenderingInputAttachmentIndicesKHR")]
        static abstract void CmdSetRenderingInputAttachmentIndicesKHR(
            CommandBufferHandle commandBuffer,
            RenderingInputAttachmentIndexInfo* pInputAttachmentIndexInfo
        );

        [NativeName("vkCmdSetRenderingInputAttachmentIndicesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetRenderingInputAttachmentIndicesKHR")]
        static abstract void CmdSetRenderingInputAttachmentIndicesKHR(
            CommandBufferHandle commandBuffer,
            Ref<RenderingInputAttachmentIndexInfo> pInputAttachmentIndexInfo
        );

        [NativeName("vkCmdSetRepresentativeFragmentTestEnableNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetRepresentativeFragmentTestEnableNV")]
        static abstract void CmdSetRepresentativeFragmentTestEnableNV(
            CommandBufferHandle commandBuffer,
            uint representativeFragmentTestEnable
        );

        [NativeName("vkCmdSetRepresentativeFragmentTestEnableNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetRepresentativeFragmentTestEnableNV")]
        static abstract void CmdSetRepresentativeFragmentTestEnableNV(
            CommandBufferHandle commandBuffer,
            MaybeBool<uint> representativeFragmentTestEnable
        );

        [NativeName("vkCmdSetSampleLocationsEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetSampleLocationsEnableEXT")]
        static abstract void CmdSetSampleLocationsEnableEXT(
            CommandBufferHandle commandBuffer,
            uint sampleLocationsEnable
        );

        [NativeName("vkCmdSetSampleLocationsEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetSampleLocationsEnableEXT")]
        static abstract void CmdSetSampleLocationsEnableEXT(
            CommandBufferHandle commandBuffer,
            MaybeBool<uint> sampleLocationsEnable
        );

        [NativeName("vkCmdSetSampleLocationsEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetSampleLocationsEXT")]
        static abstract void CmdSetSampleLocationsEXT(
            CommandBufferHandle commandBuffer,
            SampleLocationsInfoEXT* pSampleLocationsInfo
        );

        [NativeName("vkCmdSetSampleLocationsEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetSampleLocationsEXT")]
        static abstract void CmdSetSampleLocationsEXT(
            CommandBufferHandle commandBuffer,
            Ref<SampleLocationsInfoEXT> pSampleLocationsInfo
        );

        [NativeName("vkCmdSetSampleMaskEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetSampleMaskEXT")]
        static abstract void CmdSetSampleMaskEXT(
            CommandBufferHandle commandBuffer,
            SampleCountFlags samples,
            uint* pSampleMask
        );

        [NativeName("vkCmdSetSampleMaskEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetSampleMaskEXT")]
        static abstract void CmdSetSampleMaskEXT(
            CommandBufferHandle commandBuffer,
            SampleCountFlags samples,
            Ref<uint> pSampleMask
        );

        [NativeName("vkCmdSetScissor")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetScissor")]
        static abstract void CmdSetScissor(
            CommandBufferHandle commandBuffer,
            uint firstScissor,
            uint scissorCount,
            Rect2D* pScissors
        );

        [NativeName("vkCmdSetScissor")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetScissor")]
        static abstract void CmdSetScissor(
            CommandBufferHandle commandBuffer,
            uint firstScissor,
            uint scissorCount,
            Ref<Rect2D> pScissors
        );

        [NativeName("vkCmdSetScissor")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetScissor")]
        static abstract void CmdSetScissor(
            CommandBufferHandle commandBuffer,
            uint firstScissor,
            Rect2D pScissors
        );

        [NativeName("vkCmdSetScissorWithCount")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetScissorWithCount")]
        static abstract void CmdSetScissorWithCount(
            CommandBufferHandle commandBuffer,
            uint scissorCount,
            Rect2D* pScissors
        );

        [NativeName("vkCmdSetScissorWithCount")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetScissorWithCount")]
        static abstract void CmdSetScissorWithCount(
            CommandBufferHandle commandBuffer,
            uint scissorCount,
            Ref<Rect2D> pScissors
        );

        [NativeName("vkCmdSetScissorWithCount")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetScissorWithCount")]
        static abstract void CmdSetScissorWithCount(
            CommandBufferHandle commandBuffer,
            Rect2D pScissors
        );

        [NativeName("vkCmdSetScissorWithCountEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetScissorWithCountEXT")]
        static abstract void CmdSetScissorWithCountEXT(
            CommandBufferHandle commandBuffer,
            uint scissorCount,
            Rect2D* pScissors
        );

        [NativeName("vkCmdSetScissorWithCountEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetScissorWithCountEXT")]
        static abstract void CmdSetScissorWithCountEXT(
            CommandBufferHandle commandBuffer,
            uint scissorCount,
            Ref<Rect2D> pScissors
        );

        [NativeName("vkCmdSetScissorWithCountEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetScissorWithCountEXT")]
        static abstract void CmdSetScissorWithCountEXT(
            CommandBufferHandle commandBuffer,
            Rect2D pScissors
        );

        [NativeName("vkCmdSetShadingRateImageEnableNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetShadingRateImageEnableNV")]
        static abstract void CmdSetShadingRateImageEnableNV(
            CommandBufferHandle commandBuffer,
            uint shadingRateImageEnable
        );

        [NativeName("vkCmdSetShadingRateImageEnableNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetShadingRateImageEnableNV")]
        static abstract void CmdSetShadingRateImageEnableNV(
            CommandBufferHandle commandBuffer,
            MaybeBool<uint> shadingRateImageEnable
        );

        [NativeName("vkCmdSetStencilCompareMask")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetStencilCompareMask")]
        static abstract void CmdSetStencilCompareMask(
            CommandBufferHandle commandBuffer,
            StencilFaceFlags faceMask,
            uint compareMask
        );

        [NativeName("vkCmdSetStencilOp")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetStencilOp")]
        static abstract void CmdSetStencilOp(
            CommandBufferHandle commandBuffer,
            StencilFaceFlags faceMask,
            StencilOp failOp,
            StencilOp passOp,
            StencilOp depthFailOp,
            CompareOp compareOp
        );

        [NativeName("vkCmdSetStencilOpEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetStencilOpEXT")]
        static abstract void CmdSetStencilOpEXT(
            CommandBufferHandle commandBuffer,
            StencilFaceFlags faceMask,
            StencilOp failOp,
            StencilOp passOp,
            StencilOp depthFailOp,
            CompareOp compareOp
        );

        [NativeName("vkCmdSetStencilReference")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetStencilReference")]
        static abstract void CmdSetStencilReference(
            CommandBufferHandle commandBuffer,
            StencilFaceFlags faceMask,
            uint reference
        );

        [NativeName("vkCmdSetStencilTestEnable")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetStencilTestEnable")]
        static abstract void CmdSetStencilTestEnable(
            CommandBufferHandle commandBuffer,
            uint stencilTestEnable
        );

        [NativeName("vkCmdSetStencilTestEnable")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetStencilTestEnable")]
        static abstract void CmdSetStencilTestEnable(
            CommandBufferHandle commandBuffer,
            MaybeBool<uint> stencilTestEnable
        );

        [NativeName("vkCmdSetStencilTestEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetStencilTestEnableEXT")]
        static abstract void CmdSetStencilTestEnableEXT(
            CommandBufferHandle commandBuffer,
            uint stencilTestEnable
        );

        [NativeName("vkCmdSetStencilTestEnableEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetStencilTestEnableEXT")]
        static abstract void CmdSetStencilTestEnableEXT(
            CommandBufferHandle commandBuffer,
            MaybeBool<uint> stencilTestEnable
        );

        [NativeName("vkCmdSetStencilWriteMask")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetStencilWriteMask")]
        static abstract void CmdSetStencilWriteMask(
            CommandBufferHandle commandBuffer,
            StencilFaceFlags faceMask,
            uint writeMask
        );

        [NativeName("vkCmdSetTessellationDomainOriginEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetTessellationDomainOriginEXT")]
        static abstract void CmdSetTessellationDomainOriginEXT(
            CommandBufferHandle commandBuffer,
            TessellationDomainOrigin domainOrigin
        );

        [NativeName("vkCmdSetVertexInputEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetVertexInputEXT")]
        static abstract void CmdSetVertexInputEXT(
            CommandBufferHandle commandBuffer,
            uint vertexBindingDescriptionCount,
            VertexInputBindingDescription2EXT* pVertexBindingDescriptions,
            uint vertexAttributeDescriptionCount,
            VertexInputAttributeDescription2EXT* pVertexAttributeDescriptions
        );

        [NativeName("vkCmdSetVertexInputEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetVertexInputEXT")]
        static abstract void CmdSetVertexInputEXT(
            CommandBufferHandle commandBuffer,
            uint vertexBindingDescriptionCount,
            Ref<VertexInputBindingDescription2EXT> pVertexBindingDescriptions,
            uint vertexAttributeDescriptionCount,
            Ref<VertexInputAttributeDescription2EXT> pVertexAttributeDescriptions
        );

        [NativeName("vkCmdSetViewport")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewport")]
        static abstract void CmdSetViewport(
            CommandBufferHandle commandBuffer,
            uint firstViewport,
            uint viewportCount,
            Viewport* pViewports
        );

        [NativeName("vkCmdSetViewport")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewport")]
        static abstract void CmdSetViewport(
            CommandBufferHandle commandBuffer,
            uint firstViewport,
            uint viewportCount,
            Ref<Viewport> pViewports
        );

        [NativeName("vkCmdSetViewport")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewport")]
        static abstract void CmdSetViewport(
            CommandBufferHandle commandBuffer,
            uint firstViewport,
            Viewport pViewports
        );

        [NativeName("vkCmdSetViewportShadingRatePaletteNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewportShadingRatePaletteNV")]
        static abstract void CmdSetViewportShadingRatePaletteNV(
            CommandBufferHandle commandBuffer,
            uint firstViewport,
            uint viewportCount,
            ShadingRatePaletteNV* pShadingRatePalettes
        );

        [NativeName("vkCmdSetViewportShadingRatePaletteNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewportShadingRatePaletteNV")]
        static abstract void CmdSetViewportShadingRatePaletteNV(
            CommandBufferHandle commandBuffer,
            uint firstViewport,
            uint viewportCount,
            Ref<ShadingRatePaletteNV> pShadingRatePalettes
        );

        [NativeName("vkCmdSetViewportShadingRatePaletteNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewportShadingRatePaletteNV")]
        static abstract void CmdSetViewportShadingRatePaletteNV(
            CommandBufferHandle commandBuffer,
            uint firstViewport,
            ShadingRatePaletteNV pShadingRatePalettes
        );

        [NativeName("vkCmdSetViewportSwizzleNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewportSwizzleNV")]
        static abstract void CmdSetViewportSwizzleNV(
            CommandBufferHandle commandBuffer,
            uint firstViewport,
            uint viewportCount,
            ViewportSwizzleNV* pViewportSwizzles
        );

        [NativeName("vkCmdSetViewportSwizzleNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewportSwizzleNV")]
        static abstract void CmdSetViewportSwizzleNV(
            CommandBufferHandle commandBuffer,
            uint firstViewport,
            uint viewportCount,
            Ref<ViewportSwizzleNV> pViewportSwizzles
        );

        [NativeName("vkCmdSetViewportSwizzleNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewportSwizzleNV")]
        static abstract void CmdSetViewportSwizzleNV(
            CommandBufferHandle commandBuffer,
            uint firstViewport,
            ViewportSwizzleNV pViewportSwizzles
        );

        [NativeName("vkCmdSetViewportWithCount")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewportWithCount")]
        static abstract void CmdSetViewportWithCount(
            CommandBufferHandle commandBuffer,
            uint viewportCount,
            Viewport* pViewports
        );

        [NativeName("vkCmdSetViewportWithCount")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewportWithCount")]
        static abstract void CmdSetViewportWithCount(
            CommandBufferHandle commandBuffer,
            uint viewportCount,
            Ref<Viewport> pViewports
        );

        [NativeName("vkCmdSetViewportWithCount")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewportWithCount")]
        static abstract void CmdSetViewportWithCount(
            CommandBufferHandle commandBuffer,
            Viewport pViewports
        );

        [NativeName("vkCmdSetViewportWithCountEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewportWithCountEXT")]
        static abstract void CmdSetViewportWithCountEXT(
            CommandBufferHandle commandBuffer,
            uint viewportCount,
            Viewport* pViewports
        );

        [NativeName("vkCmdSetViewportWithCountEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewportWithCountEXT")]
        static abstract void CmdSetViewportWithCountEXT(
            CommandBufferHandle commandBuffer,
            uint viewportCount,
            Ref<Viewport> pViewports
        );

        [NativeName("vkCmdSetViewportWithCountEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewportWithCountEXT")]
        static abstract void CmdSetViewportWithCountEXT(
            CommandBufferHandle commandBuffer,
            Viewport pViewports
        );

        [NativeName("vkCmdSetViewportWScalingEnableNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewportWScalingEnableNV")]
        static abstract void CmdSetViewportWScalingEnableNV(
            CommandBufferHandle commandBuffer,
            uint viewportWScalingEnable
        );

        [NativeName("vkCmdSetViewportWScalingEnableNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewportWScalingEnableNV")]
        static abstract void CmdSetViewportWScalingEnableNV(
            CommandBufferHandle commandBuffer,
            MaybeBool<uint> viewportWScalingEnable
        );

        [NativeName("vkCmdSetViewportWScalingNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewportWScalingNV")]
        static abstract void CmdSetViewportWScalingNV(
            CommandBufferHandle commandBuffer,
            uint firstViewport,
            uint viewportCount,
            ViewportWScalingNV* pViewportWScalings
        );

        [NativeName("vkCmdSetViewportWScalingNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewportWScalingNV")]
        static abstract void CmdSetViewportWScalingNV(
            CommandBufferHandle commandBuffer,
            uint firstViewport,
            uint viewportCount,
            Ref<ViewportWScalingNV> pViewportWScalings
        );

        [NativeName("vkCmdSetViewportWScalingNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewportWScalingNV")]
        static abstract void CmdSetViewportWScalingNV(
            CommandBufferHandle commandBuffer,
            uint firstViewport,
            ViewportWScalingNV pViewportWScalings
        );

        [NativeName("vkCmdSubpassShadingHUAWEI")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdSubpassShadingHUAWEI")]
        static abstract void CmdSubpassShadingHUAWEI(CommandBufferHandle commandBuffer);

        [NativeName("vkCmdTraceRaysIndirect2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdTraceRaysIndirect2KHR")]
        static abstract void CmdTraceRaysIndirect2KHR(
            CommandBufferHandle commandBuffer,
            ulong indirectDeviceAddress
        );

        [NativeName("vkCmdTraceRaysIndirectKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdTraceRaysIndirectKHR")]
        static abstract void CmdTraceRaysIndirectKHR(
            CommandBufferHandle commandBuffer,
            StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable,
            StridedDeviceAddressRegionKHR* pMissShaderBindingTable,
            StridedDeviceAddressRegionKHR* pHitShaderBindingTable,
            StridedDeviceAddressRegionKHR* pCallableShaderBindingTable,
            ulong indirectDeviceAddress
        );

        [NativeName("vkCmdTraceRaysIndirectKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdTraceRaysIndirectKHR")]
        static abstract void CmdTraceRaysIndirectKHR(
            CommandBufferHandle commandBuffer,
            Ref<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable,
            Ref<StridedDeviceAddressRegionKHR> pMissShaderBindingTable,
            Ref<StridedDeviceAddressRegionKHR> pHitShaderBindingTable,
            Ref<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable,
            ulong indirectDeviceAddress
        );

        [NativeName("vkCmdTraceRaysKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdTraceRaysKHR")]
        static abstract void CmdTraceRaysKHR(
            CommandBufferHandle commandBuffer,
            StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable,
            StridedDeviceAddressRegionKHR* pMissShaderBindingTable,
            StridedDeviceAddressRegionKHR* pHitShaderBindingTable,
            StridedDeviceAddressRegionKHR* pCallableShaderBindingTable,
            uint width,
            uint height,
            uint depth
        );

        [NativeName("vkCmdTraceRaysKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdTraceRaysKHR")]
        static abstract void CmdTraceRaysKHR(
            CommandBufferHandle commandBuffer,
            Ref<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable,
            Ref<StridedDeviceAddressRegionKHR> pMissShaderBindingTable,
            Ref<StridedDeviceAddressRegionKHR> pHitShaderBindingTable,
            Ref<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable,
            uint width,
            uint height,
            uint depth
        );

        [NativeName("vkCmdTraceRaysNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdTraceRaysNV")]
        static abstract void CmdTraceRaysNV(
            CommandBufferHandle commandBuffer,
            BufferHandle raygenShaderBindingTableBuffer,
            ulong raygenShaderBindingOffset,
            BufferHandle missShaderBindingTableBuffer,
            ulong missShaderBindingOffset,
            ulong missShaderBindingStride,
            BufferHandle hitShaderBindingTableBuffer,
            ulong hitShaderBindingOffset,
            ulong hitShaderBindingStride,
            BufferHandle callableShaderBindingTableBuffer,
            ulong callableShaderBindingOffset,
            ulong callableShaderBindingStride,
            uint width,
            uint height,
            uint depth
        );

        [NativeName("vkCmdUpdateBuffer")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdUpdateBuffer")]
        static abstract void CmdUpdateBuffer(
            CommandBufferHandle commandBuffer,
            BufferHandle dstBuffer,
            ulong dstOffset,
            ulong dataSize,
            void* pData
        );

        [NativeName("vkCmdUpdateBuffer")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdUpdateBuffer")]
        static abstract void CmdUpdateBuffer(
            CommandBufferHandle commandBuffer,
            BufferHandle dstBuffer,
            ulong dstOffset,
            ulong dataSize,
            Ref pData
        );

        [NativeName("vkCmdUpdateMemoryKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdUpdateMemoryKHR")]
        static abstract void CmdUpdateMemoryKHR(
            CommandBufferHandle commandBuffer,
            DeviceAddressRangeKHR* pDstRange,
            AddressCommandFlagsKHR dstFlags,
            ulong dataSize,
            void* pData
        );

        [NativeName("vkCmdUpdateMemoryKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdUpdateMemoryKHR")]
        static abstract void CmdUpdateMemoryKHR(
            CommandBufferHandle commandBuffer,
            Ref<DeviceAddressRangeKHR> pDstRange,
            AddressCommandFlagsKHR dstFlags,
            ulong dataSize,
            Ref pData
        );

        [NativeName("vkCmdUpdatePipelineIndirectBufferNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdUpdatePipelineIndirectBufferNV")]
        static abstract void CmdUpdatePipelineIndirectBufferNV(
            CommandBufferHandle commandBuffer,
            PipelineBindPoint pipelineBindPoint,
            PipelineHandle pipeline
        );

        [NativeName("vkCmdWaitEvents")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdWaitEvents")]
        static abstract void CmdWaitEvents(
            CommandBufferHandle commandBuffer,
            uint eventCount,
            EventHandle* pEvents,
            PipelineStageFlags srcStageMask,
            PipelineStageFlags dstStageMask,
            uint memoryBarrierCount,
            MemoryBarrier* pMemoryBarriers,
            uint bufferMemoryBarrierCount,
            BufferMemoryBarrier* pBufferMemoryBarriers,
            uint imageMemoryBarrierCount,
            ImageMemoryBarrier* pImageMemoryBarriers
        );

        [NativeName("vkCmdWaitEvents")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdWaitEvents")]
        static abstract void CmdWaitEvents(
            CommandBufferHandle commandBuffer,
            uint eventCount,
            Ref<EventHandle> pEvents,
            PipelineStageFlags srcStageMask,
            PipelineStageFlags dstStageMask,
            uint memoryBarrierCount,
            Ref<MemoryBarrier> pMemoryBarriers,
            uint bufferMemoryBarrierCount,
            Ref<BufferMemoryBarrier> pBufferMemoryBarriers,
            uint imageMemoryBarrierCount,
            Ref<ImageMemoryBarrier> pImageMemoryBarriers
        );

        [NativeName("vkCmdWaitEvents2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdWaitEvents2")]
        static abstract void CmdWaitEvents2(
            CommandBufferHandle commandBuffer,
            uint eventCount,
            EventHandle* pEvents,
            DependencyInfo* pDependencyInfos
        );

        [NativeName("vkCmdWaitEvents2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdWaitEvents2")]
        static abstract void CmdWaitEvents2(
            CommandBufferHandle commandBuffer,
            uint eventCount,
            Ref<EventHandle> pEvents,
            Ref<DependencyInfo> pDependencyInfos
        );

        [NativeName("vkCmdWaitEvents2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdWaitEvents2KHR")]
        static abstract void CmdWaitEvents2KHR(
            CommandBufferHandle commandBuffer,
            uint eventCount,
            EventHandle* pEvents,
            DependencyInfo* pDependencyInfos
        );

        [NativeName("vkCmdWaitEvents2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdWaitEvents2KHR")]
        static abstract void CmdWaitEvents2KHR(
            CommandBufferHandle commandBuffer,
            uint eventCount,
            Ref<EventHandle> pEvents,
            Ref<DependencyInfo> pDependencyInfos
        );

        [NativeName("vkCmdWriteAccelerationStructuresPropertiesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdWriteAccelerationStructuresPropertiesKHR")]
        static abstract void CmdWriteAccelerationStructuresPropertiesKHR(
            CommandBufferHandle commandBuffer,
            uint accelerationStructureCount,
            AccelerationStructureHandleKHR* pAccelerationStructures,
            QueryType queryType,
            QueryPoolHandle queryPool,
            uint firstQuery
        );

        [NativeName("vkCmdWriteAccelerationStructuresPropertiesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdWriteAccelerationStructuresPropertiesKHR")]
        static abstract void CmdWriteAccelerationStructuresPropertiesKHR(
            CommandBufferHandle commandBuffer,
            uint accelerationStructureCount,
            Ref<AccelerationStructureHandleKHR> pAccelerationStructures,
            QueryType queryType,
            QueryPoolHandle queryPool,
            uint firstQuery
        );

        [NativeName("vkCmdWriteAccelerationStructuresPropertiesNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdWriteAccelerationStructuresPropertiesNV")]
        static abstract void CmdWriteAccelerationStructuresPropertiesNV(
            CommandBufferHandle commandBuffer,
            uint accelerationStructureCount,
            AccelerationStructureHandleNV* pAccelerationStructures,
            QueryType queryType,
            QueryPoolHandle queryPool,
            uint firstQuery
        );

        [NativeName("vkCmdWriteAccelerationStructuresPropertiesNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdWriteAccelerationStructuresPropertiesNV")]
        static abstract void CmdWriteAccelerationStructuresPropertiesNV(
            CommandBufferHandle commandBuffer,
            uint accelerationStructureCount,
            Ref<AccelerationStructureHandleNV> pAccelerationStructures,
            QueryType queryType,
            QueryPoolHandle queryPool,
            uint firstQuery
        );

        [NativeName("vkCmdWriteAccelerationStructuresPropertiesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdWriteAccelerationStructuresPropertiesKHR")]
        static abstract void CmdWriteAccelerationStructuresPropertyKHR(
            CommandBufferHandle commandBuffer,
            AccelerationStructureHandleKHR pAccelerationStructures,
            QueryType queryType,
            QueryPoolHandle queryPool,
            uint firstQuery
        );

        [NativeName("vkCmdWriteAccelerationStructuresPropertiesNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdWriteAccelerationStructuresPropertiesNV")]
        static abstract void CmdWriteAccelerationStructuresPropertyNV(
            CommandBufferHandle commandBuffer,
            AccelerationStructureHandleNV pAccelerationStructures,
            QueryType queryType,
            QueryPoolHandle queryPool,
            uint firstQuery
        );

        [NativeName("vkCmdWriteBufferMarker2AMD")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdWriteBufferMarker2AMD")]
        static abstract void CmdWriteBufferMarker2AMD(
            CommandBufferHandle commandBuffer,
            PipelineStageFlags2 stage,
            BufferHandle dstBuffer,
            ulong dstOffset,
            uint marker
        );

        [NativeName("vkCmdWriteBufferMarkerAMD")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdWriteBufferMarkerAMD")]
        static abstract void CmdWriteBufferMarkerAMD(
            CommandBufferHandle commandBuffer,
            PipelineStageFlags pipelineStage,
            BufferHandle dstBuffer,
            ulong dstOffset,
            uint marker
        );

        [NativeName("vkCmdWriteMarkerToMemoryAMD")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdWriteMarkerToMemoryAMD")]
        static abstract void CmdWriteMarkerToMemoryAMD(
            CommandBufferHandle commandBuffer,
            MemoryMarkerInfoAMD* pInfo
        );

        [NativeName("vkCmdWriteMarkerToMemoryAMD")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdWriteMarkerToMemoryAMD")]
        static abstract void CmdWriteMarkerToMemoryAMD(
            CommandBufferHandle commandBuffer,
            Ref<MemoryMarkerInfoAMD> pInfo
        );

        [NativeName("vkCmdWriteMicromapsPropertiesEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdWriteMicromapsPropertiesEXT")]
        static abstract void CmdWriteMicromapsPropertiesEXT(
            CommandBufferHandle commandBuffer,
            uint micromapCount,
            MicromapHandleEXT* pMicromaps,
            QueryType queryType,
            QueryPoolHandle queryPool,
            uint firstQuery
        );

        [NativeName("vkCmdWriteMicromapsPropertiesEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdWriteMicromapsPropertiesEXT")]
        static abstract void CmdWriteMicromapsPropertiesEXT(
            CommandBufferHandle commandBuffer,
            uint micromapCount,
            Ref<MicromapHandleEXT> pMicromaps,
            QueryType queryType,
            QueryPoolHandle queryPool,
            uint firstQuery
        );

        [NativeName("vkCmdWriteMicromapsPropertiesEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdWriteMicromapsPropertiesEXT")]
        static abstract void CmdWriteMicromapsPropertyEXT(
            CommandBufferHandle commandBuffer,
            MicromapHandleEXT pMicromaps,
            QueryType queryType,
            QueryPoolHandle queryPool,
            uint firstQuery
        );

        [NativeName("vkCmdWriteTimestamp")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdWriteTimestamp")]
        static abstract void CmdWriteTimestamp(
            CommandBufferHandle commandBuffer,
            PipelineStageFlags pipelineStage,
            QueryPoolHandle queryPool,
            uint query
        );

        [NativeName("vkCmdWriteTimestamp2")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdWriteTimestamp2")]
        static abstract void CmdWriteTimestamp2(
            CommandBufferHandle commandBuffer,
            PipelineStageFlags2 stage,
            QueryPoolHandle queryPool,
            uint query
        );

        [NativeName("vkCmdWriteTimestamp2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCmdWriteTimestamp2KHR")]
        static abstract void CmdWriteTimestamp2KHR(
            CommandBufferHandle commandBuffer,
            PipelineStageFlags2 stage,
            QueryPoolHandle queryPool,
            uint query
        );

        [NativeName("vkCompileDeferredNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCompileDeferredNV")]
        static abstract Result CompileDeferredNV(
            DeviceHandle device,
            PipelineHandle pipeline,
            uint shader
        );

        [NativeName("vkConvertCooperativeVectorMatrixNV")]
        [NativeFunction("vulkan", EntryPoint = "vkConvertCooperativeVectorMatrixNV")]
        static abstract Result ConvertCooperativeVectorMatrixNV(
            DeviceHandle device,
            ConvertCooperativeVectorMatrixInfoNV* pInfo
        );

        [NativeName("vkConvertCooperativeVectorMatrixNV")]
        [NativeFunction("vulkan", EntryPoint = "vkConvertCooperativeVectorMatrixNV")]
        static abstract Result ConvertCooperativeVectorMatrixNV(
            DeviceHandle device,
            Ref<ConvertCooperativeVectorMatrixInfoNV> pInfo
        );

        [NativeName("vkCopyAccelerationStructureKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCopyAccelerationStructureKHR")]
        static abstract Result CopyAccelerationStructureKHR(
            DeviceHandle device,
            DeferredOperationHandleKHR deferredOperation,
            CopyAccelerationStructureInfoKHR* pInfo
        );

        [NativeName("vkCopyAccelerationStructureKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCopyAccelerationStructureKHR")]
        static abstract Result CopyAccelerationStructureKHR(
            DeviceHandle device,
            DeferredOperationHandleKHR deferredOperation,
            Ref<CopyAccelerationStructureInfoKHR> pInfo
        );

        [NativeName("vkCopyAccelerationStructureToMemoryKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCopyAccelerationStructureToMemoryKHR")]
        static abstract Result CopyAccelerationStructureToMemoryKHR(
            DeviceHandle device,
            DeferredOperationHandleKHR deferredOperation,
            CopyAccelerationStructureToMemoryInfoKHR* pInfo
        );

        [NativeName("vkCopyAccelerationStructureToMemoryKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCopyAccelerationStructureToMemoryKHR")]
        static abstract Result CopyAccelerationStructureToMemoryKHR(
            DeviceHandle device,
            DeferredOperationHandleKHR deferredOperation,
            Ref<CopyAccelerationStructureToMemoryInfoKHR> pInfo
        );

        [NativeName("vkCopyImageToImage")]
        [NativeFunction("vulkan", EntryPoint = "vkCopyImageToImage")]
        static abstract Result CopyImageToImage(
            DeviceHandle device,
            CopyImageToImageInfo* pCopyImageToImageInfo
        );

        [NativeName("vkCopyImageToImage")]
        [NativeFunction("vulkan", EntryPoint = "vkCopyImageToImage")]
        static abstract Result CopyImageToImage(
            DeviceHandle device,
            Ref<CopyImageToImageInfo> pCopyImageToImageInfo
        );

        [NativeName("vkCopyImageToImageEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCopyImageToImageEXT")]
        static abstract Result CopyImageToImageEXT(
            DeviceHandle device,
            CopyImageToImageInfo* pCopyImageToImageInfo
        );

        [NativeName("vkCopyImageToImageEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCopyImageToImageEXT")]
        static abstract Result CopyImageToImageEXT(
            DeviceHandle device,
            Ref<CopyImageToImageInfo> pCopyImageToImageInfo
        );

        [NativeName("vkCopyImageToMemory")]
        [NativeFunction("vulkan", EntryPoint = "vkCopyImageToMemory")]
        static abstract Result CopyImageToMemory(
            DeviceHandle device,
            CopyImageToMemoryInfo* pCopyImageToMemoryInfo
        );

        [NativeName("vkCopyImageToMemory")]
        [NativeFunction("vulkan", EntryPoint = "vkCopyImageToMemory")]
        static abstract Result CopyImageToMemory(
            DeviceHandle device,
            Ref<CopyImageToMemoryInfo> pCopyImageToMemoryInfo
        );

        [NativeName("vkCopyImageToMemoryEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCopyImageToMemoryEXT")]
        static abstract Result CopyImageToMemoryEXT(
            DeviceHandle device,
            CopyImageToMemoryInfo* pCopyImageToMemoryInfo
        );

        [NativeName("vkCopyImageToMemoryEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCopyImageToMemoryEXT")]
        static abstract Result CopyImageToMemoryEXT(
            DeviceHandle device,
            Ref<CopyImageToMemoryInfo> pCopyImageToMemoryInfo
        );

        [NativeName("vkCopyMemoryToAccelerationStructureKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCopyMemoryToAccelerationStructureKHR")]
        static abstract Result CopyMemoryToAccelerationStructureKHR(
            DeviceHandle device,
            DeferredOperationHandleKHR deferredOperation,
            CopyMemoryToAccelerationStructureInfoKHR* pInfo
        );

        [NativeName("vkCopyMemoryToAccelerationStructureKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCopyMemoryToAccelerationStructureKHR")]
        static abstract Result CopyMemoryToAccelerationStructureKHR(
            DeviceHandle device,
            DeferredOperationHandleKHR deferredOperation,
            Ref<CopyMemoryToAccelerationStructureInfoKHR> pInfo
        );

        [NativeName("vkCopyMemoryToImage")]
        [NativeFunction("vulkan", EntryPoint = "vkCopyMemoryToImage")]
        static abstract Result CopyMemoryToImage(
            DeviceHandle device,
            CopyMemoryToImageInfo* pCopyMemoryToImageInfo
        );

        [NativeName("vkCopyMemoryToImage")]
        [NativeFunction("vulkan", EntryPoint = "vkCopyMemoryToImage")]
        static abstract Result CopyMemoryToImage(
            DeviceHandle device,
            Ref<CopyMemoryToImageInfo> pCopyMemoryToImageInfo
        );

        [NativeName("vkCopyMemoryToImageEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCopyMemoryToImageEXT")]
        static abstract Result CopyMemoryToImageEXT(
            DeviceHandle device,
            CopyMemoryToImageInfo* pCopyMemoryToImageInfo
        );

        [NativeName("vkCopyMemoryToImageEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCopyMemoryToImageEXT")]
        static abstract Result CopyMemoryToImageEXT(
            DeviceHandle device,
            Ref<CopyMemoryToImageInfo> pCopyMemoryToImageInfo
        );

        [NativeName("vkCopyMemoryToMicromapEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCopyMemoryToMicromapEXT")]
        static abstract Result CopyMemoryToMicromapEXT(
            DeviceHandle device,
            DeferredOperationHandleKHR deferredOperation,
            CopyMemoryToMicromapInfoEXT* pInfo
        );

        [NativeName("vkCopyMemoryToMicromapEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCopyMemoryToMicromapEXT")]
        static abstract Result CopyMemoryToMicromapEXT(
            DeviceHandle device,
            DeferredOperationHandleKHR deferredOperation,
            Ref<CopyMemoryToMicromapInfoEXT> pInfo
        );

        [NativeName("vkCopyMicromapEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCopyMicromapEXT")]
        static abstract Result CopyMicromapEXT(
            DeviceHandle device,
            DeferredOperationHandleKHR deferredOperation,
            CopyMicromapInfoEXT* pInfo
        );

        [NativeName("vkCopyMicromapEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCopyMicromapEXT")]
        static abstract Result CopyMicromapEXT(
            DeviceHandle device,
            DeferredOperationHandleKHR deferredOperation,
            Ref<CopyMicromapInfoEXT> pInfo
        );

        [NativeName("vkCopyMicromapToMemoryEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCopyMicromapToMemoryEXT")]
        static abstract Result CopyMicromapToMemoryEXT(
            DeviceHandle device,
            DeferredOperationHandleKHR deferredOperation,
            CopyMicromapToMemoryInfoEXT* pInfo
        );

        [NativeName("vkCopyMicromapToMemoryEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCopyMicromapToMemoryEXT")]
        static abstract Result CopyMicromapToMemoryEXT(
            DeviceHandle device,
            DeferredOperationHandleKHR deferredOperation,
            Ref<CopyMicromapToMemoryInfoEXT> pInfo
        );

        [NativeName("vkCreateAccelerationStructure2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateAccelerationStructure2KHR")]
        static abstract Result CreateAccelerationStructure2KHR(
            DeviceHandle device,
            AccelerationStructureCreateInfo2KHR* pCreateInfo,
            AllocationCallbacks* pAllocator,
            AccelerationStructureHandleKHR* pAccelerationStructure
        );

        [NativeName("vkCreateAccelerationStructure2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateAccelerationStructure2KHR")]
        static abstract Result CreateAccelerationStructure2KHR(
            DeviceHandle device,
            Ref<AccelerationStructureCreateInfo2KHR> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<AccelerationStructureHandleKHR> pAccelerationStructure
        );

        [NativeName("vkCreateAccelerationStructureKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateAccelerationStructureKHR")]
        static abstract Result CreateAccelerationStructureKHR(
            DeviceHandle device,
            AccelerationStructureCreateInfoKHR* pCreateInfo,
            AllocationCallbacks* pAllocator,
            AccelerationStructureHandleKHR* pAccelerationStructure
        );

        [NativeName("vkCreateAccelerationStructureKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateAccelerationStructureKHR")]
        static abstract Result CreateAccelerationStructureKHR(
            DeviceHandle device,
            Ref<AccelerationStructureCreateInfoKHR> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<AccelerationStructureHandleKHR> pAccelerationStructure
        );

        [NativeName("vkCreateAccelerationStructureNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateAccelerationStructureNV")]
        static abstract Result CreateAccelerationStructureNV(
            DeviceHandle device,
            AccelerationStructureCreateInfoNV* pCreateInfo,
            AllocationCallbacks* pAllocator,
            AccelerationStructureHandleNV* pAccelerationStructure
        );

        [NativeName("vkCreateAccelerationStructureNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateAccelerationStructureNV")]
        static abstract Result CreateAccelerationStructureNV(
            DeviceHandle device,
            Ref<AccelerationStructureCreateInfoNV> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<AccelerationStructureHandleNV> pAccelerationStructure
        );

        [NativeName("vkCreateBuffer")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateBuffer")]
        static abstract Result CreateBuffer(
            DeviceHandle device,
            BufferCreateInfo* pCreateInfo,
            AllocationCallbacks* pAllocator,
            BufferHandle* pBuffer
        );

        [NativeName("vkCreateBuffer")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateBuffer")]
        static abstract Result CreateBuffer(
            DeviceHandle device,
            Ref<BufferCreateInfo> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<BufferHandle> pBuffer
        );

        [NativeName("vkCreateBufferView")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateBufferView")]
        static abstract Result CreateBufferView(
            DeviceHandle device,
            BufferViewCreateInfo* pCreateInfo,
            AllocationCallbacks* pAllocator,
            BufferViewHandle* pView
        );

        [NativeName("vkCreateBufferView")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateBufferView")]
        static abstract Result CreateBufferView(
            DeviceHandle device,
            Ref<BufferViewCreateInfo> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<BufferViewHandle> pView
        );

        [NativeName("vkCreateCommandPool")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateCommandPool")]
        static abstract Result CreateCommandPool(
            DeviceHandle device,
            CommandPoolCreateInfo* pCreateInfo,
            AllocationCallbacks* pAllocator,
            CommandPoolHandle* pCommandPool
        );

        [NativeName("vkCreateCommandPool")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateCommandPool")]
        static abstract Result CreateCommandPool(
            DeviceHandle device,
            Ref<CommandPoolCreateInfo> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<CommandPoolHandle> pCommandPool
        );

        [NativeName("vkCreateComputePipelines")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateComputePipelines")]
        static abstract Result CreateComputePipelines(
            DeviceHandle device,
            PipelineCacheHandle pipelineCache,
            uint createInfoCount,
            ComputePipelineCreateInfo* pCreateInfos,
            AllocationCallbacks* pAllocator,
            PipelineHandle* pPipelines
        );

        [NativeName("vkCreateComputePipelines")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateComputePipelines")]
        static abstract Result CreateComputePipelines(
            DeviceHandle device,
            PipelineCacheHandle pipelineCache,
            uint createInfoCount,
            Ref<ComputePipelineCreateInfo> pCreateInfos,
            Ref<AllocationCallbacks> pAllocator,
            Ref<PipelineHandle> pPipelines
        );

        [NativeName("vkCreateCuFunctionNVX")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateCuFunctionNVX")]
        static abstract Result CreateCuFunctionNVX(
            DeviceHandle device,
            CuFunctionCreateInfoNVX* pCreateInfo,
            AllocationCallbacks* pAllocator,
            CuFunctionHandleNVX* pFunction
        );

        [NativeName("vkCreateCuFunctionNVX")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateCuFunctionNVX")]
        static abstract Result CreateCuFunctionNVX(
            DeviceHandle device,
            Ref<CuFunctionCreateInfoNVX> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<CuFunctionHandleNVX> pFunction
        );

        [NativeName("vkCreateCuModuleNVX")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateCuModuleNVX")]
        static abstract Result CreateCuModuleNVX(
            DeviceHandle device,
            CuModuleCreateInfoNVX* pCreateInfo,
            AllocationCallbacks* pAllocator,
            CuModuleHandleNVX* pModule
        );

        [NativeName("vkCreateCuModuleNVX")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateCuModuleNVX")]
        static abstract Result CreateCuModuleNVX(
            DeviceHandle device,
            Ref<CuModuleCreateInfoNVX> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<CuModuleHandleNVX> pModule
        );

        [NativeName("vkCreateDataGraphPipelinesARM")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateDataGraphPipelinesARM")]
        static abstract Result CreateDataGraphPipelinesARM(
            DeviceHandle device,
            DeferredOperationHandleKHR deferredOperation,
            PipelineCacheHandle pipelineCache,
            uint createInfoCount,
            DataGraphPipelineCreateInfoARM* pCreateInfos,
            AllocationCallbacks* pAllocator,
            PipelineHandle* pPipelines
        );

        [NativeName("vkCreateDataGraphPipelinesARM")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateDataGraphPipelinesARM")]
        static abstract Result CreateDataGraphPipelinesARM(
            DeviceHandle device,
            DeferredOperationHandleKHR deferredOperation,
            PipelineCacheHandle pipelineCache,
            uint createInfoCount,
            Ref<DataGraphPipelineCreateInfoARM> pCreateInfos,
            Ref<AllocationCallbacks> pAllocator,
            Ref<PipelineHandle> pPipelines
        );

        [NativeName("vkCreateDataGraphPipelineSessionARM")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateDataGraphPipelineSessionARM")]
        static abstract Result CreateDataGraphPipelineSessionARM(
            DeviceHandle device,
            DataGraphPipelineSessionCreateInfoARM* pCreateInfo,
            AllocationCallbacks* pAllocator,
            DataGraphPipelineSessionHandleARM* pSession
        );

        [NativeName("vkCreateDataGraphPipelineSessionARM")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateDataGraphPipelineSessionARM")]
        static abstract Result CreateDataGraphPipelineSessionARM(
            DeviceHandle device,
            Ref<DataGraphPipelineSessionCreateInfoARM> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<DataGraphPipelineSessionHandleARM> pSession
        );

        [NativeName("vkCreateDebugReportCallbackEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateDebugReportCallbackEXT")]
        static abstract Result CreateDebugReportCallbackEXT(
            InstanceHandle instance,
            DebugReportCallbackCreateInfoEXT* pCreateInfo,
            AllocationCallbacks* pAllocator,
            DebugReportCallbackHandleEXT* pCallback
        );

        [NativeName("vkCreateDebugReportCallbackEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateDebugReportCallbackEXT")]
        static abstract Result CreateDebugReportCallbackEXT(
            InstanceHandle instance,
            Ref<DebugReportCallbackCreateInfoEXT> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<DebugReportCallbackHandleEXT> pCallback
        );

        [NativeName("vkCreateDebugUtilsMessengerEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateDebugUtilsMessengerEXT")]
        static abstract Result CreateDebugUtilsMessengerEXT(
            InstanceHandle instance,
            DebugUtilsMessengerCreateInfoEXT* pCreateInfo,
            AllocationCallbacks* pAllocator,
            DebugUtilsMessengerHandleEXT* pMessenger
        );

        [NativeName("vkCreateDebugUtilsMessengerEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateDebugUtilsMessengerEXT")]
        static abstract Result CreateDebugUtilsMessengerEXT(
            InstanceHandle instance,
            Ref<DebugUtilsMessengerCreateInfoEXT> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<DebugUtilsMessengerHandleEXT> pMessenger
        );

        [NativeName("vkCreateDeferredOperationKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateDeferredOperationKHR")]
        static abstract Result CreateDeferredOperationKHR(
            DeviceHandle device,
            AllocationCallbacks* pAllocator,
            DeferredOperationHandleKHR* pDeferredOperation
        );

        [NativeName("vkCreateDeferredOperationKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateDeferredOperationKHR")]
        static abstract Result CreateDeferredOperationKHR(
            DeviceHandle device,
            Ref<AllocationCallbacks> pAllocator,
            Ref<DeferredOperationHandleKHR> pDeferredOperation
        );

        [NativeName("vkCreateDescriptorPool")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateDescriptorPool")]
        static abstract Result CreateDescriptorPool(
            DeviceHandle device,
            DescriptorPoolCreateInfo* pCreateInfo,
            AllocationCallbacks* pAllocator,
            DescriptorPoolHandle* pDescriptorPool
        );

        [NativeName("vkCreateDescriptorPool")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateDescriptorPool")]
        static abstract Result CreateDescriptorPool(
            DeviceHandle device,
            Ref<DescriptorPoolCreateInfo> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<DescriptorPoolHandle> pDescriptorPool
        );

        [NativeName("vkCreateDescriptorSetLayout")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateDescriptorSetLayout")]
        static abstract Result CreateDescriptorSetLayout(
            DeviceHandle device,
            DescriptorSetLayoutCreateInfo* pCreateInfo,
            AllocationCallbacks* pAllocator,
            DescriptorSetLayoutHandle* pSetLayout
        );

        [NativeName("vkCreateDescriptorSetLayout")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateDescriptorSetLayout")]
        static abstract Result CreateDescriptorSetLayout(
            DeviceHandle device,
            Ref<DescriptorSetLayoutCreateInfo> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<DescriptorSetLayoutHandle> pSetLayout
        );

        [NativeName("vkCreateDescriptorUpdateTemplate")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateDescriptorUpdateTemplate")]
        static abstract Result CreateDescriptorUpdateTemplate(
            DeviceHandle device,
            DescriptorUpdateTemplateCreateInfo* pCreateInfo,
            AllocationCallbacks* pAllocator,
            DescriptorUpdateTemplateHandle* pDescriptorUpdateTemplate
        );

        [NativeName("vkCreateDescriptorUpdateTemplate")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateDescriptorUpdateTemplate")]
        static abstract Result CreateDescriptorUpdateTemplate(
            DeviceHandle device,
            Ref<DescriptorUpdateTemplateCreateInfo> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<DescriptorUpdateTemplateHandle> pDescriptorUpdateTemplate
        );

        [NativeName("vkCreateDescriptorUpdateTemplateKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateDescriptorUpdateTemplateKHR")]
        static abstract Result CreateDescriptorUpdateTemplateKHR(
            DeviceHandle device,
            DescriptorUpdateTemplateCreateInfo* pCreateInfo,
            AllocationCallbacks* pAllocator,
            DescriptorUpdateTemplateHandle* pDescriptorUpdateTemplate
        );

        [NativeName("vkCreateDescriptorUpdateTemplateKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateDescriptorUpdateTemplateKHR")]
        static abstract Result CreateDescriptorUpdateTemplateKHR(
            DeviceHandle device,
            Ref<DescriptorUpdateTemplateCreateInfo> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<DescriptorUpdateTemplateHandle> pDescriptorUpdateTemplate
        );

        [NativeName("vkCreateDevice")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateDevice")]
        static abstract Result CreateDevice(
            PhysicalDeviceHandle physicalDevice,
            DeviceCreateInfo* pCreateInfo,
            AllocationCallbacks* pAllocator,
            DeviceHandle* pDevice
        );

        [NativeName("vkCreateDevice")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateDevice")]
        static abstract Result CreateDevice(
            PhysicalDeviceHandle physicalDevice,
            Ref<DeviceCreateInfo> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<DeviceHandle> pDevice
        );

        [NativeName("vkCreateDisplayModeKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateDisplayModeKHR")]
        static abstract Result CreateDisplayModeKHR(
            PhysicalDeviceHandle physicalDevice,
            DisplayHandleKHR display,
            DisplayModeCreateInfoKHR* pCreateInfo,
            AllocationCallbacks* pAllocator,
            DisplayModeHandleKHR* pMode
        );

        [NativeName("vkCreateDisplayModeKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateDisplayModeKHR")]
        static abstract Result CreateDisplayModeKHR(
            PhysicalDeviceHandle physicalDevice,
            DisplayHandleKHR display,
            Ref<DisplayModeCreateInfoKHR> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<DisplayModeHandleKHR> pMode
        );

        [NativeName("vkCreateDisplayPlaneSurfaceKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateDisplayPlaneSurfaceKHR")]
        static abstract Result CreateDisplayPlaneSurfaceKHR(
            InstanceHandle instance,
            DisplaySurfaceCreateInfoKHR* pCreateInfo,
            AllocationCallbacks* pAllocator,
            SurfaceHandleKHR* pSurface
        );

        [NativeName("vkCreateDisplayPlaneSurfaceKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateDisplayPlaneSurfaceKHR")]
        static abstract Result CreateDisplayPlaneSurfaceKHR(
            InstanceHandle instance,
            Ref<DisplaySurfaceCreateInfoKHR> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<SurfaceHandleKHR> pSurface
        );

        [NativeName("vkCreateEvent")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateEvent")]
        static abstract Result CreateEvent(
            DeviceHandle device,
            EventCreateInfo* pCreateInfo,
            AllocationCallbacks* pAllocator,
            EventHandle* pEvent
        );

        [NativeName("vkCreateEvent")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateEvent")]
        static abstract Result CreateEvent(
            DeviceHandle device,
            Ref<EventCreateInfo> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<EventHandle> pEvent
        );

        [NativeName("vkCreateExternalComputeQueueNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateExternalComputeQueueNV")]
        static abstract Result CreateExternalComputeQueueNV(
            DeviceHandle device,
            ExternalComputeQueueCreateInfoNV* pCreateInfo,
            AllocationCallbacks* pAllocator,
            ExternalComputeQueueHandleNV* pExternalQueue
        );

        [NativeName("vkCreateExternalComputeQueueNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateExternalComputeQueueNV")]
        static abstract Result CreateExternalComputeQueueNV(
            DeviceHandle device,
            Ref<ExternalComputeQueueCreateInfoNV> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<ExternalComputeQueueHandleNV> pExternalQueue
        );

        [NativeName("vkCreateFence")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateFence")]
        static abstract Result CreateFence(
            DeviceHandle device,
            FenceCreateInfo* pCreateInfo,
            AllocationCallbacks* pAllocator,
            FenceHandle* pFence
        );

        [NativeName("vkCreateFence")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateFence")]
        static abstract Result CreateFence(
            DeviceHandle device,
            Ref<FenceCreateInfo> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<FenceHandle> pFence
        );

        [NativeName("vkCreateFramebuffer")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateFramebuffer")]
        static abstract Result CreateFramebuffer(
            DeviceHandle device,
            FramebufferCreateInfo* pCreateInfo,
            AllocationCallbacks* pAllocator,
            FramebufferHandle* pFramebuffer
        );

        [NativeName("vkCreateFramebuffer")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateFramebuffer")]
        static abstract Result CreateFramebuffer(
            DeviceHandle device,
            Ref<FramebufferCreateInfo> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<FramebufferHandle> pFramebuffer
        );

        [NativeName("vkCreateGpaSessionAMD")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateGpaSessionAMD")]
        static abstract Result CreateGpaSessionAMD(
            DeviceHandle device,
            GpaSessionCreateInfoAMD* pCreateInfo,
            AllocationCallbacks* pAllocator,
            GpaSessionHandleAMD* pGpaSession
        );

        [NativeName("vkCreateGpaSessionAMD")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateGpaSessionAMD")]
        static abstract Result CreateGpaSessionAMD(
            DeviceHandle device,
            Ref<GpaSessionCreateInfoAMD> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<GpaSessionHandleAMD> pGpaSession
        );

        [NativeName("vkCreateGraphicsPipelines")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateGraphicsPipelines")]
        static abstract Result CreateGraphicsPipelines(
            DeviceHandle device,
            PipelineCacheHandle pipelineCache,
            uint createInfoCount,
            GraphicsPipelineCreateInfo* pCreateInfos,
            AllocationCallbacks* pAllocator,
            PipelineHandle* pPipelines
        );

        [NativeName("vkCreateGraphicsPipelines")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateGraphicsPipelines")]
        static abstract Result CreateGraphicsPipelines(
            DeviceHandle device,
            PipelineCacheHandle pipelineCache,
            uint createInfoCount,
            Ref<GraphicsPipelineCreateInfo> pCreateInfos,
            Ref<AllocationCallbacks> pAllocator,
            Ref<PipelineHandle> pPipelines
        );

        [NativeName("vkCreateHeadlessSurfaceEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateHeadlessSurfaceEXT")]
        static abstract Result CreateHeadlessSurfaceEXT(
            InstanceHandle instance,
            HeadlessSurfaceCreateInfoEXT* pCreateInfo,
            AllocationCallbacks* pAllocator,
            SurfaceHandleKHR* pSurface
        );

        [NativeName("vkCreateHeadlessSurfaceEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateHeadlessSurfaceEXT")]
        static abstract Result CreateHeadlessSurfaceEXT(
            InstanceHandle instance,
            Ref<HeadlessSurfaceCreateInfoEXT> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<SurfaceHandleKHR> pSurface
        );

        [NativeName("vkCreateImage")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateImage")]
        static abstract Result CreateImage(
            DeviceHandle device,
            ImageCreateInfo* pCreateInfo,
            AllocationCallbacks* pAllocator,
            ImageHandle* pImage
        );

        [NativeName("vkCreateImage")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateImage")]
        static abstract Result CreateImage(
            DeviceHandle device,
            Ref<ImageCreateInfo> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<ImageHandle> pImage
        );

        [NativeName("vkCreateImageView")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateImageView")]
        static abstract Result CreateImageView(
            DeviceHandle device,
            ImageViewCreateInfo* pCreateInfo,
            AllocationCallbacks* pAllocator,
            ImageViewHandle* pView
        );

        [NativeName("vkCreateImageView")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateImageView")]
        static abstract Result CreateImageView(
            DeviceHandle device,
            Ref<ImageViewCreateInfo> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<ImageViewHandle> pView
        );

        [NativeName("vkCreateIndirectCommandsLayoutEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateIndirectCommandsLayoutEXT")]
        static abstract Result CreateIndirectCommandsLayoutEXT(
            DeviceHandle device,
            IndirectCommandsLayoutCreateInfoEXT* pCreateInfo,
            AllocationCallbacks* pAllocator,
            IndirectCommandsLayoutHandleEXT* pIndirectCommandsLayout
        );

        [NativeName("vkCreateIndirectCommandsLayoutEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateIndirectCommandsLayoutEXT")]
        static abstract Result CreateIndirectCommandsLayoutEXT(
            DeviceHandle device,
            Ref<IndirectCommandsLayoutCreateInfoEXT> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<IndirectCommandsLayoutHandleEXT> pIndirectCommandsLayout
        );

        [NativeName("vkCreateIndirectCommandsLayoutNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateIndirectCommandsLayoutNV")]
        static abstract Result CreateIndirectCommandsLayoutNV(
            DeviceHandle device,
            IndirectCommandsLayoutCreateInfoNV* pCreateInfo,
            AllocationCallbacks* pAllocator,
            IndirectCommandsLayoutHandleNV* pIndirectCommandsLayout
        );

        [NativeName("vkCreateIndirectCommandsLayoutNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateIndirectCommandsLayoutNV")]
        static abstract Result CreateIndirectCommandsLayoutNV(
            DeviceHandle device,
            Ref<IndirectCommandsLayoutCreateInfoNV> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<IndirectCommandsLayoutHandleNV> pIndirectCommandsLayout
        );

        [NativeName("vkCreateIndirectExecutionSetEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateIndirectExecutionSetEXT")]
        static abstract Result CreateIndirectExecutionSetEXT(
            DeviceHandle device,
            IndirectExecutionSetCreateInfoEXT* pCreateInfo,
            AllocationCallbacks* pAllocator,
            IndirectExecutionSetHandleEXT* pIndirectExecutionSet
        );

        [NativeName("vkCreateIndirectExecutionSetEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateIndirectExecutionSetEXT")]
        static abstract Result CreateIndirectExecutionSetEXT(
            DeviceHandle device,
            Ref<IndirectExecutionSetCreateInfoEXT> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<IndirectExecutionSetHandleEXT> pIndirectExecutionSet
        );

        [NativeName("vkCreateInstance")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateInstance")]
        static abstract Result CreateInstance(
            InstanceCreateInfo* pCreateInfo,
            AllocationCallbacks* pAllocator,
            InstanceHandle* pInstance
        );

        [NativeName("vkCreateInstance")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateInstance")]
        static abstract Result CreateInstance(
            Ref<InstanceCreateInfo> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<InstanceHandle> pInstance
        );

        [NativeName("vkCreateMicromapEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateMicromapEXT")]
        static abstract Result CreateMicromapEXT(
            DeviceHandle device,
            MicromapCreateInfoEXT* pCreateInfo,
            AllocationCallbacks* pAllocator,
            MicromapHandleEXT* pMicromap
        );

        [NativeName("vkCreateMicromapEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateMicromapEXT")]
        static abstract Result CreateMicromapEXT(
            DeviceHandle device,
            Ref<MicromapCreateInfoEXT> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<MicromapHandleEXT> pMicromap
        );

        [NativeName("vkCreateOpticalFlowSessionNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateOpticalFlowSessionNV")]
        static abstract Result CreateOpticalFlowSessionNV(
            DeviceHandle device,
            OpticalFlowSessionCreateInfoNV* pCreateInfo,
            AllocationCallbacks* pAllocator,
            OpticalFlowSessionHandleNV* pSession
        );

        [NativeName("vkCreateOpticalFlowSessionNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateOpticalFlowSessionNV")]
        static abstract Result CreateOpticalFlowSessionNV(
            DeviceHandle device,
            Ref<OpticalFlowSessionCreateInfoNV> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<OpticalFlowSessionHandleNV> pSession
        );

        [NativeName("vkCreatePipelineBinariesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCreatePipelineBinariesKHR")]
        static abstract Result CreatePipelineBinariesKHR(
            DeviceHandle device,
            PipelineBinaryCreateInfoKHR* pCreateInfo,
            AllocationCallbacks* pAllocator,
            PipelineBinaryHandlesInfoKHR* pBinaries
        );

        [NativeName("vkCreatePipelineBinariesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCreatePipelineBinariesKHR")]
        static abstract Result CreatePipelineBinariesKHR(
            DeviceHandle device,
            Ref<PipelineBinaryCreateInfoKHR> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<PipelineBinaryHandlesInfoKHR> pBinaries
        );

        [NativeName("vkCreatePipelineCache")]
        [NativeFunction("vulkan", EntryPoint = "vkCreatePipelineCache")]
        static abstract Result CreatePipelineCache(
            DeviceHandle device,
            PipelineCacheCreateInfo* pCreateInfo,
            AllocationCallbacks* pAllocator,
            PipelineCacheHandle* pPipelineCache
        );

        [NativeName("vkCreatePipelineCache")]
        [NativeFunction("vulkan", EntryPoint = "vkCreatePipelineCache")]
        static abstract Result CreatePipelineCache(
            DeviceHandle device,
            Ref<PipelineCacheCreateInfo> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<PipelineCacheHandle> pPipelineCache
        );

        [NativeName("vkCreatePipelineLayout")]
        [NativeFunction("vulkan", EntryPoint = "vkCreatePipelineLayout")]
        static abstract Result CreatePipelineLayout(
            DeviceHandle device,
            PipelineLayoutCreateInfo* pCreateInfo,
            AllocationCallbacks* pAllocator,
            PipelineLayoutHandle* pPipelineLayout
        );

        [NativeName("vkCreatePipelineLayout")]
        [NativeFunction("vulkan", EntryPoint = "vkCreatePipelineLayout")]
        static abstract Result CreatePipelineLayout(
            DeviceHandle device,
            Ref<PipelineLayoutCreateInfo> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<PipelineLayoutHandle> pPipelineLayout
        );

        [NativeName("vkCreatePrivateDataSlot")]
        [NativeFunction("vulkan", EntryPoint = "vkCreatePrivateDataSlot")]
        static abstract Result CreatePrivateDataSlot(
            DeviceHandle device,
            PrivateDataSlotCreateInfo* pCreateInfo,
            AllocationCallbacks* pAllocator,
            PrivateDataSlotHandle* pPrivateDataSlot
        );

        [NativeName("vkCreatePrivateDataSlot")]
        [NativeFunction("vulkan", EntryPoint = "vkCreatePrivateDataSlot")]
        static abstract Result CreatePrivateDataSlot(
            DeviceHandle device,
            Ref<PrivateDataSlotCreateInfo> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<PrivateDataSlotHandle> pPrivateDataSlot
        );

        [NativeName("vkCreatePrivateDataSlotEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCreatePrivateDataSlotEXT")]
        static abstract Result CreatePrivateDataSlotEXT(
            DeviceHandle device,
            PrivateDataSlotCreateInfo* pCreateInfo,
            AllocationCallbacks* pAllocator,
            PrivateDataSlotHandle* pPrivateDataSlot
        );

        [NativeName("vkCreatePrivateDataSlotEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCreatePrivateDataSlotEXT")]
        static abstract Result CreatePrivateDataSlotEXT(
            DeviceHandle device,
            Ref<PrivateDataSlotCreateInfo> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<PrivateDataSlotHandle> pPrivateDataSlot
        );

        [NativeName("vkCreateQueryPool")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateQueryPool")]
        static abstract Result CreateQueryPool(
            DeviceHandle device,
            QueryPoolCreateInfo* pCreateInfo,
            AllocationCallbacks* pAllocator,
            QueryPoolHandle* pQueryPool
        );

        [NativeName("vkCreateQueryPool")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateQueryPool")]
        static abstract Result CreateQueryPool(
            DeviceHandle device,
            Ref<QueryPoolCreateInfo> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<QueryPoolHandle> pQueryPool
        );

        [NativeName("vkCreateRayTracingPipelinesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateRayTracingPipelinesKHR")]
        static abstract Result CreateRayTracingPipelinesKHR(
            DeviceHandle device,
            DeferredOperationHandleKHR deferredOperation,
            PipelineCacheHandle pipelineCache,
            uint createInfoCount,
            RayTracingPipelineCreateInfoKHR* pCreateInfos,
            AllocationCallbacks* pAllocator,
            PipelineHandle* pPipelines
        );

        [NativeName("vkCreateRayTracingPipelinesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateRayTracingPipelinesKHR")]
        static abstract Result CreateRayTracingPipelinesKHR(
            DeviceHandle device,
            DeferredOperationHandleKHR deferredOperation,
            PipelineCacheHandle pipelineCache,
            uint createInfoCount,
            Ref<RayTracingPipelineCreateInfoKHR> pCreateInfos,
            Ref<AllocationCallbacks> pAllocator,
            Ref<PipelineHandle> pPipelines
        );

        [NativeName("vkCreateRayTracingPipelinesNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateRayTracingPipelinesNV")]
        static abstract Result CreateRayTracingPipelinesNV(
            DeviceHandle device,
            PipelineCacheHandle pipelineCache,
            uint createInfoCount,
            RayTracingPipelineCreateInfoNV* pCreateInfos,
            AllocationCallbacks* pAllocator,
            PipelineHandle* pPipelines
        );

        [NativeName("vkCreateRayTracingPipelinesNV")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateRayTracingPipelinesNV")]
        static abstract Result CreateRayTracingPipelinesNV(
            DeviceHandle device,
            PipelineCacheHandle pipelineCache,
            uint createInfoCount,
            Ref<RayTracingPipelineCreateInfoNV> pCreateInfos,
            Ref<AllocationCallbacks> pAllocator,
            Ref<PipelineHandle> pPipelines
        );

        [NativeName("vkCreateRenderPass")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateRenderPass")]
        static abstract Result CreateRenderPass(
            DeviceHandle device,
            RenderPassCreateInfo* pCreateInfo,
            AllocationCallbacks* pAllocator,
            RenderPassHandle* pRenderPass
        );

        [NativeName("vkCreateRenderPass")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateRenderPass")]
        static abstract Result CreateRenderPass(
            DeviceHandle device,
            Ref<RenderPassCreateInfo> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<RenderPassHandle> pRenderPass
        );

        [NativeName("vkCreateRenderPass2")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateRenderPass2")]
        static abstract Result CreateRenderPass2(
            DeviceHandle device,
            RenderPassCreateInfo2* pCreateInfo,
            AllocationCallbacks* pAllocator,
            RenderPassHandle* pRenderPass
        );

        [NativeName("vkCreateRenderPass2")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateRenderPass2")]
        static abstract Result CreateRenderPass2(
            DeviceHandle device,
            Ref<RenderPassCreateInfo2> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<RenderPassHandle> pRenderPass
        );

        [NativeName("vkCreateRenderPass2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateRenderPass2KHR")]
        static abstract Result CreateRenderPass2KHR(
            DeviceHandle device,
            RenderPassCreateInfo2* pCreateInfo,
            AllocationCallbacks* pAllocator,
            RenderPassHandle* pRenderPass
        );

        [NativeName("vkCreateRenderPass2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateRenderPass2KHR")]
        static abstract Result CreateRenderPass2KHR(
            DeviceHandle device,
            Ref<RenderPassCreateInfo2> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<RenderPassHandle> pRenderPass
        );

        [NativeName("vkCreateSampler")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateSampler")]
        static abstract Result CreateSampler(
            DeviceHandle device,
            SamplerCreateInfo* pCreateInfo,
            AllocationCallbacks* pAllocator,
            SamplerHandle* pSampler
        );

        [NativeName("vkCreateSampler")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateSampler")]
        static abstract Result CreateSampler(
            DeviceHandle device,
            Ref<SamplerCreateInfo> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<SamplerHandle> pSampler
        );

        [NativeName("vkCreateSamplerYcbcrConversion")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateSamplerYcbcrConversion")]
        static abstract Result CreateSamplerYcbcrConversion(
            DeviceHandle device,
            SamplerYcbcrConversionCreateInfo* pCreateInfo,
            AllocationCallbacks* pAllocator,
            SamplerYcbcrConversionHandle* pYcbcrConversion
        );

        [NativeName("vkCreateSamplerYcbcrConversion")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateSamplerYcbcrConversion")]
        static abstract Result CreateSamplerYcbcrConversion(
            DeviceHandle device,
            Ref<SamplerYcbcrConversionCreateInfo> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<SamplerYcbcrConversionHandle> pYcbcrConversion
        );

        [NativeName("vkCreateSamplerYcbcrConversionKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateSamplerYcbcrConversionKHR")]
        static abstract Result CreateSamplerYcbcrConversionKHR(
            DeviceHandle device,
            SamplerYcbcrConversionCreateInfo* pCreateInfo,
            AllocationCallbacks* pAllocator,
            SamplerYcbcrConversionHandle* pYcbcrConversion
        );

        [NativeName("vkCreateSamplerYcbcrConversionKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateSamplerYcbcrConversionKHR")]
        static abstract Result CreateSamplerYcbcrConversionKHR(
            DeviceHandle device,
            Ref<SamplerYcbcrConversionCreateInfo> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<SamplerYcbcrConversionHandle> pYcbcrConversion
        );

        [NativeName("vkCreateSemaphore")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateSemaphore")]
        static abstract Result CreateSemaphore(
            DeviceHandle device,
            SemaphoreCreateInfo* pCreateInfo,
            AllocationCallbacks* pAllocator,
            SemaphoreHandle* pSemaphore
        );

        [NativeName("vkCreateSemaphore")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateSemaphore")]
        static abstract Result CreateSemaphore(
            DeviceHandle device,
            Ref<SemaphoreCreateInfo> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<SemaphoreHandle> pSemaphore
        );

        [NativeName("vkCreateShaderInstrumentationARM")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateShaderInstrumentationARM")]
        static abstract Result CreateShaderInstrumentationARM(
            DeviceHandle device,
            ShaderInstrumentationCreateInfoARM* pCreateInfo,
            AllocationCallbacks* pAllocator,
            ShaderInstrumentationHandleARM* pInstrumentation
        );

        [NativeName("vkCreateShaderInstrumentationARM")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateShaderInstrumentationARM")]
        static abstract Result CreateShaderInstrumentationARM(
            DeviceHandle device,
            Ref<ShaderInstrumentationCreateInfoARM> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<ShaderInstrumentationHandleARM> pInstrumentation
        );

        [NativeName("vkCreateShaderModule")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateShaderModule")]
        static abstract Result CreateShaderModule(
            DeviceHandle device,
            ShaderModuleCreateInfo* pCreateInfo,
            AllocationCallbacks* pAllocator,
            ShaderModuleHandle* pShaderModule
        );

        [NativeName("vkCreateShaderModule")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateShaderModule")]
        static abstract Result CreateShaderModule(
            DeviceHandle device,
            Ref<ShaderModuleCreateInfo> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<ShaderModuleHandle> pShaderModule
        );

        [NativeName("vkCreateShadersEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateShadersEXT")]
        static abstract Result CreateShadersEXT(
            DeviceHandle device,
            uint createInfoCount,
            ShaderCreateInfoEXT* pCreateInfos,
            AllocationCallbacks* pAllocator,
            ShaderHandleEXT* pShaders
        );

        [NativeName("vkCreateShadersEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateShadersEXT")]
        static abstract Result CreateShadersEXT(
            DeviceHandle device,
            uint createInfoCount,
            Ref<ShaderCreateInfoEXT> pCreateInfos,
            Ref<AllocationCallbacks> pAllocator,
            Ref<ShaderHandleEXT> pShaders
        );

        [NativeName("vkCreateSharedSwapchainsKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateSharedSwapchainsKHR")]
        static abstract Result CreateSharedSwapchainsKHR(
            DeviceHandle device,
            uint swapchainCount,
            SwapchainCreateInfoKHR* pCreateInfos,
            AllocationCallbacks* pAllocator,
            SwapchainHandleKHR* pSwapchains
        );

        [NativeName("vkCreateSharedSwapchainsKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateSharedSwapchainsKHR")]
        static abstract Result CreateSharedSwapchainsKHR(
            DeviceHandle device,
            uint swapchainCount,
            Ref<SwapchainCreateInfoKHR> pCreateInfos,
            Ref<AllocationCallbacks> pAllocator,
            Ref<SwapchainHandleKHR> pSwapchains
        );

        [NativeName("vkCreateSwapchainKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateSwapchainKHR")]
        static abstract Result CreateSwapchainKHR(
            DeviceHandle device,
            SwapchainCreateInfoKHR* pCreateInfo,
            AllocationCallbacks* pAllocator,
            SwapchainHandleKHR* pSwapchain
        );

        [NativeName("vkCreateSwapchainKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateSwapchainKHR")]
        static abstract Result CreateSwapchainKHR(
            DeviceHandle device,
            Ref<SwapchainCreateInfoKHR> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<SwapchainHandleKHR> pSwapchain
        );

        [NativeName("vkCreateTensorARM")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateTensorARM")]
        static abstract Result CreateTensorARM(
            DeviceHandle device,
            TensorCreateInfoARM* pCreateInfo,
            AllocationCallbacks* pAllocator,
            TensorHandleARM* pTensor
        );

        [NativeName("vkCreateTensorARM")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateTensorARM")]
        static abstract Result CreateTensorARM(
            DeviceHandle device,
            Ref<TensorCreateInfoARM> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<TensorHandleARM> pTensor
        );

        [NativeName("vkCreateTensorViewARM")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateTensorViewARM")]
        static abstract Result CreateTensorViewARM(
            DeviceHandle device,
            TensorViewCreateInfoARM* pCreateInfo,
            AllocationCallbacks* pAllocator,
            TensorViewHandleARM* pView
        );

        [NativeName("vkCreateTensorViewARM")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateTensorViewARM")]
        static abstract Result CreateTensorViewARM(
            DeviceHandle device,
            Ref<TensorViewCreateInfoARM> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<TensorViewHandleARM> pView
        );

        [NativeName("vkCreateValidationCacheEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateValidationCacheEXT")]
        static abstract Result CreateValidationCacheEXT(
            DeviceHandle device,
            ValidationCacheCreateInfoEXT* pCreateInfo,
            AllocationCallbacks* pAllocator,
            ValidationCacheHandleEXT* pValidationCache
        );

        [NativeName("vkCreateValidationCacheEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateValidationCacheEXT")]
        static abstract Result CreateValidationCacheEXT(
            DeviceHandle device,
            Ref<ValidationCacheCreateInfoEXT> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<ValidationCacheHandleEXT> pValidationCache
        );

        [NativeName("vkCreateVideoSessionKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateVideoSessionKHR")]
        static abstract Result CreateVideoSessionKHR(
            DeviceHandle device,
            VideoSessionCreateInfoKHR* pCreateInfo,
            AllocationCallbacks* pAllocator,
            VideoSessionHandleKHR* pVideoSession
        );

        [NativeName("vkCreateVideoSessionKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateVideoSessionKHR")]
        static abstract Result CreateVideoSessionKHR(
            DeviceHandle device,
            Ref<VideoSessionCreateInfoKHR> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<VideoSessionHandleKHR> pVideoSession
        );

        [NativeName("vkCreateVideoSessionParametersKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateVideoSessionParametersKHR")]
        static abstract Result CreateVideoSessionParametersKHR(
            DeviceHandle device,
            VideoSessionParametersCreateInfoKHR* pCreateInfo,
            AllocationCallbacks* pAllocator,
            VideoSessionParametersHandleKHR* pVideoSessionParameters
        );

        [NativeName("vkCreateVideoSessionParametersKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkCreateVideoSessionParametersKHR")]
        static abstract Result CreateVideoSessionParametersKHR(
            DeviceHandle device,
            Ref<VideoSessionParametersCreateInfoKHR> pCreateInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<VideoSessionParametersHandleKHR> pVideoSessionParameters
        );

        [NativeName("vkDebugMarkerSetObjectNameEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkDebugMarkerSetObjectNameEXT")]
        static abstract Result DebugMarkerSetObjectNameEXT(
            DeviceHandle device,
            DebugMarkerObjectNameInfoEXT* pNameInfo
        );

        [NativeName("vkDebugMarkerSetObjectNameEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkDebugMarkerSetObjectNameEXT")]
        static abstract Result DebugMarkerSetObjectNameEXT(
            DeviceHandle device,
            Ref<DebugMarkerObjectNameInfoEXT> pNameInfo
        );

        [NativeName("vkDebugMarkerSetObjectTagEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkDebugMarkerSetObjectTagEXT")]
        static abstract Result DebugMarkerSetObjectTagEXT(
            DeviceHandle device,
            DebugMarkerObjectTagInfoEXT* pTagInfo
        );

        [NativeName("vkDebugMarkerSetObjectTagEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkDebugMarkerSetObjectTagEXT")]
        static abstract Result DebugMarkerSetObjectTagEXT(
            DeviceHandle device,
            Ref<DebugMarkerObjectTagInfoEXT> pTagInfo
        );

        [NativeName("vkDebugReportMessageEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkDebugReportMessageEXT")]
        static abstract void DebugReportMessageEXT(
            InstanceHandle instance,
            DebugReportFlagsEXT flags,
            DebugReportObjectTypeEXT objectType,
            ulong @object,
            nuint location,
            int messageCode,
            sbyte* pLayerPrefix,
            sbyte* pMessage
        );

        [NativeName("vkDebugReportMessageEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkDebugReportMessageEXT")]
        static abstract void DebugReportMessageEXT(
            InstanceHandle instance,
            DebugReportFlagsEXT flags,
            DebugReportObjectTypeEXT objectType,
            ulong @object,
            nuint location,
            int messageCode,
            Ref<sbyte> pLayerPrefix,
            Ref<sbyte> pMessage
        );

        [NativeName("vkDeferredOperationJoinKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkDeferredOperationJoinKHR")]
        static abstract Result DeferredOperationJoinKHR(
            DeviceHandle device,
            DeferredOperationHandleKHR operation
        );

        [NativeName("vkDestroyAccelerationStructureKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyAccelerationStructureKHR")]
        static abstract void DestroyAccelerationStructureKHR(
            DeviceHandle device,
            AccelerationStructureHandleKHR accelerationStructure,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyAccelerationStructureKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyAccelerationStructureKHR")]
        static abstract void DestroyAccelerationStructureKHR(
            DeviceHandle device,
            AccelerationStructureHandleKHR accelerationStructure,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyAccelerationStructureNV")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyAccelerationStructureNV")]
        static abstract void DestroyAccelerationStructureNV(
            DeviceHandle device,
            AccelerationStructureHandleNV accelerationStructure,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyAccelerationStructureNV")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyAccelerationStructureNV")]
        static abstract void DestroyAccelerationStructureNV(
            DeviceHandle device,
            AccelerationStructureHandleNV accelerationStructure,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyBuffer")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyBuffer")]
        static abstract void DestroyBuffer(
            DeviceHandle device,
            BufferHandle buffer,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyBuffer")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyBuffer")]
        static abstract void DestroyBuffer(
            DeviceHandle device,
            BufferHandle buffer,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyBufferView")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyBufferView")]
        static abstract void DestroyBufferView(
            DeviceHandle device,
            BufferViewHandle bufferView,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyBufferView")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyBufferView")]
        static abstract void DestroyBufferView(
            DeviceHandle device,
            BufferViewHandle bufferView,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyCommandPool")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyCommandPool")]
        static abstract void DestroyCommandPool(
            DeviceHandle device,
            CommandPoolHandle commandPool,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyCommandPool")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyCommandPool")]
        static abstract void DestroyCommandPool(
            DeviceHandle device,
            CommandPoolHandle commandPool,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyCuFunctionNVX")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyCuFunctionNVX")]
        static abstract void DestroyCuFunctionNVX(
            DeviceHandle device,
            CuFunctionHandleNVX function,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyCuFunctionNVX")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyCuFunctionNVX")]
        static abstract void DestroyCuFunctionNVX(
            DeviceHandle device,
            CuFunctionHandleNVX function,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyCuModuleNVX")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyCuModuleNVX")]
        static abstract void DestroyCuModuleNVX(
            DeviceHandle device,
            CuModuleHandleNVX module,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyCuModuleNVX")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyCuModuleNVX")]
        static abstract void DestroyCuModuleNVX(
            DeviceHandle device,
            CuModuleHandleNVX module,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyDataGraphPipelineSessionARM")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyDataGraphPipelineSessionARM")]
        static abstract void DestroyDataGraphPipelineSessionARM(
            DeviceHandle device,
            DataGraphPipelineSessionHandleARM session,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyDataGraphPipelineSessionARM")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyDataGraphPipelineSessionARM")]
        static abstract void DestroyDataGraphPipelineSessionARM(
            DeviceHandle device,
            DataGraphPipelineSessionHandleARM session,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyDebugReportCallbackEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyDebugReportCallbackEXT")]
        static abstract void DestroyDebugReportCallbackEXT(
            InstanceHandle instance,
            DebugReportCallbackHandleEXT callback,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyDebugReportCallbackEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyDebugReportCallbackEXT")]
        static abstract void DestroyDebugReportCallbackEXT(
            InstanceHandle instance,
            DebugReportCallbackHandleEXT callback,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyDebugUtilsMessengerEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyDebugUtilsMessengerEXT")]
        static abstract void DestroyDebugUtilsMessengerEXT(
            InstanceHandle instance,
            DebugUtilsMessengerHandleEXT messenger,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyDebugUtilsMessengerEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyDebugUtilsMessengerEXT")]
        static abstract void DestroyDebugUtilsMessengerEXT(
            InstanceHandle instance,
            DebugUtilsMessengerHandleEXT messenger,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyDeferredOperationKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyDeferredOperationKHR")]
        static abstract void DestroyDeferredOperationKHR(
            DeviceHandle device,
            DeferredOperationHandleKHR operation,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyDeferredOperationKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyDeferredOperationKHR")]
        static abstract void DestroyDeferredOperationKHR(
            DeviceHandle device,
            DeferredOperationHandleKHR operation,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyDescriptorPool")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyDescriptorPool")]
        static abstract void DestroyDescriptorPool(
            DeviceHandle device,
            DescriptorPoolHandle descriptorPool,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyDescriptorPool")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyDescriptorPool")]
        static abstract void DestroyDescriptorPool(
            DeviceHandle device,
            DescriptorPoolHandle descriptorPool,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyDescriptorSetLayout")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyDescriptorSetLayout")]
        static abstract void DestroyDescriptorSetLayout(
            DeviceHandle device,
            DescriptorSetLayoutHandle descriptorSetLayout,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyDescriptorSetLayout")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyDescriptorSetLayout")]
        static abstract void DestroyDescriptorSetLayout(
            DeviceHandle device,
            DescriptorSetLayoutHandle descriptorSetLayout,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyDescriptorUpdateTemplate")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyDescriptorUpdateTemplate")]
        static abstract void DestroyDescriptorUpdateTemplate(
            DeviceHandle device,
            DescriptorUpdateTemplateHandle descriptorUpdateTemplate,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyDescriptorUpdateTemplate")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyDescriptorUpdateTemplate")]
        static abstract void DestroyDescriptorUpdateTemplate(
            DeviceHandle device,
            DescriptorUpdateTemplateHandle descriptorUpdateTemplate,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyDescriptorUpdateTemplateKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyDescriptorUpdateTemplateKHR")]
        static abstract void DestroyDescriptorUpdateTemplateKHR(
            DeviceHandle device,
            DescriptorUpdateTemplateHandle descriptorUpdateTemplate,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyDescriptorUpdateTemplateKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyDescriptorUpdateTemplateKHR")]
        static abstract void DestroyDescriptorUpdateTemplateKHR(
            DeviceHandle device,
            DescriptorUpdateTemplateHandle descriptorUpdateTemplate,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyDevice")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyDevice")]
        static abstract void DestroyDevice(DeviceHandle device, AllocationCallbacks* pAllocator);

        [NativeName("vkDestroyDevice")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyDevice")]
        static abstract void DestroyDevice(
            DeviceHandle device,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyEvent")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyEvent")]
        static abstract void DestroyEvent(
            DeviceHandle device,
            EventHandle @event,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyEvent")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyEvent")]
        static abstract void DestroyEvent(
            DeviceHandle device,
            EventHandle @event,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyExternalComputeQueueNV")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyExternalComputeQueueNV")]
        static abstract void DestroyExternalComputeQueueNV(
            DeviceHandle device,
            ExternalComputeQueueHandleNV externalQueue,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyExternalComputeQueueNV")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyExternalComputeQueueNV")]
        static abstract void DestroyExternalComputeQueueNV(
            DeviceHandle device,
            ExternalComputeQueueHandleNV externalQueue,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyFence")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyFence")]
        static abstract void DestroyFence(
            DeviceHandle device,
            FenceHandle fence,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyFence")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyFence")]
        static abstract void DestroyFence(
            DeviceHandle device,
            FenceHandle fence,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyFramebuffer")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyFramebuffer")]
        static abstract void DestroyFramebuffer(
            DeviceHandle device,
            FramebufferHandle framebuffer,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyFramebuffer")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyFramebuffer")]
        static abstract void DestroyFramebuffer(
            DeviceHandle device,
            FramebufferHandle framebuffer,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyGpaSessionAMD")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyGpaSessionAMD")]
        static abstract void DestroyGpaSessionAMD(
            DeviceHandle device,
            GpaSessionHandleAMD gpaSession,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyGpaSessionAMD")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyGpaSessionAMD")]
        static abstract void DestroyGpaSessionAMD(
            DeviceHandle device,
            GpaSessionHandleAMD gpaSession,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyImage")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyImage")]
        static abstract void DestroyImage(
            DeviceHandle device,
            ImageHandle image,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyImage")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyImage")]
        static abstract void DestroyImage(
            DeviceHandle device,
            ImageHandle image,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyImageView")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyImageView")]
        static abstract void DestroyImageView(
            DeviceHandle device,
            ImageViewHandle imageView,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyImageView")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyImageView")]
        static abstract void DestroyImageView(
            DeviceHandle device,
            ImageViewHandle imageView,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyIndirectCommandsLayoutEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyIndirectCommandsLayoutEXT")]
        static abstract void DestroyIndirectCommandsLayoutEXT(
            DeviceHandle device,
            IndirectCommandsLayoutHandleEXT indirectCommandsLayout,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyIndirectCommandsLayoutEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyIndirectCommandsLayoutEXT")]
        static abstract void DestroyIndirectCommandsLayoutEXT(
            DeviceHandle device,
            IndirectCommandsLayoutHandleEXT indirectCommandsLayout,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyIndirectCommandsLayoutNV")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyIndirectCommandsLayoutNV")]
        static abstract void DestroyIndirectCommandsLayoutNV(
            DeviceHandle device,
            IndirectCommandsLayoutHandleNV indirectCommandsLayout,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyIndirectCommandsLayoutNV")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyIndirectCommandsLayoutNV")]
        static abstract void DestroyIndirectCommandsLayoutNV(
            DeviceHandle device,
            IndirectCommandsLayoutHandleNV indirectCommandsLayout,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyIndirectExecutionSetEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyIndirectExecutionSetEXT")]
        static abstract void DestroyIndirectExecutionSetEXT(
            DeviceHandle device,
            IndirectExecutionSetHandleEXT indirectExecutionSet,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyIndirectExecutionSetEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyIndirectExecutionSetEXT")]
        static abstract void DestroyIndirectExecutionSetEXT(
            DeviceHandle device,
            IndirectExecutionSetHandleEXT indirectExecutionSet,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyInstance")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyInstance")]
        static abstract void DestroyInstance(
            InstanceHandle instance,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyInstance")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyInstance")]
        static abstract void DestroyInstance(
            InstanceHandle instance,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyMicromapEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyMicromapEXT")]
        static abstract void DestroyMicromapEXT(
            DeviceHandle device,
            MicromapHandleEXT micromap,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyMicromapEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyMicromapEXT")]
        static abstract void DestroyMicromapEXT(
            DeviceHandle device,
            MicromapHandleEXT micromap,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyOpticalFlowSessionNV")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyOpticalFlowSessionNV")]
        static abstract void DestroyOpticalFlowSessionNV(
            DeviceHandle device,
            OpticalFlowSessionHandleNV session,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyOpticalFlowSessionNV")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyOpticalFlowSessionNV")]
        static abstract void DestroyOpticalFlowSessionNV(
            DeviceHandle device,
            OpticalFlowSessionHandleNV session,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyPipeline")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyPipeline")]
        static abstract void DestroyPipeline(
            DeviceHandle device,
            PipelineHandle pipeline,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyPipeline")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyPipeline")]
        static abstract void DestroyPipeline(
            DeviceHandle device,
            PipelineHandle pipeline,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyPipelineBinaryKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyPipelineBinaryKHR")]
        static abstract void DestroyPipelineBinaryKHR(
            DeviceHandle device,
            PipelineBinaryHandleKHR pipelineBinary,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyPipelineBinaryKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyPipelineBinaryKHR")]
        static abstract void DestroyPipelineBinaryKHR(
            DeviceHandle device,
            PipelineBinaryHandleKHR pipelineBinary,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyPipelineCache")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyPipelineCache")]
        static abstract void DestroyPipelineCache(
            DeviceHandle device,
            PipelineCacheHandle pipelineCache,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyPipelineCache")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyPipelineCache")]
        static abstract void DestroyPipelineCache(
            DeviceHandle device,
            PipelineCacheHandle pipelineCache,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyPipelineLayout")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyPipelineLayout")]
        static abstract void DestroyPipelineLayout(
            DeviceHandle device,
            PipelineLayoutHandle pipelineLayout,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyPipelineLayout")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyPipelineLayout")]
        static abstract void DestroyPipelineLayout(
            DeviceHandle device,
            PipelineLayoutHandle pipelineLayout,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyPrivateDataSlot")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyPrivateDataSlot")]
        static abstract void DestroyPrivateDataSlot(
            DeviceHandle device,
            PrivateDataSlotHandle privateDataSlot,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyPrivateDataSlot")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyPrivateDataSlot")]
        static abstract void DestroyPrivateDataSlot(
            DeviceHandle device,
            PrivateDataSlotHandle privateDataSlot,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyPrivateDataSlotEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyPrivateDataSlotEXT")]
        static abstract void DestroyPrivateDataSlotEXT(
            DeviceHandle device,
            PrivateDataSlotHandle privateDataSlot,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyPrivateDataSlotEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyPrivateDataSlotEXT")]
        static abstract void DestroyPrivateDataSlotEXT(
            DeviceHandle device,
            PrivateDataSlotHandle privateDataSlot,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyQueryPool")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyQueryPool")]
        static abstract void DestroyQueryPool(
            DeviceHandle device,
            QueryPoolHandle queryPool,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyQueryPool")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyQueryPool")]
        static abstract void DestroyQueryPool(
            DeviceHandle device,
            QueryPoolHandle queryPool,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyRenderPass")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyRenderPass")]
        static abstract void DestroyRenderPass(
            DeviceHandle device,
            RenderPassHandle renderPass,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyRenderPass")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyRenderPass")]
        static abstract void DestroyRenderPass(
            DeviceHandle device,
            RenderPassHandle renderPass,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroySampler")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroySampler")]
        static abstract void DestroySampler(
            DeviceHandle device,
            SamplerHandle sampler,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroySampler")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroySampler")]
        static abstract void DestroySampler(
            DeviceHandle device,
            SamplerHandle sampler,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroySamplerYcbcrConversion")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroySamplerYcbcrConversion")]
        static abstract void DestroySamplerYcbcrConversion(
            DeviceHandle device,
            SamplerYcbcrConversionHandle ycbcrConversion,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroySamplerYcbcrConversion")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroySamplerYcbcrConversion")]
        static abstract void DestroySamplerYcbcrConversion(
            DeviceHandle device,
            SamplerYcbcrConversionHandle ycbcrConversion,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroySamplerYcbcrConversionKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroySamplerYcbcrConversionKHR")]
        static abstract void DestroySamplerYcbcrConversionKHR(
            DeviceHandle device,
            SamplerYcbcrConversionHandle ycbcrConversion,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroySamplerYcbcrConversionKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroySamplerYcbcrConversionKHR")]
        static abstract void DestroySamplerYcbcrConversionKHR(
            DeviceHandle device,
            SamplerYcbcrConversionHandle ycbcrConversion,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroySemaphore")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroySemaphore")]
        static abstract void DestroySemaphore(
            DeviceHandle device,
            SemaphoreHandle semaphore,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroySemaphore")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroySemaphore")]
        static abstract void DestroySemaphore(
            DeviceHandle device,
            SemaphoreHandle semaphore,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyShaderEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyShaderEXT")]
        static abstract void DestroyShaderEXT(
            DeviceHandle device,
            ShaderHandleEXT shader,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyShaderEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyShaderEXT")]
        static abstract void DestroyShaderEXT(
            DeviceHandle device,
            ShaderHandleEXT shader,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyShaderInstrumentationARM")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyShaderInstrumentationARM")]
        static abstract void DestroyShaderInstrumentationARM(
            DeviceHandle device,
            ShaderInstrumentationHandleARM instrumentation,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyShaderInstrumentationARM")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyShaderInstrumentationARM")]
        static abstract void DestroyShaderInstrumentationARM(
            DeviceHandle device,
            ShaderInstrumentationHandleARM instrumentation,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyShaderModule")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyShaderModule")]
        static abstract void DestroyShaderModule(
            DeviceHandle device,
            ShaderModuleHandle shaderModule,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyShaderModule")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyShaderModule")]
        static abstract void DestroyShaderModule(
            DeviceHandle device,
            ShaderModuleHandle shaderModule,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroySurfaceKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroySurfaceKHR")]
        static abstract void DestroySurfaceKHR(
            InstanceHandle instance,
            SurfaceHandleKHR surface,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroySurfaceKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroySurfaceKHR")]
        static abstract void DestroySurfaceKHR(
            InstanceHandle instance,
            SurfaceHandleKHR surface,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroySwapchainKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroySwapchainKHR")]
        static abstract void DestroySwapchainKHR(
            DeviceHandle device,
            SwapchainHandleKHR swapchain,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroySwapchainKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroySwapchainKHR")]
        static abstract void DestroySwapchainKHR(
            DeviceHandle device,
            SwapchainHandleKHR swapchain,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyTensorARM")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyTensorARM")]
        static abstract void DestroyTensorARM(
            DeviceHandle device,
            TensorHandleARM tensor,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyTensorARM")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyTensorARM")]
        static abstract void DestroyTensorARM(
            DeviceHandle device,
            TensorHandleARM tensor,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyTensorViewARM")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyTensorViewARM")]
        static abstract void DestroyTensorViewARM(
            DeviceHandle device,
            TensorViewHandleARM tensorView,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyTensorViewARM")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyTensorViewARM")]
        static abstract void DestroyTensorViewARM(
            DeviceHandle device,
            TensorViewHandleARM tensorView,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyValidationCacheEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyValidationCacheEXT")]
        static abstract void DestroyValidationCacheEXT(
            DeviceHandle device,
            ValidationCacheHandleEXT validationCache,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyValidationCacheEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyValidationCacheEXT")]
        static abstract void DestroyValidationCacheEXT(
            DeviceHandle device,
            ValidationCacheHandleEXT validationCache,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyVideoSessionKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyVideoSessionKHR")]
        static abstract void DestroyVideoSessionKHR(
            DeviceHandle device,
            VideoSessionHandleKHR videoSession,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyVideoSessionKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyVideoSessionKHR")]
        static abstract void DestroyVideoSessionKHR(
            DeviceHandle device,
            VideoSessionHandleKHR videoSession,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDestroyVideoSessionParametersKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyVideoSessionParametersKHR")]
        static abstract void DestroyVideoSessionParametersKHR(
            DeviceHandle device,
            VideoSessionParametersHandleKHR videoSessionParameters,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkDestroyVideoSessionParametersKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkDestroyVideoSessionParametersKHR")]
        static abstract void DestroyVideoSessionParametersKHR(
            DeviceHandle device,
            VideoSessionParametersHandleKHR videoSessionParameters,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkDeviceWaitIdle")]
        [NativeFunction("vulkan", EntryPoint = "vkDeviceWaitIdle")]
        static abstract Result DeviceWaitIdle(DeviceHandle device);

        [NativeName("vkDisplayPowerControlEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkDisplayPowerControlEXT")]
        static abstract Result DisplayPowerControlEXT(
            DeviceHandle device,
            DisplayHandleKHR display,
            DisplayPowerInfoEXT* pDisplayPowerInfo
        );

        [NativeName("vkDisplayPowerControlEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkDisplayPowerControlEXT")]
        static abstract Result DisplayPowerControlEXT(
            DeviceHandle device,
            DisplayHandleKHR display,
            Ref<DisplayPowerInfoEXT> pDisplayPowerInfo
        );

        [NativeName("vkEndCommandBuffer")]
        [NativeFunction("vulkan", EntryPoint = "vkEndCommandBuffer")]
        static abstract Result EndCommandBuffer(CommandBufferHandle commandBuffer);

        [NativeName("vkEnumerateDeviceExtensionProperties")]
        [NativeFunction("vulkan", EntryPoint = "vkEnumerateDeviceExtensionProperties")]
        static abstract Result EnumerateDeviceExtensionProperties(
            PhysicalDeviceHandle physicalDevice,
            sbyte* pLayerName,
            uint* pPropertyCount,
            ExtensionProperties* pProperties
        );

        [NativeName("vkEnumerateDeviceExtensionProperties")]
        [NativeFunction("vulkan", EntryPoint = "vkEnumerateDeviceExtensionProperties")]
        static abstract Result EnumerateDeviceExtensionProperties(
            PhysicalDeviceHandle physicalDevice,
            Ref<sbyte> pLayerName,
            Ref<uint> pPropertyCount,
            Ref<ExtensionProperties> pProperties
        );

        [NativeName("vkEnumerateDeviceLayerProperties")]
        [NativeFunction("vulkan", EntryPoint = "vkEnumerateDeviceLayerProperties")]
        static abstract Result EnumerateDeviceLayerProperties(
            PhysicalDeviceHandle physicalDevice,
            uint* pPropertyCount,
            LayerProperties* pProperties
        );

        [NativeName("vkEnumerateDeviceLayerProperties")]
        [NativeFunction("vulkan", EntryPoint = "vkEnumerateDeviceLayerProperties")]
        static abstract Result EnumerateDeviceLayerProperties(
            PhysicalDeviceHandle physicalDevice,
            Ref<uint> pPropertyCount,
            Ref<LayerProperties> pProperties
        );

        [NativeName("vkEnumerateInstanceExtensionProperties")]
        [NativeFunction("vulkan", EntryPoint = "vkEnumerateInstanceExtensionProperties")]
        static abstract Result EnumerateInstanceExtensionProperties(
            sbyte* pLayerName,
            uint* pPropertyCount,
            ExtensionProperties* pProperties
        );

        [NativeName("vkEnumerateInstanceExtensionProperties")]
        [NativeFunction("vulkan", EntryPoint = "vkEnumerateInstanceExtensionProperties")]
        static abstract Result EnumerateInstanceExtensionProperties(
            Ref<sbyte> pLayerName,
            Ref<uint> pPropertyCount,
            Ref<ExtensionProperties> pProperties
        );

        [NativeName("vkEnumerateInstanceLayerProperties")]
        [NativeFunction("vulkan", EntryPoint = "vkEnumerateInstanceLayerProperties")]
        static abstract Result EnumerateInstanceLayerProperties(
            uint* pPropertyCount,
            LayerProperties* pProperties
        );

        [NativeName("vkEnumerateInstanceLayerProperties")]
        [NativeFunction("vulkan", EntryPoint = "vkEnumerateInstanceLayerProperties")]
        static abstract Result EnumerateInstanceLayerProperties(
            Ref<uint> pPropertyCount,
            Ref<LayerProperties> pProperties
        );

        [NativeName("vkEnumerateInstanceVersion")]
        [NativeFunction("vulkan", EntryPoint = "vkEnumerateInstanceVersion")]
        static abstract Result EnumerateInstanceVersion(uint* pApiVersion);

        [NativeName("vkEnumerateInstanceVersion")]
        [NativeFunction("vulkan", EntryPoint = "vkEnumerateInstanceVersion")]
        static abstract Result EnumerateInstanceVersion(Ref<uint> pApiVersion);

        [NativeName("vkEnumeratePhysicalDeviceGroups")]
        [NativeFunction("vulkan", EntryPoint = "vkEnumeratePhysicalDeviceGroups")]
        static abstract Result EnumeratePhysicalDeviceGroups(
            InstanceHandle instance,
            uint* pPhysicalDeviceGroupCount,
            PhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties
        );

        [NativeName("vkEnumeratePhysicalDeviceGroups")]
        [NativeFunction("vulkan", EntryPoint = "vkEnumeratePhysicalDeviceGroups")]
        static abstract Result EnumeratePhysicalDeviceGroups(
            InstanceHandle instance,
            Ref<uint> pPhysicalDeviceGroupCount,
            Ref<PhysicalDeviceGroupProperties> pPhysicalDeviceGroupProperties
        );

        [NativeName("vkEnumeratePhysicalDeviceGroupsKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkEnumeratePhysicalDeviceGroupsKHR")]
        static abstract Result EnumeratePhysicalDeviceGroupsKHR(
            InstanceHandle instance,
            uint* pPhysicalDeviceGroupCount,
            PhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties
        );

        [NativeName("vkEnumeratePhysicalDeviceGroupsKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkEnumeratePhysicalDeviceGroupsKHR")]
        static abstract Result EnumeratePhysicalDeviceGroupsKHR(
            InstanceHandle instance,
            Ref<uint> pPhysicalDeviceGroupCount,
            Ref<PhysicalDeviceGroupProperties> pPhysicalDeviceGroupProperties
        );

        [NativeName("vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM")]
        [NativeFunction(
            "vulkan",
            EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM"
        )]
        static abstract Result EnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM(
            PhysicalDeviceHandle physicalDevice,
            uint queueFamilyIndex,
            uint* pCounterCount,
            PerformanceCounterARM* pCounters,
            PerformanceCounterDescriptionARM* pCounterDescriptions
        );

        [NativeName("vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM")]
        [NativeFunction(
            "vulkan",
            EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM"
        )]
        static abstract Result EnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM(
            PhysicalDeviceHandle physicalDevice,
            uint queueFamilyIndex,
            Ref<uint> pCounterCount,
            Ref<PerformanceCounterARM> pCounters,
            Ref<PerformanceCounterDescriptionARM> pCounterDescriptions
        );

        [NativeName("vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR")]
        [NativeFunction(
            "vulkan",
            EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR"
        )]
        static abstract Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(
            PhysicalDeviceHandle physicalDevice,
            uint queueFamilyIndex,
            uint* pCounterCount,
            PerformanceCounterKHR* pCounters,
            PerformanceCounterDescriptionKHR* pCounterDescriptions
        );

        [NativeName("vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR")]
        [NativeFunction(
            "vulkan",
            EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR"
        )]
        static abstract Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(
            PhysicalDeviceHandle physicalDevice,
            uint queueFamilyIndex,
            Ref<uint> pCounterCount,
            Ref<PerformanceCounterKHR> pCounters,
            Ref<PerformanceCounterDescriptionKHR> pCounterDescriptions
        );

        [NativeName("vkEnumeratePhysicalDevices")]
        [NativeFunction("vulkan", EntryPoint = "vkEnumeratePhysicalDevices")]
        static abstract Result EnumeratePhysicalDevices(
            InstanceHandle instance,
            uint* pPhysicalDeviceCount,
            PhysicalDeviceHandle* pPhysicalDevices
        );

        [NativeName("vkEnumeratePhysicalDevices")]
        [NativeFunction("vulkan", EntryPoint = "vkEnumeratePhysicalDevices")]
        static abstract Result EnumeratePhysicalDevices(
            InstanceHandle instance,
            Ref<uint> pPhysicalDeviceCount,
            Ref<PhysicalDeviceHandle> pPhysicalDevices
        );

        [NativeName("vkEnumeratePhysicalDeviceShaderInstrumentationMetricsARM")]
        [NativeFunction(
            "vulkan",
            EntryPoint = "vkEnumeratePhysicalDeviceShaderInstrumentationMetricsARM"
        )]
        static abstract Result EnumeratePhysicalDeviceShaderInstrumentationMetricsARM(
            PhysicalDeviceHandle physicalDevice,
            uint* pDescriptionCount,
            ShaderInstrumentationMetricDescriptionARM* pDescriptions
        );

        [NativeName("vkEnumeratePhysicalDeviceShaderInstrumentationMetricsARM")]
        [NativeFunction(
            "vulkan",
            EntryPoint = "vkEnumeratePhysicalDeviceShaderInstrumentationMetricsARM"
        )]
        static abstract Result EnumeratePhysicalDeviceShaderInstrumentationMetricsARM(
            PhysicalDeviceHandle physicalDevice,
            Ref<uint> pDescriptionCount,
            Ref<ShaderInstrumentationMetricDescriptionARM> pDescriptions
        );

        [NativeName("vkFlushMappedMemoryRanges")]
        [NativeFunction("vulkan", EntryPoint = "vkFlushMappedMemoryRanges")]
        static abstract Result FlushMappedMemoryRanges(
            DeviceHandle device,
            uint memoryRangeCount,
            MappedMemoryRange* pMemoryRanges
        );

        [NativeName("vkFlushMappedMemoryRanges")]
        [NativeFunction("vulkan", EntryPoint = "vkFlushMappedMemoryRanges")]
        static abstract Result FlushMappedMemoryRanges(
            DeviceHandle device,
            uint memoryRangeCount,
            Ref<MappedMemoryRange> pMemoryRanges
        );

        [NativeName("vkFreeCommandBuffers")]
        [NativeFunction("vulkan", EntryPoint = "vkFreeCommandBuffers")]
        static abstract void FreeCommandBuffer(
            DeviceHandle device,
            CommandPoolHandle commandPool,
            CommandBufferHandle pCommandBuffers
        );

        [NativeName("vkFreeCommandBuffers")]
        [NativeFunction("vulkan", EntryPoint = "vkFreeCommandBuffers")]
        static abstract void FreeCommandBuffers(
            DeviceHandle device,
            CommandPoolHandle commandPool,
            uint commandBufferCount,
            CommandBufferHandle* pCommandBuffers
        );

        [NativeName("vkFreeCommandBuffers")]
        [NativeFunction("vulkan", EntryPoint = "vkFreeCommandBuffers")]
        static abstract void FreeCommandBuffers(
            DeviceHandle device,
            CommandPoolHandle commandPool,
            uint commandBufferCount,
            Ref<CommandBufferHandle> pCommandBuffers
        );

        [NativeName("vkFreeDescriptorSets")]
        [NativeFunction("vulkan", EntryPoint = "vkFreeDescriptorSets")]
        static abstract Result FreeDescriptorSets(
            DeviceHandle device,
            DescriptorPoolHandle descriptorPool,
            uint descriptorSetCount,
            DescriptorSetHandle* pDescriptorSets
        );

        [NativeName("vkFreeDescriptorSets")]
        [NativeFunction("vulkan", EntryPoint = "vkFreeDescriptorSets")]
        static abstract Result FreeDescriptorSets(
            DeviceHandle device,
            DescriptorPoolHandle descriptorPool,
            uint descriptorSetCount,
            Ref<DescriptorSetHandle> pDescriptorSets
        );

        [NativeName("vkFreeMemory")]
        [NativeFunction("vulkan", EntryPoint = "vkFreeMemory")]
        static abstract void FreeMemory(
            DeviceHandle device,
            DeviceMemoryHandle memory,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkFreeMemory")]
        [NativeFunction("vulkan", EntryPoint = "vkFreeMemory")]
        static abstract void FreeMemory(
            DeviceHandle device,
            DeviceMemoryHandle memory,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkGetAccelerationStructureBuildSizesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetAccelerationStructureBuildSizesKHR")]
        static abstract void GetAccelerationStructureBuildSizesKHR(
            DeviceHandle device,
            AccelerationStructureBuildTypeKHR buildType,
            AccelerationStructureBuildGeometryInfoKHR* pBuildInfo,
            uint* pMaxPrimitiveCounts,
            AccelerationStructureBuildSizesInfoKHR* pSizeInfo
        );

        [NativeName("vkGetAccelerationStructureBuildSizesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetAccelerationStructureBuildSizesKHR")]
        static abstract void GetAccelerationStructureBuildSizesKHR(
            DeviceHandle device,
            AccelerationStructureBuildTypeKHR buildType,
            Ref<AccelerationStructureBuildGeometryInfoKHR> pBuildInfo,
            Ref<uint> pMaxPrimitiveCounts,
            Ref<AccelerationStructureBuildSizesInfoKHR> pSizeInfo
        );

        [NativeName("vkGetAccelerationStructureDeviceAddressKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetAccelerationStructureDeviceAddressKHR")]
        static abstract ulong GetAccelerationStructureDeviceAddressKHR(
            DeviceHandle device,
            AccelerationStructureDeviceAddressInfoKHR* pInfo
        );

        [NativeName("vkGetAccelerationStructureDeviceAddressKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetAccelerationStructureDeviceAddressKHR")]
        static abstract ulong GetAccelerationStructureDeviceAddressKHR(
            DeviceHandle device,
            Ref<AccelerationStructureDeviceAddressInfoKHR> pInfo
        );

        [NativeName("vkGetAccelerationStructureHandleNV")]
        [NativeFunction("vulkan", EntryPoint = "vkGetAccelerationStructureHandleNV")]
        static abstract Result GetAccelerationStructureHandleNV(
            DeviceHandle device,
            AccelerationStructureHandleNV accelerationStructure,
            nuint dataSize,
            void* pData
        );

        [NativeName("vkGetAccelerationStructureHandleNV")]
        [NativeFunction("vulkan", EntryPoint = "vkGetAccelerationStructureHandleNV")]
        static abstract Result GetAccelerationStructureHandleNV(
            DeviceHandle device,
            AccelerationStructureHandleNV accelerationStructure,
            nuint dataSize,
            Ref pData
        );

        [NativeName("vkGetAccelerationStructureMemoryRequirementsNV")]
        [NativeFunction("vulkan", EntryPoint = "vkGetAccelerationStructureMemoryRequirementsNV")]
        static abstract void GetAccelerationStructureMemoryRequirementsNV(
            DeviceHandle device,
            AccelerationStructureMemoryRequirementsInfoNV* pInfo,
            MemoryRequirements2* pMemoryRequirements
        );

        [NativeName("vkGetAccelerationStructureMemoryRequirementsNV")]
        [NativeFunction("vulkan", EntryPoint = "vkGetAccelerationStructureMemoryRequirementsNV")]
        static abstract void GetAccelerationStructureMemoryRequirementsNV(
            DeviceHandle device,
            Ref<AccelerationStructureMemoryRequirementsInfoNV> pInfo,
            Ref<MemoryRequirements2> pMemoryRequirements
        );

        [NativeName("vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT")]
        [NativeFunction(
            "vulkan",
            EntryPoint = "vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT"
        )]
        static abstract Result GetAccelerationStructureOpaqueCaptureDescriptorDataEXT(
            DeviceHandle device,
            AccelerationStructureCaptureDescriptorDataInfoEXT* pInfo,
            void* pData
        );

        [NativeName("vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT")]
        [NativeFunction(
            "vulkan",
            EntryPoint = "vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT"
        )]
        static abstract Result GetAccelerationStructureOpaqueCaptureDescriptorDataEXT(
            DeviceHandle device,
            Ref<AccelerationStructureCaptureDescriptorDataInfoEXT> pInfo,
            Ref pData
        );

        [NativeName("vkGetBufferDeviceAddress")]
        [NativeFunction("vulkan", EntryPoint = "vkGetBufferDeviceAddress")]
        static abstract ulong GetBufferDeviceAddress(
            DeviceHandle device,
            BufferDeviceAddressInfo* pInfo
        );

        [NativeName("vkGetBufferDeviceAddress")]
        [NativeFunction("vulkan", EntryPoint = "vkGetBufferDeviceAddress")]
        static abstract ulong GetBufferDeviceAddress(
            DeviceHandle device,
            Ref<BufferDeviceAddressInfo> pInfo
        );

        [NativeName("vkGetBufferDeviceAddressEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetBufferDeviceAddressEXT")]
        static abstract ulong GetBufferDeviceAddressEXT(
            DeviceHandle device,
            BufferDeviceAddressInfo* pInfo
        );

        [NativeName("vkGetBufferDeviceAddressEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetBufferDeviceAddressEXT")]
        static abstract ulong GetBufferDeviceAddressEXT(
            DeviceHandle device,
            Ref<BufferDeviceAddressInfo> pInfo
        );

        [NativeName("vkGetBufferDeviceAddressKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetBufferDeviceAddressKHR")]
        static abstract ulong GetBufferDeviceAddressKHR(
            DeviceHandle device,
            BufferDeviceAddressInfo* pInfo
        );

        [NativeName("vkGetBufferDeviceAddressKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetBufferDeviceAddressKHR")]
        static abstract ulong GetBufferDeviceAddressKHR(
            DeviceHandle device,
            Ref<BufferDeviceAddressInfo> pInfo
        );

        [NativeName("vkGetBufferMemoryRequirements")]
        [NativeFunction("vulkan", EntryPoint = "vkGetBufferMemoryRequirements")]
        static abstract void GetBufferMemoryRequirements(
            DeviceHandle device,
            BufferHandle buffer,
            MemoryRequirements* pMemoryRequirements
        );

        [NativeName("vkGetBufferMemoryRequirements")]
        [NativeFunction("vulkan", EntryPoint = "vkGetBufferMemoryRequirements")]
        static abstract void GetBufferMemoryRequirements(
            DeviceHandle device,
            BufferHandle buffer,
            Ref<MemoryRequirements> pMemoryRequirements
        );

        [NativeName("vkGetBufferMemoryRequirements2")]
        [NativeFunction("vulkan", EntryPoint = "vkGetBufferMemoryRequirements2")]
        static abstract void GetBufferMemoryRequirements2(
            DeviceHandle device,
            BufferMemoryRequirementsInfo2* pInfo,
            MemoryRequirements2* pMemoryRequirements
        );

        [NativeName("vkGetBufferMemoryRequirements2")]
        [NativeFunction("vulkan", EntryPoint = "vkGetBufferMemoryRequirements2")]
        static abstract void GetBufferMemoryRequirements2(
            DeviceHandle device,
            Ref<BufferMemoryRequirementsInfo2> pInfo,
            Ref<MemoryRequirements2> pMemoryRequirements
        );

        [NativeName("vkGetBufferMemoryRequirements2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetBufferMemoryRequirements2KHR")]
        static abstract void GetBufferMemoryRequirements2KHR(
            DeviceHandle device,
            BufferMemoryRequirementsInfo2* pInfo,
            MemoryRequirements2* pMemoryRequirements
        );

        [NativeName("vkGetBufferMemoryRequirements2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetBufferMemoryRequirements2KHR")]
        static abstract void GetBufferMemoryRequirements2KHR(
            DeviceHandle device,
            Ref<BufferMemoryRequirementsInfo2> pInfo,
            Ref<MemoryRequirements2> pMemoryRequirements
        );

        [NativeName("vkGetBufferOpaqueCaptureAddress")]
        [NativeFunction("vulkan", EntryPoint = "vkGetBufferOpaqueCaptureAddress")]
        static abstract ulong GetBufferOpaqueCaptureAddress(
            DeviceHandle device,
            BufferDeviceAddressInfo* pInfo
        );

        [NativeName("vkGetBufferOpaqueCaptureAddress")]
        [NativeFunction("vulkan", EntryPoint = "vkGetBufferOpaqueCaptureAddress")]
        static abstract ulong GetBufferOpaqueCaptureAddress(
            DeviceHandle device,
            Ref<BufferDeviceAddressInfo> pInfo
        );

        [NativeName("vkGetBufferOpaqueCaptureAddressKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetBufferOpaqueCaptureAddressKHR")]
        static abstract ulong GetBufferOpaqueCaptureAddressKHR(
            DeviceHandle device,
            BufferDeviceAddressInfo* pInfo
        );

        [NativeName("vkGetBufferOpaqueCaptureAddressKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetBufferOpaqueCaptureAddressKHR")]
        static abstract ulong GetBufferOpaqueCaptureAddressKHR(
            DeviceHandle device,
            Ref<BufferDeviceAddressInfo> pInfo
        );

        [NativeName("vkGetBufferOpaqueCaptureDescriptorDataEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetBufferOpaqueCaptureDescriptorDataEXT")]
        static abstract Result GetBufferOpaqueCaptureDescriptorDataEXT(
            DeviceHandle device,
            BufferCaptureDescriptorDataInfoEXT* pInfo,
            void* pData
        );

        [NativeName("vkGetBufferOpaqueCaptureDescriptorDataEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetBufferOpaqueCaptureDescriptorDataEXT")]
        static abstract Result GetBufferOpaqueCaptureDescriptorDataEXT(
            DeviceHandle device,
            Ref<BufferCaptureDescriptorDataInfoEXT> pInfo,
            Ref pData
        );

        [NativeName("vkGetCalibratedTimestampsEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetCalibratedTimestampsEXT")]
        static abstract Result GetCalibratedTimestampsEXT(
            DeviceHandle device,
            uint timestampCount,
            CalibratedTimestampInfoKHR* pTimestampInfos,
            ulong* pTimestamps,
            ulong* pMaxDeviation
        );

        [NativeName("vkGetCalibratedTimestampsEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetCalibratedTimestampsEXT")]
        static abstract Result GetCalibratedTimestampsEXT(
            DeviceHandle device,
            uint timestampCount,
            Ref<CalibratedTimestampInfoKHR> pTimestampInfos,
            Ref<ulong> pTimestamps,
            Ref<ulong> pMaxDeviation
        );

        [NativeName("vkGetCalibratedTimestampsKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetCalibratedTimestampsKHR")]
        static abstract Result GetCalibratedTimestampsKHR(
            DeviceHandle device,
            uint timestampCount,
            CalibratedTimestampInfoKHR* pTimestampInfos,
            ulong* pTimestamps,
            ulong* pMaxDeviation
        );

        [NativeName("vkGetCalibratedTimestampsKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetCalibratedTimestampsKHR")]
        static abstract Result GetCalibratedTimestampsKHR(
            DeviceHandle device,
            uint timestampCount,
            Ref<CalibratedTimestampInfoKHR> pTimestampInfos,
            Ref<ulong> pTimestamps,
            Ref<ulong> pMaxDeviation
        );

        [NativeName("vkGetClusterAccelerationStructureBuildSizesNV")]
        [NativeFunction("vulkan", EntryPoint = "vkGetClusterAccelerationStructureBuildSizesNV")]
        static abstract void GetClusterAccelerationStructureBuildSizesNV(
            DeviceHandle device,
            ClusterAccelerationStructureInputInfoNV* pInfo,
            AccelerationStructureBuildSizesInfoKHR* pSizeInfo
        );

        [NativeName("vkGetClusterAccelerationStructureBuildSizesNV")]
        [NativeFunction("vulkan", EntryPoint = "vkGetClusterAccelerationStructureBuildSizesNV")]
        static abstract void GetClusterAccelerationStructureBuildSizesNV(
            DeviceHandle device,
            Ref<ClusterAccelerationStructureInputInfoNV> pInfo,
            Ref<AccelerationStructureBuildSizesInfoKHR> pSizeInfo
        );

        [NativeName("vkGetDataGraphPipelineAvailablePropertiesARM")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDataGraphPipelineAvailablePropertiesARM")]
        static abstract Result GetDataGraphPipelineAvailablePropertiesARM(
            DeviceHandle device,
            DataGraphPipelineInfoARM* pPipelineInfo,
            uint* pPropertiesCount,
            DataGraphPipelinePropertyARM* pProperties
        );

        [NativeName("vkGetDataGraphPipelineAvailablePropertiesARM")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDataGraphPipelineAvailablePropertiesARM")]
        static abstract Result GetDataGraphPipelineAvailablePropertiesARM(
            DeviceHandle device,
            Ref<DataGraphPipelineInfoARM> pPipelineInfo,
            Ref<uint> pPropertiesCount,
            Ref<DataGraphPipelinePropertyARM> pProperties
        );

        [NativeName("vkGetDataGraphPipelinePropertiesARM")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDataGraphPipelinePropertiesARM")]
        static abstract Result GetDataGraphPipelinePropertiesARM(
            DeviceHandle device,
            DataGraphPipelineInfoARM* pPipelineInfo,
            uint propertiesCount,
            DataGraphPipelinePropertyQueryResultARM* pProperties
        );

        [NativeName("vkGetDataGraphPipelinePropertiesARM")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDataGraphPipelinePropertiesARM")]
        static abstract Result GetDataGraphPipelinePropertiesARM(
            DeviceHandle device,
            Ref<DataGraphPipelineInfoARM> pPipelineInfo,
            uint propertiesCount,
            Ref<DataGraphPipelinePropertyQueryResultARM> pProperties
        );

        [NativeName("vkGetDataGraphPipelineSessionBindPointRequirementsARM")]
        [NativeFunction(
            "vulkan",
            EntryPoint = "vkGetDataGraphPipelineSessionBindPointRequirementsARM"
        )]
        static abstract Result GetDataGraphPipelineSessionBindPointRequirementsARM(
            DeviceHandle device,
            DataGraphPipelineSessionBindPointRequirementsInfoARM* pInfo,
            uint* pBindPointRequirementCount,
            DataGraphPipelineSessionBindPointRequirementARM* pBindPointRequirements
        );

        [NativeName("vkGetDataGraphPipelineSessionBindPointRequirementsARM")]
        [NativeFunction(
            "vulkan",
            EntryPoint = "vkGetDataGraphPipelineSessionBindPointRequirementsARM"
        )]
        static abstract Result GetDataGraphPipelineSessionBindPointRequirementsARM(
            DeviceHandle device,
            Ref<DataGraphPipelineSessionBindPointRequirementsInfoARM> pInfo,
            Ref<uint> pBindPointRequirementCount,
            Ref<DataGraphPipelineSessionBindPointRequirementARM> pBindPointRequirements
        );

        [NativeName("vkGetDataGraphPipelineSessionMemoryRequirementsARM")]
        [NativeFunction(
            "vulkan",
            EntryPoint = "vkGetDataGraphPipelineSessionMemoryRequirementsARM"
        )]
        static abstract void GetDataGraphPipelineSessionMemoryRequirementsARM(
            DeviceHandle device,
            DataGraphPipelineSessionMemoryRequirementsInfoARM* pInfo,
            MemoryRequirements2* pMemoryRequirements
        );

        [NativeName("vkGetDataGraphPipelineSessionMemoryRequirementsARM")]
        [NativeFunction(
            "vulkan",
            EntryPoint = "vkGetDataGraphPipelineSessionMemoryRequirementsARM"
        )]
        static abstract void GetDataGraphPipelineSessionMemoryRequirementsARM(
            DeviceHandle device,
            Ref<DataGraphPipelineSessionMemoryRequirementsInfoARM> pInfo,
            Ref<MemoryRequirements2> pMemoryRequirements
        );

        [NativeName("vkGetDeferredOperationMaxConcurrencyKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeferredOperationMaxConcurrencyKHR")]
        static abstract uint GetDeferredOperationMaxConcurrencyKHR(
            DeviceHandle device,
            DeferredOperationHandleKHR operation
        );

        [NativeName("vkGetDeferredOperationResultKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeferredOperationResultKHR")]
        static abstract Result GetDeferredOperationResultKHR(
            DeviceHandle device,
            DeferredOperationHandleKHR operation
        );

        [NativeName("vkGetDescriptorEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDescriptorEXT")]
        static abstract void GetDescriptorEXT(
            DeviceHandle device,
            DescriptorGetInfoEXT* pDescriptorInfo,
            nuint dataSize,
            void* pDescriptor
        );

        [NativeName("vkGetDescriptorEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDescriptorEXT")]
        static abstract void GetDescriptorEXT(
            DeviceHandle device,
            Ref<DescriptorGetInfoEXT> pDescriptorInfo,
            nuint dataSize,
            Ref pDescriptor
        );

        [NativeName("vkGetDescriptorSetHostMappingVALVE")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDescriptorSetHostMappingVALVE")]
        static abstract void GetDescriptorSetHostMappingVALVE(
            DeviceHandle device,
            DescriptorSetHandle descriptorSet,
            void** ppData
        );

        [NativeName("vkGetDescriptorSetHostMappingVALVE")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDescriptorSetHostMappingVALVE")]
        static abstract void GetDescriptorSetHostMappingVALVE(
            DeviceHandle device,
            DescriptorSetHandle descriptorSet,
            Ref2D ppData
        );

        [NativeName("vkGetDescriptorSetLayoutBindingOffsetEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDescriptorSetLayoutBindingOffsetEXT")]
        static abstract void GetDescriptorSetLayoutBindingOffsetEXT(
            DeviceHandle device,
            DescriptorSetLayoutHandle layout,
            uint binding,
            ulong* pOffset
        );

        [NativeName("vkGetDescriptorSetLayoutBindingOffsetEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDescriptorSetLayoutBindingOffsetEXT")]
        static abstract void GetDescriptorSetLayoutBindingOffsetEXT(
            DeviceHandle device,
            DescriptorSetLayoutHandle layout,
            uint binding,
            Ref<ulong> pOffset
        );

        [NativeName("vkGetDescriptorSetLayoutHostMappingInfoVALVE")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDescriptorSetLayoutHostMappingInfoVALVE")]
        static abstract void GetDescriptorSetLayoutHostMappingInfoVALVE(
            DeviceHandle device,
            DescriptorSetBindingReferenceVALVE* pBindingReference,
            DescriptorSetLayoutHostMappingInfoVALVE* pHostMapping
        );

        [NativeName("vkGetDescriptorSetLayoutHostMappingInfoVALVE")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDescriptorSetLayoutHostMappingInfoVALVE")]
        static abstract void GetDescriptorSetLayoutHostMappingInfoVALVE(
            DeviceHandle device,
            Ref<DescriptorSetBindingReferenceVALVE> pBindingReference,
            Ref<DescriptorSetLayoutHostMappingInfoVALVE> pHostMapping
        );

        [NativeName("vkGetDescriptorSetLayoutSizeEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDescriptorSetLayoutSizeEXT")]
        static abstract void GetDescriptorSetLayoutSizeEXT(
            DeviceHandle device,
            DescriptorSetLayoutHandle layout,
            ulong* pLayoutSizeInBytes
        );

        [NativeName("vkGetDescriptorSetLayoutSizeEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDescriptorSetLayoutSizeEXT")]
        static abstract void GetDescriptorSetLayoutSizeEXT(
            DeviceHandle device,
            DescriptorSetLayoutHandle layout,
            Ref<ulong> pLayoutSizeInBytes
        );

        [NativeName("vkGetDescriptorSetLayoutSupport")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDescriptorSetLayoutSupport")]
        static abstract void GetDescriptorSetLayoutSupport(
            DeviceHandle device,
            DescriptorSetLayoutCreateInfo* pCreateInfo,
            DescriptorSetLayoutSupport* pSupport
        );

        [NativeName("vkGetDescriptorSetLayoutSupport")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDescriptorSetLayoutSupport")]
        static abstract void GetDescriptorSetLayoutSupport(
            DeviceHandle device,
            Ref<DescriptorSetLayoutCreateInfo> pCreateInfo,
            Ref<DescriptorSetLayoutSupport> pSupport
        );

        [NativeName("vkGetDescriptorSetLayoutSupportKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDescriptorSetLayoutSupportKHR")]
        static abstract void GetDescriptorSetLayoutSupportKHR(
            DeviceHandle device,
            DescriptorSetLayoutCreateInfo* pCreateInfo,
            DescriptorSetLayoutSupport* pSupport
        );

        [NativeName("vkGetDescriptorSetLayoutSupportKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDescriptorSetLayoutSupportKHR")]
        static abstract void GetDescriptorSetLayoutSupportKHR(
            DeviceHandle device,
            Ref<DescriptorSetLayoutCreateInfo> pCreateInfo,
            Ref<DescriptorSetLayoutSupport> pSupport
        );

        [NativeName("vkGetDeviceAccelerationStructureCompatibilityKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceAccelerationStructureCompatibilityKHR")]
        static abstract void GetDeviceAccelerationStructureCompatibilityKHR(
            DeviceHandle device,
            AccelerationStructureVersionInfoKHR* pVersionInfo,
            AccelerationStructureCompatibilityKHR* pCompatibility
        );

        [NativeName("vkGetDeviceAccelerationStructureCompatibilityKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceAccelerationStructureCompatibilityKHR")]
        static abstract void GetDeviceAccelerationStructureCompatibilityKHR(
            DeviceHandle device,
            Ref<AccelerationStructureVersionInfoKHR> pVersionInfo,
            Ref<AccelerationStructureCompatibilityKHR> pCompatibility
        );

        [NativeName("vkGetDeviceBufferMemoryRequirements")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceBufferMemoryRequirements")]
        static abstract void GetDeviceBufferMemoryRequirements(
            DeviceHandle device,
            DeviceBufferMemoryRequirements* pInfo,
            MemoryRequirements2* pMemoryRequirements
        );

        [NativeName("vkGetDeviceBufferMemoryRequirements")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceBufferMemoryRequirements")]
        static abstract void GetDeviceBufferMemoryRequirements(
            DeviceHandle device,
            Ref<DeviceBufferMemoryRequirements> pInfo,
            Ref<MemoryRequirements2> pMemoryRequirements
        );

        [NativeName("vkGetDeviceBufferMemoryRequirementsKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceBufferMemoryRequirementsKHR")]
        static abstract void GetDeviceBufferMemoryRequirementsKHR(
            DeviceHandle device,
            DeviceBufferMemoryRequirements* pInfo,
            MemoryRequirements2* pMemoryRequirements
        );

        [NativeName("vkGetDeviceBufferMemoryRequirementsKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceBufferMemoryRequirementsKHR")]
        static abstract void GetDeviceBufferMemoryRequirementsKHR(
            DeviceHandle device,
            Ref<DeviceBufferMemoryRequirements> pInfo,
            Ref<MemoryRequirements2> pMemoryRequirements
        );

        [NativeName("vkGetDeviceCombinedImageSamplerIndexNVX")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceCombinedImageSamplerIndexNVX")]
        static abstract ulong GetDeviceCombinedImageSamplerIndexNVX(
            DeviceHandle device,
            ulong imageViewIndex,
            ulong samplerIndex
        );

        [NativeName("vkGetDeviceFaultDebugInfoKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceFaultDebugInfoKHR")]
        static abstract Result GetDeviceFaultDebugInfoKHR(
            DeviceHandle device,
            DeviceFaultDebugInfoKHR* pDebugInfo
        );

        [NativeName("vkGetDeviceFaultDebugInfoKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceFaultDebugInfoKHR")]
        static abstract Result GetDeviceFaultDebugInfoKHR(
            DeviceHandle device,
            Ref<DeviceFaultDebugInfoKHR> pDebugInfo
        );

        [NativeName("vkGetDeviceFaultInfoEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceFaultInfoEXT")]
        static abstract Result GetDeviceFaultInfoEXT(
            DeviceHandle device,
            DeviceFaultCountsEXT* pFaultCounts,
            DeviceFaultInfoEXT* pFaultInfo
        );

        [NativeName("vkGetDeviceFaultInfoEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceFaultInfoEXT")]
        static abstract Result GetDeviceFaultInfoEXT(
            DeviceHandle device,
            Ref<DeviceFaultCountsEXT> pFaultCounts,
            Ref<DeviceFaultInfoEXT> pFaultInfo
        );

        [NativeName("vkGetDeviceFaultReportsKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceFaultReportsKHR")]
        static abstract Result GetDeviceFaultReportsKHR(
            DeviceHandle device,
            ulong timeout,
            uint* pFaultCounts,
            DeviceFaultInfoKHR* pFaultInfo
        );

        [NativeName("vkGetDeviceFaultReportsKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceFaultReportsKHR")]
        static abstract Result GetDeviceFaultReportsKHR(
            DeviceHandle device,
            ulong timeout,
            Ref<uint> pFaultCounts,
            Ref<DeviceFaultInfoKHR> pFaultInfo
        );

        [NativeName("vkGetDeviceGroupPeerMemoryFeatures")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceGroupPeerMemoryFeatures")]
        static abstract void GetDeviceGroupPeerMemoryFeatures(
            DeviceHandle device,
            uint heapIndex,
            uint localDeviceIndex,
            uint remoteDeviceIndex,
            PeerMemoryFeatureFlags* pPeerMemoryFeatures
        );

        [NativeName("vkGetDeviceGroupPeerMemoryFeatures")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceGroupPeerMemoryFeatures")]
        static abstract void GetDeviceGroupPeerMemoryFeatures(
            DeviceHandle device,
            uint heapIndex,
            uint localDeviceIndex,
            uint remoteDeviceIndex,
            Ref<PeerMemoryFeatureFlags> pPeerMemoryFeatures
        );

        [NativeName("vkGetDeviceGroupPeerMemoryFeaturesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceGroupPeerMemoryFeaturesKHR")]
        static abstract void GetDeviceGroupPeerMemoryFeaturesKHR(
            DeviceHandle device,
            uint heapIndex,
            uint localDeviceIndex,
            uint remoteDeviceIndex,
            PeerMemoryFeatureFlags* pPeerMemoryFeatures
        );

        [NativeName("vkGetDeviceGroupPeerMemoryFeaturesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceGroupPeerMemoryFeaturesKHR")]
        static abstract void GetDeviceGroupPeerMemoryFeaturesKHR(
            DeviceHandle device,
            uint heapIndex,
            uint localDeviceIndex,
            uint remoteDeviceIndex,
            Ref<PeerMemoryFeatureFlags> pPeerMemoryFeatures
        );

        [NativeName("vkGetDeviceGroupPresentCapabilitiesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceGroupPresentCapabilitiesKHR")]
        static abstract Result GetDeviceGroupPresentCapabilitiesKHR(
            DeviceHandle device,
            DeviceGroupPresentCapabilitiesKHR* pDeviceGroupPresentCapabilities
        );

        [NativeName("vkGetDeviceGroupPresentCapabilitiesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceGroupPresentCapabilitiesKHR")]
        static abstract Result GetDeviceGroupPresentCapabilitiesKHR(
            DeviceHandle device,
            Ref<DeviceGroupPresentCapabilitiesKHR> pDeviceGroupPresentCapabilities
        );

        [NativeName("vkGetDeviceGroupSurfacePresentModesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceGroupSurfacePresentModesKHR")]
        static abstract Result GetDeviceGroupSurfacePresentModesKHR(
            DeviceHandle device,
            SurfaceHandleKHR surface,
            DeviceGroupPresentModeFlagsKHR* pModes
        );

        [NativeName("vkGetDeviceGroupSurfacePresentModesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceGroupSurfacePresentModesKHR")]
        static abstract Result GetDeviceGroupSurfacePresentModesKHR(
            DeviceHandle device,
            SurfaceHandleKHR surface,
            Ref<DeviceGroupPresentModeFlagsKHR> pModes
        );

        [NativeName("vkGetDeviceImageMemoryRequirements")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceImageMemoryRequirements")]
        static abstract void GetDeviceImageMemoryRequirements(
            DeviceHandle device,
            DeviceImageMemoryRequirements* pInfo,
            MemoryRequirements2* pMemoryRequirements
        );

        [NativeName("vkGetDeviceImageMemoryRequirements")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceImageMemoryRequirements")]
        static abstract void GetDeviceImageMemoryRequirements(
            DeviceHandle device,
            Ref<DeviceImageMemoryRequirements> pInfo,
            Ref<MemoryRequirements2> pMemoryRequirements
        );

        [NativeName("vkGetDeviceImageMemoryRequirementsKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceImageMemoryRequirementsKHR")]
        static abstract void GetDeviceImageMemoryRequirementsKHR(
            DeviceHandle device,
            DeviceImageMemoryRequirements* pInfo,
            MemoryRequirements2* pMemoryRequirements
        );

        [NativeName("vkGetDeviceImageMemoryRequirementsKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceImageMemoryRequirementsKHR")]
        static abstract void GetDeviceImageMemoryRequirementsKHR(
            DeviceHandle device,
            Ref<DeviceImageMemoryRequirements> pInfo,
            Ref<MemoryRequirements2> pMemoryRequirements
        );

        [NativeName("vkGetDeviceImageSparseMemoryRequirements")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceImageSparseMemoryRequirements")]
        static abstract void GetDeviceImageSparseMemoryRequirements(
            DeviceHandle device,
            DeviceImageMemoryRequirements* pInfo,
            uint* pSparseMemoryRequirementCount,
            SparseImageMemoryRequirements2* pSparseMemoryRequirements
        );

        [NativeName("vkGetDeviceImageSparseMemoryRequirements")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceImageSparseMemoryRequirements")]
        static abstract void GetDeviceImageSparseMemoryRequirements(
            DeviceHandle device,
            Ref<DeviceImageMemoryRequirements> pInfo,
            Ref<uint> pSparseMemoryRequirementCount,
            Ref<SparseImageMemoryRequirements2> pSparseMemoryRequirements
        );

        [NativeName("vkGetDeviceImageSparseMemoryRequirementsKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceImageSparseMemoryRequirementsKHR")]
        static abstract void GetDeviceImageSparseMemoryRequirementsKHR(
            DeviceHandle device,
            DeviceImageMemoryRequirements* pInfo,
            uint* pSparseMemoryRequirementCount,
            SparseImageMemoryRequirements2* pSparseMemoryRequirements
        );

        [NativeName("vkGetDeviceImageSparseMemoryRequirementsKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceImageSparseMemoryRequirementsKHR")]
        static abstract void GetDeviceImageSparseMemoryRequirementsKHR(
            DeviceHandle device,
            Ref<DeviceImageMemoryRequirements> pInfo,
            Ref<uint> pSparseMemoryRequirementCount,
            Ref<SparseImageMemoryRequirements2> pSparseMemoryRequirements
        );

        [NativeName("vkGetDeviceImageSubresourceLayout")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceImageSubresourceLayout")]
        static abstract void GetDeviceImageSubresourceLayout(
            DeviceHandle device,
            DeviceImageSubresourceInfo* pInfo,
            SubresourceLayout2* pLayout
        );

        [NativeName("vkGetDeviceImageSubresourceLayout")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceImageSubresourceLayout")]
        static abstract void GetDeviceImageSubresourceLayout(
            DeviceHandle device,
            Ref<DeviceImageSubresourceInfo> pInfo,
            Ref<SubresourceLayout2> pLayout
        );

        [NativeName("vkGetDeviceImageSubresourceLayoutKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceImageSubresourceLayoutKHR")]
        static abstract void GetDeviceImageSubresourceLayoutKHR(
            DeviceHandle device,
            DeviceImageSubresourceInfo* pInfo,
            SubresourceLayout2* pLayout
        );

        [NativeName("vkGetDeviceImageSubresourceLayoutKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceImageSubresourceLayoutKHR")]
        static abstract void GetDeviceImageSubresourceLayoutKHR(
            DeviceHandle device,
            Ref<DeviceImageSubresourceInfo> pInfo,
            Ref<SubresourceLayout2> pLayout
        );

        [NativeName("vkGetDeviceMemoryCommitment")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceMemoryCommitment")]
        static abstract void GetDeviceMemoryCommitment(
            DeviceHandle device,
            DeviceMemoryHandle memory,
            ulong* pCommittedMemoryInBytes
        );

        [NativeName("vkGetDeviceMemoryCommitment")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceMemoryCommitment")]
        static abstract void GetDeviceMemoryCommitment(
            DeviceHandle device,
            DeviceMemoryHandle memory,
            Ref<ulong> pCommittedMemoryInBytes
        );

        [NativeName("vkGetDeviceMemoryOpaqueCaptureAddress")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceMemoryOpaqueCaptureAddress")]
        static abstract ulong GetDeviceMemoryOpaqueCaptureAddress(
            DeviceHandle device,
            DeviceMemoryOpaqueCaptureAddressInfo* pInfo
        );

        [NativeName("vkGetDeviceMemoryOpaqueCaptureAddress")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceMemoryOpaqueCaptureAddress")]
        static abstract ulong GetDeviceMemoryOpaqueCaptureAddress(
            DeviceHandle device,
            Ref<DeviceMemoryOpaqueCaptureAddressInfo> pInfo
        );

        [NativeName("vkGetDeviceMemoryOpaqueCaptureAddressKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceMemoryOpaqueCaptureAddressKHR")]
        static abstract ulong GetDeviceMemoryOpaqueCaptureAddressKHR(
            DeviceHandle device,
            DeviceMemoryOpaqueCaptureAddressInfo* pInfo
        );

        [NativeName("vkGetDeviceMemoryOpaqueCaptureAddressKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceMemoryOpaqueCaptureAddressKHR")]
        static abstract ulong GetDeviceMemoryOpaqueCaptureAddressKHR(
            DeviceHandle device,
            Ref<DeviceMemoryOpaqueCaptureAddressInfo> pInfo
        );

        [NativeName("vkGetDeviceMicromapCompatibilityEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceMicromapCompatibilityEXT")]
        static abstract void GetDeviceMicromapCompatibilityEXT(
            DeviceHandle device,
            MicromapVersionInfoEXT* pVersionInfo,
            AccelerationStructureCompatibilityKHR* pCompatibility
        );

        [NativeName("vkGetDeviceMicromapCompatibilityEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceMicromapCompatibilityEXT")]
        static abstract void GetDeviceMicromapCompatibilityEXT(
            DeviceHandle device,
            Ref<MicromapVersionInfoEXT> pVersionInfo,
            Ref<AccelerationStructureCompatibilityKHR> pCompatibility
        );

        [NativeName("vkGetDeviceProcAddr")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceProcAddr")]
        static abstract VoidFunction GetDeviceProcAddr(DeviceHandle device, sbyte* pName);

        [NativeName("vkGetDeviceProcAddr")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceProcAddr")]
        static abstract VoidFunction GetDeviceProcAddr(DeviceHandle device, Ref<sbyte> pName);

        [NativeName("vkGetDeviceQueue")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceQueue")]
        static abstract void GetDeviceQueue(
            DeviceHandle device,
            uint queueFamilyIndex,
            uint queueIndex,
            QueueHandle* pQueue
        );

        [NativeName("vkGetDeviceQueue")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceQueue")]
        static abstract void GetDeviceQueue(
            DeviceHandle device,
            uint queueFamilyIndex,
            uint queueIndex,
            Ref<QueueHandle> pQueue
        );

        [NativeName("vkGetDeviceQueue2")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceQueue2")]
        static abstract void GetDeviceQueue2(
            DeviceHandle device,
            DeviceQueueInfo2* pQueueInfo,
            QueueHandle* pQueue
        );

        [NativeName("vkGetDeviceQueue2")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceQueue2")]
        static abstract void GetDeviceQueue2(
            DeviceHandle device,
            Ref<DeviceQueueInfo2> pQueueInfo,
            Ref<QueueHandle> pQueue
        );

        [NativeName("vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI")]
        static abstract Result GetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(
            DeviceHandle device,
            RenderPassHandle renderpass,
            Extent2D* pMaxWorkgroupSize
        );

        [NativeName("vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI")]
        static abstract Result GetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(
            DeviceHandle device,
            RenderPassHandle renderpass,
            Ref<Extent2D> pMaxWorkgroupSize
        );

        [NativeName("vkGetDeviceTensorMemoryRequirementsARM")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceTensorMemoryRequirementsARM")]
        static abstract void GetDeviceTensorMemoryRequirementsARM(
            DeviceHandle device,
            DeviceTensorMemoryRequirementsARM* pInfo,
            MemoryRequirements2* pMemoryRequirements
        );

        [NativeName("vkGetDeviceTensorMemoryRequirementsARM")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDeviceTensorMemoryRequirementsARM")]
        static abstract void GetDeviceTensorMemoryRequirementsARM(
            DeviceHandle device,
            Ref<DeviceTensorMemoryRequirementsARM> pInfo,
            Ref<MemoryRequirements2> pMemoryRequirements
        );

        [NativeName("vkGetDisplayModeProperties2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDisplayModeProperties2KHR")]
        static abstract Result GetDisplayModeProperties2KHR(
            PhysicalDeviceHandle physicalDevice,
            DisplayHandleKHR display,
            uint* pPropertyCount,
            DisplayModeProperties2KHR* pProperties
        );

        [NativeName("vkGetDisplayModeProperties2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDisplayModeProperties2KHR")]
        static abstract Result GetDisplayModeProperties2KHR(
            PhysicalDeviceHandle physicalDevice,
            DisplayHandleKHR display,
            Ref<uint> pPropertyCount,
            Ref<DisplayModeProperties2KHR> pProperties
        );

        [NativeName("vkGetDisplayModePropertiesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDisplayModePropertiesKHR")]
        static abstract Result GetDisplayModePropertiesKHR(
            PhysicalDeviceHandle physicalDevice,
            DisplayHandleKHR display,
            uint* pPropertyCount,
            DisplayModePropertiesKHR* pProperties
        );

        [NativeName("vkGetDisplayModePropertiesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDisplayModePropertiesKHR")]
        static abstract Result GetDisplayModePropertiesKHR(
            PhysicalDeviceHandle physicalDevice,
            DisplayHandleKHR display,
            Ref<uint> pPropertyCount,
            Ref<DisplayModePropertiesKHR> pProperties
        );

        [NativeName("vkGetDisplayPlaneCapabilities2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDisplayPlaneCapabilities2KHR")]
        static abstract Result GetDisplayPlaneCapabilities2KHR(
            PhysicalDeviceHandle physicalDevice,
            DisplayPlaneInfo2KHR* pDisplayPlaneInfo,
            DisplayPlaneCapabilities2KHR* pCapabilities
        );

        [NativeName("vkGetDisplayPlaneCapabilities2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDisplayPlaneCapabilities2KHR")]
        static abstract Result GetDisplayPlaneCapabilities2KHR(
            PhysicalDeviceHandle physicalDevice,
            Ref<DisplayPlaneInfo2KHR> pDisplayPlaneInfo,
            Ref<DisplayPlaneCapabilities2KHR> pCapabilities
        );

        [NativeName("vkGetDisplayPlaneCapabilitiesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDisplayPlaneCapabilitiesKHR")]
        static abstract Result GetDisplayPlaneCapabilitiesKHR(
            PhysicalDeviceHandle physicalDevice,
            DisplayModeHandleKHR mode,
            uint planeIndex,
            DisplayPlaneCapabilitiesKHR* pCapabilities
        );

        [NativeName("vkGetDisplayPlaneCapabilitiesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDisplayPlaneCapabilitiesKHR")]
        static abstract Result GetDisplayPlaneCapabilitiesKHR(
            PhysicalDeviceHandle physicalDevice,
            DisplayModeHandleKHR mode,
            uint planeIndex,
            Ref<DisplayPlaneCapabilitiesKHR> pCapabilities
        );

        [NativeName("vkGetDisplayPlaneSupportedDisplaysKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDisplayPlaneSupportedDisplaysKHR")]
        static abstract Result GetDisplayPlaneSupportedDisplaysKHR(
            PhysicalDeviceHandle physicalDevice,
            uint planeIndex,
            uint* pDisplayCount,
            DisplayHandleKHR* pDisplays
        );

        [NativeName("vkGetDisplayPlaneSupportedDisplaysKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDisplayPlaneSupportedDisplaysKHR")]
        static abstract Result GetDisplayPlaneSupportedDisplaysKHR(
            PhysicalDeviceHandle physicalDevice,
            uint planeIndex,
            Ref<uint> pDisplayCount,
            Ref<DisplayHandleKHR> pDisplays
        );

        [NativeName("vkGetDrmDisplayEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDrmDisplayEXT")]
        static abstract Result GetDrmDisplayEXT(
            PhysicalDeviceHandle physicalDevice,
            int drmFd,
            uint connectorId,
            DisplayHandleKHR* display
        );

        [NativeName("vkGetDrmDisplayEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDrmDisplayEXT")]
        static abstract Result GetDrmDisplayEXT(
            PhysicalDeviceHandle physicalDevice,
            int drmFd,
            uint connectorId,
            Ref<DisplayHandleKHR> display
        );

        [NativeName("vkGetDynamicRenderingTilePropertiesQCOM")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDynamicRenderingTilePropertiesQCOM")]
        static abstract Result GetDynamicRenderingTilePropertiesQCOM(
            DeviceHandle device,
            RenderingInfo* pRenderingInfo,
            TilePropertiesQCOM* pProperties
        );

        [NativeName("vkGetDynamicRenderingTilePropertiesQCOM")]
        [NativeFunction("vulkan", EntryPoint = "vkGetDynamicRenderingTilePropertiesQCOM")]
        static abstract Result GetDynamicRenderingTilePropertiesQCOM(
            DeviceHandle device,
            Ref<RenderingInfo> pRenderingInfo,
            Ref<TilePropertiesQCOM> pProperties
        );

        [NativeName("vkGetEncodedVideoSessionParametersKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetEncodedVideoSessionParametersKHR")]
        static abstract Result GetEncodedVideoSessionParametersKHR(
            DeviceHandle device,
            VideoEncodeSessionParametersGetInfoKHR* pVideoSessionParametersInfo,
            VideoEncodeSessionParametersFeedbackInfoKHR* pFeedbackInfo,
            nuint* pDataSize,
            void* pData
        );

        [NativeName("vkGetEncodedVideoSessionParametersKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetEncodedVideoSessionParametersKHR")]
        static abstract Result GetEncodedVideoSessionParametersKHR(
            DeviceHandle device,
            Ref<VideoEncodeSessionParametersGetInfoKHR> pVideoSessionParametersInfo,
            Ref<VideoEncodeSessionParametersFeedbackInfoKHR> pFeedbackInfo,
            Ref<nuint> pDataSize,
            Ref pData
        );

        [NativeName("vkGetEventStatus")]
        [NativeFunction("vulkan", EntryPoint = "vkGetEventStatus")]
        static abstract Result GetEventStatus(DeviceHandle device, EventHandle @event);

        [NativeName("vkGetExternalComputeQueueDataNV")]
        [NativeFunction("vulkan", EntryPoint = "vkGetExternalComputeQueueDataNV")]
        static abstract void GetExternalComputeQueueDataNV(
            ExternalComputeQueueHandleNV externalQueue,
            ExternalComputeQueueDataParamsNV* @params,
            void* pData
        );

        [NativeName("vkGetExternalComputeQueueDataNV")]
        [NativeFunction("vulkan", EntryPoint = "vkGetExternalComputeQueueDataNV")]
        static abstract void GetExternalComputeQueueDataNV(
            ExternalComputeQueueHandleNV externalQueue,
            Ref<ExternalComputeQueueDataParamsNV> @params,
            Ref pData
        );

        [NativeName("vkGetFenceFdKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetFenceFdKHR")]
        static abstract Result GetFenceFdKHR(
            DeviceHandle device,
            FenceGetFdInfoKHR* pGetFdInfo,
            int* pFd
        );

        [NativeName("vkGetFenceFdKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetFenceFdKHR")]
        static abstract Result GetFenceFdKHR(
            DeviceHandle device,
            Ref<FenceGetFdInfoKHR> pGetFdInfo,
            Ref<int> pFd
        );

        [NativeName("vkGetFenceStatus")]
        [NativeFunction("vulkan", EntryPoint = "vkGetFenceStatus")]
        static abstract Result GetFenceStatus(DeviceHandle device, FenceHandle fence);

        [NativeName("vkGetFramebufferTilePropertiesQCOM")]
        [NativeFunction("vulkan", EntryPoint = "vkGetFramebufferTilePropertiesQCOM")]
        static abstract Result GetFramebufferTilePropertiesQCOM(
            DeviceHandle device,
            FramebufferHandle framebuffer,
            uint* pPropertiesCount,
            TilePropertiesQCOM* pProperties
        );

        [NativeName("vkGetFramebufferTilePropertiesQCOM")]
        [NativeFunction("vulkan", EntryPoint = "vkGetFramebufferTilePropertiesQCOM")]
        static abstract Result GetFramebufferTilePropertiesQCOM(
            DeviceHandle device,
            FramebufferHandle framebuffer,
            Ref<uint> pPropertiesCount,
            Ref<TilePropertiesQCOM> pProperties
        );

        [NativeName("vkGetGeneratedCommandsMemoryRequirementsEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetGeneratedCommandsMemoryRequirementsEXT")]
        static abstract void GetGeneratedCommandsMemoryRequirementsEXT(
            DeviceHandle device,
            GeneratedCommandsMemoryRequirementsInfoEXT* pInfo,
            MemoryRequirements2* pMemoryRequirements
        );

        [NativeName("vkGetGeneratedCommandsMemoryRequirementsEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetGeneratedCommandsMemoryRequirementsEXT")]
        static abstract void GetGeneratedCommandsMemoryRequirementsEXT(
            DeviceHandle device,
            Ref<GeneratedCommandsMemoryRequirementsInfoEXT> pInfo,
            Ref<MemoryRequirements2> pMemoryRequirements
        );

        [NativeName("vkGetGeneratedCommandsMemoryRequirementsNV")]
        [NativeFunction("vulkan", EntryPoint = "vkGetGeneratedCommandsMemoryRequirementsNV")]
        static abstract void GetGeneratedCommandsMemoryRequirementsNV(
            DeviceHandle device,
            GeneratedCommandsMemoryRequirementsInfoNV* pInfo,
            MemoryRequirements2* pMemoryRequirements
        );

        [NativeName("vkGetGeneratedCommandsMemoryRequirementsNV")]
        [NativeFunction("vulkan", EntryPoint = "vkGetGeneratedCommandsMemoryRequirementsNV")]
        static abstract void GetGeneratedCommandsMemoryRequirementsNV(
            DeviceHandle device,
            Ref<GeneratedCommandsMemoryRequirementsInfoNV> pInfo,
            Ref<MemoryRequirements2> pMemoryRequirements
        );

        [NativeName("vkGetGpaDeviceClockInfoAMD")]
        [NativeFunction("vulkan", EntryPoint = "vkGetGpaDeviceClockInfoAMD")]
        static abstract Result GetGpaDeviceClockInfoAMD(
            DeviceHandle device,
            GpaDeviceGetClockInfoAMD* pInfo
        );

        [NativeName("vkGetGpaDeviceClockInfoAMD")]
        [NativeFunction("vulkan", EntryPoint = "vkGetGpaDeviceClockInfoAMD")]
        static abstract Result GetGpaDeviceClockInfoAMD(
            DeviceHandle device,
            Ref<GpaDeviceGetClockInfoAMD> pInfo
        );

        [NativeName("vkGetGpaSessionResultsAMD")]
        [NativeFunction("vulkan", EntryPoint = "vkGetGpaSessionResultsAMD")]
        static abstract Result GetGpaSessionResultsAMD(
            DeviceHandle device,
            GpaSessionHandleAMD gpaSession,
            uint sampleID,
            nuint* pSizeInBytes,
            void* pData
        );

        [NativeName("vkGetGpaSessionResultsAMD")]
        [NativeFunction("vulkan", EntryPoint = "vkGetGpaSessionResultsAMD")]
        static abstract Result GetGpaSessionResultsAMD(
            DeviceHandle device,
            GpaSessionHandleAMD gpaSession,
            uint sampleID,
            Ref<nuint> pSizeInBytes,
            Ref pData
        );

        [NativeName("vkGetGpaSessionStatusAMD")]
        [NativeFunction("vulkan", EntryPoint = "vkGetGpaSessionStatusAMD")]
        static abstract Result GetGpaSessionStatusAMD(
            DeviceHandle device,
            GpaSessionHandleAMD gpaSession
        );

        [NativeName("vkGetImageDrmFormatModifierPropertiesEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetImageDrmFormatModifierPropertiesEXT")]
        static abstract Result GetImageDrmFormatModifierPropertiesEXT(
            DeviceHandle device,
            ImageHandle image,
            ImageDrmFormatModifierPropertiesEXT* pProperties
        );

        [NativeName("vkGetImageDrmFormatModifierPropertiesEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetImageDrmFormatModifierPropertiesEXT")]
        static abstract Result GetImageDrmFormatModifierPropertiesEXT(
            DeviceHandle device,
            ImageHandle image,
            Ref<ImageDrmFormatModifierPropertiesEXT> pProperties
        );

        [NativeName("vkGetImageMemoryRequirements")]
        [NativeFunction("vulkan", EntryPoint = "vkGetImageMemoryRequirements")]
        static abstract void GetImageMemoryRequirements(
            DeviceHandle device,
            ImageHandle image,
            MemoryRequirements* pMemoryRequirements
        );

        [NativeName("vkGetImageMemoryRequirements")]
        [NativeFunction("vulkan", EntryPoint = "vkGetImageMemoryRequirements")]
        static abstract void GetImageMemoryRequirements(
            DeviceHandle device,
            ImageHandle image,
            Ref<MemoryRequirements> pMemoryRequirements
        );

        [NativeName("vkGetImageMemoryRequirements2")]
        [NativeFunction("vulkan", EntryPoint = "vkGetImageMemoryRequirements2")]
        static abstract void GetImageMemoryRequirements2(
            DeviceHandle device,
            ImageMemoryRequirementsInfo2* pInfo,
            MemoryRequirements2* pMemoryRequirements
        );

        [NativeName("vkGetImageMemoryRequirements2")]
        [NativeFunction("vulkan", EntryPoint = "vkGetImageMemoryRequirements2")]
        static abstract void GetImageMemoryRequirements2(
            DeviceHandle device,
            Ref<ImageMemoryRequirementsInfo2> pInfo,
            Ref<MemoryRequirements2> pMemoryRequirements
        );

        [NativeName("vkGetImageMemoryRequirements2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetImageMemoryRequirements2KHR")]
        static abstract void GetImageMemoryRequirements2KHR(
            DeviceHandle device,
            ImageMemoryRequirementsInfo2* pInfo,
            MemoryRequirements2* pMemoryRequirements
        );

        [NativeName("vkGetImageMemoryRequirements2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetImageMemoryRequirements2KHR")]
        static abstract void GetImageMemoryRequirements2KHR(
            DeviceHandle device,
            Ref<ImageMemoryRequirementsInfo2> pInfo,
            Ref<MemoryRequirements2> pMemoryRequirements
        );

        [NativeName("vkGetImageOpaqueCaptureDataEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetImageOpaqueCaptureDataEXT")]
        static abstract Result GetImageOpaqueCaptureDataEXT(
            DeviceHandle device,
            uint imageCount,
            ImageHandle* pImages,
            HostAddressRangeEXT* pDatas
        );

        [NativeName("vkGetImageOpaqueCaptureDataEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetImageOpaqueCaptureDataEXT")]
        static abstract Result GetImageOpaqueCaptureDataEXT(
            DeviceHandle device,
            uint imageCount,
            Ref<ImageHandle> pImages,
            Ref<HostAddressRangeEXT> pDatas
        );

        [NativeName("vkGetImageOpaqueCaptureDescriptorDataEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetImageOpaqueCaptureDescriptorDataEXT")]
        static abstract Result GetImageOpaqueCaptureDescriptorDataEXT(
            DeviceHandle device,
            ImageCaptureDescriptorDataInfoEXT* pInfo,
            void* pData
        );

        [NativeName("vkGetImageOpaqueCaptureDescriptorDataEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetImageOpaqueCaptureDescriptorDataEXT")]
        static abstract Result GetImageOpaqueCaptureDescriptorDataEXT(
            DeviceHandle device,
            Ref<ImageCaptureDescriptorDataInfoEXT> pInfo,
            Ref pData
        );

        [NativeName("vkGetImageSparseMemoryRequirements")]
        [NativeFunction("vulkan", EntryPoint = "vkGetImageSparseMemoryRequirements")]
        static abstract void GetImageSparseMemoryRequirements(
            DeviceHandle device,
            ImageHandle image,
            uint* pSparseMemoryRequirementCount,
            SparseImageMemoryRequirements* pSparseMemoryRequirements
        );

        [NativeName("vkGetImageSparseMemoryRequirements")]
        [NativeFunction("vulkan", EntryPoint = "vkGetImageSparseMemoryRequirements")]
        static abstract void GetImageSparseMemoryRequirements(
            DeviceHandle device,
            ImageHandle image,
            Ref<uint> pSparseMemoryRequirementCount,
            Ref<SparseImageMemoryRequirements> pSparseMemoryRequirements
        );

        [NativeName("vkGetImageSparseMemoryRequirements2")]
        [NativeFunction("vulkan", EntryPoint = "vkGetImageSparseMemoryRequirements2")]
        static abstract void GetImageSparseMemoryRequirements2(
            DeviceHandle device,
            ImageSparseMemoryRequirementsInfo2* pInfo,
            uint* pSparseMemoryRequirementCount,
            SparseImageMemoryRequirements2* pSparseMemoryRequirements
        );

        [NativeName("vkGetImageSparseMemoryRequirements2")]
        [NativeFunction("vulkan", EntryPoint = "vkGetImageSparseMemoryRequirements2")]
        static abstract void GetImageSparseMemoryRequirements2(
            DeviceHandle device,
            Ref<ImageSparseMemoryRequirementsInfo2> pInfo,
            Ref<uint> pSparseMemoryRequirementCount,
            Ref<SparseImageMemoryRequirements2> pSparseMemoryRequirements
        );

        [NativeName("vkGetImageSparseMemoryRequirements2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetImageSparseMemoryRequirements2KHR")]
        static abstract void GetImageSparseMemoryRequirements2KHR(
            DeviceHandle device,
            ImageSparseMemoryRequirementsInfo2* pInfo,
            uint* pSparseMemoryRequirementCount,
            SparseImageMemoryRequirements2* pSparseMemoryRequirements
        );

        [NativeName("vkGetImageSparseMemoryRequirements2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetImageSparseMemoryRequirements2KHR")]
        static abstract void GetImageSparseMemoryRequirements2KHR(
            DeviceHandle device,
            Ref<ImageSparseMemoryRequirementsInfo2> pInfo,
            Ref<uint> pSparseMemoryRequirementCount,
            Ref<SparseImageMemoryRequirements2> pSparseMemoryRequirements
        );

        [NativeName("vkGetImageSubresourceLayout")]
        [NativeFunction("vulkan", EntryPoint = "vkGetImageSubresourceLayout")]
        static abstract void GetImageSubresourceLayout(
            DeviceHandle device,
            ImageHandle image,
            ImageSubresource* pSubresource,
            SubresourceLayout* pLayout
        );

        [NativeName("vkGetImageSubresourceLayout")]
        [NativeFunction("vulkan", EntryPoint = "vkGetImageSubresourceLayout")]
        static abstract void GetImageSubresourceLayout(
            DeviceHandle device,
            ImageHandle image,
            Ref<ImageSubresource> pSubresource,
            Ref<SubresourceLayout> pLayout
        );

        [NativeName("vkGetImageSubresourceLayout2")]
        [NativeFunction("vulkan", EntryPoint = "vkGetImageSubresourceLayout2")]
        static abstract void GetImageSubresourceLayout2(
            DeviceHandle device,
            ImageHandle image,
            ImageSubresource2* pSubresource,
            SubresourceLayout2* pLayout
        );

        [NativeName("vkGetImageSubresourceLayout2")]
        [NativeFunction("vulkan", EntryPoint = "vkGetImageSubresourceLayout2")]
        static abstract void GetImageSubresourceLayout2(
            DeviceHandle device,
            ImageHandle image,
            Ref<ImageSubresource2> pSubresource,
            Ref<SubresourceLayout2> pLayout
        );

        [NativeName("vkGetImageSubresourceLayout2EXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetImageSubresourceLayout2EXT")]
        static abstract void GetImageSubresourceLayout2EXT(
            DeviceHandle device,
            ImageHandle image,
            ImageSubresource2* pSubresource,
            SubresourceLayout2* pLayout
        );

        [NativeName("vkGetImageSubresourceLayout2EXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetImageSubresourceLayout2EXT")]
        static abstract void GetImageSubresourceLayout2EXT(
            DeviceHandle device,
            ImageHandle image,
            Ref<ImageSubresource2> pSubresource,
            Ref<SubresourceLayout2> pLayout
        );

        [NativeName("vkGetImageSubresourceLayout2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetImageSubresourceLayout2KHR")]
        static abstract void GetImageSubresourceLayout2KHR(
            DeviceHandle device,
            ImageHandle image,
            ImageSubresource2* pSubresource,
            SubresourceLayout2* pLayout
        );

        [NativeName("vkGetImageSubresourceLayout2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetImageSubresourceLayout2KHR")]
        static abstract void GetImageSubresourceLayout2KHR(
            DeviceHandle device,
            ImageHandle image,
            Ref<ImageSubresource2> pSubresource,
            Ref<SubresourceLayout2> pLayout
        );

        [NativeName("vkGetImageViewAddressNVX")]
        [NativeFunction("vulkan", EntryPoint = "vkGetImageViewAddressNVX")]
        static abstract Result GetImageViewAddressNVX(
            DeviceHandle device,
            ImageViewHandle imageView,
            ImageViewAddressPropertiesNVX* pProperties
        );

        [NativeName("vkGetImageViewAddressNVX")]
        [NativeFunction("vulkan", EntryPoint = "vkGetImageViewAddressNVX")]
        static abstract Result GetImageViewAddressNVX(
            DeviceHandle device,
            ImageViewHandle imageView,
            Ref<ImageViewAddressPropertiesNVX> pProperties
        );

        [NativeName("vkGetImageViewHandle64NVX")]
        [NativeFunction("vulkan", EntryPoint = "vkGetImageViewHandle64NVX")]
        static abstract ulong GetImageViewHandle64NVX(
            DeviceHandle device,
            ImageViewHandleInfoNVX* pInfo
        );

        [NativeName("vkGetImageViewHandle64NVX")]
        [NativeFunction("vulkan", EntryPoint = "vkGetImageViewHandle64NVX")]
        static abstract ulong GetImageViewHandle64NVX(
            DeviceHandle device,
            Ref<ImageViewHandleInfoNVX> pInfo
        );

        [NativeName("vkGetImageViewHandleNVX")]
        [NativeFunction("vulkan", EntryPoint = "vkGetImageViewHandleNVX")]
        static abstract uint GetImageViewHandleNVX(
            DeviceHandle device,
            ImageViewHandleInfoNVX* pInfo
        );

        [NativeName("vkGetImageViewHandleNVX")]
        [NativeFunction("vulkan", EntryPoint = "vkGetImageViewHandleNVX")]
        static abstract uint GetImageViewHandleNVX(
            DeviceHandle device,
            Ref<ImageViewHandleInfoNVX> pInfo
        );

        [NativeName("vkGetImageViewOpaqueCaptureDescriptorDataEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetImageViewOpaqueCaptureDescriptorDataEXT")]
        static abstract Result GetImageViewOpaqueCaptureDescriptorDataEXT(
            DeviceHandle device,
            ImageViewCaptureDescriptorDataInfoEXT* pInfo,
            void* pData
        );

        [NativeName("vkGetImageViewOpaqueCaptureDescriptorDataEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetImageViewOpaqueCaptureDescriptorDataEXT")]
        static abstract Result GetImageViewOpaqueCaptureDescriptorDataEXT(
            DeviceHandle device,
            Ref<ImageViewCaptureDescriptorDataInfoEXT> pInfo,
            Ref pData
        );

        [NativeName("vkGetInstanceProcAddr")]
        [NativeFunction("vulkan", EntryPoint = "vkGetInstanceProcAddr")]
        static abstract VoidFunction GetInstanceProcAddr(InstanceHandle instance, sbyte* pName);

        [NativeName("vkGetInstanceProcAddr")]
        [NativeFunction("vulkan", EntryPoint = "vkGetInstanceProcAddr")]
        static abstract VoidFunction GetInstanceProcAddr(InstanceHandle instance, Ref<sbyte> pName);

        [NativeName("vkGetLatencyTimingsNV")]
        [NativeFunction("vulkan", EntryPoint = "vkGetLatencyTimingsNV")]
        static abstract void GetLatencyTimingsNV(
            DeviceHandle device,
            SwapchainHandleKHR swapchain,
            GetLatencyMarkerInfoNV* pLatencyMarkerInfo
        );

        [NativeName("vkGetLatencyTimingsNV")]
        [NativeFunction("vulkan", EntryPoint = "vkGetLatencyTimingsNV")]
        static abstract void GetLatencyTimingsNV(
            DeviceHandle device,
            SwapchainHandleKHR swapchain,
            Ref<GetLatencyMarkerInfoNV> pLatencyMarkerInfo
        );

        [NativeName("vkGetMemoryFdKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetMemoryFdKHR")]
        static abstract Result GetMemoryFdKHR(
            DeviceHandle device,
            MemoryGetFdInfoKHR* pGetFdInfo,
            int* pFd
        );

        [NativeName("vkGetMemoryFdKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetMemoryFdKHR")]
        static abstract Result GetMemoryFdKHR(
            DeviceHandle device,
            Ref<MemoryGetFdInfoKHR> pGetFdInfo,
            Ref<int> pFd
        );

        [NativeName("vkGetMemoryFdPropertiesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetMemoryFdPropertiesKHR")]
        static abstract Result GetMemoryFdPropertiesKHR(
            DeviceHandle device,
            ExternalMemoryHandleTypeFlags handleType,
            int fd,
            MemoryFdPropertiesKHR* pMemoryFdProperties
        );

        [NativeName("vkGetMemoryFdPropertiesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetMemoryFdPropertiesKHR")]
        static abstract Result GetMemoryFdPropertiesKHR(
            DeviceHandle device,
            ExternalMemoryHandleTypeFlags handleType,
            int fd,
            Ref<MemoryFdPropertiesKHR> pMemoryFdProperties
        );

        [NativeName("vkGetMemoryHostPointerPropertiesEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetMemoryHostPointerPropertiesEXT")]
        static abstract Result GetMemoryHostPointerPropertiesEXT(
            DeviceHandle device,
            ExternalMemoryHandleTypeFlags handleType,
            void* pHostPointer,
            MemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties
        );

        [NativeName("vkGetMemoryHostPointerPropertiesEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetMemoryHostPointerPropertiesEXT")]
        static abstract Result GetMemoryHostPointerPropertiesEXT(
            DeviceHandle device,
            ExternalMemoryHandleTypeFlags handleType,
            Ref pHostPointer,
            Ref<MemoryHostPointerPropertiesEXT> pMemoryHostPointerProperties
        );

        [NativeName("vkGetMemoryRemoteAddressNV")]
        [NativeFunction("vulkan", EntryPoint = "vkGetMemoryRemoteAddressNV")]
        static abstract Result GetMemoryRemoteAddressNV(
            DeviceHandle device,
            MemoryGetRemoteAddressInfoNV* pMemoryGetRemoteAddressInfo,
            void** pAddress
        );

        [NativeName("vkGetMemoryRemoteAddressNV")]
        [NativeFunction("vulkan", EntryPoint = "vkGetMemoryRemoteAddressNV")]
        static abstract Result GetMemoryRemoteAddressNV(
            DeviceHandle device,
            Ref<MemoryGetRemoteAddressInfoNV> pMemoryGetRemoteAddressInfo,
            Ref2D pAddress
        );

        [NativeName("vkGetMicromapBuildSizesEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetMicromapBuildSizesEXT")]
        static abstract void GetMicromapBuildSizesEXT(
            DeviceHandle device,
            AccelerationStructureBuildTypeKHR buildType,
            MicromapBuildInfoEXT* pBuildInfo,
            MicromapBuildSizesInfoEXT* pSizeInfo
        );

        [NativeName("vkGetMicromapBuildSizesEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetMicromapBuildSizesEXT")]
        static abstract void GetMicromapBuildSizesEXT(
            DeviceHandle device,
            AccelerationStructureBuildTypeKHR buildType,
            Ref<MicromapBuildInfoEXT> pBuildInfo,
            Ref<MicromapBuildSizesInfoEXT> pSizeInfo
        );

        [NativeName("vkGetPartitionedAccelerationStructuresBuildSizesNV")]
        [NativeFunction(
            "vulkan",
            EntryPoint = "vkGetPartitionedAccelerationStructuresBuildSizesNV"
        )]
        static abstract void GetPartitionedAccelerationStructuresBuildSizesNV(
            DeviceHandle device,
            PartitionedAccelerationStructureInstancesInputNV* pInfo,
            AccelerationStructureBuildSizesInfoKHR* pSizeInfo
        );

        [NativeName("vkGetPartitionedAccelerationStructuresBuildSizesNV")]
        [NativeFunction(
            "vulkan",
            EntryPoint = "vkGetPartitionedAccelerationStructuresBuildSizesNV"
        )]
        static abstract void GetPartitionedAccelerationStructuresBuildSizesNV(
            DeviceHandle device,
            Ref<PartitionedAccelerationStructureInstancesInputNV> pInfo,
            Ref<AccelerationStructureBuildSizesInfoKHR> pSizeInfo
        );

        [NativeName("vkGetPastPresentationTimingEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPastPresentationTimingEXT")]
        static abstract Result GetPastPresentationTimingEXT(
            DeviceHandle device,
            PastPresentationTimingInfoEXT* pPastPresentationTimingInfo,
            PastPresentationTimingPropertiesEXT* pPastPresentationTimingProperties
        );

        [NativeName("vkGetPastPresentationTimingEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPastPresentationTimingEXT")]
        static abstract Result GetPastPresentationTimingEXT(
            DeviceHandle device,
            Ref<PastPresentationTimingInfoEXT> pPastPresentationTimingInfo,
            Ref<PastPresentationTimingPropertiesEXT> pPastPresentationTimingProperties
        );

        [NativeName("vkGetPastPresentationTimingGOOGLE")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPastPresentationTimingGOOGLE")]
        static abstract Result GetPastPresentationTimingGOOGLE(
            DeviceHandle device,
            SwapchainHandleKHR swapchain,
            uint* pPresentationTimingCount,
            PastPresentationTimingGOOGLE* pPresentationTimings
        );

        [NativeName("vkGetPastPresentationTimingGOOGLE")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPastPresentationTimingGOOGLE")]
        static abstract Result GetPastPresentationTimingGOOGLE(
            DeviceHandle device,
            SwapchainHandleKHR swapchain,
            Ref<uint> pPresentationTimingCount,
            Ref<PastPresentationTimingGOOGLE> pPresentationTimings
        );

        [NativeName("vkGetPerformanceParameterINTEL")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPerformanceParameterINTEL")]
        static abstract Result GetPerformanceParameterINTEL(
            DeviceHandle device,
            PerformanceParameterTypeINTEL parameter,
            PerformanceValueINTEL* pValue
        );

        [NativeName("vkGetPerformanceParameterINTEL")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPerformanceParameterINTEL")]
        static abstract Result GetPerformanceParameterINTEL(
            DeviceHandle device,
            PerformanceParameterTypeINTEL parameter,
            Ref<PerformanceValueINTEL> pValue
        );

        [NativeName("vkGetPhysicalDeviceCalibrateableTimeDomainsEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceCalibrateableTimeDomainsEXT")]
        static abstract Result GetPhysicalDeviceCalibrateableTimeDomainsEXT(
            PhysicalDeviceHandle physicalDevice,
            uint* pTimeDomainCount,
            TimeDomainKHR* pTimeDomains
        );

        [NativeName("vkGetPhysicalDeviceCalibrateableTimeDomainsEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceCalibrateableTimeDomainsEXT")]
        static abstract Result GetPhysicalDeviceCalibrateableTimeDomainsEXT(
            PhysicalDeviceHandle physicalDevice,
            Ref<uint> pTimeDomainCount,
            Ref<TimeDomainKHR> pTimeDomains
        );

        [NativeName("vkGetPhysicalDeviceCalibrateableTimeDomainsKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceCalibrateableTimeDomainsKHR")]
        static abstract Result GetPhysicalDeviceCalibrateableTimeDomainsKHR(
            PhysicalDeviceHandle physicalDevice,
            uint* pTimeDomainCount,
            TimeDomainKHR* pTimeDomains
        );

        [NativeName("vkGetPhysicalDeviceCalibrateableTimeDomainsKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceCalibrateableTimeDomainsKHR")]
        static abstract Result GetPhysicalDeviceCalibrateableTimeDomainsKHR(
            PhysicalDeviceHandle physicalDevice,
            Ref<uint> pTimeDomainCount,
            Ref<TimeDomainKHR> pTimeDomains
        );

        [NativeName("vkGetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV")]
        [NativeFunction(
            "vulkan",
            EntryPoint = "vkGetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV"
        )]
        static abstract Result GetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV(
            PhysicalDeviceHandle physicalDevice,
            uint* pPropertyCount,
            CooperativeMatrixFlexibleDimensionsPropertiesNV* pProperties
        );

        [NativeName("vkGetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV")]
        [NativeFunction(
            "vulkan",
            EntryPoint = "vkGetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV"
        )]
        static abstract Result GetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV(
            PhysicalDeviceHandle physicalDevice,
            Ref<uint> pPropertyCount,
            Ref<CooperativeMatrixFlexibleDimensionsPropertiesNV> pProperties
        );

        [NativeName("vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR")]
        static abstract Result GetPhysicalDeviceCooperativeMatrixPropertiesKHR(
            PhysicalDeviceHandle physicalDevice,
            uint* pPropertyCount,
            CooperativeMatrixPropertiesKHR* pProperties
        );

        [NativeName("vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR")]
        static abstract Result GetPhysicalDeviceCooperativeMatrixPropertiesKHR(
            PhysicalDeviceHandle physicalDevice,
            Ref<uint> pPropertyCount,
            Ref<CooperativeMatrixPropertiesKHR> pProperties
        );

        [NativeName("vkGetPhysicalDeviceCooperativeMatrixPropertiesNV")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceCooperativeMatrixPropertiesNV")]
        static abstract Result GetPhysicalDeviceCooperativeMatrixPropertiesNV(
            PhysicalDeviceHandle physicalDevice,
            uint* pPropertyCount,
            CooperativeMatrixPropertiesNV* pProperties
        );

        [NativeName("vkGetPhysicalDeviceCooperativeMatrixPropertiesNV")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceCooperativeMatrixPropertiesNV")]
        static abstract Result GetPhysicalDeviceCooperativeMatrixPropertiesNV(
            PhysicalDeviceHandle physicalDevice,
            Ref<uint> pPropertyCount,
            Ref<CooperativeMatrixPropertiesNV> pProperties
        );

        [NativeName("vkGetPhysicalDeviceCooperativeVectorPropertiesNV")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceCooperativeVectorPropertiesNV")]
        static abstract Result GetPhysicalDeviceCooperativeVectorPropertiesNV(
            PhysicalDeviceHandle physicalDevice,
            uint* pPropertyCount,
            CooperativeVectorPropertiesNV* pProperties
        );

        [NativeName("vkGetPhysicalDeviceCooperativeVectorPropertiesNV")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceCooperativeVectorPropertiesNV")]
        static abstract Result GetPhysicalDeviceCooperativeVectorPropertiesNV(
            PhysicalDeviceHandle physicalDevice,
            Ref<uint> pPropertyCount,
            Ref<CooperativeVectorPropertiesNV> pProperties
        );

        [NativeName("vkGetPhysicalDeviceDescriptorSizeEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceDescriptorSizeEXT")]
        static abstract ulong GetPhysicalDeviceDescriptorSizeEXT(
            PhysicalDeviceHandle physicalDevice,
            DescriptorType descriptorType
        );

        [NativeName("vkGetPhysicalDeviceDisplayPlaneProperties2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceDisplayPlaneProperties2KHR")]
        static abstract Result GetPhysicalDeviceDisplayPlaneProperties2KHR(
            PhysicalDeviceHandle physicalDevice,
            uint* pPropertyCount,
            DisplayPlaneProperties2KHR* pProperties
        );

        [NativeName("vkGetPhysicalDeviceDisplayPlaneProperties2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceDisplayPlaneProperties2KHR")]
        static abstract Result GetPhysicalDeviceDisplayPlaneProperties2KHR(
            PhysicalDeviceHandle physicalDevice,
            Ref<uint> pPropertyCount,
            Ref<DisplayPlaneProperties2KHR> pProperties
        );

        [NativeName("vkGetPhysicalDeviceDisplayPlanePropertiesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceDisplayPlanePropertiesKHR")]
        static abstract Result GetPhysicalDeviceDisplayPlanePropertiesKHR(
            PhysicalDeviceHandle physicalDevice,
            uint* pPropertyCount,
            DisplayPlanePropertiesKHR* pProperties
        );

        [NativeName("vkGetPhysicalDeviceDisplayPlanePropertiesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceDisplayPlanePropertiesKHR")]
        static abstract Result GetPhysicalDeviceDisplayPlanePropertiesKHR(
            PhysicalDeviceHandle physicalDevice,
            Ref<uint> pPropertyCount,
            Ref<DisplayPlanePropertiesKHR> pProperties
        );

        [NativeName("vkGetPhysicalDeviceDisplayProperties2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceDisplayProperties2KHR")]
        static abstract Result GetPhysicalDeviceDisplayProperties2KHR(
            PhysicalDeviceHandle physicalDevice,
            uint* pPropertyCount,
            DisplayProperties2KHR* pProperties
        );

        [NativeName("vkGetPhysicalDeviceDisplayProperties2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceDisplayProperties2KHR")]
        static abstract Result GetPhysicalDeviceDisplayProperties2KHR(
            PhysicalDeviceHandle physicalDevice,
            Ref<uint> pPropertyCount,
            Ref<DisplayProperties2KHR> pProperties
        );

        [NativeName("vkGetPhysicalDeviceDisplayPropertiesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceDisplayPropertiesKHR")]
        static abstract Result GetPhysicalDeviceDisplayPropertiesKHR(
            PhysicalDeviceHandle physicalDevice,
            uint* pPropertyCount,
            DisplayPropertiesKHR* pProperties
        );

        [NativeName("vkGetPhysicalDeviceDisplayPropertiesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceDisplayPropertiesKHR")]
        static abstract Result GetPhysicalDeviceDisplayPropertiesKHR(
            PhysicalDeviceHandle physicalDevice,
            Ref<uint> pPropertyCount,
            Ref<DisplayPropertiesKHR> pProperties
        );

        [NativeName("vkGetPhysicalDeviceExternalBufferProperties")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalBufferProperties")]
        static abstract void GetPhysicalDeviceExternalBufferProperties(
            PhysicalDeviceHandle physicalDevice,
            PhysicalDeviceExternalBufferInfo* pExternalBufferInfo,
            ExternalBufferProperties* pExternalBufferProperties
        );

        [NativeName("vkGetPhysicalDeviceExternalBufferProperties")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalBufferProperties")]
        static abstract void GetPhysicalDeviceExternalBufferProperties(
            PhysicalDeviceHandle physicalDevice,
            Ref<PhysicalDeviceExternalBufferInfo> pExternalBufferInfo,
            Ref<ExternalBufferProperties> pExternalBufferProperties
        );

        [NativeName("vkGetPhysicalDeviceExternalBufferPropertiesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalBufferPropertiesKHR")]
        static abstract void GetPhysicalDeviceExternalBufferPropertiesKHR(
            PhysicalDeviceHandle physicalDevice,
            PhysicalDeviceExternalBufferInfo* pExternalBufferInfo,
            ExternalBufferProperties* pExternalBufferProperties
        );

        [NativeName("vkGetPhysicalDeviceExternalBufferPropertiesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalBufferPropertiesKHR")]
        static abstract void GetPhysicalDeviceExternalBufferPropertiesKHR(
            PhysicalDeviceHandle physicalDevice,
            Ref<PhysicalDeviceExternalBufferInfo> pExternalBufferInfo,
            Ref<ExternalBufferProperties> pExternalBufferProperties
        );

        [NativeName("vkGetPhysicalDeviceExternalFenceProperties")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalFenceProperties")]
        static abstract void GetPhysicalDeviceExternalFenceProperties(
            PhysicalDeviceHandle physicalDevice,
            PhysicalDeviceExternalFenceInfo* pExternalFenceInfo,
            ExternalFenceProperties* pExternalFenceProperties
        );

        [NativeName("vkGetPhysicalDeviceExternalFenceProperties")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalFenceProperties")]
        static abstract void GetPhysicalDeviceExternalFenceProperties(
            PhysicalDeviceHandle physicalDevice,
            Ref<PhysicalDeviceExternalFenceInfo> pExternalFenceInfo,
            Ref<ExternalFenceProperties> pExternalFenceProperties
        );

        [NativeName("vkGetPhysicalDeviceExternalFencePropertiesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalFencePropertiesKHR")]
        static abstract void GetPhysicalDeviceExternalFencePropertiesKHR(
            PhysicalDeviceHandle physicalDevice,
            PhysicalDeviceExternalFenceInfo* pExternalFenceInfo,
            ExternalFenceProperties* pExternalFenceProperties
        );

        [NativeName("vkGetPhysicalDeviceExternalFencePropertiesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalFencePropertiesKHR")]
        static abstract void GetPhysicalDeviceExternalFencePropertiesKHR(
            PhysicalDeviceHandle physicalDevice,
            Ref<PhysicalDeviceExternalFenceInfo> pExternalFenceInfo,
            Ref<ExternalFenceProperties> pExternalFenceProperties
        );

        [NativeName("vkGetPhysicalDeviceExternalImageFormatPropertiesNV")]
        [NativeFunction(
            "vulkan",
            EntryPoint = "vkGetPhysicalDeviceExternalImageFormatPropertiesNV"
        )]
        static abstract Result GetPhysicalDeviceExternalImageFormatPropertiesNV(
            PhysicalDeviceHandle physicalDevice,
            Format format,
            ImageType type,
            ImageTiling tiling,
            ImageUsageFlags usage,
            ImageCreateFlags flags,
            ExternalMemoryHandleTypeFlagsNV externalHandleType,
            ExternalImageFormatPropertiesNV* pExternalImageFormatProperties
        );

        [NativeName("vkGetPhysicalDeviceExternalImageFormatPropertiesNV")]
        [NativeFunction(
            "vulkan",
            EntryPoint = "vkGetPhysicalDeviceExternalImageFormatPropertiesNV"
        )]
        static abstract Result GetPhysicalDeviceExternalImageFormatPropertiesNV(
            PhysicalDeviceHandle physicalDevice,
            Format format,
            ImageType type,
            ImageTiling tiling,
            ImageUsageFlags usage,
            ImageCreateFlags flags,
            ExternalMemoryHandleTypeFlagsNV externalHandleType,
            Ref<ExternalImageFormatPropertiesNV> pExternalImageFormatProperties
        );

        [NativeName("vkGetPhysicalDeviceExternalSemaphoreProperties")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalSemaphoreProperties")]
        static abstract void GetPhysicalDeviceExternalSemaphoreProperties(
            PhysicalDeviceHandle physicalDevice,
            PhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo,
            ExternalSemaphoreProperties* pExternalSemaphoreProperties
        );

        [NativeName("vkGetPhysicalDeviceExternalSemaphoreProperties")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalSemaphoreProperties")]
        static abstract void GetPhysicalDeviceExternalSemaphoreProperties(
            PhysicalDeviceHandle physicalDevice,
            Ref<PhysicalDeviceExternalSemaphoreInfo> pExternalSemaphoreInfo,
            Ref<ExternalSemaphoreProperties> pExternalSemaphoreProperties
        );

        [NativeName("vkGetPhysicalDeviceExternalSemaphorePropertiesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalSemaphorePropertiesKHR")]
        static abstract void GetPhysicalDeviceExternalSemaphorePropertiesKHR(
            PhysicalDeviceHandle physicalDevice,
            PhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo,
            ExternalSemaphoreProperties* pExternalSemaphoreProperties
        );

        [NativeName("vkGetPhysicalDeviceExternalSemaphorePropertiesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalSemaphorePropertiesKHR")]
        static abstract void GetPhysicalDeviceExternalSemaphorePropertiesKHR(
            PhysicalDeviceHandle physicalDevice,
            Ref<PhysicalDeviceExternalSemaphoreInfo> pExternalSemaphoreInfo,
            Ref<ExternalSemaphoreProperties> pExternalSemaphoreProperties
        );

        [NativeName("vkGetPhysicalDeviceExternalTensorPropertiesARM")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalTensorPropertiesARM")]
        static abstract void GetPhysicalDeviceExternalTensorPropertiesARM(
            PhysicalDeviceHandle physicalDevice,
            PhysicalDeviceExternalTensorInfoARM* pExternalTensorInfo,
            ExternalTensorPropertiesARM* pExternalTensorProperties
        );

        [NativeName("vkGetPhysicalDeviceExternalTensorPropertiesARM")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalTensorPropertiesARM")]
        static abstract void GetPhysicalDeviceExternalTensorPropertiesARM(
            PhysicalDeviceHandle physicalDevice,
            Ref<PhysicalDeviceExternalTensorInfoARM> pExternalTensorInfo,
            Ref<ExternalTensorPropertiesARM> pExternalTensorProperties
        );

        [NativeName("vkGetPhysicalDeviceFeatures")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceFeatures")]
        static abstract void GetPhysicalDeviceFeatures(
            PhysicalDeviceHandle physicalDevice,
            PhysicalDeviceFeatures* pFeatures
        );

        [NativeName("vkGetPhysicalDeviceFeatures")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceFeatures")]
        static abstract void GetPhysicalDeviceFeatures(
            PhysicalDeviceHandle physicalDevice,
            Ref<PhysicalDeviceFeatures> pFeatures
        );

        [NativeName("vkGetPhysicalDeviceFeatures2")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceFeatures2")]
        static abstract void GetPhysicalDeviceFeatures2(
            PhysicalDeviceHandle physicalDevice,
            PhysicalDeviceFeatures2* pFeatures
        );

        [NativeName("vkGetPhysicalDeviceFeatures2")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceFeatures2")]
        static abstract void GetPhysicalDeviceFeatures2(
            PhysicalDeviceHandle physicalDevice,
            Ref<PhysicalDeviceFeatures2> pFeatures
        );

        [NativeName("vkGetPhysicalDeviceFeatures2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceFeatures2KHR")]
        static abstract void GetPhysicalDeviceFeatures2KHR(
            PhysicalDeviceHandle physicalDevice,
            PhysicalDeviceFeatures2* pFeatures
        );

        [NativeName("vkGetPhysicalDeviceFeatures2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceFeatures2KHR")]
        static abstract void GetPhysicalDeviceFeatures2KHR(
            PhysicalDeviceHandle physicalDevice,
            Ref<PhysicalDeviceFeatures2> pFeatures
        );

        [NativeName("vkGetPhysicalDeviceFormatProperties")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceFormatProperties")]
        static abstract void GetPhysicalDeviceFormatProperties(
            PhysicalDeviceHandle physicalDevice,
            Format format,
            FormatProperties* pFormatProperties
        );

        [NativeName("vkGetPhysicalDeviceFormatProperties")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceFormatProperties")]
        static abstract void GetPhysicalDeviceFormatProperties(
            PhysicalDeviceHandle physicalDevice,
            Format format,
            Ref<FormatProperties> pFormatProperties
        );

        [NativeName("vkGetPhysicalDeviceFormatProperties2")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceFormatProperties2")]
        static abstract void GetPhysicalDeviceFormatProperties2(
            PhysicalDeviceHandle physicalDevice,
            Format format,
            FormatProperties2* pFormatProperties
        );

        [NativeName("vkGetPhysicalDeviceFormatProperties2")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceFormatProperties2")]
        static abstract void GetPhysicalDeviceFormatProperties2(
            PhysicalDeviceHandle physicalDevice,
            Format format,
            Ref<FormatProperties2> pFormatProperties
        );

        [NativeName("vkGetPhysicalDeviceFormatProperties2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceFormatProperties2KHR")]
        static abstract void GetPhysicalDeviceFormatProperties2KHR(
            PhysicalDeviceHandle physicalDevice,
            Format format,
            FormatProperties2* pFormatProperties
        );

        [NativeName("vkGetPhysicalDeviceFormatProperties2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceFormatProperties2KHR")]
        static abstract void GetPhysicalDeviceFormatProperties2KHR(
            PhysicalDeviceHandle physicalDevice,
            Format format,
            Ref<FormatProperties2> pFormatProperties
        );

        [NativeName("vkGetPhysicalDeviceFragmentShadingRatesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceFragmentShadingRatesKHR")]
        static abstract Result GetPhysicalDeviceFragmentShadingRatesKHR(
            PhysicalDeviceHandle physicalDevice,
            uint* pFragmentShadingRateCount,
            PhysicalDeviceFragmentShadingRateKHR* pFragmentShadingRates
        );

        [NativeName("vkGetPhysicalDeviceFragmentShadingRatesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceFragmentShadingRatesKHR")]
        static abstract Result GetPhysicalDeviceFragmentShadingRatesKHR(
            PhysicalDeviceHandle physicalDevice,
            Ref<uint> pFragmentShadingRateCount,
            Ref<PhysicalDeviceFragmentShadingRateKHR> pFragmentShadingRates
        );

        [NativeName("vkGetPhysicalDeviceImageFormatProperties")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceImageFormatProperties")]
        static abstract Result GetPhysicalDeviceImageFormatProperties(
            PhysicalDeviceHandle physicalDevice,
            Format format,
            ImageType type,
            ImageTiling tiling,
            ImageUsageFlags usage,
            ImageCreateFlags flags,
            ImageFormatProperties* pImageFormatProperties
        );

        [NativeName("vkGetPhysicalDeviceImageFormatProperties")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceImageFormatProperties")]
        static abstract Result GetPhysicalDeviceImageFormatProperties(
            PhysicalDeviceHandle physicalDevice,
            Format format,
            ImageType type,
            ImageTiling tiling,
            ImageUsageFlags usage,
            ImageCreateFlags flags,
            Ref<ImageFormatProperties> pImageFormatProperties
        );

        [NativeName("vkGetPhysicalDeviceImageFormatProperties2")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2")]
        static abstract Result GetPhysicalDeviceImageFormatProperties2(
            PhysicalDeviceHandle physicalDevice,
            PhysicalDeviceImageFormatInfo2* pImageFormatInfo,
            ImageFormatProperties2* pImageFormatProperties
        );

        [NativeName("vkGetPhysicalDeviceImageFormatProperties2")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2")]
        static abstract Result GetPhysicalDeviceImageFormatProperties2(
            PhysicalDeviceHandle physicalDevice,
            Ref<PhysicalDeviceImageFormatInfo2> pImageFormatInfo,
            Ref<ImageFormatProperties2> pImageFormatProperties
        );

        [NativeName("vkGetPhysicalDeviceImageFormatProperties2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2KHR")]
        static abstract Result GetPhysicalDeviceImageFormatProperties2KHR(
            PhysicalDeviceHandle physicalDevice,
            PhysicalDeviceImageFormatInfo2* pImageFormatInfo,
            ImageFormatProperties2* pImageFormatProperties
        );

        [NativeName("vkGetPhysicalDeviceImageFormatProperties2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2KHR")]
        static abstract Result GetPhysicalDeviceImageFormatProperties2KHR(
            PhysicalDeviceHandle physicalDevice,
            Ref<PhysicalDeviceImageFormatInfo2> pImageFormatInfo,
            Ref<ImageFormatProperties2> pImageFormatProperties
        );

        [NativeName("vkGetPhysicalDeviceMemoryProperties")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceMemoryProperties")]
        static abstract void GetPhysicalDeviceMemoryProperties(
            PhysicalDeviceHandle physicalDevice,
            PhysicalDeviceMemoryProperties* pMemoryProperties
        );

        [NativeName("vkGetPhysicalDeviceMemoryProperties")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceMemoryProperties")]
        static abstract void GetPhysicalDeviceMemoryProperties(
            PhysicalDeviceHandle physicalDevice,
            Ref<PhysicalDeviceMemoryProperties> pMemoryProperties
        );

        [NativeName("vkGetPhysicalDeviceMemoryProperties2")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceMemoryProperties2")]
        static abstract void GetPhysicalDeviceMemoryProperties2(
            PhysicalDeviceHandle physicalDevice,
            PhysicalDeviceMemoryProperties2* pMemoryProperties
        );

        [NativeName("vkGetPhysicalDeviceMemoryProperties2")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceMemoryProperties2")]
        static abstract void GetPhysicalDeviceMemoryProperties2(
            PhysicalDeviceHandle physicalDevice,
            Ref<PhysicalDeviceMemoryProperties2> pMemoryProperties
        );

        [NativeName("vkGetPhysicalDeviceMemoryProperties2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceMemoryProperties2KHR")]
        static abstract void GetPhysicalDeviceMemoryProperties2KHR(
            PhysicalDeviceHandle physicalDevice,
            PhysicalDeviceMemoryProperties2* pMemoryProperties
        );

        [NativeName("vkGetPhysicalDeviceMemoryProperties2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceMemoryProperties2KHR")]
        static abstract void GetPhysicalDeviceMemoryProperties2KHR(
            PhysicalDeviceHandle physicalDevice,
            Ref<PhysicalDeviceMemoryProperties2> pMemoryProperties
        );

        [NativeName("vkGetPhysicalDeviceMultisamplePropertiesEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceMultisamplePropertiesEXT")]
        static abstract void GetPhysicalDeviceMultisamplePropertiesEXT(
            PhysicalDeviceHandle physicalDevice,
            SampleCountFlags samples,
            MultisamplePropertiesEXT* pMultisampleProperties
        );

        [NativeName("vkGetPhysicalDeviceMultisamplePropertiesEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceMultisamplePropertiesEXT")]
        static abstract void GetPhysicalDeviceMultisamplePropertiesEXT(
            PhysicalDeviceHandle physicalDevice,
            SampleCountFlags samples,
            Ref<MultisamplePropertiesEXT> pMultisampleProperties
        );

        [NativeName("vkGetPhysicalDeviceOpticalFlowImageFormatsNV")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceOpticalFlowImageFormatsNV")]
        static abstract Result GetPhysicalDeviceOpticalFlowImageFormatsNV(
            PhysicalDeviceHandle physicalDevice,
            OpticalFlowImageFormatInfoNV* pOpticalFlowImageFormatInfo,
            uint* pFormatCount,
            OpticalFlowImageFormatPropertiesNV* pImageFormatProperties
        );

        [NativeName("vkGetPhysicalDeviceOpticalFlowImageFormatsNV")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceOpticalFlowImageFormatsNV")]
        static abstract Result GetPhysicalDeviceOpticalFlowImageFormatsNV(
            PhysicalDeviceHandle physicalDevice,
            Ref<OpticalFlowImageFormatInfoNV> pOpticalFlowImageFormatInfo,
            Ref<uint> pFormatCount,
            Ref<OpticalFlowImageFormatPropertiesNV> pImageFormatProperties
        );

        [NativeName("vkGetPhysicalDevicePresentRectanglesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDevicePresentRectanglesKHR")]
        static abstract Result GetPhysicalDevicePresentRectanglesKHR(
            PhysicalDeviceHandle physicalDevice,
            SurfaceHandleKHR surface,
            uint* pRectCount,
            Rect2D* pRects
        );

        [NativeName("vkGetPhysicalDevicePresentRectanglesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDevicePresentRectanglesKHR")]
        static abstract Result GetPhysicalDevicePresentRectanglesKHR(
            PhysicalDeviceHandle physicalDevice,
            SurfaceHandleKHR surface,
            Ref<uint> pRectCount,
            Ref<Rect2D> pRects
        );

        [NativeName("vkGetPhysicalDeviceProperties")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceProperties")]
        static abstract void GetPhysicalDeviceProperties(
            PhysicalDeviceHandle physicalDevice,
            PhysicalDeviceProperties* pProperties
        );

        [NativeName("vkGetPhysicalDeviceProperties")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceProperties")]
        static abstract void GetPhysicalDeviceProperties(
            PhysicalDeviceHandle physicalDevice,
            Ref<PhysicalDeviceProperties> pProperties
        );

        [NativeName("vkGetPhysicalDeviceProperties2")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceProperties2")]
        static abstract void GetPhysicalDeviceProperties2(
            PhysicalDeviceHandle physicalDevice,
            PhysicalDeviceProperties2* pProperties
        );

        [NativeName("vkGetPhysicalDeviceProperties2")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceProperties2")]
        static abstract void GetPhysicalDeviceProperties2(
            PhysicalDeviceHandle physicalDevice,
            Ref<PhysicalDeviceProperties2> pProperties
        );

        [NativeName("vkGetPhysicalDeviceProperties2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceProperties2KHR")]
        static abstract void GetPhysicalDeviceProperties2KHR(
            PhysicalDeviceHandle physicalDevice,
            PhysicalDeviceProperties2* pProperties
        );

        [NativeName("vkGetPhysicalDeviceProperties2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceProperties2KHR")]
        static abstract void GetPhysicalDeviceProperties2KHR(
            PhysicalDeviceHandle physicalDevice,
            Ref<PhysicalDeviceProperties2> pProperties
        );

        [NativeName("vkGetPhysicalDeviceQueueFamilyDataGraphEngineOperationPropertiesARM")]
        [NativeFunction(
            "vulkan",
            EntryPoint = "vkGetPhysicalDeviceQueueFamilyDataGraphEngineOperationPropertiesARM"
        )]
        static abstract Result GetPhysicalDeviceQueueFamilyDataGraphEngineOperationPropertiesARM(
            PhysicalDeviceHandle physicalDevice,
            uint queueFamilyIndex,
            QueueFamilyDataGraphPropertiesARM* pQueueFamilyDataGraphProperties,
            BaseOutStructure* pProperties
        );

        [NativeName("vkGetPhysicalDeviceQueueFamilyDataGraphEngineOperationPropertiesARM")]
        [NativeFunction(
            "vulkan",
            EntryPoint = "vkGetPhysicalDeviceQueueFamilyDataGraphEngineOperationPropertiesARM"
        )]
        static abstract Result GetPhysicalDeviceQueueFamilyDataGraphEngineOperationPropertiesARM(
            PhysicalDeviceHandle physicalDevice,
            uint queueFamilyIndex,
            Ref<QueueFamilyDataGraphPropertiesARM> pQueueFamilyDataGraphProperties,
            Ref<BaseOutStructure> pProperties
        );

        [NativeName("vkGetPhysicalDeviceQueueFamilyDataGraphOpticalFlowImageFormatsARM")]
        [NativeFunction(
            "vulkan",
            EntryPoint = "vkGetPhysicalDeviceQueueFamilyDataGraphOpticalFlowImageFormatsARM"
        )]
        static abstract Result GetPhysicalDeviceQueueFamilyDataGraphOpticalFlowImageFormatsARM(
            PhysicalDeviceHandle physicalDevice,
            uint queueFamilyIndex,
            QueueFamilyDataGraphPropertiesARM* pQueueFamilyDataGraphProperties,
            DataGraphOpticalFlowImageFormatInfoARM* pOpticalFlowImageFormatInfo,
            uint* pFormatCount,
            DataGraphOpticalFlowImageFormatPropertiesARM* pImageFormatProperties
        );

        [NativeName("vkGetPhysicalDeviceQueueFamilyDataGraphOpticalFlowImageFormatsARM")]
        [NativeFunction(
            "vulkan",
            EntryPoint = "vkGetPhysicalDeviceQueueFamilyDataGraphOpticalFlowImageFormatsARM"
        )]
        static abstract Result GetPhysicalDeviceQueueFamilyDataGraphOpticalFlowImageFormatsARM(
            PhysicalDeviceHandle physicalDevice,
            uint queueFamilyIndex,
            Ref<QueueFamilyDataGraphPropertiesARM> pQueueFamilyDataGraphProperties,
            Ref<DataGraphOpticalFlowImageFormatInfoARM> pOpticalFlowImageFormatInfo,
            Ref<uint> pFormatCount,
            Ref<DataGraphOpticalFlowImageFormatPropertiesARM> pImageFormatProperties
        );

        [NativeName("vkGetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM")]
        [NativeFunction(
            "vulkan",
            EntryPoint = "vkGetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM"
        )]
        static abstract void GetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM(
            PhysicalDeviceHandle physicalDevice,
            PhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM* pQueueFamilyDataGraphProcessingEngineInfo,
            QueueFamilyDataGraphProcessingEnginePropertiesARM* pQueueFamilyDataGraphProcessingEngineProperties
        );

        [NativeName("vkGetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM")]
        [NativeFunction(
            "vulkan",
            EntryPoint = "vkGetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM"
        )]
        static abstract void GetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM(
            PhysicalDeviceHandle physicalDevice,
            Ref<PhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM> pQueueFamilyDataGraphProcessingEngineInfo,
            Ref<QueueFamilyDataGraphProcessingEnginePropertiesARM> pQueueFamilyDataGraphProcessingEngineProperties
        );

        [NativeName("vkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM")]
        [NativeFunction(
            "vulkan",
            EntryPoint = "vkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM"
        )]
        static abstract Result GetPhysicalDeviceQueueFamilyDataGraphPropertiesARM(
            PhysicalDeviceHandle physicalDevice,
            uint queueFamilyIndex,
            uint* pQueueFamilyDataGraphPropertyCount,
            QueueFamilyDataGraphPropertiesARM* pQueueFamilyDataGraphProperties
        );

        [NativeName("vkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM")]
        [NativeFunction(
            "vulkan",
            EntryPoint = "vkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM"
        )]
        static abstract Result GetPhysicalDeviceQueueFamilyDataGraphPropertiesARM(
            PhysicalDeviceHandle physicalDevice,
            uint queueFamilyIndex,
            Ref<uint> pQueueFamilyDataGraphPropertyCount,
            Ref<QueueFamilyDataGraphPropertiesARM> pQueueFamilyDataGraphProperties
        );

        [NativeName("vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR")]
        [NativeFunction(
            "vulkan",
            EntryPoint = "vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR"
        )]
        static abstract void GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(
            PhysicalDeviceHandle physicalDevice,
            QueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo,
            uint* pNumPasses
        );

        [NativeName("vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR")]
        [NativeFunction(
            "vulkan",
            EntryPoint = "vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR"
        )]
        static abstract void GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(
            PhysicalDeviceHandle physicalDevice,
            Ref<QueryPoolPerformanceCreateInfoKHR> pPerformanceQueryCreateInfo,
            Ref<uint> pNumPasses
        );

        [NativeName("vkGetPhysicalDeviceQueueFamilyProperties")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties")]
        static abstract void GetPhysicalDeviceQueueFamilyProperties(
            PhysicalDeviceHandle physicalDevice,
            uint* pQueueFamilyPropertyCount,
            QueueFamilyProperties* pQueueFamilyProperties
        );

        [NativeName("vkGetPhysicalDeviceQueueFamilyProperties")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties")]
        static abstract void GetPhysicalDeviceQueueFamilyProperties(
            PhysicalDeviceHandle physicalDevice,
            Ref<uint> pQueueFamilyPropertyCount,
            Ref<QueueFamilyProperties> pQueueFamilyProperties
        );

        [NativeName("vkGetPhysicalDeviceQueueFamilyProperties2")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2")]
        static abstract void GetPhysicalDeviceQueueFamilyProperties2(
            PhysicalDeviceHandle physicalDevice,
            uint* pQueueFamilyPropertyCount,
            QueueFamilyProperties2* pQueueFamilyProperties
        );

        [NativeName("vkGetPhysicalDeviceQueueFamilyProperties2")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2")]
        static abstract void GetPhysicalDeviceQueueFamilyProperties2(
            PhysicalDeviceHandle physicalDevice,
            Ref<uint> pQueueFamilyPropertyCount,
            Ref<QueueFamilyProperties2> pQueueFamilyProperties
        );

        [NativeName("vkGetPhysicalDeviceQueueFamilyProperties2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2KHR")]
        static abstract void GetPhysicalDeviceQueueFamilyProperties2KHR(
            PhysicalDeviceHandle physicalDevice,
            uint* pQueueFamilyPropertyCount,
            QueueFamilyProperties2* pQueueFamilyProperties
        );

        [NativeName("vkGetPhysicalDeviceQueueFamilyProperties2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2KHR")]
        static abstract void GetPhysicalDeviceQueueFamilyProperties2KHR(
            PhysicalDeviceHandle physicalDevice,
            Ref<uint> pQueueFamilyPropertyCount,
            Ref<QueueFamilyProperties2> pQueueFamilyProperties
        );

        [NativeName("vkGetPhysicalDeviceSparseImageFormatProperties")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties")]
        static abstract void GetPhysicalDeviceSparseImageFormatProperties(
            PhysicalDeviceHandle physicalDevice,
            Format format,
            ImageType type,
            SampleCountFlags samples,
            ImageUsageFlags usage,
            ImageTiling tiling,
            uint* pPropertyCount,
            SparseImageFormatProperties* pProperties
        );

        [NativeName("vkGetPhysicalDeviceSparseImageFormatProperties")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties")]
        static abstract void GetPhysicalDeviceSparseImageFormatProperties(
            PhysicalDeviceHandle physicalDevice,
            Format format,
            ImageType type,
            SampleCountFlags samples,
            ImageUsageFlags usage,
            ImageTiling tiling,
            Ref<uint> pPropertyCount,
            Ref<SparseImageFormatProperties> pProperties
        );

        [NativeName("vkGetPhysicalDeviceSparseImageFormatProperties2")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2")]
        static abstract void GetPhysicalDeviceSparseImageFormatProperties2(
            PhysicalDeviceHandle physicalDevice,
            PhysicalDeviceSparseImageFormatInfo2* pFormatInfo,
            uint* pPropertyCount,
            SparseImageFormatProperties2* pProperties
        );

        [NativeName("vkGetPhysicalDeviceSparseImageFormatProperties2")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2")]
        static abstract void GetPhysicalDeviceSparseImageFormatProperties2(
            PhysicalDeviceHandle physicalDevice,
            Ref<PhysicalDeviceSparseImageFormatInfo2> pFormatInfo,
            Ref<uint> pPropertyCount,
            Ref<SparseImageFormatProperties2> pProperties
        );

        [NativeName("vkGetPhysicalDeviceSparseImageFormatProperties2KHR")]
        [NativeFunction(
            "vulkan",
            EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2KHR"
        )]
        static abstract void GetPhysicalDeviceSparseImageFormatProperties2KHR(
            PhysicalDeviceHandle physicalDevice,
            PhysicalDeviceSparseImageFormatInfo2* pFormatInfo,
            uint* pPropertyCount,
            SparseImageFormatProperties2* pProperties
        );

        [NativeName("vkGetPhysicalDeviceSparseImageFormatProperties2KHR")]
        [NativeFunction(
            "vulkan",
            EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2KHR"
        )]
        static abstract void GetPhysicalDeviceSparseImageFormatProperties2KHR(
            PhysicalDeviceHandle physicalDevice,
            Ref<PhysicalDeviceSparseImageFormatInfo2> pFormatInfo,
            Ref<uint> pPropertyCount,
            Ref<SparseImageFormatProperties2> pProperties
        );

        [NativeName("vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV")]
        [NativeFunction(
            "vulkan",
            EntryPoint = "vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV"
        )]
        static abstract Result GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(
            PhysicalDeviceHandle physicalDevice,
            uint* pCombinationCount,
            FramebufferMixedSamplesCombinationNV* pCombinations
        );

        [NativeName("vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV")]
        [NativeFunction(
            "vulkan",
            EntryPoint = "vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV"
        )]
        static abstract Result GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(
            PhysicalDeviceHandle physicalDevice,
            Ref<uint> pCombinationCount,
            Ref<FramebufferMixedSamplesCombinationNV> pCombinations
        );

        [NativeName("vkGetPhysicalDeviceSurfaceCapabilities2EXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilities2EXT")]
        static abstract Result GetPhysicalDeviceSurfaceCapabilities2EXT(
            PhysicalDeviceHandle physicalDevice,
            SurfaceHandleKHR surface,
            SurfaceCapabilities2EXT* pSurfaceCapabilities
        );

        [NativeName("vkGetPhysicalDeviceSurfaceCapabilities2EXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilities2EXT")]
        static abstract Result GetPhysicalDeviceSurfaceCapabilities2EXT(
            PhysicalDeviceHandle physicalDevice,
            SurfaceHandleKHR surface,
            Ref<SurfaceCapabilities2EXT> pSurfaceCapabilities
        );

        [NativeName("vkGetPhysicalDeviceSurfaceCapabilities2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilities2KHR")]
        static abstract Result GetPhysicalDeviceSurfaceCapabilities2KHR(
            PhysicalDeviceHandle physicalDevice,
            PhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo,
            SurfaceCapabilities2KHR* pSurfaceCapabilities
        );

        [NativeName("vkGetPhysicalDeviceSurfaceCapabilities2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilities2KHR")]
        static abstract Result GetPhysicalDeviceSurfaceCapabilities2KHR(
            PhysicalDeviceHandle physicalDevice,
            Ref<PhysicalDeviceSurfaceInfo2KHR> pSurfaceInfo,
            Ref<SurfaceCapabilities2KHR> pSurfaceCapabilities
        );

        [NativeName("vkGetPhysicalDeviceSurfaceCapabilitiesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilitiesKHR")]
        static abstract Result GetPhysicalDeviceSurfaceCapabilitiesKHR(
            PhysicalDeviceHandle physicalDevice,
            SurfaceHandleKHR surface,
            SurfaceCapabilitiesKHR* pSurfaceCapabilities
        );

        [NativeName("vkGetPhysicalDeviceSurfaceCapabilitiesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilitiesKHR")]
        static abstract Result GetPhysicalDeviceSurfaceCapabilitiesKHR(
            PhysicalDeviceHandle physicalDevice,
            SurfaceHandleKHR surface,
            Ref<SurfaceCapabilitiesKHR> pSurfaceCapabilities
        );

        [NativeName("vkGetPhysicalDeviceSurfaceFormats2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfaceFormats2KHR")]
        static abstract Result GetPhysicalDeviceSurfaceFormats2KHR(
            PhysicalDeviceHandle physicalDevice,
            PhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo,
            uint* pSurfaceFormatCount,
            SurfaceFormat2KHR* pSurfaceFormats
        );

        [NativeName("vkGetPhysicalDeviceSurfaceFormats2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfaceFormats2KHR")]
        static abstract Result GetPhysicalDeviceSurfaceFormats2KHR(
            PhysicalDeviceHandle physicalDevice,
            Ref<PhysicalDeviceSurfaceInfo2KHR> pSurfaceInfo,
            Ref<uint> pSurfaceFormatCount,
            Ref<SurfaceFormat2KHR> pSurfaceFormats
        );

        [NativeName("vkGetPhysicalDeviceSurfaceFormatsKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfaceFormatsKHR")]
        static abstract Result GetPhysicalDeviceSurfaceFormatsKHR(
            PhysicalDeviceHandle physicalDevice,
            SurfaceHandleKHR surface,
            uint* pSurfaceFormatCount,
            SurfaceFormatKHR* pSurfaceFormats
        );

        [NativeName("vkGetPhysicalDeviceSurfaceFormatsKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfaceFormatsKHR")]
        static abstract Result GetPhysicalDeviceSurfaceFormatsKHR(
            PhysicalDeviceHandle physicalDevice,
            SurfaceHandleKHR surface,
            Ref<uint> pSurfaceFormatCount,
            Ref<SurfaceFormatKHR> pSurfaceFormats
        );

        [NativeName("vkGetPhysicalDeviceSurfacePresentModesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfacePresentModesKHR")]
        static abstract Result GetPhysicalDeviceSurfacePresentModesKHR(
            PhysicalDeviceHandle physicalDevice,
            SurfaceHandleKHR surface,
            uint* pPresentModeCount,
            PresentModeKHR* pPresentModes
        );

        [NativeName("vkGetPhysicalDeviceSurfacePresentModesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfacePresentModesKHR")]
        static abstract Result GetPhysicalDeviceSurfacePresentModesKHR(
            PhysicalDeviceHandle physicalDevice,
            SurfaceHandleKHR surface,
            Ref<uint> pPresentModeCount,
            Ref<PresentModeKHR> pPresentModes
        );

        [NativeName("vkGetPhysicalDeviceSurfaceSupportKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfaceSupportKHR")]
        static abstract Result GetPhysicalDeviceSurfaceSupportKHR(
            PhysicalDeviceHandle physicalDevice,
            uint queueFamilyIndex,
            SurfaceHandleKHR surface,
            uint* pSupported
        );

        [NativeName("vkGetPhysicalDeviceSurfaceSupportKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfaceSupportKHR")]
        static abstract Result GetPhysicalDeviceSurfaceSupportKHR(
            PhysicalDeviceHandle physicalDevice,
            uint queueFamilyIndex,
            SurfaceHandleKHR surface,
            Ref<uint> pSupported
        );

        [NativeName("vkGetPhysicalDeviceToolProperties")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceToolProperties")]
        static abstract Result GetPhysicalDeviceToolProperties(
            PhysicalDeviceHandle physicalDevice,
            uint* pToolCount,
            PhysicalDeviceToolProperties* pToolProperties
        );

        [NativeName("vkGetPhysicalDeviceToolProperties")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceToolProperties")]
        static abstract Result GetPhysicalDeviceToolProperties(
            PhysicalDeviceHandle physicalDevice,
            Ref<uint> pToolCount,
            Ref<PhysicalDeviceToolProperties> pToolProperties
        );

        [NativeName("vkGetPhysicalDeviceToolPropertiesEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceToolPropertiesEXT")]
        static abstract Result GetPhysicalDeviceToolPropertiesEXT(
            PhysicalDeviceHandle physicalDevice,
            uint* pToolCount,
            PhysicalDeviceToolProperties* pToolProperties
        );

        [NativeName("vkGetPhysicalDeviceToolPropertiesEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceToolPropertiesEXT")]
        static abstract Result GetPhysicalDeviceToolPropertiesEXT(
            PhysicalDeviceHandle physicalDevice,
            Ref<uint> pToolCount,
            Ref<PhysicalDeviceToolProperties> pToolProperties
        );

        [NativeName("vkGetPhysicalDeviceVideoCapabilitiesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceVideoCapabilitiesKHR")]
        static abstract Result GetPhysicalDeviceVideoCapabilitiesKHR(
            PhysicalDeviceHandle physicalDevice,
            VideoProfileInfoKHR* pVideoProfile,
            VideoCapabilitiesKHR* pCapabilities
        );

        [NativeName("vkGetPhysicalDeviceVideoCapabilitiesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceVideoCapabilitiesKHR")]
        static abstract Result GetPhysicalDeviceVideoCapabilitiesKHR(
            PhysicalDeviceHandle physicalDevice,
            Ref<VideoProfileInfoKHR> pVideoProfile,
            Ref<VideoCapabilitiesKHR> pCapabilities
        );

        [NativeName("vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR")]
        [NativeFunction(
            "vulkan",
            EntryPoint = "vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR"
        )]
        static abstract Result GetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR(
            PhysicalDeviceHandle physicalDevice,
            PhysicalDeviceVideoEncodeQualityLevelInfoKHR* pQualityLevelInfo,
            VideoEncodeQualityLevelPropertiesKHR* pQualityLevelProperties
        );

        [NativeName("vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR")]
        [NativeFunction(
            "vulkan",
            EntryPoint = "vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR"
        )]
        static abstract Result GetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR(
            PhysicalDeviceHandle physicalDevice,
            Ref<PhysicalDeviceVideoEncodeQualityLevelInfoKHR> pQualityLevelInfo,
            Ref<VideoEncodeQualityLevelPropertiesKHR> pQualityLevelProperties
        );

        [NativeName("vkGetPhysicalDeviceVideoFormatPropertiesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceVideoFormatPropertiesKHR")]
        static abstract Result GetPhysicalDeviceVideoFormatPropertiesKHR(
            PhysicalDeviceHandle physicalDevice,
            PhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfo,
            uint* pVideoFormatPropertyCount,
            VideoFormatPropertiesKHR* pVideoFormatProperties
        );

        [NativeName("vkGetPhysicalDeviceVideoFormatPropertiesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceVideoFormatPropertiesKHR")]
        static abstract Result GetPhysicalDeviceVideoFormatPropertiesKHR(
            PhysicalDeviceHandle physicalDevice,
            Ref<PhysicalDeviceVideoFormatInfoKHR> pVideoFormatInfo,
            Ref<uint> pVideoFormatPropertyCount,
            Ref<VideoFormatPropertiesKHR> pVideoFormatProperties
        );

        [NativeName("vkGetPipelineBinaryDataKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPipelineBinaryDataKHR")]
        static abstract Result GetPipelineBinaryDataKHR(
            DeviceHandle device,
            PipelineBinaryDataInfoKHR* pInfo,
            PipelineBinaryKeyKHR* pPipelineBinaryKey,
            nuint* pPipelineBinaryDataSize,
            void* pPipelineBinaryData
        );

        [NativeName("vkGetPipelineBinaryDataKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPipelineBinaryDataKHR")]
        static abstract Result GetPipelineBinaryDataKHR(
            DeviceHandle device,
            Ref<PipelineBinaryDataInfoKHR> pInfo,
            Ref<PipelineBinaryKeyKHR> pPipelineBinaryKey,
            Ref<nuint> pPipelineBinaryDataSize,
            Ref pPipelineBinaryData
        );

        [NativeName("vkGetPipelineCacheData")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPipelineCacheData")]
        static abstract Result GetPipelineCacheData(
            DeviceHandle device,
            PipelineCacheHandle pipelineCache,
            nuint* pDataSize,
            void* pData
        );

        [NativeName("vkGetPipelineCacheData")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPipelineCacheData")]
        static abstract Result GetPipelineCacheData(
            DeviceHandle device,
            PipelineCacheHandle pipelineCache,
            Ref<nuint> pDataSize,
            Ref pData
        );

        [NativeName("vkGetPipelineExecutableInternalRepresentationsKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPipelineExecutableInternalRepresentationsKHR")]
        static abstract Result GetPipelineExecutableInternalRepresentationsKHR(
            DeviceHandle device,
            PipelineExecutableInfoKHR* pExecutableInfo,
            uint* pInternalRepresentationCount,
            PipelineExecutableInternalRepresentationKHR* pInternalRepresentations
        );

        [NativeName("vkGetPipelineExecutableInternalRepresentationsKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPipelineExecutableInternalRepresentationsKHR")]
        static abstract Result GetPipelineExecutableInternalRepresentationsKHR(
            DeviceHandle device,
            Ref<PipelineExecutableInfoKHR> pExecutableInfo,
            Ref<uint> pInternalRepresentationCount,
            Ref<PipelineExecutableInternalRepresentationKHR> pInternalRepresentations
        );

        [NativeName("vkGetPipelineExecutablePropertiesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPipelineExecutablePropertiesKHR")]
        static abstract Result GetPipelineExecutablePropertiesKHR(
            DeviceHandle device,
            PipelineInfoKHR* pPipelineInfo,
            uint* pExecutableCount,
            PipelineExecutablePropertiesKHR* pProperties
        );

        [NativeName("vkGetPipelineExecutablePropertiesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPipelineExecutablePropertiesKHR")]
        static abstract Result GetPipelineExecutablePropertiesKHR(
            DeviceHandle device,
            Ref<PipelineInfoKHR> pPipelineInfo,
            Ref<uint> pExecutableCount,
            Ref<PipelineExecutablePropertiesKHR> pProperties
        );

        [NativeName("vkGetPipelineExecutableStatisticsKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPipelineExecutableStatisticsKHR")]
        static abstract Result GetPipelineExecutableStatisticsKHR(
            DeviceHandle device,
            PipelineExecutableInfoKHR* pExecutableInfo,
            uint* pStatisticCount,
            PipelineExecutableStatisticKHR* pStatistics
        );

        [NativeName("vkGetPipelineExecutableStatisticsKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPipelineExecutableStatisticsKHR")]
        static abstract Result GetPipelineExecutableStatisticsKHR(
            DeviceHandle device,
            Ref<PipelineExecutableInfoKHR> pExecutableInfo,
            Ref<uint> pStatisticCount,
            Ref<PipelineExecutableStatisticKHR> pStatistics
        );

        [NativeName("vkGetPipelineIndirectDeviceAddressNV")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPipelineIndirectDeviceAddressNV")]
        static abstract ulong GetPipelineIndirectDeviceAddressNV(
            DeviceHandle device,
            PipelineIndirectDeviceAddressInfoNV* pInfo
        );

        [NativeName("vkGetPipelineIndirectDeviceAddressNV")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPipelineIndirectDeviceAddressNV")]
        static abstract ulong GetPipelineIndirectDeviceAddressNV(
            DeviceHandle device,
            Ref<PipelineIndirectDeviceAddressInfoNV> pInfo
        );

        [NativeName("vkGetPipelineIndirectMemoryRequirementsNV")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPipelineIndirectMemoryRequirementsNV")]
        static abstract void GetPipelineIndirectMemoryRequirementsNV(
            DeviceHandle device,
            ComputePipelineCreateInfo* pCreateInfo,
            MemoryRequirements2* pMemoryRequirements
        );

        [NativeName("vkGetPipelineIndirectMemoryRequirementsNV")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPipelineIndirectMemoryRequirementsNV")]
        static abstract void GetPipelineIndirectMemoryRequirementsNV(
            DeviceHandle device,
            Ref<ComputePipelineCreateInfo> pCreateInfo,
            Ref<MemoryRequirements2> pMemoryRequirements
        );

        [NativeName("vkGetPipelineKeyKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPipelineKeyKHR")]
        static abstract Result GetPipelineKeyKHR(
            DeviceHandle device,
            PipelineCreateInfoKHR* pPipelineCreateInfo,
            PipelineBinaryKeyKHR* pPipelineKey
        );

        [NativeName("vkGetPipelineKeyKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPipelineKeyKHR")]
        static abstract Result GetPipelineKeyKHR(
            DeviceHandle device,
            Ref<PipelineCreateInfoKHR> pPipelineCreateInfo,
            Ref<PipelineBinaryKeyKHR> pPipelineKey
        );

        [NativeName("vkGetPipelinePropertiesEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPipelinePropertiesEXT")]
        static abstract Result GetPipelinePropertiesEXT(
            DeviceHandle device,
            PipelineInfoKHR* pPipelineInfo,
            BaseOutStructure* pPipelineProperties
        );

        [NativeName("vkGetPipelinePropertiesEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPipelinePropertiesEXT")]
        static abstract Result GetPipelinePropertiesEXT(
            DeviceHandle device,
            Ref<PipelineInfoKHR> pPipelineInfo,
            Ref<BaseOutStructure> pPipelineProperties
        );

        [NativeName("vkGetPrivateData")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPrivateData")]
        static abstract void GetPrivateData(
            DeviceHandle device,
            ObjectType objectType,
            ulong objectHandle,
            PrivateDataSlotHandle privateDataSlot,
            ulong* pData
        );

        [NativeName("vkGetPrivateData")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPrivateData")]
        static abstract void GetPrivateData(
            DeviceHandle device,
            ObjectType objectType,
            ulong objectHandle,
            PrivateDataSlotHandle privateDataSlot,
            Ref<ulong> pData
        );

        [NativeName("vkGetPrivateDataEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPrivateDataEXT")]
        static abstract void GetPrivateDataEXT(
            DeviceHandle device,
            ObjectType objectType,
            ulong objectHandle,
            PrivateDataSlotHandle privateDataSlot,
            ulong* pData
        );

        [NativeName("vkGetPrivateDataEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetPrivateDataEXT")]
        static abstract void GetPrivateDataEXT(
            DeviceHandle device,
            ObjectType objectType,
            ulong objectHandle,
            PrivateDataSlotHandle privateDataSlot,
            Ref<ulong> pData
        );

        [NativeName("vkGetQueryPoolResults")]
        [NativeFunction("vulkan", EntryPoint = "vkGetQueryPoolResults")]
        static abstract Result GetQueryPoolResults(
            DeviceHandle device,
            QueryPoolHandle queryPool,
            uint firstQuery,
            uint queryCount,
            nuint dataSize,
            void* pData,
            ulong stride,
            QueryResultFlags flags
        );

        [NativeName("vkGetQueryPoolResults")]
        [NativeFunction("vulkan", EntryPoint = "vkGetQueryPoolResults")]
        static abstract Result GetQueryPoolResults(
            DeviceHandle device,
            QueryPoolHandle queryPool,
            uint firstQuery,
            uint queryCount,
            nuint dataSize,
            Ref pData,
            ulong stride,
            QueryResultFlags flags
        );

        [NativeName("vkGetQueueCheckpointData2NV")]
        [NativeFunction("vulkan", EntryPoint = "vkGetQueueCheckpointData2NV")]
        static abstract void GetQueueCheckpointData2NV(
            QueueHandle queue,
            uint* pCheckpointDataCount,
            CheckpointData2NV* pCheckpointData
        );

        [NativeName("vkGetQueueCheckpointData2NV")]
        [NativeFunction("vulkan", EntryPoint = "vkGetQueueCheckpointData2NV")]
        static abstract void GetQueueCheckpointData2NV(
            QueueHandle queue,
            Ref<uint> pCheckpointDataCount,
            Ref<CheckpointData2NV> pCheckpointData
        );

        [NativeName("vkGetQueueCheckpointDataNV")]
        [NativeFunction("vulkan", EntryPoint = "vkGetQueueCheckpointDataNV")]
        static abstract void GetQueueCheckpointDataNV(
            QueueHandle queue,
            uint* pCheckpointDataCount,
            CheckpointDataNV* pCheckpointData
        );

        [NativeName("vkGetQueueCheckpointDataNV")]
        [NativeFunction("vulkan", EntryPoint = "vkGetQueueCheckpointDataNV")]
        static abstract void GetQueueCheckpointDataNV(
            QueueHandle queue,
            Ref<uint> pCheckpointDataCount,
            Ref<CheckpointDataNV> pCheckpointData
        );

        [NativeName("vkGetRayTracingCaptureReplayShaderGroupHandlesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetRayTracingCaptureReplayShaderGroupHandlesKHR")]
        static abstract Result GetRayTracingCaptureReplayShaderGroupHandlesKHR(
            DeviceHandle device,
            PipelineHandle pipeline,
            uint firstGroup,
            uint groupCount,
            nuint dataSize,
            void* pData
        );

        [NativeName("vkGetRayTracingCaptureReplayShaderGroupHandlesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetRayTracingCaptureReplayShaderGroupHandlesKHR")]
        static abstract Result GetRayTracingCaptureReplayShaderGroupHandlesKHR(
            DeviceHandle device,
            PipelineHandle pipeline,
            uint firstGroup,
            uint groupCount,
            nuint dataSize,
            Ref pData
        );

        [NativeName("vkGetRayTracingShaderGroupHandlesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetRayTracingShaderGroupHandlesKHR")]
        static abstract Result GetRayTracingShaderGroupHandlesKHR(
            DeviceHandle device,
            PipelineHandle pipeline,
            uint firstGroup,
            uint groupCount,
            nuint dataSize,
            void* pData
        );

        [NativeName("vkGetRayTracingShaderGroupHandlesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetRayTracingShaderGroupHandlesKHR")]
        static abstract Result GetRayTracingShaderGroupHandlesKHR(
            DeviceHandle device,
            PipelineHandle pipeline,
            uint firstGroup,
            uint groupCount,
            nuint dataSize,
            Ref pData
        );

        [NativeName("vkGetRayTracingShaderGroupHandlesNV")]
        [NativeFunction("vulkan", EntryPoint = "vkGetRayTracingShaderGroupHandlesNV")]
        static abstract Result GetRayTracingShaderGroupHandlesNV(
            DeviceHandle device,
            PipelineHandle pipeline,
            uint firstGroup,
            uint groupCount,
            nuint dataSize,
            void* pData
        );

        [NativeName("vkGetRayTracingShaderGroupHandlesNV")]
        [NativeFunction("vulkan", EntryPoint = "vkGetRayTracingShaderGroupHandlesNV")]
        static abstract Result GetRayTracingShaderGroupHandlesNV(
            DeviceHandle device,
            PipelineHandle pipeline,
            uint firstGroup,
            uint groupCount,
            nuint dataSize,
            Ref pData
        );

        [NativeName("vkGetRayTracingShaderGroupStackSizeKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetRayTracingShaderGroupStackSizeKHR")]
        static abstract ulong GetRayTracingShaderGroupStackSizeKHR(
            DeviceHandle device,
            PipelineHandle pipeline,
            uint group,
            ShaderGroupShaderKHR groupShader
        );

        [NativeName("vkGetRefreshCycleDurationGOOGLE")]
        [NativeFunction("vulkan", EntryPoint = "vkGetRefreshCycleDurationGOOGLE")]
        static abstract Result GetRefreshCycleDurationGOOGLE(
            DeviceHandle device,
            SwapchainHandleKHR swapchain,
            RefreshCycleDurationGOOGLE* pDisplayTimingProperties
        );

        [NativeName("vkGetRefreshCycleDurationGOOGLE")]
        [NativeFunction("vulkan", EntryPoint = "vkGetRefreshCycleDurationGOOGLE")]
        static abstract Result GetRefreshCycleDurationGOOGLE(
            DeviceHandle device,
            SwapchainHandleKHR swapchain,
            Ref<RefreshCycleDurationGOOGLE> pDisplayTimingProperties
        );

        [NativeName("vkGetRenderAreaGranularity")]
        [NativeFunction("vulkan", EntryPoint = "vkGetRenderAreaGranularity")]
        static abstract void GetRenderAreaGranularity(
            DeviceHandle device,
            RenderPassHandle renderPass,
            Extent2D* pGranularity
        );

        [NativeName("vkGetRenderAreaGranularity")]
        [NativeFunction("vulkan", EntryPoint = "vkGetRenderAreaGranularity")]
        static abstract void GetRenderAreaGranularity(
            DeviceHandle device,
            RenderPassHandle renderPass,
            Ref<Extent2D> pGranularity
        );

        [NativeName("vkGetRenderingAreaGranularity")]
        [NativeFunction("vulkan", EntryPoint = "vkGetRenderingAreaGranularity")]
        static abstract void GetRenderingAreaGranularity(
            DeviceHandle device,
            RenderingAreaInfo* pRenderingAreaInfo,
            Extent2D* pGranularity
        );

        [NativeName("vkGetRenderingAreaGranularity")]
        [NativeFunction("vulkan", EntryPoint = "vkGetRenderingAreaGranularity")]
        static abstract void GetRenderingAreaGranularity(
            DeviceHandle device,
            Ref<RenderingAreaInfo> pRenderingAreaInfo,
            Ref<Extent2D> pGranularity
        );

        [NativeName("vkGetRenderingAreaGranularityKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetRenderingAreaGranularityKHR")]
        static abstract void GetRenderingAreaGranularityKHR(
            DeviceHandle device,
            RenderingAreaInfo* pRenderingAreaInfo,
            Extent2D* pGranularity
        );

        [NativeName("vkGetRenderingAreaGranularityKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetRenderingAreaGranularityKHR")]
        static abstract void GetRenderingAreaGranularityKHR(
            DeviceHandle device,
            Ref<RenderingAreaInfo> pRenderingAreaInfo,
            Ref<Extent2D> pGranularity
        );

        [NativeName("vkGetSamplerOpaqueCaptureDescriptorDataEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetSamplerOpaqueCaptureDescriptorDataEXT")]
        static abstract Result GetSamplerOpaqueCaptureDescriptorDataEXT(
            DeviceHandle device,
            SamplerCaptureDescriptorDataInfoEXT* pInfo,
            void* pData
        );

        [NativeName("vkGetSamplerOpaqueCaptureDescriptorDataEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetSamplerOpaqueCaptureDescriptorDataEXT")]
        static abstract Result GetSamplerOpaqueCaptureDescriptorDataEXT(
            DeviceHandle device,
            Ref<SamplerCaptureDescriptorDataInfoEXT> pInfo,
            Ref pData
        );

        [NativeName("vkGetSemaphoreCounterValue")]
        [NativeFunction("vulkan", EntryPoint = "vkGetSemaphoreCounterValue")]
        static abstract Result GetSemaphoreCounterValue(
            DeviceHandle device,
            SemaphoreHandle semaphore,
            ulong* pValue
        );

        [NativeName("vkGetSemaphoreCounterValue")]
        [NativeFunction("vulkan", EntryPoint = "vkGetSemaphoreCounterValue")]
        static abstract Result GetSemaphoreCounterValue(
            DeviceHandle device,
            SemaphoreHandle semaphore,
            Ref<ulong> pValue
        );

        [NativeName("vkGetSemaphoreCounterValueKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetSemaphoreCounterValueKHR")]
        static abstract Result GetSemaphoreCounterValueKHR(
            DeviceHandle device,
            SemaphoreHandle semaphore,
            ulong* pValue
        );

        [NativeName("vkGetSemaphoreCounterValueKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetSemaphoreCounterValueKHR")]
        static abstract Result GetSemaphoreCounterValueKHR(
            DeviceHandle device,
            SemaphoreHandle semaphore,
            Ref<ulong> pValue
        );

        [NativeName("vkGetSemaphoreFdKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetSemaphoreFdKHR")]
        static abstract Result GetSemaphoreFdKHR(
            DeviceHandle device,
            SemaphoreGetFdInfoKHR* pGetFdInfo,
            int* pFd
        );

        [NativeName("vkGetSemaphoreFdKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetSemaphoreFdKHR")]
        static abstract Result GetSemaphoreFdKHR(
            DeviceHandle device,
            Ref<SemaphoreGetFdInfoKHR> pGetFdInfo,
            Ref<int> pFd
        );

        [NativeName("vkGetShaderBinaryDataEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetShaderBinaryDataEXT")]
        static abstract Result GetShaderBinaryDataEXT(
            DeviceHandle device,
            ShaderHandleEXT shader,
            nuint* pDataSize,
            void* pData
        );

        [NativeName("vkGetShaderBinaryDataEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetShaderBinaryDataEXT")]
        static abstract Result GetShaderBinaryDataEXT(
            DeviceHandle device,
            ShaderHandleEXT shader,
            Ref<nuint> pDataSize,
            Ref pData
        );

        [NativeName("vkGetShaderInfoAMD")]
        [NativeFunction("vulkan", EntryPoint = "vkGetShaderInfoAMD")]
        static abstract Result GetShaderInfoAMD(
            DeviceHandle device,
            PipelineHandle pipeline,
            ShaderStageFlags shaderStage,
            ShaderInfoTypeAMD infoType,
            nuint* pInfoSize,
            void* pInfo
        );

        [NativeName("vkGetShaderInfoAMD")]
        [NativeFunction("vulkan", EntryPoint = "vkGetShaderInfoAMD")]
        static abstract Result GetShaderInfoAMD(
            DeviceHandle device,
            PipelineHandle pipeline,
            ShaderStageFlags shaderStage,
            ShaderInfoTypeAMD infoType,
            Ref<nuint> pInfoSize,
            Ref pInfo
        );

        [NativeName("vkGetShaderInstrumentationValuesARM")]
        [NativeFunction("vulkan", EntryPoint = "vkGetShaderInstrumentationValuesARM")]
        static abstract Result GetShaderInstrumentationValuesARM(
            DeviceHandle device,
            ShaderInstrumentationHandleARM instrumentation,
            uint* pMetricBlockCount,
            void* pMetricValues,
            uint flags
        );

        [NativeName("vkGetShaderInstrumentationValuesARM")]
        [NativeFunction("vulkan", EntryPoint = "vkGetShaderInstrumentationValuesARM")]
        static abstract Result GetShaderInstrumentationValuesARM(
            DeviceHandle device,
            ShaderInstrumentationHandleARM instrumentation,
            Ref<uint> pMetricBlockCount,
            Ref pMetricValues,
            uint flags
        );

        [NativeName("vkGetShaderModuleCreateInfoIdentifierEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetShaderModuleCreateInfoIdentifierEXT")]
        static abstract void GetShaderModuleCreateInfoIdentifierEXT(
            DeviceHandle device,
            ShaderModuleCreateInfo* pCreateInfo,
            ShaderModuleIdentifierEXT* pIdentifier
        );

        [NativeName("vkGetShaderModuleCreateInfoIdentifierEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetShaderModuleCreateInfoIdentifierEXT")]
        static abstract void GetShaderModuleCreateInfoIdentifierEXT(
            DeviceHandle device,
            Ref<ShaderModuleCreateInfo> pCreateInfo,
            Ref<ShaderModuleIdentifierEXT> pIdentifier
        );

        [NativeName("vkGetShaderModuleIdentifierEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetShaderModuleIdentifierEXT")]
        static abstract void GetShaderModuleIdentifierEXT(
            DeviceHandle device,
            ShaderModuleHandle shaderModule,
            ShaderModuleIdentifierEXT* pIdentifier
        );

        [NativeName("vkGetShaderModuleIdentifierEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetShaderModuleIdentifierEXT")]
        static abstract void GetShaderModuleIdentifierEXT(
            DeviceHandle device,
            ShaderModuleHandle shaderModule,
            Ref<ShaderModuleIdentifierEXT> pIdentifier
        );

        [NativeName("vkGetSwapchainCounterEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetSwapchainCounterEXT")]
        static abstract Result GetSwapchainCounterEXT(
            DeviceHandle device,
            SwapchainHandleKHR swapchain,
            SurfaceCounterFlagsEXT counter,
            ulong* pCounterValue
        );

        [NativeName("vkGetSwapchainCounterEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetSwapchainCounterEXT")]
        static abstract Result GetSwapchainCounterEXT(
            DeviceHandle device,
            SwapchainHandleKHR swapchain,
            SurfaceCounterFlagsEXT counter,
            Ref<ulong> pCounterValue
        );

        [NativeName("vkGetSwapchainImagesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetSwapchainImagesKHR")]
        static abstract Result GetSwapchainImagesKHR(
            DeviceHandle device,
            SwapchainHandleKHR swapchain,
            uint* pSwapchainImageCount,
            ImageHandle* pSwapchainImages
        );

        [NativeName("vkGetSwapchainImagesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetSwapchainImagesKHR")]
        static abstract Result GetSwapchainImagesKHR(
            DeviceHandle device,
            SwapchainHandleKHR swapchain,
            Ref<uint> pSwapchainImageCount,
            Ref<ImageHandle> pSwapchainImages
        );

        [NativeName("vkGetSwapchainStatusKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetSwapchainStatusKHR")]
        static abstract Result GetSwapchainStatusKHR(
            DeviceHandle device,
            SwapchainHandleKHR swapchain
        );

        [NativeName("vkGetSwapchainTimeDomainPropertiesEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetSwapchainTimeDomainPropertiesEXT")]
        static abstract Result GetSwapchainTimeDomainPropertiesEXT(
            DeviceHandle device,
            SwapchainHandleKHR swapchain,
            SwapchainTimeDomainPropertiesEXT* pSwapchainTimeDomainProperties,
            ulong* pTimeDomainsCounter
        );

        [NativeName("vkGetSwapchainTimeDomainPropertiesEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetSwapchainTimeDomainPropertiesEXT")]
        static abstract Result GetSwapchainTimeDomainPropertiesEXT(
            DeviceHandle device,
            SwapchainHandleKHR swapchain,
            Ref<SwapchainTimeDomainPropertiesEXT> pSwapchainTimeDomainProperties,
            Ref<ulong> pTimeDomainsCounter
        );

        [NativeName("vkGetSwapchainTimingPropertiesEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetSwapchainTimingPropertiesEXT")]
        static abstract Result GetSwapchainTimingPropertiesEXT(
            DeviceHandle device,
            SwapchainHandleKHR swapchain,
            SwapchainTimingPropertiesEXT* pSwapchainTimingProperties,
            ulong* pSwapchainTimingPropertiesCounter
        );

        [NativeName("vkGetSwapchainTimingPropertiesEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetSwapchainTimingPropertiesEXT")]
        static abstract Result GetSwapchainTimingPropertiesEXT(
            DeviceHandle device,
            SwapchainHandleKHR swapchain,
            Ref<SwapchainTimingPropertiesEXT> pSwapchainTimingProperties,
            Ref<ulong> pSwapchainTimingPropertiesCounter
        );

        [NativeName("vkGetTensorMemoryRequirementsARM")]
        [NativeFunction("vulkan", EntryPoint = "vkGetTensorMemoryRequirementsARM")]
        static abstract void GetTensorMemoryRequirementsARM(
            DeviceHandle device,
            TensorMemoryRequirementsInfoARM* pInfo,
            MemoryRequirements2* pMemoryRequirements
        );

        [NativeName("vkGetTensorMemoryRequirementsARM")]
        [NativeFunction("vulkan", EntryPoint = "vkGetTensorMemoryRequirementsARM")]
        static abstract void GetTensorMemoryRequirementsARM(
            DeviceHandle device,
            Ref<TensorMemoryRequirementsInfoARM> pInfo,
            Ref<MemoryRequirements2> pMemoryRequirements
        );

        [NativeName("vkGetTensorOpaqueCaptureDataARM")]
        [NativeFunction("vulkan", EntryPoint = "vkGetTensorOpaqueCaptureDataARM")]
        static abstract Result GetTensorOpaqueCaptureDataARM(
            DeviceHandle device,
            uint tensorCount,
            TensorHandleARM* pTensors,
            HostAddressRangeEXT* pDatas
        );

        [NativeName("vkGetTensorOpaqueCaptureDataARM")]
        [NativeFunction("vulkan", EntryPoint = "vkGetTensorOpaqueCaptureDataARM")]
        static abstract Result GetTensorOpaqueCaptureDataARM(
            DeviceHandle device,
            uint tensorCount,
            Ref<TensorHandleARM> pTensors,
            Ref<HostAddressRangeEXT> pDatas
        );

        [NativeName("vkGetTensorOpaqueCaptureDescriptorDataARM")]
        [NativeFunction("vulkan", EntryPoint = "vkGetTensorOpaqueCaptureDescriptorDataARM")]
        static abstract Result GetTensorOpaqueCaptureDescriptorDataARM(
            DeviceHandle device,
            TensorCaptureDescriptorDataInfoARM* pInfo,
            void* pData
        );

        [NativeName("vkGetTensorOpaqueCaptureDescriptorDataARM")]
        [NativeFunction("vulkan", EntryPoint = "vkGetTensorOpaqueCaptureDescriptorDataARM")]
        static abstract Result GetTensorOpaqueCaptureDescriptorDataARM(
            DeviceHandle device,
            Ref<TensorCaptureDescriptorDataInfoARM> pInfo,
            Ref pData
        );

        [NativeName("vkGetTensorViewOpaqueCaptureDescriptorDataARM")]
        [NativeFunction("vulkan", EntryPoint = "vkGetTensorViewOpaqueCaptureDescriptorDataARM")]
        static abstract Result GetTensorViewOpaqueCaptureDescriptorDataARM(
            DeviceHandle device,
            TensorViewCaptureDescriptorDataInfoARM* pInfo,
            void* pData
        );

        [NativeName("vkGetTensorViewOpaqueCaptureDescriptorDataARM")]
        [NativeFunction("vulkan", EntryPoint = "vkGetTensorViewOpaqueCaptureDescriptorDataARM")]
        static abstract Result GetTensorViewOpaqueCaptureDescriptorDataARM(
            DeviceHandle device,
            Ref<TensorViewCaptureDescriptorDataInfoARM> pInfo,
            Ref pData
        );

        [NativeName("vkGetValidationCacheDataEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetValidationCacheDataEXT")]
        static abstract Result GetValidationCacheDataEXT(
            DeviceHandle device,
            ValidationCacheHandleEXT validationCache,
            nuint* pDataSize,
            void* pData
        );

        [NativeName("vkGetValidationCacheDataEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkGetValidationCacheDataEXT")]
        static abstract Result GetValidationCacheDataEXT(
            DeviceHandle device,
            ValidationCacheHandleEXT validationCache,
            Ref<nuint> pDataSize,
            Ref pData
        );

        [NativeName("vkGetVideoSessionMemoryRequirementsKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetVideoSessionMemoryRequirementsKHR")]
        static abstract Result GetVideoSessionMemoryRequirementsKHR(
            DeviceHandle device,
            VideoSessionHandleKHR videoSession,
            uint* pMemoryRequirementsCount,
            VideoSessionMemoryRequirementsKHR* pMemoryRequirements
        );

        [NativeName("vkGetVideoSessionMemoryRequirementsKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkGetVideoSessionMemoryRequirementsKHR")]
        static abstract Result GetVideoSessionMemoryRequirementsKHR(
            DeviceHandle device,
            VideoSessionHandleKHR videoSession,
            Ref<uint> pMemoryRequirementsCount,
            Ref<VideoSessionMemoryRequirementsKHR> pMemoryRequirements
        );

        [NativeName("vkImportFenceFdKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkImportFenceFdKHR")]
        static abstract Result ImportFenceFdKHR(
            DeviceHandle device,
            ImportFenceFdInfoKHR* pImportFenceFdInfo
        );

        [NativeName("vkImportFenceFdKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkImportFenceFdKHR")]
        static abstract Result ImportFenceFdKHR(
            DeviceHandle device,
            Ref<ImportFenceFdInfoKHR> pImportFenceFdInfo
        );

        [NativeName("vkImportSemaphoreFdKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkImportSemaphoreFdKHR")]
        static abstract Result ImportSemaphoreFdKHR(
            DeviceHandle device,
            ImportSemaphoreFdInfoKHR* pImportSemaphoreFdInfo
        );

        [NativeName("vkImportSemaphoreFdKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkImportSemaphoreFdKHR")]
        static abstract Result ImportSemaphoreFdKHR(
            DeviceHandle device,
            Ref<ImportSemaphoreFdInfoKHR> pImportSemaphoreFdInfo
        );

        [NativeName("vkInitializePerformanceApiINTEL")]
        [NativeFunction("vulkan", EntryPoint = "vkInitializePerformanceApiINTEL")]
        static abstract Result InitializePerformanceApiINTEL(
            DeviceHandle device,
            InitializePerformanceApiInfoINTEL* pInitializeInfo
        );

        [NativeName("vkInitializePerformanceApiINTEL")]
        [NativeFunction("vulkan", EntryPoint = "vkInitializePerformanceApiINTEL")]
        static abstract Result InitializePerformanceApiINTEL(
            DeviceHandle device,
            Ref<InitializePerformanceApiInfoINTEL> pInitializeInfo
        );

        [NativeName("vkInvalidateMappedMemoryRanges")]
        [NativeFunction("vulkan", EntryPoint = "vkInvalidateMappedMemoryRanges")]
        static abstract Result InvalidateMappedMemoryRanges(
            DeviceHandle device,
            uint memoryRangeCount,
            MappedMemoryRange* pMemoryRanges
        );

        [NativeName("vkInvalidateMappedMemoryRanges")]
        [NativeFunction("vulkan", EntryPoint = "vkInvalidateMappedMemoryRanges")]
        static abstract Result InvalidateMappedMemoryRanges(
            DeviceHandle device,
            uint memoryRangeCount,
            Ref<MappedMemoryRange> pMemoryRanges
        );

        [NativeName("vkLatencySleepNV")]
        [NativeFunction("vulkan", EntryPoint = "vkLatencySleepNV")]
        static abstract Result LatencySleepNV(
            DeviceHandle device,
            SwapchainHandleKHR swapchain,
            LatencySleepInfoNV* pSleepInfo
        );

        [NativeName("vkLatencySleepNV")]
        [NativeFunction("vulkan", EntryPoint = "vkLatencySleepNV")]
        static abstract Result LatencySleepNV(
            DeviceHandle device,
            SwapchainHandleKHR swapchain,
            Ref<LatencySleepInfoNV> pSleepInfo
        );

        [NativeName("vkMapMemory")]
        [NativeFunction("vulkan", EntryPoint = "vkMapMemory")]
        static abstract Result MapMemory(
            DeviceHandle device,
            DeviceMemoryHandle memory,
            ulong offset,
            ulong size,
            MemoryMapFlags flags,
            void** ppData
        );

        [NativeName("vkMapMemory")]
        [NativeFunction("vulkan", EntryPoint = "vkMapMemory")]
        static abstract Result MapMemory(
            DeviceHandle device,
            DeviceMemoryHandle memory,
            ulong offset,
            ulong size,
            MemoryMapFlags flags,
            Ref2D ppData
        );

        [NativeName("vkMapMemory2")]
        [NativeFunction("vulkan", EntryPoint = "vkMapMemory2")]
        static abstract Result MapMemory2(
            DeviceHandle device,
            MemoryMapInfo* pMemoryMapInfo,
            void** ppData
        );

        [NativeName("vkMapMemory2")]
        [NativeFunction("vulkan", EntryPoint = "vkMapMemory2")]
        static abstract Result MapMemory2(
            DeviceHandle device,
            Ref<MemoryMapInfo> pMemoryMapInfo,
            Ref2D ppData
        );

        [NativeName("vkMapMemory2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkMapMemory2KHR")]
        static abstract Result MapMemory2KHR(
            DeviceHandle device,
            MemoryMapInfo* pMemoryMapInfo,
            void** ppData
        );

        [NativeName("vkMapMemory2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkMapMemory2KHR")]
        static abstract Result MapMemory2KHR(
            DeviceHandle device,
            Ref<MemoryMapInfo> pMemoryMapInfo,
            Ref2D ppData
        );

        [NativeName("vkMergePipelineCaches")]
        [NativeFunction("vulkan", EntryPoint = "vkMergePipelineCaches")]
        static abstract Result MergePipelineCaches(
            DeviceHandle device,
            PipelineCacheHandle dstCache,
            uint srcCacheCount,
            PipelineCacheHandle* pSrcCaches
        );

        [NativeName("vkMergePipelineCaches")]
        [NativeFunction("vulkan", EntryPoint = "vkMergePipelineCaches")]
        static abstract Result MergePipelineCaches(
            DeviceHandle device,
            PipelineCacheHandle dstCache,
            uint srcCacheCount,
            Ref<PipelineCacheHandle> pSrcCaches
        );

        [NativeName("vkMergeValidationCachesEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkMergeValidationCachesEXT")]
        static abstract Result MergeValidationCachesEXT(
            DeviceHandle device,
            ValidationCacheHandleEXT dstCache,
            uint srcCacheCount,
            ValidationCacheHandleEXT* pSrcCaches
        );

        [NativeName("vkMergeValidationCachesEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkMergeValidationCachesEXT")]
        static abstract Result MergeValidationCachesEXT(
            DeviceHandle device,
            ValidationCacheHandleEXT dstCache,
            uint srcCacheCount,
            Ref<ValidationCacheHandleEXT> pSrcCaches
        );

        [NativeName("vkQueueBeginDebugUtilsLabelEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkQueueBeginDebugUtilsLabelEXT")]
        static abstract void QueueBeginDebugUtilsLabelEXT(
            QueueHandle queue,
            DebugUtilsLabelEXT* pLabelInfo
        );

        [NativeName("vkQueueBeginDebugUtilsLabelEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkQueueBeginDebugUtilsLabelEXT")]
        static abstract void QueueBeginDebugUtilsLabelEXT(
            QueueHandle queue,
            Ref<DebugUtilsLabelEXT> pLabelInfo
        );

        [NativeName("vkQueueBindSparse")]
        [NativeFunction("vulkan", EntryPoint = "vkQueueBindSparse")]
        static abstract Result QueueBindSparse(
            QueueHandle queue,
            uint bindInfoCount,
            BindSparseInfo* pBindInfo,
            FenceHandle fence
        );

        [NativeName("vkQueueBindSparse")]
        [NativeFunction("vulkan", EntryPoint = "vkQueueBindSparse")]
        static abstract Result QueueBindSparse(
            QueueHandle queue,
            uint bindInfoCount,
            Ref<BindSparseInfo> pBindInfo,
            FenceHandle fence
        );

        [NativeName("vkQueueEndDebugUtilsLabelEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkQueueEndDebugUtilsLabelEXT")]
        static abstract void QueueEndDebugUtilsLabelEXT(QueueHandle queue);

        [NativeName("vkQueueInsertDebugUtilsLabelEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkQueueInsertDebugUtilsLabelEXT")]
        static abstract void QueueInsertDebugUtilsLabelEXT(
            QueueHandle queue,
            DebugUtilsLabelEXT* pLabelInfo
        );

        [NativeName("vkQueueInsertDebugUtilsLabelEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkQueueInsertDebugUtilsLabelEXT")]
        static abstract void QueueInsertDebugUtilsLabelEXT(
            QueueHandle queue,
            Ref<DebugUtilsLabelEXT> pLabelInfo
        );

        [NativeName("vkQueueNotifyOutOfBandNV")]
        [NativeFunction("vulkan", EntryPoint = "vkQueueNotifyOutOfBandNV")]
        static abstract void QueueNotifyOutOfBandNV(
            QueueHandle queue,
            OutOfBandQueueTypeInfoNV* pQueueTypeInfo
        );

        [NativeName("vkQueueNotifyOutOfBandNV")]
        [NativeFunction("vulkan", EntryPoint = "vkQueueNotifyOutOfBandNV")]
        static abstract void QueueNotifyOutOfBandNV(
            QueueHandle queue,
            Ref<OutOfBandQueueTypeInfoNV> pQueueTypeInfo
        );

        [NativeName("vkQueuePresentKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkQueuePresentKHR")]
        static abstract Result QueuePresentKHR(QueueHandle queue, PresentInfoKHR* pPresentInfo);

        [NativeName("vkQueuePresentKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkQueuePresentKHR")]
        static abstract Result QueuePresentKHR(QueueHandle queue, Ref<PresentInfoKHR> pPresentInfo);

        [NativeName("vkQueueSetPerfHintQCOM")]
        [NativeFunction("vulkan", EntryPoint = "vkQueueSetPerfHintQCOM")]
        static abstract Result QueueSetPerfHintQCOM(
            QueueHandle queue,
            PerfHintInfoQCOM* pPerfHintInfo
        );

        [NativeName("vkQueueSetPerfHintQCOM")]
        [NativeFunction("vulkan", EntryPoint = "vkQueueSetPerfHintQCOM")]
        static abstract Result QueueSetPerfHintQCOM(
            QueueHandle queue,
            Ref<PerfHintInfoQCOM> pPerfHintInfo
        );

        [NativeName("vkQueueSetPerformanceConfigurationINTEL")]
        [NativeFunction("vulkan", EntryPoint = "vkQueueSetPerformanceConfigurationINTEL")]
        static abstract Result QueueSetPerformanceConfigurationINTEL(
            QueueHandle queue,
            PerformanceConfigurationHandleINTEL configuration
        );

        [NativeName("vkQueueSubmit")]
        [NativeFunction("vulkan", EntryPoint = "vkQueueSubmit")]
        static abstract Result QueueSubmit(
            QueueHandle queue,
            uint submitCount,
            SubmitInfo* pSubmits,
            FenceHandle fence
        );

        [NativeName("vkQueueSubmit")]
        [NativeFunction("vulkan", EntryPoint = "vkQueueSubmit")]
        static abstract Result QueueSubmit(
            QueueHandle queue,
            uint submitCount,
            Ref<SubmitInfo> pSubmits,
            FenceHandle fence
        );

        [NativeName("vkQueueSubmit2")]
        [NativeFunction("vulkan", EntryPoint = "vkQueueSubmit2")]
        static abstract Result QueueSubmit2(
            QueueHandle queue,
            uint submitCount,
            SubmitInfo2* pSubmits,
            FenceHandle fence
        );

        [NativeName("vkQueueSubmit2")]
        [NativeFunction("vulkan", EntryPoint = "vkQueueSubmit2")]
        static abstract Result QueueSubmit2(
            QueueHandle queue,
            uint submitCount,
            Ref<SubmitInfo2> pSubmits,
            FenceHandle fence
        );

        [NativeName("vkQueueSubmit2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkQueueSubmit2KHR")]
        static abstract Result QueueSubmit2KHR(
            QueueHandle queue,
            uint submitCount,
            SubmitInfo2* pSubmits,
            FenceHandle fence
        );

        [NativeName("vkQueueSubmit2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkQueueSubmit2KHR")]
        static abstract Result QueueSubmit2KHR(
            QueueHandle queue,
            uint submitCount,
            Ref<SubmitInfo2> pSubmits,
            FenceHandle fence
        );

        [NativeName("vkQueueWaitIdle")]
        [NativeFunction("vulkan", EntryPoint = "vkQueueWaitIdle")]
        static abstract Result QueueWaitIdle(QueueHandle queue);

        [NativeName("vkRegisterCustomBorderColorEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkRegisterCustomBorderColorEXT")]
        static abstract Result RegisterCustomBorderColorEXT(
            DeviceHandle device,
            SamplerCustomBorderColorCreateInfoEXT* pBorderColor,
            uint requestIndex,
            uint* pIndex
        );

        [NativeName("vkRegisterCustomBorderColorEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkRegisterCustomBorderColorEXT")]
        static abstract Result RegisterCustomBorderColorEXT(
            DeviceHandle device,
            Ref<SamplerCustomBorderColorCreateInfoEXT> pBorderColor,
            MaybeBool<uint> requestIndex,
            Ref<uint> pIndex
        );

        [NativeName("vkRegisterDeviceEventEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkRegisterDeviceEventEXT")]
        static abstract Result RegisterDeviceEventEXT(
            DeviceHandle device,
            DeviceEventInfoEXT* pDeviceEventInfo,
            AllocationCallbacks* pAllocator,
            FenceHandle* pFence
        );

        [NativeName("vkRegisterDeviceEventEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkRegisterDeviceEventEXT")]
        static abstract Result RegisterDeviceEventEXT(
            DeviceHandle device,
            Ref<DeviceEventInfoEXT> pDeviceEventInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<FenceHandle> pFence
        );

        [NativeName("vkRegisterDisplayEventEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkRegisterDisplayEventEXT")]
        static abstract Result RegisterDisplayEventEXT(
            DeviceHandle device,
            DisplayHandleKHR display,
            DisplayEventInfoEXT* pDisplayEventInfo,
            AllocationCallbacks* pAllocator,
            FenceHandle* pFence
        );

        [NativeName("vkRegisterDisplayEventEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkRegisterDisplayEventEXT")]
        static abstract Result RegisterDisplayEventEXT(
            DeviceHandle device,
            DisplayHandleKHR display,
            Ref<DisplayEventInfoEXT> pDisplayEventInfo,
            Ref<AllocationCallbacks> pAllocator,
            Ref<FenceHandle> pFence
        );

        [NativeName("vkReleaseCapturedPipelineDataKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkReleaseCapturedPipelineDataKHR")]
        static abstract Result ReleaseCapturedPipelineDataKHR(
            DeviceHandle device,
            ReleaseCapturedPipelineDataInfoKHR* pInfo,
            AllocationCallbacks* pAllocator
        );

        [NativeName("vkReleaseCapturedPipelineDataKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkReleaseCapturedPipelineDataKHR")]
        static abstract Result ReleaseCapturedPipelineDataKHR(
            DeviceHandle device,
            Ref<ReleaseCapturedPipelineDataInfoKHR> pInfo,
            Ref<AllocationCallbacks> pAllocator
        );

        [NativeName("vkReleaseDisplayEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkReleaseDisplayEXT")]
        static abstract Result ReleaseDisplayEXT(
            PhysicalDeviceHandle physicalDevice,
            DisplayHandleKHR display
        );

        [NativeName("vkReleasePerformanceConfigurationINTEL")]
        [NativeFunction("vulkan", EntryPoint = "vkReleasePerformanceConfigurationINTEL")]
        static abstract Result ReleasePerformanceConfigurationINTEL(
            DeviceHandle device,
            PerformanceConfigurationHandleINTEL configuration
        );

        [NativeName("vkReleaseProfilingLockKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkReleaseProfilingLockKHR")]
        static abstract void ReleaseProfilingLockKHR(DeviceHandle device);

        [NativeName("vkReleaseSwapchainImagesEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkReleaseSwapchainImagesEXT")]
        static abstract Result ReleaseSwapchainImagesEXT(
            DeviceHandle device,
            ReleaseSwapchainImagesInfoKHR* pReleaseInfo
        );

        [NativeName("vkReleaseSwapchainImagesEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkReleaseSwapchainImagesEXT")]
        static abstract Result ReleaseSwapchainImagesEXT(
            DeviceHandle device,
            Ref<ReleaseSwapchainImagesInfoKHR> pReleaseInfo
        );

        [NativeName("vkReleaseSwapchainImagesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkReleaseSwapchainImagesKHR")]
        static abstract Result ReleaseSwapchainImagesKHR(
            DeviceHandle device,
            ReleaseSwapchainImagesInfoKHR* pReleaseInfo
        );

        [NativeName("vkReleaseSwapchainImagesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkReleaseSwapchainImagesKHR")]
        static abstract Result ReleaseSwapchainImagesKHR(
            DeviceHandle device,
            Ref<ReleaseSwapchainImagesInfoKHR> pReleaseInfo
        );

        [NativeName("vkResetCommandBuffer")]
        [NativeFunction("vulkan", EntryPoint = "vkResetCommandBuffer")]
        static abstract Result ResetCommandBuffer(
            CommandBufferHandle commandBuffer,
            CommandBufferResetFlags flags
        );

        [NativeName("vkResetCommandPool")]
        [NativeFunction("vulkan", EntryPoint = "vkResetCommandPool")]
        static abstract Result ResetCommandPool(
            DeviceHandle device,
            CommandPoolHandle commandPool,
            CommandPoolResetFlags flags
        );

        [NativeName("vkResetDescriptorPool")]
        [NativeFunction("vulkan", EntryPoint = "vkResetDescriptorPool")]
        static abstract Result ResetDescriptorPool(
            DeviceHandle device,
            DescriptorPoolHandle descriptorPool,
            uint flags
        );

        [NativeName("vkResetEvent")]
        [NativeFunction("vulkan", EntryPoint = "vkResetEvent")]
        static abstract Result ResetEvent(DeviceHandle device, EventHandle @event);

        [NativeName("vkResetFences")]
        [NativeFunction("vulkan", EntryPoint = "vkResetFences")]
        static abstract Result ResetFences(
            DeviceHandle device,
            uint fenceCount,
            FenceHandle* pFences
        );

        [NativeName("vkResetFences")]
        [NativeFunction("vulkan", EntryPoint = "vkResetFences")]
        static abstract Result ResetFences(
            DeviceHandle device,
            uint fenceCount,
            Ref<FenceHandle> pFences
        );

        [NativeName("vkResetGpaSessionAMD")]
        [NativeFunction("vulkan", EntryPoint = "vkResetGpaSessionAMD")]
        static abstract Result ResetGpaSessionAMD(
            DeviceHandle device,
            GpaSessionHandleAMD gpaSession
        );

        [NativeName("vkResetQueryPool")]
        [NativeFunction("vulkan", EntryPoint = "vkResetQueryPool")]
        static abstract void ResetQueryPool(
            DeviceHandle device,
            QueryPoolHandle queryPool,
            uint firstQuery,
            uint queryCount
        );

        [NativeName("vkResetQueryPoolEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkResetQueryPoolEXT")]
        static abstract void ResetQueryPoolEXT(
            DeviceHandle device,
            QueryPoolHandle queryPool,
            uint firstQuery,
            uint queryCount
        );

        [NativeName("vkSetDebugUtilsObjectNameEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkSetDebugUtilsObjectNameEXT")]
        static abstract Result SetDebugUtilsObjectNameEXT(
            DeviceHandle device,
            DebugUtilsObjectNameInfoEXT* pNameInfo
        );

        [NativeName("vkSetDebugUtilsObjectNameEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkSetDebugUtilsObjectNameEXT")]
        static abstract Result SetDebugUtilsObjectNameEXT(
            DeviceHandle device,
            Ref<DebugUtilsObjectNameInfoEXT> pNameInfo
        );

        [NativeName("vkSetDebugUtilsObjectTagEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkSetDebugUtilsObjectTagEXT")]
        static abstract Result SetDebugUtilsObjectTagEXT(
            DeviceHandle device,
            DebugUtilsObjectTagInfoEXT* pTagInfo
        );

        [NativeName("vkSetDebugUtilsObjectTagEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkSetDebugUtilsObjectTagEXT")]
        static abstract Result SetDebugUtilsObjectTagEXT(
            DeviceHandle device,
            Ref<DebugUtilsObjectTagInfoEXT> pTagInfo
        );

        [NativeName("vkSetDeviceMemoryPriorityEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkSetDeviceMemoryPriorityEXT")]
        static abstract void SetDeviceMemoryPriorityEXT(
            DeviceHandle device,
            DeviceMemoryHandle memory,
            float priority
        );

        [NativeName("vkSetEvent")]
        [NativeFunction("vulkan", EntryPoint = "vkSetEvent")]
        static abstract Result SetEvent(DeviceHandle device, EventHandle @event);

        [NativeName("vkSetGpaDeviceClockModeAMD")]
        [NativeFunction("vulkan", EntryPoint = "vkSetGpaDeviceClockModeAMD")]
        static abstract Result SetGpaDeviceClockModeAMD(
            DeviceHandle device,
            GpaDeviceClockModeInfoAMD* pInfo
        );

        [NativeName("vkSetGpaDeviceClockModeAMD")]
        [NativeFunction("vulkan", EntryPoint = "vkSetGpaDeviceClockModeAMD")]
        static abstract Result SetGpaDeviceClockModeAMD(
            DeviceHandle device,
            Ref<GpaDeviceClockModeInfoAMD> pInfo
        );

        [NativeName("vkSetHdrMetadataEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkSetHdrMetadataEXT")]
        static abstract void SetHdrMetadataEXT(
            DeviceHandle device,
            uint swapchainCount,
            SwapchainHandleKHR* pSwapchains,
            HdrMetadataEXT* pMetadata
        );

        [NativeName("vkSetHdrMetadataEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkSetHdrMetadataEXT")]
        static abstract void SetHdrMetadataEXT(
            DeviceHandle device,
            uint swapchainCount,
            Ref<SwapchainHandleKHR> pSwapchains,
            Ref<HdrMetadataEXT> pMetadata
        );

        [NativeName("vkSetLatencyMarkerNV")]
        [NativeFunction("vulkan", EntryPoint = "vkSetLatencyMarkerNV")]
        static abstract void SetLatencyMarkerNV(
            DeviceHandle device,
            SwapchainHandleKHR swapchain,
            SetLatencyMarkerInfoNV* pLatencyMarkerInfo
        );

        [NativeName("vkSetLatencyMarkerNV")]
        [NativeFunction("vulkan", EntryPoint = "vkSetLatencyMarkerNV")]
        static abstract void SetLatencyMarkerNV(
            DeviceHandle device,
            SwapchainHandleKHR swapchain,
            Ref<SetLatencyMarkerInfoNV> pLatencyMarkerInfo
        );

        [NativeName("vkSetLatencySleepModeNV")]
        [NativeFunction("vulkan", EntryPoint = "vkSetLatencySleepModeNV")]
        static abstract Result SetLatencySleepModeNV(
            DeviceHandle device,
            SwapchainHandleKHR swapchain,
            LatencySleepModeInfoNV* pSleepModeInfo
        );

        [NativeName("vkSetLatencySleepModeNV")]
        [NativeFunction("vulkan", EntryPoint = "vkSetLatencySleepModeNV")]
        static abstract Result SetLatencySleepModeNV(
            DeviceHandle device,
            SwapchainHandleKHR swapchain,
            Ref<LatencySleepModeInfoNV> pSleepModeInfo
        );

        [NativeName("vkSetLocalDimmingAMD")]
        [NativeFunction("vulkan", EntryPoint = "vkSetLocalDimmingAMD")]
        static abstract void SetLocalDimmingAMD(
            DeviceHandle device,
            SwapchainHandleKHR swapChain,
            uint localDimmingEnable
        );

        [NativeName("vkSetLocalDimmingAMD")]
        [NativeFunction("vulkan", EntryPoint = "vkSetLocalDimmingAMD")]
        static abstract void SetLocalDimmingAMD(
            DeviceHandle device,
            SwapchainHandleKHR swapChain,
            MaybeBool<uint> localDimmingEnable
        );

        [NativeName("vkSetPrivateData")]
        [NativeFunction("vulkan", EntryPoint = "vkSetPrivateData")]
        static abstract Result SetPrivateData(
            DeviceHandle device,
            ObjectType objectType,
            ulong objectHandle,
            PrivateDataSlotHandle privateDataSlot,
            ulong data
        );

        [NativeName("vkSetPrivateDataEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkSetPrivateDataEXT")]
        static abstract Result SetPrivateDataEXT(
            DeviceHandle device,
            ObjectType objectType,
            ulong objectHandle,
            PrivateDataSlotHandle privateDataSlot,
            ulong data
        );

        [NativeName("vkSetSwapchainPresentTimingQueueSizeEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkSetSwapchainPresentTimingQueueSizeEXT")]
        static abstract Result SetSwapchainPresentTimingQueueSizeEXT(
            DeviceHandle device,
            SwapchainHandleKHR swapchain,
            uint size
        );

        [NativeName("vkSignalSemaphore")]
        [NativeFunction("vulkan", EntryPoint = "vkSignalSemaphore")]
        static abstract Result SignalSemaphore(
            DeviceHandle device,
            SemaphoreSignalInfo* pSignalInfo
        );

        [NativeName("vkSignalSemaphore")]
        [NativeFunction("vulkan", EntryPoint = "vkSignalSemaphore")]
        static abstract Result SignalSemaphore(
            DeviceHandle device,
            Ref<SemaphoreSignalInfo> pSignalInfo
        );

        [NativeName("vkSignalSemaphoreKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkSignalSemaphoreKHR")]
        static abstract Result SignalSemaphoreKHR(
            DeviceHandle device,
            SemaphoreSignalInfo* pSignalInfo
        );

        [NativeName("vkSignalSemaphoreKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkSignalSemaphoreKHR")]
        static abstract Result SignalSemaphoreKHR(
            DeviceHandle device,
            Ref<SemaphoreSignalInfo> pSignalInfo
        );

        [NativeName("vkSubmitDebugUtilsMessageEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkSubmitDebugUtilsMessageEXT")]
        static abstract void SubmitDebugUtilsMessageEXT(
            InstanceHandle instance,
            DebugUtilsMessageSeverityFlagsEXT messageSeverity,
            DebugUtilsMessageTypeFlagsEXT messageTypes,
            DebugUtilsMessengerCallbackDataEXT* pCallbackData
        );

        [NativeName("vkSubmitDebugUtilsMessageEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkSubmitDebugUtilsMessageEXT")]
        static abstract void SubmitDebugUtilsMessageEXT(
            InstanceHandle instance,
            DebugUtilsMessageSeverityFlagsEXT messageSeverity,
            DebugUtilsMessageTypeFlagsEXT messageTypes,
            Ref<DebugUtilsMessengerCallbackDataEXT> pCallbackData
        );

        [NativeName("vkTransitionImageLayout")]
        [NativeFunction("vulkan", EntryPoint = "vkTransitionImageLayout")]
        static abstract Result TransitionImageLayout(
            DeviceHandle device,
            uint transitionCount,
            HostImageLayoutTransitionInfo* pTransitions
        );

        [NativeName("vkTransitionImageLayout")]
        [NativeFunction("vulkan", EntryPoint = "vkTransitionImageLayout")]
        static abstract Result TransitionImageLayout(
            DeviceHandle device,
            uint transitionCount,
            Ref<HostImageLayoutTransitionInfo> pTransitions
        );

        [NativeName("vkTransitionImageLayoutEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkTransitionImageLayoutEXT")]
        static abstract Result TransitionImageLayoutEXT(
            DeviceHandle device,
            uint transitionCount,
            HostImageLayoutTransitionInfo* pTransitions
        );

        [NativeName("vkTransitionImageLayoutEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkTransitionImageLayoutEXT")]
        static abstract Result TransitionImageLayoutEXT(
            DeviceHandle device,
            uint transitionCount,
            Ref<HostImageLayoutTransitionInfo> pTransitions
        );

        [NativeName("vkTrimCommandPool")]
        [NativeFunction("vulkan", EntryPoint = "vkTrimCommandPool")]
        static abstract void TrimCommandPool(
            DeviceHandle device,
            CommandPoolHandle commandPool,
            uint flags
        );

        [NativeName("vkTrimCommandPoolKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkTrimCommandPoolKHR")]
        static abstract void TrimCommandPoolKHR(
            DeviceHandle device,
            CommandPoolHandle commandPool,
            uint flags
        );

        [NativeName("vkUninitializePerformanceApiINTEL")]
        [NativeFunction("vulkan", EntryPoint = "vkUninitializePerformanceApiINTEL")]
        static abstract void UninitializePerformanceApiINTEL(DeviceHandle device);

        [NativeName("vkUnmapMemory")]
        [NativeFunction("vulkan", EntryPoint = "vkUnmapMemory")]
        static abstract void UnmapMemory(DeviceHandle device, DeviceMemoryHandle memory);

        [NativeName("vkUnmapMemory2")]
        [NativeFunction("vulkan", EntryPoint = "vkUnmapMemory2")]
        static abstract Result UnmapMemory2(DeviceHandle device, MemoryUnmapInfo* pMemoryUnmapInfo);

        [NativeName("vkUnmapMemory2")]
        [NativeFunction("vulkan", EntryPoint = "vkUnmapMemory2")]
        static abstract Result UnmapMemory2(
            DeviceHandle device,
            Ref<MemoryUnmapInfo> pMemoryUnmapInfo
        );

        [NativeName("vkUnmapMemory2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkUnmapMemory2KHR")]
        static abstract Result UnmapMemory2KHR(
            DeviceHandle device,
            MemoryUnmapInfo* pMemoryUnmapInfo
        );

        [NativeName("vkUnmapMemory2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkUnmapMemory2KHR")]
        static abstract Result UnmapMemory2KHR(
            DeviceHandle device,
            Ref<MemoryUnmapInfo> pMemoryUnmapInfo
        );

        [NativeName("vkUnregisterCustomBorderColorEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkUnregisterCustomBorderColorEXT")]
        static abstract void UnregisterCustomBorderColorEXT(DeviceHandle device, uint index);

        [NativeName("vkUpdateDescriptorSets")]
        [NativeFunction("vulkan", EntryPoint = "vkUpdateDescriptorSets")]
        static abstract void UpdateDescriptorSets(
            DeviceHandle device,
            uint descriptorWriteCount,
            WriteDescriptorSet* pDescriptorWrites,
            uint descriptorCopyCount,
            CopyDescriptorSet* pDescriptorCopies
        );

        [NativeName("vkUpdateDescriptorSets")]
        [NativeFunction("vulkan", EntryPoint = "vkUpdateDescriptorSets")]
        static abstract void UpdateDescriptorSets(
            DeviceHandle device,
            uint descriptorWriteCount,
            Ref<WriteDescriptorSet> pDescriptorWrites,
            uint descriptorCopyCount,
            Ref<CopyDescriptorSet> pDescriptorCopies
        );

        [NativeName("vkUpdateDescriptorSetWithTemplate")]
        [NativeFunction("vulkan", EntryPoint = "vkUpdateDescriptorSetWithTemplate")]
        static abstract void UpdateDescriptorSetWithTemplate(
            DeviceHandle device,
            DescriptorSetHandle descriptorSet,
            DescriptorUpdateTemplateHandle descriptorUpdateTemplate,
            void* pData
        );

        [NativeName("vkUpdateDescriptorSetWithTemplate")]
        [NativeFunction("vulkan", EntryPoint = "vkUpdateDescriptorSetWithTemplate")]
        static abstract void UpdateDescriptorSetWithTemplate(
            DeviceHandle device,
            DescriptorSetHandle descriptorSet,
            DescriptorUpdateTemplateHandle descriptorUpdateTemplate,
            Ref pData
        );

        [NativeName("vkUpdateDescriptorSetWithTemplateKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkUpdateDescriptorSetWithTemplateKHR")]
        static abstract void UpdateDescriptorSetWithTemplateKHR(
            DeviceHandle device,
            DescriptorSetHandle descriptorSet,
            DescriptorUpdateTemplateHandle descriptorUpdateTemplate,
            void* pData
        );

        [NativeName("vkUpdateDescriptorSetWithTemplateKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkUpdateDescriptorSetWithTemplateKHR")]
        static abstract void UpdateDescriptorSetWithTemplateKHR(
            DeviceHandle device,
            DescriptorSetHandle descriptorSet,
            DescriptorUpdateTemplateHandle descriptorUpdateTemplate,
            Ref pData
        );

        [NativeName("vkUpdateIndirectExecutionSetPipelineEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkUpdateIndirectExecutionSetPipelineEXT")]
        static abstract void UpdateIndirectExecutionSetPipelineEXT(
            DeviceHandle device,
            IndirectExecutionSetHandleEXT indirectExecutionSet,
            uint executionSetWriteCount,
            WriteIndirectExecutionSetPipelineEXT* pExecutionSetWrites
        );

        [NativeName("vkUpdateIndirectExecutionSetPipelineEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkUpdateIndirectExecutionSetPipelineEXT")]
        static abstract void UpdateIndirectExecutionSetPipelineEXT(
            DeviceHandle device,
            IndirectExecutionSetHandleEXT indirectExecutionSet,
            uint executionSetWriteCount,
            Ref<WriteIndirectExecutionSetPipelineEXT> pExecutionSetWrites
        );

        [NativeName("vkUpdateIndirectExecutionSetPipelineEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkUpdateIndirectExecutionSetPipelineEXT")]
        static abstract void UpdateIndirectExecutionSetPipelineEXT(
            DeviceHandle device,
            IndirectExecutionSetHandleEXT indirectExecutionSet,
            WriteIndirectExecutionSetPipelineEXT pExecutionSetWrites
        );

        [NativeName("vkUpdateIndirectExecutionSetShaderEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkUpdateIndirectExecutionSetShaderEXT")]
        static abstract void UpdateIndirectExecutionSetShaderEXT(
            DeviceHandle device,
            IndirectExecutionSetHandleEXT indirectExecutionSet,
            uint executionSetWriteCount,
            WriteIndirectExecutionSetShaderEXT* pExecutionSetWrites
        );

        [NativeName("vkUpdateIndirectExecutionSetShaderEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkUpdateIndirectExecutionSetShaderEXT")]
        static abstract void UpdateIndirectExecutionSetShaderEXT(
            DeviceHandle device,
            IndirectExecutionSetHandleEXT indirectExecutionSet,
            uint executionSetWriteCount,
            Ref<WriteIndirectExecutionSetShaderEXT> pExecutionSetWrites
        );

        [NativeName("vkUpdateIndirectExecutionSetShaderEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkUpdateIndirectExecutionSetShaderEXT")]
        static abstract void UpdateIndirectExecutionSetShaderEXT(
            DeviceHandle device,
            IndirectExecutionSetHandleEXT indirectExecutionSet,
            WriteIndirectExecutionSetShaderEXT pExecutionSetWrites
        );

        [NativeName("vkUpdateVideoSessionParametersKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkUpdateVideoSessionParametersKHR")]
        static abstract Result UpdateVideoSessionParametersKHR(
            DeviceHandle device,
            VideoSessionParametersHandleKHR videoSessionParameters,
            VideoSessionParametersUpdateInfoKHR* pUpdateInfo
        );

        [NativeName("vkUpdateVideoSessionParametersKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkUpdateVideoSessionParametersKHR")]
        static abstract Result UpdateVideoSessionParametersKHR(
            DeviceHandle device,
            VideoSessionParametersHandleKHR videoSessionParameters,
            Ref<VideoSessionParametersUpdateInfoKHR> pUpdateInfo
        );

        [NativeName("vkWaitForFences")]
        [NativeFunction("vulkan", EntryPoint = "vkWaitForFences")]
        static abstract Result WaitForFences(
            DeviceHandle device,
            uint fenceCount,
            FenceHandle* pFences,
            uint waitAll,
            ulong timeout
        );

        [NativeName("vkWaitForFences")]
        [NativeFunction("vulkan", EntryPoint = "vkWaitForFences")]
        static abstract Result WaitForFences(
            DeviceHandle device,
            uint fenceCount,
            Ref<FenceHandle> pFences,
            MaybeBool<uint> waitAll,
            ulong timeout
        );

        [NativeName("vkWaitForPresent2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkWaitForPresent2KHR")]
        static abstract Result WaitForPresent2KHR(
            DeviceHandle device,
            SwapchainHandleKHR swapchain,
            PresentWait2InfoKHR* pPresentWait2Info
        );

        [NativeName("vkWaitForPresent2KHR")]
        [NativeFunction("vulkan", EntryPoint = "vkWaitForPresent2KHR")]
        static abstract Result WaitForPresent2KHR(
            DeviceHandle device,
            SwapchainHandleKHR swapchain,
            Ref<PresentWait2InfoKHR> pPresentWait2Info
        );

        [NativeName("vkWaitForPresentKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkWaitForPresentKHR")]
        static abstract Result WaitForPresentKHR(
            DeviceHandle device,
            SwapchainHandleKHR swapchain,
            ulong presentId,
            ulong timeout
        );

        [NativeName("vkWaitSemaphores")]
        [NativeFunction("vulkan", EntryPoint = "vkWaitSemaphores")]
        static abstract Result WaitSemaphores(
            DeviceHandle device,
            SemaphoreWaitInfo* pWaitInfo,
            ulong timeout
        );

        [NativeName("vkWaitSemaphores")]
        [NativeFunction("vulkan", EntryPoint = "vkWaitSemaphores")]
        static abstract Result WaitSemaphores(
            DeviceHandle device,
            Ref<SemaphoreWaitInfo> pWaitInfo,
            ulong timeout
        );

        [NativeName("vkWaitSemaphoresKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkWaitSemaphoresKHR")]
        static abstract Result WaitSemaphoresKHR(
            DeviceHandle device,
            SemaphoreWaitInfo* pWaitInfo,
            ulong timeout
        );

        [NativeName("vkWaitSemaphoresKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkWaitSemaphoresKHR")]
        static abstract Result WaitSemaphoresKHR(
            DeviceHandle device,
            Ref<SemaphoreWaitInfo> pWaitInfo,
            ulong timeout
        );

        [NativeName("vkWriteAccelerationStructuresPropertiesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkWriteAccelerationStructuresPropertiesKHR")]
        static abstract Result WriteAccelerationStructuresPropertiesKHR(
            DeviceHandle device,
            uint accelerationStructureCount,
            AccelerationStructureHandleKHR* pAccelerationStructures,
            QueryType queryType,
            nuint dataSize,
            void* pData,
            nuint stride
        );

        [NativeName("vkWriteAccelerationStructuresPropertiesKHR")]
        [NativeFunction("vulkan", EntryPoint = "vkWriteAccelerationStructuresPropertiesKHR")]
        static abstract Result WriteAccelerationStructuresPropertiesKHR(
            DeviceHandle device,
            uint accelerationStructureCount,
            Ref<AccelerationStructureHandleKHR> pAccelerationStructures,
            QueryType queryType,
            nuint dataSize,
            Ref pData,
            nuint stride
        );

        [NativeName("vkWriteMicromapsPropertiesEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkWriteMicromapsPropertiesEXT")]
        static abstract Result WriteMicromapsPropertiesEXT(
            DeviceHandle device,
            uint micromapCount,
            MicromapHandleEXT* pMicromaps,
            QueryType queryType,
            nuint dataSize,
            void* pData,
            nuint stride
        );

        [NativeName("vkWriteMicromapsPropertiesEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkWriteMicromapsPropertiesEXT")]
        static abstract Result WriteMicromapsPropertiesEXT(
            DeviceHandle device,
            uint micromapCount,
            Ref<MicromapHandleEXT> pMicromaps,
            QueryType queryType,
            nuint dataSize,
            Ref pData,
            nuint stride
        );

        [NativeName("vkWriteResourceDescriptorsEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkWriteResourceDescriptorsEXT")]
        static abstract Result WriteResourceDescriptorsEXT(
            DeviceHandle device,
            uint resourceCount,
            ResourceDescriptorInfoEXT* pResources,
            HostAddressRangeEXT* pDescriptors
        );

        [NativeName("vkWriteResourceDescriptorsEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkWriteResourceDescriptorsEXT")]
        static abstract Result WriteResourceDescriptorsEXT(
            DeviceHandle device,
            uint resourceCount,
            Ref<ResourceDescriptorInfoEXT> pResources,
            Ref<HostAddressRangeEXT> pDescriptors
        );

        [NativeName("vkWriteSamplerDescriptorsEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkWriteSamplerDescriptorsEXT")]
        static abstract Result WriteSamplerDescriptorsEXT(
            DeviceHandle device,
            uint samplerCount,
            SamplerCreateInfo* pSamplers,
            HostAddressRangeEXT* pDescriptors
        );

        [NativeName("vkWriteSamplerDescriptorsEXT")]
        [NativeFunction("vulkan", EntryPoint = "vkWriteSamplerDescriptorsEXT")]
        static abstract Result WriteSamplerDescriptorsEXT(
            DeviceHandle device,
            uint samplerCount,
            Ref<SamplerCreateInfo> pSamplers,
            Ref<HostAddressRangeEXT> pDescriptors
        );
    }

    [NativeName("vkAcquireDrmDisplayEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkAcquireDrmDisplayEXT")]
    Result AcquireDrmDisplayEXT(
        PhysicalDeviceHandle physicalDevice,
        int drmFd,
        DisplayHandleKHR display
    );

    [NativeName("vkAcquireNextImage2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkAcquireNextImage2KHR")]
    Result AcquireNextImage2KHR(
        DeviceHandle device,
        AcquireNextImageInfoKHR* pAcquireInfo,
        uint* pImageIndex
    );

    [NativeName("vkAcquireNextImage2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkAcquireNextImage2KHR")]
    Result AcquireNextImage2KHR(
        DeviceHandle device,
        Ref<AcquireNextImageInfoKHR> pAcquireInfo,
        Ref<uint> pImageIndex
    );

    [NativeName("vkAcquireNextImageKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkAcquireNextImageKHR")]
    Result AcquireNextImageKHR(
        DeviceHandle device,
        SwapchainHandleKHR swapchain,
        ulong timeout,
        SemaphoreHandle semaphore,
        FenceHandle fence,
        uint* pImageIndex
    );

    [NativeName("vkAcquireNextImageKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkAcquireNextImageKHR")]
    Result AcquireNextImageKHR(
        DeviceHandle device,
        SwapchainHandleKHR swapchain,
        ulong timeout,
        SemaphoreHandle semaphore,
        FenceHandle fence,
        Ref<uint> pImageIndex
    );

    [NativeName("vkAcquirePerformanceConfigurationINTEL")]
    [NativeFunction("vulkan", EntryPoint = "vkAcquirePerformanceConfigurationINTEL")]
    Result AcquirePerformanceConfigurationINTEL(
        DeviceHandle device,
        PerformanceConfigurationAcquireInfoINTEL* pAcquireInfo,
        PerformanceConfigurationHandleINTEL* pConfiguration
    );

    [NativeName("vkAcquirePerformanceConfigurationINTEL")]
    [NativeFunction("vulkan", EntryPoint = "vkAcquirePerformanceConfigurationINTEL")]
    Result AcquirePerformanceConfigurationINTEL(
        DeviceHandle device,
        Ref<PerformanceConfigurationAcquireInfoINTEL> pAcquireInfo,
        Ref<PerformanceConfigurationHandleINTEL> pConfiguration
    );

    [NativeName("vkAcquireProfilingLockKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkAcquireProfilingLockKHR")]
    Result AcquireProfilingLockKHR(DeviceHandle device, AcquireProfilingLockInfoKHR* pInfo);

    [NativeName("vkAcquireProfilingLockKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkAcquireProfilingLockKHR")]
    Result AcquireProfilingLockKHR(DeviceHandle device, Ref<AcquireProfilingLockInfoKHR> pInfo);

    [NativeName("vkAllocateCommandBuffers")]
    [NativeFunction("vulkan", EntryPoint = "vkAllocateCommandBuffers")]
    Result AllocateCommandBuffers(
        DeviceHandle device,
        CommandBufferAllocateInfo* pAllocateInfo,
        CommandBufferHandle* pCommandBuffers
    );

    [NativeName("vkAllocateCommandBuffers")]
    [NativeFunction("vulkan", EntryPoint = "vkAllocateCommandBuffers")]
    Result AllocateCommandBuffers(
        DeviceHandle device,
        Ref<CommandBufferAllocateInfo> pAllocateInfo,
        Ref<CommandBufferHandle> pCommandBuffers
    );

    [NativeName("vkAllocateDescriptorSets")]
    [NativeFunction("vulkan", EntryPoint = "vkAllocateDescriptorSets")]
    Result AllocateDescriptorSets(
        DeviceHandle device,
        DescriptorSetAllocateInfo* pAllocateInfo,
        DescriptorSetHandle* pDescriptorSets
    );

    [NativeName("vkAllocateDescriptorSets")]
    [NativeFunction("vulkan", EntryPoint = "vkAllocateDescriptorSets")]
    Result AllocateDescriptorSets(
        DeviceHandle device,
        Ref<DescriptorSetAllocateInfo> pAllocateInfo,
        Ref<DescriptorSetHandle> pDescriptorSets
    );

    [NativeName("vkAllocateMemory")]
    [NativeFunction("vulkan", EntryPoint = "vkAllocateMemory")]
    Result AllocateMemory(
        DeviceHandle device,
        MemoryAllocateInfo* pAllocateInfo,
        AllocationCallbacks* pAllocator,
        DeviceMemoryHandle* pMemory
    );

    [NativeName("vkAllocateMemory")]
    [NativeFunction("vulkan", EntryPoint = "vkAllocateMemory")]
    Result AllocateMemory(
        DeviceHandle device,
        Ref<MemoryAllocateInfo> pAllocateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<DeviceMemoryHandle> pMemory
    );

    [NativeName("vkAntiLagUpdateAMD")]
    [NativeFunction("vulkan", EntryPoint = "vkAntiLagUpdateAMD")]
    void AntiLagUpdateAMD(DeviceHandle device, AntiLagDataAMD* pData);

    [NativeName("vkAntiLagUpdateAMD")]
    [NativeFunction("vulkan", EntryPoint = "vkAntiLagUpdateAMD")]
    void AntiLagUpdateAMD(DeviceHandle device, Ref<AntiLagDataAMD> pData);

    [NativeName("vkBeginCommandBuffer")]
    [NativeFunction("vulkan", EntryPoint = "vkBeginCommandBuffer")]
    Result BeginCommandBuffer(
        CommandBufferHandle commandBuffer,
        CommandBufferBeginInfo* pBeginInfo
    );

    [NativeName("vkBeginCommandBuffer")]
    [NativeFunction("vulkan", EntryPoint = "vkBeginCommandBuffer")]
    Result BeginCommandBuffer(
        CommandBufferHandle commandBuffer,
        Ref<CommandBufferBeginInfo> pBeginInfo
    );

    [NativeName("vkBindAccelerationStructureMemoryNV")]
    [NativeFunction("vulkan", EntryPoint = "vkBindAccelerationStructureMemoryNV")]
    Result BindAccelerationStructureMemoryNV(
        DeviceHandle device,
        uint bindInfoCount,
        BindAccelerationStructureMemoryInfoNV* pBindInfos
    );

    [NativeName("vkBindAccelerationStructureMemoryNV")]
    [NativeFunction("vulkan", EntryPoint = "vkBindAccelerationStructureMemoryNV")]
    Result BindAccelerationStructureMemoryNV(
        DeviceHandle device,
        uint bindInfoCount,
        Ref<BindAccelerationStructureMemoryInfoNV> pBindInfos
    );

    [NativeName("vkBindBufferMemory")]
    [NativeFunction("vulkan", EntryPoint = "vkBindBufferMemory")]
    Result BindBufferMemory(
        DeviceHandle device,
        BufferHandle buffer,
        DeviceMemoryHandle memory,
        ulong memoryOffset
    );

    [NativeName("vkBindBufferMemory2")]
    [NativeFunction("vulkan", EntryPoint = "vkBindBufferMemory2")]
    Result BindBufferMemory2(
        DeviceHandle device,
        uint bindInfoCount,
        BindBufferMemoryInfo* pBindInfos
    );

    [NativeName("vkBindBufferMemory2")]
    [NativeFunction("vulkan", EntryPoint = "vkBindBufferMemory2")]
    Result BindBufferMemory2(
        DeviceHandle device,
        uint bindInfoCount,
        Ref<BindBufferMemoryInfo> pBindInfos
    );

    [NativeName("vkBindBufferMemory2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkBindBufferMemory2KHR")]
    Result BindBufferMemory2KHR(
        DeviceHandle device,
        uint bindInfoCount,
        BindBufferMemoryInfo* pBindInfos
    );

    [NativeName("vkBindBufferMemory2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkBindBufferMemory2KHR")]
    Result BindBufferMemory2KHR(
        DeviceHandle device,
        uint bindInfoCount,
        Ref<BindBufferMemoryInfo> pBindInfos
    );

    [NativeName("vkBindDataGraphPipelineSessionMemoryARM")]
    [NativeFunction("vulkan", EntryPoint = "vkBindDataGraphPipelineSessionMemoryARM")]
    Result BindDataGraphPipelineSessionMemoryARM(
        DeviceHandle device,
        uint bindInfoCount,
        BindDataGraphPipelineSessionMemoryInfoARM* pBindInfos
    );

    [NativeName("vkBindDataGraphPipelineSessionMemoryARM")]
    [NativeFunction("vulkan", EntryPoint = "vkBindDataGraphPipelineSessionMemoryARM")]
    Result BindDataGraphPipelineSessionMemoryARM(
        DeviceHandle device,
        uint bindInfoCount,
        Ref<BindDataGraphPipelineSessionMemoryInfoARM> pBindInfos
    );

    [NativeName("vkBindImageMemory")]
    [NativeFunction("vulkan", EntryPoint = "vkBindImageMemory")]
    Result BindImageMemory(
        DeviceHandle device,
        ImageHandle image,
        DeviceMemoryHandle memory,
        ulong memoryOffset
    );

    [NativeName("vkBindImageMemory2")]
    [NativeFunction("vulkan", EntryPoint = "vkBindImageMemory2")]
    Result BindImageMemory2(
        DeviceHandle device,
        uint bindInfoCount,
        BindImageMemoryInfo* pBindInfos
    );

    [NativeName("vkBindImageMemory2")]
    [NativeFunction("vulkan", EntryPoint = "vkBindImageMemory2")]
    Result BindImageMemory2(
        DeviceHandle device,
        uint bindInfoCount,
        Ref<BindImageMemoryInfo> pBindInfos
    );

    [NativeName("vkBindImageMemory2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkBindImageMemory2KHR")]
    Result BindImageMemory2KHR(
        DeviceHandle device,
        uint bindInfoCount,
        BindImageMemoryInfo* pBindInfos
    );

    [NativeName("vkBindImageMemory2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkBindImageMemory2KHR")]
    Result BindImageMemory2KHR(
        DeviceHandle device,
        uint bindInfoCount,
        Ref<BindImageMemoryInfo> pBindInfos
    );

    [NativeName("vkBindOpticalFlowSessionImageNV")]
    [NativeFunction("vulkan", EntryPoint = "vkBindOpticalFlowSessionImageNV")]
    Result BindOpticalFlowSessionImageNV(
        DeviceHandle device,
        OpticalFlowSessionHandleNV session,
        OpticalFlowSessionBindingPointNV bindingPoint,
        ImageViewHandle view,
        ImageLayout layout
    );

    [NativeName("vkBindTensorMemoryARM")]
    [NativeFunction("vulkan", EntryPoint = "vkBindTensorMemoryARM")]
    Result BindTensorMemoryARM(
        DeviceHandle device,
        uint bindInfoCount,
        BindTensorMemoryInfoARM* pBindInfos
    );

    [NativeName("vkBindTensorMemoryARM")]
    [NativeFunction("vulkan", EntryPoint = "vkBindTensorMemoryARM")]
    Result BindTensorMemoryARM(
        DeviceHandle device,
        uint bindInfoCount,
        Ref<BindTensorMemoryInfoARM> pBindInfos
    );

    [NativeName("vkBindVideoSessionMemoryKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkBindVideoSessionMemoryKHR")]
    Result BindVideoSessionMemoryKHR(
        DeviceHandle device,
        VideoSessionHandleKHR videoSession,
        uint bindSessionMemoryInfoCount,
        BindVideoSessionMemoryInfoKHR* pBindSessionMemoryInfos
    );

    [NativeName("vkBindVideoSessionMemoryKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkBindVideoSessionMemoryKHR")]
    Result BindVideoSessionMemoryKHR(
        DeviceHandle device,
        VideoSessionHandleKHR videoSession,
        uint bindSessionMemoryInfoCount,
        Ref<BindVideoSessionMemoryInfoKHR> pBindSessionMemoryInfos
    );

    [NativeName("vkBuildAccelerationStructuresKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkBuildAccelerationStructuresKHR")]
    Result BuildAccelerationStructuresKHR(
        DeviceHandle device,
        DeferredOperationHandleKHR deferredOperation,
        uint infoCount,
        AccelerationStructureBuildGeometryInfoKHR* pInfos,
        AccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos
    );

    [NativeName("vkBuildAccelerationStructuresKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkBuildAccelerationStructuresKHR")]
    Result BuildAccelerationStructuresKHR(
        DeviceHandle device,
        DeferredOperationHandleKHR deferredOperation,
        uint infoCount,
        Ref<AccelerationStructureBuildGeometryInfoKHR> pInfos,
        Ref2D<AccelerationStructureBuildRangeInfoKHR> ppBuildRangeInfos
    );

    [NativeName("vkBuildMicromapsEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkBuildMicromapsEXT")]
    Result BuildMicromapsEXT(
        DeviceHandle device,
        DeferredOperationHandleKHR deferredOperation,
        uint infoCount,
        MicromapBuildInfoEXT* pInfos
    );

    [NativeName("vkBuildMicromapsEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkBuildMicromapsEXT")]
    Result BuildMicromapsEXT(
        DeviceHandle device,
        DeferredOperationHandleKHR deferredOperation,
        uint infoCount,
        Ref<MicromapBuildInfoEXT> pInfos
    );

    [NativeName("vkClearShaderInstrumentationMetricsARM")]
    [NativeFunction("vulkan", EntryPoint = "vkClearShaderInstrumentationMetricsARM")]
    void ClearShaderInstrumentationMetricsARM(
        DeviceHandle device,
        ShaderInstrumentationHandleARM instrumentation
    );

    [NativeName("vkCmdBeginConditionalRendering2EXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBeginConditionalRendering2EXT")]
    void CmdBeginConditionalRendering2EXT(
        CommandBufferHandle commandBuffer,
        ConditionalRenderingBeginInfo2EXT* pConditionalRenderingBegin
    );

    [NativeName("vkCmdBeginConditionalRendering2EXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBeginConditionalRendering2EXT")]
    void CmdBeginConditionalRendering2EXT(
        CommandBufferHandle commandBuffer,
        Ref<ConditionalRenderingBeginInfo2EXT> pConditionalRenderingBegin
    );

    [NativeName("vkCmdBeginConditionalRenderingEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBeginConditionalRenderingEXT")]
    void CmdBeginConditionalRenderingEXT(
        CommandBufferHandle commandBuffer,
        ConditionalRenderingBeginInfoEXT* pConditionalRenderingBegin
    );

    [NativeName("vkCmdBeginConditionalRenderingEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBeginConditionalRenderingEXT")]
    void CmdBeginConditionalRenderingEXT(
        CommandBufferHandle commandBuffer,
        Ref<ConditionalRenderingBeginInfoEXT> pConditionalRenderingBegin
    );

    [NativeName("vkCmdBeginCustomResolveEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBeginCustomResolveEXT")]
    void CmdBeginCustomResolveEXT(
        CommandBufferHandle commandBuffer,
        BeginCustomResolveInfoEXT* pBeginCustomResolveInfo
    );

    [NativeName("vkCmdBeginCustomResolveEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBeginCustomResolveEXT")]
    void CmdBeginCustomResolveEXT(
        CommandBufferHandle commandBuffer,
        Ref<BeginCustomResolveInfoEXT> pBeginCustomResolveInfo
    );

    [NativeName("vkCmdBeginDebugUtilsLabelEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBeginDebugUtilsLabelEXT")]
    void CmdBeginDebugUtilsLabelEXT(
        CommandBufferHandle commandBuffer,
        DebugUtilsLabelEXT* pLabelInfo
    );

    [NativeName("vkCmdBeginDebugUtilsLabelEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBeginDebugUtilsLabelEXT")]
    void CmdBeginDebugUtilsLabelEXT(
        CommandBufferHandle commandBuffer,
        Ref<DebugUtilsLabelEXT> pLabelInfo
    );

    [NativeName("vkCmdBeginGpaSampleAMD")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBeginGpaSampleAMD")]
    Result CmdBeginGpaSampleAMD(
        CommandBufferHandle commandBuffer,
        GpaSessionHandleAMD gpaSession,
        GpaSampleBeginInfoAMD* pGpaSampleBeginInfo,
        uint* pSampleID
    );

    [NativeName("vkCmdBeginGpaSampleAMD")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBeginGpaSampleAMD")]
    Result CmdBeginGpaSampleAMD(
        CommandBufferHandle commandBuffer,
        GpaSessionHandleAMD gpaSession,
        Ref<GpaSampleBeginInfoAMD> pGpaSampleBeginInfo,
        Ref<uint> pSampleID
    );

    [NativeName("vkCmdBeginGpaSessionAMD")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBeginGpaSessionAMD")]
    Result CmdBeginGpaSessionAMD(CommandBufferHandle commandBuffer, GpaSessionHandleAMD gpaSession);

    [NativeName("vkCmdBeginPerTileExecutionQCOM")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBeginPerTileExecutionQCOM")]
    void CmdBeginPerTileExecutionQCOM(
        CommandBufferHandle commandBuffer,
        PerTileBeginInfoQCOM* pPerTileBeginInfo
    );

    [NativeName("vkCmdBeginPerTileExecutionQCOM")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBeginPerTileExecutionQCOM")]
    void CmdBeginPerTileExecutionQCOM(
        CommandBufferHandle commandBuffer,
        Ref<PerTileBeginInfoQCOM> pPerTileBeginInfo
    );

    [NativeName("vkCmdBeginQuery")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBeginQuery")]
    void CmdBeginQuery(
        CommandBufferHandle commandBuffer,
        QueryPoolHandle queryPool,
        uint query,
        QueryControlFlags flags
    );

    [NativeName("vkCmdBeginQueryIndexedEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBeginQueryIndexedEXT")]
    void CmdBeginQueryIndexedEXT(
        CommandBufferHandle commandBuffer,
        QueryPoolHandle queryPool,
        uint query,
        QueryControlFlags flags,
        uint index
    );

    [NativeName("vkCmdBeginRendering")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBeginRendering")]
    void CmdBeginRendering(CommandBufferHandle commandBuffer, RenderingInfo* pRenderingInfo);

    [NativeName("vkCmdBeginRendering")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBeginRendering")]
    void CmdBeginRendering(CommandBufferHandle commandBuffer, Ref<RenderingInfo> pRenderingInfo);

    [NativeName("vkCmdBeginRenderingKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBeginRenderingKHR")]
    void CmdBeginRenderingKHR(CommandBufferHandle commandBuffer, RenderingInfo* pRenderingInfo);

    [NativeName("vkCmdBeginRenderingKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBeginRenderingKHR")]
    void CmdBeginRenderingKHR(CommandBufferHandle commandBuffer, Ref<RenderingInfo> pRenderingInfo);

    [NativeName("vkCmdBeginRenderPass")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBeginRenderPass")]
    void CmdBeginRenderPass(
        CommandBufferHandle commandBuffer,
        RenderPassBeginInfo* pRenderPassBegin,
        SubpassContents contents
    );

    [NativeName("vkCmdBeginRenderPass")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBeginRenderPass")]
    void CmdBeginRenderPass(
        CommandBufferHandle commandBuffer,
        Ref<RenderPassBeginInfo> pRenderPassBegin,
        SubpassContents contents
    );

    [NativeName("vkCmdBeginRenderPass2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBeginRenderPass2")]
    void CmdBeginRenderPass2(
        CommandBufferHandle commandBuffer,
        RenderPassBeginInfo* pRenderPassBegin,
        SubpassBeginInfo* pSubpassBeginInfo
    );

    [NativeName("vkCmdBeginRenderPass2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBeginRenderPass2")]
    void CmdBeginRenderPass2(
        CommandBufferHandle commandBuffer,
        Ref<RenderPassBeginInfo> pRenderPassBegin,
        Ref<SubpassBeginInfo> pSubpassBeginInfo
    );

    [NativeName("vkCmdBeginRenderPass2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBeginRenderPass2KHR")]
    void CmdBeginRenderPass2KHR(
        CommandBufferHandle commandBuffer,
        RenderPassBeginInfo* pRenderPassBegin,
        SubpassBeginInfo* pSubpassBeginInfo
    );

    [NativeName("vkCmdBeginRenderPass2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBeginRenderPass2KHR")]
    void CmdBeginRenderPass2KHR(
        CommandBufferHandle commandBuffer,
        Ref<RenderPassBeginInfo> pRenderPassBegin,
        Ref<SubpassBeginInfo> pSubpassBeginInfo
    );

    [NativeName("vkCmdBeginShaderInstrumentationARM")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBeginShaderInstrumentationARM")]
    void CmdBeginShaderInstrumentationARM(
        CommandBufferHandle commandBuffer,
        ShaderInstrumentationHandleARM instrumentation
    );

    [NativeName("vkCmdBeginTransformFeedback2EXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBeginTransformFeedback2EXT")]
    void CmdBeginTransformFeedback2EXT(
        CommandBufferHandle commandBuffer,
        uint firstCounterRange,
        uint counterRangeCount,
        BindTransformFeedbackBuffer2InfoEXT* pCounterInfos
    );

    [NativeName("vkCmdBeginTransformFeedback2EXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBeginTransformFeedback2EXT")]
    void CmdBeginTransformFeedback2EXT(
        CommandBufferHandle commandBuffer,
        uint firstCounterRange,
        uint counterRangeCount,
        Ref<BindTransformFeedbackBuffer2InfoEXT> pCounterInfos
    );

    [NativeName("vkCmdBeginTransformFeedback2EXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBeginTransformFeedback2EXT")]
    void CmdBeginTransformFeedback2EXT(
        CommandBufferHandle commandBuffer,
        uint firstCounterRange,
        BindTransformFeedbackBuffer2InfoEXT pCounterInfos
    );

    [NativeName("vkCmdBeginTransformFeedbackEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBeginTransformFeedbackEXT")]
    void CmdBeginTransformFeedbackEXT(
        CommandBufferHandle commandBuffer,
        uint firstCounterBuffer,
        uint counterBufferCount,
        BufferHandle* pCounterBuffers,
        ulong* pCounterBufferOffsets
    );

    [NativeName("vkCmdBeginTransformFeedbackEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBeginTransformFeedbackEXT")]
    void CmdBeginTransformFeedbackEXT(
        CommandBufferHandle commandBuffer,
        uint firstCounterBuffer,
        uint counterBufferCount,
        Ref<BufferHandle> pCounterBuffers,
        Ref<ulong> pCounterBufferOffsets
    );

    [NativeName("vkCmdBeginVideoCodingKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBeginVideoCodingKHR")]
    void CmdBeginVideoCodingKHR(
        CommandBufferHandle commandBuffer,
        VideoBeginCodingInfoKHR* pBeginInfo
    );

    [NativeName("vkCmdBeginVideoCodingKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBeginVideoCodingKHR")]
    void CmdBeginVideoCodingKHR(
        CommandBufferHandle commandBuffer,
        Ref<VideoBeginCodingInfoKHR> pBeginInfo
    );

    [NativeName("vkCmdBindDescriptorBufferEmbeddedSamplers2EXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindDescriptorBufferEmbeddedSamplers2EXT")]
    void CmdBindDescriptorBufferEmbeddedSamplers2EXT(
        CommandBufferHandle commandBuffer,
        BindDescriptorBufferEmbeddedSamplersInfoEXT* pBindDescriptorBufferEmbeddedSamplersInfo
    );

    [NativeName("vkCmdBindDescriptorBufferEmbeddedSamplers2EXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindDescriptorBufferEmbeddedSamplers2EXT")]
    void CmdBindDescriptorBufferEmbeddedSamplers2EXT(
        CommandBufferHandle commandBuffer,
        Ref<BindDescriptorBufferEmbeddedSamplersInfoEXT> pBindDescriptorBufferEmbeddedSamplersInfo
    );

    [NativeName("vkCmdBindDescriptorBufferEmbeddedSamplersEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindDescriptorBufferEmbeddedSamplersEXT")]
    void CmdBindDescriptorBufferEmbeddedSamplersEXT(
        CommandBufferHandle commandBuffer,
        PipelineBindPoint pipelineBindPoint,
        PipelineLayoutHandle layout,
        uint set
    );

    [NativeName("vkCmdBindDescriptorBuffersEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindDescriptorBuffersEXT")]
    void CmdBindDescriptorBufferEXT(
        CommandBufferHandle commandBuffer,
        DescriptorBufferBindingInfoEXT pBindingInfos
    );

    [NativeName("vkCmdBindDescriptorBuffersEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindDescriptorBuffersEXT")]
    void CmdBindDescriptorBuffersEXT(
        CommandBufferHandle commandBuffer,
        uint bufferCount,
        DescriptorBufferBindingInfoEXT* pBindingInfos
    );

    [NativeName("vkCmdBindDescriptorBuffersEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindDescriptorBuffersEXT")]
    void CmdBindDescriptorBuffersEXT(
        CommandBufferHandle commandBuffer,
        uint bufferCount,
        Ref<DescriptorBufferBindingInfoEXT> pBindingInfos
    );

    [NativeName("vkCmdBindDescriptorSets")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindDescriptorSets")]
    void CmdBindDescriptorSets(
        CommandBufferHandle commandBuffer,
        PipelineBindPoint pipelineBindPoint,
        PipelineLayoutHandle layout,
        uint firstSet,
        uint descriptorSetCount,
        DescriptorSetHandle* pDescriptorSets,
        uint dynamicOffsetCount,
        uint* pDynamicOffsets
    );

    [NativeName("vkCmdBindDescriptorSets")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindDescriptorSets")]
    void CmdBindDescriptorSets(
        CommandBufferHandle commandBuffer,
        PipelineBindPoint pipelineBindPoint,
        PipelineLayoutHandle layout,
        uint firstSet,
        uint descriptorSetCount,
        Ref<DescriptorSetHandle> pDescriptorSets,
        uint dynamicOffsetCount,
        Ref<uint> pDynamicOffsets
    );

    [NativeName("vkCmdBindDescriptorSets2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindDescriptorSets2")]
    void CmdBindDescriptorSets2(
        CommandBufferHandle commandBuffer,
        BindDescriptorSetsInfo* pBindDescriptorSetsInfo
    );

    [NativeName("vkCmdBindDescriptorSets2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindDescriptorSets2")]
    void CmdBindDescriptorSets2(
        CommandBufferHandle commandBuffer,
        Ref<BindDescriptorSetsInfo> pBindDescriptorSetsInfo
    );

    [NativeName("vkCmdBindDescriptorSets2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindDescriptorSets2KHR")]
    void CmdBindDescriptorSets2KHR(
        CommandBufferHandle commandBuffer,
        BindDescriptorSetsInfo* pBindDescriptorSetsInfo
    );

    [NativeName("vkCmdBindDescriptorSets2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindDescriptorSets2KHR")]
    void CmdBindDescriptorSets2KHR(
        CommandBufferHandle commandBuffer,
        Ref<BindDescriptorSetsInfo> pBindDescriptorSetsInfo
    );

    [NativeName("vkCmdBindIndexBuffer")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindIndexBuffer")]
    void CmdBindIndexBuffer(
        CommandBufferHandle commandBuffer,
        BufferHandle buffer,
        ulong offset,
        IndexType indexType
    );

    [NativeName("vkCmdBindIndexBuffer2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindIndexBuffer2")]
    void CmdBindIndexBuffer2(
        CommandBufferHandle commandBuffer,
        BufferHandle buffer,
        ulong offset,
        ulong size,
        IndexType indexType
    );

    [NativeName("vkCmdBindIndexBuffer2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindIndexBuffer2KHR")]
    void CmdBindIndexBuffer2KHR(
        CommandBufferHandle commandBuffer,
        BufferHandle buffer,
        ulong offset,
        ulong size,
        IndexType indexType
    );

    [NativeName("vkCmdBindIndexBuffer3KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindIndexBuffer3KHR")]
    void CmdBindIndexBuffer3KHR(CommandBufferHandle commandBuffer, BindIndexBuffer3InfoKHR* pInfo);

    [NativeName("vkCmdBindIndexBuffer3KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindIndexBuffer3KHR")]
    void CmdBindIndexBuffer3KHR(
        CommandBufferHandle commandBuffer,
        Ref<BindIndexBuffer3InfoKHR> pInfo
    );

    [NativeName("vkCmdBindInvocationMaskHUAWEI")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindInvocationMaskHUAWEI")]
    void CmdBindInvocationMaskHUAWEI(
        CommandBufferHandle commandBuffer,
        ImageViewHandle imageView,
        ImageLayout imageLayout
    );

    [NativeName("vkCmdBindPipeline")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindPipeline")]
    void CmdBindPipeline(
        CommandBufferHandle commandBuffer,
        PipelineBindPoint pipelineBindPoint,
        PipelineHandle pipeline
    );

    [NativeName("vkCmdBindPipelineShaderGroupNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindPipelineShaderGroupNV")]
    void CmdBindPipelineShaderGroupNV(
        CommandBufferHandle commandBuffer,
        PipelineBindPoint pipelineBindPoint,
        PipelineHandle pipeline,
        uint groupIndex
    );

    [NativeName("vkCmdBindResourceHeapEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindResourceHeapEXT")]
    void CmdBindResourceHeapEXT(CommandBufferHandle commandBuffer, BindHeapInfoEXT* pBindInfo);

    [NativeName("vkCmdBindResourceHeapEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindResourceHeapEXT")]
    void CmdBindResourceHeapEXT(CommandBufferHandle commandBuffer, Ref<BindHeapInfoEXT> pBindInfo);

    [NativeName("vkCmdBindSamplerHeapEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindSamplerHeapEXT")]
    void CmdBindSamplerHeapEXT(CommandBufferHandle commandBuffer, BindHeapInfoEXT* pBindInfo);

    [NativeName("vkCmdBindSamplerHeapEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindSamplerHeapEXT")]
    void CmdBindSamplerHeapEXT(CommandBufferHandle commandBuffer, Ref<BindHeapInfoEXT> pBindInfo);

    [NativeName("vkCmdBindShadersEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindShadersEXT")]
    void CmdBindShadersEXT(
        CommandBufferHandle commandBuffer,
        uint stageCount,
        ShaderStageFlags* pStages,
        ShaderHandleEXT* pShaders
    );

    [NativeName("vkCmdBindShadersEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindShadersEXT")]
    void CmdBindShadersEXT(
        CommandBufferHandle commandBuffer,
        uint stageCount,
        Ref<ShaderStageFlags> pStages,
        Ref<ShaderHandleEXT> pShaders
    );

    [NativeName("vkCmdBindShadingRateImageNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindShadingRateImageNV")]
    void CmdBindShadingRateImageNV(
        CommandBufferHandle commandBuffer,
        ImageViewHandle imageView,
        ImageLayout imageLayout
    );

    [NativeName("vkCmdBindTileMemoryQCOM")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindTileMemoryQCOM")]
    void CmdBindTileMemoryQCOM(
        CommandBufferHandle commandBuffer,
        TileMemoryBindInfoQCOM* pTileMemoryBindInfo
    );

    [NativeName("vkCmdBindTileMemoryQCOM")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindTileMemoryQCOM")]
    void CmdBindTileMemoryQCOM(
        CommandBufferHandle commandBuffer,
        Ref<TileMemoryBindInfoQCOM> pTileMemoryBindInfo
    );

    [NativeName("vkCmdBindTransformFeedbackBuffers2EXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindTransformFeedbackBuffers2EXT")]
    void CmdBindTransformFeedbackBuffers2EXT(
        CommandBufferHandle commandBuffer,
        uint firstBinding,
        uint bindingCount,
        BindTransformFeedbackBuffer2InfoEXT* pBindingInfos
    );

    [NativeName("vkCmdBindTransformFeedbackBuffers2EXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindTransformFeedbackBuffers2EXT")]
    void CmdBindTransformFeedbackBuffers2EXT(
        CommandBufferHandle commandBuffer,
        uint firstBinding,
        uint bindingCount,
        Ref<BindTransformFeedbackBuffer2InfoEXT> pBindingInfos
    );

    [NativeName("vkCmdBindTransformFeedbackBuffers2EXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindTransformFeedbackBuffers2EXT")]
    void CmdBindTransformFeedbackBuffers2EXT(
        CommandBufferHandle commandBuffer,
        uint firstBinding,
        BindTransformFeedbackBuffer2InfoEXT pBindingInfos
    );

    [NativeName("vkCmdBindTransformFeedbackBuffersEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindTransformFeedbackBuffersEXT")]
    void CmdBindTransformFeedbackBuffersEXT(
        CommandBufferHandle commandBuffer,
        uint firstBinding,
        uint bindingCount,
        BufferHandle* pBuffers,
        ulong* pOffsets,
        ulong* pSizes
    );

    [NativeName("vkCmdBindTransformFeedbackBuffersEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindTransformFeedbackBuffersEXT")]
    void CmdBindTransformFeedbackBuffersEXT(
        CommandBufferHandle commandBuffer,
        uint firstBinding,
        uint bindingCount,
        Ref<BufferHandle> pBuffers,
        Ref<ulong> pOffsets,
        Ref<ulong> pSizes
    );

    [NativeName("vkCmdBindVertexBuffers")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindVertexBuffers")]
    void CmdBindVertexBuffers(
        CommandBufferHandle commandBuffer,
        uint firstBinding,
        uint bindingCount,
        BufferHandle* pBuffers,
        ulong* pOffsets
    );

    [NativeName("vkCmdBindVertexBuffers")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindVertexBuffers")]
    void CmdBindVertexBuffers(
        CommandBufferHandle commandBuffer,
        uint firstBinding,
        uint bindingCount,
        Ref<BufferHandle> pBuffers,
        Ref<ulong> pOffsets
    );

    [NativeName("vkCmdBindVertexBuffers2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindVertexBuffers2")]
    void CmdBindVertexBuffers2(
        CommandBufferHandle commandBuffer,
        uint firstBinding,
        uint bindingCount,
        BufferHandle* pBuffers,
        ulong* pOffsets,
        ulong* pSizes,
        ulong* pStrides
    );

    [NativeName("vkCmdBindVertexBuffers2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindVertexBuffers2")]
    void CmdBindVertexBuffers2(
        CommandBufferHandle commandBuffer,
        uint firstBinding,
        uint bindingCount,
        Ref<BufferHandle> pBuffers,
        Ref<ulong> pOffsets,
        Ref<ulong> pSizes,
        Ref<ulong> pStrides
    );

    [NativeName("vkCmdBindVertexBuffers2EXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindVertexBuffers2EXT")]
    void CmdBindVertexBuffers2EXT(
        CommandBufferHandle commandBuffer,
        uint firstBinding,
        uint bindingCount,
        BufferHandle* pBuffers,
        ulong* pOffsets,
        ulong* pSizes,
        ulong* pStrides
    );

    [NativeName("vkCmdBindVertexBuffers2EXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindVertexBuffers2EXT")]
    void CmdBindVertexBuffers2EXT(
        CommandBufferHandle commandBuffer,
        uint firstBinding,
        uint bindingCount,
        Ref<BufferHandle> pBuffers,
        Ref<ulong> pOffsets,
        Ref<ulong> pSizes,
        Ref<ulong> pStrides
    );

    [NativeName("vkCmdBindVertexBuffers3KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindVertexBuffers3KHR")]
    void CmdBindVertexBuffers3KHR(
        CommandBufferHandle commandBuffer,
        uint firstBinding,
        uint bindingCount,
        BindVertexBuffer3InfoKHR* pBindingInfos
    );

    [NativeName("vkCmdBindVertexBuffers3KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindVertexBuffers3KHR")]
    void CmdBindVertexBuffers3KHR(
        CommandBufferHandle commandBuffer,
        uint firstBinding,
        uint bindingCount,
        Ref<BindVertexBuffer3InfoKHR> pBindingInfos
    );

    [NativeName("vkCmdBindVertexBuffers3KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBindVertexBuffers3KHR")]
    void CmdBindVertexBuffers3KHR(
        CommandBufferHandle commandBuffer,
        uint firstBinding,
        BindVertexBuffer3InfoKHR pBindingInfos
    );

    [NativeName("vkCmdBlitImage")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBlitImage")]
    void CmdBlitImage(
        CommandBufferHandle commandBuffer,
        ImageHandle srcImage,
        ImageLayout srcImageLayout,
        ImageHandle dstImage,
        ImageLayout dstImageLayout,
        uint regionCount,
        ImageBlit* pRegions,
        Filter filter
    );

    [NativeName("vkCmdBlitImage")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBlitImage")]
    void CmdBlitImage(
        CommandBufferHandle commandBuffer,
        ImageHandle srcImage,
        ImageLayout srcImageLayout,
        ImageHandle dstImage,
        ImageLayout dstImageLayout,
        uint regionCount,
        Ref<ImageBlit> pRegions,
        Filter filter
    );

    [NativeName("vkCmdBlitImage")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBlitImage")]
    void CmdBlitImage(
        CommandBufferHandle commandBuffer,
        ImageHandle srcImage,
        ImageLayout srcImageLayout,
        ImageHandle dstImage,
        ImageLayout dstImageLayout,
        ImageBlit pRegions,
        Filter filter
    );

    [NativeName("vkCmdBlitImage2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBlitImage2")]
    void CmdBlitImage2(CommandBufferHandle commandBuffer, BlitImageInfo2* pBlitImageInfo);

    [NativeName("vkCmdBlitImage2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBlitImage2")]
    void CmdBlitImage2(CommandBufferHandle commandBuffer, Ref<BlitImageInfo2> pBlitImageInfo);

    [NativeName("vkCmdBlitImage2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBlitImage2KHR")]
    void CmdBlitImage2KHR(CommandBufferHandle commandBuffer, BlitImageInfo2* pBlitImageInfo);

    [NativeName("vkCmdBlitImage2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBlitImage2KHR")]
    void CmdBlitImage2KHR(CommandBufferHandle commandBuffer, Ref<BlitImageInfo2> pBlitImageInfo);

    [NativeName("vkCmdBuildAccelerationStructureNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBuildAccelerationStructureNV")]
    void CmdBuildAccelerationStructureNV(
        CommandBufferHandle commandBuffer,
        AccelerationStructureInfoNV* pInfo,
        BufferHandle instanceData,
        ulong instanceOffset,
        uint update,
        AccelerationStructureHandleNV dst,
        AccelerationStructureHandleNV src,
        BufferHandle scratch,
        ulong scratchOffset
    );

    [NativeName("vkCmdBuildAccelerationStructureNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBuildAccelerationStructureNV")]
    void CmdBuildAccelerationStructureNV(
        CommandBufferHandle commandBuffer,
        Ref<AccelerationStructureInfoNV> pInfo,
        BufferHandle instanceData,
        ulong instanceOffset,
        MaybeBool<uint> update,
        AccelerationStructureHandleNV dst,
        AccelerationStructureHandleNV src,
        BufferHandle scratch,
        ulong scratchOffset
    );

    [NativeName("vkCmdBuildAccelerationStructuresIndirectKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR")]
    void CmdBuildAccelerationStructuresIndirectKHR(
        CommandBufferHandle commandBuffer,
        uint infoCount,
        AccelerationStructureBuildGeometryInfoKHR* pInfos,
        ulong* pIndirectDeviceAddresses,
        uint* pIndirectStrides,
        uint** ppMaxPrimitiveCounts
    );

    [NativeName("vkCmdBuildAccelerationStructuresIndirectKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR")]
    void CmdBuildAccelerationStructuresIndirectKHR(
        CommandBufferHandle commandBuffer,
        uint infoCount,
        Ref<AccelerationStructureBuildGeometryInfoKHR> pInfos,
        Ref<ulong> pIndirectDeviceAddresses,
        Ref<uint> pIndirectStrides,
        Ref2D<uint> ppMaxPrimitiveCounts
    );

    [NativeName("vkCmdBuildAccelerationStructuresKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBuildAccelerationStructuresKHR")]
    void CmdBuildAccelerationStructuresKHR(
        CommandBufferHandle commandBuffer,
        uint infoCount,
        AccelerationStructureBuildGeometryInfoKHR* pInfos,
        AccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos
    );

    [NativeName("vkCmdBuildAccelerationStructuresKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBuildAccelerationStructuresKHR")]
    void CmdBuildAccelerationStructuresKHR(
        CommandBufferHandle commandBuffer,
        uint infoCount,
        Ref<AccelerationStructureBuildGeometryInfoKHR> pInfos,
        Ref2D<AccelerationStructureBuildRangeInfoKHR> ppBuildRangeInfos
    );

    [NativeName("vkCmdBuildClusterAccelerationStructureIndirectNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBuildClusterAccelerationStructureIndirectNV")]
    void CmdBuildClusterAccelerationStructureIndirectNV(
        CommandBufferHandle commandBuffer,
        ClusterAccelerationStructureCommandsInfoNV* pCommandInfos
    );

    [NativeName("vkCmdBuildClusterAccelerationStructureIndirectNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBuildClusterAccelerationStructureIndirectNV")]
    void CmdBuildClusterAccelerationStructureIndirectNV(
        CommandBufferHandle commandBuffer,
        Ref<ClusterAccelerationStructureCommandsInfoNV> pCommandInfos
    );

    [NativeName("vkCmdBuildMicromapsEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBuildMicromapsEXT")]
    void CmdBuildMicromapEXT(CommandBufferHandle commandBuffer, MicromapBuildInfoEXT pInfos);

    [NativeName("vkCmdBuildMicromapsEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBuildMicromapsEXT")]
    void CmdBuildMicromapsEXT(
        CommandBufferHandle commandBuffer,
        uint infoCount,
        MicromapBuildInfoEXT* pInfos
    );

    [NativeName("vkCmdBuildMicromapsEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBuildMicromapsEXT")]
    void CmdBuildMicromapsEXT(
        CommandBufferHandle commandBuffer,
        uint infoCount,
        Ref<MicromapBuildInfoEXT> pInfos
    );

    [NativeName("vkCmdBuildPartitionedAccelerationStructuresNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBuildPartitionedAccelerationStructuresNV")]
    void CmdBuildPartitionedAccelerationStructuresNV(
        CommandBufferHandle commandBuffer,
        BuildPartitionedAccelerationStructureInfoNV* pBuildInfo
    );

    [NativeName("vkCmdBuildPartitionedAccelerationStructuresNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdBuildPartitionedAccelerationStructuresNV")]
    void CmdBuildPartitionedAccelerationStructuresNV(
        CommandBufferHandle commandBuffer,
        Ref<BuildPartitionedAccelerationStructureInfoNV> pBuildInfo
    );

    [NativeName("vkCmdClearAttachments")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdClearAttachments")]
    void CmdClearAttachments(
        CommandBufferHandle commandBuffer,
        uint attachmentCount,
        ClearAttachment* pAttachments,
        uint rectCount,
        ClearRect* pRects
    );

    [NativeName("vkCmdClearAttachments")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdClearAttachments")]
    void CmdClearAttachments(
        CommandBufferHandle commandBuffer,
        uint attachmentCount,
        Ref<ClearAttachment> pAttachments,
        uint rectCount,
        Ref<ClearRect> pRects
    );

    [NativeName("vkCmdClearColorImage")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdClearColorImage")]
    void CmdClearColorImage(
        CommandBufferHandle commandBuffer,
        ImageHandle image,
        ImageLayout imageLayout,
        ClearColorValue* pColor,
        uint rangeCount,
        ImageSubresourceRange* pRanges
    );

    [NativeName("vkCmdClearColorImage")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdClearColorImage")]
    void CmdClearColorImage(
        CommandBufferHandle commandBuffer,
        ImageHandle image,
        ImageLayout imageLayout,
        Ref<ClearColorValue> pColor,
        uint rangeCount,
        Ref<ImageSubresourceRange> pRanges
    );

    [NativeName("vkCmdClearColorImage")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdClearColorImage")]
    void CmdClearColorImage(
        CommandBufferHandle commandBuffer,
        ImageHandle image,
        ImageLayout imageLayout,
        Ref<ClearColorValue> pColor,
        ImageSubresourceRange pRanges
    );

    [NativeName("vkCmdClearDepthStencilImage")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdClearDepthStencilImage")]
    void CmdClearDepthStencilImage(
        CommandBufferHandle commandBuffer,
        ImageHandle image,
        ImageLayout imageLayout,
        ClearDepthStencilValue* pDepthStencil,
        uint rangeCount,
        ImageSubresourceRange* pRanges
    );

    [NativeName("vkCmdClearDepthStencilImage")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdClearDepthStencilImage")]
    void CmdClearDepthStencilImage(
        CommandBufferHandle commandBuffer,
        ImageHandle image,
        ImageLayout imageLayout,
        Ref<ClearDepthStencilValue> pDepthStencil,
        uint rangeCount,
        Ref<ImageSubresourceRange> pRanges
    );

    [NativeName("vkCmdClearDepthStencilImage")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdClearDepthStencilImage")]
    void CmdClearDepthStencilImage(
        CommandBufferHandle commandBuffer,
        ImageHandle image,
        ImageLayout imageLayout,
        Ref<ClearDepthStencilValue> pDepthStencil,
        ImageSubresourceRange pRanges
    );

    [NativeName("vkCmdControlVideoCodingKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdControlVideoCodingKHR")]
    void CmdControlVideoCodingKHR(
        CommandBufferHandle commandBuffer,
        VideoCodingControlInfoKHR* pCodingControlInfo
    );

    [NativeName("vkCmdControlVideoCodingKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdControlVideoCodingKHR")]
    void CmdControlVideoCodingKHR(
        CommandBufferHandle commandBuffer,
        Ref<VideoCodingControlInfoKHR> pCodingControlInfo
    );

    [NativeName("vkCmdConvertCooperativeVectorMatrixNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdConvertCooperativeVectorMatrixNV")]
    void CmdConvertCooperativeVectorMatrixNV(
        CommandBufferHandle commandBuffer,
        uint infoCount,
        ConvertCooperativeVectorMatrixInfoNV* pInfos
    );

    [NativeName("vkCmdConvertCooperativeVectorMatrixNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdConvertCooperativeVectorMatrixNV")]
    void CmdConvertCooperativeVectorMatrixNV(
        CommandBufferHandle commandBuffer,
        uint infoCount,
        Ref<ConvertCooperativeVectorMatrixInfoNV> pInfos
    );

    [NativeName("vkCmdConvertCooperativeVectorMatrixNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdConvertCooperativeVectorMatrixNV")]
    void CmdConvertCooperativeVectorMatrixNV(
        CommandBufferHandle commandBuffer,
        ConvertCooperativeVectorMatrixInfoNV pInfos
    );

    [NativeName("vkCmdCopyAccelerationStructureKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyAccelerationStructureKHR")]
    void CmdCopyAccelerationStructureKHR(
        CommandBufferHandle commandBuffer,
        CopyAccelerationStructureInfoKHR* pInfo
    );

    [NativeName("vkCmdCopyAccelerationStructureKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyAccelerationStructureKHR")]
    void CmdCopyAccelerationStructureKHR(
        CommandBufferHandle commandBuffer,
        Ref<CopyAccelerationStructureInfoKHR> pInfo
    );

    [NativeName("vkCmdCopyAccelerationStructureNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyAccelerationStructureNV")]
    void CmdCopyAccelerationStructureNV(
        CommandBufferHandle commandBuffer,
        AccelerationStructureHandleNV dst,
        AccelerationStructureHandleNV src,
        CopyAccelerationStructureModeKHR mode
    );

    [NativeName("vkCmdCopyAccelerationStructureToMemoryKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyAccelerationStructureToMemoryKHR")]
    void CmdCopyAccelerationStructureToMemoryKHR(
        CommandBufferHandle commandBuffer,
        CopyAccelerationStructureToMemoryInfoKHR* pInfo
    );

    [NativeName("vkCmdCopyAccelerationStructureToMemoryKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyAccelerationStructureToMemoryKHR")]
    void CmdCopyAccelerationStructureToMemoryKHR(
        CommandBufferHandle commandBuffer,
        Ref<CopyAccelerationStructureToMemoryInfoKHR> pInfo
    );

    [NativeName("vkCmdCopyBuffer")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyBuffer")]
    void CmdCopyBuffer(
        CommandBufferHandle commandBuffer,
        BufferHandle srcBuffer,
        BufferHandle dstBuffer,
        uint regionCount,
        BufferCopy* pRegions
    );

    [NativeName("vkCmdCopyBuffer")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyBuffer")]
    void CmdCopyBuffer(
        CommandBufferHandle commandBuffer,
        BufferHandle srcBuffer,
        BufferHandle dstBuffer,
        uint regionCount,
        Ref<BufferCopy> pRegions
    );

    [NativeName("vkCmdCopyBuffer")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyBuffer")]
    void CmdCopyBuffer(
        CommandBufferHandle commandBuffer,
        BufferHandle srcBuffer,
        BufferHandle dstBuffer,
        BufferCopy pRegions
    );

    [NativeName("vkCmdCopyBuffer2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyBuffer2")]
    void CmdCopyBuffer2(CommandBufferHandle commandBuffer, CopyBufferInfo2* pCopyBufferInfo);

    [NativeName("vkCmdCopyBuffer2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyBuffer2")]
    void CmdCopyBuffer2(CommandBufferHandle commandBuffer, Ref<CopyBufferInfo2> pCopyBufferInfo);

    [NativeName("vkCmdCopyBuffer2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyBuffer2KHR")]
    void CmdCopyBuffer2KHR(CommandBufferHandle commandBuffer, CopyBufferInfo2* pCopyBufferInfo);

    [NativeName("vkCmdCopyBuffer2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyBuffer2KHR")]
    void CmdCopyBuffer2KHR(CommandBufferHandle commandBuffer, Ref<CopyBufferInfo2> pCopyBufferInfo);

    [NativeName("vkCmdCopyBufferToImage")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyBufferToImage")]
    void CmdCopyBufferToImage(
        CommandBufferHandle commandBuffer,
        BufferHandle srcBuffer,
        ImageHandle dstImage,
        ImageLayout dstImageLayout,
        uint regionCount,
        BufferImageCopy* pRegions
    );

    [NativeName("vkCmdCopyBufferToImage")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyBufferToImage")]
    void CmdCopyBufferToImage(
        CommandBufferHandle commandBuffer,
        BufferHandle srcBuffer,
        ImageHandle dstImage,
        ImageLayout dstImageLayout,
        uint regionCount,
        Ref<BufferImageCopy> pRegions
    );

    [NativeName("vkCmdCopyBufferToImage")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyBufferToImage")]
    void CmdCopyBufferToImage(
        CommandBufferHandle commandBuffer,
        BufferHandle srcBuffer,
        ImageHandle dstImage,
        ImageLayout dstImageLayout,
        BufferImageCopy pRegions
    );

    [NativeName("vkCmdCopyBufferToImage2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyBufferToImage2")]
    void CmdCopyBufferToImage2(
        CommandBufferHandle commandBuffer,
        CopyBufferToImageInfo2* pCopyBufferToImageInfo
    );

    [NativeName("vkCmdCopyBufferToImage2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyBufferToImage2")]
    void CmdCopyBufferToImage2(
        CommandBufferHandle commandBuffer,
        Ref<CopyBufferToImageInfo2> pCopyBufferToImageInfo
    );

    [NativeName("vkCmdCopyBufferToImage2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyBufferToImage2KHR")]
    void CmdCopyBufferToImage2KHR(
        CommandBufferHandle commandBuffer,
        CopyBufferToImageInfo2* pCopyBufferToImageInfo
    );

    [NativeName("vkCmdCopyBufferToImage2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyBufferToImage2KHR")]
    void CmdCopyBufferToImage2KHR(
        CommandBufferHandle commandBuffer,
        Ref<CopyBufferToImageInfo2> pCopyBufferToImageInfo
    );

    [NativeName("vkCmdCopyGpaSessionResultsAMD")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyGpaSessionResultsAMD")]
    void CmdCopyGpaSessionResultsAMD(
        CommandBufferHandle commandBuffer,
        GpaSessionHandleAMD gpaSession
    );

    [NativeName("vkCmdCopyImage")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyImage")]
    void CmdCopyImage(
        CommandBufferHandle commandBuffer,
        ImageHandle srcImage,
        ImageLayout srcImageLayout,
        ImageHandle dstImage,
        ImageLayout dstImageLayout,
        uint regionCount,
        ImageCopy* pRegions
    );

    [NativeName("vkCmdCopyImage")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyImage")]
    void CmdCopyImage(
        CommandBufferHandle commandBuffer,
        ImageHandle srcImage,
        ImageLayout srcImageLayout,
        ImageHandle dstImage,
        ImageLayout dstImageLayout,
        uint regionCount,
        Ref<ImageCopy> pRegions
    );

    [NativeName("vkCmdCopyImage")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyImage")]
    void CmdCopyImage(
        CommandBufferHandle commandBuffer,
        ImageHandle srcImage,
        ImageLayout srcImageLayout,
        ImageHandle dstImage,
        ImageLayout dstImageLayout,
        ImageCopy pRegions
    );

    [NativeName("vkCmdCopyImage2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyImage2")]
    void CmdCopyImage2(CommandBufferHandle commandBuffer, CopyImageInfo2* pCopyImageInfo);

    [NativeName("vkCmdCopyImage2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyImage2")]
    void CmdCopyImage2(CommandBufferHandle commandBuffer, Ref<CopyImageInfo2> pCopyImageInfo);

    [NativeName("vkCmdCopyImage2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyImage2KHR")]
    void CmdCopyImage2KHR(CommandBufferHandle commandBuffer, CopyImageInfo2* pCopyImageInfo);

    [NativeName("vkCmdCopyImage2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyImage2KHR")]
    void CmdCopyImage2KHR(CommandBufferHandle commandBuffer, Ref<CopyImageInfo2> pCopyImageInfo);

    [NativeName("vkCmdCopyImageToBuffer")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyImageToBuffer")]
    void CmdCopyImageToBuffer(
        CommandBufferHandle commandBuffer,
        ImageHandle srcImage,
        ImageLayout srcImageLayout,
        BufferHandle dstBuffer,
        uint regionCount,
        BufferImageCopy* pRegions
    );

    [NativeName("vkCmdCopyImageToBuffer")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyImageToBuffer")]
    void CmdCopyImageToBuffer(
        CommandBufferHandle commandBuffer,
        ImageHandle srcImage,
        ImageLayout srcImageLayout,
        BufferHandle dstBuffer,
        uint regionCount,
        Ref<BufferImageCopy> pRegions
    );

    [NativeName("vkCmdCopyImageToBuffer")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyImageToBuffer")]
    void CmdCopyImageToBuffer(
        CommandBufferHandle commandBuffer,
        ImageHandle srcImage,
        ImageLayout srcImageLayout,
        BufferHandle dstBuffer,
        BufferImageCopy pRegions
    );

    [NativeName("vkCmdCopyImageToBuffer2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyImageToBuffer2")]
    void CmdCopyImageToBuffer2(
        CommandBufferHandle commandBuffer,
        CopyImageToBufferInfo2* pCopyImageToBufferInfo
    );

    [NativeName("vkCmdCopyImageToBuffer2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyImageToBuffer2")]
    void CmdCopyImageToBuffer2(
        CommandBufferHandle commandBuffer,
        Ref<CopyImageToBufferInfo2> pCopyImageToBufferInfo
    );

    [NativeName("vkCmdCopyImageToBuffer2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyImageToBuffer2KHR")]
    void CmdCopyImageToBuffer2KHR(
        CommandBufferHandle commandBuffer,
        CopyImageToBufferInfo2* pCopyImageToBufferInfo
    );

    [NativeName("vkCmdCopyImageToBuffer2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyImageToBuffer2KHR")]
    void CmdCopyImageToBuffer2KHR(
        CommandBufferHandle commandBuffer,
        Ref<CopyImageToBufferInfo2> pCopyImageToBufferInfo
    );

    [NativeName("vkCmdCopyImageToMemoryKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyImageToMemoryKHR")]
    void CmdCopyImageToMemoryKHR(
        CommandBufferHandle commandBuffer,
        CopyDeviceMemoryImageInfoKHR* pCopyMemoryInfo
    );

    [NativeName("vkCmdCopyImageToMemoryKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyImageToMemoryKHR")]
    void CmdCopyImageToMemoryKHR(
        CommandBufferHandle commandBuffer,
        Ref<CopyDeviceMemoryImageInfoKHR> pCopyMemoryInfo
    );

    [NativeName("vkCmdCopyMemoryIndirectKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMemoryIndirectKHR")]
    void CmdCopyMemoryIndirectKHR(
        CommandBufferHandle commandBuffer,
        CopyMemoryIndirectInfoKHR* pCopyMemoryIndirectInfo
    );

    [NativeName("vkCmdCopyMemoryIndirectKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMemoryIndirectKHR")]
    void CmdCopyMemoryIndirectKHR(
        CommandBufferHandle commandBuffer,
        Ref<CopyMemoryIndirectInfoKHR> pCopyMemoryIndirectInfo
    );

    [NativeName("vkCmdCopyMemoryIndirectNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMemoryIndirectNV")]
    void CmdCopyMemoryIndirectNV(
        CommandBufferHandle commandBuffer,
        ulong copyBufferAddress,
        uint copyCount,
        uint stride
    );

    [NativeName("vkCmdCopyMemoryKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMemoryKHR")]
    void CmdCopyMemoryKHR(
        CommandBufferHandle commandBuffer,
        CopyDeviceMemoryInfoKHR* pCopyMemoryInfo
    );

    [NativeName("vkCmdCopyMemoryKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMemoryKHR")]
    void CmdCopyMemoryKHR(
        CommandBufferHandle commandBuffer,
        Ref<CopyDeviceMemoryInfoKHR> pCopyMemoryInfo
    );

    [NativeName("vkCmdCopyMemoryToAccelerationStructureKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMemoryToAccelerationStructureKHR")]
    void CmdCopyMemoryToAccelerationStructureKHR(
        CommandBufferHandle commandBuffer,
        CopyMemoryToAccelerationStructureInfoKHR* pInfo
    );

    [NativeName("vkCmdCopyMemoryToAccelerationStructureKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMemoryToAccelerationStructureKHR")]
    void CmdCopyMemoryToAccelerationStructureKHR(
        CommandBufferHandle commandBuffer,
        Ref<CopyMemoryToAccelerationStructureInfoKHR> pInfo
    );

    [NativeName("vkCmdCopyMemoryToImageIndirectKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMemoryToImageIndirectKHR")]
    void CmdCopyMemoryToImageIndirectKHR(
        CommandBufferHandle commandBuffer,
        CopyMemoryToImageIndirectInfoKHR* pCopyMemoryToImageIndirectInfo
    );

    [NativeName("vkCmdCopyMemoryToImageIndirectKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMemoryToImageIndirectKHR")]
    void CmdCopyMemoryToImageIndirectKHR(
        CommandBufferHandle commandBuffer,
        Ref<CopyMemoryToImageIndirectInfoKHR> pCopyMemoryToImageIndirectInfo
    );

    [NativeName("vkCmdCopyMemoryToImageIndirectNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMemoryToImageIndirectNV")]
    void CmdCopyMemoryToImageIndirectNV(
        CommandBufferHandle commandBuffer,
        ulong copyBufferAddress,
        uint copyCount,
        uint stride,
        ImageHandle dstImage,
        ImageLayout dstImageLayout,
        ImageSubresourceLayers* pImageSubresources
    );

    [NativeName("vkCmdCopyMemoryToImageIndirectNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMemoryToImageIndirectNV")]
    void CmdCopyMemoryToImageIndirectNV(
        CommandBufferHandle commandBuffer,
        ulong copyBufferAddress,
        uint copyCount,
        uint stride,
        ImageHandle dstImage,
        ImageLayout dstImageLayout,
        Ref<ImageSubresourceLayers> pImageSubresources
    );

    [NativeName("vkCmdCopyMemoryToImageIndirectNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMemoryToImageIndirectNV")]
    void CmdCopyMemoryToImageIndirectNV(
        CommandBufferHandle commandBuffer,
        ulong copyBufferAddress,
        uint stride,
        ImageHandle dstImage,
        ImageLayout dstImageLayout,
        ImageSubresourceLayers pImageSubresources
    );

    [NativeName("vkCmdCopyMemoryToImageKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMemoryToImageKHR")]
    void CmdCopyMemoryToImageKHR(
        CommandBufferHandle commandBuffer,
        CopyDeviceMemoryImageInfoKHR* pCopyMemoryInfo
    );

    [NativeName("vkCmdCopyMemoryToImageKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMemoryToImageKHR")]
    void CmdCopyMemoryToImageKHR(
        CommandBufferHandle commandBuffer,
        Ref<CopyDeviceMemoryImageInfoKHR> pCopyMemoryInfo
    );

    [NativeName("vkCmdCopyMemoryToMicromapEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMemoryToMicromapEXT")]
    void CmdCopyMemoryToMicromapEXT(
        CommandBufferHandle commandBuffer,
        CopyMemoryToMicromapInfoEXT* pInfo
    );

    [NativeName("vkCmdCopyMemoryToMicromapEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMemoryToMicromapEXT")]
    void CmdCopyMemoryToMicromapEXT(
        CommandBufferHandle commandBuffer,
        Ref<CopyMemoryToMicromapInfoEXT> pInfo
    );

    [NativeName("vkCmdCopyMicromapEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMicromapEXT")]
    void CmdCopyMicromapEXT(CommandBufferHandle commandBuffer, CopyMicromapInfoEXT* pInfo);

    [NativeName("vkCmdCopyMicromapEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMicromapEXT")]
    void CmdCopyMicromapEXT(CommandBufferHandle commandBuffer, Ref<CopyMicromapInfoEXT> pInfo);

    [NativeName("vkCmdCopyMicromapToMemoryEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMicromapToMemoryEXT")]
    void CmdCopyMicromapToMemoryEXT(
        CommandBufferHandle commandBuffer,
        CopyMicromapToMemoryInfoEXT* pInfo
    );

    [NativeName("vkCmdCopyMicromapToMemoryEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyMicromapToMemoryEXT")]
    void CmdCopyMicromapToMemoryEXT(
        CommandBufferHandle commandBuffer,
        Ref<CopyMicromapToMemoryInfoEXT> pInfo
    );

    [NativeName("vkCmdCopyQueryPoolResults")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyQueryPoolResults")]
    void CmdCopyQueryPoolResults(
        CommandBufferHandle commandBuffer,
        QueryPoolHandle queryPool,
        uint firstQuery,
        uint queryCount,
        BufferHandle dstBuffer,
        ulong dstOffset,
        ulong stride,
        QueryResultFlags flags
    );

    [NativeName("vkCmdCopyQueryPoolResultsToMemoryKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyQueryPoolResultsToMemoryKHR")]
    void CmdCopyQueryPoolResultsToMemoryKHR(
        CommandBufferHandle commandBuffer,
        QueryPoolHandle queryPool,
        uint firstQuery,
        uint queryCount,
        StridedDeviceAddressRangeKHR* pDstRange,
        AddressCommandFlagsKHR dstFlags,
        QueryResultFlags queryResultFlags
    );

    [NativeName("vkCmdCopyQueryPoolResultsToMemoryKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyQueryPoolResultsToMemoryKHR")]
    void CmdCopyQueryPoolResultsToMemoryKHR(
        CommandBufferHandle commandBuffer,
        QueryPoolHandle queryPool,
        uint firstQuery,
        uint queryCount,
        Ref<StridedDeviceAddressRangeKHR> pDstRange,
        AddressCommandFlagsKHR dstFlags,
        QueryResultFlags queryResultFlags
    );

    [NativeName("vkCmdCopyTensorARM")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyTensorARM")]
    void CmdCopyTensorARM(CommandBufferHandle commandBuffer, CopyTensorInfoARM* pCopyTensorInfo);

    [NativeName("vkCmdCopyTensorARM")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCopyTensorARM")]
    void CmdCopyTensorARM(
        CommandBufferHandle commandBuffer,
        Ref<CopyTensorInfoARM> pCopyTensorInfo
    );

    [NativeName("vkCmdCuLaunchKernelNVX")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCuLaunchKernelNVX")]
    void CmdCuLaunchKernelNVX(CommandBufferHandle commandBuffer, CuLaunchInfoNVX* pLaunchInfo);

    [NativeName("vkCmdCuLaunchKernelNVX")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdCuLaunchKernelNVX")]
    void CmdCuLaunchKernelNVX(CommandBufferHandle commandBuffer, Ref<CuLaunchInfoNVX> pLaunchInfo);

    [NativeName("vkCmdDebugMarkerBeginEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDebugMarkerBeginEXT")]
    void CmdDebugMarkerBeginEXT(
        CommandBufferHandle commandBuffer,
        DebugMarkerMarkerInfoEXT* pMarkerInfo
    );

    [NativeName("vkCmdDebugMarkerBeginEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDebugMarkerBeginEXT")]
    void CmdDebugMarkerBeginEXT(
        CommandBufferHandle commandBuffer,
        Ref<DebugMarkerMarkerInfoEXT> pMarkerInfo
    );

    [NativeName("vkCmdDebugMarkerEndEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDebugMarkerEndEXT")]
    void CmdDebugMarkerEndEXT(CommandBufferHandle commandBuffer);

    [NativeName("vkCmdDebugMarkerInsertEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDebugMarkerInsertEXT")]
    void CmdDebugMarkerInsertEXT(
        CommandBufferHandle commandBuffer,
        DebugMarkerMarkerInfoEXT* pMarkerInfo
    );

    [NativeName("vkCmdDebugMarkerInsertEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDebugMarkerInsertEXT")]
    void CmdDebugMarkerInsertEXT(
        CommandBufferHandle commandBuffer,
        Ref<DebugMarkerMarkerInfoEXT> pMarkerInfo
    );

    [NativeName("vkCmdDecodeVideoKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDecodeVideoKHR")]
    void CmdDecodeVideoKHR(CommandBufferHandle commandBuffer, VideoDecodeInfoKHR* pDecodeInfo);

    [NativeName("vkCmdDecodeVideoKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDecodeVideoKHR")]
    void CmdDecodeVideoKHR(CommandBufferHandle commandBuffer, Ref<VideoDecodeInfoKHR> pDecodeInfo);

    [NativeName("vkCmdDecompressMemoryEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDecompressMemoryEXT")]
    void CmdDecompressMemoryEXT(
        CommandBufferHandle commandBuffer,
        DecompressMemoryInfoEXT* pDecompressMemoryInfoEXT
    );

    [NativeName("vkCmdDecompressMemoryEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDecompressMemoryEXT")]
    void CmdDecompressMemoryEXT(
        CommandBufferHandle commandBuffer,
        Ref<DecompressMemoryInfoEXT> pDecompressMemoryInfoEXT
    );

    [NativeName("vkCmdDecompressMemoryIndirectCountEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDecompressMemoryIndirectCountEXT")]
    void CmdDecompressMemoryIndirectCountEXT(
        CommandBufferHandle commandBuffer,
        MemoryDecompressionMethodFlagsEXT decompressionMethod,
        ulong indirectCommandsAddress,
        ulong indirectCommandsCountAddress,
        uint maxDecompressionCount,
        uint stride
    );

    [NativeName("vkCmdDecompressMemoryIndirectCountNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDecompressMemoryIndirectCountNV")]
    void CmdDecompressMemoryIndirectCountNV(
        CommandBufferHandle commandBuffer,
        ulong indirectCommandsAddress,
        ulong indirectCommandsCountAddress,
        uint stride
    );

    [NativeName("vkCmdDecompressMemoryNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDecompressMemoryNV")]
    void CmdDecompressMemoryNV(
        CommandBufferHandle commandBuffer,
        uint decompressRegionCount,
        DecompressMemoryRegionNV* pDecompressMemoryRegions
    );

    [NativeName("vkCmdDecompressMemoryNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDecompressMemoryNV")]
    void CmdDecompressMemoryNV(
        CommandBufferHandle commandBuffer,
        uint decompressRegionCount,
        Ref<DecompressMemoryRegionNV> pDecompressMemoryRegions
    );

    [NativeName("vkCmdDecompressMemoryNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDecompressMemoryNV")]
    void CmdDecompressMemoryNV(
        CommandBufferHandle commandBuffer,
        DecompressMemoryRegionNV pDecompressMemoryRegions
    );

    [NativeName("vkCmdDispatch")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDispatch")]
    void CmdDispatch(
        CommandBufferHandle commandBuffer,
        uint groupCountX,
        uint groupCountY,
        uint groupCountZ
    );

    [NativeName("vkCmdDispatchBase")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDispatchBase")]
    void CmdDispatchBase(
        CommandBufferHandle commandBuffer,
        uint baseGroupX,
        uint baseGroupY,
        uint baseGroupZ,
        uint groupCountX,
        uint groupCountY,
        uint groupCountZ
    );

    [NativeName("vkCmdDispatchBaseKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDispatchBaseKHR")]
    void CmdDispatchBaseKHR(
        CommandBufferHandle commandBuffer,
        uint baseGroupX,
        uint baseGroupY,
        uint baseGroupZ,
        uint groupCountX,
        uint groupCountY,
        uint groupCountZ
    );

    [NativeName("vkCmdDispatchDataGraphARM")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDispatchDataGraphARM")]
    void CmdDispatchDataGraphARM(
        CommandBufferHandle commandBuffer,
        DataGraphPipelineSessionHandleARM session,
        DataGraphPipelineDispatchInfoARM* pInfo
    );

    [NativeName("vkCmdDispatchDataGraphARM")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDispatchDataGraphARM")]
    void CmdDispatchDataGraphARM(
        CommandBufferHandle commandBuffer,
        DataGraphPipelineSessionHandleARM session,
        Ref<DataGraphPipelineDispatchInfoARM> pInfo
    );

    [NativeName("vkCmdDispatchIndirect")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDispatchIndirect")]
    void CmdDispatchIndirect(CommandBufferHandle commandBuffer, BufferHandle buffer, ulong offset);

    [NativeName("vkCmdDispatchIndirect2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDispatchIndirect2KHR")]
    void CmdDispatchIndirect2KHR(
        CommandBufferHandle commandBuffer,
        DispatchIndirect2InfoKHR* pInfo
    );

    [NativeName("vkCmdDispatchIndirect2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDispatchIndirect2KHR")]
    void CmdDispatchIndirect2KHR(
        CommandBufferHandle commandBuffer,
        Ref<DispatchIndirect2InfoKHR> pInfo
    );

    [NativeName("vkCmdDispatchTileQCOM")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDispatchTileQCOM")]
    void CmdDispatchTileQCOM(
        CommandBufferHandle commandBuffer,
        DispatchTileInfoQCOM* pDispatchTileInfo
    );

    [NativeName("vkCmdDispatchTileQCOM")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDispatchTileQCOM")]
    void CmdDispatchTileQCOM(
        CommandBufferHandle commandBuffer,
        Ref<DispatchTileInfoQCOM> pDispatchTileInfo
    );

    [NativeName("vkCmdDraw")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDraw")]
    void CmdDraw(
        CommandBufferHandle commandBuffer,
        uint vertexCount,
        uint instanceCount,
        uint firstVertex,
        uint firstInstance
    );

    [NativeName("vkCmdDrawClusterHUAWEI")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawClusterHUAWEI")]
    void CmdDrawClusterHUAWEI(
        CommandBufferHandle commandBuffer,
        uint groupCountX,
        uint groupCountY,
        uint groupCountZ
    );

    [NativeName("vkCmdDrawClusterIndirectHUAWEI")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawClusterIndirectHUAWEI")]
    void CmdDrawClusterIndirectHUAWEI(
        CommandBufferHandle commandBuffer,
        BufferHandle buffer,
        ulong offset
    );

    [NativeName("vkCmdDrawIndexed")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndexed")]
    void CmdDrawIndexed(
        CommandBufferHandle commandBuffer,
        uint indexCount,
        uint instanceCount,
        uint firstIndex,
        int vertexOffset,
        uint firstInstance
    );

    [NativeName("vkCmdDrawIndexedIndirect")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndexedIndirect")]
    void CmdDrawIndexedIndirect(
        CommandBufferHandle commandBuffer,
        BufferHandle buffer,
        ulong offset,
        uint drawCount,
        uint stride
    );

    [NativeName("vkCmdDrawIndexedIndirect2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndexedIndirect2KHR")]
    void CmdDrawIndexedIndirect2KHR(CommandBufferHandle commandBuffer, DrawIndirect2InfoKHR* pInfo);

    [NativeName("vkCmdDrawIndexedIndirect2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndexedIndirect2KHR")]
    void CmdDrawIndexedIndirect2KHR(
        CommandBufferHandle commandBuffer,
        Ref<DrawIndirect2InfoKHR> pInfo
    );

    [NativeName("vkCmdDrawIndexedIndirectCount")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndexedIndirectCount")]
    void CmdDrawIndexedIndirectCount(
        CommandBufferHandle commandBuffer,
        BufferHandle buffer,
        ulong offset,
        BufferHandle countBuffer,
        ulong countBufferOffset,
        uint maxDrawCount,
        uint stride
    );

    [NativeName("vkCmdDrawIndexedIndirectCount2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndexedIndirectCount2KHR")]
    void CmdDrawIndexedIndirectCount2KHR(
        CommandBufferHandle commandBuffer,
        DrawIndirectCount2InfoKHR* pInfo
    );

    [NativeName("vkCmdDrawIndexedIndirectCount2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndexedIndirectCount2KHR")]
    void CmdDrawIndexedIndirectCount2KHR(
        CommandBufferHandle commandBuffer,
        Ref<DrawIndirectCount2InfoKHR> pInfo
    );

    [NativeName("vkCmdDrawIndexedIndirectCountAMD")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndexedIndirectCountAMD")]
    void CmdDrawIndexedIndirectCountAMD(
        CommandBufferHandle commandBuffer,
        BufferHandle buffer,
        ulong offset,
        BufferHandle countBuffer,
        ulong countBufferOffset,
        uint maxDrawCount,
        uint stride
    );

    [NativeName("vkCmdDrawIndexedIndirectCountKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndexedIndirectCountKHR")]
    void CmdDrawIndexedIndirectCountKHR(
        CommandBufferHandle commandBuffer,
        BufferHandle buffer,
        ulong offset,
        BufferHandle countBuffer,
        ulong countBufferOffset,
        uint maxDrawCount,
        uint stride
    );

    [NativeName("vkCmdDrawIndirect")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndirect")]
    void CmdDrawIndirect(
        CommandBufferHandle commandBuffer,
        BufferHandle buffer,
        ulong offset,
        uint drawCount,
        uint stride
    );

    [NativeName("vkCmdDrawIndirect2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndirect2KHR")]
    void CmdDrawIndirect2KHR(CommandBufferHandle commandBuffer, DrawIndirect2InfoKHR* pInfo);

    [NativeName("vkCmdDrawIndirect2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndirect2KHR")]
    void CmdDrawIndirect2KHR(CommandBufferHandle commandBuffer, Ref<DrawIndirect2InfoKHR> pInfo);

    [NativeName("vkCmdDrawIndirectByteCount2EXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndirectByteCount2EXT")]
    void CmdDrawIndirectByteCount2EXT(
        CommandBufferHandle commandBuffer,
        uint instanceCount,
        uint firstInstance,
        BindTransformFeedbackBuffer2InfoEXT* pCounterInfo,
        uint counterOffset,
        uint vertexStride
    );

    [NativeName("vkCmdDrawIndirectByteCount2EXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndirectByteCount2EXT")]
    void CmdDrawIndirectByteCount2EXT(
        CommandBufferHandle commandBuffer,
        uint instanceCount,
        uint firstInstance,
        Ref<BindTransformFeedbackBuffer2InfoEXT> pCounterInfo,
        uint counterOffset,
        uint vertexStride
    );

    [NativeName("vkCmdDrawIndirectByteCountEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndirectByteCountEXT")]
    void CmdDrawIndirectByteCountEXT(
        CommandBufferHandle commandBuffer,
        uint instanceCount,
        uint firstInstance,
        BufferHandle counterBuffer,
        ulong counterBufferOffset,
        uint counterOffset,
        uint vertexStride
    );

    [NativeName("vkCmdDrawIndirectCount")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndirectCount")]
    void CmdDrawIndirectCount(
        CommandBufferHandle commandBuffer,
        BufferHandle buffer,
        ulong offset,
        BufferHandle countBuffer,
        ulong countBufferOffset,
        uint maxDrawCount,
        uint stride
    );

    [NativeName("vkCmdDrawIndirectCount2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndirectCount2KHR")]
    void CmdDrawIndirectCount2KHR(
        CommandBufferHandle commandBuffer,
        DrawIndirectCount2InfoKHR* pInfo
    );

    [NativeName("vkCmdDrawIndirectCount2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndirectCount2KHR")]
    void CmdDrawIndirectCount2KHR(
        CommandBufferHandle commandBuffer,
        Ref<DrawIndirectCount2InfoKHR> pInfo
    );

    [NativeName("vkCmdDrawIndirectCountAMD")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndirectCountAMD")]
    void CmdDrawIndirectCountAMD(
        CommandBufferHandle commandBuffer,
        BufferHandle buffer,
        ulong offset,
        BufferHandle countBuffer,
        ulong countBufferOffset,
        uint maxDrawCount,
        uint stride
    );

    [NativeName("vkCmdDrawIndirectCountKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawIndirectCountKHR")]
    void CmdDrawIndirectCountKHR(
        CommandBufferHandle commandBuffer,
        BufferHandle buffer,
        ulong offset,
        BufferHandle countBuffer,
        ulong countBufferOffset,
        uint maxDrawCount,
        uint stride
    );

    [NativeName("vkCmdDrawMeshTasksEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawMeshTasksEXT")]
    void CmdDrawMeshTasksEXT(
        CommandBufferHandle commandBuffer,
        uint groupCountX,
        uint groupCountY,
        uint groupCountZ
    );

    [NativeName("vkCmdDrawMeshTasksIndirect2EXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawMeshTasksIndirect2EXT")]
    void CmdDrawMeshTasksIndirect2EXT(
        CommandBufferHandle commandBuffer,
        DrawIndirect2InfoKHR* pInfo
    );

    [NativeName("vkCmdDrawMeshTasksIndirect2EXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawMeshTasksIndirect2EXT")]
    void CmdDrawMeshTasksIndirect2EXT(
        CommandBufferHandle commandBuffer,
        Ref<DrawIndirect2InfoKHR> pInfo
    );

    [NativeName("vkCmdDrawMeshTasksIndirectCount2EXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawMeshTasksIndirectCount2EXT")]
    void CmdDrawMeshTasksIndirectCount2EXT(
        CommandBufferHandle commandBuffer,
        DrawIndirectCount2InfoKHR* pInfo
    );

    [NativeName("vkCmdDrawMeshTasksIndirectCount2EXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawMeshTasksIndirectCount2EXT")]
    void CmdDrawMeshTasksIndirectCount2EXT(
        CommandBufferHandle commandBuffer,
        Ref<DrawIndirectCount2InfoKHR> pInfo
    );

    [NativeName("vkCmdDrawMeshTasksIndirectCountEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawMeshTasksIndirectCountEXT")]
    void CmdDrawMeshTasksIndirectCountEXT(
        CommandBufferHandle commandBuffer,
        BufferHandle buffer,
        ulong offset,
        BufferHandle countBuffer,
        ulong countBufferOffset,
        uint maxDrawCount,
        uint stride
    );

    [NativeName("vkCmdDrawMeshTasksIndirectCountNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawMeshTasksIndirectCountNV")]
    void CmdDrawMeshTasksIndirectCountNV(
        CommandBufferHandle commandBuffer,
        BufferHandle buffer,
        ulong offset,
        BufferHandle countBuffer,
        ulong countBufferOffset,
        uint maxDrawCount,
        uint stride
    );

    [NativeName("vkCmdDrawMeshTasksIndirectEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawMeshTasksIndirectEXT")]
    void CmdDrawMeshTasksIndirectEXT(
        CommandBufferHandle commandBuffer,
        BufferHandle buffer,
        ulong offset,
        uint drawCount,
        uint stride
    );

    [NativeName("vkCmdDrawMeshTasksIndirectNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawMeshTasksIndirectNV")]
    void CmdDrawMeshTasksIndirectNV(
        CommandBufferHandle commandBuffer,
        BufferHandle buffer,
        ulong offset,
        uint drawCount,
        uint stride
    );

    [NativeName("vkCmdDrawMeshTasksNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawMeshTasksNV")]
    void CmdDrawMeshTasksNV(CommandBufferHandle commandBuffer, uint taskCount, uint firstTask);

    [NativeName("vkCmdDrawMultiEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawMultiEXT")]
    void CmdDrawMultiEXT(
        CommandBufferHandle commandBuffer,
        uint drawCount,
        MultiDrawInfoEXT* pVertexInfo,
        uint instanceCount,
        uint firstInstance,
        uint stride
    );

    [NativeName("vkCmdDrawMultiEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawMultiEXT")]
    void CmdDrawMultiEXT(
        CommandBufferHandle commandBuffer,
        uint drawCount,
        Ref<MultiDrawInfoEXT> pVertexInfo,
        uint instanceCount,
        uint firstInstance,
        uint stride
    );

    [NativeName("vkCmdDrawMultiEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawMultiEXT")]
    void CmdDrawMultiEXT(
        CommandBufferHandle commandBuffer,
        MultiDrawInfoEXT pVertexInfo,
        uint instanceCount,
        uint firstInstance,
        uint stride
    );

    [NativeName("vkCmdDrawMultiIndexedEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawMultiIndexedEXT")]
    void CmdDrawMultiIndexedEXT(
        CommandBufferHandle commandBuffer,
        uint drawCount,
        MultiDrawIndexedInfoEXT* pIndexInfo,
        uint instanceCount,
        uint firstInstance,
        uint stride,
        int* pVertexOffset
    );

    [NativeName("vkCmdDrawMultiIndexedEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawMultiIndexedEXT")]
    void CmdDrawMultiIndexedEXT(
        CommandBufferHandle commandBuffer,
        uint drawCount,
        Ref<MultiDrawIndexedInfoEXT> pIndexInfo,
        uint instanceCount,
        uint firstInstance,
        uint stride,
        Ref<int> pVertexOffset
    );

    [NativeName("vkCmdDrawMultiIndexedEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdDrawMultiIndexedEXT")]
    void CmdDrawMultiIndexedEXT(
        CommandBufferHandle commandBuffer,
        MultiDrawIndexedInfoEXT pIndexInfo,
        uint instanceCount,
        uint firstInstance,
        uint stride,
        Ref<int> pVertexOffset
    );

    [NativeName("vkCmdEncodeVideoKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdEncodeVideoKHR")]
    void CmdEncodeVideoKHR(CommandBufferHandle commandBuffer, VideoEncodeInfoKHR* pEncodeInfo);

    [NativeName("vkCmdEncodeVideoKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdEncodeVideoKHR")]
    void CmdEncodeVideoKHR(CommandBufferHandle commandBuffer, Ref<VideoEncodeInfoKHR> pEncodeInfo);

    [NativeName("vkCmdEndConditionalRenderingEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdEndConditionalRenderingEXT")]
    void CmdEndConditionalRenderingEXT(CommandBufferHandle commandBuffer);

    [NativeName("vkCmdEndDebugUtilsLabelEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdEndDebugUtilsLabelEXT")]
    void CmdEndDebugUtilsLabelEXT(CommandBufferHandle commandBuffer);

    [NativeName("vkCmdEndGpaSampleAMD")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdEndGpaSampleAMD")]
    void CmdEndGpaSampleAMD(
        CommandBufferHandle commandBuffer,
        GpaSessionHandleAMD gpaSession,
        uint sampleID
    );

    [NativeName("vkCmdEndGpaSessionAMD")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdEndGpaSessionAMD")]
    Result CmdEndGpaSessionAMD(CommandBufferHandle commandBuffer, GpaSessionHandleAMD gpaSession);

    [NativeName("vkCmdEndPerTileExecutionQCOM")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdEndPerTileExecutionQCOM")]
    void CmdEndPerTileExecutionQCOM(
        CommandBufferHandle commandBuffer,
        PerTileEndInfoQCOM* pPerTileEndInfo
    );

    [NativeName("vkCmdEndPerTileExecutionQCOM")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdEndPerTileExecutionQCOM")]
    void CmdEndPerTileExecutionQCOM(
        CommandBufferHandle commandBuffer,
        Ref<PerTileEndInfoQCOM> pPerTileEndInfo
    );

    [NativeName("vkCmdEndQuery")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdEndQuery")]
    void CmdEndQuery(CommandBufferHandle commandBuffer, QueryPoolHandle queryPool, uint query);

    [NativeName("vkCmdEndQueryIndexedEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdEndQueryIndexedEXT")]
    void CmdEndQueryIndexedEXT(
        CommandBufferHandle commandBuffer,
        QueryPoolHandle queryPool,
        uint query,
        uint index
    );

    [NativeName("vkCmdEndRendering")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdEndRendering")]
    void CmdEndRendering(CommandBufferHandle commandBuffer);

    [NativeName("vkCmdEndRendering2EXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdEndRendering2EXT")]
    void CmdEndRendering2EXT(
        CommandBufferHandle commandBuffer,
        RenderingEndInfoKHR* pRenderingEndInfo
    );

    [NativeName("vkCmdEndRendering2EXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdEndRendering2EXT")]
    void CmdEndRendering2EXT(
        CommandBufferHandle commandBuffer,
        Ref<RenderingEndInfoKHR> pRenderingEndInfo
    );

    [NativeName("vkCmdEndRendering2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdEndRendering2KHR")]
    void CmdEndRendering2KHR(
        CommandBufferHandle commandBuffer,
        RenderingEndInfoKHR* pRenderingEndInfo
    );

    [NativeName("vkCmdEndRendering2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdEndRendering2KHR")]
    void CmdEndRendering2KHR(
        CommandBufferHandle commandBuffer,
        Ref<RenderingEndInfoKHR> pRenderingEndInfo
    );

    [NativeName("vkCmdEndRenderingKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdEndRenderingKHR")]
    void CmdEndRenderingKHR(CommandBufferHandle commandBuffer);

    [NativeName("vkCmdEndRenderPass")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdEndRenderPass")]
    void CmdEndRenderPass(CommandBufferHandle commandBuffer);

    [NativeName("vkCmdEndRenderPass2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdEndRenderPass2")]
    void CmdEndRenderPass2(CommandBufferHandle commandBuffer, SubpassEndInfo* pSubpassEndInfo);

    [NativeName("vkCmdEndRenderPass2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdEndRenderPass2")]
    void CmdEndRenderPass2(CommandBufferHandle commandBuffer, Ref<SubpassEndInfo> pSubpassEndInfo);

    [NativeName("vkCmdEndRenderPass2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdEndRenderPass2KHR")]
    void CmdEndRenderPass2KHR(CommandBufferHandle commandBuffer, SubpassEndInfo* pSubpassEndInfo);

    [NativeName("vkCmdEndRenderPass2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdEndRenderPass2KHR")]
    void CmdEndRenderPass2KHR(
        CommandBufferHandle commandBuffer,
        Ref<SubpassEndInfo> pSubpassEndInfo
    );

    [NativeName("vkCmdEndShaderInstrumentationARM")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdEndShaderInstrumentationARM")]
    void CmdEndShaderInstrumentationARM(CommandBufferHandle commandBuffer);

    [NativeName("vkCmdEndTransformFeedback2EXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdEndTransformFeedback2EXT")]
    void CmdEndTransformFeedback2EXT(
        CommandBufferHandle commandBuffer,
        uint firstCounterRange,
        uint counterRangeCount,
        BindTransformFeedbackBuffer2InfoEXT* pCounterInfos
    );

    [NativeName("vkCmdEndTransformFeedback2EXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdEndTransformFeedback2EXT")]
    void CmdEndTransformFeedback2EXT(
        CommandBufferHandle commandBuffer,
        uint firstCounterRange,
        uint counterRangeCount,
        Ref<BindTransformFeedbackBuffer2InfoEXT> pCounterInfos
    );

    [NativeName("vkCmdEndTransformFeedback2EXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdEndTransformFeedback2EXT")]
    void CmdEndTransformFeedback2EXT(
        CommandBufferHandle commandBuffer,
        uint firstCounterRange,
        BindTransformFeedbackBuffer2InfoEXT pCounterInfos
    );

    [NativeName("vkCmdEndTransformFeedbackEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdEndTransformFeedbackEXT")]
    void CmdEndTransformFeedbackEXT(
        CommandBufferHandle commandBuffer,
        uint firstCounterBuffer,
        uint counterBufferCount,
        BufferHandle* pCounterBuffers,
        ulong* pCounterBufferOffsets
    );

    [NativeName("vkCmdEndTransformFeedbackEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdEndTransformFeedbackEXT")]
    void CmdEndTransformFeedbackEXT(
        CommandBufferHandle commandBuffer,
        uint firstCounterBuffer,
        uint counterBufferCount,
        Ref<BufferHandle> pCounterBuffers,
        Ref<ulong> pCounterBufferOffsets
    );

    [NativeName("vkCmdEndVideoCodingKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdEndVideoCodingKHR")]
    void CmdEndVideoCodingKHR(
        CommandBufferHandle commandBuffer,
        VideoEndCodingInfoKHR* pEndCodingInfo
    );

    [NativeName("vkCmdEndVideoCodingKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdEndVideoCodingKHR")]
    void CmdEndVideoCodingKHR(
        CommandBufferHandle commandBuffer,
        Ref<VideoEndCodingInfoKHR> pEndCodingInfo
    );

    [NativeName("vkCmdExecuteCommands")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdExecuteCommands")]
    void CmdExecuteCommand(CommandBufferHandle commandBuffer, CommandBufferHandle pCommandBuffers);

    [NativeName("vkCmdExecuteCommands")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdExecuteCommands")]
    void CmdExecuteCommands(
        CommandBufferHandle commandBuffer,
        uint commandBufferCount,
        CommandBufferHandle* pCommandBuffers
    );

    [NativeName("vkCmdExecuteCommands")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdExecuteCommands")]
    void CmdExecuteCommands(
        CommandBufferHandle commandBuffer,
        uint commandBufferCount,
        Ref<CommandBufferHandle> pCommandBuffers
    );

    [NativeName("vkCmdExecuteGeneratedCommandsEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdExecuteGeneratedCommandsEXT")]
    void CmdExecuteGeneratedCommandsEXT(
        CommandBufferHandle commandBuffer,
        uint isPreprocessed,
        GeneratedCommandsInfoEXT* pGeneratedCommandsInfo
    );

    [NativeName("vkCmdExecuteGeneratedCommandsEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdExecuteGeneratedCommandsEXT")]
    void CmdExecuteGeneratedCommandsEXT(
        CommandBufferHandle commandBuffer,
        MaybeBool<uint> isPreprocessed,
        Ref<GeneratedCommandsInfoEXT> pGeneratedCommandsInfo
    );

    [NativeName("vkCmdExecuteGeneratedCommandsNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdExecuteGeneratedCommandsNV")]
    void CmdExecuteGeneratedCommandsNV(
        CommandBufferHandle commandBuffer,
        uint isPreprocessed,
        GeneratedCommandsInfoNV* pGeneratedCommandsInfo
    );

    [NativeName("vkCmdExecuteGeneratedCommandsNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdExecuteGeneratedCommandsNV")]
    void CmdExecuteGeneratedCommandsNV(
        CommandBufferHandle commandBuffer,
        MaybeBool<uint> isPreprocessed,
        Ref<GeneratedCommandsInfoNV> pGeneratedCommandsInfo
    );

    [NativeName("vkCmdFillBuffer")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdFillBuffer")]
    void CmdFillBuffer(
        CommandBufferHandle commandBuffer,
        BufferHandle dstBuffer,
        ulong dstOffset,
        ulong size,
        uint data
    );

    [NativeName("vkCmdFillMemoryKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdFillMemoryKHR")]
    void CmdFillMemoryKHR(
        CommandBufferHandle commandBuffer,
        DeviceAddressRangeKHR* pDstRange,
        AddressCommandFlagsKHR dstFlags,
        uint data
    );

    [NativeName("vkCmdFillMemoryKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdFillMemoryKHR")]
    void CmdFillMemoryKHR(
        CommandBufferHandle commandBuffer,
        Ref<DeviceAddressRangeKHR> pDstRange,
        AddressCommandFlagsKHR dstFlags,
        uint data
    );

    [NativeName("vkCmdInsertDebugUtilsLabelEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdInsertDebugUtilsLabelEXT")]
    void CmdInsertDebugUtilsLabelEXT(
        CommandBufferHandle commandBuffer,
        DebugUtilsLabelEXT* pLabelInfo
    );

    [NativeName("vkCmdInsertDebugUtilsLabelEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdInsertDebugUtilsLabelEXT")]
    void CmdInsertDebugUtilsLabelEXT(
        CommandBufferHandle commandBuffer,
        Ref<DebugUtilsLabelEXT> pLabelInfo
    );

    [NativeName("vkCmdNextSubpass")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdNextSubpass")]
    void CmdNextSubpass(CommandBufferHandle commandBuffer, SubpassContents contents);

    [NativeName("vkCmdNextSubpass2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdNextSubpass2")]
    void CmdNextSubpass2(
        CommandBufferHandle commandBuffer,
        SubpassBeginInfo* pSubpassBeginInfo,
        SubpassEndInfo* pSubpassEndInfo
    );

    [NativeName("vkCmdNextSubpass2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdNextSubpass2")]
    void CmdNextSubpass2(
        CommandBufferHandle commandBuffer,
        Ref<SubpassBeginInfo> pSubpassBeginInfo,
        Ref<SubpassEndInfo> pSubpassEndInfo
    );

    [NativeName("vkCmdNextSubpass2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdNextSubpass2KHR")]
    void CmdNextSubpass2KHR(
        CommandBufferHandle commandBuffer,
        SubpassBeginInfo* pSubpassBeginInfo,
        SubpassEndInfo* pSubpassEndInfo
    );

    [NativeName("vkCmdNextSubpass2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdNextSubpass2KHR")]
    void CmdNextSubpass2KHR(
        CommandBufferHandle commandBuffer,
        Ref<SubpassBeginInfo> pSubpassBeginInfo,
        Ref<SubpassEndInfo> pSubpassEndInfo
    );

    [NativeName("vkCmdOpticalFlowExecuteNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdOpticalFlowExecuteNV")]
    void CmdOpticalFlowExecuteNV(
        CommandBufferHandle commandBuffer,
        OpticalFlowSessionHandleNV session,
        OpticalFlowExecuteInfoNV* pExecuteInfo
    );

    [NativeName("vkCmdOpticalFlowExecuteNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdOpticalFlowExecuteNV")]
    void CmdOpticalFlowExecuteNV(
        CommandBufferHandle commandBuffer,
        OpticalFlowSessionHandleNV session,
        Ref<OpticalFlowExecuteInfoNV> pExecuteInfo
    );

    [NativeName("vkCmdPipelineBarrier")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPipelineBarrier")]
    void CmdPipelineBarrier(
        CommandBufferHandle commandBuffer,
        PipelineStageFlags srcStageMask,
        PipelineStageFlags dstStageMask,
        DependencyFlags dependencyFlags,
        uint memoryBarrierCount,
        MemoryBarrier* pMemoryBarriers,
        uint bufferMemoryBarrierCount,
        BufferMemoryBarrier* pBufferMemoryBarriers,
        uint imageMemoryBarrierCount,
        ImageMemoryBarrier* pImageMemoryBarriers
    );

    [NativeName("vkCmdPipelineBarrier")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPipelineBarrier")]
    void CmdPipelineBarrier(
        CommandBufferHandle commandBuffer,
        PipelineStageFlags srcStageMask,
        PipelineStageFlags dstStageMask,
        DependencyFlags dependencyFlags,
        uint memoryBarrierCount,
        Ref<MemoryBarrier> pMemoryBarriers,
        uint bufferMemoryBarrierCount,
        Ref<BufferMemoryBarrier> pBufferMemoryBarriers,
        uint imageMemoryBarrierCount,
        Ref<ImageMemoryBarrier> pImageMemoryBarriers
    );

    [NativeName("vkCmdPipelineBarrier2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPipelineBarrier2")]
    void CmdPipelineBarrier2(CommandBufferHandle commandBuffer, DependencyInfo* pDependencyInfo);

    [NativeName("vkCmdPipelineBarrier2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPipelineBarrier2")]
    void CmdPipelineBarrier2(
        CommandBufferHandle commandBuffer,
        Ref<DependencyInfo> pDependencyInfo
    );

    [NativeName("vkCmdPipelineBarrier2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPipelineBarrier2KHR")]
    void CmdPipelineBarrier2KHR(CommandBufferHandle commandBuffer, DependencyInfo* pDependencyInfo);

    [NativeName("vkCmdPipelineBarrier2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPipelineBarrier2KHR")]
    void CmdPipelineBarrier2KHR(
        CommandBufferHandle commandBuffer,
        Ref<DependencyInfo> pDependencyInfo
    );

    [NativeName("vkCmdPreprocessGeneratedCommandsEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPreprocessGeneratedCommandsEXT")]
    void CmdPreprocessGeneratedCommandsEXT(
        CommandBufferHandle commandBuffer,
        GeneratedCommandsInfoEXT* pGeneratedCommandsInfo,
        CommandBufferHandle stateCommandBuffer
    );

    [NativeName("vkCmdPreprocessGeneratedCommandsEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPreprocessGeneratedCommandsEXT")]
    void CmdPreprocessGeneratedCommandsEXT(
        CommandBufferHandle commandBuffer,
        Ref<GeneratedCommandsInfoEXT> pGeneratedCommandsInfo,
        CommandBufferHandle stateCommandBuffer
    );

    [NativeName("vkCmdPreprocessGeneratedCommandsNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPreprocessGeneratedCommandsNV")]
    void CmdPreprocessGeneratedCommandsNV(
        CommandBufferHandle commandBuffer,
        GeneratedCommandsInfoNV* pGeneratedCommandsInfo
    );

    [NativeName("vkCmdPreprocessGeneratedCommandsNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPreprocessGeneratedCommandsNV")]
    void CmdPreprocessGeneratedCommandsNV(
        CommandBufferHandle commandBuffer,
        Ref<GeneratedCommandsInfoNV> pGeneratedCommandsInfo
    );

    [NativeName("vkCmdPushConstants")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPushConstants")]
    void CmdPushConstants(
        CommandBufferHandle commandBuffer,
        PipelineLayoutHandle layout,
        ShaderStageFlags stageFlags,
        uint offset,
        uint size,
        void* pValues
    );

    [NativeName("vkCmdPushConstants")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPushConstants")]
    void CmdPushConstants(
        CommandBufferHandle commandBuffer,
        PipelineLayoutHandle layout,
        ShaderStageFlags stageFlags,
        uint offset,
        uint size,
        Ref pValues
    );

    [NativeName("vkCmdPushConstants2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPushConstants2")]
    void CmdPushConstants2(
        CommandBufferHandle commandBuffer,
        PushConstantsInfo* pPushConstantsInfo
    );

    [NativeName("vkCmdPushConstants2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPushConstants2")]
    void CmdPushConstants2(
        CommandBufferHandle commandBuffer,
        Ref<PushConstantsInfo> pPushConstantsInfo
    );

    [NativeName("vkCmdPushConstants2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPushConstants2KHR")]
    void CmdPushConstants2KHR(
        CommandBufferHandle commandBuffer,
        PushConstantsInfo* pPushConstantsInfo
    );

    [NativeName("vkCmdPushConstants2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPushConstants2KHR")]
    void CmdPushConstants2KHR(
        CommandBufferHandle commandBuffer,
        Ref<PushConstantsInfo> pPushConstantsInfo
    );

    [NativeName("vkCmdPushDataEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPushDataEXT")]
    void CmdPushDataEXT(CommandBufferHandle commandBuffer, PushDataInfoEXT* pPushDataInfo);

    [NativeName("vkCmdPushDataEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPushDataEXT")]
    void CmdPushDataEXT(CommandBufferHandle commandBuffer, Ref<PushDataInfoEXT> pPushDataInfo);

    [NativeName("vkCmdPushDescriptorSet")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSet")]
    void CmdPushDescriptorSet(
        CommandBufferHandle commandBuffer,
        PipelineBindPoint pipelineBindPoint,
        PipelineLayoutHandle layout,
        uint set,
        uint descriptorWriteCount,
        WriteDescriptorSet* pDescriptorWrites
    );

    [NativeName("vkCmdPushDescriptorSet")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSet")]
    void CmdPushDescriptorSet(
        CommandBufferHandle commandBuffer,
        PipelineBindPoint pipelineBindPoint,
        PipelineLayoutHandle layout,
        uint set,
        uint descriptorWriteCount,
        Ref<WriteDescriptorSet> pDescriptorWrites
    );

    [NativeName("vkCmdPushDescriptorSet")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSet")]
    void CmdPushDescriptorSet(
        CommandBufferHandle commandBuffer,
        PipelineBindPoint pipelineBindPoint,
        PipelineLayoutHandle layout,
        uint set,
        WriteDescriptorSet pDescriptorWrites
    );

    [NativeName("vkCmdPushDescriptorSet2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSet2")]
    void CmdPushDescriptorSet2(
        CommandBufferHandle commandBuffer,
        PushDescriptorSetInfo* pPushDescriptorSetInfo
    );

    [NativeName("vkCmdPushDescriptorSet2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSet2")]
    void CmdPushDescriptorSet2(
        CommandBufferHandle commandBuffer,
        Ref<PushDescriptorSetInfo> pPushDescriptorSetInfo
    );

    [NativeName("vkCmdPushDescriptorSet2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSet2KHR")]
    void CmdPushDescriptorSet2KHR(
        CommandBufferHandle commandBuffer,
        PushDescriptorSetInfo* pPushDescriptorSetInfo
    );

    [NativeName("vkCmdPushDescriptorSet2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSet2KHR")]
    void CmdPushDescriptorSet2KHR(
        CommandBufferHandle commandBuffer,
        Ref<PushDescriptorSetInfo> pPushDescriptorSetInfo
    );

    [NativeName("vkCmdPushDescriptorSetKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSetKHR")]
    void CmdPushDescriptorSetKHR(
        CommandBufferHandle commandBuffer,
        PipelineBindPoint pipelineBindPoint,
        PipelineLayoutHandle layout,
        uint set,
        uint descriptorWriteCount,
        WriteDescriptorSet* pDescriptorWrites
    );

    [NativeName("vkCmdPushDescriptorSetKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSetKHR")]
    void CmdPushDescriptorSetKHR(
        CommandBufferHandle commandBuffer,
        PipelineBindPoint pipelineBindPoint,
        PipelineLayoutHandle layout,
        uint set,
        uint descriptorWriteCount,
        Ref<WriteDescriptorSet> pDescriptorWrites
    );

    [NativeName("vkCmdPushDescriptorSetKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSetKHR")]
    void CmdPushDescriptorSetKHR(
        CommandBufferHandle commandBuffer,
        PipelineBindPoint pipelineBindPoint,
        PipelineLayoutHandle layout,
        uint set,
        WriteDescriptorSet pDescriptorWrites
    );

    [NativeName("vkCmdPushDescriptorSetWithTemplate")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSetWithTemplate")]
    void CmdPushDescriptorSetWithTemplate(
        CommandBufferHandle commandBuffer,
        DescriptorUpdateTemplateHandle descriptorUpdateTemplate,
        PipelineLayoutHandle layout,
        uint set,
        void* pData
    );

    [NativeName("vkCmdPushDescriptorSetWithTemplate")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSetWithTemplate")]
    void CmdPushDescriptorSetWithTemplate(
        CommandBufferHandle commandBuffer,
        DescriptorUpdateTemplateHandle descriptorUpdateTemplate,
        PipelineLayoutHandle layout,
        uint set,
        Ref pData
    );

    [NativeName("vkCmdPushDescriptorSetWithTemplate2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSetWithTemplate2")]
    void CmdPushDescriptorSetWithTemplate2(
        CommandBufferHandle commandBuffer,
        PushDescriptorSetWithTemplateInfo* pPushDescriptorSetWithTemplateInfo
    );

    [NativeName("vkCmdPushDescriptorSetWithTemplate2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSetWithTemplate2")]
    void CmdPushDescriptorSetWithTemplate2(
        CommandBufferHandle commandBuffer,
        Ref<PushDescriptorSetWithTemplateInfo> pPushDescriptorSetWithTemplateInfo
    );

    [NativeName("vkCmdPushDescriptorSetWithTemplate2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSetWithTemplate2KHR")]
    void CmdPushDescriptorSetWithTemplate2KHR(
        CommandBufferHandle commandBuffer,
        PushDescriptorSetWithTemplateInfo* pPushDescriptorSetWithTemplateInfo
    );

    [NativeName("vkCmdPushDescriptorSetWithTemplate2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSetWithTemplate2KHR")]
    void CmdPushDescriptorSetWithTemplate2KHR(
        CommandBufferHandle commandBuffer,
        Ref<PushDescriptorSetWithTemplateInfo> pPushDescriptorSetWithTemplateInfo
    );

    [NativeName("vkCmdPushDescriptorSetWithTemplateKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSetWithTemplateKHR")]
    void CmdPushDescriptorSetWithTemplateKHR(
        CommandBufferHandle commandBuffer,
        DescriptorUpdateTemplateHandle descriptorUpdateTemplate,
        PipelineLayoutHandle layout,
        uint set,
        void* pData
    );

    [NativeName("vkCmdPushDescriptorSetWithTemplateKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdPushDescriptorSetWithTemplateKHR")]
    void CmdPushDescriptorSetWithTemplateKHR(
        CommandBufferHandle commandBuffer,
        DescriptorUpdateTemplateHandle descriptorUpdateTemplate,
        PipelineLayoutHandle layout,
        uint set,
        Ref pData
    );

    [NativeName("vkCmdResetEvent")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdResetEvent")]
    void CmdResetEvent(
        CommandBufferHandle commandBuffer,
        EventHandle @event,
        PipelineStageFlags stageMask
    );

    [NativeName("vkCmdResetEvent2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdResetEvent2")]
    void CmdResetEvent2(
        CommandBufferHandle commandBuffer,
        EventHandle @event,
        PipelineStageFlags2 stageMask
    );

    [NativeName("vkCmdResetEvent2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdResetEvent2KHR")]
    void CmdResetEvent2KHR(
        CommandBufferHandle commandBuffer,
        EventHandle @event,
        PipelineStageFlags2 stageMask
    );

    [NativeName("vkCmdResetQueryPool")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdResetQueryPool")]
    void CmdResetQueryPool(
        CommandBufferHandle commandBuffer,
        QueryPoolHandle queryPool,
        uint firstQuery,
        uint queryCount
    );

    [NativeName("vkCmdResolveImage")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdResolveImage")]
    void CmdResolveImage(
        CommandBufferHandle commandBuffer,
        ImageHandle srcImage,
        ImageLayout srcImageLayout,
        ImageHandle dstImage,
        ImageLayout dstImageLayout,
        uint regionCount,
        ImageResolve* pRegions
    );

    [NativeName("vkCmdResolveImage")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdResolveImage")]
    void CmdResolveImage(
        CommandBufferHandle commandBuffer,
        ImageHandle srcImage,
        ImageLayout srcImageLayout,
        ImageHandle dstImage,
        ImageLayout dstImageLayout,
        uint regionCount,
        Ref<ImageResolve> pRegions
    );

    [NativeName("vkCmdResolveImage")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdResolveImage")]
    void CmdResolveImage(
        CommandBufferHandle commandBuffer,
        ImageHandle srcImage,
        ImageLayout srcImageLayout,
        ImageHandle dstImage,
        ImageLayout dstImageLayout,
        ImageResolve pRegions
    );

    [NativeName("vkCmdResolveImage2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdResolveImage2")]
    void CmdResolveImage2(CommandBufferHandle commandBuffer, ResolveImageInfo2* pResolveImageInfo);

    [NativeName("vkCmdResolveImage2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdResolveImage2")]
    void CmdResolveImage2(
        CommandBufferHandle commandBuffer,
        Ref<ResolveImageInfo2> pResolveImageInfo
    );

    [NativeName("vkCmdResolveImage2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdResolveImage2KHR")]
    void CmdResolveImage2KHR(
        CommandBufferHandle commandBuffer,
        ResolveImageInfo2* pResolveImageInfo
    );

    [NativeName("vkCmdResolveImage2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdResolveImage2KHR")]
    void CmdResolveImage2KHR(
        CommandBufferHandle commandBuffer,
        Ref<ResolveImageInfo2> pResolveImageInfo
    );

    [NativeName("vkCmdSetAlphaToCoverageEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetAlphaToCoverageEnableEXT")]
    void CmdSetAlphaToCoverageEnableEXT(
        CommandBufferHandle commandBuffer,
        uint alphaToCoverageEnable
    );

    [NativeName("vkCmdSetAlphaToCoverageEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetAlphaToCoverageEnableEXT")]
    void CmdSetAlphaToCoverageEnableEXT(
        CommandBufferHandle commandBuffer,
        MaybeBool<uint> alphaToCoverageEnable
    );

    [NativeName("vkCmdSetAlphaToOneEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetAlphaToOneEnableEXT")]
    void CmdSetAlphaToOneEnableEXT(CommandBufferHandle commandBuffer, uint alphaToOneEnable);

    [NativeName("vkCmdSetAlphaToOneEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetAlphaToOneEnableEXT")]
    void CmdSetAlphaToOneEnableEXT(
        CommandBufferHandle commandBuffer,
        MaybeBool<uint> alphaToOneEnable
    );

    [NativeName("vkCmdSetAttachmentFeedbackLoopEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetAttachmentFeedbackLoopEnableEXT")]
    void CmdSetAttachmentFeedbackLoopEnableEXT(
        CommandBufferHandle commandBuffer,
        ImageAspectFlags aspectMask
    );

    [NativeName("vkCmdSetBlendConstants")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetBlendConstants")]
    void CmdSetBlendConstants(CommandBufferHandle commandBuffer, float* blendConstants);

    [NativeName("vkCmdSetBlendConstants")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetBlendConstants")]
    void CmdSetBlendConstants(CommandBufferHandle commandBuffer, Ref<float> blendConstants);

    [NativeName("vkCmdSetCheckpointNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetCheckpointNV")]
    void CmdSetCheckpointNV(CommandBufferHandle commandBuffer, void* pCheckpointMarker);

    [NativeName("vkCmdSetCheckpointNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetCheckpointNV")]
    void CmdSetCheckpointNV(CommandBufferHandle commandBuffer, Ref pCheckpointMarker);

    [NativeName("vkCmdSetCoarseSampleOrderNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetCoarseSampleOrderNV")]
    void CmdSetCoarseSampleOrderNV(
        CommandBufferHandle commandBuffer,
        CoarseSampleOrderTypeNV sampleOrderType,
        uint customSampleOrderCount,
        CoarseSampleOrderCustomNV* pCustomSampleOrders
    );

    [NativeName("vkCmdSetCoarseSampleOrderNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetCoarseSampleOrderNV")]
    void CmdSetCoarseSampleOrderNV(
        CommandBufferHandle commandBuffer,
        CoarseSampleOrderTypeNV sampleOrderType,
        uint customSampleOrderCount,
        Ref<CoarseSampleOrderCustomNV> pCustomSampleOrders
    );

    [NativeName("vkCmdSetCoarseSampleOrderNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetCoarseSampleOrderNV")]
    void CmdSetCoarseSampleOrderNV(
        CommandBufferHandle commandBuffer,
        CoarseSampleOrderTypeNV sampleOrderType,
        CoarseSampleOrderCustomNV pCustomSampleOrders
    );

    [NativeName("vkCmdSetColorBlendAdvancedEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetColorBlendAdvancedEXT")]
    void CmdSetColorBlendAdvancedEXT(
        CommandBufferHandle commandBuffer,
        uint firstAttachment,
        uint attachmentCount,
        ColorBlendAdvancedEXT* pColorBlendAdvanced
    );

    [NativeName("vkCmdSetColorBlendAdvancedEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetColorBlendAdvancedEXT")]
    void CmdSetColorBlendAdvancedEXT(
        CommandBufferHandle commandBuffer,
        uint firstAttachment,
        uint attachmentCount,
        Ref<ColorBlendAdvancedEXT> pColorBlendAdvanced
    );

    [NativeName("vkCmdSetColorBlendAdvancedEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetColorBlendAdvancedEXT")]
    void CmdSetColorBlendAdvancedEXT(
        CommandBufferHandle commandBuffer,
        uint firstAttachment,
        ColorBlendAdvancedEXT pColorBlendAdvanced
    );

    [NativeName("vkCmdSetColorBlendEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetColorBlendEnableEXT")]
    void CmdSetColorBlendEnableEXT(
        CommandBufferHandle commandBuffer,
        uint firstAttachment,
        uint attachmentCount,
        uint* pColorBlendEnables
    );

    [NativeName("vkCmdSetColorBlendEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetColorBlendEnableEXT")]
    void CmdSetColorBlendEnableEXT(
        CommandBufferHandle commandBuffer,
        uint firstAttachment,
        uint attachmentCount,
        Ref<uint> pColorBlendEnables
    );

    [NativeName("vkCmdSetColorBlendEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetColorBlendEnableEXT")]
    void CmdSetColorBlendEnableEXT(
        CommandBufferHandle commandBuffer,
        uint firstAttachment,
        uint pColorBlendEnables
    );

    [NativeName("vkCmdSetColorBlendEquationEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetColorBlendEquationEXT")]
    void CmdSetColorBlendEquationEXT(
        CommandBufferHandle commandBuffer,
        uint firstAttachment,
        uint attachmentCount,
        ColorBlendEquationEXT* pColorBlendEquations
    );

    [NativeName("vkCmdSetColorBlendEquationEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetColorBlendEquationEXT")]
    void CmdSetColorBlendEquationEXT(
        CommandBufferHandle commandBuffer,
        uint firstAttachment,
        uint attachmentCount,
        Ref<ColorBlendEquationEXT> pColorBlendEquations
    );

    [NativeName("vkCmdSetColorBlendEquationEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetColorBlendEquationEXT")]
    void CmdSetColorBlendEquationEXT(
        CommandBufferHandle commandBuffer,
        uint firstAttachment,
        ColorBlendEquationEXT pColorBlendEquations
    );

    [NativeName("vkCmdSetColorWriteEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetColorWriteEnableEXT")]
    void CmdSetColorWriteEnableEXT(
        CommandBufferHandle commandBuffer,
        uint attachmentCount,
        uint* pColorWriteEnables
    );

    [NativeName("vkCmdSetColorWriteEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetColorWriteEnableEXT")]
    void CmdSetColorWriteEnableEXT(
        CommandBufferHandle commandBuffer,
        uint attachmentCount,
        Ref<uint> pColorWriteEnables
    );

    [NativeName("vkCmdSetColorWriteEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetColorWriteEnableEXT")]
    void CmdSetColorWriteEnableEXT(CommandBufferHandle commandBuffer, uint pColorWriteEnables);

    [NativeName("vkCmdSetColorWriteMaskEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetColorWriteMaskEXT")]
    void CmdSetColorWriteMaskEXT(
        CommandBufferHandle commandBuffer,
        uint firstAttachment,
        uint attachmentCount,
        ColorComponentFlags* pColorWriteMasks
    );

    [NativeName("vkCmdSetColorWriteMaskEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetColorWriteMaskEXT")]
    void CmdSetColorWriteMaskEXT(
        CommandBufferHandle commandBuffer,
        uint firstAttachment,
        uint attachmentCount,
        Ref<ColorComponentFlags> pColorWriteMasks
    );

    [NativeName("vkCmdSetColorWriteMaskEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetColorWriteMaskEXT")]
    void CmdSetColorWriteMaskEXT(
        CommandBufferHandle commandBuffer,
        uint firstAttachment,
        ColorComponentFlags pColorWriteMasks
    );

    [NativeName("vkCmdSetComputeOccupancyPriorityNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetComputeOccupancyPriorityNV")]
    void CmdSetComputeOccupancyPriorityNV(
        CommandBufferHandle commandBuffer,
        ComputeOccupancyPriorityParametersNV* pParameters
    );

    [NativeName("vkCmdSetComputeOccupancyPriorityNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetComputeOccupancyPriorityNV")]
    void CmdSetComputeOccupancyPriorityNV(
        CommandBufferHandle commandBuffer,
        Ref<ComputeOccupancyPriorityParametersNV> pParameters
    );

    [NativeName("vkCmdSetConservativeRasterizationModeEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetConservativeRasterizationModeEXT")]
    void CmdSetConservativeRasterizationModeEXT(
        CommandBufferHandle commandBuffer,
        ConservativeRasterizationModeEXT conservativeRasterizationMode
    );

    [NativeName("vkCmdSetCoverageModulationModeNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetCoverageModulationModeNV")]
    void CmdSetCoverageModulationModeNV(
        CommandBufferHandle commandBuffer,
        CoverageModulationModeNV coverageModulationMode
    );

    [NativeName("vkCmdSetCoverageModulationTableEnableNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetCoverageModulationTableEnableNV")]
    void CmdSetCoverageModulationTableEnableNV(
        CommandBufferHandle commandBuffer,
        uint coverageModulationTableEnable
    );

    [NativeName("vkCmdSetCoverageModulationTableEnableNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetCoverageModulationTableEnableNV")]
    void CmdSetCoverageModulationTableEnableNV(
        CommandBufferHandle commandBuffer,
        MaybeBool<uint> coverageModulationTableEnable
    );

    [NativeName("vkCmdSetCoverageModulationTableNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetCoverageModulationTableNV")]
    void CmdSetCoverageModulationTableNV(
        CommandBufferHandle commandBuffer,
        uint coverageModulationTableCount,
        float* pCoverageModulationTable
    );

    [NativeName("vkCmdSetCoverageModulationTableNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetCoverageModulationTableNV")]
    void CmdSetCoverageModulationTableNV(
        CommandBufferHandle commandBuffer,
        uint coverageModulationTableCount,
        Ref<float> pCoverageModulationTable
    );

    [NativeName("vkCmdSetCoverageModulationTableNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetCoverageModulationTableNV")]
    void CmdSetCoverageModulationTableNV(
        CommandBufferHandle commandBuffer,
        float pCoverageModulationTable
    );

    [NativeName("vkCmdSetCoverageReductionModeNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetCoverageReductionModeNV")]
    void CmdSetCoverageReductionModeNV(
        CommandBufferHandle commandBuffer,
        CoverageReductionModeNV coverageReductionMode
    );

    [NativeName("vkCmdSetCoverageToColorEnableNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetCoverageToColorEnableNV")]
    void CmdSetCoverageToColorEnableNV(
        CommandBufferHandle commandBuffer,
        uint coverageToColorEnable
    );

    [NativeName("vkCmdSetCoverageToColorEnableNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetCoverageToColorEnableNV")]
    void CmdSetCoverageToColorEnableNV(
        CommandBufferHandle commandBuffer,
        MaybeBool<uint> coverageToColorEnable
    );

    [NativeName("vkCmdSetCoverageToColorLocationNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetCoverageToColorLocationNV")]
    void CmdSetCoverageToColorLocationNV(
        CommandBufferHandle commandBuffer,
        uint coverageToColorLocation
    );

    [NativeName("vkCmdSetCullMode")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetCullMode")]
    void CmdSetCullMode(CommandBufferHandle commandBuffer, CullModeFlags cullMode);

    [NativeName("vkCmdSetCullModeEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetCullModeEXT")]
    void CmdSetCullModeEXT(CommandBufferHandle commandBuffer, CullModeFlags cullMode);

    [NativeName("vkCmdSetDepthBias")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthBias")]
    void CmdSetDepthBias(
        CommandBufferHandle commandBuffer,
        float depthBiasConstantFactor,
        float depthBiasClamp,
        float depthBiasSlopeFactor
    );

    [NativeName("vkCmdSetDepthBias2EXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthBias2EXT")]
    void CmdSetDepthBias2EXT(CommandBufferHandle commandBuffer, DepthBiasInfoEXT* pDepthBiasInfo);

    [NativeName("vkCmdSetDepthBias2EXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthBias2EXT")]
    void CmdSetDepthBias2EXT(
        CommandBufferHandle commandBuffer,
        Ref<DepthBiasInfoEXT> pDepthBiasInfo
    );

    [NativeName("vkCmdSetDepthBiasEnable")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthBiasEnable")]
    void CmdSetDepthBiasEnable(CommandBufferHandle commandBuffer, uint depthBiasEnable);

    [NativeName("vkCmdSetDepthBiasEnable")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthBiasEnable")]
    void CmdSetDepthBiasEnable(CommandBufferHandle commandBuffer, MaybeBool<uint> depthBiasEnable);

    [NativeName("vkCmdSetDepthBiasEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthBiasEnableEXT")]
    void CmdSetDepthBiasEnableEXT(CommandBufferHandle commandBuffer, uint depthBiasEnable);

    [NativeName("vkCmdSetDepthBiasEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthBiasEnableEXT")]
    void CmdSetDepthBiasEnableEXT(
        CommandBufferHandle commandBuffer,
        MaybeBool<uint> depthBiasEnable
    );

    [NativeName("vkCmdSetDepthBounds")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthBounds")]
    void CmdSetDepthBounds(
        CommandBufferHandle commandBuffer,
        float minDepthBounds,
        float maxDepthBounds
    );

    [NativeName("vkCmdSetDepthBoundsTestEnable")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthBoundsTestEnable")]
    void CmdSetDepthBoundsTestEnable(CommandBufferHandle commandBuffer, uint depthBoundsTestEnable);

    [NativeName("vkCmdSetDepthBoundsTestEnable")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthBoundsTestEnable")]
    void CmdSetDepthBoundsTestEnable(
        CommandBufferHandle commandBuffer,
        MaybeBool<uint> depthBoundsTestEnable
    );

    [NativeName("vkCmdSetDepthBoundsTestEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthBoundsTestEnableEXT")]
    void CmdSetDepthBoundsTestEnableEXT(
        CommandBufferHandle commandBuffer,
        uint depthBoundsTestEnable
    );

    [NativeName("vkCmdSetDepthBoundsTestEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthBoundsTestEnableEXT")]
    void CmdSetDepthBoundsTestEnableEXT(
        CommandBufferHandle commandBuffer,
        MaybeBool<uint> depthBoundsTestEnable
    );

    [NativeName("vkCmdSetDepthClampEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthClampEnableEXT")]
    void CmdSetDepthClampEnableEXT(CommandBufferHandle commandBuffer, uint depthClampEnable);

    [NativeName("vkCmdSetDepthClampEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthClampEnableEXT")]
    void CmdSetDepthClampEnableEXT(
        CommandBufferHandle commandBuffer,
        MaybeBool<uint> depthClampEnable
    );

    [NativeName("vkCmdSetDepthClampRangeEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthClampRangeEXT")]
    void CmdSetDepthClampRangeEXT(
        CommandBufferHandle commandBuffer,
        DepthClampModeEXT depthClampMode,
        DepthClampRangeEXT* pDepthClampRange
    );

    [NativeName("vkCmdSetDepthClampRangeEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthClampRangeEXT")]
    void CmdSetDepthClampRangeEXT(
        CommandBufferHandle commandBuffer,
        DepthClampModeEXT depthClampMode,
        Ref<DepthClampRangeEXT> pDepthClampRange
    );

    [NativeName("vkCmdSetDepthClipEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthClipEnableEXT")]
    void CmdSetDepthClipEnableEXT(CommandBufferHandle commandBuffer, uint depthClipEnable);

    [NativeName("vkCmdSetDepthClipEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthClipEnableEXT")]
    void CmdSetDepthClipEnableEXT(
        CommandBufferHandle commandBuffer,
        MaybeBool<uint> depthClipEnable
    );

    [NativeName("vkCmdSetDepthClipNegativeOneToOneEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthClipNegativeOneToOneEXT")]
    void CmdSetDepthClipNegativeOneToOneEXT(
        CommandBufferHandle commandBuffer,
        uint negativeOneToOne
    );

    [NativeName("vkCmdSetDepthClipNegativeOneToOneEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthClipNegativeOneToOneEXT")]
    void CmdSetDepthClipNegativeOneToOneEXT(
        CommandBufferHandle commandBuffer,
        MaybeBool<uint> negativeOneToOne
    );

    [NativeName("vkCmdSetDepthCompareOp")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthCompareOp")]
    void CmdSetDepthCompareOp(CommandBufferHandle commandBuffer, CompareOp depthCompareOp);

    [NativeName("vkCmdSetDepthCompareOpEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthCompareOpEXT")]
    void CmdSetDepthCompareOpEXT(CommandBufferHandle commandBuffer, CompareOp depthCompareOp);

    [NativeName("vkCmdSetDepthTestEnable")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthTestEnable")]
    void CmdSetDepthTestEnable(CommandBufferHandle commandBuffer, uint depthTestEnable);

    [NativeName("vkCmdSetDepthTestEnable")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthTestEnable")]
    void CmdSetDepthTestEnable(CommandBufferHandle commandBuffer, MaybeBool<uint> depthTestEnable);

    [NativeName("vkCmdSetDepthTestEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthTestEnableEXT")]
    void CmdSetDepthTestEnableEXT(CommandBufferHandle commandBuffer, uint depthTestEnable);

    [NativeName("vkCmdSetDepthTestEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthTestEnableEXT")]
    void CmdSetDepthTestEnableEXT(
        CommandBufferHandle commandBuffer,
        MaybeBool<uint> depthTestEnable
    );

    [NativeName("vkCmdSetDepthWriteEnable")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthWriteEnable")]
    void CmdSetDepthWriteEnable(CommandBufferHandle commandBuffer, uint depthWriteEnable);

    [NativeName("vkCmdSetDepthWriteEnable")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthWriteEnable")]
    void CmdSetDepthWriteEnable(
        CommandBufferHandle commandBuffer,
        MaybeBool<uint> depthWriteEnable
    );

    [NativeName("vkCmdSetDepthWriteEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthWriteEnableEXT")]
    void CmdSetDepthWriteEnableEXT(CommandBufferHandle commandBuffer, uint depthWriteEnable);

    [NativeName("vkCmdSetDepthWriteEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDepthWriteEnableEXT")]
    void CmdSetDepthWriteEnableEXT(
        CommandBufferHandle commandBuffer,
        MaybeBool<uint> depthWriteEnable
    );

    [NativeName("vkCmdSetDescriptorBufferOffsets2EXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDescriptorBufferOffsets2EXT")]
    void CmdSetDescriptorBufferOffsets2EXT(
        CommandBufferHandle commandBuffer,
        SetDescriptorBufferOffsetsInfoEXT* pSetDescriptorBufferOffsetsInfo
    );

    [NativeName("vkCmdSetDescriptorBufferOffsets2EXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDescriptorBufferOffsets2EXT")]
    void CmdSetDescriptorBufferOffsets2EXT(
        CommandBufferHandle commandBuffer,
        Ref<SetDescriptorBufferOffsetsInfoEXT> pSetDescriptorBufferOffsetsInfo
    );

    [NativeName("vkCmdSetDescriptorBufferOffsetsEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDescriptorBufferOffsetsEXT")]
    void CmdSetDescriptorBufferOffsetsEXT(
        CommandBufferHandle commandBuffer,
        PipelineBindPoint pipelineBindPoint,
        PipelineLayoutHandle layout,
        uint firstSet,
        uint setCount,
        uint* pBufferIndices,
        ulong* pOffsets
    );

    [NativeName("vkCmdSetDescriptorBufferOffsetsEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDescriptorBufferOffsetsEXT")]
    void CmdSetDescriptorBufferOffsetsEXT(
        CommandBufferHandle commandBuffer,
        PipelineBindPoint pipelineBindPoint,
        PipelineLayoutHandle layout,
        uint firstSet,
        uint setCount,
        Ref<uint> pBufferIndices,
        Ref<ulong> pOffsets
    );

    [NativeName("vkCmdSetDeviceMask")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDeviceMask")]
    void CmdSetDeviceMask(CommandBufferHandle commandBuffer, uint deviceMask);

    [NativeName("vkCmdSetDeviceMaskKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDeviceMaskKHR")]
    void CmdSetDeviceMaskKHR(CommandBufferHandle commandBuffer, uint deviceMask);

    [NativeName("vkCmdSetDiscardRectangleEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDiscardRectangleEnableEXT")]
    void CmdSetDiscardRectangleEnableEXT(
        CommandBufferHandle commandBuffer,
        uint discardRectangleEnable
    );

    [NativeName("vkCmdSetDiscardRectangleEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDiscardRectangleEnableEXT")]
    void CmdSetDiscardRectangleEnableEXT(
        CommandBufferHandle commandBuffer,
        MaybeBool<uint> discardRectangleEnable
    );

    [NativeName("vkCmdSetDiscardRectangleEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDiscardRectangleEXT")]
    void CmdSetDiscardRectangleEXT(
        CommandBufferHandle commandBuffer,
        uint firstDiscardRectangle,
        uint discardRectangleCount,
        Rect2D* pDiscardRectangles
    );

    [NativeName("vkCmdSetDiscardRectangleEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDiscardRectangleEXT")]
    void CmdSetDiscardRectangleEXT(
        CommandBufferHandle commandBuffer,
        uint firstDiscardRectangle,
        uint discardRectangleCount,
        Ref<Rect2D> pDiscardRectangles
    );

    [NativeName("vkCmdSetDiscardRectangleEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDiscardRectangleEXT")]
    void CmdSetDiscardRectangleEXT(
        CommandBufferHandle commandBuffer,
        uint firstDiscardRectangle,
        Rect2D pDiscardRectangles
    );

    [NativeName("vkCmdSetDiscardRectangleModeEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDiscardRectangleModeEXT")]
    void CmdSetDiscardRectangleModeEXT(
        CommandBufferHandle commandBuffer,
        DiscardRectangleModeEXT discardRectangleMode
    );

    [NativeName("vkCmdSetDispatchParametersARM")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDispatchParametersARM")]
    void CmdSetDispatchParametersARM(
        CommandBufferHandle commandBuffer,
        DispatchParametersARM* pDispatchParameters
    );

    [NativeName("vkCmdSetDispatchParametersARM")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetDispatchParametersARM")]
    void CmdSetDispatchParametersARM(
        CommandBufferHandle commandBuffer,
        Ref<DispatchParametersARM> pDispatchParameters
    );

    [NativeName("vkCmdSetEvent")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetEvent")]
    void CmdSetEvent(
        CommandBufferHandle commandBuffer,
        EventHandle @event,
        PipelineStageFlags stageMask
    );

    [NativeName("vkCmdSetEvent2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetEvent2")]
    void CmdSetEvent2(
        CommandBufferHandle commandBuffer,
        EventHandle @event,
        DependencyInfo* pDependencyInfo
    );

    [NativeName("vkCmdSetEvent2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetEvent2")]
    void CmdSetEvent2(
        CommandBufferHandle commandBuffer,
        EventHandle @event,
        Ref<DependencyInfo> pDependencyInfo
    );

    [NativeName("vkCmdSetEvent2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetEvent2KHR")]
    void CmdSetEvent2KHR(
        CommandBufferHandle commandBuffer,
        EventHandle @event,
        DependencyInfo* pDependencyInfo
    );

    [NativeName("vkCmdSetEvent2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetEvent2KHR")]
    void CmdSetEvent2KHR(
        CommandBufferHandle commandBuffer,
        EventHandle @event,
        Ref<DependencyInfo> pDependencyInfo
    );

    [NativeName("vkCmdSetExclusiveScissorEnableNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetExclusiveScissorEnableNV")]
    void CmdSetExclusiveScissorEnableNV(
        CommandBufferHandle commandBuffer,
        uint firstExclusiveScissor,
        uint exclusiveScissorCount,
        uint* pExclusiveScissorEnables
    );

    [NativeName("vkCmdSetExclusiveScissorEnableNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetExclusiveScissorEnableNV")]
    void CmdSetExclusiveScissorEnableNV(
        CommandBufferHandle commandBuffer,
        uint firstExclusiveScissor,
        uint exclusiveScissorCount,
        Ref<uint> pExclusiveScissorEnables
    );

    [NativeName("vkCmdSetExclusiveScissorEnableNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetExclusiveScissorEnableNV")]
    void CmdSetExclusiveScissorEnableNV(
        CommandBufferHandle commandBuffer,
        uint firstExclusiveScissor,
        uint pExclusiveScissorEnables
    );

    [NativeName("vkCmdSetExclusiveScissorNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetExclusiveScissorNV")]
    void CmdSetExclusiveScissorNV(
        CommandBufferHandle commandBuffer,
        uint firstExclusiveScissor,
        uint exclusiveScissorCount,
        Rect2D* pExclusiveScissors
    );

    [NativeName("vkCmdSetExclusiveScissorNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetExclusiveScissorNV")]
    void CmdSetExclusiveScissorNV(
        CommandBufferHandle commandBuffer,
        uint firstExclusiveScissor,
        uint exclusiveScissorCount,
        Ref<Rect2D> pExclusiveScissors
    );

    [NativeName("vkCmdSetExclusiveScissorNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetExclusiveScissorNV")]
    void CmdSetExclusiveScissorNV(
        CommandBufferHandle commandBuffer,
        uint firstExclusiveScissor,
        Rect2D pExclusiveScissors
    );

    [NativeName("vkCmdSetExtraPrimitiveOverestimationSizeEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetExtraPrimitiveOverestimationSizeEXT")]
    void CmdSetExtraPrimitiveOverestimationSizeEXT(
        CommandBufferHandle commandBuffer,
        float extraPrimitiveOverestimationSize
    );

    [NativeName("vkCmdSetFragmentShadingRateEnumNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetFragmentShadingRateEnumNV")]
    void CmdSetFragmentShadingRateEnumNV(
        CommandBufferHandle commandBuffer,
        FragmentShadingRateNV shadingRate,
        FragmentShadingRateCombinerOpKHR* combinerOps
    );

    [NativeName("vkCmdSetFragmentShadingRateEnumNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetFragmentShadingRateEnumNV")]
    void CmdSetFragmentShadingRateEnumNV(
        CommandBufferHandle commandBuffer,
        FragmentShadingRateNV shadingRate,
        Ref<FragmentShadingRateCombinerOpKHR> combinerOps
    );

    [NativeName("vkCmdSetFragmentShadingRateKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetFragmentShadingRateKHR")]
    void CmdSetFragmentShadingRateKHR(
        CommandBufferHandle commandBuffer,
        Extent2D* pFragmentSize,
        FragmentShadingRateCombinerOpKHR* combinerOps
    );

    [NativeName("vkCmdSetFragmentShadingRateKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetFragmentShadingRateKHR")]
    void CmdSetFragmentShadingRateKHR(
        CommandBufferHandle commandBuffer,
        Ref<Extent2D> pFragmentSize,
        Ref<FragmentShadingRateCombinerOpKHR> combinerOps
    );

    [NativeName("vkCmdSetFrontFace")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetFrontFace")]
    void CmdSetFrontFace(CommandBufferHandle commandBuffer, FrontFace frontFace);

    [NativeName("vkCmdSetFrontFaceEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetFrontFaceEXT")]
    void CmdSetFrontFaceEXT(CommandBufferHandle commandBuffer, FrontFace frontFace);

    [NativeName("vkCmdSetLineRasterizationModeEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetLineRasterizationModeEXT")]
    void CmdSetLineRasterizationModeEXT(
        CommandBufferHandle commandBuffer,
        LineRasterizationMode lineRasterizationMode
    );

    [NativeName("vkCmdSetLineStipple")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetLineStipple")]
    void CmdSetLineStipple(
        CommandBufferHandle commandBuffer,
        uint lineStippleFactor,
        ushort lineStipplePattern
    );

    [NativeName("vkCmdSetLineStippleEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetLineStippleEnableEXT")]
    void CmdSetLineStippleEnableEXT(CommandBufferHandle commandBuffer, uint stippledLineEnable);

    [NativeName("vkCmdSetLineStippleEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetLineStippleEnableEXT")]
    void CmdSetLineStippleEnableEXT(
        CommandBufferHandle commandBuffer,
        MaybeBool<uint> stippledLineEnable
    );

    [NativeName("vkCmdSetLineStippleEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetLineStippleEXT")]
    void CmdSetLineStippleEXT(
        CommandBufferHandle commandBuffer,
        uint lineStippleFactor,
        ushort lineStipplePattern
    );

    [NativeName("vkCmdSetLineStippleKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetLineStippleKHR")]
    void CmdSetLineStippleKHR(
        CommandBufferHandle commandBuffer,
        uint lineStippleFactor,
        ushort lineStipplePattern
    );

    [NativeName("vkCmdSetLineWidth")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetLineWidth")]
    void CmdSetLineWidth(CommandBufferHandle commandBuffer, float lineWidth);

    [NativeName("vkCmdSetLogicOpEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetLogicOpEnableEXT")]
    void CmdSetLogicOpEnableEXT(CommandBufferHandle commandBuffer, uint logicOpEnable);

    [NativeName("vkCmdSetLogicOpEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetLogicOpEnableEXT")]
    void CmdSetLogicOpEnableEXT(CommandBufferHandle commandBuffer, MaybeBool<uint> logicOpEnable);

    [NativeName("vkCmdSetLogicOpEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetLogicOpEXT")]
    void CmdSetLogicOpEXT(CommandBufferHandle commandBuffer, LogicOp logicOp);

    [NativeName("vkCmdSetPatchControlPointsEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetPatchControlPointsEXT")]
    void CmdSetPatchControlPointsEXT(CommandBufferHandle commandBuffer, uint patchControlPoints);

    [NativeName("vkCmdSetPerformanceMarkerINTEL")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetPerformanceMarkerINTEL")]
    Result CmdSetPerformanceMarkerINTEL(
        CommandBufferHandle commandBuffer,
        PerformanceMarkerInfoINTEL* pMarkerInfo
    );

    [NativeName("vkCmdSetPerformanceMarkerINTEL")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetPerformanceMarkerINTEL")]
    Result CmdSetPerformanceMarkerINTEL(
        CommandBufferHandle commandBuffer,
        Ref<PerformanceMarkerInfoINTEL> pMarkerInfo
    );

    [NativeName("vkCmdSetPerformanceOverrideINTEL")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetPerformanceOverrideINTEL")]
    Result CmdSetPerformanceOverrideINTEL(
        CommandBufferHandle commandBuffer,
        PerformanceOverrideInfoINTEL* pOverrideInfo
    );

    [NativeName("vkCmdSetPerformanceOverrideINTEL")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetPerformanceOverrideINTEL")]
    Result CmdSetPerformanceOverrideINTEL(
        CommandBufferHandle commandBuffer,
        Ref<PerformanceOverrideInfoINTEL> pOverrideInfo
    );

    [NativeName("vkCmdSetPerformanceStreamMarkerINTEL")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetPerformanceStreamMarkerINTEL")]
    Result CmdSetPerformanceStreamMarkerINTEL(
        CommandBufferHandle commandBuffer,
        PerformanceStreamMarkerInfoINTEL* pMarkerInfo
    );

    [NativeName("vkCmdSetPerformanceStreamMarkerINTEL")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetPerformanceStreamMarkerINTEL")]
    Result CmdSetPerformanceStreamMarkerINTEL(
        CommandBufferHandle commandBuffer,
        Ref<PerformanceStreamMarkerInfoINTEL> pMarkerInfo
    );

    [NativeName("vkCmdSetPolygonModeEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetPolygonModeEXT")]
    void CmdSetPolygonModeEXT(CommandBufferHandle commandBuffer, PolygonMode polygonMode);

    [NativeName("vkCmdSetPrimitiveRestartEnable")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetPrimitiveRestartEnable")]
    void CmdSetPrimitiveRestartEnable(
        CommandBufferHandle commandBuffer,
        uint primitiveRestartEnable
    );

    [NativeName("vkCmdSetPrimitiveRestartEnable")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetPrimitiveRestartEnable")]
    void CmdSetPrimitiveRestartEnable(
        CommandBufferHandle commandBuffer,
        MaybeBool<uint> primitiveRestartEnable
    );

    [NativeName("vkCmdSetPrimitiveRestartEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetPrimitiveRestartEnableEXT")]
    void CmdSetPrimitiveRestartEnableEXT(
        CommandBufferHandle commandBuffer,
        uint primitiveRestartEnable
    );

    [NativeName("vkCmdSetPrimitiveRestartEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetPrimitiveRestartEnableEXT")]
    void CmdSetPrimitiveRestartEnableEXT(
        CommandBufferHandle commandBuffer,
        MaybeBool<uint> primitiveRestartEnable
    );

    [NativeName("vkCmdSetPrimitiveRestartIndexEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetPrimitiveRestartIndexEXT")]
    void CmdSetPrimitiveRestartIndexEXT(
        CommandBufferHandle commandBuffer,
        uint primitiveRestartIndex
    );

    [NativeName("vkCmdSetPrimitiveTopology")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetPrimitiveTopology")]
    void CmdSetPrimitiveTopology(
        CommandBufferHandle commandBuffer,
        PrimitiveTopology primitiveTopology
    );

    [NativeName("vkCmdSetPrimitiveTopologyEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetPrimitiveTopologyEXT")]
    void CmdSetPrimitiveTopologyEXT(
        CommandBufferHandle commandBuffer,
        PrimitiveTopology primitiveTopology
    );

    [NativeName("vkCmdSetProvokingVertexModeEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetProvokingVertexModeEXT")]
    void CmdSetProvokingVertexModeEXT(
        CommandBufferHandle commandBuffer,
        ProvokingVertexModeEXT provokingVertexMode
    );

    [NativeName("vkCmdSetRasterizationSamplesEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetRasterizationSamplesEXT")]
    void CmdSetRasterizationSamplesEXT(
        CommandBufferHandle commandBuffer,
        SampleCountFlags rasterizationSamples
    );

    [NativeName("vkCmdSetRasterizationStreamEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetRasterizationStreamEXT")]
    void CmdSetRasterizationStreamEXT(CommandBufferHandle commandBuffer, uint rasterizationStream);

    [NativeName("vkCmdSetRasterizerDiscardEnable")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetRasterizerDiscardEnable")]
    void CmdSetRasterizerDiscardEnable(
        CommandBufferHandle commandBuffer,
        uint rasterizerDiscardEnable
    );

    [NativeName("vkCmdSetRasterizerDiscardEnable")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetRasterizerDiscardEnable")]
    void CmdSetRasterizerDiscardEnable(
        CommandBufferHandle commandBuffer,
        MaybeBool<uint> rasterizerDiscardEnable
    );

    [NativeName("vkCmdSetRasterizerDiscardEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetRasterizerDiscardEnableEXT")]
    void CmdSetRasterizerDiscardEnableEXT(
        CommandBufferHandle commandBuffer,
        uint rasterizerDiscardEnable
    );

    [NativeName("vkCmdSetRasterizerDiscardEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetRasterizerDiscardEnableEXT")]
    void CmdSetRasterizerDiscardEnableEXT(
        CommandBufferHandle commandBuffer,
        MaybeBool<uint> rasterizerDiscardEnable
    );

    [NativeName("vkCmdSetRayTracingPipelineStackSizeKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetRayTracingPipelineStackSizeKHR")]
    void CmdSetRayTracingPipelineStackSizeKHR(
        CommandBufferHandle commandBuffer,
        uint pipelineStackSize
    );

    [NativeName("vkCmdSetRenderingAttachmentLocations")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetRenderingAttachmentLocations")]
    void CmdSetRenderingAttachmentLocations(
        CommandBufferHandle commandBuffer,
        RenderingAttachmentLocationInfo* pLocationInfo
    );

    [NativeName("vkCmdSetRenderingAttachmentLocations")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetRenderingAttachmentLocations")]
    void CmdSetRenderingAttachmentLocations(
        CommandBufferHandle commandBuffer,
        Ref<RenderingAttachmentLocationInfo> pLocationInfo
    );

    [NativeName("vkCmdSetRenderingAttachmentLocationsKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetRenderingAttachmentLocationsKHR")]
    void CmdSetRenderingAttachmentLocationsKHR(
        CommandBufferHandle commandBuffer,
        RenderingAttachmentLocationInfo* pLocationInfo
    );

    [NativeName("vkCmdSetRenderingAttachmentLocationsKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetRenderingAttachmentLocationsKHR")]
    void CmdSetRenderingAttachmentLocationsKHR(
        CommandBufferHandle commandBuffer,
        Ref<RenderingAttachmentLocationInfo> pLocationInfo
    );

    [NativeName("vkCmdSetRenderingInputAttachmentIndices")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetRenderingInputAttachmentIndices")]
    void CmdSetRenderingInputAttachmentIndices(
        CommandBufferHandle commandBuffer,
        RenderingInputAttachmentIndexInfo* pInputAttachmentIndexInfo
    );

    [NativeName("vkCmdSetRenderingInputAttachmentIndices")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetRenderingInputAttachmentIndices")]
    void CmdSetRenderingInputAttachmentIndices(
        CommandBufferHandle commandBuffer,
        Ref<RenderingInputAttachmentIndexInfo> pInputAttachmentIndexInfo
    );

    [NativeName("vkCmdSetRenderingInputAttachmentIndicesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetRenderingInputAttachmentIndicesKHR")]
    void CmdSetRenderingInputAttachmentIndicesKHR(
        CommandBufferHandle commandBuffer,
        RenderingInputAttachmentIndexInfo* pInputAttachmentIndexInfo
    );

    [NativeName("vkCmdSetRenderingInputAttachmentIndicesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetRenderingInputAttachmentIndicesKHR")]
    void CmdSetRenderingInputAttachmentIndicesKHR(
        CommandBufferHandle commandBuffer,
        Ref<RenderingInputAttachmentIndexInfo> pInputAttachmentIndexInfo
    );

    [NativeName("vkCmdSetRepresentativeFragmentTestEnableNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetRepresentativeFragmentTestEnableNV")]
    void CmdSetRepresentativeFragmentTestEnableNV(
        CommandBufferHandle commandBuffer,
        uint representativeFragmentTestEnable
    );

    [NativeName("vkCmdSetRepresentativeFragmentTestEnableNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetRepresentativeFragmentTestEnableNV")]
    void CmdSetRepresentativeFragmentTestEnableNV(
        CommandBufferHandle commandBuffer,
        MaybeBool<uint> representativeFragmentTestEnable
    );

    [NativeName("vkCmdSetSampleLocationsEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetSampleLocationsEnableEXT")]
    void CmdSetSampleLocationsEnableEXT(
        CommandBufferHandle commandBuffer,
        uint sampleLocationsEnable
    );

    [NativeName("vkCmdSetSampleLocationsEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetSampleLocationsEnableEXT")]
    void CmdSetSampleLocationsEnableEXT(
        CommandBufferHandle commandBuffer,
        MaybeBool<uint> sampleLocationsEnable
    );

    [NativeName("vkCmdSetSampleLocationsEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetSampleLocationsEXT")]
    void CmdSetSampleLocationsEXT(
        CommandBufferHandle commandBuffer,
        SampleLocationsInfoEXT* pSampleLocationsInfo
    );

    [NativeName("vkCmdSetSampleLocationsEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetSampleLocationsEXT")]
    void CmdSetSampleLocationsEXT(
        CommandBufferHandle commandBuffer,
        Ref<SampleLocationsInfoEXT> pSampleLocationsInfo
    );

    [NativeName("vkCmdSetSampleMaskEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetSampleMaskEXT")]
    void CmdSetSampleMaskEXT(
        CommandBufferHandle commandBuffer,
        SampleCountFlags samples,
        uint* pSampleMask
    );

    [NativeName("vkCmdSetSampleMaskEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetSampleMaskEXT")]
    void CmdSetSampleMaskEXT(
        CommandBufferHandle commandBuffer,
        SampleCountFlags samples,
        Ref<uint> pSampleMask
    );

    [NativeName("vkCmdSetScissor")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetScissor")]
    void CmdSetScissor(
        CommandBufferHandle commandBuffer,
        uint firstScissor,
        uint scissorCount,
        Rect2D* pScissors
    );

    [NativeName("vkCmdSetScissor")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetScissor")]
    void CmdSetScissor(
        CommandBufferHandle commandBuffer,
        uint firstScissor,
        uint scissorCount,
        Ref<Rect2D> pScissors
    );

    [NativeName("vkCmdSetScissor")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetScissor")]
    void CmdSetScissor(CommandBufferHandle commandBuffer, uint firstScissor, Rect2D pScissors);

    [NativeName("vkCmdSetScissorWithCount")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetScissorWithCount")]
    void CmdSetScissorWithCount(
        CommandBufferHandle commandBuffer,
        uint scissorCount,
        Rect2D* pScissors
    );

    [NativeName("vkCmdSetScissorWithCount")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetScissorWithCount")]
    void CmdSetScissorWithCount(
        CommandBufferHandle commandBuffer,
        uint scissorCount,
        Ref<Rect2D> pScissors
    );

    [NativeName("vkCmdSetScissorWithCount")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetScissorWithCount")]
    void CmdSetScissorWithCount(CommandBufferHandle commandBuffer, Rect2D pScissors);

    [NativeName("vkCmdSetScissorWithCountEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetScissorWithCountEXT")]
    void CmdSetScissorWithCountEXT(
        CommandBufferHandle commandBuffer,
        uint scissorCount,
        Rect2D* pScissors
    );

    [NativeName("vkCmdSetScissorWithCountEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetScissorWithCountEXT")]
    void CmdSetScissorWithCountEXT(
        CommandBufferHandle commandBuffer,
        uint scissorCount,
        Ref<Rect2D> pScissors
    );

    [NativeName("vkCmdSetScissorWithCountEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetScissorWithCountEXT")]
    void CmdSetScissorWithCountEXT(CommandBufferHandle commandBuffer, Rect2D pScissors);

    [NativeName("vkCmdSetShadingRateImageEnableNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetShadingRateImageEnableNV")]
    void CmdSetShadingRateImageEnableNV(
        CommandBufferHandle commandBuffer,
        uint shadingRateImageEnable
    );

    [NativeName("vkCmdSetShadingRateImageEnableNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetShadingRateImageEnableNV")]
    void CmdSetShadingRateImageEnableNV(
        CommandBufferHandle commandBuffer,
        MaybeBool<uint> shadingRateImageEnable
    );

    [NativeName("vkCmdSetStencilCompareMask")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetStencilCompareMask")]
    void CmdSetStencilCompareMask(
        CommandBufferHandle commandBuffer,
        StencilFaceFlags faceMask,
        uint compareMask
    );

    [NativeName("vkCmdSetStencilOp")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetStencilOp")]
    void CmdSetStencilOp(
        CommandBufferHandle commandBuffer,
        StencilFaceFlags faceMask,
        StencilOp failOp,
        StencilOp passOp,
        StencilOp depthFailOp,
        CompareOp compareOp
    );

    [NativeName("vkCmdSetStencilOpEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetStencilOpEXT")]
    void CmdSetStencilOpEXT(
        CommandBufferHandle commandBuffer,
        StencilFaceFlags faceMask,
        StencilOp failOp,
        StencilOp passOp,
        StencilOp depthFailOp,
        CompareOp compareOp
    );

    [NativeName("vkCmdSetStencilReference")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetStencilReference")]
    void CmdSetStencilReference(
        CommandBufferHandle commandBuffer,
        StencilFaceFlags faceMask,
        uint reference
    );

    [NativeName("vkCmdSetStencilTestEnable")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetStencilTestEnable")]
    void CmdSetStencilTestEnable(CommandBufferHandle commandBuffer, uint stencilTestEnable);

    [NativeName("vkCmdSetStencilTestEnable")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetStencilTestEnable")]
    void CmdSetStencilTestEnable(
        CommandBufferHandle commandBuffer,
        MaybeBool<uint> stencilTestEnable
    );

    [NativeName("vkCmdSetStencilTestEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetStencilTestEnableEXT")]
    void CmdSetStencilTestEnableEXT(CommandBufferHandle commandBuffer, uint stencilTestEnable);

    [NativeName("vkCmdSetStencilTestEnableEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetStencilTestEnableEXT")]
    void CmdSetStencilTestEnableEXT(
        CommandBufferHandle commandBuffer,
        MaybeBool<uint> stencilTestEnable
    );

    [NativeName("vkCmdSetStencilWriteMask")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetStencilWriteMask")]
    void CmdSetStencilWriteMask(
        CommandBufferHandle commandBuffer,
        StencilFaceFlags faceMask,
        uint writeMask
    );

    [NativeName("vkCmdSetTessellationDomainOriginEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetTessellationDomainOriginEXT")]
    void CmdSetTessellationDomainOriginEXT(
        CommandBufferHandle commandBuffer,
        TessellationDomainOrigin domainOrigin
    );

    [NativeName("vkCmdSetVertexInputEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetVertexInputEXT")]
    void CmdSetVertexInputEXT(
        CommandBufferHandle commandBuffer,
        uint vertexBindingDescriptionCount,
        VertexInputBindingDescription2EXT* pVertexBindingDescriptions,
        uint vertexAttributeDescriptionCount,
        VertexInputAttributeDescription2EXT* pVertexAttributeDescriptions
    );

    [NativeName("vkCmdSetVertexInputEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetVertexInputEXT")]
    void CmdSetVertexInputEXT(
        CommandBufferHandle commandBuffer,
        uint vertexBindingDescriptionCount,
        Ref<VertexInputBindingDescription2EXT> pVertexBindingDescriptions,
        uint vertexAttributeDescriptionCount,
        Ref<VertexInputAttributeDescription2EXT> pVertexAttributeDescriptions
    );

    [NativeName("vkCmdSetViewport")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewport")]
    void CmdSetViewport(
        CommandBufferHandle commandBuffer,
        uint firstViewport,
        uint viewportCount,
        Viewport* pViewports
    );

    [NativeName("vkCmdSetViewport")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewport")]
    void CmdSetViewport(
        CommandBufferHandle commandBuffer,
        uint firstViewport,
        uint viewportCount,
        Ref<Viewport> pViewports
    );

    [NativeName("vkCmdSetViewport")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewport")]
    void CmdSetViewport(CommandBufferHandle commandBuffer, uint firstViewport, Viewport pViewports);

    [NativeName("vkCmdSetViewportShadingRatePaletteNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewportShadingRatePaletteNV")]
    void CmdSetViewportShadingRatePaletteNV(
        CommandBufferHandle commandBuffer,
        uint firstViewport,
        uint viewportCount,
        ShadingRatePaletteNV* pShadingRatePalettes
    );

    [NativeName("vkCmdSetViewportShadingRatePaletteNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewportShadingRatePaletteNV")]
    void CmdSetViewportShadingRatePaletteNV(
        CommandBufferHandle commandBuffer,
        uint firstViewport,
        uint viewportCount,
        Ref<ShadingRatePaletteNV> pShadingRatePalettes
    );

    [NativeName("vkCmdSetViewportShadingRatePaletteNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewportShadingRatePaletteNV")]
    void CmdSetViewportShadingRatePaletteNV(
        CommandBufferHandle commandBuffer,
        uint firstViewport,
        ShadingRatePaletteNV pShadingRatePalettes
    );

    [NativeName("vkCmdSetViewportSwizzleNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewportSwizzleNV")]
    void CmdSetViewportSwizzleNV(
        CommandBufferHandle commandBuffer,
        uint firstViewport,
        uint viewportCount,
        ViewportSwizzleNV* pViewportSwizzles
    );

    [NativeName("vkCmdSetViewportSwizzleNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewportSwizzleNV")]
    void CmdSetViewportSwizzleNV(
        CommandBufferHandle commandBuffer,
        uint firstViewport,
        uint viewportCount,
        Ref<ViewportSwizzleNV> pViewportSwizzles
    );

    [NativeName("vkCmdSetViewportSwizzleNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewportSwizzleNV")]
    void CmdSetViewportSwizzleNV(
        CommandBufferHandle commandBuffer,
        uint firstViewport,
        ViewportSwizzleNV pViewportSwizzles
    );

    [NativeName("vkCmdSetViewportWithCount")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewportWithCount")]
    void CmdSetViewportWithCount(
        CommandBufferHandle commandBuffer,
        uint viewportCount,
        Viewport* pViewports
    );

    [NativeName("vkCmdSetViewportWithCount")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewportWithCount")]
    void CmdSetViewportWithCount(
        CommandBufferHandle commandBuffer,
        uint viewportCount,
        Ref<Viewport> pViewports
    );

    [NativeName("vkCmdSetViewportWithCount")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewportWithCount")]
    void CmdSetViewportWithCount(CommandBufferHandle commandBuffer, Viewport pViewports);

    [NativeName("vkCmdSetViewportWithCountEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewportWithCountEXT")]
    void CmdSetViewportWithCountEXT(
        CommandBufferHandle commandBuffer,
        uint viewportCount,
        Viewport* pViewports
    );

    [NativeName("vkCmdSetViewportWithCountEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewportWithCountEXT")]
    void CmdSetViewportWithCountEXT(
        CommandBufferHandle commandBuffer,
        uint viewportCount,
        Ref<Viewport> pViewports
    );

    [NativeName("vkCmdSetViewportWithCountEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewportWithCountEXT")]
    void CmdSetViewportWithCountEXT(CommandBufferHandle commandBuffer, Viewport pViewports);

    [NativeName("vkCmdSetViewportWScalingEnableNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewportWScalingEnableNV")]
    void CmdSetViewportWScalingEnableNV(
        CommandBufferHandle commandBuffer,
        uint viewportWScalingEnable
    );

    [NativeName("vkCmdSetViewportWScalingEnableNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewportWScalingEnableNV")]
    void CmdSetViewportWScalingEnableNV(
        CommandBufferHandle commandBuffer,
        MaybeBool<uint> viewportWScalingEnable
    );

    [NativeName("vkCmdSetViewportWScalingNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewportWScalingNV")]
    void CmdSetViewportWScalingNV(
        CommandBufferHandle commandBuffer,
        uint firstViewport,
        uint viewportCount,
        ViewportWScalingNV* pViewportWScalings
    );

    [NativeName("vkCmdSetViewportWScalingNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewportWScalingNV")]
    void CmdSetViewportWScalingNV(
        CommandBufferHandle commandBuffer,
        uint firstViewport,
        uint viewportCount,
        Ref<ViewportWScalingNV> pViewportWScalings
    );

    [NativeName("vkCmdSetViewportWScalingNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSetViewportWScalingNV")]
    void CmdSetViewportWScalingNV(
        CommandBufferHandle commandBuffer,
        uint firstViewport,
        ViewportWScalingNV pViewportWScalings
    );

    [NativeName("vkCmdSubpassShadingHUAWEI")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdSubpassShadingHUAWEI")]
    void CmdSubpassShadingHUAWEI(CommandBufferHandle commandBuffer);

    [NativeName("vkCmdTraceRaysIndirect2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdTraceRaysIndirect2KHR")]
    void CmdTraceRaysIndirect2KHR(CommandBufferHandle commandBuffer, ulong indirectDeviceAddress);

    [NativeName("vkCmdTraceRaysIndirectKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdTraceRaysIndirectKHR")]
    void CmdTraceRaysIndirectKHR(
        CommandBufferHandle commandBuffer,
        StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable,
        StridedDeviceAddressRegionKHR* pMissShaderBindingTable,
        StridedDeviceAddressRegionKHR* pHitShaderBindingTable,
        StridedDeviceAddressRegionKHR* pCallableShaderBindingTable,
        ulong indirectDeviceAddress
    );

    [NativeName("vkCmdTraceRaysIndirectKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdTraceRaysIndirectKHR")]
    void CmdTraceRaysIndirectKHR(
        CommandBufferHandle commandBuffer,
        Ref<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable,
        Ref<StridedDeviceAddressRegionKHR> pMissShaderBindingTable,
        Ref<StridedDeviceAddressRegionKHR> pHitShaderBindingTable,
        Ref<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable,
        ulong indirectDeviceAddress
    );

    [NativeName("vkCmdTraceRaysKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdTraceRaysKHR")]
    void CmdTraceRaysKHR(
        CommandBufferHandle commandBuffer,
        StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable,
        StridedDeviceAddressRegionKHR* pMissShaderBindingTable,
        StridedDeviceAddressRegionKHR* pHitShaderBindingTable,
        StridedDeviceAddressRegionKHR* pCallableShaderBindingTable,
        uint width,
        uint height,
        uint depth
    );

    [NativeName("vkCmdTraceRaysKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdTraceRaysKHR")]
    void CmdTraceRaysKHR(
        CommandBufferHandle commandBuffer,
        Ref<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable,
        Ref<StridedDeviceAddressRegionKHR> pMissShaderBindingTable,
        Ref<StridedDeviceAddressRegionKHR> pHitShaderBindingTable,
        Ref<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable,
        uint width,
        uint height,
        uint depth
    );

    [NativeName("vkCmdTraceRaysNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdTraceRaysNV")]
    void CmdTraceRaysNV(
        CommandBufferHandle commandBuffer,
        BufferHandle raygenShaderBindingTableBuffer,
        ulong raygenShaderBindingOffset,
        BufferHandle missShaderBindingTableBuffer,
        ulong missShaderBindingOffset,
        ulong missShaderBindingStride,
        BufferHandle hitShaderBindingTableBuffer,
        ulong hitShaderBindingOffset,
        ulong hitShaderBindingStride,
        BufferHandle callableShaderBindingTableBuffer,
        ulong callableShaderBindingOffset,
        ulong callableShaderBindingStride,
        uint width,
        uint height,
        uint depth
    );

    [NativeName("vkCmdUpdateBuffer")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdUpdateBuffer")]
    void CmdUpdateBuffer(
        CommandBufferHandle commandBuffer,
        BufferHandle dstBuffer,
        ulong dstOffset,
        ulong dataSize,
        void* pData
    );

    [NativeName("vkCmdUpdateBuffer")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdUpdateBuffer")]
    void CmdUpdateBuffer(
        CommandBufferHandle commandBuffer,
        BufferHandle dstBuffer,
        ulong dstOffset,
        ulong dataSize,
        Ref pData
    );

    [NativeName("vkCmdUpdateMemoryKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdUpdateMemoryKHR")]
    void CmdUpdateMemoryKHR(
        CommandBufferHandle commandBuffer,
        DeviceAddressRangeKHR* pDstRange,
        AddressCommandFlagsKHR dstFlags,
        ulong dataSize,
        void* pData
    );

    [NativeName("vkCmdUpdateMemoryKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdUpdateMemoryKHR")]
    void CmdUpdateMemoryKHR(
        CommandBufferHandle commandBuffer,
        Ref<DeviceAddressRangeKHR> pDstRange,
        AddressCommandFlagsKHR dstFlags,
        ulong dataSize,
        Ref pData
    );

    [NativeName("vkCmdUpdatePipelineIndirectBufferNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdUpdatePipelineIndirectBufferNV")]
    void CmdUpdatePipelineIndirectBufferNV(
        CommandBufferHandle commandBuffer,
        PipelineBindPoint pipelineBindPoint,
        PipelineHandle pipeline
    );

    [NativeName("vkCmdWaitEvents")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdWaitEvents")]
    void CmdWaitEvents(
        CommandBufferHandle commandBuffer,
        uint eventCount,
        EventHandle* pEvents,
        PipelineStageFlags srcStageMask,
        PipelineStageFlags dstStageMask,
        uint memoryBarrierCount,
        MemoryBarrier* pMemoryBarriers,
        uint bufferMemoryBarrierCount,
        BufferMemoryBarrier* pBufferMemoryBarriers,
        uint imageMemoryBarrierCount,
        ImageMemoryBarrier* pImageMemoryBarriers
    );

    [NativeName("vkCmdWaitEvents")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdWaitEvents")]
    void CmdWaitEvents(
        CommandBufferHandle commandBuffer,
        uint eventCount,
        Ref<EventHandle> pEvents,
        PipelineStageFlags srcStageMask,
        PipelineStageFlags dstStageMask,
        uint memoryBarrierCount,
        Ref<MemoryBarrier> pMemoryBarriers,
        uint bufferMemoryBarrierCount,
        Ref<BufferMemoryBarrier> pBufferMemoryBarriers,
        uint imageMemoryBarrierCount,
        Ref<ImageMemoryBarrier> pImageMemoryBarriers
    );

    [NativeName("vkCmdWaitEvents2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdWaitEvents2")]
    void CmdWaitEvents2(
        CommandBufferHandle commandBuffer,
        uint eventCount,
        EventHandle* pEvents,
        DependencyInfo* pDependencyInfos
    );

    [NativeName("vkCmdWaitEvents2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdWaitEvents2")]
    void CmdWaitEvents2(
        CommandBufferHandle commandBuffer,
        uint eventCount,
        Ref<EventHandle> pEvents,
        Ref<DependencyInfo> pDependencyInfos
    );

    [NativeName("vkCmdWaitEvents2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdWaitEvents2KHR")]
    void CmdWaitEvents2KHR(
        CommandBufferHandle commandBuffer,
        uint eventCount,
        EventHandle* pEvents,
        DependencyInfo* pDependencyInfos
    );

    [NativeName("vkCmdWaitEvents2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdWaitEvents2KHR")]
    void CmdWaitEvents2KHR(
        CommandBufferHandle commandBuffer,
        uint eventCount,
        Ref<EventHandle> pEvents,
        Ref<DependencyInfo> pDependencyInfos
    );

    [NativeName("vkCmdWriteAccelerationStructuresPropertiesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdWriteAccelerationStructuresPropertiesKHR")]
    void CmdWriteAccelerationStructuresPropertiesKHR(
        CommandBufferHandle commandBuffer,
        uint accelerationStructureCount,
        AccelerationStructureHandleKHR* pAccelerationStructures,
        QueryType queryType,
        QueryPoolHandle queryPool,
        uint firstQuery
    );

    [NativeName("vkCmdWriteAccelerationStructuresPropertiesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdWriteAccelerationStructuresPropertiesKHR")]
    void CmdWriteAccelerationStructuresPropertiesKHR(
        CommandBufferHandle commandBuffer,
        uint accelerationStructureCount,
        Ref<AccelerationStructureHandleKHR> pAccelerationStructures,
        QueryType queryType,
        QueryPoolHandle queryPool,
        uint firstQuery
    );

    [NativeName("vkCmdWriteAccelerationStructuresPropertiesNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdWriteAccelerationStructuresPropertiesNV")]
    void CmdWriteAccelerationStructuresPropertiesNV(
        CommandBufferHandle commandBuffer,
        uint accelerationStructureCount,
        AccelerationStructureHandleNV* pAccelerationStructures,
        QueryType queryType,
        QueryPoolHandle queryPool,
        uint firstQuery
    );

    [NativeName("vkCmdWriteAccelerationStructuresPropertiesNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdWriteAccelerationStructuresPropertiesNV")]
    void CmdWriteAccelerationStructuresPropertiesNV(
        CommandBufferHandle commandBuffer,
        uint accelerationStructureCount,
        Ref<AccelerationStructureHandleNV> pAccelerationStructures,
        QueryType queryType,
        QueryPoolHandle queryPool,
        uint firstQuery
    );

    [NativeName("vkCmdWriteAccelerationStructuresPropertiesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdWriteAccelerationStructuresPropertiesKHR")]
    void CmdWriteAccelerationStructuresPropertyKHR(
        CommandBufferHandle commandBuffer,
        AccelerationStructureHandleKHR pAccelerationStructures,
        QueryType queryType,
        QueryPoolHandle queryPool,
        uint firstQuery
    );

    [NativeName("vkCmdWriteAccelerationStructuresPropertiesNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdWriteAccelerationStructuresPropertiesNV")]
    void CmdWriteAccelerationStructuresPropertyNV(
        CommandBufferHandle commandBuffer,
        AccelerationStructureHandleNV pAccelerationStructures,
        QueryType queryType,
        QueryPoolHandle queryPool,
        uint firstQuery
    );

    [NativeName("vkCmdWriteBufferMarker2AMD")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdWriteBufferMarker2AMD")]
    void CmdWriteBufferMarker2AMD(
        CommandBufferHandle commandBuffer,
        PipelineStageFlags2 stage,
        BufferHandle dstBuffer,
        ulong dstOffset,
        uint marker
    );

    [NativeName("vkCmdWriteBufferMarkerAMD")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdWriteBufferMarkerAMD")]
    void CmdWriteBufferMarkerAMD(
        CommandBufferHandle commandBuffer,
        PipelineStageFlags pipelineStage,
        BufferHandle dstBuffer,
        ulong dstOffset,
        uint marker
    );

    [NativeName("vkCmdWriteMarkerToMemoryAMD")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdWriteMarkerToMemoryAMD")]
    void CmdWriteMarkerToMemoryAMD(CommandBufferHandle commandBuffer, MemoryMarkerInfoAMD* pInfo);

    [NativeName("vkCmdWriteMarkerToMemoryAMD")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdWriteMarkerToMemoryAMD")]
    void CmdWriteMarkerToMemoryAMD(
        CommandBufferHandle commandBuffer,
        Ref<MemoryMarkerInfoAMD> pInfo
    );

    [NativeName("vkCmdWriteMicromapsPropertiesEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdWriteMicromapsPropertiesEXT")]
    void CmdWriteMicromapsPropertiesEXT(
        CommandBufferHandle commandBuffer,
        uint micromapCount,
        MicromapHandleEXT* pMicromaps,
        QueryType queryType,
        QueryPoolHandle queryPool,
        uint firstQuery
    );

    [NativeName("vkCmdWriteMicromapsPropertiesEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdWriteMicromapsPropertiesEXT")]
    void CmdWriteMicromapsPropertiesEXT(
        CommandBufferHandle commandBuffer,
        uint micromapCount,
        Ref<MicromapHandleEXT> pMicromaps,
        QueryType queryType,
        QueryPoolHandle queryPool,
        uint firstQuery
    );

    [NativeName("vkCmdWriteMicromapsPropertiesEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdWriteMicromapsPropertiesEXT")]
    void CmdWriteMicromapsPropertyEXT(
        CommandBufferHandle commandBuffer,
        MicromapHandleEXT pMicromaps,
        QueryType queryType,
        QueryPoolHandle queryPool,
        uint firstQuery
    );

    [NativeName("vkCmdWriteTimestamp")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdWriteTimestamp")]
    void CmdWriteTimestamp(
        CommandBufferHandle commandBuffer,
        PipelineStageFlags pipelineStage,
        QueryPoolHandle queryPool,
        uint query
    );

    [NativeName("vkCmdWriteTimestamp2")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdWriteTimestamp2")]
    void CmdWriteTimestamp2(
        CommandBufferHandle commandBuffer,
        PipelineStageFlags2 stage,
        QueryPoolHandle queryPool,
        uint query
    );

    [NativeName("vkCmdWriteTimestamp2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCmdWriteTimestamp2KHR")]
    void CmdWriteTimestamp2KHR(
        CommandBufferHandle commandBuffer,
        PipelineStageFlags2 stage,
        QueryPoolHandle queryPool,
        uint query
    );

    [NativeName("vkCompileDeferredNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCompileDeferredNV")]
    Result CompileDeferredNV(DeviceHandle device, PipelineHandle pipeline, uint shader);

    [NativeName("vkConvertCooperativeVectorMatrixNV")]
    [NativeFunction("vulkan", EntryPoint = "vkConvertCooperativeVectorMatrixNV")]
    Result ConvertCooperativeVectorMatrixNV(
        DeviceHandle device,
        ConvertCooperativeVectorMatrixInfoNV* pInfo
    );

    [NativeName("vkConvertCooperativeVectorMatrixNV")]
    [NativeFunction("vulkan", EntryPoint = "vkConvertCooperativeVectorMatrixNV")]
    Result ConvertCooperativeVectorMatrixNV(
        DeviceHandle device,
        Ref<ConvertCooperativeVectorMatrixInfoNV> pInfo
    );

    [NativeName("vkCopyAccelerationStructureKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCopyAccelerationStructureKHR")]
    Result CopyAccelerationStructureKHR(
        DeviceHandle device,
        DeferredOperationHandleKHR deferredOperation,
        CopyAccelerationStructureInfoKHR* pInfo
    );

    [NativeName("vkCopyAccelerationStructureKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCopyAccelerationStructureKHR")]
    Result CopyAccelerationStructureKHR(
        DeviceHandle device,
        DeferredOperationHandleKHR deferredOperation,
        Ref<CopyAccelerationStructureInfoKHR> pInfo
    );

    [NativeName("vkCopyAccelerationStructureToMemoryKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCopyAccelerationStructureToMemoryKHR")]
    Result CopyAccelerationStructureToMemoryKHR(
        DeviceHandle device,
        DeferredOperationHandleKHR deferredOperation,
        CopyAccelerationStructureToMemoryInfoKHR* pInfo
    );

    [NativeName("vkCopyAccelerationStructureToMemoryKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCopyAccelerationStructureToMemoryKHR")]
    Result CopyAccelerationStructureToMemoryKHR(
        DeviceHandle device,
        DeferredOperationHandleKHR deferredOperation,
        Ref<CopyAccelerationStructureToMemoryInfoKHR> pInfo
    );

    [NativeName("vkCopyImageToImage")]
    [NativeFunction("vulkan", EntryPoint = "vkCopyImageToImage")]
    Result CopyImageToImage(DeviceHandle device, CopyImageToImageInfo* pCopyImageToImageInfo);

    [NativeName("vkCopyImageToImage")]
    [NativeFunction("vulkan", EntryPoint = "vkCopyImageToImage")]
    Result CopyImageToImage(DeviceHandle device, Ref<CopyImageToImageInfo> pCopyImageToImageInfo);

    [NativeName("vkCopyImageToImageEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCopyImageToImageEXT")]
    Result CopyImageToImageEXT(DeviceHandle device, CopyImageToImageInfo* pCopyImageToImageInfo);

    [NativeName("vkCopyImageToImageEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCopyImageToImageEXT")]
    Result CopyImageToImageEXT(
        DeviceHandle device,
        Ref<CopyImageToImageInfo> pCopyImageToImageInfo
    );

    [NativeName("vkCopyImageToMemory")]
    [NativeFunction("vulkan", EntryPoint = "vkCopyImageToMemory")]
    Result CopyImageToMemory(DeviceHandle device, CopyImageToMemoryInfo* pCopyImageToMemoryInfo);

    [NativeName("vkCopyImageToMemory")]
    [NativeFunction("vulkan", EntryPoint = "vkCopyImageToMemory")]
    Result CopyImageToMemory(
        DeviceHandle device,
        Ref<CopyImageToMemoryInfo> pCopyImageToMemoryInfo
    );

    [NativeName("vkCopyImageToMemoryEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCopyImageToMemoryEXT")]
    Result CopyImageToMemoryEXT(DeviceHandle device, CopyImageToMemoryInfo* pCopyImageToMemoryInfo);

    [NativeName("vkCopyImageToMemoryEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCopyImageToMemoryEXT")]
    Result CopyImageToMemoryEXT(
        DeviceHandle device,
        Ref<CopyImageToMemoryInfo> pCopyImageToMemoryInfo
    );

    [NativeName("vkCopyMemoryToAccelerationStructureKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCopyMemoryToAccelerationStructureKHR")]
    Result CopyMemoryToAccelerationStructureKHR(
        DeviceHandle device,
        DeferredOperationHandleKHR deferredOperation,
        CopyMemoryToAccelerationStructureInfoKHR* pInfo
    );

    [NativeName("vkCopyMemoryToAccelerationStructureKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCopyMemoryToAccelerationStructureKHR")]
    Result CopyMemoryToAccelerationStructureKHR(
        DeviceHandle device,
        DeferredOperationHandleKHR deferredOperation,
        Ref<CopyMemoryToAccelerationStructureInfoKHR> pInfo
    );

    [NativeName("vkCopyMemoryToImage")]
    [NativeFunction("vulkan", EntryPoint = "vkCopyMemoryToImage")]
    Result CopyMemoryToImage(DeviceHandle device, CopyMemoryToImageInfo* pCopyMemoryToImageInfo);

    [NativeName("vkCopyMemoryToImage")]
    [NativeFunction("vulkan", EntryPoint = "vkCopyMemoryToImage")]
    Result CopyMemoryToImage(
        DeviceHandle device,
        Ref<CopyMemoryToImageInfo> pCopyMemoryToImageInfo
    );

    [NativeName("vkCopyMemoryToImageEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCopyMemoryToImageEXT")]
    Result CopyMemoryToImageEXT(DeviceHandle device, CopyMemoryToImageInfo* pCopyMemoryToImageInfo);

    [NativeName("vkCopyMemoryToImageEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCopyMemoryToImageEXT")]
    Result CopyMemoryToImageEXT(
        DeviceHandle device,
        Ref<CopyMemoryToImageInfo> pCopyMemoryToImageInfo
    );

    [NativeName("vkCopyMemoryToMicromapEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCopyMemoryToMicromapEXT")]
    Result CopyMemoryToMicromapEXT(
        DeviceHandle device,
        DeferredOperationHandleKHR deferredOperation,
        CopyMemoryToMicromapInfoEXT* pInfo
    );

    [NativeName("vkCopyMemoryToMicromapEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCopyMemoryToMicromapEXT")]
    Result CopyMemoryToMicromapEXT(
        DeviceHandle device,
        DeferredOperationHandleKHR deferredOperation,
        Ref<CopyMemoryToMicromapInfoEXT> pInfo
    );

    [NativeName("vkCopyMicromapEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCopyMicromapEXT")]
    Result CopyMicromapEXT(
        DeviceHandle device,
        DeferredOperationHandleKHR deferredOperation,
        CopyMicromapInfoEXT* pInfo
    );

    [NativeName("vkCopyMicromapEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCopyMicromapEXT")]
    Result CopyMicromapEXT(
        DeviceHandle device,
        DeferredOperationHandleKHR deferredOperation,
        Ref<CopyMicromapInfoEXT> pInfo
    );

    [NativeName("vkCopyMicromapToMemoryEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCopyMicromapToMemoryEXT")]
    Result CopyMicromapToMemoryEXT(
        DeviceHandle device,
        DeferredOperationHandleKHR deferredOperation,
        CopyMicromapToMemoryInfoEXT* pInfo
    );

    [NativeName("vkCopyMicromapToMemoryEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCopyMicromapToMemoryEXT")]
    Result CopyMicromapToMemoryEXT(
        DeviceHandle device,
        DeferredOperationHandleKHR deferredOperation,
        Ref<CopyMicromapToMemoryInfoEXT> pInfo
    );

    [NativeName("vkCreateAccelerationStructure2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateAccelerationStructure2KHR")]
    Result CreateAccelerationStructure2KHR(
        DeviceHandle device,
        AccelerationStructureCreateInfo2KHR* pCreateInfo,
        AllocationCallbacks* pAllocator,
        AccelerationStructureHandleKHR* pAccelerationStructure
    );

    [NativeName("vkCreateAccelerationStructure2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateAccelerationStructure2KHR")]
    Result CreateAccelerationStructure2KHR(
        DeviceHandle device,
        Ref<AccelerationStructureCreateInfo2KHR> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<AccelerationStructureHandleKHR> pAccelerationStructure
    );

    [NativeName("vkCreateAccelerationStructureKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateAccelerationStructureKHR")]
    Result CreateAccelerationStructureKHR(
        DeviceHandle device,
        AccelerationStructureCreateInfoKHR* pCreateInfo,
        AllocationCallbacks* pAllocator,
        AccelerationStructureHandleKHR* pAccelerationStructure
    );

    [NativeName("vkCreateAccelerationStructureKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateAccelerationStructureKHR")]
    Result CreateAccelerationStructureKHR(
        DeviceHandle device,
        Ref<AccelerationStructureCreateInfoKHR> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<AccelerationStructureHandleKHR> pAccelerationStructure
    );

    [NativeName("vkCreateAccelerationStructureNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateAccelerationStructureNV")]
    Result CreateAccelerationStructureNV(
        DeviceHandle device,
        AccelerationStructureCreateInfoNV* pCreateInfo,
        AllocationCallbacks* pAllocator,
        AccelerationStructureHandleNV* pAccelerationStructure
    );

    [NativeName("vkCreateAccelerationStructureNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateAccelerationStructureNV")]
    Result CreateAccelerationStructureNV(
        DeviceHandle device,
        Ref<AccelerationStructureCreateInfoNV> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<AccelerationStructureHandleNV> pAccelerationStructure
    );

    [NativeName("vkCreateBuffer")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateBuffer")]
    Result CreateBuffer(
        DeviceHandle device,
        BufferCreateInfo* pCreateInfo,
        AllocationCallbacks* pAllocator,
        BufferHandle* pBuffer
    );

    [NativeName("vkCreateBuffer")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateBuffer")]
    Result CreateBuffer(
        DeviceHandle device,
        Ref<BufferCreateInfo> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<BufferHandle> pBuffer
    );

    [NativeName("vkCreateBufferView")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateBufferView")]
    Result CreateBufferView(
        DeviceHandle device,
        BufferViewCreateInfo* pCreateInfo,
        AllocationCallbacks* pAllocator,
        BufferViewHandle* pView
    );

    [NativeName("vkCreateBufferView")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateBufferView")]
    Result CreateBufferView(
        DeviceHandle device,
        Ref<BufferViewCreateInfo> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<BufferViewHandle> pView
    );

    [NativeName("vkCreateCommandPool")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateCommandPool")]
    Result CreateCommandPool(
        DeviceHandle device,
        CommandPoolCreateInfo* pCreateInfo,
        AllocationCallbacks* pAllocator,
        CommandPoolHandle* pCommandPool
    );

    [NativeName("vkCreateCommandPool")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateCommandPool")]
    Result CreateCommandPool(
        DeviceHandle device,
        Ref<CommandPoolCreateInfo> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<CommandPoolHandle> pCommandPool
    );

    [NativeName("vkCreateComputePipelines")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateComputePipelines")]
    Result CreateComputePipelines(
        DeviceHandle device,
        PipelineCacheHandle pipelineCache,
        uint createInfoCount,
        ComputePipelineCreateInfo* pCreateInfos,
        AllocationCallbacks* pAllocator,
        PipelineHandle* pPipelines
    );

    [NativeName("vkCreateComputePipelines")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateComputePipelines")]
    Result CreateComputePipelines(
        DeviceHandle device,
        PipelineCacheHandle pipelineCache,
        uint createInfoCount,
        Ref<ComputePipelineCreateInfo> pCreateInfos,
        Ref<AllocationCallbacks> pAllocator,
        Ref<PipelineHandle> pPipelines
    );

    [NativeName("vkCreateCuFunctionNVX")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateCuFunctionNVX")]
    Result CreateCuFunctionNVX(
        DeviceHandle device,
        CuFunctionCreateInfoNVX* pCreateInfo,
        AllocationCallbacks* pAllocator,
        CuFunctionHandleNVX* pFunction
    );

    [NativeName("vkCreateCuFunctionNVX")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateCuFunctionNVX")]
    Result CreateCuFunctionNVX(
        DeviceHandle device,
        Ref<CuFunctionCreateInfoNVX> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<CuFunctionHandleNVX> pFunction
    );

    [NativeName("vkCreateCuModuleNVX")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateCuModuleNVX")]
    Result CreateCuModuleNVX(
        DeviceHandle device,
        CuModuleCreateInfoNVX* pCreateInfo,
        AllocationCallbacks* pAllocator,
        CuModuleHandleNVX* pModule
    );

    [NativeName("vkCreateCuModuleNVX")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateCuModuleNVX")]
    Result CreateCuModuleNVX(
        DeviceHandle device,
        Ref<CuModuleCreateInfoNVX> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<CuModuleHandleNVX> pModule
    );

    [NativeName("vkCreateDataGraphPipelinesARM")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateDataGraphPipelinesARM")]
    Result CreateDataGraphPipelinesARM(
        DeviceHandle device,
        DeferredOperationHandleKHR deferredOperation,
        PipelineCacheHandle pipelineCache,
        uint createInfoCount,
        DataGraphPipelineCreateInfoARM* pCreateInfos,
        AllocationCallbacks* pAllocator,
        PipelineHandle* pPipelines
    );

    [NativeName("vkCreateDataGraphPipelinesARM")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateDataGraphPipelinesARM")]
    Result CreateDataGraphPipelinesARM(
        DeviceHandle device,
        DeferredOperationHandleKHR deferredOperation,
        PipelineCacheHandle pipelineCache,
        uint createInfoCount,
        Ref<DataGraphPipelineCreateInfoARM> pCreateInfos,
        Ref<AllocationCallbacks> pAllocator,
        Ref<PipelineHandle> pPipelines
    );

    [NativeName("vkCreateDataGraphPipelineSessionARM")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateDataGraphPipelineSessionARM")]
    Result CreateDataGraphPipelineSessionARM(
        DeviceHandle device,
        DataGraphPipelineSessionCreateInfoARM* pCreateInfo,
        AllocationCallbacks* pAllocator,
        DataGraphPipelineSessionHandleARM* pSession
    );

    [NativeName("vkCreateDataGraphPipelineSessionARM")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateDataGraphPipelineSessionARM")]
    Result CreateDataGraphPipelineSessionARM(
        DeviceHandle device,
        Ref<DataGraphPipelineSessionCreateInfoARM> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<DataGraphPipelineSessionHandleARM> pSession
    );

    [NativeName("vkCreateDebugReportCallbackEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateDebugReportCallbackEXT")]
    Result CreateDebugReportCallbackEXT(
        InstanceHandle instance,
        DebugReportCallbackCreateInfoEXT* pCreateInfo,
        AllocationCallbacks* pAllocator,
        DebugReportCallbackHandleEXT* pCallback
    );

    [NativeName("vkCreateDebugReportCallbackEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateDebugReportCallbackEXT")]
    Result CreateDebugReportCallbackEXT(
        InstanceHandle instance,
        Ref<DebugReportCallbackCreateInfoEXT> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<DebugReportCallbackHandleEXT> pCallback
    );

    [NativeName("vkCreateDebugUtilsMessengerEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateDebugUtilsMessengerEXT")]
    Result CreateDebugUtilsMessengerEXT(
        InstanceHandle instance,
        DebugUtilsMessengerCreateInfoEXT* pCreateInfo,
        AllocationCallbacks* pAllocator,
        DebugUtilsMessengerHandleEXT* pMessenger
    );

    [NativeName("vkCreateDebugUtilsMessengerEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateDebugUtilsMessengerEXT")]
    Result CreateDebugUtilsMessengerEXT(
        InstanceHandle instance,
        Ref<DebugUtilsMessengerCreateInfoEXT> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<DebugUtilsMessengerHandleEXT> pMessenger
    );

    [NativeName("vkCreateDeferredOperationKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateDeferredOperationKHR")]
    Result CreateDeferredOperationKHR(
        DeviceHandle device,
        AllocationCallbacks* pAllocator,
        DeferredOperationHandleKHR* pDeferredOperation
    );

    [NativeName("vkCreateDeferredOperationKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateDeferredOperationKHR")]
    Result CreateDeferredOperationKHR(
        DeviceHandle device,
        Ref<AllocationCallbacks> pAllocator,
        Ref<DeferredOperationHandleKHR> pDeferredOperation
    );

    [NativeName("vkCreateDescriptorPool")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateDescriptorPool")]
    Result CreateDescriptorPool(
        DeviceHandle device,
        DescriptorPoolCreateInfo* pCreateInfo,
        AllocationCallbacks* pAllocator,
        DescriptorPoolHandle* pDescriptorPool
    );

    [NativeName("vkCreateDescriptorPool")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateDescriptorPool")]
    Result CreateDescriptorPool(
        DeviceHandle device,
        Ref<DescriptorPoolCreateInfo> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<DescriptorPoolHandle> pDescriptorPool
    );

    [NativeName("vkCreateDescriptorSetLayout")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateDescriptorSetLayout")]
    Result CreateDescriptorSetLayout(
        DeviceHandle device,
        DescriptorSetLayoutCreateInfo* pCreateInfo,
        AllocationCallbacks* pAllocator,
        DescriptorSetLayoutHandle* pSetLayout
    );

    [NativeName("vkCreateDescriptorSetLayout")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateDescriptorSetLayout")]
    Result CreateDescriptorSetLayout(
        DeviceHandle device,
        Ref<DescriptorSetLayoutCreateInfo> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<DescriptorSetLayoutHandle> pSetLayout
    );

    [NativeName("vkCreateDescriptorUpdateTemplate")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateDescriptorUpdateTemplate")]
    Result CreateDescriptorUpdateTemplate(
        DeviceHandle device,
        DescriptorUpdateTemplateCreateInfo* pCreateInfo,
        AllocationCallbacks* pAllocator,
        DescriptorUpdateTemplateHandle* pDescriptorUpdateTemplate
    );

    [NativeName("vkCreateDescriptorUpdateTemplate")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateDescriptorUpdateTemplate")]
    Result CreateDescriptorUpdateTemplate(
        DeviceHandle device,
        Ref<DescriptorUpdateTemplateCreateInfo> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<DescriptorUpdateTemplateHandle> pDescriptorUpdateTemplate
    );

    [NativeName("vkCreateDescriptorUpdateTemplateKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateDescriptorUpdateTemplateKHR")]
    Result CreateDescriptorUpdateTemplateKHR(
        DeviceHandle device,
        DescriptorUpdateTemplateCreateInfo* pCreateInfo,
        AllocationCallbacks* pAllocator,
        DescriptorUpdateTemplateHandle* pDescriptorUpdateTemplate
    );

    [NativeName("vkCreateDescriptorUpdateTemplateKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateDescriptorUpdateTemplateKHR")]
    Result CreateDescriptorUpdateTemplateKHR(
        DeviceHandle device,
        Ref<DescriptorUpdateTemplateCreateInfo> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<DescriptorUpdateTemplateHandle> pDescriptorUpdateTemplate
    );

    [NativeName("vkCreateDevice")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateDevice")]
    Result CreateDevice(
        PhysicalDeviceHandle physicalDevice,
        DeviceCreateInfo* pCreateInfo,
        AllocationCallbacks* pAllocator,
        DeviceHandle* pDevice
    );

    [NativeName("vkCreateDevice")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateDevice")]
    Result CreateDevice(
        PhysicalDeviceHandle physicalDevice,
        Ref<DeviceCreateInfo> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<DeviceHandle> pDevice
    );

    [NativeName("vkCreateDisplayModeKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateDisplayModeKHR")]
    Result CreateDisplayModeKHR(
        PhysicalDeviceHandle physicalDevice,
        DisplayHandleKHR display,
        DisplayModeCreateInfoKHR* pCreateInfo,
        AllocationCallbacks* pAllocator,
        DisplayModeHandleKHR* pMode
    );

    [NativeName("vkCreateDisplayModeKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateDisplayModeKHR")]
    Result CreateDisplayModeKHR(
        PhysicalDeviceHandle physicalDevice,
        DisplayHandleKHR display,
        Ref<DisplayModeCreateInfoKHR> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<DisplayModeHandleKHR> pMode
    );

    [NativeName("vkCreateDisplayPlaneSurfaceKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateDisplayPlaneSurfaceKHR")]
    Result CreateDisplayPlaneSurfaceKHR(
        InstanceHandle instance,
        DisplaySurfaceCreateInfoKHR* pCreateInfo,
        AllocationCallbacks* pAllocator,
        SurfaceHandleKHR* pSurface
    );

    [NativeName("vkCreateDisplayPlaneSurfaceKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateDisplayPlaneSurfaceKHR")]
    Result CreateDisplayPlaneSurfaceKHR(
        InstanceHandle instance,
        Ref<DisplaySurfaceCreateInfoKHR> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<SurfaceHandleKHR> pSurface
    );

    [NativeName("vkCreateEvent")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateEvent")]
    Result CreateEvent(
        DeviceHandle device,
        EventCreateInfo* pCreateInfo,
        AllocationCallbacks* pAllocator,
        EventHandle* pEvent
    );

    [NativeName("vkCreateEvent")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateEvent")]
    Result CreateEvent(
        DeviceHandle device,
        Ref<EventCreateInfo> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<EventHandle> pEvent
    );

    [NativeName("vkCreateExternalComputeQueueNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateExternalComputeQueueNV")]
    Result CreateExternalComputeQueueNV(
        DeviceHandle device,
        ExternalComputeQueueCreateInfoNV* pCreateInfo,
        AllocationCallbacks* pAllocator,
        ExternalComputeQueueHandleNV* pExternalQueue
    );

    [NativeName("vkCreateExternalComputeQueueNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateExternalComputeQueueNV")]
    Result CreateExternalComputeQueueNV(
        DeviceHandle device,
        Ref<ExternalComputeQueueCreateInfoNV> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<ExternalComputeQueueHandleNV> pExternalQueue
    );

    [NativeName("vkCreateFence")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateFence")]
    Result CreateFence(
        DeviceHandle device,
        FenceCreateInfo* pCreateInfo,
        AllocationCallbacks* pAllocator,
        FenceHandle* pFence
    );

    [NativeName("vkCreateFence")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateFence")]
    Result CreateFence(
        DeviceHandle device,
        Ref<FenceCreateInfo> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<FenceHandle> pFence
    );

    [NativeName("vkCreateFramebuffer")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateFramebuffer")]
    Result CreateFramebuffer(
        DeviceHandle device,
        FramebufferCreateInfo* pCreateInfo,
        AllocationCallbacks* pAllocator,
        FramebufferHandle* pFramebuffer
    );

    [NativeName("vkCreateFramebuffer")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateFramebuffer")]
    Result CreateFramebuffer(
        DeviceHandle device,
        Ref<FramebufferCreateInfo> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<FramebufferHandle> pFramebuffer
    );

    [NativeName("vkCreateGpaSessionAMD")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateGpaSessionAMD")]
    Result CreateGpaSessionAMD(
        DeviceHandle device,
        GpaSessionCreateInfoAMD* pCreateInfo,
        AllocationCallbacks* pAllocator,
        GpaSessionHandleAMD* pGpaSession
    );

    [NativeName("vkCreateGpaSessionAMD")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateGpaSessionAMD")]
    Result CreateGpaSessionAMD(
        DeviceHandle device,
        Ref<GpaSessionCreateInfoAMD> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<GpaSessionHandleAMD> pGpaSession
    );

    [NativeName("vkCreateGraphicsPipelines")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateGraphicsPipelines")]
    Result CreateGraphicsPipelines(
        DeviceHandle device,
        PipelineCacheHandle pipelineCache,
        uint createInfoCount,
        GraphicsPipelineCreateInfo* pCreateInfos,
        AllocationCallbacks* pAllocator,
        PipelineHandle* pPipelines
    );

    [NativeName("vkCreateGraphicsPipelines")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateGraphicsPipelines")]
    Result CreateGraphicsPipelines(
        DeviceHandle device,
        PipelineCacheHandle pipelineCache,
        uint createInfoCount,
        Ref<GraphicsPipelineCreateInfo> pCreateInfos,
        Ref<AllocationCallbacks> pAllocator,
        Ref<PipelineHandle> pPipelines
    );

    [NativeName("vkCreateHeadlessSurfaceEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateHeadlessSurfaceEXT")]
    Result CreateHeadlessSurfaceEXT(
        InstanceHandle instance,
        HeadlessSurfaceCreateInfoEXT* pCreateInfo,
        AllocationCallbacks* pAllocator,
        SurfaceHandleKHR* pSurface
    );

    [NativeName("vkCreateHeadlessSurfaceEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateHeadlessSurfaceEXT")]
    Result CreateHeadlessSurfaceEXT(
        InstanceHandle instance,
        Ref<HeadlessSurfaceCreateInfoEXT> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<SurfaceHandleKHR> pSurface
    );

    [NativeName("vkCreateImage")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateImage")]
    Result CreateImage(
        DeviceHandle device,
        ImageCreateInfo* pCreateInfo,
        AllocationCallbacks* pAllocator,
        ImageHandle* pImage
    );

    [NativeName("vkCreateImage")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateImage")]
    Result CreateImage(
        DeviceHandle device,
        Ref<ImageCreateInfo> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<ImageHandle> pImage
    );

    [NativeName("vkCreateImageView")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateImageView")]
    Result CreateImageView(
        DeviceHandle device,
        ImageViewCreateInfo* pCreateInfo,
        AllocationCallbacks* pAllocator,
        ImageViewHandle* pView
    );

    [NativeName("vkCreateImageView")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateImageView")]
    Result CreateImageView(
        DeviceHandle device,
        Ref<ImageViewCreateInfo> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<ImageViewHandle> pView
    );

    [NativeName("vkCreateIndirectCommandsLayoutEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateIndirectCommandsLayoutEXT")]
    Result CreateIndirectCommandsLayoutEXT(
        DeviceHandle device,
        IndirectCommandsLayoutCreateInfoEXT* pCreateInfo,
        AllocationCallbacks* pAllocator,
        IndirectCommandsLayoutHandleEXT* pIndirectCommandsLayout
    );

    [NativeName("vkCreateIndirectCommandsLayoutEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateIndirectCommandsLayoutEXT")]
    Result CreateIndirectCommandsLayoutEXT(
        DeviceHandle device,
        Ref<IndirectCommandsLayoutCreateInfoEXT> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<IndirectCommandsLayoutHandleEXT> pIndirectCommandsLayout
    );

    [NativeName("vkCreateIndirectCommandsLayoutNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateIndirectCommandsLayoutNV")]
    Result CreateIndirectCommandsLayoutNV(
        DeviceHandle device,
        IndirectCommandsLayoutCreateInfoNV* pCreateInfo,
        AllocationCallbacks* pAllocator,
        IndirectCommandsLayoutHandleNV* pIndirectCommandsLayout
    );

    [NativeName("vkCreateIndirectCommandsLayoutNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateIndirectCommandsLayoutNV")]
    Result CreateIndirectCommandsLayoutNV(
        DeviceHandle device,
        Ref<IndirectCommandsLayoutCreateInfoNV> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<IndirectCommandsLayoutHandleNV> pIndirectCommandsLayout
    );

    [NativeName("vkCreateIndirectExecutionSetEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateIndirectExecutionSetEXT")]
    Result CreateIndirectExecutionSetEXT(
        DeviceHandle device,
        IndirectExecutionSetCreateInfoEXT* pCreateInfo,
        AllocationCallbacks* pAllocator,
        IndirectExecutionSetHandleEXT* pIndirectExecutionSet
    );

    [NativeName("vkCreateIndirectExecutionSetEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateIndirectExecutionSetEXT")]
    Result CreateIndirectExecutionSetEXT(
        DeviceHandle device,
        Ref<IndirectExecutionSetCreateInfoEXT> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<IndirectExecutionSetHandleEXT> pIndirectExecutionSet
    );

    [NativeName("vkCreateInstance")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateInstance")]
    Result CreateInstance(
        InstanceCreateInfo* pCreateInfo,
        AllocationCallbacks* pAllocator,
        InstanceHandle* pInstance
    );

    [NativeName("vkCreateInstance")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateInstance")]
    Result CreateInstance(
        Ref<InstanceCreateInfo> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<InstanceHandle> pInstance
    );

    [NativeName("vkCreateMicromapEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateMicromapEXT")]
    Result CreateMicromapEXT(
        DeviceHandle device,
        MicromapCreateInfoEXT* pCreateInfo,
        AllocationCallbacks* pAllocator,
        MicromapHandleEXT* pMicromap
    );

    [NativeName("vkCreateMicromapEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateMicromapEXT")]
    Result CreateMicromapEXT(
        DeviceHandle device,
        Ref<MicromapCreateInfoEXT> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<MicromapHandleEXT> pMicromap
    );

    [NativeName("vkCreateOpticalFlowSessionNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateOpticalFlowSessionNV")]
    Result CreateOpticalFlowSessionNV(
        DeviceHandle device,
        OpticalFlowSessionCreateInfoNV* pCreateInfo,
        AllocationCallbacks* pAllocator,
        OpticalFlowSessionHandleNV* pSession
    );

    [NativeName("vkCreateOpticalFlowSessionNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateOpticalFlowSessionNV")]
    Result CreateOpticalFlowSessionNV(
        DeviceHandle device,
        Ref<OpticalFlowSessionCreateInfoNV> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<OpticalFlowSessionHandleNV> pSession
    );

    [NativeName("vkCreatePipelineBinariesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCreatePipelineBinariesKHR")]
    Result CreatePipelineBinariesKHR(
        DeviceHandle device,
        PipelineBinaryCreateInfoKHR* pCreateInfo,
        AllocationCallbacks* pAllocator,
        PipelineBinaryHandlesInfoKHR* pBinaries
    );

    [NativeName("vkCreatePipelineBinariesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCreatePipelineBinariesKHR")]
    Result CreatePipelineBinariesKHR(
        DeviceHandle device,
        Ref<PipelineBinaryCreateInfoKHR> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<PipelineBinaryHandlesInfoKHR> pBinaries
    );

    [NativeName("vkCreatePipelineCache")]
    [NativeFunction("vulkan", EntryPoint = "vkCreatePipelineCache")]
    Result CreatePipelineCache(
        DeviceHandle device,
        PipelineCacheCreateInfo* pCreateInfo,
        AllocationCallbacks* pAllocator,
        PipelineCacheHandle* pPipelineCache
    );

    [NativeName("vkCreatePipelineCache")]
    [NativeFunction("vulkan", EntryPoint = "vkCreatePipelineCache")]
    Result CreatePipelineCache(
        DeviceHandle device,
        Ref<PipelineCacheCreateInfo> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<PipelineCacheHandle> pPipelineCache
    );

    [NativeName("vkCreatePipelineLayout")]
    [NativeFunction("vulkan", EntryPoint = "vkCreatePipelineLayout")]
    Result CreatePipelineLayout(
        DeviceHandle device,
        PipelineLayoutCreateInfo* pCreateInfo,
        AllocationCallbacks* pAllocator,
        PipelineLayoutHandle* pPipelineLayout
    );

    [NativeName("vkCreatePipelineLayout")]
    [NativeFunction("vulkan", EntryPoint = "vkCreatePipelineLayout")]
    Result CreatePipelineLayout(
        DeviceHandle device,
        Ref<PipelineLayoutCreateInfo> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<PipelineLayoutHandle> pPipelineLayout
    );

    [NativeName("vkCreatePrivateDataSlot")]
    [NativeFunction("vulkan", EntryPoint = "vkCreatePrivateDataSlot")]
    Result CreatePrivateDataSlot(
        DeviceHandle device,
        PrivateDataSlotCreateInfo* pCreateInfo,
        AllocationCallbacks* pAllocator,
        PrivateDataSlotHandle* pPrivateDataSlot
    );

    [NativeName("vkCreatePrivateDataSlot")]
    [NativeFunction("vulkan", EntryPoint = "vkCreatePrivateDataSlot")]
    Result CreatePrivateDataSlot(
        DeviceHandle device,
        Ref<PrivateDataSlotCreateInfo> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<PrivateDataSlotHandle> pPrivateDataSlot
    );

    [NativeName("vkCreatePrivateDataSlotEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCreatePrivateDataSlotEXT")]
    Result CreatePrivateDataSlotEXT(
        DeviceHandle device,
        PrivateDataSlotCreateInfo* pCreateInfo,
        AllocationCallbacks* pAllocator,
        PrivateDataSlotHandle* pPrivateDataSlot
    );

    [NativeName("vkCreatePrivateDataSlotEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCreatePrivateDataSlotEXT")]
    Result CreatePrivateDataSlotEXT(
        DeviceHandle device,
        Ref<PrivateDataSlotCreateInfo> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<PrivateDataSlotHandle> pPrivateDataSlot
    );

    [NativeName("vkCreateQueryPool")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateQueryPool")]
    Result CreateQueryPool(
        DeviceHandle device,
        QueryPoolCreateInfo* pCreateInfo,
        AllocationCallbacks* pAllocator,
        QueryPoolHandle* pQueryPool
    );

    [NativeName("vkCreateQueryPool")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateQueryPool")]
    Result CreateQueryPool(
        DeviceHandle device,
        Ref<QueryPoolCreateInfo> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<QueryPoolHandle> pQueryPool
    );

    [NativeName("vkCreateRayTracingPipelinesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateRayTracingPipelinesKHR")]
    Result CreateRayTracingPipelinesKHR(
        DeviceHandle device,
        DeferredOperationHandleKHR deferredOperation,
        PipelineCacheHandle pipelineCache,
        uint createInfoCount,
        RayTracingPipelineCreateInfoKHR* pCreateInfos,
        AllocationCallbacks* pAllocator,
        PipelineHandle* pPipelines
    );

    [NativeName("vkCreateRayTracingPipelinesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateRayTracingPipelinesKHR")]
    Result CreateRayTracingPipelinesKHR(
        DeviceHandle device,
        DeferredOperationHandleKHR deferredOperation,
        PipelineCacheHandle pipelineCache,
        uint createInfoCount,
        Ref<RayTracingPipelineCreateInfoKHR> pCreateInfos,
        Ref<AllocationCallbacks> pAllocator,
        Ref<PipelineHandle> pPipelines
    );

    [NativeName("vkCreateRayTracingPipelinesNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateRayTracingPipelinesNV")]
    Result CreateRayTracingPipelinesNV(
        DeviceHandle device,
        PipelineCacheHandle pipelineCache,
        uint createInfoCount,
        RayTracingPipelineCreateInfoNV* pCreateInfos,
        AllocationCallbacks* pAllocator,
        PipelineHandle* pPipelines
    );

    [NativeName("vkCreateRayTracingPipelinesNV")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateRayTracingPipelinesNV")]
    Result CreateRayTracingPipelinesNV(
        DeviceHandle device,
        PipelineCacheHandle pipelineCache,
        uint createInfoCount,
        Ref<RayTracingPipelineCreateInfoNV> pCreateInfos,
        Ref<AllocationCallbacks> pAllocator,
        Ref<PipelineHandle> pPipelines
    );

    [NativeName("vkCreateRenderPass")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateRenderPass")]
    Result CreateRenderPass(
        DeviceHandle device,
        RenderPassCreateInfo* pCreateInfo,
        AllocationCallbacks* pAllocator,
        RenderPassHandle* pRenderPass
    );

    [NativeName("vkCreateRenderPass")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateRenderPass")]
    Result CreateRenderPass(
        DeviceHandle device,
        Ref<RenderPassCreateInfo> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<RenderPassHandle> pRenderPass
    );

    [NativeName("vkCreateRenderPass2")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateRenderPass2")]
    Result CreateRenderPass2(
        DeviceHandle device,
        RenderPassCreateInfo2* pCreateInfo,
        AllocationCallbacks* pAllocator,
        RenderPassHandle* pRenderPass
    );

    [NativeName("vkCreateRenderPass2")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateRenderPass2")]
    Result CreateRenderPass2(
        DeviceHandle device,
        Ref<RenderPassCreateInfo2> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<RenderPassHandle> pRenderPass
    );

    [NativeName("vkCreateRenderPass2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateRenderPass2KHR")]
    Result CreateRenderPass2KHR(
        DeviceHandle device,
        RenderPassCreateInfo2* pCreateInfo,
        AllocationCallbacks* pAllocator,
        RenderPassHandle* pRenderPass
    );

    [NativeName("vkCreateRenderPass2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateRenderPass2KHR")]
    Result CreateRenderPass2KHR(
        DeviceHandle device,
        Ref<RenderPassCreateInfo2> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<RenderPassHandle> pRenderPass
    );

    [NativeName("vkCreateSampler")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateSampler")]
    Result CreateSampler(
        DeviceHandle device,
        SamplerCreateInfo* pCreateInfo,
        AllocationCallbacks* pAllocator,
        SamplerHandle* pSampler
    );

    [NativeName("vkCreateSampler")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateSampler")]
    Result CreateSampler(
        DeviceHandle device,
        Ref<SamplerCreateInfo> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<SamplerHandle> pSampler
    );

    [NativeName("vkCreateSamplerYcbcrConversion")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateSamplerYcbcrConversion")]
    Result CreateSamplerYcbcrConversion(
        DeviceHandle device,
        SamplerYcbcrConversionCreateInfo* pCreateInfo,
        AllocationCallbacks* pAllocator,
        SamplerYcbcrConversionHandle* pYcbcrConversion
    );

    [NativeName("vkCreateSamplerYcbcrConversion")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateSamplerYcbcrConversion")]
    Result CreateSamplerYcbcrConversion(
        DeviceHandle device,
        Ref<SamplerYcbcrConversionCreateInfo> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<SamplerYcbcrConversionHandle> pYcbcrConversion
    );

    [NativeName("vkCreateSamplerYcbcrConversionKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateSamplerYcbcrConversionKHR")]
    Result CreateSamplerYcbcrConversionKHR(
        DeviceHandle device,
        SamplerYcbcrConversionCreateInfo* pCreateInfo,
        AllocationCallbacks* pAllocator,
        SamplerYcbcrConversionHandle* pYcbcrConversion
    );

    [NativeName("vkCreateSamplerYcbcrConversionKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateSamplerYcbcrConversionKHR")]
    Result CreateSamplerYcbcrConversionKHR(
        DeviceHandle device,
        Ref<SamplerYcbcrConversionCreateInfo> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<SamplerYcbcrConversionHandle> pYcbcrConversion
    );

    [NativeName("vkCreateSemaphore")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateSemaphore")]
    Result CreateSemaphore(
        DeviceHandle device,
        SemaphoreCreateInfo* pCreateInfo,
        AllocationCallbacks* pAllocator,
        SemaphoreHandle* pSemaphore
    );

    [NativeName("vkCreateSemaphore")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateSemaphore")]
    Result CreateSemaphore(
        DeviceHandle device,
        Ref<SemaphoreCreateInfo> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<SemaphoreHandle> pSemaphore
    );

    [NativeName("vkCreateShaderInstrumentationARM")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateShaderInstrumentationARM")]
    Result CreateShaderInstrumentationARM(
        DeviceHandle device,
        ShaderInstrumentationCreateInfoARM* pCreateInfo,
        AllocationCallbacks* pAllocator,
        ShaderInstrumentationHandleARM* pInstrumentation
    );

    [NativeName("vkCreateShaderInstrumentationARM")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateShaderInstrumentationARM")]
    Result CreateShaderInstrumentationARM(
        DeviceHandle device,
        Ref<ShaderInstrumentationCreateInfoARM> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<ShaderInstrumentationHandleARM> pInstrumentation
    );

    [NativeName("vkCreateShaderModule")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateShaderModule")]
    Result CreateShaderModule(
        DeviceHandle device,
        ShaderModuleCreateInfo* pCreateInfo,
        AllocationCallbacks* pAllocator,
        ShaderModuleHandle* pShaderModule
    );

    [NativeName("vkCreateShaderModule")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateShaderModule")]
    Result CreateShaderModule(
        DeviceHandle device,
        Ref<ShaderModuleCreateInfo> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<ShaderModuleHandle> pShaderModule
    );

    [NativeName("vkCreateShadersEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateShadersEXT")]
    Result CreateShadersEXT(
        DeviceHandle device,
        uint createInfoCount,
        ShaderCreateInfoEXT* pCreateInfos,
        AllocationCallbacks* pAllocator,
        ShaderHandleEXT* pShaders
    );

    [NativeName("vkCreateShadersEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateShadersEXT")]
    Result CreateShadersEXT(
        DeviceHandle device,
        uint createInfoCount,
        Ref<ShaderCreateInfoEXT> pCreateInfos,
        Ref<AllocationCallbacks> pAllocator,
        Ref<ShaderHandleEXT> pShaders
    );

    [NativeName("vkCreateSharedSwapchainsKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateSharedSwapchainsKHR")]
    Result CreateSharedSwapchainsKHR(
        DeviceHandle device,
        uint swapchainCount,
        SwapchainCreateInfoKHR* pCreateInfos,
        AllocationCallbacks* pAllocator,
        SwapchainHandleKHR* pSwapchains
    );

    [NativeName("vkCreateSharedSwapchainsKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateSharedSwapchainsKHR")]
    Result CreateSharedSwapchainsKHR(
        DeviceHandle device,
        uint swapchainCount,
        Ref<SwapchainCreateInfoKHR> pCreateInfos,
        Ref<AllocationCallbacks> pAllocator,
        Ref<SwapchainHandleKHR> pSwapchains
    );

    [NativeName("vkCreateSwapchainKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateSwapchainKHR")]
    Result CreateSwapchainKHR(
        DeviceHandle device,
        SwapchainCreateInfoKHR* pCreateInfo,
        AllocationCallbacks* pAllocator,
        SwapchainHandleKHR* pSwapchain
    );

    [NativeName("vkCreateSwapchainKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateSwapchainKHR")]
    Result CreateSwapchainKHR(
        DeviceHandle device,
        Ref<SwapchainCreateInfoKHR> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<SwapchainHandleKHR> pSwapchain
    );

    [NativeName("vkCreateTensorARM")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateTensorARM")]
    Result CreateTensorARM(
        DeviceHandle device,
        TensorCreateInfoARM* pCreateInfo,
        AllocationCallbacks* pAllocator,
        TensorHandleARM* pTensor
    );

    [NativeName("vkCreateTensorARM")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateTensorARM")]
    Result CreateTensorARM(
        DeviceHandle device,
        Ref<TensorCreateInfoARM> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<TensorHandleARM> pTensor
    );

    [NativeName("vkCreateTensorViewARM")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateTensorViewARM")]
    Result CreateTensorViewARM(
        DeviceHandle device,
        TensorViewCreateInfoARM* pCreateInfo,
        AllocationCallbacks* pAllocator,
        TensorViewHandleARM* pView
    );

    [NativeName("vkCreateTensorViewARM")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateTensorViewARM")]
    Result CreateTensorViewARM(
        DeviceHandle device,
        Ref<TensorViewCreateInfoARM> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<TensorViewHandleARM> pView
    );

    [NativeName("vkCreateValidationCacheEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateValidationCacheEXT")]
    Result CreateValidationCacheEXT(
        DeviceHandle device,
        ValidationCacheCreateInfoEXT* pCreateInfo,
        AllocationCallbacks* pAllocator,
        ValidationCacheHandleEXT* pValidationCache
    );

    [NativeName("vkCreateValidationCacheEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateValidationCacheEXT")]
    Result CreateValidationCacheEXT(
        DeviceHandle device,
        Ref<ValidationCacheCreateInfoEXT> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<ValidationCacheHandleEXT> pValidationCache
    );

    [NativeName("vkCreateVideoSessionKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateVideoSessionKHR")]
    Result CreateVideoSessionKHR(
        DeviceHandle device,
        VideoSessionCreateInfoKHR* pCreateInfo,
        AllocationCallbacks* pAllocator,
        VideoSessionHandleKHR* pVideoSession
    );

    [NativeName("vkCreateVideoSessionKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateVideoSessionKHR")]
    Result CreateVideoSessionKHR(
        DeviceHandle device,
        Ref<VideoSessionCreateInfoKHR> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<VideoSessionHandleKHR> pVideoSession
    );

    [NativeName("vkCreateVideoSessionParametersKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateVideoSessionParametersKHR")]
    Result CreateVideoSessionParametersKHR(
        DeviceHandle device,
        VideoSessionParametersCreateInfoKHR* pCreateInfo,
        AllocationCallbacks* pAllocator,
        VideoSessionParametersHandleKHR* pVideoSessionParameters
    );

    [NativeName("vkCreateVideoSessionParametersKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkCreateVideoSessionParametersKHR")]
    Result CreateVideoSessionParametersKHR(
        DeviceHandle device,
        Ref<VideoSessionParametersCreateInfoKHR> pCreateInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<VideoSessionParametersHandleKHR> pVideoSessionParameters
    );

    [NativeName("vkDebugMarkerSetObjectNameEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkDebugMarkerSetObjectNameEXT")]
    Result DebugMarkerSetObjectNameEXT(
        DeviceHandle device,
        DebugMarkerObjectNameInfoEXT* pNameInfo
    );

    [NativeName("vkDebugMarkerSetObjectNameEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkDebugMarkerSetObjectNameEXT")]
    Result DebugMarkerSetObjectNameEXT(
        DeviceHandle device,
        Ref<DebugMarkerObjectNameInfoEXT> pNameInfo
    );

    [NativeName("vkDebugMarkerSetObjectTagEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkDebugMarkerSetObjectTagEXT")]
    Result DebugMarkerSetObjectTagEXT(DeviceHandle device, DebugMarkerObjectTagInfoEXT* pTagInfo);

    [NativeName("vkDebugMarkerSetObjectTagEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkDebugMarkerSetObjectTagEXT")]
    Result DebugMarkerSetObjectTagEXT(
        DeviceHandle device,
        Ref<DebugMarkerObjectTagInfoEXT> pTagInfo
    );

    [NativeName("vkDebugReportMessageEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkDebugReportMessageEXT")]
    void DebugReportMessageEXT(
        InstanceHandle instance,
        DebugReportFlagsEXT flags,
        DebugReportObjectTypeEXT objectType,
        ulong @object,
        nuint location,
        int messageCode,
        sbyte* pLayerPrefix,
        sbyte* pMessage
    );

    [NativeName("vkDebugReportMessageEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkDebugReportMessageEXT")]
    void DebugReportMessageEXT(
        InstanceHandle instance,
        DebugReportFlagsEXT flags,
        DebugReportObjectTypeEXT objectType,
        ulong @object,
        nuint location,
        int messageCode,
        Ref<sbyte> pLayerPrefix,
        Ref<sbyte> pMessage
    );

    [NativeName("vkDeferredOperationJoinKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkDeferredOperationJoinKHR")]
    Result DeferredOperationJoinKHR(DeviceHandle device, DeferredOperationHandleKHR operation);

    [NativeName("vkDestroyAccelerationStructureKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyAccelerationStructureKHR")]
    void DestroyAccelerationStructureKHR(
        DeviceHandle device,
        AccelerationStructureHandleKHR accelerationStructure,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyAccelerationStructureKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyAccelerationStructureKHR")]
    void DestroyAccelerationStructureKHR(
        DeviceHandle device,
        AccelerationStructureHandleKHR accelerationStructure,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyAccelerationStructureNV")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyAccelerationStructureNV")]
    void DestroyAccelerationStructureNV(
        DeviceHandle device,
        AccelerationStructureHandleNV accelerationStructure,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyAccelerationStructureNV")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyAccelerationStructureNV")]
    void DestroyAccelerationStructureNV(
        DeviceHandle device,
        AccelerationStructureHandleNV accelerationStructure,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyBuffer")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyBuffer")]
    void DestroyBuffer(DeviceHandle device, BufferHandle buffer, AllocationCallbacks* pAllocator);

    [NativeName("vkDestroyBuffer")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyBuffer")]
    void DestroyBuffer(
        DeviceHandle device,
        BufferHandle buffer,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyBufferView")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyBufferView")]
    void DestroyBufferView(
        DeviceHandle device,
        BufferViewHandle bufferView,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyBufferView")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyBufferView")]
    void DestroyBufferView(
        DeviceHandle device,
        BufferViewHandle bufferView,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyCommandPool")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyCommandPool")]
    void DestroyCommandPool(
        DeviceHandle device,
        CommandPoolHandle commandPool,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyCommandPool")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyCommandPool")]
    void DestroyCommandPool(
        DeviceHandle device,
        CommandPoolHandle commandPool,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyCuFunctionNVX")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyCuFunctionNVX")]
    void DestroyCuFunctionNVX(
        DeviceHandle device,
        CuFunctionHandleNVX function,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyCuFunctionNVX")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyCuFunctionNVX")]
    void DestroyCuFunctionNVX(
        DeviceHandle device,
        CuFunctionHandleNVX function,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyCuModuleNVX")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyCuModuleNVX")]
    void DestroyCuModuleNVX(
        DeviceHandle device,
        CuModuleHandleNVX module,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyCuModuleNVX")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyCuModuleNVX")]
    void DestroyCuModuleNVX(
        DeviceHandle device,
        CuModuleHandleNVX module,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyDataGraphPipelineSessionARM")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyDataGraphPipelineSessionARM")]
    void DestroyDataGraphPipelineSessionARM(
        DeviceHandle device,
        DataGraphPipelineSessionHandleARM session,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyDataGraphPipelineSessionARM")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyDataGraphPipelineSessionARM")]
    void DestroyDataGraphPipelineSessionARM(
        DeviceHandle device,
        DataGraphPipelineSessionHandleARM session,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyDebugReportCallbackEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyDebugReportCallbackEXT")]
    void DestroyDebugReportCallbackEXT(
        InstanceHandle instance,
        DebugReportCallbackHandleEXT callback,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyDebugReportCallbackEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyDebugReportCallbackEXT")]
    void DestroyDebugReportCallbackEXT(
        InstanceHandle instance,
        DebugReportCallbackHandleEXT callback,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyDebugUtilsMessengerEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyDebugUtilsMessengerEXT")]
    void DestroyDebugUtilsMessengerEXT(
        InstanceHandle instance,
        DebugUtilsMessengerHandleEXT messenger,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyDebugUtilsMessengerEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyDebugUtilsMessengerEXT")]
    void DestroyDebugUtilsMessengerEXT(
        InstanceHandle instance,
        DebugUtilsMessengerHandleEXT messenger,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyDeferredOperationKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyDeferredOperationKHR")]
    void DestroyDeferredOperationKHR(
        DeviceHandle device,
        DeferredOperationHandleKHR operation,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyDeferredOperationKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyDeferredOperationKHR")]
    void DestroyDeferredOperationKHR(
        DeviceHandle device,
        DeferredOperationHandleKHR operation,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyDescriptorPool")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyDescriptorPool")]
    void DestroyDescriptorPool(
        DeviceHandle device,
        DescriptorPoolHandle descriptorPool,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyDescriptorPool")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyDescriptorPool")]
    void DestroyDescriptorPool(
        DeviceHandle device,
        DescriptorPoolHandle descriptorPool,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyDescriptorSetLayout")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyDescriptorSetLayout")]
    void DestroyDescriptorSetLayout(
        DeviceHandle device,
        DescriptorSetLayoutHandle descriptorSetLayout,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyDescriptorSetLayout")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyDescriptorSetLayout")]
    void DestroyDescriptorSetLayout(
        DeviceHandle device,
        DescriptorSetLayoutHandle descriptorSetLayout,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyDescriptorUpdateTemplate")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyDescriptorUpdateTemplate")]
    void DestroyDescriptorUpdateTemplate(
        DeviceHandle device,
        DescriptorUpdateTemplateHandle descriptorUpdateTemplate,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyDescriptorUpdateTemplate")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyDescriptorUpdateTemplate")]
    void DestroyDescriptorUpdateTemplate(
        DeviceHandle device,
        DescriptorUpdateTemplateHandle descriptorUpdateTemplate,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyDescriptorUpdateTemplateKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyDescriptorUpdateTemplateKHR")]
    void DestroyDescriptorUpdateTemplateKHR(
        DeviceHandle device,
        DescriptorUpdateTemplateHandle descriptorUpdateTemplate,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyDescriptorUpdateTemplateKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyDescriptorUpdateTemplateKHR")]
    void DestroyDescriptorUpdateTemplateKHR(
        DeviceHandle device,
        DescriptorUpdateTemplateHandle descriptorUpdateTemplate,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyDevice")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyDevice")]
    void DestroyDevice(DeviceHandle device, AllocationCallbacks* pAllocator);

    [NativeName("vkDestroyDevice")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyDevice")]
    void DestroyDevice(DeviceHandle device, Ref<AllocationCallbacks> pAllocator);

    [NativeName("vkDestroyEvent")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyEvent")]
    void DestroyEvent(DeviceHandle device, EventHandle @event, AllocationCallbacks* pAllocator);

    [NativeName("vkDestroyEvent")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyEvent")]
    void DestroyEvent(DeviceHandle device, EventHandle @event, Ref<AllocationCallbacks> pAllocator);

    [NativeName("vkDestroyExternalComputeQueueNV")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyExternalComputeQueueNV")]
    void DestroyExternalComputeQueueNV(
        DeviceHandle device,
        ExternalComputeQueueHandleNV externalQueue,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyExternalComputeQueueNV")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyExternalComputeQueueNV")]
    void DestroyExternalComputeQueueNV(
        DeviceHandle device,
        ExternalComputeQueueHandleNV externalQueue,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyFence")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyFence")]
    void DestroyFence(DeviceHandle device, FenceHandle fence, AllocationCallbacks* pAllocator);

    [NativeName("vkDestroyFence")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyFence")]
    void DestroyFence(DeviceHandle device, FenceHandle fence, Ref<AllocationCallbacks> pAllocator);

    [NativeName("vkDestroyFramebuffer")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyFramebuffer")]
    void DestroyFramebuffer(
        DeviceHandle device,
        FramebufferHandle framebuffer,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyFramebuffer")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyFramebuffer")]
    void DestroyFramebuffer(
        DeviceHandle device,
        FramebufferHandle framebuffer,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyGpaSessionAMD")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyGpaSessionAMD")]
    void DestroyGpaSessionAMD(
        DeviceHandle device,
        GpaSessionHandleAMD gpaSession,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyGpaSessionAMD")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyGpaSessionAMD")]
    void DestroyGpaSessionAMD(
        DeviceHandle device,
        GpaSessionHandleAMD gpaSession,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyImage")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyImage")]
    void DestroyImage(DeviceHandle device, ImageHandle image, AllocationCallbacks* pAllocator);

    [NativeName("vkDestroyImage")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyImage")]
    void DestroyImage(DeviceHandle device, ImageHandle image, Ref<AllocationCallbacks> pAllocator);

    [NativeName("vkDestroyImageView")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyImageView")]
    void DestroyImageView(
        DeviceHandle device,
        ImageViewHandle imageView,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyImageView")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyImageView")]
    void DestroyImageView(
        DeviceHandle device,
        ImageViewHandle imageView,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyIndirectCommandsLayoutEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyIndirectCommandsLayoutEXT")]
    void DestroyIndirectCommandsLayoutEXT(
        DeviceHandle device,
        IndirectCommandsLayoutHandleEXT indirectCommandsLayout,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyIndirectCommandsLayoutEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyIndirectCommandsLayoutEXT")]
    void DestroyIndirectCommandsLayoutEXT(
        DeviceHandle device,
        IndirectCommandsLayoutHandleEXT indirectCommandsLayout,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyIndirectCommandsLayoutNV")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyIndirectCommandsLayoutNV")]
    void DestroyIndirectCommandsLayoutNV(
        DeviceHandle device,
        IndirectCommandsLayoutHandleNV indirectCommandsLayout,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyIndirectCommandsLayoutNV")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyIndirectCommandsLayoutNV")]
    void DestroyIndirectCommandsLayoutNV(
        DeviceHandle device,
        IndirectCommandsLayoutHandleNV indirectCommandsLayout,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyIndirectExecutionSetEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyIndirectExecutionSetEXT")]
    void DestroyIndirectExecutionSetEXT(
        DeviceHandle device,
        IndirectExecutionSetHandleEXT indirectExecutionSet,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyIndirectExecutionSetEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyIndirectExecutionSetEXT")]
    void DestroyIndirectExecutionSetEXT(
        DeviceHandle device,
        IndirectExecutionSetHandleEXT indirectExecutionSet,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyInstance")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyInstance")]
    void DestroyInstance(InstanceHandle instance, AllocationCallbacks* pAllocator);

    [NativeName("vkDestroyInstance")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyInstance")]
    void DestroyInstance(InstanceHandle instance, Ref<AllocationCallbacks> pAllocator);

    [NativeName("vkDestroyMicromapEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyMicromapEXT")]
    void DestroyMicromapEXT(
        DeviceHandle device,
        MicromapHandleEXT micromap,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyMicromapEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyMicromapEXT")]
    void DestroyMicromapEXT(
        DeviceHandle device,
        MicromapHandleEXT micromap,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyOpticalFlowSessionNV")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyOpticalFlowSessionNV")]
    void DestroyOpticalFlowSessionNV(
        DeviceHandle device,
        OpticalFlowSessionHandleNV session,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyOpticalFlowSessionNV")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyOpticalFlowSessionNV")]
    void DestroyOpticalFlowSessionNV(
        DeviceHandle device,
        OpticalFlowSessionHandleNV session,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyPipeline")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyPipeline")]
    void DestroyPipeline(
        DeviceHandle device,
        PipelineHandle pipeline,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyPipeline")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyPipeline")]
    void DestroyPipeline(
        DeviceHandle device,
        PipelineHandle pipeline,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyPipelineBinaryKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyPipelineBinaryKHR")]
    void DestroyPipelineBinaryKHR(
        DeviceHandle device,
        PipelineBinaryHandleKHR pipelineBinary,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyPipelineBinaryKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyPipelineBinaryKHR")]
    void DestroyPipelineBinaryKHR(
        DeviceHandle device,
        PipelineBinaryHandleKHR pipelineBinary,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyPipelineCache")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyPipelineCache")]
    void DestroyPipelineCache(
        DeviceHandle device,
        PipelineCacheHandle pipelineCache,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyPipelineCache")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyPipelineCache")]
    void DestroyPipelineCache(
        DeviceHandle device,
        PipelineCacheHandle pipelineCache,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyPipelineLayout")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyPipelineLayout")]
    void DestroyPipelineLayout(
        DeviceHandle device,
        PipelineLayoutHandle pipelineLayout,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyPipelineLayout")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyPipelineLayout")]
    void DestroyPipelineLayout(
        DeviceHandle device,
        PipelineLayoutHandle pipelineLayout,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyPrivateDataSlot")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyPrivateDataSlot")]
    void DestroyPrivateDataSlot(
        DeviceHandle device,
        PrivateDataSlotHandle privateDataSlot,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyPrivateDataSlot")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyPrivateDataSlot")]
    void DestroyPrivateDataSlot(
        DeviceHandle device,
        PrivateDataSlotHandle privateDataSlot,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyPrivateDataSlotEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyPrivateDataSlotEXT")]
    void DestroyPrivateDataSlotEXT(
        DeviceHandle device,
        PrivateDataSlotHandle privateDataSlot,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyPrivateDataSlotEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyPrivateDataSlotEXT")]
    void DestroyPrivateDataSlotEXT(
        DeviceHandle device,
        PrivateDataSlotHandle privateDataSlot,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyQueryPool")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyQueryPool")]
    void DestroyQueryPool(
        DeviceHandle device,
        QueryPoolHandle queryPool,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyQueryPool")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyQueryPool")]
    void DestroyQueryPool(
        DeviceHandle device,
        QueryPoolHandle queryPool,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyRenderPass")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyRenderPass")]
    void DestroyRenderPass(
        DeviceHandle device,
        RenderPassHandle renderPass,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyRenderPass")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyRenderPass")]
    void DestroyRenderPass(
        DeviceHandle device,
        RenderPassHandle renderPass,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroySampler")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroySampler")]
    void DestroySampler(
        DeviceHandle device,
        SamplerHandle sampler,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroySampler")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroySampler")]
    void DestroySampler(
        DeviceHandle device,
        SamplerHandle sampler,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroySamplerYcbcrConversion")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroySamplerYcbcrConversion")]
    void DestroySamplerYcbcrConversion(
        DeviceHandle device,
        SamplerYcbcrConversionHandle ycbcrConversion,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroySamplerYcbcrConversion")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroySamplerYcbcrConversion")]
    void DestroySamplerYcbcrConversion(
        DeviceHandle device,
        SamplerYcbcrConversionHandle ycbcrConversion,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroySamplerYcbcrConversionKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroySamplerYcbcrConversionKHR")]
    void DestroySamplerYcbcrConversionKHR(
        DeviceHandle device,
        SamplerYcbcrConversionHandle ycbcrConversion,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroySamplerYcbcrConversionKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroySamplerYcbcrConversionKHR")]
    void DestroySamplerYcbcrConversionKHR(
        DeviceHandle device,
        SamplerYcbcrConversionHandle ycbcrConversion,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroySemaphore")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroySemaphore")]
    void DestroySemaphore(
        DeviceHandle device,
        SemaphoreHandle semaphore,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroySemaphore")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroySemaphore")]
    void DestroySemaphore(
        DeviceHandle device,
        SemaphoreHandle semaphore,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyShaderEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyShaderEXT")]
    void DestroyShaderEXT(
        DeviceHandle device,
        ShaderHandleEXT shader,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyShaderEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyShaderEXT")]
    void DestroyShaderEXT(
        DeviceHandle device,
        ShaderHandleEXT shader,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyShaderInstrumentationARM")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyShaderInstrumentationARM")]
    void DestroyShaderInstrumentationARM(
        DeviceHandle device,
        ShaderInstrumentationHandleARM instrumentation,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyShaderInstrumentationARM")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyShaderInstrumentationARM")]
    void DestroyShaderInstrumentationARM(
        DeviceHandle device,
        ShaderInstrumentationHandleARM instrumentation,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyShaderModule")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyShaderModule")]
    void DestroyShaderModule(
        DeviceHandle device,
        ShaderModuleHandle shaderModule,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyShaderModule")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyShaderModule")]
    void DestroyShaderModule(
        DeviceHandle device,
        ShaderModuleHandle shaderModule,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroySurfaceKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroySurfaceKHR")]
    void DestroySurfaceKHR(
        InstanceHandle instance,
        SurfaceHandleKHR surface,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroySurfaceKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroySurfaceKHR")]
    void DestroySurfaceKHR(
        InstanceHandle instance,
        SurfaceHandleKHR surface,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroySwapchainKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroySwapchainKHR")]
    void DestroySwapchainKHR(
        DeviceHandle device,
        SwapchainHandleKHR swapchain,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroySwapchainKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroySwapchainKHR")]
    void DestroySwapchainKHR(
        DeviceHandle device,
        SwapchainHandleKHR swapchain,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyTensorARM")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyTensorARM")]
    void DestroyTensorARM(
        DeviceHandle device,
        TensorHandleARM tensor,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyTensorARM")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyTensorARM")]
    void DestroyTensorARM(
        DeviceHandle device,
        TensorHandleARM tensor,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyTensorViewARM")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyTensorViewARM")]
    void DestroyTensorViewARM(
        DeviceHandle device,
        TensorViewHandleARM tensorView,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyTensorViewARM")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyTensorViewARM")]
    void DestroyTensorViewARM(
        DeviceHandle device,
        TensorViewHandleARM tensorView,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyValidationCacheEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyValidationCacheEXT")]
    void DestroyValidationCacheEXT(
        DeviceHandle device,
        ValidationCacheHandleEXT validationCache,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyValidationCacheEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyValidationCacheEXT")]
    void DestroyValidationCacheEXT(
        DeviceHandle device,
        ValidationCacheHandleEXT validationCache,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyVideoSessionKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyVideoSessionKHR")]
    void DestroyVideoSessionKHR(
        DeviceHandle device,
        VideoSessionHandleKHR videoSession,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyVideoSessionKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyVideoSessionKHR")]
    void DestroyVideoSessionKHR(
        DeviceHandle device,
        VideoSessionHandleKHR videoSession,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDestroyVideoSessionParametersKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyVideoSessionParametersKHR")]
    void DestroyVideoSessionParametersKHR(
        DeviceHandle device,
        VideoSessionParametersHandleKHR videoSessionParameters,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkDestroyVideoSessionParametersKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkDestroyVideoSessionParametersKHR")]
    void DestroyVideoSessionParametersKHR(
        DeviceHandle device,
        VideoSessionParametersHandleKHR videoSessionParameters,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkDeviceWaitIdle")]
    [NativeFunction("vulkan", EntryPoint = "vkDeviceWaitIdle")]
    Result DeviceWaitIdle(DeviceHandle device);

    [NativeName("vkDisplayPowerControlEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkDisplayPowerControlEXT")]
    Result DisplayPowerControlEXT(
        DeviceHandle device,
        DisplayHandleKHR display,
        DisplayPowerInfoEXT* pDisplayPowerInfo
    );

    [NativeName("vkDisplayPowerControlEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkDisplayPowerControlEXT")]
    Result DisplayPowerControlEXT(
        DeviceHandle device,
        DisplayHandleKHR display,
        Ref<DisplayPowerInfoEXT> pDisplayPowerInfo
    );

    [NativeName("vkEndCommandBuffer")]
    [NativeFunction("vulkan", EntryPoint = "vkEndCommandBuffer")]
    Result EndCommandBuffer(CommandBufferHandle commandBuffer);

    [NativeName("vkEnumerateDeviceExtensionProperties")]
    [NativeFunction("vulkan", EntryPoint = "vkEnumerateDeviceExtensionProperties")]
    Result EnumerateDeviceExtensionProperties(
        PhysicalDeviceHandle physicalDevice,
        sbyte* pLayerName,
        uint* pPropertyCount,
        ExtensionProperties* pProperties
    );

    [NativeName("vkEnumerateDeviceExtensionProperties")]
    [NativeFunction("vulkan", EntryPoint = "vkEnumerateDeviceExtensionProperties")]
    Result EnumerateDeviceExtensionProperties(
        PhysicalDeviceHandle physicalDevice,
        Ref<sbyte> pLayerName,
        Ref<uint> pPropertyCount,
        Ref<ExtensionProperties> pProperties
    );

    [NativeName("vkEnumerateDeviceLayerProperties")]
    [NativeFunction("vulkan", EntryPoint = "vkEnumerateDeviceLayerProperties")]
    Result EnumerateDeviceLayerProperties(
        PhysicalDeviceHandle physicalDevice,
        uint* pPropertyCount,
        LayerProperties* pProperties
    );

    [NativeName("vkEnumerateDeviceLayerProperties")]
    [NativeFunction("vulkan", EntryPoint = "vkEnumerateDeviceLayerProperties")]
    Result EnumerateDeviceLayerProperties(
        PhysicalDeviceHandle physicalDevice,
        Ref<uint> pPropertyCount,
        Ref<LayerProperties> pProperties
    );

    [NativeName("vkEnumerateInstanceExtensionProperties")]
    [NativeFunction("vulkan", EntryPoint = "vkEnumerateInstanceExtensionProperties")]
    Result EnumerateInstanceExtensionProperties(
        sbyte* pLayerName,
        uint* pPropertyCount,
        ExtensionProperties* pProperties
    );

    [NativeName("vkEnumerateInstanceExtensionProperties")]
    [NativeFunction("vulkan", EntryPoint = "vkEnumerateInstanceExtensionProperties")]
    Result EnumerateInstanceExtensionProperties(
        Ref<sbyte> pLayerName,
        Ref<uint> pPropertyCount,
        Ref<ExtensionProperties> pProperties
    );

    [NativeName("vkEnumerateInstanceLayerProperties")]
    [NativeFunction("vulkan", EntryPoint = "vkEnumerateInstanceLayerProperties")]
    Result EnumerateInstanceLayerProperties(uint* pPropertyCount, LayerProperties* pProperties);

    [NativeName("vkEnumerateInstanceLayerProperties")]
    [NativeFunction("vulkan", EntryPoint = "vkEnumerateInstanceLayerProperties")]
    Result EnumerateInstanceLayerProperties(
        Ref<uint> pPropertyCount,
        Ref<LayerProperties> pProperties
    );

    [NativeName("vkEnumerateInstanceVersion")]
    [NativeFunction("vulkan", EntryPoint = "vkEnumerateInstanceVersion")]
    Result EnumerateInstanceVersion(uint* pApiVersion);

    [NativeName("vkEnumerateInstanceVersion")]
    [NativeFunction("vulkan", EntryPoint = "vkEnumerateInstanceVersion")]
    Result EnumerateInstanceVersion(Ref<uint> pApiVersion);

    [NativeName("vkEnumeratePhysicalDeviceGroups")]
    [NativeFunction("vulkan", EntryPoint = "vkEnumeratePhysicalDeviceGroups")]
    Result EnumeratePhysicalDeviceGroups(
        InstanceHandle instance,
        uint* pPhysicalDeviceGroupCount,
        PhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties
    );

    [NativeName("vkEnumeratePhysicalDeviceGroups")]
    [NativeFunction("vulkan", EntryPoint = "vkEnumeratePhysicalDeviceGroups")]
    Result EnumeratePhysicalDeviceGroups(
        InstanceHandle instance,
        Ref<uint> pPhysicalDeviceGroupCount,
        Ref<PhysicalDeviceGroupProperties> pPhysicalDeviceGroupProperties
    );

    [NativeName("vkEnumeratePhysicalDeviceGroupsKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkEnumeratePhysicalDeviceGroupsKHR")]
    Result EnumeratePhysicalDeviceGroupsKHR(
        InstanceHandle instance,
        uint* pPhysicalDeviceGroupCount,
        PhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties
    );

    [NativeName("vkEnumeratePhysicalDeviceGroupsKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkEnumeratePhysicalDeviceGroupsKHR")]
    Result EnumeratePhysicalDeviceGroupsKHR(
        InstanceHandle instance,
        Ref<uint> pPhysicalDeviceGroupCount,
        Ref<PhysicalDeviceGroupProperties> pPhysicalDeviceGroupProperties
    );

    [NativeName("vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM")]
    [NativeFunction(
        "vulkan",
        EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM"
    )]
    Result EnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM(
        PhysicalDeviceHandle physicalDevice,
        uint queueFamilyIndex,
        uint* pCounterCount,
        PerformanceCounterARM* pCounters,
        PerformanceCounterDescriptionARM* pCounterDescriptions
    );

    [NativeName("vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM")]
    [NativeFunction(
        "vulkan",
        EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM"
    )]
    Result EnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM(
        PhysicalDeviceHandle physicalDevice,
        uint queueFamilyIndex,
        Ref<uint> pCounterCount,
        Ref<PerformanceCounterARM> pCounters,
        Ref<PerformanceCounterDescriptionARM> pCounterDescriptions
    );

    [NativeName("vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR")]
    [NativeFunction(
        "vulkan",
        EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR"
    )]
    Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(
        PhysicalDeviceHandle physicalDevice,
        uint queueFamilyIndex,
        uint* pCounterCount,
        PerformanceCounterKHR* pCounters,
        PerformanceCounterDescriptionKHR* pCounterDescriptions
    );

    [NativeName("vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR")]
    [NativeFunction(
        "vulkan",
        EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR"
    )]
    Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(
        PhysicalDeviceHandle physicalDevice,
        uint queueFamilyIndex,
        Ref<uint> pCounterCount,
        Ref<PerformanceCounterKHR> pCounters,
        Ref<PerformanceCounterDescriptionKHR> pCounterDescriptions
    );

    [NativeName("vkEnumeratePhysicalDevices")]
    [NativeFunction("vulkan", EntryPoint = "vkEnumeratePhysicalDevices")]
    Result EnumeratePhysicalDevices(
        InstanceHandle instance,
        uint* pPhysicalDeviceCount,
        PhysicalDeviceHandle* pPhysicalDevices
    );

    [NativeName("vkEnumeratePhysicalDevices")]
    [NativeFunction("vulkan", EntryPoint = "vkEnumeratePhysicalDevices")]
    Result EnumeratePhysicalDevices(
        InstanceHandle instance,
        Ref<uint> pPhysicalDeviceCount,
        Ref<PhysicalDeviceHandle> pPhysicalDevices
    );

    [NativeName("vkEnumeratePhysicalDeviceShaderInstrumentationMetricsARM")]
    [NativeFunction(
        "vulkan",
        EntryPoint = "vkEnumeratePhysicalDeviceShaderInstrumentationMetricsARM"
    )]
    Result EnumeratePhysicalDeviceShaderInstrumentationMetricsARM(
        PhysicalDeviceHandle physicalDevice,
        uint* pDescriptionCount,
        ShaderInstrumentationMetricDescriptionARM* pDescriptions
    );

    [NativeName("vkEnumeratePhysicalDeviceShaderInstrumentationMetricsARM")]
    [NativeFunction(
        "vulkan",
        EntryPoint = "vkEnumeratePhysicalDeviceShaderInstrumentationMetricsARM"
    )]
    Result EnumeratePhysicalDeviceShaderInstrumentationMetricsARM(
        PhysicalDeviceHandle physicalDevice,
        Ref<uint> pDescriptionCount,
        Ref<ShaderInstrumentationMetricDescriptionARM> pDescriptions
    );

    [NativeName("vkFlushMappedMemoryRanges")]
    [NativeFunction("vulkan", EntryPoint = "vkFlushMappedMemoryRanges")]
    Result FlushMappedMemoryRanges(
        DeviceHandle device,
        uint memoryRangeCount,
        MappedMemoryRange* pMemoryRanges
    );

    [NativeName("vkFlushMappedMemoryRanges")]
    [NativeFunction("vulkan", EntryPoint = "vkFlushMappedMemoryRanges")]
    Result FlushMappedMemoryRanges(
        DeviceHandle device,
        uint memoryRangeCount,
        Ref<MappedMemoryRange> pMemoryRanges
    );

    [NativeName("vkFreeCommandBuffers")]
    [NativeFunction("vulkan", EntryPoint = "vkFreeCommandBuffers")]
    void FreeCommandBuffer(
        DeviceHandle device,
        CommandPoolHandle commandPool,
        CommandBufferHandle pCommandBuffers
    );

    [NativeName("vkFreeCommandBuffers")]
    [NativeFunction("vulkan", EntryPoint = "vkFreeCommandBuffers")]
    void FreeCommandBuffers(
        DeviceHandle device,
        CommandPoolHandle commandPool,
        uint commandBufferCount,
        CommandBufferHandle* pCommandBuffers
    );

    [NativeName("vkFreeCommandBuffers")]
    [NativeFunction("vulkan", EntryPoint = "vkFreeCommandBuffers")]
    void FreeCommandBuffers(
        DeviceHandle device,
        CommandPoolHandle commandPool,
        uint commandBufferCount,
        Ref<CommandBufferHandle> pCommandBuffers
    );

    [NativeName("vkFreeDescriptorSets")]
    [NativeFunction("vulkan", EntryPoint = "vkFreeDescriptorSets")]
    Result FreeDescriptorSets(
        DeviceHandle device,
        DescriptorPoolHandle descriptorPool,
        uint descriptorSetCount,
        DescriptorSetHandle* pDescriptorSets
    );

    [NativeName("vkFreeDescriptorSets")]
    [NativeFunction("vulkan", EntryPoint = "vkFreeDescriptorSets")]
    Result FreeDescriptorSets(
        DeviceHandle device,
        DescriptorPoolHandle descriptorPool,
        uint descriptorSetCount,
        Ref<DescriptorSetHandle> pDescriptorSets
    );

    [NativeName("vkFreeMemory")]
    [NativeFunction("vulkan", EntryPoint = "vkFreeMemory")]
    void FreeMemory(
        DeviceHandle device,
        DeviceMemoryHandle memory,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkFreeMemory")]
    [NativeFunction("vulkan", EntryPoint = "vkFreeMemory")]
    void FreeMemory(
        DeviceHandle device,
        DeviceMemoryHandle memory,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkGetAccelerationStructureBuildSizesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetAccelerationStructureBuildSizesKHR")]
    void GetAccelerationStructureBuildSizesKHR(
        DeviceHandle device,
        AccelerationStructureBuildTypeKHR buildType,
        AccelerationStructureBuildGeometryInfoKHR* pBuildInfo,
        uint* pMaxPrimitiveCounts,
        AccelerationStructureBuildSizesInfoKHR* pSizeInfo
    );

    [NativeName("vkGetAccelerationStructureBuildSizesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetAccelerationStructureBuildSizesKHR")]
    void GetAccelerationStructureBuildSizesKHR(
        DeviceHandle device,
        AccelerationStructureBuildTypeKHR buildType,
        Ref<AccelerationStructureBuildGeometryInfoKHR> pBuildInfo,
        Ref<uint> pMaxPrimitiveCounts,
        Ref<AccelerationStructureBuildSizesInfoKHR> pSizeInfo
    );

    [NativeName("vkGetAccelerationStructureDeviceAddressKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetAccelerationStructureDeviceAddressKHR")]
    ulong GetAccelerationStructureDeviceAddressKHR(
        DeviceHandle device,
        AccelerationStructureDeviceAddressInfoKHR* pInfo
    );

    [NativeName("vkGetAccelerationStructureDeviceAddressKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetAccelerationStructureDeviceAddressKHR")]
    ulong GetAccelerationStructureDeviceAddressKHR(
        DeviceHandle device,
        Ref<AccelerationStructureDeviceAddressInfoKHR> pInfo
    );

    [NativeName("vkGetAccelerationStructureHandleNV")]
    [NativeFunction("vulkan", EntryPoint = "vkGetAccelerationStructureHandleNV")]
    Result GetAccelerationStructureHandleNV(
        DeviceHandle device,
        AccelerationStructureHandleNV accelerationStructure,
        nuint dataSize,
        void* pData
    );

    [NativeName("vkGetAccelerationStructureHandleNV")]
    [NativeFunction("vulkan", EntryPoint = "vkGetAccelerationStructureHandleNV")]
    Result GetAccelerationStructureHandleNV(
        DeviceHandle device,
        AccelerationStructureHandleNV accelerationStructure,
        nuint dataSize,
        Ref pData
    );

    [NativeName("vkGetAccelerationStructureMemoryRequirementsNV")]
    [NativeFunction("vulkan", EntryPoint = "vkGetAccelerationStructureMemoryRequirementsNV")]
    void GetAccelerationStructureMemoryRequirementsNV(
        DeviceHandle device,
        AccelerationStructureMemoryRequirementsInfoNV* pInfo,
        MemoryRequirements2* pMemoryRequirements
    );

    [NativeName("vkGetAccelerationStructureMemoryRequirementsNV")]
    [NativeFunction("vulkan", EntryPoint = "vkGetAccelerationStructureMemoryRequirementsNV")]
    void GetAccelerationStructureMemoryRequirementsNV(
        DeviceHandle device,
        Ref<AccelerationStructureMemoryRequirementsInfoNV> pInfo,
        Ref<MemoryRequirements2> pMemoryRequirements
    );

    [NativeName("vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT")]
    [NativeFunction(
        "vulkan",
        EntryPoint = "vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT"
    )]
    Result GetAccelerationStructureOpaqueCaptureDescriptorDataEXT(
        DeviceHandle device,
        AccelerationStructureCaptureDescriptorDataInfoEXT* pInfo,
        void* pData
    );

    [NativeName("vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT")]
    [NativeFunction(
        "vulkan",
        EntryPoint = "vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT"
    )]
    Result GetAccelerationStructureOpaqueCaptureDescriptorDataEXT(
        DeviceHandle device,
        Ref<AccelerationStructureCaptureDescriptorDataInfoEXT> pInfo,
        Ref pData
    );

    [NativeName("vkGetBufferDeviceAddress")]
    [NativeFunction("vulkan", EntryPoint = "vkGetBufferDeviceAddress")]
    ulong GetBufferDeviceAddress(DeviceHandle device, BufferDeviceAddressInfo* pInfo);

    [NativeName("vkGetBufferDeviceAddress")]
    [NativeFunction("vulkan", EntryPoint = "vkGetBufferDeviceAddress")]
    ulong GetBufferDeviceAddress(DeviceHandle device, Ref<BufferDeviceAddressInfo> pInfo);

    [NativeName("vkGetBufferDeviceAddressEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetBufferDeviceAddressEXT")]
    ulong GetBufferDeviceAddressEXT(DeviceHandle device, BufferDeviceAddressInfo* pInfo);

    [NativeName("vkGetBufferDeviceAddressEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetBufferDeviceAddressEXT")]
    ulong GetBufferDeviceAddressEXT(DeviceHandle device, Ref<BufferDeviceAddressInfo> pInfo);

    [NativeName("vkGetBufferDeviceAddressKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetBufferDeviceAddressKHR")]
    ulong GetBufferDeviceAddressKHR(DeviceHandle device, BufferDeviceAddressInfo* pInfo);

    [NativeName("vkGetBufferDeviceAddressKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetBufferDeviceAddressKHR")]
    ulong GetBufferDeviceAddressKHR(DeviceHandle device, Ref<BufferDeviceAddressInfo> pInfo);

    [NativeName("vkGetBufferMemoryRequirements")]
    [NativeFunction("vulkan", EntryPoint = "vkGetBufferMemoryRequirements")]
    void GetBufferMemoryRequirements(
        DeviceHandle device,
        BufferHandle buffer,
        MemoryRequirements* pMemoryRequirements
    );

    [NativeName("vkGetBufferMemoryRequirements")]
    [NativeFunction("vulkan", EntryPoint = "vkGetBufferMemoryRequirements")]
    void GetBufferMemoryRequirements(
        DeviceHandle device,
        BufferHandle buffer,
        Ref<MemoryRequirements> pMemoryRequirements
    );

    [NativeName("vkGetBufferMemoryRequirements2")]
    [NativeFunction("vulkan", EntryPoint = "vkGetBufferMemoryRequirements2")]
    void GetBufferMemoryRequirements2(
        DeviceHandle device,
        BufferMemoryRequirementsInfo2* pInfo,
        MemoryRequirements2* pMemoryRequirements
    );

    [NativeName("vkGetBufferMemoryRequirements2")]
    [NativeFunction("vulkan", EntryPoint = "vkGetBufferMemoryRequirements2")]
    void GetBufferMemoryRequirements2(
        DeviceHandle device,
        Ref<BufferMemoryRequirementsInfo2> pInfo,
        Ref<MemoryRequirements2> pMemoryRequirements
    );

    [NativeName("vkGetBufferMemoryRequirements2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetBufferMemoryRequirements2KHR")]
    void GetBufferMemoryRequirements2KHR(
        DeviceHandle device,
        BufferMemoryRequirementsInfo2* pInfo,
        MemoryRequirements2* pMemoryRequirements
    );

    [NativeName("vkGetBufferMemoryRequirements2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetBufferMemoryRequirements2KHR")]
    void GetBufferMemoryRequirements2KHR(
        DeviceHandle device,
        Ref<BufferMemoryRequirementsInfo2> pInfo,
        Ref<MemoryRequirements2> pMemoryRequirements
    );

    [NativeName("vkGetBufferOpaqueCaptureAddress")]
    [NativeFunction("vulkan", EntryPoint = "vkGetBufferOpaqueCaptureAddress")]
    ulong GetBufferOpaqueCaptureAddress(DeviceHandle device, BufferDeviceAddressInfo* pInfo);

    [NativeName("vkGetBufferOpaqueCaptureAddress")]
    [NativeFunction("vulkan", EntryPoint = "vkGetBufferOpaqueCaptureAddress")]
    ulong GetBufferOpaqueCaptureAddress(DeviceHandle device, Ref<BufferDeviceAddressInfo> pInfo);

    [NativeName("vkGetBufferOpaqueCaptureAddressKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetBufferOpaqueCaptureAddressKHR")]
    ulong GetBufferOpaqueCaptureAddressKHR(DeviceHandle device, BufferDeviceAddressInfo* pInfo);

    [NativeName("vkGetBufferOpaqueCaptureAddressKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetBufferOpaqueCaptureAddressKHR")]
    ulong GetBufferOpaqueCaptureAddressKHR(DeviceHandle device, Ref<BufferDeviceAddressInfo> pInfo);

    [NativeName("vkGetBufferOpaqueCaptureDescriptorDataEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetBufferOpaqueCaptureDescriptorDataEXT")]
    Result GetBufferOpaqueCaptureDescriptorDataEXT(
        DeviceHandle device,
        BufferCaptureDescriptorDataInfoEXT* pInfo,
        void* pData
    );

    [NativeName("vkGetBufferOpaqueCaptureDescriptorDataEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetBufferOpaqueCaptureDescriptorDataEXT")]
    Result GetBufferOpaqueCaptureDescriptorDataEXT(
        DeviceHandle device,
        Ref<BufferCaptureDescriptorDataInfoEXT> pInfo,
        Ref pData
    );

    [NativeName("vkGetCalibratedTimestampsEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetCalibratedTimestampsEXT")]
    Result GetCalibratedTimestampsEXT(
        DeviceHandle device,
        uint timestampCount,
        CalibratedTimestampInfoKHR* pTimestampInfos,
        ulong* pTimestamps,
        ulong* pMaxDeviation
    );

    [NativeName("vkGetCalibratedTimestampsEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetCalibratedTimestampsEXT")]
    Result GetCalibratedTimestampsEXT(
        DeviceHandle device,
        uint timestampCount,
        Ref<CalibratedTimestampInfoKHR> pTimestampInfos,
        Ref<ulong> pTimestamps,
        Ref<ulong> pMaxDeviation
    );

    [NativeName("vkGetCalibratedTimestampsKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetCalibratedTimestampsKHR")]
    Result GetCalibratedTimestampsKHR(
        DeviceHandle device,
        uint timestampCount,
        CalibratedTimestampInfoKHR* pTimestampInfos,
        ulong* pTimestamps,
        ulong* pMaxDeviation
    );

    [NativeName("vkGetCalibratedTimestampsKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetCalibratedTimestampsKHR")]
    Result GetCalibratedTimestampsKHR(
        DeviceHandle device,
        uint timestampCount,
        Ref<CalibratedTimestampInfoKHR> pTimestampInfos,
        Ref<ulong> pTimestamps,
        Ref<ulong> pMaxDeviation
    );

    [NativeName("vkGetClusterAccelerationStructureBuildSizesNV")]
    [NativeFunction("vulkan", EntryPoint = "vkGetClusterAccelerationStructureBuildSizesNV")]
    void GetClusterAccelerationStructureBuildSizesNV(
        DeviceHandle device,
        ClusterAccelerationStructureInputInfoNV* pInfo,
        AccelerationStructureBuildSizesInfoKHR* pSizeInfo
    );

    [NativeName("vkGetClusterAccelerationStructureBuildSizesNV")]
    [NativeFunction("vulkan", EntryPoint = "vkGetClusterAccelerationStructureBuildSizesNV")]
    void GetClusterAccelerationStructureBuildSizesNV(
        DeviceHandle device,
        Ref<ClusterAccelerationStructureInputInfoNV> pInfo,
        Ref<AccelerationStructureBuildSizesInfoKHR> pSizeInfo
    );

    [NativeName("vkGetDataGraphPipelineAvailablePropertiesARM")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDataGraphPipelineAvailablePropertiesARM")]
    Result GetDataGraphPipelineAvailablePropertiesARM(
        DeviceHandle device,
        DataGraphPipelineInfoARM* pPipelineInfo,
        uint* pPropertiesCount,
        DataGraphPipelinePropertyARM* pProperties
    );

    [NativeName("vkGetDataGraphPipelineAvailablePropertiesARM")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDataGraphPipelineAvailablePropertiesARM")]
    Result GetDataGraphPipelineAvailablePropertiesARM(
        DeviceHandle device,
        Ref<DataGraphPipelineInfoARM> pPipelineInfo,
        Ref<uint> pPropertiesCount,
        Ref<DataGraphPipelinePropertyARM> pProperties
    );

    [NativeName("vkGetDataGraphPipelinePropertiesARM")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDataGraphPipelinePropertiesARM")]
    Result GetDataGraphPipelinePropertiesARM(
        DeviceHandle device,
        DataGraphPipelineInfoARM* pPipelineInfo,
        uint propertiesCount,
        DataGraphPipelinePropertyQueryResultARM* pProperties
    );

    [NativeName("vkGetDataGraphPipelinePropertiesARM")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDataGraphPipelinePropertiesARM")]
    Result GetDataGraphPipelinePropertiesARM(
        DeviceHandle device,
        Ref<DataGraphPipelineInfoARM> pPipelineInfo,
        uint propertiesCount,
        Ref<DataGraphPipelinePropertyQueryResultARM> pProperties
    );

    [NativeName("vkGetDataGraphPipelineSessionBindPointRequirementsARM")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDataGraphPipelineSessionBindPointRequirementsARM")]
    Result GetDataGraphPipelineSessionBindPointRequirementsARM(
        DeviceHandle device,
        DataGraphPipelineSessionBindPointRequirementsInfoARM* pInfo,
        uint* pBindPointRequirementCount,
        DataGraphPipelineSessionBindPointRequirementARM* pBindPointRequirements
    );

    [NativeName("vkGetDataGraphPipelineSessionBindPointRequirementsARM")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDataGraphPipelineSessionBindPointRequirementsARM")]
    Result GetDataGraphPipelineSessionBindPointRequirementsARM(
        DeviceHandle device,
        Ref<DataGraphPipelineSessionBindPointRequirementsInfoARM> pInfo,
        Ref<uint> pBindPointRequirementCount,
        Ref<DataGraphPipelineSessionBindPointRequirementARM> pBindPointRequirements
    );

    [NativeName("vkGetDataGraphPipelineSessionMemoryRequirementsARM")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDataGraphPipelineSessionMemoryRequirementsARM")]
    void GetDataGraphPipelineSessionMemoryRequirementsARM(
        DeviceHandle device,
        DataGraphPipelineSessionMemoryRequirementsInfoARM* pInfo,
        MemoryRequirements2* pMemoryRequirements
    );

    [NativeName("vkGetDataGraphPipelineSessionMemoryRequirementsARM")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDataGraphPipelineSessionMemoryRequirementsARM")]
    void GetDataGraphPipelineSessionMemoryRequirementsARM(
        DeviceHandle device,
        Ref<DataGraphPipelineSessionMemoryRequirementsInfoARM> pInfo,
        Ref<MemoryRequirements2> pMemoryRequirements
    );

    [NativeName("vkGetDeferredOperationMaxConcurrencyKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeferredOperationMaxConcurrencyKHR")]
    uint GetDeferredOperationMaxConcurrencyKHR(
        DeviceHandle device,
        DeferredOperationHandleKHR operation
    );

    [NativeName("vkGetDeferredOperationResultKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeferredOperationResultKHR")]
    Result GetDeferredOperationResultKHR(DeviceHandle device, DeferredOperationHandleKHR operation);

    [NativeName("vkGetDescriptorEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDescriptorEXT")]
    void GetDescriptorEXT(
        DeviceHandle device,
        DescriptorGetInfoEXT* pDescriptorInfo,
        nuint dataSize,
        void* pDescriptor
    );

    [NativeName("vkGetDescriptorEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDescriptorEXT")]
    void GetDescriptorEXT(
        DeviceHandle device,
        Ref<DescriptorGetInfoEXT> pDescriptorInfo,
        nuint dataSize,
        Ref pDescriptor
    );

    [NativeName("vkGetDescriptorSetHostMappingVALVE")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDescriptorSetHostMappingVALVE")]
    void GetDescriptorSetHostMappingVALVE(
        DeviceHandle device,
        DescriptorSetHandle descriptorSet,
        void** ppData
    );

    [NativeName("vkGetDescriptorSetHostMappingVALVE")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDescriptorSetHostMappingVALVE")]
    void GetDescriptorSetHostMappingVALVE(
        DeviceHandle device,
        DescriptorSetHandle descriptorSet,
        Ref2D ppData
    );

    [NativeName("vkGetDescriptorSetLayoutBindingOffsetEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDescriptorSetLayoutBindingOffsetEXT")]
    void GetDescriptorSetLayoutBindingOffsetEXT(
        DeviceHandle device,
        DescriptorSetLayoutHandle layout,
        uint binding,
        ulong* pOffset
    );

    [NativeName("vkGetDescriptorSetLayoutBindingOffsetEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDescriptorSetLayoutBindingOffsetEXT")]
    void GetDescriptorSetLayoutBindingOffsetEXT(
        DeviceHandle device,
        DescriptorSetLayoutHandle layout,
        uint binding,
        Ref<ulong> pOffset
    );

    [NativeName("vkGetDescriptorSetLayoutHostMappingInfoVALVE")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDescriptorSetLayoutHostMappingInfoVALVE")]
    void GetDescriptorSetLayoutHostMappingInfoVALVE(
        DeviceHandle device,
        DescriptorSetBindingReferenceVALVE* pBindingReference,
        DescriptorSetLayoutHostMappingInfoVALVE* pHostMapping
    );

    [NativeName("vkGetDescriptorSetLayoutHostMappingInfoVALVE")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDescriptorSetLayoutHostMappingInfoVALVE")]
    void GetDescriptorSetLayoutHostMappingInfoVALVE(
        DeviceHandle device,
        Ref<DescriptorSetBindingReferenceVALVE> pBindingReference,
        Ref<DescriptorSetLayoutHostMappingInfoVALVE> pHostMapping
    );

    [NativeName("vkGetDescriptorSetLayoutSizeEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDescriptorSetLayoutSizeEXT")]
    void GetDescriptorSetLayoutSizeEXT(
        DeviceHandle device,
        DescriptorSetLayoutHandle layout,
        ulong* pLayoutSizeInBytes
    );

    [NativeName("vkGetDescriptorSetLayoutSizeEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDescriptorSetLayoutSizeEXT")]
    void GetDescriptorSetLayoutSizeEXT(
        DeviceHandle device,
        DescriptorSetLayoutHandle layout,
        Ref<ulong> pLayoutSizeInBytes
    );

    [NativeName("vkGetDescriptorSetLayoutSupport")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDescriptorSetLayoutSupport")]
    void GetDescriptorSetLayoutSupport(
        DeviceHandle device,
        DescriptorSetLayoutCreateInfo* pCreateInfo,
        DescriptorSetLayoutSupport* pSupport
    );

    [NativeName("vkGetDescriptorSetLayoutSupport")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDescriptorSetLayoutSupport")]
    void GetDescriptorSetLayoutSupport(
        DeviceHandle device,
        Ref<DescriptorSetLayoutCreateInfo> pCreateInfo,
        Ref<DescriptorSetLayoutSupport> pSupport
    );

    [NativeName("vkGetDescriptorSetLayoutSupportKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDescriptorSetLayoutSupportKHR")]
    void GetDescriptorSetLayoutSupportKHR(
        DeviceHandle device,
        DescriptorSetLayoutCreateInfo* pCreateInfo,
        DescriptorSetLayoutSupport* pSupport
    );

    [NativeName("vkGetDescriptorSetLayoutSupportKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDescriptorSetLayoutSupportKHR")]
    void GetDescriptorSetLayoutSupportKHR(
        DeviceHandle device,
        Ref<DescriptorSetLayoutCreateInfo> pCreateInfo,
        Ref<DescriptorSetLayoutSupport> pSupport
    );

    [NativeName("vkGetDeviceAccelerationStructureCompatibilityKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceAccelerationStructureCompatibilityKHR")]
    void GetDeviceAccelerationStructureCompatibilityKHR(
        DeviceHandle device,
        AccelerationStructureVersionInfoKHR* pVersionInfo,
        AccelerationStructureCompatibilityKHR* pCompatibility
    );

    [NativeName("vkGetDeviceAccelerationStructureCompatibilityKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceAccelerationStructureCompatibilityKHR")]
    void GetDeviceAccelerationStructureCompatibilityKHR(
        DeviceHandle device,
        Ref<AccelerationStructureVersionInfoKHR> pVersionInfo,
        Ref<AccelerationStructureCompatibilityKHR> pCompatibility
    );

    [NativeName("vkGetDeviceBufferMemoryRequirements")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceBufferMemoryRequirements")]
    void GetDeviceBufferMemoryRequirements(
        DeviceHandle device,
        DeviceBufferMemoryRequirements* pInfo,
        MemoryRequirements2* pMemoryRequirements
    );

    [NativeName("vkGetDeviceBufferMemoryRequirements")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceBufferMemoryRequirements")]
    void GetDeviceBufferMemoryRequirements(
        DeviceHandle device,
        Ref<DeviceBufferMemoryRequirements> pInfo,
        Ref<MemoryRequirements2> pMemoryRequirements
    );

    [NativeName("vkGetDeviceBufferMemoryRequirementsKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceBufferMemoryRequirementsKHR")]
    void GetDeviceBufferMemoryRequirementsKHR(
        DeviceHandle device,
        DeviceBufferMemoryRequirements* pInfo,
        MemoryRequirements2* pMemoryRequirements
    );

    [NativeName("vkGetDeviceBufferMemoryRequirementsKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceBufferMemoryRequirementsKHR")]
    void GetDeviceBufferMemoryRequirementsKHR(
        DeviceHandle device,
        Ref<DeviceBufferMemoryRequirements> pInfo,
        Ref<MemoryRequirements2> pMemoryRequirements
    );

    [NativeName("vkGetDeviceCombinedImageSamplerIndexNVX")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceCombinedImageSamplerIndexNVX")]
    ulong GetDeviceCombinedImageSamplerIndexNVX(
        DeviceHandle device,
        ulong imageViewIndex,
        ulong samplerIndex
    );

    [NativeName("vkGetDeviceFaultDebugInfoKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceFaultDebugInfoKHR")]
    Result GetDeviceFaultDebugInfoKHR(DeviceHandle device, DeviceFaultDebugInfoKHR* pDebugInfo);

    [NativeName("vkGetDeviceFaultDebugInfoKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceFaultDebugInfoKHR")]
    Result GetDeviceFaultDebugInfoKHR(DeviceHandle device, Ref<DeviceFaultDebugInfoKHR> pDebugInfo);

    [NativeName("vkGetDeviceFaultInfoEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceFaultInfoEXT")]
    Result GetDeviceFaultInfoEXT(
        DeviceHandle device,
        DeviceFaultCountsEXT* pFaultCounts,
        DeviceFaultInfoEXT* pFaultInfo
    );

    [NativeName("vkGetDeviceFaultInfoEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceFaultInfoEXT")]
    Result GetDeviceFaultInfoEXT(
        DeviceHandle device,
        Ref<DeviceFaultCountsEXT> pFaultCounts,
        Ref<DeviceFaultInfoEXT> pFaultInfo
    );

    [NativeName("vkGetDeviceFaultReportsKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceFaultReportsKHR")]
    Result GetDeviceFaultReportsKHR(
        DeviceHandle device,
        ulong timeout,
        uint* pFaultCounts,
        DeviceFaultInfoKHR* pFaultInfo
    );

    [NativeName("vkGetDeviceFaultReportsKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceFaultReportsKHR")]
    Result GetDeviceFaultReportsKHR(
        DeviceHandle device,
        ulong timeout,
        Ref<uint> pFaultCounts,
        Ref<DeviceFaultInfoKHR> pFaultInfo
    );

    [NativeName("vkGetDeviceGroupPeerMemoryFeatures")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceGroupPeerMemoryFeatures")]
    void GetDeviceGroupPeerMemoryFeatures(
        DeviceHandle device,
        uint heapIndex,
        uint localDeviceIndex,
        uint remoteDeviceIndex,
        PeerMemoryFeatureFlags* pPeerMemoryFeatures
    );

    [NativeName("vkGetDeviceGroupPeerMemoryFeatures")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceGroupPeerMemoryFeatures")]
    void GetDeviceGroupPeerMemoryFeatures(
        DeviceHandle device,
        uint heapIndex,
        uint localDeviceIndex,
        uint remoteDeviceIndex,
        Ref<PeerMemoryFeatureFlags> pPeerMemoryFeatures
    );

    [NativeName("vkGetDeviceGroupPeerMemoryFeaturesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceGroupPeerMemoryFeaturesKHR")]
    void GetDeviceGroupPeerMemoryFeaturesKHR(
        DeviceHandle device,
        uint heapIndex,
        uint localDeviceIndex,
        uint remoteDeviceIndex,
        PeerMemoryFeatureFlags* pPeerMemoryFeatures
    );

    [NativeName("vkGetDeviceGroupPeerMemoryFeaturesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceGroupPeerMemoryFeaturesKHR")]
    void GetDeviceGroupPeerMemoryFeaturesKHR(
        DeviceHandle device,
        uint heapIndex,
        uint localDeviceIndex,
        uint remoteDeviceIndex,
        Ref<PeerMemoryFeatureFlags> pPeerMemoryFeatures
    );

    [NativeName("vkGetDeviceGroupPresentCapabilitiesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceGroupPresentCapabilitiesKHR")]
    Result GetDeviceGroupPresentCapabilitiesKHR(
        DeviceHandle device,
        DeviceGroupPresentCapabilitiesKHR* pDeviceGroupPresentCapabilities
    );

    [NativeName("vkGetDeviceGroupPresentCapabilitiesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceGroupPresentCapabilitiesKHR")]
    Result GetDeviceGroupPresentCapabilitiesKHR(
        DeviceHandle device,
        Ref<DeviceGroupPresentCapabilitiesKHR> pDeviceGroupPresentCapabilities
    );

    [NativeName("vkGetDeviceGroupSurfacePresentModesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceGroupSurfacePresentModesKHR")]
    Result GetDeviceGroupSurfacePresentModesKHR(
        DeviceHandle device,
        SurfaceHandleKHR surface,
        DeviceGroupPresentModeFlagsKHR* pModes
    );

    [NativeName("vkGetDeviceGroupSurfacePresentModesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceGroupSurfacePresentModesKHR")]
    Result GetDeviceGroupSurfacePresentModesKHR(
        DeviceHandle device,
        SurfaceHandleKHR surface,
        Ref<DeviceGroupPresentModeFlagsKHR> pModes
    );

    [NativeName("vkGetDeviceImageMemoryRequirements")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceImageMemoryRequirements")]
    void GetDeviceImageMemoryRequirements(
        DeviceHandle device,
        DeviceImageMemoryRequirements* pInfo,
        MemoryRequirements2* pMemoryRequirements
    );

    [NativeName("vkGetDeviceImageMemoryRequirements")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceImageMemoryRequirements")]
    void GetDeviceImageMemoryRequirements(
        DeviceHandle device,
        Ref<DeviceImageMemoryRequirements> pInfo,
        Ref<MemoryRequirements2> pMemoryRequirements
    );

    [NativeName("vkGetDeviceImageMemoryRequirementsKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceImageMemoryRequirementsKHR")]
    void GetDeviceImageMemoryRequirementsKHR(
        DeviceHandle device,
        DeviceImageMemoryRequirements* pInfo,
        MemoryRequirements2* pMemoryRequirements
    );

    [NativeName("vkGetDeviceImageMemoryRequirementsKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceImageMemoryRequirementsKHR")]
    void GetDeviceImageMemoryRequirementsKHR(
        DeviceHandle device,
        Ref<DeviceImageMemoryRequirements> pInfo,
        Ref<MemoryRequirements2> pMemoryRequirements
    );

    [NativeName("vkGetDeviceImageSparseMemoryRequirements")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceImageSparseMemoryRequirements")]
    void GetDeviceImageSparseMemoryRequirements(
        DeviceHandle device,
        DeviceImageMemoryRequirements* pInfo,
        uint* pSparseMemoryRequirementCount,
        SparseImageMemoryRequirements2* pSparseMemoryRequirements
    );

    [NativeName("vkGetDeviceImageSparseMemoryRequirements")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceImageSparseMemoryRequirements")]
    void GetDeviceImageSparseMemoryRequirements(
        DeviceHandle device,
        Ref<DeviceImageMemoryRequirements> pInfo,
        Ref<uint> pSparseMemoryRequirementCount,
        Ref<SparseImageMemoryRequirements2> pSparseMemoryRequirements
    );

    [NativeName("vkGetDeviceImageSparseMemoryRequirementsKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceImageSparseMemoryRequirementsKHR")]
    void GetDeviceImageSparseMemoryRequirementsKHR(
        DeviceHandle device,
        DeviceImageMemoryRequirements* pInfo,
        uint* pSparseMemoryRequirementCount,
        SparseImageMemoryRequirements2* pSparseMemoryRequirements
    );

    [NativeName("vkGetDeviceImageSparseMemoryRequirementsKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceImageSparseMemoryRequirementsKHR")]
    void GetDeviceImageSparseMemoryRequirementsKHR(
        DeviceHandle device,
        Ref<DeviceImageMemoryRequirements> pInfo,
        Ref<uint> pSparseMemoryRequirementCount,
        Ref<SparseImageMemoryRequirements2> pSparseMemoryRequirements
    );

    [NativeName("vkGetDeviceImageSubresourceLayout")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceImageSubresourceLayout")]
    void GetDeviceImageSubresourceLayout(
        DeviceHandle device,
        DeviceImageSubresourceInfo* pInfo,
        SubresourceLayout2* pLayout
    );

    [NativeName("vkGetDeviceImageSubresourceLayout")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceImageSubresourceLayout")]
    void GetDeviceImageSubresourceLayout(
        DeviceHandle device,
        Ref<DeviceImageSubresourceInfo> pInfo,
        Ref<SubresourceLayout2> pLayout
    );

    [NativeName("vkGetDeviceImageSubresourceLayoutKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceImageSubresourceLayoutKHR")]
    void GetDeviceImageSubresourceLayoutKHR(
        DeviceHandle device,
        DeviceImageSubresourceInfo* pInfo,
        SubresourceLayout2* pLayout
    );

    [NativeName("vkGetDeviceImageSubresourceLayoutKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceImageSubresourceLayoutKHR")]
    void GetDeviceImageSubresourceLayoutKHR(
        DeviceHandle device,
        Ref<DeviceImageSubresourceInfo> pInfo,
        Ref<SubresourceLayout2> pLayout
    );

    [NativeName("vkGetDeviceMemoryCommitment")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceMemoryCommitment")]
    void GetDeviceMemoryCommitment(
        DeviceHandle device,
        DeviceMemoryHandle memory,
        ulong* pCommittedMemoryInBytes
    );

    [NativeName("vkGetDeviceMemoryCommitment")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceMemoryCommitment")]
    void GetDeviceMemoryCommitment(
        DeviceHandle device,
        DeviceMemoryHandle memory,
        Ref<ulong> pCommittedMemoryInBytes
    );

    [NativeName("vkGetDeviceMemoryOpaqueCaptureAddress")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceMemoryOpaqueCaptureAddress")]
    ulong GetDeviceMemoryOpaqueCaptureAddress(
        DeviceHandle device,
        DeviceMemoryOpaqueCaptureAddressInfo* pInfo
    );

    [NativeName("vkGetDeviceMemoryOpaqueCaptureAddress")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceMemoryOpaqueCaptureAddress")]
    ulong GetDeviceMemoryOpaqueCaptureAddress(
        DeviceHandle device,
        Ref<DeviceMemoryOpaqueCaptureAddressInfo> pInfo
    );

    [NativeName("vkGetDeviceMemoryOpaqueCaptureAddressKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceMemoryOpaqueCaptureAddressKHR")]
    ulong GetDeviceMemoryOpaqueCaptureAddressKHR(
        DeviceHandle device,
        DeviceMemoryOpaqueCaptureAddressInfo* pInfo
    );

    [NativeName("vkGetDeviceMemoryOpaqueCaptureAddressKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceMemoryOpaqueCaptureAddressKHR")]
    ulong GetDeviceMemoryOpaqueCaptureAddressKHR(
        DeviceHandle device,
        Ref<DeviceMemoryOpaqueCaptureAddressInfo> pInfo
    );

    [NativeName("vkGetDeviceMicromapCompatibilityEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceMicromapCompatibilityEXT")]
    void GetDeviceMicromapCompatibilityEXT(
        DeviceHandle device,
        MicromapVersionInfoEXT* pVersionInfo,
        AccelerationStructureCompatibilityKHR* pCompatibility
    );

    [NativeName("vkGetDeviceMicromapCompatibilityEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceMicromapCompatibilityEXT")]
    void GetDeviceMicromapCompatibilityEXT(
        DeviceHandle device,
        Ref<MicromapVersionInfoEXT> pVersionInfo,
        Ref<AccelerationStructureCompatibilityKHR> pCompatibility
    );

    [NativeName("vkGetDeviceProcAddr")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceProcAddr")]
    VoidFunction GetDeviceProcAddr(DeviceHandle device, sbyte* pName);

    [NativeName("vkGetDeviceProcAddr")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceProcAddr")]
    VoidFunction GetDeviceProcAddr(DeviceHandle device, Ref<sbyte> pName);

    [NativeName("vkGetDeviceQueue")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceQueue")]
    void GetDeviceQueue(
        DeviceHandle device,
        uint queueFamilyIndex,
        uint queueIndex,
        QueueHandle* pQueue
    );

    [NativeName("vkGetDeviceQueue")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceQueue")]
    void GetDeviceQueue(
        DeviceHandle device,
        uint queueFamilyIndex,
        uint queueIndex,
        Ref<QueueHandle> pQueue
    );

    [NativeName("vkGetDeviceQueue2")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceQueue2")]
    void GetDeviceQueue2(DeviceHandle device, DeviceQueueInfo2* pQueueInfo, QueueHandle* pQueue);

    [NativeName("vkGetDeviceQueue2")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceQueue2")]
    void GetDeviceQueue2(
        DeviceHandle device,
        Ref<DeviceQueueInfo2> pQueueInfo,
        Ref<QueueHandle> pQueue
    );

    [NativeName("vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI")]
    Result GetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(
        DeviceHandle device,
        RenderPassHandle renderpass,
        Extent2D* pMaxWorkgroupSize
    );

    [NativeName("vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI")]
    Result GetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(
        DeviceHandle device,
        RenderPassHandle renderpass,
        Ref<Extent2D> pMaxWorkgroupSize
    );

    [NativeName("vkGetDeviceTensorMemoryRequirementsARM")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceTensorMemoryRequirementsARM")]
    void GetDeviceTensorMemoryRequirementsARM(
        DeviceHandle device,
        DeviceTensorMemoryRequirementsARM* pInfo,
        MemoryRequirements2* pMemoryRequirements
    );

    [NativeName("vkGetDeviceTensorMemoryRequirementsARM")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDeviceTensorMemoryRequirementsARM")]
    void GetDeviceTensorMemoryRequirementsARM(
        DeviceHandle device,
        Ref<DeviceTensorMemoryRequirementsARM> pInfo,
        Ref<MemoryRequirements2> pMemoryRequirements
    );

    [NativeName("vkGetDisplayModeProperties2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDisplayModeProperties2KHR")]
    Result GetDisplayModeProperties2KHR(
        PhysicalDeviceHandle physicalDevice,
        DisplayHandleKHR display,
        uint* pPropertyCount,
        DisplayModeProperties2KHR* pProperties
    );

    [NativeName("vkGetDisplayModeProperties2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDisplayModeProperties2KHR")]
    Result GetDisplayModeProperties2KHR(
        PhysicalDeviceHandle physicalDevice,
        DisplayHandleKHR display,
        Ref<uint> pPropertyCount,
        Ref<DisplayModeProperties2KHR> pProperties
    );

    [NativeName("vkGetDisplayModePropertiesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDisplayModePropertiesKHR")]
    Result GetDisplayModePropertiesKHR(
        PhysicalDeviceHandle physicalDevice,
        DisplayHandleKHR display,
        uint* pPropertyCount,
        DisplayModePropertiesKHR* pProperties
    );

    [NativeName("vkGetDisplayModePropertiesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDisplayModePropertiesKHR")]
    Result GetDisplayModePropertiesKHR(
        PhysicalDeviceHandle physicalDevice,
        DisplayHandleKHR display,
        Ref<uint> pPropertyCount,
        Ref<DisplayModePropertiesKHR> pProperties
    );

    [NativeName("vkGetDisplayPlaneCapabilities2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDisplayPlaneCapabilities2KHR")]
    Result GetDisplayPlaneCapabilities2KHR(
        PhysicalDeviceHandle physicalDevice,
        DisplayPlaneInfo2KHR* pDisplayPlaneInfo,
        DisplayPlaneCapabilities2KHR* pCapabilities
    );

    [NativeName("vkGetDisplayPlaneCapabilities2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDisplayPlaneCapabilities2KHR")]
    Result GetDisplayPlaneCapabilities2KHR(
        PhysicalDeviceHandle physicalDevice,
        Ref<DisplayPlaneInfo2KHR> pDisplayPlaneInfo,
        Ref<DisplayPlaneCapabilities2KHR> pCapabilities
    );

    [NativeName("vkGetDisplayPlaneCapabilitiesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDisplayPlaneCapabilitiesKHR")]
    Result GetDisplayPlaneCapabilitiesKHR(
        PhysicalDeviceHandle physicalDevice,
        DisplayModeHandleKHR mode,
        uint planeIndex,
        DisplayPlaneCapabilitiesKHR* pCapabilities
    );

    [NativeName("vkGetDisplayPlaneCapabilitiesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDisplayPlaneCapabilitiesKHR")]
    Result GetDisplayPlaneCapabilitiesKHR(
        PhysicalDeviceHandle physicalDevice,
        DisplayModeHandleKHR mode,
        uint planeIndex,
        Ref<DisplayPlaneCapabilitiesKHR> pCapabilities
    );

    [NativeName("vkGetDisplayPlaneSupportedDisplaysKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDisplayPlaneSupportedDisplaysKHR")]
    Result GetDisplayPlaneSupportedDisplaysKHR(
        PhysicalDeviceHandle physicalDevice,
        uint planeIndex,
        uint* pDisplayCount,
        DisplayHandleKHR* pDisplays
    );

    [NativeName("vkGetDisplayPlaneSupportedDisplaysKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDisplayPlaneSupportedDisplaysKHR")]
    Result GetDisplayPlaneSupportedDisplaysKHR(
        PhysicalDeviceHandle physicalDevice,
        uint planeIndex,
        Ref<uint> pDisplayCount,
        Ref<DisplayHandleKHR> pDisplays
    );

    [NativeName("vkGetDrmDisplayEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDrmDisplayEXT")]
    Result GetDrmDisplayEXT(
        PhysicalDeviceHandle physicalDevice,
        int drmFd,
        uint connectorId,
        DisplayHandleKHR* display
    );

    [NativeName("vkGetDrmDisplayEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDrmDisplayEXT")]
    Result GetDrmDisplayEXT(
        PhysicalDeviceHandle physicalDevice,
        int drmFd,
        uint connectorId,
        Ref<DisplayHandleKHR> display
    );

    [NativeName("vkGetDynamicRenderingTilePropertiesQCOM")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDynamicRenderingTilePropertiesQCOM")]
    Result GetDynamicRenderingTilePropertiesQCOM(
        DeviceHandle device,
        RenderingInfo* pRenderingInfo,
        TilePropertiesQCOM* pProperties
    );

    [NativeName("vkGetDynamicRenderingTilePropertiesQCOM")]
    [NativeFunction("vulkan", EntryPoint = "vkGetDynamicRenderingTilePropertiesQCOM")]
    Result GetDynamicRenderingTilePropertiesQCOM(
        DeviceHandle device,
        Ref<RenderingInfo> pRenderingInfo,
        Ref<TilePropertiesQCOM> pProperties
    );

    [NativeName("vkGetEncodedVideoSessionParametersKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetEncodedVideoSessionParametersKHR")]
    Result GetEncodedVideoSessionParametersKHR(
        DeviceHandle device,
        VideoEncodeSessionParametersGetInfoKHR* pVideoSessionParametersInfo,
        VideoEncodeSessionParametersFeedbackInfoKHR* pFeedbackInfo,
        nuint* pDataSize,
        void* pData
    );

    [NativeName("vkGetEncodedVideoSessionParametersKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetEncodedVideoSessionParametersKHR")]
    Result GetEncodedVideoSessionParametersKHR(
        DeviceHandle device,
        Ref<VideoEncodeSessionParametersGetInfoKHR> pVideoSessionParametersInfo,
        Ref<VideoEncodeSessionParametersFeedbackInfoKHR> pFeedbackInfo,
        Ref<nuint> pDataSize,
        Ref pData
    );

    [NativeName("vkGetEventStatus")]
    [NativeFunction("vulkan", EntryPoint = "vkGetEventStatus")]
    Result GetEventStatus(DeviceHandle device, EventHandle @event);

    [NativeName("vkGetExternalComputeQueueDataNV")]
    [NativeFunction("vulkan", EntryPoint = "vkGetExternalComputeQueueDataNV")]
    void GetExternalComputeQueueDataNV(
        ExternalComputeQueueHandleNV externalQueue,
        ExternalComputeQueueDataParamsNV* @params,
        void* pData
    );

    [NativeName("vkGetExternalComputeQueueDataNV")]
    [NativeFunction("vulkan", EntryPoint = "vkGetExternalComputeQueueDataNV")]
    void GetExternalComputeQueueDataNV(
        ExternalComputeQueueHandleNV externalQueue,
        Ref<ExternalComputeQueueDataParamsNV> @params,
        Ref pData
    );

    [NativeName("vkGetFenceFdKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetFenceFdKHR")]
    Result GetFenceFdKHR(DeviceHandle device, FenceGetFdInfoKHR* pGetFdInfo, int* pFd);

    [NativeName("vkGetFenceFdKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetFenceFdKHR")]
    Result GetFenceFdKHR(DeviceHandle device, Ref<FenceGetFdInfoKHR> pGetFdInfo, Ref<int> pFd);

    [NativeName("vkGetFenceStatus")]
    [NativeFunction("vulkan", EntryPoint = "vkGetFenceStatus")]
    Result GetFenceStatus(DeviceHandle device, FenceHandle fence);

    [NativeName("vkGetFramebufferTilePropertiesQCOM")]
    [NativeFunction("vulkan", EntryPoint = "vkGetFramebufferTilePropertiesQCOM")]
    Result GetFramebufferTilePropertiesQCOM(
        DeviceHandle device,
        FramebufferHandle framebuffer,
        uint* pPropertiesCount,
        TilePropertiesQCOM* pProperties
    );

    [NativeName("vkGetFramebufferTilePropertiesQCOM")]
    [NativeFunction("vulkan", EntryPoint = "vkGetFramebufferTilePropertiesQCOM")]
    Result GetFramebufferTilePropertiesQCOM(
        DeviceHandle device,
        FramebufferHandle framebuffer,
        Ref<uint> pPropertiesCount,
        Ref<TilePropertiesQCOM> pProperties
    );

    [NativeName("vkGetGeneratedCommandsMemoryRequirementsEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetGeneratedCommandsMemoryRequirementsEXT")]
    void GetGeneratedCommandsMemoryRequirementsEXT(
        DeviceHandle device,
        GeneratedCommandsMemoryRequirementsInfoEXT* pInfo,
        MemoryRequirements2* pMemoryRequirements
    );

    [NativeName("vkGetGeneratedCommandsMemoryRequirementsEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetGeneratedCommandsMemoryRequirementsEXT")]
    void GetGeneratedCommandsMemoryRequirementsEXT(
        DeviceHandle device,
        Ref<GeneratedCommandsMemoryRequirementsInfoEXT> pInfo,
        Ref<MemoryRequirements2> pMemoryRequirements
    );

    [NativeName("vkGetGeneratedCommandsMemoryRequirementsNV")]
    [NativeFunction("vulkan", EntryPoint = "vkGetGeneratedCommandsMemoryRequirementsNV")]
    void GetGeneratedCommandsMemoryRequirementsNV(
        DeviceHandle device,
        GeneratedCommandsMemoryRequirementsInfoNV* pInfo,
        MemoryRequirements2* pMemoryRequirements
    );

    [NativeName("vkGetGeneratedCommandsMemoryRequirementsNV")]
    [NativeFunction("vulkan", EntryPoint = "vkGetGeneratedCommandsMemoryRequirementsNV")]
    void GetGeneratedCommandsMemoryRequirementsNV(
        DeviceHandle device,
        Ref<GeneratedCommandsMemoryRequirementsInfoNV> pInfo,
        Ref<MemoryRequirements2> pMemoryRequirements
    );

    [NativeName("vkGetGpaDeviceClockInfoAMD")]
    [NativeFunction("vulkan", EntryPoint = "vkGetGpaDeviceClockInfoAMD")]
    Result GetGpaDeviceClockInfoAMD(DeviceHandle device, GpaDeviceGetClockInfoAMD* pInfo);

    [NativeName("vkGetGpaDeviceClockInfoAMD")]
    [NativeFunction("vulkan", EntryPoint = "vkGetGpaDeviceClockInfoAMD")]
    Result GetGpaDeviceClockInfoAMD(DeviceHandle device, Ref<GpaDeviceGetClockInfoAMD> pInfo);

    [NativeName("vkGetGpaSessionResultsAMD")]
    [NativeFunction("vulkan", EntryPoint = "vkGetGpaSessionResultsAMD")]
    Result GetGpaSessionResultsAMD(
        DeviceHandle device,
        GpaSessionHandleAMD gpaSession,
        uint sampleID,
        nuint* pSizeInBytes,
        void* pData
    );

    [NativeName("vkGetGpaSessionResultsAMD")]
    [NativeFunction("vulkan", EntryPoint = "vkGetGpaSessionResultsAMD")]
    Result GetGpaSessionResultsAMD(
        DeviceHandle device,
        GpaSessionHandleAMD gpaSession,
        uint sampleID,
        Ref<nuint> pSizeInBytes,
        Ref pData
    );

    [NativeName("vkGetGpaSessionStatusAMD")]
    [NativeFunction("vulkan", EntryPoint = "vkGetGpaSessionStatusAMD")]
    Result GetGpaSessionStatusAMD(DeviceHandle device, GpaSessionHandleAMD gpaSession);

    [NativeName("vkGetImageDrmFormatModifierPropertiesEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetImageDrmFormatModifierPropertiesEXT")]
    Result GetImageDrmFormatModifierPropertiesEXT(
        DeviceHandle device,
        ImageHandle image,
        ImageDrmFormatModifierPropertiesEXT* pProperties
    );

    [NativeName("vkGetImageDrmFormatModifierPropertiesEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetImageDrmFormatModifierPropertiesEXT")]
    Result GetImageDrmFormatModifierPropertiesEXT(
        DeviceHandle device,
        ImageHandle image,
        Ref<ImageDrmFormatModifierPropertiesEXT> pProperties
    );

    [NativeName("vkGetImageMemoryRequirements")]
    [NativeFunction("vulkan", EntryPoint = "vkGetImageMemoryRequirements")]
    void GetImageMemoryRequirements(
        DeviceHandle device,
        ImageHandle image,
        MemoryRequirements* pMemoryRequirements
    );

    [NativeName("vkGetImageMemoryRequirements")]
    [NativeFunction("vulkan", EntryPoint = "vkGetImageMemoryRequirements")]
    void GetImageMemoryRequirements(
        DeviceHandle device,
        ImageHandle image,
        Ref<MemoryRequirements> pMemoryRequirements
    );

    [NativeName("vkGetImageMemoryRequirements2")]
    [NativeFunction("vulkan", EntryPoint = "vkGetImageMemoryRequirements2")]
    void GetImageMemoryRequirements2(
        DeviceHandle device,
        ImageMemoryRequirementsInfo2* pInfo,
        MemoryRequirements2* pMemoryRequirements
    );

    [NativeName("vkGetImageMemoryRequirements2")]
    [NativeFunction("vulkan", EntryPoint = "vkGetImageMemoryRequirements2")]
    void GetImageMemoryRequirements2(
        DeviceHandle device,
        Ref<ImageMemoryRequirementsInfo2> pInfo,
        Ref<MemoryRequirements2> pMemoryRequirements
    );

    [NativeName("vkGetImageMemoryRequirements2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetImageMemoryRequirements2KHR")]
    void GetImageMemoryRequirements2KHR(
        DeviceHandle device,
        ImageMemoryRequirementsInfo2* pInfo,
        MemoryRequirements2* pMemoryRequirements
    );

    [NativeName("vkGetImageMemoryRequirements2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetImageMemoryRequirements2KHR")]
    void GetImageMemoryRequirements2KHR(
        DeviceHandle device,
        Ref<ImageMemoryRequirementsInfo2> pInfo,
        Ref<MemoryRequirements2> pMemoryRequirements
    );

    [NativeName("vkGetImageOpaqueCaptureDataEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetImageOpaqueCaptureDataEXT")]
    Result GetImageOpaqueCaptureDataEXT(
        DeviceHandle device,
        uint imageCount,
        ImageHandle* pImages,
        HostAddressRangeEXT* pDatas
    );

    [NativeName("vkGetImageOpaqueCaptureDataEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetImageOpaqueCaptureDataEXT")]
    Result GetImageOpaqueCaptureDataEXT(
        DeviceHandle device,
        uint imageCount,
        Ref<ImageHandle> pImages,
        Ref<HostAddressRangeEXT> pDatas
    );

    [NativeName("vkGetImageOpaqueCaptureDescriptorDataEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetImageOpaqueCaptureDescriptorDataEXT")]
    Result GetImageOpaqueCaptureDescriptorDataEXT(
        DeviceHandle device,
        ImageCaptureDescriptorDataInfoEXT* pInfo,
        void* pData
    );

    [NativeName("vkGetImageOpaqueCaptureDescriptorDataEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetImageOpaqueCaptureDescriptorDataEXT")]
    Result GetImageOpaqueCaptureDescriptorDataEXT(
        DeviceHandle device,
        Ref<ImageCaptureDescriptorDataInfoEXT> pInfo,
        Ref pData
    );

    [NativeName("vkGetImageSparseMemoryRequirements")]
    [NativeFunction("vulkan", EntryPoint = "vkGetImageSparseMemoryRequirements")]
    void GetImageSparseMemoryRequirements(
        DeviceHandle device,
        ImageHandle image,
        uint* pSparseMemoryRequirementCount,
        SparseImageMemoryRequirements* pSparseMemoryRequirements
    );

    [NativeName("vkGetImageSparseMemoryRequirements")]
    [NativeFunction("vulkan", EntryPoint = "vkGetImageSparseMemoryRequirements")]
    void GetImageSparseMemoryRequirements(
        DeviceHandle device,
        ImageHandle image,
        Ref<uint> pSparseMemoryRequirementCount,
        Ref<SparseImageMemoryRequirements> pSparseMemoryRequirements
    );

    [NativeName("vkGetImageSparseMemoryRequirements2")]
    [NativeFunction("vulkan", EntryPoint = "vkGetImageSparseMemoryRequirements2")]
    void GetImageSparseMemoryRequirements2(
        DeviceHandle device,
        ImageSparseMemoryRequirementsInfo2* pInfo,
        uint* pSparseMemoryRequirementCount,
        SparseImageMemoryRequirements2* pSparseMemoryRequirements
    );

    [NativeName("vkGetImageSparseMemoryRequirements2")]
    [NativeFunction("vulkan", EntryPoint = "vkGetImageSparseMemoryRequirements2")]
    void GetImageSparseMemoryRequirements2(
        DeviceHandle device,
        Ref<ImageSparseMemoryRequirementsInfo2> pInfo,
        Ref<uint> pSparseMemoryRequirementCount,
        Ref<SparseImageMemoryRequirements2> pSparseMemoryRequirements
    );

    [NativeName("vkGetImageSparseMemoryRequirements2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetImageSparseMemoryRequirements2KHR")]
    void GetImageSparseMemoryRequirements2KHR(
        DeviceHandle device,
        ImageSparseMemoryRequirementsInfo2* pInfo,
        uint* pSparseMemoryRequirementCount,
        SparseImageMemoryRequirements2* pSparseMemoryRequirements
    );

    [NativeName("vkGetImageSparseMemoryRequirements2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetImageSparseMemoryRequirements2KHR")]
    void GetImageSparseMemoryRequirements2KHR(
        DeviceHandle device,
        Ref<ImageSparseMemoryRequirementsInfo2> pInfo,
        Ref<uint> pSparseMemoryRequirementCount,
        Ref<SparseImageMemoryRequirements2> pSparseMemoryRequirements
    );

    [NativeName("vkGetImageSubresourceLayout")]
    [NativeFunction("vulkan", EntryPoint = "vkGetImageSubresourceLayout")]
    void GetImageSubresourceLayout(
        DeviceHandle device,
        ImageHandle image,
        ImageSubresource* pSubresource,
        SubresourceLayout* pLayout
    );

    [NativeName("vkGetImageSubresourceLayout")]
    [NativeFunction("vulkan", EntryPoint = "vkGetImageSubresourceLayout")]
    void GetImageSubresourceLayout(
        DeviceHandle device,
        ImageHandle image,
        Ref<ImageSubresource> pSubresource,
        Ref<SubresourceLayout> pLayout
    );

    [NativeName("vkGetImageSubresourceLayout2")]
    [NativeFunction("vulkan", EntryPoint = "vkGetImageSubresourceLayout2")]
    void GetImageSubresourceLayout2(
        DeviceHandle device,
        ImageHandle image,
        ImageSubresource2* pSubresource,
        SubresourceLayout2* pLayout
    );

    [NativeName("vkGetImageSubresourceLayout2")]
    [NativeFunction("vulkan", EntryPoint = "vkGetImageSubresourceLayout2")]
    void GetImageSubresourceLayout2(
        DeviceHandle device,
        ImageHandle image,
        Ref<ImageSubresource2> pSubresource,
        Ref<SubresourceLayout2> pLayout
    );

    [NativeName("vkGetImageSubresourceLayout2EXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetImageSubresourceLayout2EXT")]
    void GetImageSubresourceLayout2EXT(
        DeviceHandle device,
        ImageHandle image,
        ImageSubresource2* pSubresource,
        SubresourceLayout2* pLayout
    );

    [NativeName("vkGetImageSubresourceLayout2EXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetImageSubresourceLayout2EXT")]
    void GetImageSubresourceLayout2EXT(
        DeviceHandle device,
        ImageHandle image,
        Ref<ImageSubresource2> pSubresource,
        Ref<SubresourceLayout2> pLayout
    );

    [NativeName("vkGetImageSubresourceLayout2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetImageSubresourceLayout2KHR")]
    void GetImageSubresourceLayout2KHR(
        DeviceHandle device,
        ImageHandle image,
        ImageSubresource2* pSubresource,
        SubresourceLayout2* pLayout
    );

    [NativeName("vkGetImageSubresourceLayout2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetImageSubresourceLayout2KHR")]
    void GetImageSubresourceLayout2KHR(
        DeviceHandle device,
        ImageHandle image,
        Ref<ImageSubresource2> pSubresource,
        Ref<SubresourceLayout2> pLayout
    );

    [NativeName("vkGetImageViewAddressNVX")]
    [NativeFunction("vulkan", EntryPoint = "vkGetImageViewAddressNVX")]
    Result GetImageViewAddressNVX(
        DeviceHandle device,
        ImageViewHandle imageView,
        ImageViewAddressPropertiesNVX* pProperties
    );

    [NativeName("vkGetImageViewAddressNVX")]
    [NativeFunction("vulkan", EntryPoint = "vkGetImageViewAddressNVX")]
    Result GetImageViewAddressNVX(
        DeviceHandle device,
        ImageViewHandle imageView,
        Ref<ImageViewAddressPropertiesNVX> pProperties
    );

    [NativeName("vkGetImageViewHandle64NVX")]
    [NativeFunction("vulkan", EntryPoint = "vkGetImageViewHandle64NVX")]
    ulong GetImageViewHandle64NVX(DeviceHandle device, ImageViewHandleInfoNVX* pInfo);

    [NativeName("vkGetImageViewHandle64NVX")]
    [NativeFunction("vulkan", EntryPoint = "vkGetImageViewHandle64NVX")]
    ulong GetImageViewHandle64NVX(DeviceHandle device, Ref<ImageViewHandleInfoNVX> pInfo);

    [NativeName("vkGetImageViewHandleNVX")]
    [NativeFunction("vulkan", EntryPoint = "vkGetImageViewHandleNVX")]
    uint GetImageViewHandleNVX(DeviceHandle device, ImageViewHandleInfoNVX* pInfo);

    [NativeName("vkGetImageViewHandleNVX")]
    [NativeFunction("vulkan", EntryPoint = "vkGetImageViewHandleNVX")]
    uint GetImageViewHandleNVX(DeviceHandle device, Ref<ImageViewHandleInfoNVX> pInfo);

    [NativeName("vkGetImageViewOpaqueCaptureDescriptorDataEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetImageViewOpaqueCaptureDescriptorDataEXT")]
    Result GetImageViewOpaqueCaptureDescriptorDataEXT(
        DeviceHandle device,
        ImageViewCaptureDescriptorDataInfoEXT* pInfo,
        void* pData
    );

    [NativeName("vkGetImageViewOpaqueCaptureDescriptorDataEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetImageViewOpaqueCaptureDescriptorDataEXT")]
    Result GetImageViewOpaqueCaptureDescriptorDataEXT(
        DeviceHandle device,
        Ref<ImageViewCaptureDescriptorDataInfoEXT> pInfo,
        Ref pData
    );

    [NativeName("vkGetInstanceProcAddr")]
    [NativeFunction("vulkan", EntryPoint = "vkGetInstanceProcAddr")]
    VoidFunction GetInstanceProcAddr(InstanceHandle instance, sbyte* pName);

    [NativeName("vkGetInstanceProcAddr")]
    [NativeFunction("vulkan", EntryPoint = "vkGetInstanceProcAddr")]
    VoidFunction GetInstanceProcAddr(InstanceHandle instance, Ref<sbyte> pName);

    [NativeName("vkGetLatencyTimingsNV")]
    [NativeFunction("vulkan", EntryPoint = "vkGetLatencyTimingsNV")]
    void GetLatencyTimingsNV(
        DeviceHandle device,
        SwapchainHandleKHR swapchain,
        GetLatencyMarkerInfoNV* pLatencyMarkerInfo
    );

    [NativeName("vkGetLatencyTimingsNV")]
    [NativeFunction("vulkan", EntryPoint = "vkGetLatencyTimingsNV")]
    void GetLatencyTimingsNV(
        DeviceHandle device,
        SwapchainHandleKHR swapchain,
        Ref<GetLatencyMarkerInfoNV> pLatencyMarkerInfo
    );

    [NativeName("vkGetMemoryFdKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetMemoryFdKHR")]
    Result GetMemoryFdKHR(DeviceHandle device, MemoryGetFdInfoKHR* pGetFdInfo, int* pFd);

    [NativeName("vkGetMemoryFdKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetMemoryFdKHR")]
    Result GetMemoryFdKHR(DeviceHandle device, Ref<MemoryGetFdInfoKHR> pGetFdInfo, Ref<int> pFd);

    [NativeName("vkGetMemoryFdPropertiesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetMemoryFdPropertiesKHR")]
    Result GetMemoryFdPropertiesKHR(
        DeviceHandle device,
        ExternalMemoryHandleTypeFlags handleType,
        int fd,
        MemoryFdPropertiesKHR* pMemoryFdProperties
    );

    [NativeName("vkGetMemoryFdPropertiesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetMemoryFdPropertiesKHR")]
    Result GetMemoryFdPropertiesKHR(
        DeviceHandle device,
        ExternalMemoryHandleTypeFlags handleType,
        int fd,
        Ref<MemoryFdPropertiesKHR> pMemoryFdProperties
    );

    [NativeName("vkGetMemoryHostPointerPropertiesEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetMemoryHostPointerPropertiesEXT")]
    Result GetMemoryHostPointerPropertiesEXT(
        DeviceHandle device,
        ExternalMemoryHandleTypeFlags handleType,
        void* pHostPointer,
        MemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties
    );

    [NativeName("vkGetMemoryHostPointerPropertiesEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetMemoryHostPointerPropertiesEXT")]
    Result GetMemoryHostPointerPropertiesEXT(
        DeviceHandle device,
        ExternalMemoryHandleTypeFlags handleType,
        Ref pHostPointer,
        Ref<MemoryHostPointerPropertiesEXT> pMemoryHostPointerProperties
    );

    [NativeName("vkGetMemoryRemoteAddressNV")]
    [NativeFunction("vulkan", EntryPoint = "vkGetMemoryRemoteAddressNV")]
    Result GetMemoryRemoteAddressNV(
        DeviceHandle device,
        MemoryGetRemoteAddressInfoNV* pMemoryGetRemoteAddressInfo,
        void** pAddress
    );

    [NativeName("vkGetMemoryRemoteAddressNV")]
    [NativeFunction("vulkan", EntryPoint = "vkGetMemoryRemoteAddressNV")]
    Result GetMemoryRemoteAddressNV(
        DeviceHandle device,
        Ref<MemoryGetRemoteAddressInfoNV> pMemoryGetRemoteAddressInfo,
        Ref2D pAddress
    );

    [NativeName("vkGetMicromapBuildSizesEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetMicromapBuildSizesEXT")]
    void GetMicromapBuildSizesEXT(
        DeviceHandle device,
        AccelerationStructureBuildTypeKHR buildType,
        MicromapBuildInfoEXT* pBuildInfo,
        MicromapBuildSizesInfoEXT* pSizeInfo
    );

    [NativeName("vkGetMicromapBuildSizesEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetMicromapBuildSizesEXT")]
    void GetMicromapBuildSizesEXT(
        DeviceHandle device,
        AccelerationStructureBuildTypeKHR buildType,
        Ref<MicromapBuildInfoEXT> pBuildInfo,
        Ref<MicromapBuildSizesInfoEXT> pSizeInfo
    );

    [NativeName("vkGetPartitionedAccelerationStructuresBuildSizesNV")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPartitionedAccelerationStructuresBuildSizesNV")]
    void GetPartitionedAccelerationStructuresBuildSizesNV(
        DeviceHandle device,
        PartitionedAccelerationStructureInstancesInputNV* pInfo,
        AccelerationStructureBuildSizesInfoKHR* pSizeInfo
    );

    [NativeName("vkGetPartitionedAccelerationStructuresBuildSizesNV")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPartitionedAccelerationStructuresBuildSizesNV")]
    void GetPartitionedAccelerationStructuresBuildSizesNV(
        DeviceHandle device,
        Ref<PartitionedAccelerationStructureInstancesInputNV> pInfo,
        Ref<AccelerationStructureBuildSizesInfoKHR> pSizeInfo
    );

    [NativeName("vkGetPastPresentationTimingEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPastPresentationTimingEXT")]
    Result GetPastPresentationTimingEXT(
        DeviceHandle device,
        PastPresentationTimingInfoEXT* pPastPresentationTimingInfo,
        PastPresentationTimingPropertiesEXT* pPastPresentationTimingProperties
    );

    [NativeName("vkGetPastPresentationTimingEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPastPresentationTimingEXT")]
    Result GetPastPresentationTimingEXT(
        DeviceHandle device,
        Ref<PastPresentationTimingInfoEXT> pPastPresentationTimingInfo,
        Ref<PastPresentationTimingPropertiesEXT> pPastPresentationTimingProperties
    );

    [NativeName("vkGetPastPresentationTimingGOOGLE")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPastPresentationTimingGOOGLE")]
    Result GetPastPresentationTimingGOOGLE(
        DeviceHandle device,
        SwapchainHandleKHR swapchain,
        uint* pPresentationTimingCount,
        PastPresentationTimingGOOGLE* pPresentationTimings
    );

    [NativeName("vkGetPastPresentationTimingGOOGLE")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPastPresentationTimingGOOGLE")]
    Result GetPastPresentationTimingGOOGLE(
        DeviceHandle device,
        SwapchainHandleKHR swapchain,
        Ref<uint> pPresentationTimingCount,
        Ref<PastPresentationTimingGOOGLE> pPresentationTimings
    );

    [NativeName("vkGetPerformanceParameterINTEL")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPerformanceParameterINTEL")]
    Result GetPerformanceParameterINTEL(
        DeviceHandle device,
        PerformanceParameterTypeINTEL parameter,
        PerformanceValueINTEL* pValue
    );

    [NativeName("vkGetPerformanceParameterINTEL")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPerformanceParameterINTEL")]
    Result GetPerformanceParameterINTEL(
        DeviceHandle device,
        PerformanceParameterTypeINTEL parameter,
        Ref<PerformanceValueINTEL> pValue
    );

    [NativeName("vkGetPhysicalDeviceCalibrateableTimeDomainsEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceCalibrateableTimeDomainsEXT")]
    Result GetPhysicalDeviceCalibrateableTimeDomainsEXT(
        PhysicalDeviceHandle physicalDevice,
        uint* pTimeDomainCount,
        TimeDomainKHR* pTimeDomains
    );

    [NativeName("vkGetPhysicalDeviceCalibrateableTimeDomainsEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceCalibrateableTimeDomainsEXT")]
    Result GetPhysicalDeviceCalibrateableTimeDomainsEXT(
        PhysicalDeviceHandle physicalDevice,
        Ref<uint> pTimeDomainCount,
        Ref<TimeDomainKHR> pTimeDomains
    );

    [NativeName("vkGetPhysicalDeviceCalibrateableTimeDomainsKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceCalibrateableTimeDomainsKHR")]
    Result GetPhysicalDeviceCalibrateableTimeDomainsKHR(
        PhysicalDeviceHandle physicalDevice,
        uint* pTimeDomainCount,
        TimeDomainKHR* pTimeDomains
    );

    [NativeName("vkGetPhysicalDeviceCalibrateableTimeDomainsKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceCalibrateableTimeDomainsKHR")]
    Result GetPhysicalDeviceCalibrateableTimeDomainsKHR(
        PhysicalDeviceHandle physicalDevice,
        Ref<uint> pTimeDomainCount,
        Ref<TimeDomainKHR> pTimeDomains
    );

    [NativeName("vkGetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV")]
    [NativeFunction(
        "vulkan",
        EntryPoint = "vkGetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV"
    )]
    Result GetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV(
        PhysicalDeviceHandle physicalDevice,
        uint* pPropertyCount,
        CooperativeMatrixFlexibleDimensionsPropertiesNV* pProperties
    );

    [NativeName("vkGetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV")]
    [NativeFunction(
        "vulkan",
        EntryPoint = "vkGetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV"
    )]
    Result GetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV(
        PhysicalDeviceHandle physicalDevice,
        Ref<uint> pPropertyCount,
        Ref<CooperativeMatrixFlexibleDimensionsPropertiesNV> pProperties
    );

    [NativeName("vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR")]
    Result GetPhysicalDeviceCooperativeMatrixPropertiesKHR(
        PhysicalDeviceHandle physicalDevice,
        uint* pPropertyCount,
        CooperativeMatrixPropertiesKHR* pProperties
    );

    [NativeName("vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR")]
    Result GetPhysicalDeviceCooperativeMatrixPropertiesKHR(
        PhysicalDeviceHandle physicalDevice,
        Ref<uint> pPropertyCount,
        Ref<CooperativeMatrixPropertiesKHR> pProperties
    );

    [NativeName("vkGetPhysicalDeviceCooperativeMatrixPropertiesNV")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceCooperativeMatrixPropertiesNV")]
    Result GetPhysicalDeviceCooperativeMatrixPropertiesNV(
        PhysicalDeviceHandle physicalDevice,
        uint* pPropertyCount,
        CooperativeMatrixPropertiesNV* pProperties
    );

    [NativeName("vkGetPhysicalDeviceCooperativeMatrixPropertiesNV")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceCooperativeMatrixPropertiesNV")]
    Result GetPhysicalDeviceCooperativeMatrixPropertiesNV(
        PhysicalDeviceHandle physicalDevice,
        Ref<uint> pPropertyCount,
        Ref<CooperativeMatrixPropertiesNV> pProperties
    );

    [NativeName("vkGetPhysicalDeviceCooperativeVectorPropertiesNV")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceCooperativeVectorPropertiesNV")]
    Result GetPhysicalDeviceCooperativeVectorPropertiesNV(
        PhysicalDeviceHandle physicalDevice,
        uint* pPropertyCount,
        CooperativeVectorPropertiesNV* pProperties
    );

    [NativeName("vkGetPhysicalDeviceCooperativeVectorPropertiesNV")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceCooperativeVectorPropertiesNV")]
    Result GetPhysicalDeviceCooperativeVectorPropertiesNV(
        PhysicalDeviceHandle physicalDevice,
        Ref<uint> pPropertyCount,
        Ref<CooperativeVectorPropertiesNV> pProperties
    );

    [NativeName("vkGetPhysicalDeviceDescriptorSizeEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceDescriptorSizeEXT")]
    ulong GetPhysicalDeviceDescriptorSizeEXT(
        PhysicalDeviceHandle physicalDevice,
        DescriptorType descriptorType
    );

    [NativeName("vkGetPhysicalDeviceDisplayPlaneProperties2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceDisplayPlaneProperties2KHR")]
    Result GetPhysicalDeviceDisplayPlaneProperties2KHR(
        PhysicalDeviceHandle physicalDevice,
        uint* pPropertyCount,
        DisplayPlaneProperties2KHR* pProperties
    );

    [NativeName("vkGetPhysicalDeviceDisplayPlaneProperties2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceDisplayPlaneProperties2KHR")]
    Result GetPhysicalDeviceDisplayPlaneProperties2KHR(
        PhysicalDeviceHandle physicalDevice,
        Ref<uint> pPropertyCount,
        Ref<DisplayPlaneProperties2KHR> pProperties
    );

    [NativeName("vkGetPhysicalDeviceDisplayPlanePropertiesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceDisplayPlanePropertiesKHR")]
    Result GetPhysicalDeviceDisplayPlanePropertiesKHR(
        PhysicalDeviceHandle physicalDevice,
        uint* pPropertyCount,
        DisplayPlanePropertiesKHR* pProperties
    );

    [NativeName("vkGetPhysicalDeviceDisplayPlanePropertiesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceDisplayPlanePropertiesKHR")]
    Result GetPhysicalDeviceDisplayPlanePropertiesKHR(
        PhysicalDeviceHandle physicalDevice,
        Ref<uint> pPropertyCount,
        Ref<DisplayPlanePropertiesKHR> pProperties
    );

    [NativeName("vkGetPhysicalDeviceDisplayProperties2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceDisplayProperties2KHR")]
    Result GetPhysicalDeviceDisplayProperties2KHR(
        PhysicalDeviceHandle physicalDevice,
        uint* pPropertyCount,
        DisplayProperties2KHR* pProperties
    );

    [NativeName("vkGetPhysicalDeviceDisplayProperties2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceDisplayProperties2KHR")]
    Result GetPhysicalDeviceDisplayProperties2KHR(
        PhysicalDeviceHandle physicalDevice,
        Ref<uint> pPropertyCount,
        Ref<DisplayProperties2KHR> pProperties
    );

    [NativeName("vkGetPhysicalDeviceDisplayPropertiesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceDisplayPropertiesKHR")]
    Result GetPhysicalDeviceDisplayPropertiesKHR(
        PhysicalDeviceHandle physicalDevice,
        uint* pPropertyCount,
        DisplayPropertiesKHR* pProperties
    );

    [NativeName("vkGetPhysicalDeviceDisplayPropertiesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceDisplayPropertiesKHR")]
    Result GetPhysicalDeviceDisplayPropertiesKHR(
        PhysicalDeviceHandle physicalDevice,
        Ref<uint> pPropertyCount,
        Ref<DisplayPropertiesKHR> pProperties
    );

    [NativeName("vkGetPhysicalDeviceExternalBufferProperties")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalBufferProperties")]
    void GetPhysicalDeviceExternalBufferProperties(
        PhysicalDeviceHandle physicalDevice,
        PhysicalDeviceExternalBufferInfo* pExternalBufferInfo,
        ExternalBufferProperties* pExternalBufferProperties
    );

    [NativeName("vkGetPhysicalDeviceExternalBufferProperties")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalBufferProperties")]
    void GetPhysicalDeviceExternalBufferProperties(
        PhysicalDeviceHandle physicalDevice,
        Ref<PhysicalDeviceExternalBufferInfo> pExternalBufferInfo,
        Ref<ExternalBufferProperties> pExternalBufferProperties
    );

    [NativeName("vkGetPhysicalDeviceExternalBufferPropertiesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalBufferPropertiesKHR")]
    void GetPhysicalDeviceExternalBufferPropertiesKHR(
        PhysicalDeviceHandle physicalDevice,
        PhysicalDeviceExternalBufferInfo* pExternalBufferInfo,
        ExternalBufferProperties* pExternalBufferProperties
    );

    [NativeName("vkGetPhysicalDeviceExternalBufferPropertiesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalBufferPropertiesKHR")]
    void GetPhysicalDeviceExternalBufferPropertiesKHR(
        PhysicalDeviceHandle physicalDevice,
        Ref<PhysicalDeviceExternalBufferInfo> pExternalBufferInfo,
        Ref<ExternalBufferProperties> pExternalBufferProperties
    );

    [NativeName("vkGetPhysicalDeviceExternalFenceProperties")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalFenceProperties")]
    void GetPhysicalDeviceExternalFenceProperties(
        PhysicalDeviceHandle physicalDevice,
        PhysicalDeviceExternalFenceInfo* pExternalFenceInfo,
        ExternalFenceProperties* pExternalFenceProperties
    );

    [NativeName("vkGetPhysicalDeviceExternalFenceProperties")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalFenceProperties")]
    void GetPhysicalDeviceExternalFenceProperties(
        PhysicalDeviceHandle physicalDevice,
        Ref<PhysicalDeviceExternalFenceInfo> pExternalFenceInfo,
        Ref<ExternalFenceProperties> pExternalFenceProperties
    );

    [NativeName("vkGetPhysicalDeviceExternalFencePropertiesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalFencePropertiesKHR")]
    void GetPhysicalDeviceExternalFencePropertiesKHR(
        PhysicalDeviceHandle physicalDevice,
        PhysicalDeviceExternalFenceInfo* pExternalFenceInfo,
        ExternalFenceProperties* pExternalFenceProperties
    );

    [NativeName("vkGetPhysicalDeviceExternalFencePropertiesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalFencePropertiesKHR")]
    void GetPhysicalDeviceExternalFencePropertiesKHR(
        PhysicalDeviceHandle physicalDevice,
        Ref<PhysicalDeviceExternalFenceInfo> pExternalFenceInfo,
        Ref<ExternalFenceProperties> pExternalFenceProperties
    );

    [NativeName("vkGetPhysicalDeviceExternalImageFormatPropertiesNV")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalImageFormatPropertiesNV")]
    Result GetPhysicalDeviceExternalImageFormatPropertiesNV(
        PhysicalDeviceHandle physicalDevice,
        Format format,
        ImageType type,
        ImageTiling tiling,
        ImageUsageFlags usage,
        ImageCreateFlags flags,
        ExternalMemoryHandleTypeFlagsNV externalHandleType,
        ExternalImageFormatPropertiesNV* pExternalImageFormatProperties
    );

    [NativeName("vkGetPhysicalDeviceExternalImageFormatPropertiesNV")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalImageFormatPropertiesNV")]
    Result GetPhysicalDeviceExternalImageFormatPropertiesNV(
        PhysicalDeviceHandle physicalDevice,
        Format format,
        ImageType type,
        ImageTiling tiling,
        ImageUsageFlags usage,
        ImageCreateFlags flags,
        ExternalMemoryHandleTypeFlagsNV externalHandleType,
        Ref<ExternalImageFormatPropertiesNV> pExternalImageFormatProperties
    );

    [NativeName("vkGetPhysicalDeviceExternalSemaphoreProperties")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalSemaphoreProperties")]
    void GetPhysicalDeviceExternalSemaphoreProperties(
        PhysicalDeviceHandle physicalDevice,
        PhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo,
        ExternalSemaphoreProperties* pExternalSemaphoreProperties
    );

    [NativeName("vkGetPhysicalDeviceExternalSemaphoreProperties")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalSemaphoreProperties")]
    void GetPhysicalDeviceExternalSemaphoreProperties(
        PhysicalDeviceHandle physicalDevice,
        Ref<PhysicalDeviceExternalSemaphoreInfo> pExternalSemaphoreInfo,
        Ref<ExternalSemaphoreProperties> pExternalSemaphoreProperties
    );

    [NativeName("vkGetPhysicalDeviceExternalSemaphorePropertiesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalSemaphorePropertiesKHR")]
    void GetPhysicalDeviceExternalSemaphorePropertiesKHR(
        PhysicalDeviceHandle physicalDevice,
        PhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo,
        ExternalSemaphoreProperties* pExternalSemaphoreProperties
    );

    [NativeName("vkGetPhysicalDeviceExternalSemaphorePropertiesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalSemaphorePropertiesKHR")]
    void GetPhysicalDeviceExternalSemaphorePropertiesKHR(
        PhysicalDeviceHandle physicalDevice,
        Ref<PhysicalDeviceExternalSemaphoreInfo> pExternalSemaphoreInfo,
        Ref<ExternalSemaphoreProperties> pExternalSemaphoreProperties
    );

    [NativeName("vkGetPhysicalDeviceExternalTensorPropertiesARM")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalTensorPropertiesARM")]
    void GetPhysicalDeviceExternalTensorPropertiesARM(
        PhysicalDeviceHandle physicalDevice,
        PhysicalDeviceExternalTensorInfoARM* pExternalTensorInfo,
        ExternalTensorPropertiesARM* pExternalTensorProperties
    );

    [NativeName("vkGetPhysicalDeviceExternalTensorPropertiesARM")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalTensorPropertiesARM")]
    void GetPhysicalDeviceExternalTensorPropertiesARM(
        PhysicalDeviceHandle physicalDevice,
        Ref<PhysicalDeviceExternalTensorInfoARM> pExternalTensorInfo,
        Ref<ExternalTensorPropertiesARM> pExternalTensorProperties
    );

    [NativeName("vkGetPhysicalDeviceFeatures")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceFeatures")]
    void GetPhysicalDeviceFeatures(
        PhysicalDeviceHandle physicalDevice,
        PhysicalDeviceFeatures* pFeatures
    );

    [NativeName("vkGetPhysicalDeviceFeatures")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceFeatures")]
    void GetPhysicalDeviceFeatures(
        PhysicalDeviceHandle physicalDevice,
        Ref<PhysicalDeviceFeatures> pFeatures
    );

    [NativeName("vkGetPhysicalDeviceFeatures2")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceFeatures2")]
    void GetPhysicalDeviceFeatures2(
        PhysicalDeviceHandle physicalDevice,
        PhysicalDeviceFeatures2* pFeatures
    );

    [NativeName("vkGetPhysicalDeviceFeatures2")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceFeatures2")]
    void GetPhysicalDeviceFeatures2(
        PhysicalDeviceHandle physicalDevice,
        Ref<PhysicalDeviceFeatures2> pFeatures
    );

    [NativeName("vkGetPhysicalDeviceFeatures2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceFeatures2KHR")]
    void GetPhysicalDeviceFeatures2KHR(
        PhysicalDeviceHandle physicalDevice,
        PhysicalDeviceFeatures2* pFeatures
    );

    [NativeName("vkGetPhysicalDeviceFeatures2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceFeatures2KHR")]
    void GetPhysicalDeviceFeatures2KHR(
        PhysicalDeviceHandle physicalDevice,
        Ref<PhysicalDeviceFeatures2> pFeatures
    );

    [NativeName("vkGetPhysicalDeviceFormatProperties")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceFormatProperties")]
    void GetPhysicalDeviceFormatProperties(
        PhysicalDeviceHandle physicalDevice,
        Format format,
        FormatProperties* pFormatProperties
    );

    [NativeName("vkGetPhysicalDeviceFormatProperties")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceFormatProperties")]
    void GetPhysicalDeviceFormatProperties(
        PhysicalDeviceHandle physicalDevice,
        Format format,
        Ref<FormatProperties> pFormatProperties
    );

    [NativeName("vkGetPhysicalDeviceFormatProperties2")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceFormatProperties2")]
    void GetPhysicalDeviceFormatProperties2(
        PhysicalDeviceHandle physicalDevice,
        Format format,
        FormatProperties2* pFormatProperties
    );

    [NativeName("vkGetPhysicalDeviceFormatProperties2")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceFormatProperties2")]
    void GetPhysicalDeviceFormatProperties2(
        PhysicalDeviceHandle physicalDevice,
        Format format,
        Ref<FormatProperties2> pFormatProperties
    );

    [NativeName("vkGetPhysicalDeviceFormatProperties2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceFormatProperties2KHR")]
    void GetPhysicalDeviceFormatProperties2KHR(
        PhysicalDeviceHandle physicalDevice,
        Format format,
        FormatProperties2* pFormatProperties
    );

    [NativeName("vkGetPhysicalDeviceFormatProperties2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceFormatProperties2KHR")]
    void GetPhysicalDeviceFormatProperties2KHR(
        PhysicalDeviceHandle physicalDevice,
        Format format,
        Ref<FormatProperties2> pFormatProperties
    );

    [NativeName("vkGetPhysicalDeviceFragmentShadingRatesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceFragmentShadingRatesKHR")]
    Result GetPhysicalDeviceFragmentShadingRatesKHR(
        PhysicalDeviceHandle physicalDevice,
        uint* pFragmentShadingRateCount,
        PhysicalDeviceFragmentShadingRateKHR* pFragmentShadingRates
    );

    [NativeName("vkGetPhysicalDeviceFragmentShadingRatesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceFragmentShadingRatesKHR")]
    Result GetPhysicalDeviceFragmentShadingRatesKHR(
        PhysicalDeviceHandle physicalDevice,
        Ref<uint> pFragmentShadingRateCount,
        Ref<PhysicalDeviceFragmentShadingRateKHR> pFragmentShadingRates
    );

    [NativeName("vkGetPhysicalDeviceImageFormatProperties")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceImageFormatProperties")]
    Result GetPhysicalDeviceImageFormatProperties(
        PhysicalDeviceHandle physicalDevice,
        Format format,
        ImageType type,
        ImageTiling tiling,
        ImageUsageFlags usage,
        ImageCreateFlags flags,
        ImageFormatProperties* pImageFormatProperties
    );

    [NativeName("vkGetPhysicalDeviceImageFormatProperties")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceImageFormatProperties")]
    Result GetPhysicalDeviceImageFormatProperties(
        PhysicalDeviceHandle physicalDevice,
        Format format,
        ImageType type,
        ImageTiling tiling,
        ImageUsageFlags usage,
        ImageCreateFlags flags,
        Ref<ImageFormatProperties> pImageFormatProperties
    );

    [NativeName("vkGetPhysicalDeviceImageFormatProperties2")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2")]
    Result GetPhysicalDeviceImageFormatProperties2(
        PhysicalDeviceHandle physicalDevice,
        PhysicalDeviceImageFormatInfo2* pImageFormatInfo,
        ImageFormatProperties2* pImageFormatProperties
    );

    [NativeName("vkGetPhysicalDeviceImageFormatProperties2")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2")]
    Result GetPhysicalDeviceImageFormatProperties2(
        PhysicalDeviceHandle physicalDevice,
        Ref<PhysicalDeviceImageFormatInfo2> pImageFormatInfo,
        Ref<ImageFormatProperties2> pImageFormatProperties
    );

    [NativeName("vkGetPhysicalDeviceImageFormatProperties2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2KHR")]
    Result GetPhysicalDeviceImageFormatProperties2KHR(
        PhysicalDeviceHandle physicalDevice,
        PhysicalDeviceImageFormatInfo2* pImageFormatInfo,
        ImageFormatProperties2* pImageFormatProperties
    );

    [NativeName("vkGetPhysicalDeviceImageFormatProperties2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2KHR")]
    Result GetPhysicalDeviceImageFormatProperties2KHR(
        PhysicalDeviceHandle physicalDevice,
        Ref<PhysicalDeviceImageFormatInfo2> pImageFormatInfo,
        Ref<ImageFormatProperties2> pImageFormatProperties
    );

    [NativeName("vkGetPhysicalDeviceMemoryProperties")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceMemoryProperties")]
    void GetPhysicalDeviceMemoryProperties(
        PhysicalDeviceHandle physicalDevice,
        PhysicalDeviceMemoryProperties* pMemoryProperties
    );

    [NativeName("vkGetPhysicalDeviceMemoryProperties")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceMemoryProperties")]
    void GetPhysicalDeviceMemoryProperties(
        PhysicalDeviceHandle physicalDevice,
        Ref<PhysicalDeviceMemoryProperties> pMemoryProperties
    );

    [NativeName("vkGetPhysicalDeviceMemoryProperties2")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceMemoryProperties2")]
    void GetPhysicalDeviceMemoryProperties2(
        PhysicalDeviceHandle physicalDevice,
        PhysicalDeviceMemoryProperties2* pMemoryProperties
    );

    [NativeName("vkGetPhysicalDeviceMemoryProperties2")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceMemoryProperties2")]
    void GetPhysicalDeviceMemoryProperties2(
        PhysicalDeviceHandle physicalDevice,
        Ref<PhysicalDeviceMemoryProperties2> pMemoryProperties
    );

    [NativeName("vkGetPhysicalDeviceMemoryProperties2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceMemoryProperties2KHR")]
    void GetPhysicalDeviceMemoryProperties2KHR(
        PhysicalDeviceHandle physicalDevice,
        PhysicalDeviceMemoryProperties2* pMemoryProperties
    );

    [NativeName("vkGetPhysicalDeviceMemoryProperties2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceMemoryProperties2KHR")]
    void GetPhysicalDeviceMemoryProperties2KHR(
        PhysicalDeviceHandle physicalDevice,
        Ref<PhysicalDeviceMemoryProperties2> pMemoryProperties
    );

    [NativeName("vkGetPhysicalDeviceMultisamplePropertiesEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceMultisamplePropertiesEXT")]
    void GetPhysicalDeviceMultisamplePropertiesEXT(
        PhysicalDeviceHandle physicalDevice,
        SampleCountFlags samples,
        MultisamplePropertiesEXT* pMultisampleProperties
    );

    [NativeName("vkGetPhysicalDeviceMultisamplePropertiesEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceMultisamplePropertiesEXT")]
    void GetPhysicalDeviceMultisamplePropertiesEXT(
        PhysicalDeviceHandle physicalDevice,
        SampleCountFlags samples,
        Ref<MultisamplePropertiesEXT> pMultisampleProperties
    );

    [NativeName("vkGetPhysicalDeviceOpticalFlowImageFormatsNV")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceOpticalFlowImageFormatsNV")]
    Result GetPhysicalDeviceOpticalFlowImageFormatsNV(
        PhysicalDeviceHandle physicalDevice,
        OpticalFlowImageFormatInfoNV* pOpticalFlowImageFormatInfo,
        uint* pFormatCount,
        OpticalFlowImageFormatPropertiesNV* pImageFormatProperties
    );

    [NativeName("vkGetPhysicalDeviceOpticalFlowImageFormatsNV")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceOpticalFlowImageFormatsNV")]
    Result GetPhysicalDeviceOpticalFlowImageFormatsNV(
        PhysicalDeviceHandle physicalDevice,
        Ref<OpticalFlowImageFormatInfoNV> pOpticalFlowImageFormatInfo,
        Ref<uint> pFormatCount,
        Ref<OpticalFlowImageFormatPropertiesNV> pImageFormatProperties
    );

    [NativeName("vkGetPhysicalDevicePresentRectanglesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDevicePresentRectanglesKHR")]
    Result GetPhysicalDevicePresentRectanglesKHR(
        PhysicalDeviceHandle physicalDevice,
        SurfaceHandleKHR surface,
        uint* pRectCount,
        Rect2D* pRects
    );

    [NativeName("vkGetPhysicalDevicePresentRectanglesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDevicePresentRectanglesKHR")]
    Result GetPhysicalDevicePresentRectanglesKHR(
        PhysicalDeviceHandle physicalDevice,
        SurfaceHandleKHR surface,
        Ref<uint> pRectCount,
        Ref<Rect2D> pRects
    );

    [NativeName("vkGetPhysicalDeviceProperties")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceProperties")]
    void GetPhysicalDeviceProperties(
        PhysicalDeviceHandle physicalDevice,
        PhysicalDeviceProperties* pProperties
    );

    [NativeName("vkGetPhysicalDeviceProperties")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceProperties")]
    void GetPhysicalDeviceProperties(
        PhysicalDeviceHandle physicalDevice,
        Ref<PhysicalDeviceProperties> pProperties
    );

    [NativeName("vkGetPhysicalDeviceProperties2")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceProperties2")]
    void GetPhysicalDeviceProperties2(
        PhysicalDeviceHandle physicalDevice,
        PhysicalDeviceProperties2* pProperties
    );

    [NativeName("vkGetPhysicalDeviceProperties2")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceProperties2")]
    void GetPhysicalDeviceProperties2(
        PhysicalDeviceHandle physicalDevice,
        Ref<PhysicalDeviceProperties2> pProperties
    );

    [NativeName("vkGetPhysicalDeviceProperties2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceProperties2KHR")]
    void GetPhysicalDeviceProperties2KHR(
        PhysicalDeviceHandle physicalDevice,
        PhysicalDeviceProperties2* pProperties
    );

    [NativeName("vkGetPhysicalDeviceProperties2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceProperties2KHR")]
    void GetPhysicalDeviceProperties2KHR(
        PhysicalDeviceHandle physicalDevice,
        Ref<PhysicalDeviceProperties2> pProperties
    );

    [NativeName("vkGetPhysicalDeviceQueueFamilyDataGraphEngineOperationPropertiesARM")]
    [NativeFunction(
        "vulkan",
        EntryPoint = "vkGetPhysicalDeviceQueueFamilyDataGraphEngineOperationPropertiesARM"
    )]
    Result GetPhysicalDeviceQueueFamilyDataGraphEngineOperationPropertiesARM(
        PhysicalDeviceHandle physicalDevice,
        uint queueFamilyIndex,
        QueueFamilyDataGraphPropertiesARM* pQueueFamilyDataGraphProperties,
        BaseOutStructure* pProperties
    );

    [NativeName("vkGetPhysicalDeviceQueueFamilyDataGraphEngineOperationPropertiesARM")]
    [NativeFunction(
        "vulkan",
        EntryPoint = "vkGetPhysicalDeviceQueueFamilyDataGraphEngineOperationPropertiesARM"
    )]
    Result GetPhysicalDeviceQueueFamilyDataGraphEngineOperationPropertiesARM(
        PhysicalDeviceHandle physicalDevice,
        uint queueFamilyIndex,
        Ref<QueueFamilyDataGraphPropertiesARM> pQueueFamilyDataGraphProperties,
        Ref<BaseOutStructure> pProperties
    );

    [NativeName("vkGetPhysicalDeviceQueueFamilyDataGraphOpticalFlowImageFormatsARM")]
    [NativeFunction(
        "vulkan",
        EntryPoint = "vkGetPhysicalDeviceQueueFamilyDataGraphOpticalFlowImageFormatsARM"
    )]
    Result GetPhysicalDeviceQueueFamilyDataGraphOpticalFlowImageFormatsARM(
        PhysicalDeviceHandle physicalDevice,
        uint queueFamilyIndex,
        QueueFamilyDataGraphPropertiesARM* pQueueFamilyDataGraphProperties,
        DataGraphOpticalFlowImageFormatInfoARM* pOpticalFlowImageFormatInfo,
        uint* pFormatCount,
        DataGraphOpticalFlowImageFormatPropertiesARM* pImageFormatProperties
    );

    [NativeName("vkGetPhysicalDeviceQueueFamilyDataGraphOpticalFlowImageFormatsARM")]
    [NativeFunction(
        "vulkan",
        EntryPoint = "vkGetPhysicalDeviceQueueFamilyDataGraphOpticalFlowImageFormatsARM"
    )]
    Result GetPhysicalDeviceQueueFamilyDataGraphOpticalFlowImageFormatsARM(
        PhysicalDeviceHandle physicalDevice,
        uint queueFamilyIndex,
        Ref<QueueFamilyDataGraphPropertiesARM> pQueueFamilyDataGraphProperties,
        Ref<DataGraphOpticalFlowImageFormatInfoARM> pOpticalFlowImageFormatInfo,
        Ref<uint> pFormatCount,
        Ref<DataGraphOpticalFlowImageFormatPropertiesARM> pImageFormatProperties
    );

    [NativeName("vkGetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM")]
    [NativeFunction(
        "vulkan",
        EntryPoint = "vkGetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM"
    )]
    void GetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM(
        PhysicalDeviceHandle physicalDevice,
        PhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM* pQueueFamilyDataGraphProcessingEngineInfo,
        QueueFamilyDataGraphProcessingEnginePropertiesARM* pQueueFamilyDataGraphProcessingEngineProperties
    );

    [NativeName("vkGetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM")]
    [NativeFunction(
        "vulkan",
        EntryPoint = "vkGetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM"
    )]
    void GetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM(
        PhysicalDeviceHandle physicalDevice,
        Ref<PhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM> pQueueFamilyDataGraphProcessingEngineInfo,
        Ref<QueueFamilyDataGraphProcessingEnginePropertiesARM> pQueueFamilyDataGraphProcessingEngineProperties
    );

    [NativeName("vkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM")]
    Result GetPhysicalDeviceQueueFamilyDataGraphPropertiesARM(
        PhysicalDeviceHandle physicalDevice,
        uint queueFamilyIndex,
        uint* pQueueFamilyDataGraphPropertyCount,
        QueueFamilyDataGraphPropertiesARM* pQueueFamilyDataGraphProperties
    );

    [NativeName("vkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM")]
    Result GetPhysicalDeviceQueueFamilyDataGraphPropertiesARM(
        PhysicalDeviceHandle physicalDevice,
        uint queueFamilyIndex,
        Ref<uint> pQueueFamilyDataGraphPropertyCount,
        Ref<QueueFamilyDataGraphPropertiesARM> pQueueFamilyDataGraphProperties
    );

    [NativeName("vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR")]
    [NativeFunction(
        "vulkan",
        EntryPoint = "vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR"
    )]
    void GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(
        PhysicalDeviceHandle physicalDevice,
        QueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo,
        uint* pNumPasses
    );

    [NativeName("vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR")]
    [NativeFunction(
        "vulkan",
        EntryPoint = "vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR"
    )]
    void GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(
        PhysicalDeviceHandle physicalDevice,
        Ref<QueryPoolPerformanceCreateInfoKHR> pPerformanceQueryCreateInfo,
        Ref<uint> pNumPasses
    );

    [NativeName("vkGetPhysicalDeviceQueueFamilyProperties")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties")]
    void GetPhysicalDeviceQueueFamilyProperties(
        PhysicalDeviceHandle physicalDevice,
        uint* pQueueFamilyPropertyCount,
        QueueFamilyProperties* pQueueFamilyProperties
    );

    [NativeName("vkGetPhysicalDeviceQueueFamilyProperties")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties")]
    void GetPhysicalDeviceQueueFamilyProperties(
        PhysicalDeviceHandle physicalDevice,
        Ref<uint> pQueueFamilyPropertyCount,
        Ref<QueueFamilyProperties> pQueueFamilyProperties
    );

    [NativeName("vkGetPhysicalDeviceQueueFamilyProperties2")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2")]
    void GetPhysicalDeviceQueueFamilyProperties2(
        PhysicalDeviceHandle physicalDevice,
        uint* pQueueFamilyPropertyCount,
        QueueFamilyProperties2* pQueueFamilyProperties
    );

    [NativeName("vkGetPhysicalDeviceQueueFamilyProperties2")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2")]
    void GetPhysicalDeviceQueueFamilyProperties2(
        PhysicalDeviceHandle physicalDevice,
        Ref<uint> pQueueFamilyPropertyCount,
        Ref<QueueFamilyProperties2> pQueueFamilyProperties
    );

    [NativeName("vkGetPhysicalDeviceQueueFamilyProperties2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2KHR")]
    void GetPhysicalDeviceQueueFamilyProperties2KHR(
        PhysicalDeviceHandle physicalDevice,
        uint* pQueueFamilyPropertyCount,
        QueueFamilyProperties2* pQueueFamilyProperties
    );

    [NativeName("vkGetPhysicalDeviceQueueFamilyProperties2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2KHR")]
    void GetPhysicalDeviceQueueFamilyProperties2KHR(
        PhysicalDeviceHandle physicalDevice,
        Ref<uint> pQueueFamilyPropertyCount,
        Ref<QueueFamilyProperties2> pQueueFamilyProperties
    );

    [NativeName("vkGetPhysicalDeviceSparseImageFormatProperties")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties")]
    void GetPhysicalDeviceSparseImageFormatProperties(
        PhysicalDeviceHandle physicalDevice,
        Format format,
        ImageType type,
        SampleCountFlags samples,
        ImageUsageFlags usage,
        ImageTiling tiling,
        uint* pPropertyCount,
        SparseImageFormatProperties* pProperties
    );

    [NativeName("vkGetPhysicalDeviceSparseImageFormatProperties")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties")]
    void GetPhysicalDeviceSparseImageFormatProperties(
        PhysicalDeviceHandle physicalDevice,
        Format format,
        ImageType type,
        SampleCountFlags samples,
        ImageUsageFlags usage,
        ImageTiling tiling,
        Ref<uint> pPropertyCount,
        Ref<SparseImageFormatProperties> pProperties
    );

    [NativeName("vkGetPhysicalDeviceSparseImageFormatProperties2")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2")]
    void GetPhysicalDeviceSparseImageFormatProperties2(
        PhysicalDeviceHandle physicalDevice,
        PhysicalDeviceSparseImageFormatInfo2* pFormatInfo,
        uint* pPropertyCount,
        SparseImageFormatProperties2* pProperties
    );

    [NativeName("vkGetPhysicalDeviceSparseImageFormatProperties2")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2")]
    void GetPhysicalDeviceSparseImageFormatProperties2(
        PhysicalDeviceHandle physicalDevice,
        Ref<PhysicalDeviceSparseImageFormatInfo2> pFormatInfo,
        Ref<uint> pPropertyCount,
        Ref<SparseImageFormatProperties2> pProperties
    );

    [NativeName("vkGetPhysicalDeviceSparseImageFormatProperties2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2KHR")]
    void GetPhysicalDeviceSparseImageFormatProperties2KHR(
        PhysicalDeviceHandle physicalDevice,
        PhysicalDeviceSparseImageFormatInfo2* pFormatInfo,
        uint* pPropertyCount,
        SparseImageFormatProperties2* pProperties
    );

    [NativeName("vkGetPhysicalDeviceSparseImageFormatProperties2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2KHR")]
    void GetPhysicalDeviceSparseImageFormatProperties2KHR(
        PhysicalDeviceHandle physicalDevice,
        Ref<PhysicalDeviceSparseImageFormatInfo2> pFormatInfo,
        Ref<uint> pPropertyCount,
        Ref<SparseImageFormatProperties2> pProperties
    );

    [NativeName("vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV")]
    [NativeFunction(
        "vulkan",
        EntryPoint = "vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV"
    )]
    Result GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(
        PhysicalDeviceHandle physicalDevice,
        uint* pCombinationCount,
        FramebufferMixedSamplesCombinationNV* pCombinations
    );

    [NativeName("vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV")]
    [NativeFunction(
        "vulkan",
        EntryPoint = "vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV"
    )]
    Result GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(
        PhysicalDeviceHandle physicalDevice,
        Ref<uint> pCombinationCount,
        Ref<FramebufferMixedSamplesCombinationNV> pCombinations
    );

    [NativeName("vkGetPhysicalDeviceSurfaceCapabilities2EXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilities2EXT")]
    Result GetPhysicalDeviceSurfaceCapabilities2EXT(
        PhysicalDeviceHandle physicalDevice,
        SurfaceHandleKHR surface,
        SurfaceCapabilities2EXT* pSurfaceCapabilities
    );

    [NativeName("vkGetPhysicalDeviceSurfaceCapabilities2EXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilities2EXT")]
    Result GetPhysicalDeviceSurfaceCapabilities2EXT(
        PhysicalDeviceHandle physicalDevice,
        SurfaceHandleKHR surface,
        Ref<SurfaceCapabilities2EXT> pSurfaceCapabilities
    );

    [NativeName("vkGetPhysicalDeviceSurfaceCapabilities2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilities2KHR")]
    Result GetPhysicalDeviceSurfaceCapabilities2KHR(
        PhysicalDeviceHandle physicalDevice,
        PhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo,
        SurfaceCapabilities2KHR* pSurfaceCapabilities
    );

    [NativeName("vkGetPhysicalDeviceSurfaceCapabilities2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilities2KHR")]
    Result GetPhysicalDeviceSurfaceCapabilities2KHR(
        PhysicalDeviceHandle physicalDevice,
        Ref<PhysicalDeviceSurfaceInfo2KHR> pSurfaceInfo,
        Ref<SurfaceCapabilities2KHR> pSurfaceCapabilities
    );

    [NativeName("vkGetPhysicalDeviceSurfaceCapabilitiesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilitiesKHR")]
    Result GetPhysicalDeviceSurfaceCapabilitiesKHR(
        PhysicalDeviceHandle physicalDevice,
        SurfaceHandleKHR surface,
        SurfaceCapabilitiesKHR* pSurfaceCapabilities
    );

    [NativeName("vkGetPhysicalDeviceSurfaceCapabilitiesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilitiesKHR")]
    Result GetPhysicalDeviceSurfaceCapabilitiesKHR(
        PhysicalDeviceHandle physicalDevice,
        SurfaceHandleKHR surface,
        Ref<SurfaceCapabilitiesKHR> pSurfaceCapabilities
    );

    [NativeName("vkGetPhysicalDeviceSurfaceFormats2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfaceFormats2KHR")]
    Result GetPhysicalDeviceSurfaceFormats2KHR(
        PhysicalDeviceHandle physicalDevice,
        PhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo,
        uint* pSurfaceFormatCount,
        SurfaceFormat2KHR* pSurfaceFormats
    );

    [NativeName("vkGetPhysicalDeviceSurfaceFormats2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfaceFormats2KHR")]
    Result GetPhysicalDeviceSurfaceFormats2KHR(
        PhysicalDeviceHandle physicalDevice,
        Ref<PhysicalDeviceSurfaceInfo2KHR> pSurfaceInfo,
        Ref<uint> pSurfaceFormatCount,
        Ref<SurfaceFormat2KHR> pSurfaceFormats
    );

    [NativeName("vkGetPhysicalDeviceSurfaceFormatsKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfaceFormatsKHR")]
    Result GetPhysicalDeviceSurfaceFormatsKHR(
        PhysicalDeviceHandle physicalDevice,
        SurfaceHandleKHR surface,
        uint* pSurfaceFormatCount,
        SurfaceFormatKHR* pSurfaceFormats
    );

    [NativeName("vkGetPhysicalDeviceSurfaceFormatsKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfaceFormatsKHR")]
    Result GetPhysicalDeviceSurfaceFormatsKHR(
        PhysicalDeviceHandle physicalDevice,
        SurfaceHandleKHR surface,
        Ref<uint> pSurfaceFormatCount,
        Ref<SurfaceFormatKHR> pSurfaceFormats
    );

    [NativeName("vkGetPhysicalDeviceSurfacePresentModesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfacePresentModesKHR")]
    Result GetPhysicalDeviceSurfacePresentModesKHR(
        PhysicalDeviceHandle physicalDevice,
        SurfaceHandleKHR surface,
        uint* pPresentModeCount,
        PresentModeKHR* pPresentModes
    );

    [NativeName("vkGetPhysicalDeviceSurfacePresentModesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfacePresentModesKHR")]
    Result GetPhysicalDeviceSurfacePresentModesKHR(
        PhysicalDeviceHandle physicalDevice,
        SurfaceHandleKHR surface,
        Ref<uint> pPresentModeCount,
        Ref<PresentModeKHR> pPresentModes
    );

    [NativeName("vkGetPhysicalDeviceSurfaceSupportKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfaceSupportKHR")]
    Result GetPhysicalDeviceSurfaceSupportKHR(
        PhysicalDeviceHandle physicalDevice,
        uint queueFamilyIndex,
        SurfaceHandleKHR surface,
        uint* pSupported
    );

    [NativeName("vkGetPhysicalDeviceSurfaceSupportKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfaceSupportKHR")]
    Result GetPhysicalDeviceSurfaceSupportKHR(
        PhysicalDeviceHandle physicalDevice,
        uint queueFamilyIndex,
        SurfaceHandleKHR surface,
        Ref<uint> pSupported
    );

    [NativeName("vkGetPhysicalDeviceToolProperties")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceToolProperties")]
    Result GetPhysicalDeviceToolProperties(
        PhysicalDeviceHandle physicalDevice,
        uint* pToolCount,
        PhysicalDeviceToolProperties* pToolProperties
    );

    [NativeName("vkGetPhysicalDeviceToolProperties")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceToolProperties")]
    Result GetPhysicalDeviceToolProperties(
        PhysicalDeviceHandle physicalDevice,
        Ref<uint> pToolCount,
        Ref<PhysicalDeviceToolProperties> pToolProperties
    );

    [NativeName("vkGetPhysicalDeviceToolPropertiesEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceToolPropertiesEXT")]
    Result GetPhysicalDeviceToolPropertiesEXT(
        PhysicalDeviceHandle physicalDevice,
        uint* pToolCount,
        PhysicalDeviceToolProperties* pToolProperties
    );

    [NativeName("vkGetPhysicalDeviceToolPropertiesEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceToolPropertiesEXT")]
    Result GetPhysicalDeviceToolPropertiesEXT(
        PhysicalDeviceHandle physicalDevice,
        Ref<uint> pToolCount,
        Ref<PhysicalDeviceToolProperties> pToolProperties
    );

    [NativeName("vkGetPhysicalDeviceVideoCapabilitiesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceVideoCapabilitiesKHR")]
    Result GetPhysicalDeviceVideoCapabilitiesKHR(
        PhysicalDeviceHandle physicalDevice,
        VideoProfileInfoKHR* pVideoProfile,
        VideoCapabilitiesKHR* pCapabilities
    );

    [NativeName("vkGetPhysicalDeviceVideoCapabilitiesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceVideoCapabilitiesKHR")]
    Result GetPhysicalDeviceVideoCapabilitiesKHR(
        PhysicalDeviceHandle physicalDevice,
        Ref<VideoProfileInfoKHR> pVideoProfile,
        Ref<VideoCapabilitiesKHR> pCapabilities
    );

    [NativeName("vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR")]
    [NativeFunction(
        "vulkan",
        EntryPoint = "vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR"
    )]
    Result GetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR(
        PhysicalDeviceHandle physicalDevice,
        PhysicalDeviceVideoEncodeQualityLevelInfoKHR* pQualityLevelInfo,
        VideoEncodeQualityLevelPropertiesKHR* pQualityLevelProperties
    );

    [NativeName("vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR")]
    [NativeFunction(
        "vulkan",
        EntryPoint = "vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR"
    )]
    Result GetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR(
        PhysicalDeviceHandle physicalDevice,
        Ref<PhysicalDeviceVideoEncodeQualityLevelInfoKHR> pQualityLevelInfo,
        Ref<VideoEncodeQualityLevelPropertiesKHR> pQualityLevelProperties
    );

    [NativeName("vkGetPhysicalDeviceVideoFormatPropertiesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceVideoFormatPropertiesKHR")]
    Result GetPhysicalDeviceVideoFormatPropertiesKHR(
        PhysicalDeviceHandle physicalDevice,
        PhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfo,
        uint* pVideoFormatPropertyCount,
        VideoFormatPropertiesKHR* pVideoFormatProperties
    );

    [NativeName("vkGetPhysicalDeviceVideoFormatPropertiesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPhysicalDeviceVideoFormatPropertiesKHR")]
    Result GetPhysicalDeviceVideoFormatPropertiesKHR(
        PhysicalDeviceHandle physicalDevice,
        Ref<PhysicalDeviceVideoFormatInfoKHR> pVideoFormatInfo,
        Ref<uint> pVideoFormatPropertyCount,
        Ref<VideoFormatPropertiesKHR> pVideoFormatProperties
    );

    [NativeName("vkGetPipelineBinaryDataKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPipelineBinaryDataKHR")]
    Result GetPipelineBinaryDataKHR(
        DeviceHandle device,
        PipelineBinaryDataInfoKHR* pInfo,
        PipelineBinaryKeyKHR* pPipelineBinaryKey,
        nuint* pPipelineBinaryDataSize,
        void* pPipelineBinaryData
    );

    [NativeName("vkGetPipelineBinaryDataKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPipelineBinaryDataKHR")]
    Result GetPipelineBinaryDataKHR(
        DeviceHandle device,
        Ref<PipelineBinaryDataInfoKHR> pInfo,
        Ref<PipelineBinaryKeyKHR> pPipelineBinaryKey,
        Ref<nuint> pPipelineBinaryDataSize,
        Ref pPipelineBinaryData
    );

    [NativeName("vkGetPipelineCacheData")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPipelineCacheData")]
    Result GetPipelineCacheData(
        DeviceHandle device,
        PipelineCacheHandle pipelineCache,
        nuint* pDataSize,
        void* pData
    );

    [NativeName("vkGetPipelineCacheData")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPipelineCacheData")]
    Result GetPipelineCacheData(
        DeviceHandle device,
        PipelineCacheHandle pipelineCache,
        Ref<nuint> pDataSize,
        Ref pData
    );

    [NativeName("vkGetPipelineExecutableInternalRepresentationsKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPipelineExecutableInternalRepresentationsKHR")]
    Result GetPipelineExecutableInternalRepresentationsKHR(
        DeviceHandle device,
        PipelineExecutableInfoKHR* pExecutableInfo,
        uint* pInternalRepresentationCount,
        PipelineExecutableInternalRepresentationKHR* pInternalRepresentations
    );

    [NativeName("vkGetPipelineExecutableInternalRepresentationsKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPipelineExecutableInternalRepresentationsKHR")]
    Result GetPipelineExecutableInternalRepresentationsKHR(
        DeviceHandle device,
        Ref<PipelineExecutableInfoKHR> pExecutableInfo,
        Ref<uint> pInternalRepresentationCount,
        Ref<PipelineExecutableInternalRepresentationKHR> pInternalRepresentations
    );

    [NativeName("vkGetPipelineExecutablePropertiesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPipelineExecutablePropertiesKHR")]
    Result GetPipelineExecutablePropertiesKHR(
        DeviceHandle device,
        PipelineInfoKHR* pPipelineInfo,
        uint* pExecutableCount,
        PipelineExecutablePropertiesKHR* pProperties
    );

    [NativeName("vkGetPipelineExecutablePropertiesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPipelineExecutablePropertiesKHR")]
    Result GetPipelineExecutablePropertiesKHR(
        DeviceHandle device,
        Ref<PipelineInfoKHR> pPipelineInfo,
        Ref<uint> pExecutableCount,
        Ref<PipelineExecutablePropertiesKHR> pProperties
    );

    [NativeName("vkGetPipelineExecutableStatisticsKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPipelineExecutableStatisticsKHR")]
    Result GetPipelineExecutableStatisticsKHR(
        DeviceHandle device,
        PipelineExecutableInfoKHR* pExecutableInfo,
        uint* pStatisticCount,
        PipelineExecutableStatisticKHR* pStatistics
    );

    [NativeName("vkGetPipelineExecutableStatisticsKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPipelineExecutableStatisticsKHR")]
    Result GetPipelineExecutableStatisticsKHR(
        DeviceHandle device,
        Ref<PipelineExecutableInfoKHR> pExecutableInfo,
        Ref<uint> pStatisticCount,
        Ref<PipelineExecutableStatisticKHR> pStatistics
    );

    [NativeName("vkGetPipelineIndirectDeviceAddressNV")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPipelineIndirectDeviceAddressNV")]
    ulong GetPipelineIndirectDeviceAddressNV(
        DeviceHandle device,
        PipelineIndirectDeviceAddressInfoNV* pInfo
    );

    [NativeName("vkGetPipelineIndirectDeviceAddressNV")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPipelineIndirectDeviceAddressNV")]
    ulong GetPipelineIndirectDeviceAddressNV(
        DeviceHandle device,
        Ref<PipelineIndirectDeviceAddressInfoNV> pInfo
    );

    [NativeName("vkGetPipelineIndirectMemoryRequirementsNV")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPipelineIndirectMemoryRequirementsNV")]
    void GetPipelineIndirectMemoryRequirementsNV(
        DeviceHandle device,
        ComputePipelineCreateInfo* pCreateInfo,
        MemoryRequirements2* pMemoryRequirements
    );

    [NativeName("vkGetPipelineIndirectMemoryRequirementsNV")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPipelineIndirectMemoryRequirementsNV")]
    void GetPipelineIndirectMemoryRequirementsNV(
        DeviceHandle device,
        Ref<ComputePipelineCreateInfo> pCreateInfo,
        Ref<MemoryRequirements2> pMemoryRequirements
    );

    [NativeName("vkGetPipelineKeyKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPipelineKeyKHR")]
    Result GetPipelineKeyKHR(
        DeviceHandle device,
        PipelineCreateInfoKHR* pPipelineCreateInfo,
        PipelineBinaryKeyKHR* pPipelineKey
    );

    [NativeName("vkGetPipelineKeyKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPipelineKeyKHR")]
    Result GetPipelineKeyKHR(
        DeviceHandle device,
        Ref<PipelineCreateInfoKHR> pPipelineCreateInfo,
        Ref<PipelineBinaryKeyKHR> pPipelineKey
    );

    [NativeName("vkGetPipelinePropertiesEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPipelinePropertiesEXT")]
    Result GetPipelinePropertiesEXT(
        DeviceHandle device,
        PipelineInfoKHR* pPipelineInfo,
        BaseOutStructure* pPipelineProperties
    );

    [NativeName("vkGetPipelinePropertiesEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPipelinePropertiesEXT")]
    Result GetPipelinePropertiesEXT(
        DeviceHandle device,
        Ref<PipelineInfoKHR> pPipelineInfo,
        Ref<BaseOutStructure> pPipelineProperties
    );

    [NativeName("vkGetPrivateData")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPrivateData")]
    void GetPrivateData(
        DeviceHandle device,
        ObjectType objectType,
        ulong objectHandle,
        PrivateDataSlotHandle privateDataSlot,
        ulong* pData
    );

    [NativeName("vkGetPrivateData")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPrivateData")]
    void GetPrivateData(
        DeviceHandle device,
        ObjectType objectType,
        ulong objectHandle,
        PrivateDataSlotHandle privateDataSlot,
        Ref<ulong> pData
    );

    [NativeName("vkGetPrivateDataEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPrivateDataEXT")]
    void GetPrivateDataEXT(
        DeviceHandle device,
        ObjectType objectType,
        ulong objectHandle,
        PrivateDataSlotHandle privateDataSlot,
        ulong* pData
    );

    [NativeName("vkGetPrivateDataEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetPrivateDataEXT")]
    void GetPrivateDataEXT(
        DeviceHandle device,
        ObjectType objectType,
        ulong objectHandle,
        PrivateDataSlotHandle privateDataSlot,
        Ref<ulong> pData
    );

    [NativeName("vkGetQueryPoolResults")]
    [NativeFunction("vulkan", EntryPoint = "vkGetQueryPoolResults")]
    Result GetQueryPoolResults(
        DeviceHandle device,
        QueryPoolHandle queryPool,
        uint firstQuery,
        uint queryCount,
        nuint dataSize,
        void* pData,
        ulong stride,
        QueryResultFlags flags
    );

    [NativeName("vkGetQueryPoolResults")]
    [NativeFunction("vulkan", EntryPoint = "vkGetQueryPoolResults")]
    Result GetQueryPoolResults(
        DeviceHandle device,
        QueryPoolHandle queryPool,
        uint firstQuery,
        uint queryCount,
        nuint dataSize,
        Ref pData,
        ulong stride,
        QueryResultFlags flags
    );

    [NativeName("vkGetQueueCheckpointData2NV")]
    [NativeFunction("vulkan", EntryPoint = "vkGetQueueCheckpointData2NV")]
    void GetQueueCheckpointData2NV(
        QueueHandle queue,
        uint* pCheckpointDataCount,
        CheckpointData2NV* pCheckpointData
    );

    [NativeName("vkGetQueueCheckpointData2NV")]
    [NativeFunction("vulkan", EntryPoint = "vkGetQueueCheckpointData2NV")]
    void GetQueueCheckpointData2NV(
        QueueHandle queue,
        Ref<uint> pCheckpointDataCount,
        Ref<CheckpointData2NV> pCheckpointData
    );

    [NativeName("vkGetQueueCheckpointDataNV")]
    [NativeFunction("vulkan", EntryPoint = "vkGetQueueCheckpointDataNV")]
    void GetQueueCheckpointDataNV(
        QueueHandle queue,
        uint* pCheckpointDataCount,
        CheckpointDataNV* pCheckpointData
    );

    [NativeName("vkGetQueueCheckpointDataNV")]
    [NativeFunction("vulkan", EntryPoint = "vkGetQueueCheckpointDataNV")]
    void GetQueueCheckpointDataNV(
        QueueHandle queue,
        Ref<uint> pCheckpointDataCount,
        Ref<CheckpointDataNV> pCheckpointData
    );

    [NativeName("vkGetRayTracingCaptureReplayShaderGroupHandlesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetRayTracingCaptureReplayShaderGroupHandlesKHR")]
    Result GetRayTracingCaptureReplayShaderGroupHandlesKHR(
        DeviceHandle device,
        PipelineHandle pipeline,
        uint firstGroup,
        uint groupCount,
        nuint dataSize,
        void* pData
    );

    [NativeName("vkGetRayTracingCaptureReplayShaderGroupHandlesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetRayTracingCaptureReplayShaderGroupHandlesKHR")]
    Result GetRayTracingCaptureReplayShaderGroupHandlesKHR(
        DeviceHandle device,
        PipelineHandle pipeline,
        uint firstGroup,
        uint groupCount,
        nuint dataSize,
        Ref pData
    );

    [NativeName("vkGetRayTracingShaderGroupHandlesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetRayTracingShaderGroupHandlesKHR")]
    Result GetRayTracingShaderGroupHandlesKHR(
        DeviceHandle device,
        PipelineHandle pipeline,
        uint firstGroup,
        uint groupCount,
        nuint dataSize,
        void* pData
    );

    [NativeName("vkGetRayTracingShaderGroupHandlesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetRayTracingShaderGroupHandlesKHR")]
    Result GetRayTracingShaderGroupHandlesKHR(
        DeviceHandle device,
        PipelineHandle pipeline,
        uint firstGroup,
        uint groupCount,
        nuint dataSize,
        Ref pData
    );

    [NativeName("vkGetRayTracingShaderGroupHandlesNV")]
    [NativeFunction("vulkan", EntryPoint = "vkGetRayTracingShaderGroupHandlesNV")]
    Result GetRayTracingShaderGroupHandlesNV(
        DeviceHandle device,
        PipelineHandle pipeline,
        uint firstGroup,
        uint groupCount,
        nuint dataSize,
        void* pData
    );

    [NativeName("vkGetRayTracingShaderGroupHandlesNV")]
    [NativeFunction("vulkan", EntryPoint = "vkGetRayTracingShaderGroupHandlesNV")]
    Result GetRayTracingShaderGroupHandlesNV(
        DeviceHandle device,
        PipelineHandle pipeline,
        uint firstGroup,
        uint groupCount,
        nuint dataSize,
        Ref pData
    );

    [NativeName("vkGetRayTracingShaderGroupStackSizeKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetRayTracingShaderGroupStackSizeKHR")]
    ulong GetRayTracingShaderGroupStackSizeKHR(
        DeviceHandle device,
        PipelineHandle pipeline,
        uint group,
        ShaderGroupShaderKHR groupShader
    );

    [NativeName("vkGetRefreshCycleDurationGOOGLE")]
    [NativeFunction("vulkan", EntryPoint = "vkGetRefreshCycleDurationGOOGLE")]
    Result GetRefreshCycleDurationGOOGLE(
        DeviceHandle device,
        SwapchainHandleKHR swapchain,
        RefreshCycleDurationGOOGLE* pDisplayTimingProperties
    );

    [NativeName("vkGetRefreshCycleDurationGOOGLE")]
    [NativeFunction("vulkan", EntryPoint = "vkGetRefreshCycleDurationGOOGLE")]
    Result GetRefreshCycleDurationGOOGLE(
        DeviceHandle device,
        SwapchainHandleKHR swapchain,
        Ref<RefreshCycleDurationGOOGLE> pDisplayTimingProperties
    );

    [NativeName("vkGetRenderAreaGranularity")]
    [NativeFunction("vulkan", EntryPoint = "vkGetRenderAreaGranularity")]
    void GetRenderAreaGranularity(
        DeviceHandle device,
        RenderPassHandle renderPass,
        Extent2D* pGranularity
    );

    [NativeName("vkGetRenderAreaGranularity")]
    [NativeFunction("vulkan", EntryPoint = "vkGetRenderAreaGranularity")]
    void GetRenderAreaGranularity(
        DeviceHandle device,
        RenderPassHandle renderPass,
        Ref<Extent2D> pGranularity
    );

    [NativeName("vkGetRenderingAreaGranularity")]
    [NativeFunction("vulkan", EntryPoint = "vkGetRenderingAreaGranularity")]
    void GetRenderingAreaGranularity(
        DeviceHandle device,
        RenderingAreaInfo* pRenderingAreaInfo,
        Extent2D* pGranularity
    );

    [NativeName("vkGetRenderingAreaGranularity")]
    [NativeFunction("vulkan", EntryPoint = "vkGetRenderingAreaGranularity")]
    void GetRenderingAreaGranularity(
        DeviceHandle device,
        Ref<RenderingAreaInfo> pRenderingAreaInfo,
        Ref<Extent2D> pGranularity
    );

    [NativeName("vkGetRenderingAreaGranularityKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetRenderingAreaGranularityKHR")]
    void GetRenderingAreaGranularityKHR(
        DeviceHandle device,
        RenderingAreaInfo* pRenderingAreaInfo,
        Extent2D* pGranularity
    );

    [NativeName("vkGetRenderingAreaGranularityKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetRenderingAreaGranularityKHR")]
    void GetRenderingAreaGranularityKHR(
        DeviceHandle device,
        Ref<RenderingAreaInfo> pRenderingAreaInfo,
        Ref<Extent2D> pGranularity
    );

    [NativeName("vkGetSamplerOpaqueCaptureDescriptorDataEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetSamplerOpaqueCaptureDescriptorDataEXT")]
    Result GetSamplerOpaqueCaptureDescriptorDataEXT(
        DeviceHandle device,
        SamplerCaptureDescriptorDataInfoEXT* pInfo,
        void* pData
    );

    [NativeName("vkGetSamplerOpaqueCaptureDescriptorDataEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetSamplerOpaqueCaptureDescriptorDataEXT")]
    Result GetSamplerOpaqueCaptureDescriptorDataEXT(
        DeviceHandle device,
        Ref<SamplerCaptureDescriptorDataInfoEXT> pInfo,
        Ref pData
    );

    [NativeName("vkGetSemaphoreCounterValue")]
    [NativeFunction("vulkan", EntryPoint = "vkGetSemaphoreCounterValue")]
    Result GetSemaphoreCounterValue(DeviceHandle device, SemaphoreHandle semaphore, ulong* pValue);

    [NativeName("vkGetSemaphoreCounterValue")]
    [NativeFunction("vulkan", EntryPoint = "vkGetSemaphoreCounterValue")]
    Result GetSemaphoreCounterValue(
        DeviceHandle device,
        SemaphoreHandle semaphore,
        Ref<ulong> pValue
    );

    [NativeName("vkGetSemaphoreCounterValueKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetSemaphoreCounterValueKHR")]
    Result GetSemaphoreCounterValueKHR(
        DeviceHandle device,
        SemaphoreHandle semaphore,
        ulong* pValue
    );

    [NativeName("vkGetSemaphoreCounterValueKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetSemaphoreCounterValueKHR")]
    Result GetSemaphoreCounterValueKHR(
        DeviceHandle device,
        SemaphoreHandle semaphore,
        Ref<ulong> pValue
    );

    [NativeName("vkGetSemaphoreFdKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetSemaphoreFdKHR")]
    Result GetSemaphoreFdKHR(DeviceHandle device, SemaphoreGetFdInfoKHR* pGetFdInfo, int* pFd);

    [NativeName("vkGetSemaphoreFdKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetSemaphoreFdKHR")]
    Result GetSemaphoreFdKHR(
        DeviceHandle device,
        Ref<SemaphoreGetFdInfoKHR> pGetFdInfo,
        Ref<int> pFd
    );

    [NativeName("vkGetShaderBinaryDataEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetShaderBinaryDataEXT")]
    Result GetShaderBinaryDataEXT(
        DeviceHandle device,
        ShaderHandleEXT shader,
        nuint* pDataSize,
        void* pData
    );

    [NativeName("vkGetShaderBinaryDataEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetShaderBinaryDataEXT")]
    Result GetShaderBinaryDataEXT(
        DeviceHandle device,
        ShaderHandleEXT shader,
        Ref<nuint> pDataSize,
        Ref pData
    );

    [NativeName("vkGetShaderInfoAMD")]
    [NativeFunction("vulkan", EntryPoint = "vkGetShaderInfoAMD")]
    Result GetShaderInfoAMD(
        DeviceHandle device,
        PipelineHandle pipeline,
        ShaderStageFlags shaderStage,
        ShaderInfoTypeAMD infoType,
        nuint* pInfoSize,
        void* pInfo
    );

    [NativeName("vkGetShaderInfoAMD")]
    [NativeFunction("vulkan", EntryPoint = "vkGetShaderInfoAMD")]
    Result GetShaderInfoAMD(
        DeviceHandle device,
        PipelineHandle pipeline,
        ShaderStageFlags shaderStage,
        ShaderInfoTypeAMD infoType,
        Ref<nuint> pInfoSize,
        Ref pInfo
    );

    [NativeName("vkGetShaderInstrumentationValuesARM")]
    [NativeFunction("vulkan", EntryPoint = "vkGetShaderInstrumentationValuesARM")]
    Result GetShaderInstrumentationValuesARM(
        DeviceHandle device,
        ShaderInstrumentationHandleARM instrumentation,
        uint* pMetricBlockCount,
        void* pMetricValues,
        uint flags
    );

    [NativeName("vkGetShaderInstrumentationValuesARM")]
    [NativeFunction("vulkan", EntryPoint = "vkGetShaderInstrumentationValuesARM")]
    Result GetShaderInstrumentationValuesARM(
        DeviceHandle device,
        ShaderInstrumentationHandleARM instrumentation,
        Ref<uint> pMetricBlockCount,
        Ref pMetricValues,
        uint flags
    );

    [NativeName("vkGetShaderModuleCreateInfoIdentifierEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetShaderModuleCreateInfoIdentifierEXT")]
    void GetShaderModuleCreateInfoIdentifierEXT(
        DeviceHandle device,
        ShaderModuleCreateInfo* pCreateInfo,
        ShaderModuleIdentifierEXT* pIdentifier
    );

    [NativeName("vkGetShaderModuleCreateInfoIdentifierEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetShaderModuleCreateInfoIdentifierEXT")]
    void GetShaderModuleCreateInfoIdentifierEXT(
        DeviceHandle device,
        Ref<ShaderModuleCreateInfo> pCreateInfo,
        Ref<ShaderModuleIdentifierEXT> pIdentifier
    );

    [NativeName("vkGetShaderModuleIdentifierEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetShaderModuleIdentifierEXT")]
    void GetShaderModuleIdentifierEXT(
        DeviceHandle device,
        ShaderModuleHandle shaderModule,
        ShaderModuleIdentifierEXT* pIdentifier
    );

    [NativeName("vkGetShaderModuleIdentifierEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetShaderModuleIdentifierEXT")]
    void GetShaderModuleIdentifierEXT(
        DeviceHandle device,
        ShaderModuleHandle shaderModule,
        Ref<ShaderModuleIdentifierEXT> pIdentifier
    );

    [NativeName("vkGetSwapchainCounterEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetSwapchainCounterEXT")]
    Result GetSwapchainCounterEXT(
        DeviceHandle device,
        SwapchainHandleKHR swapchain,
        SurfaceCounterFlagsEXT counter,
        ulong* pCounterValue
    );

    [NativeName("vkGetSwapchainCounterEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetSwapchainCounterEXT")]
    Result GetSwapchainCounterEXT(
        DeviceHandle device,
        SwapchainHandleKHR swapchain,
        SurfaceCounterFlagsEXT counter,
        Ref<ulong> pCounterValue
    );

    [NativeName("vkGetSwapchainImagesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetSwapchainImagesKHR")]
    Result GetSwapchainImagesKHR(
        DeviceHandle device,
        SwapchainHandleKHR swapchain,
        uint* pSwapchainImageCount,
        ImageHandle* pSwapchainImages
    );

    [NativeName("vkGetSwapchainImagesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetSwapchainImagesKHR")]
    Result GetSwapchainImagesKHR(
        DeviceHandle device,
        SwapchainHandleKHR swapchain,
        Ref<uint> pSwapchainImageCount,
        Ref<ImageHandle> pSwapchainImages
    );

    [NativeName("vkGetSwapchainStatusKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetSwapchainStatusKHR")]
    Result GetSwapchainStatusKHR(DeviceHandle device, SwapchainHandleKHR swapchain);

    [NativeName("vkGetSwapchainTimeDomainPropertiesEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetSwapchainTimeDomainPropertiesEXT")]
    Result GetSwapchainTimeDomainPropertiesEXT(
        DeviceHandle device,
        SwapchainHandleKHR swapchain,
        SwapchainTimeDomainPropertiesEXT* pSwapchainTimeDomainProperties,
        ulong* pTimeDomainsCounter
    );

    [NativeName("vkGetSwapchainTimeDomainPropertiesEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetSwapchainTimeDomainPropertiesEXT")]
    Result GetSwapchainTimeDomainPropertiesEXT(
        DeviceHandle device,
        SwapchainHandleKHR swapchain,
        Ref<SwapchainTimeDomainPropertiesEXT> pSwapchainTimeDomainProperties,
        Ref<ulong> pTimeDomainsCounter
    );

    [NativeName("vkGetSwapchainTimingPropertiesEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetSwapchainTimingPropertiesEXT")]
    Result GetSwapchainTimingPropertiesEXT(
        DeviceHandle device,
        SwapchainHandleKHR swapchain,
        SwapchainTimingPropertiesEXT* pSwapchainTimingProperties,
        ulong* pSwapchainTimingPropertiesCounter
    );

    [NativeName("vkGetSwapchainTimingPropertiesEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetSwapchainTimingPropertiesEXT")]
    Result GetSwapchainTimingPropertiesEXT(
        DeviceHandle device,
        SwapchainHandleKHR swapchain,
        Ref<SwapchainTimingPropertiesEXT> pSwapchainTimingProperties,
        Ref<ulong> pSwapchainTimingPropertiesCounter
    );

    [NativeName("vkGetTensorMemoryRequirementsARM")]
    [NativeFunction("vulkan", EntryPoint = "vkGetTensorMemoryRequirementsARM")]
    void GetTensorMemoryRequirementsARM(
        DeviceHandle device,
        TensorMemoryRequirementsInfoARM* pInfo,
        MemoryRequirements2* pMemoryRequirements
    );

    [NativeName("vkGetTensorMemoryRequirementsARM")]
    [NativeFunction("vulkan", EntryPoint = "vkGetTensorMemoryRequirementsARM")]
    void GetTensorMemoryRequirementsARM(
        DeviceHandle device,
        Ref<TensorMemoryRequirementsInfoARM> pInfo,
        Ref<MemoryRequirements2> pMemoryRequirements
    );

    [NativeName("vkGetTensorOpaqueCaptureDataARM")]
    [NativeFunction("vulkan", EntryPoint = "vkGetTensorOpaqueCaptureDataARM")]
    Result GetTensorOpaqueCaptureDataARM(
        DeviceHandle device,
        uint tensorCount,
        TensorHandleARM* pTensors,
        HostAddressRangeEXT* pDatas
    );

    [NativeName("vkGetTensorOpaqueCaptureDataARM")]
    [NativeFunction("vulkan", EntryPoint = "vkGetTensorOpaqueCaptureDataARM")]
    Result GetTensorOpaqueCaptureDataARM(
        DeviceHandle device,
        uint tensorCount,
        Ref<TensorHandleARM> pTensors,
        Ref<HostAddressRangeEXT> pDatas
    );

    [NativeName("vkGetTensorOpaqueCaptureDescriptorDataARM")]
    [NativeFunction("vulkan", EntryPoint = "vkGetTensorOpaqueCaptureDescriptorDataARM")]
    Result GetTensorOpaqueCaptureDescriptorDataARM(
        DeviceHandle device,
        TensorCaptureDescriptorDataInfoARM* pInfo,
        void* pData
    );

    [NativeName("vkGetTensorOpaqueCaptureDescriptorDataARM")]
    [NativeFunction("vulkan", EntryPoint = "vkGetTensorOpaqueCaptureDescriptorDataARM")]
    Result GetTensorOpaqueCaptureDescriptorDataARM(
        DeviceHandle device,
        Ref<TensorCaptureDescriptorDataInfoARM> pInfo,
        Ref pData
    );

    [NativeName("vkGetTensorViewOpaqueCaptureDescriptorDataARM")]
    [NativeFunction("vulkan", EntryPoint = "vkGetTensorViewOpaqueCaptureDescriptorDataARM")]
    Result GetTensorViewOpaqueCaptureDescriptorDataARM(
        DeviceHandle device,
        TensorViewCaptureDescriptorDataInfoARM* pInfo,
        void* pData
    );

    [NativeName("vkGetTensorViewOpaqueCaptureDescriptorDataARM")]
    [NativeFunction("vulkan", EntryPoint = "vkGetTensorViewOpaqueCaptureDescriptorDataARM")]
    Result GetTensorViewOpaqueCaptureDescriptorDataARM(
        DeviceHandle device,
        Ref<TensorViewCaptureDescriptorDataInfoARM> pInfo,
        Ref pData
    );

    [NativeName("vkGetValidationCacheDataEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetValidationCacheDataEXT")]
    Result GetValidationCacheDataEXT(
        DeviceHandle device,
        ValidationCacheHandleEXT validationCache,
        nuint* pDataSize,
        void* pData
    );

    [NativeName("vkGetValidationCacheDataEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkGetValidationCacheDataEXT")]
    Result GetValidationCacheDataEXT(
        DeviceHandle device,
        ValidationCacheHandleEXT validationCache,
        Ref<nuint> pDataSize,
        Ref pData
    );

    [NativeName("vkGetVideoSessionMemoryRequirementsKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetVideoSessionMemoryRequirementsKHR")]
    Result GetVideoSessionMemoryRequirementsKHR(
        DeviceHandle device,
        VideoSessionHandleKHR videoSession,
        uint* pMemoryRequirementsCount,
        VideoSessionMemoryRequirementsKHR* pMemoryRequirements
    );

    [NativeName("vkGetVideoSessionMemoryRequirementsKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkGetVideoSessionMemoryRequirementsKHR")]
    Result GetVideoSessionMemoryRequirementsKHR(
        DeviceHandle device,
        VideoSessionHandleKHR videoSession,
        Ref<uint> pMemoryRequirementsCount,
        Ref<VideoSessionMemoryRequirementsKHR> pMemoryRequirements
    );

    [NativeName("vkImportFenceFdKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkImportFenceFdKHR")]
    Result ImportFenceFdKHR(DeviceHandle device, ImportFenceFdInfoKHR* pImportFenceFdInfo);

    [NativeName("vkImportFenceFdKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkImportFenceFdKHR")]
    Result ImportFenceFdKHR(DeviceHandle device, Ref<ImportFenceFdInfoKHR> pImportFenceFdInfo);

    [NativeName("vkImportSemaphoreFdKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkImportSemaphoreFdKHR")]
    Result ImportSemaphoreFdKHR(
        DeviceHandle device,
        ImportSemaphoreFdInfoKHR* pImportSemaphoreFdInfo
    );

    [NativeName("vkImportSemaphoreFdKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkImportSemaphoreFdKHR")]
    Result ImportSemaphoreFdKHR(
        DeviceHandle device,
        Ref<ImportSemaphoreFdInfoKHR> pImportSemaphoreFdInfo
    );

    [NativeName("vkInitializePerformanceApiINTEL")]
    [NativeFunction("vulkan", EntryPoint = "vkInitializePerformanceApiINTEL")]
    Result InitializePerformanceApiINTEL(
        DeviceHandle device,
        InitializePerformanceApiInfoINTEL* pInitializeInfo
    );

    [NativeName("vkInitializePerformanceApiINTEL")]
    [NativeFunction("vulkan", EntryPoint = "vkInitializePerformanceApiINTEL")]
    Result InitializePerformanceApiINTEL(
        DeviceHandle device,
        Ref<InitializePerformanceApiInfoINTEL> pInitializeInfo
    );

    [NativeName("vkInvalidateMappedMemoryRanges")]
    [NativeFunction("vulkan", EntryPoint = "vkInvalidateMappedMemoryRanges")]
    Result InvalidateMappedMemoryRanges(
        DeviceHandle device,
        uint memoryRangeCount,
        MappedMemoryRange* pMemoryRanges
    );

    [NativeName("vkInvalidateMappedMemoryRanges")]
    [NativeFunction("vulkan", EntryPoint = "vkInvalidateMappedMemoryRanges")]
    Result InvalidateMappedMemoryRanges(
        DeviceHandle device,
        uint memoryRangeCount,
        Ref<MappedMemoryRange> pMemoryRanges
    );

    [NativeName("vkLatencySleepNV")]
    [NativeFunction("vulkan", EntryPoint = "vkLatencySleepNV")]
    Result LatencySleepNV(
        DeviceHandle device,
        SwapchainHandleKHR swapchain,
        LatencySleepInfoNV* pSleepInfo
    );

    [NativeName("vkLatencySleepNV")]
    [NativeFunction("vulkan", EntryPoint = "vkLatencySleepNV")]
    Result LatencySleepNV(
        DeviceHandle device,
        SwapchainHandleKHR swapchain,
        Ref<LatencySleepInfoNV> pSleepInfo
    );

    [NativeName("vkMapMemory")]
    [NativeFunction("vulkan", EntryPoint = "vkMapMemory")]
    Result MapMemory(
        DeviceHandle device,
        DeviceMemoryHandle memory,
        ulong offset,
        ulong size,
        MemoryMapFlags flags,
        void** ppData
    );

    [NativeName("vkMapMemory")]
    [NativeFunction("vulkan", EntryPoint = "vkMapMemory")]
    Result MapMemory(
        DeviceHandle device,
        DeviceMemoryHandle memory,
        ulong offset,
        ulong size,
        MemoryMapFlags flags,
        Ref2D ppData
    );

    [NativeName("vkMapMemory2")]
    [NativeFunction("vulkan", EntryPoint = "vkMapMemory2")]
    Result MapMemory2(DeviceHandle device, MemoryMapInfo* pMemoryMapInfo, void** ppData);

    [NativeName("vkMapMemory2")]
    [NativeFunction("vulkan", EntryPoint = "vkMapMemory2")]
    Result MapMemory2(DeviceHandle device, Ref<MemoryMapInfo> pMemoryMapInfo, Ref2D ppData);

    [NativeName("vkMapMemory2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkMapMemory2KHR")]
    Result MapMemory2KHR(DeviceHandle device, MemoryMapInfo* pMemoryMapInfo, void** ppData);

    [NativeName("vkMapMemory2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkMapMemory2KHR")]
    Result MapMemory2KHR(DeviceHandle device, Ref<MemoryMapInfo> pMemoryMapInfo, Ref2D ppData);

    [NativeName("vkMergePipelineCaches")]
    [NativeFunction("vulkan", EntryPoint = "vkMergePipelineCaches")]
    Result MergePipelineCaches(
        DeviceHandle device,
        PipelineCacheHandle dstCache,
        uint srcCacheCount,
        PipelineCacheHandle* pSrcCaches
    );

    [NativeName("vkMergePipelineCaches")]
    [NativeFunction("vulkan", EntryPoint = "vkMergePipelineCaches")]
    Result MergePipelineCaches(
        DeviceHandle device,
        PipelineCacheHandle dstCache,
        uint srcCacheCount,
        Ref<PipelineCacheHandle> pSrcCaches
    );

    [NativeName("vkMergeValidationCachesEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkMergeValidationCachesEXT")]
    Result MergeValidationCachesEXT(
        DeviceHandle device,
        ValidationCacheHandleEXT dstCache,
        uint srcCacheCount,
        ValidationCacheHandleEXT* pSrcCaches
    );

    [NativeName("vkMergeValidationCachesEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkMergeValidationCachesEXT")]
    Result MergeValidationCachesEXT(
        DeviceHandle device,
        ValidationCacheHandleEXT dstCache,
        uint srcCacheCount,
        Ref<ValidationCacheHandleEXT> pSrcCaches
    );

    [NativeName("vkQueueBeginDebugUtilsLabelEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkQueueBeginDebugUtilsLabelEXT")]
    void QueueBeginDebugUtilsLabelEXT(QueueHandle queue, DebugUtilsLabelEXT* pLabelInfo);

    [NativeName("vkQueueBeginDebugUtilsLabelEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkQueueBeginDebugUtilsLabelEXT")]
    void QueueBeginDebugUtilsLabelEXT(QueueHandle queue, Ref<DebugUtilsLabelEXT> pLabelInfo);

    [NativeName("vkQueueBindSparse")]
    [NativeFunction("vulkan", EntryPoint = "vkQueueBindSparse")]
    Result QueueBindSparse(
        QueueHandle queue,
        uint bindInfoCount,
        BindSparseInfo* pBindInfo,
        FenceHandle fence
    );

    [NativeName("vkQueueBindSparse")]
    [NativeFunction("vulkan", EntryPoint = "vkQueueBindSparse")]
    Result QueueBindSparse(
        QueueHandle queue,
        uint bindInfoCount,
        Ref<BindSparseInfo> pBindInfo,
        FenceHandle fence
    );

    [NativeName("vkQueueEndDebugUtilsLabelEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkQueueEndDebugUtilsLabelEXT")]
    void QueueEndDebugUtilsLabelEXT(QueueHandle queue);

    [NativeName("vkQueueInsertDebugUtilsLabelEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkQueueInsertDebugUtilsLabelEXT")]
    void QueueInsertDebugUtilsLabelEXT(QueueHandle queue, DebugUtilsLabelEXT* pLabelInfo);

    [NativeName("vkQueueInsertDebugUtilsLabelEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkQueueInsertDebugUtilsLabelEXT")]
    void QueueInsertDebugUtilsLabelEXT(QueueHandle queue, Ref<DebugUtilsLabelEXT> pLabelInfo);

    [NativeName("vkQueueNotifyOutOfBandNV")]
    [NativeFunction("vulkan", EntryPoint = "vkQueueNotifyOutOfBandNV")]
    void QueueNotifyOutOfBandNV(QueueHandle queue, OutOfBandQueueTypeInfoNV* pQueueTypeInfo);

    [NativeName("vkQueueNotifyOutOfBandNV")]
    [NativeFunction("vulkan", EntryPoint = "vkQueueNotifyOutOfBandNV")]
    void QueueNotifyOutOfBandNV(QueueHandle queue, Ref<OutOfBandQueueTypeInfoNV> pQueueTypeInfo);

    [NativeName("vkQueuePresentKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkQueuePresentKHR")]
    Result QueuePresentKHR(QueueHandle queue, PresentInfoKHR* pPresentInfo);

    [NativeName("vkQueuePresentKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkQueuePresentKHR")]
    Result QueuePresentKHR(QueueHandle queue, Ref<PresentInfoKHR> pPresentInfo);

    [NativeName("vkQueueSetPerfHintQCOM")]
    [NativeFunction("vulkan", EntryPoint = "vkQueueSetPerfHintQCOM")]
    Result QueueSetPerfHintQCOM(QueueHandle queue, PerfHintInfoQCOM* pPerfHintInfo);

    [NativeName("vkQueueSetPerfHintQCOM")]
    [NativeFunction("vulkan", EntryPoint = "vkQueueSetPerfHintQCOM")]
    Result QueueSetPerfHintQCOM(QueueHandle queue, Ref<PerfHintInfoQCOM> pPerfHintInfo);

    [NativeName("vkQueueSetPerformanceConfigurationINTEL")]
    [NativeFunction("vulkan", EntryPoint = "vkQueueSetPerformanceConfigurationINTEL")]
    Result QueueSetPerformanceConfigurationINTEL(
        QueueHandle queue,
        PerformanceConfigurationHandleINTEL configuration
    );

    [NativeName("vkQueueSubmit")]
    [NativeFunction("vulkan", EntryPoint = "vkQueueSubmit")]
    Result QueueSubmit(
        QueueHandle queue,
        uint submitCount,
        SubmitInfo* pSubmits,
        FenceHandle fence
    );

    [NativeName("vkQueueSubmit")]
    [NativeFunction("vulkan", EntryPoint = "vkQueueSubmit")]
    Result QueueSubmit(
        QueueHandle queue,
        uint submitCount,
        Ref<SubmitInfo> pSubmits,
        FenceHandle fence
    );

    [NativeName("vkQueueSubmit2")]
    [NativeFunction("vulkan", EntryPoint = "vkQueueSubmit2")]
    Result QueueSubmit2(
        QueueHandle queue,
        uint submitCount,
        SubmitInfo2* pSubmits,
        FenceHandle fence
    );

    [NativeName("vkQueueSubmit2")]
    [NativeFunction("vulkan", EntryPoint = "vkQueueSubmit2")]
    Result QueueSubmit2(
        QueueHandle queue,
        uint submitCount,
        Ref<SubmitInfo2> pSubmits,
        FenceHandle fence
    );

    [NativeName("vkQueueSubmit2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkQueueSubmit2KHR")]
    Result QueueSubmit2KHR(
        QueueHandle queue,
        uint submitCount,
        SubmitInfo2* pSubmits,
        FenceHandle fence
    );

    [NativeName("vkQueueSubmit2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkQueueSubmit2KHR")]
    Result QueueSubmit2KHR(
        QueueHandle queue,
        uint submitCount,
        Ref<SubmitInfo2> pSubmits,
        FenceHandle fence
    );

    [NativeName("vkQueueWaitIdle")]
    [NativeFunction("vulkan", EntryPoint = "vkQueueWaitIdle")]
    Result QueueWaitIdle(QueueHandle queue);

    [NativeName("vkRegisterCustomBorderColorEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkRegisterCustomBorderColorEXT")]
    Result RegisterCustomBorderColorEXT(
        DeviceHandle device,
        SamplerCustomBorderColorCreateInfoEXT* pBorderColor,
        uint requestIndex,
        uint* pIndex
    );

    [NativeName("vkRegisterCustomBorderColorEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkRegisterCustomBorderColorEXT")]
    Result RegisterCustomBorderColorEXT(
        DeviceHandle device,
        Ref<SamplerCustomBorderColorCreateInfoEXT> pBorderColor,
        MaybeBool<uint> requestIndex,
        Ref<uint> pIndex
    );

    [NativeName("vkRegisterDeviceEventEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkRegisterDeviceEventEXT")]
    Result RegisterDeviceEventEXT(
        DeviceHandle device,
        DeviceEventInfoEXT* pDeviceEventInfo,
        AllocationCallbacks* pAllocator,
        FenceHandle* pFence
    );

    [NativeName("vkRegisterDeviceEventEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkRegisterDeviceEventEXT")]
    Result RegisterDeviceEventEXT(
        DeviceHandle device,
        Ref<DeviceEventInfoEXT> pDeviceEventInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<FenceHandle> pFence
    );

    [NativeName("vkRegisterDisplayEventEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkRegisterDisplayEventEXT")]
    Result RegisterDisplayEventEXT(
        DeviceHandle device,
        DisplayHandleKHR display,
        DisplayEventInfoEXT* pDisplayEventInfo,
        AllocationCallbacks* pAllocator,
        FenceHandle* pFence
    );

    [NativeName("vkRegisterDisplayEventEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkRegisterDisplayEventEXT")]
    Result RegisterDisplayEventEXT(
        DeviceHandle device,
        DisplayHandleKHR display,
        Ref<DisplayEventInfoEXT> pDisplayEventInfo,
        Ref<AllocationCallbacks> pAllocator,
        Ref<FenceHandle> pFence
    );

    [NativeName("vkReleaseCapturedPipelineDataKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkReleaseCapturedPipelineDataKHR")]
    Result ReleaseCapturedPipelineDataKHR(
        DeviceHandle device,
        ReleaseCapturedPipelineDataInfoKHR* pInfo,
        AllocationCallbacks* pAllocator
    );

    [NativeName("vkReleaseCapturedPipelineDataKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkReleaseCapturedPipelineDataKHR")]
    Result ReleaseCapturedPipelineDataKHR(
        DeviceHandle device,
        Ref<ReleaseCapturedPipelineDataInfoKHR> pInfo,
        Ref<AllocationCallbacks> pAllocator
    );

    [NativeName("vkReleaseDisplayEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkReleaseDisplayEXT")]
    Result ReleaseDisplayEXT(PhysicalDeviceHandle physicalDevice, DisplayHandleKHR display);

    [NativeName("vkReleasePerformanceConfigurationINTEL")]
    [NativeFunction("vulkan", EntryPoint = "vkReleasePerformanceConfigurationINTEL")]
    Result ReleasePerformanceConfigurationINTEL(
        DeviceHandle device,
        PerformanceConfigurationHandleINTEL configuration
    );

    [NativeName("vkReleaseProfilingLockKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkReleaseProfilingLockKHR")]
    void ReleaseProfilingLockKHR(DeviceHandle device);

    [NativeName("vkReleaseSwapchainImagesEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkReleaseSwapchainImagesEXT")]
    Result ReleaseSwapchainImagesEXT(
        DeviceHandle device,
        ReleaseSwapchainImagesInfoKHR* pReleaseInfo
    );

    [NativeName("vkReleaseSwapchainImagesEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkReleaseSwapchainImagesEXT")]
    Result ReleaseSwapchainImagesEXT(
        DeviceHandle device,
        Ref<ReleaseSwapchainImagesInfoKHR> pReleaseInfo
    );

    [NativeName("vkReleaseSwapchainImagesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkReleaseSwapchainImagesKHR")]
    Result ReleaseSwapchainImagesKHR(
        DeviceHandle device,
        ReleaseSwapchainImagesInfoKHR* pReleaseInfo
    );

    [NativeName("vkReleaseSwapchainImagesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkReleaseSwapchainImagesKHR")]
    Result ReleaseSwapchainImagesKHR(
        DeviceHandle device,
        Ref<ReleaseSwapchainImagesInfoKHR> pReleaseInfo
    );

    [NativeName("vkResetCommandBuffer")]
    [NativeFunction("vulkan", EntryPoint = "vkResetCommandBuffer")]
    Result ResetCommandBuffer(CommandBufferHandle commandBuffer, CommandBufferResetFlags flags);

    [NativeName("vkResetCommandPool")]
    [NativeFunction("vulkan", EntryPoint = "vkResetCommandPool")]
    Result ResetCommandPool(
        DeviceHandle device,
        CommandPoolHandle commandPool,
        CommandPoolResetFlags flags
    );

    [NativeName("vkResetDescriptorPool")]
    [NativeFunction("vulkan", EntryPoint = "vkResetDescriptorPool")]
    Result ResetDescriptorPool(
        DeviceHandle device,
        DescriptorPoolHandle descriptorPool,
        uint flags
    );

    [NativeName("vkResetEvent")]
    [NativeFunction("vulkan", EntryPoint = "vkResetEvent")]
    Result ResetEvent(DeviceHandle device, EventHandle @event);

    [NativeName("vkResetFences")]
    [NativeFunction("vulkan", EntryPoint = "vkResetFences")]
    Result ResetFences(DeviceHandle device, uint fenceCount, FenceHandle* pFences);

    [NativeName("vkResetFences")]
    [NativeFunction("vulkan", EntryPoint = "vkResetFences")]
    Result ResetFences(DeviceHandle device, uint fenceCount, Ref<FenceHandle> pFences);

    [NativeName("vkResetGpaSessionAMD")]
    [NativeFunction("vulkan", EntryPoint = "vkResetGpaSessionAMD")]
    Result ResetGpaSessionAMD(DeviceHandle device, GpaSessionHandleAMD gpaSession);

    [NativeName("vkResetQueryPool")]
    [NativeFunction("vulkan", EntryPoint = "vkResetQueryPool")]
    void ResetQueryPool(
        DeviceHandle device,
        QueryPoolHandle queryPool,
        uint firstQuery,
        uint queryCount
    );

    [NativeName("vkResetQueryPoolEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkResetQueryPoolEXT")]
    void ResetQueryPoolEXT(
        DeviceHandle device,
        QueryPoolHandle queryPool,
        uint firstQuery,
        uint queryCount
    );

    [NativeName("vkSetDebugUtilsObjectNameEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkSetDebugUtilsObjectNameEXT")]
    Result SetDebugUtilsObjectNameEXT(DeviceHandle device, DebugUtilsObjectNameInfoEXT* pNameInfo);

    [NativeName("vkSetDebugUtilsObjectNameEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkSetDebugUtilsObjectNameEXT")]
    Result SetDebugUtilsObjectNameEXT(
        DeviceHandle device,
        Ref<DebugUtilsObjectNameInfoEXT> pNameInfo
    );

    [NativeName("vkSetDebugUtilsObjectTagEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkSetDebugUtilsObjectTagEXT")]
    Result SetDebugUtilsObjectTagEXT(DeviceHandle device, DebugUtilsObjectTagInfoEXT* pTagInfo);

    [NativeName("vkSetDebugUtilsObjectTagEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkSetDebugUtilsObjectTagEXT")]
    Result SetDebugUtilsObjectTagEXT(DeviceHandle device, Ref<DebugUtilsObjectTagInfoEXT> pTagInfo);

    [NativeName("vkSetDeviceMemoryPriorityEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkSetDeviceMemoryPriorityEXT")]
    void SetDeviceMemoryPriorityEXT(DeviceHandle device, DeviceMemoryHandle memory, float priority);

    [NativeName("vkSetEvent")]
    [NativeFunction("vulkan", EntryPoint = "vkSetEvent")]
    Result SetEvent(DeviceHandle device, EventHandle @event);

    [NativeName("vkSetGpaDeviceClockModeAMD")]
    [NativeFunction("vulkan", EntryPoint = "vkSetGpaDeviceClockModeAMD")]
    Result SetGpaDeviceClockModeAMD(DeviceHandle device, GpaDeviceClockModeInfoAMD* pInfo);

    [NativeName("vkSetGpaDeviceClockModeAMD")]
    [NativeFunction("vulkan", EntryPoint = "vkSetGpaDeviceClockModeAMD")]
    Result SetGpaDeviceClockModeAMD(DeviceHandle device, Ref<GpaDeviceClockModeInfoAMD> pInfo);

    [NativeName("vkSetHdrMetadataEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkSetHdrMetadataEXT")]
    void SetHdrMetadataEXT(
        DeviceHandle device,
        uint swapchainCount,
        SwapchainHandleKHR* pSwapchains,
        HdrMetadataEXT* pMetadata
    );

    [NativeName("vkSetHdrMetadataEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkSetHdrMetadataEXT")]
    void SetHdrMetadataEXT(
        DeviceHandle device,
        uint swapchainCount,
        Ref<SwapchainHandleKHR> pSwapchains,
        Ref<HdrMetadataEXT> pMetadata
    );

    [NativeName("vkSetLatencyMarkerNV")]
    [NativeFunction("vulkan", EntryPoint = "vkSetLatencyMarkerNV")]
    void SetLatencyMarkerNV(
        DeviceHandle device,
        SwapchainHandleKHR swapchain,
        SetLatencyMarkerInfoNV* pLatencyMarkerInfo
    );

    [NativeName("vkSetLatencyMarkerNV")]
    [NativeFunction("vulkan", EntryPoint = "vkSetLatencyMarkerNV")]
    void SetLatencyMarkerNV(
        DeviceHandle device,
        SwapchainHandleKHR swapchain,
        Ref<SetLatencyMarkerInfoNV> pLatencyMarkerInfo
    );

    [NativeName("vkSetLatencySleepModeNV")]
    [NativeFunction("vulkan", EntryPoint = "vkSetLatencySleepModeNV")]
    Result SetLatencySleepModeNV(
        DeviceHandle device,
        SwapchainHandleKHR swapchain,
        LatencySleepModeInfoNV* pSleepModeInfo
    );

    [NativeName("vkSetLatencySleepModeNV")]
    [NativeFunction("vulkan", EntryPoint = "vkSetLatencySleepModeNV")]
    Result SetLatencySleepModeNV(
        DeviceHandle device,
        SwapchainHandleKHR swapchain,
        Ref<LatencySleepModeInfoNV> pSleepModeInfo
    );

    [NativeName("vkSetLocalDimmingAMD")]
    [NativeFunction("vulkan", EntryPoint = "vkSetLocalDimmingAMD")]
    void SetLocalDimmingAMD(
        DeviceHandle device,
        SwapchainHandleKHR swapChain,
        uint localDimmingEnable
    );

    [NativeName("vkSetLocalDimmingAMD")]
    [NativeFunction("vulkan", EntryPoint = "vkSetLocalDimmingAMD")]
    void SetLocalDimmingAMD(
        DeviceHandle device,
        SwapchainHandleKHR swapChain,
        MaybeBool<uint> localDimmingEnable
    );

    [NativeName("vkSetPrivateData")]
    [NativeFunction("vulkan", EntryPoint = "vkSetPrivateData")]
    Result SetPrivateData(
        DeviceHandle device,
        ObjectType objectType,
        ulong objectHandle,
        PrivateDataSlotHandle privateDataSlot,
        ulong data
    );

    [NativeName("vkSetPrivateDataEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkSetPrivateDataEXT")]
    Result SetPrivateDataEXT(
        DeviceHandle device,
        ObjectType objectType,
        ulong objectHandle,
        PrivateDataSlotHandle privateDataSlot,
        ulong data
    );

    [NativeName("vkSetSwapchainPresentTimingQueueSizeEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkSetSwapchainPresentTimingQueueSizeEXT")]
    Result SetSwapchainPresentTimingQueueSizeEXT(
        DeviceHandle device,
        SwapchainHandleKHR swapchain,
        uint size
    );

    [NativeName("vkSignalSemaphore")]
    [NativeFunction("vulkan", EntryPoint = "vkSignalSemaphore")]
    Result SignalSemaphore(DeviceHandle device, SemaphoreSignalInfo* pSignalInfo);

    [NativeName("vkSignalSemaphore")]
    [NativeFunction("vulkan", EntryPoint = "vkSignalSemaphore")]
    Result SignalSemaphore(DeviceHandle device, Ref<SemaphoreSignalInfo> pSignalInfo);

    [NativeName("vkSignalSemaphoreKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkSignalSemaphoreKHR")]
    Result SignalSemaphoreKHR(DeviceHandle device, SemaphoreSignalInfo* pSignalInfo);

    [NativeName("vkSignalSemaphoreKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkSignalSemaphoreKHR")]
    Result SignalSemaphoreKHR(DeviceHandle device, Ref<SemaphoreSignalInfo> pSignalInfo);

    [NativeName("vkSubmitDebugUtilsMessageEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkSubmitDebugUtilsMessageEXT")]
    void SubmitDebugUtilsMessageEXT(
        InstanceHandle instance,
        DebugUtilsMessageSeverityFlagsEXT messageSeverity,
        DebugUtilsMessageTypeFlagsEXT messageTypes,
        DebugUtilsMessengerCallbackDataEXT* pCallbackData
    );

    [NativeName("vkSubmitDebugUtilsMessageEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkSubmitDebugUtilsMessageEXT")]
    void SubmitDebugUtilsMessageEXT(
        InstanceHandle instance,
        DebugUtilsMessageSeverityFlagsEXT messageSeverity,
        DebugUtilsMessageTypeFlagsEXT messageTypes,
        Ref<DebugUtilsMessengerCallbackDataEXT> pCallbackData
    );

    [NativeName("vkTransitionImageLayout")]
    [NativeFunction("vulkan", EntryPoint = "vkTransitionImageLayout")]
    Result TransitionImageLayout(
        DeviceHandle device,
        uint transitionCount,
        HostImageLayoutTransitionInfo* pTransitions
    );

    [NativeName("vkTransitionImageLayout")]
    [NativeFunction("vulkan", EntryPoint = "vkTransitionImageLayout")]
    Result TransitionImageLayout(
        DeviceHandle device,
        uint transitionCount,
        Ref<HostImageLayoutTransitionInfo> pTransitions
    );

    [NativeName("vkTransitionImageLayoutEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkTransitionImageLayoutEXT")]
    Result TransitionImageLayoutEXT(
        DeviceHandle device,
        uint transitionCount,
        HostImageLayoutTransitionInfo* pTransitions
    );

    [NativeName("vkTransitionImageLayoutEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkTransitionImageLayoutEXT")]
    Result TransitionImageLayoutEXT(
        DeviceHandle device,
        uint transitionCount,
        Ref<HostImageLayoutTransitionInfo> pTransitions
    );

    [NativeName("vkTrimCommandPool")]
    [NativeFunction("vulkan", EntryPoint = "vkTrimCommandPool")]
    void TrimCommandPool(DeviceHandle device, CommandPoolHandle commandPool, uint flags);

    [NativeName("vkTrimCommandPoolKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkTrimCommandPoolKHR")]
    void TrimCommandPoolKHR(DeviceHandle device, CommandPoolHandle commandPool, uint flags);

    [NativeName("vkUninitializePerformanceApiINTEL")]
    [NativeFunction("vulkan", EntryPoint = "vkUninitializePerformanceApiINTEL")]
    void UninitializePerformanceApiINTEL(DeviceHandle device);

    [NativeName("vkUnmapMemory")]
    [NativeFunction("vulkan", EntryPoint = "vkUnmapMemory")]
    void UnmapMemory(DeviceHandle device, DeviceMemoryHandle memory);

    [NativeName("vkUnmapMemory2")]
    [NativeFunction("vulkan", EntryPoint = "vkUnmapMemory2")]
    Result UnmapMemory2(DeviceHandle device, MemoryUnmapInfo* pMemoryUnmapInfo);

    [NativeName("vkUnmapMemory2")]
    [NativeFunction("vulkan", EntryPoint = "vkUnmapMemory2")]
    Result UnmapMemory2(DeviceHandle device, Ref<MemoryUnmapInfo> pMemoryUnmapInfo);

    [NativeName("vkUnmapMemory2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkUnmapMemory2KHR")]
    Result UnmapMemory2KHR(DeviceHandle device, MemoryUnmapInfo* pMemoryUnmapInfo);

    [NativeName("vkUnmapMemory2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkUnmapMemory2KHR")]
    Result UnmapMemory2KHR(DeviceHandle device, Ref<MemoryUnmapInfo> pMemoryUnmapInfo);

    [NativeName("vkUnregisterCustomBorderColorEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkUnregisterCustomBorderColorEXT")]
    void UnregisterCustomBorderColorEXT(DeviceHandle device, uint index);

    [NativeName("vkUpdateDescriptorSets")]
    [NativeFunction("vulkan", EntryPoint = "vkUpdateDescriptorSets")]
    void UpdateDescriptorSets(
        DeviceHandle device,
        uint descriptorWriteCount,
        WriteDescriptorSet* pDescriptorWrites,
        uint descriptorCopyCount,
        CopyDescriptorSet* pDescriptorCopies
    );

    [NativeName("vkUpdateDescriptorSets")]
    [NativeFunction("vulkan", EntryPoint = "vkUpdateDescriptorSets")]
    void UpdateDescriptorSets(
        DeviceHandle device,
        uint descriptorWriteCount,
        Ref<WriteDescriptorSet> pDescriptorWrites,
        uint descriptorCopyCount,
        Ref<CopyDescriptorSet> pDescriptorCopies
    );

    [NativeName("vkUpdateDescriptorSetWithTemplate")]
    [NativeFunction("vulkan", EntryPoint = "vkUpdateDescriptorSetWithTemplate")]
    void UpdateDescriptorSetWithTemplate(
        DeviceHandle device,
        DescriptorSetHandle descriptorSet,
        DescriptorUpdateTemplateHandle descriptorUpdateTemplate,
        void* pData
    );

    [NativeName("vkUpdateDescriptorSetWithTemplate")]
    [NativeFunction("vulkan", EntryPoint = "vkUpdateDescriptorSetWithTemplate")]
    void UpdateDescriptorSetWithTemplate(
        DeviceHandle device,
        DescriptorSetHandle descriptorSet,
        DescriptorUpdateTemplateHandle descriptorUpdateTemplate,
        Ref pData
    );

    [NativeName("vkUpdateDescriptorSetWithTemplateKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkUpdateDescriptorSetWithTemplateKHR")]
    void UpdateDescriptorSetWithTemplateKHR(
        DeviceHandle device,
        DescriptorSetHandle descriptorSet,
        DescriptorUpdateTemplateHandle descriptorUpdateTemplate,
        void* pData
    );

    [NativeName("vkUpdateDescriptorSetWithTemplateKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkUpdateDescriptorSetWithTemplateKHR")]
    void UpdateDescriptorSetWithTemplateKHR(
        DeviceHandle device,
        DescriptorSetHandle descriptorSet,
        DescriptorUpdateTemplateHandle descriptorUpdateTemplate,
        Ref pData
    );

    [NativeName("vkUpdateIndirectExecutionSetPipelineEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkUpdateIndirectExecutionSetPipelineEXT")]
    void UpdateIndirectExecutionSetPipelineEXT(
        DeviceHandle device,
        IndirectExecutionSetHandleEXT indirectExecutionSet,
        uint executionSetWriteCount,
        WriteIndirectExecutionSetPipelineEXT* pExecutionSetWrites
    );

    [NativeName("vkUpdateIndirectExecutionSetPipelineEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkUpdateIndirectExecutionSetPipelineEXT")]
    void UpdateIndirectExecutionSetPipelineEXT(
        DeviceHandle device,
        IndirectExecutionSetHandleEXT indirectExecutionSet,
        uint executionSetWriteCount,
        Ref<WriteIndirectExecutionSetPipelineEXT> pExecutionSetWrites
    );

    [NativeName("vkUpdateIndirectExecutionSetPipelineEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkUpdateIndirectExecutionSetPipelineEXT")]
    void UpdateIndirectExecutionSetPipelineEXT(
        DeviceHandle device,
        IndirectExecutionSetHandleEXT indirectExecutionSet,
        WriteIndirectExecutionSetPipelineEXT pExecutionSetWrites
    );

    [NativeName("vkUpdateIndirectExecutionSetShaderEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkUpdateIndirectExecutionSetShaderEXT")]
    void UpdateIndirectExecutionSetShaderEXT(
        DeviceHandle device,
        IndirectExecutionSetHandleEXT indirectExecutionSet,
        uint executionSetWriteCount,
        WriteIndirectExecutionSetShaderEXT* pExecutionSetWrites
    );

    [NativeName("vkUpdateIndirectExecutionSetShaderEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkUpdateIndirectExecutionSetShaderEXT")]
    void UpdateIndirectExecutionSetShaderEXT(
        DeviceHandle device,
        IndirectExecutionSetHandleEXT indirectExecutionSet,
        uint executionSetWriteCount,
        Ref<WriteIndirectExecutionSetShaderEXT> pExecutionSetWrites
    );

    [NativeName("vkUpdateIndirectExecutionSetShaderEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkUpdateIndirectExecutionSetShaderEXT")]
    void UpdateIndirectExecutionSetShaderEXT(
        DeviceHandle device,
        IndirectExecutionSetHandleEXT indirectExecutionSet,
        WriteIndirectExecutionSetShaderEXT pExecutionSetWrites
    );

    [NativeName("vkUpdateVideoSessionParametersKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkUpdateVideoSessionParametersKHR")]
    Result UpdateVideoSessionParametersKHR(
        DeviceHandle device,
        VideoSessionParametersHandleKHR videoSessionParameters,
        VideoSessionParametersUpdateInfoKHR* pUpdateInfo
    );

    [NativeName("vkUpdateVideoSessionParametersKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkUpdateVideoSessionParametersKHR")]
    Result UpdateVideoSessionParametersKHR(
        DeviceHandle device,
        VideoSessionParametersHandleKHR videoSessionParameters,
        Ref<VideoSessionParametersUpdateInfoKHR> pUpdateInfo
    );

    [NativeName("vkWaitForFences")]
    [NativeFunction("vulkan", EntryPoint = "vkWaitForFences")]
    Result WaitForFences(
        DeviceHandle device,
        uint fenceCount,
        FenceHandle* pFences,
        uint waitAll,
        ulong timeout
    );

    [NativeName("vkWaitForFences")]
    [NativeFunction("vulkan", EntryPoint = "vkWaitForFences")]
    Result WaitForFences(
        DeviceHandle device,
        uint fenceCount,
        Ref<FenceHandle> pFences,
        MaybeBool<uint> waitAll,
        ulong timeout
    );

    [NativeName("vkWaitForPresent2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkWaitForPresent2KHR")]
    Result WaitForPresent2KHR(
        DeviceHandle device,
        SwapchainHandleKHR swapchain,
        PresentWait2InfoKHR* pPresentWait2Info
    );

    [NativeName("vkWaitForPresent2KHR")]
    [NativeFunction("vulkan", EntryPoint = "vkWaitForPresent2KHR")]
    Result WaitForPresent2KHR(
        DeviceHandle device,
        SwapchainHandleKHR swapchain,
        Ref<PresentWait2InfoKHR> pPresentWait2Info
    );

    [NativeName("vkWaitForPresentKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkWaitForPresentKHR")]
    Result WaitForPresentKHR(
        DeviceHandle device,
        SwapchainHandleKHR swapchain,
        ulong presentId,
        ulong timeout
    );

    [NativeName("vkWaitSemaphores")]
    [NativeFunction("vulkan", EntryPoint = "vkWaitSemaphores")]
    Result WaitSemaphores(DeviceHandle device, SemaphoreWaitInfo* pWaitInfo, ulong timeout);

    [NativeName("vkWaitSemaphores")]
    [NativeFunction("vulkan", EntryPoint = "vkWaitSemaphores")]
    Result WaitSemaphores(DeviceHandle device, Ref<SemaphoreWaitInfo> pWaitInfo, ulong timeout);

    [NativeName("vkWaitSemaphoresKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkWaitSemaphoresKHR")]
    Result WaitSemaphoresKHR(DeviceHandle device, SemaphoreWaitInfo* pWaitInfo, ulong timeout);

    [NativeName("vkWaitSemaphoresKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkWaitSemaphoresKHR")]
    Result WaitSemaphoresKHR(DeviceHandle device, Ref<SemaphoreWaitInfo> pWaitInfo, ulong timeout);

    [NativeName("vkWriteAccelerationStructuresPropertiesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkWriteAccelerationStructuresPropertiesKHR")]
    Result WriteAccelerationStructuresPropertiesKHR(
        DeviceHandle device,
        uint accelerationStructureCount,
        AccelerationStructureHandleKHR* pAccelerationStructures,
        QueryType queryType,
        nuint dataSize,
        void* pData,
        nuint stride
    );

    [NativeName("vkWriteAccelerationStructuresPropertiesKHR")]
    [NativeFunction("vulkan", EntryPoint = "vkWriteAccelerationStructuresPropertiesKHR")]
    Result WriteAccelerationStructuresPropertiesKHR(
        DeviceHandle device,
        uint accelerationStructureCount,
        Ref<AccelerationStructureHandleKHR> pAccelerationStructures,
        QueryType queryType,
        nuint dataSize,
        Ref pData,
        nuint stride
    );

    [NativeName("vkWriteMicromapsPropertiesEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkWriteMicromapsPropertiesEXT")]
    Result WriteMicromapsPropertiesEXT(
        DeviceHandle device,
        uint micromapCount,
        MicromapHandleEXT* pMicromaps,
        QueryType queryType,
        nuint dataSize,
        void* pData,
        nuint stride
    );

    [NativeName("vkWriteMicromapsPropertiesEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkWriteMicromapsPropertiesEXT")]
    Result WriteMicromapsPropertiesEXT(
        DeviceHandle device,
        uint micromapCount,
        Ref<MicromapHandleEXT> pMicromaps,
        QueryType queryType,
        nuint dataSize,
        Ref pData,
        nuint stride
    );

    [NativeName("vkWriteResourceDescriptorsEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkWriteResourceDescriptorsEXT")]
    Result WriteResourceDescriptorsEXT(
        DeviceHandle device,
        uint resourceCount,
        ResourceDescriptorInfoEXT* pResources,
        HostAddressRangeEXT* pDescriptors
    );

    [NativeName("vkWriteResourceDescriptorsEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkWriteResourceDescriptorsEXT")]
    Result WriteResourceDescriptorsEXT(
        DeviceHandle device,
        uint resourceCount,
        Ref<ResourceDescriptorInfoEXT> pResources,
        Ref<HostAddressRangeEXT> pDescriptors
    );

    [NativeName("vkWriteSamplerDescriptorsEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkWriteSamplerDescriptorsEXT")]
    Result WriteSamplerDescriptorsEXT(
        DeviceHandle device,
        uint samplerCount,
        SamplerCreateInfo* pSamplers,
        HostAddressRangeEXT* pDescriptors
    );

    [NativeName("vkWriteSamplerDescriptorsEXT")]
    [NativeFunction("vulkan", EntryPoint = "vkWriteSamplerDescriptorsEXT")]
    Result WriteSamplerDescriptorsEXT(
        DeviceHandle device,
        uint samplerCount,
        Ref<SamplerCreateInfo> pSamplers,
        Ref<HostAddressRangeEXT> pDescriptors
    );
}
