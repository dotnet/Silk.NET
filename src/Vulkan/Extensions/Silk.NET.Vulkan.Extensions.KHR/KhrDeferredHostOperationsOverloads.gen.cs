// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    public static class KhrDeferredHostOperationsOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe Result CreateDeferredOperation(this KhrDeferredHostOperations thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Span<DeferredOperationKHR> pDeferredOperation)
        {
            // SpanOverloader
            return thisApi.CreateDeferredOperation(device, pAllocator, out pDeferredOperation.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CreateDeferredOperation(this KhrDeferredHostOperations thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DeferredOperationKHR* pDeferredOperation)
        {
            // SpanOverloader
            return thisApi.CreateDeferredOperation(device, in pAllocator.GetPinnableReference(), pDeferredOperation);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CreateDeferredOperation(this KhrDeferredHostOperations thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Span<DeferredOperationKHR> pDeferredOperation)
        {
            // SpanOverloader
            return thisApi.CreateDeferredOperation(device, in pAllocator.GetPinnableReference(), out pDeferredOperation.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe void DestroyDeferredOperation(this KhrDeferredHostOperations thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR operation, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyDeferredOperation(device, operation, in pAllocator.GetPinnableReference());
        }

    }
}

