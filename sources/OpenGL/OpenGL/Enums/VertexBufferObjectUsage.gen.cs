// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("VertexBufferObjectUsage")]
[Transformed]
public enum VertexBufferObjectUsage : uint
{
    [NativeName("GL_STREAM_DRAW")]
    StreamDraw = unchecked((uint)0x88E0),

    [NativeName("GL_STREAM_READ")]
    StreamRead = unchecked((uint)0x88E1),

    [NativeName("GL_STREAM_COPY")]
    StreamCopy = unchecked((uint)0x88E2),

    [NativeName("GL_STATIC_DRAW")]
    StaticDraw = unchecked((uint)0x88E4),

    [NativeName("GL_STATIC_READ")]
    StaticRead = unchecked((uint)0x88E5),

    [NativeName("GL_STATIC_COPY")]
    StaticCopy = unchecked((uint)0x88E6),

    [NativeName("GL_DYNAMIC_DRAW")]
    DynamicDraw = unchecked((uint)0x88E8),

    [NativeName("GL_DYNAMIC_READ")]
    DynamicRead = unchecked((uint)0x88E9),

    [NativeName("GL_DYNAMIC_COPY")]
    DynamicCopy = unchecked((uint)0x88EA),
}
