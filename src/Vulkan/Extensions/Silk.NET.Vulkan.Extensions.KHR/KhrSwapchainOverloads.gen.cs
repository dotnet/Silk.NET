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
    public static class KhrSwapchainOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result AcquireNextImage(this KhrSwapchain thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] ulong timeout, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0)] Fence fence, [Count(Count = 0)] Span<uint> pImageIndex)
        {
            // SpanOverloader
            return thisApi.AcquireNextImage(device, swapchain, timeout, semaphore, fence, ref pImageIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result AcquireNextImage2(this KhrSwapchain thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AcquireNextImageInfoKHR* pAcquireInfo, [Count(Count = 0)] Span<uint> pImageIndex)
        {
            // SpanOverloader
            return thisApi.AcquireNextImage2(device, pAcquireInfo, ref pImageIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result AcquireNextImage2(this KhrSwapchain thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AcquireNextImageInfoKHR> pAcquireInfo, [Count(Count = 0)] uint* pImageIndex)
        {
            // SpanOverloader
            return thisApi.AcquireNextImage2(device, in pAcquireInfo.GetPinnableReference(), pImageIndex);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result AcquireNextImage2(this KhrSwapchain thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AcquireNextImageInfoKHR> pAcquireInfo, [Count(Count = 0)] Span<uint> pImageIndex)
        {
            // SpanOverloader
            return thisApi.AcquireNextImage2(device, in pAcquireInfo.GetPinnableReference(), ref pImageIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSwapchain(this KhrSwapchain thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapchainCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SwapchainKHR> pSwapchain)
        {
            // SpanOverloader
            return thisApi.CreateSwapchain(device, pCreateInfo, pAllocator, out pSwapchain.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSwapchain(this KhrSwapchain thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapchainCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SwapchainKHR* pSwapchain)
        {
            // SpanOverloader
            return thisApi.CreateSwapchain(device, pCreateInfo, in pAllocator.GetPinnableReference(), pSwapchain);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSwapchain(this KhrSwapchain thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapchainCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SwapchainKHR> pSwapchain)
        {
            // SpanOverloader
            return thisApi.CreateSwapchain(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pSwapchain.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSwapchain(this KhrSwapchain thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapchainCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SwapchainKHR* pSwapchain)
        {
            // SpanOverloader
            return thisApi.CreateSwapchain(device, in pCreateInfo.GetPinnableReference(), pAllocator, pSwapchain);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSwapchain(this KhrSwapchain thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapchainCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SwapchainKHR> pSwapchain)
        {
            // SpanOverloader
            return thisApi.CreateSwapchain(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pSwapchain.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSwapchain(this KhrSwapchain thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapchainCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SwapchainKHR* pSwapchain)
        {
            // SpanOverloader
            return thisApi.CreateSwapchain(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pSwapchain);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSwapchain(this KhrSwapchain thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapchainCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SwapchainKHR> pSwapchain)
        {
            // SpanOverloader
            return thisApi.CreateSwapchain(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pSwapchain.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroySwapchain(this KhrSwapchain thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroySwapchain(device, swapchain, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pDeviceGroupPresentCapabilities = new(StructureType.DeviceGroupPresentCapabilitiesKhr);")]
        public static unsafe Result GetDeviceGroupPresentCapabilities(this KhrSwapchain thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DeviceGroupPresentCapabilitiesKHR> pDeviceGroupPresentCapabilities)
        {
            // SpanOverloader
            return thisApi.GetDeviceGroupPresentCapabilities(device, out pDeviceGroupPresentCapabilities.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetDeviceGroupSurfacePresentModes(this KhrSwapchain thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DeviceGroupPresentModeFlagsKHR> pModes)
        {
            // SpanOverloader
            return thisApi.GetDeviceGroupSurfacePresentModes(device, surface, out pModes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDevicePresentRectangles(this KhrSwapchain thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] uint* pRectCount, [Count(Parameter = "pRectCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Rect2D> pRects)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDevicePresentRectangles(physicalDevice, surface, pRectCount, out pRects.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDevicePresentRectangles(this KhrSwapchain thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] Span<uint> pRectCount, [Count(Parameter = "pRectCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Rect2D* pRects)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDevicePresentRectangles(physicalDevice, surface, ref pRectCount.GetPinnableReference(), pRects);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDevicePresentRectangles(this KhrSwapchain thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] Span<uint> pRectCount, [Count(Parameter = "pRectCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Rect2D> pRects)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDevicePresentRectangles(physicalDevice, surface, ref pRectCount.GetPinnableReference(), out pRects.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSwapchainImages(this KhrSwapchain thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] uint* pSwapchainImageCount, [Count(Parameter = "pSwapchainImageCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Image> pSwapchainImages)
        {
            // SpanOverloader
            return thisApi.GetSwapchainImages(device, swapchain, pSwapchainImageCount, out pSwapchainImages.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSwapchainImages(this KhrSwapchain thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] Span<uint> pSwapchainImageCount, [Count(Parameter = "pSwapchainImageCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Image* pSwapchainImages)
        {
            // SpanOverloader
            return thisApi.GetSwapchainImages(device, swapchain, ref pSwapchainImageCount.GetPinnableReference(), pSwapchainImages);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSwapchainImages(this KhrSwapchain thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] Span<uint> pSwapchainImageCount, [Count(Parameter = "pSwapchainImageCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Image> pSwapchainImages)
        {
            // SpanOverloader
            return thisApi.GetSwapchainImages(device, swapchain, ref pSwapchainImageCount.GetPinnableReference(), out pSwapchainImages.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result QueuePresent(this KhrSwapchain thisApi, [Count(Count = 0)] Queue queue, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PresentInfoKHR> pPresentInfo)
        {
            // SpanOverloader
            return thisApi.QueuePresent(queue, in pPresentInfo.GetPinnableReference());
        }

    }
}

