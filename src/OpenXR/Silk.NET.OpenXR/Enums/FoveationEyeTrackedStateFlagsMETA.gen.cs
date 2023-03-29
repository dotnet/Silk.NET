// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrFoveationEyeTrackedStateFlagsMETA")]
    public enum FoveationEyeTrackedStateFlagsMETA : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"ValidBitMeta\"")]
        [NativeName("Name", "XR_FOVEATION_EYE_TRACKED_STATE_VALID_BIT_META")]
        FoveationEyeTrackedStateValidBitMeta = 1,
        [NativeName("Name", "XR_FOVEATION_EYE_TRACKED_STATE_VALID_BIT_META")]
        ValidBitMeta = 1,
    }
}
