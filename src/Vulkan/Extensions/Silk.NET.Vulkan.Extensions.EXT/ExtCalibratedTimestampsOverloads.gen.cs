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
    public static class ExtCalibratedTimestampsOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetCalibratedTimestamp(this ExtCalibratedTimestamps thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Parameter = "timestampCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] CalibratedTimestampInfoKHR* pTimestampInfos, [Count(Parameter = "timestampCount")] ulong* pTimestamps, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> pMaxDeviation)
        {
            // SpanOverloader
            return thisApi.GetCalibratedTimestamp(device, timestampCount, pTimestampInfos, pTimestamps, out pMaxDeviation.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetCalibratedTimestamp(this ExtCalibratedTimestamps thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Parameter = "timestampCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] CalibratedTimestampInfoKHR* pTimestampInfos, [Count(Parameter = "timestampCount")] Span<ulong> pTimestamps, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* pMaxDeviation)
        {
            // SpanOverloader
            return thisApi.GetCalibratedTimestamp(device, timestampCount, pTimestampInfos, ref pTimestamps.GetPinnableReference(), pMaxDeviation);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetCalibratedTimestamp(this ExtCalibratedTimestamps thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Parameter = "timestampCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] CalibratedTimestampInfoKHR* pTimestampInfos, [Count(Parameter = "timestampCount")] Span<ulong> pTimestamps, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> pMaxDeviation)
        {
            // SpanOverloader
            return thisApi.GetCalibratedTimestamp(device, timestampCount, pTimestampInfos, ref pTimestamps.GetPinnableReference(), out pMaxDeviation.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetCalibratedTimestamp(this ExtCalibratedTimestamps thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Parameter = "timestampCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CalibratedTimestampInfoKHR> pTimestampInfos, [Count(Parameter = "timestampCount")] ulong* pTimestamps, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* pMaxDeviation)
        {
            // SpanOverloader
            return thisApi.GetCalibratedTimestamp(device, timestampCount, in pTimestampInfos.GetPinnableReference(), pTimestamps, pMaxDeviation);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetCalibratedTimestamp(this ExtCalibratedTimestamps thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Parameter = "timestampCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CalibratedTimestampInfoKHR> pTimestampInfos, [Count(Parameter = "timestampCount")] ulong* pTimestamps, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> pMaxDeviation)
        {
            // SpanOverloader
            return thisApi.GetCalibratedTimestamp(device, timestampCount, in pTimestampInfos.GetPinnableReference(), pTimestamps, out pMaxDeviation.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetCalibratedTimestamp(this ExtCalibratedTimestamps thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Parameter = "timestampCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CalibratedTimestampInfoKHR> pTimestampInfos, [Count(Parameter = "timestampCount")] Span<ulong> pTimestamps, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* pMaxDeviation)
        {
            // SpanOverloader
            return thisApi.GetCalibratedTimestamp(device, timestampCount, in pTimestampInfos.GetPinnableReference(), ref pTimestamps.GetPinnableReference(), pMaxDeviation);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetCalibratedTimestamp(this ExtCalibratedTimestamps thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Parameter = "timestampCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CalibratedTimestampInfoKHR> pTimestampInfos, [Count(Parameter = "timestampCount")] Span<ulong> pTimestamps, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> pMaxDeviation)
        {
            // SpanOverloader
            return thisApi.GetCalibratedTimestamp(device, timestampCount, in pTimestampInfos.GetPinnableReference(), ref pTimestamps.GetPinnableReference(), out pMaxDeviation.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceCalibrateableTimeDomain(this ExtCalibratedTimestamps thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pTimeDomainCount, [Count(Parameter = "pTimeDomainCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<TimeDomainKHR> pTimeDomains)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceCalibrateableTimeDomain(physicalDevice, pTimeDomainCount, out pTimeDomains.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceCalibrateableTimeDomain(this ExtCalibratedTimestamps thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pTimeDomainCount, [Count(Parameter = "pTimeDomainCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] TimeDomainKHR* pTimeDomains)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceCalibrateableTimeDomain(physicalDevice, ref pTimeDomainCount.GetPinnableReference(), pTimeDomains);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceCalibrateableTimeDomain(this ExtCalibratedTimestamps thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pTimeDomainCount, [Count(Parameter = "pTimeDomainCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<TimeDomainKHR> pTimeDomains)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceCalibrateableTimeDomain(physicalDevice, ref pTimeDomainCount.GetPinnableReference(), out pTimeDomains.GetPinnableReference());
        }

    }
}

