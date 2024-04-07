// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum ObjectIdentifier : uint
{
    Texture = 0x1702,
    VertexArray = 0x8074,
    Framebuffer = 0x8D40,
    Renderbuffer = 0x8D41,
    TransformFeedback = 0x8E22,
    Buffer = 0x82E0,
    Shader = 0x82E1,
    Program = 0x82E2,
    Query = 0x82E3,
    ProgramPipeline = 0x82E4,
    Sampler = 0x82E6
}
