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
    Light0 = unchecked((uint)0x4000),

    [NativeName("GL_LIGHT1")]
    Light1 = unchecked((uint)0x4001),

    [NativeName("GL_LIGHT2")]
    Light2 = unchecked((uint)0x4002),

    [NativeName("GL_LIGHT3")]
    Light3 = unchecked((uint)0x4003),

    [NativeName("GL_LIGHT4")]
    Light4 = unchecked((uint)0x4004),

    [NativeName("GL_LIGHT5")]
    Light5 = unchecked((uint)0x4005),

    [NativeName("GL_LIGHT6")]
    Light6 = unchecked((uint)0x4006),

    [NativeName("GL_LIGHT7")]
    Light7 = unchecked((uint)0x4007),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_LIGHT0_SGIX")]
    FragmentLight0SGIX = unchecked((uint)0x840C),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_LIGHT1_SGIX")]
    FragmentLight1SGIX = unchecked((uint)0x840D),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_LIGHT2_SGIX")]
    FragmentLight2SGIX = unchecked((uint)0x840E),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_LIGHT3_SGIX")]
    FragmentLight3SGIX = unchecked((uint)0x840F),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_LIGHT4_SGIX")]
    FragmentLight4SGIX = unchecked((uint)0x8410),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_LIGHT5_SGIX")]
    FragmentLight5SGIX = unchecked((uint)0x8411),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_LIGHT6_SGIX")]
    FragmentLight6SGIX = unchecked((uint)0x8412),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_LIGHT7_SGIX")]
    FragmentLight7SGIX = unchecked((uint)0x8413),
}
