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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_calibrated_timestamps")]
    public unsafe partial class ExtCalibratedTimestamps : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_calibrated_timestamps";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetCalibratedTimestampsEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetCalibratedTimestamp([Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Computed = "timestampCount"), Flow(FlowDirection.In)] CalibratedTimestampInfoEXT* pTimestampInfos, [Count(Computed = "timestampCount")] ulong* pTimestamps, [Count(Count = 0), Flow(FlowDirection.Out)] ulong* pMaxDeviation)
            => ImplGetCalibratedTimestamp(device, timestampCount, pTimestampInfos, pTimestamps, pMaxDeviation);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetCalibratedTimestampsEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetCalibratedTimestamp([Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Computed = "timestampCount"), Flow(FlowDirection.In)] ref CalibratedTimestampInfoEXT pTimestampInfos, [Count(Computed = "timestampCount")] ref ulong pTimestamps, [Count(Count = 0), Flow(FlowDirection.Out)] out ulong pMaxDeviation)
            => ImplGetCalibratedTimestamp(device, timestampCount, pTimestampInfos, pTimestamps, pMaxDeviation);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceCalibrateableTimeDomainsEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetPhysicalDeviceCalibrateableTimeDomain([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pTimeDomainCount, [Count(Computed = "pTimeDomainCount"), Flow(FlowDirection.Out)] TimeDomainEXT* pTimeDomains)
            => ImplGetPhysicalDeviceCalibrateableTimeDomain(physicalDevice, pTimeDomainCount, pTimeDomains);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceCalibrateableTimeDomainsEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetPhysicalDeviceCalibrateableTimeDomain([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pTimeDomainCount, [Count(Computed = "pTimeDomainCount"), Flow(FlowDirection.Out)] out TimeDomainEXT pTimeDomains)
            => ImplGetPhysicalDeviceCalibrateableTimeDomain(physicalDevice, pTimeDomainCount, pTimeDomains);

        public ExtCalibratedTimestamps(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

