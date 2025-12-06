// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum PointParameterName : uint
{
    PointFadeThresholdSize = unchecked((uint)0x8128),
    PointSizeMin = unchecked((uint)0x8126),
    PointSizeMax = unchecked((uint)0x8127),
    PointDistanceAttenuation = unchecked((uint)0x8129),
    PointSizeMinARB = unchecked((uint)0x8126),
    PointSizeMaxARB = unchecked((uint)0x8127),
    PointFadeThresholdSizeARB = unchecked((uint)0x8128),
    PointDistanceAttenuationARB = unchecked((uint)0x8129),
    PointSizeMinEXT = unchecked((uint)0x8126),
    PointSizeMaxEXT = unchecked((uint)0x8127),
    PointFadeThresholdSizeEXT = unchecked((uint)0x8128),
    DistanceAttenuationEXT = unchecked((uint)0x8129),
    PointSizeMinSGIS = unchecked((uint)0x8126),
    PointSizeMaxSGIS = unchecked((uint)0x8127),
    PointFadeThresholdSizeSGIS = unchecked((uint)0x8128),
    DistanceAttenuationSGIS = unchecked((uint)0x8129),
}
