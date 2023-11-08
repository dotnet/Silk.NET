// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrHeadsetFitStatusML")]
    public enum HeadsetFitStatusML : int
    {
        [Obsolete("Deprecated in favour of \"UnknownML\"")]
        [NativeName("Name", "XR_HEADSET_FIT_STATUS_UNKNOWN_ML")]
        HeadsetFitStatusUnknownML = 0,
        [Obsolete("Deprecated in favour of \"NotWornML\"")]
        [NativeName("Name", "XR_HEADSET_FIT_STATUS_NOT_WORN_ML")]
        HeadsetFitStatusNotWornML = 1,
        [Obsolete("Deprecated in favour of \"GoodFitML\"")]
        [NativeName("Name", "XR_HEADSET_FIT_STATUS_GOOD_FIT_ML")]
        HeadsetFitStatusGoodFitML = 2,
        [Obsolete("Deprecated in favour of \"BadFitML\"")]
        [NativeName("Name", "XR_HEADSET_FIT_STATUS_BAD_FIT_ML")]
        HeadsetFitStatusBadFitML = 3,
        [NativeName("Name", "XR_HEADSET_FIT_STATUS_UNKNOWN_ML")]
        UnknownML = 0,
        [NativeName("Name", "XR_HEADSET_FIT_STATUS_NOT_WORN_ML")]
        NotWornML = 1,
        [NativeName("Name", "XR_HEADSET_FIT_STATUS_GOOD_FIT_ML")]
        GoodFitML = 2,
        [NativeName("Name", "XR_HEADSET_FIT_STATUS_BAD_FIT_ML")]
        BadFitML = 3,
    }
}
