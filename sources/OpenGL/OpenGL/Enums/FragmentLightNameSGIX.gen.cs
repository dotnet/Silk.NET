// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("FragmentLightNameSGIX")]
public enum FragmentLightNameSGIX : uint
{
    [NativeName("GL_FRAGMENT_LIGHT0_SGIX")]
    Light0 = 33804,

    [NativeName("GL_FRAGMENT_LIGHT1_SGIX")]
    Light1 = 33805,

    [NativeName("GL_FRAGMENT_LIGHT2_SGIX")]
    Light2 = 33806,

    [NativeName("GL_FRAGMENT_LIGHT3_SGIX")]
    Light3 = 33807,

    [NativeName("GL_FRAGMENT_LIGHT4_SGIX")]
    Light4 = 33808,

    [NativeName("GL_FRAGMENT_LIGHT5_SGIX")]
    Light5 = 33809,

    [NativeName("GL_FRAGMENT_LIGHT6_SGIX")]
    Light6 = 33810,

    [NativeName("GL_FRAGMENT_LIGHT7_SGIX")]
    Light7 = 33811,
}
