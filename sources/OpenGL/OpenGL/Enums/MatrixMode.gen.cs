// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("MatrixMode")]
public enum MatrixMode : uint
{
    [NativeName("GL_MODELVIEW")]
    Modelview = 5888,

    [NativeName("GL_PROJECTION")]
    Projection = 5889,

    [NativeName("GL_TEXTURE")]
    Texture = 5890,

    [NativeName("GL_MODELVIEW0_EXT")]
    Modelview0EXT = 5888,
}
