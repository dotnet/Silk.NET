// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrTrackingOptimizationSettingsHintQCOM")]
    public enum TrackingOptimizationSettingsHintQCOM : int
    {
        [Obsolete("Deprecated in favour of \"NoneQCom\"")]
        [NativeName("Name", "XR_TRACKING_OPTIMIZATION_SETTINGS_HINT_NONE_QCOM")]
        TrackingOptimizationSettingsHintNoneQCom = 0,
        [Obsolete("Deprecated in favour of \"LongRangePriorizationQCom\"")]
        [NativeName("Name", "XR_TRACKING_OPTIMIZATION_SETTINGS_HINT_LONG_RANGE_PRIORIZATION_QCOM")]
        TrackingOptimizationSettingsHintLongRangePriorizationQCom = 1,
        [Obsolete("Deprecated in favour of \"CloseRangePriorizationQCom\"")]
        [NativeName("Name", "XR_TRACKING_OPTIMIZATION_SETTINGS_HINT_CLOSE_RANGE_PRIORIZATION_QCOM")]
        TrackingOptimizationSettingsHintCloseRangePriorizationQCom = 2,
        [Obsolete("Deprecated in favour of \"LowPowerPriorizationQCom\"")]
        [NativeName("Name", "XR_TRACKING_OPTIMIZATION_SETTINGS_HINT_LOW_POWER_PRIORIZATION_QCOM")]
        TrackingOptimizationSettingsHintLowPowerPriorizationQCom = 3,
        [Obsolete("Deprecated in favour of \"HighPowerPriorizationQCom\"")]
        [NativeName("Name", "XR_TRACKING_OPTIMIZATION_SETTINGS_HINT_HIGH_POWER_PRIORIZATION_QCOM")]
        TrackingOptimizationSettingsHintHighPowerPriorizationQCom = 4,
        [NativeName("Name", "XR_TRACKING_OPTIMIZATION_SETTINGS_HINT_NONE_QCOM")]
        NoneQCom = 0,
        [NativeName("Name", "XR_TRACKING_OPTIMIZATION_SETTINGS_HINT_LONG_RANGE_PRIORIZATION_QCOM")]
        LongRangePriorizationQCom = 1,
        [NativeName("Name", "XR_TRACKING_OPTIMIZATION_SETTINGS_HINT_CLOSE_RANGE_PRIORIZATION_QCOM")]
        CloseRangePriorizationQCom = 2,
        [NativeName("Name", "XR_TRACKING_OPTIMIZATION_SETTINGS_HINT_LOW_POWER_PRIORIZATION_QCOM")]
        LowPowerPriorizationQCom = 3,
        [NativeName("Name", "XR_TRACKING_OPTIMIZATION_SETTINGS_HINT_HIGH_POWER_PRIORIZATION_QCOM")]
        HighPowerPriorizationQCom = 4,
    }
}
