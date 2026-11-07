// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPerformanceMetricsCounterUnitMETA")]
[SupportedApiProfile("openxr")]
public enum PerformanceMetricsCounterUnitMETA : uint
{
    [NativeName("XR_PERFORMANCE_METRICS_COUNTER_UNIT_GENERIC_META")]
    [SupportedApiProfile("openxr", ["XR_META_performance_metrics"])]
    Generic = 0,

    [NativeName("XR_PERFORMANCE_METRICS_COUNTER_UNIT_PERCENTAGE_META")]
    [SupportedApiProfile("openxr", ["XR_META_performance_metrics"])]
    Percentage = 1,

    [NativeName("XR_PERFORMANCE_METRICS_COUNTER_UNIT_MILLISECONDS_META")]
    [SupportedApiProfile("openxr", ["XR_META_performance_metrics"])]
    Milliseconds = 2,

    [NativeName("XR_PERFORMANCE_METRICS_COUNTER_UNIT_BYTES_META")]
    [SupportedApiProfile("openxr", ["XR_META_performance_metrics"])]
    Bytes = 3,

    [NativeName("XR_PERFORMANCE_METRICS_COUNTER_UNIT_HERTZ_META")]
    [SupportedApiProfile("openxr", ["XR_META_performance_metrics"])]
    Hertz = 4,
}
