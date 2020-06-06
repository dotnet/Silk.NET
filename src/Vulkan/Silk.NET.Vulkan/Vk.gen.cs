// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe partial class Vk : NativeAPI
    {
        public const uint AttachmentUnused = (~0U);
        public const uint False = 0;
        public const float LodClampNone = 1000.0f;
        public const uint LuidSize = 8;
        public const uint LuidSizeKhr = 8;
        public const uint MaxDescriptionSize = 256;
        public const uint MaxDeviceGroupSize = 32;
        public const uint MaxDeviceGroupSizeKhr = 32;
        public const uint MaxDriverInfoSize = 256;
        public const uint MaxDriverInfoSizeKhr = 256;
        public const uint MaxDriverNameSize = 256;
        public const uint MaxDriverNameSizeKhr = 256;
        public const uint MaxExtensionNameSize = 256;
        public const uint MaxMemoryHeaps = 16;
        public const uint MaxMemoryTypes = 32;
        public const uint MaxPhysicalDeviceNameSize = 256;
        public const uint QueueFamilyExternal = (~0U-1);
        public const uint QueueFamilyExternalKhr = (~0U-1);
        public const uint QueueFamilyForeignExt = (~0U-2);
        public const uint QueueFamilyIgnored = (~0U);
        public const uint RemainingArrayLayers = (~0U);
        public const uint RemainingMipLevels = (~0U);
        public const uint ShaderUnusedKhr = (~0U);
        public const uint ShaderUnusedNV = (~0U);
        public const uint SubpassExternal = (~0U);
        public const uint True = 1;
        public const uint UuidSize = 16;
        public const ulong WholeSize = (~0ul);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAllocateCommandBuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result AllocateCommandBuffers([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] CommandBufferAllocateInfo* pAllocateInfo, [Count(Computed = "pAllocateInfo->commandBufferCount"), Flow(FlowDirection.Out)] CommandBuffer* pCommandBuffers)
            => ImplAllocateCommandBuffers(device, pAllocateInfo, pCommandBuffers);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAllocateCommandBuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result AllocateCommandBuffers([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref CommandBufferAllocateInfo pAllocateInfo, [Count(Computed = "pAllocateInfo->commandBufferCount"), Flow(FlowDirection.Out)] out CommandBuffer pCommandBuffers)
            => ImplAllocateCommandBuffers(device, pAllocateInfo, pCommandBuffers);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAllocateDescriptorSets")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result AllocateDescriptorSets([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorSetAllocateInfo* pAllocateInfo, [Count(Computed = "pAllocateInfo->descriptorSetCount"), Flow(FlowDirection.Out)] DescriptorSet* pDescriptorSets)
            => ImplAllocateDescriptorSets(device, pAllocateInfo, pDescriptorSets);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAllocateDescriptorSets")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result AllocateDescriptorSets([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DescriptorSetAllocateInfo pAllocateInfo, [Count(Computed = "pAllocateInfo->descriptorSetCount"), Flow(FlowDirection.Out)] out DescriptorSet pDescriptorSets)
            => ImplAllocateDescriptorSets(device, pAllocateInfo, pDescriptorSets);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAllocateMemory")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result AllocateMemory([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] MemoryAllocateInfo* pAllocateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DeviceMemory* pMemory)
            => ImplAllocateMemory(device, pAllocateInfo, pAllocator, pMemory);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAllocateMemory")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result AllocateMemory([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref MemoryAllocateInfo pAllocateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DeviceMemory pMemory)
            => ImplAllocateMemory(device, pAllocateInfo, pAllocator, pMemory);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBeginCommandBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result BeginCommandBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] CommandBufferBeginInfo* pBeginInfo)
            => ImplBeginCommandBuffer(commandBuffer, pBeginInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBeginCommandBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result BeginCommandBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref CommandBufferBeginInfo pBeginInfo)
            => ImplBeginCommandBuffer(commandBuffer, pBeginInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBindBufferMemory")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result BindBufferMemory([Count(Count = 0)] Device device, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0)] ulong memoryOffset)
            => ImplBindBufferMemory(device, buffer, memory, memoryOffset);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBindImageMemory")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result BindImageMemory([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0)] ulong memoryOffset)
            => ImplBindImageMemory(device, image, memory, memoryOffset);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginQuery")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdBeginQuery([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint query, [Count(Count = 0)] QueryControlFlags flags)
            => ImplCmdBeginQuery(commandBuffer, queryPool, query, flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginRenderPass")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdBeginRenderPass([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] RenderPassBeginInfo* pRenderPassBegin, [Count(Count = 0)] SubpassContents contents)
            => ImplCmdBeginRenderPass(commandBuffer, pRenderPassBegin, contents);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginRenderPass")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdBeginRenderPass([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref RenderPassBeginInfo pRenderPassBegin, [Count(Count = 0)] SubpassContents contents)
            => ImplCmdBeginRenderPass(commandBuffer, pRenderPassBegin, contents);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBindDescriptorSets")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdBindDescriptorSets([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint firstSet, [Count(Count = 0)] uint descriptorSetCount, [Count(Computed = "descriptorSetCount"), Flow(FlowDirection.In)] DescriptorSet* pDescriptorSets, [Count(Count = 0)] uint dynamicOffsetCount, [Count(Computed = "dynamicOffsetCount"), Flow(FlowDirection.In)] uint* pDynamicOffsets)
            => ImplCmdBindDescriptorSets(commandBuffer, pipelineBindPoint, layout, firstSet, descriptorSetCount, pDescriptorSets, dynamicOffsetCount, pDynamicOffsets);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBindDescriptorSets")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdBindDescriptorSets([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint firstSet, [Count(Count = 0)] uint descriptorSetCount, [Count(Computed = "descriptorSetCount"), Flow(FlowDirection.In)] ref DescriptorSet pDescriptorSets, [Count(Count = 0)] uint dynamicOffsetCount, [Count(Computed = "dynamicOffsetCount"), Flow(FlowDirection.In)] ref uint pDynamicOffsets)
            => ImplCmdBindDescriptorSets(commandBuffer, pipelineBindPoint, layout, firstSet, descriptorSetCount, pDescriptorSets, dynamicOffsetCount, pDynamicOffsets);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBindIndexBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdBindIndexBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] IndexType indexType)
            => ImplCmdBindIndexBuffer(commandBuffer, buffer, offset, indexType);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBindPipeline")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdBindPipeline([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] Pipeline pipeline)
            => ImplCmdBindPipeline(commandBuffer, pipelineBindPoint, pipeline);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBindVertexBuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdBindVertexBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets)
            => ImplCmdBindVertexBuffers(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBindVertexBuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdBindVertexBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ref Buffer pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ref ulong pOffsets)
            => ImplCmdBindVertexBuffers(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBlitImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdBlitImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] ImageBlit* pRegions, [Count(Count = 0)] Filter filter)
            => ImplCmdBlitImage(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions, filter);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBlitImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdBlitImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] ref ImageBlit pRegions, [Count(Count = 0)] Filter filter)
            => ImplCmdBlitImage(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions, filter);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdClearAttachments")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdClearAttachments([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint attachmentCount, [Count(Computed = "attachmentCount"), Flow(FlowDirection.In)] ClearAttachment* pAttachments, [Count(Count = 0)] uint rectCount, [Count(Computed = "rectCount"), Flow(FlowDirection.In)] ClearRect* pRects)
            => ImplCmdClearAttachments(commandBuffer, attachmentCount, pAttachments, rectCount, pRects);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdClearAttachments")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdClearAttachments([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint attachmentCount, [Count(Computed = "attachmentCount"), Flow(FlowDirection.In)] ref ClearAttachment pAttachments, [Count(Count = 0)] uint rectCount, [Count(Computed = "rectCount"), Flow(FlowDirection.In)] ref ClearRect pRects)
            => ImplCmdClearAttachments(commandBuffer, attachmentCount, pAttachments, rectCount, pRects);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdClearColorImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdClearColorImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image image, [Count(Count = 0)] ImageLayout imageLayout, [Count(Count = 0), Flow(FlowDirection.In)] ClearColorValue* pColor, [Count(Count = 0)] uint rangeCount, [Count(Computed = "rangeCount"), Flow(FlowDirection.In)] ImageSubresourceRange* pRanges)
            => ImplCmdClearColorImage(commandBuffer, image, imageLayout, pColor, rangeCount, pRanges);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdClearColorImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdClearColorImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image image, [Count(Count = 0)] ImageLayout imageLayout, [Count(Count = 0), Flow(FlowDirection.In)] ref ClearColorValue pColor, [Count(Count = 0)] uint rangeCount, [Count(Computed = "rangeCount"), Flow(FlowDirection.In)] ref ImageSubresourceRange pRanges)
            => ImplCmdClearColorImage(commandBuffer, image, imageLayout, pColor, rangeCount, pRanges);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdClearDepthStencilImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdClearDepthStencilImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image image, [Count(Count = 0)] ImageLayout imageLayout, [Count(Count = 0), Flow(FlowDirection.In)] ClearDepthStencilValue* pDepthStencil, [Count(Count = 0)] uint rangeCount, [Count(Computed = "rangeCount"), Flow(FlowDirection.In)] ImageSubresourceRange* pRanges)
            => ImplCmdClearDepthStencilImage(commandBuffer, image, imageLayout, pDepthStencil, rangeCount, pRanges);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdClearDepthStencilImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdClearDepthStencilImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image image, [Count(Count = 0)] ImageLayout imageLayout, [Count(Count = 0), Flow(FlowDirection.In)] ref ClearDepthStencilValue pDepthStencil, [Count(Count = 0)] uint rangeCount, [Count(Computed = "rangeCount"), Flow(FlowDirection.In)] ref ImageSubresourceRange pRanges)
            => ImplCmdClearDepthStencilImage(commandBuffer, image, imageLayout, pDepthStencil, rangeCount, pRanges);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdCopyBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer srcBuffer, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] BufferCopy* pRegions)
            => ImplCmdCopyBuffer(commandBuffer, srcBuffer, dstBuffer, regionCount, pRegions);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdCopyBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer srcBuffer, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] ref BufferCopy pRegions)
            => ImplCmdCopyBuffer(commandBuffer, srcBuffer, dstBuffer, regionCount, pRegions);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyBufferToImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdCopyBufferToImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer srcBuffer, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] BufferImageCopy* pRegions)
            => ImplCmdCopyBufferToImage(commandBuffer, srcBuffer, dstImage, dstImageLayout, regionCount, pRegions);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyBufferToImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdCopyBufferToImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer srcBuffer, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] ref BufferImageCopy pRegions)
            => ImplCmdCopyBufferToImage(commandBuffer, srcBuffer, dstImage, dstImageLayout, regionCount, pRegions);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdCopyImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] ImageCopy* pRegions)
            => ImplCmdCopyImage(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdCopyImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] ref ImageCopy pRegions)
            => ImplCmdCopyImage(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyImageToBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdCopyImageToBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] BufferImageCopy* pRegions)
            => ImplCmdCopyImageToBuffer(commandBuffer, srcImage, srcImageLayout, dstBuffer, regionCount, pRegions);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyImageToBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdCopyImageToBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] ref BufferImageCopy pRegions)
            => ImplCmdCopyImageToBuffer(commandBuffer, srcImage, srcImageLayout, dstBuffer, regionCount, pRegions);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyQueryPoolResults")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdCopyQueryPoolResults([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery, [Count(Count = 0)] uint queryCount, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] ulong dstOffset, [Count(Count = 0)] ulong stride, [Count(Count = 0)] QueryResultFlags flags)
            => ImplCmdCopyQueryPoolResults(commandBuffer, queryPool, firstQuery, queryCount, dstBuffer, dstOffset, stride, flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDispatch")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdDispatch([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint groupCountX, [Count(Count = 0)] uint groupCountY, [Count(Count = 0)] uint groupCountZ)
            => ImplCmdDispatch(commandBuffer, groupCountX, groupCountY, groupCountZ);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDispatchIndirect")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdDispatchIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset)
            => ImplCmdDispatchIndirect(commandBuffer, buffer, offset);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDraw")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdDraw([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint vertexCount, [Count(Count = 0)] uint instanceCount, [Count(Count = 0)] uint firstVertex, [Count(Count = 0)] uint firstInstance)
            => ImplCmdDraw(commandBuffer, vertexCount, instanceCount, firstVertex, firstInstance);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawIndexed")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdDrawIndexed([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint indexCount, [Count(Count = 0)] uint instanceCount, [Count(Count = 0)] uint firstIndex, [Count(Count = 0)] int vertexOffset, [Count(Count = 0)] uint firstInstance)
            => ImplCmdDrawIndexed(commandBuffer, indexCount, instanceCount, firstIndex, vertexOffset, firstInstance);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawIndexedIndirect")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdDrawIndexedIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] uint drawCount, [Count(Count = 0)] uint stride)
            => ImplCmdDrawIndexedIndirect(commandBuffer, buffer, offset, drawCount, stride);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawIndirect")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdDrawIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] uint drawCount, [Count(Count = 0)] uint stride)
            => ImplCmdDrawIndirect(commandBuffer, buffer, offset, drawCount, stride);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdEndQuery")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdEndQuery([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint query)
            => ImplCmdEndQuery(commandBuffer, queryPool, query);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdEndRenderPass")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdEndRenderPass([Count(Count = 0)] CommandBuffer commandBuffer)
            => ImplCmdEndRenderPass(commandBuffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdExecuteCommands")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdExecuteCommands([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint commandBufferCount, [Count(Computed = "commandBufferCount"), Flow(FlowDirection.In)] CommandBuffer* pCommandBuffers)
            => ImplCmdExecuteCommands(commandBuffer, commandBufferCount, pCommandBuffers);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdExecuteCommands")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdExecuteCommands([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint commandBufferCount, [Count(Computed = "commandBufferCount"), Flow(FlowDirection.In)] ref CommandBuffer pCommandBuffers)
            => ImplCmdExecuteCommands(commandBuffer, commandBufferCount, pCommandBuffers);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdFillBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdFillBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] ulong dstOffset, [Count(Count = 0)] ulong size, [Count(Count = 0)] uint data)
            => ImplCmdFillBuffer(commandBuffer, dstBuffer, dstOffset, size, data);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdNextSubpass")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdNextSubpass([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] SubpassContents contents)
            => ImplCmdNextSubpass(commandBuffer, contents);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdPipelineBarrier")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdPipelineBarrier([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] DependencyFlags dependencyFlags, [Count(Count = 0)] uint memoryBarrierCount, [Count(Computed = "memoryBarrierCount"), Flow(FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Computed = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Computed = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers)
            => ImplCmdPipelineBarrier(commandBuffer, srcStageMask, dstStageMask, dependencyFlags, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdPipelineBarrier")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdPipelineBarrier([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] DependencyFlags dependencyFlags, [Count(Count = 0)] uint memoryBarrierCount, [Count(Computed = "memoryBarrierCount"), Flow(FlowDirection.In)] ref MemoryBarrier pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Computed = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] ref BufferMemoryBarrier pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Computed = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ref ImageMemoryBarrier pImageMemoryBarriers)
            => ImplCmdPipelineBarrier(commandBuffer, srcStageMask, dstStageMask, dependencyFlags, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdPushConstants")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdPushConstants([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] ShaderStageFlags stageFlags, [Count(Count = 0)] uint offset, [Count(Count = 0)] uint size, [Count(Computed = "size")] void* pValues)
            => ImplCmdPushConstants(commandBuffer, layout, stageFlags, offset, size, pValues);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdPushConstants")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdPushConstants<T0>([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] ShaderStageFlags stageFlags, [Count(Count = 0)] uint offset, [Count(Count = 0)] uint size, [Count(Computed = "size")] ref T0 pValues) where T0 : unmanaged
            => ImplCmdPushConstants<T0>(commandBuffer, layout, stageFlags, offset, size, pValues);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdResetEvent")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdResetEvent([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Event @event, [Count(Count = 0)] PipelineStageFlags stageMask)
            => ImplCmdResetEvent(commandBuffer, @event, stageMask);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdResetQueryPool")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdResetQueryPool([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery, [Count(Count = 0)] uint queryCount)
            => ImplCmdResetQueryPool(commandBuffer, queryPool, firstQuery, queryCount);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdResolveImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdResolveImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] ImageResolve* pRegions)
            => ImplCmdResolveImage(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdResolveImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdResolveImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] ref ImageResolve pRegions)
            => ImplCmdResolveImage(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetBlendConstants")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdSetBlendConstants([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] float blendConstants)
            => ImplCmdSetBlendConstants(commandBuffer, blendConstants);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthBias")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdSetDepthBias([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] float depthBiasConstantFactor, [Count(Count = 0)] float depthBiasClamp, [Count(Count = 0)] float depthBiasSlopeFactor)
            => ImplCmdSetDepthBias(commandBuffer, depthBiasConstantFactor, depthBiasClamp, depthBiasSlopeFactor);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthBounds")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdSetDepthBounds([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] float minDepthBounds, [Count(Count = 0)] float maxDepthBounds)
            => ImplCmdSetDepthBounds(commandBuffer, minDepthBounds, maxDepthBounds);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetEvent")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdSetEvent([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Event @event, [Count(Count = 0)] PipelineStageFlags stageMask)
            => ImplCmdSetEvent(commandBuffer, @event, stageMask);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetLineWidth")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdSetLineWidth([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] float lineWidth)
            => ImplCmdSetLineWidth(commandBuffer, lineWidth);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetScissor")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdSetScissor([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstScissor, [Count(Count = 0)] uint scissorCount, [Count(Computed = "scissorCount"), Flow(FlowDirection.In)] Rect2D* pScissors)
            => ImplCmdSetScissor(commandBuffer, firstScissor, scissorCount, pScissors);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetScissor")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdSetScissor([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstScissor, [Count(Count = 0)] uint scissorCount, [Count(Computed = "scissorCount"), Flow(FlowDirection.In)] ref Rect2D pScissors)
            => ImplCmdSetScissor(commandBuffer, firstScissor, scissorCount, pScissors);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetStencilCompareMask")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdSetStencilCompareMask([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] StencilFaceFlags faceMask, [Count(Count = 0)] uint compareMask)
            => ImplCmdSetStencilCompareMask(commandBuffer, faceMask, compareMask);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetStencilReference")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdSetStencilReference([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] StencilFaceFlags faceMask, [Count(Count = 0)] uint reference)
            => ImplCmdSetStencilReference(commandBuffer, faceMask, reference);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetStencilWriteMask")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdSetStencilWriteMask([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] StencilFaceFlags faceMask, [Count(Count = 0)] uint writeMask)
            => ImplCmdSetStencilWriteMask(commandBuffer, faceMask, writeMask);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetViewport")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdSetViewport([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstViewport, [Count(Count = 0)] uint viewportCount, [Count(Computed = "viewportCount"), Flow(FlowDirection.In)] Viewport* pViewports)
            => ImplCmdSetViewport(commandBuffer, firstViewport, viewportCount, pViewports);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetViewport")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdSetViewport([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstViewport, [Count(Count = 0)] uint viewportCount, [Count(Computed = "viewportCount"), Flow(FlowDirection.In)] ref Viewport pViewports)
            => ImplCmdSetViewport(commandBuffer, firstViewport, viewportCount, pViewports);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdUpdateBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdUpdateBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] ulong dstOffset, [Count(Count = 0)] ulong dataSize, [Count(Computed = "dataSize")] void* pData)
            => ImplCmdUpdateBuffer(commandBuffer, dstBuffer, dstOffset, dataSize, pData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdUpdateBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdUpdateBuffer<T0>([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] ulong dstOffset, [Count(Count = 0)] ulong dataSize, [Count(Computed = "dataSize")] ref T0 pData) where T0 : unmanaged
            => ImplCmdUpdateBuffer<T0>(commandBuffer, dstBuffer, dstOffset, dataSize, pData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdWaitEvents")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Computed = "eventCount"), Flow(FlowDirection.In)] Event* pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Computed = "memoryBarrierCount"), Flow(FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Computed = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Computed = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers)
            => ImplCmdWaitEvents(commandBuffer, eventCount, pEvents, srcStageMask, dstStageMask, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdWaitEvents")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Computed = "eventCount"), Flow(FlowDirection.In)] ref Event pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Computed = "memoryBarrierCount"), Flow(FlowDirection.In)] ref MemoryBarrier pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Computed = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] ref BufferMemoryBarrier pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Computed = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ref ImageMemoryBarrier pImageMemoryBarriers)
            => ImplCmdWaitEvents(commandBuffer, eventCount, pEvents, srcStageMask, dstStageMask, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdWriteTimestamp")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdWriteTimestamp([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags pipelineStage, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint query)
            => ImplCmdWriteTimestamp(commandBuffer, pipelineStage, queryPool, query);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreateBuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Buffer* pBuffer)
            => ImplCreateBuffer(device, pCreateInfo, pAllocator, pBuffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreateBuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref BufferCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Buffer pBuffer)
            => ImplCreateBuffer(device, pCreateInfo, pAllocator, pBuffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateBufferView")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreateBufferView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferViewCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] BufferView* pView)
            => ImplCreateBufferView(device, pCreateInfo, pAllocator, pView);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateBufferView")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreateBufferView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref BufferViewCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out BufferView pView)
            => ImplCreateBufferView(device, pCreateInfo, pAllocator, pView);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateCommandPool")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreateCommandPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] CommandPoolCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] CommandPool* pCommandPool)
            => ImplCreateCommandPool(device, pCreateInfo, pAllocator, pCommandPool);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateCommandPool")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreateCommandPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref CommandPoolCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out CommandPool pCommandPool)
            => ImplCreateCommandPool(device, pCreateInfo, pAllocator, pCommandPool);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateComputePipelines")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreateComputePipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] ComputePipelineCreateInfo* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines)
            => ImplCreateComputePipelines(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateComputePipelines")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreateComputePipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] ref ComputePipelineCreateInfo pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] out Pipeline pPipelines)
            => ImplCreateComputePipelines(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorPool")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreateDescriptorPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorPoolCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DescriptorPool* pDescriptorPool)
            => ImplCreateDescriptorPool(device, pCreateInfo, pAllocator, pDescriptorPool);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorPool")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreateDescriptorPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DescriptorPoolCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DescriptorPool pDescriptorPool)
            => ImplCreateDescriptorPool(device, pCreateInfo, pAllocator, pDescriptorPool);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorSetLayout")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreateDescriptorSetLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorSetLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DescriptorSetLayout* pSetLayout)
            => ImplCreateDescriptorSetLayout(device, pCreateInfo, pAllocator, pSetLayout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorSetLayout")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreateDescriptorSetLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DescriptorSetLayoutCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DescriptorSetLayout pSetLayout)
            => ImplCreateDescriptorSetLayout(device, pCreateInfo, pAllocator, pSetLayout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDevice")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreateDevice([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] DeviceCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Device* pDevice)
            => ImplCreateDevice(physicalDevice, pCreateInfo, pAllocator, pDevice);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDevice")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreateDevice([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref DeviceCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Device pDevice)
            => ImplCreateDevice(physicalDevice, pCreateInfo, pAllocator, pDevice);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateEvent")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreateEvent([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] EventCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Event* pEvent)
            => ImplCreateEvent(device, pCreateInfo, pAllocator, pEvent);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateEvent")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreateEvent([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref EventCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Event pEvent)
            => ImplCreateEvent(device, pCreateInfo, pAllocator, pEvent);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateFence")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreateFence([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] FenceCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Fence* pFence)
            => ImplCreateFence(device, pCreateInfo, pAllocator, pFence);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateFence")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreateFence([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref FenceCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Fence pFence)
            => ImplCreateFence(device, pCreateInfo, pAllocator, pFence);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateFramebuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreateFramebuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] FramebufferCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Framebuffer* pFramebuffer)
            => ImplCreateFramebuffer(device, pCreateInfo, pAllocator, pFramebuffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateFramebuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreateFramebuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref FramebufferCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Framebuffer pFramebuffer)
            => ImplCreateFramebuffer(device, pCreateInfo, pAllocator, pFramebuffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateGraphicsPipelines")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreateGraphicsPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] GraphicsPipelineCreateInfo* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines)
            => ImplCreateGraphicsPipelines(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateGraphicsPipelines")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreateGraphicsPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] ref GraphicsPipelineCreateInfo pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] out Pipeline pPipelines)
            => ImplCreateGraphicsPipelines(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreateImage([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImageCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Image* pImage)
            => ImplCreateImage(device, pCreateInfo, pAllocator, pImage);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreateImage([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref ImageCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Image pImage)
            => ImplCreateImage(device, pCreateInfo, pAllocator, pImage);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateImageView")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreateImageView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImageViewCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] ImageView* pView)
            => ImplCreateImageView(device, pCreateInfo, pAllocator, pView);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateImageView")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreateImageView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref ImageViewCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out ImageView pView)
            => ImplCreateImageView(device, pCreateInfo, pAllocator, pView);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateInstance")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreateInstance([Count(Count = 0), Flow(FlowDirection.In)] InstanceCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Instance* pInstance)
            => ImplCreateInstance(pCreateInfo, pAllocator, pInstance);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateInstance")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreateInstance([Count(Count = 0), Flow(FlowDirection.In)] ref InstanceCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Instance pInstance)
            => ImplCreateInstance(pCreateInfo, pAllocator, pInstance);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreatePipelineCache")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreatePipelineCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineCacheCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] PipelineCache* pPipelineCache)
            => ImplCreatePipelineCache(device, pCreateInfo, pAllocator, pPipelineCache);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreatePipelineCache")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreatePipelineCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref PipelineCacheCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out PipelineCache pPipelineCache)
            => ImplCreatePipelineCache(device, pCreateInfo, pAllocator, pPipelineCache);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreatePipelineLayout")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreatePipelineLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] PipelineLayout* pPipelineLayout)
            => ImplCreatePipelineLayout(device, pCreateInfo, pAllocator, pPipelineLayout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreatePipelineLayout")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreatePipelineLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref PipelineLayoutCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out PipelineLayout pPipelineLayout)
            => ImplCreatePipelineLayout(device, pCreateInfo, pAllocator, pPipelineLayout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateQueryPool")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreateQueryPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] QueryPoolCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] QueryPool* pQueryPool)
            => ImplCreateQueryPool(device, pCreateInfo, pAllocator, pQueryPool);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateQueryPool")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreateQueryPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref QueryPoolCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out QueryPool pQueryPool)
            => ImplCreateQueryPool(device, pCreateInfo, pAllocator, pQueryPool);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreateRenderPass([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] RenderPassCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] RenderPass* pRenderPass)
            => ImplCreateRenderPass(device, pCreateInfo, pAllocator, pRenderPass);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreateRenderPass([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref RenderPassCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out RenderPass pRenderPass)
            => ImplCreateRenderPass(device, pCreateInfo, pAllocator, pRenderPass);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateSampler")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreateSampler([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SamplerCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Sampler* pSampler)
            => ImplCreateSampler(device, pCreateInfo, pAllocator, pSampler);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateSampler")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreateSampler([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref SamplerCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Sampler pSampler)
            => ImplCreateSampler(device, pCreateInfo, pAllocator, pSampler);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateSemaphore")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreateSemaphore([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SemaphoreCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Semaphore* pSemaphore)
            => ImplCreateSemaphore(device, pCreateInfo, pAllocator, pSemaphore);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateSemaphore")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreateSemaphore([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref SemaphoreCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Semaphore pSemaphore)
            => ImplCreateSemaphore(device, pCreateInfo, pAllocator, pSemaphore);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateShaderModule")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreateShaderModule([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ShaderModuleCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] ShaderModule* pShaderModule)
            => ImplCreateShaderModule(device, pCreateInfo, pAllocator, pShaderModule);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateShaderModule")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreateShaderModule([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref ShaderModuleCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out ShaderModule pShaderModule)
            => ImplCreateShaderModule(device, pCreateInfo, pAllocator, pShaderModule);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DestroyBuffer([Count(Count = 0)] Device device, [Count(Count = 0)] Buffer buffer, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator)
            => ImplDestroyBuffer(device, buffer, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DestroyBuffer([Count(Count = 0)] Device device, [Count(Count = 0)] Buffer buffer, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator)
            => ImplDestroyBuffer(device, buffer, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyBufferView")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DestroyBufferView([Count(Count = 0)] Device device, [Count(Count = 0)] BufferView bufferView, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator)
            => ImplDestroyBufferView(device, bufferView, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyBufferView")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DestroyBufferView([Count(Count = 0)] Device device, [Count(Count = 0)] BufferView bufferView, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator)
            => ImplDestroyBufferView(device, bufferView, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyCommandPool")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DestroyCommandPool([Count(Count = 0)] Device device, [Count(Count = 0)] CommandPool commandPool, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator)
            => ImplDestroyCommandPool(device, commandPool, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyCommandPool")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DestroyCommandPool([Count(Count = 0)] Device device, [Count(Count = 0)] CommandPool commandPool, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator)
            => ImplDestroyCommandPool(device, commandPool, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDescriptorPool")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DestroyDescriptorPool([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorPool descriptorPool, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator)
            => ImplDestroyDescriptorPool(device, descriptorPool, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDescriptorPool")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DestroyDescriptorPool([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorPool descriptorPool, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator)
            => ImplDestroyDescriptorPool(device, descriptorPool, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDescriptorSetLayout")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DestroyDescriptorSetLayout([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSetLayout descriptorSetLayout, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator)
            => ImplDestroyDescriptorSetLayout(device, descriptorSetLayout, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDescriptorSetLayout")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DestroyDescriptorSetLayout([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSetLayout descriptorSetLayout, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator)
            => ImplDestroyDescriptorSetLayout(device, descriptorSetLayout, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDevice")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DestroyDevice([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator)
            => ImplDestroyDevice(device, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDevice")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DestroyDevice([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator)
            => ImplDestroyDevice(device, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyEvent")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DestroyEvent([Count(Count = 0)] Device device, [Count(Count = 0)] Event @event, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator)
            => ImplDestroyEvent(device, @event, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyEvent")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DestroyEvent([Count(Count = 0)] Device device, [Count(Count = 0)] Event @event, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator)
            => ImplDestroyEvent(device, @event, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyFence")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DestroyFence([Count(Count = 0)] Device device, [Count(Count = 0)] Fence fence, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator)
            => ImplDestroyFence(device, fence, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyFence")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DestroyFence([Count(Count = 0)] Device device, [Count(Count = 0)] Fence fence, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator)
            => ImplDestroyFence(device, fence, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyFramebuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DestroyFramebuffer([Count(Count = 0)] Device device, [Count(Count = 0)] Framebuffer framebuffer, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator)
            => ImplDestroyFramebuffer(device, framebuffer, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyFramebuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DestroyFramebuffer([Count(Count = 0)] Device device, [Count(Count = 0)] Framebuffer framebuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator)
            => ImplDestroyFramebuffer(device, framebuffer, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DestroyImage([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator)
            => ImplDestroyImage(device, image, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DestroyImage([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator)
            => ImplDestroyImage(device, image, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyImageView")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DestroyImageView([Count(Count = 0)] Device device, [Count(Count = 0)] ImageView imageView, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator)
            => ImplDestroyImageView(device, imageView, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyImageView")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DestroyImageView([Count(Count = 0)] Device device, [Count(Count = 0)] ImageView imageView, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator)
            => ImplDestroyImageView(device, imageView, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyInstance")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DestroyInstance([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator)
            => ImplDestroyInstance(instance, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyInstance")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DestroyInstance([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator)
            => ImplDestroyInstance(instance, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyPipeline")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DestroyPipeline([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator)
            => ImplDestroyPipeline(device, pipeline, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyPipeline")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DestroyPipeline([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator)
            => ImplDestroyPipeline(device, pipeline, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyPipelineCache")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DestroyPipelineCache([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator)
            => ImplDestroyPipelineCache(device, pipelineCache, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyPipelineCache")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DestroyPipelineCache([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator)
            => ImplDestroyPipelineCache(device, pipelineCache, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyPipelineLayout")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DestroyPipelineLayout([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineLayout pipelineLayout, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator)
            => ImplDestroyPipelineLayout(device, pipelineLayout, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyPipelineLayout")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DestroyPipelineLayout([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineLayout pipelineLayout, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator)
            => ImplDestroyPipelineLayout(device, pipelineLayout, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyQueryPool")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DestroyQueryPool([Count(Count = 0)] Device device, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator)
            => ImplDestroyQueryPool(device, queryPool, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyQueryPool")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DestroyQueryPool([Count(Count = 0)] Device device, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator)
            => ImplDestroyQueryPool(device, queryPool, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyRenderPass")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DestroyRenderPass([Count(Count = 0)] Device device, [Count(Count = 0)] RenderPass renderPass, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator)
            => ImplDestroyRenderPass(device, renderPass, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyRenderPass")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DestroyRenderPass([Count(Count = 0)] Device device, [Count(Count = 0)] RenderPass renderPass, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator)
            => ImplDestroyRenderPass(device, renderPass, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroySampler")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DestroySampler([Count(Count = 0)] Device device, [Count(Count = 0)] Sampler sampler, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator)
            => ImplDestroySampler(device, sampler, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroySampler")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DestroySampler([Count(Count = 0)] Device device, [Count(Count = 0)] Sampler sampler, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator)
            => ImplDestroySampler(device, sampler, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroySemaphore")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DestroySemaphore([Count(Count = 0)] Device device, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator)
            => ImplDestroySemaphore(device, semaphore, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroySemaphore")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DestroySemaphore([Count(Count = 0)] Device device, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator)
            => ImplDestroySemaphore(device, semaphore, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyShaderModule")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DestroyShaderModule([Count(Count = 0)] Device device, [Count(Count = 0)] ShaderModule shaderModule, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator)
            => ImplDestroyShaderModule(device, shaderModule, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyShaderModule")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DestroyShaderModule([Count(Count = 0)] Device device, [Count(Count = 0)] ShaderModule shaderModule, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator)
            => ImplDestroyShaderModule(device, shaderModule, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDeviceWaitIdle")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result DeviceWaitIdle([Count(Count = 0)] Device device)
            => ImplDeviceWaitIdle(device);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEndCommandBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result EndCommandBuffer([Count(Count = 0)] CommandBuffer commandBuffer)
            => ImplEndCommandBuffer(commandBuffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceExtensionProperties")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result EnumerateDeviceExtensionProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] byte* pLayerName, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount")] ExtensionProperties* pProperties)
            => ImplEnumerateDeviceExtensionProperties(physicalDevice, pLayerName, pPropertyCount, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceExtensionProperties")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result EnumerateDeviceExtensionProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref byte pLayerName, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount")] ref ExtensionProperties pProperties)
            => ImplEnumerateDeviceExtensionProperties(physicalDevice, pLayerName, pPropertyCount, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceLayerProperties")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result EnumerateDeviceLayerProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount")] LayerProperties* pProperties)
            => ImplEnumerateDeviceLayerProperties(physicalDevice, pPropertyCount, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceLayerProperties")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result EnumerateDeviceLayerProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount")] ref LayerProperties pProperties)
            => ImplEnumerateDeviceLayerProperties(physicalDevice, pPropertyCount, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceExtensionProperties")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(FlowDirection.In)] byte* pLayerName, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount")] ExtensionProperties* pProperties)
            => ImplEnumerateInstanceExtensionProperties(pLayerName, pPropertyCount, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceExtensionProperties")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(FlowDirection.In)] ref byte pLayerName, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount")] ref ExtensionProperties pProperties)
            => ImplEnumerateInstanceExtensionProperties(pLayerName, pPropertyCount, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceLayerProperties")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result EnumerateInstanceLayerProperties([Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount")] LayerProperties* pProperties)
            => ImplEnumerateInstanceLayerProperties(pPropertyCount, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceLayerProperties")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result EnumerateInstanceLayerProperties([Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount")] ref LayerProperties pProperties)
            => ImplEnumerateInstanceLayerProperties(pPropertyCount, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDevices")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result EnumeratePhysicalDevices([Count(Count = 0)] Instance instance, [Count(Count = 0)] uint* pPhysicalDeviceCount, [Count(Computed = "pPhysicalDeviceCount")] PhysicalDevice* pPhysicalDevices)
            => ImplEnumeratePhysicalDevices(instance, pPhysicalDeviceCount, pPhysicalDevices);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDevices")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result EnumeratePhysicalDevices([Count(Count = 0)] Instance instance, [Count(Count = 0)] ref uint pPhysicalDeviceCount, [Count(Computed = "pPhysicalDeviceCount")] ref PhysicalDevice pPhysicalDevices)
            => ImplEnumeratePhysicalDevices(instance, pPhysicalDeviceCount, pPhysicalDevices);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkFlushMappedMemoryRanges")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result FlushMappedMemoryRanges([Count(Count = 0)] Device device, [Count(Count = 0)] uint memoryRangeCount, [Count(Computed = "memoryRangeCount"), Flow(FlowDirection.In)] MappedMemoryRange* pMemoryRanges)
            => ImplFlushMappedMemoryRanges(device, memoryRangeCount, pMemoryRanges);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkFlushMappedMemoryRanges")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result FlushMappedMemoryRanges([Count(Count = 0)] Device device, [Count(Count = 0)] uint memoryRangeCount, [Count(Computed = "memoryRangeCount"), Flow(FlowDirection.In)] ref MappedMemoryRange pMemoryRanges)
            => ImplFlushMappedMemoryRanges(device, memoryRangeCount, pMemoryRanges);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkFreeCommandBuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FreeCommandBuffers([Count(Count = 0)] Device device, [Count(Count = 0)] CommandPool commandPool, [Count(Count = 0)] uint commandBufferCount, [Count(Computed = "commandBufferCount"), Flow(FlowDirection.In)] CommandBuffer* pCommandBuffers)
            => ImplFreeCommandBuffers(device, commandPool, commandBufferCount, pCommandBuffers);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkFreeCommandBuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FreeCommandBuffers([Count(Count = 0)] Device device, [Count(Count = 0)] CommandPool commandPool, [Count(Count = 0)] uint commandBufferCount, [Count(Computed = "commandBufferCount"), Flow(FlowDirection.In)] ref CommandBuffer pCommandBuffers)
            => ImplFreeCommandBuffers(device, commandPool, commandBufferCount, pCommandBuffers);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkFreeDescriptorSets")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result FreeDescriptorSets([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorPool descriptorPool, [Count(Count = 0)] uint descriptorSetCount, [Count(Computed = "descriptorSetCount"), Flow(FlowDirection.In)] DescriptorSet* pDescriptorSets)
            => ImplFreeDescriptorSets(device, descriptorPool, descriptorSetCount, pDescriptorSets);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkFreeDescriptorSets")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result FreeDescriptorSets([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorPool descriptorPool, [Count(Count = 0)] uint descriptorSetCount, [Count(Computed = "descriptorSetCount"), Flow(FlowDirection.In)] ref DescriptorSet pDescriptorSets)
            => ImplFreeDescriptorSets(device, descriptorPool, descriptorSetCount, pDescriptorSets);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkFreeMemory")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FreeMemory([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator)
            => ImplFreeMemory(device, memory, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkFreeMemory")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FreeMemory([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator)
            => ImplFreeMemory(device, memory, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetBufferMemoryRequirements")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetBufferMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0)] Buffer buffer, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryRequirements* pMemoryRequirements)
            => ImplGetBufferMemoryRequirements(device, buffer, pMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetBufferMemoryRequirements")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetBufferMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0)] Buffer buffer, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryRequirements pMemoryRequirements)
            => ImplGetBufferMemoryRequirements(device, buffer, pMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceMemoryCommitment")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetDeviceMemoryCommitment([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0), Flow(FlowDirection.Out)] ulong* pCommittedMemoryInBytes)
            => ImplGetDeviceMemoryCommitment(device, memory, pCommittedMemoryInBytes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceMemoryCommitment")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetDeviceMemoryCommitment([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0), Flow(FlowDirection.Out)] out ulong pCommittedMemoryInBytes)
            => ImplGetDeviceMemoryCommitment(device, memory, pCommittedMemoryInBytes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceProcAddr")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe FuncPtr GetDeviceProcAddr([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] byte* pName)
            => ImplGetDeviceProcAddr(device, pName);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceProcAddr")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public FuncPtr GetDeviceProcAddr([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref byte pName)
            => ImplGetDeviceProcAddr(device, pName);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceQueue")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetDeviceQueue([Count(Count = 0)] Device device, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint queueIndex, [Count(Count = 0), Flow(FlowDirection.Out)] Queue* pQueue)
            => ImplGetDeviceQueue(device, queueFamilyIndex, queueIndex, pQueue);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceQueue")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetDeviceQueue([Count(Count = 0)] Device device, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint queueIndex, [Count(Count = 0), Flow(FlowDirection.Out)] out Queue pQueue)
            => ImplGetDeviceQueue(device, queueFamilyIndex, queueIndex, pQueue);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetEventStatus")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetEventStatus([Count(Count = 0)] Device device, [Count(Count = 0)] Event @event)
            => ImplGetEventStatus(device, @event);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetFenceStatus")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetFenceStatus([Count(Count = 0)] Device device, [Count(Count = 0)] Fence fence)
            => ImplGetFenceStatus(device, fence);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageMemoryRequirements")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetImageMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryRequirements* pMemoryRequirements)
            => ImplGetImageMemoryRequirements(device, image, pMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageMemoryRequirements")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetImageMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryRequirements pMemoryRequirements)
            => ImplGetImageMemoryRequirements(device, image, pMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetImageSparseMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0)] uint* pSparseMemoryRequirementCount, [Count(Computed = "pSparseMemoryRequirementCount"), Flow(FlowDirection.Out)] SparseImageMemoryRequirements* pSparseMemoryRequirements)
            => ImplGetImageSparseMemoryRequirements(device, image, pSparseMemoryRequirementCount, pSparseMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetImageSparseMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0)] ref uint pSparseMemoryRequirementCount, [Count(Computed = "pSparseMemoryRequirementCount"), Flow(FlowDirection.Out)] out SparseImageMemoryRequirements pSparseMemoryRequirements)
            => ImplGetImageSparseMemoryRequirements(device, image, pSparseMemoryRequirementCount, pSparseMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageSubresourceLayout")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetImageSubresourceLayout([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.In)] ImageSubresource* pSubresource, [Count(Count = 0), Flow(FlowDirection.Out)] SubresourceLayout* pLayout)
            => ImplGetImageSubresourceLayout(device, image, pSubresource, pLayout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageSubresourceLayout")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetImageSubresourceLayout([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.In)] ref ImageSubresource pSubresource, [Count(Count = 0), Flow(FlowDirection.Out)] out SubresourceLayout pLayout)
            => ImplGetImageSubresourceLayout(device, image, pSubresource, pLayout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetInstanceProcAddr")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe FuncPtr GetInstanceProcAddr([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] byte* pName)
            => ImplGetInstanceProcAddr(instance, pName);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetInstanceProcAddr")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public FuncPtr GetInstanceProcAddr([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref byte pName)
            => ImplGetInstanceProcAddr(instance, pName);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFeatures")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPhysicalDeviceFeatures([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] PhysicalDeviceFeatures* pFeatures)
            => ImplGetPhysicalDeviceFeatures(physicalDevice, pFeatures);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFeatures")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPhysicalDeviceFeatures([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] out PhysicalDeviceFeatures pFeatures)
            => ImplGetPhysicalDeviceFeatures(physicalDevice, pFeatures);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFormatProperties")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPhysicalDeviceFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0), Flow(FlowDirection.Out)] FormatProperties* pFormatProperties)
            => ImplGetPhysicalDeviceFormatProperties(physicalDevice, format, pFormatProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFormatProperties")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPhysicalDeviceFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0), Flow(FlowDirection.Out)] out FormatProperties pFormatProperties)
            => ImplGetPhysicalDeviceFormatProperties(physicalDevice, format, pFormatProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceImageFormatProperties")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetPhysicalDeviceImageFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageType type, [Count(Count = 0)] ImageTiling tiling, [Count(Count = 0)] ImageUsageFlags usage, [Count(Count = 0)] ImageCreateFlags flags, [Count(Count = 0), Flow(FlowDirection.Out)] ImageFormatProperties* pImageFormatProperties)
            => ImplGetPhysicalDeviceImageFormatProperties(physicalDevice, format, type, tiling, usage, flags, pImageFormatProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceImageFormatProperties")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetPhysicalDeviceImageFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageType type, [Count(Count = 0)] ImageTiling tiling, [Count(Count = 0)] ImageUsageFlags usage, [Count(Count = 0)] ImageCreateFlags flags, [Count(Count = 0), Flow(FlowDirection.Out)] out ImageFormatProperties pImageFormatProperties)
            => ImplGetPhysicalDeviceImageFormatProperties(physicalDevice, format, type, tiling, usage, flags, pImageFormatProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceMemoryProperties")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPhysicalDeviceMemoryProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] PhysicalDeviceMemoryProperties* pMemoryProperties)
            => ImplGetPhysicalDeviceMemoryProperties(physicalDevice, pMemoryProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceMemoryProperties")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPhysicalDeviceMemoryProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] out PhysicalDeviceMemoryProperties pMemoryProperties)
            => ImplGetPhysicalDeviceMemoryProperties(physicalDevice, pMemoryProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceProperties")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPhysicalDeviceProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] PhysicalDeviceProperties* pProperties)
            => ImplGetPhysicalDeviceProperties(physicalDevice, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceProperties")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPhysicalDeviceProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] out PhysicalDeviceProperties pProperties)
            => ImplGetPhysicalDeviceProperties(physicalDevice, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPhysicalDeviceQueueFamilyProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pQueueFamilyPropertyCount, [Count(Computed = "pQueueFamilyPropertyCount"), Flow(FlowDirection.Out)] QueueFamilyProperties* pQueueFamilyProperties)
            => ImplGetPhysicalDeviceQueueFamilyProperties(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPhysicalDeviceQueueFamilyProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pQueueFamilyPropertyCount, [Count(Computed = "pQueueFamilyPropertyCount"), Flow(FlowDirection.Out)] out QueueFamilyProperties pQueueFamilyProperties)
            => ImplGetPhysicalDeviceQueueFamilyProperties(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPhysicalDeviceSparseImageFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageType type, [Count(Count = 0)] SampleCountFlags samples, [Count(Count = 0)] ImageUsageFlags usage, [Count(Count = 0)] ImageTiling tiling, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] SparseImageFormatProperties* pProperties)
            => ImplGetPhysicalDeviceSparseImageFormatProperties(physicalDevice, format, type, samples, usage, tiling, pPropertyCount, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPhysicalDeviceSparseImageFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageType type, [Count(Count = 0)] SampleCountFlags samples, [Count(Count = 0)] ImageUsageFlags usage, [Count(Count = 0)] ImageTiling tiling, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] out SparseImageFormatProperties pProperties)
            => ImplGetPhysicalDeviceSparseImageFormatProperties(physicalDevice, format, type, samples, usage, tiling, pPropertyCount, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineCacheData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetPipelineCacheData([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] UIntPtr* pDataSize, [Count(Computed = "pDataSize")] void* pData)
            => ImplGetPipelineCacheData(device, pipelineCache, pDataSize, pData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineCacheData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetPipelineCacheData<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] ref UIntPtr pDataSize, [Count(Computed = "pDataSize")] ref T0 pData) where T0 : unmanaged
            => ImplGetPipelineCacheData<T0>(device, pipelineCache, pDataSize, pData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetQueryPoolResults")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetQueryPoolResults([Count(Count = 0)] Device device, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery, [Count(Count = 0)] uint queryCount, [Count(Count = 0)] UIntPtr dataSize, [Count(Computed = "dataSize")] void* pData, [Count(Count = 0)] ulong stride, [Count(Count = 0)] QueryResultFlags flags)
            => ImplGetQueryPoolResults(device, queryPool, firstQuery, queryCount, dataSize, pData, stride, flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetQueryPoolResults")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetQueryPoolResults<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery, [Count(Count = 0)] uint queryCount, [Count(Count = 0)] UIntPtr dataSize, [Count(Computed = "dataSize")] ref T0 pData, [Count(Count = 0)] ulong stride, [Count(Count = 0)] QueryResultFlags flags) where T0 : unmanaged
            => ImplGetQueryPoolResults<T0>(device, queryPool, firstQuery, queryCount, dataSize, pData, stride, flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetRenderAreaGranularity")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetRenderAreaGranularity([Count(Count = 0)] Device device, [Count(Count = 0)] RenderPass renderPass, [Count(Count = 0), Flow(FlowDirection.Out)] Extent2D* pGranularity)
            => ImplGetRenderAreaGranularity(device, renderPass, pGranularity);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetRenderAreaGranularity")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetRenderAreaGranularity([Count(Count = 0)] Device device, [Count(Count = 0)] RenderPass renderPass, [Count(Count = 0), Flow(FlowDirection.Out)] out Extent2D pGranularity)
            => ImplGetRenderAreaGranularity(device, renderPass, pGranularity);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkInvalidateMappedMemoryRanges")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result InvalidateMappedMemoryRanges([Count(Count = 0)] Device device, [Count(Count = 0)] uint memoryRangeCount, [Count(Computed = "memoryRangeCount"), Flow(FlowDirection.In)] MappedMemoryRange* pMemoryRanges)
            => ImplInvalidateMappedMemoryRanges(device, memoryRangeCount, pMemoryRanges);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkInvalidateMappedMemoryRanges")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result InvalidateMappedMemoryRanges([Count(Count = 0)] Device device, [Count(Count = 0)] uint memoryRangeCount, [Count(Computed = "memoryRangeCount"), Flow(FlowDirection.In)] ref MappedMemoryRange pMemoryRanges)
            => ImplInvalidateMappedMemoryRanges(device, memoryRangeCount, pMemoryRanges);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkMapMemory")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result MapMemory([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0)] ulong offset, [Count(Count = 0)] ulong size, [Count(Count = 0)] uint flags, [Count(Count = 0)] void** ppData)
            => ImplMapMemory(device, memory, offset, size, flags, ppData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkMapMemory")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result MapMemory<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0)] ulong offset, [Count(Count = 0)] ulong size, [Count(Count = 0)] uint flags, [Count(Count = 0)] ref T0* ppData) where T0 : unmanaged
            => ImplMapMemory<T0>(device, memory, offset, size, flags, ppData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkMergePipelineCaches")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result MergePipelineCaches([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache dstCache, [Count(Count = 0)] uint srcCacheCount, [Count(Computed = "srcCacheCount"), Flow(FlowDirection.In)] PipelineCache* pSrcCaches)
            => ImplMergePipelineCaches(device, dstCache, srcCacheCount, pSrcCaches);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkMergePipelineCaches")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result MergePipelineCaches([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache dstCache, [Count(Count = 0)] uint srcCacheCount, [Count(Computed = "srcCacheCount"), Flow(FlowDirection.In)] ref PipelineCache pSrcCaches)
            => ImplMergePipelineCaches(device, dstCache, srcCacheCount, pSrcCaches);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkQueueBindSparse")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result QueueBindSparse([Count(Count = 0)] Queue queue, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] BindSparseInfo* pBindInfo, [Count(Count = 0)] Fence fence)
            => ImplQueueBindSparse(queue, bindInfoCount, pBindInfo, fence);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkQueueBindSparse")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result QueueBindSparse([Count(Count = 0)] Queue queue, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] ref BindSparseInfo pBindInfo, [Count(Count = 0)] Fence fence)
            => ImplQueueBindSparse(queue, bindInfoCount, pBindInfo, fence);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkQueueSubmit")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result QueueSubmit([Count(Count = 0)] Queue queue, [Count(Count = 0)] uint submitCount, [Count(Computed = "submitCount"), Flow(FlowDirection.In)] SubmitInfo* pSubmits, [Count(Count = 0)] Fence fence)
            => ImplQueueSubmit(queue, submitCount, pSubmits, fence);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkQueueSubmit")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result QueueSubmit([Count(Count = 0)] Queue queue, [Count(Count = 0)] uint submitCount, [Count(Computed = "submitCount"), Flow(FlowDirection.In)] ref SubmitInfo pSubmits, [Count(Count = 0)] Fence fence)
            => ImplQueueSubmit(queue, submitCount, pSubmits, fence);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkQueueWaitIdle")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result QueueWaitIdle([Count(Count = 0)] Queue queue)
            => ImplQueueWaitIdle(queue);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkResetCommandBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result ResetCommandBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] CommandBufferResetFlags flags)
            => ImplResetCommandBuffer(commandBuffer, flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkResetCommandPool")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result ResetCommandPool([Count(Count = 0)] Device device, [Count(Count = 0)] CommandPool commandPool, [Count(Count = 0)] CommandPoolResetFlags flags)
            => ImplResetCommandPool(device, commandPool, flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkResetDescriptorPool")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result ResetDescriptorPool([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorPool descriptorPool, [Count(Count = 0)] uint flags)
            => ImplResetDescriptorPool(device, descriptorPool, flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkResetEvent")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result ResetEvent([Count(Count = 0)] Device device, [Count(Count = 0)] Event @event)
            => ImplResetEvent(device, @event);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkResetFences")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result ResetFences([Count(Count = 0)] Device device, [Count(Count = 0)] uint fenceCount, [Count(Computed = "fenceCount"), Flow(FlowDirection.In)] Fence* pFences)
            => ImplResetFences(device, fenceCount, pFences);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkResetFences")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result ResetFences([Count(Count = 0)] Device device, [Count(Count = 0)] uint fenceCount, [Count(Computed = "fenceCount"), Flow(FlowDirection.In)] ref Fence pFences)
            => ImplResetFences(device, fenceCount, pFences);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkSetEvent")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result SetEvent([Count(Count = 0)] Device device, [Count(Count = 0)] Event @event)
            => ImplSetEvent(device, @event);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkUnmapMemory")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void UnmapMemory([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory)
            => ImplUnmapMemory(device, memory);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkUpdateDescriptorSets")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void UpdateDescriptorSets([Count(Count = 0)] Device device, [Count(Count = 0)] uint descriptorWriteCount, [Count(Computed = "descriptorWriteCount"), Flow(FlowDirection.In)] WriteDescriptorSet* pDescriptorWrites, [Count(Count = 0)] uint descriptorCopyCount, [Count(Computed = "descriptorCopyCount"), Flow(FlowDirection.In)] CopyDescriptorSet* pDescriptorCopies)
            => ImplUpdateDescriptorSets(device, descriptorWriteCount, pDescriptorWrites, descriptorCopyCount, pDescriptorCopies);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkUpdateDescriptorSets")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void UpdateDescriptorSets([Count(Count = 0)] Device device, [Count(Count = 0)] uint descriptorWriteCount, [Count(Computed = "descriptorWriteCount"), Flow(FlowDirection.In)] ref WriteDescriptorSet pDescriptorWrites, [Count(Count = 0)] uint descriptorCopyCount, [Count(Computed = "descriptorCopyCount"), Flow(FlowDirection.In)] ref CopyDescriptorSet pDescriptorCopies)
            => ImplUpdateDescriptorSets(device, descriptorWriteCount, pDescriptorWrites, descriptorCopyCount, pDescriptorCopies);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkWaitForFences")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result WaitForFences([Count(Count = 0)] Device device, [Count(Count = 0)] uint fenceCount, [Count(Computed = "fenceCount"), Flow(FlowDirection.In)] Fence* pFences, [Count(Count = 0)] Bool32 waitAll, [Count(Count = 0)] ulong timeout)
            => ImplWaitForFences(device, fenceCount, pFences, waitAll, timeout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkWaitForFences")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result WaitForFences([Count(Count = 0)] Device device, [Count(Count = 0)] uint fenceCount, [Count(Computed = "fenceCount"), Flow(FlowDirection.In)] ref Fence pFences, [Count(Count = 0)] Bool32 waitAll, [Count(Count = 0)] ulong timeout)
            => ImplWaitForFences(device, fenceCount, pFences, waitAll, timeout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceExtensionProperties")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result EnumerateDeviceExtensionProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Flow(FlowDirection.In)] string pLayerName, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount")] ExtensionProperties* pProperties)
            => ImplEnumerateDeviceExtensionProperties(physicalDevice, pLayerName, pPropertyCount, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceExtensionProperties")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result EnumerateDeviceExtensionProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Flow(FlowDirection.In)] string pLayerName, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount")] ref ExtensionProperties pProperties)
            => ImplEnumerateDeviceExtensionProperties(physicalDevice, pLayerName, pPropertyCount, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceExtensionProperties")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result EnumerateInstanceExtensionProperties([Flow(FlowDirection.In)] string pLayerName, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount")] ExtensionProperties* pProperties)
            => ImplEnumerateInstanceExtensionProperties(pLayerName, pPropertyCount, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceExtensionProperties")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result EnumerateInstanceExtensionProperties([Flow(FlowDirection.In)] string pLayerName, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount")] ref ExtensionProperties pProperties)
            => ImplEnumerateInstanceExtensionProperties(pLayerName, pPropertyCount, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceProcAddr")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public FuncPtr GetDeviceProcAddr([Count(Count = 0)] Device device, [Flow(FlowDirection.In)] string pName)
            => ImplGetDeviceProcAddr(device, pName);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetInstanceProcAddr")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public FuncPtr GetInstanceProcAddr([Count(Count = 0)] Instance instance, [Flow(FlowDirection.In)] string pName)
            => ImplGetInstanceProcAddr(instance, pName);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBindBufferMemory2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result BindBufferMemory2([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] BindBufferMemoryInfo* pBindInfos)
            => ImplBindBufferMemory2(device, bindInfoCount, pBindInfos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBindBufferMemory2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result BindBufferMemory2([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] ref BindBufferMemoryInfo pBindInfos)
            => ImplBindBufferMemory2(device, bindInfoCount, pBindInfos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBindImageMemory2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result BindImageMemory2([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] BindImageMemoryInfo* pBindInfos)
            => ImplBindImageMemory2(device, bindInfoCount, pBindInfos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBindImageMemory2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result BindImageMemory2([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] ref BindImageMemoryInfo pBindInfos)
            => ImplBindImageMemory2(device, bindInfoCount, pBindInfos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDispatchBase")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdDispatchBase([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint baseGroupX, [Count(Count = 0)] uint baseGroupY, [Count(Count = 0)] uint baseGroupZ, [Count(Count = 0)] uint groupCountX, [Count(Count = 0)] uint groupCountY, [Count(Count = 0)] uint groupCountZ)
            => ImplCmdDispatchBase(commandBuffer, baseGroupX, baseGroupY, baseGroupZ, groupCountX, groupCountY, groupCountZ);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDeviceMask")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdSetDeviceMask([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint deviceMask)
            => ImplCmdSetDeviceMask(commandBuffer, deviceMask);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorUpdateTemplate")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreateDescriptorUpdateTemplate([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorUpdateTemplateCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DescriptorUpdateTemplate* pDescriptorUpdateTemplate)
            => ImplCreateDescriptorUpdateTemplate(device, pCreateInfo, pAllocator, pDescriptorUpdateTemplate);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorUpdateTemplate")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreateDescriptorUpdateTemplate([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DescriptorUpdateTemplateCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DescriptorUpdateTemplate pDescriptorUpdateTemplate)
            => ImplCreateDescriptorUpdateTemplate(device, pCreateInfo, pAllocator, pDescriptorUpdateTemplate);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateSamplerYcbcrConversion")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreateSamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SamplerYcbcrConversionCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SamplerYcbcrConversion* pYcbcrConversion)
            => ImplCreateSamplerYcbcrConversion(device, pCreateInfo, pAllocator, pYcbcrConversion);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateSamplerYcbcrConversion")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreateSamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref SamplerYcbcrConversionCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SamplerYcbcrConversion pYcbcrConversion)
            => ImplCreateSamplerYcbcrConversion(device, pCreateInfo, pAllocator, pYcbcrConversion);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDescriptorUpdateTemplate")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DestroyDescriptorUpdateTemplate([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator)
            => ImplDestroyDescriptorUpdateTemplate(device, descriptorUpdateTemplate, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDescriptorUpdateTemplate")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DestroyDescriptorUpdateTemplate([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator)
            => ImplDestroyDescriptorUpdateTemplate(device, descriptorUpdateTemplate, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroySamplerYcbcrConversion")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DestroySamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0)] SamplerYcbcrConversion ycbcrConversion, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator)
            => ImplDestroySamplerYcbcrConversion(device, ycbcrConversion, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroySamplerYcbcrConversion")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DestroySamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0)] SamplerYcbcrConversion ycbcrConversion, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator)
            => ImplDestroySamplerYcbcrConversion(device, ycbcrConversion, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceVersion")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result EnumerateInstanceVersion([Count(Count = 0)] uint* pApiVersion)
            => ImplEnumerateInstanceVersion(pApiVersion);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceVersion")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result EnumerateInstanceVersion([Count(Count = 0)] ref uint pApiVersion)
            => ImplEnumerateInstanceVersion(pApiVersion);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceGroups")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result EnumeratePhysicalDeviceGroups([Count(Count = 0)] Instance instance, [Count(Count = 0)] uint* pPhysicalDeviceGroupCount, [Count(Computed = "pPhysicalDeviceGroupCount")] PhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties)
            => ImplEnumeratePhysicalDeviceGroups(instance, pPhysicalDeviceGroupCount, pPhysicalDeviceGroupProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceGroups")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result EnumeratePhysicalDeviceGroups([Count(Count = 0)] Instance instance, [Count(Count = 0)] ref uint pPhysicalDeviceGroupCount, [Count(Computed = "pPhysicalDeviceGroupCount")] ref PhysicalDeviceGroupProperties pPhysicalDeviceGroupProperties)
            => ImplEnumeratePhysicalDeviceGroups(instance, pPhysicalDeviceGroupCount, pPhysicalDeviceGroupProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetBufferMemoryRequirements2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetBufferMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferMemoryRequirementsInfo2* pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements)
            => ImplGetBufferMemoryRequirements2(device, pInfo, pMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetBufferMemoryRequirements2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetBufferMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref BufferMemoryRequirementsInfo2 pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryRequirements2 pMemoryRequirements)
            => ImplGetBufferMemoryRequirements2(device, pInfo, pMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDescriptorSetLayoutSupport")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetDescriptorSetLayoutSupport([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorSetLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.Out)] DescriptorSetLayoutSupport* pSupport)
            => ImplGetDescriptorSetLayoutSupport(device, pCreateInfo, pSupport);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDescriptorSetLayoutSupport")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetDescriptorSetLayoutSupport([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DescriptorSetLayoutCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out DescriptorSetLayoutSupport pSupport)
            => ImplGetDescriptorSetLayoutSupport(device, pCreateInfo, pSupport);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupPeerMemoryFeatures")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetDeviceGroupPeerMemoryFeatures([Count(Count = 0)] Device device, [Count(Count = 0)] uint heapIndex, [Count(Count = 0)] uint localDeviceIndex, [Count(Count = 0)] uint remoteDeviceIndex, [Count(Count = 0), Flow(FlowDirection.Out)] PeerMemoryFeatureFlags* pPeerMemoryFeatures)
            => ImplGetDeviceGroupPeerMemoryFeatures(device, heapIndex, localDeviceIndex, remoteDeviceIndex, pPeerMemoryFeatures);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupPeerMemoryFeatures")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetDeviceGroupPeerMemoryFeatures([Count(Count = 0)] Device device, [Count(Count = 0)] uint heapIndex, [Count(Count = 0)] uint localDeviceIndex, [Count(Count = 0)] uint remoteDeviceIndex, [Count(Count = 0), Flow(FlowDirection.Out)] out PeerMemoryFeatureFlags pPeerMemoryFeatures)
            => ImplGetDeviceGroupPeerMemoryFeatures(device, heapIndex, localDeviceIndex, remoteDeviceIndex, pPeerMemoryFeatures);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceQueue2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetDeviceQueue2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DeviceQueueInfo2* pQueueInfo, [Count(Count = 0), Flow(FlowDirection.Out)] Queue* pQueue)
            => ImplGetDeviceQueue2(device, pQueueInfo, pQueue);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceQueue2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetDeviceQueue2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DeviceQueueInfo2 pQueueInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out Queue pQueue)
            => ImplGetDeviceQueue2(device, pQueueInfo, pQueue);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageMemoryRequirements2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetImageMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImageMemoryRequirementsInfo2* pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements)
            => ImplGetImageMemoryRequirements2(device, pInfo, pMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageMemoryRequirements2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetImageMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref ImageMemoryRequirementsInfo2 pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryRequirements2 pMemoryRequirements)
            => ImplGetImageMemoryRequirements2(device, pInfo, pMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetImageSparseMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImageSparseMemoryRequirementsInfo2* pInfo, [Count(Count = 0)] uint* pSparseMemoryRequirementCount, [Count(Computed = "pSparseMemoryRequirementCount"), Flow(FlowDirection.Out)] SparseImageMemoryRequirements2* pSparseMemoryRequirements)
            => ImplGetImageSparseMemoryRequirements2(device, pInfo, pSparseMemoryRequirementCount, pSparseMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetImageSparseMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref ImageSparseMemoryRequirementsInfo2 pInfo, [Count(Count = 0)] ref uint pSparseMemoryRequirementCount, [Count(Computed = "pSparseMemoryRequirementCount"), Flow(FlowDirection.Out)] out SparseImageMemoryRequirements2 pSparseMemoryRequirements)
            => ImplGetImageSparseMemoryRequirements2(device, pInfo, pSparseMemoryRequirementCount, pSparseMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalBufferProperties")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPhysicalDeviceExternalBufferProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceExternalBufferInfo* pExternalBufferInfo, [Count(Count = 0), Flow(FlowDirection.Out)] ExternalBufferProperties* pExternalBufferProperties)
            => ImplGetPhysicalDeviceExternalBufferProperties(physicalDevice, pExternalBufferInfo, pExternalBufferProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalBufferProperties")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPhysicalDeviceExternalBufferProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref PhysicalDeviceExternalBufferInfo pExternalBufferInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out ExternalBufferProperties pExternalBufferProperties)
            => ImplGetPhysicalDeviceExternalBufferProperties(physicalDevice, pExternalBufferInfo, pExternalBufferProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalFenceProperties")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPhysicalDeviceExternalFenceProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceExternalFenceInfo* pExternalFenceInfo, [Count(Count = 0), Flow(FlowDirection.Out)] ExternalFenceProperties* pExternalFenceProperties)
            => ImplGetPhysicalDeviceExternalFenceProperties(physicalDevice, pExternalFenceInfo, pExternalFenceProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalFenceProperties")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPhysicalDeviceExternalFenceProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref PhysicalDeviceExternalFenceInfo pExternalFenceInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out ExternalFenceProperties pExternalFenceProperties)
            => ImplGetPhysicalDeviceExternalFenceProperties(physicalDevice, pExternalFenceInfo, pExternalFenceProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalSemaphoreProperties")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPhysicalDeviceExternalSemaphoreProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, [Count(Count = 0), Flow(FlowDirection.Out)] ExternalSemaphoreProperties* pExternalSemaphoreProperties)
            => ImplGetPhysicalDeviceExternalSemaphoreProperties(physicalDevice, pExternalSemaphoreInfo, pExternalSemaphoreProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalSemaphoreProperties")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPhysicalDeviceExternalSemaphoreProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref PhysicalDeviceExternalSemaphoreInfo pExternalSemaphoreInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out ExternalSemaphoreProperties pExternalSemaphoreProperties)
            => ImplGetPhysicalDeviceExternalSemaphoreProperties(physicalDevice, pExternalSemaphoreInfo, pExternalSemaphoreProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFeatures2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPhysicalDeviceFeatures2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] PhysicalDeviceFeatures2* pFeatures)
            => ImplGetPhysicalDeviceFeatures2(physicalDevice, pFeatures);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFeatures2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPhysicalDeviceFeatures2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] out PhysicalDeviceFeatures2 pFeatures)
            => ImplGetPhysicalDeviceFeatures2(physicalDevice, pFeatures);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFormatProperties2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPhysicalDeviceFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0), Flow(FlowDirection.Out)] FormatProperties2* pFormatProperties)
            => ImplGetPhysicalDeviceFormatProperties2(physicalDevice, format, pFormatProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFormatProperties2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPhysicalDeviceFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0), Flow(FlowDirection.Out)] out FormatProperties2 pFormatProperties)
            => ImplGetPhysicalDeviceFormatProperties2(physicalDevice, format, pFormatProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetPhysicalDeviceImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceImageFormatInfo2* pImageFormatInfo, [Count(Count = 0), Flow(FlowDirection.Out)] ImageFormatProperties2* pImageFormatProperties)
            => ImplGetPhysicalDeviceImageFormatProperties2(physicalDevice, pImageFormatInfo, pImageFormatProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetPhysicalDeviceImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref PhysicalDeviceImageFormatInfo2 pImageFormatInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out ImageFormatProperties2 pImageFormatProperties)
            => ImplGetPhysicalDeviceImageFormatProperties2(physicalDevice, pImageFormatInfo, pImageFormatProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceMemoryProperties2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPhysicalDeviceMemoryProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] PhysicalDeviceMemoryProperties2* pMemoryProperties)
            => ImplGetPhysicalDeviceMemoryProperties2(physicalDevice, pMemoryProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceMemoryProperties2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPhysicalDeviceMemoryProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] out PhysicalDeviceMemoryProperties2 pMemoryProperties)
            => ImplGetPhysicalDeviceMemoryProperties2(physicalDevice, pMemoryProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceProperties2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPhysicalDeviceProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] PhysicalDeviceProperties2* pProperties)
            => ImplGetPhysicalDeviceProperties2(physicalDevice, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceProperties2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPhysicalDeviceProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] out PhysicalDeviceProperties2 pProperties)
            => ImplGetPhysicalDeviceProperties2(physicalDevice, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPhysicalDeviceQueueFamilyProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pQueueFamilyPropertyCount, [Count(Computed = "pQueueFamilyPropertyCount"), Flow(FlowDirection.Out)] QueueFamilyProperties2* pQueueFamilyProperties)
            => ImplGetPhysicalDeviceQueueFamilyProperties2(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPhysicalDeviceQueueFamilyProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pQueueFamilyPropertyCount, [Count(Computed = "pQueueFamilyPropertyCount"), Flow(FlowDirection.Out)] out QueueFamilyProperties2 pQueueFamilyProperties)
            => ImplGetPhysicalDeviceQueueFamilyProperties2(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPhysicalDeviceSparseImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceSparseImageFormatInfo2* pFormatInfo, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] SparseImageFormatProperties2* pProperties)
            => ImplGetPhysicalDeviceSparseImageFormatProperties2(physicalDevice, pFormatInfo, pPropertyCount, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPhysicalDeviceSparseImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref PhysicalDeviceSparseImageFormatInfo2 pFormatInfo, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] out SparseImageFormatProperties2 pProperties)
            => ImplGetPhysicalDeviceSparseImageFormatProperties2(physicalDevice, pFormatInfo, pPropertyCount, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkTrimCommandPool")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TrimCommandPool([Count(Count = 0)] Device device, [Count(Count = 0)] CommandPool commandPool, [Count(Count = 0)] uint flags)
            => ImplTrimCommandPool(device, commandPool, flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkUpdateDescriptorSetWithTemplate")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void UpdateDescriptorSetWithTemplate([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSet descriptorSet, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0)] void* pData)
            => ImplUpdateDescriptorSetWithTemplate(device, descriptorSet, descriptorUpdateTemplate, pData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkUpdateDescriptorSetWithTemplate")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void UpdateDescriptorSetWithTemplate<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSet descriptorSet, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0)] ref T0 pData) where T0 : unmanaged
            => ImplUpdateDescriptorSetWithTemplate<T0>(device, descriptorSet, descriptorUpdateTemplate, pData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginRenderPass2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdBeginRenderPass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] RenderPassBeginInfo* pRenderPassBegin, [Count(Count = 0), Flow(FlowDirection.In)] SubpassBeginInfo* pSubpassBeginInfo)
            => ImplCmdBeginRenderPass2(commandBuffer, pRenderPassBegin, pSubpassBeginInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginRenderPass2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdBeginRenderPass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref RenderPassBeginInfo pRenderPassBegin, [Count(Count = 0), Flow(FlowDirection.In)] ref SubpassBeginInfo pSubpassBeginInfo)
            => ImplCmdBeginRenderPass2(commandBuffer, pRenderPassBegin, pSubpassBeginInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawIndexedIndirectCount")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdDrawIndexedIndirectCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] Buffer countBuffer, [Count(Count = 0)] ulong countBufferOffset, [Count(Count = 0)] uint maxDrawCount, [Count(Count = 0)] uint stride)
            => ImplCmdDrawIndexedIndirectCount(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawIndirectCount")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdDrawIndirectCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] Buffer countBuffer, [Count(Count = 0)] ulong countBufferOffset, [Count(Count = 0)] uint maxDrawCount, [Count(Count = 0)] uint stride)
            => ImplCmdDrawIndirectCount(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdEndRenderPass2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdEndRenderPass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] SubpassEndInfo* pSubpassEndInfo)
            => ImplCmdEndRenderPass2(commandBuffer, pSubpassEndInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdEndRenderPass2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdEndRenderPass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref SubpassEndInfo pSubpassEndInfo)
            => ImplCmdEndRenderPass2(commandBuffer, pSubpassEndInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdNextSubpass2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdNextSubpass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] SubpassBeginInfo* pSubpassBeginInfo, [Count(Count = 0), Flow(FlowDirection.In)] SubpassEndInfo* pSubpassEndInfo)
            => ImplCmdNextSubpass2(commandBuffer, pSubpassBeginInfo, pSubpassEndInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdNextSubpass2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdNextSubpass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref SubpassBeginInfo pSubpassBeginInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref SubpassEndInfo pSubpassEndInfo)
            => ImplCmdNextSubpass2(commandBuffer, pSubpassBeginInfo, pSubpassEndInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreateRenderPass2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] RenderPassCreateInfo2* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] RenderPass* pRenderPass)
            => ImplCreateRenderPass2(device, pCreateInfo, pAllocator, pRenderPass);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreateRenderPass2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref RenderPassCreateInfo2 pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out RenderPass pRenderPass)
            => ImplCreateRenderPass2(device, pCreateInfo, pAllocator, pRenderPass);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetBufferDeviceAddress")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe ulong GetBufferDeviceAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferDeviceAddressInfo* pInfo)
            => ImplGetBufferDeviceAddress(device, pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetBufferDeviceAddress")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public ulong GetBufferDeviceAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref BufferDeviceAddressInfo pInfo)
            => ImplGetBufferDeviceAddress(device, pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetBufferOpaqueCaptureAddress")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe ulong GetBufferOpaqueCaptureAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferDeviceAddressInfo* pInfo)
            => ImplGetBufferOpaqueCaptureAddress(device, pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetBufferOpaqueCaptureAddress")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public ulong GetBufferOpaqueCaptureAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref BufferDeviceAddressInfo pInfo)
            => ImplGetBufferOpaqueCaptureAddress(device, pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceMemoryOpaqueCaptureAddress")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe ulong GetDeviceMemoryOpaqueCaptureAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DeviceMemoryOpaqueCaptureAddressInfo* pInfo)
            => ImplGetDeviceMemoryOpaqueCaptureAddress(device, pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceMemoryOpaqueCaptureAddress")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public ulong GetDeviceMemoryOpaqueCaptureAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DeviceMemoryOpaqueCaptureAddressInfo pInfo)
            => ImplGetDeviceMemoryOpaqueCaptureAddress(device, pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetSemaphoreCounterValue")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetSemaphoreCounterValue([Count(Count = 0)] Device device, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0), Flow(FlowDirection.Out)] ulong* pValue)
            => ImplGetSemaphoreCounterValue(device, semaphore, pValue);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetSemaphoreCounterValue")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetSemaphoreCounterValue([Count(Count = 0)] Device device, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0), Flow(FlowDirection.Out)] out ulong pValue)
            => ImplGetSemaphoreCounterValue(device, semaphore, pValue);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkResetQueryPool")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ResetQueryPool([Count(Count = 0)] Device device, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery, [Count(Count = 0)] uint queryCount)
            => ImplResetQueryPool(device, queryPool, firstQuery, queryCount);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkSignalSemaphore")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result SignalSemaphore([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SemaphoreSignalInfo* pSignalInfo)
            => ImplSignalSemaphore(device, pSignalInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkSignalSemaphore")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result SignalSemaphore([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref SemaphoreSignalInfo pSignalInfo)
            => ImplSignalSemaphore(device, pSignalInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkWaitSemaphores")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result WaitSemaphores([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SemaphoreWaitInfo* pWaitInfo, [Count(Count = 0)] ulong timeout)
            => ImplWaitSemaphores(device, pWaitInfo, timeout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkWaitSemaphores")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result WaitSemaphores([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref SemaphoreWaitInfo pWaitInfo, [Count(Count = 0)] ulong timeout)
            => ImplWaitSemaphores(device, pWaitInfo, timeout);

        /// <summary>To be added.</summary>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe PhysicalDeviceFeatures GetPhysicalDeviceFeature([Count(Count = 0)] PhysicalDevice physicalDevice)
        {
            // ReturnTypeOverloader
            PhysicalDeviceFeatures ret = default;
            GetPhysicalDeviceFeatures(physicalDevice, &ret);
            return ret;
        }

        /// <summary>To be added.</summary>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe PhysicalDeviceMemoryProperties GetPhysicalDeviceMemoryProperty([Count(Count = 0)] PhysicalDevice physicalDevice)
        {
            // ReturnTypeOverloader
            PhysicalDeviceMemoryProperties ret = default;
            GetPhysicalDeviceMemoryProperties(physicalDevice, &ret);
            return ret;
        }

        /// <summary>To be added.</summary>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe PhysicalDeviceProperties GetPhysicalDeviceProperty([Count(Count = 0)] PhysicalDevice physicalDevice)
        {
            // ReturnTypeOverloader
            PhysicalDeviceProperties ret = default;
            GetPhysicalDeviceProperties(physicalDevice, &ret);
            return ret;
        }

        /// <summary>To be added.</summary>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetQueryPoolResults([Count(Count = 0)] Device device, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery, [Count(Count = 0)] uint queryCount, [Count(Count = 0)] uint dataSize, [Count(Computed = "dataSize")] void* pData, [Count(Count = 0)] ulong stride, [Count(Count = 0)] QueryResultFlags flags)
        {
            // IntPtrOverloader
            return GetQueryPoolResults(device, queryPool, firstQuery, queryCount, new UIntPtr(dataSize), pData, stride, flags);
        }

        /// <summary>To be added.</summary>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetQueryPoolResults<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery, [Count(Count = 0)] uint queryCount, [Count(Count = 0)] uint dataSize, [Count(Computed = "dataSize")] ref T0 pData, [Count(Count = 0)] ulong stride, [Count(Count = 0)] QueryResultFlags flags) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetQueryPoolResults(device, queryPool, firstQuery, queryCount, new UIntPtr(dataSize), ref pData, stride, flags);
        }

        /// <summary>To be added.</summary>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe PhysicalDeviceFeatures2 GetPhysicalDeviceFeatures2([Count(Count = 0)] PhysicalDevice physicalDevice)
        {
            // ReturnTypeOverloader
            PhysicalDeviceFeatures2 ret = default;
            GetPhysicalDeviceFeatures2(physicalDevice, &ret);
            return ret;
        }

        /// <summary>To be added.</summary>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe PhysicalDeviceMemoryProperties2 GetPhysicalDeviceMemoryProperties2([Count(Count = 0)] PhysicalDevice physicalDevice)
        {
            // ReturnTypeOverloader
            PhysicalDeviceMemoryProperties2 ret = default;
            GetPhysicalDeviceMemoryProperties2(physicalDevice, &ret);
            return ret;
        }

        /// <summary>To be added.</summary>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe PhysicalDeviceProperties2 GetPhysicalDeviceProperties2([Count(Count = 0)] PhysicalDevice physicalDevice)
        {
            // ReturnTypeOverloader
            PhysicalDeviceProperties2 ret = default;
            GetPhysicalDeviceProperties2(physicalDevice, &ret);
            return ret;
        }

        private SearchPathContainer _searchPaths;
        public override SearchPathContainer SearchPaths => _searchPaths ??= new VulkanLibraryNameContainer();

        public Vk(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

