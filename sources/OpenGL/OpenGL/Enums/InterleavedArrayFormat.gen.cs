// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("InterleavedArrayFormat")]
public enum InterleavedArrayFormat : uint
{
    [NativeName("GL_V2F")]
    V2F = 10784,

    [NativeName("GL_V3F")]
    V3F = 10785,

    [NativeName("GL_C4UB_V2F")]
    C4UbV2F = 10786,

    [NativeName("GL_C4UB_V3F")]
    C4UbV3F = 10787,

    [NativeName("GL_C3F_V3F")]
    C3FV3F = 10788,

    [NativeName("GL_N3F_V3F")]
    N3FV3F = 10789,

    [NativeName("GL_C4F_N3F_V3F")]
    C4FN3FV3F = 10790,

    [NativeName("GL_T2F_V3F")]
    T2FV3F = 10791,

    [NativeName("GL_T4F_V4F")]
    T4FV4F = 10792,

    [NativeName("GL_T2F_C4UB_V3F")]
    T2FC4UbV3F = 10793,

    [NativeName("GL_T2F_C3F_V3F")]
    T2FC3FV3F = 10794,

    [NativeName("GL_T2F_N3F_V3F")]
    T2FN3FV3F = 10795,

    [NativeName("GL_T2F_C4F_N3F_V3F")]
    T2FC4FN3FV3F = 10796,

    [NativeName("GL_T4F_C4F_N3F_V4F")]
    T4FC4FN3FV4F = 10797,
}
