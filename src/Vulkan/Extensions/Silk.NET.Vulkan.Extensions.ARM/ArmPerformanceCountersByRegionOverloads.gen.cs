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

namespace Silk.NET.Vulkan.Extensions.ARM
{
    public static class ArmPerformanceCountersByRegionOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result EnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegion(this ArmPerformanceCountersByRegion thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint* pCounterCount, [Count(Parameter = "pCounterCount")] PerformanceCounterARM* pCounters, [Count(Parameter = "pCounterCount")] Span<PerformanceCounterDescriptionARM> pCounterDescriptions)
        {
            // SpanOverloader
            return thisApi.EnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegion(physicalDevice, queueFamilyIndex, pCounterCount, pCounters, ref pCounterDescriptions.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegion(this ArmPerformanceCountersByRegion thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint* pCounterCount, [Count(Parameter = "pCounterCount")] Span<PerformanceCounterARM> pCounters, [Count(Parameter = "pCounterCount")] PerformanceCounterDescriptionARM* pCounterDescriptions)
        {
            // SpanOverloader
            return thisApi.EnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegion(physicalDevice, queueFamilyIndex, pCounterCount, ref pCounters.GetPinnableReference(), pCounterDescriptions);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegion(this ArmPerformanceCountersByRegion thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint* pCounterCount, [Count(Parameter = "pCounterCount")] Span<PerformanceCounterARM> pCounters, [Count(Parameter = "pCounterCount")] Span<PerformanceCounterDescriptionARM> pCounterDescriptions)
        {
            // SpanOverloader
            return thisApi.EnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegion(physicalDevice, queueFamilyIndex, pCounterCount, ref pCounters.GetPinnableReference(), ref pCounterDescriptions.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegion(this ArmPerformanceCountersByRegion thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] Span<uint> pCounterCount, [Count(Parameter = "pCounterCount")] PerformanceCounterARM* pCounters, [Count(Parameter = "pCounterCount")] PerformanceCounterDescriptionARM* pCounterDescriptions)
        {
            // SpanOverloader
            return thisApi.EnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegion(physicalDevice, queueFamilyIndex, ref pCounterCount.GetPinnableReference(), pCounters, pCounterDescriptions);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegion(this ArmPerformanceCountersByRegion thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] Span<uint> pCounterCount, [Count(Parameter = "pCounterCount")] PerformanceCounterARM* pCounters, [Count(Parameter = "pCounterCount")] Span<PerformanceCounterDescriptionARM> pCounterDescriptions)
        {
            // SpanOverloader
            return thisApi.EnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegion(physicalDevice, queueFamilyIndex, ref pCounterCount.GetPinnableReference(), pCounters, ref pCounterDescriptions.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegion(this ArmPerformanceCountersByRegion thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] Span<uint> pCounterCount, [Count(Parameter = "pCounterCount")] Span<PerformanceCounterARM> pCounters, [Count(Parameter = "pCounterCount")] PerformanceCounterDescriptionARM* pCounterDescriptions)
        {
            // SpanOverloader
            return thisApi.EnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegion(physicalDevice, queueFamilyIndex, ref pCounterCount.GetPinnableReference(), ref pCounters.GetPinnableReference(), pCounterDescriptions);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegion(this ArmPerformanceCountersByRegion thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] Span<uint> pCounterCount, [Count(Parameter = "pCounterCount")] Span<PerformanceCounterARM> pCounters, [Count(Parameter = "pCounterCount")] Span<PerformanceCounterDescriptionARM> pCounterDescriptions)
        {
            // SpanOverloader
            return thisApi.EnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegion(physicalDevice, queueFamilyIndex, ref pCounterCount.GetPinnableReference(), ref pCounters.GetPinnableReference(), ref pCounterDescriptions.GetPinnableReference());
        }

    }
}

