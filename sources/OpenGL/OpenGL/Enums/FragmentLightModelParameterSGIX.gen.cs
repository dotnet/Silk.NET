// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("FragmentLightModelParameterSGIX")]
public enum FragmentLightModelParameterSGIX : uint
{
    [NativeName("GL_FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX")]
    LocalViewer = unchecked((uint)0x8408),

    [NativeName("GL_FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX")]
    TwoSide = unchecked((uint)0x8409),

    [NativeName("GL_FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX")]
    Ambient = unchecked((uint)0x840A),

    [NativeName("GL_FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX")]
    NormalInterpolation = unchecked((uint)0x840B),
}
