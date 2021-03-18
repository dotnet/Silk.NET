// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.IMG
{
    [NativeName("Name", "GLenum")]
    public enum IMG : int
    {
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_AND_DOWNSAMPLE_IMG")]
        FramebufferIncompleteMultisampleAndDownsampleImg = 0x913C,
        [NativeName("Name", "GL_NUM_DOWNSAMPLE_SCALES_IMG")]
        NumDownsampleScalesImg = 0x913D,
        [NativeName("Name", "GL_DOWNSAMPLE_SCALES_IMG")]
        DownsampleScalesImg = 0x913E,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SCALE_IMG")]
        FramebufferAttachmentTextureScaleImg = 0x913F,
        [NativeName("Name", "GL_RENDERBUFFER_SAMPLES_IMG")]
        RenderbufferSamplesImg = 0x9133,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_IMG")]
        FramebufferIncompleteMultisampleImg = 0x9134,
        [NativeName("Name", "GL_MAX_SAMPLES_IMG")]
        MaxSamplesImg = 0x9135,
        [NativeName("Name", "GL_TEXTURE_SAMPLES_IMG")]
        TextureSamplesImg = 0x9136,
        [NativeName("Name", "GL_SGX_PROGRAM_BINARY_IMG")]
        SgxProgramBinaryImg = 0x9130,
        [NativeName("Name", "GL_BGRA_IMG")]
        BgraImg = 0x80E1,
        [NativeName("Name", "GL_UNSIGNED_SHORT_4_4_4_4_REV_IMG")]
        UnsignedShort4444RevImg = 0x8365,
        [NativeName("Name", "GL_SGX_BINARY_IMG")]
        SgxBinaryImg = 0x8C0A,
        [NativeName("Name", "GL_COMPRESSED_RGB_PVRTC_4BPPV1_IMG")]
        CompressedRgbPvrtc4Bppv1Img = 0x8C00,
        [NativeName("Name", "GL_COMPRESSED_RGB_PVRTC_2BPPV1_IMG")]
        CompressedRgbPvrtc2Bppv1Img = 0x8C01,
        [NativeName("Name", "GL_COMPRESSED_RGBA_PVRTC_4BPPV1_IMG")]
        CompressedRgbaPvrtc4Bppv1Img = 0x8C02,
        [NativeName("Name", "GL_COMPRESSED_RGBA_PVRTC_2BPPV1_IMG")]
        CompressedRgbaPvrtc2Bppv1Img = 0x8C03,
        [NativeName("Name", "GL_COMPRESSED_RGBA_PVRTC_2BPPV2_IMG")]
        CompressedRgbaPvrtc2Bppv2Img = 0x9137,
        [NativeName("Name", "GL_COMPRESSED_RGBA_PVRTC_4BPPV2_IMG")]
        CompressedRgbaPvrtc4Bppv2Img = 0x9138,
        [NativeName("Name", "GL_CUBIC_IMG")]
        CubicImg = 0x9139,
        [NativeName("Name", "GL_CUBIC_MIPMAP_NEAREST_IMG")]
        CubicMipmapNearestImg = 0x913A,
        [NativeName("Name", "GL_CUBIC_MIPMAP_LINEAR_IMG")]
        CubicMipmapLinearImg = 0x913B,
    }
}
