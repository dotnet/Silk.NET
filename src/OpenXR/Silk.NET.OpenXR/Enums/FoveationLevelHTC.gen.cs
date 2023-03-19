// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrFoveationLevelHTC")]
    public enum FoveationLevelHTC : int
    {
        [Obsolete("Deprecated in favour of \"NoneHtc\"")]
        [NativeName("Name", "XR_FOVEATION_LEVEL_NONE_HTC")]
        FoveationLevelNoneHtc = 0,
        [Obsolete("Deprecated in favour of \"LowHtc\"")]
        [NativeName("Name", "XR_FOVEATION_LEVEL_LOW_HTC")]
        FoveationLevelLowHtc = 1,
        [Obsolete("Deprecated in favour of \"MediumHtc\"")]
        [NativeName("Name", "XR_FOVEATION_LEVEL_MEDIUM_HTC")]
        FoveationLevelMediumHtc = 2,
        [Obsolete("Deprecated in favour of \"HighHtc\"")]
        [NativeName("Name", "XR_FOVEATION_LEVEL_HIGH_HTC")]
        FoveationLevelHighHtc = 3,
        [NativeName("Name", "XR_FOVEATION_LEVEL_NONE_HTC")]
        NoneHtc = 0,
        [NativeName("Name", "XR_FOVEATION_LEVEL_LOW_HTC")]
        LowHtc = 1,
        [NativeName("Name", "XR_FOVEATION_LEVEL_MEDIUM_HTC")]
        MediumHtc = 2,
        [NativeName("Name", "XR_FOVEATION_LEVEL_HIGH_HTC")]
        HighHtc = 3,
    }
}
