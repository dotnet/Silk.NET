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
    public static class KhrDisplaySwapchainOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSharedSwapchain(this KhrDisplaySwapchain thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapchainCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SwapchainKHR> pSwapchains)
        {
            // SpanOverloader
            return thisApi.CreateSharedSwapchain(device, swapchainCount, pCreateInfos, pAllocator, out pSwapchains.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSharedSwapchain(this KhrDisplaySwapchain thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapchainCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SwapchainKHR* pSwapchains)
        {
            // SpanOverloader
            return thisApi.CreateSharedSwapchain(device, swapchainCount, pCreateInfos, in pAllocator.GetPinnableReference(), pSwapchains);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSharedSwapchain(this KhrDisplaySwapchain thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapchainCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SwapchainKHR> pSwapchains)
        {
            // SpanOverloader
            return thisApi.CreateSharedSwapchain(device, swapchainCount, pCreateInfos, in pAllocator.GetPinnableReference(), out pSwapchains.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSharedSwapchain(this KhrDisplaySwapchain thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapchainCreateInfoKHR> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SwapchainKHR* pSwapchains)
        {
            // SpanOverloader
            return thisApi.CreateSharedSwapchain(device, swapchainCount, in pCreateInfos.GetPinnableReference(), pAllocator, pSwapchains);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSharedSwapchain(this KhrDisplaySwapchain thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapchainCreateInfoKHR> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SwapchainKHR> pSwapchains)
        {
            // SpanOverloader
            return thisApi.CreateSharedSwapchain(device, swapchainCount, in pCreateInfos.GetPinnableReference(), pAllocator, out pSwapchains.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSharedSwapchain(this KhrDisplaySwapchain thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapchainCreateInfoKHR> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SwapchainKHR* pSwapchains)
        {
            // SpanOverloader
            return thisApi.CreateSharedSwapchain(device, swapchainCount, in pCreateInfos.GetPinnableReference(), in pAllocator.GetPinnableReference(), pSwapchains);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSharedSwapchain(this KhrDisplaySwapchain thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapchainCreateInfoKHR> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SwapchainKHR> pSwapchains)
        {
            // SpanOverloader
            return thisApi.CreateSharedSwapchain(device, swapchainCount, in pCreateInfos.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pSwapchains.GetPinnableReference());
        }

    }
}

