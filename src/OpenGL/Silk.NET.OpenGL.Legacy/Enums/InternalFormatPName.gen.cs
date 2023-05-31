// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "InternalFormatPName")]
    public enum InternalFormatPName : int
    {
        [NativeName("Name", "GL_SAMPLES")]
        Samples = 0x80A9,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_GENERATE_MIPMAP")]
        GenerateMipmap = 0x8191,
        [NativeName("Name", "GL_INTERNALFORMAT_SUPPORTED")]
        InternalformatSupported = 0x826F,
        [NativeName("Name", "GL_INTERNALFORMAT_PREFERRED")]
        InternalformatPreferred = 0x8270,
        [NativeName("Name", "GL_INTERNALFORMAT_RED_SIZE")]
        InternalformatRedSize = 0x8271,
        [NativeName("Name", "GL_INTERNALFORMAT_GREEN_SIZE")]
        InternalformatGreenSize = 0x8272,
        [NativeName("Name", "GL_INTERNALFORMAT_BLUE_SIZE")]
        InternalformatBlueSize = 0x8273,
        [NativeName("Name", "GL_INTERNALFORMAT_ALPHA_SIZE")]
        InternalformatAlphaSize = 0x8274,
        [NativeName("Name", "GL_INTERNALFORMAT_DEPTH_SIZE")]
        InternalformatDepthSize = 0x8275,
        [NativeName("Name", "GL_INTERNALFORMAT_STENCIL_SIZE")]
        InternalformatStencilSize = 0x8276,
        [NativeName("Name", "GL_INTERNALFORMAT_SHARED_SIZE")]
        InternalformatSharedSize = 0x8277,
        [NativeName("Name", "GL_INTERNALFORMAT_RED_TYPE")]
        InternalformatRedType = 0x8278,
        [NativeName("Name", "GL_INTERNALFORMAT_GREEN_TYPE")]
        InternalformatGreenType = 0x8279,
        [NativeName("Name", "GL_INTERNALFORMAT_BLUE_TYPE")]
        InternalformatBlueType = 0x827A,
        [NativeName("Name", "GL_INTERNALFORMAT_ALPHA_TYPE")]
        InternalformatAlphaType = 0x827B,
        [NativeName("Name", "GL_INTERNALFORMAT_DEPTH_TYPE")]
        InternalformatDepthType = 0x827C,
        [NativeName("Name", "GL_INTERNALFORMAT_STENCIL_TYPE")]
        InternalformatStencilType = 0x827D,
        [NativeName("Name", "GL_MAX_WIDTH")]
        MaxWidth = 0x827E,
        [NativeName("Name", "GL_MAX_HEIGHT")]
        MaxHeight = 0x827F,
        [NativeName("Name", "GL_MAX_DEPTH")]
        MaxDepth = 0x8280,
        [NativeName("Name", "GL_MAX_LAYERS")]
        MaxLayers = 0x8281,
        [NativeName("Name", "GL_COLOR_COMPONENTS")]
        ColorComponents = 0x8283,
        [NativeName("Name", "GL_COLOR_RENDERABLE")]
        ColorRenderable = 0x8286,
        [NativeName("Name", "GL_DEPTH_RENDERABLE")]
        DepthRenderable = 0x8287,
        [NativeName("Name", "GL_STENCIL_RENDERABLE")]
        StencilRenderable = 0x8288,
        [NativeName("Name", "GL_FRAMEBUFFER_RENDERABLE")]
        FramebufferRenderable = 0x8289,
        [NativeName("Name", "GL_FRAMEBUFFER_RENDERABLE_LAYERED")]
        FramebufferRenderableLayered = 0x828A,
        [NativeName("Name", "GL_FRAMEBUFFER_BLEND")]
        FramebufferBlend = 0x828B,
        [NativeName("Name", "GL_READ_PIXELS")]
        ReadPixels = 0x828C,
        [NativeName("Name", "GL_READ_PIXELS_FORMAT")]
        ReadPixelsFormat = 0x828D,
        [NativeName("Name", "GL_READ_PIXELS_TYPE")]
        ReadPixelsType = 0x828E,
        [NativeName("Name", "GL_TEXTURE_IMAGE_FORMAT")]
        TextureImageFormat = 0x828F,
        [NativeName("Name", "GL_TEXTURE_IMAGE_TYPE")]
        TextureImageType = 0x8290,
        [NativeName("Name", "GL_GET_TEXTURE_IMAGE_FORMAT")]
        GetTextureImageFormat = 0x8291,
        [NativeName("Name", "GL_GET_TEXTURE_IMAGE_TYPE")]
        GetTextureImageType = 0x8292,
        [NativeName("Name", "GL_MIPMAP")]
        Mipmap = 0x8293,
        [NativeName("Name", "GL_AUTO_GENERATE_MIPMAP")]
        AutoGenerateMipmap = 0x8295,
        [NativeName("Name", "GL_COLOR_ENCODING")]
        ColorEncoding = 0x8296,
        [NativeName("Name", "GL_SRGB_READ")]
        SrgbRead = 0x8297,
        [NativeName("Name", "GL_SRGB_WRITE")]
        SrgbWrite = 0x8298,
        [NativeName("Name", "GL_FILTER")]
        Filter = 0x829A,
        [NativeName("Name", "GL_VERTEX_TEXTURE")]
        VertexTexture = 0x829B,
        [NativeName("Name", "GL_TESS_CONTROL_TEXTURE")]
        TessControlTexture = 0x829C,
        [NativeName("Name", "GL_TESS_EVALUATION_TEXTURE")]
        TessEvaluationTexture = 0x829D,
        [NativeName("Name", "GL_GEOMETRY_TEXTURE")]
        GeometryTexture = 0x829E,
        [NativeName("Name", "GL_FRAGMENT_TEXTURE")]
        FragmentTexture = 0x829F,
        [NativeName("Name", "GL_COMPUTE_TEXTURE")]
        ComputeTexture = 0x82A0,
        [NativeName("Name", "GL_TEXTURE_SHADOW")]
        TextureShadow = 0x82A1,
        [NativeName("Name", "GL_TEXTURE_GATHER")]
        TextureGather = 0x82A2,
        [NativeName("Name", "GL_TEXTURE_GATHER_SHADOW")]
        TextureGatherShadow = 0x82A3,
        [NativeName("Name", "GL_SHADER_IMAGE_LOAD")]
        ShaderImageLoad = 0x82A4,
        [NativeName("Name", "GL_SHADER_IMAGE_STORE")]
        ShaderImageStore = 0x82A5,
        [NativeName("Name", "GL_SHADER_IMAGE_ATOMIC")]
        ShaderImageAtomic = 0x82A6,
        [NativeName("Name", "GL_IMAGE_TEXEL_SIZE")]
        ImageTexelSize = 0x82A7,
        [NativeName("Name", "GL_IMAGE_COMPATIBILITY_CLASS")]
        ImageCompatibilityClass = 0x82A8,
        [NativeName("Name", "GL_IMAGE_PIXEL_FORMAT")]
        ImagePixelFormat = 0x82A9,
        [NativeName("Name", "GL_IMAGE_PIXEL_TYPE")]
        ImagePixelType = 0x82AA,
        [NativeName("Name", "GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST")]
        SimultaneousTextureAndDepthTest = 0x82AC,
        [NativeName("Name", "GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST")]
        SimultaneousTextureAndStencilTest = 0x82AD,
        [NativeName("Name", "GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE")]
        SimultaneousTextureAndDepthWrite = 0x82AE,
        [NativeName("Name", "GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE")]
        SimultaneousTextureAndStencilWrite = 0x82AF,
        [NativeName("Name", "GL_TEXTURE_COMPRESSED_BLOCK_WIDTH")]
        TextureCompressedBlockWidth = 0x82B1,
        [NativeName("Name", "GL_TEXTURE_COMPRESSED_BLOCK_HEIGHT")]
        TextureCompressedBlockHeight = 0x82B2,
        [NativeName("Name", "GL_TEXTURE_COMPRESSED_BLOCK_SIZE")]
        TextureCompressedBlockSize = 0x82B3,
        [NativeName("Name", "GL_CLEAR_BUFFER")]
        ClearBuffer = 0x82B4,
        [NativeName("Name", "GL_TEXTURE_VIEW")]
        TextureView = 0x82B5,
        [NativeName("Name", "GL_VIEW_COMPATIBILITY_CLASS")]
        ViewCompatibilityClass = 0x82B6,
        [NativeName("Name", "GL_TEXTURE_COMPRESSED")]
        TextureCompressed = 0x86A1,
        [NativeName("Name", "GL_NUM_SURFACE_COMPRESSION_FIXED_RATES_EXT")]
        NumSurfaceCompressionFixedRatesExt = 0x8F6E,
        [NativeName("Name", "GL_IMAGE_FORMAT_COMPATIBILITY_TYPE")]
        ImageFormatCompatibilityType = 0x90C7,
        [NativeName("Name", "GL_CLEAR_TEXTURE")]
        ClearTexture = 0x9365,
        [NativeName("Name", "GL_NUM_SAMPLE_COUNTS")]
        NumSampleCounts = 0x9380,
    }
}
