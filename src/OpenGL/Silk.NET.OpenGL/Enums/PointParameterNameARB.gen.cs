// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "PointParameterNameARB")]
    public enum PointParameterNameARB
    {
        [NativeName("Name", "GL_POINT_SIZE_MIN_EXT")]
        PointSizeMinExt = 0x8126,
        [NativeName("Name", "GL_POINT_SIZE_MAX_EXT")]
        PointSizeMaxExt = 0x8127,
        [NativeName("Name", "GL_POINT_FADE_THRESHOLD_SIZE")]
        PointFadeThresholdSize = 0x8128,
        [NativeName("Name", "GL_POINT_FADE_THRESHOLD_SIZE_EXT")]
        PointFadeThresholdSizeExt = 0x8128,
    }
}
