// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result AcquireProfilingLock([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AcquireProfilingLockInfoKHR* pInfo)
            => ImplAcquireProfilingLock(device, pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAcquireProfilingLockKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result AcquireProfilingLock([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref AcquireProfilingLockInfoKHR pInfo)
            => ImplAcquireProfilingLock(device, pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint* pCounterCount, [Count(Computed = "pCounterCount")] PerformanceCounterKHR* pCounters, [Count(Computed = "pCounterCount")] PerformanceCounterDescriptionKHR* pCounterDescriptions)
            => ImplEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters(physicalDevice, queueFamilyIndex, pCounterCount, pCounters, pCounterDescriptions);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] ref uint pCounterCount, [Count(Computed = "pCounterCount")] ref PerformanceCounterKHR pCounters, [Count(Computed = "pCounterCount")] ref PerformanceCounterDescriptionKHR pCounterDescriptions)
            => ImplEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters(physicalDevice, queueFamilyIndex, pCounterCount, pCounters, pCounterDescriptions);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPhysicalDeviceQueueFamilyPerformanceQueryPasses([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] QueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo, [Count(Count = 0), Flow(FlowDirection.Out)] uint* pNumPasses)
            => ImplGetPhysicalDeviceQueueFamilyPerformanceQueryPasses(physicalDevice, pPerformanceQueryCreateInfo, pNumPasses);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPhysicalDeviceQueueFamilyPerformanceQueryPasses([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref QueryPoolPerformanceCreateInfoKHR pPerformanceQueryCreateInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out uint pNumPasses)
            => ImplGetPhysicalDeviceQueueFamilyPerformanceQueryPasses(physicalDevice, pPerformanceQueryCreateInfo, pNumPasses);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkReleaseProfilingLockKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ReleaseProfilingLock([Count(Count = 0)] Device device)
            => ImplReleaseProfilingLock(device);

        public KhrPerformanceQuery(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

