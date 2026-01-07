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

namespace Silk.NET.Vulkan.Extensions.ARM
{
    [Extension("VK_ARM_performance_counters_by_region")]
    public unsafe partial class ArmPerformanceCountersByRegion : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_ARM_performance_counters_by_region";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegion([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint* pCounterCount, [Count(Parameter = "pCounterCount")] PerformanceCounterARM* pCounters, [Count(Parameter = "pCounterCount")] PerformanceCounterDescriptionARM* pCounterDescriptions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegion([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint* pCounterCount, [Count(Parameter = "pCounterCount")] PerformanceCounterARM* pCounters, [Count(Parameter = "pCounterCount")] ref PerformanceCounterDescriptionARM pCounterDescriptions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegion([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint* pCounterCount, [Count(Parameter = "pCounterCount")] ref PerformanceCounterARM pCounters, [Count(Parameter = "pCounterCount")] PerformanceCounterDescriptionARM* pCounterDescriptions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegion([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint* pCounterCount, [Count(Parameter = "pCounterCount")] ref PerformanceCounterARM pCounters, [Count(Parameter = "pCounterCount")] ref PerformanceCounterDescriptionARM pCounterDescriptions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegion([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] ref uint pCounterCount, [Count(Parameter = "pCounterCount")] PerformanceCounterARM* pCounters, [Count(Parameter = "pCounterCount")] PerformanceCounterDescriptionARM* pCounterDescriptions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegion([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] ref uint pCounterCount, [Count(Parameter = "pCounterCount")] PerformanceCounterARM* pCounters, [Count(Parameter = "pCounterCount")] ref PerformanceCounterDescriptionARM pCounterDescriptions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegion([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] ref uint pCounterCount, [Count(Parameter = "pCounterCount")] ref PerformanceCounterARM pCounters, [Count(Parameter = "pCounterCount")] PerformanceCounterDescriptionARM* pCounterDescriptions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM", Convention = CallingConvention.Winapi)]
        public partial Result EnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegion([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] ref uint pCounterCount, [Count(Parameter = "pCounterCount")] ref PerformanceCounterARM pCounters, [Count(Parameter = "pCounterCount")] ref PerformanceCounterDescriptionARM pCounterDescriptions);

        public ArmPerformanceCountersByRegion(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

