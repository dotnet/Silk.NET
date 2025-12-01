// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("FragmentLightParameterSGIX")]
public enum FragmentLightParameterSGIX : uint
{
    [NativeName("GL_AMBIENT")]
    Ambient = unchecked((uint)0x1200),

    [NativeName("GL_DIFFUSE")]
    Diffuse = unchecked((uint)0x1201),

    [NativeName("GL_SPECULAR")]
    Specular = unchecked((uint)0x1202),

    [NativeName("GL_POSITION")]
    Position = unchecked((uint)0x1203),

    [NativeName("GL_SPOT_DIRECTION")]
    SpotDirection = unchecked((uint)0x1204),

    [NativeName("GL_SPOT_EXPONENT")]
    SpotExponent = unchecked((uint)0x1205),

    [NativeName("GL_SPOT_CUTOFF")]
    SpotCutoff = unchecked((uint)0x1206),

    [NativeName("GL_CONSTANT_ATTENUATION")]
    ConstantAttenuation = unchecked((uint)0x1207),

    [NativeName("GL_LINEAR_ATTENUATION")]
    LinearAttenuation = unchecked((uint)0x1208),

    [NativeName("GL_QUADRATIC_ATTENUATION")]
    QuadraticAttenuation = unchecked((uint)0x1209),
}
