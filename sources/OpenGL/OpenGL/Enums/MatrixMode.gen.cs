// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("MatrixMode")]
[Transformed]
public enum MatrixMode : uint
{
    [NativeName("GL_TEXTURE")]
    Texture = unchecked((uint)0x1702),

    [NativeName("GL_MODELVIEW")]
    Modelview = unchecked((uint)0x1700),

    [NativeName("GL_PROJECTION")]
    Projection = unchecked((uint)0x1701),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MODELVIEW0_EXT")]
    Modelview0Ext = unchecked((uint)0x1700),
}
