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
    public static class KhrConvertTimespecTimeOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result ConvertTimespecTimeToTime(this KhrConvertTimespecTime thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] Timespec* timespecTime, [Count(Count = 0)] Span<long> time)
        {
            // SpanOverloader
            return thisApi.ConvertTimespecTimeToTime(instance, timespecTime, ref time.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ConvertTimespecTimeToTime(this KhrConvertTimespecTime thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Timespec> timespecTime, [Count(Count = 0)] long* time)
        {
            // SpanOverloader
            return thisApi.ConvertTimespecTimeToTime(instance, in timespecTime.GetPinnableReference(), time);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ConvertTimespecTimeToTime(this KhrConvertTimespecTime thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Timespec> timespecTime, [Count(Count = 0)] Span<long> time)
        {
            // SpanOverloader
            return thisApi.ConvertTimespecTimeToTime(instance, in timespecTime.GetPinnableReference(), ref time.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ConvertTimeToTimespecTime(this KhrConvertTimespecTime thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] long time, [Count(Count = 0)] Span<Timespec> timespecTime)
        {
            // SpanOverloader
            return thisApi.ConvertTimeToTimespecTime(instance, time, ref timespecTime.GetPinnableReference());
        }

    }
}

