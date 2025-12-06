// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("EnableCap")]
public enum EnableCap : uint
{
    [NativeName("GL_CLIP_PLANE0")]
    ClipPlane0 = 12288,

    [NativeName("GL_CLIP_PLANE1")]
    ClipPlane1 = 12289,

    [NativeName("GL_CLIP_PLANE2")]
    ClipPlane2 = 12290,

    [NativeName("GL_CLIP_PLANE3")]
    ClipPlane3 = 12291,

    [NativeName("GL_CLIP_PLANE4")]
    ClipPlane4 = 12292,

    [NativeName("GL_CLIP_PLANE5")]
    ClipPlane5 = 12293,

    [NativeName("GL_FOG")]
    Fog = 2912,

    [NativeName("GL_LIGHTING")]
    Lighting = 2896,

    [NativeName("GL_TEXTURE_2D")]
    Texture2D = 3553,

    [NativeName("GL_CULL_FACE")]
    CullFace = 2884,

    [NativeName("GL_ALPHA_TEST")]
    AlphaTest = 3008,

    [NativeName("GL_BLEND")]
    Blend = 3042,

    [NativeName("GL_COLOR_LOGIC_OP")]
    ColorLogicOp = 3058,

    [NativeName("GL_DITHER")]
    Dither = 3024,

    [NativeName("GL_STENCIL_TEST")]
    StencilTest = 2960,

    [NativeName("GL_DEPTH_TEST")]
    DepthTest = 2929,

    [NativeName("GL_POINT_SMOOTH")]
    PointSmooth = 2832,

    [NativeName("GL_LINE_SMOOTH")]
    LineSmooth = 2848,

    [NativeName("GL_SCISSOR_TEST")]
    ScissorTest = 3089,

    [NativeName("GL_COLOR_MATERIAL")]
    ColorMaterial = 2903,

    [NativeName("GL_NORMALIZE")]
    Normalize = 2977,

    [NativeName("GL_VERTEX_ARRAY")]
    VertexArray = 32884,

    [NativeName("GL_NORMAL_ARRAY")]
    NormalArray = 32885,

    [NativeName("GL_COLOR_ARRAY")]
    ColorArray = 32886,

    [NativeName("GL_TEXTURE_COORD_ARRAY")]
    TextureCoordArray = 32888,

    [NativeName("GL_MULTISAMPLE")]
    Multisample = 32925,

    [NativeName("GL_SAMPLE_ALPHA_TO_COVERAGE")]
    SampleAlphaToCoverage = 32926,

    [NativeName("GL_SAMPLE_ALPHA_TO_ONE")]
    SampleAlphaToOne = 32927,

    [NativeName("GL_SAMPLE_COVERAGE")]
    SampleCoverage = 32928,

    [NativeName("GL_POLYGON_OFFSET_FILL")]
    PolygonOffsetFill = 32823,

    [NativeName("GL_LIGHT0")]
    Light0 = 16384,

    [NativeName("GL_LIGHT1")]
    Light1 = 16385,

    [NativeName("GL_LIGHT2")]
    Light2 = 16386,

    [NativeName("GL_LIGHT3")]
    Light3 = 16387,

    [NativeName("GL_LIGHT4")]
    Light4 = 16388,

    [NativeName("GL_LIGHT5")]
    Light5 = 16389,

    [NativeName("GL_LIGHT6")]
    Light6 = 16390,

    [NativeName("GL_LIGHT7")]
    Light7 = 16391,

    [NativeName("GL_TEXTURE_CUBE_MAP_OES")]
    TextureCubeMapOES = 34067,

    [NativeName("GL_TEXTURE_GEN_STR_OES")]
    TextureGenStrOES = 36192,

    [NativeName("GL_POLYGON_SMOOTH")]
    PolygonSmooth = 2881,

    [NativeName("GL_TEXTURE_1D")]
    Texture1D = 3552,

