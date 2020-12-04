// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetCalibratedTimestampsEXT")]
        public unsafe partial Result GetCalibratedTimestamp([Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Computed = "timestampCount"), Flow(FlowDirection.In)] CalibratedTimestampInfoEXT* pTimestampInfos, [Count(Computed = "timestampCount")] ulong* pTimestamps, [Count(Count = 0), Flow(FlowDirection.Out)] ulong* pMaxDeviation);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetCalibratedTimestampsEXT")]
        public unsafe partial Result GetCalibratedTimestamp([Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Computed = "timestampCount"), Flow(FlowDirection.In)] CalibratedTimestampInfoEXT* pTimestampInfos, [Count(Computed = "timestampCount")] ulong* pTimestamps, [Count(Count = 0), Flow(FlowDirection.Out)] out ulong pMaxDeviation);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetCalibratedTimestampsEXT")]
        public unsafe partial Result GetCalibratedTimestamp([Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Computed = "timestampCount"), Flow(FlowDirection.In)] CalibratedTimestampInfoEXT* pTimestampInfos, [Count(Computed = "timestampCount")] ref ulong pTimestamps, [Count(Count = 0), Flow(FlowDirection.Out)] ulong* pMaxDeviation);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetCalibratedTimestampsEXT")]
        public unsafe partial Result GetCalibratedTimestamp([Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Computed = "timestampCount"), Flow(FlowDirection.In)] CalibratedTimestampInfoEXT* pTimestampInfos, [Count(Computed = "timestampCount")] ref ulong pTimestamps, [Count(Count = 0), Flow(FlowDirection.Out)] out ulong pMaxDeviation);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetCalibratedTimestampsEXT")]
        public unsafe partial Result GetCalibratedTimestamp([Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Computed = "timestampCount"), Flow(FlowDirection.In)] in CalibratedTimestampInfoEXT pTimestampInfos, [Count(Computed = "timestampCount")] ulong* pTimestamps, [Count(Count = 0), Flow(FlowDirection.Out)] ulong* pMaxDeviation);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetCalibratedTimestampsEXT")]
        public unsafe partial Result GetCalibratedTimestamp([Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Computed = "timestampCount"), Flow(FlowDirection.In)] in CalibratedTimestampInfoEXT pTimestampInfos, [Count(Computed = "timestampCount")] ulong* pTimestamps, [Count(Count = 0), Flow(FlowDirection.Out)] out ulong pMaxDeviation);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetCalibratedTimestampsEXT")]
        public unsafe partial Result GetCalibratedTimestamp([Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Computed = "timestampCount"), Flow(FlowDirection.In)] in CalibratedTimestampInfoEXT pTimestampInfos, [Count(Computed = "timestampCount")] ref ulong pTimestamps, [Count(Count = 0), Flow(FlowDirection.Out)] ulong* pMaxDeviation);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetCalibratedTimestampsEXT")]
        public partial Result GetCalibratedTimestamp([Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Computed = "timestampCount"), Flow(FlowDirection.In)] in CalibratedTimestampInfoEXT pTimestampInfos, [Count(Computed = "timestampCount")] ref ulong pTimestamps, [Count(Count = 0), Flow(FlowDirection.Out)] out ulong pMaxDeviation);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceCalibrateableTimeDomainsEXT")]
        public unsafe partial Result GetPhysicalDeviceCalibrateableTimeDomain([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pTimeDomainCount, [Count(Computed = "pTimeDomainCount"), Flow(FlowDirection.Out)] TimeDomainEXT* pTimeDomains);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceCalibrateableTimeDomainsEXT")]
        public unsafe partial Result GetPhysicalDeviceCalibrateableTimeDomain([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pTimeDomainCount, [Count(Computed = "pTimeDomainCount"), Flow(FlowDirection.Out)] out TimeDomainEXT pTimeDomains);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceCalibrateableTimeDomainsEXT")]
        public unsafe partial Result GetPhysicalDeviceCalibrateableTimeDomain([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pTimeDomainCount, [Count(Computed = "pTimeDomainCount"), Flow(FlowDirection.Out)] TimeDomainEXT* pTimeDomains);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceCalibrateableTimeDomainsEXT")]
        public partial Result GetPhysicalDeviceCalibrateableTimeDomain([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pTimeDomainCount, [Count(Computed = "pTimeDomainCount"), Flow(FlowDirection.Out)] out TimeDomainEXT pTimeDomains);

        public ExtCalibratedTimestamps(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

