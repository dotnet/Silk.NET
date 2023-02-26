// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrPerformanceMetricsCounterUnitMETA")]
    public enum PerformanceMetricsCounterUnitMETA : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"GenericMeta\"")]
        [NativeName("Name", "XR_PERFORMANCE_METRICS_COUNTER_UNIT_GENERIC_META")]
        PerformanceMetricsCounterUnitGenericMeta = 0,
        [Obsolete("Deprecated in favour of \"PercentageMeta\"")]
        [NativeName("Name", "XR_PERFORMANCE_METRICS_COUNTER_UNIT_PERCENTAGE_META")]
        PerformanceMetricsCounterUnitPercentageMeta = 1,
        [Obsolete("Deprecated in favour of \"MillisecondsMeta\"")]
        [NativeName("Name", "XR_PERFORMANCE_METRICS_COUNTER_UNIT_MILLISECONDS_META")]
        PerformanceMetricsCounterUnitMillisecondsMeta = 2,
        [Obsolete("Deprecated in favour of \"BytesMeta\"")]
        [NativeName("Name", "XR_PERFORMANCE_METRICS_COUNTER_UNIT_BYTES_META")]
        PerformanceMetricsCounterUnitBytesMeta = 3,
        [Obsolete("Deprecated in favour of \"HertzMeta\"")]
        [NativeName("Name", "XR_PERFORMANCE_METRICS_COUNTER_UNIT_HERTZ_META")]
        PerformanceMetricsCounterUnitHertzMeta = 4,
        [NativeName("Name", "XR_PERFORMANCE_METRICS_COUNTER_UNIT_GENERIC_META")]
        GenericMeta = 0,
        [NativeName("Name", "XR_PERFORMANCE_METRICS_COUNTER_UNIT_PERCENTAGE_META")]
        PercentageMeta = 1,
        [NativeName("Name", "XR_PERFORMANCE_METRICS_COUNTER_UNIT_MILLISECONDS_META")]
        MillisecondsMeta = 2,
        [NativeName("Name", "XR_PERFORMANCE_METRICS_COUNTER_UNIT_BYTES_META")]
        BytesMeta = 3,
        [NativeName("Name", "XR_PERFORMANCE_METRICS_COUNTER_UNIT_HERTZ_META")]
        HertzMeta = 4,
    }
}
