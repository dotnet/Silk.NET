// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("LightModelParameter")]
public enum LightModelParameter : uint
{
    [NativeName("GL_LIGHT_MODEL_LOCAL_VIEWER")]
    LocalViewer = 2897,

    [NativeName("GL_LIGHT_MODEL_TWO_SIDE")]
    TwoSide = 2898,

    [NativeName("GL_LIGHT_MODEL_AMBIENT")]
    Ambient = 2899,

    [NativeName("GL_LIGHT_MODEL_COLOR_CONTROL")]
    ColorControl = 33272,

    [NativeName("GL_LIGHT_MODEL_COLOR_CONTROL_EXT")]
    ColorControlEXT = 33272,
}
