// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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
        public static unsafe Result CreatePrivateDataSlot(this ExtPrivateData thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PrivateDataSlotCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Span<PrivateDataSlotEXT> pPrivateDataSlot)
        {
            // SpanOverloader
            return thisApi.CreatePrivateDataSlot(device, pCreateInfo, pAllocator, out pPrivateDataSlot.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePrivateDataSlot(this ExtPrivateData thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PrivateDataSlotCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] PrivateDataSlotEXT* pPrivateDataSlot)
        {
            // SpanOverloader
            return thisApi.CreatePrivateDataSlot(device, pCreateInfo, in pAllocator.GetPinnableReference(), pPrivateDataSlot);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePrivateDataSlot(this ExtPrivateData thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PrivateDataSlotCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Span<PrivateDataSlotEXT> pPrivateDataSlot)
        {
            // SpanOverloader
            return thisApi.CreatePrivateDataSlot(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pPrivateDataSlot.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePrivateDataSlot(this ExtPrivateData thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<PrivateDataSlotCreateInfoEXT> pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] PrivateDataSlotEXT* pPrivateDataSlot)
        {
            // SpanOverloader
            return thisApi.CreatePrivateDataSlot(device, in pCreateInfo.GetPinnableReference(), pAllocator, pPrivateDataSlot);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePrivateDataSlot(this ExtPrivateData thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<PrivateDataSlotCreateInfoEXT> pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Span<PrivateDataSlotEXT> pPrivateDataSlot)
        {
            // SpanOverloader
            return thisApi.CreatePrivateDataSlot(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pPrivateDataSlot.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePrivateDataSlot(this ExtPrivateData thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<PrivateDataSlotCreateInfoEXT> pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] PrivateDataSlotEXT* pPrivateDataSlot)
        {
            // SpanOverloader
            return thisApi.CreatePrivateDataSlot(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pPrivateDataSlot);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePrivateDataSlot(this ExtPrivateData thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<PrivateDataSlotCreateInfoEXT> pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Span<PrivateDataSlotEXT> pPrivateDataSlot)
        {
            // SpanOverloader
            return thisApi.CreatePrivateDataSlot(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pPrivateDataSlot.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyPrivateDataSlot(this ExtPrivateData thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PrivateDataSlotEXT privateDataSlot, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyPrivateDataSlot(device, privateDataSlot, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetPrivateData(this ExtPrivateData thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] ObjectType objectType, [Count(Count = 0)] ulong objectHandle, [Count(Count = 0)] PrivateDataSlotEXT privateDataSlot, [Count(Count = 0), Flow(FlowDirection.Out)] Span<ulong> pData)
        {
            // SpanOverloader
            thisApi.GetPrivateData(device, objectType, objectHandle, privateDataSlot, out pData.GetPinnableReference());
        }

    }
}

