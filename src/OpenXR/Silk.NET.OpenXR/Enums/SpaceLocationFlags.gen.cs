// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags()]
    [NativeName("Name", "XrSpaceLocationFlags")]
    public enum SpaceLocationFlags : int
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
