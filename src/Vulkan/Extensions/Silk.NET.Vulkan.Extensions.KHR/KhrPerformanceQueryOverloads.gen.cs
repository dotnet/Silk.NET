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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    public static class KhrPerformanceQueryOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe Result AcquireProfilingLock(this KhrPerformanceQuery thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AcquireProfilingLockInfoKHR> pInfo)
        {
            // SpanOverloader
            return thisApi.AcquireProfilingLock(device, in pInfo.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters(this KhrPerformanceQuery thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint* pCounterCount, [Count(Computed = "pCounterCount")] PerformanceCounterKHR* pCounters, [Count(Computed = "pCounterCount")] Span<PerformanceCounterDescriptionKHR> pCounterDescriptions)
        {
            // SpanOverloader
            return thisApi.EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters(physicalDevice, queueFamilyIndex, pCounterCount, pCounters, ref pCounterDescriptions.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters(this KhrPerformanceQuery thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint* pCounterCount, [Count(Computed = "pCounterCount")] Span<PerformanceCounterKHR> pCounters, [Count(Computed = "pCounterCount")] PerformanceCounterDescriptionKHR* pCounterDescriptions)
        {
            // SpanOverloader
            return thisApi.EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters(physicalDevice, queueFamilyIndex, pCounterCount, ref pCounters.GetPinnableReference(), pCounterDescriptions);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters(this KhrPerformanceQuery thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint* pCounterCount, [Count(Computed = "pCounterCount")] Span<PerformanceCounterKHR> pCounters, [Count(Computed = "pCounterCount")] Span<PerformanceCounterDescriptionKHR> pCounterDescriptions)
        {
            // SpanOverloader
            return thisApi.EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters(physicalDevice, queueFamilyIndex, pCounterCount, ref pCounters.GetPinnableReference(), ref pCounterDescriptions.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters(this KhrPerformanceQuery thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] Span<uint> pCounterCount, [Count(Computed = "pCounterCount")] PerformanceCounterKHR* pCounters, [Count(Computed = "pCounterCount")] PerformanceCounterDescriptionKHR* pCounterDescriptions)
        {
            // SpanOverloader
            return thisApi.EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters(physicalDevice, queueFamilyIndex, ref pCounterCount.GetPinnableReference(), pCounters, pCounterDescriptions);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters(this KhrPerformanceQuery thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] Span<uint> pCounterCount, [Count(Computed = "pCounterCount")] PerformanceCounterKHR* pCounters, [Count(Computed = "pCounterCount")] Span<PerformanceCounterDescriptionKHR> pCounterDescriptions)
        {
            // SpanOverloader
            return thisApi.EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters(physicalDevice, queueFamilyIndex, ref pCounterCount.GetPinnableReference(), pCounters, ref pCounterDescriptions.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters(this KhrPerformanceQuery thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] Span<uint> pCounterCount, [Count(Computed = "pCounterCount")] Span<PerformanceCounterKHR> pCounters, [Count(Computed = "pCounterCount")] PerformanceCounterDescriptionKHR* pCounterDescriptions)
        {
            // SpanOverloader
            return thisApi.EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters(physicalDevice, queueFamilyIndex, ref pCounterCount.GetPinnableReference(), ref pCounters.GetPinnableReference(), pCounterDescriptions);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters(this KhrPerformanceQuery thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] Span<uint> pCounterCount, [Count(Computed = "pCounterCount")] Span<PerformanceCounterKHR> pCounters, [Count(Computed = "pCounterCount")] Span<PerformanceCounterDescriptionKHR> pCounterDescriptions)
        {
            // SpanOverloader
            return thisApi.EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters(physicalDevice, queueFamilyIndex, ref pCounterCount.GetPinnableReference(), ref pCounters.GetPinnableReference(), ref pCounterDescriptions.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe void GetPhysicalDeviceQueueFamilyPerformanceQueryPasses(this KhrPerformanceQuery thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] QueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo, [Count(Count = 0), Flow(FlowDirection.Out)] Span<uint> pNumPasses)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceQueueFamilyPerformanceQueryPasses(physicalDevice, pPerformanceQueryCreateInfo, out pNumPasses.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe void GetPhysicalDeviceQueueFamilyPerformanceQueryPasses(this KhrPerformanceQuery thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<QueryPoolPerformanceCreateInfoKHR> pPerformanceQueryCreateInfo, [Count(Count = 0), Flow(FlowDirection.Out)] uint* pNumPasses)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceQueueFamilyPerformanceQueryPasses(physicalDevice, in pPerformanceQueryCreateInfo.GetPinnableReference(), pNumPasses);
        }

        /// <summary>To be added.</summary>
        public static unsafe void GetPhysicalDeviceQueueFamilyPerformanceQueryPasses(this KhrPerformanceQuery thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<QueryPoolPerformanceCreateInfoKHR> pPerformanceQueryCreateInfo, [Count(Count = 0), Flow(FlowDirection.Out)] Span<uint> pNumPasses)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceQueueFamilyPerformanceQueryPasses(physicalDevice, in pPerformanceQueryCreateInfo.GetPinnableReference(), out pNumPasses.GetPinnableReference());
        }

    }
}

