// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("TextureCoordName")]
public enum TextureCoordName : uint
{
    [NativeName("GL_S")]
    S = 8192,

    [NativeName("GL_T")]
    T = 8193,

    [NativeName("GL_R")]
    R = 8194,

    [NativeName("GL_Q")]
    Q = 8195,

    [NativeName("GL_TEXTURE_GEN_STR_OES")]
    TextureGenStrOES = 36192,
}
