// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_performance_query")]
    public unsafe partial class KhrPerformanceQuery : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_performance_query";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAcquireProfilingLockKHR")]
        public unsafe partial Result AcquireProfilingLock([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AcquireProfilingLockInfoKHR* pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAcquireProfilingLockKHR")]
        public partial Result AcquireProfilingLock([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref AcquireProfilingLockInfoKHR pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR")]
        public unsafe partial Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint* pCounterCount, [Count(Computed = "pCounterCount")] PerformanceCounterKHR* pCounters, [Count(Computed = "pCounterCount")] PerformanceCounterDescriptionKHR* pCounterDescriptions);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR")]
        public partial Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] ref uint pCounterCount, [Count(Computed = "pCounterCount")] ref PerformanceCounterKHR pCounters, [Count(Computed = "pCounterCount")] ref PerformanceCounterDescriptionKHR pCounterDescriptions);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR")]
        public unsafe partial void GetPhysicalDeviceQueueFamilyPerformanceQueryPasses([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] QueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo, [Count(Count = 0), Flow(FlowDirection.Out)] uint* pNumPasses);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR")]
        public partial void GetPhysicalDeviceQueueFamilyPerformanceQueryPasses([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref QueryPoolPerformanceCreateInfoKHR pPerformanceQueryCreateInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out uint pNumPasses);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkReleaseProfilingLockKHR")]
        public partial void ReleaseProfilingLock([Count(Count = 0)] Device device);

        public KhrPerformanceQuery(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

