// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ClipPlaneName")]
public enum ClipPlaneName : uint
{
    [NativeName("GL_CLIP_PLANE0")]
    Plane0 = 12288,

    [NativeName("GL_CLIP_PLANE1")]
    Plane1 = 12289,

    [NativeName("GL_CLIP_PLANE2")]
    Plane2 = 12290,

    [NativeName("GL_CLIP_PLANE3")]
    Plane3 = 12291,

    [NativeName("GL_CLIP_PLANE4")]
    Plane4 = 12292,

    [NativeName("GL_CLIP_PLANE5")]
    Plane5 = 12293,

    [NativeName("GL_CLIP_DISTANCE0")]
    Distance0 = 12288,

    [NativeName("GL_CLIP_DISTANCE1")]
    Distance1 = 12289,

    [NativeName("GL_CLIP_DISTANCE2")]
    Distance2 = 12290,

    [NativeName("GL_CLIP_DISTANCE3")]
    Distance3 = 12291,

    [NativeName("GL_CLIP_DISTANCE4")]
    Distance4 = 12292,

    [NativeName("GL_CLIP_DISTANCE5")]
    Distance5 = 12293,

    [NativeName("GL_CLIP_DISTANCE6")]
    Distance6 = 12294,

    [NativeName("GL_CLIP_DISTANCE7")]
    Distance7 = 12295,
}
