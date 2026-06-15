// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPerformanceMetricsCounterFlagsANDROID")]
[Flags]
public enum PerformanceMetricsCounterFlagsANDROID : ulong
{
    None = 0x0,

    [NativeName("XR_PERFORMANCE_METRICS_COUNTER_ANY_VALUE_VALID_BIT_ANDROID")]
    AnyValueValidBit = 0x1,

    [NativeName("XR_PERFORMANCE_METRICS_COUNTER_UINT_VALUE_VALID_BIT_ANDROID")]
    UintValueValidBit = 0x2,

    [NativeName("XR_PERFORMANCE_METRICS_COUNTER_FLOAT_VALUE_VALID_BIT_ANDROID")]
    FloatValueValidBit = 0x4,
}
