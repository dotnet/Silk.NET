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
    ClipPlane0 = unchecked((uint)0x3000),

    [NativeName("GL_CLIP_PLANE1")]
    ClipPlane1 = unchecked((uint)0x3001),

    [NativeName("GL_CLIP_PLANE2")]
    ClipPlane2 = unchecked((uint)0x3002),

    [NativeName("GL_CLIP_PLANE3")]
    ClipPlane3 = unchecked((uint)0x3003),

    [NativeName("GL_CLIP_PLANE4")]
    ClipPlane4 = unchecked((uint)0x3004),

    [NativeName("GL_CLIP_PLANE5")]
    ClipPlane5 = unchecked((uint)0x3005),

    [NativeName("GL_FOG")]
    Fog = unchecked((uint)0x0B60),

    [NativeName("GL_LIGHTING")]
    Lighting = unchecked((uint)0x0B50),

    [NativeName("GL_TEXTURE_2D")]
    Texture2D = unchecked((uint)0x0DE1),

    [NativeName("GL_CULL_FACE")]
    CullFace = unchecked((uint)0x0B44),

    [NativeName("GL_ALPHA_TEST")]
    AlphaTest = unchecked((uint)0x0BC0),

    [NativeName("GL_BLEND")]
    Blend = unchecked((uint)0x0BE2),

    [NativeName("GL_COLOR_LOGIC_OP")]
    ColorLogicOp = unchecked((uint)0x0BF2),

    [NativeName("GL_DITHER")]
    Dither = unchecked((uint)0x0BD0),

    [NativeName("GL_STENCIL_TEST")]
    StencilTest = unchecked((uint)0x0B90),

    [NativeName("GL_DEPTH_TEST")]
    DepthTest = unchecked((uint)0x0B71),

    [NativeName("GL_POINT_SMOOTH")]
    PointSmooth = unchecked((uint)0x0B10),

    [NativeName("GL_LINE_SMOOTH")]
    LineSmooth = unchecked((uint)0x0B20),

    [NativeName("GL_SCISSOR_TEST")]
    ScissorTest = unchecked((uint)0x0C11),

    [NativeName("GL_COLOR_MATERIAL")]
    ColorMaterial = unchecked((uint)0x0B57),

    [NativeName("GL_NORMALIZE")]
    Normalize = unchecked((uint)0x0BA1),

    [NativeName("GL_VERTEX_ARRAY")]
    VertexArray = unchecked((uint)0x8074),

    [NativeName("GL_NORMAL_ARRAY")]
    NormalArray = unchecked((uint)0x8075),

    [NativeName("GL_COLOR_ARRAY")]
    ColorArray = unchecked((uint)0x8076),

    [NativeName("GL_TEXTURE_COORD_ARRAY")]
    TextureCoordArray = unchecked((uint)0x8078),

    [NativeName("GL_MULTISAMPLE")]
    Multisample = unchecked((uint)0x809D),

    [NativeName("GL_SAMPLE_ALPHA_TO_COVERAGE")]
    SampleAlphaToCoverage = unchecked((uint)0x809E),

    [NativeName("GL_SAMPLE_ALPHA_TO_ONE")]
    SampleAlphaToOne = unchecked((uint)0x809F),

    [NativeName("GL_SAMPLE_COVERAGE")]
    SampleCoverage = unchecked((uint)0x80A0),

    [NativeName("GL_POLYGON_OFFSET_FILL")]
    PolygonOffsetFill = unchecked((uint)0x8037),

    [NativeName("GL_LIGHT0")]
    Light0 = unchecked((uint)0x4000),

    [NativeName("GL_LIGHT1")]
    Light1 = unchecked((uint)0x4001),

    [NativeName("GL_LIGHT2")]
    Light2 = unchecked((uint)0x4002),

    [NativeName("GL_LIGHT3")]
    Light3 = unchecked((uint)0x4003),

    [NativeName("GL_LIGHT4")]
    Light4 = unchecked((uint)0x4004),

    [NativeName("GL_LIGHT5")]
    Light5 = unchecked((uint)0x4005),

    [NativeName("GL_LIGHT6")]
    Light6 = unchecked((uint)0x4006),

    [NativeName("GL_LIGHT7")]
    Light7 = unchecked((uint)0x4007),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_OES")]
    TextureCubeMapOES = unchecked((uint)0x8513),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_GEN_STR_OES")]
    TextureGenStrOES = unchecked((uint)0x8D60),

    [NativeName("GL_POLYGON_SMOOTH")]
    PolygonSmooth = unchecked((uint)0x0B41),

    [NativeName("GL_TEXTURE_1D")]
    Texture1D = unchecked((uint)0x0DE0),

    [NativeName("GL_LINE_STIPPLE")]
    LineStipple = unchecked((uint)0x0B24),

    [NativeName("GL_POLYGON_STIPPLE")]
    PolygonStipple = unchecked((uint)0x0B42),

    [NativeName("GL_TEXTURE_GEN_S")]
    TextureGenS = unchecked((uint)0x0C60),

    [NativeName("GL_TEXTURE_GEN")]
    [NameAffix("Suffix", "_T", -1)]
    TextureGen = unchecked((uint)0x0C61),

    [NativeName("GL_TEXTURE_GEN_R")]
    TextureGenR = unchecked((uint)0x0C62),

    [NativeName("GL_TEXTURE_GEN_Q")]
    TextureGenQ = unchecked((uint)0x0C63),

    [NativeName("GL_AUTO_NORMAL")]
    AutoNormal = unchecked((uint)0x0D80),

    [NativeName("GL_MAP1_COLOR_4")]
    Map1Color4 = unchecked((uint)0x0D90),

    [NativeName("GL_MAP1_INDEX")]
    Map1Index = unchecked((uint)0x0D91),

    [NativeName("GL_MAP1_NORMAL")]
    Map1Normal = unchecked((uint)0x0D92),

    [NativeName("GL_MAP1_TEXTURE_COORD_1")]
    Map1TextureCoord1 = unchecked((uint)0x0D93),

    [NativeName("GL_MAP1_TEXTURE_COORD_2")]
    Map1TextureCoord2 = unchecked((uint)0x0D94),

    [NativeName("GL_MAP1_TEXTURE_COORD_3")]
    Map1TextureCoord3 = unchecked((uint)0x0D95),

    [NativeName("GL_MAP1_TEXTURE_COORD_4")]
    Map1TextureCoord4 = unchecked((uint)0x0D96),

    [NativeName("GL_MAP1_VERTEX_3")]
    Map1Vertex3 = unchecked((uint)0x0D97),

    [NativeName("GL_MAP1_VERTEX_4")]
    Map1Vertex4 = unchecked((uint)0x0D98),

    [NativeName("GL_MAP2_COLOR_4")]
    Map2Color4 = unchecked((uint)0x0DB0),

    [NativeName("GL_MAP2_INDEX")]
    Map2Index = unchecked((uint)0x0DB1),

    [NativeName("GL_MAP2_NORMAL")]
    Map2Normal = unchecked((uint)0x0DB2),

    [NativeName("GL_MAP2_TEXTURE_COORD_1")]
    Map2TextureCoord1 = unchecked((uint)0x0DB3),

    [NativeName("GL_MAP2_TEXTURE_COORD_2")]
    Map2TextureCoord2 = unchecked((uint)0x0DB4),

    [NativeName("GL_MAP2_TEXTURE_COORD_3")]
    Map2TextureCoord3 = unchecked((uint)0x0DB5),

    [NativeName("GL_MAP2_TEXTURE_COORD_4")]
    Map2TextureCoord4 = unchecked((uint)0x0DB6),

    [NativeName("GL_MAP2_VERTEX_3")]
    Map2Vertex3 = unchecked((uint)0x0DB7),

    [NativeName("GL_MAP2_VERTEX_4")]
    Map2Vertex4 = unchecked((uint)0x0DB8),

    [NativeName("GL_POLYGON_OFFSET_POINT")]
    PolygonOffsetPoint = unchecked((uint)0x2A01),

    [NativeName("GL_POLYGON_OFFSET_LINE")]
    PolygonOffsetLine = unchecked((uint)0x2A02),

    [NativeName("GL_INDEX_LOGIC_OP")]
    IndexLogicOp = unchecked((uint)0x0BF1),

    [NativeName("GL_INDEX_ARRAY")]
    IndexArray = unchecked((uint)0x8077),

    [NativeName("GL_EDGE_FLAG_ARRAY")]
    EdgeFlagArray = unchecked((uint)0x8079),

    [NativeName("GL_TEXTURE_CUBE_MAP")]
    TextureCubeMap = unchecked((uint)0x8513),

    [NativeName("GL_CLIP_DISTANCE0")]
    ClipDistance0 = unchecked((uint)0x3000),

    [NativeName("GL_CLIP_DISTANCE1")]
    ClipDistance1 = unchecked((uint)0x3001),

    [NativeName("GL_CLIP_DISTANCE2")]
    ClipDistance2 = unchecked((uint)0x3002),

    [NativeName("GL_CLIP_DISTANCE3")]
    ClipDistance3 = unchecked((uint)0x3003),

    [NativeName("GL_CLIP_DISTANCE4")]
    ClipDistance4 = unchecked((uint)0x3004),

    [NativeName("GL_CLIP_DISTANCE5")]
    ClipDistance5 = unchecked((uint)0x3005),

    [NativeName("GL_CLIP_DISTANCE6")]
    ClipDistance6 = unchecked((uint)0x3006),

    [NativeName("GL_CLIP_DISTANCE7")]
    ClipDistance7 = unchecked((uint)0x3007),

    [NativeName("GL_RASTERIZER_DISCARD")]
    RasterizerDiscard = unchecked((uint)0x8C89),

    [NativeName("GL_FRAMEBUFFER_SRGB")]
    FramebufferSrgb = unchecked((uint)0x8DB9),

    [NameAffix("Suffix", "ANGLE", 0)]
    [NativeName("GL_TEXTURE_RECTANGLE")]
    TextureRectANGLE = unchecked((uint)0x84F5),

    [NativeName("GL_PRIMITIVE_RESTART")]
    PrimitiveRestart = unchecked((uint)0x8F9D),

    [NativeName("GL_PROGRAM_POINT_SIZE")]
    ProgramPointSize = unchecked((uint)0x8642),

    [NativeName("GL_DEPTH_CLAMP")]
    DepthClamp = unchecked((uint)0x864F),

    [NativeName("GL_TEXTURE_CUBE_MAP_SEAMLESS")]
    TextureCubeMapSeamless = unchecked((uint)0x884F),

    [NativeName("GL_SAMPLE_MASK")]
    SampleMask = unchecked((uint)0x8E51),

    [NativeName("GL_SAMPLE_SHADING")]
    SampleShading = unchecked((uint)0x8C36),

    [NativeName("GL_PRIMITIVE_RESTART_FIXED_INDEX")]
    PrimitiveRestartFixedIndex = unchecked((uint)0x8D69),

    [NativeName("GL_DEBUG_OUTPUT_SYNCHRONOUS")]
    DebugOutputSynchronous = unchecked((uint)0x8242),

    [NativeName("GL_DEBUG_OUTPUT")]
    DebugOutput = unchecked((uint)0x92E0),

    [NativeName("GL_COLOR_TABLE")]
    ColorTable = unchecked((uint)0x80D0),

    [NativeName("GL_POST_CONVOLUTION_COLOR_TABLE")]
    PostConvolutionColorTable = unchecked((uint)0x80D1),

    [NativeName("GL_POST_COLOR_MATRIX_COLOR_TABLE")]
    PostColorMatrixColorTable = unchecked((uint)0x80D2),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_ARB")]
    TextureCubeMapARB = unchecked((uint)0x8513),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_RECTANGLE_ARB")]
    TextureRectangleARB = unchecked((uint)0x84F5),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CONVOLUTION_1D_EXT")]
    Convolution1DEXT = unchecked((uint)0x8010),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CONVOLUTION_2D_EXT")]
    Convolution2DEXT = unchecked((uint)0x8011),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SEPARABLE_2D_EXT")]
    Separable2DEXT = unchecked((uint)0x8012),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HISTOGRAM_EXT")]
    HistogramEXT = unchecked((uint)0x8024),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MINMAX_EXT")]
    MinmaxEXT = unchecked((uint)0x802E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RESCALE_NORMAL_EXT")]
    RescaleNormalEXT = unchecked((uint)0x803A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SHARED_TEXTURE_PALETTE_EXT")]
    SharedTexturePaletteEXT = unchecked((uint)0x81FB),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_3D_EXT")]
    Texture3DEXT = unchecked((uint)0x806F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_EXT")]
    TextureCubeMapEXT = unchecked((uint)0x8513),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SHADING_RATE_IMAGE_PER_PRIMITIVE_NV")]
    ShadingRateImagePerPrimitiveNV = unchecked((uint)0x95B1),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TEXTURE_RECTANGLE_NV")]
    TextureRectangleNV = unchecked((uint)0x84F5),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_MULTISAMPLE_SGIS")]
    MultisampleSGIS = unchecked((uint)0x809D),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_SAMPLE_ALPHA_TO_MASK_SGIS")]
    SampleAlphaToMaskSGIS = unchecked((uint)0x809E),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_SAMPLE_ALPHA_TO_ONE_SGIS")]
    SampleAlphaToOneSGIS = unchecked((uint)0x809F),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_SAMPLE_MASK_SGIS")]
    SampleMaskSGIS = unchecked((uint)0x80A0),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_PIXEL_TEXTURE_SGIS")]
    PixelTextureSGIS = unchecked((uint)0x8353),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_TEXTURE_4D_SGIS")]
    Texture4DSGIS = unchecked((uint)0x8134),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_ASYNC_HISTOGRAM_SGIX")]
    AsyncHistogramSGIX = unchecked((uint)0x832C),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_ASYNC_TEX_IMAGE_SGIX")]
    AsyncTexImageSGIX = unchecked((uint)0x835C),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_ASYNC_DRAW_PIXELS_SGIX")]
    AsyncDrawPixelsSGIX = unchecked((uint)0x835D),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_ASYNC_READ_PIXELS_SGIX")]
    AsyncReadPixelsSGIX = unchecked((uint)0x835E),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_CALLIGRAPHIC_FRAGMENT_SGIX")]
    CalligraphicFragmentSGIX = unchecked((uint)0x8183),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FOG_OFFSET_SGIX")]
    FogOffsetSGIX = unchecked((uint)0x8198),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_LIGHTING_SGIX")]
    FragmentLightingSGIX = unchecked((uint)0x8400),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_COLOR_MATERIAL_SGIX")]
    FragmentColorMaterialSGIX = unchecked((uint)0x8401),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_LIGHT0_SGIX")]
    FragmentLight0SGIX = unchecked((uint)0x840C),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_LIGHT1_SGIX")]
    FragmentLight1SGIX = unchecked((uint)0x840D),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_LIGHT2_SGIX")]
    FragmentLight2SGIX = unchecked((uint)0x840E),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_LIGHT3_SGIX")]
    FragmentLight3SGIX = unchecked((uint)0x840F),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_LIGHT4_SGIX")]
    FragmentLight4SGIX = unchecked((uint)0x8410),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_LIGHT5_SGIX")]
    FragmentLight5SGIX = unchecked((uint)0x8411),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_LIGHT6_SGIX")]
    FragmentLight6SGIX = unchecked((uint)0x8412),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_LIGHT7_SGIX")]
    FragmentLight7SGIX = unchecked((uint)0x8413),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAMEZOOM_SGIX")]
    FramezoomSGIX = unchecked((uint)0x818B),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_INTERLACE_SGIX")]
    InterlaceSGIX = unchecked((uint)0x8094),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_IR_INSTRUMENT1_SGIX")]
    IrInstrument1SGIX = unchecked((uint)0x817F),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_PIXEL_TEX_GEN_SGIX")]
    PixelTexGenSGIX = unchecked((uint)0x8139),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_REFERENCE_PLANE_SGIX")]
    ReferencePlaneSGIX = unchecked((uint)0x817D),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_SPRITE_SGIX")]
    SpriteSGIX = unchecked((uint)0x8148),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_COLOR_TABLE_SGI")]
    ColorTableSGI = unchecked((uint)0x80D0),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_POST_CONVOLUTION_COLOR_TABLE_SGI")]
    PostConvolutionColorTableSGI = unchecked((uint)0x80D1),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI")]
    PostColorMatrixColorTableSGI = unchecked((uint)0x80D2),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_TEXTURE_COLOR_TABLE_SGI")]
    TextureColorTableSGI = unchecked((uint)0x80BC),

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("GL_FETCH_PER_SAMPLE_ARM")]
    FetchPerSampleARM = unchecked((uint)0x8F65),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_FRAMEBUFFER_FETCH_NONCOHERENT_QCOM")]
    FramebufferFetchNoncoherentQCOM = unchecked((uint)0x96A2),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_SHADING_RATE_PRESERVE_ASPECT_RATIO_QCOM")]
    ShadingRatePreserveAspectRatioQCOM = unchecked((uint)0x96A5),
}
