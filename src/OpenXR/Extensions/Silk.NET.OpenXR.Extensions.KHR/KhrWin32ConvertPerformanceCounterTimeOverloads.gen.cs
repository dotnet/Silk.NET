// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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
        public static unsafe Result ConvertWin32PerformanceCounterToTime(this KhrWin32ConvertPerformanceCounterTime thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] long* performanceCounter, [Count(Count = 0)] Span<long> time)
        {
            // SpanOverloader
            return thisApi.ConvertWin32PerformanceCounterToTime(instance, performanceCounter, ref time.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ConvertWin32PerformanceCounterToTime(this KhrWin32ConvertPerformanceCounterTime thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<long> performanceCounter, [Count(Count = 0)] long* time)
        {
            // SpanOverloader
            return thisApi.ConvertWin32PerformanceCounterToTime(instance, in performanceCounter.GetPinnableReference(), time);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ConvertWin32PerformanceCounterToTime(this KhrWin32ConvertPerformanceCounterTime thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<long> performanceCounter, [Count(Count = 0)] Span<long> time)
        {
            // SpanOverloader
            return thisApi.ConvertWin32PerformanceCounterToTime(instance, in performanceCounter.GetPinnableReference(), ref time.GetPinnableReference());
        }

    }
}

