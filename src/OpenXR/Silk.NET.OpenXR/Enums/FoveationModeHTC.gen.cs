// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrFoveationModeHTC")]
    public enum FoveationModeHTC : int
    {
        [Obsolete("Deprecated in favour of \"DisableHtc\"")]
        [NativeName("Name", "XR_FOVEATION_MODE_DISABLE_HTC")]
        FoveationModeDisableHtc = 0,
        [Obsolete("Deprecated in favour of \"FixedHtc\"")]
        [NativeName("Name", "XR_FOVEATION_MODE_FIXED_HTC")]
        FoveationModeFixedHtc = 1,
        [Obsolete("Deprecated in favour of \"DynamicHtc\"")]
        [NativeName("Name", "XR_FOVEATION_MODE_DYNAMIC_HTC")]
        FoveationModeDynamicHtc = 2,
        [Obsolete("Deprecated in favour of \"CustomHtc\"")]
        [NativeName("Name", "XR_FOVEATION_MODE_CUSTOM_HTC")]
        FoveationModeCustomHtc = 3,
        [NativeName("Name", "XR_FOVEATION_MODE_DISABLE_HTC")]
        DisableHtc = 0,
        [NativeName("Name", "XR_FOVEATION_MODE_FIXED_HTC")]
        FixedHtc = 1,
        [NativeName("Name", "XR_FOVEATION_MODE_DYNAMIC_HTC")]
        DynamicHtc = 2,
        [NativeName("Name", "XR_FOVEATION_MODE_CUSTOM_HTC")]
        CustomHtc = 3,
    }
}
