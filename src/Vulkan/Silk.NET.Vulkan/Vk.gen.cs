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
    public unsafe partial class Vk : NativeAPI
    {
        [NativeName("Type", "")]
        [NativeName("Name", "VK_ATTACHMENT_UNUSED")]
        public const uint AttachmentUnused = unchecked((uint) (~0U));
        [NativeName("Type", "")]
        [NativeName("Name", "VK_FALSE")]
        public const uint False = unchecked((uint) 0);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_LOD_CLAMP_NONE")]
        public const uint LodClampNone = unchecked((uint) 1000.0F);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_LUID_SIZE")]
        public const uint LuidSize = unchecked((uint) 8);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_LUID_SIZE_KHR")]
        public const uint LuidSizeKhr = unchecked((uint) 8);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_DESCRIPTION_SIZE")]
        public const uint MaxDescriptionSize = unchecked((uint) 256);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_DEVICE_GROUP_SIZE")]
        public const uint MaxDeviceGroupSize = unchecked((uint) 32);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_DEVICE_GROUP_SIZE_KHR")]
        public const uint MaxDeviceGroupSizeKhr = unchecked((uint) 32);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_DRIVER_INFO_SIZE")]
        public const uint MaxDriverInfoSize = unchecked((uint) 256);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_DRIVER_INFO_SIZE_KHR")]
        public const uint MaxDriverInfoSizeKhr = unchecked((uint) 256);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_DRIVER_NAME_SIZE")]
        public const uint MaxDriverNameSize = unchecked((uint) 256);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_DRIVER_NAME_SIZE_KHR")]
        public const uint MaxDriverNameSizeKhr = unchecked((uint) 256);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_EXTENSION_NAME_SIZE")]
        public const uint MaxExtensionNameSize = unchecked((uint) 256);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_GLOBAL_PRIORITY_SIZE_EXT")]
        public const uint MaxGlobalPrioritySizeExt = unchecked((uint) 16);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_GLOBAL_PRIORITY_SIZE_KHR")]
        public const uint MaxGlobalPrioritySizeKhr = unchecked((uint) 16);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_MEMORY_HEAPS")]
        public const uint MaxMemoryHeaps = unchecked((uint) 16);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_MEMORY_TYPES")]
        public const uint MaxMemoryTypes = unchecked((uint) 32);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_PHYSICAL_DEVICE_NAME_SIZE")]
        public const uint MaxPhysicalDeviceNameSize = unchecked((uint) 256);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_SHADER_MODULE_IDENTIFIER_SIZE_EXT")]
        public const uint MaxShaderModuleIdentifierSizeExt = unchecked((uint) 32);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_QUEUE_FAMILY_EXTERNAL")]
        public const uint QueueFamilyExternal = unchecked((uint) (~1U));
        [NativeName("Type", "")]
        [NativeName("Name", "VK_QUEUE_FAMILY_EXTERNAL_KHR")]
        public const uint QueueFamilyExternalKhr = unchecked((uint) (~1U));
        [NativeName("Type", "")]
        [NativeName("Name", "VK_QUEUE_FAMILY_FOREIGN_EXT")]
        public const uint QueueFamilyForeignExt = unchecked((uint) (~2U));
        [NativeName("Type", "")]
        [NativeName("Name", "VK_QUEUE_FAMILY_IGNORED")]
        public const uint QueueFamilyIgnored = unchecked((uint) (~0U));
        [NativeName("Type", "")]
        [NativeName("Name", "VK_REMAINING_3D_SLICES_EXT")]
        public const uint Remaining3DSlicesExt = unchecked((uint) (~0U));
        [NativeName("Type", "")]
        [NativeName("Name", "VK_REMAINING_ARRAY_LAYERS")]
        public const uint RemainingArrayLayers = unchecked((uint) (~0U));
        [NativeName("Type", "")]
        [NativeName("Name", "VK_REMAINING_MIP_LEVELS")]
        public const uint RemainingMipLevels = unchecked((uint) (~0U));
        [NativeName("Type", "")]
        [NativeName("Name", "VK_SHADER_UNUSED_KHR")]
        public const uint ShaderUnusedKhr = unchecked((uint) (~0U));
        [NativeName("Type", "")]
        [NativeName("Name", "VK_SHADER_UNUSED_NV")]
        public const uint ShaderUnusedNV = unchecked((uint) (~0U));
        [NativeName("Type", "")]
        [NativeName("Name", "VK_SUBPASS_EXTERNAL")]
        public const uint SubpassExternal = unchecked((uint) (~0U));
        [NativeName("Type", "")]
        [NativeName("Name", "VK_TRUE")]
        public const uint True = unchecked((uint) 1);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_UUID_SIZE")]
        public const uint UuidSize = unchecked((uint) 16);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_WHOLE_SIZE")]
        public const ulong WholeSize = unchecked((ulong) (~0ul));

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginRenderPass2", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBeginRenderPass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPassBeginInfo* pRenderPassBegin, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SubpassBeginInfo* pSubpassBeginInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawIndexedIndirectCount", Convention = CallingConvention.Winapi)]
        public partial void CmdDrawIndexedIndirectCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] Buffer countBuffer, [Count(Count = 0)] ulong countBufferOffset, [Count(Count = 0)] uint maxDrawCount, [Count(Count = 0)] uint stride);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawIndirectCount", Convention = CallingConvention.Winapi)]
        public partial void CmdDrawIndirectCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] Buffer countBuffer, [Count(Count = 0)] ulong countBufferOffset, [Count(Count = 0)] uint maxDrawCount, [Count(Count = 0)] uint stride);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdEndRenderPass2", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdEndRenderPass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SubpassEndInfo* pSubpassEndInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdNextSubpass2", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdNextSubpass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SubpassBeginInfo* pSubpassBeginInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SubpassEndInfo* pSubpassEndInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass2", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateRenderPass2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPassCreateInfo2* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] RenderPass* pRenderPass);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetBufferDeviceAddress", Convention = CallingConvention.Winapi)]
        public unsafe partial ulong GetBufferDeviceAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferDeviceAddressInfo* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetBufferOpaqueCaptureAddress", Convention = CallingConvention.Winapi)]
        public unsafe partial ulong GetBufferOpaqueCaptureAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferDeviceAddressInfo* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceMemoryOpaqueCaptureAddress", Convention = CallingConvention.Winapi)]
        public unsafe partial ulong GetDeviceMemoryOpaqueCaptureAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceMemoryOpaqueCaptureAddressInfo* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSemaphoreCounterValue", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSemaphoreCounterValue([Count(Count = 0)] Device device, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* pValue);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkResetQueryPool", Convention = CallingConvention.Winapi)]
        public partial void ResetQueryPool([Count(Count = 0)] Device device, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery, [Count(Count = 0)] uint queryCount);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkSignalSemaphore", Convention = CallingConvention.Winapi)]
        public unsafe partial Result SignalSemaphore([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SemaphoreSignalInfo* pSignalInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkWaitSemaphores", Convention = CallingConvention.Winapi)]
        public unsafe partial Result WaitSemaphores([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SemaphoreWaitInfo* pWaitInfo, [Count(Count = 0)] ulong timeout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginRendering", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBeginRendering([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderingInfo* pRenderingInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindVertexBuffers2", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pSizes, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pStrides);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBlitImage2", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBlitImage2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BlitImageInfo2* pBlitImageInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyBuffer2", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdCopyBuffer2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyBufferInfo2* pCopyBufferInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyBufferToImage2", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdCopyBufferToImage2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyBufferToImageInfo2* pCopyBufferToImageInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyImage2", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdCopyImage2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyImageInfo2* pCopyImageInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyImageToBuffer2", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdCopyImageToBuffer2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyImageToBufferInfo2* pCopyImageToBufferInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdEndRendering", Convention = CallingConvention.Winapi)]
        public partial void CmdEndRendering([Count(Count = 0)] CommandBuffer commandBuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdPipelineBarrier2", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdPipelineBarrier2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DependencyInfo* pDependencyInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdResetEvent2", Convention = CallingConvention.Winapi)]
        public partial void CmdResetEvent2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Event @event, [Count(Count = 0)] PipelineStageFlags2 stageMask);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdResolveImage2", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdResolveImage2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ResolveImageInfo2* pResolveImageInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetCullMode", Convention = CallingConvention.Winapi)]
        public partial void CmdSetCullMode([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] CullModeFlags cullMode);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthBiasEnable", Convention = CallingConvention.Winapi)]
        public partial void CmdSetDepthBiasEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 depthBiasEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthBoundsTestEnable", Convention = CallingConvention.Winapi)]
        public partial void CmdSetDepthBoundsTestEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 depthBoundsTestEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthCompareOp", Convention = CallingConvention.Winapi)]
        public partial void CmdSetDepthCompareOp([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] CompareOp depthCompareOp);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthTestEnable", Convention = CallingConvention.Winapi)]
        public partial void CmdSetDepthTestEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 depthTestEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthWriteEnable", Convention = CallingConvention.Winapi)]
        public partial void CmdSetDepthWriteEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 depthWriteEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetEvent2", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetEvent2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Event @event, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DependencyInfo* pDependencyInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetFrontFace", Convention = CallingConvention.Winapi)]
        public partial void CmdSetFrontFace([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] FrontFace frontFace);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetPrimitiveRestartEnable", Convention = CallingConvention.Winapi)]
        public partial void CmdSetPrimitiveRestartEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 primitiveRestartEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetPrimitiveTopology", Convention = CallingConvention.Winapi)]
        public partial void CmdSetPrimitiveTopology([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PrimitiveTopology primitiveTopology);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetRasterizerDiscardEnable", Convention = CallingConvention.Winapi)]
        public partial void CmdSetRasterizerDiscardEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 rasterizerDiscardEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetScissorWithCount", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetScissorWithCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint scissorCount, [Count(Parameter = "scissorCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Rect2D* pScissors);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetStencilOp", Convention = CallingConvention.Winapi)]
        public partial void CmdSetStencilOp([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] StencilFaceFlags faceMask, [Count(Count = 0)] StencilOp failOp, [Count(Count = 0)] StencilOp passOp, [Count(Count = 0)] StencilOp depthFailOp, [Count(Count = 0)] CompareOp compareOp);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetStencilTestEnable", Convention = CallingConvention.Winapi)]
        public partial void CmdSetStencilTestEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 stencilTestEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetViewportWithCount", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetViewportWithCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint viewportCount, [Count(Parameter = "viewportCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Viewport* pViewports);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWaitEvents2", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdWaitEvents2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Event* pEvents, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] DependencyInfo* pDependencyInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWriteTimestamp2", Convention = CallingConvention.Winapi)]
        public partial void CmdWriteTimestamp2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags2 stage, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint query);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePrivateDataSlot", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreatePrivateDataSlot([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrivateDataSlotCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PrivateDataSlot* pPrivateDataSlot);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyPrivateDataSlot", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyPrivateDataSlot([Count(Count = 0)] Device device, [Count(Count = 0)] PrivateDataSlot privateDataSlot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceBufferMemoryRequirements", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDeviceBufferMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceBufferMemoryRequirements* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceImageMemoryRequirements", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDeviceImageMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceImageMemoryRequirements* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceImageSparseMemoryRequirements", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDeviceImageSparseMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceImageMemoryRequirements* pInfo, [Count(Count = 0)] uint* pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SparseImageMemoryRequirements2* pSparseMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceToolProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceToolProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pToolCount, [Count(Parameter = "pToolCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PhysicalDeviceToolProperties* pToolProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPrivateData", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPrivateData([Count(Count = 0)] Device device, [Count(Count = 0)] ObjectType objectType, [Count(Count = 0)] ulong objectHandle, [Count(Count = 0)] PrivateDataSlot privateDataSlot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkQueueSubmit2", Convention = CallingConvention.Winapi)]
        public unsafe partial Result QueueSubmit2([Count(Count = 0)] Queue queue, [Count(Count = 0)] uint submitCount, [Count(Parameter = "submitCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] SubmitInfo2* pSubmits, [Count(Count = 0)] Fence fence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkSetPrivateData", Convention = CallingConvention.Winapi)]
        public partial Result SetPrivateData([Count(Count = 0)] Device device, [Count(Count = 0)] ObjectType objectType, [Count(Count = 0)] ulong objectHandle, [Count(Count = 0)] PrivateDataSlot privateDataSlot, [Count(Count = 0)] ulong data);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBindBufferMemory2", Convention = CallingConvention.Winapi)]
        public unsafe partial Result BindBufferMemory2([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Parameter = "bindInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] BindBufferMemoryInfo* pBindInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBindImageMemory2", Convention = CallingConvention.Winapi)]
        public unsafe partial Result BindImageMemory2([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Parameter = "bindInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] BindImageMemoryInfo* pBindInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDispatchBase", Convention = CallingConvention.Winapi)]
        public partial void CmdDispatchBase([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint baseGroupX, [Count(Count = 0)] uint baseGroupY, [Count(Count = 0)] uint baseGroupZ, [Count(Count = 0)] uint groupCountX, [Count(Count = 0)] uint groupCountY, [Count(Count = 0)] uint groupCountZ);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDeviceMask", Convention = CallingConvention.Winapi)]
        public partial void CmdSetDeviceMask([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint deviceMask);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorUpdateTemplate", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDescriptorUpdateTemplate([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorUpdateTemplateCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DescriptorUpdateTemplate* pDescriptorUpdateTemplate);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSamplerYcbcrConversion", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerYcbcrConversionCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SamplerYcbcrConversion* pYcbcrConversion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyDescriptorUpdateTemplate", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyDescriptorUpdateTemplate([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroySamplerYcbcrConversion", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroySamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0)] SamplerYcbcrConversion ycbcrConversion, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceVersion", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateInstanceVersion([Count(Count = 0)] uint* pApiVersion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceGroups", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumeratePhysicalDeviceGroups([Count(Count = 0)] Instance instance, [Count(Count = 0)] uint* pPhysicalDeviceGroupCount, [Count(Parameter = "pPhysicalDeviceGroupCount")] PhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetBufferMemoryRequirements2", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBufferMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferMemoryRequirementsInfo2* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDescriptorSetLayoutSupport", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDescriptorSetLayoutSupport([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorSetLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DescriptorSetLayoutSupport* pSupport);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupPeerMemoryFeatures", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDeviceGroupPeerMemoryFeatures([Count(Count = 0)] Device device, [Count(Count = 0)] uint heapIndex, [Count(Count = 0)] uint localDeviceIndex, [Count(Count = 0)] uint remoteDeviceIndex, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PeerMemoryFeatureFlags* pPeerMemoryFeatures);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceQueue2", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDeviceQueue2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceQueueInfo2* pQueueInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Queue* pQueue);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageMemoryRequirements2", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageMemoryRequirementsInfo2* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements2", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageSparseMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageSparseMemoryRequirementsInfo2* pInfo, [Count(Count = 0)] uint* pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SparseImageMemoryRequirements2* pSparseMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalBufferProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPhysicalDeviceExternalBufferProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceExternalBufferInfo* pExternalBufferInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ExternalBufferProperties* pExternalBufferProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalFenceProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPhysicalDeviceExternalFenceProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceExternalFenceInfo* pExternalFenceInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ExternalFenceProperties* pExternalFenceProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalSemaphoreProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPhysicalDeviceExternalSemaphoreProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ExternalSemaphoreProperties* pExternalSemaphoreProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFeatures2", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPhysicalDeviceFeatures2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PhysicalDeviceFeatures2* pFeatures);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFormatProperties2", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPhysicalDeviceFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] FormatProperties2* pFormatProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceImageFormatInfo2* pImageFormatInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ImageFormatProperties2* pImageFormatProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceMemoryProperties2", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPhysicalDeviceMemoryProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PhysicalDeviceMemoryProperties2* pMemoryProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceProperties2", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPhysicalDeviceProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PhysicalDeviceProperties2* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPhysicalDeviceQueueFamilyProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pQueueFamilyPropertyCount, [Count(Parameter = "pQueueFamilyPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] QueueFamilyProperties2* pQueueFamilyProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPhysicalDeviceSparseImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceSparseImageFormatInfo2* pFormatInfo, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SparseImageFormatProperties2* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkTrimCommandPool", Convention = CallingConvention.Winapi)]
        public partial void TrimCommandPool([Count(Count = 0)] Device device, [Count(Count = 0)] CommandPool commandPool, [Count(Count = 0)] uint flags);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkUpdateDescriptorSetWithTemplate", Convention = CallingConvention.Winapi)]
        public unsafe partial void UpdateDescriptorSetWithTemplate([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSet descriptorSet, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0)] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAllocateCommandBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial Result AllocateCommandBuffers([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandBufferAllocateInfo* pAllocateInfo, [Count(Computed = "pAllocateInfo->commandBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CommandBuffer* pCommandBuffers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAllocateDescriptorSets", Convention = CallingConvention.Winapi)]
        public unsafe partial Result AllocateDescriptorSets([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorSetAllocateInfo* pAllocateInfo, [Count(Computed = "pAllocateInfo->descriptorSetCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DescriptorSet* pDescriptorSets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAllocateMemory", Convention = CallingConvention.Winapi)]
        public unsafe partial Result AllocateMemory([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryAllocateInfo* pAllocateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DeviceMemory* pMemory);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBeginCommandBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial Result BeginCommandBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandBufferBeginInfo* pBeginInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBindBufferMemory", Convention = CallingConvention.Winapi)]
        public partial Result BindBufferMemory([Count(Count = 0)] Device device, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0)] ulong memoryOffset);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBindImageMemory", Convention = CallingConvention.Winapi)]
        public partial Result BindImageMemory([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0)] ulong memoryOffset);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginQuery", Convention = CallingConvention.Winapi)]
        public partial void CmdBeginQuery([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint query, [Count(Count = 0)] QueryControlFlags flags);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginRenderPass", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBeginRenderPass([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPassBeginInfo* pRenderPassBegin, [Count(Count = 0)] SubpassContents contents);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindDescriptorSets", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBindDescriptorSets([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint firstSet, [Count(Count = 0)] uint descriptorSetCount, [Count(Parameter = "descriptorSetCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorSet* pDescriptorSets, [Count(Count = 0)] uint dynamicOffsetCount, [Count(Parameter = "dynamicOffsetCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pDynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindIndexBuffer", Convention = CallingConvention.Winapi)]
        public partial void CmdBindIndexBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] IndexType indexType);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindPipeline", Convention = CallingConvention.Winapi)]
        public partial void CmdBindPipeline([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] Pipeline pipeline);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindVertexBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBindVertexBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pOffsets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBlitImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBlitImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Parameter = "regionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageBlit* pRegions, [Count(Count = 0)] Filter filter);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdClearAttachments", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdClearAttachments([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint attachmentCount, [Count(Parameter = "attachmentCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearAttachment* pAttachments, [Count(Count = 0)] uint rectCount, [Count(Parameter = "rectCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearRect* pRects);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdClearColorImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdClearColorImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image image, [Count(Count = 0)] ImageLayout imageLayout, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearColorValue* pColor, [Count(Count = 0)] uint rangeCount, [Count(Parameter = "rangeCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageSubresourceRange* pRanges);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdClearDepthStencilImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdClearDepthStencilImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image image, [Count(Count = 0)] ImageLayout imageLayout, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearDepthStencilValue* pDepthStencil, [Count(Count = 0)] uint rangeCount, [Count(Parameter = "rangeCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageSubresourceRange* pRanges);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdCopyBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer srcBuffer, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] uint regionCount, [Count(Parameter = "regionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferCopy* pRegions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyBufferToImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdCopyBufferToImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer srcBuffer, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Parameter = "regionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferImageCopy* pRegions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdCopyImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Parameter = "regionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopy* pRegions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyImageToBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdCopyImageToBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] uint regionCount, [Count(Parameter = "regionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferImageCopy* pRegions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyQueryPoolResults", Convention = CallingConvention.Winapi)]
        public partial void CmdCopyQueryPoolResults([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery, [Count(Count = 0)] uint queryCount, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] ulong dstOffset, [Count(Count = 0)] ulong stride, [Count(Count = 0)] QueryResultFlags flags);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDispatch", Convention = CallingConvention.Winapi)]
        public partial void CmdDispatch([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint groupCountX, [Count(Count = 0)] uint groupCountY, [Count(Count = 0)] uint groupCountZ);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDispatchIndirect", Convention = CallingConvention.Winapi)]
        public partial void CmdDispatchIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDraw", Convention = CallingConvention.Winapi)]
        public partial void CmdDraw([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint vertexCount, [Count(Count = 0)] uint instanceCount, [Count(Count = 0)] uint firstVertex, [Count(Count = 0)] uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawIndexed", Convention = CallingConvention.Winapi)]
        public partial void CmdDrawIndexed([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint indexCount, [Count(Count = 0)] uint instanceCount, [Count(Count = 0)] uint firstIndex, [Count(Count = 0)] int vertexOffset, [Count(Count = 0)] uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawIndexedIndirect", Convention = CallingConvention.Winapi)]
        public partial void CmdDrawIndexedIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] uint drawCount, [Count(Count = 0)] uint stride);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawIndirect", Convention = CallingConvention.Winapi)]
        public partial void CmdDrawIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] uint drawCount, [Count(Count = 0)] uint stride);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdEndQuery", Convention = CallingConvention.Winapi)]
        public partial void CmdEndQuery([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint query);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdEndRenderPass", Convention = CallingConvention.Winapi)]
        public partial void CmdEndRenderPass([Count(Count = 0)] CommandBuffer commandBuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdExecuteCommands", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdExecuteCommands([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint commandBufferCount, [Count(Parameter = "commandBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandBuffer* pCommandBuffers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdFillBuffer", Convention = CallingConvention.Winapi)]
        public partial void CmdFillBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] ulong dstOffset, [Count(Count = 0)] ulong size, [Count(Count = 0)] uint data);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdNextSubpass", Convention = CallingConvention.Winapi)]
        public partial void CmdNextSubpass([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] SubpassContents contents);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdPipelineBarrier", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdPipelineBarrier([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] DependencyFlags dependencyFlags, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdPushConstants", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdPushConstants([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] ShaderStageFlags stageFlags, [Count(Count = 0)] uint offset, [Count(Count = 0)] uint size, [Count(Parameter = "size")] void* pValues);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdResetEvent", Convention = CallingConvention.Winapi)]
        public partial void CmdResetEvent([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Event @event, [Count(Count = 0)] PipelineStageFlags stageMask);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdResetQueryPool", Convention = CallingConvention.Winapi)]
        public partial void CmdResetQueryPool([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery, [Count(Count = 0)] uint queryCount);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdResolveImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdResolveImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Parameter = "regionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageResolve* pRegions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetBlendConstants", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetBlendConstants([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* blendConstants);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthBias", Convention = CallingConvention.Winapi)]
        public partial void CmdSetDepthBias([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] float depthBiasConstantFactor, [Count(Count = 0)] float depthBiasClamp, [Count(Count = 0)] float depthBiasSlopeFactor);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthBounds", Convention = CallingConvention.Winapi)]
        public partial void CmdSetDepthBounds([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] float minDepthBounds, [Count(Count = 0)] float maxDepthBounds);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetEvent", Convention = CallingConvention.Winapi)]
        public partial void CmdSetEvent([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Event @event, [Count(Count = 0)] PipelineStageFlags stageMask);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetLineWidth", Convention = CallingConvention.Winapi)]
        public partial void CmdSetLineWidth([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] float lineWidth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetScissor", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetScissor([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstScissor, [Count(Count = 0)] uint scissorCount, [Count(Parameter = "scissorCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Rect2D* pScissors);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetStencilCompareMask", Convention = CallingConvention.Winapi)]
        public partial void CmdSetStencilCompareMask([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] StencilFaceFlags faceMask, [Count(Count = 0)] uint compareMask);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetStencilReference", Convention = CallingConvention.Winapi)]
        public partial void CmdSetStencilReference([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] StencilFaceFlags faceMask, [Count(Count = 0)] uint reference);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetStencilWriteMask", Convention = CallingConvention.Winapi)]
        public partial void CmdSetStencilWriteMask([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] StencilFaceFlags faceMask, [Count(Count = 0)] uint writeMask);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetViewport", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetViewport([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstViewport, [Count(Count = 0)] uint viewportCount, [Count(Parameter = "viewportCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Viewport* pViewports);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdUpdateBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdUpdateBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] ulong dstOffset, [Count(Count = 0)] ulong dataSize, [Count(Parameter = "dataSize")] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWaitEvents", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Event* pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWriteTimestamp", Convention = CallingConvention.Winapi)]
        public partial void CmdWriteTimestamp([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags pipelineStage, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint query);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateBuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Buffer* pBuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateBufferView", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateBufferView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferViewCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] BufferView* pView);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCommandPool", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateCommandPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandPoolCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CommandPool* pCommandPool);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateComputePipelines", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateComputePipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineCreateInfo* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorPool", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDescriptorPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorPoolCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DescriptorPool* pDescriptorPool);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorSetLayout", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDescriptorSetLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorSetLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DescriptorSetLayout* pSetLayout);

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentDevice = *%$PARAM(pDevice)$%; }")]
        [NativeApi(EntryPoint = "vkCreateDevice", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDevice([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Device* pDevice);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateEvent", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateEvent([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] EventCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Event* pEvent);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateFence", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateFence([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FenceCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Fence* pFence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateFramebuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateFramebuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Framebuffer* pFramebuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateGraphicsPipelines", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateGraphicsPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] GraphicsPipelineCreateInfo* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateImage", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateImage([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Image* pImage);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateImageView", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateImageView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageViewCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ImageView* pView);

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentInstance = *%$PARAM(pInstance)$%; }")]
        [NativeApi(EntryPoint = "vkCreateInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateInstance([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InstanceCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Instance* pInstance);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePipelineCache", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreatePipelineCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineCacheCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PipelineCache* pPipelineCache);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePipelineLayout", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreatePipelineLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PipelineLayout* pPipelineLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateQueryPool", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateQueryPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryPoolCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] QueryPool* pQueryPool);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateRenderPass([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPassCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] RenderPass* pRenderPass);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSampler", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSampler([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Sampler* pSampler);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSemaphore", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSemaphore([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SemaphoreCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Semaphore* pSemaphore);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateShaderModule", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateShaderModule([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderModuleCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ShaderModule* pShaderModule);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyBuffer([Count(Count = 0)] Device device, [Count(Count = 0)] Buffer buffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyBufferView", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyBufferView([Count(Count = 0)] Device device, [Count(Count = 0)] BufferView bufferView, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyCommandPool", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyCommandPool([Count(Count = 0)] Device device, [Count(Count = 0)] CommandPool commandPool, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyDescriptorPool", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyDescriptorPool([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorPool descriptorPool, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyDescriptorSetLayout", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyDescriptorSetLayout([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSetLayout descriptorSetLayout, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyDevice", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyDevice([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyEvent", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyEvent([Count(Count = 0)] Device device, [Count(Count = 0)] Event @event, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyFence", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyFence([Count(Count = 0)] Device device, [Count(Count = 0)] Fence fence, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyFramebuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyFramebuffer([Count(Count = 0)] Device device, [Count(Count = 0)] Framebuffer framebuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyImage([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyImageView", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyImageView([Count(Count = 0)] Device device, [Count(Count = 0)] ImageView imageView, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyInstance([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyPipeline", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyPipeline([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyPipelineCache", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyPipelineCache([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyPipelineLayout", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyPipelineLayout([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineLayout pipelineLayout, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyQueryPool", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyQueryPool([Count(Count = 0)] Device device, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyRenderPass", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyRenderPass([Count(Count = 0)] Device device, [Count(Count = 0)] RenderPass renderPass, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroySampler", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroySampler([Count(Count = 0)] Device device, [Count(Count = 0)] Sampler sampler, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroySemaphore", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroySemaphore([Count(Count = 0)] Device device, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyShaderModule", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyShaderModule([Count(Count = 0)] Device device, [Count(Count = 0)] ShaderModule shaderModule, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDeviceWaitIdle", Convention = CallingConvention.Winapi)]
        public partial Result DeviceWaitIdle([Count(Count = 0)] Device device);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEndCommandBuffer", Convention = CallingConvention.Winapi)]
        public partial Result EndCommandBuffer([Count(Count = 0)] CommandBuffer commandBuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceExtensionProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateDeviceExtensionProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pLayerName, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount")] ExtensionProperties* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceLayerProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateDeviceLayerProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount")] LayerProperties* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceExtensionProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pLayerName, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount")] ExtensionProperties* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceLayerProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateInstanceLayerProperties([Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount")] LayerProperties* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDevices", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumeratePhysicalDevices([Count(Count = 0)] Instance instance, [Count(Count = 0)] uint* pPhysicalDeviceCount, [Count(Parameter = "pPhysicalDeviceCount")] PhysicalDevice* pPhysicalDevices);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkFlushMappedMemoryRanges", Convention = CallingConvention.Winapi)]
        public unsafe partial Result FlushMappedMemoryRanges([Count(Count = 0)] Device device, [Count(Count = 0)] uint memoryRangeCount, [Count(Parameter = "memoryRangeCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] MappedMemoryRange* pMemoryRanges);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkFreeCommandBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void FreeCommandBuffers([Count(Count = 0)] Device device, [Count(Count = 0)] CommandPool commandPool, [Count(Count = 0)] uint commandBufferCount, [Count(Parameter = "commandBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandBuffer* pCommandBuffers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkFreeDescriptorSets", Convention = CallingConvention.Winapi)]
        public unsafe partial Result FreeDescriptorSets([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorPool descriptorPool, [Count(Count = 0)] uint descriptorSetCount, [Count(Parameter = "descriptorSetCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorSet* pDescriptorSets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkFreeMemory", Convention = CallingConvention.Winapi)]
        public unsafe partial void FreeMemory([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetBufferMemoryRequirements", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBufferMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0)] Buffer buffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements* pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceMemoryCommitment", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDeviceMemoryCommitment([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* pCommittedMemoryInBytes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceProcAddr", Convention = CallingConvention.Winapi)]
        public unsafe partial PfnVoidFunction GetDeviceProcAddr([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pName);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceQueue", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDeviceQueue([Count(Count = 0)] Device device, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint queueIndex, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Queue* pQueue);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetEventStatus", Convention = CallingConvention.Winapi)]
        public partial Result GetEventStatus([Count(Count = 0)] Device device, [Count(Count = 0)] Event @event);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetFenceStatus", Convention = CallingConvention.Winapi)]
        public partial Result GetFenceStatus([Count(Count = 0)] Device device, [Count(Count = 0)] Fence fence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageMemoryRequirements", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements* pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageSparseMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0)] uint* pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SparseImageMemoryRequirements* pSparseMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageSubresourceLayout", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageSubresourceLayout([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageSubresource* pSubresource, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SubresourceLayout* pLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetInstanceProcAddr", Convention = CallingConvention.Winapi)]
        public unsafe partial PfnVoidFunction GetInstanceProcAddr([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pName);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFeatures", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPhysicalDeviceFeatures([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PhysicalDeviceFeatures* pFeatures);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFormatProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPhysicalDeviceFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] FormatProperties* pFormatProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceImageFormatProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceImageFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageType type, [Count(Count = 0)] ImageTiling tiling, [Count(Count = 0)] ImageUsageFlags usage, [Count(Count = 0)] ImageCreateFlags flags, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ImageFormatProperties* pImageFormatProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceMemoryProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPhysicalDeviceMemoryProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PhysicalDeviceMemoryProperties* pMemoryProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPhysicalDeviceProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PhysicalDeviceProperties* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPhysicalDeviceQueueFamilyProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pQueueFamilyPropertyCount, [Count(Parameter = "pQueueFamilyPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] QueueFamilyProperties* pQueueFamilyProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPhysicalDeviceSparseImageFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageType type, [Count(Count = 0)] SampleCountFlags samples, [Count(Count = 0)] ImageUsageFlags usage, [Count(Count = 0)] ImageTiling tiling, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SparseImageFormatProperties* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineCacheData", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPipelineCacheData([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] nuint* pDataSize, [Count(Parameter = "pDataSize")] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetQueryPoolResults", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetQueryPoolResults([Count(Count = 0)] Device device, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery, [Count(Count = 0)] uint queryCount, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] void* pData, [Count(Count = 0)] ulong stride, [Count(Count = 0)] QueryResultFlags flags);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetRenderAreaGranularity", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetRenderAreaGranularity([Count(Count = 0)] Device device, [Count(Count = 0)] RenderPass renderPass, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Extent2D* pGranularity);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkInvalidateMappedMemoryRanges", Convention = CallingConvention.Winapi)]
        public unsafe partial Result InvalidateMappedMemoryRanges([Count(Count = 0)] Device device, [Count(Count = 0)] uint memoryRangeCount, [Count(Parameter = "memoryRangeCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] MappedMemoryRange* pMemoryRanges);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkMapMemory", Convention = CallingConvention.Winapi)]
        public unsafe partial Result MapMemory([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0)] ulong offset, [Count(Count = 0)] ulong size, [Count(Count = 0)] uint flags, [Count(Count = 0)] void** ppData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkMergePipelineCaches", Convention = CallingConvention.Winapi)]
        public unsafe partial Result MergePipelineCaches([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache dstCache, [Count(Count = 0)] uint srcCacheCount, [Count(Parameter = "srcCacheCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineCache* pSrcCaches);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkQueueBindSparse", Convention = CallingConvention.Winapi)]
        public unsafe partial Result QueueBindSparse([Count(Count = 0)] Queue queue, [Count(Count = 0)] uint bindInfoCount, [Count(Parameter = "bindInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] BindSparseInfo* pBindInfo, [Count(Count = 0)] Fence fence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkQueueSubmit", Convention = CallingConvention.Winapi)]
        public unsafe partial Result QueueSubmit([Count(Count = 0)] Queue queue, [Count(Count = 0)] uint submitCount, [Count(Parameter = "submitCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] SubmitInfo* pSubmits, [Count(Count = 0)] Fence fence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkQueueWaitIdle", Convention = CallingConvention.Winapi)]
        public partial Result QueueWaitIdle([Count(Count = 0)] Queue queue);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkResetCommandBuffer", Convention = CallingConvention.Winapi)]
        public partial Result ResetCommandBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] CommandBufferResetFlags flags);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkResetCommandPool", Convention = CallingConvention.Winapi)]
        public partial Result ResetCommandPool([Count(Count = 0)] Device device, [Count(Count = 0)] CommandPool commandPool, [Count(Count = 0)] CommandPoolResetFlags flags);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkResetDescriptorPool", Convention = CallingConvention.Winapi)]
        public partial Result ResetDescriptorPool([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorPool descriptorPool, [Count(Count = 0)] uint flags);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkResetEvent", Convention = CallingConvention.Winapi)]
        public partial Result ResetEvent([Count(Count = 0)] Device device, [Count(Count = 0)] Event @event);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkResetFences", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ResetFences([Count(Count = 0)] Device device, [Count(Count = 0)] uint fenceCount, [Count(Parameter = "fenceCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Fence* pFences);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkSetEvent", Convention = CallingConvention.Winapi)]
        public partial Result SetEvent([Count(Count = 0)] Device device, [Count(Count = 0)] Event @event);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkUnmapMemory", Convention = CallingConvention.Winapi)]
        public partial void UnmapMemory([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkUpdateDescriptorSets", Convention = CallingConvention.Winapi)]
        public unsafe partial void UpdateDescriptorSets([Count(Count = 0)] Device device, [Count(Count = 0)] uint descriptorWriteCount, [Count(Parameter = "descriptorWriteCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] WriteDescriptorSet* pDescriptorWrites, [Count(Count = 0)] uint descriptorCopyCount, [Count(Parameter = "descriptorCopyCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyDescriptorSet* pDescriptorCopies);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkWaitForFences", Convention = CallingConvention.Winapi)]
        public unsafe partial Result WaitForFences([Count(Count = 0)] Device device, [Count(Count = 0)] uint fenceCount, [Count(Parameter = "fenceCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Fence* pFences, [Count(Count = 0)] Bool32 waitAll, [Count(Count = 0)] ulong timeout);


        public Vk(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

