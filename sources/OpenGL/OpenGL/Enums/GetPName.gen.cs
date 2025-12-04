// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("GetPName")]
public enum GetPName : uint
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

    [NativeName("GL_FOG_DENSITY")]
    FogDensity = unchecked((uint)0x0B62),

    [NativeName("GL_FOG_START")]
    FogStart = unchecked((uint)0x0B63),

    [NativeName("GL_FOG_END")]
    FogEnd = unchecked((uint)0x0B64),

    [NativeName("GL_FOG_MODE")]
    FogMode = unchecked((uint)0x0B65),

    [NativeName("GL_FOG_COLOR")]
    FogColor = unchecked((uint)0x0B66),

    [NativeName("GL_CURRENT_COLOR")]
    CurrentColor = unchecked((uint)0x0B00),

    [NativeName("GL_CURRENT_NORMAL")]
    CurrentNormal = unchecked((uint)0x0B02),

    [NativeName("GL_CURRENT_TEXTURE_COORDS")]
    CurrentTextureCoords = unchecked((uint)0x0B03),

    [NativeName("GL_POINT_SIZE")]
    PointSize = unchecked((uint)0x0B11),

    [NativeName("GL_POINT_SIZE_MIN")]
    PointSizeMin = unchecked((uint)0x8126),

    [NativeName("GL_POINT_SIZE_MAX")]
    PointSizeMax = unchecked((uint)0x8127),

    [NativeName("GL_POINT_FADE_THRESHOLD_SIZE")]
    PointFadeThresholdSize = unchecked((uint)0x8128),

    [NativeName("GL_POINT_DISTANCE_ATTENUATION")]
    PointDistanceAttenuation = unchecked((uint)0x8129),

    [NativeName("GL_SMOOTH_POINT_SIZE_RANGE")]
    SmoothPointSizeRange = unchecked((uint)0x0B12),

    [NativeName("GL_LINE_WIDTH")]
    LineWidth = unchecked((uint)0x0B21),

    [NativeName("GL_SMOOTH_LINE_WIDTH_RANGE")]
    SmoothLineWidthRange = unchecked((uint)0x0B22),

    [NativeName("GL_ALIASED_POINT_SIZE_RANGE")]
    AliasedPointSizeRange = unchecked((uint)0x846D),

    [NativeName("GL_ALIASED_LINE_WIDTH_RANGE")]
    AliasedLineWidthRange = unchecked((uint)0x846E),

    [NativeName("GL_CULL_FACE_MODE")]
    CullFaceMode = unchecked((uint)0x0B45),

    [NativeName("GL_FRONT_FACE")]
    FrontFace = unchecked((uint)0x0B46),

    [NativeName("GL_SHADE_MODEL")]
    ShadeModel = unchecked((uint)0x0B54),

    [NativeName("GL_DEPTH_RANGE")]
    DepthRange = unchecked((uint)0x0B70),

    [NativeName("GL_DEPTH_WRITEMASK")]
    DepthWritemask = unchecked((uint)0x0B72),

    [NativeName("GL_DEPTH_CLEAR_VALUE")]
    DepthClearValue = unchecked((uint)0x0B73),

    [NativeName("GL_DEPTH_FUNC")]
    DepthFunc = unchecked((uint)0x0B74),

    [NativeName("GL_STENCIL_CLEAR_VALUE")]
    StencilClearValue = unchecked((uint)0x0B91),

    [NativeName("GL_STENCIL_FUNC")]
    StencilFunc = unchecked((uint)0x0B92),

    [NativeName("GL_STENCIL_VALUE_MASK")]
    StencilValueMask = unchecked((uint)0x0B93),

    [NativeName("GL_STENCIL_FAIL")]
    StencilFail = unchecked((uint)0x0B94),

    [NativeName("GL_STENCIL_PASS_DEPTH_FAIL")]
    StencilPassDepthFail = unchecked((uint)0x0B95),

    [NativeName("GL_STENCIL_PASS_DEPTH_PASS")]
    StencilPassDepthPass = unchecked((uint)0x0B96),

    [NativeName("GL_STENCIL_REF")]
    StencilRef = unchecked((uint)0x0B97),

    [NativeName("GL_STENCIL_WRITEMASK")]
    StencilWritemask = unchecked((uint)0x0B98),

    [NativeName("GL_MATRIX_MODE")]
    MatrixMode = unchecked((uint)0x0BA0),

    [NativeName("GL_VIEWPORT")]
    Viewport = unchecked((uint)0x0BA2),

    [NativeName("GL_MODELVIEW_STACK_DEPTH")]
    ModelviewStackDepth = unchecked((uint)0x0BA3),

    [NativeName("GL_PROJECTION_STACK_DEPTH")]
    ProjectionStackDepth = unchecked((uint)0x0BA4),

    [NativeName("GL_TEXTURE_STACK_DEPTH")]
    TextureStackDepth = unchecked((uint)0x0BA5),

    [NativeName("GL_MODELVIEW_MATRIX")]
    ModelviewMatrix = unchecked((uint)0x0BA6),

    [NativeName("GL_PROJECTION_MATRIX")]
    ProjectionMatrix = unchecked((uint)0x0BA7),

    [NativeName("GL_TEXTURE_MATRIX")]
    TextureMatrix = unchecked((uint)0x0BA8),

    [NativeName("GL_ALPHA_TEST_FUNC")]
    AlphaTestFunc = unchecked((uint)0x0BC1),

    [NativeName("GL_ALPHA_TEST_REF")]
    AlphaTestRef = unchecked((uint)0x0BC2),

    [NativeName("GL_BLEND_DST")]
    BlendDst = unchecked((uint)0x0BE0),

    [NativeName("GL_BLEND_SRC")]
    BlendSrc = unchecked((uint)0x0BE1),

    [NativeName("GL_LOGIC_OP_MODE")]
    LogicOpMode = unchecked((uint)0x0BF0),

    [NativeName("GL_SCISSOR_BOX")]
    ScissorBox = unchecked((uint)0x0C10),

    [NativeName("GL_COLOR_CLEAR_VALUE")]
    ColorClearValue = unchecked((uint)0x0C22),

    [NativeName("GL_COLOR_WRITEMASK")]
    ColorWritemask = unchecked((uint)0x0C23),

    [NativeName("GL_MAX_LIGHTS")]
    MaxLights = unchecked((uint)0x0D31),

    [NativeName("GL_MAX_CLIP_PLANES")]
    MaxClipPlanes = unchecked((uint)0x0D32),

    [NativeName("GL_MAX_TEXTURE_SIZE")]
    MaxTextureSize = unchecked((uint)0x0D33),

    [NativeName("GL_MAX_MODELVIEW_STACK_DEPTH")]
    MaxModelviewStackDepth = unchecked((uint)0x0D36),

    [NativeName("GL_MAX_PROJECTION_STACK_DEPTH")]
    MaxProjectionStackDepth = unchecked((uint)0x0D38),

    [NativeName("GL_MAX_TEXTURE_STACK_DEPTH")]
    MaxTextureStackDepth = unchecked((uint)0x0D39),

    [NativeName("GL_MAX_VIEWPORT_DIMS")]
    MaxViewportDims = unchecked((uint)0x0D3A),

    [NativeName("GL_SUBPIXEL_BITS")]
    SubpixelBits = unchecked((uint)0x0D50),

    [NativeName("GL_RED_BITS")]
    RedBits = unchecked((uint)0x0D52),

    [NativeName("GL_GREEN_BITS")]
    GreenBits = unchecked((uint)0x0D53),

    [NativeName("GL_BLUE_BITS")]
    BlueBits = unchecked((uint)0x0D54),

    [NativeName("GL_ALPHA_BITS")]
    AlphaBits = unchecked((uint)0x0D55),

    [NativeName("GL_DEPTH_BITS")]
    DepthBits = unchecked((uint)0x0D56),

    [NativeName("GL_STENCIL_BITS")]
    StencilBits = unchecked((uint)0x0D57),

    [NativeName("GL_POLYGON_OFFSET_UNITS")]
    PolygonOffsetUnits = unchecked((uint)0x2A00),

    [NativeName("GL_POLYGON_OFFSET_FILL")]
    PolygonOffsetFill = unchecked((uint)0x8037),

    [NativeName("GL_POLYGON_OFFSET_FACTOR")]
    PolygonOffsetFactor = unchecked((uint)0x8038),

    [NativeName("GL_TEXTURE_BINDING_2D")]
    TextureBinding2D = unchecked((uint)0x8069),

    [NativeName("GL_VERTEX_ARRAY_SIZE")]
    VertexArraySize = unchecked((uint)0x807A),

    [NativeName("GL_VERTEX_ARRAY_TYPE")]
    VertexArrayType = unchecked((uint)0x807B),

    [NativeName("GL_VERTEX_ARRAY_STRIDE")]
    VertexArrayStride = unchecked((uint)0x807C),

    [NativeName("GL_NORMAL_ARRAY_TYPE")]
    NormalArrayType = unchecked((uint)0x807E),

    [NativeName("GL_NORMAL_ARRAY_STRIDE")]
    NormalArrayStride = unchecked((uint)0x807F),

    [NativeName("GL_COLOR_ARRAY_SIZE")]
    ColorArraySize = unchecked((uint)0x8081),

    [NativeName("GL_COLOR_ARRAY_TYPE")]
    ColorArrayType = unchecked((uint)0x8082),

    [NativeName("GL_COLOR_ARRAY_STRIDE")]
    ColorArrayStride = unchecked((uint)0x8083),

    [NativeName("GL_TEXTURE_COORD_ARRAY_SIZE")]
    TextureCoordArraySize = unchecked((uint)0x8088),

    [NativeName("GL_TEXTURE_COORD_ARRAY_TYPE")]
    TextureCoordArrayType = unchecked((uint)0x8089),

    [NativeName("GL_TEXTURE_COORD_ARRAY_STRIDE")]
    TextureCoordArrayStride = unchecked((uint)0x808A),

    [NativeName("GL_SAMPLE_BUFFERS")]
    SampleBuffers = unchecked((uint)0x80A8),

    [NativeName("GL_SAMPLES")]
    Samples = unchecked((uint)0x80A9),

    [NativeName("GL_SAMPLE_COVERAGE_VALUE")]
    SampleCoverageValue = unchecked((uint)0x80AA),

    [NativeName("GL_SAMPLE_COVERAGE_INVERT")]
    SampleCoverageInvert = unchecked((uint)0x80AB),

    [NativeName("GL_NUM_COMPRESSED_TEXTURE_FORMATS")]
    NumCompressedTextureFormats = unchecked((uint)0x86A2),

    [NativeName("GL_COMPRESSED_TEXTURE_FORMATS")]
    CompressedTextureFormats = unchecked((uint)0x86A3),

    [NativeName("GL_PERSPECTIVE_CORRECTION_HINT")]
    PerspectiveCorrectionHint = unchecked((uint)0x0C50),

    [NativeName("GL_POINT_SMOOTH_HINT")]
    PointSmoothHint = unchecked((uint)0x0C51),

    [NativeName("GL_LINE_SMOOTH_HINT")]
    LineSmoothHint = unchecked((uint)0x0C52),

    [NativeName("GL_FOG_HINT")]
    FogHint = unchecked((uint)0x0C54),

    [NativeName("GL_LIGHT_MODEL_AMBIENT")]
    LightModelAmbient = unchecked((uint)0x0B53),

    [NativeName("GL_LIGHT_MODEL_TWO_SIDE")]
    LightModelTwoSide = unchecked((uint)0x0B52),

    [NativeName("GL_UNPACK_ALIGNMENT")]
    UnpackAlignment = unchecked((uint)0x0CF5),

    [NativeName("GL_PACK_ALIGNMENT")]
    PackAlignment = unchecked((uint)0x0D05),

    [NativeName("GL_ACTIVE_TEXTURE")]
    ActiveTexture = unchecked((uint)0x84E0),

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

    [NativeName("GL_ARRAY_BUFFER_BINDING")]
    ArrayBufferBinding = unchecked((uint)0x8894),

    [NativeName("GL_ELEMENT_ARRAY_BUFFER_BINDING")]
    ElementArrayBufferBinding = unchecked((uint)0x8895),

    [NativeName("GL_ALPHA_SCALE")]
    AlphaScale = unchecked((uint)0x0D1C),

    [NativeName("GL_BLEND_EQUATION_OES")]
    BlendEquationOES = unchecked((uint)0x8009),

    [NativeName("GL_TEXTURE_BINDING_CUBE_MAP_OES")]
    TextureBindingCubeMapOES = unchecked((uint)0x8514),

    [NativeName("GL_MAX_CUBE_MAP_TEXTURE_SIZE_OES")]
    MaxCubeMapTextureSizeOES = unchecked((uint)0x851C),

    [NativeName("GL_TEXTURE_GEN_STR_OES")]
    TextureGenStrOES = unchecked((uint)0x8D60),

    [NativeName("GL_POINT_SIZE_RANGE")]
    PointSizeRange = unchecked((uint)0x0B12),

    [NativeName("GL_POINT_SIZE_GRANULARITY")]
    PointSizeGranularity = unchecked((uint)0x0B13),

    [NativeName("GL_LINE_WIDTH_RANGE")]
    LineWidthRange = unchecked((uint)0x0B22),

    [NativeName("GL_LINE_WIDTH_GRANULARITY")]
    LineWidthGranularity = unchecked((uint)0x0B23),

    [NativeName("GL_POLYGON_MODE")]
    PolygonMode = unchecked((uint)0x0B40),

    [NativeName("GL_POLYGON_SMOOTH")]
    PolygonSmooth = unchecked((uint)0x0B41),

    [NativeName("GL_DRAW_BUFFER")]
    DrawBuffer = unchecked((uint)0x0C01),

    [NativeName("GL_READ_BUFFER")]
    ReadBuffer = unchecked((uint)0x0C02),

    [NativeName("GL_DOUBLEBUFFER")]
    Doublebuffer = unchecked((uint)0x0C32),

    [NativeName("GL_STEREO")]
    Stereo = unchecked((uint)0x0C33),

    [NativeName("GL_POLYGON_SMOOTH_HINT")]
    PolygonSmoothHint = unchecked((uint)0x0C53),

    [NativeName("GL_UNPACK_SWAP_BYTES")]
    UnpackSwapBytes = unchecked((uint)0x0CF0),

    [NativeName("GL_UNPACK_LSB_FIRST")]
    UnpackLsbFirst = unchecked((uint)0x0CF1),

    [NativeName("GL_UNPACK_ROW_LENGTH")]
    UnpackRowLength = unchecked((uint)0x0CF2),

    [NativeName("GL_UNPACK_SKIP_ROWS")]
    UnpackSkipRows = unchecked((uint)0x0CF3),

    [NativeName("GL_UNPACK_SKIP_PIXELS")]
    UnpackSkipPixels = unchecked((uint)0x0CF4),

    [NativeName("GL_PACK_SWAP_BYTES")]
    PackSwapBytes = unchecked((uint)0x0D00),

    [NativeName("GL_PACK_LSB_FIRST")]
    PackLsbFirst = unchecked((uint)0x0D01),

    [NativeName("GL_PACK_ROW_LENGTH")]
    PackRowLength = unchecked((uint)0x0D02),

    [NativeName("GL_PACK_SKIP_ROWS")]
    PackSkipRows = unchecked((uint)0x0D03),

    [NativeName("GL_PACK_SKIP_PIXELS")]
    PackSkipPixels = unchecked((uint)0x0D04),

    [NativeName("GL_TEXTURE_1D")]
    Texture1D = unchecked((uint)0x0DE0),

    [NativeName("GL_CURRENT_INDEX")]
    CurrentIndex = unchecked((uint)0x0B01),

    [NativeName("GL_CURRENT_RASTER_COLOR")]
    CurrentRasterColor = unchecked((uint)0x0B04),

    [NativeName("GL_CURRENT_RASTER_INDEX")]
    CurrentRasterIndex = unchecked((uint)0x0B05),

    [NativeName("GL_CURRENT_RASTER_TEXTURE_COORDS")]
    CurrentRasterTextureCoords = unchecked((uint)0x0B06),

    [NativeName("GL_CURRENT_RASTER_POSITION")]
    CurrentRasterPosition = unchecked((uint)0x0B07),

    [NativeName("GL_CURRENT_RASTER_POSITION_VALID")]
    CurrentRasterPositionValid = unchecked((uint)0x0B08),

    [NativeName("GL_CURRENT_RASTER_DISTANCE")]
    CurrentRasterDistance = unchecked((uint)0x0B09),

    [NativeName("GL_LINE_STIPPLE")]
    LineStipple = unchecked((uint)0x0B24),

    [NativeName("GL_LINE_STIPPLE_PATTERN")]
    LineStipplePattern = unchecked((uint)0x0B25),

    [NativeName("GL_LINE_STIPPLE_REPEAT")]
    LineStippleRepeat = unchecked((uint)0x0B26),

    [NativeName("GL_LIST_MODE")]
    ListMode = unchecked((uint)0x0B30),

    [NativeName("GL_MAX_LIST_NESTING")]
    MaxListNesting = unchecked((uint)0x0B31),

    [NativeName("GL_LIST_BASE")]
    ListBase = unchecked((uint)0x0B32),

    [NativeName("GL_LIST_INDEX")]
    ListIndex = unchecked((uint)0x0B33),

    [NativeName("GL_POLYGON_STIPPLE")]
    PolygonStipple = unchecked((uint)0x0B42),

    [NativeName("GL_EDGE_FLAG")]
    EdgeFlag = unchecked((uint)0x0B43),

    [NativeName("GL_LIGHT_MODEL_LOCAL_VIEWER")]
    LightModelLocalViewer = unchecked((uint)0x0B51),

    [NativeName("GL_COLOR_MATERIAL_FACE")]
    ColorMaterialFace = unchecked((uint)0x0B55),

    [NativeName("GL_COLOR_MATERIAL_PARAMETER")]
    ColorMaterialParameter = unchecked((uint)0x0B56),

    [NativeName("GL_FOG_INDEX")]
    FogIndex = unchecked((uint)0x0B61),

    [NativeName("GL_ACCUM_CLEAR_VALUE")]
    AccumClearValue = unchecked((uint)0x0B80),

    [NativeName("GL_ATTRIB_STACK_DEPTH")]
    AttribStackDepth = unchecked((uint)0x0BB0),

    [NativeName("GL_LOGIC_OP")]
    LogicOp = unchecked((uint)0x0BF1),

    [NativeName("GL_AUX_BUFFERS")]
    AuxBuffers = unchecked((uint)0x0C00),

    [NativeName("GL_INDEX_CLEAR_VALUE")]
    IndexClearValue = unchecked((uint)0x0C20),

    [NativeName("GL_INDEX_WRITEMASK")]
    IndexWritemask = unchecked((uint)0x0C21),

    [NativeName("GL_INDEX_MODE")]
    IndexMode = unchecked((uint)0x0C30),

    [NativeName("GL_RGBA_MODE")]
    RgbaMode = unchecked((uint)0x0C31),

    [NativeName("GL_RENDER_MODE")]
    RenderMode = unchecked((uint)0x0C40),

    [NativeName("GL_TEXTURE_GEN_S")]
    TextureGenS = unchecked((uint)0x0C60),

    [NativeName("GL_TEXTURE_GEN_T")]
    TextureGenT = unchecked((uint)0x0C61),

    [NativeName("GL_TEXTURE_GEN_R")]
    TextureGenR = unchecked((uint)0x0C62),

    [NativeName("GL_TEXTURE_GEN_Q")]
    TextureGenQ = unchecked((uint)0x0C63),

    [NativeName("GL_PIXEL_MAP_I_TO_I_SIZE")]
    PixelMapIToISize = unchecked((uint)0x0CB0),

    [NativeName("GL_PIXEL_MAP_S_TO_S_SIZE")]
    PixelMapSToSSize = unchecked((uint)0x0CB1),

    [NativeName("GL_PIXEL_MAP_I_TO_R_SIZE")]
    PixelMapIToRSize = unchecked((uint)0x0CB2),

    [NativeName("GL_PIXEL_MAP_I_TO_G_SIZE")]
    PixelMapIToGSize = unchecked((uint)0x0CB3),

    [NativeName("GL_PIXEL_MAP_I_TO_B_SIZE")]
    PixelMapIToBSize = unchecked((uint)0x0CB4),

    [NativeName("GL_PIXEL_MAP_I_TO_A_SIZE")]
    PixelMapIToASize = unchecked((uint)0x0CB5),

    [NativeName("GL_PIXEL_MAP_R_TO_R_SIZE")]
    PixelMapRToRSize = unchecked((uint)0x0CB6),

    [NativeName("GL_PIXEL_MAP_G_TO_G_SIZE")]
    PixelMapGToGSize = unchecked((uint)0x0CB7),

    [NativeName("GL_PIXEL_MAP_B_TO_B_SIZE")]
    PixelMapBToBSize = unchecked((uint)0x0CB8),

    [NativeName("GL_PIXEL_MAP_A_TO_A_SIZE")]
    PixelMapAToASize = unchecked((uint)0x0CB9),

    [NativeName("GL_MAP_COLOR")]
    MapColor = unchecked((uint)0x0D10),

    [NativeName("GL_MAP_STENCIL")]
    MapStencil = unchecked((uint)0x0D11),

    [NativeName("GL_INDEX_SHIFT")]
    IndexShift = unchecked((uint)0x0D12),

    [NativeName("GL_INDEX_OFFSET")]
    IndexOffset = unchecked((uint)0x0D13),

    [NativeName("GL_RED_SCALE")]
    RedScale = unchecked((uint)0x0D14),

    [NativeName("GL_RED_BIAS")]
    RedBias = unchecked((uint)0x0D15),

    [NativeName("GL_ZOOM_X")]
    ZoomX = unchecked((uint)0x0D16),

    [NativeName("GL_ZOOM_Y")]
    ZoomY = unchecked((uint)0x0D17),

    [NativeName("GL_GREEN_SCALE")]
    GreenScale = unchecked((uint)0x0D18),

    [NativeName("GL_GREEN_BIAS")]
    GreenBias = unchecked((uint)0x0D19),

    [NativeName("GL_BLUE_SCALE")]
    BlueScale = unchecked((uint)0x0D1A),

    [NativeName("GL_BLUE_BIAS")]
    BlueBias = unchecked((uint)0x0D1B),

    [NativeName("GL_ALPHA_BIAS")]
    AlphaBias = unchecked((uint)0x0D1D),

    [NativeName("GL_DEPTH_SCALE")]
    DepthScale = unchecked((uint)0x0D1E),

    [NativeName("GL_DEPTH_BIAS")]
    DepthBias = unchecked((uint)0x0D1F),

    [NativeName("GL_MAX_EVAL_ORDER")]
    MaxEvalOrder = unchecked((uint)0x0D30),

    [NativeName("GL_MAX_PIXEL_MAP_TABLE")]
    MaxPixelMapTable = unchecked((uint)0x0D34),

    [NativeName("GL_MAX_ATTRIB_STACK_DEPTH")]
    MaxAttribStackDepth = unchecked((uint)0x0D35),

    [NativeName("GL_MAX_NAME_STACK_DEPTH")]
    MaxNameStackDepth = unchecked((uint)0x0D37),

    [NativeName("GL_INDEX_BITS")]
    IndexBits = unchecked((uint)0x0D51),

    [NativeName("GL_ACCUM_RED_BITS")]
    AccumRedBits = unchecked((uint)0x0D58),

    [NativeName("GL_ACCUM_GREEN_BITS")]
    AccumGreenBits = unchecked((uint)0x0D59),

    [NativeName("GL_ACCUM_BLUE_BITS")]
    AccumBlueBits = unchecked((uint)0x0D5A),

    [NativeName("GL_ACCUM_ALPHA_BITS")]
    AccumAlphaBits = unchecked((uint)0x0D5B),

    [NativeName("GL_NAME_STACK_DEPTH")]
    NameStackDepth = unchecked((uint)0x0D70),

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

    [NativeName("GL_MAP1_GRID_DOMAIN")]
    Map1GridDomain = unchecked((uint)0x0DD0),

    [NativeName("GL_MAP1_GRID_SEGMENTS")]
    Map1GridSegments = unchecked((uint)0x0DD1),

    [NativeName("GL_MAP2_GRID_DOMAIN")]
    Map2GridDomain = unchecked((uint)0x0DD2),

    [NativeName("GL_MAP2_GRID_SEGMENTS")]
    Map2GridSegments = unchecked((uint)0x0DD3),

    [NativeName("GL_POLYGON_OFFSET_POINT")]
    PolygonOffsetPoint = unchecked((uint)0x2A01),

    [NativeName("GL_POLYGON_OFFSET_LINE")]
    PolygonOffsetLine = unchecked((uint)0x2A02),

    [NativeName("GL_TEXTURE_BINDING_1D")]
    TextureBinding1D = unchecked((uint)0x8068),

    [NativeName("GL_CLIENT_ATTRIB_STACK_DEPTH")]
    ClientAttribStackDepth = unchecked((uint)0x0BB1),

    [NativeName("GL_INDEX_LOGIC_OP")]
    IndexLogicOp = unchecked((uint)0x0BF1),

    [NativeName("GL_MAX_CLIENT_ATTRIB_STACK_DEPTH")]
    MaxClientAttribStackDepth = unchecked((uint)0x0D3B),

    [NativeName("GL_FEEDBACK_BUFFER_SIZE")]
    FeedbackBufferSize = unchecked((uint)0x0DF1),

    [NativeName("GL_FEEDBACK_BUFFER_TYPE")]
    FeedbackBufferType = unchecked((uint)0x0DF2),

    [NativeName("GL_SELECTION_BUFFER_SIZE")]
    SelectionBufferSize = unchecked((uint)0x0DF4),

    [NativeName("GL_INDEX_ARRAY")]
    IndexArray = unchecked((uint)0x8077),

    [NativeName("GL_EDGE_FLAG_ARRAY")]
    EdgeFlagArray = unchecked((uint)0x8079),

    [NativeName("GL_INDEX_ARRAY_TYPE")]
    IndexArrayType = unchecked((uint)0x8085),

    [NativeName("GL_INDEX_ARRAY_STRIDE")]
    IndexArrayStride = unchecked((uint)0x8086),

    [NativeName("GL_EDGE_FLAG_ARRAY_STRIDE")]
    EdgeFlagArrayStride = unchecked((uint)0x808C),

    [NativeName("GL_TEXTURE_BINDING_3D")]
    TextureBinding3D = unchecked((uint)0x806A),

    [NativeName("GL_PACK_SKIP_IMAGES")]
    PackSkipImages = unchecked((uint)0x806B),

    [NativeName("GL_PACK_IMAGE_HEIGHT")]
    PackImageHeight = unchecked((uint)0x806C),

    [NativeName("GL_UNPACK_SKIP_IMAGES")]
    UnpackSkipImages = unchecked((uint)0x806D),

    [NativeName("GL_UNPACK_IMAGE_HEIGHT")]
    UnpackImageHeight = unchecked((uint)0x806E),

    [NativeName("GL_MAX_3D_TEXTURE_SIZE")]
    Max3DTextureSize = unchecked((uint)0x8073),

    [NativeName("GL_MAX_ELEMENTS_VERTICES")]
    MaxElementsVertices = unchecked((uint)0x80E8),

    [NativeName("GL_MAX_ELEMENTS_INDICES")]
    MaxElementsIndices = unchecked((uint)0x80E9),

    [NativeName("GL_SMOOTH_POINT_SIZE_GRANULARITY")]
    SmoothPointSizeGranularity = unchecked((uint)0x0B13),

    [NativeName("GL_SMOOTH_LINE_WIDTH_GRANULARITY")]
    SmoothLineWidthGranularity = unchecked((uint)0x0B23),

    [NativeName("GL_LIGHT_MODEL_COLOR_CONTROL")]
    LightModelColorControl = unchecked((uint)0x81F8),

    [NativeName("GL_TEXTURE_BINDING_CUBE_MAP")]
    TextureBindingCubeMap = unchecked((uint)0x8514),

    [NativeName("GL_MAX_CUBE_MAP_TEXTURE_SIZE")]
    MaxCubeMapTextureSize = unchecked((uint)0x851C),

    [NativeName("GL_TEXTURE_COMPRESSION_HINT")]
    TextureCompressionHint = unchecked((uint)0x84EF),

    [NativeName("GL_BLEND_DST_RGB")]
    BlendDstRgb = unchecked((uint)0x80C8),

    [NativeName("GL_BLEND_SRC_RGB")]
    BlendSrcRgb = unchecked((uint)0x80C9),

    [NativeName("GL_BLEND_DST_ALPHA")]
    BlendDstAlpha = unchecked((uint)0x80CA),

    [NativeName("GL_BLEND_SRC_ALPHA")]
    BlendSrcAlpha = unchecked((uint)0x80CB),

    [NativeName("GL_MAX_TEXTURE_LOD_BIAS")]
    MaxTextureLodBias = unchecked((uint)0x84FD),

    [NativeName("GL_BLEND_COLOR")]
    BlendColor = unchecked((uint)0x8005),

    [NativeName("GL_BLEND_EQUATION")]
    BlendEquation = unchecked((uint)0x8009),

    [NativeName("GL_BLEND_EQUATION_RGB")]
    BlendEquationRgb = unchecked((uint)0x8009),

    [NativeName("GL_STENCIL_BACK_FUNC")]
    StencilBackFunc = unchecked((uint)0x8800),

    [NativeName("GL_STENCIL_BACK_FAIL")]
    StencilBackFail = unchecked((uint)0x8801),

    [NativeName("GL_STENCIL_BACK_PASS_DEPTH_FAIL")]
    StencilBackPassDepthFail = unchecked((uint)0x8802),

    [NativeName("GL_STENCIL_BACK_PASS_DEPTH_PASS")]
    StencilBackPassDepthPass = unchecked((uint)0x8803),

    [NativeName("GL_MAX_DRAW_BUFFERS")]
    MaxDrawBuffers = unchecked((uint)0x8824),

    [NativeName("GL_BLEND_EQUATION_ALPHA")]
    BlendEquationAlpha = unchecked((uint)0x883D),

    [NativeName("GL_MAX_VERTEX_ATTRIBS")]
    MaxVertexAttribs = unchecked((uint)0x8869),

    [NativeName("GL_MAX_TEXTURE_IMAGE_UNITS")]
    MaxTextureImageUnits = unchecked((uint)0x8872),

    [NativeName("GL_MAX_FRAGMENT_UNIFORM_COMPONENTS")]
    MaxFragmentUniformComponents = unchecked((uint)0x8B49),

    [NativeName("GL_MAX_VERTEX_UNIFORM_COMPONENTS")]
    MaxVertexUniformComponents = unchecked((uint)0x8B4A),

    [NativeName("GL_MAX_VARYING_FLOATS")]
    MaxVaryingFloats = unchecked((uint)0x8B4B),

    [NativeName("GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS")]
    MaxVertexTextureImageUnits = unchecked((uint)0x8B4C),

    [NativeName("GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS")]
    MaxCombinedTextureImageUnits = unchecked((uint)0x8B4D),

    [NativeName("GL_FRAGMENT_SHADER_DERIVATIVE_HINT")]
    FragmentShaderDerivativeHint = unchecked((uint)0x8B8B),

    [NativeName("GL_CURRENT_PROGRAM")]
    CurrentProgram = unchecked((uint)0x8B8D),

    [NativeName("GL_STENCIL_BACK_REF")]
    StencilBackRef = unchecked((uint)0x8CA3),

    [NativeName("GL_STENCIL_BACK_VALUE_MASK")]
    StencilBackValueMask = unchecked((uint)0x8CA4),

    [NativeName("GL_STENCIL_BACK_WRITEMASK")]
    StencilBackWritemask = unchecked((uint)0x8CA5),

    [NativeName("GL_PIXEL_PACK_BUFFER_BINDING")]
    PixelPackBufferBinding = unchecked((uint)0x88ED),

    [NativeName("GL_PIXEL_UNPACK_BUFFER_BINDING")]
    PixelUnpackBufferBinding = unchecked((uint)0x88EF),

    [NativeName("GL_MAX_CLIP_DISTANCES")]
    MaxClipDistances = unchecked((uint)0x0D32),

    [NativeName("GL_MAJOR_VERSION")]
    MajorVersion = unchecked((uint)0x821B),

    [NativeName("GL_MINOR_VERSION")]
    MinorVersion = unchecked((uint)0x821C),

    [NativeName("GL_NUM_EXTENSIONS")]
    NumExtensions = unchecked((uint)0x821D),

    [NativeName("GL_CONTEXT_FLAGS")]
    ContextFlags = unchecked((uint)0x821E),

    [NativeName("GL_MAX_ARRAY_TEXTURE_LAYERS")]
    MaxArrayTextureLayers = unchecked((uint)0x88FF),

    [NativeName("GL_MIN_PROGRAM_TEXEL_OFFSET")]
    MinProgramTexelOffset = unchecked((uint)0x8904),

    [NativeName("GL_MAX_PROGRAM_TEXEL_OFFSET")]
    MaxProgramTexelOffset = unchecked((uint)0x8905),

    [NativeName("GL_MAX_VARYING_COMPONENTS")]
    MaxVaryingComponents = unchecked((uint)0x8B4B),

    [NativeName("GL_TEXTURE_BINDING_1D_ARRAY")]
    TextureBinding1DArray = unchecked((uint)0x8C1C),

    [NativeName("GL_TEXTURE_BINDING_2D_ARRAY")]
    TextureBinding2DArray = unchecked((uint)0x8C1D),

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_START")]
    TransformFeedbackBufferStart = unchecked((uint)0x8C84),

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_SIZE")]
    TransformFeedbackBufferSize = unchecked((uint)0x8C85),

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_BINDING")]
    TransformFeedbackBufferBinding = unchecked((uint)0x8C8F),

    [NativeName("GL_MAX_RENDERBUFFER_SIZE")]
    MaxRenderbufferSize = unchecked((uint)0x84E8),

    [NativeName("GL_DRAW_FRAMEBUFFER_BINDING")]
    DrawFramebufferBinding = unchecked((uint)0x8CA6),

    [NativeName("GL_RENDERBUFFER_BINDING")]
    RenderbufferBinding = unchecked((uint)0x8CA7),

    [NativeName("GL_READ_FRAMEBUFFER_BINDING")]
    ReadFramebufferBinding = unchecked((uint)0x8CAA),

    [NativeName("GL_MAX_COLOR_ATTACHMENTS")]
    MaxColorAttachments = unchecked((uint)0x8CDF),

    [NativeName("GL_VERTEX_ARRAY_BINDING")]
    VertexArrayBinding = unchecked((uint)0x85B5),

    [NativeName("GL_MAX_TEXTURE_BUFFER_SIZE")]
    MaxTextureBufferSize = unchecked((uint)0x8C2B),

    [NativeName("GL_TEXTURE_BINDING_BUFFER")]
    TextureBindingBuffer = unchecked((uint)0x8C2C),

    [NativeName("GL_TEXTURE_BINDING_RECTANGLE")]
    TextureBindingRectANGLE = unchecked((uint)0x84F6),

    [NativeName("GL_MAX_RECTANGLE_TEXTURE_SIZE")]
    MaxRectangleTextureSize = unchecked((uint)0x84F8),

    [NativeName("GL_PRIMITIVE_RESTART_INDEX")]
    PrimitiveRestartIndex = unchecked((uint)0x8F9E),

    [NativeName("GL_UNIFORM_BUFFER_BINDING")]
    UniformBufferBinding = unchecked((uint)0x8A28),

    [NativeName("GL_UNIFORM_BUFFER_START")]
    UniformBufferStart = unchecked((uint)0x8A29),

    [NativeName("GL_UNIFORM_BUFFER_SIZE")]
    UniformBufferSize = unchecked((uint)0x8A2A),

    [NativeName("GL_MAX_VERTEX_UNIFORM_BLOCKS")]
    MaxVertexUniformBlocks = unchecked((uint)0x8A2B),

    [NativeName("GL_MAX_GEOMETRY_UNIFORM_BLOCKS")]
    MaxGeometryUniformBlocks = unchecked((uint)0x8A2C),

    [NativeName("GL_MAX_FRAGMENT_UNIFORM_BLOCKS")]
    MaxFragmentUniformBlocks = unchecked((uint)0x8A2D),

    [NativeName("GL_MAX_COMBINED_UNIFORM_BLOCKS")]
    MaxCombinedUniformBlocks = unchecked((uint)0x8A2E),

    [NativeName("GL_MAX_UNIFORM_BUFFER_BINDINGS")]
    MaxUniformBufferBindings = unchecked((uint)0x8A2F),

    [NativeName("GL_MAX_UNIFORM_BLOCK_SIZE")]
    MaxUniformBlockSize = unchecked((uint)0x8A30),

    [NativeName("GL_MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS")]
    MaxCombinedVertexUniformComponents = unchecked((uint)0x8A31),

    [NativeName("GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS")]
    MaxCombinedGeometryUniformComponents = unchecked((uint)0x8A32),

    [NativeName("GL_MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS")]
    MaxCombinedFragmentUniformComponents = unchecked((uint)0x8A33),

    [NativeName("GL_UNIFORM_BUFFER_OFFSET_ALIGNMENT")]
    UniformBufferOffsetAlignment = unchecked((uint)0x8A34),

    [NativeName("GL_PROGRAM_POINT_SIZE")]
    ProgramPointSize = unchecked((uint)0x8642),

    [NativeName("GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS")]
    MaxGeometryTextureImageUnits = unchecked((uint)0x8C29),

    [NativeName("GL_MAX_GEOMETRY_UNIFORM_COMPONENTS")]
    MaxGeometryUniformComponents = unchecked((uint)0x8DDF),

    [NativeName("GL_MAX_VERTEX_OUTPUT_COMPONENTS")]
    MaxVertexOutputComponents = unchecked((uint)0x9122),

    [NativeName("GL_MAX_GEOMETRY_INPUT_COMPONENTS")]
    MaxGeometryInputComponents = unchecked((uint)0x9123),

    [NativeName("GL_MAX_GEOMETRY_OUTPUT_COMPONENTS")]
    MaxGeometryOutputComponents = unchecked((uint)0x9124),

    [NativeName("GL_MAX_FRAGMENT_INPUT_COMPONENTS")]
    MaxFragmentInputComponents = unchecked((uint)0x9125),

    [NativeName("GL_CONTEXT_PROFILE_MASK")]
    ContextProfileMask = unchecked((uint)0x9126),

    [NativeName("GL_PROVOKING_VERTEX")]
    ProvokingVertex = unchecked((uint)0x8E4F),

    [NativeName("GL_MAX_SERVER_WAIT_TIMEOUT")]
    MaxServerWaitTimeout = unchecked((uint)0x9111),

    [NativeName("GL_MAX_SAMPLE_MASK_WORDS")]
    MaxSampleMaskWords = unchecked((uint)0x8E59),

    [NativeName("GL_TEXTURE_BINDING_2D_MULTISAMPLE")]
    TextureBinding2DMultisample = unchecked((uint)0x9104),

    [NativeName("GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY")]
    TextureBinding2DMultisampleArray = unchecked((uint)0x9105),

    [NativeName("GL_MAX_COLOR_TEXTURE_SAMPLES")]
    MaxColorTextureSamples = unchecked((uint)0x910E),

    [NativeName("GL_MAX_DEPTH_TEXTURE_SAMPLES")]
    MaxDepthTextureSamples = unchecked((uint)0x910F),

    [NativeName("GL_MAX_INTEGER_SAMPLES")]
    MaxIntegerSamples = unchecked((uint)0x9110),

    [NativeName("GL_MAX_DUAL_SOURCE_DRAW_BUFFERS")]
    MaxDualSourceDrawBuffers = unchecked((uint)0x88FC),

    [NativeName("GL_SAMPLER_BINDING")]
    SamplerBinding = unchecked((uint)0x8919),

    [NativeName("GL_TIMESTAMP")]
    Timestamp = unchecked((uint)0x8E28),

    [NativeName("GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS")]
    MaxTessControlUniformBlocks = unchecked((uint)0x8E89),

    [NativeName("GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS")]
    MaxTessEvaluationUniformBlocks = unchecked((uint)0x8E8A),

    [NativeName("GL_IMPLEMENTATION_COLOR_READ_TYPE")]
    ImplementationColorReadType = unchecked((uint)0x8B9A),

    [NativeName("GL_IMPLEMENTATION_COLOR_READ_FORMAT")]
    ImplementationColorReadFormat = unchecked((uint)0x8B9B),

    [NativeName("GL_SHADER_COMPILER")]
    ShaderCompiler = unchecked((uint)0x8DFA),

    [NativeName("GL_SHADER_BINARY_FORMATS")]
    ShaderBinaryFormats = unchecked((uint)0x8DF8),

    [NativeName("GL_NUM_SHADER_BINARY_FORMATS")]
    NumShaderBinaryFormats = unchecked((uint)0x8DF9),

    [NativeName("GL_MAX_VERTEX_UNIFORM_VECTORS")]
    MaxVertexUniformVectors = unchecked((uint)0x8DFB),

    [NativeName("GL_MAX_VARYING_VECTORS")]
    MaxVaryingVectors = unchecked((uint)0x8DFC),

    [NativeName("GL_MAX_FRAGMENT_UNIFORM_VECTORS")]
    MaxFragmentUniformVectors = unchecked((uint)0x8DFD),

    [NativeName("GL_NUM_PROGRAM_BINARY_FORMATS")]
    NumProgramBinaryFormats = unchecked((uint)0x87FE),

    [NativeName("GL_PROGRAM_BINARY_FORMATS")]
    ProgramBinaryFormats = unchecked((uint)0x87FF),

    [NativeName("GL_PROGRAM_PIPELINE_BINDING")]
    ProgramPipelineBinding = unchecked((uint)0x825A),

    [NativeName("GL_MAX_VIEWPORTS")]
    MaxViewports = unchecked((uint)0x825B),

    [NativeName("GL_VIEWPORT_SUBPIXEL_BITS")]
    ViewportSubpixelBits = unchecked((uint)0x825C),

    [NativeName("GL_VIEWPORT_BOUNDS_RANGE")]
    ViewportBoundsRange = unchecked((uint)0x825D),

    [NativeName("GL_LAYER_PROVOKING_VERTEX")]
    LayerProvokingVertex = unchecked((uint)0x825E),

    [NativeName("GL_VIEWPORT_INDEX_PROVOKING_VERTEX")]
    ViewportIndexProvokingVertex = unchecked((uint)0x825F),

    [NativeName("GL_MIN_MAP_BUFFER_ALIGNMENT")]
    MinMapBufferAlignment = unchecked((uint)0x90BC),

    [NativeName("GL_MAX_VERTEX_ATOMIC_COUNTERS")]
    MaxVertexAtomicCounters = unchecked((uint)0x92D2),

    [NativeName("GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS")]
    MaxTessControlAtomicCounters = unchecked((uint)0x92D3),

    [NativeName("GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS")]
    MaxTessEvaluationAtomicCounters = unchecked((uint)0x92D4),

    [NativeName("GL_MAX_GEOMETRY_ATOMIC_COUNTERS")]
    MaxGeometryAtomicCounters = unchecked((uint)0x92D5),

    [NativeName("GL_MAX_FRAGMENT_ATOMIC_COUNTERS")]
    MaxFragmentAtomicCounters = unchecked((uint)0x92D6),

    [NativeName("GL_MAX_COMBINED_ATOMIC_COUNTERS")]
    MaxCombinedAtomicCounters = unchecked((uint)0x92D7),

    [NativeName("GL_MAX_ELEMENT_INDEX")]
    MaxElementIndex = unchecked((uint)0x8D6B),

    [NativeName("GL_MAX_COMPUTE_UNIFORM_BLOCKS")]
    MaxComputeUniformBlocks = unchecked((uint)0x91BB),

    [NativeName("GL_MAX_COMPUTE_TEXTURE_IMAGE_UNITS")]
    MaxComputeTextureImageUnits = unchecked((uint)0x91BC),

    [NativeName("GL_MAX_COMPUTE_UNIFORM_COMPONENTS")]
    MaxComputeUniformComponents = unchecked((uint)0x8263),

    [NativeName("GL_MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS")]
    MaxComputeAtomicCounterBuffers = unchecked((uint)0x8264),

    [NativeName("GL_MAX_COMPUTE_ATOMIC_COUNTERS")]
    MaxComputeAtomicCounters = unchecked((uint)0x8265),

    [NativeName("GL_MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS")]
    MaxCombinedComputeUniformComponents = unchecked((uint)0x8266),

    [NativeName("GL_MAX_COMPUTE_WORK_GROUP_INVOCATIONS")]
    MaxComputeWorkGroupInvocations = unchecked((uint)0x90EB),

    [NativeName("GL_MAX_COMPUTE_WORK_GROUP_COUNT")]
    MaxComputeWorkGroupCount = unchecked((uint)0x91BE),

    [NativeName("GL_MAX_COMPUTE_WORK_GROUP_SIZE")]
    MaxComputeWorkGroupSize = unchecked((uint)0x91BF),

    [NativeName("GL_DISPATCH_INDIRECT_BUFFER_BINDING")]
    DispatchIndirectBufferBinding = unchecked((uint)0x90EF),

    [NativeName("GL_MAX_DEBUG_GROUP_STACK_DEPTH")]
    MaxDebugGroupStackDepth = unchecked((uint)0x826C),

    [NativeName("GL_DEBUG_GROUP_STACK_DEPTH")]
    DebugGroupStackDepth = unchecked((uint)0x826D),

    [NativeName("GL_MAX_LABEL_LENGTH")]
    MaxLabelLength = unchecked((uint)0x82E8),

    [NativeName("GL_MAX_UNIFORM_LOCATIONS")]
    MaxUniformLocations = unchecked((uint)0x826E),

    [NativeName("GL_MAX_FRAMEBUFFER_WIDTH")]
    MaxFramebufferWidth = unchecked((uint)0x9315),

    [NativeName("GL_MAX_FRAMEBUFFER_HEIGHT")]
    MaxFramebufferHeight = unchecked((uint)0x9316),

    [NativeName("GL_MAX_FRAMEBUFFER_LAYERS")]
    MaxFramebufferLayers = unchecked((uint)0x9317),

    [NativeName("GL_MAX_FRAMEBUFFER_SAMPLES")]
    MaxFramebufferSamples = unchecked((uint)0x9318),

    [NativeName("GL_SHADER_STORAGE_BUFFER_BINDING")]
    ShaderStorageBufferBinding = unchecked((uint)0x90D3),

    [NativeName("GL_SHADER_STORAGE_BUFFER_START")]
    ShaderStorageBufferStart = unchecked((uint)0x90D4),

    [NativeName("GL_SHADER_STORAGE_BUFFER_SIZE")]
    ShaderStorageBufferSize = unchecked((uint)0x90D5),

    [NativeName("GL_MAX_VERTEX_SHADER_STORAGE_BLOCKS")]
    MaxVertexShaderStorageBlocks = unchecked((uint)0x90D6),

    [NativeName("GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS")]
    MaxGeometryShaderStorageBlocks = unchecked((uint)0x90D7),

    [NativeName("GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS")]
    MaxTessControlShaderStorageBlocks = unchecked((uint)0x90D8),

    [NativeName("GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS")]
    MaxTessEvaluationShaderStorageBlocks = unchecked((uint)0x90D9),

    [NativeName("GL_MAX_FRAGMENT_SHADER_STORAGE_BLOCKS")]
    MaxFragmentShaderStorageBlocks = unchecked((uint)0x90DA),

    [NativeName("GL_MAX_COMPUTE_SHADER_STORAGE_BLOCKS")]
    MaxComputeShaderStorageBlocks = unchecked((uint)0x90DB),

    [NativeName("GL_MAX_COMBINED_SHADER_STORAGE_BLOCKS")]
    MaxCombinedShaderStorageBlocks = unchecked((uint)0x90DC),

    [NativeName("GL_MAX_SHADER_STORAGE_BUFFER_BINDINGS")]
    MaxShaderStorageBufferBindings = unchecked((uint)0x90DD),

    [NativeName("GL_SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT")]
    ShaderStorageBufferOffsetAlignment = unchecked((uint)0x90DF),

    [NativeName("GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT")]
    TextureBufferOffsetAlignment = unchecked((uint)0x919F),

    [NativeName("GL_VERTEX_BINDING_DIVISOR")]
    VertexBindingDivisor = unchecked((uint)0x82D6),

    [NativeName("GL_VERTEX_BINDING_OFFSET")]
    VertexBindingOffset = unchecked((uint)0x82D7),

    [NativeName("GL_VERTEX_BINDING_STRIDE")]
    VertexBindingStride = unchecked((uint)0x82D8),

    [NativeName("GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET")]
    MaxVertexAttribRelativeOffset = unchecked((uint)0x82D9),

    [NativeName("GL_MAX_VERTEX_ATTRIB_BINDINGS")]
    MaxVertexAttribBindings = unchecked((uint)0x82DA),

    [NativeName("GL_POINT_SIZE_MIN_ARB")]
    PointSizeMinARB = unchecked((uint)0x8126),

    [NativeName("GL_POINT_SIZE_MAX_ARB")]
    PointSizeMaxARB = unchecked((uint)0x8127),

    [NativeName("GL_POINT_FADE_THRESHOLD_SIZE_ARB")]
    PointFadeThresholdSizeARB = unchecked((uint)0x8128),

    [NativeName("GL_POINT_DISTANCE_ATTENUATION_ARB")]
    PointDistanceAttenuationARB = unchecked((uint)0x8129),

    [NativeName("GL_TEXTURE_BINDING_CUBE_MAP_ARB")]
    TextureBindingCubeMapARB = unchecked((uint)0x8514),

    [NativeName("GL_MAX_CUBE_MAP_TEXTURE_SIZE_ARB")]
    MaxCubeMapTextureSizeARB = unchecked((uint)0x851C),

    [NativeName("GL_TEXTURE_BINDING_RECTANGLE_ARB")]
    TextureBindingRectangleARB = unchecked((uint)0x84F6),

    [NativeName("GL_FRAGMENT_SHADER_ATI")]
    FragmentShaderATI = unchecked((uint)0x8920),

    [NativeName("GL_BLEND_COLOR_EXT")]
    BlendColorEXT = unchecked((uint)0x8005),

    [NativeName("GL_BLEND_EQUATION_EXT")]
    BlendEquationEXT = unchecked((uint)0x8009),

    [NativeName("GL_PACK_CMYK_HINT_EXT")]
    PackCmykHintEXT = unchecked((uint)0x800E),

    [NativeName("GL_UNPACK_CMYK_HINT_EXT")]
    UnpackCmykHintEXT = unchecked((uint)0x800F),

    [NativeName("GL_CONVOLUTION_1D_EXT")]
    Convolution1DEXT = unchecked((uint)0x8010),

    [NativeName("GL_CONVOLUTION_2D_EXT")]
    Convolution2DEXT = unchecked((uint)0x8011),

    [NativeName("GL_SEPARABLE_2D_EXT")]
    Separable2DEXT = unchecked((uint)0x8012),

    [NativeName("GL_POST_CONVOLUTION_RED_SCALE_EXT")]
    PostConvolutionRedScaleEXT = unchecked((uint)0x801C),

    [NativeName("GL_POST_CONVOLUTION_GREEN_SCALE_EXT")]
    PostConvolutionGreenScaleEXT = unchecked((uint)0x801D),

    [NativeName("GL_POST_CONVOLUTION_BLUE_SCALE_EXT")]
    PostConvolutionBlueScaleEXT = unchecked((uint)0x801E),

    [NativeName("GL_POST_CONVOLUTION_ALPHA_SCALE_EXT")]
    PostConvolutionAlphaScaleEXT = unchecked((uint)0x801F),

    [NativeName("GL_POST_CONVOLUTION_RED_BIAS_EXT")]
    PostConvolutionRedBiasEXT = unchecked((uint)0x8020),

    [NativeName("GL_POST_CONVOLUTION_GREEN_BIAS_EXT")]
    PostConvolutionGreenBiasEXT = unchecked((uint)0x8021),

    [NativeName("GL_POST_CONVOLUTION_BLUE_BIAS_EXT")]
    PostConvolutionBlueBiasEXT = unchecked((uint)0x8022),

    [NativeName("GL_POST_CONVOLUTION_ALPHA_BIAS_EXT")]
    PostConvolutionAlphaBiasEXT = unchecked((uint)0x8023),

    [NativeName("GL_MAX_COLOR_ATTACHMENTS_EXT")]
    MaxColorAttachmentsEXT = unchecked((uint)0x8CDF),

    [NativeName("GL_HISTOGRAM_EXT")]
    HistogramEXT = unchecked((uint)0x8024),

    [NativeName("GL_MINMAX_EXT")]
    MinmaxEXT = unchecked((uint)0x802E),

    [NativeName("GL_NUM_DEVICE_UUIDS_EXT")]
    NumDeviceUuidsEXT = unchecked((uint)0x9596),

    [NativeName("GL_DEVICE_UUID_EXT")]
    DeviceUuidEXT = unchecked((uint)0x9597),

    [NativeName("GL_DRIVER_UUID_EXT")]
    DriverUuidEXT = unchecked((uint)0x9598),

    [NativeName("GL_DEVICE_LUID_EXT")]
    DeviceLuidEXT = unchecked((uint)0x9599),

    [NativeName("GL_DEVICE_NODE_MASK_EXT")]
    DeviceNodeMaskEXT = unchecked((uint)0x959A),

    [NativeName("GL_POINT_SIZE_MIN_EXT")]
    PointSizeMinEXT = unchecked((uint)0x8126),

    [NativeName("GL_POINT_SIZE_MAX_EXT")]
    PointSizeMaxEXT = unchecked((uint)0x8127),

    [NativeName("GL_POINT_FADE_THRESHOLD_SIZE_EXT")]
    PointFadeThresholdSizeEXT = unchecked((uint)0x8128),

    [NativeName("GL_DISTANCE_ATTENUATION_EXT")]
    DistanceAttenuationEXT = unchecked((uint)0x8129),

    [NativeName("GL_POLYGON_OFFSET_BIAS_EXT")]
    PolygonOffsetBiasEXT = unchecked((uint)0x8039),

    [NativeName("GL_RESCALE_NORMAL_EXT")]
    RescaleNormalEXT = unchecked((uint)0x803A),

    [NativeName("GL_SHARED_TEXTURE_PALETTE_EXT")]
    SharedTexturePaletteEXT = unchecked((uint)0x81FB),

    [NativeName("GL_PACK_SKIP_IMAGES_EXT")]
    PackSkipImagesEXT = unchecked((uint)0x806B),

    [NativeName("GL_PACK_IMAGE_HEIGHT_EXT")]
    PackImageHeightEXT = unchecked((uint)0x806C),

    [NativeName("GL_UNPACK_SKIP_IMAGES_EXT")]
    UnpackSkipImagesEXT = unchecked((uint)0x806D),

    [NativeName("GL_UNPACK_IMAGE_HEIGHT_EXT")]
    UnpackImageHeightEXT = unchecked((uint)0x806E),

    [NativeName("GL_TEXTURE_3D_EXT")]
    Texture3DEXT = unchecked((uint)0x806F),

    [NativeName("GL_MAX_3D_TEXTURE_SIZE_EXT")]
    Max3DTextureSizeEXT = unchecked((uint)0x8073),

    [NativeName("GL_TEXTURE_BINDING_CUBE_MAP_EXT")]
    TextureBindingCubeMapEXT = unchecked((uint)0x8514),

    [NativeName("GL_MAX_CUBE_MAP_TEXTURE_SIZE_EXT")]
    MaxCubeMapTextureSizeEXT = unchecked((uint)0x851C),

    [NativeName("GL_TEXTURE_3D_BINDING_EXT")]
    Texture3DBindingEXT = unchecked((uint)0x806A),

    [NativeName("GL_VERTEX_ARRAY_COUNT_EXT")]
    VertexArrayCountEXT = unchecked((uint)0x807D),

    [NativeName("GL_NORMAL_ARRAY_COUNT_EXT")]
    NormalArrayCountEXT = unchecked((uint)0x8080),

    [NativeName("GL_COLOR_ARRAY_COUNT_EXT")]
    ColorArrayCountEXT = unchecked((uint)0x8084),

    [NativeName("GL_INDEX_ARRAY_COUNT_EXT")]
    IndexArrayCountEXT = unchecked((uint)0x8087),

    [NativeName("GL_TEXTURE_COORD_ARRAY_COUNT_EXT")]
    TextureCoordArrayCountEXT = unchecked((uint)0x808B),

    [NativeName("GL_EDGE_FLAG_ARRAY_COUNT_EXT")]
    EdgeFlagArrayCountEXT = unchecked((uint)0x808D),

    [NativeName("GL_MODELVIEW0_STACK_DEPTH_EXT")]
    Modelview0StackDepthEXT = unchecked((uint)0x0BA3),

    [NativeName("GL_MODELVIEW0_MATRIX_EXT")]
    Modelview0MatrixEXT = unchecked((uint)0x0BA6),

    [NativeName("GL_SHADING_RATE_IMAGE_PER_PRIMITIVE_NV")]
    ShadingRateImagePerPrimitiveNV = unchecked((uint)0x95B1),

    [NativeName("GL_SHADING_RATE_IMAGE_PALETTE_COUNT_NV")]
    ShadingRateImagePaletteCountNV = unchecked((uint)0x95B2),

    [NativeName("GL_TEXTURE_BINDING_RECTANGLE_NV")]
    TextureBindingRectangleNV = unchecked((uint)0x84F6),

    [NativeName("GL_MAX_TIMELINE_SEMAPHORE_VALUE_DIFFERENCE_NV")]
    MaxTimelineSemaphoreValueDifferenceNV = unchecked((uint)0x95B6),

    [NativeName("GL_DETAIL_TEXTURE_2D_BINDING_SGIS")]
    DetailTexture2DBindingSGIS = unchecked((uint)0x8096),

    [NativeName("GL_FOG_FUNC_POINTS_SGIS")]
    FogFuncPointsSGIS = unchecked((uint)0x812B),

    [NativeName("GL_MAX_FOG_FUNC_POINTS_SGIS")]
    MaxFogFuncPointsSGIS = unchecked((uint)0x812C),

    [NativeName("GL_GENERATE_MIPMAP_HINT_SGIS")]
    GenerateMipmapHintSGIS = unchecked((uint)0x8192),

    [NativeName("GL_MULTISAMPLE_SGIS")]
    MultisampleSGIS = unchecked((uint)0x809D),

    [NativeName("GL_SAMPLE_ALPHA_TO_MASK_SGIS")]
    SampleAlphaToMaskSGIS = unchecked((uint)0x809E),

    [NativeName("GL_SAMPLE_ALPHA_TO_ONE_SGIS")]
    SampleAlphaToOneSGIS = unchecked((uint)0x809F),

    [NativeName("GL_SAMPLE_MASK_SGIS")]
    SampleMaskSGIS = unchecked((uint)0x80A0),

    [NativeName("GL_SAMPLE_BUFFERS_SGIS")]
    SampleBuffersSGIS = unchecked((uint)0x80A8),

    [NativeName("GL_SAMPLES_SGIS")]
    SamplesSGIS = unchecked((uint)0x80A9),

    [NativeName("GL_SAMPLE_MASK_VALUE_SGIS")]
    SampleMaskValueSGIS = unchecked((uint)0x80AA),

    [NativeName("GL_SAMPLE_MASK_INVERT_SGIS")]
    SampleMaskInvertSGIS = unchecked((uint)0x80AB),

    [NativeName("GL_SAMPLE_PATTERN_SGIS")]
    SamplePatternSGIS = unchecked((uint)0x80AC),

    [NativeName("GL_PIXEL_TEXTURE_SGIS")]
    PixelTextureSGIS = unchecked((uint)0x8353),

    [NativeName("GL_POINT_SIZE_MIN_SGIS")]
    PointSizeMinSGIS = unchecked((uint)0x8126),

    [NativeName("GL_POINT_SIZE_MAX_SGIS")]
    PointSizeMaxSGIS = unchecked((uint)0x8127),

    [NativeName("GL_POINT_FADE_THRESHOLD_SIZE_SGIS")]
    PointFadeThresholdSizeSGIS = unchecked((uint)0x8128),

    [NativeName("GL_DISTANCE_ATTENUATION_SGIS")]
    DistanceAttenuationSGIS = unchecked((uint)0x8129),

    [NativeName("GL_PACK_SKIP_VOLUMES_SGIS")]
    PackSkipVolumesSGIS = unchecked((uint)0x8130),

    [NativeName("GL_PACK_IMAGE_DEPTH_SGIS")]
    PackImageDepthSGIS = unchecked((uint)0x8131),

    [NativeName("GL_UNPACK_SKIP_VOLUMES_SGIS")]
    UnpackSkipVolumesSGIS = unchecked((uint)0x8132),

    [NativeName("GL_UNPACK_IMAGE_DEPTH_SGIS")]
    UnpackImageDepthSGIS = unchecked((uint)0x8133),

    [NativeName("GL_TEXTURE_4D_SGIS")]
    Texture4DSGIS = unchecked((uint)0x8134),

    [NativeName("GL_MAX_4D_TEXTURE_SIZE_SGIS")]
    Max4DTextureSizeSGIS = unchecked((uint)0x8138),

    [NativeName("GL_TEXTURE_4D_BINDING_SGIS")]
    Texture4DBindingSGIS = unchecked((uint)0x814F),

    [NativeName("GL_ASYNC_MARKER_SGIX")]
    AsyncMarkerSGIX = unchecked((uint)0x8329),

    [NativeName("GL_ASYNC_HISTOGRAM_SGIX")]
    AsyncHistogramSGIX = unchecked((uint)0x832C),

    [NativeName("GL_MAX_ASYNC_HISTOGRAM_SGIX")]
    MaxAsyncHistogramSGIX = unchecked((uint)0x832D),

    [NativeName("GL_ASYNC_TEX_IMAGE_SGIX")]
    AsyncTexImageSGIX = unchecked((uint)0x835C),

    [NativeName("GL_ASYNC_DRAW_PIXELS_SGIX")]
    AsyncDrawPixelsSGIX = unchecked((uint)0x835D),

    [NativeName("GL_ASYNC_READ_PIXELS_SGIX")]
    AsyncReadPixelsSGIX = unchecked((uint)0x835E),

    [NativeName("GL_MAX_ASYNC_TEX_IMAGE_SGIX")]
    MaxAsyncTexImageSGIX = unchecked((uint)0x835F),

    [NativeName("GL_MAX_ASYNC_DRAW_PIXELS_SGIX")]
    MaxAsyncDrawPixelsSGIX = unchecked((uint)0x8360),

    [NativeName("GL_MAX_ASYNC_READ_PIXELS_SGIX")]
    MaxAsyncReadPixelsSGIX = unchecked((uint)0x8361),

    [NativeName("GL_CALLIGRAPHIC_FRAGMENT_SGIX")]
    CalligraphicFragmentSGIX = unchecked((uint)0x8183),

    [NativeName("GL_MAX_CLIPMAP_DEPTH_SGIX")]
    MaxClipmapDepthSGIX = unchecked((uint)0x8177),

    [NativeName("GL_MAX_CLIPMAP_VIRTUAL_DEPTH_SGIX")]
    MaxClipmapVirtualDepthSGIX = unchecked((uint)0x8178),

    [NativeName("GL_CONVOLUTION_HINT_SGIX")]
    ConvolutionHintSGIX = unchecked((uint)0x8316),

    [NativeName("GL_FOG_OFFSET_SGIX")]
    FogOffsetSGIX = unchecked((uint)0x8198),

    [NativeName("GL_FOG_OFFSET_VALUE_SGIX")]
    FogOffsetValueSGIX = unchecked((uint)0x8199),

    [NativeName("GL_FRAGMENT_LIGHTING_SGIX")]
    FragmentLightingSGIX = unchecked((uint)0x8400),

    [NativeName("GL_FRAGMENT_COLOR_MATERIAL_SGIX")]
    FragmentColorMaterialSGIX = unchecked((uint)0x8401),

    [NativeName("GL_FRAGMENT_COLOR_MATERIAL_FACE_SGIX")]
    FragmentColorMaterialFaceSGIX = unchecked((uint)0x8402),

    [NativeName("GL_FRAGMENT_COLOR_MATERIAL_PARAMETER_SGIX")]
    FragmentColorMaterialParameterSGIX = unchecked((uint)0x8403),

    [NativeName("GL_MAX_FRAGMENT_LIGHTS_SGIX")]
    MaxFragmentLightsSGIX = unchecked((uint)0x8404),

    [NativeName("GL_MAX_ACTIVE_LIGHTS_SGIX")]
    MaxActiveLightsSGIX = unchecked((uint)0x8405),

    [NativeName("GL_LIGHT_ENV_MODE_SGIX")]
    LightEnvModeSGIX = unchecked((uint)0x8407),

    [NativeName("GL_FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX")]
    FragmentLightModelLocalViewerSGIX = unchecked((uint)0x8408),

    [NativeName("GL_FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX")]
    FragmentLightModelTwoSideSGIX = unchecked((uint)0x8409),

    [NativeName("GL_FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX")]
    FragmentLightModelAmbientSGIX = unchecked((uint)0x840A),

    [NativeName("GL_FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX")]
    FragmentLightModelNormalInterpolationSGIX = unchecked((uint)0x840B),

    [NativeName("GL_FRAGMENT_LIGHT0_SGIX")]
    FragmentLight0SGIX = unchecked((uint)0x840C),

    [NativeName("GL_FRAMEZOOM_SGIX")]
    FramezoomSGIX = unchecked((uint)0x818B),

    [NativeName("GL_FRAMEZOOM_FACTOR_SGIX")]
    FramezoomFactorSGIX = unchecked((uint)0x818C),

    [NativeName("GL_MAX_FRAMEZOOM_FACTOR_SGIX")]
    MaxFramezoomFactorSGIX = unchecked((uint)0x818D),

    [NativeName("GL_INSTRUMENT_MEASUREMENTS_SGIX")]
    InstrumentMeasurementsSGIX = unchecked((uint)0x8181),

    [NativeName("GL_INTERLACE_SGIX")]
    InterlaceSGIX = unchecked((uint)0x8094),

    [NativeName("GL_IR_INSTRUMENT1_SGIX")]
    IrInstrument1SGIX = unchecked((uint)0x817F),

    [NativeName("GL_PIXEL_TEX_GEN_SGIX")]
    PixelTexGenSGIX = unchecked((uint)0x8139),

    [NativeName("GL_PIXEL_TEX_GEN_MODE_SGIX")]
    PixelTexGenModeSGIX = unchecked((uint)0x832B),

    [NativeName("GL_PIXEL_TILE_BEST_ALIGNMENT_SGIX")]
    PixelTileBestAlignmentSGIX = unchecked((uint)0x813E),

    [NativeName("GL_PIXEL_TILE_CACHE_INCREMENT_SGIX")]
    PixelTileCacheIncrementSGIX = unchecked((uint)0x813F),

    [NativeName("GL_PIXEL_TILE_WIDTH_SGIX")]
    PixelTileWidthSGIX = unchecked((uint)0x8140),

    [NativeName("GL_PIXEL_TILE_HEIGHT_SGIX")]
    PixelTileHeightSGIX = unchecked((uint)0x8141),

    [NativeName("GL_PIXEL_TILE_GRID_WIDTH_SGIX")]
    PixelTileGridWidthSGIX = unchecked((uint)0x8142),

    [NativeName("GL_PIXEL_TILE_GRID_HEIGHT_SGIX")]
    PixelTileGridHeightSGIX = unchecked((uint)0x8143),

    [NativeName("GL_PIXEL_TILE_GRID_DEPTH_SGIX")]
    PixelTileGridDepthSGIX = unchecked((uint)0x8144),

    [NativeName("GL_PIXEL_TILE_CACHE_SIZE_SGIX")]
    PixelTileCacheSizeSGIX = unchecked((uint)0x8145),

    [NativeName("GL_DEFORMATIONS_MASK_SGIX")]
    DeformationsMaskSGIX = unchecked((uint)0x8196),

    [NativeName("GL_REFERENCE_PLANE_SGIX")]
    ReferencePlaneSGIX = unchecked((uint)0x817D),

    [NativeName("GL_REFERENCE_PLANE_EQUATION_SGIX")]
    ReferencePlaneEquationSGIX = unchecked((uint)0x817E),

    [NativeName("GL_PACK_RESAMPLE_SGIX")]
    PackResampleSGIX = unchecked((uint)0x842E),

    [NativeName("GL_UNPACK_RESAMPLE_SGIX")]
    UnpackResampleSGIX = unchecked((uint)0x842F),

    [NativeName("GL_SPRITE_SGIX")]
    SpriteSGIX = unchecked((uint)0x8148),

    [NativeName("GL_SPRITE_MODE_SGIX")]
    SpriteModeSGIX = unchecked((uint)0x8149),

    [NativeName("GL_SPRITE_AXIS_SGIX")]
    SpriteAxisSGIX = unchecked((uint)0x814A),

    [NativeName("GL_SPRITE_TRANSLATION_SGIX")]
    SpriteTranslationSGIX = unchecked((uint)0x814B),

    [NativeName("GL_PACK_SUBSAMPLE_RATE_SGIX")]
    PackSubsampleRateSGIX = unchecked((uint)0x85A0),

    [NativeName("GL_UNPACK_SUBSAMPLE_RATE_SGIX")]
    UnpackSubsampleRateSGIX = unchecked((uint)0x85A1),

    [NativeName("GL_POST_TEXTURE_FILTER_BIAS_RANGE_SGIX")]
    PostTextureFilterBiasRangeSGIX = unchecked((uint)0x817B),

    [NativeName("GL_POST_TEXTURE_FILTER_SCALE_RANGE_SGIX")]
    PostTextureFilterScaleRangeSGIX = unchecked((uint)0x817C),

    [NativeName("GL_VERTEX_PRECLIP_SGIX")]
    VertexPreclipSGIX = unchecked((uint)0x83EE),

    [NativeName("GL_VERTEX_PRECLIP_HINT_SGIX")]
    VertexPreclipHintSGIX = unchecked((uint)0x83EF),

    [NativeName("GL_COLOR_MATRIX_SGI")]
    ColorMatrixSGI = unchecked((uint)0x80B1),

    [NativeName("GL_COLOR_MATRIX_STACK_DEPTH_SGI")]
    ColorMatrixStackDepthSGI = unchecked((uint)0x80B2),

    [NativeName("GL_MAX_COLOR_MATRIX_STACK_DEPTH_SGI")]
    MaxColorMatrixStackDepthSGI = unchecked((uint)0x80B3),

    [NativeName("GL_POST_COLOR_MATRIX_RED_SCALE_SGI")]
    PostColorMatrixRedScaleSGI = unchecked((uint)0x80B4),

    [NativeName("GL_POST_COLOR_MATRIX_GREEN_SCALE_SGI")]
    PostColorMatrixGreenScaleSGI = unchecked((uint)0x80B5),

    [NativeName("GL_POST_COLOR_MATRIX_BLUE_SCALE_SGI")]
    PostColorMatrixBlueScaleSGI = unchecked((uint)0x80B6),

    [NativeName("GL_POST_COLOR_MATRIX_ALPHA_SCALE_SGI")]
    PostColorMatrixAlphaScaleSGI = unchecked((uint)0x80B7),

    [NativeName("GL_POST_COLOR_MATRIX_RED_BIAS_SGI")]
    PostColorMatrixRedBiasSGI = unchecked((uint)0x80B8),

    [NativeName("GL_POST_COLOR_MATRIX_GREEN_BIAS_SGI")]
    PostColorMatrixGreenBiasSGI = unchecked((uint)0x80B9),

    [NativeName("GL_POST_COLOR_MATRIX_BLUE_BIAS_SGI")]
    PostColorMatrixBlueBiasSGI = unchecked((uint)0x80BA),

    [NativeName("GL_POST_COLOR_MATRIX_ALPHA_BIAS_SGI")]
    PostColorMatrixAlphaBiasSGI = unchecked((uint)0x80BB),

    [NativeName("GL_COLOR_TABLE_SGI")]
    ColorTableSGI = unchecked((uint)0x80D0),

    [NativeName("GL_POST_CONVOLUTION_COLOR_TABLE_SGI")]
    PostConvolutionColorTableSGI = unchecked((uint)0x80D1),

    [NativeName("GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI")]
    PostColorMatrixColorTableSGI = unchecked((uint)0x80D2),

    [NativeName("GL_TEXTURE_COLOR_TABLE_SGI")]
    TextureColorTableSGI = unchecked((uint)0x80BC),

    [NativeName("GL_FETCH_PER_SAMPLE_ARM")]
    FetchPerSampleARM = unchecked((uint)0x8F65),

    [NativeName("GL_FRAGMENT_SHADER_FRAMEBUFFER_FETCH_MRT_ARM")]
    FragmentShaderFramebufferFetchMrtARM = unchecked((uint)0x8F66),

    [NativeName("GL_TIMESTAMP_EXT")]
    TimestampEXT = unchecked((uint)0x8E28),

    [NativeName("GL_SHADING_RATE_EXT")]
    ShadingRateEXT = unchecked((uint)0x96D0),

    [NativeName("GL_MIN_FRAGMENT_SHADING_RATE_ATTACHMENT_TEXEL_WIDTH_EXT")]
    MinFragmentShadingRateAttachmentTexelWidthEXT = unchecked((uint)0x96D7),

    [NativeName("GL_MAX_FRAGMENT_SHADING_RATE_ATTACHMENT_TEXEL_WIDTH_EXT")]
    MaxFragmentShadingRateAttachmentTexelWidthEXT = unchecked((uint)0x96D8),

    [NativeName("GL_MIN_FRAGMENT_SHADING_RATE_ATTACHMENT_TEXEL_HEIGHT_EXT")]
    MinFragmentShadingRateAttachmentTexelHeightEXT = unchecked((uint)0x96D9),

    [NativeName("GL_MAX_FRAGMENT_SHADING_RATE_ATTACHMENT_TEXEL_HEIGHT_EXT")]
    MaxFragmentShadingRateAttachmentTexelHeightEXT = unchecked((uint)0x96DA),

    [NativeName("GL_MAX_FRAGMENT_SHADING_RATE_ATTACHMENT_TEXEL_ASPECT_RATIO_EXT")]
    MaxFragmentShadingRateAttachmentTexelAspectRatioEXT = unchecked((uint)0x96DB),

    [NativeName("GL_MAX_FRAGMENT_SHADING_RATE_ATTACHMENT_LAYERS_EXT")]
    MaxFragmentShadingRateAttachmentLayersEXT = unchecked((uint)0x96DC),

    [NativeName("GL_FRAGMENT_SHADING_RATE_WITH_SHADER_DEPTH_STENCIL_WRITES_SUPPORTED_EXT")]
    FragmentShadingRateWithShaderDepthStencilWritesSupportedEXT = unchecked((uint)0x96DD),

    [NativeName("GL_FRAGMENT_SHADING_RATE_WITH_SAMPLE_MASK_SUPPORTED_EXT")]
    FragmentShadingRateWithSampleMaskSupportedEXT = unchecked((uint)0x96DE),

    [NativeName("GL_FRAGMENT_SHADING_RATE_ATTACHMENT_WITH_DEFAULT_FRAMEBUFFER_SUPPORTED_EXT")]
    FragmentShadingRateAttachmentWithDefaultFramebufferSupportedEXT = unchecked((uint)0x96DF),

    [NativeName("GL_FRAGMENT_SHADING_RATE_NON_TRIVIAL_COMBINERS_SUPPORTED_EXT")]
    FragmentShadingRateNonTrivialCombinersSupportedEXT = unchecked((uint)0x8F6F),

    [NativeName("GL_DRAW_BUFFER_EXT")]
    DrawBufferEXT = unchecked((uint)0x0C01),

    [NativeName("GL_READ_BUFFER_EXT")]
    ReadBufferEXT = unchecked((uint)0x0C02),

    [NativeName("GL_MAX_COLOR_ATTACHMENTS_NV")]
    MaxColorAttachmentsNV = unchecked((uint)0x8CDF),

    [NativeName("GL_PACK_ROW_LENGTH_NV")]
    PackRowLengthNV = unchecked((uint)0x0D02),

    [NativeName("GL_PACK_SKIP_ROWS_NV")]
    PackSkipRowsNV = unchecked((uint)0x0D03),

    [NativeName("GL_PACK_SKIP_PIXELS_NV")]
    PackSkipPixelsNV = unchecked((uint)0x0D04),

    [NativeName("GL_READ_BUFFER_NV")]
    ReadBufferNV = unchecked((uint)0x0C02),

    [NativeName("GL_ALPHA_TEST_QCOM")]
    AlphaTestQCOM = unchecked((uint)0x0BC0),

    [NativeName("GL_ALPHA_TEST_FUNC_QCOM")]
    AlphaTestFuncQCOM = unchecked((uint)0x0BC1),

    [NativeName("GL_ALPHA_TEST_REF_QCOM")]
    AlphaTestRefQCOM = unchecked((uint)0x0BC2),

    [NativeName("GL_MOTION_ESTIMATION_SEARCH_BLOCK_X_QCOM")]
    MotionEstimationSearchBlockXQCOM = unchecked((uint)0x8C90),

    [NativeName("GL_MOTION_ESTIMATION_SEARCH_BLOCK_Y_QCOM")]
    MotionEstimationSearchBlockYQCOM = unchecked((uint)0x8C91),

    [NativeName("GL_FRAMEBUFFER_FETCH_NONCOHERENT_QCOM")]
    FramebufferFetchNoncoherentQCOM = unchecked((uint)0x96A2),

    [NativeName("GL_SHADING_RATE_QCOM")]
    ShadingRateQCOM = unchecked((uint)0x96A4),
}
