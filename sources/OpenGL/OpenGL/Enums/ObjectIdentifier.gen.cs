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
    VertexArray = 32884,

    [NativeName("GL_TEXTURE")]
    Texture = 5890,

    [NativeName("GL_FRAMEBUFFER")]
    Framebuffer = 36160,

    [NativeName("GL_RENDERBUFFER")]
    Renderbuffer = 36161,

    [NativeName("GL_TRANSFORM_FEEDBACK")]
    TransformFeedback = 36386,

    [NativeName("GL_BUFFER")]
    Buffer = 33504,

    [NativeName("GL_SHADER")]
    Shader = 33505,

    [NativeName("GL_PROGRAM")]
    Program = 33506,

    [NativeName("GL_QUERY")]
    Query = 33507,

    [NativeName("GL_PROGRAM_PIPELINE")]
    ProgramPipeline = 33508,

    [NativeName("GL_SAMPLER")]
    Sampler = 33510,
}
