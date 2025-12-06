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
    [NativeName("GL_POINT_SIZE")]
    PointSize = 2833,

    [NativeName("GL_POINT_SIZE_RANGE")]
    PointSizeRange = 2834,

    [NativeName("GL_POINT_SIZE_GRANULARITY")]
    PointSizeGranularity = 2835,

    [NativeName("GL_LINE_SMOOTH")]
    LineSmooth = 2848,

    [NativeName("GL_LINE_WIDTH")]
    LineWidth = 2849,

    [NativeName("GL_LINE_WIDTH_RANGE")]
    LineWidthRange = 2850,

    [NativeName("GL_LINE_WIDTH_GRANULARITY")]
    LineWidthGranularity = 2851,

    [NativeName("GL_POLYGON_MODE")]
    PolygonMode = 2880,

    [NativeName("GL_POLYGON_SMOOTH")]
    PolygonSmooth = 2881,

    [NativeName("GL_CULL_FACE")]
    CullFace = 2884,

    [NativeName("GL_CULL_FACE_MODE")]
    CullFaceMode = 2885,

    [NativeName("GL_FRONT_FACE")]
    FrontFace = 2886,

    [NativeName("GL_DEPTH_RANGE")]
    DepthRange = 2928,

    [NativeName("GL_DEPTH_TEST")]
    DepthTest = 2929,

    [NativeName("GL_DEPTH_WRITEMASK")]
    DepthWritemask = 2930,

    [NativeName("GL_DEPTH_CLEAR_VALUE")]
    DepthClearValue = 2931,

    [NativeName("GL_DEPTH_FUNC")]
    DepthFunc = 2932,

    [NativeName("GL_STENCIL_TEST")]
    StencilTest = 2960,

    [NativeName("GL_STENCIL_CLEAR_VALUE")]
    StencilClearValue = 2961,

    [NativeName("GL_STENCIL_FUNC")]
    StencilFunc = 2962,

    [NativeName("GL_STENCIL_VALUE_MASK")]
    StencilValueMask = 2963,

    [NativeName("GL_STENCIL_FAIL")]
    StencilFail = 2964,

    [NativeName("GL_STENCIL_PASS_DEPTH_FAIL")]
    StencilPassDepthFail = 2965,

    [NativeName("GL_STENCIL_PASS_DEPTH_PASS")]
    StencilPassDepthPass = 2966,

    [NativeName("GL_STENCIL_REF")]
    StencilRef = 2967,

    [NativeName("GL_STENCIL_WRITEMASK")]
    StencilWritemask = 2968,

    [NativeName("GL_VIEWPORT")]
    Viewport = 2978,

    [NativeName("GL_DITHER")]
    Dither = 3024,

    [NativeName("GL_BLEND_DST")]
    BlendDst = 3040,

    [NativeName("GL_BLEND_SRC")]
    BlendSrc = 3041,

    [NativeName("GL_BLEND")]
    Blend = 3042,

    [NativeName("GL_LOGIC_OP_MODE")]
    LogicOpMode = 3056,

    [NativeName("GL_DRAW_BUFFER")]
    DrawBuffer = 3073,

    [NativeName("GL_READ_BUFFER")]
    ReadBuffer = 3074,

    [NativeName("GL_SCISSOR_BOX")]
    ScissorBox = 3088,

    [NativeName("GL_SCISSOR_TEST")]
    ScissorTest = 3089,

    [NativeName("GL_COLOR_CLEAR_VALUE")]
    ColorClearValue = 3106,

    [NativeName("GL_COLOR_WRITEMASK")]
    ColorWritemask = 3107,

    [NativeName("GL_DOUBLEBUFFER")]
    Doublebuffer = 3122,

    [NativeName("GL_STEREO")]
    Stereo = 3123,

    [NativeName("GL_LINE_SMOOTH_HINT")]
    LineSmoothHint = 3154,

    [NativeName("GL_POLYGON_SMOOTH_HINT")]
    PolygonSmoothHint = 3155,

    [NativeName("GL_UNPACK_SWAP_BYTES")]
    UnpackSwapBytes = 3312,

    [NativeName("GL_UNPACK_LSB_FIRST")]
    UnpackLsbFirst = 3313,

    [NativeName("GL_UNPACK_ROW_LENGTH")]
    UnpackRowLength = 3314,

    [NativeName("GL_UNPACK_SKIP_ROWS")]
    UnpackSkipRows = 3315,

    [NativeName("GL_UNPACK_SKIP_PIXELS")]
    UnpackSkipPixels = 3316,

    [NativeName("GL_UNPACK_ALIGNMENT")]
    UnpackAlignment = 3317,

    [NativeName("GL_PACK_SWAP_BYTES")]
    PackSwapBytes = 3328,

    [NativeName("GL_PACK_LSB_FIRST")]
    PackLsbFirst = 3329,

    [NativeName("GL_PACK_ROW_LENGTH")]
    PackRowLength = 3330,

    [NativeName("GL_PACK_SKIP_ROWS")]
    PackSkipRows = 3331,

    [NativeName("GL_PACK_SKIP_PIXELS")]
    PackSkipPixels = 3332,

    [NativeName("GL_PACK_ALIGNMENT")]
    PackAlignment = 3333,

    [NativeName("GL_MAX_TEXTURE_SIZE")]
    MaxTextureSize = 3379,

    [NativeName("GL_MAX_VIEWPORT_DIMS")]
    MaxViewportDims = 3386,

    [NativeName("GL_SUBPIXEL_BITS")]
    SubpixelBits = 3408,

    [NativeName("GL_TEXTURE_1D")]
    Texture1D = 3552,

    [NativeName("GL_TEXTURE_2D")]
    Texture2D = 3553,

    [NativeName("GL_CURRENT_COLOR")]
    CurrentColor = 2816,

    [NativeName("GL_CURRENT_INDEX")]
    CurrentIndex = 2817,

    [NativeName("GL_CURRENT_NORMAL")]
    CurrentNormal = 2818,

    [NativeName("GL_CURRENT_TEXTURE_COORDS")]
    CurrentTextureCoords = 2819,

    [NativeName("GL_CURRENT_RASTER_COLOR")]
    CurrentRasterColor = 2820,

    [NativeName("GL_CURRENT_RASTER_INDEX")]
    CurrentRasterIndex = 2821,

    [NativeName("GL_CURRENT_RASTER_TEXTURE_COORDS")]
    CurrentRasterTextureCoords = 2822,

    [NativeName("GL_CURRENT_RASTER_POSITION")]
    CurrentRasterPosition = 2823,

    [NativeName("GL_CURRENT_RASTER_POSITION_VALID")]
    CurrentRasterPositionValid = 2824,

    [NativeName("GL_CURRENT_RASTER_DISTANCE")]
    CurrentRasterDistance = 2825,

    [NativeName("GL_POINT_SMOOTH")]
    PointSmooth = 2832,

    [NativeName("GL_LINE_STIPPLE")]
    LineStipple = 2852,

    [NativeName("GL_LINE_STIPPLE_PATTERN")]
    LineStipplePattern = 2853,

    [NativeName("GL_LINE_STIPPLE_REPEAT")]
    LineStippleRepeat = 2854,

    [NativeName("GL_LIST_MODE")]
    ListMode = 2864,

    [NativeName("GL_MAX_LIST_NESTING")]
    MaxListNesting = 2865,

    [NativeName("GL_LIST_BASE")]
    ListBase = 2866,

    [NativeName("GL_LIST_INDEX")]
    ListIndex = 2867,

    [NativeName("GL_POLYGON_STIPPLE")]
    PolygonStipple = 2882,

    [NativeName("GL_EDGE_FLAG")]
    EdgeFlag = 2883,

    [NativeName("GL_LIGHTING")]
    Lighting = 2896,

    [NativeName("GL_LIGHT_MODEL_LOCAL_VIEWER")]
    LightModelLocalViewer = 2897,

    [NativeName("GL_LIGHT_MODEL_TWO_SIDE")]
    LightModelTwoSide = 2898,

    [NativeName("GL_LIGHT_MODEL_AMBIENT")]
    LightModelAmbient = 2899,

    [NativeName("GL_SHADE_MODEL")]
    ShadeModel = 2900,

    [NativeName("GL_COLOR_MATERIAL_FACE")]
    ColorMaterialFace = 2901,

    [NativeName("GL_COLOR_MATERIAL_PARAMETER")]
    ColorMaterialParameter = 2902,

    [NativeName("GL_COLOR_MATERIAL")]
    ColorMaterial = 2903,

    [NativeName("GL_FOG")]
    Fog = 2912,

    [NativeName("GL_FOG_INDEX")]
    FogIndex = 2913,

    [NativeName("GL_FOG_DENSITY")]
    FogDensity = 2914,

    [NativeName("GL_FOG_START")]
    FogStart = 2915,

    [NativeName("GL_FOG_END")]
    FogEnd = 2916,

    [NativeName("GL_FOG_MODE")]
    FogMode = 2917,

    [NativeName("GL_FOG_COLOR")]
    FogColor = 2918,

    [NativeName("GL_ACCUM_CLEAR_VALUE")]
    AccumClearValue = 2944,

    [NativeName("GL_MATRIX_MODE")]
    MatrixMode = 2976,

    [NativeName("GL_NORMALIZE")]
    Normalize = 2977,

    [NativeName("GL_MODELVIEW_STACK_DEPTH")]
    ModelviewStackDepth = 2979,

    [NativeName("GL_PROJECTION_STACK_DEPTH")]
    ProjectionStackDepth = 2980,

    [NativeName("GL_TEXTURE_STACK_DEPTH")]
    TextureStackDepth = 2981,

    [NativeName("GL_MODELVIEW_MATRIX")]
    ModelviewMatrix = 2982,

    [NativeName("GL_PROJECTION_MATRIX")]
    ProjectionMatrix = 2983,

    [NativeName("GL_TEXTURE_MATRIX")]
    TextureMatrix = 2984,

    [NativeName("GL_ATTRIB_STACK_DEPTH")]
    AttribStackDepth = 2992,

    [NativeName("GL_ALPHA_TEST")]
    AlphaTest = 3008,

    [NativeName("GL_ALPHA_TEST_FUNC")]
    AlphaTestFunc = 3009,

    [NativeName("GL_ALPHA_TEST_REF")]
    AlphaTestRef = 3010,

    [NativeName("GL_LOGIC_OP")]
    LogicOp = 3057,

    [NativeName("GL_AUX_BUFFERS")]
    AuxBuffers = 3072,

    [NativeName("GL_INDEX_CLEAR_VALUE")]
    IndexClearValue = 3104,

    [NativeName("GL_INDEX_WRITEMASK")]
    IndexWritemask = 3105,

    [NativeName("GL_INDEX_MODE")]
    IndexMode = 3120,

    [NativeName("GL_RGBA_MODE")]
    RgbaMode = 3121,

    [NativeName("GL_RENDER_MODE")]
    RenderMode = 3136,

    [NativeName("GL_PERSPECTIVE_CORRECTION_HINT")]
    PerspectiveCorrectionHint = 3152,

    [NativeName("GL_POINT_SMOOTH_HINT")]
    PointSmoothHint = 3153,

    [NativeName("GL_FOG_HINT")]
    FogHint = 3156,

    [NativeName("GL_TEXTURE_GEN_S")]
    TextureGenS = 3168,

    [NativeName("GL_TEXTURE_GEN_T")]
    TextureGenT = 3169,

    [NativeName("GL_TEXTURE_GEN_R")]
    TextureGenR = 3170,

    [NativeName("GL_TEXTURE_GEN_Q")]
    TextureGenQ = 3171,

    [NativeName("GL_PIXEL_MAP_I_TO_I_SIZE")]
    PixelMapIToISize = 3248,

    [NativeName("GL_PIXEL_MAP_S_TO_S_SIZE")]
    PixelMapSToSSize = 3249,

    [NativeName("GL_PIXEL_MAP_I_TO_R_SIZE")]
    PixelMapIToRSize = 3250,

    [NativeName("GL_PIXEL_MAP_I_TO_G_SIZE")]
    PixelMapIToGSize = 3251,

    [NativeName("GL_PIXEL_MAP_I_TO_B_SIZE")]
    PixelMapIToBSize = 3252,

    [NativeName("GL_PIXEL_MAP_I_TO_A_SIZE")]
    PixelMapIToASize = 3253,

    [NativeName("GL_PIXEL_MAP_R_TO_R_SIZE")]
    PixelMapRToRSize = 3254,

    [NativeName("GL_PIXEL_MAP_G_TO_G_SIZE")]
    PixelMapGToGSize = 3255,

    [NativeName("GL_PIXEL_MAP_B_TO_B_SIZE")]
    PixelMapBToBSize = 3256,

    [NativeName("GL_PIXEL_MAP_A_TO_A_SIZE")]
    PixelMapAToASize = 3257,

    [NativeName("GL_MAP_COLOR")]
    MapColor = 3344,

    [NativeName("GL_MAP_STENCIL")]
    MapStencil = 3345,

    [NativeName("GL_INDEX_SHIFT")]
    IndexShift = 3346,

    [NativeName("GL_INDEX_OFFSET")]
    IndexOffset = 3347,

    [NativeName("GL_RED_SCALE")]
    RedScale = 3348,

    [NativeName("GL_RED_BIAS")]
    RedBias = 3349,

    [NativeName("GL_ZOOM_X")]
    ZoomX = 3350,

    [NativeName("GL_ZOOM_Y")]
    ZoomY = 3351,

    [NativeName("GL_GREEN_SCALE")]
    GreenScale = 3352,

    [NativeName("GL_GREEN_BIAS")]
    GreenBias = 3353,

    [NativeName("GL_BLUE_SCALE")]
    BlueScale = 3354,

    [NativeName("GL_BLUE_BIAS")]
    BlueBias = 3355,

    [NativeName("GL_ALPHA_SCALE")]
    AlphaScale = 3356,

    [NativeName("GL_ALPHA_BIAS")]
    AlphaBias = 3357,

    [NativeName("GL_DEPTH_SCALE")]
    DepthScale = 3358,

    [NativeName("GL_DEPTH_BIAS")]
    DepthBias = 3359,

    [NativeName("GL_MAX_EVAL_ORDER")]
    MaxEvalOrder = 3376,

    [NativeName("GL_MAX_LIGHTS")]
    MaxLights = 3377,

    [NativeName("GL_MAX_CLIP_PLANES")]
    MaxClipPlanes = 3378,

    [NativeName("GL_MAX_PIXEL_MAP_TABLE")]
    MaxPixelMapTable = 3380,

    [NativeName("GL_MAX_ATTRIB_STACK_DEPTH")]
    MaxAttribStackDepth = 3381,

    [NativeName("GL_MAX_MODELVIEW_STACK_DEPTH")]
    MaxModelviewStackDepth = 3382,

    [NativeName("GL_MAX_NAME_STACK_DEPTH")]
    MaxNameStackDepth = 3383,

    [NativeName("GL_MAX_PROJECTION_STACK_DEPTH")]
    MaxProjectionStackDepth = 3384,

    [NativeName("GL_MAX_TEXTURE_STACK_DEPTH")]
    MaxTextureStackDepth = 3385,

    [NativeName("GL_INDEX_BITS")]
    IndexBits = 3409,

    [NativeName("GL_RED_BITS")]
    RedBits = 3410,

    [NativeName("GL_GREEN_BITS")]
    GreenBits = 3411,

    [NativeName("GL_BLUE_BITS")]
    BlueBits = 3412,

    [NativeName("GL_ALPHA_BITS")]
    AlphaBits = 3413,

    [NativeName("GL_DEPTH_BITS")]
    DepthBits = 3414,

    [NativeName("GL_STENCIL_BITS")]
    StencilBits = 3415,

    [NativeName("GL_ACCUM_RED_BITS")]
    AccumRedBits = 3416,

    [NativeName("GL_ACCUM_GREEN_BITS")]
    AccumGreenBits = 3417,

    [NativeName("GL_ACCUM_BLUE_BITS")]
    AccumBlueBits = 3418,

    [NativeName("GL_ACCUM_ALPHA_BITS")]
    AccumAlphaBits = 3419,

    [NativeName("GL_NAME_STACK_DEPTH")]
    NameStackDepth = 3440,

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

    [NativeName("GL_MAP1_GRID_DOMAIN")]
    Map1GridDomain = 3536,

    [NativeName("GL_MAP1_GRID_SEGMENTS")]
    Map1GridSegments = 3537,

    [NativeName("GL_MAP2_GRID_DOMAIN")]
    Map2GridDomain = 3538,

    [NativeName("GL_MAP2_GRID_SEGMENTS")]
    Map2GridSegments = 3539,

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

    [NativeName("GL_COLOR_LOGIC_OP")]
    ColorLogicOp = 3058,

    [NativeName("GL_POLYGON_OFFSET_UNITS")]
    PolygonOffsetUnits = 10752,

    [NativeName("GL_POLYGON_OFFSET_POINT")]
    PolygonOffsetPoint = 10753,

    [NativeName("GL_POLYGON_OFFSET_LINE")]
    PolygonOffsetLine = 10754,

    [NativeName("GL_POLYGON_OFFSET_FILL")]
    PolygonOffsetFill = 32823,

    [NativeName("GL_POLYGON_OFFSET_FACTOR")]
    PolygonOffsetFactor = 32824,

    [NativeName("GL_TEXTURE_BINDING_1D")]
    TextureBinding1D = 32872,

    [NativeName("GL_TEXTURE_BINDING_2D")]
    TextureBinding2D = 32873,

    [NativeName("GL_CLIENT_ATTRIB_STACK_DEPTH")]
    ClientAttribStackDepth = 2993,

    [NativeName("GL_INDEX_LOGIC_OP")]
    IndexLogicOp = 3057,

    [NativeName("GL_MAX_CLIENT_ATTRIB_STACK_DEPTH")]
    MaxClientAttribStackDepth = 3387,

    [NativeName("GL_FEEDBACK_BUFFER_SIZE")]
    FeedbackBufferSize = 3569,

    [NativeName("GL_FEEDBACK_BUFFER_TYPE")]
    FeedbackBufferType = 3570,

    [NativeName("GL_SELECTION_BUFFER_SIZE")]
    SelectionBufferSize = 3572,

    [NativeName("GL_VERTEX_ARRAY")]
    VertexArray = 32884,

    [NativeName("GL_NORMAL_ARRAY")]
    NormalArray = 32885,

    [NativeName("GL_COLOR_ARRAY")]
    ColorArray = 32886,

    [NativeName("GL_INDEX_ARRAY")]
    IndexArray = 32887,

    [NativeName("GL_TEXTURE_COORD_ARRAY")]
    TextureCoordArray = 32888,

    [NativeName("GL_EDGE_FLAG_ARRAY")]
    EdgeFlagArray = 32889,

    [NativeName("GL_VERTEX_ARRAY_SIZE")]
    VertexArraySize = 32890,

    [NativeName("GL_VERTEX_ARRAY_TYPE")]
    VertexArrayType = 32891,

    [NativeName("GL_VERTEX_ARRAY_STRIDE")]
    VertexArrayStride = 32892,

    [NativeName("GL_NORMAL_ARRAY_TYPE")]
    NormalArrayType = 32894,

    [NativeName("GL_NORMAL_ARRAY_STRIDE")]
    NormalArrayStride = 32895,

    [NativeName("GL_COLOR_ARRAY_SIZE")]
    ColorArraySize = 32897,

    [NativeName("GL_COLOR_ARRAY_TYPE")]
    ColorArrayType = 32898,

    [NativeName("GL_COLOR_ARRAY_STRIDE")]
    ColorArrayStride = 32899,

    [NativeName("GL_INDEX_ARRAY_TYPE")]
    IndexArrayType = 32901,

    [NativeName("GL_INDEX_ARRAY_STRIDE")]
    IndexArrayStride = 32902,

    [NativeName("GL_TEXTURE_COORD_ARRAY_SIZE")]
    TextureCoordArraySize = 32904,

    [NativeName("GL_TEXTURE_COORD_ARRAY_TYPE")]
    TextureCoordArrayType = 32905,

    [NativeName("GL_TEXTURE_COORD_ARRAY_STRIDE")]
    TextureCoordArrayStride = 32906,

    [NativeName("GL_EDGE_FLAG_ARRAY_STRIDE")]
    EdgeFlagArrayStride = 32908,

    [NativeName("GL_TEXTURE_BINDING_3D")]
    TextureBinding3D = 32874,

    [NativeName("GL_PACK_SKIP_IMAGES")]
    PackSkipImages = 32875,

    [NativeName("GL_PACK_IMAGE_HEIGHT")]
    PackImageHeight = 32876,

    [NativeName("GL_UNPACK_SKIP_IMAGES")]
    UnpackSkipImages = 32877,

    [NativeName("GL_UNPACK_IMAGE_HEIGHT")]
    UnpackImageHeight = 32878,

    [NativeName("GL_MAX_3D_TEXTURE_SIZE")]
    Max3DTextureSize = 32883,

    [NativeName("GL_MAX_ELEMENTS_VERTICES")]
    MaxElementsVertices = 33000,

    [NativeName("GL_MAX_ELEMENTS_INDICES")]
    MaxElementsIndices = 33001,

    [NativeName("GL_SMOOTH_POINT_SIZE_RANGE")]
    SmoothPointSizeRange = 2834,

    [NativeName("GL_SMOOTH_POINT_SIZE_GRANULARITY")]
    SmoothPointSizeGranularity = 2835,

    [NativeName("GL_SMOOTH_LINE_WIDTH_RANGE")]
    SmoothLineWidthRange = 2850,

    [NativeName("GL_SMOOTH_LINE_WIDTH_GRANULARITY")]
    SmoothLineWidthGranularity = 2851,

    [NativeName("GL_ALIASED_LINE_WIDTH_RANGE")]
    AliasedLineWidthRange = 33902,

    [NativeName("GL_LIGHT_MODEL_COLOR_CONTROL")]
    LightModelColorControl = 33272,

    [NativeName("GL_ALIASED_POINT_SIZE_RANGE")]
    AliasedPointSizeRange = 33901,

    [NativeName("GL_ACTIVE_TEXTURE")]
    ActiveTexture = 34016,

    [NativeName("GL_SAMPLE_BUFFERS")]
    SampleBuffers = 32936,

    [NativeName("GL_SAMPLES")]
    Samples = 32937,

    [NativeName("GL_SAMPLE_COVERAGE_VALUE")]
    SampleCoverageValue = 32938,

    [NativeName("GL_SAMPLE_COVERAGE_INVERT")]
    SampleCoverageInvert = 32939,

    [NativeName("GL_TEXTURE_BINDING_CUBE_MAP")]
    TextureBindingCubeMap = 34068,

    [NativeName("GL_MAX_CUBE_MAP_TEXTURE_SIZE")]
    MaxCubeMapTextureSize = 34076,

    [NativeName("GL_TEXTURE_COMPRESSION_HINT")]
    TextureCompressionHint = 34031,

    [NativeName("GL_NUM_COMPRESSED_TEXTURE_FORMATS")]
    NumCompressedTextureFormats = 34466,

    [NativeName("GL_COMPRESSED_TEXTURE_FORMATS")]
    CompressedTextureFormats = 34467,

    [NativeName("GL_BLEND_DST_RGB")]
    BlendDstRgb = 32968,

    [NativeName("GL_BLEND_SRC_RGB")]
    BlendSrcRgb = 32969,

    [NativeName("GL_BLEND_DST_ALPHA")]
    BlendDstAlpha = 32970,

    [NativeName("GL_BLEND_SRC_ALPHA")]
    BlendSrcAlpha = 32971,

    [NativeName("GL_POINT_FADE_THRESHOLD_SIZE")]
    PointFadeThresholdSize = 33064,

    [NativeName("GL_MAX_TEXTURE_LOD_BIAS")]
    MaxTextureLodBias = 34045,

    [NativeName("GL_POINT_SIZE_MIN")]
    PointSizeMin = 33062,

    [NativeName("GL_POINT_SIZE_MAX")]
    PointSizeMax = 33063,

    [NativeName("GL_POINT_DISTANCE_ATTENUATION")]
    PointDistanceAttenuation = 33065,

    [NativeName("GL_BLEND_COLOR")]
    BlendColor = 32773,

    [NativeName("GL_BLEND_EQUATION")]
    BlendEquation = 32777,

    [NativeName("GL_ARRAY_BUFFER_BINDING")]
    ArrayBufferBinding = 34964,

    [NativeName("GL_ELEMENT_ARRAY_BUFFER_BINDING")]
    ElementArrayBufferBinding = 34965,

    [NativeName("GL_BLEND_EQUATION_RGB")]
    BlendEquationRgb = 32777,

    [NativeName("GL_STENCIL_BACK_FUNC")]
    StencilBackFunc = 34816,

    [NativeName("GL_STENCIL_BACK_FAIL")]
    StencilBackFail = 34817,

    [NativeName("GL_STENCIL_BACK_PASS_DEPTH_FAIL")]
    StencilBackPassDepthFail = 34818,

    [NativeName("GL_STENCIL_BACK_PASS_DEPTH_PASS")]
    StencilBackPassDepthPass = 34819,

    [NativeName("GL_MAX_DRAW_BUFFERS")]
    MaxDrawBuffers = 34852,

    [NativeName("GL_BLEND_EQUATION_ALPHA")]
    BlendEquationAlpha = 34877,

    [NativeName("GL_MAX_VERTEX_ATTRIBS")]
    MaxVertexAttribs = 34921,

    [NativeName("GL_MAX_TEXTURE_IMAGE_UNITS")]
    MaxTextureImageUnits = 34930,

    [NativeName("GL_MAX_FRAGMENT_UNIFORM_COMPONENTS")]
    MaxFragmentUniformComponents = 35657,

    [NativeName("GL_MAX_VERTEX_UNIFORM_COMPONENTS")]
    MaxVertexUniformComponents = 35658,

    [NativeName("GL_MAX_VARYING_FLOATS")]
    MaxVaryingFloats = 35659,

    [NativeName("GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS")]
    MaxVertexTextureImageUnits = 35660,

    [NativeName("GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS")]
    MaxCombinedTextureImageUnits = 35661,

    [NativeName("GL_FRAGMENT_SHADER_DERIVATIVE_HINT")]
    FragmentShaderDerivativeHint = 35723,

    [NativeName("GL_CURRENT_PROGRAM")]
    CurrentProgram = 35725,

    [NativeName("GL_STENCIL_BACK_REF")]
    StencilBackRef = 36003,

    [NativeName("GL_STENCIL_BACK_VALUE_MASK")]
    StencilBackValueMask = 36004,

    [NativeName("GL_STENCIL_BACK_WRITEMASK")]
    StencilBackWritemask = 36005,

    [NativeName("GL_PIXEL_PACK_BUFFER_BINDING")]
    PixelPackBufferBinding = 35053,

    [NativeName("GL_PIXEL_UNPACK_BUFFER_BINDING")]
    PixelUnpackBufferBinding = 35055,

    [NativeName("GL_MAX_CLIP_DISTANCES")]
    MaxClipDistances = 3378,

    [NativeName("GL_MAJOR_VERSION")]
    MajorVersion = 33307,

    [NativeName("GL_MINOR_VERSION")]
    MinorVersion = 33308,

    [NativeName("GL_NUM_EXTENSIONS")]
    NumExtensions = 33309,

    [NativeName("GL_CONTEXT_FLAGS")]
    ContextFlags = 33310,

    [NativeName("GL_MAX_ARRAY_TEXTURE_LAYERS")]
    MaxArrayTextureLayers = 35071,

    [NativeName("GL_MIN_PROGRAM_TEXEL_OFFSET")]
    MinProgramTexelOffset = 35076,

    [NativeName("GL_MAX_PROGRAM_TEXEL_OFFSET")]
    MaxProgramTexelOffset = 35077,

    [NativeName("GL_MAX_VARYING_COMPONENTS")]
    MaxVaryingComponents = 35659,

    [NativeName("GL_TEXTURE_BINDING_1D_ARRAY")]
    TextureBinding1DArray = 35868,

    [NativeName("GL_TEXTURE_BINDING_2D_ARRAY")]
    TextureBinding2DArray = 35869,

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_START")]
    TransformFeedbackBufferStart = 35972,

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_SIZE")]
    TransformFeedbackBufferSize = 35973,

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_BINDING")]
    TransformFeedbackBufferBinding = 35983,

    [NativeName("GL_MAX_RENDERBUFFER_SIZE")]
    MaxRenderbufferSize = 34024,

    [NativeName("GL_DRAW_FRAMEBUFFER_BINDING")]
    DrawFramebufferBinding = 36006,

    [NativeName("GL_RENDERBUFFER_BINDING")]
    RenderbufferBinding = 36007,

    [NativeName("GL_READ_FRAMEBUFFER_BINDING")]
    ReadFramebufferBinding = 36010,

    [NativeName("GL_MAX_COLOR_ATTACHMENTS")]
    MaxColorAttachments = 36063,

    [NativeName("GL_VERTEX_ARRAY_BINDING")]
    VertexArrayBinding = 34229,

    [NativeName("GL_MAX_TEXTURE_BUFFER_SIZE")]
    MaxTextureBufferSize = 35883,

    [NativeName("GL_TEXTURE_BINDING_BUFFER")]
    TextureBindingBuffer = 35884,

    [NativeName("GL_TEXTURE_BINDING_RECTANGLE")]
    TextureBindingRectANGLE = 34038,

    [NativeName("GL_MAX_RECTANGLE_TEXTURE_SIZE")]
    MaxRectangleTextureSize = 34040,

    [NativeName("GL_PRIMITIVE_RESTART_INDEX")]
    PrimitiveRestartIndex = 36766,

    [NativeName("GL_UNIFORM_BUFFER_BINDING")]
    UniformBufferBinding = 35368,

    [NativeName("GL_UNIFORM_BUFFER_START")]
    UniformBufferStart = 35369,

    [NativeName("GL_UNIFORM_BUFFER_SIZE")]
    UniformBufferSize = 35370,

    [NativeName("GL_MAX_VERTEX_UNIFORM_BLOCKS")]
    MaxVertexUniformBlocks = 35371,

    [NativeName("GL_MAX_GEOMETRY_UNIFORM_BLOCKS")]
    MaxGeometryUniformBlocks = 35372,

    [NativeName("GL_MAX_FRAGMENT_UNIFORM_BLOCKS")]
    MaxFragmentUniformBlocks = 35373,

    [NativeName("GL_MAX_COMBINED_UNIFORM_BLOCKS")]
    MaxCombinedUniformBlocks = 35374,

    [NativeName("GL_MAX_UNIFORM_BUFFER_BINDINGS")]
    MaxUniformBufferBindings = 35375,

    [NativeName("GL_MAX_UNIFORM_BLOCK_SIZE")]
    MaxUniformBlockSize = 35376,

    [NativeName("GL_MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS")]
    MaxCombinedVertexUniformComponents = 35377,

    [NativeName("GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS")]
    MaxCombinedGeometryUniformComponents = 35378,

    [NativeName("GL_MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS")]
    MaxCombinedFragmentUniformComponents = 35379,

    [NativeName("GL_UNIFORM_BUFFER_OFFSET_ALIGNMENT")]
    UniformBufferOffsetAlignment = 35380,

    [NativeName("GL_PROGRAM_POINT_SIZE")]
    ProgramPointSize = 34370,

    [NativeName("GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS")]
    MaxGeometryTextureImageUnits = 35881,

    [NativeName("GL_MAX_GEOMETRY_UNIFORM_COMPONENTS")]
    MaxGeometryUniformComponents = 36319,

    [NativeName("GL_MAX_VERTEX_OUTPUT_COMPONENTS")]
    MaxVertexOutputComponents = 37154,

    [NativeName("GL_MAX_GEOMETRY_INPUT_COMPONENTS")]
    MaxGeometryInputComponents = 37155,

    [NativeName("GL_MAX_GEOMETRY_OUTPUT_COMPONENTS")]
    MaxGeometryOutputComponents = 37156,

    [NativeName("GL_MAX_FRAGMENT_INPUT_COMPONENTS")]
    MaxFragmentInputComponents = 37157,

    [NativeName("GL_CONTEXT_PROFILE_MASK")]
    ContextProfileMask = 37158,

    [NativeName("GL_PROVOKING_VERTEX")]
    ProvokingVertex = 36431,

    [NativeName("GL_MAX_SERVER_WAIT_TIMEOUT")]
    MaxServerWaitTimeout = 37137,

    [NativeName("GL_MAX_SAMPLE_MASK_WORDS")]
    MaxSampleMaskWords = 36441,

    [NativeName("GL_TEXTURE_BINDING_2D_MULTISAMPLE")]
    TextureBinding2DMultisample = 37124,

    [NativeName("GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY")]
    TextureBinding2DMultisampleArray = 37125,

    [NativeName("GL_MAX_COLOR_TEXTURE_SAMPLES")]
    MaxColorTextureSamples = 37134,

    [NativeName("GL_MAX_DEPTH_TEXTURE_SAMPLES")]
    MaxDepthTextureSamples = 37135,

    [NativeName("GL_MAX_INTEGER_SAMPLES")]
    MaxIntegerSamples = 37136,

    [NativeName("GL_MAX_DUAL_SOURCE_DRAW_BUFFERS")]
    MaxDualSourceDrawBuffers = 35068,

    [NativeName("GL_SAMPLER_BINDING")]
    SamplerBinding = 35097,

    [NativeName("GL_TIMESTAMP")]
    Timestamp = 36392,

    [NativeName("GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS")]
    MaxTessControlUniformBlocks = 36489,

    [NativeName("GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS")]
    MaxTessEvaluationUniformBlocks = 36490,

    [NativeName("GL_IMPLEMENTATION_COLOR_READ_TYPE")]
    ImplementationColorReadType = 35738,

    [NativeName("GL_IMPLEMENTATION_COLOR_READ_FORMAT")]
    ImplementationColorReadFormat = 35739,

    [NativeName("GL_SHADER_COMPILER")]
    ShaderCompiler = 36346,

    [NativeName("GL_SHADER_BINARY_FORMATS")]
    ShaderBinaryFormats = 36344,

    [NativeName("GL_NUM_SHADER_BINARY_FORMATS")]
    NumShaderBinaryFormats = 36345,

    [NativeName("GL_MAX_VERTEX_UNIFORM_VECTORS")]
    MaxVertexUniformVectors = 36347,

    [NativeName("GL_MAX_VARYING_VECTORS")]
    MaxVaryingVectors = 36348,

    [NativeName("GL_MAX_FRAGMENT_UNIFORM_VECTORS")]
    MaxFragmentUniformVectors = 36349,

    [NativeName("GL_NUM_PROGRAM_BINARY_FORMATS")]
    NumProgramBinaryFormats = 34814,

    [NativeName("GL_PROGRAM_BINARY_FORMATS")]
    ProgramBinaryFormats = 34815,

    [NativeName("GL_PROGRAM_PIPELINE_BINDING")]
    ProgramPipelineBinding = 33370,

    [NativeName("GL_MAX_VIEWPORTS")]
    MaxViewports = 33371,

    [NativeName("GL_VIEWPORT_SUBPIXEL_BITS")]
    ViewportSubpixelBits = 33372,

    [NativeName("GL_VIEWPORT_BOUNDS_RANGE")]
    ViewportBoundsRange = 33373,

    [NativeName("GL_LAYER_PROVOKING_VERTEX")]
    LayerProvokingVertex = 33374,

    [NativeName("GL_VIEWPORT_INDEX_PROVOKING_VERTEX")]
    ViewportIndexProvokingVertex = 33375,

    [NativeName("GL_MIN_MAP_BUFFER_ALIGNMENT")]
    MinMapBufferAlignment = 37052,

    [NativeName("GL_MAX_VERTEX_ATOMIC_COUNTERS")]
    MaxVertexAtomicCounters = 37586,

    [NativeName("GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS")]
    MaxTessControlAtomicCounters = 37587,

    [NativeName("GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS")]
    MaxTessEvaluationAtomicCounters = 37588,

    [NativeName("GL_MAX_GEOMETRY_ATOMIC_COUNTERS")]
    MaxGeometryAtomicCounters = 37589,

    [NativeName("GL_MAX_FRAGMENT_ATOMIC_COUNTERS")]
    MaxFragmentAtomicCounters = 37590,

    [NativeName("GL_MAX_COMBINED_ATOMIC_COUNTERS")]
    MaxCombinedAtomicCounters = 37591,

    [NativeName("GL_MAX_ELEMENT_INDEX")]
    MaxElementIndex = 36203,

    [NativeName("GL_MAX_COMPUTE_UNIFORM_BLOCKS")]
    MaxComputeUniformBlocks = 37307,

    [NativeName("GL_MAX_COMPUTE_TEXTURE_IMAGE_UNITS")]
    MaxComputeTextureImageUnits = 37308,

    [NativeName("GL_MAX_COMPUTE_UNIFORM_COMPONENTS")]
    MaxComputeUniformComponents = 33379,

    [NativeName("GL_MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS")]
    MaxComputeAtomicCounterBuffers = 33380,

    [NativeName("GL_MAX_COMPUTE_ATOMIC_COUNTERS")]
    MaxComputeAtomicCounters = 33381,

    [NativeName("GL_MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS")]
    MaxCombinedComputeUniformComponents = 33382,

    [NativeName("GL_MAX_COMPUTE_WORK_GROUP_INVOCATIONS")]
    MaxComputeWorkGroupInvocations = 37099,

    [NativeName("GL_MAX_COMPUTE_WORK_GROUP_COUNT")]
    MaxComputeWorkGroupCount = 37310,

    [NativeName("GL_MAX_COMPUTE_WORK_GROUP_SIZE")]
    MaxComputeWorkGroupSize = 37311,

    [NativeName("GL_DISPATCH_INDIRECT_BUFFER_BINDING")]
    DispatchIndirectBufferBinding = 37103,

    [NativeName("GL_MAX_DEBUG_GROUP_STACK_DEPTH")]
    MaxDebugGroupStackDepth = 33388,

    [NativeName("GL_DEBUG_GROUP_STACK_DEPTH")]
    DebugGroupStackDepth = 33389,

    [NativeName("GL_MAX_LABEL_LENGTH")]
    MaxLabelLength = 33512,

    [NativeName("GL_MAX_UNIFORM_LOCATIONS")]
    MaxUniformLocations = 33390,

    [NativeName("GL_MAX_FRAMEBUFFER_WIDTH")]
    MaxFramebufferWidth = 37653,

    [NativeName("GL_MAX_FRAMEBUFFER_HEIGHT")]
    MaxFramebufferHeight = 37654,

    [NativeName("GL_MAX_FRAMEBUFFER_LAYERS")]
    MaxFramebufferLayers = 37655,

    [NativeName("GL_MAX_FRAMEBUFFER_SAMPLES")]
    MaxFramebufferSamples = 37656,

    [NativeName("GL_SHADER_STORAGE_BUFFER_BINDING")]
    ShaderStorageBufferBinding = 37075,

    [NativeName("GL_SHADER_STORAGE_BUFFER_START")]
    ShaderStorageBufferStart = 37076,

    [NativeName("GL_SHADER_STORAGE_BUFFER_SIZE")]
    ShaderStorageBufferSize = 37077,

    [NativeName("GL_MAX_VERTEX_SHADER_STORAGE_BLOCKS")]
    MaxVertexShaderStorageBlocks = 37078,

    [NativeName("GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS")]
    MaxGeometryShaderStorageBlocks = 37079,

    [NativeName("GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS")]
    MaxTessControlShaderStorageBlocks = 37080,

    [NativeName("GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS")]
    MaxTessEvaluationShaderStorageBlocks = 37081,

    [NativeName("GL_MAX_FRAGMENT_SHADER_STORAGE_BLOCKS")]
    MaxFragmentShaderStorageBlocks = 37082,

    [NativeName("GL_MAX_COMPUTE_SHADER_STORAGE_BLOCKS")]
    MaxComputeShaderStorageBlocks = 37083,

    [NativeName("GL_MAX_COMBINED_SHADER_STORAGE_BLOCKS")]
    MaxCombinedShaderStorageBlocks = 37084,

    [NativeName("GL_MAX_SHADER_STORAGE_BUFFER_BINDINGS")]
    MaxShaderStorageBufferBindings = 37085,

    [NativeName("GL_SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT")]
    ShaderStorageBufferOffsetAlignment = 37087,

    [NativeName("GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT")]
    TextureBufferOffsetAlignment = 37279,

    [NativeName("GL_VERTEX_BINDING_DIVISOR")]
    VertexBindingDivisor = 33494,

    [NativeName("GL_VERTEX_BINDING_OFFSET")]
    VertexBindingOffset = 33495,

    [NativeName("GL_VERTEX_BINDING_STRIDE")]
    VertexBindingStride = 33496,

    [NativeName("GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET")]
    MaxVertexAttribRelativeOffset = 33497,

    [NativeName("GL_MAX_VERTEX_ATTRIB_BINDINGS")]
    MaxVertexAttribBindings = 33498,

    [NativeName("GL_POINT_SIZE_MIN_ARB")]
    PointSizeMinARB = 33062,

    [NativeName("GL_POINT_SIZE_MAX_ARB")]
    PointSizeMaxARB = 33063,

    [NativeName("GL_POINT_FADE_THRESHOLD_SIZE_ARB")]
    PointFadeThresholdSizeARB = 33064,

    [NativeName("GL_POINT_DISTANCE_ATTENUATION_ARB")]
    PointDistanceAttenuationARB = 33065,

    [NativeName("GL_TEXTURE_BINDING_CUBE_MAP_ARB")]
    TextureBindingCubeMapARB = 34068,

    [NativeName("GL_MAX_CUBE_MAP_TEXTURE_SIZE_ARB")]
    MaxCubeMapTextureSizeARB = 34076,

    [NativeName("GL_TEXTURE_BINDING_RECTANGLE_ARB")]
    TextureBindingRectangleARB = 34038,

    [NativeName("GL_FRAGMENT_SHADER_ATI")]
    FragmentShaderATI = 35104,

    [NativeName("GL_BLEND_COLOR_EXT")]
    BlendColorEXT = 32773,

    [NativeName("GL_BLEND_EQUATION_EXT")]
    BlendEquationEXT = 32777,

    [NativeName("GL_PACK_CMYK_HINT_EXT")]
    PackCmykHintEXT = 32782,

    [NativeName("GL_UNPACK_CMYK_HINT_EXT")]
    UnpackCmykHintEXT = 32783,

    [NativeName("GL_CONVOLUTION_1D_EXT")]
    Convolution1DEXT = 32784,

    [NativeName("GL_CONVOLUTION_2D_EXT")]
    Convolution2DEXT = 32785,

    [NativeName("GL_SEPARABLE_2D_EXT")]
    Separable2DEXT = 32786,

    [NativeName("GL_POST_CONVOLUTION_RED_SCALE_EXT")]
    PostConvolutionRedScaleEXT = 32796,

    [NativeName("GL_POST_CONVOLUTION_GREEN_SCALE_EXT")]
    PostConvolutionGreenScaleEXT = 32797,

    [NativeName("GL_POST_CONVOLUTION_BLUE_SCALE_EXT")]
    PostConvolutionBlueScaleEXT = 32798,

    [NativeName("GL_POST_CONVOLUTION_ALPHA_SCALE_EXT")]
    PostConvolutionAlphaScaleEXT = 32799,

    [NativeName("GL_POST_CONVOLUTION_RED_BIAS_EXT")]
    PostConvolutionRedBiasEXT = 32800,

    [NativeName("GL_POST_CONVOLUTION_GREEN_BIAS_EXT")]
    PostConvolutionGreenBiasEXT = 32801,

    [NativeName("GL_POST_CONVOLUTION_BLUE_BIAS_EXT")]
    PostConvolutionBlueBiasEXT = 32802,

    [NativeName("GL_POST_CONVOLUTION_ALPHA_BIAS_EXT")]
    PostConvolutionAlphaBiasEXT = 32803,

    [NativeName("GL_MAX_COLOR_ATTACHMENTS_EXT")]
    MaxColorAttachmentsEXT = 36063,

    [NativeName("GL_HISTOGRAM_EXT")]
    HistogramEXT = 32804,

    [NativeName("GL_MINMAX_EXT")]
    MinmaxEXT = 32814,

    [NativeName("GL_NUM_DEVICE_UUIDS_EXT")]
    NumDeviceUuidsEXT = 38294,

    [NativeName("GL_DEVICE_UUID_EXT")]
    DeviceUuidEXT = 38295,

    [NativeName("GL_DRIVER_UUID_EXT")]
    DriverUuidEXT = 38296,

    [NativeName("GL_DEVICE_LUID_EXT")]
    DeviceLuidEXT = 38297,

    [NativeName("GL_DEVICE_NODE_MASK_EXT")]
    DeviceNodeMaskEXT = 38298,

    [NativeName("GL_POINT_SIZE_MIN_EXT")]
    PointSizeMinEXT = 33062,

    [NativeName("GL_POINT_SIZE_MAX_EXT")]
    PointSizeMaxEXT = 33063,

    [NativeName("GL_POINT_FADE_THRESHOLD_SIZE_EXT")]
    PointFadeThresholdSizeEXT = 33064,

    [NativeName("GL_DISTANCE_ATTENUATION_EXT")]
    DistanceAttenuationEXT = 33065,

    [NativeName("GL_POLYGON_OFFSET_BIAS_EXT")]
    PolygonOffsetBiasEXT = 32825,

    [NativeName("GL_RESCALE_NORMAL_EXT")]
    RescaleNormalEXT = 32826,

    [NativeName("GL_SHARED_TEXTURE_PALETTE_EXT")]
    SharedTexturePaletteEXT = 33275,

    [NativeName("GL_PACK_SKIP_IMAGES_EXT")]
    PackSkipImagesEXT = 32875,

    [NativeName("GL_PACK_IMAGE_HEIGHT_EXT")]
    PackImageHeightEXT = 32876,

    [NativeName("GL_UNPACK_SKIP_IMAGES_EXT")]
    UnpackSkipImagesEXT = 32877,

    [NativeName("GL_UNPACK_IMAGE_HEIGHT_EXT")]
    UnpackImageHeightEXT = 32878,

    [NativeName("GL_TEXTURE_3D_EXT")]
    Texture3DEXT = 32879,

    [NativeName("GL_MAX_3D_TEXTURE_SIZE_EXT")]
    Max3DTextureSizeEXT = 32883,

    [NativeName("GL_TEXTURE_BINDING_CUBE_MAP_EXT")]
    TextureBindingCubeMapEXT = 34068,

    [NativeName("GL_MAX_CUBE_MAP_TEXTURE_SIZE_EXT")]
    MaxCubeMapTextureSizeEXT = 34076,

    [NativeName("GL_TEXTURE_3D_BINDING_EXT")]
    Texture3DBindingEXT = 32874,

    [NativeName("GL_VERTEX_ARRAY_COUNT_EXT")]
    VertexArrayCountEXT = 32893,

    [NativeName("GL_NORMAL_ARRAY_COUNT_EXT")]
    NormalArrayCountEXT = 32896,

    [NativeName("GL_COLOR_ARRAY_COUNT_EXT")]
    ColorArrayCountEXT = 32900,

    [NativeName("GL_INDEX_ARRAY_COUNT_EXT")]
    IndexArrayCountEXT = 32903,

    [NativeName("GL_TEXTURE_COORD_ARRAY_COUNT_EXT")]
    TextureCoordArrayCountEXT = 32907,

    [NativeName("GL_EDGE_FLAG_ARRAY_COUNT_EXT")]
    EdgeFlagArrayCountEXT = 32909,

    [NativeName("GL_MODELVIEW0_STACK_DEPTH_EXT")]
    Modelview0StackDepthEXT = 2979,

    [NativeName("GL_MODELVIEW0_MATRIX_EXT")]
    Modelview0MatrixEXT = 2982,

    [NativeName("GL_SHADING_RATE_IMAGE_PER_PRIMITIVE_NV")]
    ShadingRateImagePerPrimitiveNV = 38321,

    [NativeName("GL_SHADING_RATE_IMAGE_PALETTE_COUNT_NV")]
    ShadingRateImagePaletteCountNV = 38322,

    [NativeName("GL_TEXTURE_BINDING_RECTANGLE_NV")]
    TextureBindingRectangleNV = 34038,

    [NativeName("GL_MAX_TIMELINE_SEMAPHORE_VALUE_DIFFERENCE_NV")]
    MaxTimelineSemaphoreValueDifferenceNV = 38326,

    [NativeName("GL_DETAIL_TEXTURE_2D_BINDING_SGIS")]
    DetailTexture2DBindingSGIS = 32918,

    [NativeName("GL_FOG_FUNC_POINTS_SGIS")]
    FogFuncPointsSGIS = 33067,

    [NativeName("GL_MAX_FOG_FUNC_POINTS_SGIS")]
    MaxFogFuncPointsSGIS = 33068,

    [NativeName("GL_GENERATE_MIPMAP_HINT_SGIS")]
    GenerateMipmapHintSGIS = 33170,

    [NativeName("GL_MULTISAMPLE_SGIS")]
    MultisampleSGIS = 32925,

    [NativeName("GL_SAMPLE_ALPHA_TO_MASK_SGIS")]
    SampleAlphaToMaskSGIS = 32926,

    [NativeName("GL_SAMPLE_ALPHA_TO_ONE_SGIS")]
    SampleAlphaToOneSGIS = 32927,

    [NativeName("GL_SAMPLE_MASK_SGIS")]
    SampleMaskSGIS = 32928,

    [NativeName("GL_SAMPLE_BUFFERS_SGIS")]
    SampleBuffersSGIS = 32936,

    [NativeName("GL_SAMPLES_SGIS")]
    SamplesSGIS = 32937,

    [NativeName("GL_SAMPLE_MASK_VALUE_SGIS")]
    SampleMaskValueSGIS = 32938,

    [NativeName("GL_SAMPLE_MASK_INVERT_SGIS")]
    SampleMaskInvertSGIS = 32939,

    [NativeName("GL_SAMPLE_PATTERN_SGIS")]
    SamplePatternSGIS = 32940,

    [NativeName("GL_PIXEL_TEXTURE_SGIS")]
    PixelTextureSGIS = 33619,

    [NativeName("GL_POINT_SIZE_MIN_SGIS")]
    PointSizeMinSGIS = 33062,

    [NativeName("GL_POINT_SIZE_MAX_SGIS")]
    PointSizeMaxSGIS = 33063,

    [NativeName("GL_POINT_FADE_THRESHOLD_SIZE_SGIS")]
    PointFadeThresholdSizeSGIS = 33064,

    [NativeName("GL_DISTANCE_ATTENUATION_SGIS")]
    DistanceAttenuationSGIS = 33065,

    [NativeName("GL_PACK_SKIP_VOLUMES_SGIS")]
    PackSkipVolumesSGIS = 33072,

    [NativeName("GL_PACK_IMAGE_DEPTH_SGIS")]
    PackImageDepthSGIS = 33073,

    [NativeName("GL_UNPACK_SKIP_VOLUMES_SGIS")]
    UnpackSkipVolumesSGIS = 33074,

    [NativeName("GL_UNPACK_IMAGE_DEPTH_SGIS")]
    UnpackImageDepthSGIS = 33075,

    [NativeName("GL_TEXTURE_4D_SGIS")]
    Texture4DSGIS = 33076,

    [NativeName("GL_MAX_4D_TEXTURE_SIZE_SGIS")]
    Max4DTextureSizeSGIS = 33080,

    [NativeName("GL_TEXTURE_4D_BINDING_SGIS")]
    Texture4DBindingSGIS = 33103,

    [NativeName("GL_ASYNC_MARKER_SGIX")]
    AsyncMarkerSGIX = 33577,

    [NativeName("GL_ASYNC_HISTOGRAM_SGIX")]
    AsyncHistogramSGIX = 33580,

    [NativeName("GL_MAX_ASYNC_HISTOGRAM_SGIX")]
    MaxAsyncHistogramSGIX = 33581,

    [NativeName("GL_ASYNC_TEX_IMAGE_SGIX")]
    AsyncTexImageSGIX = 33628,

    [NativeName("GL_ASYNC_DRAW_PIXELS_SGIX")]
    AsyncDrawPixelsSGIX = 33629,

    [NativeName("GL_ASYNC_READ_PIXELS_SGIX")]
    AsyncReadPixelsSGIX = 33630,

    [NativeName("GL_MAX_ASYNC_TEX_IMAGE_SGIX")]
    MaxAsyncTexImageSGIX = 33631,

    [NativeName("GL_MAX_ASYNC_DRAW_PIXELS_SGIX")]
    MaxAsyncDrawPixelsSGIX = 33632,

    [NativeName("GL_MAX_ASYNC_READ_PIXELS_SGIX")]
    MaxAsyncReadPixelsSGIX = 33633,

    [NativeName("GL_CALLIGRAPHIC_FRAGMENT_SGIX")]
    CalligraphicFragmentSGIX = 33155,

    [NativeName("GL_MAX_CLIPMAP_DEPTH_SGIX")]
    MaxClipmapDepthSGIX = 33143,

    [NativeName("GL_MAX_CLIPMAP_VIRTUAL_DEPTH_SGIX")]
    MaxClipmapVirtualDepthSGIX = 33144,

    [NativeName("GL_CONVOLUTION_HINT_SGIX")]
    ConvolutionHintSGIX = 33558,

    [NativeName("GL_FOG_OFFSET_SGIX")]
    FogOffsetSGIX = 33176,

    [NativeName("GL_FOG_OFFSET_VALUE_SGIX")]
    FogOffsetValueSGIX = 33177,

    [NativeName("GL_FRAGMENT_LIGHTING_SGIX")]
    FragmentLightingSGIX = 33792,

    [NativeName("GL_FRAGMENT_COLOR_MATERIAL_SGIX")]
    FragmentColorMaterialSGIX = 33793,

    [NativeName("GL_FRAGMENT_COLOR_MATERIAL_FACE_SGIX")]
    FragmentColorMaterialFaceSGIX = 33794,

    [NativeName("GL_FRAGMENT_COLOR_MATERIAL_PARAMETER_SGIX")]
    FragmentColorMaterialParameterSGIX = 33795,

    [NativeName("GL_MAX_FRAGMENT_LIGHTS_SGIX")]
    MaxFragmentLightsSGIX = 33796,

    [NativeName("GL_MAX_ACTIVE_LIGHTS_SGIX")]
    MaxActiveLightsSGIX = 33797,

    [NativeName("GL_LIGHT_ENV_MODE_SGIX")]
    LightEnvModeSGIX = 33799,

    [NativeName("GL_FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX")]
    FragmentLightModelLocalViewerSGIX = 33800,

    [NativeName("GL_FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX")]
    FragmentLightModelTwoSideSGIX = 33801,

    [NativeName("GL_FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX")]
    FragmentLightModelAmbientSGIX = 33802,

    [NativeName("GL_FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX")]
    FragmentLightModelNormalInterpolationSGIX = 33803,

    [NativeName("GL_FRAGMENT_LIGHT0_SGIX")]
    FragmentLight0SGIX = 33804,

    [NativeName("GL_FRAMEZOOM_SGIX")]
    FramezoomSGIX = 33163,

    [NativeName("GL_FRAMEZOOM_FACTOR_SGIX")]
    FramezoomFactorSGIX = 33164,

    [NativeName("GL_MAX_FRAMEZOOM_FACTOR_SGIX")]
    MaxFramezoomFactorSGIX = 33165,

    [NativeName("GL_INSTRUMENT_MEASUREMENTS_SGIX")]
    InstrumentMeasurementsSGIX = 33153,

    [NativeName("GL_INTERLACE_SGIX")]
    InterlaceSGIX = 32916,

    [NativeName("GL_IR_INSTRUMENT1_SGIX")]
    IrInstrument1SGIX = 33151,

    [NativeName("GL_PIXEL_TEX_GEN_SGIX")]
    PixelTexGenSGIX = 33081,

    [NativeName("GL_PIXEL_TEX_GEN_MODE_SGIX")]
    PixelTexGenModeSGIX = 33579,

    [NativeName("GL_PIXEL_TILE_BEST_ALIGNMENT_SGIX")]
    PixelTileBestAlignmentSGIX = 33086,

    [NativeName("GL_PIXEL_TILE_CACHE_INCREMENT_SGIX")]
    PixelTileCacheIncrementSGIX = 33087,

    [NativeName("GL_PIXEL_TILE_WIDTH_SGIX")]
    PixelTileWidthSGIX = 33088,

    [NativeName("GL_PIXEL_TILE_HEIGHT_SGIX")]
    PixelTileHeightSGIX = 33089,

    [NativeName("GL_PIXEL_TILE_GRID_WIDTH_SGIX")]
    PixelTileGridWidthSGIX = 33090,

    [NativeName("GL_PIXEL_TILE_GRID_HEIGHT_SGIX")]
    PixelTileGridHeightSGIX = 33091,

    [NativeName("GL_PIXEL_TILE_GRID_DEPTH_SGIX")]
    PixelTileGridDepthSGIX = 33092,

    [NativeName("GL_PIXEL_TILE_CACHE_SIZE_SGIX")]
    PixelTileCacheSizeSGIX = 33093,

    [NativeName("GL_DEFORMATIONS_MASK_SGIX")]
    DeformationsMaskSGIX = 33174,

    [NativeName("GL_REFERENCE_PLANE_SGIX")]
    ReferencePlaneSGIX = 33149,

    [NativeName("GL_REFERENCE_PLANE_EQUATION_SGIX")]
    ReferencePlaneEquationSGIX = 33150,

    [NativeName("GL_PACK_RESAMPLE_SGIX")]
    PackResampleSGIX = 33838,

    [NativeName("GL_UNPACK_RESAMPLE_SGIX")]
    UnpackResampleSGIX = 33839,

    [NativeName("GL_SPRITE_SGIX")]
    SpriteSGIX = 33096,

    [NativeName("GL_SPRITE_MODE_SGIX")]
    SpriteModeSGIX = 33097,

    [NativeName("GL_SPRITE_AXIS_SGIX")]
    SpriteAxisSGIX = 33098,

    [NativeName("GL_SPRITE_TRANSLATION_SGIX")]
    SpriteTranslationSGIX = 33099,

    [NativeName("GL_PACK_SUBSAMPLE_RATE_SGIX")]
    PackSubsampleRateSGIX = 34208,

    [NativeName("GL_UNPACK_SUBSAMPLE_RATE_SGIX")]
    UnpackSubsampleRateSGIX = 34209,

    [NativeName("GL_POST_TEXTURE_FILTER_BIAS_RANGE_SGIX")]
    PostTextureFilterBiasRangeSGIX = 33147,

    [NativeName("GL_POST_TEXTURE_FILTER_SCALE_RANGE_SGIX")]
    PostTextureFilterScaleRangeSGIX = 33148,

    [NativeName("GL_VERTEX_PRECLIP_SGIX")]
    VertexPreclipSGIX = 33774,

    [NativeName("GL_VERTEX_PRECLIP_HINT_SGIX")]
    VertexPreclipHintSGIX = 33775,

    [NativeName("GL_COLOR_MATRIX_SGI")]
    ColorMatrixSGI = 32945,

    [NativeName("GL_COLOR_MATRIX_STACK_DEPTH_SGI")]
    ColorMatrixStackDepthSGI = 32946,

    [NativeName("GL_MAX_COLOR_MATRIX_STACK_DEPTH_SGI")]
    MaxColorMatrixStackDepthSGI = 32947,

    [NativeName("GL_POST_COLOR_MATRIX_RED_SCALE_SGI")]
    PostColorMatrixRedScaleSGI = 32948,

    [NativeName("GL_POST_COLOR_MATRIX_GREEN_SCALE_SGI")]
    PostColorMatrixGreenScaleSGI = 32949,

    [NativeName("GL_POST_COLOR_MATRIX_BLUE_SCALE_SGI")]
    PostColorMatrixBlueScaleSGI = 32950,

    [NativeName("GL_POST_COLOR_MATRIX_ALPHA_SCALE_SGI")]
    PostColorMatrixAlphaScaleSGI = 32951,

    [NativeName("GL_POST_COLOR_MATRIX_RED_BIAS_SGI")]
    PostColorMatrixRedBiasSGI = 32952,

    [NativeName("GL_POST_COLOR_MATRIX_GREEN_BIAS_SGI")]
    PostColorMatrixGreenBiasSGI = 32953,

    [NativeName("GL_POST_COLOR_MATRIX_BLUE_BIAS_SGI")]
    PostColorMatrixBlueBiasSGI = 32954,

    [NativeName("GL_POST_COLOR_MATRIX_ALPHA_BIAS_SGI")]
    PostColorMatrixAlphaBiasSGI = 32955,

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

    [NativeName("GL_FRAGMENT_SHADER_FRAMEBUFFER_FETCH_MRT_ARM")]
    FragmentShaderFramebufferFetchMrtARM = 36710,

    [NativeName("GL_TIMESTAMP_EXT")]
    TimestampEXT = 36392,

    [NativeName("GL_SHADING_RATE_EXT")]
    ShadingRateEXT = 38608,

    [NativeName("GL_MIN_FRAGMENT_SHADING_RATE_ATTACHMENT_TEXEL_WIDTH_EXT")]
    MinFragmentShadingRateAttachmentTexelWidthEXT = 38615,

    [NativeName("GL_MAX_FRAGMENT_SHADING_RATE_ATTACHMENT_TEXEL_WIDTH_EXT")]
    MaxFragmentShadingRateAttachmentTexelWidthEXT = 38616,

    [NativeName("GL_MIN_FRAGMENT_SHADING_RATE_ATTACHMENT_TEXEL_HEIGHT_EXT")]
    MinFragmentShadingRateAttachmentTexelHeightEXT = 38617,

    [NativeName("GL_MAX_FRAGMENT_SHADING_RATE_ATTACHMENT_TEXEL_HEIGHT_EXT")]
    MaxFragmentShadingRateAttachmentTexelHeightEXT = 38618,

    [NativeName("GL_MAX_FRAGMENT_SHADING_RATE_ATTACHMENT_TEXEL_ASPECT_RATIO_EXT")]
    MaxFragmentShadingRateAttachmentTexelAspectRatioEXT = 38619,

    [NativeName("GL_MAX_FRAGMENT_SHADING_RATE_ATTACHMENT_LAYERS_EXT")]
    MaxFragmentShadingRateAttachmentLayersEXT = 38620,

    [NativeName("GL_FRAGMENT_SHADING_RATE_WITH_SHADER_DEPTH_STENCIL_WRITES_SUPPORTED_EXT")]
    FragmentShadingRateWithShaderDepthStencilWritesSupportedEXT = 38621,

    [NativeName("GL_FRAGMENT_SHADING_RATE_WITH_SAMPLE_MASK_SUPPORTED_EXT")]
    FragmentShadingRateWithSampleMaskSupportedEXT = 38622,

    [NativeName("GL_FRAGMENT_SHADING_RATE_ATTACHMENT_WITH_DEFAULT_FRAMEBUFFER_SUPPORTED_EXT")]
    FragmentShadingRateAttachmentWithDefaultFramebufferSupportedEXT = 38623,

    [NativeName("GL_FRAGMENT_SHADING_RATE_NON_TRIVIAL_COMBINERS_SUPPORTED_EXT")]
    FragmentShadingRateNonTrivialCombinersSupportedEXT = 36719,

    [NativeName("GL_DRAW_BUFFER_EXT")]
    DrawBufferEXT = 3073,

    [NativeName("GL_READ_BUFFER_EXT")]
    ReadBufferEXT = 3074,

    [NativeName("GL_MAX_COLOR_ATTACHMENTS_NV")]
    MaxColorAttachmentsNV = 36063,

    [NativeName("GL_PACK_ROW_LENGTH_NV")]
    PackRowLengthNV = 3330,

    [NativeName("GL_PACK_SKIP_ROWS_NV")]
    PackSkipRowsNV = 3331,

    [NativeName("GL_PACK_SKIP_PIXELS_NV")]
    PackSkipPixelsNV = 3332,

    [NativeName("GL_READ_BUFFER_NV")]
    ReadBufferNV = 3074,

    [NativeName("GL_ALPHA_TEST_QCOM")]
    AlphaTestQCOM = 3008,

    [NativeName("GL_ALPHA_TEST_FUNC_QCOM")]
    AlphaTestFuncQCOM = 3009,

    [NativeName("GL_ALPHA_TEST_REF_QCOM")]
    AlphaTestRefQCOM = 3010,

    [NativeName("GL_MOTION_ESTIMATION_SEARCH_BLOCK_X_QCOM")]
    MotionEstimationSearchBlockXQCOM = 35984,

    [NativeName("GL_MOTION_ESTIMATION_SEARCH_BLOCK_Y_QCOM")]
    MotionEstimationSearchBlockYQCOM = 35985,

    [NativeName("GL_FRAMEBUFFER_FETCH_NONCOHERENT_QCOM")]
    FramebufferFetchNoncoherentQCOM = 38562,

    [NativeName("GL_SHADING_RATE_QCOM")]
    ShadingRateQCOM = 38564,

    [NativeName("GL_BLEND_EQUATION_OES")]
    BlendEquationOES = 32777,

    [NativeName("GL_TEXTURE_BINDING_CUBE_MAP_OES")]
    TextureBindingCubeMapOES = 34068,

    [NativeName("GL_MAX_CUBE_MAP_TEXTURE_SIZE_OES")]
    MaxCubeMapTextureSizeOES = 34076,

    [NativeName("GL_TEXTURE_GEN_STR_OES")]
    TextureGenStrOES = 36192,
}
