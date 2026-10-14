// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("StencilOp")]
public enum StencilOp : uint
{
    [NativeName("GL_ZERO")]
    Zero = 0,

    [NativeName("GL_INVERT")]
    Invert = 5386,

    [NativeName("GL_KEEP")]
    Keep = 7680,

    [NativeName("GL_REPLACE")]
    Replace = 7681,

    [NativeName("GL_INCR")]
    Incr = 7682,

    [NativeName("GL_DECR")]
    Decr = 7683,

    [NativeName("GL_INCR_WRAP")]
    IncrWrap = 34055,

    [NativeName("GL_DECR_WRAP")]
    DecrWrap = 34056,
}
