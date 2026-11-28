// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_gl_object_type")]
public enum GlObjectType : uint
{
    [NativeName("CL_GL_OBJECT_BUFFER")]
    Buffer = 8192,

    [NativeName("CL_GL_OBJECT_TEXTURE2D")]
    Texture2D = 8193,

    [NativeName("CL_GL_OBJECT_TEXTURE3D")]
    Texture3D = 8194,

    [NativeName("CL_GL_OBJECT_RENDERBUFFER")]
    Renderbuffer = 8195,

    [NativeName("CL_GL_OBJECT_TEXTURE2D_ARRAY")]
    Texture2DArray = 8206,

    [NativeName("CL_GL_OBJECT_TEXTURE1D")]
    Texture1D = 8207,

    [NativeName("CL_GL_OBJECT_TEXTURE1D_ARRAY")]
    Texture1DArray = 8208,

    [NativeName("CL_GL_OBJECT_TEXTURE_BUFFER")]
    TextureBuffer = 8209,
}
