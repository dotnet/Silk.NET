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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    public static class ExtPresentTimingOverloads
    {
        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pPastPresentationTimingProperties = new(StructureType.PastPresentationTimingPropertiesExt);")]
        public static unsafe Result GetPastPresentationTiming(this ExtPresentTiming thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PastPresentationTimingInfoEXT* pPastPresentationTimingInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PastPresentationTimingPropertiesEXT> pPastPresentationTimingProperties)
        {
            // SpanOverloader
            return thisApi.GetPastPresentationTiming(device, pPastPresentationTimingInfo, out pPastPresentationTimingProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPastPresentationTiming(this ExtPresentTiming thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PastPresentationTimingInfoEXT> pPastPresentationTimingInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PastPresentationTimingPropertiesEXT* pPastPresentationTimingProperties)
        {
            // SpanOverloader
            return thisApi.GetPastPresentationTiming(device, in pPastPresentationTimingInfo.GetPinnableReference(), pPastPresentationTimingProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pPastPresentationTimingProperties = new(StructureType.PastPresentationTimingPropertiesExt);")]
        public static unsafe Result GetPastPresentationTiming(this ExtPresentTiming thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PastPresentationTimingInfoEXT> pPastPresentationTimingInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PastPresentationTimingPropertiesEXT> pPastPresentationTimingProperties)
        {
            // SpanOverloader
            return thisApi.GetPastPresentationTiming(device, in pPastPresentationTimingInfo.GetPinnableReference(), out pPastPresentationTimingProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSwapchainTimeDomainProperties(this ExtPresentTiming thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] SwapchainTimeDomainPropertiesEXT* pSwapchainTimeDomainProperties, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> pTimeDomainsCounter)
        {
            // SpanOverloader
            return thisApi.GetSwapchainTimeDomainProperties(device, swapchain, pSwapchainTimeDomainProperties, out pTimeDomainsCounter.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSwapchainTimeDomainProperties(this ExtPresentTiming thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] Span<SwapchainTimeDomainPropertiesEXT> pSwapchainTimeDomainProperties, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* pTimeDomainsCounter)
        {
            // SpanOverloader
            return thisApi.GetSwapchainTimeDomainProperties(device, swapchain, ref pSwapchainTimeDomainProperties.GetPinnableReference(), pTimeDomainsCounter);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSwapchainTimeDomainProperties(this ExtPresentTiming thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] Span<SwapchainTimeDomainPropertiesEXT> pSwapchainTimeDomainProperties, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> pTimeDomainsCounter)
        {
            // SpanOverloader
            return thisApi.GetSwapchainTimeDomainProperties(device, swapchain, ref pSwapchainTimeDomainProperties.GetPinnableReference(), out pTimeDomainsCounter.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSwapchainTimingProperties(this ExtPresentTiming thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] SwapchainTimingPropertiesEXT* pSwapchainTimingProperties, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> pSwapchainTimingPropertiesCounter)
        {
            // SpanOverloader
            return thisApi.GetSwapchainTimingProperties(device, swapchain, pSwapchainTimingProperties, out pSwapchainTimingPropertiesCounter.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSwapchainTimingProperties(this ExtPresentTiming thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] Span<SwapchainTimingPropertiesEXT> pSwapchainTimingProperties, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* pSwapchainTimingPropertiesCounter)
        {
            // SpanOverloader
            return thisApi.GetSwapchainTimingProperties(device, swapchain, ref pSwapchainTimingProperties.GetPinnableReference(), pSwapchainTimingPropertiesCounter);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSwapchainTimingProperties(this ExtPresentTiming thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] Span<SwapchainTimingPropertiesEXT> pSwapchainTimingProperties, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> pSwapchainTimingPropertiesCounter)
        {
            // SpanOverloader
            return thisApi.GetSwapchainTimingProperties(device, swapchain, ref pSwapchainTimingProperties.GetPinnableReference(), out pSwapchainTimingPropertiesCounter.GetPinnableReference());
        }

    }
}

