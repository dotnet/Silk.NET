// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPerformanceMetricsCounterMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct PerformanceMetricsCounterMETA
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_META_performance_metrics"])]
    public StructureType Type = StructureType.TypePerformanceMetricsCounterMETA;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_META_performance_metrics"])]
    public void* Next;

    [NativeName("counterFlags")]
    [SupportedApiProfile("openxr", ["XR_META_performance_metrics"])]
    public PerformanceMetricsCounterFlagsMETA CounterFlags;

    [NativeName("counterUnit")]
    [SupportedApiProfile("openxr", ["XR_META_performance_metrics"])]
    public PerformanceMetricsCounterUnitMETA CounterUnit;

    [NativeName("uintValue")]
    [SupportedApiProfile("openxr", ["XR_META_performance_metrics"])]
    public uint UintValue;

    [NativeName("floatValue")]
    [SupportedApiProfile("openxr", ["XR_META_performance_metrics"])]
    public float FloatValue;

    [SupportedApiProfile("openxr", ["XR_META_performance_metrics"])]
    public PerformanceMetricsCounterMETA() { }
}
