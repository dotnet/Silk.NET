// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrSpaceLocationFlags")]
    public enum SpaceLocationFlags : long
    {
        [NativeName("Name", "XR_SPACE_LOCATION_ORIENTATION_VALID_BIT")]
        SpaceLocationOrientationValidBit = 1,
        [NativeName("Name", "XR_SPACE_LOCATION_POSITION_VALID_BIT")]
        SpaceLocationPositionValidBit = 2,
        [NativeName("Name", "XR_SPACE_LOCATION_ORIENTATION_TRACKED_BIT")]
        SpaceLocationOrientationTrackedBit = 4,
        [NativeName("Name", "XR_SPACE_LOCATION_POSITION_TRACKED_BIT")]
        SpaceLocationPositionTrackedBit = 8,
    }
}
