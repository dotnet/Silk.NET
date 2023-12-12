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

namespace Silk.NET.Vulkan.Extensions.NV
{
    public static class NVLowLatency2Overloads
    {
        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pLatencyMarkerInfo = new(StructureType.GetLatencyMarkerInfoNV);")]
        public static unsafe void GetLatencyTiming(this NVLowLatency2 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<GetLatencyMarkerInfoNV> pLatencyMarkerInfo)
        {
            // SpanOverloader
            thisApi.GetLatencyTiming(device, swapchain, out pLatencyMarkerInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LatencySleep(this NVLowLatency2 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<LatencySleepInfoNV> pSleepInfo)
        {
            // SpanOverloader
            return thisApi.LatencySleep(device, swapchain, in pSleepInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void QueueNotifyOutOfBan(this NVLowLatency2 thisApi, [Count(Count = 0)] Queue queue, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<OutOfBandQueueTypeInfoNV> pQueueTypeInfo)
        {
            // SpanOverloader
            thisApi.QueueNotifyOutOfBan(queue, in pQueueTypeInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void SetLatencyMarker(this NVLowLatency2 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SetLatencyMarkerInfoNV> pLatencyMarkerInfo)
        {
            // SpanOverloader
            thisApi.SetLatencyMarker(device, swapchain, in pLatencyMarkerInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result SetLatencySleepMode(this NVLowLatency2 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<LatencySleepModeInfoNV> pSleepModeInfo)
        {
            // SpanOverloader
            return thisApi.SetLatencySleepMode(device, swapchain, in pSleepModeInfo.GetPinnableReference());
        }

    }
}

