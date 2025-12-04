// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("GLEnum")]
public enum GlEnum : uint
{
    [NativeName("GL_VERSION_ES_CL_1_0")]
    VersionEsCl1X0 = 1,

    [NativeName("GL_VERSION_ES_CM_1_1")]
    VersionEsCm1X1 = 1,

    [NativeName("GL_VERSION_ES_CL_1_1")]
    VersionEsCl1X1 = 1,

    [NativeName("GL_DEPTH_BUFFER_BIT")]
    DepthBufferBit = 256,

    [NativeName("GL_STENCIL_BUFFER_BIT")]
    StencilBufferBit = 1024,

    [NativeName("GL_COLOR_BUFFER_BIT")]
    ColorBufferBit = 16384,

    [NativeName("GL_FALSE")]
    False = 0,

    [NativeName("GL_TRUE")]
    True = 1,

    [NativeName("GL_POINTS")]
    Points = 0,

    [NativeName("GL_LINES")]
    Lines = 1,

    [NativeName("GL_LINE_LOOP")]
    LineLoop = 2,

    [NativeName("GL_LINE_STRIP")]
    LineStrip = 3,

    [NativeName("GL_TRIANGLES")]
    Triangles = 4,

    [NativeName("GL_TRIANGLE_STRIP")]
    TriangleStrip = 5,

    [NativeName("GL_TRIANGLE_FAN")]
    TriangleFan = 6,

    [NativeName("GL_NEVER")]
    Never = 512,

    [NativeName("GL_LESS")]
    Less = 513,

    [NativeName("GL_EQUAL")]
    Equal = 514,

    [NativeName("GL_LEQUAL")]
    Lequal = 515,

    [NativeName("GL_GREATER")]
    Greater = 516,

    [NativeName("GL_NOTEQUAL")]
    Notequal = 517,

    [NativeName("GL_GEQUAL")]
    Gequal = 518,

    [NativeName("GL_ALWAYS")]
    Always = 519,

    [NativeName("GL_ZERO")]
    Zero = 0,

    [NativeName("GL_ONE")]
    One = 1,

    [NativeName("GL_SRC_COLOR")]
    SrcColor = 768,

    [NativeName("GL_ONE_MINUS_SRC_COLOR")]
    OneMinusSrcColor = 769,

    [NativeName("GL_SRC_ALPHA")]
    SrcAlpha = 770,

    [NativeName("GL_ONE_MINUS_SRC_ALPHA")]
    OneMinusSrcAlpha = 771,

    [NativeName("GL_DST_ALPHA")]
    DstAlpha = 772,

    [NativeName("GL_ONE_MINUS_DST_ALPHA")]
    OneMinusDstAlpha = 773,

    [NativeName("GL_DST_COLOR")]
    DstColor = 774,

    [NativeName("GL_ONE_MINUS_DST_COLOR")]
    OneMinusDstColor = 775,

    [NativeName("GL_SRC_ALPHA_SATURATE")]
    SrcAlphaSaturate = 776,

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

    [NativeName("GL_FRONT")]
    Front = 1028,

    [NativeName("GL_BACK")]
    Back = 1029,

    [NativeName("GL_FRONT_AND_BACK")]
    FrontAndBack = 1032,

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

    [NativeName("GL_RESCALE_NORMAL")]
    RescaleNormal = 32826,

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

    [NativeName("GL_NO_ERROR")]
    NoError = 0,

    [NativeName("GL_INVALID_ENUM")]
    InvalidEnum = 1280,

    [NativeName("GL_INVALID_VALUE")]
    InvalidValue = 1281,

    [NativeName("GL_INVALID_OPERATION")]
    InvalidOperation = 1282,

    [NativeName("GL_STACK_OVERFLOW")]
    StackOverflow = 1283,

    [NativeName("GL_STACK_UNDERFLOW")]
    StackUnderflow = 1284,

    [NativeName("GL_OUT_OF_MEMORY")]
    OutOfMemory = 1285,

    [NativeName("GL_EXP")]
    Exp = 2048,

    [NativeName("GL_EXP2")]
    Exp2 = 2049,

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

    [NativeName("GL_CW")]
    Cw = 2304,

    [NativeName("GL_CCW")]
    Ccw = 2305,

    [NativeName("GL_CURRENT_COLOR")]
    CurrentColor = 2816,

    [NativeName("GL_CURRENT_NORMAL")]
    CurrentNormal = 2818,

    [NativeName("GL_CURRENT_TEXTURE_COORDS")]
    CurrentTextureCoords = 2819,

    [NativeName("GL_POINT_SIZE")]
    PointSize = 2833,

    [NativeName("GL_POINT_SIZE_MIN")]
    PointSizeMin = 33062,

    [NativeName("GL_POINT_SIZE_MAX")]
    PointSizeMax = 33063,

    [NativeName("GL_POINT_FADE_THRESHOLD_SIZE")]
    PointFadeThresholdSize = 33064,

    [NativeName("GL_POINT_DISTANCE_ATTENUATION")]
    PointDistanceAttenuation = 33065,

    [NativeName("GL_SMOOTH_POINT_SIZE_RANGE")]
    SmoothPointSizeRange = 2834,

    [NativeName("GL_LINE_WIDTH")]
    LineWidth = 2849,

    [NativeName("GL_SMOOTH_LINE_WIDTH_RANGE")]
    SmoothLineWidthRange = 2850,

    [NativeName("GL_ALIASED_POINT_SIZE_RANGE")]
    AliasedPointSizeRange = 33901,

    [NativeName("GL_ALIASED_LINE_WIDTH_RANGE")]
    AliasedLineWidthRange = 33902,

    [NativeName("GL_CULL_FACE_MODE")]
    CullFaceMode = 2885,

    [NativeName("GL_FRONT_FACE")]
    FrontFace = 2886,

    [NativeName("GL_SHADE_MODEL")]
    ShadeModel = 2900,

    [NativeName("GL_DEPTH_RANGE")]
    DepthRange = 2928,

    [NativeName("GL_DEPTH_WRITEMASK")]
    DepthWritemask = 2930,

    [NativeName("GL_DEPTH_CLEAR_VALUE")]
    DepthClearValue = 2931,

    [NativeName("GL_DEPTH_FUNC")]
    DepthFunc = 2932,

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

    [NativeName("GL_MATRIX_MODE")]
    MatrixMode = 2976,

    [NativeName("GL_VIEWPORT")]
    Viewport = 2978,

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

    [NativeName("GL_ALPHA_TEST_FUNC")]
    AlphaTestFunc = 3009,

    [NativeName("GL_ALPHA_TEST_REF")]
    AlphaTestRef = 3010,

    [NativeName("GL_BLEND_DST")]
    BlendDst = 3040,

    [NativeName("GL_BLEND_SRC")]
    BlendSrc = 3041,

    [NativeName("GL_LOGIC_OP_MODE")]
    LogicOpMode = 3056,

    [NativeName("GL_SCISSOR_BOX")]
    ScissorBox = 3088,

    [NativeName("GL_COLOR_CLEAR_VALUE")]
    ColorClearValue = 3106,

    [NativeName("GL_COLOR_WRITEMASK")]
    ColorWritemask = 3107,

    [NativeName("GL_MAX_LIGHTS")]
    MaxLights = 3377,

    [NativeName("GL_MAX_CLIP_PLANES")]
    MaxClipPlanes = 3378,

    [NativeName("GL_MAX_TEXTURE_SIZE")]
    MaxTextureSize = 3379,

    [NativeName("GL_MAX_MODELVIEW_STACK_DEPTH")]
    MaxModelviewStackDepth = 3382,

    [NativeName("GL_MAX_PROJECTION_STACK_DEPTH")]
    MaxProjectionStackDepth = 3384,

    [NativeName("GL_MAX_TEXTURE_STACK_DEPTH")]
    MaxTextureStackDepth = 3385,

    [NativeName("GL_MAX_VIEWPORT_DIMS")]
    MaxViewportDims = 3386,

    [NativeName("GL_MAX_TEXTURE_UNITS")]
    MaxTextureUnits = 34018,

    [NativeName("GL_SUBPIXEL_BITS")]
    SubpixelBits = 3408,

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

    [NativeName("GL_POLYGON_OFFSET_UNITS")]
    PolygonOffsetUnits = 10752,

    [NativeName("GL_POLYGON_OFFSET_FILL")]
    PolygonOffsetFill = 32823,

    [NativeName("GL_POLYGON_OFFSET_FACTOR")]
    PolygonOffsetFactor = 32824,

    [NativeName("GL_TEXTURE_BINDING_2D")]
    TextureBinding2D = 32873,

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

    [NativeName("GL_TEXTURE_COORD_ARRAY_SIZE")]
    TextureCoordArraySize = 32904,

    [NativeName("GL_TEXTURE_COORD_ARRAY_TYPE")]
    TextureCoordArrayType = 32905,

    [NativeName("GL_TEXTURE_COORD_ARRAY_STRIDE")]
    TextureCoordArrayStride = 32906,

    [NativeName("GL_VERTEX_ARRAY_POINTER")]
    VertexArrayPointer = 32910,

    [NativeName("GL_NORMAL_ARRAY_POINTER")]
    NormalArrayPointer = 32911,

    [NativeName("GL_COLOR_ARRAY_POINTER")]
    ColorArrayPointer = 32912,

    [NativeName("GL_TEXTURE_COORD_ARRAY_POINTER")]
    TextureCoordArrayPointer = 32914,

    [NativeName("GL_SAMPLE_BUFFERS")]
    SampleBuffers = 32936,

    [NativeName("GL_SAMPLES")]
    Samples = 32937,

    [NativeName("GL_SAMPLE_COVERAGE_VALUE")]
    SampleCoverageValue = 32938,

    [NativeName("GL_SAMPLE_COVERAGE_INVERT")]
    SampleCoverageInvert = 32939,

    [NativeName("GL_NUM_COMPRESSED_TEXTURE_FORMATS")]
    NumCompressedTextureFormats = 34466,

    [NativeName("GL_COMPRESSED_TEXTURE_FORMATS")]
    CompressedTextureFormats = 34467,

    [NativeName("GL_DONT_CARE")]
    DontCare = 4352,

    [NativeName("GL_FASTEST")]
    Fastest = 4353,

    [NativeName("GL_NICEST")]
    Nicest = 4354,

    [NativeName("GL_PERSPECTIVE_CORRECTION_HINT")]
    PerspectiveCorrectionHint = 3152,

    [NativeName("GL_POINT_SMOOTH_HINT")]
    PointSmoothHint = 3153,

    [NativeName("GL_LINE_SMOOTH_HINT")]
    LineSmoothHint = 3154,

    [NativeName("GL_FOG_HINT")]
    FogHint = 3156,

    [NativeName("GL_GENERATE_MIPMAP_HINT")]
    GenerateMipmapHint = 33170,

    [NativeName("GL_LIGHT_MODEL_AMBIENT")]
    LightModelAmbient = 2899,

    [NativeName("GL_LIGHT_MODEL_TWO_SIDE")]
    LightModelTwoSide = 2898,

    [NativeName("GL_AMBIENT")]
    Ambient = 4608,

    [NativeName("GL_DIFFUSE")]
    Diffuse = 4609,

    [NativeName("GL_SPECULAR")]
    Specular = 4610,

    [NativeName("GL_POSITION")]
    Position = 4611,

    [NativeName("GL_SPOT_DIRECTION")]
    SpotDirection = 4612,

    [NativeName("GL_SPOT_EXPONENT")]
    SpotExponent = 4613,

    [NativeName("GL_SPOT_CUTOFF")]
    SpotCutoff = 4614,

    [NativeName("GL_CONSTANT_ATTENUATION")]
    ConstantAttenuation = 4615,

    [NativeName("GL_LINEAR_ATTENUATION")]
    LinearAttenuation = 4616,

    [NativeName("GL_QUADRATIC_ATTENUATION")]
    QuadraticAttenuation = 4617,

    [NativeName("GL_BYTE")]
    Byte = 5120,

    [NativeName("GL_UNSIGNED_BYTE")]
    UnsignedByte = 5121,

    [NativeName("GL_SHORT")]
    Short = 5122,

    [NativeName("GL_UNSIGNED_SHORT")]
    UnsignedShort = 5123,

    [NativeName("GL_FLOAT")]
    Float = 5126,

    [NativeName("GL_FIXED")]
    Fixed = 5132,

    [NativeName("GL_CLEAR")]
    Clear = 5376,

    [NativeName("GL_AND")]
    And = 5377,

    [NativeName("GL_AND_REVERSE")]
    AndReverse = 5378,

    [NativeName("GL_COPY")]
    Copy = 5379,

    [NativeName("GL_AND_INVERTED")]
    AndInverted = 5380,

    [NativeName("GL_NOOP")]
    Noop = 5381,

    [NativeName("GL_XOR")]
    Xor = 5382,

    [NativeName("GL_OR")]
    Or = 5383,

    [NativeName("GL_NOR")]
    Nor = 5384,

    [NativeName("GL_EQUIV")]
    Equiv = 5385,

    [NativeName("GL_INVERT")]
    Invert = 5386,

    [NativeName("GL_OR_REVERSE")]
    OrReverse = 5387,

    [NativeName("GL_COPY_INVERTED")]
    CopyInverted = 5388,

    [NativeName("GL_OR_INVERTED")]
    OrInverted = 5389,

    [NativeName("GL_NAND")]
    Nand = 5390,

    [NativeName("GL_SET")]
    Set = 5391,

    [NativeName("GL_EMISSION")]
    Emission = 5632,

    [NativeName("GL_SHININESS")]
    Shininess = 5633,

    [NativeName("GL_AMBIENT_AND_DIFFUSE")]
    AmbientAndDiffuse = 5634,

    [NativeName("GL_MODELVIEW")]
    Modelview = 5888,

    [NativeName("GL_PROJECTION")]
    Projection = 5889,

    [NativeName("GL_TEXTURE")]
    Texture = 5890,

    [NativeName("GL_ALPHA")]
    Alpha = 6406,

    [NativeName("GL_RGB")]
    Rgb = 6407,

    [NativeName("GL_RGBA")]
    Rgba = 6408,

    [NativeName("GL_LUMINANCE")]
    Luminance = 6409,

    [NativeName("GL_LUMINANCE_ALPHA")]
    LuminanceAlpha = 6410,

    [NativeName("GL_UNPACK_ALIGNMENT")]
    UnpackAlignment = 3317,

    [NativeName("GL_PACK_ALIGNMENT")]
    PackAlignment = 3333,

    [NativeName("GL_UNSIGNED_SHORT_4_4_4_4")]
    UnsignedShort4X4X4X4 = 32819,

    [NativeName("GL_UNSIGNED_SHORT_5_5_5_1")]
    UnsignedShort5X5X5X1 = 32820,

    [NativeName("GL_UNSIGNED_SHORT_5_6_5")]
    UnsignedShort5X6X5 = 33635,

    [NativeName("GL_FLAT")]
    Flat = 7424,

    [NativeName("GL_SMOOTH")]
    Smooth = 7425,

    [NativeName("GL_KEEP")]
    Keep = 7680,

    [NativeName("GL_REPLACE")]
    Replace = 7681,

    [NativeName("GL_INCR")]
    Incr = 7682,

    [NativeName("GL_DECR")]
    Decr = 7683,

    [NativeName("GL_VENDOR")]
    Vendor = 7936,

    [NativeName("GL_RENDERER")]
    Renderer = 7937,

    [NativeName("GL_VERSION")]
    Version = 7938,

    [NativeName("GL_EXTENSIONS")]
    Extensions = 7939,

    [NativeName("GL_MODULATE")]
    Modulate = 8448,

    [NativeName("GL_DECAL")]
    Decal = 8449,

    [NativeName("GL_ADD")]
    Add = 260,

    [NativeName("GL_TEXTURE_ENV_MODE")]
    TextureEnvMode = 8704,

    [NativeName("GL_TEXTURE_ENV_COLOR")]
    TextureEnvColor = 8705,

    [NativeName("GL_TEXTURE_ENV")]
    TextureENV = 8960,

    [NativeName("GL_NEAREST")]
    Nearest = 9728,

    [NativeName("GL_LINEAR")]
    Linear = 9729,

    [NativeName("GL_NEAREST_MIPMAP_NEAREST")]
    NearestMipmapNearest = 9984,

    [NativeName("GL_LINEAR_MIPMAP_NEAREST")]
    LinearMipmapNearest = 9985,

    [NativeName("GL_NEAREST_MIPMAP_LINEAR")]
    NearestMipmapLinear = 9986,

    [NativeName("GL_LINEAR_MIPMAP_LINEAR")]
    LinearMipmapLinear = 9987,

    [NativeName("GL_TEXTURE_MAG_FILTER")]
    TextureMagFilter = 10240,

    [NativeName("GL_TEXTURE_MIN_FILTER")]
    TextureMinFilter = 10241,

    [NativeName("GL_TEXTURE_WRAP_S")]
    TextureWrapS = 10242,

    [NativeName("GL_TEXTURE_WRAP_T")]
    TextureWrapT = 10243,

    [NativeName("GL_GENERATE_MIPMAP")]
    GenerateMipmap = 33169,

    [NativeName("GL_TEXTURE0")]
    Texture0 = 33984,

    [NativeName("GL_TEXTURE1")]
    Texture1 = 33985,

    [NativeName("GL_TEXTURE2")]
    Texture2 = 33986,

    [NativeName("GL_TEXTURE3")]
    Texture3 = 33987,

    [NativeName("GL_TEXTURE4")]
    Texture4 = 33988,

    [NativeName("GL_TEXTURE5")]
    Texture5 = 33989,

    [NativeName("GL_TEXTURE6")]
    Texture6 = 33990,

    [NativeName("GL_TEXTURE7")]
    Texture7 = 33991,

    [NativeName("GL_TEXTURE8")]
    Texture8 = 33992,

    [NativeName("GL_TEXTURE9")]
    Texture9 = 33993,

    [NativeName("GL_TEXTURE10")]
    Texture10 = 33994,

    [NativeName("GL_TEXTURE11")]
    Texture11 = 33995,

    [NativeName("GL_TEXTURE12")]
    Texture12 = 33996,

    [NativeName("GL_TEXTURE13")]
    Texture13 = 33997,

    [NativeName("GL_TEXTURE14")]
    Texture14 = 33998,

    [NativeName("GL_TEXTURE15")]
    Texture15 = 33999,

    [NativeName("GL_TEXTURE16")]
    Texture16 = 34000,

    [NativeName("GL_TEXTURE17")]
    Texture17 = 34001,

    [NativeName("GL_TEXTURE18")]
    Texture18 = 34002,

    [NativeName("GL_TEXTURE19")]
    Texture19 = 34003,

    [NativeName("GL_TEXTURE20")]
    Texture20 = 34004,

    [NativeName("GL_TEXTURE21")]
    Texture21 = 34005,

    [NativeName("GL_TEXTURE22")]
    Texture22 = 34006,

    [NativeName("GL_TEXTURE23")]
    Texture23 = 34007,

    [NativeName("GL_TEXTURE24")]
    Texture24 = 34008,

    [NativeName("GL_TEXTURE25")]
    Texture25 = 34009,

    [NativeName("GL_TEXTURE26")]
    Texture26 = 34010,

    [NativeName("GL_TEXTURE27")]
    Texture27 = 34011,

    [NativeName("GL_TEXTURE28")]
    Texture28 = 34012,

    [NativeName("GL_TEXTURE29")]
    Texture29 = 34013,

    [NativeName("GL_TEXTURE30")]
    Texture30 = 34014,

    [NativeName("GL_TEXTURE31")]
    Texture31 = 34015,

    [NativeName("GL_ACTIVE_TEXTURE")]
    ActiveTexture = 34016,

    [NativeName("GL_CLIENT_ACTIVE_TEXTURE")]
    ClientActiveTexture = 34017,

    [NativeName("GL_REPEAT")]
    Repeat = 10497,

    [NativeName("GL_CLAMP_TO_EDGE")]
    ClampToEdge = 33071,

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

    [NativeName("GL_ARRAY_BUFFER")]
    ArrayBuffer = 34962,

    [NativeName("GL_ELEMENT_ARRAY_BUFFER")]
    ElementArrayBuffer = 34963,

    [NativeName("GL_ARRAY_BUFFER_BINDING")]
    ArrayBufferBinding = 34964,

    [NativeName("GL_ELEMENT_ARRAY_BUFFER_BINDING")]
    ElementArrayBufferBinding = 34965,

    [NativeName("GL_VERTEX_ARRAY_BUFFER_BINDING")]
    VertexArrayBufferBinding = 34966,

    [NativeName("GL_NORMAL_ARRAY_BUFFER_BINDING")]
    NormalArrayBufferBinding = 34967,

    [NativeName("GL_COLOR_ARRAY_BUFFER_BINDING")]
    ColorArrayBufferBinding = 34968,

    [NativeName("GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING")]
    TextureCoordArrayBufferBinding = 34970,

    [NativeName("GL_STATIC_DRAW")]
    StaticDraw = 35044,

    [NativeName("GL_DYNAMIC_DRAW")]
    DynamicDraw = 35048,

    [NativeName("GL_BUFFER_SIZE")]
    BufferSize = 34660,

    [NativeName("GL_BUFFER_USAGE")]
    BufferUsage = 34661,

    [NativeName("GL_SUBTRACT")]
    Subtract = 34023,

    [NativeName("GL_COMBINE")]
    Combine = 34160,

    [NativeName("GL_COMBINE_RGB")]
    CombineRgb = 34161,

    [NativeName("GL_COMBINE_ALPHA")]
    CombineAlpha = 34162,

    [NativeName("GL_RGB_SCALE")]
    RgbScale = 34163,

    [NativeName("GL_ADD_SIGNED")]
    AddSigned = 34164,

    [NativeName("GL_INTERPOLATE")]
    Interpolate = 34165,

    [NativeName("GL_CONSTANT")]
    Constant = 34166,

    [NativeName("GL_PRIMARY_COLOR")]
    PrimaryColor = 34167,

    [NativeName("GL_PREVIOUS")]
    Previous = 34168,

    [NativeName("GL_OPERAND0_RGB")]
    Operand0Rgb = 34192,

    [NativeName("GL_OPERAND1_RGB")]
    Operand1Rgb = 34193,

    [NativeName("GL_OPERAND2_RGB")]
    Operand2Rgb = 34194,

    [NativeName("GL_OPERAND0_ALPHA")]
    Operand0Alpha = 34200,

    [NativeName("GL_OPERAND1_ALPHA")]
    Operand1Alpha = 34201,

    [NativeName("GL_OPERAND2_ALPHA")]
    Operand2Alpha = 34202,

    [NativeName("GL_ALPHA_SCALE")]
    AlphaScale = 3356,

    [NativeName("GL_SRC0_RGB")]
    Src0Rgb = 34176,

    [NativeName("GL_SRC1_RGB")]
    Src1Rgb = 34177,

    [NativeName("GL_SRC2_RGB")]
    Src2Rgb = 34178,

    [NativeName("GL_SRC0_ALPHA")]
    Src0Alpha = 34184,

    [NativeName("GL_SRC1_ALPHA")]
    Src1Alpha = 34185,

    [NativeName("GL_SRC2_ALPHA")]
    Src2Alpha = 34186,

    [NativeName("GL_DOT3_RGB")]
    Dot3Rgb = 34478,

    [NativeName("GL_DOT3_RGBA")]
    Dot3Rgba = 34479,

    [NativeName("GL_TEXTURE_EXTERNAL_OES")]
    TextureExternalOES = 36197,

    [NativeName("GL_TEXTURE_BINDING_EXTERNAL_OES")]
    TextureBindingExternalOES = 36199,

    [NativeName("GL_REQUIRED_TEXTURE_IMAGE_UNITS_OES")]
    RequiredTextureImageUnitsOES = 36200,

    [NativeName("GL_BLEND_EQUATION_RGB_OES")]
    BlendEquationRgbOES = 32777,

    [NativeName("GL_BLEND_EQUATION_ALPHA_OES")]
    BlendEquationAlphaOES = 34877,

    [NativeName("GL_BLEND_DST_RGB_OES")]
    BlendDstRgbOES = 32968,

    [NativeName("GL_BLEND_SRC_RGB_OES")]
    BlendSrcRgbOES = 32969,

    [NativeName("GL_BLEND_DST_ALPHA_OES")]
    BlendDstAlphaOES = 32970,

    [NativeName("GL_BLEND_SRC_ALPHA_OES")]
    BlendSrcAlphaOES = 32971,

    [NativeName("GL_BLEND_EQUATION_OES")]
    BlendEquationOES = 32777,

    [NativeName("GL_FUNC_ADD_OES")]
    FuncAddOES = 32774,

    [NativeName("GL_FUNC_SUBTRACT_OES")]
    FuncSubtractOES = 32778,

    [NativeName("GL_FUNC_REVERSE_SUBTRACT_OES")]
    FuncReverseSubtractOES = 32779,

    [NativeName("GL_ETC1_RGB8_OES")]
    Etc1Rgb8OES = 36196,

    [NativeName("GL_PALETTE4_RGB8_OES")]
    Palette4Rgb8OES = 35728,

    [NativeName("GL_PALETTE4_RGBA8_OES")]
    Palette4Rgba8OES = 35729,

    [NativeName("GL_PALETTE4_R5_G6_B5_OES")]
    Palette4R5G6B5OES = 35730,

    [NativeName("GL_PALETTE4_RGBA4_OES")]
    Palette4Rgba4OES = 35731,

    [NativeName("GL_PALETTE4_RGB5_A1_OES")]
    Palette4Rgb5A1OES = 35732,

    [NativeName("GL_PALETTE8_RGB8_OES")]
    Palette8Rgb8OES = 35733,

    [NativeName("GL_PALETTE8_RGBA8_OES")]
    Palette8Rgba8OES = 35734,

    [NativeName("GL_PALETTE8_R5_G6_B5_OES")]
    Palette8R5G6B5OES = 35735,

    [NativeName("GL_PALETTE8_RGBA4_OES")]
    Palette8Rgba4OES = 35736,

    [NativeName("GL_PALETTE8_RGB5_A1_OES")]
    Palette8Rgb5A1OES = 35737,

    [NativeName("GL_DEPTH_COMPONENT24_OES")]
    DepthComponent24OES = 33190,

    [NativeName("GL_DEPTH_COMPONENT32_OES")]
    DepthComponent32OES = 33191,

    [NativeName("GL_TEXTURE_CROP_RECT_OES")]
    TextureCropRectOES = 35741,

    [NativeName("GL_UNSIGNED_INT")]
    UnsignedInt = 5125,

    [NativeName("GL_FIXED_OES")]
    FixedOES = 5132,

    [NativeName("GL_NONE_OES")]
    NoneOES = 0,

    [NativeName("GL_FRAMEBUFFER_OES")]
    FramebufferOES = 36160,

    [NativeName("GL_RENDERBUFFER_OES")]
    RenderbufferOES = 36161,

    [NativeName("GL_RGBA4_OES")]
    Rgba4OES = 32854,

    [NativeName("GL_RGB5_A1_OES")]
    Rgb5A1OES = 32855,

    [NativeName("GL_RGB565_OES")]
    Rgb565OES = 36194,

    [NativeName("GL_DEPTH_COMPONENT16_OES")]
    DepthComponent16OES = 33189,

    [NativeName("GL_RENDERBUFFER_WIDTH_OES")]
    RenderbufferWidthOES = 36162,

    [NativeName("GL_RENDERBUFFER_HEIGHT_OES")]
    RenderbufferHeightOES = 36163,

    [NativeName("GL_RENDERBUFFER_INTERNAL_FORMAT_OES")]
    RenderbufferInternalFormatOES = 36164,

    [NativeName("GL_RENDERBUFFER_RED_SIZE_OES")]
    RenderbufferRedSizeOES = 36176,

    [NativeName("GL_RENDERBUFFER_GREEN_SIZE_OES")]
    RenderbufferGreenSizeOES = 36177,

    [NativeName("GL_RENDERBUFFER_BLUE_SIZE_OES")]
    RenderbufferBlueSizeOES = 36178,

    [NativeName("GL_RENDERBUFFER_ALPHA_SIZE_OES")]
    RenderbufferAlphaSizeOES = 36179,

    [NativeName("GL_RENDERBUFFER_DEPTH_SIZE_OES")]
    RenderbufferDepthSizeOES = 36180,

    [NativeName("GL_RENDERBUFFER_STENCIL_SIZE_OES")]
    RenderbufferStencilSizeOES = 36181,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_OES")]
    FramebufferAttachmentObjectTypeOES = 36048,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_OES")]
    FramebufferAttachmentObjectNameOES = 36049,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_OES")]
    FramebufferAttachmentTextureLevelOES = 36050,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_OES")]
    FramebufferAttachmentTextureCubeMapFaceOES = 36051,

    [NativeName("GL_COLOR_ATTACHMENT0_OES")]
    ColorAttachment0OES = 36064,

    [NativeName("GL_DEPTH_ATTACHMENT_OES")]
    DepthAttachmentOES = 36096,

    [NativeName("GL_STENCIL_ATTACHMENT_OES")]
    StencilAttachmentOES = 36128,

    [NativeName("GL_FRAMEBUFFER_COMPLETE_OES")]
    FramebufferCompleteOES = 36053,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_OES")]
    FramebufferIncompleteAttachmentOES = 36054,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_OES")]
    FramebufferIncompleteMissingAttachmentOES = 36055,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_OES")]
    FramebufferIncompleteDimensionsOES = 36057,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_FORMATS_OES")]
    FramebufferIncompleteFormatsOES = 36058,

    [NativeName("GL_FRAMEBUFFER_UNSUPPORTED_OES")]
    FramebufferUnsupportedOES = 36061,

    [NativeName("GL_FRAMEBUFFER_BINDING_OES")]
    FramebufferBindingOES = 36006,

    [NativeName("GL_RENDERBUFFER_BINDING_OES")]
    RenderbufferBindingOES = 36007,

    [NativeName("GL_MAX_RENDERBUFFER_SIZE_OES")]
    MaxRenderbufferSizeOES = 34024,

    [NativeName("GL_INVALID_FRAMEBUFFER_OPERATION_OES")]
    InvalidFramebufferOperationOES = 1286,

    [NativeName("GL_WRITE_ONLY_OES")]
    WriteOnlyOES = 35001,

    [NativeName("GL_BUFFER_ACCESS_OES")]
    BufferAccessOES = 35003,

    [NativeName("GL_BUFFER_MAPPED_OES")]
    BufferMappedOES = 35004,

    [NativeName("GL_BUFFER_MAP_POINTER_OES")]
    BufferMapPointerOES = 35005,

    [NativeName("GL_MODELVIEW_MATRIX_FLOAT_AS_INT_BITS_OES")]
    ModelviewMatrixFloatAsIntBitsOES = 35213,

    [NativeName("GL_PROJECTION_MATRIX_FLOAT_AS_INT_BITS_OES")]
    ProjectionMatrixFloatAsIntBitsOES = 35214,

    [NativeName("GL_TEXTURE_MATRIX_FLOAT_AS_INT_BITS_OES")]
    TextureMatrixFloatAsIntBitsOES = 35215,

    [NativeName("GL_MAX_VERTEX_UNITS_OES")]
    MaxVertexUnitsOES = 34468,

    [NativeName("GL_MAX_PALETTE_MATRICES_OES")]
    MaxPaletteMatricesOES = 34882,

    [NativeName("GL_MATRIX_PALETTE_OES")]
    MatrixPaletteOES = 34880,

    [NativeName("GL_MATRIX_INDEX_ARRAY_OES")]
    MatrixIndexArrayOES = 34884,

    [NativeName("GL_WEIGHT_ARRAY_OES")]
    WeightArrayOES = 34477,

    [NativeName("GL_CURRENT_PALETTE_MATRIX_OES")]
    CurrentPaletteMatrixOES = 34883,

    [NativeName("GL_MATRIX_INDEX_ARRAY_SIZE_OES")]
    MatrixIndexArraySizeOES = 34886,

    [NativeName("GL_MATRIX_INDEX_ARRAY_TYPE_OES")]
    MatrixIndexArrayTypeOES = 34887,

    [NativeName("GL_MATRIX_INDEX_ARRAY_STRIDE_OES")]
    MatrixIndexArrayStrideOES = 34888,

    [NativeName("GL_MATRIX_INDEX_ARRAY_POINTER_OES")]
    MatrixIndexArrayPointerOES = 34889,

    [NativeName("GL_MATRIX_INDEX_ARRAY_BUFFER_BINDING_OES")]
    MatrixIndexArrayBufferBindingOES = 35742,

    [NativeName("GL_WEIGHT_ARRAY_SIZE_OES")]
    WeightArraySizeOES = 34475,

    [NativeName("GL_WEIGHT_ARRAY_TYPE_OES")]
    WeightArrayTypeOES = 34473,

    [NativeName("GL_WEIGHT_ARRAY_STRIDE_OES")]
    WeightArrayStrideOES = 34474,

    [NativeName("GL_WEIGHT_ARRAY_POINTER_OES")]
    WeightArrayPointerOES = 34476,

    [NativeName("GL_WEIGHT_ARRAY_BUFFER_BINDING_OES")]
    WeightArrayBufferBindingOES = 34974,

    [NativeName("GL_DEPTH_STENCIL_OES")]
    DepthStencilOES = 34041,

    [NativeName("GL_UNSIGNED_INT_24_8_OES")]
    UnsignedInt24X8OES = 34042,

    [NativeName("GL_DEPTH24_STENCIL8_OES")]
    Depth24Stencil8OES = 35056,

    [NativeName("GL_POINT_SIZE_ARRAY_OES")]
    PointSizeArrayOES = 35740,

    [NativeName("GL_POINT_SIZE_ARRAY_TYPE_OES")]
    PointSizeArrayTypeOES = 35210,

    [NativeName("GL_POINT_SIZE_ARRAY_STRIDE_OES")]
    PointSizeArrayStrideOES = 35211,

    [NativeName("GL_POINT_SIZE_ARRAY_POINTER_OES")]
    PointSizeArrayPointerOES = 35212,

    [NativeName("GL_POINT_SIZE_ARRAY_BUFFER_BINDING_OES")]
    PointSizeArrayBufferBindingOES = 35743,

    [NativeName("GL_POINT_SPRITE_OES")]
    PointSpriteOES = 34913,

    [NativeName("GL_COORD_REPLACE_OES")]
    CoordReplaceOES = 34914,

    [NativeName("GL_IMPLEMENTATION_COLOR_READ_TYPE_OES")]
    ImplementationColorReadTypeOES = 35738,

    [NativeName("GL_IMPLEMENTATION_COLOR_READ_FORMAT_OES")]
    ImplementationColorReadFormatOES = 35739,

    [NativeName("GL_ALPHA8_OES")]
    Alpha8OES = 32828,

    [NativeName("GL_LUMINANCE4_ALPHA4_OES")]
    Luminance4Alpha4OES = 32835,

    [NativeName("GL_LUMINANCE8_ALPHA8_OES")]
    Luminance8Alpha8OES = 32837,

    [NativeName("GL_LUMINANCE8_OES")]
    Luminance8OES = 32832,

    [NativeName("GL_RGB8_OES")]
    Rgb8OES = 32849,

    [NativeName("GL_RGBA8_OES")]
    Rgba8OES = 32856,

    [NativeName("GL_RGB10_EXT")]
    Rgb10EXT = 32850,

    [NativeName("GL_RGB10_A2_EXT")]
    Rgb10A2EXT = 32857,

    [NativeName("GL_STENCIL_INDEX1_OES")]
    StencilIndex1OES = 36166,

    [NativeName("GL_STENCIL_INDEX4_OES")]
    StencilIndex4OES = 36167,

    [NativeName("GL_STENCIL_INDEX8_OES")]
    StencilIndex8OES = 36168,

    [NativeName("GL_INCR_WRAP_OES")]
    IncrWrapOES = 34055,

    [NativeName("GL_DECR_WRAP_OES")]
    DecrWrapOES = 34056,

    [NativeName("GL_FRAMEBUFFER_UNDEFINED_OES")]
    FramebufferUndefinedOES = 33305,

    [NativeName("GL_NORMAL_MAP_OES")]
    NormalMapOES = 34065,

    [NativeName("GL_REFLECTION_MAP_OES")]
    ReflectionMapOES = 34066,

    [NativeName("GL_TEXTURE_CUBE_MAP_OES")]
    TextureCubeMapOES = 34067,

    [NativeName("GL_TEXTURE_BINDING_CUBE_MAP_OES")]
    TextureBindingCubeMapOES = 34068,

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_X_OES")]
    TextureCubeMapPositiveXOES = 34069,

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_X_OES")]
    TextureCubeMapNegativeXOES = 34070,

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Y_OES")]
    TextureCubeMapPositiveYOES = 34071,

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_OES")]
    TextureCubeMapNegativeYOES = 34072,

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Z_OES")]
    TextureCubeMapPositiveZOES = 34073,

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_OES")]
    TextureCubeMapNegativeZOES = 34074,

    [NativeName("GL_MAX_CUBE_MAP_TEXTURE_SIZE_OES")]
    MaxCubeMapTextureSizeOES = 34076,

    [NativeName("GL_TEXTURE_GEN_MODE_OES")]
    TextureGenModeOES = 9472,

    [NativeName("GL_TEXTURE_GEN_STR_OES")]
    TextureGenStrOES = 36192,

    [NativeName("GL_MIRRORED_REPEAT_OES")]
    MirroredRepeatOES = 33648,

    [NativeName("GL_VERTEX_ARRAY_BINDING_OES")]
    VertexArrayBindingOES = 34229,

    [NativeName("GL_3DC_X_AMD")]
    X3DcXAMD = 34809,

    [NativeName("GL_3DC_XY_AMD")]
    X3DcXyAMD = 34810,

    [NativeName("GL_ATC_RGB_AMD")]
    AtcRgbAMD = 35986,

    [NativeName("GL_ATC_RGBA_EXPLICIT_ALPHA_AMD")]
    AtcRgbaExplicitAlphaAMD = 35987,

    [NativeName("GL_ATC_RGBA_INTERPOLATED_ALPHA_AMD")]
    AtcRgbaInterpolatedAlphaAMD = 34798,

    [NativeName("GL_RENDERBUFFER_SAMPLES_APPLE")]
    RenderbufferSamplesAPPLE = 36011,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_APPLE")]
    FramebufferIncompleteMultisampleAPPLE = 36182,

    [NativeName("GL_MAX_SAMPLES_APPLE")]
    MaxSamplesAPPLE = 36183,

    [NativeName("GL_READ_FRAMEBUFFER_APPLE")]
    ReadFramebufferAPPLE = 36008,

    [NativeName("GL_DRAW_FRAMEBUFFER_APPLE")]
    DrawFramebufferAPPLE = 36009,

    [NativeName("GL_DRAW_FRAMEBUFFER_BINDING_APPLE")]
    DrawFramebufferBindingAPPLE = 36006,

    [NativeName("GL_READ_FRAMEBUFFER_BINDING_APPLE")]
    ReadFramebufferBindingAPPLE = 36010,

    [NativeName("GL_SYNC_OBJECT_APPLE")]
    SyncObjectAPPLE = 35411,

    [NativeName("GL_MAX_SERVER_WAIT_TIMEOUT_APPLE")]
    MaxServerWaitTimeoutAPPLE = 37137,

    [NativeName("GL_OBJECT_TYPE_APPLE")]
    ObjectTypeAPPLE = 37138,

    [NativeName("GL_SYNC_CONDITION_APPLE")]
    SyncConditionAPPLE = 37139,

    [NativeName("GL_SYNC_STATUS_APPLE")]
    SyncStatusAPPLE = 37140,

    [NativeName("GL_SYNC_FLAGS_APPLE")]
    SyncFlagsAPPLE = 37141,

    [NativeName("GL_SYNC_FENCE_APPLE")]
    SyncFenceAPPLE = 37142,

    [NativeName("GL_SYNC_GPU_COMMANDS_COMPLETE_APPLE")]
    SyncGpuCommandsCompleteAPPLE = 37143,

    [NativeName("GL_UNSIGNALED_APPLE")]
    UnsignaledAPPLE = 37144,

    [NativeName("GL_SIGNALED_APPLE")]
    SignaledAPPLE = 37145,

    [NativeName("GL_ALREADY_SIGNALED_APPLE")]
    AlreadySignaledAPPLE = 37146,

    [NativeName("GL_TIMEOUT_EXPIRED_APPLE")]
    TimeoutExpiredAPPLE = 37147,

    [NativeName("GL_CONDITION_SATISFIED_APPLE")]
    ConditionSatisfiedAPPLE = 37148,

    [NativeName("GL_WAIT_FAILED_APPLE")]
    WaitFailedAPPLE = 37149,

    [NativeName("GL_SYNC_FLUSH_COMMANDS_BIT_APPLE")]
    SyncFlushCommandsBitAPPLE = 1,

    [NativeName("GL_TIMEOUT_IGNORED_APPLE")]
    TimeoutIgnoredAPPLE = 4294967295,

    [NativeName("GL_BGRA_EXT")]
    BgraEXT = 32993,

    [NativeName("GL_BGRA8_EXT")]
    Bgra8EXT = 37793,

    [NativeName("GL_TEXTURE_MAX_LEVEL_APPLE")]
    TextureMaxLevelAPPLE = 33085,

    [NativeName("GL_MIN_EXT")]
    MinEXT = 32775,

    [NativeName("GL_MAX_EXT")]
    MaxEXT = 32776,

    [NativeName("GL_COLOR_EXT")]
    ColorEXT = 6144,

    [NativeName("GL_DEPTH_EXT")]
    DepthEXT = 6145,

    [NativeName("GL_STENCIL_EXT")]
    StencilEXT = 6146,

    [NativeName("GL_MAP_READ_BIT_EXT")]
    MapReadBitEXT = 1,

    [NativeName("GL_MAP_WRITE_BIT_EXT")]
    MapWriteBitEXT = 2,

    [NativeName("GL_MAP_INVALIDATE_RANGE_BIT_EXT")]
    MapInvalidateRangeBitEXT = 4,

    [NativeName("GL_MAP_INVALIDATE_BUFFER_BIT_EXT")]
    MapInvalidateBufferBitEXT = 8,

    [NativeName("GL_MAP_FLUSH_EXPLICIT_BIT_EXT")]
    MapFlushExplicitBitEXT = 16,

    [NativeName("GL_MAP_UNSYNCHRONIZED_BIT_EXT")]
    MapUnsynchronizedBitEXT = 32,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SAMPLES_EXT")]
    FramebufferAttachmentTextureSamplesEXT = 36204,

    [NativeName("GL_RENDERBUFFER_SAMPLES_EXT")]
    RenderbufferSamplesEXT = 36011,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_EXT")]
    FramebufferIncompleteMultisampleEXT = 36182,

    [NativeName("GL_MAX_SAMPLES_EXT")]
    MaxSamplesEXT = 36183,

    [NativeName("GL_UNSIGNED_SHORT_4_4_4_4_REV_EXT")]
    UnsignedShort4X4X4X4RevEXT = 33637,

    [NativeName("GL_UNSIGNED_SHORT_1_5_5_5_REV_EXT")]
    UnsignedShort1X5X5X5RevEXT = 33638,

    [NativeName("GL_GUILTY_CONTEXT_RESET_EXT")]
    GuiltyContextResetEXT = 33363,

    [NativeName("GL_INNOCENT_CONTEXT_RESET_EXT")]
    InnocentContextResetEXT = 33364,

    [NativeName("GL_UNKNOWN_CONTEXT_RESET_EXT")]
    UnknownContextResetEXT = 33365,

    [NativeName("GL_CONTEXT_ROBUST_ACCESS_EXT")]
    ContextRobustAccessEXT = 37107,

    [NativeName("GL_RESET_NOTIFICATION_STRATEGY_EXT")]
    ResetNotificationStrategyEXT = 33366,

    [NativeName("GL_LOSE_CONTEXT_ON_RESET_EXT")]
    LoseContextOnResetEXT = 33362,

    [NativeName("GL_NO_RESET_NOTIFICATION_EXT")]
    NoResetNotificationEXT = 33377,

    [NativeName("GL_SRGB_EXT")]
    SrgbEXT = 35904,

    [NativeName("GL_SRGB_ALPHA_EXT")]
    SrgbAlphaEXT = 35906,

    [NativeName("GL_SRGB8_ALPHA8_EXT")]
    Srgb8Alpha8EXT = 35907,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING_EXT")]
    FramebufferAttachmentColorEncodingEXT = 33296,

    [NativeName("GL_COMPRESSED_RGB_S3TC_DXT1_EXT")]
    CompressedRgbS3TcDxt1EXT = 33776,

    [NativeName("GL_COMPRESSED_RGBA_S3TC_DXT1_EXT")]
    CompressedRgbaS3TcDxt1EXT = 33777,

    [NativeName("GL_TEXTURE_MAX_ANISOTROPY_EXT")]
    TextureMaxAnisotropyEXT = 34046,

    [NativeName("GL_MAX_TEXTURE_MAX_ANISOTROPY_EXT")]
    MaxTextureMaxAnisotropyEXT = 34047,

    [NativeName("GL_MAX_TEXTURE_LOD_BIAS_EXT")]
    MaxTextureLodBiasEXT = 34045,

    [NativeName("GL_TEXTURE_FILTER_CONTROL_EXT")]
    TextureFilterControlEXT = 34048,

    [NativeName("GL_TEXTURE_LOD_BIAS_EXT")]
    TextureLodBiasEXT = 34049,

    [NativeName("GL_TEXTURE_IMMUTABLE_FORMAT_EXT")]
    TextureImmutableFormatEXT = 37167,

    [NativeName("GL_ALPHA8_EXT")]
    Alpha8EXT = 32828,

    [NativeName("GL_LUMINANCE8_EXT")]
    Luminance8EXT = 32832,

    [NativeName("GL_LUMINANCE8_ALPHA8_EXT")]
    Luminance8Alpha8EXT = 32837,

    [NativeName("GL_RGBA32F_EXT")]
    Rgba32FEXT = 34836,

    [NativeName("GL_RGB32F_EXT")]
    Rgb32FEXT = 34837,

    [NativeName("GL_ALPHA32F_EXT")]
    Alpha32FEXT = 34838,

    [NativeName("GL_LUMINANCE32F_EXT")]
    Luminance32FEXT = 34840,

    [NativeName("GL_LUMINANCE_ALPHA32F_EXT")]
    LuminanceAlpha32FEXT = 34841,

    [NativeName("GL_RGBA16F_EXT")]
    Rgba16FEXT = 34842,

    [NativeName("GL_RGB16F_EXT")]
    Rgb16FEXT = 34843,

    [NativeName("GL_ALPHA16F_EXT")]
    Alpha16FEXT = 34844,

    [NativeName("GL_LUMINANCE16F_EXT")]
    Luminance16FEXT = 34846,

    [NativeName("GL_LUMINANCE_ALPHA16F_EXT")]
    LuminanceAlpha16FEXT = 34847,

    [NativeName("GL_R8_EXT")]
    R8EXT = 33321,

    [NativeName("GL_RG8_EXT")]
    Rg8EXT = 33323,

    [NativeName("GL_R32F_EXT")]
    R32FEXT = 33326,

    [NativeName("GL_RG32F_EXT")]
    Rg32FEXT = 33328,

    [NativeName("GL_R16F_EXT")]
    R16FEXT = 33325,

    [NativeName("GL_RG16F_EXT")]
    Rg16FEXT = 33327,

    [NativeName("GL_RENDERBUFFER_SAMPLES_IMG")]
    RenderbufferSamplesIMG = 37171,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_IMG")]
    FramebufferIncompleteMultisampleIMG = 37172,

    [NativeName("GL_MAX_SAMPLES_IMG")]
    MaxSamplesIMG = 37173,

    [NativeName("GL_TEXTURE_SAMPLES_IMG")]
    TextureSamplesIMG = 37174,

    [NativeName("GL_BGRA_IMG")]
    BgraIMG = 32993,

    [NativeName("GL_UNSIGNED_SHORT_4_4_4_4_REV_IMG")]
    UnsignedShort4X4X4X4RevIMG = 33637,

    [NativeName("GL_COMPRESSED_RGB_PVRTC_4BPPV1_IMG")]
    CompressedRgbPvrtc4Bppv1IMG = 35840,

    [NativeName("GL_COMPRESSED_RGB_PVRTC_2BPPV1_IMG")]
    CompressedRgbPvrtc2Bppv1IMG = 35841,

    [NativeName("GL_COMPRESSED_RGBA_PVRTC_4BPPV1_IMG")]
    CompressedRgbaPvrtc4Bppv1IMG = 35842,

    [NativeName("GL_COMPRESSED_RGBA_PVRTC_2BPPV1_IMG")]
    CompressedRgbaPvrtc2Bppv1IMG = 35843,

    [NativeName("GL_MODULATE_COLOR_IMG")]
    ModulateColorIMG = 35844,

    [NativeName("GL_RECIP_ADD_SIGNED_ALPHA_IMG")]
    RecipAddSignedAlphaIMG = 35845,

    [NativeName("GL_TEXTURE_ALPHA_MODULATE_IMG")]
    TextureAlphaModulateIMG = 35846,

    [NativeName("GL_FACTOR_ALPHA_MODULATE_IMG")]
    FactorAlphaModulateIMG = 35847,

    [NativeName("GL_FRAGMENT_ALPHA_MODULATE_IMG")]
    FragmentAlphaModulateIMG = 35848,

    [NativeName("GL_ADD_BLEND_IMG")]
    AddBlendIMG = 35849,

    [NativeName("GL_DOT3_RGBA_IMG")]
    Dot3RgbaIMG = 34479,

    [NativeName("GL_CLIP_PLANE0_IMG")]
    ClipPlane0IMG = 12288,

    [NativeName("GL_CLIP_PLANE1_IMG")]
    ClipPlane1IMG = 12289,

    [NativeName("GL_CLIP_PLANE2_IMG")]
    ClipPlane2IMG = 12290,

    [NativeName("GL_CLIP_PLANE3_IMG")]
    ClipPlane3IMG = 12291,

    [NativeName("GL_CLIP_PLANE4_IMG")]
    ClipPlane4IMG = 12292,

    [NativeName("GL_CLIP_PLANE5_IMG")]
    ClipPlane5IMG = 12293,

    [NativeName("GL_MAX_CLIP_PLANES_IMG")]
    MaxClipPlanesIMG = 3378,

    [NativeName("GL_ALL_COMPLETED_NV")]
    AllCompletedNV = 34034,

    [NativeName("GL_FENCE_STATUS_NV")]
    FenceStatusNV = 34035,

    [NativeName("GL_FENCE_CONDITION_NV")]
    FenceConditionNV = 34036,

    [NativeName("GL_TEXTURE_WIDTH_QCOM")]
    TextureWidthQCOM = 35794,

    [NativeName("GL_TEXTURE_HEIGHT_QCOM")]
    TextureHeightQCOM = 35795,

    [NativeName("GL_TEXTURE_DEPTH_QCOM")]
    TextureDepthQCOM = 35796,

    [NativeName("GL_TEXTURE_INTERNAL_FORMAT_QCOM")]
    TextureInternalFormatQCOM = 35797,

    [NativeName("GL_TEXTURE_FORMAT_QCOM")]
    TextureFormatQCOM = 35798,

    [NativeName("GL_TEXTURE_TYPE_QCOM")]
    TextureTypeQCOM = 35799,

    [NativeName("GL_TEXTURE_IMAGE_VALID_QCOM")]
    TextureImageValidQCOM = 35800,

    [NativeName("GL_TEXTURE_NUM_LEVELS_QCOM")]
    TextureNumLevelsQCOM = 35801,

    [NativeName("GL_TEXTURE_TARGET_QCOM")]
    TextureTargetQCOM = 35802,

    [NativeName("GL_TEXTURE_OBJECT_VALID_QCOM")]
    TextureObjectValidQCOM = 35803,

    [NativeName("GL_STATE_RESTORE")]
    StateRestore = 35804,

    [NativeName("GL_PERFMON_GLOBAL_MODE_QCOM")]
    PerfmonGlobalModeQCOM = 36768,

    [NativeName("GL_COLOR_BUFFER_BIT0_QCOM")]
    ColorBufferBit0QCOM = 1,

    [NativeName("GL_COLOR_BUFFER_BIT1_QCOM")]
    ColorBufferBit1QCOM = 2,

    [NativeName("GL_COLOR_BUFFER_BIT2_QCOM")]
    ColorBufferBit2QCOM = 4,

    [NativeName("GL_COLOR_BUFFER_BIT3_QCOM")]
    ColorBufferBit3QCOM = 8,

    [NativeName("GL_COLOR_BUFFER_BIT4_QCOM")]
    ColorBufferBit4QCOM = 16,

    [NativeName("GL_COLOR_BUFFER_BIT5_QCOM")]
    ColorBufferBit5QCOM = 32,

    [NativeName("GL_COLOR_BUFFER_BIT6_QCOM")]
    ColorBufferBit6QCOM = 64,

    [NativeName("GL_COLOR_BUFFER_BIT7_QCOM")]
    ColorBufferBit7QCOM = 128,

    [NativeName("GL_DEPTH_BUFFER_BIT0_QCOM")]
    DepthBufferBit0QCOM = 256,

    [NativeName("GL_DEPTH_BUFFER_BIT1_QCOM")]
    DepthBufferBit1QCOM = 512,

    [NativeName("GL_DEPTH_BUFFER_BIT2_QCOM")]
    DepthBufferBit2QCOM = 1024,

    [NativeName("GL_DEPTH_BUFFER_BIT3_QCOM")]
    DepthBufferBit3QCOM = 2048,

    [NativeName("GL_DEPTH_BUFFER_BIT4_QCOM")]
    DepthBufferBit4QCOM = 4096,

    [NativeName("GL_DEPTH_BUFFER_BIT5_QCOM")]
    DepthBufferBit5QCOM = 8192,

    [NativeName("GL_DEPTH_BUFFER_BIT6_QCOM")]
    DepthBufferBit6QCOM = 16384,

    [NativeName("GL_DEPTH_BUFFER_BIT7_QCOM")]
    DepthBufferBit7QCOM = 32768,

    [NativeName("GL_STENCIL_BUFFER_BIT0_QCOM")]
    StencilBufferBit0QCOM = 65536,

    [NativeName("GL_STENCIL_BUFFER_BIT1_QCOM")]
    StencilBufferBit1QCOM = 131072,

    [NativeName("GL_STENCIL_BUFFER_BIT2_QCOM")]
    StencilBufferBit2QCOM = 262144,

    [NativeName("GL_STENCIL_BUFFER_BIT3_QCOM")]
    StencilBufferBit3QCOM = 524288,

    [NativeName("GL_STENCIL_BUFFER_BIT4_QCOM")]
    StencilBufferBit4QCOM = 1048576,

    [NativeName("GL_STENCIL_BUFFER_BIT5_QCOM")]
    StencilBufferBit5QCOM = 2097152,

    [NativeName("GL_STENCIL_BUFFER_BIT6_QCOM")]
    StencilBufferBit6QCOM = 4194304,

    [NativeName("GL_STENCIL_BUFFER_BIT7_QCOM")]
    StencilBufferBit7QCOM = 8388608,

    [NativeName("GL_MULTISAMPLE_BUFFER_BIT0_QCOM")]
    MultisampleBufferBit0QCOM = 16777216,

    [NativeName("GL_MULTISAMPLE_BUFFER_BIT1_QCOM")]
    MultisampleBufferBit1QCOM = 33554432,

    [NativeName("GL_MULTISAMPLE_BUFFER_BIT2_QCOM")]
    MultisampleBufferBit2QCOM = 67108864,

    [NativeName("GL_MULTISAMPLE_BUFFER_BIT3_QCOM")]
    MultisampleBufferBit3QCOM = 134217728,

    [NativeName("GL_MULTISAMPLE_BUFFER_BIT4_QCOM")]
    MultisampleBufferBit4QCOM = 268435456,

    [NativeName("GL_MULTISAMPLE_BUFFER_BIT5_QCOM")]
    MultisampleBufferBit5QCOM = 536870912,

    [NativeName("GL_MULTISAMPLE_BUFFER_BIT6_QCOM")]
    MultisampleBufferBit6QCOM = 1073741824,

    [NativeName("GL_MULTISAMPLE_BUFFER_BIT7_QCOM")]
    MultisampleBufferBit7QCOM = 2147483648,

    [NativeName("GL_WRITEONLY_RENDERING_QCOM")]
    WriteonlyRenderingQCOM = 34851,

    [NativeName("GL_QUADS")]
    Quads = 7,

    [NativeName("GL_NONE")]
    None = 0,

    [NativeName("GL_FRONT_LEFT")]
    FrontLeft = 1024,

    [NativeName("GL_FRONT_RIGHT")]
    FrontRight = 1025,

    [NativeName("GL_BACK_LEFT")]
    BackLeft = 1026,

    [NativeName("GL_BACK_RIGHT")]
    BackRight = 1027,

    [NativeName("GL_LEFT")]
    Left = 1030,

    [NativeName("GL_RIGHT")]
    Right = 1031,

    [NativeName("GL_POINT_SIZE_RANGE")]
    PointSizeRange = 2834,

    [NativeName("GL_POINT_SIZE_GRANULARITY")]
    PointSizeGranularity = 2835,

    [NativeName("GL_LINE_WIDTH_RANGE")]
    LineWidthRange = 2850,

    [NativeName("GL_LINE_WIDTH_GRANULARITY")]
    LineWidthGranularity = 2851,

    [NativeName("GL_POLYGON_MODE")]
    PolygonMode = 2880,

    [NativeName("GL_POLYGON_SMOOTH")]
    PolygonSmooth = 2881,

    [NativeName("GL_DRAW_BUFFER")]
    DrawBuffer = 3073,

    [NativeName("GL_READ_BUFFER")]
    ReadBuffer = 3074,

    [NativeName("GL_DOUBLEBUFFER")]
    Doublebuffer = 3122,

    [NativeName("GL_STEREO")]
    Stereo = 3123,

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

    [NativeName("GL_TEXTURE_1D")]
    Texture1D = 3552,

    [NativeName("GL_TEXTURE_WIDTH")]
    TextureWidth = 4096,

    [NativeName("GL_TEXTURE_HEIGHT")]
    TextureHeight = 4097,

    [NativeName("GL_TEXTURE_BORDER_COLOR")]
    TextureBorderColor = 4100,

    [NativeName("GL_INT")]
    Int = 5124,

    [NativeName("GL_COLOR")]
    Color = 6144,

    [NativeName("GL_DEPTH")]
    Depth = 6145,

    [NativeName("GL_STENCIL")]
    Stencil = 6146,

    [NativeName("GL_STENCIL_INDEX")]
    StencilIndex = 6401,

    [NativeName("GL_DEPTH_COMPONENT")]
    DepthComponent = 6402,

    [NativeName("GL_RED")]
    Red = 6403,

    [NativeName("GL_GREEN")]
    Green = 6404,

    [NativeName("GL_BLUE")]
    Blue = 6405,

    [NativeName("GL_POINT")]
    Point = 6912,

    [NativeName("GL_LINE")]
    Line = 6913,

    [NativeName("GL_FILL")]
    Fill = 6914,

    [NativeName("GL_CURRENT_BIT")]
    CurrentBit = 1,

    [NativeName("GL_POINT_BIT")]
    PointBit = 2,

    [NativeName("GL_LINE_BIT")]
    LineBit = 4,

    [NativeName("GL_POLYGON_BIT")]
    PolygonBit = 8,

    [NativeName("GL_POLYGON_STIPPLE_BIT")]
    PolygonStippleBit = 16,

    [NativeName("GL_PIXEL_MODE_BIT")]
    PixelModeBit = 32,

    [NativeName("GL_LIGHTING_BIT")]
    LightingBit = 64,

    [NativeName("GL_FOG_BIT")]
    FogBit = 128,

    [NativeName("GL_ACCUM_BUFFER_BIT")]
    AccumBufferBit = 512,

    [NativeName("GL_VIEWPORT_BIT")]
    ViewportBit = 2048,

    [NativeName("GL_TRANSFORM_BIT")]
    TransformBit = 4096,

    [NativeName("GL_ENABLE_BIT")]
    EnableBit = 8192,

    [NativeName("GL_HINT_BIT")]
    HintBit = 32768,

    [NativeName("GL_EVAL_BIT")]
    EvalBit = 65536,

    [NativeName("GL_LIST_BIT")]
    ListBit = 131072,

    [NativeName("GL_TEXTURE_BIT")]
    TextureBit = 262144,

    [NativeName("GL_SCISSOR_BIT")]
    ScissorBit = 524288,

    [NativeName("GL_ALL_ATTRIB_BITS")]
    AllAttribBits = 4294967295,

    [NativeName("GL_QUAD_STRIP")]
    QuadStrip = 8,

    [NativeName("GL_POLYGON")]
    Polygon = 9,

    [NativeName("GL_ACCUM")]
    Accum = 256,

    [NativeName("GL_LOAD")]
    Load = 257,

    [NativeName("GL_RETURN")]
    Return = 258,

    [NativeName("GL_MULT")]
    Mult = 259,

    [NativeName("GL_AUX0")]
    Aux0 = 1033,

    [NativeName("GL_AUX1")]
    Aux1 = 1034,

    [NativeName("GL_AUX2")]
    Aux2 = 1035,

    [NativeName("GL_AUX3")]
    Aux3 = 1036,

    [NativeName("GL_2D")]
    X2D = 1536,

    [NativeName("GL_3D")]
    X3D = 1537,

    [NativeName("GL_3D_COLOR")]
    X3DColor = 1538,

    [NativeName("GL_3D_COLOR_TEXTURE")]
    X3DColorTexture = 1539,

    [NativeName("GL_4D_COLOR_TEXTURE")]
    X4DColorTexture = 1540,

    [NativeName("GL_PASS_THROUGH_TOKEN")]
    PassThroughToken = 1792,

    [NativeName("GL_POINT_TOKEN")]
    PointToken = 1793,

    [NativeName("GL_LINE_TOKEN")]
    LineToken = 1794,

    [NativeName("GL_POLYGON_TOKEN")]
    PolygonToken = 1795,

    [NativeName("GL_BITMAP_TOKEN")]
    BitmapToken = 1796,

    [NativeName("GL_DRAW_PIXEL_TOKEN")]
    DrawPixelToken = 1797,

    [NativeName("GL_COPY_PIXEL_TOKEN")]
    CopyPixelToken = 1798,

    [NativeName("GL_LINE_RESET_TOKEN")]
    LineResetToken = 1799,

    [NativeName("GL_COEFF")]
    Coeff = 2560,

    [NativeName("GL_ORDER")]
    Order = 2561,

    [NativeName("GL_DOMAIN")]
    Domain = 2562,

    [NativeName("GL_PIXEL_MAP_I_TO_I")]
    PixelMapIToI = 3184,

    [NativeName("GL_PIXEL_MAP_S_TO_S")]
    PixelMapSToS = 3185,

    [NativeName("GL_PIXEL_MAP_I_TO_R")]
    PixelMapIToR = 3186,

    [NativeName("GL_PIXEL_MAP_I_TO_G")]
    PixelMapIToG = 3187,

    [NativeName("GL_PIXEL_MAP_I_TO_B")]
    PixelMapIToB = 3188,

    [NativeName("GL_PIXEL_MAP_I_TO_A")]
    PixelMapIToA = 3189,

    [NativeName("GL_PIXEL_MAP_R_TO_R")]
    PixelMapRToR = 3190,

    [NativeName("GL_PIXEL_MAP_G_TO_G")]
    PixelMapGToG = 3191,

    [NativeName("GL_PIXEL_MAP_B_TO_B")]
    PixelMapBToB = 3192,

    [NativeName("GL_PIXEL_MAP_A_TO_A")]
    PixelMapAToA = 3193,

    [NativeName("GL_CURRENT_INDEX")]
    CurrentIndex = 2817,

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

    [NativeName("GL_LIGHT_MODEL_LOCAL_VIEWER")]
    LightModelLocalViewer = 2897,

    [NativeName("GL_COLOR_MATERIAL_FACE")]
    ColorMaterialFace = 2901,

    [NativeName("GL_COLOR_MATERIAL_PARAMETER")]
    ColorMaterialParameter = 2902,

    [NativeName("GL_FOG_INDEX")]
    FogIndex = 2913,

    [NativeName("GL_ACCUM_CLEAR_VALUE")]
    AccumClearValue = 2944,

    [NativeName("GL_ATTRIB_STACK_DEPTH")]
    AttribStackDepth = 2992,

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

    [NativeName("GL_ALPHA_BIAS")]
    AlphaBias = 3357,

    [NativeName("GL_DEPTH_SCALE")]
    DepthScale = 3358,

    [NativeName("GL_DEPTH_BIAS")]
    DepthBias = 3359,

    [NativeName("GL_MAX_EVAL_ORDER")]
    MaxEvalOrder = 3376,

    [NativeName("GL_MAX_PIXEL_MAP_TABLE")]
    MaxPixelMapTable = 3380,

    [NativeName("GL_MAX_ATTRIB_STACK_DEPTH")]
    MaxAttribStackDepth = 3381,

    [NativeName("GL_MAX_NAME_STACK_DEPTH")]
    MaxNameStackDepth = 3383,

    [NativeName("GL_INDEX_BITS")]
    IndexBits = 3409,

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

    [NativeName("GL_TEXTURE_COMPONENTS")]
    TextureComponents = 4099,

    [NativeName("GL_TEXTURE_BORDER")]
    TextureBorder = 4101,

    [NativeName("GL_COMPILE")]
    Compile = 4864,

    [NativeName("GL_COMPILE_AND_EXECUTE")]
    CompileAndExecute = 4865,

    [NativeName("GL_2_BYTES")]
    X2Bytes = 5127,

    [NativeName("GL_3_BYTES")]
    X3Bytes = 5128,

    [NativeName("GL_4_BYTES")]
    X4Bytes = 5129,

    [NativeName("GL_COLOR_INDEXES")]
    ColorIndexes = 5635,

    [NativeName("GL_COLOR_INDEX")]
    ColorIndex = 6400,

    [NativeName("GL_BITMAP")]
    Bitmap = 6656,

    [NativeName("GL_RENDER")]
    Render = 7168,

    [NativeName("GL_FEEDBACK")]
    Feedback = 7169,

    [NativeName("GL_SELECT")]
    Select = 7170,

    [NativeName("GL_S")]
    S = 8192,

    [NativeName("GL_T")]
    T = 8193,

    [NativeName("GL_R")]
    R = 8194,

    [NativeName("GL_Q")]
    Q = 8195,

    [NativeName("GL_EYE_LINEAR")]
    EyeLinear = 9216,

    [NativeName("GL_OBJECT_LINEAR")]
    ObjectLinear = 9217,

    [NativeName("GL_SPHERE_MAP")]
    SphereMap = 9218,

    [NativeName("GL_TEXTURE_GEN_MODE")]
    TextureGenMode = 9472,

    [NativeName("GL_OBJECT_PLANE")]
    ObjectPlane = 9473,

    [NativeName("GL_EYE_PLANE")]
    EyePlane = 9474,

    [NativeName("GL_CLAMP")]
    Clamp = 10496,

    [NativeName("GL_POLYGON_OFFSET_POINT")]
    PolygonOffsetPoint = 10753,

    [NativeName("GL_POLYGON_OFFSET_LINE")]
    PolygonOffsetLine = 10754,

    [NativeName("GL_TEXTURE_BINDING_1D")]
    TextureBinding1D = 32872,

    [NativeName("GL_TEXTURE_INTERNAL_FORMAT")]
    TextureInternalFormat = 4099,

    [NativeName("GL_TEXTURE_RED_SIZE")]
    TextureRedSize = 32860,

    [NativeName("GL_TEXTURE_GREEN_SIZE")]
    TextureGreenSize = 32861,

    [NativeName("GL_TEXTURE_BLUE_SIZE")]
    TextureBlueSize = 32862,

    [NativeName("GL_TEXTURE_ALPHA_SIZE")]
    TextureAlphaSize = 32863,

    [NativeName("GL_DOUBLE")]
    Double = 5130,

    [NativeName("GL_PROXY_TEXTURE_1D")]
    ProxyTexture1D = 32867,

    [NativeName("GL_PROXY_TEXTURE_2D")]
    ProxyTexture2D = 32868,

    [NativeName("GL_R3_G3_B2")]
    R3G3B2 = 10768,

    [NativeName("GL_RGB4")]
    Rgb4 = 32847,

    [NativeName("GL_RGB5")]
    Rgb5 = 32848,

    [NativeName("GL_RGB8")]
    Rgb8 = 32849,

    [NativeName("GL_RGB10")]
    Rgb10 = 32850,

    [NativeName("GL_RGB12")]
    Rgb12 = 32851,

    [NativeName("GL_RGB16")]
    Rgb16 = 32852,

    [NativeName("GL_RGBA2")]
    Rgba2 = 32853,

    [NativeName("GL_RGBA4")]
    Rgba4 = 32854,

    [NativeName("GL_RGB5_A1")]
    Rgb5A1 = 32855,

    [NativeName("GL_RGBA8")]
    Rgba8 = 32856,

    [NativeName("GL_RGB10_A2")]
    Rgb10A2 = 32857,

    [NativeName("GL_RGBA12")]
    Rgba12 = 32858,

    [NativeName("GL_RGBA16")]
    Rgba16 = 32859,

    [NativeName("GL_CLIENT_PIXEL_STORE_BIT")]
    ClientPixelStoreBit = 1,

    [NativeName("GL_CLIENT_VERTEX_ARRAY_BIT")]
    ClientVertexArrayBit = 2,

    [NativeName("GL_CLIENT_ALL_ATTRIB_BITS")]
    ClientAllAttribBits = 4294967295,

    [NativeName("GL_INDEX_ARRAY_POINTER")]
    IndexArrayPointer = 32913,

    [NativeName("GL_EDGE_FLAG_ARRAY_POINTER")]
    EdgeFlagArrayPointer = 32915,

    [NativeName("GL_FEEDBACK_BUFFER_POINTER")]
    FeedbackBufferPointer = 3568,

    [NativeName("GL_SELECTION_BUFFER_POINTER")]
    SelectionBufferPointer = 3571,

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

    [NativeName("GL_INDEX_ARRAY")]
    IndexArray = 32887,

    [NativeName("GL_EDGE_FLAG_ARRAY")]
    EdgeFlagArray = 32889,

    [NativeName("GL_INDEX_ARRAY_TYPE")]
    IndexArrayType = 32901,

    [NativeName("GL_INDEX_ARRAY_STRIDE")]
    IndexArrayStride = 32902,

    [NativeName("GL_EDGE_FLAG_ARRAY_STRIDE")]
    EdgeFlagArrayStride = 32908,

    [NativeName("GL_TEXTURE_LUMINANCE_SIZE")]
    TextureLuminanceSize = 32864,

    [NativeName("GL_TEXTURE_INTENSITY_SIZE")]
    TextureIntensitySize = 32865,

    [NativeName("GL_TEXTURE_PRIORITY")]
    TexturePriority = 32870,

    [NativeName("GL_TEXTURE_RESIDENT")]
    TextureResident = 32871,

    [NativeName("GL_ALPHA4")]
    Alpha4 = 32827,

    [NativeName("GL_ALPHA8")]
    Alpha8 = 32828,

    [NativeName("GL_ALPHA12")]
    Alpha12 = 32829,

    [NativeName("GL_ALPHA16")]
    Alpha16 = 32830,

    [NativeName("GL_LUMINANCE4")]
    Luminance4 = 32831,

    [NativeName("GL_LUMINANCE8")]
    Luminance8 = 32832,

    [NativeName("GL_LUMINANCE12")]
    Luminance12 = 32833,

    [NativeName("GL_LUMINANCE16")]
    Luminance16 = 32834,

    [NativeName("GL_LUMINANCE4_ALPHA4")]
    Luminance4Alpha4 = 32835,

    [NativeName("GL_LUMINANCE6_ALPHA2")]
    Luminance6Alpha2 = 32836,

    [NativeName("GL_LUMINANCE8_ALPHA8")]
    Luminance8Alpha8 = 32837,

    [NativeName("GL_LUMINANCE12_ALPHA4")]
    Luminance12Alpha4 = 32838,

    [NativeName("GL_LUMINANCE12_ALPHA12")]
    Luminance12Alpha12 = 32839,

    [NativeName("GL_LUMINANCE16_ALPHA16")]
    Luminance16Alpha16 = 32840,

    [NativeName("GL_INTENSITY")]
    Intensity = 32841,

    [NativeName("GL_INTENSITY4")]
    Intensity4 = 32842,

    [NativeName("GL_INTENSITY8")]
    Intensity8 = 32843,

    [NativeName("GL_INTENSITY12")]
    Intensity12 = 32844,

    [NativeName("GL_INTENSITY16")]
    Intensity16 = 32845,

    [NativeName("GL_V2F")]
    V2F = 10784,

    [NativeName("GL_V3F")]
    V3F = 10785,

    [NativeName("GL_C4UB_V2F")]
    C4UbV2F = 10786,

    [NativeName("GL_C4UB_V3F")]
    C4UbV3F = 10787,

    [NativeName("GL_C3F_V3F")]
    C3FV3F = 10788,

    [NativeName("GL_N3F_V3F")]
    N3FV3F = 10789,

    [NativeName("GL_C4F_N3F_V3F")]
    C4FN3FV3F = 10790,

    [NativeName("GL_T2F_V3F")]
    T2FV3F = 10791,

    [NativeName("GL_T4F_V4F")]
    T4FV4F = 10792,

    [NativeName("GL_T2F_C4UB_V3F")]
    T2FC4UbV3F = 10793,

    [NativeName("GL_T2F_C3F_V3F")]
    T2FC3FV3F = 10794,

    [NativeName("GL_T2F_N3F_V3F")]
    T2FN3FV3F = 10795,

    [NativeName("GL_T2F_C4F_N3F_V3F")]
    T2FC4FN3FV3F = 10796,

    [NativeName("GL_T4F_C4F_N3F_V4F")]
    T4FC4FN3FV4F = 10797,

    [NativeName("GL_UNSIGNED_BYTE_3_3_2")]
    UnsignedByte3X3X2 = 32818,

    [NativeName("GL_UNSIGNED_INT_8_8_8_8")]
    UnsignedInt8X8X8X8 = 32821,

    [NativeName("GL_UNSIGNED_INT_10_10_10_2")]
    UnsignedInt10X10X10X2 = 32822,

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

    [NativeName("GL_TEXTURE_3D")]
    Texture3D = 32879,

    [NativeName("GL_PROXY_TEXTURE_3D")]
    ProxyTexture3D = 32880,

    [NativeName("GL_TEXTURE_DEPTH")]
    TextureDepth = 32881,

    [NativeName("GL_TEXTURE_WRAP_R")]
    TextureWrapR = 32882,

    [NativeName("GL_MAX_3D_TEXTURE_SIZE")]
    Max3DTextureSize = 32883,

    [NativeName("GL_UNSIGNED_BYTE_2_3_3_REV")]
    UnsignedByte2X3X3Rev = 33634,

    [NativeName("GL_UNSIGNED_SHORT_5_6_5_REV")]
    UnsignedShort5X6X5Rev = 33636,

    [NativeName("GL_UNSIGNED_SHORT_4_4_4_4_REV")]
    UnsignedShort4X4X4X4Rev = 33637,

    [NativeName("GL_UNSIGNED_SHORT_1_5_5_5_REV")]
    UnsignedShort1X5X5X5Rev = 33638,

    [NativeName("GL_UNSIGNED_INT_8_8_8_8_REV")]
    UnsignedInt8X8X8X8Rev = 33639,

    [NativeName("GL_UNSIGNED_INT_2_10_10_10_REV")]
    UnsignedInt2X10X10X10Rev = 33640,

    [NativeName("GL_BGR")]
    Bgr = 32992,

    [NativeName("GL_BGRA")]
    Bgra = 32993,

    [NativeName("GL_MAX_ELEMENTS_VERTICES")]
    MaxElementsVertices = 33000,

    [NativeName("GL_MAX_ELEMENTS_INDICES")]
    MaxElementsIndices = 33001,

    [NativeName("GL_TEXTURE_MIN_LOD")]
    TextureMinLod = 33082,

    [NativeName("GL_TEXTURE_MAX_LOD")]
    TextureMaxLod = 33083,

    [NativeName("GL_TEXTURE_BASE_LEVEL")]
    TextureBaseLevel = 33084,

    [NativeName("GL_TEXTURE_MAX_LEVEL")]
    TextureMaxLevel = 33085,

    [NativeName("GL_SMOOTH_POINT_SIZE_GRANULARITY")]
    SmoothPointSizeGranularity = 2835,

    [NativeName("GL_SMOOTH_LINE_WIDTH_GRANULARITY")]
    SmoothLineWidthGranularity = 2851,

    [NativeName("GL_LIGHT_MODEL_COLOR_CONTROL")]
    LightModelColorControl = 33272,

    [NativeName("GL_SINGLE_COLOR")]
    SingleColor = 33273,

    [NativeName("GL_SEPARATE_SPECULAR_COLOR")]
    SeparateSpecularColor = 33274,

    [NativeName("GL_TEXTURE_CUBE_MAP")]
    TextureCubeMap = 34067,

    [NativeName("GL_TEXTURE_BINDING_CUBE_MAP")]
    TextureBindingCubeMap = 34068,

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_X")]
    TextureCubeMapPositiveX = 34069,

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_X")]
    TextureCubeMapNegativeX = 34070,

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Y")]
    TextureCubeMapPositiveY = 34071,

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Y")]
    TextureCubeMapNegativeY = 34072,

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Z")]
    TextureCubeMapPositiveZ = 34073,

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Z")]
    TextureCubeMapNegativeZ = 34074,

    [NativeName("GL_PROXY_TEXTURE_CUBE_MAP")]
    ProxyTextureCubeMap = 34075,

    [NativeName("GL_MAX_CUBE_MAP_TEXTURE_SIZE")]
    MaxCubeMapTextureSize = 34076,

    [NativeName("GL_COMPRESSED_RGB")]
    CompressedRgb = 34029,

    [NativeName("GL_COMPRESSED_RGBA")]
    CompressedRgba = 34030,

    [NativeName("GL_TEXTURE_COMPRESSION_HINT")]
    TextureCompressionHint = 34031,

    [NativeName("GL_TEXTURE_COMPRESSED_IMAGE_SIZE")]
    TextureCompressedImageSize = 34464,

    [NativeName("GL_TEXTURE_COMPRESSED")]
    TextureCompressed = 34465,

    [NativeName("GL_CLAMP_TO_BORDER")]
    ClampToBorder = 33069,

    [NativeName("GL_TRANSPOSE_MODELVIEW_MATRIX")]
    TransposeModelviewMatrix = 34019,

    [NativeName("GL_TRANSPOSE_PROJECTION_MATRIX")]
    TransposeProjectionMatrix = 34020,

    [NativeName("GL_TRANSPOSE_TEXTURE_MATRIX")]
    TransposeTextureMatrix = 34021,

    [NativeName("GL_TRANSPOSE_COLOR_MATRIX")]
    TransposeColorMatrix = 34022,

    [NativeName("GL_MULTISAMPLE_BIT")]
    MultisampleBit = 536870912,

    [NativeName("GL_NORMAL_MAP")]
    NormalMap = 34065,

    [NativeName("GL_REFLECTION_MAP")]
    ReflectionMap = 34066,

    [NativeName("GL_COMPRESSED_ALPHA")]
    CompressedAlpha = 34025,

    [NativeName("GL_COMPRESSED_LUMINANCE")]
    CompressedLuminance = 34026,

    [NativeName("GL_COMPRESSED_LUMINANCE_ALPHA")]
    CompressedLuminanceAlpha = 34027,

    [NativeName("GL_COMPRESSED_INTENSITY")]
    CompressedIntensity = 34028,

    [NativeName("GL_SOURCE0_RGB")]
    Source0Rgb = 34176,

    [NativeName("GL_SOURCE1_RGB")]
    Source1Rgb = 34177,

    [NativeName("GL_SOURCE2_RGB")]
    Source2Rgb = 34178,

    [NativeName("GL_SOURCE0_ALPHA")]
    Source0Alpha = 34184,

    [NativeName("GL_SOURCE1_ALPHA")]
    Source1Alpha = 34185,

    [NativeName("GL_SOURCE2_ALPHA")]
    Source2Alpha = 34186,

    [NativeName("GL_BLEND_DST_RGB")]
    BlendDstRgb = 32968,

    [NativeName("GL_BLEND_SRC_RGB")]
    BlendSrcRgb = 32969,

    [NativeName("GL_BLEND_DST_ALPHA")]
    BlendDstAlpha = 32970,

    [NativeName("GL_BLEND_SRC_ALPHA")]
    BlendSrcAlpha = 32971,

    [NativeName("GL_DEPTH_COMPONENT16")]
    DepthComponent16 = 33189,

    [NativeName("GL_DEPTH_COMPONENT24")]
    DepthComponent24 = 33190,

    [NativeName("GL_DEPTH_COMPONENT32")]
    DepthComponent32 = 33191,

    [NativeName("GL_MIRRORED_REPEAT")]
    MirroredRepeat = 33648,

    [NativeName("GL_MAX_TEXTURE_LOD_BIAS")]
    MaxTextureLodBias = 34045,

    [NativeName("GL_TEXTURE_LOD_BIAS")]
    TextureLodBias = 34049,

    [NativeName("GL_INCR_WRAP")]
    IncrWrap = 34055,

    [NativeName("GL_DECR_WRAP")]
    DecrWrap = 34056,

    [NativeName("GL_TEXTURE_DEPTH_SIZE")]
    TextureDepthSize = 34890,

    [NativeName("GL_TEXTURE_COMPARE_MODE")]
    TextureCompareMode = 34892,

    [NativeName("GL_TEXTURE_COMPARE_FUNC")]
    TextureCompareFunc = 34893,

    [NativeName("GL_FOG_COORDINATE_SOURCE")]
    FogCoordinateSource = 33872,

    [NativeName("GL_FOG_COORDINATE")]
    FogCoordinate = 33873,

    [NativeName("GL_FRAGMENT_DEPTH")]
    FragmentDepth = 33874,

    [NativeName("GL_CURRENT_FOG_COORDINATE")]
    CurrentFogCoordinate = 33875,

    [NativeName("GL_FOG_COORDINATE_ARRAY_TYPE")]
    FogCoordinateArrayType = 33876,

    [NativeName("GL_FOG_COORDINATE_ARRAY_STRIDE")]
    FogCoordinateArrayStride = 33877,

    [NativeName("GL_FOG_COORDINATE_ARRAY_POINTER")]
    FogCoordinateArrayPointer = 33878,

    [NativeName("GL_FOG_COORDINATE_ARRAY")]
    FogCoordinateArray = 33879,

    [NativeName("GL_COLOR_SUM")]
    ColorSum = 33880,

    [NativeName("GL_CURRENT_SECONDARY_COLOR")]
    CurrentSecondaryColor = 33881,

    [NativeName("GL_SECONDARY_COLOR_ARRAY_SIZE")]
    SecondaryColorArraySize = 33882,

    [NativeName("GL_SECONDARY_COLOR_ARRAY_TYPE")]
    SecondaryColorArrayType = 33883,

    [NativeName("GL_SECONDARY_COLOR_ARRAY_STRIDE")]
    SecondaryColorArrayStride = 33884,

    [NativeName("GL_SECONDARY_COLOR_ARRAY_POINTER")]
    SecondaryColorArrayPointer = 33885,

    [NativeName("GL_SECONDARY_COLOR_ARRAY")]
    SecondaryColorArray = 33886,

    [NativeName("GL_TEXTURE_FILTER_CONTROL")]
    TextureFilterControl = 34048,

    [NativeName("GL_DEPTH_TEXTURE_MODE")]
    DepthTextureMode = 34891,

    [NativeName("GL_COMPARE_R_TO_TEXTURE")]
    CompareRToTexture = 34894,

    [NativeName("GL_BLEND_COLOR")]
    BlendColor = 32773,

    [NativeName("GL_BLEND_EQUATION")]
    BlendEquation = 32777,

    [NativeName("GL_CONSTANT_COLOR")]
    ConstantColor = 32769,

    [NativeName("GL_ONE_MINUS_CONSTANT_COLOR")]
    OneMinusConstantColor = 32770,

    [NativeName("GL_CONSTANT_ALPHA")]
    ConstantAlpha = 32771,

    [NativeName("GL_ONE_MINUS_CONSTANT_ALPHA")]
    OneMinusConstantAlpha = 32772,

    [NativeName("GL_FUNC_ADD")]
    FuncAdd = 32774,

    [NativeName("GL_FUNC_REVERSE_SUBTRACT")]
    FuncReverseSubtract = 32779,

    [NativeName("GL_FUNC_SUBTRACT")]
    FuncSubtract = 32778,

    [NativeName("GL_MIN")]
    Min = 32775,

    [NativeName("GL_MAX")]
    Max = 32776,

    [NativeName("GL_QUERY_COUNTER_BITS")]
    QueryCounterBits = 34916,

    [NativeName("GL_CURRENT_QUERY")]
    CurrentQuery = 34917,

    [NativeName("GL_QUERY_RESULT")]
    QueryResult = 34918,

    [NativeName("GL_QUERY_RESULT_AVAILABLE")]
    QueryResultAvailable = 34919,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING")]
    VertexAttribArrayBufferBinding = 34975,

    [NativeName("GL_READ_ONLY")]
    ReadOnly = 35000,

    [NativeName("GL_WRITE_ONLY")]
    WriteOnly = 35001,

    [NativeName("GL_READ_WRITE")]
    ReadWrite = 35002,

    [NativeName("GL_BUFFER_ACCESS")]
    BufferAccess = 35003,

    [NativeName("GL_BUFFER_MAPPED")]
    BufferMapped = 35004,

    [NativeName("GL_BUFFER_MAP_POINTER")]
    BufferMapPointer = 35005,

    [NativeName("GL_STREAM_DRAW")]
    StreamDraw = 35040,

    [NativeName("GL_STREAM_READ")]
    StreamRead = 35041,

    [NativeName("GL_STREAM_COPY")]
    StreamCopy = 35042,

    [NativeName("GL_STATIC_READ")]
    StaticRead = 35045,

    [NativeName("GL_STATIC_COPY")]
    StaticCopy = 35046,

    [NativeName("GL_DYNAMIC_READ")]
    DynamicRead = 35049,

    [NativeName("GL_DYNAMIC_COPY")]
    DynamicCopy = 35050,

    [NativeName("GL_SAMPLES_PASSED")]
    SamplesPassed = 35092,

    [NativeName("GL_INDEX_ARRAY_BUFFER_BINDING")]
    IndexArrayBufferBinding = 34969,

    [NativeName("GL_EDGE_FLAG_ARRAY_BUFFER_BINDING")]
    EdgeFlagArrayBufferBinding = 34971,

    [NativeName("GL_SECONDARY_COLOR_ARRAY_BUFFER_BINDING")]
    SecondaryColorArrayBufferBinding = 34972,

    [NativeName("GL_FOG_COORDINATE_ARRAY_BUFFER_BINDING")]
    FogCoordinateArrayBufferBinding = 34973,

    [NativeName("GL_WEIGHT_ARRAY_BUFFER_BINDING")]
    WeightArrayBufferBinding = 34974,

    [NativeName("GL_FOG_COORD_SRC")]
    FogCoordSrc = 33872,

    [NativeName("GL_FOG_COORD")]
    FogCoord = 33873,

    [NativeName("GL_CURRENT_FOG_COORD")]
    CurrentFogCoord = 33875,

    [NativeName("GL_FOG_COORD_ARRAY_TYPE")]
    FogCoordArrayType = 33876,

    [NativeName("GL_FOG_COORD_ARRAY_STRIDE")]
    FogCoordArrayStride = 33877,

    [NativeName("GL_FOG_COORD_ARRAY_POINTER")]
    FogCoordArrayPointer = 33878,

    [NativeName("GL_FOG_COORD_ARRAY")]
    FogCoordArray = 33879,

    [NativeName("GL_FOG_COORD_ARRAY_BUFFER_BINDING")]
    FogCoordArrayBufferBinding = 34973,

    [NativeName("GL_BLEND_EQUATION_RGB")]
    BlendEquationRgb = 32777,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_ENABLED")]
    VertexAttribArrayEnabled = 34338,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_SIZE")]
    VertexAttribArraySize = 34339,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_STRIDE")]
    VertexAttribArrayStride = 34340,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_TYPE")]
    VertexAttribArrayType = 34341,

    [NativeName("GL_CURRENT_VERTEX_ATTRIB")]
    CurrentVertexAttrib = 34342,

    [NativeName("GL_VERTEX_PROGRAM_POINT_SIZE")]
    VertexProgramPointSize = 34370,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_POINTER")]
    VertexAttribArrayPointer = 34373,

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

    [NativeName("GL_DRAW_BUFFER0")]
    DrawBuffer0 = 34853,

    [NativeName("GL_DRAW_BUFFER1")]
    DrawBuffer1 = 34854,

    [NativeName("GL_DRAW_BUFFER2")]
    DrawBuffer2 = 34855,

    [NativeName("GL_DRAW_BUFFER3")]
    DrawBuffer3 = 34856,

    [NativeName("GL_DRAW_BUFFER4")]
    DrawBuffer4 = 34857,

    [NativeName("GL_DRAW_BUFFER5")]
    DrawBuffer5 = 34858,

    [NativeName("GL_DRAW_BUFFER6")]
    DrawBuffer6 = 34859,

    [NativeName("GL_DRAW_BUFFER7")]
    DrawBuffer7 = 34860,

    [NativeName("GL_DRAW_BUFFER8")]
    DrawBuffer8 = 34861,

    [NativeName("GL_DRAW_BUFFER9")]
    DrawBuffer9 = 34862,

    [NativeName("GL_DRAW_BUFFER10")]
    DrawBuffer10 = 34863,

    [NativeName("GL_DRAW_BUFFER11")]
    DrawBuffer11 = 34864,

    [NativeName("GL_DRAW_BUFFER12")]
    DrawBuffer12 = 34865,

    [NativeName("GL_DRAW_BUFFER13")]
    DrawBuffer13 = 34866,

    [NativeName("GL_DRAW_BUFFER14")]
    DrawBuffer14 = 34867,

    [NativeName("GL_DRAW_BUFFER15")]
    DrawBuffer15 = 34868,

    [NativeName("GL_BLEND_EQUATION_ALPHA")]
    BlendEquationAlpha = 34877,

    [NativeName("GL_MAX_VERTEX_ATTRIBS")]
    MaxVertexAttribs = 34921,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_NORMALIZED")]
    VertexAttribArrayNormalized = 34922,

    [NativeName("GL_MAX_TEXTURE_IMAGE_UNITS")]
    MaxTextureImageUnits = 34930,

    [NativeName("GL_FRAGMENT_SHADER")]
    FragmentShader = 35632,

    [NativeName("GL_VERTEX_SHADER")]
    VertexShader = 35633,

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

    [NativeName("GL_SHADER_TYPE")]
    ShaderType = 35663,

    [NativeName("GL_FLOAT_VEC2")]
    FloatVec2 = 35664,

    [NativeName("GL_FLOAT_VEC3")]
    FloatVec3 = 35665,

    [NativeName("GL_FLOAT_VEC4")]
    FloatVec4 = 35666,

    [NativeName("GL_INT_VEC2")]
    IntVec2 = 35667,

    [NativeName("GL_INT_VEC3")]
    IntVec3 = 35668,

    [NativeName("GL_INT_VEC4")]
    IntVec4 = 35669,

    [NativeName("GL_BOOL")]
    Bool = 35670,

    [NativeName("GL_BOOL_VEC2")]
    BoolVec2 = 35671,

    [NativeName("GL_BOOL_VEC3")]
    BoolVec3 = 35672,

    [NativeName("GL_BOOL_VEC4")]
    BoolVec4 = 35673,

    [NativeName("GL_FLOAT_MAT2")]
    FloatMat2 = 35674,

    [NativeName("GL_FLOAT_MAT3")]
    FloatMat3 = 35675,

    [NativeName("GL_FLOAT_MAT4")]
    FloatMat4 = 35676,

    [NativeName("GL_SAMPLER_1D")]
    Sampler1D = 35677,

    [NativeName("GL_SAMPLER_2D")]
    Sampler2D = 35678,

    [NativeName("GL_SAMPLER_3D")]
    Sampler3D = 35679,

    [NativeName("GL_SAMPLER_CUBE")]
    SamplerCube = 35680,

    [NativeName("GL_SAMPLER_1D_SHADOW")]
    Sampler1DShadow = 35681,

    [NativeName("GL_SAMPLER_2D_SHADOW")]
    Sampler2DShadow = 35682,

    [NativeName("GL_DELETE_STATUS")]
    DeleteStatus = 35712,

    [NativeName("GL_COMPILE_STATUS")]
    CompileStatus = 35713,

    [NativeName("GL_LINK_STATUS")]
    LinkStatus = 35714,

    [NativeName("GL_VALIDATE_STATUS")]
    ValidateStatus = 35715,

    [NativeName("GL_INFO_LOG_LENGTH")]
    InfoLogLength = 35716,

    [NativeName("GL_ATTACHED_SHADERS")]
    AttachedShaders = 35717,

    [NativeName("GL_ACTIVE_UNIFORMS")]
    ActiveUniforms = 35718,

    [NativeName("GL_ACTIVE_UNIFORM_MAX_LENGTH")]
    ActiveUniformMaxLength = 35719,

    [NativeName("GL_SHADER_SOURCE_LENGTH")]
    ShaderSourceLength = 35720,

    [NativeName("GL_ACTIVE_ATTRIBUTES")]
    ActiveAttributes = 35721,

    [NativeName("GL_ACTIVE_ATTRIBUTE_MAX_LENGTH")]
    ActiveAttributeMaxLength = 35722,

    [NativeName("GL_FRAGMENT_SHADER_DERIVATIVE_HINT")]
    FragmentShaderDerivativeHint = 35723,

    [NativeName("GL_SHADING_LANGUAGE_VERSION")]
    ShadingLanguageVersion = 35724,

    [NativeName("GL_CURRENT_PROGRAM")]
    CurrentProgram = 35725,

    [NativeName("GL_POINT_SPRITE_COORD_ORIGIN")]
    PointSpriteCoordOrigin = 36000,

    [NativeName("GL_LOWER_LEFT")]
    LowerLeft = 36001,

    [NativeName("GL_UPPER_LEFT")]
    UpperLeft = 36002,

    [NativeName("GL_STENCIL_BACK_REF")]
    StencilBackRef = 36003,

    [NativeName("GL_STENCIL_BACK_VALUE_MASK")]
    StencilBackValueMask = 36004,

    [NativeName("GL_STENCIL_BACK_WRITEMASK")]
    StencilBackWritemask = 36005,

    [NativeName("GL_VERTEX_PROGRAM_TWO_SIDE")]
    VertexProgramTwoSide = 34371,

    [NativeName("GL_POINT_SPRITE")]
    PointSprite = 34913,

    [NativeName("GL_COORD_REPLACE")]
    CoordReplace = 34914,

    [NativeName("GL_MAX_TEXTURE_COORDS")]
    MaxTextureCoords = 34929,

    [NativeName("GL_PIXEL_PACK_BUFFER")]
    PixelPackBuffer = 35051,

    [NativeName("GL_PIXEL_UNPACK_BUFFER")]
    PixelUnpackBuffer = 35052,

    [NativeName("GL_PIXEL_PACK_BUFFER_BINDING")]
    PixelPackBufferBinding = 35053,

    [NativeName("GL_PIXEL_UNPACK_BUFFER_BINDING")]
    PixelUnpackBufferBinding = 35055,

    [NativeName("GL_FLOAT_MAT2x3")]
    FloatMat2X3 = 35685,

    [NativeName("GL_FLOAT_MAT2x4")]
    FloatMat2X4 = 35686,

    [NativeName("GL_FLOAT_MAT3x2")]
    FloatMat3X2 = 35687,

    [NativeName("GL_FLOAT_MAT3x4")]
    FloatMat3X4 = 35688,

    [NativeName("GL_FLOAT_MAT4x2")]
    FloatMat4X2 = 35689,

    [NativeName("GL_FLOAT_MAT4x3")]
    FloatMat4X3 = 35690,

    [NativeName("GL_SRGB")]
    Srgb = 35904,

    [NativeName("GL_SRGB8")]
    Srgb8 = 35905,

    [NativeName("GL_SRGB_ALPHA")]
    SrgbAlpha = 35906,

    [NativeName("GL_SRGB8_ALPHA8")]
    Srgb8Alpha8 = 35907,

    [NativeName("GL_COMPRESSED_SRGB")]
    CompressedSrgb = 35912,

    [NativeName("GL_COMPRESSED_SRGB_ALPHA")]
    CompressedSrgbAlpha = 35913,

    [NativeName("GL_CURRENT_RASTER_SECONDARY_COLOR")]
    CurrentRasterSecondaryColor = 33887,

    [NativeName("GL_SLUMINANCE_ALPHA")]
    SluminanceAlpha = 35908,

    [NativeName("GL_SLUMINANCE8_ALPHA8")]
    Sluminance8Alpha8 = 35909,

    [NativeName("GL_SLUMINANCE")]
    Sluminance = 35910,

    [NativeName("GL_SLUMINANCE8")]
    Sluminance8 = 35911,

    [NativeName("GL_COMPRESSED_SLUMINANCE")]
    CompressedSluminance = 35914,

    [NativeName("GL_COMPRESSED_SLUMINANCE_ALPHA")]
    CompressedSluminanceAlpha = 35915,

    [NativeName("GL_COMPARE_REF_TO_TEXTURE")]
    CompareRefToTexture = 34894,

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

    [NativeName("GL_COMPRESSED_RED")]
    CompressedRed = 33317,

    [NativeName("GL_COMPRESSED_RG")]
    CompressedRg = 33318,

    [NativeName("GL_CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT")]
    ContextFlagForwardCompatibleBit = 1,

    [NativeName("GL_RGBA32F")]
    Rgba32F = 34836,

    [NativeName("GL_RGB32F")]
    Rgb32F = 34837,

    [NativeName("GL_RGBA16F")]
    Rgba16F = 34842,

    [NativeName("GL_RGB16F")]
    Rgb16F = 34843,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_INTEGER")]
    VertexAttribArrayInteger = 35069,

    [NativeName("GL_MAX_ARRAY_TEXTURE_LAYERS")]
    MaxArrayTextureLayers = 35071,

    [NativeName("GL_MIN_PROGRAM_TEXEL_OFFSET")]
    MinProgramTexelOffset = 35076,

    [NativeName("GL_MAX_PROGRAM_TEXEL_OFFSET")]
    MaxProgramTexelOffset = 35077,

    [NativeName("GL_CLAMP_READ_COLOR")]
    ClampReadColor = 35100,

    [NativeName("GL_FIXED_ONLY")]
    FixedOnly = 35101,

    [NativeName("GL_MAX_VARYING_COMPONENTS")]
    MaxVaryingComponents = 35659,

    [NativeName("GL_TEXTURE_1D_ARRAY")]
    Texture1DArray = 35864,

    [NativeName("GL_PROXY_TEXTURE_1D_ARRAY")]
    ProxyTexture1DArray = 35865,

    [NativeName("GL_TEXTURE_2D_ARRAY")]
    Texture2DArray = 35866,

    [NativeName("GL_PROXY_TEXTURE_2D_ARRAY")]
    ProxyTexture2DArray = 35867,

    [NativeName("GL_TEXTURE_BINDING_1D_ARRAY")]
    TextureBinding1DArray = 35868,

    [NativeName("GL_TEXTURE_BINDING_2D_ARRAY")]
    TextureBinding2DArray = 35869,

    [NativeName("GL_R11F_G11F_B10F")]
    R11FG11FB10F = 35898,

    [NativeName("GL_UNSIGNED_INT_10F_11F_11F_REV")]
    UnsignedInt10F11F11FRev = 35899,

    [NativeName("GL_RGB9_E5")]
    Rgb9E5 = 35901,

    [NativeName("GL_UNSIGNED_INT_5_9_9_9_REV")]
    UnsignedInt5X9X9X9Rev = 35902,

    [NativeName("GL_TEXTURE_SHARED_SIZE")]
    TextureSharedSize = 35903,

    [NativeName("GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH")]
    TransformFeedbackVaryingMaxLength = 35958,

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_MODE")]
    TransformFeedbackBufferMode = 35967,

    [NativeName("GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS")]
    MaxTransformFeedbackSeparateComponents = 35968,

    [NativeName("GL_TRANSFORM_FEEDBACK_VARYINGS")]
    TransformFeedbackVaryings = 35971,

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_START")]
    TransformFeedbackBufferStart = 35972,

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_SIZE")]
    TransformFeedbackBufferSize = 35973,

    [NativeName("GL_PRIMITIVES_GENERATED")]
    PrimitivesGenerated = 35975,

    [NativeName("GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN")]
    TransformFeedbackPrimitivesWritten = 35976,

    [NativeName("GL_RASTERIZER_DISCARD")]
    RasterizerDiscard = 35977,

    [NativeName("GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS")]
    MaxTransformFeedbackInterleavedComponents = 35978,

    [NativeName("GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS")]
    MaxTransformFeedbackSeparateAttribs = 35979,

    [NativeName("GL_INTERLEAVED_ATTRIBS")]
    InterleavedAttribs = 35980,

    [NativeName("GL_SEPARATE_ATTRIBS")]
    SeparateAttribs = 35981,

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER")]
    TransformFeedbackBuffer = 35982,

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_BINDING")]
    TransformFeedbackBufferBinding = 35983,

    [NativeName("GL_RGBA32UI")]
    Rgba32Ui = 36208,

    [NativeName("GL_RGB32UI")]
    Rgb32Ui = 36209,

    [NativeName("GL_RGBA16UI")]
    Rgba16Ui = 36214,

    [NativeName("GL_RGB16UI")]
    Rgb16Ui = 36215,

    [NativeName("GL_RGBA8UI")]
    Rgba8Ui = 36220,

    [NativeName("GL_RGB8UI")]
    Rgb8Ui = 36221,

    [NativeName("GL_RGBA32I")]
    Rgba32I = 36226,

    [NativeName("GL_RGB32I")]
    Rgb32I = 36227,

    [NativeName("GL_RGBA16I")]
    Rgba16I = 36232,

    [NativeName("GL_RGB16I")]
    Rgb16I = 36233,

    [NativeName("GL_RGBA8I")]
    Rgba8I = 36238,

    [NativeName("GL_RGB8I")]
    Rgb8I = 36239,

    [NativeName("GL_RED_INTEGER")]
    RedInteger = 36244,

    [NativeName("GL_GREEN_INTEGER")]
    GreenInteger = 36245,

    [NativeName("GL_BLUE_INTEGER")]
    BlueInteger = 36246,

    [NativeName("GL_RGB_INTEGER")]
    RgbInteger = 36248,

    [NativeName("GL_RGBA_INTEGER")]
    RgbaInteger = 36249,

    [NativeName("GL_BGR_INTEGER")]
    BgrInteger = 36250,

    [NativeName("GL_BGRA_INTEGER")]
    BgraInteger = 36251,

    [NativeName("GL_SAMPLER_1D_ARRAY")]
    Sampler1DArray = 36288,

    [NativeName("GL_SAMPLER_2D_ARRAY")]
    Sampler2DArray = 36289,

    [NativeName("GL_SAMPLER_1D_ARRAY_SHADOW")]
    Sampler1DArrayShadow = 36291,

    [NativeName("GL_SAMPLER_2D_ARRAY_SHADOW")]
    Sampler2DArrayShadow = 36292,

    [NativeName("GL_SAMPLER_CUBE_SHADOW")]
    SamplerCubeShadow = 36293,

    [NativeName("GL_UNSIGNED_INT_VEC2")]
    UnsignedIntVec2 = 36294,

    [NativeName("GL_UNSIGNED_INT_VEC3")]
    UnsignedIntVec3 = 36295,

    [NativeName("GL_UNSIGNED_INT_VEC4")]
    UnsignedIntVec4 = 36296,

    [NativeName("GL_INT_SAMPLER_1D")]
    IntSampler1D = 36297,

    [NativeName("GL_INT_SAMPLER_2D")]
    IntSampler2D = 36298,

    [NativeName("GL_INT_SAMPLER_3D")]
    IntSampler3D = 36299,

    [NativeName("GL_INT_SAMPLER_CUBE")]
    IntSamplerCube = 36300,

    [NativeName("GL_INT_SAMPLER_1D_ARRAY")]
    IntSampler1DArray = 36302,

    [NativeName("GL_INT_SAMPLER_2D_ARRAY")]
    IntSampler2DArray = 36303,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_1D")]
    UnsignedIntSampler1D = 36305,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_2D")]
    UnsignedIntSampler2D = 36306,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_3D")]
    UnsignedIntSampler3D = 36307,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_CUBE")]
    UnsignedIntSamplerCube = 36308,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_1D_ARRAY")]
    UnsignedIntSampler1DArray = 36310,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_2D_ARRAY")]
    UnsignedIntSampler2DArray = 36311,

    [NativeName("GL_QUERY_WAIT")]
    QueryWait = 36371,

    [NativeName("GL_QUERY_NO_WAIT")]
    QueryNoWait = 36372,

    [NativeName("GL_QUERY_BY_REGION_WAIT")]
    QueryByRegionWait = 36373,

    [NativeName("GL_QUERY_BY_REGION_NO_WAIT")]
    QueryByRegionNoWait = 36374,

    [NativeName("GL_BUFFER_ACCESS_FLAGS")]
    BufferAccessFlags = 37151,

    [NativeName("GL_BUFFER_MAP_LENGTH")]
    BufferMapLength = 37152,

    [NativeName("GL_BUFFER_MAP_OFFSET")]
    BufferMapOffset = 37153,

    [NativeName("GL_DEPTH_COMPONENT32F")]
    DepthComponent32F = 36012,

    [NativeName("GL_DEPTH32F_STENCIL8")]
    Depth32FStencil8 = 36013,

    [NativeName("GL_FLOAT_32_UNSIGNED_INT_24_8_REV")]
    Float32UnsignedInt24X8Rev = 36269,

    [NativeName("GL_INVALID_FRAMEBUFFER_OPERATION")]
    InvalidFramebufferOperation = 1286,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING")]
    FramebufferAttachmentColorEncoding = 33296,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE")]
    FramebufferAttachmentComponentType = 33297,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE")]
    FramebufferAttachmentRedSize = 33298,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE")]
    FramebufferAttachmentGreenSize = 33299,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE")]
    FramebufferAttachmentBlueSize = 33300,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE")]
    FramebufferAttachmentAlphaSize = 33301,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE")]
    FramebufferAttachmentDepthSize = 33302,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE")]
    FramebufferAttachmentStencilSize = 33303,

    [NativeName("GL_FRAMEBUFFER_DEFAULT")]
    FramebufferDefault = 33304,

    [NativeName("GL_FRAMEBUFFER_UNDEFINED")]
    FramebufferUndefined = 33305,

    [NativeName("GL_DEPTH_STENCIL_ATTACHMENT")]
    DepthStencilAttachment = 33306,

    [NativeName("GL_MAX_RENDERBUFFER_SIZE")]
    MaxRenderbufferSize = 34024,

    [NativeName("GL_DEPTH_STENCIL")]
    DepthStencil = 34041,

    [NativeName("GL_UNSIGNED_INT_24_8")]
    UnsignedInt24X8 = 34042,

    [NativeName("GL_DEPTH24_STENCIL8")]
    Depth24Stencil8 = 35056,

    [NativeName("GL_TEXTURE_STENCIL_SIZE")]
    TextureStencilSize = 35057,

    [NativeName("GL_TEXTURE_RED_TYPE")]
    TextureRedType = 35856,

    [NativeName("GL_TEXTURE_GREEN_TYPE")]
    TextureGreenType = 35857,

    [NativeName("GL_TEXTURE_BLUE_TYPE")]
    TextureBlueType = 35858,

    [NativeName("GL_TEXTURE_ALPHA_TYPE")]
    TextureAlphaType = 35859,

    [NativeName("GL_TEXTURE_DEPTH_TYPE")]
    TextureDepthType = 35862,

    [NativeName("GL_UNSIGNED_NORMALIZED")]
    UnsignedNormalized = 35863,

    [NativeName("GL_FRAMEBUFFER_BINDING")]
    FramebufferBinding = 36006,

    [NativeName("GL_DRAW_FRAMEBUFFER_BINDING")]
    DrawFramebufferBinding = 36006,

    [NativeName("GL_RENDERBUFFER_BINDING")]
    RenderbufferBinding = 36007,

    [NativeName("GL_READ_FRAMEBUFFER")]
    ReadFramebuffer = 36008,

    [NativeName("GL_DRAW_FRAMEBUFFER")]
    DrawFramebuffer = 36009,

    [NativeName("GL_READ_FRAMEBUFFER_BINDING")]
    ReadFramebufferBinding = 36010,

    [NativeName("GL_RENDERBUFFER_SAMPLES")]
    RenderbufferSamples = 36011,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE")]
    FramebufferAttachmentObjectType = 36048,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME")]
    FramebufferAttachmentObjectName = 36049,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL")]
    FramebufferAttachmentTextureLevel = 36050,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE")]
    FramebufferAttachmentTextureCubeMapFace = 36051,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER")]
    FramebufferAttachmentTextureLayer = 36052,

    [NativeName("GL_FRAMEBUFFER_COMPLETE")]
    FramebufferComplete = 36053,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT")]
    FramebufferIncompleteAttachment = 36054,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT")]
    FramebufferIncompleteMissingAttachment = 36055,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER")]
    FramebufferIncompleteDrawBuffer = 36059,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER")]
    FramebufferIncompleteReadBuffer = 36060,

    [NativeName("GL_FRAMEBUFFER_UNSUPPORTED")]
    FramebufferUnsupported = 36061,

    [NativeName("GL_MAX_COLOR_ATTACHMENTS")]
    MaxColorAttachments = 36063,

    [NativeName("GL_COLOR_ATTACHMENT0")]
    ColorAttachment0 = 36064,

    [NativeName("GL_COLOR_ATTACHMENT1")]
    ColorAttachment1 = 36065,

    [NativeName("GL_COLOR_ATTACHMENT2")]
    ColorAttachment2 = 36066,

    [NativeName("GL_COLOR_ATTACHMENT3")]
    ColorAttachment3 = 36067,

    [NativeName("GL_COLOR_ATTACHMENT4")]
    ColorAttachment4 = 36068,

    [NativeName("GL_COLOR_ATTACHMENT5")]
    ColorAttachment5 = 36069,

    [NativeName("GL_COLOR_ATTACHMENT6")]
    ColorAttachment6 = 36070,

    [NativeName("GL_COLOR_ATTACHMENT7")]
    ColorAttachment7 = 36071,

    [NativeName("GL_COLOR_ATTACHMENT8")]
    ColorAttachment8 = 36072,

    [NativeName("GL_COLOR_ATTACHMENT9")]
    ColorAttachment9 = 36073,

    [NativeName("GL_COLOR_ATTACHMENT10")]
    ColorAttachment10 = 36074,

    [NativeName("GL_COLOR_ATTACHMENT11")]
    ColorAttachment11 = 36075,

    [NativeName("GL_COLOR_ATTACHMENT12")]
    ColorAttachment12 = 36076,

    [NativeName("GL_COLOR_ATTACHMENT13")]
    ColorAttachment13 = 36077,

    [NativeName("GL_COLOR_ATTACHMENT14")]
    ColorAttachment14 = 36078,

    [NativeName("GL_COLOR_ATTACHMENT15")]
    ColorAttachment15 = 36079,

    [NativeName("GL_COLOR_ATTACHMENT16")]
    ColorAttachment16 = 36080,

    [NativeName("GL_COLOR_ATTACHMENT17")]
    ColorAttachment17 = 36081,

    [NativeName("GL_COLOR_ATTACHMENT18")]
    ColorAttachment18 = 36082,

    [NativeName("GL_COLOR_ATTACHMENT19")]
    ColorAttachment19 = 36083,

    [NativeName("GL_COLOR_ATTACHMENT20")]
    ColorAttachment20 = 36084,

    [NativeName("GL_COLOR_ATTACHMENT21")]
    ColorAttachment21 = 36085,

    [NativeName("GL_COLOR_ATTACHMENT22")]
    ColorAttachment22 = 36086,

    [NativeName("GL_COLOR_ATTACHMENT23")]
    ColorAttachment23 = 36087,

    [NativeName("GL_COLOR_ATTACHMENT24")]
    ColorAttachment24 = 36088,

    [NativeName("GL_COLOR_ATTACHMENT25")]
    ColorAttachment25 = 36089,

    [NativeName("GL_COLOR_ATTACHMENT26")]
    ColorAttachment26 = 36090,

    [NativeName("GL_COLOR_ATTACHMENT27")]
    ColorAttachment27 = 36091,

    [NativeName("GL_COLOR_ATTACHMENT28")]
    ColorAttachment28 = 36092,

    [NativeName("GL_COLOR_ATTACHMENT29")]
    ColorAttachment29 = 36093,

    [NativeName("GL_COLOR_ATTACHMENT30")]
    ColorAttachment30 = 36094,

    [NativeName("GL_COLOR_ATTACHMENT31")]
    ColorAttachment31 = 36095,

    [NativeName("GL_DEPTH_ATTACHMENT")]
    DepthAttachment = 36096,

    [NativeName("GL_STENCIL_ATTACHMENT")]
    StencilAttachment = 36128,

    [NativeName("GL_FRAMEBUFFER")]
    Framebuffer = 36160,

    [NativeName("GL_RENDERBUFFER")]
    Renderbuffer = 36161,

    [NativeName("GL_RENDERBUFFER_WIDTH")]
    RenderbufferWidth = 36162,

    [NativeName("GL_RENDERBUFFER_HEIGHT")]
    RenderbufferHeight = 36163,

    [NativeName("GL_RENDERBUFFER_INTERNAL_FORMAT")]
    RenderbufferInternalFormat = 36164,

    [NativeName("GL_STENCIL_INDEX1")]
    StencilIndex1 = 36166,

    [NativeName("GL_STENCIL_INDEX4")]
    StencilIndex4 = 36167,

    [NativeName("GL_STENCIL_INDEX8")]
    StencilIndex8 = 36168,

    [NativeName("GL_STENCIL_INDEX16")]
    StencilIndex16 = 36169,

    [NativeName("GL_RENDERBUFFER_RED_SIZE")]
    RenderbufferRedSize = 36176,

    [NativeName("GL_RENDERBUFFER_GREEN_SIZE")]
    RenderbufferGreenSize = 36177,

    [NativeName("GL_RENDERBUFFER_BLUE_SIZE")]
    RenderbufferBlueSize = 36178,

    [NativeName("GL_RENDERBUFFER_ALPHA_SIZE")]
    RenderbufferAlphaSize = 36179,

    [NativeName("GL_RENDERBUFFER_DEPTH_SIZE")]
    RenderbufferDepthSize = 36180,

    [NativeName("GL_RENDERBUFFER_STENCIL_SIZE")]
    RenderbufferStencilSize = 36181,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE")]
    FramebufferIncompleteMultisample = 36182,

    [NativeName("GL_MAX_SAMPLES")]
    MaxSamples = 36183,

    [NativeName("GL_INDEX")]
    Index = 33314,

    [NativeName("GL_TEXTURE_LUMINANCE_TYPE")]
    TextureLuminanceType = 35860,

    [NativeName("GL_TEXTURE_INTENSITY_TYPE")]
    TextureIntensityType = 35861,

    [NativeName("GL_FRAMEBUFFER_SRGB")]
    FramebufferSrgb = 36281,

    [NativeName("GL_HALF_FLOAT")]
    HalfFloat = 5131,

    [NativeName("GL_MAP_READ_BIT")]
    MapReadBit = 1,

    [NativeName("GL_MAP_WRITE_BIT")]
    MapWriteBit = 2,

    [NativeName("GL_MAP_INVALIDATE_RANGE_BIT")]
    MapInvalidateRangeBit = 4,

    [NativeName("GL_MAP_INVALIDATE_BUFFER_BIT")]
    MapInvalidateBufferBit = 8,

    [NativeName("GL_MAP_FLUSH_EXPLICIT_BIT")]
    MapFlushExplicitBit = 16,

    [NativeName("GL_MAP_UNSYNCHRONIZED_BIT")]
    MapUnsynchronizedBit = 32,

    [NativeName("GL_COMPRESSED_RED_RGTC1")]
    CompressedRedRgtc1 = 36283,

    [NativeName("GL_COMPRESSED_SIGNED_RED_RGTC1")]
    CompressedSignedRedRgtc1 = 36284,

    [NativeName("GL_COMPRESSED_RG_RGTC2")]
    CompressedRgRgtc2 = 36285,

    [NativeName("GL_COMPRESSED_SIGNED_RG_RGTC2")]
    CompressedSignedRgRgtc2 = 36286,

    [NativeName("GL_RG")]
    Rg = 33319,

    [NativeName("GL_RG_INTEGER")]
    RgInteger = 33320,

    [NativeName("GL_R8")]
    R8 = 33321,

    [NativeName("GL_R16")]
    R16 = 33322,

    [NativeName("GL_RG8")]
    Rg8 = 33323,

    [NativeName("GL_RG16")]
    Rg16 = 33324,

    [NativeName("GL_R16F")]
    R16F = 33325,

    [NativeName("GL_R32F")]
    R32F = 33326,

    [NativeName("GL_RG16F")]
    Rg16F = 33327,

    [NativeName("GL_RG32F")]
    Rg32F = 33328,

    [NativeName("GL_R8I")]
    R8I = 33329,

    [NativeName("GL_R8UI")]
    R8Ui = 33330,

    [NativeName("GL_R16I")]
    R16I = 33331,

    [NativeName("GL_R16UI")]
    R16Ui = 33332,

    [NativeName("GL_R32I")]
    R32I = 33333,

    [NativeName("GL_R32UI")]
    R32Ui = 33334,

    [NativeName("GL_RG8I")]
    Rg8I = 33335,

    [NativeName("GL_RG8UI")]
    Rg8Ui = 33336,

    [NativeName("GL_RG16I")]
    Rg16I = 33337,

    [NativeName("GL_RG16UI")]
    Rg16Ui = 33338,

    [NativeName("GL_RG32I")]
    Rg32I = 33339,

    [NativeName("GL_RG32UI")]
    Rg32Ui = 33340,

    [NativeName("GL_VERTEX_ARRAY_BINDING")]
    VertexArrayBinding = 34229,

    [NativeName("GL_CLAMP_VERTEX_COLOR")]
    ClampVertexColor = 35098,

    [NativeName("GL_CLAMP_FRAGMENT_COLOR")]
    ClampFragmentColor = 35099,

    [NativeName("GL_ALPHA_INTEGER")]
    AlphaInteger = 36247,

    [NativeName("GL_SAMPLER_2D_RECT")]
    Sampler2DRect = 35683,

    [NativeName("GL_SAMPLER_2D_RECT_SHADOW")]
    Sampler2DRectShadow = 35684,

    [NativeName("GL_SAMPLER_BUFFER")]
    SamplerBuffer = 36290,

    [NativeName("GL_INT_SAMPLER_2D_RECT")]
    IntSampler2DRect = 36301,

    [NativeName("GL_INT_SAMPLER_BUFFER")]
    IntSamplerBuffer = 36304,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_2D_RECT")]
    UnsignedIntSampler2DRect = 36309,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_BUFFER")]
    UnsignedIntSamplerBuffer = 36312,

    [NativeName("GL_TEXTURE_BUFFER")]
    TextureBuffer = 35882,

    [NativeName("GL_MAX_TEXTURE_BUFFER_SIZE")]
    MaxTextureBufferSize = 35883,

    [NativeName("GL_TEXTURE_BINDING_BUFFER")]
    TextureBindingBuffer = 35884,

    [NativeName("GL_TEXTURE_BUFFER_DATA_STORE_BINDING")]
    TextureBufferDataStoreBinding = 35885,

    [NativeName("GL_TEXTURE_RECTANGLE")]
    TextureRectANGLE = 34037,

    [NativeName("GL_TEXTURE_BINDING_RECTANGLE")]
    TextureBindingRectANGLE = 34038,

    [NativeName("GL_PROXY_TEXTURE_RECTANGLE")]
    ProxyTextureRectANGLE = 34039,

    [NativeName("GL_MAX_RECTANGLE_TEXTURE_SIZE")]
    MaxRectangleTextureSize = 34040,

    [NativeName("GL_R8_SNORM")]
    R8Snorm = 36756,

    [NativeName("GL_RG8_SNORM")]
    Rg8Snorm = 36757,

    [NativeName("GL_RGB8_SNORM")]
    Rgb8Snorm = 36758,

    [NativeName("GL_RGBA8_SNORM")]
    Rgba8Snorm = 36759,

    [NativeName("GL_R16_SNORM")]
    R16Snorm = 36760,

    [NativeName("GL_RG16_SNORM")]
    Rg16Snorm = 36761,

    [NativeName("GL_RGB16_SNORM")]
    Rgb16Snorm = 36762,

    [NativeName("GL_RGBA16_SNORM")]
    Rgba16Snorm = 36763,

    [NativeName("GL_SIGNED_NORMALIZED")]
    SignedNormalized = 36764,

    [NativeName("GL_PRIMITIVE_RESTART")]
    PrimitiveRestart = 36765,

    [NativeName("GL_PRIMITIVE_RESTART_INDEX")]
    PrimitiveRestartIndex = 36766,

    [NativeName("GL_COPY_READ_BUFFER")]
    CopyReadBuffer = 36662,

    [NativeName("GL_COPY_WRITE_BUFFER")]
    CopyWriteBuffer = 36663,

    [NativeName("GL_UNIFORM_BUFFER")]
    UniformBuffer = 35345,

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

    [NativeName("GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH")]
    ActiveUniformBlockMaxNameLength = 35381,

    [NativeName("GL_ACTIVE_UNIFORM_BLOCKS")]
    ActiveUniformBlocks = 35382,

    [NativeName("GL_UNIFORM_TYPE")]
    UniformType = 35383,

    [NativeName("GL_UNIFORM_SIZE")]
    UniformSize = 35384,

    [NativeName("GL_UNIFORM_NAME_LENGTH")]
    UniformNameLength = 35385,

    [NativeName("GL_UNIFORM_BLOCK_INDEX")]
    UniformBlockIndex = 35386,

    [NativeName("GL_UNIFORM_OFFSET")]
    UniformOffset = 35387,

    [NativeName("GL_UNIFORM_ARRAY_STRIDE")]
    UniformArrayStride = 35388,

    [NativeName("GL_UNIFORM_MATRIX_STRIDE")]
    UniformMatrixStride = 35389,

    [NativeName("GL_UNIFORM_IS_ROW_MAJOR")]
    UniformIsRowMajor = 35390,

    [NativeName("GL_UNIFORM_BLOCK_BINDING")]
    UniformBlockBinding = 35391,

    [NativeName("GL_UNIFORM_BLOCK_DATA_SIZE")]
    UniformBlockDataSize = 35392,

    [NativeName("GL_UNIFORM_BLOCK_NAME_LENGTH")]
    UniformBlockNameLength = 35393,

    [NativeName("GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS")]
    UniformBlockActiveUniforms = 35394,

    [NativeName("GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES")]
    UniformBlockActiveUniformIndices = 35395,

    [NativeName("GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER")]
    UniformBlockReferencedByVertexShader = 35396,

    [NativeName("GL_UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER")]
    UniformBlockReferencedByGeometryShader = 35397,

    [NativeName("GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER")]
    UniformBlockReferencedByFragmentShader = 35398,

    [NativeName("GL_INVALID_INDEX")]
    InvalidIndex = 4294967295,

    [NativeName("GL_CONTEXT_CORE_PROFILE_BIT")]
    ContextCoreProfileBit = 1,

    [NativeName("GL_CONTEXT_COMPATIBILITY_PROFILE_BIT")]
    ContextCompatibilityProfileBit = 2,

    [NativeName("GL_LINES_ADJACENCY")]
    LinesAdjacency = 10,

    [NativeName("GL_LINE_STRIP_ADJACENCY")]
    LineStripAdjacency = 11,

    [NativeName("GL_TRIANGLES_ADJACENCY")]
    TrianglesAdjacency = 12,

    [NativeName("GL_TRIANGLE_STRIP_ADJACENCY")]
    TriangleStripAdjacency = 13,

    [NativeName("GL_PROGRAM_POINT_SIZE")]
    ProgramPointSize = 34370,

    [NativeName("GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS")]
    MaxGeometryTextureImageUnits = 35881,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_LAYERED")]
    FramebufferAttachmentLayered = 36263,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS")]
    FramebufferIncompleteLayerTargets = 36264,

    [NativeName("GL_GEOMETRY_SHADER")]
    GeometryShader = 36313,

    [NativeName("GL_GEOMETRY_VERTICES_OUT")]
    GeometryVerticesOut = 35094,

    [NativeName("GL_GEOMETRY_INPUT_TYPE")]
    GeometryInputType = 35095,

    [NativeName("GL_GEOMETRY_OUTPUT_TYPE")]
    GeometryOutputType = 35096,

    [NativeName("GL_MAX_GEOMETRY_UNIFORM_COMPONENTS")]
    MaxGeometryUniformComponents = 36319,

    [NativeName("GL_MAX_GEOMETRY_OUTPUT_VERTICES")]
    MaxGeometryOutputVertices = 36320,

    [NativeName("GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS")]
    MaxGeometryTotalOutputComponents = 36321,

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

    [NativeName("GL_DEPTH_CLAMP")]
    DepthClamp = 34383,

    [NativeName("GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION")]
    QuadsFollowProvokingVertexConvention = 36428,

    [NativeName("GL_FIRST_VERTEX_CONVENTION")]
    FirstVertexConvention = 36429,

    [NativeName("GL_LAST_VERTEX_CONVENTION")]
    LastVertexConvention = 36430,

    [NativeName("GL_PROVOKING_VERTEX")]
    ProvokingVertex = 36431,

    [NativeName("GL_TEXTURE_CUBE_MAP_SEAMLESS")]
    TextureCubeMapSeamless = 34895,

    [NativeName("GL_MAX_SERVER_WAIT_TIMEOUT")]
    MaxServerWaitTimeout = 37137,

    [NativeName("GL_OBJECT_TYPE")]
    ObjectType = 37138,

    [NativeName("GL_SYNC_CONDITION")]
    SyncCondition = 37139,

    [NativeName("GL_SYNC_STATUS")]
    SyncStatus = 37140,

    [NativeName("GL_SYNC_FLAGS")]
    SyncFlags = 37141,

    [NativeName("GL_SYNC_FENCE")]
    SyncFence = 37142,

    [NativeName("GL_SYNC_GPU_COMMANDS_COMPLETE")]
    SyncGpuCommandsComplete = 37143,

    [NativeName("GL_UNSIGNALED")]
    Unsignaled = 37144,

    [NativeName("GL_SIGNALED")]
    Signaled = 37145,

    [NativeName("GL_ALREADY_SIGNALED")]
    AlreadySignaled = 37146,

    [NativeName("GL_TIMEOUT_EXPIRED")]
    TimeoutExpired = 37147,

    [NativeName("GL_CONDITION_SATISFIED")]
    ConditionSatisfied = 37148,

    [NativeName("GL_WAIT_FAILED")]
    WaitFailed = 37149,

    [NativeName("GL_TIMEOUT_IGNORED")]
    TimeoutIgnored = 4294967295,

    [NativeName("GL_SYNC_FLUSH_COMMANDS_BIT")]
    SyncFlushCommandsBit = 1,

    [NativeName("GL_SAMPLE_POSITION")]
    SamplePosition = 36432,

    [NativeName("GL_SAMPLE_MASK")]
    SampleMask = 36433,

    [NativeName("GL_SAMPLE_MASK_VALUE")]
    SampleMaskValue = 36434,

    [NativeName("GL_MAX_SAMPLE_MASK_WORDS")]
    MaxSampleMaskWords = 36441,

    [NativeName("GL_TEXTURE_2D_MULTISAMPLE")]
    Texture2DMultisample = 37120,

    [NativeName("GL_PROXY_TEXTURE_2D_MULTISAMPLE")]
    ProxyTexture2DMultisample = 37121,

    [NativeName("GL_TEXTURE_2D_MULTISAMPLE_ARRAY")]
    Texture2DMultisampleArray = 37122,

    [NativeName("GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY")]
    ProxyTexture2DMultisampleArray = 37123,

    [NativeName("GL_TEXTURE_BINDING_2D_MULTISAMPLE")]
    TextureBinding2DMultisample = 37124,

    [NativeName("GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY")]
    TextureBinding2DMultisampleArray = 37125,

    [NativeName("GL_TEXTURE_SAMPLES")]
    TextureSamples = 37126,

    [NativeName("GL_TEXTURE_FIXED_SAMPLE_LOCATIONS")]
    TextureFixedSampleLocations = 37127,

    [NativeName("GL_SAMPLER_2D_MULTISAMPLE")]
    Sampler2DMultisample = 37128,

    [NativeName("GL_INT_SAMPLER_2D_MULTISAMPLE")]
    IntSampler2DMultisample = 37129,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE")]
    UnsignedIntSampler2DMultisample = 37130,

    [NativeName("GL_SAMPLER_2D_MULTISAMPLE_ARRAY")]
    Sampler2DMultisampleArray = 37131,

    [NativeName("GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY")]
    IntSampler2DMultisampleArray = 37132,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY")]
    UnsignedIntSampler2DMultisampleArray = 37133,

    [NativeName("GL_MAX_COLOR_TEXTURE_SAMPLES")]
    MaxColorTextureSamples = 37134,

    [NativeName("GL_MAX_DEPTH_TEXTURE_SAMPLES")]
    MaxDepthTextureSamples = 37135,

    [NativeName("GL_MAX_INTEGER_SAMPLES")]
    MaxIntegerSamples = 37136,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_DIVISOR")]
    VertexAttribArrayDivisor = 35070,

    [NativeName("GL_SRC1_COLOR")]
    Src1Color = 35065,

    [NativeName("GL_ONE_MINUS_SRC1_COLOR")]
    OneMinusSrc1Color = 35066,

    [NativeName("GL_ONE_MINUS_SRC1_ALPHA")]
    OneMinusSrc1Alpha = 35067,

    [NativeName("GL_MAX_DUAL_SOURCE_DRAW_BUFFERS")]
    MaxDualSourceDrawBuffers = 35068,

    [NativeName("GL_ANY_SAMPLES_PASSED")]
    AnySamplesPassed = 35887,

    [NativeName("GL_SAMPLER_BINDING")]
    SamplerBinding = 35097,

    [NativeName("GL_RGB10_A2UI")]
    Rgb10A2Ui = 36975,

    [NativeName("GL_TEXTURE_SWIZZLE_R")]
    TextureSwizzleR = 36418,

    [NativeName("GL_TEXTURE_SWIZZLE_G")]
    TextureSwizzleG = 36419,

    [NativeName("GL_TEXTURE_SWIZZLE_B")]
    TextureSwizzleB = 36420,

    [NativeName("GL_TEXTURE_SWIZZLE_A")]
    TextureSwizzleA = 36421,

    [NativeName("GL_TEXTURE_SWIZZLE_RGBA")]
    TextureSwizzleRgba = 36422,

    [NativeName("GL_TIME_ELAPSED")]
    TimeElapsed = 35007,

    [NativeName("GL_TIMESTAMP")]
    Timestamp = 36392,

    [NativeName("GL_INT_2_10_10_10_REV")]
    Int2X10X10X10Rev = 36255,

    [NativeName("GL_SAMPLE_SHADING")]
    SampleShading = 35894,

    [NativeName("GL_MIN_SAMPLE_SHADING_VALUE")]
    MinSampleShadingValue = 35895,

    [NativeName("GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET")]
    MinProgramTextureGatherOffset = 36446,

    [NativeName("GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET")]
    MaxProgramTextureGatherOffset = 36447,

    [NativeName("GL_TEXTURE_CUBE_MAP_ARRAY")]
    TextureCubeMapArray = 36873,

    [NativeName("GL_TEXTURE_BINDING_CUBE_MAP_ARRAY")]
    TextureBindingCubeMapArray = 36874,

    [NativeName("GL_PROXY_TEXTURE_CUBE_MAP_ARRAY")]
    ProxyTextureCubeMapArray = 36875,

    [NativeName("GL_SAMPLER_CUBE_MAP_ARRAY")]
    SamplerCubeMapArray = 36876,

    [NativeName("GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW")]
    SamplerCubeMapArrayShadow = 36877,

    [NativeName("GL_INT_SAMPLER_CUBE_MAP_ARRAY")]
    IntSamplerCubeMapArray = 36878,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY")]
    UnsignedIntSamplerCubeMapArray = 36879,

    [NativeName("GL_DRAW_INDIRECT_BUFFER")]
    DrawIndirectBuffer = 36671,

    [NativeName("GL_DRAW_INDIRECT_BUFFER_BINDING")]
    DrawIndirectBufferBinding = 36675,

    [NativeName("GL_GEOMETRY_SHADER_INVOCATIONS")]
    GeometryShaderInvocations = 34943,

    [NativeName("GL_MAX_GEOMETRY_SHADER_INVOCATIONS")]
    MaxGeometryShaderInvocations = 36442,

    [NativeName("GL_MIN_FRAGMENT_INTERPOLATION_OFFSET")]
    MinFragmentInterpolationOffset = 36443,

    [NativeName("GL_MAX_FRAGMENT_INTERPOLATION_OFFSET")]
    MaxFragmentInterpolationOffset = 36444,

    [NativeName("GL_FRAGMENT_INTERPOLATION_OFFSET_BITS")]
    FragmentInterpolationOffsetBits = 36445,

    [NativeName("GL_MAX_VERTEX_STREAMS")]
    MaxVertexStreams = 36465,

    [NativeName("GL_DOUBLE_VEC2")]
    DoubleVec2 = 36860,

    [NativeName("GL_DOUBLE_VEC3")]
    DoubleVec3 = 36861,

    [NativeName("GL_DOUBLE_VEC4")]
    DoubleVec4 = 36862,

    [NativeName("GL_DOUBLE_MAT2")]
    DoubleMat2 = 36678,

    [NativeName("GL_DOUBLE_MAT3")]
    DoubleMat3 = 36679,

    [NativeName("GL_DOUBLE_MAT4")]
    DoubleMat4 = 36680,

    [NativeName("GL_DOUBLE_MAT2x3")]
    DoubleMat2X3 = 36681,

    [NativeName("GL_DOUBLE_MAT2x4")]
    DoubleMat2X4 = 36682,

    [NativeName("GL_DOUBLE_MAT3x2")]
    DoubleMat3X2 = 36683,

    [NativeName("GL_DOUBLE_MAT3x4")]
    DoubleMat3X4 = 36684,

    [NativeName("GL_DOUBLE_MAT4x2")]
    DoubleMat4X2 = 36685,

    [NativeName("GL_DOUBLE_MAT4x3")]
    DoubleMat4X3 = 36686,

    [NativeName("GL_ACTIVE_SUBROUTINES")]
    ActiveSubroutines = 36325,

    [NativeName("GL_ACTIVE_SUBROUTINE_UNIFORMS")]
    ActiveSubroutineUniforms = 36326,

    [NativeName("GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS")]
    ActiveSubroutineUniformLocations = 36423,

    [NativeName("GL_ACTIVE_SUBROUTINE_MAX_LENGTH")]
    ActiveSubroutineMaxLength = 36424,

    [NativeName("GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH")]
    ActiveSubroutineUniformMaxLength = 36425,

    [NativeName("GL_MAX_SUBROUTINES")]
    MaxSubroutines = 36327,

    [NativeName("GL_MAX_SUBROUTINE_UNIFORM_LOCATIONS")]
    MaxSubroutineUniformLocations = 36328,

    [NativeName("GL_NUM_COMPATIBLE_SUBROUTINES")]
    NumCompatibleSubroutines = 36426,

    [NativeName("GL_COMPATIBLE_SUBROUTINES")]
    CompatibleSubroutines = 36427,

    [NativeName("GL_PATCHES")]
    Patches = 14,

    [NativeName("GL_PATCH_VERTICES")]
    PatchVertices = 36466,

    [NativeName("GL_PATCH_DEFAULT_INNER_LEVEL")]
    PatchDefaultInnerLevel = 36467,

    [NativeName("GL_PATCH_DEFAULT_OUTER_LEVEL")]
    PatchDefaultOuterLevel = 36468,

    [NativeName("GL_TESS_CONTROL_OUTPUT_VERTICES")]
    TessControlOutputVertices = 36469,

    [NativeName("GL_TESS_GEN_MODE")]
    TessGenMode = 36470,

    [NativeName("GL_TESS_GEN_SPACING")]
    TessGenSpacing = 36471,

    [NativeName("GL_TESS_GEN_VERTEX_ORDER")]
    TessGenVertexOrder = 36472,

    [NativeName("GL_TESS_GEN_POINT_MODE")]
    TessGenPointMode = 36473,

    [NativeName("GL_ISOLINES")]
    Isolines = 36474,

    [NativeName("GL_FRACTIONAL_ODD")]
    FractionalOdd = 36475,

    [NativeName("GL_FRACTIONAL_EVEN")]
    FractionalEven = 36476,

    [NativeName("GL_MAX_PATCH_VERTICES")]
    MaxPatchVertices = 36477,

    [NativeName("GL_MAX_TESS_GEN_LEVEL")]
    MaxTessGenLevel = 36478,

    [NativeName("GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS")]
    MaxTessControlUniformComponents = 36479,

    [NativeName("GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS")]
    MaxTessEvaluationUniformComponents = 36480,

    [NativeName("GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS")]
    MaxTessControlTextureImageUnits = 36481,

    [NativeName("GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS")]
    MaxTessEvaluationTextureImageUnits = 36482,

    [NativeName("GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS")]
    MaxTessControlOutputComponents = 36483,

    [NativeName("GL_MAX_TESS_PATCH_COMPONENTS")]
    MaxTessPatchComponents = 36484,

    [NativeName("GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS")]
    MaxTessControlTotalOutputComponents = 36485,

    [NativeName("GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS")]
    MaxTessEvaluationOutputComponents = 36486,

    [NativeName("GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS")]
    MaxTessControlUniformBlocks = 36489,

    [NativeName("GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS")]
    MaxTessEvaluationUniformBlocks = 36490,

    [NativeName("GL_MAX_TESS_CONTROL_INPUT_COMPONENTS")]
    MaxTessControlInputComponents = 34924,

    [NativeName("GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS")]
    MaxTessEvaluationInputComponents = 34925,

    [NativeName("GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS")]
    MaxCombinedTessControlUniformComponents = 36382,

    [NativeName("GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS")]
    MaxCombinedTessEvaluationUniformComponents = 36383,

    [NativeName("GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER")]
    UniformBlockReferencedByTessControlShader = 34032,

    [NativeName("GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER")]
    UniformBlockReferencedByTessEvaluationShader = 34033,

    [NativeName("GL_TESS_EVALUATION_SHADER")]
    TessEvaluationShader = 36487,

    [NativeName("GL_TESS_CONTROL_SHADER")]
    TessControlShader = 36488,

    [NativeName("GL_TRANSFORM_FEEDBACK")]
    TransformFeedback = 36386,

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED")]
    TransformFeedbackBufferPaused = 36387,

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE")]
    TransformFeedbackBufferActive = 36388,

    [NativeName("GL_TRANSFORM_FEEDBACK_BINDING")]
    TransformFeedbackBinding = 36389,

    [NativeName("GL_MAX_TRANSFORM_FEEDBACK_BUFFERS")]
    MaxTransformFeedbackBuffers = 36464,

    [NativeName("GL_IMPLEMENTATION_COLOR_READ_TYPE")]
    ImplementationColorReadType = 35738,

    [NativeName("GL_IMPLEMENTATION_COLOR_READ_FORMAT")]
    ImplementationColorReadFormat = 35739,

    [NativeName("GL_LOW_FLOAT")]
    LowFloat = 36336,

    [NativeName("GL_MEDIUM_FLOAT")]
    MediumFloat = 36337,

    [NativeName("GL_HIGH_FLOAT")]
    HighFloat = 36338,

    [NativeName("GL_LOW_INT")]
    LowInt = 36339,

    [NativeName("GL_MEDIUM_INT")]
    MediumInt = 36340,

    [NativeName("GL_HIGH_INT")]
    HighInt = 36341,

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

    [NativeName("GL_RGB565")]
    Rgb565 = 36194,

    [NativeName("GL_PROGRAM_BINARY_RETRIEVABLE_HINT")]
    ProgramBinaryRetrievableHint = 33367,

    [NativeName("GL_PROGRAM_BINARY_LENGTH")]
    ProgramBinaryLength = 34625,

    [NativeName("GL_NUM_PROGRAM_BINARY_FORMATS")]
    NumProgramBinaryFormats = 34814,

    [NativeName("GL_PROGRAM_BINARY_FORMATS")]
    ProgramBinaryFormats = 34815,

    [NativeName("GL_VERTEX_SHADER_BIT")]
    VertexShaderBit = 1,

    [NativeName("GL_FRAGMENT_SHADER_BIT")]
    FragmentShaderBit = 2,

    [NativeName("GL_GEOMETRY_SHADER_BIT")]
    GeometryShaderBit = 4,

    [NativeName("GL_TESS_CONTROL_SHADER_BIT")]
    TessControlShaderBit = 8,

    [NativeName("GL_TESS_EVALUATION_SHADER_BIT")]
    TessEvaluationShaderBit = 16,

    [NativeName("GL_ALL_SHADER_BITS")]
    AllShaderBits = 4294967295,

    [NativeName("GL_PROGRAM_SEPARABLE")]
    ProgramSeparable = 33368,

    [NativeName("GL_ACTIVE_PROGRAM")]
    ActiveProgram = 33369,

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

    [NativeName("GL_UNDEFINED_VERTEX")]
    UndefinedVertex = 33376,

    [NativeName("GL_COPY_READ_BUFFER_BINDING")]
    CopyReadBufferBinding = 36662,

    [NativeName("GL_COPY_WRITE_BUFFER_BINDING")]
    CopyWriteBufferBinding = 36663,

    [NativeName("GL_TRANSFORM_FEEDBACK_ACTIVE")]
    TransformFeedbackActive = 36388,

    [NativeName("GL_TRANSFORM_FEEDBACK_PAUSED")]
    TransformFeedbackPaused = 36387,

    [NativeName("GL_UNPACK_COMPRESSED_BLOCK_WIDTH")]
    UnpackCompressedBlockWidth = 37159,

    [NativeName("GL_UNPACK_COMPRESSED_BLOCK_HEIGHT")]
    UnpackCompressedBlockHeight = 37160,

    [NativeName("GL_UNPACK_COMPRESSED_BLOCK_DEPTH")]
    UnpackCompressedBlockDepth = 37161,

    [NativeName("GL_UNPACK_COMPRESSED_BLOCK_SIZE")]
    UnpackCompressedBlockSize = 37162,

    [NativeName("GL_PACK_COMPRESSED_BLOCK_WIDTH")]
    PackCompressedBlockWidth = 37163,

    [NativeName("GL_PACK_COMPRESSED_BLOCK_HEIGHT")]
    PackCompressedBlockHeight = 37164,

    [NativeName("GL_PACK_COMPRESSED_BLOCK_DEPTH")]
    PackCompressedBlockDepth = 37165,

    [NativeName("GL_PACK_COMPRESSED_BLOCK_SIZE")]
    PackCompressedBlockSize = 37166,

    [NativeName("GL_NUM_SAMPLE_COUNTS")]
    NumSampleCounts = 37760,

    [NativeName("GL_MIN_MAP_BUFFER_ALIGNMENT")]
    MinMapBufferAlignment = 37052,

    [NativeName("GL_ATOMIC_COUNTER_BUFFER")]
    AtomicCounterBuffer = 37568,

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_BINDING")]
    AtomicCounterBufferBinding = 37569,

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_START")]
    AtomicCounterBufferStart = 37570,

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_SIZE")]
    AtomicCounterBufferSize = 37571,

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_DATA_SIZE")]
    AtomicCounterBufferDataSize = 37572,

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS")]
    AtomicCounterBufferActiveAtomicCounters = 37573,

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES")]
    AtomicCounterBufferActiveAtomicCounterIndices = 37574,

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER")]
    AtomicCounterBufferReferencedByVertexShader = 37575,

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER")]
    AtomicCounterBufferReferencedByTessControlShader = 37576,

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER")]
    AtomicCounterBufferReferencedByTessEvaluationShader = 37577,

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER")]
    AtomicCounterBufferReferencedByGeometryShader = 37578,

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER")]
    AtomicCounterBufferReferencedByFragmentShader = 37579,

    [NativeName("GL_MAX_VERTEX_ATOMIC_COUNTER_BUFFERS")]
    MaxVertexAtomicCounterBuffers = 37580,

    [NativeName("GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS")]
    MaxTessControlAtomicCounterBuffers = 37581,

    [NativeName("GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS")]
    MaxTessEvaluationAtomicCounterBuffers = 37582,

    [NativeName("GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS")]
    MaxGeometryAtomicCounterBuffers = 37583,

    [NativeName("GL_MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS")]
    MaxFragmentAtomicCounterBuffers = 37584,

    [NativeName("GL_MAX_COMBINED_ATOMIC_COUNTER_BUFFERS")]
    MaxCombinedAtomicCounterBuffers = 37585,

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

    [NativeName("GL_MAX_ATOMIC_COUNTER_BUFFER_SIZE")]
    MaxAtomicCounterBufferSize = 37592,

    [NativeName("GL_MAX_ATOMIC_COUNTER_BUFFER_BINDINGS")]
    MaxAtomicCounterBufferBindings = 37596,

    [NativeName("GL_ACTIVE_ATOMIC_COUNTER_BUFFERS")]
    ActiveAtomicCounterBuffers = 37593,

    [NativeName("GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX")]
    UniformAtomicCounterBufferIndex = 37594,

    [NativeName("GL_UNSIGNED_INT_ATOMIC_COUNTER")]
    UnsignedIntAtomicCounter = 37595,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT")]
    VertexAttribArrayBarrierBit = 1,

    [NativeName("GL_ELEMENT_ARRAY_BARRIER_BIT")]
    ElementArrayBarrierBit = 2,

    [NativeName("GL_UNIFORM_BARRIER_BIT")]
    UniformBarrierBit = 4,

    [NativeName("GL_TEXTURE_FETCH_BARRIER_BIT")]
    TextureFetchBarrierBit = 8,

    [NativeName("GL_SHADER_IMAGE_ACCESS_BARRIER_BIT")]
    ShaderImageAccessBarrierBit = 32,

    [NativeName("GL_COMMAND_BARRIER_BIT")]
    CommandBarrierBit = 64,

    [NativeName("GL_PIXEL_BUFFER_BARRIER_BIT")]
    PixelBufferBarrierBit = 128,

    [NativeName("GL_TEXTURE_UPDATE_BARRIER_BIT")]
    TextureUpdateBarrierBit = 256,

    [NativeName("GL_BUFFER_UPDATE_BARRIER_BIT")]
    BufferUpdateBarrierBit = 512,

    [NativeName("GL_FRAMEBUFFER_BARRIER_BIT")]
    FramebufferBarrierBit = 1024,

    [NativeName("GL_TRANSFORM_FEEDBACK_BARRIER_BIT")]
    TransformFeedbackBarrierBit = 2048,

    [NativeName("GL_ATOMIC_COUNTER_BARRIER_BIT")]
    AtomicCounterBarrierBit = 4096,

    [NativeName("GL_ALL_BARRIER_BITS")]
    AllBarrierBits = 4294967295,

    [NativeName("GL_MAX_IMAGE_UNITS")]
    MaxImageUnits = 36664,

    [NativeName("GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS")]
    MaxCombinedImageUnitsAndFragmentOutputs = 36665,

    [NativeName("GL_IMAGE_BINDING_NAME")]
    ImageBindingName = 36666,

    [NativeName("GL_IMAGE_BINDING_LEVEL")]
    ImageBindingLevel = 36667,

    [NativeName("GL_IMAGE_BINDING_LAYERED")]
    ImageBindingLayered = 36668,

    [NativeName("GL_IMAGE_BINDING_LAYER")]
    ImageBindingLayer = 36669,

    [NativeName("GL_IMAGE_BINDING_ACCESS")]
    ImageBindingAccess = 36670,

    [NativeName("GL_IMAGE_1D")]
    Image1D = 36940,

    [NativeName("GL_IMAGE_2D")]
    Image2D = 36941,

    [NativeName("GL_IMAGE_3D")]
    Image3D = 36942,

    [NativeName("GL_IMAGE_2D_RECT")]
    Image2DRect = 36943,

    [NativeName("GL_IMAGE_CUBE")]
    ImageCube = 36944,

    [NativeName("GL_IMAGE_BUFFER")]
    ImageBuffer = 36945,

    [NativeName("GL_IMAGE_1D_ARRAY")]
    Image1DArray = 36946,

    [NativeName("GL_IMAGE_2D_ARRAY")]
    Image2DArray = 36947,

    [NativeName("GL_IMAGE_CUBE_MAP_ARRAY")]
    ImageCubeMapArray = 36948,

    [NativeName("GL_IMAGE_2D_MULTISAMPLE")]
    Image2DMultisample = 36949,

    [NativeName("GL_IMAGE_2D_MULTISAMPLE_ARRAY")]
    Image2DMultisampleArray = 36950,

    [NativeName("GL_INT_IMAGE_1D")]
    IntImage1D = 36951,

    [NativeName("GL_INT_IMAGE_2D")]
    IntImage2D = 36952,

    [NativeName("GL_INT_IMAGE_3D")]
    IntImage3D = 36953,

    [NativeName("GL_INT_IMAGE_2D_RECT")]
    IntImage2DRect = 36954,

    [NativeName("GL_INT_IMAGE_CUBE")]
    IntImageCube = 36955,

    [NativeName("GL_INT_IMAGE_BUFFER")]
    IntImageBuffer = 36956,

    [NativeName("GL_INT_IMAGE_1D_ARRAY")]
    IntImage1DArray = 36957,

    [NativeName("GL_INT_IMAGE_2D_ARRAY")]
    IntImage2DArray = 36958,

    [NativeName("GL_INT_IMAGE_CUBE_MAP_ARRAY")]
    IntImageCubeMapArray = 36959,

    [NativeName("GL_INT_IMAGE_2D_MULTISAMPLE")]
    IntImage2DMultisample = 36960,

    [NativeName("GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY")]
    IntImage2DMultisampleArray = 36961,

    [NativeName("GL_UNSIGNED_INT_IMAGE_1D")]
    UnsignedIntImage1D = 36962,

    [NativeName("GL_UNSIGNED_INT_IMAGE_2D")]
    UnsignedIntImage2D = 36963,

    [NativeName("GL_UNSIGNED_INT_IMAGE_3D")]
    UnsignedIntImage3D = 36964,

    [NativeName("GL_UNSIGNED_INT_IMAGE_2D_RECT")]
    UnsignedIntImage2DRect = 36965,

    [NativeName("GL_UNSIGNED_INT_IMAGE_CUBE")]
    UnsignedIntImageCube = 36966,

    [NativeName("GL_UNSIGNED_INT_IMAGE_BUFFER")]
    UnsignedIntImageBuffer = 36967,

    [NativeName("GL_UNSIGNED_INT_IMAGE_1D_ARRAY")]
    UnsignedIntImage1DArray = 36968,

    [NativeName("GL_UNSIGNED_INT_IMAGE_2D_ARRAY")]
    UnsignedIntImage2DArray = 36969,

    [NativeName("GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY")]
    UnsignedIntImageCubeMapArray = 36970,

    [NativeName("GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE")]
    UnsignedIntImage2DMultisample = 36971,

    [NativeName("GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY")]
    UnsignedIntImage2DMultisampleArray = 36972,

    [NativeName("GL_MAX_IMAGE_SAMPLES")]
    MaxImageSamples = 36973,

    [NativeName("GL_IMAGE_BINDING_FORMAT")]
    ImageBindingFormat = 36974,

    [NativeName("GL_IMAGE_FORMAT_COMPATIBILITY_TYPE")]
    ImageFormatCompatibilityType = 37063,

    [NativeName("GL_IMAGE_FORMAT_COMPATIBILITY_BY_SIZE")]
    ImageFormatCompatibilityBySize = 37064,

    [NativeName("GL_IMAGE_FORMAT_COMPATIBILITY_BY_CLASS")]
    ImageFormatCompatibilityByClass = 37065,

    [NativeName("GL_MAX_VERTEX_IMAGE_UNIFORMS")]
    MaxVertexImageUniforms = 37066,

    [NativeName("GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS")]
    MaxTessControlImageUniforms = 37067,

    [NativeName("GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS")]
    MaxTessEvaluationImageUniforms = 37068,

    [NativeName("GL_MAX_GEOMETRY_IMAGE_UNIFORMS")]
    MaxGeometryImageUniforms = 37069,

    [NativeName("GL_MAX_FRAGMENT_IMAGE_UNIFORMS")]
    MaxFragmentImageUniforms = 37070,

    [NativeName("GL_MAX_COMBINED_IMAGE_UNIFORMS")]
    MaxCombinedImageUniforms = 37071,

    [NativeName("GL_COMPRESSED_RGBA_BPTC_UNORM")]
    CompressedRgbaBptcUnorm = 36492,

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM")]
    CompressedSrgbAlphaBptcUnorm = 36493,

    [NativeName("GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT")]
    CompressedRgbBptcSignedFloat = 36494,

    [NativeName("GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT")]
    CompressedRgbBptcUnsignedFloat = 36495,

    [NativeName("GL_TEXTURE_IMMUTABLE_FORMAT")]
    TextureImmutableFormat = 37167,

    [NativeName("GL_NUM_SHADING_LANGUAGE_VERSIONS")]
    NumShadingLanguageVersions = 33513,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_LONG")]
    VertexAttribArrayLong = 34638,

    [NativeName("GL_COMPRESSED_RGB8_ETC2")]
    CompressedRgb8Etc2 = 37492,

    [NativeName("GL_COMPRESSED_SRGB8_ETC2")]
    CompressedSrgb8Etc2 = 37493,

    [NativeName("GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2")]
    CompressedRgb8PunchthroughAlpha1Etc2 = 37494,

    [NativeName("GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2")]
    CompressedSrgb8PunchthroughAlpha1Etc2 = 37495,

    [NativeName("GL_COMPRESSED_RGBA8_ETC2_EAC")]
    CompressedRgba8Etc2Eac = 37496,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC")]
    CompressedSrgb8Alpha8Etc2Eac = 37497,

    [NativeName("GL_COMPRESSED_R11_EAC")]
    CompressedR11Eac = 37488,

    [NativeName("GL_COMPRESSED_SIGNED_R11_EAC")]
    CompressedSignedR11Eac = 37489,

    [NativeName("GL_COMPRESSED_RG11_EAC")]
    CompressedRg11Eac = 37490,

    [NativeName("GL_COMPRESSED_SIGNED_RG11_EAC")]
    CompressedSignedRg11Eac = 37491,

    [NativeName("GL_PRIMITIVE_RESTART_FIXED_INDEX")]
    PrimitiveRestartFixedIndex = 36201,

    [NativeName("GL_ANY_SAMPLES_PASSED_CONSERVATIVE")]
    AnySamplesPassedConservative = 36202,

    [NativeName("GL_MAX_ELEMENT_INDEX")]
    MaxElementIndex = 36203,

    [NativeName("GL_COMPUTE_SHADER")]
    ComputeShader = 37305,

    [NativeName("GL_MAX_COMPUTE_UNIFORM_BLOCKS")]
    MaxComputeUniformBlocks = 37307,

    [NativeName("GL_MAX_COMPUTE_TEXTURE_IMAGE_UNITS")]
    MaxComputeTextureImageUnits = 37308,

    [NativeName("GL_MAX_COMPUTE_IMAGE_UNIFORMS")]
    MaxComputeImageUniforms = 37309,

    [NativeName("GL_MAX_COMPUTE_SHARED_MEMORY_SIZE")]
    MaxComputeSharedMemorySize = 33378,

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

    [NativeName("GL_COMPUTE_WORK_GROUP_SIZE")]
    ComputeWorkGroupSize = 33383,

    [NativeName("GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER")]
    UniformBlockReferencedByComputeShader = 37100,

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER")]
    AtomicCounterBufferReferencedByComputeShader = 37101,

    [NativeName("GL_DISPATCH_INDIRECT_BUFFER")]
    DispatchIndirectBuffer = 37102,

    [NativeName("GL_DISPATCH_INDIRECT_BUFFER_BINDING")]
    DispatchIndirectBufferBinding = 37103,

    [NativeName("GL_COMPUTE_SHADER_BIT")]
    ComputeShaderBit = 32,

    [NativeName("GL_DEBUG_OUTPUT_SYNCHRONOUS")]
    DebugOutputSynchronous = 33346,

    [NativeName("GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH")]
    DebugNextLoggedMessageLength = 33347,

    [NativeName("GL_DEBUG_CALLBACK_FUNCTION")]
    DebugCallbackFunction = 33348,

    [NativeName("GL_DEBUG_CALLBACK_USER_PARAM")]
    DebugCallbackUserParam = 33349,

    [NativeName("GL_DEBUG_SOURCE_API")]
    DebugSourceApi = 33350,

    [NativeName("GL_DEBUG_SOURCE_WINDOW_SYSTEM")]
    DebugSourceWindowSystem = 33351,

    [NativeName("GL_DEBUG_SOURCE_SHADER_COMPILER")]
    DebugSourceShaderCompiler = 33352,

    [NativeName("GL_DEBUG_SOURCE_THIRD_PARTY")]
    DebugSourceThirdParty = 33353,

    [NativeName("GL_DEBUG_SOURCE_APPLICATION")]
    DebugSourceApplication = 33354,

    [NativeName("GL_DEBUG_SOURCE_OTHER")]
    DebugSourceOther = 33355,

    [NativeName("GL_DEBUG_TYPE_ERROR")]
    DebugTypeError = 33356,

    [NativeName("GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR")]
    DebugTypeDeprecatedBehavior = 33357,

    [NativeName("GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR")]
    DebugTypeUndefinedBehavior = 33358,

    [NativeName("GL_DEBUG_TYPE_PORTABILITY")]
    DebugTypePortability = 33359,

    [NativeName("GL_DEBUG_TYPE_PERFORMANCE")]
    DebugTypePerformance = 33360,

    [NativeName("GL_DEBUG_TYPE_OTHER")]
    DebugTypeOther = 33361,

    [NativeName("GL_MAX_DEBUG_MESSAGE_LENGTH")]
    MaxDebugMessageLength = 37187,

    [NativeName("GL_MAX_DEBUG_LOGGED_MESSAGES")]
    MaxDebugLoggedMessages = 37188,

    [NativeName("GL_DEBUG_LOGGED_MESSAGES")]
    DebugLoggedMessages = 37189,

    [NativeName("GL_DEBUG_SEVERITY_HIGH")]
    DebugSeverityHigh = 37190,

    [NativeName("GL_DEBUG_SEVERITY_MEDIUM")]
    DebugSeverityMedium = 37191,

    [NativeName("GL_DEBUG_SEVERITY_LOW")]
    DebugSeverityLow = 37192,

    [NativeName("GL_DEBUG_TYPE_MARKER")]
    DebugTypeMarker = 33384,

    [NativeName("GL_DEBUG_TYPE_PUSH_GROUP")]
    DebugTypePushGroup = 33385,

    [NativeName("GL_DEBUG_TYPE_POP_GROUP")]
    DebugTypePopGroup = 33386,

    [NativeName("GL_DEBUG_SEVERITY_NOTIFICATION")]
    DebugSeverityNotification = 33387,

    [NativeName("GL_MAX_DEBUG_GROUP_STACK_DEPTH")]
    MaxDebugGroupStackDepth = 33388,

    [NativeName("GL_DEBUG_GROUP_STACK_DEPTH")]
    DebugGroupStackDepth = 33389,

    [NativeName("GL_BUFFER")]
    Buffer = 33504,

    [NativeName("GL_SHADER")]
    Shader = 33505,

    [NativeName("GL_PROGRAM")]
    Program = 33506,

    [NativeName("GL_QUERY")]
    Query = 33507,

    [NativeName("GL_PROGRAM_PIPELINE")]
    ProgramPipeline = 33508,

    [NativeName("GL_SAMPLER")]
    Sampler = 33510,

    [NativeName("GL_MAX_LABEL_LENGTH")]
    MaxLabelLength = 33512,

    [NativeName("GL_DEBUG_OUTPUT")]
    DebugOutput = 37600,

    [NativeName("GL_CONTEXT_FLAG_DEBUG_BIT")]
    ContextFlagDebugBit = 2,

    [NativeName("GL_MAX_UNIFORM_LOCATIONS")]
    MaxUniformLocations = 33390,

    [NativeName("GL_FRAMEBUFFER_DEFAULT_WIDTH")]
    FramebufferDefaultWidth = 37648,

    [NativeName("GL_FRAMEBUFFER_DEFAULT_HEIGHT")]
    FramebufferDefaultHeight = 37649,

    [NativeName("GL_FRAMEBUFFER_DEFAULT_LAYERS")]
    FramebufferDefaultLayers = 37650,

    [NativeName("GL_FRAMEBUFFER_DEFAULT_SAMPLES")]
    FramebufferDefaultSamples = 37651,

    [NativeName("GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS")]
    FramebufferDefaultFixedSampleLocations = 37652,

    [NativeName("GL_MAX_FRAMEBUFFER_WIDTH")]
    MaxFramebufferWidth = 37653,

    [NativeName("GL_MAX_FRAMEBUFFER_HEIGHT")]
    MaxFramebufferHeight = 37654,

    [NativeName("GL_MAX_FRAMEBUFFER_LAYERS")]
    MaxFramebufferLayers = 37655,

    [NativeName("GL_MAX_FRAMEBUFFER_SAMPLES")]
    MaxFramebufferSamples = 37656,

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

    [NativeName("GL_MAX_COMBINED_DIMENSIONS")]
    MaxCombinedDimensions = 33410,

    [NativeName("GL_COLOR_COMPONENTS")]
    ColorComponents = 33411,

    [NativeName("GL_DEPTH_COMPONENTS")]
    DepthComponents = 33412,

    [NativeName("GL_STENCIL_COMPONENTS")]
    StencilComponents = 33413,

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

    [NativeName("GL_MANUAL_GENERATE_MIPMAP")]
    ManualGenerateMipmap = 33428,

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

    [NativeName("GL_FULL_SUPPORT")]
    FullSupport = 33463,

    [NativeName("GL_CAVEAT_SUPPORT")]
    CaveatSupport = 33464,

    [NativeName("GL_IMAGE_CLASS_4_X_32")]
    ImageClass4X32 = 33465,

    [NativeName("GL_IMAGE_CLASS_2_X_32")]
    ImageClass2X32 = 33466,

    [NativeName("GL_IMAGE_CLASS_1_X_32")]
    ImageClass1X32 = 33467,

    [NativeName("GL_IMAGE_CLASS_4_X_16")]
    ImageClass4X16 = 33468,

    [NativeName("GL_IMAGE_CLASS_2_X_16")]
    ImageClass2X16 = 33469,

    [NativeName("GL_IMAGE_CLASS_1_X_16")]
    ImageClass1X16 = 33470,

    [NativeName("GL_IMAGE_CLASS_4_X_8")]
    ImageClass4X8 = 33471,

    [NativeName("GL_IMAGE_CLASS_2_X_8")]
    ImageClass2X8 = 33472,

    [NativeName("GL_IMAGE_CLASS_1_X_8")]
    ImageClass1X8 = 33473,

    [NativeName("GL_IMAGE_CLASS_11_11_10")]
    ImageClass11X11X10 = 33474,

    [NativeName("GL_IMAGE_CLASS_10_10_10_2")]
    ImageClass10X10X10X2 = 33475,

    [NativeName("GL_VIEW_CLASS_128_BITS")]
    ViewClass128Bits = 33476,

    [NativeName("GL_VIEW_CLASS_96_BITS")]
    ViewClass96Bits = 33477,

    [NativeName("GL_VIEW_CLASS_64_BITS")]
    ViewClass64Bits = 33478,

    [NativeName("GL_VIEW_CLASS_48_BITS")]
    ViewClass48Bits = 33479,

    [NativeName("GL_VIEW_CLASS_32_BITS")]
    ViewClass32Bits = 33480,

    [NativeName("GL_VIEW_CLASS_24_BITS")]
    ViewClass24Bits = 33481,

    [NativeName("GL_VIEW_CLASS_16_BITS")]
    ViewClass16Bits = 33482,

    [NativeName("GL_VIEW_CLASS_8_BITS")]
    ViewClass8Bits = 33483,

    [NativeName("GL_VIEW_CLASS_S3TC_DXT1_RGB")]
    ViewClassS3TcDxt1Rgb = 33484,

    [NativeName("GL_VIEW_CLASS_S3TC_DXT1_RGBA")]
    ViewClassS3TcDxt1Rgba = 33485,

    [NativeName("GL_VIEW_CLASS_S3TC_DXT3_RGBA")]
    ViewClassS3TcDxt3Rgba = 33486,

    [NativeName("GL_VIEW_CLASS_S3TC_DXT5_RGBA")]
    ViewClassS3TcDxt5Rgba = 33487,

    [NativeName("GL_VIEW_CLASS_RGTC1_RED")]
    ViewClassRgtc1Red = 33488,

    [NativeName("GL_VIEW_CLASS_RGTC2_RG")]
    ViewClassRgtc2Rg = 33489,

    [NativeName("GL_VIEW_CLASS_BPTC_UNORM")]
    ViewClassBptcUnorm = 33490,

    [NativeName("GL_VIEW_CLASS_BPTC_FLOAT")]
    ViewClassBptcFloat = 33491,

    [NativeName("GL_UNIFORM")]
    Uniform = 37601,

    [NativeName("GL_UNIFORM_BLOCK")]
    UniformBlock = 37602,

    [NativeName("GL_PROGRAM_INPUT")]
    ProgramInput = 37603,

    [NativeName("GL_PROGRAM_OUTPUT")]
    ProgramOutput = 37604,

    [NativeName("GL_BUFFER_VARIABLE")]
    BufferVariable = 37605,

    [NativeName("GL_SHADER_STORAGE_BLOCK")]
    ShaderStorageBlock = 37606,

    [NativeName("GL_VERTEX_SUBROUTINE")]
    VertexSubroutine = 37608,

    [NativeName("GL_TESS_CONTROL_SUBROUTINE")]
    TessControlSubroutine = 37609,

    [NativeName("GL_TESS_EVALUATION_SUBROUTINE")]
    TessEvaluationSubroutine = 37610,

    [NativeName("GL_GEOMETRY_SUBROUTINE")]
    GeometrySubroutine = 37611,

    [NativeName("GL_FRAGMENT_SUBROUTINE")]
    FragmentSubroutine = 37612,

    [NativeName("GL_COMPUTE_SUBROUTINE")]
    ComputeSubroutine = 37613,

    [NativeName("GL_VERTEX_SUBROUTINE_UNIFORM")]
    VertexSubroutineUniform = 37614,

    [NativeName("GL_TESS_CONTROL_SUBROUTINE_UNIFORM")]
    TessControlSubroutineUniform = 37615,

    [NativeName("GL_TESS_EVALUATION_SUBROUTINE_UNIFORM")]
    TessEvaluationSubroutineUniform = 37616,

    [NativeName("GL_GEOMETRY_SUBROUTINE_UNIFORM")]
    GeometrySubroutineUniform = 37617,

    [NativeName("GL_FRAGMENT_SUBROUTINE_UNIFORM")]
    FragmentSubroutineUniform = 37618,

    [NativeName("GL_COMPUTE_SUBROUTINE_UNIFORM")]
    ComputeSubroutineUniform = 37619,

    [NativeName("GL_TRANSFORM_FEEDBACK_VARYING")]
    TransformFeedbackVarying = 37620,

    [NativeName("GL_ACTIVE_RESOURCES")]
    ActiveResources = 37621,

    [NativeName("GL_MAX_NAME_LENGTH")]
    MaxNameLength = 37622,

    [NativeName("GL_MAX_NUM_ACTIVE_VARIABLES")]
    MaxNumActiveVariables = 37623,

    [NativeName("GL_MAX_NUM_COMPATIBLE_SUBROUTINES")]
    MaxNumCompatibleSubroutines = 37624,

    [NativeName("GL_NAME_LENGTH")]
    NameLength = 37625,

    [NativeName("GL_TYPE")]
    Type = 37626,

    [NativeName("GL_ARRAY_SIZE")]
    ArraySize = 37627,

    [NativeName("GL_OFFSET")]
    Offset = 37628,

    [NativeName("GL_BLOCK_INDEX")]
    BlockIndex = 37629,

    [NativeName("GL_ARRAY_STRIDE")]
    ArrayStride = 37630,

    [NativeName("GL_MATRIX_STRIDE")]
    MatrixStride = 37631,

    [NativeName("GL_IS_ROW_MAJOR")]
    IsRowMajor = 37632,

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_INDEX")]
    AtomicCounterBufferIndex = 37633,

    [NativeName("GL_BUFFER_BINDING")]
    BufferBinding = 37634,

    [NativeName("GL_BUFFER_DATA_SIZE")]
    BufferDataSize = 37635,

    [NativeName("GL_NUM_ACTIVE_VARIABLES")]
    NumActiveVariables = 37636,

    [NativeName("GL_ACTIVE_VARIABLES")]
    ActiveVariables = 37637,

    [NativeName("GL_REFERENCED_BY_VERTEX_SHADER")]
    ReferencedByVertexShader = 37638,

    [NativeName("GL_REFERENCED_BY_TESS_CONTROL_SHADER")]
    ReferencedByTessControlShader = 37639,

    [NativeName("GL_REFERENCED_BY_TESS_EVALUATION_SHADER")]
    ReferencedByTessEvaluationShader = 37640,

    [NativeName("GL_REFERENCED_BY_GEOMETRY_SHADER")]
    ReferencedByGeometryShader = 37641,

    [NativeName("GL_REFERENCED_BY_FRAGMENT_SHADER")]
    ReferencedByFragmentShader = 37642,

    [NativeName("GL_REFERENCED_BY_COMPUTE_SHADER")]
    ReferencedByComputeShader = 37643,

    [NativeName("GL_TOP_LEVEL_ARRAY_SIZE")]
    TopLevelArraySize = 37644,

    [NativeName("GL_TOP_LEVEL_ARRAY_STRIDE")]
    TopLevelArrayStride = 37645,

    [NativeName("GL_LOCATION")]
    Location = 37646,

    [NativeName("GL_LOCATION_INDEX")]
    LocationIndex = 37647,

    [NativeName("GL_IS_PER_PATCH")]
    IsPerPatch = 37607,

    [NativeName("GL_SHADER_STORAGE_BUFFER")]
    ShaderStorageBuffer = 37074,

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

    [NativeName("GL_MAX_SHADER_STORAGE_BLOCK_SIZE")]
    MaxShaderStorageBlockSize = 37086,

    [NativeName("GL_SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT")]
    ShaderStorageBufferOffsetAlignment = 37087,

    [NativeName("GL_SHADER_STORAGE_BARRIER_BIT")]
    ShaderStorageBarrierBit = 8192,

    [NativeName("GL_MAX_COMBINED_SHADER_OUTPUT_RESOURCES")]
    MaxCombinedShaderOutputResources = 36665,

    [NativeName("GL_DEPTH_STENCIL_TEXTURE_MODE")]
    DepthStencilTextureMode = 37098,

    [NativeName("GL_TEXTURE_BUFFER_OFFSET")]
    TextureBufferOffset = 37277,

    [NativeName("GL_TEXTURE_BUFFER_SIZE")]
    TextureBufferSize = 37278,

    [NativeName("GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT")]
    TextureBufferOffsetAlignment = 37279,

    [NativeName("GL_TEXTURE_VIEW_MIN_LEVEL")]
    TextureViewMinLevel = 33499,

    [NativeName("GL_TEXTURE_VIEW_NUM_LEVELS")]
    TextureViewNumLevels = 33500,

    [NativeName("GL_TEXTURE_VIEW_MIN_LAYER")]
    TextureViewMinLayer = 33501,

    [NativeName("GL_TEXTURE_VIEW_NUM_LAYERS")]
    TextureViewNumLayers = 33502,

    [NativeName("GL_TEXTURE_IMMUTABLE_LEVELS")]
    TextureImmutableLevels = 33503,

    [NativeName("GL_VERTEX_ATTRIB_BINDING")]
    VertexAttribBinding = 33492,

    [NativeName("GL_VERTEX_ATTRIB_RELATIVE_OFFSET")]
    VertexAttribRelativeOffset = 33493,

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

    [NativeName("GL_VERTEX_BINDING_BUFFER")]
    VertexBindingBuffer = 36687,

    [NativeName("GL_DISPLAY_LIST")]
    DisplayList = 33511,

    [NativeName("GL_MAX_VERTEX_ATTRIB_STRIDE")]
    MaxVertexAttribStride = 33509,

    [NativeName("GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED")]
    PrimitiveRestartForPatchesSupported = 33313,

    [NativeName("GL_TEXTURE_BUFFER_BINDING")]
    TextureBufferBinding = 35882,

    [NativeName("GL_MAP_PERSISTENT_BIT")]
    MapPersistentBit = 64,

    [NativeName("GL_MAP_COHERENT_BIT")]
    MapCoherentBit = 128,

    [NativeName("GL_DYNAMIC_STORAGE_BIT")]
    DynamicStorageBit = 256,

    [NativeName("GL_CLIENT_STORAGE_BIT")]
    ClientStorageBit = 512,

    [NativeName("GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT")]
    ClientMappedBufferBarrierBit = 16384,

    [NativeName("GL_BUFFER_IMMUTABLE_STORAGE")]
    BufferImmutableStorage = 33311,

    [NativeName("GL_BUFFER_STORAGE_FLAGS")]
    BufferStorageFlags = 33312,

    [NativeName("GL_CLEAR_TEXTURE")]
    ClearTexture = 37733,

    [NativeName("GL_LOCATION_COMPONENT")]
    LocationComponent = 37706,

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_INDEX")]
    TransformFeedbackBufferIndex = 37707,

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_STRIDE")]
    TransformFeedbackBufferStride = 37708,

    [NativeName("GL_QUERY_BUFFER")]
    QueryBuffer = 37266,

    [NativeName("GL_QUERY_BUFFER_BARRIER_BIT")]
    QueryBufferBarrierBit = 32768,

    [NativeName("GL_QUERY_BUFFER_BINDING")]
    QueryBufferBinding = 37267,

    [NativeName("GL_QUERY_RESULT_NO_WAIT")]
    QueryResultNoWait = 37268,

    [NativeName("GL_MIRROR_CLAMP_TO_EDGE")]
    MirrorClampToEdge = 34627,

    [NativeName("GL_CONTEXT_LOST")]
    ContextLost = 1287,

    [NativeName("GL_NEGATIVE_ONE_TO_ONE")]
    NegativeOneToOne = 37726,

    [NativeName("GL_ZERO_TO_ONE")]
    ZeroToOne = 37727,

    [NativeName("GL_CLIP_ORIGIN")]
    ClipOrigin = 37724,

    [NativeName("GL_CLIP_DEPTH_MODE")]
    ClipDepthMode = 37725,

    [NativeName("GL_QUERY_WAIT_INVERTED")]
    QueryWaitInverted = 36375,

    [NativeName("GL_QUERY_NO_WAIT_INVERTED")]
    QueryNoWaitInverted = 36376,

    [NativeName("GL_QUERY_BY_REGION_WAIT_INVERTED")]
    QueryByRegionWaitInverted = 36377,

    [NativeName("GL_QUERY_BY_REGION_NO_WAIT_INVERTED")]
    QueryByRegionNoWaitInverted = 36378,

    [NativeName("GL_MAX_CULL_DISTANCES")]
    MaxCullDistances = 33529,

    [NativeName("GL_MAX_COMBINED_CLIP_AND_CULL_DISTANCES")]
    MaxCombinedClipAndCullDistances = 33530,

    [NativeName("GL_TEXTURE_TARGET")]
    TextureTarget = 4102,

    [NativeName("GL_QUERY_TARGET")]
    QueryTarget = 33514,

    [NativeName("GL_GUILTY_CONTEXT_RESET")]
    GuiltyContextReset = 33363,

    [NativeName("GL_INNOCENT_CONTEXT_RESET")]
    InnocentContextReset = 33364,

    [NativeName("GL_UNKNOWN_CONTEXT_RESET")]
    UnknownContextReset = 33365,

    [NativeName("GL_RESET_NOTIFICATION_STRATEGY")]
    ResetNotificationStrategy = 33366,

    [NativeName("GL_LOSE_CONTEXT_ON_RESET")]
    LoseContextOnReset = 33362,

    [NativeName("GL_NO_RESET_NOTIFICATION")]
    NoResetNotification = 33377,

    [NativeName("GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT")]
    ContextFlagRobustAccessBit = 4,

    [NativeName("GL_COLOR_TABLE")]
    ColorTable = 32976,

    [NativeName("GL_POST_CONVOLUTION_COLOR_TABLE")]
    PostConvolutionColorTable = 32977,

    [NativeName("GL_POST_COLOR_MATRIX_COLOR_TABLE")]
    PostColorMatrixColorTable = 32978,

    [NativeName("GL_PROXY_COLOR_TABLE")]
    ProxyColorTable = 32979,

    [NativeName("GL_PROXY_POST_CONVOLUTION_COLOR_TABLE")]
    ProxyPostConvolutionColorTable = 32980,

    [NativeName("GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE")]
    ProxyPostColorMatrixColorTable = 32981,

    [NativeName("GL_CONVOLUTION_1D")]
    Convolution1D = 32784,

    [NativeName("GL_CONVOLUTION_2D")]
    Convolution2D = 32785,

    [NativeName("GL_SEPARABLE_2D")]
    Separable2D = 32786,

    [NativeName("GL_HISTOGRAM")]
    Histogram = 32804,

    [NativeName("GL_PROXY_HISTOGRAM")]
    ProxyHistogram = 32805,

    [NativeName("GL_MINMAX")]
    Minmax = 32814,

    [NativeName("GL_CONTEXT_RELEASE_BEHAVIOR")]
    ContextReleaseBehavior = 33531,

    [NativeName("GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH")]
    ContextReleaseBehaviorFlush = 33532,

    [NativeName("GL_SHADER_BINARY_FORMAT_SPIR_V")]
    ShaderBinaryFormatSpirV = 38225,

    [NativeName("GL_SPIR_V_BINARY")]
    SpirVBinary = 38226,

    [NativeName("GL_PARAMETER_BUFFER")]
    ParameterBuffer = 33006,

    [NativeName("GL_PARAMETER_BUFFER_BINDING")]
    ParameterBufferBinding = 33007,

    [NativeName("GL_CONTEXT_FLAG_NO_ERROR_BIT")]
    ContextFlagNoErrorBit = 8,

    [NativeName("GL_VERTICES_SUBMITTED")]
    VerticesSubmitted = 33518,

    [NativeName("GL_PRIMITIVES_SUBMITTED")]
    PrimitivesSubmitted = 33519,

    [NativeName("GL_VERTEX_SHADER_INVOCATIONS")]
    VertexShaderInvocations = 33520,

    [NativeName("GL_TESS_CONTROL_SHADER_PATCHES")]
    TessControlShaderPatches = 33521,

    [NativeName("GL_TESS_EVALUATION_SHADER_INVOCATIONS")]
    TessEvaluationShaderInvocations = 33522,

    [NativeName("GL_GEOMETRY_SHADER_PRIMITIVES_EMITTED")]
    GeometryShaderPrimitivesEmitted = 33523,

    [NativeName("GL_FRAGMENT_SHADER_INVOCATIONS")]
    FragmentShaderInvocations = 33524,

    [NativeName("GL_COMPUTE_SHADER_INVOCATIONS")]
    ComputeShaderInvocations = 33525,

    [NativeName("GL_CLIPPING_INPUT_PRIMITIVES")]
    ClippingInputPrimitives = 33526,

    [NativeName("GL_CLIPPING_OUTPUT_PRIMITIVES")]
    ClippingOutputPrimitives = 33527,

    [NativeName("GL_POLYGON_OFFSET_CLAMP")]
    PolygonOffsetClamp = 36379,

    [NativeName("GL_SPIR_V_EXTENSIONS")]
    SpirVExtensions = 38227,

    [NativeName("GL_NUM_SPIR_V_EXTENSIONS")]
    NumSpirVExtensions = 38228,

    [NativeName("GL_TEXTURE_MAX_ANISOTROPY")]
    TextureMaxAnisotropy = 34046,

    [NativeName("GL_MAX_TEXTURE_MAX_ANISOTROPY")]
    MaxTextureMaxAnisotropy = 34047,

    [NativeName("GL_TRANSFORM_FEEDBACK_OVERFLOW")]
    TransformFeedbackOverflow = 33516,

    [NativeName("GL_TRANSFORM_FEEDBACK_STREAM_OVERFLOW")]
    TransformFeedbackStreamOverflow = 33517,

    [NativeName("GL_PRIMITIVE_BOUNDING_BOX_ARB")]
    PrimitiveBoundingBoxARB = 37566,

    [NativeName("GL_MULTISAMPLE_LINE_WIDTH_RANGE_ARB")]
    MultisampleLineWidthRangeARB = 37761,

    [NativeName("GL_MULTISAMPLE_LINE_WIDTH_GRANULARITY_ARB")]
    MultisampleLineWidthGranularityARB = 37762,

    [NativeName("GL_UNSIGNED_INT64_ARB")]
    UnsignedInt64ARB = 5135,

    [NativeName("GL_SYNC_CL_EVENT_ARB")]
    SyncClEventARB = 33344,

    [NativeName("GL_SYNC_CL_EVENT_COMPLETE_ARB")]
    SyncClEventCompleteARB = 33345,

    [NativeName("GL_RGBA_FLOAT_MODE_ARB")]
    RgbaFloatModeARB = 34848,

    [NativeName("GL_CLAMP_VERTEX_COLOR_ARB")]
    ClampVertexColorARB = 35098,

    [NativeName("GL_CLAMP_FRAGMENT_COLOR_ARB")]
    ClampFragmentColorARB = 35099,

    [NativeName("GL_CLAMP_READ_COLOR_ARB")]
    ClampReadColorARB = 35100,

    [NativeName("GL_FIXED_ONLY_ARB")]
    FixedOnlyARB = 35101,

    [NativeName("GL_MAX_COMPUTE_VARIABLE_GROUP_INVOCATIONS_ARB")]
    MaxComputeVariableGroupInvocationsARB = 37700,

    [NativeName("GL_MAX_COMPUTE_FIXED_GROUP_INVOCATIONS_ARB")]
    MaxComputeFixedGroupInvocationsARB = 37099,

    [NativeName("GL_MAX_COMPUTE_VARIABLE_GROUP_SIZE_ARB")]
    MaxComputeVariableGroupSizeARB = 37701,

    [NativeName("GL_MAX_COMPUTE_FIXED_GROUP_SIZE_ARB")]
    MaxComputeFixedGroupSizeARB = 37311,

    [NativeName("GL_DEBUG_OUTPUT_SYNCHRONOUS_ARB")]
    DebugOutputSynchronousARB = 33346,

    [NativeName("GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_ARB")]
    DebugNextLoggedMessageLengthARB = 33347,

    [NativeName("GL_DEBUG_CALLBACK_FUNCTION_ARB")]
    DebugCallbackFunctionARB = 33348,

    [NativeName("GL_DEBUG_CALLBACK_USER_PARAM_ARB")]
    DebugCallbackUserParamARB = 33349,

    [NativeName("GL_DEBUG_SOURCE_API_ARB")]
    DebugSourceApiARB = 33350,

    [NativeName("GL_DEBUG_SOURCE_WINDOW_SYSTEM_ARB")]
    DebugSourceWindowSystemARB = 33351,

    [NativeName("GL_DEBUG_SOURCE_SHADER_COMPILER_ARB")]
    DebugSourceShaderCompilerARB = 33352,

    [NativeName("GL_DEBUG_SOURCE_THIRD_PARTY_ARB")]
    DebugSourceThirdPartyARB = 33353,

    [NativeName("GL_DEBUG_SOURCE_APPLICATION_ARB")]
    DebugSourceApplicationARB = 33354,

    [NativeName("GL_DEBUG_SOURCE_OTHER_ARB")]
    DebugSourceOtherARB = 33355,

    [NativeName("GL_DEBUG_TYPE_ERROR_ARB")]
    DebugTypeErrorARB = 33356,

    [NativeName("GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_ARB")]
    DebugTypeDeprecatedBehaviorARB = 33357,

    [NativeName("GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_ARB")]
    DebugTypeUndefinedBehaviorARB = 33358,

    [NativeName("GL_DEBUG_TYPE_PORTABILITY_ARB")]
    DebugTypePortabilityARB = 33359,

    [NativeName("GL_DEBUG_TYPE_PERFORMANCE_ARB")]
    DebugTypePerformanceARB = 33360,

    [NativeName("GL_DEBUG_TYPE_OTHER_ARB")]
    DebugTypeOtherARB = 33361,

    [NativeName("GL_MAX_DEBUG_MESSAGE_LENGTH_ARB")]
    MaxDebugMessageLengthARB = 37187,

    [NativeName("GL_MAX_DEBUG_LOGGED_MESSAGES_ARB")]
    MaxDebugLoggedMessagesARB = 37188,

    [NativeName("GL_DEBUG_LOGGED_MESSAGES_ARB")]
    DebugLoggedMessagesARB = 37189,

    [NativeName("GL_DEBUG_SEVERITY_HIGH_ARB")]
    DebugSeverityHighARB = 37190,

    [NativeName("GL_DEBUG_SEVERITY_MEDIUM_ARB")]
    DebugSeverityMediumARB = 37191,

    [NativeName("GL_DEBUG_SEVERITY_LOW_ARB")]
    DebugSeverityLowARB = 37192,

    [NativeName("GL_DEPTH_COMPONENT16_ARB")]
    DepthComponent16ARB = 33189,

    [NativeName("GL_DEPTH_COMPONENT24_ARB")]
    DepthComponent24ARB = 33190,

    [NativeName("GL_DEPTH_COMPONENT32_ARB")]
    DepthComponent32ARB = 33191,

    [NativeName("GL_TEXTURE_DEPTH_SIZE_ARB")]
    TextureDepthSizeARB = 34890,

    [NativeName("GL_DEPTH_TEXTURE_MODE_ARB")]
    DepthTextureModeARB = 34891,

    [NativeName("GL_MAX_DRAW_BUFFERS_ARB")]
    MaxDrawBuffersARB = 34852,

    [NativeName("GL_DRAW_BUFFER0_ARB")]
    DrawBuffer0ARB = 34853,

    [NativeName("GL_DRAW_BUFFER1_ARB")]
    DrawBuffer1ARB = 34854,

    [NativeName("GL_DRAW_BUFFER2_ARB")]
    DrawBuffer2ARB = 34855,

    [NativeName("GL_DRAW_BUFFER3_ARB")]
    DrawBuffer3ARB = 34856,

    [NativeName("GL_DRAW_BUFFER4_ARB")]
    DrawBuffer4ARB = 34857,

    [NativeName("GL_DRAW_BUFFER5_ARB")]
    DrawBuffer5ARB = 34858,

    [NativeName("GL_DRAW_BUFFER6_ARB")]
    DrawBuffer6ARB = 34859,

    [NativeName("GL_DRAW_BUFFER7_ARB")]
    DrawBuffer7ARB = 34860,

    [NativeName("GL_DRAW_BUFFER8_ARB")]
    DrawBuffer8ARB = 34861,

    [NativeName("GL_DRAW_BUFFER9_ARB")]
    DrawBuffer9ARB = 34862,

    [NativeName("GL_DRAW_BUFFER10_ARB")]
    DrawBuffer10ARB = 34863,

    [NativeName("GL_DRAW_BUFFER11_ARB")]
    DrawBuffer11ARB = 34864,

    [NativeName("GL_DRAW_BUFFER12_ARB")]
    DrawBuffer12ARB = 34865,

    [NativeName("GL_DRAW_BUFFER13_ARB")]
    DrawBuffer13ARB = 34866,

    [NativeName("GL_DRAW_BUFFER14_ARB")]
    DrawBuffer14ARB = 34867,

    [NativeName("GL_DRAW_BUFFER15_ARB")]
    DrawBuffer15ARB = 34868,

    [NativeName("GL_FRAGMENT_PROGRAM_ARB")]
    FragmentProgramARB = 34820,

    [NativeName("GL_PROGRAM_FORMAT_ASCII_ARB")]
    ProgramFormatAsciiARB = 34933,

    [NativeName("GL_PROGRAM_LENGTH_ARB")]
    ProgramLengthARB = 34343,

    [NativeName("GL_PROGRAM_FORMAT_ARB")]
    ProgramFormatARB = 34934,

    [NativeName("GL_PROGRAM_BINDING_ARB")]
    ProgramBindingARB = 34423,

    [NativeName("GL_PROGRAM_INSTRUCTIONS_ARB")]
    ProgramInstructionsARB = 34976,

    [NativeName("GL_MAX_PROGRAM_INSTRUCTIONS_ARB")]
    MaxProgramInstructionsARB = 34977,

    [NativeName("GL_PROGRAM_NATIVE_INSTRUCTIONS_ARB")]
    ProgramNativeInstructionsARB = 34978,

    [NativeName("GL_MAX_PROGRAM_NATIVE_INSTRUCTIONS_ARB")]
    MaxProgramNativeInstructionsARB = 34979,

    [NativeName("GL_PROGRAM_TEMPORARIES_ARB")]
    ProgramTemporariesARB = 34980,

    [NativeName("GL_MAX_PROGRAM_TEMPORARIES_ARB")]
    MaxProgramTemporariesARB = 34981,

    [NativeName("GL_PROGRAM_NATIVE_TEMPORARIES_ARB")]
    ProgramNativeTemporariesARB = 34982,

    [NativeName("GL_MAX_PROGRAM_NATIVE_TEMPORARIES_ARB")]
    MaxProgramNativeTemporariesARB = 34983,

    [NativeName("GL_PROGRAM_PARAMETERS_ARB")]
    ProgramParametersARB = 34984,

    [NativeName("GL_MAX_PROGRAM_PARAMETERS_ARB")]
    MaxProgramParametersARB = 34985,

    [NativeName("GL_PROGRAM_NATIVE_PARAMETERS_ARB")]
    ProgramNativeParametersARB = 34986,

    [NativeName("GL_MAX_PROGRAM_NATIVE_PARAMETERS_ARB")]
    MaxProgramNativeParametersARB = 34987,

    [NativeName("GL_PROGRAM_ATTRIBS_ARB")]
    ProgramAttribsARB = 34988,

    [NativeName("GL_MAX_PROGRAM_ATTRIBS_ARB")]
    MaxProgramAttribsARB = 34989,

    [NativeName("GL_PROGRAM_NATIVE_ATTRIBS_ARB")]
    ProgramNativeAttribsARB = 34990,

    [NativeName("GL_MAX_PROGRAM_NATIVE_ATTRIBS_ARB")]
    MaxProgramNativeAttribsARB = 34991,

    [NativeName("GL_MAX_PROGRAM_LOCAL_PARAMETERS_ARB")]
    MaxProgramLocalParametersARB = 34996,

    [NativeName("GL_MAX_PROGRAM_ENV_PARAMETERS_ARB")]
    MaxProgramEnvParametersARB = 34997,

    [NativeName("GL_PROGRAM_UNDER_NATIVE_LIMITS_ARB")]
    ProgramUnderNativeLimitsARB = 34998,

    [NativeName("GL_PROGRAM_ALU_INSTRUCTIONS_ARB")]
    ProgramAluInstructionsARB = 34821,

    [NativeName("GL_PROGRAM_TEX_INSTRUCTIONS_ARB")]
    ProgramTexInstructionsARB = 34822,

    [NativeName("GL_PROGRAM_TEX_INDIRECTIONS_ARB")]
    ProgramTexIndirectionsARB = 34823,

    [NativeName("GL_PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB")]
    ProgramNativeAluInstructionsARB = 34824,

    [NativeName("GL_PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB")]
    ProgramNativeTexInstructionsARB = 34825,

    [NativeName("GL_PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB")]
    ProgramNativeTexIndirectionsARB = 34826,

    [NativeName("GL_MAX_PROGRAM_ALU_INSTRUCTIONS_ARB")]
    MaxProgramAluInstructionsARB = 34827,

    [NativeName("GL_MAX_PROGRAM_TEX_INSTRUCTIONS_ARB")]
    MaxProgramTexInstructionsARB = 34828,

    [NativeName("GL_MAX_PROGRAM_TEX_INDIRECTIONS_ARB")]
    MaxProgramTexIndirectionsARB = 34829,

    [NativeName("GL_MAX_PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB")]
    MaxProgramNativeAluInstructionsARB = 34830,

    [NativeName("GL_MAX_PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB")]
    MaxProgramNativeTexInstructionsARB = 34831,

    [NativeName("GL_MAX_PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB")]
    MaxProgramNativeTexIndirectionsARB = 34832,

    [NativeName("GL_PROGRAM_STRING_ARB")]
    ProgramStringARB = 34344,

    [NativeName("GL_PROGRAM_ERROR_POSITION_ARB")]
    ProgramErrorPositionARB = 34379,

    [NativeName("GL_CURRENT_MATRIX_ARB")]
    CurrentMatrixARB = 34369,

    [NativeName("GL_TRANSPOSE_CURRENT_MATRIX_ARB")]
    TransposeCurrentMatrixARB = 34999,

    [NativeName("GL_CURRENT_MATRIX_STACK_DEPTH_ARB")]
    CurrentMatrixStackDepthARB = 34368,

    [NativeName("GL_MAX_PROGRAM_MATRICES_ARB")]
    MaxProgramMatricesARB = 34351,

    [NativeName("GL_MAX_PROGRAM_MATRIX_STACK_DEPTH_ARB")]
    MaxProgramMatrixStackDepthARB = 34350,

    [NativeName("GL_MAX_TEXTURE_COORDS_ARB")]
    MaxTextureCoordsARB = 34929,

    [NativeName("GL_MAX_TEXTURE_IMAGE_UNITS_ARB")]
    MaxTextureImageUnitsARB = 34930,

    [NativeName("GL_PROGRAM_ERROR_STRING_ARB")]
    ProgramErrorStringARB = 34932,

    [NativeName("GL_MATRIX0_ARB")]
    Matrix0ARB = 35008,

    [NativeName("GL_MATRIX1_ARB")]
    Matrix1ARB = 35009,

    [NativeName("GL_MATRIX2_ARB")]
    Matrix2ARB = 35010,

    [NativeName("GL_MATRIX3_ARB")]
    Matrix3ARB = 35011,

    [NativeName("GL_MATRIX4_ARB")]
    Matrix4ARB = 35012,

    [NativeName("GL_MATRIX5_ARB")]
    Matrix5ARB = 35013,

    [NativeName("GL_MATRIX6_ARB")]
    Matrix6ARB = 35014,

    [NativeName("GL_MATRIX7_ARB")]
    Matrix7ARB = 35015,

    [NativeName("GL_MATRIX8_ARB")]
    Matrix8ARB = 35016,

    [NativeName("GL_MATRIX9_ARB")]
    Matrix9ARB = 35017,

    [NativeName("GL_MATRIX10_ARB")]
    Matrix10ARB = 35018,

    [NativeName("GL_MATRIX11_ARB")]
    Matrix11ARB = 35019,

    [NativeName("GL_MATRIX12_ARB")]
    Matrix12ARB = 35020,

    [NativeName("GL_MATRIX13_ARB")]
    Matrix13ARB = 35021,

    [NativeName("GL_MATRIX14_ARB")]
    Matrix14ARB = 35022,

    [NativeName("GL_MATRIX15_ARB")]
    Matrix15ARB = 35023,

    [NativeName("GL_MATRIX16_ARB")]
    Matrix16ARB = 35024,

    [NativeName("GL_MATRIX17_ARB")]
    Matrix17ARB = 35025,

    [NativeName("GL_MATRIX18_ARB")]
    Matrix18ARB = 35026,

    [NativeName("GL_MATRIX19_ARB")]
    Matrix19ARB = 35027,

    [NativeName("GL_MATRIX20_ARB")]
    Matrix20ARB = 35028,

    [NativeName("GL_MATRIX21_ARB")]
    Matrix21ARB = 35029,

    [NativeName("GL_MATRIX22_ARB")]
    Matrix22ARB = 35030,

    [NativeName("GL_MATRIX23_ARB")]
    Matrix23ARB = 35031,

    [NativeName("GL_MATRIX24_ARB")]
    Matrix24ARB = 35032,

    [NativeName("GL_MATRIX25_ARB")]
    Matrix25ARB = 35033,

    [NativeName("GL_MATRIX26_ARB")]
    Matrix26ARB = 35034,

    [NativeName("GL_MATRIX27_ARB")]
    Matrix27ARB = 35035,

    [NativeName("GL_MATRIX28_ARB")]
    Matrix28ARB = 35036,

    [NativeName("GL_MATRIX29_ARB")]
    Matrix29ARB = 35037,

    [NativeName("GL_MATRIX30_ARB")]
    Matrix30ARB = 35038,

    [NativeName("GL_MATRIX31_ARB")]
    Matrix31ARB = 35039,

    [NativeName("GL_FRAGMENT_SHADER_ARB")]
    FragmentShaderARB = 35632,

    [NativeName("GL_MAX_FRAGMENT_UNIFORM_COMPONENTS_ARB")]
    MaxFragmentUniformComponentsARB = 35657,

    [NativeName("GL_FRAGMENT_SHADER_DERIVATIVE_HINT_ARB")]
    FragmentShaderDerivativeHintARB = 35723,

    [NativeName("GL_LINES_ADJACENCY_ARB")]
    LinesAdjacencyARB = 10,

    [NativeName("GL_LINE_STRIP_ADJACENCY_ARB")]
    LineStripAdjacencyARB = 11,

    [NativeName("GL_TRIANGLES_ADJACENCY_ARB")]
    TrianglesAdjacencyARB = 12,

    [NativeName("GL_TRIANGLE_STRIP_ADJACENCY_ARB")]
    TriangleStripAdjacencyARB = 13,

    [NativeName("GL_PROGRAM_POINT_SIZE_ARB")]
    ProgramPointSizeARB = 34370,

    [NativeName("GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_ARB")]
    MaxGeometryTextureImageUnitsARB = 35881,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_LAYERED_ARB")]
    FramebufferAttachmentLayeredARB = 36263,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_ARB")]
    FramebufferIncompleteLayerTargetsARB = 36264,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_ARB")]
    FramebufferIncompleteLayerCountARB = 36265,

    [NativeName("GL_GEOMETRY_SHADER_ARB")]
    GeometryShaderARB = 36313,

    [NativeName("GL_GEOMETRY_VERTICES_OUT_ARB")]
    GeometryVerticesOutARB = 36314,

    [NativeName("GL_GEOMETRY_INPUT_TYPE_ARB")]
    GeometryInputTypeARB = 36315,

    [NativeName("GL_GEOMETRY_OUTPUT_TYPE_ARB")]
    GeometryOutputTypeARB = 36316,

    [NativeName("GL_MAX_GEOMETRY_VARYING_COMPONENTS_ARB")]
    MaxGeometryVaryingComponentsARB = 36317,

    [NativeName("GL_MAX_VERTEX_VARYING_COMPONENTS_ARB")]
    MaxVertexVaryingComponentsARB = 36318,

    [NativeName("GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_ARB")]
    MaxGeometryUniformComponentsARB = 36319,

    [NativeName("GL_MAX_GEOMETRY_OUTPUT_VERTICES_ARB")]
    MaxGeometryOutputVerticesARB = 36320,

    [NativeName("GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_ARB")]
    MaxGeometryTotalOutputComponentsARB = 36321,

    [NativeName("GL_SHADER_BINARY_FORMAT_SPIR_V_ARB")]
    ShaderBinaryFormatSpirVARB = 38225,

    [NativeName("GL_SPIR_V_BINARY_ARB")]
    SpirVBinaryARB = 38226,

    [NativeName("GL_INT64_ARB")]
    Int64ARB = 5134,

    [NativeName("GL_INT64_VEC2_ARB")]
    Int64Vec2ARB = 36841,

    [NativeName("GL_INT64_VEC3_ARB")]
    Int64Vec3ARB = 36842,

    [NativeName("GL_INT64_VEC4_ARB")]
    Int64Vec4ARB = 36843,

    [NativeName("GL_UNSIGNED_INT64_VEC2_ARB")]
    UnsignedInt64Vec2ARB = 36853,

    [NativeName("GL_UNSIGNED_INT64_VEC3_ARB")]
    UnsignedInt64Vec3ARB = 36854,

    [NativeName("GL_UNSIGNED_INT64_VEC4_ARB")]
    UnsignedInt64Vec4ARB = 36855,

    [NativeName("GL_HALF_FLOAT_ARB")]
    HalfFloatARB = 5131,

    [NativeName("GL_CONVOLUTION_BORDER_MODE")]
    ConvolutionBorderMode = 32787,

    [NativeName("GL_CONVOLUTION_FILTER_SCALE")]
    ConvolutionFilterScale = 32788,

    [NativeName("GL_CONVOLUTION_FILTER_BIAS")]
    ConvolutionFilterBias = 32789,

    [NativeName("GL_REDUCE")]
    Reduce = 32790,

    [NativeName("GL_CONVOLUTION_FORMAT")]
    ConvolutionFormat = 32791,

    [NativeName("GL_CONVOLUTION_WIDTH")]
    ConvolutionWidth = 32792,

    [NativeName("GL_CONVOLUTION_HEIGHT")]
    ConvolutionHeight = 32793,

    [NativeName("GL_MAX_CONVOLUTION_WIDTH")]
    MaxConvolutionWidth = 32794,

    [NativeName("GL_MAX_CONVOLUTION_HEIGHT")]
    MaxConvolutionHeight = 32795,

    [NativeName("GL_POST_CONVOLUTION_RED_SCALE")]
    PostConvolutionRedScale = 32796,

    [NativeName("GL_POST_CONVOLUTION_GREEN_SCALE")]
    PostConvolutionGreenScale = 32797,

    [NativeName("GL_POST_CONVOLUTION_BLUE_SCALE")]
    PostConvolutionBlueScale = 32798,

    [NativeName("GL_POST_CONVOLUTION_ALPHA_SCALE")]
    PostConvolutionAlphaScale = 32799,

    [NativeName("GL_POST_CONVOLUTION_RED_BIAS")]
    PostConvolutionRedBias = 32800,

    [NativeName("GL_POST_CONVOLUTION_GREEN_BIAS")]
    PostConvolutionGreenBias = 32801,

    [NativeName("GL_POST_CONVOLUTION_BLUE_BIAS")]
    PostConvolutionBlueBias = 32802,

    [NativeName("GL_POST_CONVOLUTION_ALPHA_BIAS")]
    PostConvolutionAlphaBias = 32803,

    [NativeName("GL_HISTOGRAM_WIDTH")]
    HistogramWidth = 32806,

    [NativeName("GL_HISTOGRAM_FORMAT")]
    HistogramFormat = 32807,

    [NativeName("GL_HISTOGRAM_RED_SIZE")]
    HistogramRedSize = 32808,

    [NativeName("GL_HISTOGRAM_GREEN_SIZE")]
    HistogramGreenSize = 32809,

    [NativeName("GL_HISTOGRAM_BLUE_SIZE")]
    HistogramBlueSize = 32810,

    [NativeName("GL_HISTOGRAM_ALPHA_SIZE")]
    HistogramAlphaSize = 32811,

    [NativeName("GL_HISTOGRAM_LUMINANCE_SIZE")]
    HistogramLuminanceSize = 32812,

    [NativeName("GL_HISTOGRAM_SINK")]
    HistogramSink = 32813,

    [NativeName("GL_MINMAX_FORMAT")]
    MinmaxFormat = 32815,

    [NativeName("GL_MINMAX_SINK")]
    MinmaxSink = 32816,

    [NativeName("GL_TABLE_TOO_LARGE")]
    TableTooLarge = 32817,

    [NativeName("GL_COLOR_MATRIX")]
    ColorMatrix = 32945,

    [NativeName("GL_COLOR_MATRIX_STACK_DEPTH")]
    ColorMatrixStackDepth = 32946,

    [NativeName("GL_MAX_COLOR_MATRIX_STACK_DEPTH")]
    MaxColorMatrixStackDepth = 32947,

    [NativeName("GL_POST_COLOR_MATRIX_RED_SCALE")]
    PostColorMatrixRedScale = 32948,

    [NativeName("GL_POST_COLOR_MATRIX_GREEN_SCALE")]
    PostColorMatrixGreenScale = 32949,

    [NativeName("GL_POST_COLOR_MATRIX_BLUE_SCALE")]
    PostColorMatrixBlueScale = 32950,

    [NativeName("GL_POST_COLOR_MATRIX_ALPHA_SCALE")]
    PostColorMatrixAlphaScale = 32951,

    [NativeName("GL_POST_COLOR_MATRIX_RED_BIAS")]
    PostColorMatrixRedBias = 32952,

    [NativeName("GL_POST_COLOR_MATRIX_GREEN_BIAS")]
    PostColorMatrixGreenBias = 32953,

    [NativeName("GL_POST_COLOR_MATRIX_BLUE_BIAS")]
    PostColorMatrixBlueBias = 32954,

    [NativeName("GL_POST_COLOR_MATRIX_ALPHA_BIAS")]
    PostColorMatrixAlphaBias = 32955,

    [NativeName("GL_COLOR_TABLE_SCALE")]
    ColorTableScale = 32982,

    [NativeName("GL_COLOR_TABLE_BIAS")]
    ColorTableBias = 32983,

    [NativeName("GL_COLOR_TABLE_FORMAT")]
    ColorTableFormat = 32984,

    [NativeName("GL_COLOR_TABLE_WIDTH")]
    ColorTableWidth = 32985,

    [NativeName("GL_COLOR_TABLE_RED_SIZE")]
    ColorTableRedSize = 32986,

    [NativeName("GL_COLOR_TABLE_GREEN_SIZE")]
    ColorTableGreenSize = 32987,

    [NativeName("GL_COLOR_TABLE_BLUE_SIZE")]
    ColorTableBlueSize = 32988,

    [NativeName("GL_COLOR_TABLE_ALPHA_SIZE")]
    ColorTableAlphaSize = 32989,

    [NativeName("GL_COLOR_TABLE_LUMINANCE_SIZE")]
    ColorTableLuminanceSize = 32990,

    [NativeName("GL_COLOR_TABLE_INTENSITY_SIZE")]
    ColorTableIntensitySize = 32991,

    [NativeName("GL_CONSTANT_BORDER")]
    ConstantBorder = 33105,

    [NativeName("GL_REPLICATE_BORDER")]
    ReplicateBorder = 33107,

    [NativeName("GL_CONVOLUTION_BORDER_COLOR")]
    ConvolutionBorderColor = 33108,

    [NativeName("GL_PARAMETER_BUFFER_ARB")]
    ParameterBufferARB = 33006,

    [NativeName("GL_PARAMETER_BUFFER_BINDING_ARB")]
    ParameterBufferBindingARB = 33007,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_DIVISOR_ARB")]
    VertexAttribArrayDivisorARB = 35070,

    [NativeName("GL_SRGB_DECODE_ARB")]
    SrgbDecodeARB = 33433,

    [NativeName("GL_VIEW_CLASS_EAC_R11")]
    ViewClassEacR11 = 37763,

    [NativeName("GL_VIEW_CLASS_EAC_RG11")]
    ViewClassEacRg11 = 37764,

    [NativeName("GL_VIEW_CLASS_ETC2_RGB")]
    ViewClassEtc2Rgb = 37765,

    [NativeName("GL_VIEW_CLASS_ETC2_RGBA")]
    ViewClassEtc2Rgba = 37766,

    [NativeName("GL_VIEW_CLASS_ETC2_EAC_RGBA")]
    ViewClassEtc2EacRgba = 37767,

    [NativeName("GL_VIEW_CLASS_ASTC_4x4_RGBA")]
    ViewClassAstc4X4Rgba = 37768,

    [NativeName("GL_VIEW_CLASS_ASTC_5x4_RGBA")]
    ViewClassAstc5X4Rgba = 37769,

    [NativeName("GL_VIEW_CLASS_ASTC_5x5_RGBA")]
    ViewClassAstc5X5Rgba = 37770,

    [NativeName("GL_VIEW_CLASS_ASTC_6x5_RGBA")]
    ViewClassAstc6X5Rgba = 37771,

    [NativeName("GL_VIEW_CLASS_ASTC_6x6_RGBA")]
    ViewClassAstc6X6Rgba = 37772,

    [NativeName("GL_VIEW_CLASS_ASTC_8x5_RGBA")]
    ViewClassAstc8X5Rgba = 37773,

    [NativeName("GL_VIEW_CLASS_ASTC_8x6_RGBA")]
    ViewClassAstc8X6Rgba = 37774,

    [NativeName("GL_VIEW_CLASS_ASTC_8x8_RGBA")]
    ViewClassAstc8X8Rgba = 37775,

    [NativeName("GL_VIEW_CLASS_ASTC_10x5_RGBA")]
    ViewClassAstc10X5Rgba = 37776,

    [NativeName("GL_VIEW_CLASS_ASTC_10x6_RGBA")]
    ViewClassAstc10X6Rgba = 37777,

    [NativeName("GL_VIEW_CLASS_ASTC_10x8_RGBA")]
    ViewClassAstc10X8Rgba = 37778,

    [NativeName("GL_VIEW_CLASS_ASTC_10x10_RGBA")]
    ViewClassAstc10X10Rgba = 37779,

    [NativeName("GL_VIEW_CLASS_ASTC_12x10_RGBA")]
    ViewClassAstc12X10Rgba = 37780,

    [NativeName("GL_VIEW_CLASS_ASTC_12x12_RGBA")]
    ViewClassAstc12X12Rgba = 37781,

    [NativeName("GL_MATRIX_PALETTE_ARB")]
    MatrixPaletteARB = 34880,

    [NativeName("GL_MAX_MATRIX_PALETTE_STACK_DEPTH_ARB")]
    MaxMatrixPaletteStackDepthARB = 34881,

    [NativeName("GL_MAX_PALETTE_MATRICES_ARB")]
    MaxPaletteMatricesARB = 34882,

    [NativeName("GL_CURRENT_PALETTE_MATRIX_ARB")]
    CurrentPaletteMatrixARB = 34883,

    [NativeName("GL_MATRIX_INDEX_ARRAY_ARB")]
    MatrixIndexArrayARB = 34884,

    [NativeName("GL_CURRENT_MATRIX_INDEX_ARB")]
    CurrentMatrixIndexARB = 34885,

    [NativeName("GL_MATRIX_INDEX_ARRAY_SIZE_ARB")]
    MatrixIndexArraySizeARB = 34886,

    [NativeName("GL_MATRIX_INDEX_ARRAY_TYPE_ARB")]
    MatrixIndexArrayTypeARB = 34887,

    [NativeName("GL_MATRIX_INDEX_ARRAY_STRIDE_ARB")]
    MatrixIndexArrayStrideARB = 34888,

    [NativeName("GL_MATRIX_INDEX_ARRAY_POINTER_ARB")]
    MatrixIndexArrayPointerARB = 34889,

    [NativeName("GL_MULTISAMPLE_ARB")]
    MultisampleARB = 32925,

    [NativeName("GL_SAMPLE_ALPHA_TO_COVERAGE_ARB")]
    SampleAlphaToCoverageARB = 32926,

    [NativeName("GL_SAMPLE_ALPHA_TO_ONE_ARB")]
    SampleAlphaToOneARB = 32927,

    [NativeName("GL_SAMPLE_COVERAGE_ARB")]
    SampleCoverageARB = 32928,

    [NativeName("GL_SAMPLE_BUFFERS_ARB")]
    SampleBuffersARB = 32936,

    [NativeName("GL_SAMPLES_ARB")]
    SamplesARB = 32937,

    [NativeName("GL_SAMPLE_COVERAGE_VALUE_ARB")]
    SampleCoverageValueARB = 32938,

    [NativeName("GL_SAMPLE_COVERAGE_INVERT_ARB")]
    SampleCoverageInvertARB = 32939,

    [NativeName("GL_MULTISAMPLE_BIT_ARB")]
    MultisampleBitARB = 536870912,

    [NativeName("GL_TEXTURE0_ARB")]
    Texture0ARB = 33984,

    [NativeName("GL_TEXTURE1_ARB")]
    Texture1ARB = 33985,

    [NativeName("GL_TEXTURE2_ARB")]
    Texture2ARB = 33986,

    [NativeName("GL_TEXTURE3_ARB")]
    Texture3ARB = 33987,

    [NativeName("GL_TEXTURE4_ARB")]
    Texture4ARB = 33988,

    [NativeName("GL_TEXTURE5_ARB")]
    Texture5ARB = 33989,

    [NativeName("GL_TEXTURE6_ARB")]
    Texture6ARB = 33990,

    [NativeName("GL_TEXTURE7_ARB")]
    Texture7ARB = 33991,

    [NativeName("GL_TEXTURE8_ARB")]
    Texture8ARB = 33992,

    [NativeName("GL_TEXTURE9_ARB")]
    Texture9ARB = 33993,

    [NativeName("GL_TEXTURE10_ARB")]
    Texture10ARB = 33994,

    [NativeName("GL_TEXTURE11_ARB")]
    Texture11ARB = 33995,

    [NativeName("GL_TEXTURE12_ARB")]
    Texture12ARB = 33996,

    [NativeName("GL_TEXTURE13_ARB")]
    Texture13ARB = 33997,

    [NativeName("GL_TEXTURE14_ARB")]
    Texture14ARB = 33998,

    [NativeName("GL_TEXTURE15_ARB")]
    Texture15ARB = 33999,

    [NativeName("GL_TEXTURE16_ARB")]
    Texture16ARB = 34000,

    [NativeName("GL_TEXTURE17_ARB")]
    Texture17ARB = 34001,

    [NativeName("GL_TEXTURE18_ARB")]
    Texture18ARB = 34002,

    [NativeName("GL_TEXTURE19_ARB")]
    Texture19ARB = 34003,

    [NativeName("GL_TEXTURE20_ARB")]
    Texture20ARB = 34004,

    [NativeName("GL_TEXTURE21_ARB")]
    Texture21ARB = 34005,

    [NativeName("GL_TEXTURE22_ARB")]
    Texture22ARB = 34006,

    [NativeName("GL_TEXTURE23_ARB")]
    Texture23ARB = 34007,

    [NativeName("GL_TEXTURE24_ARB")]
    Texture24ARB = 34008,

    [NativeName("GL_TEXTURE25_ARB")]
    Texture25ARB = 34009,

    [NativeName("GL_TEXTURE26_ARB")]
    Texture26ARB = 34010,

    [NativeName("GL_TEXTURE27_ARB")]
    Texture27ARB = 34011,

    [NativeName("GL_TEXTURE28_ARB")]
    Texture28ARB = 34012,

    [NativeName("GL_TEXTURE29_ARB")]
    Texture29ARB = 34013,

    [NativeName("GL_TEXTURE30_ARB")]
    Texture30ARB = 34014,

    [NativeName("GL_TEXTURE31_ARB")]
    Texture31ARB = 34015,

    [NativeName("GL_ACTIVE_TEXTURE_ARB")]
    ActiveTextureARB = 34016,

    [NativeName("GL_CLIENT_ACTIVE_TEXTURE_ARB")]
    ClientActiveTextureARB = 34017,

    [NativeName("GL_MAX_TEXTURE_UNITS_ARB")]
    MaxTextureUnitsARB = 34018,

    [NativeName("GL_QUERY_COUNTER_BITS_ARB")]
    QueryCounterBitsARB = 34916,

    [NativeName("GL_CURRENT_QUERY_ARB")]
    CurrentQueryARB = 34917,

    [NativeName("GL_QUERY_RESULT_ARB")]
    QueryResultARB = 34918,

    [NativeName("GL_QUERY_RESULT_AVAILABLE_ARB")]
    QueryResultAvailableARB = 34919,

    [NativeName("GL_SAMPLES_PASSED_ARB")]
    SamplesPassedARB = 35092,

    [NativeName("GL_MAX_SHADER_COMPILER_THREADS_ARB")]
    MaxShaderCompilerThreadsARB = 37296,

    [NativeName("GL_COMPLETION_STATUS_ARB")]
    CompletionStatusARB = 37297,

    [NativeName("GL_VERTICES_SUBMITTED_ARB")]
    VerticesSubmittedARB = 33518,

    [NativeName("GL_PRIMITIVES_SUBMITTED_ARB")]
    PrimitivesSubmittedARB = 33519,

    [NativeName("GL_VERTEX_SHADER_INVOCATIONS_ARB")]
    VertexShaderInvocationsARB = 33520,

    [NativeName("GL_TESS_CONTROL_SHADER_PATCHES_ARB")]
    TessControlShaderPatchesARB = 33521,

    [NativeName("GL_TESS_EVALUATION_SHADER_INVOCATIONS_ARB")]
    TessEvaluationShaderInvocationsARB = 33522,

    [NativeName("GL_GEOMETRY_SHADER_PRIMITIVES_EMITTED_ARB")]
    GeometryShaderPrimitivesEmittedARB = 33523,

    [NativeName("GL_FRAGMENT_SHADER_INVOCATIONS_ARB")]
    FragmentShaderInvocationsARB = 33524,

    [NativeName("GL_COMPUTE_SHADER_INVOCATIONS_ARB")]
    ComputeShaderInvocationsARB = 33525,

    [NativeName("GL_CLIPPING_INPUT_PRIMITIVES_ARB")]
    ClippingInputPrimitivesARB = 33526,

    [NativeName("GL_CLIPPING_OUTPUT_PRIMITIVES_ARB")]
    ClippingOutputPrimitivesARB = 33527,

    [NativeName("GL_PIXEL_PACK_BUFFER_ARB")]
    PixelPackBufferARB = 35051,

    [NativeName("GL_PIXEL_UNPACK_BUFFER_ARB")]
    PixelUnpackBufferARB = 35052,

    [NativeName("GL_PIXEL_PACK_BUFFER_BINDING_ARB")]
    PixelPackBufferBindingARB = 35053,

    [NativeName("GL_PIXEL_UNPACK_BUFFER_BINDING_ARB")]
    PixelUnpackBufferBindingARB = 35055,

    [NativeName("GL_POINT_SIZE_MIN_ARB")]
    PointSizeMinARB = 33062,

    [NativeName("GL_POINT_SIZE_MAX_ARB")]
    PointSizeMaxARB = 33063,

    [NativeName("GL_POINT_FADE_THRESHOLD_SIZE_ARB")]
    PointFadeThresholdSizeARB = 33064,

    [NativeName("GL_POINT_DISTANCE_ATTENUATION_ARB")]
    PointDistanceAttenuationARB = 33065,

    [NativeName("GL_POINT_SPRITE_ARB")]
    PointSpriteARB = 34913,

    [NativeName("GL_COORD_REPLACE_ARB")]
    CoordReplaceARB = 34914,

    [NativeName("GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB")]
    ContextFlagRobustAccessBitARB = 4,

    [NativeName("GL_LOSE_CONTEXT_ON_RESET_ARB")]
    LoseContextOnResetARB = 33362,

    [NativeName("GL_GUILTY_CONTEXT_RESET_ARB")]
    GuiltyContextResetARB = 33363,

    [NativeName("GL_INNOCENT_CONTEXT_RESET_ARB")]
    InnocentContextResetARB = 33364,

    [NativeName("GL_UNKNOWN_CONTEXT_RESET_ARB")]
    UnknownContextResetARB = 33365,

    [NativeName("GL_RESET_NOTIFICATION_STRATEGY_ARB")]
    ResetNotificationStrategyARB = 33366,

    [NativeName("GL_NO_RESET_NOTIFICATION_ARB")]
    NoResetNotificationARB = 33377,

    [NativeName("GL_SAMPLE_LOCATION_SUBPIXEL_BITS_ARB")]
    SampleLocationSubpixelBitsARB = 37693,

    [NativeName("GL_SAMPLE_LOCATION_PIXEL_GRID_WIDTH_ARB")]
    SampleLocationPixelGridWidthARB = 37694,

    [NativeName("GL_SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_ARB")]
    SampleLocationPixelGridHeightARB = 37695,

    [NativeName("GL_PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_ARB")]
    ProgrammableSampleLocationTableSizeARB = 37696,

    [NativeName("GL_SAMPLE_LOCATION_ARB")]
    SampleLocationARB = 36432,

    [NativeName("GL_PROGRAMMABLE_SAMPLE_LOCATION_ARB")]
    ProgrammableSampleLocationARB = 37697,

    [NativeName("GL_FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_ARB")]
    FramebufferProgrammableSampleLocationsARB = 37698,

    [NativeName("GL_FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_ARB")]
    FramebufferSampleLocationPixelGridARB = 37699,

    [NativeName("GL_SAMPLE_SHADING_ARB")]
    SampleShadingARB = 35894,

    [NativeName("GL_MIN_SAMPLE_SHADING_VALUE_ARB")]
    MinSampleShadingValueARB = 35895,

    [NativeName("GL_PROGRAM_OBJECT_ARB")]
    ProgramObjectARB = 35648,

    [NativeName("GL_SHADER_OBJECT_ARB")]
    ShaderObjectARB = 35656,

    [NativeName("GL_OBJECT_TYPE_ARB")]
    ObjectTypeARB = 35662,

    [NativeName("GL_OBJECT_SUBTYPE_ARB")]
    ObjectSubtypeARB = 35663,

    [NativeName("GL_FLOAT_VEC2_ARB")]
    FloatVec2ARB = 35664,

    [NativeName("GL_FLOAT_VEC3_ARB")]
    FloatVec3ARB = 35665,

    [NativeName("GL_FLOAT_VEC4_ARB")]
    FloatVec4ARB = 35666,

    [NativeName("GL_INT_VEC2_ARB")]
    IntVec2ARB = 35667,

    [NativeName("GL_INT_VEC3_ARB")]
    IntVec3ARB = 35668,

    [NativeName("GL_INT_VEC4_ARB")]
    IntVec4ARB = 35669,

    [NativeName("GL_BOOL_ARB")]
    BoolARB = 35670,

    [NativeName("GL_BOOL_VEC2_ARB")]
    BoolVec2ARB = 35671,

    [NativeName("GL_BOOL_VEC3_ARB")]
    BoolVec3ARB = 35672,

    [NativeName("GL_BOOL_VEC4_ARB")]
    BoolVec4ARB = 35673,

    [NativeName("GL_FLOAT_MAT2_ARB")]
    FloatMat2ARB = 35674,

    [NativeName("GL_FLOAT_MAT3_ARB")]
    FloatMat3ARB = 35675,

    [NativeName("GL_FLOAT_MAT4_ARB")]
    FloatMat4ARB = 35676,

    [NativeName("GL_SAMPLER_1D_ARB")]
    Sampler1DARB = 35677,

    [NativeName("GL_SAMPLER_2D_ARB")]
    Sampler2DARB = 35678,

    [NativeName("GL_SAMPLER_3D_ARB")]
    Sampler3DARB = 35679,

    [NativeName("GL_SAMPLER_CUBE_ARB")]
    SamplerCubeARB = 35680,

    [NativeName("GL_SAMPLER_1D_SHADOW_ARB")]
    Sampler1DShadowARB = 35681,

    [NativeName("GL_SAMPLER_2D_SHADOW_ARB")]
    Sampler2DShadowARB = 35682,

    [NativeName("GL_SAMPLER_2D_RECT_ARB")]
    Sampler2DRectARB = 35683,

    [NativeName("GL_SAMPLER_2D_RECT_SHADOW_ARB")]
    Sampler2DRectShadowARB = 35684,

    [NativeName("GL_OBJECT_DELETE_STATUS_ARB")]
    ObjectDeleteStatusARB = 35712,

    [NativeName("GL_OBJECT_COMPILE_STATUS_ARB")]
    ObjectCompileStatusARB = 35713,

    [NativeName("GL_OBJECT_LINK_STATUS_ARB")]
    ObjectLinkStatusARB = 35714,

    [NativeName("GL_OBJECT_VALIDATE_STATUS_ARB")]
    ObjectValidateStatusARB = 35715,

    [NativeName("GL_OBJECT_INFO_LOG_LENGTH_ARB")]
    ObjectInfoLogLengthARB = 35716,

    [NativeName("GL_OBJECT_ATTACHED_OBJECTS_ARB")]
    ObjectAttachedObjectsARB = 35717,

    [NativeName("GL_OBJECT_ACTIVE_UNIFORMS_ARB")]
    ObjectActiveUniformsARB = 35718,

    [NativeName("GL_OBJECT_ACTIVE_UNIFORM_MAX_LENGTH_ARB")]
    ObjectActiveUniformMaxLengthARB = 35719,

    [NativeName("GL_OBJECT_SHADER_SOURCE_LENGTH_ARB")]
    ObjectShaderSourceLengthARB = 35720,

    [NativeName("GL_SHADING_LANGUAGE_VERSION_ARB")]
    ShadingLanguageVersionARB = 35724,

    [NativeName("GL_SHADER_INCLUDE_ARB")]
    ShaderIncludeARB = 36270,

    [NativeName("GL_NAMED_STRING_LENGTH_ARB")]
    NamedStringLengthARB = 36329,

    [NativeName("GL_NAMED_STRING_TYPE_ARB")]
    NamedStringTypeARB = 36330,

    [NativeName("GL_TEXTURE_COMPARE_MODE_ARB")]
    TextureCompareModeARB = 34892,

    [NativeName("GL_TEXTURE_COMPARE_FUNC_ARB")]
    TextureCompareFuncARB = 34893,

    [NativeName("GL_COMPARE_R_TO_TEXTURE_ARB")]
    CompareRToTextureARB = 34894,

    [NativeName("GL_TEXTURE_COMPARE_FAIL_VALUE_ARB")]
    TextureCompareFailValueARB = 32959,

    [NativeName("GL_SPARSE_STORAGE_BIT_ARB")]
    SparseStorageBitARB = 1024,

    [NativeName("GL_SPARSE_BUFFER_PAGE_SIZE_ARB")]
    SparseBufferPageSizeARB = 33528,

    [NativeName("GL_TEXTURE_SPARSE_ARB")]
    TextureSparseARB = 37286,

    [NativeName("GL_VIRTUAL_PAGE_SIZE_INDEX_ARB")]
    VirtualPageSizeIndexARB = 37287,

    [NativeName("GL_NUM_SPARSE_LEVELS_ARB")]
    NumSparseLevelsARB = 37290,

    [NativeName("GL_NUM_VIRTUAL_PAGE_SIZES_ARB")]
    NumVirtualPageSizesARB = 37288,

    [NativeName("GL_VIRTUAL_PAGE_SIZE_X_ARB")]
    VirtualPageSizeXARB = 37269,

    [NativeName("GL_VIRTUAL_PAGE_SIZE_Y_ARB")]
    VirtualPageSizeYARB = 37270,

    [NativeName("GL_VIRTUAL_PAGE_SIZE_Z_ARB")]
    VirtualPageSizeZARB = 37271,

    [NativeName("GL_MAX_SPARSE_TEXTURE_SIZE_ARB")]
    MaxSparseTextureSizeARB = 37272,

    [NativeName("GL_MAX_SPARSE_3D_TEXTURE_SIZE_ARB")]
    MaxSparse3DTextureSizeARB = 37273,

    [NativeName("GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS_ARB")]
    MaxSparseArrayTextureLayersARB = 37274,

    [NativeName("GL_SPARSE_TEXTURE_FULL_ARRAY_CUBE_MIPMAPS_ARB")]
    SparseTextureFullArrayCubeMipmapsARB = 37289,

    [NativeName("GL_CLAMP_TO_BORDER_ARB")]
    ClampToBorderARB = 33069,

    [NativeName("GL_TEXTURE_BUFFER_ARB")]
    TextureBufferARB = 35882,

    [NativeName("GL_MAX_TEXTURE_BUFFER_SIZE_ARB")]
    MaxTextureBufferSizeARB = 35883,

    [NativeName("GL_TEXTURE_BINDING_BUFFER_ARB")]
    TextureBindingBufferARB = 35884,

    [NativeName("GL_TEXTURE_BUFFER_DATA_STORE_BINDING_ARB")]
    TextureBufferDataStoreBindingARB = 35885,

    [NativeName("GL_TEXTURE_BUFFER_FORMAT_ARB")]
    TextureBufferFormatARB = 35886,

    [NativeName("GL_COMPRESSED_ALPHA_ARB")]
    CompressedAlphaARB = 34025,

    [NativeName("GL_COMPRESSED_LUMINANCE_ARB")]
    CompressedLuminanceARB = 34026,

    [NativeName("GL_COMPRESSED_LUMINANCE_ALPHA_ARB")]
    CompressedLuminanceAlphaARB = 34027,

    [NativeName("GL_COMPRESSED_INTENSITY_ARB")]
    CompressedIntensityARB = 34028,

    [NativeName("GL_COMPRESSED_RGB_ARB")]
    CompressedRgbARB = 34029,

    [NativeName("GL_COMPRESSED_RGBA_ARB")]
    CompressedRgbaARB = 34030,

    [NativeName("GL_TEXTURE_COMPRESSION_HINT_ARB")]
    TextureCompressionHintARB = 34031,

    [NativeName("GL_TEXTURE_COMPRESSED_IMAGE_SIZE_ARB")]
    TextureCompressedImageSizeARB = 34464,

    [NativeName("GL_TEXTURE_COMPRESSED_ARB")]
    TextureCompressedARB = 34465,

    [NativeName("GL_NUM_COMPRESSED_TEXTURE_FORMATS_ARB")]
    NumCompressedTextureFormatsARB = 34466,

    [NativeName("GL_COMPRESSED_TEXTURE_FORMATS_ARB")]
    CompressedTextureFormatsARB = 34467,

    [NativeName("GL_COMPRESSED_RGBA_BPTC_UNORM_ARB")]
    CompressedRgbaBptcUnormARB = 36492,

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM_ARB")]
    CompressedSrgbAlphaBptcUnormARB = 36493,

    [NativeName("GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT_ARB")]
    CompressedRgbBptcSignedFloatARB = 36494,

    [NativeName("GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_ARB")]
    CompressedRgbBptcUnsignedFloatARB = 36495,

    [NativeName("GL_NORMAL_MAP_ARB")]
    NormalMapARB = 34065,

    [NativeName("GL_REFLECTION_MAP_ARB")]
    ReflectionMapARB = 34066,

    [NativeName("GL_TEXTURE_CUBE_MAP_ARB")]
    TextureCubeMapARB = 34067,

    [NativeName("GL_TEXTURE_BINDING_CUBE_MAP_ARB")]
    TextureBindingCubeMapARB = 34068,

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_X_ARB")]
    TextureCubeMapPositiveXARB = 34069,

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_X_ARB")]
    TextureCubeMapNegativeXARB = 34070,

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Y_ARB")]
    TextureCubeMapPositiveYARB = 34071,

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB")]
    TextureCubeMapNegativeYARB = 34072,

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Z_ARB")]
    TextureCubeMapPositiveZARB = 34073,

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB")]
    TextureCubeMapNegativeZARB = 34074,

    [NativeName("GL_PROXY_TEXTURE_CUBE_MAP_ARB")]
    ProxyTextureCubeMapARB = 34075,

    [NativeName("GL_MAX_CUBE_MAP_TEXTURE_SIZE_ARB")]
    MaxCubeMapTextureSizeARB = 34076,

    [NativeName("GL_TEXTURE_CUBE_MAP_ARRAY_ARB")]
    TextureCubeMapArrayARB = 36873,

    [NativeName("GL_TEXTURE_BINDING_CUBE_MAP_ARRAY_ARB")]
    TextureBindingCubeMapArrayARB = 36874,

    [NativeName("GL_PROXY_TEXTURE_CUBE_MAP_ARRAY_ARB")]
    ProxyTextureCubeMapArrayARB = 36875,

    [NativeName("GL_SAMPLER_CUBE_MAP_ARRAY_ARB")]
    SamplerCubeMapArrayARB = 36876,

    [NativeName("GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW_ARB")]
    SamplerCubeMapArrayShadowARB = 36877,

    [NativeName("GL_INT_SAMPLER_CUBE_MAP_ARRAY_ARB")]
    IntSamplerCubeMapArrayARB = 36878,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_ARB")]
    UnsignedIntSamplerCubeMapArrayARB = 36879,

    [NativeName("GL_COMBINE_ARB")]
    CombineARB = 34160,

    [NativeName("GL_COMBINE_RGB_ARB")]
    CombineRgbARB = 34161,

    [NativeName("GL_COMBINE_ALPHA_ARB")]
    CombineAlphaARB = 34162,

    [NativeName("GL_SOURCE0_RGB_ARB")]
    Source0RgbARB = 34176,

    [NativeName("GL_SOURCE1_RGB_ARB")]
    Source1RgbARB = 34177,

    [NativeName("GL_SOURCE2_RGB_ARB")]
    Source2RgbARB = 34178,

    [NativeName("GL_SOURCE0_ALPHA_ARB")]
    Source0AlphaARB = 34184,

    [NativeName("GL_SOURCE1_ALPHA_ARB")]
    Source1AlphaARB = 34185,

    [NativeName("GL_SOURCE2_ALPHA_ARB")]
    Source2AlphaARB = 34186,

    [NativeName("GL_OPERAND0_RGB_ARB")]
    Operand0RgbARB = 34192,

    [NativeName("GL_OPERAND1_RGB_ARB")]
    Operand1RgbARB = 34193,

    [NativeName("GL_OPERAND2_RGB_ARB")]
    Operand2RgbARB = 34194,

    [NativeName("GL_OPERAND0_ALPHA_ARB")]
    Operand0AlphaARB = 34200,

    [NativeName("GL_OPERAND1_ALPHA_ARB")]
    Operand1AlphaARB = 34201,

    [NativeName("GL_OPERAND2_ALPHA_ARB")]
    Operand2AlphaARB = 34202,

    [NativeName("GL_RGB_SCALE_ARB")]
    RgbScaleARB = 34163,

    [NativeName("GL_ADD_SIGNED_ARB")]
    AddSignedARB = 34164,

    [NativeName("GL_INTERPOLATE_ARB")]
    InterpolateARB = 34165,

    [NativeName("GL_SUBTRACT_ARB")]
    SubtractARB = 34023,

    [NativeName("GL_CONSTANT_ARB")]
    ConstantARB = 34166,

    [NativeName("GL_PRIMARY_COLOR_ARB")]
    PrimaryColorARB = 34167,

    [NativeName("GL_PREVIOUS_ARB")]
    PreviousARB = 34168,

    [NativeName("GL_DOT3_RGB_ARB")]
    Dot3RgbARB = 34478,

    [NativeName("GL_DOT3_RGBA_ARB")]
    Dot3RgbaARB = 34479,

    [NativeName("GL_TEXTURE_REDUCTION_MODE_ARB")]
    TextureReductionModeARB = 37734,

    [NativeName("GL_WEIGHTED_AVERAGE_ARB")]
    WeightedAverageARB = 37735,

    [NativeName("GL_TEXTURE_RED_TYPE_ARB")]
    TextureRedTypeARB = 35856,

    [NativeName("GL_TEXTURE_GREEN_TYPE_ARB")]
    TextureGreenTypeARB = 35857,

    [NativeName("GL_TEXTURE_BLUE_TYPE_ARB")]
    TextureBlueTypeARB = 35858,

    [NativeName("GL_TEXTURE_ALPHA_TYPE_ARB")]
    TextureAlphaTypeARB = 35859,

    [NativeName("GL_TEXTURE_LUMINANCE_TYPE_ARB")]
    TextureLuminanceTypeARB = 35860,

    [NativeName("GL_TEXTURE_INTENSITY_TYPE_ARB")]
    TextureIntensityTypeARB = 35861,

    [NativeName("GL_TEXTURE_DEPTH_TYPE_ARB")]
    TextureDepthTypeARB = 35862,

    [NativeName("GL_UNSIGNED_NORMALIZED_ARB")]
    UnsignedNormalizedARB = 35863,

    [NativeName("GL_RGBA32F_ARB")]
    Rgba32FARB = 34836,

    [NativeName("GL_RGB32F_ARB")]
    Rgb32FARB = 34837,

    [NativeName("GL_ALPHA32F_ARB")]
    Alpha32FARB = 34838,

    [NativeName("GL_INTENSITY32F_ARB")]
    Intensity32FARB = 34839,

    [NativeName("GL_LUMINANCE32F_ARB")]
    Luminance32FARB = 34840,

    [NativeName("GL_LUMINANCE_ALPHA32F_ARB")]
    LuminanceAlpha32FARB = 34841,

    [NativeName("GL_RGBA16F_ARB")]
    Rgba16FARB = 34842,

    [NativeName("GL_RGB16F_ARB")]
    Rgb16FARB = 34843,

    [NativeName("GL_ALPHA16F_ARB")]
    Alpha16FARB = 34844,

    [NativeName("GL_INTENSITY16F_ARB")]
    Intensity16FARB = 34845,

    [NativeName("GL_LUMINANCE16F_ARB")]
    Luminance16FARB = 34846,

    [NativeName("GL_LUMINANCE_ALPHA16F_ARB")]
    LuminanceAlpha16FARB = 34847,

    [NativeName("GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET_ARB")]
    MinProgramTextureGatherOffsetARB = 36446,

    [NativeName("GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET_ARB")]
    MaxProgramTextureGatherOffsetARB = 36447,

    [NativeName("GL_MAX_PROGRAM_TEXTURE_GATHER_COMPONENTS_ARB")]
    MaxProgramTextureGatherComponentsARB = 36767,

    [NativeName("GL_MIRRORED_REPEAT_ARB")]
    MirroredRepeatARB = 33648,

    [NativeName("GL_TEXTURE_RECTANGLE_ARB")]
    TextureRectangleARB = 34037,

    [NativeName("GL_TEXTURE_BINDING_RECTANGLE_ARB")]
    TextureBindingRectangleARB = 34038,

    [NativeName("GL_PROXY_TEXTURE_RECTANGLE_ARB")]
    ProxyTextureRectangleARB = 34039,

    [NativeName("GL_MAX_RECTANGLE_TEXTURE_SIZE_ARB")]
    MaxRectangleTextureSizeARB = 34040,

    [NativeName("GL_TRANSFORM_FEEDBACK_OVERFLOW_ARB")]
    TransformFeedbackOverflowARB = 33516,

    [NativeName("GL_TRANSFORM_FEEDBACK_STREAM_OVERFLOW_ARB")]
    TransformFeedbackStreamOverflowARB = 33517,

    [NativeName("GL_TRANSPOSE_MODELVIEW_MATRIX_ARB")]
    TransposeModelviewMatrixARB = 34019,

    [NativeName("GL_TRANSPOSE_PROJECTION_MATRIX_ARB")]
    TransposeProjectionMatrixARB = 34020,

    [NativeName("GL_TRANSPOSE_TEXTURE_MATRIX_ARB")]
    TransposeTextureMatrixARB = 34021,

    [NativeName("GL_TRANSPOSE_COLOR_MATRIX_ARB")]
    TransposeColorMatrixARB = 34022,

    [NativeName("GL_MAX_VERTEX_UNITS_ARB")]
    MaxVertexUnitsARB = 34468,

    [NativeName("GL_ACTIVE_VERTEX_UNITS_ARB")]
    ActiveVertexUnitsARB = 34469,

    [NativeName("GL_WEIGHT_SUM_UNITY_ARB")]
    WeightSumUnityARB = 34470,

    [NativeName("GL_VERTEX_BLEND_ARB")]
    VertexBlendARB = 34471,

    [NativeName("GL_CURRENT_WEIGHT_ARB")]
    CurrentWeightARB = 34472,

    [NativeName("GL_WEIGHT_ARRAY_TYPE_ARB")]
    WeightArrayTypeARB = 34473,

    [NativeName("GL_WEIGHT_ARRAY_STRIDE_ARB")]
    WeightArrayStrideARB = 34474,

    [NativeName("GL_WEIGHT_ARRAY_SIZE_ARB")]
    WeightArraySizeARB = 34475,

    [NativeName("GL_WEIGHT_ARRAY_POINTER_ARB")]
    WeightArrayPointerARB = 34476,

    [NativeName("GL_WEIGHT_ARRAY_ARB")]
    WeightArrayARB = 34477,

    [NativeName("GL_MODELVIEW0_ARB")]
    Modelview0ARB = 5888,

    [NativeName("GL_MODELVIEW1_ARB")]
    Modelview1ARB = 34058,

    [NativeName("GL_MODELVIEW2_ARB")]
    Modelview2ARB = 34594,

    [NativeName("GL_MODELVIEW3_ARB")]
    Modelview3ARB = 34595,

    [NativeName("GL_MODELVIEW4_ARB")]
    Modelview4ARB = 34596,

    [NativeName("GL_MODELVIEW5_ARB")]
    Modelview5ARB = 34597,

    [NativeName("GL_MODELVIEW6_ARB")]
    Modelview6ARB = 34598,

    [NativeName("GL_MODELVIEW7_ARB")]
    Modelview7ARB = 34599,

    [NativeName("GL_MODELVIEW8_ARB")]
    Modelview8ARB = 34600,

    [NativeName("GL_MODELVIEW9_ARB")]
    Modelview9ARB = 34601,

    [NativeName("GL_MODELVIEW10_ARB")]
    Modelview10ARB = 34602,

    [NativeName("GL_MODELVIEW11_ARB")]
    Modelview11ARB = 34603,

    [NativeName("GL_MODELVIEW12_ARB")]
    Modelview12ARB = 34604,

    [NativeName("GL_MODELVIEW13_ARB")]
    Modelview13ARB = 34605,

    [NativeName("GL_MODELVIEW14_ARB")]
    Modelview14ARB = 34606,

    [NativeName("GL_MODELVIEW15_ARB")]
    Modelview15ARB = 34607,

    [NativeName("GL_MODELVIEW16_ARB")]
    Modelview16ARB = 34608,

    [NativeName("GL_MODELVIEW17_ARB")]
    Modelview17ARB = 34609,

    [NativeName("GL_MODELVIEW18_ARB")]
    Modelview18ARB = 34610,

    [NativeName("GL_MODELVIEW19_ARB")]
    Modelview19ARB = 34611,

    [NativeName("GL_MODELVIEW20_ARB")]
    Modelview20ARB = 34612,

    [NativeName("GL_MODELVIEW21_ARB")]
    Modelview21ARB = 34613,

    [NativeName("GL_MODELVIEW22_ARB")]
    Modelview22ARB = 34614,

    [NativeName("GL_MODELVIEW23_ARB")]
    Modelview23ARB = 34615,

    [NativeName("GL_MODELVIEW24_ARB")]
    Modelview24ARB = 34616,

    [NativeName("GL_MODELVIEW25_ARB")]
    Modelview25ARB = 34617,

    [NativeName("GL_MODELVIEW26_ARB")]
    Modelview26ARB = 34618,

    [NativeName("GL_MODELVIEW27_ARB")]
    Modelview27ARB = 34619,

    [NativeName("GL_MODELVIEW28_ARB")]
    Modelview28ARB = 34620,

    [NativeName("GL_MODELVIEW29_ARB")]
    Modelview29ARB = 34621,

    [NativeName("GL_MODELVIEW30_ARB")]
    Modelview30ARB = 34622,

    [NativeName("GL_MODELVIEW31_ARB")]
    Modelview31ARB = 34623,

    [NativeName("GL_BUFFER_SIZE_ARB")]
    BufferSizeARB = 34660,

    [NativeName("GL_BUFFER_USAGE_ARB")]
    BufferUsageARB = 34661,

    [NativeName("GL_ARRAY_BUFFER_ARB")]
    ArrayBufferARB = 34962,

    [NativeName("GL_ELEMENT_ARRAY_BUFFER_ARB")]
    ElementArrayBufferARB = 34963,

    [NativeName("GL_ARRAY_BUFFER_BINDING_ARB")]
    ArrayBufferBindingARB = 34964,

    [NativeName("GL_ELEMENT_ARRAY_BUFFER_BINDING_ARB")]
    ElementArrayBufferBindingARB = 34965,

    [NativeName("GL_VERTEX_ARRAY_BUFFER_BINDING_ARB")]
    VertexArrayBufferBindingARB = 34966,

    [NativeName("GL_NORMAL_ARRAY_BUFFER_BINDING_ARB")]
    NormalArrayBufferBindingARB = 34967,

    [NativeName("GL_COLOR_ARRAY_BUFFER_BINDING_ARB")]
    ColorArrayBufferBindingARB = 34968,

    [NativeName("GL_INDEX_ARRAY_BUFFER_BINDING_ARB")]
    IndexArrayBufferBindingARB = 34969,

    [NativeName("GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING_ARB")]
    TextureCoordArrayBufferBindingARB = 34970,

    [NativeName("GL_EDGE_FLAG_ARRAY_BUFFER_BINDING_ARB")]
    EdgeFlagArrayBufferBindingARB = 34971,

    [NativeName("GL_SECONDARY_COLOR_ARRAY_BUFFER_BINDING_ARB")]
    SecondaryColorArrayBufferBindingARB = 34972,

    [NativeName("GL_FOG_COORDINATE_ARRAY_BUFFER_BINDING_ARB")]
    FogCoordinateArrayBufferBindingARB = 34973,

    [NativeName("GL_WEIGHT_ARRAY_BUFFER_BINDING_ARB")]
    WeightArrayBufferBindingARB = 34974,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING_ARB")]
    VertexAttribArrayBufferBindingARB = 34975,

    [NativeName("GL_READ_ONLY_ARB")]
    ReadOnlyARB = 35000,

    [NativeName("GL_WRITE_ONLY_ARB")]
    WriteOnlyARB = 35001,

    [NativeName("GL_READ_WRITE_ARB")]
    ReadWriteARB = 35002,

    [NativeName("GL_BUFFER_ACCESS_ARB")]
    BufferAccessARB = 35003,

    [NativeName("GL_BUFFER_MAPPED_ARB")]
    BufferMappedARB = 35004,

    [NativeName("GL_BUFFER_MAP_POINTER_ARB")]
    BufferMapPointerARB = 35005,

    [NativeName("GL_STREAM_DRAW_ARB")]
    StreamDrawARB = 35040,

    [NativeName("GL_STREAM_READ_ARB")]
    StreamReadARB = 35041,

    [NativeName("GL_STREAM_COPY_ARB")]
    StreamCopyARB = 35042,

    [NativeName("GL_STATIC_DRAW_ARB")]
    StaticDrawARB = 35044,

    [NativeName("GL_STATIC_READ_ARB")]
    StaticReadARB = 35045,

    [NativeName("GL_STATIC_COPY_ARB")]
    StaticCopyARB = 35046,

    [NativeName("GL_DYNAMIC_DRAW_ARB")]
    DynamicDrawARB = 35048,

    [NativeName("GL_DYNAMIC_READ_ARB")]
    DynamicReadARB = 35049,

    [NativeName("GL_DYNAMIC_COPY_ARB")]
    DynamicCopyARB = 35050,

    [NativeName("GL_COLOR_SUM_ARB")]
    ColorSumARB = 33880,

    [NativeName("GL_VERTEX_PROGRAM_ARB")]
    VertexProgramARB = 34336,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_ENABLED_ARB")]
    VertexAttribArrayEnabledARB = 34338,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_SIZE_ARB")]
    VertexAttribArraySizeARB = 34339,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_STRIDE_ARB")]
    VertexAttribArrayStrideARB = 34340,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_TYPE_ARB")]
    VertexAttribArrayTypeARB = 34341,

    [NativeName("GL_CURRENT_VERTEX_ATTRIB_ARB")]
    CurrentVertexAttribARB = 34342,

    [NativeName("GL_VERTEX_PROGRAM_POINT_SIZE_ARB")]
    VertexProgramPointSizeARB = 34370,

    [NativeName("GL_VERTEX_PROGRAM_TWO_SIDE_ARB")]
    VertexProgramTwoSideARB = 34371,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_POINTER_ARB")]
    VertexAttribArrayPointerARB = 34373,

    [NativeName("GL_MAX_VERTEX_ATTRIBS_ARB")]
    MaxVertexAttribsARB = 34921,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_NORMALIZED_ARB")]
    VertexAttribArrayNormalizedARB = 34922,

    [NativeName("GL_PROGRAM_ADDRESS_REGISTERS_ARB")]
    ProgramAddressRegistersARB = 34992,

    [NativeName("GL_MAX_PROGRAM_ADDRESS_REGISTERS_ARB")]
    MaxProgramAddressRegistersARB = 34993,

    [NativeName("GL_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB")]
    ProgramNativeAddressRegistersARB = 34994,

    [NativeName("GL_MAX_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB")]
    MaxProgramNativeAddressRegistersARB = 34995,

    [NativeName("GL_VERTEX_SHADER_ARB")]
    VertexShaderARB = 35633,

    [NativeName("GL_MAX_VERTEX_UNIFORM_COMPONENTS_ARB")]
    MaxVertexUniformComponentsARB = 35658,

    [NativeName("GL_MAX_VARYING_FLOATS_ARB")]
    MaxVaryingFloatsARB = 35659,

    [NativeName("GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS_ARB")]
    MaxVertexTextureImageUnitsARB = 35660,

    [NativeName("GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS_ARB")]
    MaxCombinedTextureImageUnitsARB = 35661,

    [NativeName("GL_OBJECT_ACTIVE_ATTRIBUTES_ARB")]
    ObjectActiveAttributesARB = 35721,

    [NativeName("GL_OBJECT_ACTIVE_ATTRIBUTE_MAX_LENGTH_ARB")]
    ObjectActiveAttributeMaxLengthARB = 35722,

    [NativeName("GL_MULTIPLY_KHR")]
    MultiplyKHR = 37524,

    [NativeName("GL_SCREEN_KHR")]
    ScreenKHR = 37525,

    [NativeName("GL_OVERLAY_KHR")]
    OverlayKHR = 37526,

    [NativeName("GL_DARKEN_KHR")]
    DarkenKHR = 37527,

    [NativeName("GL_LIGHTEN_KHR")]
    LightenKHR = 37528,

    [NativeName("GL_COLORDODGE_KHR")]
    ColordodgeKHR = 37529,

    [NativeName("GL_COLORBURN_KHR")]
    ColorburnKHR = 37530,

    [NativeName("GL_HARDLIGHT_KHR")]
    HardlightKHR = 37531,

    [NativeName("GL_SOFTLIGHT_KHR")]
    SoftlightKHR = 37532,

    [NativeName("GL_DIFFERENCE_KHR")]
    DifferenceKHR = 37534,

    [NativeName("GL_EXCLUSION_KHR")]
    ExclusionKHR = 37536,

    [NativeName("GL_HSL_HUE_KHR")]
    HslHueKHR = 37549,

    [NativeName("GL_HSL_SATURATION_KHR")]
    HslSaturationKHR = 37550,

    [NativeName("GL_HSL_COLOR_KHR")]
    HslColorKHR = 37551,

    [NativeName("GL_HSL_LUMINOSITY_KHR")]
    HslLuminosityKHR = 37552,

    [NativeName("GL_BLEND_ADVANCED_COHERENT_KHR")]
    BlendAdvancedCoherentKHR = 37509,

    [NativeName("GL_CONTEXT_FLAG_NO_ERROR_BIT_KHR")]
    ContextFlagNoErrorBitKHR = 8,

    [NativeName("GL_MAX_SHADER_COMPILER_THREADS_KHR")]
    MaxShaderCompilerThreadsKHR = 37296,

    [NativeName("GL_COMPLETION_STATUS_KHR")]
    CompletionStatusKHR = 37297,

    [NativeName("GL_CONTEXT_ROBUST_ACCESS")]
    ContextRobustAccess = 37107,

    [NativeName("GL_SUBGROUP_SIZE_KHR")]
    SubgroupSizeKHR = 38194,

    [NativeName("GL_SUBGROUP_SUPPORTED_STAGES_KHR")]
    SubgroupSupportedStagesKHR = 38195,

    [NativeName("GL_SUBGROUP_SUPPORTED_FEATURES_KHR")]
    SubgroupSupportedFeaturesKHR = 38196,

    [NativeName("GL_SUBGROUP_QUAD_ALL_STAGES_KHR")]
    SubgroupQuadAllStagesKHR = 38197,

    [NativeName("GL_SUBGROUP_FEATURE_BASIC_BIT_KHR")]
    SubgroupFeatureBasicBitKHR = 1,

    [NativeName("GL_SUBGROUP_FEATURE_VOTE_BIT_KHR")]
    SubgroupFeatureVoteBitKHR = 2,

    [NativeName("GL_SUBGROUP_FEATURE_ARITHMETIC_BIT_KHR")]
    SubgroupFeatureArithmeticBitKHR = 4,

    [NativeName("GL_SUBGROUP_FEATURE_BALLOT_BIT_KHR")]
    SubgroupFeatureBallotBitKHR = 8,

    [NativeName("GL_SUBGROUP_FEATURE_SHUFFLE_BIT_KHR")]
    SubgroupFeatureShuffleBitKHR = 16,

    [NativeName("GL_SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT_KHR")]
    SubgroupFeatureShuffleRelativeBitKHR = 32,

    [NativeName("GL_SUBGROUP_FEATURE_CLUSTERED_BIT_KHR")]
    SubgroupFeatureClusteredBitKHR = 64,

    [NativeName("GL_SUBGROUP_FEATURE_QUAD_BIT_KHR")]
    SubgroupFeatureQuadBitKHR = 128,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_4x4_KHR")]
    CompressedRgbaAstc4X4KHR = 37808,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_5x4_KHR")]
    CompressedRgbaAstc5X4KHR = 37809,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_5x5_KHR")]
    CompressedRgbaAstc5X5KHR = 37810,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_6x5_KHR")]
    CompressedRgbaAstc6X5KHR = 37811,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_6x6_KHR")]
    CompressedRgbaAstc6X6KHR = 37812,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_8x5_KHR")]
    CompressedRgbaAstc8X5KHR = 37813,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_8x6_KHR")]
    CompressedRgbaAstc8X6KHR = 37814,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_8x8_KHR")]
    CompressedRgbaAstc8X8KHR = 37815,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_10x5_KHR")]
    CompressedRgbaAstc10X5KHR = 37816,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_10x6_KHR")]
    CompressedRgbaAstc10X6KHR = 37817,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_10x8_KHR")]
    CompressedRgbaAstc10X8KHR = 37818,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_10x10_KHR")]
    CompressedRgbaAstc10X10KHR = 37819,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_12x10_KHR")]
    CompressedRgbaAstc12X10KHR = 37820,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_12x12_KHR")]
    CompressedRgbaAstc12X12KHR = 37821,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR")]
    CompressedSrgb8Alpha8Astc4X4KHR = 37840,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4_KHR")]
    CompressedSrgb8Alpha8Astc5X4KHR = 37841,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5_KHR")]
    CompressedSrgb8Alpha8Astc5X5KHR = 37842,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5_KHR")]
    CompressedSrgb8Alpha8Astc6X5KHR = 37843,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6_KHR")]
    CompressedSrgb8Alpha8Astc6X6KHR = 37844,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x5_KHR")]
    CompressedSrgb8Alpha8Astc8X5KHR = 37845,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x6_KHR")]
    CompressedSrgb8Alpha8Astc8X6KHR = 37846,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x8_KHR")]
    CompressedSrgb8Alpha8Astc8X8KHR = 37847,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x5_KHR")]
    CompressedSrgb8Alpha8Astc10X5KHR = 37848,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x6_KHR")]
    CompressedSrgb8Alpha8Astc10X6KHR = 37849,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x8_KHR")]
    CompressedSrgb8Alpha8Astc10X8KHR = 37850,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x10_KHR")]
    CompressedSrgb8Alpha8Astc10X10KHR = 37851,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x10_KHR")]
    CompressedSrgb8Alpha8Astc12X10KHR = 37852,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x12_KHR")]
    CompressedSrgb8Alpha8Astc12X12KHR = 37853,

    [NativeName("GL_MULTISAMPLE_3DFX")]
    Multisample3DFX = 34482,

    [NativeName("GL_SAMPLE_BUFFERS_3DFX")]
    SampleBuffers3DFX = 34483,

    [NativeName("GL_SAMPLES_3DFX")]
    Samples3DFX = 34484,

    [NativeName("GL_MULTISAMPLE_BIT_3DFX")]
    MultisampleBit3DFX = 536870912,

    [NativeName("GL_COMPRESSED_RGB_FXT1_3DFX")]
    CompressedRgbFxt1X3DFX = 34480,

    [NativeName("GL_COMPRESSED_RGBA_FXT1_3DFX")]
    CompressedRgbaFxt1X3DFX = 34481,

    [NativeName("GL_FACTOR_MIN_AMD")]
    FactorMinAMD = 36892,

    [NativeName("GL_FACTOR_MAX_AMD")]
    FactorMaxAMD = 36893,

    [NativeName("GL_MAX_DEBUG_MESSAGE_LENGTH_AMD")]
    MaxDebugMessageLengthAMD = 37187,

    [NativeName("GL_MAX_DEBUG_LOGGED_MESSAGES_AMD")]
    MaxDebugLoggedMessagesAMD = 37188,

    [NativeName("GL_DEBUG_LOGGED_MESSAGES_AMD")]
    DebugLoggedMessagesAMD = 37189,

    [NativeName("GL_DEBUG_SEVERITY_HIGH_AMD")]
    DebugSeverityHighAMD = 37190,

    [NativeName("GL_DEBUG_SEVERITY_MEDIUM_AMD")]
    DebugSeverityMediumAMD = 37191,

    [NativeName("GL_DEBUG_SEVERITY_LOW_AMD")]
    DebugSeverityLowAMD = 37192,

    [NativeName("GL_DEBUG_CATEGORY_API_ERROR_AMD")]
    DebugCategoryApiErrorAMD = 37193,

    [NativeName("GL_DEBUG_CATEGORY_WINDOW_SYSTEM_AMD")]
    DebugCategoryWindowSystemAMD = 37194,

    [NativeName("GL_DEBUG_CATEGORY_DEPRECATION_AMD")]
    DebugCategoryDeprecationAMD = 37195,

    [NativeName("GL_DEBUG_CATEGORY_UNDEFINED_BEHAVIOR_AMD")]
    DebugCategoryUndefinedBehaviorAMD = 37196,

    [NativeName("GL_DEBUG_CATEGORY_PERFORMANCE_AMD")]
    DebugCategoryPerformanceAMD = 37197,

    [NativeName("GL_DEBUG_CATEGORY_SHADER_COMPILER_AMD")]
    DebugCategoryShaderCompilerAMD = 37198,

    [NativeName("GL_DEBUG_CATEGORY_APPLICATION_AMD")]
    DebugCategoryApplicationAMD = 37199,

    [NativeName("GL_DEBUG_CATEGORY_OTHER_AMD")]
    DebugCategoryOtherAMD = 37200,

    [NativeName("GL_DEPTH_CLAMP_NEAR_AMD")]
    DepthClampNearAMD = 36894,

    [NativeName("GL_DEPTH_CLAMP_FAR_AMD")]
    DepthClampFarAMD = 36895,

    [NativeName("GL_RENDERBUFFER_STORAGE_SAMPLES_AMD")]
    RenderbufferStorageSamplesAMD = 37298,

    [NativeName("GL_MAX_COLOR_FRAMEBUFFER_SAMPLES_AMD")]
    MaxColorFramebufferSamplesAMD = 37299,

    [NativeName("GL_MAX_COLOR_FRAMEBUFFER_STORAGE_SAMPLES_AMD")]
    MaxColorFramebufferStorageSamplesAMD = 37300,

    [NativeName("GL_MAX_DEPTH_STENCIL_FRAMEBUFFER_SAMPLES_AMD")]
    MaxDepthStencilFramebufferSamplesAMD = 37301,

    [NativeName("GL_NUM_SUPPORTED_MULTISAMPLE_MODES_AMD")]
    NumSupportedMultisampleModesAMD = 37302,

    [NativeName("GL_SUPPORTED_MULTISAMPLE_MODES_AMD")]
    SupportedMultisampleModesAMD = 37303,

    [NativeName("GL_SUBSAMPLE_DISTANCE_AMD")]
    SubsampleDistanceAMD = 34879,

    [NativeName("GL_PIXELS_PER_SAMPLE_PATTERN_X_AMD")]
    PixelsPerSamplePatternXAMD = 37294,

    [NativeName("GL_PIXELS_PER_SAMPLE_PATTERN_Y_AMD")]
    PixelsPerSamplePatternYAMD = 37295,

    [NativeName("GL_ALL_PIXELS_AMD")]
    AllPixelsAMD = 4294967295,

    [NativeName("GL_FLOAT16_NV")]
    Float16NV = 36856,

    [NativeName("GL_FLOAT16_VEC2_NV")]
    Float16Vec2NV = 36857,

    [NativeName("GL_FLOAT16_VEC3_NV")]
    Float16Vec3NV = 36858,

    [NativeName("GL_FLOAT16_VEC4_NV")]
    Float16Vec4NV = 36859,

    [NativeName("GL_FLOAT16_MAT2_AMD")]
    Float16Mat2AMD = 37317,

    [NativeName("GL_FLOAT16_MAT3_AMD")]
    Float16Mat3AMD = 37318,

    [NativeName("GL_FLOAT16_MAT4_AMD")]
    Float16Mat4AMD = 37319,

    [NativeName("GL_FLOAT16_MAT2x3_AMD")]
    Float16Mat2X3AMD = 37320,

    [NativeName("GL_FLOAT16_MAT2x4_AMD")]
    Float16Mat2X4AMD = 37321,

    [NativeName("GL_FLOAT16_MAT3x2_AMD")]
    Float16Mat3X2AMD = 37322,

    [NativeName("GL_FLOAT16_MAT3x4_AMD")]
    Float16Mat3X4AMD = 37323,

    [NativeName("GL_FLOAT16_MAT4x2_AMD")]
    Float16Mat4X2AMD = 37324,

    [NativeName("GL_FLOAT16_MAT4x3_AMD")]
    Float16Mat4X3AMD = 37325,

    [NativeName("GL_INT64_NV")]
    Int64NV = 5134,

    [NativeName("GL_UNSIGNED_INT64_NV")]
    UnsignedInt64NV = 5135,

    [NativeName("GL_INT8_NV")]
    Int8NV = 36832,

    [NativeName("GL_INT8_VEC2_NV")]
    Int8Vec2NV = 36833,

    [NativeName("GL_INT8_VEC3_NV")]
    Int8Vec3NV = 36834,

    [NativeName("GL_INT8_VEC4_NV")]
    Int8Vec4NV = 36835,

    [NativeName("GL_INT16_NV")]
    Int16NV = 36836,

    [NativeName("GL_INT16_VEC2_NV")]
    Int16Vec2NV = 36837,

    [NativeName("GL_INT16_VEC3_NV")]
    Int16Vec3NV = 36838,

    [NativeName("GL_INT16_VEC4_NV")]
    Int16Vec4NV = 36839,

    [NativeName("GL_INT64_VEC2_NV")]
    Int64Vec2NV = 36841,

    [NativeName("GL_INT64_VEC3_NV")]
    Int64Vec3NV = 36842,

    [NativeName("GL_INT64_VEC4_NV")]
    Int64Vec4NV = 36843,

    [NativeName("GL_UNSIGNED_INT8_NV")]
    UnsignedInt8NV = 36844,

    [NativeName("GL_UNSIGNED_INT8_VEC2_NV")]
    UnsignedInt8Vec2NV = 36845,

    [NativeName("GL_UNSIGNED_INT8_VEC3_NV")]
    UnsignedInt8Vec3NV = 36846,

    [NativeName("GL_UNSIGNED_INT8_VEC4_NV")]
    UnsignedInt8Vec4NV = 36847,

    [NativeName("GL_UNSIGNED_INT16_NV")]
    UnsignedInt16NV = 36848,

    [NativeName("GL_UNSIGNED_INT16_VEC2_NV")]
    UnsignedInt16Vec2NV = 36849,

    [NativeName("GL_UNSIGNED_INT16_VEC3_NV")]
    UnsignedInt16Vec3NV = 36850,

    [NativeName("GL_UNSIGNED_INT16_VEC4_NV")]
    UnsignedInt16Vec4NV = 36851,

    [NativeName("GL_UNSIGNED_INT64_VEC2_NV")]
    UnsignedInt64Vec2NV = 36853,

    [NativeName("GL_UNSIGNED_INT64_VEC3_NV")]
    UnsignedInt64Vec3NV = 36854,

    [NativeName("GL_UNSIGNED_INT64_VEC4_NV")]
    UnsignedInt64Vec4NV = 36855,

    [NativeName("GL_VERTEX_ELEMENT_SWIZZLE_AMD")]
    VertexElementSwizzleAMD = 37284,

    [NativeName("GL_VERTEX_ID_SWIZZLE_AMD")]
    VertexIdSwizzleAMD = 37285,

    [NativeName("GL_DATA_BUFFER_AMD")]
    DataBufferAMD = 37201,

    [NativeName("GL_PERFORMANCE_MONITOR_AMD")]
    PerformanceMonitorAMD = 37202,

    [NativeName("GL_QUERY_OBJECT_AMD")]
    QueryObjectAMD = 37203,

    [NativeName("GL_VERTEX_ARRAY_OBJECT_AMD")]
    VertexArrayObjectAMD = 37204,

    [NativeName("GL_SAMPLER_OBJECT_AMD")]
    SamplerObjectAMD = 37205,

    [NativeName("GL_OCCLUSION_QUERY_EVENT_MASK_AMD")]
    OcclusionQueryEventMaskAMD = 34639,

    [NativeName("GL_QUERY_DEPTH_PASS_EVENT_BIT_AMD")]
    QueryDepthPassEventBitAMD = 1,

    [NativeName("GL_QUERY_DEPTH_FAIL_EVENT_BIT_AMD")]
    QueryDepthFailEventBitAMD = 2,

    [NativeName("GL_QUERY_STENCIL_FAIL_EVENT_BIT_AMD")]
    QueryStencilFailEventBitAMD = 4,

    [NativeName("GL_QUERY_DEPTH_BOUNDS_FAIL_EVENT_BIT_AMD")]
    QueryDepthBoundsFailEventBitAMD = 8,

    [NativeName("GL_QUERY_ALL_EVENT_BITS_AMD")]
    QueryAllEventBitsAMD = 4294967295,

    [NativeName("GL_COUNTER_TYPE_AMD")]
    CounterTypeAMD = 35776,

    [NativeName("GL_COUNTER_RANGE_AMD")]
    CounterRangeAMD = 35777,

    [NativeName("GL_UNSIGNED_INT64_AMD")]
    UnsignedInt64AMD = 35778,

    [NativeName("GL_PERCENTAGE_AMD")]
    PercentageAMD = 35779,

    [NativeName("GL_PERFMON_RESULT_AVAILABLE_AMD")]
    PerfmonResultAvailableAMD = 35780,

    [NativeName("GL_PERFMON_RESULT_SIZE_AMD")]
    PerfmonResultSizeAMD = 35781,

    [NativeName("GL_PERFMON_RESULT_AMD")]
    PerfmonResultAMD = 35782,

    [NativeName("GL_EXTERNAL_VIRTUAL_MEMORY_BUFFER_AMD")]
    ExternalVirtualMemoryBufferAMD = 37216,

    [NativeName("GL_QUERY_BUFFER_AMD")]
    QueryBufferAMD = 37266,

    [NativeName("GL_QUERY_BUFFER_BINDING_AMD")]
    QueryBufferBindingAMD = 37267,

    [NativeName("GL_QUERY_RESULT_NO_WAIT_AMD")]
    QueryResultNoWaitAMD = 37268,

    [NativeName("GL_VIRTUAL_PAGE_SIZE_X_AMD")]
    VirtualPageSizeXAMD = 37269,

    [NativeName("GL_VIRTUAL_PAGE_SIZE_Y_AMD")]
    VirtualPageSizeYAMD = 37270,

    [NativeName("GL_VIRTUAL_PAGE_SIZE_Z_AMD")]
    VirtualPageSizeZAMD = 37271,

    [NativeName("GL_MAX_SPARSE_TEXTURE_SIZE_AMD")]
    MaxSparseTextureSizeAMD = 37272,

    [NativeName("GL_MAX_SPARSE_3D_TEXTURE_SIZE_AMD")]
    MaxSparse3DTextureSizeAMD = 37273,

    [NativeName("GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS")]
    MaxSparseArrayTextureLayers = 37274,

    [NativeName("GL_MIN_SPARSE_LEVEL_AMD")]
    MinSparseLevelAMD = 37275,

    [NativeName("GL_MIN_LOD_WARNING_AMD")]
    MinLodWarningAMD = 37276,

    [NativeName("GL_TEXTURE_STORAGE_SPARSE_BIT_AMD")]
    TextureStorageSparseBitAMD = 1,

    [NativeName("GL_SET_AMD")]
    SetAMD = 34634,

    [NativeName("GL_REPLACE_VALUE_AMD")]
    ReplaceValueAMD = 34635,

    [NativeName("GL_STENCIL_OP_VALUE_AMD")]
    StencilOpValueAMD = 34636,

    [NativeName("GL_STENCIL_BACK_OP_VALUE_AMD")]
    StencilBackOpValueAMD = 34637,

    [NativeName("GL_STREAM_RASTERIZATION_AMD")]
    StreamRasterizationAMD = 37280,

    [NativeName("GL_SAMPLER_BUFFER_AMD")]
    SamplerBufferAMD = 36865,

    [NativeName("GL_INT_SAMPLER_BUFFER_AMD")]
    IntSamplerBufferAMD = 36866,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_BUFFER_AMD")]
    UnsignedIntSamplerBufferAMD = 36867,

    [NativeName("GL_TESSELLATION_MODE_AMD")]
    TessellationModeAMD = 36868,

    [NativeName("GL_TESSELLATION_FACTOR_AMD")]
    TessellationFactorAMD = 36869,

    [NativeName("GL_DISCRETE_AMD")]
    DiscreteAMD = 36870,

    [NativeName("GL_CONTINUOUS_AMD")]
    ContinuousAMD = 36871,

    [NativeName("GL_AUX_DEPTH_STENCIL_APPLE")]
    AuxDepthStencilAPPLE = 35348,

    [NativeName("GL_UNPACK_CLIENT_STORAGE_APPLE")]
    UnpackClientStorageAPPLE = 34226,

    [NativeName("GL_ELEMENT_ARRAY_APPLE")]
    ElementArrayAPPLE = 35340,

    [NativeName("GL_ELEMENT_ARRAY_TYPE_APPLE")]
    ElementArrayTypeAPPLE = 35341,

    [NativeName("GL_ELEMENT_ARRAY_POINTER_APPLE")]
    ElementArrayPointerAPPLE = 35342,

    [NativeName("GL_DRAW_PIXELS_APPLE")]
    DrawPixelsAPPLE = 35338,

    [NativeName("GL_FENCE_APPLE")]
    FenceAPPLE = 35339,

    [NativeName("GL_HALF_APPLE")]
    HalfAPPLE = 5131,

    [NativeName("GL_RGBA_FLOAT32_APPLE")]
    RgbaFloat32APPLE = 34836,

    [NativeName("GL_RGB_FLOAT32_APPLE")]
    RgbFloat32APPLE = 34837,

    [NativeName("GL_ALPHA_FLOAT32_APPLE")]
    AlphaFloat32APPLE = 34838,

    [NativeName("GL_INTENSITY_FLOAT32_APPLE")]
    IntensityFloat32APPLE = 34839,

    [NativeName("GL_LUMINANCE_FLOAT32_APPLE")]
    LuminanceFloat32APPLE = 34840,

    [NativeName("GL_LUMINANCE_ALPHA_FLOAT32_APPLE")]
    LuminanceAlphaFloat32APPLE = 34841,

    [NativeName("GL_RGBA_FLOAT16_APPLE")]
    RgbaFloat16APPLE = 34842,

    [NativeName("GL_RGB_FLOAT16_APPLE")]
    RgbFloat16APPLE = 34843,

    [NativeName("GL_ALPHA_FLOAT16_APPLE")]
    AlphaFloat16APPLE = 34844,

    [NativeName("GL_INTENSITY_FLOAT16_APPLE")]
    IntensityFloat16APPLE = 34845,

    [NativeName("GL_LUMINANCE_FLOAT16_APPLE")]
    LuminanceFloat16APPLE = 34846,

    [NativeName("GL_LUMINANCE_ALPHA_FLOAT16_APPLE")]
    LuminanceAlphaFloat16APPLE = 34847,

    [NativeName("GL_COLOR_FLOAT_APPLE")]
    ColorFloatAPPLE = 35343,

    [NativeName("GL_BUFFER_SERIALIZED_MODIFY_APPLE")]
    BufferSerializedModifyAPPLE = 35346,

    [NativeName("GL_BUFFER_FLUSHING_UNMAP_APPLE")]
    BufferFlushingUnmapAPPLE = 35347,

    [NativeName("GL_BUFFER_OBJECT_APPLE")]
    BufferObjectAPPLE = 34227,

    [NativeName("GL_RELEASED_APPLE")]
    ReleasedAPPLE = 35353,

    [NativeName("GL_VOLATILE_APPLE")]
    VolatileAPPLE = 35354,

    [NativeName("GL_RETAINED_APPLE")]
    RetainedAPPLE = 35355,

    [NativeName("GL_UNDEFINED_APPLE")]
    UndefinedAPPLE = 35356,

    [NativeName("GL_PURGEABLE_APPLE")]
    PurgeableAPPLE = 35357,

    [NativeName("GL_RGB_422_APPLE")]
    Rgb422APPLE = 35359,

    [NativeName("GL_UNSIGNED_SHORT_8_8_APPLE")]
    UnsignedShort8X8APPLE = 34234,

    [NativeName("GL_UNSIGNED_SHORT_8_8_REV_APPLE")]
    UnsignedShort8X8RevAPPLE = 34235,

    [NativeName("GL_RGB_RAW_422_APPLE")]
    RgbRaw422APPLE = 35409,

    [NativeName("GL_PACK_ROW_BYTES_APPLE")]
    PackRowBytesAPPLE = 35349,

    [NativeName("GL_UNPACK_ROW_BYTES_APPLE")]
    UnpackRowBytesAPPLE = 35350,

    [NativeName("GL_LIGHT_MODEL_SPECULAR_VECTOR_APPLE")]
    LightModelSpecularVectorAPPLE = 34224,

    [NativeName("GL_TEXTURE_RANGE_LENGTH_APPLE")]
    TextureRangeLengthAPPLE = 34231,

    [NativeName("GL_TEXTURE_RANGE_POINTER_APPLE")]
    TextureRangePointerAPPLE = 34232,

    [NativeName("GL_TEXTURE_STORAGE_HINT_APPLE")]
    TextureStorageHintAPPLE = 34236,

    [NativeName("GL_STORAGE_PRIVATE_APPLE")]
    StoragePrivateAPPLE = 34237,

    [NativeName("GL_STORAGE_CACHED_APPLE")]
    StorageCachedAPPLE = 34238,

    [NativeName("GL_STORAGE_SHARED_APPLE")]
    StorageSharedAPPLE = 34239,

    [NativeName("GL_TRANSFORM_HINT_APPLE")]
    TransformHintAPPLE = 34225,

    [NativeName("GL_VERTEX_ARRAY_BINDING_APPLE")]
    VertexArrayBindingAPPLE = 34229,

    [NativeName("GL_VERTEX_ARRAY_RANGE_APPLE")]
    VertexArrayRangeAPPLE = 34077,

    [NativeName("GL_VERTEX_ARRAY_RANGE_LENGTH_APPLE")]
    VertexArrayRangeLengthAPPLE = 34078,

    [NativeName("GL_VERTEX_ARRAY_STORAGE_HINT_APPLE")]
    VertexArrayStorageHintAPPLE = 34079,

    [NativeName("GL_VERTEX_ARRAY_RANGE_POINTER_APPLE")]
    VertexArrayRangePointerAPPLE = 34081,

    [NativeName("GL_STORAGE_CLIENT_APPLE")]
    StorageClientAPPLE = 34228,

    [NativeName("GL_VERTEX_ATTRIB_MAP1_APPLE")]
    VertexAttribMap1APPLE = 35328,

    [NativeName("GL_VERTEX_ATTRIB_MAP2_APPLE")]
    VertexAttribMap2APPLE = 35329,

    [NativeName("GL_VERTEX_ATTRIB_MAP1_SIZE_APPLE")]
    VertexAttribMap1SizeAPPLE = 35330,

    [NativeName("GL_VERTEX_ATTRIB_MAP1_COEFF_APPLE")]
    VertexAttribMap1CoeffAPPLE = 35331,

    [NativeName("GL_VERTEX_ATTRIB_MAP1_ORDER_APPLE")]
    VertexAttribMap1OrderAPPLE = 35332,

    [NativeName("GL_VERTEX_ATTRIB_MAP1_DOMAIN_APPLE")]
    VertexAttribMap1DomainAPPLE = 35333,

    [NativeName("GL_VERTEX_ATTRIB_MAP2_SIZE_APPLE")]
    VertexAttribMap2SizeAPPLE = 35334,

    [NativeName("GL_VERTEX_ATTRIB_MAP2_COEFF_APPLE")]
    VertexAttribMap2CoeffAPPLE = 35335,

    [NativeName("GL_VERTEX_ATTRIB_MAP2_ORDER_APPLE")]
    VertexAttribMap2OrderAPPLE = 35336,

    [NativeName("GL_VERTEX_ATTRIB_MAP2_DOMAIN_APPLE")]
    VertexAttribMap2DomainAPPLE = 35337,

    [NativeName("GL_YCBCR_422_APPLE")]
    Ycbcr422APPLE = 34233,

    [NativeName("GL_MAX_DRAW_BUFFERS_ATI")]
    MaxDrawBuffersATI = 34852,

    [NativeName("GL_DRAW_BUFFER0_ATI")]
    DrawBuffer0ATI = 34853,

    [NativeName("GL_DRAW_BUFFER1_ATI")]
    DrawBuffer1ATI = 34854,

    [NativeName("GL_DRAW_BUFFER2_ATI")]
    DrawBuffer2ATI = 34855,

    [NativeName("GL_DRAW_BUFFER3_ATI")]
    DrawBuffer3ATI = 34856,

    [NativeName("GL_DRAW_BUFFER4_ATI")]
    DrawBuffer4ATI = 34857,

    [NativeName("GL_DRAW_BUFFER5_ATI")]
    DrawBuffer5ATI = 34858,

    [NativeName("GL_DRAW_BUFFER6_ATI")]
    DrawBuffer6ATI = 34859,

    [NativeName("GL_DRAW_BUFFER7_ATI")]
    DrawBuffer7ATI = 34860,

    [NativeName("GL_DRAW_BUFFER8_ATI")]
    DrawBuffer8ATI = 34861,

    [NativeName("GL_DRAW_BUFFER9_ATI")]
    DrawBuffer9ATI = 34862,

    [NativeName("GL_DRAW_BUFFER10_ATI")]
    DrawBuffer10ATI = 34863,

    [NativeName("GL_DRAW_BUFFER11_ATI")]
    DrawBuffer11ATI = 34864,

    [NativeName("GL_DRAW_BUFFER12_ATI")]
    DrawBuffer12ATI = 34865,

    [NativeName("GL_DRAW_BUFFER13_ATI")]
    DrawBuffer13ATI = 34866,

    [NativeName("GL_DRAW_BUFFER14_ATI")]
    DrawBuffer14ATI = 34867,

    [NativeName("GL_DRAW_BUFFER15_ATI")]
    DrawBuffer15ATI = 34868,

    [NativeName("GL_ELEMENT_ARRAY_ATI")]
    ElementArrayATI = 34664,

    [NativeName("GL_ELEMENT_ARRAY_TYPE_ATI")]
    ElementArrayTypeATI = 34665,

    [NativeName("GL_ELEMENT_ARRAY_POINTER_ATI")]
    ElementArrayPointerATI = 34666,

    [NativeName("GL_BUMP_ROT_MATRIX_ATI")]
    BumpRotMatrixATI = 34677,

    [NativeName("GL_BUMP_ROT_MATRIX_SIZE_ATI")]
    BumpRotMatrixSizeATI = 34678,

    [NativeName("GL_BUMP_NUM_TEX_UNITS_ATI")]
    BumpNumTexUnitsATI = 34679,

    [NativeName("GL_BUMP_TEX_UNITS_ATI")]
    BumpTexUnitsATI = 34680,

    [NativeName("GL_DUDV_ATI")]
    DudvATI = 34681,

    [NativeName("GL_DU8DV8_ATI")]
    Du8Dv8ATI = 34682,

    [NativeName("GL_BUMP_ENVMAP_ATI")]
    BumpEnvmapATI = 34683,

    [NativeName("GL_BUMP_TARGET_ATI")]
    BumpTargetATI = 34684,

    [NativeName("GL_FRAGMENT_SHADER_ATI")]
    FragmentShaderATI = 35104,

    [NativeName("GL_REG_0_ATI")]
    Reg0ATI = 35105,

    [NativeName("GL_REG_1_ATI")]
    Reg1ATI = 35106,

    [NativeName("GL_REG_2_ATI")]
    Reg2ATI = 35107,

    [NativeName("GL_REG_3_ATI")]
    Reg3ATI = 35108,

    [NativeName("GL_REG_4_ATI")]
    Reg4ATI = 35109,

    [NativeName("GL_REG_5_ATI")]
    Reg5ATI = 35110,

    [NativeName("GL_REG_6_ATI")]
    Reg6ATI = 35111,

    [NativeName("GL_REG_7_ATI")]
    Reg7ATI = 35112,

    [NativeName("GL_REG_8_ATI")]
    Reg8ATI = 35113,

    [NativeName("GL_REG_9_ATI")]
    Reg9ATI = 35114,

    [NativeName("GL_REG_10_ATI")]
    Reg10ATI = 35115,

    [NativeName("GL_REG_11_ATI")]
    Reg11ATI = 35116,

    [NativeName("GL_REG_12_ATI")]
    Reg12ATI = 35117,

    [NativeName("GL_REG_13_ATI")]
    Reg13ATI = 35118,

    [NativeName("GL_REG_14_ATI")]
    Reg14ATI = 35119,

    [NativeName("GL_REG_15_ATI")]
    Reg15ATI = 35120,

    [NativeName("GL_REG_16_ATI")]
    Reg16ATI = 35121,

    [NativeName("GL_REG_17_ATI")]
    Reg17ATI = 35122,

    [NativeName("GL_REG_18_ATI")]
    Reg18ATI = 35123,

    [NativeName("GL_REG_19_ATI")]
    Reg19ATI = 35124,

    [NativeName("GL_REG_20_ATI")]
    Reg20ATI = 35125,

    [NativeName("GL_REG_21_ATI")]
    Reg21ATI = 35126,

    [NativeName("GL_REG_22_ATI")]
    Reg22ATI = 35127,

    [NativeName("GL_REG_23_ATI")]
    Reg23ATI = 35128,

    [NativeName("GL_REG_24_ATI")]
    Reg24ATI = 35129,

    [NativeName("GL_REG_25_ATI")]
    Reg25ATI = 35130,

    [NativeName("GL_REG_26_ATI")]
    Reg26ATI = 35131,

    [NativeName("GL_REG_27_ATI")]
    Reg27ATI = 35132,

    [NativeName("GL_REG_28_ATI")]
    Reg28ATI = 35133,

    [NativeName("GL_REG_29_ATI")]
    Reg29ATI = 35134,

    [NativeName("GL_REG_30_ATI")]
    Reg30ATI = 35135,

    [NativeName("GL_REG_31_ATI")]
    Reg31ATI = 35136,

    [NativeName("GL_CON_0_ATI")]
    Con0ATI = 35137,

    [NativeName("GL_CON_1_ATI")]
    Con1ATI = 35138,

    [NativeName("GL_CON_2_ATI")]
    Con2ATI = 35139,

    [NativeName("GL_CON_3_ATI")]
    Con3ATI = 35140,

    [NativeName("GL_CON_4_ATI")]
    Con4ATI = 35141,

    [NativeName("GL_CON_5_ATI")]
    Con5ATI = 35142,

    [NativeName("GL_CON_6_ATI")]
    Con6ATI = 35143,

    [NativeName("GL_CON_7_ATI")]
    Con7ATI = 35144,

    [NativeName("GL_CON_8_ATI")]
    Con8ATI = 35145,

    [NativeName("GL_CON_9_ATI")]
    Con9ATI = 35146,

    [NativeName("GL_CON_10_ATI")]
    Con10ATI = 35147,

    [NativeName("GL_CON_11_ATI")]
    Con11ATI = 35148,

    [NativeName("GL_CON_12_ATI")]
    Con12ATI = 35149,

    [NativeName("GL_CON_13_ATI")]
    Con13ATI = 35150,

    [NativeName("GL_CON_14_ATI")]
    Con14ATI = 35151,

    [NativeName("GL_CON_15_ATI")]
    Con15ATI = 35152,

    [NativeName("GL_CON_16_ATI")]
    Con16ATI = 35153,

    [NativeName("GL_CON_17_ATI")]
    Con17ATI = 35154,

    [NativeName("GL_CON_18_ATI")]
    Con18ATI = 35155,

    [NativeName("GL_CON_19_ATI")]
    Con19ATI = 35156,

    [NativeName("GL_CON_20_ATI")]
    Con20ATI = 35157,

    [NativeName("GL_CON_21_ATI")]
    Con21ATI = 35158,

    [NativeName("GL_CON_22_ATI")]
    Con22ATI = 35159,

    [NativeName("GL_CON_23_ATI")]
    Con23ATI = 35160,

    [NativeName("GL_CON_24_ATI")]
    Con24ATI = 35161,

    [NativeName("GL_CON_25_ATI")]
    Con25ATI = 35162,

    [NativeName("GL_CON_26_ATI")]
    Con26ATI = 35163,

    [NativeName("GL_CON_27_ATI")]
    Con27ATI = 35164,

    [NativeName("GL_CON_28_ATI")]
    Con28ATI = 35165,

    [NativeName("GL_CON_29_ATI")]
    Con29ATI = 35166,

    [NativeName("GL_CON_30_ATI")]
    Con30ATI = 35167,

    [NativeName("GL_CON_31_ATI")]
    Con31ATI = 35168,

    [NativeName("GL_MOV_ATI")]
    MovATI = 35169,

    [NativeName("GL_ADD_ATI")]
    AddATI = 35171,

    [NativeName("GL_MUL_ATI")]
    MulATI = 35172,

    [NativeName("GL_SUB_ATI")]
    SubATI = 35173,

    [NativeName("GL_DOT3_ATI")]
    Dot3ATI = 35174,

    [NativeName("GL_DOT4_ATI")]
    Dot4ATI = 35175,

    [NativeName("GL_MAD_ATI")]
    MadATI = 35176,

    [NativeName("GL_LERP_ATI")]
    LerpATI = 35177,

    [NativeName("GL_CND_ATI")]
    CndATI = 35178,

    [NativeName("GL_CND0_ATI")]
    Cnd0ATI = 35179,

    [NativeName("GL_DOT2_ADD_ATI")]
    Dot2AddATI = 35180,

    [NativeName("GL_SECONDARY_INTERPOLATOR_ATI")]
    SecondaryInterpolatorATI = 35181,

    [NativeName("GL_NUM_FRAGMENT_REGISTERS_ATI")]
    NumFragmentRegistersATI = 35182,

    [NativeName("GL_NUM_FRAGMENT_CONSTANTS_ATI")]
    NumFragmentConstantsATI = 35183,

    [NativeName("GL_NUM_PASSES_ATI")]
    NumPassesATI = 35184,

    [NativeName("GL_NUM_INSTRUCTIONS_PER_PASS_ATI")]
    NumInstructionsPerPassATI = 35185,

    [NativeName("GL_NUM_INSTRUCTIONS_TOTAL_ATI")]
    NumInstructionsTotalATI = 35186,

    [NativeName("GL_NUM_INPUT_INTERPOLATOR_COMPONENTS_ATI")]
    NumInputInterpolatorComponentsATI = 35187,

    [NativeName("GL_NUM_LOOPBACK_COMPONENTS_ATI")]
    NumLoopbackComponentsATI = 35188,

    [NativeName("GL_COLOR_ALPHA_PAIRING_ATI")]
    ColorAlphaPairingATI = 35189,

    [NativeName("GL_SWIZZLE_STR_ATI")]
    SwizzleStrATI = 35190,

    [NativeName("GL_SWIZZLE_STQ_ATI")]
    SwizzleStqATI = 35191,

    [NativeName("GL_SWIZZLE_STR_DR_ATI")]
    SwizzleStrDrATI = 35192,

    [NativeName("GL_SWIZZLE_STQ_DQ_ATI")]
    SwizzleStqDqATI = 35193,

    [NativeName("GL_SWIZZLE_STRQ_ATI")]
    SwizzleStrqATI = 35194,

    [NativeName("GL_SWIZZLE_STRQ_DQ_ATI")]
    SwizzleStrqDqATI = 35195,

    [NativeName("GL_RED_BIT_ATI")]
    RedBitATI = 1,

    [NativeName("GL_GREEN_BIT_ATI")]
    GreenBitATI = 2,

    [NativeName("GL_BLUE_BIT_ATI")]
    BlueBitATI = 4,

    [NativeName("GL_2X_BIT_ATI")]
    X2XBitATI = 1,

    [NativeName("GL_4X_BIT_ATI")]
    X4XBitATI = 2,

    [NativeName("GL_8X_BIT_ATI")]
    X8XBitATI = 4,

    [NativeName("GL_HALF_BIT_ATI")]
    HalfBitATI = 8,

    [NativeName("GL_QUARTER_BIT_ATI")]
    QuarterBitATI = 16,

    [NativeName("GL_EIGHTH_BIT_ATI")]
    EighthBitATI = 32,

    [NativeName("GL_SATURATE_BIT_ATI")]
    SaturateBitATI = 64,

    [NativeName("GL_COMP_BIT_ATI")]
    CompBitATI = 2,

    [NativeName("GL_NEGATE_BIT_ATI")]
    NegateBitATI = 4,

    [NativeName("GL_BIAS_BIT_ATI")]
    BiasBitATI = 8,

    [NativeName("GL_VBO_FREE_MEMORY_ATI")]
    VboFreeMemoryATI = 34811,

    [NativeName("GL_TEXTURE_FREE_MEMORY_ATI")]
    TextureFreeMemoryATI = 34812,

    [NativeName("GL_RENDERBUFFER_FREE_MEMORY_ATI")]
    RenderbufferFreeMemoryATI = 34813,

    [NativeName("GL_RGBA_FLOAT_MODE_ATI")]
    RgbaFloatModeATI = 34848,

    [NativeName("GL_COLOR_CLEAR_UNCLAMPED_VALUE_ATI")]
    ColorClearUnclampedValueATI = 34869,

    [NativeName("GL_PN_TRIANGLES_ATI")]
    PnTrianglesATI = 34800,

    [NativeName("GL_MAX_PN_TRIANGLES_TESSELATION_LEVEL_ATI")]
    MaxPnTrianglesTesselationLevelATI = 34801,

    [NativeName("GL_PN_TRIANGLES_POINT_MODE_ATI")]
    PnTrianglesPointModeATI = 34802,

    [NativeName("GL_PN_TRIANGLES_NORMAL_MODE_ATI")]
    PnTrianglesNormalModeATI = 34803,

    [NativeName("GL_PN_TRIANGLES_TESSELATION_LEVEL_ATI")]
    PnTrianglesTesselationLevelATI = 34804,

    [NativeName("GL_PN_TRIANGLES_POINT_MODE_LINEAR_ATI")]
    PnTrianglesPointModeLinearATI = 34805,

    [NativeName("GL_PN_TRIANGLES_POINT_MODE_CUBIC_ATI")]
    PnTrianglesPointModeCubicATI = 34806,

    [NativeName("GL_PN_TRIANGLES_NORMAL_MODE_LINEAR_ATI")]
    PnTrianglesNormalModeLinearATI = 34807,

    [NativeName("GL_PN_TRIANGLES_NORMAL_MODE_QUADRATIC_ATI")]
    PnTrianglesNormalModeQuadraticATI = 34808,

    [NativeName("GL_STENCIL_BACK_FUNC_ATI")]
    StencilBackFuncATI = 34816,

    [NativeName("GL_STENCIL_BACK_FAIL_ATI")]
    StencilBackFailATI = 34817,

    [NativeName("GL_STENCIL_BACK_PASS_DEPTH_FAIL_ATI")]
    StencilBackPassDepthFailATI = 34818,

    [NativeName("GL_STENCIL_BACK_PASS_DEPTH_PASS_ATI")]
    StencilBackPassDepthPassATI = 34819,

    [NativeName("GL_TEXT_FRAGMENT_SHADER_ATI")]
    TextFragmentShaderATI = 33280,

    [NativeName("GL_MODULATE_ADD_ATI")]
    ModulateAddATI = 34628,

    [NativeName("GL_MODULATE_SIGNED_ADD_ATI")]
    ModulateSignedAddATI = 34629,

    [NativeName("GL_MODULATE_SUBTRACT_ATI")]
    ModulateSubtractATI = 34630,

    [NativeName("GL_RGBA_FLOAT32_ATI")]
    RgbaFloat32ATI = 34836,

    [NativeName("GL_RGB_FLOAT32_ATI")]
    RgbFloat32ATI = 34837,

    [NativeName("GL_ALPHA_FLOAT32_ATI")]
    AlphaFloat32ATI = 34838,

    [NativeName("GL_INTENSITY_FLOAT32_ATI")]
    IntensityFloat32ATI = 34839,

    [NativeName("GL_LUMINANCE_FLOAT32_ATI")]
    LuminanceFloat32ATI = 34840,

    [NativeName("GL_LUMINANCE_ALPHA_FLOAT32_ATI")]
    LuminanceAlphaFloat32ATI = 34841,

    [NativeName("GL_RGBA_FLOAT16_ATI")]
    RgbaFloat16ATI = 34842,

    [NativeName("GL_RGB_FLOAT16_ATI")]
    RgbFloat16ATI = 34843,

    [NativeName("GL_ALPHA_FLOAT16_ATI")]
    AlphaFloat16ATI = 34844,

    [NativeName("GL_INTENSITY_FLOAT16_ATI")]
    IntensityFloat16ATI = 34845,

    [NativeName("GL_LUMINANCE_FLOAT16_ATI")]
    LuminanceFloat16ATI = 34846,

    [NativeName("GL_LUMINANCE_ALPHA_FLOAT16_ATI")]
    LuminanceAlphaFloat16ATI = 34847,

    [NativeName("GL_MIRROR_CLAMP_ATI")]
    MirrorClampATI = 34626,

    [NativeName("GL_MIRROR_CLAMP_TO_EDGE_ATI")]
    MirrorClampToEdgeATI = 34627,

    [NativeName("GL_STATIC_ATI")]
    StaticATI = 34656,

    [NativeName("GL_DYNAMIC_ATI")]
    DynamicATI = 34657,

    [NativeName("GL_PRESERVE_ATI")]
    PreserveATI = 34658,

    [NativeName("GL_DISCARD_ATI")]
    DiscardATI = 34659,

    [NativeName("GL_OBJECT_BUFFER_SIZE_ATI")]
    ObjectBufferSizeATI = 34660,

    [NativeName("GL_OBJECT_BUFFER_USAGE_ATI")]
    ObjectBufferUsageATI = 34661,

    [NativeName("GL_ARRAY_OBJECT_BUFFER_ATI")]
    ArrayObjectBufferATI = 34662,

    [NativeName("GL_ARRAY_OBJECT_OFFSET_ATI")]
    ArrayObjectOffsetATI = 34663,

    [NativeName("GL_MAX_VERTEX_STREAMS_ATI")]
    MaxVertexStreamsATI = 34667,

    [NativeName("GL_VERTEX_STREAM0_ATI")]
    VertexStream0ATI = 34668,

    [NativeName("GL_VERTEX_STREAM1_ATI")]
    VertexStream1ATI = 34669,

    [NativeName("GL_VERTEX_STREAM2_ATI")]
    VertexStream2ATI = 34670,

    [NativeName("GL_VERTEX_STREAM3_ATI")]
    VertexStream3ATI = 34671,

    [NativeName("GL_VERTEX_STREAM4_ATI")]
    VertexStream4ATI = 34672,

    [NativeName("GL_VERTEX_STREAM5_ATI")]
    VertexStream5ATI = 34673,

    [NativeName("GL_VERTEX_STREAM6_ATI")]
    VertexStream6ATI = 34674,

    [NativeName("GL_VERTEX_STREAM7_ATI")]
    VertexStream7ATI = 34675,

    [NativeName("GL_VERTEX_SOURCE_ATI")]
    VertexSourceATI = 34676,

    [NativeName("GL_422_EXT")]
    X422EXT = 32972,

    [NativeName("GL_422_REV_EXT")]
    X422RevEXT = 32973,

    [NativeName("GL_422_AVERAGE_EXT")]
    X422AverageEXT = 32974,

    [NativeName("GL_422_REV_AVERAGE_EXT")]
    X422RevAverageEXT = 32975,

    [NativeName("GL_ABGR_EXT")]
    AbgrEXT = 32768,

    [NativeName("GL_BGR_EXT")]
    BgrEXT = 32992,

    [NativeName("GL_MAX_VERTEX_BINDABLE_UNIFORMS_EXT")]
    MaxVertexBindableUniformsEXT = 36322,

    [NativeName("GL_MAX_FRAGMENT_BINDABLE_UNIFORMS_EXT")]
    MaxFragmentBindableUniformsEXT = 36323,

    [NativeName("GL_MAX_GEOMETRY_BINDABLE_UNIFORMS_EXT")]
    MaxGeometryBindableUniformsEXT = 36324,

    [NativeName("GL_MAX_BINDABLE_UNIFORM_SIZE_EXT")]
    MaxBindableUniformSizeEXT = 36333,

    [NativeName("GL_UNIFORM_BUFFER_EXT")]
    UniformBufferEXT = 36334,

    [NativeName("GL_UNIFORM_BUFFER_BINDING_EXT")]
    UniformBufferBindingEXT = 36335,

    [NativeName("GL_CONSTANT_COLOR_EXT")]
    ConstantColorEXT = 32769,

    [NativeName("GL_ONE_MINUS_CONSTANT_COLOR_EXT")]
    OneMinusConstantColorEXT = 32770,

    [NativeName("GL_CONSTANT_ALPHA_EXT")]
    ConstantAlphaEXT = 32771,

    [NativeName("GL_ONE_MINUS_CONSTANT_ALPHA_EXT")]
    OneMinusConstantAlphaEXT = 32772,

    [NativeName("GL_BLEND_COLOR_EXT")]
    BlendColorEXT = 32773,

    [NativeName("GL_BLEND_EQUATION_RGB_EXT")]
    BlendEquationRgbEXT = 32777,

    [NativeName("GL_BLEND_EQUATION_ALPHA_EXT")]
    BlendEquationAlphaEXT = 34877,

    [NativeName("GL_BLEND_DST_RGB_EXT")]
    BlendDstRgbEXT = 32968,

    [NativeName("GL_BLEND_SRC_RGB_EXT")]
    BlendSrcRgbEXT = 32969,

    [NativeName("GL_BLEND_DST_ALPHA_EXT")]
    BlendDstAlphaEXT = 32970,

    [NativeName("GL_BLEND_SRC_ALPHA_EXT")]
    BlendSrcAlphaEXT = 32971,

    [NativeName("GL_FUNC_ADD_EXT")]
    FuncAddEXT = 32774,

    [NativeName("GL_BLEND_EQUATION_EXT")]
    BlendEquationEXT = 32777,

    [NativeName("GL_FUNC_SUBTRACT_EXT")]
    FuncSubtractEXT = 32778,

    [NativeName("GL_FUNC_REVERSE_SUBTRACT_EXT")]
    FuncReverseSubtractEXT = 32779,

    [NativeName("GL_CLIP_VOLUME_CLIPPING_HINT_EXT")]
    ClipVolumeClippingHintEXT = 33008,

    [NativeName("GL_CMYK_EXT")]
    CmykEXT = 32780,

    [NativeName("GL_CMYKA_EXT")]
    CmykaEXT = 32781,

    [NativeName("GL_PACK_CMYK_HINT_EXT")]
    PackCmykHintEXT = 32782,

    [NativeName("GL_UNPACK_CMYK_HINT_EXT")]
    UnpackCmykHintEXT = 32783,

    [NativeName("GL_ARRAY_ELEMENT_LOCK_FIRST_EXT")]
    ArrayElementLockFirstEXT = 33192,

    [NativeName("GL_ARRAY_ELEMENT_LOCK_COUNT_EXT")]
    ArrayElementLockCountEXT = 33193,

    [NativeName("GL_CONVOLUTION_1D_EXT")]
    Convolution1DEXT = 32784,

    [NativeName("GL_CONVOLUTION_2D_EXT")]
    Convolution2DEXT = 32785,

    [NativeName("GL_SEPARABLE_2D_EXT")]
    Separable2DEXT = 32786,

    [NativeName("GL_CONVOLUTION_BORDER_MODE_EXT")]
    ConvolutionBorderModeEXT = 32787,

    [NativeName("GL_CONVOLUTION_FILTER_SCALE_EXT")]
    ConvolutionFilterScaleEXT = 32788,

    [NativeName("GL_CONVOLUTION_FILTER_BIAS_EXT")]
    ConvolutionFilterBiasEXT = 32789,

    [NativeName("GL_REDUCE_EXT")]
    ReduceEXT = 32790,

    [NativeName("GL_CONVOLUTION_FORMAT_EXT")]
    ConvolutionFormatEXT = 32791,

    [NativeName("GL_CONVOLUTION_WIDTH_EXT")]
    ConvolutionWidthEXT = 32792,

    [NativeName("GL_CONVOLUTION_HEIGHT_EXT")]
    ConvolutionHeightEXT = 32793,

    [NativeName("GL_MAX_CONVOLUTION_WIDTH_EXT")]
    MaxConvolutionWidthEXT = 32794,

    [NativeName("GL_MAX_CONVOLUTION_HEIGHT_EXT")]
    MaxConvolutionHeightEXT = 32795,

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

    [NativeName("GL_TANGENT_ARRAY_EXT")]
    TangentArrayEXT = 33849,

    [NativeName("GL_BINORMAL_ARRAY_EXT")]
    BinormalArrayEXT = 33850,

    [NativeName("GL_CURRENT_TANGENT_EXT")]
    CurrentTangentEXT = 33851,

    [NativeName("GL_CURRENT_BINORMAL_EXT")]
    CurrentBinormalEXT = 33852,

    [NativeName("GL_TANGENT_ARRAY_TYPE_EXT")]
    TangentArrayTypeEXT = 33854,

    [NativeName("GL_TANGENT_ARRAY_STRIDE_EXT")]
    TangentArrayStrideEXT = 33855,

    [NativeName("GL_BINORMAL_ARRAY_TYPE_EXT")]
    BinormalArrayTypeEXT = 33856,

    [NativeName("GL_BINORMAL_ARRAY_STRIDE_EXT")]
    BinormalArrayStrideEXT = 33857,

    [NativeName("GL_TANGENT_ARRAY_POINTER_EXT")]
    TangentArrayPointerEXT = 33858,

    [NativeName("GL_BINORMAL_ARRAY_POINTER_EXT")]
    BinormalArrayPointerEXT = 33859,

    [NativeName("GL_MAP1_TANGENT_EXT")]
    Map1TangentEXT = 33860,

    [NativeName("GL_MAP2_TANGENT_EXT")]
    Map2TangentEXT = 33861,

    [NativeName("GL_MAP1_BINORMAL_EXT")]
    Map1BinormalEXT = 33862,

    [NativeName("GL_MAP2_BINORMAL_EXT")]
    Map2BinormalEXT = 33863,

    [NativeName("GL_CULL_VERTEX_EXT")]
    CullVertexEXT = 33194,

    [NativeName("GL_CULL_VERTEX_EYE_POSITION_EXT")]
    CullVertexEyePositionEXT = 33195,

    [NativeName("GL_CULL_VERTEX_OBJECT_POSITION_EXT")]
    CullVertexObjectPositionEXT = 33196,

    [NativeName("GL_PROGRAM_PIPELINE_OBJECT_EXT")]
    ProgramPipelineObjectEXT = 35407,

    [NativeName("GL_PROGRAM_OBJECT_EXT")]
    ProgramObjectEXT = 35648,

    [NativeName("GL_SHADER_OBJECT_EXT")]
    ShaderObjectEXT = 35656,

    [NativeName("GL_BUFFER_OBJECT_EXT")]
    BufferObjectEXT = 37201,

    [NativeName("GL_QUERY_OBJECT_EXT")]
    QueryObjectEXT = 37203,

    [NativeName("GL_VERTEX_ARRAY_OBJECT_EXT")]
    VertexArrayObjectEXT = 37204,

    [NativeName("GL_DEPTH_BOUNDS_TEST_EXT")]
    DepthBoundsTestEXT = 34960,

    [NativeName("GL_DEPTH_BOUNDS_EXT")]
    DepthBoundsEXT = 34961,

    [NativeName("GL_PROGRAM_MATRIX_EXT")]
    ProgramMatrixEXT = 36397,

    [NativeName("GL_TRANSPOSE_PROGRAM_MATRIX_EXT")]
    TransposeProgramMatrixEXT = 36398,

    [NativeName("GL_PROGRAM_MATRIX_STACK_DEPTH_EXT")]
    ProgramMatrixStackDepthEXT = 36399,

    [NativeName("GL_MAX_ELEMENTS_VERTICES_EXT")]
    MaxElementsVerticesEXT = 33000,

    [NativeName("GL_MAX_ELEMENTS_INDICES_EXT")]
    MaxElementsIndicesEXT = 33001,

    [NativeName("GL_FOG_COORDINATE_SOURCE_EXT")]
    FogCoordinateSourceEXT = 33872,

    [NativeName("GL_FOG_COORDINATE_EXT")]
    FogCoordinateEXT = 33873,

    [NativeName("GL_FRAGMENT_DEPTH_EXT")]
    FragmentDepthEXT = 33874,

    [NativeName("GL_CURRENT_FOG_COORDINATE_EXT")]
    CurrentFogCoordinateEXT = 33875,

    [NativeName("GL_FOG_COORDINATE_ARRAY_TYPE_EXT")]
    FogCoordinateArrayTypeEXT = 33876,

    [NativeName("GL_FOG_COORDINATE_ARRAY_STRIDE_EXT")]
    FogCoordinateArrayStrideEXT = 33877,

    [NativeName("GL_FOG_COORDINATE_ARRAY_POINTER_EXT")]
    FogCoordinateArrayPointerEXT = 33878,

    [NativeName("GL_FOG_COORDINATE_ARRAY_EXT")]
    FogCoordinateArrayEXT = 33879,

    [NativeName("GL_READ_FRAMEBUFFER_EXT")]
    ReadFramebufferEXT = 36008,

    [NativeName("GL_DRAW_FRAMEBUFFER_EXT")]
    DrawFramebufferEXT = 36009,

    [NativeName("GL_DRAW_FRAMEBUFFER_BINDING_EXT")]
    DrawFramebufferBindingEXT = 36006,

    [NativeName("GL_READ_FRAMEBUFFER_BINDING_EXT")]
    ReadFramebufferBindingEXT = 36010,

    [NativeName("GL_SCALED_RESOLVE_FASTEST_EXT")]
    ScaledResolveFastestEXT = 37050,

    [NativeName("GL_SCALED_RESOLVE_NICEST_EXT")]
    ScaledResolveNicestEXT = 37051,

    [NativeName("GL_INVALID_FRAMEBUFFER_OPERATION_EXT")]
    InvalidFramebufferOperationEXT = 1286,

    [NativeName("GL_MAX_RENDERBUFFER_SIZE_EXT")]
    MaxRenderbufferSizeEXT = 34024,

    [NativeName("GL_FRAMEBUFFER_BINDING_EXT")]
    FramebufferBindingEXT = 36006,

    [NativeName("GL_RENDERBUFFER_BINDING_EXT")]
    RenderbufferBindingEXT = 36007,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_EXT")]
    FramebufferAttachmentObjectTypeEXT = 36048,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_EXT")]
    FramebufferAttachmentObjectNameEXT = 36049,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_EXT")]
    FramebufferAttachmentTextureLevelEXT = 36050,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_EXT")]
    FramebufferAttachmentTextureCubeMapFaceEXT = 36051,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_EXT")]
    FramebufferAttachmentTexture3DZoffsetEXT = 36052,

    [NativeName("GL_FRAMEBUFFER_COMPLETE_EXT")]
    FramebufferCompleteEXT = 36053,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_EXT")]
    FramebufferIncompleteAttachmentEXT = 36054,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_EXT")]
    FramebufferIncompleteMissingAttachmentEXT = 36055,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_EXT")]
    FramebufferIncompleteDimensionsEXT = 36057,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_FORMATS_EXT")]
    FramebufferIncompleteFormatsEXT = 36058,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER_EXT")]
    FramebufferIncompleteDrawBufferEXT = 36059,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER_EXT")]
    FramebufferIncompleteReadBufferEXT = 36060,

    [NativeName("GL_FRAMEBUFFER_UNSUPPORTED_EXT")]
    FramebufferUnsupportedEXT = 36061,

    [NativeName("GL_MAX_COLOR_ATTACHMENTS_EXT")]
    MaxColorAttachmentsEXT = 36063,

    [NativeName("GL_COLOR_ATTACHMENT0_EXT")]
    ColorAttachment0EXT = 36064,

    [NativeName("GL_COLOR_ATTACHMENT1_EXT")]
    ColorAttachment1EXT = 36065,

    [NativeName("GL_COLOR_ATTACHMENT2_EXT")]
    ColorAttachment2EXT = 36066,

    [NativeName("GL_COLOR_ATTACHMENT3_EXT")]
    ColorAttachment3EXT = 36067,

    [NativeName("GL_COLOR_ATTACHMENT4_EXT")]
    ColorAttachment4EXT = 36068,

    [NativeName("GL_COLOR_ATTACHMENT5_EXT")]
    ColorAttachment5EXT = 36069,

    [NativeName("GL_COLOR_ATTACHMENT6_EXT")]
    ColorAttachment6EXT = 36070,

    [NativeName("GL_COLOR_ATTACHMENT7_EXT")]
    ColorAttachment7EXT = 36071,

    [NativeName("GL_COLOR_ATTACHMENT8_EXT")]
    ColorAttachment8EXT = 36072,

    [NativeName("GL_COLOR_ATTACHMENT9_EXT")]
    ColorAttachment9EXT = 36073,

    [NativeName("GL_COLOR_ATTACHMENT10_EXT")]
    ColorAttachment10EXT = 36074,

    [NativeName("GL_COLOR_ATTACHMENT11_EXT")]
    ColorAttachment11EXT = 36075,

    [NativeName("GL_COLOR_ATTACHMENT12_EXT")]
    ColorAttachment12EXT = 36076,

    [NativeName("GL_COLOR_ATTACHMENT13_EXT")]
    ColorAttachment13EXT = 36077,

    [NativeName("GL_COLOR_ATTACHMENT14_EXT")]
    ColorAttachment14EXT = 36078,

    [NativeName("GL_COLOR_ATTACHMENT15_EXT")]
    ColorAttachment15EXT = 36079,

    [NativeName("GL_DEPTH_ATTACHMENT_EXT")]
    DepthAttachmentEXT = 36096,

    [NativeName("GL_STENCIL_ATTACHMENT_EXT")]
    StencilAttachmentEXT = 36128,

    [NativeName("GL_FRAMEBUFFER_EXT")]
    FramebufferEXT = 36160,

    [NativeName("GL_RENDERBUFFER_EXT")]
    RenderbufferEXT = 36161,

    [NativeName("GL_RENDERBUFFER_WIDTH_EXT")]
    RenderbufferWidthEXT = 36162,

    [NativeName("GL_RENDERBUFFER_HEIGHT_EXT")]
    RenderbufferHeightEXT = 36163,

    [NativeName("GL_RENDERBUFFER_INTERNAL_FORMAT_EXT")]
    RenderbufferInternalFormatEXT = 36164,

    [NativeName("GL_STENCIL_INDEX1_EXT")]
    StencilIndex1EXT = 36166,

    [NativeName("GL_STENCIL_INDEX4_EXT")]
    StencilIndex4EXT = 36167,

    [NativeName("GL_STENCIL_INDEX8_EXT")]
    StencilIndex8EXT = 36168,

    [NativeName("GL_STENCIL_INDEX16_EXT")]
    StencilIndex16EXT = 36169,

    [NativeName("GL_RENDERBUFFER_RED_SIZE_EXT")]
    RenderbufferRedSizeEXT = 36176,

    [NativeName("GL_RENDERBUFFER_GREEN_SIZE_EXT")]
    RenderbufferGreenSizeEXT = 36177,

    [NativeName("GL_RENDERBUFFER_BLUE_SIZE_EXT")]
    RenderbufferBlueSizeEXT = 36178,

    [NativeName("GL_RENDERBUFFER_ALPHA_SIZE_EXT")]
    RenderbufferAlphaSizeEXT = 36179,

    [NativeName("GL_RENDERBUFFER_DEPTH_SIZE_EXT")]
    RenderbufferDepthSizeEXT = 36180,

    [NativeName("GL_RENDERBUFFER_STENCIL_SIZE_EXT")]
    RenderbufferStencilSizeEXT = 36181,

    [NativeName("GL_FRAMEBUFFER_SRGB_EXT")]
    FramebufferSrgbEXT = 36281,

    [NativeName("GL_FRAMEBUFFER_SRGB_CAPABLE_EXT")]
    FramebufferSrgbCapableEXT = 36282,

    [NativeName("GL_GEOMETRY_SHADER_EXT")]
    GeometryShaderEXT = 36313,

    [NativeName("GL_GEOMETRY_VERTICES_OUT_EXT")]
    GeometryVerticesOutEXT = 36314,

    [NativeName("GL_GEOMETRY_INPUT_TYPE_EXT")]
    GeometryInputTypeEXT = 36315,

    [NativeName("GL_GEOMETRY_OUTPUT_TYPE_EXT")]
    GeometryOutputTypeEXT = 36316,

    [NativeName("GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_EXT")]
    MaxGeometryTextureImageUnitsEXT = 35881,

    [NativeName("GL_MAX_GEOMETRY_VARYING_COMPONENTS_EXT")]
    MaxGeometryVaryingComponentsEXT = 36317,

    [NativeName("GL_MAX_VERTEX_VARYING_COMPONENTS_EXT")]
    MaxVertexVaryingComponentsEXT = 36318,

    [NativeName("GL_MAX_VARYING_COMPONENTS_EXT")]
    MaxVaryingComponentsEXT = 35659,

    [NativeName("GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_EXT")]
    MaxGeometryUniformComponentsEXT = 36319,

    [NativeName("GL_MAX_GEOMETRY_OUTPUT_VERTICES_EXT")]
    MaxGeometryOutputVerticesEXT = 36320,

    [NativeName("GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_EXT")]
    MaxGeometryTotalOutputComponentsEXT = 36321,

    [NativeName("GL_LINES_ADJACENCY_EXT")]
    LinesAdjacencyEXT = 10,

    [NativeName("GL_LINE_STRIP_ADJACENCY_EXT")]
    LineStripAdjacencyEXT = 11,

    [NativeName("GL_TRIANGLES_ADJACENCY_EXT")]
    TrianglesAdjacencyEXT = 12,

    [NativeName("GL_TRIANGLE_STRIP_ADJACENCY_EXT")]
    TriangleStripAdjacencyEXT = 13,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_EXT")]
    FramebufferIncompleteLayerTargetsEXT = 36264,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_EXT")]
    FramebufferIncompleteLayerCountEXT = 36265,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_LAYERED_EXT")]
    FramebufferAttachmentLayeredEXT = 36263,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER_EXT")]
    FramebufferAttachmentTextureLayerEXT = 36052,

    [NativeName("GL_PROGRAM_POINT_SIZE_EXT")]
    ProgramPointSizeEXT = 34370,

    [NativeName("GL_SAMPLER_1D_ARRAY_EXT")]
    Sampler1DArrayEXT = 36288,

    [NativeName("GL_SAMPLER_2D_ARRAY_EXT")]
    Sampler2DArrayEXT = 36289,

    [NativeName("GL_SAMPLER_BUFFER_EXT")]
    SamplerBufferEXT = 36290,

    [NativeName("GL_SAMPLER_1D_ARRAY_SHADOW_EXT")]
    Sampler1DArrayShadowEXT = 36291,

    [NativeName("GL_SAMPLER_2D_ARRAY_SHADOW_EXT")]
    Sampler2DArrayShadowEXT = 36292,

    [NativeName("GL_SAMPLER_CUBE_SHADOW_EXT")]
    SamplerCubeShadowEXT = 36293,

    [NativeName("GL_UNSIGNED_INT_VEC2_EXT")]
    UnsignedIntVec2EXT = 36294,

    [NativeName("GL_UNSIGNED_INT_VEC3_EXT")]
    UnsignedIntVec3EXT = 36295,

    [NativeName("GL_UNSIGNED_INT_VEC4_EXT")]
    UnsignedIntVec4EXT = 36296,

    [NativeName("GL_INT_SAMPLER_1D_EXT")]
    IntSampler1DEXT = 36297,

    [NativeName("GL_INT_SAMPLER_2D_EXT")]
    IntSampler2DEXT = 36298,

    [NativeName("GL_INT_SAMPLER_3D_EXT")]
    IntSampler3DEXT = 36299,

    [NativeName("GL_INT_SAMPLER_CUBE_EXT")]
    IntSamplerCubeEXT = 36300,

    [NativeName("GL_INT_SAMPLER_2D_RECT_EXT")]
    IntSampler2DRectEXT = 36301,

    [NativeName("GL_INT_SAMPLER_1D_ARRAY_EXT")]
    IntSampler1DArrayEXT = 36302,

    [NativeName("GL_INT_SAMPLER_2D_ARRAY_EXT")]
    IntSampler2DArrayEXT = 36303,

    [NativeName("GL_INT_SAMPLER_BUFFER_EXT")]
    IntSamplerBufferEXT = 36304,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_1D_EXT")]
    UnsignedIntSampler1DEXT = 36305,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_2D_EXT")]
    UnsignedIntSampler2DEXT = 36306,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_3D_EXT")]
    UnsignedIntSampler3DEXT = 36307,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_CUBE_EXT")]
    UnsignedIntSamplerCubeEXT = 36308,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_2D_RECT_EXT")]
    UnsignedIntSampler2DRectEXT = 36309,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_1D_ARRAY_EXT")]
    UnsignedIntSampler1DArrayEXT = 36310,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_2D_ARRAY_EXT")]
    UnsignedIntSampler2DArrayEXT = 36311,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_BUFFER_EXT")]
    UnsignedIntSamplerBufferEXT = 36312,

    [NativeName("GL_MIN_PROGRAM_TEXEL_OFFSET_EXT")]
    MinProgramTexelOffsetEXT = 35076,

    [NativeName("GL_MAX_PROGRAM_TEXEL_OFFSET_EXT")]
    MaxProgramTexelOffsetEXT = 35077,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_INTEGER_EXT")]
    VertexAttribArrayIntegerEXT = 35069,

    [NativeName("GL_HISTOGRAM_EXT")]
    HistogramEXT = 32804,

    [NativeName("GL_PROXY_HISTOGRAM_EXT")]
    ProxyHistogramEXT = 32805,

    [NativeName("GL_HISTOGRAM_WIDTH_EXT")]
    HistogramWidthEXT = 32806,

    [NativeName("GL_HISTOGRAM_FORMAT_EXT")]
    HistogramFormatEXT = 32807,

    [NativeName("GL_HISTOGRAM_RED_SIZE_EXT")]
    HistogramRedSizeEXT = 32808,

    [NativeName("GL_HISTOGRAM_GREEN_SIZE_EXT")]
    HistogramGreenSizeEXT = 32809,

    [NativeName("GL_HISTOGRAM_BLUE_SIZE_EXT")]
    HistogramBlueSizeEXT = 32810,

    [NativeName("GL_HISTOGRAM_ALPHA_SIZE_EXT")]
    HistogramAlphaSizeEXT = 32811,

    [NativeName("GL_HISTOGRAM_LUMINANCE_SIZE_EXT")]
    HistogramLuminanceSizeEXT = 32812,

    [NativeName("GL_HISTOGRAM_SINK_EXT")]
    HistogramSinkEXT = 32813,

    [NativeName("GL_MINMAX_EXT")]
    MinmaxEXT = 32814,

    [NativeName("GL_MINMAX_FORMAT_EXT")]
    MinmaxFormatEXT = 32815,

    [NativeName("GL_MINMAX_SINK_EXT")]
    MinmaxSinkEXT = 32816,

    [NativeName("GL_TABLE_TOO_LARGE_EXT")]
    TableTooLargeEXT = 32817,

    [NativeName("GL_IUI_V2F_EXT")]
    IuiV2FEXT = 33197,

    [NativeName("GL_IUI_V3F_EXT")]
    IuiV3FEXT = 33198,

    [NativeName("GL_IUI_N3F_V2F_EXT")]
    IuiN3FV2FEXT = 33199,

    [NativeName("GL_IUI_N3F_V3F_EXT")]
    IuiN3FV3FEXT = 33200,

    [NativeName("GL_T2F_IUI_V2F_EXT")]
    T2FIuiV2FEXT = 33201,

    [NativeName("GL_T2F_IUI_V3F_EXT")]
    T2FIuiV3FEXT = 33202,

    [NativeName("GL_T2F_IUI_N3F_V2F_EXT")]
    T2FIuiN3FV2FEXT = 33203,

    [NativeName("GL_T2F_IUI_N3F_V3F_EXT")]
    T2FIuiN3FV3FEXT = 33204,

    [NativeName("GL_INDEX_TEST_EXT")]
    IndexTestEXT = 33205,

    [NativeName("GL_INDEX_TEST_FUNC_EXT")]
    IndexTestFuncEXT = 33206,

    [NativeName("GL_INDEX_TEST_REF_EXT")]
    IndexTestRefEXT = 33207,

    [NativeName("GL_INDEX_MATERIAL_EXT")]
    IndexMaterialEXT = 33208,

    [NativeName("GL_INDEX_MATERIAL_PARAMETER_EXT")]
    IndexMaterialParameterEXT = 33209,

    [NativeName("GL_INDEX_MATERIAL_FACE_EXT")]
    IndexMaterialFaceEXT = 33210,

    [NativeName("GL_FRAGMENT_MATERIAL_EXT")]
    FragmentMaterialEXT = 33609,

    [NativeName("GL_FRAGMENT_NORMAL_EXT")]
    FragmentNormalEXT = 33610,

    [NativeName("GL_FRAGMENT_COLOR_EXT")]
    FragmentColorEXT = 33612,

    [NativeName("GL_ATTENUATION_EXT")]
    AttenuationEXT = 33613,

    [NativeName("GL_SHADOW_ATTENUATION_EXT")]
    ShadowAttenuationEXT = 33614,

    [NativeName("GL_TEXTURE_APPLICATION_MODE_EXT")]
    TextureApplicationModeEXT = 33615,

    [NativeName("GL_TEXTURE_LIGHT_EXT")]
    TextureLightEXT = 33616,

    [NativeName("GL_TEXTURE_MATERIAL_FACE_EXT")]
    TextureMaterialFaceEXT = 33617,

    [NativeName("GL_TEXTURE_MATERIAL_PARAMETER_EXT")]
    TextureMaterialParameterEXT = 33618,

    [NativeName("GL_TEXTURE_TILING_EXT")]
    TextureTilingEXT = 38272,

    [NativeName("GL_DEDICATED_MEMORY_OBJECT_EXT")]
    DedicatedMemoryObjectEXT = 38273,

    [NativeName("GL_PROTECTED_MEMORY_OBJECT_EXT")]
    ProtectedMemoryObjectEXT = 38299,

    [NativeName("GL_NUM_TILING_TYPES_EXT")]
    NumTilingTypesEXT = 38274,

    [NativeName("GL_TILING_TYPES_EXT")]
    TilingTypesEXT = 38275,

    [NativeName("GL_OPTIMAL_TILING_EXT")]
    OptimalTilingEXT = 38276,

    [NativeName("GL_LINEAR_TILING_EXT")]
    LinearTilingEXT = 38277,

    [NativeName("GL_NUM_DEVICE_UUIDS_EXT")]
    NumDeviceUuidsEXT = 38294,

    [NativeName("GL_DEVICE_UUID_EXT")]
    DeviceUuidEXT = 38295,

    [NativeName("GL_DRIVER_UUID_EXT")]
    DriverUuidEXT = 38296,

    [NativeName("GL_UUID_SIZE_EXT")]
    UuidSizeEXT = 16,

    [NativeName("GL_HANDLE_TYPE_OPAQUE_FD_EXT")]
    HandleTypeOpaqueFdEXT = 38278,

    [NativeName("GL_HANDLE_TYPE_OPAQUE_WIN32_EXT")]
    HandleTypeOpaqueWin32EXT = 38279,

    [NativeName("GL_HANDLE_TYPE_OPAQUE_WIN32_KMT_EXT")]
    HandleTypeOpaqueWin32KmtEXT = 38280,

    [NativeName("GL_DEVICE_LUID_EXT")]
    DeviceLuidEXT = 38297,

    [NativeName("GL_DEVICE_NODE_MASK_EXT")]
    DeviceNodeMaskEXT = 38298,

    [NativeName("GL_LUID_SIZE_EXT")]
    LuidSizeEXT = 8,

    [NativeName("GL_HANDLE_TYPE_D3D12_TILEPOOL_EXT")]
    HandleTypeD3D12TilepoolEXT = 38281,

    [NativeName("GL_HANDLE_TYPE_D3D12_RESOURCE_EXT")]
    HandleTypeD3D12ResourceEXT = 38282,

    [NativeName("GL_HANDLE_TYPE_D3D11_IMAGE_EXT")]
    HandleTypeD3D11ImageEXT = 38283,

    [NativeName("GL_HANDLE_TYPE_D3D11_IMAGE_KMT_EXT")]
    HandleTypeD3D11ImageKmtEXT = 38284,

    [NativeName("GL_MULTISAMPLE_EXT")]
    MultisampleEXT = 32925,

    [NativeName("GL_SAMPLE_ALPHA_TO_MASK_EXT")]
    SampleAlphaToMaskEXT = 32926,

    [NativeName("GL_SAMPLE_ALPHA_TO_ONE_EXT")]
    SampleAlphaToOneEXT = 32927,

    [NativeName("GL_SAMPLE_MASK_EXT")]
    SampleMaskEXT = 32928,

    [NativeName("GL_1PASS_EXT")]
    X1PassEXT = 32929,

    [NativeName("GL_2PASS_0_EXT")]
    X2Pass0EXT = 32930,

    [NativeName("GL_2PASS_1_EXT")]
    X2Pass1EXT = 32931,

    [NativeName("GL_4PASS_0_EXT")]
    X4Pass0EXT = 32932,

    [NativeName("GL_4PASS_1_EXT")]
    X4Pass1EXT = 32933,

    [NativeName("GL_4PASS_2_EXT")]
    X4Pass2EXT = 32934,

    [NativeName("GL_4PASS_3_EXT")]
    X4Pass3EXT = 32935,

    [NativeName("GL_SAMPLE_BUFFERS_EXT")]
    SampleBuffersEXT = 32936,

    [NativeName("GL_SAMPLES_EXT")]
    SamplesEXT = 32937,

    [NativeName("GL_SAMPLE_MASK_VALUE_EXT")]
    SampleMaskValueEXT = 32938,

    [NativeName("GL_SAMPLE_MASK_INVERT_EXT")]
    SampleMaskInvertEXT = 32939,

    [NativeName("GL_SAMPLE_PATTERN_EXT")]
    SamplePatternEXT = 32940,

    [NativeName("GL_MULTISAMPLE_BIT_EXT")]
    MultisampleBitEXT = 536870912,

    [NativeName("GL_DEPTH_STENCIL_EXT")]
    DepthStencilEXT = 34041,

    [NativeName("GL_UNSIGNED_INT_24_8_EXT")]
    UnsignedInt24X8EXT = 34042,

    [NativeName("GL_DEPTH24_STENCIL8_EXT")]
    Depth24Stencil8EXT = 35056,

    [NativeName("GL_TEXTURE_STENCIL_SIZE_EXT")]
    TextureStencilSizeEXT = 35057,

    [NativeName("GL_R11F_G11F_B10F_EXT")]
    R11FG11FB10FEXT = 35898,

    [NativeName("GL_UNSIGNED_INT_10F_11F_11F_REV_EXT")]
    UnsignedInt10F11F11FRevEXT = 35899,

    [NativeName("GL_RGBA_SIGNED_COMPONENTS_EXT")]
    RgbaSignedComponentsEXT = 35900,

    [NativeName("GL_UNSIGNED_BYTE_3_3_2_EXT")]
    UnsignedByte3X3X2EXT = 32818,

    [NativeName("GL_UNSIGNED_SHORT_4_4_4_4_EXT")]
    UnsignedShort4X4X4X4EXT = 32819,

    [NativeName("GL_UNSIGNED_SHORT_5_5_5_1_EXT")]
    UnsignedShort5X5X5X1EXT = 32820,

    [NativeName("GL_UNSIGNED_INT_8_8_8_8_EXT")]
    UnsignedInt8X8X8X8EXT = 32821,

    [NativeName("GL_UNSIGNED_INT_10_10_10_2_EXT")]
    UnsignedInt10X10X10X2EXT = 32822,

    [NativeName("GL_COLOR_INDEX1_EXT")]
    ColorIndex1EXT = 32994,

    [NativeName("GL_COLOR_INDEX2_EXT")]
    ColorIndex2EXT = 32995,

    [NativeName("GL_COLOR_INDEX4_EXT")]
    ColorIndex4EXT = 32996,

    [NativeName("GL_COLOR_INDEX8_EXT")]
    ColorIndex8EXT = 32997,

    [NativeName("GL_COLOR_INDEX12_EXT")]
    ColorIndex12EXT = 32998,

    [NativeName("GL_COLOR_INDEX16_EXT")]
    ColorIndex16EXT = 32999,

    [NativeName("GL_TEXTURE_INDEX_SIZE_EXT")]
    TextureIndexSizeEXT = 33005,

    [NativeName("GL_PIXEL_PACK_BUFFER_EXT")]
    PixelPackBufferEXT = 35051,

    [NativeName("GL_PIXEL_UNPACK_BUFFER_EXT")]
    PixelUnpackBufferEXT = 35052,

    [NativeName("GL_PIXEL_PACK_BUFFER_BINDING_EXT")]
    PixelPackBufferBindingEXT = 35053,

    [NativeName("GL_PIXEL_UNPACK_BUFFER_BINDING_EXT")]
    PixelUnpackBufferBindingEXT = 35055,

    [NativeName("GL_PIXEL_TRANSFORM_2D_EXT")]
    PixelTransform2DEXT = 33584,

    [NativeName("GL_PIXEL_MAG_FILTER_EXT")]
    PixelMagFilterEXT = 33585,

    [NativeName("GL_PIXEL_MIN_FILTER_EXT")]
    PixelMinFilterEXT = 33586,

    [NativeName("GL_PIXEL_CUBIC_WEIGHT_EXT")]
    PixelCubicWeightEXT = 33587,

    [NativeName("GL_CUBIC_EXT")]
    CubicEXT = 33588,

    [NativeName("GL_AVERAGE_EXT")]
    AverageEXT = 33589,

    [NativeName("GL_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT")]
    PixelTransform2DStackDepthEXT = 33590,

    [NativeName("GL_MAX_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT")]
    MaxPixelTransform2DStackDepthEXT = 33591,

    [NativeName("GL_PIXEL_TRANSFORM_2D_MATRIX_EXT")]
    PixelTransform2DMatrixEXT = 33592,

    [NativeName("GL_POINT_SIZE_MIN_EXT")]
    PointSizeMinEXT = 33062,

    [NativeName("GL_POINT_SIZE_MAX_EXT")]
    PointSizeMaxEXT = 33063,

    [NativeName("GL_POINT_FADE_THRESHOLD_SIZE_EXT")]
    PointFadeThresholdSizeEXT = 33064,

    [NativeName("GL_DISTANCE_ATTENUATION_EXT")]
    DistanceAttenuationEXT = 33065,

    [NativeName("GL_POLYGON_OFFSET_EXT")]
    PolygonOffsetEXT = 32823,

    [NativeName("GL_POLYGON_OFFSET_FACTOR_EXT")]
    PolygonOffsetFactorEXT = 32824,

    [NativeName("GL_POLYGON_OFFSET_BIAS_EXT")]
    PolygonOffsetBiasEXT = 32825,

    [NativeName("GL_POLYGON_OFFSET_CLAMP_EXT")]
    PolygonOffsetClampEXT = 36379,

    [NativeName("GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION_EXT")]
    QuadsFollowProvokingVertexConventionEXT = 36428,

    [NativeName("GL_FIRST_VERTEX_CONVENTION_EXT")]
    FirstVertexConventionEXT = 36429,

    [NativeName("GL_LAST_VERTEX_CONVENTION_EXT")]
    LastVertexConventionEXT = 36430,

    [NativeName("GL_PROVOKING_VERTEX_EXT")]
    ProvokingVertexEXT = 36431,

    [NativeName("GL_RASTER_MULTISAMPLE_EXT")]
    RasterMultisampleEXT = 37671,

    [NativeName("GL_RASTER_SAMPLES_EXT")]
    RasterSamplesEXT = 37672,

    [NativeName("GL_MAX_RASTER_SAMPLES_EXT")]
    MaxRasterSamplesEXT = 37673,

    [NativeName("GL_RASTER_FIXED_SAMPLE_LOCATIONS_EXT")]
    RasterFixedSampleLocationsEXT = 37674,

    [NativeName("GL_MULTISAMPLE_RASTERIZATION_ALLOWED_EXT")]
    MultisampleRasterizationAllowedEXT = 37675,

    [NativeName("GL_EFFECTIVE_RASTER_SAMPLES_EXT")]
    EffectiveRasterSamplesEXT = 37676,

    [NativeName("GL_RESCALE_NORMAL_EXT")]
    RescaleNormalEXT = 32826,

    [NativeName("GL_COLOR_SUM_EXT")]
    ColorSumEXT = 33880,

    [NativeName("GL_CURRENT_SECONDARY_COLOR_EXT")]
    CurrentSecondaryColorEXT = 33881,

    [NativeName("GL_SECONDARY_COLOR_ARRAY_SIZE_EXT")]
    SecondaryColorArraySizeEXT = 33882,

    [NativeName("GL_SECONDARY_COLOR_ARRAY_TYPE_EXT")]
    SecondaryColorArrayTypeEXT = 33883,

    [NativeName("GL_SECONDARY_COLOR_ARRAY_STRIDE_EXT")]
    SecondaryColorArrayStrideEXT = 33884,

    [NativeName("GL_SECONDARY_COLOR_ARRAY_POINTER_EXT")]
    SecondaryColorArrayPointerEXT = 33885,

    [NativeName("GL_SECONDARY_COLOR_ARRAY_EXT")]
    SecondaryColorArrayEXT = 33886,

    [NativeName("GL_LAYOUT_GENERAL_EXT")]
    LayoutGeneralEXT = 38285,

    [NativeName("GL_LAYOUT_COLOR_ATTACHMENT_EXT")]
    LayoutColorAttachmentEXT = 38286,

    [NativeName("GL_LAYOUT_DEPTH_STENCIL_ATTACHMENT_EXT")]
    LayoutDepthStencilAttachmentEXT = 38287,

    [NativeName("GL_LAYOUT_DEPTH_STENCIL_READ_ONLY_EXT")]
    LayoutDepthStencilReadOnlyEXT = 38288,

    [NativeName("GL_LAYOUT_SHADER_READ_ONLY_EXT")]
    LayoutShaderReadOnlyEXT = 38289,

    [NativeName("GL_LAYOUT_TRANSFER_SRC_EXT")]
    LayoutTransferSrcEXT = 38290,

    [NativeName("GL_LAYOUT_TRANSFER_DST_EXT")]
    LayoutTransferDstEXT = 38291,

    [NativeName("GL_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_EXT")]
    LayoutDepthReadOnlyStencilAttachmentEXT = 38192,

    [NativeName("GL_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_EXT")]
    LayoutDepthAttachmentStencilReadOnlyEXT = 38193,

    [NativeName("GL_HANDLE_TYPE_D3D12_FENCE_EXT")]
    HandleTypeD3D12FenceEXT = 38292,

    [NativeName("GL_D3D12_FENCE_VALUE_EXT")]
    D3D12FenceValueEXT = 38293,

    [NativeName("GL_ACTIVE_PROGRAM_EXT")]
    ActiveProgramEXT = 33369,

    [NativeName("GL_LIGHT_MODEL_COLOR_CONTROL_EXT")]
    LightModelColorControlEXT = 33272,

    [NativeName("GL_SINGLE_COLOR_EXT")]
    SingleColorEXT = 33273,

    [NativeName("GL_SEPARATE_SPECULAR_COLOR_EXT")]
    SeparateSpecularColorEXT = 33274,

    [NativeName("GL_FRAGMENT_SHADER_DISCARDS_SAMPLES_EXT")]
    FragmentShaderDiscardsSamplesEXT = 35410,

    [NativeName("GL_MAX_IMAGE_UNITS_EXT")]
    MaxImageUnitsEXT = 36664,

    [NativeName("GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS_EXT")]
    MaxCombinedImageUnitsAndFragmentOutputsEXT = 36665,

    [NativeName("GL_IMAGE_BINDING_NAME_EXT")]
    ImageBindingNameEXT = 36666,

    [NativeName("GL_IMAGE_BINDING_LEVEL_EXT")]
    ImageBindingLevelEXT = 36667,

    [NativeName("GL_IMAGE_BINDING_LAYERED_EXT")]
    ImageBindingLayeredEXT = 36668,

    [NativeName("GL_IMAGE_BINDING_LAYER_EXT")]
    ImageBindingLayerEXT = 36669,

    [NativeName("GL_IMAGE_BINDING_ACCESS_EXT")]
    ImageBindingAccessEXT = 36670,

    [NativeName("GL_IMAGE_1D_EXT")]
    Image1DEXT = 36940,

    [NativeName("GL_IMAGE_2D_EXT")]
    Image2DEXT = 36941,

    [NativeName("GL_IMAGE_3D_EXT")]
    Image3DEXT = 36942,

    [NativeName("GL_IMAGE_2D_RECT_EXT")]
    Image2DRectEXT = 36943,

    [NativeName("GL_IMAGE_CUBE_EXT")]
    ImageCubeEXT = 36944,

    [NativeName("GL_IMAGE_BUFFER_EXT")]
    ImageBufferEXT = 36945,

    [NativeName("GL_IMAGE_1D_ARRAY_EXT")]
    Image1DArrayEXT = 36946,

    [NativeName("GL_IMAGE_2D_ARRAY_EXT")]
    Image2DArrayEXT = 36947,

    [NativeName("GL_IMAGE_CUBE_MAP_ARRAY_EXT")]
    ImageCubeMapArrayEXT = 36948,

    [NativeName("GL_IMAGE_2D_MULTISAMPLE_EXT")]
    Image2DMultisampleEXT = 36949,

    [NativeName("GL_IMAGE_2D_MULTISAMPLE_ARRAY_EXT")]
    Image2DMultisampleArrayEXT = 36950,

    [NativeName("GL_INT_IMAGE_1D_EXT")]
    IntImage1DEXT = 36951,

    [NativeName("GL_INT_IMAGE_2D_EXT")]
    IntImage2DEXT = 36952,

    [NativeName("GL_INT_IMAGE_3D_EXT")]
    IntImage3DEXT = 36953,

    [NativeName("GL_INT_IMAGE_2D_RECT_EXT")]
    IntImage2DRectEXT = 36954,

    [NativeName("GL_INT_IMAGE_CUBE_EXT")]
    IntImageCubeEXT = 36955,

    [NativeName("GL_INT_IMAGE_BUFFER_EXT")]
    IntImageBufferEXT = 36956,

    [NativeName("GL_INT_IMAGE_1D_ARRAY_EXT")]
    IntImage1DArrayEXT = 36957,

    [NativeName("GL_INT_IMAGE_2D_ARRAY_EXT")]
    IntImage2DArrayEXT = 36958,

    [NativeName("GL_INT_IMAGE_CUBE_MAP_ARRAY_EXT")]
    IntImageCubeMapArrayEXT = 36959,

    [NativeName("GL_INT_IMAGE_2D_MULTISAMPLE_EXT")]
    IntImage2DMultisampleEXT = 36960,

    [NativeName("GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT")]
    IntImage2DMultisampleArrayEXT = 36961,

    [NativeName("GL_UNSIGNED_INT_IMAGE_1D_EXT")]
    UnsignedIntImage1DEXT = 36962,

    [NativeName("GL_UNSIGNED_INT_IMAGE_2D_EXT")]
    UnsignedIntImage2DEXT = 36963,

    [NativeName("GL_UNSIGNED_INT_IMAGE_3D_EXT")]
    UnsignedIntImage3DEXT = 36964,

    [NativeName("GL_UNSIGNED_INT_IMAGE_2D_RECT_EXT")]
    UnsignedIntImage2DRectEXT = 36965,

    [NativeName("GL_UNSIGNED_INT_IMAGE_CUBE_EXT")]
    UnsignedIntImageCubeEXT = 36966,

    [NativeName("GL_UNSIGNED_INT_IMAGE_BUFFER_EXT")]
    UnsignedIntImageBufferEXT = 36967,

    [NativeName("GL_UNSIGNED_INT_IMAGE_1D_ARRAY_EXT")]
    UnsignedIntImage1DArrayEXT = 36968,

    [NativeName("GL_UNSIGNED_INT_IMAGE_2D_ARRAY_EXT")]
    UnsignedIntImage2DArrayEXT = 36969,

    [NativeName("GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_EXT")]
    UnsignedIntImageCubeMapArrayEXT = 36970,

    [NativeName("GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_EXT")]
    UnsignedIntImage2DMultisampleEXT = 36971,

    [NativeName("GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT")]
    UnsignedIntImage2DMultisampleArrayEXT = 36972,

    [NativeName("GL_MAX_IMAGE_SAMPLES_EXT")]
    MaxImageSamplesEXT = 36973,

    [NativeName("GL_IMAGE_BINDING_FORMAT_EXT")]
    ImageBindingFormatEXT = 36974,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT_EXT")]
    VertexAttribArrayBarrierBitEXT = 1,

    [NativeName("GL_ELEMENT_ARRAY_BARRIER_BIT_EXT")]
    ElementArrayBarrierBitEXT = 2,

    [NativeName("GL_UNIFORM_BARRIER_BIT_EXT")]
    UniformBarrierBitEXT = 4,

    [NativeName("GL_TEXTURE_FETCH_BARRIER_BIT_EXT")]
    TextureFetchBarrierBitEXT = 8,

    [NativeName("GL_SHADER_IMAGE_ACCESS_BARRIER_BIT_EXT")]
    ShaderImageAccessBarrierBitEXT = 32,

    [NativeName("GL_COMMAND_BARRIER_BIT_EXT")]
    CommandBarrierBitEXT = 64,

    [NativeName("GL_PIXEL_BUFFER_BARRIER_BIT_EXT")]
    PixelBufferBarrierBitEXT = 128,

    [NativeName("GL_TEXTURE_UPDATE_BARRIER_BIT_EXT")]
    TextureUpdateBarrierBitEXT = 256,

    [NativeName("GL_BUFFER_UPDATE_BARRIER_BIT_EXT")]
    BufferUpdateBarrierBitEXT = 512,

    [NativeName("GL_FRAMEBUFFER_BARRIER_BIT_EXT")]
    FramebufferBarrierBitEXT = 1024,

    [NativeName("GL_TRANSFORM_FEEDBACK_BARRIER_BIT_EXT")]
    TransformFeedbackBarrierBitEXT = 2048,

    [NativeName("GL_ATOMIC_COUNTER_BARRIER_BIT_EXT")]
    AtomicCounterBarrierBitEXT = 4096,

    [NativeName("GL_ALL_BARRIER_BITS_EXT")]
    AllBarrierBitsEXT = 4294967295,

    [NativeName("GL_SHARED_TEXTURE_PALETTE_EXT")]
    SharedTexturePaletteEXT = 33275,

    [NativeName("GL_STENCIL_TAG_BITS_EXT")]
    StencilTagBitsEXT = 35058,

    [NativeName("GL_STENCIL_CLEAR_TAG_VALUE_EXT")]
    StencilClearTagValueEXT = 35059,

    [NativeName("GL_STENCIL_TEST_TWO_SIDE_EXT")]
    StencilTestTwoSideEXT = 35088,

    [NativeName("GL_ACTIVE_STENCIL_FACE_EXT")]
    ActiveStencilFaceEXT = 35089,

    [NativeName("GL_INCR_WRAP_EXT")]
    IncrWrapEXT = 34055,

    [NativeName("GL_DECR_WRAP_EXT")]
    DecrWrapEXT = 34056,

    [NativeName("GL_ALPHA4_EXT")]
    Alpha4EXT = 32827,

    [NativeName("GL_ALPHA12_EXT")]
    Alpha12EXT = 32829,

    [NativeName("GL_ALPHA16_EXT")]
    Alpha16EXT = 32830,

    [NativeName("GL_LUMINANCE4_EXT")]
    Luminance4EXT = 32831,

    [NativeName("GL_LUMINANCE12_EXT")]
    Luminance12EXT = 32833,

    [NativeName("GL_LUMINANCE16_EXT")]
    Luminance16EXT = 32834,

    [NativeName("GL_LUMINANCE4_ALPHA4_EXT")]
    Luminance4Alpha4EXT = 32835,

    [NativeName("GL_LUMINANCE6_ALPHA2_EXT")]
    Luminance6Alpha2EXT = 32836,

    [NativeName("GL_LUMINANCE12_ALPHA4_EXT")]
    Luminance12Alpha4EXT = 32838,

    [NativeName("GL_LUMINANCE12_ALPHA12_EXT")]
    Luminance12Alpha12EXT = 32839,

    [NativeName("GL_LUMINANCE16_ALPHA16_EXT")]
    Luminance16Alpha16EXT = 32840,

    [NativeName("GL_INTENSITY_EXT")]
    IntensityEXT = 32841,

    [NativeName("GL_INTENSITY4_EXT")]
    Intensity4EXT = 32842,

    [NativeName("GL_INTENSITY8_EXT")]
    Intensity8EXT = 32843,

    [NativeName("GL_INTENSITY12_EXT")]
    Intensity12EXT = 32844,

    [NativeName("GL_INTENSITY16_EXT")]
    Intensity16EXT = 32845,

    [NativeName("GL_RGB2_EXT")]
    Rgb2EXT = 32846,

    [NativeName("GL_RGB4_EXT")]
    Rgb4EXT = 32847,

    [NativeName("GL_RGB5_EXT")]
    Rgb5EXT = 32848,

    [NativeName("GL_RGB8_EXT")]
    Rgb8EXT = 32849,

    [NativeName("GL_RGB12_EXT")]
    Rgb12EXT = 32851,

    [NativeName("GL_RGB16_EXT")]
    Rgb16EXT = 32852,

    [NativeName("GL_RGBA2_EXT")]
    Rgba2EXT = 32853,

    [NativeName("GL_RGBA4_EXT")]
    Rgba4EXT = 32854,

    [NativeName("GL_RGB5_A1_EXT")]
    Rgb5A1EXT = 32855,

    [NativeName("GL_RGBA8_EXT")]
    Rgba8EXT = 32856,

    [NativeName("GL_RGBA12_EXT")]
    Rgba12EXT = 32858,

    [NativeName("GL_RGBA16_EXT")]
    Rgba16EXT = 32859,

    [NativeName("GL_TEXTURE_RED_SIZE_EXT")]
    TextureRedSizeEXT = 32860,

    [NativeName("GL_TEXTURE_GREEN_SIZE_EXT")]
    TextureGreenSizeEXT = 32861,

    [NativeName("GL_TEXTURE_BLUE_SIZE_EXT")]
    TextureBlueSizeEXT = 32862,

    [NativeName("GL_TEXTURE_ALPHA_SIZE_EXT")]
    TextureAlphaSizeEXT = 32863,

    [NativeName("GL_TEXTURE_LUMINANCE_SIZE_EXT")]
    TextureLuminanceSizeEXT = 32864,

    [NativeName("GL_TEXTURE_INTENSITY_SIZE_EXT")]
    TextureIntensitySizeEXT = 32865,

    [NativeName("GL_REPLACE_EXT")]
    ReplaceEXT = 32866,

    [NativeName("GL_PROXY_TEXTURE_1D_EXT")]
    ProxyTexture1DEXT = 32867,

    [NativeName("GL_PROXY_TEXTURE_2D_EXT")]
    ProxyTexture2DEXT = 32868,

    [NativeName("GL_TEXTURE_TOO_LARGE_EXT")]
    TextureTooLargeEXT = 32869,

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

    [NativeName("GL_PROXY_TEXTURE_3D_EXT")]
    ProxyTexture3DEXT = 32880,

    [NativeName("GL_TEXTURE_DEPTH_EXT")]
    TextureDepthEXT = 32881,

    [NativeName("GL_TEXTURE_WRAP_R_EXT")]
    TextureWrapREXT = 32882,

    [NativeName("GL_MAX_3D_TEXTURE_SIZE_EXT")]
    Max3DTextureSizeEXT = 32883,

    [NativeName("GL_TEXTURE_1D_ARRAY_EXT")]
    Texture1DArrayEXT = 35864,

    [NativeName("GL_PROXY_TEXTURE_1D_ARRAY_EXT")]
    ProxyTexture1DArrayEXT = 35865,

    [NativeName("GL_TEXTURE_2D_ARRAY_EXT")]
    Texture2DArrayEXT = 35866,

    [NativeName("GL_PROXY_TEXTURE_2D_ARRAY_EXT")]
    ProxyTexture2DArrayEXT = 35867,

    [NativeName("GL_TEXTURE_BINDING_1D_ARRAY_EXT")]
    TextureBinding1DArrayEXT = 35868,

    [NativeName("GL_TEXTURE_BINDING_2D_ARRAY_EXT")]
    TextureBinding2DArrayEXT = 35869,

    [NativeName("GL_MAX_ARRAY_TEXTURE_LAYERS_EXT")]
    MaxArrayTextureLayersEXT = 35071,

    [NativeName("GL_COMPARE_REF_DEPTH_TO_TEXTURE_EXT")]
    CompareRefDepthToTextureEXT = 34894,

    [NativeName("GL_TEXTURE_BUFFER_EXT")]
    TextureBufferEXT = 35882,

    [NativeName("GL_MAX_TEXTURE_BUFFER_SIZE_EXT")]
    MaxTextureBufferSizeEXT = 35883,

    [NativeName("GL_TEXTURE_BINDING_BUFFER_EXT")]
    TextureBindingBufferEXT = 35884,

    [NativeName("GL_TEXTURE_BUFFER_DATA_STORE_BINDING_EXT")]
    TextureBufferDataStoreBindingEXT = 35885,

    [NativeName("GL_TEXTURE_BUFFER_FORMAT_EXT")]
    TextureBufferFormatEXT = 35886,

    [NativeName("GL_COMPRESSED_LUMINANCE_LATC1_EXT")]
    CompressedLuminanceLatc1EXT = 35952,

    [NativeName("GL_COMPRESSED_SIGNED_LUMINANCE_LATC1_EXT")]
    CompressedSignedLuminanceLatc1EXT = 35953,

    [NativeName("GL_COMPRESSED_LUMINANCE_ALPHA_LATC2_EXT")]
    CompressedLuminanceAlphaLatc2EXT = 35954,

    [NativeName("GL_COMPRESSED_SIGNED_LUMINANCE_ALPHA_LATC2_EXT")]
    CompressedSignedLuminanceAlphaLatc2EXT = 35955,

    [NativeName("GL_COMPRESSED_RED_RGTC1_EXT")]
    CompressedRedRgtc1EXT = 36283,

    [NativeName("GL_COMPRESSED_SIGNED_RED_RGTC1_EXT")]
    CompressedSignedRedRgtc1EXT = 36284,

    [NativeName("GL_COMPRESSED_RED_GREEN_RGTC2_EXT")]
    CompressedRedGreenRgtc2EXT = 36285,

    [NativeName("GL_COMPRESSED_SIGNED_RED_GREEN_RGTC2_EXT")]
    CompressedSignedRedGreenRgtc2EXT = 36286,

    [NativeName("GL_COMPRESSED_RGBA_S3TC_DXT3_EXT")]
    CompressedRgbaS3TcDxt3EXT = 33778,

    [NativeName("GL_COMPRESSED_RGBA_S3TC_DXT5_EXT")]
    CompressedRgbaS3TcDxt5EXT = 33779,

    [NativeName("GL_NORMAL_MAP_EXT")]
    NormalMapEXT = 34065,

    [NativeName("GL_REFLECTION_MAP_EXT")]
    ReflectionMapEXT = 34066,

    [NativeName("GL_TEXTURE_CUBE_MAP_EXT")]
    TextureCubeMapEXT = 34067,

    [NativeName("GL_TEXTURE_BINDING_CUBE_MAP_EXT")]
    TextureBindingCubeMapEXT = 34068,

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_X_EXT")]
    TextureCubeMapPositiveXEXT = 34069,

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_X_EXT")]
    TextureCubeMapNegativeXEXT = 34070,

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Y_EXT")]
    TextureCubeMapPositiveYEXT = 34071,

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_EXT")]
    TextureCubeMapNegativeYEXT = 34072,

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Z_EXT")]
    TextureCubeMapPositiveZEXT = 34073,

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_EXT")]
    TextureCubeMapNegativeZEXT = 34074,

    [NativeName("GL_PROXY_TEXTURE_CUBE_MAP_EXT")]
    ProxyTextureCubeMapEXT = 34075,

    [NativeName("GL_MAX_CUBE_MAP_TEXTURE_SIZE_EXT")]
    MaxCubeMapTextureSizeEXT = 34076,

    [NativeName("GL_COMBINE_EXT")]
    CombineEXT = 34160,

    [NativeName("GL_COMBINE_RGB_EXT")]
    CombineRgbEXT = 34161,

    [NativeName("GL_COMBINE_ALPHA_EXT")]
    CombineAlphaEXT = 34162,

    [NativeName("GL_RGB_SCALE_EXT")]
    RgbScaleEXT = 34163,

    [NativeName("GL_ADD_SIGNED_EXT")]
    AddSignedEXT = 34164,

    [NativeName("GL_INTERPOLATE_EXT")]
    InterpolateEXT = 34165,

    [NativeName("GL_CONSTANT_EXT")]
    ConstantEXT = 34166,

    [NativeName("GL_PRIMARY_COLOR_EXT")]
    PrimaryColorEXT = 34167,

    [NativeName("GL_PREVIOUS_EXT")]
    PreviousEXT = 34168,

    [NativeName("GL_SOURCE0_RGB_EXT")]
    Source0RgbEXT = 34176,

    [NativeName("GL_SOURCE1_RGB_EXT")]
    Source1RgbEXT = 34177,

    [NativeName("GL_SOURCE2_RGB_EXT")]
    Source2RgbEXT = 34178,

    [NativeName("GL_SOURCE0_ALPHA_EXT")]
    Source0AlphaEXT = 34184,

    [NativeName("GL_SOURCE1_ALPHA_EXT")]
    Source1AlphaEXT = 34185,

    [NativeName("GL_SOURCE2_ALPHA_EXT")]
    Source2AlphaEXT = 34186,

    [NativeName("GL_OPERAND0_RGB_EXT")]
    Operand0RgbEXT = 34192,

    [NativeName("GL_OPERAND1_RGB_EXT")]
    Operand1RgbEXT = 34193,

    [NativeName("GL_OPERAND2_RGB_EXT")]
    Operand2RgbEXT = 34194,

    [NativeName("GL_OPERAND0_ALPHA_EXT")]
    Operand0AlphaEXT = 34200,

    [NativeName("GL_OPERAND1_ALPHA_EXT")]
    Operand1AlphaEXT = 34201,

    [NativeName("GL_OPERAND2_ALPHA_EXT")]
    Operand2AlphaEXT = 34202,

    [NativeName("GL_DOT3_RGB_EXT")]
    Dot3RgbEXT = 34624,

    [NativeName("GL_DOT3_RGBA_EXT")]
    Dot3RgbaEXT = 34625,

    [NativeName("GL_TEXTURE_REDUCTION_MODE_EXT")]
    TextureReductionModeEXT = 37734,

    [NativeName("GL_WEIGHTED_AVERAGE_EXT")]
    WeightedAverageEXT = 37735,

    [NativeName("GL_RGBA32UI_EXT")]
    Rgba32UiEXT = 36208,

    [NativeName("GL_RGB32UI_EXT")]
    Rgb32UiEXT = 36209,

    [NativeName("GL_ALPHA32UI_EXT")]
    Alpha32UiEXT = 36210,

    [NativeName("GL_INTENSITY32UI_EXT")]
    Intensity32UiEXT = 36211,

    [NativeName("GL_LUMINANCE32UI_EXT")]
    Luminance32UiEXT = 36212,

    [NativeName("GL_LUMINANCE_ALPHA32UI_EXT")]
    LuminanceAlpha32UiEXT = 36213,

    [NativeName("GL_RGBA16UI_EXT")]
    Rgba16UiEXT = 36214,

    [NativeName("GL_RGB16UI_EXT")]
    Rgb16UiEXT = 36215,

    [NativeName("GL_ALPHA16UI_EXT")]
    Alpha16UiEXT = 36216,

    [NativeName("GL_INTENSITY16UI_EXT")]
    Intensity16UiEXT = 36217,

    [NativeName("GL_LUMINANCE16UI_EXT")]
    Luminance16UiEXT = 36218,

    [NativeName("GL_LUMINANCE_ALPHA16UI_EXT")]
    LuminanceAlpha16UiEXT = 36219,

    [NativeName("GL_RGBA8UI_EXT")]
    Rgba8UiEXT = 36220,

    [NativeName("GL_RGB8UI_EXT")]
    Rgb8UiEXT = 36221,

    [NativeName("GL_ALPHA8UI_EXT")]
    Alpha8UiEXT = 36222,

    [NativeName("GL_INTENSITY8UI_EXT")]
    Intensity8UiEXT = 36223,

    [NativeName("GL_LUMINANCE8UI_EXT")]
    Luminance8UiEXT = 36224,

    [NativeName("GL_LUMINANCE_ALPHA8UI_EXT")]
    LuminanceAlpha8UiEXT = 36225,

    [NativeName("GL_RGBA32I_EXT")]
    Rgba32IEXT = 36226,

    [NativeName("GL_RGB32I_EXT")]
    Rgb32IEXT = 36227,

    [NativeName("GL_ALPHA32I_EXT")]
    Alpha32IEXT = 36228,

    [NativeName("GL_INTENSITY32I_EXT")]
    Intensity32IEXT = 36229,

    [NativeName("GL_LUMINANCE32I_EXT")]
    Luminance32IEXT = 36230,

    [NativeName("GL_LUMINANCE_ALPHA32I_EXT")]
    LuminanceAlpha32IEXT = 36231,

    [NativeName("GL_RGBA16I_EXT")]
    Rgba16IEXT = 36232,

    [NativeName("GL_RGB16I_EXT")]
    Rgb16IEXT = 36233,

    [NativeName("GL_ALPHA16I_EXT")]
    Alpha16IEXT = 36234,

    [NativeName("GL_INTENSITY16I_EXT")]
    Intensity16IEXT = 36235,

    [NativeName("GL_LUMINANCE16I_EXT")]
    Luminance16IEXT = 36236,

    [NativeName("GL_LUMINANCE_ALPHA16I_EXT")]
    LuminanceAlpha16IEXT = 36237,

    [NativeName("GL_RGBA8I_EXT")]
    Rgba8IEXT = 36238,

    [NativeName("GL_RGB8I_EXT")]
    Rgb8IEXT = 36239,

    [NativeName("GL_ALPHA8I_EXT")]
    Alpha8IEXT = 36240,

    [NativeName("GL_INTENSITY8I_EXT")]
    Intensity8IEXT = 36241,

    [NativeName("GL_LUMINANCE8I_EXT")]
    Luminance8IEXT = 36242,

    [NativeName("GL_LUMINANCE_ALPHA8I_EXT")]
    LuminanceAlpha8IEXT = 36243,

    [NativeName("GL_RED_INTEGER_EXT")]
    RedIntegerEXT = 36244,

    [NativeName("GL_GREEN_INTEGER_EXT")]
    GreenIntegerEXT = 36245,

    [NativeName("GL_BLUE_INTEGER_EXT")]
    BlueIntegerEXT = 36246,

    [NativeName("GL_ALPHA_INTEGER_EXT")]
    AlphaIntegerEXT = 36247,

    [NativeName("GL_RGB_INTEGER_EXT")]
    RgbIntegerEXT = 36248,

    [NativeName("GL_RGBA_INTEGER_EXT")]
    RgbaIntegerEXT = 36249,

    [NativeName("GL_BGR_INTEGER_EXT")]
    BgrIntegerEXT = 36250,

    [NativeName("GL_BGRA_INTEGER_EXT")]
    BgraIntegerEXT = 36251,

    [NativeName("GL_LUMINANCE_INTEGER_EXT")]
    LuminanceIntegerEXT = 36252,

    [NativeName("GL_LUMINANCE_ALPHA_INTEGER_EXT")]
    LuminanceAlphaIntegerEXT = 36253,

    [NativeName("GL_RGBA_INTEGER_MODE_EXT")]
    RgbaIntegerModeEXT = 36254,

    [NativeName("GL_MIRROR_CLAMP_EXT")]
    MirrorClampEXT = 34626,

    [NativeName("GL_MIRROR_CLAMP_TO_EDGE_EXT")]
    MirrorClampToEdgeEXT = 34627,

    [NativeName("GL_MIRROR_CLAMP_TO_BORDER_EXT")]
    MirrorClampToBorderEXT = 35090,

    [NativeName("GL_TEXTURE_PRIORITY_EXT")]
    TexturePriorityEXT = 32870,

    [NativeName("GL_TEXTURE_RESIDENT_EXT")]
    TextureResidentEXT = 32871,

    [NativeName("GL_TEXTURE_1D_BINDING_EXT")]
    Texture1DBindingEXT = 32872,

    [NativeName("GL_TEXTURE_2D_BINDING_EXT")]
    Texture2DBindingEXT = 32873,

    [NativeName("GL_TEXTURE_3D_BINDING_EXT")]
    Texture3DBindingEXT = 32874,

    [NativeName("GL_PERTURB_EXT")]
    PerturbEXT = 34222,

    [NativeName("GL_TEXTURE_NORMAL_EXT")]
    TextureNormalEXT = 34223,

    [NativeName("GL_SRGB8_EXT")]
    Srgb8EXT = 35905,

    [NativeName("GL_SLUMINANCE_ALPHA_EXT")]
    SluminanceAlphaEXT = 35908,

    [NativeName("GL_SLUMINANCE8_ALPHA8_EXT")]
    Sluminance8Alpha8EXT = 35909,

    [NativeName("GL_SLUMINANCE_EXT")]
    SluminanceEXT = 35910,

    [NativeName("GL_SLUMINANCE8_EXT")]
    Sluminance8EXT = 35911,

    [NativeName("GL_COMPRESSED_SRGB_EXT")]
    CompressedSrgbEXT = 35912,

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_EXT")]
    CompressedSrgbAlphaEXT = 35913,

    [NativeName("GL_COMPRESSED_SLUMINANCE_EXT")]
    CompressedSluminanceEXT = 35914,

    [NativeName("GL_COMPRESSED_SLUMINANCE_ALPHA_EXT")]
    CompressedSluminanceAlphaEXT = 35915,

    [NativeName("GL_COMPRESSED_SRGB_S3TC_DXT1_EXT")]
    CompressedSrgbS3TcDxt1EXT = 35916,

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT")]
    CompressedSrgbAlphaS3TcDxt1EXT = 35917,

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT")]
    CompressedSrgbAlphaS3TcDxt3EXT = 35918,

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT")]
    CompressedSrgbAlphaS3TcDxt5EXT = 35919,

    [NativeName("GL_SR8_EXT")]
    Sr8EXT = 36797,

    [NativeName("GL_SRG8_EXT")]
    Srg8EXT = 36798,

    [NativeName("GL_TEXTURE_SRGB_DECODE_EXT")]
    TextureSrgbDecodeEXT = 35400,

    [NativeName("GL_DECODE_EXT")]
    DecodeEXT = 35401,

    [NativeName("GL_SKIP_DECODE_EXT")]
    SkipDecodeEXT = 35402,

    [NativeName("GL_RGB9_E5_EXT")]
    Rgb9E5EXT = 35901,

    [NativeName("GL_UNSIGNED_INT_5_9_9_9_REV_EXT")]
    UnsignedInt5X9X9X9RevEXT = 35902,

    [NativeName("GL_TEXTURE_SHARED_SIZE_EXT")]
    TextureSharedSizeEXT = 35903,

    [NativeName("GL_ALPHA_SNORM")]
    AlphaSnorm = 36880,

    [NativeName("GL_LUMINANCE_SNORM")]
    LuminanceSnorm = 36881,

    [NativeName("GL_LUMINANCE_ALPHA_SNORM")]
    LuminanceAlphaSnorm = 36882,

    [NativeName("GL_INTENSITY_SNORM")]
    IntensitySnorm = 36883,

    [NativeName("GL_ALPHA8_SNORM")]
    Alpha8Snorm = 36884,

    [NativeName("GL_LUMINANCE8_SNORM")]
    Luminance8Snorm = 36885,

    [NativeName("GL_LUMINANCE8_ALPHA8_SNORM")]
    Luminance8Alpha8Snorm = 36886,

    [NativeName("GL_INTENSITY8_SNORM")]
    Intensity8Snorm = 36887,

    [NativeName("GL_ALPHA16_SNORM")]
    Alpha16Snorm = 36888,

    [NativeName("GL_LUMINANCE16_SNORM")]
    Luminance16Snorm = 36889,

    [NativeName("GL_LUMINANCE16_ALPHA16_SNORM")]
    Luminance16Alpha16Snorm = 36890,

    [NativeName("GL_INTENSITY16_SNORM")]
    Intensity16Snorm = 36891,

    [NativeName("GL_RED_SNORM")]
    RedSnorm = 36752,

    [NativeName("GL_RG_SNORM")]
    RgSnorm = 36753,

    [NativeName("GL_RGB_SNORM")]
    RgbSnorm = 36754,

    [NativeName("GL_RGBA_SNORM")]
    RgbaSnorm = 36755,

    [NativeName("GL_TEXTURE_SWIZZLE_R_EXT")]
    TextureSwizzleREXT = 36418,

    [NativeName("GL_TEXTURE_SWIZZLE_G_EXT")]
    TextureSwizzleGEXT = 36419,

    [NativeName("GL_TEXTURE_SWIZZLE_B_EXT")]
    TextureSwizzleBEXT = 36420,

    [NativeName("GL_TEXTURE_SWIZZLE_A_EXT")]
    TextureSwizzleAEXT = 36421,

    [NativeName("GL_TEXTURE_SWIZZLE_RGBA_EXT")]
    TextureSwizzleRgbaEXT = 36422,

    [NativeName("GL_TIME_ELAPSED_EXT")]
    TimeElapsedEXT = 35007,

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_EXT")]
    TransformFeedbackBufferEXT = 35982,

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_START_EXT")]
    TransformFeedbackBufferStartEXT = 35972,

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_SIZE_EXT")]
    TransformFeedbackBufferSizeEXT = 35973,

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_BINDING_EXT")]
    TransformFeedbackBufferBindingEXT = 35983,

    [NativeName("GL_INTERLEAVED_ATTRIBS_EXT")]
    InterleavedAttribsEXT = 35980,

    [NativeName("GL_SEPARATE_ATTRIBS_EXT")]
    SeparateAttribsEXT = 35981,

    [NativeName("GL_PRIMITIVES_GENERATED_EXT")]
    PrimitivesGeneratedEXT = 35975,

    [NativeName("GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN_EXT")]
    TransformFeedbackPrimitivesWrittenEXT = 35976,

    [NativeName("GL_RASTERIZER_DISCARD_EXT")]
    RasterizerDiscardEXT = 35977,

    [NativeName("GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS_EXT")]
    MaxTransformFeedbackInterleavedComponentsEXT = 35978,

    [NativeName("GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS_EXT")]
    MaxTransformFeedbackSeparateAttribsEXT = 35979,

    [NativeName("GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS_EXT")]
    MaxTransformFeedbackSeparateComponentsEXT = 35968,

    [NativeName("GL_TRANSFORM_FEEDBACK_VARYINGS_EXT")]
    TransformFeedbackVaryingsEXT = 35971,

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_MODE_EXT")]
    TransformFeedbackBufferModeEXT = 35967,

    [NativeName("GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH_EXT")]
    TransformFeedbackVaryingMaxLengthEXT = 35958,

    [NativeName("GL_VERTEX_ARRAY_EXT")]
    VertexArrayEXT = 32884,

    [NativeName("GL_NORMAL_ARRAY_EXT")]
    NormalArrayEXT = 32885,

    [NativeName("GL_COLOR_ARRAY_EXT")]
    ColorArrayEXT = 32886,

    [NativeName("GL_INDEX_ARRAY_EXT")]
    IndexArrayEXT = 32887,

    [NativeName("GL_TEXTURE_COORD_ARRAY_EXT")]
    TextureCoordArrayEXT = 32888,

    [NativeName("GL_EDGE_FLAG_ARRAY_EXT")]
    EdgeFlagArrayEXT = 32889,

    [NativeName("GL_VERTEX_ARRAY_SIZE_EXT")]
    VertexArraySizeEXT = 32890,

    [NativeName("GL_VERTEX_ARRAY_TYPE_EXT")]
    VertexArrayTypeEXT = 32891,

    [NativeName("GL_VERTEX_ARRAY_STRIDE_EXT")]
    VertexArrayStrideEXT = 32892,

    [NativeName("GL_VERTEX_ARRAY_COUNT_EXT")]
    VertexArrayCountEXT = 32893,

    [NativeName("GL_NORMAL_ARRAY_TYPE_EXT")]
    NormalArrayTypeEXT = 32894,

    [NativeName("GL_NORMAL_ARRAY_STRIDE_EXT")]
    NormalArrayStrideEXT = 32895,

    [NativeName("GL_NORMAL_ARRAY_COUNT_EXT")]
    NormalArrayCountEXT = 32896,

    [NativeName("GL_COLOR_ARRAY_SIZE_EXT")]
    ColorArraySizeEXT = 32897,

    [NativeName("GL_COLOR_ARRAY_TYPE_EXT")]
    ColorArrayTypeEXT = 32898,

    [NativeName("GL_COLOR_ARRAY_STRIDE_EXT")]
    ColorArrayStrideEXT = 32899,

    [NativeName("GL_COLOR_ARRAY_COUNT_EXT")]
    ColorArrayCountEXT = 32900,

    [NativeName("GL_INDEX_ARRAY_TYPE_EXT")]
    IndexArrayTypeEXT = 32901,

    [NativeName("GL_INDEX_ARRAY_STRIDE_EXT")]
    IndexArrayStrideEXT = 32902,

    [NativeName("GL_INDEX_ARRAY_COUNT_EXT")]
    IndexArrayCountEXT = 32903,

    [NativeName("GL_TEXTURE_COORD_ARRAY_SIZE_EXT")]
    TextureCoordArraySizeEXT = 32904,

    [NativeName("GL_TEXTURE_COORD_ARRAY_TYPE_EXT")]
    TextureCoordArrayTypeEXT = 32905,

    [NativeName("GL_TEXTURE_COORD_ARRAY_STRIDE_EXT")]
    TextureCoordArrayStrideEXT = 32906,

    [NativeName("GL_TEXTURE_COORD_ARRAY_COUNT_EXT")]
    TextureCoordArrayCountEXT = 32907,

    [NativeName("GL_EDGE_FLAG_ARRAY_STRIDE_EXT")]
    EdgeFlagArrayStrideEXT = 32908,

    [NativeName("GL_EDGE_FLAG_ARRAY_COUNT_EXT")]
    EdgeFlagArrayCountEXT = 32909,

    [NativeName("GL_VERTEX_ARRAY_POINTER_EXT")]
    VertexArrayPointerEXT = 32910,

    [NativeName("GL_NORMAL_ARRAY_POINTER_EXT")]
    NormalArrayPointerEXT = 32911,

    [NativeName("GL_COLOR_ARRAY_POINTER_EXT")]
    ColorArrayPointerEXT = 32912,

    [NativeName("GL_INDEX_ARRAY_POINTER_EXT")]
    IndexArrayPointerEXT = 32913,

    [NativeName("GL_TEXTURE_COORD_ARRAY_POINTER_EXT")]
    TextureCoordArrayPointerEXT = 32914,

    [NativeName("GL_EDGE_FLAG_ARRAY_POINTER_EXT")]
    EdgeFlagArrayPointerEXT = 32915,

    [NativeName("GL_DOUBLE_VEC2_EXT")]
    DoubleVec2EXT = 36860,

    [NativeName("GL_DOUBLE_VEC3_EXT")]
    DoubleVec3EXT = 36861,

    [NativeName("GL_DOUBLE_VEC4_EXT")]
    DoubleVec4EXT = 36862,

    [NativeName("GL_DOUBLE_MAT2_EXT")]
    DoubleMat2EXT = 36678,

    [NativeName("GL_DOUBLE_MAT3_EXT")]
    DoubleMat3EXT = 36679,

    [NativeName("GL_DOUBLE_MAT4_EXT")]
    DoubleMat4EXT = 36680,

    [NativeName("GL_DOUBLE_MAT2x3_EXT")]
    DoubleMat2X3EXT = 36681,

    [NativeName("GL_DOUBLE_MAT2x4_EXT")]
    DoubleMat2X4EXT = 36682,

    [NativeName("GL_DOUBLE_MAT3x2_EXT")]
    DoubleMat3X2EXT = 36683,

    [NativeName("GL_DOUBLE_MAT3x4_EXT")]
    DoubleMat3X4EXT = 36684,

    [NativeName("GL_DOUBLE_MAT4x2_EXT")]
    DoubleMat4X2EXT = 36685,

    [NativeName("GL_DOUBLE_MAT4x3_EXT")]
    DoubleMat4X3EXT = 36686,

    [NativeName("GL_VERTEX_SHADER_EXT")]
    VertexShaderEXT = 34688,

    [NativeName("GL_VERTEX_SHADER_BINDING_EXT")]
    VertexShaderBindingEXT = 34689,

    [NativeName("GL_OP_INDEX_EXT")]
    OpIndexEXT = 34690,

    [NativeName("GL_OP_NEGATE_EXT")]
    OpNegateEXT = 34691,

    [NativeName("GL_OP_DOT3_EXT")]
    OpDot3EXT = 34692,

    [NativeName("GL_OP_DOT4_EXT")]
    OpDot4EXT = 34693,

    [NativeName("GL_OP_MUL_EXT")]
    OpMulEXT = 34694,

    [NativeName("GL_OP_ADD_EXT")]
    OpAddEXT = 34695,

    [NativeName("GL_OP_MADD_EXT")]
    OpMaddEXT = 34696,

    [NativeName("GL_OP_FRAC_EXT")]
    OpFracEXT = 34697,

    [NativeName("GL_OP_MAX_EXT")]
    OpMaxEXT = 34698,

    [NativeName("GL_OP_MIN_EXT")]
    OpMinEXT = 34699,

    [NativeName("GL_OP_SET_GE_EXT")]
    OpSetGeEXT = 34700,

    [NativeName("GL_OP_SET_LT_EXT")]
    OpSetLtEXT = 34701,

    [NativeName("GL_OP_CLAMP_EXT")]
    OpClampEXT = 34702,

    [NativeName("GL_OP_FLOOR_EXT")]
    OpFloorEXT = 34703,

    [NativeName("GL_OP_ROUND_EXT")]
    OpRoundEXT = 34704,

    [NativeName("GL_OP_EXP_BASE_2_EXT")]
    OpExpBase2EXT = 34705,

    [NativeName("GL_OP_LOG_BASE_2_EXT")]
    OpLogBase2EXT = 34706,

    [NativeName("GL_OP_POWER_EXT")]
    OpPowerEXT = 34707,

    [NativeName("GL_OP_RECIP_EXT")]
    OpRecipEXT = 34708,

    [NativeName("GL_OP_RECIP_SQRT_EXT")]
    OpRecipSqrtEXT = 34709,

    [NativeName("GL_OP_SUB_EXT")]
    OpSubEXT = 34710,

    [NativeName("GL_OP_CROSS_PRODUCT_EXT")]
    OpCrossProductEXT = 34711,

    [NativeName("GL_OP_MULTIPLY_MATRIX_EXT")]
    OpMultiplyMatrixEXT = 34712,

    [NativeName("GL_OP_MOV_EXT")]
    OpMovEXT = 34713,

    [NativeName("GL_OUTPUT_VERTEX_EXT")]
    OutputVertexEXT = 34714,

    [NativeName("GL_OUTPUT_COLOR0_EXT")]
    OutputColor0EXT = 34715,

    [NativeName("GL_OUTPUT_COLOR1_EXT")]
    OutputColor1EXT = 34716,

    [NativeName("GL_OUTPUT_TEXTURE_COORD0_EXT")]
    OutputTextureCoord0EXT = 34717,

    [NativeName("GL_OUTPUT_TEXTURE_COORD1_EXT")]
    OutputTextureCoord1EXT = 34718,

    [NativeName("GL_OUTPUT_TEXTURE_COORD2_EXT")]
    OutputTextureCoord2EXT = 34719,

    [NativeName("GL_OUTPUT_TEXTURE_COORD3_EXT")]
    OutputTextureCoord3EXT = 34720,

    [NativeName("GL_OUTPUT_TEXTURE_COORD4_EXT")]
    OutputTextureCoord4EXT = 34721,

    [NativeName("GL_OUTPUT_TEXTURE_COORD5_EXT")]
    OutputTextureCoord5EXT = 34722,

    [NativeName("GL_OUTPUT_TEXTURE_COORD6_EXT")]
    OutputTextureCoord6EXT = 34723,

    [NativeName("GL_OUTPUT_TEXTURE_COORD7_EXT")]
    OutputTextureCoord7EXT = 34724,

    [NativeName("GL_OUTPUT_TEXTURE_COORD8_EXT")]
    OutputTextureCoord8EXT = 34725,

    [NativeName("GL_OUTPUT_TEXTURE_COORD9_EXT")]
    OutputTextureCoord9EXT = 34726,

    [NativeName("GL_OUTPUT_TEXTURE_COORD10_EXT")]
    OutputTextureCoord10EXT = 34727,

    [NativeName("GL_OUTPUT_TEXTURE_COORD11_EXT")]
    OutputTextureCoord11EXT = 34728,

    [NativeName("GL_OUTPUT_TEXTURE_COORD12_EXT")]
    OutputTextureCoord12EXT = 34729,

    [NativeName("GL_OUTPUT_TEXTURE_COORD13_EXT")]
    OutputTextureCoord13EXT = 34730,

    [NativeName("GL_OUTPUT_TEXTURE_COORD14_EXT")]
    OutputTextureCoord14EXT = 34731,

    [NativeName("GL_OUTPUT_TEXTURE_COORD15_EXT")]
    OutputTextureCoord15EXT = 34732,

    [NativeName("GL_OUTPUT_TEXTURE_COORD16_EXT")]
    OutputTextureCoord16EXT = 34733,

    [NativeName("GL_OUTPUT_TEXTURE_COORD17_EXT")]
    OutputTextureCoord17EXT = 34734,

    [NativeName("GL_OUTPUT_TEXTURE_COORD18_EXT")]
    OutputTextureCoord18EXT = 34735,

    [NativeName("GL_OUTPUT_TEXTURE_COORD19_EXT")]
    OutputTextureCoord19EXT = 34736,

    [NativeName("GL_OUTPUT_TEXTURE_COORD20_EXT")]
    OutputTextureCoord20EXT = 34737,

    [NativeName("GL_OUTPUT_TEXTURE_COORD21_EXT")]
    OutputTextureCoord21EXT = 34738,

    [NativeName("GL_OUTPUT_TEXTURE_COORD22_EXT")]
    OutputTextureCoord22EXT = 34739,

    [NativeName("GL_OUTPUT_TEXTURE_COORD23_EXT")]
    OutputTextureCoord23EXT = 34740,

    [NativeName("GL_OUTPUT_TEXTURE_COORD24_EXT")]
    OutputTextureCoord24EXT = 34741,

    [NativeName("GL_OUTPUT_TEXTURE_COORD25_EXT")]
    OutputTextureCoord25EXT = 34742,

    [NativeName("GL_OUTPUT_TEXTURE_COORD26_EXT")]
    OutputTextureCoord26EXT = 34743,

    [NativeName("GL_OUTPUT_TEXTURE_COORD27_EXT")]
    OutputTextureCoord27EXT = 34744,

    [NativeName("GL_OUTPUT_TEXTURE_COORD28_EXT")]
    OutputTextureCoord28EXT = 34745,

    [NativeName("GL_OUTPUT_TEXTURE_COORD29_EXT")]
    OutputTextureCoord29EXT = 34746,

    [NativeName("GL_OUTPUT_TEXTURE_COORD30_EXT")]
    OutputTextureCoord30EXT = 34747,

    [NativeName("GL_OUTPUT_TEXTURE_COORD31_EXT")]
    OutputTextureCoord31EXT = 34748,

    [NativeName("GL_OUTPUT_FOG_EXT")]
    OutputFogEXT = 34749,

    [NativeName("GL_SCALAR_EXT")]
    ScalarEXT = 34750,

    [NativeName("GL_VECTOR_EXT")]
    VectorEXT = 34751,

    [NativeName("GL_MATRIX_EXT")]
    MatrixEXT = 34752,

    [NativeName("GL_VARIANT_EXT")]
    VariantEXT = 34753,

    [NativeName("GL_INVARIANT_EXT")]
    InvariantEXT = 34754,

    [NativeName("GL_LOCAL_CONSTANT_EXT")]
    LocalConstantEXT = 34755,

    [NativeName("GL_LOCAL_EXT")]
    LocalEXT = 34756,

    [NativeName("GL_MAX_VERTEX_SHADER_INSTRUCTIONS_EXT")]
    MaxVertexShaderInstructionsEXT = 34757,

    [NativeName("GL_MAX_VERTEX_SHADER_VARIANTS_EXT")]
    MaxVertexShaderVariantsEXT = 34758,

    [NativeName("GL_MAX_VERTEX_SHADER_INVARIANTS_EXT")]
    MaxVertexShaderInvariantsEXT = 34759,

    [NativeName("GL_MAX_VERTEX_SHADER_LOCAL_CONSTANTS_EXT")]
    MaxVertexShaderLocalConstantsEXT = 34760,

    [NativeName("GL_MAX_VERTEX_SHADER_LOCALS_EXT")]
    MaxVertexShaderLocalsEXT = 34761,

    [NativeName("GL_MAX_OPTIMIZED_VERTEX_SHADER_INSTRUCTIONS_EXT")]
    MaxOptimizedVertexShaderInstructionsEXT = 34762,

    [NativeName("GL_MAX_OPTIMIZED_VERTEX_SHADER_VARIANTS_EXT")]
    MaxOptimizedVertexShaderVariantsEXT = 34763,

    [NativeName("GL_MAX_OPTIMIZED_VERTEX_SHADER_LOCAL_CONSTANTS_EXT")]
    MaxOptimizedVertexShaderLocalConstantsEXT = 34764,

    [NativeName("GL_MAX_OPTIMIZED_VERTEX_SHADER_INVARIANTS_EXT")]
    MaxOptimizedVertexShaderInvariantsEXT = 34765,

    [NativeName("GL_MAX_OPTIMIZED_VERTEX_SHADER_LOCALS_EXT")]
    MaxOptimizedVertexShaderLocalsEXT = 34766,

    [NativeName("GL_VERTEX_SHADER_INSTRUCTIONS_EXT")]
    VertexShaderInstructionsEXT = 34767,

    [NativeName("GL_VERTEX_SHADER_VARIANTS_EXT")]
    VertexShaderVariantsEXT = 34768,

    [NativeName("GL_VERTEX_SHADER_INVARIANTS_EXT")]
    VertexShaderInvariantsEXT = 34769,

    [NativeName("GL_VERTEX_SHADER_LOCAL_CONSTANTS_EXT")]
    VertexShaderLocalConstantsEXT = 34770,

    [NativeName("GL_VERTEX_SHADER_LOCALS_EXT")]
    VertexShaderLocalsEXT = 34771,

    [NativeName("GL_VERTEX_SHADER_OPTIMIZED_EXT")]
    VertexShaderOptimizedEXT = 34772,

    [NativeName("GL_X_EXT")]
    Xext = 34773,

    [NativeName("GL_Y_EXT")]
    Yext = 34774,

    [NativeName("GL_Z_EXT")]
    Zext = 34775,

    [NativeName("GL_W_EXT")]
    Wext = 34776,

    [NativeName("GL_NEGATIVE_X_EXT")]
    NegativeXEXT = 34777,

    [NativeName("GL_NEGATIVE_Y_EXT")]
    NegativeYEXT = 34778,

    [NativeName("GL_NEGATIVE_Z_EXT")]
    NegativeZEXT = 34779,

    [NativeName("GL_NEGATIVE_W_EXT")]
    NegativeWEXT = 34780,

    [NativeName("GL_ZERO_EXT")]
    ZeroEXT = 34781,

    [NativeName("GL_ONE_EXT")]
    OneEXT = 34782,

    [NativeName("GL_NEGATIVE_ONE_EXT")]
    NegativeOneEXT = 34783,

    [NativeName("GL_NORMALIZED_RANGE_EXT")]
    NormalizedRangeEXT = 34784,

    [NativeName("GL_FULL_RANGE_EXT")]
    FullRangeEXT = 34785,

    [NativeName("GL_CURRENT_VERTEX_EXT")]
    CurrentVertexEXT = 34786,

    [NativeName("GL_MVP_MATRIX_EXT")]
    MvpMatrixEXT = 34787,

    [NativeName("GL_VARIANT_VALUE_EXT")]
    VariantValueEXT = 34788,

    [NativeName("GL_VARIANT_DATATYPE_EXT")]
    VariantDatatypeEXT = 34789,

    [NativeName("GL_VARIANT_ARRAY_STRIDE_EXT")]
    VariantArrayStrideEXT = 34790,

    [NativeName("GL_VARIANT_ARRAY_TYPE_EXT")]
    VariantArrayTypeEXT = 34791,

    [NativeName("GL_VARIANT_ARRAY_EXT")]
    VariantArrayEXT = 34792,

    [NativeName("GL_VARIANT_ARRAY_POINTER_EXT")]
    VariantArrayPointerEXT = 34793,

    [NativeName("GL_INVARIANT_VALUE_EXT")]
    InvariantValueEXT = 34794,

    [NativeName("GL_INVARIANT_DATATYPE_EXT")]
    InvariantDatatypeEXT = 34795,

    [NativeName("GL_LOCAL_CONSTANT_VALUE_EXT")]
    LocalConstantValueEXT = 34796,

    [NativeName("GL_LOCAL_CONSTANT_DATATYPE_EXT")]
    LocalConstantDatatypeEXT = 34797,

    [NativeName("GL_MODELVIEW0_STACK_DEPTH_EXT")]
    Modelview0StackDepthEXT = 2979,

    [NativeName("GL_MODELVIEW1_STACK_DEPTH_EXT")]
    Modelview1StackDepthEXT = 34050,

    [NativeName("GL_MODELVIEW0_MATRIX_EXT")]
    Modelview0MatrixEXT = 2982,

    [NativeName("GL_MODELVIEW1_MATRIX_EXT")]
    Modelview1MatrixEXT = 34054,

    [NativeName("GL_VERTEX_WEIGHTING_EXT")]
    VertexWeightingEXT = 34057,

    [NativeName("GL_MODELVIEW0_EXT")]
    Modelview0EXT = 5888,

    [NativeName("GL_MODELVIEW1_EXT")]
    Modelview1EXT = 34058,

    [NativeName("GL_CURRENT_VERTEX_WEIGHT_EXT")]
    CurrentVertexWeightEXT = 34059,

    [NativeName("GL_VERTEX_WEIGHT_ARRAY_EXT")]
    VertexWeightArrayEXT = 34060,

    [NativeName("GL_VERTEX_WEIGHT_ARRAY_SIZE_EXT")]
    VertexWeightArraySizeEXT = 34061,

    [NativeName("GL_VERTEX_WEIGHT_ARRAY_TYPE_EXT")]
    VertexWeightArrayTypeEXT = 34062,

    [NativeName("GL_VERTEX_WEIGHT_ARRAY_STRIDE_EXT")]
    VertexWeightArrayStrideEXT = 34063,

    [NativeName("GL_VERTEX_WEIGHT_ARRAY_POINTER_EXT")]
    VertexWeightArrayPointerEXT = 34064,

    [NativeName("GL_INCLUSIVE_EXT")]
    InclusiveEXT = 36624,

    [NativeName("GL_EXCLUSIVE_EXT")]
    ExclusiveEXT = 36625,

    [NativeName("GL_WINDOW_RECTANGLE_EXT")]
    WindowRectangleEXT = 36626,

    [NativeName("GL_WINDOW_RECTANGLE_MODE_EXT")]
    WindowRectangleModeEXT = 36627,

    [NativeName("GL_MAX_WINDOW_RECTANGLES_EXT")]
    MaxWindowRectanglesEXT = 36628,

    [NativeName("GL_NUM_WINDOW_RECTANGLES_EXT")]
    NumWindowRectanglesEXT = 36629,

    [NativeName("GL_SYNC_X11_FENCE_EXT")]
    SyncX11FenceEXT = 37089,

    [NativeName("GL_IGNORE_BORDER_HP")]
    IgnoreBorderHP = 33104,

    [NativeName("GL_CONSTANT_BORDER_HP")]
    ConstantBorderHP = 33105,

    [NativeName("GL_REPLICATE_BORDER_HP")]
    ReplicateBorderHP = 33107,

    [NativeName("GL_CONVOLUTION_BORDER_COLOR_HP")]
    ConvolutionBorderColorHP = 33108,

    [NativeName("GL_IMAGE_SCALE_X_HP")]
    ImageScaleXHP = 33109,

    [NativeName("GL_IMAGE_SCALE_Y_HP")]
    ImageScaleYHP = 33110,

    [NativeName("GL_IMAGE_TRANSLATE_X_HP")]
    ImageTranslateXHP = 33111,

    [NativeName("GL_IMAGE_TRANSLATE_Y_HP")]
    ImageTranslateYHP = 33112,

    [NativeName("GL_IMAGE_ROTATE_ANGLE_HP")]
    ImageRotateAngleHP = 33113,

    [NativeName("GL_IMAGE_ROTATE_ORIGIN_X_HP")]
    ImageRotateOriginXHP = 33114,

    [NativeName("GL_IMAGE_ROTATE_ORIGIN_Y_HP")]
    ImageRotateOriginYHP = 33115,

    [NativeName("GL_IMAGE_MAG_FILTER_HP")]
    ImageMagFilterHP = 33116,

    [NativeName("GL_IMAGE_MIN_FILTER_HP")]
    ImageMinFilterHP = 33117,

    [NativeName("GL_IMAGE_CUBIC_WEIGHT_HP")]
    ImageCubicWeightHP = 33118,

    [NativeName("GL_CUBIC_HP")]
    CubicHP = 33119,

    [NativeName("GL_AVERAGE_HP")]
    AverageHP = 33120,

    [NativeName("GL_IMAGE_TRANSFORM_2D_HP")]
    ImageTransform2DHP = 33121,

    [NativeName("GL_POST_IMAGE_TRANSFORM_COLOR_TABLE_HP")]
    PostImageTransformColorTableHP = 33122,

    [NativeName("GL_PROXY_POST_IMAGE_TRANSFORM_COLOR_TABLE_HP")]
    ProxyPostImageTransformColorTableHP = 33123,

    [NativeName("GL_OCCLUSION_TEST_HP")]
    OcclusionTestHP = 33125,

    [NativeName("GL_OCCLUSION_TEST_RESULT_HP")]
    OcclusionTestResultHP = 33126,

    [NativeName("GL_TEXTURE_LIGHTING_MODE_HP")]
    TextureLightingModeHP = 33127,

    [NativeName("GL_TEXTURE_POST_SPECULAR_HP")]
    TexturePostSpecularHP = 33128,

    [NativeName("GL_TEXTURE_PRE_SPECULAR_HP")]
    TexturePreSpecularHP = 33129,

    [NativeName("GL_CULL_VERTEX_IBM")]
    CullVertexIBM = 103050,

    [NativeName("GL_RASTER_POSITION_UNCLIPPED_IBM")]
    RasterPositionUnclippedIBM = 103010,

    [NativeName("GL_ALL_STATIC_DATA_IBM")]
    AllStaticDataIBM = 103060,

    [NativeName("GL_STATIC_VERTEX_ARRAY_IBM")]
    StaticVertexArrayIBM = 103061,

    [NativeName("GL_MIRRORED_REPEAT_IBM")]
    MirroredRepeatIBM = 33648,

    [NativeName("GL_VERTEX_ARRAY_LIST_IBM")]
    VertexArrayListIBM = 103070,

    [NativeName("GL_NORMAL_ARRAY_LIST_IBM")]
    NormalArrayListIBM = 103071,

    [NativeName("GL_COLOR_ARRAY_LIST_IBM")]
    ColorArrayListIBM = 103072,

    [NativeName("GL_INDEX_ARRAY_LIST_IBM")]
    IndexArrayListIBM = 103073,

    [NativeName("GL_TEXTURE_COORD_ARRAY_LIST_IBM")]
    TextureCoordArrayListIBM = 103074,

    [NativeName("GL_EDGE_FLAG_ARRAY_LIST_IBM")]
    EdgeFlagArrayListIBM = 103075,

    [NativeName("GL_FOG_COORDINATE_ARRAY_LIST_IBM")]
    FogCoordinateArrayListIBM = 103076,

    [NativeName("GL_SECONDARY_COLOR_ARRAY_LIST_IBM")]
    SecondaryColorArrayListIBM = 103077,

    [NativeName("GL_VERTEX_ARRAY_LIST_STRIDE_IBM")]
    VertexArrayListStrideIBM = 103080,

    [NativeName("GL_NORMAL_ARRAY_LIST_STRIDE_IBM")]
    NormalArrayListStrideIBM = 103081,

    [NativeName("GL_COLOR_ARRAY_LIST_STRIDE_IBM")]
    ColorArrayListStrideIBM = 103082,

    [NativeName("GL_INDEX_ARRAY_LIST_STRIDE_IBM")]
    IndexArrayListStrideIBM = 103083,

    [NativeName("GL_TEXTURE_COORD_ARRAY_LIST_STRIDE_IBM")]
    TextureCoordArrayListStrideIBM = 103084,

    [NativeName("GL_EDGE_FLAG_ARRAY_LIST_STRIDE_IBM")]
    EdgeFlagArrayListStrideIBM = 103085,

    [NativeName("GL_FOG_COORDINATE_ARRAY_LIST_STRIDE_IBM")]
    FogCoordinateArrayListStrideIBM = 103086,

    [NativeName("GL_SECONDARY_COLOR_ARRAY_LIST_STRIDE_IBM")]
    SecondaryColorArrayListStrideIBM = 103087,

    [NativeName("GL_RED_MIN_CLAMP_INGR")]
    RedMinClampINGR = 34144,

    [NativeName("GL_GREEN_MIN_CLAMP_INGR")]
    GreenMinClampINGR = 34145,

    [NativeName("GL_BLUE_MIN_CLAMP_INGR")]
    BlueMinClampINGR = 34146,

    [NativeName("GL_ALPHA_MIN_CLAMP_INGR")]
    AlphaMinClampINGR = 34147,

    [NativeName("GL_RED_MAX_CLAMP_INGR")]
    RedMaxClampINGR = 34148,

    [NativeName("GL_GREEN_MAX_CLAMP_INGR")]
    GreenMaxClampINGR = 34149,

    [NativeName("GL_BLUE_MAX_CLAMP_INGR")]
    BlueMaxClampINGR = 34150,

    [NativeName("GL_ALPHA_MAX_CLAMP_INGR")]
    AlphaMaxClampINGR = 34151,

    [NativeName("GL_INTERLACE_READ_INGR")]
    InterlaceReadINGR = 34152,

    [NativeName("GL_BLACKHOLE_RENDER_INTEL")]
    BlackholeRenderINTEL = 33788,

    [NativeName("GL_CONSERVATIVE_RASTERIZATION_INTEL")]
    ConservativeRasterizationINTEL = 33790,

    [NativeName("GL_TEXTURE_MEMORY_LAYOUT_INTEL")]
    TextureMemoryLayoutINTEL = 33791,

    [NativeName("GL_LAYOUT_DEFAULT_INTEL")]
    LayoutDefaultINTEL = 0,

    [NativeName("GL_LAYOUT_LINEAR_INTEL")]
    LayoutLinearINTEL = 1,

    [NativeName("GL_LAYOUT_LINEAR_CPU_CACHED_INTEL")]
    LayoutLinearCpuCachedINTEL = 2,

    [NativeName("GL_PARALLEL_ARRAYS_INTEL")]
    ParallelArraysINTEL = 33780,

    [NativeName("GL_VERTEX_ARRAY_PARALLEL_POINTERS_INTEL")]
    VertexArrayParallelPointersINTEL = 33781,

    [NativeName("GL_NORMAL_ARRAY_PARALLEL_POINTERS_INTEL")]
    NormalArrayParallelPointersINTEL = 33782,

    [NativeName("GL_COLOR_ARRAY_PARALLEL_POINTERS_INTEL")]
    ColorArrayParallelPointersINTEL = 33783,

    [NativeName("GL_TEXTURE_COORD_ARRAY_PARALLEL_POINTERS_INTEL")]
    TextureCoordArrayParallelPointersINTEL = 33784,

    [NativeName("GL_PERFQUERY_SINGLE_CONTEXT_INTEL")]
    PerfquerySingleContextINTEL = 0,

    [NativeName("GL_PERFQUERY_GLOBAL_CONTEXT_INTEL")]
    PerfqueryGlobalContextINTEL = 1,

    [NativeName("GL_PERFQUERY_WAIT_INTEL")]
    PerfqueryWaitINTEL = 33787,

    [NativeName("GL_PERFQUERY_FLUSH_INTEL")]
    PerfqueryFlushINTEL = 33786,

    [NativeName("GL_PERFQUERY_DONOT_FLUSH_INTEL")]
    PerfqueryDonotFlushINTEL = 33785,

    [NativeName("GL_PERFQUERY_COUNTER_EVENT_INTEL")]
    PerfqueryCounterEventINTEL = 38128,

    [NativeName("GL_PERFQUERY_COUNTER_DURATION_NORM_INTEL")]
    PerfqueryCounterDurationNormINTEL = 38129,

    [NativeName("GL_PERFQUERY_COUNTER_DURATION_RAW_INTEL")]
    PerfqueryCounterDurationRawINTEL = 38130,

    [NativeName("GL_PERFQUERY_COUNTER_THROUGHPUT_INTEL")]
    PerfqueryCounterThroughputINTEL = 38131,

    [NativeName("GL_PERFQUERY_COUNTER_RAW_INTEL")]
    PerfqueryCounterRawINTEL = 38132,

    [NativeName("GL_PERFQUERY_COUNTER_TIMESTAMP_INTEL")]
    PerfqueryCounterTimestampINTEL = 38133,

    [NativeName("GL_PERFQUERY_COUNTER_DATA_UINT32_INTEL")]
    PerfqueryCounterDataUint32INTEL = 38136,

    [NativeName("GL_PERFQUERY_COUNTER_DATA_UINT64_INTEL")]
    PerfqueryCounterDataUint64INTEL = 38137,

    [NativeName("GL_PERFQUERY_COUNTER_DATA_FLOAT_INTEL")]
    PerfqueryCounterDataFloatINTEL = 38138,

    [NativeName("GL_PERFQUERY_COUNTER_DATA_DOUBLE_INTEL")]
    PerfqueryCounterDataDoubleINTEL = 38139,

    [NativeName("GL_PERFQUERY_COUNTER_DATA_BOOL32_INTEL")]
    PerfqueryCounterDataBool32INTEL = 38140,

    [NativeName("GL_PERFQUERY_QUERY_NAME_LENGTH_MAX_INTEL")]
    PerfqueryQueryNameLengthMaxINTEL = 38141,

    [NativeName("GL_PERFQUERY_COUNTER_NAME_LENGTH_MAX_INTEL")]
    PerfqueryCounterNameLengthMaxINTEL = 38142,

    [NativeName("GL_PERFQUERY_COUNTER_DESC_LENGTH_MAX_INTEL")]
    PerfqueryCounterDescLengthMaxINTEL = 38143,

    [NativeName("GL_PERFQUERY_GPA_EXTENDED_COUNTERS_INTEL")]
    PerfqueryGpaExtendedCountersINTEL = 38144,

    [NativeName("GL_TEXTURE_1D_STACK_MESAX")]
    Texture1DStackMESAX = 34649,

    [NativeName("GL_TEXTURE_2D_STACK_MESAX")]
    Texture2DStackMESAX = 34650,

    [NativeName("GL_PROXY_TEXTURE_1D_STACK_MESAX")]
    ProxyTexture1DStackMESAX = 34651,

    [NativeName("GL_PROXY_TEXTURE_2D_STACK_MESAX")]
    ProxyTexture2DStackMESAX = 34652,

    [NativeName("GL_TEXTURE_1D_STACK_BINDING_MESAX")]
    Texture1DStackBindingMESAX = 34653,

    [NativeName("GL_TEXTURE_2D_STACK_BINDING_MESAX")]
    Texture2DStackBindingMESAX = 34654,

    [NativeName("GL_FRAMEBUFFER_FLIP_X_MESA")]
    FramebufferFlipXMESA = 35772,

    [NativeName("GL_FRAMEBUFFER_FLIP_Y_MESA")]
    FramebufferFlipYMESA = 35771,

    [NativeName("GL_FRAMEBUFFER_SWAP_XY_MESA")]
    FramebufferSwapXyMESA = 35773,

    [NativeName("GL_PACK_INVERT_MESA")]
    PackInvertMESA = 34648,

    [NativeName("GL_PROGRAM_BINARY_FORMAT_MESA")]
    ProgramBinaryFormatMESA = 34655,

    [NativeName("GL_TILE_RASTER_ORDER_FIXED_MESA")]
    TileRasterOrderFixedMESA = 35768,

    [NativeName("GL_TILE_RASTER_ORDER_INCREASING_X_MESA")]
    TileRasterOrderIncreasingXMESA = 35769,

    [NativeName("GL_TILE_RASTER_ORDER_INCREASING_Y_MESA")]
    TileRasterOrderIncreasingYMESA = 35770,

    [NativeName("GL_UNSIGNED_SHORT_8_8_MESA")]
    UnsignedShort8X8MESA = 34234,

    [NativeName("GL_UNSIGNED_SHORT_8_8_REV_MESA")]
    UnsignedShort8X8RevMESA = 34235,

    [NativeName("GL_YCBCR_MESA")]
    YcbcrMESA = 34647,

    [NativeName("GL_GPU_MEMORY_INFO_DEDICATED_VIDMEM_NVX")]
    GpuMemoryInfoDedicatedVidmemNVX = 36935,

    [NativeName("GL_GPU_MEMORY_INFO_TOTAL_AVAILABLE_MEMORY_NVX")]
    GpuMemoryInfoTotalAvailableMemoryNVX = 36936,

    [NativeName("GL_GPU_MEMORY_INFO_CURRENT_AVAILABLE_VIDMEM_NVX")]
    GpuMemoryInfoCurrentAvailableVidmemNVX = 36937,

    [NativeName("GL_GPU_MEMORY_INFO_EVICTION_COUNT_NVX")]
    GpuMemoryInfoEvictionCountNVX = 36938,

    [NativeName("GL_GPU_MEMORY_INFO_EVICTED_MEMORY_NVX")]
    GpuMemoryInfoEvictedMemoryNVX = 36939,

    [NativeName("GL_UPLOAD_GPU_MASK_NVX")]
    UploadGpuMaskNVX = 38218,

    [NativeName("GL_LGPU_SEPARATE_STORAGE_BIT_NVX")]
    LgpuSeparateStorageBitNVX = 2048,

    [NativeName("GL_MAX_LGPU_GPUS_NVX")]
    MaxLgpuGpusNVX = 37562,

    [NativeName("GL_ALPHA_TO_COVERAGE_DITHER_DEFAULT_NV")]
    AlphaToCoverageDitherDefaultNV = 37709,

    [NativeName("GL_ALPHA_TO_COVERAGE_DITHER_ENABLE_NV")]
    AlphaToCoverageDitherEnableNV = 37710,

    [NativeName("GL_ALPHA_TO_COVERAGE_DITHER_DISABLE_NV")]
    AlphaToCoverageDitherDisableNV = 37711,

    [NativeName("GL_ALPHA_TO_COVERAGE_DITHER_MODE_NV")]
    AlphaToCoverageDitherModeNV = 37567,

    [NativeName("GL_BLEND_OVERLAP_NV")]
    BlendOverlapNV = 37505,

    [NativeName("GL_BLEND_PREMULTIPLIED_SRC_NV")]
    BlendPremultipliedSrcNV = 37504,

    [NativeName("GL_BLUE_NV")]
    BlueNV = 6405,

    [NativeName("GL_COLORBURN_NV")]
    ColorburnNV = 37530,

    [NativeName("GL_COLORDODGE_NV")]
    ColordodgeNV = 37529,

    [NativeName("GL_CONJOINT_NV")]
    ConjointNV = 37508,

    [NativeName("GL_CONTRAST_NV")]
    ContrastNV = 37537,

    [NativeName("GL_DARKEN_NV")]
    DarkenNV = 37527,

    [NativeName("GL_DIFFERENCE_NV")]
    DifferenceNV = 37534,

    [NativeName("GL_DISJOINT_NV")]
    DisjointNV = 37507,

    [NativeName("GL_DST_ATOP_NV")]
    DstAtopNV = 37519,

    [NativeName("GL_DST_IN_NV")]
    DstInNV = 37515,

    [NativeName("GL_DST_NV")]
    DstNV = 37511,

    [NativeName("GL_DST_OUT_NV")]
    DstOutNV = 37517,

    [NativeName("GL_DST_OVER_NV")]
    DstOverNV = 37513,

    [NativeName("GL_EXCLUSION_NV")]
    ExclusionNV = 37536,

    [NativeName("GL_GREEN_NV")]
    GreenNV = 6404,

    [NativeName("GL_HARDLIGHT_NV")]
    HardlightNV = 37531,

    [NativeName("GL_HARDMIX_NV")]
    HardmixNV = 37545,

    [NativeName("GL_HSL_COLOR_NV")]
    HslColorNV = 37551,

    [NativeName("GL_HSL_HUE_NV")]
    HslHueNV = 37549,

    [NativeName("GL_HSL_LUMINOSITY_NV")]
    HslLuminosityNV = 37552,

    [NativeName("GL_HSL_SATURATION_NV")]
    HslSaturationNV = 37550,

    [NativeName("GL_INVERT_OVG_NV")]
    InvertOvgNV = 37556,

    [NativeName("GL_INVERT_RGB_NV")]
    InvertRgbNV = 37539,

    [NativeName("GL_LIGHTEN_NV")]
    LightenNV = 37528,

    [NativeName("GL_LINEARBURN_NV")]
    LinearburnNV = 37541,

    [NativeName("GL_LINEARDODGE_NV")]
    LineardodgeNV = 37540,

    [NativeName("GL_LINEARLIGHT_NV")]
    LinearlightNV = 37543,

    [NativeName("GL_MINUS_CLAMPED_NV")]
    MinusClampedNV = 37555,

    [NativeName("GL_MINUS_NV")]
    MinusNV = 37535,

    [NativeName("GL_MULTIPLY_NV")]
    MultiplyNV = 37524,

    [NativeName("GL_OVERLAY_NV")]
    OverlayNV = 37526,

    [NativeName("GL_PINLIGHT_NV")]
    PinlightNV = 37544,

    [NativeName("GL_PLUS_CLAMPED_ALPHA_NV")]
    PlusClampedAlphaNV = 37554,

    [NativeName("GL_PLUS_CLAMPED_NV")]
    PlusClampedNV = 37553,

    [NativeName("GL_PLUS_DARKER_NV")]
    PlusDarkerNV = 37522,

    [NativeName("GL_PLUS_NV")]
    PlusNV = 37521,

    [NativeName("GL_RED_NV")]
    RedNV = 6403,

    [NativeName("GL_SCREEN_NV")]
    ScreenNV = 37525,

    [NativeName("GL_SOFTLIGHT_NV")]
    SoftlightNV = 37532,

    [NativeName("GL_SRC_ATOP_NV")]
    SrcAtopNV = 37518,

    [NativeName("GL_SRC_IN_NV")]
    SrcInNV = 37514,

    [NativeName("GL_SRC_NV")]
    SrcNV = 37510,

    [NativeName("GL_SRC_OUT_NV")]
    SrcOutNV = 37516,

    [NativeName("GL_SRC_OVER_NV")]
    SrcOverNV = 37512,

    [NativeName("GL_UNCORRELATED_NV")]
    UncorrelatedNV = 37506,

    [NativeName("GL_VIVIDLIGHT_NV")]
    VividlightNV = 37542,

    [NativeName("GL_XOR_NV")]
    XorNV = 5382,

    [NativeName("GL_BLEND_ADVANCED_COHERENT_NV")]
    BlendAdvancedCoherentNV = 37509,

    [NativeName("GL_VIEWPORT_POSITION_W_SCALE_NV")]
    ViewportPositionWScaleNV = 37756,

    [NativeName("GL_VIEWPORT_POSITION_W_SCALE_X_COEFF_NV")]
    ViewportPositionWScaleXCoeffNV = 37757,

    [NativeName("GL_VIEWPORT_POSITION_W_SCALE_Y_COEFF_NV")]
    ViewportPositionWScaleYCoeffNV = 37758,

    [NativeName("GL_TERMINATE_SEQUENCE_COMMAND_NV")]
    TerminateSequenceCommandNV = 0,

    [NativeName("GL_NOP_COMMAND_NV")]
    NopCommandNV = 1,

    [NativeName("GL_DRAW_ELEMENTS_COMMAND_NV")]
    DrawElementsCommandNV = 2,

    [NativeName("GL_DRAW_ARRAYS_COMMAND_NV")]
    DrawArraysCommandNV = 3,

    [NativeName("GL_DRAW_ELEMENTS_STRIP_COMMAND_NV")]
    DrawElementsStripCommandNV = 4,

    [NativeName("GL_DRAW_ARRAYS_STRIP_COMMAND_NV")]
    DrawArraysStripCommandNV = 5,

    [NativeName("GL_DRAW_ELEMENTS_INSTANCED_COMMAND_NV")]
    DrawElementsInstancedCommandNV = 6,

    [NativeName("GL_DRAW_ARRAYS_INSTANCED_COMMAND_NV")]
    DrawArraysInstancedCommandNV = 7,

    [NativeName("GL_ELEMENT_ADDRESS_COMMAND_NV")]
    ElementAddressCommandNV = 8,

    [NativeName("GL_ATTRIBUTE_ADDRESS_COMMAND_NV")]
    AttributeAddressCommandNV = 9,

    [NativeName("GL_UNIFORM_ADDRESS_COMMAND_NV")]
    UniformAddressCommandNV = 10,

    [NativeName("GL_BLEND_COLOR_COMMAND_NV")]
    BlendColorCommandNV = 11,

    [NativeName("GL_STENCIL_REF_COMMAND_NV")]
    StencilRefCommandNV = 12,

    [NativeName("GL_LINE_WIDTH_COMMAND_NV")]
    LineWidthCommandNV = 13,

    [NativeName("GL_POLYGON_OFFSET_COMMAND_NV")]
    PolygonOffsetCommandNV = 14,

    [NativeName("GL_ALPHA_REF_COMMAND_NV")]
    AlphaRefCommandNV = 15,

    [NativeName("GL_VIEWPORT_COMMAND_NV")]
    ViewportCommandNV = 16,

    [NativeName("GL_SCISSOR_COMMAND_NV")]
    ScissorCommandNV = 17,

    [NativeName("GL_FRONT_FACE_COMMAND_NV")]
    FrontFaceCommandNV = 18,

    [NativeName("GL_COMPUTE_PROGRAM_NV")]
    ComputeProgramNV = 37115,

    [NativeName("GL_COMPUTE_PROGRAM_PARAMETER_BUFFER_NV")]
    ComputeProgramParameterBufferNV = 37116,

    [NativeName("GL_QUERY_WAIT_NV")]
    QueryWaitNV = 36371,

    [NativeName("GL_QUERY_NO_WAIT_NV")]
    QueryNoWaitNV = 36372,

    [NativeName("GL_QUERY_BY_REGION_WAIT_NV")]
    QueryByRegionWaitNV = 36373,

    [NativeName("GL_QUERY_BY_REGION_NO_WAIT_NV")]
    QueryByRegionNoWaitNV = 36374,

    [NativeName("GL_CONSERVATIVE_RASTERIZATION_NV")]
    ConservativeRasterizationNV = 37702,

    [NativeName("GL_SUBPIXEL_PRECISION_BIAS_X_BITS_NV")]
    SubpixelPrecisionBiasXBitsNV = 37703,

    [NativeName("GL_SUBPIXEL_PRECISION_BIAS_Y_BITS_NV")]
    SubpixelPrecisionBiasYBitsNV = 37704,

    [NativeName("GL_MAX_SUBPIXEL_PRECISION_BIAS_BITS_NV")]
    MaxSubpixelPrecisionBiasBitsNV = 37705,

    [NativeName("GL_CONSERVATIVE_RASTER_DILATE_NV")]
    ConservativeRasterDilateNV = 37753,

    [NativeName("GL_CONSERVATIVE_RASTER_DILATE_RANGE_NV")]
    ConservativeRasterDilateRangeNV = 37754,

    [NativeName("GL_CONSERVATIVE_RASTER_DILATE_GRANULARITY_NV")]
    ConservativeRasterDilateGranularityNV = 37755,

    [NativeName("GL_CONSERVATIVE_RASTER_MODE_PRE_SNAP_NV")]
    ConservativeRasterModePreSnapNV = 38224,

    [NativeName("GL_CONSERVATIVE_RASTER_MODE_NV")]
    ConservativeRasterModeNV = 38221,

    [NativeName("GL_CONSERVATIVE_RASTER_MODE_POST_SNAP_NV")]
    ConservativeRasterModePostSnapNV = 38222,

    [NativeName("GL_CONSERVATIVE_RASTER_MODE_PRE_SNAP_TRIANGLES_NV")]
    ConservativeRasterModePreSnapTrianglesNV = 38223,

    [NativeName("GL_DEPTH_STENCIL_TO_RGBA_NV")]
    DepthStencilToRgbaNV = 34926,

    [NativeName("GL_DEPTH_STENCIL_TO_BGRA_NV")]
    DepthStencilToBgraNV = 34927,

    [NativeName("GL_MAX_DEEP_3D_TEXTURE_WIDTH_HEIGHT_NV")]
    MaxDeep3DTextureWidthHeightNV = 37072,

    [NativeName("GL_MAX_DEEP_3D_TEXTURE_DEPTH_NV")]
    MaxDeep3DTextureDepthNV = 37073,

    [NativeName("GL_DEPTH_COMPONENT32F_NV")]
    DepthComponent32FNV = 36267,

    [NativeName("GL_DEPTH32F_STENCIL8_NV")]
    Depth32FStencil8NV = 36268,

    [NativeName("GL_FLOAT_32_UNSIGNED_INT_24_8_REV_NV")]
    Float32UnsignedInt24X8RevNV = 36269,

    [NativeName("GL_DEPTH_BUFFER_FLOAT_MODE_NV")]
    DepthBufferFloatModeNV = 36271,

    [NativeName("GL_DEPTH_CLAMP_NV")]
    DepthClampNV = 34383,

    [NativeName("GL_EVAL_2D_NV")]
    Eval2DNV = 34496,

    [NativeName("GL_EVAL_TRIANGULAR_2D_NV")]
    EvalTriangular2DNV = 34497,

    [NativeName("GL_MAP_TESSELLATION_NV")]
    MapTessellationNV = 34498,

    [NativeName("GL_MAP_ATTRIB_U_ORDER_NV")]
    MapAttribUOrderNV = 34499,

    [NativeName("GL_MAP_ATTRIB_V_ORDER_NV")]
    MapAttribVOrderNV = 34500,

    [NativeName("GL_EVAL_FRACTIONAL_TESSELLATION_NV")]
    EvalFractionalTessellationNV = 34501,

    [NativeName("GL_EVAL_VERTEX_ATTRIB0_NV")]
    EvalVertexAttrib0NV = 34502,

    [NativeName("GL_EVAL_VERTEX_ATTRIB1_NV")]
    EvalVertexAttrib1NV = 34503,

    [NativeName("GL_EVAL_VERTEX_ATTRIB2_NV")]
    EvalVertexAttrib2NV = 34504,

    [NativeName("GL_EVAL_VERTEX_ATTRIB3_NV")]
    EvalVertexAttrib3NV = 34505,

    [NativeName("GL_EVAL_VERTEX_ATTRIB4_NV")]
    EvalVertexAttrib4NV = 34506,

    [NativeName("GL_EVAL_VERTEX_ATTRIB5_NV")]
    EvalVertexAttrib5NV = 34507,

    [NativeName("GL_EVAL_VERTEX_ATTRIB6_NV")]
    EvalVertexAttrib6NV = 34508,

    [NativeName("GL_EVAL_VERTEX_ATTRIB7_NV")]
    EvalVertexAttrib7NV = 34509,

    [NativeName("GL_EVAL_VERTEX_ATTRIB8_NV")]
    EvalVertexAttrib8NV = 34510,

    [NativeName("GL_EVAL_VERTEX_ATTRIB9_NV")]
    EvalVertexAttrib9NV = 34511,

    [NativeName("GL_EVAL_VERTEX_ATTRIB10_NV")]
    EvalVertexAttrib10NV = 34512,

    [NativeName("GL_EVAL_VERTEX_ATTRIB11_NV")]
    EvalVertexAttrib11NV = 34513,

    [NativeName("GL_EVAL_VERTEX_ATTRIB12_NV")]
    EvalVertexAttrib12NV = 34514,

    [NativeName("GL_EVAL_VERTEX_ATTRIB13_NV")]
    EvalVertexAttrib13NV = 34515,

    [NativeName("GL_EVAL_VERTEX_ATTRIB14_NV")]
    EvalVertexAttrib14NV = 34516,

    [NativeName("GL_EVAL_VERTEX_ATTRIB15_NV")]
    EvalVertexAttrib15NV = 34517,

    [NativeName("GL_MAX_MAP_TESSELLATION_NV")]
    MaxMapTessellationNV = 34518,

    [NativeName("GL_MAX_RATIONAL_EVAL_ORDER_NV")]
    MaxRationalEvalOrderNV = 34519,

    [NativeName("GL_SAMPLE_POSITION_NV")]
    SamplePositionNV = 36432,

    [NativeName("GL_SAMPLE_MASK_NV")]
    SampleMaskNV = 36433,

    [NativeName("GL_SAMPLE_MASK_VALUE_NV")]
    SampleMaskValueNV = 36434,

    [NativeName("GL_TEXTURE_BINDING_RENDERBUFFER_NV")]
    TextureBindingRenderbufferNV = 36435,

    [NativeName("GL_TEXTURE_RENDERBUFFER_DATA_STORE_BINDING_NV")]
    TextureRenderbufferDataStoreBindingNV = 36436,

    [NativeName("GL_TEXTURE_RENDERBUFFER_NV")]
    TextureRenderbufferNV = 36437,

    [NativeName("GL_SAMPLER_RENDERBUFFER_NV")]
    SamplerRenderbufferNV = 36438,

    [NativeName("GL_INT_SAMPLER_RENDERBUFFER_NV")]
    IntSamplerRenderbufferNV = 36439,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_RENDERBUFFER_NV")]
    UnsignedIntSamplerRenderbufferNV = 36440,

    [NativeName("GL_MAX_SAMPLE_MASK_WORDS_NV")]
    MaxSampleMaskWordsNV = 36441,

    [NativeName("GL_FILL_RECTANGLE_NV")]
    FillRectangleNV = 37692,

    [NativeName("GL_FLOAT_R_NV")]
    FloatRNV = 34944,

    [NativeName("GL_FLOAT_RG_NV")]
    FloatRgNV = 34945,

    [NativeName("GL_FLOAT_RGB_NV")]
    FloatRgbNV = 34946,

    [NativeName("GL_FLOAT_RGBA_NV")]
    FloatRgbaNV = 34947,

    [NativeName("GL_FLOAT_R16_NV")]
    FloatR16NV = 34948,

    [NativeName("GL_FLOAT_R32_NV")]
    FloatR32NV = 34949,

    [NativeName("GL_FLOAT_RG16_NV")]
    FloatRg16NV = 34950,

    [NativeName("GL_FLOAT_RG32_NV")]
    FloatRg32NV = 34951,

    [NativeName("GL_FLOAT_RGB16_NV")]
    FloatRgb16NV = 34952,

    [NativeName("GL_FLOAT_RGB32_NV")]
    FloatRgb32NV = 34953,

    [NativeName("GL_FLOAT_RGBA16_NV")]
    FloatRgba16NV = 34954,

    [NativeName("GL_FLOAT_RGBA32_NV")]
    FloatRgba32NV = 34955,

    [NativeName("GL_TEXTURE_FLOAT_COMPONENTS_NV")]
    TextureFloatComponentsNV = 34956,

    [NativeName("GL_FLOAT_CLEAR_COLOR_VALUE_NV")]
    FloatClearColorValueNV = 34957,

    [NativeName("GL_FLOAT_RGBA_MODE_NV")]
    FloatRgbaModeNV = 34958,

    [NativeName("GL_FOG_DISTANCE_MODE_NV")]
    FogDistanceModeNV = 34138,

    [NativeName("GL_EYE_RADIAL_NV")]
    EyeRadialNV = 34139,

    [NativeName("GL_EYE_PLANE_ABSOLUTE_NV")]
    EyePlaneAbsoluteNV = 34140,

    [NativeName("GL_FRAGMENT_COVERAGE_TO_COLOR_NV")]
    FragmentCoverageToColorNV = 37597,

    [NativeName("GL_FRAGMENT_COVERAGE_COLOR_NV")]
    FragmentCoverageColorNV = 37598,

    [NativeName("GL_MAX_FRAGMENT_PROGRAM_LOCAL_PARAMETERS_NV")]
    MaxFragmentProgramLocalParametersNV = 34920,

    [NativeName("GL_FRAGMENT_PROGRAM_NV")]
    FragmentProgramNV = 34928,

    [NativeName("GL_MAX_TEXTURE_COORDS_NV")]
    MaxTextureCoordsNV = 34929,

    [NativeName("GL_MAX_TEXTURE_IMAGE_UNITS_NV")]
    MaxTextureImageUnitsNV = 34930,

    [NativeName("GL_FRAGMENT_PROGRAM_BINDING_NV")]
    FragmentProgramBindingNV = 34931,

    [NativeName("GL_PROGRAM_ERROR_STRING_NV")]
    ProgramErrorStringNV = 34932,

    [NativeName("GL_MAX_PROGRAM_EXEC_INSTRUCTIONS_NV")]
    MaxProgramExecInstructionsNV = 35060,

    [NativeName("GL_MAX_PROGRAM_CALL_DEPTH_NV")]
    MaxProgramCallDepthNV = 35061,

    [NativeName("GL_MAX_PROGRAM_IF_DEPTH_NV")]
    MaxProgramIfDepthNV = 35062,

    [NativeName("GL_MAX_PROGRAM_LOOP_DEPTH_NV")]
    MaxProgramLoopDepthNV = 35063,

    [NativeName("GL_MAX_PROGRAM_LOOP_COUNT_NV")]
    MaxProgramLoopCountNV = 35064,

    [NativeName("GL_COVERAGE_MODULATION_TABLE_NV")]
    CoverageModulationTableNV = 37681,

    [NativeName("GL_COLOR_SAMPLES_NV")]
    ColorSamplesNV = 36384,

    [NativeName("GL_DEPTH_SAMPLES_NV")]
    DepthSamplesNV = 37677,

    [NativeName("GL_STENCIL_SAMPLES_NV")]
    StencilSamplesNV = 37678,

    [NativeName("GL_MIXED_DEPTH_SAMPLES_SUPPORTED_NV")]
    MixedDepthSamplesSupportedNV = 37679,

    [NativeName("GL_MIXED_STENCIL_SAMPLES_SUPPORTED_NV")]
    MixedStencilSamplesSupportedNV = 37680,

    [NativeName("GL_COVERAGE_MODULATION_NV")]
    CoverageModulationNV = 37682,

    [NativeName("GL_COVERAGE_MODULATION_TABLE_SIZE_NV")]
    CoverageModulationTableSizeNV = 37683,

    [NativeName("GL_RENDERBUFFER_COVERAGE_SAMPLES_NV")]
    RenderbufferCoverageSamplesNV = 36011,

    [NativeName("GL_RENDERBUFFER_COLOR_SAMPLES_NV")]
    RenderbufferColorSamplesNV = 36368,

    [NativeName("GL_MAX_MULTISAMPLE_COVERAGE_MODES_NV")]
    MaxMultisampleCoverageModesNV = 36369,

    [NativeName("GL_MULTISAMPLE_COVERAGE_MODES_NV")]
    MultisampleCoverageModesNV = 36370,

    [NativeName("GL_GEOMETRY_PROGRAM_NV")]
    GeometryProgramNV = 35878,

    [NativeName("GL_MAX_PROGRAM_OUTPUT_VERTICES_NV")]
    MaxProgramOutputVerticesNV = 35879,

    [NativeName("GL_MAX_PROGRAM_TOTAL_OUTPUT_COMPONENTS_NV")]
    MaxProgramTotalOutputComponentsNV = 35880,

    [NativeName("GL_PER_GPU_STORAGE_BIT_NV")]
    PerGpuStorageBitNV = 2048,

    [NativeName("GL_MULTICAST_GPUS_NV")]
    MulticastGpusNV = 37562,

    [NativeName("GL_RENDER_GPU_MASK_NV")]
    RenderGpuMaskNV = 38232,

    [NativeName("GL_PER_GPU_STORAGE_NV")]
    PerGpuStorageNV = 38216,

    [NativeName("GL_MULTICAST_PROGRAMMABLE_SAMPLE_LOCATION_NV")]
    MulticastProgrammableSampleLocationNV = 38217,

    [NativeName("GL_MIN_PROGRAM_TEXEL_OFFSET_NV")]
    MinProgramTexelOffsetNV = 35076,

    [NativeName("GL_MAX_PROGRAM_TEXEL_OFFSET_NV")]
    MaxProgramTexelOffsetNV = 35077,

    [NativeName("GL_PROGRAM_ATTRIB_COMPONENTS_NV")]
    ProgramAttribComponentsNV = 35078,

    [NativeName("GL_PROGRAM_RESULT_COMPONENTS_NV")]
    ProgramResultComponentsNV = 35079,

    [NativeName("GL_MAX_PROGRAM_ATTRIB_COMPONENTS_NV")]
    MaxProgramAttribComponentsNV = 35080,

    [NativeName("GL_MAX_PROGRAM_RESULT_COMPONENTS_NV")]
    MaxProgramResultComponentsNV = 35081,

    [NativeName("GL_MAX_PROGRAM_GENERIC_ATTRIBS_NV")]
    MaxProgramGenericAttribsNV = 36261,

    [NativeName("GL_MAX_PROGRAM_GENERIC_RESULTS_NV")]
    MaxProgramGenericResultsNV = 36262,

    [NativeName("GL_MAX_GEOMETRY_PROGRAM_INVOCATIONS_NV")]
    MaxGeometryProgramInvocationsNV = 36442,

    [NativeName("GL_MIN_FRAGMENT_INTERPOLATION_OFFSET_NV")]
    MinFragmentInterpolationOffsetNV = 36443,

    [NativeName("GL_MAX_FRAGMENT_INTERPOLATION_OFFSET_NV")]
    MaxFragmentInterpolationOffsetNV = 36444,

    [NativeName("GL_FRAGMENT_PROGRAM_INTERPOLATION_OFFSET_BITS_NV")]
    FragmentProgramInterpolationOffsetBitsNV = 36445,

    [NativeName("GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET_NV")]
    MinProgramTextureGatherOffsetNV = 36446,

    [NativeName("GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET_NV")]
    MaxProgramTextureGatherOffsetNV = 36447,

    [NativeName("GL_MAX_PROGRAM_SUBROUTINE_PARAMETERS_NV")]
    MaxProgramSubroutineParametersNV = 36676,

    [NativeName("GL_MAX_PROGRAM_SUBROUTINE_NUM_NV")]
    MaxProgramSubroutineNumNV = 36677,

    [NativeName("GL_HALF_FLOAT_NV")]
    HalfFloatNV = 5131,

    [NativeName("GL_MULTISAMPLES_NV")]
    MultisamplesNV = 37745,

    [NativeName("GL_SUPERSAMPLE_SCALE_X_NV")]
    SupersampleScaleXNV = 37746,

    [NativeName("GL_SUPERSAMPLE_SCALE_Y_NV")]
    SupersampleScaleYNV = 37747,

    [NativeName("GL_CONFORMANT_NV")]
    ConformantNV = 37748,

    [NativeName("GL_MAX_SHININESS_NV")]
    MaxShininessNV = 34052,

    [NativeName("GL_MAX_SPOT_EXPONENT_NV")]
    MaxSpotExponentNV = 34053,

    [NativeName("GL_ATTACHED_MEMORY_OBJECT_NV")]
    AttachedMemoryObjectNV = 38308,

    [NativeName("GL_ATTACHED_MEMORY_OFFSET_NV")]
    AttachedMemoryOffsetNV = 38309,

    [NativeName("GL_MEMORY_ATTACHABLE_ALIGNMENT_NV")]
    MemoryAttachableAlignmentNV = 38310,

    [NativeName("GL_MEMORY_ATTACHABLE_SIZE_NV")]
    MemoryAttachableSizeNV = 38311,

    [NativeName("GL_MEMORY_ATTACHABLE_NV")]
    MemoryAttachableNV = 38312,

    [NativeName("GL_DETACHED_MEMORY_INCARNATION_NV")]
    DetachedMemoryIncarnationNV = 38313,

    [NativeName("GL_DETACHED_TEXTURES_NV")]
    DetachedTexturesNV = 38314,

    [NativeName("GL_DETACHED_BUFFERS_NV")]
    DetachedBuffersNV = 38315,

    [NativeName("GL_MAX_DETACHED_TEXTURES_NV")]
    MaxDetachedTexturesNV = 38316,

    [NativeName("GL_MAX_DETACHED_BUFFERS_NV")]
    MaxDetachedBuffersNV = 38317,

    [NativeName("GL_MESH_SHADER_NV")]
    MeshShaderNV = 38233,

    [NativeName("GL_TASK_SHADER_NV")]
    TaskShaderNV = 38234,

    [NativeName("GL_MAX_MESH_UNIFORM_BLOCKS_NV")]
    MaxMeshUniformBlocksNV = 36448,

    [NativeName("GL_MAX_MESH_TEXTURE_IMAGE_UNITS_NV")]
    MaxMeshTextureImageUnitsNV = 36449,

    [NativeName("GL_MAX_MESH_IMAGE_UNIFORMS_NV")]
    MaxMeshImageUniformsNV = 36450,

    [NativeName("GL_MAX_MESH_UNIFORM_COMPONENTS_NV")]
    MaxMeshUniformComponentsNV = 36451,

    [NativeName("GL_MAX_MESH_ATOMIC_COUNTER_BUFFERS_NV")]
    MaxMeshAtomicCounterBuffersNV = 36452,

    [NativeName("GL_MAX_MESH_ATOMIC_COUNTERS_NV")]
    MaxMeshAtomicCountersNV = 36453,

    [NativeName("GL_MAX_MESH_SHADER_STORAGE_BLOCKS_NV")]
    MaxMeshShaderStorageBlocksNV = 36454,

    [NativeName("GL_MAX_COMBINED_MESH_UNIFORM_COMPONENTS_NV")]
    MaxCombinedMeshUniformComponentsNV = 36455,

    [NativeName("GL_MAX_TASK_UNIFORM_BLOCKS_NV")]
    MaxTaskUniformBlocksNV = 36456,

    [NativeName("GL_MAX_TASK_TEXTURE_IMAGE_UNITS_NV")]
    MaxTaskTextureImageUnitsNV = 36457,

    [NativeName("GL_MAX_TASK_IMAGE_UNIFORMS_NV")]
    MaxTaskImageUniformsNV = 36458,

    [NativeName("GL_MAX_TASK_UNIFORM_COMPONENTS_NV")]
    MaxTaskUniformComponentsNV = 36459,

    [NativeName("GL_MAX_TASK_ATOMIC_COUNTER_BUFFERS_NV")]
    MaxTaskAtomicCounterBuffersNV = 36460,

    [NativeName("GL_MAX_TASK_ATOMIC_COUNTERS_NV")]
    MaxTaskAtomicCountersNV = 36461,

    [NativeName("GL_MAX_TASK_SHADER_STORAGE_BLOCKS_NV")]
    MaxTaskShaderStorageBlocksNV = 36462,

    [NativeName("GL_MAX_COMBINED_TASK_UNIFORM_COMPONENTS_NV")]
    MaxCombinedTaskUniformComponentsNV = 36463,

    [NativeName("GL_MAX_MESH_WORK_GROUP_INVOCATIONS_NV")]
    MaxMeshWorkGroupInvocationsNV = 38306,

    [NativeName("GL_MAX_TASK_WORK_GROUP_INVOCATIONS_NV")]
    MaxTaskWorkGroupInvocationsNV = 38307,

    [NativeName("GL_MAX_MESH_TOTAL_MEMORY_SIZE_NV")]
    MaxMeshTotalMemorySizeNV = 38198,

    [NativeName("GL_MAX_TASK_TOTAL_MEMORY_SIZE_NV")]
    MaxTaskTotalMemorySizeNV = 38199,

    [NativeName("GL_MAX_MESH_OUTPUT_VERTICES_NV")]
    MaxMeshOutputVerticesNV = 38200,

    [NativeName("GL_MAX_MESH_OUTPUT_PRIMITIVES_NV")]
    MaxMeshOutputPrimitivesNV = 38201,

    [NativeName("GL_MAX_TASK_OUTPUT_COUNT_NV")]
    MaxTaskOutputCountNV = 38202,

    [NativeName("GL_MAX_DRAW_MESH_TASKS_COUNT_NV")]
    MaxDrawMeshTasksCountNV = 38205,

    [NativeName("GL_MAX_MESH_VIEWS_NV")]
    MaxMeshViewsNV = 38231,

    [NativeName("GL_MESH_OUTPUT_PER_VERTEX_GRANULARITY_NV")]
    MeshOutputPerVertexGranularityNV = 37599,

    [NativeName("GL_MESH_OUTPUT_PER_PRIMITIVE_GRANULARITY_NV")]
    MeshOutputPerPrimitiveGranularityNV = 38211,

    [NativeName("GL_MAX_MESH_WORK_GROUP_SIZE_NV")]
    MaxMeshWorkGroupSizeNV = 38203,

    [NativeName("GL_MAX_TASK_WORK_GROUP_SIZE_NV")]
    MaxTaskWorkGroupSizeNV = 38204,

    [NativeName("GL_MESH_WORK_GROUP_SIZE_NV")]
    MeshWorkGroupSizeNV = 38206,

    [NativeName("GL_TASK_WORK_GROUP_SIZE_NV")]
    TaskWorkGroupSizeNV = 38207,

    [NativeName("GL_MESH_VERTICES_OUT_NV")]
    MeshVerticesOutNV = 38265,

    [NativeName("GL_MESH_PRIMITIVES_OUT_NV")]
    MeshPrimitivesOutNV = 38266,

    [NativeName("GL_MESH_OUTPUT_TYPE_NV")]
    MeshOutputTypeNV = 38267,

    [NativeName("GL_UNIFORM_BLOCK_REFERENCED_BY_MESH_SHADER_NV")]
    UniformBlockReferencedByMeshShaderNV = 38300,

    [NativeName("GL_UNIFORM_BLOCK_REFERENCED_BY_TASK_SHADER_NV")]
    UniformBlockReferencedByTaskShaderNV = 38301,

    [NativeName("GL_REFERENCED_BY_MESH_SHADER_NV")]
    ReferencedByMeshShaderNV = 38304,

    [NativeName("GL_REFERENCED_BY_TASK_SHADER_NV")]
    ReferencedByTaskShaderNV = 38305,

    [NativeName("GL_MESH_SHADER_BIT_NV")]
    MeshShaderBitNV = 64,

    [NativeName("GL_TASK_SHADER_BIT_NV")]
    TaskShaderBitNV = 128,

    [NativeName("GL_MESH_SUBROUTINE_NV")]
    MeshSubroutineNV = 38268,

    [NativeName("GL_TASK_SUBROUTINE_NV")]
    TaskSubroutineNV = 38269,

    [NativeName("GL_MESH_SUBROUTINE_UNIFORM_NV")]
    MeshSubroutineUniformNV = 38270,

    [NativeName("GL_TASK_SUBROUTINE_UNIFORM_NV")]
    TaskSubroutineUniformNV = 38271,

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_MESH_SHADER_NV")]
    AtomicCounterBufferReferencedByMeshShaderNV = 38302,

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TASK_SHADER_NV")]
    AtomicCounterBufferReferencedByTaskShaderNV = 38303,

    [NativeName("GL_MULTISAMPLE_FILTER_HINT_NV")]
    MultisampleFilterHintNV = 34100,

    [NativeName("GL_PIXEL_COUNTER_BITS_NV")]
    PixelCounterBitsNV = 34916,

    [NativeName("GL_CURRENT_OCCLUSION_QUERY_ID_NV")]
    CurrentOcclusionQueryIdNV = 34917,

    [NativeName("GL_PIXEL_COUNT_NV")]
    PixelCountNV = 34918,

    [NativeName("GL_PIXEL_COUNT_AVAILABLE_NV")]
    PixelCountAvailableNV = 34919,

    [NativeName("GL_DEPTH_STENCIL_NV")]
    DepthStencilNV = 34041,

    [NativeName("GL_UNSIGNED_INT_24_8_NV")]
    UnsignedInt24X8NV = 34042,

    [NativeName("GL_MAX_PROGRAM_PARAMETER_BUFFER_BINDINGS_NV")]
    MaxProgramParameterBufferBindingsNV = 36256,

    [NativeName("GL_MAX_PROGRAM_PARAMETER_BUFFER_SIZE_NV")]
    MaxProgramParameterBufferSizeNV = 36257,

    [NativeName("GL_VERTEX_PROGRAM_PARAMETER_BUFFER_NV")]
    VertexProgramParameterBufferNV = 36258,

    [NativeName("GL_GEOMETRY_PROGRAM_PARAMETER_BUFFER_NV")]
    GeometryProgramParameterBufferNV = 36259,

    [NativeName("GL_FRAGMENT_PROGRAM_PARAMETER_BUFFER_NV")]
    FragmentProgramParameterBufferNV = 36260,

    [NativeName("GL_PATH_FORMAT_SVG_NV")]
    PathFormatSvgNV = 36976,

    [NativeName("GL_PATH_FORMAT_PS_NV")]
    PathFormatPsNV = 36977,

    [NativeName("GL_STANDARD_FONT_NAME_NV")]
    StandardFontNameNV = 36978,

    [NativeName("GL_SYSTEM_FONT_NAME_NV")]
    SystemFontNameNV = 36979,

    [NativeName("GL_FILE_NAME_NV")]
    FileNameNV = 36980,

    [NativeName("GL_PATH_STROKE_WIDTH_NV")]
    PathStrokeWidthNV = 36981,

    [NativeName("GL_PATH_END_CAPS_NV")]
    PathEndCapsNV = 36982,

    [NativeName("GL_PATH_INITIAL_END_CAP_NV")]
    PathInitialEndCapNV = 36983,

    [NativeName("GL_PATH_TERMINAL_END_CAP_NV")]
    PathTerminalEndCapNV = 36984,

    [NativeName("GL_PATH_JOIN_STYLE_NV")]
    PathJoinStyleNV = 36985,

    [NativeName("GL_PATH_MITER_LIMIT_NV")]
    PathMiterLimitNV = 36986,

    [NativeName("GL_PATH_DASH_CAPS_NV")]
    PathDashCapsNV = 36987,

    [NativeName("GL_PATH_INITIAL_DASH_CAP_NV")]
    PathInitialDashCapNV = 36988,

    [NativeName("GL_PATH_TERMINAL_DASH_CAP_NV")]
    PathTerminalDashCapNV = 36989,

    [NativeName("GL_PATH_DASH_OFFSET_NV")]
    PathDashOffsetNV = 36990,

    [NativeName("GL_PATH_CLIENT_LENGTH_NV")]
    PathClientLengthNV = 36991,

    [NativeName("GL_PATH_FILL_MODE_NV")]
    PathFillModeNV = 36992,

    [NativeName("GL_PATH_FILL_MASK_NV")]
    PathFillMaskNV = 36993,

    [NativeName("GL_PATH_FILL_COVER_MODE_NV")]
    PathFillCoverModeNV = 36994,

    [NativeName("GL_PATH_STROKE_COVER_MODE_NV")]
    PathStrokeCoverModeNV = 36995,

    [NativeName("GL_PATH_STROKE_MASK_NV")]
    PathStrokeMaskNV = 36996,

    [NativeName("GL_COUNT_UP_NV")]
    CountUpNV = 37000,

    [NativeName("GL_COUNT_DOWN_NV")]
    CountDownNV = 37001,

    [NativeName("GL_PATH_OBJECT_BOUNDING_BOX_NV")]
    PathObjectBoundingBoxNV = 37002,

    [NativeName("GL_CONVEX_HULL_NV")]
    ConvexHullNV = 37003,

    [NativeName("GL_BOUNDING_BOX_NV")]
    BoundingBoxNV = 37005,

    [NativeName("GL_TRANSLATE_X_NV")]
    TranslateXNV = 37006,

    [NativeName("GL_TRANSLATE_Y_NV")]
    TranslateYNV = 37007,

    [NativeName("GL_TRANSLATE_2D_NV")]
    Translate2DNV = 37008,

    [NativeName("GL_TRANSLATE_3D_NV")]
    Translate3DNV = 37009,

    [NativeName("GL_AFFINE_2D_NV")]
    Affine2DNV = 37010,

    [NativeName("GL_AFFINE_3D_NV")]
    Affine3DNV = 37012,

    [NativeName("GL_TRANSPOSE_AFFINE_2D_NV")]
    TransposeAffine2DNV = 37014,

    [NativeName("GL_TRANSPOSE_AFFINE_3D_NV")]
    TransposeAffine3DNV = 37016,

    [NativeName("GL_UTF8_NV")]
    Utf8NV = 37018,

    [NativeName("GL_UTF16_NV")]
    Utf16NV = 37019,

    [NativeName("GL_BOUNDING_BOX_OF_BOUNDING_BOXES_NV")]
    BoundingBoxOfBoundingBoxesNV = 37020,

    [NativeName("GL_PATH_COMMAND_COUNT_NV")]
    PathCommandCountNV = 37021,

    [NativeName("GL_PATH_COORD_COUNT_NV")]
    PathCoordCountNV = 37022,

    [NativeName("GL_PATH_DASH_ARRAY_COUNT_NV")]
    PathDashArrayCountNV = 37023,

    [NativeName("GL_PATH_COMPUTED_LENGTH_NV")]
    PathComputedLengthNV = 37024,

    [NativeName("GL_PATH_FILL_BOUNDING_BOX_NV")]
    PathFillBoundingBoxNV = 37025,

    [NativeName("GL_PATH_STROKE_BOUNDING_BOX_NV")]
    PathStrokeBoundingBoxNV = 37026,

    [NativeName("GL_SQUARE_NV")]
    SquareNV = 37027,

    [NativeName("GL_ROUND_NV")]
    RoundNV = 37028,

    [NativeName("GL_TRIANGULAR_NV")]
    TriangularNV = 37029,

    [NativeName("GL_BEVEL_NV")]
    BevelNV = 37030,

    [NativeName("GL_MITER_REVERT_NV")]
    MiterRevertNV = 37031,

    [NativeName("GL_MITER_TRUNCATE_NV")]
    MiterTruncateNV = 37032,

    [NativeName("GL_SKIP_MISSING_GLYPH_NV")]
    SkipMissingGlyphNV = 37033,

    [NativeName("GL_USE_MISSING_GLYPH_NV")]
    UseMissingGlyphNV = 37034,

    [NativeName("GL_PATH_ERROR_POSITION_NV")]
    PathErrorPositionNV = 37035,

    [NativeName("GL_ACCUM_ADJACENT_PAIRS_NV")]
    AccumAdjacentPairsNV = 37037,

    [NativeName("GL_ADJACENT_PAIRS_NV")]
    AdjacentPairsNV = 37038,

    [NativeName("GL_FIRST_TO_REST_NV")]
    FirstToRestNV = 37039,

    [NativeName("GL_PATH_GEN_MODE_NV")]
    PathGenModeNV = 37040,

    [NativeName("GL_PATH_GEN_COEFF_NV")]
    PathGenCoeffNV = 37041,

    [NativeName("GL_PATH_GEN_COMPONENTS_NV")]
    PathGenComponentsNV = 37043,

    [NativeName("GL_PATH_STENCIL_FUNC_NV")]
    PathStencilFuncNV = 37047,

    [NativeName("GL_PATH_STENCIL_REF_NV")]
    PathStencilRefNV = 37048,

    [NativeName("GL_PATH_STENCIL_VALUE_MASK_NV")]
    PathStencilValueMaskNV = 37049,

    [NativeName("GL_PATH_STENCIL_DEPTH_OFFSET_FACTOR_NV")]
    PathStencilDepthOffsetFactorNV = 37053,

    [NativeName("GL_PATH_STENCIL_DEPTH_OFFSET_UNITS_NV")]
    PathStencilDepthOffsetUnitsNV = 37054,

    [NativeName("GL_PATH_COVER_DEPTH_FUNC_NV")]
    PathCoverDepthFuncNV = 37055,

    [NativeName("GL_PATH_DASH_OFFSET_RESET_NV")]
    PathDashOffsetResetNV = 37044,

    [NativeName("GL_MOVE_TO_RESETS_NV")]
    MoveToResetsNV = 37045,

    [NativeName("GL_MOVE_TO_CONTINUES_NV")]
    MoveToContinuesNV = 37046,

    [NativeName("GL_CLOSE_PATH_NV")]
    ClosePathNV = 0,

    [NativeName("GL_MOVE_TO_NV")]
    MoveToNV = 2,

    [NativeName("GL_RELATIVE_MOVE_TO_NV")]
    RelativeMoveToNV = 3,

    [NativeName("GL_LINE_TO_NV")]
    LineToNV = 4,

    [NativeName("GL_RELATIVE_LINE_TO_NV")]
    RelativeLineToNV = 5,

    [NativeName("GL_HORIZONTAL_LINE_TO_NV")]
    HorizontalLineToNV = 6,

    [NativeName("GL_RELATIVE_HORIZONTAL_LINE_TO_NV")]
    RelativeHorizontalLineToNV = 7,

    [NativeName("GL_VERTICAL_LINE_TO_NV")]
    VerticalLineToNV = 8,

    [NativeName("GL_RELATIVE_VERTICAL_LINE_TO_NV")]
    RelativeVerticalLineToNV = 9,

    [NativeName("GL_QUADRATIC_CURVE_TO_NV")]
    QuadraticCurveToNV = 10,

    [NativeName("GL_RELATIVE_QUADRATIC_CURVE_TO_NV")]
    RelativeQuadraticCurveToNV = 11,

    [NativeName("GL_CUBIC_CURVE_TO_NV")]
    CubicCurveToNV = 12,

    [NativeName("GL_RELATIVE_CUBIC_CURVE_TO_NV")]
    RelativeCubicCurveToNV = 13,

    [NativeName("GL_SMOOTH_QUADRATIC_CURVE_TO_NV")]
    SmoothQuadraticCurveToNV = 14,

    [NativeName("GL_RELATIVE_SMOOTH_QUADRATIC_CURVE_TO_NV")]
    RelativeSmoothQuadraticCurveToNV = 15,

    [NativeName("GL_SMOOTH_CUBIC_CURVE_TO_NV")]
    SmoothCubicCurveToNV = 16,

    [NativeName("GL_RELATIVE_SMOOTH_CUBIC_CURVE_TO_NV")]
    RelativeSmoothCubicCurveToNV = 17,

    [NativeName("GL_SMALL_CCW_ARC_TO_NV")]
    SmallCcwArcToNV = 18,

    [NativeName("GL_RELATIVE_SMALL_CCW_ARC_TO_NV")]
    RelativeSmallCcwArcToNV = 19,

    [NativeName("GL_SMALL_CW_ARC_TO_NV")]
    SmallCwArcToNV = 20,

    [NativeName("GL_RELATIVE_SMALL_CW_ARC_TO_NV")]
    RelativeSmallCwArcToNV = 21,

    [NativeName("GL_LARGE_CCW_ARC_TO_NV")]
    LargeCcwArcToNV = 22,

    [NativeName("GL_RELATIVE_LARGE_CCW_ARC_TO_NV")]
    RelativeLargeCcwArcToNV = 23,

    [NativeName("GL_LARGE_CW_ARC_TO_NV")]
    LargeCwArcToNV = 24,

    [NativeName("GL_RELATIVE_LARGE_CW_ARC_TO_NV")]
    RelativeLargeCwArcToNV = 25,

    [NativeName("GL_RESTART_PATH_NV")]
    RestartPathNV = 240,

    [NativeName("GL_DUP_FIRST_CUBIC_CURVE_TO_NV")]
    DupFirstCubicCurveToNV = 242,

    [NativeName("GL_DUP_LAST_CUBIC_CURVE_TO_NV")]
    DupLastCubicCurveToNV = 244,

    [NativeName("GL_RECT_NV")]
    RectNV = 246,

    [NativeName("GL_CIRCULAR_CCW_ARC_TO_NV")]
    CircularCcwArcToNV = 248,

    [NativeName("GL_CIRCULAR_CW_ARC_TO_NV")]
    CircularCwArcToNV = 250,

    [NativeName("GL_CIRCULAR_TANGENT_ARC_TO_NV")]
    CircularTangentArcToNV = 252,

    [NativeName("GL_ARC_TO_NV")]
    ArcToNV = 254,

    [NativeName("GL_RELATIVE_ARC_TO_NV")]
    RelativeArcToNV = 255,

    [NativeName("GL_BOLD_BIT_NV")]
    BoldBitNV = 1,

    [NativeName("GL_ITALIC_BIT_NV")]
    ItalicBitNV = 2,

    [NativeName("GL_GLYPH_WIDTH_BIT_NV")]
    GlyphWidthBitNV = 1,

    [NativeName("GL_GLYPH_HEIGHT_BIT_NV")]
    GlyphHeightBitNV = 2,

    [NativeName("GL_GLYPH_HORIZONTAL_BEARING_X_BIT_NV")]
    GlyphHorizontalBearingXBitNV = 4,

    [NativeName("GL_GLYPH_HORIZONTAL_BEARING_Y_BIT_NV")]
    GlyphHorizontalBearingYBitNV = 8,

    [NativeName("GL_GLYPH_HORIZONTAL_BEARING_ADVANCE_BIT_NV")]
    GlyphHorizontalBearingAdvanceBitNV = 16,

    [NativeName("GL_GLYPH_VERTICAL_BEARING_X_BIT_NV")]
    GlyphVerticalBearingXBitNV = 32,

    [NativeName("GL_GLYPH_VERTICAL_BEARING_Y_BIT_NV")]
    GlyphVerticalBearingYBitNV = 64,

    [NativeName("GL_GLYPH_VERTICAL_BEARING_ADVANCE_BIT_NV")]
    GlyphVerticalBearingAdvanceBitNV = 128,

    [NativeName("GL_GLYPH_HAS_KERNING_BIT_NV")]
    GlyphHasKerningBitNV = 256,

    [NativeName("GL_FONT_X_MIN_BOUNDS_BIT_NV")]
    FontXMinBoundsBitNV = 65536,

    [NativeName("GL_FONT_Y_MIN_BOUNDS_BIT_NV")]
    FontYMinBoundsBitNV = 131072,

    [NativeName("GL_FONT_X_MAX_BOUNDS_BIT_NV")]
    FontXMaxBoundsBitNV = 262144,

    [NativeName("GL_FONT_Y_MAX_BOUNDS_BIT_NV")]
    FontYMaxBoundsBitNV = 524288,

    [NativeName("GL_FONT_UNITS_PER_EM_BIT_NV")]
    FontUnitsPerEmBitNV = 1048576,

    [NativeName("GL_FONT_ASCENDER_BIT_NV")]
    FontAscenderBitNV = 2097152,

    [NativeName("GL_FONT_DESCENDER_BIT_NV")]
    FontDescenderBitNV = 4194304,

    [NativeName("GL_FONT_HEIGHT_BIT_NV")]
    FontHeightBitNV = 8388608,

    [NativeName("GL_FONT_MAX_ADVANCE_WIDTH_BIT_NV")]
    FontMaxAdvanceWidthBitNV = 16777216,

    [NativeName("GL_FONT_MAX_ADVANCE_HEIGHT_BIT_NV")]
    FontMaxAdvanceHeightBitNV = 33554432,

    [NativeName("GL_FONT_UNDERLINE_POSITION_BIT_NV")]
    FontUnderlinePositionBitNV = 67108864,

    [NativeName("GL_FONT_UNDERLINE_THICKNESS_BIT_NV")]
    FontUnderlineThicknessBitNV = 134217728,

    [NativeName("GL_FONT_HAS_KERNING_BIT_NV")]
    FontHasKerningBitNV = 268435456,

    [NativeName("GL_ROUNDED_RECT_NV")]
    RoundedRectNV = 232,

    [NativeName("GL_RELATIVE_ROUNDED_RECT_NV")]
    RelativeRoundedRectNV = 233,

    [NativeName("GL_ROUNDED_RECT2_NV")]
    RoundedRect2NV = 234,

    [NativeName("GL_RELATIVE_ROUNDED_RECT2_NV")]
    RelativeRoundedRect2NV = 235,

    [NativeName("GL_ROUNDED_RECT4_NV")]
    RoundedRect4NV = 236,

    [NativeName("GL_RELATIVE_ROUNDED_RECT4_NV")]
    RelativeRoundedRect4NV = 237,

    [NativeName("GL_ROUNDED_RECT8_NV")]
    RoundedRect8NV = 238,

    [NativeName("GL_RELATIVE_ROUNDED_RECT8_NV")]
    RelativeRoundedRect8NV = 239,

    [NativeName("GL_RELATIVE_RECT_NV")]
    RelativeRectNV = 247,

    [NativeName("GL_FONT_GLYPHS_AVAILABLE_NV")]
    FontGlyphsAvailableNV = 37736,

    [NativeName("GL_FONT_TARGET_UNAVAILABLE_NV")]
    FontTargetUnavailableNV = 37737,

    [NativeName("GL_FONT_UNAVAILABLE_NV")]
    FontUnavailableNV = 37738,

    [NativeName("GL_FONT_UNINTELLIGIBLE_NV")]
    FontUnintelligibleNV = 37739,

    [NativeName("GL_CONIC_CURVE_TO_NV")]
    ConicCurveToNV = 26,

    [NativeName("GL_RELATIVE_CONIC_CURVE_TO_NV")]
    RelativeConicCurveToNV = 27,

    [NativeName("GL_FONT_NUM_GLYPH_INDICES_BIT_NV")]
    FontNumGlyphIndicesBitNV = 536870912,

    [NativeName("GL_STANDARD_FONT_FORMAT_NV")]
    StandardFontFormatNV = 37740,

    [NativeName("GL_2_BYTES_NV")]
    X2BytesNV = 5127,

    [NativeName("GL_3_BYTES_NV")]
    X3BytesNV = 5128,

    [NativeName("GL_4_BYTES_NV")]
    X4BytesNV = 5129,

    [NativeName("GL_EYE_LINEAR_NV")]
    EyeLinearNV = 9216,

    [NativeName("GL_OBJECT_LINEAR_NV")]
    ObjectLinearNV = 9217,

    [NativeName("GL_CONSTANT_NV")]
    ConstantNV = 34166,

    [NativeName("GL_PATH_FOG_GEN_MODE_NV")]
    PathFogGenModeNV = 37036,

    [NativeName("GL_PRIMARY_COLOR_NV")]
    PrimaryColorNV = 34092,

    [NativeName("GL_SECONDARY_COLOR_NV")]
    SecondaryColorNV = 34093,

    [NativeName("GL_PATH_GEN_COLOR_FORMAT_NV")]
    PathGenColorFormatNV = 37042,

    [NativeName("GL_PATH_PROJECTION_NV")]
    PathProjectionNV = 5889,

    [NativeName("GL_PATH_MODELVIEW_NV")]
    PathModelviewNV = 5888,

    [NativeName("GL_PATH_MODELVIEW_STACK_DEPTH_NV")]
    PathModelviewStackDepthNV = 2979,

    [NativeName("GL_PATH_MODELVIEW_MATRIX_NV")]
    PathModelviewMatrixNV = 2982,

    [NativeName("GL_PATH_MAX_MODELVIEW_STACK_DEPTH_NV")]
    PathMaxModelviewStackDepthNV = 3382,

    [NativeName("GL_PATH_TRANSPOSE_MODELVIEW_MATRIX_NV")]
    PathTransposeModelviewMatrixNV = 34019,

    [NativeName("GL_PATH_PROJECTION_STACK_DEPTH_NV")]
    PathProjectionStackDepthNV = 2980,

    [NativeName("GL_PATH_PROJECTION_MATRIX_NV")]
    PathProjectionMatrixNV = 2983,

    [NativeName("GL_PATH_MAX_PROJECTION_STACK_DEPTH_NV")]
    PathMaxProjectionStackDepthNV = 3384,

    [NativeName("GL_PATH_TRANSPOSE_PROJECTION_MATRIX_NV")]
    PathTransposeProjectionMatrixNV = 34020,

    [NativeName("GL_FRAGMENT_INPUT_NV")]
    FragmentInputNV = 37741,

    [NativeName("GL_SHARED_EDGE_NV")]
    SharedEdgeNV = 192,

    [NativeName("GL_WRITE_PIXEL_DATA_RANGE_NV")]
    WritePixelDataRangeNV = 34936,

    [NativeName("GL_READ_PIXEL_DATA_RANGE_NV")]
    ReadPixelDataRangeNV = 34937,

    [NativeName("GL_WRITE_PIXEL_DATA_RANGE_LENGTH_NV")]
    WritePixelDataRangeLengthNV = 34938,

    [NativeName("GL_READ_PIXEL_DATA_RANGE_LENGTH_NV")]
    ReadPixelDataRangeLengthNV = 34939,

    [NativeName("GL_WRITE_PIXEL_DATA_RANGE_POINTER_NV")]
    WritePixelDataRangePointerNV = 34940,

    [NativeName("GL_READ_PIXEL_DATA_RANGE_POINTER_NV")]
    ReadPixelDataRangePointerNV = 34941,

    [NativeName("GL_POINT_SPRITE_NV")]
    PointSpriteNV = 34913,

    [NativeName("GL_COORD_REPLACE_NV")]
    CoordReplaceNV = 34914,

    [NativeName("GL_POINT_SPRITE_R_MODE_NV")]
    PointSpriteRModeNV = 34915,

    [NativeName("GL_FRAME_NV")]
    FrameNV = 36390,

    [NativeName("GL_FIELDS_NV")]
    FieldsNV = 36391,

    [NativeName("GL_CURRENT_TIME_NV")]
    CurrentTimeNV = 36392,

    [NativeName("GL_NUM_FILL_STREAMS_NV")]
    NumFillStreamsNV = 36393,

    [NativeName("GL_PRESENT_TIME_NV")]
    PresentTimeNV = 36394,

    [NativeName("GL_PRESENT_DURATION_NV")]
    PresentDurationNV = 36395,

    [NativeName("GL_PRIMITIVE_RESTART_NV")]
    PrimitiveRestartNV = 34136,

    [NativeName("GL_PRIMITIVE_RESTART_INDEX_NV")]
    PrimitiveRestartIndexNV = 34137,

    [NativeName("GL_SHADING_RATE_IMAGE_PER_PRIMITIVE_NV")]
    ShadingRateImagePerPrimitiveNV = 38321,

    [NativeName("GL_SHADING_RATE_IMAGE_PALETTE_COUNT_NV")]
    ShadingRateImagePaletteCountNV = 38322,

    [NativeName("GL_QUERY_RESOURCE_TYPE_VIDMEM_ALLOC_NV")]
    QueryResourceTypeVidmemAllocNV = 38208,

    [NativeName("GL_QUERY_RESOURCE_MEMTYPE_VIDMEM_NV")]
    QueryResourceMemtypeVidmemNV = 38210,

    [NativeName("GL_QUERY_RESOURCE_SYS_RESERVED_NV")]
    QueryResourceSysReservedNV = 38212,

    [NativeName("GL_QUERY_RESOURCE_TEXTURE_NV")]
    QueryResourceTextureNV = 38213,

    [NativeName("GL_QUERY_RESOURCE_RENDERBUFFER_NV")]
    QueryResourceRenderbufferNV = 38214,

    [NativeName("GL_QUERY_RESOURCE_BUFFEROBJECT_NV")]
    QueryResourceBufferobjectNV = 38215,

    [NativeName("GL_REGISTER_COMBINERS_NV")]
    RegisterCombinersNV = 34082,

    [NativeName("GL_VARIABLE_A_NV")]
    VariableANV = 34083,

    [NativeName("GL_VARIABLE_B_NV")]
    VariableBNV = 34084,

    [NativeName("GL_VARIABLE_C_NV")]
    VariableCNV = 34085,

    [NativeName("GL_VARIABLE_D_NV")]
    VariableDNV = 34086,

    [NativeName("GL_VARIABLE_E_NV")]
    VariableENV = 34087,

    [NativeName("GL_VARIABLE_F_NV")]
    VariableFNV = 34088,

    [NativeName("GL_VARIABLE_G_NV")]
    VariableGNV = 34089,

    [NativeName("GL_CONSTANT_COLOR0_NV")]
    ConstantColor0NV = 34090,

    [NativeName("GL_CONSTANT_COLOR1_NV")]
    ConstantColor1NV = 34091,

    [NativeName("GL_SPARE0_NV")]
    Spare0NV = 34094,

    [NativeName("GL_SPARE1_NV")]
    Spare1NV = 34095,

    [NativeName("GL_DISCARD_NV")]
    DiscardNV = 34096,

    [NativeName("GL_E_TIMES_F_NV")]
    ETimesFNV = 34097,

    [NativeName("GL_SPARE0_PLUS_SECONDARY_COLOR_NV")]
    Spare0PlusSecondaryColorNV = 34098,

    [NativeName("GL_UNSIGNED_IDENTITY_NV")]
    UnsignedIdentityNV = 34102,

    [NativeName("GL_UNSIGNED_INVERT_NV")]
    UnsignedInvertNV = 34103,

    [NativeName("GL_EXPAND_NORMAL_NV")]
    ExpandNormalNV = 34104,

    [NativeName("GL_EXPAND_NEGATE_NV")]
    ExpandNegateNV = 34105,

    [NativeName("GL_HALF_BIAS_NORMAL_NV")]
    HalfBiasNormalNV = 34106,

    [NativeName("GL_HALF_BIAS_NEGATE_NV")]
    HalfBiasNegateNV = 34107,

    [NativeName("GL_SIGNED_IDENTITY_NV")]
    SignedIdentityNV = 34108,

    [NativeName("GL_SIGNED_NEGATE_NV")]
    SignedNegateNV = 34109,

    [NativeName("GL_SCALE_BY_TWO_NV")]
    ScaleByTwoNV = 34110,

    [NativeName("GL_SCALE_BY_FOUR_NV")]
    ScaleByFourNV = 34111,

    [NativeName("GL_SCALE_BY_ONE_HALF_NV")]
    ScaleByOneHalfNV = 34112,

    [NativeName("GL_BIAS_BY_NEGATIVE_ONE_HALF_NV")]
    BiasByNegativeOneHalfNV = 34113,

    [NativeName("GL_COMBINER_INPUT_NV")]
    CombinerInputNV = 34114,

    [NativeName("GL_COMBINER_MAPPING_NV")]
    CombinerMappingNV = 34115,

    [NativeName("GL_COMBINER_COMPONENT_USAGE_NV")]
    CombinerComponentUsageNV = 34116,

    [NativeName("GL_COMBINER_AB_DOT_PRODUCT_NV")]
    CombinerAbDotProductNV = 34117,

    [NativeName("GL_COMBINER_CD_DOT_PRODUCT_NV")]
    CombinerCdDotProductNV = 34118,

    [NativeName("GL_COMBINER_MUX_SUM_NV")]
    CombinerMuxSumNV = 34119,

    [NativeName("GL_COMBINER_SCALE_NV")]
    CombinerScaleNV = 34120,

    [NativeName("GL_COMBINER_BIAS_NV")]
    CombinerBiasNV = 34121,

    [NativeName("GL_COMBINER_AB_OUTPUT_NV")]
    CombinerAbOutputNV = 34122,

    [NativeName("GL_COMBINER_CD_OUTPUT_NV")]
    CombinerCdOutputNV = 34123,

    [NativeName("GL_COMBINER_SUM_OUTPUT_NV")]
    CombinerSumOutputNV = 34124,

    [NativeName("GL_MAX_GENERAL_COMBINERS_NV")]
    MaxGeneralCombinersNV = 34125,

    [NativeName("GL_NUM_GENERAL_COMBINERS_NV")]
    NumGeneralCombinersNV = 34126,

    [NativeName("GL_COLOR_SUM_CLAMP_NV")]
    ColorSumClampNV = 34127,

    [NativeName("GL_COMBINER0_NV")]
    Combiner0NV = 34128,

    [NativeName("GL_COMBINER1_NV")]
    Combiner1NV = 34129,

    [NativeName("GL_COMBINER2_NV")]
    Combiner2NV = 34130,

    [NativeName("GL_COMBINER3_NV")]
    Combiner3NV = 34131,

    [NativeName("GL_COMBINER4_NV")]
    Combiner4NV = 34132,

    [NativeName("GL_COMBINER5_NV")]
    Combiner5NV = 34133,

    [NativeName("GL_COMBINER6_NV")]
    Combiner6NV = 34134,

    [NativeName("GL_COMBINER7_NV")]
    Combiner7NV = 34135,

    [NativeName("GL_PER_STAGE_CONSTANTS_NV")]
    PerStageConstantsNV = 34101,

    [NativeName("GL_REPRESENTATIVE_FRAGMENT_TEST_NV")]
    RepresentativeFragmentTestNV = 37759,

    [NativeName("GL_PURGED_CONTEXT_RESET_NV")]
    PurgedContextResetNV = 37563,

    [NativeName("GL_SAMPLE_LOCATION_SUBPIXEL_BITS_NV")]
    SampleLocationSubpixelBitsNV = 37693,

    [NativeName("GL_SAMPLE_LOCATION_PIXEL_GRID_WIDTH_NV")]
    SampleLocationPixelGridWidthNV = 37694,

    [NativeName("GL_SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_NV")]
    SampleLocationPixelGridHeightNV = 37695,

    [NativeName("GL_PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_NV")]
    ProgrammableSampleLocationTableSizeNV = 37696,

    [NativeName("GL_SAMPLE_LOCATION_NV")]
    SampleLocationNV = 36432,

    [NativeName("GL_PROGRAMMABLE_SAMPLE_LOCATION_NV")]
    ProgrammableSampleLocationNV = 37697,

    [NativeName("GL_FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_NV")]
    FramebufferProgrammableSampleLocationsNV = 37698,

    [NativeName("GL_FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_NV")]
    FramebufferSampleLocationPixelGridNV = 37699,

    [NativeName("GL_SCISSOR_TEST_EXCLUSIVE_NV")]
    ScissorTestExclusiveNV = 38229,

    [NativeName("GL_SCISSOR_BOX_EXCLUSIVE_NV")]
    ScissorBoxExclusiveNV = 38230,

    [NativeName("GL_BUFFER_GPU_ADDRESS_NV")]
    BufferGpuAddressNV = 36637,

    [NativeName("GL_GPU_ADDRESS_NV")]
    GpuAddressNV = 36660,

    [NativeName("GL_MAX_SHADER_BUFFER_ADDRESS_NV")]
    MaxShaderBufferAddressNV = 36661,

    [NativeName("GL_SHADER_GLOBAL_ACCESS_BARRIER_BIT_NV")]
    ShaderGlobalAccessBarrierBitNV = 16,

    [NativeName("GL_SUBGROUP_FEATURE_PARTITIONED_BIT_NV")]
    SubgroupFeaturePartitionedBitNV = 256,

    [NativeName("GL_WARP_SIZE_NV")]
    WarpSizeNV = 37689,

    [NativeName("GL_WARPS_PER_SM_NV")]
    WarpsPerSmNV = 37690,

    [NativeName("GL_SM_COUNT_NV")]
    SmCountNV = 37691,

    [NativeName("GL_SHADING_RATE_IMAGE_NV")]
    ShadingRateImageNV = 38243,

    [NativeName("GL_SHADING_RATE_NO_INVOCATIONS_NV")]
    ShadingRateNoInvocationsNV = 38244,

    [NativeName("GL_SHADING_RATE_1_INVOCATION_PER_PIXEL_NV")]
    ShadingRate1InvocationPerPixelNV = 38245,

    [NativeName("GL_SHADING_RATE_1_INVOCATION_PER_1X2_PIXELS_NV")]
    ShadingRate1InvocationPer1X2PixelsNV = 38246,

    [NativeName("GL_SHADING_RATE_1_INVOCATION_PER_2X1_PIXELS_NV")]
    ShadingRate1InvocationPer2X1PixelsNV = 38247,

    [NativeName("GL_SHADING_RATE_1_INVOCATION_PER_2X2_PIXELS_NV")]
    ShadingRate1InvocationPer2X2PixelsNV = 38248,

    [NativeName("GL_SHADING_RATE_1_INVOCATION_PER_2X4_PIXELS_NV")]
    ShadingRate1InvocationPer2X4PixelsNV = 38249,

    [NativeName("GL_SHADING_RATE_1_INVOCATION_PER_4X2_PIXELS_NV")]
    ShadingRate1InvocationPer4X2PixelsNV = 38250,

    [NativeName("GL_SHADING_RATE_1_INVOCATION_PER_4X4_PIXELS_NV")]
    ShadingRate1InvocationPer4X4PixelsNV = 38251,

    [NativeName("GL_SHADING_RATE_2_INVOCATIONS_PER_PIXEL_NV")]
    ShadingRate2InvocationsPerPixelNV = 38252,

    [NativeName("GL_SHADING_RATE_4_INVOCATIONS_PER_PIXEL_NV")]
    ShadingRate4InvocationsPerPixelNV = 38253,

    [NativeName("GL_SHADING_RATE_8_INVOCATIONS_PER_PIXEL_NV")]
    ShadingRate8InvocationsPerPixelNV = 38254,

    [NativeName("GL_SHADING_RATE_16_INVOCATIONS_PER_PIXEL_NV")]
    ShadingRate16InvocationsPerPixelNV = 38255,

    [NativeName("GL_SHADING_RATE_IMAGE_BINDING_NV")]
    ShadingRateImageBindingNV = 38235,

    [NativeName("GL_SHADING_RATE_IMAGE_TEXEL_WIDTH_NV")]
    ShadingRateImageTexelWidthNV = 38236,

    [NativeName("GL_SHADING_RATE_IMAGE_TEXEL_HEIGHT_NV")]
    ShadingRateImageTexelHeightNV = 38237,

    [NativeName("GL_SHADING_RATE_IMAGE_PALETTE_SIZE_NV")]
    ShadingRateImagePaletteSizeNV = 38238,

    [NativeName("GL_MAX_COARSE_FRAGMENT_SAMPLES_NV")]
    MaxCoarseFragmentSamplesNV = 38239,

    [NativeName("GL_SHADING_RATE_SAMPLE_ORDER_DEFAULT_NV")]
    ShadingRateSampleOrderDefaultNV = 38318,

    [NativeName("GL_SHADING_RATE_SAMPLE_ORDER_PIXEL_MAJOR_NV")]
    ShadingRateSampleOrderPixelMajorNV = 38319,

    [NativeName("GL_SHADING_RATE_SAMPLE_ORDER_SAMPLE_MAJOR_NV")]
    ShadingRateSampleOrderSampleMajorNV = 38320,

    [NativeName("GL_MAX_PROGRAM_PATCH_ATTRIBS_NV")]
    MaxProgramPatchAttribsNV = 34520,

    [NativeName("GL_TESS_CONTROL_PROGRAM_NV")]
    TessControlProgramNV = 35102,

    [NativeName("GL_TESS_EVALUATION_PROGRAM_NV")]
    TessEvaluationProgramNV = 35103,

    [NativeName("GL_TESS_CONTROL_PROGRAM_PARAMETER_BUFFER_NV")]
    TessControlProgramParameterBufferNV = 35956,

    [NativeName("GL_TESS_EVALUATION_PROGRAM_PARAMETER_BUFFER_NV")]
    TessEvaluationProgramParameterBufferNV = 35957,

    [NativeName("GL_EMBOSS_LIGHT_NV")]
    EmbossLightNV = 34141,

    [NativeName("GL_EMBOSS_CONSTANT_NV")]
    EmbossConstantNV = 34142,

    [NativeName("GL_EMBOSS_MAP_NV")]
    EmbossMapNV = 34143,

    [NativeName("GL_NORMAL_MAP_NV")]
    NormalMapNV = 34065,

    [NativeName("GL_REFLECTION_MAP_NV")]
    ReflectionMapNV = 34066,

    [NativeName("GL_COMBINE4_NV")]
    Combine4NV = 34051,

    [NativeName("GL_SOURCE3_RGB_NV")]
    Source3RgbNV = 34179,

    [NativeName("GL_SOURCE3_ALPHA_NV")]
    Source3AlphaNV = 34187,

    [NativeName("GL_OPERAND3_RGB_NV")]
    Operand3RgbNV = 34195,

    [NativeName("GL_OPERAND3_ALPHA_NV")]
    Operand3AlphaNV = 34203,

    [NativeName("GL_TEXTURE_UNSIGNED_REMAP_MODE_NV")]
    TextureUnsignedRemapModeNV = 34959,

    [NativeName("GL_TEXTURE_COVERAGE_SAMPLES_NV")]
    TextureCoverageSamplesNV = 36933,

    [NativeName("GL_TEXTURE_COLOR_SAMPLES_NV")]
    TextureColorSamplesNV = 36934,

    [NativeName("GL_TEXTURE_RECTANGLE_NV")]
    TextureRectangleNV = 34037,

    [NativeName("GL_TEXTURE_BINDING_RECTANGLE_NV")]
    TextureBindingRectangleNV = 34038,

    [NativeName("GL_PROXY_TEXTURE_RECTANGLE_NV")]
    ProxyTextureRectangleNV = 34039,

    [NativeName("GL_MAX_RECTANGLE_TEXTURE_SIZE_NV")]
    MaxRectangleTextureSizeNV = 34040,

    [NativeName("GL_OFFSET_TEXTURE_RECTANGLE_NV")]
    OffsetTextureRectangleNV = 34380,

    [NativeName("GL_OFFSET_TEXTURE_RECTANGLE_SCALE_NV")]
    OffsetTextureRectangleScaleNV = 34381,

    [NativeName("GL_DOT_PRODUCT_TEXTURE_RECTANGLE_NV")]
    DotProductTextureRectangleNV = 34382,

    [NativeName("GL_RGBA_UNSIGNED_DOT_PRODUCT_MAPPING_NV")]
    RgbaUnsignedDotProductMappingNV = 34521,

    [NativeName("GL_UNSIGNED_INT_S8_S8_8_8_NV")]
    UnsignedIntS8S8X8X8NV = 34522,

    [NativeName("GL_UNSIGNED_INT_8_8_S8_S8_REV_NV")]
    UnsignedInt8X8S8S8RevNV = 34523,

    [NativeName("GL_DSDT_MAG_INTENSITY_NV")]
    DsdtMagIntensityNV = 34524,

    [NativeName("GL_SHADER_CONSISTENT_NV")]
    ShaderConsistentNV = 34525,

    [NativeName("GL_TEXTURE_SHADER_NV")]
    TextureShaderNV = 34526,

    [NativeName("GL_SHADER_OPERATION_NV")]
    ShaderOperationNV = 34527,

    [NativeName("GL_CULL_MODES_NV")]
    CullModesNV = 34528,

    [NativeName("GL_OFFSET_TEXTURE_MATRIX_NV")]
    OffsetTextureMatrixNV = 34529,

    [NativeName("GL_OFFSET_TEXTURE_SCALE_NV")]
    OffsetTextureScaleNV = 34530,

    [NativeName("GL_OFFSET_TEXTURE_BIAS_NV")]
    OffsetTextureBiasNV = 34531,

    [NativeName("GL_OFFSET_TEXTURE_2D_MATRIX_NV")]
    OffsetTexture2DMatrixNV = 34529,

    [NativeName("GL_OFFSET_TEXTURE_2D_SCALE_NV")]
    OffsetTexture2DScaleNV = 34530,

    [NativeName("GL_OFFSET_TEXTURE_2D_BIAS_NV")]
    OffsetTexture2DBiasNV = 34531,

    [NativeName("GL_PREVIOUS_TEXTURE_INPUT_NV")]
    PreviousTextureInputNV = 34532,

    [NativeName("GL_CONST_EYE_NV")]
    ConstEyeNV = 34533,

    [NativeName("GL_PASS_THROUGH_NV")]
    PassThroughNV = 34534,

    [NativeName("GL_CULL_FRAGMENT_NV")]
    CullFragmentNV = 34535,

    [NativeName("GL_OFFSET_TEXTURE_2D_NV")]
    OffsetTexture2DNV = 34536,

    [NativeName("GL_DEPENDENT_AR_TEXTURE_2D_NV")]
    DependentArTexture2DNV = 34537,

    [NativeName("GL_DEPENDENT_GB_TEXTURE_2D_NV")]
    DependentGbTexture2DNV = 34538,

    [NativeName("GL_DOT_PRODUCT_NV")]
    DotProductNV = 34540,

    [NativeName("GL_DOT_PRODUCT_DEPTH_REPLACE_NV")]
    DotProductDepthReplaceNV = 34541,

    [NativeName("GL_DOT_PRODUCT_TEXTURE_2D_NV")]
    DotProductTexture2DNV = 34542,

    [NativeName("GL_DOT_PRODUCT_TEXTURE_CUBE_MAP_NV")]
    DotProductTextureCubeMapNV = 34544,

    [NativeName("GL_DOT_PRODUCT_DIFFUSE_CUBE_MAP_NV")]
    DotProductDiffuseCubeMapNV = 34545,

    [NativeName("GL_DOT_PRODUCT_REFLECT_CUBE_MAP_NV")]
    DotProductReflectCubeMapNV = 34546,

    [NativeName("GL_DOT_PRODUCT_CONST_EYE_REFLECT_CUBE_MAP_NV")]
    DotProductConstEyeReflectCubeMapNV = 34547,

    [NativeName("GL_HILO_NV")]
    HiloNV = 34548,

    [NativeName("GL_DSDT_NV")]
    DsdtNV = 34549,

    [NativeName("GL_DSDT_MAG_NV")]
    DsdtMagNV = 34550,

    [NativeName("GL_DSDT_MAG_VIB_NV")]
    DsdtMagVibNV = 34551,

    [NativeName("GL_HILO16_NV")]
    Hilo16NV = 34552,

    [NativeName("GL_SIGNED_HILO_NV")]
    SignedHiloNV = 34553,

    [NativeName("GL_SIGNED_HILO16_NV")]
    SignedHilo16NV = 34554,

    [NativeName("GL_SIGNED_RGBA_NV")]
    SignedRgbaNV = 34555,

    [NativeName("GL_SIGNED_RGBA8_NV")]
    SignedRgba8NV = 34556,

    [NativeName("GL_SIGNED_RGB_NV")]
    SignedRgbNV = 34558,

    [NativeName("GL_SIGNED_RGB8_NV")]
    SignedRgb8NV = 34559,

    [NativeName("GL_SIGNED_LUMINANCE_NV")]
    SignedLuminanceNV = 34561,

    [NativeName("GL_SIGNED_LUMINANCE8_NV")]
    SignedLuminance8NV = 34562,

    [NativeName("GL_SIGNED_LUMINANCE_ALPHA_NV")]
    SignedLuminanceAlphaNV = 34563,

    [NativeName("GL_SIGNED_LUMINANCE8_ALPHA8_NV")]
    SignedLuminance8Alpha8NV = 34564,

    [NativeName("GL_SIGNED_ALPHA_NV")]
    SignedAlphaNV = 34565,

    [NativeName("GL_SIGNED_ALPHA8_NV")]
    SignedAlpha8NV = 34566,

    [NativeName("GL_SIGNED_INTENSITY_NV")]
    SignedIntensityNV = 34567,

    [NativeName("GL_SIGNED_INTENSITY8_NV")]
    SignedIntensity8NV = 34568,

    [NativeName("GL_DSDT8_NV")]
    Dsdt8NV = 34569,

    [NativeName("GL_DSDT8_MAG8_NV")]
    Dsdt8Mag8NV = 34570,

    [NativeName("GL_DSDT8_MAG8_INTENSITY8_NV")]
    Dsdt8Mag8Intensity8NV = 34571,

    [NativeName("GL_SIGNED_RGB_UNSIGNED_ALPHA_NV")]
    SignedRgbUnsignedAlphaNV = 34572,

    [NativeName("GL_SIGNED_RGB8_UNSIGNED_ALPHA8_NV")]
    SignedRgb8UnsignedAlpha8NV = 34573,

    [NativeName("GL_HI_SCALE_NV")]
    HiScaleNV = 34574,

    [NativeName("GL_LO_SCALE_NV")]
    LoScaleNV = 34575,

    [NativeName("GL_DS_SCALE_NV")]
    DsScaleNV = 34576,

    [NativeName("GL_DT_SCALE_NV")]
    DtScaleNV = 34577,

    [NativeName("GL_MAGNITUDE_SCALE_NV")]
    MagnitudeScaleNV = 34578,

    [NativeName("GL_VIBRANCE_SCALE_NV")]
    VibranceScaleNV = 34579,

    [NativeName("GL_HI_BIAS_NV")]
    HiBiasNV = 34580,

    [NativeName("GL_LO_BIAS_NV")]
    LoBiasNV = 34581,

    [NativeName("GL_DS_BIAS_NV")]
    DsBiasNV = 34582,

    [NativeName("GL_DT_BIAS_NV")]
    DtBiasNV = 34583,

    [NativeName("GL_MAGNITUDE_BIAS_NV")]
    MagnitudeBiasNV = 34584,

    [NativeName("GL_VIBRANCE_BIAS_NV")]
    VibranceBiasNV = 34585,

    [NativeName("GL_TEXTURE_BORDER_VALUES_NV")]
    TextureBorderValuesNV = 34586,

    [NativeName("GL_TEXTURE_HI_SIZE_NV")]
    TextureHiSizeNV = 34587,

    [NativeName("GL_TEXTURE_LO_SIZE_NV")]
    TextureLoSizeNV = 34588,

    [NativeName("GL_TEXTURE_DS_SIZE_NV")]
    TextureDsSizeNV = 34589,

    [NativeName("GL_TEXTURE_DT_SIZE_NV")]
    TextureDtSizeNV = 34590,

    [NativeName("GL_TEXTURE_MAG_SIZE_NV")]
    TextureMagSizeNV = 34591,

    [NativeName("GL_DOT_PRODUCT_TEXTURE_3D_NV")]
    DotProductTexture3DNV = 34543,

    [NativeName("GL_OFFSET_PROJECTIVE_TEXTURE_2D_NV")]
    OffsetProjectiveTexture2DNV = 34896,

    [NativeName("GL_OFFSET_PROJECTIVE_TEXTURE_2D_SCALE_NV")]
    OffsetProjectiveTexture2DScaleNV = 34897,

    [NativeName("GL_OFFSET_PROJECTIVE_TEXTURE_RECTANGLE_NV")]
    OffsetProjectiveTextureRectangleNV = 34898,

    [NativeName("GL_OFFSET_PROJECTIVE_TEXTURE_RECTANGLE_SCALE_NV")]
    OffsetProjectiveTextureRectangleScaleNV = 34899,

    [NativeName("GL_OFFSET_HILO_TEXTURE_2D_NV")]
    OffsetHiloTexture2DNV = 34900,

    [NativeName("GL_OFFSET_HILO_TEXTURE_RECTANGLE_NV")]
    OffsetHiloTextureRectangleNV = 34901,

    [NativeName("GL_OFFSET_HILO_PROJECTIVE_TEXTURE_2D_NV")]
    OffsetHiloProjectiveTexture2DNV = 34902,

    [NativeName("GL_OFFSET_HILO_PROJECTIVE_TEXTURE_RECTANGLE_NV")]
    OffsetHiloProjectiveTextureRectangleNV = 34903,

    [NativeName("GL_DEPENDENT_HILO_TEXTURE_2D_NV")]
    DependentHiloTexture2DNV = 34904,

    [NativeName("GL_DEPENDENT_RGB_TEXTURE_3D_NV")]
    DependentRgbTexture3DNV = 34905,

    [NativeName("GL_DEPENDENT_RGB_TEXTURE_CUBE_MAP_NV")]
    DependentRgbTextureCubeMapNV = 34906,

    [NativeName("GL_DOT_PRODUCT_PASS_THROUGH_NV")]
    DotProductPassThroughNV = 34907,

    [NativeName("GL_DOT_PRODUCT_TEXTURE_1D_NV")]
    DotProductTexture1DNV = 34908,

    [NativeName("GL_DOT_PRODUCT_AFFINE_DEPTH_REPLACE_NV")]
    DotProductAffineDepthReplaceNV = 34909,

    [NativeName("GL_HILO8_NV")]
    Hilo8NV = 34910,

    [NativeName("GL_SIGNED_HILO8_NV")]
    SignedHilo8NV = 34911,

    [NativeName("GL_FORCE_BLUE_TO_ONE_NV")]
    ForceBlueToOneNV = 34912,

    [NativeName("GL_TIMELINE_SEMAPHORE_VALUE_NV")]
    TimelineSemaphoreValueNV = 38293,

    [NativeName("GL_SEMAPHORE_TYPE_NV")]
    SemaphoreTypeNV = 38323,

    [NativeName("GL_SEMAPHORE_TYPE_BINARY_NV")]
    SemaphoreTypeBinaryNV = 38324,

    [NativeName("GL_SEMAPHORE_TYPE_TIMELINE_NV")]
    SemaphoreTypeTimelineNV = 38325,

    [NativeName("GL_MAX_TIMELINE_SEMAPHORE_VALUE_DIFFERENCE_NV")]
    MaxTimelineSemaphoreValueDifferenceNV = 38326,

    [NativeName("GL_BACK_PRIMARY_COLOR_NV")]
    BackPrimaryColorNV = 35959,

    [NativeName("GL_BACK_SECONDARY_COLOR_NV")]
    BackSecondaryColorNV = 35960,

    [NativeName("GL_TEXTURE_COORD_NV")]
    TextureCoordNV = 35961,

    [NativeName("GL_CLIP_DISTANCE_NV")]
    ClipDistanceNV = 35962,

    [NativeName("GL_VERTEX_ID_NV")]
    VertexIdNV = 35963,

    [NativeName("GL_PRIMITIVE_ID_NV")]
    PrimitiveIdNV = 35964,

    [NativeName("GL_GENERIC_ATTRIB_NV")]
    GenericAttribNV = 35965,

    [NativeName("GL_TRANSFORM_FEEDBACK_ATTRIBS_NV")]
    TransformFeedbackAttribsNV = 35966,

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_MODE_NV")]
    TransformFeedbackBufferModeNV = 35967,

    [NativeName("GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS_NV")]
    MaxTransformFeedbackSeparateComponentsNV = 35968,

    [NativeName("GL_ACTIVE_VARYINGS_NV")]
    ActiveVaryingsNV = 35969,

    [NativeName("GL_ACTIVE_VARYING_MAX_LENGTH_NV")]
    ActiveVaryingMaxLengthNV = 35970,

    [NativeName("GL_TRANSFORM_FEEDBACK_VARYINGS_NV")]
    TransformFeedbackVaryingsNV = 35971,

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_START_NV")]
    TransformFeedbackBufferStartNV = 35972,

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_SIZE_NV")]
    TransformFeedbackBufferSizeNV = 35973,

    [NativeName("GL_TRANSFORM_FEEDBACK_RECORD_NV")]
    TransformFeedbackRecordNV = 35974,

    [NativeName("GL_PRIMITIVES_GENERATED_NV")]
    PrimitivesGeneratedNV = 35975,

    [NativeName("GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN_NV")]
    TransformFeedbackPrimitivesWrittenNV = 35976,

    [NativeName("GL_RASTERIZER_DISCARD_NV")]
    RasterizerDiscardNV = 35977,

    [NativeName("GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS_NV")]
    MaxTransformFeedbackInterleavedComponentsNV = 35978,

    [NativeName("GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS_NV")]
    MaxTransformFeedbackSeparateAttribsNV = 35979,

    [NativeName("GL_INTERLEAVED_ATTRIBS_NV")]
    InterleavedAttribsNV = 35980,

    [NativeName("GL_SEPARATE_ATTRIBS_NV")]
    SeparateAttribsNV = 35981,

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_NV")]
    TransformFeedbackBufferNV = 35982,

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_BINDING_NV")]
    TransformFeedbackBufferBindingNV = 35983,

    [NativeName("GL_LAYER_NV")]
    LayerNV = 36266,

    [NativeName("GL_NEXT_BUFFER_NV")]
    NextBufferNV = 4294967294,

    [NativeName("GL_SKIP_COMPONENTS4_NV")]
    SkipComponents4NV = 4294967293,

    [NativeName("GL_SKIP_COMPONENTS3_NV")]
    SkipComponents3NV = 4294967292,

    [NativeName("GL_SKIP_COMPONENTS2_NV")]
    SkipComponents2NV = 4294967291,

    [NativeName("GL_SKIP_COMPONENTS1_NV")]
    SkipComponents1NV = 4294967290,

    [NativeName("GL_TRANSFORM_FEEDBACK_NV")]
    TransformFeedbackNV = 36386,

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED_NV")]
    TransformFeedbackBufferPausedNV = 36387,

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE_NV")]
    TransformFeedbackBufferActiveNV = 36388,

    [NativeName("GL_TRANSFORM_FEEDBACK_BINDING_NV")]
    TransformFeedbackBindingNV = 36389,

    [NativeName("GL_UNIFORM_BUFFER_UNIFIED_NV")]
    UniformBufferUnifiedNV = 37742,

    [NativeName("GL_UNIFORM_BUFFER_ADDRESS_NV")]
    UniformBufferAddressNV = 37743,

    [NativeName("GL_UNIFORM_BUFFER_LENGTH_NV")]
    UniformBufferLengthNV = 37744,

    [NativeName("GL_SURFACE_STATE_NV")]
    SurfaceStateNV = 34539,

    [NativeName("GL_SURFACE_REGISTERED_NV")]
    SurfaceRegisteredNV = 34557,

    [NativeName("GL_SURFACE_MAPPED_NV")]
    SurfaceMappedNV = 34560,

    [NativeName("GL_WRITE_DISCARD_NV")]
    WriteDiscardNV = 35006,

    [NativeName("GL_VERTEX_ARRAY_RANGE_NV")]
    VertexArrayRangeNV = 34077,

    [NativeName("GL_VERTEX_ARRAY_RANGE_LENGTH_NV")]
    VertexArrayRangeLengthNV = 34078,

    [NativeName("GL_VERTEX_ARRAY_RANGE_VALID_NV")]
    VertexArrayRangeValidNV = 34079,

    [NativeName("GL_MAX_VERTEX_ARRAY_RANGE_ELEMENT_NV")]
    MaxVertexArrayRangeElementNV = 34080,

    [NativeName("GL_VERTEX_ARRAY_RANGE_POINTER_NV")]
    VertexArrayRangePointerNV = 34081,

    [NativeName("GL_VERTEX_ARRAY_RANGE_WITHOUT_FLUSH_NV")]
    VertexArrayRangeWithoutFlushNV = 34099,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_UNIFIED_NV")]
    VertexAttribArrayUnifiedNV = 36638,

    [NativeName("GL_ELEMENT_ARRAY_UNIFIED_NV")]
    ElementArrayUnifiedNV = 36639,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_ADDRESS_NV")]
    VertexAttribArrayAddressNV = 36640,

    [NativeName("GL_VERTEX_ARRAY_ADDRESS_NV")]
    VertexArrayAddressNV = 36641,

    [NativeName("GL_NORMAL_ARRAY_ADDRESS_NV")]
    NormalArrayAddressNV = 36642,

    [NativeName("GL_COLOR_ARRAY_ADDRESS_NV")]
    ColorArrayAddressNV = 36643,

    [NativeName("GL_INDEX_ARRAY_ADDRESS_NV")]
    IndexArrayAddressNV = 36644,

    [NativeName("GL_TEXTURE_COORD_ARRAY_ADDRESS_NV")]
    TextureCoordArrayAddressNV = 36645,

    [NativeName("GL_EDGE_FLAG_ARRAY_ADDRESS_NV")]
    EdgeFlagArrayAddressNV = 36646,

    [NativeName("GL_SECONDARY_COLOR_ARRAY_ADDRESS_NV")]
    SecondaryColorArrayAddressNV = 36647,

    [NativeName("GL_FOG_COORD_ARRAY_ADDRESS_NV")]
    FogCoordArrayAddressNV = 36648,

    [NativeName("GL_ELEMENT_ARRAY_ADDRESS_NV")]
    ElementArrayAddressNV = 36649,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_LENGTH_NV")]
    VertexAttribArrayLengthNV = 36650,

    [NativeName("GL_VERTEX_ARRAY_LENGTH_NV")]
    VertexArrayLengthNV = 36651,

    [NativeName("GL_NORMAL_ARRAY_LENGTH_NV")]
    NormalArrayLengthNV = 36652,

    [NativeName("GL_COLOR_ARRAY_LENGTH_NV")]
    ColorArrayLengthNV = 36653,

    [NativeName("GL_INDEX_ARRAY_LENGTH_NV")]
    IndexArrayLengthNV = 36654,

    [NativeName("GL_TEXTURE_COORD_ARRAY_LENGTH_NV")]
    TextureCoordArrayLengthNV = 36655,

    [NativeName("GL_EDGE_FLAG_ARRAY_LENGTH_NV")]
    EdgeFlagArrayLengthNV = 36656,

    [NativeName("GL_SECONDARY_COLOR_ARRAY_LENGTH_NV")]
    SecondaryColorArrayLengthNV = 36657,

    [NativeName("GL_FOG_COORD_ARRAY_LENGTH_NV")]
    FogCoordArrayLengthNV = 36658,

    [NativeName("GL_ELEMENT_ARRAY_LENGTH_NV")]
    ElementArrayLengthNV = 36659,

    [NativeName("GL_DRAW_INDIRECT_UNIFIED_NV")]
    DrawIndirectUnifiedNV = 36672,

    [NativeName("GL_DRAW_INDIRECT_ADDRESS_NV")]
    DrawIndirectAddressNV = 36673,

    [NativeName("GL_DRAW_INDIRECT_LENGTH_NV")]
    DrawIndirectLengthNV = 36674,

    [NativeName("GL_VERTEX_PROGRAM_NV")]
    VertexProgramNV = 34336,

    [NativeName("GL_VERTEX_STATE_PROGRAM_NV")]
    VertexStateProgramNV = 34337,

    [NativeName("GL_ATTRIB_ARRAY_SIZE_NV")]
    AttribArraySizeNV = 34339,

    [NativeName("GL_ATTRIB_ARRAY_STRIDE_NV")]
    AttribArrayStrideNV = 34340,

    [NativeName("GL_ATTRIB_ARRAY_TYPE_NV")]
    AttribArrayTypeNV = 34341,

    [NativeName("GL_CURRENT_ATTRIB_NV")]
    CurrentAttribNV = 34342,

    [NativeName("GL_PROGRAM_LENGTH_NV")]
    ProgramLengthNV = 34343,

    [NativeName("GL_PROGRAM_STRING_NV")]
    ProgramStringNV = 34344,

    [NativeName("GL_MODELVIEW_PROJECTION_NV")]
    ModelviewProjectionNV = 34345,

    [NativeName("GL_IDENTITY_NV")]
    IdentityNV = 34346,

    [NativeName("GL_INVERSE_NV")]
    InverseNV = 34347,

    [NativeName("GL_TRANSPOSE_NV")]
    TransposeNV = 34348,

    [NativeName("GL_INVERSE_TRANSPOSE_NV")]
    InverseTransposeNV = 34349,

    [NativeName("GL_MAX_TRACK_MATRIX_STACK_DEPTH_NV")]
    MaxTrackMatrixStackDepthNV = 34350,

    [NativeName("GL_MAX_TRACK_MATRICES_NV")]
    MaxTrackMatricesNV = 34351,

    [NativeName("GL_MATRIX0_NV")]
    Matrix0NV = 34352,

    [NativeName("GL_MATRIX1_NV")]
    Matrix1NV = 34353,

    [NativeName("GL_MATRIX2_NV")]
    Matrix2NV = 34354,

    [NativeName("GL_MATRIX3_NV")]
    Matrix3NV = 34355,

    [NativeName("GL_MATRIX4_NV")]
    Matrix4NV = 34356,

    [NativeName("GL_MATRIX5_NV")]
    Matrix5NV = 34357,

    [NativeName("GL_MATRIX6_NV")]
    Matrix6NV = 34358,

    [NativeName("GL_MATRIX7_NV")]
    Matrix7NV = 34359,

    [NativeName("GL_CURRENT_MATRIX_STACK_DEPTH_NV")]
    CurrentMatrixStackDepthNV = 34368,

    [NativeName("GL_CURRENT_MATRIX_NV")]
    CurrentMatrixNV = 34369,

    [NativeName("GL_VERTEX_PROGRAM_POINT_SIZE_NV")]
    VertexProgramPointSizeNV = 34370,

    [NativeName("GL_VERTEX_PROGRAM_TWO_SIDE_NV")]
    VertexProgramTwoSideNV = 34371,

    [NativeName("GL_PROGRAM_PARAMETER_NV")]
    ProgramParameterNV = 34372,

    [NativeName("GL_ATTRIB_ARRAY_POINTER_NV")]
    AttribArrayPointerNV = 34373,

    [NativeName("GL_PROGRAM_TARGET_NV")]
    ProgramTargetNV = 34374,

    [NativeName("GL_PROGRAM_RESIDENT_NV")]
    ProgramResidentNV = 34375,

    [NativeName("GL_TRACK_MATRIX_NV")]
    TrackMatrixNV = 34376,

    [NativeName("GL_TRACK_MATRIX_TRANSFORM_NV")]
    TrackMatrixTransformNV = 34377,

    [NativeName("GL_VERTEX_PROGRAM_BINDING_NV")]
    VertexProgramBindingNV = 34378,

    [NativeName("GL_PROGRAM_ERROR_POSITION_NV")]
    ProgramErrorPositionNV = 34379,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY0_NV")]
    VertexAttribArray0NV = 34384,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY1_NV")]
    VertexAttribArray1NV = 34385,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY2_NV")]
    VertexAttribArray2NV = 34386,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY3_NV")]
    VertexAttribArray3NV = 34387,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY4_NV")]
    VertexAttribArray4NV = 34388,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY5_NV")]
    VertexAttribArray5NV = 34389,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY6_NV")]
    VertexAttribArray6NV = 34390,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY7_NV")]
    VertexAttribArray7NV = 34391,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY8_NV")]
    VertexAttribArray8NV = 34392,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY9_NV")]
    VertexAttribArray9NV = 34393,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY10_NV")]
    VertexAttribArray10NV = 34394,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY11_NV")]
    VertexAttribArray11NV = 34395,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY12_NV")]
    VertexAttribArray12NV = 34396,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY13_NV")]
    VertexAttribArray13NV = 34397,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY14_NV")]
    VertexAttribArray14NV = 34398,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY15_NV")]
    VertexAttribArray15NV = 34399,

    [NativeName("GL_MAP1_VERTEX_ATTRIB0_4_NV")]
    Map1VertexAttrib0X4NV = 34400,

    [NativeName("GL_MAP1_VERTEX_ATTRIB1_4_NV")]
    Map1VertexAttrib1X4NV = 34401,

    [NativeName("GL_MAP1_VERTEX_ATTRIB2_4_NV")]
    Map1VertexAttrib2X4NV = 34402,

    [NativeName("GL_MAP1_VERTEX_ATTRIB3_4_NV")]
    Map1VertexAttrib3X4NV = 34403,

    [NativeName("GL_MAP1_VERTEX_ATTRIB4_4_NV")]
    Map1VertexAttrib4X4NV = 34404,

    [NativeName("GL_MAP1_VERTEX_ATTRIB5_4_NV")]
    Map1VertexAttrib5X4NV = 34405,

    [NativeName("GL_MAP1_VERTEX_ATTRIB6_4_NV")]
    Map1VertexAttrib6X4NV = 34406,

    [NativeName("GL_MAP1_VERTEX_ATTRIB7_4_NV")]
    Map1VertexAttrib7X4NV = 34407,

    [NativeName("GL_MAP1_VERTEX_ATTRIB8_4_NV")]
    Map1VertexAttrib8X4NV = 34408,

    [NativeName("GL_MAP1_VERTEX_ATTRIB9_4_NV")]
    Map1VertexAttrib9X4NV = 34409,

    [NativeName("GL_MAP1_VERTEX_ATTRIB10_4_NV")]
    Map1VertexAttrib10X4NV = 34410,

    [NativeName("GL_MAP1_VERTEX_ATTRIB11_4_NV")]
    Map1VertexAttrib11X4NV = 34411,

    [NativeName("GL_MAP1_VERTEX_ATTRIB12_4_NV")]
    Map1VertexAttrib12X4NV = 34412,

    [NativeName("GL_MAP1_VERTEX_ATTRIB13_4_NV")]
    Map1VertexAttrib13X4NV = 34413,

    [NativeName("GL_MAP1_VERTEX_ATTRIB14_4_NV")]
    Map1VertexAttrib14X4NV = 34414,

    [NativeName("GL_MAP1_VERTEX_ATTRIB15_4_NV")]
    Map1VertexAttrib15X4NV = 34415,

    [NativeName("GL_MAP2_VERTEX_ATTRIB0_4_NV")]
    Map2VertexAttrib0X4NV = 34416,

    [NativeName("GL_MAP2_VERTEX_ATTRIB1_4_NV")]
    Map2VertexAttrib1X4NV = 34417,

    [NativeName("GL_MAP2_VERTEX_ATTRIB2_4_NV")]
    Map2VertexAttrib2X4NV = 34418,

    [NativeName("GL_MAP2_VERTEX_ATTRIB3_4_NV")]
    Map2VertexAttrib3X4NV = 34419,

    [NativeName("GL_MAP2_VERTEX_ATTRIB4_4_NV")]
    Map2VertexAttrib4X4NV = 34420,

    [NativeName("GL_MAP2_VERTEX_ATTRIB5_4_NV")]
    Map2VertexAttrib5X4NV = 34421,

    [NativeName("GL_MAP2_VERTEX_ATTRIB6_4_NV")]
    Map2VertexAttrib6X4NV = 34422,

    [NativeName("GL_MAP2_VERTEX_ATTRIB7_4_NV")]
    Map2VertexAttrib7X4NV = 34423,

    [NativeName("GL_MAP2_VERTEX_ATTRIB8_4_NV")]
    Map2VertexAttrib8X4NV = 34424,

    [NativeName("GL_MAP2_VERTEX_ATTRIB9_4_NV")]
    Map2VertexAttrib9X4NV = 34425,

    [NativeName("GL_MAP2_VERTEX_ATTRIB10_4_NV")]
    Map2VertexAttrib10X4NV = 34426,

    [NativeName("GL_MAP2_VERTEX_ATTRIB11_4_NV")]
    Map2VertexAttrib11X4NV = 34427,

    [NativeName("GL_MAP2_VERTEX_ATTRIB12_4_NV")]
    Map2VertexAttrib12X4NV = 34428,

    [NativeName("GL_MAP2_VERTEX_ATTRIB13_4_NV")]
    Map2VertexAttrib13X4NV = 34429,

    [NativeName("GL_MAP2_VERTEX_ATTRIB14_4_NV")]
    Map2VertexAttrib14X4NV = 34430,

    [NativeName("GL_MAP2_VERTEX_ATTRIB15_4_NV")]
    Map2VertexAttrib15X4NV = 34431,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_INTEGER_NV")]
    VertexAttribArrayIntegerNV = 35069,

    [NativeName("GL_VIDEO_BUFFER_NV")]
    VideoBufferNV = 36896,

    [NativeName("GL_VIDEO_BUFFER_BINDING_NV")]
    VideoBufferBindingNV = 36897,

    [NativeName("GL_FIELD_UPPER_NV")]
    FieldUpperNV = 36898,

    [NativeName("GL_FIELD_LOWER_NV")]
    FieldLowerNV = 36899,

    [NativeName("GL_NUM_VIDEO_CAPTURE_STREAMS_NV")]
    NumVideoCaptureStreamsNV = 36900,

    [NativeName("GL_NEXT_VIDEO_CAPTURE_BUFFER_STATUS_NV")]
    NextVideoCaptureBufferStatusNV = 36901,

    [NativeName("GL_VIDEO_CAPTURE_TO_422_SUPPORTED_NV")]
    VideoCaptureTo422SupportedNV = 36902,

    [NativeName("GL_LAST_VIDEO_CAPTURE_STATUS_NV")]
    LastVideoCaptureStatusNV = 36903,

    [NativeName("GL_VIDEO_BUFFER_PITCH_NV")]
    VideoBufferPitchNV = 36904,

    [NativeName("GL_VIDEO_COLOR_CONVERSION_MATRIX_NV")]
    VideoColorConversionMatrixNV = 36905,

    [NativeName("GL_VIDEO_COLOR_CONVERSION_MAX_NV")]
    VideoColorConversionMaxNV = 36906,

    [NativeName("GL_VIDEO_COLOR_CONVERSION_MIN_NV")]
    VideoColorConversionMinNV = 36907,

    [NativeName("GL_VIDEO_COLOR_CONVERSION_OFFSET_NV")]
    VideoColorConversionOffsetNV = 36908,

    [NativeName("GL_VIDEO_BUFFER_INTERNAL_FORMAT_NV")]
    VideoBufferInternalFormatNV = 36909,

    [NativeName("GL_PARTIAL_SUCCESS_NV")]
    PartialSuccessNV = 36910,

    [NativeName("GL_SUCCESS_NV")]
    SuccessNV = 36911,

    [NativeName("GL_FAILURE_NV")]
    FailureNV = 36912,

    [NativeName("GL_YCBYCR8_422_NV")]
    Ycbycr8X422NV = 36913,

    [NativeName("GL_YCBAYCR8A_4224_NV")]
    Ycbaycr8A4224NV = 36914,

    [NativeName("GL_Z6Y10Z6CB10Z6Y10Z6CR10_422_NV")]
    Z6Y10Z6Cb10Z6Y10Z6Cr10X422NV = 36915,

    [NativeName("GL_Z6Y10Z6CB10Z6A10Z6Y10Z6CR10Z6A10_4224_NV")]
    Z6Y10Z6Cb10Z6A10Z6Y10Z6Cr10Z6A10X4224NV = 36916,

    [NativeName("GL_Z4Y12Z4CB12Z4Y12Z4CR12_422_NV")]
    Z4Y12Z4Cb12Z4Y12Z4Cr12X422NV = 36917,

    [NativeName("GL_Z4Y12Z4CB12Z4A12Z4Y12Z4CR12Z4A12_4224_NV")]
    Z4Y12Z4Cb12Z4A12Z4Y12Z4Cr12Z4A12X4224NV = 36918,

    [NativeName("GL_Z4Y12Z4CB12Z4CR12_444_NV")]
    Z4Y12Z4Cb12Z4Cr12X444NV = 36919,

    [NativeName("GL_VIDEO_CAPTURE_FRAME_WIDTH_NV")]
    VideoCaptureFrameWidthNV = 36920,

    [NativeName("GL_VIDEO_CAPTURE_FRAME_HEIGHT_NV")]
    VideoCaptureFrameHeightNV = 36921,

    [NativeName("GL_VIDEO_CAPTURE_FIELD_UPPER_HEIGHT_NV")]
    VideoCaptureFieldUpperHeightNV = 36922,

    [NativeName("GL_VIDEO_CAPTURE_FIELD_LOWER_HEIGHT_NV")]
    VideoCaptureFieldLowerHeightNV = 36923,

    [NativeName("GL_VIDEO_CAPTURE_SURFACE_ORIGIN_NV")]
    VideoCaptureSurfaceOriginNV = 36924,

    [NativeName("GL_VIEWPORT_SWIZZLE_POSITIVE_X_NV")]
    ViewportSwizzlePositiveXNV = 37712,

    [NativeName("GL_VIEWPORT_SWIZZLE_NEGATIVE_X_NV")]
    ViewportSwizzleNegativeXNV = 37713,

    [NativeName("GL_VIEWPORT_SWIZZLE_POSITIVE_Y_NV")]
    ViewportSwizzlePositiveYNV = 37714,

    [NativeName("GL_VIEWPORT_SWIZZLE_NEGATIVE_Y_NV")]
    ViewportSwizzleNegativeYNV = 37715,

    [NativeName("GL_VIEWPORT_SWIZZLE_POSITIVE_Z_NV")]
    ViewportSwizzlePositiveZNV = 37716,

    [NativeName("GL_VIEWPORT_SWIZZLE_NEGATIVE_Z_NV")]
    ViewportSwizzleNegativeZNV = 37717,

    [NativeName("GL_VIEWPORT_SWIZZLE_POSITIVE_W_NV")]
    ViewportSwizzlePositiveWNV = 37718,

    [NativeName("GL_VIEWPORT_SWIZZLE_NEGATIVE_W_NV")]
    ViewportSwizzleNegativeWNV = 37719,

    [NativeName("GL_VIEWPORT_SWIZZLE_X_NV")]
    ViewportSwizzleXNV = 37720,

    [NativeName("GL_VIEWPORT_SWIZZLE_Y_NV")]
    ViewportSwizzleYNV = 37721,

    [NativeName("GL_VIEWPORT_SWIZZLE_Z_NV")]
    ViewportSwizzleZNV = 37722,

    [NativeName("GL_VIEWPORT_SWIZZLE_W_NV")]
    ViewportSwizzleWNV = 37723,

    [NativeName("GL_INTERLACE_OML")]
    InterlaceOML = 35200,

    [NativeName("GL_INTERLACE_READ_OML")]
    InterlaceReadOML = 35201,

    [NativeName("GL_PACK_RESAMPLE_OML")]
    PackResampleOML = 35204,

    [NativeName("GL_UNPACK_RESAMPLE_OML")]
    UnpackResampleOML = 35205,

    [NativeName("GL_RESAMPLE_REPLICATE_OML")]
    ResampleReplicateOML = 35206,

    [NativeName("GL_RESAMPLE_ZERO_FILL_OML")]
    ResampleZeroFillOML = 35207,

    [NativeName("GL_RESAMPLE_AVERAGE_OML")]
    ResampleAverageOML = 35208,

    [NativeName("GL_RESAMPLE_DECIMATE_OML")]
    ResampleDecimateOML = 35209,

    [NativeName("GL_FORMAT_SUBSAMPLE_24_24_OML")]
    FormatSubsample24X24OML = 35202,

    [NativeName("GL_FORMAT_SUBSAMPLE_244_244_OML")]
    FormatSubsample244X244OML = 35203,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_NUM_VIEWS_OVR")]
    FramebufferAttachmentTextureNumViewsOVR = 38448,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_BASE_VIEW_INDEX_OVR")]
    FramebufferAttachmentTextureBaseViewIndexOVR = 38450,

    [NativeName("GL_MAX_VIEWS_OVR")]
    MaxViewsOVR = 38449,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_VIEW_TARGETS_OVR")]
    FramebufferIncompleteViewTargetsOVR = 38451,

    [NativeName("GL_PREFER_DOUBLEBUFFER_HINT_PGI")]
    PreferDoublebufferHintPGI = 107000,

    [NativeName("GL_CONSERVE_MEMORY_HINT_PGI")]
    ConserveMemoryHintPGI = 107005,

    [NativeName("GL_RECLAIM_MEMORY_HINT_PGI")]
    ReclaimMemoryHintPGI = 107006,

    [NativeName("GL_NATIVE_GRAPHICS_HANDLE_PGI")]
    NativeGraphicsHandlePGI = 107010,

    [NativeName("GL_NATIVE_GRAPHICS_BEGIN_HINT_PGI")]
    NativeGraphicsBeginHintPGI = 107011,

    [NativeName("GL_NATIVE_GRAPHICS_END_HINT_PGI")]
    NativeGraphicsEndHintPGI = 107012,

    [NativeName("GL_ALWAYS_FAST_HINT_PGI")]
    AlwaysFastHintPGI = 107020,

    [NativeName("GL_ALWAYS_SOFT_HINT_PGI")]
    AlwaysSoftHintPGI = 107021,

    [NativeName("GL_ALLOW_DRAW_OBJ_HINT_PGI")]
    AllowDrawObjHintPGI = 107022,

    [NativeName("GL_ALLOW_DRAW_WIN_HINT_PGI")]
    AllowDrawWinHintPGI = 107023,

    [NativeName("GL_ALLOW_DRAW_FRG_HINT_PGI")]
    AllowDrawFrgHintPGI = 107024,

    [NativeName("GL_ALLOW_DRAW_MEM_HINT_PGI")]
    AllowDrawMemHintPGI = 107025,

    [NativeName("GL_STRICT_DEPTHFUNC_HINT_PGI")]
    StrictDepthfuncHintPGI = 107030,

    [NativeName("GL_STRICT_LIGHTING_HINT_PGI")]
    StrictLightingHintPGI = 107031,

    [NativeName("GL_STRICT_SCISSOR_HINT_PGI")]
    StrictScissorHintPGI = 107032,

    [NativeName("GL_FULL_STIPPLE_HINT_PGI")]
    FullStippleHintPGI = 107033,

    [NativeName("GL_CLIP_NEAR_HINT_PGI")]
    ClipNearHintPGI = 107040,

    [NativeName("GL_CLIP_FAR_HINT_PGI")]
    ClipFarHintPGI = 107041,

    [NativeName("GL_WIDE_LINE_HINT_PGI")]
    WideLineHintPGI = 107042,

    [NativeName("GL_BACK_NORMALS_HINT_PGI")]
    BackNormalsHintPGI = 107043,

    [NativeName("GL_VERTEX_DATA_HINT_PGI")]
    VertexDataHintPGI = 107050,

    [NativeName("GL_VERTEX_CONSISTENT_HINT_PGI")]
    VertexConsistentHintPGI = 107051,

    [NativeName("GL_MATERIAL_SIDE_HINT_PGI")]
    MaterialSideHintPGI = 107052,

    [NativeName("GL_MAX_VERTEX_HINT_PGI")]
    MaxVertexHintPGI = 107053,

    [NativeName("GL_COLOR3_BIT_PGI")]
    Color3BitPGI = 65536,

    [NativeName("GL_COLOR4_BIT_PGI")]
    Color4BitPGI = 131072,

    [NativeName("GL_EDGEFLAG_BIT_PGI")]
    EdgeflagBitPGI = 262144,

    [NativeName("GL_INDEX_BIT_PGI")]
    IndexBitPGI = 524288,

    [NativeName("GL_MAT_AMBIENT_BIT_PGI")]
    MatAmbientBitPGI = 1048576,

    [NativeName("GL_MAT_AMBIENT_AND_DIFFUSE_BIT_PGI")]
    MatAmbientAndDiffuseBitPGI = 2097152,

    [NativeName("GL_MAT_DIFFUSE_BIT_PGI")]
    MatDiffuseBitPGI = 4194304,

    [NativeName("GL_MAT_EMISSION_BIT_PGI")]
    MatEmissionBitPGI = 8388608,

    [NativeName("GL_MAT_COLOR_INDEXES_BIT_PGI")]
    MatColorIndexesBitPGI = 16777216,

    [NativeName("GL_MAT_SHININESS_BIT_PGI")]
    MatShininessBitPGI = 33554432,

    [NativeName("GL_MAT_SPECULAR_BIT_PGI")]
    MatSpecularBitPGI = 67108864,

    [NativeName("GL_NORMAL_BIT_PGI")]
    NormalBitPGI = 134217728,

    [NativeName("GL_TEXCOORD1_BIT_PGI")]
    Texcoord1BitPGI = 268435456,

    [NativeName("GL_TEXCOORD2_BIT_PGI")]
    Texcoord2BitPGI = 536870912,

    [NativeName("GL_TEXCOORD3_BIT_PGI")]
    Texcoord3BitPGI = 1073741824,

    [NativeName("GL_TEXCOORD4_BIT_PGI")]
    Texcoord4BitPGI = 2147483648,

    [NativeName("GL_VERTEX23_BIT_PGI")]
    Vertex23BitPGI = 4,

    [NativeName("GL_VERTEX4_BIT_PGI")]
    Vertex4BitPGI = 8,

    [NativeName("GL_SCREEN_COORDINATES_REND")]
    ScreenCoordinatesREND = 33936,

    [NativeName("GL_INVERTED_SCREEN_W_REND")]
    InvertedScreenWREND = 33937,

    [NativeName("GL_RGB_S3TC")]
    RgbS3Tc = 33696,

    [NativeName("GL_RGB4_S3TC")]
    Rgb4S3Tc = 33697,

    [NativeName("GL_RGBA_S3TC")]
    RgbaS3Tc = 33698,

    [NativeName("GL_RGBA4_S3TC")]
    Rgba4S3Tc = 33699,

    [NativeName("GL_RGBA_DXT5_S3TC")]
    RgbaDxt5S3Tc = 33700,

    [NativeName("GL_RGBA4_DXT5_S3TC")]
    Rgba4Dxt5S3Tc = 33701,

    [NativeName("GL_DETAIL_TEXTURE_2D_SGIS")]
    DetailTexture2DSGIS = 32917,

    [NativeName("GL_DETAIL_TEXTURE_2D_BINDING_SGIS")]
    DetailTexture2DBindingSGIS = 32918,

    [NativeName("GL_LINEAR_DETAIL_SGIS")]
    LinearDetailSGIS = 32919,

    [NativeName("GL_LINEAR_DETAIL_ALPHA_SGIS")]
    LinearDetailAlphaSGIS = 32920,

    [NativeName("GL_LINEAR_DETAIL_COLOR_SGIS")]
    LinearDetailColorSGIS = 32921,

    [NativeName("GL_DETAIL_TEXTURE_LEVEL_SGIS")]
    DetailTextureLevelSGIS = 32922,

    [NativeName("GL_DETAIL_TEXTURE_MODE_SGIS")]
    DetailTextureModeSGIS = 32923,

    [NativeName("GL_DETAIL_TEXTURE_FUNC_POINTS_SGIS")]
    DetailTextureFuncPointsSGIS = 32924,

    [NativeName("GL_FOG_FUNC_SGIS")]
    FogFuncSGIS = 33066,

    [NativeName("GL_FOG_FUNC_POINTS_SGIS")]
    FogFuncPointsSGIS = 33067,

    [NativeName("GL_MAX_FOG_FUNC_POINTS_SGIS")]
    MaxFogFuncPointsSGIS = 33068,

    [NativeName("GL_GENERATE_MIPMAP_SGIS")]
    GenerateMipmapSGIS = 33169,

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

    [NativeName("GL_1PASS_SGIS")]
    X1PassSGIS = 32929,

    [NativeName("GL_2PASS_0_SGIS")]
    X2Pass0SGIS = 32930,

    [NativeName("GL_2PASS_1_SGIS")]
    X2Pass1SGIS = 32931,

    [NativeName("GL_4PASS_0_SGIS")]
    X4Pass0SGIS = 32932,

    [NativeName("GL_4PASS_1_SGIS")]
    X4Pass1SGIS = 32933,

    [NativeName("GL_4PASS_2_SGIS")]
    X4Pass2SGIS = 32934,

    [NativeName("GL_4PASS_3_SGIS")]
    X4Pass3SGIS = 32935,

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

    [NativeName("GL_PIXEL_FRAGMENT_RGB_SOURCE_SGIS")]
    PixelFragmentRgbSourceSGIS = 33620,

    [NativeName("GL_PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS")]
    PixelFragmentAlphaSourceSGIS = 33621,

    [NativeName("GL_PIXEL_GROUP_COLOR_SGIS")]
    PixelGroupColorSGIS = 33622,

    [NativeName("GL_EYE_DISTANCE_TO_POINT_SGIS")]
    EyeDistanceToPointSGIS = 33264,

    [NativeName("GL_OBJECT_DISTANCE_TO_POINT_SGIS")]
    ObjectDistanceToPointSGIS = 33265,

    [NativeName("GL_EYE_DISTANCE_TO_LINE_SGIS")]
    EyeDistanceToLineSGIS = 33266,

    [NativeName("GL_OBJECT_DISTANCE_TO_LINE_SGIS")]
    ObjectDistanceToLineSGIS = 33267,

    [NativeName("GL_EYE_POINT_SGIS")]
    EyePointSGIS = 33268,

    [NativeName("GL_OBJECT_POINT_SGIS")]
    ObjectPointSGIS = 33269,

    [NativeName("GL_EYE_LINE_SGIS")]
    EyeLineSGIS = 33270,

    [NativeName("GL_OBJECT_LINE_SGIS")]
    ObjectLineSGIS = 33271,

    [NativeName("GL_POINT_SIZE_MIN_SGIS")]
    PointSizeMinSGIS = 33062,

    [NativeName("GL_POINT_SIZE_MAX_SGIS")]
    PointSizeMaxSGIS = 33063,

    [NativeName("GL_POINT_FADE_THRESHOLD_SIZE_SGIS")]
    PointFadeThresholdSizeSGIS = 33064,

    [NativeName("GL_DISTANCE_ATTENUATION_SGIS")]
    DistanceAttenuationSGIS = 33065,

    [NativeName("GL_LINEAR_SHARPEN_SGIS")]
    LinearSharpenSGIS = 32941,

    [NativeName("GL_LINEAR_SHARPEN_ALPHA_SGIS")]
    LinearSharpenAlphaSGIS = 32942,

    [NativeName("GL_LINEAR_SHARPEN_COLOR_SGIS")]
    LinearSharpenColorSGIS = 32943,

    [NativeName("GL_SHARPEN_TEXTURE_FUNC_POINTS_SGIS")]
    SharpenTextureFuncPointsSGIS = 32944,

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

    [NativeName("GL_PROXY_TEXTURE_4D_SGIS")]
    ProxyTexture4DSGIS = 33077,

    [NativeName("GL_TEXTURE_4DSIZE_SGIS")]
    Texture4DsizeSGIS = 33078,

    [NativeName("GL_TEXTURE_WRAP_Q_SGIS")]
    TextureWrapQSGIS = 33079,

    [NativeName("GL_MAX_4D_TEXTURE_SIZE_SGIS")]
    Max4DTextureSizeSGIS = 33080,

    [NativeName("GL_TEXTURE_4D_BINDING_SGIS")]
    Texture4DBindingSGIS = 33103,

    [NativeName("GL_CLAMP_TO_BORDER_SGIS")]
    ClampToBorderSGIS = 33069,

    [NativeName("GL_TEXTURE_COLOR_WRITEMASK_SGIS")]
    TextureColorWritemaskSGIS = 33263,

    [NativeName("GL_CLAMP_TO_EDGE_SGIS")]
    ClampToEdgeSGIS = 33071,

    [NativeName("GL_FILTER4_SGIS")]
    Filter4SGIS = 33094,

    [NativeName("GL_TEXTURE_FILTER4_SIZE_SGIS")]
    TextureFilter4SizeSGIS = 33095,

    [NativeName("GL_TEXTURE_MIN_LOD_SGIS")]
    TextureMinLodSGIS = 33082,

    [NativeName("GL_TEXTURE_MAX_LOD_SGIS")]
    TextureMaxLodSGIS = 33083,

    [NativeName("GL_TEXTURE_BASE_LEVEL_SGIS")]
    TextureBaseLevelSGIS = 33084,

    [NativeName("GL_TEXTURE_MAX_LEVEL_SGIS")]
    TextureMaxLevelSGIS = 33085,

    [NativeName("GL_DUAL_ALPHA4_SGIS")]
    DualAlpha4SGIS = 33040,

    [NativeName("GL_DUAL_ALPHA8_SGIS")]
    DualAlpha8SGIS = 33041,

    [NativeName("GL_DUAL_ALPHA12_SGIS")]
    DualAlpha12SGIS = 33042,

    [NativeName("GL_DUAL_ALPHA16_SGIS")]
    DualAlpha16SGIS = 33043,

    [NativeName("GL_DUAL_LUMINANCE4_SGIS")]
    DualLuminance4SGIS = 33044,

    [NativeName("GL_DUAL_LUMINANCE8_SGIS")]
    DualLuminance8SGIS = 33045,

    [NativeName("GL_DUAL_LUMINANCE12_SGIS")]
    DualLuminance12SGIS = 33046,

    [NativeName("GL_DUAL_LUMINANCE16_SGIS")]
    DualLuminance16SGIS = 33047,

    [NativeName("GL_DUAL_INTENSITY4_SGIS")]
    DualIntensity4SGIS = 33048,

    [NativeName("GL_DUAL_INTENSITY8_SGIS")]
    DualIntensity8SGIS = 33049,

    [NativeName("GL_DUAL_INTENSITY12_SGIS")]
    DualIntensity12SGIS = 33050,

    [NativeName("GL_DUAL_INTENSITY16_SGIS")]
    DualIntensity16SGIS = 33051,

    [NativeName("GL_DUAL_LUMINANCE_ALPHA4_SGIS")]
    DualLuminanceAlpha4SGIS = 33052,

    [NativeName("GL_DUAL_LUMINANCE_ALPHA8_SGIS")]
    DualLuminanceAlpha8SGIS = 33053,

    [NativeName("GL_QUAD_ALPHA4_SGIS")]
    QuadAlpha4SGIS = 33054,

    [NativeName("GL_QUAD_ALPHA8_SGIS")]
    QuadAlpha8SGIS = 33055,

    [NativeName("GL_QUAD_LUMINANCE4_SGIS")]
    QuadLuminance4SGIS = 33056,

    [NativeName("GL_QUAD_LUMINANCE8_SGIS")]
    QuadLuminance8SGIS = 33057,

    [NativeName("GL_QUAD_INTENSITY4_SGIS")]
    QuadIntensity4SGIS = 33058,

    [NativeName("GL_QUAD_INTENSITY8_SGIS")]
    QuadIntensity8SGIS = 33059,

    [NativeName("GL_DUAL_TEXTURE_SELECT_SGIS")]
    DualTextureSelectSGIS = 33060,

    [NativeName("GL_QUAD_TEXTURE_SELECT_SGIS")]
    QuadTextureSelectSGIS = 33061,

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

    [NativeName("GL_ALPHA_MIN_SGIX")]
    AlphaMinSGIX = 33568,

    [NativeName("GL_ALPHA_MAX_SGIX")]
    AlphaMaxSGIX = 33569,

    [NativeName("GL_CALLIGRAPHIC_FRAGMENT_SGIX")]
    CalligraphicFragmentSGIX = 33155,

    [NativeName("GL_LINEAR_CLIPMAP_LINEAR_SGIX")]
    LinearClipmapLinearSGIX = 33136,

    [NativeName("GL_TEXTURE_CLIPMAP_CENTER_SGIX")]
    TextureClipmapCenterSGIX = 33137,

    [NativeName("GL_TEXTURE_CLIPMAP_FRAME_SGIX")]
    TextureClipmapFrameSGIX = 33138,

    [NativeName("GL_TEXTURE_CLIPMAP_OFFSET_SGIX")]
    TextureClipmapOffsetSGIX = 33139,

    [NativeName("GL_TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX")]
    TextureClipmapVirtualDepthSGIX = 33140,

    [NativeName("GL_TEXTURE_CLIPMAP_LOD_OFFSET_SGIX")]
    TextureClipmapLodOffsetSGIX = 33141,

    [NativeName("GL_TEXTURE_CLIPMAP_DEPTH_SGIX")]
    TextureClipmapDepthSGIX = 33142,

    [NativeName("GL_MAX_CLIPMAP_DEPTH_SGIX")]
    MaxClipmapDepthSGIX = 33143,

    [NativeName("GL_MAX_CLIPMAP_VIRTUAL_DEPTH_SGIX")]
    MaxClipmapVirtualDepthSGIX = 33144,

    [NativeName("GL_NEAREST_CLIPMAP_NEAREST_SGIX")]
    NearestClipmapNearestSGIX = 33869,

    [NativeName("GL_NEAREST_CLIPMAP_LINEAR_SGIX")]
    NearestClipmapLinearSGIX = 33870,

    [NativeName("GL_LINEAR_CLIPMAP_NEAREST_SGIX")]
    LinearClipmapNearestSGIX = 33871,

    [NativeName("GL_CONVOLUTION_HINT_SGIX")]
    ConvolutionHintSGIX = 33558,

    [NativeName("GL_DEPTH_COMPONENT16_SGIX")]
    DepthComponent16SGIX = 33189,

    [NativeName("GL_DEPTH_COMPONENT24_SGIX")]
    DepthComponent24SGIX = 33190,

    [NativeName("GL_DEPTH_COMPONENT32_SGIX")]
    DepthComponent32SGIX = 33191,

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

    [NativeName("GL_CURRENT_RASTER_NORMAL_SGIX")]
    CurrentRasterNormalSGIX = 33798,

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

    [NativeName("GL_FRAMEZOOM_FACTOR_SGIX")]
    FramezoomFactorSGIX = 33164,

    [NativeName("GL_MAX_FRAMEZOOM_FACTOR_SGIX")]
    MaxFramezoomFactorSGIX = 33165,

    [NativeName("GL_INSTRUMENT_BUFFER_POINTER_SGIX")]
    InstrumentBufferPointerSGIX = 33152,

    [NativeName("GL_INSTRUMENT_MEASUREMENTS_SGIX")]
    InstrumentMeasurementsSGIX = 33153,

    [NativeName("GL_INTERLACE_SGIX")]
    InterlaceSGIX = 32916,

    [NativeName("GL_IR_INSTRUMENT1_SGIX")]
    IrInstrument1SGIX = 33151,

    [NativeName("GL_LIST_PRIORITY_SGIX")]
    ListPrioritySGIX = 33154,

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

    [NativeName("GL_TEXTURE_DEFORMATION_BIT_SGIX")]
    TextureDeformationBitSGIX = 1,

    [NativeName("GL_GEOMETRY_DEFORMATION_BIT_SGIX")]
    GeometryDeformationBitSGIX = 2,

    [NativeName("GL_GEOMETRY_DEFORMATION_SGIX")]
    GeometryDeformationSGIX = 33172,

    [NativeName("GL_TEXTURE_DEFORMATION_SGIX")]
    TextureDeformationSGIX = 33173,

    [NativeName("GL_DEFORMATIONS_MASK_SGIX")]
    DeformationsMaskSGIX = 33174,

    [NativeName("GL_MAX_DEFORMATION_ORDER_SGIX")]
    MaxDeformationOrderSGIX = 33175,

    [NativeName("GL_REFERENCE_PLANE_SGIX")]
    ReferencePlaneSGIX = 33149,

    [NativeName("GL_REFERENCE_PLANE_EQUATION_SGIX")]
    ReferencePlaneEquationSGIX = 33150,

    [NativeName("GL_PACK_RESAMPLE_SGIX")]
    PackResampleSGIX = 33838,

    [NativeName("GL_UNPACK_RESAMPLE_SGIX")]
    UnpackResampleSGIX = 33839,

    [NativeName("GL_RESAMPLE_REPLICATE_SGIX")]
    ResampleReplicateSGIX = 33843,

    [NativeName("GL_RESAMPLE_ZERO_FILL_SGIX")]
    ResampleZeroFillSGIX = 33844,

    [NativeName("GL_RESAMPLE_DECIMATE_SGIX")]
    ResampleDecimateSGIX = 33840,

    [NativeName("GL_SCALEBIAS_HINT_SGIX")]
    ScalebiasHintSGIX = 33570,

    [NativeName("GL_TEXTURE_COMPARE_SGIX")]
    TextureCompareSGIX = 33178,

    [NativeName("GL_TEXTURE_COMPARE_OPERATOR_SGIX")]
    TextureCompareOperatorSGIX = 33179,

    [NativeName("GL_TEXTURE_LEQUAL_R_SGIX")]
    TextureLequalRSGIX = 33180,

    [NativeName("GL_TEXTURE_GEQUAL_R_SGIX")]
    TextureGequalRSGIX = 33181,

    [NativeName("GL_SHADOW_AMBIENT_SGIX")]
    ShadowAmbientSGIX = 32959,

    [NativeName("GL_SPRITE_SGIX")]
    SpriteSGIX = 33096,

    [NativeName("GL_SPRITE_MODE_SGIX")]
    SpriteModeSGIX = 33097,

    [NativeName("GL_SPRITE_AXIS_SGIX")]
    SpriteAxisSGIX = 33098,

    [NativeName("GL_SPRITE_TRANSLATION_SGIX")]
    SpriteTranslationSGIX = 33099,

    [NativeName("GL_SPRITE_AXIAL_SGIX")]
    SpriteAxialSGIX = 33100,

    [NativeName("GL_SPRITE_OBJECT_ALIGNED_SGIX")]
    SpriteObjectAlignedSGIX = 33101,

    [NativeName("GL_SPRITE_EYE_ALIGNED_SGIX")]
    SpriteEyeAlignedSGIX = 33102,

    [NativeName("GL_PACK_SUBSAMPLE_RATE_SGIX")]
    PackSubsampleRateSGIX = 34208,

    [NativeName("GL_UNPACK_SUBSAMPLE_RATE_SGIX")]
    UnpackSubsampleRateSGIX = 34209,

    [NativeName("GL_PIXEL_SUBSAMPLE_4444_SGIX")]
    PixelSubsample4444SGIX = 34210,

    [NativeName("GL_PIXEL_SUBSAMPLE_2424_SGIX")]
    PixelSubsample2424SGIX = 34211,

    [NativeName("GL_PIXEL_SUBSAMPLE_4242_SGIX")]
    PixelSubsample4242SGIX = 34212,

    [NativeName("GL_TEXTURE_ENV_BIAS_SGIX")]
    TextureEnvBiasSGIX = 32958,

    [NativeName("GL_TEXTURE_MAX_CLAMP_S_SGIX")]
    TextureMaxClampSSGIX = 33641,

    [NativeName("GL_TEXTURE_MAX_CLAMP_T_SGIX")]
    TextureMaxClampTSGIX = 33642,

    [NativeName("GL_TEXTURE_MAX_CLAMP_R_SGIX")]
    TextureMaxClampRSGIX = 33643,

    [NativeName("GL_TEXTURE_LOD_BIAS_S_SGIX")]
    TextureLodBiasSSGIX = 33166,

    [NativeName("GL_TEXTURE_LOD_BIAS_T_SGIX")]
    TextureLodBiasTSGIX = 33167,

    [NativeName("GL_TEXTURE_LOD_BIAS_R_SGIX")]
    TextureLodBiasRSGIX = 33168,

    [NativeName("GL_TEXTURE_MULTI_BUFFER_HINT_SGIX")]
    TextureMultiBufferHintSGIX = 33070,

    [NativeName("GL_POST_TEXTURE_FILTER_BIAS_SGIX")]
    PostTextureFilterBiasSGIX = 33145,

    [NativeName("GL_POST_TEXTURE_FILTER_SCALE_SGIX")]
    PostTextureFilterScaleSGIX = 33146,

    [NativeName("GL_POST_TEXTURE_FILTER_BIAS_RANGE_SGIX")]
    PostTextureFilterBiasRangeSGIX = 33147,

    [NativeName("GL_POST_TEXTURE_FILTER_SCALE_RANGE_SGIX")]
    PostTextureFilterScaleRangeSGIX = 33148,

    [NativeName("GL_VERTEX_PRECLIP_SGIX")]
    VertexPreclipSGIX = 33774,

    [NativeName("GL_VERTEX_PRECLIP_HINT_SGIX")]
    VertexPreclipHintSGIX = 33775,

    [NativeName("GL_YCRCB_422_SGIX")]
    Ycrcb422SGIX = 33211,

    [NativeName("GL_YCRCB_444_SGIX")]
    Ycrcb444SGIX = 33212,

    [NativeName("GL_YCRCB_SGIX")]
    YcrcbSGIX = 33560,

    [NativeName("GL_YCRCBA_SGIX")]
    YcrcbaSGIX = 33561,

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

    [NativeName("GL_PROXY_COLOR_TABLE_SGI")]
    ProxyColorTableSGI = 32979,

    [NativeName("GL_PROXY_POST_CONVOLUTION_COLOR_TABLE_SGI")]
    ProxyPostConvolutionColorTableSGI = 32980,

    [NativeName("GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE_SGI")]
    ProxyPostColorMatrixColorTableSGI = 32981,

    [NativeName("GL_COLOR_TABLE_SCALE_SGI")]
    ColorTableScaleSGI = 32982,

    [NativeName("GL_COLOR_TABLE_BIAS_SGI")]
    ColorTableBiasSGI = 32983,

    [NativeName("GL_COLOR_TABLE_FORMAT_SGI")]
    ColorTableFormatSGI = 32984,

    [NativeName("GL_COLOR_TABLE_WIDTH_SGI")]
    ColorTableWidthSGI = 32985,

    [NativeName("GL_COLOR_TABLE_RED_SIZE_SGI")]
    ColorTableRedSizeSGI = 32986,

    [NativeName("GL_COLOR_TABLE_GREEN_SIZE_SGI")]
    ColorTableGreenSizeSGI = 32987,

    [NativeName("GL_COLOR_TABLE_BLUE_SIZE_SGI")]
    ColorTableBlueSizeSGI = 32988,

    [NativeName("GL_COLOR_TABLE_ALPHA_SIZE_SGI")]
    ColorTableAlphaSizeSGI = 32989,

    [NativeName("GL_COLOR_TABLE_LUMINANCE_SIZE_SGI")]
    ColorTableLuminanceSizeSGI = 32990,

    [NativeName("GL_COLOR_TABLE_INTENSITY_SIZE_SGI")]
    ColorTableIntensitySizeSGI = 32991,

    [NativeName("GL_TEXTURE_COLOR_TABLE_SGI")]
    TextureColorTableSGI = 32956,

    [NativeName("GL_PROXY_TEXTURE_COLOR_TABLE_SGI")]
    ProxyTextureColorTableSGI = 32957,

    [NativeName("GL_UNPACK_CONSTANT_DATA_SUNX")]
    UnpackConstantDataSUNX = 33237,

    [NativeName("GL_TEXTURE_CONSTANT_DATA_SUNX")]
    TextureConstantDataSUNX = 33238,

    [NativeName("GL_WRAP_BORDER_SUN")]
    WrapBorderSUN = 33236,

    [NativeName("GL_GLOBAL_ALPHA_SUN")]
    GlobalAlphaSUN = 33241,

    [NativeName("GL_GLOBAL_ALPHA_FACTOR_SUN")]
    GlobalAlphaFactorSUN = 33242,

    [NativeName("GL_QUAD_MESH_SUN")]
    QuadMeshSUN = 34324,

    [NativeName("GL_TRIANGLE_MESH_SUN")]
    TriangleMeshSUN = 34325,

    [NativeName("GL_SLICE_ACCUM_SUN")]
    SliceAccumSUN = 34252,

    [NativeName("GL_RESTART_SUN")]
    RestartSUN = 1,

    [NativeName("GL_REPLACE_MIDDLE_SUN")]
    ReplaceMiddleSUN = 2,

    [NativeName("GL_REPLACE_OLDEST_SUN")]
    ReplaceOldestSUN = 3,

    [NativeName("GL_TRIANGLE_LIST_SUN")]
    TriangleListSUN = 33239,

    [NativeName("GL_REPLACEMENT_CODE_SUN")]
    ReplacementCodeSUN = 33240,

    [NativeName("GL_REPLACEMENT_CODE_ARRAY_SUN")]
    ReplacementCodeArraySUN = 34240,

    [NativeName("GL_REPLACEMENT_CODE_ARRAY_TYPE_SUN")]
    ReplacementCodeArrayTypeSUN = 34241,

    [NativeName("GL_REPLACEMENT_CODE_ARRAY_STRIDE_SUN")]
    ReplacementCodeArrayStrideSUN = 34242,

    [NativeName("GL_REPLACEMENT_CODE_ARRAY_POINTER_SUN")]
    ReplacementCodeArrayPointerSUN = 34243,

    [NativeName("GL_R1UI_V3F_SUN")]
    R1UiV3FSUN = 34244,

    [NativeName("GL_R1UI_C4UB_V3F_SUN")]
    R1UiC4UbV3FSUN = 34245,

    [NativeName("GL_R1UI_C3F_V3F_SUN")]
    R1UiC3FV3FSUN = 34246,

    [NativeName("GL_R1UI_N3F_V3F_SUN")]
    R1UiN3FV3FSUN = 34247,

    [NativeName("GL_R1UI_C4F_N3F_V3F_SUN")]
    R1UiC4FN3FV3FSUN = 34248,

    [NativeName("GL_R1UI_T2F_V3F_SUN")]
    R1UiT2FV3FSUN = 34249,

    [NativeName("GL_R1UI_T2F_N3F_V3F_SUN")]
    R1UiT2FN3FV3FSUN = 34250,

    [NativeName("GL_R1UI_T2F_C4F_N3F_V3F_SUN")]
    R1UiT2FC4FN3FV3FSUN = 34251,

    [NativeName("GL_PHONG_WIN")]
    PhongWIN = 33002,

    [NativeName("GL_PHONG_HINT_WIN")]
    PhongHintWIN = 33003,

    [NativeName("GL_FOG_SPECULAR_TEXTURE_WIN")]
    FogSpecularTextureWIN = 33004,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS")]
    FramebufferIncompleteDimensions = 36057,

    [NativeName("GL_CONTEXT_RELEASE_BEHAVIOR_KHR")]
    ContextReleaseBehaviorKHR = 33531,

    [NativeName("GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH_KHR")]
    ContextReleaseBehaviorFlushKHR = 33532,

    [NativeName("GL_DEBUG_OUTPUT_SYNCHRONOUS_KHR")]
    DebugOutputSynchronousKHR = 33346,

    [NativeName("GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_KHR")]
    DebugNextLoggedMessageLengthKHR = 33347,

    [NativeName("GL_DEBUG_CALLBACK_FUNCTION_KHR")]
    DebugCallbackFunctionKHR = 33348,

    [NativeName("GL_DEBUG_CALLBACK_USER_PARAM_KHR")]
    DebugCallbackUserParamKHR = 33349,

    [NativeName("GL_DEBUG_SOURCE_API_KHR")]
    DebugSourceApiKHR = 33350,

    [NativeName("GL_DEBUG_SOURCE_WINDOW_SYSTEM_KHR")]
    DebugSourceWindowSystemKHR = 33351,

    [NativeName("GL_DEBUG_SOURCE_SHADER_COMPILER_KHR")]
    DebugSourceShaderCompilerKHR = 33352,

    [NativeName("GL_DEBUG_SOURCE_THIRD_PARTY_KHR")]
    DebugSourceThirdPartyKHR = 33353,

    [NativeName("GL_DEBUG_SOURCE_APPLICATION_KHR")]
    DebugSourceApplicationKHR = 33354,

    [NativeName("GL_DEBUG_SOURCE_OTHER_KHR")]
    DebugSourceOtherKHR = 33355,

    [NativeName("GL_DEBUG_TYPE_ERROR_KHR")]
    DebugTypeErrorKHR = 33356,

    [NativeName("GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_KHR")]
    DebugTypeDeprecatedBehaviorKHR = 33357,

    [NativeName("GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_KHR")]
    DebugTypeUndefinedBehaviorKHR = 33358,

    [NativeName("GL_DEBUG_TYPE_PORTABILITY_KHR")]
    DebugTypePortabilityKHR = 33359,

    [NativeName("GL_DEBUG_TYPE_PERFORMANCE_KHR")]
    DebugTypePerformanceKHR = 33360,

    [NativeName("GL_DEBUG_TYPE_OTHER_KHR")]
    DebugTypeOtherKHR = 33361,

    [NativeName("GL_DEBUG_TYPE_MARKER_KHR")]
    DebugTypeMarkerKHR = 33384,

    [NativeName("GL_DEBUG_TYPE_PUSH_GROUP_KHR")]
    DebugTypePushGroupKHR = 33385,

    [NativeName("GL_DEBUG_TYPE_POP_GROUP_KHR")]
    DebugTypePopGroupKHR = 33386,

    [NativeName("GL_DEBUG_SEVERITY_NOTIFICATION_KHR")]
    DebugSeverityNotificationKHR = 33387,

    [NativeName("GL_MAX_DEBUG_GROUP_STACK_DEPTH_KHR")]
    MaxDebugGroupStackDepthKHR = 33388,

    [NativeName("GL_DEBUG_GROUP_STACK_DEPTH_KHR")]
    DebugGroupStackDepthKHR = 33389,

    [NativeName("GL_BUFFER_KHR")]
    BufferKHR = 33504,

    [NativeName("GL_SHADER_KHR")]
    ShaderKHR = 33505,

    [NativeName("GL_PROGRAM_KHR")]
    ProgramKHR = 33506,

    [NativeName("GL_VERTEX_ARRAY_KHR")]
    VertexArrayKHR = 32884,

    [NativeName("GL_QUERY_KHR")]
    QueryKHR = 33507,

    [NativeName("GL_PROGRAM_PIPELINE_KHR")]
    ProgramPipelineKHR = 33508,

    [NativeName("GL_SAMPLER_KHR")]
    SamplerKHR = 33510,

    [NativeName("GL_MAX_LABEL_LENGTH_KHR")]
    MaxLabelLengthKHR = 33512,

    [NativeName("GL_MAX_DEBUG_MESSAGE_LENGTH_KHR")]
    MaxDebugMessageLengthKHR = 37187,

    [NativeName("GL_MAX_DEBUG_LOGGED_MESSAGES_KHR")]
    MaxDebugLoggedMessagesKHR = 37188,

    [NativeName("GL_DEBUG_LOGGED_MESSAGES_KHR")]
    DebugLoggedMessagesKHR = 37189,

    [NativeName("GL_DEBUG_SEVERITY_HIGH_KHR")]
    DebugSeverityHighKHR = 37190,

    [NativeName("GL_DEBUG_SEVERITY_MEDIUM_KHR")]
    DebugSeverityMediumKHR = 37191,

    [NativeName("GL_DEBUG_SEVERITY_LOW_KHR")]
    DebugSeverityLowKHR = 37192,

    [NativeName("GL_DEBUG_OUTPUT_KHR")]
    DebugOutputKHR = 37600,

    [NativeName("GL_CONTEXT_FLAG_DEBUG_BIT_KHR")]
    ContextFlagDebugBitKHR = 2,

    [NativeName("GL_STACK_OVERFLOW_KHR")]
    StackOverflowKHR = 1283,

    [NativeName("GL_STACK_UNDERFLOW_KHR")]
    StackUnderflowKHR = 1284,

    [NativeName("GL_CONTEXT_ROBUST_ACCESS_KHR")]
    ContextRobustAccessKHR = 37107,

    [NativeName("GL_LOSE_CONTEXT_ON_RESET_KHR")]
    LoseContextOnResetKHR = 33362,

    [NativeName("GL_GUILTY_CONTEXT_RESET_KHR")]
    GuiltyContextResetKHR = 33363,

    [NativeName("GL_INNOCENT_CONTEXT_RESET_KHR")]
    InnocentContextResetKHR = 33364,

    [NativeName("GL_UNKNOWN_CONTEXT_RESET_KHR")]
    UnknownContextResetKHR = 33365,

    [NativeName("GL_RESET_NOTIFICATION_STRATEGY_KHR")]
    ResetNotificationStrategyKHR = 33366,

    [NativeName("GL_NO_RESET_NOTIFICATION_KHR")]
    NoResetNotificationKHR = 33377,

    [NativeName("GL_CONTEXT_LOST_KHR")]
    ContextLostKHR = 1287,

    [NativeName("GL_SAMPLER_EXTERNAL_OES")]
    SamplerExternalOES = 36198,

    [NativeName("GL_GEOMETRY_SHADER_OES")]
    GeometryShaderOES = 36313,

    [NativeName("GL_GEOMETRY_SHADER_BIT_OES")]
    GeometryShaderBitOES = 4,

    [NativeName("GL_GEOMETRY_LINKED_VERTICES_OUT_OES")]
    GeometryLinkedVerticesOutOES = 35094,

    [NativeName("GL_GEOMETRY_LINKED_INPUT_TYPE_OES")]
    GeometryLinkedInputTypeOES = 35095,

    [NativeName("GL_GEOMETRY_LINKED_OUTPUT_TYPE_OES")]
    GeometryLinkedOutputTypeOES = 35096,

    [NativeName("GL_GEOMETRY_SHADER_INVOCATIONS_OES")]
    GeometryShaderInvocationsOES = 34943,

    [NativeName("GL_LAYER_PROVOKING_VERTEX_OES")]
    LayerProvokingVertexOES = 33374,

    [NativeName("GL_LINES_ADJACENCY_OES")]
    LinesAdjacencyOES = 10,

    [NativeName("GL_LINE_STRIP_ADJACENCY_OES")]
    LineStripAdjacencyOES = 11,

    [NativeName("GL_TRIANGLES_ADJACENCY_OES")]
    TrianglesAdjacencyOES = 12,

    [NativeName("GL_TRIANGLE_STRIP_ADJACENCY_OES")]
    TriangleStripAdjacencyOES = 13,

    [NativeName("GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_OES")]
    MaxGeometryUniformComponentsOES = 36319,

    [NativeName("GL_MAX_GEOMETRY_UNIFORM_BLOCKS_OES")]
    MaxGeometryUniformBlocksOES = 35372,

    [NativeName("GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS_OES")]
    MaxCombinedGeometryUniformComponentsOES = 35378,

    [NativeName("GL_MAX_GEOMETRY_INPUT_COMPONENTS_OES")]
    MaxGeometryInputComponentsOES = 37155,

    [NativeName("GL_MAX_GEOMETRY_OUTPUT_COMPONENTS_OES")]
    MaxGeometryOutputComponentsOES = 37156,

    [NativeName("GL_MAX_GEOMETRY_OUTPUT_VERTICES_OES")]
    MaxGeometryOutputVerticesOES = 36320,

    [NativeName("GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_OES")]
    MaxGeometryTotalOutputComponentsOES = 36321,

    [NativeName("GL_MAX_GEOMETRY_SHADER_INVOCATIONS_OES")]
    MaxGeometryShaderInvocationsOES = 36442,

    [NativeName("GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_OES")]
    MaxGeometryTextureImageUnitsOES = 35881,

    [NativeName("GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS_OES")]
    MaxGeometryAtomicCounterBuffersOES = 37583,

    [NativeName("GL_MAX_GEOMETRY_ATOMIC_COUNTERS_OES")]
    MaxGeometryAtomicCountersOES = 37589,

    [NativeName("GL_MAX_GEOMETRY_IMAGE_UNIFORMS_OES")]
    MaxGeometryImageUniformsOES = 37069,

    [NativeName("GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS_OES")]
    MaxGeometryShaderStorageBlocksOES = 37079,

    [NativeName("GL_FIRST_VERTEX_CONVENTION_OES")]
    FirstVertexConventionOES = 36429,

    [NativeName("GL_LAST_VERTEX_CONVENTION_OES")]
    LastVertexConventionOES = 36430,

    [NativeName("GL_UNDEFINED_VERTEX_OES")]
    UndefinedVertexOES = 33376,

    [NativeName("GL_PRIMITIVES_GENERATED_OES")]
    PrimitivesGeneratedOES = 35975,

    [NativeName("GL_FRAMEBUFFER_DEFAULT_LAYERS_OES")]
    FramebufferDefaultLayersOES = 37650,

    [NativeName("GL_MAX_FRAMEBUFFER_LAYERS_OES")]
    MaxFramebufferLayersOES = 37655,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_OES")]
    FramebufferIncompleteLayerTargetsOES = 36264,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_LAYERED_OES")]
    FramebufferAttachmentLayeredOES = 36263,

    [NativeName("GL_REFERENCED_BY_GEOMETRY_SHADER_OES")]
    ReferencedByGeometryShaderOES = 37641,

    [NativeName("GL_PROGRAM_BINARY_LENGTH_OES")]
    ProgramBinaryLengthOES = 34625,

    [NativeName("GL_NUM_PROGRAM_BINARY_FORMATS_OES")]
    NumProgramBinaryFormatsOES = 34814,

    [NativeName("GL_PROGRAM_BINARY_FORMATS_OES")]
    ProgramBinaryFormatsOES = 34815,

    [NativeName("GL_PRIMITIVE_BOUNDING_BOX_OES")]
    PrimitiveBoundingBoxOES = 37566,

    [NativeName("GL_SAMPLE_SHADING_OES")]
    SampleShadingOES = 35894,

    [NativeName("GL_MIN_SAMPLE_SHADING_VALUE_OES")]
    MinSampleShadingValueOES = 35895,

    [NativeName("GL_MIN_FRAGMENT_INTERPOLATION_OFFSET_OES")]
    MinFragmentInterpolationOffsetOES = 36443,

    [NativeName("GL_MAX_FRAGMENT_INTERPOLATION_OFFSET_OES")]
    MaxFragmentInterpolationOffsetOES = 36444,

    [NativeName("GL_FRAGMENT_INTERPOLATION_OFFSET_BITS_OES")]
    FragmentInterpolationOffsetBitsOES = 36445,

    [NativeName("GL_FRAGMENT_SHADER_DERIVATIVE_HINT_OES")]
    FragmentShaderDerivativeHintOES = 35723,

    [NativeName("GL_PATCHES_OES")]
    PatchesOES = 14,

    [NativeName("GL_PATCH_VERTICES_OES")]
    PatchVerticesOES = 36466,

    [NativeName("GL_TESS_CONTROL_OUTPUT_VERTICES_OES")]
    TessControlOutputVerticesOES = 36469,

    [NativeName("GL_TESS_GEN_MODE_OES")]
    TessGenModeOES = 36470,

    [NativeName("GL_TESS_GEN_SPACING_OES")]
    TessGenSpacingOES = 36471,

    [NativeName("GL_TESS_GEN_VERTEX_ORDER_OES")]
    TessGenVertexOrderOES = 36472,

    [NativeName("GL_TESS_GEN_POINT_MODE_OES")]
    TessGenPointModeOES = 36473,

    [NativeName("GL_ISOLINES_OES")]
    IsolinesOES = 36474,

    [NativeName("GL_QUADS_OES")]
    QuadsOES = 7,

    [NativeName("GL_FRACTIONAL_ODD_OES")]
    FractionalOddOES = 36475,

    [NativeName("GL_FRACTIONAL_EVEN_OES")]
    FractionalEvenOES = 36476,

    [NativeName("GL_MAX_PATCH_VERTICES_OES")]
    MaxPatchVerticesOES = 36477,

    [NativeName("GL_MAX_TESS_GEN_LEVEL_OES")]
    MaxTessGenLevelOES = 36478,

    [NativeName("GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS_OES")]
    MaxTessControlUniformComponentsOES = 36479,

    [NativeName("GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS_OES")]
    MaxTessEvaluationUniformComponentsOES = 36480,

    [NativeName("GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS_OES")]
    MaxTessControlTextureImageUnitsOES = 36481,

    [NativeName("GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS_OES")]
    MaxTessEvaluationTextureImageUnitsOES = 36482,

    [NativeName("GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS_OES")]
    MaxTessControlOutputComponentsOES = 36483,

    [NativeName("GL_MAX_TESS_PATCH_COMPONENTS_OES")]
    MaxTessPatchComponentsOES = 36484,

    [NativeName("GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS_OES")]
    MaxTessControlTotalOutputComponentsOES = 36485,

    [NativeName("GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS_OES")]
    MaxTessEvaluationOutputComponentsOES = 36486,

    [NativeName("GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS_OES")]
    MaxTessControlUniformBlocksOES = 36489,

    [NativeName("GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS_OES")]
    MaxTessEvaluationUniformBlocksOES = 36490,

    [NativeName("GL_MAX_TESS_CONTROL_INPUT_COMPONENTS_OES")]
    MaxTessControlInputComponentsOES = 34924,

    [NativeName("GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS_OES")]
    MaxTessEvaluationInputComponentsOES = 34925,

    [NativeName("GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS_OES")]
    MaxCombinedTessControlUniformComponentsOES = 36382,

    [NativeName("GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS_OES")]
    MaxCombinedTessEvaluationUniformComponentsOES = 36383,

    [NativeName("GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS_OES")]
    MaxTessControlAtomicCounterBuffersOES = 37581,

    [NativeName("GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS_OES")]
    MaxTessEvaluationAtomicCounterBuffersOES = 37582,

    [NativeName("GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS_OES")]
    MaxTessControlAtomicCountersOES = 37587,

    [NativeName("GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS_OES")]
    MaxTessEvaluationAtomicCountersOES = 37588,

    [NativeName("GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS_OES")]
    MaxTessControlImageUniformsOES = 37067,

    [NativeName("GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS_OES")]
    MaxTessEvaluationImageUniformsOES = 37068,

    [NativeName("GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS_OES")]
    MaxTessControlShaderStorageBlocksOES = 37080,

    [NativeName("GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS_OES")]
    MaxTessEvaluationShaderStorageBlocksOES = 37081,

    [NativeName("GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED_OES")]
    PrimitiveRestartForPatchesSupportedOES = 33313,

    [NativeName("GL_IS_PER_PATCH_OES")]
    IsPerPatchOES = 37607,

    [NativeName("GL_REFERENCED_BY_TESS_CONTROL_SHADER_OES")]
    ReferencedByTessControlShaderOES = 37639,

    [NativeName("GL_REFERENCED_BY_TESS_EVALUATION_SHADER_OES")]
    ReferencedByTessEvaluationShaderOES = 37640,

    [NativeName("GL_TESS_CONTROL_SHADER_OES")]
    TessControlShaderOES = 36488,

    [NativeName("GL_TESS_EVALUATION_SHADER_OES")]
    TessEvaluationShaderOES = 36487,

    [NativeName("GL_TESS_CONTROL_SHADER_BIT_OES")]
    TessControlShaderBitOES = 8,

    [NativeName("GL_TESS_EVALUATION_SHADER_BIT_OES")]
    TessEvaluationShaderBitOES = 16,

    [NativeName("GL_TEXTURE_WRAP_R_OES")]
    TextureWrapROES = 32882,

    [NativeName("GL_TEXTURE_3D_OES")]
    Texture3DOES = 32879,

    [NativeName("GL_TEXTURE_BINDING_3D_OES")]
    TextureBinding3DOES = 32874,

    [NativeName("GL_MAX_3D_TEXTURE_SIZE_OES")]
    Max3DTextureSizeOES = 32883,

    [NativeName("GL_SAMPLER_3D_OES")]
    Sampler3DOES = 35679,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_OES")]
    FramebufferAttachmentTexture3DZoffsetOES = 36052,

    [NativeName("GL_TEXTURE_BORDER_COLOR_OES")]
    TextureBorderColorOES = 4100,

    [NativeName("GL_CLAMP_TO_BORDER_OES")]
    ClampToBorderOES = 33069,

    [NativeName("GL_TEXTURE_BUFFER_OES")]
    TextureBufferOES = 35882,

    [NativeName("GL_TEXTURE_BUFFER_BINDING_OES")]
    TextureBufferBindingOES = 35882,

    [NativeName("GL_MAX_TEXTURE_BUFFER_SIZE_OES")]
    MaxTextureBufferSizeOES = 35883,

    [NativeName("GL_TEXTURE_BINDING_BUFFER_OES")]
    TextureBindingBufferOES = 35884,

    [NativeName("GL_TEXTURE_BUFFER_DATA_STORE_BINDING_OES")]
    TextureBufferDataStoreBindingOES = 35885,

    [NativeName("GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT_OES")]
    TextureBufferOffsetAlignmentOES = 37279,

    [NativeName("GL_SAMPLER_BUFFER_OES")]
    SamplerBufferOES = 36290,

    [NativeName("GL_INT_SAMPLER_BUFFER_OES")]
    IntSamplerBufferOES = 36304,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_BUFFER_OES")]
    UnsignedIntSamplerBufferOES = 36312,

    [NativeName("GL_IMAGE_BUFFER_OES")]
    ImageBufferOES = 36945,

    [NativeName("GL_INT_IMAGE_BUFFER_OES")]
    IntImageBufferOES = 36956,

    [NativeName("GL_UNSIGNED_INT_IMAGE_BUFFER_OES")]
    UnsignedIntImageBufferOES = 36967,

    [NativeName("GL_TEXTURE_BUFFER_OFFSET_OES")]
    TextureBufferOffsetOES = 37277,

    [NativeName("GL_TEXTURE_BUFFER_SIZE_OES")]
    TextureBufferSizeOES = 37278,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_3x3x3_OES")]
    CompressedRgbaAstc3X3X3OES = 37824,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_4x3x3_OES")]
    CompressedRgbaAstc4X3X3OES = 37825,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_4x4x3_OES")]
    CompressedRgbaAstc4X4X3OES = 37826,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_4x4x4_OES")]
    CompressedRgbaAstc4X4X4OES = 37827,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_5x4x4_OES")]
    CompressedRgbaAstc5X4X4OES = 37828,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_5x5x4_OES")]
    CompressedRgbaAstc5X5X4OES = 37829,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_5x5x5_OES")]
    CompressedRgbaAstc5X5X5OES = 37830,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_6x5x5_OES")]
    CompressedRgbaAstc6X5X5OES = 37831,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_6x6x5_OES")]
    CompressedRgbaAstc6X6X5OES = 37832,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_6x6x6_OES")]
    CompressedRgbaAstc6X6X6OES = 37833,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_3x3x3_OES")]
    CompressedSrgb8Alpha8Astc3X3X3OES = 37856,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x3x3_OES")]
    CompressedSrgb8Alpha8Astc4X3X3OES = 37857,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x3_OES")]
    CompressedSrgb8Alpha8Astc4X4X3OES = 37858,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x4_OES")]
    CompressedSrgb8Alpha8Astc4X4X4OES = 37859,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4x4_OES")]
    CompressedSrgb8Alpha8Astc5X4X4OES = 37860,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x4_OES")]
    CompressedSrgb8Alpha8Astc5X5X4OES = 37861,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x5_OES")]
    CompressedSrgb8Alpha8Astc5X5X5OES = 37862,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5x5_OES")]
    CompressedSrgb8Alpha8Astc6X5X5OES = 37863,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x5_OES")]
    CompressedSrgb8Alpha8Astc6X6X5OES = 37864,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x6_OES")]
    CompressedSrgb8Alpha8Astc6X6X6OES = 37865,

    [NativeName("GL_TEXTURE_CUBE_MAP_ARRAY_OES")]
    TextureCubeMapArrayOES = 36873,

    [NativeName("GL_TEXTURE_BINDING_CUBE_MAP_ARRAY_OES")]
    TextureBindingCubeMapArrayOES = 36874,

    [NativeName("GL_SAMPLER_CUBE_MAP_ARRAY_OES")]
    SamplerCubeMapArrayOES = 36876,

    [NativeName("GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW_OES")]
    SamplerCubeMapArrayShadowOES = 36877,

    [NativeName("GL_INT_SAMPLER_CUBE_MAP_ARRAY_OES")]
    IntSamplerCubeMapArrayOES = 36878,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_OES")]
    UnsignedIntSamplerCubeMapArrayOES = 36879,

    [NativeName("GL_IMAGE_CUBE_MAP_ARRAY_OES")]
    ImageCubeMapArrayOES = 36948,

    [NativeName("GL_INT_IMAGE_CUBE_MAP_ARRAY_OES")]
    IntImageCubeMapArrayOES = 36959,

    [NativeName("GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_OES")]
    UnsignedIntImageCubeMapArrayOES = 36970,

    [NativeName("GL_HALF_FLOAT_OES")]
    HalfFloatOES = 36193,

    [NativeName("GL_STENCIL_INDEX_OES")]
    StencilIndexOES = 6401,

    [NativeName("GL_TEXTURE_2D_MULTISAMPLE_ARRAY_OES")]
    Texture2DMultisampleArrayOES = 37122,

    [NativeName("GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY_OES")]
    TextureBinding2DMultisampleArrayOES = 37125,

    [NativeName("GL_SAMPLER_2D_MULTISAMPLE_ARRAY_OES")]
    Sampler2DMultisampleArrayOES = 37131,

    [NativeName("GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY_OES")]
    IntSampler2DMultisampleArrayOES = 37132,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY_OES")]
    UnsignedIntSampler2DMultisampleArrayOES = 37133,

    [NativeName("GL_TEXTURE_VIEW_MIN_LEVEL_OES")]
    TextureViewMinLevelOES = 33499,

    [NativeName("GL_TEXTURE_VIEW_NUM_LEVELS_OES")]
    TextureViewNumLevelsOES = 33500,

    [NativeName("GL_TEXTURE_VIEW_MIN_LAYER_OES")]
    TextureViewMinLayerOES = 33501,

    [NativeName("GL_TEXTURE_VIEW_NUM_LAYERS_OES")]
    TextureViewNumLayersOES = 33502,

    [NativeName("GL_UNSIGNED_INT_10_10_10_2_OES")]
    UnsignedInt10X10X10X2OES = 36342,

    [NativeName("GL_INT_10_10_10_2_OES")]
    Int10X10X10X2OES = 36343,

    [NativeName("GL_MAX_VIEWPORTS_OES")]
    MaxViewportsOES = 33371,

    [NativeName("GL_VIEWPORT_SUBPIXEL_BITS_OES")]
    ViewportSubpixelBitsOES = 33372,

    [NativeName("GL_VIEWPORT_BOUNDS_RANGE_OES")]
    ViewportBoundsRangeOES = 33373,

    [NativeName("GL_VIEWPORT_INDEX_PROVOKING_VERTEX_OES")]
    ViewportIndexProvokingVertexOES = 33375,

    [NativeName("GL_Z400_BINARY_AMD")]
    Z400BinaryAMD = 34624,

    [NativeName("GL_READ_FRAMEBUFFER_ANGLE")]
    ReadFramebufferANGLE = 36008,

    [NativeName("GL_DRAW_FRAMEBUFFER_ANGLE")]
    DrawFramebufferANGLE = 36009,

    [NativeName("GL_DRAW_FRAMEBUFFER_BINDING_ANGLE")]
    DrawFramebufferBindingANGLE = 36006,

    [NativeName("GL_READ_FRAMEBUFFER_BINDING_ANGLE")]
    ReadFramebufferBindingANGLE = 36010,

    [NativeName("GL_RENDERBUFFER_SAMPLES_ANGLE")]
    RenderbufferSamplesANGLE = 36011,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_ANGLE")]
    FramebufferIncompleteMultisampleANGLE = 36182,

    [NativeName("GL_MAX_SAMPLES_ANGLE")]
    MaxSamplesANGLE = 36183,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_DIVISOR_ANGLE")]
    VertexAttribArrayDivisorANGLE = 35070,

    [NativeName("GL_PACK_REVERSE_ROW_ORDER_ANGLE")]
    PackReverseRowOrderANGLE = 37796,

    [NativeName("GL_PROGRAM_BINARY_ANGLE")]
    ProgramBinaryANGLE = 37798,

    [NativeName("GL_COMPRESSED_RGBA_S3TC_DXT3_ANGLE")]
    CompressedRgbaS3TcDxt3ANGLE = 33778,

    [NativeName("GL_COMPRESSED_RGBA_S3TC_DXT5_ANGLE")]
    CompressedRgbaS3TcDxt5ANGLE = 33779,

    [NativeName("GL_TEXTURE_USAGE_ANGLE")]
    TextureUsageANGLE = 37794,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_ANGLE")]
    FramebufferAttachmentANGLE = 37795,

    [NativeName("GL_TRANSLATED_SHADER_SOURCE_LENGTH_ANGLE")]
    TranslatedShaderSourceLengthANGLE = 37792,

    [NativeName("GL_MAX_CLIP_DISTANCES_APPLE")]
    MaxClipDistancesAPPLE = 3378,

    [NativeName("GL_CLIP_DISTANCE0_APPLE")]
    ClipDistance0APPLE = 12288,

    [NativeName("GL_CLIP_DISTANCE1_APPLE")]
    ClipDistance1APPLE = 12289,

    [NativeName("GL_CLIP_DISTANCE2_APPLE")]
    ClipDistance2APPLE = 12290,

    [NativeName("GL_CLIP_DISTANCE3_APPLE")]
    ClipDistance3APPLE = 12291,

    [NativeName("GL_CLIP_DISTANCE4_APPLE")]
    ClipDistance4APPLE = 12292,

    [NativeName("GL_CLIP_DISTANCE5_APPLE")]
    ClipDistance5APPLE = 12293,

    [NativeName("GL_CLIP_DISTANCE6_APPLE")]
    ClipDistance6APPLE = 12294,

    [NativeName("GL_CLIP_DISTANCE7_APPLE")]
    ClipDistance7APPLE = 12295,

    [NativeName("GL_UNSIGNED_INT_10F_11F_11F_REV_APPLE")]
    UnsignedInt10F11F11FRevAPPLE = 35899,

    [NativeName("GL_UNSIGNED_INT_5_9_9_9_REV_APPLE")]
    UnsignedInt5X9X9X9RevAPPLE = 35902,

    [NativeName("GL_R11F_G11F_B10F_APPLE")]
    R11FG11FB10FAPPLE = 35898,

    [NativeName("GL_RGB9_E5_APPLE")]
    Rgb9E5APPLE = 35901,

    [NativeName("GL_MALI_PROGRAM_BINARY_ARM")]
    MaliProgramBinaryARM = 36705,

    [NativeName("GL_MALI_SHADER_BINARY_ARM")]
    MaliShaderBinaryARM = 36704,

    [NativeName("GL_FETCH_PER_SAMPLE_ARM")]
    FetchPerSampleARM = 36709,

    [NativeName("GL_FRAGMENT_SHADER_FRAMEBUFFER_FETCH_MRT_ARM")]
    FragmentShaderFramebufferFetchMrtARM = 36710,

    [NativeName("GL_TEXTURE_UNNORMALIZED_COORDINATES_ARM")]
    TextureUnnormalizedCoordinatesARM = 36714,

    [NativeName("GL_SMAPHS30_PROGRAM_BINARY_DMP")]
    Smaphs30ProgramBinaryDMP = 37457,

    [NativeName("GL_SMAPHS_PROGRAM_BINARY_DMP")]
    SmaphsProgramBinaryDMP = 37458,

    [NativeName("GL_DMP_PROGRAM_BINARY_DMP")]
    DmpProgramBinaryDMP = 37459,

    [NativeName("GL_SHADER_BINARY_DMP")]
    ShaderBinaryDMP = 37456,

    [NativeName("GL_SURFACE_COMPRESSION_EXT")]
    SurfaceCompressionEXT = 38592,

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_NONE_EXT")]
    SurfaceCompressionFixedRateNoneEXT = 38593,

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_DEFAULT_EXT")]
    SurfaceCompressionFixedRateDefaultEXT = 38594,

    [NativeName("GL_SAMPLER_EXTERNAL_2D_Y2Y_EXT")]
    SamplerExternal2DY2YEXT = 35815,

    [NativeName("GL_SRC1_COLOR_EXT")]
    Src1ColorEXT = 35065,

    [NativeName("GL_SRC1_ALPHA_EXT")]
    Src1AlphaEXT = 34185,

    [NativeName("GL_ONE_MINUS_SRC1_COLOR_EXT")]
    OneMinusSrc1ColorEXT = 35066,

    [NativeName("GL_ONE_MINUS_SRC1_ALPHA_EXT")]
    OneMinusSrc1AlphaEXT = 35067,

    [NativeName("GL_SRC_ALPHA_SATURATE_EXT")]
    SrcAlphaSaturateEXT = 776,

    [NativeName("GL_LOCATION_INDEX_EXT")]
    LocationIndexEXT = 37647,

    [NativeName("GL_MAX_DUAL_SOURCE_DRAW_BUFFERS_EXT")]
    MaxDualSourceDrawBuffersEXT = 35068,

    [NativeName("GL_MAP_PERSISTENT_BIT_EXT")]
    MapPersistentBitEXT = 64,

    [NativeName("GL_MAP_COHERENT_BIT_EXT")]
    MapCoherentBitEXT = 128,

    [NativeName("GL_DYNAMIC_STORAGE_BIT_EXT")]
    DynamicStorageBitEXT = 256,

    [NativeName("GL_CLIENT_STORAGE_BIT_EXT")]
    ClientStorageBitEXT = 512,

    [NativeName("GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT_EXT")]
    ClientMappedBufferBarrierBitEXT = 16384,

    [NativeName("GL_BUFFER_IMMUTABLE_STORAGE_EXT")]
    BufferImmutableStorageEXT = 33311,

    [NativeName("GL_BUFFER_STORAGE_FLAGS_EXT")]
    BufferStorageFlagsEXT = 33312,

    [NativeName("GL_LOWER_LEFT_EXT")]
    LowerLeftEXT = 36001,

    [NativeName("GL_UPPER_LEFT_EXT")]
    UpperLeftEXT = 36002,

    [NativeName("GL_NEGATIVE_ONE_TO_ONE_EXT")]
    NegativeOneToOneEXT = 37726,

    [NativeName("GL_ZERO_TO_ONE_EXT")]
    ZeroToOneEXT = 37727,

    [NativeName("GL_CLIP_ORIGIN_EXT")]
    ClipOriginEXT = 37724,

    [NativeName("GL_CLIP_DEPTH_MODE_EXT")]
    ClipDepthModeEXT = 37725,

    [NativeName("GL_MAX_CLIP_DISTANCES_EXT")]
    MaxClipDistancesEXT = 3378,

    [NativeName("GL_MAX_CULL_DISTANCES_EXT")]
    MaxCullDistancesEXT = 33529,

    [NativeName("GL_MAX_COMBINED_CLIP_AND_CULL_DISTANCES_EXT")]
    MaxCombinedClipAndCullDistancesEXT = 33530,

    [NativeName("GL_CLIP_DISTANCE0_EXT")]
    ClipDistance0EXT = 12288,

    [NativeName("GL_CLIP_DISTANCE1_EXT")]
    ClipDistance1EXT = 12289,

    [NativeName("GL_CLIP_DISTANCE2_EXT")]
    ClipDistance2EXT = 12290,

    [NativeName("GL_CLIP_DISTANCE3_EXT")]
    ClipDistance3EXT = 12291,

    [NativeName("GL_CLIP_DISTANCE4_EXT")]
    ClipDistance4EXT = 12292,

    [NativeName("GL_CLIP_DISTANCE5_EXT")]
    ClipDistance5EXT = 12293,

    [NativeName("GL_CLIP_DISTANCE6_EXT")]
    ClipDistance6EXT = 12294,

    [NativeName("GL_CLIP_DISTANCE7_EXT")]
    ClipDistance7EXT = 12295,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE_EXT")]
    FramebufferAttachmentComponentTypeEXT = 33297,

    [NativeName("GL_UNSIGNED_NORMALIZED_EXT")]
    UnsignedNormalizedEXT = 35863,

    [NativeName("GL_DEPTH_CLAMP_EXT")]
    DepthClampEXT = 34383,

    [NativeName("GL_QUERY_COUNTER_BITS_EXT")]
    QueryCounterBitsEXT = 34916,

    [NativeName("GL_CURRENT_QUERY_EXT")]
    CurrentQueryEXT = 34917,

    [NativeName("GL_QUERY_RESULT_EXT")]
    QueryResultEXT = 34918,

    [NativeName("GL_QUERY_RESULT_AVAILABLE_EXT")]
    QueryResultAvailableEXT = 34919,

    [NativeName("GL_TIMESTAMP_EXT")]
    TimestampEXT = 36392,

    [NativeName("GL_GPU_DISJOINT_EXT")]
    GpuDisjointEXT = 36795,

    [NativeName("GL_MAX_DRAW_BUFFERS_EXT")]
    MaxDrawBuffersEXT = 34852,

    [NativeName("GL_DRAW_BUFFER0_EXT")]
    DrawBuffer0EXT = 34853,

    [NativeName("GL_DRAW_BUFFER1_EXT")]
    DrawBuffer1EXT = 34854,

    [NativeName("GL_DRAW_BUFFER2_EXT")]
    DrawBuffer2EXT = 34855,

    [NativeName("GL_DRAW_BUFFER3_EXT")]
    DrawBuffer3EXT = 34856,

    [NativeName("GL_DRAW_BUFFER4_EXT")]
    DrawBuffer4EXT = 34857,

    [NativeName("GL_DRAW_BUFFER5_EXT")]
    DrawBuffer5EXT = 34858,

    [NativeName("GL_DRAW_BUFFER6_EXT")]
    DrawBuffer6EXT = 34859,

    [NativeName("GL_DRAW_BUFFER7_EXT")]
    DrawBuffer7EXT = 34860,

    [NativeName("GL_DRAW_BUFFER8_EXT")]
    DrawBuffer8EXT = 34861,

    [NativeName("GL_DRAW_BUFFER9_EXT")]
    DrawBuffer9EXT = 34862,

    [NativeName("GL_DRAW_BUFFER10_EXT")]
    DrawBuffer10EXT = 34863,

    [NativeName("GL_DRAW_BUFFER11_EXT")]
    DrawBuffer11EXT = 34864,

    [NativeName("GL_DRAW_BUFFER12_EXT")]
    DrawBuffer12EXT = 34865,

    [NativeName("GL_DRAW_BUFFER13_EXT")]
    DrawBuffer13EXT = 34866,

    [NativeName("GL_DRAW_BUFFER14_EXT")]
    DrawBuffer14EXT = 34867,

    [NativeName("GL_DRAW_BUFFER15_EXT")]
    DrawBuffer15EXT = 34868,

    [NativeName("GL_SHADING_RATE_1X1_PIXELS_EXT")]
    ShadingRate1X1PixelsEXT = 38566,

    [NativeName("GL_SHADING_RATE_1X2_PIXELS_EXT")]
    ShadingRate1X2PixelsEXT = 38567,

    [NativeName("GL_SHADING_RATE_2X1_PIXELS_EXT")]
    ShadingRate2X1PixelsEXT = 38568,

    [NativeName("GL_SHADING_RATE_2X2_PIXELS_EXT")]
    ShadingRate2X2PixelsEXT = 38569,

    [NativeName("GL_SHADING_RATE_1X4_PIXELS_EXT")]
    ShadingRate1X4PixelsEXT = 38570,

    [NativeName("GL_SHADING_RATE_4X1_PIXELS_EXT")]
    ShadingRate4X1PixelsEXT = 38571,

    [NativeName("GL_SHADING_RATE_4X2_PIXELS_EXT")]
    ShadingRate4X2PixelsEXT = 38572,

    [NativeName("GL_SHADING_RATE_2X4_PIXELS_EXT")]
    ShadingRate2X4PixelsEXT = 38573,

    [NativeName("GL_SHADING_RATE_4X4_PIXELS_EXT")]
    ShadingRate4X4PixelsEXT = 38574,

    [NativeName("GL_SHADING_RATE_EXT")]
    ShadingRateEXT = 38608,

    [NativeName("GL_SHADING_RATE_ATTACHMENT_EXT")]
    ShadingRateAttachmentEXT = 38609,

    [NativeName("GL_FRAGMENT_SHADING_RATE_COMBINER_OP_KEEP_EXT")]
    FragmentShadingRateCombinerOpKeepEXT = 38610,

    [NativeName("GL_FRAGMENT_SHADING_RATE_COMBINER_OP_REPLACE_EXT")]
    FragmentShadingRateCombinerOpReplaceEXT = 38611,

    [NativeName("GL_FRAGMENT_SHADING_RATE_COMBINER_OP_MIN_EXT")]
    FragmentShadingRateCombinerOpMinEXT = 38612,

    [NativeName("GL_FRAGMENT_SHADING_RATE_COMBINER_OP_MAX_EXT")]
    FragmentShadingRateCombinerOpMaxEXT = 38613,

    [NativeName("GL_FRAGMENT_SHADING_RATE_COMBINER_OP_MUL_EXT")]
    FragmentShadingRateCombinerOpMulEXT = 38614,

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

    [NativeName("GL_GEOMETRY_SHADER_BIT_EXT")]
    GeometryShaderBitEXT = 4,

    [NativeName("GL_GEOMETRY_LINKED_VERTICES_OUT_EXT")]
    GeometryLinkedVerticesOutEXT = 35094,

    [NativeName("GL_GEOMETRY_LINKED_INPUT_TYPE_EXT")]
    GeometryLinkedInputTypeEXT = 35095,

    [NativeName("GL_GEOMETRY_LINKED_OUTPUT_TYPE_EXT")]
    GeometryLinkedOutputTypeEXT = 35096,

    [NativeName("GL_GEOMETRY_SHADER_INVOCATIONS_EXT")]
    GeometryShaderInvocationsEXT = 34943,

    [NativeName("GL_LAYER_PROVOKING_VERTEX_EXT")]
    LayerProvokingVertexEXT = 33374,

    [NativeName("GL_MAX_GEOMETRY_UNIFORM_BLOCKS_EXT")]
    MaxGeometryUniformBlocksEXT = 35372,

    [NativeName("GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS_EXT")]
    MaxCombinedGeometryUniformComponentsEXT = 35378,

    [NativeName("GL_MAX_GEOMETRY_INPUT_COMPONENTS_EXT")]
    MaxGeometryInputComponentsEXT = 37155,

    [NativeName("GL_MAX_GEOMETRY_OUTPUT_COMPONENTS_EXT")]
    MaxGeometryOutputComponentsEXT = 37156,

    [NativeName("GL_MAX_GEOMETRY_SHADER_INVOCATIONS_EXT")]
    MaxGeometryShaderInvocationsEXT = 36442,

    [NativeName("GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS_EXT")]
    MaxGeometryAtomicCounterBuffersEXT = 37583,

    [NativeName("GL_MAX_GEOMETRY_ATOMIC_COUNTERS_EXT")]
    MaxGeometryAtomicCountersEXT = 37589,

    [NativeName("GL_MAX_GEOMETRY_IMAGE_UNIFORMS_EXT")]
    MaxGeometryImageUniformsEXT = 37069,

    [NativeName("GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS_EXT")]
    MaxGeometryShaderStorageBlocksEXT = 37079,

    [NativeName("GL_UNDEFINED_VERTEX_EXT")]
    UndefinedVertexEXT = 33376,

    [NativeName("GL_FRAMEBUFFER_DEFAULT_LAYERS_EXT")]
    FramebufferDefaultLayersEXT = 37650,

    [NativeName("GL_MAX_FRAMEBUFFER_LAYERS_EXT")]
    MaxFramebufferLayersEXT = 37655,

    [NativeName("GL_REFERENCED_BY_GEOMETRY_SHADER_EXT")]
    ReferencedByGeometryShaderEXT = 37641,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_DIVISOR_EXT")]
    VertexAttribArrayDivisorEXT = 35070,

    [NativeName("GL_COLOR_ATTACHMENT_EXT")]
    ColorAttachmentEXT = 37104,

    [NativeName("GL_MULTIVIEW_EXT")]
    MultiviewEXT = 37105,

    [NativeName("GL_DRAW_BUFFER_EXT")]
    DrawBufferEXT = 3073,

    [NativeName("GL_READ_BUFFER_EXT")]
    ReadBufferEXT = 3074,

    [NativeName("GL_MAX_MULTIVIEW_BUFFERS_EXT")]
    MaxMultiviewBuffersEXT = 37106,

    [NativeName("GL_ANY_SAMPLES_PASSED_EXT")]
    AnySamplesPassedEXT = 35887,

    [NativeName("GL_ANY_SAMPLES_PASSED_CONSERVATIVE_EXT")]
    AnySamplesPassedConservativeEXT = 36202,

    [NativeName("GL_PRIMITIVE_BOUNDING_BOX_EXT")]
    PrimitiveBoundingBoxEXT = 37566,

    [NativeName("GL_CONTEXT_FLAG_PROTECTED_CONTENT_BIT_EXT")]
    ContextFlagProtectedContentBitEXT = 16,

    [NativeName("GL_TEXTURE_PROTECTED_EXT")]
    TextureProtectedEXT = 35834,

    [NativeName("GL_COMPRESSED_SRGB_PVRTC_2BPPV1_EXT")]
    CompressedSrgbPvrtc2Bppv1EXT = 35412,

    [NativeName("GL_COMPRESSED_SRGB_PVRTC_4BPPV1_EXT")]
    CompressedSrgbPvrtc4Bppv1EXT = 35413,

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_PVRTC_2BPPV1_EXT")]
    CompressedSrgbAlphaPvrtc2Bppv1EXT = 35414,

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_PVRTC_4BPPV1_EXT")]
    CompressedSrgbAlphaPvrtc4Bppv1EXT = 35415,

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_PVRTC_2BPPV2_IMG")]
    CompressedSrgbAlphaPvrtc2Bppv2IMG = 37872,

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_PVRTC_4BPPV2_IMG")]
    CompressedSrgbAlphaPvrtc4Bppv2IMG = 37873,

    [NativeName("GL_R16_SNORM_EXT")]
    R16SnormEXT = 36760,

    [NativeName("GL_RG16_SNORM_EXT")]
    Rg16SnormEXT = 36761,

    [NativeName("GL_RGBA16_SNORM_EXT")]
    Rgba16SnormEXT = 36763,

    [NativeName("GL_VERTEX_SHADER_BIT_EXT")]
    VertexShaderBitEXT = 1,

    [NativeName("GL_FRAGMENT_SHADER_BIT_EXT")]
    FragmentShaderBitEXT = 2,

    [NativeName("GL_ALL_SHADER_BITS_EXT")]
    AllShaderBitsEXT = 4294967295,

    [NativeName("GL_PROGRAM_SEPARABLE_EXT")]
    ProgramSeparableEXT = 33368,

    [NativeName("GL_PROGRAM_PIPELINE_BINDING_EXT")]
    ProgramPipelineBindingEXT = 33370,

    [NativeName("GL_MAX_SHADER_PIXEL_LOCAL_STORAGE_FAST_SIZE_EXT")]
    MaxShaderPixelLocalStorageFastSizeEXT = 36707,

    [NativeName("GL_MAX_SHADER_PIXEL_LOCAL_STORAGE_SIZE_EXT")]
    MaxShaderPixelLocalStorageSizeEXT = 36711,

    [NativeName("GL_SHADER_PIXEL_LOCAL_STORAGE_EXT")]
    ShaderPixelLocalStorageEXT = 36708,

    [NativeName("GL_MAX_SHADER_COMBINED_LOCAL_STORAGE_FAST_SIZE_EXT")]
    MaxShaderCombinedLocalStorageFastSizeEXT = 38480,

    [NativeName("GL_MAX_SHADER_COMBINED_LOCAL_STORAGE_SIZE_EXT")]
    MaxShaderCombinedLocalStorageSizeEXT = 38481,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_INSUFFICIENT_SHADER_COMBINED_LOCAL_STORAGE_EXT")]
    FramebufferIncompleteInsufficientShaderCombinedLocalStorageEXT = 38482,

    [NativeName("GL_TEXTURE_COMPARE_MODE_EXT")]
    TextureCompareModeEXT = 34892,

    [NativeName("GL_TEXTURE_COMPARE_FUNC_EXT")]
    TextureCompareFuncEXT = 34893,

    [NativeName("GL_COMPARE_REF_TO_TEXTURE_EXT")]
    CompareRefToTextureEXT = 34894,

    [NativeName("GL_SAMPLER_2D_SHADOW_EXT")]
    Sampler2DShadowEXT = 35682,

    [NativeName("GL_TEXTURE_SPARSE_EXT")]
    TextureSparseEXT = 37286,

    [NativeName("GL_VIRTUAL_PAGE_SIZE_INDEX_EXT")]
    VirtualPageSizeIndexEXT = 37287,

    [NativeName("GL_NUM_SPARSE_LEVELS_EXT")]
    NumSparseLevelsEXT = 37290,

    [NativeName("GL_NUM_VIRTUAL_PAGE_SIZES_EXT")]
    NumVirtualPageSizesEXT = 37288,

    [NativeName("GL_VIRTUAL_PAGE_SIZE_X_EXT")]
    VirtualPageSizeXEXT = 37269,

    [NativeName("GL_VIRTUAL_PAGE_SIZE_Y_EXT")]
    VirtualPageSizeYEXT = 37270,

    [NativeName("GL_VIRTUAL_PAGE_SIZE_Z_EXT")]
    VirtualPageSizeZEXT = 37271,

    [NativeName("GL_MAX_SPARSE_TEXTURE_SIZE_EXT")]
    MaxSparseTextureSizeEXT = 37272,

    [NativeName("GL_MAX_SPARSE_3D_TEXTURE_SIZE_EXT")]
    MaxSparse3DTextureSizeEXT = 37273,

    [NativeName("GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS_EXT")]
    MaxSparseArrayTextureLayersEXT = 37274,

    [NativeName("GL_SPARSE_TEXTURE_FULL_ARRAY_CUBE_MIPMAPS_EXT")]
    SparseTextureFullArrayCubeMipmapsEXT = 37289,

    [NativeName("GL_PATCHES_EXT")]
    PatchesEXT = 14,

    [NativeName("GL_PATCH_VERTICES_EXT")]
    PatchVerticesEXT = 36466,

    [NativeName("GL_TESS_CONTROL_OUTPUT_VERTICES_EXT")]
    TessControlOutputVerticesEXT = 36469,

    [NativeName("GL_TESS_GEN_MODE_EXT")]
    TessGenModeEXT = 36470,

    [NativeName("GL_TESS_GEN_SPACING_EXT")]
    TessGenSpacingEXT = 36471,

    [NativeName("GL_TESS_GEN_VERTEX_ORDER_EXT")]
    TessGenVertexOrderEXT = 36472,

    [NativeName("GL_TESS_GEN_POINT_MODE_EXT")]
    TessGenPointModeEXT = 36473,

    [NativeName("GL_ISOLINES_EXT")]
    IsolinesEXT = 36474,

    [NativeName("GL_QUADS_EXT")]
    QuadsEXT = 7,

    [NativeName("GL_FRACTIONAL_ODD_EXT")]
    FractionalOddEXT = 36475,

    [NativeName("GL_FRACTIONAL_EVEN_EXT")]
    FractionalEvenEXT = 36476,

    [NativeName("GL_MAX_PATCH_VERTICES_EXT")]
    MaxPatchVerticesEXT = 36477,

    [NativeName("GL_MAX_TESS_GEN_LEVEL_EXT")]
    MaxTessGenLevelEXT = 36478,

    [NativeName("GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS_EXT")]
    MaxTessControlUniformComponentsEXT = 36479,

    [NativeName("GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS_EXT")]
    MaxTessEvaluationUniformComponentsEXT = 36480,

    [NativeName("GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS_EXT")]
    MaxTessControlTextureImageUnitsEXT = 36481,

    [NativeName("GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS_EXT")]
    MaxTessEvaluationTextureImageUnitsEXT = 36482,

    [NativeName("GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS_EXT")]
    MaxTessControlOutputComponentsEXT = 36483,

    [NativeName("GL_MAX_TESS_PATCH_COMPONENTS_EXT")]
    MaxTessPatchComponentsEXT = 36484,

    [NativeName("GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS_EXT")]
    MaxTessControlTotalOutputComponentsEXT = 36485,

    [NativeName("GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS_EXT")]
    MaxTessEvaluationOutputComponentsEXT = 36486,

    [NativeName("GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS_EXT")]
    MaxTessControlUniformBlocksEXT = 36489,

    [NativeName("GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS_EXT")]
    MaxTessEvaluationUniformBlocksEXT = 36490,

    [NativeName("GL_MAX_TESS_CONTROL_INPUT_COMPONENTS_EXT")]
    MaxTessControlInputComponentsEXT = 34924,

    [NativeName("GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS_EXT")]
    MaxTessEvaluationInputComponentsEXT = 34925,

    [NativeName("GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS_EXT")]
    MaxCombinedTessControlUniformComponentsEXT = 36382,

    [NativeName("GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS_EXT")]
    MaxCombinedTessEvaluationUniformComponentsEXT = 36383,

    [NativeName("GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS_EXT")]
    MaxTessControlAtomicCounterBuffersEXT = 37581,

    [NativeName("GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS_EXT")]
    MaxTessEvaluationAtomicCounterBuffersEXT = 37582,

    [NativeName("GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS_EXT")]
    MaxTessControlAtomicCountersEXT = 37587,

    [NativeName("GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS_EXT")]
    MaxTessEvaluationAtomicCountersEXT = 37588,

    [NativeName("GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS_EXT")]
    MaxTessControlImageUniformsEXT = 37067,

    [NativeName("GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS_EXT")]
    MaxTessEvaluationImageUniformsEXT = 37068,

    [NativeName("GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS_EXT")]
    MaxTessControlShaderStorageBlocksEXT = 37080,

    [NativeName("GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS_EXT")]
    MaxTessEvaluationShaderStorageBlocksEXT = 37081,

    [NativeName("GL_IS_PER_PATCH_EXT")]
    IsPerPatchEXT = 37607,

    [NativeName("GL_REFERENCED_BY_TESS_CONTROL_SHADER_EXT")]
    ReferencedByTessControlShaderEXT = 37639,

    [NativeName("GL_REFERENCED_BY_TESS_EVALUATION_SHADER_EXT")]
    ReferencedByTessEvaluationShaderEXT = 37640,

    [NativeName("GL_TESS_CONTROL_SHADER_EXT")]
    TessControlShaderEXT = 36488,

    [NativeName("GL_TESS_EVALUATION_SHADER_EXT")]
    TessEvaluationShaderEXT = 36487,

    [NativeName("GL_TESS_CONTROL_SHADER_BIT_EXT")]
    TessControlShaderBitEXT = 8,

    [NativeName("GL_TESS_EVALUATION_SHADER_BIT_EXT")]
    TessEvaluationShaderBitEXT = 16,

    [NativeName("GL_TEXTURE_BORDER_COLOR_EXT")]
    TextureBorderColorEXT = 4100,

    [NativeName("GL_CLAMP_TO_BORDER_EXT")]
    ClampToBorderEXT = 33069,

    [NativeName("GL_TEXTURE_BUFFER_BINDING_EXT")]
    TextureBufferBindingEXT = 35882,

    [NativeName("GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT_EXT")]
    TextureBufferOffsetAlignmentEXT = 37279,

    [NativeName("GL_TEXTURE_BUFFER_OFFSET_EXT")]
    TextureBufferOffsetEXT = 37277,

    [NativeName("GL_TEXTURE_BUFFER_SIZE_EXT")]
    TextureBufferSizeEXT = 37278,

    [NativeName("GL_TEXTURE_ASTC_DECODE_PRECISION_EXT")]
    TextureAstcDecodePrecisionEXT = 36713,

    [NativeName("GL_COMPRESSED_RGBA_BPTC_UNORM_EXT")]
    CompressedRgbaBptcUnormEXT = 36492,

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM_EXT")]
    CompressedSrgbAlphaBptcUnormEXT = 36493,

    [NativeName("GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT_EXT")]
    CompressedRgbBptcSignedFloatEXT = 36494,

    [NativeName("GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_EXT")]
    CompressedRgbBptcUnsignedFloatEXT = 36495,

    [NativeName("GL_TEXTURE_CUBE_MAP_ARRAY_EXT")]
    TextureCubeMapArrayEXT = 36873,

    [NativeName("GL_TEXTURE_BINDING_CUBE_MAP_ARRAY_EXT")]
    TextureBindingCubeMapArrayEXT = 36874,

    [NativeName("GL_SAMPLER_CUBE_MAP_ARRAY_EXT")]
    SamplerCubeMapArrayEXT = 36876,

    [NativeName("GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW_EXT")]
    SamplerCubeMapArrayShadowEXT = 36877,

    [NativeName("GL_INT_SAMPLER_CUBE_MAP_ARRAY_EXT")]
    IntSamplerCubeMapArrayEXT = 36878,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_EXT")]
    UnsignedIntSamplerCubeMapArrayEXT = 36879,

    [NativeName("GL_TEXTURE_FORMAT_SRGB_OVERRIDE_EXT")]
    TextureFormatSrgbOverrideEXT = 36799,

    [NativeName("GL_R16_EXT")]
    R16EXT = 33322,

    [NativeName("GL_RG16_EXT")]
    Rg16EXT = 33324,

    [NativeName("GL_RGB16_SNORM_EXT")]
    Rgb16SnormEXT = 36762,

    [NativeName("GL_RED_EXT")]
    RedEXT = 6403,

    [NativeName("GL_RG_EXT")]
    RgEXT = 33319,

    [NativeName("GL_NUM_SURFACE_COMPRESSION_FIXED_RATES_EXT")]
    NumSurfaceCompressionFixedRatesEXT = 36718,

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_1BPC_EXT")]
    SurfaceCompressionFixedRate1BpcEXT = 38596,

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_2BPC_EXT")]
    SurfaceCompressionFixedRate2BpcEXT = 38597,

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_3BPC_EXT")]
    SurfaceCompressionFixedRate3BpcEXT = 38598,

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_4BPC_EXT")]
    SurfaceCompressionFixedRate4BpcEXT = 38599,

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_5BPC_EXT")]
    SurfaceCompressionFixedRate5BpcEXT = 38600,

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_6BPC_EXT")]
    SurfaceCompressionFixedRate6BpcEXT = 38601,

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_7BPC_EXT")]
    SurfaceCompressionFixedRate7BpcEXT = 38602,

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_8BPC_EXT")]
    SurfaceCompressionFixedRate8BpcEXT = 38603,

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_9BPC_EXT")]
    SurfaceCompressionFixedRate9BpcEXT = 38604,

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_10BPC_EXT")]
    SurfaceCompressionFixedRate10BpcEXT = 38605,

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_11BPC_EXT")]
    SurfaceCompressionFixedRate11BpcEXT = 38606,

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_12BPC_EXT")]
    SurfaceCompressionFixedRate12BpcEXT = 38607,

    [NativeName("GL_UNSIGNED_INT_2_10_10_10_REV_EXT")]
    UnsignedInt2X10X10X10RevEXT = 33640,

    [NativeName("GL_TEXTURE_VIEW_MIN_LEVEL_EXT")]
    TextureViewMinLevelEXT = 33499,

    [NativeName("GL_TEXTURE_VIEW_NUM_LEVELS_EXT")]
    TextureViewNumLevelsEXT = 33500,

    [NativeName("GL_TEXTURE_VIEW_MIN_LAYER_EXT")]
    TextureViewMinLayerEXT = 33501,

    [NativeName("GL_TEXTURE_VIEW_NUM_LAYERS_EXT")]
    TextureViewNumLayersEXT = 33502,

    [NativeName("GL_UNPACK_ROW_LENGTH_EXT")]
    UnpackRowLengthEXT = 3314,

    [NativeName("GL_UNPACK_SKIP_ROWS_EXT")]
    UnpackSkipRowsEXT = 3315,

    [NativeName("GL_UNPACK_SKIP_PIXELS_EXT")]
    UnpackSkipPixelsEXT = 3316,

    [NativeName("GL_GCCSO_SHADER_BINARY_FJ")]
    GccsoShaderBinaryFJ = 37472,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_AND_DOWNSAMPLE_IMG")]
    FramebufferIncompleteMultisampleAndDownsampleIMG = 37180,

    [NativeName("GL_NUM_DOWNSAMPLE_SCALES_IMG")]
    NumDownsampleScalesIMG = 37181,

    [NativeName("GL_DOWNSAMPLE_SCALES_IMG")]
    DownsampleScalesIMG = 37182,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SCALE_IMG")]
    FramebufferAttachmentTextureScaleIMG = 37183,

    [NativeName("GL_SGX_PROGRAM_BINARY_IMG")]
    SgxProgramBinaryIMG = 37168,

    [NativeName("GL_SGX_BINARY_IMG")]
    SgxBinaryIMG = 35850,

    [NativeName("GL_COMPRESSED_RGBA_PVRTC_2BPPV2_IMG")]
    CompressedRgbaPvrtc2Bppv2IMG = 37175,

    [NativeName("GL_COMPRESSED_RGBA_PVRTC_4BPPV2_IMG")]
    CompressedRgbaPvrtc4Bppv2IMG = 37176,

    [NativeName("GL_CUBIC_IMG")]
    CubicIMG = 37177,

    [NativeName("GL_CUBIC_MIPMAP_NEAREST_IMG")]
    CubicMipmapNearestIMG = 37178,

    [NativeName("GL_CUBIC_MIPMAP_LINEAR_IMG")]
    CubicMipmapLinearIMG = 37179,

    [NativeName("GL_COPY_READ_BUFFER_NV")]
    CopyReadBufferNV = 36662,

    [NativeName("GL_COPY_WRITE_BUFFER_NV")]
    CopyWriteBufferNV = 36663,

    [NativeName("GL_COVERAGE_COMPONENT_NV")]
    CoverageComponentNV = 36560,

    [NativeName("GL_COVERAGE_COMPONENT4_NV")]
    CoverageComponent4NV = 36561,

    [NativeName("GL_COVERAGE_ATTACHMENT_NV")]
    CoverageAttachmentNV = 36562,

    [NativeName("GL_COVERAGE_BUFFERS_NV")]
    CoverageBuffersNV = 36563,

    [NativeName("GL_COVERAGE_SAMPLES_NV")]
    CoverageSamplesNV = 36564,

    [NativeName("GL_COVERAGE_ALL_FRAGMENTS_NV")]
    CoverageAllFragmentsNV = 36565,

    [NativeName("GL_COVERAGE_EDGE_FRAGMENTS_NV")]
    CoverageEdgeFragmentsNV = 36566,

    [NativeName("GL_COVERAGE_AUTOMATIC_NV")]
    CoverageAutomaticNV = 36567,

    [NativeName("GL_COVERAGE_BUFFER_BIT_NV")]
    CoverageBufferBitNV = 32768,

    [NativeName("GL_DEPTH_COMPONENT16_NONLINEAR_NV")]
    DepthComponent16NonlinearNV = 36396,

    [NativeName("GL_MAX_DRAW_BUFFERS_NV")]
    MaxDrawBuffersNV = 34852,

    [NativeName("GL_DRAW_BUFFER0_NV")]
    DrawBuffer0NV = 34853,

    [NativeName("GL_DRAW_BUFFER1_NV")]
    DrawBuffer1NV = 34854,

    [NativeName("GL_DRAW_BUFFER2_NV")]
    DrawBuffer2NV = 34855,

    [NativeName("GL_DRAW_BUFFER3_NV")]
    DrawBuffer3NV = 34856,

    [NativeName("GL_DRAW_BUFFER4_NV")]
    DrawBuffer4NV = 34857,

    [NativeName("GL_DRAW_BUFFER5_NV")]
    DrawBuffer5NV = 34858,

    [NativeName("GL_DRAW_BUFFER6_NV")]
    DrawBuffer6NV = 34859,

    [NativeName("GL_DRAW_BUFFER7_NV")]
    DrawBuffer7NV = 34860,

    [NativeName("GL_DRAW_BUFFER8_NV")]
    DrawBuffer8NV = 34861,

    [NativeName("GL_DRAW_BUFFER9_NV")]
    DrawBuffer9NV = 34862,

    [NativeName("GL_DRAW_BUFFER10_NV")]
    DrawBuffer10NV = 34863,

    [NativeName("GL_DRAW_BUFFER11_NV")]
    DrawBuffer11NV = 34864,

    [NativeName("GL_DRAW_BUFFER12_NV")]
    DrawBuffer12NV = 34865,

    [NativeName("GL_DRAW_BUFFER13_NV")]
    DrawBuffer13NV = 34866,

    [NativeName("GL_DRAW_BUFFER14_NV")]
    DrawBuffer14NV = 34867,

    [NativeName("GL_DRAW_BUFFER15_NV")]
    DrawBuffer15NV = 34868,

    [NativeName("GL_COLOR_ATTACHMENT0_NV")]
    ColorAttachment0NV = 36064,

    [NativeName("GL_COLOR_ATTACHMENT1_NV")]
    ColorAttachment1NV = 36065,

    [NativeName("GL_COLOR_ATTACHMENT2_NV")]
    ColorAttachment2NV = 36066,

    [NativeName("GL_COLOR_ATTACHMENT3_NV")]
    ColorAttachment3NV = 36067,

    [NativeName("GL_COLOR_ATTACHMENT4_NV")]
    ColorAttachment4NV = 36068,

    [NativeName("GL_COLOR_ATTACHMENT5_NV")]
    ColorAttachment5NV = 36069,

    [NativeName("GL_COLOR_ATTACHMENT6_NV")]
    ColorAttachment6NV = 36070,

    [NativeName("GL_COLOR_ATTACHMENT7_NV")]
    ColorAttachment7NV = 36071,

    [NativeName("GL_COLOR_ATTACHMENT8_NV")]
    ColorAttachment8NV = 36072,

    [NativeName("GL_COLOR_ATTACHMENT9_NV")]
    ColorAttachment9NV = 36073,

    [NativeName("GL_COLOR_ATTACHMENT10_NV")]
    ColorAttachment10NV = 36074,

    [NativeName("GL_COLOR_ATTACHMENT11_NV")]
    ColorAttachment11NV = 36075,

    [NativeName("GL_COLOR_ATTACHMENT12_NV")]
    ColorAttachment12NV = 36076,

    [NativeName("GL_COLOR_ATTACHMENT13_NV")]
    ColorAttachment13NV = 36077,

    [NativeName("GL_COLOR_ATTACHMENT14_NV")]
    ColorAttachment14NV = 36078,

    [NativeName("GL_COLOR_ATTACHMENT15_NV")]
    ColorAttachment15NV = 36079,

    [NativeName("GL_MAX_COLOR_ATTACHMENTS_NV")]
    MaxColorAttachmentsNV = 36063,

    [NativeName("GL_READ_FRAMEBUFFER_NV")]
    ReadFramebufferNV = 36008,

    [NativeName("GL_DRAW_FRAMEBUFFER_NV")]
    DrawFramebufferNV = 36009,

    [NativeName("GL_DRAW_FRAMEBUFFER_BINDING_NV")]
    DrawFramebufferBindingNV = 36006,

    [NativeName("GL_READ_FRAMEBUFFER_BINDING_NV")]
    ReadFramebufferBindingNV = 36010,

    [NativeName("GL_RENDERBUFFER_SAMPLES_NV")]
    RenderbufferSamplesNV = 36011,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_NV")]
    FramebufferIncompleteMultisampleNV = 36182,

    [NativeName("GL_MAX_SAMPLES_NV")]
    MaxSamplesNV = 36183,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_DIVISOR_NV")]
    VertexAttribArrayDivisorNV = 35070,

    [NativeName("GL_FLOAT_MAT2x3_NV")]
    FloatMat2X3NV = 35685,

    [NativeName("GL_FLOAT_MAT2x4_NV")]
    FloatMat2X4NV = 35686,

    [NativeName("GL_FLOAT_MAT3x2_NV")]
    FloatMat3X2NV = 35687,

    [NativeName("GL_FLOAT_MAT3x4_NV")]
    FloatMat3X4NV = 35688,

    [NativeName("GL_FLOAT_MAT4x2_NV")]
    FloatMat4X2NV = 35689,

    [NativeName("GL_FLOAT_MAT4x3_NV")]
    FloatMat4X3NV = 35690,

    [NativeName("GL_PACK_ROW_LENGTH_NV")]
    PackRowLengthNV = 3330,

    [NativeName("GL_PACK_SKIP_ROWS_NV")]
    PackSkipRowsNV = 3331,

    [NativeName("GL_PACK_SKIP_PIXELS_NV")]
    PackSkipPixelsNV = 3332,

    [NativeName("GL_PIXEL_PACK_BUFFER_NV")]
    PixelPackBufferNV = 35051,

    [NativeName("GL_PIXEL_UNPACK_BUFFER_NV")]
    PixelUnpackBufferNV = 35052,

    [NativeName("GL_PIXEL_PACK_BUFFER_BINDING_NV")]
    PixelPackBufferBindingNV = 35053,

    [NativeName("GL_PIXEL_UNPACK_BUFFER_BINDING_NV")]
    PixelUnpackBufferBindingNV = 35055,

    [NativeName("GL_POLYGON_MODE_NV")]
    PolygonModeNV = 2880,

    [NativeName("GL_POLYGON_OFFSET_POINT_NV")]
    PolygonOffsetPointNV = 10753,

    [NativeName("GL_POLYGON_OFFSET_LINE_NV")]
    PolygonOffsetLineNV = 10754,

    [NativeName("GL_POINT_NV")]
    PointNV = 6912,

    [NativeName("GL_LINE_NV")]
    LineNV = 6913,

    [NativeName("GL_FILL_NV")]
    FillNV = 6914,

    [NativeName("GL_READ_BUFFER_NV")]
    ReadBufferNV = 3074,

    [NativeName("GL_SLUMINANCE_NV")]
    SluminanceNV = 35910,

    [NativeName("GL_SLUMINANCE_ALPHA_NV")]
    SluminanceAlphaNV = 35908,

    [NativeName("GL_SRGB8_NV")]
    Srgb8NV = 35905,

    [NativeName("GL_SLUMINANCE8_NV")]
    Sluminance8NV = 35911,

    [NativeName("GL_SLUMINANCE8_ALPHA8_NV")]
    Sluminance8Alpha8NV = 35909,

    [NativeName("GL_COMPRESSED_SRGB_S3TC_DXT1_NV")]
    CompressedSrgbS3TcDxt1NV = 35916,

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_NV")]
    CompressedSrgbAlphaS3TcDxt1NV = 35917,

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_NV")]
    CompressedSrgbAlphaS3TcDxt3NV = 35918,

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_NV")]
    CompressedSrgbAlphaS3TcDxt5NV = 35919,

    [NativeName("GL_ETC1_SRGB8_NV")]
    Etc1Srgb8NV = 35054,

    [NativeName("GL_SAMPLER_2D_ARRAY_SHADOW_NV")]
    Sampler2DArrayShadowNV = 36292,

    [NativeName("GL_SAMPLER_CUBE_SHADOW_NV")]
    SamplerCubeShadowNV = 36293,

    [NativeName("GL_TEXTURE_BORDER_COLOR_NV")]
    TextureBorderColorNV = 4100,

    [NativeName("GL_CLAMP_TO_BORDER_NV")]
    ClampToBorderNV = 33069,

    [NativeName("GL_MAX_VIEWPORTS_NV")]
    MaxViewportsNV = 33371,

    [NativeName("GL_VIEWPORT_SUBPIXEL_BITS_NV")]
    ViewportSubpixelBitsNV = 33372,

    [NativeName("GL_VIEWPORT_BOUNDS_RANGE_NV")]
    ViewportBoundsRangeNV = 33373,

    [NativeName("GL_VIEWPORT_INDEX_PROVOKING_VERTEX_NV")]
    ViewportIndexProvokingVertexNV = 33375,

    [NativeName("GL_ALPHA_TEST_QCOM")]
    AlphaTestQCOM = 3008,

    [NativeName("GL_ALPHA_TEST_FUNC_QCOM")]
    AlphaTestFuncQCOM = 3009,

    [NativeName("GL_ALPHA_TEST_REF_QCOM")]
    AlphaTestRefQCOM = 3010,

    [NativeName("GL_BINNING_CONTROL_HINT_QCOM")]
    BinningControlHintQCOM = 36784,

    [NativeName("GL_CPU_OPTIMIZED_QCOM")]
    CpuOptimizedQCOM = 36785,

    [NativeName("GL_GPU_OPTIMIZED_QCOM")]
    GpuOptimizedQCOM = 36786,

    [NativeName("GL_RENDER_DIRECT_TO_FRAMEBUFFER_QCOM")]
    RenderDirectToFramebufferQCOM = 36787,

    [NativeName("GL_FOVEATION_ENABLE_BIT_QCOM")]
    FoveationEnableBitQCOM = 1,

    [NativeName("GL_FOVEATION_SCALED_BIN_METHOD_BIT_QCOM")]
    FoveationScaledBinMethodBitQCOM = 2,

    [NativeName("GL_MOTION_ESTIMATION_SEARCH_BLOCK_X_QCOM")]
    MotionEstimationSearchBlockXQCOM = 35984,

    [NativeName("GL_MOTION_ESTIMATION_SEARCH_BLOCK_Y_QCOM")]
    MotionEstimationSearchBlockYQCOM = 35985,

    [NativeName("GL_FRAMEBUFFER_FETCH_NONCOHERENT_QCOM")]
    FramebufferFetchNoncoherentQCOM = 38562,

    [NativeName("GL_SHADING_RATE_QCOM")]
    ShadingRateQCOM = 38564,

    [NativeName("GL_SHADING_RATE_PRESERVE_ASPECT_RATIO_QCOM")]
    ShadingRatePreserveAspectRatioQCOM = 38565,

    [NativeName("GL_SHADING_RATE_1X1_PIXELS_QCOM")]
    ShadingRate1X1PixelsQCOM = 38566,

    [NativeName("GL_SHADING_RATE_1X2_PIXELS_QCOM")]
    ShadingRate1X2PixelsQCOM = 38567,

    [NativeName("GL_SHADING_RATE_2X1_PIXELS_QCOM")]
    ShadingRate2X1PixelsQCOM = 38568,

    [NativeName("GL_SHADING_RATE_2X2_PIXELS_QCOM")]
    ShadingRate2X2PixelsQCOM = 38569,

    [NativeName("GL_SHADING_RATE_4X2_PIXELS_QCOM")]
    ShadingRate4X2PixelsQCOM = 38572,

    [NativeName("GL_SHADING_RATE_4X4_PIXELS_QCOM")]
    ShadingRate4X4PixelsQCOM = 38574,

    [NativeName("GL_TEXTURE_FOVEATED_FEATURE_BITS_QCOM")]
    TextureFoveatedFeatureBitsQCOM = 35835,

    [NativeName("GL_TEXTURE_FOVEATED_MIN_PIXEL_DENSITY_QCOM")]
    TextureFoveatedMinPixelDensityQCOM = 35836,

    [NativeName("GL_TEXTURE_FOVEATED_FEATURE_QUERY_QCOM")]
    TextureFoveatedFeatureQueryQCOM = 35837,

    [NativeName("GL_TEXTURE_FOVEATED_NUM_FOCAL_POINTS_QUERY_QCOM")]
    TextureFoveatedNumFocalPointsQueryQCOM = 35838,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_FOVEATION_QCOM")]
    FramebufferIncompleteFoveationQCOM = 35839,

    [NativeName("GL_TEXTURE_FOVEATED_CUTOFF_DENSITY_QCOM")]
    TextureFoveatedCutoffDensityQCOM = 38560,

    [NativeName("GL_FOVEATION_SUBSAMPLED_LAYOUT_METHOD_BIT_QCOM")]
    FoveationSubsampledLayoutMethodBitQCOM = 4,

    [NativeName("GL_MAX_SHADER_SUBSAMPLED_IMAGE_UNITS_QCOM")]
    MaxShaderSubsampledImageUnitsQCOM = 36769,

    [NativeName("GL_TEXTURE_LOD_BIAS_QCOM")]
    TextureLodBiasQCOM = 35990,

    [NativeName("GL_SHADER_BINARY_VIV")]
    ShaderBinaryVIV = 36804,
}
