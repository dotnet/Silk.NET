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

namespace Silk.NET.OpenXR.Extensions.KHR
{
    public static class KhrAndroidSurfaceSwapchainOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSwapchainAndroidSurface(this KhrAndroidSurfaceSwapchain thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapchainCreateInfo* info, [Count(Count = 0)] Swapchain* swapchain, [Count(Count = 0)] Span<nint> surface)
        {
            // SpanOverloader
            return thisApi.CreateSwapchainAndroidSurface(session, info, swapchain, ref surface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSwapchainAndroidSurface(this KhrAndroidSurfaceSwapchain thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapchainCreateInfo* info, [Count(Count = 0)] Span<Swapchain> swapchain, [Count(Count = 0)] nint* surface)
        {
            // SpanOverloader
            return thisApi.CreateSwapchainAndroidSurface(session, info, ref swapchain.GetPinnableReference(), surface);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSwapchainAndroidSurface(this KhrAndroidSurfaceSwapchain thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapchainCreateInfo* info, [Count(Count = 0)] Span<Swapchain> swapchain, [Count(Count = 0)] Span<nint> surface)
        {
            // SpanOverloader
            return thisApi.CreateSwapchainAndroidSurface(session, info, ref swapchain.GetPinnableReference(), ref surface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSwapchainAndroidSurface(this KhrAndroidSurfaceSwapchain thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapchainCreateInfo> info, [Count(Count = 0)] Swapchain* swapchain, [Count(Count = 0)] nint* surface)
        {
            // SpanOverloader
            return thisApi.CreateSwapchainAndroidSurface(session, in info.GetPinnableReference(), swapchain, surface);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSwapchainAndroidSurface(this KhrAndroidSurfaceSwapchain thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapchainCreateInfo> info, [Count(Count = 0)] Swapchain* swapchain, [Count(Count = 0)] Span<nint> surface)
        {
            // SpanOverloader
            return thisApi.CreateSwapchainAndroidSurface(session, in info.GetPinnableReference(), swapchain, ref surface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSwapchainAndroidSurface(this KhrAndroidSurfaceSwapchain thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapchainCreateInfo> info, [Count(Count = 0)] Span<Swapchain> swapchain, [Count(Count = 0)] nint* surface)
        {
            // SpanOverloader
            return thisApi.CreateSwapchainAndroidSurface(session, in info.GetPinnableReference(), ref swapchain.GetPinnableReference(), surface);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSwapchainAndroidSurface(this KhrAndroidSurfaceSwapchain thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapchainCreateInfo> info, [Count(Count = 0)] Span<Swapchain> swapchain, [Count(Count = 0)] Span<nint> surface)
        {
            // SpanOverloader
            return thisApi.CreateSwapchainAndroidSurface(session, in info.GetPinnableReference(), ref swapchain.GetPinnableReference(), ref surface.GetPinnableReference());
        }

    }
}

