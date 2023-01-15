// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrFoveationDynamicFB")]
    public enum FoveationDynamicFB : int
    {
        [Obsolete("Deprecated in favour of \"DisabledFB\"")]
        [NativeName("Name", "XR_FOVEATION_DYNAMIC_DISABLED_FB")]
        FoveationDynamicDisabledFB = 0,
        [Obsolete("Deprecated in favour of \"LevelEnabledFB\"")]
        [NativeName("Name", "XR_FOVEATION_DYNAMIC_LEVEL_ENABLED_FB")]
        FoveationDynamicLevelEnabledFB = 1,
        [NativeName("Name", "XR_FOVEATION_DYNAMIC_DISABLED_FB")]
        DisabledFB = 0,
        [NativeName("Name", "XR_FOVEATION_DYNAMIC_LEVEL_ENABLED_FB")]
        LevelEnabledFB = 1,
    }
}
