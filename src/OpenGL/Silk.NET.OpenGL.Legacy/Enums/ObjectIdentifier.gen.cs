// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "ObjectIdentifier")]
    public enum ObjectIdentifier
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
