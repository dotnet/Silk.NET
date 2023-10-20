// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrHandTrackingDataSourceEXT")]
    public enum HandTrackingDataSourceEXT : int
    {
        [Obsolete("Deprecated in favour of \"UnobstructedExt\"")]
        [NativeName("Name", "XR_HAND_TRACKING_DATA_SOURCE_UNOBSTRUCTED_EXT")]
        HandTrackingDataSourceUnobstructedExt = 1,
        [Obsolete("Deprecated in favour of \"ControllerExt\"")]
        [NativeName("Name", "XR_HAND_TRACKING_DATA_SOURCE_CONTROLLER_EXT")]
        HandTrackingDataSourceControllerExt = 2,
        [NativeName("Name", "XR_HAND_TRACKING_DATA_SOURCE_UNOBSTRUCTED_EXT")]
        UnobstructedExt = 1,
        [NativeName("Name", "XR_HAND_TRACKING_DATA_SOURCE_CONTROLLER_EXT")]
        ControllerExt = 2,
    }
}
