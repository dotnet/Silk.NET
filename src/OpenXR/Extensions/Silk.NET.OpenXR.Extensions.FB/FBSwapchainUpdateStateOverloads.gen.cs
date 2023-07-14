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

namespace Silk.NET.OpenXR.Extensions.FB
{
    public static class FBSwapchainUpdateStateOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetSwapchainStateFB(this FBSwapchainUpdateState thisApi, [Count(Count = 0)] Swapchain swapchain, [Count(Count = 0)] Span<SwapchainStateBaseHeaderFB> state)
        {
            // SpanOverloader
            return thisApi.GetSwapchainStateFB(swapchain, ref state.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result UpdateSwapchainFB(this FBSwapchainUpdateState thisApi, [Count(Count = 0)] Swapchain swapchain, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapchainStateBaseHeaderFB> state)
        {
            // SpanOverloader
            return thisApi.UpdateSwapchainFB(swapchain, in state.GetPinnableReference());
        }

    }
}

