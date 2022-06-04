// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrPerformanceMetricsCounterUnitMETA")]
    public enum PerformanceMetricsCounterUnitMETA : int
    {
        [NativeName("Name", "XR_PERFORMANCE_METRICS_COUNTER_UNIT_GENERIC_META")]
        PerformanceMetricsCounterUnitGenericMeta = 0,
        [NativeName("Name", "XR_PERFORMANCE_METRICS_COUNTER_UNIT_PERCENTAGE_META")]
        PerformanceMetricsCounterUnitPercentageMeta = 1,
        [NativeName("Name", "XR_PERFORMANCE_METRICS_COUNTER_UNIT_MILLISECONDS_META")]
        PerformanceMetricsCounterUnitMillisecondsMeta = 2,
        [NativeName("Name", "XR_PERFORMANCE_METRICS_COUNTER_UNIT_BYTES_META")]
        PerformanceMetricsCounterUnitBytesMeta = 3,
        [NativeName("Name", "XR_PERFORMANCE_METRICS_COUNTER_UNIT_HERTZ_META")]
        PerformanceMetricsCounterUnitHertzMeta = 4,
    }
}
