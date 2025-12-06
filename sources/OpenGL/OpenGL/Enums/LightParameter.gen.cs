// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("LightParameter")]
public enum LightParameter : uint
{
    [NativeName("GL_AMBIENT")]
    Ambient = 4608,

    [NativeName("GL_DIFFUSE")]
    Diffuse = 4609,

    [NativeName("GL_SPECULAR")]
    Specular = 4610,

    [NativeName("GL_POSITION")]
    Position = 4611,

    [NativeName("GL_SPOT_DIRECTION")]
    SpotDirection = 4612,

    [NativeName("GL_SPOT_EXPONENT")]
    SpotExponent = 4613,

    [NativeName("GL_SPOT_CUTOFF")]
    SpotCutoff = 4614,

    [NativeName("GL_CONSTANT_ATTENUATION")]
    ConstantAttenuation = 4615,

    [NativeName("GL_LINEAR_ATTENUATION")]
    LinearAttenuation = 4616,

    [NativeName("GL_QUADRATIC_ATTENUATION")]
    QuadraticAttenuation = 4617,
}
