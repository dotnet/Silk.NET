// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("InternalFormatPName")]
public enum InternalFormatPName : uint
{
    [NativeName("GL_SAMPLES")]
    Samples = 32937,

    [NativeName("GL_GENERATE_MIPMAP")]
    GenerateMipmap = 33169,

    [NativeName("GL_TEXTURE_COMPRESSED")]
    TextureCompressed = 34465,

    [NativeName("GL_NUM_SAMPLE_COUNTS")]
    NumSampleCounts = 37760,

    [NativeName("GL_IMAGE_FORMAT_COMPATIBILITY_TYPE")]
    ImageFormatCompatibilityType = 37063,

    [NativeName("GL_INTERNALFORMAT_SUPPORTED")]
    InternalformatSupported = 33391,

    [NativeName("GL_INTERNALFORMAT_PREFERRED")]
    InternalformatPreferred = 33392,

    [NativeName("GL_INTERNALFORMAT_RED_SIZE")]
    InternalformatRedSize = 33393,

    [NativeName("GL_INTERNALFORMAT_GREEN_SIZE")]
    InternalformatGreenSize = 33394,

    [NativeName("GL_INTERNALFORMAT_BLUE_SIZE")]
    InternalformatBlueSize = 33395,

    [NativeName("GL_INTERNALFORMAT_ALPHA_SIZE")]
    InternalformatAlphaSize = 33396,

    [NativeName("GL_INTERNALFORMAT_DEPTH_SIZE")]
    InternalformatDepthSize = 33397,

    [NativeName("GL_INTERNALFORMAT_STENCIL_SIZE")]
    InternalformatStencilSize = 33398,

    [NativeName("GL_INTERNALFORMAT_SHARED_SIZE")]
    InternalformatSharedSize = 33399,

    [NativeName("GL_INTERNALFORMAT_RED_TYPE")]
    InternalformatRedType = 33400,

    [NativeName("GL_INTERNALFORMAT_GREEN_TYPE")]
    InternalformatGreenType = 33401,

    [NativeName("GL_INTERNALFORMAT_BLUE_TYPE")]
    InternalformatBlueType = 33402,

    [NativeName("GL_INTERNALFORMAT_ALPHA_TYPE")]
    InternalformatAlphaType = 33403,

    [NativeName("GL_INTERNALFORMAT_DEPTH_TYPE")]
    InternalformatDepthType = 33404,

    [NativeName("GL_INTERNALFORMAT_STENCIL_TYPE")]
    InternalformatStencilType = 33405,

    [NativeName("GL_MAX_WIDTH")]
    MaxWidth = 33406,

    [NativeName("GL_MAX_HEIGHT")]
    MaxHeight = 33407,

    [NativeName("GL_MAX_DEPTH")]
    MaxDepth = 33408,

    [NativeName("GL_MAX_LAYERS")]
    MaxLayers = 33409,

    [NativeName("GL_COLOR_COMPONENTS")]
    ColorComponents = 33411,

    [NativeName("GL_COLOR_RENDERABLE")]
    ColorRenderable = 33414,

    [NativeName("GL_DEPTH_RENDERABLE")]
    DepthRenderable = 33415,

    [NativeName("GL_STENCIL_RENDERABLE")]
    StencilRenderable = 33416,

    [NativeName("GL_FRAMEBUFFER_RENDERABLE")]
    FramebufferRenderable = 33417,

    [NativeName("GL_FRAMEBUFFER_RENDERABLE_LAYERED")]
    FramebufferRenderableLayered = 33418,

    [NativeName("GL_FRAMEBUFFER_BLEND")]
    FramebufferBlend = 33419,

    [NativeName("GL_READ_PIXELS")]
    ReadPixels = 33420,

    [NativeName("GL_READ_PIXELS_FORMAT")]
    ReadPixelsFormat = 33421,

    [NativeName("GL_READ_PIXELS_TYPE")]
    ReadPixelsType = 33422,

    [NativeName("GL_TEXTURE_IMAGE_FORMAT")]
    TextureImageFormat = 33423,

