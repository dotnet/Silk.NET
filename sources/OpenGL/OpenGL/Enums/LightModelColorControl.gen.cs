// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("LightModelColorControl")]
public enum LightModelColorControl : uint
{
    [NativeName("GL_SINGLE_COLOR")]
    SingleColor = 33273,

    [NativeName("GL_SEPARATE_SPECULAR_COLOR")]
    SeparateSpecularColor = 33274,

    [NativeName("GL_SINGLE_COLOR_EXT")]
    SingleColorEXT = 33273,

    [NativeName("GL_SEPARATE_SPECULAR_COLOR_EXT")]
    SeparateSpecularColorEXT = 33274,
}
