// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_performance_query")]
    public abstract unsafe partial class KhrPerformanceQuery : NativeExtension<Vk>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkAcquireProfilingLockKHR")]
        public abstract unsafe Result AcquireProfilingLock([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AcquireProfilingLockInfoKHR* pInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkAcquireProfilingLockKHR")]
        public abstract Result AcquireProfilingLock([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref AcquireProfilingLockInfoKHR pInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR")]
        public abstract unsafe Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint* pCounterCount, [Count(Computed = "pCounterCount")] PerformanceCounterKHR* pCounters, [Count(Computed = "pCounterCount")] PerformanceCounterDescriptionKHR* pCounterDescriptions);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR")]
        public abstract Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] ref uint pCounterCount, [Count(Computed = "pCounterCount")] ref PerformanceCounterKHR pCounters, [Count(Computed = "pCounterCount")] ref PerformanceCounterDescriptionKHR pCounterDescriptions);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR")]
        public abstract unsafe void GetPhysicalDeviceQueueFamilyPerformanceQueryPasses([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] QueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo, [Count(Count = 0), Flow(FlowDirection.Out)] uint* pNumPasses);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR")]
        public abstract void GetPhysicalDeviceQueueFamilyPerformanceQueryPasses([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref QueryPoolPerformanceCreateInfoKHR pPerformanceQueryCreateInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out uint pNumPasses);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkReleaseProfilingLockKHR")]
        public abstract void ReleaseProfilingLock([Count(Count = 0)] Device device);

        public KhrPerformanceQuery(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

