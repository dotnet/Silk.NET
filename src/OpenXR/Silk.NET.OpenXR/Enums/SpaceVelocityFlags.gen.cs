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
    [NativeName("Name", "XrSpaceVelocityFlags")]
    public enum SpaceVelocityFlags : int
    {
        [NativeName("Name", "XR_SPACE_VELOCITY_LINEAR_VALID_BIT")]
        SpaceVelocityLinearValidBit = 1,
        [NativeName("Name", "XR_SPACE_VELOCITY_ANGULAR_VALID_BIT")]
        SpaceVelocityAngularValidBit = 2,
    }
}
