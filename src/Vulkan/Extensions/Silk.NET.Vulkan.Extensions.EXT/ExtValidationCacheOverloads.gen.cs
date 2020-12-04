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
    public static class ExtValidationCacheOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe Result CreateValidationCache(this ExtValidationCache thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ValidationCacheCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Span<ValidationCacheEXT> pValidationCache)
        {
            // SpanOverloader
            return thisApi.CreateValidationCache(device, pCreateInfo, pAllocator, out pValidationCache.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CreateValidationCache(this ExtValidationCache thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ValidationCacheCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] ValidationCacheEXT* pValidationCache)
        {
            // SpanOverloader
            return thisApi.CreateValidationCache(device, pCreateInfo, in pAllocator.GetPinnableReference(), pValidationCache);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CreateValidationCache(this ExtValidationCache thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ValidationCacheCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Span<ValidationCacheEXT> pValidationCache)
        {
            // SpanOverloader
            return thisApi.CreateValidationCache(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pValidationCache.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CreateValidationCache(this ExtValidationCache thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<ValidationCacheCreateInfoEXT> pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] ValidationCacheEXT* pValidationCache)
        {
            // SpanOverloader
            return thisApi.CreateValidationCache(device, in pCreateInfo.GetPinnableReference(), pAllocator, pValidationCache);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CreateValidationCache(this ExtValidationCache thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<ValidationCacheCreateInfoEXT> pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Span<ValidationCacheEXT> pValidationCache)
        {
            // SpanOverloader
            return thisApi.CreateValidationCache(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pValidationCache.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CreateValidationCache(this ExtValidationCache thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<ValidationCacheCreateInfoEXT> pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] ValidationCacheEXT* pValidationCache)
        {
            // SpanOverloader
            return thisApi.CreateValidationCache(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pValidationCache);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CreateValidationCache(this ExtValidationCache thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<ValidationCacheCreateInfoEXT> pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Span<ValidationCacheEXT> pValidationCache)
        {
            // SpanOverloader
            return thisApi.CreateValidationCache(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pValidationCache.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe void DestroyValidationCache(this ExtValidationCache thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] ValidationCacheEXT validationCache, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyValidationCache(device, validationCache, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetValidationCacheData<T0>(this ExtValidationCache thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] ValidationCacheEXT validationCache, [Count(Count = 0)] UIntPtr* pDataSize, [Count(Computed = "pDataSize")] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetValidationCacheData(device, validationCache, pDataSize, ref pData.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetValidationCacheData(this ExtValidationCache thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] ValidationCacheEXT validationCache, [Count(Count = 0)] Span<UIntPtr> pDataSize, [Count(Computed = "pDataSize")] void* pData)
        {
            // SpanOverloader
            return thisApi.GetValidationCacheData(device, validationCache, ref pDataSize.GetPinnableReference(), pData);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetValidationCacheData<T0>(this ExtValidationCache thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] ValidationCacheEXT validationCache, [Count(Count = 0)] Span<UIntPtr> pDataSize, [Count(Computed = "pDataSize")] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetValidationCacheData(device, validationCache, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result MergeValidationCaches(this ExtValidationCache thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] ValidationCacheEXT dstCache, [Count(Count = 0)] uint srcCacheCount, [Count(Computed = "srcCacheCount"), Flow(FlowDirection.In)] ReadOnlySpan<ValidationCacheEXT> pSrcCaches)
        {
            // SpanOverloader
            return thisApi.MergeValidationCaches(device, dstCache, srcCacheCount, in pSrcCaches.GetPinnableReference());
        }

    }
}

