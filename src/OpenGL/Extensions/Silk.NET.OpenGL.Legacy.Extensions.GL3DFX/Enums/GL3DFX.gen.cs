// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.GL3DFX
{
    [NativeName("Name", "GLenum")]
    public enum GL3DFX : int
    {
        [NativeName("Name", "GL_MULTISAMPLE_3DFX")]
        Multisample3Dfx = 0x86B2,
        [NativeName("Name", "GL_SAMPLE_BUFFERS_3DFX")]
        SampleBuffers3Dfx = 0x86B3,
        [NativeName("Name", "GL_SAMPLES_3DFX")]
        Samples3Dfx = 0x86B4,
        [NativeName("Name", "GL_MULTISAMPLE_BIT_3DFX")]
        MultisampleBit3Dfx = 0x20000000,
        [NativeName("Name", "GL_COMPRESSED_RGB_FXT1_3DFX")]
        CompressedRgbFxt13Dfx = 0x86B0,
        [NativeName("Name", "GL_COMPRESSED_RGBA_FXT1_3DFX")]
        CompressedRgbaFxt13Dfx = 0x86B1,
    }
}
