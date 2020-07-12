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
    [Extension("XR_KHR_win32_convert_performance_counter_time")]
    public abstract unsafe partial class KhrWin32ConvertPerformanceCounterTime : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_KHR_win32_convert_performance_counter_time";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrConvertTimeToWin32PerformanceCounterKHR")]
        public abstract unsafe Result ConvertTimeToWin32PerformanceCounter([Count(Count = 0)] Instance instance, [Count(Count = 0)] long time, [Count(Count = 0)] LARGE_INTEGER* performanceCounter);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrConvertTimeToWin32PerformanceCounterKHR")]
        public abstract Result ConvertTimeToWin32PerformanceCounter([Count(Count = 0)] Instance instance, [Count(Count = 0)] long time, [Count(Count = 0)] ref LARGE_INTEGER performanceCounter);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrConvertWin32PerformanceCounterToTimeKHR")]
        public abstract unsafe Result ConvertWin32PerformanceCounterToTime([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] LARGE_INTEGER* performanceCounter, [Count(Count = 0)] long* time);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrConvertWin32PerformanceCounterToTimeKHR")]
        public abstract Result ConvertWin32PerformanceCounterToTime([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref LARGE_INTEGER performanceCounter, [Count(Count = 0)] ref long time);

        public KhrWin32ConvertPerformanceCounterTime(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

