// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("LightModelColorControl")]
[Transformed]
public enum LightModelColorControl : uint
{
    [NativeName("GL_SINGLE_COLOR")]
    SingleColor = unchecked((uint)0x81F9),

    [NativeName("GL_SEPARATE_SPECULAR_COLOR")]
    SeparateSpecularColor = unchecked((uint)0x81FA),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SINGLE_COLOR_EXT")]
    SingleColorEXT = unchecked((uint)0x81F9),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SEPARATE_SPECULAR_COLOR_EXT")]
    SeparateSpecularColorEXT = unchecked((uint)0x81FA),
}
