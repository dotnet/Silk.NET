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
        Buffer = 0x2000,
        [NativeName("Name", "CL_GL_OBJECT_TEXTURE2D")]
        Texture2D = 0x2001,
        [NativeName("Name", "CL_GL_OBJECT_TEXTURE3D")]
        Texture3D = 0x2002,
        [NativeName("Name", "CL_GL_OBJECT_RENDERBUFFER")]
        Renderbuffer = 0x2003,
        [NativeName("Name", "CL_GL_OBJECT_TEXTURE2D_ARRAY")]
        Texture2DArray = 0x200E,
        [NativeName("Name", "CL_GL_OBJECT_TEXTURE1D")]
        Texture1D = 0x200F,
        [NativeName("Name", "CL_GL_OBJECT_TEXTURE1D_ARRAY")]
        Texture1DArray = 0x2010,
        [NativeName("Name", "CL_GL_OBJECT_TEXTURE_BUFFER")]
        TextureBuffer = 0x2011,
    }
}
