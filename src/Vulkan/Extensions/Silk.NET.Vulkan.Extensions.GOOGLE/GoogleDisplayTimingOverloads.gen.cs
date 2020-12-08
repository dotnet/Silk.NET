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

namespace Silk.NET.Vulkan.Extensions.GOOGLE
{
    public static class GoogleDisplayTimingOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetPastPresentationTiming(this GoogleDisplayTiming thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] uint* pPresentationTimingCount, [Count(Computed = "pPresentationTimingCount"), Flow(FlowDirection.Out)] Span<PastPresentationTimingGOOGLE> pPresentationTimings)
        {
            // SpanOverloader
            return thisApi.GetPastPresentationTiming(device, swapchain, pPresentationTimingCount, out pPresentationTimings.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPastPresentationTiming(this GoogleDisplayTiming thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] Span<uint> pPresentationTimingCount, [Count(Computed = "pPresentationTimingCount"), Flow(FlowDirection.Out)] PastPresentationTimingGOOGLE* pPresentationTimings)
        {
            // SpanOverloader
            return thisApi.GetPastPresentationTiming(device, swapchain, ref pPresentationTimingCount.GetPinnableReference(), pPresentationTimings);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPastPresentationTiming(this GoogleDisplayTiming thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] Span<uint> pPresentationTimingCount, [Count(Computed = "pPresentationTimingCount"), Flow(FlowDirection.Out)] Span<PastPresentationTimingGOOGLE> pPresentationTimings)
        {
            // SpanOverloader
            return thisApi.GetPastPresentationTiming(device, swapchain, ref pPresentationTimingCount.GetPinnableReference(), out pPresentationTimings.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetRefreshCycleDuration(this GoogleDisplayTiming thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0), Flow(FlowDirection.Out)] Span<RefreshCycleDurationGOOGLE> pDisplayTimingProperties)
        {
            // SpanOverloader
            return thisApi.GetRefreshCycleDuration(device, swapchain, out pDisplayTimingProperties.GetPinnableReference());
        }

    }
}

