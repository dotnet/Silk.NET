// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "PointParameterNameARB")]
    public enum PointParameterNameARB : int
    {
        [NativeName("Name", "GL_POINT_SIZE_MIN_ARB")]
        PointSizeMinArb = 0x8126,
        [NativeName("Name", "GL_POINT_SIZE_MIN_EXT")]
        PointSizeMinExt = 0x8126,
        [NativeName("Name", "GL_POINT_SIZE_MIN_SGIS")]
        PointSizeMinSgis = 0x8126,
        [NativeName("Name", "GL_POINT_SIZE_MAX_ARB")]
        PointSizeMaxArb = 0x8127,
        [NativeName("Name", "GL_POINT_SIZE_MAX_EXT")]
        PointSizeMaxExt = 0x8127,
        [NativeName("Name", "GL_POINT_SIZE_MAX_SGIS")]
        PointSizeMaxSgis = 0x8127,
        [NativeName("Name", "GL_POINT_FADE_THRESHOLD_SIZE")]
        PointFadeThresholdSize = 0x8128,
        [NativeName("Name", "GL_POINT_FADE_THRESHOLD_SIZE_ARB")]
        PointFadeThresholdSizeArb = 0x8128,
        [NativeName("Name", "GL_POINT_FADE_THRESHOLD_SIZE_EXT")]
        PointFadeThresholdSizeExt = 0x8128,
        [NativeName("Name", "GL_POINT_FADE_THRESHOLD_SIZE_SGIS")]
        PointFadeThresholdSizeSgis = 0x8128,
        [NativeName("Name", "GL_DISTANCE_ATTENUATION_EXT")]
        DistanceAttenuationExt = 0x8129,
        [NativeName("Name", "GL_DISTANCE_ATTENUATION_SGIS")]
        DistanceAttenuationSgis = 0x8129,
        [NativeName("Name", "GL_POINT_DISTANCE_ATTENUATION_ARB")]
        PointDistanceAttenuationArb = 0x8129,
    }
}
