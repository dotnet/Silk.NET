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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    public static class KhrCreateRenderpass2Overloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdBeginRenderPass2(this KhrCreateRenderpass2 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPassBeginInfo* pRenderPassBegin, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SubpassBeginInfo> pSubpassBeginInfo)
        {
            // SpanOverloader
            thisApi.CmdBeginRenderPass2(commandBuffer, pRenderPassBegin, in pSubpassBeginInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBeginRenderPass2(this KhrCreateRenderpass2 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderPassBeginInfo> pRenderPassBegin, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SubpassBeginInfo* pSubpassBeginInfo)
        {
            // SpanOverloader
            thisApi.CmdBeginRenderPass2(commandBuffer, in pRenderPassBegin.GetPinnableReference(), pSubpassBeginInfo);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBeginRenderPass2(this KhrCreateRenderpass2 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderPassBeginInfo> pRenderPassBegin, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SubpassBeginInfo> pSubpassBeginInfo)
        {
            // SpanOverloader
            thisApi.CmdBeginRenderPass2(commandBuffer, in pRenderPassBegin.GetPinnableReference(), in pSubpassBeginInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdEndRenderPass2(this KhrCreateRenderpass2 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SubpassEndInfo> pSubpassEndInfo)
        {
            // SpanOverloader
            thisApi.CmdEndRenderPass2(commandBuffer, in pSubpassEndInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdNextSubpass2(this KhrCreateRenderpass2 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SubpassBeginInfo* pSubpassBeginInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SubpassEndInfo> pSubpassEndInfo)
        {
            // SpanOverloader
            thisApi.CmdNextSubpass2(commandBuffer, pSubpassBeginInfo, in pSubpassEndInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdNextSubpass2(this KhrCreateRenderpass2 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SubpassBeginInfo> pSubpassBeginInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SubpassEndInfo* pSubpassEndInfo)
        {
            // SpanOverloader
            thisApi.CmdNextSubpass2(commandBuffer, in pSubpassBeginInfo.GetPinnableReference(), pSubpassEndInfo);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdNextSubpass2(this KhrCreateRenderpass2 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SubpassBeginInfo> pSubpassBeginInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SubpassEndInfo> pSubpassEndInfo)
        {
            // SpanOverloader
            thisApi.CmdNextSubpass2(commandBuffer, in pSubpassBeginInfo.GetPinnableReference(), in pSubpassEndInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRenderPass2(this KhrCreateRenderpass2 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPassCreateInfo2* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<RenderPass> pRenderPass)
        {
            // SpanOverloader
            return thisApi.CreateRenderPass2(device, pCreateInfo, pAllocator, out pRenderPass.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRenderPass2(this KhrCreateRenderpass2 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPassCreateInfo2* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] RenderPass* pRenderPass)
        {
            // SpanOverloader
            return thisApi.CreateRenderPass2(device, pCreateInfo, in pAllocator.GetPinnableReference(), pRenderPass);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRenderPass2(this KhrCreateRenderpass2 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPassCreateInfo2* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<RenderPass> pRenderPass)
        {
            // SpanOverloader
            return thisApi.CreateRenderPass2(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pRenderPass.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRenderPass2(this KhrCreateRenderpass2 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderPassCreateInfo2> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] RenderPass* pRenderPass)
        {
            // SpanOverloader
            return thisApi.CreateRenderPass2(device, in pCreateInfo.GetPinnableReference(), pAllocator, pRenderPass);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRenderPass2(this KhrCreateRenderpass2 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderPassCreateInfo2> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<RenderPass> pRenderPass)
        {
            // SpanOverloader
            return thisApi.CreateRenderPass2(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pRenderPass.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRenderPass2(this KhrCreateRenderpass2 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderPassCreateInfo2> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] RenderPass* pRenderPass)
        {
            // SpanOverloader
            return thisApi.CreateRenderPass2(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pRenderPass);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRenderPass2(this KhrCreateRenderpass2 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderPassCreateInfo2> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<RenderPass> pRenderPass)
        {
            // SpanOverloader
            return thisApi.CreateRenderPass2(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pRenderPass.GetPinnableReference());
        }

    }
}

