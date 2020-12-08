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

namespace Silk.NET.OpenXR.Extensions.KHR
{
    public static class KhrAndroidSurfaceSwapchainOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSwapchainAndroidSurface(this KhrAndroidSurfaceSwapchain thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] SwapchainCreateInfo* info, [Count(Count = 0)] Swapchain* swapchain, [Count(Count = 0)] Span<IntPtr> surface)
        {
            // SpanOverloader
            return thisApi.CreateSwapchainAndroidSurface(session, info, swapchain, ref surface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSwapchainAndroidSurface(this KhrAndroidSurfaceSwapchain thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] SwapchainCreateInfo* info, [Count(Count = 0)] Span<Swapchain> swapchain, [Count(Count = 0)] IntPtr* surface)
        {
            // SpanOverloader
            return thisApi.CreateSwapchainAndroidSurface(session, info, ref swapchain.GetPinnableReference(), surface);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSwapchainAndroidSurface(this KhrAndroidSurfaceSwapchain thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] SwapchainCreateInfo* info, [Count(Count = 0)] Span<Swapchain> swapchain, [Count(Count = 0)] Span<IntPtr> surface)
        {
            // SpanOverloader
            return thisApi.CreateSwapchainAndroidSurface(session, info, ref swapchain.GetPinnableReference(), ref surface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSwapchainAndroidSurface(this KhrAndroidSurfaceSwapchain thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<SwapchainCreateInfo> info, [Count(Count = 0)] Swapchain* swapchain, [Count(Count = 0)] IntPtr* surface)
        {
            // SpanOverloader
            return thisApi.CreateSwapchainAndroidSurface(session, in info.GetPinnableReference(), swapchain, surface);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSwapchainAndroidSurface(this KhrAndroidSurfaceSwapchain thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<SwapchainCreateInfo> info, [Count(Count = 0)] Swapchain* swapchain, [Count(Count = 0)] Span<IntPtr> surface)
        {
            // SpanOverloader
            return thisApi.CreateSwapchainAndroidSurface(session, in info.GetPinnableReference(), swapchain, ref surface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSwapchainAndroidSurface(this KhrAndroidSurfaceSwapchain thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<SwapchainCreateInfo> info, [Count(Count = 0)] Span<Swapchain> swapchain, [Count(Count = 0)] IntPtr* surface)
        {
            // SpanOverloader
            return thisApi.CreateSwapchainAndroidSurface(session, in info.GetPinnableReference(), ref swapchain.GetPinnableReference(), surface);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSwapchainAndroidSurface(this KhrAndroidSurfaceSwapchain thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<SwapchainCreateInfo> info, [Count(Count = 0)] Span<Swapchain> swapchain, [Count(Count = 0)] Span<IntPtr> surface)
        {
            // SpanOverloader
            return thisApi.CreateSwapchainAndroidSurface(session, in info.GetPinnableReference(), ref swapchain.GetPinnableReference(), ref surface.GetPinnableReference());
        }

    }
}

