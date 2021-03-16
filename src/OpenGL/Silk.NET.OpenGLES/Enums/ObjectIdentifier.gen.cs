// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "ObjectIdentifier")]
    public enum ObjectIdentifier : int
    {
        [NativeName("Name", "GL_TEXTURE")]
        Texture = 0x1702,
        [NativeName("Name", "GL_VERTEX_ARRAY")]
        VertexArray = 0x8074,
        [NativeName("Name", "GL_BUFFER")]
        Buffer = 0x82E0,
        [NativeName("Name", "GL_SHADER")]
        Shader = 0x82E1,
        [NativeName("Name", "GL_PROGRAM")]
        Program = 0x82E2,
        [NativeName("Name", "GL_QUERY")]
        Query = 0x82E3,
        [NativeName("Name", "GL_PROGRAM_PIPELINE")]
        ProgramPipeline = 0x82E4,
        [NativeName("Name", "GL_SAMPLER")]
        Sampler = 0x82E6,
        [NativeName("Name", "GL_FRAMEBUFFER")]
        Framebuffer = 0x8D40,
        [NativeName("Name", "GL_RENDERBUFFER")]
        Renderbuffer = 0x8D41,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK")]
        TransformFeedback = 0x8E22,
    }
}
