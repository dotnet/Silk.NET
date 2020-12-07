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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    public static class ExtDisplayControlOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe Result DisplayPowerControl(this ExtDisplayControl thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<DisplayPowerInfoEXT> pDisplayPowerInfo)
        {
            // SpanOverloader
            return thisApi.DisplayPowerControl(device, display, in pDisplayPowerInfo.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetSwapchainCounter(this ExtDisplayControl thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] SurfaceCounterFlagsEXT counter, [Count(Count = 0), Flow(FlowDirection.Out)] Span<ulong> pCounterValue)
        {
            // SpanOverloader
            return thisApi.GetSwapchainCounter(device, swapchain, counter, out pCounterValue.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result RegisterDeviceEvent(this ExtDisplayControl thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DeviceEventInfoEXT* pDeviceEventInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0)] Span<Fence> pFence)
        {
            // SpanOverloader
            return thisApi.RegisterDeviceEvent(device, pDeviceEventInfo, pAllocator, ref pFence.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result RegisterDeviceEvent(this ExtDisplayControl thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DeviceEventInfoEXT* pDeviceEventInfo, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0)] Fence* pFence)
        {
            // SpanOverloader
            return thisApi.RegisterDeviceEvent(device, pDeviceEventInfo, in pAllocator.GetPinnableReference(), pFence);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result RegisterDeviceEvent(this ExtDisplayControl thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DeviceEventInfoEXT* pDeviceEventInfo, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0)] Span<Fence> pFence)
        {
            // SpanOverloader
            return thisApi.RegisterDeviceEvent(device, pDeviceEventInfo, in pAllocator.GetPinnableReference(), ref pFence.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result RegisterDeviceEvent(this ExtDisplayControl thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<DeviceEventInfoEXT> pDeviceEventInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0)] Fence* pFence)
        {
            // SpanOverloader
            return thisApi.RegisterDeviceEvent(device, in pDeviceEventInfo.GetPinnableReference(), pAllocator, pFence);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result RegisterDeviceEvent(this ExtDisplayControl thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<DeviceEventInfoEXT> pDeviceEventInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0)] Span<Fence> pFence)
        {
            // SpanOverloader
            return thisApi.RegisterDeviceEvent(device, in pDeviceEventInfo.GetPinnableReference(), pAllocator, ref pFence.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result RegisterDeviceEvent(this ExtDisplayControl thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<DeviceEventInfoEXT> pDeviceEventInfo, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0)] Fence* pFence)
        {
            // SpanOverloader
            return thisApi.RegisterDeviceEvent(device, in pDeviceEventInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pFence);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result RegisterDeviceEvent(this ExtDisplayControl thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<DeviceEventInfoEXT> pDeviceEventInfo, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0)] Span<Fence> pFence)
        {
            // SpanOverloader
            return thisApi.RegisterDeviceEvent(device, in pDeviceEventInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), ref pFence.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result RegisterDisplayEvent(this ExtDisplayControl thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(FlowDirection.In)] DisplayEventInfoEXT* pDisplayEventInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0)] Span<Fence> pFence)
        {
            // SpanOverloader
            return thisApi.RegisterDisplayEvent(device, display, pDisplayEventInfo, pAllocator, ref pFence.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result RegisterDisplayEvent(this ExtDisplayControl thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(FlowDirection.In)] DisplayEventInfoEXT* pDisplayEventInfo, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0)] Fence* pFence)
        {
            // SpanOverloader
            return thisApi.RegisterDisplayEvent(device, display, pDisplayEventInfo, in pAllocator.GetPinnableReference(), pFence);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result RegisterDisplayEvent(this ExtDisplayControl thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(FlowDirection.In)] DisplayEventInfoEXT* pDisplayEventInfo, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0)] Span<Fence> pFence)
        {
            // SpanOverloader
            return thisApi.RegisterDisplayEvent(device, display, pDisplayEventInfo, in pAllocator.GetPinnableReference(), ref pFence.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result RegisterDisplayEvent(this ExtDisplayControl thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<DisplayEventInfoEXT> pDisplayEventInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0)] Fence* pFence)
        {
            // SpanOverloader
            return thisApi.RegisterDisplayEvent(device, display, in pDisplayEventInfo.GetPinnableReference(), pAllocator, pFence);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result RegisterDisplayEvent(this ExtDisplayControl thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<DisplayEventInfoEXT> pDisplayEventInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0)] Span<Fence> pFence)
        {
            // SpanOverloader
            return thisApi.RegisterDisplayEvent(device, display, in pDisplayEventInfo.GetPinnableReference(), pAllocator, ref pFence.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result RegisterDisplayEvent(this ExtDisplayControl thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<DisplayEventInfoEXT> pDisplayEventInfo, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0)] Fence* pFence)
        {
            // SpanOverloader
            return thisApi.RegisterDisplayEvent(device, display, in pDisplayEventInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pFence);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result RegisterDisplayEvent(this ExtDisplayControl thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<DisplayEventInfoEXT> pDisplayEventInfo, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0)] Span<Fence> pFence)
        {
            // SpanOverloader
            return thisApi.RegisterDisplayEvent(device, display, in pDisplayEventInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), ref pFence.GetPinnableReference());
        }

    }
}

