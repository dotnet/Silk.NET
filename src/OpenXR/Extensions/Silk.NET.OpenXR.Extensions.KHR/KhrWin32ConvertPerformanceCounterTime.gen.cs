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
using Silk.NET.OpenXR;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.KHR
{
    [Extension("XR_KHR_win32_convert_performance_counter_time")]
    public unsafe partial class KhrWin32ConvertPerformanceCounterTime : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_KHR_win32_convert_performance_counter_time";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrConvertTimeToWin32PerformanceCounterKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ConvertTimeToWin32PerformanceCounter([Count(Count = 0)] Instance instance, [Count(Count = 0)] long time, [Count(Count = 0)] long* performanceCounter);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrConvertTimeToWin32PerformanceCounterKHR", Convention = CallingConvention.Winapi)]
        public partial Result ConvertTimeToWin32PerformanceCounter([Count(Count = 0)] Instance instance, [Count(Count = 0)] long time, [Count(Count = 0)] ref long performanceCounter);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrConvertWin32PerformanceCounterToTimeKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ConvertWin32PerformanceCounterToTime([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] long* performanceCounter, [Count(Count = 0)] long* time);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrConvertWin32PerformanceCounterToTimeKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ConvertWin32PerformanceCounterToTime([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] long* performanceCounter, [Count(Count = 0)] ref long time);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrConvertWin32PerformanceCounterToTimeKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ConvertWin32PerformanceCounterToTime([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in long performanceCounter, [Count(Count = 0)] long* time);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrConvertWin32PerformanceCounterToTimeKHR", Convention = CallingConvention.Winapi)]
        public partial Result ConvertWin32PerformanceCounterToTime([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in long performanceCounter, [Count(Count = 0)] ref long time);

        public KhrWin32ConvertPerformanceCounterTime(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

