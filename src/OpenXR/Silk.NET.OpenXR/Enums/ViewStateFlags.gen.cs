// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrViewStateFlags")]
    public enum ViewStateFlags : long
    {
        [NativeName("Name", "XR_VIEW_STATE_ORIENTATION_VALID_BIT")]
        ViewStateOrientationValidBit = 1,
        [NativeName("Name", "XR_VIEW_STATE_POSITION_VALID_BIT")]
        ViewStatePositionValidBit = 2,
        [NativeName("Name", "XR_VIEW_STATE_ORIENTATION_TRACKED_BIT")]
        ViewStateOrientationTrackedBit = 4,
        [NativeName("Name", "XR_VIEW_STATE_POSITION_TRACKED_BIT")]
        ViewStatePositionTrackedBit = 8,
    }
}
