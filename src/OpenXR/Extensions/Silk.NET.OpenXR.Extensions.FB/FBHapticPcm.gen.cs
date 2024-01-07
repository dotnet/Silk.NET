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

namespace Silk.NET.OpenXR.Extensions.FB
{
    [Extension("XR_FB_haptic_pcm")]
    public unsafe partial class FBHapticPcm : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_FB_haptic_pcm";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetDeviceSampleRateFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDeviceSampleRateFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] HapticActionInfo* hapticActionInfo, [Count(Count = 0)] DevicePcmSampleRateGetInfoFB* deviceSampleRate);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetDeviceSampleRateFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDeviceSampleRateFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] HapticActionInfo* hapticActionInfo, [Count(Count = 0)] ref DevicePcmSampleRateGetInfoFB deviceSampleRate);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetDeviceSampleRateFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDeviceSampleRateFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HapticActionInfo hapticActionInfo, [Count(Count = 0)] DevicePcmSampleRateGetInfoFB* deviceSampleRate);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetDeviceSampleRateFB", Convention = CallingConvention.Winapi)]
        public partial Result GetDeviceSampleRateFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HapticActionInfo hapticActionInfo, [Count(Count = 0)] ref DevicePcmSampleRateGetInfoFB deviceSampleRate);

        public FBHapticPcm(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

