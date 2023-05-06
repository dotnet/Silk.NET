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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    public static class ExtPrivateDataOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePrivateDataSlot(this ExtPrivateData thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrivateDataSlotCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PrivateDataSlot> pPrivateDataSlot)
        {
            // SpanOverloader
            return thisApi.CreatePrivateDataSlot(device, pCreateInfo, pAllocator, out pPrivateDataSlot.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePrivateDataSlot(this ExtPrivateData thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrivateDataSlotCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PrivateDataSlot* pPrivateDataSlot)
        {
            // SpanOverloader
            return thisApi.CreatePrivateDataSlot(device, pCreateInfo, in pAllocator.GetPinnableReference(), pPrivateDataSlot);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePrivateDataSlot(this ExtPrivateData thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrivateDataSlotCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PrivateDataSlot> pPrivateDataSlot)
        {
            // SpanOverloader
            return thisApi.CreatePrivateDataSlot(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pPrivateDataSlot.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePrivateDataSlot(this ExtPrivateData thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PrivateDataSlotCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PrivateDataSlot* pPrivateDataSlot)
        {
            // SpanOverloader
            return thisApi.CreatePrivateDataSlot(device, in pCreateInfo.GetPinnableReference(), pAllocator, pPrivateDataSlot);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePrivateDataSlot(this ExtPrivateData thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PrivateDataSlotCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PrivateDataSlot> pPrivateDataSlot)
        {
            // SpanOverloader
            return thisApi.CreatePrivateDataSlot(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pPrivateDataSlot.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePrivateDataSlot(this ExtPrivateData thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PrivateDataSlotCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PrivateDataSlot* pPrivateDataSlot)
        {
            // SpanOverloader
            return thisApi.CreatePrivateDataSlot(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pPrivateDataSlot);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePrivateDataSlot(this ExtPrivateData thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PrivateDataSlotCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PrivateDataSlot> pPrivateDataSlot)
        {
            // SpanOverloader
            return thisApi.CreatePrivateDataSlot(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pPrivateDataSlot.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyPrivateDataSlot(this ExtPrivateData thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PrivateDataSlot privateDataSlot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyPrivateDataSlot(device, privateDataSlot, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetPrivateData(this ExtPrivateData thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] ObjectType objectType, [Count(Count = 0)] ulong objectHandle, [Count(Count = 0)] PrivateDataSlot privateDataSlot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> pData)
        {
            // SpanOverloader
            thisApi.GetPrivateData(device, objectType, objectHandle, privateDataSlot, out pData.GetPinnableReference());
        }

    }
}

