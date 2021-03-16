// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrHandJointSetEXT")]
    public enum HandJointSetEXT : int
    {
        [NativeName("Name", "XR_HAND_JOINT_SET_DEFAULT_EXT")]
        HandJointSetDefaultExt = 0,
    }
}
