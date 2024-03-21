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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_calibrated_timestamps")]
    public unsafe partial class ExtCalibratedTimestamps : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_calibrated_timestamps";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetCalibratedTimestampsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetCalibratedTimestamp([Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Parameter = "timestampCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] CalibratedTimestampInfoKHR* pTimestampInfos, [Count(Parameter = "timestampCount")] ulong* pTimestamps, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* pMaxDeviation);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetCalibratedTimestampsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetCalibratedTimestamp([Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Parameter = "timestampCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] CalibratedTimestampInfoKHR* pTimestampInfos, [Count(Parameter = "timestampCount")] ulong* pTimestamps, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong pMaxDeviation);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetCalibratedTimestampsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetCalibratedTimestamp([Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Parameter = "timestampCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] CalibratedTimestampInfoKHR* pTimestampInfos, [Count(Parameter = "timestampCount")] ref ulong pTimestamps, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* pMaxDeviation);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetCalibratedTimestampsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetCalibratedTimestamp([Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Parameter = "timestampCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] CalibratedTimestampInfoKHR* pTimestampInfos, [Count(Parameter = "timestampCount")] ref ulong pTimestamps, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong pMaxDeviation);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetCalibratedTimestampsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetCalibratedTimestamp([Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Parameter = "timestampCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CalibratedTimestampInfoKHR pTimestampInfos, [Count(Parameter = "timestampCount")] ulong* pTimestamps, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* pMaxDeviation);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetCalibratedTimestampsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetCalibratedTimestamp([Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Parameter = "timestampCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CalibratedTimestampInfoKHR pTimestampInfos, [Count(Parameter = "timestampCount")] ulong* pTimestamps, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong pMaxDeviation);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetCalibratedTimestampsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetCalibratedTimestamp([Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Parameter = "timestampCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CalibratedTimestampInfoKHR pTimestampInfos, [Count(Parameter = "timestampCount")] ref ulong pTimestamps, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* pMaxDeviation);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetCalibratedTimestampsEXT", Convention = CallingConvention.Winapi)]
        public partial Result GetCalibratedTimestamp([Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Parameter = "timestampCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CalibratedTimestampInfoKHR pTimestampInfos, [Count(Parameter = "timestampCount")] ref ulong pTimestamps, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong pMaxDeviation);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceCalibrateableTimeDomainsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceCalibrateableTimeDomain([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pTimeDomainCount, [Count(Parameter = "pTimeDomainCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] TimeDomainKHR* pTimeDomains);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceCalibrateableTimeDomainsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceCalibrateableTimeDomain([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pTimeDomainCount, [Count(Parameter = "pTimeDomainCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out TimeDomainKHR pTimeDomains);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceCalibrateableTimeDomainsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceCalibrateableTimeDomain([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pTimeDomainCount, [Count(Parameter = "pTimeDomainCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] TimeDomainKHR* pTimeDomains);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceCalibrateableTimeDomainsEXT", Convention = CallingConvention.Winapi)]
        public partial Result GetPhysicalDeviceCalibrateableTimeDomain([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pTimeDomainCount, [Count(Parameter = "pTimeDomainCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out TimeDomainKHR pTimeDomains);

        /// <summary>To be documented.</summary>
        public unsafe Result GetCalibratedTimestamp([Count(Count = 0)] Device device, [Count(Parameter = "timestampCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] CalibratedTimestampInfoKHR* pTimestampInfos, [Count(Parameter = "timestampCount")] Span<ulong> pTimestamps, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* pMaxDeviation)
        {
            // ImplicitCountSpanOverloader
            return GetCalibratedTimestamp(device, (uint) pTimestamps.Length, pTimestampInfos, ref pTimestamps.GetPinnableReference(), pMaxDeviation);
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetCalibratedTimestamp([Count(Count = 0)] Device device, [Count(Parameter = "timestampCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] CalibratedTimestampInfoKHR* pTimestampInfos, [Count(Parameter = "timestampCount")] Span<ulong> pTimestamps, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong pMaxDeviation)
        {
            // ImplicitCountSpanOverloader
            return GetCalibratedTimestamp(device, (uint) pTimestamps.Length, pTimestampInfos, ref pTimestamps.GetPinnableReference(), out pMaxDeviation);
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetCalibratedTimestamp([Count(Count = 0)] Device device, [Count(Parameter = "timestampCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CalibratedTimestampInfoKHR> pTimestampInfos, [Count(Parameter = "timestampCount")] ulong* pTimestamps, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* pMaxDeviation)
        {
            // ImplicitCountSpanOverloader
            return GetCalibratedTimestamp(device, (uint) pTimestampInfos.Length, in pTimestampInfos.GetPinnableReference(), pTimestamps, pMaxDeviation);
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetCalibratedTimestamp([Count(Count = 0)] Device device, [Count(Parameter = "timestampCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CalibratedTimestampInfoKHR> pTimestampInfos, [Count(Parameter = "timestampCount")] ulong* pTimestamps, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong pMaxDeviation)
        {
            // ImplicitCountSpanOverloader
            return GetCalibratedTimestamp(device, (uint) pTimestampInfos.Length, in pTimestampInfos.GetPinnableReference(), pTimestamps, out pMaxDeviation);
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetCalibratedTimestamp([Count(Count = 0)] Device device, [Count(Parameter = "timestampCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CalibratedTimestampInfoKHR> pTimestampInfos, [Count(Parameter = "timestampCount")] Span<ulong> pTimestamps, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* pMaxDeviation)
        {
            // ImplicitCountSpanOverloader
            return GetCalibratedTimestamp(device, (uint) pTimestamps.Length, in pTimestampInfos.GetPinnableReference(), ref pTimestamps.GetPinnableReference(), pMaxDeviation);
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetCalibratedTimestamp([Count(Count = 0)] Device device, [Count(Parameter = "timestampCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CalibratedTimestampInfoKHR> pTimestampInfos, [Count(Parameter = "timestampCount")] Span<ulong> pTimestamps, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong pMaxDeviation)
        {
            // ImplicitCountSpanOverloader
            return GetCalibratedTimestamp(device, (uint) pTimestamps.Length, in pTimestampInfos.GetPinnableReference(), ref pTimestamps.GetPinnableReference(), out pMaxDeviation);
        }

        public ExtCalibratedTimestamps(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

