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
    public static class KhrDisplaySwapchainOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe Result CreateSharedSwapchain(this KhrDisplaySwapchain thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] SwapchainCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Computed = "swapchainCount"), Flow(FlowDirection.Out)] Span<SwapchainKHR> pSwapchains)
        {
            // SpanOverloader
            return thisApi.CreateSharedSwapchain(device, swapchainCount, pCreateInfos, pAllocator, out pSwapchains.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CreateSharedSwapchain(this KhrDisplaySwapchain thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] SwapchainCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Computed = "swapchainCount"), Flow(FlowDirection.Out)] SwapchainKHR* pSwapchains)
        {
            // SpanOverloader
            return thisApi.CreateSharedSwapchain(device, swapchainCount, pCreateInfos, in pAllocator.GetPinnableReference(), pSwapchains);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CreateSharedSwapchain(this KhrDisplaySwapchain thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] SwapchainCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Computed = "swapchainCount"), Flow(FlowDirection.Out)] Span<SwapchainKHR> pSwapchains)
        {
            // SpanOverloader
            return thisApi.CreateSharedSwapchain(device, swapchainCount, pCreateInfos, in pAllocator.GetPinnableReference(), out pSwapchains.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CreateSharedSwapchain(this KhrDisplaySwapchain thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] ReadOnlySpan<SwapchainCreateInfoKHR> pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Computed = "swapchainCount"), Flow(FlowDirection.Out)] SwapchainKHR* pSwapchains)
        {
            // SpanOverloader
            return thisApi.CreateSharedSwapchain(device, swapchainCount, in pCreateInfos.GetPinnableReference(), pAllocator, pSwapchains);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CreateSharedSwapchain(this KhrDisplaySwapchain thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] ReadOnlySpan<SwapchainCreateInfoKHR> pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Computed = "swapchainCount"), Flow(FlowDirection.Out)] Span<SwapchainKHR> pSwapchains)
        {
            // SpanOverloader
            return thisApi.CreateSharedSwapchain(device, swapchainCount, in pCreateInfos.GetPinnableReference(), pAllocator, out pSwapchains.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CreateSharedSwapchain(this KhrDisplaySwapchain thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] ReadOnlySpan<SwapchainCreateInfoKHR> pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Computed = "swapchainCount"), Flow(FlowDirection.Out)] SwapchainKHR* pSwapchains)
        {
            // SpanOverloader
            return thisApi.CreateSharedSwapchain(device, swapchainCount, in pCreateInfos.GetPinnableReference(), in pAllocator.GetPinnableReference(), pSwapchains);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CreateSharedSwapchain(this KhrDisplaySwapchain thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] ReadOnlySpan<SwapchainCreateInfoKHR> pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Computed = "swapchainCount"), Flow(FlowDirection.Out)] Span<SwapchainKHR> pSwapchains)
        {
            // SpanOverloader
            return thisApi.CreateSharedSwapchain(device, swapchainCount, in pCreateInfos.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pSwapchains.GetPinnableReference());
        }

    }
}

