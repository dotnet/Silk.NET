// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [NativeName("Name", "cl_gl_object_type")]
    public enum GlObjectType : int
    {
        [NativeName("Name", "CL_GL_OBJECT_BUFFER")]
        GLObjectBuffer = 0x2000,
        [NativeName("Name", "CL_GL_OBJECT_TEXTURE2D")]
        GLObjectTexture2D = 0x2001,
        [NativeName("Name", "CL_GL_OBJECT_TEXTURE3D")]
        GLObjectTexture3D = 0x2002,
        [NativeName("Name", "CL_GL_OBJECT_RENDERBUFFER")]
        GLObjectRenderbuffer = 0x2003,
        [NativeName("Name", "CL_GL_OBJECT_TEXTURE2D_ARRAY")]
        GLObjectTexture2DArray = 0x200E,
        [NativeName("Name", "CL_GL_OBJECT_TEXTURE1D")]
        GLObjectTexture1D = 0x200F,
        [NativeName("Name", "CL_GL_OBJECT_TEXTURE1D_ARRAY")]
        GLObjectTexture1DArray = 0x2010,
        [NativeName("Name", "CL_GL_OBJECT_TEXTURE_BUFFER")]
        GLObjectTextureBuffer = 0x2011,
    }
}
