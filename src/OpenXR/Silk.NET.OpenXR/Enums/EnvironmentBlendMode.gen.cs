// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrEnvironmentBlendMode")]
    public enum EnvironmentBlendMode : int
    {
        [NativeName("Name", "XR_ENVIRONMENT_BLEND_MODE_OPAQUE")]
        Opaque = 1,
        [NativeName("Name", "XR_ENVIRONMENT_BLEND_MODE_ADDITIVE")]
        Additive = 2,
        [NativeName("Name", "XR_ENVIRONMENT_BLEND_MODE_ALPHA_BLEND")]
        AlphaBlend = 3,
    }
}