    [NativeName("GL_LINE_STIPPLE")]
    LineStipple = 2852,

    [NativeName("GL_POLYGON_STIPPLE")]
    PolygonStipple = 2882,

    [NativeName("GL_TEXTURE_GEN_S")]
    TextureGenS = 3168,

    [NativeName("GL_TEXTURE_GEN_T")]
    TextureGenT = 3169,

    [NativeName("GL_TEXTURE_GEN_R")]
    TextureGenR = 3170,

    [NativeName("GL_TEXTURE_GEN_Q")]
    TextureGenQ = 3171,

    [NativeName("GL_AUTO_NORMAL")]
    AutoNormal = 3456,

    [NativeName("GL_MAP1_COLOR_4")]
    Map1Color4 = 3472,

    [NativeName("GL_MAP1_INDEX")]
    Map1Index = 3473,

    [NativeName("GL_MAP1_NORMAL")]
    Map1Normal = 3474,

    [NativeName("GL_MAP1_TEXTURE_COORD_1")]
    Map1TextureCoord1 = 3475,

    [NativeName("GL_MAP1_TEXTURE_COORD_2")]
    Map1TextureCoord2 = 3476,

    [NativeName("GL_MAP1_TEXTURE_COORD_3")]
    Map1TextureCoord3 = 3477,

    [NativeName("GL_MAP1_TEXTURE_COORD_4")]
    Map1TextureCoord4 = 3478,

    [NativeName("GL_MAP1_VERTEX_3")]
    Map1Vertex3 = 3479,

    [NativeName("GL_MAP1_VERTEX_4")]
    Map1Vertex4 = 3480,

    [NativeName("GL_MAP2_COLOR_4")]
    Map2Color4 = 3504,

    [NativeName("GL_MAP2_INDEX")]
    Map2Index = 3505,

    [NativeName("GL_MAP2_NORMAL")]
    Map2Normal = 3506,

    [NativeName("GL_MAP2_TEXTURE_COORD_1")]
    Map2TextureCoord1 = 3507,

    [NativeName("GL_MAP2_TEXTURE_COORD_2")]
    Map2TextureCoord2 = 3508,

    [NativeName("GL_MAP2_TEXTURE_COORD_3")]
    Map2TextureCoord3 = 3509,

    [NativeName("GL_MAP2_TEXTURE_COORD_4")]
    Map2TextureCoord4 = 3510,

    [NativeName("GL_MAP2_VERTEX_3")]
    Map2Vertex3 = 3511,

    [NativeName("GL_MAP2_VERTEX_4")]
    Map2Vertex4 = 3512,

    [NativeName("GL_POLYGON_OFFSET_POINT")]
    PolygonOffsetPoint = 10753,

    [NativeName("GL_POLYGON_OFFSET_LINE")]
    PolygonOffsetLine = 10754,

    [NativeName("GL_INDEX_LOGIC_OP")]
    IndexLogicOp = 3057,

    [NativeName("GL_INDEX_ARRAY")]
    IndexArray = 32887,

    [NativeName("GL_EDGE_FLAG_ARRAY")]
    EdgeFlagArray = 32889,

    [NativeName("GL_TEXTURE_CUBE_MAP")]
    TextureCubeMap = 34067,

    [NativeName("GL_CLIP_DISTANCE0")]
    ClipDistance0 = 12288,

    [NativeName("GL_CLIP_DISTANCE1")]
    ClipDistance1 = 12289,

    [NativeName("GL_CLIP_DISTANCE2")]
    ClipDistance2 = 12290,

    [NativeName("GL_CLIP_DISTANCE3")]
    ClipDistance3 = 12291,

    [NativeName("GL_CLIP_DISTANCE4")]
    ClipDistance4 = 12292,

    [NativeName("GL_CLIP_DISTANCE5")]
    ClipDistance5 = 12293,

    [NativeName("GL_CLIP_DISTANCE6")]
    ClipDistance6 = 12294,

