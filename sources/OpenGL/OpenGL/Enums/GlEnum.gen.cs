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
    VersionEsCl1X0 = unchecked((uint)1),

    [NativeName("GL_VERSION_ES_CM_1_1")]
    VersionEsCm1X1 = unchecked((uint)1),

    [NativeName("GL_VERSION_ES_CL_1_1")]
    VersionEsCl1X1 = unchecked((uint)1),

    [NativeName("GL_DEPTH_BUFFER_BIT")]
    DepthBufferBit = unchecked((uint)0x00000100),

    [NativeName("GL_STENCIL_BUFFER_BIT")]
    StencilBufferBit = unchecked((uint)0x00000400),

    [NativeName("GL_COLOR_BUFFER_BIT")]
    ColorBufferBit = unchecked((uint)0x00004000),

    [NativeName("GL_FALSE")]
    False = unchecked((uint)0),

    [NativeName("GL_TRUE")]
    True = unchecked((uint)1),

    [NativeName("GL_POINTS")]
    Points = unchecked((uint)0x0000),

    [NativeName("GL_LINES")]
    Lines = unchecked((uint)0x0001),

    [NativeName("GL_LINE_LOOP")]
    LineLoop = unchecked((uint)0x0002),

    [NativeName("GL_LINE_STRIP")]
    LineStrip = unchecked((uint)0x0003),

    [NativeName("GL_TRIANGLES")]
    Triangles = unchecked((uint)0x0004),

    [NativeName("GL_TRIANGLE_STRIP")]
    TriangleStrip = unchecked((uint)0x0005),

    [NativeName("GL_TRIANGLE_FAN")]
    TriangleFan = unchecked((uint)0x0006),

    [NativeName("GL_NEVER")]
    Never = unchecked((uint)0x0200),

    [NativeName("GL_LESS")]
    Less = unchecked((uint)0x0201),

    [NativeName("GL_EQUAL")]
    Equal = unchecked((uint)0x0202),

    [NativeName("GL_LEQUAL")]
    Lequal = unchecked((uint)0x0203),

    [NativeName("GL_GREATER")]
    Greater = unchecked((uint)0x0204),

    [NativeName("GL_NOTEQUAL")]
    Notequal = unchecked((uint)0x0205),

    [NativeName("GL_GEQUAL")]
    Gequal = unchecked((uint)0x0206),

    [NativeName("GL_ALWAYS")]
    Always = unchecked((uint)0x0207),

    [NativeName("GL_ZERO")]
    Zero = unchecked((uint)0),

    [NativeName("GL_ONE")]
    One = unchecked((uint)1),

    [NativeName("GL_SRC_COLOR")]
    SrcColor = unchecked((uint)0x0300),

    [NativeName("GL_ONE_MINUS_SRC_COLOR")]
    OneMinusSrcColor = unchecked((uint)0x0301),

    [NativeName("GL_SRC_ALPHA")]
    SrcAlpha = unchecked((uint)0x0302),

    [NativeName("GL_ONE_MINUS_SRC_ALPHA")]
    OneMinusSrcAlpha = unchecked((uint)0x0303),

    [NativeName("GL_DST_ALPHA")]
    DstAlpha = unchecked((uint)0x0304),

    [NativeName("GL_ONE_MINUS_DST_ALPHA")]
    OneMinusDstAlpha = unchecked((uint)0x0305),

    [NativeName("GL_DST_COLOR")]
    DstColor = unchecked((uint)0x0306),

    [NativeName("GL_ONE_MINUS_DST_COLOR")]
    OneMinusDstColor = unchecked((uint)0x0307),

    [NativeName("GL_SRC_ALPHA_SATURATE")]
    SrcAlphaSaturate = unchecked((uint)0x0308),

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

    [NativeName("GL_FRONT")]
    Front = unchecked((uint)0x0404),

    [NativeName("GL_BACK")]
    Back = unchecked((uint)0x0405),

    [NativeName("GL_FRONT_AND_BACK")]
    FrontAndBack = unchecked((uint)0x0408),

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

    [NativeName("GL_RESCALE_NORMAL")]
    RescaleNormal = unchecked((uint)0x803A),

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

    [NativeName("GL_NO_ERROR")]
    NoError = unchecked((uint)0),

    [NativeName("GL_INVALID_ENUM")]
    InvalidEnum = unchecked((uint)0x0500),

    [NativeName("GL_INVALID_VALUE")]
    InvalidValue = unchecked((uint)0x0501),

    [NativeName("GL_INVALID_OPERATION")]
    InvalidOperation = unchecked((uint)0x0502),

    [NativeName("GL_STACK_OVERFLOW")]
    StackOverflow = unchecked((uint)0x0503),

    [NativeName("GL_STACK_UNDERFLOW")]
    StackUnderflow = unchecked((uint)0x0504),

    [NativeName("GL_OUT_OF_MEMORY")]
    OutOfMemory = unchecked((uint)0x0505),

    [NativeName("GL_EXP")]
    Exp = unchecked((uint)0x0800),

    [NativeName("GL_EXP2")]
    Exp2 = unchecked((uint)0x0801),

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

    [NativeName("GL_CW")]
    Cw = unchecked((uint)0x0900),

    [NativeName("GL_CCW")]
    Ccw = unchecked((uint)0x0901),

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

    [NativeName("GL_MAX_TEXTURE_UNITS")]
    MaxTextureUnits = unchecked((uint)0x84E2),

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

    [NativeName("GL_VERTEX_ARRAY_POINTER")]
    VertexArrayPointer = unchecked((uint)0x808E),

    [NativeName("GL_NORMAL_ARRAY_POINTER")]
    NormalArrayPointer = unchecked((uint)0x808F),

    [NativeName("GL_COLOR_ARRAY_POINTER")]
    ColorArrayPointer = unchecked((uint)0x8090),

    [NativeName("GL_TEXTURE_COORD_ARRAY_POINTER")]
    TextureCoordArrayPointer = unchecked((uint)0x8092),

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

    [NativeName("GL_DONT_CARE")]
    DontCare = unchecked((uint)0x1100),

    [NativeName("GL_FASTEST")]
    Fastest = unchecked((uint)0x1101),

    [NativeName("GL_NICEST")]
    Nicest = unchecked((uint)0x1102),

    [NativeName("GL_PERSPECTIVE_CORRECTION_HINT")]
    PerspectiveCorrectionHint = unchecked((uint)0x0C50),

    [NativeName("GL_POINT_SMOOTH_HINT")]
    PointSmoothHint = unchecked((uint)0x0C51),

    [NativeName("GL_LINE_SMOOTH_HINT")]
    LineSmoothHint = unchecked((uint)0x0C52),

    [NativeName("GL_FOG_HINT")]
    FogHint = unchecked((uint)0x0C54),

    [NativeName("GL_GENERATE_MIPMAP_HINT")]
    GenerateMipmapHint = unchecked((uint)0x8192),

    [NativeName("GL_LIGHT_MODEL_AMBIENT")]
    LightModelAmbient = unchecked((uint)0x0B53),

    [NativeName("GL_LIGHT_MODEL_TWO_SIDE")]
    LightModelTwoSide = unchecked((uint)0x0B52),

    [NativeName("GL_AMBIENT")]
    Ambient = unchecked((uint)0x1200),

    [NativeName("GL_DIFFUSE")]
    Diffuse = unchecked((uint)0x1201),

    [NativeName("GL_SPECULAR")]
    Specular = unchecked((uint)0x1202),

    [NativeName("GL_POSITION")]
    Position = unchecked((uint)0x1203),

    [NativeName("GL_SPOT_DIRECTION")]
    SpotDirection = unchecked((uint)0x1204),

    [NativeName("GL_SPOT_EXPONENT")]
    SpotExponent = unchecked((uint)0x1205),

    [NativeName("GL_SPOT_CUTOFF")]
    SpotCutoff = unchecked((uint)0x1206),

    [NativeName("GL_CONSTANT_ATTENUATION")]
    ConstantAttenuation = unchecked((uint)0x1207),

    [NativeName("GL_LINEAR_ATTENUATION")]
    LinearAttenuation = unchecked((uint)0x1208),

    [NativeName("GL_QUADRATIC_ATTENUATION")]
    QuadraticAttenuation = unchecked((uint)0x1209),

    [NativeName("GL_BYTE")]
    Byte = unchecked((uint)0x1400),

    [NativeName("GL_UNSIGNED_BYTE")]
    UnsignedByte = unchecked((uint)0x1401),

    [NativeName("GL_SHORT")]
    Short = unchecked((uint)0x1402),

    [NativeName("GL_UNSIGNED_SHORT")]
    UnsignedShort = unchecked((uint)0x1403),

    [NativeName("GL_FLOAT")]
    Float = unchecked((uint)0x1406),

    [NativeName("GL_FIXED")]
    Fixed = unchecked((uint)0x140C),

    [NativeName("GL_CLEAR")]
    Clear = unchecked((uint)0x1500),

    [NativeName("GL_AND")]
    And = unchecked((uint)0x1501),

    [NativeName("GL_AND_REVERSE")]
    AndReverse = unchecked((uint)0x1502),

    [NativeName("GL_COPY")]
    Copy = unchecked((uint)0x1503),

    [NativeName("GL_AND_INVERTED")]
    AndInverted = unchecked((uint)0x1504),

    [NativeName("GL_NOOP")]
    Noop = unchecked((uint)0x1505),

    [NativeName("GL_XOR")]
    Xor = unchecked((uint)0x1506),

    [NativeName("GL_OR")]
    Or = unchecked((uint)0x1507),

    [NativeName("GL_NOR")]
    Nor = unchecked((uint)0x1508),

    [NativeName("GL_EQUIV")]
    Equiv = unchecked((uint)0x1509),

    [NativeName("GL_INVERT")]
    Invert = unchecked((uint)0x150A),

    [NativeName("GL_OR_REVERSE")]
    OrReverse = unchecked((uint)0x150B),

    [NativeName("GL_COPY_INVERTED")]
    CopyInverted = unchecked((uint)0x150C),

    [NativeName("GL_OR_INVERTED")]
    OrInverted = unchecked((uint)0x150D),

    [NativeName("GL_NAND")]
    Nand = unchecked((uint)0x150E),

    [NativeName("GL_SET")]
    Set = unchecked((uint)0x150F),

    [NativeName("GL_EMISSION")]
    Emission = unchecked((uint)0x1600),

    [NativeName("GL_SHININESS")]
    Shininess = unchecked((uint)0x1601),

    [NativeName("GL_AMBIENT_AND_DIFFUSE")]
    AmbientAndDiffuse = unchecked((uint)0x1602),

    [NativeName("GL_MODELVIEW")]
    Modelview = unchecked((uint)0x1700),

    [NativeName("GL_PROJECTION")]
    Projection = unchecked((uint)0x1701),

    [NativeName("GL_TEXTURE")]
    Texture = unchecked((uint)0x1702),

    [NativeName("GL_ALPHA")]
    Alpha = unchecked((uint)0x1906),

    [NativeName("GL_RGB")]
    Rgb = unchecked((uint)0x1907),

    [NativeName("GL_RGBA")]
    Rgba = unchecked((uint)0x1908),

    [NativeName("GL_LUMINANCE")]
    Luminance = unchecked((uint)0x1909),

    [NativeName("GL_LUMINANCE_ALPHA")]
    LuminanceAlpha = unchecked((uint)0x190A),

    [NativeName("GL_UNPACK_ALIGNMENT")]
    UnpackAlignment = unchecked((uint)0x0CF5),

    [NativeName("GL_PACK_ALIGNMENT")]
    PackAlignment = unchecked((uint)0x0D05),

    [NativeName("GL_UNSIGNED_SHORT_4_4_4_4")]
    UnsignedShort4X4X4X4 = unchecked((uint)0x8033),

    [NativeName("GL_UNSIGNED_SHORT_5_5_5_1")]
    UnsignedShort5X5X5X1 = unchecked((uint)0x8034),

    [NativeName("GL_UNSIGNED_SHORT_5_6_5")]
    UnsignedShort5X6X5 = unchecked((uint)0x8363),

    [NativeName("GL_FLAT")]
    Flat = unchecked((uint)0x1D00),

    [NativeName("GL_SMOOTH")]
    Smooth = unchecked((uint)0x1D01),

    [NativeName("GL_KEEP")]
    Keep = unchecked((uint)0x1E00),

    [NativeName("GL_REPLACE")]
    Replace = unchecked((uint)0x1E01),

    [NativeName("GL_INCR")]
    Incr = unchecked((uint)0x1E02),

    [NativeName("GL_DECR")]
    Decr = unchecked((uint)0x1E03),

    [NativeName("GL_VENDOR")]
    Vendor = unchecked((uint)0x1F00),

    [NativeName("GL_RENDERER")]
    Renderer = unchecked((uint)0x1F01),

    [NativeName("GL_VERSION")]
    Version = unchecked((uint)0x1F02),

    [NativeName("GL_EXTENSIONS")]
    Extensions = unchecked((uint)0x1F03),

    [NativeName("GL_MODULATE")]
    Modulate = unchecked((uint)0x2100),

    [NativeName("GL_DECAL")]
    Decal = unchecked((uint)0x2101),

    [NativeName("GL_ADD")]
    Add = unchecked((uint)0x0104),

    [NativeName("GL_TEXTURE_ENV_MODE")]
    TextureEnvMode = unchecked((uint)0x2200),

    [NativeName("GL_TEXTURE_ENV_COLOR")]
    TextureEnvColor = unchecked((uint)0x2201),

    [NativeName("GL_TEXTURE_ENV")]
    TextureENV = unchecked((uint)0x2300),

    [NativeName("GL_NEAREST")]
    Nearest = unchecked((uint)0x2600),

    [NativeName("GL_LINEAR")]
    Linear = unchecked((uint)0x2601),

    [NativeName("GL_NEAREST_MIPMAP_NEAREST")]
    NearestMipmapNearest = unchecked((uint)0x2700),

    [NativeName("GL_LINEAR_MIPMAP_NEAREST")]
    LinearMipmapNearest = unchecked((uint)0x2701),

    [NativeName("GL_NEAREST_MIPMAP_LINEAR")]
    NearestMipmapLinear = unchecked((uint)0x2702),

    [NativeName("GL_LINEAR_MIPMAP_LINEAR")]
    LinearMipmapLinear = unchecked((uint)0x2703),

    [NativeName("GL_TEXTURE_MAG_FILTER")]
    TextureMagFilter = unchecked((uint)0x2800),

    [NativeName("GL_TEXTURE_MIN_FILTER")]
    TextureMinFilter = unchecked((uint)0x2801),

    [NativeName("GL_TEXTURE_WRAP_S")]
    TextureWrapS = unchecked((uint)0x2802),

    [NativeName("GL_TEXTURE_WRAP")]
    TextureWrap = unchecked((uint)0x2803),

    [NativeName("GL_GENERATE_MIPMAP")]
    GenerateMipmap = unchecked((uint)0x8191),

    [NativeName("GL_TEXTURE0")]
    Texture0 = unchecked((uint)0x84C0),

    [NativeName("GL_TEXTURE1")]
    Texture1 = unchecked((uint)0x84C1),

    [NativeName("GL_TEXTURE2")]
    Texture2 = unchecked((uint)0x84C2),

    [NativeName("GL_TEXTURE3")]
    Texture3 = unchecked((uint)0x84C3),

    [NativeName("GL_TEXTURE4")]
    Texture4 = unchecked((uint)0x84C4),

    [NativeName("GL_TEXTURE5")]
    Texture5 = unchecked((uint)0x84C5),

    [NativeName("GL_TEXTURE6")]
    Texture6 = unchecked((uint)0x84C6),

    [NativeName("GL_TEXTURE7")]
    Texture7 = unchecked((uint)0x84C7),

    [NativeName("GL_TEXTURE8")]
    Texture8 = unchecked((uint)0x84C8),

    [NativeName("GL_TEXTURE9")]
    Texture9 = unchecked((uint)0x84C9),

    [NativeName("GL_TEXTURE10")]
    Texture10 = unchecked((uint)0x84CA),

    [NativeName("GL_TEXTURE11")]
    Texture11 = unchecked((uint)0x84CB),

    [NativeName("GL_TEXTURE12")]
    Texture12 = unchecked((uint)0x84CC),

    [NativeName("GL_TEXTURE13")]
    Texture13 = unchecked((uint)0x84CD),

    [NativeName("GL_TEXTURE14")]
    Texture14 = unchecked((uint)0x84CE),

    [NativeName("GL_TEXTURE15")]
    Texture15 = unchecked((uint)0x84CF),

    [NativeName("GL_TEXTURE16")]
    Texture16 = unchecked((uint)0x84D0),

    [NativeName("GL_TEXTURE17")]
    Texture17 = unchecked((uint)0x84D1),

    [NativeName("GL_TEXTURE18")]
    Texture18 = unchecked((uint)0x84D2),

    [NativeName("GL_TEXTURE19")]
    Texture19 = unchecked((uint)0x84D3),

    [NativeName("GL_TEXTURE20")]
    Texture20 = unchecked((uint)0x84D4),

    [NativeName("GL_TEXTURE21")]
    Texture21 = unchecked((uint)0x84D5),

    [NativeName("GL_TEXTURE22")]
    Texture22 = unchecked((uint)0x84D6),

    [NativeName("GL_TEXTURE23")]
    Texture23 = unchecked((uint)0x84D7),

    [NativeName("GL_TEXTURE24")]
    Texture24 = unchecked((uint)0x84D8),

    [NativeName("GL_TEXTURE25")]
    Texture25 = unchecked((uint)0x84D9),

    [NativeName("GL_TEXTURE26")]
    Texture26 = unchecked((uint)0x84DA),

    [NativeName("GL_TEXTURE27")]
    Texture27 = unchecked((uint)0x84DB),

    [NativeName("GL_TEXTURE28")]
    Texture28 = unchecked((uint)0x84DC),

    [NativeName("GL_TEXTURE29")]
    Texture29 = unchecked((uint)0x84DD),

    [NativeName("GL_TEXTURE30")]
    Texture30 = unchecked((uint)0x84DE),

    [NativeName("GL_TEXTURE31")]
    Texture31 = unchecked((uint)0x84DF),

    [NativeName("GL_ACTIVE_TEXTURE")]
    ActiveTexture = unchecked((uint)0x84E0),

    [NativeName("GL_CLIENT_ACTIVE_TEXTURE")]
    ClientActiveTexture = unchecked((uint)0x84E1),

    [NativeName("GL_REPEAT")]
    Repeat = unchecked((uint)0x2901),

    [NativeName("GL_CLAMP_TO_EDGE")]
    ClampToEdge = unchecked((uint)0x812F),

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

    [NativeName("GL_ARRAY_BUFFER")]
    ArrayBuffer = unchecked((uint)0x8892),

    [NativeName("GL_ELEMENT_ARRAY_BUFFER")]
    ElementArrayBuffer = unchecked((uint)0x8893),

    [NativeName("GL_ARRAY_BUFFER_BINDING")]
    ArrayBufferBinding = unchecked((uint)0x8894),

    [NativeName("GL_ELEMENT_ARRAY_BUFFER_BINDING")]
    ElementArrayBufferBinding = unchecked((uint)0x8895),

    [NativeName("GL_VERTEX_ARRAY_BUFFER_BINDING")]
    VertexArrayBufferBinding = unchecked((uint)0x8896),

    [NativeName("GL_NORMAL_ARRAY_BUFFER_BINDING")]
    NormalArrayBufferBinding = unchecked((uint)0x8897),

    [NativeName("GL_COLOR_ARRAY_BUFFER_BINDING")]
    ColorArrayBufferBinding = unchecked((uint)0x8898),

    [NativeName("GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING")]
    TextureCoordArrayBufferBinding = unchecked((uint)0x889A),

    [NativeName("GL_STATIC_DRAW")]
    StaticDraw = unchecked((uint)0x88E4),

    [NativeName("GL_DYNAMIC_DRAW")]
    DynamicDraw = unchecked((uint)0x88E8),

    [NativeName("GL_BUFFER_SIZE")]
    BufferSize = unchecked((uint)0x8764),

    [NativeName("GL_BUFFER_USAGE")]
    BufferUsage = unchecked((uint)0x8765),

    [NativeName("GL_SUBTRACT")]
    Subtract = unchecked((uint)0x84E7),

    [NativeName("GL_COMBINE")]
    Combine = unchecked((uint)0x8570),

    [NativeName("GL_COMBINE_RGB")]
    CombineRgb = unchecked((uint)0x8571),

    [NativeName("GL_COMBINE_ALPHA")]
    CombineAlpha = unchecked((uint)0x8572),

    [NativeName("GL_RGB_SCALE")]
    RgbScale = unchecked((uint)0x8573),

    [NativeName("GL_ADD_SIGNED")]
    AddSigned = unchecked((uint)0x8574),

    [NativeName("GL_INTERPOLATE")]
    Interpolate = unchecked((uint)0x8575),

    [NativeName("GL_CONSTANT")]
    Constant = unchecked((uint)0x8576),

    [NativeName("GL_PRIMARY_COLOR")]
    PrimaryColor = unchecked((uint)0x8577),

    [NativeName("GL_PREVIOUS")]
    Previous = unchecked((uint)0x8578),

    [NativeName("GL_OPERAND0_RGB")]
    Operand0Rgb = unchecked((uint)0x8590),

    [NativeName("GL_OPERAND1_RGB")]
    Operand1Rgb = unchecked((uint)0x8591),

    [NativeName("GL_OPERAND2_RGB")]
    Operand2Rgb = unchecked((uint)0x8592),

    [NativeName("GL_OPERAND0_ALPHA")]
    Operand0Alpha = unchecked((uint)0x8598),

    [NativeName("GL_OPERAND1_ALPHA")]
    Operand1Alpha = unchecked((uint)0x8599),

    [NativeName("GL_OPERAND2_ALPHA")]
    Operand2Alpha = unchecked((uint)0x859A),

    [NativeName("GL_ALPHA_SCALE")]
    AlphaScale = unchecked((uint)0x0D1C),

    [NativeName("GL_SRC0_RGB")]
    Src0Rgb = unchecked((uint)0x8580),

    [NativeName("GL_SRC1_RGB")]
    Src1Rgb = unchecked((uint)0x8581),

    [NativeName("GL_SRC2_RGB")]
    Src2Rgb = unchecked((uint)0x8582),

    [NativeName("GL_SRC0_ALPHA")]
    Src0Alpha = unchecked((uint)0x8588),

    [NativeName("GL_SRC1_ALPHA")]
    Src1Alpha = unchecked((uint)0x8589),

    [NativeName("GL_SRC2_ALPHA")]
    Src2Alpha = unchecked((uint)0x858A),

    [NativeName("GL_DOT3_RGB")]
    Dot3Rgb = unchecked((uint)0x86AE),

    [NativeName("GL_DOT3_RGBA")]
    Dot3Rgba = unchecked((uint)0x86AF),

    [NativeName("GL_TEXTURE_EXTERNAL_OES")]
    TextureExternalOES = unchecked((uint)0x8D65),

    [NativeName("GL_TEXTURE_BINDING_EXTERNAL_OES")]
    TextureBindingExternalOES = unchecked((uint)0x8D67),

    [NativeName("GL_REQUIRED_TEXTURE_IMAGE_UNITS_OES")]
    RequiredTextureImageUnitsOES = unchecked((uint)0x8D68),

    [NativeName("GL_BLEND_EQUATION_RGB_OES")]
    BlendEquationRgbOES = unchecked((uint)0x8009),

    [NativeName("GL_BLEND_EQUATION_ALPHA_OES")]
    BlendEquationAlphaOES = unchecked((uint)0x883D),

    [NativeName("GL_BLEND_DST_RGB_OES")]
    BlendDstRgbOES = unchecked((uint)0x80C8),

    [NativeName("GL_BLEND_SRC_RGB_OES")]
    BlendSrcRgbOES = unchecked((uint)0x80C9),

    [NativeName("GL_BLEND_DST_ALPHA_OES")]
    BlendDstAlphaOES = unchecked((uint)0x80CA),

    [NativeName("GL_BLEND_SRC_ALPHA_OES")]
    BlendSrcAlphaOES = unchecked((uint)0x80CB),

    [NativeName("GL_BLEND_EQUATION_OES")]
    BlendEquationOES = unchecked((uint)0x8009),

    [NativeName("GL_FUNC_ADD_OES")]
    FuncAddOES = unchecked((uint)0x8006),

    [NativeName("GL_FUNC_SUBTRACT_OES")]
    FuncSubtractOES = unchecked((uint)0x800A),

    [NativeName("GL_FUNC_REVERSE_SUBTRACT_OES")]
    FuncReverseSubtractOES = unchecked((uint)0x800B),

    [NativeName("GL_ETC1_RGB8_OES")]
    Etc1Rgb8OES = unchecked((uint)0x8D64),

    [NativeName("GL_PALETTE4_RGB8_OES")]
    Palette4Rgb8OES = unchecked((uint)0x8B90),

    [NativeName("GL_PALETTE4_RGBA8_OES")]
    Palette4Rgba8OES = unchecked((uint)0x8B91),

    [NativeName("GL_PALETTE4_R5_G6_B5_OES")]
    Palette4R5G6B5OES = unchecked((uint)0x8B92),

    [NativeName("GL_PALETTE4_RGBA4_OES")]
    Palette4Rgba4OES = unchecked((uint)0x8B93),

    [NativeName("GL_PALETTE4_RGB5_A1_OES")]
    Palette4Rgb5A1OES = unchecked((uint)0x8B94),

    [NativeName("GL_PALETTE8_RGB8_OES")]
    Palette8Rgb8OES = unchecked((uint)0x8B95),

    [NativeName("GL_PALETTE8_RGBA8_OES")]
    Palette8Rgba8OES = unchecked((uint)0x8B96),

    [NativeName("GL_PALETTE8_R5_G6_B5_OES")]
    Palette8R5G6B5OES = unchecked((uint)0x8B97),

    [NativeName("GL_PALETTE8_RGBA4_OES")]
    Palette8Rgba4OES = unchecked((uint)0x8B98),

    [NativeName("GL_PALETTE8_RGB5_A1_OES")]
    Palette8Rgb5A1OES = unchecked((uint)0x8B99),

    [NativeName("GL_DEPTH_COMPONENT24_OES")]
    DepthComponent24OES = unchecked((uint)0x81A6),

    [NativeName("GL_DEPTH_COMPONENT32_OES")]
    DepthComponent32OES = unchecked((uint)0x81A7),

    [NativeName("GL_TEXTURE_CROP_RECT_OES")]
    TextureCropRectOES = unchecked((uint)0x8B9D),

    [NativeName("GL_UNSIGNED_INT")]
    UnsignedInt = unchecked((uint)0x1405),

    [NativeName("GL_FIXED_OES")]
    FixedOES = unchecked((uint)0x140C),

    [NativeName("GL_NONE_OES")]
    NoneOES = unchecked((uint)0),

    [NativeName("GL_FRAMEBUFFER_OES")]
    FramebufferOES = unchecked((uint)0x8D40),

    [NativeName("GL_RENDERBUFFER_OES")]
    RenderbufferOES = unchecked((uint)0x8D41),

    [NativeName("GL_RGBA4_OES")]
    Rgba4OES = unchecked((uint)0x8056),

    [NativeName("GL_RGB5_A1_OES")]
    Rgb5A1OES = unchecked((uint)0x8057),

    [NativeName("GL_RGB565_OES")]
    Rgb565OES = unchecked((uint)0x8D62),

    [NativeName("GL_DEPTH_COMPONENT16_OES")]
    DepthComponent16OES = unchecked((uint)0x81A5),

    [NativeName("GL_RENDERBUFFER_WIDTH_OES")]
    RenderbufferWidthOES = unchecked((uint)0x8D42),

    [NativeName("GL_RENDERBUFFER_HEIGHT_OES")]
    RenderbufferHeightOES = unchecked((uint)0x8D43),

    [NativeName("GL_RENDERBUFFER_INTERNAL_FORMAT_OES")]
    RenderbufferInternalFormatOES = unchecked((uint)0x8D44),

    [NativeName("GL_RENDERBUFFER_RED_SIZE_OES")]
    RenderbufferRedSizeOES = unchecked((uint)0x8D50),

    [NativeName("GL_RENDERBUFFER_GREEN_SIZE_OES")]
    RenderbufferGreenSizeOES = unchecked((uint)0x8D51),

    [NativeName("GL_RENDERBUFFER_BLUE_SIZE_OES")]
    RenderbufferBlueSizeOES = unchecked((uint)0x8D52),

    [NativeName("GL_RENDERBUFFER_ALPHA_SIZE_OES")]
    RenderbufferAlphaSizeOES = unchecked((uint)0x8D53),

    [NativeName("GL_RENDERBUFFER_DEPTH_SIZE_OES")]
    RenderbufferDepthSizeOES = unchecked((uint)0x8D54),

    [NativeName("GL_RENDERBUFFER_STENCIL_SIZE_OES")]
    RenderbufferStencilSizeOES = unchecked((uint)0x8D55),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_OES")]
    FramebufferAttachmentObjectTypeOES = unchecked((uint)0x8CD0),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_OES")]
    FramebufferAttachmentObjectNameOES = unchecked((uint)0x8CD1),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_OES")]
    FramebufferAttachmentTextureLevelOES = unchecked((uint)0x8CD2),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_OES")]
    FramebufferAttachmentTextureCubeMapFaceOES = unchecked((uint)0x8CD3),

    [NativeName("GL_COLOR_ATTACHMENT0_OES")]
    ColorAttachment0OES = unchecked((uint)0x8CE0),

    [NativeName("GL_DEPTH_ATTACHMENT_OES")]
    DepthAttachmentOES = unchecked((uint)0x8D00),

    [NativeName("GL_STENCIL_ATTACHMENT_OES")]
    StencilAttachmentOES = unchecked((uint)0x8D20),

    [NativeName("GL_FRAMEBUFFER_COMPLETE_OES")]
    FramebufferCompleteOES = unchecked((uint)0x8CD5),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_OES")]
    FramebufferIncompleteAttachmentOES = unchecked((uint)0x8CD6),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_OES")]
    FramebufferIncompleteMissingAttachmentOES = unchecked((uint)0x8CD7),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_OES")]
    FramebufferIncompleteDimensionsOES = unchecked((uint)0x8CD9),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_FORMATS_OES")]
    FramebufferIncompleteFormatsOES = unchecked((uint)0x8CDA),

    [NativeName("GL_FRAMEBUFFER_UNSUPPORTED_OES")]
    FramebufferUnsupportedOES = unchecked((uint)0x8CDD),

    [NativeName("GL_FRAMEBUFFER_BINDING_OES")]
    FramebufferBindingOES = unchecked((uint)0x8CA6),

    [NativeName("GL_RENDERBUFFER_BINDING_OES")]
    RenderbufferBindingOES = unchecked((uint)0x8CA7),

    [NativeName("GL_MAX_RENDERBUFFER_SIZE_OES")]
    MaxRenderbufferSizeOES = unchecked((uint)0x84E8),

    [NativeName("GL_INVALID_FRAMEBUFFER_OPERATION_OES")]
    InvalidFramebufferOperationOES = unchecked((uint)0x0506),

    [NativeName("GL_WRITE_ONLY_OES")]
    WriteOnlyOES = unchecked((uint)0x88B9),

    [NativeName("GL_BUFFER_ACCESS_OES")]
    BufferAccessOES = unchecked((uint)0x88BB),

    [NativeName("GL_BUFFER_MAPPED_OES")]
    BufferMappedOES = unchecked((uint)0x88BC),

    [NativeName("GL_BUFFER_MAP_POINTER_OES")]
    BufferMapPointerOES = unchecked((uint)0x88BD),

    [NativeName("GL_MODELVIEW_MATRIX_FLOAT_AS_INT_BITS_OES")]
    ModelviewMatrixFloatAsIntBitsOES = unchecked((uint)0x898D),

    [NativeName("GL_PROJECTION_MATRIX_FLOAT_AS_INT_BITS_OES")]
    ProjectionMatrixFloatAsIntBitsOES = unchecked((uint)0x898E),

    [NativeName("GL_TEXTURE_MATRIX_FLOAT_AS_INT_BITS_OES")]
    TextureMatrixFloatAsIntBitsOES = unchecked((uint)0x898F),

    [NativeName("GL_MAX_VERTEX_UNITS_OES")]
    MaxVertexUnitsOES = unchecked((uint)0x86A4),

    [NativeName("GL_MAX_PALETTE_MATRICES_OES")]
    MaxPaletteMatricesOES = unchecked((uint)0x8842),

    [NativeName("GL_MATRIX_PALETTE_OES")]
    MatrixPaletteOES = unchecked((uint)0x8840),

    [NativeName("GL_MATRIX_INDEX_ARRAY_OES")]
    MatrixIndexArrayOES = unchecked((uint)0x8844),

    [NativeName("GL_WEIGHT_ARRAY_OES")]
    WeightArrayOES = unchecked((uint)0x86AD),

    [NativeName("GL_CURRENT_PALETTE_MATRIX_OES")]
    CurrentPaletteMatrixOES = unchecked((uint)0x8843),

    [NativeName("GL_MATRIX_INDEX_ARRAY_SIZE_OES")]
    MatrixIndexArraySizeOES = unchecked((uint)0x8846),

    [NativeName("GL_MATRIX_INDEX_ARRAY_TYPE_OES")]
    MatrixIndexArrayTypeOES = unchecked((uint)0x8847),

    [NativeName("GL_MATRIX_INDEX_ARRAY_STRIDE_OES")]
    MatrixIndexArrayStrideOES = unchecked((uint)0x8848),

    [NativeName("GL_MATRIX_INDEX_ARRAY_POINTER_OES")]
    MatrixIndexArrayPointerOES = unchecked((uint)0x8849),

    [NativeName("GL_MATRIX_INDEX_ARRAY_BUFFER_BINDING_OES")]
    MatrixIndexArrayBufferBindingOES = unchecked((uint)0x8B9E),

    [NativeName("GL_WEIGHT_ARRAY_SIZE_OES")]
    WeightArraySizeOES = unchecked((uint)0x86AB),

    [NativeName("GL_WEIGHT_ARRAY_TYPE_OES")]
    WeightArrayTypeOES = unchecked((uint)0x86A9),

    [NativeName("GL_WEIGHT_ARRAY_STRIDE_OES")]
    WeightArrayStrideOES = unchecked((uint)0x86AA),

    [NativeName("GL_WEIGHT_ARRAY_POINTER_OES")]
    WeightArrayPointerOES = unchecked((uint)0x86AC),

    [NativeName("GL_WEIGHT_ARRAY_BUFFER_BINDING_OES")]
    WeightArrayBufferBindingOES = unchecked((uint)0x889E),

    [NativeName("GL_DEPTH_STENCIL_OES")]
    DepthStencilOES = unchecked((uint)0x84F9),

    [NativeName("GL_UNSIGNED_INT_24_8_OES")]
    UnsignedInt24X8OES = unchecked((uint)0x84FA),

    [NativeName("GL_DEPTH24_STENCIL8_OES")]
    Depth24Stencil8OES = unchecked((uint)0x88F0),

    [NativeName("GL_POINT_SIZE_ARRAY_OES")]
    PointSizeArrayOES = unchecked((uint)0x8B9C),

    [NativeName("GL_POINT_SIZE_ARRAY_TYPE_OES")]
    PointSizeArrayTypeOES = unchecked((uint)0x898A),

    [NativeName("GL_POINT_SIZE_ARRAY_STRIDE_OES")]
    PointSizeArrayStrideOES = unchecked((uint)0x898B),

    [NativeName("GL_POINT_SIZE_ARRAY_POINTER_OES")]
    PointSizeArrayPointerOES = unchecked((uint)0x898C),

    [NativeName("GL_POINT_SIZE_ARRAY_BUFFER_BINDING_OES")]
    PointSizeArrayBufferBindingOES = unchecked((uint)0x8B9F),

    [NativeName("GL_POINT_SPRITE_OES")]
    PointSpriteOES = unchecked((uint)0x8861),

    [NativeName("GL_COORD_REPLACE_OES")]
    CoordReplaceOES = unchecked((uint)0x8862),

    [NativeName("GL_IMPLEMENTATION_COLOR_READ_TYPE_OES")]
    ImplementationColorReadTypeOES = unchecked((uint)0x8B9A),

    [NativeName("GL_IMPLEMENTATION_COLOR_READ_FORMAT_OES")]
    ImplementationColorReadFormatOES = unchecked((uint)0x8B9B),

    [NativeName("GL_ALPHA8_OES")]
    Alpha8OES = unchecked((uint)0x803C),

    [NativeName("GL_LUMINANCE4_ALPHA4_OES")]
    Luminance4Alpha4OES = unchecked((uint)0x8043),

    [NativeName("GL_LUMINANCE8_ALPHA8_OES")]
    Luminance8Alpha8OES = unchecked((uint)0x8045),

    [NativeName("GL_LUMINANCE8_OES")]
    Luminance8OES = unchecked((uint)0x8040),

    [NativeName("GL_RGB8_OES")]
    Rgb8OES = unchecked((uint)0x8051),

    [NativeName("GL_RGBA8_OES")]
    Rgba8OES = unchecked((uint)0x8058),

    [NativeName("GL_RGB10_EXT")]
    Rgb10EXT = unchecked((uint)0x8052),

    [NativeName("GL_RGB10_A2_EXT")]
    Rgb10A2EXT = unchecked((uint)0x8059),

    [NativeName("GL_STENCIL_INDEX1_OES")]
    StencilIndex1OES = unchecked((uint)0x8D46),

    [NativeName("GL_STENCIL_INDEX4_OES")]
    StencilIndex4OES = unchecked((uint)0x8D47),

    [NativeName("GL_STENCIL_INDEX8_OES")]
    StencilIndex8OES = unchecked((uint)0x8D48),

    [NativeName("GL_INCR_WRAP_OES")]
    IncrWrapOES = unchecked((uint)0x8507),

    [NativeName("GL_DECR_WRAP_OES")]
    DecrWrapOES = unchecked((uint)0x8508),

    [NativeName("GL_FRAMEBUFFER_UNDEFINED_OES")]
    FramebufferUndefinedOES = unchecked((uint)0x8219),

    [NativeName("GL_NORMAL_MAP_OES")]
    NormalMapOES = unchecked((uint)0x8511),

    [NativeName("GL_REFLECTION_MAP_OES")]
    ReflectionMapOES = unchecked((uint)0x8512),

    [NativeName("GL_TEXTURE_CUBE_MAP_OES")]
    TextureCubeMapOES = unchecked((uint)0x8513),

    [NativeName("GL_TEXTURE_BINDING_CUBE_MAP_OES")]
    TextureBindingCubeMapOES = unchecked((uint)0x8514),

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_X_OES")]
    TextureCubeMapPositiveXOES = unchecked((uint)0x8515),

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_X_OES")]
    TextureCubeMapNegativeXOES = unchecked((uint)0x8516),

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Y_OES")]
    TextureCubeMapPositiveYOES = unchecked((uint)0x8517),

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_OES")]
    TextureCubeMapNegativeYOES = unchecked((uint)0x8518),

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Z_OES")]
    TextureCubeMapPositiveZOES = unchecked((uint)0x8519),

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_OES")]
    TextureCubeMapNegativeZOES = unchecked((uint)0x851A),

    [NativeName("GL_MAX_CUBE_MAP_TEXTURE_SIZE_OES")]
    MaxCubeMapTextureSizeOES = unchecked((uint)0x851C),

    [NativeName("GL_TEXTURE_GEN_MODE_OES")]
    TextureGenModeOES = unchecked((uint)0x2500),

    [NativeName("GL_TEXTURE_GEN_STR_OES")]
    TextureGenStrOES = unchecked((uint)0x8D60),

    [NativeName("GL_MIRRORED_REPEAT_OES")]
    MirroredRepeatOES = unchecked((uint)0x8370),

    [NativeName("GL_VERTEX_ARRAY_BINDING_OES")]
    VertexArrayBindingOES = unchecked((uint)0x85B5),

    [NativeName("GL_3DC_X_AMD")]
    X3DcXAMD = unchecked((uint)0x87F9),

    [NativeName("GL_3DC_XY_AMD")]
    X3DcXyAMD = unchecked((uint)0x87FA),

    [NativeName("GL_ATC_RGB_AMD")]
    AtcRgbAMD = unchecked((uint)0x8C92),

    [NativeName("GL_ATC_RGBA_EXPLICIT_ALPHA_AMD")]
    AtcRgbaExplicitAlphaAMD = unchecked((uint)0x8C93),

    [NativeName("GL_ATC_RGBA_INTERPOLATED_ALPHA_AMD")]
    AtcRgbaInterpolatedAlphaAMD = unchecked((uint)0x87EE),

    [NativeName("GL_RENDERBUFFER_SAMPLES_APPLE")]
    RenderbufferSamplesAPPLE = unchecked((uint)0x8CAB),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_APPLE")]
    FramebufferIncompleteMultisampleAPPLE = unchecked((uint)0x8D56),

    [NativeName("GL_MAX_SAMPLES_APPLE")]
    MaxSamplesAPPLE = unchecked((uint)0x8D57),

    [NativeName("GL_READ_FRAMEBUFFER_APPLE")]
    ReadFramebufferAPPLE = unchecked((uint)0x8CA8),

    [NativeName("GL_DRAW_FRAMEBUFFER_APPLE")]
    DrawFramebufferAPPLE = unchecked((uint)0x8CA9),

    [NativeName("GL_DRAW_FRAMEBUFFER_BINDING_APPLE")]
    DrawFramebufferBindingAPPLE = unchecked((uint)0x8CA6),

    [NativeName("GL_READ_FRAMEBUFFER_BINDING_APPLE")]
    ReadFramebufferBindingAPPLE = unchecked((uint)0x8CAA),

    [NativeName("GL_SYNC_OBJECT_APPLE")]
    SyncObjectAPPLE = unchecked((uint)0x8A53),

    [NativeName("GL_MAX_SERVER_WAIT_TIMEOUT_APPLE")]
    MaxServerWaitTimeoutAPPLE = unchecked((uint)0x9111),

    [NativeName("GL_OBJECT_TYPE_APPLE")]
    ObjectTypeAPPLE = unchecked((uint)0x9112),

    [NativeName("GL_SYNC_CONDITION_APPLE")]
    SyncConditionAPPLE = unchecked((uint)0x9113),

    [NativeName("GL_SYNC_STATUS_APPLE")]
    SyncStatusAPPLE = unchecked((uint)0x9114),

    [NativeName("GL_SYNC_FLAGS_APPLE")]
    SyncFlagsAPPLE = unchecked((uint)0x9115),

    [NativeName("GL_SYNC_FENCE_APPLE")]
    SyncFenceAPPLE = unchecked((uint)0x9116),

    [NativeName("GL_SYNC_GPU_COMMANDS_COMPLETE_APPLE")]
    SyncGpuCommandsCompleteAPPLE = unchecked((uint)0x9117),

    [NativeName("GL_UNSIGNALED_APPLE")]
    UnsignaledAPPLE = unchecked((uint)0x9118),

    [NativeName("GL_SIGNALED_APPLE")]
    SignaledAPPLE = unchecked((uint)0x9119),

    [NativeName("GL_ALREADY_SIGNALED_APPLE")]
    AlreadySignaledAPPLE = unchecked((uint)0x911A),

    [NativeName("GL_TIMEOUT_EXPIRED_APPLE")]
    TimeoutExpiredAPPLE = unchecked((uint)0x911B),

    [NativeName("GL_CONDITION_SATISFIED_APPLE")]
    ConditionSatisfiedAPPLE = unchecked((uint)0x911C),

    [NativeName("GL_WAIT_FAILED_APPLE")]
    WaitFailedAPPLE = unchecked((uint)0x911D),

    [NativeName("GL_SYNC_FLUSH_COMMANDS_BIT_APPLE")]
    SyncFlushCommandsBitAPPLE = unchecked((uint)0x00000001),

    [NativeName("GL_TIMEOUT_IGNORED_APPLE")]
    TimeoutIgnoredAPPLE = unchecked((uint)0xFFFFFFFFFFFFFFFFUL),

    [NativeName("GL_BGRA_EXT")]
    BgraEXT = unchecked((uint)0x80E1),

    [NativeName("GL_BGRA8_EXT")]
    Bgra8EXT = unchecked((uint)0x93A1),

    [NativeName("GL_TEXTURE_MAX_LEVEL_APPLE")]
    TextureMaxLevelAPPLE = unchecked((uint)0x813D),

    [NativeName("GL_MIN_EXT")]
    MinEXT = unchecked((uint)0x8007),

    [NativeName("GL_MAX_EXT")]
    MaxEXT = unchecked((uint)0x8008),

    [NativeName("GL_COLOR_EXT")]
    ColorEXT = unchecked((uint)0x1800),

    [NativeName("GL_DEPTH_EXT")]
    DepthEXT = unchecked((uint)0x1801),

    [NativeName("GL_STENCIL_EXT")]
    StencilEXT = unchecked((uint)0x1802),

    [NativeName("GL_MAP_READ_BIT_EXT")]
    MapReadBitEXT = unchecked((uint)0x0001),

    [NativeName("GL_MAP_WRITE_BIT_EXT")]
    MapWriteBitEXT = unchecked((uint)0x0002),

    [NativeName("GL_MAP_INVALIDATE_RANGE_BIT_EXT")]
    MapInvalidateRangeBitEXT = unchecked((uint)0x0004),

    [NativeName("GL_MAP_INVALIDATE_BUFFER_BIT_EXT")]
    MapInvalidateBufferBitEXT = unchecked((uint)0x0008),

    [NativeName("GL_MAP_FLUSH_EXPLICIT_BIT_EXT")]
    MapFlushExplicitBitEXT = unchecked((uint)0x0010),

    [NativeName("GL_MAP_UNSYNCHRONIZED_BIT_EXT")]
    MapUnsynchronizedBitEXT = unchecked((uint)0x0020),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SAMPLES_EXT")]
    FramebufferAttachmentTextureSamplesEXT = unchecked((uint)0x8D6C),

    [NativeName("GL_RENDERBUFFER_SAMPLES_EXT")]
    RenderbufferSamplesEXT = unchecked((uint)0x8CAB),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_EXT")]
    FramebufferIncompleteMultisampleEXT = unchecked((uint)0x8D56),

    [NativeName("GL_MAX_SAMPLES_EXT")]
    MaxSamplesEXT = unchecked((uint)0x8D57),

    [NativeName("GL_UNSIGNED_SHORT_4_4_4_4_REV_EXT")]
    UnsignedShort4X4X4X4RevEXT = unchecked((uint)0x8365),

    [NativeName("GL_UNSIGNED_SHORT_1_5_5_5_REV_EXT")]
    UnsignedShort1X5X5X5RevEXT = unchecked((uint)0x8366),

    [NativeName("GL_GUILTY_CONTEXT_RESET_EXT")]
    GuiltyContextResetEXT = unchecked((uint)0x8253),

    [NativeName("GL_INNOCENT_CONTEXT_RESET_EXT")]
    InnocentContextResetEXT = unchecked((uint)0x8254),

    [NativeName("GL_UNKNOWN_CONTEXT_RESET_EXT")]
    UnknownContextResetEXT = unchecked((uint)0x8255),

    [NativeName("GL_CONTEXT_ROBUST_ACCESS_EXT")]
    ContextRobustAccessEXT = unchecked((uint)0x90F3),

    [NativeName("GL_RESET_NOTIFICATION_STRATEGY_EXT")]
    ResetNotificationStrategyEXT = unchecked((uint)0x8256),

    [NativeName("GL_LOSE_CONTEXT_ON_RESET_EXT")]
    LoseContextOnResetEXT = unchecked((uint)0x8252),

    [NativeName("GL_NO_RESET_NOTIFICATION_EXT")]
    NoResetNotificationEXT = unchecked((uint)0x8261),

    [NativeName("GL_SRGB_EXT")]
    SrgbEXT = unchecked((uint)0x8C40),

    [NativeName("GL_SRGB_ALPHA_EXT")]
    SrgbAlphaEXT = unchecked((uint)0x8C42),

    [NativeName("GL_SRGB8_ALPHA8_EXT")]
    Srgb8Alpha8EXT = unchecked((uint)0x8C43),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING_EXT")]
    FramebufferAttachmentColorEncodingEXT = unchecked((uint)0x8210),

    [NativeName("GL_COMPRESSED_RGB_S3TC_DXT1_EXT")]
    CompressedRgbS3TcDxt1EXT = unchecked((uint)0x83F0),

    [NativeName("GL_COMPRESSED_RGBA_S3TC_DXT1_EXT")]
    CompressedRgbaS3TcDxt1EXT = unchecked((uint)0x83F1),

    [NativeName("GL_TEXTURE_MAX_ANISOTROPY_EXT")]
    TextureMaxAnisotropyEXT = unchecked((uint)0x84FE),

    [NativeName("GL_MAX_TEXTURE_MAX_ANISOTROPY_EXT")]
    MaxTextureMaxAnisotropyEXT = unchecked((uint)0x84FF),

    [NativeName("GL_MAX_TEXTURE_LOD_BIAS_EXT")]
    MaxTextureLodBiasEXT = unchecked((uint)0x84FD),

    [NativeName("GL_TEXTURE_FILTER_CONTROL_EXT")]
    TextureFilterControlEXT = unchecked((uint)0x8500),

    [NativeName("GL_TEXTURE_LOD_BIAS_EXT")]
    TextureLodBiasEXT = unchecked((uint)0x8501),

    [NativeName("GL_TEXTURE_IMMUTABLE_FORMAT_EXT")]
    TextureImmutableFormatEXT = unchecked((uint)0x912F),

    [NativeName("GL_ALPHA8_EXT")]
    Alpha8EXT = unchecked((uint)0x803C),

    [NativeName("GL_LUMINANCE8_EXT")]
    Luminance8EXT = unchecked((uint)0x8040),

    [NativeName("GL_LUMINANCE8_ALPHA8_EXT")]
    Luminance8Alpha8EXT = unchecked((uint)0x8045),

    [NativeName("GL_RGBA32F_EXT")]
    Rgba32FEXT = unchecked((uint)0x8814),

    [NativeName("GL_RGB32F_EXT")]
    Rgb32FEXT = unchecked((uint)0x8815),

    [NativeName("GL_ALPHA32F_EXT")]
    Alpha32FEXT = unchecked((uint)0x8816),

    [NativeName("GL_LUMINANCE32F_EXT")]
    Luminance32FEXT = unchecked((uint)0x8818),

    [NativeName("GL_LUMINANCE_ALPHA32F_EXT")]
    LuminanceAlpha32FEXT = unchecked((uint)0x8819),

    [NativeName("GL_RGBA16F_EXT")]
    Rgba16FEXT = unchecked((uint)0x881A),

    [NativeName("GL_RGB16F_EXT")]
    Rgb16FEXT = unchecked((uint)0x881B),

    [NativeName("GL_ALPHA16F_EXT")]
    Alpha16FEXT = unchecked((uint)0x881C),

    [NativeName("GL_LUMINANCE16F_EXT")]
    Luminance16FEXT = unchecked((uint)0x881E),

    [NativeName("GL_LUMINANCE_ALPHA16F_EXT")]
    LuminanceAlpha16FEXT = unchecked((uint)0x881F),

    [NativeName("GL_R8_EXT")]
    R8EXT = unchecked((uint)0x8229),

    [NativeName("GL_RG8_EXT")]
    Rg8EXT = unchecked((uint)0x822B),

    [NativeName("GL_R32F_EXT")]
    R32FEXT = unchecked((uint)0x822E),

    [NativeName("GL_RG32F_EXT")]
    Rg32FEXT = unchecked((uint)0x8230),

    [NativeName("GL_R16F_EXT")]
    R16FEXT = unchecked((uint)0x822D),

    [NativeName("GL_RG16F_EXT")]
    Rg16FEXT = unchecked((uint)0x822F),

    [NativeName("GL_RENDERBUFFER_SAMPLES_IMG")]
    RenderbufferSamplesIMG = unchecked((uint)0x9133),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_IMG")]
    FramebufferIncompleteMultisampleIMG = unchecked((uint)0x9134),

    [NativeName("GL_MAX_SAMPLES_IMG")]
    MaxSamplesIMG = unchecked((uint)0x9135),

    [NativeName("GL_TEXTURE_SAMPLES_IMG")]
    TextureSamplesIMG = unchecked((uint)0x9136),

    [NativeName("GL_BGRA_IMG")]
    BgraIMG = unchecked((uint)0x80E1),

    [NativeName("GL_UNSIGNED_SHORT_4_4_4_4_REV_IMG")]
    UnsignedShort4X4X4X4RevIMG = unchecked((uint)0x8365),

    [NativeName("GL_COMPRESSED_RGB_PVRTC_4BPPV1_IMG")]
    CompressedRgbPvrtc4Bppv1IMG = unchecked((uint)0x8C00),

    [NativeName("GL_COMPRESSED_RGB_PVRTC_2BPPV1_IMG")]
    CompressedRgbPvrtc2Bppv1IMG = unchecked((uint)0x8C01),

    [NativeName("GL_COMPRESSED_RGBA_PVRTC_4BPPV1_IMG")]
    CompressedRgbaPvrtc4Bppv1IMG = unchecked((uint)0x8C02),

    [NativeName("GL_COMPRESSED_RGBA_PVRTC_2BPPV1_IMG")]
    CompressedRgbaPvrtc2Bppv1IMG = unchecked((uint)0x8C03),

    [NativeName("GL_MODULATE_COLOR_IMG")]
    ModulateColorIMG = unchecked((uint)0x8C04),

    [NativeName("GL_RECIP_ADD_SIGNED_ALPHA_IMG")]
    RecipAddSignedAlphaIMG = unchecked((uint)0x8C05),

    [NativeName("GL_TEXTURE_ALPHA_MODULATE_IMG")]
    TextureAlphaModulateIMG = unchecked((uint)0x8C06),

    [NativeName("GL_FACTOR_ALPHA_MODULATE_IMG")]
    FactorAlphaModulateIMG = unchecked((uint)0x8C07),

    [NativeName("GL_FRAGMENT_ALPHA_MODULATE_IMG")]
    FragmentAlphaModulateIMG = unchecked((uint)0x8C08),

    [NativeName("GL_ADD_BLEND_IMG")]
    AddBlendIMG = unchecked((uint)0x8C09),

    [NativeName("GL_DOT3_RGBA_IMG")]
    Dot3RgbaIMG = unchecked((uint)0x86AF),

    [NativeName("GL_CLIP_PLANE0_IMG")]
    ClipPlane0IMG = unchecked((uint)0x3000),

    [NativeName("GL_CLIP_PLANE1_IMG")]
    ClipPlane1IMG = unchecked((uint)0x3001),

    [NativeName("GL_CLIP_PLANE2_IMG")]
    ClipPlane2IMG = unchecked((uint)0x3002),

    [NativeName("GL_CLIP_PLANE3_IMG")]
    ClipPlane3IMG = unchecked((uint)0x3003),

    [NativeName("GL_CLIP_PLANE4_IMG")]
    ClipPlane4IMG = unchecked((uint)0x3004),

    [NativeName("GL_CLIP_PLANE5_IMG")]
    ClipPlane5IMG = unchecked((uint)0x3005),

    [NativeName("GL_MAX_CLIP_PLANES_IMG")]
    MaxClipPlanesIMG = unchecked((uint)0x0D32),

    [NativeName("GL_ALL_COMPLETED_NV")]
    AllCompletedNV = unchecked((uint)0x84F2),

    [NativeName("GL_FENCE_STATUS_NV")]
    FenceStatusNV = unchecked((uint)0x84F3),

    [NativeName("GL_FENCE_CONDITION_NV")]
    FenceConditionNV = unchecked((uint)0x84F4),

    [NativeName("GL_TEXTURE_WIDTH_QCOM")]
    TextureWidthQCOM = unchecked((uint)0x8BD2),

    [NativeName("GL_TEXTURE_HEIGHT_QCOM")]
    TextureHeightQCOM = unchecked((uint)0x8BD3),

    [NativeName("GL_TEXTURE_DEPTH_QCOM")]
    TextureDepthQCOM = unchecked((uint)0x8BD4),

    [NativeName("GL_TEXTURE_INTERNAL_FORMAT_QCOM")]
    TextureInternalFormatQCOM = unchecked((uint)0x8BD5),

    [NativeName("GL_TEXTURE_FORMAT_QCOM")]
    TextureFormatQCOM = unchecked((uint)0x8BD6),

    [NativeName("GL_TEXTURE_TYPE_QCOM")]
    TextureTypeQCOM = unchecked((uint)0x8BD7),

    [NativeName("GL_TEXTURE_IMAGE_VALID_QCOM")]
    TextureImageValidQCOM = unchecked((uint)0x8BD8),

    [NativeName("GL_TEXTURE_NUM_LEVELS_QCOM")]
    TextureNumLevelsQCOM = unchecked((uint)0x8BD9),

    [NativeName("GL_TEXTURE_TARGET_QCOM")]
    TextureTargetQCOM = unchecked((uint)0x8BDA),

    [NativeName("GL_TEXTURE_OBJECT_VALID_QCOM")]
    TextureObjectValidQCOM = unchecked((uint)0x8BDB),

    [NativeName("GL_STATE_RESTORE")]
    StateRestore = unchecked((uint)0x8BDC),

    [NativeName("GL_PERFMON_GLOBAL_MODE_QCOM")]
    PerfmonGlobalModeQCOM = unchecked((uint)0x8FA0),

    [NativeName("GL_COLOR_BUFFER_BIT0_QCOM")]
    ColorBufferBit0QCOM = unchecked((uint)0x00000001),

    [NativeName("GL_COLOR_BUFFER_BIT1_QCOM")]
    ColorBufferBit1QCOM = unchecked((uint)0x00000002),

    [NativeName("GL_COLOR_BUFFER_BIT2_QCOM")]
    ColorBufferBit2QCOM = unchecked((uint)0x00000004),

    [NativeName("GL_COLOR_BUFFER_BIT3_QCOM")]
    ColorBufferBit3QCOM = unchecked((uint)0x00000008),

    [NativeName("GL_COLOR_BUFFER_BIT4_QCOM")]
    ColorBufferBit4QCOM = unchecked((uint)0x00000010),

    [NativeName("GL_COLOR_BUFFER_BIT5_QCOM")]
    ColorBufferBit5QCOM = unchecked((uint)0x00000020),

    [NativeName("GL_COLOR_BUFFER_BIT6_QCOM")]
    ColorBufferBit6QCOM = unchecked((uint)0x00000040),

    [NativeName("GL_COLOR_BUFFER_BIT7_QCOM")]
    ColorBufferBit7QCOM = unchecked((uint)0x00000080),

    [NativeName("GL_DEPTH_BUFFER_BIT0_QCOM")]
    DepthBufferBit0QCOM = unchecked((uint)0x00000100),

    [NativeName("GL_DEPTH_BUFFER_BIT1_QCOM")]
    DepthBufferBit1QCOM = unchecked((uint)0x00000200),

    [NativeName("GL_DEPTH_BUFFER_BIT2_QCOM")]
    DepthBufferBit2QCOM = unchecked((uint)0x00000400),

    [NativeName("GL_DEPTH_BUFFER_BIT3_QCOM")]
    DepthBufferBit3QCOM = unchecked((uint)0x00000800),

    [NativeName("GL_DEPTH_BUFFER_BIT4_QCOM")]
    DepthBufferBit4QCOM = unchecked((uint)0x00001000),

    [NativeName("GL_DEPTH_BUFFER_BIT5_QCOM")]
    DepthBufferBit5QCOM = unchecked((uint)0x00002000),

    [NativeName("GL_DEPTH_BUFFER_BIT6_QCOM")]
    DepthBufferBit6QCOM = unchecked((uint)0x00004000),

    [NativeName("GL_DEPTH_BUFFER_BIT7_QCOM")]
    DepthBufferBit7QCOM = unchecked((uint)0x00008000),

    [NativeName("GL_STENCIL_BUFFER_BIT0_QCOM")]
    StencilBufferBit0QCOM = unchecked((uint)0x00010000),

    [NativeName("GL_STENCIL_BUFFER_BIT1_QCOM")]
    StencilBufferBit1QCOM = unchecked((uint)0x00020000),

    [NativeName("GL_STENCIL_BUFFER_BIT2_QCOM")]
    StencilBufferBit2QCOM = unchecked((uint)0x00040000),

    [NativeName("GL_STENCIL_BUFFER_BIT3_QCOM")]
    StencilBufferBit3QCOM = unchecked((uint)0x00080000),

    [NativeName("GL_STENCIL_BUFFER_BIT4_QCOM")]
    StencilBufferBit4QCOM = unchecked((uint)0x00100000),

    [NativeName("GL_STENCIL_BUFFER_BIT5_QCOM")]
    StencilBufferBit5QCOM = unchecked((uint)0x00200000),

    [NativeName("GL_STENCIL_BUFFER_BIT6_QCOM")]
    StencilBufferBit6QCOM = unchecked((uint)0x00400000),

    [NativeName("GL_STENCIL_BUFFER_BIT7_QCOM")]
    StencilBufferBit7QCOM = unchecked((uint)0x00800000),

    [NativeName("GL_MULTISAMPLE_BUFFER_BIT0_QCOM")]
    MultisampleBufferBit0QCOM = unchecked((uint)0x01000000),

    [NativeName("GL_MULTISAMPLE_BUFFER_BIT1_QCOM")]
    MultisampleBufferBit1QCOM = unchecked((uint)0x02000000),

    [NativeName("GL_MULTISAMPLE_BUFFER_BIT2_QCOM")]
    MultisampleBufferBit2QCOM = unchecked((uint)0x04000000),

    [NativeName("GL_MULTISAMPLE_BUFFER_BIT3_QCOM")]
    MultisampleBufferBit3QCOM = unchecked((uint)0x08000000),

    [NativeName("GL_MULTISAMPLE_BUFFER_BIT4_QCOM")]
    MultisampleBufferBit4QCOM = unchecked((uint)0x10000000),

    [NativeName("GL_MULTISAMPLE_BUFFER_BIT5_QCOM")]
    MultisampleBufferBit5QCOM = unchecked((uint)0x20000000),

    [NativeName("GL_MULTISAMPLE_BUFFER_BIT6_QCOM")]
    MultisampleBufferBit6QCOM = unchecked((uint)0x40000000),

    [NativeName("GL_MULTISAMPLE_BUFFER_BIT7_QCOM")]
    MultisampleBufferBit7QCOM = unchecked((uint)0x80000000),

    [NativeName("GL_WRITEONLY_RENDERING_QCOM")]
    WriteonlyRenderingQCOM = unchecked((uint)0x8823),

    [NativeName("GL_QUADS")]
    Quads = unchecked((uint)0x0007),

    [NativeName("GL_NONE")]
    None = unchecked((uint)0),

    [NativeName("GL_FRONT_LEFT")]
    FrontLeft = unchecked((uint)0x0400),

    [NativeName("GL_FRONT_RIGHT")]
    FrontRight = unchecked((uint)0x0401),

    [NativeName("GL_BACK_LEFT")]
    BackLeft = unchecked((uint)0x0402),

    [NativeName("GL_BACK_RIGHT")]
    BackRight = unchecked((uint)0x0403),

    [NativeName("GL_LEFT")]
    Left = unchecked((uint)0x0406),

    [NativeName("GL_RIGHT")]
    Right = unchecked((uint)0x0407),

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

    [NativeName("GL_TEXTURE_WIDTH")]
    TextureWidth = unchecked((uint)0x1000),

    [NativeName("GL_TEXTURE_HEIGHT")]
    TextureHeight = unchecked((uint)0x1001),

    [NativeName("GL_TEXTURE_BORDER_COLOR")]
    TextureBorderColor = unchecked((uint)0x1004),

    [NativeName("GL_INT")]
    Int = unchecked((uint)0x1404),

    [NativeName("GL_COLOR")]
    Color = unchecked((uint)0x1800),

    [NativeName("GL_DEPTH")]
    Depth = unchecked((uint)0x1801),

    [NativeName("GL_STENCIL")]
    Stencil = unchecked((uint)0x1802),

    [NativeName("GL_STENCIL_INDEX")]
    StencilIndex = unchecked((uint)0x1901),

    [NativeName("GL_DEPTH_COMPONENT")]
    DepthComponent = unchecked((uint)0x1902),

    [NativeName("GL_RED")]
    Red = unchecked((uint)0x1903),

    [NativeName("GL_GREEN")]
    Green = unchecked((uint)0x1904),

    [NativeName("GL_BLUE")]
    Blue = unchecked((uint)0x1905),

    [NativeName("GL_POINT")]
    Point = unchecked((uint)0x1B00),

    [NativeName("GL_LINE")]
    Line = unchecked((uint)0x1B01),

    [NativeName("GL_FILL")]
    Fill = unchecked((uint)0x1B02),

    [NativeName("GL_CURRENT_BIT")]
    CurrentBit = unchecked((uint)0x00000001),

    [NativeName("GL_POINT_BIT")]
    PointBit = unchecked((uint)0x00000002),

    [NativeName("GL_LINE_BIT")]
    LineBit = unchecked((uint)0x00000004),

    [NativeName("GL_POLYGON_BIT")]
    PolygonBit = unchecked((uint)0x00000008),

    [NativeName("GL_POLYGON_STIPPLE_BIT")]
    PolygonStippleBit = unchecked((uint)0x00000010),

    [NativeName("GL_PIXEL_MODE_BIT")]
    PixelModeBit = unchecked((uint)0x00000020),

    [NativeName("GL_LIGHTING_BIT")]
    LightingBit = unchecked((uint)0x00000040),

    [NativeName("GL_FOG_BIT")]
    FogBit = unchecked((uint)0x00000080),

    [NativeName("GL_ACCUM_BUFFER_BIT")]
    AccumBufferBit = unchecked((uint)0x00000200),

    [NativeName("GL_VIEWPORT_BIT")]
    ViewportBit = unchecked((uint)0x00000800),

    [NativeName("GL_TRANSFORM_BIT")]
    TransformBit = unchecked((uint)0x00001000),

    [NativeName("GL_ENABLE_BIT")]
    EnableBit = unchecked((uint)0x00002000),

    [NativeName("GL_HINT_BIT")]
    HintBit = unchecked((uint)0x00008000),

    [NativeName("GL_EVAL_BIT")]
    EvalBit = unchecked((uint)0x00010000),

    [NativeName("GL_LIST_BIT")]
    ListBit = unchecked((uint)0x00020000),

    [NativeName("GL_TEXTURE_BIT")]
    TextureBit = unchecked((uint)0x00040000),

    [NativeName("GL_SCISSOR_BIT")]
    ScissorBit = unchecked((uint)0x00080000),

    [NativeName("GL_ALL_ATTRIB_BITS")]
    AllAttribBits = unchecked((uint)0xFFFFFFFF),

    [NativeName("GL_QUAD_STRIP")]
    QuadStrip = unchecked((uint)0x0008),

    [NativeName("GL_POLYGON")]
    Polygon = unchecked((uint)0x0009),

    [NativeName("GL_ACCUM")]
    Accum = unchecked((uint)0x0100),

    [NativeName("GL_LOAD")]
    Load = unchecked((uint)0x0101),

    [NativeName("GL_RETURN")]
    Return = unchecked((uint)0x0102),

    [NativeName("GL_MULT")]
    Mult = unchecked((uint)0x0103),

    [NativeName("GL_AUX0")]
    Aux0 = unchecked((uint)0x0409),

    [NativeName("GL_AUX1")]
    Aux1 = unchecked((uint)0x040A),

    [NativeName("GL_AUX2")]
    Aux2 = unchecked((uint)0x040B),

    [NativeName("GL_AUX3")]
    Aux3 = unchecked((uint)0x040C),

    [NativeName("GL_2D")]
    X2D = unchecked((uint)0x0600),

    [NativeName("GL_3D")]
    X3D = unchecked((uint)0x0601),

    [NativeName("GL_3D_COLOR")]
    X3DColor = unchecked((uint)0x0602),

    [NativeName("GL_3D_COLOR_TEXTURE")]
    X3DColorTexture = unchecked((uint)0x0603),

    [NativeName("GL_4D_COLOR_TEXTURE")]
    X4DColorTexture = unchecked((uint)0x0604),

    [NativeName("GL_PASS_THROUGH_TOKEN")]
    PassThroughToken = unchecked((uint)0x0700),

    [NativeName("GL_POINT_TOKEN")]
    PointToken = unchecked((uint)0x0701),

    [NativeName("GL_LINE_TOKEN")]
    LineToken = unchecked((uint)0x0702),

    [NativeName("GL_POLYGON_TOKEN")]
    PolygonToken = unchecked((uint)0x0703),

    [NativeName("GL_BITMAP_TOKEN")]
    BitmapToken = unchecked((uint)0x0704),

    [NativeName("GL_DRAW_PIXEL_TOKEN")]
    DrawPixelToken = unchecked((uint)0x0705),

    [NativeName("GL_COPY_PIXEL_TOKEN")]
    CopyPixelToken = unchecked((uint)0x0706),

    [NativeName("GL_LINE_RESET_TOKEN")]
    LineResetToken = unchecked((uint)0x0707),

    [NativeName("GL_COEFF")]
    Coeff = unchecked((uint)0x0A00),

    [NativeName("GL_ORDER")]
    Order = unchecked((uint)0x0A01),

    [NativeName("GL_DOMAIN")]
    Domain = unchecked((uint)0x0A02),

    [NativeName("GL_PIXEL_MAP_I_TO_I")]
    PixelMapIToI = unchecked((uint)0x0C70),

    [NativeName("GL_PIXEL_MAP_S_TO_S")]
    PixelMapSToS = unchecked((uint)0x0C71),

    [NativeName("GL_PIXEL_MAP_I_TO_R")]
    PixelMapIToR = unchecked((uint)0x0C72),

    [NativeName("GL_PIXEL_MAP_I_TO_G")]
    PixelMapIToG = unchecked((uint)0x0C73),

    [NativeName("GL_PIXEL_MAP_I_TO_B")]
    PixelMapIToB = unchecked((uint)0x0C74),

    [NativeName("GL_PIXEL_MAP_I_TO_A")]
    PixelMapIToA = unchecked((uint)0x0C75),

    [NativeName("GL_PIXEL_MAP_R_TO_R")]
    PixelMapRToR = unchecked((uint)0x0C76),

    [NativeName("GL_PIXEL_MAP_G_TO_G")]
    PixelMapGToG = unchecked((uint)0x0C77),

    [NativeName("GL_PIXEL_MAP_B_TO_B")]
    PixelMapBToB = unchecked((uint)0x0C78),

    [NativeName("GL_PIXEL_MAP_A_TO_A")]
    PixelMapAToA = unchecked((uint)0x0C79),

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

    [NativeName("GL_TEXTURE_GEN")]
    TextureGen = unchecked((uint)0x0C61),

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

    [NativeName("GL_TEXTURE_COMPONENTS")]
    TextureComponents = unchecked((uint)0x1003),

    [NativeName("GL_TEXTURE_BORDER")]
    TextureBorder = unchecked((uint)0x1005),

    [NativeName("GL_COMPILE")]
    Compile = unchecked((uint)0x1300),

    [NativeName("GL_COMPILE_AND_EXECUTE")]
    CompileAndExecute = unchecked((uint)0x1301),

    [NativeName("GL_2_BYTES")]
    X2Bytes = unchecked((uint)0x1407),

    [NativeName("GL_3_BYTES")]
    X3Bytes = unchecked((uint)0x1408),

    [NativeName("GL_4_BYTES")]
    X4Bytes = unchecked((uint)0x1409),

    [NativeName("GL_COLOR_INDEXES")]
    ColorIndexes = unchecked((uint)0x1603),

    [NativeName("GL_COLOR_INDEX")]
    ColorIndex = unchecked((uint)0x1900),

    [NativeName("GL_BITMAP")]
    Bitmap = unchecked((uint)0x1A00),

    [NativeName("GL_RENDER")]
    Render = unchecked((uint)0x1C00),

    [NativeName("GL_FEEDBACK")]
    Feedback = unchecked((uint)0x1C01),

    [NativeName("GL_SELECT")]
    Select = unchecked((uint)0x1C02),

    [NativeName("GL_S")]
    S = unchecked((uint)0x2000),

    [NativeName("GL")]
    Gl = unchecked((uint)0x2001),

    [NativeName("GL_R")]
    R = unchecked((uint)0x2002),

    [NativeName("GL_Q")]
    Q = unchecked((uint)0x2003),

    [NativeName("GL_EYE_LINEAR")]
    EyeLinear = unchecked((uint)0x2400),

    [NativeName("GL_OBJECT_LINEAR")]
    ObjectLinear = unchecked((uint)0x2401),

    [NativeName("GL_SPHERE_MAP")]
    SphereMap = unchecked((uint)0x2402),

    [NativeName("GL_TEXTURE_GEN_MODE")]
    TextureGenMode = unchecked((uint)0x2500),

    [NativeName("GL_OBJECT_PLANE")]
    ObjectPlane = unchecked((uint)0x2501),

    [NativeName("GL_EYE_PLANE")]
    EyePlane = unchecked((uint)0x2502),

    [NativeName("GL_CLAMP")]
    Clamp = unchecked((uint)0x2900),

    [NativeName("GL_POLYGON_OFFSET_POINT")]
    PolygonOffsetPoint = unchecked((uint)0x2A01),

    [NativeName("GL_POLYGON_OFFSET_LINE")]
    PolygonOffsetLine = unchecked((uint)0x2A02),

    [NativeName("GL_TEXTURE_BINDING_1D")]
    TextureBinding1D = unchecked((uint)0x8068),

    [NativeName("GL_TEXTURE_INTERNAL_FORMAT")]
    TextureInternalFormat = unchecked((uint)0x1003),

    [NativeName("GL_TEXTURE_RED_SIZE")]
    TextureRedSize = unchecked((uint)0x805C),

    [NativeName("GL_TEXTURE_GREEN_SIZE")]
    TextureGreenSize = unchecked((uint)0x805D),

    [NativeName("GL_TEXTURE_BLUE_SIZE")]
    TextureBlueSize = unchecked((uint)0x805E),

    [NativeName("GL_TEXTURE_ALPHA_SIZE")]
    TextureAlphaSize = unchecked((uint)0x805F),

    [NativeName("GL_DOUBLE")]
    Double = unchecked((uint)0x140A),

    [NativeName("GL_PROXY_TEXTURE_1D")]
    ProxyTexture1D = unchecked((uint)0x8063),

    [NativeName("GL_PROXY_TEXTURE_2D")]
    ProxyTexture2D = unchecked((uint)0x8064),

    [NativeName("GL_R3_G3_B2")]
    R3G3B2 = unchecked((uint)0x2A10),

    [NativeName("GL_RGB4")]
    Rgb4 = unchecked((uint)0x804F),

    [NativeName("GL_RGB5")]
    Rgb5 = unchecked((uint)0x8050),

    [NativeName("GL_RGB8")]
    Rgb8 = unchecked((uint)0x8051),

    [NativeName("GL_RGB10")]
    Rgb10 = unchecked((uint)0x8052),

    [NativeName("GL_RGB12")]
    Rgb12 = unchecked((uint)0x8053),

    [NativeName("GL_RGB16")]
    Rgb16 = unchecked((uint)0x8054),

    [NativeName("GL_RGBA2")]
    Rgba2 = unchecked((uint)0x8055),

    [NativeName("GL_RGBA4")]
    Rgba4 = unchecked((uint)0x8056),

    [NativeName("GL_RGB5_A1")]
    Rgb5A1 = unchecked((uint)0x8057),

    [NativeName("GL_RGBA8")]
    Rgba8 = unchecked((uint)0x8058),

    [NativeName("GL_RGB10_A2")]
    Rgb10A2 = unchecked((uint)0x8059),

    [NativeName("GL_RGBA12")]
    Rgba12 = unchecked((uint)0x805A),

    [NativeName("GL_RGBA16")]
    Rgba16 = unchecked((uint)0x805B),

    [NativeName("GL_CLIENT_PIXEL_STORE_BIT")]
    ClientPixelStoreBit = unchecked((uint)0x00000001),

    [NativeName("GL_CLIENT_VERTEX_ARRAY_BIT")]
    ClientVertexArrayBit = unchecked((uint)0x00000002),

    [NativeName("GL_CLIENT_ALL_ATTRIB_BITS")]
    ClientAllAttribBits = unchecked((uint)0xFFFFFFFF),

    [NativeName("GL_INDEX_ARRAY_POINTER")]
    IndexArrayPointer = unchecked((uint)0x8091),

    [NativeName("GL_EDGE_FLAG_ARRAY_POINTER")]
    EdgeFlagArrayPointer = unchecked((uint)0x8093),

    [NativeName("GL_FEEDBACK_BUFFER_POINTER")]
    FeedbackBufferPointer = unchecked((uint)0x0DF0),

    [NativeName("GL_SELECTION_BUFFER_POINTER")]
    SelectionBufferPointer = unchecked((uint)0x0DF3),

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

    [NativeName("GL_TEXTURE_LUMINANCE_SIZE")]
    TextureLuminanceSize = unchecked((uint)0x8060),

    [NativeName("GL_TEXTURE_INTENSITY_SIZE")]
    TextureIntensitySize = unchecked((uint)0x8061),

    [NativeName("GL_TEXTURE_PRIORITY")]
    TexturePriority = unchecked((uint)0x8066),

    [NativeName("GL_TEXTURE_RESIDENT")]
    TextureResident = unchecked((uint)0x8067),

    [NativeName("GL_ALPHA4")]
    Alpha4 = unchecked((uint)0x803B),

    [NativeName("GL_ALPHA8")]
    Alpha8 = unchecked((uint)0x803C),

    [NativeName("GL_ALPHA12")]
    Alpha12 = unchecked((uint)0x803D),

    [NativeName("GL_ALPHA16")]
    Alpha16 = unchecked((uint)0x803E),

    [NativeName("GL_LUMINANCE4")]
    Luminance4 = unchecked((uint)0x803F),

    [NativeName("GL_LUMINANCE8")]
    Luminance8 = unchecked((uint)0x8040),

    [NativeName("GL_LUMINANCE12")]
    Luminance12 = unchecked((uint)0x8041),

    [NativeName("GL_LUMINANCE16")]
    Luminance16 = unchecked((uint)0x8042),

    [NativeName("GL_LUMINANCE4_ALPHA4")]
    Luminance4Alpha4 = unchecked((uint)0x8043),

    [NativeName("GL_LUMINANCE6_ALPHA2")]
    Luminance6Alpha2 = unchecked((uint)0x8044),

    [NativeName("GL_LUMINANCE8_ALPHA8")]
    Luminance8Alpha8 = unchecked((uint)0x8045),

    [NativeName("GL_LUMINANCE12_ALPHA4")]
    Luminance12Alpha4 = unchecked((uint)0x8046),

    [NativeName("GL_LUMINANCE12_ALPHA12")]
    Luminance12Alpha12 = unchecked((uint)0x8047),

    [NativeName("GL_LUMINANCE16_ALPHA16")]
    Luminance16Alpha16 = unchecked((uint)0x8048),

    [NativeName("GL_INTENSITY")]
    Intensity = unchecked((uint)0x8049),

    [NativeName("GL_INTENSITY4")]
    Intensity4 = unchecked((uint)0x804A),

    [NativeName("GL_INTENSITY8")]
    Intensity8 = unchecked((uint)0x804B),

    [NativeName("GL_INTENSITY12")]
    Intensity12 = unchecked((uint)0x804C),

    [NativeName("GL_INTENSITY16")]
    Intensity16 = unchecked((uint)0x804D),

    [NativeName("GL_V2F")]
    V2F = unchecked((uint)0x2A20),

    [NativeName("GL_V3F")]
    V3F = unchecked((uint)0x2A21),

    [NativeName("GL_C4UB_V2F")]
    C4UbV2F = unchecked((uint)0x2A22),

    [NativeName("GL_C4UB_V3F")]
    C4UbV3F = unchecked((uint)0x2A23),

    [NativeName("GL_C3F_V3F")]
    C3FV3F = unchecked((uint)0x2A24),

    [NativeName("GL_N3F_V3F")]
    N3FV3F = unchecked((uint)0x2A25),

    [NativeName("GL_C4F_N3F_V3F")]
    C4FN3FV3F = unchecked((uint)0x2A26),

    [NativeName("GL_T2F_V3F")]
    T2FV3F = unchecked((uint)0x2A27),

    [NativeName("GL_T4F_V4F")]
    T4FV4F = unchecked((uint)0x2A28),

    [NativeName("GL_T2F_C4UB_V3F")]
    T2FC4UbV3F = unchecked((uint)0x2A29),

    [NativeName("GL_T2F_C3F_V3F")]
    T2FC3FV3F = unchecked((uint)0x2A2A),

    [NativeName("GL_T2F_N3F_V3F")]
    T2FN3FV3F = unchecked((uint)0x2A2B),

    [NativeName("GL_T2F_C4F_N3F_V3F")]
    T2FC4FN3FV3F = unchecked((uint)0x2A2C),

    [NativeName("GL_T4F_C4F_N3F_V4F")]
    T4FC4FN3FV4F = unchecked((uint)0x2A2D),

    [NativeName("GL_UNSIGNED_BYTE_3_3_2")]
    UnsignedByte3X3X2 = unchecked((uint)0x8032),

    [NativeName("GL_UNSIGNED_INT_8_8_8_8")]
    UnsignedInt8X8X8X8 = unchecked((uint)0x8035),

    [NativeName("GL_UNSIGNED_INT_10_10_10_2")]
    UnsignedInt10X10X10X2 = unchecked((uint)0x8036),

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

    [NativeName("GL_TEXTURE_3D")]
    Texture3D = unchecked((uint)0x806F),

    [NativeName("GL_PROXY_TEXTURE_3D")]
    ProxyTexture3D = unchecked((uint)0x8070),

    [NativeName("GL_TEXTURE_DEPTH")]
    TextureDepth = unchecked((uint)0x8071),

    [NativeName("GL_TEXTURE_WRAP_R")]
    TextureWrapR = unchecked((uint)0x8072),

    [NativeName("GL_MAX_3D_TEXTURE_SIZE")]
    Max3DTextureSize = unchecked((uint)0x8073),

    [NativeName("GL_UNSIGNED_BYTE_2_3_3_REV")]
    UnsignedByte2X3X3Rev = unchecked((uint)0x8362),

    [NativeName("GL_UNSIGNED_SHORT_5_6_5_REV")]
    UnsignedShort5X6X5Rev = unchecked((uint)0x8364),

    [NativeName("GL_UNSIGNED_SHORT_4_4_4_4_REV")]
    UnsignedShort4X4X4X4Rev = unchecked((uint)0x8365),

    [NativeName("GL_UNSIGNED_SHORT_1_5_5_5_REV")]
    UnsignedShort1X5X5X5Rev = unchecked((uint)0x8366),

    [NativeName("GL_UNSIGNED_INT_8_8_8_8_REV")]
    UnsignedInt8X8X8X8Rev = unchecked((uint)0x8367),

    [NativeName("GL_UNSIGNED_INT_2_10_10_10_REV")]
    UnsignedInt2X10X10X10Rev = unchecked((uint)0x8368),

    [NativeName("GL_BGR")]
    Bgr = unchecked((uint)0x80E0),

    [NativeName("GL_BGRA")]
    Bgra = unchecked((uint)0x80E1),

    [NativeName("GL_MAX_ELEMENTS_VERTICES")]
    MaxElementsVertices = unchecked((uint)0x80E8),

    [NativeName("GL_MAX_ELEMENTS_INDICES")]
    MaxElementsIndices = unchecked((uint)0x80E9),

    [NativeName("GL_TEXTURE_MIN_LOD")]
    TextureMinLod = unchecked((uint)0x813A),

    [NativeName("GL_TEXTURE_MAX_LOD")]
    TextureMaxLod = unchecked((uint)0x813B),

    [NativeName("GL_TEXTURE_BASE_LEVEL")]
    TextureBaseLevel = unchecked((uint)0x813C),

    [NativeName("GL_TEXTURE_MAX_LEVEL")]
    TextureMaxLevel = unchecked((uint)0x813D),

    [NativeName("GL_SMOOTH_POINT_SIZE_GRANULARITY")]
    SmoothPointSizeGranularity = unchecked((uint)0x0B13),

    [NativeName("GL_SMOOTH_LINE_WIDTH_GRANULARITY")]
    SmoothLineWidthGranularity = unchecked((uint)0x0B23),

    [NativeName("GL_LIGHT_MODEL_COLOR_CONTROL")]
    LightModelColorControl = unchecked((uint)0x81F8),

    [NativeName("GL_SINGLE_COLOR")]
    SingleColor = unchecked((uint)0x81F9),

    [NativeName("GL_SEPARATE_SPECULAR_COLOR")]
    SeparateSpecularColor = unchecked((uint)0x81FA),

    [NativeName("GL_TEXTURE_CUBE_MAP")]
    TextureCubeMap = unchecked((uint)0x8513),

    [NativeName("GL_TEXTURE_BINDING_CUBE_MAP")]
    TextureBindingCubeMap = unchecked((uint)0x8514),

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_X")]
    TextureCubeMapPositiveX = unchecked((uint)0x8515),

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_X")]
    TextureCubeMapNegativeX = unchecked((uint)0x8516),

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Y")]
    TextureCubeMapPositiveY = unchecked((uint)0x8517),

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Y")]
    TextureCubeMapNegativeY = unchecked((uint)0x8518),

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Z")]
    TextureCubeMapPositiveZ = unchecked((uint)0x8519),

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Z")]
    TextureCubeMapNegativeZ = unchecked((uint)0x851A),

    [NativeName("GL_PROXY_TEXTURE_CUBE_MAP")]
    ProxyTextureCubeMap = unchecked((uint)0x851B),

    [NativeName("GL_MAX_CUBE_MAP_TEXTURE_SIZE")]
    MaxCubeMapTextureSize = unchecked((uint)0x851C),

    [NativeName("GL_COMPRESSED_RGB")]
    CompressedRgb = unchecked((uint)0x84ED),

    [NativeName("GL_COMPRESSED_RGBA")]
    CompressedRgba = unchecked((uint)0x84EE),

    [NativeName("GL_TEXTURE_COMPRESSION_HINT")]
    TextureCompressionHint = unchecked((uint)0x84EF),

    [NativeName("GL_TEXTURE_COMPRESSED_IMAGE_SIZE")]
    TextureCompressedImageSize = unchecked((uint)0x86A0),

    [NativeName("GL_TEXTURE_COMPRESSED")]
    TextureCompressed = unchecked((uint)0x86A1),

    [NativeName("GL_CLAMP_TO_BORDER")]
    ClampToBorder = unchecked((uint)0x812D),

    [NativeName("GL_TRANSPOSE_MODELVIEW_MATRIX")]
    TransposeModelviewMatrix = unchecked((uint)0x84E3),

    [NativeName("GL_TRANSPOSE_PROJECTION_MATRIX")]
    TransposeProjectionMatrix = unchecked((uint)0x84E4),

    [NativeName("GL_TRANSPOSE_TEXTURE_MATRIX")]
    TransposeTextureMatrix = unchecked((uint)0x84E5),

    [NativeName("GL_TRANSPOSE_COLOR_MATRIX")]
    TransposeColorMatrix = unchecked((uint)0x84E6),

    [NativeName("GL_MULTISAMPLE_BIT")]
    MultisampleBit = unchecked((uint)0x20000000),

    [NativeName("GL_NORMAL_MAP")]
    NormalMap = unchecked((uint)0x8511),

    [NativeName("GL_REFLECTION_MAP")]
    ReflectionMap = unchecked((uint)0x8512),

    [NativeName("GL_COMPRESSED_ALPHA")]
    CompressedAlpha = unchecked((uint)0x84E9),

    [NativeName("GL_COMPRESSED_LUMINANCE")]
    CompressedLuminance = unchecked((uint)0x84EA),

    [NativeName("GL_COMPRESSED_LUMINANCE_ALPHA")]
    CompressedLuminanceAlpha = unchecked((uint)0x84EB),

    [NativeName("GL_COMPRESSED_INTENSITY")]
    CompressedIntensity = unchecked((uint)0x84EC),

    [NativeName("GL_SOURCE0_RGB")]
    Source0Rgb = unchecked((uint)0x8580),

    [NativeName("GL_SOURCE1_RGB")]
    Source1Rgb = unchecked((uint)0x8581),

    [NativeName("GL_SOURCE2_RGB")]
    Source2Rgb = unchecked((uint)0x8582),

    [NativeName("GL_SOURCE0_ALPHA")]
    Source0Alpha = unchecked((uint)0x8588),

    [NativeName("GL_SOURCE1_ALPHA")]
    Source1Alpha = unchecked((uint)0x8589),

    [NativeName("GL_SOURCE2_ALPHA")]
    Source2Alpha = unchecked((uint)0x858A),

    [NativeName("GL_BLEND_DST_RGB")]
    BlendDstRgb = unchecked((uint)0x80C8),

    [NativeName("GL_BLEND_SRC_RGB")]
    BlendSrcRgb = unchecked((uint)0x80C9),

    [NativeName("GL_BLEND_DST_ALPHA")]
    BlendDstAlpha = unchecked((uint)0x80CA),

    [NativeName("GL_BLEND_SRC_ALPHA")]
    BlendSrcAlpha = unchecked((uint)0x80CB),

    [NativeName("GL_DEPTH_COMPONENT16")]
    DepthComponent16 = unchecked((uint)0x81A5),

    [NativeName("GL_DEPTH_COMPONENT24")]
    DepthComponent24 = unchecked((uint)0x81A6),

    [NativeName("GL_DEPTH_COMPONENT32")]
    DepthComponent32 = unchecked((uint)0x81A7),

    [NativeName("GL_MIRRORED_REPEAT")]
    MirroredRepeat = unchecked((uint)0x8370),

    [NativeName("GL_MAX_TEXTURE_LOD_BIAS")]
    MaxTextureLodBias = unchecked((uint)0x84FD),

    [NativeName("GL_TEXTURE_LOD_BIAS")]
    TextureLodBias = unchecked((uint)0x8501),

    [NativeName("GL_INCR_WRAP")]
    IncrWrap = unchecked((uint)0x8507),

    [NativeName("GL_DECR_WRAP")]
    DecrWrap = unchecked((uint)0x8508),

    [NativeName("GL_TEXTURE_DEPTH_SIZE")]
    TextureDepthSize = unchecked((uint)0x884A),

    [NativeName("GL_TEXTURE_COMPARE_MODE")]
    TextureCompareMode = unchecked((uint)0x884C),

    [NativeName("GL_TEXTURE_COMPARE_FUNC")]
    TextureCompareFunc = unchecked((uint)0x884D),

    [NativeName("GL_FOG_COORDINATE_SOURCE")]
    FogCoordinateSource = unchecked((uint)0x8450),

    [NativeName("GL_FOG_COORDINATE")]
    FogCoordinate = unchecked((uint)0x8451),

    [NativeName("GL_FRAGMENT_DEPTH")]
    FragmentDepth = unchecked((uint)0x8452),

    [NativeName("GL_CURRENT_FOG_COORDINATE")]
    CurrentFogCoordinate = unchecked((uint)0x8453),

    [NativeName("GL_FOG_COORDINATE_ARRAY_TYPE")]
    FogCoordinateArrayType = unchecked((uint)0x8454),

    [NativeName("GL_FOG_COORDINATE_ARRAY_STRIDE")]
    FogCoordinateArrayStride = unchecked((uint)0x8455),

    [NativeName("GL_FOG_COORDINATE_ARRAY_POINTER")]
    FogCoordinateArrayPointer = unchecked((uint)0x8456),

    [NativeName("GL_FOG_COORDINATE_ARRAY")]
    FogCoordinateArray = unchecked((uint)0x8457),

    [NativeName("GL_COLOR_SUM")]
    ColorSum = unchecked((uint)0x8458),

    [NativeName("GL_CURRENT_SECONDARY_COLOR")]
    CurrentSecondaryColor = unchecked((uint)0x8459),

    [NativeName("GL_SECONDARY_COLOR_ARRAY_SIZE")]
    SecondaryColorArraySize = unchecked((uint)0x845A),

    [NativeName("GL_SECONDARY_COLOR_ARRAY_TYPE")]
    SecondaryColorArrayType = unchecked((uint)0x845B),

    [NativeName("GL_SECONDARY_COLOR_ARRAY_STRIDE")]
    SecondaryColorArrayStride = unchecked((uint)0x845C),

    [NativeName("GL_SECONDARY_COLOR_ARRAY_POINTER")]
    SecondaryColorArrayPointer = unchecked((uint)0x845D),

    [NativeName("GL_SECONDARY_COLOR_ARRAY")]
    SecondaryColorArray = unchecked((uint)0x845E),

    [NativeName("GL_TEXTURE_FILTER_CONTROL")]
    TextureFilterControl = unchecked((uint)0x8500),

    [NativeName("GL_DEPTH_TEXTURE_MODE")]
    DepthTextureMode = unchecked((uint)0x884B),

    [NativeName("GL_COMPARE_R_TO_TEXTURE")]
    CompareRToTexture = unchecked((uint)0x884E),

    [NativeName("GL_BLEND_COLOR")]
    BlendColor = unchecked((uint)0x8005),

    [NativeName("GL_BLEND_EQUATION")]
    BlendEquation = unchecked((uint)0x8009),

    [NativeName("GL_CONSTANT_COLOR")]
    ConstantColor = unchecked((uint)0x8001),

    [NativeName("GL_ONE_MINUS_CONSTANT_COLOR")]
    OneMinusConstantColor = unchecked((uint)0x8002),

    [NativeName("GL_CONSTANT_ALPHA")]
    ConstantAlpha = unchecked((uint)0x8003),

    [NativeName("GL_ONE_MINUS_CONSTANT_ALPHA")]
    OneMinusConstantAlpha = unchecked((uint)0x8004),

    [NativeName("GL_FUNC_ADD")]
    FuncAdd = unchecked((uint)0x8006),

    [NativeName("GL_FUNC_REVERSE_SUBTRACT")]
    FuncReverseSubtract = unchecked((uint)0x800B),

    [NativeName("GL_FUNC_SUBTRACT")]
    FuncSubtract = unchecked((uint)0x800A),

    [NativeName("GL_MIN")]
    Min = unchecked((uint)0x8007),

    [NativeName("GL_MAX")]
    Max = unchecked((uint)0x8008),

    [NativeName("GL_QUERY_COUNTER_BITS")]
    QueryCounterBits = unchecked((uint)0x8864),

    [NativeName("GL_CURRENT_QUERY")]
    CurrentQuery = unchecked((uint)0x8865),

    [NativeName("GL_QUERY_RESULT")]
    QueryResult = unchecked((uint)0x8866),

    [NativeName("GL_QUERY_RESULT_AVAILABLE")]
    QueryResultAvailable = unchecked((uint)0x8867),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING")]
    VertexAttribArrayBufferBinding = unchecked((uint)0x889F),

    [NativeName("GL_READ_ONLY")]
    ReadOnly = unchecked((uint)0x88B8),

    [NativeName("GL_WRITE_ONLY")]
    WriteOnly = unchecked((uint)0x88B9),

    [NativeName("GL_READ_WRITE")]
    ReadWrite = unchecked((uint)0x88BA),

    [NativeName("GL_BUFFER_ACCESS")]
    BufferAccess = unchecked((uint)0x88BB),

    [NativeName("GL_BUFFER_MAPPED")]
    BufferMapped = unchecked((uint)0x88BC),

    [NativeName("GL_BUFFER_MAP_POINTER")]
    BufferMapPointer = unchecked((uint)0x88BD),

    [NativeName("GL_STREAM_DRAW")]
    StreamDraw = unchecked((uint)0x88E0),

    [NativeName("GL_STREAM_READ")]
    StreamRead = unchecked((uint)0x88E1),

    [NativeName("GL_STREAM_COPY")]
    StreamCopy = unchecked((uint)0x88E2),

    [NativeName("GL_STATIC_READ")]
    StaticRead = unchecked((uint)0x88E5),

    [NativeName("GL_STATIC_COPY")]
    StaticCopy = unchecked((uint)0x88E6),

    [NativeName("GL_DYNAMIC_READ")]
    DynamicRead = unchecked((uint)0x88E9),

    [NativeName("GL_DYNAMIC_COPY")]
    DynamicCopy = unchecked((uint)0x88EA),

    [NativeName("GL_SAMPLES_PASSED")]
    SamplesPassed = unchecked((uint)0x8914),

    [NativeName("GL_INDEX_ARRAY_BUFFER_BINDING")]
    IndexArrayBufferBinding = unchecked((uint)0x8899),

    [NativeName("GL_EDGE_FLAG_ARRAY_BUFFER_BINDING")]
    EdgeFlagArrayBufferBinding = unchecked((uint)0x889B),

    [NativeName("GL_SECONDARY_COLOR_ARRAY_BUFFER_BINDING")]
    SecondaryColorArrayBufferBinding = unchecked((uint)0x889C),

    [NativeName("GL_FOG_COORDINATE_ARRAY_BUFFER_BINDING")]
    FogCoordinateArrayBufferBinding = unchecked((uint)0x889D),

    [NativeName("GL_WEIGHT_ARRAY_BUFFER_BINDING")]
    WeightArrayBufferBinding = unchecked((uint)0x889E),

    [NativeName("GL_FOG_COORD_SRC")]
    FogCoordSrc = unchecked((uint)0x8450),

    [NativeName("GL_FOG_COORD")]
    FogCoord = unchecked((uint)0x8451),

    [NativeName("GL_CURRENT_FOG_COORD")]
    CurrentFogCoord = unchecked((uint)0x8453),

    [NativeName("GL_FOG_COORD_ARRAY_TYPE")]
    FogCoordArrayType = unchecked((uint)0x8454),

    [NativeName("GL_FOG_COORD_ARRAY_STRIDE")]
    FogCoordArrayStride = unchecked((uint)0x8455),

    [NativeName("GL_FOG_COORD_ARRAY_POINTER")]
    FogCoordArrayPointer = unchecked((uint)0x8456),

    [NativeName("GL_FOG_COORD_ARRAY")]
    FogCoordArray = unchecked((uint)0x8457),

    [NativeName("GL_FOG_COORD_ARRAY_BUFFER_BINDING")]
    FogCoordArrayBufferBinding = unchecked((uint)0x889D),

    [NativeName("GL_BLEND_EQUATION_RGB")]
    BlendEquationRgb = unchecked((uint)0x8009),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_ENABLED")]
    VertexAttribArrayEnabled = unchecked((uint)0x8622),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_SIZE")]
    VertexAttribArraySize = unchecked((uint)0x8623),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_STRIDE")]
    VertexAttribArrayStride = unchecked((uint)0x8624),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_TYPE")]
    VertexAttribArrayType = unchecked((uint)0x8625),

    [NativeName("GL_CURRENT_VERTEX_ATTRIB")]
    CurrentVertexAttrib = unchecked((uint)0x8626),

    [NativeName("GL_VERTEX_PROGRAM_POINT_SIZE")]
    VertexProgramPointSize = unchecked((uint)0x8642),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_POINTER")]
    VertexAttribArrayPointer = unchecked((uint)0x8645),

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

    [NativeName("GL_DRAW_BUFFER0")]
    DrawBuffer0 = unchecked((uint)0x8825),

    [NativeName("GL_DRAW_BUFFER1")]
    DrawBuffer1 = unchecked((uint)0x8826),

    [NativeName("GL_DRAW_BUFFER2")]
    DrawBuffer2 = unchecked((uint)0x8827),

    [NativeName("GL_DRAW_BUFFER3")]
    DrawBuffer3 = unchecked((uint)0x8828),

    [NativeName("GL_DRAW_BUFFER4")]
    DrawBuffer4 = unchecked((uint)0x8829),

    [NativeName("GL_DRAW_BUFFER5")]
    DrawBuffer5 = unchecked((uint)0x882A),

    [NativeName("GL_DRAW_BUFFER6")]
    DrawBuffer6 = unchecked((uint)0x882B),

    [NativeName("GL_DRAW_BUFFER7")]
    DrawBuffer7 = unchecked((uint)0x882C),

    [NativeName("GL_DRAW_BUFFER8")]
    DrawBuffer8 = unchecked((uint)0x882D),

    [NativeName("GL_DRAW_BUFFER9")]
    DrawBuffer9 = unchecked((uint)0x882E),

    [NativeName("GL_DRAW_BUFFER10")]
    DrawBuffer10 = unchecked((uint)0x882F),

    [NativeName("GL_DRAW_BUFFER11")]
    DrawBuffer11 = unchecked((uint)0x8830),

    [NativeName("GL_DRAW_BUFFER12")]
    DrawBuffer12 = unchecked((uint)0x8831),

    [NativeName("GL_DRAW_BUFFER13")]
    DrawBuffer13 = unchecked((uint)0x8832),

    [NativeName("GL_DRAW_BUFFER14")]
    DrawBuffer14 = unchecked((uint)0x8833),

    [NativeName("GL_DRAW_BUFFER15")]
    DrawBuffer15 = unchecked((uint)0x8834),

    [NativeName("GL_BLEND_EQUATION_ALPHA")]
    BlendEquationAlpha = unchecked((uint)0x883D),

    [NativeName("GL_MAX_VERTEX_ATTRIBS")]
    MaxVertexAttribs = unchecked((uint)0x8869),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_NORMALIZED")]
    VertexAttribArrayNormalized = unchecked((uint)0x886A),

    [NativeName("GL_MAX_TEXTURE_IMAGE_UNITS")]
    MaxTextureImageUnits = unchecked((uint)0x8872),

    [NativeName("GL_FRAGMENT_SHADER")]
    FragmentShader = unchecked((uint)0x8B30),

    [NativeName("GL_VERTEX_SHADER")]
    VertexShader = unchecked((uint)0x8B31),

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

    [NativeName("GL_SHADER_TYPE")]
    ShaderType = unchecked((uint)0x8B4F),

    [NativeName("GL_FLOAT_VEC2")]
    FloatVec2 = unchecked((uint)0x8B50),

    [NativeName("GL_FLOAT_VEC3")]
    FloatVec3 = unchecked((uint)0x8B51),

    [NativeName("GL_FLOAT_VEC4")]
    FloatVec4 = unchecked((uint)0x8B52),

    [NativeName("GL_INT_VEC2")]
    IntVec2 = unchecked((uint)0x8B53),

    [NativeName("GL_INT_VEC3")]
    IntVec3 = unchecked((uint)0x8B54),

    [NativeName("GL_INT_VEC4")]
    IntVec4 = unchecked((uint)0x8B55),

    [NativeName("GL_BOOL")]
    Bool = unchecked((uint)0x8B56),

    [NativeName("GL_BOOL_VEC2")]
    BoolVec2 = unchecked((uint)0x8B57),

    [NativeName("GL_BOOL_VEC3")]
    BoolVec3 = unchecked((uint)0x8B58),

    [NativeName("GL_BOOL_VEC4")]
    BoolVec4 = unchecked((uint)0x8B59),

    [NativeName("GL_FLOAT_MAT2")]
    FloatMat2 = unchecked((uint)0x8B5A),

    [NativeName("GL_FLOAT_MAT3")]
    FloatMat3 = unchecked((uint)0x8B5B),

    [NativeName("GL_FLOAT_MAT4")]
    FloatMat4 = unchecked((uint)0x8B5C),

    [NativeName("GL_SAMPLER_1D")]
    Sampler1D = unchecked((uint)0x8B5D),

    [NativeName("GL_SAMPLER_2D")]
    Sampler2D = unchecked((uint)0x8B5E),

    [NativeName("GL_SAMPLER_3D")]
    Sampler3D = unchecked((uint)0x8B5F),

    [NativeName("GL_SAMPLER_CUBE")]
    SamplerCube = unchecked((uint)0x8B60),

    [NativeName("GL_SAMPLER_1D_SHADOW")]
    Sampler1DShadow = unchecked((uint)0x8B61),

    [NativeName("GL_SAMPLER_2D_SHADOW")]
    Sampler2DShadow = unchecked((uint)0x8B62),

    [NativeName("GL_DELETE_STATUS")]
    DeleteStatus = unchecked((uint)0x8B80),

    [NativeName("GL_COMPILE_STATUS")]
    CompileStatus = unchecked((uint)0x8B81),

    [NativeName("GL_LINK_STATUS")]
    LinkStatus = unchecked((uint)0x8B82),

    [NativeName("GL_VALIDATE_STATUS")]
    ValidateStatus = unchecked((uint)0x8B83),

    [NativeName("GL_INFO_LOG_LENGTH")]
    InfoLogLength = unchecked((uint)0x8B84),

    [NativeName("GL_ATTACHED_SHADERS")]
    AttachedShaders = unchecked((uint)0x8B85),

    [NativeName("GL_ACTIVE_UNIFORMS")]
    ActiveUniforms = unchecked((uint)0x8B86),

    [NativeName("GL_ACTIVE_UNIFORM_MAX_LENGTH")]
    ActiveUniformMaxLength = unchecked((uint)0x8B87),

    [NativeName("GL_SHADER_SOURCE_LENGTH")]
    ShaderSourceLength = unchecked((uint)0x8B88),

    [NativeName("GL_ACTIVE_ATTRIBUTES")]
    ActiveAttributes = unchecked((uint)0x8B89),

    [NativeName("GL_ACTIVE_ATTRIBUTE_MAX_LENGTH")]
    ActiveAttributeMaxLength = unchecked((uint)0x8B8A),

    [NativeName("GL_FRAGMENT_SHADER_DERIVATIVE_HINT")]
    FragmentShaderDerivativeHint = unchecked((uint)0x8B8B),

    [NativeName("GL_SHADING_LANGUAGE_VERSION")]
    ShadingLanguageVersion = unchecked((uint)0x8B8C),

    [NativeName("GL_CURRENT_PROGRAM")]
    CurrentProgram = unchecked((uint)0x8B8D),

    [NativeName("GL_POINT_SPRITE_COORD_ORIGIN")]
    PointSpriteCoordOrigin = unchecked((uint)0x8CA0),

    [NativeName("GL_LOWER_LEFT")]
    LowerLeft = unchecked((uint)0x8CA1),

    [NativeName("GL_UPPER_LEFT")]
    UpperLeft = unchecked((uint)0x8CA2),

    [NativeName("GL_STENCIL_BACK_REF")]
    StencilBackRef = unchecked((uint)0x8CA3),

    [NativeName("GL_STENCIL_BACK_VALUE_MASK")]
    StencilBackValueMask = unchecked((uint)0x8CA4),

    [NativeName("GL_STENCIL_BACK_WRITEMASK")]
    StencilBackWritemask = unchecked((uint)0x8CA5),

    [NativeName("GL_VERTEX_PROGRAM_TWO_SIDE")]
    VertexProgramTwoSide = unchecked((uint)0x8643),

    [NativeName("GL_POINT_SPRITE")]
    PointSprite = unchecked((uint)0x8861),

    [NativeName("GL_COORD_REPLACE")]
    CoordReplace = unchecked((uint)0x8862),

    [NativeName("GL_MAX_TEXTURE_COORDS")]
    MaxTextureCoords = unchecked((uint)0x8871),

    [NativeName("GL_PIXEL_PACK_BUFFER")]
    PixelPackBuffer = unchecked((uint)0x88EB),

    [NativeName("GL_PIXEL_UNPACK_BUFFER")]
    PixelUnpackBuffer = unchecked((uint)0x88EC),

    [NativeName("GL_PIXEL_PACK_BUFFER_BINDING")]
    PixelPackBufferBinding = unchecked((uint)0x88ED),

    [NativeName("GL_PIXEL_UNPACK_BUFFER_BINDING")]
    PixelUnpackBufferBinding = unchecked((uint)0x88EF),

    [NativeName("GL_FLOAT_MAT2x3")]
    FloatMat2X3 = unchecked((uint)0x8B65),

    [NativeName("GL_FLOAT_MAT2x4")]
    FloatMat2X4 = unchecked((uint)0x8B66),

    [NativeName("GL_FLOAT_MAT3x2")]
    FloatMat3X2 = unchecked((uint)0x8B67),

    [NativeName("GL_FLOAT_MAT3x4")]
    FloatMat3X4 = unchecked((uint)0x8B68),

    [NativeName("GL_FLOAT_MAT4x2")]
    FloatMat4X2 = unchecked((uint)0x8B69),

    [NativeName("GL_FLOAT_MAT4x3")]
    FloatMat4X3 = unchecked((uint)0x8B6A),

    [NativeName("GL_SRGB")]
    Srgb = unchecked((uint)0x8C40),

    [NativeName("GL_SRGB8")]
    Srgb8 = unchecked((uint)0x8C41),

    [NativeName("GL_SRGB_ALPHA")]
    SrgbAlpha = unchecked((uint)0x8C42),

    [NativeName("GL_SRGB8_ALPHA8")]
    Srgb8Alpha8 = unchecked((uint)0x8C43),

    [NativeName("GL_COMPRESSED_SRGB")]
    CompressedSrgb = unchecked((uint)0x8C48),

    [NativeName("GL_COMPRESSED_SRGB_ALPHA")]
    CompressedSrgbAlpha = unchecked((uint)0x8C49),

    [NativeName("GL_CURRENT_RASTER_SECONDARY_COLOR")]
    CurrentRasterSecondaryColor = unchecked((uint)0x845F),

    [NativeName("GL_SLUMINANCE_ALPHA")]
    SluminanceAlpha = unchecked((uint)0x8C44),

    [NativeName("GL_SLUMINANCE8_ALPHA8")]
    Sluminance8Alpha8 = unchecked((uint)0x8C45),

    [NativeName("GL_SLUMINANCE")]
    Sluminance = unchecked((uint)0x8C46),

    [NativeName("GL_SLUMINANCE8")]
    Sluminance8 = unchecked((uint)0x8C47),

    [NativeName("GL_COMPRESSED_SLUMINANCE")]
    CompressedSluminance = unchecked((uint)0x8C4A),

    [NativeName("GL_COMPRESSED_SLUMINANCE_ALPHA")]
    CompressedSluminanceAlpha = unchecked((uint)0x8C4B),

    [NativeName("GL_COMPARE_REF_TO_TEXTURE")]
    CompareRefToTexture = unchecked((uint)0x884E),

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

    [NativeName("GL_COMPRESSED_RED")]
    CompressedRed = unchecked((uint)0x8225),

    [NativeName("GL_COMPRESSED_RG")]
    CompressedRg = unchecked((uint)0x8226),

    [NativeName("GL_CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT")]
    ContextFlagForwardCompatibleBit = unchecked((uint)0x00000001),

    [NativeName("GL_RGBA32F")]
    Rgba32F = unchecked((uint)0x8814),

    [NativeName("GL_RGB32F")]
    Rgb32F = unchecked((uint)0x8815),

    [NativeName("GL_RGBA16F")]
    Rgba16F = unchecked((uint)0x881A),

    [NativeName("GL_RGB16F")]
    Rgb16F = unchecked((uint)0x881B),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_INTEGER")]
    VertexAttribArrayInteger = unchecked((uint)0x88FD),

    [NativeName("GL_MAX_ARRAY_TEXTURE_LAYERS")]
    MaxArrayTextureLayers = unchecked((uint)0x88FF),

    [NativeName("GL_MIN_PROGRAM_TEXEL_OFFSET")]
    MinProgramTexelOffset = unchecked((uint)0x8904),

    [NativeName("GL_MAX_PROGRAM_TEXEL_OFFSET")]
    MaxProgramTexelOffset = unchecked((uint)0x8905),

    [NativeName("GL_CLAMP_READ_COLOR")]
    ClampReadColor = unchecked((uint)0x891C),

    [NativeName("GL_FIXED_ONLY")]
    FixedOnly = unchecked((uint)0x891D),

    [NativeName("GL_MAX_VARYING_COMPONENTS")]
    MaxVaryingComponents = unchecked((uint)0x8B4B),

    [NativeName("GL_TEXTURE_1D_ARRAY")]
    Texture1DArray = unchecked((uint)0x8C18),

    [NativeName("GL_PROXY_TEXTURE_1D_ARRAY")]
    ProxyTexture1DArray = unchecked((uint)0x8C19),

    [NativeName("GL_TEXTURE_2D_ARRAY")]
    Texture2DArray = unchecked((uint)0x8C1A),

    [NativeName("GL_PROXY_TEXTURE_2D_ARRAY")]
    ProxyTexture2DArray = unchecked((uint)0x8C1B),

    [NativeName("GL_TEXTURE_BINDING_1D_ARRAY")]
    TextureBinding1DArray = unchecked((uint)0x8C1C),

    [NativeName("GL_TEXTURE_BINDING_2D_ARRAY")]
    TextureBinding2DArray = unchecked((uint)0x8C1D),

    [NativeName("GL_R11F_G11F_B10F")]
    R11FG11FB10F = unchecked((uint)0x8C3A),

    [NativeName("GL_UNSIGNED_INT_10F_11F_11F_REV")]
    UnsignedInt10F11F11FRev = unchecked((uint)0x8C3B),

    [NativeName("GL_RGB9_E5")]
    Rgb9E5 = unchecked((uint)0x8C3D),

    [NativeName("GL_UNSIGNED_INT_5_9_9_9_REV")]
    UnsignedInt5X9X9X9Rev = unchecked((uint)0x8C3E),

    [NativeName("GL_TEXTURE_SHARED_SIZE")]
    TextureSharedSize = unchecked((uint)0x8C3F),

    [NativeName("GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH")]
    TransformFeedbackVaryingMaxLength = unchecked((uint)0x8C76),

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_MODE")]
    TransformFeedbackBufferMode = unchecked((uint)0x8C7F),

    [NativeName("GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS")]
    MaxTransformFeedbackSeparateComponents = unchecked((uint)0x8C80),

    [NativeName("GL_TRANSFORM_FEEDBACK_VARYINGS")]
    TransformFeedbackVaryings = unchecked((uint)0x8C83),

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_START")]
    TransformFeedbackBufferStart = unchecked((uint)0x8C84),

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_SIZE")]
    TransformFeedbackBufferSize = unchecked((uint)0x8C85),

    [NativeName("GL_PRIMITIVES_GENERATED")]
    PrimitivesGenerated = unchecked((uint)0x8C87),

    [NativeName("GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN")]
    TransformFeedbackPrimitivesWritten = unchecked((uint)0x8C88),

    [NativeName("GL_RASTERIZER_DISCARD")]
    RasterizerDiscard = unchecked((uint)0x8C89),

    [NativeName("GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS")]
    MaxTransformFeedbackInterleavedComponents = unchecked((uint)0x8C8A),

    [NativeName("GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS")]
    MaxTransformFeedbackSeparateAttribs = unchecked((uint)0x8C8B),

    [NativeName("GL_INTERLEAVED_ATTRIBS")]
    InterleavedAttribs = unchecked((uint)0x8C8C),

    [NativeName("GL_SEPARATE_ATTRIBS")]
    SeparateAttribs = unchecked((uint)0x8C8D),

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER")]
    TransformFeedbackBuffer = unchecked((uint)0x8C8E),

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_BINDING")]
    TransformFeedbackBufferBinding = unchecked((uint)0x8C8F),

    [NativeName("GL_RGBA32UI")]
    Rgba32Ui = unchecked((uint)0x8D70),

    [NativeName("GL_RGB32UI")]
    Rgb32Ui = unchecked((uint)0x8D71),

    [NativeName("GL_RGBA16UI")]
    Rgba16Ui = unchecked((uint)0x8D76),

    [NativeName("GL_RGB16UI")]
    Rgb16Ui = unchecked((uint)0x8D77),

    [NativeName("GL_RGBA8UI")]
    Rgba8Ui = unchecked((uint)0x8D7C),

    [NativeName("GL_RGB8UI")]
    Rgb8Ui = unchecked((uint)0x8D7D),

    [NativeName("GL_RGBA32I")]
    Rgba32I = unchecked((uint)0x8D82),

    [NativeName("GL_RGB32I")]
    Rgb32I = unchecked((uint)0x8D83),

    [NativeName("GL_RGBA16I")]
    Rgba16I = unchecked((uint)0x8D88),

    [NativeName("GL_RGB16I")]
    Rgb16I = unchecked((uint)0x8D89),

    [NativeName("GL_RGBA8I")]
    Rgba8I = unchecked((uint)0x8D8E),

    [NativeName("GL_RGB8I")]
    Rgb8I = unchecked((uint)0x8D8F),

    [NativeName("GL_RED_INTEGER")]
    RedInteger = unchecked((uint)0x8D94),

    [NativeName("GL_GREEN_INTEGER")]
    GreenInteger = unchecked((uint)0x8D95),

    [NativeName("GL_BLUE_INTEGER")]
    BlueInteger = unchecked((uint)0x8D96),

    [NativeName("GL_RGB_INTEGER")]
    RgbInteger = unchecked((uint)0x8D98),

    [NativeName("GL_RGBA_INTEGER")]
    RgbaInteger = unchecked((uint)0x8D99),

    [NativeName("GL_BGR_INTEGER")]
    BgrInteger = unchecked((uint)0x8D9A),

    [NativeName("GL_BGRA_INTEGER")]
    BgraInteger = unchecked((uint)0x8D9B),

    [NativeName("GL_SAMPLER_1D_ARRAY")]
    Sampler1DArray = unchecked((uint)0x8DC0),

    [NativeName("GL_SAMPLER_2D_ARRAY")]
    Sampler2DArray = unchecked((uint)0x8DC1),

    [NativeName("GL_SAMPLER_1D_ARRAY_SHADOW")]
    Sampler1DArrayShadow = unchecked((uint)0x8DC3),

    [NativeName("GL_SAMPLER_2D_ARRAY_SHADOW")]
    Sampler2DArrayShadow = unchecked((uint)0x8DC4),

    [NativeName("GL_SAMPLER_CUBE_SHADOW")]
    SamplerCubeShadow = unchecked((uint)0x8DC5),

    [NativeName("GL_UNSIGNED_INT_VEC2")]
    UnsignedIntVec2 = unchecked((uint)0x8DC6),

    [NativeName("GL_UNSIGNED_INT_VEC3")]
    UnsignedIntVec3 = unchecked((uint)0x8DC7),

    [NativeName("GL_UNSIGNED_INT_VEC4")]
    UnsignedIntVec4 = unchecked((uint)0x8DC8),

    [NativeName("GL_INT_SAMPLER_1D")]
    IntSampler1D = unchecked((uint)0x8DC9),

    [NativeName("GL_INT_SAMPLER_2D")]
    IntSampler2D = unchecked((uint)0x8DCA),

    [NativeName("GL_INT_SAMPLER_3D")]
    IntSampler3D = unchecked((uint)0x8DCB),

    [NativeName("GL_INT_SAMPLER_CUBE")]
    IntSamplerCube = unchecked((uint)0x8DCC),

    [NativeName("GL_INT_SAMPLER_1D_ARRAY")]
    IntSampler1DArray = unchecked((uint)0x8DCE),

    [NativeName("GL_INT_SAMPLER_2D_ARRAY")]
    IntSampler2DArray = unchecked((uint)0x8DCF),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_1D")]
    UnsignedIntSampler1D = unchecked((uint)0x8DD1),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_2D")]
    UnsignedIntSampler2D = unchecked((uint)0x8DD2),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_3D")]
    UnsignedIntSampler3D = unchecked((uint)0x8DD3),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_CUBE")]
    UnsignedIntSamplerCube = unchecked((uint)0x8DD4),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_1D_ARRAY")]
    UnsignedIntSampler1DArray = unchecked((uint)0x8DD6),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_2D_ARRAY")]
    UnsignedIntSampler2DArray = unchecked((uint)0x8DD7),

    [NativeName("GL_QUERY_WAIT")]
    QueryWait = unchecked((uint)0x8E13),

    [NativeName("GL_QUERY_NO_WAIT")]
    QueryNoWait = unchecked((uint)0x8E14),

    [NativeName("GL_QUERY_BY_REGION_WAIT")]
    QueryByRegionWait = unchecked((uint)0x8E15),

    [NativeName("GL_QUERY_BY_REGION_NO_WAIT")]
    QueryByRegionNoWait = unchecked((uint)0x8E16),

    [NativeName("GL_BUFFER_ACCESS_FLAGS")]
    BufferAccessFlags = unchecked((uint)0x911F),

    [NativeName("GL_BUFFER_MAP_LENGTH")]
    BufferMapLength = unchecked((uint)0x9120),

    [NativeName("GL_BUFFER_MAP_OFFSET")]
    BufferMapOffset = unchecked((uint)0x9121),

    [NativeName("GL_DEPTH_COMPONENT32F")]
    DepthComponent32F = unchecked((uint)0x8CAC),

    [NativeName("GL_DEPTH32F_STENCIL8")]
    Depth32FStencil8 = unchecked((uint)0x8CAD),

    [NativeName("GL_FLOAT_32_UNSIGNED_INT_24_8_REV")]
    Float32UnsignedInt24X8Rev = unchecked((uint)0x8DAD),

    [NativeName("GL_INVALID_FRAMEBUFFER_OPERATION")]
    InvalidFramebufferOperation = unchecked((uint)0x0506),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING")]
    FramebufferAttachmentColorEncoding = unchecked((uint)0x8210),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE")]
    FramebufferAttachmentComponentType = unchecked((uint)0x8211),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE")]
    FramebufferAttachmentRedSize = unchecked((uint)0x8212),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE")]
    FramebufferAttachmentGreenSize = unchecked((uint)0x8213),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE")]
    FramebufferAttachmentBlueSize = unchecked((uint)0x8214),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE")]
    FramebufferAttachmentAlphaSize = unchecked((uint)0x8215),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE")]
    FramebufferAttachmentDepthSize = unchecked((uint)0x8216),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE")]
    FramebufferAttachmentStencilSize = unchecked((uint)0x8217),

    [NativeName("GL_FRAMEBUFFER_DEFAULT")]
    FramebufferDefault = unchecked((uint)0x8218),

    [NativeName("GL_FRAMEBUFFER_UNDEFINED")]
    FramebufferUndefined = unchecked((uint)0x8219),

    [NativeName("GL_DEPTH_STENCIL_ATTACHMENT")]
    DepthStencilAttachment = unchecked((uint)0x821A),

    [NativeName("GL_MAX_RENDERBUFFER_SIZE")]
    MaxRenderbufferSize = unchecked((uint)0x84E8),

    [NativeName("GL_DEPTH_STENCIL")]
    DepthStencil = unchecked((uint)0x84F9),

    [NativeName("GL_UNSIGNED_INT_24_8")]
    UnsignedInt24X8 = unchecked((uint)0x84FA),

    [NativeName("GL_DEPTH24_STENCIL8")]
    Depth24Stencil8 = unchecked((uint)0x88F0),

    [NativeName("GL_TEXTURE_STENCIL_SIZE")]
    TextureStencilSize = unchecked((uint)0x88F1),

    [NativeName("GL_TEXTURE_RED_TYPE")]
    TextureRedType = unchecked((uint)0x8C10),

    [NativeName("GL_TEXTURE_GREEN_TYPE")]
    TextureGreenType = unchecked((uint)0x8C11),

    [NativeName("GL_TEXTURE_BLUE_TYPE")]
    TextureBlueType = unchecked((uint)0x8C12),

    [NativeName("GL_TEXTURE_ALPHA_TYPE")]
    TextureAlphaType = unchecked((uint)0x8C13),

    [NativeName("GL_TEXTURE_DEPTH_TYPE")]
    TextureDepthType = unchecked((uint)0x8C16),

    [NativeName("GL_UNSIGNED_NORMALIZED")]
    UnsignedNormalized = unchecked((uint)0x8C17),

    [NativeName("GL_FRAMEBUFFER_BINDING")]
    FramebufferBinding = unchecked((uint)0x8CA6),

    [NativeName("GL_DRAW_FRAMEBUFFER_BINDING")]
    DrawFramebufferBinding = unchecked((uint)0x8CA6),

    [NativeName("GL_RENDERBUFFER_BINDING")]
    RenderbufferBinding = unchecked((uint)0x8CA7),

    [NativeName("GL_READ_FRAMEBUFFER")]
    ReadFramebuffer = unchecked((uint)0x8CA8),

    [NativeName("GL_DRAW_FRAMEBUFFER")]
    DrawFramebuffer = unchecked((uint)0x8CA9),

    [NativeName("GL_READ_FRAMEBUFFER_BINDING")]
    ReadFramebufferBinding = unchecked((uint)0x8CAA),

    [NativeName("GL_RENDERBUFFER_SAMPLES")]
    RenderbufferSamples = unchecked((uint)0x8CAB),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE")]
    FramebufferAttachmentObjectType = unchecked((uint)0x8CD0),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME")]
    FramebufferAttachmentObjectName = unchecked((uint)0x8CD1),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL")]
    FramebufferAttachmentTextureLevel = unchecked((uint)0x8CD2),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE")]
    FramebufferAttachmentTextureCubeMapFace = unchecked((uint)0x8CD3),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER")]
    FramebufferAttachmentTextureLayer = unchecked((uint)0x8CD4),

    [NativeName("GL_FRAMEBUFFER_COMPLETE")]
    FramebufferComplete = unchecked((uint)0x8CD5),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT")]
    FramebufferIncompleteAttachment = unchecked((uint)0x8CD6),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT")]
    FramebufferIncompleteMissingAttachment = unchecked((uint)0x8CD7),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER")]
    FramebufferIncompleteDrawBuffer = unchecked((uint)0x8CDB),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER")]
    FramebufferIncompleteReadBuffer = unchecked((uint)0x8CDC),

    [NativeName("GL_FRAMEBUFFER_UNSUPPORTED")]
    FramebufferUnsupported = unchecked((uint)0x8CDD),

    [NativeName("GL_MAX_COLOR_ATTACHMENTS")]
    MaxColorAttachments = unchecked((uint)0x8CDF),

    [NativeName("GL_COLOR_ATTACHMENT0")]
    ColorAttachment0 = unchecked((uint)0x8CE0),

    [NativeName("GL_COLOR_ATTACHMENT1")]
    ColorAttachment1 = unchecked((uint)0x8CE1),

    [NativeName("GL_COLOR_ATTACHMENT2")]
    ColorAttachment2 = unchecked((uint)0x8CE2),

    [NativeName("GL_COLOR_ATTACHMENT3")]
    ColorAttachment3 = unchecked((uint)0x8CE3),

    [NativeName("GL_COLOR_ATTACHMENT4")]
    ColorAttachment4 = unchecked((uint)0x8CE4),

    [NativeName("GL_COLOR_ATTACHMENT5")]
    ColorAttachment5 = unchecked((uint)0x8CE5),

    [NativeName("GL_COLOR_ATTACHMENT6")]
    ColorAttachment6 = unchecked((uint)0x8CE6),

    [NativeName("GL_COLOR_ATTACHMENT7")]
    ColorAttachment7 = unchecked((uint)0x8CE7),

    [NativeName("GL_COLOR_ATTACHMENT8")]
    ColorAttachment8 = unchecked((uint)0x8CE8),

    [NativeName("GL_COLOR_ATTACHMENT9")]
    ColorAttachment9 = unchecked((uint)0x8CE9),

    [NativeName("GL_COLOR_ATTACHMENT10")]
    ColorAttachment10 = unchecked((uint)0x8CEA),

    [NativeName("GL_COLOR_ATTACHMENT11")]
    ColorAttachment11 = unchecked((uint)0x8CEB),

    [NativeName("GL_COLOR_ATTACHMENT12")]
    ColorAttachment12 = unchecked((uint)0x8CEC),

    [NativeName("GL_COLOR_ATTACHMENT13")]
    ColorAttachment13 = unchecked((uint)0x8CED),

    [NativeName("GL_COLOR_ATTACHMENT14")]
    ColorAttachment14 = unchecked((uint)0x8CEE),

    [NativeName("GL_COLOR_ATTACHMENT15")]
    ColorAttachment15 = unchecked((uint)0x8CEF),

    [NativeName("GL_COLOR_ATTACHMENT16")]
    ColorAttachment16 = unchecked((uint)0x8CF0),

    [NativeName("GL_COLOR_ATTACHMENT17")]
    ColorAttachment17 = unchecked((uint)0x8CF1),

    [NativeName("GL_COLOR_ATTACHMENT18")]
    ColorAttachment18 = unchecked((uint)0x8CF2),

    [NativeName("GL_COLOR_ATTACHMENT19")]
    ColorAttachment19 = unchecked((uint)0x8CF3),

    [NativeName("GL_COLOR_ATTACHMENT20")]
    ColorAttachment20 = unchecked((uint)0x8CF4),

    [NativeName("GL_COLOR_ATTACHMENT21")]
    ColorAttachment21 = unchecked((uint)0x8CF5),

    [NativeName("GL_COLOR_ATTACHMENT22")]
    ColorAttachment22 = unchecked((uint)0x8CF6),

    [NativeName("GL_COLOR_ATTACHMENT23")]
    ColorAttachment23 = unchecked((uint)0x8CF7),

    [NativeName("GL_COLOR_ATTACHMENT24")]
    ColorAttachment24 = unchecked((uint)0x8CF8),

    [NativeName("GL_COLOR_ATTACHMENT25")]
    ColorAttachment25 = unchecked((uint)0x8CF9),

    [NativeName("GL_COLOR_ATTACHMENT26")]
    ColorAttachment26 = unchecked((uint)0x8CFA),

    [NativeName("GL_COLOR_ATTACHMENT27")]
    ColorAttachment27 = unchecked((uint)0x8CFB),

    [NativeName("GL_COLOR_ATTACHMENT28")]
    ColorAttachment28 = unchecked((uint)0x8CFC),

    [NativeName("GL_COLOR_ATTACHMENT29")]
    ColorAttachment29 = unchecked((uint)0x8CFD),

    [NativeName("GL_COLOR_ATTACHMENT30")]
    ColorAttachment30 = unchecked((uint)0x8CFE),

    [NativeName("GL_COLOR_ATTACHMENT31")]
    ColorAttachment31 = unchecked((uint)0x8CFF),

    [NativeName("GL_DEPTH_ATTACHMENT")]
    DepthAttachment = unchecked((uint)0x8D00),

    [NativeName("GL_STENCIL_ATTACHMENT")]
    StencilAttachment = unchecked((uint)0x8D20),

    [NativeName("GL_FRAMEBUFFER")]
    Framebuffer = unchecked((uint)0x8D40),

    [NativeName("GL_RENDERBUFFER")]
    Renderbuffer = unchecked((uint)0x8D41),

    [NativeName("GL_RENDERBUFFER_WIDTH")]
    RenderbufferWidth = unchecked((uint)0x8D42),

    [NativeName("GL_RENDERBUFFER_HEIGHT")]
    RenderbufferHeight = unchecked((uint)0x8D43),

    [NativeName("GL_RENDERBUFFER_INTERNAL_FORMAT")]
    RenderbufferInternalFormat = unchecked((uint)0x8D44),

    [NativeName("GL_STENCIL_INDEX1")]
    StencilIndex1 = unchecked((uint)0x8D46),

    [NativeName("GL_STENCIL_INDEX4")]
    StencilIndex4 = unchecked((uint)0x8D47),

    [NativeName("GL_STENCIL_INDEX8")]
    StencilIndex8 = unchecked((uint)0x8D48),

    [NativeName("GL_STENCIL_INDEX16")]
    StencilIndex16 = unchecked((uint)0x8D49),

    [NativeName("GL_RENDERBUFFER_RED_SIZE")]
    RenderbufferRedSize = unchecked((uint)0x8D50),

    [NativeName("GL_RENDERBUFFER_GREEN_SIZE")]
    RenderbufferGreenSize = unchecked((uint)0x8D51),

    [NativeName("GL_RENDERBUFFER_BLUE_SIZE")]
    RenderbufferBlueSize = unchecked((uint)0x8D52),

    [NativeName("GL_RENDERBUFFER_ALPHA_SIZE")]
    RenderbufferAlphaSize = unchecked((uint)0x8D53),

    [NativeName("GL_RENDERBUFFER_DEPTH_SIZE")]
    RenderbufferDepthSize = unchecked((uint)0x8D54),

    [NativeName("GL_RENDERBUFFER_STENCIL_SIZE")]
    RenderbufferStencilSize = unchecked((uint)0x8D55),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE")]
    FramebufferIncompleteMultisample = unchecked((uint)0x8D56),

    [NativeName("GL_MAX_SAMPLES")]
    MaxSamples = unchecked((uint)0x8D57),

    [NativeName("GL_INDEX")]
    Index = unchecked((uint)0x8222),

    [NativeName("GL_TEXTURE_LUMINANCE_TYPE")]
    TextureLuminanceType = unchecked((uint)0x8C14),

    [NativeName("GL_TEXTURE_INTENSITY_TYPE")]
    TextureIntensityType = unchecked((uint)0x8C15),

    [NativeName("GL_FRAMEBUFFER_SRGB")]
    FramebufferSrgb = unchecked((uint)0x8DB9),

    [NativeName("GL_HALF_FLOAT")]
    HalfFloat = unchecked((uint)0x140B),

    [NativeName("GL_MAP_READ_BIT")]
    MapReadBit = unchecked((uint)0x0001),

    [NativeName("GL_MAP_WRITE_BIT")]
    MapWriteBit = unchecked((uint)0x0002),

    [NativeName("GL_MAP_INVALIDATE_RANGE_BIT")]
    MapInvalidateRangeBit = unchecked((uint)0x0004),

    [NativeName("GL_MAP_INVALIDATE_BUFFER_BIT")]
    MapInvalidateBufferBit = unchecked((uint)0x0008),

    [NativeName("GL_MAP_FLUSH_EXPLICIT_BIT")]
    MapFlushExplicitBit = unchecked((uint)0x0010),

    [NativeName("GL_MAP_UNSYNCHRONIZED_BIT")]
    MapUnsynchronizedBit = unchecked((uint)0x0020),

    [NativeName("GL_COMPRESSED_RED_RGTC1")]
    CompressedRedRgtc1 = unchecked((uint)0x8DBB),

    [NativeName("GL_COMPRESSED_SIGNED_RED_RGTC1")]
    CompressedSignedRedRgtc1 = unchecked((uint)0x8DBC),

    [NativeName("GL_COMPRESSED_RG_RGTC2")]
    CompressedRgRgtc2 = unchecked((uint)0x8DBD),

    [NativeName("GL_COMPRESSED_SIGNED_RG_RGTC2")]
    CompressedSignedRgRgtc2 = unchecked((uint)0x8DBE),

    [NativeName("GL_RG")]
    Rg = unchecked((uint)0x8227),

    [NativeName("GL_RG_INTEGER")]
    RgInteger = unchecked((uint)0x8228),

    [NativeName("GL_R8")]
    R8 = unchecked((uint)0x8229),

    [NativeName("GL_R16")]
    R16 = unchecked((uint)0x822A),

    [NativeName("GL_RG8")]
    Rg8 = unchecked((uint)0x822B),

    [NativeName("GL_RG16")]
    Rg16 = unchecked((uint)0x822C),

    [NativeName("GL_R16F")]
    R16F = unchecked((uint)0x822D),

    [NativeName("GL_R32F")]
    R32F = unchecked((uint)0x822E),

    [NativeName("GL_RG16F")]
    Rg16F = unchecked((uint)0x822F),

    [NativeName("GL_RG32F")]
    Rg32F = unchecked((uint)0x8230),

    [NativeName("GL_R8I")]
    R8I = unchecked((uint)0x8231),

    [NativeName("GL_R8UI")]
    R8Ui = unchecked((uint)0x8232),

    [NativeName("GL_R16I")]
    R16I = unchecked((uint)0x8233),

    [NativeName("GL_R16UI")]
    R16Ui = unchecked((uint)0x8234),

    [NativeName("GL_R32I")]
    R32I = unchecked((uint)0x8235),

    [NativeName("GL_R32UI")]
    R32Ui = unchecked((uint)0x8236),

    [NativeName("GL_RG8I")]
    Rg8I = unchecked((uint)0x8237),

    [NativeName("GL_RG8UI")]
    Rg8Ui = unchecked((uint)0x8238),

    [NativeName("GL_RG16I")]
    Rg16I = unchecked((uint)0x8239),

    [NativeName("GL_RG16UI")]
    Rg16Ui = unchecked((uint)0x823A),

    [NativeName("GL_RG32I")]
    Rg32I = unchecked((uint)0x823B),

    [NativeName("GL_RG32UI")]
    Rg32Ui = unchecked((uint)0x823C),

    [NativeName("GL_VERTEX_ARRAY_BINDING")]
    VertexArrayBinding = unchecked((uint)0x85B5),

    [NativeName("GL_CLAMP_VERTEX_COLOR")]
    ClampVertexColor = unchecked((uint)0x891A),

    [NativeName("GL_CLAMP_FRAGMENT_COLOR")]
    ClampFragmentColor = unchecked((uint)0x891B),

    [NativeName("GL_ALPHA_INTEGER")]
    AlphaInteger = unchecked((uint)0x8D97),

    [NativeName("GL_SAMPLER_2D_RECT")]
    Sampler2DRect = unchecked((uint)0x8B63),

    [NativeName("GL_SAMPLER_2D_RECT_SHADOW")]
    Sampler2DRectShadow = unchecked((uint)0x8B64),

    [NativeName("GL_SAMPLER_BUFFER")]
    SamplerBuffer = unchecked((uint)0x8DC2),

    [NativeName("GL_INT_SAMPLER_2D_RECT")]
    IntSampler2DRect = unchecked((uint)0x8DCD),

    [NativeName("GL_INT_SAMPLER_BUFFER")]
    IntSamplerBuffer = unchecked((uint)0x8DD0),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_2D_RECT")]
    UnsignedIntSampler2DRect = unchecked((uint)0x8DD5),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_BUFFER")]
    UnsignedIntSamplerBuffer = unchecked((uint)0x8DD8),

    [NativeName("GL_TEXTURE_BUFFER")]
    TextureBuffer = unchecked((uint)0x8C2A),

    [NativeName("GL_MAX_TEXTURE_BUFFER_SIZE")]
    MaxTextureBufferSize = unchecked((uint)0x8C2B),

    [NativeName("GL_TEXTURE_BINDING_BUFFER")]
    TextureBindingBuffer = unchecked((uint)0x8C2C),

    [NativeName("GL_TEXTURE_BUFFER_DATA_STORE_BINDING")]
    TextureBufferDataStoreBinding = unchecked((uint)0x8C2D),

    [NativeName("GL_TEXTURE_RECTANGLE")]
    TextureRectANGLE = unchecked((uint)0x84F5),

    [NativeName("GL_TEXTURE_BINDING_RECTANGLE")]
    TextureBindingRectANGLE = unchecked((uint)0x84F6),

    [NativeName("GL_PROXY_TEXTURE_RECTANGLE")]
    ProxyTextureRectANGLE = unchecked((uint)0x84F7),

    [NativeName("GL_MAX_RECTANGLE_TEXTURE_SIZE")]
    MaxRectangleTextureSize = unchecked((uint)0x84F8),

    [NativeName("GL_R8_SNORM")]
    R8Snorm = unchecked((uint)0x8F94),

    [NativeName("GL_RG8_SNORM")]
    Rg8Snorm = unchecked((uint)0x8F95),

    [NativeName("GL_RGB8_SNORM")]
    Rgb8Snorm = unchecked((uint)0x8F96),

    [NativeName("GL_RGBA8_SNORM")]
    Rgba8Snorm = unchecked((uint)0x8F97),

    [NativeName("GL_R16_SNORM")]
    R16Snorm = unchecked((uint)0x8F98),

    [NativeName("GL_RG16_SNORM")]
    Rg16Snorm = unchecked((uint)0x8F99),

    [NativeName("GL_RGB16_SNORM")]
    Rgb16Snorm = unchecked((uint)0x8F9A),

    [NativeName("GL_RGBA16_SNORM")]
    Rgba16Snorm = unchecked((uint)0x8F9B),

    [NativeName("GL_SIGNED_NORMALIZED")]
    SignedNormalized = unchecked((uint)0x8F9C),

    [NativeName("GL_PRIMITIVE_RESTART")]
    PrimitiveRestart = unchecked((uint)0x8F9D),

    [NativeName("GL_PRIMITIVE_RESTART_INDEX")]
    PrimitiveRestartIndex = unchecked((uint)0x8F9E),

    [NativeName("GL_COPY_READ_BUFFER")]
    CopyReadBuffer = unchecked((uint)0x8F36),

    [NativeName("GL_COPY_WRITE_BUFFER")]
    CopyWriteBuffer = unchecked((uint)0x8F37),

    [NativeName("GL_UNIFORM_BUFFER")]
    UniformBuffer = unchecked((uint)0x8A11),

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

    [NativeName("GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH")]
    ActiveUniformBlockMaxNameLength = unchecked((uint)0x8A35),

    [NativeName("GL_ACTIVE_UNIFORM_BLOCKS")]
    ActiveUniformBlocks = unchecked((uint)0x8A36),

    [NativeName("GL_UNIFORM_TYPE")]
    UniformType = unchecked((uint)0x8A37),

    [NativeName("GL_UNIFORM_SIZE")]
    UniformSize = unchecked((uint)0x8A38),

    [NativeName("GL_UNIFORM_NAME_LENGTH")]
    UniformNameLength = unchecked((uint)0x8A39),

    [NativeName("GL_UNIFORM_BLOCK_INDEX")]
    UniformBlockIndex = unchecked((uint)0x8A3A),

    [NativeName("GL_UNIFORM_OFFSET")]
    UniformOffset = unchecked((uint)0x8A3B),

    [NativeName("GL_UNIFORM_ARRAY_STRIDE")]
    UniformArrayStride = unchecked((uint)0x8A3C),

    [NativeName("GL_UNIFORM_MATRIX_STRIDE")]
    UniformMatrixStride = unchecked((uint)0x8A3D),

    [NativeName("GL_UNIFORM_IS_ROW_MAJOR")]
    UniformIsRowMajor = unchecked((uint)0x8A3E),

    [NativeName("GL_UNIFORM_BLOCK_BINDING")]
    UniformBlockBinding = unchecked((uint)0x8A3F),

    [NativeName("GL_UNIFORM_BLOCK_DATA_SIZE")]
    UniformBlockDataSize = unchecked((uint)0x8A40),

    [NativeName("GL_UNIFORM_BLOCK_NAME_LENGTH")]
    UniformBlockNameLength = unchecked((uint)0x8A41),

    [NativeName("GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS")]
    UniformBlockActiveUniforms = unchecked((uint)0x8A42),

    [NativeName("GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES")]
    UniformBlockActiveUniformIndices = unchecked((uint)0x8A43),

    [NativeName("GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER")]
    UniformBlockReferencedByVertexShader = unchecked((uint)0x8A44),

    [NativeName("GL_UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER")]
    UniformBlockReferencedByGeometryShader = unchecked((uint)0x8A45),

    [NativeName("GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER")]
    UniformBlockReferencedByFragmentShader = unchecked((uint)0x8A46),

    [NativeName("GL_INVALID_INDEX")]
    InvalidIndex = unchecked((uint)0xFFFFFFFFU),

    [NativeName("GL_CONTEXT_CORE_PROFILE_BIT")]
    ContextCoreProfileBit = unchecked((uint)0x00000001),

    [NativeName("GL_CONTEXT_COMPATIBILITY_PROFILE_BIT")]
    ContextCompatibilityProfileBit = unchecked((uint)0x00000002),

    [NativeName("GL_LINES_ADJACENCY")]
    LinesAdjacency = unchecked((uint)0x000A),

    [NativeName("GL_LINE_STRIP_ADJACENCY")]
    LineStripAdjacency = unchecked((uint)0x000B),

    [NativeName("GL_TRIANGLES_ADJACENCY")]
    TrianglesAdjacency = unchecked((uint)0x000C),

    [NativeName("GL_TRIANGLE_STRIP_ADJACENCY")]
    TriangleStripAdjacency = unchecked((uint)0x000D),

    [NativeName("GL_PROGRAM_POINT_SIZE")]
    ProgramPointSize = unchecked((uint)0x8642),

    [NativeName("GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS")]
    MaxGeometryTextureImageUnits = unchecked((uint)0x8C29),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_LAYERED")]
    FramebufferAttachmentLayered = unchecked((uint)0x8DA7),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS")]
    FramebufferIncompleteLayerTargets = unchecked((uint)0x8DA8),

    [NativeName("GL_GEOMETRY_SHADER")]
    GeometryShader = unchecked((uint)0x8DD9),

    [NativeName("GL_GEOMETRY_VERTICES_OUT")]
    GeometryVerticesOut = unchecked((uint)0x8916),

    [NativeName("GL_GEOMETRY_INPUT_TYPE")]
    GeometryInputType = unchecked((uint)0x8917),

    [NativeName("GL_GEOMETRY_OUTPUT_TYPE")]
    GeometryOutputType = unchecked((uint)0x8918),

    [NativeName("GL_MAX_GEOMETRY_UNIFORM_COMPONENTS")]
    MaxGeometryUniformComponents = unchecked((uint)0x8DDF),

    [NativeName("GL_MAX_GEOMETRY_OUTPUT_VERTICES")]
    MaxGeometryOutputVertices = unchecked((uint)0x8DE0),

    [NativeName("GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS")]
    MaxGeometryTotalOutputComponents = unchecked((uint)0x8DE1),

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

    [NativeName("GL_DEPTH_CLAMP")]
    DepthClamp = unchecked((uint)0x864F),

    [NativeName("GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION")]
    QuadsFollowProvokingVertexConvention = unchecked((uint)0x8E4C),

    [NativeName("GL_FIRST_VERTEX_CONVENTION")]
    FirstVertexConvention = unchecked((uint)0x8E4D),

    [NativeName("GL_LAST_VERTEX_CONVENTION")]
    LastVertexConvention = unchecked((uint)0x8E4E),

    [NativeName("GL_PROVOKING_VERTEX")]
    ProvokingVertex = unchecked((uint)0x8E4F),

    [NativeName("GL_TEXTURE_CUBE_MAP_SEAMLESS")]
    TextureCubeMapSeamless = unchecked((uint)0x884F),

    [NativeName("GL_MAX_SERVER_WAIT_TIMEOUT")]
    MaxServerWaitTimeout = unchecked((uint)0x9111),

    [NativeName("GL_OBJECT_TYPE")]
    ObjectType = unchecked((uint)0x9112),

    [NativeName("GL_SYNC_CONDITION")]
    SyncCondition = unchecked((uint)0x9113),

    [NativeName("GL_SYNC_STATUS")]
    SyncStatus = unchecked((uint)0x9114),

    [NativeName("GL_SYNC_FLAGS")]
    SyncFlags = unchecked((uint)0x9115),

    [NativeName("GL_SYNC_FENCE")]
    SyncFence = unchecked((uint)0x9116),

    [NativeName("GL_SYNC_GPU_COMMANDS_COMPLETE")]
    SyncGpuCommandsComplete = unchecked((uint)0x9117),

    [NativeName("GL_UNSIGNALED")]
    Unsignaled = unchecked((uint)0x9118),

    [NativeName("GL_SIGNALED")]
    Signaled = unchecked((uint)0x9119),

    [NativeName("GL_ALREADY_SIGNALED")]
    AlreadySignaled = unchecked((uint)0x911A),

    [NativeName("GL_TIMEOUT_EXPIRED")]
    TimeoutExpired = unchecked((uint)0x911B),

    [NativeName("GL_CONDITION_SATISFIED")]
    ConditionSatisfied = unchecked((uint)0x911C),

    [NativeName("GL_WAIT_FAILED")]
    WaitFailed = unchecked((uint)0x911D),

    [NativeName("GL_TIMEOUT_IGNORED")]
    TimeoutIgnored = unchecked((uint)0xFFFFFFFFFFFFFFFFUL),

    [NativeName("GL_SYNC_FLUSH_COMMANDS_BIT")]
    SyncFlushCommandsBit = unchecked((uint)0x00000001),

    [NativeName("GL_SAMPLE_POSITION")]
    SamplePosition = unchecked((uint)0x8E50),

    [NativeName("GL_SAMPLE_MASK")]
    SampleMask = unchecked((uint)0x8E51),

    [NativeName("GL_SAMPLE_MASK_VALUE")]
    SampleMaskValue = unchecked((uint)0x8E52),

    [NativeName("GL_MAX_SAMPLE_MASK_WORDS")]
    MaxSampleMaskWords = unchecked((uint)0x8E59),

    [NativeName("GL_TEXTURE_2D_MULTISAMPLE")]
    Texture2DMultisample = unchecked((uint)0x9100),

    [NativeName("GL_PROXY_TEXTURE_2D_MULTISAMPLE")]
    ProxyTexture2DMultisample = unchecked((uint)0x9101),

    [NativeName("GL_TEXTURE_2D_MULTISAMPLE_ARRAY")]
    Texture2DMultisampleArray = unchecked((uint)0x9102),

    [NativeName("GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY")]
    ProxyTexture2DMultisampleArray = unchecked((uint)0x9103),

    [NativeName("GL_TEXTURE_BINDING_2D_MULTISAMPLE")]
    TextureBinding2DMultisample = unchecked((uint)0x9104),

    [NativeName("GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY")]
    TextureBinding2DMultisampleArray = unchecked((uint)0x9105),

    [NativeName("GL_TEXTURE_SAMPLES")]
    TextureSamples = unchecked((uint)0x9106),

    [NativeName("GL_TEXTURE_FIXED_SAMPLE_LOCATIONS")]
    TextureFixedSampleLocations = unchecked((uint)0x9107),

    [NativeName("GL_SAMPLER_2D_MULTISAMPLE")]
    Sampler2DMultisample = unchecked((uint)0x9108),

    [NativeName("GL_INT_SAMPLER_2D_MULTISAMPLE")]
    IntSampler2DMultisample = unchecked((uint)0x9109),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE")]
    UnsignedIntSampler2DMultisample = unchecked((uint)0x910A),

    [NativeName("GL_SAMPLER_2D_MULTISAMPLE_ARRAY")]
    Sampler2DMultisampleArray = unchecked((uint)0x910B),

    [NativeName("GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY")]
    IntSampler2DMultisampleArray = unchecked((uint)0x910C),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY")]
    UnsignedIntSampler2DMultisampleArray = unchecked((uint)0x910D),

    [NativeName("GL_MAX_COLOR_TEXTURE_SAMPLES")]
    MaxColorTextureSamples = unchecked((uint)0x910E),

    [NativeName("GL_MAX_DEPTH_TEXTURE_SAMPLES")]
    MaxDepthTextureSamples = unchecked((uint)0x910F),

    [NativeName("GL_MAX_INTEGER_SAMPLES")]
    MaxIntegerSamples = unchecked((uint)0x9110),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_DIVISOR")]
    VertexAttribArrayDivisor = unchecked((uint)0x88FE),

    [NativeName("GL_SRC1_COLOR")]
    Src1Color = unchecked((uint)0x88F9),

    [NativeName("GL_ONE_MINUS_SRC1_COLOR")]
    OneMinusSrc1Color = unchecked((uint)0x88FA),

    [NativeName("GL_ONE_MINUS_SRC1_ALPHA")]
    OneMinusSrc1Alpha = unchecked((uint)0x88FB),

    [NativeName("GL_MAX_DUAL_SOURCE_DRAW_BUFFERS")]
    MaxDualSourceDrawBuffers = unchecked((uint)0x88FC),

    [NativeName("GL_ANY_SAMPLES_PASSED")]
    AnySamplesPassed = unchecked((uint)0x8C2F),

    [NativeName("GL_SAMPLER_BINDING")]
    SamplerBinding = unchecked((uint)0x8919),

    [NativeName("GL_RGB10_A2UI")]
    Rgb10A2Ui = unchecked((uint)0x906F),

    [NativeName("GL_TEXTURE_SWIZZLE_R")]
    TextureSwizzleR = unchecked((uint)0x8E42),

    [NativeName("GL_TEXTURE_SWIZZLE_G")]
    TextureSwizzleG = unchecked((uint)0x8E43),

    [NativeName("GL_TEXTURE_SWIZZLE_B")]
    TextureSwizzleB = unchecked((uint)0x8E44),

    [NativeName("GL_TEXTURE_SWIZZLE_A")]
    TextureSwizzleA = unchecked((uint)0x8E45),

    [NativeName("GL_TEXTURE_SWIZZLE_RGBA")]
    TextureSwizzleRgba = unchecked((uint)0x8E46),

    [NativeName("GL_TIME_ELAPSED")]
    TimeElapsed = unchecked((uint)0x88BF),

    [NativeName("GL_TIMESTAMP")]
    Timestamp = unchecked((uint)0x8E28),

    [NativeName("GL_INT_2_10_10_10_REV")]
    Int2X10X10X10Rev = unchecked((uint)0x8D9F),

    [NativeName("GL_SAMPLE_SHADING")]
    SampleShading = unchecked((uint)0x8C36),

    [NativeName("GL_MIN_SAMPLE_SHADING_VALUE")]
    MinSampleShadingValue = unchecked((uint)0x8C37),

    [NativeName("GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET")]
    MinProgramTextureGatherOffset = unchecked((uint)0x8E5E),

    [NativeName("GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET")]
    MaxProgramTextureGatherOffset = unchecked((uint)0x8E5F),

    [NativeName("GL_TEXTURE_CUBE_MAP_ARRAY")]
    TextureCubeMapArray = unchecked((uint)0x9009),

    [NativeName("GL_TEXTURE_BINDING_CUBE_MAP_ARRAY")]
    TextureBindingCubeMapArray = unchecked((uint)0x900A),

    [NativeName("GL_PROXY_TEXTURE_CUBE_MAP_ARRAY")]
    ProxyTextureCubeMapArray = unchecked((uint)0x900B),

    [NativeName("GL_SAMPLER_CUBE_MAP_ARRAY")]
    SamplerCubeMapArray = unchecked((uint)0x900C),

    [NativeName("GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW")]
    SamplerCubeMapArrayShadow = unchecked((uint)0x900D),

    [NativeName("GL_INT_SAMPLER_CUBE_MAP_ARRAY")]
    IntSamplerCubeMapArray = unchecked((uint)0x900E),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY")]
    UnsignedIntSamplerCubeMapArray = unchecked((uint)0x900F),

    [NativeName("GL_DRAW_INDIRECT_BUFFER")]
    DrawIndirectBuffer = unchecked((uint)0x8F3F),

    [NativeName("GL_DRAW_INDIRECT_BUFFER_BINDING")]
    DrawIndirectBufferBinding = unchecked((uint)0x8F43),

    [NativeName("GL_GEOMETRY_SHADER_INVOCATIONS")]
    GeometryShaderInvocations = unchecked((uint)0x887F),

    [NativeName("GL_MAX_GEOMETRY_SHADER_INVOCATIONS")]
    MaxGeometryShaderInvocations = unchecked((uint)0x8E5A),

    [NativeName("GL_MIN_FRAGMENT_INTERPOLATION_OFFSET")]
    MinFragmentInterpolationOffset = unchecked((uint)0x8E5B),

    [NativeName("GL_MAX_FRAGMENT_INTERPOLATION_OFFSET")]
    MaxFragmentInterpolationOffset = unchecked((uint)0x8E5C),

    [NativeName("GL_FRAGMENT_INTERPOLATION_OFFSET_BITS")]
    FragmentInterpolationOffsetBits = unchecked((uint)0x8E5D),

    [NativeName("GL_MAX_VERTEX_STREAMS")]
    MaxVertexStreams = unchecked((uint)0x8E71),

    [NativeName("GL_DOUBLE_VEC2")]
    DoubleVec2 = unchecked((uint)0x8FFC),

    [NativeName("GL_DOUBLE_VEC3")]
    DoubleVec3 = unchecked((uint)0x8FFD),

    [NativeName("GL_DOUBLE_VEC4")]
    DoubleVec4 = unchecked((uint)0x8FFE),

    [NativeName("GL_DOUBLE_MAT2")]
    DoubleMat2 = unchecked((uint)0x8F46),

    [NativeName("GL_DOUBLE_MAT3")]
    DoubleMat3 = unchecked((uint)0x8F47),

    [NativeName("GL_DOUBLE_MAT4")]
    DoubleMat4 = unchecked((uint)0x8F48),

    [NativeName("GL_DOUBLE_MAT2x3")]
    DoubleMat2X3 = unchecked((uint)0x8F49),

    [NativeName("GL_DOUBLE_MAT2x4")]
    DoubleMat2X4 = unchecked((uint)0x8F4A),

    [NativeName("GL_DOUBLE_MAT3x2")]
    DoubleMat3X2 = unchecked((uint)0x8F4B),

    [NativeName("GL_DOUBLE_MAT3x4")]
    DoubleMat3X4 = unchecked((uint)0x8F4C),

    [NativeName("GL_DOUBLE_MAT4x2")]
    DoubleMat4X2 = unchecked((uint)0x8F4D),

    [NativeName("GL_DOUBLE_MAT4x3")]
    DoubleMat4X3 = unchecked((uint)0x8F4E),

    [NativeName("GL_ACTIVE_SUBROUTINES")]
    ActiveSubroutines = unchecked((uint)0x8DE5),

    [NativeName("GL_ACTIVE_SUBROUTINE_UNIFORMS")]
    ActiveSubroutineUniforms = unchecked((uint)0x8DE6),

    [NativeName("GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS")]
    ActiveSubroutineUniformLocations = unchecked((uint)0x8E47),

    [NativeName("GL_ACTIVE_SUBROUTINE_MAX_LENGTH")]
    ActiveSubroutineMaxLength = unchecked((uint)0x8E48),

    [NativeName("GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH")]
    ActiveSubroutineUniformMaxLength = unchecked((uint)0x8E49),

    [NativeName("GL_MAX_SUBROUTINES")]
    MaxSubroutines = unchecked((uint)0x8DE7),

    [NativeName("GL_MAX_SUBROUTINE_UNIFORM_LOCATIONS")]
    MaxSubroutineUniformLocations = unchecked((uint)0x8DE8),

    [NativeName("GL_NUM_COMPATIBLE_SUBROUTINES")]
    NumCompatibleSubroutines = unchecked((uint)0x8E4A),

    [NativeName("GL_COMPATIBLE_SUBROUTINES")]
    CompatibleSubroutines = unchecked((uint)0x8E4B),

    [NativeName("GL_PATCHES")]
    Patches = unchecked((uint)0x000E),

    [NativeName("GL_PATCH_VERTICES")]
    PatchVertices = unchecked((uint)0x8E72),

    [NativeName("GL_PATCH_DEFAULT_INNER_LEVEL")]
    PatchDefaultInnerLevel = unchecked((uint)0x8E73),

    [NativeName("GL_PATCH_DEFAULT_OUTER_LEVEL")]
    PatchDefaultOuterLevel = unchecked((uint)0x8E74),

    [NativeName("GL_TESS_CONTROL_OUTPUT_VERTICES")]
    TessControlOutputVertices = unchecked((uint)0x8E75),

    [NativeName("GL_TESS_GEN_MODE")]
    TessGenMode = unchecked((uint)0x8E76),

    [NativeName("GL_TESS_GEN_SPACING")]
    TessGenSpacing = unchecked((uint)0x8E77),

    [NativeName("GL_TESS_GEN_VERTEX_ORDER")]
    TessGenVertexOrder = unchecked((uint)0x8E78),

    [NativeName("GL_TESS_GEN_POINT_MODE")]
    TessGenPointMode = unchecked((uint)0x8E79),

    [NativeName("GL_ISOLINES")]
    Isolines = unchecked((uint)0x8E7A),

    [NativeName("GL_FRACTIONAL_ODD")]
    FractionalOdd = unchecked((uint)0x8E7B),

    [NativeName("GL_FRACTIONAL_EVEN")]
    FractionalEven = unchecked((uint)0x8E7C),

    [NativeName("GL_MAX_PATCH_VERTICES")]
    MaxPatchVertices = unchecked((uint)0x8E7D),

    [NativeName("GL_MAX_TESS_GEN_LEVEL")]
    MaxTessGenLevel = unchecked((uint)0x8E7E),

    [NativeName("GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS")]
    MaxTessControlUniformComponents = unchecked((uint)0x8E7F),

    [NativeName("GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS")]
    MaxTessEvaluationUniformComponents = unchecked((uint)0x8E80),

    [NativeName("GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS")]
    MaxTessControlTextureImageUnits = unchecked((uint)0x8E81),

    [NativeName("GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS")]
    MaxTessEvaluationTextureImageUnits = unchecked((uint)0x8E82),

    [NativeName("GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS")]
    MaxTessControlOutputComponents = unchecked((uint)0x8E83),

    [NativeName("GL_MAX_TESS_PATCH_COMPONENTS")]
    MaxTessPatchComponents = unchecked((uint)0x8E84),

    [NativeName("GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS")]
    MaxTessControlTotalOutputComponents = unchecked((uint)0x8E85),

    [NativeName("GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS")]
    MaxTessEvaluationOutputComponents = unchecked((uint)0x8E86),

    [NativeName("GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS")]
    MaxTessControlUniformBlocks = unchecked((uint)0x8E89),

    [NativeName("GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS")]
    MaxTessEvaluationUniformBlocks = unchecked((uint)0x8E8A),

    [NativeName("GL_MAX_TESS_CONTROL_INPUT_COMPONENTS")]
    MaxTessControlInputComponents = unchecked((uint)0x886C),

    [NativeName("GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS")]
    MaxTessEvaluationInputComponents = unchecked((uint)0x886D),

    [NativeName("GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS")]
    MaxCombinedTessControlUniformComponents = unchecked((uint)0x8E1E),

    [NativeName("GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS")]
    MaxCombinedTessEvaluationUniformComponents = unchecked((uint)0x8E1F),

    [NativeName("GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER")]
    UniformBlockReferencedByTessControlShader = unchecked((uint)0x84F0),

    [NativeName("GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER")]
    UniformBlockReferencedByTessEvaluationShader = unchecked((uint)0x84F1),

    [NativeName("GL_TESS_EVALUATION_SHADER")]
    TessEvaluationShader = unchecked((uint)0x8E87),

    [NativeName("GL_TESS_CONTROL_SHADER")]
    TessControlShader = unchecked((uint)0x8E88),

    [NativeName("GL_TRANSFORM_FEEDBACK")]
    TransformFeedback = unchecked((uint)0x8E22),

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED")]
    TransformFeedbackBufferPaused = unchecked((uint)0x8E23),

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE")]
    TransformFeedbackBufferActive = unchecked((uint)0x8E24),

    [NativeName("GL_TRANSFORM_FEEDBACK_BINDING")]
    TransformFeedbackBinding = unchecked((uint)0x8E25),

    [NativeName("GL_MAX_TRANSFORM_FEEDBACK_BUFFERS")]
    MaxTransformFeedbackBuffers = unchecked((uint)0x8E70),

    [NativeName("GL_IMPLEMENTATION_COLOR_READ_TYPE")]
    ImplementationColorReadType = unchecked((uint)0x8B9A),

    [NativeName("GL_IMPLEMENTATION_COLOR_READ_FORMAT")]
    ImplementationColorReadFormat = unchecked((uint)0x8B9B),

    [NativeName("GL_LOW_FLOAT")]
    LowFloat = unchecked((uint)0x8DF0),

    [NativeName("GL_MEDIUM_FLOAT")]
    MediumFloat = unchecked((uint)0x8DF1),

    [NativeName("GL_HIGH_FLOAT")]
    HighFloat = unchecked((uint)0x8DF2),

    [NativeName("GL_LOW_INT")]
    LowInt = unchecked((uint)0x8DF3),

    [NativeName("GL_MEDIUM_INT")]
    MediumInt = unchecked((uint)0x8DF4),

    [NativeName("GL_HIGH_INT")]
    HighInt = unchecked((uint)0x8DF5),

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

    [NativeName("GL_RGB565")]
    Rgb565 = unchecked((uint)0x8D62),

    [NativeName("GL_PROGRAM_BINARY_RETRIEVABLE_HINT")]
    ProgramBinaryRetrievableHint = unchecked((uint)0x8257),

    [NativeName("GL_PROGRAM_BINARY_LENGTH")]
    ProgramBinaryLength = unchecked((uint)0x8741),

    [NativeName("GL_NUM_PROGRAM_BINARY_FORMATS")]
    NumProgramBinaryFormats = unchecked((uint)0x87FE),

    [NativeName("GL_PROGRAM_BINARY_FORMATS")]
    ProgramBinaryFormats = unchecked((uint)0x87FF),

    [NativeName("GL_VERTEX_SHADER_BIT")]
    VertexShaderBit = unchecked((uint)0x00000001),

    [NativeName("GL_FRAGMENT_SHADER_BIT")]
    FragmentShaderBit = unchecked((uint)0x00000002),

    [NativeName("GL_GEOMETRY_SHADER_BIT")]
    GeometryShaderBit = unchecked((uint)0x00000004),

    [NativeName("GL_TESS_CONTROL_SHADER_BIT")]
    TessControlShaderBit = unchecked((uint)0x00000008),

    [NativeName("GL_TESS_EVALUATION_SHADER_BIT")]
    TessEvaluationShaderBit = unchecked((uint)0x00000010),

    [NativeName("GL_ALL_SHADER_BITS")]
    AllShaderBits = unchecked((uint)0xFFFFFFFF),

    [NativeName("GL_PROGRAM_SEPARABLE")]
    ProgramSeparable = unchecked((uint)0x8258),

    [NativeName("GL_ACTIVE_PROGRAM")]
    ActiveProgram = unchecked((uint)0x8259),

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

    [NativeName("GL_UNDEFINED_VERTEX")]
    UndefinedVertex = unchecked((uint)0x8260),

    [NativeName("GL_COPY_READ_BUFFER_BINDING")]
    CopyReadBufferBinding = unchecked((uint)0x8F36),

    [NativeName("GL_COPY_WRITE_BUFFER_BINDING")]
    CopyWriteBufferBinding = unchecked((uint)0x8F37),

    [NativeName("GL_TRANSFORM_FEEDBACK_ACTIVE")]
    TransformFeedbackActive = unchecked((uint)0x8E24),

    [NativeName("GL_TRANSFORM_FEEDBACK_PAUSED")]
    TransformFeedbackPaused = unchecked((uint)0x8E23),

    [NativeName("GL_UNPACK_COMPRESSED_BLOCK_WIDTH")]
    UnpackCompressedBlockWidth = unchecked((uint)0x9127),

    [NativeName("GL_UNPACK_COMPRESSED_BLOCK_HEIGHT")]
    UnpackCompressedBlockHeight = unchecked((uint)0x9128),

    [NativeName("GL_UNPACK_COMPRESSED_BLOCK_DEPTH")]
    UnpackCompressedBlockDepth = unchecked((uint)0x9129),

    [NativeName("GL_UNPACK_COMPRESSED_BLOCK_SIZE")]
    UnpackCompressedBlockSize = unchecked((uint)0x912A),

    [NativeName("GL_PACK_COMPRESSED_BLOCK_WIDTH")]
    PackCompressedBlockWidth = unchecked((uint)0x912B),

    [NativeName("GL_PACK_COMPRESSED_BLOCK_HEIGHT")]
    PackCompressedBlockHeight = unchecked((uint)0x912C),

    [NativeName("GL_PACK_COMPRESSED_BLOCK_DEPTH")]
    PackCompressedBlockDepth = unchecked((uint)0x912D),

    [NativeName("GL_PACK_COMPRESSED_BLOCK_SIZE")]
    PackCompressedBlockSize = unchecked((uint)0x912E),

    [NativeName("GL_NUM_SAMPLE_COUNTS")]
    NumSampleCounts = unchecked((uint)0x9380),

    [NativeName("GL_MIN_MAP_BUFFER_ALIGNMENT")]
    MinMapBufferAlignment = unchecked((uint)0x90BC),

    [NativeName("GL_ATOMIC_COUNTER_BUFFER")]
    AtomicCounterBuffer = unchecked((uint)0x92C0),

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_BINDING")]
    AtomicCounterBufferBinding = unchecked((uint)0x92C1),

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_START")]
    AtomicCounterBufferStart = unchecked((uint)0x92C2),

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_SIZE")]
    AtomicCounterBufferSize = unchecked((uint)0x92C3),

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_DATA_SIZE")]
    AtomicCounterBufferDataSize = unchecked((uint)0x92C4),

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS")]
    AtomicCounterBufferActiveAtomicCounters = unchecked((uint)0x92C5),

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES")]
    AtomicCounterBufferActiveAtomicCounterIndices = unchecked((uint)0x92C6),

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER")]
    AtomicCounterBufferReferencedByVertexShader = unchecked((uint)0x92C7),

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER")]
    AtomicCounterBufferReferencedByTessControlShader = unchecked((uint)0x92C8),

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER")]
    AtomicCounterBufferReferencedByTessEvaluationShader = unchecked((uint)0x92C9),

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER")]
    AtomicCounterBufferReferencedByGeometryShader = unchecked((uint)0x92CA),

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER")]
    AtomicCounterBufferReferencedByFragmentShader = unchecked((uint)0x92CB),

    [NativeName("GL_MAX_VERTEX_ATOMIC_COUNTER_BUFFERS")]
    MaxVertexAtomicCounterBuffers = unchecked((uint)0x92CC),

    [NativeName("GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS")]
    MaxTessControlAtomicCounterBuffers = unchecked((uint)0x92CD),

    [NativeName("GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS")]
    MaxTessEvaluationAtomicCounterBuffers = unchecked((uint)0x92CE),

    [NativeName("GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS")]
    MaxGeometryAtomicCounterBuffers = unchecked((uint)0x92CF),

    [NativeName("GL_MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS")]
    MaxFragmentAtomicCounterBuffers = unchecked((uint)0x92D0),

    [NativeName("GL_MAX_COMBINED_ATOMIC_COUNTER_BUFFERS")]
    MaxCombinedAtomicCounterBuffers = unchecked((uint)0x92D1),

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

    [NativeName("GL_MAX_ATOMIC_COUNTER_BUFFER_SIZE")]
    MaxAtomicCounterBufferSize = unchecked((uint)0x92D8),

    [NativeName("GL_MAX_ATOMIC_COUNTER_BUFFER_BINDINGS")]
    MaxAtomicCounterBufferBindings = unchecked((uint)0x92DC),

    [NativeName("GL_ACTIVE_ATOMIC_COUNTER_BUFFERS")]
    ActiveAtomicCounterBuffers = unchecked((uint)0x92D9),

    [NativeName("GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX")]
    UniformAtomicCounterBufferIndex = unchecked((uint)0x92DA),

    [NativeName("GL_UNSIGNED_INT_ATOMIC_COUNTER")]
    UnsignedIntAtomicCounter = unchecked((uint)0x92DB),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT")]
    VertexAttribArrayBarrierBit = unchecked((uint)0x00000001),

    [NativeName("GL_ELEMENT_ARRAY_BARRIER_BIT")]
    ElementArrayBarrierBit = unchecked((uint)0x00000002),

    [NativeName("GL_UNIFORM_BARRIER_BIT")]
    UniformBarrierBit = unchecked((uint)0x00000004),

    [NativeName("GL_TEXTURE_FETCH_BARRIER_BIT")]
    TextureFetchBarrierBit = unchecked((uint)0x00000008),

    [NativeName("GL_SHADER_IMAGE_ACCESS_BARRIER_BIT")]
    ShaderImageAccessBarrierBit = unchecked((uint)0x00000020),

    [NativeName("GL_COMMAND_BARRIER_BIT")]
    CommandBarrierBit = unchecked((uint)0x00000040),

    [NativeName("GL_PIXEL_BUFFER_BARRIER_BIT")]
    PixelBufferBarrierBit = unchecked((uint)0x00000080),

    [NativeName("GL_TEXTURE_UPDATE_BARRIER_BIT")]
    TextureUpdateBarrierBit = unchecked((uint)0x00000100),

    [NativeName("GL_BUFFER_UPDATE_BARRIER_BIT")]
    BufferUpdateBarrierBit = unchecked((uint)0x00000200),

    [NativeName("GL_FRAMEBUFFER_BARRIER_BIT")]
    FramebufferBarrierBit = unchecked((uint)0x00000400),

    [NativeName("GL_TRANSFORM_FEEDBACK_BARRIER_BIT")]
    TransformFeedbackBarrierBit = unchecked((uint)0x00000800),

    [NativeName("GL_ATOMIC_COUNTER_BARRIER_BIT")]
    AtomicCounterBarrierBit = unchecked((uint)0x00001000),

    [NativeName("GL_ALL_BARRIER_BITS")]
    AllBarrierBits = unchecked((uint)0xFFFFFFFF),

    [NativeName("GL_MAX_IMAGE_UNITS")]
    MaxImageUnits = unchecked((uint)0x8F38),

    [NativeName("GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS")]
    MaxCombinedImageUnitsAndFragmentOutputs = unchecked((uint)0x8F39),

    [NativeName("GL_IMAGE_BINDING_NAME")]
    ImageBindingName = unchecked((uint)0x8F3A),

    [NativeName("GL_IMAGE_BINDING_LEVEL")]
    ImageBindingLevel = unchecked((uint)0x8F3B),

    [NativeName("GL_IMAGE_BINDING_LAYERED")]
    ImageBindingLayered = unchecked((uint)0x8F3C),

    [NativeName("GL_IMAGE_BINDING_LAYER")]
    ImageBindingLayer = unchecked((uint)0x8F3D),

    [NativeName("GL_IMAGE_BINDING_ACCESS")]
    ImageBindingAccess = unchecked((uint)0x8F3E),

    [NativeName("GL_IMAGE_1D")]
    Image1D = unchecked((uint)0x904C),

    [NativeName("GL_IMAGE_2D")]
    Image2D = unchecked((uint)0x904D),

    [NativeName("GL_IMAGE_3D")]
    Image3D = unchecked((uint)0x904E),

    [NativeName("GL_IMAGE_2D_RECT")]
    Image2DRect = unchecked((uint)0x904F),

    [NativeName("GL_IMAGE_CUBE")]
    ImageCube = unchecked((uint)0x9050),

    [NativeName("GL_IMAGE_BUFFER")]
    ImageBuffer = unchecked((uint)0x9051),

    [NativeName("GL_IMAGE_1D_ARRAY")]
    Image1DArray = unchecked((uint)0x9052),

    [NativeName("GL_IMAGE_2D_ARRAY")]
    Image2DArray = unchecked((uint)0x9053),

    [NativeName("GL_IMAGE_CUBE_MAP_ARRAY")]
    ImageCubeMapArray = unchecked((uint)0x9054),

    [NativeName("GL_IMAGE_2D_MULTISAMPLE")]
    Image2DMultisample = unchecked((uint)0x9055),

    [NativeName("GL_IMAGE_2D_MULTISAMPLE_ARRAY")]
    Image2DMultisampleArray = unchecked((uint)0x9056),

    [NativeName("GL_INT_IMAGE_1D")]
    IntImage1D = unchecked((uint)0x9057),

    [NativeName("GL_INT_IMAGE_2D")]
    IntImage2D = unchecked((uint)0x9058),

    [NativeName("GL_INT_IMAGE_3D")]
    IntImage3D = unchecked((uint)0x9059),

    [NativeName("GL_INT_IMAGE_2D_RECT")]
    IntImage2DRect = unchecked((uint)0x905A),

    [NativeName("GL_INT_IMAGE_CUBE")]
    IntImageCube = unchecked((uint)0x905B),

    [NativeName("GL_INT_IMAGE_BUFFER")]
    IntImageBuffer = unchecked((uint)0x905C),

    [NativeName("GL_INT_IMAGE_1D_ARRAY")]
    IntImage1DArray = unchecked((uint)0x905D),

    [NativeName("GL_INT_IMAGE_2D_ARRAY")]
    IntImage2DArray = unchecked((uint)0x905E),

    [NativeName("GL_INT_IMAGE_CUBE_MAP_ARRAY")]
    IntImageCubeMapArray = unchecked((uint)0x905F),

    [NativeName("GL_INT_IMAGE_2D_MULTISAMPLE")]
    IntImage2DMultisample = unchecked((uint)0x9060),

    [NativeName("GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY")]
    IntImage2DMultisampleArray = unchecked((uint)0x9061),

    [NativeName("GL_UNSIGNED_INT_IMAGE_1D")]
    UnsignedIntImage1D = unchecked((uint)0x9062),

    [NativeName("GL_UNSIGNED_INT_IMAGE_2D")]
    UnsignedIntImage2D = unchecked((uint)0x9063),

    [NativeName("GL_UNSIGNED_INT_IMAGE_3D")]
    UnsignedIntImage3D = unchecked((uint)0x9064),

    [NativeName("GL_UNSIGNED_INT_IMAGE_2D_RECT")]
    UnsignedIntImage2DRect = unchecked((uint)0x9065),

    [NativeName("GL_UNSIGNED_INT_IMAGE_CUBE")]
    UnsignedIntImageCube = unchecked((uint)0x9066),

    [NativeName("GL_UNSIGNED_INT_IMAGE_BUFFER")]
    UnsignedIntImageBuffer = unchecked((uint)0x9067),

    [NativeName("GL_UNSIGNED_INT_IMAGE_1D_ARRAY")]
    UnsignedIntImage1DArray = unchecked((uint)0x9068),

    [NativeName("GL_UNSIGNED_INT_IMAGE_2D_ARRAY")]
    UnsignedIntImage2DArray = unchecked((uint)0x9069),

    [NativeName("GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY")]
    UnsignedIntImageCubeMapArray = unchecked((uint)0x906A),

    [NativeName("GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE")]
    UnsignedIntImage2DMultisample = unchecked((uint)0x906B),

    [NativeName("GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY")]
    UnsignedIntImage2DMultisampleArray = unchecked((uint)0x906C),

    [NativeName("GL_MAX_IMAGE_SAMPLES")]
    MaxImageSamples = unchecked((uint)0x906D),

    [NativeName("GL_IMAGE_BINDING_FORMAT")]
    ImageBindingFormat = unchecked((uint)0x906E),

    [NativeName("GL_IMAGE_FORMAT_COMPATIBILITY_TYPE")]
    ImageFormatCompatibilityType = unchecked((uint)0x90C7),

    [NativeName("GL_IMAGE_FORMAT_COMPATIBILITY_BY_SIZE")]
    ImageFormatCompatibilityBySize = unchecked((uint)0x90C8),

    [NativeName("GL_IMAGE_FORMAT_COMPATIBILITY_BY_CLASS")]
    ImageFormatCompatibilityByClass = unchecked((uint)0x90C9),

    [NativeName("GL_MAX_VERTEX_IMAGE_UNIFORMS")]
    MaxVertexImageUniforms = unchecked((uint)0x90CA),

    [NativeName("GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS")]
    MaxTessControlImageUniforms = unchecked((uint)0x90CB),

    [NativeName("GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS")]
    MaxTessEvaluationImageUniforms = unchecked((uint)0x90CC),

    [NativeName("GL_MAX_GEOMETRY_IMAGE_UNIFORMS")]
    MaxGeometryImageUniforms = unchecked((uint)0x90CD),

    [NativeName("GL_MAX_FRAGMENT_IMAGE_UNIFORMS")]
    MaxFragmentImageUniforms = unchecked((uint)0x90CE),

    [NativeName("GL_MAX_COMBINED_IMAGE_UNIFORMS")]
    MaxCombinedImageUniforms = unchecked((uint)0x90CF),

    [NativeName("GL_COMPRESSED_RGBA_BPTC_UNORM")]
    CompressedRgbaBptcUnorm = unchecked((uint)0x8E8C),

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM")]
    CompressedSrgbAlphaBptcUnorm = unchecked((uint)0x8E8D),

    [NativeName("GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT")]
    CompressedRgbBptcSignedFloat = unchecked((uint)0x8E8E),

    [NativeName("GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT")]
    CompressedRgbBptcUnsignedFloat = unchecked((uint)0x8E8F),

    [NativeName("GL_TEXTURE_IMMUTABLE_FORMAT")]
    TextureImmutableFormat = unchecked((uint)0x912F),

    [NativeName("GL_NUM_SHADING_LANGUAGE_VERSIONS")]
    NumShadingLanguageVersions = unchecked((uint)0x82E9),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_LONG")]
    VertexAttribArrayLong = unchecked((uint)0x874E),

    [NativeName("GL_COMPRESSED_RGB8_ETC2")]
    CompressedRgb8Etc2 = unchecked((uint)0x9274),

    [NativeName("GL_COMPRESSED_SRGB8_ETC2")]
    CompressedSrgb8Etc2 = unchecked((uint)0x9275),

    [NativeName("GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2")]
    CompressedRgb8PunchthroughAlpha1Etc2 = unchecked((uint)0x9276),

    [NativeName("GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2")]
    CompressedSrgb8PunchthroughAlpha1Etc2 = unchecked((uint)0x9277),

    [NativeName("GL_COMPRESSED_RGBA8_ETC2_EAC")]
    CompressedRgba8Etc2Eac = unchecked((uint)0x9278),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC")]
    CompressedSrgb8Alpha8Etc2Eac = unchecked((uint)0x9279),

    [NativeName("GL_COMPRESSED_R11_EAC")]
    CompressedR11Eac = unchecked((uint)0x9270),

    [NativeName("GL_COMPRESSED_SIGNED_R11_EAC")]
    CompressedSignedR11Eac = unchecked((uint)0x9271),

    [NativeName("GL_COMPRESSED_RG11_EAC")]
    CompressedRg11Eac = unchecked((uint)0x9272),

    [NativeName("GL_COMPRESSED_SIGNED_RG11_EAC")]
    CompressedSignedRg11Eac = unchecked((uint)0x9273),

    [NativeName("GL_PRIMITIVE_RESTART_FIXED_INDEX")]
    PrimitiveRestartFixedIndex = unchecked((uint)0x8D69),

    [NativeName("GL_ANY_SAMPLES_PASSED_CONSERVATIVE")]
    AnySamplesPassedConservative = unchecked((uint)0x8D6A),

    [NativeName("GL_MAX_ELEMENT_INDEX")]
    MaxElementIndex = unchecked((uint)0x8D6B),

    [NativeName("GL_COMPUTE_SHADER")]
    ComputeShader = unchecked((uint)0x91B9),

    [NativeName("GL_MAX_COMPUTE_UNIFORM_BLOCKS")]
    MaxComputeUniformBlocks = unchecked((uint)0x91BB),

    [NativeName("GL_MAX_COMPUTE_TEXTURE_IMAGE_UNITS")]
    MaxComputeTextureImageUnits = unchecked((uint)0x91BC),

    [NativeName("GL_MAX_COMPUTE_IMAGE_UNIFORMS")]
    MaxComputeImageUniforms = unchecked((uint)0x91BD),

    [NativeName("GL_MAX_COMPUTE_SHARED_MEMORY_SIZE")]
    MaxComputeSharedMemorySize = unchecked((uint)0x8262),

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

    [NativeName("GL_COMPUTE_WORK_GROUP_SIZE")]
    ComputeWorkGroupSize = unchecked((uint)0x8267),

    [NativeName("GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER")]
    UniformBlockReferencedByComputeShader = unchecked((uint)0x90EC),

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER")]
    AtomicCounterBufferReferencedByComputeShader = unchecked((uint)0x90ED),

    [NativeName("GL_DISPATCH_INDIRECT_BUFFER")]
    DispatchIndirectBuffer = unchecked((uint)0x90EE),

    [NativeName("GL_DISPATCH_INDIRECT_BUFFER_BINDING")]
    DispatchIndirectBufferBinding = unchecked((uint)0x90EF),

    [NativeName("GL_COMPUTE_SHADER_BIT")]
    ComputeShaderBit = unchecked((uint)0x00000020),

    [NativeName("GL_DEBUG_OUTPUT_SYNCHRONOUS")]
    DebugOutputSynchronous = unchecked((uint)0x8242),

    [NativeName("GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH")]
    DebugNextLoggedMessageLength = unchecked((uint)0x8243),

    [NativeName("GL_DEBUG_CALLBACK_FUNCTION")]
    DebugCallbackFunction = unchecked((uint)0x8244),

    [NativeName("GL_DEBUG_CALLBACK_USER_PARAM")]
    DebugCallbackUserParam = unchecked((uint)0x8245),

    [NativeName("GL_DEBUG_SOURCE_API")]
    DebugSourceApi = unchecked((uint)0x8246),

    [NativeName("GL_DEBUG_SOURCE_WINDOW_SYSTEM")]
    DebugSourceWindowSystem = unchecked((uint)0x8247),

    [NativeName("GL_DEBUG_SOURCE_SHADER_COMPILER")]
    DebugSourceShaderCompiler = unchecked((uint)0x8248),

    [NativeName("GL_DEBUG_SOURCE_THIRD_PARTY")]
    DebugSourceThirdParty = unchecked((uint)0x8249),

    [NativeName("GL_DEBUG_SOURCE_APPLICATION")]
    DebugSourceApplication = unchecked((uint)0x824A),

    [NativeName("GL_DEBUG_SOURCE_OTHER")]
    DebugSourceOther = unchecked((uint)0x824B),

    [NativeName("GL_DEBUG_TYPE_ERROR")]
    DebugTypeError = unchecked((uint)0x824C),

    [NativeName("GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR")]
    DebugTypeDeprecatedBehavior = unchecked((uint)0x824D),

    [NativeName("GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR")]
    DebugTypeUndefinedBehavior = unchecked((uint)0x824E),

    [NativeName("GL_DEBUG_TYPE_PORTABILITY")]
    DebugTypePortability = unchecked((uint)0x824F),

    [NativeName("GL_DEBUG_TYPE_PERFORMANCE")]
    DebugTypePerformance = unchecked((uint)0x8250),

    [NativeName("GL_DEBUG_TYPE_OTHER")]
    DebugTypeOther = unchecked((uint)0x8251),

    [NativeName("GL_MAX_DEBUG_MESSAGE_LENGTH")]
    MaxDebugMessageLength = unchecked((uint)0x9143),

    [NativeName("GL_MAX_DEBUG_LOGGED_MESSAGES")]
    MaxDebugLoggedMessages = unchecked((uint)0x9144),

    [NativeName("GL_DEBUG_LOGGED_MESSAGES")]
    DebugLoggedMessages = unchecked((uint)0x9145),

    [NativeName("GL_DEBUG_SEVERITY_HIGH")]
    DebugSeverityHigh = unchecked((uint)0x9146),

    [NativeName("GL_DEBUG_SEVERITY_MEDIUM")]
    DebugSeverityMedium = unchecked((uint)0x9147),

    [NativeName("GL_DEBUG_SEVERITY_LOW")]
    DebugSeverityLow = unchecked((uint)0x9148),

    [NativeName("GL_DEBUG_TYPE_MARKER")]
    DebugTypeMarker = unchecked((uint)0x8268),

    [NativeName("GL_DEBUG_TYPE_PUSH_GROUP")]
    DebugTypePushGroup = unchecked((uint)0x8269),

    [NativeName("GL_DEBUG_TYPE_POP_GROUP")]
    DebugTypePopGroup = unchecked((uint)0x826A),

    [NativeName("GL_DEBUG_SEVERITY_NOTIFICATION")]
    DebugSeverityNotification = unchecked((uint)0x826B),

    [NativeName("GL_MAX_DEBUG_GROUP_STACK_DEPTH")]
    MaxDebugGroupStackDepth = unchecked((uint)0x826C),

    [NativeName("GL_DEBUG_GROUP_STACK_DEPTH")]
    DebugGroupStackDepth = unchecked((uint)0x826D),

    [NativeName("GL_BUFFER")]
    Buffer = unchecked((uint)0x82E0),

    [NativeName("GL_SHADER")]
    Shader = unchecked((uint)0x82E1),

    [NativeName("GL_PROGRAM")]
    Program = unchecked((uint)0x82E2),

    [NativeName("GL_QUERY")]
    Query = unchecked((uint)0x82E3),

    [NativeName("GL_PROGRAM_PIPELINE")]
    ProgramPipeline = unchecked((uint)0x82E4),

    [NativeName("GL_SAMPLER")]
    Sampler = unchecked((uint)0x82E6),

    [NativeName("GL_MAX_LABEL_LENGTH")]
    MaxLabelLength = unchecked((uint)0x82E8),

    [NativeName("GL_DEBUG_OUTPUT")]
    DebugOutput = unchecked((uint)0x92E0),

    [NativeName("GL_CONTEXT_FLAG_DEBUG_BIT")]
    ContextFlagDebugBit = unchecked((uint)0x00000002),

    [NativeName("GL_MAX_UNIFORM_LOCATIONS")]
    MaxUniformLocations = unchecked((uint)0x826E),

    [NativeName("GL_FRAMEBUFFER_DEFAULT_WIDTH")]
    FramebufferDefaultWidth = unchecked((uint)0x9310),

    [NativeName("GL_FRAMEBUFFER_DEFAULT_HEIGHT")]
    FramebufferDefaultHeight = unchecked((uint)0x9311),

    [NativeName("GL_FRAMEBUFFER_DEFAULT_LAYERS")]
    FramebufferDefaultLayers = unchecked((uint)0x9312),

    [NativeName("GL_FRAMEBUFFER_DEFAULT_SAMPLES")]
    FramebufferDefaultSamples = unchecked((uint)0x9313),

    [NativeName("GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS")]
    FramebufferDefaultFixedSampleLocations = unchecked((uint)0x9314),

    [NativeName("GL_MAX_FRAMEBUFFER_WIDTH")]
    MaxFramebufferWidth = unchecked((uint)0x9315),

    [NativeName("GL_MAX_FRAMEBUFFER_HEIGHT")]
    MaxFramebufferHeight = unchecked((uint)0x9316),

    [NativeName("GL_MAX_FRAMEBUFFER_LAYERS")]
    MaxFramebufferLayers = unchecked((uint)0x9317),

    [NativeName("GL_MAX_FRAMEBUFFER_SAMPLES")]
    MaxFramebufferSamples = unchecked((uint)0x9318),

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

    [NativeName("GL_MAX_COMBINED_DIMENSIONS")]
    MaxCombinedDimensions = unchecked((uint)0x8282),

    [NativeName("GL_COLOR_COMPONENTS")]
    ColorComponents = unchecked((uint)0x8283),

    [NativeName("GL_DEPTH_COMPONENTS")]
    DepthComponents = unchecked((uint)0x8284),

    [NativeName("GL_STENCIL_COMPONENTS")]
    StencilComponents = unchecked((uint)0x8285),

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

    [NativeName("GL_MANUAL_GENERATE_MIPMAP")]
    ManualGenerateMipmap = unchecked((uint)0x8294),

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

    [NativeName("GL_FULL_SUPPORT")]
    FullSupport = unchecked((uint)0x82B7),

    [NativeName("GL_CAVEAT_SUPPORT")]
    CaveatSupport = unchecked((uint)0x82B8),

    [NativeName("GL_IMAGE_CLASS_4_X_32")]
    ImageClass4X32 = unchecked((uint)0x82B9),

    [NativeName("GL_IMAGE_CLASS_2_X_32")]
    ImageClass2X32 = unchecked((uint)0x82BA),

    [NativeName("GL_IMAGE_CLASS_1_X_32")]
    ImageClass1X32 = unchecked((uint)0x82BB),

    [NativeName("GL_IMAGE_CLASS_4_X_16")]
    ImageClass4X16 = unchecked((uint)0x82BC),

    [NativeName("GL_IMAGE_CLASS_2_X_16")]
    ImageClass2X16 = unchecked((uint)0x82BD),

    [NativeName("GL_IMAGE_CLASS_1_X_16")]
    ImageClass1X16 = unchecked((uint)0x82BE),

    [NativeName("GL_IMAGE_CLASS_4_X_8")]
    ImageClass4X8 = unchecked((uint)0x82BF),

    [NativeName("GL_IMAGE_CLASS_2_X_8")]
    ImageClass2X8 = unchecked((uint)0x82C0),

    [NativeName("GL_IMAGE_CLASS_1_X_8")]
    ImageClass1X8 = unchecked((uint)0x82C1),

    [NativeName("GL_IMAGE_CLASS_11_11_10")]
    ImageClass11X11X10 = unchecked((uint)0x82C2),

    [NativeName("GL_IMAGE_CLASS_10_10_10_2")]
    ImageClass10X10X10X2 = unchecked((uint)0x82C3),

    [NativeName("GL_VIEW_CLASS_128_BITS")]
    ViewClass128Bits = unchecked((uint)0x82C4),

    [NativeName("GL_VIEW_CLASS_96_BITS")]
    ViewClass96Bits = unchecked((uint)0x82C5),

    [NativeName("GL_VIEW_CLASS_64_BITS")]
    ViewClass64Bits = unchecked((uint)0x82C6),

    [NativeName("GL_VIEW_CLASS_48_BITS")]
    ViewClass48Bits = unchecked((uint)0x82C7),

    [NativeName("GL_VIEW_CLASS_32_BITS")]
    ViewClass32Bits = unchecked((uint)0x82C8),

    [NativeName("GL_VIEW_CLASS_24_BITS")]
    ViewClass24Bits = unchecked((uint)0x82C9),

    [NativeName("GL_VIEW_CLASS_16_BITS")]
    ViewClass16Bits = unchecked((uint)0x82CA),

    [NativeName("GL_VIEW_CLASS_8_BITS")]
    ViewClass8Bits = unchecked((uint)0x82CB),

    [NativeName("GL_VIEW_CLASS_S3TC_DXT1_RGB")]
    ViewClassS3TcDxt1Rgb = unchecked((uint)0x82CC),

    [NativeName("GL_VIEW_CLASS_S3TC_DXT1_RGBA")]
    ViewClassS3TcDxt1Rgba = unchecked((uint)0x82CD),

    [NativeName("GL_VIEW_CLASS_S3TC_DXT3_RGBA")]
    ViewClassS3TcDxt3Rgba = unchecked((uint)0x82CE),

    [NativeName("GL_VIEW_CLASS_S3TC_DXT5_RGBA")]
    ViewClassS3TcDxt5Rgba = unchecked((uint)0x82CF),

    [NativeName("GL_VIEW_CLASS_RGTC1_RED")]
    ViewClassRgtc1Red = unchecked((uint)0x82D0),

    [NativeName("GL_VIEW_CLASS_RGTC2_RG")]
    ViewClassRgtc2Rg = unchecked((uint)0x82D1),

    [NativeName("GL_VIEW_CLASS_BPTC_UNORM")]
    ViewClassBptcUnorm = unchecked((uint)0x82D2),

    [NativeName("GL_VIEW_CLASS_BPTC_FLOAT")]
    ViewClassBptcFloat = unchecked((uint)0x82D3),

    [NativeName("GL_UNIFORM")]
    Uniform = unchecked((uint)0x92E1),

    [NativeName("GL_UNIFORM_BLOCK")]
    UniformBlock = unchecked((uint)0x92E2),

    [NativeName("GL_PROGRAM_INPUT")]
    ProgramInput = unchecked((uint)0x92E3),

    [NativeName("GL_PROGRAM_OUTPUT")]
    ProgramOutput = unchecked((uint)0x92E4),

    [NativeName("GL_BUFFER_VARIABLE")]
    BufferVariable = unchecked((uint)0x92E5),

    [NativeName("GL_SHADER_STORAGE_BLOCK")]
    ShaderStorageBlock = unchecked((uint)0x92E6),

    [NativeName("GL_VERTEX_SUBROUTINE")]
    VertexSubroutine = unchecked((uint)0x92E8),

    [NativeName("GL_TESS_CONTROL_SUBROUTINE")]
    TessControlSubroutine = unchecked((uint)0x92E9),

    [NativeName("GL_TESS_EVALUATION_SUBROUTINE")]
    TessEvaluationSubroutine = unchecked((uint)0x92EA),

    [NativeName("GL_GEOMETRY_SUBROUTINE")]
    GeometrySubroutine = unchecked((uint)0x92EB),

    [NativeName("GL_FRAGMENT_SUBROUTINE")]
    FragmentSubroutine = unchecked((uint)0x92EC),

    [NativeName("GL_COMPUTE_SUBROUTINE")]
    ComputeSubroutine = unchecked((uint)0x92ED),

    [NativeName("GL_VERTEX_SUBROUTINE_UNIFORM")]
    VertexSubroutineUniform = unchecked((uint)0x92EE),

    [NativeName("GL_TESS_CONTROL_SUBROUTINE_UNIFORM")]
    TessControlSubroutineUniform = unchecked((uint)0x92EF),

    [NativeName("GL_TESS_EVALUATION_SUBROUTINE_UNIFORM")]
    TessEvaluationSubroutineUniform = unchecked((uint)0x92F0),

    [NativeName("GL_GEOMETRY_SUBROUTINE_UNIFORM")]
    GeometrySubroutineUniform = unchecked((uint)0x92F1),

    [NativeName("GL_FRAGMENT_SUBROUTINE_UNIFORM")]
    FragmentSubroutineUniform = unchecked((uint)0x92F2),

    [NativeName("GL_COMPUTE_SUBROUTINE_UNIFORM")]
    ComputeSubroutineUniform = unchecked((uint)0x92F3),

    [NativeName("GL_TRANSFORM_FEEDBACK_VARYING")]
    TransformFeedbackVarying = unchecked((uint)0x92F4),

    [NativeName("GL_ACTIVE_RESOURCES")]
    ActiveResources = unchecked((uint)0x92F5),

    [NativeName("GL_MAX_NAME_LENGTH")]
    MaxNameLength = unchecked((uint)0x92F6),

    [NativeName("GL_MAX_NUM_ACTIVE_VARIABLES")]
    MaxNumActiveVariables = unchecked((uint)0x92F7),

    [NativeName("GL_MAX_NUM_COMPATIBLE_SUBROUTINES")]
    MaxNumCompatibleSubroutines = unchecked((uint)0x92F8),

    [NativeName("GL_NAME_LENGTH")]
    NameLength = unchecked((uint)0x92F9),

    [NativeName("GL_TYPE")]
    Type = unchecked((uint)0x92FA),

    [NativeName("GL_ARRAY_SIZE")]
    ArraySize = unchecked((uint)0x92FB),

    [NativeName("GL_OFFSET")]
    Offset = unchecked((uint)0x92FC),

    [NativeName("GL_BLOCK_INDEX")]
    BlockIndex = unchecked((uint)0x92FD),

    [NativeName("GL_ARRAY_STRIDE")]
    ArrayStride = unchecked((uint)0x92FE),

    [NativeName("GL_MATRIX_STRIDE")]
    MatrixStride = unchecked((uint)0x92FF),

    [NativeName("GL_IS_ROW_MAJOR")]
    IsRowMajor = unchecked((uint)0x9300),

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_INDEX")]
    AtomicCounterBufferIndex = unchecked((uint)0x9301),

    [NativeName("GL_BUFFER_BINDING")]
    BufferBinding = unchecked((uint)0x9302),

    [NativeName("GL_BUFFER_DATA_SIZE")]
    BufferDataSize = unchecked((uint)0x9303),

    [NativeName("GL_NUM_ACTIVE_VARIABLES")]
    NumActiveVariables = unchecked((uint)0x9304),

    [NativeName("GL_ACTIVE_VARIABLES")]
    ActiveVariables = unchecked((uint)0x9305),

    [NativeName("GL_REFERENCED_BY_VERTEX_SHADER")]
    ReferencedByVertexShader = unchecked((uint)0x9306),

    [NativeName("GL_REFERENCED_BY_TESS_CONTROL_SHADER")]
    ReferencedByTessControlShader = unchecked((uint)0x9307),

    [NativeName("GL_REFERENCED_BY_TESS_EVALUATION_SHADER")]
    ReferencedByTessEvaluationShader = unchecked((uint)0x9308),

    [NativeName("GL_REFERENCED_BY_GEOMETRY_SHADER")]
    ReferencedByGeometryShader = unchecked((uint)0x9309),

    [NativeName("GL_REFERENCED_BY_FRAGMENT_SHADER")]
    ReferencedByFragmentShader = unchecked((uint)0x930A),

    [NativeName("GL_REFERENCED_BY_COMPUTE_SHADER")]
    ReferencedByComputeShader = unchecked((uint)0x930B),

    [NativeName("GL_TOP_LEVEL_ARRAY_SIZE")]
    TopLevelArraySize = unchecked((uint)0x930C),

    [NativeName("GL_TOP_LEVEL_ARRAY_STRIDE")]
    TopLevelArrayStride = unchecked((uint)0x930D),

    [NativeName("GL_LOCATION")]
    Location = unchecked((uint)0x930E),

    [NativeName("GL_LOCATION_INDEX")]
    LocationIndex = unchecked((uint)0x930F),

    [NativeName("GL_IS_PER_PATCH")]
    IsPerPatch = unchecked((uint)0x92E7),

    [NativeName("GL_SHADER_STORAGE_BUFFER")]
    ShaderStorageBuffer = unchecked((uint)0x90D2),

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

    [NativeName("GL_MAX_SHADER_STORAGE_BLOCK_SIZE")]
    MaxShaderStorageBlockSize = unchecked((uint)0x90DE),

    [NativeName("GL_SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT")]
    ShaderStorageBufferOffsetAlignment = unchecked((uint)0x90DF),

    [NativeName("GL_SHADER_STORAGE_BARRIER_BIT")]
    ShaderStorageBarrierBit = unchecked((uint)0x00002000),

    [NativeName("GL_MAX_COMBINED_SHADER_OUTPUT_RESOURCES")]
    MaxCombinedShaderOutputResources = unchecked((uint)0x8F39),

    [NativeName("GL_DEPTH_STENCIL_TEXTURE_MODE")]
    DepthStencilTextureMode = unchecked((uint)0x90EA),

    [NativeName("GL_TEXTURE_BUFFER_OFFSET")]
    TextureBufferOffset = unchecked((uint)0x919D),

    [NativeName("GL_TEXTURE_BUFFER_SIZE")]
    TextureBufferSize = unchecked((uint)0x919E),

    [NativeName("GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT")]
    TextureBufferOffsetAlignment = unchecked((uint)0x919F),

    [NativeName("GL_TEXTURE_VIEW_MIN_LEVEL")]
    TextureViewMinLevel = unchecked((uint)0x82DB),

    [NativeName("GL_TEXTURE_VIEW_NUM_LEVELS")]
    TextureViewNumLevels = unchecked((uint)0x82DC),

    [NativeName("GL_TEXTURE_VIEW_MIN_LAYER")]
    TextureViewMinLayer = unchecked((uint)0x82DD),

    [NativeName("GL_TEXTURE_VIEW_NUM_LAYERS")]
    TextureViewNumLayers = unchecked((uint)0x82DE),

    [NativeName("GL_TEXTURE_IMMUTABLE_LEVELS")]
    TextureImmutableLevels = unchecked((uint)0x82DF),

    [NativeName("GL_VERTEX_ATTRIB_BINDING")]
    VertexAttribBinding = unchecked((uint)0x82D4),

    [NativeName("GL_VERTEX_ATTRIB_RELATIVE_OFFSET")]
    VertexAttribRelativeOffset = unchecked((uint)0x82D5),

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

    [NativeName("GL_VERTEX_BINDING_BUFFER")]
    VertexBindingBuffer = unchecked((uint)0x8F4F),

    [NativeName("GL_DISPLAY_LIST")]
    DisplayList = unchecked((uint)0x82E7),

    [NativeName("GL_MAX_VERTEX_ATTRIB_STRIDE")]
    MaxVertexAttribStride = unchecked((uint)0x82E5),

    [NativeName("GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED")]
    PrimitiveRestartForPatchesSupported = unchecked((uint)0x8221),

    [NativeName("GL_TEXTURE_BUFFER_BINDING")]
    TextureBufferBinding = unchecked((uint)0x8C2A),

    [NativeName("GL_MAP_PERSISTENT_BIT")]
    MapPersistentBit = unchecked((uint)0x0040),

    [NativeName("GL_MAP_COHERENT_BIT")]
    MapCoherentBit = unchecked((uint)0x0080),

    [NativeName("GL_DYNAMIC_STORAGE_BIT")]
    DynamicStorageBit = unchecked((uint)0x0100),

    [NativeName("GL_CLIENT_STORAGE_BIT")]
    ClientStorageBit = unchecked((uint)0x0200),

    [NativeName("GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT")]
    ClientMappedBufferBarrierBit = unchecked((uint)0x00004000),

    [NativeName("GL_BUFFER_IMMUTABLE_STORAGE")]
    BufferImmutableStorage = unchecked((uint)0x821F),

    [NativeName("GL_BUFFER_STORAGE_FLAGS")]
    BufferStorageFlags = unchecked((uint)0x8220),

    [NativeName("GL_CLEAR_TEXTURE")]
    ClearTexture = unchecked((uint)0x9365),

    [NativeName("GL_LOCATION_COMPONENT")]
    LocationComponent = unchecked((uint)0x934A),

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_INDEX")]
    TransformFeedbackBufferIndex = unchecked((uint)0x934B),

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_STRIDE")]
    TransformFeedbackBufferStride = unchecked((uint)0x934C),

    [NativeName("GL_QUERY_BUFFER")]
    QueryBuffer = unchecked((uint)0x9192),

    [NativeName("GL_QUERY_BUFFER_BARRIER_BIT")]
    QueryBufferBarrierBit = unchecked((uint)0x00008000),

    [NativeName("GL_QUERY_BUFFER_BINDING")]
    QueryBufferBinding = unchecked((uint)0x9193),

    [NativeName("GL_QUERY_RESULT_NO_WAIT")]
    QueryResultNoWait = unchecked((uint)0x9194),

    [NativeName("GL_MIRROR_CLAMP_TO_EDGE")]
    MirrorClampToEdge = unchecked((uint)0x8743),

    [NativeName("GL_CONTEXT_LOST")]
    ContextLost = unchecked((uint)0x0507),

    [NativeName("GL_NEGATIVE_ONE_TO_ONE")]
    NegativeOneToOne = unchecked((uint)0x935E),

    [NativeName("GL_ZERO_TO_ONE")]
    ZeroToOne = unchecked((uint)0x935F),

    [NativeName("GL_CLIP_ORIGIN")]
    ClipOrigin = unchecked((uint)0x935C),

    [NativeName("GL_CLIP_DEPTH_MODE")]
    ClipDepthMode = unchecked((uint)0x935D),

    [NativeName("GL_QUERY_WAIT_INVERTED")]
    QueryWaitInverted = unchecked((uint)0x8E17),

    [NativeName("GL_QUERY_NO_WAIT_INVERTED")]
    QueryNoWaitInverted = unchecked((uint)0x8E18),

    [NativeName("GL_QUERY_BY_REGION_WAIT_INVERTED")]
    QueryByRegionWaitInverted = unchecked((uint)0x8E19),

    [NativeName("GL_QUERY_BY_REGION_NO_WAIT_INVERTED")]
    QueryByRegionNoWaitInverted = unchecked((uint)0x8E1A),

    [NativeName("GL_MAX_CULL_DISTANCES")]
    MaxCullDistances = unchecked((uint)0x82F9),

    [NativeName("GL_MAX_COMBINED_CLIP_AND_CULL_DISTANCES")]
    MaxCombinedClipAndCullDistances = unchecked((uint)0x82FA),

    [NativeName("GL_TEXTURE_TARGET")]
    TextureTarget = unchecked((uint)0x1006),

    [NativeName("GL_QUERY_TARGET")]
    QueryTarget = unchecked((uint)0x82EA),

    [NativeName("GL_GUILTY_CONTEXT_RESET")]
    GuiltyContextReset = unchecked((uint)0x8253),

    [NativeName("GL_INNOCENT_CONTEXT_RESET")]
    InnocentContextReset = unchecked((uint)0x8254),

    [NativeName("GL_UNKNOWN_CONTEXT_RESET")]
    UnknownContextReset = unchecked((uint)0x8255),

    [NativeName("GL_RESET_NOTIFICATION_STRATEGY")]
    ResetNotificationStrategy = unchecked((uint)0x8256),

    [NativeName("GL_LOSE_CONTEXT_ON_RESET")]
    LoseContextOnReset = unchecked((uint)0x8252),

    [NativeName("GL_NO_RESET_NOTIFICATION")]
    NoResetNotification = unchecked((uint)0x8261),

    [NativeName("GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT")]
    ContextFlagRobustAccessBit = unchecked((uint)0x00000004),

    [NativeName("GL_COLOR_TABLE")]
    ColorTable = unchecked((uint)0x80D0),

    [NativeName("GL_POST_CONVOLUTION_COLOR_TABLE")]
    PostConvolutionColorTable = unchecked((uint)0x80D1),

    [NativeName("GL_POST_COLOR_MATRIX_COLOR_TABLE")]
    PostColorMatrixColorTable = unchecked((uint)0x80D2),

    [NativeName("GL_PROXY_COLOR_TABLE")]
    ProxyColorTable = unchecked((uint)0x80D3),

    [NativeName("GL_PROXY_POST_CONVOLUTION_COLOR_TABLE")]
    ProxyPostConvolutionColorTable = unchecked((uint)0x80D4),

    [NativeName("GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE")]
    ProxyPostColorMatrixColorTable = unchecked((uint)0x80D5),

    [NativeName("GL_CONVOLUTION_1D")]
    Convolution1D = unchecked((uint)0x8010),

    [NativeName("GL_CONVOLUTION_2D")]
    Convolution2D = unchecked((uint)0x8011),

    [NativeName("GL_SEPARABLE_2D")]
    Separable2D = unchecked((uint)0x8012),

    [NativeName("GL_HISTOGRAM")]
    Histogram = unchecked((uint)0x8024),

    [NativeName("GL_PROXY_HISTOGRAM")]
    ProxyHistogram = unchecked((uint)0x8025),

    [NativeName("GL_MINMAX")]
    Minmax = unchecked((uint)0x802E),

    [NativeName("GL_CONTEXT_RELEASE_BEHAVIOR")]
    ContextReleaseBehavior = unchecked((uint)0x82FB),

    [NativeName("GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH")]
    ContextReleaseBehaviorFlush = unchecked((uint)0x82FC),

    [NativeName("GL_SHADER_BINARY_FORMAT_SPIR_V")]
    ShaderBinaryFormatSpirV = unchecked((uint)0x9551),

    [NativeName("GL_SPIR_V_BINARY")]
    SpirVBinary = unchecked((uint)0x9552),

    [NativeName("GL_PARAMETER_BUFFER")]
    ParameterBuffer = unchecked((uint)0x80EE),

    [NativeName("GL_PARAMETER_BUFFER_BINDING")]
    ParameterBufferBinding = unchecked((uint)0x80EF),

    [NativeName("GL_CONTEXT_FLAG_NO_ERROR_BIT")]
    ContextFlagNoErrorBit = unchecked((uint)0x00000008),

    [NativeName("GL_VERTICES_SUBMITTED")]
    VerticesSubmitted = unchecked((uint)0x82EE),

    [NativeName("GL_PRIMITIVES_SUBMITTED")]
    PrimitivesSubmitted = unchecked((uint)0x82EF),

    [NativeName("GL_VERTEX_SHADER_INVOCATIONS")]
    VertexShaderInvocations = unchecked((uint)0x82F0),

    [NativeName("GL_TESS_CONTROL_SHADER_PATCHES")]
    TessControlShaderPatches = unchecked((uint)0x82F1),

    [NativeName("GL_TESS_EVALUATION_SHADER_INVOCATIONS")]
    TessEvaluationShaderInvocations = unchecked((uint)0x82F2),

    [NativeName("GL_GEOMETRY_SHADER_PRIMITIVES_EMITTED")]
    GeometryShaderPrimitivesEmitted = unchecked((uint)0x82F3),

    [NativeName("GL_FRAGMENT_SHADER_INVOCATIONS")]
    FragmentShaderInvocations = unchecked((uint)0x82F4),

    [NativeName("GL_COMPUTE_SHADER_INVOCATIONS")]
    ComputeShaderInvocations = unchecked((uint)0x82F5),

    [NativeName("GL_CLIPPING_INPUT_PRIMITIVES")]
    ClippingInputPrimitives = unchecked((uint)0x82F6),

    [NativeName("GL_CLIPPING_OUTPUT_PRIMITIVES")]
    ClippingOutputPrimitives = unchecked((uint)0x82F7),

    [NativeName("GL_POLYGON_OFFSET_CLAMP")]
    PolygonOffsetClamp = unchecked((uint)0x8E1B),

    [NativeName("GL_SPIR_V_EXTENSIONS")]
    SpirVExtensions = unchecked((uint)0x9553),

    [NativeName("GL_NUM_SPIR_V_EXTENSIONS")]
    NumSpirVExtensions = unchecked((uint)0x9554),

    [NativeName("GL_TEXTURE_MAX_ANISOTROPY")]
    TextureMaxAnisotropy = unchecked((uint)0x84FE),

    [NativeName("GL_MAX_TEXTURE_MAX_ANISOTROPY")]
    MaxTextureMaxAnisotropy = unchecked((uint)0x84FF),

    [NativeName("GL_TRANSFORM_FEEDBACK_OVERFLOW")]
    TransformFeedbackOverflow = unchecked((uint)0x82EC),

    [NativeName("GL_TRANSFORM_FEEDBACK_STREAM_OVERFLOW")]
    TransformFeedbackStreamOverflow = unchecked((uint)0x82ED),

    [NativeName("GL_PRIMITIVE_BOUNDING_BOX_ARB")]
    PrimitiveBoundingBoxARB = unchecked((uint)0x92BE),

    [NativeName("GL_MULTISAMPLE_LINE_WIDTH_RANGE_ARB")]
    MultisampleLineWidthRangeARB = unchecked((uint)0x9381),

    [NativeName("GL_MULTISAMPLE_LINE_WIDTH_GRANULARITY_ARB")]
    MultisampleLineWidthGranularityARB = unchecked((uint)0x9382),

    [NativeName("GL_UNSIGNED_INT64_ARB")]
    UnsignedInt64ARB = unchecked((uint)0x140F),

    [NativeName("GL_SYNC_CL_EVENT_ARB")]
    SyncClEventARB = unchecked((uint)0x8240),

    [NativeName("GL_SYNC_CL_EVENT_COMPLETE_ARB")]
    SyncClEventCompleteARB = unchecked((uint)0x8241),

    [NativeName("GL_RGBA_FLOAT_MODE_ARB")]
    RgbaFloatModeARB = unchecked((uint)0x8820),

    [NativeName("GL_CLAMP_VERTEX_COLOR_ARB")]
    ClampVertexColorARB = unchecked((uint)0x891A),

    [NativeName("GL_CLAMP_FRAGMENT_COLOR_ARB")]
    ClampFragmentColorARB = unchecked((uint)0x891B),

    [NativeName("GL_CLAMP_READ_COLOR_ARB")]
    ClampReadColorARB = unchecked((uint)0x891C),

    [NativeName("GL_FIXED_ONLY_ARB")]
    FixedOnlyARB = unchecked((uint)0x891D),

    [NativeName("GL_MAX_COMPUTE_VARIABLE_GROUP_INVOCATIONS_ARB")]
    MaxComputeVariableGroupInvocationsARB = unchecked((uint)0x9344),

    [NativeName("GL_MAX_COMPUTE_FIXED_GROUP_INVOCATIONS_ARB")]
    MaxComputeFixedGroupInvocationsARB = unchecked((uint)0x90EB),

    [NativeName("GL_MAX_COMPUTE_VARIABLE_GROUP_SIZE_ARB")]
    MaxComputeVariableGroupSizeARB = unchecked((uint)0x9345),

    [NativeName("GL_MAX_COMPUTE_FIXED_GROUP_SIZE_ARB")]
    MaxComputeFixedGroupSizeARB = unchecked((uint)0x91BF),

    [NativeName("GL_DEBUG_OUTPUT_SYNCHRONOUS_ARB")]
    DebugOutputSynchronousARB = unchecked((uint)0x8242),

    [NativeName("GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_ARB")]
    DebugNextLoggedMessageLengthARB = unchecked((uint)0x8243),

    [NativeName("GL_DEBUG_CALLBACK_FUNCTION_ARB")]
    DebugCallbackFunctionARB = unchecked((uint)0x8244),

    [NativeName("GL_DEBUG_CALLBACK_USER_PARAM_ARB")]
    DebugCallbackUserParamARB = unchecked((uint)0x8245),

    [NativeName("GL_DEBUG_SOURCE_API_ARB")]
    DebugSourceApiARB = unchecked((uint)0x8246),

    [NativeName("GL_DEBUG_SOURCE_WINDOW_SYSTEM_ARB")]
    DebugSourceWindowSystemARB = unchecked((uint)0x8247),

    [NativeName("GL_DEBUG_SOURCE_SHADER_COMPILER_ARB")]
    DebugSourceShaderCompilerARB = unchecked((uint)0x8248),

    [NativeName("GL_DEBUG_SOURCE_THIRD_PARTY_ARB")]
    DebugSourceThirdPartyARB = unchecked((uint)0x8249),

    [NativeName("GL_DEBUG_SOURCE_APPLICATION_ARB")]
    DebugSourceApplicationARB = unchecked((uint)0x824A),

    [NativeName("GL_DEBUG_SOURCE_OTHER_ARB")]
    DebugSourceOtherARB = unchecked((uint)0x824B),

    [NativeName("GL_DEBUG_TYPE_ERROR_ARB")]
    DebugTypeErrorARB = unchecked((uint)0x824C),

    [NativeName("GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_ARB")]
    DebugTypeDeprecatedBehaviorARB = unchecked((uint)0x824D),

    [NativeName("GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_ARB")]
    DebugTypeUndefinedBehaviorARB = unchecked((uint)0x824E),

    [NativeName("GL_DEBUG_TYPE_PORTABILITY_ARB")]
    DebugTypePortabilityARB = unchecked((uint)0x824F),

    [NativeName("GL_DEBUG_TYPE_PERFORMANCE_ARB")]
    DebugTypePerformanceARB = unchecked((uint)0x8250),

    [NativeName("GL_DEBUG_TYPE_OTHER_ARB")]
    DebugTypeOtherARB = unchecked((uint)0x8251),

    [NativeName("GL_MAX_DEBUG_MESSAGE_LENGTH_ARB")]
    MaxDebugMessageLengthARB = unchecked((uint)0x9143),

    [NativeName("GL_MAX_DEBUG_LOGGED_MESSAGES_ARB")]
    MaxDebugLoggedMessagesARB = unchecked((uint)0x9144),

    [NativeName("GL_DEBUG_LOGGED_MESSAGES_ARB")]
    DebugLoggedMessagesARB = unchecked((uint)0x9145),

    [NativeName("GL_DEBUG_SEVERITY_HIGH_ARB")]
    DebugSeverityHighARB = unchecked((uint)0x9146),

    [NativeName("GL_DEBUG_SEVERITY_MEDIUM_ARB")]
    DebugSeverityMediumARB = unchecked((uint)0x9147),

    [NativeName("GL_DEBUG_SEVERITY_LOW_ARB")]
    DebugSeverityLowARB = unchecked((uint)0x9148),

    [NativeName("GL_DEPTH_COMPONENT16_ARB")]
    DepthComponent16ARB = unchecked((uint)0x81A5),

    [NativeName("GL_DEPTH_COMPONENT24_ARB")]
    DepthComponent24ARB = unchecked((uint)0x81A6),

    [NativeName("GL_DEPTH_COMPONENT32_ARB")]
    DepthComponent32ARB = unchecked((uint)0x81A7),

    [NativeName("GL_TEXTURE_DEPTH_SIZE_ARB")]
    TextureDepthSizeARB = unchecked((uint)0x884A),

    [NativeName("GL_DEPTH_TEXTURE_MODE_ARB")]
    DepthTextureModeARB = unchecked((uint)0x884B),

    [NativeName("GL_MAX_DRAW_BUFFERS_ARB")]
    MaxDrawBuffersARB = unchecked((uint)0x8824),

    [NativeName("GL_DRAW_BUFFER0_ARB")]
    DrawBuffer0ARB = unchecked((uint)0x8825),

    [NativeName("GL_DRAW_BUFFER1_ARB")]
    DrawBuffer1ARB = unchecked((uint)0x8826),

    [NativeName("GL_DRAW_BUFFER2_ARB")]
    DrawBuffer2ARB = unchecked((uint)0x8827),

    [NativeName("GL_DRAW_BUFFER3_ARB")]
    DrawBuffer3ARB = unchecked((uint)0x8828),

    [NativeName("GL_DRAW_BUFFER4_ARB")]
    DrawBuffer4ARB = unchecked((uint)0x8829),

    [NativeName("GL_DRAW_BUFFER5_ARB")]
    DrawBuffer5ARB = unchecked((uint)0x882A),

    [NativeName("GL_DRAW_BUFFER6_ARB")]
    DrawBuffer6ARB = unchecked((uint)0x882B),

    [NativeName("GL_DRAW_BUFFER7_ARB")]
    DrawBuffer7ARB = unchecked((uint)0x882C),

    [NativeName("GL_DRAW_BUFFER8_ARB")]
    DrawBuffer8ARB = unchecked((uint)0x882D),

    [NativeName("GL_DRAW_BUFFER9_ARB")]
    DrawBuffer9ARB = unchecked((uint)0x882E),

    [NativeName("GL_DRAW_BUFFER10_ARB")]
    DrawBuffer10ARB = unchecked((uint)0x882F),

    [NativeName("GL_DRAW_BUFFER11_ARB")]
    DrawBuffer11ARB = unchecked((uint)0x8830),

    [NativeName("GL_DRAW_BUFFER12_ARB")]
    DrawBuffer12ARB = unchecked((uint)0x8831),

    [NativeName("GL_DRAW_BUFFER13_ARB")]
    DrawBuffer13ARB = unchecked((uint)0x8832),

    [NativeName("GL_DRAW_BUFFER14_ARB")]
    DrawBuffer14ARB = unchecked((uint)0x8833),

    [NativeName("GL_DRAW_BUFFER15_ARB")]
    DrawBuffer15ARB = unchecked((uint)0x8834),

    [NativeName("GL_FRAGMENT_PROGRAM_ARB")]
    FragmentProgramARB = unchecked((uint)0x8804),

    [NativeName("GL_PROGRAM_FORMAT_ASCII_ARB")]
    ProgramFormatAsciiARB = unchecked((uint)0x8875),

    [NativeName("GL_PROGRAM_LENGTH_ARB")]
    ProgramLengthARB = unchecked((uint)0x8627),

    [NativeName("GL_PROGRAM_FORMAT_ARB")]
    ProgramFormatARB = unchecked((uint)0x8876),

    [NativeName("GL_PROGRAM_BINDING_ARB")]
    ProgramBindingARB = unchecked((uint)0x8677),

    [NativeName("GL_PROGRAM_INSTRUCTIONS_ARB")]
    ProgramInstructionsARB = unchecked((uint)0x88A0),

    [NativeName("GL_MAX_PROGRAM_INSTRUCTIONS_ARB")]
    MaxProgramInstructionsARB = unchecked((uint)0x88A1),

    [NativeName("GL_PROGRAM_NATIVE_INSTRUCTIONS_ARB")]
    ProgramNativeInstructionsARB = unchecked((uint)0x88A2),

    [NativeName("GL_MAX_PROGRAM_NATIVE_INSTRUCTIONS_ARB")]
    MaxProgramNativeInstructionsARB = unchecked((uint)0x88A3),

    [NativeName("GL_PROGRAM_TEMPORARIES_ARB")]
    ProgramTemporariesARB = unchecked((uint)0x88A4),

    [NativeName("GL_MAX_PROGRAM_TEMPORARIES_ARB")]
    MaxProgramTemporariesARB = unchecked((uint)0x88A5),

    [NativeName("GL_PROGRAM_NATIVE_TEMPORARIES_ARB")]
    ProgramNativeTemporariesARB = unchecked((uint)0x88A6),

    [NativeName("GL_MAX_PROGRAM_NATIVE_TEMPORARIES_ARB")]
    MaxProgramNativeTemporariesARB = unchecked((uint)0x88A7),

    [NativeName("GL_PROGRAM_PARAMETERS_ARB")]
    ProgramParametersARB = unchecked((uint)0x88A8),

    [NativeName("GL_MAX_PROGRAM_PARAMETERS_ARB")]
    MaxProgramParametersARB = unchecked((uint)0x88A9),

    [NativeName("GL_PROGRAM_NATIVE_PARAMETERS_ARB")]
    ProgramNativeParametersARB = unchecked((uint)0x88AA),

    [NativeName("GL_MAX_PROGRAM_NATIVE_PARAMETERS_ARB")]
    MaxProgramNativeParametersARB = unchecked((uint)0x88AB),

    [NativeName("GL_PROGRAM_ATTRIBS_ARB")]
    ProgramAttribsARB = unchecked((uint)0x88AC),

    [NativeName("GL_MAX_PROGRAM_ATTRIBS_ARB")]
    MaxProgramAttribsARB = unchecked((uint)0x88AD),

    [NativeName("GL_PROGRAM_NATIVE_ATTRIBS_ARB")]
    ProgramNativeAttribsARB = unchecked((uint)0x88AE),

    [NativeName("GL_MAX_PROGRAM_NATIVE_ATTRIBS_ARB")]
    MaxProgramNativeAttribsARB = unchecked((uint)0x88AF),

    [NativeName("GL_MAX_PROGRAM_LOCAL_PARAMETERS_ARB")]
    MaxProgramLocalParametersARB = unchecked((uint)0x88B4),

    [NativeName("GL_MAX_PROGRAM_ENV_PARAMETERS_ARB")]
    MaxProgramEnvParametersARB = unchecked((uint)0x88B5),

    [NativeName("GL_PROGRAM_UNDER_NATIVE_LIMITS_ARB")]
    ProgramUnderNativeLimitsARB = unchecked((uint)0x88B6),

    [NativeName("GL_PROGRAM_ALU_INSTRUCTIONS_ARB")]
    ProgramAluInstructionsARB = unchecked((uint)0x8805),

    [NativeName("GL_PROGRAM_TEX_INSTRUCTIONS_ARB")]
    ProgramTexInstructionsARB = unchecked((uint)0x8806),

    [NativeName("GL_PROGRAM_TEX_INDIRECTIONS_ARB")]
    ProgramTexIndirectionsARB = unchecked((uint)0x8807),

    [NativeName("GL_PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB")]
    ProgramNativeAluInstructionsARB = unchecked((uint)0x8808),

    [NativeName("GL_PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB")]
    ProgramNativeTexInstructionsARB = unchecked((uint)0x8809),

    [NativeName("GL_PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB")]
    ProgramNativeTexIndirectionsARB = unchecked((uint)0x880A),

    [NativeName("GL_MAX_PROGRAM_ALU_INSTRUCTIONS_ARB")]
    MaxProgramAluInstructionsARB = unchecked((uint)0x880B),

    [NativeName("GL_MAX_PROGRAM_TEX_INSTRUCTIONS_ARB")]
    MaxProgramTexInstructionsARB = unchecked((uint)0x880C),

    [NativeName("GL_MAX_PROGRAM_TEX_INDIRECTIONS_ARB")]
    MaxProgramTexIndirectionsARB = unchecked((uint)0x880D),

    [NativeName("GL_MAX_PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB")]
    MaxProgramNativeAluInstructionsARB = unchecked((uint)0x880E),

    [NativeName("GL_MAX_PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB")]
    MaxProgramNativeTexInstructionsARB = unchecked((uint)0x880F),

    [NativeName("GL_MAX_PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB")]
    MaxProgramNativeTexIndirectionsARB = unchecked((uint)0x8810),

    [NativeName("GL_PROGRAM_STRING_ARB")]
    ProgramStringARB = unchecked((uint)0x8628),

    [NativeName("GL_PROGRAM_ERROR_POSITION_ARB")]
    ProgramErrorPositionARB = unchecked((uint)0x864B),

    [NativeName("GL_CURRENT_MATRIX_ARB")]
    CurrentMatrixARB = unchecked((uint)0x8641),

    [NativeName("GL_TRANSPOSE_CURRENT_MATRIX_ARB")]
    TransposeCurrentMatrixARB = unchecked((uint)0x88B7),

    [NativeName("GL_CURRENT_MATRIX_STACK_DEPTH_ARB")]
    CurrentMatrixStackDepthARB = unchecked((uint)0x8640),

    [NativeName("GL_MAX_PROGRAM_MATRICES_ARB")]
    MaxProgramMatricesARB = unchecked((uint)0x862F),

    [NativeName("GL_MAX_PROGRAM_MATRIX_STACK_DEPTH_ARB")]
    MaxProgramMatrixStackDepthARB = unchecked((uint)0x862E),

    [NativeName("GL_MAX_TEXTURE_COORDS_ARB")]
    MaxTextureCoordsARB = unchecked((uint)0x8871),

    [NativeName("GL_MAX_TEXTURE_IMAGE_UNITS_ARB")]
    MaxTextureImageUnitsARB = unchecked((uint)0x8872),

    [NativeName("GL_PROGRAM_ERROR_STRING_ARB")]
    ProgramErrorStringARB = unchecked((uint)0x8874),

    [NativeName("GL_MATRIX0_ARB")]
    Matrix0ARB = unchecked((uint)0x88C0),

    [NativeName("GL_MATRIX1_ARB")]
    Matrix1ARB = unchecked((uint)0x88C1),

    [NativeName("GL_MATRIX2_ARB")]
    Matrix2ARB = unchecked((uint)0x88C2),

    [NativeName("GL_MATRIX3_ARB")]
    Matrix3ARB = unchecked((uint)0x88C3),

    [NativeName("GL_MATRIX4_ARB")]
    Matrix4ARB = unchecked((uint)0x88C4),

    [NativeName("GL_MATRIX5_ARB")]
    Matrix5ARB = unchecked((uint)0x88C5),

    [NativeName("GL_MATRIX6_ARB")]
    Matrix6ARB = unchecked((uint)0x88C6),

    [NativeName("GL_MATRIX7_ARB")]
    Matrix7ARB = unchecked((uint)0x88C7),

    [NativeName("GL_MATRIX8_ARB")]
    Matrix8ARB = unchecked((uint)0x88C8),

    [NativeName("GL_MATRIX9_ARB")]
    Matrix9ARB = unchecked((uint)0x88C9),

    [NativeName("GL_MATRIX10_ARB")]
    Matrix10ARB = unchecked((uint)0x88CA),

    [NativeName("GL_MATRIX11_ARB")]
    Matrix11ARB = unchecked((uint)0x88CB),

    [NativeName("GL_MATRIX12_ARB")]
    Matrix12ARB = unchecked((uint)0x88CC),

    [NativeName("GL_MATRIX13_ARB")]
    Matrix13ARB = unchecked((uint)0x88CD),

    [NativeName("GL_MATRIX14_ARB")]
    Matrix14ARB = unchecked((uint)0x88CE),

    [NativeName("GL_MATRIX15_ARB")]
    Matrix15ARB = unchecked((uint)0x88CF),

    [NativeName("GL_MATRIX16_ARB")]
    Matrix16ARB = unchecked((uint)0x88D0),

    [NativeName("GL_MATRIX17_ARB")]
    Matrix17ARB = unchecked((uint)0x88D1),

    [NativeName("GL_MATRIX18_ARB")]
    Matrix18ARB = unchecked((uint)0x88D2),

    [NativeName("GL_MATRIX19_ARB")]
    Matrix19ARB = unchecked((uint)0x88D3),

    [NativeName("GL_MATRIX20_ARB")]
    Matrix20ARB = unchecked((uint)0x88D4),

    [NativeName("GL_MATRIX21_ARB")]
    Matrix21ARB = unchecked((uint)0x88D5),

    [NativeName("GL_MATRIX22_ARB")]
    Matrix22ARB = unchecked((uint)0x88D6),

    [NativeName("GL_MATRIX23_ARB")]
    Matrix23ARB = unchecked((uint)0x88D7),

    [NativeName("GL_MATRIX24_ARB")]
    Matrix24ARB = unchecked((uint)0x88D8),

    [NativeName("GL_MATRIX25_ARB")]
    Matrix25ARB = unchecked((uint)0x88D9),

    [NativeName("GL_MATRIX26_ARB")]
    Matrix26ARB = unchecked((uint)0x88DA),

    [NativeName("GL_MATRIX27_ARB")]
    Matrix27ARB = unchecked((uint)0x88DB),

    [NativeName("GL_MATRIX28_ARB")]
    Matrix28ARB = unchecked((uint)0x88DC),

    [NativeName("GL_MATRIX29_ARB")]
    Matrix29ARB = unchecked((uint)0x88DD),

    [NativeName("GL_MATRIX30_ARB")]
    Matrix30ARB = unchecked((uint)0x88DE),

    [NativeName("GL_MATRIX31_ARB")]
    Matrix31ARB = unchecked((uint)0x88DF),

    [NativeName("GL_FRAGMENT_SHADER_ARB")]
    FragmentShaderARB = unchecked((uint)0x8B30),

    [NativeName("GL_MAX_FRAGMENT_UNIFORM_COMPONENTS_ARB")]
    MaxFragmentUniformComponentsARB = unchecked((uint)0x8B49),

    [NativeName("GL_FRAGMENT_SHADER_DERIVATIVE_HINT_ARB")]
    FragmentShaderDerivativeHintARB = unchecked((uint)0x8B8B),

    [NativeName("GL_LINES_ADJACENCY_ARB")]
    LinesAdjacencyARB = unchecked((uint)0x000A),

    [NativeName("GL_LINE_STRIP_ADJACENCY_ARB")]
    LineStripAdjacencyARB = unchecked((uint)0x000B),

    [NativeName("GL_TRIANGLES_ADJACENCY_ARB")]
    TrianglesAdjacencyARB = unchecked((uint)0x000C),

    [NativeName("GL_TRIANGLE_STRIP_ADJACENCY_ARB")]
    TriangleStripAdjacencyARB = unchecked((uint)0x000D),

    [NativeName("GL_PROGRAM_POINT_SIZE_ARB")]
    ProgramPointSizeARB = unchecked((uint)0x8642),

    [NativeName("GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_ARB")]
    MaxGeometryTextureImageUnitsARB = unchecked((uint)0x8C29),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_LAYERED_ARB")]
    FramebufferAttachmentLayeredARB = unchecked((uint)0x8DA7),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_ARB")]
    FramebufferIncompleteLayerTargetsARB = unchecked((uint)0x8DA8),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_ARB")]
    FramebufferIncompleteLayerCountARB = unchecked((uint)0x8DA9),

    [NativeName("GL_GEOMETRY_SHADER_ARB")]
    GeometryShaderARB = unchecked((uint)0x8DD9),

    [NativeName("GL_GEOMETRY_VERTICES_OUT_ARB")]
    GeometryVerticesOutARB = unchecked((uint)0x8DDA),

    [NativeName("GL_GEOMETRY_INPUT_TYPE_ARB")]
    GeometryInputTypeARB = unchecked((uint)0x8DDB),

    [NativeName("GL_GEOMETRY_OUTPUT_TYPE_ARB")]
    GeometryOutputTypeARB = unchecked((uint)0x8DDC),

    [NativeName("GL_MAX_GEOMETRY_VARYING_COMPONENTS_ARB")]
    MaxGeometryVaryingComponentsARB = unchecked((uint)0x8DDD),

    [NativeName("GL_MAX_VERTEX_VARYING_COMPONENTS_ARB")]
    MaxVertexVaryingComponentsARB = unchecked((uint)0x8DDE),

    [NativeName("GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_ARB")]
    MaxGeometryUniformComponentsARB = unchecked((uint)0x8DDF),

    [NativeName("GL_MAX_GEOMETRY_OUTPUT_VERTICES_ARB")]
    MaxGeometryOutputVerticesARB = unchecked((uint)0x8DE0),

    [NativeName("GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_ARB")]
    MaxGeometryTotalOutputComponentsARB = unchecked((uint)0x8DE1),

    [NativeName("GL_SHADER_BINARY_FORMAT_SPIR_V_ARB")]
    ShaderBinaryFormatSpirVARB = unchecked((uint)0x9551),

    [NativeName("GL_SPIR_V_BINARY_ARB")]
    SpirVBinaryARB = unchecked((uint)0x9552),

    [NativeName("GL_INT64_ARB")]
    Int64ARB = unchecked((uint)0x140E),

    [NativeName("GL_INT64_VEC2_ARB")]
    Int64Vec2ARB = unchecked((uint)0x8FE9),

    [NativeName("GL_INT64_VEC3_ARB")]
    Int64Vec3ARB = unchecked((uint)0x8FEA),

    [NativeName("GL_INT64_VEC4_ARB")]
    Int64Vec4ARB = unchecked((uint)0x8FEB),

    [NativeName("GL_UNSIGNED_INT64_VEC2_ARB")]
    UnsignedInt64Vec2ARB = unchecked((uint)0x8FF5),

    [NativeName("GL_UNSIGNED_INT64_VEC3_ARB")]
    UnsignedInt64Vec3ARB = unchecked((uint)0x8FF6),

    [NativeName("GL_UNSIGNED_INT64_VEC4_ARB")]
    UnsignedInt64Vec4ARB = unchecked((uint)0x8FF7),

    [NativeName("GL_HALF_FLOAT_ARB")]
    HalfFloatARB = unchecked((uint)0x140B),

    [NativeName("GL_CONVOLUTION_BORDER_MODE")]
    ConvolutionBorderMode = unchecked((uint)0x8013),

    [NativeName("GL_CONVOLUTION_FILTER_SCALE")]
    ConvolutionFilterScale = unchecked((uint)0x8014),

    [NativeName("GL_CONVOLUTION_FILTER_BIAS")]
    ConvolutionFilterBias = unchecked((uint)0x8015),

    [NativeName("GL_REDUCE")]
    Reduce = unchecked((uint)0x8016),

    [NativeName("GL_CONVOLUTION_FORMAT")]
    ConvolutionFormat = unchecked((uint)0x8017),

    [NativeName("GL_CONVOLUTION_WIDTH")]
    ConvolutionWidth = unchecked((uint)0x8018),

    [NativeName("GL_CONVOLUTION_HEIGHT")]
    ConvolutionHeight = unchecked((uint)0x8019),

    [NativeName("GL_MAX_CONVOLUTION_WIDTH")]
    MaxConvolutionWidth = unchecked((uint)0x801A),

    [NativeName("GL_MAX_CONVOLUTION_HEIGHT")]
    MaxConvolutionHeight = unchecked((uint)0x801B),

    [NativeName("GL_POST_CONVOLUTION_RED_SCALE")]
    PostConvolutionRedScale = unchecked((uint)0x801C),

    [NativeName("GL_POST_CONVOLUTION_GREEN_SCALE")]
    PostConvolutionGreenScale = unchecked((uint)0x801D),

    [NativeName("GL_POST_CONVOLUTION_BLUE_SCALE")]
    PostConvolutionBlueScale = unchecked((uint)0x801E),

    [NativeName("GL_POST_CONVOLUTION_ALPHA_SCALE")]
    PostConvolutionAlphaScale = unchecked((uint)0x801F),

    [NativeName("GL_POST_CONVOLUTION_RED_BIAS")]
    PostConvolutionRedBias = unchecked((uint)0x8020),

    [NativeName("GL_POST_CONVOLUTION_GREEN_BIAS")]
    PostConvolutionGreenBias = unchecked((uint)0x8021),

    [NativeName("GL_POST_CONVOLUTION_BLUE_BIAS")]
    PostConvolutionBlueBias = unchecked((uint)0x8022),

    [NativeName("GL_POST_CONVOLUTION_ALPHA_BIAS")]
    PostConvolutionAlphaBias = unchecked((uint)0x8023),

    [NativeName("GL_HISTOGRAM_WIDTH")]
    HistogramWidth = unchecked((uint)0x8026),

    [NativeName("GL_HISTOGRAM_FORMAT")]
    HistogramFormat = unchecked((uint)0x8027),

    [NativeName("GL_HISTOGRAM_RED_SIZE")]
    HistogramRedSize = unchecked((uint)0x8028),

    [NativeName("GL_HISTOGRAM_GREEN_SIZE")]
    HistogramGreenSize = unchecked((uint)0x8029),

    [NativeName("GL_HISTOGRAM_BLUE_SIZE")]
    HistogramBlueSize = unchecked((uint)0x802A),

    [NativeName("GL_HISTOGRAM_ALPHA_SIZE")]
    HistogramAlphaSize = unchecked((uint)0x802B),

    [NativeName("GL_HISTOGRAM_LUMINANCE_SIZE")]
    HistogramLuminanceSize = unchecked((uint)0x802C),

    [NativeName("GL_HISTOGRAM_SINK")]
    HistogramSink = unchecked((uint)0x802D),

    [NativeName("GL_MINMAX_FORMAT")]
    MinmaxFormat = unchecked((uint)0x802F),

    [NativeName("GL_MINMAX_SINK")]
    MinmaxSink = unchecked((uint)0x8030),

    [NativeName("GL_TABLE_TOO_LARGE")]
    TableTooLarge = unchecked((uint)0x8031),

    [NativeName("GL_COLOR_MATRIX")]
    ColorMatrix = unchecked((uint)0x80B1),

    [NativeName("GL_COLOR_MATRIX_STACK_DEPTH")]
    ColorMatrixStackDepth = unchecked((uint)0x80B2),

    [NativeName("GL_MAX_COLOR_MATRIX_STACK_DEPTH")]
    MaxColorMatrixStackDepth = unchecked((uint)0x80B3),

    [NativeName("GL_POST_COLOR_MATRIX_RED_SCALE")]
    PostColorMatrixRedScale = unchecked((uint)0x80B4),

    [NativeName("GL_POST_COLOR_MATRIX_GREEN_SCALE")]
    PostColorMatrixGreenScale = unchecked((uint)0x80B5),

    [NativeName("GL_POST_COLOR_MATRIX_BLUE_SCALE")]
    PostColorMatrixBlueScale = unchecked((uint)0x80B6),

    [NativeName("GL_POST_COLOR_MATRIX_ALPHA_SCALE")]
    PostColorMatrixAlphaScale = unchecked((uint)0x80B7),

    [NativeName("GL_POST_COLOR_MATRIX_RED_BIAS")]
    PostColorMatrixRedBias = unchecked((uint)0x80B8),

    [NativeName("GL_POST_COLOR_MATRIX_GREEN_BIAS")]
    PostColorMatrixGreenBias = unchecked((uint)0x80B9),

    [NativeName("GL_POST_COLOR_MATRIX_BLUE_BIAS")]
    PostColorMatrixBlueBias = unchecked((uint)0x80BA),

    [NativeName("GL_POST_COLOR_MATRIX_ALPHA_BIAS")]
    PostColorMatrixAlphaBias = unchecked((uint)0x80BB),

    [NativeName("GL_COLOR_TABLE_SCALE")]
    ColorTableScale = unchecked((uint)0x80D6),

    [NativeName("GL_COLOR_TABLE_BIAS")]
    ColorTableBias = unchecked((uint)0x80D7),

    [NativeName("GL_COLOR_TABLE_FORMAT")]
    ColorTableFormat = unchecked((uint)0x80D8),

    [NativeName("GL_COLOR_TABLE_WIDTH")]
    ColorTableWidth = unchecked((uint)0x80D9),

    [NativeName("GL_COLOR_TABLE_RED_SIZE")]
    ColorTableRedSize = unchecked((uint)0x80DA),

    [NativeName("GL_COLOR_TABLE_GREEN_SIZE")]
    ColorTableGreenSize = unchecked((uint)0x80DB),

    [NativeName("GL_COLOR_TABLE_BLUE_SIZE")]
    ColorTableBlueSize = unchecked((uint)0x80DC),

    [NativeName("GL_COLOR_TABLE_ALPHA_SIZE")]
    ColorTableAlphaSize = unchecked((uint)0x80DD),

    [NativeName("GL_COLOR_TABLE_LUMINANCE_SIZE")]
    ColorTableLuminanceSize = unchecked((uint)0x80DE),

    [NativeName("GL_COLOR_TABLE_INTENSITY_SIZE")]
    ColorTableIntensitySize = unchecked((uint)0x80DF),

    [NativeName("GL_CONSTANT_BORDER")]
    ConstantBorder = unchecked((uint)0x8151),

    [NativeName("GL_REPLICATE_BORDER")]
    ReplicateBorder = unchecked((uint)0x8153),

    [NativeName("GL_CONVOLUTION_BORDER_COLOR")]
    ConvolutionBorderColor = unchecked((uint)0x8154),

    [NativeName("GL_PARAMETER_BUFFER_ARB")]
    ParameterBufferARB = unchecked((uint)0x80EE),

    [NativeName("GL_PARAMETER_BUFFER_BINDING_ARB")]
    ParameterBufferBindingARB = unchecked((uint)0x80EF),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_DIVISOR_ARB")]
    VertexAttribArrayDivisorARB = unchecked((uint)0x88FE),

    [NativeName("GL_SRGB_DECODE_ARB")]
    SrgbDecodeARB = unchecked((uint)0x8299),

    [NativeName("GL_VIEW_CLASS_EAC_R11")]
    ViewClassEacR11 = unchecked((uint)0x9383),

    [NativeName("GL_VIEW_CLASS_EAC_RG11")]
    ViewClassEacRg11 = unchecked((uint)0x9384),

    [NativeName("GL_VIEW_CLASS_ETC2_RGB")]
    ViewClassEtc2Rgb = unchecked((uint)0x9385),

    [NativeName("GL_VIEW_CLASS_ETC2_RGBA")]
    ViewClassEtc2Rgba = unchecked((uint)0x9386),

    [NativeName("GL_VIEW_CLASS_ETC2_EAC_RGBA")]
    ViewClassEtc2EacRgba = unchecked((uint)0x9387),

    [NativeName("GL_VIEW_CLASS_ASTC_4x4_RGBA")]
    ViewClassAstc4X4Rgba = unchecked((uint)0x9388),

    [NativeName("GL_VIEW_CLASS_ASTC_5x4_RGBA")]
    ViewClassAstc5X4Rgba = unchecked((uint)0x9389),

    [NativeName("GL_VIEW_CLASS_ASTC_5x5_RGBA")]
    ViewClassAstc5X5Rgba = unchecked((uint)0x938A),

    [NativeName("GL_VIEW_CLASS_ASTC_6x5_RGBA")]
    ViewClassAstc6X5Rgba = unchecked((uint)0x938B),

    [NativeName("GL_VIEW_CLASS_ASTC_6x6_RGBA")]
    ViewClassAstc6X6Rgba = unchecked((uint)0x938C),

    [NativeName("GL_VIEW_CLASS_ASTC_8x5_RGBA")]
    ViewClassAstc8X5Rgba = unchecked((uint)0x938D),

    [NativeName("GL_VIEW_CLASS_ASTC_8x6_RGBA")]
    ViewClassAstc8X6Rgba = unchecked((uint)0x938E),

    [NativeName("GL_VIEW_CLASS_ASTC_8x8_RGBA")]
    ViewClassAstc8X8Rgba = unchecked((uint)0x938F),

    [NativeName("GL_VIEW_CLASS_ASTC_10x5_RGBA")]
    ViewClassAstc10X5Rgba = unchecked((uint)0x9390),

    [NativeName("GL_VIEW_CLASS_ASTC_10x6_RGBA")]
    ViewClassAstc10X6Rgba = unchecked((uint)0x9391),

    [NativeName("GL_VIEW_CLASS_ASTC_10x8_RGBA")]
    ViewClassAstc10X8Rgba = unchecked((uint)0x9392),

    [NativeName("GL_VIEW_CLASS_ASTC_10x10_RGBA")]
    ViewClassAstc10X10Rgba = unchecked((uint)0x9393),

    [NativeName("GL_VIEW_CLASS_ASTC_12x10_RGBA")]
    ViewClassAstc12X10Rgba = unchecked((uint)0x9394),

    [NativeName("GL_VIEW_CLASS_ASTC_12x12_RGBA")]
    ViewClassAstc12X12Rgba = unchecked((uint)0x9395),

    [NativeName("GL_MATRIX_PALETTE_ARB")]
    MatrixPaletteARB = unchecked((uint)0x8840),

    [NativeName("GL_MAX_MATRIX_PALETTE_STACK_DEPTH_ARB")]
    MaxMatrixPaletteStackDepthARB = unchecked((uint)0x8841),

    [NativeName("GL_MAX_PALETTE_MATRICES_ARB")]
    MaxPaletteMatricesARB = unchecked((uint)0x8842),

    [NativeName("GL_CURRENT_PALETTE_MATRIX_ARB")]
    CurrentPaletteMatrixARB = unchecked((uint)0x8843),

    [NativeName("GL_MATRIX_INDEX_ARRAY_ARB")]
    MatrixIndexArrayARB = unchecked((uint)0x8844),

    [NativeName("GL_CURRENT_MATRIX_INDEX_ARB")]
    CurrentMatrixIndexARB = unchecked((uint)0x8845),

    [NativeName("GL_MATRIX_INDEX_ARRAY_SIZE_ARB")]
    MatrixIndexArraySizeARB = unchecked((uint)0x8846),

    [NativeName("GL_MATRIX_INDEX_ARRAY_TYPE_ARB")]
    MatrixIndexArrayTypeARB = unchecked((uint)0x8847),

    [NativeName("GL_MATRIX_INDEX_ARRAY_STRIDE_ARB")]
    MatrixIndexArrayStrideARB = unchecked((uint)0x8848),

    [NativeName("GL_MATRIX_INDEX_ARRAY_POINTER_ARB")]
    MatrixIndexArrayPointerARB = unchecked((uint)0x8849),

    [NativeName("GL_MULTISAMPLE_ARB")]
    MultisampleARB = unchecked((uint)0x809D),

    [NativeName("GL_SAMPLE_ALPHA_TO_COVERAGE_ARB")]
    SampleAlphaToCoverageARB = unchecked((uint)0x809E),

    [NativeName("GL_SAMPLE_ALPHA_TO_ONE_ARB")]
    SampleAlphaToOneARB = unchecked((uint)0x809F),

    [NativeName("GL_SAMPLE_COVERAGE_ARB")]
    SampleCoverageARB = unchecked((uint)0x80A0),

    [NativeName("GL_SAMPLE_BUFFERS_ARB")]
    SampleBuffersARB = unchecked((uint)0x80A8),

    [NativeName("GL_SAMPLES_ARB")]
    SamplesARB = unchecked((uint)0x80A9),

    [NativeName("GL_SAMPLE_COVERAGE_VALUE_ARB")]
    SampleCoverageValueARB = unchecked((uint)0x80AA),

    [NativeName("GL_SAMPLE_COVERAGE_INVERT_ARB")]
    SampleCoverageInvertARB = unchecked((uint)0x80AB),

    [NativeName("GL_MULTISAMPLE_BIT_ARB")]
    MultisampleBitARB = unchecked((uint)0x20000000),

    [NativeName("GL_TEXTURE0_ARB")]
    Texture0ARB = unchecked((uint)0x84C0),

    [NativeName("GL_TEXTURE1_ARB")]
    Texture1ARB = unchecked((uint)0x84C1),

    [NativeName("GL_TEXTURE2_ARB")]
    Texture2ARB = unchecked((uint)0x84C2),

    [NativeName("GL_TEXTURE3_ARB")]
    Texture3ARB = unchecked((uint)0x84C3),

    [NativeName("GL_TEXTURE4_ARB")]
    Texture4ARB = unchecked((uint)0x84C4),

    [NativeName("GL_TEXTURE5_ARB")]
    Texture5ARB = unchecked((uint)0x84C5),

    [NativeName("GL_TEXTURE6_ARB")]
    Texture6ARB = unchecked((uint)0x84C6),

    [NativeName("GL_TEXTURE7_ARB")]
    Texture7ARB = unchecked((uint)0x84C7),

    [NativeName("GL_TEXTURE8_ARB")]
    Texture8ARB = unchecked((uint)0x84C8),

    [NativeName("GL_TEXTURE9_ARB")]
    Texture9ARB = unchecked((uint)0x84C9),

    [NativeName("GL_TEXTURE10_ARB")]
    Texture10ARB = unchecked((uint)0x84CA),

    [NativeName("GL_TEXTURE11_ARB")]
    Texture11ARB = unchecked((uint)0x84CB),

    [NativeName("GL_TEXTURE12_ARB")]
    Texture12ARB = unchecked((uint)0x84CC),

    [NativeName("GL_TEXTURE13_ARB")]
    Texture13ARB = unchecked((uint)0x84CD),

    [NativeName("GL_TEXTURE14_ARB")]
    Texture14ARB = unchecked((uint)0x84CE),

    [NativeName("GL_TEXTURE15_ARB")]
    Texture15ARB = unchecked((uint)0x84CF),

    [NativeName("GL_TEXTURE16_ARB")]
    Texture16ARB = unchecked((uint)0x84D0),

    [NativeName("GL_TEXTURE17_ARB")]
    Texture17ARB = unchecked((uint)0x84D1),

    [NativeName("GL_TEXTURE18_ARB")]
    Texture18ARB = unchecked((uint)0x84D2),

    [NativeName("GL_TEXTURE19_ARB")]
    Texture19ARB = unchecked((uint)0x84D3),

    [NativeName("GL_TEXTURE20_ARB")]
    Texture20ARB = unchecked((uint)0x84D4),

    [NativeName("GL_TEXTURE21_ARB")]
    Texture21ARB = unchecked((uint)0x84D5),

    [NativeName("GL_TEXTURE22_ARB")]
    Texture22ARB = unchecked((uint)0x84D6),

    [NativeName("GL_TEXTURE23_ARB")]
    Texture23ARB = unchecked((uint)0x84D7),

    [NativeName("GL_TEXTURE24_ARB")]
    Texture24ARB = unchecked((uint)0x84D8),

    [NativeName("GL_TEXTURE25_ARB")]
    Texture25ARB = unchecked((uint)0x84D9),

    [NativeName("GL_TEXTURE26_ARB")]
    Texture26ARB = unchecked((uint)0x84DA),

    [NativeName("GL_TEXTURE27_ARB")]
    Texture27ARB = unchecked((uint)0x84DB),

    [NativeName("GL_TEXTURE28_ARB")]
    Texture28ARB = unchecked((uint)0x84DC),

    [NativeName("GL_TEXTURE29_ARB")]
    Texture29ARB = unchecked((uint)0x84DD),

    [NativeName("GL_TEXTURE30_ARB")]
    Texture30ARB = unchecked((uint)0x84DE),

    [NativeName("GL_TEXTURE31_ARB")]
    Texture31ARB = unchecked((uint)0x84DF),

    [NativeName("GL_ACTIVE_TEXTURE_ARB")]
    ActiveTextureARB = unchecked((uint)0x84E0),

    [NativeName("GL_CLIENT_ACTIVE_TEXTURE_ARB")]
    ClientActiveTextureARB = unchecked((uint)0x84E1),

    [NativeName("GL_MAX_TEXTURE_UNITS_ARB")]
    MaxTextureUnitsARB = unchecked((uint)0x84E2),

    [NativeName("GL_QUERY_COUNTER_BITS_ARB")]
    QueryCounterBitsARB = unchecked((uint)0x8864),

    [NativeName("GL_CURRENT_QUERY_ARB")]
    CurrentQueryARB = unchecked((uint)0x8865),

    [NativeName("GL_QUERY_RESULT_ARB")]
    QueryResultARB = unchecked((uint)0x8866),

    [NativeName("GL_QUERY_RESULT_AVAILABLE_ARB")]
    QueryResultAvailableARB = unchecked((uint)0x8867),

    [NativeName("GL_SAMPLES_PASSED_ARB")]
    SamplesPassedARB = unchecked((uint)0x8914),

    [NativeName("GL_MAX_SHADER_COMPILER_THREADS_ARB")]
    MaxShaderCompilerThreadsARB = unchecked((uint)0x91B0),

    [NativeName("GL_COMPLETION_STATUS_ARB")]
    CompletionStatusARB = unchecked((uint)0x91B1),

    [NativeName("GL_VERTICES_SUBMITTED_ARB")]
    VerticesSubmittedARB = unchecked((uint)0x82EE),

    [NativeName("GL_PRIMITIVES_SUBMITTED_ARB")]
    PrimitivesSubmittedARB = unchecked((uint)0x82EF),

    [NativeName("GL_VERTEX_SHADER_INVOCATIONS_ARB")]
    VertexShaderInvocationsARB = unchecked((uint)0x82F0),

    [NativeName("GL_TESS_CONTROL_SHADER_PATCHES_ARB")]
    TessControlShaderPatchesARB = unchecked((uint)0x82F1),

    [NativeName("GL_TESS_EVALUATION_SHADER_INVOCATIONS_ARB")]
    TessEvaluationShaderInvocationsARB = unchecked((uint)0x82F2),

    [NativeName("GL_GEOMETRY_SHADER_PRIMITIVES_EMITTED_ARB")]
    GeometryShaderPrimitivesEmittedARB = unchecked((uint)0x82F3),

    [NativeName("GL_FRAGMENT_SHADER_INVOCATIONS_ARB")]
    FragmentShaderInvocationsARB = unchecked((uint)0x82F4),

    [NativeName("GL_COMPUTE_SHADER_INVOCATIONS_ARB")]
    ComputeShaderInvocationsARB = unchecked((uint)0x82F5),

    [NativeName("GL_CLIPPING_INPUT_PRIMITIVES_ARB")]
    ClippingInputPrimitivesARB = unchecked((uint)0x82F6),

    [NativeName("GL_CLIPPING_OUTPUT_PRIMITIVES_ARB")]
    ClippingOutputPrimitivesARB = unchecked((uint)0x82F7),

    [NativeName("GL_PIXEL_PACK_BUFFER_ARB")]
    PixelPackBufferARB = unchecked((uint)0x88EB),

    [NativeName("GL_PIXEL_UNPACK_BUFFER_ARB")]
    PixelUnpackBufferARB = unchecked((uint)0x88EC),

    [NativeName("GL_PIXEL_PACK_BUFFER_BINDING_ARB")]
    PixelPackBufferBindingARB = unchecked((uint)0x88ED),

    [NativeName("GL_PIXEL_UNPACK_BUFFER_BINDING_ARB")]
    PixelUnpackBufferBindingARB = unchecked((uint)0x88EF),

    [NativeName("GL_POINT_SIZE_MIN_ARB")]
    PointSizeMinARB = unchecked((uint)0x8126),

    [NativeName("GL_POINT_SIZE_MAX_ARB")]
    PointSizeMaxARB = unchecked((uint)0x8127),

    [NativeName("GL_POINT_FADE_THRESHOLD_SIZE_ARB")]
    PointFadeThresholdSizeARB = unchecked((uint)0x8128),

    [NativeName("GL_POINT_DISTANCE_ATTENUATION_ARB")]
    PointDistanceAttenuationARB = unchecked((uint)0x8129),

    [NativeName("GL_POINT_SPRITE_ARB")]
    PointSpriteARB = unchecked((uint)0x8861),

    [NativeName("GL_COORD_REPLACE_ARB")]
    CoordReplaceARB = unchecked((uint)0x8862),

    [NativeName("GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB")]
    ContextFlagRobustAccessBitARB = unchecked((uint)0x00000004),

    [NativeName("GL_LOSE_CONTEXT_ON_RESET_ARB")]
    LoseContextOnResetARB = unchecked((uint)0x8252),

    [NativeName("GL_GUILTY_CONTEXT_RESET_ARB")]
    GuiltyContextResetARB = unchecked((uint)0x8253),

    [NativeName("GL_INNOCENT_CONTEXT_RESET_ARB")]
    InnocentContextResetARB = unchecked((uint)0x8254),

    [NativeName("GL_UNKNOWN_CONTEXT_RESET_ARB")]
    UnknownContextResetARB = unchecked((uint)0x8255),

    [NativeName("GL_RESET_NOTIFICATION_STRATEGY_ARB")]
    ResetNotificationStrategyARB = unchecked((uint)0x8256),

    [NativeName("GL_NO_RESET_NOTIFICATION_ARB")]
    NoResetNotificationARB = unchecked((uint)0x8261),

    [NativeName("GL_SAMPLE_LOCATION_SUBPIXEL_BITS_ARB")]
    SampleLocationSubpixelBitsARB = unchecked((uint)0x933D),

    [NativeName("GL_SAMPLE_LOCATION_PIXEL_GRID_WIDTH_ARB")]
    SampleLocationPixelGridWidthARB = unchecked((uint)0x933E),

    [NativeName("GL_SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_ARB")]
    SampleLocationPixelGridHeightARB = unchecked((uint)0x933F),

    [NativeName("GL_PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_ARB")]
    ProgrammableSampleLocationTableSizeARB = unchecked((uint)0x9340),

    [NativeName("GL_SAMPLE_LOCATION_ARB")]
    SampleLocationARB = unchecked((uint)0x8E50),

    [NativeName("GL_PROGRAMMABLE_SAMPLE_LOCATION_ARB")]
    ProgrammableSampleLocationARB = unchecked((uint)0x9341),

    [NativeName("GL_FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_ARB")]
    FramebufferProgrammableSampleLocationsARB = unchecked((uint)0x9342),

    [NativeName("GL_FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_ARB")]
    FramebufferSampleLocationPixelGridARB = unchecked((uint)0x9343),

    [NativeName("GL_SAMPLE_SHADING_ARB")]
    SampleShadingARB = unchecked((uint)0x8C36),

    [NativeName("GL_MIN_SAMPLE_SHADING_VALUE_ARB")]
    MinSampleShadingValueARB = unchecked((uint)0x8C37),

    [NativeName("GL_PROGRAM_OBJECT_ARB")]
    ProgramObjectARB = unchecked((uint)0x8B40),

    [NativeName("GL_SHADER_OBJECT_ARB")]
    ShaderObjectARB = unchecked((uint)0x8B48),

    [NativeName("GL_OBJECT_TYPE_ARB")]
    ObjectTypeARB = unchecked((uint)0x8B4E),

    [NativeName("GL_OBJECT_SUBTYPE_ARB")]
    ObjectSubtypeARB = unchecked((uint)0x8B4F),

    [NativeName("GL_FLOAT_VEC2_ARB")]
    FloatVec2ARB = unchecked((uint)0x8B50),

    [NativeName("GL_FLOAT_VEC3_ARB")]
    FloatVec3ARB = unchecked((uint)0x8B51),

    [NativeName("GL_FLOAT_VEC4_ARB")]
    FloatVec4ARB = unchecked((uint)0x8B52),

    [NativeName("GL_INT_VEC2_ARB")]
    IntVec2ARB = unchecked((uint)0x8B53),

    [NativeName("GL_INT_VEC3_ARB")]
    IntVec3ARB = unchecked((uint)0x8B54),

    [NativeName("GL_INT_VEC4_ARB")]
    IntVec4ARB = unchecked((uint)0x8B55),

    [NativeName("GL_BOOL_ARB")]
    BoolARB = unchecked((uint)0x8B56),

    [NativeName("GL_BOOL_VEC2_ARB")]
    BoolVec2ARB = unchecked((uint)0x8B57),

    [NativeName("GL_BOOL_VEC3_ARB")]
    BoolVec3ARB = unchecked((uint)0x8B58),

    [NativeName("GL_BOOL_VEC4_ARB")]
    BoolVec4ARB = unchecked((uint)0x8B59),

    [NativeName("GL_FLOAT_MAT2_ARB")]
    FloatMat2ARB = unchecked((uint)0x8B5A),

    [NativeName("GL_FLOAT_MAT3_ARB")]
    FloatMat3ARB = unchecked((uint)0x8B5B),

    [NativeName("GL_FLOAT_MAT4_ARB")]
    FloatMat4ARB = unchecked((uint)0x8B5C),

    [NativeName("GL_SAMPLER_1D_ARB")]
    Sampler1DARB = unchecked((uint)0x8B5D),

    [NativeName("GL_SAMPLER_2D_ARB")]
    Sampler2DARB = unchecked((uint)0x8B5E),

    [NativeName("GL_SAMPLER_3D_ARB")]
    Sampler3DARB = unchecked((uint)0x8B5F),

    [NativeName("GL_SAMPLER_CUBE_ARB")]
    SamplerCubeARB = unchecked((uint)0x8B60),

    [NativeName("GL_SAMPLER_1D_SHADOW_ARB")]
    Sampler1DShadowARB = unchecked((uint)0x8B61),

    [NativeName("GL_SAMPLER_2D_SHADOW_ARB")]
    Sampler2DShadowARB = unchecked((uint)0x8B62),

    [NativeName("GL_SAMPLER_2D_RECT_ARB")]
    Sampler2DRectARB = unchecked((uint)0x8B63),

    [NativeName("GL_SAMPLER_2D_RECT_SHADOW_ARB")]
    Sampler2DRectShadowARB = unchecked((uint)0x8B64),

    [NativeName("GL_OBJECT_DELETE_STATUS_ARB")]
    ObjectDeleteStatusARB = unchecked((uint)0x8B80),

    [NativeName("GL_OBJECT_COMPILE_STATUS_ARB")]
    ObjectCompileStatusARB = unchecked((uint)0x8B81),

    [NativeName("GL_OBJECT_LINK_STATUS_ARB")]
    ObjectLinkStatusARB = unchecked((uint)0x8B82),

    [NativeName("GL_OBJECT_VALIDATE_STATUS_ARB")]
    ObjectValidateStatusARB = unchecked((uint)0x8B83),

    [NativeName("GL_OBJECT_INFO_LOG_LENGTH_ARB")]
    ObjectInfoLogLengthARB = unchecked((uint)0x8B84),

    [NativeName("GL_OBJECT_ATTACHED_OBJECTS_ARB")]
    ObjectAttachedObjectsARB = unchecked((uint)0x8B85),

    [NativeName("GL_OBJECT_ACTIVE_UNIFORMS_ARB")]
    ObjectActiveUniformsARB = unchecked((uint)0x8B86),

    [NativeName("GL_OBJECT_ACTIVE_UNIFORM_MAX_LENGTH_ARB")]
    ObjectActiveUniformMaxLengthARB = unchecked((uint)0x8B87),

    [NativeName("GL_OBJECT_SHADER_SOURCE_LENGTH_ARB")]
    ObjectShaderSourceLengthARB = unchecked((uint)0x8B88),

    [NativeName("GL_SHADING_LANGUAGE_VERSION_ARB")]
    ShadingLanguageVersionARB = unchecked((uint)0x8B8C),

    [NativeName("GL_SHADER_INCLUDE_ARB")]
    ShaderIncludeARB = unchecked((uint)0x8DAE),

    [NativeName("GL_NAMED_STRING_LENGTH_ARB")]
    NamedStringLengthARB = unchecked((uint)0x8DE9),

    [NativeName("GL_NAMED_STRING_TYPE_ARB")]
    NamedStringTypeARB = unchecked((uint)0x8DEA),

    [NativeName("GL_TEXTURE_COMPARE_MODE_ARB")]
    TextureCompareModeARB = unchecked((uint)0x884C),

    [NativeName("GL_TEXTURE_COMPARE_FUNC_ARB")]
    TextureCompareFuncARB = unchecked((uint)0x884D),

    [NativeName("GL_COMPARE_R_TO_TEXTURE_ARB")]
    CompareRToTextureARB = unchecked((uint)0x884E),

    [NativeName("GL_TEXTURE_COMPARE_FAIL_VALUE_ARB")]
    TextureCompareFailValueARB = unchecked((uint)0x80BF),

    [NativeName("GL_SPARSE_STORAGE_BIT_ARB")]
    SparseStorageBitARB = unchecked((uint)0x0400),

    [NativeName("GL_SPARSE_BUFFER_PAGE_SIZE_ARB")]
    SparseBufferPageSizeARB = unchecked((uint)0x82F8),

    [NativeName("GL_TEXTURE_SPARSE_ARB")]
    TextureSparseARB = unchecked((uint)0x91A6),

    [NativeName("GL_VIRTUAL_PAGE_SIZE_INDEX_ARB")]
    VirtualPageSizeIndexARB = unchecked((uint)0x91A7),

    [NativeName("GL_NUM_SPARSE_LEVELS_ARB")]
    NumSparseLevelsARB = unchecked((uint)0x91AA),

    [NativeName("GL_NUM_VIRTUAL_PAGE_SIZES_ARB")]
    NumVirtualPageSizesARB = unchecked((uint)0x91A8),

    [NativeName("GL_VIRTUAL_PAGE_SIZE_X_ARB")]
    VirtualPageSizeXARB = unchecked((uint)0x9195),

    [NativeName("GL_VIRTUAL_PAGE_SIZE_Y_ARB")]
    VirtualPageSizeYARB = unchecked((uint)0x9196),

    [NativeName("GL_VIRTUAL_PAGE_SIZE_Z_ARB")]
    VirtualPageSizeZARB = unchecked((uint)0x9197),

    [NativeName("GL_MAX_SPARSE_TEXTURE_SIZE_ARB")]
    MaxSparseTextureSizeARB = unchecked((uint)0x9198),

    [NativeName("GL_MAX_SPARSE_3D_TEXTURE_SIZE_ARB")]
    MaxSparse3DTextureSizeARB = unchecked((uint)0x9199),

    [NativeName("GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS_ARB")]
    MaxSparseArrayTextureLayersARB = unchecked((uint)0x919A),

    [NativeName("GL_SPARSE_TEXTURE_FULL_ARRAY_CUBE_MIPMAPS_ARB")]
    SparseTextureFullArrayCubeMipmapsARB = unchecked((uint)0x91A9),

    [NativeName("GL_CLAMP_TO_BORDER_ARB")]
    ClampToBorderARB = unchecked((uint)0x812D),

    [NativeName("GL_TEXTURE_BUFFER_ARB")]
    TextureBufferARB = unchecked((uint)0x8C2A),

    [NativeName("GL_MAX_TEXTURE_BUFFER_SIZE_ARB")]
    MaxTextureBufferSizeARB = unchecked((uint)0x8C2B),

    [NativeName("GL_TEXTURE_BINDING_BUFFER_ARB")]
    TextureBindingBufferARB = unchecked((uint)0x8C2C),

    [NativeName("GL_TEXTURE_BUFFER_DATA_STORE_BINDING_ARB")]
    TextureBufferDataStoreBindingARB = unchecked((uint)0x8C2D),

    [NativeName("GL_TEXTURE_BUFFER_FORMAT_ARB")]
    TextureBufferFormatARB = unchecked((uint)0x8C2E),

    [NativeName("GL_COMPRESSED_ALPHA_ARB")]
    CompressedAlphaARB = unchecked((uint)0x84E9),

    [NativeName("GL_COMPRESSED_LUMINANCE_ARB")]
    CompressedLuminanceARB = unchecked((uint)0x84EA),

    [NativeName("GL_COMPRESSED_LUMINANCE_ALPHA_ARB")]
    CompressedLuminanceAlphaARB = unchecked((uint)0x84EB),

    [NativeName("GL_COMPRESSED_INTENSITY_ARB")]
    CompressedIntensityARB = unchecked((uint)0x84EC),

    [NativeName("GL_COMPRESSED_RGB_ARB")]
    CompressedRgbARB = unchecked((uint)0x84ED),

    [NativeName("GL_COMPRESSED_RGBA_ARB")]
    CompressedRgbaARB = unchecked((uint)0x84EE),

    [NativeName("GL_TEXTURE_COMPRESSION_HINT_ARB")]
    TextureCompressionHintARB = unchecked((uint)0x84EF),

    [NativeName("GL_TEXTURE_COMPRESSED_IMAGE_SIZE_ARB")]
    TextureCompressedImageSizeARB = unchecked((uint)0x86A0),

    [NativeName("GL_TEXTURE_COMPRESSED_ARB")]
    TextureCompressedARB = unchecked((uint)0x86A1),

    [NativeName("GL_NUM_COMPRESSED_TEXTURE_FORMATS_ARB")]
    NumCompressedTextureFormatsARB = unchecked((uint)0x86A2),

    [NativeName("GL_COMPRESSED_TEXTURE_FORMATS_ARB")]
    CompressedTextureFormatsARB = unchecked((uint)0x86A3),

    [NativeName("GL_COMPRESSED_RGBA_BPTC_UNORM_ARB")]
    CompressedRgbaBptcUnormARB = unchecked((uint)0x8E8C),

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM_ARB")]
    CompressedSrgbAlphaBptcUnormARB = unchecked((uint)0x8E8D),

    [NativeName("GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT_ARB")]
    CompressedRgbBptcSignedFloatARB = unchecked((uint)0x8E8E),

    [NativeName("GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_ARB")]
    CompressedRgbBptcUnsignedFloatARB = unchecked((uint)0x8E8F),

    [NativeName("GL_NORMAL_MAP_ARB")]
    NormalMapARB = unchecked((uint)0x8511),

    [NativeName("GL_REFLECTION_MAP_ARB")]
    ReflectionMapARB = unchecked((uint)0x8512),

    [NativeName("GL_TEXTURE_CUBE_MAP_ARB")]
    TextureCubeMapARB = unchecked((uint)0x8513),

    [NativeName("GL_TEXTURE_BINDING_CUBE_MAP_ARB")]
    TextureBindingCubeMapARB = unchecked((uint)0x8514),

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_X_ARB")]
    TextureCubeMapPositiveXARB = unchecked((uint)0x8515),

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_X_ARB")]
    TextureCubeMapNegativeXARB = unchecked((uint)0x8516),

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Y_ARB")]
    TextureCubeMapPositiveYARB = unchecked((uint)0x8517),

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB")]
    TextureCubeMapNegativeYARB = unchecked((uint)0x8518),

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Z_ARB")]
    TextureCubeMapPositiveZARB = unchecked((uint)0x8519),

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB")]
    TextureCubeMapNegativeZARB = unchecked((uint)0x851A),

    [NativeName("GL_PROXY_TEXTURE_CUBE_MAP_ARB")]
    ProxyTextureCubeMapARB = unchecked((uint)0x851B),

    [NativeName("GL_MAX_CUBE_MAP_TEXTURE_SIZE_ARB")]
    MaxCubeMapTextureSizeARB = unchecked((uint)0x851C),

    [NativeName("GL_TEXTURE_CUBE_MAP_ARRAY_ARB")]
    TextureCubeMapArrayARB = unchecked((uint)0x9009),

    [NativeName("GL_TEXTURE_BINDING_CUBE_MAP_ARRAY_ARB")]
    TextureBindingCubeMapArrayARB = unchecked((uint)0x900A),

    [NativeName("GL_PROXY_TEXTURE_CUBE_MAP_ARRAY_ARB")]
    ProxyTextureCubeMapArrayARB = unchecked((uint)0x900B),

    [NativeName("GL_SAMPLER_CUBE_MAP_ARRAY_ARB")]
    SamplerCubeMapArrayARB = unchecked((uint)0x900C),

    [NativeName("GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW_ARB")]
    SamplerCubeMapArrayShadowARB = unchecked((uint)0x900D),

    [NativeName("GL_INT_SAMPLER_CUBE_MAP_ARRAY_ARB")]
    IntSamplerCubeMapArrayARB = unchecked((uint)0x900E),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_ARB")]
    UnsignedIntSamplerCubeMapArrayARB = unchecked((uint)0x900F),

    [NativeName("GL_COMBINE_ARB")]
    CombineARB = unchecked((uint)0x8570),

    [NativeName("GL_COMBINE_RGB_ARB")]
    CombineRgbARB = unchecked((uint)0x8571),

    [NativeName("GL_COMBINE_ALPHA_ARB")]
    CombineAlphaARB = unchecked((uint)0x8572),

    [NativeName("GL_SOURCE0_RGB_ARB")]
    Source0RgbARB = unchecked((uint)0x8580),

    [NativeName("GL_SOURCE1_RGB_ARB")]
    Source1RgbARB = unchecked((uint)0x8581),

    [NativeName("GL_SOURCE2_RGB_ARB")]
    Source2RgbARB = unchecked((uint)0x8582),

    [NativeName("GL_SOURCE0_ALPHA_ARB")]
    Source0AlphaARB = unchecked((uint)0x8588),

    [NativeName("GL_SOURCE1_ALPHA_ARB")]
    Source1AlphaARB = unchecked((uint)0x8589),

    [NativeName("GL_SOURCE2_ALPHA_ARB")]
    Source2AlphaARB = unchecked((uint)0x858A),

    [NativeName("GL_OPERAND0_RGB_ARB")]
    Operand0RgbARB = unchecked((uint)0x8590),

    [NativeName("GL_OPERAND1_RGB_ARB")]
    Operand1RgbARB = unchecked((uint)0x8591),

    [NativeName("GL_OPERAND2_RGB_ARB")]
    Operand2RgbARB = unchecked((uint)0x8592),

    [NativeName("GL_OPERAND0_ALPHA_ARB")]
    Operand0AlphaARB = unchecked((uint)0x8598),

    [NativeName("GL_OPERAND1_ALPHA_ARB")]
    Operand1AlphaARB = unchecked((uint)0x8599),

    [NativeName("GL_OPERAND2_ALPHA_ARB")]
    Operand2AlphaARB = unchecked((uint)0x859A),

    [NativeName("GL_RGB_SCALE_ARB")]
    RgbScaleARB = unchecked((uint)0x8573),

    [NativeName("GL_ADD_SIGNED_ARB")]
    AddSignedARB = unchecked((uint)0x8574),

    [NativeName("GL_INTERPOLATE_ARB")]
    InterpolateARB = unchecked((uint)0x8575),

    [NativeName("GL_SUBTRACT_ARB")]
    SubtractARB = unchecked((uint)0x84E7),

    [NativeName("GL_CONSTANT_ARB")]
    ConstantARB = unchecked((uint)0x8576),

    [NativeName("GL_PRIMARY_COLOR_ARB")]
    PrimaryColorARB = unchecked((uint)0x8577),

    [NativeName("GL_PREVIOUS_ARB")]
    PreviousARB = unchecked((uint)0x8578),

    [NativeName("GL_DOT3_RGB_ARB")]
    Dot3RgbARB = unchecked((uint)0x86AE),

    [NativeName("GL_DOT3_RGBA_ARB")]
    Dot3RgbaARB = unchecked((uint)0x86AF),

    [NativeName("GL_TEXTURE_REDUCTION_MODE_ARB")]
    TextureReductionModeARB = unchecked((uint)0x9366),

    [NativeName("GL_WEIGHTED_AVERAGE_ARB")]
    WeightedAverageARB = unchecked((uint)0x9367),

    [NativeName("GL_TEXTURE_RED_TYPE_ARB")]
    TextureRedTypeARB = unchecked((uint)0x8C10),

    [NativeName("GL_TEXTURE_GREEN_TYPE_ARB")]
    TextureGreenTypeARB = unchecked((uint)0x8C11),

    [NativeName("GL_TEXTURE_BLUE_TYPE_ARB")]
    TextureBlueTypeARB = unchecked((uint)0x8C12),

    [NativeName("GL_TEXTURE_ALPHA_TYPE_ARB")]
    TextureAlphaTypeARB = unchecked((uint)0x8C13),

    [NativeName("GL_TEXTURE_LUMINANCE_TYPE_ARB")]
    TextureLuminanceTypeARB = unchecked((uint)0x8C14),

    [NativeName("GL_TEXTURE_INTENSITY_TYPE_ARB")]
    TextureIntensityTypeARB = unchecked((uint)0x8C15),

    [NativeName("GL_TEXTURE_DEPTH_TYPE_ARB")]
    TextureDepthTypeARB = unchecked((uint)0x8C16),

    [NativeName("GL_UNSIGNED_NORMALIZED_ARB")]
    UnsignedNormalizedARB = unchecked((uint)0x8C17),

    [NativeName("GL_RGBA32F_ARB")]
    Rgba32FARB = unchecked((uint)0x8814),

    [NativeName("GL_RGB32F_ARB")]
    Rgb32FARB = unchecked((uint)0x8815),

    [NativeName("GL_ALPHA32F_ARB")]
    Alpha32FARB = unchecked((uint)0x8816),

    [NativeName("GL_INTENSITY32F_ARB")]
    Intensity32FARB = unchecked((uint)0x8817),

    [NativeName("GL_LUMINANCE32F_ARB")]
    Luminance32FARB = unchecked((uint)0x8818),

    [NativeName("GL_LUMINANCE_ALPHA32F_ARB")]
    LuminanceAlpha32FARB = unchecked((uint)0x8819),

    [NativeName("GL_RGBA16F_ARB")]
    Rgba16FARB = unchecked((uint)0x881A),

    [NativeName("GL_RGB16F_ARB")]
    Rgb16FARB = unchecked((uint)0x881B),

    [NativeName("GL_ALPHA16F_ARB")]
    Alpha16FARB = unchecked((uint)0x881C),

    [NativeName("GL_INTENSITY16F_ARB")]
    Intensity16FARB = unchecked((uint)0x881D),

    [NativeName("GL_LUMINANCE16F_ARB")]
    Luminance16FARB = unchecked((uint)0x881E),

    [NativeName("GL_LUMINANCE_ALPHA16F_ARB")]
    LuminanceAlpha16FARB = unchecked((uint)0x881F),

    [NativeName("GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET_ARB")]
    MinProgramTextureGatherOffsetARB = unchecked((uint)0x8E5E),

    [NativeName("GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET_ARB")]
    MaxProgramTextureGatherOffsetARB = unchecked((uint)0x8E5F),

    [NativeName("GL_MAX_PROGRAM_TEXTURE_GATHER_COMPONENTS_ARB")]
    MaxProgramTextureGatherComponentsARB = unchecked((uint)0x8F9F),

    [NativeName("GL_MIRRORED_REPEAT_ARB")]
    MirroredRepeatARB = unchecked((uint)0x8370),

    [NativeName("GL_TEXTURE_RECTANGLE_ARB")]
    TextureRectangleARB = unchecked((uint)0x84F5),

    [NativeName("GL_TEXTURE_BINDING_RECTANGLE_ARB")]
    TextureBindingRectangleARB = unchecked((uint)0x84F6),

    [NativeName("GL_PROXY_TEXTURE_RECTANGLE_ARB")]
    ProxyTextureRectangleARB = unchecked((uint)0x84F7),

    [NativeName("GL_MAX_RECTANGLE_TEXTURE_SIZE_ARB")]
    MaxRectangleTextureSizeARB = unchecked((uint)0x84F8),

    [NativeName("GL_TRANSFORM_FEEDBACK_OVERFLOW_ARB")]
    TransformFeedbackOverflowARB = unchecked((uint)0x82EC),

    [NativeName("GL_TRANSFORM_FEEDBACK_STREAM_OVERFLOW_ARB")]
    TransformFeedbackStreamOverflowARB = unchecked((uint)0x82ED),

    [NativeName("GL_TRANSPOSE_MODELVIEW_MATRIX_ARB")]
    TransposeModelviewMatrixARB = unchecked((uint)0x84E3),

    [NativeName("GL_TRANSPOSE_PROJECTION_MATRIX_ARB")]
    TransposeProjectionMatrixARB = unchecked((uint)0x84E4),

    [NativeName("GL_TRANSPOSE_TEXTURE_MATRIX_ARB")]
    TransposeTextureMatrixARB = unchecked((uint)0x84E5),

    [NativeName("GL_TRANSPOSE_COLOR_MATRIX_ARB")]
    TransposeColorMatrixARB = unchecked((uint)0x84E6),

    [NativeName("GL_MAX_VERTEX_UNITS_ARB")]
    MaxVertexUnitsARB = unchecked((uint)0x86A4),

    [NativeName("GL_ACTIVE_VERTEX_UNITS_ARB")]
    ActiveVertexUnitsARB = unchecked((uint)0x86A5),

    [NativeName("GL_WEIGHT_SUM_UNITY_ARB")]
    WeightSumUnityARB = unchecked((uint)0x86A6),

    [NativeName("GL_VERTEX_BLEND_ARB")]
    VertexBlendARB = unchecked((uint)0x86A7),

    [NativeName("GL_CURRENT_WEIGHT_ARB")]
    CurrentWeightARB = unchecked((uint)0x86A8),

    [NativeName("GL_WEIGHT_ARRAY_TYPE_ARB")]
    WeightArrayTypeARB = unchecked((uint)0x86A9),

    [NativeName("GL_WEIGHT_ARRAY_STRIDE_ARB")]
    WeightArrayStrideARB = unchecked((uint)0x86AA),

    [NativeName("GL_WEIGHT_ARRAY_SIZE_ARB")]
    WeightArraySizeARB = unchecked((uint)0x86AB),

    [NativeName("GL_WEIGHT_ARRAY_POINTER_ARB")]
    WeightArrayPointerARB = unchecked((uint)0x86AC),

    [NativeName("GL_WEIGHT_ARRAY_ARB")]
    WeightArrayARB = unchecked((uint)0x86AD),

    [NativeName("GL_MODELVIEW0_ARB")]
    Modelview0ARB = unchecked((uint)0x1700),

    [NativeName("GL_MODELVIEW1_ARB")]
    Modelview1ARB = unchecked((uint)0x850A),

    [NativeName("GL_MODELVIEW2_ARB")]
    Modelview2ARB = unchecked((uint)0x8722),

    [NativeName("GL_MODELVIEW3_ARB")]
    Modelview3ARB = unchecked((uint)0x8723),

    [NativeName("GL_MODELVIEW4_ARB")]
    Modelview4ARB = unchecked((uint)0x8724),

    [NativeName("GL_MODELVIEW5_ARB")]
    Modelview5ARB = unchecked((uint)0x8725),

    [NativeName("GL_MODELVIEW6_ARB")]
    Modelview6ARB = unchecked((uint)0x8726),

    [NativeName("GL_MODELVIEW7_ARB")]
    Modelview7ARB = unchecked((uint)0x8727),

    [NativeName("GL_MODELVIEW8_ARB")]
    Modelview8ARB = unchecked((uint)0x8728),

    [NativeName("GL_MODELVIEW9_ARB")]
    Modelview9ARB = unchecked((uint)0x8729),

    [NativeName("GL_MODELVIEW10_ARB")]
    Modelview10ARB = unchecked((uint)0x872A),

    [NativeName("GL_MODELVIEW11_ARB")]
    Modelview11ARB = unchecked((uint)0x872B),

    [NativeName("GL_MODELVIEW12_ARB")]
    Modelview12ARB = unchecked((uint)0x872C),

    [NativeName("GL_MODELVIEW13_ARB")]
    Modelview13ARB = unchecked((uint)0x872D),

    [NativeName("GL_MODELVIEW14_ARB")]
    Modelview14ARB = unchecked((uint)0x872E),

    [NativeName("GL_MODELVIEW15_ARB")]
    Modelview15ARB = unchecked((uint)0x872F),

    [NativeName("GL_MODELVIEW16_ARB")]
    Modelview16ARB = unchecked((uint)0x8730),

    [NativeName("GL_MODELVIEW17_ARB")]
    Modelview17ARB = unchecked((uint)0x8731),

    [NativeName("GL_MODELVIEW18_ARB")]
    Modelview18ARB = unchecked((uint)0x8732),

    [NativeName("GL_MODELVIEW19_ARB")]
    Modelview19ARB = unchecked((uint)0x8733),

    [NativeName("GL_MODELVIEW20_ARB")]
    Modelview20ARB = unchecked((uint)0x8734),

    [NativeName("GL_MODELVIEW21_ARB")]
    Modelview21ARB = unchecked((uint)0x8735),

    [NativeName("GL_MODELVIEW22_ARB")]
    Modelview22ARB = unchecked((uint)0x8736),

    [NativeName("GL_MODELVIEW23_ARB")]
    Modelview23ARB = unchecked((uint)0x8737),

    [NativeName("GL_MODELVIEW24_ARB")]
    Modelview24ARB = unchecked((uint)0x8738),

    [NativeName("GL_MODELVIEW25_ARB")]
    Modelview25ARB = unchecked((uint)0x8739),

    [NativeName("GL_MODELVIEW26_ARB")]
    Modelview26ARB = unchecked((uint)0x873A),

    [NativeName("GL_MODELVIEW27_ARB")]
    Modelview27ARB = unchecked((uint)0x873B),

    [NativeName("GL_MODELVIEW28_ARB")]
    Modelview28ARB = unchecked((uint)0x873C),

    [NativeName("GL_MODELVIEW29_ARB")]
    Modelview29ARB = unchecked((uint)0x873D),

    [NativeName("GL_MODELVIEW30_ARB")]
    Modelview30ARB = unchecked((uint)0x873E),

    [NativeName("GL_MODELVIEW31_ARB")]
    Modelview31ARB = unchecked((uint)0x873F),

    [NativeName("GL_BUFFER_SIZE_ARB")]
    BufferSizeARB = unchecked((uint)0x8764),

    [NativeName("GL_BUFFER_USAGE_ARB")]
    BufferUsageARB = unchecked((uint)0x8765),

    [NativeName("GL_ARRAY_BUFFER_ARB")]
    ArrayBufferARB = unchecked((uint)0x8892),

    [NativeName("GL_ELEMENT_ARRAY_BUFFER_ARB")]
    ElementArrayBufferARB = unchecked((uint)0x8893),

    [NativeName("GL_ARRAY_BUFFER_BINDING_ARB")]
    ArrayBufferBindingARB = unchecked((uint)0x8894),

    [NativeName("GL_ELEMENT_ARRAY_BUFFER_BINDING_ARB")]
    ElementArrayBufferBindingARB = unchecked((uint)0x8895),

    [NativeName("GL_VERTEX_ARRAY_BUFFER_BINDING_ARB")]
    VertexArrayBufferBindingARB = unchecked((uint)0x8896),

    [NativeName("GL_NORMAL_ARRAY_BUFFER_BINDING_ARB")]
    NormalArrayBufferBindingARB = unchecked((uint)0x8897),

    [NativeName("GL_COLOR_ARRAY_BUFFER_BINDING_ARB")]
    ColorArrayBufferBindingARB = unchecked((uint)0x8898),

    [NativeName("GL_INDEX_ARRAY_BUFFER_BINDING_ARB")]
    IndexArrayBufferBindingARB = unchecked((uint)0x8899),

    [NativeName("GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING_ARB")]
    TextureCoordArrayBufferBindingARB = unchecked((uint)0x889A),

    [NativeName("GL_EDGE_FLAG_ARRAY_BUFFER_BINDING_ARB")]
    EdgeFlagArrayBufferBindingARB = unchecked((uint)0x889B),

    [NativeName("GL_SECONDARY_COLOR_ARRAY_BUFFER_BINDING_ARB")]
    SecondaryColorArrayBufferBindingARB = unchecked((uint)0x889C),

    [NativeName("GL_FOG_COORDINATE_ARRAY_BUFFER_BINDING_ARB")]
    FogCoordinateArrayBufferBindingARB = unchecked((uint)0x889D),

    [NativeName("GL_WEIGHT_ARRAY_BUFFER_BINDING_ARB")]
    WeightArrayBufferBindingARB = unchecked((uint)0x889E),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING_ARB")]
    VertexAttribArrayBufferBindingARB = unchecked((uint)0x889F),

    [NativeName("GL_READ_ONLY_ARB")]
    ReadOnlyARB = unchecked((uint)0x88B8),

    [NativeName("GL_WRITE_ONLY_ARB")]
    WriteOnlyARB = unchecked((uint)0x88B9),

    [NativeName("GL_READ_WRITE_ARB")]
    ReadWriteARB = unchecked((uint)0x88BA),

    [NativeName("GL_BUFFER_ACCESS_ARB")]
    BufferAccessARB = unchecked((uint)0x88BB),

    [NativeName("GL_BUFFER_MAPPED_ARB")]
    BufferMappedARB = unchecked((uint)0x88BC),

    [NativeName("GL_BUFFER_MAP_POINTER_ARB")]
    BufferMapPointerARB = unchecked((uint)0x88BD),

    [NativeName("GL_STREAM_DRAW_ARB")]
    StreamDrawARB = unchecked((uint)0x88E0),

    [NativeName("GL_STREAM_READ_ARB")]
    StreamReadARB = unchecked((uint)0x88E1),

    [NativeName("GL_STREAM_COPY_ARB")]
    StreamCopyARB = unchecked((uint)0x88E2),

    [NativeName("GL_STATIC_DRAW_ARB")]
    StaticDrawARB = unchecked((uint)0x88E4),

    [NativeName("GL_STATIC_READ_ARB")]
    StaticReadARB = unchecked((uint)0x88E5),

    [NativeName("GL_STATIC_COPY_ARB")]
    StaticCopyARB = unchecked((uint)0x88E6),

    [NativeName("GL_DYNAMIC_DRAW_ARB")]
    DynamicDrawARB = unchecked((uint)0x88E8),

    [NativeName("GL_DYNAMIC_READ_ARB")]
    DynamicReadARB = unchecked((uint)0x88E9),

    [NativeName("GL_DYNAMIC_COPY_ARB")]
    DynamicCopyARB = unchecked((uint)0x88EA),

    [NativeName("GL_COLOR_SUM_ARB")]
    ColorSumARB = unchecked((uint)0x8458),

    [NativeName("GL_VERTEX_PROGRAM_ARB")]
    VertexProgramARB = unchecked((uint)0x8620),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_ENABLED_ARB")]
    VertexAttribArrayEnabledARB = unchecked((uint)0x8622),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_SIZE_ARB")]
    VertexAttribArraySizeARB = unchecked((uint)0x8623),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_STRIDE_ARB")]
    VertexAttribArrayStrideARB = unchecked((uint)0x8624),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_TYPE_ARB")]
    VertexAttribArrayTypeARB = unchecked((uint)0x8625),

    [NativeName("GL_CURRENT_VERTEX_ATTRIB_ARB")]
    CurrentVertexAttribARB = unchecked((uint)0x8626),

    [NativeName("GL_VERTEX_PROGRAM_POINT_SIZE_ARB")]
    VertexProgramPointSizeARB = unchecked((uint)0x8642),

    [NativeName("GL_VERTEX_PROGRAM_TWO_SIDE_ARB")]
    VertexProgramTwoSideARB = unchecked((uint)0x8643),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_POINTER_ARB")]
    VertexAttribArrayPointerARB = unchecked((uint)0x8645),

    [NativeName("GL_MAX_VERTEX_ATTRIBS_ARB")]
    MaxVertexAttribsARB = unchecked((uint)0x8869),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_NORMALIZED_ARB")]
    VertexAttribArrayNormalizedARB = unchecked((uint)0x886A),

    [NativeName("GL_PROGRAM_ADDRESS_REGISTERS_ARB")]
    ProgramAddressRegistersARB = unchecked((uint)0x88B0),

    [NativeName("GL_MAX_PROGRAM_ADDRESS_REGISTERS_ARB")]
    MaxProgramAddressRegistersARB = unchecked((uint)0x88B1),

    [NativeName("GL_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB")]
    ProgramNativeAddressRegistersARB = unchecked((uint)0x88B2),

    [NativeName("GL_MAX_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB")]
    MaxProgramNativeAddressRegistersARB = unchecked((uint)0x88B3),

    [NativeName("GL_VERTEX_SHADER_ARB")]
    VertexShaderARB = unchecked((uint)0x8B31),

    [NativeName("GL_MAX_VERTEX_UNIFORM_COMPONENTS_ARB")]
    MaxVertexUniformComponentsARB = unchecked((uint)0x8B4A),

    [NativeName("GL_MAX_VARYING_FLOATS_ARB")]
    MaxVaryingFloatsARB = unchecked((uint)0x8B4B),

    [NativeName("GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS_ARB")]
    MaxVertexTextureImageUnitsARB = unchecked((uint)0x8B4C),

    [NativeName("GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS_ARB")]
    MaxCombinedTextureImageUnitsARB = unchecked((uint)0x8B4D),

    [NativeName("GL_OBJECT_ACTIVE_ATTRIBUTES_ARB")]
    ObjectActiveAttributesARB = unchecked((uint)0x8B89),

    [NativeName("GL_OBJECT_ACTIVE_ATTRIBUTE_MAX_LENGTH_ARB")]
    ObjectActiveAttributeMaxLengthARB = unchecked((uint)0x8B8A),

    [NativeName("GL_MULTIPLY_KHR")]
    MultiplyKHR = unchecked((uint)0x9294),

    [NativeName("GL_SCREEN_KHR")]
    ScreenKHR = unchecked((uint)0x9295),

    [NativeName("GL_OVERLAY_KHR")]
    OverlayKHR = unchecked((uint)0x9296),

    [NativeName("GL_DARKEN_KHR")]
    DarkenKHR = unchecked((uint)0x9297),

    [NativeName("GL_LIGHTEN_KHR")]
    LightenKHR = unchecked((uint)0x9298),

    [NativeName("GL_COLORDODGE_KHR")]
    ColordodgeKHR = unchecked((uint)0x9299),

    [NativeName("GL_COLORBURN_KHR")]
    ColorburnKHR = unchecked((uint)0x929A),

    [NativeName("GL_HARDLIGHT_KHR")]
    HardlightKHR = unchecked((uint)0x929B),

    [NativeName("GL_SOFTLIGHT_KHR")]
    SoftlightKHR = unchecked((uint)0x929C),

    [NativeName("GL_DIFFERENCE_KHR")]
    DifferenceKHR = unchecked((uint)0x929E),

    [NativeName("GL_EXCLUSION_KHR")]
    ExclusionKHR = unchecked((uint)0x92A0),

    [NativeName("GL_HSL_HUE_KHR")]
    HslHueKHR = unchecked((uint)0x92AD),

    [NativeName("GL_HSL_SATURATION_KHR")]
    HslSaturationKHR = unchecked((uint)0x92AE),

    [NativeName("GL_HSL_COLOR_KHR")]
    HslColorKHR = unchecked((uint)0x92AF),

    [NativeName("GL_HSL_LUMINOSITY_KHR")]
    HslLuminosityKHR = unchecked((uint)0x92B0),

    [NativeName("GL_BLEND_ADVANCED_COHERENT_KHR")]
    BlendAdvancedCoherentKHR = unchecked((uint)0x9285),

    [NativeName("GL_CONTEXT_FLAG_NO_ERROR_BIT_KHR")]
    ContextFlagNoErrorBitKHR = unchecked((uint)0x00000008),

    [NativeName("GL_MAX_SHADER_COMPILER_THREADS_KHR")]
    MaxShaderCompilerThreadsKHR = unchecked((uint)0x91B0),

    [NativeName("GL_COMPLETION_STATUS_KHR")]
    CompletionStatusKHR = unchecked((uint)0x91B1),

    [NativeName("GL_CONTEXT_ROBUST_ACCESS")]
    ContextRobustAccess = unchecked((uint)0x90F3),

    [NativeName("GL_SUBGROUP_SIZE_KHR")]
    SubgroupSizeKHR = unchecked((uint)0x9532),

    [NativeName("GL_SUBGROUP_SUPPORTED_STAGES_KHR")]
    SubgroupSupportedStagesKHR = unchecked((uint)0x9533),

    [NativeName("GL_SUBGROUP_SUPPORTED_FEATURES_KHR")]
    SubgroupSupportedFeaturesKHR = unchecked((uint)0x9534),

    [NativeName("GL_SUBGROUP_QUAD_ALL_STAGES_KHR")]
    SubgroupQuadAllStagesKHR = unchecked((uint)0x9535),

    [NativeName("GL_SUBGROUP_FEATURE_BASIC_BIT_KHR")]
    SubgroupFeatureBasicBitKHR = unchecked((uint)0x00000001),

    [NativeName("GL_SUBGROUP_FEATURE_VOTE_BIT_KHR")]
    SubgroupFeatureVoteBitKHR = unchecked((uint)0x00000002),

    [NativeName("GL_SUBGROUP_FEATURE_ARITHMETIC_BIT_KHR")]
    SubgroupFeatureArithmeticBitKHR = unchecked((uint)0x00000004),

    [NativeName("GL_SUBGROUP_FEATURE_BALLOT_BIT_KHR")]
    SubgroupFeatureBallotBitKHR = unchecked((uint)0x00000008),

    [NativeName("GL_SUBGROUP_FEATURE_SHUFFLE_BIT_KHR")]
    SubgroupFeatureShuffleBitKHR = unchecked((uint)0x00000010),

    [NativeName("GL_SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT_KHR")]
    SubgroupFeatureShuffleRelativeBitKHR = unchecked((uint)0x00000020),

    [NativeName("GL_SUBGROUP_FEATURE_CLUSTERED_BIT_KHR")]
    SubgroupFeatureClusteredBitKHR = unchecked((uint)0x00000040),

    [NativeName("GL_SUBGROUP_FEATURE_QUAD_BIT_KHR")]
    SubgroupFeatureQuadBitKHR = unchecked((uint)0x00000080),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_4x4_KHR")]
    CompressedRgbaAstc4X4KHR = unchecked((uint)0x93B0),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_5x4_KHR")]
    CompressedRgbaAstc5X4KHR = unchecked((uint)0x93B1),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_5x5_KHR")]
    CompressedRgbaAstc5X5KHR = unchecked((uint)0x93B2),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_6x5_KHR")]
    CompressedRgbaAstc6X5KHR = unchecked((uint)0x93B3),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_6x6_KHR")]
    CompressedRgbaAstc6X6KHR = unchecked((uint)0x93B4),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_8x5_KHR")]
    CompressedRgbaAstc8X5KHR = unchecked((uint)0x93B5),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_8x6_KHR")]
    CompressedRgbaAstc8X6KHR = unchecked((uint)0x93B6),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_8x8_KHR")]
    CompressedRgbaAstc8X8KHR = unchecked((uint)0x93B7),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_10x5_KHR")]
    CompressedRgbaAstc10X5KHR = unchecked((uint)0x93B8),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_10x6_KHR")]
    CompressedRgbaAstc10X6KHR = unchecked((uint)0x93B9),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_10x8_KHR")]
    CompressedRgbaAstc10X8KHR = unchecked((uint)0x93BA),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_10x10_KHR")]
    CompressedRgbaAstc10X10KHR = unchecked((uint)0x93BB),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_12x10_KHR")]
    CompressedRgbaAstc12X10KHR = unchecked((uint)0x93BC),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_12x12_KHR")]
    CompressedRgbaAstc12X12KHR = unchecked((uint)0x93BD),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR")]
    CompressedSrgb8Alpha8Astc4X4KHR = unchecked((uint)0x93D0),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4_KHR")]
    CompressedSrgb8Alpha8Astc5X4KHR = unchecked((uint)0x93D1),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5_KHR")]
    CompressedSrgb8Alpha8Astc5X5KHR = unchecked((uint)0x93D2),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5_KHR")]
    CompressedSrgb8Alpha8Astc6X5KHR = unchecked((uint)0x93D3),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6_KHR")]
    CompressedSrgb8Alpha8Astc6X6KHR = unchecked((uint)0x93D4),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x5_KHR")]
    CompressedSrgb8Alpha8Astc8X5KHR = unchecked((uint)0x93D5),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x6_KHR")]
    CompressedSrgb8Alpha8Astc8X6KHR = unchecked((uint)0x93D6),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x8_KHR")]
    CompressedSrgb8Alpha8Astc8X8KHR = unchecked((uint)0x93D7),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x5_KHR")]
    CompressedSrgb8Alpha8Astc10X5KHR = unchecked((uint)0x93D8),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x6_KHR")]
    CompressedSrgb8Alpha8Astc10X6KHR = unchecked((uint)0x93D9),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x8_KHR")]
    CompressedSrgb8Alpha8Astc10X8KHR = unchecked((uint)0x93DA),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x10_KHR")]
    CompressedSrgb8Alpha8Astc10X10KHR = unchecked((uint)0x93DB),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x10_KHR")]
    CompressedSrgb8Alpha8Astc12X10KHR = unchecked((uint)0x93DC),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x12_KHR")]
    CompressedSrgb8Alpha8Astc12X12KHR = unchecked((uint)0x93DD),

    [NativeName("GL_MULTISAMPLE_3DFX")]
    Multisample3DFX = unchecked((uint)0x86B2),

    [NativeName("GL_SAMPLE_BUFFERS_3DFX")]
    SampleBuffers3DFX = unchecked((uint)0x86B3),

    [NativeName("GL_SAMPLES_3DFX")]
    Samples3DFX = unchecked((uint)0x86B4),

    [NativeName("GL_MULTISAMPLE_BIT_3DFX")]
    MultisampleBit3DFX = unchecked((uint)0x20000000),

    [NativeName("GL_COMPRESSED_RGB_FXT1_3DFX")]
    CompressedRgbFxt1X3DFX = unchecked((uint)0x86B0),

    [NativeName("GL_COMPRESSED_RGBA_FXT1_3DFX")]
    CompressedRgbaFxt1X3DFX = unchecked((uint)0x86B1),

    [NativeName("GL_FACTOR_MIN_AMD")]
    FactorMinAMD = unchecked((uint)0x901C),

    [NativeName("GL_FACTOR_MAX_AMD")]
    FactorMaxAMD = unchecked((uint)0x901D),

    [NativeName("GL_MAX_DEBUG_MESSAGE_LENGTH_AMD")]
    MaxDebugMessageLengthAMD = unchecked((uint)0x9143),

    [NativeName("GL_MAX_DEBUG_LOGGED_MESSAGES_AMD")]
    MaxDebugLoggedMessagesAMD = unchecked((uint)0x9144),

    [NativeName("GL_DEBUG_LOGGED_MESSAGES_AMD")]
    DebugLoggedMessagesAMD = unchecked((uint)0x9145),

    [NativeName("GL_DEBUG_SEVERITY_HIGH_AMD")]
    DebugSeverityHighAMD = unchecked((uint)0x9146),

    [NativeName("GL_DEBUG_SEVERITY_MEDIUM_AMD")]
    DebugSeverityMediumAMD = unchecked((uint)0x9147),

    [NativeName("GL_DEBUG_SEVERITY_LOW_AMD")]
    DebugSeverityLowAMD = unchecked((uint)0x9148),

    [NativeName("GL_DEBUG_CATEGORY_API_ERROR_AMD")]
    DebugCategoryApiErrorAMD = unchecked((uint)0x9149),

    [NativeName("GL_DEBUG_CATEGORY_WINDOW_SYSTEM_AMD")]
    DebugCategoryWindowSystemAMD = unchecked((uint)0x914A),

    [NativeName("GL_DEBUG_CATEGORY_DEPRECATION_AMD")]
    DebugCategoryDeprecationAMD = unchecked((uint)0x914B),

    [NativeName("GL_DEBUG_CATEGORY_UNDEFINED_BEHAVIOR_AMD")]
    DebugCategoryUndefinedBehaviorAMD = unchecked((uint)0x914C),

    [NativeName("GL_DEBUG_CATEGORY_PERFORMANCE_AMD")]
    DebugCategoryPerformanceAMD = unchecked((uint)0x914D),

    [NativeName("GL_DEBUG_CATEGORY_SHADER_COMPILER_AMD")]
    DebugCategoryShaderCompilerAMD = unchecked((uint)0x914E),

    [NativeName("GL_DEBUG_CATEGORY_APPLICATION_AMD")]
    DebugCategoryApplicationAMD = unchecked((uint)0x914F),

    [NativeName("GL_DEBUG_CATEGORY_OTHER_AMD")]
    DebugCategoryOtherAMD = unchecked((uint)0x9150),

    [NativeName("GL_DEPTH_CLAMP_NEAR_AMD")]
    DepthClampNearAMD = unchecked((uint)0x901E),

    [NativeName("GL_DEPTH_CLAMP_FAR_AMD")]
    DepthClampFarAMD = unchecked((uint)0x901F),

    [NativeName("GL_RENDERBUFFER_STORAGE_SAMPLES_AMD")]
    RenderbufferStorageSamplesAMD = unchecked((uint)0x91B2),

    [NativeName("GL_MAX_COLOR_FRAMEBUFFER_SAMPLES_AMD")]
    MaxColorFramebufferSamplesAMD = unchecked((uint)0x91B3),

    [NativeName("GL_MAX_COLOR_FRAMEBUFFER_STORAGE_SAMPLES_AMD")]
    MaxColorFramebufferStorageSamplesAMD = unchecked((uint)0x91B4),

    [NativeName("GL_MAX_DEPTH_STENCIL_FRAMEBUFFER_SAMPLES_AMD")]
    MaxDepthStencilFramebufferSamplesAMD = unchecked((uint)0x91B5),

    [NativeName("GL_NUM_SUPPORTED_MULTISAMPLE_MODES_AMD")]
    NumSupportedMultisampleModesAMD = unchecked((uint)0x91B6),

    [NativeName("GL_SUPPORTED_MULTISAMPLE_MODES_AMD")]
    SupportedMultisampleModesAMD = unchecked((uint)0x91B7),

    [NativeName("GL_SUBSAMPLE_DISTANCE_AMD")]
    SubsampleDistanceAMD = unchecked((uint)0x883F),

    [NativeName("GL_PIXELS_PER_SAMPLE_PATTERN_X_AMD")]
    PixelsPerSamplePatternXAMD = unchecked((uint)0x91AE),

    [NativeName("GL_PIXELS_PER_SAMPLE_PATTERN_Y_AMD")]
    PixelsPerSamplePatternYAMD = unchecked((uint)0x91AF),

    [NativeName("GL_ALL_PIXELS_AMD")]
    AllPixelsAMD = unchecked((uint)0xFFFFFFFF),

    [NativeName("GL_FLOAT16_NV")]
    Float16NV = unchecked((uint)0x8FF8),

    [NativeName("GL_FLOAT16_VEC2_NV")]
    Float16Vec2NV = unchecked((uint)0x8FF9),

    [NativeName("GL_FLOAT16_VEC3_NV")]
    Float16Vec3NV = unchecked((uint)0x8FFA),

    [NativeName("GL_FLOAT16_VEC4_NV")]
    Float16Vec4NV = unchecked((uint)0x8FFB),

    [NativeName("GL_FLOAT16_MAT2_AMD")]
    Float16Mat2AMD = unchecked((uint)0x91C5),

    [NativeName("GL_FLOAT16_MAT3_AMD")]
    Float16Mat3AMD = unchecked((uint)0x91C6),

    [NativeName("GL_FLOAT16_MAT4_AMD")]
    Float16Mat4AMD = unchecked((uint)0x91C7),

    [NativeName("GL_FLOAT16_MAT2x3_AMD")]
    Float16Mat2X3AMD = unchecked((uint)0x91C8),

    [NativeName("GL_FLOAT16_MAT2x4_AMD")]
    Float16Mat2X4AMD = unchecked((uint)0x91C9),

    [NativeName("GL_FLOAT16_MAT3x2_AMD")]
    Float16Mat3X2AMD = unchecked((uint)0x91CA),

    [NativeName("GL_FLOAT16_MAT3x4_AMD")]
    Float16Mat3X4AMD = unchecked((uint)0x91CB),

    [NativeName("GL_FLOAT16_MAT4x2_AMD")]
    Float16Mat4X2AMD = unchecked((uint)0x91CC),

    [NativeName("GL_FLOAT16_MAT4x3_AMD")]
    Float16Mat4X3AMD = unchecked((uint)0x91CD),

    [NativeName("GL_INT64_NV")]
    Int64NV = unchecked((uint)0x140E),

    [NativeName("GL_UNSIGNED_INT64_NV")]
    UnsignedInt64NV = unchecked((uint)0x140F),

    [NativeName("GL_INT8_NV")]
    Int8NV = unchecked((uint)0x8FE0),

    [NativeName("GL_INT8_VEC2_NV")]
    Int8Vec2NV = unchecked((uint)0x8FE1),

    [NativeName("GL_INT8_VEC3_NV")]
    Int8Vec3NV = unchecked((uint)0x8FE2),

    [NativeName("GL_INT8_VEC4_NV")]
    Int8Vec4NV = unchecked((uint)0x8FE3),

    [NativeName("GL_INT16_NV")]
    Int16NV = unchecked((uint)0x8FE4),

    [NativeName("GL_INT16_VEC2_NV")]
    Int16Vec2NV = unchecked((uint)0x8FE5),

    [NativeName("GL_INT16_VEC3_NV")]
    Int16Vec3NV = unchecked((uint)0x8FE6),

    [NativeName("GL_INT16_VEC4_NV")]
    Int16Vec4NV = unchecked((uint)0x8FE7),

    [NativeName("GL_INT64_VEC2_NV")]
    Int64Vec2NV = unchecked((uint)0x8FE9),

    [NativeName("GL_INT64_VEC3_NV")]
    Int64Vec3NV = unchecked((uint)0x8FEA),

    [NativeName("GL_INT64_VEC4_NV")]
    Int64Vec4NV = unchecked((uint)0x8FEB),

    [NativeName("GL_UNSIGNED_INT8_NV")]
    UnsignedInt8NV = unchecked((uint)0x8FEC),

    [NativeName("GL_UNSIGNED_INT8_VEC2_NV")]
    UnsignedInt8Vec2NV = unchecked((uint)0x8FED),

    [NativeName("GL_UNSIGNED_INT8_VEC3_NV")]
    UnsignedInt8Vec3NV = unchecked((uint)0x8FEE),

    [NativeName("GL_UNSIGNED_INT8_VEC4_NV")]
    UnsignedInt8Vec4NV = unchecked((uint)0x8FEF),

    [NativeName("GL_UNSIGNED_INT16_NV")]
    UnsignedInt16NV = unchecked((uint)0x8FF0),

    [NativeName("GL_UNSIGNED_INT16_VEC2_NV")]
    UnsignedInt16Vec2NV = unchecked((uint)0x8FF1),

    [NativeName("GL_UNSIGNED_INT16_VEC3_NV")]
    UnsignedInt16Vec3NV = unchecked((uint)0x8FF2),

    [NativeName("GL_UNSIGNED_INT16_VEC4_NV")]
    UnsignedInt16Vec4NV = unchecked((uint)0x8FF3),

    [NativeName("GL_UNSIGNED_INT64_VEC2_NV")]
    UnsignedInt64Vec2NV = unchecked((uint)0x8FF5),

    [NativeName("GL_UNSIGNED_INT64_VEC3_NV")]
    UnsignedInt64Vec3NV = unchecked((uint)0x8FF6),

    [NativeName("GL_UNSIGNED_INT64_VEC4_NV")]
    UnsignedInt64Vec4NV = unchecked((uint)0x8FF7),

    [NativeName("GL_VERTEX_ELEMENT_SWIZZLE_AMD")]
    VertexElementSwizzleAMD = unchecked((uint)0x91A4),

    [NativeName("GL_VERTEX_ID_SWIZZLE_AMD")]
    VertexIdSwizzleAMD = unchecked((uint)0x91A5),

    [NativeName("GL_DATA_BUFFER_AMD")]
    DataBufferAMD = unchecked((uint)0x9151),

    [NativeName("GL_PERFORMANCE_MONITOR_AMD")]
    PerformanceMonitorAMD = unchecked((uint)0x9152),

    [NativeName("GL_QUERY_OBJECT_AMD")]
    QueryObjectAMD = unchecked((uint)0x9153),

    [NativeName("GL_VERTEX_ARRAY_OBJECT_AMD")]
    VertexArrayObjectAMD = unchecked((uint)0x9154),

    [NativeName("GL_SAMPLER_OBJECT_AMD")]
    SamplerObjectAMD = unchecked((uint)0x9155),

    [NativeName("GL_OCCLUSION_QUERY_EVENT_MASK_AMD")]
    OcclusionQueryEventMaskAMD = unchecked((uint)0x874F),

    [NativeName("GL_QUERY_DEPTH_PASS_EVENT_BIT_AMD")]
    QueryDepthPassEventBitAMD = unchecked((uint)0x00000001),

    [NativeName("GL_QUERY_DEPTH_FAIL_EVENT_BIT_AMD")]
    QueryDepthFailEventBitAMD = unchecked((uint)0x00000002),

    [NativeName("GL_QUERY_STENCIL_FAIL_EVENT_BIT_AMD")]
    QueryStencilFailEventBitAMD = unchecked((uint)0x00000004),

    [NativeName("GL_QUERY_DEPTH_BOUNDS_FAIL_EVENT_BIT_AMD")]
    QueryDepthBoundsFailEventBitAMD = unchecked((uint)0x00000008),

    [NativeName("GL_QUERY_ALL_EVENT_BITS_AMD")]
    QueryAllEventBitsAMD = unchecked((uint)0xFFFFFFFF),

    [NativeName("GL_COUNTER_TYPE_AMD")]
    CounterTypeAMD = unchecked((uint)0x8BC0),

    [NativeName("GL_COUNTER_RANGE_AMD")]
    CounterRangeAMD = unchecked((uint)0x8BC1),

    [NativeName("GL_UNSIGNED_INT64_AMD")]
    UnsignedInt64AMD = unchecked((uint)0x8BC2),

    [NativeName("GL_PERCENTAGE_AMD")]
    PercentageAMD = unchecked((uint)0x8BC3),

    [NativeName("GL_PERFMON_RESULT_AVAILABLE_AMD")]
    PerfmonResultAvailableAMD = unchecked((uint)0x8BC4),

    [NativeName("GL_PERFMON_RESULT_SIZE_AMD")]
    PerfmonResultSizeAMD = unchecked((uint)0x8BC5),

    [NativeName("GL_PERFMON_RESULT_AMD")]
    PerfmonResultAMD = unchecked((uint)0x8BC6),

    [NativeName("GL_EXTERNAL_VIRTUAL_MEMORY_BUFFER_AMD")]
    ExternalVirtualMemoryBufferAMD = unchecked((uint)0x9160),

    [NativeName("GL_QUERY_BUFFER_AMD")]
    QueryBufferAMD = unchecked((uint)0x9192),

    [NativeName("GL_QUERY_BUFFER_BINDING_AMD")]
    QueryBufferBindingAMD = unchecked((uint)0x9193),

    [NativeName("GL_QUERY_RESULT_NO_WAIT_AMD")]
    QueryResultNoWaitAMD = unchecked((uint)0x9194),

    [NativeName("GL_VIRTUAL_PAGE_SIZE_X_AMD")]
    VirtualPageSizeXAMD = unchecked((uint)0x9195),

    [NativeName("GL_VIRTUAL_PAGE_SIZE_Y_AMD")]
    VirtualPageSizeYAMD = unchecked((uint)0x9196),

    [NativeName("GL_VIRTUAL_PAGE_SIZE_Z_AMD")]
    VirtualPageSizeZAMD = unchecked((uint)0x9197),

    [NativeName("GL_MAX_SPARSE_TEXTURE_SIZE_AMD")]
    MaxSparseTextureSizeAMD = unchecked((uint)0x9198),

    [NativeName("GL_MAX_SPARSE_3D_TEXTURE_SIZE_AMD")]
    MaxSparse3DTextureSizeAMD = unchecked((uint)0x9199),

    [NativeName("GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS")]
    MaxSparseArrayTextureLayers = unchecked((uint)0x919A),

    [NativeName("GL_MIN_SPARSE_LEVEL_AMD")]
    MinSparseLevelAMD = unchecked((uint)0x919B),

    [NativeName("GL_MIN_LOD_WARNING_AMD")]
    MinLodWarningAMD = unchecked((uint)0x919C),

    [NativeName("GL_TEXTURE_STORAGE_SPARSE_BIT_AMD")]
    TextureStorageSparseBitAMD = unchecked((uint)0x00000001),

    [NativeName("GL_SET_AMD")]
    SetAMD = unchecked((uint)0x874A),

    [NativeName("GL_REPLACE_VALUE_AMD")]
    ReplaceValueAMD = unchecked((uint)0x874B),

    [NativeName("GL_STENCIL_OP_VALUE_AMD")]
    StencilOpValueAMD = unchecked((uint)0x874C),

    [NativeName("GL_STENCIL_BACK_OP_VALUE_AMD")]
    StencilBackOpValueAMD = unchecked((uint)0x874D),

    [NativeName("GL_STREAM_RASTERIZATION_AMD")]
    StreamRasterizationAMD = unchecked((uint)0x91A0),

    [NativeName("GL_SAMPLER_BUFFER_AMD")]
    SamplerBufferAMD = unchecked((uint)0x9001),

    [NativeName("GL_INT_SAMPLER_BUFFER_AMD")]
    IntSamplerBufferAMD = unchecked((uint)0x9002),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_BUFFER_AMD")]
    UnsignedIntSamplerBufferAMD = unchecked((uint)0x9003),

    [NativeName("GL_TESSELLATION_MODE_AMD")]
    TessellationModeAMD = unchecked((uint)0x9004),

    [NativeName("GL_TESSELLATION_FACTOR_AMD")]
    TessellationFactorAMD = unchecked((uint)0x9005),

    [NativeName("GL_DISCRETE_AMD")]
    DiscreteAMD = unchecked((uint)0x9006),

    [NativeName("GL_CONTINUOUS_AMD")]
    ContinuousAMD = unchecked((uint)0x9007),

    [NativeName("GL_AUX_DEPTH_STENCIL_APPLE")]
    AuxDepthStencilAPPLE = unchecked((uint)0x8A14),

    [NativeName("GL_UNPACK_CLIENT_STORAGE_APPLE")]
    UnpackClientStorageAPPLE = unchecked((uint)0x85B2),

    [NativeName("GL_ELEMENT_ARRAY_APPLE")]
    ElementArrayAPPLE = unchecked((uint)0x8A0C),

    [NativeName("GL_ELEMENT_ARRAY_TYPE_APPLE")]
    ElementArrayTypeAPPLE = unchecked((uint)0x8A0D),

    [NativeName("GL_ELEMENT_ARRAY_POINTER_APPLE")]
    ElementArrayPointerAPPLE = unchecked((uint)0x8A0E),

    [NativeName("GL_DRAW_PIXELS_APPLE")]
    DrawPixelsAPPLE = unchecked((uint)0x8A0A),

    [NativeName("GL_FENCE_APPLE")]
    FenceAPPLE = unchecked((uint)0x8A0B),

    [NativeName("GL_HALF_APPLE")]
    HalfAPPLE = unchecked((uint)0x140B),

    [NativeName("GL_RGBA_FLOAT32_APPLE")]
    RgbaFloat32APPLE = unchecked((uint)0x8814),

    [NativeName("GL_RGB_FLOAT32_APPLE")]
    RgbFloat32APPLE = unchecked((uint)0x8815),

    [NativeName("GL_ALPHA_FLOAT32_APPLE")]
    AlphaFloat32APPLE = unchecked((uint)0x8816),

    [NativeName("GL_INTENSITY_FLOAT32_APPLE")]
    IntensityFloat32APPLE = unchecked((uint)0x8817),

    [NativeName("GL_LUMINANCE_FLOAT32_APPLE")]
    LuminanceFloat32APPLE = unchecked((uint)0x8818),

    [NativeName("GL_LUMINANCE_ALPHA_FLOAT32_APPLE")]
    LuminanceAlphaFloat32APPLE = unchecked((uint)0x8819),

    [NativeName("GL_RGBA_FLOAT16_APPLE")]
    RgbaFloat16APPLE = unchecked((uint)0x881A),

    [NativeName("GL_RGB_FLOAT16_APPLE")]
    RgbFloat16APPLE = unchecked((uint)0x881B),

    [NativeName("GL_ALPHA_FLOAT16_APPLE")]
    AlphaFloat16APPLE = unchecked((uint)0x881C),

    [NativeName("GL_INTENSITY_FLOAT16_APPLE")]
    IntensityFloat16APPLE = unchecked((uint)0x881D),

    [NativeName("GL_LUMINANCE_FLOAT16_APPLE")]
    LuminanceFloat16APPLE = unchecked((uint)0x881E),

    [NativeName("GL_LUMINANCE_ALPHA_FLOAT16_APPLE")]
    LuminanceAlphaFloat16APPLE = unchecked((uint)0x881F),

    [NativeName("GL_COLOR_FLOAT_APPLE")]
    ColorFloatAPPLE = unchecked((uint)0x8A0F),

    [NativeName("GL_BUFFER_SERIALIZED_MODIFY_APPLE")]
    BufferSerializedModifyAPPLE = unchecked((uint)0x8A12),

    [NativeName("GL_BUFFER_FLUSHING_UNMAP_APPLE")]
    BufferFlushingUnmapAPPLE = unchecked((uint)0x8A13),

    [NativeName("GL_BUFFER_OBJECT_APPLE")]
    BufferObjectAPPLE = unchecked((uint)0x85B3),

    [NativeName("GL_RELEASED_APPLE")]
    ReleasedAPPLE = unchecked((uint)0x8A19),

    [NativeName("GL_VOLATILE_APPLE")]
    VolatileAPPLE = unchecked((uint)0x8A1A),

    [NativeName("GL_RETAINED_APPLE")]
    RetainedAPPLE = unchecked((uint)0x8A1B),

    [NativeName("GL_UNDEFINED_APPLE")]
    UndefinedAPPLE = unchecked((uint)0x8A1C),

    [NativeName("GL_PURGEABLE_APPLE")]
    PurgeableAPPLE = unchecked((uint)0x8A1D),

    [NativeName("GL_RGB_422_APPLE")]
    Rgb422APPLE = unchecked((uint)0x8A1F),

    [NativeName("GL_UNSIGNED_SHORT_8_8_APPLE")]
    UnsignedShort8X8APPLE = unchecked((uint)0x85BA),

    [NativeName("GL_UNSIGNED_SHORT_8_8_REV_APPLE")]
    UnsignedShort8X8RevAPPLE = unchecked((uint)0x85BB),

    [NativeName("GL_RGB_RAW_422_APPLE")]
    RgbRaw422APPLE = unchecked((uint)0x8A51),

    [NativeName("GL_PACK_ROW_BYTES_APPLE")]
    PackRowBytesAPPLE = unchecked((uint)0x8A15),

    [NativeName("GL_UNPACK_ROW_BYTES_APPLE")]
    UnpackRowBytesAPPLE = unchecked((uint)0x8A16),

    [NativeName("GL_LIGHT_MODEL_SPECULAR_VECTOR_APPLE")]
    LightModelSpecularVectorAPPLE = unchecked((uint)0x85B0),

    [NativeName("GL_TEXTURE_RANGE_LENGTH_APPLE")]
    TextureRangeLengthAPPLE = unchecked((uint)0x85B7),

    [NativeName("GL_TEXTURE_RANGE_POINTER_APPLE")]
    TextureRangePointerAPPLE = unchecked((uint)0x85B8),

    [NativeName("GL_TEXTURE_STORAGE_HINT_APPLE")]
    TextureStorageHintAPPLE = unchecked((uint)0x85BC),

    [NativeName("GL_STORAGE_PRIVATE_APPLE")]
    StoragePrivateAPPLE = unchecked((uint)0x85BD),

    [NativeName("GL_STORAGE_CACHED_APPLE")]
    StorageCachedAPPLE = unchecked((uint)0x85BE),

    [NativeName("GL_STORAGE_SHARED_APPLE")]
    StorageSharedAPPLE = unchecked((uint)0x85BF),

    [NativeName("GL_TRANSFORM_HINT_APPLE")]
    TransformHintAPPLE = unchecked((uint)0x85B1),

    [NativeName("GL_VERTEX_ARRAY_BINDING_APPLE")]
    VertexArrayBindingAPPLE = unchecked((uint)0x85B5),

    [NativeName("GL_VERTEX_ARRAY_RANGE_APPLE")]
    VertexArrayRangeAPPLE = unchecked((uint)0x851D),

    [NativeName("GL_VERTEX_ARRAY_RANGE_LENGTH_APPLE")]
    VertexArrayRangeLengthAPPLE = unchecked((uint)0x851E),

    [NativeName("GL_VERTEX_ARRAY_STORAGE_HINT_APPLE")]
    VertexArrayStorageHintAPPLE = unchecked((uint)0x851F),

    [NativeName("GL_VERTEX_ARRAY_RANGE_POINTER_APPLE")]
    VertexArrayRangePointerAPPLE = unchecked((uint)0x8521),

    [NativeName("GL_STORAGE_CLIENT_APPLE")]
    StorageClientAPPLE = unchecked((uint)0x85B4),

    [NativeName("GL_VERTEX_ATTRIB_MAP1_APPLE")]
    VertexAttribMap1APPLE = unchecked((uint)0x8A00),

    [NativeName("GL_VERTEX_ATTRIB_MAP2_APPLE")]
    VertexAttribMap2APPLE = unchecked((uint)0x8A01),

    [NativeName("GL_VERTEX_ATTRIB_MAP1_SIZE_APPLE")]
    VertexAttribMap1SizeAPPLE = unchecked((uint)0x8A02),

    [NativeName("GL_VERTEX_ATTRIB_MAP1_COEFF_APPLE")]
    VertexAttribMap1CoeffAPPLE = unchecked((uint)0x8A03),

    [NativeName("GL_VERTEX_ATTRIB_MAP1_ORDER_APPLE")]
    VertexAttribMap1OrderAPPLE = unchecked((uint)0x8A04),

    [NativeName("GL_VERTEX_ATTRIB_MAP1_DOMAIN_APPLE")]
    VertexAttribMap1DomainAPPLE = unchecked((uint)0x8A05),

    [NativeName("GL_VERTEX_ATTRIB_MAP2_SIZE_APPLE")]
    VertexAttribMap2SizeAPPLE = unchecked((uint)0x8A06),

    [NativeName("GL_VERTEX_ATTRIB_MAP2_COEFF_APPLE")]
    VertexAttribMap2CoeffAPPLE = unchecked((uint)0x8A07),

    [NativeName("GL_VERTEX_ATTRIB_MAP2_ORDER_APPLE")]
    VertexAttribMap2OrderAPPLE = unchecked((uint)0x8A08),

    [NativeName("GL_VERTEX_ATTRIB_MAP2_DOMAIN_APPLE")]
    VertexAttribMap2DomainAPPLE = unchecked((uint)0x8A09),

    [NativeName("GL_YCBCR_422_APPLE")]
    Ycbcr422APPLE = unchecked((uint)0x85B9),

    [NativeName("GL_MAX_DRAW_BUFFERS_ATI")]
    MaxDrawBuffersATI = unchecked((uint)0x8824),

    [NativeName("GL_DRAW_BUFFER0_ATI")]
    DrawBuffer0ATI = unchecked((uint)0x8825),

    [NativeName("GL_DRAW_BUFFER1_ATI")]
    DrawBuffer1ATI = unchecked((uint)0x8826),

    [NativeName("GL_DRAW_BUFFER2_ATI")]
    DrawBuffer2ATI = unchecked((uint)0x8827),

    [NativeName("GL_DRAW_BUFFER3_ATI")]
    DrawBuffer3ATI = unchecked((uint)0x8828),

    [NativeName("GL_DRAW_BUFFER4_ATI")]
    DrawBuffer4ATI = unchecked((uint)0x8829),

    [NativeName("GL_DRAW_BUFFER5_ATI")]
    DrawBuffer5ATI = unchecked((uint)0x882A),

    [NativeName("GL_DRAW_BUFFER6_ATI")]
    DrawBuffer6ATI = unchecked((uint)0x882B),

    [NativeName("GL_DRAW_BUFFER7_ATI")]
    DrawBuffer7ATI = unchecked((uint)0x882C),

    [NativeName("GL_DRAW_BUFFER8_ATI")]
    DrawBuffer8ATI = unchecked((uint)0x882D),

    [NativeName("GL_DRAW_BUFFER9_ATI")]
    DrawBuffer9ATI = unchecked((uint)0x882E),

    [NativeName("GL_DRAW_BUFFER10_ATI")]
    DrawBuffer10ATI = unchecked((uint)0x882F),

    [NativeName("GL_DRAW_BUFFER11_ATI")]
    DrawBuffer11ATI = unchecked((uint)0x8830),

    [NativeName("GL_DRAW_BUFFER12_ATI")]
    DrawBuffer12ATI = unchecked((uint)0x8831),

    [NativeName("GL_DRAW_BUFFER13_ATI")]
    DrawBuffer13ATI = unchecked((uint)0x8832),

    [NativeName("GL_DRAW_BUFFER14_ATI")]
    DrawBuffer14ATI = unchecked((uint)0x8833),

    [NativeName("GL_DRAW_BUFFER15_ATI")]
    DrawBuffer15ATI = unchecked((uint)0x8834),

    [NativeName("GL_ELEMENT_ARRAY_ATI")]
    ElementArrayATI = unchecked((uint)0x8768),

    [NativeName("GL_ELEMENT_ARRAY_TYPE_ATI")]
    ElementArrayTypeATI = unchecked((uint)0x8769),

    [NativeName("GL_ELEMENT_ARRAY_POINTER_ATI")]
    ElementArrayPointerATI = unchecked((uint)0x876A),

    [NativeName("GL_BUMP_ROT_MATRIX_ATI")]
    BumpRotMatrixATI = unchecked((uint)0x8775),

    [NativeName("GL_BUMP_ROT_MATRIX_SIZE_ATI")]
    BumpRotMatrixSizeATI = unchecked((uint)0x8776),

    [NativeName("GL_BUMP_NUM_TEX_UNITS_ATI")]
    BumpNumTexUnitsATI = unchecked((uint)0x8777),

    [NativeName("GL_BUMP_TEX_UNITS_ATI")]
    BumpTexUnitsATI = unchecked((uint)0x8778),

    [NativeName("GL_DUDV_ATI")]
    DudvATI = unchecked((uint)0x8779),

    [NativeName("GL_DU8DV8_ATI")]
    Du8Dv8ATI = unchecked((uint)0x877A),

    [NativeName("GL_BUMP_ENVMAP_ATI")]
    BumpEnvmapATI = unchecked((uint)0x877B),

    [NativeName("GL_BUMP_TARGET_ATI")]
    BumpTargetATI = unchecked((uint)0x877C),

    [NativeName("GL_FRAGMENT_SHADER_ATI")]
    FragmentShaderATI = unchecked((uint)0x8920),

    [NativeName("GL_REG_0_ATI")]
    Reg0ATI = unchecked((uint)0x8921),

    [NativeName("GL_REG_1_ATI")]
    Reg1ATI = unchecked((uint)0x8922),

    [NativeName("GL_REG_2_ATI")]
    Reg2ATI = unchecked((uint)0x8923),

    [NativeName("GL_REG_3_ATI")]
    Reg3ATI = unchecked((uint)0x8924),

    [NativeName("GL_REG_4_ATI")]
    Reg4ATI = unchecked((uint)0x8925),

    [NativeName("GL_REG_5_ATI")]
    Reg5ATI = unchecked((uint)0x8926),

    [NativeName("GL_REG_6_ATI")]
    Reg6ATI = unchecked((uint)0x8927),

    [NativeName("GL_REG_7_ATI")]
    Reg7ATI = unchecked((uint)0x8928),

    [NativeName("GL_REG_8_ATI")]
    Reg8ATI = unchecked((uint)0x8929),

    [NativeName("GL_REG_9_ATI")]
    Reg9ATI = unchecked((uint)0x892A),

    [NativeName("GL_REG_10_ATI")]
    Reg10ATI = unchecked((uint)0x892B),

    [NativeName("GL_REG_11_ATI")]
    Reg11ATI = unchecked((uint)0x892C),

    [NativeName("GL_REG_12_ATI")]
    Reg12ATI = unchecked((uint)0x892D),

    [NativeName("GL_REG_13_ATI")]
    Reg13ATI = unchecked((uint)0x892E),

    [NativeName("GL_REG_14_ATI")]
    Reg14ATI = unchecked((uint)0x892F),

    [NativeName("GL_REG_15_ATI")]
    Reg15ATI = unchecked((uint)0x8930),

    [NativeName("GL_REG_16_ATI")]
    Reg16ATI = unchecked((uint)0x8931),

    [NativeName("GL_REG_17_ATI")]
    Reg17ATI = unchecked((uint)0x8932),

    [NativeName("GL_REG_18_ATI")]
    Reg18ATI = unchecked((uint)0x8933),

    [NativeName("GL_REG_19_ATI")]
    Reg19ATI = unchecked((uint)0x8934),

    [NativeName("GL_REG_20_ATI")]
    Reg20ATI = unchecked((uint)0x8935),

    [NativeName("GL_REG_21_ATI")]
    Reg21ATI = unchecked((uint)0x8936),

    [NativeName("GL_REG_22_ATI")]
    Reg22ATI = unchecked((uint)0x8937),

    [NativeName("GL_REG_23_ATI")]
    Reg23ATI = unchecked((uint)0x8938),

    [NativeName("GL_REG_24_ATI")]
    Reg24ATI = unchecked((uint)0x8939),

    [NativeName("GL_REG_25_ATI")]
    Reg25ATI = unchecked((uint)0x893A),

    [NativeName("GL_REG_26_ATI")]
    Reg26ATI = unchecked((uint)0x893B),

    [NativeName("GL_REG_27_ATI")]
    Reg27ATI = unchecked((uint)0x893C),

    [NativeName("GL_REG_28_ATI")]
    Reg28ATI = unchecked((uint)0x893D),

    [NativeName("GL_REG_29_ATI")]
    Reg29ATI = unchecked((uint)0x893E),

    [NativeName("GL_REG_30_ATI")]
    Reg30ATI = unchecked((uint)0x893F),

    [NativeName("GL_REG_31_ATI")]
    Reg31ATI = unchecked((uint)0x8940),

    [NativeName("GL_CON_0_ATI")]
    Con0ATI = unchecked((uint)0x8941),

    [NativeName("GL_CON_1_ATI")]
    Con1ATI = unchecked((uint)0x8942),

    [NativeName("GL_CON_2_ATI")]
    Con2ATI = unchecked((uint)0x8943),

    [NativeName("GL_CON_3_ATI")]
    Con3ATI = unchecked((uint)0x8944),

    [NativeName("GL_CON_4_ATI")]
    Con4ATI = unchecked((uint)0x8945),

    [NativeName("GL_CON_5_ATI")]
    Con5ATI = unchecked((uint)0x8946),

    [NativeName("GL_CON_6_ATI")]
    Con6ATI = unchecked((uint)0x8947),

    [NativeName("GL_CON_7_ATI")]
    Con7ATI = unchecked((uint)0x8948),

    [NativeName("GL_CON_8_ATI")]
    Con8ATI = unchecked((uint)0x8949),

    [NativeName("GL_CON_9_ATI")]
    Con9ATI = unchecked((uint)0x894A),

    [NativeName("GL_CON_10_ATI")]
    Con10ATI = unchecked((uint)0x894B),

    [NativeName("GL_CON_11_ATI")]
    Con11ATI = unchecked((uint)0x894C),

    [NativeName("GL_CON_12_ATI")]
    Con12ATI = unchecked((uint)0x894D),

    [NativeName("GL_CON_13_ATI")]
    Con13ATI = unchecked((uint)0x894E),

    [NativeName("GL_CON_14_ATI")]
    Con14ATI = unchecked((uint)0x894F),

    [NativeName("GL_CON_15_ATI")]
    Con15ATI = unchecked((uint)0x8950),

    [NativeName("GL_CON_16_ATI")]
    Con16ATI = unchecked((uint)0x8951),

    [NativeName("GL_CON_17_ATI")]
    Con17ATI = unchecked((uint)0x8952),

    [NativeName("GL_CON_18_ATI")]
    Con18ATI = unchecked((uint)0x8953),

    [NativeName("GL_CON_19_ATI")]
    Con19ATI = unchecked((uint)0x8954),

    [NativeName("GL_CON_20_ATI")]
    Con20ATI = unchecked((uint)0x8955),

    [NativeName("GL_CON_21_ATI")]
    Con21ATI = unchecked((uint)0x8956),

    [NativeName("GL_CON_22_ATI")]
    Con22ATI = unchecked((uint)0x8957),

    [NativeName("GL_CON_23_ATI")]
    Con23ATI = unchecked((uint)0x8958),

    [NativeName("GL_CON_24_ATI")]
    Con24ATI = unchecked((uint)0x8959),

    [NativeName("GL_CON_25_ATI")]
    Con25ATI = unchecked((uint)0x895A),

    [NativeName("GL_CON_26_ATI")]
    Con26ATI = unchecked((uint)0x895B),

    [NativeName("GL_CON_27_ATI")]
    Con27ATI = unchecked((uint)0x895C),

    [NativeName("GL_CON_28_ATI")]
    Con28ATI = unchecked((uint)0x895D),

    [NativeName("GL_CON_29_ATI")]
    Con29ATI = unchecked((uint)0x895E),

    [NativeName("GL_CON_30_ATI")]
    Con30ATI = unchecked((uint)0x895F),

    [NativeName("GL_CON_31_ATI")]
    Con31ATI = unchecked((uint)0x8960),

    [NativeName("GL_MOV_ATI")]
    MovATI = unchecked((uint)0x8961),

    [NativeName("GL_ADD_ATI")]
    AddATI = unchecked((uint)0x8963),

    [NativeName("GL_MUL_ATI")]
    MulATI = unchecked((uint)0x8964),

    [NativeName("GL_SUB_ATI")]
    SubATI = unchecked((uint)0x8965),

    [NativeName("GL_DOT3_ATI")]
    Dot3ATI = unchecked((uint)0x8966),

    [NativeName("GL_DOT4_ATI")]
    Dot4ATI = unchecked((uint)0x8967),

    [NativeName("GL_MAD_ATI")]
    MadATI = unchecked((uint)0x8968),

    [NativeName("GL_LERP_ATI")]
    LerpATI = unchecked((uint)0x8969),

    [NativeName("GL_CND_ATI")]
    CndATI = unchecked((uint)0x896A),

    [NativeName("GL_CND0_ATI")]
    Cnd0ATI = unchecked((uint)0x896B),

    [NativeName("GL_DOT2_ADD_ATI")]
    Dot2AddATI = unchecked((uint)0x896C),

    [NativeName("GL_SECONDARY_INTERPOLATOR_ATI")]
    SecondaryInterpolatorATI = unchecked((uint)0x896D),

    [NativeName("GL_NUM_FRAGMENT_REGISTERS_ATI")]
    NumFragmentRegistersATI = unchecked((uint)0x896E),

    [NativeName("GL_NUM_FRAGMENT_CONSTANTS_ATI")]
    NumFragmentConstantsATI = unchecked((uint)0x896F),

    [NativeName("GL_NUM_PASSES_ATI")]
    NumPassesATI = unchecked((uint)0x8970),

    [NativeName("GL_NUM_INSTRUCTIONS_PER_PASS_ATI")]
    NumInstructionsPerPassATI = unchecked((uint)0x8971),

    [NativeName("GL_NUM_INSTRUCTIONS_TOTAL_ATI")]
    NumInstructionsTotalATI = unchecked((uint)0x8972),

    [NativeName("GL_NUM_INPUT_INTERPOLATOR_COMPONENTS_ATI")]
    NumInputInterpolatorComponentsATI = unchecked((uint)0x8973),

    [NativeName("GL_NUM_LOOPBACK_COMPONENTS_ATI")]
    NumLoopbackComponentsATI = unchecked((uint)0x8974),

    [NativeName("GL_COLOR_ALPHA_PAIRING_ATI")]
    ColorAlphaPairingATI = unchecked((uint)0x8975),

    [NativeName("GL_SWIZZLE_STR_ATI")]
    SwizzleStrATI = unchecked((uint)0x8976),

    [NativeName("GL_SWIZZLE_STQ_ATI")]
    SwizzleStqATI = unchecked((uint)0x8977),

    [NativeName("GL_SWIZZLE_STR_DR_ATI")]
    SwizzleStrDrATI = unchecked((uint)0x8978),

    [NativeName("GL_SWIZZLE_STQ_DQ_ATI")]
    SwizzleStqDqATI = unchecked((uint)0x8979),

    [NativeName("GL_SWIZZLE_STRQ_ATI")]
    SwizzleStrqATI = unchecked((uint)0x897A),

    [NativeName("GL_SWIZZLE_STRQ_DQ_ATI")]
    SwizzleStrqDqATI = unchecked((uint)0x897B),

    [NativeName("GL_RED_BIT_ATI")]
    RedBitATI = unchecked((uint)0x00000001),

    [NativeName("GL_GREEN_BIT_ATI")]
    GreenBitATI = unchecked((uint)0x00000002),

    [NativeName("GL_BLUE_BIT_ATI")]
    BlueBitATI = unchecked((uint)0x00000004),

    [NativeName("GL_2X_BIT_ATI")]
    X2XBitATI = unchecked((uint)0x00000001),

    [NativeName("GL_4X_BIT_ATI")]
    X4XBitATI = unchecked((uint)0x00000002),

    [NativeName("GL_8X_BIT_ATI")]
    X8XBitATI = unchecked((uint)0x00000004),

    [NativeName("GL_HALF_BIT_ATI")]
    HalfBitATI = unchecked((uint)0x00000008),

    [NativeName("GL_QUARTER_BIT_ATI")]
    QuarterBitATI = unchecked((uint)0x00000010),

    [NativeName("GL_EIGHTH_BIT_ATI")]
    EighthBitATI = unchecked((uint)0x00000020),

    [NativeName("GL_SATURATE_BIT_ATI")]
    SaturateBitATI = unchecked((uint)0x00000040),

    [NativeName("GL_COMP_BIT_ATI")]
    CompBitATI = unchecked((uint)0x00000002),

    [NativeName("GL_NEGATE_BIT_ATI")]
    NegateBitATI = unchecked((uint)0x00000004),

    [NativeName("GL_BIAS_BIT_ATI")]
    BiasBitATI = unchecked((uint)0x00000008),

    [NativeName("GL_VBO_FREE_MEMORY_ATI")]
    VboFreeMemoryATI = unchecked((uint)0x87FB),

    [NativeName("GL_TEXTURE_FREE_MEMORY_ATI")]
    TextureFreeMemoryATI = unchecked((uint)0x87FC),

    [NativeName("GL_RENDERBUFFER_FREE_MEMORY_ATI")]
    RenderbufferFreeMemoryATI = unchecked((uint)0x87FD),

    [NativeName("GL_RGBA_FLOAT_MODE_ATI")]
    RgbaFloatModeATI = unchecked((uint)0x8820),

    [NativeName("GL_COLOR_CLEAR_UNCLAMPED_VALUE_ATI")]
    ColorClearUnclampedValueATI = unchecked((uint)0x8835),

    [NativeName("GL_PN_TRIANGLES_ATI")]
    PnTrianglesATI = unchecked((uint)0x87F0),

    [NativeName("GL_MAX_PN_TRIANGLES_TESSELATION_LEVEL_ATI")]
    MaxPnTrianglesTesselationLevelATI = unchecked((uint)0x87F1),

    [NativeName("GL_PN_TRIANGLES_POINT_MODE_ATI")]
    PnTrianglesPointModeATI = unchecked((uint)0x87F2),

    [NativeName("GL_PN_TRIANGLES_NORMAL_MODE_ATI")]
    PnTrianglesNormalModeATI = unchecked((uint)0x87F3),

    [NativeName("GL_PN_TRIANGLES_TESSELATION_LEVEL_ATI")]
    PnTrianglesTesselationLevelATI = unchecked((uint)0x87F4),

    [NativeName("GL_PN_TRIANGLES_POINT_MODE_LINEAR_ATI")]
    PnTrianglesPointModeLinearATI = unchecked((uint)0x87F5),

    [NativeName("GL_PN_TRIANGLES_POINT_MODE_CUBIC_ATI")]
    PnTrianglesPointModeCubicATI = unchecked((uint)0x87F6),

    [NativeName("GL_PN_TRIANGLES_NORMAL_MODE_LINEAR_ATI")]
    PnTrianglesNormalModeLinearATI = unchecked((uint)0x87F7),

    [NativeName("GL_PN_TRIANGLES_NORMAL_MODE_QUADRATIC_ATI")]
    PnTrianglesNormalModeQuadraticATI = unchecked((uint)0x87F8),

    [NativeName("GL_STENCIL_BACK_FUNC_ATI")]
    StencilBackFuncATI = unchecked((uint)0x8800),

    [NativeName("GL_STENCIL_BACK_FAIL_ATI")]
    StencilBackFailATI = unchecked((uint)0x8801),

    [NativeName("GL_STENCIL_BACK_PASS_DEPTH_FAIL_ATI")]
    StencilBackPassDepthFailATI = unchecked((uint)0x8802),

    [NativeName("GL_STENCIL_BACK_PASS_DEPTH_PASS_ATI")]
    StencilBackPassDepthPassATI = unchecked((uint)0x8803),

    [NativeName("GL_TEXT_FRAGMENT_SHADER_ATI")]
    TextFragmentShaderATI = unchecked((uint)0x8200),

    [NativeName("GL_MODULATE_ADD_ATI")]
    ModulateAddATI = unchecked((uint)0x8744),

    [NativeName("GL_MODULATE_SIGNED_ADD_ATI")]
    ModulateSignedAddATI = unchecked((uint)0x8745),

    [NativeName("GL_MODULATE_SUBTRACT_ATI")]
    ModulateSubtractATI = unchecked((uint)0x8746),

    [NativeName("GL_RGBA_FLOAT32_ATI")]
    RgbaFloat32ATI = unchecked((uint)0x8814),

    [NativeName("GL_RGB_FLOAT32_ATI")]
    RgbFloat32ATI = unchecked((uint)0x8815),

    [NativeName("GL_ALPHA_FLOAT32_ATI")]
    AlphaFloat32ATI = unchecked((uint)0x8816),

    [NativeName("GL_INTENSITY_FLOAT32_ATI")]
    IntensityFloat32ATI = unchecked((uint)0x8817),

    [NativeName("GL_LUMINANCE_FLOAT32_ATI")]
    LuminanceFloat32ATI = unchecked((uint)0x8818),

    [NativeName("GL_LUMINANCE_ALPHA_FLOAT32_ATI")]
    LuminanceAlphaFloat32ATI = unchecked((uint)0x8819),

    [NativeName("GL_RGBA_FLOAT16_ATI")]
    RgbaFloat16ATI = unchecked((uint)0x881A),

    [NativeName("GL_RGB_FLOAT16_ATI")]
    RgbFloat16ATI = unchecked((uint)0x881B),

    [NativeName("GL_ALPHA_FLOAT16_ATI")]
    AlphaFloat16ATI = unchecked((uint)0x881C),

    [NativeName("GL_INTENSITY_FLOAT16_ATI")]
    IntensityFloat16ATI = unchecked((uint)0x881D),

    [NativeName("GL_LUMINANCE_FLOAT16_ATI")]
    LuminanceFloat16ATI = unchecked((uint)0x881E),

    [NativeName("GL_LUMINANCE_ALPHA_FLOAT16_ATI")]
    LuminanceAlphaFloat16ATI = unchecked((uint)0x881F),

    [NativeName("GL_MIRROR_CLAMP_ATI")]
    MirrorClampATI = unchecked((uint)0x8742),

    [NativeName("GL_MIRROR_CLAMP_TO_EDGE_ATI")]
    MirrorClampToEdgeATI = unchecked((uint)0x8743),

    [NativeName("GL_STATIC_ATI")]
    StaticATI = unchecked((uint)0x8760),

    [NativeName("GL_DYNAMIC_ATI")]
    DynamicATI = unchecked((uint)0x8761),

    [NativeName("GL_PRESERVE_ATI")]
    PreserveATI = unchecked((uint)0x8762),

    [NativeName("GL_DISCARD_ATI")]
    DiscardATI = unchecked((uint)0x8763),

    [NativeName("GL_OBJECT_BUFFER_SIZE_ATI")]
    ObjectBufferSizeATI = unchecked((uint)0x8764),

    [NativeName("GL_OBJECT_BUFFER_USAGE_ATI")]
    ObjectBufferUsageATI = unchecked((uint)0x8765),

    [NativeName("GL_ARRAY_OBJECT_BUFFER_ATI")]
    ArrayObjectBufferATI = unchecked((uint)0x8766),

    [NativeName("GL_ARRAY_OBJECT_OFFSET_ATI")]
    ArrayObjectOffsetATI = unchecked((uint)0x8767),

    [NativeName("GL_MAX_VERTEX_STREAMS_ATI")]
    MaxVertexStreamsATI = unchecked((uint)0x876B),

    [NativeName("GL_VERTEX_STREAM0_ATI")]
    VertexStream0ATI = unchecked((uint)0x876C),

    [NativeName("GL_VERTEX_STREAM1_ATI")]
    VertexStream1ATI = unchecked((uint)0x876D),

    [NativeName("GL_VERTEX_STREAM2_ATI")]
    VertexStream2ATI = unchecked((uint)0x876E),

    [NativeName("GL_VERTEX_STREAM3_ATI")]
    VertexStream3ATI = unchecked((uint)0x876F),

    [NativeName("GL_VERTEX_STREAM4_ATI")]
    VertexStream4ATI = unchecked((uint)0x8770),

    [NativeName("GL_VERTEX_STREAM5_ATI")]
    VertexStream5ATI = unchecked((uint)0x8771),

    [NativeName("GL_VERTEX_STREAM6_ATI")]
    VertexStream6ATI = unchecked((uint)0x8772),

    [NativeName("GL_VERTEX_STREAM7_ATI")]
    VertexStream7ATI = unchecked((uint)0x8773),

    [NativeName("GL_VERTEX_SOURCE_ATI")]
    VertexSourceATI = unchecked((uint)0x8774),

    [NativeName("GL_422_EXT")]
    X422EXT = unchecked((uint)0x80CC),

    [NativeName("GL_422_REV_EXT")]
    X422RevEXT = unchecked((uint)0x80CD),

    [NativeName("GL_422_AVERAGE_EXT")]
    X422AverageEXT = unchecked((uint)0x80CE),

    [NativeName("GL_422_REV_AVERAGE_EXT")]
    X422RevAverageEXT = unchecked((uint)0x80CF),

    [NativeName("GL_ABGR_EXT")]
    AbgrEXT = unchecked((uint)0x8000),

    [NativeName("GL_BGR_EXT")]
    BgrEXT = unchecked((uint)0x80E0),

    [NativeName("GL_MAX_VERTEX_BINDABLE_UNIFORMS_EXT")]
    MaxVertexBindableUniformsEXT = unchecked((uint)0x8DE2),

    [NativeName("GL_MAX_FRAGMENT_BINDABLE_UNIFORMS_EXT")]
    MaxFragmentBindableUniformsEXT = unchecked((uint)0x8DE3),

    [NativeName("GL_MAX_GEOMETRY_BINDABLE_UNIFORMS_EXT")]
    MaxGeometryBindableUniformsEXT = unchecked((uint)0x8DE4),

    [NativeName("GL_MAX_BINDABLE_UNIFORM_SIZE_EXT")]
    MaxBindableUniformSizeEXT = unchecked((uint)0x8DED),

    [NativeName("GL_UNIFORM_BUFFER_EXT")]
    UniformBufferEXT = unchecked((uint)0x8DEE),

    [NativeName("GL_UNIFORM_BUFFER_BINDING_EXT")]
    UniformBufferBindingEXT = unchecked((uint)0x8DEF),

    [NativeName("GL_CONSTANT_COLOR_EXT")]
    ConstantColorEXT = unchecked((uint)0x8001),

    [NativeName("GL_ONE_MINUS_CONSTANT_COLOR_EXT")]
    OneMinusConstantColorEXT = unchecked((uint)0x8002),

    [NativeName("GL_CONSTANT_ALPHA_EXT")]
    ConstantAlphaEXT = unchecked((uint)0x8003),

    [NativeName("GL_ONE_MINUS_CONSTANT_ALPHA_EXT")]
    OneMinusConstantAlphaEXT = unchecked((uint)0x8004),

    [NativeName("GL_BLEND_COLOR_EXT")]
    BlendColorEXT = unchecked((uint)0x8005),

    [NativeName("GL_BLEND_EQUATION_RGB_EXT")]
    BlendEquationRgbEXT = unchecked((uint)0x8009),

    [NativeName("GL_BLEND_EQUATION_ALPHA_EXT")]
    BlendEquationAlphaEXT = unchecked((uint)0x883D),

    [NativeName("GL_BLEND_DST_RGB_EXT")]
    BlendDstRgbEXT = unchecked((uint)0x80C8),

    [NativeName("GL_BLEND_SRC_RGB_EXT")]
    BlendSrcRgbEXT = unchecked((uint)0x80C9),

    [NativeName("GL_BLEND_DST_ALPHA_EXT")]
    BlendDstAlphaEXT = unchecked((uint)0x80CA),

    [NativeName("GL_BLEND_SRC_ALPHA_EXT")]
    BlendSrcAlphaEXT = unchecked((uint)0x80CB),

    [NativeName("GL_FUNC_ADD_EXT")]
    FuncAddEXT = unchecked((uint)0x8006),

    [NativeName("GL_BLEND_EQUATION_EXT")]
    BlendEquationEXT = unchecked((uint)0x8009),

    [NativeName("GL_FUNC_SUBTRACT_EXT")]
    FuncSubtractEXT = unchecked((uint)0x800A),

    [NativeName("GL_FUNC_REVERSE_SUBTRACT_EXT")]
    FuncReverseSubtractEXT = unchecked((uint)0x800B),

    [NativeName("GL_CLIP_VOLUME_CLIPPING_HINT_EXT")]
    ClipVolumeClippingHintEXT = unchecked((uint)0x80F0),

    [NativeName("GL_CMYK_EXT")]
    CmykEXT = unchecked((uint)0x800C),

    [NativeName("GL_CMYKA_EXT")]
    CmykaEXT = unchecked((uint)0x800D),

    [NativeName("GL_PACK_CMYK_HINT_EXT")]
    PackCmykHintEXT = unchecked((uint)0x800E),

    [NativeName("GL_UNPACK_CMYK_HINT_EXT")]
    UnpackCmykHintEXT = unchecked((uint)0x800F),

    [NativeName("GL_ARRAY_ELEMENT_LOCK_FIRST_EXT")]
    ArrayElementLockFirstEXT = unchecked((uint)0x81A8),

    [NativeName("GL_ARRAY_ELEMENT_LOCK_COUNT_EXT")]
    ArrayElementLockCountEXT = unchecked((uint)0x81A9),

    [NativeName("GL_CONVOLUTION_1D_EXT")]
    Convolution1DEXT = unchecked((uint)0x8010),

    [NativeName("GL_CONVOLUTION_2D_EXT")]
    Convolution2DEXT = unchecked((uint)0x8011),

    [NativeName("GL_SEPARABLE_2D_EXT")]
    Separable2DEXT = unchecked((uint)0x8012),

    [NativeName("GL_CONVOLUTION_BORDER_MODE_EXT")]
    ConvolutionBorderModeEXT = unchecked((uint)0x8013),

    [NativeName("GL_CONVOLUTION_FILTER_SCALE_EXT")]
    ConvolutionFilterScaleEXT = unchecked((uint)0x8014),

    [NativeName("GL_CONVOLUTION_FILTER_BIAS_EXT")]
    ConvolutionFilterBiasEXT = unchecked((uint)0x8015),

    [NativeName("GL_REDUCE_EXT")]
    ReduceEXT = unchecked((uint)0x8016),

    [NativeName("GL_CONVOLUTION_FORMAT_EXT")]
    ConvolutionFormatEXT = unchecked((uint)0x8017),

    [NativeName("GL_CONVOLUTION_WIDTH_EXT")]
    ConvolutionWidthEXT = unchecked((uint)0x8018),

    [NativeName("GL_CONVOLUTION_HEIGHT_EXT")]
    ConvolutionHeightEXT = unchecked((uint)0x8019),

    [NativeName("GL_MAX_CONVOLUTION_WIDTH_EXT")]
    MaxConvolutionWidthEXT = unchecked((uint)0x801A),

    [NativeName("GL_MAX_CONVOLUTION_HEIGHT_EXT")]
    MaxConvolutionHeightEXT = unchecked((uint)0x801B),

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

    [NativeName("GL_TANGENT_ARRAY_EXT")]
    TangentArrayEXT = unchecked((uint)0x8439),

    [NativeName("GL_BINORMAL_ARRAY_EXT")]
    BinormalArrayEXT = unchecked((uint)0x843A),

    [NativeName("GL_CURRENT_TANGENT_EXT")]
    CurrentTangentEXT = unchecked((uint)0x843B),

    [NativeName("GL_CURRENT_BINORMAL_EXT")]
    CurrentBinormalEXT = unchecked((uint)0x843C),

    [NativeName("GL_TANGENT_ARRAY_TYPE_EXT")]
    TangentArrayTypeEXT = unchecked((uint)0x843E),

    [NativeName("GL_TANGENT_ARRAY_STRIDE_EXT")]
    TangentArrayStrideEXT = unchecked((uint)0x843F),

    [NativeName("GL_BINORMAL_ARRAY_TYPE_EXT")]
    BinormalArrayTypeEXT = unchecked((uint)0x8440),

    [NativeName("GL_BINORMAL_ARRAY_STRIDE_EXT")]
    BinormalArrayStrideEXT = unchecked((uint)0x8441),

    [NativeName("GL_TANGENT_ARRAY_POINTER_EXT")]
    TangentArrayPointerEXT = unchecked((uint)0x8442),

    [NativeName("GL_BINORMAL_ARRAY_POINTER_EXT")]
    BinormalArrayPointerEXT = unchecked((uint)0x8443),

    [NativeName("GL_MAP1_TANGENT_EXT")]
    Map1TangentEXT = unchecked((uint)0x8444),

    [NativeName("GL_MAP2_TANGENT_EXT")]
    Map2TangentEXT = unchecked((uint)0x8445),

    [NativeName("GL_MAP1_BINORMAL_EXT")]
    Map1BinormalEXT = unchecked((uint)0x8446),

    [NativeName("GL_MAP2_BINORMAL_EXT")]
    Map2BinormalEXT = unchecked((uint)0x8447),

    [NativeName("GL_CULL_VERTEX_EXT")]
    CullVertexEXT = unchecked((uint)0x81AA),

    [NativeName("GL_CULL_VERTEX_EYE_POSITION_EXT")]
    CullVertexEyePositionEXT = unchecked((uint)0x81AB),

    [NativeName("GL_CULL_VERTEX_OBJECT_POSITION_EXT")]
    CullVertexObjectPositionEXT = unchecked((uint)0x81AC),

    [NativeName("GL_PROGRAM_PIPELINE_OBJECT_EXT")]
    ProgramPipelineObjectEXT = unchecked((uint)0x8A4F),

    [NativeName("GL_PROGRAM_OBJECT_EXT")]
    ProgramObjectEXT = unchecked((uint)0x8B40),

    [NativeName("GL_SHADER_OBJECT_EXT")]
    ShaderObjectEXT = unchecked((uint)0x8B48),

    [NativeName("GL_BUFFER_OBJECT_EXT")]
    BufferObjectEXT = unchecked((uint)0x9151),

    [NativeName("GL_QUERY_OBJECT_EXT")]
    QueryObjectEXT = unchecked((uint)0x9153),

    [NativeName("GL_VERTEX_ARRAY_OBJECT_EXT")]
    VertexArrayObjectEXT = unchecked((uint)0x9154),

    [NativeName("GL_DEPTH_BOUNDS_TEST_EXT")]
    DepthBoundsTestEXT = unchecked((uint)0x8890),

    [NativeName("GL_DEPTH_BOUNDS_EXT")]
    DepthBoundsEXT = unchecked((uint)0x8891),

    [NativeName("GL_PROGRAM_MATRIX_EXT")]
    ProgramMatrixEXT = unchecked((uint)0x8E2D),

    [NativeName("GL_TRANSPOSE_PROGRAM_MATRIX_EXT")]
    TransposeProgramMatrixEXT = unchecked((uint)0x8E2E),

    [NativeName("GL_PROGRAM_MATRIX_STACK_DEPTH_EXT")]
    ProgramMatrixStackDepthEXT = unchecked((uint)0x8E2F),

    [NativeName("GL_MAX_ELEMENTS_VERTICES_EXT")]
    MaxElementsVerticesEXT = unchecked((uint)0x80E8),

    [NativeName("GL_MAX_ELEMENTS_INDICES_EXT")]
    MaxElementsIndicesEXT = unchecked((uint)0x80E9),

    [NativeName("GL_FOG_COORDINATE_SOURCE_EXT")]
    FogCoordinateSourceEXT = unchecked((uint)0x8450),

    [NativeName("GL_FOG_COORDINATE_EXT")]
    FogCoordinateEXT = unchecked((uint)0x8451),

    [NativeName("GL_FRAGMENT_DEPTH_EXT")]
    FragmentDepthEXT = unchecked((uint)0x8452),

    [NativeName("GL_CURRENT_FOG_COORDINATE_EXT")]
    CurrentFogCoordinateEXT = unchecked((uint)0x8453),

    [NativeName("GL_FOG_COORDINATE_ARRAY_TYPE_EXT")]
    FogCoordinateArrayTypeEXT = unchecked((uint)0x8454),

    [NativeName("GL_FOG_COORDINATE_ARRAY_STRIDE_EXT")]
    FogCoordinateArrayStrideEXT = unchecked((uint)0x8455),

    [NativeName("GL_FOG_COORDINATE_ARRAY_POINTER_EXT")]
    FogCoordinateArrayPointerEXT = unchecked((uint)0x8456),

    [NativeName("GL_FOG_COORDINATE_ARRAY_EXT")]
    FogCoordinateArrayEXT = unchecked((uint)0x8457),

    [NativeName("GL_READ_FRAMEBUFFER_EXT")]
    ReadFramebufferEXT = unchecked((uint)0x8CA8),

    [NativeName("GL_DRAW_FRAMEBUFFER_EXT")]
    DrawFramebufferEXT = unchecked((uint)0x8CA9),

    [NativeName("GL_DRAW_FRAMEBUFFER_BINDING_EXT")]
    DrawFramebufferBindingEXT = unchecked((uint)0x8CA6),

    [NativeName("GL_READ_FRAMEBUFFER_BINDING_EXT")]
    ReadFramebufferBindingEXT = unchecked((uint)0x8CAA),

    [NativeName("GL_SCALED_RESOLVE_FASTEST_EXT")]
    ScaledResolveFastestEXT = unchecked((uint)0x90BA),

    [NativeName("GL_SCALED_RESOLVE_NICEST_EXT")]
    ScaledResolveNicestEXT = unchecked((uint)0x90BB),

    [NativeName("GL_INVALID_FRAMEBUFFER_OPERATION_EXT")]
    InvalidFramebufferOperationEXT = unchecked((uint)0x0506),

    [NativeName("GL_MAX_RENDERBUFFER_SIZE_EXT")]
    MaxRenderbufferSizeEXT = unchecked((uint)0x84E8),

    [NativeName("GL_FRAMEBUFFER_BINDING_EXT")]
    FramebufferBindingEXT = unchecked((uint)0x8CA6),

    [NativeName("GL_RENDERBUFFER_BINDING_EXT")]
    RenderbufferBindingEXT = unchecked((uint)0x8CA7),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_EXT")]
    FramebufferAttachmentObjectTypeEXT = unchecked((uint)0x8CD0),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_EXT")]
    FramebufferAttachmentObjectNameEXT = unchecked((uint)0x8CD1),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_EXT")]
    FramebufferAttachmentTextureLevelEXT = unchecked((uint)0x8CD2),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_EXT")]
    FramebufferAttachmentTextureCubeMapFaceEXT = unchecked((uint)0x8CD3),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_EXT")]
    FramebufferAttachmentTexture3DZoffsetEXT = unchecked((uint)0x8CD4),

    [NativeName("GL_FRAMEBUFFER_COMPLETE_EXT")]
    FramebufferCompleteEXT = unchecked((uint)0x8CD5),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_EXT")]
    FramebufferIncompleteAttachmentEXT = unchecked((uint)0x8CD6),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_EXT")]
    FramebufferIncompleteMissingAttachmentEXT = unchecked((uint)0x8CD7),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_EXT")]
    FramebufferIncompleteDimensionsEXT = unchecked((uint)0x8CD9),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_FORMATS_EXT")]
    FramebufferIncompleteFormatsEXT = unchecked((uint)0x8CDA),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER_EXT")]
    FramebufferIncompleteDrawBufferEXT = unchecked((uint)0x8CDB),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER_EXT")]
    FramebufferIncompleteReadBufferEXT = unchecked((uint)0x8CDC),

    [NativeName("GL_FRAMEBUFFER_UNSUPPORTED_EXT")]
    FramebufferUnsupportedEXT = unchecked((uint)0x8CDD),

    [NativeName("GL_MAX_COLOR_ATTACHMENTS_EXT")]
    MaxColorAttachmentsEXT = unchecked((uint)0x8CDF),

    [NativeName("GL_COLOR_ATTACHMENT0_EXT")]
    ColorAttachment0EXT = unchecked((uint)0x8CE0),

    [NativeName("GL_COLOR_ATTACHMENT1_EXT")]
    ColorAttachment1EXT = unchecked((uint)0x8CE1),

    [NativeName("GL_COLOR_ATTACHMENT2_EXT")]
    ColorAttachment2EXT = unchecked((uint)0x8CE2),

    [NativeName("GL_COLOR_ATTACHMENT3_EXT")]
    ColorAttachment3EXT = unchecked((uint)0x8CE3),

    [NativeName("GL_COLOR_ATTACHMENT4_EXT")]
    ColorAttachment4EXT = unchecked((uint)0x8CE4),

    [NativeName("GL_COLOR_ATTACHMENT5_EXT")]
    ColorAttachment5EXT = unchecked((uint)0x8CE5),

    [NativeName("GL_COLOR_ATTACHMENT6_EXT")]
    ColorAttachment6EXT = unchecked((uint)0x8CE6),

    [NativeName("GL_COLOR_ATTACHMENT7_EXT")]
    ColorAttachment7EXT = unchecked((uint)0x8CE7),

    [NativeName("GL_COLOR_ATTACHMENT8_EXT")]
    ColorAttachment8EXT = unchecked((uint)0x8CE8),

    [NativeName("GL_COLOR_ATTACHMENT9_EXT")]
    ColorAttachment9EXT = unchecked((uint)0x8CE9),

    [NativeName("GL_COLOR_ATTACHMENT10_EXT")]
    ColorAttachment10EXT = unchecked((uint)0x8CEA),

    [NativeName("GL_COLOR_ATTACHMENT11_EXT")]
    ColorAttachment11EXT = unchecked((uint)0x8CEB),

    [NativeName("GL_COLOR_ATTACHMENT12_EXT")]
    ColorAttachment12EXT = unchecked((uint)0x8CEC),

    [NativeName("GL_COLOR_ATTACHMENT13_EXT")]
    ColorAttachment13EXT = unchecked((uint)0x8CED),

    [NativeName("GL_COLOR_ATTACHMENT14_EXT")]
    ColorAttachment14EXT = unchecked((uint)0x8CEE),

    [NativeName("GL_COLOR_ATTACHMENT15_EXT")]
    ColorAttachment15EXT = unchecked((uint)0x8CEF),

    [NativeName("GL_DEPTH_ATTACHMENT_EXT")]
    DepthAttachmentEXT = unchecked((uint)0x8D00),

    [NativeName("GL_STENCIL_ATTACHMENT_EXT")]
    StencilAttachmentEXT = unchecked((uint)0x8D20),

    [NativeName("GL_FRAMEBUFFER_EXT")]
    FramebufferEXT = unchecked((uint)0x8D40),

    [NativeName("GL_RENDERBUFFER_EXT")]
    RenderbufferEXT = unchecked((uint)0x8D41),

    [NativeName("GL_RENDERBUFFER_WIDTH_EXT")]
    RenderbufferWidthEXT = unchecked((uint)0x8D42),

    [NativeName("GL_RENDERBUFFER_HEIGHT_EXT")]
    RenderbufferHeightEXT = unchecked((uint)0x8D43),

    [NativeName("GL_RENDERBUFFER_INTERNAL_FORMAT_EXT")]
    RenderbufferInternalFormatEXT = unchecked((uint)0x8D44),

    [NativeName("GL_STENCIL_INDEX1_EXT")]
    StencilIndex1EXT = unchecked((uint)0x8D46),

    [NativeName("GL_STENCIL_INDEX4_EXT")]
    StencilIndex4EXT = unchecked((uint)0x8D47),

    [NativeName("GL_STENCIL_INDEX8_EXT")]
    StencilIndex8EXT = unchecked((uint)0x8D48),

    [NativeName("GL_STENCIL_INDEX16_EXT")]
    StencilIndex16EXT = unchecked((uint)0x8D49),

    [NativeName("GL_RENDERBUFFER_RED_SIZE_EXT")]
    RenderbufferRedSizeEXT = unchecked((uint)0x8D50),

    [NativeName("GL_RENDERBUFFER_GREEN_SIZE_EXT")]
    RenderbufferGreenSizeEXT = unchecked((uint)0x8D51),

    [NativeName("GL_RENDERBUFFER_BLUE_SIZE_EXT")]
    RenderbufferBlueSizeEXT = unchecked((uint)0x8D52),

    [NativeName("GL_RENDERBUFFER_ALPHA_SIZE_EXT")]
    RenderbufferAlphaSizeEXT = unchecked((uint)0x8D53),

    [NativeName("GL_RENDERBUFFER_DEPTH_SIZE_EXT")]
    RenderbufferDepthSizeEXT = unchecked((uint)0x8D54),

    [NativeName("GL_RENDERBUFFER_STENCIL_SIZE_EXT")]
    RenderbufferStencilSizeEXT = unchecked((uint)0x8D55),

    [NativeName("GL_FRAMEBUFFER_SRGB_EXT")]
    FramebufferSrgbEXT = unchecked((uint)0x8DB9),

    [NativeName("GL_FRAMEBUFFER_SRGB_CAPABLE_EXT")]
    FramebufferSrgbCapableEXT = unchecked((uint)0x8DBA),

    [NativeName("GL_GEOMETRY_SHADER_EXT")]
    GeometryShaderEXT = unchecked((uint)0x8DD9),

    [NativeName("GL_GEOMETRY_VERTICES_OUT_EXT")]
    GeometryVerticesOutEXT = unchecked((uint)0x8DDA),

    [NativeName("GL_GEOMETRY_INPUT_TYPE_EXT")]
    GeometryInputTypeEXT = unchecked((uint)0x8DDB),

    [NativeName("GL_GEOMETRY_OUTPUT_TYPE_EXT")]
    GeometryOutputTypeEXT = unchecked((uint)0x8DDC),

    [NativeName("GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_EXT")]
    MaxGeometryTextureImageUnitsEXT = unchecked((uint)0x8C29),

    [NativeName("GL_MAX_GEOMETRY_VARYING_COMPONENTS_EXT")]
    MaxGeometryVaryingComponentsEXT = unchecked((uint)0x8DDD),

    [NativeName("GL_MAX_VERTEX_VARYING_COMPONENTS_EXT")]
    MaxVertexVaryingComponentsEXT = unchecked((uint)0x8DDE),

    [NativeName("GL_MAX_VARYING_COMPONENTS_EXT")]
    MaxVaryingComponentsEXT = unchecked((uint)0x8B4B),

    [NativeName("GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_EXT")]
    MaxGeometryUniformComponentsEXT = unchecked((uint)0x8DDF),

    [NativeName("GL_MAX_GEOMETRY_OUTPUT_VERTICES_EXT")]
    MaxGeometryOutputVerticesEXT = unchecked((uint)0x8DE0),

    [NativeName("GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_EXT")]
    MaxGeometryTotalOutputComponentsEXT = unchecked((uint)0x8DE1),

    [NativeName("GL_LINES_ADJACENCY_EXT")]
    LinesAdjacencyEXT = unchecked((uint)0x000A),

    [NativeName("GL_LINE_STRIP_ADJACENCY_EXT")]
    LineStripAdjacencyEXT = unchecked((uint)0x000B),

    [NativeName("GL_TRIANGLES_ADJACENCY_EXT")]
    TrianglesAdjacencyEXT = unchecked((uint)0x000C),

    [NativeName("GL_TRIANGLE_STRIP_ADJACENCY_EXT")]
    TriangleStripAdjacencyEXT = unchecked((uint)0x000D),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_EXT")]
    FramebufferIncompleteLayerTargetsEXT = unchecked((uint)0x8DA8),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_EXT")]
    FramebufferIncompleteLayerCountEXT = unchecked((uint)0x8DA9),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_LAYERED_EXT")]
    FramebufferAttachmentLayeredEXT = unchecked((uint)0x8DA7),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER_EXT")]
    FramebufferAttachmentTextureLayerEXT = unchecked((uint)0x8CD4),

    [NativeName("GL_PROGRAM_POINT_SIZE_EXT")]
    ProgramPointSizeEXT = unchecked((uint)0x8642),

    [NativeName("GL_SAMPLER_1D_ARRAY_EXT")]
    Sampler1DArrayEXT = unchecked((uint)0x8DC0),

    [NativeName("GL_SAMPLER_2D_ARRAY_EXT")]
    Sampler2DArrayEXT = unchecked((uint)0x8DC1),

    [NativeName("GL_SAMPLER_BUFFER_EXT")]
    SamplerBufferEXT = unchecked((uint)0x8DC2),

    [NativeName("GL_SAMPLER_1D_ARRAY_SHADOW_EXT")]
    Sampler1DArrayShadowEXT = unchecked((uint)0x8DC3),

    [NativeName("GL_SAMPLER_2D_ARRAY_SHADOW_EXT")]
    Sampler2DArrayShadowEXT = unchecked((uint)0x8DC4),

    [NativeName("GL_SAMPLER_CUBE_SHADOW_EXT")]
    SamplerCubeShadowEXT = unchecked((uint)0x8DC5),

    [NativeName("GL_UNSIGNED_INT_VEC2_EXT")]
    UnsignedIntVec2EXT = unchecked((uint)0x8DC6),

    [NativeName("GL_UNSIGNED_INT_VEC3_EXT")]
    UnsignedIntVec3EXT = unchecked((uint)0x8DC7),

    [NativeName("GL_UNSIGNED_INT_VEC4_EXT")]
    UnsignedIntVec4EXT = unchecked((uint)0x8DC8),

    [NativeName("GL_INT_SAMPLER_1D_EXT")]
    IntSampler1DEXT = unchecked((uint)0x8DC9),

    [NativeName("GL_INT_SAMPLER_2D_EXT")]
    IntSampler2DEXT = unchecked((uint)0x8DCA),

    [NativeName("GL_INT_SAMPLER_3D_EXT")]
    IntSampler3DEXT = unchecked((uint)0x8DCB),

    [NativeName("GL_INT_SAMPLER_CUBE_EXT")]
    IntSamplerCubeEXT = unchecked((uint)0x8DCC),

    [NativeName("GL_INT_SAMPLER_2D_RECT_EXT")]
    IntSampler2DRectEXT = unchecked((uint)0x8DCD),

    [NativeName("GL_INT_SAMPLER_1D_ARRAY_EXT")]
    IntSampler1DArrayEXT = unchecked((uint)0x8DCE),

    [NativeName("GL_INT_SAMPLER_2D_ARRAY_EXT")]
    IntSampler2DArrayEXT = unchecked((uint)0x8DCF),

    [NativeName("GL_INT_SAMPLER_BUFFER_EXT")]
    IntSamplerBufferEXT = unchecked((uint)0x8DD0),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_1D_EXT")]
    UnsignedIntSampler1DEXT = unchecked((uint)0x8DD1),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_2D_EXT")]
    UnsignedIntSampler2DEXT = unchecked((uint)0x8DD2),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_3D_EXT")]
    UnsignedIntSampler3DEXT = unchecked((uint)0x8DD3),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_CUBE_EXT")]
    UnsignedIntSamplerCubeEXT = unchecked((uint)0x8DD4),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_2D_RECT_EXT")]
    UnsignedIntSampler2DRectEXT = unchecked((uint)0x8DD5),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_1D_ARRAY_EXT")]
    UnsignedIntSampler1DArrayEXT = unchecked((uint)0x8DD6),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_2D_ARRAY_EXT")]
    UnsignedIntSampler2DArrayEXT = unchecked((uint)0x8DD7),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_BUFFER_EXT")]
    UnsignedIntSamplerBufferEXT = unchecked((uint)0x8DD8),

    [NativeName("GL_MIN_PROGRAM_TEXEL_OFFSET_EXT")]
    MinProgramTexelOffsetEXT = unchecked((uint)0x8904),

    [NativeName("GL_MAX_PROGRAM_TEXEL_OFFSET_EXT")]
    MaxProgramTexelOffsetEXT = unchecked((uint)0x8905),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_INTEGER_EXT")]
    VertexAttribArrayIntegerEXT = unchecked((uint)0x88FD),

    [NativeName("GL_HISTOGRAM_EXT")]
    HistogramEXT = unchecked((uint)0x8024),

    [NativeName("GL_PROXY_HISTOGRAM_EXT")]
    ProxyHistogramEXT = unchecked((uint)0x8025),

    [NativeName("GL_HISTOGRAM_WIDTH_EXT")]
    HistogramWidthEXT = unchecked((uint)0x8026),

    [NativeName("GL_HISTOGRAM_FORMAT_EXT")]
    HistogramFormatEXT = unchecked((uint)0x8027),

    [NativeName("GL_HISTOGRAM_RED_SIZE_EXT")]
    HistogramRedSizeEXT = unchecked((uint)0x8028),

    [NativeName("GL_HISTOGRAM_GREEN_SIZE_EXT")]
    HistogramGreenSizeEXT = unchecked((uint)0x8029),

    [NativeName("GL_HISTOGRAM_BLUE_SIZE_EXT")]
    HistogramBlueSizeEXT = unchecked((uint)0x802A),

    [NativeName("GL_HISTOGRAM_ALPHA_SIZE_EXT")]
    HistogramAlphaSizeEXT = unchecked((uint)0x802B),

    [NativeName("GL_HISTOGRAM_LUMINANCE_SIZE_EXT")]
    HistogramLuminanceSizeEXT = unchecked((uint)0x802C),

    [NativeName("GL_HISTOGRAM_SINK_EXT")]
    HistogramSinkEXT = unchecked((uint)0x802D),

    [NativeName("GL_MINMAX_EXT")]
    MinmaxEXT = unchecked((uint)0x802E),

    [NativeName("GL_MINMAX_FORMAT_EXT")]
    MinmaxFormatEXT = unchecked((uint)0x802F),

    [NativeName("GL_MINMAX_SINK_EXT")]
    MinmaxSinkEXT = unchecked((uint)0x8030),

    [NativeName("GL_TABLE_TOO_LARGE_EXT")]
    TableTooLargeEXT = unchecked((uint)0x8031),

    [NativeName("GL_IUI_V2F_EXT")]
    IuiV2FEXT = unchecked((uint)0x81AD),

    [NativeName("GL_IUI_V3F_EXT")]
    IuiV3FEXT = unchecked((uint)0x81AE),

    [NativeName("GL_IUI_N3F_V2F_EXT")]
    IuiN3FV2FEXT = unchecked((uint)0x81AF),

    [NativeName("GL_IUI_N3F_V3F_EXT")]
    IuiN3FV3FEXT = unchecked((uint)0x81B0),

    [NativeName("GL_T2F_IUI_V2F_EXT")]
    T2FIuiV2FEXT = unchecked((uint)0x81B1),

    [NativeName("GL_T2F_IUI_V3F_EXT")]
    T2FIuiV3FEXT = unchecked((uint)0x81B2),

    [NativeName("GL_T2F_IUI_N3F_V2F_EXT")]
    T2FIuiN3FV2FEXT = unchecked((uint)0x81B3),

    [NativeName("GL_T2F_IUI_N3F_V3F_EXT")]
    T2FIuiN3FV3FEXT = unchecked((uint)0x81B4),

    [NativeName("GL_INDEX_TEST_EXT")]
    IndexTestEXT = unchecked((uint)0x81B5),

    [NativeName("GL_INDEX_TEST_FUNC_EXT")]
    IndexTestFuncEXT = unchecked((uint)0x81B6),

    [NativeName("GL_INDEX_TEST_REF_EXT")]
    IndexTestRefEXT = unchecked((uint)0x81B7),

    [NativeName("GL_INDEX_MATERIAL_EXT")]
    IndexMaterialEXT = unchecked((uint)0x81B8),

    [NativeName("GL_INDEX_MATERIAL_PARAMETER_EXT")]
    IndexMaterialParameterEXT = unchecked((uint)0x81B9),

    [NativeName("GL_INDEX_MATERIAL_FACE_EXT")]
    IndexMaterialFaceEXT = unchecked((uint)0x81BA),

    [NativeName("GL_FRAGMENT_MATERIAL_EXT")]
    FragmentMaterialEXT = unchecked((uint)0x8349),

    [NativeName("GL_FRAGMENT_NORMAL_EXT")]
    FragmentNormalEXT = unchecked((uint)0x834A),

    [NativeName("GL_FRAGMENT_COLOR_EXT")]
    FragmentColorEXT = unchecked((uint)0x834C),

    [NativeName("GL_ATTENUATION_EXT")]
    AttenuationEXT = unchecked((uint)0x834D),

    [NativeName("GL_SHADOW_ATTENUATION_EXT")]
    ShadowAttenuationEXT = unchecked((uint)0x834E),

    [NativeName("GL_TEXTURE_APPLICATION_MODE_EXT")]
    TextureApplicationModeEXT = unchecked((uint)0x834F),

    [NativeName("GL_TEXTURE_LIGHT_EXT")]
    TextureLightEXT = unchecked((uint)0x8350),

    [NativeName("GL_TEXTURE_MATERIAL_FACE_EXT")]
    TextureMaterialFaceEXT = unchecked((uint)0x8351),

    [NativeName("GL_TEXTURE_MATERIAL_PARAMETER_EXT")]
    TextureMaterialParameterEXT = unchecked((uint)0x8352),

    [NativeName("GL_TEXTURE_TILING_EXT")]
    TextureTilingEXT = unchecked((uint)0x9580),

    [NativeName("GL_DEDICATED_MEMORY_OBJECT_EXT")]
    DedicatedMemoryObjectEXT = unchecked((uint)0x9581),

    [NativeName("GL_PROTECTED_MEMORY_OBJECT_EXT")]
    ProtectedMemoryObjectEXT = unchecked((uint)0x959B),

    [NativeName("GL_NUM_TILING_TYPES_EXT")]
    NumTilingTypesEXT = unchecked((uint)0x9582),

    [NativeName("GL_TILING_TYPES_EXT")]
    TilingTypesEXT = unchecked((uint)0x9583),

    [NativeName("GL_OPTIMAL_TILING_EXT")]
    OptimalTilingEXT = unchecked((uint)0x9584),

    [NativeName("GL_LINEAR_TILING_EXT")]
    LinearTilingEXT = unchecked((uint)0x9585),

    [NativeName("GL_NUM_DEVICE_UUIDS_EXT")]
    NumDeviceUuidsEXT = unchecked((uint)0x9596),

    [NativeName("GL_DEVICE_UUID_EXT")]
    DeviceUuidEXT = unchecked((uint)0x9597),

    [NativeName("GL_DRIVER_UUID_EXT")]
    DriverUuidEXT = unchecked((uint)0x9598),

    [NativeName("GL_UUID_SIZE_EXT")]
    UuidSizeEXT = unchecked((uint)16),

    [NativeName("GL_HANDLE_TYPE_OPAQUE_FD_EXT")]
    HandleTypeOpaqueFdEXT = unchecked((uint)0x9586),

    [NativeName("GL_HANDLE_TYPE_OPAQUE_WIN32_EXT")]
    HandleTypeOpaqueWin32EXT = unchecked((uint)0x9587),

    [NativeName("GL_HANDLE_TYPE_OPAQUE_WIN32_KMT_EXT")]
    HandleTypeOpaqueWin32KmtEXT = unchecked((uint)0x9588),

    [NativeName("GL_DEVICE_LUID_EXT")]
    DeviceLuidEXT = unchecked((uint)0x9599),

    [NativeName("GL_DEVICE_NODE_MASK_EXT")]
    DeviceNodeMaskEXT = unchecked((uint)0x959A),

    [NativeName("GL_LUID_SIZE_EXT")]
    LuidSizeEXT = unchecked((uint)8),

    [NativeName("GL_HANDLE_TYPE_D3D12_TILEPOOL_EXT")]
    HandleTypeD3D12TilepoolEXT = unchecked((uint)0x9589),

    [NativeName("GL_HANDLE_TYPE_D3D12_RESOURCE_EXT")]
    HandleTypeD3D12ResourceEXT = unchecked((uint)0x958A),

    [NativeName("GL_HANDLE_TYPE_D3D11_IMAGE_EXT")]
    HandleTypeD3D11ImageEXT = unchecked((uint)0x958B),

    [NativeName("GL_HANDLE_TYPE_D3D11_IMAGE_KMT_EXT")]
    HandleTypeD3D11ImageKmtEXT = unchecked((uint)0x958C),

    [NativeName("GL_MULTISAMPLE_EXT")]
    MultisampleEXT = unchecked((uint)0x809D),

    [NativeName("GL_SAMPLE_ALPHA_TO_MASK_EXT")]
    SampleAlphaToMaskEXT = unchecked((uint)0x809E),

    [NativeName("GL_SAMPLE_ALPHA_TO_ONE_EXT")]
    SampleAlphaToOneEXT = unchecked((uint)0x809F),

    [NativeName("GL_SAMPLE_MASK_EXT")]
    SampleMaskEXT = unchecked((uint)0x80A0),

    [NativeName("GL_1PASS_EXT")]
    X1PassEXT = unchecked((uint)0x80A1),

    [NativeName("GL_2PASS_0_EXT")]
    X2Pass0EXT = unchecked((uint)0x80A2),

    [NativeName("GL_2PASS_1_EXT")]
    X2Pass1EXT = unchecked((uint)0x80A3),

    [NativeName("GL_4PASS_0_EXT")]
    X4Pass0EXT = unchecked((uint)0x80A4),

    [NativeName("GL_4PASS_1_EXT")]
    X4Pass1EXT = unchecked((uint)0x80A5),

    [NativeName("GL_4PASS_2_EXT")]
    X4Pass2EXT = unchecked((uint)0x80A6),

    [NativeName("GL_4PASS_3_EXT")]
    X4Pass3EXT = unchecked((uint)0x80A7),

    [NativeName("GL_SAMPLE_BUFFERS_EXT")]
    SampleBuffersEXT = unchecked((uint)0x80A8),

    [NativeName("GL_SAMPLES_EXT")]
    SamplesEXT = unchecked((uint)0x80A9),

    [NativeName("GL_SAMPLE_MASK_VALUE_EXT")]
    SampleMaskValueEXT = unchecked((uint)0x80AA),

    [NativeName("GL_SAMPLE_MASK_INVERT_EXT")]
    SampleMaskInvertEXT = unchecked((uint)0x80AB),

    [NativeName("GL_SAMPLE_PATTERN_EXT")]
    SamplePatternEXT = unchecked((uint)0x80AC),

    [NativeName("GL_MULTISAMPLE_BIT_EXT")]
    MultisampleBitEXT = unchecked((uint)0x20000000),

    [NativeName("GL_DEPTH_STENCIL_EXT")]
    DepthStencilEXT = unchecked((uint)0x84F9),

    [NativeName("GL_UNSIGNED_INT_24_8_EXT")]
    UnsignedInt24X8EXT = unchecked((uint)0x84FA),

    [NativeName("GL_DEPTH24_STENCIL8_EXT")]
    Depth24Stencil8EXT = unchecked((uint)0x88F0),

    [NativeName("GL_TEXTURE_STENCIL_SIZE_EXT")]
    TextureStencilSizeEXT = unchecked((uint)0x88F1),

    [NativeName("GL_R11F_G11F_B10F_EXT")]
    R11FG11FB10FEXT = unchecked((uint)0x8C3A),

    [NativeName("GL_UNSIGNED_INT_10F_11F_11F_REV_EXT")]
    UnsignedInt10F11F11FRevEXT = unchecked((uint)0x8C3B),

    [NativeName("GL_RGBA_SIGNED_COMPONENTS_EXT")]
    RgbaSignedComponentsEXT = unchecked((uint)0x8C3C),

    [NativeName("GL_UNSIGNED_BYTE_3_3_2_EXT")]
    UnsignedByte3X3X2EXT = unchecked((uint)0x8032),

    [NativeName("GL_UNSIGNED_SHORT_4_4_4_4_EXT")]
    UnsignedShort4X4X4X4EXT = unchecked((uint)0x8033),

    [NativeName("GL_UNSIGNED_SHORT_5_5_5_1_EXT")]
    UnsignedShort5X5X5X1EXT = unchecked((uint)0x8034),

    [NativeName("GL_UNSIGNED_INT_8_8_8_8_EXT")]
    UnsignedInt8X8X8X8EXT = unchecked((uint)0x8035),

    [NativeName("GL_UNSIGNED_INT_10_10_10_2_EXT")]
    UnsignedInt10X10X10X2EXT = unchecked((uint)0x8036),

    [NativeName("GL_COLOR_INDEX1_EXT")]
    ColorIndex1EXT = unchecked((uint)0x80E2),

    [NativeName("GL_COLOR_INDEX2_EXT")]
    ColorIndex2EXT = unchecked((uint)0x80E3),

    [NativeName("GL_COLOR_INDEX4_EXT")]
    ColorIndex4EXT = unchecked((uint)0x80E4),

    [NativeName("GL_COLOR_INDEX8_EXT")]
    ColorIndex8EXT = unchecked((uint)0x80E5),

    [NativeName("GL_COLOR_INDEX12_EXT")]
    ColorIndex12EXT = unchecked((uint)0x80E6),

    [NativeName("GL_COLOR_INDEX16_EXT")]
    ColorIndex16EXT = unchecked((uint)0x80E7),

    [NativeName("GL_TEXTURE_INDEX_SIZE_EXT")]
    TextureIndexSizeEXT = unchecked((uint)0x80ED),

    [NativeName("GL_PIXEL_PACK_BUFFER_EXT")]
    PixelPackBufferEXT = unchecked((uint)0x88EB),

    [NativeName("GL_PIXEL_UNPACK_BUFFER_EXT")]
    PixelUnpackBufferEXT = unchecked((uint)0x88EC),

    [NativeName("GL_PIXEL_PACK_BUFFER_BINDING_EXT")]
    PixelPackBufferBindingEXT = unchecked((uint)0x88ED),

    [NativeName("GL_PIXEL_UNPACK_BUFFER_BINDING_EXT")]
    PixelUnpackBufferBindingEXT = unchecked((uint)0x88EF),

    [NativeName("GL_PIXEL_TRANSFORM_2D_EXT")]
    PixelTransform2DEXT = unchecked((uint)0x8330),

    [NativeName("GL_PIXEL_MAG_FILTER_EXT")]
    PixelMagFilterEXT = unchecked((uint)0x8331),

    [NativeName("GL_PIXEL_MIN_FILTER_EXT")]
    PixelMinFilterEXT = unchecked((uint)0x8332),

    [NativeName("GL_PIXEL_CUBIC_WEIGHT_EXT")]
    PixelCubicWeightEXT = unchecked((uint)0x8333),

    [NativeName("GL_CUBIC_EXT")]
    CubicEXT = unchecked((uint)0x8334),

    [NativeName("GL_AVERAGE_EXT")]
    AverageEXT = unchecked((uint)0x8335),

    [NativeName("GL_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT")]
    PixelTransform2DStackDepthEXT = unchecked((uint)0x8336),

    [NativeName("GL_MAX_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT")]
    MaxPixelTransform2DStackDepthEXT = unchecked((uint)0x8337),

    [NativeName("GL_PIXEL_TRANSFORM_2D_MATRIX_EXT")]
    PixelTransform2DMatrixEXT = unchecked((uint)0x8338),

    [NativeName("GL_POINT_SIZE_MIN_EXT")]
    PointSizeMinEXT = unchecked((uint)0x8126),

    [NativeName("GL_POINT_SIZE_MAX_EXT")]
    PointSizeMaxEXT = unchecked((uint)0x8127),

    [NativeName("GL_POINT_FADE_THRESHOLD_SIZE_EXT")]
    PointFadeThresholdSizeEXT = unchecked((uint)0x8128),

    [NativeName("GL_DISTANCE_ATTENUATION_EXT")]
    DistanceAttenuationEXT = unchecked((uint)0x8129),

    [NativeName("GL_POLYGON_OFFSET_EXT")]
    PolygonOffsetEXT = unchecked((uint)0x8037),

    [NativeName("GL_POLYGON_OFFSET_FACTOR_EXT")]
    PolygonOffsetFactorEXT = unchecked((uint)0x8038),

    [NativeName("GL_POLYGON_OFFSET_BIAS_EXT")]
    PolygonOffsetBiasEXT = unchecked((uint)0x8039),

    [NativeName("GL_POLYGON_OFFSET_CLAMP_EXT")]
    PolygonOffsetClampEXT = unchecked((uint)0x8E1B),

    [NativeName("GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION_EXT")]
    QuadsFollowProvokingVertexConventionEXT = unchecked((uint)0x8E4C),

    [NativeName("GL_FIRST_VERTEX_CONVENTION_EXT")]
    FirstVertexConventionEXT = unchecked((uint)0x8E4D),

    [NativeName("GL_LAST_VERTEX_CONVENTION_EXT")]
    LastVertexConventionEXT = unchecked((uint)0x8E4E),

    [NativeName("GL_PROVOKING_VERTEX_EXT")]
    ProvokingVertexEXT = unchecked((uint)0x8E4F),

    [NativeName("GL_RASTER_MULTISAMPLE_EXT")]
    RasterMultisampleEXT = unchecked((uint)0x9327),

    [NativeName("GL_RASTER_SAMPLES_EXT")]
    RasterSamplesEXT = unchecked((uint)0x9328),

    [NativeName("GL_MAX_RASTER_SAMPLES_EXT")]
    MaxRasterSamplesEXT = unchecked((uint)0x9329),

    [NativeName("GL_RASTER_FIXED_SAMPLE_LOCATIONS_EXT")]
    RasterFixedSampleLocationsEXT = unchecked((uint)0x932A),

    [NativeName("GL_MULTISAMPLE_RASTERIZATION_ALLOWED_EXT")]
    MultisampleRasterizationAllowedEXT = unchecked((uint)0x932B),

    [NativeName("GL_EFFECTIVE_RASTER_SAMPLES_EXT")]
    EffectiveRasterSamplesEXT = unchecked((uint)0x932C),

    [NativeName("GL_RESCALE_NORMAL_EXT")]
    RescaleNormalEXT = unchecked((uint)0x803A),

    [NativeName("GL_COLOR_SUM_EXT")]
    ColorSumEXT = unchecked((uint)0x8458),

    [NativeName("GL_CURRENT_SECONDARY_COLOR_EXT")]
    CurrentSecondaryColorEXT = unchecked((uint)0x8459),

    [NativeName("GL_SECONDARY_COLOR_ARRAY_SIZE_EXT")]
    SecondaryColorArraySizeEXT = unchecked((uint)0x845A),

    [NativeName("GL_SECONDARY_COLOR_ARRAY_TYPE_EXT")]
    SecondaryColorArrayTypeEXT = unchecked((uint)0x845B),

    [NativeName("GL_SECONDARY_COLOR_ARRAY_STRIDE_EXT")]
    SecondaryColorArrayStrideEXT = unchecked((uint)0x845C),

    [NativeName("GL_SECONDARY_COLOR_ARRAY_POINTER_EXT")]
    SecondaryColorArrayPointerEXT = unchecked((uint)0x845D),

    [NativeName("GL_SECONDARY_COLOR_ARRAY_EXT")]
    SecondaryColorArrayEXT = unchecked((uint)0x845E),

    [NativeName("GL_LAYOUT_GENERAL_EXT")]
    LayoutGeneralEXT = unchecked((uint)0x958D),

    [NativeName("GL_LAYOUT_COLOR_ATTACHMENT_EXT")]
    LayoutColorAttachmentEXT = unchecked((uint)0x958E),

    [NativeName("GL_LAYOUT_DEPTH_STENCIL_ATTACHMENT_EXT")]
    LayoutDepthStencilAttachmentEXT = unchecked((uint)0x958F),

    [NativeName("GL_LAYOUT_DEPTH_STENCIL_READ_ONLY_EXT")]
    LayoutDepthStencilReadOnlyEXT = unchecked((uint)0x9590),

    [NativeName("GL_LAYOUT_SHADER_READ_ONLY_EXT")]
    LayoutShaderReadOnlyEXT = unchecked((uint)0x9591),

    [NativeName("GL_LAYOUT_TRANSFER_SRC_EXT")]
    LayoutTransferSrcEXT = unchecked((uint)0x9592),

    [NativeName("GL_LAYOUT_TRANSFER_DST_EXT")]
    LayoutTransferDstEXT = unchecked((uint)0x9593),

    [NativeName("GL_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_EXT")]
    LayoutDepthReadOnlyStencilAttachmentEXT = unchecked((uint)0x9530),

    [NativeName("GL_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_EXT")]
    LayoutDepthAttachmentStencilReadOnlyEXT = unchecked((uint)0x9531),

    [NativeName("GL_HANDLE_TYPE_D3D12_FENCE_EXT")]
    HandleTypeD3D12FenceEXT = unchecked((uint)0x9594),

    [NativeName("GL_D3D12_FENCE_VALUE_EXT")]
    D3D12FenceValueEXT = unchecked((uint)0x9595),

    [NativeName("GL_ACTIVE_PROGRAM_EXT")]
    ActiveProgramEXT = unchecked((uint)0x8259),

    [NativeName("GL_LIGHT_MODEL_COLOR_CONTROL_EXT")]
    LightModelColorControlEXT = unchecked((uint)0x81F8),

    [NativeName("GL_SINGLE_COLOR_EXT")]
    SingleColorEXT = unchecked((uint)0x81F9),

    [NativeName("GL_SEPARATE_SPECULAR_COLOR_EXT")]
    SeparateSpecularColorEXT = unchecked((uint)0x81FA),

    [NativeName("GL_FRAGMENT_SHADER_DISCARDS_SAMPLES_EXT")]
    FragmentShaderDiscardsSamplesEXT = unchecked((uint)0x8A52),

    [NativeName("GL_MAX_IMAGE_UNITS_EXT")]
    MaxImageUnitsEXT = unchecked((uint)0x8F38),

    [NativeName("GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS_EXT")]
    MaxCombinedImageUnitsAndFragmentOutputsEXT = unchecked((uint)0x8F39),

    [NativeName("GL_IMAGE_BINDING_NAME_EXT")]
    ImageBindingNameEXT = unchecked((uint)0x8F3A),

    [NativeName("GL_IMAGE_BINDING_LEVEL_EXT")]
    ImageBindingLevelEXT = unchecked((uint)0x8F3B),

    [NativeName("GL_IMAGE_BINDING_LAYERED_EXT")]
    ImageBindingLayeredEXT = unchecked((uint)0x8F3C),

    [NativeName("GL_IMAGE_BINDING_LAYER_EXT")]
    ImageBindingLayerEXT = unchecked((uint)0x8F3D),

    [NativeName("GL_IMAGE_BINDING_ACCESS_EXT")]
    ImageBindingAccessEXT = unchecked((uint)0x8F3E),

    [NativeName("GL_IMAGE_1D_EXT")]
    Image1DEXT = unchecked((uint)0x904C),

    [NativeName("GL_IMAGE_2D_EXT")]
    Image2DEXT = unchecked((uint)0x904D),

    [NativeName("GL_IMAGE_3D_EXT")]
    Image3DEXT = unchecked((uint)0x904E),

    [NativeName("GL_IMAGE_2D_RECT_EXT")]
    Image2DRectEXT = unchecked((uint)0x904F),

    [NativeName("GL_IMAGE_CUBE_EXT")]
    ImageCubeEXT = unchecked((uint)0x9050),

    [NativeName("GL_IMAGE_BUFFER_EXT")]
    ImageBufferEXT = unchecked((uint)0x9051),

    [NativeName("GL_IMAGE_1D_ARRAY_EXT")]
    Image1DArrayEXT = unchecked((uint)0x9052),

    [NativeName("GL_IMAGE_2D_ARRAY_EXT")]
    Image2DArrayEXT = unchecked((uint)0x9053),

    [NativeName("GL_IMAGE_CUBE_MAP_ARRAY_EXT")]
    ImageCubeMapArrayEXT = unchecked((uint)0x9054),

    [NativeName("GL_IMAGE_2D_MULTISAMPLE_EXT")]
    Image2DMultisampleEXT = unchecked((uint)0x9055),

    [NativeName("GL_IMAGE_2D_MULTISAMPLE_ARRAY_EXT")]
    Image2DMultisampleArrayEXT = unchecked((uint)0x9056),

    [NativeName("GL_INT_IMAGE_1D_EXT")]
    IntImage1DEXT = unchecked((uint)0x9057),

    [NativeName("GL_INT_IMAGE_2D_EXT")]
    IntImage2DEXT = unchecked((uint)0x9058),

    [NativeName("GL_INT_IMAGE_3D_EXT")]
    IntImage3DEXT = unchecked((uint)0x9059),

    [NativeName("GL_INT_IMAGE_2D_RECT_EXT")]
    IntImage2DRectEXT = unchecked((uint)0x905A),

    [NativeName("GL_INT_IMAGE_CUBE_EXT")]
    IntImageCubeEXT = unchecked((uint)0x905B),

    [NativeName("GL_INT_IMAGE_BUFFER_EXT")]
    IntImageBufferEXT = unchecked((uint)0x905C),

    [NativeName("GL_INT_IMAGE_1D_ARRAY_EXT")]
    IntImage1DArrayEXT = unchecked((uint)0x905D),

    [NativeName("GL_INT_IMAGE_2D_ARRAY_EXT")]
    IntImage2DArrayEXT = unchecked((uint)0x905E),

    [NativeName("GL_INT_IMAGE_CUBE_MAP_ARRAY_EXT")]
    IntImageCubeMapArrayEXT = unchecked((uint)0x905F),

    [NativeName("GL_INT_IMAGE_2D_MULTISAMPLE_EXT")]
    IntImage2DMultisampleEXT = unchecked((uint)0x9060),

    [NativeName("GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT")]
    IntImage2DMultisampleArrayEXT = unchecked((uint)0x9061),

    [NativeName("GL_UNSIGNED_INT_IMAGE_1D_EXT")]
    UnsignedIntImage1DEXT = unchecked((uint)0x9062),

    [NativeName("GL_UNSIGNED_INT_IMAGE_2D_EXT")]
    UnsignedIntImage2DEXT = unchecked((uint)0x9063),

    [NativeName("GL_UNSIGNED_INT_IMAGE_3D_EXT")]
    UnsignedIntImage3DEXT = unchecked((uint)0x9064),

    [NativeName("GL_UNSIGNED_INT_IMAGE_2D_RECT_EXT")]
    UnsignedIntImage2DRectEXT = unchecked((uint)0x9065),

    [NativeName("GL_UNSIGNED_INT_IMAGE_CUBE_EXT")]
    UnsignedIntImageCubeEXT = unchecked((uint)0x9066),

    [NativeName("GL_UNSIGNED_INT_IMAGE_BUFFER_EXT")]
    UnsignedIntImageBufferEXT = unchecked((uint)0x9067),

    [NativeName("GL_UNSIGNED_INT_IMAGE_1D_ARRAY_EXT")]
    UnsignedIntImage1DArrayEXT = unchecked((uint)0x9068),

    [NativeName("GL_UNSIGNED_INT_IMAGE_2D_ARRAY_EXT")]
    UnsignedIntImage2DArrayEXT = unchecked((uint)0x9069),

    [NativeName("GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_EXT")]
    UnsignedIntImageCubeMapArrayEXT = unchecked((uint)0x906A),

    [NativeName("GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_EXT")]
    UnsignedIntImage2DMultisampleEXT = unchecked((uint)0x906B),

    [NativeName("GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT")]
    UnsignedIntImage2DMultisampleArrayEXT = unchecked((uint)0x906C),

    [NativeName("GL_MAX_IMAGE_SAMPLES_EXT")]
    MaxImageSamplesEXT = unchecked((uint)0x906D),

    [NativeName("GL_IMAGE_BINDING_FORMAT_EXT")]
    ImageBindingFormatEXT = unchecked((uint)0x906E),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT_EXT")]
    VertexAttribArrayBarrierBitEXT = unchecked((uint)0x00000001),

    [NativeName("GL_ELEMENT_ARRAY_BARRIER_BIT_EXT")]
    ElementArrayBarrierBitEXT = unchecked((uint)0x00000002),

    [NativeName("GL_UNIFORM_BARRIER_BIT_EXT")]
    UniformBarrierBitEXT = unchecked((uint)0x00000004),

    [NativeName("GL_TEXTURE_FETCH_BARRIER_BIT_EXT")]
    TextureFetchBarrierBitEXT = unchecked((uint)0x00000008),

    [NativeName("GL_SHADER_IMAGE_ACCESS_BARRIER_BIT_EXT")]
    ShaderImageAccessBarrierBitEXT = unchecked((uint)0x00000020),

    [NativeName("GL_COMMAND_BARRIER_BIT_EXT")]
    CommandBarrierBitEXT = unchecked((uint)0x00000040),

    [NativeName("GL_PIXEL_BUFFER_BARRIER_BIT_EXT")]
    PixelBufferBarrierBitEXT = unchecked((uint)0x00000080),

    [NativeName("GL_TEXTURE_UPDATE_BARRIER_BIT_EXT")]
    TextureUpdateBarrierBitEXT = unchecked((uint)0x00000100),

    [NativeName("GL_BUFFER_UPDATE_BARRIER_BIT_EXT")]
    BufferUpdateBarrierBitEXT = unchecked((uint)0x00000200),

    [NativeName("GL_FRAMEBUFFER_BARRIER_BIT_EXT")]
    FramebufferBarrierBitEXT = unchecked((uint)0x00000400),

    [NativeName("GL_TRANSFORM_FEEDBACK_BARRIER_BIT_EXT")]
    TransformFeedbackBarrierBitEXT = unchecked((uint)0x00000800),

    [NativeName("GL_ATOMIC_COUNTER_BARRIER_BIT_EXT")]
    AtomicCounterBarrierBitEXT = unchecked((uint)0x00001000),

    [NativeName("GL_ALL_BARRIER_BITS_EXT")]
    AllBarrierBitsEXT = unchecked((uint)0xFFFFFFFF),

    [NativeName("GL_SHARED_TEXTURE_PALETTE_EXT")]
    SharedTexturePaletteEXT = unchecked((uint)0x81FB),

    [NativeName("GL_STENCIL_TAG_BITS_EXT")]
    StencilTagBitsEXT = unchecked((uint)0x88F2),

    [NativeName("GL_STENCIL_CLEAR_TAG_VALUE_EXT")]
    StencilClearTagValueEXT = unchecked((uint)0x88F3),

    [NativeName("GL_STENCIL_TEST_TWO_SIDE_EXT")]
    StencilTestTwoSideEXT = unchecked((uint)0x8910),

    [NativeName("GL_ACTIVE_STENCIL_FACE_EXT")]
    ActiveStencilFaceEXT = unchecked((uint)0x8911),

    [NativeName("GL_INCR_WRAP_EXT")]
    IncrWrapEXT = unchecked((uint)0x8507),

    [NativeName("GL_DECR_WRAP_EXT")]
    DecrWrapEXT = unchecked((uint)0x8508),

    [NativeName("GL_ALPHA4_EXT")]
    Alpha4EXT = unchecked((uint)0x803B),

    [NativeName("GL_ALPHA12_EXT")]
    Alpha12EXT = unchecked((uint)0x803D),

    [NativeName("GL_ALPHA16_EXT")]
    Alpha16EXT = unchecked((uint)0x803E),

    [NativeName("GL_LUMINANCE4_EXT")]
    Luminance4EXT = unchecked((uint)0x803F),

    [NativeName("GL_LUMINANCE12_EXT")]
    Luminance12EXT = unchecked((uint)0x8041),

    [NativeName("GL_LUMINANCE16_EXT")]
    Luminance16EXT = unchecked((uint)0x8042),

    [NativeName("GL_LUMINANCE4_ALPHA4_EXT")]
    Luminance4Alpha4EXT = unchecked((uint)0x8043),

    [NativeName("GL_LUMINANCE6_ALPHA2_EXT")]
    Luminance6Alpha2EXT = unchecked((uint)0x8044),

    [NativeName("GL_LUMINANCE12_ALPHA4_EXT")]
    Luminance12Alpha4EXT = unchecked((uint)0x8046),

    [NativeName("GL_LUMINANCE12_ALPHA12_EXT")]
    Luminance12Alpha12EXT = unchecked((uint)0x8047),

    [NativeName("GL_LUMINANCE16_ALPHA16_EXT")]
    Luminance16Alpha16EXT = unchecked((uint)0x8048),

    [NativeName("GL_INTENSITY_EXT")]
    IntensityEXT = unchecked((uint)0x8049),

    [NativeName("GL_INTENSITY4_EXT")]
    Intensity4EXT = unchecked((uint)0x804A),

    [NativeName("GL_INTENSITY8_EXT")]
    Intensity8EXT = unchecked((uint)0x804B),

    [NativeName("GL_INTENSITY12_EXT")]
    Intensity12EXT = unchecked((uint)0x804C),

    [NativeName("GL_INTENSITY16_EXT")]
    Intensity16EXT = unchecked((uint)0x804D),

    [NativeName("GL_RGB2_EXT")]
    Rgb2EXT = unchecked((uint)0x804E),

    [NativeName("GL_RGB4_EXT")]
    Rgb4EXT = unchecked((uint)0x804F),

    [NativeName("GL_RGB5_EXT")]
    Rgb5EXT = unchecked((uint)0x8050),

    [NativeName("GL_RGB8_EXT")]
    Rgb8EXT = unchecked((uint)0x8051),

    [NativeName("GL_RGB12_EXT")]
    Rgb12EXT = unchecked((uint)0x8053),

    [NativeName("GL_RGB16_EXT")]
    Rgb16EXT = unchecked((uint)0x8054),

    [NativeName("GL_RGBA2_EXT")]
    Rgba2EXT = unchecked((uint)0x8055),

    [NativeName("GL_RGBA4_EXT")]
    Rgba4EXT = unchecked((uint)0x8056),

    [NativeName("GL_RGB5_A1_EXT")]
    Rgb5A1EXT = unchecked((uint)0x8057),

    [NativeName("GL_RGBA8_EXT")]
    Rgba8EXT = unchecked((uint)0x8058),

    [NativeName("GL_RGBA12_EXT")]
    Rgba12EXT = unchecked((uint)0x805A),

    [NativeName("GL_RGBA16_EXT")]
    Rgba16EXT = unchecked((uint)0x805B),

    [NativeName("GL_TEXTURE_RED_SIZE_EXT")]
    TextureRedSizeEXT = unchecked((uint)0x805C),

    [NativeName("GL_TEXTURE_GREEN_SIZE_EXT")]
    TextureGreenSizeEXT = unchecked((uint)0x805D),

    [NativeName("GL_TEXTURE_BLUE_SIZE_EXT")]
    TextureBlueSizeEXT = unchecked((uint)0x805E),

    [NativeName("GL_TEXTURE_ALPHA_SIZE_EXT")]
    TextureAlphaSizeEXT = unchecked((uint)0x805F),

    [NativeName("GL_TEXTURE_LUMINANCE_SIZE_EXT")]
    TextureLuminanceSizeEXT = unchecked((uint)0x8060),

    [NativeName("GL_TEXTURE_INTENSITY_SIZE_EXT")]
    TextureIntensitySizeEXT = unchecked((uint)0x8061),

    [NativeName("GL_REPLACE_EXT")]
    ReplaceEXT = unchecked((uint)0x8062),

    [NativeName("GL_PROXY_TEXTURE_1D_EXT")]
    ProxyTexture1DEXT = unchecked((uint)0x8063),

    [NativeName("GL_PROXY_TEXTURE_2D_EXT")]
    ProxyTexture2DEXT = unchecked((uint)0x8064),

    [NativeName("GL_TEXTURE_TOO_LARGE_EXT")]
    TextureTooLargeEXT = unchecked((uint)0x8065),

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

    [NativeName("GL_PROXY_TEXTURE_3D_EXT")]
    ProxyTexture3DEXT = unchecked((uint)0x8070),

    [NativeName("GL_TEXTURE_DEPTH_EXT")]
    TextureDepthEXT = unchecked((uint)0x8071),

    [NativeName("GL_TEXTURE_WRAP_R_EXT")]
    TextureWrapREXT = unchecked((uint)0x8072),

    [NativeName("GL_MAX_3D_TEXTURE_SIZE_EXT")]
    Max3DTextureSizeEXT = unchecked((uint)0x8073),

    [NativeName("GL_TEXTURE_1D_ARRAY_EXT")]
    Texture1DArrayEXT = unchecked((uint)0x8C18),

    [NativeName("GL_PROXY_TEXTURE_1D_ARRAY_EXT")]
    ProxyTexture1DArrayEXT = unchecked((uint)0x8C19),

    [NativeName("GL_TEXTURE_2D_ARRAY_EXT")]
    Texture2DArrayEXT = unchecked((uint)0x8C1A),

    [NativeName("GL_PROXY_TEXTURE_2D_ARRAY_EXT")]
    ProxyTexture2DArrayEXT = unchecked((uint)0x8C1B),

    [NativeName("GL_TEXTURE_BINDING_1D_ARRAY_EXT")]
    TextureBinding1DArrayEXT = unchecked((uint)0x8C1C),

    [NativeName("GL_TEXTURE_BINDING_2D_ARRAY_EXT")]
    TextureBinding2DArrayEXT = unchecked((uint)0x8C1D),

    [NativeName("GL_MAX_ARRAY_TEXTURE_LAYERS_EXT")]
    MaxArrayTextureLayersEXT = unchecked((uint)0x88FF),

    [NativeName("GL_COMPARE_REF_DEPTH_TO_TEXTURE_EXT")]
    CompareRefDepthToTextureEXT = unchecked((uint)0x884E),

    [NativeName("GL_TEXTURE_BUFFER_EXT")]
    TextureBufferEXT = unchecked((uint)0x8C2A),

    [NativeName("GL_MAX_TEXTURE_BUFFER_SIZE_EXT")]
    MaxTextureBufferSizeEXT = unchecked((uint)0x8C2B),

    [NativeName("GL_TEXTURE_BINDING_BUFFER_EXT")]
    TextureBindingBufferEXT = unchecked((uint)0x8C2C),

    [NativeName("GL_TEXTURE_BUFFER_DATA_STORE_BINDING_EXT")]
    TextureBufferDataStoreBindingEXT = unchecked((uint)0x8C2D),

    [NativeName("GL_TEXTURE_BUFFER_FORMAT_EXT")]
    TextureBufferFormatEXT = unchecked((uint)0x8C2E),

    [NativeName("GL_COMPRESSED_LUMINANCE_LATC1_EXT")]
    CompressedLuminanceLatc1EXT = unchecked((uint)0x8C70),

    [NativeName("GL_COMPRESSED_SIGNED_LUMINANCE_LATC1_EXT")]
    CompressedSignedLuminanceLatc1EXT = unchecked((uint)0x8C71),

    [NativeName("GL_COMPRESSED_LUMINANCE_ALPHA_LATC2_EXT")]
    CompressedLuminanceAlphaLatc2EXT = unchecked((uint)0x8C72),

    [NativeName("GL_COMPRESSED_SIGNED_LUMINANCE_ALPHA_LATC2_EXT")]
    CompressedSignedLuminanceAlphaLatc2EXT = unchecked((uint)0x8C73),

    [NativeName("GL_COMPRESSED_RED_RGTC1_EXT")]
    CompressedRedRgtc1EXT = unchecked((uint)0x8DBB),

    [NativeName("GL_COMPRESSED_SIGNED_RED_RGTC1_EXT")]
    CompressedSignedRedRgtc1EXT = unchecked((uint)0x8DBC),

    [NativeName("GL_COMPRESSED_RED_GREEN_RGTC2_EXT")]
    CompressedRedGreenRgtc2EXT = unchecked((uint)0x8DBD),

    [NativeName("GL_COMPRESSED_SIGNED_RED_GREEN_RGTC2_EXT")]
    CompressedSignedRedGreenRgtc2EXT = unchecked((uint)0x8DBE),

    [NativeName("GL_COMPRESSED_RGBA_S3TC_DXT3_EXT")]
    CompressedRgbaS3TcDxt3EXT = unchecked((uint)0x83F2),

    [NativeName("GL_COMPRESSED_RGBA_S3TC_DXT5_EXT")]
    CompressedRgbaS3TcDxt5EXT = unchecked((uint)0x83F3),

    [NativeName("GL_NORMAL_MAP_EXT")]
    NormalMapEXT = unchecked((uint)0x8511),

    [NativeName("GL_REFLECTION_MAP_EXT")]
    ReflectionMapEXT = unchecked((uint)0x8512),

    [NativeName("GL_TEXTURE_CUBE_MAP_EXT")]
    TextureCubeMapEXT = unchecked((uint)0x8513),

    [NativeName("GL_TEXTURE_BINDING_CUBE_MAP_EXT")]
    TextureBindingCubeMapEXT = unchecked((uint)0x8514),

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_X_EXT")]
    TextureCubeMapPositiveXEXT = unchecked((uint)0x8515),

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_X_EXT")]
    TextureCubeMapNegativeXEXT = unchecked((uint)0x8516),

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Y_EXT")]
    TextureCubeMapPositiveYEXT = unchecked((uint)0x8517),

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_EXT")]
    TextureCubeMapNegativeYEXT = unchecked((uint)0x8518),

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Z_EXT")]
    TextureCubeMapPositiveZEXT = unchecked((uint)0x8519),

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_EXT")]
    TextureCubeMapNegativeZEXT = unchecked((uint)0x851A),

    [NativeName("GL_PROXY_TEXTURE_CUBE_MAP_EXT")]
    ProxyTextureCubeMapEXT = unchecked((uint)0x851B),

    [NativeName("GL_MAX_CUBE_MAP_TEXTURE_SIZE_EXT")]
    MaxCubeMapTextureSizeEXT = unchecked((uint)0x851C),

    [NativeName("GL_COMBINE_EXT")]
    CombineEXT = unchecked((uint)0x8570),

    [NativeName("GL_COMBINE_RGB_EXT")]
    CombineRgbEXT = unchecked((uint)0x8571),

    [NativeName("GL_COMBINE_ALPHA_EXT")]
    CombineAlphaEXT = unchecked((uint)0x8572),

    [NativeName("GL_RGB_SCALE_EXT")]
    RgbScaleEXT = unchecked((uint)0x8573),

    [NativeName("GL_ADD_SIGNED_EXT")]
    AddSignedEXT = unchecked((uint)0x8574),

    [NativeName("GL_INTERPOLATE_EXT")]
    InterpolateEXT = unchecked((uint)0x8575),

    [NativeName("GL_CONSTANT_EXT")]
    ConstantEXT = unchecked((uint)0x8576),

    [NativeName("GL_PRIMARY_COLOR_EXT")]
    PrimaryColorEXT = unchecked((uint)0x8577),

    [NativeName("GL_PREVIOUS_EXT")]
    PreviousEXT = unchecked((uint)0x8578),

    [NativeName("GL_SOURCE0_RGB_EXT")]
    Source0RgbEXT = unchecked((uint)0x8580),

    [NativeName("GL_SOURCE1_RGB_EXT")]
    Source1RgbEXT = unchecked((uint)0x8581),

    [NativeName("GL_SOURCE2_RGB_EXT")]
    Source2RgbEXT = unchecked((uint)0x8582),

    [NativeName("GL_SOURCE0_ALPHA_EXT")]
    Source0AlphaEXT = unchecked((uint)0x8588),

    [NativeName("GL_SOURCE1_ALPHA_EXT")]
    Source1AlphaEXT = unchecked((uint)0x8589),

    [NativeName("GL_SOURCE2_ALPHA_EXT")]
    Source2AlphaEXT = unchecked((uint)0x858A),

    [NativeName("GL_OPERAND0_RGB_EXT")]
    Operand0RgbEXT = unchecked((uint)0x8590),

    [NativeName("GL_OPERAND1_RGB_EXT")]
    Operand1RgbEXT = unchecked((uint)0x8591),

    [NativeName("GL_OPERAND2_RGB_EXT")]
    Operand2RgbEXT = unchecked((uint)0x8592),

    [NativeName("GL_OPERAND0_ALPHA_EXT")]
    Operand0AlphaEXT = unchecked((uint)0x8598),

    [NativeName("GL_OPERAND1_ALPHA_EXT")]
    Operand1AlphaEXT = unchecked((uint)0x8599),

    [NativeName("GL_OPERAND2_ALPHA_EXT")]
    Operand2AlphaEXT = unchecked((uint)0x859A),

    [NativeName("GL_DOT3_RGB_EXT")]
    Dot3RgbEXT = unchecked((uint)0x8740),

    [NativeName("GL_DOT3_RGBA_EXT")]
    Dot3RgbaEXT = unchecked((uint)0x8741),

    [NativeName("GL_TEXTURE_REDUCTION_MODE_EXT")]
    TextureReductionModeEXT = unchecked((uint)0x9366),

    [NativeName("GL_WEIGHTED_AVERAGE_EXT")]
    WeightedAverageEXT = unchecked((uint)0x9367),

    [NativeName("GL_RGBA32UI_EXT")]
    Rgba32UiEXT = unchecked((uint)0x8D70),

    [NativeName("GL_RGB32UI_EXT")]
    Rgb32UiEXT = unchecked((uint)0x8D71),

    [NativeName("GL_ALPHA32UI_EXT")]
    Alpha32UiEXT = unchecked((uint)0x8D72),

    [NativeName("GL_INTENSITY32UI_EXT")]
    Intensity32UiEXT = unchecked((uint)0x8D73),

    [NativeName("GL_LUMINANCE32UI_EXT")]
    Luminance32UiEXT = unchecked((uint)0x8D74),

    [NativeName("GL_LUMINANCE_ALPHA32UI_EXT")]
    LuminanceAlpha32UiEXT = unchecked((uint)0x8D75),

    [NativeName("GL_RGBA16UI_EXT")]
    Rgba16UiEXT = unchecked((uint)0x8D76),

    [NativeName("GL_RGB16UI_EXT")]
    Rgb16UiEXT = unchecked((uint)0x8D77),

    [NativeName("GL_ALPHA16UI_EXT")]
    Alpha16UiEXT = unchecked((uint)0x8D78),

    [NativeName("GL_INTENSITY16UI_EXT")]
    Intensity16UiEXT = unchecked((uint)0x8D79),

    [NativeName("GL_LUMINANCE16UI_EXT")]
    Luminance16UiEXT = unchecked((uint)0x8D7A),

    [NativeName("GL_LUMINANCE_ALPHA16UI_EXT")]
    LuminanceAlpha16UiEXT = unchecked((uint)0x8D7B),

    [NativeName("GL_RGBA8UI_EXT")]
    Rgba8UiEXT = unchecked((uint)0x8D7C),

    [NativeName("GL_RGB8UI_EXT")]
    Rgb8UiEXT = unchecked((uint)0x8D7D),

    [NativeName("GL_ALPHA8UI_EXT")]
    Alpha8UiEXT = unchecked((uint)0x8D7E),

    [NativeName("GL_INTENSITY8UI_EXT")]
    Intensity8UiEXT = unchecked((uint)0x8D7F),

    [NativeName("GL_LUMINANCE8UI_EXT")]
    Luminance8UiEXT = unchecked((uint)0x8D80),

    [NativeName("GL_LUMINANCE_ALPHA8UI_EXT")]
    LuminanceAlpha8UiEXT = unchecked((uint)0x8D81),

    [NativeName("GL_RGBA32I_EXT")]
    Rgba32IEXT = unchecked((uint)0x8D82),

    [NativeName("GL_RGB32I_EXT")]
    Rgb32IEXT = unchecked((uint)0x8D83),

    [NativeName("GL_ALPHA32I_EXT")]
    Alpha32IEXT = unchecked((uint)0x8D84),

    [NativeName("GL_INTENSITY32I_EXT")]
    Intensity32IEXT = unchecked((uint)0x8D85),

    [NativeName("GL_LUMINANCE32I_EXT")]
    Luminance32IEXT = unchecked((uint)0x8D86),

    [NativeName("GL_LUMINANCE_ALPHA32I_EXT")]
    LuminanceAlpha32IEXT = unchecked((uint)0x8D87),

    [NativeName("GL_RGBA16I_EXT")]
    Rgba16IEXT = unchecked((uint)0x8D88),

    [NativeName("GL_RGB16I_EXT")]
    Rgb16IEXT = unchecked((uint)0x8D89),

    [NativeName("GL_ALPHA16I_EXT")]
    Alpha16IEXT = unchecked((uint)0x8D8A),

    [NativeName("GL_INTENSITY16I_EXT")]
    Intensity16IEXT = unchecked((uint)0x8D8B),

    [NativeName("GL_LUMINANCE16I_EXT")]
    Luminance16IEXT = unchecked((uint)0x8D8C),

    [NativeName("GL_LUMINANCE_ALPHA16I_EXT")]
    LuminanceAlpha16IEXT = unchecked((uint)0x8D8D),

    [NativeName("GL_RGBA8I_EXT")]
    Rgba8IEXT = unchecked((uint)0x8D8E),

    [NativeName("GL_RGB8I_EXT")]
    Rgb8IEXT = unchecked((uint)0x8D8F),

    [NativeName("GL_ALPHA8I_EXT")]
    Alpha8IEXT = unchecked((uint)0x8D90),

    [NativeName("GL_INTENSITY8I_EXT")]
    Intensity8IEXT = unchecked((uint)0x8D91),

    [NativeName("GL_LUMINANCE8I_EXT")]
    Luminance8IEXT = unchecked((uint)0x8D92),

    [NativeName("GL_LUMINANCE_ALPHA8I_EXT")]
    LuminanceAlpha8IEXT = unchecked((uint)0x8D93),

    [NativeName("GL_RED_INTEGER_EXT")]
    RedIntegerEXT = unchecked((uint)0x8D94),

    [NativeName("GL_GREEN_INTEGER_EXT")]
    GreenIntegerEXT = unchecked((uint)0x8D95),

    [NativeName("GL_BLUE_INTEGER_EXT")]
    BlueIntegerEXT = unchecked((uint)0x8D96),

    [NativeName("GL_ALPHA_INTEGER_EXT")]
    AlphaIntegerEXT = unchecked((uint)0x8D97),

    [NativeName("GL_RGB_INTEGER_EXT")]
    RgbIntegerEXT = unchecked((uint)0x8D98),

    [NativeName("GL_RGBA_INTEGER_EXT")]
    RgbaIntegerEXT = unchecked((uint)0x8D99),

    [NativeName("GL_BGR_INTEGER_EXT")]
    BgrIntegerEXT = unchecked((uint)0x8D9A),

    [NativeName("GL_BGRA_INTEGER_EXT")]
    BgraIntegerEXT = unchecked((uint)0x8D9B),

    [NativeName("GL_LUMINANCE_INTEGER_EXT")]
    LuminanceIntegerEXT = unchecked((uint)0x8D9C),

    [NativeName("GL_LUMINANCE_ALPHA_INTEGER_EXT")]
    LuminanceAlphaIntegerEXT = unchecked((uint)0x8D9D),

    [NativeName("GL_RGBA_INTEGER_MODE_EXT")]
    RgbaIntegerModeEXT = unchecked((uint)0x8D9E),

    [NativeName("GL_MIRROR_CLAMP_EXT")]
    MirrorClampEXT = unchecked((uint)0x8742),

    [NativeName("GL_MIRROR_CLAMP_TO_EDGE_EXT")]
    MirrorClampToEdgeEXT = unchecked((uint)0x8743),

    [NativeName("GL_MIRROR_CLAMP_TO_BORDER_EXT")]
    MirrorClampToBorderEXT = unchecked((uint)0x8912),

    [NativeName("GL_TEXTURE_PRIORITY_EXT")]
    TexturePriorityEXT = unchecked((uint)0x8066),

    [NativeName("GL_TEXTURE_RESIDENT_EXT")]
    TextureResidentEXT = unchecked((uint)0x8067),

    [NativeName("GL_TEXTURE_1D_BINDING_EXT")]
    Texture1DBindingEXT = unchecked((uint)0x8068),

    [NativeName("GL_TEXTURE_2D_BINDING_EXT")]
    Texture2DBindingEXT = unchecked((uint)0x8069),

    [NativeName("GL_TEXTURE_3D_BINDING_EXT")]
    Texture3DBindingEXT = unchecked((uint)0x806A),

    [NativeName("GL_PERTURB_EXT")]
    PerturbEXT = unchecked((uint)0x85AE),

    [NativeName("GL_TEXTURE_NORMAL_EXT")]
    TextureNormalEXT = unchecked((uint)0x85AF),

    [NativeName("GL_SRGB8_EXT")]
    Srgb8EXT = unchecked((uint)0x8C41),

    [NativeName("GL_SLUMINANCE_ALPHA_EXT")]
    SluminanceAlphaEXT = unchecked((uint)0x8C44),

    [NativeName("GL_SLUMINANCE8_ALPHA8_EXT")]
    Sluminance8Alpha8EXT = unchecked((uint)0x8C45),

    [NativeName("GL_SLUMINANCE_EXT")]
    SluminanceEXT = unchecked((uint)0x8C46),

    [NativeName("GL_SLUMINANCE8_EXT")]
    Sluminance8EXT = unchecked((uint)0x8C47),

    [NativeName("GL_COMPRESSED_SRGB_EXT")]
    CompressedSrgbEXT = unchecked((uint)0x8C48),

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_EXT")]
    CompressedSrgbAlphaEXT = unchecked((uint)0x8C49),

    [NativeName("GL_COMPRESSED_SLUMINANCE_EXT")]
    CompressedSluminanceEXT = unchecked((uint)0x8C4A),

    [NativeName("GL_COMPRESSED_SLUMINANCE_ALPHA_EXT")]
    CompressedSluminanceAlphaEXT = unchecked((uint)0x8C4B),

    [NativeName("GL_COMPRESSED_SRGB_S3TC_DXT1_EXT")]
    CompressedSrgbS3TcDxt1EXT = unchecked((uint)0x8C4C),

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT")]
    CompressedSrgbAlphaS3TcDxt1EXT = unchecked((uint)0x8C4D),

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT")]
    CompressedSrgbAlphaS3TcDxt3EXT = unchecked((uint)0x8C4E),

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT")]
    CompressedSrgbAlphaS3TcDxt5EXT = unchecked((uint)0x8C4F),

    [NativeName("GL_SR8_EXT")]
    Sr8EXT = unchecked((uint)0x8FBD),

    [NativeName("GL_SRG8_EXT")]
    Srg8EXT = unchecked((uint)0x8FBE),

    [NativeName("GL_TEXTURE_SRGB_DECODE_EXT")]
    TextureSrgbDecodeEXT = unchecked((uint)0x8A48),

    [NativeName("GL_DECODE_EXT")]
    DecodeEXT = unchecked((uint)0x8A49),

    [NativeName("GL_SKIP_DECODE_EXT")]
    SkipDecodeEXT = unchecked((uint)0x8A4A),

    [NativeName("GL_RGB9_E5_EXT")]
    Rgb9E5EXT = unchecked((uint)0x8C3D),

    [NativeName("GL_UNSIGNED_INT_5_9_9_9_REV_EXT")]
    UnsignedInt5X9X9X9RevEXT = unchecked((uint)0x8C3E),

    [NativeName("GL_TEXTURE_SHARED_SIZE_EXT")]
    TextureSharedSizeEXT = unchecked((uint)0x8C3F),

    [NativeName("GL_ALPHA_SNORM")]
    AlphaSnorm = unchecked((uint)0x9010),

    [NativeName("GL_LUMINANCE_SNORM")]
    LuminanceSnorm = unchecked((uint)0x9011),

    [NativeName("GL_LUMINANCE_ALPHA_SNORM")]
    LuminanceAlphaSnorm = unchecked((uint)0x9012),

    [NativeName("GL_INTENSITY_SNORM")]
    IntensitySnorm = unchecked((uint)0x9013),

    [NativeName("GL_ALPHA8_SNORM")]
    Alpha8Snorm = unchecked((uint)0x9014),

    [NativeName("GL_LUMINANCE8_SNORM")]
    Luminance8Snorm = unchecked((uint)0x9015),

    [NativeName("GL_LUMINANCE8_ALPHA8_SNORM")]
    Luminance8Alpha8Snorm = unchecked((uint)0x9016),

    [NativeName("GL_INTENSITY8_SNORM")]
    Intensity8Snorm = unchecked((uint)0x9017),

    [NativeName("GL_ALPHA16_SNORM")]
    Alpha16Snorm = unchecked((uint)0x9018),

    [NativeName("GL_LUMINANCE16_SNORM")]
    Luminance16Snorm = unchecked((uint)0x9019),

    [NativeName("GL_LUMINANCE16_ALPHA16_SNORM")]
    Luminance16Alpha16Snorm = unchecked((uint)0x901A),

    [NativeName("GL_INTENSITY16_SNORM")]
    Intensity16Snorm = unchecked((uint)0x901B),

    [NativeName("GL_RED_SNORM")]
    RedSnorm = unchecked((uint)0x8F90),

    [NativeName("GL_RG_SNORM")]
    RgSnorm = unchecked((uint)0x8F91),

    [NativeName("GL_RGB_SNORM")]
    RgbSnorm = unchecked((uint)0x8F92),

    [NativeName("GL_RGBA_SNORM")]
    RgbaSnorm = unchecked((uint)0x8F93),

    [NativeName("GL_TEXTURE_SWIZZLE_R_EXT")]
    TextureSwizzleREXT = unchecked((uint)0x8E42),

    [NativeName("GL_TEXTURE_SWIZZLE_G_EXT")]
    TextureSwizzleGEXT = unchecked((uint)0x8E43),

    [NativeName("GL_TEXTURE_SWIZZLE_B_EXT")]
    TextureSwizzleBEXT = unchecked((uint)0x8E44),

    [NativeName("GL_TEXTURE_SWIZZLE_A_EXT")]
    TextureSwizzleAEXT = unchecked((uint)0x8E45),

    [NativeName("GL_TEXTURE_SWIZZLE_RGBA_EXT")]
    TextureSwizzleRgbaEXT = unchecked((uint)0x8E46),

    [NativeName("GL_TIME_ELAPSED_EXT")]
    TimeElapsedEXT = unchecked((uint)0x88BF),

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_EXT")]
    TransformFeedbackBufferEXT = unchecked((uint)0x8C8E),

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_START_EXT")]
    TransformFeedbackBufferStartEXT = unchecked((uint)0x8C84),

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_SIZE_EXT")]
    TransformFeedbackBufferSizeEXT = unchecked((uint)0x8C85),

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_BINDING_EXT")]
    TransformFeedbackBufferBindingEXT = unchecked((uint)0x8C8F),

    [NativeName("GL_INTERLEAVED_ATTRIBS_EXT")]
    InterleavedAttribsEXT = unchecked((uint)0x8C8C),

    [NativeName("GL_SEPARATE_ATTRIBS_EXT")]
    SeparateAttribsEXT = unchecked((uint)0x8C8D),

    [NativeName("GL_PRIMITIVES_GENERATED_EXT")]
    PrimitivesGeneratedEXT = unchecked((uint)0x8C87),

    [NativeName("GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN_EXT")]
    TransformFeedbackPrimitivesWrittenEXT = unchecked((uint)0x8C88),

    [NativeName("GL_RASTERIZER_DISCARD_EXT")]
    RasterizerDiscardEXT = unchecked((uint)0x8C89),

    [NativeName("GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS_EXT")]
    MaxTransformFeedbackInterleavedComponentsEXT = unchecked((uint)0x8C8A),

    [NativeName("GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS_EXT")]
    MaxTransformFeedbackSeparateAttribsEXT = unchecked((uint)0x8C8B),

    [NativeName("GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS_EXT")]
    MaxTransformFeedbackSeparateComponentsEXT = unchecked((uint)0x8C80),

    [NativeName("GL_TRANSFORM_FEEDBACK_VARYINGS_EXT")]
    TransformFeedbackVaryingsEXT = unchecked((uint)0x8C83),

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_MODE_EXT")]
    TransformFeedbackBufferModeEXT = unchecked((uint)0x8C7F),

    [NativeName("GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH_EXT")]
    TransformFeedbackVaryingMaxLengthEXT = unchecked((uint)0x8C76),

    [NativeName("GL_VERTEX_ARRAY_EXT")]
    VertexArrayEXT = unchecked((uint)0x8074),

    [NativeName("GL_NORMAL_ARRAY_EXT")]
    NormalArrayEXT = unchecked((uint)0x8075),

    [NativeName("GL_COLOR_ARRAY_EXT")]
    ColorArrayEXT = unchecked((uint)0x8076),

    [NativeName("GL_INDEX_ARRAY_EXT")]
    IndexArrayEXT = unchecked((uint)0x8077),

    [NativeName("GL_TEXTURE_COORD_ARRAY_EXT")]
    TextureCoordArrayEXT = unchecked((uint)0x8078),

    [NativeName("GL_EDGE_FLAG_ARRAY_EXT")]
    EdgeFlagArrayEXT = unchecked((uint)0x8079),

    [NativeName("GL_VERTEX_ARRAY_SIZE_EXT")]
    VertexArraySizeEXT = unchecked((uint)0x807A),

    [NativeName("GL_VERTEX_ARRAY_TYPE_EXT")]
    VertexArrayTypeEXT = unchecked((uint)0x807B),

    [NativeName("GL_VERTEX_ARRAY_STRIDE_EXT")]
    VertexArrayStrideEXT = unchecked((uint)0x807C),

    [NativeName("GL_VERTEX_ARRAY_COUNT_EXT")]
    VertexArrayCountEXT = unchecked((uint)0x807D),

    [NativeName("GL_NORMAL_ARRAY_TYPE_EXT")]
    NormalArrayTypeEXT = unchecked((uint)0x807E),

    [NativeName("GL_NORMAL_ARRAY_STRIDE_EXT")]
    NormalArrayStrideEXT = unchecked((uint)0x807F),

    [NativeName("GL_NORMAL_ARRAY_COUNT_EXT")]
    NormalArrayCountEXT = unchecked((uint)0x8080),

    [NativeName("GL_COLOR_ARRAY_SIZE_EXT")]
    ColorArraySizeEXT = unchecked((uint)0x8081),

    [NativeName("GL_COLOR_ARRAY_TYPE_EXT")]
    ColorArrayTypeEXT = unchecked((uint)0x8082),

    [NativeName("GL_COLOR_ARRAY_STRIDE_EXT")]
    ColorArrayStrideEXT = unchecked((uint)0x8083),

    [NativeName("GL_COLOR_ARRAY_COUNT_EXT")]
    ColorArrayCountEXT = unchecked((uint)0x8084),

    [NativeName("GL_INDEX_ARRAY_TYPE_EXT")]
    IndexArrayTypeEXT = unchecked((uint)0x8085),

    [NativeName("GL_INDEX_ARRAY_STRIDE_EXT")]
    IndexArrayStrideEXT = unchecked((uint)0x8086),

    [NativeName("GL_INDEX_ARRAY_COUNT_EXT")]
    IndexArrayCountEXT = unchecked((uint)0x8087),

    [NativeName("GL_TEXTURE_COORD_ARRAY_SIZE_EXT")]
    TextureCoordArraySizeEXT = unchecked((uint)0x8088),

    [NativeName("GL_TEXTURE_COORD_ARRAY_TYPE_EXT")]
    TextureCoordArrayTypeEXT = unchecked((uint)0x8089),

    [NativeName("GL_TEXTURE_COORD_ARRAY_STRIDE_EXT")]
    TextureCoordArrayStrideEXT = unchecked((uint)0x808A),

    [NativeName("GL_TEXTURE_COORD_ARRAY_COUNT_EXT")]
    TextureCoordArrayCountEXT = unchecked((uint)0x808B),

    [NativeName("GL_EDGE_FLAG_ARRAY_STRIDE_EXT")]
    EdgeFlagArrayStrideEXT = unchecked((uint)0x808C),

    [NativeName("GL_EDGE_FLAG_ARRAY_COUNT_EXT")]
    EdgeFlagArrayCountEXT = unchecked((uint)0x808D),

    [NativeName("GL_VERTEX_ARRAY_POINTER_EXT")]
    VertexArrayPointerEXT = unchecked((uint)0x808E),

    [NativeName("GL_NORMAL_ARRAY_POINTER_EXT")]
    NormalArrayPointerEXT = unchecked((uint)0x808F),

    [NativeName("GL_COLOR_ARRAY_POINTER_EXT")]
    ColorArrayPointerEXT = unchecked((uint)0x8090),

    [NativeName("GL_INDEX_ARRAY_POINTER_EXT")]
    IndexArrayPointerEXT = unchecked((uint)0x8091),

    [NativeName("GL_TEXTURE_COORD_ARRAY_POINTER_EXT")]
    TextureCoordArrayPointerEXT = unchecked((uint)0x8092),

    [NativeName("GL_EDGE_FLAG_ARRAY_POINTER_EXT")]
    EdgeFlagArrayPointerEXT = unchecked((uint)0x8093),

    [NativeName("GL_DOUBLE_VEC2_EXT")]
    DoubleVec2EXT = unchecked((uint)0x8FFC),

    [NativeName("GL_DOUBLE_VEC3_EXT")]
    DoubleVec3EXT = unchecked((uint)0x8FFD),

    [NativeName("GL_DOUBLE_VEC4_EXT")]
    DoubleVec4EXT = unchecked((uint)0x8FFE),

    [NativeName("GL_DOUBLE_MAT2_EXT")]
    DoubleMat2EXT = unchecked((uint)0x8F46),

    [NativeName("GL_DOUBLE_MAT3_EXT")]
    DoubleMat3EXT = unchecked((uint)0x8F47),

    [NativeName("GL_DOUBLE_MAT4_EXT")]
    DoubleMat4EXT = unchecked((uint)0x8F48),

    [NativeName("GL_DOUBLE_MAT2x3_EXT")]
    DoubleMat2X3EXT = unchecked((uint)0x8F49),

    [NativeName("GL_DOUBLE_MAT2x4_EXT")]
    DoubleMat2X4EXT = unchecked((uint)0x8F4A),

    [NativeName("GL_DOUBLE_MAT3x2_EXT")]
    DoubleMat3X2EXT = unchecked((uint)0x8F4B),

    [NativeName("GL_DOUBLE_MAT3x4_EXT")]
    DoubleMat3X4EXT = unchecked((uint)0x8F4C),

    [NativeName("GL_DOUBLE_MAT4x2_EXT")]
    DoubleMat4X2EXT = unchecked((uint)0x8F4D),

    [NativeName("GL_DOUBLE_MAT4x3_EXT")]
    DoubleMat4X3EXT = unchecked((uint)0x8F4E),

    [NativeName("GL_VERTEX_SHADER_EXT")]
    VertexShaderEXT = unchecked((uint)0x8780),

    [NativeName("GL_VERTEX_SHADER_BINDING_EXT")]
    VertexShaderBindingEXT = unchecked((uint)0x8781),

    [NativeName("GL_OP_INDEX_EXT")]
    OpIndexEXT = unchecked((uint)0x8782),

    [NativeName("GL_OP_NEGATE_EXT")]
    OpNegateEXT = unchecked((uint)0x8783),

    [NativeName("GL_OP_DOT3_EXT")]
    OpDot3EXT = unchecked((uint)0x8784),

    [NativeName("GL_OP_DOT4_EXT")]
    OpDot4EXT = unchecked((uint)0x8785),

    [NativeName("GL_OP_MUL_EXT")]
    OpMulEXT = unchecked((uint)0x8786),

    [NativeName("GL_OP_ADD_EXT")]
    OpAddEXT = unchecked((uint)0x8787),

    [NativeName("GL_OP_MADD_EXT")]
    OpMaddEXT = unchecked((uint)0x8788),

    [NativeName("GL_OP_FRAC_EXT")]
    OpFracEXT = unchecked((uint)0x8789),

    [NativeName("GL_OP_MAX_EXT")]
    OpMaxEXT = unchecked((uint)0x878A),

    [NativeName("GL_OP_MIN_EXT")]
    OpMinEXT = unchecked((uint)0x878B),

    [NativeName("GL_OP_SET_GE_EXT")]
    OpSetGeEXT = unchecked((uint)0x878C),

    [NativeName("GL_OP_SET_LT_EXT")]
    OpSetLtEXT = unchecked((uint)0x878D),

    [NativeName("GL_OP_CLAMP_EXT")]
    OpClampEXT = unchecked((uint)0x878E),

    [NativeName("GL_OP_FLOOR_EXT")]
    OpFloorEXT = unchecked((uint)0x878F),

    [NativeName("GL_OP_ROUND_EXT")]
    OpRoundEXT = unchecked((uint)0x8790),

    [NativeName("GL_OP_EXP_BASE_2_EXT")]
    OpExpBase2EXT = unchecked((uint)0x8791),

    [NativeName("GL_OP_LOG_BASE_2_EXT")]
    OpLogBase2EXT = unchecked((uint)0x8792),

    [NativeName("GL_OP_POWER_EXT")]
    OpPowerEXT = unchecked((uint)0x8793),

    [NativeName("GL_OP_RECIP_EXT")]
    OpRecipEXT = unchecked((uint)0x8794),

    [NativeName("GL_OP_RECIP_SQRT_EXT")]
    OpRecipSqrtEXT = unchecked((uint)0x8795),

    [NativeName("GL_OP_SUB_EXT")]
    OpSubEXT = unchecked((uint)0x8796),

    [NativeName("GL_OP_CROSS_PRODUCT_EXT")]
    OpCrossProductEXT = unchecked((uint)0x8797),

    [NativeName("GL_OP_MULTIPLY_MATRIX_EXT")]
    OpMultiplyMatrixEXT = unchecked((uint)0x8798),

    [NativeName("GL_OP_MOV_EXT")]
    OpMovEXT = unchecked((uint)0x8799),

    [NativeName("GL_OUTPUT_VERTEX_EXT")]
    OutputVertexEXT = unchecked((uint)0x879A),

    [NativeName("GL_OUTPUT_COLOR0_EXT")]
    OutputColor0EXT = unchecked((uint)0x879B),

    [NativeName("GL_OUTPUT_COLOR1_EXT")]
    OutputColor1EXT = unchecked((uint)0x879C),

    [NativeName("GL_OUTPUT_TEXTURE_COORD0_EXT")]
    OutputTextureCoord0EXT = unchecked((uint)0x879D),

    [NativeName("GL_OUTPUT_TEXTURE_COORD1_EXT")]
    OutputTextureCoord1EXT = unchecked((uint)0x879E),

    [NativeName("GL_OUTPUT_TEXTURE_COORD2_EXT")]
    OutputTextureCoord2EXT = unchecked((uint)0x879F),

    [NativeName("GL_OUTPUT_TEXTURE_COORD3_EXT")]
    OutputTextureCoord3EXT = unchecked((uint)0x87A0),

    [NativeName("GL_OUTPUT_TEXTURE_COORD4_EXT")]
    OutputTextureCoord4EXT = unchecked((uint)0x87A1),

    [NativeName("GL_OUTPUT_TEXTURE_COORD5_EXT")]
    OutputTextureCoord5EXT = unchecked((uint)0x87A2),

    [NativeName("GL_OUTPUT_TEXTURE_COORD6_EXT")]
    OutputTextureCoord6EXT = unchecked((uint)0x87A3),

    [NativeName("GL_OUTPUT_TEXTURE_COORD7_EXT")]
    OutputTextureCoord7EXT = unchecked((uint)0x87A4),

    [NativeName("GL_OUTPUT_TEXTURE_COORD8_EXT")]
    OutputTextureCoord8EXT = unchecked((uint)0x87A5),

    [NativeName("GL_OUTPUT_TEXTURE_COORD9_EXT")]
    OutputTextureCoord9EXT = unchecked((uint)0x87A6),

    [NativeName("GL_OUTPUT_TEXTURE_COORD10_EXT")]
    OutputTextureCoord10EXT = unchecked((uint)0x87A7),

    [NativeName("GL_OUTPUT_TEXTURE_COORD11_EXT")]
    OutputTextureCoord11EXT = unchecked((uint)0x87A8),

    [NativeName("GL_OUTPUT_TEXTURE_COORD12_EXT")]
    OutputTextureCoord12EXT = unchecked((uint)0x87A9),

    [NativeName("GL_OUTPUT_TEXTURE_COORD13_EXT")]
    OutputTextureCoord13EXT = unchecked((uint)0x87AA),

    [NativeName("GL_OUTPUT_TEXTURE_COORD14_EXT")]
    OutputTextureCoord14EXT = unchecked((uint)0x87AB),

    [NativeName("GL_OUTPUT_TEXTURE_COORD15_EXT")]
    OutputTextureCoord15EXT = unchecked((uint)0x87AC),

    [NativeName("GL_OUTPUT_TEXTURE_COORD16_EXT")]
    OutputTextureCoord16EXT = unchecked((uint)0x87AD),

    [NativeName("GL_OUTPUT_TEXTURE_COORD17_EXT")]
    OutputTextureCoord17EXT = unchecked((uint)0x87AE),

    [NativeName("GL_OUTPUT_TEXTURE_COORD18_EXT")]
    OutputTextureCoord18EXT = unchecked((uint)0x87AF),

    [NativeName("GL_OUTPUT_TEXTURE_COORD19_EXT")]
    OutputTextureCoord19EXT = unchecked((uint)0x87B0),

    [NativeName("GL_OUTPUT_TEXTURE_COORD20_EXT")]
    OutputTextureCoord20EXT = unchecked((uint)0x87B1),

    [NativeName("GL_OUTPUT_TEXTURE_COORD21_EXT")]
    OutputTextureCoord21EXT = unchecked((uint)0x87B2),

    [NativeName("GL_OUTPUT_TEXTURE_COORD22_EXT")]
    OutputTextureCoord22EXT = unchecked((uint)0x87B3),

    [NativeName("GL_OUTPUT_TEXTURE_COORD23_EXT")]
    OutputTextureCoord23EXT = unchecked((uint)0x87B4),

    [NativeName("GL_OUTPUT_TEXTURE_COORD24_EXT")]
    OutputTextureCoord24EXT = unchecked((uint)0x87B5),

    [NativeName("GL_OUTPUT_TEXTURE_COORD25_EXT")]
    OutputTextureCoord25EXT = unchecked((uint)0x87B6),

    [NativeName("GL_OUTPUT_TEXTURE_COORD26_EXT")]
    OutputTextureCoord26EXT = unchecked((uint)0x87B7),

    [NativeName("GL_OUTPUT_TEXTURE_COORD27_EXT")]
    OutputTextureCoord27EXT = unchecked((uint)0x87B8),

    [NativeName("GL_OUTPUT_TEXTURE_COORD28_EXT")]
    OutputTextureCoord28EXT = unchecked((uint)0x87B9),

    [NativeName("GL_OUTPUT_TEXTURE_COORD29_EXT")]
    OutputTextureCoord29EXT = unchecked((uint)0x87BA),

    [NativeName("GL_OUTPUT_TEXTURE_COORD30_EXT")]
    OutputTextureCoord30EXT = unchecked((uint)0x87BB),

    [NativeName("GL_OUTPUT_TEXTURE_COORD31_EXT")]
    OutputTextureCoord31EXT = unchecked((uint)0x87BC),

    [NativeName("GL_OUTPUT_FOG_EXT")]
    OutputFogEXT = unchecked((uint)0x87BD),

    [NativeName("GL_SCALAR_EXT")]
    ScalarEXT = unchecked((uint)0x87BE),

    [NativeName("GL_VECTOR_EXT")]
    VectorEXT = unchecked((uint)0x87BF),

    [NativeName("GL_MATRIX_EXT")]
    MatrixEXT = unchecked((uint)0x87C0),

    [NativeName("GL_VARIANT_EXT")]
    VariantEXT = unchecked((uint)0x87C1),

    [NativeName("GL_INVARIANT_EXT")]
    InvariantEXT = unchecked((uint)0x87C2),

    [NativeName("GL_LOCAL_CONSTANT_EXT")]
    LocalConstantEXT = unchecked((uint)0x87C3),

    [NativeName("GL_LOCAL_EXT")]
    LocalEXT = unchecked((uint)0x87C4),

    [NativeName("GL_MAX_VERTEX_SHADER_INSTRUCTIONS_EXT")]
    MaxVertexShaderInstructionsEXT = unchecked((uint)0x87C5),

    [NativeName("GL_MAX_VERTEX_SHADER_VARIANTS_EXT")]
    MaxVertexShaderVariantsEXT = unchecked((uint)0x87C6),

    [NativeName("GL_MAX_VERTEX_SHADER_INVARIANTS_EXT")]
    MaxVertexShaderInvariantsEXT = unchecked((uint)0x87C7),

    [NativeName("GL_MAX_VERTEX_SHADER_LOCAL_CONSTANTS_EXT")]
    MaxVertexShaderLocalConstantsEXT = unchecked((uint)0x87C8),

    [NativeName("GL_MAX_VERTEX_SHADER_LOCALS_EXT")]
    MaxVertexShaderLocalsEXT = unchecked((uint)0x87C9),

    [NativeName("GL_MAX_OPTIMIZED_VERTEX_SHADER_INSTRUCTIONS_EXT")]
    MaxOptimizedVertexShaderInstructionsEXT = unchecked((uint)0x87CA),

    [NativeName("GL_MAX_OPTIMIZED_VERTEX_SHADER_VARIANTS_EXT")]
    MaxOptimizedVertexShaderVariantsEXT = unchecked((uint)0x87CB),

    [NativeName("GL_MAX_OPTIMIZED_VERTEX_SHADER_LOCAL_CONSTANTS_EXT")]
    MaxOptimizedVertexShaderLocalConstantsEXT = unchecked((uint)0x87CC),

    [NativeName("GL_MAX_OPTIMIZED_VERTEX_SHADER_INVARIANTS_EXT")]
    MaxOptimizedVertexShaderInvariantsEXT = unchecked((uint)0x87CD),

    [NativeName("GL_MAX_OPTIMIZED_VERTEX_SHADER_LOCALS_EXT")]
    MaxOptimizedVertexShaderLocalsEXT = unchecked((uint)0x87CE),

    [NativeName("GL_VERTEX_SHADER_INSTRUCTIONS_EXT")]
    VertexShaderInstructionsEXT = unchecked((uint)0x87CF),

    [NativeName("GL_VERTEX_SHADER_VARIANTS_EXT")]
    VertexShaderVariantsEXT = unchecked((uint)0x87D0),

    [NativeName("GL_VERTEX_SHADER_INVARIANTS_EXT")]
    VertexShaderInvariantsEXT = unchecked((uint)0x87D1),

    [NativeName("GL_VERTEX_SHADER_LOCAL_CONSTANTS_EXT")]
    VertexShaderLocalConstantsEXT = unchecked((uint)0x87D2),

    [NativeName("GL_VERTEX_SHADER_LOCALS_EXT")]
    VertexShaderLocalsEXT = unchecked((uint)0x87D3),

    [NativeName("GL_VERTEX_SHADER_OPTIMIZED_EXT")]
    VertexShaderOptimizedEXT = unchecked((uint)0x87D4),

    [NativeName("GL_X_EXT")]
    Xext = unchecked((uint)0x87D5),

    [NativeName("GL_Y_EXT")]
    Yext = unchecked((uint)0x87D6),

    [NativeName("GL_Z_EXT")]
    Zext = unchecked((uint)0x87D7),

    [NativeName("GL_W_EXT")]
    Wext = unchecked((uint)0x87D8),

    [NativeName("GL_NEGATIVE_X_EXT")]
    NegativeXEXT = unchecked((uint)0x87D9),

    [NativeName("GL_NEGATIVE_Y_EXT")]
    NegativeYEXT = unchecked((uint)0x87DA),

    [NativeName("GL_NEGATIVE_Z_EXT")]
    NegativeZEXT = unchecked((uint)0x87DB),

    [NativeName("GL_NEGATIVE_W_EXT")]
    NegativeWEXT = unchecked((uint)0x87DC),

    [NativeName("GL_ZERO_EXT")]
    ZeroEXT = unchecked((uint)0x87DD),

    [NativeName("GL_ONE_EXT")]
    OneEXT = unchecked((uint)0x87DE),

    [NativeName("GL_NEGATIVE_ONE_EXT")]
    NegativeOneEXT = unchecked((uint)0x87DF),

    [NativeName("GL_NORMALIZED_RANGE_EXT")]
    NormalizedRangeEXT = unchecked((uint)0x87E0),

    [NativeName("GL_FULL_RANGE_EXT")]
    FullRangeEXT = unchecked((uint)0x87E1),

    [NativeName("GL_CURRENT_VERTEX_EXT")]
    CurrentVertexEXT = unchecked((uint)0x87E2),

    [NativeName("GL_MVP_MATRIX_EXT")]
    MvpMatrixEXT = unchecked((uint)0x87E3),

    [NativeName("GL_VARIANT_VALUE_EXT")]
    VariantValueEXT = unchecked((uint)0x87E4),

    [NativeName("GL_VARIANT_DATATYPE_EXT")]
    VariantDatatypeEXT = unchecked((uint)0x87E5),

    [NativeName("GL_VARIANT_ARRAY_STRIDE_EXT")]
    VariantArrayStrideEXT = unchecked((uint)0x87E6),

    [NativeName("GL_VARIANT_ARRAY_TYPE_EXT")]
    VariantArrayTypeEXT = unchecked((uint)0x87E7),

    [NativeName("GL_VARIANT_ARRAY_EXT")]
    VariantArrayEXT = unchecked((uint)0x87E8),

    [NativeName("GL_VARIANT_ARRAY_POINTER_EXT")]
    VariantArrayPointerEXT = unchecked((uint)0x87E9),

    [NativeName("GL_INVARIANT_VALUE_EXT")]
    InvariantValueEXT = unchecked((uint)0x87EA),

    [NativeName("GL_INVARIANT_DATATYPE_EXT")]
    InvariantDatatypeEXT = unchecked((uint)0x87EB),

    [NativeName("GL_LOCAL_CONSTANT_VALUE_EXT")]
    LocalConstantValueEXT = unchecked((uint)0x87EC),

    [NativeName("GL_LOCAL_CONSTANT_DATATYPE_EXT")]
    LocalConstantDatatypeEXT = unchecked((uint)0x87ED),

    [NativeName("GL_MODELVIEW0_STACK_DEPTH_EXT")]
    Modelview0StackDepthEXT = unchecked((uint)0x0BA3),

    [NativeName("GL_MODELVIEW1_STACK_DEPTH_EXT")]
    Modelview1StackDepthEXT = unchecked((uint)0x8502),

    [NativeName("GL_MODELVIEW0_MATRIX_EXT")]
    Modelview0MatrixEXT = unchecked((uint)0x0BA6),

    [NativeName("GL_MODELVIEW1_MATRIX_EXT")]
    Modelview1MatrixEXT = unchecked((uint)0x8506),

    [NativeName("GL_VERTEX_WEIGHTING_EXT")]
    VertexWeightingEXT = unchecked((uint)0x8509),

    [NativeName("GL_MODELVIEW0_EXT")]
    Modelview0EXT = unchecked((uint)0x1700),

    [NativeName("GL_MODELVIEW1_EXT")]
    Modelview1EXT = unchecked((uint)0x850A),

    [NativeName("GL_CURRENT_VERTEX_WEIGHT_EXT")]
    CurrentVertexWeightEXT = unchecked((uint)0x850B),

    [NativeName("GL_VERTEX_WEIGHT_ARRAY_EXT")]
    VertexWeightArrayEXT = unchecked((uint)0x850C),

    [NativeName("GL_VERTEX_WEIGHT_ARRAY_SIZE_EXT")]
    VertexWeightArraySizeEXT = unchecked((uint)0x850D),

    [NativeName("GL_VERTEX_WEIGHT_ARRAY_TYPE_EXT")]
    VertexWeightArrayTypeEXT = unchecked((uint)0x850E),

    [NativeName("GL_VERTEX_WEIGHT_ARRAY_STRIDE_EXT")]
    VertexWeightArrayStrideEXT = unchecked((uint)0x850F),

    [NativeName("GL_VERTEX_WEIGHT_ARRAY_POINTER_EXT")]
    VertexWeightArrayPointerEXT = unchecked((uint)0x8510),

    [NativeName("GL_INCLUSIVE_EXT")]
    InclusiveEXT = unchecked((uint)0x8F10),

    [NativeName("GL_EXCLUSIVE_EXT")]
    ExclusiveEXT = unchecked((uint)0x8F11),

    [NativeName("GL_WINDOW_RECTANGLE_EXT")]
    WindowRectangleEXT = unchecked((uint)0x8F12),

    [NativeName("GL_WINDOW_RECTANGLE_MODE_EXT")]
    WindowRectangleModeEXT = unchecked((uint)0x8F13),

    [NativeName("GL_MAX_WINDOW_RECTANGLES_EXT")]
    MaxWindowRectanglesEXT = unchecked((uint)0x8F14),

    [NativeName("GL_NUM_WINDOW_RECTANGLES_EXT")]
    NumWindowRectanglesEXT = unchecked((uint)0x8F15),

    [NativeName("GL_SYNC_X11_FENCE_EXT")]
    SyncX11FenceEXT = unchecked((uint)0x90E1),

    [NativeName("GL_IGNORE_BORDER_HP")]
    IgnoreBorderHP = unchecked((uint)0x8150),

    [NativeName("GL_CONSTANT_BORDER_HP")]
    ConstantBorderHP = unchecked((uint)0x8151),

    [NativeName("GL_REPLICATE_BORDER_HP")]
    ReplicateBorderHP = unchecked((uint)0x8153),

    [NativeName("GL_CONVOLUTION_BORDER_COLOR_HP")]
    ConvolutionBorderColorHP = unchecked((uint)0x8154),

    [NativeName("GL_IMAGE_SCALE_X_HP")]
    ImageScaleXHP = unchecked((uint)0x8155),

    [NativeName("GL_IMAGE_SCALE_Y_HP")]
    ImageScaleYHP = unchecked((uint)0x8156),

    [NativeName("GL_IMAGE_TRANSLATE_X_HP")]
    ImageTranslateXHP = unchecked((uint)0x8157),

    [NativeName("GL_IMAGE_TRANSLATE_Y_HP")]
    ImageTranslateYHP = unchecked((uint)0x8158),

    [NativeName("GL_IMAGE_ROTATE_ANGLE_HP")]
    ImageRotateAngleHP = unchecked((uint)0x8159),

    [NativeName("GL_IMAGE_ROTATE_ORIGIN_X_HP")]
    ImageRotateOriginXHP = unchecked((uint)0x815A),

    [NativeName("GL_IMAGE_ROTATE_ORIGIN_Y_HP")]
    ImageRotateOriginYHP = unchecked((uint)0x815B),

    [NativeName("GL_IMAGE_MAG_FILTER_HP")]
    ImageMagFilterHP = unchecked((uint)0x815C),

    [NativeName("GL_IMAGE_MIN_FILTER_HP")]
    ImageMinFilterHP = unchecked((uint)0x815D),

    [NativeName("GL_IMAGE_CUBIC_WEIGHT_HP")]
    ImageCubicWeightHP = unchecked((uint)0x815E),

    [NativeName("GL_CUBIC_HP")]
    CubicHP = unchecked((uint)0x815F),

    [NativeName("GL_AVERAGE_HP")]
    AverageHP = unchecked((uint)0x8160),

    [NativeName("GL_IMAGE_TRANSFORM_2D_HP")]
    ImageTransform2DHP = unchecked((uint)0x8161),

    [NativeName("GL_POST_IMAGE_TRANSFORM_COLOR_TABLE_HP")]
    PostImageTransformColorTableHP = unchecked((uint)0x8162),

    [NativeName("GL_PROXY_POST_IMAGE_TRANSFORM_COLOR_TABLE_HP")]
    ProxyPostImageTransformColorTableHP = unchecked((uint)0x8163),

    [NativeName("GL_OCCLUSION_TEST_HP")]
    OcclusionTestHP = unchecked((uint)0x8165),

    [NativeName("GL_OCCLUSION_TEST_RESULT_HP")]
    OcclusionTestResultHP = unchecked((uint)0x8166),

    [NativeName("GL_TEXTURE_LIGHTING_MODE_HP")]
    TextureLightingModeHP = unchecked((uint)0x8167),

    [NativeName("GL_TEXTURE_POST_SPECULAR_HP")]
    TexturePostSpecularHP = unchecked((uint)0x8168),

    [NativeName("GL_TEXTURE_PRE_SPECULAR_HP")]
    TexturePreSpecularHP = unchecked((uint)0x8169),

    [NativeName("GL_CULL_VERTEX_IBM")]
    CullVertexIBM = unchecked((uint)103050),

    [NativeName("GL_RASTER_POSITION_UNCLIPPED_IBM")]
    RasterPositionUnclippedIBM = unchecked((uint)0x19262),

    [NativeName("GL_ALL_STATIC_DATA_IBM")]
    AllStaticDataIBM = unchecked((uint)103060),

    [NativeName("GL_STATIC_VERTEX_ARRAY_IBM")]
    StaticVertexArrayIBM = unchecked((uint)103061),

    [NativeName("GL_MIRRORED_REPEAT_IBM")]
    MirroredRepeatIBM = unchecked((uint)0x8370),

    [NativeName("GL_VERTEX_ARRAY_LIST_IBM")]
    VertexArrayListIBM = unchecked((uint)103070),

    [NativeName("GL_NORMAL_ARRAY_LIST_IBM")]
    NormalArrayListIBM = unchecked((uint)103071),

    [NativeName("GL_COLOR_ARRAY_LIST_IBM")]
    ColorArrayListIBM = unchecked((uint)103072),

    [NativeName("GL_INDEX_ARRAY_LIST_IBM")]
    IndexArrayListIBM = unchecked((uint)103073),

    [NativeName("GL_TEXTURE_COORD_ARRAY_LIST_IBM")]
    TextureCoordArrayListIBM = unchecked((uint)103074),

    [NativeName("GL_EDGE_FLAG_ARRAY_LIST_IBM")]
    EdgeFlagArrayListIBM = unchecked((uint)103075),

    [NativeName("GL_FOG_COORDINATE_ARRAY_LIST_IBM")]
    FogCoordinateArrayListIBM = unchecked((uint)103076),

    [NativeName("GL_SECONDARY_COLOR_ARRAY_LIST_IBM")]
    SecondaryColorArrayListIBM = unchecked((uint)103077),

    [NativeName("GL_VERTEX_ARRAY_LIST_STRIDE_IBM")]
    VertexArrayListStrideIBM = unchecked((uint)103080),

    [NativeName("GL_NORMAL_ARRAY_LIST_STRIDE_IBM")]
    NormalArrayListStrideIBM = unchecked((uint)103081),

    [NativeName("GL_COLOR_ARRAY_LIST_STRIDE_IBM")]
    ColorArrayListStrideIBM = unchecked((uint)103082),

    [NativeName("GL_INDEX_ARRAY_LIST_STRIDE_IBM")]
    IndexArrayListStrideIBM = unchecked((uint)103083),

    [NativeName("GL_TEXTURE_COORD_ARRAY_LIST_STRIDE_IBM")]
    TextureCoordArrayListStrideIBM = unchecked((uint)103084),

    [NativeName("GL_EDGE_FLAG_ARRAY_LIST_STRIDE_IBM")]
    EdgeFlagArrayListStrideIBM = unchecked((uint)103085),

    [NativeName("GL_FOG_COORDINATE_ARRAY_LIST_STRIDE_IBM")]
    FogCoordinateArrayListStrideIBM = unchecked((uint)103086),

    [NativeName("GL_SECONDARY_COLOR_ARRAY_LIST_STRIDE_IBM")]
    SecondaryColorArrayListStrideIBM = unchecked((uint)103087),

    [NativeName("GL_RED_MIN_CLAMP_INGR")]
    RedMinClampINGR = unchecked((uint)0x8560),

    [NativeName("GL_GREEN_MIN_CLAMP_INGR")]
    GreenMinClampINGR = unchecked((uint)0x8561),

    [NativeName("GL_BLUE_MIN_CLAMP_INGR")]
    BlueMinClampINGR = unchecked((uint)0x8562),

    [NativeName("GL_ALPHA_MIN_CLAMP_INGR")]
    AlphaMinClampINGR = unchecked((uint)0x8563),

    [NativeName("GL_RED_MAX_CLAMP_INGR")]
    RedMaxClampINGR = unchecked((uint)0x8564),

    [NativeName("GL_GREEN_MAX_CLAMP_INGR")]
    GreenMaxClampINGR = unchecked((uint)0x8565),

    [NativeName("GL_BLUE_MAX_CLAMP_INGR")]
    BlueMaxClampINGR = unchecked((uint)0x8566),

    [NativeName("GL_ALPHA_MAX_CLAMP_INGR")]
    AlphaMaxClampINGR = unchecked((uint)0x8567),

    [NativeName("GL_INTERLACE_READ_INGR")]
    InterlaceReadINGR = unchecked((uint)0x8568),

    [NativeName("GL_BLACKHOLE_RENDER_INTEL")]
    BlackholeRenderINTEL = unchecked((uint)0x83FC),

    [NativeName("GL_CONSERVATIVE_RASTERIZATION_INTEL")]
    ConservativeRasterizationINTEL = unchecked((uint)0x83FE),

    [NativeName("GL_TEXTURE_MEMORY_LAYOUT_INTEL")]
    TextureMemoryLayoutINTEL = unchecked((uint)0x83FF),

    [NativeName("GL_LAYOUT_DEFAULT_INTEL")]
    LayoutDefaultINTEL = unchecked((uint)0),

    [NativeName("GL_LAYOUT_LINEAR_INTEL")]
    LayoutLinearINTEL = unchecked((uint)1),

    [NativeName("GL_LAYOUT_LINEAR_CPU_CACHED_INTEL")]
    LayoutLinearCpuCachedINTEL = unchecked((uint)2),

    [NativeName("GL_PARALLEL_ARRAYS_INTEL")]
    ParallelArraysINTEL = unchecked((uint)0x83F4),

    [NativeName("GL_VERTEX_ARRAY_PARALLEL_POINTERS_INTEL")]
    VertexArrayParallelPointersINTEL = unchecked((uint)0x83F5),

    [NativeName("GL_NORMAL_ARRAY_PARALLEL_POINTERS_INTEL")]
    NormalArrayParallelPointersINTEL = unchecked((uint)0x83F6),

    [NativeName("GL_COLOR_ARRAY_PARALLEL_POINTERS_INTEL")]
    ColorArrayParallelPointersINTEL = unchecked((uint)0x83F7),

    [NativeName("GL_TEXTURE_COORD_ARRAY_PARALLEL_POINTERS_INTEL")]
    TextureCoordArrayParallelPointersINTEL = unchecked((uint)0x83F8),

    [NativeName("GL_PERFQUERY_SINGLE_CONTEXT_INTEL")]
    PerfquerySingleContextINTEL = unchecked((uint)0x00000000),

    [NativeName("GL_PERFQUERY_GLOBAL_CONTEXT_INTEL")]
    PerfqueryGlobalContextINTEL = unchecked((uint)0x00000001),

    [NativeName("GL_PERFQUERY_WAIT_INTEL")]
    PerfqueryWaitINTEL = unchecked((uint)0x83FB),

    [NativeName("GL_PERFQUERY_FLUSH_INTEL")]
    PerfqueryFlushINTEL = unchecked((uint)0x83FA),

    [NativeName("GL_PERFQUERY_DONOT_FLUSH_INTEL")]
    PerfqueryDonotFlushINTEL = unchecked((uint)0x83F9),

    [NativeName("GL_PERFQUERY_COUNTER_EVENT_INTEL")]
    PerfqueryCounterEventINTEL = unchecked((uint)0x94F0),

    [NativeName("GL_PERFQUERY_COUNTER_DURATION_NORM_INTEL")]
    PerfqueryCounterDurationNormINTEL = unchecked((uint)0x94F1),

    [NativeName("GL_PERFQUERY_COUNTER_DURATION_RAW_INTEL")]
    PerfqueryCounterDurationRawINTEL = unchecked((uint)0x94F2),

    [NativeName("GL_PERFQUERY_COUNTER_THROUGHPUT_INTEL")]
    PerfqueryCounterThroughputINTEL = unchecked((uint)0x94F3),

    [NativeName("GL_PERFQUERY_COUNTER_RAW_INTEL")]
    PerfqueryCounterRawINTEL = unchecked((uint)0x94F4),

    [NativeName("GL_PERFQUERY_COUNTER_TIMESTAMP_INTEL")]
    PerfqueryCounterTimestampINTEL = unchecked((uint)0x94F5),

    [NativeName("GL_PERFQUERY_COUNTER_DATA_UINT32_INTEL")]
    PerfqueryCounterDataUint32INTEL = unchecked((uint)0x94F8),

    [NativeName("GL_PERFQUERY_COUNTER_DATA_UINT64_INTEL")]
    PerfqueryCounterDataUint64INTEL = unchecked((uint)0x94F9),

    [NativeName("GL_PERFQUERY_COUNTER_DATA_FLOAT_INTEL")]
    PerfqueryCounterDataFloatINTEL = unchecked((uint)0x94FA),

    [NativeName("GL_PERFQUERY_COUNTER_DATA_DOUBLE_INTEL")]
    PerfqueryCounterDataDoubleINTEL = unchecked((uint)0x94FB),

    [NativeName("GL_PERFQUERY_COUNTER_DATA_BOOL32_INTEL")]
    PerfqueryCounterDataBool32INTEL = unchecked((uint)0x94FC),

    [NativeName("GL_PERFQUERY_QUERY_NAME_LENGTH_MAX_INTEL")]
    PerfqueryQueryNameLengthMaxINTEL = unchecked((uint)0x94FD),

    [NativeName("GL_PERFQUERY_COUNTER_NAME_LENGTH_MAX_INTEL")]
    PerfqueryCounterNameLengthMaxINTEL = unchecked((uint)0x94FE),

    [NativeName("GL_PERFQUERY_COUNTER_DESC_LENGTH_MAX_INTEL")]
    PerfqueryCounterDescLengthMaxINTEL = unchecked((uint)0x94FF),

    [NativeName("GL_PERFQUERY_GPA_EXTENDED_COUNTERS_INTEL")]
    PerfqueryGpaExtendedCountersINTEL = unchecked((uint)0x9500),

    [NativeName("GL_TEXTURE_1D_STACK_MESAX")]
    Texture1DStackMESAX = unchecked((uint)0x8759),

    [NativeName("GL_TEXTURE_2D_STACK_MESAX")]
    Texture2DStackMESAX = unchecked((uint)0x875A),

    [NativeName("GL_PROXY_TEXTURE_1D_STACK_MESAX")]
    ProxyTexture1DStackMESAX = unchecked((uint)0x875B),

    [NativeName("GL_PROXY_TEXTURE_2D_STACK_MESAX")]
    ProxyTexture2DStackMESAX = unchecked((uint)0x875C),

    [NativeName("GL_TEXTURE_1D_STACK_BINDING_MESAX")]
    Texture1DStackBindingMESAX = unchecked((uint)0x875D),

    [NativeName("GL_TEXTURE_2D_STACK_BINDING_MESAX")]
    Texture2DStackBindingMESAX = unchecked((uint)0x875E),

    [NativeName("GL_FRAMEBUFFER_FLIP_X_MESA")]
    FramebufferFlipXMESA = unchecked((uint)0x8BBC),

    [NativeName("GL_FRAMEBUFFER_FLIP_Y_MESA")]
    FramebufferFlipYMESA = unchecked((uint)0x8BBB),

    [NativeName("GL_FRAMEBUFFER_SWAP_XY_MESA")]
    FramebufferSwapXyMESA = unchecked((uint)0x8BBD),

    [NativeName("GL_PACK_INVERT_MESA")]
    PackInvertMESA = unchecked((uint)0x8758),

    [NativeName("GL_PROGRAM_BINARY_FORMAT_MESA")]
    ProgramBinaryFormatMESA = unchecked((uint)0x875F),

    [NativeName("GL_TILE_RASTER_ORDER_FIXED_MESA")]
    TileRasterOrderFixedMESA = unchecked((uint)0x8BB8),

    [NativeName("GL_TILE_RASTER_ORDER_INCREASING_X_MESA")]
    TileRasterOrderIncreasingXMESA = unchecked((uint)0x8BB9),

    [NativeName("GL_TILE_RASTER_ORDER_INCREASING_Y_MESA")]
    TileRasterOrderIncreasingYMESA = unchecked((uint)0x8BBA),

    [NativeName("GL_UNSIGNED_SHORT_8_8_MESA")]
    UnsignedShort8X8MESA = unchecked((uint)0x85BA),

    [NativeName("GL_UNSIGNED_SHORT_8_8_REV_MESA")]
    UnsignedShort8X8RevMESA = unchecked((uint)0x85BB),

    [NativeName("GL_YCBCR_MESA")]
    YcbcrMESA = unchecked((uint)0x8757),

    [NativeName("GL_GPU_MEMORY_INFO_DEDICATED_VIDMEM_NVX")]
    GpuMemoryInfoDedicatedVidmemNVX = unchecked((uint)0x9047),

    [NativeName("GL_GPU_MEMORY_INFO_TOTAL_AVAILABLE_MEMORY_NVX")]
    GpuMemoryInfoTotalAvailableMemoryNVX = unchecked((uint)0x9048),

    [NativeName("GL_GPU_MEMORY_INFO_CURRENT_AVAILABLE_VIDMEM_NVX")]
    GpuMemoryInfoCurrentAvailableVidmemNVX = unchecked((uint)0x9049),

    [NativeName("GL_GPU_MEMORY_INFO_EVICTION_COUNT_NVX")]
    GpuMemoryInfoEvictionCountNVX = unchecked((uint)0x904A),

    [NativeName("GL_GPU_MEMORY_INFO_EVICTED_MEMORY_NVX")]
    GpuMemoryInfoEvictedMemoryNVX = unchecked((uint)0x904B),

    [NativeName("GL_UPLOAD_GPU_MASK_NVX")]
    UploadGpuMaskNVX = unchecked((uint)0x954A),

    [NativeName("GL_LGPU_SEPARATE_STORAGE_BIT_NVX")]
    LgpuSeparateStorageBitNVX = unchecked((uint)0x0800),

    [NativeName("GL_MAX_LGPU_GPUS_NVX")]
    MaxLgpuGpusNVX = unchecked((uint)0x92BA),

    [NativeName("GL_ALPHA_TO_COVERAGE_DITHER_DEFAULT_NV")]
    AlphaToCoverageDitherDefaultNV = unchecked((uint)0x934D),

    [NativeName("GL_ALPHA_TO_COVERAGE_DITHER_ENABLE_NV")]
    AlphaToCoverageDitherEnableNV = unchecked((uint)0x934E),

    [NativeName("GL_ALPHA_TO_COVERAGE_DITHER_DISABLE_NV")]
    AlphaToCoverageDitherDisableNV = unchecked((uint)0x934F),

    [NativeName("GL_ALPHA_TO_COVERAGE_DITHER_MODE_NV")]
    AlphaToCoverageDitherModeNV = unchecked((uint)0x92BF),

    [NativeName("GL_BLEND_OVERLAP_NV")]
    BlendOverlapNV = unchecked((uint)0x9281),

    [NativeName("GL_BLEND_PREMULTIPLIED_SRC_NV")]
    BlendPremultipliedSrcNV = unchecked((uint)0x9280),

    [NativeName("GL_BLUE_NV")]
    BlueNV = unchecked((uint)0x1905),

    [NativeName("GL_COLORBURN_NV")]
    ColorburnNV = unchecked((uint)0x929A),

    [NativeName("GL_COLORDODGE_NV")]
    ColordodgeNV = unchecked((uint)0x9299),

    [NativeName("GL_CONJOINT_NV")]
    ConjointNV = unchecked((uint)0x9284),

    [NativeName("GL_CONTRAST_NV")]
    ContrastNV = unchecked((uint)0x92A1),

    [NativeName("GL_DARKEN_NV")]
    DarkenNV = unchecked((uint)0x9297),

    [NativeName("GL_DIFFERENCE_NV")]
    DifferenceNV = unchecked((uint)0x929E),

    [NativeName("GL_DISJOINT_NV")]
    DisjointNV = unchecked((uint)0x9283),

    [NativeName("GL_DST_ATOP_NV")]
    DstAtopNV = unchecked((uint)0x928F),

    [NativeName("GL_DST_IN_NV")]
    DstInNV = unchecked((uint)0x928B),

    [NativeName("GL_DST_NV")]
    DstNV = unchecked((uint)0x9287),

    [NativeName("GL_DST_OUT_NV")]
    DstOutNV = unchecked((uint)0x928D),

    [NativeName("GL_DST_OVER_NV")]
    DstOverNV = unchecked((uint)0x9289),

    [NativeName("GL_EXCLUSION_NV")]
    ExclusionNV = unchecked((uint)0x92A0),

    [NativeName("GL_GREEN_NV")]
    GreenNV = unchecked((uint)0x1904),

    [NativeName("GL_HARDLIGHT_NV")]
    HardlightNV = unchecked((uint)0x929B),

    [NativeName("GL_HARDMIX_NV")]
    HardmixNV = unchecked((uint)0x92A9),

    [NativeName("GL_HSL_COLOR_NV")]
    HslColorNV = unchecked((uint)0x92AF),

    [NativeName("GL_HSL_HUE_NV")]
    HslHueNV = unchecked((uint)0x92AD),

    [NativeName("GL_HSL_LUMINOSITY_NV")]
    HslLuminosityNV = unchecked((uint)0x92B0),

    [NativeName("GL_HSL_SATURATION_NV")]
    HslSaturationNV = unchecked((uint)0x92AE),

    [NativeName("GL_INVERT_OVG_NV")]
    InvertOvgNV = unchecked((uint)0x92B4),

    [NativeName("GL_INVERT_RGB_NV")]
    InvertRgbNV = unchecked((uint)0x92A3),

    [NativeName("GL_LIGHTEN_NV")]
    LightenNV = unchecked((uint)0x9298),

    [NativeName("GL_LINEARBURN_NV")]
    LinearburnNV = unchecked((uint)0x92A5),

    [NativeName("GL_LINEARDODGE_NV")]
    LineardodgeNV = unchecked((uint)0x92A4),

    [NativeName("GL_LINEARLIGHT_NV")]
    LinearlightNV = unchecked((uint)0x92A7),

    [NativeName("GL_MINUS_CLAMPED_NV")]
    MinusClampedNV = unchecked((uint)0x92B3),

    [NativeName("GL_MINUS_NV")]
    MinusNV = unchecked((uint)0x929F),

    [NativeName("GL_MULTIPLY_NV")]
    MultiplyNV = unchecked((uint)0x9294),

    [NativeName("GL_OVERLAY_NV")]
    OverlayNV = unchecked((uint)0x9296),

    [NativeName("GL_PINLIGHT_NV")]
    PinlightNV = unchecked((uint)0x92A8),

    [NativeName("GL_PLUS_CLAMPED_ALPHA_NV")]
    PlusClampedAlphaNV = unchecked((uint)0x92B2),

    [NativeName("GL_PLUS_CLAMPED_NV")]
    PlusClampedNV = unchecked((uint)0x92B1),

    [NativeName("GL_PLUS_DARKER_NV")]
    PlusDarkerNV = unchecked((uint)0x9292),

    [NativeName("GL_PLUS_NV")]
    PlusNV = unchecked((uint)0x9291),

    [NativeName("GL_RED_NV")]
    RedNV = unchecked((uint)0x1903),

    [NativeName("GL_SCREEN_NV")]
    ScreenNV = unchecked((uint)0x9295),

    [NativeName("GL_SOFTLIGHT_NV")]
    SoftlightNV = unchecked((uint)0x929C),

    [NativeName("GL_SRC_ATOP_NV")]
    SrcAtopNV = unchecked((uint)0x928E),

    [NativeName("GL_SRC_IN_NV")]
    SrcInNV = unchecked((uint)0x928A),

    [NativeName("GL_SRC_NV")]
    SrcNV = unchecked((uint)0x9286),

    [NativeName("GL_SRC_OUT_NV")]
    SrcOutNV = unchecked((uint)0x928C),

    [NativeName("GL_SRC_OVER_NV")]
    SrcOverNV = unchecked((uint)0x9288),

    [NativeName("GL_UNCORRELATED_NV")]
    UncorrelatedNV = unchecked((uint)0x9282),

    [NativeName("GL_VIVIDLIGHT_NV")]
    VividlightNV = unchecked((uint)0x92A6),

    [NativeName("GL_XOR_NV")]
    XorNV = unchecked((uint)0x1506),

    [NativeName("GL_BLEND_ADVANCED_COHERENT_NV")]
    BlendAdvancedCoherentNV = unchecked((uint)0x9285),

    [NativeName("GL_VIEWPORT_POSITION_W_SCALE_NV")]
    ViewportPositionWScaleNV = unchecked((uint)0x937C),

    [NativeName("GL_VIEWPORT_POSITION_W_SCALE_X_COEFF_NV")]
    ViewportPositionWScaleXCoeffNV = unchecked((uint)0x937D),

    [NativeName("GL_VIEWPORT_POSITION_W_SCALE_Y_COEFF_NV")]
    ViewportPositionWScaleYCoeffNV = unchecked((uint)0x937E),

    [NativeName("GL_TERMINATE_SEQUENCE_COMMAND_NV")]
    TerminateSequenceCommandNV = unchecked((uint)0x0000),

    [NativeName("GL_NOP_COMMAND_NV")]
    NopCommandNV = unchecked((uint)0x0001),

    [NativeName("GL_DRAW_ELEMENTS_COMMAND_NV")]
    DrawElementsCommandNV = unchecked((uint)0x0002),

    [NativeName("GL_DRAW_ARRAYS_COMMAND_NV")]
    DrawArraysCommandNV = unchecked((uint)0x0003),

    [NativeName("GL_DRAW_ELEMENTS_STRIP_COMMAND_NV")]
    DrawElementsStripCommandNV = unchecked((uint)0x0004),

    [NativeName("GL_DRAW_ARRAYS_STRIP_COMMAND_NV")]
    DrawArraysStripCommandNV = unchecked((uint)0x0005),

    [NativeName("GL_DRAW_ELEMENTS_INSTANCED_COMMAND_NV")]
    DrawElementsInstancedCommandNV = unchecked((uint)0x0006),

    [NativeName("GL_DRAW_ARRAYS_INSTANCED_COMMAND_NV")]
    DrawArraysInstancedCommandNV = unchecked((uint)0x0007),

    [NativeName("GL_ELEMENT_ADDRESS_COMMAND_NV")]
    ElementAddressCommandNV = unchecked((uint)0x0008),

    [NativeName("GL_ATTRIBUTE_ADDRESS_COMMAND_NV")]
    AttributeAddressCommandNV = unchecked((uint)0x0009),

    [NativeName("GL_UNIFORM_ADDRESS_COMMAND_NV")]
    UniformAddressCommandNV = unchecked((uint)0x000A),

    [NativeName("GL_BLEND_COLOR_COMMAND_NV")]
    BlendColorCommandNV = unchecked((uint)0x000B),

    [NativeName("GL_STENCIL_REF_COMMAND_NV")]
    StencilRefCommandNV = unchecked((uint)0x000C),

    [NativeName("GL_LINE_WIDTH_COMMAND_NV")]
    LineWidthCommandNV = unchecked((uint)0x000D),

    [NativeName("GL_POLYGON_OFFSET_COMMAND_NV")]
    PolygonOffsetCommandNV = unchecked((uint)0x000E),

    [NativeName("GL_ALPHA_REF_COMMAND_NV")]
    AlphaRefCommandNV = unchecked((uint)0x000F),

    [NativeName("GL_VIEWPORT_COMMAND_NV")]
    ViewportCommandNV = unchecked((uint)0x0010),

    [NativeName("GL_SCISSOR_COMMAND_NV")]
    ScissorCommandNV = unchecked((uint)0x0011),

    [NativeName("GL_FRONT_FACE_COMMAND_NV")]
    FrontFaceCommandNV = unchecked((uint)0x0012),

    [NativeName("GL_COMPUTE_PROGRAM_NV")]
    ComputeProgramNV = unchecked((uint)0x90FB),

    [NativeName("GL_COMPUTE_PROGRAM_PARAMETER_BUFFER_NV")]
    ComputeProgramParameterBufferNV = unchecked((uint)0x90FC),

    [NativeName("GL_QUERY_WAIT_NV")]
    QueryWaitNV = unchecked((uint)0x8E13),

    [NativeName("GL_QUERY_NO_WAIT_NV")]
    QueryNoWaitNV = unchecked((uint)0x8E14),

    [NativeName("GL_QUERY_BY_REGION_WAIT_NV")]
    QueryByRegionWaitNV = unchecked((uint)0x8E15),

    [NativeName("GL_QUERY_BY_REGION_NO_WAIT_NV")]
    QueryByRegionNoWaitNV = unchecked((uint)0x8E16),

    [NativeName("GL_CONSERVATIVE_RASTERIZATION_NV")]
    ConservativeRasterizationNV = unchecked((uint)0x9346),

    [NativeName("GL_SUBPIXEL_PRECISION_BIAS_X_BITS_NV")]
    SubpixelPrecisionBiasXBitsNV = unchecked((uint)0x9347),

    [NativeName("GL_SUBPIXEL_PRECISION_BIAS_Y_BITS_NV")]
    SubpixelPrecisionBiasYBitsNV = unchecked((uint)0x9348),

    [NativeName("GL_MAX_SUBPIXEL_PRECISION_BIAS_BITS_NV")]
    MaxSubpixelPrecisionBiasBitsNV = unchecked((uint)0x9349),

    [NativeName("GL_CONSERVATIVE_RASTER_DILATE_NV")]
    ConservativeRasterDilateNV = unchecked((uint)0x9379),

    [NativeName("GL_CONSERVATIVE_RASTER_DILATE_RANGE_NV")]
    ConservativeRasterDilateRangeNV = unchecked((uint)0x937A),

    [NativeName("GL_CONSERVATIVE_RASTER_DILATE_GRANULARITY_NV")]
    ConservativeRasterDilateGranularityNV = unchecked((uint)0x937B),

    [NativeName("GL_CONSERVATIVE_RASTER_MODE_PRE_SNAP_NV")]
    ConservativeRasterModePreSnapNV = unchecked((uint)0x9550),

    [NativeName("GL_CONSERVATIVE_RASTER_MODE_NV")]
    ConservativeRasterModeNV = unchecked((uint)0x954D),

    [NativeName("GL_CONSERVATIVE_RASTER_MODE_POST_SNAP_NV")]
    ConservativeRasterModePostSnapNV = unchecked((uint)0x954E),

    [NativeName("GL_CONSERVATIVE_RASTER_MODE_PRE_SNAP_TRIANGLES_NV")]
    ConservativeRasterModePreSnapTrianglesNV = unchecked((uint)0x954F),

    [NativeName("GL_DEPTH_STENCIL_TO_RGBA_NV")]
    DepthStencilToRgbaNV = unchecked((uint)0x886E),

    [NativeName("GL_DEPTH_STENCIL_TO_BGRA_NV")]
    DepthStencilToBgraNV = unchecked((uint)0x886F),

    [NativeName("GL_MAX_DEEP_3D_TEXTURE_WIDTH_HEIGHT_NV")]
    MaxDeep3DTextureWidthHeightNV = unchecked((uint)0x90D0),

    [NativeName("GL_MAX_DEEP_3D_TEXTURE_DEPTH_NV")]
    MaxDeep3DTextureDepthNV = unchecked((uint)0x90D1),

    [NativeName("GL_DEPTH_COMPONENT32F_NV")]
    DepthComponent32FNV = unchecked((uint)0x8DAB),

    [NativeName("GL_DEPTH32F_STENCIL8_NV")]
    Depth32FStencil8NV = unchecked((uint)0x8DAC),

    [NativeName("GL_FLOAT_32_UNSIGNED_INT_24_8_REV_NV")]
    Float32UnsignedInt24X8RevNV = unchecked((uint)0x8DAD),

    [NativeName("GL_DEPTH_BUFFER_FLOAT_MODE_NV")]
    DepthBufferFloatModeNV = unchecked((uint)0x8DAF),

    [NativeName("GL_DEPTH_CLAMP_NV")]
    DepthClampNV = unchecked((uint)0x864F),

    [NativeName("GL_EVAL_2D_NV")]
    Eval2DNV = unchecked((uint)0x86C0),

    [NativeName("GL_EVAL_TRIANGULAR_2D_NV")]
    EvalTriangular2DNV = unchecked((uint)0x86C1),

    [NativeName("GL_MAP_TESSELLATION_NV")]
    MapTessellationNV = unchecked((uint)0x86C2),

    [NativeName("GL_MAP_ATTRIB_U_ORDER_NV")]
    MapAttribUOrderNV = unchecked((uint)0x86C3),

    [NativeName("GL_MAP_ATTRIB_V_ORDER_NV")]
    MapAttribVOrderNV = unchecked((uint)0x86C4),

    [NativeName("GL_EVAL_FRACTIONAL_TESSELLATION_NV")]
    EvalFractionalTessellationNV = unchecked((uint)0x86C5),

    [NativeName("GL_EVAL_VERTEX_ATTRIB0_NV")]
    EvalVertexAttrib0NV = unchecked((uint)0x86C6),

    [NativeName("GL_EVAL_VERTEX_ATTRIB1_NV")]
    EvalVertexAttrib1NV = unchecked((uint)0x86C7),

    [NativeName("GL_EVAL_VERTEX_ATTRIB2_NV")]
    EvalVertexAttrib2NV = unchecked((uint)0x86C8),

    [NativeName("GL_EVAL_VERTEX_ATTRIB3_NV")]
    EvalVertexAttrib3NV = unchecked((uint)0x86C9),

    [NativeName("GL_EVAL_VERTEX_ATTRIB4_NV")]
    EvalVertexAttrib4NV = unchecked((uint)0x86CA),

    [NativeName("GL_EVAL_VERTEX_ATTRIB5_NV")]
    EvalVertexAttrib5NV = unchecked((uint)0x86CB),

    [NativeName("GL_EVAL_VERTEX_ATTRIB6_NV")]
    EvalVertexAttrib6NV = unchecked((uint)0x86CC),

    [NativeName("GL_EVAL_VERTEX_ATTRIB7_NV")]
    EvalVertexAttrib7NV = unchecked((uint)0x86CD),

    [NativeName("GL_EVAL_VERTEX_ATTRIB8_NV")]
    EvalVertexAttrib8NV = unchecked((uint)0x86CE),

    [NativeName("GL_EVAL_VERTEX_ATTRIB9_NV")]
    EvalVertexAttrib9NV = unchecked((uint)0x86CF),

    [NativeName("GL_EVAL_VERTEX_ATTRIB10_NV")]
    EvalVertexAttrib10NV = unchecked((uint)0x86D0),

    [NativeName("GL_EVAL_VERTEX_ATTRIB11_NV")]
    EvalVertexAttrib11NV = unchecked((uint)0x86D1),

    [NativeName("GL_EVAL_VERTEX_ATTRIB12_NV")]
    EvalVertexAttrib12NV = unchecked((uint)0x86D2),

    [NativeName("GL_EVAL_VERTEX_ATTRIB13_NV")]
    EvalVertexAttrib13NV = unchecked((uint)0x86D3),

    [NativeName("GL_EVAL_VERTEX_ATTRIB14_NV")]
    EvalVertexAttrib14NV = unchecked((uint)0x86D4),

    [NativeName("GL_EVAL_VERTEX_ATTRIB15_NV")]
    EvalVertexAttrib15NV = unchecked((uint)0x86D5),

    [NativeName("GL_MAX_MAP_TESSELLATION_NV")]
    MaxMapTessellationNV = unchecked((uint)0x86D6),

    [NativeName("GL_MAX_RATIONAL_EVAL_ORDER_NV")]
    MaxRationalEvalOrderNV = unchecked((uint)0x86D7),

    [NativeName("GL_SAMPLE_POSITION_NV")]
    SamplePositionNV = unchecked((uint)0x8E50),

    [NativeName("GL_SAMPLE_MASK_NV")]
    SampleMaskNV = unchecked((uint)0x8E51),

    [NativeName("GL_SAMPLE_MASK_VALUE_NV")]
    SampleMaskValueNV = unchecked((uint)0x8E52),

    [NativeName("GL_TEXTURE_BINDING_RENDERBUFFER_NV")]
    TextureBindingRenderbufferNV = unchecked((uint)0x8E53),

    [NativeName("GL_TEXTURE_RENDERBUFFER_DATA_STORE_BINDING_NV")]
    TextureRenderbufferDataStoreBindingNV = unchecked((uint)0x8E54),

    [NativeName("GL_TEXTURE_RENDERBUFFER_NV")]
    TextureRenderbufferNV = unchecked((uint)0x8E55),

    [NativeName("GL_SAMPLER_RENDERBUFFER_NV")]
    SamplerRenderbufferNV = unchecked((uint)0x8E56),

    [NativeName("GL_INT_SAMPLER_RENDERBUFFER_NV")]
    IntSamplerRenderbufferNV = unchecked((uint)0x8E57),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_RENDERBUFFER_NV")]
    UnsignedIntSamplerRenderbufferNV = unchecked((uint)0x8E58),

    [NativeName("GL_MAX_SAMPLE_MASK_WORDS_NV")]
    MaxSampleMaskWordsNV = unchecked((uint)0x8E59),

    [NativeName("GL_FILL_RECTANGLE_NV")]
    FillRectangleNV = unchecked((uint)0x933C),

    [NativeName("GL_FLOAT_R_NV")]
    FloatRNV = unchecked((uint)0x8880),

    [NativeName("GL_FLOAT_RG_NV")]
    FloatRgNV = unchecked((uint)0x8881),

    [NativeName("GL_FLOAT_RGB_NV")]
    FloatRgbNV = unchecked((uint)0x8882),

    [NativeName("GL_FLOAT_RGBA_NV")]
    FloatRgbaNV = unchecked((uint)0x8883),

    [NativeName("GL_FLOAT_R16_NV")]
    FloatR16NV = unchecked((uint)0x8884),

    [NativeName("GL_FLOAT_R32_NV")]
    FloatR32NV = unchecked((uint)0x8885),

    [NativeName("GL_FLOAT_RG16_NV")]
    FloatRg16NV = unchecked((uint)0x8886),

    [NativeName("GL_FLOAT_RG32_NV")]
    FloatRg32NV = unchecked((uint)0x8887),

    [NativeName("GL_FLOAT_RGB16_NV")]
    FloatRgb16NV = unchecked((uint)0x8888),

    [NativeName("GL_FLOAT_RGB32_NV")]
    FloatRgb32NV = unchecked((uint)0x8889),

    [NativeName("GL_FLOAT_RGBA16_NV")]
    FloatRgba16NV = unchecked((uint)0x888A),

    [NativeName("GL_FLOAT_RGBA32_NV")]
    FloatRgba32NV = unchecked((uint)0x888B),

    [NativeName("GL_TEXTURE_FLOAT_COMPONENTS_NV")]
    TextureFloatComponentsNV = unchecked((uint)0x888C),

    [NativeName("GL_FLOAT_CLEAR_COLOR_VALUE_NV")]
    FloatClearColorValueNV = unchecked((uint)0x888D),

    [NativeName("GL_FLOAT_RGBA_MODE_NV")]
    FloatRgbaModeNV = unchecked((uint)0x888E),

    [NativeName("GL_FOG_DISTANCE_MODE_NV")]
    FogDistanceModeNV = unchecked((uint)0x855A),

    [NativeName("GL_EYE_RADIAL_NV")]
    EyeRadialNV = unchecked((uint)0x855B),

    [NativeName("GL_EYE_PLANE_ABSOLUTE_NV")]
    EyePlaneAbsoluteNV = unchecked((uint)0x855C),

    [NativeName("GL_FRAGMENT_COVERAGE_TO_COLOR_NV")]
    FragmentCoverageToColorNV = unchecked((uint)0x92DD),

    [NativeName("GL_FRAGMENT_COVERAGE_COLOR_NV")]
    FragmentCoverageColorNV = unchecked((uint)0x92DE),

    [NativeName("GL_MAX_FRAGMENT_PROGRAM_LOCAL_PARAMETERS_NV")]
    MaxFragmentProgramLocalParametersNV = unchecked((uint)0x8868),

    [NativeName("GL_FRAGMENT_PROGRAM_NV")]
    FragmentProgramNV = unchecked((uint)0x8870),

    [NativeName("GL_MAX_TEXTURE_COORDS_NV")]
    MaxTextureCoordsNV = unchecked((uint)0x8871),

    [NativeName("GL_MAX_TEXTURE_IMAGE_UNITS_NV")]
    MaxTextureImageUnitsNV = unchecked((uint)0x8872),

    [NativeName("GL_FRAGMENT_PROGRAM_BINDING_NV")]
    FragmentProgramBindingNV = unchecked((uint)0x8873),

    [NativeName("GL_PROGRAM_ERROR_STRING_NV")]
    ProgramErrorStringNV = unchecked((uint)0x8874),

    [NativeName("GL_MAX_PROGRAM_EXEC_INSTRUCTIONS_NV")]
    MaxProgramExecInstructionsNV = unchecked((uint)0x88F4),

    [NativeName("GL_MAX_PROGRAM_CALL_DEPTH_NV")]
    MaxProgramCallDepthNV = unchecked((uint)0x88F5),

    [NativeName("GL_MAX_PROGRAM_IF_DEPTH_NV")]
    MaxProgramIfDepthNV = unchecked((uint)0x88F6),

    [NativeName("GL_MAX_PROGRAM_LOOP_DEPTH_NV")]
    MaxProgramLoopDepthNV = unchecked((uint)0x88F7),

    [NativeName("GL_MAX_PROGRAM_LOOP_COUNT_NV")]
    MaxProgramLoopCountNV = unchecked((uint)0x88F8),

    [NativeName("GL_COVERAGE_MODULATION_TABLE_NV")]
    CoverageModulationTableNV = unchecked((uint)0x9331),

    [NativeName("GL_COLOR_SAMPLES_NV")]
    ColorSamplesNV = unchecked((uint)0x8E20),

    [NativeName("GL_DEPTH_SAMPLES_NV")]
    DepthSamplesNV = unchecked((uint)0x932D),

    [NativeName("GL_STENCIL_SAMPLES_NV")]
    StencilSamplesNV = unchecked((uint)0x932E),

    [NativeName("GL_MIXED_DEPTH_SAMPLES_SUPPORTED_NV")]
    MixedDepthSamplesSupportedNV = unchecked((uint)0x932F),

    [NativeName("GL_MIXED_STENCIL_SAMPLES_SUPPORTED_NV")]
    MixedStencilSamplesSupportedNV = unchecked((uint)0x9330),

    [NativeName("GL_COVERAGE_MODULATION_NV")]
    CoverageModulationNV = unchecked((uint)0x9332),

    [NativeName("GL_COVERAGE_MODULATION_TABLE_SIZE_NV")]
    CoverageModulationTableSizeNV = unchecked((uint)0x9333),

    [NativeName("GL_RENDERBUFFER_COVERAGE_SAMPLES_NV")]
    RenderbufferCoverageSamplesNV = unchecked((uint)0x8CAB),

    [NativeName("GL_RENDERBUFFER_COLOR_SAMPLES_NV")]
    RenderbufferColorSamplesNV = unchecked((uint)0x8E10),

    [NativeName("GL_MAX_MULTISAMPLE_COVERAGE_MODES_NV")]
    MaxMultisampleCoverageModesNV = unchecked((uint)0x8E11),

    [NativeName("GL_MULTISAMPLE_COVERAGE_MODES_NV")]
    MultisampleCoverageModesNV = unchecked((uint)0x8E12),

    [NativeName("GL_GEOMETRY_PROGRAM_NV")]
    GeometryProgramNV = unchecked((uint)0x8C26),

    [NativeName("GL_MAX_PROGRAM_OUTPUT_VERTICES_NV")]
    MaxProgramOutputVerticesNV = unchecked((uint)0x8C27),

    [NativeName("GL_MAX_PROGRAM_TOTAL_OUTPUT_COMPONENTS_NV")]
    MaxProgramTotalOutputComponentsNV = unchecked((uint)0x8C28),

    [NativeName("GL_PER_GPU_STORAGE_BIT_NV")]
    PerGpuStorageBitNV = unchecked((uint)0x0800),

    [NativeName("GL_MULTICAST_GPUS_NV")]
    MulticastGpusNV = unchecked((uint)0x92BA),

    [NativeName("GL_RENDER_GPU_MASK_NV")]
    RenderGpuMaskNV = unchecked((uint)0x9558),

    [NativeName("GL_PER_GPU_STORAGE_NV")]
    PerGpuStorageNV = unchecked((uint)0x9548),

    [NativeName("GL_MULTICAST_PROGRAMMABLE_SAMPLE_LOCATION_NV")]
    MulticastProgrammableSampleLocationNV = unchecked((uint)0x9549),

    [NativeName("GL_MIN_PROGRAM_TEXEL_OFFSET_NV")]
    MinProgramTexelOffsetNV = unchecked((uint)0x8904),

    [NativeName("GL_MAX_PROGRAM_TEXEL_OFFSET_NV")]
    MaxProgramTexelOffsetNV = unchecked((uint)0x8905),

    [NativeName("GL_PROGRAM_ATTRIB_COMPONENTS_NV")]
    ProgramAttribComponentsNV = unchecked((uint)0x8906),

    [NativeName("GL_PROGRAM_RESULT_COMPONENTS_NV")]
    ProgramResultComponentsNV = unchecked((uint)0x8907),

    [NativeName("GL_MAX_PROGRAM_ATTRIB_COMPONENTS_NV")]
    MaxProgramAttribComponentsNV = unchecked((uint)0x8908),

    [NativeName("GL_MAX_PROGRAM_RESULT_COMPONENTS_NV")]
    MaxProgramResultComponentsNV = unchecked((uint)0x8909),

    [NativeName("GL_MAX_PROGRAM_GENERIC_ATTRIBS_NV")]
    MaxProgramGenericAttribsNV = unchecked((uint)0x8DA5),

    [NativeName("GL_MAX_PROGRAM_GENERIC_RESULTS_NV")]
    MaxProgramGenericResultsNV = unchecked((uint)0x8DA6),

    [NativeName("GL_MAX_GEOMETRY_PROGRAM_INVOCATIONS_NV")]
    MaxGeometryProgramInvocationsNV = unchecked((uint)0x8E5A),

    [NativeName("GL_MIN_FRAGMENT_INTERPOLATION_OFFSET_NV")]
    MinFragmentInterpolationOffsetNV = unchecked((uint)0x8E5B),

    [NativeName("GL_MAX_FRAGMENT_INTERPOLATION_OFFSET_NV")]
    MaxFragmentInterpolationOffsetNV = unchecked((uint)0x8E5C),

    [NativeName("GL_FRAGMENT_PROGRAM_INTERPOLATION_OFFSET_BITS_NV")]
    FragmentProgramInterpolationOffsetBitsNV = unchecked((uint)0x8E5D),

    [NativeName("GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET_NV")]
    MinProgramTextureGatherOffsetNV = unchecked((uint)0x8E5E),

    [NativeName("GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET_NV")]
    MaxProgramTextureGatherOffsetNV = unchecked((uint)0x8E5F),

    [NativeName("GL_MAX_PROGRAM_SUBROUTINE_PARAMETERS_NV")]
    MaxProgramSubroutineParametersNV = unchecked((uint)0x8F44),

    [NativeName("GL_MAX_PROGRAM_SUBROUTINE_NUM_NV")]
    MaxProgramSubroutineNumNV = unchecked((uint)0x8F45),

    [NativeName("GL_HALF_FLOAT_NV")]
    HalfFloatNV = unchecked((uint)0x140B),

    [NativeName("GL_MULTISAMPLES_NV")]
    MultisamplesNV = unchecked((uint)0x9371),

    [NativeName("GL_SUPERSAMPLE_SCALE_X_NV")]
    SupersampleScaleXNV = unchecked((uint)0x9372),

    [NativeName("GL_SUPERSAMPLE_SCALE_Y_NV")]
    SupersampleScaleYNV = unchecked((uint)0x9373),

    [NativeName("GL_CONFORMANT_NV")]
    ConformantNV = unchecked((uint)0x9374),

    [NativeName("GL_MAX_SHININESS_NV")]
    MaxShininessNV = unchecked((uint)0x8504),

    [NativeName("GL_MAX_SPOT_EXPONENT_NV")]
    MaxSpotExponentNV = unchecked((uint)0x8505),

    [NativeName("GL_ATTACHED_MEMORY_OBJECT_NV")]
    AttachedMemoryObjectNV = unchecked((uint)0x95A4),

    [NativeName("GL_ATTACHED_MEMORY_OFFSET_NV")]
    AttachedMemoryOffsetNV = unchecked((uint)0x95A5),

    [NativeName("GL_MEMORY_ATTACHABLE_ALIGNMENT_NV")]
    MemoryAttachableAlignmentNV = unchecked((uint)0x95A6),

    [NativeName("GL_MEMORY_ATTACHABLE_SIZE_NV")]
    MemoryAttachableSizeNV = unchecked((uint)0x95A7),

    [NativeName("GL_MEMORY_ATTACHABLE_NV")]
    MemoryAttachableNV = unchecked((uint)0x95A8),

    [NativeName("GL_DETACHED_MEMORY_INCARNATION_NV")]
    DetachedMemoryIncarnationNV = unchecked((uint)0x95A9),

    [NativeName("GL_DETACHED_TEXTURES_NV")]
    DetachedTexturesNV = unchecked((uint)0x95AA),

    [NativeName("GL_DETACHED_BUFFERS_NV")]
    DetachedBuffersNV = unchecked((uint)0x95AB),

    [NativeName("GL_MAX_DETACHED_TEXTURES_NV")]
    MaxDetachedTexturesNV = unchecked((uint)0x95AC),

    [NativeName("GL_MAX_DETACHED_BUFFERS_NV")]
    MaxDetachedBuffersNV = unchecked((uint)0x95AD),

    [NativeName("GL_MESH_SHADER_NV")]
    MeshShaderNV = unchecked((uint)0x9559),

    [NativeName("GL_TASK_SHADER_NV")]
    TaskShaderNV = unchecked((uint)0x955A),

    [NativeName("GL_MAX_MESH_UNIFORM_BLOCKS_NV")]
    MaxMeshUniformBlocksNV = unchecked((uint)0x8E60),

    [NativeName("GL_MAX_MESH_TEXTURE_IMAGE_UNITS_NV")]
    MaxMeshTextureImageUnitsNV = unchecked((uint)0x8E61),

    [NativeName("GL_MAX_MESH_IMAGE_UNIFORMS_NV")]
    MaxMeshImageUniformsNV = unchecked((uint)0x8E62),

    [NativeName("GL_MAX_MESH_UNIFORM_COMPONENTS_NV")]
    MaxMeshUniformComponentsNV = unchecked((uint)0x8E63),

    [NativeName("GL_MAX_MESH_ATOMIC_COUNTER_BUFFERS_NV")]
    MaxMeshAtomicCounterBuffersNV = unchecked((uint)0x8E64),

    [NativeName("GL_MAX_MESH_ATOMIC_COUNTERS_NV")]
    MaxMeshAtomicCountersNV = unchecked((uint)0x8E65),

    [NativeName("GL_MAX_MESH_SHADER_STORAGE_BLOCKS_NV")]
    MaxMeshShaderStorageBlocksNV = unchecked((uint)0x8E66),

    [NativeName("GL_MAX_COMBINED_MESH_UNIFORM_COMPONENTS_NV")]
    MaxCombinedMeshUniformComponentsNV = unchecked((uint)0x8E67),

    [NativeName("GL_MAX_TASK_UNIFORM_BLOCKS_NV")]
    MaxTaskUniformBlocksNV = unchecked((uint)0x8E68),

    [NativeName("GL_MAX_TASK_TEXTURE_IMAGE_UNITS_NV")]
    MaxTaskTextureImageUnitsNV = unchecked((uint)0x8E69),

    [NativeName("GL_MAX_TASK_IMAGE_UNIFORMS_NV")]
    MaxTaskImageUniformsNV = unchecked((uint)0x8E6A),

    [NativeName("GL_MAX_TASK_UNIFORM_COMPONENTS_NV")]
    MaxTaskUniformComponentsNV = unchecked((uint)0x8E6B),

    [NativeName("GL_MAX_TASK_ATOMIC_COUNTER_BUFFERS_NV")]
    MaxTaskAtomicCounterBuffersNV = unchecked((uint)0x8E6C),

    [NativeName("GL_MAX_TASK_ATOMIC_COUNTERS_NV")]
    MaxTaskAtomicCountersNV = unchecked((uint)0x8E6D),

    [NativeName("GL_MAX_TASK_SHADER_STORAGE_BLOCKS_NV")]
    MaxTaskShaderStorageBlocksNV = unchecked((uint)0x8E6E),

    [NativeName("GL_MAX_COMBINED_TASK_UNIFORM_COMPONENTS_NV")]
    MaxCombinedTaskUniformComponentsNV = unchecked((uint)0x8E6F),

    [NativeName("GL_MAX_MESH_WORK_GROUP_INVOCATIONS_NV")]
    MaxMeshWorkGroupInvocationsNV = unchecked((uint)0x95A2),

    [NativeName("GL_MAX_TASK_WORK_GROUP_INVOCATIONS_NV")]
    MaxTaskWorkGroupInvocationsNV = unchecked((uint)0x95A3),

    [NativeName("GL_MAX_MESH_TOTAL_MEMORY_SIZE_NV")]
    MaxMeshTotalMemorySizeNV = unchecked((uint)0x9536),

    [NativeName("GL_MAX_TASK_TOTAL_MEMORY_SIZE_NV")]
    MaxTaskTotalMemorySizeNV = unchecked((uint)0x9537),

    [NativeName("GL_MAX_MESH_OUTPUT_VERTICES_NV")]
    MaxMeshOutputVerticesNV = unchecked((uint)0x9538),

    [NativeName("GL_MAX_MESH_OUTPUT_PRIMITIVES_NV")]
    MaxMeshOutputPrimitivesNV = unchecked((uint)0x9539),

    [NativeName("GL_MAX_TASK_OUTPUT_COUNT_NV")]
    MaxTaskOutputCountNV = unchecked((uint)0x953A),

    [NativeName("GL_MAX_DRAW_MESH_TASKS_COUNT_NV")]
    MaxDrawMeshTasksCountNV = unchecked((uint)0x953D),

    [NativeName("GL_MAX_MESH_VIEWS_NV")]
    MaxMeshViewsNV = unchecked((uint)0x9557),

    [NativeName("GL_MESH_OUTPUT_PER_VERTEX_GRANULARITY_NV")]
    MeshOutputPerVertexGranularityNV = unchecked((uint)0x92DF),

    [NativeName("GL_MESH_OUTPUT_PER_PRIMITIVE_GRANULARITY_NV")]
    MeshOutputPerPrimitiveGranularityNV = unchecked((uint)0x9543),

    [NativeName("GL_MAX_MESH_WORK_GROUP_SIZE_NV")]
    MaxMeshWorkGroupSizeNV = unchecked((uint)0x953B),

    [NativeName("GL_MAX_TASK_WORK_GROUP_SIZE_NV")]
    MaxTaskWorkGroupSizeNV = unchecked((uint)0x953C),

    [NativeName("GL_MESH_WORK_GROUP_SIZE_NV")]
    MeshWorkGroupSizeNV = unchecked((uint)0x953E),

    [NativeName("GL_TASK_WORK_GROUP_SIZE_NV")]
    TaskWorkGroupSizeNV = unchecked((uint)0x953F),

    [NativeName("GL_MESH_VERTICES_OUT_NV")]
    MeshVerticesOutNV = unchecked((uint)0x9579),

    [NativeName("GL_MESH_PRIMITIVES_OUT_NV")]
    MeshPrimitivesOutNV = unchecked((uint)0x957A),

    [NativeName("GL_MESH_OUTPUT_TYPE_NV")]
    MeshOutputTypeNV = unchecked((uint)0x957B),

    [NativeName("GL_UNIFORM_BLOCK_REFERENCED_BY_MESH_SHADER_NV")]
    UniformBlockReferencedByMeshShaderNV = unchecked((uint)0x959C),

    [NativeName("GL_UNIFORM_BLOCK_REFERENCED_BY_TASK_SHADER_NV")]
    UniformBlockReferencedByTaskShaderNV = unchecked((uint)0x959D),

    [NativeName("GL_REFERENCED_BY_MESH_SHADER_NV")]
    ReferencedByMeshShaderNV = unchecked((uint)0x95A0),

    [NativeName("GL_REFERENCED_BY_TASK_SHADER_NV")]
    ReferencedByTaskShaderNV = unchecked((uint)0x95A1),

    [NativeName("GL_MESH_SHADER_BIT_NV")]
    MeshShaderBitNV = unchecked((uint)0x00000040),

    [NativeName("GL_TASK_SHADER_BIT_NV")]
    TaskShaderBitNV = unchecked((uint)0x00000080),

    [NativeName("GL_MESH_SUBROUTINE_NV")]
    MeshSubroutineNV = unchecked((uint)0x957C),

    [NativeName("GL_TASK_SUBROUTINE_NV")]
    TaskSubroutineNV = unchecked((uint)0x957D),

    [NativeName("GL_MESH_SUBROUTINE_UNIFORM_NV")]
    MeshSubroutineUniformNV = unchecked((uint)0x957E),

    [NativeName("GL_TASK_SUBROUTINE_UNIFORM_NV")]
    TaskSubroutineUniformNV = unchecked((uint)0x957F),

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_MESH_SHADER_NV")]
    AtomicCounterBufferReferencedByMeshShaderNV = unchecked((uint)0x959E),

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TASK_SHADER_NV")]
    AtomicCounterBufferReferencedByTaskShaderNV = unchecked((uint)0x959F),

    [NativeName("GL_MULTISAMPLE_FILTER_HINT_NV")]
    MultisampleFilterHintNV = unchecked((uint)0x8534),

    [NativeName("GL_PIXEL_COUNTER_BITS_NV")]
    PixelCounterBitsNV = unchecked((uint)0x8864),

    [NativeName("GL_CURRENT_OCCLUSION_QUERY_ID_NV")]
    CurrentOcclusionQueryIdNV = unchecked((uint)0x8865),

    [NativeName("GL_PIXEL_COUNT_NV")]
    PixelCountNV = unchecked((uint)0x8866),

    [NativeName("GL_PIXEL_COUNT_AVAILABLE_NV")]
    PixelCountAvailableNV = unchecked((uint)0x8867),

    [NativeName("GL_DEPTH_STENCIL_NV")]
    DepthStencilNV = unchecked((uint)0x84F9),

    [NativeName("GL_UNSIGNED_INT_24_8_NV")]
    UnsignedInt24X8NV = unchecked((uint)0x84FA),

    [NativeName("GL_MAX_PROGRAM_PARAMETER_BUFFER_BINDINGS_NV")]
    MaxProgramParameterBufferBindingsNV = unchecked((uint)0x8DA0),

    [NativeName("GL_MAX_PROGRAM_PARAMETER_BUFFER_SIZE_NV")]
    MaxProgramParameterBufferSizeNV = unchecked((uint)0x8DA1),

    [NativeName("GL_VERTEX_PROGRAM_PARAMETER_BUFFER_NV")]
    VertexProgramParameterBufferNV = unchecked((uint)0x8DA2),

    [NativeName("GL_GEOMETRY_PROGRAM_PARAMETER_BUFFER_NV")]
    GeometryProgramParameterBufferNV = unchecked((uint)0x8DA3),

    [NativeName("GL_FRAGMENT_PROGRAM_PARAMETER_BUFFER_NV")]
    FragmentProgramParameterBufferNV = unchecked((uint)0x8DA4),

    [NativeName("GL_PATH_FORMAT_SVG_NV")]
    PathFormatSvgNV = unchecked((uint)0x9070),

    [NativeName("GL_PATH_FORMAT_PS_NV")]
    PathFormatPsNV = unchecked((uint)0x9071),

    [NativeName("GL_STANDARD_FONT_NAME_NV")]
    StandardFontNameNV = unchecked((uint)0x9072),

    [NativeName("GL_SYSTEM_FONT_NAME_NV")]
    SystemFontNameNV = unchecked((uint)0x9073),

    [NativeName("GL_FILE_NAME_NV")]
    FileNameNV = unchecked((uint)0x9074),

    [NativeName("GL_PATH_STROKE_WIDTH_NV")]
    PathStrokeWidthNV = unchecked((uint)0x9075),

    [NativeName("GL_PATH_END_CAPS_NV")]
    PathEndCapsNV = unchecked((uint)0x9076),

    [NativeName("GL_PATH_INITIAL_END_CAP_NV")]
    PathInitialEndCapNV = unchecked((uint)0x9077),

    [NativeName("GL_PATH_TERMINAL_END_CAP_NV")]
    PathTerminalEndCapNV = unchecked((uint)0x9078),

    [NativeName("GL_PATH_JOIN_STYLE_NV")]
    PathJoinStyleNV = unchecked((uint)0x9079),

    [NativeName("GL_PATH_MITER_LIMIT_NV")]
    PathMiterLimitNV = unchecked((uint)0x907A),

    [NativeName("GL_PATH_DASH_CAPS_NV")]
    PathDashCapsNV = unchecked((uint)0x907B),

    [NativeName("GL_PATH_INITIAL_DASH_CAP_NV")]
    PathInitialDashCapNV = unchecked((uint)0x907C),

    [NativeName("GL_PATH_TERMINAL_DASH_CAP_NV")]
    PathTerminalDashCapNV = unchecked((uint)0x907D),

    [NativeName("GL_PATH_DASH_OFFSET_NV")]
    PathDashOffsetNV = unchecked((uint)0x907E),

    [NativeName("GL_PATH_CLIENT_LENGTH_NV")]
    PathClientLengthNV = unchecked((uint)0x907F),

    [NativeName("GL_PATH_FILL_MODE_NV")]
    PathFillModeNV = unchecked((uint)0x9080),

    [NativeName("GL_PATH_FILL_MASK_NV")]
    PathFillMaskNV = unchecked((uint)0x9081),

    [NativeName("GL_PATH_FILL_COVER_MODE_NV")]
    PathFillCoverModeNV = unchecked((uint)0x9082),

    [NativeName("GL_PATH_STROKE_COVER_MODE_NV")]
    PathStrokeCoverModeNV = unchecked((uint)0x9083),

    [NativeName("GL_PATH_STROKE_MASK_NV")]
    PathStrokeMaskNV = unchecked((uint)0x9084),

    [NativeName("GL_COUNT_UP_NV")]
    CountUpNV = unchecked((uint)0x9088),

    [NativeName("GL_COUNT_DOWN_NV")]
    CountDownNV = unchecked((uint)0x9089),

    [NativeName("GL_PATH_OBJECT_BOUNDING_BOX_NV")]
    PathObjectBoundingBoxNV = unchecked((uint)0x908A),

    [NativeName("GL_CONVEX_HULL_NV")]
    ConvexHullNV = unchecked((uint)0x908B),

    [NativeName("GL_BOUNDING_BOX_NV")]
    BoundingBoxNV = unchecked((uint)0x908D),

    [NativeName("GL_TRANSLATE_X_NV")]
    TranslateXNV = unchecked((uint)0x908E),

    [NativeName("GL_TRANSLATE_Y_NV")]
    TranslateYNV = unchecked((uint)0x908F),

    [NativeName("GL_TRANSLATE_2D_NV")]
    Translate2DNV = unchecked((uint)0x9090),

    [NativeName("GL_TRANSLATE_3D_NV")]
    Translate3DNV = unchecked((uint)0x9091),

    [NativeName("GL_AFFINE_2D_NV")]
    Affine2DNV = unchecked((uint)0x9092),

    [NativeName("GL_AFFINE_3D_NV")]
    Affine3DNV = unchecked((uint)0x9094),

    [NativeName("GL_TRANSPOSE_AFFINE_2D_NV")]
    TransposeAffine2DNV = unchecked((uint)0x9096),

    [NativeName("GL_TRANSPOSE_AFFINE_3D_NV")]
    TransposeAffine3DNV = unchecked((uint)0x9098),

    [NativeName("GL_UTF8_NV")]
    Utf8NV = unchecked((uint)0x909A),

    [NativeName("GL_UTF16_NV")]
    Utf16NV = unchecked((uint)0x909B),

    [NativeName("GL_BOUNDING_BOX_OF_BOUNDING_BOXES_NV")]
    BoundingBoxOfBoundingBoxesNV = unchecked((uint)0x909C),

    [NativeName("GL_PATH_COMMAND_COUNT_NV")]
    PathCommandCountNV = unchecked((uint)0x909D),

    [NativeName("GL_PATH_COORD_COUNT_NV")]
    PathCoordCountNV = unchecked((uint)0x909E),

    [NativeName("GL_PATH_DASH_ARRAY_COUNT_NV")]
    PathDashArrayCountNV = unchecked((uint)0x909F),

    [NativeName("GL_PATH_COMPUTED_LENGTH_NV")]
    PathComputedLengthNV = unchecked((uint)0x90A0),

    [NativeName("GL_PATH_FILL_BOUNDING_BOX_NV")]
    PathFillBoundingBoxNV = unchecked((uint)0x90A1),

    [NativeName("GL_PATH_STROKE_BOUNDING_BOX_NV")]
    PathStrokeBoundingBoxNV = unchecked((uint)0x90A2),

    [NativeName("GL_SQUARE_NV")]
    SquareNV = unchecked((uint)0x90A3),

    [NativeName("GL_ROUND_NV")]
    RoundNV = unchecked((uint)0x90A4),

    [NativeName("GL_TRIANGULAR_NV")]
    TriangularNV = unchecked((uint)0x90A5),

    [NativeName("GL_BEVEL_NV")]
    BevelNV = unchecked((uint)0x90A6),

    [NativeName("GL_MITER_REVERT_NV")]
    MiterRevertNV = unchecked((uint)0x90A7),

    [NativeName("GL_MITER_TRUNCATE_NV")]
    MiterTruncateNV = unchecked((uint)0x90A8),

    [NativeName("GL_SKIP_MISSING_GLYPH_NV")]
    SkipMissingGlyphNV = unchecked((uint)0x90A9),

    [NativeName("GL_USE_MISSING_GLYPH_NV")]
    UseMissingGlyphNV = unchecked((uint)0x90AA),

    [NativeName("GL_PATH_ERROR_POSITION_NV")]
    PathErrorPositionNV = unchecked((uint)0x90AB),

    [NativeName("GL_ACCUM_ADJACENT_PAIRS_NV")]
    AccumAdjacentPairsNV = unchecked((uint)0x90AD),

    [NativeName("GL_ADJACENT_PAIRS_NV")]
    AdjacentPairsNV = unchecked((uint)0x90AE),

    [NativeName("GL_FIRST_TO_REST_NV")]
    FirstToRestNV = unchecked((uint)0x90AF),

    [NativeName("GL_PATH_GEN_MODE_NV")]
    PathGenModeNV = unchecked((uint)0x90B0),

    [NativeName("GL_PATH_GEN_COEFF_NV")]
    PathGenCoeffNV = unchecked((uint)0x90B1),

    [NativeName("GL_PATH_GEN_COMPONENTS_NV")]
    PathGenComponentsNV = unchecked((uint)0x90B3),

    [NativeName("GL_PATH_STENCIL_FUNC_NV")]
    PathStencilFuncNV = unchecked((uint)0x90B7),

    [NativeName("GL_PATH_STENCIL_REF_NV")]
    PathStencilRefNV = unchecked((uint)0x90B8),

    [NativeName("GL_PATH_STENCIL_VALUE_MASK_NV")]
    PathStencilValueMaskNV = unchecked((uint)0x90B9),

    [NativeName("GL_PATH_STENCIL_DEPTH_OFFSET_FACTOR_NV")]
    PathStencilDepthOffsetFactorNV = unchecked((uint)0x90BD),

    [NativeName("GL_PATH_STENCIL_DEPTH_OFFSET_UNITS_NV")]
    PathStencilDepthOffsetUnitsNV = unchecked((uint)0x90BE),

    [NativeName("GL_PATH_COVER_DEPTH_FUNC_NV")]
    PathCoverDepthFuncNV = unchecked((uint)0x90BF),

    [NativeName("GL_PATH_DASH_OFFSET_RESET_NV")]
    PathDashOffsetResetNV = unchecked((uint)0x90B4),

    [NativeName("GL_MOVE_TO_RESETS_NV")]
    MoveToResetsNV = unchecked((uint)0x90B5),

    [NativeName("GL_MOVE_TO_CONTINUES_NV")]
    MoveToContinuesNV = unchecked((uint)0x90B6),

    [NativeName("GL_CLOSE_PATH_NV")]
    ClosePathNV = unchecked((uint)0x00),

    [NativeName("GL_MOVE_TO_NV")]
    MoveToNV = unchecked((uint)0x02),

    [NativeName("GL_RELATIVE_MOVE_TO_NV")]
    RelativeMoveToNV = unchecked((uint)0x03),

    [NativeName("GL_LINE_TO_NV")]
    LineToNV = unchecked((uint)0x04),

    [NativeName("GL_RELATIVE_LINE_TO_NV")]
    RelativeLineToNV = unchecked((uint)0x05),

    [NativeName("GL_HORIZONTAL_LINE_TO_NV")]
    HorizontalLineToNV = unchecked((uint)0x06),

    [NativeName("GL_RELATIVE_HORIZONTAL_LINE_TO_NV")]
    RelativeHorizontalLineToNV = unchecked((uint)0x07),

    [NativeName("GL_VERTICAL_LINE_TO_NV")]
    VerticalLineToNV = unchecked((uint)0x08),

    [NativeName("GL_RELATIVE_VERTICAL_LINE_TO_NV")]
    RelativeVerticalLineToNV = unchecked((uint)0x09),

    [NativeName("GL_QUADRATIC_CURVE_TO_NV")]
    QuadraticCurveToNV = unchecked((uint)0x0A),

    [NativeName("GL_RELATIVE_QUADRATIC_CURVE_TO_NV")]
    RelativeQuadraticCurveToNV = unchecked((uint)0x0B),

    [NativeName("GL_CUBIC_CURVE_TO_NV")]
    CubicCurveToNV = unchecked((uint)0x0C),

    [NativeName("GL_RELATIVE_CUBIC_CURVE_TO_NV")]
    RelativeCubicCurveToNV = unchecked((uint)0x0D),

    [NativeName("GL_SMOOTH_QUADRATIC_CURVE_TO_NV")]
    SmoothQuadraticCurveToNV = unchecked((uint)0x0E),

    [NativeName("GL_RELATIVE_SMOOTH_QUADRATIC_CURVE_TO_NV")]
    RelativeSmoothQuadraticCurveToNV = unchecked((uint)0x0F),

    [NativeName("GL_SMOOTH_CUBIC_CURVE_TO_NV")]
    SmoothCubicCurveToNV = unchecked((uint)0x10),

    [NativeName("GL_RELATIVE_SMOOTH_CUBIC_CURVE_TO_NV")]
    RelativeSmoothCubicCurveToNV = unchecked((uint)0x11),

    [NativeName("GL_SMALL_CCW_ARC_TO_NV")]
    SmallCcwArcToNV = unchecked((uint)0x12),

    [NativeName("GL_RELATIVE_SMALL_CCW_ARC_TO_NV")]
    RelativeSmallCcwArcToNV = unchecked((uint)0x13),

    [NativeName("GL_SMALL_CW_ARC_TO_NV")]
    SmallCwArcToNV = unchecked((uint)0x14),

    [NativeName("GL_RELATIVE_SMALL_CW_ARC_TO_NV")]
    RelativeSmallCwArcToNV = unchecked((uint)0x15),

    [NativeName("GL_LARGE_CCW_ARC_TO_NV")]
    LargeCcwArcToNV = unchecked((uint)0x16),

    [NativeName("GL_RELATIVE_LARGE_CCW_ARC_TO_NV")]
    RelativeLargeCcwArcToNV = unchecked((uint)0x17),

    [NativeName("GL_LARGE_CW_ARC_TO_NV")]
    LargeCwArcToNV = unchecked((uint)0x18),

    [NativeName("GL_RELATIVE_LARGE_CW_ARC_TO_NV")]
    RelativeLargeCwArcToNV = unchecked((uint)0x19),

    [NativeName("GL_RESTART_PATH_NV")]
    RestartPathNV = unchecked((uint)0xF0),

    [NativeName("GL_DUP_FIRST_CUBIC_CURVE_TO_NV")]
    DupFirstCubicCurveToNV = unchecked((uint)0xF2),

    [NativeName("GL_DUP_LAST_CUBIC_CURVE_TO_NV")]
    DupLastCubicCurveToNV = unchecked((uint)0xF4),

    [NativeName("GL_RECT_NV")]
    RectNV = unchecked((uint)0xF6),

    [NativeName("GL_CIRCULAR_CCW_ARC_TO_NV")]
    CircularCcwArcToNV = unchecked((uint)0xF8),

    [NativeName("GL_CIRCULAR_CW_ARC_TO_NV")]
    CircularCwArcToNV = unchecked((uint)0xFA),

    [NativeName("GL_CIRCULAR_TANGENT_ARC_TO_NV")]
    CircularTangentArcToNV = unchecked((uint)0xFC),

    [NativeName("GL_ARC_TO_NV")]
    ArcToNV = unchecked((uint)0xFE),

    [NativeName("GL_RELATIVE_ARC_TO_NV")]
    RelativeArcToNV = unchecked((uint)0xFF),

    [NativeName("GL_BOLD_BIT_NV")]
    BoldBitNV = unchecked((uint)0x01),

    [NativeName("GL_ITALIC_BIT_NV")]
    ItalicBitNV = unchecked((uint)0x02),

    [NativeName("GL_GLYPH_WIDTH_BIT_NV")]
    GlyphWidthBitNV = unchecked((uint)0x01),

    [NativeName("GL_GLYPH_HEIGHT_BIT_NV")]
    GlyphHeightBitNV = unchecked((uint)0x02),

    [NativeName("GL_GLYPH_HORIZONTAL_BEARING_X_BIT_NV")]
    GlyphHorizontalBearingXBitNV = unchecked((uint)0x04),

    [NativeName("GL_GLYPH_HORIZONTAL_BEARING_Y_BIT_NV")]
    GlyphHorizontalBearingYBitNV = unchecked((uint)0x08),

    [NativeName("GL_GLYPH_HORIZONTAL_BEARING_ADVANCE_BIT_NV")]
    GlyphHorizontalBearingAdvanceBitNV = unchecked((uint)0x10),

    [NativeName("GL_GLYPH_VERTICAL_BEARING_X_BIT_NV")]
    GlyphVerticalBearingXBitNV = unchecked((uint)0x20),

    [NativeName("GL_GLYPH_VERTICAL_BEARING_Y_BIT_NV")]
    GlyphVerticalBearingYBitNV = unchecked((uint)0x40),

    [NativeName("GL_GLYPH_VERTICAL_BEARING_ADVANCE_BIT_NV")]
    GlyphVerticalBearingAdvanceBitNV = unchecked((uint)0x80),

    [NativeName("GL_GLYPH_HAS_KERNING_BIT_NV")]
    GlyphHasKerningBitNV = unchecked((uint)0x100),

    [NativeName("GL_FONT_X_MIN_BOUNDS_BIT_NV")]
    FontXMinBoundsBitNV = unchecked((uint)0x00010000),

    [NativeName("GL_FONT_Y_MIN_BOUNDS_BIT_NV")]
    FontYMinBoundsBitNV = unchecked((uint)0x00020000),

    [NativeName("GL_FONT_X_MAX_BOUNDS_BIT_NV")]
    FontXMaxBoundsBitNV = unchecked((uint)0x00040000),

    [NativeName("GL_FONT_Y_MAX_BOUNDS_BIT_NV")]
    FontYMaxBoundsBitNV = unchecked((uint)0x00080000),

    [NativeName("GL_FONT_UNITS_PER_EM_BIT_NV")]
    FontUnitsPerEmBitNV = unchecked((uint)0x00100000),

    [NativeName("GL_FONT_ASCENDER_BIT_NV")]
    FontAscenderBitNV = unchecked((uint)0x00200000),

    [NativeName("GL_FONT_DESCENDER_BIT_NV")]
    FontDescenderBitNV = unchecked((uint)0x00400000),

    [NativeName("GL_FONT_HEIGHT_BIT_NV")]
    FontHeightBitNV = unchecked((uint)0x00800000),

    [NativeName("GL_FONT_MAX_ADVANCE_WIDTH_BIT_NV")]
    FontMaxAdvanceWidthBitNV = unchecked((uint)0x01000000),

    [NativeName("GL_FONT_MAX_ADVANCE_HEIGHT_BIT_NV")]
    FontMaxAdvanceHeightBitNV = unchecked((uint)0x02000000),

    [NativeName("GL_FONT_UNDERLINE_POSITION_BIT_NV")]
    FontUnderlinePositionBitNV = unchecked((uint)0x04000000),

    [NativeName("GL_FONT_UNDERLINE_THICKNESS_BIT_NV")]
    FontUnderlineThicknessBitNV = unchecked((uint)0x08000000),

    [NativeName("GL_FONT_HAS_KERNING_BIT_NV")]
    FontHasKerningBitNV = unchecked((uint)0x10000000),

    [NativeName("GL_ROUNDED_RECT_NV")]
    RoundedRectNV = unchecked((uint)0xE8),

    [NativeName("GL_RELATIVE_ROUNDED_RECT_NV")]
    RelativeRoundedRectNV = unchecked((uint)0xE9),

    [NativeName("GL_ROUNDED_RECT2_NV")]
    RoundedRect2NV = unchecked((uint)0xEA),

    [NativeName("GL_RELATIVE_ROUNDED_RECT2_NV")]
    RelativeRoundedRect2NV = unchecked((uint)0xEB),

    [NativeName("GL_ROUNDED_RECT4_NV")]
    RoundedRect4NV = unchecked((uint)0xEC),

    [NativeName("GL_RELATIVE_ROUNDED_RECT4_NV")]
    RelativeRoundedRect4NV = unchecked((uint)0xED),

    [NativeName("GL_ROUNDED_RECT8_NV")]
    RoundedRect8NV = unchecked((uint)0xEE),

    [NativeName("GL_RELATIVE_ROUNDED_RECT8_NV")]
    RelativeRoundedRect8NV = unchecked((uint)0xEF),

    [NativeName("GL_RELATIVE_RECT_NV")]
    RelativeRectNV = unchecked((uint)0xF7),

    [NativeName("GL_FONT_GLYPHS_AVAILABLE_NV")]
    FontGlyphsAvailableNV = unchecked((uint)0x9368),

    [NativeName("GL_FONT_TARGET_UNAVAILABLE_NV")]
    FontTargetUnavailableNV = unchecked((uint)0x9369),

    [NativeName("GL_FONT_UNAVAILABLE_NV")]
    FontUnavailableNV = unchecked((uint)0x936A),

    [NativeName("GL_FONT_UNINTELLIGIBLE_NV")]
    FontUnintelligibleNV = unchecked((uint)0x936B),

    [NativeName("GL_CONIC_CURVE_TO_NV")]
    ConicCurveToNV = unchecked((uint)0x1A),

    [NativeName("GL_RELATIVE_CONIC_CURVE_TO_NV")]
    RelativeConicCurveToNV = unchecked((uint)0x1B),

    [NativeName("GL_FONT_NUM_GLYPH_INDICES_BIT_NV")]
    FontNumGlyphIndicesBitNV = unchecked((uint)0x20000000),

    [NativeName("GL_STANDARD_FONT_FORMAT_NV")]
    StandardFontFormatNV = unchecked((uint)0x936C),

    [NativeName("GL_2_BYTES_NV")]
    X2BytesNV = unchecked((uint)0x1407),

    [NativeName("GL_3_BYTES_NV")]
    X3BytesNV = unchecked((uint)0x1408),

    [NativeName("GL_4_BYTES_NV")]
    X4BytesNV = unchecked((uint)0x1409),

    [NativeName("GL_EYE_LINEAR_NV")]
    EyeLinearNV = unchecked((uint)0x2400),

    [NativeName("GL_OBJECT_LINEAR_NV")]
    ObjectLinearNV = unchecked((uint)0x2401),

    [NativeName("GL_CONSTANT_NV")]
    ConstantNV = unchecked((uint)0x8576),

    [NativeName("GL_PATH_FOG_GEN_MODE_NV")]
    PathFogGenModeNV = unchecked((uint)0x90AC),

    [NativeName("GL_PRIMARY_COLOR_NV")]
    PrimaryColorNV = unchecked((uint)0x852C),

    [NativeName("GL_SECONDARY_COLOR_NV")]
    SecondaryColorNV = unchecked((uint)0x852D),

    [NativeName("GL_PATH_GEN_COLOR_FORMAT_NV")]
    PathGenColorFormatNV = unchecked((uint)0x90B2),

    [NativeName("GL_PATH_PROJECTION_NV")]
    PathProjectionNV = unchecked((uint)0x1701),

    [NativeName("GL_PATH_MODELVIEW_NV")]
    PathModelviewNV = unchecked((uint)0x1700),

    [NativeName("GL_PATH_MODELVIEW_STACK_DEPTH_NV")]
    PathModelviewStackDepthNV = unchecked((uint)0x0BA3),

    [NativeName("GL_PATH_MODELVIEW_MATRIX_NV")]
    PathModelviewMatrixNV = unchecked((uint)0x0BA6),

    [NativeName("GL_PATH_MAX_MODELVIEW_STACK_DEPTH_NV")]
    PathMaxModelviewStackDepthNV = unchecked((uint)0x0D36),

    [NativeName("GL_PATH_TRANSPOSE_MODELVIEW_MATRIX_NV")]
    PathTransposeModelviewMatrixNV = unchecked((uint)0x84E3),

    [NativeName("GL_PATH_PROJECTION_STACK_DEPTH_NV")]
    PathProjectionStackDepthNV = unchecked((uint)0x0BA4),

    [NativeName("GL_PATH_PROJECTION_MATRIX_NV")]
    PathProjectionMatrixNV = unchecked((uint)0x0BA7),

    [NativeName("GL_PATH_MAX_PROJECTION_STACK_DEPTH_NV")]
    PathMaxProjectionStackDepthNV = unchecked((uint)0x0D38),

    [NativeName("GL_PATH_TRANSPOSE_PROJECTION_MATRIX_NV")]
    PathTransposeProjectionMatrixNV = unchecked((uint)0x84E4),

    [NativeName("GL_FRAGMENT_INPUT_NV")]
    FragmentInputNV = unchecked((uint)0x936D),

    [NativeName("GL_SHARED_EDGE_NV")]
    SharedEdgeNV = unchecked((uint)0xC0),

    [NativeName("GL_WRITE_PIXEL_DATA_RANGE_NV")]
    WritePixelDataRangeNV = unchecked((uint)0x8878),

    [NativeName("GL_READ_PIXEL_DATA_RANGE_NV")]
    ReadPixelDataRangeNV = unchecked((uint)0x8879),

    [NativeName("GL_WRITE_PIXEL_DATA_RANGE_LENGTH_NV")]
    WritePixelDataRangeLengthNV = unchecked((uint)0x887A),

    [NativeName("GL_READ_PIXEL_DATA_RANGE_LENGTH_NV")]
    ReadPixelDataRangeLengthNV = unchecked((uint)0x887B),

    [NativeName("GL_WRITE_PIXEL_DATA_RANGE_POINTER_NV")]
    WritePixelDataRangePointerNV = unchecked((uint)0x887C),

    [NativeName("GL_READ_PIXEL_DATA_RANGE_POINTER_NV")]
    ReadPixelDataRangePointerNV = unchecked((uint)0x887D),

    [NativeName("GL_POINT_SPRITE_NV")]
    PointSpriteNV = unchecked((uint)0x8861),

    [NativeName("GL_COORD_REPLACE_NV")]
    CoordReplaceNV = unchecked((uint)0x8862),

    [NativeName("GL_POINT_SPRITE_R_MODE_NV")]
    PointSpriteRModeNV = unchecked((uint)0x8863),

    [NativeName("GL_FRAME_NV")]
    FrameNV = unchecked((uint)0x8E26),

    [NativeName("GL_FIELDS_NV")]
    FieldsNV = unchecked((uint)0x8E27),

    [NativeName("GL_CURRENT_TIME_NV")]
    CurrentTimeNV = unchecked((uint)0x8E28),

    [NativeName("GL_NUM_FILL_STREAMS_NV")]
    NumFillStreamsNV = unchecked((uint)0x8E29),

    [NativeName("GL_PRESENT_TIME_NV")]
    PresentTimeNV = unchecked((uint)0x8E2A),

    [NativeName("GL_PRESENT_DURATION_NV")]
    PresentDurationNV = unchecked((uint)0x8E2B),

    [NativeName("GL_PRIMITIVE_RESTART_NV")]
    PrimitiveRestartNV = unchecked((uint)0x8558),

    [NativeName("GL_PRIMITIVE_RESTART_INDEX_NV")]
    PrimitiveRestartIndexNV = unchecked((uint)0x8559),

    [NativeName("GL_SHADING_RATE_IMAGE_PER_PRIMITIVE_NV")]
    ShadingRateImagePerPrimitiveNV = unchecked((uint)0x95B1),

    [NativeName("GL_SHADING_RATE_IMAGE_PALETTE_COUNT_NV")]
    ShadingRateImagePaletteCountNV = unchecked((uint)0x95B2),

    [NativeName("GL_QUERY_RESOURCE_TYPE_VIDMEM_ALLOC_NV")]
    QueryResourceTypeVidmemAllocNV = unchecked((uint)0x9540),

    [NativeName("GL_QUERY_RESOURCE_MEMTYPE_VIDMEM_NV")]
    QueryResourceMemtypeVidmemNV = unchecked((uint)0x9542),

    [NativeName("GL_QUERY_RESOURCE_SYS_RESERVED_NV")]
    QueryResourceSysReservedNV = unchecked((uint)0x9544),

    [NativeName("GL_QUERY_RESOURCE_TEXTURE_NV")]
    QueryResourceTextureNV = unchecked((uint)0x9545),

    [NativeName("GL_QUERY_RESOURCE_RENDERBUFFER_NV")]
    QueryResourceRenderbufferNV = unchecked((uint)0x9546),

    [NativeName("GL_QUERY_RESOURCE_BUFFEROBJECT_NV")]
    QueryResourceBufferobjectNV = unchecked((uint)0x9547),

    [NativeName("GL_REGISTER_COMBINERS_NV")]
    RegisterCombinersNV = unchecked((uint)0x8522),

    [NativeName("GL_VARIABLE_A_NV")]
    VariableANV = unchecked((uint)0x8523),

    [NativeName("GL_VARIABLE_B_NV")]
    VariableBNV = unchecked((uint)0x8524),

    [NativeName("GL_VARIABLE_C_NV")]
    VariableCNV = unchecked((uint)0x8525),

    [NativeName("GL_VARIABLE_D_NV")]
    VariableDNV = unchecked((uint)0x8526),

    [NativeName("GL_VARIABLE_E_NV")]
    VariableENV = unchecked((uint)0x8527),

    [NativeName("GL_VARIABLE_F_NV")]
    VariableFNV = unchecked((uint)0x8528),

    [NativeName("GL_VARIABLE_G_NV")]
    VariableGNV = unchecked((uint)0x8529),

    [NativeName("GL_CONSTANT_COLOR0_NV")]
    ConstantColor0NV = unchecked((uint)0x852A),

    [NativeName("GL_CONSTANT_COLOR1_NV")]
    ConstantColor1NV = unchecked((uint)0x852B),

    [NativeName("GL_SPARE0_NV")]
    Spare0NV = unchecked((uint)0x852E),

    [NativeName("GL_SPARE1_NV")]
    Spare1NV = unchecked((uint)0x852F),

    [NativeName("GL_DISCARD_NV")]
    DiscardNV = unchecked((uint)0x8530),

    [NativeName("GL_E_TIMES_F_NV")]
    ETimesFNV = unchecked((uint)0x8531),

    [NativeName("GL_SPARE0_PLUS_SECONDARY_COLOR_NV")]
    Spare0PlusSecondaryColorNV = unchecked((uint)0x8532),

    [NativeName("GL_UNSIGNED_IDENTITY_NV")]
    UnsignedIdentityNV = unchecked((uint)0x8536),

    [NativeName("GL_UNSIGNED_INVERT_NV")]
    UnsignedInvertNV = unchecked((uint)0x8537),

    [NativeName("GL_EXPAND_NORMAL_NV")]
    ExpandNormalNV = unchecked((uint)0x8538),

    [NativeName("GL_EXPAND_NEGATE_NV")]
    ExpandNegateNV = unchecked((uint)0x8539),

    [NativeName("GL_HALF_BIAS_NORMAL_NV")]
    HalfBiasNormalNV = unchecked((uint)0x853A),

    [NativeName("GL_HALF_BIAS_NEGATE_NV")]
    HalfBiasNegateNV = unchecked((uint)0x853B),

    [NativeName("GL_SIGNED_IDENTITY_NV")]
    SignedIdentityNV = unchecked((uint)0x853C),

    [NativeName("GL_SIGNED_NEGATE_NV")]
    SignedNegateNV = unchecked((uint)0x853D),

    [NativeName("GL_SCALE_BY_TWO_NV")]
    ScaleByTwoNV = unchecked((uint)0x853E),

    [NativeName("GL_SCALE_BY_FOUR_NV")]
    ScaleByFourNV = unchecked((uint)0x853F),

    [NativeName("GL_SCALE_BY_ONE_HALF_NV")]
    ScaleByOneHalfNV = unchecked((uint)0x8540),

    [NativeName("GL_BIAS_BY_NEGATIVE_ONE_HALF_NV")]
    BiasByNegativeOneHalfNV = unchecked((uint)0x8541),

    [NativeName("GL_COMBINER_INPUT_NV")]
    CombinerInputNV = unchecked((uint)0x8542),

    [NativeName("GL_COMBINER_MAPPING_NV")]
    CombinerMappingNV = unchecked((uint)0x8543),

    [NativeName("GL_COMBINER_COMPONENT_USAGE_NV")]
    CombinerComponentUsageNV = unchecked((uint)0x8544),

    [NativeName("GL_COMBINER_AB_DOT_PRODUCT_NV")]
    CombinerAbDotProductNV = unchecked((uint)0x8545),

    [NativeName("GL_COMBINER_CD_DOT_PRODUCT_NV")]
    CombinerCdDotProductNV = unchecked((uint)0x8546),

    [NativeName("GL_COMBINER_MUX_SUM_NV")]
    CombinerMuxSumNV = unchecked((uint)0x8547),

    [NativeName("GL_COMBINER_SCALE_NV")]
    CombinerScaleNV = unchecked((uint)0x8548),

    [NativeName("GL_COMBINER_BIAS_NV")]
    CombinerBiasNV = unchecked((uint)0x8549),

    [NativeName("GL_COMBINER_AB_OUTPUT_NV")]
    CombinerAbOutputNV = unchecked((uint)0x854A),

    [NativeName("GL_COMBINER_CD_OUTPUT_NV")]
    CombinerCdOutputNV = unchecked((uint)0x854B),

    [NativeName("GL_COMBINER_SUM_OUTPUT_NV")]
    CombinerSumOutputNV = unchecked((uint)0x854C),

    [NativeName("GL_MAX_GENERAL_COMBINERS_NV")]
    MaxGeneralCombinersNV = unchecked((uint)0x854D),

    [NativeName("GL_NUM_GENERAL_COMBINERS_NV")]
    NumGeneralCombinersNV = unchecked((uint)0x854E),

    [NativeName("GL_COLOR_SUM_CLAMP_NV")]
    ColorSumClampNV = unchecked((uint)0x854F),

    [NativeName("GL_COMBINER0_NV")]
    Combiner0NV = unchecked((uint)0x8550),

    [NativeName("GL_COMBINER1_NV")]
    Combiner1NV = unchecked((uint)0x8551),

    [NativeName("GL_COMBINER2_NV")]
    Combiner2NV = unchecked((uint)0x8552),

    [NativeName("GL_COMBINER3_NV")]
    Combiner3NV = unchecked((uint)0x8553),

    [NativeName("GL_COMBINER4_NV")]
    Combiner4NV = unchecked((uint)0x8554),

    [NativeName("GL_COMBINER5_NV")]
    Combiner5NV = unchecked((uint)0x8555),

    [NativeName("GL_COMBINER6_NV")]
    Combiner6NV = unchecked((uint)0x8556),

    [NativeName("GL_COMBINER7_NV")]
    Combiner7NV = unchecked((uint)0x8557),

    [NativeName("GL_PER_STAGE_CONSTANTS_NV")]
    PerStageConstantsNV = unchecked((uint)0x8535),

    [NativeName("GL_REPRESENTATIVE_FRAGMENT_TEST_NV")]
    RepresentativeFragmentTestNV = unchecked((uint)0x937F),

    [NativeName("GL_PURGED_CONTEXT_RESET_NV")]
    PurgedContextResetNV = unchecked((uint)0x92BB),

    [NativeName("GL_SAMPLE_LOCATION_SUBPIXEL_BITS_NV")]
    SampleLocationSubpixelBitsNV = unchecked((uint)0x933D),

    [NativeName("GL_SAMPLE_LOCATION_PIXEL_GRID_WIDTH_NV")]
    SampleLocationPixelGridWidthNV = unchecked((uint)0x933E),

    [NativeName("GL_SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_NV")]
    SampleLocationPixelGridHeightNV = unchecked((uint)0x933F),

    [NativeName("GL_PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_NV")]
    ProgrammableSampleLocationTableSizeNV = unchecked((uint)0x9340),

    [NativeName("GL_SAMPLE_LOCATION_NV")]
    SampleLocationNV = unchecked((uint)0x8E50),

    [NativeName("GL_PROGRAMMABLE_SAMPLE_LOCATION_NV")]
    ProgrammableSampleLocationNV = unchecked((uint)0x9341),

    [NativeName("GL_FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_NV")]
    FramebufferProgrammableSampleLocationsNV = unchecked((uint)0x9342),

    [NativeName("GL_FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_NV")]
    FramebufferSampleLocationPixelGridNV = unchecked((uint)0x9343),

    [NativeName("GL_SCISSOR_TEST_EXCLUSIVE_NV")]
    ScissorTestExclusiveNV = unchecked((uint)0x9555),

    [NativeName("GL_SCISSOR_BOX_EXCLUSIVE_NV")]
    ScissorBoxExclusiveNV = unchecked((uint)0x9556),

    [NativeName("GL_BUFFER_GPU_ADDRESS_NV")]
    BufferGpuAddressNV = unchecked((uint)0x8F1D),

    [NativeName("GL_GPU_ADDRESS_NV")]
    GpuAddressNV = unchecked((uint)0x8F34),

    [NativeName("GL_MAX_SHADER_BUFFER_ADDRESS_NV")]
    MaxShaderBufferAddressNV = unchecked((uint)0x8F35),

    [NativeName("GL_SHADER_GLOBAL_ACCESS_BARRIER_BIT_NV")]
    ShaderGlobalAccessBarrierBitNV = unchecked((uint)0x00000010),

    [NativeName("GL_SUBGROUP_FEATURE_PARTITIONED_BIT_NV")]
    SubgroupFeaturePartitionedBitNV = unchecked((uint)0x00000100),

    [NativeName("GL_WARP_SIZE_NV")]
    WarpSizeNV = unchecked((uint)0x9339),

    [NativeName("GL_WARPS_PER_SM_NV")]
    WarpsPerSmNV = unchecked((uint)0x933A),

    [NativeName("GL_SM_COUNT_NV")]
    SmCountNV = unchecked((uint)0x933B),

    [NativeName("GL_SHADING_RATE_IMAGE_NV")]
    ShadingRateImageNV = unchecked((uint)0x9563),

    [NativeName("GL_SHADING_RATE_NO_INVOCATIONS_NV")]
    ShadingRateNoInvocationsNV = unchecked((uint)0x9564),

    [NativeName("GL_SHADING_RATE_1_INVOCATION_PER_PIXEL_NV")]
    ShadingRate1InvocationPerPixelNV = unchecked((uint)0x9565),

    [NativeName("GL_SHADING_RATE_1_INVOCATION_PER_1X2_PIXELS_NV")]
    ShadingRate1InvocationPer1X2PixelsNV = unchecked((uint)0x9566),

    [NativeName("GL_SHADING_RATE_1_INVOCATION_PER_2X1_PIXELS_NV")]
    ShadingRate1InvocationPer2X1PixelsNV = unchecked((uint)0x9567),

    [NativeName("GL_SHADING_RATE_1_INVOCATION_PER_2X2_PIXELS_NV")]
    ShadingRate1InvocationPer2X2PixelsNV = unchecked((uint)0x9568),

    [NativeName("GL_SHADING_RATE_1_INVOCATION_PER_2X4_PIXELS_NV")]
    ShadingRate1InvocationPer2X4PixelsNV = unchecked((uint)0x9569),

    [NativeName("GL_SHADING_RATE_1_INVOCATION_PER_4X2_PIXELS_NV")]
    ShadingRate1InvocationPer4X2PixelsNV = unchecked((uint)0x956A),

    [NativeName("GL_SHADING_RATE_1_INVOCATION_PER_4X4_PIXELS_NV")]
    ShadingRate1InvocationPer4X4PixelsNV = unchecked((uint)0x956B),

    [NativeName("GL_SHADING_RATE_2_INVOCATIONS_PER_PIXEL_NV")]
    ShadingRate2InvocationsPerPixelNV = unchecked((uint)0x956C),

    [NativeName("GL_SHADING_RATE_4_INVOCATIONS_PER_PIXEL_NV")]
    ShadingRate4InvocationsPerPixelNV = unchecked((uint)0x956D),

    [NativeName("GL_SHADING_RATE_8_INVOCATIONS_PER_PIXEL_NV")]
    ShadingRate8InvocationsPerPixelNV = unchecked((uint)0x956E),

    [NativeName("GL_SHADING_RATE_16_INVOCATIONS_PER_PIXEL_NV")]
    ShadingRate16InvocationsPerPixelNV = unchecked((uint)0x956F),

    [NativeName("GL_SHADING_RATE_IMAGE_BINDING_NV")]
    ShadingRateImageBindingNV = unchecked((uint)0x955B),

    [NativeName("GL_SHADING_RATE_IMAGE_TEXEL_WIDTH_NV")]
    ShadingRateImageTexelWidthNV = unchecked((uint)0x955C),

    [NativeName("GL_SHADING_RATE_IMAGE_TEXEL_HEIGHT_NV")]
    ShadingRateImageTexelHeightNV = unchecked((uint)0x955D),

    [NativeName("GL_SHADING_RATE_IMAGE_PALETTE_SIZE_NV")]
    ShadingRateImagePaletteSizeNV = unchecked((uint)0x955E),

    [NativeName("GL_MAX_COARSE_FRAGMENT_SAMPLES_NV")]
    MaxCoarseFragmentSamplesNV = unchecked((uint)0x955F),

    [NativeName("GL_SHADING_RATE_SAMPLE_ORDER_DEFAULT_NV")]
    ShadingRateSampleOrderDefaultNV = unchecked((uint)0x95AE),

    [NativeName("GL_SHADING_RATE_SAMPLE_ORDER_PIXEL_MAJOR_NV")]
    ShadingRateSampleOrderPixelMajorNV = unchecked((uint)0x95AF),

    [NativeName("GL_SHADING_RATE_SAMPLE_ORDER_SAMPLE_MAJOR_NV")]
    ShadingRateSampleOrderSampleMajorNV = unchecked((uint)0x95B0),

    [NativeName("GL_MAX_PROGRAM_PATCH_ATTRIBS_NV")]
    MaxProgramPatchAttribsNV = unchecked((uint)0x86D8),

    [NativeName("GL_TESS_CONTROL_PROGRAM_NV")]
    TessControlProgramNV = unchecked((uint)0x891E),

    [NativeName("GL_TESS_EVALUATION_PROGRAM_NV")]
    TessEvaluationProgramNV = unchecked((uint)0x891F),

    [NativeName("GL_TESS_CONTROL_PROGRAM_PARAMETER_BUFFER_NV")]
    TessControlProgramParameterBufferNV = unchecked((uint)0x8C74),

    [NativeName("GL_TESS_EVALUATION_PROGRAM_PARAMETER_BUFFER_NV")]
    TessEvaluationProgramParameterBufferNV = unchecked((uint)0x8C75),

    [NativeName("GL_EMBOSS_LIGHT_NV")]
    EmbossLightNV = unchecked((uint)0x855D),

    [NativeName("GL_EMBOSS_CONSTANT_NV")]
    EmbossConstantNV = unchecked((uint)0x855E),

    [NativeName("GL_EMBOSS_MAP_NV")]
    EmbossMapNV = unchecked((uint)0x855F),

    [NativeName("GL_NORMAL_MAP_NV")]
    NormalMapNV = unchecked((uint)0x8511),

    [NativeName("GL_REFLECTION_MAP_NV")]
    ReflectionMapNV = unchecked((uint)0x8512),

    [NativeName("GL_COMBINE4_NV")]
    Combine4NV = unchecked((uint)0x8503),

    [NativeName("GL_SOURCE3_RGB_NV")]
    Source3RgbNV = unchecked((uint)0x8583),

    [NativeName("GL_SOURCE3_ALPHA_NV")]
    Source3AlphaNV = unchecked((uint)0x858B),

    [NativeName("GL_OPERAND3_RGB_NV")]
    Operand3RgbNV = unchecked((uint)0x8593),

    [NativeName("GL_OPERAND3_ALPHA_NV")]
    Operand3AlphaNV = unchecked((uint)0x859B),

    [NativeName("GL_TEXTURE_UNSIGNED_REMAP_MODE_NV")]
    TextureUnsignedRemapModeNV = unchecked((uint)0x888F),

    [NativeName("GL_TEXTURE_COVERAGE_SAMPLES_NV")]
    TextureCoverageSamplesNV = unchecked((uint)0x9045),

    [NativeName("GL_TEXTURE_COLOR_SAMPLES_NV")]
    TextureColorSamplesNV = unchecked((uint)0x9046),

    [NativeName("GL_TEXTURE_RECTANGLE_NV")]
    TextureRectangleNV = unchecked((uint)0x84F5),

    [NativeName("GL_TEXTURE_BINDING_RECTANGLE_NV")]
    TextureBindingRectangleNV = unchecked((uint)0x84F6),

    [NativeName("GL_PROXY_TEXTURE_RECTANGLE_NV")]
    ProxyTextureRectangleNV = unchecked((uint)0x84F7),

    [NativeName("GL_MAX_RECTANGLE_TEXTURE_SIZE_NV")]
    MaxRectangleTextureSizeNV = unchecked((uint)0x84F8),

    [NativeName("GL_OFFSET_TEXTURE_RECTANGLE_NV")]
    OffsetTextureRectangleNV = unchecked((uint)0x864C),

    [NativeName("GL_OFFSET_TEXTURE_RECTANGLE_SCALE_NV")]
    OffsetTextureRectangleScaleNV = unchecked((uint)0x864D),

    [NativeName("GL_DOT_PRODUCT_TEXTURE_RECTANGLE_NV")]
    DotProductTextureRectangleNV = unchecked((uint)0x864E),

    [NativeName("GL_RGBA_UNSIGNED_DOT_PRODUCT_MAPPING_NV")]
    RgbaUnsignedDotProductMappingNV = unchecked((uint)0x86D9),

    [NativeName("GL_UNSIGNED_INT_S8_S8_8_8_NV")]
    UnsignedIntS8S8X8X8NV = unchecked((uint)0x86DA),

    [NativeName("GL_UNSIGNED_INT_8_8_S8_S8_REV_NV")]
    UnsignedInt8X8S8S8RevNV = unchecked((uint)0x86DB),

    [NativeName("GL_DSDT_MAG_INTENSITY_NV")]
    DsdtMagIntensityNV = unchecked((uint)0x86DC),

    [NativeName("GL_SHADER_CONSISTENT_NV")]
    ShaderConsistentNV = unchecked((uint)0x86DD),

    [NativeName("GL_TEXTURE_SHADER_NV")]
    TextureShaderNV = unchecked((uint)0x86DE),

    [NativeName("GL_SHADER_OPERATION_NV")]
    ShaderOperationNV = unchecked((uint)0x86DF),

    [NativeName("GL_CULL_MODES_NV")]
    CullModesNV = unchecked((uint)0x86E0),

    [NativeName("GL_OFFSET_TEXTURE_MATRIX_NV")]
    OffsetTextureMatrixNV = unchecked((uint)0x86E1),

    [NativeName("GL_OFFSET_TEXTURE_SCALE_NV")]
    OffsetTextureScaleNV = unchecked((uint)0x86E2),

    [NativeName("GL_OFFSET_TEXTURE_BIAS_NV")]
    OffsetTextureBiasNV = unchecked((uint)0x86E3),

    [NativeName("GL_OFFSET_TEXTURE_2D_MATRIX_NV")]
    OffsetTexture2DMatrixNV = unchecked((uint)0x86E1),

    [NativeName("GL_OFFSET_TEXTURE_2D_SCALE_NV")]
    OffsetTexture2DScaleNV = unchecked((uint)0x86E2),

    [NativeName("GL_OFFSET_TEXTURE_2D_BIAS_NV")]
    OffsetTexture2DBiasNV = unchecked((uint)0x86E3),

    [NativeName("GL_PREVIOUS_TEXTURE_INPUT_NV")]
    PreviousTextureInputNV = unchecked((uint)0x86E4),

    [NativeName("GL_CONST_EYE_NV")]
    ConstEyeNV = unchecked((uint)0x86E5),

    [NativeName("GL_PASS_THROUGH_NV")]
    PassThroughNV = unchecked((uint)0x86E6),

    [NativeName("GL_CULL_FRAGMENT_NV")]
    CullFragmentNV = unchecked((uint)0x86E7),

    [NativeName("GL_OFFSET_TEXTURE_2D_NV")]
    OffsetTexture2DNV = unchecked((uint)0x86E8),

    [NativeName("GL_DEPENDENT_AR_TEXTURE_2D_NV")]
    DependentArTexture2DNV = unchecked((uint)0x86E9),

    [NativeName("GL_DEPENDENT_GB_TEXTURE_2D_NV")]
    DependentGbTexture2DNV = unchecked((uint)0x86EA),

    [NativeName("GL_DOT_PRODUCT_NV")]
    DotProductNV = unchecked((uint)0x86EC),

    [NativeName("GL_DOT_PRODUCT_DEPTH_REPLACE_NV")]
    DotProductDepthReplaceNV = unchecked((uint)0x86ED),

    [NativeName("GL_DOT_PRODUCT_TEXTURE_2D_NV")]
    DotProductTexture2DNV = unchecked((uint)0x86EE),

    [NativeName("GL_DOT_PRODUCT_TEXTURE_CUBE_MAP_NV")]
    DotProductTextureCubeMapNV = unchecked((uint)0x86F0),

    [NativeName("GL_DOT_PRODUCT_DIFFUSE_CUBE_MAP_NV")]
    DotProductDiffuseCubeMapNV = unchecked((uint)0x86F1),

    [NativeName("GL_DOT_PRODUCT_REFLECT_CUBE_MAP_NV")]
    DotProductReflectCubeMapNV = unchecked((uint)0x86F2),

    [NativeName("GL_DOT_PRODUCT_CONST_EYE_REFLECT_CUBE_MAP_NV")]
    DotProductConstEyeReflectCubeMapNV = unchecked((uint)0x86F3),

    [NativeName("GL_HILO_NV")]
    HiloNV = unchecked((uint)0x86F4),

    [NativeName("GL_DSDT_NV")]
    DsdtNV = unchecked((uint)0x86F5),

    [NativeName("GL_DSDT_MAG_NV")]
    DsdtMagNV = unchecked((uint)0x86F6),

    [NativeName("GL_DSDT_MAG_VIB_NV")]
    DsdtMagVibNV = unchecked((uint)0x86F7),

    [NativeName("GL_HILO16_NV")]
    Hilo16NV = unchecked((uint)0x86F8),

    [NativeName("GL_SIGNED_HILO_NV")]
    SignedHiloNV = unchecked((uint)0x86F9),

    [NativeName("GL_SIGNED_HILO16_NV")]
    SignedHilo16NV = unchecked((uint)0x86FA),

    [NativeName("GL_SIGNED_RGBA_NV")]
    SignedRgbaNV = unchecked((uint)0x86FB),

    [NativeName("GL_SIGNED_RGBA8_NV")]
    SignedRgba8NV = unchecked((uint)0x86FC),

    [NativeName("GL_SIGNED_RGB_NV")]
    SignedRgbNV = unchecked((uint)0x86FE),

    [NativeName("GL_SIGNED_RGB8_NV")]
    SignedRgb8NV = unchecked((uint)0x86FF),

    [NativeName("GL_SIGNED_LUMINANCE_NV")]
    SignedLuminanceNV = unchecked((uint)0x8701),

    [NativeName("GL_SIGNED_LUMINANCE8_NV")]
    SignedLuminance8NV = unchecked((uint)0x8702),

    [NativeName("GL_SIGNED_LUMINANCE_ALPHA_NV")]
    SignedLuminanceAlphaNV = unchecked((uint)0x8703),

    [NativeName("GL_SIGNED_LUMINANCE8_ALPHA8_NV")]
    SignedLuminance8Alpha8NV = unchecked((uint)0x8704),

    [NativeName("GL_SIGNED_ALPHA_NV")]
    SignedAlphaNV = unchecked((uint)0x8705),

    [NativeName("GL_SIGNED_ALPHA8_NV")]
    SignedAlpha8NV = unchecked((uint)0x8706),

    [NativeName("GL_SIGNED_INTENSITY_NV")]
    SignedIntensityNV = unchecked((uint)0x8707),

    [NativeName("GL_SIGNED_INTENSITY8_NV")]
    SignedIntensity8NV = unchecked((uint)0x8708),

    [NativeName("GL_DSDT8_NV")]
    Dsdt8NV = unchecked((uint)0x8709),

    [NativeName("GL_DSDT8_MAG8_NV")]
    Dsdt8Mag8NV = unchecked((uint)0x870A),

    [NativeName("GL_DSDT8_MAG8_INTENSITY8_NV")]
    Dsdt8Mag8Intensity8NV = unchecked((uint)0x870B),

    [NativeName("GL_SIGNED_RGB_UNSIGNED_ALPHA_NV")]
    SignedRgbUnsignedAlphaNV = unchecked((uint)0x870C),

    [NativeName("GL_SIGNED_RGB8_UNSIGNED_ALPHA8_NV")]
    SignedRgb8UnsignedAlpha8NV = unchecked((uint)0x870D),

    [NativeName("GL_HI_SCALE_NV")]
    HiScaleNV = unchecked((uint)0x870E),

    [NativeName("GL_LO_SCALE_NV")]
    LoScaleNV = unchecked((uint)0x870F),

    [NativeName("GL_DS_SCALE_NV")]
    DsScaleNV = unchecked((uint)0x8710),

    [NativeName("GL_DT_SCALE_NV")]
    DtScaleNV = unchecked((uint)0x8711),

    [NativeName("GL_MAGNITUDE_SCALE_NV")]
    MagnitudeScaleNV = unchecked((uint)0x8712),

    [NativeName("GL_VIBRANCE_SCALE_NV")]
    VibranceScaleNV = unchecked((uint)0x8713),

    [NativeName("GL_HI_BIAS_NV")]
    HiBiasNV = unchecked((uint)0x8714),

    [NativeName("GL_LO_BIAS_NV")]
    LoBiasNV = unchecked((uint)0x8715),

    [NativeName("GL_DS_BIAS_NV")]
    DsBiasNV = unchecked((uint)0x8716),

    [NativeName("GL_DT_BIAS_NV")]
    DtBiasNV = unchecked((uint)0x8717),

    [NativeName("GL_MAGNITUDE_BIAS_NV")]
    MagnitudeBiasNV = unchecked((uint)0x8718),

    [NativeName("GL_VIBRANCE_BIAS_NV")]
    VibranceBiasNV = unchecked((uint)0x8719),

    [NativeName("GL_TEXTURE_BORDER_VALUES_NV")]
    TextureBorderValuesNV = unchecked((uint)0x871A),

    [NativeName("GL_TEXTURE_HI_SIZE_NV")]
    TextureHiSizeNV = unchecked((uint)0x871B),

    [NativeName("GL_TEXTURE_LO_SIZE_NV")]
    TextureLoSizeNV = unchecked((uint)0x871C),

    [NativeName("GL_TEXTURE_DS_SIZE_NV")]
    TextureDsSizeNV = unchecked((uint)0x871D),

    [NativeName("GL_TEXTURE_DT_SIZE_NV")]
    TextureDtSizeNV = unchecked((uint)0x871E),

    [NativeName("GL_TEXTURE_MAG_SIZE_NV")]
    TextureMagSizeNV = unchecked((uint)0x871F),

    [NativeName("GL_DOT_PRODUCT_TEXTURE_3D_NV")]
    DotProductTexture3DNV = unchecked((uint)0x86EF),

    [NativeName("GL_OFFSET_PROJECTIVE_TEXTURE_2D_NV")]
    OffsetProjectiveTexture2DNV = unchecked((uint)0x8850),

    [NativeName("GL_OFFSET_PROJECTIVE_TEXTURE_2D_SCALE_NV")]
    OffsetProjectiveTexture2DScaleNV = unchecked((uint)0x8851),

    [NativeName("GL_OFFSET_PROJECTIVE_TEXTURE_RECTANGLE_NV")]
    OffsetProjectiveTextureRectangleNV = unchecked((uint)0x8852),

    [NativeName("GL_OFFSET_PROJECTIVE_TEXTURE_RECTANGLE_SCALE_NV")]
    OffsetProjectiveTextureRectangleScaleNV = unchecked((uint)0x8853),

    [NativeName("GL_OFFSET_HILO_TEXTURE_2D_NV")]
    OffsetHiloTexture2DNV = unchecked((uint)0x8854),

    [NativeName("GL_OFFSET_HILO_TEXTURE_RECTANGLE_NV")]
    OffsetHiloTextureRectangleNV = unchecked((uint)0x8855),

    [NativeName("GL_OFFSET_HILO_PROJECTIVE_TEXTURE_2D_NV")]
    OffsetHiloProjectiveTexture2DNV = unchecked((uint)0x8856),

    [NativeName("GL_OFFSET_HILO_PROJECTIVE_TEXTURE_RECTANGLE_NV")]
    OffsetHiloProjectiveTextureRectangleNV = unchecked((uint)0x8857),

    [NativeName("GL_DEPENDENT_HILO_TEXTURE_2D_NV")]
    DependentHiloTexture2DNV = unchecked((uint)0x8858),

    [NativeName("GL_DEPENDENT_RGB_TEXTURE_3D_NV")]
    DependentRgbTexture3DNV = unchecked((uint)0x8859),

    [NativeName("GL_DEPENDENT_RGB_TEXTURE_CUBE_MAP_NV")]
    DependentRgbTextureCubeMapNV = unchecked((uint)0x885A),

    [NativeName("GL_DOT_PRODUCT_PASS_THROUGH_NV")]
    DotProductPassThroughNV = unchecked((uint)0x885B),

    [NativeName("GL_DOT_PRODUCT_TEXTURE_1D_NV")]
    DotProductTexture1DNV = unchecked((uint)0x885C),

    [NativeName("GL_DOT_PRODUCT_AFFINE_DEPTH_REPLACE_NV")]
    DotProductAffineDepthReplaceNV = unchecked((uint)0x885D),

    [NativeName("GL_HILO8_NV")]
    Hilo8NV = unchecked((uint)0x885E),

    [NativeName("GL_SIGNED_HILO8_NV")]
    SignedHilo8NV = unchecked((uint)0x885F),

    [NativeName("GL_FORCE_BLUE_TO_ONE_NV")]
    ForceBlueToOneNV = unchecked((uint)0x8860),

    [NativeName("GL_TIMELINE_SEMAPHORE_VALUE_NV")]
    TimelineSemaphoreValueNV = unchecked((uint)0x9595),

    [NativeName("GL_SEMAPHORE_TYPE_NV")]
    SemaphoreTypeNV = unchecked((uint)0x95B3),

    [NativeName("GL_SEMAPHORE_TYPE_BINARY_NV")]
    SemaphoreTypeBinaryNV = unchecked((uint)0x95B4),

    [NativeName("GL_SEMAPHORE_TYPE_TIMELINE_NV")]
    SemaphoreTypeTimelineNV = unchecked((uint)0x95B5),

    [NativeName("GL_MAX_TIMELINE_SEMAPHORE_VALUE_DIFFERENCE_NV")]
    MaxTimelineSemaphoreValueDifferenceNV = unchecked((uint)0x95B6),

    [NativeName("GL_BACK_PRIMARY_COLOR_NV")]
    BackPrimaryColorNV = unchecked((uint)0x8C77),

    [NativeName("GL_BACK_SECONDARY_COLOR_NV")]
    BackSecondaryColorNV = unchecked((uint)0x8C78),

    [NativeName("GL_TEXTURE_COORD_NV")]
    TextureCoordNV = unchecked((uint)0x8C79),

    [NativeName("GL_CLIP_DISTANCE_NV")]
    ClipDistanceNV = unchecked((uint)0x8C7A),

    [NativeName("GL_VERTEX_ID_NV")]
    VertexIdNV = unchecked((uint)0x8C7B),

    [NativeName("GL_PRIMITIVE_ID_NV")]
    PrimitiveIdNV = unchecked((uint)0x8C7C),

    [NativeName("GL_GENERIC_ATTRIB_NV")]
    GenericAttribNV = unchecked((uint)0x8C7D),

    [NativeName("GL_TRANSFORM_FEEDBACK_ATTRIBS_NV")]
    TransformFeedbackAttribsNV = unchecked((uint)0x8C7E),

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_MODE_NV")]
    TransformFeedbackBufferModeNV = unchecked((uint)0x8C7F),

    [NativeName("GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS_NV")]
    MaxTransformFeedbackSeparateComponentsNV = unchecked((uint)0x8C80),

    [NativeName("GL_ACTIVE_VARYINGS_NV")]
    ActiveVaryingsNV = unchecked((uint)0x8C81),

    [NativeName("GL_ACTIVE_VARYING_MAX_LENGTH_NV")]
    ActiveVaryingMaxLengthNV = unchecked((uint)0x8C82),

    [NativeName("GL_TRANSFORM_FEEDBACK_VARYINGS_NV")]
    TransformFeedbackVaryingsNV = unchecked((uint)0x8C83),

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_START_NV")]
    TransformFeedbackBufferStartNV = unchecked((uint)0x8C84),

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_SIZE_NV")]
    TransformFeedbackBufferSizeNV = unchecked((uint)0x8C85),

    [NativeName("GL_TRANSFORM_FEEDBACK_RECORD_NV")]
    TransformFeedbackRecordNV = unchecked((uint)0x8C86),

    [NativeName("GL_PRIMITIVES_GENERATED_NV")]
    PrimitivesGeneratedNV = unchecked((uint)0x8C87),

    [NativeName("GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN_NV")]
    TransformFeedbackPrimitivesWrittenNV = unchecked((uint)0x8C88),

    [NativeName("GL_RASTERIZER_DISCARD_NV")]
    RasterizerDiscardNV = unchecked((uint)0x8C89),

    [NativeName("GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS_NV")]
    MaxTransformFeedbackInterleavedComponentsNV = unchecked((uint)0x8C8A),

    [NativeName("GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS_NV")]
    MaxTransformFeedbackSeparateAttribsNV = unchecked((uint)0x8C8B),

    [NativeName("GL_INTERLEAVED_ATTRIBS_NV")]
    InterleavedAttribsNV = unchecked((uint)0x8C8C),

    [NativeName("GL_SEPARATE_ATTRIBS_NV")]
    SeparateAttribsNV = unchecked((uint)0x8C8D),

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_NV")]
    TransformFeedbackBufferNV = unchecked((uint)0x8C8E),

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_BINDING_NV")]
    TransformFeedbackBufferBindingNV = unchecked((uint)0x8C8F),

    [NativeName("GL_LAYER_NV")]
    LayerNV = unchecked((uint)0x8DAA),

    [NativeName("GL_NEXT_BUFFER_NV")]
    NextBufferNV = unchecked((uint)-2),

    [NativeName("GL_SKIP_COMPONENTS4_NV")]
    SkipComponents4NV = unchecked((uint)-3),

    [NativeName("GL_SKIP_COMPONENTS3_NV")]
    SkipComponents3NV = unchecked((uint)-4),

    [NativeName("GL_SKIP_COMPONENTS2_NV")]
    SkipComponents2NV = unchecked((uint)-5),

    [NativeName("GL_SKIP_COMPONENTS1_NV")]
    SkipComponents1NV = unchecked((uint)-6),

    [NativeName("GL_TRANSFORM_FEEDBACK_NV")]
    TransformFeedbackNV = unchecked((uint)0x8E22),

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED_NV")]
    TransformFeedbackBufferPausedNV = unchecked((uint)0x8E23),

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE_NV")]
    TransformFeedbackBufferActiveNV = unchecked((uint)0x8E24),

    [NativeName("GL_TRANSFORM_FEEDBACK_BINDING_NV")]
    TransformFeedbackBindingNV = unchecked((uint)0x8E25),

    [NativeName("GL_UNIFORM_BUFFER_UNIFIED_NV")]
    UniformBufferUnifiedNV = unchecked((uint)0x936E),

    [NativeName("GL_UNIFORM_BUFFER_ADDRESS_NV")]
    UniformBufferAddressNV = unchecked((uint)0x936F),

    [NativeName("GL_UNIFORM_BUFFER_LENGTH_NV")]
    UniformBufferLengthNV = unchecked((uint)0x9370),

    [NativeName("GL_SURFACE_STATE_NV")]
    SurfaceStateNV = unchecked((uint)0x86EB),

    [NativeName("GL_SURFACE_REGISTERED_NV")]
    SurfaceRegisteredNV = unchecked((uint)0x86FD),

    [NativeName("GL_SURFACE_MAPPED_NV")]
    SurfaceMappedNV = unchecked((uint)0x8700),

    [NativeName("GL_WRITE_DISCARD_NV")]
    WriteDiscardNV = unchecked((uint)0x88BE),

    [NativeName("GL_VERTEX_ARRAY_RANGE_NV")]
    VertexArrayRangeNV = unchecked((uint)0x851D),

    [NativeName("GL_VERTEX_ARRAY_RANGE_LENGTH_NV")]
    VertexArrayRangeLengthNV = unchecked((uint)0x851E),

    [NativeName("GL_VERTEX_ARRAY_RANGE_VALID_NV")]
    VertexArrayRangeValidNV = unchecked((uint)0x851F),

    [NativeName("GL_MAX_VERTEX_ARRAY_RANGE_ELEMENT_NV")]
    MaxVertexArrayRangeElementNV = unchecked((uint)0x8520),

    [NativeName("GL_VERTEX_ARRAY_RANGE_POINTER_NV")]
    VertexArrayRangePointerNV = unchecked((uint)0x8521),

    [NativeName("GL_VERTEX_ARRAY_RANGE_WITHOUT_FLUSH_NV")]
    VertexArrayRangeWithoutFlushNV = unchecked((uint)0x8533),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_UNIFIED_NV")]
    VertexAttribArrayUnifiedNV = unchecked((uint)0x8F1E),

    [NativeName("GL_ELEMENT_ARRAY_UNIFIED_NV")]
    ElementArrayUnifiedNV = unchecked((uint)0x8F1F),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_ADDRESS_NV")]
    VertexAttribArrayAddressNV = unchecked((uint)0x8F20),

    [NativeName("GL_VERTEX_ARRAY_ADDRESS_NV")]
    VertexArrayAddressNV = unchecked((uint)0x8F21),

    [NativeName("GL_NORMAL_ARRAY_ADDRESS_NV")]
    NormalArrayAddressNV = unchecked((uint)0x8F22),

    [NativeName("GL_COLOR_ARRAY_ADDRESS_NV")]
    ColorArrayAddressNV = unchecked((uint)0x8F23),

    [NativeName("GL_INDEX_ARRAY_ADDRESS_NV")]
    IndexArrayAddressNV = unchecked((uint)0x8F24),

    [NativeName("GL_TEXTURE_COORD_ARRAY_ADDRESS_NV")]
    TextureCoordArrayAddressNV = unchecked((uint)0x8F25),

    [NativeName("GL_EDGE_FLAG_ARRAY_ADDRESS_NV")]
    EdgeFlagArrayAddressNV = unchecked((uint)0x8F26),

    [NativeName("GL_SECONDARY_COLOR_ARRAY_ADDRESS_NV")]
    SecondaryColorArrayAddressNV = unchecked((uint)0x8F27),

    [NativeName("GL_FOG_COORD_ARRAY_ADDRESS_NV")]
    FogCoordArrayAddressNV = unchecked((uint)0x8F28),

    [NativeName("GL_ELEMENT_ARRAY_ADDRESS_NV")]
    ElementArrayAddressNV = unchecked((uint)0x8F29),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_LENGTH_NV")]
    VertexAttribArrayLengthNV = unchecked((uint)0x8F2A),

    [NativeName("GL_VERTEX_ARRAY_LENGTH_NV")]
    VertexArrayLengthNV = unchecked((uint)0x8F2B),

    [NativeName("GL_NORMAL_ARRAY_LENGTH_NV")]
    NormalArrayLengthNV = unchecked((uint)0x8F2C),

    [NativeName("GL_COLOR_ARRAY_LENGTH_NV")]
    ColorArrayLengthNV = unchecked((uint)0x8F2D),

    [NativeName("GL_INDEX_ARRAY_LENGTH_NV")]
    IndexArrayLengthNV = unchecked((uint)0x8F2E),

    [NativeName("GL_TEXTURE_COORD_ARRAY_LENGTH_NV")]
    TextureCoordArrayLengthNV = unchecked((uint)0x8F2F),

    [NativeName("GL_EDGE_FLAG_ARRAY_LENGTH_NV")]
    EdgeFlagArrayLengthNV = unchecked((uint)0x8F30),

    [NativeName("GL_SECONDARY_COLOR_ARRAY_LENGTH_NV")]
    SecondaryColorArrayLengthNV = unchecked((uint)0x8F31),

    [NativeName("GL_FOG_COORD_ARRAY_LENGTH_NV")]
    FogCoordArrayLengthNV = unchecked((uint)0x8F32),

    [NativeName("GL_ELEMENT_ARRAY_LENGTH_NV")]
    ElementArrayLengthNV = unchecked((uint)0x8F33),

    [NativeName("GL_DRAW_INDIRECT_UNIFIED_NV")]
    DrawIndirectUnifiedNV = unchecked((uint)0x8F40),

    [NativeName("GL_DRAW_INDIRECT_ADDRESS_NV")]
    DrawIndirectAddressNV = unchecked((uint)0x8F41),

    [NativeName("GL_DRAW_INDIRECT_LENGTH_NV")]
    DrawIndirectLengthNV = unchecked((uint)0x8F42),

    [NativeName("GL_VERTEX_PROGRAM_NV")]
    VertexProgramNV = unchecked((uint)0x8620),

    [NativeName("GL_VERTEX_STATE_PROGRAM_NV")]
    VertexStateProgramNV = unchecked((uint)0x8621),

    [NativeName("GL_ATTRIB_ARRAY_SIZE_NV")]
    AttribArraySizeNV = unchecked((uint)0x8623),

    [NativeName("GL_ATTRIB_ARRAY_STRIDE_NV")]
    AttribArrayStrideNV = unchecked((uint)0x8624),

    [NativeName("GL_ATTRIB_ARRAY_TYPE_NV")]
    AttribArrayTypeNV = unchecked((uint)0x8625),

    [NativeName("GL_CURRENT_ATTRIB_NV")]
    CurrentAttribNV = unchecked((uint)0x8626),

    [NativeName("GL_PROGRAM_LENGTH_NV")]
    ProgramLengthNV = unchecked((uint)0x8627),

    [NativeName("GL_PROGRAM_STRING_NV")]
    ProgramStringNV = unchecked((uint)0x8628),

    [NativeName("GL_MODELVIEW_PROJECTION_NV")]
    ModelviewProjectionNV = unchecked((uint)0x8629),

    [NativeName("GL_IDENTITY_NV")]
    IdentityNV = unchecked((uint)0x862A),

    [NativeName("GL_INVERSE_NV")]
    InverseNV = unchecked((uint)0x862B),

    [NativeName("GL_TRANSPOSE_NV")]
    TransposeNV = unchecked((uint)0x862C),

    [NativeName("GL_INVERSE_TRANSPOSE_NV")]
    InverseTransposeNV = unchecked((uint)0x862D),

    [NativeName("GL_MAX_TRACK_MATRIX_STACK_DEPTH_NV")]
    MaxTrackMatrixStackDepthNV = unchecked((uint)0x862E),

    [NativeName("GL_MAX_TRACK_MATRICES_NV")]
    MaxTrackMatricesNV = unchecked((uint)0x862F),

    [NativeName("GL_MATRIX0_NV")]
    Matrix0NV = unchecked((uint)0x8630),

    [NativeName("GL_MATRIX1_NV")]
    Matrix1NV = unchecked((uint)0x8631),

    [NativeName("GL_MATRIX2_NV")]
    Matrix2NV = unchecked((uint)0x8632),

    [NativeName("GL_MATRIX3_NV")]
    Matrix3NV = unchecked((uint)0x8633),

    [NativeName("GL_MATRIX4_NV")]
    Matrix4NV = unchecked((uint)0x8634),

    [NativeName("GL_MATRIX5_NV")]
    Matrix5NV = unchecked((uint)0x8635),

    [NativeName("GL_MATRIX6_NV")]
    Matrix6NV = unchecked((uint)0x8636),

    [NativeName("GL_MATRIX7_NV")]
    Matrix7NV = unchecked((uint)0x8637),

    [NativeName("GL_CURRENT_MATRIX_STACK_DEPTH_NV")]
    CurrentMatrixStackDepthNV = unchecked((uint)0x8640),

    [NativeName("GL_CURRENT_MATRIX_NV")]
    CurrentMatrixNV = unchecked((uint)0x8641),

    [NativeName("GL_VERTEX_PROGRAM_POINT_SIZE_NV")]
    VertexProgramPointSizeNV = unchecked((uint)0x8642),

    [NativeName("GL_VERTEX_PROGRAM_TWO_SIDE_NV")]
    VertexProgramTwoSideNV = unchecked((uint)0x8643),

    [NativeName("GL_PROGRAM_PARAMETER_NV")]
    ProgramParameterNV = unchecked((uint)0x8644),

    [NativeName("GL_ATTRIB_ARRAY_POINTER_NV")]
    AttribArrayPointerNV = unchecked((uint)0x8645),

    [NativeName("GL_PROGRAM_TARGET_NV")]
    ProgramTargetNV = unchecked((uint)0x8646),

    [NativeName("GL_PROGRAM_RESIDENT_NV")]
    ProgramResidentNV = unchecked((uint)0x8647),

    [NativeName("GL_TRACK_MATRIX_NV")]
    TrackMatrixNV = unchecked((uint)0x8648),

    [NativeName("GL_TRACK_MATRIX_TRANSFORM_NV")]
    TrackMatrixTransformNV = unchecked((uint)0x8649),

    [NativeName("GL_VERTEX_PROGRAM_BINDING_NV")]
    VertexProgramBindingNV = unchecked((uint)0x864A),

    [NativeName("GL_PROGRAM_ERROR_POSITION_NV")]
    ProgramErrorPositionNV = unchecked((uint)0x864B),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY0_NV")]
    VertexAttribArray0NV = unchecked((uint)0x8650),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY1_NV")]
    VertexAttribArray1NV = unchecked((uint)0x8651),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY2_NV")]
    VertexAttribArray2NV = unchecked((uint)0x8652),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY3_NV")]
    VertexAttribArray3NV = unchecked((uint)0x8653),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY4_NV")]
    VertexAttribArray4NV = unchecked((uint)0x8654),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY5_NV")]
    VertexAttribArray5NV = unchecked((uint)0x8655),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY6_NV")]
    VertexAttribArray6NV = unchecked((uint)0x8656),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY7_NV")]
    VertexAttribArray7NV = unchecked((uint)0x8657),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY8_NV")]
    VertexAttribArray8NV = unchecked((uint)0x8658),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY9_NV")]
    VertexAttribArray9NV = unchecked((uint)0x8659),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY10_NV")]
    VertexAttribArray10NV = unchecked((uint)0x865A),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY11_NV")]
    VertexAttribArray11NV = unchecked((uint)0x865B),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY12_NV")]
    VertexAttribArray12NV = unchecked((uint)0x865C),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY13_NV")]
    VertexAttribArray13NV = unchecked((uint)0x865D),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY14_NV")]
    VertexAttribArray14NV = unchecked((uint)0x865E),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY15_NV")]
    VertexAttribArray15NV = unchecked((uint)0x865F),

    [NativeName("GL_MAP1_VERTEX_ATTRIB0_4_NV")]
    Map1VertexAttrib0X4NV = unchecked((uint)0x8660),

    [NativeName("GL_MAP1_VERTEX_ATTRIB1_4_NV")]
    Map1VertexAttrib1X4NV = unchecked((uint)0x8661),

    [NativeName("GL_MAP1_VERTEX_ATTRIB2_4_NV")]
    Map1VertexAttrib2X4NV = unchecked((uint)0x8662),

    [NativeName("GL_MAP1_VERTEX_ATTRIB3_4_NV")]
    Map1VertexAttrib3X4NV = unchecked((uint)0x8663),

    [NativeName("GL_MAP1_VERTEX_ATTRIB4_4_NV")]
    Map1VertexAttrib4X4NV = unchecked((uint)0x8664),

    [NativeName("GL_MAP1_VERTEX_ATTRIB5_4_NV")]
    Map1VertexAttrib5X4NV = unchecked((uint)0x8665),

    [NativeName("GL_MAP1_VERTEX_ATTRIB6_4_NV")]
    Map1VertexAttrib6X4NV = unchecked((uint)0x8666),

    [NativeName("GL_MAP1_VERTEX_ATTRIB7_4_NV")]
    Map1VertexAttrib7X4NV = unchecked((uint)0x8667),

    [NativeName("GL_MAP1_VERTEX_ATTRIB8_4_NV")]
    Map1VertexAttrib8X4NV = unchecked((uint)0x8668),

    [NativeName("GL_MAP1_VERTEX_ATTRIB9_4_NV")]
    Map1VertexAttrib9X4NV = unchecked((uint)0x8669),

    [NativeName("GL_MAP1_VERTEX_ATTRIB10_4_NV")]
    Map1VertexAttrib10X4NV = unchecked((uint)0x866A),

    [NativeName("GL_MAP1_VERTEX_ATTRIB11_4_NV")]
    Map1VertexAttrib11X4NV = unchecked((uint)0x866B),

    [NativeName("GL_MAP1_VERTEX_ATTRIB12_4_NV")]
    Map1VertexAttrib12X4NV = unchecked((uint)0x866C),

    [NativeName("GL_MAP1_VERTEX_ATTRIB13_4_NV")]
    Map1VertexAttrib13X4NV = unchecked((uint)0x866D),

    [NativeName("GL_MAP1_VERTEX_ATTRIB14_4_NV")]
    Map1VertexAttrib14X4NV = unchecked((uint)0x866E),

    [NativeName("GL_MAP1_VERTEX_ATTRIB15_4_NV")]
    Map1VertexAttrib15X4NV = unchecked((uint)0x866F),

    [NativeName("GL_MAP2_VERTEX_ATTRIB0_4_NV")]
    Map2VertexAttrib0X4NV = unchecked((uint)0x8670),

    [NativeName("GL_MAP2_VERTEX_ATTRIB1_4_NV")]
    Map2VertexAttrib1X4NV = unchecked((uint)0x8671),

    [NativeName("GL_MAP2_VERTEX_ATTRIB2_4_NV")]
    Map2VertexAttrib2X4NV = unchecked((uint)0x8672),

    [NativeName("GL_MAP2_VERTEX_ATTRIB3_4_NV")]
    Map2VertexAttrib3X4NV = unchecked((uint)0x8673),

    [NativeName("GL_MAP2_VERTEX_ATTRIB4_4_NV")]
    Map2VertexAttrib4X4NV = unchecked((uint)0x8674),

    [NativeName("GL_MAP2_VERTEX_ATTRIB5_4_NV")]
    Map2VertexAttrib5X4NV = unchecked((uint)0x8675),

    [NativeName("GL_MAP2_VERTEX_ATTRIB6_4_NV")]
    Map2VertexAttrib6X4NV = unchecked((uint)0x8676),

    [NativeName("GL_MAP2_VERTEX_ATTRIB7_4_NV")]
    Map2VertexAttrib7X4NV = unchecked((uint)0x8677),

    [NativeName("GL_MAP2_VERTEX_ATTRIB8_4_NV")]
    Map2VertexAttrib8X4NV = unchecked((uint)0x8678),

    [NativeName("GL_MAP2_VERTEX_ATTRIB9_4_NV")]
    Map2VertexAttrib9X4NV = unchecked((uint)0x8679),

    [NativeName("GL_MAP2_VERTEX_ATTRIB10_4_NV")]
    Map2VertexAttrib10X4NV = unchecked((uint)0x867A),

    [NativeName("GL_MAP2_VERTEX_ATTRIB11_4_NV")]
    Map2VertexAttrib11X4NV = unchecked((uint)0x867B),

    [NativeName("GL_MAP2_VERTEX_ATTRIB12_4_NV")]
    Map2VertexAttrib12X4NV = unchecked((uint)0x867C),

    [NativeName("GL_MAP2_VERTEX_ATTRIB13_4_NV")]
    Map2VertexAttrib13X4NV = unchecked((uint)0x867D),

    [NativeName("GL_MAP2_VERTEX_ATTRIB14_4_NV")]
    Map2VertexAttrib14X4NV = unchecked((uint)0x867E),

    [NativeName("GL_MAP2_VERTEX_ATTRIB15_4_NV")]
    Map2VertexAttrib15X4NV = unchecked((uint)0x867F),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_INTEGER_NV")]
    VertexAttribArrayIntegerNV = unchecked((uint)0x88FD),

    [NativeName("GL_VIDEO_BUFFER_NV")]
    VideoBufferNV = unchecked((uint)0x9020),

    [NativeName("GL_VIDEO_BUFFER_BINDING_NV")]
    VideoBufferBindingNV = unchecked((uint)0x9021),

    [NativeName("GL_FIELD_UPPER_NV")]
    FieldUpperNV = unchecked((uint)0x9022),

    [NativeName("GL_FIELD_LOWER_NV")]
    FieldLowerNV = unchecked((uint)0x9023),

    [NativeName("GL_NUM_VIDEO_CAPTURE_STREAMS_NV")]
    NumVideoCaptureStreamsNV = unchecked((uint)0x9024),

    [NativeName("GL_NEXT_VIDEO_CAPTURE_BUFFER_STATUS_NV")]
    NextVideoCaptureBufferStatusNV = unchecked((uint)0x9025),

    [NativeName("GL_VIDEO_CAPTURE_TO_422_SUPPORTED_NV")]
    VideoCaptureTo422SupportedNV = unchecked((uint)0x9026),

    [NativeName("GL_LAST_VIDEO_CAPTURE_STATUS_NV")]
    LastVideoCaptureStatusNV = unchecked((uint)0x9027),

    [NativeName("GL_VIDEO_BUFFER_PITCH_NV")]
    VideoBufferPitchNV = unchecked((uint)0x9028),

    [NativeName("GL_VIDEO_COLOR_CONVERSION_MATRIX_NV")]
    VideoColorConversionMatrixNV = unchecked((uint)0x9029),

    [NativeName("GL_VIDEO_COLOR_CONVERSION_MAX_NV")]
    VideoColorConversionMaxNV = unchecked((uint)0x902A),

    [NativeName("GL_VIDEO_COLOR_CONVERSION_MIN_NV")]
    VideoColorConversionMinNV = unchecked((uint)0x902B),

    [NativeName("GL_VIDEO_COLOR_CONVERSION_OFFSET_NV")]
    VideoColorConversionOffsetNV = unchecked((uint)0x902C),

    [NativeName("GL_VIDEO_BUFFER_INTERNAL_FORMAT_NV")]
    VideoBufferInternalFormatNV = unchecked((uint)0x902D),

    [NativeName("GL_PARTIAL_SUCCESS_NV")]
    PartialSuccessNV = unchecked((uint)0x902E),

    [NativeName("GL_SUCCESS_NV")]
    SuccessNV = unchecked((uint)0x902F),

    [NativeName("GL_FAILURE_NV")]
    FailureNV = unchecked((uint)0x9030),

    [NativeName("GL_YCBYCR8_422_NV")]
    Ycbycr8X422NV = unchecked((uint)0x9031),

    [NativeName("GL_YCBAYCR8A_4224_NV")]
    Ycbaycr8A4224NV = unchecked((uint)0x9032),

    [NativeName("GL_Z6Y10Z6CB10Z6Y10Z6CR10_422_NV")]
    Z6Y10Z6Cb10Z6Y10Z6Cr10X422NV = unchecked((uint)0x9033),

    [NativeName("GL_Z6Y10Z6CB10Z6A10Z6Y10Z6CR10Z6A10_4224_NV")]
    Z6Y10Z6Cb10Z6A10Z6Y10Z6Cr10Z6A10X4224NV = unchecked((uint)0x9034),

    [NativeName("GL_Z4Y12Z4CB12Z4Y12Z4CR12_422_NV")]
    Z4Y12Z4Cb12Z4Y12Z4Cr12X422NV = unchecked((uint)0x9035),

    [NativeName("GL_Z4Y12Z4CB12Z4A12Z4Y12Z4CR12Z4A12_4224_NV")]
    Z4Y12Z4Cb12Z4A12Z4Y12Z4Cr12Z4A12X4224NV = unchecked((uint)0x9036),

    [NativeName("GL_Z4Y12Z4CB12Z4CR12_444_NV")]
    Z4Y12Z4Cb12Z4Cr12X444NV = unchecked((uint)0x9037),

    [NativeName("GL_VIDEO_CAPTURE_FRAME_WIDTH_NV")]
    VideoCaptureFrameWidthNV = unchecked((uint)0x9038),

    [NativeName("GL_VIDEO_CAPTURE_FRAME_HEIGHT_NV")]
    VideoCaptureFrameHeightNV = unchecked((uint)0x9039),

    [NativeName("GL_VIDEO_CAPTURE_FIELD_UPPER_HEIGHT_NV")]
    VideoCaptureFieldUpperHeightNV = unchecked((uint)0x903A),

    [NativeName("GL_VIDEO_CAPTURE_FIELD_LOWER_HEIGHT_NV")]
    VideoCaptureFieldLowerHeightNV = unchecked((uint)0x903B),

    [NativeName("GL_VIDEO_CAPTURE_SURFACE_ORIGIN_NV")]
    VideoCaptureSurfaceOriginNV = unchecked((uint)0x903C),

    [NativeName("GL_VIEWPORT_SWIZZLE_POSITIVE_X_NV")]
    ViewportSwizzlePositiveXNV = unchecked((uint)0x9350),

    [NativeName("GL_VIEWPORT_SWIZZLE_NEGATIVE_X_NV")]
    ViewportSwizzleNegativeXNV = unchecked((uint)0x9351),

    [NativeName("GL_VIEWPORT_SWIZZLE_POSITIVE_Y_NV")]
    ViewportSwizzlePositiveYNV = unchecked((uint)0x9352),

    [NativeName("GL_VIEWPORT_SWIZZLE_NEGATIVE_Y_NV")]
    ViewportSwizzleNegativeYNV = unchecked((uint)0x9353),

    [NativeName("GL_VIEWPORT_SWIZZLE_POSITIVE_Z_NV")]
    ViewportSwizzlePositiveZNV = unchecked((uint)0x9354),

    [NativeName("GL_VIEWPORT_SWIZZLE_NEGATIVE_Z_NV")]
    ViewportSwizzleNegativeZNV = unchecked((uint)0x9355),

    [NativeName("GL_VIEWPORT_SWIZZLE_POSITIVE_W_NV")]
    ViewportSwizzlePositiveWNV = unchecked((uint)0x9356),

    [NativeName("GL_VIEWPORT_SWIZZLE_NEGATIVE_W_NV")]
    ViewportSwizzleNegativeWNV = unchecked((uint)0x9357),

    [NativeName("GL_VIEWPORT_SWIZZLE_X_NV")]
    ViewportSwizzleXNV = unchecked((uint)0x9358),

    [NativeName("GL_VIEWPORT_SWIZZLE_Y_NV")]
    ViewportSwizzleYNV = unchecked((uint)0x9359),

    [NativeName("GL_VIEWPORT_SWIZZLE_Z_NV")]
    ViewportSwizzleZNV = unchecked((uint)0x935A),

    [NativeName("GL_VIEWPORT_SWIZZLE_W_NV")]
    ViewportSwizzleWNV = unchecked((uint)0x935B),

    [NativeName("GL_INTERLACE_OML")]
    InterlaceOML = unchecked((uint)0x8980),

    [NativeName("GL_INTERLACE_READ_OML")]
    InterlaceReadOML = unchecked((uint)0x8981),

    [NativeName("GL_PACK_RESAMPLE_OML")]
    PackResampleOML = unchecked((uint)0x8984),

    [NativeName("GL_UNPACK_RESAMPLE_OML")]
    UnpackResampleOML = unchecked((uint)0x8985),

    [NativeName("GL_RESAMPLE_REPLICATE_OML")]
    ResampleReplicateOML = unchecked((uint)0x8986),

    [NativeName("GL_RESAMPLE_ZERO_FILL_OML")]
    ResampleZeroFillOML = unchecked((uint)0x8987),

    [NativeName("GL_RESAMPLE_AVERAGE_OML")]
    ResampleAverageOML = unchecked((uint)0x8988),

    [NativeName("GL_RESAMPLE_DECIMATE_OML")]
    ResampleDecimateOML = unchecked((uint)0x8989),

    [NativeName("GL_FORMAT_SUBSAMPLE_24_24_OML")]
    FormatSubsample24X24OML = unchecked((uint)0x8982),

    [NativeName("GL_FORMAT_SUBSAMPLE_244_244_OML")]
    FormatSubsample244X244OML = unchecked((uint)0x8983),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_NUM_VIEWS_OVR")]
    FramebufferAttachmentTextureNumViewsOVR = unchecked((uint)0x9630),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_BASE_VIEW_INDEX_OVR")]
    FramebufferAttachmentTextureBaseViewIndexOVR = unchecked((uint)0x9632),

    [NativeName("GL_MAX_VIEWS_OVR")]
    MaxViewsOVR = unchecked((uint)0x9631),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_VIEW_TARGETS_OVR")]
    FramebufferIncompleteViewTargetsOVR = unchecked((uint)0x9633),

    [NativeName("GL_PREFER_DOUBLEBUFFER_HINT_PGI")]
    PreferDoublebufferHintPGI = unchecked((uint)0x1A1F8),

    [NativeName("GL_CONSERVE_MEMORY_HINT_PGI")]
    ConserveMemoryHintPGI = unchecked((uint)0x1A1FD),

    [NativeName("GL_RECLAIM_MEMORY_HINT_PGI")]
    ReclaimMemoryHintPGI = unchecked((uint)0x1A1FE),

    [NativeName("GL_NATIVE_GRAPHICS_HANDLE_PGI")]
    NativeGraphicsHandlePGI = unchecked((uint)0x1A202),

    [NativeName("GL_NATIVE_GRAPHICS_BEGIN_HINT_PGI")]
    NativeGraphicsBeginHintPGI = unchecked((uint)0x1A203),

    [NativeName("GL_NATIVE_GRAPHICS_END_HINT_PGI")]
    NativeGraphicsEndHintPGI = unchecked((uint)0x1A204),

    [NativeName("GL_ALWAYS_FAST_HINT_PGI")]
    AlwaysFastHintPGI = unchecked((uint)0x1A20C),

    [NativeName("GL_ALWAYS_SOFT_HINT_PGI")]
    AlwaysSoftHintPGI = unchecked((uint)0x1A20D),

    [NativeName("GL_ALLOW_DRAW_OBJ_HINT_PGI")]
    AllowDrawObjHintPGI = unchecked((uint)0x1A20E),

    [NativeName("GL_ALLOW_DRAW_WIN_HINT_PGI")]
    AllowDrawWinHintPGI = unchecked((uint)0x1A20F),

    [NativeName("GL_ALLOW_DRAW_FRG_HINT_PGI")]
    AllowDrawFrgHintPGI = unchecked((uint)0x1A210),

    [NativeName("GL_ALLOW_DRAW_MEM_HINT_PGI")]
    AllowDrawMemHintPGI = unchecked((uint)0x1A211),

    [NativeName("GL_STRICT_DEPTHFUNC_HINT_PGI")]
    StrictDepthfuncHintPGI = unchecked((uint)0x1A216),

    [NativeName("GL_STRICT_LIGHTING_HINT_PGI")]
    StrictLightingHintPGI = unchecked((uint)0x1A217),

    [NativeName("GL_STRICT_SCISSOR_HINT_PGI")]
    StrictScissorHintPGI = unchecked((uint)0x1A218),

    [NativeName("GL_FULL_STIPPLE_HINT_PGI")]
    FullStippleHintPGI = unchecked((uint)0x1A219),

    [NativeName("GL_CLIP_NEAR_HINT_PGI")]
    ClipNearHintPGI = unchecked((uint)0x1A220),

    [NativeName("GL_CLIP_FAR_HINT_PGI")]
    ClipFarHintPGI = unchecked((uint)0x1A221),

    [NativeName("GL_WIDE_LINE_HINT_PGI")]
    WideLineHintPGI = unchecked((uint)0x1A222),

    [NativeName("GL_BACK_NORMALS_HINT_PGI")]
    BackNormalsHintPGI = unchecked((uint)0x1A223),

    [NativeName("GL_VERTEX_DATA_HINT_PGI")]
    VertexDataHintPGI = unchecked((uint)0x1A22A),

    [NativeName("GL_VERTEX_CONSISTENT_HINT_PGI")]
    VertexConsistentHintPGI = unchecked((uint)0x1A22B),

    [NativeName("GL_MATERIAL_SIDE_HINT_PGI")]
    MaterialSideHintPGI = unchecked((uint)0x1A22C),

    [NativeName("GL_MAX_VERTEX_HINT_PGI")]
    MaxVertexHintPGI = unchecked((uint)0x1A22D),

    [NativeName("GL_COLOR3_BIT_PGI")]
    Color3BitPGI = unchecked((uint)0x00010000),

    [NativeName("GL_COLOR4_BIT_PGI")]
    Color4BitPGI = unchecked((uint)0x00020000),

    [NativeName("GL_EDGEFLAG_BIT_PGI")]
    EdgeflagBitPGI = unchecked((uint)0x00040000),

    [NativeName("GL_INDEX_BIT_PGI")]
    IndexBitPGI = unchecked((uint)0x00080000),

    [NativeName("GL_MAT_AMBIENT_BIT_PGI")]
    MatAmbientBitPGI = unchecked((uint)0x00100000),

    [NativeName("GL_MAT_AMBIENT_AND_DIFFUSE_BIT_PGI")]
    MatAmbientAndDiffuseBitPGI = unchecked((uint)0x00200000),

    [NativeName("GL_MAT_DIFFUSE_BIT_PGI")]
    MatDiffuseBitPGI = unchecked((uint)0x00400000),

    [NativeName("GL_MAT_EMISSION_BIT_PGI")]
    MatEmissionBitPGI = unchecked((uint)0x00800000),

    [NativeName("GL_MAT_COLOR_INDEXES_BIT_PGI")]
    MatColorIndexesBitPGI = unchecked((uint)0x01000000),

    [NativeName("GL_MAT_SHININESS_BIT_PGI")]
    MatShininessBitPGI = unchecked((uint)0x02000000),

    [NativeName("GL_MAT_SPECULAR_BIT_PGI")]
    MatSpecularBitPGI = unchecked((uint)0x04000000),

    [NativeName("GL_NORMAL_BIT_PGI")]
    NormalBitPGI = unchecked((uint)0x08000000),

    [NativeName("GL_TEXCOORD1_BIT_PGI")]
    Texcoord1BitPGI = unchecked((uint)0x10000000),

    [NativeName("GL_TEXCOORD2_BIT_PGI")]
    Texcoord2BitPGI = unchecked((uint)0x20000000),

    [NativeName("GL_TEXCOORD3_BIT_PGI")]
    Texcoord3BitPGI = unchecked((uint)0x40000000),

    [NativeName("GL_TEXCOORD4_BIT_PGI")]
    Texcoord4BitPGI = unchecked((uint)0x80000000),

    [NativeName("GL_VERTEX23_BIT_PGI")]
    Vertex23BitPGI = unchecked((uint)0x00000004),

    [NativeName("GL_VERTEX4_BIT_PGI")]
    Vertex4BitPGI = unchecked((uint)0x00000008),

    [NativeName("GL_SCREEN_COORDINATES_REND")]
    ScreenCoordinatesREND = unchecked((uint)0x8490),

    [NativeName("GL_INVERTED_SCREEN_W_REND")]
    InvertedScreenWREND = unchecked((uint)0x8491),

    [NativeName("GL_RGB_S3TC")]
    RgbS3Tc = unchecked((uint)0x83A0),

    [NativeName("GL_RGB4_S3TC")]
    Rgb4S3Tc = unchecked((uint)0x83A1),

    [NativeName("GL_RGBA_S3TC")]
    RgbaS3Tc = unchecked((uint)0x83A2),

    [NativeName("GL_RGBA4_S3TC")]
    Rgba4S3Tc = unchecked((uint)0x83A3),

    [NativeName("GL_RGBA_DXT5_S3TC")]
    RgbaDxt5S3Tc = unchecked((uint)0x83A4),

    [NativeName("GL_RGBA4_DXT5_S3TC")]
    Rgba4Dxt5S3Tc = unchecked((uint)0x83A5),

    [NativeName("GL_DETAIL_TEXTURE_2D_SGIS")]
    DetailTexture2DSGIS = unchecked((uint)0x8095),

    [NativeName("GL_DETAIL_TEXTURE_2D_BINDING_SGIS")]
    DetailTexture2DBindingSGIS = unchecked((uint)0x8096),

    [NativeName("GL_LINEAR_DETAIL_SGIS")]
    LinearDetailSGIS = unchecked((uint)0x8097),

    [NativeName("GL_LINEAR_DETAIL_ALPHA_SGIS")]
    LinearDetailAlphaSGIS = unchecked((uint)0x8098),

    [NativeName("GL_LINEAR_DETAIL_COLOR_SGIS")]
    LinearDetailColorSGIS = unchecked((uint)0x8099),

    [NativeName("GL_DETAIL_TEXTURE_LEVEL_SGIS")]
    DetailTextureLevelSGIS = unchecked((uint)0x809A),

    [NativeName("GL_DETAIL_TEXTURE_MODE_SGIS")]
    DetailTextureModeSGIS = unchecked((uint)0x809B),

    [NativeName("GL_DETAIL_TEXTURE_FUNC_POINTS_SGIS")]
    DetailTextureFuncPointsSGIS = unchecked((uint)0x809C),

    [NativeName("GL_FOG_FUNC_SGIS")]
    FogFuncSGIS = unchecked((uint)0x812A),

    [NativeName("GL_FOG_FUNC_POINTS_SGIS")]
    FogFuncPointsSGIS = unchecked((uint)0x812B),

    [NativeName("GL_MAX_FOG_FUNC_POINTS_SGIS")]
    MaxFogFuncPointsSGIS = unchecked((uint)0x812C),

    [NativeName("GL_GENERATE_MIPMAP_SGIS")]
    GenerateMipmapSGIS = unchecked((uint)0x8191),

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

    [NativeName("GL_1PASS_SGIS")]
    X1PassSGIS = unchecked((uint)0x80A1),

    [NativeName("GL_2PASS_0_SGIS")]
    X2Pass0SGIS = unchecked((uint)0x80A2),

    [NativeName("GL_2PASS_1_SGIS")]
    X2Pass1SGIS = unchecked((uint)0x80A3),

    [NativeName("GL_4PASS_0_SGIS")]
    X4Pass0SGIS = unchecked((uint)0x80A4),

    [NativeName("GL_4PASS_1_SGIS")]
    X4Pass1SGIS = unchecked((uint)0x80A5),

    [NativeName("GL_4PASS_2_SGIS")]
    X4Pass2SGIS = unchecked((uint)0x80A6),

    [NativeName("GL_4PASS_3_SGIS")]
    X4Pass3SGIS = unchecked((uint)0x80A7),

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

    [NativeName("GL_PIXEL_FRAGMENT_RGB_SOURCE_SGIS")]
    PixelFragmentRgbSourceSGIS = unchecked((uint)0x8354),

    [NativeName("GL_PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS")]
    PixelFragmentAlphaSourceSGIS = unchecked((uint)0x8355),

    [NativeName("GL_PIXEL_GROUP_COLOR_SGIS")]
    PixelGroupColorSGIS = unchecked((uint)0x8356),

    [NativeName("GL_EYE_DISTANCE_TO_POINT_SGIS")]
    EyeDistanceToPointSGIS = unchecked((uint)0x81F0),

    [NativeName("GL_OBJECT_DISTANCE_TO_POINT_SGIS")]
    ObjectDistanceToPointSGIS = unchecked((uint)0x81F1),

    [NativeName("GL_EYE_DISTANCE_TO_LINE_SGIS")]
    EyeDistanceToLineSGIS = unchecked((uint)0x81F2),

    [NativeName("GL_OBJECT_DISTANCE_TO_LINE_SGIS")]
    ObjectDistanceToLineSGIS = unchecked((uint)0x81F3),

    [NativeName("GL_EYE_POINT_SGIS")]
    EyePointSGIS = unchecked((uint)0x81F4),

    [NativeName("GL_OBJECT_POINT_SGIS")]
    ObjectPointSGIS = unchecked((uint)0x81F5),

    [NativeName("GL_EYE_LINE_SGIS")]
    EyeLineSGIS = unchecked((uint)0x81F6),

    [NativeName("GL_OBJECT_LINE_SGIS")]
    ObjectLineSGIS = unchecked((uint)0x81F7),

    [NativeName("GL_POINT_SIZE_MIN_SGIS")]
    PointSizeMinSGIS = unchecked((uint)0x8126),

    [NativeName("GL_POINT_SIZE_MAX_SGIS")]
    PointSizeMaxSGIS = unchecked((uint)0x8127),

    [NativeName("GL_POINT_FADE_THRESHOLD_SIZE_SGIS")]
    PointFadeThresholdSizeSGIS = unchecked((uint)0x8128),

    [NativeName("GL_DISTANCE_ATTENUATION_SGIS")]
    DistanceAttenuationSGIS = unchecked((uint)0x8129),

    [NativeName("GL_LINEAR_SHARPEN_SGIS")]
    LinearSharpenSGIS = unchecked((uint)0x80AD),

    [NativeName("GL_LINEAR_SHARPEN_ALPHA_SGIS")]
    LinearSharpenAlphaSGIS = unchecked((uint)0x80AE),

    [NativeName("GL_LINEAR_SHARPEN_COLOR_SGIS")]
    LinearSharpenColorSGIS = unchecked((uint)0x80AF),

    [NativeName("GL_SHARPEN_TEXTURE_FUNC_POINTS_SGIS")]
    SharpenTextureFuncPointsSGIS = unchecked((uint)0x80B0),

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

    [NativeName("GL_PROXY_TEXTURE_4D_SGIS")]
    ProxyTexture4DSGIS = unchecked((uint)0x8135),

    [NativeName("GL_TEXTURE_4DSIZE_SGIS")]
    Texture4DsizeSGIS = unchecked((uint)0x8136),

    [NativeName("GL_TEXTURE_WRAP_Q_SGIS")]
    TextureWrapQSGIS = unchecked((uint)0x8137),

    [NativeName("GL_MAX_4D_TEXTURE_SIZE_SGIS")]
    Max4DTextureSizeSGIS = unchecked((uint)0x8138),

    [NativeName("GL_TEXTURE_4D_BINDING_SGIS")]
    Texture4DBindingSGIS = unchecked((uint)0x814F),

    [NativeName("GL_CLAMP_TO_BORDER_SGIS")]
    ClampToBorderSGIS = unchecked((uint)0x812D),

    [NativeName("GL_TEXTURE_COLOR_WRITEMASK_SGIS")]
    TextureColorWritemaskSGIS = unchecked((uint)0x81EF),

    [NativeName("GL_CLAMP_TO_EDGE_SGIS")]
    ClampToEdgeSGIS = unchecked((uint)0x812F),

    [NativeName("GL_FILTER4_SGIS")]
    Filter4SGIS = unchecked((uint)0x8146),

    [NativeName("GL_TEXTURE_FILTER4_SIZE_SGIS")]
    TextureFilter4SizeSGIS = unchecked((uint)0x8147),

    [NativeName("GL_TEXTURE_MIN_LOD_SGIS")]
    TextureMinLodSGIS = unchecked((uint)0x813A),

    [NativeName("GL_TEXTURE_MAX_LOD_SGIS")]
    TextureMaxLodSGIS = unchecked((uint)0x813B),

    [NativeName("GL_TEXTURE_BASE_LEVEL_SGIS")]
    TextureBaseLevelSGIS = unchecked((uint)0x813C),

    [NativeName("GL_TEXTURE_MAX_LEVEL_SGIS")]
    TextureMaxLevelSGIS = unchecked((uint)0x813D),

    [NativeName("GL_DUAL_ALPHA4_SGIS")]
    DualAlpha4SGIS = unchecked((uint)0x8110),

    [NativeName("GL_DUAL_ALPHA8_SGIS")]
    DualAlpha8SGIS = unchecked((uint)0x8111),

    [NativeName("GL_DUAL_ALPHA12_SGIS")]
    DualAlpha12SGIS = unchecked((uint)0x8112),

    [NativeName("GL_DUAL_ALPHA16_SGIS")]
    DualAlpha16SGIS = unchecked((uint)0x8113),

    [NativeName("GL_DUAL_LUMINANCE4_SGIS")]
    DualLuminance4SGIS = unchecked((uint)0x8114),

    [NativeName("GL_DUAL_LUMINANCE8_SGIS")]
    DualLuminance8SGIS = unchecked((uint)0x8115),

    [NativeName("GL_DUAL_LUMINANCE12_SGIS")]
    DualLuminance12SGIS = unchecked((uint)0x8116),

    [NativeName("GL_DUAL_LUMINANCE16_SGIS")]
    DualLuminance16SGIS = unchecked((uint)0x8117),

    [NativeName("GL_DUAL_INTENSITY4_SGIS")]
    DualIntensity4SGIS = unchecked((uint)0x8118),

    [NativeName("GL_DUAL_INTENSITY8_SGIS")]
    DualIntensity8SGIS = unchecked((uint)0x8119),

    [NativeName("GL_DUAL_INTENSITY12_SGIS")]
    DualIntensity12SGIS = unchecked((uint)0x811A),

    [NativeName("GL_DUAL_INTENSITY16_SGIS")]
    DualIntensity16SGIS = unchecked((uint)0x811B),

    [NativeName("GL_DUAL_LUMINANCE_ALPHA4_SGIS")]
    DualLuminanceAlpha4SGIS = unchecked((uint)0x811C),

    [NativeName("GL_DUAL_LUMINANCE_ALPHA8_SGIS")]
    DualLuminanceAlpha8SGIS = unchecked((uint)0x811D),

    [NativeName("GL_QUAD_ALPHA4_SGIS")]
    QuadAlpha4SGIS = unchecked((uint)0x811E),

    [NativeName("GL_QUAD_ALPHA8_SGIS")]
    QuadAlpha8SGIS = unchecked((uint)0x811F),

    [NativeName("GL_QUAD_LUMINANCE4_SGIS")]
    QuadLuminance4SGIS = unchecked((uint)0x8120),

    [NativeName("GL_QUAD_LUMINANCE8_SGIS")]
    QuadLuminance8SGIS = unchecked((uint)0x8121),

    [NativeName("GL_QUAD_INTENSITY4_SGIS")]
    QuadIntensity4SGIS = unchecked((uint)0x8122),

    [NativeName("GL_QUAD_INTENSITY8_SGIS")]
    QuadIntensity8SGIS = unchecked((uint)0x8123),

    [NativeName("GL_DUAL_TEXTURE_SELECT_SGIS")]
    DualTextureSelectSGIS = unchecked((uint)0x8124),

    [NativeName("GL_QUAD_TEXTURE_SELECT_SGIS")]
    QuadTextureSelectSGIS = unchecked((uint)0x8125),

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

    [NativeName("GL_ALPHA_MIN_SGIX")]
    AlphaMinSGIX = unchecked((uint)0x8320),

    [NativeName("GL_ALPHA_MAX_SGIX")]
    AlphaMaxSGIX = unchecked((uint)0x8321),

    [NativeName("GL_CALLIGRAPHIC_FRAGMENT_SGIX")]
    CalligraphicFragmentSGIX = unchecked((uint)0x8183),

    [NativeName("GL_LINEAR_CLIPMAP_LINEAR_SGIX")]
    LinearClipmapLinearSGIX = unchecked((uint)0x8170),

    [NativeName("GL_TEXTURE_CLIPMAP_CENTER_SGIX")]
    TextureClipmapCenterSGIX = unchecked((uint)0x8171),

    [NativeName("GL_TEXTURE_CLIPMAP_FRAME_SGIX")]
    TextureClipmapFrameSGIX = unchecked((uint)0x8172),

    [NativeName("GL_TEXTURE_CLIPMAP_OFFSET_SGIX")]
    TextureClipmapOffsetSGIX = unchecked((uint)0x8173),

    [NativeName("GL_TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX")]
    TextureClipmapVirtualDepthSGIX = unchecked((uint)0x8174),

    [NativeName("GL_TEXTURE_CLIPMAP_LOD_OFFSET_SGIX")]
    TextureClipmapLodOffsetSGIX = unchecked((uint)0x8175),

    [NativeName("GL_TEXTURE_CLIPMAP_DEPTH_SGIX")]
    TextureClipmapDepthSGIX = unchecked((uint)0x8176),

    [NativeName("GL_MAX_CLIPMAP_DEPTH_SGIX")]
    MaxClipmapDepthSGIX = unchecked((uint)0x8177),

    [NativeName("GL_MAX_CLIPMAP_VIRTUAL_DEPTH_SGIX")]
    MaxClipmapVirtualDepthSGIX = unchecked((uint)0x8178),

    [NativeName("GL_NEAREST_CLIPMAP_NEAREST_SGIX")]
    NearestClipmapNearestSGIX = unchecked((uint)0x844D),

    [NativeName("GL_NEAREST_CLIPMAP_LINEAR_SGIX")]
    NearestClipmapLinearSGIX = unchecked((uint)0x844E),

    [NativeName("GL_LINEAR_CLIPMAP_NEAREST_SGIX")]
    LinearClipmapNearestSGIX = unchecked((uint)0x844F),

    [NativeName("GL_CONVOLUTION_HINT_SGIX")]
    ConvolutionHintSGIX = unchecked((uint)0x8316),

    [NativeName("GL_DEPTH_COMPONENT16_SGIX")]
    DepthComponent16SGIX = unchecked((uint)0x81A5),

    [NativeName("GL_DEPTH_COMPONENT24_SGIX")]
    DepthComponent24SGIX = unchecked((uint)0x81A6),

    [NativeName("GL_DEPTH_COMPONENT32_SGIX")]
    DepthComponent32SGIX = unchecked((uint)0x81A7),

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

    [NativeName("GL_CURRENT_RASTER_NORMAL_SGIX")]
    CurrentRasterNormalSGIX = unchecked((uint)0x8406),

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

    [NativeName("GL_FRAGMENT_LIGHT1_SGIX")]
    FragmentLight1SGIX = unchecked((uint)0x840D),

    [NativeName("GL_FRAGMENT_LIGHT2_SGIX")]
    FragmentLight2SGIX = unchecked((uint)0x840E),

    [NativeName("GL_FRAGMENT_LIGHT3_SGIX")]
    FragmentLight3SGIX = unchecked((uint)0x840F),

    [NativeName("GL_FRAGMENT_LIGHT4_SGIX")]
    FragmentLight4SGIX = unchecked((uint)0x8410),

    [NativeName("GL_FRAGMENT_LIGHT5_SGIX")]
    FragmentLight5SGIX = unchecked((uint)0x8411),

    [NativeName("GL_FRAGMENT_LIGHT6_SGIX")]
    FragmentLight6SGIX = unchecked((uint)0x8412),

    [NativeName("GL_FRAGMENT_LIGHT7_SGIX")]
    FragmentLight7SGIX = unchecked((uint)0x8413),

    [NativeName("GL_FRAMEZOOM_SGIX")]
    FramezoomSGIX = unchecked((uint)0x818B),

    [NativeName("GL_FRAMEZOOM_FACTOR_SGIX")]
    FramezoomFactorSGIX = unchecked((uint)0x818C),

    [NativeName("GL_MAX_FRAMEZOOM_FACTOR_SGIX")]
    MaxFramezoomFactorSGIX = unchecked((uint)0x818D),

    [NativeName("GL_INSTRUMENT_BUFFER_POINTER_SGIX")]
    InstrumentBufferPointerSGIX = unchecked((uint)0x8180),

    [NativeName("GL_INSTRUMENT_MEASUREMENTS_SGIX")]
    InstrumentMeasurementsSGIX = unchecked((uint)0x8181),

    [NativeName("GL_INTERLACE_SGIX")]
    InterlaceSGIX = unchecked((uint)0x8094),

    [NativeName("GL_IR_INSTRUMENT1_SGIX")]
    IrInstrument1SGIX = unchecked((uint)0x817F),

    [NativeName("GL_LIST_PRIORITY_SGIX")]
    ListPrioritySGIX = unchecked((uint)0x8182),

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

    [NativeName("GL_TEXTURE_DEFORMATION_BIT_SGIX")]
    TextureDeformationBitSGIX = unchecked((uint)0x00000001),

    [NativeName("GL_GEOMETRY_DEFORMATION_BIT_SGIX")]
    GeometryDeformationBitSGIX = unchecked((uint)0x00000002),

    [NativeName("GL_GEOMETRY_DEFORMATION_SGIX")]
    GeometryDeformationSGIX = unchecked((uint)0x8194),

    [NativeName("GL_TEXTURE_DEFORMATION_SGIX")]
    TextureDeformationSGIX = unchecked((uint)0x8195),

    [NativeName("GL_DEFORMATIONS_MASK_SGIX")]
    DeformationsMaskSGIX = unchecked((uint)0x8196),

    [NativeName("GL_MAX_DEFORMATION_ORDER_SGIX")]
    MaxDeformationOrderSGIX = unchecked((uint)0x8197),

    [NativeName("GL_REFERENCE_PLANE_SGIX")]
    ReferencePlaneSGIX = unchecked((uint)0x817D),

    [NativeName("GL_REFERENCE_PLANE_EQUATION_SGIX")]
    ReferencePlaneEquationSGIX = unchecked((uint)0x817E),

    [NativeName("GL_PACK_RESAMPLE_SGIX")]
    PackResampleSGIX = unchecked((uint)0x842E),

    [NativeName("GL_UNPACK_RESAMPLE_SGIX")]
    UnpackResampleSGIX = unchecked((uint)0x842F),

    [NativeName("GL_RESAMPLE_REPLICATE_SGIX")]
    ResampleReplicateSGIX = unchecked((uint)0x8433),

    [NativeName("GL_RESAMPLE_ZERO_FILL_SGIX")]
    ResampleZeroFillSGIX = unchecked((uint)0x8434),

    [NativeName("GL_RESAMPLE_DECIMATE_SGIX")]
    ResampleDecimateSGIX = unchecked((uint)0x8430),

    [NativeName("GL_SCALEBIAS_HINT_SGIX")]
    ScalebiasHintSGIX = unchecked((uint)0x8322),

    [NativeName("GL_TEXTURE_COMPARE_SGIX")]
    TextureCompareSGIX = unchecked((uint)0x819A),

    [NativeName("GL_TEXTURE_COMPARE_OPERATOR_SGIX")]
    TextureCompareOperatorSGIX = unchecked((uint)0x819B),

    [NativeName("GL_TEXTURE_LEQUAL_R_SGIX")]
    TextureLequalRSGIX = unchecked((uint)0x819C),

    [NativeName("GL_TEXTURE_GEQUAL_R_SGIX")]
    TextureGequalRSGIX = unchecked((uint)0x819D),

    [NativeName("GL_SHADOW_AMBIENT_SGIX")]
    ShadowAmbientSGIX = unchecked((uint)0x80BF),

    [NativeName("GL_SPRITE_SGIX")]
    SpriteSGIX = unchecked((uint)0x8148),

    [NativeName("GL_SPRITE_MODE_SGIX")]
    SpriteModeSGIX = unchecked((uint)0x8149),

    [NativeName("GL_SPRITE_AXIS_SGIX")]
    SpriteAxisSGIX = unchecked((uint)0x814A),

    [NativeName("GL_SPRITE_TRANSLATION_SGIX")]
    SpriteTranslationSGIX = unchecked((uint)0x814B),

    [NativeName("GL_SPRITE_AXIAL_SGIX")]
    SpriteAxialSGIX = unchecked((uint)0x814C),

    [NativeName("GL_SPRITE_OBJECT_ALIGNED_SGIX")]
    SpriteObjectAlignedSGIX = unchecked((uint)0x814D),

    [NativeName("GL_SPRITE_EYE_ALIGNED_SGIX")]
    SpriteEyeAlignedSGIX = unchecked((uint)0x814E),

    [NativeName("GL_PACK_SUBSAMPLE_RATE_SGIX")]
    PackSubsampleRateSGIX = unchecked((uint)0x85A0),

    [NativeName("GL_UNPACK_SUBSAMPLE_RATE_SGIX")]
    UnpackSubsampleRateSGIX = unchecked((uint)0x85A1),

    [NativeName("GL_PIXEL_SUBSAMPLE_4444_SGIX")]
    PixelSubsample4444SGIX = unchecked((uint)0x85A2),

    [NativeName("GL_PIXEL_SUBSAMPLE_2424_SGIX")]
    PixelSubsample2424SGIX = unchecked((uint)0x85A3),

    [NativeName("GL_PIXEL_SUBSAMPLE_4242_SGIX")]
    PixelSubsample4242SGIX = unchecked((uint)0x85A4),

    [NativeName("GL_TEXTURE_ENV_BIAS_SGIX")]
    TextureEnvBiasSGIX = unchecked((uint)0x80BE),

    [NativeName("GL_TEXTURE_MAX_CLAMP_S_SGIX")]
    TextureMaxClampSSGIX = unchecked((uint)0x8369),

    [NativeName("GL_TEXTURE_MAX_CLAMP_T_SGIX")]
    TextureMaxClampTSGIX = unchecked((uint)0x836A),

    [NativeName("GL_TEXTURE_MAX_CLAMP_R_SGIX")]
    TextureMaxClampRSGIX = unchecked((uint)0x836B),

    [NativeName("GL_TEXTURE_LOD_BIAS_S_SGIX")]
    TextureLodBiasSSGIX = unchecked((uint)0x818E),

    [NativeName("GL_TEXTURE_LOD_BIAS_T_SGIX")]
    TextureLodBiasTSGIX = unchecked((uint)0x818F),

    [NativeName("GL_TEXTURE_LOD_BIAS_R_SGIX")]
    TextureLodBiasRSGIX = unchecked((uint)0x8190),

    [NativeName("GL_TEXTURE_MULTI_BUFFER_HINT_SGIX")]
    TextureMultiBufferHintSGIX = unchecked((uint)0x812E),

    [NativeName("GL_POST_TEXTURE_FILTER_BIAS_SGIX")]
    PostTextureFilterBiasSGIX = unchecked((uint)0x8179),

    [NativeName("GL_POST_TEXTURE_FILTER_SCALE_SGIX")]
    PostTextureFilterScaleSGIX = unchecked((uint)0x817A),

    [NativeName("GL_POST_TEXTURE_FILTER_BIAS_RANGE_SGIX")]
    PostTextureFilterBiasRangeSGIX = unchecked((uint)0x817B),

    [NativeName("GL_POST_TEXTURE_FILTER_SCALE_RANGE_SGIX")]
    PostTextureFilterScaleRangeSGIX = unchecked((uint)0x817C),

    [NativeName("GL_VERTEX_PRECLIP_SGIX")]
    VertexPreclipSGIX = unchecked((uint)0x83EE),

    [NativeName("GL_VERTEX_PRECLIP_HINT_SGIX")]
    VertexPreclipHintSGIX = unchecked((uint)0x83EF),

    [NativeName("GL_YCRCB_422_SGIX")]
    Ycrcb422SGIX = unchecked((uint)0x81BB),

    [NativeName("GL_YCRCB_444_SGIX")]
    Ycrcb444SGIX = unchecked((uint)0x81BC),

    [NativeName("GL_YCRCB_SGIX")]
    YcrcbSGIX = unchecked((uint)0x8318),

    [NativeName("GL_YCRCBA_SGIX")]
    YcrcbaSGIX = unchecked((uint)0x8319),

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

    [NativeName("GL_PROXY_COLOR_TABLE_SGI")]
    ProxyColorTableSGI = unchecked((uint)0x80D3),

    [NativeName("GL_PROXY_POST_CONVOLUTION_COLOR_TABLE_SGI")]
    ProxyPostConvolutionColorTableSGI = unchecked((uint)0x80D4),

    [NativeName("GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE_SGI")]
    ProxyPostColorMatrixColorTableSGI = unchecked((uint)0x80D5),

    [NativeName("GL_COLOR_TABLE_SCALE_SGI")]
    ColorTableScaleSGI = unchecked((uint)0x80D6),

    [NativeName("GL_COLOR_TABLE_BIAS_SGI")]
    ColorTableBiasSGI = unchecked((uint)0x80D7),

    [NativeName("GL_COLOR_TABLE_FORMAT_SGI")]
    ColorTableFormatSGI = unchecked((uint)0x80D8),

    [NativeName("GL_COLOR_TABLE_WIDTH_SGI")]
    ColorTableWidthSGI = unchecked((uint)0x80D9),

    [NativeName("GL_COLOR_TABLE_RED_SIZE_SGI")]
    ColorTableRedSizeSGI = unchecked((uint)0x80DA),

    [NativeName("GL_COLOR_TABLE_GREEN_SIZE_SGI")]
    ColorTableGreenSizeSGI = unchecked((uint)0x80DB),

    [NativeName("GL_COLOR_TABLE_BLUE_SIZE_SGI")]
    ColorTableBlueSizeSGI = unchecked((uint)0x80DC),

    [NativeName("GL_COLOR_TABLE_ALPHA_SIZE_SGI")]
    ColorTableAlphaSizeSGI = unchecked((uint)0x80DD),

    [NativeName("GL_COLOR_TABLE_LUMINANCE_SIZE_SGI")]
    ColorTableLuminanceSizeSGI = unchecked((uint)0x80DE),

    [NativeName("GL_COLOR_TABLE_INTENSITY_SIZE_SGI")]
    ColorTableIntensitySizeSGI = unchecked((uint)0x80DF),

    [NativeName("GL_TEXTURE_COLOR_TABLE_SGI")]
    TextureColorTableSGI = unchecked((uint)0x80BC),

    [NativeName("GL_PROXY_TEXTURE_COLOR_TABLE_SGI")]
    ProxyTextureColorTableSGI = unchecked((uint)0x80BD),

    [NativeName("GL_UNPACK_CONSTANT_DATA_SUNX")]
    UnpackConstantDataSUNX = unchecked((uint)0x81D5),

    [NativeName("GL_TEXTURE_CONSTANT_DATA_SUNX")]
    TextureConstantDataSUNX = unchecked((uint)0x81D6),

    [NativeName("GL_WRAP_BORDER_SUN")]
    WrapBorderSUN = unchecked((uint)0x81D4),

    [NativeName("GL_GLOBAL_ALPHA_SUN")]
    GlobalAlphaSUN = unchecked((uint)0x81D9),

    [NativeName("GL_GLOBAL_ALPHA_FACTOR_SUN")]
    GlobalAlphaFactorSUN = unchecked((uint)0x81DA),

    [NativeName("GL_QUAD_MESH_SUN")]
    QuadMeshSUN = unchecked((uint)0x8614),

    [NativeName("GL_TRIANGLE_MESH_SUN")]
    TriangleMeshSUN = unchecked((uint)0x8615),

    [NativeName("GL_SLICE_ACCUM_SUN")]
    SliceAccumSUN = unchecked((uint)0x85CC),

    [NativeName("GL_RESTART_SUN")]
    RestartSUN = unchecked((uint)0x0001),

    [NativeName("GL_REPLACE_MIDDLE_SUN")]
    ReplaceMiddleSUN = unchecked((uint)0x0002),

    [NativeName("GL_REPLACE_OLDEST_SUN")]
    ReplaceOldestSUN = unchecked((uint)0x0003),

    [NativeName("GL_TRIANGLE_LIST_SUN")]
    TriangleListSUN = unchecked((uint)0x81D7),

    [NativeName("GL_REPLACEMENT_CODE_SUN")]
    ReplacementCodeSUN = unchecked((uint)0x81D8),

    [NativeName("GL_REPLACEMENT_CODE_ARRAY_SUN")]
    ReplacementCodeArraySUN = unchecked((uint)0x85C0),

    [NativeName("GL_REPLACEMENT_CODE_ARRAY_TYPE_SUN")]
    ReplacementCodeArrayTypeSUN = unchecked((uint)0x85C1),

    [NativeName("GL_REPLACEMENT_CODE_ARRAY_STRIDE_SUN")]
    ReplacementCodeArrayStrideSUN = unchecked((uint)0x85C2),

    [NativeName("GL_REPLACEMENT_CODE_ARRAY_POINTER_SUN")]
    ReplacementCodeArrayPointerSUN = unchecked((uint)0x85C3),

    [NativeName("GL_R1UI_V3F_SUN")]
    R1UiV3FSUN = unchecked((uint)0x85C4),

    [NativeName("GL_R1UI_C4UB_V3F_SUN")]
    R1UiC4UbV3FSUN = unchecked((uint)0x85C5),

    [NativeName("GL_R1UI_C3F_V3F_SUN")]
    R1UiC3FV3FSUN = unchecked((uint)0x85C6),

    [NativeName("GL_R1UI_N3F_V3F_SUN")]
    R1UiN3FV3FSUN = unchecked((uint)0x85C7),

    [NativeName("GL_R1UI_C4F_N3F_V3F_SUN")]
    R1UiC4FN3FV3FSUN = unchecked((uint)0x85C8),

    [NativeName("GL_R1UI_T2F_V3F_SUN")]
    R1UiT2FV3FSUN = unchecked((uint)0x85C9),

    [NativeName("GL_R1UI_T2F_N3F_V3F_SUN")]
    R1UiT2FN3FV3FSUN = unchecked((uint)0x85CA),

    [NativeName("GL_R1UI_T2F_C4F_N3F_V3F_SUN")]
    R1UiT2FC4FN3FV3FSUN = unchecked((uint)0x85CB),

    [NativeName("GL_PHONG_WIN")]
    PhongWIN = unchecked((uint)0x80EA),

    [NativeName("GL_PHONG_HINT_WIN")]
    PhongHintWIN = unchecked((uint)0x80EB),

    [NativeName("GL_FOG_SPECULAR_TEXTURE_WIN")]
    FogSpecularTextureWIN = unchecked((uint)0x80EC),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS")]
    FramebufferIncompleteDimensions = unchecked((uint)0x8CD9),

    [NativeName("GL_CONTEXT_RELEASE_BEHAVIOR_KHR")]
    ContextReleaseBehaviorKHR = unchecked((uint)0x82FB),

    [NativeName("GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH_KHR")]
    ContextReleaseBehaviorFlushKHR = unchecked((uint)0x82FC),

    [NativeName("GL_DEBUG_OUTPUT_SYNCHRONOUS_KHR")]
    DebugOutputSynchronousKHR = unchecked((uint)0x8242),

    [NativeName("GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_KHR")]
    DebugNextLoggedMessageLengthKHR = unchecked((uint)0x8243),

    [NativeName("GL_DEBUG_CALLBACK_FUNCTION_KHR")]
    DebugCallbackFunctionKHR = unchecked((uint)0x8244),

    [NativeName("GL_DEBUG_CALLBACK_USER_PARAM_KHR")]
    DebugCallbackUserParamKHR = unchecked((uint)0x8245),

    [NativeName("GL_DEBUG_SOURCE_API_KHR")]
    DebugSourceApiKHR = unchecked((uint)0x8246),

    [NativeName("GL_DEBUG_SOURCE_WINDOW_SYSTEM_KHR")]
    DebugSourceWindowSystemKHR = unchecked((uint)0x8247),

    [NativeName("GL_DEBUG_SOURCE_SHADER_COMPILER_KHR")]
    DebugSourceShaderCompilerKHR = unchecked((uint)0x8248),

    [NativeName("GL_DEBUG_SOURCE_THIRD_PARTY_KHR")]
    DebugSourceThirdPartyKHR = unchecked((uint)0x8249),

    [NativeName("GL_DEBUG_SOURCE_APPLICATION_KHR")]
    DebugSourceApplicationKHR = unchecked((uint)0x824A),

    [NativeName("GL_DEBUG_SOURCE_OTHER_KHR")]
    DebugSourceOtherKHR = unchecked((uint)0x824B),

    [NativeName("GL_DEBUG_TYPE_ERROR_KHR")]
    DebugTypeErrorKHR = unchecked((uint)0x824C),

    [NativeName("GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_KHR")]
    DebugTypeDeprecatedBehaviorKHR = unchecked((uint)0x824D),

    [NativeName("GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_KHR")]
    DebugTypeUndefinedBehaviorKHR = unchecked((uint)0x824E),

    [NativeName("GL_DEBUG_TYPE_PORTABILITY_KHR")]
    DebugTypePortabilityKHR = unchecked((uint)0x824F),

    [NativeName("GL_DEBUG_TYPE_PERFORMANCE_KHR")]
    DebugTypePerformanceKHR = unchecked((uint)0x8250),

    [NativeName("GL_DEBUG_TYPE_OTHER_KHR")]
    DebugTypeOtherKHR = unchecked((uint)0x8251),

    [NativeName("GL_DEBUG_TYPE_MARKER_KHR")]
    DebugTypeMarkerKHR = unchecked((uint)0x8268),

    [NativeName("GL_DEBUG_TYPE_PUSH_GROUP_KHR")]
    DebugTypePushGroupKHR = unchecked((uint)0x8269),

    [NativeName("GL_DEBUG_TYPE_POP_GROUP_KHR")]
    DebugTypePopGroupKHR = unchecked((uint)0x826A),

    [NativeName("GL_DEBUG_SEVERITY_NOTIFICATION_KHR")]
    DebugSeverityNotificationKHR = unchecked((uint)0x826B),

    [NativeName("GL_MAX_DEBUG_GROUP_STACK_DEPTH_KHR")]
    MaxDebugGroupStackDepthKHR = unchecked((uint)0x826C),

    [NativeName("GL_DEBUG_GROUP_STACK_DEPTH_KHR")]
    DebugGroupStackDepthKHR = unchecked((uint)0x826D),

    [NativeName("GL_BUFFER_KHR")]
    BufferKHR = unchecked((uint)0x82E0),

    [NativeName("GL_SHADER_KHR")]
    ShaderKHR = unchecked((uint)0x82E1),

    [NativeName("GL_PROGRAM_KHR")]
    ProgramKHR = unchecked((uint)0x82E2),

    [NativeName("GL_VERTEX_ARRAY_KHR")]
    VertexArrayKHR = unchecked((uint)0x8074),

    [NativeName("GL_QUERY_KHR")]
    QueryKHR = unchecked((uint)0x82E3),

    [NativeName("GL_PROGRAM_PIPELINE_KHR")]
    ProgramPipelineKHR = unchecked((uint)0x82E4),

    [NativeName("GL_SAMPLER_KHR")]
    SamplerKHR = unchecked((uint)0x82E6),

    [NativeName("GL_MAX_LABEL_LENGTH_KHR")]
    MaxLabelLengthKHR = unchecked((uint)0x82E8),

    [NativeName("GL_MAX_DEBUG_MESSAGE_LENGTH_KHR")]
    MaxDebugMessageLengthKHR = unchecked((uint)0x9143),

    [NativeName("GL_MAX_DEBUG_LOGGED_MESSAGES_KHR")]
    MaxDebugLoggedMessagesKHR = unchecked((uint)0x9144),

    [NativeName("GL_DEBUG_LOGGED_MESSAGES_KHR")]
    DebugLoggedMessagesKHR = unchecked((uint)0x9145),

    [NativeName("GL_DEBUG_SEVERITY_HIGH_KHR")]
    DebugSeverityHighKHR = unchecked((uint)0x9146),

    [NativeName("GL_DEBUG_SEVERITY_MEDIUM_KHR")]
    DebugSeverityMediumKHR = unchecked((uint)0x9147),

    [NativeName("GL_DEBUG_SEVERITY_LOW_KHR")]
    DebugSeverityLowKHR = unchecked((uint)0x9148),

    [NativeName("GL_DEBUG_OUTPUT_KHR")]
    DebugOutputKHR = unchecked((uint)0x92E0),

    [NativeName("GL_CONTEXT_FLAG_DEBUG_BIT_KHR")]
    ContextFlagDebugBitKHR = unchecked((uint)0x00000002),

    [NativeName("GL_STACK_OVERFLOW_KHR")]
    StackOverflowKHR = unchecked((uint)0x0503),

    [NativeName("GL_STACK_UNDERFLOW_KHR")]
    StackUnderflowKHR = unchecked((uint)0x0504),

    [NativeName("GL_CONTEXT_ROBUST_ACCESS_KHR")]
    ContextRobustAccessKHR = unchecked((uint)0x90F3),

    [NativeName("GL_LOSE_CONTEXT_ON_RESET_KHR")]
    LoseContextOnResetKHR = unchecked((uint)0x8252),

    [NativeName("GL_GUILTY_CONTEXT_RESET_KHR")]
    GuiltyContextResetKHR = unchecked((uint)0x8253),

    [NativeName("GL_INNOCENT_CONTEXT_RESET_KHR")]
    InnocentContextResetKHR = unchecked((uint)0x8254),

    [NativeName("GL_UNKNOWN_CONTEXT_RESET_KHR")]
    UnknownContextResetKHR = unchecked((uint)0x8255),

    [NativeName("GL_RESET_NOTIFICATION_STRATEGY_KHR")]
    ResetNotificationStrategyKHR = unchecked((uint)0x8256),

    [NativeName("GL_NO_RESET_NOTIFICATION_KHR")]
    NoResetNotificationKHR = unchecked((uint)0x8261),

    [NativeName("GL_CONTEXT_LOST_KHR")]
    ContextLostKHR = unchecked((uint)0x0507),

    [NativeName("GL_SAMPLER_EXTERNAL_OES")]
    SamplerExternalOES = unchecked((uint)0x8D66),

    [NativeName("GL_GEOMETRY_SHADER_OES")]
    GeometryShaderOES = unchecked((uint)0x8DD9),

    [NativeName("GL_GEOMETRY_SHADER_BIT_OES")]
    GeometryShaderBitOES = unchecked((uint)0x00000004),

    [NativeName("GL_GEOMETRY_LINKED_VERTICES_OUT_OES")]
    GeometryLinkedVerticesOutOES = unchecked((uint)0x8916),

    [NativeName("GL_GEOMETRY_LINKED_INPUT_TYPE_OES")]
    GeometryLinkedInputTypeOES = unchecked((uint)0x8917),

    [NativeName("GL_GEOMETRY_LINKED_OUTPUT_TYPE_OES")]
    GeometryLinkedOutputTypeOES = unchecked((uint)0x8918),

    [NativeName("GL_GEOMETRY_SHADER_INVOCATIONS_OES")]
    GeometryShaderInvocationsOES = unchecked((uint)0x887F),

    [NativeName("GL_LAYER_PROVOKING_VERTEX_OES")]
    LayerProvokingVertexOES = unchecked((uint)0x825E),

    [NativeName("GL_LINES_ADJACENCY_OES")]
    LinesAdjacencyOES = unchecked((uint)0x000A),

    [NativeName("GL_LINE_STRIP_ADJACENCY_OES")]
    LineStripAdjacencyOES = unchecked((uint)0x000B),

    [NativeName("GL_TRIANGLES_ADJACENCY_OES")]
    TrianglesAdjacencyOES = unchecked((uint)0x000C),

    [NativeName("GL_TRIANGLE_STRIP_ADJACENCY_OES")]
    TriangleStripAdjacencyOES = unchecked((uint)0x000D),

    [NativeName("GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_OES")]
    MaxGeometryUniformComponentsOES = unchecked((uint)0x8DDF),

    [NativeName("GL_MAX_GEOMETRY_UNIFORM_BLOCKS_OES")]
    MaxGeometryUniformBlocksOES = unchecked((uint)0x8A2C),

    [NativeName("GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS_OES")]
    MaxCombinedGeometryUniformComponentsOES = unchecked((uint)0x8A32),

    [NativeName("GL_MAX_GEOMETRY_INPUT_COMPONENTS_OES")]
    MaxGeometryInputComponentsOES = unchecked((uint)0x9123),

    [NativeName("GL_MAX_GEOMETRY_OUTPUT_COMPONENTS_OES")]
    MaxGeometryOutputComponentsOES = unchecked((uint)0x9124),

    [NativeName("GL_MAX_GEOMETRY_OUTPUT_VERTICES_OES")]
    MaxGeometryOutputVerticesOES = unchecked((uint)0x8DE0),

    [NativeName("GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_OES")]
    MaxGeometryTotalOutputComponentsOES = unchecked((uint)0x8DE1),

    [NativeName("GL_MAX_GEOMETRY_SHADER_INVOCATIONS_OES")]
    MaxGeometryShaderInvocationsOES = unchecked((uint)0x8E5A),

    [NativeName("GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_OES")]
    MaxGeometryTextureImageUnitsOES = unchecked((uint)0x8C29),

    [NativeName("GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS_OES")]
    MaxGeometryAtomicCounterBuffersOES = unchecked((uint)0x92CF),

    [NativeName("GL_MAX_GEOMETRY_ATOMIC_COUNTERS_OES")]
    MaxGeometryAtomicCountersOES = unchecked((uint)0x92D5),

    [NativeName("GL_MAX_GEOMETRY_IMAGE_UNIFORMS_OES")]
    MaxGeometryImageUniformsOES = unchecked((uint)0x90CD),

    [NativeName("GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS_OES")]
    MaxGeometryShaderStorageBlocksOES = unchecked((uint)0x90D7),

    [NativeName("GL_FIRST_VERTEX_CONVENTION_OES")]
    FirstVertexConventionOES = unchecked((uint)0x8E4D),

    [NativeName("GL_LAST_VERTEX_CONVENTION_OES")]
    LastVertexConventionOES = unchecked((uint)0x8E4E),

    [NativeName("GL_UNDEFINED_VERTEX_OES")]
    UndefinedVertexOES = unchecked((uint)0x8260),

    [NativeName("GL_PRIMITIVES_GENERATED_OES")]
    PrimitivesGeneratedOES = unchecked((uint)0x8C87),

    [NativeName("GL_FRAMEBUFFER_DEFAULT_LAYERS_OES")]
    FramebufferDefaultLayersOES = unchecked((uint)0x9312),

    [NativeName("GL_MAX_FRAMEBUFFER_LAYERS_OES")]
    MaxFramebufferLayersOES = unchecked((uint)0x9317),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_OES")]
    FramebufferIncompleteLayerTargetsOES = unchecked((uint)0x8DA8),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_LAYERED_OES")]
    FramebufferAttachmentLayeredOES = unchecked((uint)0x8DA7),

    [NativeName("GL_REFERENCED_BY_GEOMETRY_SHADER_OES")]
    ReferencedByGeometryShaderOES = unchecked((uint)0x9309),

    [NativeName("GL_PROGRAM_BINARY_LENGTH_OES")]
    ProgramBinaryLengthOES = unchecked((uint)0x8741),

    [NativeName("GL_NUM_PROGRAM_BINARY_FORMATS_OES")]
    NumProgramBinaryFormatsOES = unchecked((uint)0x87FE),

    [NativeName("GL_PROGRAM_BINARY_FORMATS_OES")]
    ProgramBinaryFormatsOES = unchecked((uint)0x87FF),

    [NativeName("GL_PRIMITIVE_BOUNDING_BOX_OES")]
    PrimitiveBoundingBoxOES = unchecked((uint)0x92BE),

    [NativeName("GL_SAMPLE_SHADING_OES")]
    SampleShadingOES = unchecked((uint)0x8C36),

    [NativeName("GL_MIN_SAMPLE_SHADING_VALUE_OES")]
    MinSampleShadingValueOES = unchecked((uint)0x8C37),

    [NativeName("GL_MIN_FRAGMENT_INTERPOLATION_OFFSET_OES")]
    MinFragmentInterpolationOffsetOES = unchecked((uint)0x8E5B),

    [NativeName("GL_MAX_FRAGMENT_INTERPOLATION_OFFSET_OES")]
    MaxFragmentInterpolationOffsetOES = unchecked((uint)0x8E5C),

    [NativeName("GL_FRAGMENT_INTERPOLATION_OFFSET_BITS_OES")]
    FragmentInterpolationOffsetBitsOES = unchecked((uint)0x8E5D),

    [NativeName("GL_FRAGMENT_SHADER_DERIVATIVE_HINT_OES")]
    FragmentShaderDerivativeHintOES = unchecked((uint)0x8B8B),

    [NativeName("GL_PATCHES_OES")]
    PatchesOES = unchecked((uint)0x000E),

    [NativeName("GL_PATCH_VERTICES_OES")]
    PatchVerticesOES = unchecked((uint)0x8E72),

    [NativeName("GL_TESS_CONTROL_OUTPUT_VERTICES_OES")]
    TessControlOutputVerticesOES = unchecked((uint)0x8E75),

    [NativeName("GL_TESS_GEN_MODE_OES")]
    TessGenModeOES = unchecked((uint)0x8E76),

    [NativeName("GL_TESS_GEN_SPACING_OES")]
    TessGenSpacingOES = unchecked((uint)0x8E77),

    [NativeName("GL_TESS_GEN_VERTEX_ORDER_OES")]
    TessGenVertexOrderOES = unchecked((uint)0x8E78),

    [NativeName("GL_TESS_GEN_POINT_MODE_OES")]
    TessGenPointModeOES = unchecked((uint)0x8E79),

    [NativeName("GL_ISOLINES_OES")]
    IsolinesOES = unchecked((uint)0x8E7A),

    [NativeName("GL_QUADS_OES")]
    QuadsOES = unchecked((uint)0x0007),

    [NativeName("GL_FRACTIONAL_ODD_OES")]
    FractionalOddOES = unchecked((uint)0x8E7B),

    [NativeName("GL_FRACTIONAL_EVEN_OES")]
    FractionalEvenOES = unchecked((uint)0x8E7C),

    [NativeName("GL_MAX_PATCH_VERTICES_OES")]
    MaxPatchVerticesOES = unchecked((uint)0x8E7D),

    [NativeName("GL_MAX_TESS_GEN_LEVEL_OES")]
    MaxTessGenLevelOES = unchecked((uint)0x8E7E),

    [NativeName("GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS_OES")]
    MaxTessControlUniformComponentsOES = unchecked((uint)0x8E7F),

    [NativeName("GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS_OES")]
    MaxTessEvaluationUniformComponentsOES = unchecked((uint)0x8E80),

    [NativeName("GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS_OES")]
    MaxTessControlTextureImageUnitsOES = unchecked((uint)0x8E81),

    [NativeName("GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS_OES")]
    MaxTessEvaluationTextureImageUnitsOES = unchecked((uint)0x8E82),

    [NativeName("GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS_OES")]
    MaxTessControlOutputComponentsOES = unchecked((uint)0x8E83),

    [NativeName("GL_MAX_TESS_PATCH_COMPONENTS_OES")]
    MaxTessPatchComponentsOES = unchecked((uint)0x8E84),

    [NativeName("GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS_OES")]
    MaxTessControlTotalOutputComponentsOES = unchecked((uint)0x8E85),

    [NativeName("GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS_OES")]
    MaxTessEvaluationOutputComponentsOES = unchecked((uint)0x8E86),

    [NativeName("GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS_OES")]
    MaxTessControlUniformBlocksOES = unchecked((uint)0x8E89),

    [NativeName("GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS_OES")]
    MaxTessEvaluationUniformBlocksOES = unchecked((uint)0x8E8A),

    [NativeName("GL_MAX_TESS_CONTROL_INPUT_COMPONENTS_OES")]
    MaxTessControlInputComponentsOES = unchecked((uint)0x886C),

    [NativeName("GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS_OES")]
    MaxTessEvaluationInputComponentsOES = unchecked((uint)0x886D),

    [NativeName("GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS_OES")]
    MaxCombinedTessControlUniformComponentsOES = unchecked((uint)0x8E1E),

    [NativeName("GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS_OES")]
    MaxCombinedTessEvaluationUniformComponentsOES = unchecked((uint)0x8E1F),

    [NativeName("GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS_OES")]
    MaxTessControlAtomicCounterBuffersOES = unchecked((uint)0x92CD),

    [NativeName("GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS_OES")]
    MaxTessEvaluationAtomicCounterBuffersOES = unchecked((uint)0x92CE),

    [NativeName("GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS_OES")]
    MaxTessControlAtomicCountersOES = unchecked((uint)0x92D3),

    [NativeName("GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS_OES")]
    MaxTessEvaluationAtomicCountersOES = unchecked((uint)0x92D4),

    [NativeName("GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS_OES")]
    MaxTessControlImageUniformsOES = unchecked((uint)0x90CB),

    [NativeName("GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS_OES")]
    MaxTessEvaluationImageUniformsOES = unchecked((uint)0x90CC),

    [NativeName("GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS_OES")]
    MaxTessControlShaderStorageBlocksOES = unchecked((uint)0x90D8),

    [NativeName("GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS_OES")]
    MaxTessEvaluationShaderStorageBlocksOES = unchecked((uint)0x90D9),

    [NativeName("GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED_OES")]
    PrimitiveRestartForPatchesSupportedOES = unchecked((uint)0x8221),

    [NativeName("GL_IS_PER_PATCH_OES")]
    IsPerPatchOES = unchecked((uint)0x92E7),

    [NativeName("GL_REFERENCED_BY_TESS_CONTROL_SHADER_OES")]
    ReferencedByTessControlShaderOES = unchecked((uint)0x9307),

    [NativeName("GL_REFERENCED_BY_TESS_EVALUATION_SHADER_OES")]
    ReferencedByTessEvaluationShaderOES = unchecked((uint)0x9308),

    [NativeName("GL_TESS_CONTROL_SHADER_OES")]
    TessControlShaderOES = unchecked((uint)0x8E88),

    [NativeName("GL_TESS_EVALUATION_SHADER_OES")]
    TessEvaluationShaderOES = unchecked((uint)0x8E87),

    [NativeName("GL_TESS_CONTROL_SHADER_BIT_OES")]
    TessControlShaderBitOES = unchecked((uint)0x00000008),

    [NativeName("GL_TESS_EVALUATION_SHADER_BIT_OES")]
    TessEvaluationShaderBitOES = unchecked((uint)0x00000010),

    [NativeName("GL_TEXTURE_WRAP_R_OES")]
    TextureWrapROES = unchecked((uint)0x8072),

    [NativeName("GL_TEXTURE_3D_OES")]
    Texture3DOES = unchecked((uint)0x806F),

    [NativeName("GL_TEXTURE_BINDING_3D_OES")]
    TextureBinding3DOES = unchecked((uint)0x806A),

    [NativeName("GL_MAX_3D_TEXTURE_SIZE_OES")]
    Max3DTextureSizeOES = unchecked((uint)0x8073),

    [NativeName("GL_SAMPLER_3D_OES")]
    Sampler3DOES = unchecked((uint)0x8B5F),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_OES")]
    FramebufferAttachmentTexture3DZoffsetOES = unchecked((uint)0x8CD4),

    [NativeName("GL_TEXTURE_BORDER_COLOR_OES")]
    TextureBorderColorOES = unchecked((uint)0x1004),

    [NativeName("GL_CLAMP_TO_BORDER_OES")]
    ClampToBorderOES = unchecked((uint)0x812D),

    [NativeName("GL_TEXTURE_BUFFER_OES")]
    TextureBufferOES = unchecked((uint)0x8C2A),

    [NativeName("GL_TEXTURE_BUFFER_BINDING_OES")]
    TextureBufferBindingOES = unchecked((uint)0x8C2A),

    [NativeName("GL_MAX_TEXTURE_BUFFER_SIZE_OES")]
    MaxTextureBufferSizeOES = unchecked((uint)0x8C2B),

    [NativeName("GL_TEXTURE_BINDING_BUFFER_OES")]
    TextureBindingBufferOES = unchecked((uint)0x8C2C),

    [NativeName("GL_TEXTURE_BUFFER_DATA_STORE_BINDING_OES")]
    TextureBufferDataStoreBindingOES = unchecked((uint)0x8C2D),

    [NativeName("GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT_OES")]
    TextureBufferOffsetAlignmentOES = unchecked((uint)0x919F),

    [NativeName("GL_SAMPLER_BUFFER_OES")]
    SamplerBufferOES = unchecked((uint)0x8DC2),

    [NativeName("GL_INT_SAMPLER_BUFFER_OES")]
    IntSamplerBufferOES = unchecked((uint)0x8DD0),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_BUFFER_OES")]
    UnsignedIntSamplerBufferOES = unchecked((uint)0x8DD8),

    [NativeName("GL_IMAGE_BUFFER_OES")]
    ImageBufferOES = unchecked((uint)0x9051),

    [NativeName("GL_INT_IMAGE_BUFFER_OES")]
    IntImageBufferOES = unchecked((uint)0x905C),

    [NativeName("GL_UNSIGNED_INT_IMAGE_BUFFER_OES")]
    UnsignedIntImageBufferOES = unchecked((uint)0x9067),

    [NativeName("GL_TEXTURE_BUFFER_OFFSET_OES")]
    TextureBufferOffsetOES = unchecked((uint)0x919D),

    [NativeName("GL_TEXTURE_BUFFER_SIZE_OES")]
    TextureBufferSizeOES = unchecked((uint)0x919E),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_3x3x3_OES")]
    CompressedRgbaAstc3X3X3OES = unchecked((uint)0x93C0),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_4x3x3_OES")]
    CompressedRgbaAstc4X3X3OES = unchecked((uint)0x93C1),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_4x4x3_OES")]
    CompressedRgbaAstc4X4X3OES = unchecked((uint)0x93C2),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_4x4x4_OES")]
    CompressedRgbaAstc4X4X4OES = unchecked((uint)0x93C3),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_5x4x4_OES")]
    CompressedRgbaAstc5X4X4OES = unchecked((uint)0x93C4),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_5x5x4_OES")]
    CompressedRgbaAstc5X5X4OES = unchecked((uint)0x93C5),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_5x5x5_OES")]
    CompressedRgbaAstc5X5X5OES = unchecked((uint)0x93C6),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_6x5x5_OES")]
    CompressedRgbaAstc6X5X5OES = unchecked((uint)0x93C7),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_6x6x5_OES")]
    CompressedRgbaAstc6X6X5OES = unchecked((uint)0x93C8),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_6x6x6_OES")]
    CompressedRgbaAstc6X6X6OES = unchecked((uint)0x93C9),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_3x3x3_OES")]
    CompressedSrgb8Alpha8Astc3X3X3OES = unchecked((uint)0x93E0),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x3x3_OES")]
    CompressedSrgb8Alpha8Astc4X3X3OES = unchecked((uint)0x93E1),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x3_OES")]
    CompressedSrgb8Alpha8Astc4X4X3OES = unchecked((uint)0x93E2),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x4_OES")]
    CompressedSrgb8Alpha8Astc4X4X4OES = unchecked((uint)0x93E3),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4x4_OES")]
    CompressedSrgb8Alpha8Astc5X4X4OES = unchecked((uint)0x93E4),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x4_OES")]
    CompressedSrgb8Alpha8Astc5X5X4OES = unchecked((uint)0x93E5),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x5_OES")]
    CompressedSrgb8Alpha8Astc5X5X5OES = unchecked((uint)0x93E6),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5x5_OES")]
    CompressedSrgb8Alpha8Astc6X5X5OES = unchecked((uint)0x93E7),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x5_OES")]
    CompressedSrgb8Alpha8Astc6X6X5OES = unchecked((uint)0x93E8),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x6_OES")]
    CompressedSrgb8Alpha8Astc6X6X6OES = unchecked((uint)0x93E9),

    [NativeName("GL_TEXTURE_CUBE_MAP_ARRAY_OES")]
    TextureCubeMapArrayOES = unchecked((uint)0x9009),

    [NativeName("GL_TEXTURE_BINDING_CUBE_MAP_ARRAY_OES")]
    TextureBindingCubeMapArrayOES = unchecked((uint)0x900A),

    [NativeName("GL_SAMPLER_CUBE_MAP_ARRAY_OES")]
    SamplerCubeMapArrayOES = unchecked((uint)0x900C),

    [NativeName("GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW_OES")]
    SamplerCubeMapArrayShadowOES = unchecked((uint)0x900D),

    [NativeName("GL_INT_SAMPLER_CUBE_MAP_ARRAY_OES")]
    IntSamplerCubeMapArrayOES = unchecked((uint)0x900E),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_OES")]
    UnsignedIntSamplerCubeMapArrayOES = unchecked((uint)0x900F),

    [NativeName("GL_IMAGE_CUBE_MAP_ARRAY_OES")]
    ImageCubeMapArrayOES = unchecked((uint)0x9054),

    [NativeName("GL_INT_IMAGE_CUBE_MAP_ARRAY_OES")]
    IntImageCubeMapArrayOES = unchecked((uint)0x905F),

    [NativeName("GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_OES")]
    UnsignedIntImageCubeMapArrayOES = unchecked((uint)0x906A),

    [NativeName("GL_HALF_FLOAT_OES")]
    HalfFloatOES = unchecked((uint)0x8D61),

    [NativeName("GL_STENCIL_INDEX_OES")]
    StencilIndexOES = unchecked((uint)0x1901),

    [NativeName("GL_TEXTURE_2D_MULTISAMPLE_ARRAY_OES")]
    Texture2DMultisampleArrayOES = unchecked((uint)0x9102),

    [NativeName("GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY_OES")]
    TextureBinding2DMultisampleArrayOES = unchecked((uint)0x9105),

    [NativeName("GL_SAMPLER_2D_MULTISAMPLE_ARRAY_OES")]
    Sampler2DMultisampleArrayOES = unchecked((uint)0x910B),

    [NativeName("GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY_OES")]
    IntSampler2DMultisampleArrayOES = unchecked((uint)0x910C),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY_OES")]
    UnsignedIntSampler2DMultisampleArrayOES = unchecked((uint)0x910D),

    [NativeName("GL_TEXTURE_VIEW_MIN_LEVEL_OES")]
    TextureViewMinLevelOES = unchecked((uint)0x82DB),

    [NativeName("GL_TEXTURE_VIEW_NUM_LEVELS_OES")]
    TextureViewNumLevelsOES = unchecked((uint)0x82DC),

    [NativeName("GL_TEXTURE_VIEW_MIN_LAYER_OES")]
    TextureViewMinLayerOES = unchecked((uint)0x82DD),

    [NativeName("GL_TEXTURE_VIEW_NUM_LAYERS_OES")]
    TextureViewNumLayersOES = unchecked((uint)0x82DE),

    [NativeName("GL_UNSIGNED_INT_10_10_10_2_OES")]
    UnsignedInt10X10X10X2OES = unchecked((uint)0x8DF6),

    [NativeName("GL_INT_10_10_10_2_OES")]
    Int10X10X10X2OES = unchecked((uint)0x8DF7),

    [NativeName("GL_MAX_VIEWPORTS_OES")]
    MaxViewportsOES = unchecked((uint)0x825B),

    [NativeName("GL_VIEWPORT_SUBPIXEL_BITS_OES")]
    ViewportSubpixelBitsOES = unchecked((uint)0x825C),

    [NativeName("GL_VIEWPORT_BOUNDS_RANGE_OES")]
    ViewportBoundsRangeOES = unchecked((uint)0x825D),

    [NativeName("GL_VIEWPORT_INDEX_PROVOKING_VERTEX_OES")]
    ViewportIndexProvokingVertexOES = unchecked((uint)0x825F),

    [NativeName("GL_Z400_BINARY_AMD")]
    Z400BinaryAMD = unchecked((uint)0x8740),

    [NativeName("GL_READ_FRAMEBUFFER_ANGLE")]
    ReadFramebufferANGLE = unchecked((uint)0x8CA8),

    [NativeName("GL_DRAW_FRAMEBUFFER_ANGLE")]
    DrawFramebufferANGLE = unchecked((uint)0x8CA9),

    [NativeName("GL_DRAW_FRAMEBUFFER_BINDING_ANGLE")]
    DrawFramebufferBindingANGLE = unchecked((uint)0x8CA6),

    [NativeName("GL_READ_FRAMEBUFFER_BINDING_ANGLE")]
    ReadFramebufferBindingANGLE = unchecked((uint)0x8CAA),

    [NativeName("GL_RENDERBUFFER_SAMPLES_ANGLE")]
    RenderbufferSamplesANGLE = unchecked((uint)0x8CAB),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_ANGLE")]
    FramebufferIncompleteMultisampleANGLE = unchecked((uint)0x8D56),

    [NativeName("GL_MAX_SAMPLES_ANGLE")]
    MaxSamplesANGLE = unchecked((uint)0x8D57),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_DIVISOR_ANGLE")]
    VertexAttribArrayDivisorANGLE = unchecked((uint)0x88FE),

    [NativeName("GL_PACK_REVERSE_ROW_ORDER_ANGLE")]
    PackReverseRowOrderANGLE = unchecked((uint)0x93A4),

    [NativeName("GL_PROGRAM_BINARY_ANGLE")]
    ProgramBinaryANGLE = unchecked((uint)0x93A6),

    [NativeName("GL_COMPRESSED_RGBA_S3TC_DXT3_ANGLE")]
    CompressedRgbaS3TcDxt3ANGLE = unchecked((uint)0x83F2),

    [NativeName("GL_COMPRESSED_RGBA_S3TC_DXT5_ANGLE")]
    CompressedRgbaS3TcDxt5ANGLE = unchecked((uint)0x83F3),

    [NativeName("GL_TEXTURE_USAGE_ANGLE")]
    TextureUsageANGLE = unchecked((uint)0x93A2),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_ANGLE")]
    FramebufferAttachmentANGLE = unchecked((uint)0x93A3),

    [NativeName("GL_TRANSLATED_SHADER_SOURCE_LENGTH_ANGLE")]
    TranslatedShaderSourceLengthANGLE = unchecked((uint)0x93A0),

    [NativeName("GL_MAX_CLIP_DISTANCES_APPLE")]
    MaxClipDistancesAPPLE = unchecked((uint)0x0D32),

    [NativeName("GL_CLIP_DISTANCE0_APPLE")]
    ClipDistance0APPLE = unchecked((uint)0x3000),

    [NativeName("GL_CLIP_DISTANCE1_APPLE")]
    ClipDistance1APPLE = unchecked((uint)0x3001),

    [NativeName("GL_CLIP_DISTANCE2_APPLE")]
    ClipDistance2APPLE = unchecked((uint)0x3002),

    [NativeName("GL_CLIP_DISTANCE3_APPLE")]
    ClipDistance3APPLE = unchecked((uint)0x3003),

    [NativeName("GL_CLIP_DISTANCE4_APPLE")]
    ClipDistance4APPLE = unchecked((uint)0x3004),

    [NativeName("GL_CLIP_DISTANCE5_APPLE")]
    ClipDistance5APPLE = unchecked((uint)0x3005),

    [NativeName("GL_CLIP_DISTANCE6_APPLE")]
    ClipDistance6APPLE = unchecked((uint)0x3006),

    [NativeName("GL_CLIP_DISTANCE7_APPLE")]
    ClipDistance7APPLE = unchecked((uint)0x3007),

    [NativeName("GL_UNSIGNED_INT_10F_11F_11F_REV_APPLE")]
    UnsignedInt10F11F11FRevAPPLE = unchecked((uint)0x8C3B),

    [NativeName("GL_UNSIGNED_INT_5_9_9_9_REV_APPLE")]
    UnsignedInt5X9X9X9RevAPPLE = unchecked((uint)0x8C3E),

    [NativeName("GL_R11F_G11F_B10F_APPLE")]
    R11FG11FB10FAPPLE = unchecked((uint)0x8C3A),

    [NativeName("GL_RGB9_E5_APPLE")]
    Rgb9E5APPLE = unchecked((uint)0x8C3D),

    [NativeName("GL_MALI_PROGRAM_BINARY_ARM")]
    MaliProgramBinaryARM = unchecked((uint)0x8F61),

    [NativeName("GL_MALI_SHADER_BINARY_ARM")]
    MaliShaderBinaryARM = unchecked((uint)0x8F60),

    [NativeName("GL_FETCH_PER_SAMPLE_ARM")]
    FetchPerSampleARM = unchecked((uint)0x8F65),

    [NativeName("GL_FRAGMENT_SHADER_FRAMEBUFFER_FETCH_MRT_ARM")]
    FragmentShaderFramebufferFetchMrtARM = unchecked((uint)0x8F66),

    [NativeName("GL_TEXTURE_UNNORMALIZED_COORDINATES_ARM")]
    TextureUnnormalizedCoordinatesARM = unchecked((uint)0x8F6A),

    [NativeName("GL_SMAPHS30_PROGRAM_BINARY_DMP")]
    Smaphs30ProgramBinaryDMP = unchecked((uint)0x9251),

    [NativeName("GL_SMAPHS_PROGRAM_BINARY_DMP")]
    SmaphsProgramBinaryDMP = unchecked((uint)0x9252),

    [NativeName("GL_DMP_PROGRAM_BINARY_DMP")]
    DmpProgramBinaryDMP = unchecked((uint)0x9253),

    [NativeName("GL_SHADER_BINARY_DMP")]
    ShaderBinaryDMP = unchecked((uint)0x9250),

    [NativeName("GL_SURFACE_COMPRESSION_EXT")]
    SurfaceCompressionEXT = unchecked((uint)0x96C0),

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_NONE_EXT")]
    SurfaceCompressionFixedRateNoneEXT = unchecked((uint)0x96C1),

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_DEFAULT_EXT")]
    SurfaceCompressionFixedRateDefaultEXT = unchecked((uint)0x96C2),

    [NativeName("GL_SAMPLER_EXTERNAL_2D_Y2Y_EXT")]
    SamplerExternal2DY2YEXT = unchecked((uint)0x8BE7),

    [NativeName("GL_SRC1_COLOR_EXT")]
    Src1ColorEXT = unchecked((uint)0x88F9),

    [NativeName("GL_SRC1_ALPHA_EXT")]
    Src1AlphaEXT = unchecked((uint)0x8589),

    [NativeName("GL_ONE_MINUS_SRC1_COLOR_EXT")]
    OneMinusSrc1ColorEXT = unchecked((uint)0x88FA),

    [NativeName("GL_ONE_MINUS_SRC1_ALPHA_EXT")]
    OneMinusSrc1AlphaEXT = unchecked((uint)0x88FB),

    [NativeName("GL_SRC_ALPHA_SATURATE_EXT")]
    SrcAlphaSaturateEXT = unchecked((uint)0x0308),

    [NativeName("GL_LOCATION_INDEX_EXT")]
    LocationIndexEXT = unchecked((uint)0x930F),

    [NativeName("GL_MAX_DUAL_SOURCE_DRAW_BUFFERS_EXT")]
    MaxDualSourceDrawBuffersEXT = unchecked((uint)0x88FC),

    [NativeName("GL_MAP_PERSISTENT_BIT_EXT")]
    MapPersistentBitEXT = unchecked((uint)0x0040),

    [NativeName("GL_MAP_COHERENT_BIT_EXT")]
    MapCoherentBitEXT = unchecked((uint)0x0080),

    [NativeName("GL_DYNAMIC_STORAGE_BIT_EXT")]
    DynamicStorageBitEXT = unchecked((uint)0x0100),

    [NativeName("GL_CLIENT_STORAGE_BIT_EXT")]
    ClientStorageBitEXT = unchecked((uint)0x0200),

    [NativeName("GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT_EXT")]
    ClientMappedBufferBarrierBitEXT = unchecked((uint)0x00004000),

    [NativeName("GL_BUFFER_IMMUTABLE_STORAGE_EXT")]
    BufferImmutableStorageEXT = unchecked((uint)0x821F),

    [NativeName("GL_BUFFER_STORAGE_FLAGS_EXT")]
    BufferStorageFlagsEXT = unchecked((uint)0x8220),

    [NativeName("GL_LOWER_LEFT_EXT")]
    LowerLeftEXT = unchecked((uint)0x8CA1),

    [NativeName("GL_UPPER_LEFT_EXT")]
    UpperLeftEXT = unchecked((uint)0x8CA2),

    [NativeName("GL_NEGATIVE_ONE_TO_ONE_EXT")]
    NegativeOneToOneEXT = unchecked((uint)0x935E),

    [NativeName("GL_ZERO_TO_ONE_EXT")]
    ZeroToOneEXT = unchecked((uint)0x935F),

    [NativeName("GL_CLIP_ORIGIN_EXT")]
    ClipOriginEXT = unchecked((uint)0x935C),

    [NativeName("GL_CLIP_DEPTH_MODE_EXT")]
    ClipDepthModeEXT = unchecked((uint)0x935D),

    [NativeName("GL_MAX_CLIP_DISTANCES_EXT")]
    MaxClipDistancesEXT = unchecked((uint)0x0D32),

    [NativeName("GL_MAX_CULL_DISTANCES_EXT")]
    MaxCullDistancesEXT = unchecked((uint)0x82F9),

    [NativeName("GL_MAX_COMBINED_CLIP_AND_CULL_DISTANCES_EXT")]
    MaxCombinedClipAndCullDistancesEXT = unchecked((uint)0x82FA),

    [NativeName("GL_CLIP_DISTANCE0_EXT")]
    ClipDistance0EXT = unchecked((uint)0x3000),

    [NativeName("GL_CLIP_DISTANCE1_EXT")]
    ClipDistance1EXT = unchecked((uint)0x3001),

    [NativeName("GL_CLIP_DISTANCE2_EXT")]
    ClipDistance2EXT = unchecked((uint)0x3002),

    [NativeName("GL_CLIP_DISTANCE3_EXT")]
    ClipDistance3EXT = unchecked((uint)0x3003),

    [NativeName("GL_CLIP_DISTANCE4_EXT")]
    ClipDistance4EXT = unchecked((uint)0x3004),

    [NativeName("GL_CLIP_DISTANCE5_EXT")]
    ClipDistance5EXT = unchecked((uint)0x3005),

    [NativeName("GL_CLIP_DISTANCE6_EXT")]
    ClipDistance6EXT = unchecked((uint)0x3006),

    [NativeName("GL_CLIP_DISTANCE7_EXT")]
    ClipDistance7EXT = unchecked((uint)0x3007),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE_EXT")]
    FramebufferAttachmentComponentTypeEXT = unchecked((uint)0x8211),

    [NativeName("GL_UNSIGNED_NORMALIZED_EXT")]
    UnsignedNormalizedEXT = unchecked((uint)0x8C17),

    [NativeName("GL_DEPTH_CLAMP_EXT")]
    DepthClampEXT = unchecked((uint)0x864F),

    [NativeName("GL_QUERY_COUNTER_BITS_EXT")]
    QueryCounterBitsEXT = unchecked((uint)0x8864),

    [NativeName("GL_CURRENT_QUERY_EXT")]
    CurrentQueryEXT = unchecked((uint)0x8865),

    [NativeName("GL_QUERY_RESULT_EXT")]
    QueryResultEXT = unchecked((uint)0x8866),

    [NativeName("GL_QUERY_RESULT_AVAILABLE_EXT")]
    QueryResultAvailableEXT = unchecked((uint)0x8867),

    [NativeName("GL_TIMESTAMP_EXT")]
    TimestampEXT = unchecked((uint)0x8E28),

    [NativeName("GL_GPU_DISJOINT_EXT")]
    GpuDisjointEXT = unchecked((uint)0x8FBB),

    [NativeName("GL_MAX_DRAW_BUFFERS_EXT")]
    MaxDrawBuffersEXT = unchecked((uint)0x8824),

    [NativeName("GL_DRAW_BUFFER0_EXT")]
    DrawBuffer0EXT = unchecked((uint)0x8825),

    [NativeName("GL_DRAW_BUFFER1_EXT")]
    DrawBuffer1EXT = unchecked((uint)0x8826),

    [NativeName("GL_DRAW_BUFFER2_EXT")]
    DrawBuffer2EXT = unchecked((uint)0x8827),

    [NativeName("GL_DRAW_BUFFER3_EXT")]
    DrawBuffer3EXT = unchecked((uint)0x8828),

    [NativeName("GL_DRAW_BUFFER4_EXT")]
    DrawBuffer4EXT = unchecked((uint)0x8829),

    [NativeName("GL_DRAW_BUFFER5_EXT")]
    DrawBuffer5EXT = unchecked((uint)0x882A),

    [NativeName("GL_DRAW_BUFFER6_EXT")]
    DrawBuffer6EXT = unchecked((uint)0x882B),

    [NativeName("GL_DRAW_BUFFER7_EXT")]
    DrawBuffer7EXT = unchecked((uint)0x882C),

    [NativeName("GL_DRAW_BUFFER8_EXT")]
    DrawBuffer8EXT = unchecked((uint)0x882D),

    [NativeName("GL_DRAW_BUFFER9_EXT")]
    DrawBuffer9EXT = unchecked((uint)0x882E),

    [NativeName("GL_DRAW_BUFFER10_EXT")]
    DrawBuffer10EXT = unchecked((uint)0x882F),

    [NativeName("GL_DRAW_BUFFER11_EXT")]
    DrawBuffer11EXT = unchecked((uint)0x8830),

    [NativeName("GL_DRAW_BUFFER12_EXT")]
    DrawBuffer12EXT = unchecked((uint)0x8831),

    [NativeName("GL_DRAW_BUFFER13_EXT")]
    DrawBuffer13EXT = unchecked((uint)0x8832),

    [NativeName("GL_DRAW_BUFFER14_EXT")]
    DrawBuffer14EXT = unchecked((uint)0x8833),

    [NativeName("GL_DRAW_BUFFER15_EXT")]
    DrawBuffer15EXT = unchecked((uint)0x8834),

    [NativeName("GL_SHADING_RATE_1X1_PIXELS_EXT")]
    ShadingRate1X1PixelsEXT = unchecked((uint)0x96A6),

    [NativeName("GL_SHADING_RATE_1X2_PIXELS_EXT")]
    ShadingRate1X2PixelsEXT = unchecked((uint)0x96A7),

    [NativeName("GL_SHADING_RATE_2X1_PIXELS_EXT")]
    ShadingRate2X1PixelsEXT = unchecked((uint)0x96A8),

    [NativeName("GL_SHADING_RATE_2X2_PIXELS_EXT")]
    ShadingRate2X2PixelsEXT = unchecked((uint)0x96A9),

    [NativeName("GL_SHADING_RATE_1X4_PIXELS_EXT")]
    ShadingRate1X4PixelsEXT = unchecked((uint)0x96AA),

    [NativeName("GL_SHADING_RATE_4X1_PIXELS_EXT")]
    ShadingRate4X1PixelsEXT = unchecked((uint)0x96AB),

    [NativeName("GL_SHADING_RATE_4X2_PIXELS_EXT")]
    ShadingRate4X2PixelsEXT = unchecked((uint)0x96AC),

    [NativeName("GL_SHADING_RATE_2X4_PIXELS_EXT")]
    ShadingRate2X4PixelsEXT = unchecked((uint)0x96AD),

    [NativeName("GL_SHADING_RATE_4X4_PIXELS_EXT")]
    ShadingRate4X4PixelsEXT = unchecked((uint)0x96AE),

    [NativeName("GL_SHADING_RATE_EXT")]
    ShadingRateEXT = unchecked((uint)0x96D0),

    [NativeName("GL_SHADING_RATE_ATTACHMENT_EXT")]
    ShadingRateAttachmentEXT = unchecked((uint)0x96D1),

    [NativeName("GL_FRAGMENT_SHADING_RATE_COMBINER_OP_KEEP_EXT")]
    FragmentShadingRateCombinerOpKeepEXT = unchecked((uint)0x96D2),

    [NativeName("GL_FRAGMENT_SHADING_RATE_COMBINER_OP_REPLACE_EXT")]
    FragmentShadingRateCombinerOpReplaceEXT = unchecked((uint)0x96D3),

    [NativeName("GL_FRAGMENT_SHADING_RATE_COMBINER_OP_MIN_EXT")]
    FragmentShadingRateCombinerOpMinEXT = unchecked((uint)0x96D4),

    [NativeName("GL_FRAGMENT_SHADING_RATE_COMBINER_OP_MAX_EXT")]
    FragmentShadingRateCombinerOpMaxEXT = unchecked((uint)0x96D5),

    [NativeName("GL_FRAGMENT_SHADING_RATE_COMBINER_OP_MUL_EXT")]
    FragmentShadingRateCombinerOpMulEXT = unchecked((uint)0x96D6),

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

    [NativeName("GL_GEOMETRY_SHADER_BIT_EXT")]
    GeometryShaderBitEXT = unchecked((uint)0x00000004),

    [NativeName("GL_GEOMETRY_LINKED_VERTICES_OUT_EXT")]
    GeometryLinkedVerticesOutEXT = unchecked((uint)0x8916),

    [NativeName("GL_GEOMETRY_LINKED_INPUT_TYPE_EXT")]
    GeometryLinkedInputTypeEXT = unchecked((uint)0x8917),

    [NativeName("GL_GEOMETRY_LINKED_OUTPUT_TYPE_EXT")]
    GeometryLinkedOutputTypeEXT = unchecked((uint)0x8918),

    [NativeName("GL_GEOMETRY_SHADER_INVOCATIONS_EXT")]
    GeometryShaderInvocationsEXT = unchecked((uint)0x887F),

    [NativeName("GL_LAYER_PROVOKING_VERTEX_EXT")]
    LayerProvokingVertexEXT = unchecked((uint)0x825E),

    [NativeName("GL_MAX_GEOMETRY_UNIFORM_BLOCKS_EXT")]
    MaxGeometryUniformBlocksEXT = unchecked((uint)0x8A2C),

    [NativeName("GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS_EXT")]
    MaxCombinedGeometryUniformComponentsEXT = unchecked((uint)0x8A32),

    [NativeName("GL_MAX_GEOMETRY_INPUT_COMPONENTS_EXT")]
    MaxGeometryInputComponentsEXT = unchecked((uint)0x9123),

    [NativeName("GL_MAX_GEOMETRY_OUTPUT_COMPONENTS_EXT")]
    MaxGeometryOutputComponentsEXT = unchecked((uint)0x9124),

    [NativeName("GL_MAX_GEOMETRY_SHADER_INVOCATIONS_EXT")]
    MaxGeometryShaderInvocationsEXT = unchecked((uint)0x8E5A),

    [NativeName("GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS_EXT")]
    MaxGeometryAtomicCounterBuffersEXT = unchecked((uint)0x92CF),

    [NativeName("GL_MAX_GEOMETRY_ATOMIC_COUNTERS_EXT")]
    MaxGeometryAtomicCountersEXT = unchecked((uint)0x92D5),

    [NativeName("GL_MAX_GEOMETRY_IMAGE_UNIFORMS_EXT")]
    MaxGeometryImageUniformsEXT = unchecked((uint)0x90CD),

    [NativeName("GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS_EXT")]
    MaxGeometryShaderStorageBlocksEXT = unchecked((uint)0x90D7),

    [NativeName("GL_UNDEFINED_VERTEX_EXT")]
    UndefinedVertexEXT = unchecked((uint)0x8260),

    [NativeName("GL_FRAMEBUFFER_DEFAULT_LAYERS_EXT")]
    FramebufferDefaultLayersEXT = unchecked((uint)0x9312),

    [NativeName("GL_MAX_FRAMEBUFFER_LAYERS_EXT")]
    MaxFramebufferLayersEXT = unchecked((uint)0x9317),

    [NativeName("GL_REFERENCED_BY_GEOMETRY_SHADER_EXT")]
    ReferencedByGeometryShaderEXT = unchecked((uint)0x9309),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_DIVISOR_EXT")]
    VertexAttribArrayDivisorEXT = unchecked((uint)0x88FE),

    [NativeName("GL_COLOR_ATTACHMENT_EXT")]
    ColorAttachmentEXT = unchecked((uint)0x90F0),

    [NativeName("GL_MULTIVIEW_EXT")]
    MultiviewEXT = unchecked((uint)0x90F1),

    [NativeName("GL_DRAW_BUFFER_EXT")]
    DrawBufferEXT = unchecked((uint)0x0C01),

    [NativeName("GL_READ_BUFFER_EXT")]
    ReadBufferEXT = unchecked((uint)0x0C02),

    [NativeName("GL_MAX_MULTIVIEW_BUFFERS_EXT")]
    MaxMultiviewBuffersEXT = unchecked((uint)0x90F2),

    [NativeName("GL_ANY_SAMPLES_PASSED_EXT")]
    AnySamplesPassedEXT = unchecked((uint)0x8C2F),

    [NativeName("GL_ANY_SAMPLES_PASSED_CONSERVATIVE_EXT")]
    AnySamplesPassedConservativeEXT = unchecked((uint)0x8D6A),

    [NativeName("GL_PRIMITIVE_BOUNDING_BOX_EXT")]
    PrimitiveBoundingBoxEXT = unchecked((uint)0x92BE),

    [NativeName("GL_CONTEXT_FLAG_PROTECTED_CONTENT_BIT_EXT")]
    ContextFlagProtectedContentBitEXT = unchecked((uint)0x00000010),

    [NativeName("GL_TEXTURE_PROTECTED_EXT")]
    TextureProtectedEXT = unchecked((uint)0x8BFA),

    [NativeName("GL_COMPRESSED_SRGB_PVRTC_2BPPV1_EXT")]
    CompressedSrgbPvrtc2Bppv1EXT = unchecked((uint)0x8A54),

    [NativeName("GL_COMPRESSED_SRGB_PVRTC_4BPPV1_EXT")]
    CompressedSrgbPvrtc4Bppv1EXT = unchecked((uint)0x8A55),

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_PVRTC_2BPPV1_EXT")]
    CompressedSrgbAlphaPvrtc2Bppv1EXT = unchecked((uint)0x8A56),

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_PVRTC_4BPPV1_EXT")]
    CompressedSrgbAlphaPvrtc4Bppv1EXT = unchecked((uint)0x8A57),

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_PVRTC_2BPPV2_IMG")]
    CompressedSrgbAlphaPvrtc2Bppv2IMG = unchecked((uint)0x93F0),

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_PVRTC_4BPPV2_IMG")]
    CompressedSrgbAlphaPvrtc4Bppv2IMG = unchecked((uint)0x93F1),

    [NativeName("GL_R16_SNORM_EXT")]
    R16SnormEXT = unchecked((uint)0x8F98),

    [NativeName("GL_RG16_SNORM_EXT")]
    Rg16SnormEXT = unchecked((uint)0x8F99),

    [NativeName("GL_RGBA16_SNORM_EXT")]
    Rgba16SnormEXT = unchecked((uint)0x8F9B),

    [NativeName("GL_VERTEX_SHADER_BIT_EXT")]
    VertexShaderBitEXT = unchecked((uint)0x00000001),

    [NativeName("GL_FRAGMENT_SHADER_BIT_EXT")]
    FragmentShaderBitEXT = unchecked((uint)0x00000002),

    [NativeName("GL_ALL_SHADER_BITS_EXT")]
    AllShaderBitsEXT = unchecked((uint)0xFFFFFFFF),

    [NativeName("GL_PROGRAM_SEPARABLE_EXT")]
    ProgramSeparableEXT = unchecked((uint)0x8258),

    [NativeName("GL_PROGRAM_PIPELINE_BINDING_EXT")]
    ProgramPipelineBindingEXT = unchecked((uint)0x825A),

    [NativeName("GL_MAX_SHADER_PIXEL_LOCAL_STORAGE_FAST_SIZE_EXT")]
    MaxShaderPixelLocalStorageFastSizeEXT = unchecked((uint)0x8F63),

    [NativeName("GL_MAX_SHADER_PIXEL_LOCAL_STORAGE_SIZE_EXT")]
    MaxShaderPixelLocalStorageSizeEXT = unchecked((uint)0x8F67),

    [NativeName("GL_SHADER_PIXEL_LOCAL_STORAGE_EXT")]
    ShaderPixelLocalStorageEXT = unchecked((uint)0x8F64),

    [NativeName("GL_MAX_SHADER_COMBINED_LOCAL_STORAGE_FAST_SIZE_EXT")]
    MaxShaderCombinedLocalStorageFastSizeEXT = unchecked((uint)0x9650),

    [NativeName("GL_MAX_SHADER_COMBINED_LOCAL_STORAGE_SIZE_EXT")]
    MaxShaderCombinedLocalStorageSizeEXT = unchecked((uint)0x9651),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_INSUFFICIENT_SHADER_COMBINED_LOCAL_STORAGE_EXT")]
    FramebufferIncompleteInsufficientShaderCombinedLocalStorageEXT = unchecked((uint)0x9652),

    [NativeName("GL_TEXTURE_COMPARE_MODE_EXT")]
    TextureCompareModeEXT = unchecked((uint)0x884C),

    [NativeName("GL_TEXTURE_COMPARE_FUNC_EXT")]
    TextureCompareFuncEXT = unchecked((uint)0x884D),

    [NativeName("GL_COMPARE_REF_TO_TEXTURE_EXT")]
    CompareRefToTextureEXT = unchecked((uint)0x884E),

    [NativeName("GL_SAMPLER_2D_SHADOW_EXT")]
    Sampler2DShadowEXT = unchecked((uint)0x8B62),

    [NativeName("GL_TEXTURE_SPARSE_EXT")]
    TextureSparseEXT = unchecked((uint)0x91A6),

    [NativeName("GL_VIRTUAL_PAGE_SIZE_INDEX_EXT")]
    VirtualPageSizeIndexEXT = unchecked((uint)0x91A7),

    [NativeName("GL_NUM_SPARSE_LEVELS_EXT")]
    NumSparseLevelsEXT = unchecked((uint)0x91AA),

    [NativeName("GL_NUM_VIRTUAL_PAGE_SIZES_EXT")]
    NumVirtualPageSizesEXT = unchecked((uint)0x91A8),

    [NativeName("GL_VIRTUAL_PAGE_SIZE_X_EXT")]
    VirtualPageSizeXEXT = unchecked((uint)0x9195),

    [NativeName("GL_VIRTUAL_PAGE_SIZE_Y_EXT")]
    VirtualPageSizeYEXT = unchecked((uint)0x9196),

    [NativeName("GL_VIRTUAL_PAGE_SIZE_Z_EXT")]
    VirtualPageSizeZEXT = unchecked((uint)0x9197),

    [NativeName("GL_MAX_SPARSE_TEXTURE_SIZE_EXT")]
    MaxSparseTextureSizeEXT = unchecked((uint)0x9198),

    [NativeName("GL_MAX_SPARSE_3D_TEXTURE_SIZE_EXT")]
    MaxSparse3DTextureSizeEXT = unchecked((uint)0x9199),

    [NativeName("GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS_EXT")]
    MaxSparseArrayTextureLayersEXT = unchecked((uint)0x919A),

    [NativeName("GL_SPARSE_TEXTURE_FULL_ARRAY_CUBE_MIPMAPS_EXT")]
    SparseTextureFullArrayCubeMipmapsEXT = unchecked((uint)0x91A9),

    [NativeName("GL_PATCHES_EXT")]
    PatchesEXT = unchecked((uint)0x000E),

    [NativeName("GL_PATCH_VERTICES_EXT")]
    PatchVerticesEXT = unchecked((uint)0x8E72),

    [NativeName("GL_TESS_CONTROL_OUTPUT_VERTICES_EXT")]
    TessControlOutputVerticesEXT = unchecked((uint)0x8E75),

    [NativeName("GL_TESS_GEN_MODE_EXT")]
    TessGenModeEXT = unchecked((uint)0x8E76),

    [NativeName("GL_TESS_GEN_SPACING_EXT")]
    TessGenSpacingEXT = unchecked((uint)0x8E77),

    [NativeName("GL_TESS_GEN_VERTEX_ORDER_EXT")]
    TessGenVertexOrderEXT = unchecked((uint)0x8E78),

    [NativeName("GL_TESS_GEN_POINT_MODE_EXT")]
    TessGenPointModeEXT = unchecked((uint)0x8E79),

    [NativeName("GL_ISOLINES_EXT")]
    IsolinesEXT = unchecked((uint)0x8E7A),

    [NativeName("GL_QUADS_EXT")]
    QuadsEXT = unchecked((uint)0x0007),

    [NativeName("GL_FRACTIONAL_ODD_EXT")]
    FractionalOddEXT = unchecked((uint)0x8E7B),

    [NativeName("GL_FRACTIONAL_EVEN_EXT")]
    FractionalEvenEXT = unchecked((uint)0x8E7C),

    [NativeName("GL_MAX_PATCH_VERTICES_EXT")]
    MaxPatchVerticesEXT = unchecked((uint)0x8E7D),

    [NativeName("GL_MAX_TESS_GEN_LEVEL_EXT")]
    MaxTessGenLevelEXT = unchecked((uint)0x8E7E),

    [NativeName("GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS_EXT")]
    MaxTessControlUniformComponentsEXT = unchecked((uint)0x8E7F),

    [NativeName("GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS_EXT")]
    MaxTessEvaluationUniformComponentsEXT = unchecked((uint)0x8E80),

    [NativeName("GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS_EXT")]
    MaxTessControlTextureImageUnitsEXT = unchecked((uint)0x8E81),

    [NativeName("GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS_EXT")]
    MaxTessEvaluationTextureImageUnitsEXT = unchecked((uint)0x8E82),

    [NativeName("GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS_EXT")]
    MaxTessControlOutputComponentsEXT = unchecked((uint)0x8E83),

    [NativeName("GL_MAX_TESS_PATCH_COMPONENTS_EXT")]
    MaxTessPatchComponentsEXT = unchecked((uint)0x8E84),

    [NativeName("GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS_EXT")]
    MaxTessControlTotalOutputComponentsEXT = unchecked((uint)0x8E85),

    [NativeName("GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS_EXT")]
    MaxTessEvaluationOutputComponentsEXT = unchecked((uint)0x8E86),

    [NativeName("GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS_EXT")]
    MaxTessControlUniformBlocksEXT = unchecked((uint)0x8E89),

    [NativeName("GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS_EXT")]
    MaxTessEvaluationUniformBlocksEXT = unchecked((uint)0x8E8A),

    [NativeName("GL_MAX_TESS_CONTROL_INPUT_COMPONENTS_EXT")]
    MaxTessControlInputComponentsEXT = unchecked((uint)0x886C),

    [NativeName("GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS_EXT")]
    MaxTessEvaluationInputComponentsEXT = unchecked((uint)0x886D),

    [NativeName("GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS_EXT")]
    MaxCombinedTessControlUniformComponentsEXT = unchecked((uint)0x8E1E),

    [NativeName("GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS_EXT")]
    MaxCombinedTessEvaluationUniformComponentsEXT = unchecked((uint)0x8E1F),

    [NativeName("GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS_EXT")]
    MaxTessControlAtomicCounterBuffersEXT = unchecked((uint)0x92CD),

    [NativeName("GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS_EXT")]
    MaxTessEvaluationAtomicCounterBuffersEXT = unchecked((uint)0x92CE),

    [NativeName("GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS_EXT")]
    MaxTessControlAtomicCountersEXT = unchecked((uint)0x92D3),

    [NativeName("GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS_EXT")]
    MaxTessEvaluationAtomicCountersEXT = unchecked((uint)0x92D4),

    [NativeName("GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS_EXT")]
    MaxTessControlImageUniformsEXT = unchecked((uint)0x90CB),

    [NativeName("GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS_EXT")]
    MaxTessEvaluationImageUniformsEXT = unchecked((uint)0x90CC),

    [NativeName("GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS_EXT")]
    MaxTessControlShaderStorageBlocksEXT = unchecked((uint)0x90D8),

    [NativeName("GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS_EXT")]
    MaxTessEvaluationShaderStorageBlocksEXT = unchecked((uint)0x90D9),

    [NativeName("GL_IS_PER_PATCH_EXT")]
    IsPerPatchEXT = unchecked((uint)0x92E7),

    [NativeName("GL_REFERENCED_BY_TESS_CONTROL_SHADER_EXT")]
    ReferencedByTessControlShaderEXT = unchecked((uint)0x9307),

    [NativeName("GL_REFERENCED_BY_TESS_EVALUATION_SHADER_EXT")]
    ReferencedByTessEvaluationShaderEXT = unchecked((uint)0x9308),

    [NativeName("GL_TESS_CONTROL_SHADER_EXT")]
    TessControlShaderEXT = unchecked((uint)0x8E88),

    [NativeName("GL_TESS_EVALUATION_SHADER_EXT")]
    TessEvaluationShaderEXT = unchecked((uint)0x8E87),

    [NativeName("GL_TESS_CONTROL_SHADER_BIT_EXT")]
    TessControlShaderBitEXT = unchecked((uint)0x00000008),

    [NativeName("GL_TESS_EVALUATION_SHADER_BIT_EXT")]
    TessEvaluationShaderBitEXT = unchecked((uint)0x00000010),

    [NativeName("GL_TEXTURE_BORDER_COLOR_EXT")]
    TextureBorderColorEXT = unchecked((uint)0x1004),

    [NativeName("GL_CLAMP_TO_BORDER_EXT")]
    ClampToBorderEXT = unchecked((uint)0x812D),

    [NativeName("GL_TEXTURE_BUFFER_BINDING_EXT")]
    TextureBufferBindingEXT = unchecked((uint)0x8C2A),

    [NativeName("GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT_EXT")]
    TextureBufferOffsetAlignmentEXT = unchecked((uint)0x919F),

    [NativeName("GL_TEXTURE_BUFFER_OFFSET_EXT")]
    TextureBufferOffsetEXT = unchecked((uint)0x919D),

    [NativeName("GL_TEXTURE_BUFFER_SIZE_EXT")]
    TextureBufferSizeEXT = unchecked((uint)0x919E),

    [NativeName("GL_TEXTURE_ASTC_DECODE_PRECISION_EXT")]
    TextureAstcDecodePrecisionEXT = unchecked((uint)0x8F69),

    [NativeName("GL_COMPRESSED_RGBA_BPTC_UNORM_EXT")]
    CompressedRgbaBptcUnormEXT = unchecked((uint)0x8E8C),

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM_EXT")]
    CompressedSrgbAlphaBptcUnormEXT = unchecked((uint)0x8E8D),

    [NativeName("GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT_EXT")]
    CompressedRgbBptcSignedFloatEXT = unchecked((uint)0x8E8E),

    [NativeName("GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_EXT")]
    CompressedRgbBptcUnsignedFloatEXT = unchecked((uint)0x8E8F),

    [NativeName("GL_TEXTURE_CUBE_MAP_ARRAY_EXT")]
    TextureCubeMapArrayEXT = unchecked((uint)0x9009),

    [NativeName("GL_TEXTURE_BINDING_CUBE_MAP_ARRAY_EXT")]
    TextureBindingCubeMapArrayEXT = unchecked((uint)0x900A),

    [NativeName("GL_SAMPLER_CUBE_MAP_ARRAY_EXT")]
    SamplerCubeMapArrayEXT = unchecked((uint)0x900C),

    [NativeName("GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW_EXT")]
    SamplerCubeMapArrayShadowEXT = unchecked((uint)0x900D),

    [NativeName("GL_INT_SAMPLER_CUBE_MAP_ARRAY_EXT")]
    IntSamplerCubeMapArrayEXT = unchecked((uint)0x900E),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_EXT")]
    UnsignedIntSamplerCubeMapArrayEXT = unchecked((uint)0x900F),

    [NativeName("GL_TEXTURE_FORMAT_SRGB_OVERRIDE_EXT")]
    TextureFormatSrgbOverrideEXT = unchecked((uint)0x8FBF),

    [NativeName("GL_R16_EXT")]
    R16EXT = unchecked((uint)0x822A),

    [NativeName("GL_RG16_EXT")]
    Rg16EXT = unchecked((uint)0x822C),

    [NativeName("GL_RGB16_SNORM_EXT")]
    Rgb16SnormEXT = unchecked((uint)0x8F9A),

    [NativeName("GL_RED_EXT")]
    RedEXT = unchecked((uint)0x1903),

    [NativeName("GL_RG_EXT")]
    RgEXT = unchecked((uint)0x8227),

    [NativeName("GL_NUM_SURFACE_COMPRESSION_FIXED_RATES_EXT")]
    NumSurfaceCompressionFixedRatesEXT = unchecked((uint)0x8F6E),

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_1BPC_EXT")]
    SurfaceCompressionFixedRate1BpcEXT = unchecked((uint)0x96C4),

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_2BPC_EXT")]
    SurfaceCompressionFixedRate2BpcEXT = unchecked((uint)0x96C5),

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_3BPC_EXT")]
    SurfaceCompressionFixedRate3BpcEXT = unchecked((uint)0x96C6),

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_4BPC_EXT")]
    SurfaceCompressionFixedRate4BpcEXT = unchecked((uint)0x96C7),

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_5BPC_EXT")]
    SurfaceCompressionFixedRate5BpcEXT = unchecked((uint)0x96C8),

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_6BPC_EXT")]
    SurfaceCompressionFixedRate6BpcEXT = unchecked((uint)0x96C9),

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_7BPC_EXT")]
    SurfaceCompressionFixedRate7BpcEXT = unchecked((uint)0x96CA),

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_8BPC_EXT")]
    SurfaceCompressionFixedRate8BpcEXT = unchecked((uint)0x96CB),

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_9BPC_EXT")]
    SurfaceCompressionFixedRate9BpcEXT = unchecked((uint)0x96CC),

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_10BPC_EXT")]
    SurfaceCompressionFixedRate10BpcEXT = unchecked((uint)0x96CD),

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_11BPC_EXT")]
    SurfaceCompressionFixedRate11BpcEXT = unchecked((uint)0x96CE),

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_12BPC_EXT")]
    SurfaceCompressionFixedRate12BpcEXT = unchecked((uint)0x96CF),

    [NativeName("GL_UNSIGNED_INT_2_10_10_10_REV_EXT")]
    UnsignedInt2X10X10X10RevEXT = unchecked((uint)0x8368),

    [NativeName("GL_TEXTURE_VIEW_MIN_LEVEL_EXT")]
    TextureViewMinLevelEXT = unchecked((uint)0x82DB),

    [NativeName("GL_TEXTURE_VIEW_NUM_LEVELS_EXT")]
    TextureViewNumLevelsEXT = unchecked((uint)0x82DC),

    [NativeName("GL_TEXTURE_VIEW_MIN_LAYER_EXT")]
    TextureViewMinLayerEXT = unchecked((uint)0x82DD),

    [NativeName("GL_TEXTURE_VIEW_NUM_LAYERS_EXT")]
    TextureViewNumLayersEXT = unchecked((uint)0x82DE),

    [NativeName("GL_UNPACK_ROW_LENGTH_EXT")]
    UnpackRowLengthEXT = unchecked((uint)0x0CF2),

    [NativeName("GL_UNPACK_SKIP_ROWS_EXT")]
    UnpackSkipRowsEXT = unchecked((uint)0x0CF3),

    [NativeName("GL_UNPACK_SKIP_PIXELS_EXT")]
    UnpackSkipPixelsEXT = unchecked((uint)0x0CF4),

    [NativeName("GL_GCCSO_SHADER_BINARY_FJ")]
    GccsoShaderBinaryFJ = unchecked((uint)0x9260),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_AND_DOWNSAMPLE_IMG")]
    FramebufferIncompleteMultisampleAndDownsampleIMG = unchecked((uint)0x913C),

    [NativeName("GL_NUM_DOWNSAMPLE_SCALES_IMG")]
    NumDownsampleScalesIMG = unchecked((uint)0x913D),

    [NativeName("GL_DOWNSAMPLE_SCALES_IMG")]
    DownsampleScalesIMG = unchecked((uint)0x913E),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SCALE_IMG")]
    FramebufferAttachmentTextureScaleIMG = unchecked((uint)0x913F),

    [NativeName("GL_SGX_PROGRAM_BINARY_IMG")]
    SgxProgramBinaryIMG = unchecked((uint)0x9130),

    [NativeName("GL_SGX_BINARY_IMG")]
    SgxBinaryIMG = unchecked((uint)0x8C0A),

    [NativeName("GL_COMPRESSED_RGBA_PVRTC_2BPPV2_IMG")]
    CompressedRgbaPvrtc2Bppv2IMG = unchecked((uint)0x9137),

    [NativeName("GL_COMPRESSED_RGBA_PVRTC_4BPPV2_IMG")]
    CompressedRgbaPvrtc4Bppv2IMG = unchecked((uint)0x9138),

    [NativeName("GL_CUBIC_IMG")]
    CubicIMG = unchecked((uint)0x9139),

    [NativeName("GL_CUBIC_MIPMAP_NEAREST_IMG")]
    CubicMipmapNearestIMG = unchecked((uint)0x913A),

    [NativeName("GL_CUBIC_MIPMAP_LINEAR_IMG")]
    CubicMipmapLinearIMG = unchecked((uint)0x913B),

    [NativeName("GL_COPY_READ_BUFFER_NV")]
    CopyReadBufferNV = unchecked((uint)0x8F36),

    [NativeName("GL_COPY_WRITE_BUFFER_NV")]
    CopyWriteBufferNV = unchecked((uint)0x8F37),

    [NativeName("GL_COVERAGE_COMPONENT_NV")]
    CoverageComponentNV = unchecked((uint)0x8ED0),

    [NativeName("GL_COVERAGE_COMPONENT4_NV")]
    CoverageComponent4NV = unchecked((uint)0x8ED1),

    [NativeName("GL_COVERAGE_ATTACHMENT_NV")]
    CoverageAttachmentNV = unchecked((uint)0x8ED2),

    [NativeName("GL_COVERAGE_BUFFERS_NV")]
    CoverageBuffersNV = unchecked((uint)0x8ED3),

    [NativeName("GL_COVERAGE_SAMPLES_NV")]
    CoverageSamplesNV = unchecked((uint)0x8ED4),

    [NativeName("GL_COVERAGE_ALL_FRAGMENTS_NV")]
    CoverageAllFragmentsNV = unchecked((uint)0x8ED5),

    [NativeName("GL_COVERAGE_EDGE_FRAGMENTS_NV")]
    CoverageEdgeFragmentsNV = unchecked((uint)0x8ED6),

    [NativeName("GL_COVERAGE_AUTOMATIC_NV")]
    CoverageAutomaticNV = unchecked((uint)0x8ED7),

    [NativeName("GL_COVERAGE_BUFFER_BIT_NV")]
    CoverageBufferBitNV = unchecked((uint)0x00008000),

    [NativeName("GL_DEPTH_COMPONENT16_NONLINEAR_NV")]
    DepthComponent16NonlinearNV = unchecked((uint)0x8E2C),

    [NativeName("GL_MAX_DRAW_BUFFERS_NV")]
    MaxDrawBuffersNV = unchecked((uint)0x8824),

    [NativeName("GL_DRAW_BUFFER0_NV")]
    DrawBuffer0NV = unchecked((uint)0x8825),

    [NativeName("GL_DRAW_BUFFER1_NV")]
    DrawBuffer1NV = unchecked((uint)0x8826),

    [NativeName("GL_DRAW_BUFFER2_NV")]
    DrawBuffer2NV = unchecked((uint)0x8827),

    [NativeName("GL_DRAW_BUFFER3_NV")]
    DrawBuffer3NV = unchecked((uint)0x8828),

    [NativeName("GL_DRAW_BUFFER4_NV")]
    DrawBuffer4NV = unchecked((uint)0x8829),

    [NativeName("GL_DRAW_BUFFER5_NV")]
    DrawBuffer5NV = unchecked((uint)0x882A),

    [NativeName("GL_DRAW_BUFFER6_NV")]
    DrawBuffer6NV = unchecked((uint)0x882B),

    [NativeName("GL_DRAW_BUFFER7_NV")]
    DrawBuffer7NV = unchecked((uint)0x882C),

    [NativeName("GL_DRAW_BUFFER8_NV")]
    DrawBuffer8NV = unchecked((uint)0x882D),

    [NativeName("GL_DRAW_BUFFER9_NV")]
    DrawBuffer9NV = unchecked((uint)0x882E),

    [NativeName("GL_DRAW_BUFFER10_NV")]
    DrawBuffer10NV = unchecked((uint)0x882F),

    [NativeName("GL_DRAW_BUFFER11_NV")]
    DrawBuffer11NV = unchecked((uint)0x8830),

    [NativeName("GL_DRAW_BUFFER12_NV")]
    DrawBuffer12NV = unchecked((uint)0x8831),

    [NativeName("GL_DRAW_BUFFER13_NV")]
    DrawBuffer13NV = unchecked((uint)0x8832),

    [NativeName("GL_DRAW_BUFFER14_NV")]
    DrawBuffer14NV = unchecked((uint)0x8833),

    [NativeName("GL_DRAW_BUFFER15_NV")]
    DrawBuffer15NV = unchecked((uint)0x8834),

    [NativeName("GL_COLOR_ATTACHMENT0_NV")]
    ColorAttachment0NV = unchecked((uint)0x8CE0),

    [NativeName("GL_COLOR_ATTACHMENT1_NV")]
    ColorAttachment1NV = unchecked((uint)0x8CE1),

    [NativeName("GL_COLOR_ATTACHMENT2_NV")]
    ColorAttachment2NV = unchecked((uint)0x8CE2),

    [NativeName("GL_COLOR_ATTACHMENT3_NV")]
    ColorAttachment3NV = unchecked((uint)0x8CE3),

    [NativeName("GL_COLOR_ATTACHMENT4_NV")]
    ColorAttachment4NV = unchecked((uint)0x8CE4),

    [NativeName("GL_COLOR_ATTACHMENT5_NV")]
    ColorAttachment5NV = unchecked((uint)0x8CE5),

    [NativeName("GL_COLOR_ATTACHMENT6_NV")]
    ColorAttachment6NV = unchecked((uint)0x8CE6),

    [NativeName("GL_COLOR_ATTACHMENT7_NV")]
    ColorAttachment7NV = unchecked((uint)0x8CE7),

    [NativeName("GL_COLOR_ATTACHMENT8_NV")]
    ColorAttachment8NV = unchecked((uint)0x8CE8),

    [NativeName("GL_COLOR_ATTACHMENT9_NV")]
    ColorAttachment9NV = unchecked((uint)0x8CE9),

    [NativeName("GL_COLOR_ATTACHMENT10_NV")]
    ColorAttachment10NV = unchecked((uint)0x8CEA),

    [NativeName("GL_COLOR_ATTACHMENT11_NV")]
    ColorAttachment11NV = unchecked((uint)0x8CEB),

    [NativeName("GL_COLOR_ATTACHMENT12_NV")]
    ColorAttachment12NV = unchecked((uint)0x8CEC),

    [NativeName("GL_COLOR_ATTACHMENT13_NV")]
    ColorAttachment13NV = unchecked((uint)0x8CED),

    [NativeName("GL_COLOR_ATTACHMENT14_NV")]
    ColorAttachment14NV = unchecked((uint)0x8CEE),

    [NativeName("GL_COLOR_ATTACHMENT15_NV")]
    ColorAttachment15NV = unchecked((uint)0x8CEF),

    [NativeName("GL_MAX_COLOR_ATTACHMENTS_NV")]
    MaxColorAttachmentsNV = unchecked((uint)0x8CDF),

    [NativeName("GL_READ_FRAMEBUFFER_NV")]
    ReadFramebufferNV = unchecked((uint)0x8CA8),

    [NativeName("GL_DRAW_FRAMEBUFFER_NV")]
    DrawFramebufferNV = unchecked((uint)0x8CA9),

    [NativeName("GL_DRAW_FRAMEBUFFER_BINDING_NV")]
    DrawFramebufferBindingNV = unchecked((uint)0x8CA6),

    [NativeName("GL_READ_FRAMEBUFFER_BINDING_NV")]
    ReadFramebufferBindingNV = unchecked((uint)0x8CAA),

    [NativeName("GL_RENDERBUFFER_SAMPLES_NV")]
    RenderbufferSamplesNV = unchecked((uint)0x8CAB),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_NV")]
    FramebufferIncompleteMultisampleNV = unchecked((uint)0x8D56),

    [NativeName("GL_MAX_SAMPLES_NV")]
    MaxSamplesNV = unchecked((uint)0x8D57),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_DIVISOR_NV")]
    VertexAttribArrayDivisorNV = unchecked((uint)0x88FE),

    [NativeName("GL_FLOAT_MAT2x3_NV")]
    FloatMat2X3NV = unchecked((uint)0x8B65),

    [NativeName("GL_FLOAT_MAT2x4_NV")]
    FloatMat2X4NV = unchecked((uint)0x8B66),

    [NativeName("GL_FLOAT_MAT3x2_NV")]
    FloatMat3X2NV = unchecked((uint)0x8B67),

    [NativeName("GL_FLOAT_MAT3x4_NV")]
    FloatMat3X4NV = unchecked((uint)0x8B68),

    [NativeName("GL_FLOAT_MAT4x2_NV")]
    FloatMat4X2NV = unchecked((uint)0x8B69),

    [NativeName("GL_FLOAT_MAT4x3_NV")]
    FloatMat4X3NV = unchecked((uint)0x8B6A),

    [NativeName("GL_PACK_ROW_LENGTH_NV")]
    PackRowLengthNV = unchecked((uint)0x0D02),

    [NativeName("GL_PACK_SKIP_ROWS_NV")]
    PackSkipRowsNV = unchecked((uint)0x0D03),

    [NativeName("GL_PACK_SKIP_PIXELS_NV")]
    PackSkipPixelsNV = unchecked((uint)0x0D04),

    [NativeName("GL_PIXEL_PACK_BUFFER_NV")]
    PixelPackBufferNV = unchecked((uint)0x88EB),

    [NativeName("GL_PIXEL_UNPACK_BUFFER_NV")]
    PixelUnpackBufferNV = unchecked((uint)0x88EC),

    [NativeName("GL_PIXEL_PACK_BUFFER_BINDING_NV")]
    PixelPackBufferBindingNV = unchecked((uint)0x88ED),

    [NativeName("GL_PIXEL_UNPACK_BUFFER_BINDING_NV")]
    PixelUnpackBufferBindingNV = unchecked((uint)0x88EF),

    [NativeName("GL_POLYGON_MODE_NV")]
    PolygonModeNV = unchecked((uint)0x0B40),

    [NativeName("GL_POLYGON_OFFSET_POINT_NV")]
    PolygonOffsetPointNV = unchecked((uint)0x2A01),

    [NativeName("GL_POLYGON_OFFSET_LINE_NV")]
    PolygonOffsetLineNV = unchecked((uint)0x2A02),

    [NativeName("GL_POINT_NV")]
    PointNV = unchecked((uint)0x1B00),

    [NativeName("GL_LINE_NV")]
    LineNV = unchecked((uint)0x1B01),

    [NativeName("GL_FILL_NV")]
    FillNV = unchecked((uint)0x1B02),

    [NativeName("GL_READ_BUFFER_NV")]
    ReadBufferNV = unchecked((uint)0x0C02),

    [NativeName("GL_SLUMINANCE_NV")]
    SluminanceNV = unchecked((uint)0x8C46),

    [NativeName("GL_SLUMINANCE_ALPHA_NV")]
    SluminanceAlphaNV = unchecked((uint)0x8C44),

    [NativeName("GL_SRGB8_NV")]
    Srgb8NV = unchecked((uint)0x8C41),

    [NativeName("GL_SLUMINANCE8_NV")]
    Sluminance8NV = unchecked((uint)0x8C47),

    [NativeName("GL_SLUMINANCE8_ALPHA8_NV")]
    Sluminance8Alpha8NV = unchecked((uint)0x8C45),

    [NativeName("GL_COMPRESSED_SRGB_S3TC_DXT1_NV")]
    CompressedSrgbS3TcDxt1NV = unchecked((uint)0x8C4C),

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_NV")]
    CompressedSrgbAlphaS3TcDxt1NV = unchecked((uint)0x8C4D),

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_NV")]
    CompressedSrgbAlphaS3TcDxt3NV = unchecked((uint)0x8C4E),

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_NV")]
    CompressedSrgbAlphaS3TcDxt5NV = unchecked((uint)0x8C4F),

    [NativeName("GL_ETC1_SRGB8_NV")]
    Etc1Srgb8NV = unchecked((uint)0x88EE),

    [NativeName("GL_SAMPLER_2D_ARRAY_SHADOW_NV")]
    Sampler2DArrayShadowNV = unchecked((uint)0x8DC4),

    [NativeName("GL_SAMPLER_CUBE_SHADOW_NV")]
    SamplerCubeShadowNV = unchecked((uint)0x8DC5),

    [NativeName("GL_TEXTURE_BORDER_COLOR_NV")]
    TextureBorderColorNV = unchecked((uint)0x1004),

    [NativeName("GL_CLAMP_TO_BORDER_NV")]
    ClampToBorderNV = unchecked((uint)0x812D),

    [NativeName("GL_MAX_VIEWPORTS_NV")]
    MaxViewportsNV = unchecked((uint)0x825B),

    [NativeName("GL_VIEWPORT_SUBPIXEL_BITS_NV")]
    ViewportSubpixelBitsNV = unchecked((uint)0x825C),

    [NativeName("GL_VIEWPORT_BOUNDS_RANGE_NV")]
    ViewportBoundsRangeNV = unchecked((uint)0x825D),

    [NativeName("GL_VIEWPORT_INDEX_PROVOKING_VERTEX_NV")]
    ViewportIndexProvokingVertexNV = unchecked((uint)0x825F),

    [NativeName("GL_ALPHA_TEST_QCOM")]
    AlphaTestQCOM = unchecked((uint)0x0BC0),

    [NativeName("GL_ALPHA_TEST_FUNC_QCOM")]
    AlphaTestFuncQCOM = unchecked((uint)0x0BC1),

    [NativeName("GL_ALPHA_TEST_REF_QCOM")]
    AlphaTestRefQCOM = unchecked((uint)0x0BC2),

    [NativeName("GL_BINNING_CONTROL_HINT_QCOM")]
    BinningControlHintQCOM = unchecked((uint)0x8FB0),

    [NativeName("GL_CPU_OPTIMIZED_QCOM")]
    CpuOptimizedQCOM = unchecked((uint)0x8FB1),

    [NativeName("GL_GPU_OPTIMIZED_QCOM")]
    GpuOptimizedQCOM = unchecked((uint)0x8FB2),

    [NativeName("GL_RENDER_DIRECT_TO_FRAMEBUFFER_QCOM")]
    RenderDirectToFramebufferQCOM = unchecked((uint)0x8FB3),

    [NativeName("GL_FOVEATION_ENABLE_BIT_QCOM")]
    FoveationEnableBitQCOM = unchecked((uint)0x00000001),

    [NativeName("GL_FOVEATION_SCALED_BIN_METHOD_BIT_QCOM")]
    FoveationScaledBinMethodBitQCOM = unchecked((uint)0x00000002),

    [NativeName("GL_MOTION_ESTIMATION_SEARCH_BLOCK_X_QCOM")]
    MotionEstimationSearchBlockXQCOM = unchecked((uint)0x8C90),

    [NativeName("GL_MOTION_ESTIMATION_SEARCH_BLOCK_Y_QCOM")]
    MotionEstimationSearchBlockYQCOM = unchecked((uint)0x8C91),

    [NativeName("GL_FRAMEBUFFER_FETCH_NONCOHERENT_QCOM")]
    FramebufferFetchNoncoherentQCOM = unchecked((uint)0x96A2),

    [NativeName("GL_SHADING_RATE_QCOM")]
    ShadingRateQCOM = unchecked((uint)0x96A4),

    [NativeName("GL_SHADING_RATE_PRESERVE_ASPECT_RATIO_QCOM")]
    ShadingRatePreserveAspectRatioQCOM = unchecked((uint)0x96A5),

    [NativeName("GL_SHADING_RATE_1X1_PIXELS_QCOM")]
    ShadingRate1X1PixelsQCOM = unchecked((uint)0x96A6),

    [NativeName("GL_SHADING_RATE_1X2_PIXELS_QCOM")]
    ShadingRate1X2PixelsQCOM = unchecked((uint)0x96A7),

    [NativeName("GL_SHADING_RATE_2X1_PIXELS_QCOM")]
    ShadingRate2X1PixelsQCOM = unchecked((uint)0x96A8),

    [NativeName("GL_SHADING_RATE_2X2_PIXELS_QCOM")]
    ShadingRate2X2PixelsQCOM = unchecked((uint)0x96A9),

    [NativeName("GL_SHADING_RATE_4X2_PIXELS_QCOM")]
    ShadingRate4X2PixelsQCOM = unchecked((uint)0x96AC),

    [NativeName("GL_SHADING_RATE_4X4_PIXELS_QCOM")]
    ShadingRate4X4PixelsQCOM = unchecked((uint)0x96AE),

    [NativeName("GL_TEXTURE_FOVEATED_FEATURE_BITS_QCOM")]
    TextureFoveatedFeatureBitsQCOM = unchecked((uint)0x8BFB),

    [NativeName("GL_TEXTURE_FOVEATED_MIN_PIXEL_DENSITY_QCOM")]
    TextureFoveatedMinPixelDensityQCOM = unchecked((uint)0x8BFC),

    [NativeName("GL_TEXTURE_FOVEATED_FEATURE_QUERY_QCOM")]
    TextureFoveatedFeatureQueryQCOM = unchecked((uint)0x8BFD),

    [NativeName("GL_TEXTURE_FOVEATED_NUM_FOCAL_POINTS_QUERY_QCOM")]
    TextureFoveatedNumFocalPointsQueryQCOM = unchecked((uint)0x8BFE),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_FOVEATION_QCOM")]
    FramebufferIncompleteFoveationQCOM = unchecked((uint)0x8BFF),

    [NativeName("GL_TEXTURE_FOVEATED_CUTOFF_DENSITY_QCOM")]
    TextureFoveatedCutoffDensityQCOM = unchecked((uint)0x96A0),

    [NativeName("GL_FOVEATION_SUBSAMPLED_LAYOUT_METHOD_BIT_QCOM")]
    FoveationSubsampledLayoutMethodBitQCOM = unchecked((uint)0x00000004),

    [NativeName("GL_MAX_SHADER_SUBSAMPLED_IMAGE_UNITS_QCOM")]
    MaxShaderSubsampledImageUnitsQCOM = unchecked((uint)0x8FA1),

    [NativeName("GL_TEXTURE_LOD_BIAS_QCOM")]
    TextureLodBiasQCOM = unchecked((uint)0x8C96),

    [NativeName("GL_SHADER_BINARY_VIV")]
    ShaderBinaryVIV = unchecked((uint)0x8FC4),
}
