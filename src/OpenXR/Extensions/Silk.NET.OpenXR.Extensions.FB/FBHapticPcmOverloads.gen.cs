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

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.FB
{
    public static class FBHapticPcmOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetDeviceSampleRateFB(this FBHapticPcm thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] HapticActionInfo* hapticActionInfo, [Count(Count = 0)] Span<DevicePcmSampleRateGetInfoFB> deviceSampleRate)
        {
            // SpanOverloader
            return thisApi.GetDeviceSampleRateFB(session, hapticActionInfo, ref deviceSampleRate.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetDeviceSampleRateFB(this FBHapticPcm thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HapticActionInfo> hapticActionInfo, [Count(Count = 0)] DevicePcmSampleRateGetInfoFB* deviceSampleRate)
        {
            // SpanOverloader
            return thisApi.GetDeviceSampleRateFB(session, in hapticActionInfo.GetPinnableReference(), deviceSampleRate);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetDeviceSampleRateFB(this FBHapticPcm thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HapticActionInfo> hapticActionInfo, [Count(Count = 0)] Span<DevicePcmSampleRateGetInfoFB> deviceSampleRate)
        {
            // SpanOverloader
            return thisApi.GetDeviceSampleRateFB(session, in hapticActionInfo.GetPinnableReference(), ref deviceSampleRate.GetPinnableReference());
        }

    }
}