    [NativeName("GL_CLIP_DISTANCE7")]
    ClipDistance7 = 12295,

    [NativeName("GL_RASTERIZER_DISCARD")]
    RasterizerDiscard = 35977,

    [NativeName("GL_FRAMEBUFFER_SRGB")]
    FramebufferSrgb = 36281,

    [NativeName("GL_TEXTURE_RECTANGLE")]
    TextureRectANGLE = 34037,

    [NativeName("GL_PRIMITIVE_RESTART")]
    PrimitiveRestart = 36765,

    [NativeName("GL_PROGRAM_POINT_SIZE")]
    ProgramPointSize = 34370,

    [NativeName("GL_DEPTH_CLAMP")]
    DepthClamp = 34383,

    [NativeName("GL_TEXTURE_CUBE_MAP_SEAMLESS")]
    TextureCubeMapSeamless = 34895,

    [NativeName("GL_SAMPLE_MASK")]
    SampleMask = 36433,

    [NativeName("GL_SAMPLE_SHADING")]
    SampleShading = 35894,

    [NativeName("GL_PRIMITIVE_RESTART_FIXED_INDEX")]
    PrimitiveRestartFixedIndex = 36201,

    [NativeName("GL_DEBUG_OUTPUT_SYNCHRONOUS")]
    DebugOutputSynchronous = 33346,

    [NativeName("GL_DEBUG_OUTPUT")]
    DebugOutput = 37600,

    [NativeName("GL_COLOR_TABLE")]
    ColorTable = 32976,

    [NativeName("GL_POST_CONVOLUTION_COLOR_TABLE")]
    PostConvolutionColorTable = 32977,

    [NativeName("GL_POST_COLOR_MATRIX_COLOR_TABLE")]
    PostColorMatrixColorTable = 32978,

    [NativeName("GL_TEXTURE_CUBE_MAP_ARB")]
    TextureCubeMapARB = 34067,

    [NativeName("GL_TEXTURE_RECTANGLE_ARB")]
    TextureRectangleARB = 34037,

    [NativeName("GL_CONVOLUTION_1D_EXT")]
    Convolution1DEXT = 32784,

    [NativeName("GL_CONVOLUTION_2D_EXT")]
    Convolution2DEXT = 32785,

    [NativeName("GL_SEPARABLE_2D_EXT")]
    Separable2DEXT = 32786,

    [NativeName("GL_HISTOGRAM_EXT")]
    HistogramEXT = 32804,

    [NativeName("GL_MINMAX_EXT")]
    MinmaxEXT = 32814,

    [NativeName("GL_RESCALE_NORMAL_EXT")]
    RescaleNormalEXT = 32826,

    [NativeName("GL_SHARED_TEXTURE_PALETTE_EXT")]
    SharedTexturePaletteEXT = 33275,

    [NativeName("GL_TEXTURE_3D_EXT")]
    Texture3DEXT = 32879,

    [NativeName("GL_TEXTURE_CUBE_MAP_EXT")]
    TextureCubeMapEXT = 34067,

    [NativeName("GL_SHADING_RATE_IMAGE_PER_PRIMITIVE_NV")]
    ShadingRateImagePerPrimitiveNV = 38321,

    [NativeName("GL_TEXTURE_RECTANGLE_NV")]
    TextureRectangleNV = 34037,

    [NativeName("GL_MULTISAMPLE_SGIS")]
    MultisampleSGIS = 32925,

    [NativeName("GL_SAMPLE_ALPHA_TO_MASK_SGIS")]
    SampleAlphaToMaskSGIS = 32926,

    [NativeName("GL_SAMPLE_ALPHA_TO_ONE_SGIS")]
    SampleAlphaToOneSGIS = 32927,

    [NativeName("GL_SAMPLE_MASK_SGIS")]
    SampleMaskSGIS = 32928,

