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

namespace Silk.NET.Vulkan.Extensions.NV
{
    public static class NVExternalComputeQueueOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateExternalComputeQueue(this NVExternalComputeQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ExternalComputeQueueCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ExternalComputeQueueNV> pExternalQueue)
        {
            // SpanOverloader
            return thisApi.CreateExternalComputeQueue(device, pCreateInfo, pAllocator, out pExternalQueue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateExternalComputeQueue(this NVExternalComputeQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ExternalComputeQueueCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ExternalComputeQueueNV* pExternalQueue)
        {
            // SpanOverloader
            return thisApi.CreateExternalComputeQueue(device, pCreateInfo, in pAllocator.GetPinnableReference(), pExternalQueue);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateExternalComputeQueue(this NVExternalComputeQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ExternalComputeQueueCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ExternalComputeQueueNV> pExternalQueue)
        {
            // SpanOverloader
            return thisApi.CreateExternalComputeQueue(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pExternalQueue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateExternalComputeQueue(this NVExternalComputeQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ExternalComputeQueueCreateInfoNV> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ExternalComputeQueueNV* pExternalQueue)
        {
            // SpanOverloader
            return thisApi.CreateExternalComputeQueue(device, in pCreateInfo.GetPinnableReference(), pAllocator, pExternalQueue);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateExternalComputeQueue(this NVExternalComputeQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ExternalComputeQueueCreateInfoNV> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ExternalComputeQueueNV> pExternalQueue)
        {
            // SpanOverloader
            return thisApi.CreateExternalComputeQueue(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pExternalQueue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateExternalComputeQueue(this NVExternalComputeQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ExternalComputeQueueCreateInfoNV> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ExternalComputeQueueNV* pExternalQueue)
        {
            // SpanOverloader
            return thisApi.CreateExternalComputeQueue(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pExternalQueue);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateExternalComputeQueue(this NVExternalComputeQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ExternalComputeQueueCreateInfoNV> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ExternalComputeQueueNV> pExternalQueue)
        {
            // SpanOverloader
            return thisApi.CreateExternalComputeQueue(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pExternalQueue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyExternalComputeQueue(this NVExternalComputeQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] ExternalComputeQueueNV externalQueue, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyExternalComputeQueue(device, externalQueue, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetExternalComputeQueueData<T0>(this NVExternalComputeQueue thisApi, [Count(Count = 0)] ExternalComputeQueueNV externalQueue, [Count(Count = 0)] ExternalComputeQueueDataParamsNV* @params, [Count(Count = 0)] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetExternalComputeQueueData(externalQueue, @params, ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetExternalComputeQueueData(this NVExternalComputeQueue thisApi, [Count(Count = 0)] ExternalComputeQueueNV externalQueue, [Count(Count = 0)] Span<ExternalComputeQueueDataParamsNV> @params, [Count(Count = 0)] void* pData)
        {
            // SpanOverloader
            thisApi.GetExternalComputeQueueData(externalQueue, ref @params.GetPinnableReference(), pData);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetExternalComputeQueueData<T0>(this NVExternalComputeQueue thisApi, [Count(Count = 0)] ExternalComputeQueueNV externalQueue, [Count(Count = 0)] Span<ExternalComputeQueueDataParamsNV> @params, [Count(Count = 0)] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetExternalComputeQueueData(externalQueue, ref @params.GetPinnableReference(), ref pData.GetPinnableReference());
        }

    }
}

