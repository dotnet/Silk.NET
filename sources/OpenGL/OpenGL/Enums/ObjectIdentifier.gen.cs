// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ObjectIdentifier")]
public enum ObjectIdentifier : uint
{
    [NativeName("GL_VERTEX_ARRAY")]
    VertexArray = unchecked((uint)0x8074),

    [NativeName("GL_TEXTURE")]
    Texture = unchecked((uint)0x1702),

    [NativeName("GL_FRAMEBUFFER")]
    Framebuffer = unchecked((uint)0x8D40),

    [NativeName("GL_RENDERBUFFER")]
    Renderbuffer = unchecked((uint)0x8D41),

    [NativeName("GL_TRANSFORM_FEEDBACK")]
    TransformFeedback = unchecked((uint)0x8E22),

    [NativeName("GL_BUFFER")]
    Buffer = unchecked((uint)0x82E0),

    [NativeName("GL_SHADER")]
    Shader = unchecked((uint)0x82E1),

    [NativeName("GL_PROGRAM")]
    Program = unchecked((uint)0x82E2),

    [NativeName("GL_QUERY")]
    Query = unchecked((uint)0x82E3),

    [NativeName("GL_PROGRAM_PIPELINE")]
    ProgramPipeline = unchecked((uint)0x82E4),

    [NativeName("GL_SAMPLER")]
    Sampler = unchecked((uint)0x82E6),
}
