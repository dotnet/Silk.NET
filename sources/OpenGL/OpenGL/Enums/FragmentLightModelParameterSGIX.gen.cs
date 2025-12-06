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
    LocalViewer = 33800,

    [NativeName("GL_FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX")]
    TwoSide = 33801,

    [NativeName("GL_FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX")]
    Ambient = 33802,

    [NativeName("GL_FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX")]
    NormalInterpolation = 33803,
}
