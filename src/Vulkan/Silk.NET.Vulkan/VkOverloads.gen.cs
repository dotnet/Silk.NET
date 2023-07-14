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
    public static class VkOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdBeginRenderPass2(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPassBeginInfo* pRenderPassBegin, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SubpassBeginInfo> pSubpassBeginInfo)
        {
            // SpanOverloader
            thisApi.CmdBeginRenderPass2(commandBuffer, pRenderPassBegin, in pSubpassBeginInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBeginRenderPass2(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderPassBeginInfo> pRenderPassBegin, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SubpassBeginInfo* pSubpassBeginInfo)
        {
            // SpanOverloader
            thisApi.CmdBeginRenderPass2(commandBuffer, in pRenderPassBegin.GetPinnableReference(), pSubpassBeginInfo);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBeginRenderPass2(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderPassBeginInfo> pRenderPassBegin, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SubpassBeginInfo> pSubpassBeginInfo)
        {
            // SpanOverloader
            thisApi.CmdBeginRenderPass2(commandBuffer, in pRenderPassBegin.GetPinnableReference(), in pSubpassBeginInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdEndRenderPass2(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SubpassEndInfo> pSubpassEndInfo)
        {
            // SpanOverloader
            thisApi.CmdEndRenderPass2(commandBuffer, in pSubpassEndInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdNextSubpass2(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SubpassBeginInfo* pSubpassBeginInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SubpassEndInfo> pSubpassEndInfo)
        {
            // SpanOverloader
            thisApi.CmdNextSubpass2(commandBuffer, pSubpassBeginInfo, in pSubpassEndInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdNextSubpass2(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SubpassBeginInfo> pSubpassBeginInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SubpassEndInfo* pSubpassEndInfo)
        {
            // SpanOverloader
            thisApi.CmdNextSubpass2(commandBuffer, in pSubpassBeginInfo.GetPinnableReference(), pSubpassEndInfo);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdNextSubpass2(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SubpassBeginInfo> pSubpassBeginInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SubpassEndInfo> pSubpassEndInfo)
        {
            // SpanOverloader
            thisApi.CmdNextSubpass2(commandBuffer, in pSubpassBeginInfo.GetPinnableReference(), in pSubpassEndInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRenderPass2(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPassCreateInfo2* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<RenderPass> pRenderPass)
        {
            // SpanOverloader
            return thisApi.CreateRenderPass2(device, pCreateInfo, pAllocator, out pRenderPass.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRenderPass2(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPassCreateInfo2* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] RenderPass* pRenderPass)
        {
            // SpanOverloader
            return thisApi.CreateRenderPass2(device, pCreateInfo, in pAllocator.GetPinnableReference(), pRenderPass);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRenderPass2(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPassCreateInfo2* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<RenderPass> pRenderPass)
        {
            // SpanOverloader
            return thisApi.CreateRenderPass2(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pRenderPass.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRenderPass2(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderPassCreateInfo2> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] RenderPass* pRenderPass)
        {
            // SpanOverloader
            return thisApi.CreateRenderPass2(device, in pCreateInfo.GetPinnableReference(), pAllocator, pRenderPass);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRenderPass2(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderPassCreateInfo2> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<RenderPass> pRenderPass)
        {
            // SpanOverloader
            return thisApi.CreateRenderPass2(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pRenderPass.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRenderPass2(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderPassCreateInfo2> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] RenderPass* pRenderPass)
        {
            // SpanOverloader
            return thisApi.CreateRenderPass2(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pRenderPass);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRenderPass2(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderPassCreateInfo2> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<RenderPass> pRenderPass)
        {
            // SpanOverloader
            return thisApi.CreateRenderPass2(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pRenderPass.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe ulong GetBufferDeviceAddress(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferDeviceAddressInfo> pInfo)
        {
            // SpanOverloader
            return thisApi.GetBufferDeviceAddress(device, in pInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe ulong GetBufferOpaqueCaptureAddress(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferDeviceAddressInfo> pInfo)
        {
            // SpanOverloader
            return thisApi.GetBufferOpaqueCaptureAddress(device, in pInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe ulong GetDeviceMemoryOpaqueCaptureAddress(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DeviceMemoryOpaqueCaptureAddressInfo> pInfo)
        {
            // SpanOverloader
            return thisApi.GetDeviceMemoryOpaqueCaptureAddress(device, in pInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSemaphoreCounterValue(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> pValue)
        {
            // SpanOverloader
            return thisApi.GetSemaphoreCounterValue(device, semaphore, out pValue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result SignalSemaphore(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SemaphoreSignalInfo> pSignalInfo)
        {
            // SpanOverloader
            return thisApi.SignalSemaphore(device, in pSignalInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result WaitSemaphores(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SemaphoreWaitInfo> pWaitInfo, [Count(Count = 0)] ulong timeout)
        {
            // SpanOverloader
            return thisApi.WaitSemaphores(device, in pWaitInfo.GetPinnableReference(), timeout);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBeginRendering(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderingInfo> pRenderingInfo)
        {
            // SpanOverloader
            thisApi.CmdBeginRendering(commandBuffer, in pRenderingInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pSizes, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes, in pStrides.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pSizes, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, in pSizes.GetPinnableReference(), pStrides);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pSizes, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, in pSizes.GetPinnableReference(), in pStrides.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pSizes, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, pBuffers, in pOffsets.GetPinnableReference(), pSizes, pStrides);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pSizes, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, pBuffers, in pOffsets.GetPinnableReference(), pSizes, in pStrides.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pSizes, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, pBuffers, in pOffsets.GetPinnableReference(), in pSizes.GetPinnableReference(), pStrides);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pSizes, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, pBuffers, in pOffsets.GetPinnableReference(), in pSizes.GetPinnableReference(), in pStrides.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pSizes, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, in pBuffers.GetPinnableReference(), pOffsets, pSizes, pStrides);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pSizes, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, in pBuffers.GetPinnableReference(), pOffsets, pSizes, in pStrides.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pSizes, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, in pBuffers.GetPinnableReference(), pOffsets, in pSizes.GetPinnableReference(), pStrides);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pSizes, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, in pBuffers.GetPinnableReference(), pOffsets, in pSizes.GetPinnableReference(), in pStrides.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pSizes, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, in pBuffers.GetPinnableReference(), in pOffsets.GetPinnableReference(), pSizes, pStrides);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pSizes, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, in pBuffers.GetPinnableReference(), in pOffsets.GetPinnableReference(), pSizes, in pStrides.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pSizes, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, in pBuffers.GetPinnableReference(), in pOffsets.GetPinnableReference(), in pSizes.GetPinnableReference(), pStrides);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pSizes, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, in pBuffers.GetPinnableReference(), in pOffsets.GetPinnableReference(), in pSizes.GetPinnableReference(), in pStrides.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBlitImage2(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BlitImageInfo2> pBlitImageInfo)
        {
            // SpanOverloader
            thisApi.CmdBlitImage2(commandBuffer, in pBlitImageInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdCopyBuffer2(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyBufferInfo2> pCopyBufferInfo)
        {
            // SpanOverloader
            thisApi.CmdCopyBuffer2(commandBuffer, in pCopyBufferInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdCopyBufferToImage2(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyBufferToImageInfo2> pCopyBufferToImageInfo)
        {
            // SpanOverloader
            thisApi.CmdCopyBufferToImage2(commandBuffer, in pCopyBufferToImageInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdCopyImage2(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyImageInfo2> pCopyImageInfo)
        {
            // SpanOverloader
            thisApi.CmdCopyImage2(commandBuffer, in pCopyImageInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdCopyImageToBuffer2(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyImageToBufferInfo2> pCopyImageToBufferInfo)
        {
            // SpanOverloader
            thisApi.CmdCopyImageToBuffer2(commandBuffer, in pCopyImageToBufferInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdPipelineBarrier2(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DependencyInfo> pDependencyInfo)
        {
            // SpanOverloader
            thisApi.CmdPipelineBarrier2(commandBuffer, in pDependencyInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdResolveImage2(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResolveImageInfo2> pResolveImageInfo)
        {
            // SpanOverloader
            thisApi.CmdResolveImage2(commandBuffer, in pResolveImageInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetEvent2(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Event @event, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DependencyInfo> pDependencyInfo)
        {
            // SpanOverloader
            thisApi.CmdSetEvent2(commandBuffer, @event, in pDependencyInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetScissorWithCount(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint scissorCount, [Count(Parameter = "scissorCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Rect2D> pScissors)
        {
            // SpanOverloader
            thisApi.CmdSetScissorWithCount(commandBuffer, scissorCount, in pScissors.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetViewportWithCount(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint viewportCount, [Count(Parameter = "viewportCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Viewport> pViewports)
        {
            // SpanOverloader
            thisApi.CmdSetViewportWithCount(commandBuffer, viewportCount, in pViewports.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdWaitEvents2(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Event* pEvents, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DependencyInfo> pDependencyInfos)
        {
            // SpanOverloader
            thisApi.CmdWaitEvents2(commandBuffer, eventCount, pEvents, in pDependencyInfos.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdWaitEvents2(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Event> pEvents, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] DependencyInfo* pDependencyInfos)
        {
            // SpanOverloader
            thisApi.CmdWaitEvents2(commandBuffer, eventCount, in pEvents.GetPinnableReference(), pDependencyInfos);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdWaitEvents2(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Event> pEvents, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DependencyInfo> pDependencyInfos)
        {
            // SpanOverloader
            thisApi.CmdWaitEvents2(commandBuffer, eventCount, in pEvents.GetPinnableReference(), in pDependencyInfos.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePrivateDataSlot(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrivateDataSlotCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PrivateDataSlot> pPrivateDataSlot)
        {
            // SpanOverloader
            return thisApi.CreatePrivateDataSlot(device, pCreateInfo, pAllocator, out pPrivateDataSlot.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePrivateDataSlot(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrivateDataSlotCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PrivateDataSlot* pPrivateDataSlot)
        {
            // SpanOverloader
            return thisApi.CreatePrivateDataSlot(device, pCreateInfo, in pAllocator.GetPinnableReference(), pPrivateDataSlot);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePrivateDataSlot(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrivateDataSlotCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PrivateDataSlot> pPrivateDataSlot)
        {
            // SpanOverloader
            return thisApi.CreatePrivateDataSlot(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pPrivateDataSlot.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePrivateDataSlot(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PrivateDataSlotCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PrivateDataSlot* pPrivateDataSlot)
        {
            // SpanOverloader
            return thisApi.CreatePrivateDataSlot(device, in pCreateInfo.GetPinnableReference(), pAllocator, pPrivateDataSlot);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePrivateDataSlot(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PrivateDataSlotCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PrivateDataSlot> pPrivateDataSlot)
        {
            // SpanOverloader
            return thisApi.CreatePrivateDataSlot(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pPrivateDataSlot.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePrivateDataSlot(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PrivateDataSlotCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PrivateDataSlot* pPrivateDataSlot)
        {
            // SpanOverloader
            return thisApi.CreatePrivateDataSlot(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pPrivateDataSlot);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePrivateDataSlot(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PrivateDataSlotCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PrivateDataSlot> pPrivateDataSlot)
        {
            // SpanOverloader
            return thisApi.CreatePrivateDataSlot(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pPrivateDataSlot.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyPrivateDataSlot(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PrivateDataSlot privateDataSlot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyPrivateDataSlot(device, privateDataSlot, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public static unsafe void GetDeviceBufferMemoryRequirements(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceBufferMemoryRequirements* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryRequirements2> pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetDeviceBufferMemoryRequirements(device, pInfo, out pMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetDeviceBufferMemoryRequirements(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DeviceBufferMemoryRequirements> pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetDeviceBufferMemoryRequirements(device, in pInfo.GetPinnableReference(), pMemoryRequirements);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public static unsafe void GetDeviceBufferMemoryRequirements(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DeviceBufferMemoryRequirements> pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryRequirements2> pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetDeviceBufferMemoryRequirements(device, in pInfo.GetPinnableReference(), out pMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public static unsafe void GetDeviceImageMemoryRequirements(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceImageMemoryRequirements* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryRequirements2> pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetDeviceImageMemoryRequirements(device, pInfo, out pMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetDeviceImageMemoryRequirements(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DeviceImageMemoryRequirements> pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetDeviceImageMemoryRequirements(device, in pInfo.GetPinnableReference(), pMemoryRequirements);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public static unsafe void GetDeviceImageMemoryRequirements(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DeviceImageMemoryRequirements> pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryRequirements2> pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetDeviceImageMemoryRequirements(device, in pInfo.GetPinnableReference(), out pMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSparseMemoryRequirements = new(StructureType.SparseImageMemoryRequirements2);")]
        public static unsafe void GetDeviceImageSparseMemoryRequirements(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceImageMemoryRequirements* pInfo, [Count(Count = 0)] uint* pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SparseImageMemoryRequirements2> pSparseMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetDeviceImageSparseMemoryRequirements(device, pInfo, pSparseMemoryRequirementCount, out pSparseMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetDeviceImageSparseMemoryRequirements(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceImageMemoryRequirements* pInfo, [Count(Count = 0)] Span<uint> pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SparseImageMemoryRequirements2* pSparseMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetDeviceImageSparseMemoryRequirements(device, pInfo, ref pSparseMemoryRequirementCount.GetPinnableReference(), pSparseMemoryRequirements);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSparseMemoryRequirements = new(StructureType.SparseImageMemoryRequirements2);")]
        public static unsafe void GetDeviceImageSparseMemoryRequirements(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceImageMemoryRequirements* pInfo, [Count(Count = 0)] Span<uint> pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SparseImageMemoryRequirements2> pSparseMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetDeviceImageSparseMemoryRequirements(device, pInfo, ref pSparseMemoryRequirementCount.GetPinnableReference(), out pSparseMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetDeviceImageSparseMemoryRequirements(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DeviceImageMemoryRequirements> pInfo, [Count(Count = 0)] uint* pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SparseImageMemoryRequirements2* pSparseMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetDeviceImageSparseMemoryRequirements(device, in pInfo.GetPinnableReference(), pSparseMemoryRequirementCount, pSparseMemoryRequirements);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSparseMemoryRequirements = new(StructureType.SparseImageMemoryRequirements2);")]
        public static unsafe void GetDeviceImageSparseMemoryRequirements(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DeviceImageMemoryRequirements> pInfo, [Count(Count = 0)] uint* pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SparseImageMemoryRequirements2> pSparseMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetDeviceImageSparseMemoryRequirements(device, in pInfo.GetPinnableReference(), pSparseMemoryRequirementCount, out pSparseMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetDeviceImageSparseMemoryRequirements(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DeviceImageMemoryRequirements> pInfo, [Count(Count = 0)] Span<uint> pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SparseImageMemoryRequirements2* pSparseMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetDeviceImageSparseMemoryRequirements(device, in pInfo.GetPinnableReference(), ref pSparseMemoryRequirementCount.GetPinnableReference(), pSparseMemoryRequirements);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSparseMemoryRequirements = new(StructureType.SparseImageMemoryRequirements2);")]
        public static unsafe void GetDeviceImageSparseMemoryRequirements(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DeviceImageMemoryRequirements> pInfo, [Count(Count = 0)] Span<uint> pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SparseImageMemoryRequirements2> pSparseMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetDeviceImageSparseMemoryRequirements(device, in pInfo.GetPinnableReference(), ref pSparseMemoryRequirementCount.GetPinnableReference(), out pSparseMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pToolProperties = new(StructureType.PhysicalDeviceToolProperties);")]
        public static unsafe Result GetPhysicalDeviceToolProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pToolCount, [Count(Parameter = "pToolCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PhysicalDeviceToolProperties> pToolProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceToolProperties(physicalDevice, pToolCount, out pToolProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceToolProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pToolCount, [Count(Parameter = "pToolCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PhysicalDeviceToolProperties* pToolProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceToolProperties(physicalDevice, ref pToolCount.GetPinnableReference(), pToolProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pToolProperties = new(StructureType.PhysicalDeviceToolProperties);")]
        public static unsafe Result GetPhysicalDeviceToolProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pToolCount, [Count(Parameter = "pToolCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PhysicalDeviceToolProperties> pToolProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceToolProperties(physicalDevice, ref pToolCount.GetPinnableReference(), out pToolProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetPrivateData(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] ObjectType objectType, [Count(Count = 0)] ulong objectHandle, [Count(Count = 0)] PrivateDataSlot privateDataSlot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> pData)
        {
            // SpanOverloader
            thisApi.GetPrivateData(device, objectType, objectHandle, privateDataSlot, out pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result QueueSubmit2(this Vk thisApi, [Count(Count = 0)] Queue queue, [Count(Count = 0)] uint submitCount, [Count(Parameter = "submitCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SubmitInfo2> pSubmits, [Count(Count = 0)] Fence fence)
        {
            // SpanOverloader
            return thisApi.QueueSubmit2(queue, submitCount, in pSubmits.GetPinnableReference(), fence);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result BindBufferMemory2(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Parameter = "bindInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BindBufferMemoryInfo> pBindInfos)
        {
            // SpanOverloader
            return thisApi.BindBufferMemory2(device, bindInfoCount, in pBindInfos.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result BindImageMemory2(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Parameter = "bindInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BindImageMemoryInfo> pBindInfos)
        {
            // SpanOverloader
            return thisApi.BindImageMemory2(device, bindInfoCount, in pBindInfos.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDescriptorUpdateTemplate(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorUpdateTemplateCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DescriptorUpdateTemplate> pDescriptorUpdateTemplate)
        {
            // SpanOverloader
            return thisApi.CreateDescriptorUpdateTemplate(device, pCreateInfo, pAllocator, out pDescriptorUpdateTemplate.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDescriptorUpdateTemplate(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorUpdateTemplateCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DescriptorUpdateTemplate* pDescriptorUpdateTemplate)
        {
            // SpanOverloader
            return thisApi.CreateDescriptorUpdateTemplate(device, pCreateInfo, in pAllocator.GetPinnableReference(), pDescriptorUpdateTemplate);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDescriptorUpdateTemplate(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorUpdateTemplateCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DescriptorUpdateTemplate> pDescriptorUpdateTemplate)
        {
            // SpanOverloader
            return thisApi.CreateDescriptorUpdateTemplate(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pDescriptorUpdateTemplate.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDescriptorUpdateTemplate(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorUpdateTemplateCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DescriptorUpdateTemplate* pDescriptorUpdateTemplate)
        {
            // SpanOverloader
            return thisApi.CreateDescriptorUpdateTemplate(device, in pCreateInfo.GetPinnableReference(), pAllocator, pDescriptorUpdateTemplate);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDescriptorUpdateTemplate(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorUpdateTemplateCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DescriptorUpdateTemplate> pDescriptorUpdateTemplate)
        {
            // SpanOverloader
            return thisApi.CreateDescriptorUpdateTemplate(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pDescriptorUpdateTemplate.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDescriptorUpdateTemplate(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorUpdateTemplateCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DescriptorUpdateTemplate* pDescriptorUpdateTemplate)
        {
            // SpanOverloader
            return thisApi.CreateDescriptorUpdateTemplate(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pDescriptorUpdateTemplate);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDescriptorUpdateTemplate(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorUpdateTemplateCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DescriptorUpdateTemplate> pDescriptorUpdateTemplate)
        {
            // SpanOverloader
            return thisApi.CreateDescriptorUpdateTemplate(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pDescriptorUpdateTemplate.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSamplerYcbcrConversion(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerYcbcrConversionCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SamplerYcbcrConversion> pYcbcrConversion)
        {
            // SpanOverloader
            return thisApi.CreateSamplerYcbcrConversion(device, pCreateInfo, pAllocator, out pYcbcrConversion.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSamplerYcbcrConversion(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerYcbcrConversionCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SamplerYcbcrConversion* pYcbcrConversion)
        {
            // SpanOverloader
            return thisApi.CreateSamplerYcbcrConversion(device, pCreateInfo, in pAllocator.GetPinnableReference(), pYcbcrConversion);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSamplerYcbcrConversion(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerYcbcrConversionCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SamplerYcbcrConversion> pYcbcrConversion)
        {
            // SpanOverloader
            return thisApi.CreateSamplerYcbcrConversion(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pYcbcrConversion.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSamplerYcbcrConversion(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SamplerYcbcrConversionCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SamplerYcbcrConversion* pYcbcrConversion)
        {
            // SpanOverloader
            return thisApi.CreateSamplerYcbcrConversion(device, in pCreateInfo.GetPinnableReference(), pAllocator, pYcbcrConversion);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSamplerYcbcrConversion(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SamplerYcbcrConversionCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SamplerYcbcrConversion> pYcbcrConversion)
        {
            // SpanOverloader
            return thisApi.CreateSamplerYcbcrConversion(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pYcbcrConversion.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSamplerYcbcrConversion(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SamplerYcbcrConversionCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SamplerYcbcrConversion* pYcbcrConversion)
        {
            // SpanOverloader
            return thisApi.CreateSamplerYcbcrConversion(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pYcbcrConversion);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSamplerYcbcrConversion(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SamplerYcbcrConversionCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SamplerYcbcrConversion> pYcbcrConversion)
        {
            // SpanOverloader
            return thisApi.CreateSamplerYcbcrConversion(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pYcbcrConversion.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyDescriptorUpdateTemplate(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyDescriptorUpdateTemplate(device, descriptorUpdateTemplate, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroySamplerYcbcrConversion(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] SamplerYcbcrConversion ycbcrConversion, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroySamplerYcbcrConversion(device, ycbcrConversion, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateInstanceVersion(this Vk thisApi, [Count(Count = 0)] Span<uint> pApiVersion)
        {
            // SpanOverloader
            return thisApi.EnumerateInstanceVersion(ref pApiVersion.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumeratePhysicalDeviceGroups(this Vk thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] uint* pPhysicalDeviceGroupCount, [Count(Parameter = "pPhysicalDeviceGroupCount")] Span<PhysicalDeviceGroupProperties> pPhysicalDeviceGroupProperties)
        {
            // SpanOverloader
            return thisApi.EnumeratePhysicalDeviceGroups(instance, pPhysicalDeviceGroupCount, ref pPhysicalDeviceGroupProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumeratePhysicalDeviceGroups(this Vk thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] Span<uint> pPhysicalDeviceGroupCount, [Count(Parameter = "pPhysicalDeviceGroupCount")] PhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties)
        {
            // SpanOverloader
            return thisApi.EnumeratePhysicalDeviceGroups(instance, ref pPhysicalDeviceGroupCount.GetPinnableReference(), pPhysicalDeviceGroupProperties);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumeratePhysicalDeviceGroups(this Vk thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] Span<uint> pPhysicalDeviceGroupCount, [Count(Parameter = "pPhysicalDeviceGroupCount")] Span<PhysicalDeviceGroupProperties> pPhysicalDeviceGroupProperties)
        {
            // SpanOverloader
            return thisApi.EnumeratePhysicalDeviceGroups(instance, ref pPhysicalDeviceGroupCount.GetPinnableReference(), ref pPhysicalDeviceGroupProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public static unsafe void GetBufferMemoryRequirements2(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferMemoryRequirementsInfo2* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryRequirements2> pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetBufferMemoryRequirements2(device, pInfo, out pMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetBufferMemoryRequirements2(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferMemoryRequirementsInfo2> pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetBufferMemoryRequirements2(device, in pInfo.GetPinnableReference(), pMemoryRequirements);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public static unsafe void GetBufferMemoryRequirements2(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferMemoryRequirementsInfo2> pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryRequirements2> pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetBufferMemoryRequirements2(device, in pInfo.GetPinnableReference(), out pMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSupport = new(StructureType.DescriptorSetLayoutSupport);")]
        public static unsafe void GetDescriptorSetLayoutSupport(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorSetLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DescriptorSetLayoutSupport> pSupport)
        {
            // SpanOverloader
            thisApi.GetDescriptorSetLayoutSupport(device, pCreateInfo, out pSupport.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetDescriptorSetLayoutSupport(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorSetLayoutCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DescriptorSetLayoutSupport* pSupport)
        {
            // SpanOverloader
            thisApi.GetDescriptorSetLayoutSupport(device, in pCreateInfo.GetPinnableReference(), pSupport);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSupport = new(StructureType.DescriptorSetLayoutSupport);")]
        public static unsafe void GetDescriptorSetLayoutSupport(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorSetLayoutCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DescriptorSetLayoutSupport> pSupport)
        {
            // SpanOverloader
            thisApi.GetDescriptorSetLayoutSupport(device, in pCreateInfo.GetPinnableReference(), out pSupport.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetDeviceGroupPeerMemoryFeatures(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint heapIndex, [Count(Count = 0)] uint localDeviceIndex, [Count(Count = 0)] uint remoteDeviceIndex, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PeerMemoryFeatureFlags> pPeerMemoryFeatures)
        {
            // SpanOverloader
            thisApi.GetDeviceGroupPeerMemoryFeatures(device, heapIndex, localDeviceIndex, remoteDeviceIndex, out pPeerMemoryFeatures.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetDeviceQueue2(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceQueueInfo2* pQueueInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Queue> pQueue)
        {
            // SpanOverloader
            thisApi.GetDeviceQueue2(device, pQueueInfo, out pQueue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetDeviceQueue2(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DeviceQueueInfo2> pQueueInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Queue* pQueue)
        {
            // SpanOverloader
            thisApi.GetDeviceQueue2(device, in pQueueInfo.GetPinnableReference(), pQueue);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetDeviceQueue2(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DeviceQueueInfo2> pQueueInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Queue> pQueue)
        {
            // SpanOverloader
            thisApi.GetDeviceQueue2(device, in pQueueInfo.GetPinnableReference(), out pQueue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public static unsafe void GetImageMemoryRequirements2(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageMemoryRequirementsInfo2* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryRequirements2> pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetImageMemoryRequirements2(device, pInfo, out pMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetImageMemoryRequirements2(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageMemoryRequirementsInfo2> pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetImageMemoryRequirements2(device, in pInfo.GetPinnableReference(), pMemoryRequirements);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public static unsafe void GetImageMemoryRequirements2(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageMemoryRequirementsInfo2> pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryRequirements2> pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetImageMemoryRequirements2(device, in pInfo.GetPinnableReference(), out pMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSparseMemoryRequirements = new(StructureType.SparseImageMemoryRequirements2);")]
        public static unsafe void GetImageSparseMemoryRequirements2(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageSparseMemoryRequirementsInfo2* pInfo, [Count(Count = 0)] uint* pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SparseImageMemoryRequirements2> pSparseMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetImageSparseMemoryRequirements2(device, pInfo, pSparseMemoryRequirementCount, out pSparseMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetImageSparseMemoryRequirements2(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageSparseMemoryRequirementsInfo2* pInfo, [Count(Count = 0)] Span<uint> pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SparseImageMemoryRequirements2* pSparseMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetImageSparseMemoryRequirements2(device, pInfo, ref pSparseMemoryRequirementCount.GetPinnableReference(), pSparseMemoryRequirements);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSparseMemoryRequirements = new(StructureType.SparseImageMemoryRequirements2);")]
        public static unsafe void GetImageSparseMemoryRequirements2(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageSparseMemoryRequirementsInfo2* pInfo, [Count(Count = 0)] Span<uint> pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SparseImageMemoryRequirements2> pSparseMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetImageSparseMemoryRequirements2(device, pInfo, ref pSparseMemoryRequirementCount.GetPinnableReference(), out pSparseMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetImageSparseMemoryRequirements2(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageSparseMemoryRequirementsInfo2> pInfo, [Count(Count = 0)] uint* pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SparseImageMemoryRequirements2* pSparseMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetImageSparseMemoryRequirements2(device, in pInfo.GetPinnableReference(), pSparseMemoryRequirementCount, pSparseMemoryRequirements);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSparseMemoryRequirements = new(StructureType.SparseImageMemoryRequirements2);")]
        public static unsafe void GetImageSparseMemoryRequirements2(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageSparseMemoryRequirementsInfo2> pInfo, [Count(Count = 0)] uint* pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SparseImageMemoryRequirements2> pSparseMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetImageSparseMemoryRequirements2(device, in pInfo.GetPinnableReference(), pSparseMemoryRequirementCount, out pSparseMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetImageSparseMemoryRequirements2(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageSparseMemoryRequirementsInfo2> pInfo, [Count(Count = 0)] Span<uint> pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SparseImageMemoryRequirements2* pSparseMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetImageSparseMemoryRequirements2(device, in pInfo.GetPinnableReference(), ref pSparseMemoryRequirementCount.GetPinnableReference(), pSparseMemoryRequirements);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSparseMemoryRequirements = new(StructureType.SparseImageMemoryRequirements2);")]
        public static unsafe void GetImageSparseMemoryRequirements2(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageSparseMemoryRequirementsInfo2> pInfo, [Count(Count = 0)] Span<uint> pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SparseImageMemoryRequirements2> pSparseMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetImageSparseMemoryRequirements2(device, in pInfo.GetPinnableReference(), ref pSparseMemoryRequirementCount.GetPinnableReference(), out pSparseMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pExternalBufferProperties = new(StructureType.ExternalBufferProperties);")]
        public static unsafe void GetPhysicalDeviceExternalBufferProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceExternalBufferInfo* pExternalBufferInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ExternalBufferProperties> pExternalBufferProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceExternalBufferProperties(physicalDevice, pExternalBufferInfo, out pExternalBufferProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetPhysicalDeviceExternalBufferProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceExternalBufferInfo> pExternalBufferInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ExternalBufferProperties* pExternalBufferProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceExternalBufferProperties(physicalDevice, in pExternalBufferInfo.GetPinnableReference(), pExternalBufferProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pExternalBufferProperties = new(StructureType.ExternalBufferProperties);")]
        public static unsafe void GetPhysicalDeviceExternalBufferProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceExternalBufferInfo> pExternalBufferInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ExternalBufferProperties> pExternalBufferProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceExternalBufferProperties(physicalDevice, in pExternalBufferInfo.GetPinnableReference(), out pExternalBufferProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pExternalFenceProperties = new(StructureType.ExternalFenceProperties);")]
        public static unsafe void GetPhysicalDeviceExternalFenceProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceExternalFenceInfo* pExternalFenceInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ExternalFenceProperties> pExternalFenceProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceExternalFenceProperties(physicalDevice, pExternalFenceInfo, out pExternalFenceProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetPhysicalDeviceExternalFenceProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceExternalFenceInfo> pExternalFenceInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ExternalFenceProperties* pExternalFenceProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceExternalFenceProperties(physicalDevice, in pExternalFenceInfo.GetPinnableReference(), pExternalFenceProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pExternalFenceProperties = new(StructureType.ExternalFenceProperties);")]
        public static unsafe void GetPhysicalDeviceExternalFenceProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceExternalFenceInfo> pExternalFenceInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ExternalFenceProperties> pExternalFenceProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceExternalFenceProperties(physicalDevice, in pExternalFenceInfo.GetPinnableReference(), out pExternalFenceProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pExternalSemaphoreProperties = new(StructureType.ExternalSemaphoreProperties);")]
        public static unsafe void GetPhysicalDeviceExternalSemaphoreProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ExternalSemaphoreProperties> pExternalSemaphoreProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceExternalSemaphoreProperties(physicalDevice, pExternalSemaphoreInfo, out pExternalSemaphoreProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetPhysicalDeviceExternalSemaphoreProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceExternalSemaphoreInfo> pExternalSemaphoreInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ExternalSemaphoreProperties* pExternalSemaphoreProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceExternalSemaphoreProperties(physicalDevice, in pExternalSemaphoreInfo.GetPinnableReference(), pExternalSemaphoreProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pExternalSemaphoreProperties = new(StructureType.ExternalSemaphoreProperties);")]
        public static unsafe void GetPhysicalDeviceExternalSemaphoreProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceExternalSemaphoreInfo> pExternalSemaphoreInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ExternalSemaphoreProperties> pExternalSemaphoreProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceExternalSemaphoreProperties(physicalDevice, in pExternalSemaphoreInfo.GetPinnableReference(), out pExternalSemaphoreProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pFeatures = new(StructureType.PhysicalDeviceFeatures2);")]
        public static unsafe void GetPhysicalDeviceFeatures2(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PhysicalDeviceFeatures2> pFeatures)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceFeatures2(physicalDevice, out pFeatures.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pFormatProperties = new(StructureType.FormatProperties2);")]
        public static unsafe void GetPhysicalDeviceFormatProperties2(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<FormatProperties2> pFormatProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceFormatProperties2(physicalDevice, format, out pFormatProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pImageFormatProperties = new(StructureType.ImageFormatProperties2);")]
        public static unsafe Result GetPhysicalDeviceImageFormatProperties2(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceImageFormatInfo2* pImageFormatInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ImageFormatProperties2> pImageFormatProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceImageFormatProperties2(physicalDevice, pImageFormatInfo, out pImageFormatProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceImageFormatProperties2(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceImageFormatInfo2> pImageFormatInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ImageFormatProperties2* pImageFormatProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceImageFormatProperties2(physicalDevice, in pImageFormatInfo.GetPinnableReference(), pImageFormatProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pImageFormatProperties = new(StructureType.ImageFormatProperties2);")]
        public static unsafe Result GetPhysicalDeviceImageFormatProperties2(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceImageFormatInfo2> pImageFormatInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ImageFormatProperties2> pImageFormatProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceImageFormatProperties2(physicalDevice, in pImageFormatInfo.GetPinnableReference(), out pImageFormatProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryProperties = new(StructureType.PhysicalDeviceMemoryProperties2);")]
        public static unsafe void GetPhysicalDeviceMemoryProperties2(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PhysicalDeviceMemoryProperties2> pMemoryProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceMemoryProperties2(physicalDevice, out pMemoryProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.PhysicalDeviceProperties2);")]
        public static unsafe void GetPhysicalDeviceProperties2(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PhysicalDeviceProperties2> pProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceProperties2(physicalDevice, out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pQueueFamilyProperties = new(StructureType.QueueFamilyProperties2);")]
        public static unsafe void GetPhysicalDeviceQueueFamilyProperties2(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pQueueFamilyPropertyCount, [Count(Parameter = "pQueueFamilyPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<QueueFamilyProperties2> pQueueFamilyProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceQueueFamilyProperties2(physicalDevice, pQueueFamilyPropertyCount, out pQueueFamilyProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetPhysicalDeviceQueueFamilyProperties2(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pQueueFamilyPropertyCount, [Count(Parameter = "pQueueFamilyPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] QueueFamilyProperties2* pQueueFamilyProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceQueueFamilyProperties2(physicalDevice, ref pQueueFamilyPropertyCount.GetPinnableReference(), pQueueFamilyProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pQueueFamilyProperties = new(StructureType.QueueFamilyProperties2);")]
        public static unsafe void GetPhysicalDeviceQueueFamilyProperties2(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pQueueFamilyPropertyCount, [Count(Parameter = "pQueueFamilyPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<QueueFamilyProperties2> pQueueFamilyProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceQueueFamilyProperties2(physicalDevice, ref pQueueFamilyPropertyCount.GetPinnableReference(), out pQueueFamilyProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.SparseImageFormatProperties2);")]
        public static unsafe void GetPhysicalDeviceSparseImageFormatProperties2(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceSparseImageFormatInfo2* pFormatInfo, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SparseImageFormatProperties2> pProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceSparseImageFormatProperties2(physicalDevice, pFormatInfo, pPropertyCount, out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetPhysicalDeviceSparseImageFormatProperties2(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceSparseImageFormatInfo2* pFormatInfo, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SparseImageFormatProperties2* pProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceSparseImageFormatProperties2(physicalDevice, pFormatInfo, ref pPropertyCount.GetPinnableReference(), pProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.SparseImageFormatProperties2);")]
        public static unsafe void GetPhysicalDeviceSparseImageFormatProperties2(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceSparseImageFormatInfo2* pFormatInfo, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SparseImageFormatProperties2> pProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceSparseImageFormatProperties2(physicalDevice, pFormatInfo, ref pPropertyCount.GetPinnableReference(), out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetPhysicalDeviceSparseImageFormatProperties2(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceSparseImageFormatInfo2> pFormatInfo, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SparseImageFormatProperties2* pProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceSparseImageFormatProperties2(physicalDevice, in pFormatInfo.GetPinnableReference(), pPropertyCount, pProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.SparseImageFormatProperties2);")]
        public static unsafe void GetPhysicalDeviceSparseImageFormatProperties2(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceSparseImageFormatInfo2> pFormatInfo, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SparseImageFormatProperties2> pProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceSparseImageFormatProperties2(physicalDevice, in pFormatInfo.GetPinnableReference(), pPropertyCount, out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetPhysicalDeviceSparseImageFormatProperties2(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceSparseImageFormatInfo2> pFormatInfo, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SparseImageFormatProperties2* pProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceSparseImageFormatProperties2(physicalDevice, in pFormatInfo.GetPinnableReference(), ref pPropertyCount.GetPinnableReference(), pProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.SparseImageFormatProperties2);")]
        public static unsafe void GetPhysicalDeviceSparseImageFormatProperties2(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceSparseImageFormatInfo2> pFormatInfo, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SparseImageFormatProperties2> pProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceSparseImageFormatProperties2(physicalDevice, in pFormatInfo.GetPinnableReference(), ref pPropertyCount.GetPinnableReference(), out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void UpdateDescriptorSetWithTemplate<T0>(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSet descriptorSet, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0)] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.UpdateDescriptorSetWithTemplate(device, descriptorSet, descriptorUpdateTemplate, ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result AllocateCommandBuffers(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandBufferAllocateInfo* pAllocateInfo, [Count(Computed = "pAllocateInfo->commandBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<CommandBuffer> pCommandBuffers)
        {
            // SpanOverloader
            return thisApi.AllocateCommandBuffers(device, pAllocateInfo, out pCommandBuffers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result AllocateCommandBuffers(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CommandBufferAllocateInfo> pAllocateInfo, [Count(Computed = "pAllocateInfo->commandBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CommandBuffer* pCommandBuffers)
        {
            // SpanOverloader
            return thisApi.AllocateCommandBuffers(device, in pAllocateInfo.GetPinnableReference(), pCommandBuffers);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result AllocateCommandBuffers(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CommandBufferAllocateInfo> pAllocateInfo, [Count(Computed = "pAllocateInfo->commandBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<CommandBuffer> pCommandBuffers)
        {
            // SpanOverloader
            return thisApi.AllocateCommandBuffers(device, in pAllocateInfo.GetPinnableReference(), out pCommandBuffers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result AllocateDescriptorSets(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorSetAllocateInfo* pAllocateInfo, [Count(Computed = "pAllocateInfo->descriptorSetCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DescriptorSet> pDescriptorSets)
        {
            // SpanOverloader
            return thisApi.AllocateDescriptorSets(device, pAllocateInfo, out pDescriptorSets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result AllocateDescriptorSets(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorSetAllocateInfo> pAllocateInfo, [Count(Computed = "pAllocateInfo->descriptorSetCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DescriptorSet* pDescriptorSets)
        {
            // SpanOverloader
            return thisApi.AllocateDescriptorSets(device, in pAllocateInfo.GetPinnableReference(), pDescriptorSets);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result AllocateDescriptorSets(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorSetAllocateInfo> pAllocateInfo, [Count(Computed = "pAllocateInfo->descriptorSetCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DescriptorSet> pDescriptorSets)
        {
            // SpanOverloader
            return thisApi.AllocateDescriptorSets(device, in pAllocateInfo.GetPinnableReference(), out pDescriptorSets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result AllocateMemory(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryAllocateInfo* pAllocateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DeviceMemory> pMemory)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(device, pAllocateInfo, pAllocator, out pMemory.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result AllocateMemory(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryAllocateInfo* pAllocateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DeviceMemory* pMemory)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(device, pAllocateInfo, in pAllocator.GetPinnableReference(), pMemory);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result AllocateMemory(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryAllocateInfo* pAllocateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DeviceMemory> pMemory)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(device, pAllocateInfo, in pAllocator.GetPinnableReference(), out pMemory.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result AllocateMemory(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemoryAllocateInfo> pAllocateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DeviceMemory* pMemory)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(device, in pAllocateInfo.GetPinnableReference(), pAllocator, pMemory);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result AllocateMemory(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemoryAllocateInfo> pAllocateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DeviceMemory> pMemory)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(device, in pAllocateInfo.GetPinnableReference(), pAllocator, out pMemory.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result AllocateMemory(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemoryAllocateInfo> pAllocateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DeviceMemory* pMemory)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(device, in pAllocateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pMemory);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result AllocateMemory(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemoryAllocateInfo> pAllocateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DeviceMemory> pMemory)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(device, in pAllocateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pMemory.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result BeginCommandBuffer(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CommandBufferBeginInfo> pBeginInfo)
        {
            // SpanOverloader
            return thisApi.BeginCommandBuffer(commandBuffer, in pBeginInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBeginRenderPass(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderPassBeginInfo> pRenderPassBegin, [Count(Count = 0)] SubpassContents contents)
        {
            // SpanOverloader
            thisApi.CmdBeginRenderPass(commandBuffer, in pRenderPassBegin.GetPinnableReference(), contents);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindDescriptorSets(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint firstSet, [Count(Count = 0)] uint descriptorSetCount, [Count(Parameter = "descriptorSetCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorSet* pDescriptorSets, [Count(Count = 0)] uint dynamicOffsetCount, [Count(Parameter = "dynamicOffsetCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pDynamicOffsets)
        {
            // SpanOverloader
            thisApi.CmdBindDescriptorSets(commandBuffer, pipelineBindPoint, layout, firstSet, descriptorSetCount, pDescriptorSets, dynamicOffsetCount, in pDynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindDescriptorSets(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint firstSet, [Count(Count = 0)] uint descriptorSetCount, [Count(Parameter = "descriptorSetCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorSet> pDescriptorSets, [Count(Count = 0)] uint dynamicOffsetCount, [Count(Parameter = "dynamicOffsetCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pDynamicOffsets)
        {
            // SpanOverloader
            thisApi.CmdBindDescriptorSets(commandBuffer, pipelineBindPoint, layout, firstSet, descriptorSetCount, in pDescriptorSets.GetPinnableReference(), dynamicOffsetCount, pDynamicOffsets);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindDescriptorSets(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint firstSet, [Count(Count = 0)] uint descriptorSetCount, [Count(Parameter = "descriptorSetCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorSet> pDescriptorSets, [Count(Count = 0)] uint dynamicOffsetCount, [Count(Parameter = "dynamicOffsetCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pDynamicOffsets)
        {
            // SpanOverloader
            thisApi.CmdBindDescriptorSets(commandBuffer, pipelineBindPoint, layout, firstSet, descriptorSetCount, in pDescriptorSets.GetPinnableReference(), dynamicOffsetCount, in pDynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pOffsets)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers(commandBuffer, firstBinding, bindingCount, pBuffers, in pOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pOffsets)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers(commandBuffer, firstBinding, bindingCount, in pBuffers.GetPinnableReference(), pOffsets);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pOffsets)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers(commandBuffer, firstBinding, bindingCount, in pBuffers.GetPinnableReference(), in pOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBlitImage(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Parameter = "regionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageBlit> pRegions, [Count(Count = 0)] Filter filter)
        {
            // SpanOverloader
            thisApi.CmdBlitImage(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, in pRegions.GetPinnableReference(), filter);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdClearAttachments(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint attachmentCount, [Count(Parameter = "attachmentCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearAttachment* pAttachments, [Count(Count = 0)] uint rectCount, [Count(Parameter = "rectCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearRect> pRects)
        {
            // SpanOverloader
            thisApi.CmdClearAttachments(commandBuffer, attachmentCount, pAttachments, rectCount, in pRects.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdClearAttachments(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint attachmentCount, [Count(Parameter = "attachmentCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearAttachment> pAttachments, [Count(Count = 0)] uint rectCount, [Count(Parameter = "rectCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearRect* pRects)
        {
            // SpanOverloader
            thisApi.CmdClearAttachments(commandBuffer, attachmentCount, in pAttachments.GetPinnableReference(), rectCount, pRects);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdClearAttachments(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint attachmentCount, [Count(Parameter = "attachmentCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearAttachment> pAttachments, [Count(Count = 0)] uint rectCount, [Count(Parameter = "rectCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearRect> pRects)
        {
            // SpanOverloader
            thisApi.CmdClearAttachments(commandBuffer, attachmentCount, in pAttachments.GetPinnableReference(), rectCount, in pRects.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdClearColorImage(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image image, [Count(Count = 0)] ImageLayout imageLayout, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearColorValue* pColor, [Count(Count = 0)] uint rangeCount, [Count(Parameter = "rangeCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageSubresourceRange> pRanges)
        {
            // SpanOverloader
            thisApi.CmdClearColorImage(commandBuffer, image, imageLayout, pColor, rangeCount, in pRanges.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdClearColorImage(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image image, [Count(Count = 0)] ImageLayout imageLayout, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearColorValue> pColor, [Count(Count = 0)] uint rangeCount, [Count(Parameter = "rangeCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageSubresourceRange* pRanges)
        {
            // SpanOverloader
            thisApi.CmdClearColorImage(commandBuffer, image, imageLayout, in pColor.GetPinnableReference(), rangeCount, pRanges);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdClearColorImage(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image image, [Count(Count = 0)] ImageLayout imageLayout, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearColorValue> pColor, [Count(Count = 0)] uint rangeCount, [Count(Parameter = "rangeCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageSubresourceRange> pRanges)
        {
            // SpanOverloader
            thisApi.CmdClearColorImage(commandBuffer, image, imageLayout, in pColor.GetPinnableReference(), rangeCount, in pRanges.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdClearDepthStencilImage(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image image, [Count(Count = 0)] ImageLayout imageLayout, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearDepthStencilValue* pDepthStencil, [Count(Count = 0)] uint rangeCount, [Count(Parameter = "rangeCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageSubresourceRange> pRanges)
        {
            // SpanOverloader
            thisApi.CmdClearDepthStencilImage(commandBuffer, image, imageLayout, pDepthStencil, rangeCount, in pRanges.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdClearDepthStencilImage(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image image, [Count(Count = 0)] ImageLayout imageLayout, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearDepthStencilValue> pDepthStencil, [Count(Count = 0)] uint rangeCount, [Count(Parameter = "rangeCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageSubresourceRange* pRanges)
        {
            // SpanOverloader
            thisApi.CmdClearDepthStencilImage(commandBuffer, image, imageLayout, in pDepthStencil.GetPinnableReference(), rangeCount, pRanges);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdClearDepthStencilImage(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image image, [Count(Count = 0)] ImageLayout imageLayout, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearDepthStencilValue> pDepthStencil, [Count(Count = 0)] uint rangeCount, [Count(Parameter = "rangeCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageSubresourceRange> pRanges)
        {
            // SpanOverloader
            thisApi.CmdClearDepthStencilImage(commandBuffer, image, imageLayout, in pDepthStencil.GetPinnableReference(), rangeCount, in pRanges.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdCopyBuffer(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer srcBuffer, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] uint regionCount, [Count(Parameter = "regionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferCopy> pRegions)
        {
            // SpanOverloader
            thisApi.CmdCopyBuffer(commandBuffer, srcBuffer, dstBuffer, regionCount, in pRegions.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdCopyBufferToImage(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer srcBuffer, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Parameter = "regionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferImageCopy> pRegions)
        {
            // SpanOverloader
            thisApi.CmdCopyBufferToImage(commandBuffer, srcBuffer, dstImage, dstImageLayout, regionCount, in pRegions.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdCopyImage(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Parameter = "regionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopy> pRegions)
        {
            // SpanOverloader
            thisApi.CmdCopyImage(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, in pRegions.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdCopyImageToBuffer(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] uint regionCount, [Count(Parameter = "regionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferImageCopy> pRegions)
        {
            // SpanOverloader
            thisApi.CmdCopyImageToBuffer(commandBuffer, srcImage, srcImageLayout, dstBuffer, regionCount, in pRegions.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdExecuteCommands(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint commandBufferCount, [Count(Parameter = "commandBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CommandBuffer> pCommandBuffers)
        {
            // SpanOverloader
            thisApi.CmdExecuteCommands(commandBuffer, commandBufferCount, in pCommandBuffers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdPipelineBarrier(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] DependencyFlags dependencyFlags, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageMemoryBarrier> pImageMemoryBarriers)
        {
            // SpanOverloader
            thisApi.CmdPipelineBarrier(commandBuffer, srcStageMask, dstStageMask, dependencyFlags, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, in pImageMemoryBarriers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdPipelineBarrier(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] DependencyFlags dependencyFlags, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferMemoryBarrier> pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers)
        {
            // SpanOverloader
            thisApi.CmdPipelineBarrier(commandBuffer, srcStageMask, dstStageMask, dependencyFlags, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, in pBufferMemoryBarriers.GetPinnableReference(), imageMemoryBarrierCount, pImageMemoryBarriers);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdPipelineBarrier(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] DependencyFlags dependencyFlags, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferMemoryBarrier> pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageMemoryBarrier> pImageMemoryBarriers)
        {
            // SpanOverloader
            thisApi.CmdPipelineBarrier(commandBuffer, srcStageMask, dstStageMask, dependencyFlags, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, in pBufferMemoryBarriers.GetPinnableReference(), imageMemoryBarrierCount, in pImageMemoryBarriers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdPipelineBarrier(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] DependencyFlags dependencyFlags, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemoryBarrier> pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers)
        {
            // SpanOverloader
            thisApi.CmdPipelineBarrier(commandBuffer, srcStageMask, dstStageMask, dependencyFlags, memoryBarrierCount, in pMemoryBarriers.GetPinnableReference(), bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdPipelineBarrier(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] DependencyFlags dependencyFlags, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemoryBarrier> pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageMemoryBarrier> pImageMemoryBarriers)
        {
            // SpanOverloader
            thisApi.CmdPipelineBarrier(commandBuffer, srcStageMask, dstStageMask, dependencyFlags, memoryBarrierCount, in pMemoryBarriers.GetPinnableReference(), bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, in pImageMemoryBarriers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdPipelineBarrier(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] DependencyFlags dependencyFlags, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemoryBarrier> pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferMemoryBarrier> pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers)
        {
            // SpanOverloader
            thisApi.CmdPipelineBarrier(commandBuffer, srcStageMask, dstStageMask, dependencyFlags, memoryBarrierCount, in pMemoryBarriers.GetPinnableReference(), bufferMemoryBarrierCount, in pBufferMemoryBarriers.GetPinnableReference(), imageMemoryBarrierCount, pImageMemoryBarriers);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdPipelineBarrier(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] DependencyFlags dependencyFlags, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemoryBarrier> pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferMemoryBarrier> pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageMemoryBarrier> pImageMemoryBarriers)
        {
            // SpanOverloader
            thisApi.CmdPipelineBarrier(commandBuffer, srcStageMask, dstStageMask, dependencyFlags, memoryBarrierCount, in pMemoryBarriers.GetPinnableReference(), bufferMemoryBarrierCount, in pBufferMemoryBarriers.GetPinnableReference(), imageMemoryBarrierCount, in pImageMemoryBarriers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdPushConstants<T0>(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] ShaderStageFlags stageFlags, [Count(Count = 0)] uint offset, [Count(Count = 0)] uint size, [Count(Parameter = "size")] Span<T0> pValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CmdPushConstants(commandBuffer, layout, stageFlags, offset, size, ref pValues.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdResolveImage(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Parameter = "regionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageResolve> pRegions)
        {
            // SpanOverloader
            thisApi.CmdResolveImage(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, in pRegions.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetBlendConstants(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> blendConstants)
        {
            // SpanOverloader
            thisApi.CmdSetBlendConstants(commandBuffer, in blendConstants.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetScissor(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstScissor, [Count(Count = 0)] uint scissorCount, [Count(Parameter = "scissorCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Rect2D> pScissors)
        {
            // SpanOverloader
            thisApi.CmdSetScissor(commandBuffer, firstScissor, scissorCount, in pScissors.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetViewport(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstViewport, [Count(Count = 0)] uint viewportCount, [Count(Parameter = "viewportCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Viewport> pViewports)
        {
            // SpanOverloader
            thisApi.CmdSetViewport(commandBuffer, firstViewport, viewportCount, in pViewports.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdUpdateBuffer<T0>(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] ulong dstOffset, [Count(Count = 0)] ulong dataSize, [Count(Parameter = "dataSize")] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CmdUpdateBuffer(commandBuffer, dstBuffer, dstOffset, dataSize, ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdWaitEvents(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Event* pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageMemoryBarrier> pImageMemoryBarriers)
        {
            // SpanOverloader
            thisApi.CmdWaitEvents(commandBuffer, eventCount, pEvents, srcStageMask, dstStageMask, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, in pImageMemoryBarriers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdWaitEvents(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Event* pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferMemoryBarrier> pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers)
        {
            // SpanOverloader
            thisApi.CmdWaitEvents(commandBuffer, eventCount, pEvents, srcStageMask, dstStageMask, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, in pBufferMemoryBarriers.GetPinnableReference(), imageMemoryBarrierCount, pImageMemoryBarriers);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdWaitEvents(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Event* pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferMemoryBarrier> pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageMemoryBarrier> pImageMemoryBarriers)
        {
            // SpanOverloader
            thisApi.CmdWaitEvents(commandBuffer, eventCount, pEvents, srcStageMask, dstStageMask, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, in pBufferMemoryBarriers.GetPinnableReference(), imageMemoryBarrierCount, in pImageMemoryBarriers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdWaitEvents(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Event* pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemoryBarrier> pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers)
        {
            // SpanOverloader
            thisApi.CmdWaitEvents(commandBuffer, eventCount, pEvents, srcStageMask, dstStageMask, memoryBarrierCount, in pMemoryBarriers.GetPinnableReference(), bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdWaitEvents(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Event* pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemoryBarrier> pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageMemoryBarrier> pImageMemoryBarriers)
        {
            // SpanOverloader
            thisApi.CmdWaitEvents(commandBuffer, eventCount, pEvents, srcStageMask, dstStageMask, memoryBarrierCount, in pMemoryBarriers.GetPinnableReference(), bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, in pImageMemoryBarriers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdWaitEvents(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Event* pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemoryBarrier> pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferMemoryBarrier> pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers)
        {
            // SpanOverloader
            thisApi.CmdWaitEvents(commandBuffer, eventCount, pEvents, srcStageMask, dstStageMask, memoryBarrierCount, in pMemoryBarriers.GetPinnableReference(), bufferMemoryBarrierCount, in pBufferMemoryBarriers.GetPinnableReference(), imageMemoryBarrierCount, pImageMemoryBarriers);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdWaitEvents(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Event* pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemoryBarrier> pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferMemoryBarrier> pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageMemoryBarrier> pImageMemoryBarriers)
        {
            // SpanOverloader
            thisApi.CmdWaitEvents(commandBuffer, eventCount, pEvents, srcStageMask, dstStageMask, memoryBarrierCount, in pMemoryBarriers.GetPinnableReference(), bufferMemoryBarrierCount, in pBufferMemoryBarriers.GetPinnableReference(), imageMemoryBarrierCount, in pImageMemoryBarriers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdWaitEvents(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Event> pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers)
        {
            // SpanOverloader
            thisApi.CmdWaitEvents(commandBuffer, eventCount, in pEvents.GetPinnableReference(), srcStageMask, dstStageMask, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdWaitEvents(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Event> pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageMemoryBarrier> pImageMemoryBarriers)
        {
            // SpanOverloader
            thisApi.CmdWaitEvents(commandBuffer, eventCount, in pEvents.GetPinnableReference(), srcStageMask, dstStageMask, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, in pImageMemoryBarriers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdWaitEvents(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Event> pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferMemoryBarrier> pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers)
        {
            // SpanOverloader
            thisApi.CmdWaitEvents(commandBuffer, eventCount, in pEvents.GetPinnableReference(), srcStageMask, dstStageMask, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, in pBufferMemoryBarriers.GetPinnableReference(), imageMemoryBarrierCount, pImageMemoryBarriers);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdWaitEvents(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Event> pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferMemoryBarrier> pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageMemoryBarrier> pImageMemoryBarriers)
        {
            // SpanOverloader
            thisApi.CmdWaitEvents(commandBuffer, eventCount, in pEvents.GetPinnableReference(), srcStageMask, dstStageMask, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, in pBufferMemoryBarriers.GetPinnableReference(), imageMemoryBarrierCount, in pImageMemoryBarriers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdWaitEvents(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Event> pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemoryBarrier> pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers)
        {
            // SpanOverloader
            thisApi.CmdWaitEvents(commandBuffer, eventCount, in pEvents.GetPinnableReference(), srcStageMask, dstStageMask, memoryBarrierCount, in pMemoryBarriers.GetPinnableReference(), bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdWaitEvents(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Event> pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemoryBarrier> pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageMemoryBarrier> pImageMemoryBarriers)
        {
            // SpanOverloader
            thisApi.CmdWaitEvents(commandBuffer, eventCount, in pEvents.GetPinnableReference(), srcStageMask, dstStageMask, memoryBarrierCount, in pMemoryBarriers.GetPinnableReference(), bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, in pImageMemoryBarriers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdWaitEvents(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Event> pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemoryBarrier> pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferMemoryBarrier> pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers)
        {
            // SpanOverloader
            thisApi.CmdWaitEvents(commandBuffer, eventCount, in pEvents.GetPinnableReference(), srcStageMask, dstStageMask, memoryBarrierCount, in pMemoryBarriers.GetPinnableReference(), bufferMemoryBarrierCount, in pBufferMemoryBarriers.GetPinnableReference(), imageMemoryBarrierCount, pImageMemoryBarriers);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdWaitEvents(this Vk thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Event> pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemoryBarrier> pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferMemoryBarrier> pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageMemoryBarrier> pImageMemoryBarriers)
        {
            // SpanOverloader
            thisApi.CmdWaitEvents(commandBuffer, eventCount, in pEvents.GetPinnableReference(), srcStageMask, dstStageMask, memoryBarrierCount, in pMemoryBarriers.GetPinnableReference(), bufferMemoryBarrierCount, in pBufferMemoryBarriers.GetPinnableReference(), imageMemoryBarrierCount, in pImageMemoryBarriers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateBuffer(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Buffer> pBuffer)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(device, pCreateInfo, pAllocator, out pBuffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateBuffer(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Buffer* pBuffer)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(device, pCreateInfo, in pAllocator.GetPinnableReference(), pBuffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateBuffer(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Buffer> pBuffer)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pBuffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateBuffer(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Buffer* pBuffer)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(device, in pCreateInfo.GetPinnableReference(), pAllocator, pBuffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateBuffer(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Buffer> pBuffer)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pBuffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateBuffer(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Buffer* pBuffer)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pBuffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateBuffer(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Buffer> pBuffer)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pBuffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateBufferView(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferViewCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<BufferView> pView)
        {
            // SpanOverloader
            return thisApi.CreateBufferView(device, pCreateInfo, pAllocator, out pView.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateBufferView(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferViewCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] BufferView* pView)
        {
            // SpanOverloader
            return thisApi.CreateBufferView(device, pCreateInfo, in pAllocator.GetPinnableReference(), pView);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateBufferView(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferViewCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<BufferView> pView)
        {
            // SpanOverloader
            return thisApi.CreateBufferView(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pView.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateBufferView(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferViewCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] BufferView* pView)
        {
            // SpanOverloader
            return thisApi.CreateBufferView(device, in pCreateInfo.GetPinnableReference(), pAllocator, pView);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateBufferView(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferViewCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<BufferView> pView)
        {
            // SpanOverloader
            return thisApi.CreateBufferView(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pView.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateBufferView(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferViewCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] BufferView* pView)
        {
            // SpanOverloader
            return thisApi.CreateBufferView(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pView);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateBufferView(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferViewCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<BufferView> pView)
        {
            // SpanOverloader
            return thisApi.CreateBufferView(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pView.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCommandPool(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandPoolCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<CommandPool> pCommandPool)
        {
            // SpanOverloader
            return thisApi.CreateCommandPool(device, pCreateInfo, pAllocator, out pCommandPool.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCommandPool(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandPoolCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CommandPool* pCommandPool)
        {
            // SpanOverloader
            return thisApi.CreateCommandPool(device, pCreateInfo, in pAllocator.GetPinnableReference(), pCommandPool);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCommandPool(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandPoolCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<CommandPool> pCommandPool)
        {
            // SpanOverloader
            return thisApi.CreateCommandPool(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pCommandPool.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCommandPool(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CommandPoolCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CommandPool* pCommandPool)
        {
            // SpanOverloader
            return thisApi.CreateCommandPool(device, in pCreateInfo.GetPinnableReference(), pAllocator, pCommandPool);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCommandPool(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CommandPoolCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<CommandPool> pCommandPool)
        {
            // SpanOverloader
            return thisApi.CreateCommandPool(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pCommandPool.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCommandPool(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CommandPoolCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CommandPool* pCommandPool)
        {
            // SpanOverloader
            return thisApi.CreateCommandPool(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pCommandPool);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCommandPool(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CommandPoolCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<CommandPool> pCommandPool)
        {
            // SpanOverloader
            return thisApi.CreateCommandPool(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pCommandPool.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateComputePipelines(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineCreateInfo* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateComputePipelines(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateComputePipelines(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineCreateInfo* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateComputePipelines(device, pipelineCache, createInfoCount, pCreateInfos, in pAllocator.GetPinnableReference(), pPipelines);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateComputePipelines(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineCreateInfo* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateComputePipelines(device, pipelineCache, createInfoCount, pCreateInfos, in pAllocator.GetPinnableReference(), out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateComputePipelines(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ComputePipelineCreateInfo> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateComputePipelines(device, pipelineCache, createInfoCount, in pCreateInfos.GetPinnableReference(), pAllocator, pPipelines);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateComputePipelines(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ComputePipelineCreateInfo> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateComputePipelines(device, pipelineCache, createInfoCount, in pCreateInfos.GetPinnableReference(), pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateComputePipelines(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ComputePipelineCreateInfo> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateComputePipelines(device, pipelineCache, createInfoCount, in pCreateInfos.GetPinnableReference(), in pAllocator.GetPinnableReference(), pPipelines);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateComputePipelines(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ComputePipelineCreateInfo> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateComputePipelines(device, pipelineCache, createInfoCount, in pCreateInfos.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDescriptorPool(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorPoolCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DescriptorPool> pDescriptorPool)
        {
            // SpanOverloader
            return thisApi.CreateDescriptorPool(device, pCreateInfo, pAllocator, out pDescriptorPool.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDescriptorPool(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorPoolCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DescriptorPool* pDescriptorPool)
        {
            // SpanOverloader
            return thisApi.CreateDescriptorPool(device, pCreateInfo, in pAllocator.GetPinnableReference(), pDescriptorPool);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDescriptorPool(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorPoolCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DescriptorPool> pDescriptorPool)
        {
            // SpanOverloader
            return thisApi.CreateDescriptorPool(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pDescriptorPool.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDescriptorPool(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorPoolCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DescriptorPool* pDescriptorPool)
        {
            // SpanOverloader
            return thisApi.CreateDescriptorPool(device, in pCreateInfo.GetPinnableReference(), pAllocator, pDescriptorPool);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDescriptorPool(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorPoolCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DescriptorPool> pDescriptorPool)
        {
            // SpanOverloader
            return thisApi.CreateDescriptorPool(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pDescriptorPool.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDescriptorPool(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorPoolCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DescriptorPool* pDescriptorPool)
        {
            // SpanOverloader
            return thisApi.CreateDescriptorPool(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pDescriptorPool);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDescriptorPool(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorPoolCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DescriptorPool> pDescriptorPool)
        {
            // SpanOverloader
            return thisApi.CreateDescriptorPool(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pDescriptorPool.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDescriptorSetLayout(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorSetLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DescriptorSetLayout> pSetLayout)
        {
            // SpanOverloader
            return thisApi.CreateDescriptorSetLayout(device, pCreateInfo, pAllocator, out pSetLayout.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDescriptorSetLayout(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorSetLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DescriptorSetLayout* pSetLayout)
        {
            // SpanOverloader
            return thisApi.CreateDescriptorSetLayout(device, pCreateInfo, in pAllocator.GetPinnableReference(), pSetLayout);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDescriptorSetLayout(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorSetLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DescriptorSetLayout> pSetLayout)
        {
            // SpanOverloader
            return thisApi.CreateDescriptorSetLayout(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pSetLayout.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDescriptorSetLayout(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorSetLayoutCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DescriptorSetLayout* pSetLayout)
        {
            // SpanOverloader
            return thisApi.CreateDescriptorSetLayout(device, in pCreateInfo.GetPinnableReference(), pAllocator, pSetLayout);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDescriptorSetLayout(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorSetLayoutCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DescriptorSetLayout> pSetLayout)
        {
            // SpanOverloader
            return thisApi.CreateDescriptorSetLayout(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pSetLayout.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDescriptorSetLayout(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorSetLayoutCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DescriptorSetLayout* pSetLayout)
        {
            // SpanOverloader
            return thisApi.CreateDescriptorSetLayout(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pSetLayout);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDescriptorSetLayout(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorSetLayoutCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DescriptorSetLayout> pSetLayout)
        {
            // SpanOverloader
            return thisApi.CreateDescriptorSetLayout(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pSetLayout.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentDevice = *%$PARAM(pDevice)$%; }")]
        public static unsafe Result CreateDevice(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Device> pDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice(physicalDevice, pCreateInfo, pAllocator, out pDevice.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentDevice = *%$PARAM(pDevice)$%; }")]
        public static unsafe Result CreateDevice(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Device* pDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice(physicalDevice, pCreateInfo, in pAllocator.GetPinnableReference(), pDevice);
        }

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentDevice = *%$PARAM(pDevice)$%; }")]
        public static unsafe Result CreateDevice(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Device> pDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice(physicalDevice, pCreateInfo, in pAllocator.GetPinnableReference(), out pDevice.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentDevice = *%$PARAM(pDevice)$%; }")]
        public static unsafe Result CreateDevice(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DeviceCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Device* pDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice(physicalDevice, in pCreateInfo.GetPinnableReference(), pAllocator, pDevice);
        }

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentDevice = *%$PARAM(pDevice)$%; }")]
        public static unsafe Result CreateDevice(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DeviceCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Device> pDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice(physicalDevice, in pCreateInfo.GetPinnableReference(), pAllocator, out pDevice.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentDevice = *%$PARAM(pDevice)$%; }")]
        public static unsafe Result CreateDevice(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DeviceCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Device* pDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice(physicalDevice, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pDevice);
        }

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentDevice = *%$PARAM(pDevice)$%; }")]
        public static unsafe Result CreateDevice(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DeviceCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Device> pDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice(physicalDevice, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pDevice.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateEvent(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] EventCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Event> pEvent)
        {
            // SpanOverloader
            return thisApi.CreateEvent(device, pCreateInfo, pAllocator, out pEvent.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateEvent(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] EventCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Event* pEvent)
        {
            // SpanOverloader
            return thisApi.CreateEvent(device, pCreateInfo, in pAllocator.GetPinnableReference(), pEvent);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateEvent(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] EventCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Event> pEvent)
        {
            // SpanOverloader
            return thisApi.CreateEvent(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pEvent.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateEvent(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EventCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Event* pEvent)
        {
            // SpanOverloader
            return thisApi.CreateEvent(device, in pCreateInfo.GetPinnableReference(), pAllocator, pEvent);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateEvent(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EventCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Event> pEvent)
        {
            // SpanOverloader
            return thisApi.CreateEvent(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pEvent.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateEvent(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EventCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Event* pEvent)
        {
            // SpanOverloader
            return thisApi.CreateEvent(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pEvent);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateEvent(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EventCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Event> pEvent)
        {
            // SpanOverloader
            return thisApi.CreateEvent(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pEvent.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFence(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FenceCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Fence> pFence)
        {
            // SpanOverloader
            return thisApi.CreateFence(device, pCreateInfo, pAllocator, out pFence.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFence(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FenceCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Fence* pFence)
        {
            // SpanOverloader
            return thisApi.CreateFence(device, pCreateInfo, in pAllocator.GetPinnableReference(), pFence);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFence(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FenceCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Fence> pFence)
        {
            // SpanOverloader
            return thisApi.CreateFence(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pFence.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFence(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FenceCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Fence* pFence)
        {
            // SpanOverloader
            return thisApi.CreateFence(device, in pCreateInfo.GetPinnableReference(), pAllocator, pFence);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFence(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FenceCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Fence> pFence)
        {
            // SpanOverloader
            return thisApi.CreateFence(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pFence.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFence(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FenceCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Fence* pFence)
        {
            // SpanOverloader
            return thisApi.CreateFence(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pFence);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFence(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FenceCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Fence> pFence)
        {
            // SpanOverloader
            return thisApi.CreateFence(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pFence.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFramebuffer(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Framebuffer> pFramebuffer)
        {
            // SpanOverloader
            return thisApi.CreateFramebuffer(device, pCreateInfo, pAllocator, out pFramebuffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFramebuffer(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Framebuffer* pFramebuffer)
        {
            // SpanOverloader
            return thisApi.CreateFramebuffer(device, pCreateInfo, in pAllocator.GetPinnableReference(), pFramebuffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFramebuffer(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Framebuffer> pFramebuffer)
        {
            // SpanOverloader
            return thisApi.CreateFramebuffer(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pFramebuffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFramebuffer(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FramebufferCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Framebuffer* pFramebuffer)
        {
            // SpanOverloader
            return thisApi.CreateFramebuffer(device, in pCreateInfo.GetPinnableReference(), pAllocator, pFramebuffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFramebuffer(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FramebufferCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Framebuffer> pFramebuffer)
        {
            // SpanOverloader
            return thisApi.CreateFramebuffer(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pFramebuffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFramebuffer(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FramebufferCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Framebuffer* pFramebuffer)
        {
            // SpanOverloader
            return thisApi.CreateFramebuffer(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pFramebuffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFramebuffer(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FramebufferCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Framebuffer> pFramebuffer)
        {
            // SpanOverloader
            return thisApi.CreateFramebuffer(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pFramebuffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateGraphicsPipelines(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] GraphicsPipelineCreateInfo* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateGraphicsPipelines(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateGraphicsPipelines(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] GraphicsPipelineCreateInfo* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateGraphicsPipelines(device, pipelineCache, createInfoCount, pCreateInfos, in pAllocator.GetPinnableReference(), pPipelines);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateGraphicsPipelines(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] GraphicsPipelineCreateInfo* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateGraphicsPipelines(device, pipelineCache, createInfoCount, pCreateInfos, in pAllocator.GetPinnableReference(), out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateGraphicsPipelines(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GraphicsPipelineCreateInfo> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateGraphicsPipelines(device, pipelineCache, createInfoCount, in pCreateInfos.GetPinnableReference(), pAllocator, pPipelines);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateGraphicsPipelines(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GraphicsPipelineCreateInfo> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateGraphicsPipelines(device, pipelineCache, createInfoCount, in pCreateInfos.GetPinnableReference(), pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateGraphicsPipelines(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GraphicsPipelineCreateInfo> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateGraphicsPipelines(device, pipelineCache, createInfoCount, in pCreateInfos.GetPinnableReference(), in pAllocator.GetPinnableReference(), pPipelines);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateGraphicsPipelines(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GraphicsPipelineCreateInfo> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateGraphicsPipelines(device, pipelineCache, createInfoCount, in pCreateInfos.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateImage(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Image> pImage)
        {
            // SpanOverloader
            return thisApi.CreateImage(device, pCreateInfo, pAllocator, out pImage.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateImage(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Image* pImage)
        {
            // SpanOverloader
            return thisApi.CreateImage(device, pCreateInfo, in pAllocator.GetPinnableReference(), pImage);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateImage(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Image> pImage)
        {
            // SpanOverloader
            return thisApi.CreateImage(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pImage.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateImage(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Image* pImage)
        {
            // SpanOverloader
            return thisApi.CreateImage(device, in pCreateInfo.GetPinnableReference(), pAllocator, pImage);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateImage(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Image> pImage)
        {
            // SpanOverloader
            return thisApi.CreateImage(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pImage.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateImage(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Image* pImage)
        {
            // SpanOverloader
            return thisApi.CreateImage(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pImage);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateImage(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Image> pImage)
        {
            // SpanOverloader
            return thisApi.CreateImage(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pImage.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateImageView(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageViewCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ImageView> pView)
        {
            // SpanOverloader
            return thisApi.CreateImageView(device, pCreateInfo, pAllocator, out pView.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateImageView(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageViewCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ImageView* pView)
        {
            // SpanOverloader
            return thisApi.CreateImageView(device, pCreateInfo, in pAllocator.GetPinnableReference(), pView);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateImageView(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageViewCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ImageView> pView)
        {
            // SpanOverloader
            return thisApi.CreateImageView(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pView.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateImageView(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageViewCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ImageView* pView)
        {
            // SpanOverloader
            return thisApi.CreateImageView(device, in pCreateInfo.GetPinnableReference(), pAllocator, pView);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateImageView(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageViewCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ImageView> pView)
        {
            // SpanOverloader
            return thisApi.CreateImageView(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pView.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateImageView(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageViewCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ImageView* pView)
        {
            // SpanOverloader
            return thisApi.CreateImageView(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pView);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateImageView(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageViewCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ImageView> pView)
        {
            // SpanOverloader
            return thisApi.CreateImageView(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pView.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentInstance = *%$PARAM(pInstance)$%; }")]
        public static unsafe Result CreateInstance(this Vk thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InstanceCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Instance> pInstance)
        {
            // SpanOverloader
            return thisApi.CreateInstance(pCreateInfo, pAllocator, out pInstance.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentInstance = *%$PARAM(pInstance)$%; }")]
        public static unsafe Result CreateInstance(this Vk thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InstanceCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Instance* pInstance)
        {
            // SpanOverloader
            return thisApi.CreateInstance(pCreateInfo, in pAllocator.GetPinnableReference(), pInstance);
        }

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentInstance = *%$PARAM(pInstance)$%; }")]
        public static unsafe Result CreateInstance(this Vk thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InstanceCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Instance> pInstance)
        {
            // SpanOverloader
            return thisApi.CreateInstance(pCreateInfo, in pAllocator.GetPinnableReference(), out pInstance.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentInstance = *%$PARAM(pInstance)$%; }")]
        public static unsafe Result CreateInstance(this Vk thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InstanceCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Instance* pInstance)
        {
            // SpanOverloader
            return thisApi.CreateInstance(in pCreateInfo.GetPinnableReference(), pAllocator, pInstance);
        }

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentInstance = *%$PARAM(pInstance)$%; }")]
        public static unsafe Result CreateInstance(this Vk thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InstanceCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Instance> pInstance)
        {
            // SpanOverloader
            return thisApi.CreateInstance(in pCreateInfo.GetPinnableReference(), pAllocator, out pInstance.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentInstance = *%$PARAM(pInstance)$%; }")]
        public static unsafe Result CreateInstance(this Vk thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InstanceCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Instance* pInstance)
        {
            // SpanOverloader
            return thisApi.CreateInstance(in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pInstance);
        }

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentInstance = *%$PARAM(pInstance)$%; }")]
        public static unsafe Result CreateInstance(this Vk thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InstanceCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Instance> pInstance)
        {
            // SpanOverloader
            return thisApi.CreateInstance(in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pInstance.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePipelineCache(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineCacheCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PipelineCache> pPipelineCache)
        {
            // SpanOverloader
            return thisApi.CreatePipelineCache(device, pCreateInfo, pAllocator, out pPipelineCache.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePipelineCache(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineCacheCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PipelineCache* pPipelineCache)
        {
            // SpanOverloader
            return thisApi.CreatePipelineCache(device, pCreateInfo, in pAllocator.GetPinnableReference(), pPipelineCache);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePipelineCache(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineCacheCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PipelineCache> pPipelineCache)
        {
            // SpanOverloader
            return thisApi.CreatePipelineCache(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pPipelineCache.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePipelineCache(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineCacheCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PipelineCache* pPipelineCache)
        {
            // SpanOverloader
            return thisApi.CreatePipelineCache(device, in pCreateInfo.GetPinnableReference(), pAllocator, pPipelineCache);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePipelineCache(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineCacheCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PipelineCache> pPipelineCache)
        {
            // SpanOverloader
            return thisApi.CreatePipelineCache(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pPipelineCache.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePipelineCache(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineCacheCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PipelineCache* pPipelineCache)
        {
            // SpanOverloader
            return thisApi.CreatePipelineCache(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pPipelineCache);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePipelineCache(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineCacheCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PipelineCache> pPipelineCache)
        {
            // SpanOverloader
            return thisApi.CreatePipelineCache(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pPipelineCache.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePipelineLayout(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PipelineLayout> pPipelineLayout)
        {
            // SpanOverloader
            return thisApi.CreatePipelineLayout(device, pCreateInfo, pAllocator, out pPipelineLayout.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePipelineLayout(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PipelineLayout* pPipelineLayout)
        {
            // SpanOverloader
            return thisApi.CreatePipelineLayout(device, pCreateInfo, in pAllocator.GetPinnableReference(), pPipelineLayout);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePipelineLayout(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PipelineLayout> pPipelineLayout)
        {
            // SpanOverloader
            return thisApi.CreatePipelineLayout(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pPipelineLayout.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePipelineLayout(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineLayoutCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PipelineLayout* pPipelineLayout)
        {
            // SpanOverloader
            return thisApi.CreatePipelineLayout(device, in pCreateInfo.GetPinnableReference(), pAllocator, pPipelineLayout);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePipelineLayout(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineLayoutCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PipelineLayout> pPipelineLayout)
        {
            // SpanOverloader
            return thisApi.CreatePipelineLayout(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pPipelineLayout.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePipelineLayout(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineLayoutCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PipelineLayout* pPipelineLayout)
        {
            // SpanOverloader
            return thisApi.CreatePipelineLayout(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pPipelineLayout);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePipelineLayout(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineLayoutCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PipelineLayout> pPipelineLayout)
        {
            // SpanOverloader
            return thisApi.CreatePipelineLayout(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pPipelineLayout.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateQueryPool(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryPoolCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<QueryPool> pQueryPool)
        {
            // SpanOverloader
            return thisApi.CreateQueryPool(device, pCreateInfo, pAllocator, out pQueryPool.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateQueryPool(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryPoolCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] QueryPool* pQueryPool)
        {
            // SpanOverloader
            return thisApi.CreateQueryPool(device, pCreateInfo, in pAllocator.GetPinnableReference(), pQueryPool);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateQueryPool(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryPoolCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<QueryPool> pQueryPool)
        {
            // SpanOverloader
            return thisApi.CreateQueryPool(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pQueryPool.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateQueryPool(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<QueryPoolCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] QueryPool* pQueryPool)
        {
            // SpanOverloader
            return thisApi.CreateQueryPool(device, in pCreateInfo.GetPinnableReference(), pAllocator, pQueryPool);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateQueryPool(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<QueryPoolCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<QueryPool> pQueryPool)
        {
            // SpanOverloader
            return thisApi.CreateQueryPool(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pQueryPool.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateQueryPool(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<QueryPoolCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] QueryPool* pQueryPool)
        {
            // SpanOverloader
            return thisApi.CreateQueryPool(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pQueryPool);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateQueryPool(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<QueryPoolCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<QueryPool> pQueryPool)
        {
            // SpanOverloader
            return thisApi.CreateQueryPool(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pQueryPool.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRenderPass(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPassCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<RenderPass> pRenderPass)
        {
            // SpanOverloader
            return thisApi.CreateRenderPass(device, pCreateInfo, pAllocator, out pRenderPass.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRenderPass(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPassCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] RenderPass* pRenderPass)
        {
            // SpanOverloader
            return thisApi.CreateRenderPass(device, pCreateInfo, in pAllocator.GetPinnableReference(), pRenderPass);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRenderPass(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPassCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<RenderPass> pRenderPass)
        {
            // SpanOverloader
            return thisApi.CreateRenderPass(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pRenderPass.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRenderPass(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderPassCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] RenderPass* pRenderPass)
        {
            // SpanOverloader
            return thisApi.CreateRenderPass(device, in pCreateInfo.GetPinnableReference(), pAllocator, pRenderPass);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRenderPass(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderPassCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<RenderPass> pRenderPass)
        {
            // SpanOverloader
            return thisApi.CreateRenderPass(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pRenderPass.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRenderPass(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderPassCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] RenderPass* pRenderPass)
        {
            // SpanOverloader
            return thisApi.CreateRenderPass(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pRenderPass);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRenderPass(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderPassCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<RenderPass> pRenderPass)
        {
            // SpanOverloader
            return thisApi.CreateRenderPass(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pRenderPass.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSampler(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Sampler> pSampler)
        {
            // SpanOverloader
            return thisApi.CreateSampler(device, pCreateInfo, pAllocator, out pSampler.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSampler(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Sampler* pSampler)
        {
            // SpanOverloader
            return thisApi.CreateSampler(device, pCreateInfo, in pAllocator.GetPinnableReference(), pSampler);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSampler(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Sampler> pSampler)
        {
            // SpanOverloader
            return thisApi.CreateSampler(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pSampler.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSampler(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SamplerCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Sampler* pSampler)
        {
            // SpanOverloader
            return thisApi.CreateSampler(device, in pCreateInfo.GetPinnableReference(), pAllocator, pSampler);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSampler(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SamplerCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Sampler> pSampler)
        {
            // SpanOverloader
            return thisApi.CreateSampler(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pSampler.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSampler(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SamplerCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Sampler* pSampler)
        {
            // SpanOverloader
            return thisApi.CreateSampler(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pSampler);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSampler(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SamplerCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Sampler> pSampler)
        {
            // SpanOverloader
            return thisApi.CreateSampler(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pSampler.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSemaphore(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SemaphoreCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Semaphore> pSemaphore)
        {
            // SpanOverloader
            return thisApi.CreateSemaphore(device, pCreateInfo, pAllocator, out pSemaphore.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSemaphore(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SemaphoreCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Semaphore* pSemaphore)
        {
            // SpanOverloader
            return thisApi.CreateSemaphore(device, pCreateInfo, in pAllocator.GetPinnableReference(), pSemaphore);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSemaphore(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SemaphoreCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Semaphore> pSemaphore)
        {
            // SpanOverloader
            return thisApi.CreateSemaphore(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pSemaphore.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSemaphore(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SemaphoreCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Semaphore* pSemaphore)
        {
            // SpanOverloader
            return thisApi.CreateSemaphore(device, in pCreateInfo.GetPinnableReference(), pAllocator, pSemaphore);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSemaphore(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SemaphoreCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Semaphore> pSemaphore)
        {
            // SpanOverloader
            return thisApi.CreateSemaphore(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pSemaphore.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSemaphore(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SemaphoreCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Semaphore* pSemaphore)
        {
            // SpanOverloader
            return thisApi.CreateSemaphore(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pSemaphore);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSemaphore(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SemaphoreCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Semaphore> pSemaphore)
        {
            // SpanOverloader
            return thisApi.CreateSemaphore(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pSemaphore.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateShaderModule(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderModuleCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ShaderModule> pShaderModule)
        {
            // SpanOverloader
            return thisApi.CreateShaderModule(device, pCreateInfo, pAllocator, out pShaderModule.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateShaderModule(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderModuleCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ShaderModule* pShaderModule)
        {
            // SpanOverloader
            return thisApi.CreateShaderModule(device, pCreateInfo, in pAllocator.GetPinnableReference(), pShaderModule);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateShaderModule(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderModuleCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ShaderModule> pShaderModule)
        {
            // SpanOverloader
            return thisApi.CreateShaderModule(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pShaderModule.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateShaderModule(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ShaderModuleCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ShaderModule* pShaderModule)
        {
            // SpanOverloader
            return thisApi.CreateShaderModule(device, in pCreateInfo.GetPinnableReference(), pAllocator, pShaderModule);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateShaderModule(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ShaderModuleCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ShaderModule> pShaderModule)
        {
            // SpanOverloader
            return thisApi.CreateShaderModule(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pShaderModule.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateShaderModule(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ShaderModuleCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ShaderModule* pShaderModule)
        {
            // SpanOverloader
            return thisApi.CreateShaderModule(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pShaderModule);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateShaderModule(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ShaderModuleCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ShaderModule> pShaderModule)
        {
            // SpanOverloader
            return thisApi.CreateShaderModule(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pShaderModule.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyBuffer(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Buffer buffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyBuffer(device, buffer, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyBufferView(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] BufferView bufferView, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyBufferView(device, bufferView, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyCommandPool(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] CommandPool commandPool, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyCommandPool(device, commandPool, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyDescriptorPool(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorPool descriptorPool, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyDescriptorPool(device, descriptorPool, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyDescriptorSetLayout(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSetLayout descriptorSetLayout, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyDescriptorSetLayout(device, descriptorSetLayout, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyDevice(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyDevice(device, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyEvent(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Event @event, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyEvent(device, @event, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyFence(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Fence fence, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyFence(device, fence, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyFramebuffer(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Framebuffer framebuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyFramebuffer(device, framebuffer, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyImage(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyImage(device, image, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyImageView(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] ImageView imageView, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyImageView(device, imageView, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyInstance(this Vk thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyInstance(instance, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyPipeline(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyPipeline(device, pipeline, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyPipelineCache(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyPipelineCache(device, pipelineCache, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyPipelineLayout(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineLayout pipelineLayout, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyPipelineLayout(device, pipelineLayout, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyQueryPool(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyQueryPool(device, queryPool, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyRenderPass(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] RenderPass renderPass, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyRenderPass(device, renderPass, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroySampler(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Sampler sampler, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroySampler(device, sampler, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroySemaphore(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroySemaphore(device, semaphore, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyShaderModule(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] ShaderModule shaderModule, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyShaderModule(device, shaderModule, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateDeviceExtensionProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pLayerName, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount")] Span<ExtensionProperties> pProperties)
        {
            // SpanOverloader
            return thisApi.EnumerateDeviceExtensionProperties(physicalDevice, pLayerName, pPropertyCount, ref pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateDeviceExtensionProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pLayerName, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount")] ExtensionProperties* pProperties)
        {
            // SpanOverloader
            return thisApi.EnumerateDeviceExtensionProperties(physicalDevice, pLayerName, ref pPropertyCount.GetPinnableReference(), pProperties);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateDeviceExtensionProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pLayerName, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount")] Span<ExtensionProperties> pProperties)
        {
            // SpanOverloader
            return thisApi.EnumerateDeviceExtensionProperties(physicalDevice, pLayerName, ref pPropertyCount.GetPinnableReference(), ref pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateDeviceExtensionProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pLayerName, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount")] ExtensionProperties* pProperties)
        {
            // SpanOverloader
            return thisApi.EnumerateDeviceExtensionProperties(physicalDevice, in pLayerName.GetPinnableReference(), pPropertyCount, pProperties);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateDeviceExtensionProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pLayerName, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount")] Span<ExtensionProperties> pProperties)
        {
            // SpanOverloader
            return thisApi.EnumerateDeviceExtensionProperties(physicalDevice, in pLayerName.GetPinnableReference(), pPropertyCount, ref pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateDeviceExtensionProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pLayerName, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount")] ExtensionProperties* pProperties)
        {
            // SpanOverloader
            return thisApi.EnumerateDeviceExtensionProperties(physicalDevice, in pLayerName.GetPinnableReference(), ref pPropertyCount.GetPinnableReference(), pProperties);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateDeviceExtensionProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pLayerName, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount")] Span<ExtensionProperties> pProperties)
        {
            // SpanOverloader
            return thisApi.EnumerateDeviceExtensionProperties(physicalDevice, in pLayerName.GetPinnableReference(), ref pPropertyCount.GetPinnableReference(), ref pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateDeviceExtensionProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pLayerName, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount")] Span<ExtensionProperties> pProperties)
        {
            // SpanOverloader
            return thisApi.EnumerateDeviceExtensionProperties(physicalDevice, pLayerName, pPropertyCount, ref pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateDeviceExtensionProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pLayerName, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount")] ExtensionProperties* pProperties)
        {
            // SpanOverloader
            return thisApi.EnumerateDeviceExtensionProperties(physicalDevice, pLayerName, ref pPropertyCount.GetPinnableReference(), pProperties);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateDeviceExtensionProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pLayerName, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount")] Span<ExtensionProperties> pProperties)
        {
            // SpanOverloader
            return thisApi.EnumerateDeviceExtensionProperties(physicalDevice, pLayerName, ref pPropertyCount.GetPinnableReference(), ref pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateDeviceLayerProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount")] Span<LayerProperties> pProperties)
        {
            // SpanOverloader
            return thisApi.EnumerateDeviceLayerProperties(physicalDevice, pPropertyCount, ref pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateDeviceLayerProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount")] LayerProperties* pProperties)
        {
            // SpanOverloader
            return thisApi.EnumerateDeviceLayerProperties(physicalDevice, ref pPropertyCount.GetPinnableReference(), pProperties);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateDeviceLayerProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount")] Span<LayerProperties> pProperties)
        {
            // SpanOverloader
            return thisApi.EnumerateDeviceLayerProperties(physicalDevice, ref pPropertyCount.GetPinnableReference(), ref pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateInstanceExtensionProperties(this Vk thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pLayerName, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount")] Span<ExtensionProperties> pProperties)
        {
            // SpanOverloader
            return thisApi.EnumerateInstanceExtensionProperties(pLayerName, pPropertyCount, ref pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateInstanceExtensionProperties(this Vk thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pLayerName, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount")] ExtensionProperties* pProperties)
        {
            // SpanOverloader
            return thisApi.EnumerateInstanceExtensionProperties(pLayerName, ref pPropertyCount.GetPinnableReference(), pProperties);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateInstanceExtensionProperties(this Vk thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pLayerName, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount")] Span<ExtensionProperties> pProperties)
        {
            // SpanOverloader
            return thisApi.EnumerateInstanceExtensionProperties(pLayerName, ref pPropertyCount.GetPinnableReference(), ref pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateInstanceExtensionProperties(this Vk thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pLayerName, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount")] ExtensionProperties* pProperties)
        {
            // SpanOverloader
            return thisApi.EnumerateInstanceExtensionProperties(in pLayerName.GetPinnableReference(), pPropertyCount, pProperties);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateInstanceExtensionProperties(this Vk thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pLayerName, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount")] Span<ExtensionProperties> pProperties)
        {
            // SpanOverloader
            return thisApi.EnumerateInstanceExtensionProperties(in pLayerName.GetPinnableReference(), pPropertyCount, ref pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateInstanceExtensionProperties(this Vk thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pLayerName, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount")] ExtensionProperties* pProperties)
        {
            // SpanOverloader
            return thisApi.EnumerateInstanceExtensionProperties(in pLayerName.GetPinnableReference(), ref pPropertyCount.GetPinnableReference(), pProperties);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateInstanceExtensionProperties(this Vk thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pLayerName, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount")] Span<ExtensionProperties> pProperties)
        {
            // SpanOverloader
            return thisApi.EnumerateInstanceExtensionProperties(in pLayerName.GetPinnableReference(), ref pPropertyCount.GetPinnableReference(), ref pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateInstanceExtensionProperties(this Vk thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pLayerName, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount")] Span<ExtensionProperties> pProperties)
        {
            // SpanOverloader
            return thisApi.EnumerateInstanceExtensionProperties(pLayerName, pPropertyCount, ref pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateInstanceExtensionProperties(this Vk thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pLayerName, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount")] ExtensionProperties* pProperties)
        {
            // SpanOverloader
            return thisApi.EnumerateInstanceExtensionProperties(pLayerName, ref pPropertyCount.GetPinnableReference(), pProperties);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateInstanceExtensionProperties(this Vk thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pLayerName, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount")] Span<ExtensionProperties> pProperties)
        {
            // SpanOverloader
            return thisApi.EnumerateInstanceExtensionProperties(pLayerName, ref pPropertyCount.GetPinnableReference(), ref pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateInstanceLayerProperties(this Vk thisApi, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount")] Span<LayerProperties> pProperties)
        {
            // SpanOverloader
            return thisApi.EnumerateInstanceLayerProperties(pPropertyCount, ref pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateInstanceLayerProperties(this Vk thisApi, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount")] LayerProperties* pProperties)
        {
            // SpanOverloader
            return thisApi.EnumerateInstanceLayerProperties(ref pPropertyCount.GetPinnableReference(), pProperties);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateInstanceLayerProperties(this Vk thisApi, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount")] Span<LayerProperties> pProperties)
        {
            // SpanOverloader
            return thisApi.EnumerateInstanceLayerProperties(ref pPropertyCount.GetPinnableReference(), ref pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumeratePhysicalDevices(this Vk thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] uint* pPhysicalDeviceCount, [Count(Parameter = "pPhysicalDeviceCount")] Span<PhysicalDevice> pPhysicalDevices)
        {
            // SpanOverloader
            return thisApi.EnumeratePhysicalDevices(instance, pPhysicalDeviceCount, ref pPhysicalDevices.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumeratePhysicalDevices(this Vk thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] Span<uint> pPhysicalDeviceCount, [Count(Parameter = "pPhysicalDeviceCount")] PhysicalDevice* pPhysicalDevices)
        {
            // SpanOverloader
            return thisApi.EnumeratePhysicalDevices(instance, ref pPhysicalDeviceCount.GetPinnableReference(), pPhysicalDevices);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumeratePhysicalDevices(this Vk thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] Span<uint> pPhysicalDeviceCount, [Count(Parameter = "pPhysicalDeviceCount")] Span<PhysicalDevice> pPhysicalDevices)
        {
            // SpanOverloader
            return thisApi.EnumeratePhysicalDevices(instance, ref pPhysicalDeviceCount.GetPinnableReference(), ref pPhysicalDevices.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result FlushMappedMemoryRanges(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint memoryRangeCount, [Count(Parameter = "memoryRangeCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MappedMemoryRange> pMemoryRanges)
        {
            // SpanOverloader
            return thisApi.FlushMappedMemoryRanges(device, memoryRangeCount, in pMemoryRanges.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void FreeCommandBuffers(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] CommandPool commandPool, [Count(Count = 0)] uint commandBufferCount, [Count(Parameter = "commandBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CommandBuffer> pCommandBuffers)
        {
            // SpanOverloader
            thisApi.FreeCommandBuffers(device, commandPool, commandBufferCount, in pCommandBuffers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result FreeDescriptorSets(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorPool descriptorPool, [Count(Count = 0)] uint descriptorSetCount, [Count(Parameter = "descriptorSetCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorSet> pDescriptorSets)
        {
            // SpanOverloader
            return thisApi.FreeDescriptorSets(device, descriptorPool, descriptorSetCount, in pDescriptorSets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void FreeMemory(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.FreeMemory(device, memory, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetBufferMemoryRequirements(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Buffer buffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryRequirements> pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetBufferMemoryRequirements(device, buffer, out pMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetDeviceMemoryCommitment(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> pCommittedMemoryInBytes)
        {
            // SpanOverloader
            thisApi.GetDeviceMemoryCommitment(device, memory, out pCommittedMemoryInBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe PfnVoidFunction GetDeviceProcAddr(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pName)
        {
            // SpanOverloader
            return thisApi.GetDeviceProcAddr(device, in pName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetDeviceQueue(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint queueIndex, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Queue> pQueue)
        {
            // SpanOverloader
            thisApi.GetDeviceQueue(device, queueFamilyIndex, queueIndex, out pQueue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetImageMemoryRequirements(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryRequirements> pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetImageMemoryRequirements(device, image, out pMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetImageSparseMemoryRequirements(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0)] uint* pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SparseImageMemoryRequirements> pSparseMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetImageSparseMemoryRequirements(device, image, pSparseMemoryRequirementCount, out pSparseMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetImageSparseMemoryRequirements(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0)] Span<uint> pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SparseImageMemoryRequirements* pSparseMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetImageSparseMemoryRequirements(device, image, ref pSparseMemoryRequirementCount.GetPinnableReference(), pSparseMemoryRequirements);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetImageSparseMemoryRequirements(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0)] Span<uint> pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SparseImageMemoryRequirements> pSparseMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetImageSparseMemoryRequirements(device, image, ref pSparseMemoryRequirementCount.GetPinnableReference(), out pSparseMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetImageSubresourceLayout(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageSubresource* pSubresource, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SubresourceLayout> pLayout)
        {
            // SpanOverloader
            thisApi.GetImageSubresourceLayout(device, image, pSubresource, out pLayout.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetImageSubresourceLayout(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageSubresource> pSubresource, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SubresourceLayout* pLayout)
        {
            // SpanOverloader
            thisApi.GetImageSubresourceLayout(device, image, in pSubresource.GetPinnableReference(), pLayout);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetImageSubresourceLayout(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageSubresource> pSubresource, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SubresourceLayout> pLayout)
        {
            // SpanOverloader
            thisApi.GetImageSubresourceLayout(device, image, in pSubresource.GetPinnableReference(), out pLayout.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe PfnVoidFunction GetInstanceProcAddr(this Vk thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pName)
        {
            // SpanOverloader
            return thisApi.GetInstanceProcAddr(instance, in pName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetPhysicalDeviceFeatures(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PhysicalDeviceFeatures> pFeatures)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceFeatures(physicalDevice, out pFeatures.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetPhysicalDeviceFormatProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<FormatProperties> pFormatProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceFormatProperties(physicalDevice, format, out pFormatProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceImageFormatProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageType type, [Count(Count = 0)] ImageTiling tiling, [Count(Count = 0)] ImageUsageFlags usage, [Count(Count = 0)] ImageCreateFlags flags, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ImageFormatProperties> pImageFormatProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceImageFormatProperties(physicalDevice, format, type, tiling, usage, flags, out pImageFormatProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetPhysicalDeviceMemoryProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PhysicalDeviceMemoryProperties> pMemoryProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceMemoryProperties(physicalDevice, out pMemoryProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetPhysicalDeviceProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PhysicalDeviceProperties> pProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceProperties(physicalDevice, out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetPhysicalDeviceQueueFamilyProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pQueueFamilyPropertyCount, [Count(Parameter = "pQueueFamilyPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<QueueFamilyProperties> pQueueFamilyProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceQueueFamilyProperties(physicalDevice, pQueueFamilyPropertyCount, out pQueueFamilyProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetPhysicalDeviceQueueFamilyProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pQueueFamilyPropertyCount, [Count(Parameter = "pQueueFamilyPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] QueueFamilyProperties* pQueueFamilyProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceQueueFamilyProperties(physicalDevice, ref pQueueFamilyPropertyCount.GetPinnableReference(), pQueueFamilyProperties);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetPhysicalDeviceQueueFamilyProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pQueueFamilyPropertyCount, [Count(Parameter = "pQueueFamilyPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<QueueFamilyProperties> pQueueFamilyProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceQueueFamilyProperties(physicalDevice, ref pQueueFamilyPropertyCount.GetPinnableReference(), out pQueueFamilyProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetPhysicalDeviceSparseImageFormatProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageType type, [Count(Count = 0)] SampleCountFlags samples, [Count(Count = 0)] ImageUsageFlags usage, [Count(Count = 0)] ImageTiling tiling, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SparseImageFormatProperties> pProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceSparseImageFormatProperties(physicalDevice, format, type, samples, usage, tiling, pPropertyCount, out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetPhysicalDeviceSparseImageFormatProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageType type, [Count(Count = 0)] SampleCountFlags samples, [Count(Count = 0)] ImageUsageFlags usage, [Count(Count = 0)] ImageTiling tiling, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SparseImageFormatProperties* pProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceSparseImageFormatProperties(physicalDevice, format, type, samples, usage, tiling, ref pPropertyCount.GetPinnableReference(), pProperties);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetPhysicalDeviceSparseImageFormatProperties(this Vk thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageType type, [Count(Count = 0)] SampleCountFlags samples, [Count(Count = 0)] ImageUsageFlags usage, [Count(Count = 0)] ImageTiling tiling, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SparseImageFormatProperties> pProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceSparseImageFormatProperties(physicalDevice, format, type, samples, usage, tiling, ref pPropertyCount.GetPinnableReference(), out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPipelineCacheData<T0>(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] nuint* pDataSize, [Count(Parameter = "pDataSize")] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetPipelineCacheData(device, pipelineCache, pDataSize, ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPipelineCacheData(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] Span<nuint> pDataSize, [Count(Parameter = "pDataSize")] void* pData)
        {
            // SpanOverloader
            return thisApi.GetPipelineCacheData(device, pipelineCache, ref pDataSize.GetPinnableReference(), pData);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPipelineCacheData<T0>(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] Span<nuint> pDataSize, [Count(Parameter = "pDataSize")] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetPipelineCacheData(device, pipelineCache, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetQueryPoolResults<T0>(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery, [Count(Count = 0)] uint queryCount, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] Span<T0> pData, [Count(Count = 0)] ulong stride, [Count(Count = 0)] QueryResultFlags flags) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetQueryPoolResults(device, queryPool, firstQuery, queryCount, dataSize, ref pData.GetPinnableReference(), stride, flags);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetRenderAreaGranularity(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] RenderPass renderPass, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Extent2D> pGranularity)
        {
            // SpanOverloader
            thisApi.GetRenderAreaGranularity(device, renderPass, out pGranularity.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result InvalidateMappedMemoryRanges(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint memoryRangeCount, [Count(Parameter = "memoryRangeCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MappedMemoryRange> pMemoryRanges)
        {
            // SpanOverloader
            return thisApi.InvalidateMappedMemoryRanges(device, memoryRangeCount, in pMemoryRanges.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result MergePipelineCaches(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache dstCache, [Count(Count = 0)] uint srcCacheCount, [Count(Parameter = "srcCacheCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineCache> pSrcCaches)
        {
            // SpanOverloader
            return thisApi.MergePipelineCaches(device, dstCache, srcCacheCount, in pSrcCaches.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result QueueBindSparse(this Vk thisApi, [Count(Count = 0)] Queue queue, [Count(Count = 0)] uint bindInfoCount, [Count(Parameter = "bindInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BindSparseInfo> pBindInfo, [Count(Count = 0)] Fence fence)
        {
            // SpanOverloader
            return thisApi.QueueBindSparse(queue, bindInfoCount, in pBindInfo.GetPinnableReference(), fence);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result QueueSubmit(this Vk thisApi, [Count(Count = 0)] Queue queue, [Count(Count = 0)] uint submitCount, [Count(Parameter = "submitCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SubmitInfo> pSubmits, [Count(Count = 0)] Fence fence)
        {
            // SpanOverloader
            return thisApi.QueueSubmit(queue, submitCount, in pSubmits.GetPinnableReference(), fence);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ResetFences(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint fenceCount, [Count(Parameter = "fenceCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Fence> pFences)
        {
            // SpanOverloader
            return thisApi.ResetFences(device, fenceCount, in pFences.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void UpdateDescriptorSets(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint descriptorWriteCount, [Count(Parameter = "descriptorWriteCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] WriteDescriptorSet* pDescriptorWrites, [Count(Count = 0)] uint descriptorCopyCount, [Count(Parameter = "descriptorCopyCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyDescriptorSet> pDescriptorCopies)
        {
            // SpanOverloader
            thisApi.UpdateDescriptorSets(device, descriptorWriteCount, pDescriptorWrites, descriptorCopyCount, in pDescriptorCopies.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void UpdateDescriptorSets(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint descriptorWriteCount, [Count(Parameter = "descriptorWriteCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WriteDescriptorSet> pDescriptorWrites, [Count(Count = 0)] uint descriptorCopyCount, [Count(Parameter = "descriptorCopyCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyDescriptorSet* pDescriptorCopies)
        {
            // SpanOverloader
            thisApi.UpdateDescriptorSets(device, descriptorWriteCount, in pDescriptorWrites.GetPinnableReference(), descriptorCopyCount, pDescriptorCopies);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void UpdateDescriptorSets(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint descriptorWriteCount, [Count(Parameter = "descriptorWriteCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WriteDescriptorSet> pDescriptorWrites, [Count(Count = 0)] uint descriptorCopyCount, [Count(Parameter = "descriptorCopyCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyDescriptorSet> pDescriptorCopies)
        {
            // SpanOverloader
            thisApi.UpdateDescriptorSets(device, descriptorWriteCount, in pDescriptorWrites.GetPinnableReference(), descriptorCopyCount, in pDescriptorCopies.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result WaitForFences(this Vk thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint fenceCount, [Count(Parameter = "fenceCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Fence> pFences, [Count(Count = 0)] Bool32 waitAll, [Count(Count = 0)] ulong timeout)
        {
            // SpanOverloader
            return thisApi.WaitForFences(device, fenceCount, in pFences.GetPinnableReference(), waitAll, timeout);
        }

    }
}

