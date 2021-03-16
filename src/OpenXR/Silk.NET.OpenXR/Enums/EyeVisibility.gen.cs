// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrEyeVisibility")]
    public enum EyeVisibility : int
    {
        [NativeName("Name", "XR_EYE_VISIBILITY_BOTH")]
        Both = 0,
        [NativeName("Name", "XR_EYE_VISIBILITY_LEFT")]
        Left = 1,
        [NativeName("Name", "XR_EYE_VISIBILITY_RIGHT")]
        Right = 2,
    }
}
