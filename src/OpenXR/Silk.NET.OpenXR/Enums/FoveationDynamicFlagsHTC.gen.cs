// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrFoveationDynamicFlagsHTC")]
    public enum FoveationDynamicFlagsHTC : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"LevelEnabledBitHtc\"")]
        [NativeName("Name", "XR_FOVEATION_DYNAMIC_LEVEL_ENABLED_BIT_HTC")]
        FoveationDynamicLevelEnabledBitHtc = 1,
        [Obsolete("Deprecated in favour of \"ClearFovEnabledBitHtc\"")]
        [NativeName("Name", "XR_FOVEATION_DYNAMIC_CLEAR_FOV_ENABLED_BIT_HTC")]
        FoveationDynamicClearFovEnabledBitHtc = 2,
        [Obsolete("Deprecated in favour of \"FocalCenterOffsetEnabledBitHtc\"")]
        [NativeName("Name", "XR_FOVEATION_DYNAMIC_FOCAL_CENTER_OFFSET_ENABLED_BIT_HTC")]
        FoveationDynamicFocalCenterOffsetEnabledBitHtc = 4,
        [NativeName("Name", "XR_FOVEATION_DYNAMIC_LEVEL_ENABLED_BIT_HTC")]
        LevelEnabledBitHtc = 1,
        [NativeName("Name", "XR_FOVEATION_DYNAMIC_CLEAR_FOV_ENABLED_BIT_HTC")]
        ClearFovEnabledBitHtc = 2,
        [NativeName("Name", "XR_FOVEATION_DYNAMIC_FOCAL_CENTER_OFFSET_ENABLED_BIT_HTC")]
        FocalCenterOffsetEnabledBitHtc = 4,
    }
}
