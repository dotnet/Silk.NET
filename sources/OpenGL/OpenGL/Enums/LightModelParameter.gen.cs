// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("LightModelParameter")]
[Transformed]
public enum LightModelParameter : uint
{
    [NativeName("GL_LIGHT_MODEL_AMBIENT")]
    Ambient = unchecked((uint)0x0B53),

    [NativeName("GL_LIGHT_MODEL_TWO_SIDE")]
    TwoSide = unchecked((uint)0x0B52),

    [NativeName("GL_LIGHT_MODEL_LOCAL_VIEWER")]
    LocalViewer = unchecked((uint)0x0B51),

    [NativeName("GL_LIGHT_MODEL_COLOR_CONTROL")]
    ColorControl = unchecked((uint)0x81F8),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LIGHT_MODEL_COLOR_CONTROL_EXT")]
    ColorControlEXT = unchecked((uint)0x81F8),
}
