// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("TextureSwizzle")]
[Transformed]
public enum TextureSwizzle : uint
{
    [NativeName("GL_ZERO")]
    Zero = unchecked((uint)0),

    [NativeName("GL_ONE")]
    One = unchecked((uint)1),

    [NativeName("GL_ALPHA")]
    Alpha = unchecked((uint)0x1906),

    [NativeName("GL_RED")]
    Red = unchecked((uint)0x1903),

    [NativeName("GL_GREEN")]
    Green = unchecked((uint)0x1904),

    [NativeName("GL_BLUE")]
    Blue = unchecked((uint)0x1905),
}
