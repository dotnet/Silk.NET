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
    [Extension("XR_KHR_convert_timespec_time")]
    public unsafe partial class KhrConvertTimespecTime : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_KHR_convert_timespec_time";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrConvertTimespecTimeToTimeKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ConvertTimespecTimeToTime([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] Timespec* timespecTime, [Count(Count = 0)] long* time);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrConvertTimespecTimeToTimeKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ConvertTimespecTimeToTime([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] Timespec* timespecTime, [Count(Count = 0)] ref long time);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrConvertTimespecTimeToTimeKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ConvertTimespecTimeToTime([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Timespec timespecTime, [Count(Count = 0)] long* time);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrConvertTimespecTimeToTimeKHR", Convention = CallingConvention.Winapi)]
        public partial Result ConvertTimespecTimeToTime([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Timespec timespecTime, [Count(Count = 0)] ref long time);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrConvertTimeToTimespecTimeKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ConvertTimeToTimespecTime([Count(Count = 0)] Instance instance, [Count(Count = 0)] long time, [Count(Count = 0)] Timespec* timespecTime);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrConvertTimeToTimespecTimeKHR", Convention = CallingConvention.Winapi)]
        public partial Result ConvertTimeToTimespecTime([Count(Count = 0)] Instance instance, [Count(Count = 0)] long time, [Count(Count = 0)] ref Timespec timespecTime);

        public KhrConvertTimespecTime(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

