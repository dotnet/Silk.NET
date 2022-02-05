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
        [NativeName("Name", "XR_SPACE_VELOCITY_LINEAR_VALID_BIT")]
        SpaceVelocityLinearValidBit = 1,
        [NativeName("Name", "XR_SPACE_VELOCITY_ANGULAR_VALID_BIT")]
        SpaceVelocityAngularValidBit = 2,
    }
}
