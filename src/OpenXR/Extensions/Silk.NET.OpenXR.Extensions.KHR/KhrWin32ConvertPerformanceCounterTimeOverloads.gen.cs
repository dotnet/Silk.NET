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

namespace Silk.NET.OpenXR.Extensions.KHR
{
    public static class KhrWin32ConvertPerformanceCounterTimeOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result ConvertTimeToWin32PerformanceCounter(this KhrWin32ConvertPerformanceCounterTime thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] long time, [Count(Count = 0)] Span<long> performanceCounter)
        {
            // SpanOverloader
            return thisApi.ConvertTimeToWin32PerformanceCounter(instance, time, ref performanceCounter.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ConvertWin32PerformanceCounterToTime(this KhrWin32ConvertPerformanceCounterTime thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] long* performanceCounter, [Count(Count = 0)] Span<long> time)
        {
            // SpanOverloader
            return thisApi.ConvertWin32PerformanceCounterToTime(instance, performanceCounter, ref time.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ConvertWin32PerformanceCounterToTime(this KhrWin32ConvertPerformanceCounterTime thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<long> performanceCounter, [Count(Count = 0)] long* time)
        {
            // SpanOverloader
            return thisApi.ConvertWin32PerformanceCounterToTime(instance, in performanceCounter.GetPinnableReference(), time);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ConvertWin32PerformanceCounterToTime(this KhrWin32ConvertPerformanceCounterTime thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<long> performanceCounter, [Count(Count = 0)] Span<long> time)
        {
            // SpanOverloader
            return thisApi.ConvertWin32PerformanceCounterToTime(instance, in performanceCounter.GetPinnableReference(), ref time.GetPinnableReference());
        }

    }
}

