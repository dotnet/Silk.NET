// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum ObjectIdentifier : uint
{
    Texture = unchecked((uint)0x1702),
    VertexArray = unchecked((uint)0x8074),
    Framebuffer = unchecked((uint)0x8D40),
    Renderbuffer = unchecked((uint)0x8D41),
    TransformFeedback = unchecked((uint)0x8E22),
    Buffer = unchecked((uint)0x82E0),
    Shader = unchecked((uint)0x82E1),
    Program = unchecked((uint)0x82E2),
    Query = unchecked((uint)0x82E3),
    ProgramPipeline = unchecked((uint)0x82E4),
    Sampler = unchecked((uint)0x82E6),
}
