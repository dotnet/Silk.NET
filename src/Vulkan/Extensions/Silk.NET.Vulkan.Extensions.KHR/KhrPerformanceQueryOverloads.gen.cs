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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    public static class KhrPerformanceQueryOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result AcquireProfilingLock(this KhrPerformanceQuery thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AcquireProfilingLockInfoKHR> pInfo)
        {
            // SpanOverloader
            return thisApi.AcquireProfilingLock(device, in pInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters(this KhrPerformanceQuery thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint* pCounterCount, [Count(Parameter = "pCounterCount")] PerformanceCounterKHR* pCounters, [Count(Parameter = "pCounterCount")] Span<PerformanceCounterDescriptionKHR> pCounterDescriptions)
        {
            // SpanOverloader
            return thisApi.EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters(physicalDevice, queueFamilyIndex, pCounterCount, pCounters, ref pCounterDescriptions.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters(this KhrPerformanceQuery thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint* pCounterCount, [Count(Parameter = "pCounterCount")] Span<PerformanceCounterKHR> pCounters, [Count(Parameter = "pCounterCount")] PerformanceCounterDescriptionKHR* pCounterDescriptions)
        {
            // SpanOverloader
            return thisApi.EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters(physicalDevice, queueFamilyIndex, pCounterCount, ref pCounters.GetPinnableReference(), pCounterDescriptions);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters(this KhrPerformanceQuery thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint* pCounterCount, [Count(Parameter = "pCounterCount")] Span<PerformanceCounterKHR> pCounters, [Count(Parameter = "pCounterCount")] Span<PerformanceCounterDescriptionKHR> pCounterDescriptions)
        {
            // SpanOverloader
            return thisApi.EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters(physicalDevice, queueFamilyIndex, pCounterCount, ref pCounters.GetPinnableReference(), ref pCounterDescriptions.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters(this KhrPerformanceQuery thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] Span<uint> pCounterCount, [Count(Parameter = "pCounterCount")] PerformanceCounterKHR* pCounters, [Count(Parameter = "pCounterCount")] PerformanceCounterDescriptionKHR* pCounterDescriptions)
        {
            // SpanOverloader
            return thisApi.EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters(physicalDevice, queueFamilyIndex, ref pCounterCount.GetPinnableReference(), pCounters, pCounterDescriptions);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters(this KhrPerformanceQuery thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] Span<uint> pCounterCount, [Count(Parameter = "pCounterCount")] PerformanceCounterKHR* pCounters, [Count(Parameter = "pCounterCount")] Span<PerformanceCounterDescriptionKHR> pCounterDescriptions)
        {
            // SpanOverloader
            return thisApi.EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters(physicalDevice, queueFamilyIndex, ref pCounterCount.GetPinnableReference(), pCounters, ref pCounterDescriptions.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters(this KhrPerformanceQuery thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] Span<uint> pCounterCount, [Count(Parameter = "pCounterCount")] Span<PerformanceCounterKHR> pCounters, [Count(Parameter = "pCounterCount")] PerformanceCounterDescriptionKHR* pCounterDescriptions)
        {
            // SpanOverloader
            return thisApi.EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters(physicalDevice, queueFamilyIndex, ref pCounterCount.GetPinnableReference(), ref pCounters.GetPinnableReference(), pCounterDescriptions);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters(this KhrPerformanceQuery thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] Span<uint> pCounterCount, [Count(Parameter = "pCounterCount")] Span<PerformanceCounterKHR> pCounters, [Count(Parameter = "pCounterCount")] Span<PerformanceCounterDescriptionKHR> pCounterDescriptions)
        {
            // SpanOverloader
            return thisApi.EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters(physicalDevice, queueFamilyIndex, ref pCounterCount.GetPinnableReference(), ref pCounters.GetPinnableReference(), ref pCounterDescriptions.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetPhysicalDeviceQueueFamilyPerformanceQueryPasses(this KhrPerformanceQuery thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> pNumPasses)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceQueueFamilyPerformanceQueryPasses(physicalDevice, pPerformanceQueryCreateInfo, out pNumPasses.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetPhysicalDeviceQueueFamilyPerformanceQueryPasses(this KhrPerformanceQuery thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<QueryPoolPerformanceCreateInfoKHR> pPerformanceQueryCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* pNumPasses)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceQueueFamilyPerformanceQueryPasses(physicalDevice, in pPerformanceQueryCreateInfo.GetPinnableReference(), pNumPasses);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetPhysicalDeviceQueueFamilyPerformanceQueryPasses(this KhrPerformanceQuery thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<QueryPoolPerformanceCreateInfoKHR> pPerformanceQueryCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> pNumPasses)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceQueueFamilyPerformanceQueryPasses(physicalDevice, in pPerformanceQueryCreateInfo.GetPinnableReference(), out pNumPasses.GetPinnableReference());
        }

    }
}

