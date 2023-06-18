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
        public unsafe partial Result GetCalibratedTimestamp([Count(Count = 0)] Device device, [Count(Count = 0)] uint timestampCount, [Count(Parameter = "timestampCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] CalibratedTimestampInfoEXT* pTimestampInfos, [Count(Parameter = "timestampCount")] ulong* pTimestamps, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* pMaxDeviation);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceCalibrateableTimeDomainsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceCalibrateableTimeDomain([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pTimeDomainCount, [Count(Parameter = "pTimeDomainCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] TimeDomainEXT* pTimeDomains);

        public ExtCalibratedTimestamps(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

