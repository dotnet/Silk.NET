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
    public static class KhrDisplayOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDisplayMode(this KhrDisplay thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DisplayModeCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DisplayModeKHR> pMode)
        {
            // SpanOverloader
            return thisApi.CreateDisplayMode(physicalDevice, display, pCreateInfo, pAllocator, out pMode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDisplayMode(this KhrDisplay thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DisplayModeCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayModeKHR* pMode)
        {
            // SpanOverloader
            return thisApi.CreateDisplayMode(physicalDevice, display, pCreateInfo, in pAllocator.GetPinnableReference(), pMode);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDisplayMode(this KhrDisplay thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DisplayModeCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DisplayModeKHR> pMode)
        {
            // SpanOverloader
            return thisApi.CreateDisplayMode(physicalDevice, display, pCreateInfo, in pAllocator.GetPinnableReference(), out pMode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDisplayMode(this KhrDisplay thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DisplayModeCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayModeKHR* pMode)
        {
            // SpanOverloader
            return thisApi.CreateDisplayMode(physicalDevice, display, in pCreateInfo.GetPinnableReference(), pAllocator, pMode);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDisplayMode(this KhrDisplay thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DisplayModeCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DisplayModeKHR> pMode)
        {
            // SpanOverloader
            return thisApi.CreateDisplayMode(physicalDevice, display, in pCreateInfo.GetPinnableReference(), pAllocator, out pMode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDisplayMode(this KhrDisplay thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DisplayModeCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayModeKHR* pMode)
        {
            // SpanOverloader
            return thisApi.CreateDisplayMode(physicalDevice, display, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pMode);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDisplayMode(this KhrDisplay thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DisplayModeCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DisplayModeKHR> pMode)
        {
            // SpanOverloader
            return thisApi.CreateDisplayMode(physicalDevice, display, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pMode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDisplayPlaneSurface(this KhrDisplay thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DisplaySurfaceCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SurfaceKHR> pSurface)
        {
            // SpanOverloader
            return thisApi.CreateDisplayPlaneSurface(instance, pCreateInfo, pAllocator, out pSurface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDisplayPlaneSurface(this KhrDisplay thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DisplaySurfaceCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceKHR* pSurface)
        {
            // SpanOverloader
            return thisApi.CreateDisplayPlaneSurface(instance, pCreateInfo, in pAllocator.GetPinnableReference(), pSurface);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDisplayPlaneSurface(this KhrDisplay thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DisplaySurfaceCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SurfaceKHR> pSurface)
        {
            // SpanOverloader
            return thisApi.CreateDisplayPlaneSurface(instance, pCreateInfo, in pAllocator.GetPinnableReference(), out pSurface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDisplayPlaneSurface(this KhrDisplay thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DisplaySurfaceCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceKHR* pSurface)
        {
            // SpanOverloader
            return thisApi.CreateDisplayPlaneSurface(instance, in pCreateInfo.GetPinnableReference(), pAllocator, pSurface);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDisplayPlaneSurface(this KhrDisplay thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DisplaySurfaceCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SurfaceKHR> pSurface)
        {
            // SpanOverloader
            return thisApi.CreateDisplayPlaneSurface(instance, in pCreateInfo.GetPinnableReference(), pAllocator, out pSurface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDisplayPlaneSurface(this KhrDisplay thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DisplaySurfaceCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceKHR* pSurface)
        {
            // SpanOverloader
            return thisApi.CreateDisplayPlaneSurface(instance, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pSurface);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDisplayPlaneSurface(this KhrDisplay thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DisplaySurfaceCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SurfaceKHR> pSurface)
        {
            // SpanOverloader
            return thisApi.CreateDisplayPlaneSurface(instance, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pSurface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetDisplayModeProperties(this KhrDisplay thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DisplayModePropertiesKHR> pProperties)
        {
            // SpanOverloader
            return thisApi.GetDisplayModeProperties(physicalDevice, display, pPropertyCount, out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetDisplayModeProperties(this KhrDisplay thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayModePropertiesKHR* pProperties)
        {
            // SpanOverloader
            return thisApi.GetDisplayModeProperties(physicalDevice, display, ref pPropertyCount.GetPinnableReference(), pProperties);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetDisplayModeProperties(this KhrDisplay thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DisplayModePropertiesKHR> pProperties)
        {
            // SpanOverloader
            return thisApi.GetDisplayModeProperties(physicalDevice, display, ref pPropertyCount.GetPinnableReference(), out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetDisplayPlaneCapabilities(this KhrDisplay thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayModeKHR mode, [Count(Count = 0)] uint planeIndex, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DisplayPlaneCapabilitiesKHR> pCapabilities)
        {
            // SpanOverloader
            return thisApi.GetDisplayPlaneCapabilities(physicalDevice, mode, planeIndex, out pCapabilities.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetDisplayPlaneSupportedDisplays(this KhrDisplay thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint planeIndex, [Count(Count = 0)] uint* pDisplayCount, [Count(Parameter = "pDisplayCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DisplayKHR> pDisplays)
        {
            // SpanOverloader
            return thisApi.GetDisplayPlaneSupportedDisplays(physicalDevice, planeIndex, pDisplayCount, out pDisplays.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetDisplayPlaneSupportedDisplays(this KhrDisplay thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint planeIndex, [Count(Count = 0)] Span<uint> pDisplayCount, [Count(Parameter = "pDisplayCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayKHR* pDisplays)
        {
            // SpanOverloader
            return thisApi.GetDisplayPlaneSupportedDisplays(physicalDevice, planeIndex, ref pDisplayCount.GetPinnableReference(), pDisplays);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetDisplayPlaneSupportedDisplays(this KhrDisplay thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint planeIndex, [Count(Count = 0)] Span<uint> pDisplayCount, [Count(Parameter = "pDisplayCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DisplayKHR> pDisplays)
        {
            // SpanOverloader
            return thisApi.GetDisplayPlaneSupportedDisplays(physicalDevice, planeIndex, ref pDisplayCount.GetPinnableReference(), out pDisplays.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceDisplayPlaneProperties(this KhrDisplay thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DisplayPlanePropertiesKHR> pProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceDisplayPlaneProperties(physicalDevice, pPropertyCount, out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceDisplayPlaneProperties(this KhrDisplay thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayPlanePropertiesKHR* pProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceDisplayPlaneProperties(physicalDevice, ref pPropertyCount.GetPinnableReference(), pProperties);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceDisplayPlaneProperties(this KhrDisplay thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DisplayPlanePropertiesKHR> pProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceDisplayPlaneProperties(physicalDevice, ref pPropertyCount.GetPinnableReference(), out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceDisplayProperties(this KhrDisplay thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DisplayPropertiesKHR> pProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceDisplayProperties(physicalDevice, pPropertyCount, out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceDisplayProperties(this KhrDisplay thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayPropertiesKHR* pProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceDisplayProperties(physicalDevice, ref pPropertyCount.GetPinnableReference(), pProperties);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceDisplayProperties(this KhrDisplay thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DisplayPropertiesKHR> pProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceDisplayProperties(physicalDevice, ref pPropertyCount.GetPinnableReference(), out pProperties.GetPinnableReference());
        }

    }
}

