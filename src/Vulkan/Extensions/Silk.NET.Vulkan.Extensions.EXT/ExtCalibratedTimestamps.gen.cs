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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_calibrated_timestamps")]
    public abstract unsafe partial class ExtCalibratedTimestamps : NativeExtension<Vk>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetCalibratedTimestampsEXT")]
        public abstract unsafe Result GetCalibratedTimestamp([Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Computed = "timestampCount"), Flow(FlowDirection.In)] CalibratedTimestampInfoEXT* pTimestampInfos, [Count(Computed = "timestampCount")] ulong* pTimestamps, [Count(Count = 0), Flow(FlowDirection.Out)] ulong* pMaxDeviation);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetCalibratedTimestampsEXT")]
        public abstract Result GetCalibratedTimestamp([Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Computed = "timestampCount"), Flow(FlowDirection.In)] ref CalibratedTimestampInfoEXT pTimestampInfos, [Count(Computed = "timestampCount")] ref ulong pTimestamps, [Count(Count = 0), Flow(FlowDirection.Out)] out ulong pMaxDeviation);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceCalibrateableTimeDomainsEXT")]
        public abstract unsafe Result GetPhysicalDeviceCalibrateableTimeDomain([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pTimeDomainCount, [Count(Computed = "pTimeDomainCount"), Flow(FlowDirection.Out)] TimeDomainEXT* pTimeDomains);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceCalibrateableTimeDomainsEXT")]
        public abstract Result GetPhysicalDeviceCalibrateableTimeDomain([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pTimeDomainCount, [Count(Computed = "pTimeDomainCount"), Flow(FlowDirection.Out)] out TimeDomainEXT pTimeDomains);

        public ExtCalibratedTimestamps(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

