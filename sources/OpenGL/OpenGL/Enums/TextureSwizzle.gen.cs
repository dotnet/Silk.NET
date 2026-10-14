// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("TextureSwizzle")]
public enum TextureSwizzle : uint
{
    [NativeName("GL_ZERO")]
    Zero = 0,

    [NativeName("GL_ONE")]
    One = 1,

    [NativeName("GL_RED")]
    Red = 6403,

    [NativeName("GL_GREEN")]
    Green = 6404,

    [NativeName("GL_BLUE")]
    Blue = 6405,

    [NativeName("GL_ALPHA")]
    Alpha = 6406,
}
