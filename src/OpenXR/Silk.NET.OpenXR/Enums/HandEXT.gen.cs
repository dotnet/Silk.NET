// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
