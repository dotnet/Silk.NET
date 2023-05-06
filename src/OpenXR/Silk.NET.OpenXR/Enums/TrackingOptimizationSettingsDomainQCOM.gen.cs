// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrTrackingOptimizationSettingsDomainQCOM")]
    public enum TrackingOptimizationSettingsDomainQCOM : int
    {
        [Obsolete("Deprecated in favour of \"AllQCom\"")]
        [NativeName("Name", "XR_TRACKING_OPTIMIZATION_SETTINGS_DOMAIN_ALL_QCOM")]
        TrackingOptimizationSettingsDomainAllQCom = 1,
        [NativeName("Name", "XR_TRACKING_OPTIMIZATION_SETTINGS_DOMAIN_ALL_QCOM")]
        AllQCom = 1,
    }
}
