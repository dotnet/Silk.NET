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

namespace Silk.NET.Vulkan.Extensions.MVK
{
    public static class MvkIosSurfaceOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe Result CreateIossurface(this MvkIosSurface thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] IOSSurfaceCreateInfoMVK* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Span<SurfaceKHR> pSurface)
        {
            // SpanOverloader
            return thisApi.CreateIossurface(instance, pCreateInfo, pAllocator, out pSurface.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CreateIossurface(this MvkIosSurface thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] IOSSurfaceCreateInfoMVK* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceKHR* pSurface)
        {
            // SpanOverloader
            return thisApi.CreateIossurface(instance, pCreateInfo, in pAllocator.GetPinnableReference(), pSurface);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CreateIossurface(this MvkIosSurface thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] IOSSurfaceCreateInfoMVK* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Span<SurfaceKHR> pSurface)
        {
            // SpanOverloader
            return thisApi.CreateIossurface(instance, pCreateInfo, in pAllocator.GetPinnableReference(), out pSurface.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CreateIossurface(this MvkIosSurface thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<IOSSurfaceCreateInfoMVK> pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceKHR* pSurface)
        {
            // SpanOverloader
            return thisApi.CreateIossurface(instance, in pCreateInfo.GetPinnableReference(), pAllocator, pSurface);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CreateIossurface(this MvkIosSurface thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<IOSSurfaceCreateInfoMVK> pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Span<SurfaceKHR> pSurface)
        {
            // SpanOverloader
            return thisApi.CreateIossurface(instance, in pCreateInfo.GetPinnableReference(), pAllocator, out pSurface.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CreateIossurface(this MvkIosSurface thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<IOSSurfaceCreateInfoMVK> pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceKHR* pSurface)
        {
            // SpanOverloader
            return thisApi.CreateIossurface(instance, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pSurface);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CreateIossurface(this MvkIosSurface thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<IOSSurfaceCreateInfoMVK> pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Span<SurfaceKHR> pSurface)
        {
            // SpanOverloader
            return thisApi.CreateIossurface(instance, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pSurface.GetPinnableReference());
        }

    }
}

