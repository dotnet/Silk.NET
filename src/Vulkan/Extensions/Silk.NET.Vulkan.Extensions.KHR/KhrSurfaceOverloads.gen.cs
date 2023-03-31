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
    public static class KhrSurfaceOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void DestroySurface(this KhrSurface thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroySurface(instance, surface, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceSurfaceCapabilities(this KhrSurface thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SurfaceCapabilitiesKHR> pSurfaceCapabilities)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceSurfaceCapabilities(physicalDevice, surface, out pSurfaceCapabilities.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceSurfaceFormats(this KhrSurface thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] uint* pSurfaceFormatCount, [Count(Parameter = "pSurfaceFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SurfaceFormatKHR> pSurfaceFormats)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceSurfaceFormats(physicalDevice, surface, pSurfaceFormatCount, out pSurfaceFormats.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceSurfaceFormats(this KhrSurface thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] Span<uint> pSurfaceFormatCount, [Count(Parameter = "pSurfaceFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceFormatKHR* pSurfaceFormats)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceSurfaceFormats(physicalDevice, surface, ref pSurfaceFormatCount.GetPinnableReference(), pSurfaceFormats);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceSurfaceFormats(this KhrSurface thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] Span<uint> pSurfaceFormatCount, [Count(Parameter = "pSurfaceFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SurfaceFormatKHR> pSurfaceFormats)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceSurfaceFormats(physicalDevice, surface, ref pSurfaceFormatCount.GetPinnableReference(), out pSurfaceFormats.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceSurfacePresentModes(this KhrSurface thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] uint* pPresentModeCount, [Count(Parameter = "pPresentModeCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PresentModeKHR> pPresentModes)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceSurfacePresentModes(physicalDevice, surface, pPresentModeCount, out pPresentModes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceSurfacePresentModes(this KhrSurface thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] Span<uint> pPresentModeCount, [Count(Parameter = "pPresentModeCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PresentModeKHR* pPresentModes)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceSurfacePresentModes(physicalDevice, surface, ref pPresentModeCount.GetPinnableReference(), pPresentModes);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceSurfacePresentModes(this KhrSurface thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] Span<uint> pPresentModeCount, [Count(Parameter = "pPresentModeCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PresentModeKHR> pPresentModes)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceSurfacePresentModes(physicalDevice, surface, ref pPresentModeCount.GetPinnableReference(), out pPresentModes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceSurfaceSupport(this KhrSurface thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Bool32> pSupported)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceSurfaceSupport(physicalDevice, queueFamilyIndex, surface, out pSupported.GetPinnableReference());
        }

    }
}

