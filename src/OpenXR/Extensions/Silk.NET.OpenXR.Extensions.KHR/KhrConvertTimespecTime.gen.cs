// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenXR;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.KHR
{
    [Extension("XR_KHR_convert_timespec_time")]
    public unsafe partial class KhrConvertTimespecTime : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_KHR_convert_timespec_time";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrConvertTimespecTimeToTimeKHR")]
        public unsafe partial Result ConvertTimespecTimeToTime([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ValueTuple<IntPtr,IntPtr>* timespecTime, [Count(Count = 0)] long* time);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrConvertTimespecTimeToTimeKHR")]
        public partial Result ConvertTimespecTimeToTime([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref ValueTuple<IntPtr,IntPtr> timespecTime, [Count(Count = 0)] ref long time);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrConvertTimeToTimespecTimeKHR")]
        public unsafe partial Result ConvertTimeToTimespecTime([Count(Count = 0)] Instance instance, [Count(Count = 0)] long time, [Count(Count = 0)] ValueTuple<IntPtr,IntPtr>* timespecTime);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrConvertTimeToTimespecTimeKHR")]
        public partial Result ConvertTimeToTimespecTime([Count(Count = 0)] Instance instance, [Count(Count = 0)] long time, [Count(Count = 0)] ref ValueTuple<IntPtr,IntPtr> timespecTime);

        public KhrConvertTimespecTime(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

