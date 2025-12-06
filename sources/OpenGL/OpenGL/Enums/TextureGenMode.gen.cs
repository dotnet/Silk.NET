// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("TextureGenMode")]
public enum TextureGenMode : uint
{
    [NativeName("GL_EYE_LINEAR")]
    EyeLinear = 9216,

    [NativeName("GL_OBJECT_LINEAR")]
    ObjectLinear = 9217,

    [NativeName("GL_SPHERE_MAP")]
    SphereMap = 9218,

    [NativeName("GL_EYE_DISTANCE_TO_POINT_SGIS")]
    EyeDistanceToPointSGIS = 33264,

    [NativeName("GL_OBJECT_DISTANCE_TO_POINT_SGIS")]
    ObjectDistanceToPointSGIS = 33265,

    [NativeName("GL_EYE_DISTANCE_TO_LINE_SGIS")]
    EyeDistanceToLineSGIS = 33266,

    [NativeName("GL_OBJECT_DISTANCE_TO_LINE_SGIS")]
    ObjectDistanceToLineSGIS = 33267,
}
