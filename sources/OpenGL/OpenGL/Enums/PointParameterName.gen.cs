// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PointParameterNameARB")]
public enum PointParameterName : uint
{
    [NativeName("GL_POINT_SIZE_MIN")]
    PointSizeMin = 33062,

    [NativeName("GL_POINT_SIZE_MAX")]
    PointSizeMax = 33063,

    [NativeName("GL_POINT_FADE_THRESHOLD_SIZE")]
    PointFadeThresholdSize = 33064,

    [NativeName("GL_POINT_DISTANCE_ATTENUATION")]
    PointDistanceAttenuation = 33065,

    [NativeName("GL_POINT_SIZE_MIN_ARB")]
    PointSizeMinARB = 33062,

    [NativeName("GL_POINT_SIZE_MAX_ARB")]
    PointSizeMaxARB = 33063,

    [NativeName("GL_POINT_FADE_THRESHOLD_SIZE_ARB")]
    PointFadeThresholdSizeARB = 33064,

    [NativeName("GL_POINT_DISTANCE_ATTENUATION_ARB")]
    PointDistanceAttenuationARB = 33065,

    [NativeName("GL_POINT_SIZE_MIN_EXT")]
    PointSizeMinEXT = 33062,

    [NativeName("GL_POINT_SIZE_MAX_EXT")]
    PointSizeMaxEXT = 33063,

    [NativeName("GL_POINT_FADE_THRESHOLD_SIZE_EXT")]
    PointFadeThresholdSizeEXT = 33064,

    [NativeName("GL_DISTANCE_ATTENUATION_EXT")]
    DistanceAttenuationEXT = 33065,

    [NativeName("GL_POINT_SIZE_MIN_SGIS")]
    PointSizeMinSGIS = 33062,

    [NativeName("GL_POINT_SIZE_MAX_SGIS")]
    PointSizeMaxSGIS = 33063,

    [NativeName("GL_POINT_FADE_THRESHOLD_SIZE_SGIS")]
    PointFadeThresholdSizeSGIS = 33064,

    [NativeName("GL_DISTANCE_ATTENUATION_SGIS")]
    DistanceAttenuationSGIS = 33065,
}
