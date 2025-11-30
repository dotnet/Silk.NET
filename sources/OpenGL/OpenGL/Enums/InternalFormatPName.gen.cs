// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("InternalFormatPName")]
[Transformed]
public enum InternalFormatPName : uint
{
    [NativeName("GL_SAMPLES")]
    Samples = unchecked((uint)0x80A9),

    [NativeName("GL_GENERATE_MIPMAP")]
    GenerateMipmap = unchecked((uint)0x8191),

    [NativeName("GL_TEXTURE_COMPRESSED")]
    TextureCompressed = unchecked((uint)0x86A1),

    [NativeName("GL_NUM_SAMPLE_COUNTS")]
    NumSampleCounts = unchecked((uint)0x9380),

    [NativeName("GL_IMAGE_FORMAT_COMPATIBILITY_TYPE")]
    ImageFormatCompatibilityType = unchecked((uint)0x90C7),

    [NativeName("GL_INTERNALFORMAT_SUPPORTED")]
    InternalformatSupported = unchecked((uint)0x826F),

    [NativeName("GL_INTERNALFORMAT_PREFERRED")]
    InternalformatPreferred = unchecked((uint)0x8270),

    [NativeName("GL_INTERNALFORMAT_RED_SIZE")]
    InternalformatRedSize = unchecked((uint)0x8271),

    [NativeName("GL_INTERNALFORMAT_GREEN_SIZE")]
    InternalformatGreenSize = unchecked((uint)0x8272),

    [NativeName("GL_INTERNALFORMAT_BLUE_SIZE")]
    InternalformatBlueSize = unchecked((uint)0x8273),

    [NativeName("GL_INTERNALFORMAT_ALPHA_SIZE")]
    InternalformatAlphaSize = unchecked((uint)0x8274),

    [NativeName("GL_INTERNALFORMAT_DEPTH_SIZE")]
    InternalformatDepthSize = unchecked((uint)0x8275),

    [NativeName("GL_INTERNALFORMAT_STENCIL_SIZE")]
    InternalformatStencilSize = unchecked((uint)0x8276),

    [NativeName("GL_INTERNALFORMAT_SHARED_SIZE")]
    InternalformatSharedSize = unchecked((uint)0x8277),

    [NativeName("GL_INTERNALFORMAT_RED_TYPE")]
    InternalformatRedType = unchecked((uint)0x8278),

    [NativeName("GL_INTERNALFORMAT_GREEN_TYPE")]
    InternalformatGreenType = unchecked((uint)0x8279),

    [NativeName("GL_INTERNALFORMAT_BLUE_TYPE")]
    InternalformatBlueType = unchecked((uint)0x827A),

    [NativeName("GL_INTERNALFORMAT_ALPHA_TYPE")]
    InternalformatAlphaType = unchecked((uint)0x827B),

    [NativeName("GL_INTERNALFORMAT_DEPTH_TYPE")]
    InternalformatDepthType = unchecked((uint)0x827C),

    [NativeName("GL_INTERNALFORMAT_STENCIL_TYPE")]
    InternalformatStencilType = unchecked((uint)0x827D),

    [NativeName("GL_MAX_WIDTH")]
    MaxWidth = unchecked((uint)0x827E),

    [NativeName("GL_MAX_HEIGHT")]
    MaxHeight = unchecked((uint)0x827F),

    [NativeName("GL_MAX_DEPTH")]
    MaxDepth = unchecked((uint)0x8280),

    [NativeName("GL_MAX_LAYERS")]
    MaxLayers = unchecked((uint)0x8281),

    [NativeName("GL_COLOR_COMPONENTS")]
    ColorComponents = unchecked((uint)0x8283),

    [NativeName("GL_COLOR_RENDERABLE")]
    ColorRenderable = unchecked((uint)0x8286),

    [NativeName("GL_DEPTH_RENDERABLE")]
    DepthRenderable = unchecked((uint)0x8287),

    [NativeName("GL_STENCIL_RENDERABLE")]
    StencilRenderable = unchecked((uint)0x8288),

    [NativeName("GL_FRAMEBUFFER_RENDERABLE")]
    FramebufferRenderable = unchecked((uint)0x8289),

    [NativeName("GL_FRAMEBUFFER_RENDERABLE_LAYERED")]
    FramebufferRenderableLayered = unchecked((uint)0x828A),

    [NativeName("GL_FRAMEBUFFER_BLEND")]
    FramebufferBlend = unchecked((uint)0x828B),

    [NativeName("GL_READ_PIXELS")]
    ReadPixels = unchecked((uint)0x828C),

    [NativeName("GL_READ_PIXELS_FORMAT")]
    ReadPixelsFormat = unchecked((uint)0x828D),

    [NativeName("GL_READ_PIXELS_TYPE")]
    ReadPixelsType = unchecked((uint)0x828E),

    [NativeName("GL_TEXTURE_IMAGE_FORMAT")]
    TextureImageFormat = unchecked((uint)0x828F),

