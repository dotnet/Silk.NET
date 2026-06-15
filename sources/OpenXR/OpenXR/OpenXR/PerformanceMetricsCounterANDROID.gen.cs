// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPerformanceMetricsCounterANDROID")]
[SupportedApiProfile("openxr")]
public unsafe partial struct PerformanceMetricsCounterANDROID
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_performance_metrics"])]
    public StructureType Type = StructureType.TypePerformanceMetricsCounterANDROID;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_performance_metrics"])]
    public void* Next;

    [NativeName("counterFlags")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_performance_metrics"])]
    public PerformanceMetricsCounterFlagsANDROID CounterFlags;

    [NativeName("counterUnit")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_performance_metrics"])]
    public PerformanceMetricsCounterUnitANDROID CounterUnit;

    [NativeName("uintValue")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_performance_metrics"])]
    public uint UintValue;

    [NativeName("floatValue")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_performance_metrics"])]
    public float FloatValue;

    [SupportedApiProfile("openxr", ["XR_ANDROID_performance_metrics"])]
    public PerformanceMetricsCounterANDROID() { }
}