    [NativeName("GL_TEXTURE_IMAGE_TYPE")]
    TextureImageType = 33424,

    [NativeName("GL_GET_TEXTURE_IMAGE_FORMAT")]
    GetTextureImageFormat = 33425,

    [NativeName("GL_GET_TEXTURE_IMAGE_TYPE")]
    GetTextureImageType = 33426,

    [NativeName("GL_MIPMAP")]
    Mipmap = 33427,

    [NativeName("GL_AUTO_GENERATE_MIPMAP")]
    AutoGenerateMipmap = 33429,

    [NativeName("GL_COLOR_ENCODING")]
    ColorEncoding = 33430,

    [NativeName("GL_SRGB_READ")]
    SrgbRead = 33431,

    [NativeName("GL_SRGB_WRITE")]
    SrgbWrite = 33432,

    [NativeName("GL_FILTER")]
    Filter = 33434,

    [NativeName("GL_VERTEX_TEXTURE")]
    VertexTexture = 33435,

    [NativeName("GL_TESS_CONTROL_TEXTURE")]
    TessControlTexture = 33436,

    [NativeName("GL_TESS_EVALUATION_TEXTURE")]
    TessEvaluationTexture = 33437,

    [NativeName("GL_GEOMETRY_TEXTURE")]
    GeometryTexture = 33438,

    [NativeName("GL_FRAGMENT_TEXTURE")]
    FragmentTexture = 33439,

    [NativeName("GL_COMPUTE_TEXTURE")]
    ComputeTexture = 33440,

    [NativeName("GL_TEXTURE_SHADOW")]
    TextureShadow = 33441,

    [NativeName("GL_TEXTURE_GATHER")]
    TextureGather = 33442,

    [NativeName("GL_TEXTURE_GATHER_SHADOW")]
    TextureGatherShadow = 33443,

    [NativeName("GL_SHADER_IMAGE_LOAD")]
    ShaderImageLoad = 33444,

    [NativeName("GL_SHADER_IMAGE_STORE")]
    ShaderImageStore = 33445,

    [NativeName("GL_SHADER_IMAGE_ATOMIC")]
    ShaderImageAtomic = 33446,

    [NativeName("GL_IMAGE_TEXEL_SIZE")]
    ImageTexelSize = 33447,

    [NativeName("GL_IMAGE_COMPATIBILITY_CLASS")]
    ImageCompatibilityClass = 33448,

    [NativeName("GL_IMAGE_PIXEL_FORMAT")]
    ImagePixelFormat = 33449,

    [NativeName("GL_IMAGE_PIXEL_TYPE")]
    ImagePixelType = 33450,

    [NativeName("GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST")]
    SimultaneousTextureAndDepthTest = 33452,

    [NativeName("GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST")]
    SimultaneousTextureAndStencilTest = 33453,

    [NativeName("GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE")]
    SimultaneousTextureAndDepthWrite = 33454,

    [NativeName("GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE")]
    SimultaneousTextureAndStencilWrite = 33455,

    [NativeName("GL_TEXTURE_COMPRESSED_BLOCK_WIDTH")]
    TextureCompressedBlockWidth = 33457,

    [NativeName("GL_TEXTURE_COMPRESSED_BLOCK_HEIGHT")]
    TextureCompressedBlockHeight = 33458,

    [NativeName("GL_TEXTURE_COMPRESSED_BLOCK_SIZE")]
    TextureCompressedBlockSize = 33459,

    [NativeName("GL_CLEAR_BUFFER")]
    ClearBuffer = 33460,

    [NativeName("GL_TEXTURE_VIEW")]
    TextureView = 33461,

    [NativeName("GL_VIEW_COMPATIBILITY_CLASS")]
    ViewCompatibilityClass = 33462,

    [NativeName("GL_CLEAR_TEXTURE")]
    ClearTexture = 37733,

    [NativeName("GL_NUM_SURFACE_COMPRESSION_FIXED_RATES_EXT")]
    NumSurfaceCompressionFixedRatesEXT = 36718,
}
