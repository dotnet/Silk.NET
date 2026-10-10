// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPerformanceMetricsCounterFlagsMETA")]
[Flags]
public enum PerformanceMetricsCounterFlagsMETA : ulong
{
    None = 0x0,

    [NativeName("XR_PERFORMANCE_METRICS_COUNTER_ANY_VALUE_VALID_BIT_META")]
    AnyValueValidBit = 0x1,

    [NativeName("XR_PERFORMANCE_METRICS_COUNTER_UINT_VALUE_VALID_BIT_META")]
    UintValueValidBit = 0x2,

    [NativeName("XR_PERFORMANCE_METRICS_COUNTER_FLOAT_VALUE_VALID_BIT_META")]
    FloatValueValidBit = 0x4,
}
