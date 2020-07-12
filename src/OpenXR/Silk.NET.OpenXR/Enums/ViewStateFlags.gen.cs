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
    [NativeName("Name", "XrViewStateFlags")]
    public enum ViewStateFlags
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
