// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPerfSettingsLevelEXT")]
[SupportedApiProfile("openxr")]
public enum PerfSettingsLevelEXT : uint
{
    [NativeName("XR_PERF_SETTINGS_LEVEL_POWER_SAVINGS_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_performance_settings"])]
    PowerSavings = 0,

    [NativeName("XR_PERF_SETTINGS_LEVEL_SUSTAINED_LOW_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_performance_settings"])]
    SustainedLow = 25,

    [NativeName("XR_PERF_SETTINGS_LEVEL_SUSTAINED_HIGH_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_performance_settings"])]
    SustainedHigh = 50,

    [NativeName("XR_PERF_SETTINGS_LEVEL_BOOST_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_performance_settings"])]
    Boost = 75,
}
