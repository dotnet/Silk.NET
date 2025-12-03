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
    Light0 = unchecked((uint)0x840C),

    [NativeName("GL_FRAGMENT_LIGHT1_SGIX")]
    Light1 = unchecked((uint)0x840D),

    [NativeName("GL_FRAGMENT_LIGHT2_SGIX")]
    Light2 = unchecked((uint)0x840E),

    [NativeName("GL_FRAGMENT_LIGHT3_SGIX")]
    Light3 = unchecked((uint)0x840F),

    [NativeName("GL_FRAGMENT_LIGHT4_SGIX")]
    Light4 = unchecked((uint)0x8410),

    [NativeName("GL_FRAGMENT_LIGHT5_SGIX")]
    Light5 = unchecked((uint)0x8411),

    [NativeName("GL_FRAGMENT_LIGHT6_SGIX")]
    Light6 = unchecked((uint)0x8412),

    [NativeName("GL_FRAGMENT_LIGHT7_SGIX")]
    Light7 = unchecked((uint)0x8413),
}
