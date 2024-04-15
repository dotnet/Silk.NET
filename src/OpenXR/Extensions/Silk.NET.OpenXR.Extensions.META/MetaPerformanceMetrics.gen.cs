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

namespace Silk.NET.OpenXR.Extensions.META
{
    [Extension("XR_META_performance_metrics")]
    public unsafe partial class MetaPerformanceMetrics : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_META_performance_metrics";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumeratePerformanceMetricsCounterPathsMETA", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumeratePerformanceMetricsCounterPathsMeta([Count(Count = 0)] Instance instance, [Count(Count = 0)] uint counterPathCapacityInput, [Count(Count = 0)] uint* counterPathCountOutput, [Count(Parameter = "counterPathCapacityInput")] ulong* counterPaths);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumeratePerformanceMetricsCounterPathsMETA", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumeratePerformanceMetricsCounterPathsMeta([Count(Count = 0)] Instance instance, [Count(Count = 0)] uint counterPathCapacityInput, [Count(Count = 0)] uint* counterPathCountOutput, [Count(Parameter = "counterPathCapacityInput")] ref ulong counterPaths);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumeratePerformanceMetricsCounterPathsMETA", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumeratePerformanceMetricsCounterPathsMeta([Count(Count = 0)] Instance instance, [Count(Count = 0)] uint counterPathCapacityInput, [Count(Count = 0)] ref uint counterPathCountOutput, [Count(Parameter = "counterPathCapacityInput")] ulong* counterPaths);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumeratePerformanceMetricsCounterPathsMETA", Convention = CallingConvention.Winapi)]
        public partial Result EnumeratePerformanceMetricsCounterPathsMeta([Count(Count = 0)] Instance instance, [Count(Count = 0)] uint counterPathCapacityInput, [Count(Count = 0)] ref uint counterPathCountOutput, [Count(Parameter = "counterPathCapacityInput")] ref ulong counterPaths);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetPerformanceMetricsStateMETA", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPerformanceMetricsStateMeta([Count(Count = 0)] Session session, [Count(Count = 0)] PerformanceMetricsStateMETA* state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetPerformanceMetricsStateMETA", Convention = CallingConvention.Winapi)]
        public partial Result GetPerformanceMetricsStateMeta([Count(Count = 0)] Session session, [Count(Count = 0)] ref PerformanceMetricsStateMETA state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrQueryPerformanceMetricsCounterMETA", Convention = CallingConvention.Winapi)]
        public unsafe partial Result QueryPerformanceMetricsCounterMeta([Count(Count = 0)] Session session, [Count(Count = 0)] ulong counterPath, [Count(Count = 0)] PerformanceMetricsCounterMETA* counter);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrQueryPerformanceMetricsCounterMETA", Convention = CallingConvention.Winapi)]
        public partial Result QueryPerformanceMetricsCounterMeta([Count(Count = 0)] Session session, [Count(Count = 0)] ulong counterPath, [Count(Count = 0)] ref PerformanceMetricsCounterMETA counter);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSetPerformanceMetricsStateMETA", Convention = CallingConvention.Winapi)]
        public unsafe partial Result SetPerformanceMetricsStateMeta([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PerformanceMetricsStateMETA* state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSetPerformanceMetricsStateMETA", Convention = CallingConvention.Winapi)]
        public partial Result SetPerformanceMetricsStateMeta([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PerformanceMetricsStateMETA state);

        /// <summary>To be documented.</summary>
        public unsafe Result EnumeratePerformanceMetricsCounterPathsMeta([Count(Count = 0)] Instance instance, [Count(Count = 0)] uint* counterPathCountOutput, [Count(Parameter = "counterPathCapacityInput")] Span<ulong> counterPaths)
        {
            // ImplicitCountSpanOverloader
            return EnumeratePerformanceMetricsCounterPathsMeta(instance, (uint) counterPaths.Length, counterPathCountOutput, ref counterPaths.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumeratePerformanceMetricsCounterPathsMeta([Count(Count = 0)] Instance instance, [Count(Count = 0)] ref uint counterPathCountOutput, [Count(Parameter = "counterPathCapacityInput")] Span<ulong> counterPaths)
        {
            // ImplicitCountSpanOverloader
            return EnumeratePerformanceMetricsCounterPathsMeta(instance, (uint) counterPaths.Length, ref counterPathCountOutput, ref counterPaths.GetPinnableReference());
        }

        public MetaPerformanceMetrics(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

