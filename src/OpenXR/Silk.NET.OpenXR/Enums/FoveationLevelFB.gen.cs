// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrFoveationLevelFB")]
    public enum FoveationLevelFB : int
    {
        [NativeName("Name", "XR_FOVEATION_LEVEL_NONE_FB")]
        FoveationLevelNoneFB = 0,
        [NativeName("Name", "XR_FOVEATION_LEVEL_LOW_FB")]
        FoveationLevelLowFB = 1,
        [NativeName("Name", "XR_FOVEATION_LEVEL_MEDIUM_FB")]
        FoveationLevelMediumFB = 2,
        [NativeName("Name", "XR_FOVEATION_LEVEL_HIGH_FB")]
        FoveationLevelHighFB = 3,
    }
}
