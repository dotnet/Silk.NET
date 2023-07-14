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
    public static class KhrXlibSurfaceOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateXlibSurface(this KhrXlibSurface thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] XlibSurfaceCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SurfaceKHR> pSurface)
        {
            // SpanOverloader
            return thisApi.CreateXlibSurface(instance, pCreateInfo, pAllocator, out pSurface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateXlibSurface(this KhrXlibSurface thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] XlibSurfaceCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceKHR* pSurface)
        {
            // SpanOverloader
            return thisApi.CreateXlibSurface(instance, pCreateInfo, in pAllocator.GetPinnableReference(), pSurface);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateXlibSurface(this KhrXlibSurface thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] XlibSurfaceCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SurfaceKHR> pSurface)
        {
            // SpanOverloader
            return thisApi.CreateXlibSurface(instance, pCreateInfo, in pAllocator.GetPinnableReference(), out pSurface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateXlibSurface(this KhrXlibSurface thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<XlibSurfaceCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceKHR* pSurface)
        {
            // SpanOverloader
            return thisApi.CreateXlibSurface(instance, in pCreateInfo.GetPinnableReference(), pAllocator, pSurface);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateXlibSurface(this KhrXlibSurface thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<XlibSurfaceCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SurfaceKHR> pSurface)
        {
            // SpanOverloader
            return thisApi.CreateXlibSurface(instance, in pCreateInfo.GetPinnableReference(), pAllocator, out pSurface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateXlibSurface(this KhrXlibSurface thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<XlibSurfaceCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceKHR* pSurface)
        {
            // SpanOverloader
            return thisApi.CreateXlibSurface(instance, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pSurface);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateXlibSurface(this KhrXlibSurface thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<XlibSurfaceCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SurfaceKHR> pSurface)
        {
            // SpanOverloader
            return thisApi.CreateXlibSurface(instance, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pSurface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Bool32 GetPhysicalDeviceXlibPresentationSupport(this KhrXlibSurface thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] Span<nint> dpy, [Count(Count = 0)] nint visualID)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceXlibPresentationSupport(physicalDevice, queueFamilyIndex, ref dpy.GetPinnableReference(), visualID);
        }

    }
}

