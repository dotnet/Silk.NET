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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    public static class ExtCalibratedTimestampsOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe Result GetCalibratedTimestamp(this ExtCalibratedTimestamps thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Computed = "timestampCount"), Flow(FlowDirection.In)] CalibratedTimestampInfoEXT* pTimestampInfos, [Count(Computed = "timestampCount")] ulong* pTimestamps, [Count(Count = 0), Flow(FlowDirection.Out)] Span<ulong> pMaxDeviation)
        {
            // SpanOverloader
            return thisApi.GetCalibratedTimestamp(device, timestampCount, pTimestampInfos, pTimestamps, out pMaxDeviation.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetCalibratedTimestamp(this ExtCalibratedTimestamps thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Computed = "timestampCount"), Flow(FlowDirection.In)] CalibratedTimestampInfoEXT* pTimestampInfos, [Count(Computed = "timestampCount")] Span<ulong> pTimestamps, [Count(Count = 0), Flow(FlowDirection.Out)] ulong* pMaxDeviation)
        {
            // SpanOverloader
            return thisApi.GetCalibratedTimestamp(device, timestampCount, pTimestampInfos, ref pTimestamps.GetPinnableReference(), pMaxDeviation);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetCalibratedTimestamp(this ExtCalibratedTimestamps thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Computed = "timestampCount"), Flow(FlowDirection.In)] CalibratedTimestampInfoEXT* pTimestampInfos, [Count(Computed = "timestampCount")] Span<ulong> pTimestamps, [Count(Count = 0), Flow(FlowDirection.Out)] Span<ulong> pMaxDeviation)
        {
            // SpanOverloader
            return thisApi.GetCalibratedTimestamp(device, timestampCount, pTimestampInfos, ref pTimestamps.GetPinnableReference(), out pMaxDeviation.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetCalibratedTimestamp(this ExtCalibratedTimestamps thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Computed = "timestampCount"), Flow(FlowDirection.In)] ReadOnlySpan<CalibratedTimestampInfoEXT> pTimestampInfos, [Count(Computed = "timestampCount")] ulong* pTimestamps, [Count(Count = 0), Flow(FlowDirection.Out)] ulong* pMaxDeviation)
        {
            // SpanOverloader
            return thisApi.GetCalibratedTimestamp(device, timestampCount, in pTimestampInfos.GetPinnableReference(), pTimestamps, pMaxDeviation);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetCalibratedTimestamp(this ExtCalibratedTimestamps thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Computed = "timestampCount"), Flow(FlowDirection.In)] ReadOnlySpan<CalibratedTimestampInfoEXT> pTimestampInfos, [Count(Computed = "timestampCount")] ulong* pTimestamps, [Count(Count = 0), Flow(FlowDirection.Out)] Span<ulong> pMaxDeviation)
        {
            // SpanOverloader
            return thisApi.GetCalibratedTimestamp(device, timestampCount, in pTimestampInfos.GetPinnableReference(), pTimestamps, out pMaxDeviation.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetCalibratedTimestamp(this ExtCalibratedTimestamps thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Computed = "timestampCount"), Flow(FlowDirection.In)] ReadOnlySpan<CalibratedTimestampInfoEXT> pTimestampInfos, [Count(Computed = "timestampCount")] Span<ulong> pTimestamps, [Count(Count = 0), Flow(FlowDirection.Out)] ulong* pMaxDeviation)
        {
            // SpanOverloader
            return thisApi.GetCalibratedTimestamp(device, timestampCount, in pTimestampInfos.GetPinnableReference(), ref pTimestamps.GetPinnableReference(), pMaxDeviation);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetCalibratedTimestamp(this ExtCalibratedTimestamps thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Computed = "timestampCount"), Flow(FlowDirection.In)] ReadOnlySpan<CalibratedTimestampInfoEXT> pTimestampInfos, [Count(Computed = "timestampCount")] Span<ulong> pTimestamps, [Count(Count = 0), Flow(FlowDirection.Out)] Span<ulong> pMaxDeviation)
        {
            // SpanOverloader
            return thisApi.GetCalibratedTimestamp(device, timestampCount, in pTimestampInfos.GetPinnableReference(), ref pTimestamps.GetPinnableReference(), out pMaxDeviation.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetPhysicalDeviceCalibrateableTimeDomain(this ExtCalibratedTimestamps thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pTimeDomainCount, [Count(Computed = "pTimeDomainCount"), Flow(FlowDirection.Out)] Span<TimeDomainEXT> pTimeDomains)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceCalibrateableTimeDomain(physicalDevice, pTimeDomainCount, out pTimeDomains.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetPhysicalDeviceCalibrateableTimeDomain(this ExtCalibratedTimestamps thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pTimeDomainCount, [Count(Computed = "pTimeDomainCount"), Flow(FlowDirection.Out)] TimeDomainEXT* pTimeDomains)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceCalibrateableTimeDomain(physicalDevice, ref pTimeDomainCount.GetPinnableReference(), pTimeDomains);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetPhysicalDeviceCalibrateableTimeDomain(this ExtCalibratedTimestamps thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pTimeDomainCount, [Count(Computed = "pTimeDomainCount"), Flow(FlowDirection.Out)] Span<TimeDomainEXT> pTimeDomains)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceCalibrateableTimeDomain(physicalDevice, ref pTimeDomainCount.GetPinnableReference(), out pTimeDomains.GetPinnableReference());
        }

    }
}

