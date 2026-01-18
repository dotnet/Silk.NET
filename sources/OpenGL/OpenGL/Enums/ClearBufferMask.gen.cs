// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ClearBufferMask")]
[Flags]
public enum ClearBufferMask : uint
{
    None = 0x0,

    [NativeName("GL_DEPTH_BUFFER_BIT")]
    DepthBufferBit = 0x100,

    [NativeName("GL_STENCIL_BUFFER_BIT")]
    StencilBufferBit = 0x400,

    [NativeName("GL_COLOR_BUFFER_BIT")]
    ColorBufferBit = 0x4000,

    [NativeName("GL_ACCUM_BUFFER_BIT")]
    AccumBufferBit = 0x200,

    [NativeName("GL_COVERAGE_BUFFER_BIT_NV")]
    CoverageBufferBitNV = 0x8000,
}
