// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrTrackingOptimizationSettingsHintQCOM")]
[SupportedApiProfile("openxr")]
public enum TrackingOptimizationSettingsHintQCOM : uint
{
    [NativeName("XR_TRACKING_OPTIMIZATION_SETTINGS_HINT_NONE_QCOM")]
    [SupportedApiProfile("openxr", ["XR_QCOM_tracking_optimization_settings"])]
    None = 0,

    [NativeName("XR_TRACKING_OPTIMIZATION_SETTINGS_HINT_LONG_RANGE_PRIORIZATION_QCOM")]
    [SupportedApiProfile("openxr", ["XR_QCOM_tracking_optimization_settings"])]
    LongRangePriorization = 1,

    [NativeName("XR_TRACKING_OPTIMIZATION_SETTINGS_HINT_CLOSE_RANGE_PRIORIZATION_QCOM")]
    [SupportedApiProfile("openxr", ["XR_QCOM_tracking_optimization_settings"])]
    CloseRangePriorization = 2,

    [NativeName("XR_TRACKING_OPTIMIZATION_SETTINGS_HINT_LOW_POWER_PRIORIZATION_QCOM")]
    [SupportedApiProfile("openxr", ["XR_QCOM_tracking_optimization_settings"])]
    LowPowerPriorization = 3,

    [NativeName("XR_TRACKING_OPTIMIZATION_SETTINGS_HINT_HIGH_POWER_PRIORIZATION_QCOM")]
    [SupportedApiProfile("openxr", ["XR_QCOM_tracking_optimization_settings"])]
    HighPowerPriorization = 4,
}
