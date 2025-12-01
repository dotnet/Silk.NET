// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("MaterialParameter")]
public enum MaterialParameter : uint
{
    [NativeName("GL_AMBIENT")]
    Ambient = unchecked((uint)0x1200),

    [NativeName("GL_DIFFUSE")]
    Diffuse = unchecked((uint)0x1201),

    [NativeName("GL_SPECULAR")]
    Specular = unchecked((uint)0x1202),

    [NativeName("GL_EMISSION")]
    Emission = unchecked((uint)0x1600),

    [NativeName("GL_SHININESS")]
    Shininess = unchecked((uint)0x1601),

    [NativeName("GL_AMBIENT_AND_DIFFUSE")]
    AmbientAndDiffuse = unchecked((uint)0x1602),

    [NativeName("GL_COLOR_INDEXES")]
    ColorIndexes = unchecked((uint)0x1603),
}
