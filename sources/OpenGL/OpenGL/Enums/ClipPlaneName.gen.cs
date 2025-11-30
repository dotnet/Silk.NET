// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ClipPlaneName")]
[Transformed]
public enum ClipPlaneName : uint
{
    [NativeName("GL_CLIP_PLANE0")]
    Plane0 = unchecked((uint)0x3000),

    [NativeName("GL_CLIP_PLANE1")]
    Plane1 = unchecked((uint)0x3001),

    [NativeName("GL_CLIP_PLANE2")]
    Plane2 = unchecked((uint)0x3002),

    [NativeName("GL_CLIP_PLANE3")]
    Plane3 = unchecked((uint)0x3003),

    [NativeName("GL_CLIP_PLANE4")]
    Plane4 = unchecked((uint)0x3004),

    [NativeName("GL_CLIP_PLANE5")]
    Plane5 = unchecked((uint)0x3005),

    [NativeName("GL_CLIP_DISTANCE0")]
    Distance0 = unchecked((uint)0x3000),

    [NativeName("GL_CLIP_DISTANCE1")]
    Distance1 = unchecked((uint)0x3001),

    [NativeName("GL_CLIP_DISTANCE2")]
    Distance2 = unchecked((uint)0x3002),

    [NativeName("GL_CLIP_DISTANCE3")]
    Distance3 = unchecked((uint)0x3003),

    [NativeName("GL_CLIP_DISTANCE4")]
    Distance4 = unchecked((uint)0x3004),

    [NativeName("GL_CLIP_DISTANCE5")]
    Distance5 = unchecked((uint)0x3005),

    [NativeName("GL_CLIP_DISTANCE6")]
    Distance6 = unchecked((uint)0x3006),

    [NativeName("GL_CLIP_DISTANCE7")]
    Distance7 = unchecked((uint)0x3007),
}
