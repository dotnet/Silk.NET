// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.MESA
{
    [NativeName("Name", "GLenum")]
    public enum MESA : int
    {
        [NativeName("Name", "GL_BGR_EXT")]
        BgrExt = 0x80E0,
        [NativeName("Name", "GL_BGRA_EXT")]
        BgraExt = 0x80E1,
        [NativeName("Name", "GL_FRAMEBUFFER_FLIP_X_MESA")]
        FramebufferFlipXMesa = 0x8BBC,
        [NativeName("Name", "GL_FRAMEBUFFER_FLIP_Y_MESA")]
        FramebufferFlipYMesa = 0x8BBB,
        [NativeName("Name", "GL_FRAMEBUFFER_SWAP_XY_MESA")]
        FramebufferSwapXYMesa = 0x8BBD,
        [NativeName("Name", "GL_PROGRAM_BINARY_FORMAT_MESA")]
        ProgramBinaryFormatMesa = 0x875F,
        [NativeName("Name", "GL_SAMPLER_BINDING")]
        SamplerBinding = 0x8919,
    }
}
