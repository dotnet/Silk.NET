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

namespace Silk.NET.OpenXR.Extensions.META
{
    public static class MetaPerformanceMetricsOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result EnumeratePerformanceMetricsCounterPathsMeta(this MetaPerformanceMetrics thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] uint counterPathCapacityInput, [Count(Count = 0)] uint* counterPathCountOutput, [Count(Parameter = "counterPathCapacityInput")] Span<ulong> counterPaths)
        {
            // SpanOverloader
            return thisApi.EnumeratePerformanceMetricsCounterPathsMeta(instance, counterPathCapacityInput, counterPathCountOutput, ref counterPaths.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumeratePerformanceMetricsCounterPathsMeta(this MetaPerformanceMetrics thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] uint counterPathCapacityInput, [Count(Count = 0)] Span<uint> counterPathCountOutput, [Count(Parameter = "counterPathCapacityInput")] ulong* counterPaths)
        {
            // SpanOverloader
            return thisApi.EnumeratePerformanceMetricsCounterPathsMeta(instance, counterPathCapacityInput, ref counterPathCountOutput.GetPinnableReference(), counterPaths);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumeratePerformanceMetricsCounterPathsMeta(this MetaPerformanceMetrics thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] uint counterPathCapacityInput, [Count(Count = 0)] Span<uint> counterPathCountOutput, [Count(Parameter = "counterPathCapacityInput")] Span<ulong> counterPaths)
        {
            // SpanOverloader
            return thisApi.EnumeratePerformanceMetricsCounterPathsMeta(instance, counterPathCapacityInput, ref counterPathCountOutput.GetPinnableReference(), ref counterPaths.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPerformanceMetricsStateMeta(this MetaPerformanceMetrics thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] Span<PerformanceMetricsStateMETA> state)
        {
            // SpanOverloader
            return thisApi.GetPerformanceMetricsStateMeta(session, ref state.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result QueryPerformanceMetricsCounterMeta(this MetaPerformanceMetrics thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] ulong counterPath, [Count(Count = 0)] Span<PerformanceMetricsCounterMETA> counter)
        {
            // SpanOverloader
            return thisApi.QueryPerformanceMetricsCounterMeta(session, counterPath, ref counter.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result SetPerformanceMetricsStateMeta(this MetaPerformanceMetrics thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PerformanceMetricsStateMETA> state)
        {
            // SpanOverloader
            return thisApi.SetPerformanceMetricsStateMeta(session, in state.GetPinnableReference());
        }

    }
}

