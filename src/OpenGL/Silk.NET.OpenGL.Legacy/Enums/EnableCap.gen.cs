// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "EnableCap")]
    public enum EnableCap : int
    {
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_POINT_SMOOTH")]
        PointSmooth = 0xB10,
        [NativeName("Name", "GL_LINE_SMOOTH")]
        LineSmooth = 0xB20,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LINE_STIPPLE")]
        LineStipple = 0xB24,
        [NativeName("Name", "GL_POLYGON_SMOOTH")]
        PolygonSmooth = 0xB41,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_POLYGON_STIPPLE")]
        PolygonStipple = 0xB42,
        [NativeName("Name", "GL_CULL_FACE")]
        CullFace = 0xB44,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIGHTING")]
        Lighting = 0xB50,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_COLOR_MATERIAL")]
        ColorMaterial = 0xB57,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_FOG")]
        Fog = 0xB60,
        [NativeName("Name", "GL_DEPTH_TEST")]
        DepthTest = 0xB71,
        [NativeName("Name", "GL_STENCIL_TEST")]
        StencilTest = 0xB90,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_NORMALIZE")]
        Normalize = 0xBA1,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_ALPHA_TEST")]
        AlphaTest = 0xBC0,
        [NativeName("Name", "GL_DITHER")]
        Dither = 0xBD0,
        [NativeName("Name", "GL_BLEND")]
        Blend = 0xBE2,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_INDEX_LOGIC_OP")]
        IndexLogicOp = 0xBF1,
        [NativeName("Name", "GL_COLOR_LOGIC_OP")]
        ColorLogicOp = 0xBF2,
        [NativeName("Name", "GL_SCISSOR_TEST")]
        ScissorTest = 0xC11,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_TEXTURE_GEN_S")]
        TextureGenS = 0xC60,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_TEXTURE_GEN_T")]
        TextureGenT = 0xC61,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_TEXTURE_GEN_R")]
        TextureGenR = 0xC62,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_TEXTURE_GEN_Q")]
        TextureGenQ = 0xC63,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_AUTO_NORMAL")]
        AutoNormal = 0xD80,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP1_COLOR_4")]
        Map1Color4 = 0xD90,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP1_INDEX")]
        Map1Index = 0xD91,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP1_NORMAL")]
        Map1Normal = 0xD92,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP1_TEXTURE_COORD_1")]
        Map1TextureCoord1 = 0xD93,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP1_TEXTURE_COORD_2")]
        Map1TextureCoord2 = 0xD94,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP1_TEXTURE_COORD_3")]
        Map1TextureCoord3 = 0xD95,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP1_TEXTURE_COORD_4")]
        Map1TextureCoord4 = 0xD96,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP1_VERTEX_3")]
        Map1Vertex3 = 0xD97,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP1_VERTEX_4")]
        Map1Vertex4 = 0xD98,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP2_COLOR_4")]
        Map2Color4 = 0xDB0,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP2_INDEX")]
        Map2Index = 0xDB1,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP2_NORMAL")]
        Map2Normal = 0xDB2,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP2_TEXTURE_COORD_1")]
        Map2TextureCoord1 = 0xDB3,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP2_TEXTURE_COORD_2")]
        Map2TextureCoord2 = 0xDB4,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP2_TEXTURE_COORD_3")]
        Map2TextureCoord3 = 0xDB5,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP2_TEXTURE_COORD_4")]
        Map2TextureCoord4 = 0xDB6,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP2_VERTEX_3")]
        Map2Vertex3 = 0xDB7,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP2_VERTEX_4")]
        Map2Vertex4 = 0xDB8,
        [NativeName("Name", "GL_TEXTURE_1D")]
        Texture1D = 0xDE0,
        [NativeName("Name", "GL_TEXTURE_2D")]
        Texture2D = 0xDE1,
        [NativeName("Name", "GL_POLYGON_OFFSET_POINT")]
        PolygonOffsetPoint = 0x2A01,
        [NativeName("Name", "GL_POLYGON_OFFSET_LINE")]
        PolygonOffsetLine = 0x2A02,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CLIP_PLANE0")]
        ClipPlane0 = 0x3000,
        [NativeName("Name", "GL_CLIP_DISTANCE0")]
        ClipDistance0 = 0x3000,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CLIP_PLANE1")]
        ClipPlane1 = 0x3001,
        [NativeName("Name", "GL_CLIP_DISTANCE1")]
        ClipDistance1 = 0x3001,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CLIP_PLANE2")]
        ClipPlane2 = 0x3002,
        [NativeName("Name", "GL_CLIP_DISTANCE2")]
        ClipDistance2 = 0x3002,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CLIP_PLANE3")]
        ClipPlane3 = 0x3003,
        [NativeName("Name", "GL_CLIP_DISTANCE3")]
        ClipDistance3 = 0x3003,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CLIP_PLANE4")]
        ClipPlane4 = 0x3004,
        [NativeName("Name", "GL_CLIP_DISTANCE4")]
        ClipDistance4 = 0x3004,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CLIP_PLANE5")]
        ClipPlane5 = 0x3005,
        [NativeName("Name", "GL_CLIP_DISTANCE5")]
        ClipDistance5 = 0x3005,
        [NativeName("Name", "GL_CLIP_DISTANCE6")]
        ClipDistance6 = 0x3006,
        [NativeName("Name", "GL_CLIP_DISTANCE7")]
        ClipDistance7 = 0x3007,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIGHT0")]
        Light0 = 0x4000,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIGHT1")]
        Light1 = 0x4001,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIGHT2")]
        Light2 = 0x4002,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIGHT3")]
        Light3 = 0x4003,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIGHT4")]
        Light4 = 0x4004,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIGHT5")]
        Light5 = 0x4005,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIGHT6")]
        Light6 = 0x4006,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIGHT7")]
        Light7 = 0x4007,
        [NativeName("Name", "GL_CONVOLUTION_1D_EXT")]
        Convolution1DExt = 0x8010,
        [NativeName("Name", "GL_CONVOLUTION_2D_EXT")]
        Convolution2DExt = 0x8011,
        [NativeName("Name", "GL_SEPARABLE_2D_EXT")]
        Separable2DExt = 0x8012,
        [NativeName("Name", "GL_HISTOGRAM_EXT")]
        HistogramExt = 0x8024,
        [NativeName("Name", "GL_MINMAX_EXT")]
        MinmaxExt = 0x802E,
        [NativeName("Name", "GL_POLYGON_OFFSET_FILL")]
        PolygonOffsetFill = 0x8037,
        [NativeName("Name", "GL_RESCALE_NORMAL_EXT")]
        RescaleNormalExt = 0x803A,
        [NativeName("Name", "GL_TEXTURE_3D_EXT")]
        Texture3DExt = 0x806F,
        [NativeName("Name", "GL_VERTEX_ARRAY")]
        VertexArray = 0x8074,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_NORMAL_ARRAY")]
        NormalArray = 0x8075,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_COLOR_ARRAY")]
        ColorArray = 0x8076,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_INDEX_ARRAY")]
        IndexArray = 0x8077,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_TEXTURE_COORD_ARRAY")]
        TextureCoordArray = 0x8078,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_EDGE_FLAG_ARRAY")]
        EdgeFlagArray = 0x8079,
        [NativeName("Name", "GL_INTERLACE_SGIX")]
        InterlaceSgix = 0x8094,
        [NativeName("Name", "GL_MULTISAMPLE")]
        Multisample = 0x809D,
        [NativeName("Name", "GL_MULTISAMPLE_SGIS")]
        MultisampleSgis = 0x809D,
        [NativeName("Name", "GL_SAMPLE_ALPHA_TO_COVERAGE")]
        SampleAlphaToCoverage = 0x809E,
        [NativeName("Name", "GL_SAMPLE_ALPHA_TO_MASK_SGIS")]
        SampleAlphaToMaskSgis = 0x809E,
        [NativeName("Name", "GL_SAMPLE_ALPHA_TO_ONE")]
        SampleAlphaToOne = 0x809F,
        [NativeName("Name", "GL_SAMPLE_ALPHA_TO_ONE_SGIS")]
        SampleAlphaToOneSgis = 0x809F,
        [NativeName("Name", "GL_SAMPLE_COVERAGE")]
        SampleCoverage = 0x80A0,
        [NativeName("Name", "GL_SAMPLE_MASK_SGIS")]
        SampleMaskSgis = 0x80A0,
        [NativeName("Name", "GL_TEXTURE_COLOR_TABLE_SGI")]
        TextureColorTableSgi = 0x80BC,
        [NativeName("Name", "GL_COLOR_TABLE")]
        ColorTable = 0x80D0,
        [NativeName("Name", "GL_COLOR_TABLE_SGI")]
        ColorTableSgi = 0x80D0,
        [NativeName("Name", "GL_POST_CONVOLUTION_COLOR_TABLE")]
        PostConvolutionColorTable = 0x80D1,
        [NativeName("Name", "GL_POST_CONVOLUTION_COLOR_TABLE_SGI")]
        PostConvolutionColorTableSgi = 0x80D1,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_COLOR_TABLE")]
        PostColorMatrixColorTable = 0x80D2,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI")]
        PostColorMatrixColorTableSgi = 0x80D2,
        [NativeName("Name", "GL_TEXTURE_4D_SGIS")]
        Texture4DSgis = 0x8134,
        [NativeName("Name", "GL_PIXEL_TEX_GEN_SGIX")]
        PixelTexGenSgix = 0x8139,
        [NativeName("Name", "GL_SPRITE_SGIX")]
        SpriteSgix = 0x8148,
        [NativeName("Name", "GL_REFERENCE_PLANE_SGIX")]
        ReferencePlaneSgix = 0x817D,
        [NativeName("Name", "GL_IR_INSTRUMENT1_SGIX")]
        IRInstrument1Sgix = 0x817F,
        [NativeName("Name", "GL_CALLIGRAPHIC_FRAGMENT_SGIX")]
        CalligraphicFragmentSgix = 0x8183,
        [NativeName("Name", "GL_FRAMEZOOM_SGIX")]
        FramezoomSgix = 0x818B,
        [NativeName("Name", "GL_FOG_OFFSET_SGIX")]
        FogOffsetSgix = 0x8198,
        [NativeName("Name", "GL_SHARED_TEXTURE_PALETTE_EXT")]
        SharedTexturePaletteExt = 0x81FB,
        [NativeName("Name", "GL_DEBUG_OUTPUT_SYNCHRONOUS")]
        DebugOutputSynchronous = 0x8242,
        [NativeName("Name", "GL_ASYNC_HISTOGRAM_SGIX")]
        AsyncHistogramSgix = 0x832C,
        [NativeName("Name", "GL_PIXEL_TEXTURE_SGIS")]
        PixelTextureSgis = 0x8353,
        [NativeName("Name", "GL_ASYNC_TEX_IMAGE_SGIX")]
        AsyncTexImageSgix = 0x835C,
        [NativeName("Name", "GL_ASYNC_DRAW_PIXELS_SGIX")]
        AsyncDrawPixelsSgix = 0x835D,
        [NativeName("Name", "GL_ASYNC_READ_PIXELS_SGIX")]
        AsyncReadPixelsSgix = 0x835E,
        [NativeName("Name", "GL_FRAGMENT_LIGHTING_SGIX")]
        FragmentLightingSgix = 0x8400,
        [NativeName("Name", "GL_FRAGMENT_COLOR_MATERIAL_SGIX")]
        FragmentColorMaterialSgix = 0x8401,
        [NativeName("Name", "GL_FRAGMENT_LIGHT0_SGIX")]
        FragmentLight0Sgix = 0x840C,
        [NativeName("Name", "GL_FRAGMENT_LIGHT1_SGIX")]
        FragmentLight1Sgix = 0x840D,
        [NativeName("Name", "GL_FRAGMENT_LIGHT2_SGIX")]
        FragmentLight2Sgix = 0x840E,
        [NativeName("Name", "GL_FRAGMENT_LIGHT3_SGIX")]
        FragmentLight3Sgix = 0x840F,
        [NativeName("Name", "GL_FRAGMENT_LIGHT4_SGIX")]
        FragmentLight4Sgix = 0x8410,
        [NativeName("Name", "GL_FRAGMENT_LIGHT5_SGIX")]
        FragmentLight5Sgix = 0x8411,
        [NativeName("Name", "GL_FRAGMENT_LIGHT6_SGIX")]
        FragmentLight6Sgix = 0x8412,
        [NativeName("Name", "GL_FRAGMENT_LIGHT7_SGIX")]
        FragmentLight7Sgix = 0x8413,
        [NativeName("Name", "GL_TEXTURE_RECTANGLE")]
        TextureRectangle = 0x84F5,
        [NativeName("Name", "GL_TEXTURE_RECTANGLE_ARB")]
        TextureRectangleArb = 0x84F5,
        [NativeName("Name", "GL_TEXTURE_RECTANGLE_NV")]
        TextureRectangleNV = 0x84F5,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP")]
        TextureCubeMap = 0x8513,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_ARB")]
        TextureCubeMapArb = 0x8513,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_EXT")]
        TextureCubeMapExt = 0x8513,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_OES")]
        TextureCubeMapOes = 0x8513,
        [NativeName("Name", "GL_PROGRAM_POINT_SIZE")]
        ProgramPointSize = 0x8642,
        [NativeName("Name", "GL_DEPTH_CLAMP")]
        DepthClamp = 0x864F,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_SEAMLESS")]
        TextureCubeMapSeamless = 0x884F,
        [NativeName("Name", "GL_SAMPLE_SHADING")]
        SampleShading = 0x8C36,
        [NativeName("Name", "GL_RASTERIZER_DISCARD")]
        RasterizerDiscard = 0x8C89,
        [NativeName("Name", "GL_TEXTURE_GEN_STR_OES")]
        TextureGenStrOes = 0x8D60,
        [NativeName("Name", "GL_PRIMITIVE_RESTART_FIXED_INDEX")]
        PrimitiveRestartFixedIndex = 0x8D69,
        [NativeName("Name", "GL_FRAMEBUFFER_SRGB")]
        FramebufferSrgb = 0x8DB9,
        [NativeName("Name", "GL_SAMPLE_MASK")]
        SampleMask = 0x8E51,
        [NativeName("Name", "GL_FETCH_PER_SAMPLE_ARM")]
        FetchPerSampleArm = 0x8F65,
        [NativeName("Name", "GL_PRIMITIVE_RESTART")]
        PrimitiveRestart = 0x8F9D,
        [NativeName("Name", "GL_DEBUG_OUTPUT")]
        DebugOutput = 0x92E0,
        [NativeName("Name", "GL_SHADING_RATE_IMAGE_PER_PRIMITIVE_NV")]
        ShadingRateImagePerPrimitiveNV = 0x95B1,
        [NativeName("Name", "GL_FRAMEBUFFER_FETCH_NONCOHERENT_QCOM")]
        FramebufferFetchNoncoherentQCom = 0x96A2,
        [NativeName("Name", "GL_SHADING_RATE_PRESERVE_ASPECT_RATIO_QCOM")]
        ShadingRatePreserveAspectRatioQCom = 0x96A5,
    }
}
