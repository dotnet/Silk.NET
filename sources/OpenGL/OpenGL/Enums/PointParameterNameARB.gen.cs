// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "ARB", 0)]
[NativeName("PointParameterNameARB")]
[Transformed]
public enum PointParameterNameARB : uint
{
    [NativeName("GL_POINT_SIZE_MIN")]
    PointSizeMin = unchecked((uint)0x8126),

    [NativeName("GL_POINT_SIZE_MAX")]
    PointSizeMax = unchecked((uint)0x8127),

    [NativeName("GL_POINT_FADE_THRESHOLD_SIZE")]
    PointFadeThresholdSize = unchecked((uint)0x8128),

    [NativeName("GL_POINT_DISTANCE_ATTENUATION")]
    PointDistanceAttenuation = unchecked((uint)0x8129),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_POINT_SIZE_MIN_ARB")]
    PointSizeMinARB = unchecked((uint)0x8126),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_POINT_SIZE_MAX_ARB")]
    PointSizeMaxARB = unchecked((uint)0x8127),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_POINT_FADE_THRESHOLD_SIZE_ARB")]
    PointFadeThresholdSizeARB = unchecked((uint)0x8128),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_POINT_DISTANCE_ATTENUATION_ARB")]
    PointDistanceAttenuationARB = unchecked((uint)0x8129),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_POINT_SIZE_MIN_EXT")]
    PointSizeMinEXT = unchecked((uint)0x8126),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_POINT_SIZE_MAX_EXT")]
    PointSizeMaxEXT = unchecked((uint)0x8127),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_POINT_FADE_THRESHOLD_SIZE_EXT")]
    PointFadeThresholdSizeEXT = unchecked((uint)0x8128),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DISTANCE_ATTENUATION_EXT")]
    DistanceAttenuationEXT = unchecked((uint)0x8129),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_POINT_SIZE_MIN_SGIS")]
    PointSizeMinSGIS = unchecked((uint)0x8126),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_POINT_SIZE_MAX_SGIS")]
    PointSizeMaxSGIS = unchecked((uint)0x8127),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_POINT_FADE_THRESHOLD_SIZE_SGIS")]
    PointFadeThresholdSizeSGIS = unchecked((uint)0x8128),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_DISTANCE_ATTENUATION_SGIS")]
    DistanceAttenuationSGIS = unchecked((uint)0x8129),
}
