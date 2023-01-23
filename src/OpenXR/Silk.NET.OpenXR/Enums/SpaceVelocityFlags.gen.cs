// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrSpaceVelocityFlags")]
    public enum SpaceVelocityFlags : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"LinearValidBit\"")]
        [NativeName("Name", "XR_SPACE_VELOCITY_LINEAR_VALID_BIT")]
        SpaceVelocityLinearValidBit = 1,
        [Obsolete("Deprecated in favour of \"AngularValidBit\"")]
        [NativeName("Name", "XR_SPACE_VELOCITY_ANGULAR_VALID_BIT")]
        SpaceVelocityAngularValidBit = 2,
        [NativeName("Name", "XR_SPACE_VELOCITY_LINEAR_VALID_BIT")]
        LinearValidBit = 1,
        [NativeName("Name", "XR_SPACE_VELOCITY_ANGULAR_VALID_BIT")]
        AngularValidBit = 2,
    }
}
