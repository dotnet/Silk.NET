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
using Silk.NET.Vulkan;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_performance_query")]
    public unsafe partial class KhrPerformanceQuery : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_performance_query";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAcquireProfilingLockKHR")]
        public unsafe partial Result AcquireProfilingLock([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AcquireProfilingLockInfoKHR* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAcquireProfilingLockKHR")]
        public partial Result AcquireProfilingLock([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in AcquireProfilingLockInfoKHR pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR")]
        public unsafe partial Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint* pCounterCount, [Count(Parameter = "pCounterCount")] PerformanceCounterKHR* pCounters, [Count(Parameter = "pCounterCount")] PerformanceCounterDescriptionKHR* pCounterDescriptions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR")]
        public unsafe partial Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint* pCounterCount, [Count(Parameter = "pCounterCount")] PerformanceCounterKHR* pCounters, [Count(Parameter = "pCounterCount")] ref PerformanceCounterDescriptionKHR pCounterDescriptions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR")]
        public unsafe partial Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint* pCounterCount, [Count(Parameter = "pCounterCount")] ref PerformanceCounterKHR pCounters, [Count(Parameter = "pCounterCount")] PerformanceCounterDescriptionKHR* pCounterDescriptions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR")]
        public unsafe partial Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint* pCounterCount, [Count(Parameter = "pCounterCount")] ref PerformanceCounterKHR pCounters, [Count(Parameter = "pCounterCount")] ref PerformanceCounterDescriptionKHR pCounterDescriptions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR")]
        public unsafe partial Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] ref uint pCounterCount, [Count(Parameter = "pCounterCount")] PerformanceCounterKHR* pCounters, [Count(Parameter = "pCounterCount")] PerformanceCounterDescriptionKHR* pCounterDescriptions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR")]
        public unsafe partial Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] ref uint pCounterCount, [Count(Parameter = "pCounterCount")] PerformanceCounterKHR* pCounters, [Count(Parameter = "pCounterCount")] ref PerformanceCounterDescriptionKHR pCounterDescriptions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR")]
        public unsafe partial Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] ref uint pCounterCount, [Count(Parameter = "pCounterCount")] ref PerformanceCounterKHR pCounters, [Count(Parameter = "pCounterCount")] PerformanceCounterDescriptionKHR* pCounterDescriptions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR")]
        public partial Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] ref uint pCounterCount, [Count(Parameter = "pCounterCount")] ref PerformanceCounterKHR pCounters, [Count(Parameter = "pCounterCount")] ref PerformanceCounterDescriptionKHR pCounterDescriptions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR")]
        public unsafe partial void GetPhysicalDeviceQueueFamilyPerformanceQueryPasses([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] QueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo, [Count(Count = 0), Flow(FlowDirection.Out)] uint* pNumPasses);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR")]
        public unsafe partial void GetPhysicalDeviceQueueFamilyPerformanceQueryPasses([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] QueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out uint pNumPasses);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR")]
        public unsafe partial void GetPhysicalDeviceQueueFamilyPerformanceQueryPasses([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] in QueryPoolPerformanceCreateInfoKHR pPerformanceQueryCreateInfo, [Count(Count = 0), Flow(FlowDirection.Out)] uint* pNumPasses);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR")]
        public partial void GetPhysicalDeviceQueueFamilyPerformanceQueryPasses([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] in QueryPoolPerformanceCreateInfoKHR pPerformanceQueryCreateInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out uint pNumPasses);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkReleaseProfilingLockKHR")]
        public partial void ReleaseProfilingLock([Count(Count = 0)] Device device);

        public KhrPerformanceQuery(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

