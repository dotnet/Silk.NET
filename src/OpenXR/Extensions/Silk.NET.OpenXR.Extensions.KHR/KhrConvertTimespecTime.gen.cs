// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenXR;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.KHR
{
    [Extension("XR_KHR_convert_timespec_time")]
    public abstract unsafe partial class KhrConvertTimespecTime : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_KHR_convert_timespec_time";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrConvertTimespecTimeToTimeKHR")]
        public abstract unsafe Result ConvertTimespecTimeToTime([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] timespec* timespecTime, [Count(Count = 0)] long* time);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrConvertTimespecTimeToTimeKHR")]
        public abstract Result ConvertTimespecTimeToTime([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref timespec timespecTime, [Count(Count = 0)] ref long time);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrConvertTimeToTimespecTimeKHR")]
        public abstract unsafe Result ConvertTimeToTimespecTime([Count(Count = 0)] Instance instance, [Count(Count = 0)] long time, [Count(Count = 0)] timespec* timespecTime);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrConvertTimeToTimespecTimeKHR")]
        public abstract Result ConvertTimeToTimespecTime([Count(Count = 0)] Instance instance, [Count(Count = 0)] long time, [Count(Count = 0)] ref timespec timespecTime);

        public KhrConvertTimespecTime(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

