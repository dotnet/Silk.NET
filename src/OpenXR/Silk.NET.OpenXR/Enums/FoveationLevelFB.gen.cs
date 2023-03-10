// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrFoveationLevelFB")]
    public enum FoveationLevelFB : int
    {
        [Obsolete("Deprecated in favour of \"NoneFB\"")]
        [NativeName("Name", "XR_FOVEATION_LEVEL_NONE_FB")]
        FoveationLevelNoneFB = 0,
        [Obsolete("Deprecated in favour of \"LowFB\"")]
        [NativeName("Name", "XR_FOVEATION_LEVEL_LOW_FB")]
        FoveationLevelLowFB = 1,
        [Obsolete("Deprecated in favour of \"MediumFB\"")]
        [NativeName("Name", "XR_FOVEATION_LEVEL_MEDIUM_FB")]
        FoveationLevelMediumFB = 2,
        [Obsolete("Deprecated in favour of \"HighFB\"")]
        [NativeName("Name", "XR_FOVEATION_LEVEL_HIGH_FB")]
        FoveationLevelHighFB = 3,
        [NativeName("Name", "XR_FOVEATION_LEVEL_NONE_FB")]
        NoneFB = 0,
        [NativeName("Name", "XR_FOVEATION_LEVEL_LOW_FB")]
        LowFB = 1,
        [NativeName("Name", "XR_FOVEATION_LEVEL_MEDIUM_FB")]
        MediumFB = 2,
        [NativeName("Name", "XR_FOVEATION_LEVEL_HIGH_FB")]
        HighFB = 3,
    }
}
