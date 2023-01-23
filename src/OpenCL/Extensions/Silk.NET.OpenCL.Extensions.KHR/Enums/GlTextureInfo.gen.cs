// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [NativeName("Name", "cl_gl_texture_info")]
    public enum GlTextureInfo : int
    {
        [NativeName("Name", "CL_GL_NUM_SAMPLES")]
        NumSamples = 0x2012,
        [NativeName("Name", "CL_GL_TEXTURE_TARGET")]
        TextureTarget = 0x2004,
        [NativeName("Name", "CL_GL_MIPMAP_LEVEL")]
        MipmapLevel = 0x2005,
    }
}
