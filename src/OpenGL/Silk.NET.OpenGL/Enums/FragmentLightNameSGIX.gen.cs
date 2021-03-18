// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "FragmentLightNameSGIX")]
    public enum FragmentLightNameSGIX : int
    {
        [NativeName("Name", "GL_FRAGMENT_LIGHT0_SGIX")]
        FragmentLight0Sgix = 0x840C,
        [NativeName("Name", "GL_FRAGMENT_LIGHT1_SGIX")]
        FragmentLight1Sgix = 0x840D,
        [NativeName("Name", "GL_FRAGMENT_LIGHT2_SGIX")]
        FragmentLight2Sgix = 0x840E,
        [NativeName("Name", "GL_FRAGMENT_LIGHT3_SGIX")]
        FragmentLight3Sgix = 0x840F,
        [NativeName("Name", "GL_FRAGMENT_LIGHT4_SGIX")]
        FragmentLight4Sgix = 0x8410,
        [NativeName("Name", "GL_FRAGMENT_LIGHT5_SGIX")]
        FragmentLight5Sgix = 0x8411,
        [NativeName("Name", "GL_FRAGMENT_LIGHT6_SGIX")]
        FragmentLight6Sgix = 0x8412,
        [NativeName("Name", "GL_FRAGMENT_LIGHT7_SGIX")]
        FragmentLight7Sgix = 0x8413,
    }
}
