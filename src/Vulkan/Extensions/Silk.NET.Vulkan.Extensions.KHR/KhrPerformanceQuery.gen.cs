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
        [NativeApi(EntryPoint = "vkAcquireProfilingLockKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result AcquireProfilingLock([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AcquireProfilingLockInfoKHR* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAcquireProfilingLockKHR", Convention = CallingConvention.Winapi)]
        public partial Result AcquireProfilingLock([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AcquireProfilingLockInfoKHR pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint* pCounterCount, [Count(Parameter = "pCounterCount")] PerformanceCounterKHR* pCounters, [Count(Parameter = "pCounterCount")] PerformanceCounterDescriptionKHR* pCounterDescriptions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint* pCounterCount, [Count(Parameter = "pCounterCount")] PerformanceCounterKHR* pCounters, [Count(Parameter = "pCounterCount")] ref PerformanceCounterDescriptionKHR pCounterDescriptions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint* pCounterCount, [Count(Parameter = "pCounterCount")] ref PerformanceCounterKHR pCounters, [Count(Parameter = "pCounterCount")] PerformanceCounterDescriptionKHR* pCounterDescriptions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint* pCounterCount, [Count(Parameter = "pCounterCount")] ref PerformanceCounterKHR pCounters, [Count(Parameter = "pCounterCount")] ref PerformanceCounterDescriptionKHR pCounterDescriptions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] ref uint pCounterCount, [Count(Parameter = "pCounterCount")] PerformanceCounterKHR* pCounters, [Count(Parameter = "pCounterCount")] PerformanceCounterDescriptionKHR* pCounterDescriptions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] ref uint pCounterCount, [Count(Parameter = "pCounterCount")] PerformanceCounterKHR* pCounters, [Count(Parameter = "pCounterCount")] ref PerformanceCounterDescriptionKHR pCounterDescriptions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] ref uint pCounterCount, [Count(Parameter = "pCounterCount")] ref PerformanceCounterKHR pCounters, [Count(Parameter = "pCounterCount")] PerformanceCounterDescriptionKHR* pCounterDescriptions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR", Convention = CallingConvention.Winapi)]
        public partial Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCounters([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] ref uint pCounterCount, [Count(Parameter = "pCounterCount")] ref PerformanceCounterKHR pCounters, [Count(Parameter = "pCounterCount")] ref PerformanceCounterDescriptionKHR pCounterDescriptions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPhysicalDeviceQueueFamilyPerformanceQueryPasses([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* pNumPasses);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPhysicalDeviceQueueFamilyPerformanceQueryPasses([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint pNumPasses);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPhysicalDeviceQueueFamilyPerformanceQueryPasses([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in QueryPoolPerformanceCreateInfoKHR pPerformanceQueryCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* pNumPasses);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR", Convention = CallingConvention.Winapi)]
        public partial void GetPhysicalDeviceQueueFamilyPerformanceQueryPasses([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in QueryPoolPerformanceCreateInfoKHR pPerformanceQueryCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint pNumPasses);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkReleaseProfilingLockKHR", Convention = CallingConvention.Winapi)]
        public partial void ReleaseProfilingLock([Count(Count = 0)] Device device);

        /// <summary>To be documented.</summary>
        public unsafe uint GetPhysicalDeviceQueueFamilyPerformanceQueryPasses([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo)
        {
            // NonKhrReturnTypeOverloader
            GetPhysicalDeviceQueueFamilyPerformanceQueryPasses(physicalDevice, pPerformanceQueryCreateInfo, out uint silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public unsafe uint GetPhysicalDeviceQueueFamilyPerformanceQueryPasses([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in QueryPoolPerformanceCreateInfoKHR pPerformanceQueryCreateInfo)
        {
            // NonKhrReturnTypeOverloader
            GetPhysicalDeviceQueueFamilyPerformanceQueryPasses(physicalDevice, in pPerformanceQueryCreateInfo, out uint silkRet);
            return silkRet;
        }

        public KhrPerformanceQuery(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