    [NativeName("GL_TEXTURE_IMAGE_TYPE")]
    TextureImageType = unchecked((uint)0x8290),

    [NativeName("GL_GET_TEXTURE_IMAGE_FORMAT")]
    GetTextureImageFormat = unchecked((uint)0x8291),

    [NativeName("GL_GET_TEXTURE_IMAGE_TYPE")]
    GetTextureImageType = unchecked((uint)0x8292),

    [NativeName("GL_MIPMAP")]
    Mipmap = unchecked((uint)0x8293),

    [NativeName("GL_AUTO_GENERATE_MIPMAP")]
    AutoGenerateMipmap = unchecked((uint)0x8295),

    [NativeName("GL_COLOR_ENCODING")]
    ColorEncoding = unchecked((uint)0x8296),

    [NativeName("GL_SRGB_READ")]
    SrgbRead = unchecked((uint)0x8297),

    [NativeName("GL_SRGB_WRITE")]
    SrgbWrite = unchecked((uint)0x8298),

    [NativeName("GL_FILTER")]
    Filter = unchecked((uint)0x829A),

    [NativeName("GL_VERTEX_TEXTURE")]
    VertexTexture = unchecked((uint)0x829B),

    [NativeName("GL_TESS_CONTROL_TEXTURE")]
    TessControlTexture = unchecked((uint)0x829C),

    [NativeName("GL_TESS_EVALUATION_TEXTURE")]
    TessEvaluationTexture = unchecked((uint)0x829D),

    [NativeName("GL_GEOMETRY_TEXTURE")]
    GeometryTexture = unchecked((uint)0x829E),

    [NativeName("GL_FRAGMENT_TEXTURE")]
    FragmentTexture = unchecked((uint)0x829F),

    [NativeName("GL_COMPUTE_TEXTURE")]
    ComputeTexture = unchecked((uint)0x82A0),

    [NativeName("GL_TEXTURE_SHADOW")]
    TextureShadow = unchecked((uint)0x82A1),

    [NativeName("GL_TEXTURE_GATHER")]
    TextureGather = unchecked((uint)0x82A2),

    [NativeName("GL_TEXTURE_GATHER_SHADOW")]
    TextureGatherShadow = unchecked((uint)0x82A3),

    [NativeName("GL_SHADER_IMAGE_LOAD")]
    ShaderImageLoad = unchecked((uint)0x82A4),

    [NativeName("GL_SHADER_IMAGE_STORE")]
    ShaderImageStore = unchecked((uint)0x82A5),

    [NativeName("GL_SHADER_IMAGE_ATOMIC")]
    ShaderImageAtomic = unchecked((uint)0x82A6),

    [NativeName("GL_IMAGE_TEXEL_SIZE")]
    ImageTexelSize = unchecked((uint)0x82A7),

    [NativeName("GL_IMAGE_COMPATIBILITY_CLASS")]
    ImageCompatibilityClass = unchecked((uint)0x82A8),

    [NativeName("GL_IMAGE_PIXEL_FORMAT")]
    ImagePixelFormat = unchecked((uint)0x82A9),

    [NativeName("GL_IMAGE_PIXEL_TYPE")]
    ImagePixelType = unchecked((uint)0x82AA),

    [NativeName("GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST")]
    SimultaneousTextureAndDepthTest = unchecked((uint)0x82AC),

    [NativeName("GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST")]
    SimultaneousTextureAndStencilTest = unchecked((uint)0x82AD),

    [NativeName("GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE")]
    SimultaneousTextureAndDepthWrite = unchecked((uint)0x82AE),

    [NativeName("GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE")]
    SimultaneousTextureAndStencilWrite = unchecked((uint)0x82AF),

    [NativeName("GL_TEXTURE_COMPRESSED_BLOCK_WIDTH")]
    TextureCompressedBlockWidth = unchecked((uint)0x82B1),

    [NativeName("GL_TEXTURE_COMPRESSED_BLOCK_HEIGHT")]
    TextureCompressedBlockHeight = unchecked((uint)0x82B2),

    [NativeName("GL_TEXTURE_COMPRESSED_BLOCK_SIZE")]
    TextureCompressedBlockSize = unchecked((uint)0x82B3),

    [NativeName("GL_CLEAR_BUFFER")]
    ClearBuffer = unchecked((uint)0x82B4),

    [NativeName("GL_TEXTURE_VIEW")]
    TextureView = unchecked((uint)0x82B5),

    [NativeName("GL_VIEW_COMPATIBILITY_CLASS")]
    ViewCompatibilityClass = unchecked((uint)0x82B6),

    [NativeName("GL_CLEAR_TEXTURE")]
    ClearTexture = unchecked((uint)0x9365),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_NUM_SURFACE_COMPRESSION_FIXED_RATES_EXT")]
    NumSurfaceCompressionFixedRatesEXT = unchecked((uint)0x8F6E),
}
