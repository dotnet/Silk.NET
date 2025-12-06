// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("BufferUsageARB")]
public enum BufferUsage : uint
{
    [NativeName("GL_STATIC_DRAW")]
    StaticDraw = 35044,

    [NativeName("GL_DYNAMIC_DRAW")]
    DynamicDraw = 35048,

    [NativeName("GL_STREAM_DRAW")]
    StreamDraw = 35040,

    [NativeName("GL_STREAM_READ")]
    StreamRead = 35041,

    [NativeName("GL_STREAM_COPY")]
    StreamCopy = 35042,

    [NativeName("GL_STATIC_READ")]
    StaticRead = 35045,

    [NativeName("GL_STATIC_COPY")]
    StaticCopy = 35046,

    [NativeName("GL_DYNAMIC_READ")]
    DynamicRead = 35049,

    [NativeName("GL_DYNAMIC_COPY")]
    DynamicCopy = 35050,
}
