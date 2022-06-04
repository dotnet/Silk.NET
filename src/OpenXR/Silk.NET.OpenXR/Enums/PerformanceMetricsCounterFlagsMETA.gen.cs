// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrPerformanceMetricsCounterFlagsMETA")]
    public enum PerformanceMetricsCounterFlagsMETA : long
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "XR_PERFORMANCE_METRICS_COUNTER_ANY_VALUE_VALID_BIT_META")]
        PerformanceMetricsCounterAnyValueValidBitMeta = 1,
        [NativeName("Name", "XR_PERFORMANCE_METRICS_COUNTER_UINT_VALUE_VALID_BIT_META")]
        PerformanceMetricsCounterUintValueValidBitMeta = 2,
        [NativeName("Name", "XR_PERFORMANCE_METRICS_COUNTER_FLOAT_VALUE_VALID_BIT_META")]
        PerformanceMetricsCounterFloatValueValidBitMeta = 4,
    }
}