    [NativeName("GL_PIXEL_TEXTURE_SGIS")]
    PixelTextureSGIS = 33619,

    [NativeName("GL_TEXTURE_4D_SGIS")]
    Texture4DSGIS = 33076,

    [NativeName("GL_ASYNC_HISTOGRAM_SGIX")]
    AsyncHistogramSGIX = 33580,

    [NativeName("GL_ASYNC_TEX_IMAGE_SGIX")]
    AsyncTexImageSGIX = 33628,

    [NativeName("GL_ASYNC_DRAW_PIXELS_SGIX")]
    AsyncDrawPixelsSGIX = 33629,

    [NativeName("GL_ASYNC_READ_PIXELS_SGIX")]
    AsyncReadPixelsSGIX = 33630,

    [NativeName("GL_CALLIGRAPHIC_FRAGMENT_SGIX")]
    CalligraphicFragmentSGIX = 33155,

    [NativeName("GL_FOG_OFFSET_SGIX")]
    FogOffsetSGIX = 33176,

    [NativeName("GL_FRAGMENT_LIGHTING_SGIX")]
    FragmentLightingSGIX = 33792,

    [NativeName("GL_FRAGMENT_COLOR_MATERIAL_SGIX")]
    FragmentColorMaterialSGIX = 33793,

    [NativeName("GL_FRAGMENT_LIGHT0_SGIX")]
    FragmentLight0SGIX = 33804,

    [NativeName("GL_FRAGMENT_LIGHT1_SGIX")]
    FragmentLight1SGIX = 33805,

    [NativeName("GL_FRAGMENT_LIGHT2_SGIX")]
    FragmentLight2SGIX = 33806,

    [NativeName("GL_FRAGMENT_LIGHT3_SGIX")]
    FragmentLight3SGIX = 33807,

    [NativeName("GL_FRAGMENT_LIGHT4_SGIX")]
    FragmentLight4SGIX = 33808,

    [NativeName("GL_FRAGMENT_LIGHT5_SGIX")]
    FragmentLight5SGIX = 33809,

    [NativeName("GL_FRAGMENT_LIGHT6_SGIX")]
    FragmentLight6SGIX = 33810,

    [NativeName("GL_FRAGMENT_LIGHT7_SGIX")]
    FragmentLight7SGIX = 33811,

    [NativeName("GL_FRAMEZOOM_SGIX")]
    FramezoomSGIX = 33163,

    [NativeName("GL_INTERLACE_SGIX")]
    InterlaceSGIX = 32916,

    [NativeName("GL_IR_INSTRUMENT1_SGIX")]
    IrInstrument1SGIX = 33151,

    [NativeName("GL_PIXEL_TEX_GEN_SGIX")]
    PixelTexGenSGIX = 33081,

    [NativeName("GL_REFERENCE_PLANE_SGIX")]
    ReferencePlaneSGIX = 33149,

    [NativeName("GL_SPRITE_SGIX")]
    SpriteSGIX = 33096,

    [NativeName("GL_COLOR_TABLE_SGI")]
    ColorTableSGI = 32976,

    [NativeName("GL_POST_CONVOLUTION_COLOR_TABLE_SGI")]
    PostConvolutionColorTableSGI = 32977,

    [NativeName("GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI")]
    PostColorMatrixColorTableSGI = 32978,

    [NativeName("GL_TEXTURE_COLOR_TABLE_SGI")]
    TextureColorTableSGI = 32956,

    [NativeName("GL_FETCH_PER_SAMPLE_ARM")]
    FetchPerSampleARM = 36709,

    [NativeName("GL_FRAMEBUFFER_FETCH_NONCOHERENT_QCOM")]
    FramebufferFetchNoncoherentQCOM = 38562,

    [NativeName("GL_SHADING_RATE_PRESERVE_ASPECT_RATIO_QCOM")]
    ShadingRatePreserveAspectRatioQCOM = 38565,
}
