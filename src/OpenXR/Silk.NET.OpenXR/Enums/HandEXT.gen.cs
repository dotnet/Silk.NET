// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrHandEXT")]
    public enum HandEXT : int
    {
        [NativeName("Name", "XR_HAND_LEFT_EXT")]
        HandLeftExt = 1,
        [NativeName("Name", "XR_HAND_RIGHT_EXT")]
        HandRightExt = 2,
    }
}
