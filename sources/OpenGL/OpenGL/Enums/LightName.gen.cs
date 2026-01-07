// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("LightName")]
public enum LightName : uint
{
    [NativeName("GL_LIGHT0")]
    Light0 = 16384,

    [NativeName("GL_LIGHT1")]
    Light1 = 16385,

    [NativeName("GL_LIGHT2")]
    Light2 = 16386,

    [NativeName("GL_LIGHT3")]
    Light3 = 16387,

    [NativeName("GL_LIGHT4")]
    Light4 = 16388,

    [NativeName("GL_LIGHT5")]
    Light5 = 16389,

    [NativeName("GL_LIGHT6")]
    Light6 = 16390,

    [NativeName("GL_LIGHT7")]
    Light7 = 16391,

    [NativeName("GL_FRAGMENT_LIGHT0_SGIX")]
    FragmentLight0SGIX = 33804,

    [NativeName("GL_FRAGMENT_LIGHT1_SGIX")]
    FragmentLight1SGIX = 33805,

    [NativeName("GL_FRAGMENT_LIGHT2_SGIX")]
    FragmentLight2SGIX = 33806,

    [NativeName("GL_FRAGMENT_LIGHT3_SGIX")]
    FragmentLight3SGIX = 33807,

    [NativeName("GL_FRAGMENT_LIGHT4_SGIX")]
    FragmentLight4SGIX = 33808,

    [NativeName("GL_FRAGMENT_LIGHT5_SGIX")]
    FragmentLight5SGIX = 33809,

    [NativeName("GL_FRAGMENT_LIGHT6_SGIX")]
    FragmentLight6SGIX = 33810,

    [NativeName("GL_FRAGMENT_LIGHT7_SGIX")]
    FragmentLight7SGIX = 33811,
}
