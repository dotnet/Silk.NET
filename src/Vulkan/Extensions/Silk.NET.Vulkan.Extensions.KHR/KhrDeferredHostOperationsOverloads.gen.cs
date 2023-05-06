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
    public static class KhrDeferredHostOperationsOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDeferredOperation(this KhrDeferredHostOperations thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DeferredOperationKHR> pDeferredOperation)
        {
            // SpanOverloader
            return thisApi.CreateDeferredOperation(device, pAllocator, out pDeferredOperation.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDeferredOperation(this KhrDeferredHostOperations thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DeferredOperationKHR* pDeferredOperation)
        {
            // SpanOverloader
            return thisApi.CreateDeferredOperation(device, in pAllocator.GetPinnableReference(), pDeferredOperation);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDeferredOperation(this KhrDeferredHostOperations thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DeferredOperationKHR> pDeferredOperation)
        {
            // SpanOverloader
            return thisApi.CreateDeferredOperation(device, in pAllocator.GetPinnableReference(), out pDeferredOperation.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyDeferredOperation(this KhrDeferredHostOperations thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR operation, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyDeferredOperation(device, operation, in pAllocator.GetPinnableReference());
        }

    }
}

