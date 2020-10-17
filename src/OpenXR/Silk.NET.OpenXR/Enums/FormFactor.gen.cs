// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrFormFactor")]
    public enum FormFactor
    {
        [NativeName("Name", "XR_FORM_FACTOR_HEAD_MOUNTED_DISPLAY")]
        HeadMountedDisplay = 1,
        [NativeName("Name", "XR_FORM_FACTOR_HANDHELD_DISPLAY")]
        HandheldDisplay = 2,
    }
}
