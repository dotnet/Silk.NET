// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("GLEnum")]
[Transformed]
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

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TEXTURE_ENV")]
    TextureEnv = unchecked((uint)0x2300),

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
    [NameAffix("Suffix", "_T", -1)]
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

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_EXTERNAL_OES")]
    TextureExternaloes = unchecked((uint)0x8D65),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_BINDING_EXTERNAL_OES")]
    TextureBindingExternaloes = unchecked((uint)0x8D67),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_REQUIRED_TEXTURE_IMAGE_UNITS_OES")]
    RequiredTextureImageUnitsoes = unchecked((uint)0x8D68),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_BLEND_EQUATION_RGB_OES")]
    BlendEquationRgboes = unchecked((uint)0x8009),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_BLEND_EQUATION_ALPHA_OES")]
    BlendEquationAlphaoes = unchecked((uint)0x883D),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_BLEND_DST_RGB_OES")]
    BlendDstRgboes = unchecked((uint)0x80C8),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_BLEND_SRC_RGB_OES")]
    BlendSrcRgboes = unchecked((uint)0x80C9),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_BLEND_DST_ALPHA_OES")]
    BlendDstAlphaoes = unchecked((uint)0x80CA),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_BLEND_SRC_ALPHA_OES")]
    BlendSrcAlphaoes = unchecked((uint)0x80CB),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_BLEND_EQUATION_OES")]
    BlendEquationoes = unchecked((uint)0x8009),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_FUNC_ADD_OES")]
    FuncAddoes = unchecked((uint)0x8006),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_FUNC_SUBTRACT_OES")]
    FuncSubtractoes = unchecked((uint)0x800A),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_FUNC_REVERSE_SUBTRACT_OES")]
    FuncReverseSubtractoes = unchecked((uint)0x800B),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_ETC1_RGB8_OES")]
    Etc1Rgb8Oes = unchecked((uint)0x8D64),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_PALETTE4_RGB8_OES")]
    Palette4Rgb8Oes = unchecked((uint)0x8B90),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_PALETTE4_RGBA8_OES")]
    Palette4Rgba8Oes = unchecked((uint)0x8B91),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_PALETTE4_R5_G6_B5_OES")]
    Palette4R5G6B5Oes = unchecked((uint)0x8B92),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_PALETTE4_RGBA4_OES")]
    Palette4Rgba4Oes = unchecked((uint)0x8B93),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_PALETTE4_RGB5_A1_OES")]
    Palette4Rgb5A1Oes = unchecked((uint)0x8B94),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_PALETTE8_RGB8_OES")]
    Palette8Rgb8Oes = unchecked((uint)0x8B95),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_PALETTE8_RGBA8_OES")]
    Palette8Rgba8Oes = unchecked((uint)0x8B96),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_PALETTE8_R5_G6_B5_OES")]
    Palette8R5G6B5Oes = unchecked((uint)0x8B97),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_PALETTE8_RGBA4_OES")]
    Palette8Rgba4Oes = unchecked((uint)0x8B98),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_PALETTE8_RGB5_A1_OES")]
    Palette8Rgb5A1Oes = unchecked((uint)0x8B99),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_DEPTH_COMPONENT24_OES")]
    DepthComponent24Oes = unchecked((uint)0x81A6),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_DEPTH_COMPONENT32_OES")]
    DepthComponent32Oes = unchecked((uint)0x81A7),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_CROP_RECT_OES")]
    TextureCropRectoes = unchecked((uint)0x8B9D),

    [NativeName("GL_UNSIGNED_INT")]
    UnsignedInt = unchecked((uint)0x1405),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_FIXED_OES")]
    Fixedoes = unchecked((uint)0x140C),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_NONE_OES")]
    Noneoes = unchecked((uint)0),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_FRAMEBUFFER_OES")]
    Framebufferoes = unchecked((uint)0x8D40),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_RENDERBUFFER_OES")]
    Renderbufferoes = unchecked((uint)0x8D41),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_RGBA4_OES")]
    Rgba4Oes = unchecked((uint)0x8056),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_RGB5_A1_OES")]
    Rgb5A1Oes = unchecked((uint)0x8057),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_RGB565_OES")]
    Rgb565Oes = unchecked((uint)0x8D62),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_DEPTH_COMPONENT16_OES")]
    DepthComponent16Oes = unchecked((uint)0x81A5),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_RENDERBUFFER_WIDTH_OES")]
    RenderbufferWidthoes = unchecked((uint)0x8D42),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_RENDERBUFFER_HEIGHT_OES")]
    RenderbufferHeightoes = unchecked((uint)0x8D43),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_RENDERBUFFER_INTERNAL_FORMAT_OES")]
    RenderbufferInternalFormatoes = unchecked((uint)0x8D44),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_RENDERBUFFER_RED_SIZE_OES")]
    RenderbufferRedSizeoes = unchecked((uint)0x8D50),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_RENDERBUFFER_GREEN_SIZE_OES")]
    RenderbufferGreenSizeoes = unchecked((uint)0x8D51),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_RENDERBUFFER_BLUE_SIZE_OES")]
    RenderbufferBlueSizeoes = unchecked((uint)0x8D52),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_RENDERBUFFER_ALPHA_SIZE_OES")]
    RenderbufferAlphaSizeoes = unchecked((uint)0x8D53),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_RENDERBUFFER_DEPTH_SIZE_OES")]
    RenderbufferDepthSizeoes = unchecked((uint)0x8D54),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_RENDERBUFFER_STENCIL_SIZE_OES")]
    RenderbufferStencilSizeoes = unchecked((uint)0x8D55),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_OES")]
    FramebufferAttachmentObjectTypeoes = unchecked((uint)0x8CD0),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_OES")]
    FramebufferAttachmentObjectNameoes = unchecked((uint)0x8CD1),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_OES")]
    FramebufferAttachmentTextureLeveloes = unchecked((uint)0x8CD2),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_OES")]
    FramebufferAttachmentTextureCubeMapFaceoes = unchecked((uint)0x8CD3),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_COLOR_ATTACHMENT0_OES")]
    ColorAttachment0Oes = unchecked((uint)0x8CE0),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_DEPTH_ATTACHMENT_OES")]
    DepthAttachmentoes = unchecked((uint)0x8D00),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_STENCIL_ATTACHMENT_OES")]
    StencilAttachmentoes = unchecked((uint)0x8D20),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_FRAMEBUFFER_COMPLETE_OES")]
    FramebufferCompleteoes = unchecked((uint)0x8CD5),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_OES")]
    FramebufferIncompleteAttachmentoes = unchecked((uint)0x8CD6),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_OES")]
    FramebufferIncompleteMissingAttachmentoes = unchecked((uint)0x8CD7),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_OES")]
    FramebufferIncompleteDimensionsoes = unchecked((uint)0x8CD9),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_FORMATS_OES")]
    FramebufferIncompleteFormatsoes = unchecked((uint)0x8CDA),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_FRAMEBUFFER_UNSUPPORTED_OES")]
    FramebufferUnsupportedoes = unchecked((uint)0x8CDD),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_FRAMEBUFFER_BINDING_OES")]
    FramebufferBindingoes = unchecked((uint)0x8CA6),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_RENDERBUFFER_BINDING_OES")]
    RenderbufferBindingoes = unchecked((uint)0x8CA7),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_RENDERBUFFER_SIZE_OES")]
    MaxRenderbufferSizeoes = unchecked((uint)0x84E8),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_INVALID_FRAMEBUFFER_OPERATION_OES")]
    InvalidFramebufferOperationoes = unchecked((uint)0x0506),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_WRITE_ONLY_OES")]
    WriteOnlyoes = unchecked((uint)0x88B9),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_BUFFER_ACCESS_OES")]
    BufferAccessoes = unchecked((uint)0x88BB),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_BUFFER_MAPPED_OES")]
    BufferMappedoes = unchecked((uint)0x88BC),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_BUFFER_MAP_POINTER_OES")]
    BufferMapPointeroes = unchecked((uint)0x88BD),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MODELVIEW_MATRIX_FLOAT_AS_INT_BITS_OES")]
    ModelviewMatrixFloatAsIntBitsoes = unchecked((uint)0x898D),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_PROJECTION_MATRIX_FLOAT_AS_INT_BITS_OES")]
    ProjectionMatrixFloatAsIntBitsoes = unchecked((uint)0x898E),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_MATRIX_FLOAT_AS_INT_BITS_OES")]
    TextureMatrixFloatAsIntBitsoes = unchecked((uint)0x898F),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_VERTEX_UNITS_OES")]
    MaxVertexUnitsoes = unchecked((uint)0x86A4),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_PALETTE_MATRICES_OES")]
    MaxPaletteMatricesoes = unchecked((uint)0x8842),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MATRIX_PALETTE_OES")]
    MatrixPaletteoes = unchecked((uint)0x8840),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MATRIX_INDEX_ARRAY_OES")]
    MatrixIndexArrayoes = unchecked((uint)0x8844),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_WEIGHT_ARRAY_OES")]
    WeightArrayoes = unchecked((uint)0x86AD),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_CURRENT_PALETTE_MATRIX_OES")]
    CurrentPaletteMatrixoes = unchecked((uint)0x8843),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MATRIX_INDEX_ARRAY_SIZE_OES")]
    MatrixIndexArraySizeoes = unchecked((uint)0x8846),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MATRIX_INDEX_ARRAY_TYPE_OES")]
    MatrixIndexArrayTypeoes = unchecked((uint)0x8847),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MATRIX_INDEX_ARRAY_STRIDE_OES")]
    MatrixIndexArrayStrideoes = unchecked((uint)0x8848),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MATRIX_INDEX_ARRAY_POINTER_OES")]
    MatrixIndexArrayPointeroes = unchecked((uint)0x8849),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MATRIX_INDEX_ARRAY_BUFFER_BINDING_OES")]
    MatrixIndexArrayBufferBindingoes = unchecked((uint)0x8B9E),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_WEIGHT_ARRAY_SIZE_OES")]
    WeightArraySizeoes = unchecked((uint)0x86AB),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_WEIGHT_ARRAY_TYPE_OES")]
    WeightArrayTypeoes = unchecked((uint)0x86A9),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_WEIGHT_ARRAY_STRIDE_OES")]
    WeightArrayStrideoes = unchecked((uint)0x86AA),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_WEIGHT_ARRAY_POINTER_OES")]
    WeightArrayPointeroes = unchecked((uint)0x86AC),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_WEIGHT_ARRAY_BUFFER_BINDING_OES")]
    WeightArrayBufferBindingoes = unchecked((uint)0x889E),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_DEPTH_STENCIL_OES")]
    DepthStenciloes = unchecked((uint)0x84F9),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_UNSIGNED_INT_24_8_OES")]
    UnsignedInt24X8Oes = unchecked((uint)0x84FA),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_DEPTH24_STENCIL8_OES")]
    Depth24Stencil8Oes = unchecked((uint)0x88F0),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_POINT_SIZE_ARRAY_OES")]
    PointSizeArrayoes = unchecked((uint)0x8B9C),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_POINT_SIZE_ARRAY_TYPE_OES")]
    PointSizeArrayTypeoes = unchecked((uint)0x898A),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_POINT_SIZE_ARRAY_STRIDE_OES")]
    PointSizeArrayStrideoes = unchecked((uint)0x898B),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_POINT_SIZE_ARRAY_POINTER_OES")]
    PointSizeArrayPointeroes = unchecked((uint)0x898C),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_POINT_SIZE_ARRAY_BUFFER_BINDING_OES")]
    PointSizeArrayBufferBindingoes = unchecked((uint)0x8B9F),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_POINT_SPRITE_OES")]
    PointSpriteoes = unchecked((uint)0x8861),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_COORD_REPLACE_OES")]
    CoordReplaceoes = unchecked((uint)0x8862),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_IMPLEMENTATION_COLOR_READ_TYPE_OES")]
    ImplementationColorReadTypeoes = unchecked((uint)0x8B9A),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_IMPLEMENTATION_COLOR_READ_FORMAT_OES")]
    ImplementationColorReadFormatoes = unchecked((uint)0x8B9B),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_ALPHA8_OES")]
    Alpha8Oes = unchecked((uint)0x803C),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_LUMINANCE4_ALPHA4_OES")]
    Luminance4Alpha4Oes = unchecked((uint)0x8043),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_LUMINANCE8_ALPHA8_OES")]
    Luminance8Alpha8Oes = unchecked((uint)0x8045),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_LUMINANCE8_OES")]
    Luminance8Oes = unchecked((uint)0x8040),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_RGB8_OES")]
    Rgb8Oes = unchecked((uint)0x8051),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_RGBA8_OES")]
    Rgba8Oes = unchecked((uint)0x8058),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGB10_EXT")]
    Rgb10Ext = unchecked((uint)0x8052),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGB10_A2_EXT")]
    Rgb10A2Ext = unchecked((uint)0x8059),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_STENCIL_INDEX1_OES")]
    StencilIndex1Oes = unchecked((uint)0x8D46),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_STENCIL_INDEX4_OES")]
    StencilIndex4Oes = unchecked((uint)0x8D47),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_STENCIL_INDEX8_OES")]
    StencilIndex8Oes = unchecked((uint)0x8D48),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_INCR_WRAP_OES")]
    IncrWrapoes = unchecked((uint)0x8507),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_DECR_WRAP_OES")]
    DecrWrapoes = unchecked((uint)0x8508),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_FRAMEBUFFER_UNDEFINED_OES")]
    FramebufferUndefinedoes = unchecked((uint)0x8219),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_NORMAL_MAP_OES")]
    NormalMapoes = unchecked((uint)0x8511),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_REFLECTION_MAP_OES")]
    ReflectionMapoes = unchecked((uint)0x8512),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_OES")]
    TextureCubeMapoes = unchecked((uint)0x8513),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_BINDING_CUBE_MAP_OES")]
    TextureBindingCubeMapoes = unchecked((uint)0x8514),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_X_OES")]
    TextureCubeMapPositiveXoes = unchecked((uint)0x8515),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_X_OES")]
    TextureCubeMapNegativeXoes = unchecked((uint)0x8516),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Y_OES")]
    TextureCubeMapPositiveYoes = unchecked((uint)0x8517),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_OES")]
    TextureCubeMapNegativeYoes = unchecked((uint)0x8518),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Z_OES")]
    TextureCubeMapPositiveZoes = unchecked((uint)0x8519),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_OES")]
    TextureCubeMapNegativeZoes = unchecked((uint)0x851A),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_CUBE_MAP_TEXTURE_SIZE_OES")]
    MaxCubeMapTextureSizeoes = unchecked((uint)0x851C),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_GEN_MODE_OES")]
    TextureGenModeoes = unchecked((uint)0x2500),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_GEN_STR_OES")]
    TextureGenStroes = unchecked((uint)0x8D60),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MIRRORED_REPEAT_OES")]
    MirroredRepeatoes = unchecked((uint)0x8370),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_VERTEX_ARRAY_BINDING_OES")]
    VertexArrayBindingoes = unchecked((uint)0x85B5),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_3DC_X_AMD")]
    X3DcXamd = unchecked((uint)0x87F9),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_3DC_XY_AMD")]
    X3DcXyamd = unchecked((uint)0x87FA),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_ATC_RGB_AMD")]
    AtcRgbamd = unchecked((uint)0x8C92),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_ATC_RGBA_EXPLICIT_ALPHA_AMD")]
    AtcRgbaExplicitAlphaamd = unchecked((uint)0x8C93),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_ATC_RGBA_INTERPOLATED_ALPHA_AMD")]
    AtcRgbaInterpolatedAlphaamd = unchecked((uint)0x87EE),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_RENDERBUFFER_SAMPLES_APPLE")]
    RenderbufferSamplesapple = unchecked((uint)0x8CAB),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_APPLE")]
    FramebufferIncompleteMultisampleapple = unchecked((uint)0x8D56),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_MAX_SAMPLES_APPLE")]
    MaxSamplesapple = unchecked((uint)0x8D57),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_READ_FRAMEBUFFER_APPLE")]
    ReadFramebufferapple = unchecked((uint)0x8CA8),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_DRAW_FRAMEBUFFER_APPLE")]
    DrawFramebufferapple = unchecked((uint)0x8CA9),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_DRAW_FRAMEBUFFER_BINDING_APPLE")]
    DrawFramebufferBindingapple = unchecked((uint)0x8CA6),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_READ_FRAMEBUFFER_BINDING_APPLE")]
    ReadFramebufferBindingapple = unchecked((uint)0x8CAA),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_SYNC_OBJECT_APPLE")]
    SyncObjectapple = unchecked((uint)0x8A53),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_MAX_SERVER_WAIT_TIMEOUT_APPLE")]
    MaxServerWaitTimeoutapple = unchecked((uint)0x9111),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_OBJECT_TYPE_APPLE")]
    ObjectTypeapple = unchecked((uint)0x9112),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_SYNC_CONDITION_APPLE")]
    SyncConditionapple = unchecked((uint)0x9113),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_SYNC_STATUS_APPLE")]
    SyncStatusapple = unchecked((uint)0x9114),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_SYNC_FLAGS_APPLE")]
    SyncFlagsapple = unchecked((uint)0x9115),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_SYNC_FENCE_APPLE")]
    SyncFenceapple = unchecked((uint)0x9116),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_SYNC_GPU_COMMANDS_COMPLETE_APPLE")]
    SyncGpuCommandsCompleteapple = unchecked((uint)0x9117),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_UNSIGNALED_APPLE")]
    Unsignaledapple = unchecked((uint)0x9118),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_SIGNALED_APPLE")]
    Signaledapple = unchecked((uint)0x9119),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_ALREADY_SIGNALED_APPLE")]
    AlreadySignaledapple = unchecked((uint)0x911A),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_TIMEOUT_EXPIRED_APPLE")]
    TimeoutExpiredapple = unchecked((uint)0x911B),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_CONDITION_SATISFIED_APPLE")]
    ConditionSatisfiedapple = unchecked((uint)0x911C),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_WAIT_FAILED_APPLE")]
    WaitFailedapple = unchecked((uint)0x911D),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_SYNC_FLUSH_COMMANDS_BIT_APPLE")]
    SyncFlushCommandsBitapple = unchecked((uint)0x00000001),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_TIMEOUT_IGNORED_APPLE")]
    TimeoutIgnoredapple = unchecked((uint)0xFFFFFFFFFFFFFFFFUL),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_BGRA_EXT")]
    Bgraext = unchecked((uint)0x80E1),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_BGRA8_EXT")]
    Bgra8Ext = unchecked((uint)0x93A1),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_TEXTURE_MAX_LEVEL_APPLE")]
    TextureMaxLevelapple = unchecked((uint)0x813D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MIN_EXT")]
    Minext = unchecked((uint)0x8007),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_EXT")]
    Maxext = unchecked((uint)0x8008),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_EXT")]
    Colorext = unchecked((uint)0x1800),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DEPTH_EXT")]
    Depthext = unchecked((uint)0x1801),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_STENCIL_EXT")]
    Stencilext = unchecked((uint)0x1802),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAP_READ_BIT_EXT")]
    MapReadBitext = unchecked((uint)0x0001),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAP_WRITE_BIT_EXT")]
    MapWriteBitext = unchecked((uint)0x0002),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAP_INVALIDATE_RANGE_BIT_EXT")]
    MapInvalidateRangeBitext = unchecked((uint)0x0004),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAP_INVALIDATE_BUFFER_BIT_EXT")]
    MapInvalidateBufferBitext = unchecked((uint)0x0008),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAP_FLUSH_EXPLICIT_BIT_EXT")]
    MapFlushExplicitBitext = unchecked((uint)0x0010),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAP_UNSYNCHRONIZED_BIT_EXT")]
    MapUnsynchronizedBitext = unchecked((uint)0x0020),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SAMPLES_EXT")]
    FramebufferAttachmentTextureSamplesext = unchecked((uint)0x8D6C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RENDERBUFFER_SAMPLES_EXT")]
    RenderbufferSamplesext = unchecked((uint)0x8CAB),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_EXT")]
    FramebufferIncompleteMultisampleext = unchecked((uint)0x8D56),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_SAMPLES_EXT")]
    MaxSamplesext = unchecked((uint)0x8D57),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_SHORT_4_4_4_4_REV_EXT")]
    UnsignedShort4X4X4X4Revext = unchecked((uint)0x8365),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_SHORT_1_5_5_5_REV_EXT")]
    UnsignedShort1X5X5X5Revext = unchecked((uint)0x8366),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_GUILTY_CONTEXT_RESET_EXT")]
    GuiltyContextResetext = unchecked((uint)0x8253),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INNOCENT_CONTEXT_RESET_EXT")]
    InnocentContextResetext = unchecked((uint)0x8254),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNKNOWN_CONTEXT_RESET_EXT")]
    UnknownContextResetext = unchecked((uint)0x8255),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CONTEXT_ROBUST_ACCESS_EXT")]
    ContextRobustAccessext = unchecked((uint)0x90F3),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RESET_NOTIFICATION_STRATEGY_EXT")]
    ResetNotificationStrategyext = unchecked((uint)0x8256),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LOSE_CONTEXT_ON_RESET_EXT")]
    LoseContextOnResetext = unchecked((uint)0x8252),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_NO_RESET_NOTIFICATION_EXT")]
    NoResetNotificationext = unchecked((uint)0x8261),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SRGB_EXT")]
    Srgbext = unchecked((uint)0x8C40),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SRGB_ALPHA_EXT")]
    SrgbAlphaext = unchecked((uint)0x8C42),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SRGB8_ALPHA8_EXT")]
    Srgb8Alpha8Ext = unchecked((uint)0x8C43),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING_EXT")]
    FramebufferAttachmentColorEncodingext = unchecked((uint)0x8210),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMPRESSED_RGB_S3TC_DXT1_EXT")]
    CompressedRgbS3TcDxt1Ext = unchecked((uint)0x83F0),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMPRESSED_RGBA_S3TC_DXT1_EXT")]
    CompressedRgbaS3TcDxt1Ext = unchecked((uint)0x83F1),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_MAX_ANISOTROPY_EXT")]
    TextureMaxAnisotropyext = unchecked((uint)0x84FE),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_TEXTURE_MAX_ANISOTROPY_EXT")]
    MaxTextureMaxAnisotropyext = unchecked((uint)0x84FF),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_TEXTURE_LOD_BIAS_EXT")]
    MaxTextureLodBiasext = unchecked((uint)0x84FD),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_FILTER_CONTROL_EXT")]
    TextureFilterControlext = unchecked((uint)0x8500),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_LOD_BIAS_EXT")]
    TextureLodBiasext = unchecked((uint)0x8501),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_IMMUTABLE_FORMAT_EXT")]
    TextureImmutableFormatext = unchecked((uint)0x912F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ALPHA8_EXT")]
    Alpha8Ext = unchecked((uint)0x803C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LUMINANCE8_EXT")]
    Luminance8Ext = unchecked((uint)0x8040),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LUMINANCE8_ALPHA8_EXT")]
    Luminance8Alpha8Ext = unchecked((uint)0x8045),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGBA32F_EXT")]
    Rgba32Fext = unchecked((uint)0x8814),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGB32F_EXT")]
    Rgb32Fext = unchecked((uint)0x8815),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ALPHA32F_EXT")]
    Alpha32Fext = unchecked((uint)0x8816),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LUMINANCE32F_EXT")]
    Luminance32Fext = unchecked((uint)0x8818),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LUMINANCE_ALPHA32F_EXT")]
    LuminanceAlpha32Fext = unchecked((uint)0x8819),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGBA16F_EXT")]
    Rgba16Fext = unchecked((uint)0x881A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGB16F_EXT")]
    Rgb16Fext = unchecked((uint)0x881B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ALPHA16F_EXT")]
    Alpha16Fext = unchecked((uint)0x881C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LUMINANCE16F_EXT")]
    Luminance16Fext = unchecked((uint)0x881E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LUMINANCE_ALPHA16F_EXT")]
    LuminanceAlpha16Fext = unchecked((uint)0x881F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_R8_EXT")]
    R8Ext = unchecked((uint)0x8229),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RG8_EXT")]
    Rg8Ext = unchecked((uint)0x822B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_R32F_EXT")]
    R32Fext = unchecked((uint)0x822E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RG32F_EXT")]
    Rg32Fext = unchecked((uint)0x8230),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_R16F_EXT")]
    R16Fext = unchecked((uint)0x822D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RG16F_EXT")]
    Rg16Fext = unchecked((uint)0x822F),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_RENDERBUFFER_SAMPLES_IMG")]
    RenderbufferSamplesimg = unchecked((uint)0x9133),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_IMG")]
    FramebufferIncompleteMultisampleimg = unchecked((uint)0x9134),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_MAX_SAMPLES_IMG")]
    MaxSamplesimg = unchecked((uint)0x9135),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_TEXTURE_SAMPLES_IMG")]
    TextureSamplesimg = unchecked((uint)0x9136),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_BGRA_IMG")]
    Bgraimg = unchecked((uint)0x80E1),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_UNSIGNED_SHORT_4_4_4_4_REV_IMG")]
    UnsignedShort4X4X4X4Revimg = unchecked((uint)0x8365),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_COMPRESSED_RGB_PVRTC_4BPPV1_IMG")]
    CompressedRgbPvrtc4Bppv1Img = unchecked((uint)0x8C00),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_COMPRESSED_RGB_PVRTC_2BPPV1_IMG")]
    CompressedRgbPvrtc2Bppv1Img = unchecked((uint)0x8C01),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_COMPRESSED_RGBA_PVRTC_4BPPV1_IMG")]
    CompressedRgbaPvrtc4Bppv1Img = unchecked((uint)0x8C02),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_COMPRESSED_RGBA_PVRTC_2BPPV1_IMG")]
    CompressedRgbaPvrtc2Bppv1Img = unchecked((uint)0x8C03),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_MODULATE_COLOR_IMG")]
    ModulateColorimg = unchecked((uint)0x8C04),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_RECIP_ADD_SIGNED_ALPHA_IMG")]
    RecipAddSignedAlphaimg = unchecked((uint)0x8C05),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_TEXTURE_ALPHA_MODULATE_IMG")]
    TextureAlphaModulateimg = unchecked((uint)0x8C06),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_FACTOR_ALPHA_MODULATE_IMG")]
    FactorAlphaModulateimg = unchecked((uint)0x8C07),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_FRAGMENT_ALPHA_MODULATE_IMG")]
    FragmentAlphaModulateimg = unchecked((uint)0x8C08),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_ADD_BLEND_IMG")]
    AddBlendimg = unchecked((uint)0x8C09),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_DOT3_RGBA_IMG")]
    Dot3Rgbaimg = unchecked((uint)0x86AF),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_CLIP_PLANE0_IMG")]
    ClipPlane0Img = unchecked((uint)0x3000),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_CLIP_PLANE1_IMG")]
    ClipPlane1Img = unchecked((uint)0x3001),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_CLIP_PLANE2_IMG")]
    ClipPlane2Img = unchecked((uint)0x3002),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_CLIP_PLANE3_IMG")]
    ClipPlane3Img = unchecked((uint)0x3003),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_CLIP_PLANE4_IMG")]
    ClipPlane4Img = unchecked((uint)0x3004),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_CLIP_PLANE5_IMG")]
    ClipPlane5Img = unchecked((uint)0x3005),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_MAX_CLIP_PLANES_IMG")]
    MaxClipPlanesimg = unchecked((uint)0x0D32),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ALL_COMPLETED_NV")]
    AllCompletednv = unchecked((uint)0x84F2),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FENCE_STATUS_NV")]
    FenceStatusnv = unchecked((uint)0x84F3),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FENCE_CONDITION_NV")]
    FenceConditionnv = unchecked((uint)0x84F4),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_TEXTURE_WIDTH_QCOM")]
    TextureWidthqcom = unchecked((uint)0x8BD2),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_TEXTURE_HEIGHT_QCOM")]
    TextureHeightqcom = unchecked((uint)0x8BD3),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_TEXTURE_DEPTH_QCOM")]
    TextureDepthqcom = unchecked((uint)0x8BD4),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_TEXTURE_INTERNAL_FORMAT_QCOM")]
    TextureInternalFormatqcom = unchecked((uint)0x8BD5),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_TEXTURE_FORMAT_QCOM")]
    TextureFormatqcom = unchecked((uint)0x8BD6),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_TEXTURE_TYPE_QCOM")]
    TextureTypeqcom = unchecked((uint)0x8BD7),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_TEXTURE_IMAGE_VALID_QCOM")]
    TextureImageValidqcom = unchecked((uint)0x8BD8),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_TEXTURE_NUM_LEVELS_QCOM")]
    TextureNumLevelsqcom = unchecked((uint)0x8BD9),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_TEXTURE_TARGET_QCOM")]
    TextureTargetqcom = unchecked((uint)0x8BDA),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_TEXTURE_OBJECT_VALID_QCOM")]
    TextureObjectValidqcom = unchecked((uint)0x8BDB),

    [NativeName("GL_STATE_RESTORE")]
    StateRestore = unchecked((uint)0x8BDC),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_PERFMON_GLOBAL_MODE_QCOM")]
    PerfmonGlobalModeqcom = unchecked((uint)0x8FA0),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_COLOR_BUFFER_BIT0_QCOM")]
    ColorBufferBit0Qcom = unchecked((uint)0x00000001),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_COLOR_BUFFER_BIT1_QCOM")]
    ColorBufferBit1Qcom = unchecked((uint)0x00000002),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_COLOR_BUFFER_BIT2_QCOM")]
    ColorBufferBit2Qcom = unchecked((uint)0x00000004),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_COLOR_BUFFER_BIT3_QCOM")]
    ColorBufferBit3Qcom = unchecked((uint)0x00000008),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_COLOR_BUFFER_BIT4_QCOM")]
    ColorBufferBit4Qcom = unchecked((uint)0x00000010),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_COLOR_BUFFER_BIT5_QCOM")]
    ColorBufferBit5Qcom = unchecked((uint)0x00000020),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_COLOR_BUFFER_BIT6_QCOM")]
    ColorBufferBit6Qcom = unchecked((uint)0x00000040),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_COLOR_BUFFER_BIT7_QCOM")]
    ColorBufferBit7Qcom = unchecked((uint)0x00000080),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_DEPTH_BUFFER_BIT0_QCOM")]
    DepthBufferBit0Qcom = unchecked((uint)0x00000100),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_DEPTH_BUFFER_BIT1_QCOM")]
    DepthBufferBit1Qcom = unchecked((uint)0x00000200),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_DEPTH_BUFFER_BIT2_QCOM")]
    DepthBufferBit2Qcom = unchecked((uint)0x00000400),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_DEPTH_BUFFER_BIT3_QCOM")]
    DepthBufferBit3Qcom = unchecked((uint)0x00000800),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_DEPTH_BUFFER_BIT4_QCOM")]
    DepthBufferBit4Qcom = unchecked((uint)0x00001000),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_DEPTH_BUFFER_BIT5_QCOM")]
    DepthBufferBit5Qcom = unchecked((uint)0x00002000),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_DEPTH_BUFFER_BIT6_QCOM")]
    DepthBufferBit6Qcom = unchecked((uint)0x00004000),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_DEPTH_BUFFER_BIT7_QCOM")]
    DepthBufferBit7Qcom = unchecked((uint)0x00008000),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_STENCIL_BUFFER_BIT0_QCOM")]
    StencilBufferBit0Qcom = unchecked((uint)0x00010000),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_STENCIL_BUFFER_BIT1_QCOM")]
    StencilBufferBit1Qcom = unchecked((uint)0x00020000),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_STENCIL_BUFFER_BIT2_QCOM")]
    StencilBufferBit2Qcom = unchecked((uint)0x00040000),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_STENCIL_BUFFER_BIT3_QCOM")]
    StencilBufferBit3Qcom = unchecked((uint)0x00080000),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_STENCIL_BUFFER_BIT4_QCOM")]
    StencilBufferBit4Qcom = unchecked((uint)0x00100000),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_STENCIL_BUFFER_BIT5_QCOM")]
    StencilBufferBit5Qcom = unchecked((uint)0x00200000),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_STENCIL_BUFFER_BIT6_QCOM")]
    StencilBufferBit6Qcom = unchecked((uint)0x00400000),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_STENCIL_BUFFER_BIT7_QCOM")]
    StencilBufferBit7Qcom = unchecked((uint)0x00800000),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_MULTISAMPLE_BUFFER_BIT0_QCOM")]
    MultisampleBufferBit0Qcom = unchecked((uint)0x01000000),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_MULTISAMPLE_BUFFER_BIT1_QCOM")]
    MultisampleBufferBit1Qcom = unchecked((uint)0x02000000),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_MULTISAMPLE_BUFFER_BIT2_QCOM")]
    MultisampleBufferBit2Qcom = unchecked((uint)0x04000000),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_MULTISAMPLE_BUFFER_BIT3_QCOM")]
    MultisampleBufferBit3Qcom = unchecked((uint)0x08000000),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_MULTISAMPLE_BUFFER_BIT4_QCOM")]
    MultisampleBufferBit4Qcom = unchecked((uint)0x10000000),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_MULTISAMPLE_BUFFER_BIT5_QCOM")]
    MultisampleBufferBit5Qcom = unchecked((uint)0x20000000),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_MULTISAMPLE_BUFFER_BIT6_QCOM")]
    MultisampleBufferBit6Qcom = unchecked((uint)0x40000000),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_MULTISAMPLE_BUFFER_BIT7_QCOM")]
    MultisampleBufferBit7Qcom = unchecked((uint)0x80000000),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_WRITEONLY_RENDERING_QCOM")]
    WriteonlyRenderingqcom = unchecked((uint)0x8823),

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
    [NameAffix("Suffix", "_T", -1)]
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
    [NameAffix("Suffix", "_T", -1)]
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

    [NameAffix("Suffix", "ANGLE", 0)]
    [NativeName("GL_TEXTURE_RECTANGLE")]
    TextureRectangle = unchecked((uint)0x84F5),

    [NameAffix("Suffix", "ANGLE", 0)]
    [NativeName("GL_TEXTURE_BINDING_RECTANGLE")]
    TextureBindingRectangle = unchecked((uint)0x84F6),

    [NameAffix("Suffix", "ANGLE", 0)]
    [NativeName("GL_PROXY_TEXTURE_RECTANGLE")]
    ProxyTextureRectangle = unchecked((uint)0x84F7),

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

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PRIMITIVE_BOUNDING_BOX_ARB")]
    PrimitiveBoundingBoxarb = unchecked((uint)0x92BE),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MULTISAMPLE_LINE_WIDTH_RANGE_ARB")]
    MultisampleLineWidthRangearb = unchecked((uint)0x9381),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MULTISAMPLE_LINE_WIDTH_GRANULARITY_ARB")]
    MultisampleLineWidthGranularityarb = unchecked((uint)0x9382),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_UNSIGNED_INT64_ARB")]
    UnsignedInt64Arb = unchecked((uint)0x140F),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SYNC_CL_EVENT_ARB")]
    SyncClEventarb = unchecked((uint)0x8240),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SYNC_CL_EVENT_COMPLETE_ARB")]
    SyncClEventCompletearb = unchecked((uint)0x8241),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_RGBA_FLOAT_MODE_ARB")]
    RgbaFloatModearb = unchecked((uint)0x8820),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_CLAMP_VERTEX_COLOR_ARB")]
    ClampVertexColorarb = unchecked((uint)0x891A),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_CLAMP_FRAGMENT_COLOR_ARB")]
    ClampFragmentColorarb = unchecked((uint)0x891B),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_CLAMP_READ_COLOR_ARB")]
    ClampReadColorarb = unchecked((uint)0x891C),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_FIXED_ONLY_ARB")]
    FixedOnlyarb = unchecked((uint)0x891D),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_COMPUTE_VARIABLE_GROUP_INVOCATIONS_ARB")]
    MaxComputeVariableGroupInvocationsarb = unchecked((uint)0x9344),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_COMPUTE_FIXED_GROUP_INVOCATIONS_ARB")]
    MaxComputeFixedGroupInvocationsarb = unchecked((uint)0x90EB),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_COMPUTE_VARIABLE_GROUP_SIZE_ARB")]
    MaxComputeVariableGroupSizearb = unchecked((uint)0x9345),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_COMPUTE_FIXED_GROUP_SIZE_ARB")]
    MaxComputeFixedGroupSizearb = unchecked((uint)0x91BF),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DEBUG_OUTPUT_SYNCHRONOUS_ARB")]
    DebugOutputSynchronousarb = unchecked((uint)0x8242),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_ARB")]
    DebugNextLoggedMessageLengtharb = unchecked((uint)0x8243),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DEBUG_CALLBACK_FUNCTION_ARB")]
    DebugCallbackFunctionarb = unchecked((uint)0x8244),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DEBUG_CALLBACK_USER_PARAM_ARB")]
    DebugCallbackUserParamarb = unchecked((uint)0x8245),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DEBUG_SOURCE_API_ARB")]
    DebugSourceApiarb = unchecked((uint)0x8246),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DEBUG_SOURCE_WINDOW_SYSTEM_ARB")]
    DebugSourceWindowSystemarb = unchecked((uint)0x8247),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DEBUG_SOURCE_SHADER_COMPILER_ARB")]
    DebugSourceShaderCompilerarb = unchecked((uint)0x8248),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DEBUG_SOURCE_THIRD_PARTY_ARB")]
    DebugSourceThirdPartyarb = unchecked((uint)0x8249),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DEBUG_SOURCE_APPLICATION_ARB")]
    DebugSourceApplicationarb = unchecked((uint)0x824A),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DEBUG_SOURCE_OTHER_ARB")]
    DebugSourceOtherarb = unchecked((uint)0x824B),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DEBUG_TYPE_ERROR_ARB")]
    DebugTypeErrorarb = unchecked((uint)0x824C),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_ARB")]
    DebugTypeDeprecatedBehaviorarb = unchecked((uint)0x824D),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_ARB")]
    DebugTypeUndefinedBehaviorarb = unchecked((uint)0x824E),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DEBUG_TYPE_PORTABILITY_ARB")]
    DebugTypePortabilityarb = unchecked((uint)0x824F),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DEBUG_TYPE_PERFORMANCE_ARB")]
    DebugTypePerformancearb = unchecked((uint)0x8250),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DEBUG_TYPE_OTHER_ARB")]
    DebugTypeOtherarb = unchecked((uint)0x8251),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_DEBUG_MESSAGE_LENGTH_ARB")]
    MaxDebugMessageLengtharb = unchecked((uint)0x9143),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_DEBUG_LOGGED_MESSAGES_ARB")]
    MaxDebugLoggedMessagesarb = unchecked((uint)0x9144),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DEBUG_LOGGED_MESSAGES_ARB")]
    DebugLoggedMessagesarb = unchecked((uint)0x9145),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DEBUG_SEVERITY_HIGH_ARB")]
    DebugSeverityHigharb = unchecked((uint)0x9146),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DEBUG_SEVERITY_MEDIUM_ARB")]
    DebugSeverityMediumarb = unchecked((uint)0x9147),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DEBUG_SEVERITY_LOW_ARB")]
    DebugSeverityLowarb = unchecked((uint)0x9148),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DEPTH_COMPONENT16_ARB")]
    DepthComponent16Arb = unchecked((uint)0x81A5),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DEPTH_COMPONENT24_ARB")]
    DepthComponent24Arb = unchecked((uint)0x81A6),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DEPTH_COMPONENT32_ARB")]
    DepthComponent32Arb = unchecked((uint)0x81A7),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_DEPTH_SIZE_ARB")]
    TextureDepthSizearb = unchecked((uint)0x884A),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DEPTH_TEXTURE_MODE_ARB")]
    DepthTextureModearb = unchecked((uint)0x884B),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_DRAW_BUFFERS_ARB")]
    MaxDrawBuffersarb = unchecked((uint)0x8824),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DRAW_BUFFER0_ARB")]
    DrawBuffer0Arb = unchecked((uint)0x8825),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DRAW_BUFFER1_ARB")]
    DrawBuffer1Arb = unchecked((uint)0x8826),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DRAW_BUFFER2_ARB")]
    DrawBuffer2Arb = unchecked((uint)0x8827),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DRAW_BUFFER3_ARB")]
    DrawBuffer3Arb = unchecked((uint)0x8828),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DRAW_BUFFER4_ARB")]
    DrawBuffer4Arb = unchecked((uint)0x8829),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DRAW_BUFFER5_ARB")]
    DrawBuffer5Arb = unchecked((uint)0x882A),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DRAW_BUFFER6_ARB")]
    DrawBuffer6Arb = unchecked((uint)0x882B),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DRAW_BUFFER7_ARB")]
    DrawBuffer7Arb = unchecked((uint)0x882C),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DRAW_BUFFER8_ARB")]
    DrawBuffer8Arb = unchecked((uint)0x882D),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DRAW_BUFFER9_ARB")]
    DrawBuffer9Arb = unchecked((uint)0x882E),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DRAW_BUFFER10_ARB")]
    DrawBuffer10Arb = unchecked((uint)0x882F),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DRAW_BUFFER11_ARB")]
    DrawBuffer11Arb = unchecked((uint)0x8830),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DRAW_BUFFER12_ARB")]
    DrawBuffer12Arb = unchecked((uint)0x8831),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DRAW_BUFFER13_ARB")]
    DrawBuffer13Arb = unchecked((uint)0x8832),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DRAW_BUFFER14_ARB")]
    DrawBuffer14Arb = unchecked((uint)0x8833),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DRAW_BUFFER15_ARB")]
    DrawBuffer15Arb = unchecked((uint)0x8834),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_FRAGMENT_PROGRAM_ARB")]
    FragmentProgramarb = unchecked((uint)0x8804),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PROGRAM_FORMAT_ASCII_ARB")]
    ProgramFormatAsciiarb = unchecked((uint)0x8875),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PROGRAM_LENGTH_ARB")]
    ProgramLengtharb = unchecked((uint)0x8627),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PROGRAM_FORMAT_ARB")]
    ProgramFormatarb = unchecked((uint)0x8876),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PROGRAM_BINDING_ARB")]
    ProgramBindingarb = unchecked((uint)0x8677),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PROGRAM_INSTRUCTIONS_ARB")]
    ProgramInstructionsarb = unchecked((uint)0x88A0),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_PROGRAM_INSTRUCTIONS_ARB")]
    MaxProgramInstructionsarb = unchecked((uint)0x88A1),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PROGRAM_NATIVE_INSTRUCTIONS_ARB")]
    ProgramNativeInstructionsarb = unchecked((uint)0x88A2),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_PROGRAM_NATIVE_INSTRUCTIONS_ARB")]
    MaxProgramNativeInstructionsarb = unchecked((uint)0x88A3),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PROGRAM_TEMPORARIES_ARB")]
    ProgramTemporariesarb = unchecked((uint)0x88A4),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_PROGRAM_TEMPORARIES_ARB")]
    MaxProgramTemporariesarb = unchecked((uint)0x88A5),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PROGRAM_NATIVE_TEMPORARIES_ARB")]
    ProgramNativeTemporariesarb = unchecked((uint)0x88A6),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_PROGRAM_NATIVE_TEMPORARIES_ARB")]
    MaxProgramNativeTemporariesarb = unchecked((uint)0x88A7),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PROGRAM_PARAMETERS_ARB")]
    ProgramParametersarb = unchecked((uint)0x88A8),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_PROGRAM_PARAMETERS_ARB")]
    MaxProgramParametersarb = unchecked((uint)0x88A9),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PROGRAM_NATIVE_PARAMETERS_ARB")]
    ProgramNativeParametersarb = unchecked((uint)0x88AA),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_PROGRAM_NATIVE_PARAMETERS_ARB")]
    MaxProgramNativeParametersarb = unchecked((uint)0x88AB),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PROGRAM_ATTRIBS_ARB")]
    ProgramAttribsarb = unchecked((uint)0x88AC),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_PROGRAM_ATTRIBS_ARB")]
    MaxProgramAttribsarb = unchecked((uint)0x88AD),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PROGRAM_NATIVE_ATTRIBS_ARB")]
    ProgramNativeAttribsarb = unchecked((uint)0x88AE),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_PROGRAM_NATIVE_ATTRIBS_ARB")]
    MaxProgramNativeAttribsarb = unchecked((uint)0x88AF),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_PROGRAM_LOCAL_PARAMETERS_ARB")]
    MaxProgramLocalParametersarb = unchecked((uint)0x88B4),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_PROGRAM_ENV_PARAMETERS_ARB")]
    MaxProgramEnvParametersarb = unchecked((uint)0x88B5),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PROGRAM_UNDER_NATIVE_LIMITS_ARB")]
    ProgramUnderNativeLimitsarb = unchecked((uint)0x88B6),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PROGRAM_ALU_INSTRUCTIONS_ARB")]
    ProgramAluInstructionsarb = unchecked((uint)0x8805),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PROGRAM_TEX_INSTRUCTIONS_ARB")]
    ProgramTexInstructionsarb = unchecked((uint)0x8806),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PROGRAM_TEX_INDIRECTIONS_ARB")]
    ProgramTexIndirectionsarb = unchecked((uint)0x8807),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB")]
    ProgramNativeAluInstructionsarb = unchecked((uint)0x8808),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB")]
    ProgramNativeTexInstructionsarb = unchecked((uint)0x8809),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB")]
    ProgramNativeTexIndirectionsarb = unchecked((uint)0x880A),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_PROGRAM_ALU_INSTRUCTIONS_ARB")]
    MaxProgramAluInstructionsarb = unchecked((uint)0x880B),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_PROGRAM_TEX_INSTRUCTIONS_ARB")]
    MaxProgramTexInstructionsarb = unchecked((uint)0x880C),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_PROGRAM_TEX_INDIRECTIONS_ARB")]
    MaxProgramTexIndirectionsarb = unchecked((uint)0x880D),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB")]
    MaxProgramNativeAluInstructionsarb = unchecked((uint)0x880E),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB")]
    MaxProgramNativeTexInstructionsarb = unchecked((uint)0x880F),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB")]
    MaxProgramNativeTexIndirectionsarb = unchecked((uint)0x8810),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PROGRAM_STRING_ARB")]
    ProgramStringarb = unchecked((uint)0x8628),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PROGRAM_ERROR_POSITION_ARB")]
    ProgramErrorPositionarb = unchecked((uint)0x864B),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_CURRENT_MATRIX_ARB")]
    CurrentMatrixarb = unchecked((uint)0x8641),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TRANSPOSE_CURRENT_MATRIX_ARB")]
    TransposeCurrentMatrixarb = unchecked((uint)0x88B7),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_CURRENT_MATRIX_STACK_DEPTH_ARB")]
    CurrentMatrixStackDeptharb = unchecked((uint)0x8640),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_PROGRAM_MATRICES_ARB")]
    MaxProgramMatricesarb = unchecked((uint)0x862F),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_PROGRAM_MATRIX_STACK_DEPTH_ARB")]
    MaxProgramMatrixStackDeptharb = unchecked((uint)0x862E),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_TEXTURE_COORDS_ARB")]
    MaxTextureCoordsarb = unchecked((uint)0x8871),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_TEXTURE_IMAGE_UNITS_ARB")]
    MaxTextureImageUnitsarb = unchecked((uint)0x8872),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PROGRAM_ERROR_STRING_ARB")]
    ProgramErrorStringarb = unchecked((uint)0x8874),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX0_ARB")]
    Matrix0Arb = unchecked((uint)0x88C0),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX1_ARB")]
    Matrix1Arb = unchecked((uint)0x88C1),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX2_ARB")]
    Matrix2Arb = unchecked((uint)0x88C2),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX3_ARB")]
    Matrix3Arb = unchecked((uint)0x88C3),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX4_ARB")]
    Matrix4Arb = unchecked((uint)0x88C4),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX5_ARB")]
    Matrix5Arb = unchecked((uint)0x88C5),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX6_ARB")]
    Matrix6Arb = unchecked((uint)0x88C6),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX7_ARB")]
    Matrix7Arb = unchecked((uint)0x88C7),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX8_ARB")]
    Matrix8Arb = unchecked((uint)0x88C8),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX9_ARB")]
    Matrix9Arb = unchecked((uint)0x88C9),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX10_ARB")]
    Matrix10Arb = unchecked((uint)0x88CA),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX11_ARB")]
    Matrix11Arb = unchecked((uint)0x88CB),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX12_ARB")]
    Matrix12Arb = unchecked((uint)0x88CC),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX13_ARB")]
    Matrix13Arb = unchecked((uint)0x88CD),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX14_ARB")]
    Matrix14Arb = unchecked((uint)0x88CE),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX15_ARB")]
    Matrix15Arb = unchecked((uint)0x88CF),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX16_ARB")]
    Matrix16Arb = unchecked((uint)0x88D0),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX17_ARB")]
    Matrix17Arb = unchecked((uint)0x88D1),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX18_ARB")]
    Matrix18Arb = unchecked((uint)0x88D2),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX19_ARB")]
    Matrix19Arb = unchecked((uint)0x88D3),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX20_ARB")]
    Matrix20Arb = unchecked((uint)0x88D4),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX21_ARB")]
    Matrix21Arb = unchecked((uint)0x88D5),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX22_ARB")]
    Matrix22Arb = unchecked((uint)0x88D6),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX23_ARB")]
    Matrix23Arb = unchecked((uint)0x88D7),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX24_ARB")]
    Matrix24Arb = unchecked((uint)0x88D8),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX25_ARB")]
    Matrix25Arb = unchecked((uint)0x88D9),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX26_ARB")]
    Matrix26Arb = unchecked((uint)0x88DA),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX27_ARB")]
    Matrix27Arb = unchecked((uint)0x88DB),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX28_ARB")]
    Matrix28Arb = unchecked((uint)0x88DC),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX29_ARB")]
    Matrix29Arb = unchecked((uint)0x88DD),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX30_ARB")]
    Matrix30Arb = unchecked((uint)0x88DE),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX31_ARB")]
    Matrix31Arb = unchecked((uint)0x88DF),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_FRAGMENT_SHADER_ARB")]
    FragmentShaderarb = unchecked((uint)0x8B30),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_FRAGMENT_UNIFORM_COMPONENTS_ARB")]
    MaxFragmentUniformComponentsarb = unchecked((uint)0x8B49),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_FRAGMENT_SHADER_DERIVATIVE_HINT_ARB")]
    FragmentShaderDerivativeHintarb = unchecked((uint)0x8B8B),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_LINES_ADJACENCY_ARB")]
    LinesAdjacencyarb = unchecked((uint)0x000A),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_LINE_STRIP_ADJACENCY_ARB")]
    LineStripAdjacencyarb = unchecked((uint)0x000B),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TRIANGLES_ADJACENCY_ARB")]
    TrianglesAdjacencyarb = unchecked((uint)0x000C),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TRIANGLE_STRIP_ADJACENCY_ARB")]
    TriangleStripAdjacencyarb = unchecked((uint)0x000D),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PROGRAM_POINT_SIZE_ARB")]
    ProgramPointSizearb = unchecked((uint)0x8642),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_ARB")]
    MaxGeometryTextureImageUnitsarb = unchecked((uint)0x8C29),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_LAYERED_ARB")]
    FramebufferAttachmentLayeredarb = unchecked((uint)0x8DA7),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_ARB")]
    FramebufferIncompleteLayerTargetsarb = unchecked((uint)0x8DA8),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_ARB")]
    FramebufferIncompleteLayerCountarb = unchecked((uint)0x8DA9),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_GEOMETRY_SHADER_ARB")]
    GeometryShaderarb = unchecked((uint)0x8DD9),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_GEOMETRY_VERTICES_OUT_ARB")]
    GeometryVerticesOutarb = unchecked((uint)0x8DDA),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_GEOMETRY_INPUT_TYPE_ARB")]
    GeometryInputTypearb = unchecked((uint)0x8DDB),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_GEOMETRY_OUTPUT_TYPE_ARB")]
    GeometryOutputTypearb = unchecked((uint)0x8DDC),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_GEOMETRY_VARYING_COMPONENTS_ARB")]
    MaxGeometryVaryingComponentsarb = unchecked((uint)0x8DDD),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_VERTEX_VARYING_COMPONENTS_ARB")]
    MaxVertexVaryingComponentsarb = unchecked((uint)0x8DDE),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_ARB")]
    MaxGeometryUniformComponentsarb = unchecked((uint)0x8DDF),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_GEOMETRY_OUTPUT_VERTICES_ARB")]
    MaxGeometryOutputVerticesarb = unchecked((uint)0x8DE0),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_ARB")]
    MaxGeometryTotalOutputComponentsarb = unchecked((uint)0x8DE1),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SHADER_BINARY_FORMAT_SPIR_V_ARB")]
    ShaderBinaryFormatSpirVarb = unchecked((uint)0x9551),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SPIR_V_BINARY_ARB")]
    SpirVBinaryarb = unchecked((uint)0x9552),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_INT64_ARB")]
    Int64Arb = unchecked((uint)0x140E),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_INT64_VEC2_ARB")]
    Int64Vec2Arb = unchecked((uint)0x8FE9),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_INT64_VEC3_ARB")]
    Int64Vec3Arb = unchecked((uint)0x8FEA),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_INT64_VEC4_ARB")]
    Int64Vec4Arb = unchecked((uint)0x8FEB),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_UNSIGNED_INT64_VEC2_ARB")]
    UnsignedInt64Vec2Arb = unchecked((uint)0x8FF5),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_UNSIGNED_INT64_VEC3_ARB")]
    UnsignedInt64Vec3Arb = unchecked((uint)0x8FF6),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_UNSIGNED_INT64_VEC4_ARB")]
    UnsignedInt64Vec4Arb = unchecked((uint)0x8FF7),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_HALF_FLOAT_ARB")]
    HalfFloatarb = unchecked((uint)0x140B),

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

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PARAMETER_BUFFER_ARB")]
    ParameterBufferarb = unchecked((uint)0x80EE),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PARAMETER_BUFFER_BINDING_ARB")]
    ParameterBufferBindingarb = unchecked((uint)0x80EF),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_VERTEX_ATTRIB_ARRAY_DIVISOR_ARB")]
    VertexAttribArrayDivisorarb = unchecked((uint)0x88FE),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SRGB_DECODE_ARB")]
    SrgbDecodearb = unchecked((uint)0x8299),

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

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX_PALETTE_ARB")]
    MatrixPalettearb = unchecked((uint)0x8840),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_MATRIX_PALETTE_STACK_DEPTH_ARB")]
    MaxMatrixPaletteStackDeptharb = unchecked((uint)0x8841),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_PALETTE_MATRICES_ARB")]
    MaxPaletteMatricesarb = unchecked((uint)0x8842),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_CURRENT_PALETTE_MATRIX_ARB")]
    CurrentPaletteMatrixarb = unchecked((uint)0x8843),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX_INDEX_ARRAY_ARB")]
    MatrixIndexArrayarb = unchecked((uint)0x8844),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_CURRENT_MATRIX_INDEX_ARB")]
    CurrentMatrixIndexarb = unchecked((uint)0x8845),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX_INDEX_ARRAY_SIZE_ARB")]
    MatrixIndexArraySizearb = unchecked((uint)0x8846),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX_INDEX_ARRAY_TYPE_ARB")]
    MatrixIndexArrayTypearb = unchecked((uint)0x8847),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX_INDEX_ARRAY_STRIDE_ARB")]
    MatrixIndexArrayStridearb = unchecked((uint)0x8848),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MATRIX_INDEX_ARRAY_POINTER_ARB")]
    MatrixIndexArrayPointerarb = unchecked((uint)0x8849),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MULTISAMPLE_ARB")]
    Multisamplearb = unchecked((uint)0x809D),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SAMPLE_ALPHA_TO_COVERAGE_ARB")]
    SampleAlphaToCoveragearb = unchecked((uint)0x809E),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SAMPLE_ALPHA_TO_ONE_ARB")]
    SampleAlphaToOnearb = unchecked((uint)0x809F),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SAMPLE_COVERAGE_ARB")]
    SampleCoveragearb = unchecked((uint)0x80A0),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SAMPLE_BUFFERS_ARB")]
    SampleBuffersarb = unchecked((uint)0x80A8),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SAMPLES_ARB")]
    Samplesarb = unchecked((uint)0x80A9),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SAMPLE_COVERAGE_VALUE_ARB")]
    SampleCoverageValuearb = unchecked((uint)0x80AA),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SAMPLE_COVERAGE_INVERT_ARB")]
    SampleCoverageInvertarb = unchecked((uint)0x80AB),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MULTISAMPLE_BIT_ARB")]
    MultisampleBitarb = unchecked((uint)0x20000000),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE0_ARB")]
    Texture0Arb = unchecked((uint)0x84C0),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE1_ARB")]
    Texture1Arb = unchecked((uint)0x84C1),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE2_ARB")]
    Texture2Arb = unchecked((uint)0x84C2),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE3_ARB")]
    Texture3Arb = unchecked((uint)0x84C3),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE4_ARB")]
    Texture4Arb = unchecked((uint)0x84C4),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE5_ARB")]
    Texture5Arb = unchecked((uint)0x84C5),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE6_ARB")]
    Texture6Arb = unchecked((uint)0x84C6),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE7_ARB")]
    Texture7Arb = unchecked((uint)0x84C7),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE8_ARB")]
    Texture8Arb = unchecked((uint)0x84C8),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE9_ARB")]
    Texture9Arb = unchecked((uint)0x84C9),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE10_ARB")]
    Texture10Arb = unchecked((uint)0x84CA),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE11_ARB")]
    Texture11Arb = unchecked((uint)0x84CB),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE12_ARB")]
    Texture12Arb = unchecked((uint)0x84CC),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE13_ARB")]
    Texture13Arb = unchecked((uint)0x84CD),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE14_ARB")]
    Texture14Arb = unchecked((uint)0x84CE),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE15_ARB")]
    Texture15Arb = unchecked((uint)0x84CF),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE16_ARB")]
    Texture16Arb = unchecked((uint)0x84D0),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE17_ARB")]
    Texture17Arb = unchecked((uint)0x84D1),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE18_ARB")]
    Texture18Arb = unchecked((uint)0x84D2),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE19_ARB")]
    Texture19Arb = unchecked((uint)0x84D3),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE20_ARB")]
    Texture20Arb = unchecked((uint)0x84D4),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE21_ARB")]
    Texture21Arb = unchecked((uint)0x84D5),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE22_ARB")]
    Texture22Arb = unchecked((uint)0x84D6),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE23_ARB")]
    Texture23Arb = unchecked((uint)0x84D7),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE24_ARB")]
    Texture24Arb = unchecked((uint)0x84D8),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE25_ARB")]
    Texture25Arb = unchecked((uint)0x84D9),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE26_ARB")]
    Texture26Arb = unchecked((uint)0x84DA),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE27_ARB")]
    Texture27Arb = unchecked((uint)0x84DB),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE28_ARB")]
    Texture28Arb = unchecked((uint)0x84DC),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE29_ARB")]
    Texture29Arb = unchecked((uint)0x84DD),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE30_ARB")]
    Texture30Arb = unchecked((uint)0x84DE),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE31_ARB")]
    Texture31Arb = unchecked((uint)0x84DF),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_ACTIVE_TEXTURE_ARB")]
    ActiveTexturearb = unchecked((uint)0x84E0),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_CLIENT_ACTIVE_TEXTURE_ARB")]
    ClientActiveTexturearb = unchecked((uint)0x84E1),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_TEXTURE_UNITS_ARB")]
    MaxTextureUnitsarb = unchecked((uint)0x84E2),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_QUERY_COUNTER_BITS_ARB")]
    QueryCounterBitsarb = unchecked((uint)0x8864),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_CURRENT_QUERY_ARB")]
    CurrentQueryarb = unchecked((uint)0x8865),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_QUERY_RESULT_ARB")]
    QueryResultarb = unchecked((uint)0x8866),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_QUERY_RESULT_AVAILABLE_ARB")]
    QueryResultAvailablearb = unchecked((uint)0x8867),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SAMPLES_PASSED_ARB")]
    SamplesPassedarb = unchecked((uint)0x8914),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_SHADER_COMPILER_THREADS_ARB")]
    MaxShaderCompilerThreadsarb = unchecked((uint)0x91B0),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_COMPLETION_STATUS_ARB")]
    CompletionStatusarb = unchecked((uint)0x91B1),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_VERTICES_SUBMITTED_ARB")]
    VerticesSubmittedarb = unchecked((uint)0x82EE),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PRIMITIVES_SUBMITTED_ARB")]
    PrimitivesSubmittedarb = unchecked((uint)0x82EF),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_VERTEX_SHADER_INVOCATIONS_ARB")]
    VertexShaderInvocationsarb = unchecked((uint)0x82F0),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TESS_CONTROL_SHADER_PATCHES_ARB")]
    TessControlShaderPatchesarb = unchecked((uint)0x82F1),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TESS_EVALUATION_SHADER_INVOCATIONS_ARB")]
    TessEvaluationShaderInvocationsarb = unchecked((uint)0x82F2),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_GEOMETRY_SHADER_PRIMITIVES_EMITTED_ARB")]
    GeometryShaderPrimitivesEmittedarb = unchecked((uint)0x82F3),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_FRAGMENT_SHADER_INVOCATIONS_ARB")]
    FragmentShaderInvocationsarb = unchecked((uint)0x82F4),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_COMPUTE_SHADER_INVOCATIONS_ARB")]
    ComputeShaderInvocationsarb = unchecked((uint)0x82F5),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_CLIPPING_INPUT_PRIMITIVES_ARB")]
    ClippingInputPrimitivesarb = unchecked((uint)0x82F6),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_CLIPPING_OUTPUT_PRIMITIVES_ARB")]
    ClippingOutputPrimitivesarb = unchecked((uint)0x82F7),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PIXEL_PACK_BUFFER_ARB")]
    PixelPackBufferarb = unchecked((uint)0x88EB),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PIXEL_UNPACK_BUFFER_ARB")]
    PixelUnpackBufferarb = unchecked((uint)0x88EC),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PIXEL_PACK_BUFFER_BINDING_ARB")]
    PixelPackBufferBindingarb = unchecked((uint)0x88ED),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PIXEL_UNPACK_BUFFER_BINDING_ARB")]
    PixelUnpackBufferBindingarb = unchecked((uint)0x88EF),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_POINT_SIZE_MIN_ARB")]
    PointSizeMinarb = unchecked((uint)0x8126),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_POINT_SIZE_MAX_ARB")]
    PointSizeMaxarb = unchecked((uint)0x8127),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_POINT_FADE_THRESHOLD_SIZE_ARB")]
    PointFadeThresholdSizearb = unchecked((uint)0x8128),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_POINT_DISTANCE_ATTENUATION_ARB")]
    PointDistanceAttenuationarb = unchecked((uint)0x8129),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_POINT_SPRITE_ARB")]
    PointSpritearb = unchecked((uint)0x8861),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_COORD_REPLACE_ARB")]
    CoordReplacearb = unchecked((uint)0x8862),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB")]
    ContextFlagRobustAccessBitarb = unchecked((uint)0x00000004),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_LOSE_CONTEXT_ON_RESET_ARB")]
    LoseContextOnResetarb = unchecked((uint)0x8252),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_GUILTY_CONTEXT_RESET_ARB")]
    GuiltyContextResetarb = unchecked((uint)0x8253),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_INNOCENT_CONTEXT_RESET_ARB")]
    InnocentContextResetarb = unchecked((uint)0x8254),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_UNKNOWN_CONTEXT_RESET_ARB")]
    UnknownContextResetarb = unchecked((uint)0x8255),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_RESET_NOTIFICATION_STRATEGY_ARB")]
    ResetNotificationStrategyarb = unchecked((uint)0x8256),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_NO_RESET_NOTIFICATION_ARB")]
    NoResetNotificationarb = unchecked((uint)0x8261),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SAMPLE_LOCATION_SUBPIXEL_BITS_ARB")]
    SampleLocationSubpixelBitsarb = unchecked((uint)0x933D),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SAMPLE_LOCATION_PIXEL_GRID_WIDTH_ARB")]
    SampleLocationPixelGridWidtharb = unchecked((uint)0x933E),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_ARB")]
    SampleLocationPixelGridHeightarb = unchecked((uint)0x933F),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_ARB")]
    ProgrammableSampleLocationTableSizearb = unchecked((uint)0x9340),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SAMPLE_LOCATION_ARB")]
    SampleLocationarb = unchecked((uint)0x8E50),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PROGRAMMABLE_SAMPLE_LOCATION_ARB")]
    ProgrammableSampleLocationarb = unchecked((uint)0x9341),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_ARB")]
    FramebufferProgrammableSampleLocationsarb = unchecked((uint)0x9342),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_ARB")]
    FramebufferSampleLocationPixelGridarb = unchecked((uint)0x9343),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SAMPLE_SHADING_ARB")]
    SampleShadingarb = unchecked((uint)0x8C36),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MIN_SAMPLE_SHADING_VALUE_ARB")]
    MinSampleShadingValuearb = unchecked((uint)0x8C37),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PROGRAM_OBJECT_ARB")]
    ProgramObjectarb = unchecked((uint)0x8B40),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SHADER_OBJECT_ARB")]
    ShaderObjectarb = unchecked((uint)0x8B48),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_OBJECT_TYPE_ARB")]
    ObjectTypearb = unchecked((uint)0x8B4E),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_OBJECT_SUBTYPE_ARB")]
    ObjectSubtypearb = unchecked((uint)0x8B4F),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_FLOAT_VEC2_ARB")]
    FloatVec2Arb = unchecked((uint)0x8B50),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_FLOAT_VEC3_ARB")]
    FloatVec3Arb = unchecked((uint)0x8B51),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_FLOAT_VEC4_ARB")]
    FloatVec4Arb = unchecked((uint)0x8B52),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_INT_VEC2_ARB")]
    IntVec2Arb = unchecked((uint)0x8B53),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_INT_VEC3_ARB")]
    IntVec3Arb = unchecked((uint)0x8B54),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_INT_VEC4_ARB")]
    IntVec4Arb = unchecked((uint)0x8B55),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_BOOL_ARB")]
    Boolarb = unchecked((uint)0x8B56),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_BOOL_VEC2_ARB")]
    BoolVec2Arb = unchecked((uint)0x8B57),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_BOOL_VEC3_ARB")]
    BoolVec3Arb = unchecked((uint)0x8B58),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_BOOL_VEC4_ARB")]
    BoolVec4Arb = unchecked((uint)0x8B59),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_FLOAT_MAT2_ARB")]
    FloatMat2Arb = unchecked((uint)0x8B5A),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_FLOAT_MAT3_ARB")]
    FloatMat3Arb = unchecked((uint)0x8B5B),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_FLOAT_MAT4_ARB")]
    FloatMat4Arb = unchecked((uint)0x8B5C),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SAMPLER_1D_ARB")]
    Sampler1Darb = unchecked((uint)0x8B5D),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SAMPLER_2D_ARB")]
    Sampler2Darb = unchecked((uint)0x8B5E),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SAMPLER_3D_ARB")]
    Sampler3Darb = unchecked((uint)0x8B5F),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SAMPLER_CUBE_ARB")]
    SamplerCubearb = unchecked((uint)0x8B60),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SAMPLER_1D_SHADOW_ARB")]
    Sampler1DShadowarb = unchecked((uint)0x8B61),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SAMPLER_2D_SHADOW_ARB")]
    Sampler2DShadowarb = unchecked((uint)0x8B62),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SAMPLER_2D_RECT_ARB")]
    Sampler2DRectarb = unchecked((uint)0x8B63),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SAMPLER_2D_RECT_SHADOW_ARB")]
    Sampler2DRectShadowarb = unchecked((uint)0x8B64),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_OBJECT_DELETE_STATUS_ARB")]
    ObjectDeleteStatusarb = unchecked((uint)0x8B80),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_OBJECT_COMPILE_STATUS_ARB")]
    ObjectCompileStatusarb = unchecked((uint)0x8B81),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_OBJECT_LINK_STATUS_ARB")]
    ObjectLinkStatusarb = unchecked((uint)0x8B82),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_OBJECT_VALIDATE_STATUS_ARB")]
    ObjectValidateStatusarb = unchecked((uint)0x8B83),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_OBJECT_INFO_LOG_LENGTH_ARB")]
    ObjectInfoLogLengtharb = unchecked((uint)0x8B84),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_OBJECT_ATTACHED_OBJECTS_ARB")]
    ObjectAttachedObjectsarb = unchecked((uint)0x8B85),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_OBJECT_ACTIVE_UNIFORMS_ARB")]
    ObjectActiveUniformsarb = unchecked((uint)0x8B86),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_OBJECT_ACTIVE_UNIFORM_MAX_LENGTH_ARB")]
    ObjectActiveUniformMaxLengtharb = unchecked((uint)0x8B87),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_OBJECT_SHADER_SOURCE_LENGTH_ARB")]
    ObjectShaderSourceLengtharb = unchecked((uint)0x8B88),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SHADING_LANGUAGE_VERSION_ARB")]
    ShadingLanguageVersionarb = unchecked((uint)0x8B8C),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SHADER_INCLUDE_ARB")]
    ShaderIncludearb = unchecked((uint)0x8DAE),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_NAMED_STRING_LENGTH_ARB")]
    NamedStringLengtharb = unchecked((uint)0x8DE9),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_NAMED_STRING_TYPE_ARB")]
    NamedStringTypearb = unchecked((uint)0x8DEA),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_COMPARE_MODE_ARB")]
    TextureCompareModearb = unchecked((uint)0x884C),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_COMPARE_FUNC_ARB")]
    TextureCompareFuncarb = unchecked((uint)0x884D),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_COMPARE_R_TO_TEXTURE_ARB")]
    CompareRToTexturearb = unchecked((uint)0x884E),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_COMPARE_FAIL_VALUE_ARB")]
    TextureCompareFailValuearb = unchecked((uint)0x80BF),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SPARSE_STORAGE_BIT_ARB")]
    SparseStorageBitarb = unchecked((uint)0x0400),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SPARSE_BUFFER_PAGE_SIZE_ARB")]
    SparseBufferPageSizearb = unchecked((uint)0x82F8),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_SPARSE_ARB")]
    TextureSparsearb = unchecked((uint)0x91A6),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_VIRTUAL_PAGE_SIZE_INDEX_ARB")]
    VirtualPageSizeIndexarb = unchecked((uint)0x91A7),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_NUM_SPARSE_LEVELS_ARB")]
    NumSparseLevelsarb = unchecked((uint)0x91AA),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_NUM_VIRTUAL_PAGE_SIZES_ARB")]
    NumVirtualPageSizesarb = unchecked((uint)0x91A8),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_VIRTUAL_PAGE_SIZE_X_ARB")]
    VirtualPageSizeXarb = unchecked((uint)0x9195),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_VIRTUAL_PAGE_SIZE_Y_ARB")]
    VirtualPageSizeYarb = unchecked((uint)0x9196),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_VIRTUAL_PAGE_SIZE_Z_ARB")]
    VirtualPageSizeZarb = unchecked((uint)0x9197),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_SPARSE_TEXTURE_SIZE_ARB")]
    MaxSparseTextureSizearb = unchecked((uint)0x9198),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_SPARSE_3D_TEXTURE_SIZE_ARB")]
    MaxSparse3DTextureSizearb = unchecked((uint)0x9199),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS_ARB")]
    MaxSparseArrayTextureLayersarb = unchecked((uint)0x919A),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SPARSE_TEXTURE_FULL_ARRAY_CUBE_MIPMAPS_ARB")]
    SparseTextureFullArrayCubeMipmapsarb = unchecked((uint)0x91A9),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_CLAMP_TO_BORDER_ARB")]
    ClampToBorderarb = unchecked((uint)0x812D),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_BUFFER_ARB")]
    TextureBufferarb = unchecked((uint)0x8C2A),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_TEXTURE_BUFFER_SIZE_ARB")]
    MaxTextureBufferSizearb = unchecked((uint)0x8C2B),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_BINDING_BUFFER_ARB")]
    TextureBindingBufferarb = unchecked((uint)0x8C2C),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_BUFFER_DATA_STORE_BINDING_ARB")]
    TextureBufferDataStoreBindingarb = unchecked((uint)0x8C2D),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_BUFFER_FORMAT_ARB")]
    TextureBufferFormatarb = unchecked((uint)0x8C2E),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_COMPRESSED_ALPHA_ARB")]
    CompressedAlphaarb = unchecked((uint)0x84E9),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_COMPRESSED_LUMINANCE_ARB")]
    CompressedLuminancearb = unchecked((uint)0x84EA),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_COMPRESSED_LUMINANCE_ALPHA_ARB")]
    CompressedLuminanceAlphaarb = unchecked((uint)0x84EB),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_COMPRESSED_INTENSITY_ARB")]
    CompressedIntensityarb = unchecked((uint)0x84EC),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_COMPRESSED_RGB_ARB")]
    CompressedRgbarb = unchecked((uint)0x84ED),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_COMPRESSED_RGBA_ARB")]
    CompressedRgbaarb = unchecked((uint)0x84EE),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_COMPRESSION_HINT_ARB")]
    TextureCompressionHintarb = unchecked((uint)0x84EF),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_COMPRESSED_IMAGE_SIZE_ARB")]
    TextureCompressedImageSizearb = unchecked((uint)0x86A0),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_COMPRESSED_ARB")]
    TextureCompressedarb = unchecked((uint)0x86A1),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_NUM_COMPRESSED_TEXTURE_FORMATS_ARB")]
    NumCompressedTextureFormatsarb = unchecked((uint)0x86A2),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_COMPRESSED_TEXTURE_FORMATS_ARB")]
    CompressedTextureFormatsarb = unchecked((uint)0x86A3),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_COMPRESSED_RGBA_BPTC_UNORM_ARB")]
    CompressedRgbaBptcUnormarb = unchecked((uint)0x8E8C),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM_ARB")]
    CompressedSrgbAlphaBptcUnormarb = unchecked((uint)0x8E8D),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT_ARB")]
    CompressedRgbBptcSignedFloatarb = unchecked((uint)0x8E8E),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_ARB")]
    CompressedRgbBptcUnsignedFloatarb = unchecked((uint)0x8E8F),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_NORMAL_MAP_ARB")]
    NormalMaparb = unchecked((uint)0x8511),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_REFLECTION_MAP_ARB")]
    ReflectionMaparb = unchecked((uint)0x8512),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_ARB")]
    TextureCubeMaparb = unchecked((uint)0x8513),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_BINDING_CUBE_MAP_ARB")]
    TextureBindingCubeMaparb = unchecked((uint)0x8514),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_X_ARB")]
    TextureCubeMapPositiveXarb = unchecked((uint)0x8515),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_X_ARB")]
    TextureCubeMapNegativeXarb = unchecked((uint)0x8516),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Y_ARB")]
    TextureCubeMapPositiveYarb = unchecked((uint)0x8517),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB")]
    TextureCubeMapNegativeYarb = unchecked((uint)0x8518),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Z_ARB")]
    TextureCubeMapPositiveZarb = unchecked((uint)0x8519),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB")]
    TextureCubeMapNegativeZarb = unchecked((uint)0x851A),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PROXY_TEXTURE_CUBE_MAP_ARB")]
    ProxyTextureCubeMaparb = unchecked((uint)0x851B),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_CUBE_MAP_TEXTURE_SIZE_ARB")]
    MaxCubeMapTextureSizearb = unchecked((uint)0x851C),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_ARRAY_ARB")]
    TextureCubeMapArrayarb = unchecked((uint)0x9009),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_BINDING_CUBE_MAP_ARRAY_ARB")]
    TextureBindingCubeMapArrayarb = unchecked((uint)0x900A),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PROXY_TEXTURE_CUBE_MAP_ARRAY_ARB")]
    ProxyTextureCubeMapArrayarb = unchecked((uint)0x900B),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SAMPLER_CUBE_MAP_ARRAY_ARB")]
    SamplerCubeMapArrayarb = unchecked((uint)0x900C),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW_ARB")]
    SamplerCubeMapArrayShadowarb = unchecked((uint)0x900D),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_INT_SAMPLER_CUBE_MAP_ARRAY_ARB")]
    IntSamplerCubeMapArrayarb = unchecked((uint)0x900E),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_ARB")]
    UnsignedIntSamplerCubeMapArrayarb = unchecked((uint)0x900F),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_COMBINE_ARB")]
    Combinearb = unchecked((uint)0x8570),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_COMBINE_RGB_ARB")]
    CombineRgbarb = unchecked((uint)0x8571),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_COMBINE_ALPHA_ARB")]
    CombineAlphaarb = unchecked((uint)0x8572),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SOURCE0_RGB_ARB")]
    Source0Rgbarb = unchecked((uint)0x8580),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SOURCE1_RGB_ARB")]
    Source1Rgbarb = unchecked((uint)0x8581),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SOURCE2_RGB_ARB")]
    Source2Rgbarb = unchecked((uint)0x8582),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SOURCE0_ALPHA_ARB")]
    Source0Alphaarb = unchecked((uint)0x8588),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SOURCE1_ALPHA_ARB")]
    Source1Alphaarb = unchecked((uint)0x8589),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SOURCE2_ALPHA_ARB")]
    Source2Alphaarb = unchecked((uint)0x858A),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_OPERAND0_RGB_ARB")]
    Operand0Rgbarb = unchecked((uint)0x8590),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_OPERAND1_RGB_ARB")]
    Operand1Rgbarb = unchecked((uint)0x8591),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_OPERAND2_RGB_ARB")]
    Operand2Rgbarb = unchecked((uint)0x8592),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_OPERAND0_ALPHA_ARB")]
    Operand0Alphaarb = unchecked((uint)0x8598),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_OPERAND1_ALPHA_ARB")]
    Operand1Alphaarb = unchecked((uint)0x8599),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_OPERAND2_ALPHA_ARB")]
    Operand2Alphaarb = unchecked((uint)0x859A),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_RGB_SCALE_ARB")]
    RgbScalearb = unchecked((uint)0x8573),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_ADD_SIGNED_ARB")]
    AddSignedarb = unchecked((uint)0x8574),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_INTERPOLATE_ARB")]
    Interpolatearb = unchecked((uint)0x8575),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SUBTRACT_ARB")]
    Subtractarb = unchecked((uint)0x84E7),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_CONSTANT_ARB")]
    Constantarb = unchecked((uint)0x8576),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PRIMARY_COLOR_ARB")]
    PrimaryColorarb = unchecked((uint)0x8577),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PREVIOUS_ARB")]
    Previousarb = unchecked((uint)0x8578),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DOT3_RGB_ARB")]
    Dot3Rgbarb = unchecked((uint)0x86AE),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DOT3_RGBA_ARB")]
    Dot3Rgbaarb = unchecked((uint)0x86AF),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_REDUCTION_MODE_ARB")]
    TextureReductionModearb = unchecked((uint)0x9366),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_WEIGHTED_AVERAGE_ARB")]
    WeightedAveragearb = unchecked((uint)0x9367),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_RED_TYPE_ARB")]
    TextureRedTypearb = unchecked((uint)0x8C10),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_GREEN_TYPE_ARB")]
    TextureGreenTypearb = unchecked((uint)0x8C11),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_BLUE_TYPE_ARB")]
    TextureBlueTypearb = unchecked((uint)0x8C12),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_ALPHA_TYPE_ARB")]
    TextureAlphaTypearb = unchecked((uint)0x8C13),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_LUMINANCE_TYPE_ARB")]
    TextureLuminanceTypearb = unchecked((uint)0x8C14),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_INTENSITY_TYPE_ARB")]
    TextureIntensityTypearb = unchecked((uint)0x8C15),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_DEPTH_TYPE_ARB")]
    TextureDepthTypearb = unchecked((uint)0x8C16),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_UNSIGNED_NORMALIZED_ARB")]
    UnsignedNormalizedarb = unchecked((uint)0x8C17),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_RGBA32F_ARB")]
    Rgba32Farb = unchecked((uint)0x8814),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_RGB32F_ARB")]
    Rgb32Farb = unchecked((uint)0x8815),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_ALPHA32F_ARB")]
    Alpha32Farb = unchecked((uint)0x8816),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_INTENSITY32F_ARB")]
    Intensity32Farb = unchecked((uint)0x8817),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_LUMINANCE32F_ARB")]
    Luminance32Farb = unchecked((uint)0x8818),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_LUMINANCE_ALPHA32F_ARB")]
    LuminanceAlpha32Farb = unchecked((uint)0x8819),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_RGBA16F_ARB")]
    Rgba16Farb = unchecked((uint)0x881A),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_RGB16F_ARB")]
    Rgb16Farb = unchecked((uint)0x881B),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_ALPHA16F_ARB")]
    Alpha16Farb = unchecked((uint)0x881C),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_INTENSITY16F_ARB")]
    Intensity16Farb = unchecked((uint)0x881D),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_LUMINANCE16F_ARB")]
    Luminance16Farb = unchecked((uint)0x881E),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_LUMINANCE_ALPHA16F_ARB")]
    LuminanceAlpha16Farb = unchecked((uint)0x881F),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET_ARB")]
    MinProgramTextureGatherOffsetarb = unchecked((uint)0x8E5E),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET_ARB")]
    MaxProgramTextureGatherOffsetarb = unchecked((uint)0x8E5F),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_PROGRAM_TEXTURE_GATHER_COMPONENTS_ARB")]
    MaxProgramTextureGatherComponentsarb = unchecked((uint)0x8F9F),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MIRRORED_REPEAT_ARB")]
    MirroredRepeatarb = unchecked((uint)0x8370),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_RECTANGLE_ARB")]
    TextureRectAnglearb = unchecked((uint)0x84F5),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_BINDING_RECTANGLE_ARB")]
    TextureBindingRectAnglearb = unchecked((uint)0x84F6),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PROXY_TEXTURE_RECTANGLE_ARB")]
    ProxyTextureRectAnglearb = unchecked((uint)0x84F7),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_RECTANGLE_TEXTURE_SIZE_ARB")]
    MaxRectangleTextureSizearb = unchecked((uint)0x84F8),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TRANSFORM_FEEDBACK_OVERFLOW_ARB")]
    TransformFeedbackOverflowarb = unchecked((uint)0x82EC),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TRANSFORM_FEEDBACK_STREAM_OVERFLOW_ARB")]
    TransformFeedbackStreamOverflowarb = unchecked((uint)0x82ED),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TRANSPOSE_MODELVIEW_MATRIX_ARB")]
    TransposeModelviewMatrixarb = unchecked((uint)0x84E3),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TRANSPOSE_PROJECTION_MATRIX_ARB")]
    TransposeProjectionMatrixarb = unchecked((uint)0x84E4),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TRANSPOSE_TEXTURE_MATRIX_ARB")]
    TransposeTextureMatrixarb = unchecked((uint)0x84E5),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TRANSPOSE_COLOR_MATRIX_ARB")]
    TransposeColorMatrixarb = unchecked((uint)0x84E6),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_VERTEX_UNITS_ARB")]
    MaxVertexUnitsarb = unchecked((uint)0x86A4),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_ACTIVE_VERTEX_UNITS_ARB")]
    ActiveVertexUnitsarb = unchecked((uint)0x86A5),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_WEIGHT_SUM_UNITY_ARB")]
    WeightSumUnityarb = unchecked((uint)0x86A6),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_VERTEX_BLEND_ARB")]
    VertexBlendarb = unchecked((uint)0x86A7),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_CURRENT_WEIGHT_ARB")]
    CurrentWeightarb = unchecked((uint)0x86A8),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_WEIGHT_ARRAY_TYPE_ARB")]
    WeightArrayTypearb = unchecked((uint)0x86A9),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_WEIGHT_ARRAY_STRIDE_ARB")]
    WeightArrayStridearb = unchecked((uint)0x86AA),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_WEIGHT_ARRAY_SIZE_ARB")]
    WeightArraySizearb = unchecked((uint)0x86AB),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_WEIGHT_ARRAY_POINTER_ARB")]
    WeightArrayPointerarb = unchecked((uint)0x86AC),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_WEIGHT_ARRAY_ARB")]
    WeightArrayarb = unchecked((uint)0x86AD),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MODELVIEW0_ARB")]
    Modelview0Arb = unchecked((uint)0x1700),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MODELVIEW1_ARB")]
    Modelview1Arb = unchecked((uint)0x850A),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MODELVIEW2_ARB")]
    Modelview2Arb = unchecked((uint)0x8722),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MODELVIEW3_ARB")]
    Modelview3Arb = unchecked((uint)0x8723),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MODELVIEW4_ARB")]
    Modelview4Arb = unchecked((uint)0x8724),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MODELVIEW5_ARB")]
    Modelview5Arb = unchecked((uint)0x8725),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MODELVIEW6_ARB")]
    Modelview6Arb = unchecked((uint)0x8726),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MODELVIEW7_ARB")]
    Modelview7Arb = unchecked((uint)0x8727),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MODELVIEW8_ARB")]
    Modelview8Arb = unchecked((uint)0x8728),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MODELVIEW9_ARB")]
    Modelview9Arb = unchecked((uint)0x8729),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MODELVIEW10_ARB")]
    Modelview10Arb = unchecked((uint)0x872A),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MODELVIEW11_ARB")]
    Modelview11Arb = unchecked((uint)0x872B),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MODELVIEW12_ARB")]
    Modelview12Arb = unchecked((uint)0x872C),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MODELVIEW13_ARB")]
    Modelview13Arb = unchecked((uint)0x872D),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MODELVIEW14_ARB")]
    Modelview14Arb = unchecked((uint)0x872E),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MODELVIEW15_ARB")]
    Modelview15Arb = unchecked((uint)0x872F),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MODELVIEW16_ARB")]
    Modelview16Arb = unchecked((uint)0x8730),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MODELVIEW17_ARB")]
    Modelview17Arb = unchecked((uint)0x8731),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MODELVIEW18_ARB")]
    Modelview18Arb = unchecked((uint)0x8732),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MODELVIEW19_ARB")]
    Modelview19Arb = unchecked((uint)0x8733),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MODELVIEW20_ARB")]
    Modelview20Arb = unchecked((uint)0x8734),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MODELVIEW21_ARB")]
    Modelview21Arb = unchecked((uint)0x8735),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MODELVIEW22_ARB")]
    Modelview22Arb = unchecked((uint)0x8736),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MODELVIEW23_ARB")]
    Modelview23Arb = unchecked((uint)0x8737),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MODELVIEW24_ARB")]
    Modelview24Arb = unchecked((uint)0x8738),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MODELVIEW25_ARB")]
    Modelview25Arb = unchecked((uint)0x8739),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MODELVIEW26_ARB")]
    Modelview26Arb = unchecked((uint)0x873A),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MODELVIEW27_ARB")]
    Modelview27Arb = unchecked((uint)0x873B),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MODELVIEW28_ARB")]
    Modelview28Arb = unchecked((uint)0x873C),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MODELVIEW29_ARB")]
    Modelview29Arb = unchecked((uint)0x873D),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MODELVIEW30_ARB")]
    Modelview30Arb = unchecked((uint)0x873E),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MODELVIEW31_ARB")]
    Modelview31Arb = unchecked((uint)0x873F),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_BUFFER_SIZE_ARB")]
    BufferSizearb = unchecked((uint)0x8764),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_BUFFER_USAGE_ARB")]
    BufferUsagearb = unchecked((uint)0x8765),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_ARRAY_BUFFER_ARB")]
    ArrayBufferarb = unchecked((uint)0x8892),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_ELEMENT_ARRAY_BUFFER_ARB")]
    ElementArrayBufferarb = unchecked((uint)0x8893),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_ARRAY_BUFFER_BINDING_ARB")]
    ArrayBufferBindingarb = unchecked((uint)0x8894),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_ELEMENT_ARRAY_BUFFER_BINDING_ARB")]
    ElementArrayBufferBindingarb = unchecked((uint)0x8895),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_VERTEX_ARRAY_BUFFER_BINDING_ARB")]
    VertexArrayBufferBindingarb = unchecked((uint)0x8896),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_NORMAL_ARRAY_BUFFER_BINDING_ARB")]
    NormalArrayBufferBindingarb = unchecked((uint)0x8897),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_COLOR_ARRAY_BUFFER_BINDING_ARB")]
    ColorArrayBufferBindingarb = unchecked((uint)0x8898),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_INDEX_ARRAY_BUFFER_BINDING_ARB")]
    IndexArrayBufferBindingarb = unchecked((uint)0x8899),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING_ARB")]
    TextureCoordArrayBufferBindingarb = unchecked((uint)0x889A),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_EDGE_FLAG_ARRAY_BUFFER_BINDING_ARB")]
    EdgeFlagArrayBufferBindingarb = unchecked((uint)0x889B),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SECONDARY_COLOR_ARRAY_BUFFER_BINDING_ARB")]
    SecondaryColorArrayBufferBindingarb = unchecked((uint)0x889C),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_FOG_COORDINATE_ARRAY_BUFFER_BINDING_ARB")]
    FogCoordinateArrayBufferBindingarb = unchecked((uint)0x889D),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_WEIGHT_ARRAY_BUFFER_BINDING_ARB")]
    WeightArrayBufferBindingarb = unchecked((uint)0x889E),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING_ARB")]
    VertexAttribArrayBufferBindingarb = unchecked((uint)0x889F),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_READ_ONLY_ARB")]
    ReadOnlyarb = unchecked((uint)0x88B8),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_WRITE_ONLY_ARB")]
    WriteOnlyarb = unchecked((uint)0x88B9),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_READ_WRITE_ARB")]
    ReadWritearb = unchecked((uint)0x88BA),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_BUFFER_ACCESS_ARB")]
    BufferAccessarb = unchecked((uint)0x88BB),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_BUFFER_MAPPED_ARB")]
    BufferMappedarb = unchecked((uint)0x88BC),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_BUFFER_MAP_POINTER_ARB")]
    BufferMapPointerarb = unchecked((uint)0x88BD),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_STREAM_DRAW_ARB")]
    StreamDrawarb = unchecked((uint)0x88E0),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_STREAM_READ_ARB")]
    StreamReadarb = unchecked((uint)0x88E1),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_STREAM_COPY_ARB")]
    StreamCopyarb = unchecked((uint)0x88E2),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_STATIC_DRAW_ARB")]
    StaticDrawarb = unchecked((uint)0x88E4),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_STATIC_READ_ARB")]
    StaticReadarb = unchecked((uint)0x88E5),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_STATIC_COPY_ARB")]
    StaticCopyarb = unchecked((uint)0x88E6),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DYNAMIC_DRAW_ARB")]
    DynamicDrawarb = unchecked((uint)0x88E8),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DYNAMIC_READ_ARB")]
    DynamicReadarb = unchecked((uint)0x88E9),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_DYNAMIC_COPY_ARB")]
    DynamicCopyarb = unchecked((uint)0x88EA),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_COLOR_SUM_ARB")]
    ColorSumarb = unchecked((uint)0x8458),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_VERTEX_PROGRAM_ARB")]
    VertexProgramarb = unchecked((uint)0x8620),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_VERTEX_ATTRIB_ARRAY_ENABLED_ARB")]
    VertexAttribArrayEnabledarb = unchecked((uint)0x8622),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_VERTEX_ATTRIB_ARRAY_SIZE_ARB")]
    VertexAttribArraySizearb = unchecked((uint)0x8623),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_VERTEX_ATTRIB_ARRAY_STRIDE_ARB")]
    VertexAttribArrayStridearb = unchecked((uint)0x8624),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_VERTEX_ATTRIB_ARRAY_TYPE_ARB")]
    VertexAttribArrayTypearb = unchecked((uint)0x8625),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_CURRENT_VERTEX_ATTRIB_ARB")]
    CurrentVertexAttribarb = unchecked((uint)0x8626),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_VERTEX_PROGRAM_POINT_SIZE_ARB")]
    VertexProgramPointSizearb = unchecked((uint)0x8642),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_VERTEX_PROGRAM_TWO_SIDE_ARB")]
    VertexProgramTwoSidearb = unchecked((uint)0x8643),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_VERTEX_ATTRIB_ARRAY_POINTER_ARB")]
    VertexAttribArrayPointerarb = unchecked((uint)0x8645),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_VERTEX_ATTRIBS_ARB")]
    MaxVertexAttribsarb = unchecked((uint)0x8869),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_VERTEX_ATTRIB_ARRAY_NORMALIZED_ARB")]
    VertexAttribArrayNormalizedarb = unchecked((uint)0x886A),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PROGRAM_ADDRESS_REGISTERS_ARB")]
    ProgramAddressRegistersarb = unchecked((uint)0x88B0),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_PROGRAM_ADDRESS_REGISTERS_ARB")]
    MaxProgramAddressRegistersarb = unchecked((uint)0x88B1),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB")]
    ProgramNativeAddressRegistersarb = unchecked((uint)0x88B2),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB")]
    MaxProgramNativeAddressRegistersarb = unchecked((uint)0x88B3),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_VERTEX_SHADER_ARB")]
    VertexShaderarb = unchecked((uint)0x8B31),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_VERTEX_UNIFORM_COMPONENTS_ARB")]
    MaxVertexUniformComponentsarb = unchecked((uint)0x8B4A),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_VARYING_FLOATS_ARB")]
    MaxVaryingFloatsarb = unchecked((uint)0x8B4B),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS_ARB")]
    MaxVertexTextureImageUnitsarb = unchecked((uint)0x8B4C),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS_ARB")]
    MaxCombinedTextureImageUnitsarb = unchecked((uint)0x8B4D),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_OBJECT_ACTIVE_ATTRIBUTES_ARB")]
    ObjectActiveAttributesarb = unchecked((uint)0x8B89),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_OBJECT_ACTIVE_ATTRIBUTE_MAX_LENGTH_ARB")]
    ObjectActiveAttributeMaxLengtharb = unchecked((uint)0x8B8A),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_MULTIPLY_KHR")]
    Multiplykhr = unchecked((uint)0x9294),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_SCREEN_KHR")]
    Screenkhr = unchecked((uint)0x9295),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_OVERLAY_KHR")]
    Overlaykhr = unchecked((uint)0x9296),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_DARKEN_KHR")]
    Darkenkhr = unchecked((uint)0x9297),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_LIGHTEN_KHR")]
    Lightenkhr = unchecked((uint)0x9298),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_COLORDODGE_KHR")]
    Colordodgekhr = unchecked((uint)0x9299),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_COLORBURN_KHR")]
    Colorburnkhr = unchecked((uint)0x929A),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_HARDLIGHT_KHR")]
    Hardlightkhr = unchecked((uint)0x929B),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_SOFTLIGHT_KHR")]
    Softlightkhr = unchecked((uint)0x929C),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_DIFFERENCE_KHR")]
    Differencekhr = unchecked((uint)0x929E),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_EXCLUSION_KHR")]
    Exclusionkhr = unchecked((uint)0x92A0),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_HSL_HUE_KHR")]
    HslHuekhr = unchecked((uint)0x92AD),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_HSL_SATURATION_KHR")]
    HslSaturationkhr = unchecked((uint)0x92AE),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_HSL_COLOR_KHR")]
    HslColorkhr = unchecked((uint)0x92AF),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_HSL_LUMINOSITY_KHR")]
    HslLuminositykhr = unchecked((uint)0x92B0),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_BLEND_ADVANCED_COHERENT_KHR")]
    BlendAdvancedCoherentkhr = unchecked((uint)0x9285),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_CONTEXT_FLAG_NO_ERROR_BIT_KHR")]
    ContextFlagNoErrorBitkhr = unchecked((uint)0x00000008),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_MAX_SHADER_COMPILER_THREADS_KHR")]
    MaxShaderCompilerThreadskhr = unchecked((uint)0x91B0),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_COMPLETION_STATUS_KHR")]
    CompletionStatuskhr = unchecked((uint)0x91B1),

    [NativeName("GL_CONTEXT_ROBUST_ACCESS")]
    ContextRobustAccess = unchecked((uint)0x90F3),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_SUBGROUP_SIZE_KHR")]
    SubgroupSizekhr = unchecked((uint)0x9532),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_SUBGROUP_SUPPORTED_STAGES_KHR")]
    SubgroupSupportedStageskhr = unchecked((uint)0x9533),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_SUBGROUP_SUPPORTED_FEATURES_KHR")]
    SubgroupSupportedFeatureskhr = unchecked((uint)0x9534),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_SUBGROUP_QUAD_ALL_STAGES_KHR")]
    SubgroupQuadAllStageskhr = unchecked((uint)0x9535),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_SUBGROUP_FEATURE_BASIC_BIT_KHR")]
    SubgroupFeatureBasicBitkhr = unchecked((uint)0x00000001),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_SUBGROUP_FEATURE_VOTE_BIT_KHR")]
    SubgroupFeatureVoteBitkhr = unchecked((uint)0x00000002),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_SUBGROUP_FEATURE_ARITHMETIC_BIT_KHR")]
    SubgroupFeatureArithmeticBitkhr = unchecked((uint)0x00000004),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_SUBGROUP_FEATURE_BALLOT_BIT_KHR")]
    SubgroupFeatureBallotBitkhr = unchecked((uint)0x00000008),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_SUBGROUP_FEATURE_SHUFFLE_BIT_KHR")]
    SubgroupFeatureShuffleBitkhr = unchecked((uint)0x00000010),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT_KHR")]
    SubgroupFeatureShuffleRelativeBitkhr = unchecked((uint)0x00000020),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_SUBGROUP_FEATURE_CLUSTERED_BIT_KHR")]
    SubgroupFeatureClusteredBitkhr = unchecked((uint)0x00000040),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_SUBGROUP_FEATURE_QUAD_BIT_KHR")]
    SubgroupFeatureQuadBitkhr = unchecked((uint)0x00000080),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_COMPRESSED_RGBA_ASTC_4x4_KHR")]
    CompressedRgbaAstc4X4Khr = unchecked((uint)0x93B0),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_COMPRESSED_RGBA_ASTC_5x4_KHR")]
    CompressedRgbaAstc5X4Khr = unchecked((uint)0x93B1),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_COMPRESSED_RGBA_ASTC_5x5_KHR")]
    CompressedRgbaAstc5X5Khr = unchecked((uint)0x93B2),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_COMPRESSED_RGBA_ASTC_6x5_KHR")]
    CompressedRgbaAstc6X5Khr = unchecked((uint)0x93B3),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_COMPRESSED_RGBA_ASTC_6x6_KHR")]
    CompressedRgbaAstc6X6Khr = unchecked((uint)0x93B4),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_COMPRESSED_RGBA_ASTC_8x5_KHR")]
    CompressedRgbaAstc8X5Khr = unchecked((uint)0x93B5),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_COMPRESSED_RGBA_ASTC_8x6_KHR")]
    CompressedRgbaAstc8X6Khr = unchecked((uint)0x93B6),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_COMPRESSED_RGBA_ASTC_8x8_KHR")]
    CompressedRgbaAstc8X8Khr = unchecked((uint)0x93B7),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_COMPRESSED_RGBA_ASTC_10x5_KHR")]
    CompressedRgbaAstc10X5Khr = unchecked((uint)0x93B8),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_COMPRESSED_RGBA_ASTC_10x6_KHR")]
    CompressedRgbaAstc10X6Khr = unchecked((uint)0x93B9),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_COMPRESSED_RGBA_ASTC_10x8_KHR")]
    CompressedRgbaAstc10X8Khr = unchecked((uint)0x93BA),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_COMPRESSED_RGBA_ASTC_10x10_KHR")]
    CompressedRgbaAstc10X10Khr = unchecked((uint)0x93BB),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_COMPRESSED_RGBA_ASTC_12x10_KHR")]
    CompressedRgbaAstc12X10Khr = unchecked((uint)0x93BC),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_COMPRESSED_RGBA_ASTC_12x12_KHR")]
    CompressedRgbaAstc12X12Khr = unchecked((uint)0x93BD),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR")]
    CompressedSrgb8Alpha8Astc4X4Khr = unchecked((uint)0x93D0),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4_KHR")]
    CompressedSrgb8Alpha8Astc5X4Khr = unchecked((uint)0x93D1),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5_KHR")]
    CompressedSrgb8Alpha8Astc5X5Khr = unchecked((uint)0x93D2),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5_KHR")]
    CompressedSrgb8Alpha8Astc6X5Khr = unchecked((uint)0x93D3),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6_KHR")]
    CompressedSrgb8Alpha8Astc6X6Khr = unchecked((uint)0x93D4),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x5_KHR")]
    CompressedSrgb8Alpha8Astc8X5Khr = unchecked((uint)0x93D5),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x6_KHR")]
    CompressedSrgb8Alpha8Astc8X6Khr = unchecked((uint)0x93D6),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x8_KHR")]
    CompressedSrgb8Alpha8Astc8X8Khr = unchecked((uint)0x93D7),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x5_KHR")]
    CompressedSrgb8Alpha8Astc10X5Khr = unchecked((uint)0x93D8),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x6_KHR")]
    CompressedSrgb8Alpha8Astc10X6Khr = unchecked((uint)0x93D9),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x8_KHR")]
    CompressedSrgb8Alpha8Astc10X8Khr = unchecked((uint)0x93DA),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x10_KHR")]
    CompressedSrgb8Alpha8Astc10X10Khr = unchecked((uint)0x93DB),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x10_KHR")]
    CompressedSrgb8Alpha8Astc12X10Khr = unchecked((uint)0x93DC),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x12_KHR")]
    CompressedSrgb8Alpha8Astc12X12Khr = unchecked((uint)0x93DD),

    [NameAffix("Suffix", "3DFX", 0)]
    [NativeName("GL_MULTISAMPLE_3DFX")]
    Multisample3Dfx = unchecked((uint)0x86B2),

    [NameAffix("Suffix", "3DFX", 0)]
    [NativeName("GL_SAMPLE_BUFFERS_3DFX")]
    SampleBuffers3Dfx = unchecked((uint)0x86B3),

    [NameAffix("Suffix", "3DFX", 0)]
    [NativeName("GL_SAMPLES_3DFX")]
    Samples3Dfx = unchecked((uint)0x86B4),

    [NameAffix("Suffix", "3DFX", 0)]
    [NativeName("GL_MULTISAMPLE_BIT_3DFX")]
    MultisampleBit3Dfx = unchecked((uint)0x20000000),

    [NameAffix("Suffix", "3DFX", 0)]
    [NativeName("GL_COMPRESSED_RGB_FXT1_3DFX")]
    CompressedRgbFxt13Dfx = unchecked((uint)0x86B0),

    [NameAffix("Suffix", "3DFX", 0)]
    [NativeName("GL_COMPRESSED_RGBA_FXT1_3DFX")]
    CompressedRgbaFxt13Dfx = unchecked((uint)0x86B1),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_FACTOR_MIN_AMD")]
    FactorMinamd = unchecked((uint)0x901C),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_FACTOR_MAX_AMD")]
    FactorMaxamd = unchecked((uint)0x901D),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_MAX_DEBUG_MESSAGE_LENGTH_AMD")]
    MaxDebugMessageLengthamd = unchecked((uint)0x9143),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_MAX_DEBUG_LOGGED_MESSAGES_AMD")]
    MaxDebugLoggedMessagesamd = unchecked((uint)0x9144),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_DEBUG_LOGGED_MESSAGES_AMD")]
    DebugLoggedMessagesamd = unchecked((uint)0x9145),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_DEBUG_SEVERITY_HIGH_AMD")]
    DebugSeverityHighamd = unchecked((uint)0x9146),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_DEBUG_SEVERITY_MEDIUM_AMD")]
    DebugSeverityMediumamd = unchecked((uint)0x9147),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_DEBUG_SEVERITY_LOW_AMD")]
    DebugSeverityLowamd = unchecked((uint)0x9148),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_DEBUG_CATEGORY_API_ERROR_AMD")]
    DebugCategoryApiErroramd = unchecked((uint)0x9149),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_DEBUG_CATEGORY_WINDOW_SYSTEM_AMD")]
    DebugCategoryWindowSystemamd = unchecked((uint)0x914A),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_DEBUG_CATEGORY_DEPRECATION_AMD")]
    DebugCategoryDeprecationamd = unchecked((uint)0x914B),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_DEBUG_CATEGORY_UNDEFINED_BEHAVIOR_AMD")]
    DebugCategoryUndefinedBehavioramd = unchecked((uint)0x914C),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_DEBUG_CATEGORY_PERFORMANCE_AMD")]
    DebugCategoryPerformanceamd = unchecked((uint)0x914D),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_DEBUG_CATEGORY_SHADER_COMPILER_AMD")]
    DebugCategoryShaderCompileramd = unchecked((uint)0x914E),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_DEBUG_CATEGORY_APPLICATION_AMD")]
    DebugCategoryApplicationamd = unchecked((uint)0x914F),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_DEBUG_CATEGORY_OTHER_AMD")]
    DebugCategoryOtheramd = unchecked((uint)0x9150),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_DEPTH_CLAMP_NEAR_AMD")]
    DepthClampNearamd = unchecked((uint)0x901E),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_DEPTH_CLAMP_FAR_AMD")]
    DepthClampFaramd = unchecked((uint)0x901F),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_RENDERBUFFER_STORAGE_SAMPLES_AMD")]
    RenderbufferStorageSamplesamd = unchecked((uint)0x91B2),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_MAX_COLOR_FRAMEBUFFER_SAMPLES_AMD")]
    MaxColorFramebufferSamplesamd = unchecked((uint)0x91B3),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_MAX_COLOR_FRAMEBUFFER_STORAGE_SAMPLES_AMD")]
    MaxColorFramebufferStorageSamplesamd = unchecked((uint)0x91B4),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_MAX_DEPTH_STENCIL_FRAMEBUFFER_SAMPLES_AMD")]
    MaxDepthStencilFramebufferSamplesamd = unchecked((uint)0x91B5),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_NUM_SUPPORTED_MULTISAMPLE_MODES_AMD")]
    NumSupportedMultisampleModesamd = unchecked((uint)0x91B6),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_SUPPORTED_MULTISAMPLE_MODES_AMD")]
    SupportedMultisampleModesamd = unchecked((uint)0x91B7),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_SUBSAMPLE_DISTANCE_AMD")]
    SubsampleDistanceamd = unchecked((uint)0x883F),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_PIXELS_PER_SAMPLE_PATTERN_X_AMD")]
    PixelsPerSamplePatternXamd = unchecked((uint)0x91AE),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_PIXELS_PER_SAMPLE_PATTERN_Y_AMD")]
    PixelsPerSamplePatternYamd = unchecked((uint)0x91AF),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_ALL_PIXELS_AMD")]
    AllPixelsamd = unchecked((uint)0xFFFFFFFF),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FLOAT16_NV")]
    Float16Nv = unchecked((uint)0x8FF8),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FLOAT16_VEC2_NV")]
    Float16Vec2Nv = unchecked((uint)0x8FF9),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FLOAT16_VEC3_NV")]
    Float16Vec3Nv = unchecked((uint)0x8FFA),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FLOAT16_VEC4_NV")]
    Float16Vec4Nv = unchecked((uint)0x8FFB),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_FLOAT16_MAT2_AMD")]
    Float16Mat2Amd = unchecked((uint)0x91C5),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_FLOAT16_MAT3_AMD")]
    Float16Mat3Amd = unchecked((uint)0x91C6),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_FLOAT16_MAT4_AMD")]
    Float16Mat4Amd = unchecked((uint)0x91C7),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_FLOAT16_MAT2x3_AMD")]
    Float16Mat2X3Amd = unchecked((uint)0x91C8),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_FLOAT16_MAT2x4_AMD")]
    Float16Mat2X4Amd = unchecked((uint)0x91C9),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_FLOAT16_MAT3x2_AMD")]
    Float16Mat3X2Amd = unchecked((uint)0x91CA),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_FLOAT16_MAT3x4_AMD")]
    Float16Mat3X4Amd = unchecked((uint)0x91CB),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_FLOAT16_MAT4x2_AMD")]
    Float16Mat4X2Amd = unchecked((uint)0x91CC),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_FLOAT16_MAT4x3_AMD")]
    Float16Mat4X3Amd = unchecked((uint)0x91CD),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_INT64_NV")]
    Int64Nv = unchecked((uint)0x140E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_UNSIGNED_INT64_NV")]
    UnsignedInt64Nv = unchecked((uint)0x140F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_INT8_NV")]
    Int8Nv = unchecked((uint)0x8FE0),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_INT8_VEC2_NV")]
    Int8Vec2Nv = unchecked((uint)0x8FE1),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_INT8_VEC3_NV")]
    Int8Vec3Nv = unchecked((uint)0x8FE2),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_INT8_VEC4_NV")]
    Int8Vec4Nv = unchecked((uint)0x8FE3),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_INT16_NV")]
    Int16Nv = unchecked((uint)0x8FE4),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_INT16_VEC2_NV")]
    Int16Vec2Nv = unchecked((uint)0x8FE5),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_INT16_VEC3_NV")]
    Int16Vec3Nv = unchecked((uint)0x8FE6),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_INT16_VEC4_NV")]
    Int16Vec4Nv = unchecked((uint)0x8FE7),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_INT64_VEC2_NV")]
    Int64Vec2Nv = unchecked((uint)0x8FE9),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_INT64_VEC3_NV")]
    Int64Vec3Nv = unchecked((uint)0x8FEA),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_INT64_VEC4_NV")]
    Int64Vec4Nv = unchecked((uint)0x8FEB),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_UNSIGNED_INT8_NV")]
    UnsignedInt8Nv = unchecked((uint)0x8FEC),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_UNSIGNED_INT8_VEC2_NV")]
    UnsignedInt8Vec2Nv = unchecked((uint)0x8FED),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_UNSIGNED_INT8_VEC3_NV")]
    UnsignedInt8Vec3Nv = unchecked((uint)0x8FEE),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_UNSIGNED_INT8_VEC4_NV")]
    UnsignedInt8Vec4Nv = unchecked((uint)0x8FEF),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_UNSIGNED_INT16_NV")]
    UnsignedInt16Nv = unchecked((uint)0x8FF0),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_UNSIGNED_INT16_VEC2_NV")]
    UnsignedInt16Vec2Nv = unchecked((uint)0x8FF1),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_UNSIGNED_INT16_VEC3_NV")]
    UnsignedInt16Vec3Nv = unchecked((uint)0x8FF2),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_UNSIGNED_INT16_VEC4_NV")]
    UnsignedInt16Vec4Nv = unchecked((uint)0x8FF3),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_UNSIGNED_INT64_VEC2_NV")]
    UnsignedInt64Vec2Nv = unchecked((uint)0x8FF5),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_UNSIGNED_INT64_VEC3_NV")]
    UnsignedInt64Vec3Nv = unchecked((uint)0x8FF6),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_UNSIGNED_INT64_VEC4_NV")]
    UnsignedInt64Vec4Nv = unchecked((uint)0x8FF7),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_VERTEX_ELEMENT_SWIZZLE_AMD")]
    VertexElementSwizzleamd = unchecked((uint)0x91A4),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_VERTEX_ID_SWIZZLE_AMD")]
    VertexIdSwizzleamd = unchecked((uint)0x91A5),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_DATA_BUFFER_AMD")]
    DataBufferamd = unchecked((uint)0x9151),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_PERFORMANCE_MONITOR_AMD")]
    PerformanceMonitoramd = unchecked((uint)0x9152),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_QUERY_OBJECT_AMD")]
    QueryObjectamd = unchecked((uint)0x9153),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_VERTEX_ARRAY_OBJECT_AMD")]
    VertexArrayObjectamd = unchecked((uint)0x9154),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_SAMPLER_OBJECT_AMD")]
    SamplerObjectamd = unchecked((uint)0x9155),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_OCCLUSION_QUERY_EVENT_MASK_AMD")]
    OcclusionQueryEventMaskamd = unchecked((uint)0x874F),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_QUERY_DEPTH_PASS_EVENT_BIT_AMD")]
    QueryDepthPassEventBitamd = unchecked((uint)0x00000001),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_QUERY_DEPTH_FAIL_EVENT_BIT_AMD")]
    QueryDepthFailEventBitamd = unchecked((uint)0x00000002),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_QUERY_STENCIL_FAIL_EVENT_BIT_AMD")]
    QueryStencilFailEventBitamd = unchecked((uint)0x00000004),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_QUERY_DEPTH_BOUNDS_FAIL_EVENT_BIT_AMD")]
    QueryDepthBoundsFailEventBitamd = unchecked((uint)0x00000008),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_QUERY_ALL_EVENT_BITS_AMD")]
    QueryAllEventBitsamd = unchecked((uint)0xFFFFFFFF),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_COUNTER_TYPE_AMD")]
    CounterTypeamd = unchecked((uint)0x8BC0),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_COUNTER_RANGE_AMD")]
    CounterRangeamd = unchecked((uint)0x8BC1),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_UNSIGNED_INT64_AMD")]
    UnsignedInt64Amd = unchecked((uint)0x8BC2),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_PERCENTAGE_AMD")]
    Percentageamd = unchecked((uint)0x8BC3),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_PERFMON_RESULT_AVAILABLE_AMD")]
    PerfmonResultAvailableamd = unchecked((uint)0x8BC4),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_PERFMON_RESULT_SIZE_AMD")]
    PerfmonResultSizeamd = unchecked((uint)0x8BC5),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_PERFMON_RESULT_AMD")]
    PerfmonResultamd = unchecked((uint)0x8BC6),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_EXTERNAL_VIRTUAL_MEMORY_BUFFER_AMD")]
    ExternalVirtualMemoryBufferamd = unchecked((uint)0x9160),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_QUERY_BUFFER_AMD")]
    QueryBufferamd = unchecked((uint)0x9192),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_QUERY_BUFFER_BINDING_AMD")]
    QueryBufferBindingamd = unchecked((uint)0x9193),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_QUERY_RESULT_NO_WAIT_AMD")]
    QueryResultNoWaitamd = unchecked((uint)0x9194),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_VIRTUAL_PAGE_SIZE_X_AMD")]
    VirtualPageSizeXamd = unchecked((uint)0x9195),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_VIRTUAL_PAGE_SIZE_Y_AMD")]
    VirtualPageSizeYamd = unchecked((uint)0x9196),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_VIRTUAL_PAGE_SIZE_Z_AMD")]
    VirtualPageSizeZamd = unchecked((uint)0x9197),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_MAX_SPARSE_TEXTURE_SIZE_AMD")]
    MaxSparseTextureSizeamd = unchecked((uint)0x9198),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_MAX_SPARSE_3D_TEXTURE_SIZE_AMD")]
    MaxSparse3DTextureSizeamd = unchecked((uint)0x9199),

    [NativeName("GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS")]
    MaxSparseArrayTextureLayers = unchecked((uint)0x919A),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_MIN_SPARSE_LEVEL_AMD")]
    MinSparseLevelamd = unchecked((uint)0x919B),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_MIN_LOD_WARNING_AMD")]
    MinLodWarningamd = unchecked((uint)0x919C),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_TEXTURE_STORAGE_SPARSE_BIT_AMD")]
    TextureStorageSparseBitamd = unchecked((uint)0x00000001),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_SET_AMD")]
    Setamd = unchecked((uint)0x874A),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_REPLACE_VALUE_AMD")]
    ReplaceValueamd = unchecked((uint)0x874B),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_STENCIL_OP_VALUE_AMD")]
    StencilOpValueamd = unchecked((uint)0x874C),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_STENCIL_BACK_OP_VALUE_AMD")]
    StencilBackOpValueamd = unchecked((uint)0x874D),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_STREAM_RASTERIZATION_AMD")]
    StreamRasterizationamd = unchecked((uint)0x91A0),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_SAMPLER_BUFFER_AMD")]
    SamplerBufferamd = unchecked((uint)0x9001),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_INT_SAMPLER_BUFFER_AMD")]
    IntSamplerBufferamd = unchecked((uint)0x9002),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_UNSIGNED_INT_SAMPLER_BUFFER_AMD")]
    UnsignedIntSamplerBufferamd = unchecked((uint)0x9003),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_TESSELLATION_MODE_AMD")]
    TessellationModeamd = unchecked((uint)0x9004),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_TESSELLATION_FACTOR_AMD")]
    TessellationFactoramd = unchecked((uint)0x9005),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_DISCRETE_AMD")]
    Discreteamd = unchecked((uint)0x9006),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_CONTINUOUS_AMD")]
    Continuousamd = unchecked((uint)0x9007),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_AUX_DEPTH_STENCIL_APPLE")]
    AuxDepthStencilapple = unchecked((uint)0x8A14),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_UNPACK_CLIENT_STORAGE_APPLE")]
    UnpackClientStorageapple = unchecked((uint)0x85B2),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_ELEMENT_ARRAY_APPLE")]
    ElementArrayapple = unchecked((uint)0x8A0C),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_ELEMENT_ARRAY_TYPE_APPLE")]
    ElementArrayTypeapple = unchecked((uint)0x8A0D),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_ELEMENT_ARRAY_POINTER_APPLE")]
    ElementArrayPointerapple = unchecked((uint)0x8A0E),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_DRAW_PIXELS_APPLE")]
    DrawPixelsapple = unchecked((uint)0x8A0A),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_FENCE_APPLE")]
    Fenceapple = unchecked((uint)0x8A0B),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_HALF_APPLE")]
    Halfapple = unchecked((uint)0x140B),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_RGBA_FLOAT32_APPLE")]
    RgbaFloat32Apple = unchecked((uint)0x8814),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_RGB_FLOAT32_APPLE")]
    RgbFloat32Apple = unchecked((uint)0x8815),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_ALPHA_FLOAT32_APPLE")]
    AlphaFloat32Apple = unchecked((uint)0x8816),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_INTENSITY_FLOAT32_APPLE")]
    IntensityFloat32Apple = unchecked((uint)0x8817),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_LUMINANCE_FLOAT32_APPLE")]
    LuminanceFloat32Apple = unchecked((uint)0x8818),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_LUMINANCE_ALPHA_FLOAT32_APPLE")]
    LuminanceAlphaFloat32Apple = unchecked((uint)0x8819),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_RGBA_FLOAT16_APPLE")]
    RgbaFloat16Apple = unchecked((uint)0x881A),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_RGB_FLOAT16_APPLE")]
    RgbFloat16Apple = unchecked((uint)0x881B),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_ALPHA_FLOAT16_APPLE")]
    AlphaFloat16Apple = unchecked((uint)0x881C),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_INTENSITY_FLOAT16_APPLE")]
    IntensityFloat16Apple = unchecked((uint)0x881D),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_LUMINANCE_FLOAT16_APPLE")]
    LuminanceFloat16Apple = unchecked((uint)0x881E),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_LUMINANCE_ALPHA_FLOAT16_APPLE")]
    LuminanceAlphaFloat16Apple = unchecked((uint)0x881F),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_COLOR_FLOAT_APPLE")]
    ColorFloatapple = unchecked((uint)0x8A0F),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_BUFFER_SERIALIZED_MODIFY_APPLE")]
    BufferSerializedModifyapple = unchecked((uint)0x8A12),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_BUFFER_FLUSHING_UNMAP_APPLE")]
    BufferFlushingUnmapapple = unchecked((uint)0x8A13),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_BUFFER_OBJECT_APPLE")]
    BufferObjectapple = unchecked((uint)0x85B3),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_RELEASED_APPLE")]
    Releasedapple = unchecked((uint)0x8A19),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_VOLATILE_APPLE")]
    Volatileapple = unchecked((uint)0x8A1A),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_RETAINED_APPLE")]
    Retainedapple = unchecked((uint)0x8A1B),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_UNDEFINED_APPLE")]
    Undefinedapple = unchecked((uint)0x8A1C),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_PURGEABLE_APPLE")]
    Purgeableapple = unchecked((uint)0x8A1D),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_RGB_422_APPLE")]
    Rgb422Apple = unchecked((uint)0x8A1F),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_UNSIGNED_SHORT_8_8_APPLE")]
    UnsignedShort8X8Apple = unchecked((uint)0x85BA),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_UNSIGNED_SHORT_8_8_REV_APPLE")]
    UnsignedShort8X8Revapple = unchecked((uint)0x85BB),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_RGB_RAW_422_APPLE")]
    RgbRaw422Apple = unchecked((uint)0x8A51),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_PACK_ROW_BYTES_APPLE")]
    PackRowBytesapple = unchecked((uint)0x8A15),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_UNPACK_ROW_BYTES_APPLE")]
    UnpackRowBytesapple = unchecked((uint)0x8A16),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_LIGHT_MODEL_SPECULAR_VECTOR_APPLE")]
    LightModelSpecularVectorapple = unchecked((uint)0x85B0),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_TEXTURE_RANGE_LENGTH_APPLE")]
    TextureRangeLengthapple = unchecked((uint)0x85B7),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_TEXTURE_RANGE_POINTER_APPLE")]
    TextureRangePointerapple = unchecked((uint)0x85B8),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_TEXTURE_STORAGE_HINT_APPLE")]
    TextureStorageHintapple = unchecked((uint)0x85BC),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_STORAGE_PRIVATE_APPLE")]
    StoragePrivateapple = unchecked((uint)0x85BD),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_STORAGE_CACHED_APPLE")]
    StorageCachedapple = unchecked((uint)0x85BE),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_STORAGE_SHARED_APPLE")]
    StorageSharedapple = unchecked((uint)0x85BF),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_TRANSFORM_HINT_APPLE")]
    TransformHintapple = unchecked((uint)0x85B1),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_VERTEX_ARRAY_BINDING_APPLE")]
    VertexArrayBindingapple = unchecked((uint)0x85B5),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_VERTEX_ARRAY_RANGE_APPLE")]
    VertexArrayRangeapple = unchecked((uint)0x851D),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_VERTEX_ARRAY_RANGE_LENGTH_APPLE")]
    VertexArrayRangeLengthapple = unchecked((uint)0x851E),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_VERTEX_ARRAY_STORAGE_HINT_APPLE")]
    VertexArrayStorageHintapple = unchecked((uint)0x851F),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_VERTEX_ARRAY_RANGE_POINTER_APPLE")]
    VertexArrayRangePointerapple = unchecked((uint)0x8521),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_STORAGE_CLIENT_APPLE")]
    StorageClientapple = unchecked((uint)0x85B4),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_VERTEX_ATTRIB_MAP1_APPLE")]
    VertexAttribMap1Apple = unchecked((uint)0x8A00),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_VERTEX_ATTRIB_MAP2_APPLE")]
    VertexAttribMap2Apple = unchecked((uint)0x8A01),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_VERTEX_ATTRIB_MAP1_SIZE_APPLE")]
    VertexAttribMap1Sizeapple = unchecked((uint)0x8A02),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_VERTEX_ATTRIB_MAP1_COEFF_APPLE")]
    VertexAttribMap1Coeffapple = unchecked((uint)0x8A03),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_VERTEX_ATTRIB_MAP1_ORDER_APPLE")]
    VertexAttribMap1Orderapple = unchecked((uint)0x8A04),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_VERTEX_ATTRIB_MAP1_DOMAIN_APPLE")]
    VertexAttribMap1Domainapple = unchecked((uint)0x8A05),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_VERTEX_ATTRIB_MAP2_SIZE_APPLE")]
    VertexAttribMap2Sizeapple = unchecked((uint)0x8A06),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_VERTEX_ATTRIB_MAP2_COEFF_APPLE")]
    VertexAttribMap2Coeffapple = unchecked((uint)0x8A07),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_VERTEX_ATTRIB_MAP2_ORDER_APPLE")]
    VertexAttribMap2Orderapple = unchecked((uint)0x8A08),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_VERTEX_ATTRIB_MAP2_DOMAIN_APPLE")]
    VertexAttribMap2Domainapple = unchecked((uint)0x8A09),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_YCBCR_422_APPLE")]
    Ycbcr422Apple = unchecked((uint)0x85B9),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_MAX_DRAW_BUFFERS_ATI")]
    MaxDrawBuffersati = unchecked((uint)0x8824),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_DRAW_BUFFER0_ATI")]
    DrawBuffer0Ati = unchecked((uint)0x8825),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_DRAW_BUFFER1_ATI")]
    DrawBuffer1Ati = unchecked((uint)0x8826),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_DRAW_BUFFER2_ATI")]
    DrawBuffer2Ati = unchecked((uint)0x8827),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_DRAW_BUFFER3_ATI")]
    DrawBuffer3Ati = unchecked((uint)0x8828),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_DRAW_BUFFER4_ATI")]
    DrawBuffer4Ati = unchecked((uint)0x8829),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_DRAW_BUFFER5_ATI")]
    DrawBuffer5Ati = unchecked((uint)0x882A),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_DRAW_BUFFER6_ATI")]
    DrawBuffer6Ati = unchecked((uint)0x882B),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_DRAW_BUFFER7_ATI")]
    DrawBuffer7Ati = unchecked((uint)0x882C),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_DRAW_BUFFER8_ATI")]
    DrawBuffer8Ati = unchecked((uint)0x882D),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_DRAW_BUFFER9_ATI")]
    DrawBuffer9Ati = unchecked((uint)0x882E),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_DRAW_BUFFER10_ATI")]
    DrawBuffer10Ati = unchecked((uint)0x882F),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_DRAW_BUFFER11_ATI")]
    DrawBuffer11Ati = unchecked((uint)0x8830),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_DRAW_BUFFER12_ATI")]
    DrawBuffer12Ati = unchecked((uint)0x8831),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_DRAW_BUFFER13_ATI")]
    DrawBuffer13Ati = unchecked((uint)0x8832),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_DRAW_BUFFER14_ATI")]
    DrawBuffer14Ati = unchecked((uint)0x8833),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_DRAW_BUFFER15_ATI")]
    DrawBuffer15Ati = unchecked((uint)0x8834),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_ELEMENT_ARRAY_ATI")]
    ElementArrayati = unchecked((uint)0x8768),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_ELEMENT_ARRAY_TYPE_ATI")]
    ElementArrayTypeati = unchecked((uint)0x8769),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_ELEMENT_ARRAY_POINTER_ATI")]
    ElementArrayPointerati = unchecked((uint)0x876A),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_BUMP_ROT_MATRIX_ATI")]
    BumpRotMatrixati = unchecked((uint)0x8775),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_BUMP_ROT_MATRIX_SIZE_ATI")]
    BumpRotMatrixSizeati = unchecked((uint)0x8776),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_BUMP_NUM_TEX_UNITS_ATI")]
    BumpNumTexUnitsati = unchecked((uint)0x8777),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_BUMP_TEX_UNITS_ATI")]
    BumpTexUnitsati = unchecked((uint)0x8778),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_DUDV_ATI")]
    Dudvati = unchecked((uint)0x8779),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_DU8DV8_ATI")]
    Du8Dv8Ati = unchecked((uint)0x877A),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_BUMP_ENVMAP_ATI")]
    BumpEnvmapati = unchecked((uint)0x877B),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_BUMP_TARGET_ATI")]
    BumpTargetati = unchecked((uint)0x877C),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_FRAGMENT_SHADER_ATI")]
    FragmentShaderati = unchecked((uint)0x8920),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_0_ATI")]
    Reg0Ati = unchecked((uint)0x8921),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_1_ATI")]
    Reg1Ati = unchecked((uint)0x8922),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_2_ATI")]
    Reg2Ati = unchecked((uint)0x8923),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_3_ATI")]
    Reg3Ati = unchecked((uint)0x8924),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_4_ATI")]
    Reg4Ati = unchecked((uint)0x8925),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_5_ATI")]
    Reg5Ati = unchecked((uint)0x8926),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_6_ATI")]
    Reg6Ati = unchecked((uint)0x8927),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_7_ATI")]
    Reg7Ati = unchecked((uint)0x8928),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_8_ATI")]
    Reg8Ati = unchecked((uint)0x8929),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_9_ATI")]
    Reg9Ati = unchecked((uint)0x892A),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_10_ATI")]
    Reg10Ati = unchecked((uint)0x892B),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_11_ATI")]
    Reg11Ati = unchecked((uint)0x892C),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_12_ATI")]
    Reg12Ati = unchecked((uint)0x892D),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_13_ATI")]
    Reg13Ati = unchecked((uint)0x892E),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_14_ATI")]
    Reg14Ati = unchecked((uint)0x892F),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_15_ATI")]
    Reg15Ati = unchecked((uint)0x8930),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_16_ATI")]
    Reg16Ati = unchecked((uint)0x8931),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_17_ATI")]
    Reg17Ati = unchecked((uint)0x8932),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_18_ATI")]
    Reg18Ati = unchecked((uint)0x8933),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_19_ATI")]
    Reg19Ati = unchecked((uint)0x8934),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_20_ATI")]
    Reg20Ati = unchecked((uint)0x8935),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_21_ATI")]
    Reg21Ati = unchecked((uint)0x8936),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_22_ATI")]
    Reg22Ati = unchecked((uint)0x8937),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_23_ATI")]
    Reg23Ati = unchecked((uint)0x8938),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_24_ATI")]
    Reg24Ati = unchecked((uint)0x8939),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_25_ATI")]
    Reg25Ati = unchecked((uint)0x893A),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_26_ATI")]
    Reg26Ati = unchecked((uint)0x893B),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_27_ATI")]
    Reg27Ati = unchecked((uint)0x893C),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_28_ATI")]
    Reg28Ati = unchecked((uint)0x893D),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_29_ATI")]
    Reg29Ati = unchecked((uint)0x893E),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_30_ATI")]
    Reg30Ati = unchecked((uint)0x893F),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_31_ATI")]
    Reg31Ati = unchecked((uint)0x8940),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_0_ATI")]
    Con0Ati = unchecked((uint)0x8941),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_1_ATI")]
    Con1Ati = unchecked((uint)0x8942),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_2_ATI")]
    Con2Ati = unchecked((uint)0x8943),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_3_ATI")]
    Con3Ati = unchecked((uint)0x8944),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_4_ATI")]
    Con4Ati = unchecked((uint)0x8945),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_5_ATI")]
    Con5Ati = unchecked((uint)0x8946),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_6_ATI")]
    Con6Ati = unchecked((uint)0x8947),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_7_ATI")]
    Con7Ati = unchecked((uint)0x8948),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_8_ATI")]
    Con8Ati = unchecked((uint)0x8949),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_9_ATI")]
    Con9Ati = unchecked((uint)0x894A),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_10_ATI")]
    Con10Ati = unchecked((uint)0x894B),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_11_ATI")]
    Con11Ati = unchecked((uint)0x894C),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_12_ATI")]
    Con12Ati = unchecked((uint)0x894D),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_13_ATI")]
    Con13Ati = unchecked((uint)0x894E),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_14_ATI")]
    Con14Ati = unchecked((uint)0x894F),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_15_ATI")]
    Con15Ati = unchecked((uint)0x8950),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_16_ATI")]
    Con16Ati = unchecked((uint)0x8951),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_17_ATI")]
    Con17Ati = unchecked((uint)0x8952),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_18_ATI")]
    Con18Ati = unchecked((uint)0x8953),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_19_ATI")]
    Con19Ati = unchecked((uint)0x8954),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_20_ATI")]
    Con20Ati = unchecked((uint)0x8955),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_21_ATI")]
    Con21Ati = unchecked((uint)0x8956),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_22_ATI")]
    Con22Ati = unchecked((uint)0x8957),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_23_ATI")]
    Con23Ati = unchecked((uint)0x8958),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_24_ATI")]
    Con24Ati = unchecked((uint)0x8959),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_25_ATI")]
    Con25Ati = unchecked((uint)0x895A),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_26_ATI")]
    Con26Ati = unchecked((uint)0x895B),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_27_ATI")]
    Con27Ati = unchecked((uint)0x895C),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_28_ATI")]
    Con28Ati = unchecked((uint)0x895D),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_29_ATI")]
    Con29Ati = unchecked((uint)0x895E),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_30_ATI")]
    Con30Ati = unchecked((uint)0x895F),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_31_ATI")]
    Con31Ati = unchecked((uint)0x8960),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_MOV_ATI")]
    Movati = unchecked((uint)0x8961),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_ADD_ATI")]
    Addati = unchecked((uint)0x8963),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_MUL_ATI")]
    Mulati = unchecked((uint)0x8964),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_SUB_ATI")]
    Subati = unchecked((uint)0x8965),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_DOT3_ATI")]
    Dot3Ati = unchecked((uint)0x8966),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_DOT4_ATI")]
    Dot4Ati = unchecked((uint)0x8967),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_MAD_ATI")]
    Madati = unchecked((uint)0x8968),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_LERP_ATI")]
    Lerpati = unchecked((uint)0x8969),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CND_ATI")]
    Cndati = unchecked((uint)0x896A),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CND0_ATI")]
    Cnd0Ati = unchecked((uint)0x896B),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_DOT2_ADD_ATI")]
    Dot2Addati = unchecked((uint)0x896C),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_SECONDARY_INTERPOLATOR_ATI")]
    SecondaryInterpolatorati = unchecked((uint)0x896D),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_NUM_FRAGMENT_REGISTERS_ATI")]
    NumFragmentRegistersati = unchecked((uint)0x896E),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_NUM_FRAGMENT_CONSTANTS_ATI")]
    NumFragmentConstantsati = unchecked((uint)0x896F),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_NUM_PASSES_ATI")]
    NumPassesati = unchecked((uint)0x8970),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_NUM_INSTRUCTIONS_PER_PASS_ATI")]
    NumInstructionsPerPassati = unchecked((uint)0x8971),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_NUM_INSTRUCTIONS_TOTAL_ATI")]
    NumInstructionsTotalati = unchecked((uint)0x8972),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_NUM_INPUT_INTERPOLATOR_COMPONENTS_ATI")]
    NumInputInterpolatorComponentsati = unchecked((uint)0x8973),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_NUM_LOOPBACK_COMPONENTS_ATI")]
    NumLoopbackComponentsati = unchecked((uint)0x8974),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_COLOR_ALPHA_PAIRING_ATI")]
    ColorAlphaPairingati = unchecked((uint)0x8975),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_SWIZZLE_STR_ATI")]
    SwizzleStrati = unchecked((uint)0x8976),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_SWIZZLE_STQ_ATI")]
    SwizzleStqati = unchecked((uint)0x8977),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_SWIZZLE_STR_DR_ATI")]
    SwizzleStrDrati = unchecked((uint)0x8978),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_SWIZZLE_STQ_DQ_ATI")]
    SwizzleStqDqati = unchecked((uint)0x8979),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_SWIZZLE_STRQ_ATI")]
    SwizzleStrqati = unchecked((uint)0x897A),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_SWIZZLE_STRQ_DQ_ATI")]
    SwizzleStrqDqati = unchecked((uint)0x897B),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_RED_BIT_ATI")]
    RedBitati = unchecked((uint)0x00000001),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_GREEN_BIT_ATI")]
    GreenBitati = unchecked((uint)0x00000002),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_BLUE_BIT_ATI")]
    BlueBitati = unchecked((uint)0x00000004),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_2X_BIT_ATI")]
    X2XBitati = unchecked((uint)0x00000001),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_4X_BIT_ATI")]
    X4XBitati = unchecked((uint)0x00000002),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_8X_BIT_ATI")]
    X8XBitati = unchecked((uint)0x00000004),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_HALF_BIT_ATI")]
    HalfBitati = unchecked((uint)0x00000008),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_QUARTER_BIT_ATI")]
    QuarterBitati = unchecked((uint)0x00000010),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_EIGHTH_BIT_ATI")]
    EighthBitati = unchecked((uint)0x00000020),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_SATURATE_BIT_ATI")]
    SaturateBitati = unchecked((uint)0x00000040),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_COMP_BIT_ATI")]
    CompBitati = unchecked((uint)0x00000002),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_NEGATE_BIT_ATI")]
    NegateBitati = unchecked((uint)0x00000004),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_BIAS_BIT_ATI")]
    BiasBitati = unchecked((uint)0x00000008),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_VBO_FREE_MEMORY_ATI")]
    VboFreeMemoryati = unchecked((uint)0x87FB),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_TEXTURE_FREE_MEMORY_ATI")]
    TextureFreeMemoryati = unchecked((uint)0x87FC),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_RENDERBUFFER_FREE_MEMORY_ATI")]
    RenderbufferFreeMemoryati = unchecked((uint)0x87FD),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_RGBA_FLOAT_MODE_ATI")]
    RgbaFloatModeati = unchecked((uint)0x8820),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_COLOR_CLEAR_UNCLAMPED_VALUE_ATI")]
    ColorClearUnclampedValueati = unchecked((uint)0x8835),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_PN_TRIANGLES_ATI")]
    PnTrianglesati = unchecked((uint)0x87F0),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_MAX_PN_TRIANGLES_TESSELATION_LEVEL_ATI")]
    MaxPnTrianglesTesselationLevelati = unchecked((uint)0x87F1),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_PN_TRIANGLES_POINT_MODE_ATI")]
    PnTrianglesPointModeati = unchecked((uint)0x87F2),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_PN_TRIANGLES_NORMAL_MODE_ATI")]
    PnTrianglesNormalModeati = unchecked((uint)0x87F3),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_PN_TRIANGLES_TESSELATION_LEVEL_ATI")]
    PnTrianglesTesselationLevelati = unchecked((uint)0x87F4),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_PN_TRIANGLES_POINT_MODE_LINEAR_ATI")]
    PnTrianglesPointModeLinearati = unchecked((uint)0x87F5),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_PN_TRIANGLES_POINT_MODE_CUBIC_ATI")]
    PnTrianglesPointModeCubicati = unchecked((uint)0x87F6),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_PN_TRIANGLES_NORMAL_MODE_LINEAR_ATI")]
    PnTrianglesNormalModeLinearati = unchecked((uint)0x87F7),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_PN_TRIANGLES_NORMAL_MODE_QUADRATIC_ATI")]
    PnTrianglesNormalModeQuadraticati = unchecked((uint)0x87F8),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_STENCIL_BACK_FUNC_ATI")]
    StencilBackFuncati = unchecked((uint)0x8800),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_STENCIL_BACK_FAIL_ATI")]
    StencilBackFailati = unchecked((uint)0x8801),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_STENCIL_BACK_PASS_DEPTH_FAIL_ATI")]
    StencilBackPassDepthFailati = unchecked((uint)0x8802),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_STENCIL_BACK_PASS_DEPTH_PASS_ATI")]
    StencilBackPassDepthPassati = unchecked((uint)0x8803),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_TEXT_FRAGMENT_SHADER_ATI")]
    TextFragmentShaderati = unchecked((uint)0x8200),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_MODULATE_ADD_ATI")]
    ModulateAddati = unchecked((uint)0x8744),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_MODULATE_SIGNED_ADD_ATI")]
    ModulateSignedAddati = unchecked((uint)0x8745),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_MODULATE_SUBTRACT_ATI")]
    ModulateSubtractati = unchecked((uint)0x8746),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_RGBA_FLOAT32_ATI")]
    RgbaFloat32Ati = unchecked((uint)0x8814),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_RGB_FLOAT32_ATI")]
    RgbFloat32Ati = unchecked((uint)0x8815),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_ALPHA_FLOAT32_ATI")]
    AlphaFloat32Ati = unchecked((uint)0x8816),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_INTENSITY_FLOAT32_ATI")]
    IntensityFloat32Ati = unchecked((uint)0x8817),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_LUMINANCE_FLOAT32_ATI")]
    LuminanceFloat32Ati = unchecked((uint)0x8818),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_LUMINANCE_ALPHA_FLOAT32_ATI")]
    LuminanceAlphaFloat32Ati = unchecked((uint)0x8819),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_RGBA_FLOAT16_ATI")]
    RgbaFloat16Ati = unchecked((uint)0x881A),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_RGB_FLOAT16_ATI")]
    RgbFloat16Ati = unchecked((uint)0x881B),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_ALPHA_FLOAT16_ATI")]
    AlphaFloat16Ati = unchecked((uint)0x881C),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_INTENSITY_FLOAT16_ATI")]
    IntensityFloat16Ati = unchecked((uint)0x881D),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_LUMINANCE_FLOAT16_ATI")]
    LuminanceFloat16Ati = unchecked((uint)0x881E),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_LUMINANCE_ALPHA_FLOAT16_ATI")]
    LuminanceAlphaFloat16Ati = unchecked((uint)0x881F),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_MIRROR_CLAMP_ATI")]
    MirrorClampati = unchecked((uint)0x8742),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_MIRROR_CLAMP_TO_EDGE_ATI")]
    MirrorClampToEdgeati = unchecked((uint)0x8743),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_STATIC_ATI")]
    Staticati = unchecked((uint)0x8760),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_DYNAMIC_ATI")]
    Dynamicati = unchecked((uint)0x8761),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_PRESERVE_ATI")]
    Preserveati = unchecked((uint)0x8762),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_DISCARD_ATI")]
    Discardati = unchecked((uint)0x8763),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_OBJECT_BUFFER_SIZE_ATI")]
    ObjectBufferSizeati = unchecked((uint)0x8764),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_OBJECT_BUFFER_USAGE_ATI")]
    ObjectBufferUsageati = unchecked((uint)0x8765),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_ARRAY_OBJECT_BUFFER_ATI")]
    ArrayObjectBufferati = unchecked((uint)0x8766),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_ARRAY_OBJECT_OFFSET_ATI")]
    ArrayObjectOffsetati = unchecked((uint)0x8767),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_MAX_VERTEX_STREAMS_ATI")]
    MaxVertexStreamsati = unchecked((uint)0x876B),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_VERTEX_STREAM0_ATI")]
    VertexStream0Ati = unchecked((uint)0x876C),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_VERTEX_STREAM1_ATI")]
    VertexStream1Ati = unchecked((uint)0x876D),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_VERTEX_STREAM2_ATI")]
    VertexStream2Ati = unchecked((uint)0x876E),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_VERTEX_STREAM3_ATI")]
    VertexStream3Ati = unchecked((uint)0x876F),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_VERTEX_STREAM4_ATI")]
    VertexStream4Ati = unchecked((uint)0x8770),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_VERTEX_STREAM5_ATI")]
    VertexStream5Ati = unchecked((uint)0x8771),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_VERTEX_STREAM6_ATI")]
    VertexStream6Ati = unchecked((uint)0x8772),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_VERTEX_STREAM7_ATI")]
    VertexStream7Ati = unchecked((uint)0x8773),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_VERTEX_SOURCE_ATI")]
    VertexSourceati = unchecked((uint)0x8774),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_422_EXT")]
    X422Ext = unchecked((uint)0x80CC),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_422_REV_EXT")]
    X422Revext = unchecked((uint)0x80CD),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_422_AVERAGE_EXT")]
    X422Averageext = unchecked((uint)0x80CE),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_422_REV_AVERAGE_EXT")]
    X422RevAverageext = unchecked((uint)0x80CF),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ABGR_EXT")]
    Abgrext = unchecked((uint)0x8000),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_BGR_EXT")]
    Bgrext = unchecked((uint)0x80E0),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_VERTEX_BINDABLE_UNIFORMS_EXT")]
    MaxVertexBindableUniformsext = unchecked((uint)0x8DE2),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_FRAGMENT_BINDABLE_UNIFORMS_EXT")]
    MaxFragmentBindableUniformsext = unchecked((uint)0x8DE3),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_GEOMETRY_BINDABLE_UNIFORMS_EXT")]
    MaxGeometryBindableUniformsext = unchecked((uint)0x8DE4),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_BINDABLE_UNIFORM_SIZE_EXT")]
    MaxBindableUniformSizeext = unchecked((uint)0x8DED),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNIFORM_BUFFER_EXT")]
    UniformBufferext = unchecked((uint)0x8DEE),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNIFORM_BUFFER_BINDING_EXT")]
    UniformBufferBindingext = unchecked((uint)0x8DEF),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CONSTANT_COLOR_EXT")]
    ConstantColorext = unchecked((uint)0x8001),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ONE_MINUS_CONSTANT_COLOR_EXT")]
    OneMinusConstantColorext = unchecked((uint)0x8002),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CONSTANT_ALPHA_EXT")]
    ConstantAlphaext = unchecked((uint)0x8003),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ONE_MINUS_CONSTANT_ALPHA_EXT")]
    OneMinusConstantAlphaext = unchecked((uint)0x8004),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_BLEND_COLOR_EXT")]
    BlendColorext = unchecked((uint)0x8005),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_BLEND_EQUATION_RGB_EXT")]
    BlendEquationRgbext = unchecked((uint)0x8009),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_BLEND_EQUATION_ALPHA_EXT")]
    BlendEquationAlphaext = unchecked((uint)0x883D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_BLEND_DST_RGB_EXT")]
    BlendDstRgbext = unchecked((uint)0x80C8),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_BLEND_SRC_RGB_EXT")]
    BlendSrcRgbext = unchecked((uint)0x80C9),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_BLEND_DST_ALPHA_EXT")]
    BlendDstAlphaext = unchecked((uint)0x80CA),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_BLEND_SRC_ALPHA_EXT")]
    BlendSrcAlphaext = unchecked((uint)0x80CB),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FUNC_ADD_EXT")]
    FuncAddext = unchecked((uint)0x8006),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_BLEND_EQUATION_EXT")]
    BlendEquationext = unchecked((uint)0x8009),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FUNC_SUBTRACT_EXT")]
    FuncSubtractext = unchecked((uint)0x800A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FUNC_REVERSE_SUBTRACT_EXT")]
    FuncReverseSubtractext = unchecked((uint)0x800B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CLIP_VOLUME_CLIPPING_HINT_EXT")]
    ClipVolumeClippingHintext = unchecked((uint)0x80F0),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CMYK_EXT")]
    Cmykext = unchecked((uint)0x800C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CMYKA_EXT")]
    Cmykaext = unchecked((uint)0x800D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PACK_CMYK_HINT_EXT")]
    PackCmykHintext = unchecked((uint)0x800E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNPACK_CMYK_HINT_EXT")]
    UnpackCmykHintext = unchecked((uint)0x800F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ARRAY_ELEMENT_LOCK_FIRST_EXT")]
    ArrayElementLockFirstext = unchecked((uint)0x81A8),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ARRAY_ELEMENT_LOCK_COUNT_EXT")]
    ArrayElementLockCountext = unchecked((uint)0x81A9),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CONVOLUTION_1D_EXT")]
    Convolution1Dext = unchecked((uint)0x8010),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CONVOLUTION_2D_EXT")]
    Convolution2Dext = unchecked((uint)0x8011),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SEPARABLE_2D_EXT")]
    Separable2Dext = unchecked((uint)0x8012),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CONVOLUTION_BORDER_MODE_EXT")]
    ConvolutionBorderModeext = unchecked((uint)0x8013),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CONVOLUTION_FILTER_SCALE_EXT")]
    ConvolutionFilterScaleext = unchecked((uint)0x8014),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CONVOLUTION_FILTER_BIAS_EXT")]
    ConvolutionFilterBiasext = unchecked((uint)0x8015),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_REDUCE_EXT")]
    Reduceext = unchecked((uint)0x8016),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CONVOLUTION_FORMAT_EXT")]
    ConvolutionFormatext = unchecked((uint)0x8017),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CONVOLUTION_WIDTH_EXT")]
    ConvolutionWidthext = unchecked((uint)0x8018),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CONVOLUTION_HEIGHT_EXT")]
    ConvolutionHeightext = unchecked((uint)0x8019),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_CONVOLUTION_WIDTH_EXT")]
    MaxConvolutionWidthext = unchecked((uint)0x801A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_CONVOLUTION_HEIGHT_EXT")]
    MaxConvolutionHeightext = unchecked((uint)0x801B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_POST_CONVOLUTION_RED_SCALE_EXT")]
    PostConvolutionRedScaleext = unchecked((uint)0x801C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_POST_CONVOLUTION_GREEN_SCALE_EXT")]
    PostConvolutionGreenScaleext = unchecked((uint)0x801D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_POST_CONVOLUTION_BLUE_SCALE_EXT")]
    PostConvolutionBlueScaleext = unchecked((uint)0x801E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_POST_CONVOLUTION_ALPHA_SCALE_EXT")]
    PostConvolutionAlphaScaleext = unchecked((uint)0x801F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_POST_CONVOLUTION_RED_BIAS_EXT")]
    PostConvolutionRedBiasext = unchecked((uint)0x8020),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_POST_CONVOLUTION_GREEN_BIAS_EXT")]
    PostConvolutionGreenBiasext = unchecked((uint)0x8021),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_POST_CONVOLUTION_BLUE_BIAS_EXT")]
    PostConvolutionBlueBiasext = unchecked((uint)0x8022),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_POST_CONVOLUTION_ALPHA_BIAS_EXT")]
    PostConvolutionAlphaBiasext = unchecked((uint)0x8023),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TANGENT_ARRAY_EXT")]
    TangentArrayext = unchecked((uint)0x8439),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_BINORMAL_ARRAY_EXT")]
    BinormalArrayext = unchecked((uint)0x843A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CURRENT_TANGENT_EXT")]
    CurrentTangentext = unchecked((uint)0x843B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CURRENT_BINORMAL_EXT")]
    CurrentBinormalext = unchecked((uint)0x843C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TANGENT_ARRAY_TYPE_EXT")]
    TangentArrayTypeext = unchecked((uint)0x843E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TANGENT_ARRAY_STRIDE_EXT")]
    TangentArrayStrideext = unchecked((uint)0x843F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_BINORMAL_ARRAY_TYPE_EXT")]
    BinormalArrayTypeext = unchecked((uint)0x8440),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_BINORMAL_ARRAY_STRIDE_EXT")]
    BinormalArrayStrideext = unchecked((uint)0x8441),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TANGENT_ARRAY_POINTER_EXT")]
    TangentArrayPointerext = unchecked((uint)0x8442),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_BINORMAL_ARRAY_POINTER_EXT")]
    BinormalArrayPointerext = unchecked((uint)0x8443),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAP1_TANGENT_EXT")]
    Map1Tangentext = unchecked((uint)0x8444),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAP2_TANGENT_EXT")]
    Map2Tangentext = unchecked((uint)0x8445),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAP1_BINORMAL_EXT")]
    Map1Binormalext = unchecked((uint)0x8446),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAP2_BINORMAL_EXT")]
    Map2Binormalext = unchecked((uint)0x8447),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CULL_VERTEX_EXT")]
    CullVertexext = unchecked((uint)0x81AA),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CULL_VERTEX_EYE_POSITION_EXT")]
    CullVertexEyePositionext = unchecked((uint)0x81AB),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CULL_VERTEX_OBJECT_POSITION_EXT")]
    CullVertexObjectPositionext = unchecked((uint)0x81AC),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PROGRAM_PIPELINE_OBJECT_EXT")]
    ProgramPipelineObjectext = unchecked((uint)0x8A4F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PROGRAM_OBJECT_EXT")]
    ProgramObjectext = unchecked((uint)0x8B40),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SHADER_OBJECT_EXT")]
    ShaderObjectext = unchecked((uint)0x8B48),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_BUFFER_OBJECT_EXT")]
    BufferObjectext = unchecked((uint)0x9151),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_QUERY_OBJECT_EXT")]
    QueryObjectext = unchecked((uint)0x9153),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VERTEX_ARRAY_OBJECT_EXT")]
    VertexArrayObjectext = unchecked((uint)0x9154),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DEPTH_BOUNDS_TEST_EXT")]
    DepthBoundsTestext = unchecked((uint)0x8890),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DEPTH_BOUNDS_EXT")]
    DepthBoundsext = unchecked((uint)0x8891),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PROGRAM_MATRIX_EXT")]
    ProgramMatrixext = unchecked((uint)0x8E2D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TRANSPOSE_PROGRAM_MATRIX_EXT")]
    TransposeProgramMatrixext = unchecked((uint)0x8E2E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PROGRAM_MATRIX_STACK_DEPTH_EXT")]
    ProgramMatrixStackDepthext = unchecked((uint)0x8E2F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_ELEMENTS_VERTICES_EXT")]
    MaxElementsVerticesext = unchecked((uint)0x80E8),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_ELEMENTS_INDICES_EXT")]
    MaxElementsIndicesext = unchecked((uint)0x80E9),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FOG_COORDINATE_SOURCE_EXT")]
    FogCoordinateSourceext = unchecked((uint)0x8450),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FOG_COORDINATE_EXT")]
    FogCoordinateext = unchecked((uint)0x8451),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAGMENT_DEPTH_EXT")]
    FragmentDepthext = unchecked((uint)0x8452),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CURRENT_FOG_COORDINATE_EXT")]
    CurrentFogCoordinateext = unchecked((uint)0x8453),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FOG_COORDINATE_ARRAY_TYPE_EXT")]
    FogCoordinateArrayTypeext = unchecked((uint)0x8454),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FOG_COORDINATE_ARRAY_STRIDE_EXT")]
    FogCoordinateArrayStrideext = unchecked((uint)0x8455),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FOG_COORDINATE_ARRAY_POINTER_EXT")]
    FogCoordinateArrayPointerext = unchecked((uint)0x8456),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FOG_COORDINATE_ARRAY_EXT")]
    FogCoordinateArrayext = unchecked((uint)0x8457),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_READ_FRAMEBUFFER_EXT")]
    ReadFramebufferext = unchecked((uint)0x8CA8),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DRAW_FRAMEBUFFER_EXT")]
    DrawFramebufferext = unchecked((uint)0x8CA9),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DRAW_FRAMEBUFFER_BINDING_EXT")]
    DrawFramebufferBindingext = unchecked((uint)0x8CA6),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_READ_FRAMEBUFFER_BINDING_EXT")]
    ReadFramebufferBindingext = unchecked((uint)0x8CAA),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SCALED_RESOLVE_FASTEST_EXT")]
    ScaledResolveFastestext = unchecked((uint)0x90BA),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SCALED_RESOLVE_NICEST_EXT")]
    ScaledResolveNicestext = unchecked((uint)0x90BB),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INVALID_FRAMEBUFFER_OPERATION_EXT")]
    InvalidFramebufferOperationext = unchecked((uint)0x0506),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_RENDERBUFFER_SIZE_EXT")]
    MaxRenderbufferSizeext = unchecked((uint)0x84E8),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_BINDING_EXT")]
    FramebufferBindingext = unchecked((uint)0x8CA6),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RENDERBUFFER_BINDING_EXT")]
    RenderbufferBindingext = unchecked((uint)0x8CA7),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_EXT")]
    FramebufferAttachmentObjectTypeext = unchecked((uint)0x8CD0),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_EXT")]
    FramebufferAttachmentObjectNameext = unchecked((uint)0x8CD1),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_EXT")]
    FramebufferAttachmentTextureLevelext = unchecked((uint)0x8CD2),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_EXT")]
    FramebufferAttachmentTextureCubeMapFaceext = unchecked((uint)0x8CD3),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_EXT")]
    FramebufferAttachmentTexture3DZoffsetext = unchecked((uint)0x8CD4),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_COMPLETE_EXT")]
    FramebufferCompleteext = unchecked((uint)0x8CD5),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_EXT")]
    FramebufferIncompleteAttachmentext = unchecked((uint)0x8CD6),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_EXT")]
    FramebufferIncompleteMissingAttachmentext = unchecked((uint)0x8CD7),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_EXT")]
    FramebufferIncompleteDimensionsext = unchecked((uint)0x8CD9),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_FORMATS_EXT")]
    FramebufferIncompleteFormatsext = unchecked((uint)0x8CDA),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER_EXT")]
    FramebufferIncompleteDrawBufferext = unchecked((uint)0x8CDB),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER_EXT")]
    FramebufferIncompleteReadBufferext = unchecked((uint)0x8CDC),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_UNSUPPORTED_EXT")]
    FramebufferUnsupportedext = unchecked((uint)0x8CDD),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_COLOR_ATTACHMENTS_EXT")]
    MaxColorAttachmentsext = unchecked((uint)0x8CDF),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ATTACHMENT0_EXT")]
    ColorAttachment0Ext = unchecked((uint)0x8CE0),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ATTACHMENT1_EXT")]
    ColorAttachment1Ext = unchecked((uint)0x8CE1),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ATTACHMENT2_EXT")]
    ColorAttachment2Ext = unchecked((uint)0x8CE2),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ATTACHMENT3_EXT")]
    ColorAttachment3Ext = unchecked((uint)0x8CE3),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ATTACHMENT4_EXT")]
    ColorAttachment4Ext = unchecked((uint)0x8CE4),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ATTACHMENT5_EXT")]
    ColorAttachment5Ext = unchecked((uint)0x8CE5),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ATTACHMENT6_EXT")]
    ColorAttachment6Ext = unchecked((uint)0x8CE6),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ATTACHMENT7_EXT")]
    ColorAttachment7Ext = unchecked((uint)0x8CE7),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ATTACHMENT8_EXT")]
    ColorAttachment8Ext = unchecked((uint)0x8CE8),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ATTACHMENT9_EXT")]
    ColorAttachment9Ext = unchecked((uint)0x8CE9),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ATTACHMENT10_EXT")]
    ColorAttachment10Ext = unchecked((uint)0x8CEA),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ATTACHMENT11_EXT")]
    ColorAttachment11Ext = unchecked((uint)0x8CEB),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ATTACHMENT12_EXT")]
    ColorAttachment12Ext = unchecked((uint)0x8CEC),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ATTACHMENT13_EXT")]
    ColorAttachment13Ext = unchecked((uint)0x8CED),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ATTACHMENT14_EXT")]
    ColorAttachment14Ext = unchecked((uint)0x8CEE),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ATTACHMENT15_EXT")]
    ColorAttachment15Ext = unchecked((uint)0x8CEF),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DEPTH_ATTACHMENT_EXT")]
    DepthAttachmentext = unchecked((uint)0x8D00),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_STENCIL_ATTACHMENT_EXT")]
    StencilAttachmentext = unchecked((uint)0x8D20),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_EXT")]
    Framebufferext = unchecked((uint)0x8D40),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RENDERBUFFER_EXT")]
    Renderbufferext = unchecked((uint)0x8D41),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RENDERBUFFER_WIDTH_EXT")]
    RenderbufferWidthext = unchecked((uint)0x8D42),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RENDERBUFFER_HEIGHT_EXT")]
    RenderbufferHeightext = unchecked((uint)0x8D43),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RENDERBUFFER_INTERNAL_FORMAT_EXT")]
    RenderbufferInternalFormatext = unchecked((uint)0x8D44),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_STENCIL_INDEX1_EXT")]
    StencilIndex1Ext = unchecked((uint)0x8D46),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_STENCIL_INDEX4_EXT")]
    StencilIndex4Ext = unchecked((uint)0x8D47),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_STENCIL_INDEX8_EXT")]
    StencilIndex8Ext = unchecked((uint)0x8D48),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_STENCIL_INDEX16_EXT")]
    StencilIndex16Ext = unchecked((uint)0x8D49),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RENDERBUFFER_RED_SIZE_EXT")]
    RenderbufferRedSizeext = unchecked((uint)0x8D50),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RENDERBUFFER_GREEN_SIZE_EXT")]
    RenderbufferGreenSizeext = unchecked((uint)0x8D51),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RENDERBUFFER_BLUE_SIZE_EXT")]
    RenderbufferBlueSizeext = unchecked((uint)0x8D52),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RENDERBUFFER_ALPHA_SIZE_EXT")]
    RenderbufferAlphaSizeext = unchecked((uint)0x8D53),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RENDERBUFFER_DEPTH_SIZE_EXT")]
    RenderbufferDepthSizeext = unchecked((uint)0x8D54),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RENDERBUFFER_STENCIL_SIZE_EXT")]
    RenderbufferStencilSizeext = unchecked((uint)0x8D55),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_SRGB_EXT")]
    FramebufferSrgbext = unchecked((uint)0x8DB9),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_SRGB_CAPABLE_EXT")]
    FramebufferSrgbCapableext = unchecked((uint)0x8DBA),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_GEOMETRY_SHADER_EXT")]
    GeometryShaderext = unchecked((uint)0x8DD9),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_GEOMETRY_VERTICES_OUT_EXT")]
    GeometryVerticesOutext = unchecked((uint)0x8DDA),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_GEOMETRY_INPUT_TYPE_EXT")]
    GeometryInputTypeext = unchecked((uint)0x8DDB),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_GEOMETRY_OUTPUT_TYPE_EXT")]
    GeometryOutputTypeext = unchecked((uint)0x8DDC),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_EXT")]
    MaxGeometryTextureImageUnitsext = unchecked((uint)0x8C29),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_GEOMETRY_VARYING_COMPONENTS_EXT")]
    MaxGeometryVaryingComponentsext = unchecked((uint)0x8DDD),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_VERTEX_VARYING_COMPONENTS_EXT")]
    MaxVertexVaryingComponentsext = unchecked((uint)0x8DDE),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_VARYING_COMPONENTS_EXT")]
    MaxVaryingComponentsext = unchecked((uint)0x8B4B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_EXT")]
    MaxGeometryUniformComponentsext = unchecked((uint)0x8DDF),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_GEOMETRY_OUTPUT_VERTICES_EXT")]
    MaxGeometryOutputVerticesext = unchecked((uint)0x8DE0),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_EXT")]
    MaxGeometryTotalOutputComponentsext = unchecked((uint)0x8DE1),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LINES_ADJACENCY_EXT")]
    LinesAdjacencyext = unchecked((uint)0x000A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LINE_STRIP_ADJACENCY_EXT")]
    LineStripAdjacencyext = unchecked((uint)0x000B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TRIANGLES_ADJACENCY_EXT")]
    TrianglesAdjacencyext = unchecked((uint)0x000C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TRIANGLE_STRIP_ADJACENCY_EXT")]
    TriangleStripAdjacencyext = unchecked((uint)0x000D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_EXT")]
    FramebufferIncompleteLayerTargetsext = unchecked((uint)0x8DA8),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_EXT")]
    FramebufferIncompleteLayerCountext = unchecked((uint)0x8DA9),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_LAYERED_EXT")]
    FramebufferAttachmentLayeredext = unchecked((uint)0x8DA7),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER_EXT")]
    FramebufferAttachmentTextureLayerext = unchecked((uint)0x8CD4),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PROGRAM_POINT_SIZE_EXT")]
    ProgramPointSizeext = unchecked((uint)0x8642),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SAMPLER_1D_ARRAY_EXT")]
    Sampler1DArrayext = unchecked((uint)0x8DC0),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SAMPLER_2D_ARRAY_EXT")]
    Sampler2DArrayext = unchecked((uint)0x8DC1),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SAMPLER_BUFFER_EXT")]
    SamplerBufferext = unchecked((uint)0x8DC2),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SAMPLER_1D_ARRAY_SHADOW_EXT")]
    Sampler1DArrayShadowext = unchecked((uint)0x8DC3),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SAMPLER_2D_ARRAY_SHADOW_EXT")]
    Sampler2DArrayShadowext = unchecked((uint)0x8DC4),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SAMPLER_CUBE_SHADOW_EXT")]
    SamplerCubeShadowext = unchecked((uint)0x8DC5),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_VEC2_EXT")]
    UnsignedIntVec2Ext = unchecked((uint)0x8DC6),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_VEC3_EXT")]
    UnsignedIntVec3Ext = unchecked((uint)0x8DC7),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_VEC4_EXT")]
    UnsignedIntVec4Ext = unchecked((uint)0x8DC8),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INT_SAMPLER_1D_EXT")]
    IntSampler1Dext = unchecked((uint)0x8DC9),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INT_SAMPLER_2D_EXT")]
    IntSampler2Dext = unchecked((uint)0x8DCA),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INT_SAMPLER_3D_EXT")]
    IntSampler3Dext = unchecked((uint)0x8DCB),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INT_SAMPLER_CUBE_EXT")]
    IntSamplerCubeext = unchecked((uint)0x8DCC),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INT_SAMPLER_2D_RECT_EXT")]
    IntSampler2DRectext = unchecked((uint)0x8DCD),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INT_SAMPLER_1D_ARRAY_EXT")]
    IntSampler1DArrayext = unchecked((uint)0x8DCE),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INT_SAMPLER_2D_ARRAY_EXT")]
    IntSampler2DArrayext = unchecked((uint)0x8DCF),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INT_SAMPLER_BUFFER_EXT")]
    IntSamplerBufferext = unchecked((uint)0x8DD0),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_SAMPLER_1D_EXT")]
    UnsignedIntSampler1Dext = unchecked((uint)0x8DD1),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_SAMPLER_2D_EXT")]
    UnsignedIntSampler2Dext = unchecked((uint)0x8DD2),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_SAMPLER_3D_EXT")]
    UnsignedIntSampler3Dext = unchecked((uint)0x8DD3),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_SAMPLER_CUBE_EXT")]
    UnsignedIntSamplerCubeext = unchecked((uint)0x8DD4),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_SAMPLER_2D_RECT_EXT")]
    UnsignedIntSampler2DRectext = unchecked((uint)0x8DD5),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_SAMPLER_1D_ARRAY_EXT")]
    UnsignedIntSampler1DArrayext = unchecked((uint)0x8DD6),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_SAMPLER_2D_ARRAY_EXT")]
    UnsignedIntSampler2DArrayext = unchecked((uint)0x8DD7),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_SAMPLER_BUFFER_EXT")]
    UnsignedIntSamplerBufferext = unchecked((uint)0x8DD8),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MIN_PROGRAM_TEXEL_OFFSET_EXT")]
    MinProgramTexelOffsetext = unchecked((uint)0x8904),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_PROGRAM_TEXEL_OFFSET_EXT")]
    MaxProgramTexelOffsetext = unchecked((uint)0x8905),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VERTEX_ATTRIB_ARRAY_INTEGER_EXT")]
    VertexAttribArrayIntegerext = unchecked((uint)0x88FD),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HISTOGRAM_EXT")]
    Histogramext = unchecked((uint)0x8024),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PROXY_HISTOGRAM_EXT")]
    ProxyHistogramext = unchecked((uint)0x8025),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HISTOGRAM_WIDTH_EXT")]
    HistogramWidthext = unchecked((uint)0x8026),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HISTOGRAM_FORMAT_EXT")]
    HistogramFormatext = unchecked((uint)0x8027),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HISTOGRAM_RED_SIZE_EXT")]
    HistogramRedSizeext = unchecked((uint)0x8028),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HISTOGRAM_GREEN_SIZE_EXT")]
    HistogramGreenSizeext = unchecked((uint)0x8029),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HISTOGRAM_BLUE_SIZE_EXT")]
    HistogramBlueSizeext = unchecked((uint)0x802A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HISTOGRAM_ALPHA_SIZE_EXT")]
    HistogramAlphaSizeext = unchecked((uint)0x802B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HISTOGRAM_LUMINANCE_SIZE_EXT")]
    HistogramLuminanceSizeext = unchecked((uint)0x802C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HISTOGRAM_SINK_EXT")]
    HistogramSinkext = unchecked((uint)0x802D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MINMAX_EXT")]
    Minmaxext = unchecked((uint)0x802E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MINMAX_FORMAT_EXT")]
    MinmaxFormatext = unchecked((uint)0x802F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MINMAX_SINK_EXT")]
    MinmaxSinkext = unchecked((uint)0x8030),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TABLE_TOO_LARGE_EXT")]
    TableTooLargeext = unchecked((uint)0x8031),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_IUI_V2F_EXT")]
    IuiV2Fext = unchecked((uint)0x81AD),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_IUI_V3F_EXT")]
    IuiV3Fext = unchecked((uint)0x81AE),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_IUI_N3F_V2F_EXT")]
    IuiN3FV2Fext = unchecked((uint)0x81AF),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_IUI_N3F_V3F_EXT")]
    IuiN3FV3Fext = unchecked((uint)0x81B0),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_T2F_IUI_V2F_EXT")]
    T2FIuiV2Fext = unchecked((uint)0x81B1),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_T2F_IUI_V3F_EXT")]
    T2FIuiV3Fext = unchecked((uint)0x81B2),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_T2F_IUI_N3F_V2F_EXT")]
    T2FIuiN3FV2Fext = unchecked((uint)0x81B3),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_T2F_IUI_N3F_V3F_EXT")]
    T2FIuiN3FV3Fext = unchecked((uint)0x81B4),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INDEX_TEST_EXT")]
    IndexTestext = unchecked((uint)0x81B5),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INDEX_TEST_FUNC_EXT")]
    IndexTestFuncext = unchecked((uint)0x81B6),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INDEX_TEST_REF_EXT")]
    IndexTestRefext = unchecked((uint)0x81B7),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INDEX_MATERIAL_EXT")]
    IndexMaterialext = unchecked((uint)0x81B8),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INDEX_MATERIAL_PARAMETER_EXT")]
    IndexMaterialParameterext = unchecked((uint)0x81B9),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INDEX_MATERIAL_FACE_EXT")]
    IndexMaterialFaceext = unchecked((uint)0x81BA),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAGMENT_MATERIAL_EXT")]
    FragmentMaterialext = unchecked((uint)0x8349),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAGMENT_NORMAL_EXT")]
    FragmentNormalext = unchecked((uint)0x834A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAGMENT_COLOR_EXT")]
    FragmentColorext = unchecked((uint)0x834C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ATTENUATION_EXT")]
    Attenuationext = unchecked((uint)0x834D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SHADOW_ATTENUATION_EXT")]
    ShadowAttenuationext = unchecked((uint)0x834E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_APPLICATION_MODE_EXT")]
    TextureApplicationModeext = unchecked((uint)0x834F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_LIGHT_EXT")]
    TextureLightext = unchecked((uint)0x8350),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_MATERIAL_FACE_EXT")]
    TextureMaterialFaceext = unchecked((uint)0x8351),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_MATERIAL_PARAMETER_EXT")]
    TextureMaterialParameterext = unchecked((uint)0x8352),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_TILING_EXT")]
    TextureTilingext = unchecked((uint)0x9580),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DEDICATED_MEMORY_OBJECT_EXT")]
    DedicatedMemoryObjectext = unchecked((uint)0x9581),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PROTECTED_MEMORY_OBJECT_EXT")]
    ProtectedMemoryObjectext = unchecked((uint)0x959B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_NUM_TILING_TYPES_EXT")]
    NumTilingTypesext = unchecked((uint)0x9582),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TILING_TYPES_EXT")]
    TilingTypesext = unchecked((uint)0x9583),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OPTIMAL_TILING_EXT")]
    OptimalTilingext = unchecked((uint)0x9584),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LINEAR_TILING_EXT")]
    LinearTilingext = unchecked((uint)0x9585),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_NUM_DEVICE_UUIDS_EXT")]
    NumDeviceUuidsext = unchecked((uint)0x9596),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DEVICE_UUID_EXT")]
    DeviceUuidext = unchecked((uint)0x9597),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DRIVER_UUID_EXT")]
    DriverUuidext = unchecked((uint)0x9598),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UUID_SIZE_EXT")]
    UuidSizeext = unchecked((uint)16),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HANDLE_TYPE_OPAQUE_FD_EXT")]
    HandleTypeOpaqueFdext = unchecked((uint)0x9586),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HANDLE_TYPE_OPAQUE_WIN32_EXT")]
    HandleTypeOpaqueWin32Ext = unchecked((uint)0x9587),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HANDLE_TYPE_OPAQUE_WIN32_KMT_EXT")]
    HandleTypeOpaqueWin32Kmtext = unchecked((uint)0x9588),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DEVICE_LUID_EXT")]
    DeviceLuidext = unchecked((uint)0x9599),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DEVICE_NODE_MASK_EXT")]
    DeviceNodeMaskext = unchecked((uint)0x959A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LUID_SIZE_EXT")]
    LuidSizeext = unchecked((uint)8),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HANDLE_TYPE_D3D12_TILEPOOL_EXT")]
    HandleTypeD3D12Tilepoolext = unchecked((uint)0x9589),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HANDLE_TYPE_D3D12_RESOURCE_EXT")]
    HandleTypeD3D12Resourceext = unchecked((uint)0x958A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HANDLE_TYPE_D3D11_IMAGE_EXT")]
    HandleTypeD3D11Imageext = unchecked((uint)0x958B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HANDLE_TYPE_D3D11_IMAGE_KMT_EXT")]
    HandleTypeD3D11ImageKmtext = unchecked((uint)0x958C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MULTISAMPLE_EXT")]
    Multisampleext = unchecked((uint)0x809D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SAMPLE_ALPHA_TO_MASK_EXT")]
    SampleAlphaToMaskext = unchecked((uint)0x809E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SAMPLE_ALPHA_TO_ONE_EXT")]
    SampleAlphaToOneext = unchecked((uint)0x809F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SAMPLE_MASK_EXT")]
    SampleMaskext = unchecked((uint)0x80A0),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_1PASS_EXT")]
    X1Passext = unchecked((uint)0x80A1),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_2PASS_0_EXT")]
    X2Pass0Ext = unchecked((uint)0x80A2),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_2PASS_1_EXT")]
    X2Pass1Ext = unchecked((uint)0x80A3),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_4PASS_0_EXT")]
    X4Pass0Ext = unchecked((uint)0x80A4),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_4PASS_1_EXT")]
    X4Pass1Ext = unchecked((uint)0x80A5),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_4PASS_2_EXT")]
    X4Pass2Ext = unchecked((uint)0x80A6),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_4PASS_3_EXT")]
    X4Pass3Ext = unchecked((uint)0x80A7),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SAMPLE_BUFFERS_EXT")]
    SampleBuffersext = unchecked((uint)0x80A8),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SAMPLES_EXT")]
    Samplesext = unchecked((uint)0x80A9),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SAMPLE_MASK_VALUE_EXT")]
    SampleMaskValueext = unchecked((uint)0x80AA),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SAMPLE_MASK_INVERT_EXT")]
    SampleMaskInvertext = unchecked((uint)0x80AB),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SAMPLE_PATTERN_EXT")]
    SamplePatternext = unchecked((uint)0x80AC),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MULTISAMPLE_BIT_EXT")]
    MultisampleBitext = unchecked((uint)0x20000000),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DEPTH_STENCIL_EXT")]
    DepthStencilext = unchecked((uint)0x84F9),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_24_8_EXT")]
    UnsignedInt24X8Ext = unchecked((uint)0x84FA),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DEPTH24_STENCIL8_EXT")]
    Depth24Stencil8Ext = unchecked((uint)0x88F0),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_STENCIL_SIZE_EXT")]
    TextureStencilSizeext = unchecked((uint)0x88F1),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_R11F_G11F_B10F_EXT")]
    R11FG11FB10Fext = unchecked((uint)0x8C3A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_10F_11F_11F_REV_EXT")]
    UnsignedInt10F11F11FRevext = unchecked((uint)0x8C3B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGBA_SIGNED_COMPONENTS_EXT")]
    RgbaSignedComponentsext = unchecked((uint)0x8C3C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_BYTE_3_3_2_EXT")]
    UnsignedByte3X3X2Ext = unchecked((uint)0x8032),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_SHORT_4_4_4_4_EXT")]
    UnsignedShort4X4X4X4Ext = unchecked((uint)0x8033),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_SHORT_5_5_5_1_EXT")]
    UnsignedShort5X5X5X1Ext = unchecked((uint)0x8034),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_8_8_8_8_EXT")]
    UnsignedInt8X8X8X8Ext = unchecked((uint)0x8035),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_10_10_10_2_EXT")]
    UnsignedInt10X10X10X2Ext = unchecked((uint)0x8036),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_INDEX1_EXT")]
    ColorIndex1Ext = unchecked((uint)0x80E2),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_INDEX2_EXT")]
    ColorIndex2Ext = unchecked((uint)0x80E3),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_INDEX4_EXT")]
    ColorIndex4Ext = unchecked((uint)0x80E4),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_INDEX8_EXT")]
    ColorIndex8Ext = unchecked((uint)0x80E5),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_INDEX12_EXT")]
    ColorIndex12Ext = unchecked((uint)0x80E6),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_INDEX16_EXT")]
    ColorIndex16Ext = unchecked((uint)0x80E7),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_INDEX_SIZE_EXT")]
    TextureIndexSizeext = unchecked((uint)0x80ED),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PIXEL_PACK_BUFFER_EXT")]
    PixelPackBufferext = unchecked((uint)0x88EB),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PIXEL_UNPACK_BUFFER_EXT")]
    PixelUnpackBufferext = unchecked((uint)0x88EC),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PIXEL_PACK_BUFFER_BINDING_EXT")]
    PixelPackBufferBindingext = unchecked((uint)0x88ED),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PIXEL_UNPACK_BUFFER_BINDING_EXT")]
    PixelUnpackBufferBindingext = unchecked((uint)0x88EF),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PIXEL_TRANSFORM_2D_EXT")]
    PixelTransform2Dext = unchecked((uint)0x8330),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PIXEL_MAG_FILTER_EXT")]
    PixelMagFilterext = unchecked((uint)0x8331),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PIXEL_MIN_FILTER_EXT")]
    PixelMinFilterext = unchecked((uint)0x8332),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PIXEL_CUBIC_WEIGHT_EXT")]
    PixelCubicWeightext = unchecked((uint)0x8333),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CUBIC_EXT")]
    Cubicext = unchecked((uint)0x8334),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_AVERAGE_EXT")]
    Averageext = unchecked((uint)0x8335),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT")]
    PixelTransform2DStackDepthext = unchecked((uint)0x8336),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT")]
    MaxPixelTransform2DStackDepthext = unchecked((uint)0x8337),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PIXEL_TRANSFORM_2D_MATRIX_EXT")]
    PixelTransform2DMatrixext = unchecked((uint)0x8338),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_POINT_SIZE_MIN_EXT")]
    PointSizeMinext = unchecked((uint)0x8126),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_POINT_SIZE_MAX_EXT")]
    PointSizeMaxext = unchecked((uint)0x8127),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_POINT_FADE_THRESHOLD_SIZE_EXT")]
    PointFadeThresholdSizeext = unchecked((uint)0x8128),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DISTANCE_ATTENUATION_EXT")]
    DistanceAttenuationext = unchecked((uint)0x8129),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_POLYGON_OFFSET_EXT")]
    PolygonOffsetext = unchecked((uint)0x8037),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_POLYGON_OFFSET_FACTOR_EXT")]
    PolygonOffsetFactorext = unchecked((uint)0x8038),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_POLYGON_OFFSET_BIAS_EXT")]
    PolygonOffsetBiasext = unchecked((uint)0x8039),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_POLYGON_OFFSET_CLAMP_EXT")]
    PolygonOffsetClampext = unchecked((uint)0x8E1B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION_EXT")]
    QuadsFollowProvokingVertexConventionext = unchecked((uint)0x8E4C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FIRST_VERTEX_CONVENTION_EXT")]
    FirstVertexConventionext = unchecked((uint)0x8E4D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LAST_VERTEX_CONVENTION_EXT")]
    LastVertexConventionext = unchecked((uint)0x8E4E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PROVOKING_VERTEX_EXT")]
    ProvokingVertexext = unchecked((uint)0x8E4F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RASTER_MULTISAMPLE_EXT")]
    RasterMultisampleext = unchecked((uint)0x9327),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RASTER_SAMPLES_EXT")]
    RasterSamplesext = unchecked((uint)0x9328),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_RASTER_SAMPLES_EXT")]
    MaxRasterSamplesext = unchecked((uint)0x9329),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RASTER_FIXED_SAMPLE_LOCATIONS_EXT")]
    RasterFixedSampleLocationsext = unchecked((uint)0x932A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MULTISAMPLE_RASTERIZATION_ALLOWED_EXT")]
    MultisampleRasterizationAllowedext = unchecked((uint)0x932B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_EFFECTIVE_RASTER_SAMPLES_EXT")]
    EffectiveRasterSamplesext = unchecked((uint)0x932C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RESCALE_NORMAL_EXT")]
    RescaleNormalext = unchecked((uint)0x803A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_SUM_EXT")]
    ColorSumext = unchecked((uint)0x8458),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CURRENT_SECONDARY_COLOR_EXT")]
    CurrentSecondaryColorext = unchecked((uint)0x8459),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SECONDARY_COLOR_ARRAY_SIZE_EXT")]
    SecondaryColorArraySizeext = unchecked((uint)0x845A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SECONDARY_COLOR_ARRAY_TYPE_EXT")]
    SecondaryColorArrayTypeext = unchecked((uint)0x845B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SECONDARY_COLOR_ARRAY_STRIDE_EXT")]
    SecondaryColorArrayStrideext = unchecked((uint)0x845C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SECONDARY_COLOR_ARRAY_POINTER_EXT")]
    SecondaryColorArrayPointerext = unchecked((uint)0x845D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SECONDARY_COLOR_ARRAY_EXT")]
    SecondaryColorArrayext = unchecked((uint)0x845E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LAYOUT_GENERAL_EXT")]
    LayoutGeneralext = unchecked((uint)0x958D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LAYOUT_COLOR_ATTACHMENT_EXT")]
    LayoutColorAttachmentext = unchecked((uint)0x958E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LAYOUT_DEPTH_STENCIL_ATTACHMENT_EXT")]
    LayoutDepthStencilAttachmentext = unchecked((uint)0x958F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LAYOUT_DEPTH_STENCIL_READ_ONLY_EXT")]
    LayoutDepthStencilReadOnlyext = unchecked((uint)0x9590),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LAYOUT_SHADER_READ_ONLY_EXT")]
    LayoutShaderReadOnlyext = unchecked((uint)0x9591),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LAYOUT_TRANSFER_SRC_EXT")]
    LayoutTransferSrcext = unchecked((uint)0x9592),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LAYOUT_TRANSFER_DST_EXT")]
    LayoutTransferDstext = unchecked((uint)0x9593),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_EXT")]
    LayoutDepthReadOnlyStencilAttachmentext = unchecked((uint)0x9530),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_EXT")]
    LayoutDepthAttachmentStencilReadOnlyext = unchecked((uint)0x9531),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HANDLE_TYPE_D3D12_FENCE_EXT")]
    HandleTypeD3D12Fenceext = unchecked((uint)0x9594),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_D3D12_FENCE_VALUE_EXT")]
    D3D12FenceValueext = unchecked((uint)0x9595),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ACTIVE_PROGRAM_EXT")]
    ActiveProgramext = unchecked((uint)0x8259),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LIGHT_MODEL_COLOR_CONTROL_EXT")]
    LightModelColorControlext = unchecked((uint)0x81F8),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SINGLE_COLOR_EXT")]
    SingleColorext = unchecked((uint)0x81F9),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SEPARATE_SPECULAR_COLOR_EXT")]
    SeparateSpecularColorext = unchecked((uint)0x81FA),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAGMENT_SHADER_DISCARDS_SAMPLES_EXT")]
    FragmentShaderDiscardsSamplesext = unchecked((uint)0x8A52),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_IMAGE_UNITS_EXT")]
    MaxImageUnitsext = unchecked((uint)0x8F38),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS_EXT")]
    MaxCombinedImageUnitsAndFragmentOutputsext = unchecked((uint)0x8F39),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_IMAGE_BINDING_NAME_EXT")]
    ImageBindingNameext = unchecked((uint)0x8F3A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_IMAGE_BINDING_LEVEL_EXT")]
    ImageBindingLevelext = unchecked((uint)0x8F3B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_IMAGE_BINDING_LAYERED_EXT")]
    ImageBindingLayeredext = unchecked((uint)0x8F3C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_IMAGE_BINDING_LAYER_EXT")]
    ImageBindingLayerext = unchecked((uint)0x8F3D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_IMAGE_BINDING_ACCESS_EXT")]
    ImageBindingAccessext = unchecked((uint)0x8F3E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_IMAGE_1D_EXT")]
    Image1Dext = unchecked((uint)0x904C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_IMAGE_2D_EXT")]
    Image2Dext = unchecked((uint)0x904D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_IMAGE_3D_EXT")]
    Image3Dext = unchecked((uint)0x904E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_IMAGE_2D_RECT_EXT")]
    Image2DRectext = unchecked((uint)0x904F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_IMAGE_CUBE_EXT")]
    ImageCubeext = unchecked((uint)0x9050),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_IMAGE_BUFFER_EXT")]
    ImageBufferext = unchecked((uint)0x9051),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_IMAGE_1D_ARRAY_EXT")]
    Image1DArrayext = unchecked((uint)0x9052),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_IMAGE_2D_ARRAY_EXT")]
    Image2DArrayext = unchecked((uint)0x9053),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_IMAGE_CUBE_MAP_ARRAY_EXT")]
    ImageCubeMapArrayext = unchecked((uint)0x9054),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_IMAGE_2D_MULTISAMPLE_EXT")]
    Image2DMultisampleext = unchecked((uint)0x9055),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_IMAGE_2D_MULTISAMPLE_ARRAY_EXT")]
    Image2DMultisampleArrayext = unchecked((uint)0x9056),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INT_IMAGE_1D_EXT")]
    IntImage1Dext = unchecked((uint)0x9057),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INT_IMAGE_2D_EXT")]
    IntImage2Dext = unchecked((uint)0x9058),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INT_IMAGE_3D_EXT")]
    IntImage3Dext = unchecked((uint)0x9059),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INT_IMAGE_2D_RECT_EXT")]
    IntImage2DRectext = unchecked((uint)0x905A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INT_IMAGE_CUBE_EXT")]
    IntImageCubeext = unchecked((uint)0x905B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INT_IMAGE_BUFFER_EXT")]
    IntImageBufferext = unchecked((uint)0x905C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INT_IMAGE_1D_ARRAY_EXT")]
    IntImage1DArrayext = unchecked((uint)0x905D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INT_IMAGE_2D_ARRAY_EXT")]
    IntImage2DArrayext = unchecked((uint)0x905E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INT_IMAGE_CUBE_MAP_ARRAY_EXT")]
    IntImageCubeMapArrayext = unchecked((uint)0x905F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INT_IMAGE_2D_MULTISAMPLE_EXT")]
    IntImage2DMultisampleext = unchecked((uint)0x9060),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT")]
    IntImage2DMultisampleArrayext = unchecked((uint)0x9061),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_IMAGE_1D_EXT")]
    UnsignedIntImage1Dext = unchecked((uint)0x9062),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_IMAGE_2D_EXT")]
    UnsignedIntImage2Dext = unchecked((uint)0x9063),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_IMAGE_3D_EXT")]
    UnsignedIntImage3Dext = unchecked((uint)0x9064),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_IMAGE_2D_RECT_EXT")]
    UnsignedIntImage2DRectext = unchecked((uint)0x9065),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_IMAGE_CUBE_EXT")]
    UnsignedIntImageCubeext = unchecked((uint)0x9066),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_IMAGE_BUFFER_EXT")]
    UnsignedIntImageBufferext = unchecked((uint)0x9067),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_IMAGE_1D_ARRAY_EXT")]
    UnsignedIntImage1DArrayext = unchecked((uint)0x9068),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_IMAGE_2D_ARRAY_EXT")]
    UnsignedIntImage2DArrayext = unchecked((uint)0x9069),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_EXT")]
    UnsignedIntImageCubeMapArrayext = unchecked((uint)0x906A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_EXT")]
    UnsignedIntImage2DMultisampleext = unchecked((uint)0x906B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT")]
    UnsignedIntImage2DMultisampleArrayext = unchecked((uint)0x906C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_IMAGE_SAMPLES_EXT")]
    MaxImageSamplesext = unchecked((uint)0x906D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_IMAGE_BINDING_FORMAT_EXT")]
    ImageBindingFormatext = unchecked((uint)0x906E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT_EXT")]
    VertexAttribArrayBarrierBitext = unchecked((uint)0x00000001),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ELEMENT_ARRAY_BARRIER_BIT_EXT")]
    ElementArrayBarrierBitext = unchecked((uint)0x00000002),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNIFORM_BARRIER_BIT_EXT")]
    UniformBarrierBitext = unchecked((uint)0x00000004),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_FETCH_BARRIER_BIT_EXT")]
    TextureFetchBarrierBitext = unchecked((uint)0x00000008),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SHADER_IMAGE_ACCESS_BARRIER_BIT_EXT")]
    ShaderImageAccessBarrierBitext = unchecked((uint)0x00000020),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMMAND_BARRIER_BIT_EXT")]
    CommandBarrierBitext = unchecked((uint)0x00000040),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PIXEL_BUFFER_BARRIER_BIT_EXT")]
    PixelBufferBarrierBitext = unchecked((uint)0x00000080),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_UPDATE_BARRIER_BIT_EXT")]
    TextureUpdateBarrierBitext = unchecked((uint)0x00000100),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_BUFFER_UPDATE_BARRIER_BIT_EXT")]
    BufferUpdateBarrierBitext = unchecked((uint)0x00000200),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_BARRIER_BIT_EXT")]
    FramebufferBarrierBitext = unchecked((uint)0x00000400),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TRANSFORM_FEEDBACK_BARRIER_BIT_EXT")]
    TransformFeedbackBarrierBitext = unchecked((uint)0x00000800),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ATOMIC_COUNTER_BARRIER_BIT_EXT")]
    AtomicCounterBarrierBitext = unchecked((uint)0x00001000),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ALL_BARRIER_BITS_EXT")]
    AllBarrierBitsext = unchecked((uint)0xFFFFFFFF),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SHARED_TEXTURE_PALETTE_EXT")]
    SharedTexturePaletteext = unchecked((uint)0x81FB),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_STENCIL_TAG_BITS_EXT")]
    StencilTagBitsext = unchecked((uint)0x88F2),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_STENCIL_CLEAR_TAG_VALUE_EXT")]
    StencilClearTagValueext = unchecked((uint)0x88F3),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_STENCIL_TEST_TWO_SIDE_EXT")]
    StencilTestTwoSideext = unchecked((uint)0x8910),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ACTIVE_STENCIL_FACE_EXT")]
    ActiveStencilFaceext = unchecked((uint)0x8911),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INCR_WRAP_EXT")]
    IncrWrapext = unchecked((uint)0x8507),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DECR_WRAP_EXT")]
    DecrWrapext = unchecked((uint)0x8508),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ALPHA4_EXT")]
    Alpha4Ext = unchecked((uint)0x803B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ALPHA12_EXT")]
    Alpha12Ext = unchecked((uint)0x803D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ALPHA16_EXT")]
    Alpha16Ext = unchecked((uint)0x803E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LUMINANCE4_EXT")]
    Luminance4Ext = unchecked((uint)0x803F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LUMINANCE12_EXT")]
    Luminance12Ext = unchecked((uint)0x8041),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LUMINANCE16_EXT")]
    Luminance16Ext = unchecked((uint)0x8042),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LUMINANCE4_ALPHA4_EXT")]
    Luminance4Alpha4Ext = unchecked((uint)0x8043),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LUMINANCE6_ALPHA2_EXT")]
    Luminance6Alpha2Ext = unchecked((uint)0x8044),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LUMINANCE12_ALPHA4_EXT")]
    Luminance12Alpha4Ext = unchecked((uint)0x8046),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LUMINANCE12_ALPHA12_EXT")]
    Luminance12Alpha12Ext = unchecked((uint)0x8047),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LUMINANCE16_ALPHA16_EXT")]
    Luminance16Alpha16Ext = unchecked((uint)0x8048),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INTENSITY_EXT")]
    Intensityext = unchecked((uint)0x8049),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INTENSITY4_EXT")]
    Intensity4Ext = unchecked((uint)0x804A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INTENSITY8_EXT")]
    Intensity8Ext = unchecked((uint)0x804B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INTENSITY12_EXT")]
    Intensity12Ext = unchecked((uint)0x804C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INTENSITY16_EXT")]
    Intensity16Ext = unchecked((uint)0x804D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGB2_EXT")]
    Rgb2Ext = unchecked((uint)0x804E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGB4_EXT")]
    Rgb4Ext = unchecked((uint)0x804F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGB5_EXT")]
    Rgb5Ext = unchecked((uint)0x8050),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGB8_EXT")]
    Rgb8Ext = unchecked((uint)0x8051),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGB12_EXT")]
    Rgb12Ext = unchecked((uint)0x8053),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGB16_EXT")]
    Rgb16Ext = unchecked((uint)0x8054),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGBA2_EXT")]
    Rgba2Ext = unchecked((uint)0x8055),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGBA4_EXT")]
    Rgba4Ext = unchecked((uint)0x8056),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGB5_A1_EXT")]
    Rgb5A1Ext = unchecked((uint)0x8057),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGBA8_EXT")]
    Rgba8Ext = unchecked((uint)0x8058),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGBA12_EXT")]
    Rgba12Ext = unchecked((uint)0x805A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGBA16_EXT")]
    Rgba16Ext = unchecked((uint)0x805B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_RED_SIZE_EXT")]
    TextureRedSizeext = unchecked((uint)0x805C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_GREEN_SIZE_EXT")]
    TextureGreenSizeext = unchecked((uint)0x805D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_BLUE_SIZE_EXT")]
    TextureBlueSizeext = unchecked((uint)0x805E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_ALPHA_SIZE_EXT")]
    TextureAlphaSizeext = unchecked((uint)0x805F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_LUMINANCE_SIZE_EXT")]
    TextureLuminanceSizeext = unchecked((uint)0x8060),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_INTENSITY_SIZE_EXT")]
    TextureIntensitySizeext = unchecked((uint)0x8061),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_REPLACE_EXT")]
    Replaceext = unchecked((uint)0x8062),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PROXY_TEXTURE_1D_EXT")]
    ProxyTexture1Dext = unchecked((uint)0x8063),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PROXY_TEXTURE_2D_EXT")]
    ProxyTexture2Dext = unchecked((uint)0x8064),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_TOO_LARGE_EXT")]
    TextureTooLargeext = unchecked((uint)0x8065),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PACK_SKIP_IMAGES_EXT")]
    PackSkipImagesext = unchecked((uint)0x806B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PACK_IMAGE_HEIGHT_EXT")]
    PackImageHeightext = unchecked((uint)0x806C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNPACK_SKIP_IMAGES_EXT")]
    UnpackSkipImagesext = unchecked((uint)0x806D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNPACK_IMAGE_HEIGHT_EXT")]
    UnpackImageHeightext = unchecked((uint)0x806E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_3D_EXT")]
    Texture3Dext = unchecked((uint)0x806F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PROXY_TEXTURE_3D_EXT")]
    ProxyTexture3Dext = unchecked((uint)0x8070),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_DEPTH_EXT")]
    TextureDepthext = unchecked((uint)0x8071),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_WRAP_R_EXT")]
    TextureWrapRext = unchecked((uint)0x8072),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_3D_TEXTURE_SIZE_EXT")]
    Max3DTextureSizeext = unchecked((uint)0x8073),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_1D_ARRAY_EXT")]
    Texture1DArrayext = unchecked((uint)0x8C18),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PROXY_TEXTURE_1D_ARRAY_EXT")]
    ProxyTexture1DArrayext = unchecked((uint)0x8C19),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_2D_ARRAY_EXT")]
    Texture2DArrayext = unchecked((uint)0x8C1A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PROXY_TEXTURE_2D_ARRAY_EXT")]
    ProxyTexture2DArrayext = unchecked((uint)0x8C1B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_BINDING_1D_ARRAY_EXT")]
    TextureBinding1DArrayext = unchecked((uint)0x8C1C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_BINDING_2D_ARRAY_EXT")]
    TextureBinding2DArrayext = unchecked((uint)0x8C1D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_ARRAY_TEXTURE_LAYERS_EXT")]
    MaxArrayTextureLayersext = unchecked((uint)0x88FF),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMPARE_REF_DEPTH_TO_TEXTURE_EXT")]
    CompareRefDepthToTextureext = unchecked((uint)0x884E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_BUFFER_EXT")]
    TextureBufferext = unchecked((uint)0x8C2A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_TEXTURE_BUFFER_SIZE_EXT")]
    MaxTextureBufferSizeext = unchecked((uint)0x8C2B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_BINDING_BUFFER_EXT")]
    TextureBindingBufferext = unchecked((uint)0x8C2C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_BUFFER_DATA_STORE_BINDING_EXT")]
    TextureBufferDataStoreBindingext = unchecked((uint)0x8C2D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_BUFFER_FORMAT_EXT")]
    TextureBufferFormatext = unchecked((uint)0x8C2E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMPRESSED_LUMINANCE_LATC1_EXT")]
    CompressedLuminanceLatc1Ext = unchecked((uint)0x8C70),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMPRESSED_SIGNED_LUMINANCE_LATC1_EXT")]
    CompressedSignedLuminanceLatc1Ext = unchecked((uint)0x8C71),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMPRESSED_LUMINANCE_ALPHA_LATC2_EXT")]
    CompressedLuminanceAlphaLatc2Ext = unchecked((uint)0x8C72),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMPRESSED_SIGNED_LUMINANCE_ALPHA_LATC2_EXT")]
    CompressedSignedLuminanceAlphaLatc2Ext = unchecked((uint)0x8C73),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMPRESSED_RED_RGTC1_EXT")]
    CompressedRedRgtc1Ext = unchecked((uint)0x8DBB),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMPRESSED_SIGNED_RED_RGTC1_EXT")]
    CompressedSignedRedRgtc1Ext = unchecked((uint)0x8DBC),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMPRESSED_RED_GREEN_RGTC2_EXT")]
    CompressedRedGreenRgtc2Ext = unchecked((uint)0x8DBD),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMPRESSED_SIGNED_RED_GREEN_RGTC2_EXT")]
    CompressedSignedRedGreenRgtc2Ext = unchecked((uint)0x8DBE),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMPRESSED_RGBA_S3TC_DXT3_EXT")]
    CompressedRgbaS3TcDxt3Ext = unchecked((uint)0x83F2),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMPRESSED_RGBA_S3TC_DXT5_EXT")]
    CompressedRgbaS3TcDxt5Ext = unchecked((uint)0x83F3),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_NORMAL_MAP_EXT")]
    NormalMapext = unchecked((uint)0x8511),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_REFLECTION_MAP_EXT")]
    ReflectionMapext = unchecked((uint)0x8512),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_EXT")]
    TextureCubeMapext = unchecked((uint)0x8513),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_BINDING_CUBE_MAP_EXT")]
    TextureBindingCubeMapext = unchecked((uint)0x8514),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_X_EXT")]
    TextureCubeMapPositiveXext = unchecked((uint)0x8515),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_X_EXT")]
    TextureCubeMapNegativeXext = unchecked((uint)0x8516),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Y_EXT")]
    TextureCubeMapPositiveYext = unchecked((uint)0x8517),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_EXT")]
    TextureCubeMapNegativeYext = unchecked((uint)0x8518),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Z_EXT")]
    TextureCubeMapPositiveZext = unchecked((uint)0x8519),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_EXT")]
    TextureCubeMapNegativeZext = unchecked((uint)0x851A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PROXY_TEXTURE_CUBE_MAP_EXT")]
    ProxyTextureCubeMapext = unchecked((uint)0x851B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_CUBE_MAP_TEXTURE_SIZE_EXT")]
    MaxCubeMapTextureSizeext = unchecked((uint)0x851C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMBINE_EXT")]
    Combineext = unchecked((uint)0x8570),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMBINE_RGB_EXT")]
    CombineRgbext = unchecked((uint)0x8571),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMBINE_ALPHA_EXT")]
    CombineAlphaext = unchecked((uint)0x8572),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGB_SCALE_EXT")]
    RgbScaleext = unchecked((uint)0x8573),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ADD_SIGNED_EXT")]
    AddSignedext = unchecked((uint)0x8574),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INTERPOLATE_EXT")]
    Interpolateext = unchecked((uint)0x8575),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CONSTANT_EXT")]
    Constantext = unchecked((uint)0x8576),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PRIMARY_COLOR_EXT")]
    PrimaryColorext = unchecked((uint)0x8577),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PREVIOUS_EXT")]
    Previousext = unchecked((uint)0x8578),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SOURCE0_RGB_EXT")]
    Source0Rgbext = unchecked((uint)0x8580),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SOURCE1_RGB_EXT")]
    Source1Rgbext = unchecked((uint)0x8581),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SOURCE2_RGB_EXT")]
    Source2Rgbext = unchecked((uint)0x8582),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SOURCE0_ALPHA_EXT")]
    Source0Alphaext = unchecked((uint)0x8588),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SOURCE1_ALPHA_EXT")]
    Source1Alphaext = unchecked((uint)0x8589),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SOURCE2_ALPHA_EXT")]
    Source2Alphaext = unchecked((uint)0x858A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OPERAND0_RGB_EXT")]
    Operand0Rgbext = unchecked((uint)0x8590),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OPERAND1_RGB_EXT")]
    Operand1Rgbext = unchecked((uint)0x8591),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OPERAND2_RGB_EXT")]
    Operand2Rgbext = unchecked((uint)0x8592),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OPERAND0_ALPHA_EXT")]
    Operand0Alphaext = unchecked((uint)0x8598),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OPERAND1_ALPHA_EXT")]
    Operand1Alphaext = unchecked((uint)0x8599),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OPERAND2_ALPHA_EXT")]
    Operand2Alphaext = unchecked((uint)0x859A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DOT3_RGB_EXT")]
    Dot3Rgbext = unchecked((uint)0x8740),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DOT3_RGBA_EXT")]
    Dot3Rgbaext = unchecked((uint)0x8741),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_REDUCTION_MODE_EXT")]
    TextureReductionModeext = unchecked((uint)0x9366),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_WEIGHTED_AVERAGE_EXT")]
    WeightedAverageext = unchecked((uint)0x9367),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGBA32UI_EXT")]
    Rgba32Uiext = unchecked((uint)0x8D70),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGB32UI_EXT")]
    Rgb32Uiext = unchecked((uint)0x8D71),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ALPHA32UI_EXT")]
    Alpha32Uiext = unchecked((uint)0x8D72),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INTENSITY32UI_EXT")]
    Intensity32Uiext = unchecked((uint)0x8D73),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LUMINANCE32UI_EXT")]
    Luminance32Uiext = unchecked((uint)0x8D74),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LUMINANCE_ALPHA32UI_EXT")]
    LuminanceAlpha32Uiext = unchecked((uint)0x8D75),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGBA16UI_EXT")]
    Rgba16Uiext = unchecked((uint)0x8D76),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGB16UI_EXT")]
    Rgb16Uiext = unchecked((uint)0x8D77),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ALPHA16UI_EXT")]
    Alpha16Uiext = unchecked((uint)0x8D78),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INTENSITY16UI_EXT")]
    Intensity16Uiext = unchecked((uint)0x8D79),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LUMINANCE16UI_EXT")]
    Luminance16Uiext = unchecked((uint)0x8D7A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LUMINANCE_ALPHA16UI_EXT")]
    LuminanceAlpha16Uiext = unchecked((uint)0x8D7B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGBA8UI_EXT")]
    Rgba8Uiext = unchecked((uint)0x8D7C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGB8UI_EXT")]
    Rgb8Uiext = unchecked((uint)0x8D7D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ALPHA8UI_EXT")]
    Alpha8Uiext = unchecked((uint)0x8D7E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INTENSITY8UI_EXT")]
    Intensity8Uiext = unchecked((uint)0x8D7F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LUMINANCE8UI_EXT")]
    Luminance8Uiext = unchecked((uint)0x8D80),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LUMINANCE_ALPHA8UI_EXT")]
    LuminanceAlpha8Uiext = unchecked((uint)0x8D81),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGBA32I_EXT")]
    Rgba32Iext = unchecked((uint)0x8D82),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGB32I_EXT")]
    Rgb32Iext = unchecked((uint)0x8D83),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ALPHA32I_EXT")]
    Alpha32Iext = unchecked((uint)0x8D84),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INTENSITY32I_EXT")]
    Intensity32Iext = unchecked((uint)0x8D85),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LUMINANCE32I_EXT")]
    Luminance32Iext = unchecked((uint)0x8D86),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LUMINANCE_ALPHA32I_EXT")]
    LuminanceAlpha32Iext = unchecked((uint)0x8D87),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGBA16I_EXT")]
    Rgba16Iext = unchecked((uint)0x8D88),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGB16I_EXT")]
    Rgb16Iext = unchecked((uint)0x8D89),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ALPHA16I_EXT")]
    Alpha16Iext = unchecked((uint)0x8D8A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INTENSITY16I_EXT")]
    Intensity16Iext = unchecked((uint)0x8D8B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LUMINANCE16I_EXT")]
    Luminance16Iext = unchecked((uint)0x8D8C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LUMINANCE_ALPHA16I_EXT")]
    LuminanceAlpha16Iext = unchecked((uint)0x8D8D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGBA8I_EXT")]
    Rgba8Iext = unchecked((uint)0x8D8E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGB8I_EXT")]
    Rgb8Iext = unchecked((uint)0x8D8F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ALPHA8I_EXT")]
    Alpha8Iext = unchecked((uint)0x8D90),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INTENSITY8I_EXT")]
    Intensity8Iext = unchecked((uint)0x8D91),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LUMINANCE8I_EXT")]
    Luminance8Iext = unchecked((uint)0x8D92),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LUMINANCE_ALPHA8I_EXT")]
    LuminanceAlpha8Iext = unchecked((uint)0x8D93),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RED_INTEGER_EXT")]
    RedIntegerext = unchecked((uint)0x8D94),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_GREEN_INTEGER_EXT")]
    GreenIntegerext = unchecked((uint)0x8D95),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_BLUE_INTEGER_EXT")]
    BlueIntegerext = unchecked((uint)0x8D96),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ALPHA_INTEGER_EXT")]
    AlphaIntegerext = unchecked((uint)0x8D97),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGB_INTEGER_EXT")]
    RgbIntegerext = unchecked((uint)0x8D98),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGBA_INTEGER_EXT")]
    RgbaIntegerext = unchecked((uint)0x8D99),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_BGR_INTEGER_EXT")]
    BgrIntegerext = unchecked((uint)0x8D9A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_BGRA_INTEGER_EXT")]
    BgraIntegerext = unchecked((uint)0x8D9B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LUMINANCE_INTEGER_EXT")]
    LuminanceIntegerext = unchecked((uint)0x8D9C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LUMINANCE_ALPHA_INTEGER_EXT")]
    LuminanceAlphaIntegerext = unchecked((uint)0x8D9D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGBA_INTEGER_MODE_EXT")]
    RgbaIntegerModeext = unchecked((uint)0x8D9E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MIRROR_CLAMP_EXT")]
    MirrorClampext = unchecked((uint)0x8742),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MIRROR_CLAMP_TO_EDGE_EXT")]
    MirrorClampToEdgeext = unchecked((uint)0x8743),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MIRROR_CLAMP_TO_BORDER_EXT")]
    MirrorClampToBorderext = unchecked((uint)0x8912),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_PRIORITY_EXT")]
    TexturePriorityext = unchecked((uint)0x8066),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_RESIDENT_EXT")]
    TextureResidentext = unchecked((uint)0x8067),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_1D_BINDING_EXT")]
    Texture1DBindingext = unchecked((uint)0x8068),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_2D_BINDING_EXT")]
    Texture2DBindingext = unchecked((uint)0x8069),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_3D_BINDING_EXT")]
    Texture3DBindingext = unchecked((uint)0x806A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PERTURB_EXT")]
    Perturbext = unchecked((uint)0x85AE),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_NORMAL_EXT")]
    TextureNormalext = unchecked((uint)0x85AF),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SRGB8_EXT")]
    Srgb8Ext = unchecked((uint)0x8C41),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SLUMINANCE_ALPHA_EXT")]
    SluminanceAlphaext = unchecked((uint)0x8C44),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SLUMINANCE8_ALPHA8_EXT")]
    Sluminance8Alpha8Ext = unchecked((uint)0x8C45),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SLUMINANCE_EXT")]
    Sluminanceext = unchecked((uint)0x8C46),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SLUMINANCE8_EXT")]
    Sluminance8Ext = unchecked((uint)0x8C47),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMPRESSED_SRGB_EXT")]
    CompressedSrgbext = unchecked((uint)0x8C48),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMPRESSED_SRGB_ALPHA_EXT")]
    CompressedSrgbAlphaext = unchecked((uint)0x8C49),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMPRESSED_SLUMINANCE_EXT")]
    CompressedSluminanceext = unchecked((uint)0x8C4A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMPRESSED_SLUMINANCE_ALPHA_EXT")]
    CompressedSluminanceAlphaext = unchecked((uint)0x8C4B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMPRESSED_SRGB_S3TC_DXT1_EXT")]
    CompressedSrgbS3TcDxt1Ext = unchecked((uint)0x8C4C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT")]
    CompressedSrgbAlphaS3TcDxt1Ext = unchecked((uint)0x8C4D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT")]
    CompressedSrgbAlphaS3TcDxt3Ext = unchecked((uint)0x8C4E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT")]
    CompressedSrgbAlphaS3TcDxt5Ext = unchecked((uint)0x8C4F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SR8_EXT")]
    Sr8Ext = unchecked((uint)0x8FBD),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SRG8_EXT")]
    Srg8Ext = unchecked((uint)0x8FBE),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_SRGB_DECODE_EXT")]
    TextureSrgbDecodeext = unchecked((uint)0x8A48),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DECODE_EXT")]
    Decodeext = unchecked((uint)0x8A49),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SKIP_DECODE_EXT")]
    SkipDecodeext = unchecked((uint)0x8A4A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGB9_E5_EXT")]
    Rgb9E5Ext = unchecked((uint)0x8C3D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_5_9_9_9_REV_EXT")]
    UnsignedInt5X9X9X9Revext = unchecked((uint)0x8C3E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_SHARED_SIZE_EXT")]
    TextureSharedSizeext = unchecked((uint)0x8C3F),

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

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_SWIZZLE_R_EXT")]
    TextureSwizzleRext = unchecked((uint)0x8E42),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_SWIZZLE_G_EXT")]
    TextureSwizzleGext = unchecked((uint)0x8E43),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_SWIZZLE_B_EXT")]
    TextureSwizzleBext = unchecked((uint)0x8E44),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_SWIZZLE_A_EXT")]
    TextureSwizzleAext = unchecked((uint)0x8E45),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_SWIZZLE_RGBA_EXT")]
    TextureSwizzleRgbaext = unchecked((uint)0x8E46),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TIME_ELAPSED_EXT")]
    TimeElapsedext = unchecked((uint)0x88BF),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_EXT")]
    TransformFeedbackBufferext = unchecked((uint)0x8C8E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_START_EXT")]
    TransformFeedbackBufferStartext = unchecked((uint)0x8C84),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_SIZE_EXT")]
    TransformFeedbackBufferSizeext = unchecked((uint)0x8C85),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_BINDING_EXT")]
    TransformFeedbackBufferBindingext = unchecked((uint)0x8C8F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INTERLEAVED_ATTRIBS_EXT")]
    InterleavedAttribsext = unchecked((uint)0x8C8C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SEPARATE_ATTRIBS_EXT")]
    SeparateAttribsext = unchecked((uint)0x8C8D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PRIMITIVES_GENERATED_EXT")]
    PrimitivesGeneratedext = unchecked((uint)0x8C87),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN_EXT")]
    TransformFeedbackPrimitivesWrittenext = unchecked((uint)0x8C88),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RASTERIZER_DISCARD_EXT")]
    RasterizerDiscardext = unchecked((uint)0x8C89),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS_EXT")]
    MaxTransformFeedbackInterleavedComponentsext = unchecked((uint)0x8C8A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS_EXT")]
    MaxTransformFeedbackSeparateAttribsext = unchecked((uint)0x8C8B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS_EXT")]
    MaxTransformFeedbackSeparateComponentsext = unchecked((uint)0x8C80),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TRANSFORM_FEEDBACK_VARYINGS_EXT")]
    TransformFeedbackVaryingsext = unchecked((uint)0x8C83),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_MODE_EXT")]
    TransformFeedbackBufferModeext = unchecked((uint)0x8C7F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH_EXT")]
    TransformFeedbackVaryingMaxLengthext = unchecked((uint)0x8C76),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VERTEX_ARRAY_EXT")]
    VertexArrayext = unchecked((uint)0x8074),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_NORMAL_ARRAY_EXT")]
    NormalArrayext = unchecked((uint)0x8075),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ARRAY_EXT")]
    ColorArrayext = unchecked((uint)0x8076),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INDEX_ARRAY_EXT")]
    IndexArrayext = unchecked((uint)0x8077),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_COORD_ARRAY_EXT")]
    TextureCoordArrayext = unchecked((uint)0x8078),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_EDGE_FLAG_ARRAY_EXT")]
    EdgeFlagArrayext = unchecked((uint)0x8079),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VERTEX_ARRAY_SIZE_EXT")]
    VertexArraySizeext = unchecked((uint)0x807A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VERTEX_ARRAY_TYPE_EXT")]
    VertexArrayTypeext = unchecked((uint)0x807B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VERTEX_ARRAY_STRIDE_EXT")]
    VertexArrayStrideext = unchecked((uint)0x807C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VERTEX_ARRAY_COUNT_EXT")]
    VertexArrayCountext = unchecked((uint)0x807D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_NORMAL_ARRAY_TYPE_EXT")]
    NormalArrayTypeext = unchecked((uint)0x807E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_NORMAL_ARRAY_STRIDE_EXT")]
    NormalArrayStrideext = unchecked((uint)0x807F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_NORMAL_ARRAY_COUNT_EXT")]
    NormalArrayCountext = unchecked((uint)0x8080),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ARRAY_SIZE_EXT")]
    ColorArraySizeext = unchecked((uint)0x8081),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ARRAY_TYPE_EXT")]
    ColorArrayTypeext = unchecked((uint)0x8082),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ARRAY_STRIDE_EXT")]
    ColorArrayStrideext = unchecked((uint)0x8083),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ARRAY_COUNT_EXT")]
    ColorArrayCountext = unchecked((uint)0x8084),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INDEX_ARRAY_TYPE_EXT")]
    IndexArrayTypeext = unchecked((uint)0x8085),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INDEX_ARRAY_STRIDE_EXT")]
    IndexArrayStrideext = unchecked((uint)0x8086),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INDEX_ARRAY_COUNT_EXT")]
    IndexArrayCountext = unchecked((uint)0x8087),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_COORD_ARRAY_SIZE_EXT")]
    TextureCoordArraySizeext = unchecked((uint)0x8088),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_COORD_ARRAY_TYPE_EXT")]
    TextureCoordArrayTypeext = unchecked((uint)0x8089),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_COORD_ARRAY_STRIDE_EXT")]
    TextureCoordArrayStrideext = unchecked((uint)0x808A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_COORD_ARRAY_COUNT_EXT")]
    TextureCoordArrayCountext = unchecked((uint)0x808B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_EDGE_FLAG_ARRAY_STRIDE_EXT")]
    EdgeFlagArrayStrideext = unchecked((uint)0x808C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_EDGE_FLAG_ARRAY_COUNT_EXT")]
    EdgeFlagArrayCountext = unchecked((uint)0x808D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VERTEX_ARRAY_POINTER_EXT")]
    VertexArrayPointerext = unchecked((uint)0x808E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_NORMAL_ARRAY_POINTER_EXT")]
    NormalArrayPointerext = unchecked((uint)0x808F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ARRAY_POINTER_EXT")]
    ColorArrayPointerext = unchecked((uint)0x8090),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INDEX_ARRAY_POINTER_EXT")]
    IndexArrayPointerext = unchecked((uint)0x8091),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_COORD_ARRAY_POINTER_EXT")]
    TextureCoordArrayPointerext = unchecked((uint)0x8092),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_EDGE_FLAG_ARRAY_POINTER_EXT")]
    EdgeFlagArrayPointerext = unchecked((uint)0x8093),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DOUBLE_VEC2_EXT")]
    DoubleVec2Ext = unchecked((uint)0x8FFC),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DOUBLE_VEC3_EXT")]
    DoubleVec3Ext = unchecked((uint)0x8FFD),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DOUBLE_VEC4_EXT")]
    DoubleVec4Ext = unchecked((uint)0x8FFE),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DOUBLE_MAT2_EXT")]
    DoubleMat2Ext = unchecked((uint)0x8F46),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DOUBLE_MAT3_EXT")]
    DoubleMat3Ext = unchecked((uint)0x8F47),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DOUBLE_MAT4_EXT")]
    DoubleMat4Ext = unchecked((uint)0x8F48),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DOUBLE_MAT2x3_EXT")]
    DoubleMat2X3Ext = unchecked((uint)0x8F49),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DOUBLE_MAT2x4_EXT")]
    DoubleMat2X4Ext = unchecked((uint)0x8F4A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DOUBLE_MAT3x2_EXT")]
    DoubleMat3X2Ext = unchecked((uint)0x8F4B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DOUBLE_MAT3x4_EXT")]
    DoubleMat3X4Ext = unchecked((uint)0x8F4C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DOUBLE_MAT4x2_EXT")]
    DoubleMat4X2Ext = unchecked((uint)0x8F4D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DOUBLE_MAT4x3_EXT")]
    DoubleMat4X3Ext = unchecked((uint)0x8F4E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VERTEX_SHADER_EXT")]
    VertexShaderext = unchecked((uint)0x8780),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VERTEX_SHADER_BINDING_EXT")]
    VertexShaderBindingext = unchecked((uint)0x8781),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_INDEX_EXT")]
    OpIndexext = unchecked((uint)0x8782),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_NEGATE_EXT")]
    OpNegateext = unchecked((uint)0x8783),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_DOT3_EXT")]
    OpDot3Ext = unchecked((uint)0x8784),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_DOT4_EXT")]
    OpDot4Ext = unchecked((uint)0x8785),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_MUL_EXT")]
    OpMulext = unchecked((uint)0x8786),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_ADD_EXT")]
    OpAddext = unchecked((uint)0x8787),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_MADD_EXT")]
    OpMaddext = unchecked((uint)0x8788),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_FRAC_EXT")]
    OpFracext = unchecked((uint)0x8789),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_MAX_EXT")]
    OpMaxext = unchecked((uint)0x878A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_MIN_EXT")]
    OpMinext = unchecked((uint)0x878B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_SET_GE_EXT")]
    OpSetGeext = unchecked((uint)0x878C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_SET_LT_EXT")]
    OpSetLtext = unchecked((uint)0x878D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_CLAMP_EXT")]
    OpClampext = unchecked((uint)0x878E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_FLOOR_EXT")]
    OpFloorext = unchecked((uint)0x878F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_ROUND_EXT")]
    OpRoundext = unchecked((uint)0x8790),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_EXP_BASE_2_EXT")]
    OpExpBase2Ext = unchecked((uint)0x8791),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_LOG_BASE_2_EXT")]
    OpLogBase2Ext = unchecked((uint)0x8792),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_POWER_EXT")]
    OpPowerext = unchecked((uint)0x8793),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_RECIP_EXT")]
    OpRecipext = unchecked((uint)0x8794),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_RECIP_SQRT_EXT")]
    OpRecipSqrtext = unchecked((uint)0x8795),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_SUB_EXT")]
    OpSubext = unchecked((uint)0x8796),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_CROSS_PRODUCT_EXT")]
    OpCrossProductext = unchecked((uint)0x8797),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_MULTIPLY_MATRIX_EXT")]
    OpMultiplyMatrixext = unchecked((uint)0x8798),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_MOV_EXT")]
    OpMovext = unchecked((uint)0x8799),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_VERTEX_EXT")]
    OutputVertexext = unchecked((uint)0x879A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_COLOR0_EXT")]
    OutputColor0Ext = unchecked((uint)0x879B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_COLOR1_EXT")]
    OutputColor1Ext = unchecked((uint)0x879C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_TEXTURE_COORD0_EXT")]
    OutputTextureCoord0Ext = unchecked((uint)0x879D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_TEXTURE_COORD1_EXT")]
    OutputTextureCoord1Ext = unchecked((uint)0x879E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_TEXTURE_COORD2_EXT")]
    OutputTextureCoord2Ext = unchecked((uint)0x879F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_TEXTURE_COORD3_EXT")]
    OutputTextureCoord3Ext = unchecked((uint)0x87A0),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_TEXTURE_COORD4_EXT")]
    OutputTextureCoord4Ext = unchecked((uint)0x87A1),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_TEXTURE_COORD5_EXT")]
    OutputTextureCoord5Ext = unchecked((uint)0x87A2),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_TEXTURE_COORD6_EXT")]
    OutputTextureCoord6Ext = unchecked((uint)0x87A3),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_TEXTURE_COORD7_EXT")]
    OutputTextureCoord7Ext = unchecked((uint)0x87A4),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_TEXTURE_COORD8_EXT")]
    OutputTextureCoord8Ext = unchecked((uint)0x87A5),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_TEXTURE_COORD9_EXT")]
    OutputTextureCoord9Ext = unchecked((uint)0x87A6),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_TEXTURE_COORD10_EXT")]
    OutputTextureCoord10Ext = unchecked((uint)0x87A7),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_TEXTURE_COORD11_EXT")]
    OutputTextureCoord11Ext = unchecked((uint)0x87A8),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_TEXTURE_COORD12_EXT")]
    OutputTextureCoord12Ext = unchecked((uint)0x87A9),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_TEXTURE_COORD13_EXT")]
    OutputTextureCoord13Ext = unchecked((uint)0x87AA),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_TEXTURE_COORD14_EXT")]
    OutputTextureCoord14Ext = unchecked((uint)0x87AB),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_TEXTURE_COORD15_EXT")]
    OutputTextureCoord15Ext = unchecked((uint)0x87AC),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_TEXTURE_COORD16_EXT")]
    OutputTextureCoord16Ext = unchecked((uint)0x87AD),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_TEXTURE_COORD17_EXT")]
    OutputTextureCoord17Ext = unchecked((uint)0x87AE),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_TEXTURE_COORD18_EXT")]
    OutputTextureCoord18Ext = unchecked((uint)0x87AF),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_TEXTURE_COORD19_EXT")]
    OutputTextureCoord19Ext = unchecked((uint)0x87B0),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_TEXTURE_COORD20_EXT")]
    OutputTextureCoord20Ext = unchecked((uint)0x87B1),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_TEXTURE_COORD21_EXT")]
    OutputTextureCoord21Ext = unchecked((uint)0x87B2),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_TEXTURE_COORD22_EXT")]
    OutputTextureCoord22Ext = unchecked((uint)0x87B3),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_TEXTURE_COORD23_EXT")]
    OutputTextureCoord23Ext = unchecked((uint)0x87B4),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_TEXTURE_COORD24_EXT")]
    OutputTextureCoord24Ext = unchecked((uint)0x87B5),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_TEXTURE_COORD25_EXT")]
    OutputTextureCoord25Ext = unchecked((uint)0x87B6),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_TEXTURE_COORD26_EXT")]
    OutputTextureCoord26Ext = unchecked((uint)0x87B7),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_TEXTURE_COORD27_EXT")]
    OutputTextureCoord27Ext = unchecked((uint)0x87B8),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_TEXTURE_COORD28_EXT")]
    OutputTextureCoord28Ext = unchecked((uint)0x87B9),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_TEXTURE_COORD29_EXT")]
    OutputTextureCoord29Ext = unchecked((uint)0x87BA),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_TEXTURE_COORD30_EXT")]
    OutputTextureCoord30Ext = unchecked((uint)0x87BB),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_TEXTURE_COORD31_EXT")]
    OutputTextureCoord31Ext = unchecked((uint)0x87BC),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OUTPUT_FOG_EXT")]
    OutputFogext = unchecked((uint)0x87BD),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SCALAR_EXT")]
    Scalarext = unchecked((uint)0x87BE),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VECTOR_EXT")]
    Vectorext = unchecked((uint)0x87BF),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MATRIX_EXT")]
    Matrixext = unchecked((uint)0x87C0),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VARIANT_EXT")]
    Variantext = unchecked((uint)0x87C1),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INVARIANT_EXT")]
    Invariantext = unchecked((uint)0x87C2),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LOCAL_CONSTANT_EXT")]
    LocalConstantext = unchecked((uint)0x87C3),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LOCAL_EXT")]
    Localext = unchecked((uint)0x87C4),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_VERTEX_SHADER_INSTRUCTIONS_EXT")]
    MaxVertexShaderInstructionsext = unchecked((uint)0x87C5),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_VERTEX_SHADER_VARIANTS_EXT")]
    MaxVertexShaderVariantsext = unchecked((uint)0x87C6),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_VERTEX_SHADER_INVARIANTS_EXT")]
    MaxVertexShaderInvariantsext = unchecked((uint)0x87C7),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_VERTEX_SHADER_LOCAL_CONSTANTS_EXT")]
    MaxVertexShaderLocalConstantsext = unchecked((uint)0x87C8),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_VERTEX_SHADER_LOCALS_EXT")]
    MaxVertexShaderLocalsext = unchecked((uint)0x87C9),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_OPTIMIZED_VERTEX_SHADER_INSTRUCTIONS_EXT")]
    MaxOptimizedVertexShaderInstructionsext = unchecked((uint)0x87CA),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_OPTIMIZED_VERTEX_SHADER_VARIANTS_EXT")]
    MaxOptimizedVertexShaderVariantsext = unchecked((uint)0x87CB),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_OPTIMIZED_VERTEX_SHADER_LOCAL_CONSTANTS_EXT")]
    MaxOptimizedVertexShaderLocalConstantsext = unchecked((uint)0x87CC),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_OPTIMIZED_VERTEX_SHADER_INVARIANTS_EXT")]
    MaxOptimizedVertexShaderInvariantsext = unchecked((uint)0x87CD),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_OPTIMIZED_VERTEX_SHADER_LOCALS_EXT")]
    MaxOptimizedVertexShaderLocalsext = unchecked((uint)0x87CE),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VERTEX_SHADER_INSTRUCTIONS_EXT")]
    VertexShaderInstructionsext = unchecked((uint)0x87CF),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VERTEX_SHADER_VARIANTS_EXT")]
    VertexShaderVariantsext = unchecked((uint)0x87D0),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VERTEX_SHADER_INVARIANTS_EXT")]
    VertexShaderInvariantsext = unchecked((uint)0x87D1),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VERTEX_SHADER_LOCAL_CONSTANTS_EXT")]
    VertexShaderLocalConstantsext = unchecked((uint)0x87D2),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VERTEX_SHADER_LOCALS_EXT")]
    VertexShaderLocalsext = unchecked((uint)0x87D3),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VERTEX_SHADER_OPTIMIZED_EXT")]
    VertexShaderOptimizedext = unchecked((uint)0x87D4),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_X_EXT")]
    Xext = unchecked((uint)0x87D5),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_Y_EXT")]
    Yext = unchecked((uint)0x87D6),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_Z_EXT")]
    Zext = unchecked((uint)0x87D7),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_W_EXT")]
    Wext = unchecked((uint)0x87D8),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_NEGATIVE_X_EXT")]
    NegativeXext = unchecked((uint)0x87D9),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_NEGATIVE_Y_EXT")]
    NegativeYext = unchecked((uint)0x87DA),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_NEGATIVE_Z_EXT")]
    NegativeZext = unchecked((uint)0x87DB),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_NEGATIVE_W_EXT")]
    NegativeWext = unchecked((uint)0x87DC),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ZERO_EXT")]
    Zeroext = unchecked((uint)0x87DD),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ONE_EXT")]
    Oneext = unchecked((uint)0x87DE),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_NEGATIVE_ONE_EXT")]
    NegativeOneext = unchecked((uint)0x87DF),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_NORMALIZED_RANGE_EXT")]
    NormalizedRangeext = unchecked((uint)0x87E0),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FULL_RANGE_EXT")]
    FullRangeext = unchecked((uint)0x87E1),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CURRENT_VERTEX_EXT")]
    CurrentVertexext = unchecked((uint)0x87E2),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MVP_MATRIX_EXT")]
    MvpMatrixext = unchecked((uint)0x87E3),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VARIANT_VALUE_EXT")]
    VariantValueext = unchecked((uint)0x87E4),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VARIANT_DATATYPE_EXT")]
    VariantDatatypeext = unchecked((uint)0x87E5),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VARIANT_ARRAY_STRIDE_EXT")]
    VariantArrayStrideext = unchecked((uint)0x87E6),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VARIANT_ARRAY_TYPE_EXT")]
    VariantArrayTypeext = unchecked((uint)0x87E7),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VARIANT_ARRAY_EXT")]
    VariantArrayext = unchecked((uint)0x87E8),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VARIANT_ARRAY_POINTER_EXT")]
    VariantArrayPointerext = unchecked((uint)0x87E9),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INVARIANT_VALUE_EXT")]
    InvariantValueext = unchecked((uint)0x87EA),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INVARIANT_DATATYPE_EXT")]
    InvariantDatatypeext = unchecked((uint)0x87EB),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LOCAL_CONSTANT_VALUE_EXT")]
    LocalConstantValueext = unchecked((uint)0x87EC),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LOCAL_CONSTANT_DATATYPE_EXT")]
    LocalConstantDatatypeext = unchecked((uint)0x87ED),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MODELVIEW0_STACK_DEPTH_EXT")]
    Modelview0StackDepthext = unchecked((uint)0x0BA3),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MODELVIEW1_STACK_DEPTH_EXT")]
    Modelview1StackDepthext = unchecked((uint)0x8502),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MODELVIEW0_MATRIX_EXT")]
    Modelview0Matrixext = unchecked((uint)0x0BA6),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MODELVIEW1_MATRIX_EXT")]
    Modelview1Matrixext = unchecked((uint)0x8506),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VERTEX_WEIGHTING_EXT")]
    VertexWeightingext = unchecked((uint)0x8509),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MODELVIEW0_EXT")]
    Modelview0Ext = unchecked((uint)0x1700),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MODELVIEW1_EXT")]
    Modelview1Ext = unchecked((uint)0x850A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CURRENT_VERTEX_WEIGHT_EXT")]
    CurrentVertexWeightext = unchecked((uint)0x850B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VERTEX_WEIGHT_ARRAY_EXT")]
    VertexWeightArrayext = unchecked((uint)0x850C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VERTEX_WEIGHT_ARRAY_SIZE_EXT")]
    VertexWeightArraySizeext = unchecked((uint)0x850D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VERTEX_WEIGHT_ARRAY_TYPE_EXT")]
    VertexWeightArrayTypeext = unchecked((uint)0x850E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VERTEX_WEIGHT_ARRAY_STRIDE_EXT")]
    VertexWeightArrayStrideext = unchecked((uint)0x850F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VERTEX_WEIGHT_ARRAY_POINTER_EXT")]
    VertexWeightArrayPointerext = unchecked((uint)0x8510),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INCLUSIVE_EXT")]
    Inclusiveext = unchecked((uint)0x8F10),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_EXCLUSIVE_EXT")]
    Exclusiveext = unchecked((uint)0x8F11),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_WINDOW_RECTANGLE_EXT")]
    WindowRectAngleext = unchecked((uint)0x8F12),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_WINDOW_RECTANGLE_MODE_EXT")]
    WindowRectangleModeext = unchecked((uint)0x8F13),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_WINDOW_RECTANGLES_EXT")]
    MaxWindowRectanglesext = unchecked((uint)0x8F14),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_NUM_WINDOW_RECTANGLES_EXT")]
    NumWindowRectanglesext = unchecked((uint)0x8F15),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SYNC_X11_FENCE_EXT")]
    SyncX11Fenceext = unchecked((uint)0x90E1),

    [NameAffix("Suffix", "HP", 0)]
    [NativeName("GL_IGNORE_BORDER_HP")]
    IgnoreBorderhp = unchecked((uint)0x8150),

    [NameAffix("Suffix", "HP", 0)]
    [NativeName("GL_CONSTANT_BORDER_HP")]
    ConstantBorderhp = unchecked((uint)0x8151),

    [NameAffix("Suffix", "HP", 0)]
    [NativeName("GL_REPLICATE_BORDER_HP")]
    ReplicateBorderhp = unchecked((uint)0x8153),

    [NameAffix("Suffix", "HP", 0)]
    [NativeName("GL_CONVOLUTION_BORDER_COLOR_HP")]
    ConvolutionBorderColorhp = unchecked((uint)0x8154),

    [NameAffix("Suffix", "HP", 0)]
    [NativeName("GL_IMAGE_SCALE_X_HP")]
    ImageScaleXhp = unchecked((uint)0x8155),

    [NameAffix("Suffix", "HP", 0)]
    [NativeName("GL_IMAGE_SCALE_Y_HP")]
    ImageScaleYhp = unchecked((uint)0x8156),

    [NameAffix("Suffix", "HP", 0)]
    [NativeName("GL_IMAGE_TRANSLATE_X_HP")]
    ImageTranslateXhp = unchecked((uint)0x8157),

    [NameAffix("Suffix", "HP", 0)]
    [NativeName("GL_IMAGE_TRANSLATE_Y_HP")]
    ImageTranslateYhp = unchecked((uint)0x8158),

    [NameAffix("Suffix", "HP", 0)]
    [NativeName("GL_IMAGE_ROTATE_ANGLE_HP")]
    ImageRotateAnglehp = unchecked((uint)0x8159),

    [NameAffix("Suffix", "HP", 0)]
    [NativeName("GL_IMAGE_ROTATE_ORIGIN_X_HP")]
    ImageRotateOriginXhp = unchecked((uint)0x815A),

    [NameAffix("Suffix", "HP", 0)]
    [NativeName("GL_IMAGE_ROTATE_ORIGIN_Y_HP")]
    ImageRotateOriginYhp = unchecked((uint)0x815B),

    [NameAffix("Suffix", "HP", 0)]
    [NativeName("GL_IMAGE_MAG_FILTER_HP")]
    ImageMagFilterhp = unchecked((uint)0x815C),

    [NameAffix("Suffix", "HP", 0)]
    [NativeName("GL_IMAGE_MIN_FILTER_HP")]
    ImageMinFilterhp = unchecked((uint)0x815D),

    [NameAffix("Suffix", "HP", 0)]
    [NativeName("GL_IMAGE_CUBIC_WEIGHT_HP")]
    ImageCubicWeighthp = unchecked((uint)0x815E),

    [NameAffix("Suffix", "HP", 0)]
    [NativeName("GL_CUBIC_HP")]
    Cubichp = unchecked((uint)0x815F),

    [NameAffix("Suffix", "HP", 0)]
    [NativeName("GL_AVERAGE_HP")]
    Averagehp = unchecked((uint)0x8160),

    [NameAffix("Suffix", "HP", 0)]
    [NativeName("GL_IMAGE_TRANSFORM_2D_HP")]
    ImageTransform2Dhp = unchecked((uint)0x8161),

    [NameAffix("Suffix", "HP", 0)]
    [NativeName("GL_POST_IMAGE_TRANSFORM_COLOR_TABLE_HP")]
    PostImageTransformColorTablehp = unchecked((uint)0x8162),

    [NameAffix("Suffix", "HP", 0)]
    [NativeName("GL_PROXY_POST_IMAGE_TRANSFORM_COLOR_TABLE_HP")]
    ProxyPostImageTransformColorTablehp = unchecked((uint)0x8163),

    [NameAffix("Suffix", "HP", 0)]
    [NativeName("GL_OCCLUSION_TEST_HP")]
    OcclusionTesthp = unchecked((uint)0x8165),

    [NameAffix("Suffix", "HP", 0)]
    [NativeName("GL_OCCLUSION_TEST_RESULT_HP")]
    OcclusionTestResulthp = unchecked((uint)0x8166),

    [NameAffix("Suffix", "HP", 0)]
    [NativeName("GL_TEXTURE_LIGHTING_MODE_HP")]
    TextureLightingModehp = unchecked((uint)0x8167),

    [NameAffix("Suffix", "HP", 0)]
    [NativeName("GL_TEXTURE_POST_SPECULAR_HP")]
    TexturePostSpecularhp = unchecked((uint)0x8168),

    [NameAffix("Suffix", "HP", 0)]
    [NativeName("GL_TEXTURE_PRE_SPECULAR_HP")]
    TexturePreSpecularhp = unchecked((uint)0x8169),

    [NameAffix("Suffix", "IBM", 0)]
    [NativeName("GL_CULL_VERTEX_IBM")]
    CullVertexibm = unchecked((uint)103050),

    [NameAffix("Suffix", "IBM", 0)]
    [NativeName("GL_RASTER_POSITION_UNCLIPPED_IBM")]
    RasterPositionUnclippedibm = unchecked((uint)0x19262),

    [NameAffix("Suffix", "IBM", 0)]
    [NativeName("GL_ALL_STATIC_DATA_IBM")]
    AllStaticDataibm = unchecked((uint)103060),

    [NameAffix("Suffix", "IBM", 0)]
    [NativeName("GL_STATIC_VERTEX_ARRAY_IBM")]
    StaticVertexArrayibm = unchecked((uint)103061),

    [NameAffix("Suffix", "IBM", 0)]
    [NativeName("GL_MIRRORED_REPEAT_IBM")]
    MirroredRepeatibm = unchecked((uint)0x8370),

    [NameAffix("Suffix", "IBM", 0)]
    [NativeName("GL_VERTEX_ARRAY_LIST_IBM")]
    VertexArrayListibm = unchecked((uint)103070),

    [NameAffix("Suffix", "IBM", 0)]
    [NativeName("GL_NORMAL_ARRAY_LIST_IBM")]
    NormalArrayListibm = unchecked((uint)103071),

    [NameAffix("Suffix", "IBM", 0)]
    [NativeName("GL_COLOR_ARRAY_LIST_IBM")]
    ColorArrayListibm = unchecked((uint)103072),

    [NameAffix("Suffix", "IBM", 0)]
    [NativeName("GL_INDEX_ARRAY_LIST_IBM")]
    IndexArrayListibm = unchecked((uint)103073),

    [NameAffix("Suffix", "IBM", 0)]
    [NativeName("GL_TEXTURE_COORD_ARRAY_LIST_IBM")]
    TextureCoordArrayListibm = unchecked((uint)103074),

    [NameAffix("Suffix", "IBM", 0)]
    [NativeName("GL_EDGE_FLAG_ARRAY_LIST_IBM")]
    EdgeFlagArrayListibm = unchecked((uint)103075),

    [NameAffix("Suffix", "IBM", 0)]
    [NativeName("GL_FOG_COORDINATE_ARRAY_LIST_IBM")]
    FogCoordinateArrayListibm = unchecked((uint)103076),

    [NameAffix("Suffix", "IBM", 0)]
    [NativeName("GL_SECONDARY_COLOR_ARRAY_LIST_IBM")]
    SecondaryColorArrayListibm = unchecked((uint)103077),

    [NameAffix("Suffix", "IBM", 0)]
    [NativeName("GL_VERTEX_ARRAY_LIST_STRIDE_IBM")]
    VertexArrayListStrideibm = unchecked((uint)103080),

    [NameAffix("Suffix", "IBM", 0)]
    [NativeName("GL_NORMAL_ARRAY_LIST_STRIDE_IBM")]
    NormalArrayListStrideibm = unchecked((uint)103081),

    [NameAffix("Suffix", "IBM", 0)]
    [NativeName("GL_COLOR_ARRAY_LIST_STRIDE_IBM")]
    ColorArrayListStrideibm = unchecked((uint)103082),

    [NameAffix("Suffix", "IBM", 0)]
    [NativeName("GL_INDEX_ARRAY_LIST_STRIDE_IBM")]
    IndexArrayListStrideibm = unchecked((uint)103083),

    [NameAffix("Suffix", "IBM", 0)]
    [NativeName("GL_TEXTURE_COORD_ARRAY_LIST_STRIDE_IBM")]
    TextureCoordArrayListStrideibm = unchecked((uint)103084),

    [NameAffix("Suffix", "IBM", 0)]
    [NativeName("GL_EDGE_FLAG_ARRAY_LIST_STRIDE_IBM")]
    EdgeFlagArrayListStrideibm = unchecked((uint)103085),

    [NameAffix("Suffix", "IBM", 0)]
    [NativeName("GL_FOG_COORDINATE_ARRAY_LIST_STRIDE_IBM")]
    FogCoordinateArrayListStrideibm = unchecked((uint)103086),

    [NameAffix("Suffix", "IBM", 0)]
    [NativeName("GL_SECONDARY_COLOR_ARRAY_LIST_STRIDE_IBM")]
    SecondaryColorArrayListStrideibm = unchecked((uint)103087),

    [NameAffix("Suffix", "INGR", 0)]
    [NativeName("GL_RED_MIN_CLAMP_INGR")]
    RedMinClampingr = unchecked((uint)0x8560),

    [NameAffix("Suffix", "INGR", 0)]
    [NativeName("GL_GREEN_MIN_CLAMP_INGR")]
    GreenMinClampingr = unchecked((uint)0x8561),

    [NameAffix("Suffix", "INGR", 0)]
    [NativeName("GL_BLUE_MIN_CLAMP_INGR")]
    BlueMinClampingr = unchecked((uint)0x8562),

    [NameAffix("Suffix", "INGR", 0)]
    [NativeName("GL_ALPHA_MIN_CLAMP_INGR")]
    AlphaMinClampingr = unchecked((uint)0x8563),

    [NameAffix("Suffix", "INGR", 0)]
    [NativeName("GL_RED_MAX_CLAMP_INGR")]
    RedMaxClampingr = unchecked((uint)0x8564),

    [NameAffix("Suffix", "INGR", 0)]
    [NativeName("GL_GREEN_MAX_CLAMP_INGR")]
    GreenMaxClampingr = unchecked((uint)0x8565),

    [NameAffix("Suffix", "INGR", 0)]
    [NativeName("GL_BLUE_MAX_CLAMP_INGR")]
    BlueMaxClampingr = unchecked((uint)0x8566),

    [NameAffix("Suffix", "INGR", 0)]
    [NativeName("GL_ALPHA_MAX_CLAMP_INGR")]
    AlphaMaxClampingr = unchecked((uint)0x8567),

    [NameAffix("Suffix", "INGR", 0)]
    [NativeName("GL_INTERLACE_READ_INGR")]
    InterlaceReadingr = unchecked((uint)0x8568),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_BLACKHOLE_RENDER_INTEL")]
    BlackholeRenderintel = unchecked((uint)0x83FC),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_CONSERVATIVE_RASTERIZATION_INTEL")]
    ConservativeRasterizationintel = unchecked((uint)0x83FE),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_TEXTURE_MEMORY_LAYOUT_INTEL")]
    TextureMemoryLayoutintel = unchecked((uint)0x83FF),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_LAYOUT_DEFAULT_INTEL")]
    LayoutDefaultintel = unchecked((uint)0),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_LAYOUT_LINEAR_INTEL")]
    LayoutLinearintel = unchecked((uint)1),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_LAYOUT_LINEAR_CPU_CACHED_INTEL")]
    LayoutLinearCpuCachedintel = unchecked((uint)2),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_PARALLEL_ARRAYS_INTEL")]
    ParallelArraysintel = unchecked((uint)0x83F4),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_VERTEX_ARRAY_PARALLEL_POINTERS_INTEL")]
    VertexArrayParallelPointersintel = unchecked((uint)0x83F5),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_NORMAL_ARRAY_PARALLEL_POINTERS_INTEL")]
    NormalArrayParallelPointersintel = unchecked((uint)0x83F6),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_COLOR_ARRAY_PARALLEL_POINTERS_INTEL")]
    ColorArrayParallelPointersintel = unchecked((uint)0x83F7),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_TEXTURE_COORD_ARRAY_PARALLEL_POINTERS_INTEL")]
    TextureCoordArrayParallelPointersintel = unchecked((uint)0x83F8),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_PERFQUERY_SINGLE_CONTEXT_INTEL")]
    PerfquerySingleContExtintel = unchecked((uint)0x00000000),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_PERFQUERY_GLOBAL_CONTEXT_INTEL")]
    PerfqueryGlobalContExtintel = unchecked((uint)0x00000001),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_PERFQUERY_WAIT_INTEL")]
    PerfqueryWaitintel = unchecked((uint)0x83FB),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_PERFQUERY_FLUSH_INTEL")]
    PerfqueryFlushintel = unchecked((uint)0x83FA),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_PERFQUERY_DONOT_FLUSH_INTEL")]
    PerfqueryDonotFlushintel = unchecked((uint)0x83F9),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_PERFQUERY_COUNTER_EVENT_INTEL")]
    PerfqueryCounterEventintel = unchecked((uint)0x94F0),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_PERFQUERY_COUNTER_DURATION_NORM_INTEL")]
    PerfqueryCounterDurationNormintel = unchecked((uint)0x94F1),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_PERFQUERY_COUNTER_DURATION_RAW_INTEL")]
    PerfqueryCounterDurationRawintel = unchecked((uint)0x94F2),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_PERFQUERY_COUNTER_THROUGHPUT_INTEL")]
    PerfqueryCounterThroughputintel = unchecked((uint)0x94F3),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_PERFQUERY_COUNTER_RAW_INTEL")]
    PerfqueryCounterRawintel = unchecked((uint)0x94F4),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_PERFQUERY_COUNTER_TIMESTAMP_INTEL")]
    PerfqueryCounterTimestampintel = unchecked((uint)0x94F5),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_PERFQUERY_COUNTER_DATA_UINT32_INTEL")]
    PerfqueryCounterDataUint32Intel = unchecked((uint)0x94F8),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_PERFQUERY_COUNTER_DATA_UINT64_INTEL")]
    PerfqueryCounterDataUint64Intel = unchecked((uint)0x94F9),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_PERFQUERY_COUNTER_DATA_FLOAT_INTEL")]
    PerfqueryCounterDataFloatintel = unchecked((uint)0x94FA),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_PERFQUERY_COUNTER_DATA_DOUBLE_INTEL")]
    PerfqueryCounterDataDoubleintel = unchecked((uint)0x94FB),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_PERFQUERY_COUNTER_DATA_BOOL32_INTEL")]
    PerfqueryCounterDataBool32Intel = unchecked((uint)0x94FC),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_PERFQUERY_QUERY_NAME_LENGTH_MAX_INTEL")]
    PerfqueryQueryNameLengthMaxintel = unchecked((uint)0x94FD),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_PERFQUERY_COUNTER_NAME_LENGTH_MAX_INTEL")]
    PerfqueryCounterNameLengthMaxintel = unchecked((uint)0x94FE),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_PERFQUERY_COUNTER_DESC_LENGTH_MAX_INTEL")]
    PerfqueryCounterDescLengthMaxintel = unchecked((uint)0x94FF),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_PERFQUERY_GPA_EXTENDED_COUNTERS_INTEL")]
    PerfqueryGpaExtendedCountersintel = unchecked((uint)0x9500),

    [NameAffix("Suffix", "MESAX", 0)]
    [NativeName("GL_TEXTURE_1D_STACK_MESAX")]
    Texture1DStackmesax = unchecked((uint)0x8759),

    [NameAffix("Suffix", "MESAX", 0)]
    [NativeName("GL_TEXTURE_2D_STACK_MESAX")]
    Texture2DStackmesax = unchecked((uint)0x875A),

    [NameAffix("Suffix", "MESAX", 0)]
    [NativeName("GL_PROXY_TEXTURE_1D_STACK_MESAX")]
    ProxyTexture1DStackmesax = unchecked((uint)0x875B),

    [NameAffix("Suffix", "MESAX", 0)]
    [NativeName("GL_PROXY_TEXTURE_2D_STACK_MESAX")]
    ProxyTexture2DStackmesax = unchecked((uint)0x875C),

    [NameAffix("Suffix", "MESAX", 0)]
    [NativeName("GL_TEXTURE_1D_STACK_BINDING_MESAX")]
    Texture1DStackBindingmesax = unchecked((uint)0x875D),

    [NameAffix("Suffix", "MESAX", 0)]
    [NativeName("GL_TEXTURE_2D_STACK_BINDING_MESAX")]
    Texture2DStackBindingmesax = unchecked((uint)0x875E),

    [NameAffix("Suffix", "MESA", 0)]
    [NativeName("GL_FRAMEBUFFER_FLIP_X_MESA")]
    FramebufferFlipXmesa = unchecked((uint)0x8BBC),

    [NameAffix("Suffix", "MESA", 0)]
    [NativeName("GL_FRAMEBUFFER_FLIP_Y_MESA")]
    FramebufferFlipYmesa = unchecked((uint)0x8BBB),

    [NameAffix("Suffix", "MESA", 0)]
    [NativeName("GL_FRAMEBUFFER_SWAP_XY_MESA")]
    FramebufferSwapXymesa = unchecked((uint)0x8BBD),

    [NameAffix("Suffix", "MESA", 0)]
    [NativeName("GL_PACK_INVERT_MESA")]
    PackInvertmesa = unchecked((uint)0x8758),

    [NameAffix("Suffix", "MESA", 0)]
    [NativeName("GL_PROGRAM_BINARY_FORMAT_MESA")]
    ProgramBinaryFormatmesa = unchecked((uint)0x875F),

    [NameAffix("Suffix", "MESA", 0)]
    [NativeName("GL_TILE_RASTER_ORDER_FIXED_MESA")]
    TileRasterOrderFixedmesa = unchecked((uint)0x8BB8),

    [NameAffix("Suffix", "MESA", 0)]
    [NativeName("GL_TILE_RASTER_ORDER_INCREASING_X_MESA")]
    TileRasterOrderIncreasingXmesa = unchecked((uint)0x8BB9),

    [NameAffix("Suffix", "MESA", 0)]
    [NativeName("GL_TILE_RASTER_ORDER_INCREASING_Y_MESA")]
    TileRasterOrderIncreasingYmesa = unchecked((uint)0x8BBA),

    [NameAffix("Suffix", "MESA", 0)]
    [NativeName("GL_UNSIGNED_SHORT_8_8_MESA")]
    UnsignedShort8X8Mesa = unchecked((uint)0x85BA),

    [NameAffix("Suffix", "MESA", 0)]
    [NativeName("GL_UNSIGNED_SHORT_8_8_REV_MESA")]
    UnsignedShort8X8Revmesa = unchecked((uint)0x85BB),

    [NameAffix("Suffix", "MESA", 0)]
    [NativeName("GL_YCBCR_MESA")]
    Ycbcrmesa = unchecked((uint)0x8757),

    [NameAffix("Suffix", "NVX", 0)]
    [NativeName("GL_GPU_MEMORY_INFO_DEDICATED_VIDMEM_NVX")]
    GpuMemoryInfoDedicatedVidmemnvx = unchecked((uint)0x9047),

    [NameAffix("Suffix", "NVX", 0)]
    [NativeName("GL_GPU_MEMORY_INFO_TOTAL_AVAILABLE_MEMORY_NVX")]
    GpuMemoryInfoTotalAvailableMemorynvx = unchecked((uint)0x9048),

    [NameAffix("Suffix", "NVX", 0)]
    [NativeName("GL_GPU_MEMORY_INFO_CURRENT_AVAILABLE_VIDMEM_NVX")]
    GpuMemoryInfoCurrentAvailableVidmemnvx = unchecked((uint)0x9049),

    [NameAffix("Suffix", "NVX", 0)]
    [NativeName("GL_GPU_MEMORY_INFO_EVICTION_COUNT_NVX")]
    GpuMemoryInfoEvictionCountnvx = unchecked((uint)0x904A),

    [NameAffix("Suffix", "NVX", 0)]
    [NativeName("GL_GPU_MEMORY_INFO_EVICTED_MEMORY_NVX")]
    GpuMemoryInfoEvictedMemorynvx = unchecked((uint)0x904B),

    [NameAffix("Suffix", "NVX", 0)]
    [NativeName("GL_UPLOAD_GPU_MASK_NVX")]
    UploadGpuMasknvx = unchecked((uint)0x954A),

    [NameAffix("Suffix", "NVX", 0)]
    [NativeName("GL_LGPU_SEPARATE_STORAGE_BIT_NVX")]
    LgpuSeparateStorageBitnvx = unchecked((uint)0x0800),

    [NameAffix("Suffix", "NVX", 0)]
    [NativeName("GL_MAX_LGPU_GPUS_NVX")]
    MaxLgpuGpusnvx = unchecked((uint)0x92BA),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ALPHA_TO_COVERAGE_DITHER_DEFAULT_NV")]
    AlphaToCoverageDitherDefaultnv = unchecked((uint)0x934D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ALPHA_TO_COVERAGE_DITHER_ENABLE_NV")]
    AlphaToCoverageDitherEnablenv = unchecked((uint)0x934E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ALPHA_TO_COVERAGE_DITHER_DISABLE_NV")]
    AlphaToCoverageDitherDisablenv = unchecked((uint)0x934F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ALPHA_TO_COVERAGE_DITHER_MODE_NV")]
    AlphaToCoverageDitherModenv = unchecked((uint)0x92BF),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_BLEND_OVERLAP_NV")]
    BlendOverlapnv = unchecked((uint)0x9281),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_BLEND_PREMULTIPLIED_SRC_NV")]
    BlendPremultipliedSrcnv = unchecked((uint)0x9280),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_BLUE_NV")]
    Bluenv = unchecked((uint)0x1905),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLORBURN_NV")]
    Colorburnnv = unchecked((uint)0x929A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLORDODGE_NV")]
    Colordodgenv = unchecked((uint)0x9299),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CONJOINT_NV")]
    Conjointnv = unchecked((uint)0x9284),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CONTRAST_NV")]
    Contrastnv = unchecked((uint)0x92A1),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DARKEN_NV")]
    Darkennv = unchecked((uint)0x9297),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DIFFERENCE_NV")]
    Differencenv = unchecked((uint)0x929E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DISJOINT_NV")]
    Disjointnv = unchecked((uint)0x9283),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DST_ATOP_NV")]
    DstAtopnv = unchecked((uint)0x928F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DST_IN_NV")]
    DstInnv = unchecked((uint)0x928B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DST_NV")]
    Dstnv = unchecked((uint)0x9287),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DST_OUT_NV")]
    DstOutnv = unchecked((uint)0x928D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DST_OVER_NV")]
    DstOvernv = unchecked((uint)0x9289),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_EXCLUSION_NV")]
    Exclusionnv = unchecked((uint)0x92A0),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_GREEN_NV")]
    Greennv = unchecked((uint)0x1904),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_HARDLIGHT_NV")]
    Hardlightnv = unchecked((uint)0x929B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_HARDMIX_NV")]
    Hardmixnv = unchecked((uint)0x92A9),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_HSL_COLOR_NV")]
    HslColornv = unchecked((uint)0x92AF),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_HSL_HUE_NV")]
    HslHuenv = unchecked((uint)0x92AD),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_HSL_LUMINOSITY_NV")]
    HslLuminositynv = unchecked((uint)0x92B0),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_HSL_SATURATION_NV")]
    HslSaturationnv = unchecked((uint)0x92AE),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_INVERT_OVG_NV")]
    InvertOvgnv = unchecked((uint)0x92B4),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_INVERT_RGB_NV")]
    InvertRgbnv = unchecked((uint)0x92A3),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_LIGHTEN_NV")]
    Lightennv = unchecked((uint)0x9298),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_LINEARBURN_NV")]
    Linearburnnv = unchecked((uint)0x92A5),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_LINEARDODGE_NV")]
    Lineardodgenv = unchecked((uint)0x92A4),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_LINEARLIGHT_NV")]
    Linearlightnv = unchecked((uint)0x92A7),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MINUS_CLAMPED_NV")]
    MinusClampednv = unchecked((uint)0x92B3),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MINUS_NV")]
    Minusnv = unchecked((uint)0x929F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MULTIPLY_NV")]
    Multiplynv = unchecked((uint)0x9294),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_OVERLAY_NV")]
    Overlaynv = unchecked((uint)0x9296),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PINLIGHT_NV")]
    Pinlightnv = unchecked((uint)0x92A8),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PLUS_CLAMPED_ALPHA_NV")]
    PlusClampedAlphanv = unchecked((uint)0x92B2),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PLUS_CLAMPED_NV")]
    PlusClampednv = unchecked((uint)0x92B1),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PLUS_DARKER_NV")]
    PlusDarkernv = unchecked((uint)0x9292),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PLUS_NV")]
    Plusnv = unchecked((uint)0x9291),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RED_NV")]
    Rednv = unchecked((uint)0x1903),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SCREEN_NV")]
    Screennv = unchecked((uint)0x9295),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SOFTLIGHT_NV")]
    Softlightnv = unchecked((uint)0x929C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SRC_ATOP_NV")]
    SrcAtopnv = unchecked((uint)0x928E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SRC_IN_NV")]
    SrcInnv = unchecked((uint)0x928A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SRC_NV")]
    Srcnv = unchecked((uint)0x9286),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SRC_OUT_NV")]
    SrcOutnv = unchecked((uint)0x928C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SRC_OVER_NV")]
    SrcOvernv = unchecked((uint)0x9288),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_UNCORRELATED_NV")]
    Uncorrelatednv = unchecked((uint)0x9282),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIVIDLIGHT_NV")]
    Vividlightnv = unchecked((uint)0x92A6),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_XOR_NV")]
    Xornv = unchecked((uint)0x1506),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_BLEND_ADVANCED_COHERENT_NV")]
    BlendAdvancedCoherentnv = unchecked((uint)0x9285),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIEWPORT_POSITION_W_SCALE_NV")]
    ViewportPositionWScalenv = unchecked((uint)0x937C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIEWPORT_POSITION_W_SCALE_X_COEFF_NV")]
    ViewportPositionWScaleXCoeffnv = unchecked((uint)0x937D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIEWPORT_POSITION_W_SCALE_Y_COEFF_NV")]
    ViewportPositionWScaleYCoeffnv = unchecked((uint)0x937E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TERMINATE_SEQUENCE_COMMAND_NV")]
    TerminateSequenceCommandnv = unchecked((uint)0x0000),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_NOP_COMMAND_NV")]
    NopCommandnv = unchecked((uint)0x0001),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_ELEMENTS_COMMAND_NV")]
    DrawElementsCommandnv = unchecked((uint)0x0002),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_ARRAYS_COMMAND_NV")]
    DrawArraysCommandnv = unchecked((uint)0x0003),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_ELEMENTS_STRIP_COMMAND_NV")]
    DrawElementsStripCommandnv = unchecked((uint)0x0004),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_ARRAYS_STRIP_COMMAND_NV")]
    DrawArraysStripCommandnv = unchecked((uint)0x0005),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_ELEMENTS_INSTANCED_COMMAND_NV")]
    DrawElementsInstancedCommandnv = unchecked((uint)0x0006),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_ARRAYS_INSTANCED_COMMAND_NV")]
    DrawArraysInstancedCommandnv = unchecked((uint)0x0007),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ELEMENT_ADDRESS_COMMAND_NV")]
    ElementAddressCommandnv = unchecked((uint)0x0008),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ATTRIBUTE_ADDRESS_COMMAND_NV")]
    AttributeAddressCommandnv = unchecked((uint)0x0009),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_UNIFORM_ADDRESS_COMMAND_NV")]
    UniformAddressCommandnv = unchecked((uint)0x000A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_BLEND_COLOR_COMMAND_NV")]
    BlendColorCommandnv = unchecked((uint)0x000B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_STENCIL_REF_COMMAND_NV")]
    StencilRefCommandnv = unchecked((uint)0x000C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_LINE_WIDTH_COMMAND_NV")]
    LineWidthCommandnv = unchecked((uint)0x000D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_POLYGON_OFFSET_COMMAND_NV")]
    PolygonOffsetCommandnv = unchecked((uint)0x000E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ALPHA_REF_COMMAND_NV")]
    AlphaRefCommandnv = unchecked((uint)0x000F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIEWPORT_COMMAND_NV")]
    ViewportCommandnv = unchecked((uint)0x0010),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SCISSOR_COMMAND_NV")]
    ScissorCommandnv = unchecked((uint)0x0011),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FRONT_FACE_COMMAND_NV")]
    FrontFaceCommandnv = unchecked((uint)0x0012),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMPUTE_PROGRAM_NV")]
    ComputeProgramnv = unchecked((uint)0x90FB),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMPUTE_PROGRAM_PARAMETER_BUFFER_NV")]
    ComputeProgramParameterBuffernv = unchecked((uint)0x90FC),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_QUERY_WAIT_NV")]
    QueryWaitnv = unchecked((uint)0x8E13),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_QUERY_NO_WAIT_NV")]
    QueryNoWaitnv = unchecked((uint)0x8E14),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_QUERY_BY_REGION_WAIT_NV")]
    QueryByRegionWaitnv = unchecked((uint)0x8E15),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_QUERY_BY_REGION_NO_WAIT_NV")]
    QueryByRegionNoWaitnv = unchecked((uint)0x8E16),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CONSERVATIVE_RASTERIZATION_NV")]
    ConservativeRasterizationnv = unchecked((uint)0x9346),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SUBPIXEL_PRECISION_BIAS_X_BITS_NV")]
    SubpixelPrecisionBiasXBitsnv = unchecked((uint)0x9347),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SUBPIXEL_PRECISION_BIAS_Y_BITS_NV")]
    SubpixelPrecisionBiasYBitsnv = unchecked((uint)0x9348),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_SUBPIXEL_PRECISION_BIAS_BITS_NV")]
    MaxSubpixelPrecisionBiasBitsnv = unchecked((uint)0x9349),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CONSERVATIVE_RASTER_DILATE_NV")]
    ConservativeRasterDilatenv = unchecked((uint)0x9379),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CONSERVATIVE_RASTER_DILATE_RANGE_NV")]
    ConservativeRasterDilateRangenv = unchecked((uint)0x937A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CONSERVATIVE_RASTER_DILATE_GRANULARITY_NV")]
    ConservativeRasterDilateGranularitynv = unchecked((uint)0x937B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CONSERVATIVE_RASTER_MODE_PRE_SNAP_NV")]
    ConservativeRasterModePreSnapnv = unchecked((uint)0x9550),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CONSERVATIVE_RASTER_MODE_NV")]
    ConservativeRasterModenv = unchecked((uint)0x954D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CONSERVATIVE_RASTER_MODE_POST_SNAP_NV")]
    ConservativeRasterModePostSnapnv = unchecked((uint)0x954E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CONSERVATIVE_RASTER_MODE_PRE_SNAP_TRIANGLES_NV")]
    ConservativeRasterModePreSnapTrianglesnv = unchecked((uint)0x954F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DEPTH_STENCIL_TO_RGBA_NV")]
    DepthStencilToRgbanv = unchecked((uint)0x886E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DEPTH_STENCIL_TO_BGRA_NV")]
    DepthStencilToBgranv = unchecked((uint)0x886F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_DEEP_3D_TEXTURE_WIDTH_HEIGHT_NV")]
    MaxDeep3DTextureWidthHeightnv = unchecked((uint)0x90D0),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_DEEP_3D_TEXTURE_DEPTH_NV")]
    MaxDeep3DTextureDepthnv = unchecked((uint)0x90D1),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DEPTH_COMPONENT32F_NV")]
    DepthComponent32Fnv = unchecked((uint)0x8DAB),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DEPTH32F_STENCIL8_NV")]
    Depth32FStencil8Nv = unchecked((uint)0x8DAC),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FLOAT_32_UNSIGNED_INT_24_8_REV_NV")]
    Float32UnsignedInt24X8Revnv = unchecked((uint)0x8DAD),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DEPTH_BUFFER_FLOAT_MODE_NV")]
    DepthBufferFloatModenv = unchecked((uint)0x8DAF),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DEPTH_CLAMP_NV")]
    DepthClampnv = unchecked((uint)0x864F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_EVAL_2D_NV")]
    Eval2Dnv = unchecked((uint)0x86C0),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_EVAL_TRIANGULAR_2D_NV")]
    EvalTriangular2Dnv = unchecked((uint)0x86C1),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP_TESSELLATION_NV")]
    MapTessellationnv = unchecked((uint)0x86C2),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP_ATTRIB_U_ORDER_NV")]
    MapAttribUOrdernv = unchecked((uint)0x86C3),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP_ATTRIB_V_ORDER_NV")]
    MapAttribVOrdernv = unchecked((uint)0x86C4),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_EVAL_FRACTIONAL_TESSELLATION_NV")]
    EvalFractionalTessellationnv = unchecked((uint)0x86C5),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_EVAL_VERTEX_ATTRIB0_NV")]
    EvalVertexAttrib0Nv = unchecked((uint)0x86C6),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_EVAL_VERTEX_ATTRIB1_NV")]
    EvalVertexAttrib1Nv = unchecked((uint)0x86C7),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_EVAL_VERTEX_ATTRIB2_NV")]
    EvalVertexAttrib2Nv = unchecked((uint)0x86C8),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_EVAL_VERTEX_ATTRIB3_NV")]
    EvalVertexAttrib3Nv = unchecked((uint)0x86C9),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_EVAL_VERTEX_ATTRIB4_NV")]
    EvalVertexAttrib4Nv = unchecked((uint)0x86CA),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_EVAL_VERTEX_ATTRIB5_NV")]
    EvalVertexAttrib5Nv = unchecked((uint)0x86CB),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_EVAL_VERTEX_ATTRIB6_NV")]
    EvalVertexAttrib6Nv = unchecked((uint)0x86CC),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_EVAL_VERTEX_ATTRIB7_NV")]
    EvalVertexAttrib7Nv = unchecked((uint)0x86CD),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_EVAL_VERTEX_ATTRIB8_NV")]
    EvalVertexAttrib8Nv = unchecked((uint)0x86CE),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_EVAL_VERTEX_ATTRIB9_NV")]
    EvalVertexAttrib9Nv = unchecked((uint)0x86CF),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_EVAL_VERTEX_ATTRIB10_NV")]
    EvalVertexAttrib10Nv = unchecked((uint)0x86D0),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_EVAL_VERTEX_ATTRIB11_NV")]
    EvalVertexAttrib11Nv = unchecked((uint)0x86D1),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_EVAL_VERTEX_ATTRIB12_NV")]
    EvalVertexAttrib12Nv = unchecked((uint)0x86D2),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_EVAL_VERTEX_ATTRIB13_NV")]
    EvalVertexAttrib13Nv = unchecked((uint)0x86D3),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_EVAL_VERTEX_ATTRIB14_NV")]
    EvalVertexAttrib14Nv = unchecked((uint)0x86D4),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_EVAL_VERTEX_ATTRIB15_NV")]
    EvalVertexAttrib15Nv = unchecked((uint)0x86D5),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_MAP_TESSELLATION_NV")]
    MaxMapTessellationnv = unchecked((uint)0x86D6),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_RATIONAL_EVAL_ORDER_NV")]
    MaxRationalEvalOrdernv = unchecked((uint)0x86D7),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SAMPLE_POSITION_NV")]
    SamplePositionnv = unchecked((uint)0x8E50),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SAMPLE_MASK_NV")]
    SampleMasknv = unchecked((uint)0x8E51),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SAMPLE_MASK_VALUE_NV")]
    SampleMaskValuenv = unchecked((uint)0x8E52),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TEXTURE_BINDING_RENDERBUFFER_NV")]
    TextureBindingRenderbuffernv = unchecked((uint)0x8E53),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TEXTURE_RENDERBUFFER_DATA_STORE_BINDING_NV")]
    TextureRenderbufferDataStoreBindingnv = unchecked((uint)0x8E54),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TEXTURE_RENDERBUFFER_NV")]
    TextureRenderbuffernv = unchecked((uint)0x8E55),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SAMPLER_RENDERBUFFER_NV")]
    SamplerRenderbuffernv = unchecked((uint)0x8E56),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_INT_SAMPLER_RENDERBUFFER_NV")]
    IntSamplerRenderbuffernv = unchecked((uint)0x8E57),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_UNSIGNED_INT_SAMPLER_RENDERBUFFER_NV")]
    UnsignedIntSamplerRenderbuffernv = unchecked((uint)0x8E58),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_SAMPLE_MASK_WORDS_NV")]
    MaxSampleMaskWordsnv = unchecked((uint)0x8E59),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FILL_RECTANGLE_NV")]
    FillRectAnglenv = unchecked((uint)0x933C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FLOAT_R_NV")]
    FloatRnv = unchecked((uint)0x8880),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FLOAT_RG_NV")]
    FloatRgnv = unchecked((uint)0x8881),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FLOAT_RGB_NV")]
    FloatRgbnv = unchecked((uint)0x8882),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FLOAT_RGBA_NV")]
    FloatRgbanv = unchecked((uint)0x8883),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FLOAT_R16_NV")]
    FloatR16Nv = unchecked((uint)0x8884),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FLOAT_R32_NV")]
    FloatR32Nv = unchecked((uint)0x8885),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FLOAT_RG16_NV")]
    FloatRg16Nv = unchecked((uint)0x8886),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FLOAT_RG32_NV")]
    FloatRg32Nv = unchecked((uint)0x8887),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FLOAT_RGB16_NV")]
    FloatRgb16Nv = unchecked((uint)0x8888),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FLOAT_RGB32_NV")]
    FloatRgb32Nv = unchecked((uint)0x8889),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FLOAT_RGBA16_NV")]
    FloatRgba16Nv = unchecked((uint)0x888A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FLOAT_RGBA32_NV")]
    FloatRgba32Nv = unchecked((uint)0x888B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TEXTURE_FLOAT_COMPONENTS_NV")]
    TextureFloatComponentsnv = unchecked((uint)0x888C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FLOAT_CLEAR_COLOR_VALUE_NV")]
    FloatClearColorValuenv = unchecked((uint)0x888D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FLOAT_RGBA_MODE_NV")]
    FloatRgbaModenv = unchecked((uint)0x888E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FOG_DISTANCE_MODE_NV")]
    FogDistanceModenv = unchecked((uint)0x855A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_EYE_RADIAL_NV")]
    EyeRadialnv = unchecked((uint)0x855B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_EYE_PLANE_ABSOLUTE_NV")]
    EyePlaneAbsolutenv = unchecked((uint)0x855C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FRAGMENT_COVERAGE_TO_COLOR_NV")]
    FragmentCoverageToColornv = unchecked((uint)0x92DD),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FRAGMENT_COVERAGE_COLOR_NV")]
    FragmentCoverageColornv = unchecked((uint)0x92DE),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_FRAGMENT_PROGRAM_LOCAL_PARAMETERS_NV")]
    MaxFragmentProgramLocalParametersnv = unchecked((uint)0x8868),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FRAGMENT_PROGRAM_NV")]
    FragmentProgramnv = unchecked((uint)0x8870),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_TEXTURE_COORDS_NV")]
    MaxTextureCoordsnv = unchecked((uint)0x8871),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_TEXTURE_IMAGE_UNITS_NV")]
    MaxTextureImageUnitsnv = unchecked((uint)0x8872),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FRAGMENT_PROGRAM_BINDING_NV")]
    FragmentProgramBindingnv = unchecked((uint)0x8873),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PROGRAM_ERROR_STRING_NV")]
    ProgramErrorStringnv = unchecked((uint)0x8874),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_PROGRAM_EXEC_INSTRUCTIONS_NV")]
    MaxProgramExecInstructionsnv = unchecked((uint)0x88F4),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_PROGRAM_CALL_DEPTH_NV")]
    MaxProgramCallDepthnv = unchecked((uint)0x88F5),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_PROGRAM_IF_DEPTH_NV")]
    MaxProgramIfDepthnv = unchecked((uint)0x88F6),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_PROGRAM_LOOP_DEPTH_NV")]
    MaxProgramLoopDepthnv = unchecked((uint)0x88F7),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_PROGRAM_LOOP_COUNT_NV")]
    MaxProgramLoopCountnv = unchecked((uint)0x88F8),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COVERAGE_MODULATION_TABLE_NV")]
    CoverageModulationTablenv = unchecked((uint)0x9331),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_SAMPLES_NV")]
    ColorSamplesnv = unchecked((uint)0x8E20),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DEPTH_SAMPLES_NV")]
    DepthSamplesnv = unchecked((uint)0x932D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_STENCIL_SAMPLES_NV")]
    StencilSamplesnv = unchecked((uint)0x932E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MIXED_DEPTH_SAMPLES_SUPPORTED_NV")]
    MixedDepthSamplesSupportednv = unchecked((uint)0x932F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MIXED_STENCIL_SAMPLES_SUPPORTED_NV")]
    MixedStencilSamplesSupportednv = unchecked((uint)0x9330),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COVERAGE_MODULATION_NV")]
    CoverageModulationnv = unchecked((uint)0x9332),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COVERAGE_MODULATION_TABLE_SIZE_NV")]
    CoverageModulationTableSizenv = unchecked((uint)0x9333),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RENDERBUFFER_COVERAGE_SAMPLES_NV")]
    RenderbufferCoverageSamplesnv = unchecked((uint)0x8CAB),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RENDERBUFFER_COLOR_SAMPLES_NV")]
    RenderbufferColorSamplesnv = unchecked((uint)0x8E10),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_MULTISAMPLE_COVERAGE_MODES_NV")]
    MaxMultisampleCoverageModesnv = unchecked((uint)0x8E11),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MULTISAMPLE_COVERAGE_MODES_NV")]
    MultisampleCoverageModesnv = unchecked((uint)0x8E12),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_GEOMETRY_PROGRAM_NV")]
    GeometryProgramnv = unchecked((uint)0x8C26),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_PROGRAM_OUTPUT_VERTICES_NV")]
    MaxProgramOutputVerticesnv = unchecked((uint)0x8C27),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_PROGRAM_TOTAL_OUTPUT_COMPONENTS_NV")]
    MaxProgramTotalOutputComponentsnv = unchecked((uint)0x8C28),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PER_GPU_STORAGE_BIT_NV")]
    PerGpuStorageBitnv = unchecked((uint)0x0800),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MULTICAST_GPUS_NV")]
    MulticastGpusnv = unchecked((uint)0x92BA),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RENDER_GPU_MASK_NV")]
    RenderGpuMasknv = unchecked((uint)0x9558),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PER_GPU_STORAGE_NV")]
    PerGpuStoragenv = unchecked((uint)0x9548),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MULTICAST_PROGRAMMABLE_SAMPLE_LOCATION_NV")]
    MulticastProgrammableSampleLocationnv = unchecked((uint)0x9549),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MIN_PROGRAM_TEXEL_OFFSET_NV")]
    MinProgramTexelOffsetnv = unchecked((uint)0x8904),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_PROGRAM_TEXEL_OFFSET_NV")]
    MaxProgramTexelOffsetnv = unchecked((uint)0x8905),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PROGRAM_ATTRIB_COMPONENTS_NV")]
    ProgramAttribComponentsnv = unchecked((uint)0x8906),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PROGRAM_RESULT_COMPONENTS_NV")]
    ProgramResultComponentsnv = unchecked((uint)0x8907),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_PROGRAM_ATTRIB_COMPONENTS_NV")]
    MaxProgramAttribComponentsnv = unchecked((uint)0x8908),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_PROGRAM_RESULT_COMPONENTS_NV")]
    MaxProgramResultComponentsnv = unchecked((uint)0x8909),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_PROGRAM_GENERIC_ATTRIBS_NV")]
    MaxProgramGenericAttribsnv = unchecked((uint)0x8DA5),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_PROGRAM_GENERIC_RESULTS_NV")]
    MaxProgramGenericResultsnv = unchecked((uint)0x8DA6),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_GEOMETRY_PROGRAM_INVOCATIONS_NV")]
    MaxGeometryProgramInvocationsnv = unchecked((uint)0x8E5A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MIN_FRAGMENT_INTERPOLATION_OFFSET_NV")]
    MinFragmentInterpolationOffsetnv = unchecked((uint)0x8E5B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_FRAGMENT_INTERPOLATION_OFFSET_NV")]
    MaxFragmentInterpolationOffsetnv = unchecked((uint)0x8E5C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FRAGMENT_PROGRAM_INTERPOLATION_OFFSET_BITS_NV")]
    FragmentProgramInterpolationOffsetBitsnv = unchecked((uint)0x8E5D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET_NV")]
    MinProgramTextureGatherOffsetnv = unchecked((uint)0x8E5E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET_NV")]
    MaxProgramTextureGatherOffsetnv = unchecked((uint)0x8E5F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_PROGRAM_SUBROUTINE_PARAMETERS_NV")]
    MaxProgramSubroutineParametersnv = unchecked((uint)0x8F44),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_PROGRAM_SUBROUTINE_NUM_NV")]
    MaxProgramSubroutineNumnv = unchecked((uint)0x8F45),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_HALF_FLOAT_NV")]
    HalfFloatnv = unchecked((uint)0x140B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MULTISAMPLES_NV")]
    Multisamplesnv = unchecked((uint)0x9371),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SUPERSAMPLE_SCALE_X_NV")]
    SupersampleScaleXnv = unchecked((uint)0x9372),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SUPERSAMPLE_SCALE_Y_NV")]
    SupersampleScaleYnv = unchecked((uint)0x9373),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CONFORMANT_NV")]
    Conformantnv = unchecked((uint)0x9374),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_SHININESS_NV")]
    MaxShininessnv = unchecked((uint)0x8504),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_SPOT_EXPONENT_NV")]
    MaxSpotExponentnv = unchecked((uint)0x8505),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ATTACHED_MEMORY_OBJECT_NV")]
    AttachedMemoryObjectnv = unchecked((uint)0x95A4),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ATTACHED_MEMORY_OFFSET_NV")]
    AttachedMemoryOffsetnv = unchecked((uint)0x95A5),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MEMORY_ATTACHABLE_ALIGNMENT_NV")]
    MemoryAttachableAlignmentnv = unchecked((uint)0x95A6),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MEMORY_ATTACHABLE_SIZE_NV")]
    MemoryAttachableSizenv = unchecked((uint)0x95A7),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MEMORY_ATTACHABLE_NV")]
    MemoryAttachablenv = unchecked((uint)0x95A8),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DETACHED_MEMORY_INCARNATION_NV")]
    DetachedMemoryIncarnationnv = unchecked((uint)0x95A9),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DETACHED_TEXTURES_NV")]
    DetachedTexturesnv = unchecked((uint)0x95AA),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DETACHED_BUFFERS_NV")]
    DetachedBuffersnv = unchecked((uint)0x95AB),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_DETACHED_TEXTURES_NV")]
    MaxDetachedTexturesnv = unchecked((uint)0x95AC),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_DETACHED_BUFFERS_NV")]
    MaxDetachedBuffersnv = unchecked((uint)0x95AD),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MESH_SHADER_NV")]
    MeshShadernv = unchecked((uint)0x9559),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TASK_SHADER_NV")]
    TaskShadernv = unchecked((uint)0x955A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_MESH_UNIFORM_BLOCKS_NV")]
    MaxMeshUniformBlocksnv = unchecked((uint)0x8E60),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_MESH_TEXTURE_IMAGE_UNITS_NV")]
    MaxMeshTextureImageUnitsnv = unchecked((uint)0x8E61),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_MESH_IMAGE_UNIFORMS_NV")]
    MaxMeshImageUniformsnv = unchecked((uint)0x8E62),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_MESH_UNIFORM_COMPONENTS_NV")]
    MaxMeshUniformComponentsnv = unchecked((uint)0x8E63),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_MESH_ATOMIC_COUNTER_BUFFERS_NV")]
    MaxMeshAtomicCounterBuffersnv = unchecked((uint)0x8E64),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_MESH_ATOMIC_COUNTERS_NV")]
    MaxMeshAtomicCountersnv = unchecked((uint)0x8E65),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_MESH_SHADER_STORAGE_BLOCKS_NV")]
    MaxMeshShaderStorageBlocksnv = unchecked((uint)0x8E66),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_COMBINED_MESH_UNIFORM_COMPONENTS_NV")]
    MaxCombinedMeshUniformComponentsnv = unchecked((uint)0x8E67),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_TASK_UNIFORM_BLOCKS_NV")]
    MaxTaskUniformBlocksnv = unchecked((uint)0x8E68),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_TASK_TEXTURE_IMAGE_UNITS_NV")]
    MaxTaskTextureImageUnitsnv = unchecked((uint)0x8E69),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_TASK_IMAGE_UNIFORMS_NV")]
    MaxTaskImageUniformsnv = unchecked((uint)0x8E6A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_TASK_UNIFORM_COMPONENTS_NV")]
    MaxTaskUniformComponentsnv = unchecked((uint)0x8E6B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_TASK_ATOMIC_COUNTER_BUFFERS_NV")]
    MaxTaskAtomicCounterBuffersnv = unchecked((uint)0x8E6C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_TASK_ATOMIC_COUNTERS_NV")]
    MaxTaskAtomicCountersnv = unchecked((uint)0x8E6D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_TASK_SHADER_STORAGE_BLOCKS_NV")]
    MaxTaskShaderStorageBlocksnv = unchecked((uint)0x8E6E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_COMBINED_TASK_UNIFORM_COMPONENTS_NV")]
    MaxCombinedTaskUniformComponentsnv = unchecked((uint)0x8E6F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_MESH_WORK_GROUP_INVOCATIONS_NV")]
    MaxMeshWorkGroupInvocationsnv = unchecked((uint)0x95A2),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_TASK_WORK_GROUP_INVOCATIONS_NV")]
    MaxTaskWorkGroupInvocationsnv = unchecked((uint)0x95A3),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_MESH_TOTAL_MEMORY_SIZE_NV")]
    MaxMeshTotalMemorySizenv = unchecked((uint)0x9536),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_TASK_TOTAL_MEMORY_SIZE_NV")]
    MaxTaskTotalMemorySizenv = unchecked((uint)0x9537),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_MESH_OUTPUT_VERTICES_NV")]
    MaxMeshOutputVerticesnv = unchecked((uint)0x9538),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_MESH_OUTPUT_PRIMITIVES_NV")]
    MaxMeshOutputPrimitivesnv = unchecked((uint)0x9539),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_TASK_OUTPUT_COUNT_NV")]
    MaxTaskOutputCountnv = unchecked((uint)0x953A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_DRAW_MESH_TASKS_COUNT_NV")]
    MaxDrawMeshTasksCountnv = unchecked((uint)0x953D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_MESH_VIEWS_NV")]
    MaxMeshViewsnv = unchecked((uint)0x9557),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MESH_OUTPUT_PER_VERTEX_GRANULARITY_NV")]
    MeshOutputPerVertexGranularitynv = unchecked((uint)0x92DF),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MESH_OUTPUT_PER_PRIMITIVE_GRANULARITY_NV")]
    MeshOutputPerPrimitiveGranularitynv = unchecked((uint)0x9543),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_MESH_WORK_GROUP_SIZE_NV")]
    MaxMeshWorkGroupSizenv = unchecked((uint)0x953B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_TASK_WORK_GROUP_SIZE_NV")]
    MaxTaskWorkGroupSizenv = unchecked((uint)0x953C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MESH_WORK_GROUP_SIZE_NV")]
    MeshWorkGroupSizenv = unchecked((uint)0x953E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TASK_WORK_GROUP_SIZE_NV")]
    TaskWorkGroupSizenv = unchecked((uint)0x953F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MESH_VERTICES_OUT_NV")]
    MeshVerticesOutnv = unchecked((uint)0x9579),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MESH_PRIMITIVES_OUT_NV")]
    MeshPrimitivesOutnv = unchecked((uint)0x957A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MESH_OUTPUT_TYPE_NV")]
    MeshOutputTypenv = unchecked((uint)0x957B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_UNIFORM_BLOCK_REFERENCED_BY_MESH_SHADER_NV")]
    UniformBlockReferencedByMeshShadernv = unchecked((uint)0x959C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_UNIFORM_BLOCK_REFERENCED_BY_TASK_SHADER_NV")]
    UniformBlockReferencedByTaskShadernv = unchecked((uint)0x959D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_REFERENCED_BY_MESH_SHADER_NV")]
    ReferencedByMeshShadernv = unchecked((uint)0x95A0),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_REFERENCED_BY_TASK_SHADER_NV")]
    ReferencedByTaskShadernv = unchecked((uint)0x95A1),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MESH_SHADER_BIT_NV")]
    MeshShaderBitnv = unchecked((uint)0x00000040),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TASK_SHADER_BIT_NV")]
    TaskShaderBitnv = unchecked((uint)0x00000080),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MESH_SUBROUTINE_NV")]
    MeshSubroutinenv = unchecked((uint)0x957C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TASK_SUBROUTINE_NV")]
    TaskSubroutinenv = unchecked((uint)0x957D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MESH_SUBROUTINE_UNIFORM_NV")]
    MeshSubroutineUniformnv = unchecked((uint)0x957E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TASK_SUBROUTINE_UNIFORM_NV")]
    TaskSubroutineUniformnv = unchecked((uint)0x957F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_MESH_SHADER_NV")]
    AtomicCounterBufferReferencedByMeshShadernv = unchecked((uint)0x959E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TASK_SHADER_NV")]
    AtomicCounterBufferReferencedByTaskShadernv = unchecked((uint)0x959F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MULTISAMPLE_FILTER_HINT_NV")]
    MultisampleFilterHintnv = unchecked((uint)0x8534),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PIXEL_COUNTER_BITS_NV")]
    PixelCounterBitsnv = unchecked((uint)0x8864),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CURRENT_OCCLUSION_QUERY_ID_NV")]
    CurrentOcclusionQueryIdnv = unchecked((uint)0x8865),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PIXEL_COUNT_NV")]
    PixelCountnv = unchecked((uint)0x8866),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PIXEL_COUNT_AVAILABLE_NV")]
    PixelCountAvailablenv = unchecked((uint)0x8867),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DEPTH_STENCIL_NV")]
    DepthStencilnv = unchecked((uint)0x84F9),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_UNSIGNED_INT_24_8_NV")]
    UnsignedInt24X8Nv = unchecked((uint)0x84FA),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_PROGRAM_PARAMETER_BUFFER_BINDINGS_NV")]
    MaxProgramParameterBufferBindingsnv = unchecked((uint)0x8DA0),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_PROGRAM_PARAMETER_BUFFER_SIZE_NV")]
    MaxProgramParameterBufferSizenv = unchecked((uint)0x8DA1),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_PROGRAM_PARAMETER_BUFFER_NV")]
    VertexProgramParameterBuffernv = unchecked((uint)0x8DA2),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_GEOMETRY_PROGRAM_PARAMETER_BUFFER_NV")]
    GeometryProgramParameterBuffernv = unchecked((uint)0x8DA3),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FRAGMENT_PROGRAM_PARAMETER_BUFFER_NV")]
    FragmentProgramParameterBuffernv = unchecked((uint)0x8DA4),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_FORMAT_SVG_NV")]
    PathFormatSvgnv = unchecked((uint)0x9070),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_FORMAT_PS_NV")]
    PathFormatPsnv = unchecked((uint)0x9071),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_STANDARD_FONT_NAME_NV")]
    StandardFontNamenv = unchecked((uint)0x9072),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SYSTEM_FONT_NAME_NV")]
    SystemFontNamenv = unchecked((uint)0x9073),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FILE_NAME_NV")]
    FileNamenv = unchecked((uint)0x9074),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_STROKE_WIDTH_NV")]
    PathStrokeWidthnv = unchecked((uint)0x9075),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_END_CAPS_NV")]
    PathEndCapsnv = unchecked((uint)0x9076),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_INITIAL_END_CAP_NV")]
    PathInitialEndCapnv = unchecked((uint)0x9077),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_TERMINAL_END_CAP_NV")]
    PathTerminalEndCapnv = unchecked((uint)0x9078),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_JOIN_STYLE_NV")]
    PathJoinStylenv = unchecked((uint)0x9079),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_MITER_LIMIT_NV")]
    PathMiterLimitnv = unchecked((uint)0x907A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_DASH_CAPS_NV")]
    PathDashCapsnv = unchecked((uint)0x907B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_INITIAL_DASH_CAP_NV")]
    PathInitialDashCapnv = unchecked((uint)0x907C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_TERMINAL_DASH_CAP_NV")]
    PathTerminalDashCapnv = unchecked((uint)0x907D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_DASH_OFFSET_NV")]
    PathDashOffsetnv = unchecked((uint)0x907E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_CLIENT_LENGTH_NV")]
    PathClientLengthnv = unchecked((uint)0x907F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_FILL_MODE_NV")]
    PathFillModenv = unchecked((uint)0x9080),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_FILL_MASK_NV")]
    PathFillMasknv = unchecked((uint)0x9081),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_FILL_COVER_MODE_NV")]
    PathFillCoverModenv = unchecked((uint)0x9082),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_STROKE_COVER_MODE_NV")]
    PathStrokeCoverModenv = unchecked((uint)0x9083),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_STROKE_MASK_NV")]
    PathStrokeMasknv = unchecked((uint)0x9084),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COUNT_UP_NV")]
    CountUpnv = unchecked((uint)0x9088),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COUNT_DOWN_NV")]
    CountDownnv = unchecked((uint)0x9089),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_OBJECT_BOUNDING_BOX_NV")]
    PathObjectBoundingBoxnv = unchecked((uint)0x908A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CONVEX_HULL_NV")]
    ConvexHullnv = unchecked((uint)0x908B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_BOUNDING_BOX_NV")]
    BoundingBoxnv = unchecked((uint)0x908D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TRANSLATE_X_NV")]
    TranslateXnv = unchecked((uint)0x908E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TRANSLATE_Y_NV")]
    TranslateYnv = unchecked((uint)0x908F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TRANSLATE_2D_NV")]
    Translate2Dnv = unchecked((uint)0x9090),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TRANSLATE_3D_NV")]
    Translate3Dnv = unchecked((uint)0x9091),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_AFFINE_2D_NV")]
    Affine2Dnv = unchecked((uint)0x9092),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_AFFINE_3D_NV")]
    Affine3Dnv = unchecked((uint)0x9094),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TRANSPOSE_AFFINE_2D_NV")]
    TransposeAffine2Dnv = unchecked((uint)0x9096),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TRANSPOSE_AFFINE_3D_NV")]
    TransposeAffine3Dnv = unchecked((uint)0x9098),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_UTF8_NV")]
    Utf8Nv = unchecked((uint)0x909A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_UTF16_NV")]
    Utf16Nv = unchecked((uint)0x909B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_BOUNDING_BOX_OF_BOUNDING_BOXES_NV")]
    BoundingBoxOfBoundingBoxesnv = unchecked((uint)0x909C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_COMMAND_COUNT_NV")]
    PathCommandCountnv = unchecked((uint)0x909D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_COORD_COUNT_NV")]
    PathCoordCountnv = unchecked((uint)0x909E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_DASH_ARRAY_COUNT_NV")]
    PathDashArrayCountnv = unchecked((uint)0x909F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_COMPUTED_LENGTH_NV")]
    PathComputedLengthnv = unchecked((uint)0x90A0),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_FILL_BOUNDING_BOX_NV")]
    PathFillBoundingBoxnv = unchecked((uint)0x90A1),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_STROKE_BOUNDING_BOX_NV")]
    PathStrokeBoundingBoxnv = unchecked((uint)0x90A2),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SQUARE_NV")]
    Squarenv = unchecked((uint)0x90A3),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ROUND_NV")]
    Roundnv = unchecked((uint)0x90A4),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TRIANGULAR_NV")]
    Triangularnv = unchecked((uint)0x90A5),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_BEVEL_NV")]
    Bevelnv = unchecked((uint)0x90A6),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MITER_REVERT_NV")]
    MiterRevertnv = unchecked((uint)0x90A7),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MITER_TRUNCATE_NV")]
    MiterTruncatenv = unchecked((uint)0x90A8),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SKIP_MISSING_GLYPH_NV")]
    SkipMissingGlyphnv = unchecked((uint)0x90A9),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_USE_MISSING_GLYPH_NV")]
    UseMissingGlyphnv = unchecked((uint)0x90AA),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_ERROR_POSITION_NV")]
    PathErrorPositionnv = unchecked((uint)0x90AB),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ACCUM_ADJACENT_PAIRS_NV")]
    AccumAdjacentPairsnv = unchecked((uint)0x90AD),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ADJACENT_PAIRS_NV")]
    AdjacentPairsnv = unchecked((uint)0x90AE),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FIRST_TO_REST_NV")]
    FirstToRestnv = unchecked((uint)0x90AF),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_GEN_MODE_NV")]
    PathGenModenv = unchecked((uint)0x90B0),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_GEN_COEFF_NV")]
    PathGenCoeffnv = unchecked((uint)0x90B1),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_GEN_COMPONENTS_NV")]
    PathGenComponentsnv = unchecked((uint)0x90B3),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_STENCIL_FUNC_NV")]
    PathStencilFuncnv = unchecked((uint)0x90B7),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_STENCIL_REF_NV")]
    PathStencilRefnv = unchecked((uint)0x90B8),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_STENCIL_VALUE_MASK_NV")]
    PathStencilValueMasknv = unchecked((uint)0x90B9),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_STENCIL_DEPTH_OFFSET_FACTOR_NV")]
    PathStencilDepthOffsetFactornv = unchecked((uint)0x90BD),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_STENCIL_DEPTH_OFFSET_UNITS_NV")]
    PathStencilDepthOffsetUnitsnv = unchecked((uint)0x90BE),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_COVER_DEPTH_FUNC_NV")]
    PathCoverDepthFuncnv = unchecked((uint)0x90BF),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_DASH_OFFSET_RESET_NV")]
    PathDashOffsetResetnv = unchecked((uint)0x90B4),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MOVE_TO_RESETS_NV")]
    MoveToResetsnv = unchecked((uint)0x90B5),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MOVE_TO_CONTINUES_NV")]
    MoveToContinuesnv = unchecked((uint)0x90B6),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CLOSE_PATH_NV")]
    ClosePathnv = unchecked((uint)0x00),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MOVE_TO_NV")]
    MoveTonv = unchecked((uint)0x02),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_MOVE_TO_NV")]
    RelativeMoveTonv = unchecked((uint)0x03),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_LINE_TO_NV")]
    LineTonv = unchecked((uint)0x04),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_LINE_TO_NV")]
    RelativeLineTonv = unchecked((uint)0x05),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_HORIZONTAL_LINE_TO_NV")]
    HorizontalLineTonv = unchecked((uint)0x06),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_HORIZONTAL_LINE_TO_NV")]
    RelativeHorizontalLineTonv = unchecked((uint)0x07),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTICAL_LINE_TO_NV")]
    VerticalLineTonv = unchecked((uint)0x08),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_VERTICAL_LINE_TO_NV")]
    RelativeVerticalLineTonv = unchecked((uint)0x09),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_QUADRATIC_CURVE_TO_NV")]
    QuadraticCurveTonv = unchecked((uint)0x0A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_QUADRATIC_CURVE_TO_NV")]
    RelativeQuadraticCurveTonv = unchecked((uint)0x0B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CUBIC_CURVE_TO_NV")]
    CubicCurveTonv = unchecked((uint)0x0C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_CUBIC_CURVE_TO_NV")]
    RelativeCubicCurveTonv = unchecked((uint)0x0D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SMOOTH_QUADRATIC_CURVE_TO_NV")]
    SmoothQuadraticCurveTonv = unchecked((uint)0x0E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_SMOOTH_QUADRATIC_CURVE_TO_NV")]
    RelativeSmoothQuadraticCurveTonv = unchecked((uint)0x0F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SMOOTH_CUBIC_CURVE_TO_NV")]
    SmoothCubicCurveTonv = unchecked((uint)0x10),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_SMOOTH_CUBIC_CURVE_TO_NV")]
    RelativeSmoothCubicCurveTonv = unchecked((uint)0x11),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SMALL_CCW_ARC_TO_NV")]
    SmallCcwArcTonv = unchecked((uint)0x12),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_SMALL_CCW_ARC_TO_NV")]
    RelativeSmallCcwArcTonv = unchecked((uint)0x13),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SMALL_CW_ARC_TO_NV")]
    SmallCwArcTonv = unchecked((uint)0x14),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_SMALL_CW_ARC_TO_NV")]
    RelativeSmallCwArcTonv = unchecked((uint)0x15),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_LARGE_CCW_ARC_TO_NV")]
    LargeCcwArcTonv = unchecked((uint)0x16),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_LARGE_CCW_ARC_TO_NV")]
    RelativeLargeCcwArcTonv = unchecked((uint)0x17),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_LARGE_CW_ARC_TO_NV")]
    LargeCwArcTonv = unchecked((uint)0x18),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_LARGE_CW_ARC_TO_NV")]
    RelativeLargeCwArcTonv = unchecked((uint)0x19),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RESTART_PATH_NV")]
    RestartPathnv = unchecked((uint)0xF0),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DUP_FIRST_CUBIC_CURVE_TO_NV")]
    DupFirstCubicCurveTonv = unchecked((uint)0xF2),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DUP_LAST_CUBIC_CURVE_TO_NV")]
    DupLastCubicCurveTonv = unchecked((uint)0xF4),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RECT_NV")]
    Rectnv = unchecked((uint)0xF6),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CIRCULAR_CCW_ARC_TO_NV")]
    CircularCcwArcTonv = unchecked((uint)0xF8),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CIRCULAR_CW_ARC_TO_NV")]
    CircularCwArcTonv = unchecked((uint)0xFA),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CIRCULAR_TANGENT_ARC_TO_NV")]
    CircularTangentArcTonv = unchecked((uint)0xFC),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ARC_TO_NV")]
    ArcTonv = unchecked((uint)0xFE),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_ARC_TO_NV")]
    RelativeArcTonv = unchecked((uint)0xFF),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_BOLD_BIT_NV")]
    BoldBitnv = unchecked((uint)0x01),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ITALIC_BIT_NV")]
    ItalicBitnv = unchecked((uint)0x02),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_GLYPH_WIDTH_BIT_NV")]
    GlyphWidthBitnv = unchecked((uint)0x01),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_GLYPH_HEIGHT_BIT_NV")]
    GlyphHeightBitnv = unchecked((uint)0x02),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_GLYPH_HORIZONTAL_BEARING_X_BIT_NV")]
    GlyphHorizontalBearingXBitnv = unchecked((uint)0x04),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_GLYPH_HORIZONTAL_BEARING_Y_BIT_NV")]
    GlyphHorizontalBearingYBitnv = unchecked((uint)0x08),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_GLYPH_HORIZONTAL_BEARING_ADVANCE_BIT_NV")]
    GlyphHorizontalBearingAdvanceBitnv = unchecked((uint)0x10),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_GLYPH_VERTICAL_BEARING_X_BIT_NV")]
    GlyphVerticalBearingXBitnv = unchecked((uint)0x20),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_GLYPH_VERTICAL_BEARING_Y_BIT_NV")]
    GlyphVerticalBearingYBitnv = unchecked((uint)0x40),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_GLYPH_VERTICAL_BEARING_ADVANCE_BIT_NV")]
    GlyphVerticalBearingAdvanceBitnv = unchecked((uint)0x80),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_GLYPH_HAS_KERNING_BIT_NV")]
    GlyphHasKerningBitnv = unchecked((uint)0x100),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FONT_X_MIN_BOUNDS_BIT_NV")]
    FontXMinBoundsBitnv = unchecked((uint)0x00010000),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FONT_Y_MIN_BOUNDS_BIT_NV")]
    FontYMinBoundsBitnv = unchecked((uint)0x00020000),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FONT_X_MAX_BOUNDS_BIT_NV")]
    FontXMaxBoundsBitnv = unchecked((uint)0x00040000),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FONT_Y_MAX_BOUNDS_BIT_NV")]
    FontYMaxBoundsBitnv = unchecked((uint)0x00080000),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FONT_UNITS_PER_EM_BIT_NV")]
    FontUnitsPerEmBitnv = unchecked((uint)0x00100000),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FONT_ASCENDER_BIT_NV")]
    FontAscenderBitnv = unchecked((uint)0x00200000),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FONT_DESCENDER_BIT_NV")]
    FontDescenderBitnv = unchecked((uint)0x00400000),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FONT_HEIGHT_BIT_NV")]
    FontHeightBitnv = unchecked((uint)0x00800000),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FONT_MAX_ADVANCE_WIDTH_BIT_NV")]
    FontMaxAdvanceWidthBitnv = unchecked((uint)0x01000000),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FONT_MAX_ADVANCE_HEIGHT_BIT_NV")]
    FontMaxAdvanceHeightBitnv = unchecked((uint)0x02000000),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FONT_UNDERLINE_POSITION_BIT_NV")]
    FontUnderlinePositionBitnv = unchecked((uint)0x04000000),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FONT_UNDERLINE_THICKNESS_BIT_NV")]
    FontUnderlineThicknessBitnv = unchecked((uint)0x08000000),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FONT_HAS_KERNING_BIT_NV")]
    FontHasKerningBitnv = unchecked((uint)0x10000000),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ROUNDED_RECT_NV")]
    RoundedRectnv = unchecked((uint)0xE8),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_ROUNDED_RECT_NV")]
    RelativeRoundedRectnv = unchecked((uint)0xE9),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ROUNDED_RECT2_NV")]
    RoundedRect2Nv = unchecked((uint)0xEA),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_ROUNDED_RECT2_NV")]
    RelativeRoundedRect2Nv = unchecked((uint)0xEB),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ROUNDED_RECT4_NV")]
    RoundedRect4Nv = unchecked((uint)0xEC),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_ROUNDED_RECT4_NV")]
    RelativeRoundedRect4Nv = unchecked((uint)0xED),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ROUNDED_RECT8_NV")]
    RoundedRect8Nv = unchecked((uint)0xEE),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_ROUNDED_RECT8_NV")]
    RelativeRoundedRect8Nv = unchecked((uint)0xEF),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_RECT_NV")]
    RelativeRectnv = unchecked((uint)0xF7),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FONT_GLYPHS_AVAILABLE_NV")]
    FontGlyphsAvailablenv = unchecked((uint)0x9368),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FONT_TARGET_UNAVAILABLE_NV")]
    FontTargetUnavailablenv = unchecked((uint)0x9369),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FONT_UNAVAILABLE_NV")]
    FontUnavailablenv = unchecked((uint)0x936A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FONT_UNINTELLIGIBLE_NV")]
    FontUnintelligiblenv = unchecked((uint)0x936B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CONIC_CURVE_TO_NV")]
    ConicCurveTonv = unchecked((uint)0x1A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_CONIC_CURVE_TO_NV")]
    RelativeConicCurveTonv = unchecked((uint)0x1B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FONT_NUM_GLYPH_INDICES_BIT_NV")]
    FontNumGlyphIndicesBitnv = unchecked((uint)0x20000000),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_STANDARD_FONT_FORMAT_NV")]
    StandardFontFormatnv = unchecked((uint)0x936C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_2_BYTES_NV")]
    X2Bytesnv = unchecked((uint)0x1407),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_3_BYTES_NV")]
    X3Bytesnv = unchecked((uint)0x1408),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_4_BYTES_NV")]
    X4Bytesnv = unchecked((uint)0x1409),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_EYE_LINEAR_NV")]
    EyeLinearnv = unchecked((uint)0x2400),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_OBJECT_LINEAR_NV")]
    ObjectLinearnv = unchecked((uint)0x2401),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CONSTANT_NV")]
    Constantnv = unchecked((uint)0x8576),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_FOG_GEN_MODE_NV")]
    PathFogGenModenv = unchecked((uint)0x90AC),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PRIMARY_COLOR_NV")]
    PrimaryColornv = unchecked((uint)0x852C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SECONDARY_COLOR_NV")]
    SecondaryColornv = unchecked((uint)0x852D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_GEN_COLOR_FORMAT_NV")]
    PathGenColorFormatnv = unchecked((uint)0x90B2),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_PROJECTION_NV")]
    PathProjectionnv = unchecked((uint)0x1701),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_MODELVIEW_NV")]
    PathModelviewnv = unchecked((uint)0x1700),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_MODELVIEW_STACK_DEPTH_NV")]
    PathModelviewStackDepthnv = unchecked((uint)0x0BA3),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_MODELVIEW_MATRIX_NV")]
    PathModelviewMatrixnv = unchecked((uint)0x0BA6),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_MAX_MODELVIEW_STACK_DEPTH_NV")]
    PathMaxModelviewStackDepthnv = unchecked((uint)0x0D36),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_TRANSPOSE_MODELVIEW_MATRIX_NV")]
    PathTransposeModelviewMatrixnv = unchecked((uint)0x84E3),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_PROJECTION_STACK_DEPTH_NV")]
    PathProjectionStackDepthnv = unchecked((uint)0x0BA4),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_PROJECTION_MATRIX_NV")]
    PathProjectionMatrixnv = unchecked((uint)0x0BA7),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_MAX_PROJECTION_STACK_DEPTH_NV")]
    PathMaxProjectionStackDepthnv = unchecked((uint)0x0D38),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_TRANSPOSE_PROJECTION_MATRIX_NV")]
    PathTransposeProjectionMatrixnv = unchecked((uint)0x84E4),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FRAGMENT_INPUT_NV")]
    FragmentInputnv = unchecked((uint)0x936D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SHARED_EDGE_NV")]
    SharedEdgenv = unchecked((uint)0xC0),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_WRITE_PIXEL_DATA_RANGE_NV")]
    WritePixelDataRangenv = unchecked((uint)0x8878),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_READ_PIXEL_DATA_RANGE_NV")]
    ReadPixelDataRangenv = unchecked((uint)0x8879),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_WRITE_PIXEL_DATA_RANGE_LENGTH_NV")]
    WritePixelDataRangeLengthnv = unchecked((uint)0x887A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_READ_PIXEL_DATA_RANGE_LENGTH_NV")]
    ReadPixelDataRangeLengthnv = unchecked((uint)0x887B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_WRITE_PIXEL_DATA_RANGE_POINTER_NV")]
    WritePixelDataRangePointernv = unchecked((uint)0x887C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_READ_PIXEL_DATA_RANGE_POINTER_NV")]
    ReadPixelDataRangePointernv = unchecked((uint)0x887D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_POINT_SPRITE_NV")]
    PointSpritenv = unchecked((uint)0x8861),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COORD_REPLACE_NV")]
    CoordReplacenv = unchecked((uint)0x8862),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_POINT_SPRITE_R_MODE_NV")]
    PointSpriteRModenv = unchecked((uint)0x8863),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FRAME_NV")]
    Framenv = unchecked((uint)0x8E26),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FIELDS_NV")]
    Fieldsnv = unchecked((uint)0x8E27),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CURRENT_TIME_NV")]
    CurrentTimenv = unchecked((uint)0x8E28),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_NUM_FILL_STREAMS_NV")]
    NumFillStreamsnv = unchecked((uint)0x8E29),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PRESENT_TIME_NV")]
    PresentTimenv = unchecked((uint)0x8E2A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PRESENT_DURATION_NV")]
    PresentDurationnv = unchecked((uint)0x8E2B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PRIMITIVE_RESTART_NV")]
    PrimitiveRestartnv = unchecked((uint)0x8558),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PRIMITIVE_RESTART_INDEX_NV")]
    PrimitiveRestartIndexnv = unchecked((uint)0x8559),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SHADING_RATE_IMAGE_PER_PRIMITIVE_NV")]
    ShadingRateImagePerPrimitivenv = unchecked((uint)0x95B1),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SHADING_RATE_IMAGE_PALETTE_COUNT_NV")]
    ShadingRateImagePaletteCountnv = unchecked((uint)0x95B2),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_QUERY_RESOURCE_TYPE_VIDMEM_ALLOC_NV")]
    QueryResourceTypeVidmemAllocnv = unchecked((uint)0x9540),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_QUERY_RESOURCE_MEMTYPE_VIDMEM_NV")]
    QueryResourceMemtypeVidmemnv = unchecked((uint)0x9542),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_QUERY_RESOURCE_SYS_RESERVED_NV")]
    QueryResourceSysReservednv = unchecked((uint)0x9544),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_QUERY_RESOURCE_TEXTURE_NV")]
    QueryResourceTexturenv = unchecked((uint)0x9545),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_QUERY_RESOURCE_RENDERBUFFER_NV")]
    QueryResourceRenderbuffernv = unchecked((uint)0x9546),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_QUERY_RESOURCE_BUFFEROBJECT_NV")]
    QueryResourceBufferobjectnv = unchecked((uint)0x9547),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_REGISTER_COMBINERS_NV")]
    RegisterCombinersnv = unchecked((uint)0x8522),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VARIABLE_A_NV")]
    VariableAnv = unchecked((uint)0x8523),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VARIABLE_B_NV")]
    VariableBnv = unchecked((uint)0x8524),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VARIABLE_C_NV")]
    VariableCnv = unchecked((uint)0x8525),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VARIABLE_D_NV")]
    VariableDnv = unchecked((uint)0x8526),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VARIABLE_E_NV")]
    VariableEnv = unchecked((uint)0x8527),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VARIABLE_F_NV")]
    VariableFnv = unchecked((uint)0x8528),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VARIABLE_G_NV")]
    VariableGnv = unchecked((uint)0x8529),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CONSTANT_COLOR0_NV")]
    ConstantColor0Nv = unchecked((uint)0x852A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CONSTANT_COLOR1_NV")]
    ConstantColor1Nv = unchecked((uint)0x852B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SPARE0_NV")]
    Spare0Nv = unchecked((uint)0x852E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SPARE1_NV")]
    Spare1Nv = unchecked((uint)0x852F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DISCARD_NV")]
    Discardnv = unchecked((uint)0x8530),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_E_TIMES_F_NV")]
    ETimesFnv = unchecked((uint)0x8531),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SPARE0_PLUS_SECONDARY_COLOR_NV")]
    Spare0PlusSecondaryColornv = unchecked((uint)0x8532),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_UNSIGNED_IDENTITY_NV")]
    UnsignedIdentitynv = unchecked((uint)0x8536),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_UNSIGNED_INVERT_NV")]
    UnsignedInvertnv = unchecked((uint)0x8537),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_EXPAND_NORMAL_NV")]
    ExpandNormalnv = unchecked((uint)0x8538),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_EXPAND_NEGATE_NV")]
    ExpandNegatenv = unchecked((uint)0x8539),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_HALF_BIAS_NORMAL_NV")]
    HalfBiasNormalnv = unchecked((uint)0x853A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_HALF_BIAS_NEGATE_NV")]
    HalfBiasNegatenv = unchecked((uint)0x853B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SIGNED_IDENTITY_NV")]
    SignedIdentitynv = unchecked((uint)0x853C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SIGNED_NEGATE_NV")]
    SignedNegatenv = unchecked((uint)0x853D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SCALE_BY_TWO_NV")]
    ScaleByTwonv = unchecked((uint)0x853E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SCALE_BY_FOUR_NV")]
    ScaleByFournv = unchecked((uint)0x853F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SCALE_BY_ONE_HALF_NV")]
    ScaleByOneHalfnv = unchecked((uint)0x8540),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_BIAS_BY_NEGATIVE_ONE_HALF_NV")]
    BiasByNegativeOneHalfnv = unchecked((uint)0x8541),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMBINER_INPUT_NV")]
    CombinerInputnv = unchecked((uint)0x8542),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMBINER_MAPPING_NV")]
    CombinerMappingnv = unchecked((uint)0x8543),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMBINER_COMPONENT_USAGE_NV")]
    CombinerComponentUsagenv = unchecked((uint)0x8544),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMBINER_AB_DOT_PRODUCT_NV")]
    CombinerAbDotProductnv = unchecked((uint)0x8545),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMBINER_CD_DOT_PRODUCT_NV")]
    CombinerCdDotProductnv = unchecked((uint)0x8546),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMBINER_MUX_SUM_NV")]
    CombinerMuxSumnv = unchecked((uint)0x8547),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMBINER_SCALE_NV")]
    CombinerScalenv = unchecked((uint)0x8548),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMBINER_BIAS_NV")]
    CombinerBiasnv = unchecked((uint)0x8549),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMBINER_AB_OUTPUT_NV")]
    CombinerAbOutputnv = unchecked((uint)0x854A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMBINER_CD_OUTPUT_NV")]
    CombinerCdOutputnv = unchecked((uint)0x854B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMBINER_SUM_OUTPUT_NV")]
    CombinerSumOutputnv = unchecked((uint)0x854C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_GENERAL_COMBINERS_NV")]
    MaxGeneralCombinersnv = unchecked((uint)0x854D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_NUM_GENERAL_COMBINERS_NV")]
    NumGeneralCombinersnv = unchecked((uint)0x854E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_SUM_CLAMP_NV")]
    ColorSumClampnv = unchecked((uint)0x854F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMBINER0_NV")]
    Combiner0Nv = unchecked((uint)0x8550),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMBINER1_NV")]
    Combiner1Nv = unchecked((uint)0x8551),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMBINER2_NV")]
    Combiner2Nv = unchecked((uint)0x8552),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMBINER3_NV")]
    Combiner3Nv = unchecked((uint)0x8553),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMBINER4_NV")]
    Combiner4Nv = unchecked((uint)0x8554),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMBINER5_NV")]
    Combiner5Nv = unchecked((uint)0x8555),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMBINER6_NV")]
    Combiner6Nv = unchecked((uint)0x8556),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMBINER7_NV")]
    Combiner7Nv = unchecked((uint)0x8557),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PER_STAGE_CONSTANTS_NV")]
    PerStageConstantsnv = unchecked((uint)0x8535),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_REPRESENTATIVE_FRAGMENT_TEST_NV")]
    RepresentativeFragmentTestnv = unchecked((uint)0x937F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PURGED_CONTEXT_RESET_NV")]
    PurgedContextResetnv = unchecked((uint)0x92BB),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SAMPLE_LOCATION_SUBPIXEL_BITS_NV")]
    SampleLocationSubpixelBitsnv = unchecked((uint)0x933D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SAMPLE_LOCATION_PIXEL_GRID_WIDTH_NV")]
    SampleLocationPixelGridWidthnv = unchecked((uint)0x933E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_NV")]
    SampleLocationPixelGridHeightnv = unchecked((uint)0x933F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_NV")]
    ProgrammableSampleLocationTableSizenv = unchecked((uint)0x9340),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SAMPLE_LOCATION_NV")]
    SampleLocationnv = unchecked((uint)0x8E50),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PROGRAMMABLE_SAMPLE_LOCATION_NV")]
    ProgrammableSampleLocationnv = unchecked((uint)0x9341),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_NV")]
    FramebufferProgrammableSampleLocationsnv = unchecked((uint)0x9342),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_NV")]
    FramebufferSampleLocationPixelGridnv = unchecked((uint)0x9343),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SCISSOR_TEST_EXCLUSIVE_NV")]
    ScissorTestExclusivenv = unchecked((uint)0x9555),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SCISSOR_BOX_EXCLUSIVE_NV")]
    ScissorBoxExclusivenv = unchecked((uint)0x9556),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_BUFFER_GPU_ADDRESS_NV")]
    BufferGpuAddressnv = unchecked((uint)0x8F1D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_GPU_ADDRESS_NV")]
    GpuAddressnv = unchecked((uint)0x8F34),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_SHADER_BUFFER_ADDRESS_NV")]
    MaxShaderBufferAddressnv = unchecked((uint)0x8F35),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SHADER_GLOBAL_ACCESS_BARRIER_BIT_NV")]
    ShaderGlobalAccessBarrierBitnv = unchecked((uint)0x00000010),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SUBGROUP_FEATURE_PARTITIONED_BIT_NV")]
    SubgroupFeaturePartitionedBitnv = unchecked((uint)0x00000100),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_WARP_SIZE_NV")]
    WarpSizenv = unchecked((uint)0x9339),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_WARPS_PER_SM_NV")]
    WarpsPerSmnv = unchecked((uint)0x933A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SM_COUNT_NV")]
    SmCountnv = unchecked((uint)0x933B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SHADING_RATE_IMAGE_NV")]
    ShadingRateImagenv = unchecked((uint)0x9563),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SHADING_RATE_NO_INVOCATIONS_NV")]
    ShadingRateNoInvocationsnv = unchecked((uint)0x9564),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SHADING_RATE_1_INVOCATION_PER_PIXEL_NV")]
    ShadingRate1InvocationPerPixelnv = unchecked((uint)0x9565),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SHADING_RATE_1_INVOCATION_PER_1X2_PIXELS_NV")]
    ShadingRate1InvocationPer1X2Pixelsnv = unchecked((uint)0x9566),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SHADING_RATE_1_INVOCATION_PER_2X1_PIXELS_NV")]
    ShadingRate1InvocationPer2X1Pixelsnv = unchecked((uint)0x9567),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SHADING_RATE_1_INVOCATION_PER_2X2_PIXELS_NV")]
    ShadingRate1InvocationPer2X2Pixelsnv = unchecked((uint)0x9568),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SHADING_RATE_1_INVOCATION_PER_2X4_PIXELS_NV")]
    ShadingRate1InvocationPer2X4Pixelsnv = unchecked((uint)0x9569),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SHADING_RATE_1_INVOCATION_PER_4X2_PIXELS_NV")]
    ShadingRate1InvocationPer4X2Pixelsnv = unchecked((uint)0x956A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SHADING_RATE_1_INVOCATION_PER_4X4_PIXELS_NV")]
    ShadingRate1InvocationPer4X4Pixelsnv = unchecked((uint)0x956B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SHADING_RATE_2_INVOCATIONS_PER_PIXEL_NV")]
    ShadingRate2InvocationsPerPixelnv = unchecked((uint)0x956C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SHADING_RATE_4_INVOCATIONS_PER_PIXEL_NV")]
    ShadingRate4InvocationsPerPixelnv = unchecked((uint)0x956D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SHADING_RATE_8_INVOCATIONS_PER_PIXEL_NV")]
    ShadingRate8InvocationsPerPixelnv = unchecked((uint)0x956E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SHADING_RATE_16_INVOCATIONS_PER_PIXEL_NV")]
    ShadingRate16InvocationsPerPixelnv = unchecked((uint)0x956F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SHADING_RATE_IMAGE_BINDING_NV")]
    ShadingRateImageBindingnv = unchecked((uint)0x955B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SHADING_RATE_IMAGE_TEXEL_WIDTH_NV")]
    ShadingRateImageTexelWidthnv = unchecked((uint)0x955C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SHADING_RATE_IMAGE_TEXEL_HEIGHT_NV")]
    ShadingRateImageTexelHeightnv = unchecked((uint)0x955D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SHADING_RATE_IMAGE_PALETTE_SIZE_NV")]
    ShadingRateImagePaletteSizenv = unchecked((uint)0x955E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_COARSE_FRAGMENT_SAMPLES_NV")]
    MaxCoarseFragmentSamplesnv = unchecked((uint)0x955F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SHADING_RATE_SAMPLE_ORDER_DEFAULT_NV")]
    ShadingRateSampleOrderDefaultnv = unchecked((uint)0x95AE),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SHADING_RATE_SAMPLE_ORDER_PIXEL_MAJOR_NV")]
    ShadingRateSampleOrderPixelMajornv = unchecked((uint)0x95AF),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SHADING_RATE_SAMPLE_ORDER_SAMPLE_MAJOR_NV")]
    ShadingRateSampleOrderSampleMajornv = unchecked((uint)0x95B0),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_PROGRAM_PATCH_ATTRIBS_NV")]
    MaxProgramPatchAttribsnv = unchecked((uint)0x86D8),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TESS_CONTROL_PROGRAM_NV")]
    TessControlProgramnv = unchecked((uint)0x891E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TESS_EVALUATION_PROGRAM_NV")]
    TessEvaluationProgramnv = unchecked((uint)0x891F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TESS_CONTROL_PROGRAM_PARAMETER_BUFFER_NV")]
    TessControlProgramParameterBuffernv = unchecked((uint)0x8C74),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TESS_EVALUATION_PROGRAM_PARAMETER_BUFFER_NV")]
    TessEvaluationProgramParameterBuffernv = unchecked((uint)0x8C75),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_EMBOSS_LIGHT_NV")]
    EmbossLightnv = unchecked((uint)0x855D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_EMBOSS_CONSTANT_NV")]
    EmbossConstantnv = unchecked((uint)0x855E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_EMBOSS_MAP_NV")]
    EmbossMapnv = unchecked((uint)0x855F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_NORMAL_MAP_NV")]
    NormalMapnv = unchecked((uint)0x8511),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_REFLECTION_MAP_NV")]
    ReflectionMapnv = unchecked((uint)0x8512),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMBINE4_NV")]
    Combine4Nv = unchecked((uint)0x8503),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SOURCE3_RGB_NV")]
    Source3Rgbnv = unchecked((uint)0x8583),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SOURCE3_ALPHA_NV")]
    Source3Alphanv = unchecked((uint)0x858B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_OPERAND3_RGB_NV")]
    Operand3Rgbnv = unchecked((uint)0x8593),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_OPERAND3_ALPHA_NV")]
    Operand3Alphanv = unchecked((uint)0x859B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TEXTURE_UNSIGNED_REMAP_MODE_NV")]
    TextureUnsignedRemapModenv = unchecked((uint)0x888F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TEXTURE_COVERAGE_SAMPLES_NV")]
    TextureCoverageSamplesnv = unchecked((uint)0x9045),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TEXTURE_COLOR_SAMPLES_NV")]
    TextureColorSamplesnv = unchecked((uint)0x9046),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TEXTURE_RECTANGLE_NV")]
    TextureRectAnglenv = unchecked((uint)0x84F5),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TEXTURE_BINDING_RECTANGLE_NV")]
    TextureBindingRectAnglenv = unchecked((uint)0x84F6),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PROXY_TEXTURE_RECTANGLE_NV")]
    ProxyTextureRectAnglenv = unchecked((uint)0x84F7),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_RECTANGLE_TEXTURE_SIZE_NV")]
    MaxRectangleTextureSizenv = unchecked((uint)0x84F8),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_OFFSET_TEXTURE_RECTANGLE_NV")]
    OffsetTextureRectAnglenv = unchecked((uint)0x864C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_OFFSET_TEXTURE_RECTANGLE_SCALE_NV")]
    OffsetTextureRectangleScalenv = unchecked((uint)0x864D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DOT_PRODUCT_TEXTURE_RECTANGLE_NV")]
    DotProductTextureRectAnglenv = unchecked((uint)0x864E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RGBA_UNSIGNED_DOT_PRODUCT_MAPPING_NV")]
    RgbaUnsignedDotProductMappingnv = unchecked((uint)0x86D9),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_UNSIGNED_INT_S8_S8_8_8_NV")]
    UnsignedIntS8S8X8X8Nv = unchecked((uint)0x86DA),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_UNSIGNED_INT_8_8_S8_S8_REV_NV")]
    UnsignedInt8X8S8S8Revnv = unchecked((uint)0x86DB),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DSDT_MAG_INTENSITY_NV")]
    DsdtMagIntensitynv = unchecked((uint)0x86DC),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SHADER_CONSISTENT_NV")]
    ShaderConsistentnv = unchecked((uint)0x86DD),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TEXTURE_SHADER_NV")]
    TextureShadernv = unchecked((uint)0x86DE),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SHADER_OPERATION_NV")]
    ShaderOperationnv = unchecked((uint)0x86DF),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CULL_MODES_NV")]
    CullModesnv = unchecked((uint)0x86E0),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_OFFSET_TEXTURE_MATRIX_NV")]
    OffsetTextureMatrixnv = unchecked((uint)0x86E1),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_OFFSET_TEXTURE_SCALE_NV")]
    OffsetTextureScalenv = unchecked((uint)0x86E2),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_OFFSET_TEXTURE_BIAS_NV")]
    OffsetTextureBiasnv = unchecked((uint)0x86E3),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_OFFSET_TEXTURE_2D_MATRIX_NV")]
    OffsetTexture2DMatrixnv = unchecked((uint)0x86E1),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_OFFSET_TEXTURE_2D_SCALE_NV")]
    OffsetTexture2DScalenv = unchecked((uint)0x86E2),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_OFFSET_TEXTURE_2D_BIAS_NV")]
    OffsetTexture2DBiasnv = unchecked((uint)0x86E3),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PREVIOUS_TEXTURE_INPUT_NV")]
    PreviousTextureInputnv = unchecked((uint)0x86E4),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CONST_EYE_NV")]
    ConstEyenv = unchecked((uint)0x86E5),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PASS_THROUGH_NV")]
    PassThroughnv = unchecked((uint)0x86E6),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CULL_FRAGMENT_NV")]
    CullFragmentnv = unchecked((uint)0x86E7),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_OFFSET_TEXTURE_2D_NV")]
    OffsetTexture2Dnv = unchecked((uint)0x86E8),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DEPENDENT_AR_TEXTURE_2D_NV")]
    DependentArTexture2Dnv = unchecked((uint)0x86E9),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DEPENDENT_GB_TEXTURE_2D_NV")]
    DependentGbTexture2Dnv = unchecked((uint)0x86EA),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DOT_PRODUCT_NV")]
    DotProductnv = unchecked((uint)0x86EC),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DOT_PRODUCT_DEPTH_REPLACE_NV")]
    DotProductDepthReplacenv = unchecked((uint)0x86ED),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DOT_PRODUCT_TEXTURE_2D_NV")]
    DotProductTexture2Dnv = unchecked((uint)0x86EE),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DOT_PRODUCT_TEXTURE_CUBE_MAP_NV")]
    DotProductTextureCubeMapnv = unchecked((uint)0x86F0),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DOT_PRODUCT_DIFFUSE_CUBE_MAP_NV")]
    DotProductDiffuseCubeMapnv = unchecked((uint)0x86F1),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DOT_PRODUCT_REFLECT_CUBE_MAP_NV")]
    DotProductReflectCubeMapnv = unchecked((uint)0x86F2),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DOT_PRODUCT_CONST_EYE_REFLECT_CUBE_MAP_NV")]
    DotProductConstEyeReflectCubeMapnv = unchecked((uint)0x86F3),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_HILO_NV")]
    Hilonv = unchecked((uint)0x86F4),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DSDT_NV")]
    Dsdtnv = unchecked((uint)0x86F5),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DSDT_MAG_NV")]
    DsdtMagnv = unchecked((uint)0x86F6),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DSDT_MAG_VIB_NV")]
    DsdtMagVibnv = unchecked((uint)0x86F7),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_HILO16_NV")]
    Hilo16Nv = unchecked((uint)0x86F8),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SIGNED_HILO_NV")]
    SignedHilonv = unchecked((uint)0x86F9),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SIGNED_HILO16_NV")]
    SignedHilo16Nv = unchecked((uint)0x86FA),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SIGNED_RGBA_NV")]
    SignedRgbanv = unchecked((uint)0x86FB),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SIGNED_RGBA8_NV")]
    SignedRgba8Nv = unchecked((uint)0x86FC),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SIGNED_RGB_NV")]
    SignedRgbnv = unchecked((uint)0x86FE),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SIGNED_RGB8_NV")]
    SignedRgb8Nv = unchecked((uint)0x86FF),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SIGNED_LUMINANCE_NV")]
    SignedLuminancenv = unchecked((uint)0x8701),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SIGNED_LUMINANCE8_NV")]
    SignedLuminance8Nv = unchecked((uint)0x8702),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SIGNED_LUMINANCE_ALPHA_NV")]
    SignedLuminanceAlphanv = unchecked((uint)0x8703),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SIGNED_LUMINANCE8_ALPHA8_NV")]
    SignedLuminance8Alpha8Nv = unchecked((uint)0x8704),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SIGNED_ALPHA_NV")]
    SignedAlphanv = unchecked((uint)0x8705),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SIGNED_ALPHA8_NV")]
    SignedAlpha8Nv = unchecked((uint)0x8706),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SIGNED_INTENSITY_NV")]
    SignedIntensitynv = unchecked((uint)0x8707),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SIGNED_INTENSITY8_NV")]
    SignedIntensity8Nv = unchecked((uint)0x8708),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DSDT8_NV")]
    Dsdt8Nv = unchecked((uint)0x8709),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DSDT8_MAG8_NV")]
    Dsdt8Mag8Nv = unchecked((uint)0x870A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DSDT8_MAG8_INTENSITY8_NV")]
    Dsdt8Mag8Intensity8Nv = unchecked((uint)0x870B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SIGNED_RGB_UNSIGNED_ALPHA_NV")]
    SignedRgbUnsignedAlphanv = unchecked((uint)0x870C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SIGNED_RGB8_UNSIGNED_ALPHA8_NV")]
    SignedRgb8UnsignedAlpha8Nv = unchecked((uint)0x870D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_HI_SCALE_NV")]
    HiScalenv = unchecked((uint)0x870E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_LO_SCALE_NV")]
    LoScalenv = unchecked((uint)0x870F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DS_SCALE_NV")]
    DsScalenv = unchecked((uint)0x8710),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DT_SCALE_NV")]
    DtScalenv = unchecked((uint)0x8711),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAGNITUDE_SCALE_NV")]
    MagnitudeScalenv = unchecked((uint)0x8712),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIBRANCE_SCALE_NV")]
    VibranceScalenv = unchecked((uint)0x8713),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_HI_BIAS_NV")]
    HiBiasnv = unchecked((uint)0x8714),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_LO_BIAS_NV")]
    LoBiasnv = unchecked((uint)0x8715),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DS_BIAS_NV")]
    DsBiasnv = unchecked((uint)0x8716),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DT_BIAS_NV")]
    DtBiasnv = unchecked((uint)0x8717),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAGNITUDE_BIAS_NV")]
    MagnitudeBiasnv = unchecked((uint)0x8718),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIBRANCE_BIAS_NV")]
    VibranceBiasnv = unchecked((uint)0x8719),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TEXTURE_BORDER_VALUES_NV")]
    TextureBorderValuesnv = unchecked((uint)0x871A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TEXTURE_HI_SIZE_NV")]
    TextureHiSizenv = unchecked((uint)0x871B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TEXTURE_LO_SIZE_NV")]
    TextureLoSizenv = unchecked((uint)0x871C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TEXTURE_DS_SIZE_NV")]
    TextureDsSizenv = unchecked((uint)0x871D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TEXTURE_DT_SIZE_NV")]
    TextureDtSizenv = unchecked((uint)0x871E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TEXTURE_MAG_SIZE_NV")]
    TextureMagSizenv = unchecked((uint)0x871F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DOT_PRODUCT_TEXTURE_3D_NV")]
    DotProductTexture3Dnv = unchecked((uint)0x86EF),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_OFFSET_PROJECTIVE_TEXTURE_2D_NV")]
    OffsetProjectiveTexture2Dnv = unchecked((uint)0x8850),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_OFFSET_PROJECTIVE_TEXTURE_2D_SCALE_NV")]
    OffsetProjectiveTexture2DScalenv = unchecked((uint)0x8851),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_OFFSET_PROJECTIVE_TEXTURE_RECTANGLE_NV")]
    OffsetProjectiveTextureRectAnglenv = unchecked((uint)0x8852),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_OFFSET_PROJECTIVE_TEXTURE_RECTANGLE_SCALE_NV")]
    OffsetProjectiveTextureRectangleScalenv = unchecked((uint)0x8853),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_OFFSET_HILO_TEXTURE_2D_NV")]
    OffsetHiloTexture2Dnv = unchecked((uint)0x8854),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_OFFSET_HILO_TEXTURE_RECTANGLE_NV")]
    OffsetHiloTextureRectAnglenv = unchecked((uint)0x8855),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_OFFSET_HILO_PROJECTIVE_TEXTURE_2D_NV")]
    OffsetHiloProjectiveTexture2Dnv = unchecked((uint)0x8856),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_OFFSET_HILO_PROJECTIVE_TEXTURE_RECTANGLE_NV")]
    OffsetHiloProjectiveTextureRectAnglenv = unchecked((uint)0x8857),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DEPENDENT_HILO_TEXTURE_2D_NV")]
    DependentHiloTexture2Dnv = unchecked((uint)0x8858),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DEPENDENT_RGB_TEXTURE_3D_NV")]
    DependentRgbTexture3Dnv = unchecked((uint)0x8859),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DEPENDENT_RGB_TEXTURE_CUBE_MAP_NV")]
    DependentRgbTextureCubeMapnv = unchecked((uint)0x885A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DOT_PRODUCT_PASS_THROUGH_NV")]
    DotProductPassThroughnv = unchecked((uint)0x885B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DOT_PRODUCT_TEXTURE_1D_NV")]
    DotProductTexture1Dnv = unchecked((uint)0x885C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DOT_PRODUCT_AFFINE_DEPTH_REPLACE_NV")]
    DotProductAffineDepthReplacenv = unchecked((uint)0x885D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_HILO8_NV")]
    Hilo8Nv = unchecked((uint)0x885E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SIGNED_HILO8_NV")]
    SignedHilo8Nv = unchecked((uint)0x885F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FORCE_BLUE_TO_ONE_NV")]
    ForceBlueToOnenv = unchecked((uint)0x8860),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TIMELINE_SEMAPHORE_VALUE_NV")]
    TimelineSemaphoreValuenv = unchecked((uint)0x9595),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SEMAPHORE_TYPE_NV")]
    SemaphoreTypenv = unchecked((uint)0x95B3),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SEMAPHORE_TYPE_BINARY_NV")]
    SemaphoreTypeBinarynv = unchecked((uint)0x95B4),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SEMAPHORE_TYPE_TIMELINE_NV")]
    SemaphoreTypeTimelinenv = unchecked((uint)0x95B5),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_TIMELINE_SEMAPHORE_VALUE_DIFFERENCE_NV")]
    MaxTimelineSemaphoreValueDifferencenv = unchecked((uint)0x95B6),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_BACK_PRIMARY_COLOR_NV")]
    BackPrimaryColornv = unchecked((uint)0x8C77),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_BACK_SECONDARY_COLOR_NV")]
    BackSecondaryColornv = unchecked((uint)0x8C78),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TEXTURE_COORD_NV")]
    TextureCoordnv = unchecked((uint)0x8C79),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CLIP_DISTANCE_NV")]
    ClipDistancenv = unchecked((uint)0x8C7A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_ID_NV")]
    VertexIdnv = unchecked((uint)0x8C7B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PRIMITIVE_ID_NV")]
    PrimitiveIdnv = unchecked((uint)0x8C7C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_GENERIC_ATTRIB_NV")]
    GenericAttribnv = unchecked((uint)0x8C7D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TRANSFORM_FEEDBACK_ATTRIBS_NV")]
    TransformFeedbackAttribsnv = unchecked((uint)0x8C7E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_MODE_NV")]
    TransformFeedbackBufferModenv = unchecked((uint)0x8C7F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS_NV")]
    MaxTransformFeedbackSeparateComponentsnv = unchecked((uint)0x8C80),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ACTIVE_VARYINGS_NV")]
    ActiveVaryingsnv = unchecked((uint)0x8C81),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ACTIVE_VARYING_MAX_LENGTH_NV")]
    ActiveVaryingMaxLengthnv = unchecked((uint)0x8C82),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TRANSFORM_FEEDBACK_VARYINGS_NV")]
    TransformFeedbackVaryingsnv = unchecked((uint)0x8C83),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_START_NV")]
    TransformFeedbackBufferStartnv = unchecked((uint)0x8C84),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_SIZE_NV")]
    TransformFeedbackBufferSizenv = unchecked((uint)0x8C85),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TRANSFORM_FEEDBACK_RECORD_NV")]
    TransformFeedbackRecordnv = unchecked((uint)0x8C86),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PRIMITIVES_GENERATED_NV")]
    PrimitivesGeneratednv = unchecked((uint)0x8C87),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN_NV")]
    TransformFeedbackPrimitivesWrittennv = unchecked((uint)0x8C88),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RASTERIZER_DISCARD_NV")]
    RasterizerDiscardnv = unchecked((uint)0x8C89),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS_NV")]
    MaxTransformFeedbackInterleavedComponentsnv = unchecked((uint)0x8C8A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS_NV")]
    MaxTransformFeedbackSeparateAttribsnv = unchecked((uint)0x8C8B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_INTERLEAVED_ATTRIBS_NV")]
    InterleavedAttribsnv = unchecked((uint)0x8C8C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SEPARATE_ATTRIBS_NV")]
    SeparateAttribsnv = unchecked((uint)0x8C8D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_NV")]
    TransformFeedbackBuffernv = unchecked((uint)0x8C8E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_BINDING_NV")]
    TransformFeedbackBufferBindingnv = unchecked((uint)0x8C8F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_LAYER_NV")]
    Layernv = unchecked((uint)0x8DAA),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_NEXT_BUFFER_NV")]
    NextBuffernv = unchecked((uint)-2),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SKIP_COMPONENTS4_NV")]
    SkipComponents4Nv = unchecked((uint)-3),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SKIP_COMPONENTS3_NV")]
    SkipComponentS3Nv = unchecked((uint)-4),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SKIP_COMPONENTS2_NV")]
    SkipComponents2Nv = unchecked((uint)-5),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SKIP_COMPONENTS1_NV")]
    SkipComponents1Nv = unchecked((uint)-6),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TRANSFORM_FEEDBACK_NV")]
    TransformFeedbacknv = unchecked((uint)0x8E22),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED_NV")]
    TransformFeedbackBufferPausednv = unchecked((uint)0x8E23),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE_NV")]
    TransformFeedbackBufferActivenv = unchecked((uint)0x8E24),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TRANSFORM_FEEDBACK_BINDING_NV")]
    TransformFeedbackBindingnv = unchecked((uint)0x8E25),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_UNIFORM_BUFFER_UNIFIED_NV")]
    UniformBufferUnifiednv = unchecked((uint)0x936E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_UNIFORM_BUFFER_ADDRESS_NV")]
    UniformBufferAddressnv = unchecked((uint)0x936F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_UNIFORM_BUFFER_LENGTH_NV")]
    UniformBufferLengthnv = unchecked((uint)0x9370),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SURFACE_STATE_NV")]
    SurfaceStatenv = unchecked((uint)0x86EB),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SURFACE_REGISTERED_NV")]
    SurfaceRegisterednv = unchecked((uint)0x86FD),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SURFACE_MAPPED_NV")]
    SurfaceMappednv = unchecked((uint)0x8700),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_WRITE_DISCARD_NV")]
    WriteDiscardnv = unchecked((uint)0x88BE),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_ARRAY_RANGE_NV")]
    VertexArrayRangenv = unchecked((uint)0x851D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_ARRAY_RANGE_LENGTH_NV")]
    VertexArrayRangeLengthnv = unchecked((uint)0x851E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_ARRAY_RANGE_VALID_NV")]
    VertexArrayRangeValidnv = unchecked((uint)0x851F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_VERTEX_ARRAY_RANGE_ELEMENT_NV")]
    MaxVertexArrayRangeElementnv = unchecked((uint)0x8520),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_ARRAY_RANGE_POINTER_NV")]
    VertexArrayRangePointernv = unchecked((uint)0x8521),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_ARRAY_RANGE_WITHOUT_FLUSH_NV")]
    VertexArrayRangeWithoutFlushnv = unchecked((uint)0x8533),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_ATTRIB_ARRAY_UNIFIED_NV")]
    VertexAttribArrayUnifiednv = unchecked((uint)0x8F1E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ELEMENT_ARRAY_UNIFIED_NV")]
    ElementArrayUnifiednv = unchecked((uint)0x8F1F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_ATTRIB_ARRAY_ADDRESS_NV")]
    VertexAttribArrayAddressnv = unchecked((uint)0x8F20),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_ARRAY_ADDRESS_NV")]
    VertexArrayAddressnv = unchecked((uint)0x8F21),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_NORMAL_ARRAY_ADDRESS_NV")]
    NormalArrayAddressnv = unchecked((uint)0x8F22),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ARRAY_ADDRESS_NV")]
    ColorArrayAddressnv = unchecked((uint)0x8F23),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_INDEX_ARRAY_ADDRESS_NV")]
    IndexArrayAddressnv = unchecked((uint)0x8F24),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TEXTURE_COORD_ARRAY_ADDRESS_NV")]
    TextureCoordArrayAddressnv = unchecked((uint)0x8F25),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_EDGE_FLAG_ARRAY_ADDRESS_NV")]
    EdgeFlagArrayAddressnv = unchecked((uint)0x8F26),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SECONDARY_COLOR_ARRAY_ADDRESS_NV")]
    SecondaryColorArrayAddressnv = unchecked((uint)0x8F27),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FOG_COORD_ARRAY_ADDRESS_NV")]
    FogCoordArrayAddressnv = unchecked((uint)0x8F28),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ELEMENT_ARRAY_ADDRESS_NV")]
    ElementArrayAddressnv = unchecked((uint)0x8F29),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_ATTRIB_ARRAY_LENGTH_NV")]
    VertexAttribArrayLengthnv = unchecked((uint)0x8F2A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_ARRAY_LENGTH_NV")]
    VertexArrayLengthnv = unchecked((uint)0x8F2B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_NORMAL_ARRAY_LENGTH_NV")]
    NormalArrayLengthnv = unchecked((uint)0x8F2C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ARRAY_LENGTH_NV")]
    ColorArrayLengthnv = unchecked((uint)0x8F2D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_INDEX_ARRAY_LENGTH_NV")]
    IndexArrayLengthnv = unchecked((uint)0x8F2E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TEXTURE_COORD_ARRAY_LENGTH_NV")]
    TextureCoordArrayLengthnv = unchecked((uint)0x8F2F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_EDGE_FLAG_ARRAY_LENGTH_NV")]
    EdgeFlagArrayLengthnv = unchecked((uint)0x8F30),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SECONDARY_COLOR_ARRAY_LENGTH_NV")]
    SecondaryColorArrayLengthnv = unchecked((uint)0x8F31),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FOG_COORD_ARRAY_LENGTH_NV")]
    FogCoordArrayLengthnv = unchecked((uint)0x8F32),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ELEMENT_ARRAY_LENGTH_NV")]
    ElementArrayLengthnv = unchecked((uint)0x8F33),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_INDIRECT_UNIFIED_NV")]
    DrawIndirectUnifiednv = unchecked((uint)0x8F40),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_INDIRECT_ADDRESS_NV")]
    DrawIndirectAddressnv = unchecked((uint)0x8F41),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_INDIRECT_LENGTH_NV")]
    DrawIndirectLengthnv = unchecked((uint)0x8F42),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_PROGRAM_NV")]
    VertexProgramnv = unchecked((uint)0x8620),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_STATE_PROGRAM_NV")]
    VertexStateProgramnv = unchecked((uint)0x8621),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ATTRIB_ARRAY_SIZE_NV")]
    AttribArraySizenv = unchecked((uint)0x8623),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ATTRIB_ARRAY_STRIDE_NV")]
    AttribArrayStridenv = unchecked((uint)0x8624),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ATTRIB_ARRAY_TYPE_NV")]
    AttribArrayTypenv = unchecked((uint)0x8625),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CURRENT_ATTRIB_NV")]
    CurrentAttribnv = unchecked((uint)0x8626),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PROGRAM_LENGTH_NV")]
    ProgramLengthnv = unchecked((uint)0x8627),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PROGRAM_STRING_NV")]
    ProgramStringnv = unchecked((uint)0x8628),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MODELVIEW_PROJECTION_NV")]
    ModelviewProjectionnv = unchecked((uint)0x8629),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_IDENTITY_NV")]
    Identitynv = unchecked((uint)0x862A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_INVERSE_NV")]
    Inversenv = unchecked((uint)0x862B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TRANSPOSE_NV")]
    Transposenv = unchecked((uint)0x862C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_INVERSE_TRANSPOSE_NV")]
    InverseTransposenv = unchecked((uint)0x862D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_TRACK_MATRIX_STACK_DEPTH_NV")]
    MaxTrackMatrixStackDepthnv = unchecked((uint)0x862E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_TRACK_MATRICES_NV")]
    MaxTrackMatricesnv = unchecked((uint)0x862F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MATRIX0_NV")]
    Matrix0Nv = unchecked((uint)0x8630),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MATRIX1_NV")]
    Matrix1Nv = unchecked((uint)0x8631),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MATRIX2_NV")]
    Matrix2Nv = unchecked((uint)0x8632),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MATRIX3_NV")]
    Matrix3Nv = unchecked((uint)0x8633),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MATRIX4_NV")]
    Matrix4Nv = unchecked((uint)0x8634),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MATRIX5_NV")]
    Matrix5Nv = unchecked((uint)0x8635),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MATRIX6_NV")]
    Matrix6Nv = unchecked((uint)0x8636),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MATRIX7_NV")]
    Matrix7Nv = unchecked((uint)0x8637),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CURRENT_MATRIX_STACK_DEPTH_NV")]
    CurrentMatrixStackDepthnv = unchecked((uint)0x8640),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CURRENT_MATRIX_NV")]
    CurrentMatrixnv = unchecked((uint)0x8641),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_PROGRAM_POINT_SIZE_NV")]
    VertexProgramPointSizenv = unchecked((uint)0x8642),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_PROGRAM_TWO_SIDE_NV")]
    VertexProgramTwoSidenv = unchecked((uint)0x8643),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PROGRAM_PARAMETER_NV")]
    ProgramParameternv = unchecked((uint)0x8644),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ATTRIB_ARRAY_POINTER_NV")]
    AttribArrayPointernv = unchecked((uint)0x8645),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PROGRAM_TARGET_NV")]
    ProgramTargetnv = unchecked((uint)0x8646),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PROGRAM_RESIDENT_NV")]
    ProgramResidentnv = unchecked((uint)0x8647),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TRACK_MATRIX_NV")]
    TrackMatrixnv = unchecked((uint)0x8648),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TRACK_MATRIX_TRANSFORM_NV")]
    TrackMatrixTransformnv = unchecked((uint)0x8649),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_PROGRAM_BINDING_NV")]
    VertexProgramBindingnv = unchecked((uint)0x864A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PROGRAM_ERROR_POSITION_NV")]
    ProgramErrorPositionnv = unchecked((uint)0x864B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_ATTRIB_ARRAY0_NV")]
    VertexAttribArray0Nv = unchecked((uint)0x8650),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_ATTRIB_ARRAY1_NV")]
    VertexAttribArray1Nv = unchecked((uint)0x8651),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_ATTRIB_ARRAY2_NV")]
    VertexAttribArray2Nv = unchecked((uint)0x8652),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_ATTRIB_ARRAY3_NV")]
    VertexAttribArray3Nv = unchecked((uint)0x8653),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_ATTRIB_ARRAY4_NV")]
    VertexAttribArray4Nv = unchecked((uint)0x8654),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_ATTRIB_ARRAY5_NV")]
    VertexAttribArray5Nv = unchecked((uint)0x8655),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_ATTRIB_ARRAY6_NV")]
    VertexAttribArray6Nv = unchecked((uint)0x8656),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_ATTRIB_ARRAY7_NV")]
    VertexAttribArray7Nv = unchecked((uint)0x8657),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_ATTRIB_ARRAY8_NV")]
    VertexAttribArray8Nv = unchecked((uint)0x8658),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_ATTRIB_ARRAY9_NV")]
    VertexAttribArray9Nv = unchecked((uint)0x8659),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_ATTRIB_ARRAY10_NV")]
    VertexAttribArray10Nv = unchecked((uint)0x865A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_ATTRIB_ARRAY11_NV")]
    VertexAttribArray11Nv = unchecked((uint)0x865B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_ATTRIB_ARRAY12_NV")]
    VertexAttribArray12Nv = unchecked((uint)0x865C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_ATTRIB_ARRAY13_NV")]
    VertexAttribArray13Nv = unchecked((uint)0x865D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_ATTRIB_ARRAY14_NV")]
    VertexAttribArray14Nv = unchecked((uint)0x865E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_ATTRIB_ARRAY15_NV")]
    VertexAttribArray15Nv = unchecked((uint)0x865F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP1_VERTEX_ATTRIB0_4_NV")]
    Map1VertexAttrib0X4Nv = unchecked((uint)0x8660),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP1_VERTEX_ATTRIB1_4_NV")]
    Map1VertexAttrib1X4Nv = unchecked((uint)0x8661),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP1_VERTEX_ATTRIB2_4_NV")]
    Map1VertexAttrib2X4Nv = unchecked((uint)0x8662),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP1_VERTEX_ATTRIB3_4_NV")]
    Map1VertexAttrib3X4Nv = unchecked((uint)0x8663),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP1_VERTEX_ATTRIB4_4_NV")]
    Map1VertexAttrib4X4Nv = unchecked((uint)0x8664),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP1_VERTEX_ATTRIB5_4_NV")]
    Map1VertexAttrib5X4Nv = unchecked((uint)0x8665),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP1_VERTEX_ATTRIB6_4_NV")]
    Map1VertexAttrib6X4Nv = unchecked((uint)0x8666),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP1_VERTEX_ATTRIB7_4_NV")]
    Map1VertexAttrib7X4Nv = unchecked((uint)0x8667),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP1_VERTEX_ATTRIB8_4_NV")]
    Map1VertexAttrib8X4Nv = unchecked((uint)0x8668),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP1_VERTEX_ATTRIB9_4_NV")]
    Map1VertexAttrib9X4Nv = unchecked((uint)0x8669),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP1_VERTEX_ATTRIB10_4_NV")]
    Map1VertexAttrib10X4Nv = unchecked((uint)0x866A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP1_VERTEX_ATTRIB11_4_NV")]
    Map1VertexAttrib11X4Nv = unchecked((uint)0x866B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP1_VERTEX_ATTRIB12_4_NV")]
    Map1VertexAttrib12X4Nv = unchecked((uint)0x866C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP1_VERTEX_ATTRIB13_4_NV")]
    Map1VertexAttrib13X4Nv = unchecked((uint)0x866D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP1_VERTEX_ATTRIB14_4_NV")]
    Map1VertexAttrib14X4Nv = unchecked((uint)0x866E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP1_VERTEX_ATTRIB15_4_NV")]
    Map1VertexAttrib15X4Nv = unchecked((uint)0x866F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP2_VERTEX_ATTRIB0_4_NV")]
    Map2VertexAttrib0X4Nv = unchecked((uint)0x8670),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP2_VERTEX_ATTRIB1_4_NV")]
    Map2VertexAttrib1X4Nv = unchecked((uint)0x8671),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP2_VERTEX_ATTRIB2_4_NV")]
    Map2VertexAttrib2X4Nv = unchecked((uint)0x8672),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP2_VERTEX_ATTRIB3_4_NV")]
    Map2VertexAttrib3X4Nv = unchecked((uint)0x8673),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP2_VERTEX_ATTRIB4_4_NV")]
    Map2VertexAttrib4X4Nv = unchecked((uint)0x8674),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP2_VERTEX_ATTRIB5_4_NV")]
    Map2VertexAttrib5X4Nv = unchecked((uint)0x8675),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP2_VERTEX_ATTRIB6_4_NV")]
    Map2VertexAttrib6X4Nv = unchecked((uint)0x8676),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP2_VERTEX_ATTRIB7_4_NV")]
    Map2VertexAttrib7X4Nv = unchecked((uint)0x8677),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP2_VERTEX_ATTRIB8_4_NV")]
    Map2VertexAttrib8X4Nv = unchecked((uint)0x8678),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP2_VERTEX_ATTRIB9_4_NV")]
    Map2VertexAttrib9X4Nv = unchecked((uint)0x8679),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP2_VERTEX_ATTRIB10_4_NV")]
    Map2VertexAttrib10X4Nv = unchecked((uint)0x867A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP2_VERTEX_ATTRIB11_4_NV")]
    Map2VertexAttrib11X4Nv = unchecked((uint)0x867B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP2_VERTEX_ATTRIB12_4_NV")]
    Map2VertexAttrib12X4Nv = unchecked((uint)0x867C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP2_VERTEX_ATTRIB13_4_NV")]
    Map2VertexAttrib13X4Nv = unchecked((uint)0x867D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP2_VERTEX_ATTRIB14_4_NV")]
    Map2VertexAttrib14X4Nv = unchecked((uint)0x867E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAP2_VERTEX_ATTRIB15_4_NV")]
    Map2VertexAttrib15X4Nv = unchecked((uint)0x867F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_ATTRIB_ARRAY_INTEGER_NV")]
    VertexAttribArrayIntegernv = unchecked((uint)0x88FD),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIDEO_BUFFER_NV")]
    VideoBuffernv = unchecked((uint)0x9020),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIDEO_BUFFER_BINDING_NV")]
    VideoBufferBindingnv = unchecked((uint)0x9021),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FIELD_UPPER_NV")]
    FieldUppernv = unchecked((uint)0x9022),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FIELD_LOWER_NV")]
    FieldLowernv = unchecked((uint)0x9023),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_NUM_VIDEO_CAPTURE_STREAMS_NV")]
    NumVideoCaptureStreamsnv = unchecked((uint)0x9024),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_NEXT_VIDEO_CAPTURE_BUFFER_STATUS_NV")]
    NextVideoCaptureBufferStatusnv = unchecked((uint)0x9025),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIDEO_CAPTURE_TO_422_SUPPORTED_NV")]
    VideoCaptureTo422Supportednv = unchecked((uint)0x9026),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_LAST_VIDEO_CAPTURE_STATUS_NV")]
    LastVideoCaptureStatusnv = unchecked((uint)0x9027),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIDEO_BUFFER_PITCH_NV")]
    VideoBufferPitchnv = unchecked((uint)0x9028),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIDEO_COLOR_CONVERSION_MATRIX_NV")]
    VideoColorConversionMatrixnv = unchecked((uint)0x9029),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIDEO_COLOR_CONVERSION_MAX_NV")]
    VideoColorConversionMaxnv = unchecked((uint)0x902A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIDEO_COLOR_CONVERSION_MIN_NV")]
    VideoColorConversionMinnv = unchecked((uint)0x902B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIDEO_COLOR_CONVERSION_OFFSET_NV")]
    VideoColorConversionOffsetnv = unchecked((uint)0x902C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIDEO_BUFFER_INTERNAL_FORMAT_NV")]
    VideoBufferInternalFormatnv = unchecked((uint)0x902D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PARTIAL_SUCCESS_NV")]
    PartialSuccessnv = unchecked((uint)0x902E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SUCCESS_NV")]
    Successnv = unchecked((uint)0x902F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FAILURE_NV")]
    Failurenv = unchecked((uint)0x9030),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_YCBYCR8_422_NV")]
    Ycbycr8X422Nv = unchecked((uint)0x9031),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_YCBAYCR8A_4224_NV")]
    Ycbaycr8A4224Nv = unchecked((uint)0x9032),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_Z6Y10Z6CB10Z6Y10Z6CR10_422_NV")]
    Z6Y10Z6Cb10Z6Y10Z6Cr10X422Nv = unchecked((uint)0x9033),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_Z6Y10Z6CB10Z6A10Z6Y10Z6CR10Z6A10_4224_NV")]
    Z6Y10Z6Cb10Z6A10Z6Y10Z6Cr10Z6A10X4224Nv = unchecked((uint)0x9034),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_Z4Y12Z4CB12Z4Y12Z4CR12_422_NV")]
    Z4Y12Z4Cb12Z4Y12Z4Cr12X422Nv = unchecked((uint)0x9035),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_Z4Y12Z4CB12Z4A12Z4Y12Z4CR12Z4A12_4224_NV")]
    Z4Y12Z4Cb12Z4A12Z4Y12Z4Cr12Z4A12X4224Nv = unchecked((uint)0x9036),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_Z4Y12Z4CB12Z4CR12_444_NV")]
    Z4Y12Z4Cb12Z4Cr12X444Nv = unchecked((uint)0x9037),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIDEO_CAPTURE_FRAME_WIDTH_NV")]
    VideoCaptureFrameWidthnv = unchecked((uint)0x9038),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIDEO_CAPTURE_FRAME_HEIGHT_NV")]
    VideoCaptureFrameHeightnv = unchecked((uint)0x9039),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIDEO_CAPTURE_FIELD_UPPER_HEIGHT_NV")]
    VideoCaptureFieldUpperHeightnv = unchecked((uint)0x903A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIDEO_CAPTURE_FIELD_LOWER_HEIGHT_NV")]
    VideoCaptureFieldLowerHeightnv = unchecked((uint)0x903B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIDEO_CAPTURE_SURFACE_ORIGIN_NV")]
    VideoCaptureSurfaceOriginnv = unchecked((uint)0x903C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIEWPORT_SWIZZLE_POSITIVE_X_NV")]
    ViewportSwizzlePositiveXnv = unchecked((uint)0x9350),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIEWPORT_SWIZZLE_NEGATIVE_X_NV")]
    ViewportSwizzleNegativeXnv = unchecked((uint)0x9351),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIEWPORT_SWIZZLE_POSITIVE_Y_NV")]
    ViewportSwizzlePositiveYnv = unchecked((uint)0x9352),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIEWPORT_SWIZZLE_NEGATIVE_Y_NV")]
    ViewportSwizzleNegativeYnv = unchecked((uint)0x9353),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIEWPORT_SWIZZLE_POSITIVE_Z_NV")]
    ViewportSwizzlePositiveZnv = unchecked((uint)0x9354),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIEWPORT_SWIZZLE_NEGATIVE_Z_NV")]
    ViewportSwizzleNegativeZnv = unchecked((uint)0x9355),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIEWPORT_SWIZZLE_POSITIVE_W_NV")]
    ViewportSwizzlePositiveWnv = unchecked((uint)0x9356),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIEWPORT_SWIZZLE_NEGATIVE_W_NV")]
    ViewportSwizzleNegativeWnv = unchecked((uint)0x9357),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIEWPORT_SWIZZLE_X_NV")]
    ViewportSwizzleXnv = unchecked((uint)0x9358),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIEWPORT_SWIZZLE_Y_NV")]
    ViewportSwizzleYnv = unchecked((uint)0x9359),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIEWPORT_SWIZZLE_Z_NV")]
    ViewportSwizzleZnv = unchecked((uint)0x935A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIEWPORT_SWIZZLE_W_NV")]
    ViewportSwizzleWnv = unchecked((uint)0x935B),

    [NameAffix("Suffix", "OML", 0)]
    [NativeName("GL_INTERLACE_OML")]
    Interlaceoml = unchecked((uint)0x8980),

    [NameAffix("Suffix", "OML", 0)]
    [NativeName("GL_INTERLACE_READ_OML")]
    InterlaceReadoml = unchecked((uint)0x8981),

    [NameAffix("Suffix", "OML", 0)]
    [NativeName("GL_PACK_RESAMPLE_OML")]
    PackResampleoml = unchecked((uint)0x8984),

    [NameAffix("Suffix", "OML", 0)]
    [NativeName("GL_UNPACK_RESAMPLE_OML")]
    UnpackResampleoml = unchecked((uint)0x8985),

    [NameAffix("Suffix", "OML", 0)]
    [NativeName("GL_RESAMPLE_REPLICATE_OML")]
    ResampleReplicateoml = unchecked((uint)0x8986),

    [NameAffix("Suffix", "OML", 0)]
    [NativeName("GL_RESAMPLE_ZERO_FILL_OML")]
    ResampleZeroFilloml = unchecked((uint)0x8987),

    [NameAffix("Suffix", "OML", 0)]
    [NativeName("GL_RESAMPLE_AVERAGE_OML")]
    ResampleAverageoml = unchecked((uint)0x8988),

    [NameAffix("Suffix", "OML", 0)]
    [NativeName("GL_RESAMPLE_DECIMATE_OML")]
    ResampleDecimateoml = unchecked((uint)0x8989),

    [NameAffix("Suffix", "OML", 0)]
    [NativeName("GL_FORMAT_SUBSAMPLE_24_24_OML")]
    FormatSubsample24X24Oml = unchecked((uint)0x8982),

    [NameAffix("Suffix", "OML", 0)]
    [NativeName("GL_FORMAT_SUBSAMPLE_244_244_OML")]
    FormatSubsample244X244Oml = unchecked((uint)0x8983),

    [NameAffix("Suffix", "OVR", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_NUM_VIEWS_OVR")]
    FramebufferAttachmentTextureNumViewsovr = unchecked((uint)0x9630),

    [NameAffix("Suffix", "OVR", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_BASE_VIEW_INDEX_OVR")]
    FramebufferAttachmentTextureBaseViewIndexovr = unchecked((uint)0x9632),

    [NameAffix("Suffix", "OVR", 0)]
    [NativeName("GL_MAX_VIEWS_OVR")]
    MaxViewsovr = unchecked((uint)0x9631),

    [NameAffix("Suffix", "OVR", 0)]
    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_VIEW_TARGETS_OVR")]
    FramebufferIncompleteViewTargetsovr = unchecked((uint)0x9633),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_PREFER_DOUBLEBUFFER_HINT_PGI")]
    PreferDoublebufferHintpgi = unchecked((uint)0x1A1F8),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_CONSERVE_MEMORY_HINT_PGI")]
    ConserveMemoryHintpgi = unchecked((uint)0x1A1FD),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_RECLAIM_MEMORY_HINT_PGI")]
    ReclaimMemoryHintpgi = unchecked((uint)0x1A1FE),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_NATIVE_GRAPHICS_HANDLE_PGI")]
    NativeGraphicsHandlepgi = unchecked((uint)0x1A202),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_NATIVE_GRAPHICS_BEGIN_HINT_PGI")]
    NativeGraphicsBeginHintpgi = unchecked((uint)0x1A203),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_NATIVE_GRAPHICS_END_HINT_PGI")]
    NativeGraphicsEndHintpgi = unchecked((uint)0x1A204),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_ALWAYS_FAST_HINT_PGI")]
    AlwaysFastHintpgi = unchecked((uint)0x1A20C),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_ALWAYS_SOFT_HINT_PGI")]
    AlwaysSoftHintpgi = unchecked((uint)0x1A20D),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_ALLOW_DRAW_OBJ_HINT_PGI")]
    AllowDrawObjHintpgi = unchecked((uint)0x1A20E),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_ALLOW_DRAW_WIN_HINT_PGI")]
    AllowDrawWinHintpgi = unchecked((uint)0x1A20F),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_ALLOW_DRAW_FRG_HINT_PGI")]
    AllowDrawFrgHintpgi = unchecked((uint)0x1A210),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_ALLOW_DRAW_MEM_HINT_PGI")]
    AllowDrawMemHintpgi = unchecked((uint)0x1A211),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_STRICT_DEPTHFUNC_HINT_PGI")]
    StrictDepthfuncHintpgi = unchecked((uint)0x1A216),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_STRICT_LIGHTING_HINT_PGI")]
    StrictLightingHintpgi = unchecked((uint)0x1A217),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_STRICT_SCISSOR_HINT_PGI")]
    StrictScissorHintpgi = unchecked((uint)0x1A218),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_FULL_STIPPLE_HINT_PGI")]
    FullStippleHintpgi = unchecked((uint)0x1A219),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_CLIP_NEAR_HINT_PGI")]
    ClipNearHintpgi = unchecked((uint)0x1A220),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_CLIP_FAR_HINT_PGI")]
    ClipFarHintpgi = unchecked((uint)0x1A221),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_WIDE_LINE_HINT_PGI")]
    WideLineHintpgi = unchecked((uint)0x1A222),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_BACK_NORMALS_HINT_PGI")]
    BackNormalsHintpgi = unchecked((uint)0x1A223),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_VERTEX_DATA_HINT_PGI")]
    VertexDataHintpgi = unchecked((uint)0x1A22A),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_VERTEX_CONSISTENT_HINT_PGI")]
    VertexConsistentHintpgi = unchecked((uint)0x1A22B),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_MATERIAL_SIDE_HINT_PGI")]
    MaterialSideHintpgi = unchecked((uint)0x1A22C),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_MAX_VERTEX_HINT_PGI")]
    MaxVertexHintpgi = unchecked((uint)0x1A22D),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_COLOR3_BIT_PGI")]
    Color3Bitpgi = unchecked((uint)0x00010000),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_COLOR4_BIT_PGI")]
    Color4Bitpgi = unchecked((uint)0x00020000),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_EDGEFLAG_BIT_PGI")]
    EdgeflagBitpgi = unchecked((uint)0x00040000),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_INDEX_BIT_PGI")]
    IndexBitpgi = unchecked((uint)0x00080000),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_MAT_AMBIENT_BIT_PGI")]
    MatAmbientBitpgi = unchecked((uint)0x00100000),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_MAT_AMBIENT_AND_DIFFUSE_BIT_PGI")]
    MatAmbientAndDiffuseBitpgi = unchecked((uint)0x00200000),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_MAT_DIFFUSE_BIT_PGI")]
    MatDiffuseBitpgi = unchecked((uint)0x00400000),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_MAT_EMISSION_BIT_PGI")]
    MatEmissionBitpgi = unchecked((uint)0x00800000),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_MAT_COLOR_INDEXES_BIT_PGI")]
    MatColorIndexesBitpgi = unchecked((uint)0x01000000),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_MAT_SHININESS_BIT_PGI")]
    MatShininessBitpgi = unchecked((uint)0x02000000),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_MAT_SPECULAR_BIT_PGI")]
    MatSpecularBitpgi = unchecked((uint)0x04000000),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_NORMAL_BIT_PGI")]
    NormalBitpgi = unchecked((uint)0x08000000),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_TEXCOORD1_BIT_PGI")]
    Texcoord1Bitpgi = unchecked((uint)0x10000000),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_TEXCOORD2_BIT_PGI")]
    Texcoord2Bitpgi = unchecked((uint)0x20000000),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_TEXCOORD3_BIT_PGI")]
    Texcoord3Bitpgi = unchecked((uint)0x40000000),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_TEXCOORD4_BIT_PGI")]
    Texcoord4Bitpgi = unchecked((uint)0x80000000),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_VERTEX23_BIT_PGI")]
    Vertex23Bitpgi = unchecked((uint)0x00000004),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_VERTEX4_BIT_PGI")]
    Vertex4Bitpgi = unchecked((uint)0x00000008),

    [NameAffix("Suffix", "REND", 0)]
    [NativeName("GL_SCREEN_COORDINATES_REND")]
    ScreenCoordinatesrend = unchecked((uint)0x8490),

    [NameAffix("Suffix", "REND", 0)]
    [NativeName("GL_INVERTED_SCREEN_W_REND")]
    InvertedScreenWrend = unchecked((uint)0x8491),

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

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_DETAIL_TEXTURE_2D_SGIS")]
    DetailTexture2Dsgis = unchecked((uint)0x8095),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_DETAIL_TEXTURE_2D_BINDING_SGIS")]
    DetailTexture2DBindingsgis = unchecked((uint)0x8096),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_LINEAR_DETAIL_SGIS")]
    LinearDetailsgis = unchecked((uint)0x8097),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_LINEAR_DETAIL_ALPHA_SGIS")]
    LinearDetailAlphasgis = unchecked((uint)0x8098),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_LINEAR_DETAIL_COLOR_SGIS")]
    LinearDetailColorsgis = unchecked((uint)0x8099),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_DETAIL_TEXTURE_LEVEL_SGIS")]
    DetailTextureLevelsgis = unchecked((uint)0x809A),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_DETAIL_TEXTURE_MODE_SGIS")]
    DetailTextureModesgis = unchecked((uint)0x809B),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_DETAIL_TEXTURE_FUNC_POINTS_SGIS")]
    DetailTextureFuncPointssgis = unchecked((uint)0x809C),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_FOG_FUNC_SGIS")]
    FogFuncsgis = unchecked((uint)0x812A),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_FOG_FUNC_POINTS_SGIS")]
    FogFuncPointssgis = unchecked((uint)0x812B),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_MAX_FOG_FUNC_POINTS_SGIS")]
    MaxFogFuncPointssgis = unchecked((uint)0x812C),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_GENERATE_MIPMAP_SGIS")]
    GenerateMipmapsgis = unchecked((uint)0x8191),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_GENERATE_MIPMAP_HINT_SGIS")]
    GenerateMipmapHintsgis = unchecked((uint)0x8192),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_MULTISAMPLE_SGIS")]
    Multisamplesgis = unchecked((uint)0x809D),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_SAMPLE_ALPHA_TO_MASK_SGIS")]
    SampleAlphaToMasksgis = unchecked((uint)0x809E),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_SAMPLE_ALPHA_TO_ONE_SGIS")]
    SampleAlphaToOnesgis = unchecked((uint)0x809F),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_SAMPLE_MASK_SGIS")]
    SampleMasksgis = unchecked((uint)0x80A0),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_1PASS_SGIS")]
    X1Passsgis = unchecked((uint)0x80A1),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_2PASS_0_SGIS")]
    X2Pass0Sgis = unchecked((uint)0x80A2),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_2PASS_1_SGIS")]
    X2Pass1Sgis = unchecked((uint)0x80A3),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_4PASS_0_SGIS")]
    X4Pass0Sgis = unchecked((uint)0x80A4),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_4PASS_1_SGIS")]
    X4Pass1Sgis = unchecked((uint)0x80A5),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_4PASS_2_SGIS")]
    X4Pass2Sgis = unchecked((uint)0x80A6),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_4PASS_3_SGIS")]
    X4Pass3Sgis = unchecked((uint)0x80A7),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_SAMPLE_BUFFERS_SGIS")]
    SampleBufferssgis = unchecked((uint)0x80A8),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_SAMPLES_SGIS")]
    Samplessgis = unchecked((uint)0x80A9),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_SAMPLE_MASK_VALUE_SGIS")]
    SampleMaskValuesgis = unchecked((uint)0x80AA),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_SAMPLE_MASK_INVERT_SGIS")]
    SampleMaskInvertsgis = unchecked((uint)0x80AB),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_SAMPLE_PATTERN_SGIS")]
    SamplePatternsgis = unchecked((uint)0x80AC),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_PIXEL_TEXTURE_SGIS")]
    PixelTexturesgis = unchecked((uint)0x8353),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_PIXEL_FRAGMENT_RGB_SOURCE_SGIS")]
    PixelFragmentRgbSourcesgis = unchecked((uint)0x8354),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS")]
    PixelFragmentAlphaSourcesgis = unchecked((uint)0x8355),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_PIXEL_GROUP_COLOR_SGIS")]
    PixelGroupColorsgis = unchecked((uint)0x8356),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_EYE_DISTANCE_TO_POINT_SGIS")]
    EyeDistanceToPointsgis = unchecked((uint)0x81F0),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_OBJECT_DISTANCE_TO_POINT_SGIS")]
    ObjectDistanceToPointsgis = unchecked((uint)0x81F1),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_EYE_DISTANCE_TO_LINE_SGIS")]
    EyeDistanceToLinesgis = unchecked((uint)0x81F2),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_OBJECT_DISTANCE_TO_LINE_SGIS")]
    ObjectDistanceToLinesgis = unchecked((uint)0x81F3),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_EYE_POINT_SGIS")]
    EyePointsgis = unchecked((uint)0x81F4),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_OBJECT_POINT_SGIS")]
    ObjectPointsgis = unchecked((uint)0x81F5),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_EYE_LINE_SGIS")]
    EyeLinesgis = unchecked((uint)0x81F6),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_OBJECT_LINE_SGIS")]
    ObjectLinesgis = unchecked((uint)0x81F7),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_POINT_SIZE_MIN_SGIS")]
    PointSizeMinsgis = unchecked((uint)0x8126),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_POINT_SIZE_MAX_SGIS")]
    PointSizeMaxsgis = unchecked((uint)0x8127),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_POINT_FADE_THRESHOLD_SIZE_SGIS")]
    PointFadeThresholdSizesgis = unchecked((uint)0x8128),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_DISTANCE_ATTENUATION_SGIS")]
    DistanceAttenuationsgis = unchecked((uint)0x8129),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_LINEAR_SHARPEN_SGIS")]
    LinearSharpensgis = unchecked((uint)0x80AD),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_LINEAR_SHARPEN_ALPHA_SGIS")]
    LinearSharpenAlphasgis = unchecked((uint)0x80AE),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_LINEAR_SHARPEN_COLOR_SGIS")]
    LinearSharpenColorsgis = unchecked((uint)0x80AF),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_SHARPEN_TEXTURE_FUNC_POINTS_SGIS")]
    SharpenTextureFuncPointssgis = unchecked((uint)0x80B0),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_PACK_SKIP_VOLUMES_SGIS")]
    PackSkipVolumessgis = unchecked((uint)0x8130),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_PACK_IMAGE_DEPTH_SGIS")]
    PackImageDepthsgis = unchecked((uint)0x8131),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_UNPACK_SKIP_VOLUMES_SGIS")]
    UnpackSkipVolumessgis = unchecked((uint)0x8132),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_UNPACK_IMAGE_DEPTH_SGIS")]
    UnpackImageDepthsgis = unchecked((uint)0x8133),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_TEXTURE_4D_SGIS")]
    Texture4Dsgis = unchecked((uint)0x8134),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_PROXY_TEXTURE_4D_SGIS")]
    ProxyTexture4Dsgis = unchecked((uint)0x8135),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_TEXTURE_4DSIZE_SGIS")]
    Texture4Dsizesgis = unchecked((uint)0x8136),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_TEXTURE_WRAP_Q_SGIS")]
    TextureWrapQsgis = unchecked((uint)0x8137),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_MAX_4D_TEXTURE_SIZE_SGIS")]
    Max4DTextureSizesgis = unchecked((uint)0x8138),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_TEXTURE_4D_BINDING_SGIS")]
    Texture4DBindingsgis = unchecked((uint)0x814F),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_CLAMP_TO_BORDER_SGIS")]
    ClampToBordersgis = unchecked((uint)0x812D),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_TEXTURE_COLOR_WRITEMASK_SGIS")]
    TextureColorWritemasksgis = unchecked((uint)0x81EF),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_CLAMP_TO_EDGE_SGIS")]
    ClampToEdgesgis = unchecked((uint)0x812F),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_FILTER4_SGIS")]
    Filter4Sgis = unchecked((uint)0x8146),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_TEXTURE_FILTER4_SIZE_SGIS")]
    TextureFilter4Sizesgis = unchecked((uint)0x8147),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_TEXTURE_MIN_LOD_SGIS")]
    TextureMinLodsgis = unchecked((uint)0x813A),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_TEXTURE_MAX_LOD_SGIS")]
    TextureMaxLodsgis = unchecked((uint)0x813B),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_TEXTURE_BASE_LEVEL_SGIS")]
    TextureBaseLevelsgis = unchecked((uint)0x813C),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_TEXTURE_MAX_LEVEL_SGIS")]
    TextureMaxLevelsgis = unchecked((uint)0x813D),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_DUAL_ALPHA4_SGIS")]
    DualAlpha4Sgis = unchecked((uint)0x8110),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_DUAL_ALPHA8_SGIS")]
    DualAlpha8Sgis = unchecked((uint)0x8111),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_DUAL_ALPHA12_SGIS")]
    DualAlpha12Sgis = unchecked((uint)0x8112),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_DUAL_ALPHA16_SGIS")]
    DualAlpha16Sgis = unchecked((uint)0x8113),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_DUAL_LUMINANCE4_SGIS")]
    DualLuminance4Sgis = unchecked((uint)0x8114),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_DUAL_LUMINANCE8_SGIS")]
    DualLuminance8Sgis = unchecked((uint)0x8115),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_DUAL_LUMINANCE12_SGIS")]
    DualLuminance12Sgis = unchecked((uint)0x8116),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_DUAL_LUMINANCE16_SGIS")]
    DualLuminance16Sgis = unchecked((uint)0x8117),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_DUAL_INTENSITY4_SGIS")]
    DualIntensity4Sgis = unchecked((uint)0x8118),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_DUAL_INTENSITY8_SGIS")]
    DualIntensity8Sgis = unchecked((uint)0x8119),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_DUAL_INTENSITY12_SGIS")]
    DualIntensity12Sgis = unchecked((uint)0x811A),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_DUAL_INTENSITY16_SGIS")]
    DualIntensity16Sgis = unchecked((uint)0x811B),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_DUAL_LUMINANCE_ALPHA4_SGIS")]
    DualLuminanceAlpha4Sgis = unchecked((uint)0x811C),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_DUAL_LUMINANCE_ALPHA8_SGIS")]
    DualLuminanceAlpha8Sgis = unchecked((uint)0x811D),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_QUAD_ALPHA4_SGIS")]
    QuadAlpha4Sgis = unchecked((uint)0x811E),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_QUAD_ALPHA8_SGIS")]
    QuadAlpha8Sgis = unchecked((uint)0x811F),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_QUAD_LUMINANCE4_SGIS")]
    QuadLuminance4Sgis = unchecked((uint)0x8120),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_QUAD_LUMINANCE8_SGIS")]
    QuadLuminance8Sgis = unchecked((uint)0x8121),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_QUAD_INTENSITY4_SGIS")]
    QuadIntensity4Sgis = unchecked((uint)0x8122),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_QUAD_INTENSITY8_SGIS")]
    QuadIntensity8Sgis = unchecked((uint)0x8123),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_DUAL_TEXTURE_SELECT_SGIS")]
    DualTextureSelectsgis = unchecked((uint)0x8124),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_QUAD_TEXTURE_SELECT_SGIS")]
    QuadTextureSelectsgis = unchecked((uint)0x8125),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_ASYNC_MARKER_SGIX")]
    AsyncMarkersgix = unchecked((uint)0x8329),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_ASYNC_HISTOGRAM_SGIX")]
    AsyncHistogramsgix = unchecked((uint)0x832C),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_MAX_ASYNC_HISTOGRAM_SGIX")]
    MaxAsyncHistogramsgix = unchecked((uint)0x832D),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_ASYNC_TEX_IMAGE_SGIX")]
    AsyncTexImagesgix = unchecked((uint)0x835C),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_ASYNC_DRAW_PIXELS_SGIX")]
    AsyncDrawPixelssgix = unchecked((uint)0x835D),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_ASYNC_READ_PIXELS_SGIX")]
    AsyncReadPixelssgix = unchecked((uint)0x835E),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_MAX_ASYNC_TEX_IMAGE_SGIX")]
    MaxAsyncTexImagesgix = unchecked((uint)0x835F),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_MAX_ASYNC_DRAW_PIXELS_SGIX")]
    MaxAsyncDrawPixelssgix = unchecked((uint)0x8360),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_MAX_ASYNC_READ_PIXELS_SGIX")]
    MaxAsyncReadPixelssgix = unchecked((uint)0x8361),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_ALPHA_MIN_SGIX")]
    AlphaMinsgix = unchecked((uint)0x8320),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_ALPHA_MAX_SGIX")]
    AlphaMaxsgix = unchecked((uint)0x8321),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_CALLIGRAPHIC_FRAGMENT_SGIX")]
    CalligraphicFragmentsgix = unchecked((uint)0x8183),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_LINEAR_CLIPMAP_LINEAR_SGIX")]
    LinearClipmapLinearsgix = unchecked((uint)0x8170),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_CLIPMAP_CENTER_SGIX")]
    TextureClipmapCentersgix = unchecked((uint)0x8171),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_CLIPMAP_FRAME_SGIX")]
    TextureClipmapFramesgix = unchecked((uint)0x8172),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_CLIPMAP_OFFSET_SGIX")]
    TextureClipmapOffsetsgix = unchecked((uint)0x8173),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX")]
    TextureClipmapVirtualDepthsgix = unchecked((uint)0x8174),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_CLIPMAP_LOD_OFFSET_SGIX")]
    TextureClipmapLodOffsetsgix = unchecked((uint)0x8175),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_CLIPMAP_DEPTH_SGIX")]
    TextureClipmapDepthsgix = unchecked((uint)0x8176),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_MAX_CLIPMAP_DEPTH_SGIX")]
    MaxClipmapDepthsgix = unchecked((uint)0x8177),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_MAX_CLIPMAP_VIRTUAL_DEPTH_SGIX")]
    MaxClipmapVirtualDepthsgix = unchecked((uint)0x8178),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_NEAREST_CLIPMAP_NEAREST_SGIX")]
    NearestClipmapNearestsgix = unchecked((uint)0x844D),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_NEAREST_CLIPMAP_LINEAR_SGIX")]
    NearestClipmapLinearsgix = unchecked((uint)0x844E),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_LINEAR_CLIPMAP_NEAREST_SGIX")]
    LinearClipmapNearestsgix = unchecked((uint)0x844F),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_CONVOLUTION_HINT_SGIX")]
    ConvolutionHintsgix = unchecked((uint)0x8316),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_DEPTH_COMPONENT16_SGIX")]
    DepthComponent16Sgix = unchecked((uint)0x81A5),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_DEPTH_COMPONENT24_SGIX")]
    DepthComponent24Sgix = unchecked((uint)0x81A6),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_DEPTH_COMPONENT32_SGIX")]
    DepthComponent32Sgix = unchecked((uint)0x81A7),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FOG_OFFSET_SGIX")]
    FogOffsetsgix = unchecked((uint)0x8198),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FOG_OFFSET_VALUE_SGIX")]
    FogOffsetValuesgix = unchecked((uint)0x8199),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_LIGHTING_SGIX")]
    FragmentLightingsgix = unchecked((uint)0x8400),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_COLOR_MATERIAL_SGIX")]
    FragmentColorMaterialsgix = unchecked((uint)0x8401),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_COLOR_MATERIAL_FACE_SGIX")]
    FragmentColorMaterialFacesgix = unchecked((uint)0x8402),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_COLOR_MATERIAL_PARAMETER_SGIX")]
    FragmentColorMaterialParametersgix = unchecked((uint)0x8403),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_MAX_FRAGMENT_LIGHTS_SGIX")]
    MaxFragmentLightssgix = unchecked((uint)0x8404),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_MAX_ACTIVE_LIGHTS_SGIX")]
    MaxActiveLightssgix = unchecked((uint)0x8405),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_CURRENT_RASTER_NORMAL_SGIX")]
    CurrentRasterNormalsgix = unchecked((uint)0x8406),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_LIGHT_ENV_MODE_SGIX")]
    LightEnvModesgix = unchecked((uint)0x8407),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX")]
    FragmentLightModelLocalViewersgix = unchecked((uint)0x8408),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX")]
    FragmentLightModelTwoSidesgix = unchecked((uint)0x8409),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX")]
    FragmentLightModelAmbientsgix = unchecked((uint)0x840A),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX")]
    FragmentLightModelNormalInterpolationsgix = unchecked((uint)0x840B),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_LIGHT0_SGIX")]
    FragmentLight0Sgix = unchecked((uint)0x840C),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_LIGHT1_SGIX")]
    FragmentLight1Sgix = unchecked((uint)0x840D),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_LIGHT2_SGIX")]
    FragmentLight2Sgix = unchecked((uint)0x840E),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_LIGHT3_SGIX")]
    FragmentLight3Sgix = unchecked((uint)0x840F),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_LIGHT4_SGIX")]
    FragmentLight4Sgix = unchecked((uint)0x8410),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_LIGHT5_SGIX")]
    FragmentLight5Sgix = unchecked((uint)0x8411),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_LIGHT6_SGIX")]
    FragmentLight6Sgix = unchecked((uint)0x8412),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_LIGHT7_SGIX")]
    FragmentLight7Sgix = unchecked((uint)0x8413),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAMEZOOM_SGIX")]
    Framezoomsgix = unchecked((uint)0x818B),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAMEZOOM_FACTOR_SGIX")]
    FramezoomFactorsgix = unchecked((uint)0x818C),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_MAX_FRAMEZOOM_FACTOR_SGIX")]
    MaxFramezoomFactorsgix = unchecked((uint)0x818D),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_INSTRUMENT_BUFFER_POINTER_SGIX")]
    InstrumentBufferPointersgix = unchecked((uint)0x8180),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_INSTRUMENT_MEASUREMENTS_SGIX")]
    InstrumentMeasurementssgix = unchecked((uint)0x8181),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_INTERLACE_SGIX")]
    Interlacesgix = unchecked((uint)0x8094),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_IR_INSTRUMENT1_SGIX")]
    IrInstrument1Sgix = unchecked((uint)0x817F),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_LIST_PRIORITY_SGIX")]
    ListPrioritysgix = unchecked((uint)0x8182),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_PIXEL_TEX_GEN_SGIX")]
    PixelTexGensgix = unchecked((uint)0x8139),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_PIXEL_TEX_GEN_MODE_SGIX")]
    PixelTexGenModesgix = unchecked((uint)0x832B),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_PIXEL_TILE_BEST_ALIGNMENT_SGIX")]
    PixelTileBestAlignmentsgix = unchecked((uint)0x813E),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_PIXEL_TILE_CACHE_INCREMENT_SGIX")]
    PixelTileCacheIncrementsgix = unchecked((uint)0x813F),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_PIXEL_TILE_WIDTH_SGIX")]
    PixelTileWidthsgix = unchecked((uint)0x8140),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_PIXEL_TILE_HEIGHT_SGIX")]
    PixelTileHeightsgix = unchecked((uint)0x8141),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_PIXEL_TILE_GRID_WIDTH_SGIX")]
    PixelTileGridWidthsgix = unchecked((uint)0x8142),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_PIXEL_TILE_GRID_HEIGHT_SGIX")]
    PixelTileGridHeightsgix = unchecked((uint)0x8143),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_PIXEL_TILE_GRID_DEPTH_SGIX")]
    PixelTileGridDepthsgix = unchecked((uint)0x8144),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_PIXEL_TILE_CACHE_SIZE_SGIX")]
    PixelTileCacheSizesgix = unchecked((uint)0x8145),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_DEFORMATION_BIT_SGIX")]
    TextureDeformationBitsgix = unchecked((uint)0x00000001),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_GEOMETRY_DEFORMATION_BIT_SGIX")]
    GeometryDeformationBitsgix = unchecked((uint)0x00000002),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_GEOMETRY_DEFORMATION_SGIX")]
    GeometryDeformationsgix = unchecked((uint)0x8194),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_DEFORMATION_SGIX")]
    TextureDeformationsgix = unchecked((uint)0x8195),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_DEFORMATIONS_MASK_SGIX")]
    DeformationsMasksgix = unchecked((uint)0x8196),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_MAX_DEFORMATION_ORDER_SGIX")]
    MaxDeformationOrdersgix = unchecked((uint)0x8197),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_REFERENCE_PLANE_SGIX")]
    ReferencePlanesgix = unchecked((uint)0x817D),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_REFERENCE_PLANE_EQUATION_SGIX")]
    ReferencePlaneEquationsgix = unchecked((uint)0x817E),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_PACK_RESAMPLE_SGIX")]
    PackResamplesgix = unchecked((uint)0x842E),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_UNPACK_RESAMPLE_SGIX")]
    UnpackResamplesgix = unchecked((uint)0x842F),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_RESAMPLE_REPLICATE_SGIX")]
    ResampleReplicatesgix = unchecked((uint)0x8433),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_RESAMPLE_ZERO_FILL_SGIX")]
    ResampleZeroFillsgix = unchecked((uint)0x8434),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_RESAMPLE_DECIMATE_SGIX")]
    ResampleDecimatesgix = unchecked((uint)0x8430),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_SCALEBIAS_HINT_SGIX")]
    ScalebiasHintsgix = unchecked((uint)0x8322),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_COMPARE_SGIX")]
    TextureComparesgix = unchecked((uint)0x819A),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_COMPARE_OPERATOR_SGIX")]
    TextureCompareOperatorsgix = unchecked((uint)0x819B),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_LEQUAL_R_SGIX")]
    TextureLequalRsgix = unchecked((uint)0x819C),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_GEQUAL_R_SGIX")]
    TextureGequalRsgix = unchecked((uint)0x819D),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_SHADOW_AMBIENT_SGIX")]
    ShadowAmbientsgix = unchecked((uint)0x80BF),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_SPRITE_SGIX")]
    Spritesgix = unchecked((uint)0x8148),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_SPRITE_MODE_SGIX")]
    SpriteModesgix = unchecked((uint)0x8149),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_SPRITE_AXIS_SGIX")]
    SpriteAxissgix = unchecked((uint)0x814A),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_SPRITE_TRANSLATION_SGIX")]
    SpriteTranslationsgix = unchecked((uint)0x814B),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_SPRITE_AXIAL_SGIX")]
    SpriteAxialsgix = unchecked((uint)0x814C),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_SPRITE_OBJECT_ALIGNED_SGIX")]
    SpriteObjectAlignedsgix = unchecked((uint)0x814D),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_SPRITE_EYE_ALIGNED_SGIX")]
    SpriteEyeAlignedsgix = unchecked((uint)0x814E),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_PACK_SUBSAMPLE_RATE_SGIX")]
    PackSubsampleRatesgix = unchecked((uint)0x85A0),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_UNPACK_SUBSAMPLE_RATE_SGIX")]
    UnpackSubsampleRatesgix = unchecked((uint)0x85A1),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_PIXEL_SUBSAMPLE_4444_SGIX")]
    PixelSubsample4444Sgix = unchecked((uint)0x85A2),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_PIXEL_SUBSAMPLE_2424_SGIX")]
    PixelSubsample2424Sgix = unchecked((uint)0x85A3),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_PIXEL_SUBSAMPLE_4242_SGIX")]
    PixelSubsample4242Sgix = unchecked((uint)0x85A4),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_ENV_BIAS_SGIX")]
    TextureEnvBiassgix = unchecked((uint)0x80BE),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_MAX_CLAMP_S_SGIX")]
    TextureMaxClampSsgix = unchecked((uint)0x8369),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_MAX_CLAMP_T_SGIX")]
    TextureMaxClampTsgix = unchecked((uint)0x836A),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_MAX_CLAMP_R_SGIX")]
    TextureMaxClampRsgix = unchecked((uint)0x836B),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_LOD_BIAS_S_SGIX")]
    TextureLodBiasSsgix = unchecked((uint)0x818E),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_LOD_BIAS_T_SGIX")]
    TextureLodBiasTsgix = unchecked((uint)0x818F),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_LOD_BIAS_R_SGIX")]
    TextureLodBiasRsgix = unchecked((uint)0x8190),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_MULTI_BUFFER_HINT_SGIX")]
    TextureMultiBufferHintsgix = unchecked((uint)0x812E),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_POST_TEXTURE_FILTER_BIAS_SGIX")]
    PostTextureFilterBiassgix = unchecked((uint)0x8179),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_POST_TEXTURE_FILTER_SCALE_SGIX")]
    PostTextureFilterScalesgix = unchecked((uint)0x817A),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_POST_TEXTURE_FILTER_BIAS_RANGE_SGIX")]
    PostTextureFilterBiasRangesgix = unchecked((uint)0x817B),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_POST_TEXTURE_FILTER_SCALE_RANGE_SGIX")]
    PostTextureFilterScaleRangesgix = unchecked((uint)0x817C),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_VERTEX_PRECLIP_SGIX")]
    VertexPreclipsgix = unchecked((uint)0x83EE),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_VERTEX_PRECLIP_HINT_SGIX")]
    VertexPreclipHintsgix = unchecked((uint)0x83EF),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_YCRCB_422_SGIX")]
    Ycrcb422Sgix = unchecked((uint)0x81BB),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_YCRCB_444_SGIX")]
    Ycrcb444Sgix = unchecked((uint)0x81BC),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_YCRCB_SGIX")]
    Ycrcbsgix = unchecked((uint)0x8318),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_YCRCBA_SGIX")]
    Ycrcbasgix = unchecked((uint)0x8319),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_COLOR_MATRIX_SGI")]
    ColorMatrixsgi = unchecked((uint)0x80B1),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_COLOR_MATRIX_STACK_DEPTH_SGI")]
    ColorMatrixStackDepthsgi = unchecked((uint)0x80B2),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_MAX_COLOR_MATRIX_STACK_DEPTH_SGI")]
    MaxColorMatrixStackDepthsgi = unchecked((uint)0x80B3),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_POST_COLOR_MATRIX_RED_SCALE_SGI")]
    PostColorMatrixRedScalesgi = unchecked((uint)0x80B4),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_POST_COLOR_MATRIX_GREEN_SCALE_SGI")]
    PostColorMatrixGreenScalesgi = unchecked((uint)0x80B5),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_POST_COLOR_MATRIX_BLUE_SCALE_SGI")]
    PostColorMatrixBlueScalesgi = unchecked((uint)0x80B6),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_POST_COLOR_MATRIX_ALPHA_SCALE_SGI")]
    PostColorMatrixAlphaScalesgi = unchecked((uint)0x80B7),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_POST_COLOR_MATRIX_RED_BIAS_SGI")]
    PostColorMatrixRedBiassgi = unchecked((uint)0x80B8),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_POST_COLOR_MATRIX_GREEN_BIAS_SGI")]
    PostColorMatrixGreenBiassgi = unchecked((uint)0x80B9),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_POST_COLOR_MATRIX_BLUE_BIAS_SGI")]
    PostColorMatrixBlueBiassgi = unchecked((uint)0x80BA),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_POST_COLOR_MATRIX_ALPHA_BIAS_SGI")]
    PostColorMatrixAlphaBiassgi = unchecked((uint)0x80BB),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_COLOR_TABLE_SGI")]
    ColorTablesgi = unchecked((uint)0x80D0),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_POST_CONVOLUTION_COLOR_TABLE_SGI")]
    PostConvolutionColorTablesgi = unchecked((uint)0x80D1),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI")]
    PostColorMatrixColorTablesgi = unchecked((uint)0x80D2),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_PROXY_COLOR_TABLE_SGI")]
    ProxyColorTablesgi = unchecked((uint)0x80D3),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_PROXY_POST_CONVOLUTION_COLOR_TABLE_SGI")]
    ProxyPostConvolutionColorTablesgi = unchecked((uint)0x80D4),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE_SGI")]
    ProxyPostColorMatrixColorTablesgi = unchecked((uint)0x80D5),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_COLOR_TABLE_SCALE_SGI")]
    ColorTableScalesgi = unchecked((uint)0x80D6),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_COLOR_TABLE_BIAS_SGI")]
    ColorTableBiassgi = unchecked((uint)0x80D7),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_COLOR_TABLE_FORMAT_SGI")]
    ColorTableFormatsgi = unchecked((uint)0x80D8),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_COLOR_TABLE_WIDTH_SGI")]
    ColorTableWidthsgi = unchecked((uint)0x80D9),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_COLOR_TABLE_RED_SIZE_SGI")]
    ColorTableRedSizesgi = unchecked((uint)0x80DA),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_COLOR_TABLE_GREEN_SIZE_SGI")]
    ColorTableGreenSizesgi = unchecked((uint)0x80DB),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_COLOR_TABLE_BLUE_SIZE_SGI")]
    ColorTableBlueSizesgi = unchecked((uint)0x80DC),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_COLOR_TABLE_ALPHA_SIZE_SGI")]
    ColorTableAlphaSizesgi = unchecked((uint)0x80DD),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_COLOR_TABLE_LUMINANCE_SIZE_SGI")]
    ColorTableLuminanceSizesgi = unchecked((uint)0x80DE),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_COLOR_TABLE_INTENSITY_SIZE_SGI")]
    ColorTableIntensitySizesgi = unchecked((uint)0x80DF),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_TEXTURE_COLOR_TABLE_SGI")]
    TextureColorTablesgi = unchecked((uint)0x80BC),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_PROXY_TEXTURE_COLOR_TABLE_SGI")]
    ProxyTextureColorTablesgi = unchecked((uint)0x80BD),

    [NameAffix("Suffix", "SUNX", 0)]
    [NativeName("GL_UNPACK_CONSTANT_DATA_SUNX")]
    UnpackConstantDatasunx = unchecked((uint)0x81D5),

    [NameAffix("Suffix", "SUNX", 0)]
    [NativeName("GL_TEXTURE_CONSTANT_DATA_SUNX")]
    TextureConstantDatasunx = unchecked((uint)0x81D6),

    [NameAffix("Suffix", "SUN", 0)]
    [NativeName("GL_WRAP_BORDER_SUN")]
    WrapBordersun = unchecked((uint)0x81D4),

    [NameAffix("Suffix", "SUN", 0)]
    [NativeName("GL_GLOBAL_ALPHA_SUN")]
    GlobalAlphasun = unchecked((uint)0x81D9),

    [NameAffix("Suffix", "SUN", 0)]
    [NativeName("GL_GLOBAL_ALPHA_FACTOR_SUN")]
    GlobalAlphaFactorsun = unchecked((uint)0x81DA),

    [NameAffix("Suffix", "SUN", 0)]
    [NativeName("GL_QUAD_MESH_SUN")]
    QuadMeshsun = unchecked((uint)0x8614),

    [NameAffix("Suffix", "SUN", 0)]
    [NativeName("GL_TRIANGLE_MESH_SUN")]
    TriangleMeshsun = unchecked((uint)0x8615),

    [NameAffix("Suffix", "SUN", 0)]
    [NativeName("GL_SLICE_ACCUM_SUN")]
    SliceAccumsun = unchecked((uint)0x85CC),

    [NameAffix("Suffix", "SUN", 0)]
    [NativeName("GL_RESTART_SUN")]
    Restartsun = unchecked((uint)0x0001),

    [NameAffix("Suffix", "SUN", 0)]
    [NativeName("GL_REPLACE_MIDDLE_SUN")]
    ReplaceMiddlesun = unchecked((uint)0x0002),

    [NameAffix("Suffix", "SUN", 0)]
    [NativeName("GL_REPLACE_OLDEST_SUN")]
    ReplaceOldestsun = unchecked((uint)0x0003),

    [NameAffix("Suffix", "SUN", 0)]
    [NativeName("GL_TRIANGLE_LIST_SUN")]
    TriangleListsun = unchecked((uint)0x81D7),

    [NameAffix("Suffix", "SUN", 0)]
    [NativeName("GL_REPLACEMENT_CODE_SUN")]
    ReplacementCodesun = unchecked((uint)0x81D8),

    [NameAffix("Suffix", "SUN", 0)]
    [NativeName("GL_REPLACEMENT_CODE_ARRAY_SUN")]
    ReplacementCodeArraysun = unchecked((uint)0x85C0),

    [NameAffix("Suffix", "SUN", 0)]
    [NativeName("GL_REPLACEMENT_CODE_ARRAY_TYPE_SUN")]
    ReplacementCodeArrayTypesun = unchecked((uint)0x85C1),

    [NameAffix("Suffix", "SUN", 0)]
    [NativeName("GL_REPLACEMENT_CODE_ARRAY_STRIDE_SUN")]
    ReplacementCodeArrayStridesun = unchecked((uint)0x85C2),

    [NameAffix("Suffix", "SUN", 0)]
    [NativeName("GL_REPLACEMENT_CODE_ARRAY_POINTER_SUN")]
    ReplacementCodeArrayPointersun = unchecked((uint)0x85C3),

    [NameAffix("Suffix", "SUN", 0)]
    [NativeName("GL_R1UI_V3F_SUN")]
    R1UiV3Fsun = unchecked((uint)0x85C4),

    [NameAffix("Suffix", "SUN", 0)]
    [NativeName("GL_R1UI_C4UB_V3F_SUN")]
    R1UiC4UbV3Fsun = unchecked((uint)0x85C5),

    [NameAffix("Suffix", "SUN", 0)]
    [NativeName("GL_R1UI_C3F_V3F_SUN")]
    R1UiC3FV3Fsun = unchecked((uint)0x85C6),

    [NameAffix("Suffix", "SUN", 0)]
    [NativeName("GL_R1UI_N3F_V3F_SUN")]
    R1UiN3FV3Fsun = unchecked((uint)0x85C7),

    [NameAffix("Suffix", "SUN", 0)]
    [NativeName("GL_R1UI_C4F_N3F_V3F_SUN")]
    R1UiC4FN3FV3Fsun = unchecked((uint)0x85C8),

    [NameAffix("Suffix", "SUN", 0)]
    [NativeName("GL_R1UI_T2F_V3F_SUN")]
    R1UiT2FV3Fsun = unchecked((uint)0x85C9),

    [NameAffix("Suffix", "SUN", 0)]
    [NativeName("GL_R1UI_T2F_N3F_V3F_SUN")]
    R1UiT2FN3FV3Fsun = unchecked((uint)0x85CA),

    [NameAffix("Suffix", "SUN", 0)]
    [NativeName("GL_R1UI_T2F_C4F_N3F_V3F_SUN")]
    R1UiT2FC4FN3FV3Fsun = unchecked((uint)0x85CB),

    [NameAffix("Suffix", "WIN", 0)]
    [NativeName("GL_PHONG_WIN")]
    Phongwin = unchecked((uint)0x80EA),

    [NameAffix("Suffix", "WIN", 0)]
    [NativeName("GL_PHONG_HINT_WIN")]
    PhongHintwin = unchecked((uint)0x80EB),

    [NameAffix("Suffix", "WIN", 0)]
    [NativeName("GL_FOG_SPECULAR_TEXTURE_WIN")]
    FogSpecularTexturewin = unchecked((uint)0x80EC),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS")]
    FramebufferIncompleteDimensions = unchecked((uint)0x8CD9),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_CONTEXT_RELEASE_BEHAVIOR_KHR")]
    ContextReleaseBehaviorkhr = unchecked((uint)0x82FB),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH_KHR")]
    ContextReleaseBehaviorFlushkhr = unchecked((uint)0x82FC),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_DEBUG_OUTPUT_SYNCHRONOUS_KHR")]
    DebugOutputSynchronouskhr = unchecked((uint)0x8242),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_KHR")]
    DebugNextLoggedMessageLengthkhr = unchecked((uint)0x8243),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_DEBUG_CALLBACK_FUNCTION_KHR")]
    DebugCallbackFunctionkhr = unchecked((uint)0x8244),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_DEBUG_CALLBACK_USER_PARAM_KHR")]
    DebugCallbackUserParamkhr = unchecked((uint)0x8245),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_DEBUG_SOURCE_API_KHR")]
    DebugSourceApikhr = unchecked((uint)0x8246),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_DEBUG_SOURCE_WINDOW_SYSTEM_KHR")]
    DebugSourceWindowSystemkhr = unchecked((uint)0x8247),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_DEBUG_SOURCE_SHADER_COMPILER_KHR")]
    DebugSourceShaderCompilerkhr = unchecked((uint)0x8248),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_DEBUG_SOURCE_THIRD_PARTY_KHR")]
    DebugSourceThirdPartykhr = unchecked((uint)0x8249),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_DEBUG_SOURCE_APPLICATION_KHR")]
    DebugSourceApplicationkhr = unchecked((uint)0x824A),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_DEBUG_SOURCE_OTHER_KHR")]
    DebugSourceOtherkhr = unchecked((uint)0x824B),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_DEBUG_TYPE_ERROR_KHR")]
    DebugTypeErrorkhr = unchecked((uint)0x824C),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_KHR")]
    DebugTypeDeprecatedBehaviorkhr = unchecked((uint)0x824D),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_KHR")]
    DebugTypeUndefinedBehaviorkhr = unchecked((uint)0x824E),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_DEBUG_TYPE_PORTABILITY_KHR")]
    DebugTypePortabilitykhr = unchecked((uint)0x824F),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_DEBUG_TYPE_PERFORMANCE_KHR")]
    DebugTypePerformancekhr = unchecked((uint)0x8250),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_DEBUG_TYPE_OTHER_KHR")]
    DebugTypeOtherkhr = unchecked((uint)0x8251),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_DEBUG_TYPE_MARKER_KHR")]
    DebugTypeMarkerkhr = unchecked((uint)0x8268),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_DEBUG_TYPE_PUSH_GROUP_KHR")]
    DebugTypePushGroupkhr = unchecked((uint)0x8269),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_DEBUG_TYPE_POP_GROUP_KHR")]
    DebugTypePopGroupkhr = unchecked((uint)0x826A),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_DEBUG_SEVERITY_NOTIFICATION_KHR")]
    DebugSeverityNotificationkhr = unchecked((uint)0x826B),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_MAX_DEBUG_GROUP_STACK_DEPTH_KHR")]
    MaxDebugGroupStackDepthkhr = unchecked((uint)0x826C),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_DEBUG_GROUP_STACK_DEPTH_KHR")]
    DebugGroupStackDepthkhr = unchecked((uint)0x826D),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_BUFFER_KHR")]
    Bufferkhr = unchecked((uint)0x82E0),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_SHADER_KHR")]
    Shaderkhr = unchecked((uint)0x82E1),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_PROGRAM_KHR")]
    Programkhr = unchecked((uint)0x82E2),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_VERTEX_ARRAY_KHR")]
    VertexArraykhr = unchecked((uint)0x8074),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_QUERY_KHR")]
    Querykhr = unchecked((uint)0x82E3),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_PROGRAM_PIPELINE_KHR")]
    ProgramPipelinekhr = unchecked((uint)0x82E4),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_SAMPLER_KHR")]
    Samplerkhr = unchecked((uint)0x82E6),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_MAX_LABEL_LENGTH_KHR")]
    MaxLabelLengthkhr = unchecked((uint)0x82E8),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_MAX_DEBUG_MESSAGE_LENGTH_KHR")]
    MaxDebugMessageLengthkhr = unchecked((uint)0x9143),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_MAX_DEBUG_LOGGED_MESSAGES_KHR")]
    MaxDebugLoggedMessageskhr = unchecked((uint)0x9144),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_DEBUG_LOGGED_MESSAGES_KHR")]
    DebugLoggedMessageskhr = unchecked((uint)0x9145),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_DEBUG_SEVERITY_HIGH_KHR")]
    DebugSeverityHighkhr = unchecked((uint)0x9146),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_DEBUG_SEVERITY_MEDIUM_KHR")]
    DebugSeverityMediumkhr = unchecked((uint)0x9147),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_DEBUG_SEVERITY_LOW_KHR")]
    DebugSeverityLowkhr = unchecked((uint)0x9148),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_DEBUG_OUTPUT_KHR")]
    DebugOutputkhr = unchecked((uint)0x92E0),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_CONTEXT_FLAG_DEBUG_BIT_KHR")]
    ContextFlagDebugBitkhr = unchecked((uint)0x00000002),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_STACK_OVERFLOW_KHR")]
    StackOverflowkhr = unchecked((uint)0x0503),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_STACK_UNDERFLOW_KHR")]
    StackUnderflowkhr = unchecked((uint)0x0504),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_CONTEXT_ROBUST_ACCESS_KHR")]
    ContextRobustAccesskhr = unchecked((uint)0x90F3),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_LOSE_CONTEXT_ON_RESET_KHR")]
    LoseContextOnResetkhr = unchecked((uint)0x8252),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_GUILTY_CONTEXT_RESET_KHR")]
    GuiltyContextResetkhr = unchecked((uint)0x8253),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_INNOCENT_CONTEXT_RESET_KHR")]
    InnocentContextResetkhr = unchecked((uint)0x8254),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_UNKNOWN_CONTEXT_RESET_KHR")]
    UnknownContextResetkhr = unchecked((uint)0x8255),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_RESET_NOTIFICATION_STRATEGY_KHR")]
    ResetNotificationStrategykhr = unchecked((uint)0x8256),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_NO_RESET_NOTIFICATION_KHR")]
    NoResetNotificationkhr = unchecked((uint)0x8261),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_CONTEXT_LOST_KHR")]
    ContextLostkhr = unchecked((uint)0x0507),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_SAMPLER_EXTERNAL_OES")]
    SamplerExternaloes = unchecked((uint)0x8D66),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_GEOMETRY_SHADER_OES")]
    GeometryShaderoes = unchecked((uint)0x8DD9),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_GEOMETRY_SHADER_BIT_OES")]
    GeometryShaderBitoes = unchecked((uint)0x00000004),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_GEOMETRY_LINKED_VERTICES_OUT_OES")]
    GeometryLinkedVerticesOutoes = unchecked((uint)0x8916),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_GEOMETRY_LINKED_INPUT_TYPE_OES")]
    GeometryLinkedInputTypeoes = unchecked((uint)0x8917),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_GEOMETRY_LINKED_OUTPUT_TYPE_OES")]
    GeometryLinkedOutputTypeoes = unchecked((uint)0x8918),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_GEOMETRY_SHADER_INVOCATIONS_OES")]
    GeometryShaderInvocationsoes = unchecked((uint)0x887F),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_LAYER_PROVOKING_VERTEX_OES")]
    LayerProvokingVertexoes = unchecked((uint)0x825E),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_LINES_ADJACENCY_OES")]
    LinesAdjacencyoes = unchecked((uint)0x000A),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_LINE_STRIP_ADJACENCY_OES")]
    LineStripAdjacencyoes = unchecked((uint)0x000B),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TRIANGLES_ADJACENCY_OES")]
    TrianglesAdjacencyoes = unchecked((uint)0x000C),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TRIANGLE_STRIP_ADJACENCY_OES")]
    TriangleStripAdjacencyoes = unchecked((uint)0x000D),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_OES")]
    MaxGeometryUniformComponentsoes = unchecked((uint)0x8DDF),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_GEOMETRY_UNIFORM_BLOCKS_OES")]
    MaxGeometryUniformBlocksoes = unchecked((uint)0x8A2C),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS_OES")]
    MaxCombinedGeometryUniformComponentsoes = unchecked((uint)0x8A32),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_GEOMETRY_INPUT_COMPONENTS_OES")]
    MaxGeometryInputComponentsoes = unchecked((uint)0x9123),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_GEOMETRY_OUTPUT_COMPONENTS_OES")]
    MaxGeometryOutputComponentsoes = unchecked((uint)0x9124),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_GEOMETRY_OUTPUT_VERTICES_OES")]
    MaxGeometryOutputVerticesoes = unchecked((uint)0x8DE0),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_OES")]
    MaxGeometryTotalOutputComponentsoes = unchecked((uint)0x8DE1),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_GEOMETRY_SHADER_INVOCATIONS_OES")]
    MaxGeometryShaderInvocationsoes = unchecked((uint)0x8E5A),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_OES")]
    MaxGeometryTextureImageUnitsoes = unchecked((uint)0x8C29),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS_OES")]
    MaxGeometryAtomicCounterBuffersoes = unchecked((uint)0x92CF),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_GEOMETRY_ATOMIC_COUNTERS_OES")]
    MaxGeometryAtomicCountersoes = unchecked((uint)0x92D5),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_GEOMETRY_IMAGE_UNIFORMS_OES")]
    MaxGeometryImageUniformsoes = unchecked((uint)0x90CD),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS_OES")]
    MaxGeometryShaderStorageBlocksoes = unchecked((uint)0x90D7),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_FIRST_VERTEX_CONVENTION_OES")]
    FirstVertexConventionoes = unchecked((uint)0x8E4D),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_LAST_VERTEX_CONVENTION_OES")]
    LastVertexConventionoes = unchecked((uint)0x8E4E),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_UNDEFINED_VERTEX_OES")]
    UndefinedVertexoes = unchecked((uint)0x8260),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_PRIMITIVES_GENERATED_OES")]
    PrimitivesGeneratedoes = unchecked((uint)0x8C87),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_FRAMEBUFFER_DEFAULT_LAYERS_OES")]
    FramebufferDefaultLayersoes = unchecked((uint)0x9312),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_FRAMEBUFFER_LAYERS_OES")]
    MaxFramebufferLayersoes = unchecked((uint)0x9317),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_OES")]
    FramebufferIncompleteLayerTargetsoes = unchecked((uint)0x8DA8),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_LAYERED_OES")]
    FramebufferAttachmentLayeredoes = unchecked((uint)0x8DA7),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_REFERENCED_BY_GEOMETRY_SHADER_OES")]
    ReferencedByGeometryShaderoes = unchecked((uint)0x9309),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_PROGRAM_BINARY_LENGTH_OES")]
    ProgramBinaryLengthoes = unchecked((uint)0x8741),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_NUM_PROGRAM_BINARY_FORMATS_OES")]
    NumProgramBinaryFormatsoes = unchecked((uint)0x87FE),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_PROGRAM_BINARY_FORMATS_OES")]
    ProgramBinaryFormatsoes = unchecked((uint)0x87FF),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_PRIMITIVE_BOUNDING_BOX_OES")]
    PrimitiveBoundingBoxoes = unchecked((uint)0x92BE),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_SAMPLE_SHADING_OES")]
    SampleShadingoes = unchecked((uint)0x8C36),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MIN_SAMPLE_SHADING_VALUE_OES")]
    MinSampleShadingValueoes = unchecked((uint)0x8C37),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MIN_FRAGMENT_INTERPOLATION_OFFSET_OES")]
    MinFragmentInterpolationOffsetoes = unchecked((uint)0x8E5B),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_FRAGMENT_INTERPOLATION_OFFSET_OES")]
    MaxFragmentInterpolationOffsetoes = unchecked((uint)0x8E5C),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_FRAGMENT_INTERPOLATION_OFFSET_BITS_OES")]
    FragmentInterpolationOffsetBitsoes = unchecked((uint)0x8E5D),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_FRAGMENT_SHADER_DERIVATIVE_HINT_OES")]
    FragmentShaderDerivativeHintoes = unchecked((uint)0x8B8B),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_PATCHES_OES")]
    Patchesoes = unchecked((uint)0x000E),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_PATCH_VERTICES_OES")]
    PatchVerticesoes = unchecked((uint)0x8E72),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TESS_CONTROL_OUTPUT_VERTICES_OES")]
    TessControlOutputVerticesoes = unchecked((uint)0x8E75),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TESS_GEN_MODE_OES")]
    TessGenModeoes = unchecked((uint)0x8E76),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TESS_GEN_SPACING_OES")]
    TessGenSpacingoes = unchecked((uint)0x8E77),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TESS_GEN_VERTEX_ORDER_OES")]
    TessGenVertexOrderoes = unchecked((uint)0x8E78),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TESS_GEN_POINT_MODE_OES")]
    TessGenPointModeoes = unchecked((uint)0x8E79),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_ISOLINES_OES")]
    Isolinesoes = unchecked((uint)0x8E7A),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_QUADS_OES")]
    Quadsoes = unchecked((uint)0x0007),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_FRACTIONAL_ODD_OES")]
    FractionalOddoes = unchecked((uint)0x8E7B),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_FRACTIONAL_EVEN_OES")]
    FractionalEvenoes = unchecked((uint)0x8E7C),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_PATCH_VERTICES_OES")]
    MaxPatchVerticesoes = unchecked((uint)0x8E7D),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_TESS_GEN_LEVEL_OES")]
    MaxTessGenLeveloes = unchecked((uint)0x8E7E),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS_OES")]
    MaxTessControlUniformComponentsoes = unchecked((uint)0x8E7F),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS_OES")]
    MaxTessEvaluationUniformComponentsoes = unchecked((uint)0x8E80),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS_OES")]
    MaxTessControlTextureImageUnitsoes = unchecked((uint)0x8E81),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS_OES")]
    MaxTessEvaluationTextureImageUnitsoes = unchecked((uint)0x8E82),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS_OES")]
    MaxTessControlOutputComponentsoes = unchecked((uint)0x8E83),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_TESS_PATCH_COMPONENTS_OES")]
    MaxTessPatchComponentsoes = unchecked((uint)0x8E84),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS_OES")]
    MaxTessControlTotalOutputComponentsoes = unchecked((uint)0x8E85),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS_OES")]
    MaxTessEvaluationOutputComponentsoes = unchecked((uint)0x8E86),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS_OES")]
    MaxTessControlUniformBlocksoes = unchecked((uint)0x8E89),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS_OES")]
    MaxTessEvaluationUniformBlocksoes = unchecked((uint)0x8E8A),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_TESS_CONTROL_INPUT_COMPONENTS_OES")]
    MaxTessControlInputComponentsoes = unchecked((uint)0x886C),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS_OES")]
    MaxTessEvaluationInputComponentsoes = unchecked((uint)0x886D),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS_OES")]
    MaxCombinedTessControlUniformComponentsoes = unchecked((uint)0x8E1E),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS_OES")]
    MaxCombinedTessEvaluationUniformComponentsoes = unchecked((uint)0x8E1F),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS_OES")]
    MaxTessControlAtomicCounterBuffersoes = unchecked((uint)0x92CD),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS_OES")]
    MaxTessEvaluationAtomicCounterBuffersoes = unchecked((uint)0x92CE),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS_OES")]
    MaxTessControlAtomicCountersoes = unchecked((uint)0x92D3),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS_OES")]
    MaxTessEvaluationAtomicCountersoes = unchecked((uint)0x92D4),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS_OES")]
    MaxTessControlImageUniformsoes = unchecked((uint)0x90CB),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS_OES")]
    MaxTessEvaluationImageUniformsoes = unchecked((uint)0x90CC),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS_OES")]
    MaxTessControlShaderStorageBlocksoes = unchecked((uint)0x90D8),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS_OES")]
    MaxTessEvaluationShaderStorageBlocksoes = unchecked((uint)0x90D9),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED_OES")]
    PrimitiveRestartForPatchesSupportedoes = unchecked((uint)0x8221),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_IS_PER_PATCH_OES")]
    IsPerPatchoes = unchecked((uint)0x92E7),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_REFERENCED_BY_TESS_CONTROL_SHADER_OES")]
    ReferencedByTessControlShaderoes = unchecked((uint)0x9307),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_REFERENCED_BY_TESS_EVALUATION_SHADER_OES")]
    ReferencedByTessEvaluationShaderoes = unchecked((uint)0x9308),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TESS_CONTROL_SHADER_OES")]
    TessControlShaderoes = unchecked((uint)0x8E88),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TESS_EVALUATION_SHADER_OES")]
    TessEvaluationShaderoes = unchecked((uint)0x8E87),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TESS_CONTROL_SHADER_BIT_OES")]
    TessControlShaderBitoes = unchecked((uint)0x00000008),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TESS_EVALUATION_SHADER_BIT_OES")]
    TessEvaluationShaderBitoes = unchecked((uint)0x00000010),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_WRAP_R_OES")]
    TextureWrapRoes = unchecked((uint)0x8072),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_3D_OES")]
    Texture3Does = unchecked((uint)0x806F),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_BINDING_3D_OES")]
    TextureBinding3Does = unchecked((uint)0x806A),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_3D_TEXTURE_SIZE_OES")]
    Max3DTextureSizeoes = unchecked((uint)0x8073),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_SAMPLER_3D_OES")]
    Sampler3Does = unchecked((uint)0x8B5F),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_OES")]
    FramebufferAttachmentTexture3DZoffsetoes = unchecked((uint)0x8CD4),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_BORDER_COLOR_OES")]
    TextureBorderColoroes = unchecked((uint)0x1004),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_CLAMP_TO_BORDER_OES")]
    ClampToBorderoes = unchecked((uint)0x812D),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_BUFFER_OES")]
    TextureBufferoes = unchecked((uint)0x8C2A),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_BUFFER_BINDING_OES")]
    TextureBufferBindingoes = unchecked((uint)0x8C2A),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_TEXTURE_BUFFER_SIZE_OES")]
    MaxTextureBufferSizeoes = unchecked((uint)0x8C2B),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_BINDING_BUFFER_OES")]
    TextureBindingBufferoes = unchecked((uint)0x8C2C),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_BUFFER_DATA_STORE_BINDING_OES")]
    TextureBufferDataStoreBindingoes = unchecked((uint)0x8C2D),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT_OES")]
    TextureBufferOffsetAlignmentoes = unchecked((uint)0x919F),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_SAMPLER_BUFFER_OES")]
    SamplerBufferoes = unchecked((uint)0x8DC2),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_INT_SAMPLER_BUFFER_OES")]
    IntSamplerBufferoes = unchecked((uint)0x8DD0),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_UNSIGNED_INT_SAMPLER_BUFFER_OES")]
    UnsignedIntSamplerBufferoes = unchecked((uint)0x8DD8),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_IMAGE_BUFFER_OES")]
    ImageBufferoes = unchecked((uint)0x9051),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_INT_IMAGE_BUFFER_OES")]
    IntImageBufferoes = unchecked((uint)0x905C),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_UNSIGNED_INT_IMAGE_BUFFER_OES")]
    UnsignedIntImageBufferoes = unchecked((uint)0x9067),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_BUFFER_OFFSET_OES")]
    TextureBufferOffsetoes = unchecked((uint)0x919D),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_BUFFER_SIZE_OES")]
    TextureBufferSizeoes = unchecked((uint)0x919E),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_COMPRESSED_RGBA_ASTC_3x3x3_OES")]
    CompressedRgbaAstc3X3X3Oes = unchecked((uint)0x93C0),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_COMPRESSED_RGBA_ASTC_4x3x3_OES")]
    CompressedRgbaAstc4X3X3Oes = unchecked((uint)0x93C1),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_COMPRESSED_RGBA_ASTC_4x4x3_OES")]
    CompressedRgbaAstc4X4X3Oes = unchecked((uint)0x93C2),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_COMPRESSED_RGBA_ASTC_4x4x4_OES")]
    CompressedRgbaAstc4X4X4Oes = unchecked((uint)0x93C3),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_COMPRESSED_RGBA_ASTC_5x4x4_OES")]
    CompressedRgbaAstc5X4X4Oes = unchecked((uint)0x93C4),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_COMPRESSED_RGBA_ASTC_5x5x4_OES")]
    CompressedRgbaAstc5X5X4Oes = unchecked((uint)0x93C5),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_COMPRESSED_RGBA_ASTC_5x5x5_OES")]
    CompressedRgbaAstc5X5X5Oes = unchecked((uint)0x93C6),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_COMPRESSED_RGBA_ASTC_6x5x5_OES")]
    CompressedRgbaAstc6X5X5Oes = unchecked((uint)0x93C7),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_COMPRESSED_RGBA_ASTC_6x6x5_OES")]
    CompressedRgbaAstc6X6X5Oes = unchecked((uint)0x93C8),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_COMPRESSED_RGBA_ASTC_6x6x6_OES")]
    CompressedRgbaAstc6X6X6Oes = unchecked((uint)0x93C9),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_3x3x3_OES")]
    CompressedSrgb8Alpha8Astc3X3X3Oes = unchecked((uint)0x93E0),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x3x3_OES")]
    CompressedSrgb8Alpha8Astc4X3X3Oes = unchecked((uint)0x93E1),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x3_OES")]
    CompressedSrgb8Alpha8Astc4X4X3Oes = unchecked((uint)0x93E2),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x4_OES")]
    CompressedSrgb8Alpha8Astc4X4X4Oes = unchecked((uint)0x93E3),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4x4_OES")]
    CompressedSrgb8Alpha8Astc5X4X4Oes = unchecked((uint)0x93E4),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x4_OES")]
    CompressedSrgb8Alpha8Astc5X5X4Oes = unchecked((uint)0x93E5),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x5_OES")]
    CompressedSrgb8Alpha8Astc5X5X5Oes = unchecked((uint)0x93E6),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5x5_OES")]
    CompressedSrgb8Alpha8Astc6X5X5Oes = unchecked((uint)0x93E7),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x5_OES")]
    CompressedSrgb8Alpha8Astc6X6X5Oes = unchecked((uint)0x93E8),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x6_OES")]
    CompressedSrgb8Alpha8Astc6X6X6Oes = unchecked((uint)0x93E9),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_ARRAY_OES")]
    TextureCubeMapArrayoes = unchecked((uint)0x9009),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_BINDING_CUBE_MAP_ARRAY_OES")]
    TextureBindingCubeMapArrayoes = unchecked((uint)0x900A),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_SAMPLER_CUBE_MAP_ARRAY_OES")]
    SamplerCubeMapArrayoes = unchecked((uint)0x900C),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW_OES")]
    SamplerCubeMapArrayShadowoes = unchecked((uint)0x900D),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_INT_SAMPLER_CUBE_MAP_ARRAY_OES")]
    IntSamplerCubeMapArrayoes = unchecked((uint)0x900E),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_OES")]
    UnsignedIntSamplerCubeMapArrayoes = unchecked((uint)0x900F),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_IMAGE_CUBE_MAP_ARRAY_OES")]
    ImageCubeMapArrayoes = unchecked((uint)0x9054),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_INT_IMAGE_CUBE_MAP_ARRAY_OES")]
    IntImageCubeMapArrayoes = unchecked((uint)0x905F),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_OES")]
    UnsignedIntImageCubeMapArrayoes = unchecked((uint)0x906A),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_HALF_FLOAT_OES")]
    HalfFloatoes = unchecked((uint)0x8D61),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_STENCIL_INDEX_OES")]
    StencilIndexoes = unchecked((uint)0x1901),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_2D_MULTISAMPLE_ARRAY_OES")]
    Texture2DMultisampleArrayoes = unchecked((uint)0x9102),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY_OES")]
    TextureBinding2DMultisampleArrayoes = unchecked((uint)0x9105),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_SAMPLER_2D_MULTISAMPLE_ARRAY_OES")]
    Sampler2DMultisampleArrayoes = unchecked((uint)0x910B),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY_OES")]
    IntSampler2DMultisampleArrayoes = unchecked((uint)0x910C),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY_OES")]
    UnsignedIntSampler2DMultisampleArrayoes = unchecked((uint)0x910D),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_VIEW_MIN_LEVEL_OES")]
    TextureViewMinLeveloes = unchecked((uint)0x82DB),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_VIEW_NUM_LEVELS_OES")]
    TextureViewNumLevelsoes = unchecked((uint)0x82DC),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_VIEW_MIN_LAYER_OES")]
    TextureViewMinLayeroes = unchecked((uint)0x82DD),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_VIEW_NUM_LAYERS_OES")]
    TextureViewNumLayersoes = unchecked((uint)0x82DE),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_UNSIGNED_INT_10_10_10_2_OES")]
    UnsignedInt10X10X10X2Oes = unchecked((uint)0x8DF6),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_INT_10_10_10_2_OES")]
    Int10X10X10X2Oes = unchecked((uint)0x8DF7),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_MAX_VIEWPORTS_OES")]
    MaxViewportsoes = unchecked((uint)0x825B),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_VIEWPORT_SUBPIXEL_BITS_OES")]
    ViewportSubpixelBitsoes = unchecked((uint)0x825C),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_VIEWPORT_BOUNDS_RANGE_OES")]
    ViewportBoundsRangeoes = unchecked((uint)0x825D),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_VIEWPORT_INDEX_PROVOKING_VERTEX_OES")]
    ViewportIndexProvokingVertexoes = unchecked((uint)0x825F),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_Z400_BINARY_AMD")]
    Z400Binaryamd = unchecked((uint)0x8740),

    [NameAffix("Suffix", "ANGLE", 0)]
    [NativeName("GL_READ_FRAMEBUFFER_ANGLE")]
    ReadFramebufferangle = unchecked((uint)0x8CA8),

    [NameAffix("Suffix", "ANGLE", 0)]
    [NativeName("GL_DRAW_FRAMEBUFFER_ANGLE")]
    DrawFramebufferangle = unchecked((uint)0x8CA9),

    [NameAffix("Suffix", "ANGLE", 0)]
    [NativeName("GL_DRAW_FRAMEBUFFER_BINDING_ANGLE")]
    DrawFramebufferBindingangle = unchecked((uint)0x8CA6),

    [NameAffix("Suffix", "ANGLE", 0)]
    [NativeName("GL_READ_FRAMEBUFFER_BINDING_ANGLE")]
    ReadFramebufferBindingangle = unchecked((uint)0x8CAA),

    [NameAffix("Suffix", "ANGLE", 0)]
    [NativeName("GL_RENDERBUFFER_SAMPLES_ANGLE")]
    RenderbufferSamplesangle = unchecked((uint)0x8CAB),

    [NameAffix("Suffix", "ANGLE", 0)]
    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_ANGLE")]
    FramebufferIncompleteMultisampleangle = unchecked((uint)0x8D56),

    [NameAffix("Suffix", "ANGLE", 0)]
    [NativeName("GL_MAX_SAMPLES_ANGLE")]
    MaxSamplesangle = unchecked((uint)0x8D57),

    [NameAffix("Suffix", "ANGLE", 0)]
    [NativeName("GL_VERTEX_ATTRIB_ARRAY_DIVISOR_ANGLE")]
    VertexAttribArrayDivisorangle = unchecked((uint)0x88FE),

    [NameAffix("Suffix", "ANGLE", 0)]
    [NativeName("GL_PACK_REVERSE_ROW_ORDER_ANGLE")]
    PackReverseRowOrderangle = unchecked((uint)0x93A4),

    [NameAffix("Suffix", "ANGLE", 0)]
    [NativeName("GL_PROGRAM_BINARY_ANGLE")]
    ProgramBinaryangle = unchecked((uint)0x93A6),

    [NameAffix("Suffix", "ANGLE", 0)]
    [NativeName("GL_COMPRESSED_RGBA_S3TC_DXT3_ANGLE")]
    CompressedRgbaS3TcDxt3Angle = unchecked((uint)0x83F2),

    [NameAffix("Suffix", "ANGLE", 0)]
    [NativeName("GL_COMPRESSED_RGBA_S3TC_DXT5_ANGLE")]
    CompressedRgbaS3TcDxt5Angle = unchecked((uint)0x83F3),

    [NameAffix("Suffix", "ANGLE", 0)]
    [NativeName("GL_TEXTURE_USAGE_ANGLE")]
    TextureUsageangle = unchecked((uint)0x93A2),

    [NameAffix("Suffix", "ANGLE", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_ANGLE")]
    FramebufferAttachmentangle = unchecked((uint)0x93A3),

    [NameAffix("Suffix", "ANGLE", 0)]
    [NativeName("GL_TRANSLATED_SHADER_SOURCE_LENGTH_ANGLE")]
    TranslatedShaderSourceLengthangle = unchecked((uint)0x93A0),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_MAX_CLIP_DISTANCES_APPLE")]
    MaxClipDistancesapple = unchecked((uint)0x0D32),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_CLIP_DISTANCE0_APPLE")]
    ClipDistance0Apple = unchecked((uint)0x3000),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_CLIP_DISTANCE1_APPLE")]
    ClipDistance1Apple = unchecked((uint)0x3001),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_CLIP_DISTANCE2_APPLE")]
    ClipDistance2Apple = unchecked((uint)0x3002),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_CLIP_DISTANCE3_APPLE")]
    ClipDistance3Apple = unchecked((uint)0x3003),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_CLIP_DISTANCE4_APPLE")]
    ClipDistance4Apple = unchecked((uint)0x3004),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_CLIP_DISTANCE5_APPLE")]
    ClipDistance5Apple = unchecked((uint)0x3005),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_CLIP_DISTANCE6_APPLE")]
    ClipDistance6Apple = unchecked((uint)0x3006),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_CLIP_DISTANCE7_APPLE")]
    ClipDistance7Apple = unchecked((uint)0x3007),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_UNSIGNED_INT_10F_11F_11F_REV_APPLE")]
    UnsignedInt10F11F11FRevapple = unchecked((uint)0x8C3B),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_UNSIGNED_INT_5_9_9_9_REV_APPLE")]
    UnsignedInt5X9X9X9Revapple = unchecked((uint)0x8C3E),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_R11F_G11F_B10F_APPLE")]
    R11FG11FB10Fapple = unchecked((uint)0x8C3A),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_RGB9_E5_APPLE")]
    Rgb9E5Apple = unchecked((uint)0x8C3D),

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("GL_MALI_PROGRAM_BINARY_ARM")]
    MaliProgramBinaryarm = unchecked((uint)0x8F61),

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("GL_MALI_SHADER_BINARY_ARM")]
    MaliShaderBinaryarm = unchecked((uint)0x8F60),

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("GL_FETCH_PER_SAMPLE_ARM")]
    FetchPerSamplearm = unchecked((uint)0x8F65),

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("GL_FRAGMENT_SHADER_FRAMEBUFFER_FETCH_MRT_ARM")]
    FragmentShaderFramebufferFetchMrtarm = unchecked((uint)0x8F66),

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("GL_TEXTURE_UNNORMALIZED_COORDINATES_ARM")]
    TextureUnnormalizedCoordinatesarm = unchecked((uint)0x8F6A),

    [NameAffix("Suffix", "DMP", 0)]
    [NativeName("GL_SMAPHS30_PROGRAM_BINARY_DMP")]
    Smaphs30ProgramBinarydmp = unchecked((uint)0x9251),

    [NameAffix("Suffix", "DMP", 0)]
    [NativeName("GL_SMAPHS_PROGRAM_BINARY_DMP")]
    SmaphsProgramBinarydmp = unchecked((uint)0x9252),

    [NameAffix("Suffix", "DMP", 0)]
    [NativeName("GL_DMP_PROGRAM_BINARY_DMP")]
    DmpProgramBinarydmp = unchecked((uint)0x9253),

    [NameAffix("Suffix", "DMP", 0)]
    [NativeName("GL_SHADER_BINARY_DMP")]
    ShaderBinarydmp = unchecked((uint)0x9250),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SURFACE_COMPRESSION_EXT")]
    SurfaceCompressionext = unchecked((uint)0x96C0),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_NONE_EXT")]
    SurfaceCompressionFixedRateNoneext = unchecked((uint)0x96C1),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_DEFAULT_EXT")]
    SurfaceCompressionFixedRateDefaultext = unchecked((uint)0x96C2),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SAMPLER_EXTERNAL_2D_Y2Y_EXT")]
    SamplerExternal2DY2Yext = unchecked((uint)0x8BE7),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SRC1_COLOR_EXT")]
    Src1Colorext = unchecked((uint)0x88F9),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SRC1_ALPHA_EXT")]
    Src1Alphaext = unchecked((uint)0x8589),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ONE_MINUS_SRC1_COLOR_EXT")]
    OneMinusSrc1Colorext = unchecked((uint)0x88FA),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ONE_MINUS_SRC1_ALPHA_EXT")]
    OneMinusSrc1Alphaext = unchecked((uint)0x88FB),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SRC_ALPHA_SATURATE_EXT")]
    SrcAlphaSaturateext = unchecked((uint)0x0308),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LOCATION_INDEX_EXT")]
    LocationIndexext = unchecked((uint)0x930F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_DUAL_SOURCE_DRAW_BUFFERS_EXT")]
    MaxDualSourceDrawBuffersext = unchecked((uint)0x88FC),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAP_PERSISTENT_BIT_EXT")]
    MapPersistentBitext = unchecked((uint)0x0040),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAP_COHERENT_BIT_EXT")]
    MapCoherentBitext = unchecked((uint)0x0080),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DYNAMIC_STORAGE_BIT_EXT")]
    DynamicStorageBitext = unchecked((uint)0x0100),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CLIENT_STORAGE_BIT_EXT")]
    ClientStorageBitext = unchecked((uint)0x0200),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT_EXT")]
    ClientMappedBufferBarrierBitext = unchecked((uint)0x00004000),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_BUFFER_IMMUTABLE_STORAGE_EXT")]
    BufferImmutableStorageext = unchecked((uint)0x821F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_BUFFER_STORAGE_FLAGS_EXT")]
    BufferStorageFlagsext = unchecked((uint)0x8220),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LOWER_LEFT_EXT")]
    LowerLeftext = unchecked((uint)0x8CA1),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UPPER_LEFT_EXT")]
    UpperLeftext = unchecked((uint)0x8CA2),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_NEGATIVE_ONE_TO_ONE_EXT")]
    NegativeOneToOneext = unchecked((uint)0x935E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ZERO_TO_ONE_EXT")]
    ZeroToOneext = unchecked((uint)0x935F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CLIP_ORIGIN_EXT")]
    ClipOriginext = unchecked((uint)0x935C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CLIP_DEPTH_MODE_EXT")]
    ClipDepthModeext = unchecked((uint)0x935D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_CLIP_DISTANCES_EXT")]
    MaxClipDistancesext = unchecked((uint)0x0D32),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_CULL_DISTANCES_EXT")]
    MaxCullDistancesext = unchecked((uint)0x82F9),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_COMBINED_CLIP_AND_CULL_DISTANCES_EXT")]
    MaxCombinedClipAndCullDistancesext = unchecked((uint)0x82FA),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CLIP_DISTANCE0_EXT")]
    ClipDistance0Ext = unchecked((uint)0x3000),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CLIP_DISTANCE1_EXT")]
    ClipDistance1Ext = unchecked((uint)0x3001),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CLIP_DISTANCE2_EXT")]
    ClipDistance2Ext = unchecked((uint)0x3002),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CLIP_DISTANCE3_EXT")]
    ClipDistance3Ext = unchecked((uint)0x3003),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CLIP_DISTANCE4_EXT")]
    ClipDistance4Ext = unchecked((uint)0x3004),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CLIP_DISTANCE5_EXT")]
    ClipDistance5Ext = unchecked((uint)0x3005),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CLIP_DISTANCE6_EXT")]
    ClipDistance6Ext = unchecked((uint)0x3006),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CLIP_DISTANCE7_EXT")]
    ClipDistance7Ext = unchecked((uint)0x3007),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE_EXT")]
    FramebufferAttachmentComponentTypeext = unchecked((uint)0x8211),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_NORMALIZED_EXT")]
    UnsignedNormalizedext = unchecked((uint)0x8C17),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DEPTH_CLAMP_EXT")]
    DepthClampext = unchecked((uint)0x864F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_QUERY_COUNTER_BITS_EXT")]
    QueryCounterBitsext = unchecked((uint)0x8864),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CURRENT_QUERY_EXT")]
    CurrentQueryext = unchecked((uint)0x8865),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_QUERY_RESULT_EXT")]
    QueryResultext = unchecked((uint)0x8866),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_QUERY_RESULT_AVAILABLE_EXT")]
    QueryResultAvailableext = unchecked((uint)0x8867),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TIMESTAMP_EXT")]
    Timestampext = unchecked((uint)0x8E28),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_GPU_DISJOINT_EXT")]
    GpuDisjointext = unchecked((uint)0x8FBB),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_DRAW_BUFFERS_EXT")]
    MaxDrawBuffersext = unchecked((uint)0x8824),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DRAW_BUFFER0_EXT")]
    DrawBuffer0Ext = unchecked((uint)0x8825),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DRAW_BUFFER1_EXT")]
    DrawBuffer1Ext = unchecked((uint)0x8826),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DRAW_BUFFER2_EXT")]
    DrawBuffer2Ext = unchecked((uint)0x8827),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DRAW_BUFFER3_EXT")]
    DrawBuffer3Ext = unchecked((uint)0x8828),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DRAW_BUFFER4_EXT")]
    DrawBuffer4Ext = unchecked((uint)0x8829),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DRAW_BUFFER5_EXT")]
    DrawBuffer5Ext = unchecked((uint)0x882A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DRAW_BUFFER6_EXT")]
    DrawBuffer6Ext = unchecked((uint)0x882B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DRAW_BUFFER7_EXT")]
    DrawBuffer7Ext = unchecked((uint)0x882C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DRAW_BUFFER8_EXT")]
    DrawBuffer8Ext = unchecked((uint)0x882D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DRAW_BUFFER9_EXT")]
    DrawBuffer9Ext = unchecked((uint)0x882E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DRAW_BUFFER10_EXT")]
    DrawBuffer10Ext = unchecked((uint)0x882F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DRAW_BUFFER11_EXT")]
    DrawBuffer11Ext = unchecked((uint)0x8830),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DRAW_BUFFER12_EXT")]
    DrawBuffer12Ext = unchecked((uint)0x8831),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DRAW_BUFFER13_EXT")]
    DrawBuffer13Ext = unchecked((uint)0x8832),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DRAW_BUFFER14_EXT")]
    DrawBuffer14Ext = unchecked((uint)0x8833),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DRAW_BUFFER15_EXT")]
    DrawBuffer15Ext = unchecked((uint)0x8834),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SHADING_RATE_1X1_PIXELS_EXT")]
    ShadingRate1X1Pixelsext = unchecked((uint)0x96A6),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SHADING_RATE_1X2_PIXELS_EXT")]
    ShadingRate1X2Pixelsext = unchecked((uint)0x96A7),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SHADING_RATE_2X1_PIXELS_EXT")]
    ShadingRate2X1Pixelsext = unchecked((uint)0x96A8),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SHADING_RATE_2X2_PIXELS_EXT")]
    ShadingRate2X2Pixelsext = unchecked((uint)0x96A9),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SHADING_RATE_1X4_PIXELS_EXT")]
    ShadingRate1X4Pixelsext = unchecked((uint)0x96AA),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SHADING_RATE_4X1_PIXELS_EXT")]
    ShadingRate4X1Pixelsext = unchecked((uint)0x96AB),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SHADING_RATE_4X2_PIXELS_EXT")]
    ShadingRate4X2Pixelsext = unchecked((uint)0x96AC),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SHADING_RATE_2X4_PIXELS_EXT")]
    ShadingRate2X4Pixelsext = unchecked((uint)0x96AD),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SHADING_RATE_4X4_PIXELS_EXT")]
    ShadingRate4X4Pixelsext = unchecked((uint)0x96AE),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SHADING_RATE_EXT")]
    ShadingRateext = unchecked((uint)0x96D0),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SHADING_RATE_ATTACHMENT_EXT")]
    ShadingRateAttachmentext = unchecked((uint)0x96D1),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAGMENT_SHADING_RATE_COMBINER_OP_KEEP_EXT")]
    FragmentShadingRateCombinerOpKeepext = unchecked((uint)0x96D2),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAGMENT_SHADING_RATE_COMBINER_OP_REPLACE_EXT")]
    FragmentShadingRateCombinerOpReplaceext = unchecked((uint)0x96D3),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAGMENT_SHADING_RATE_COMBINER_OP_MIN_EXT")]
    FragmentShadingRateCombinerOpMinext = unchecked((uint)0x96D4),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAGMENT_SHADING_RATE_COMBINER_OP_MAX_EXT")]
    FragmentShadingRateCombinerOpMaxext = unchecked((uint)0x96D5),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAGMENT_SHADING_RATE_COMBINER_OP_MUL_EXT")]
    FragmentShadingRateCombinerOpMulext = unchecked((uint)0x96D6),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MIN_FRAGMENT_SHADING_RATE_ATTACHMENT_TEXEL_WIDTH_EXT")]
    MinFragmentShadingRateAttachmentTexelWidthext = unchecked((uint)0x96D7),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_FRAGMENT_SHADING_RATE_ATTACHMENT_TEXEL_WIDTH_EXT")]
    MaxFragmentShadingRateAttachmentTexelWidthext = unchecked((uint)0x96D8),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MIN_FRAGMENT_SHADING_RATE_ATTACHMENT_TEXEL_HEIGHT_EXT")]
    MinFragmentShadingRateAttachmentTexelHeightext = unchecked((uint)0x96D9),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_FRAGMENT_SHADING_RATE_ATTACHMENT_TEXEL_HEIGHT_EXT")]
    MaxFragmentShadingRateAttachmentTexelHeightext = unchecked((uint)0x96DA),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_FRAGMENT_SHADING_RATE_ATTACHMENT_TEXEL_ASPECT_RATIO_EXT")]
    MaxFragmentShadingRateAttachmentTexelAspectRatioext = unchecked((uint)0x96DB),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_FRAGMENT_SHADING_RATE_ATTACHMENT_LAYERS_EXT")]
    MaxFragmentShadingRateAttachmentLayersext = unchecked((uint)0x96DC),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAGMENT_SHADING_RATE_WITH_SHADER_DEPTH_STENCIL_WRITES_SUPPORTED_EXT")]
    FragmentShadingRateWithShaderDepthStencilWritesSupportedext = unchecked((uint)0x96DD),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAGMENT_SHADING_RATE_WITH_SAMPLE_MASK_SUPPORTED_EXT")]
    FragmentShadingRateWithSampleMaskSupportedext = unchecked((uint)0x96DE),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAGMENT_SHADING_RATE_ATTACHMENT_WITH_DEFAULT_FRAMEBUFFER_SUPPORTED_EXT")]
    FragmentShadingRateAttachmentWithDefaultFramebufferSupportedext = unchecked((uint)0x96DF),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAGMENT_SHADING_RATE_NON_TRIVIAL_COMBINERS_SUPPORTED_EXT")]
    FragmentShadingRateNonTrivialCombinersSupportedext = unchecked((uint)0x8F6F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_GEOMETRY_SHADER_BIT_EXT")]
    GeometryShaderBitext = unchecked((uint)0x00000004),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_GEOMETRY_LINKED_VERTICES_OUT_EXT")]
    GeometryLinkedVerticesOutext = unchecked((uint)0x8916),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_GEOMETRY_LINKED_INPUT_TYPE_EXT")]
    GeometryLinkedInputTypeext = unchecked((uint)0x8917),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_GEOMETRY_LINKED_OUTPUT_TYPE_EXT")]
    GeometryLinkedOutputTypeext = unchecked((uint)0x8918),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_GEOMETRY_SHADER_INVOCATIONS_EXT")]
    GeometryShaderInvocationsext = unchecked((uint)0x887F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LAYER_PROVOKING_VERTEX_EXT")]
    LayerProvokingVertexext = unchecked((uint)0x825E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_GEOMETRY_UNIFORM_BLOCKS_EXT")]
    MaxGeometryUniformBlocksext = unchecked((uint)0x8A2C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS_EXT")]
    MaxCombinedGeometryUniformComponentsext = unchecked((uint)0x8A32),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_GEOMETRY_INPUT_COMPONENTS_EXT")]
    MaxGeometryInputComponentsext = unchecked((uint)0x9123),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_GEOMETRY_OUTPUT_COMPONENTS_EXT")]
    MaxGeometryOutputComponentsext = unchecked((uint)0x9124),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_GEOMETRY_SHADER_INVOCATIONS_EXT")]
    MaxGeometryShaderInvocationsext = unchecked((uint)0x8E5A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS_EXT")]
    MaxGeometryAtomicCounterBuffersext = unchecked((uint)0x92CF),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_GEOMETRY_ATOMIC_COUNTERS_EXT")]
    MaxGeometryAtomicCountersext = unchecked((uint)0x92D5),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_GEOMETRY_IMAGE_UNIFORMS_EXT")]
    MaxGeometryImageUniformsext = unchecked((uint)0x90CD),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS_EXT")]
    MaxGeometryShaderStorageBlocksext = unchecked((uint)0x90D7),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNDEFINED_VERTEX_EXT")]
    UndefinedVertexext = unchecked((uint)0x8260),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_DEFAULT_LAYERS_EXT")]
    FramebufferDefaultLayersext = unchecked((uint)0x9312),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_FRAMEBUFFER_LAYERS_EXT")]
    MaxFramebufferLayersext = unchecked((uint)0x9317),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_REFERENCED_BY_GEOMETRY_SHADER_EXT")]
    ReferencedByGeometryShaderext = unchecked((uint)0x9309),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VERTEX_ATTRIB_ARRAY_DIVISOR_EXT")]
    VertexAttribArrayDivisorext = unchecked((uint)0x88FE),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ATTACHMENT_EXT")]
    ColorAttachmentext = unchecked((uint)0x90F0),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MULTIVIEW_EXT")]
    Multiviewext = unchecked((uint)0x90F1),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DRAW_BUFFER_EXT")]
    DrawBufferext = unchecked((uint)0x0C01),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_READ_BUFFER_EXT")]
    ReadBufferext = unchecked((uint)0x0C02),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_MULTIVIEW_BUFFERS_EXT")]
    MaxMultiviewBuffersext = unchecked((uint)0x90F2),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ANY_SAMPLES_PASSED_EXT")]
    AnySamplesPassedext = unchecked((uint)0x8C2F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ANY_SAMPLES_PASSED_CONSERVATIVE_EXT")]
    AnySamplesPassedConservativeext = unchecked((uint)0x8D6A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PRIMITIVE_BOUNDING_BOX_EXT")]
    PrimitiveBoundingBoxext = unchecked((uint)0x92BE),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CONTEXT_FLAG_PROTECTED_CONTENT_BIT_EXT")]
    ContextFlagProtectedContentBitext = unchecked((uint)0x00000010),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_PROTECTED_EXT")]
    TextureProtectedext = unchecked((uint)0x8BFA),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMPRESSED_SRGB_PVRTC_2BPPV1_EXT")]
    CompressedSrgbPvrtc2Bppv1Ext = unchecked((uint)0x8A54),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMPRESSED_SRGB_PVRTC_4BPPV1_EXT")]
    CompressedSrgbPvrtc4Bppv1Ext = unchecked((uint)0x8A55),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMPRESSED_SRGB_ALPHA_PVRTC_2BPPV1_EXT")]
    CompressedSrgbAlphaPvrtc2Bppv1Ext = unchecked((uint)0x8A56),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMPRESSED_SRGB_ALPHA_PVRTC_4BPPV1_EXT")]
    CompressedSrgbAlphaPvrtc4Bppv1Ext = unchecked((uint)0x8A57),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_COMPRESSED_SRGB_ALPHA_PVRTC_2BPPV2_IMG")]
    CompressedSrgbAlphaPvrtc2Bppv2Img = unchecked((uint)0x93F0),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_COMPRESSED_SRGB_ALPHA_PVRTC_4BPPV2_IMG")]
    CompressedSrgbAlphaPvrtc4Bppv2Img = unchecked((uint)0x93F1),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_R16_SNORM_EXT")]
    R16Snormext = unchecked((uint)0x8F98),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RG16_SNORM_EXT")]
    Rg16Snormext = unchecked((uint)0x8F99),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGBA16_SNORM_EXT")]
    Rgba16Snormext = unchecked((uint)0x8F9B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VERTEX_SHADER_BIT_EXT")]
    VertexShaderBitext = unchecked((uint)0x00000001),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAGMENT_SHADER_BIT_EXT")]
    FragmentShaderBitext = unchecked((uint)0x00000002),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ALL_SHADER_BITS_EXT")]
    AllShaderBitsext = unchecked((uint)0xFFFFFFFF),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PROGRAM_SEPARABLE_EXT")]
    ProgramSeparableext = unchecked((uint)0x8258),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PROGRAM_PIPELINE_BINDING_EXT")]
    ProgramPipelineBindingext = unchecked((uint)0x825A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_SHADER_PIXEL_LOCAL_STORAGE_FAST_SIZE_EXT")]
    MaxShaderPixelLocalStorageFastSizeext = unchecked((uint)0x8F63),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_SHADER_PIXEL_LOCAL_STORAGE_SIZE_EXT")]
    MaxShaderPixelLocalStorageSizeext = unchecked((uint)0x8F67),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SHADER_PIXEL_LOCAL_STORAGE_EXT")]
    ShaderPixelLocalStorageext = unchecked((uint)0x8F64),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_SHADER_COMBINED_LOCAL_STORAGE_FAST_SIZE_EXT")]
    MaxShaderCombinedLocalStorageFastSizeext = unchecked((uint)0x9650),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_SHADER_COMBINED_LOCAL_STORAGE_SIZE_EXT")]
    MaxShaderCombinedLocalStorageSizeext = unchecked((uint)0x9651),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_INSUFFICIENT_SHADER_COMBINED_LOCAL_STORAGE_EXT")]
    FramebufferIncompleteInsufficientShaderCombinedLocalStorageext = unchecked((uint)0x9652),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_COMPARE_MODE_EXT")]
    TextureCompareModeext = unchecked((uint)0x884C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_COMPARE_FUNC_EXT")]
    TextureCompareFuncext = unchecked((uint)0x884D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMPARE_REF_TO_TEXTURE_EXT")]
    CompareRefToTextureext = unchecked((uint)0x884E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SAMPLER_2D_SHADOW_EXT")]
    Sampler2DShadowext = unchecked((uint)0x8B62),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_SPARSE_EXT")]
    TextureSparseext = unchecked((uint)0x91A6),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VIRTUAL_PAGE_SIZE_INDEX_EXT")]
    VirtualPageSizeIndexext = unchecked((uint)0x91A7),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_NUM_SPARSE_LEVELS_EXT")]
    NumSparseLevelsext = unchecked((uint)0x91AA),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_NUM_VIRTUAL_PAGE_SIZES_EXT")]
    NumVirtualPageSizesext = unchecked((uint)0x91A8),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VIRTUAL_PAGE_SIZE_X_EXT")]
    VirtualPageSizeXext = unchecked((uint)0x9195),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VIRTUAL_PAGE_SIZE_Y_EXT")]
    VirtualPageSizeYext = unchecked((uint)0x9196),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VIRTUAL_PAGE_SIZE_Z_EXT")]
    VirtualPageSizeZext = unchecked((uint)0x9197),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_SPARSE_TEXTURE_SIZE_EXT")]
    MaxSparseTextureSizeext = unchecked((uint)0x9198),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_SPARSE_3D_TEXTURE_SIZE_EXT")]
    MaxSparse3DTextureSizeext = unchecked((uint)0x9199),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS_EXT")]
    MaxSparseArrayTextureLayersext = unchecked((uint)0x919A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SPARSE_TEXTURE_FULL_ARRAY_CUBE_MIPMAPS_EXT")]
    SparseTextureFullArrayCubeMipmapsext = unchecked((uint)0x91A9),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PATCHES_EXT")]
    Patchesext = unchecked((uint)0x000E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PATCH_VERTICES_EXT")]
    PatchVerticesext = unchecked((uint)0x8E72),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TESS_CONTROL_OUTPUT_VERTICES_EXT")]
    TessControlOutputVerticesext = unchecked((uint)0x8E75),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TESS_GEN_MODE_EXT")]
    TessGenModeext = unchecked((uint)0x8E76),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TESS_GEN_SPACING_EXT")]
    TessGenSpacingext = unchecked((uint)0x8E77),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TESS_GEN_VERTEX_ORDER_EXT")]
    TessGenVertexOrderext = unchecked((uint)0x8E78),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TESS_GEN_POINT_MODE_EXT")]
    TessGenPointModeext = unchecked((uint)0x8E79),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ISOLINES_EXT")]
    Isolinesext = unchecked((uint)0x8E7A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_QUADS_EXT")]
    Quadsext = unchecked((uint)0x0007),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRACTIONAL_ODD_EXT")]
    FractionalOddext = unchecked((uint)0x8E7B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRACTIONAL_EVEN_EXT")]
    FractionalEvenext = unchecked((uint)0x8E7C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_PATCH_VERTICES_EXT")]
    MaxPatchVerticesext = unchecked((uint)0x8E7D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_TESS_GEN_LEVEL_EXT")]
    MaxTessGenLevelext = unchecked((uint)0x8E7E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS_EXT")]
    MaxTessControlUniformComponentsext = unchecked((uint)0x8E7F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS_EXT")]
    MaxTessEvaluationUniformComponentsext = unchecked((uint)0x8E80),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS_EXT")]
    MaxTessControlTextureImageUnitsext = unchecked((uint)0x8E81),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS_EXT")]
    MaxTessEvaluationTextureImageUnitsext = unchecked((uint)0x8E82),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS_EXT")]
    MaxTessControlOutputComponentsext = unchecked((uint)0x8E83),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_TESS_PATCH_COMPONENTS_EXT")]
    MaxTessPatchComponentsext = unchecked((uint)0x8E84),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS_EXT")]
    MaxTessControlTotalOutputComponentsext = unchecked((uint)0x8E85),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS_EXT")]
    MaxTessEvaluationOutputComponentsext = unchecked((uint)0x8E86),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS_EXT")]
    MaxTessControlUniformBlocksext = unchecked((uint)0x8E89),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS_EXT")]
    MaxTessEvaluationUniformBlocksext = unchecked((uint)0x8E8A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_TESS_CONTROL_INPUT_COMPONENTS_EXT")]
    MaxTessControlInputComponentsext = unchecked((uint)0x886C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS_EXT")]
    MaxTessEvaluationInputComponentsext = unchecked((uint)0x886D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS_EXT")]
    MaxCombinedTessControlUniformComponentsext = unchecked((uint)0x8E1E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS_EXT")]
    MaxCombinedTessEvaluationUniformComponentsext = unchecked((uint)0x8E1F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS_EXT")]
    MaxTessControlAtomicCounterBuffersext = unchecked((uint)0x92CD),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS_EXT")]
    MaxTessEvaluationAtomicCounterBuffersext = unchecked((uint)0x92CE),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS_EXT")]
    MaxTessControlAtomicCountersext = unchecked((uint)0x92D3),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS_EXT")]
    MaxTessEvaluationAtomicCountersext = unchecked((uint)0x92D4),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS_EXT")]
    MaxTessControlImageUniformsext = unchecked((uint)0x90CB),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS_EXT")]
    MaxTessEvaluationImageUniformsext = unchecked((uint)0x90CC),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS_EXT")]
    MaxTessControlShaderStorageBlocksext = unchecked((uint)0x90D8),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS_EXT")]
    MaxTessEvaluationShaderStorageBlocksext = unchecked((uint)0x90D9),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_IS_PER_PATCH_EXT")]
    IsPerPatchext = unchecked((uint)0x92E7),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_REFERENCED_BY_TESS_CONTROL_SHADER_EXT")]
    ReferencedByTessControlShaderext = unchecked((uint)0x9307),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_REFERENCED_BY_TESS_EVALUATION_SHADER_EXT")]
    ReferencedByTessEvaluationShaderext = unchecked((uint)0x9308),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TESS_CONTROL_SHADER_EXT")]
    TessControlShaderext = unchecked((uint)0x8E88),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TESS_EVALUATION_SHADER_EXT")]
    TessEvaluationShaderext = unchecked((uint)0x8E87),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TESS_CONTROL_SHADER_BIT_EXT")]
    TessControlShaderBitext = unchecked((uint)0x00000008),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TESS_EVALUATION_SHADER_BIT_EXT")]
    TessEvaluationShaderBitext = unchecked((uint)0x00000010),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_BORDER_COLOR_EXT")]
    TextureBorderColorext = unchecked((uint)0x1004),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CLAMP_TO_BORDER_EXT")]
    ClampToBorderext = unchecked((uint)0x812D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_BUFFER_BINDING_EXT")]
    TextureBufferBindingext = unchecked((uint)0x8C2A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT_EXT")]
    TextureBufferOffsetAlignmentext = unchecked((uint)0x919F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_BUFFER_OFFSET_EXT")]
    TextureBufferOffsetext = unchecked((uint)0x919D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_BUFFER_SIZE_EXT")]
    TextureBufferSizeext = unchecked((uint)0x919E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_ASTC_DECODE_PRECISION_EXT")]
    TextureAstcDecodePrecisionext = unchecked((uint)0x8F69),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMPRESSED_RGBA_BPTC_UNORM_EXT")]
    CompressedRgbaBptcUnormext = unchecked((uint)0x8E8C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM_EXT")]
    CompressedSrgbAlphaBptcUnormext = unchecked((uint)0x8E8D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT_EXT")]
    CompressedRgbBptcSignedFloatext = unchecked((uint)0x8E8E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_EXT")]
    CompressedRgbBptcUnsignedFloatext = unchecked((uint)0x8E8F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_ARRAY_EXT")]
    TextureCubeMapArrayext = unchecked((uint)0x9009),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_BINDING_CUBE_MAP_ARRAY_EXT")]
    TextureBindingCubeMapArrayext = unchecked((uint)0x900A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SAMPLER_CUBE_MAP_ARRAY_EXT")]
    SamplerCubeMapArrayext = unchecked((uint)0x900C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW_EXT")]
    SamplerCubeMapArrayShadowext = unchecked((uint)0x900D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INT_SAMPLER_CUBE_MAP_ARRAY_EXT")]
    IntSamplerCubeMapArrayext = unchecked((uint)0x900E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_EXT")]
    UnsignedIntSamplerCubeMapArrayext = unchecked((uint)0x900F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_FORMAT_SRGB_OVERRIDE_EXT")]
    TextureFormatSrgbOverrideext = unchecked((uint)0x8FBF),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_R16_EXT")]
    R16Ext = unchecked((uint)0x822A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RG16_EXT")]
    Rg16Ext = unchecked((uint)0x822C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGB16_SNORM_EXT")]
    Rgb16Snormext = unchecked((uint)0x8F9A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RED_EXT")]
    Redext = unchecked((uint)0x1903),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RG_EXT")]
    Rgext = unchecked((uint)0x8227),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_NUM_SURFACE_COMPRESSION_FIXED_RATES_EXT")]
    NumSurfaceCompressionFixedRatesext = unchecked((uint)0x8F6E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_1BPC_EXT")]
    SurfaceCompressionFixedRate1Bpcext = unchecked((uint)0x96C4),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_2BPC_EXT")]
    SurfaceCompressionFixedRate2Bpcext = unchecked((uint)0x96C5),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_3BPC_EXT")]
    SurfaceCompressionFixedRate3Bpcext = unchecked((uint)0x96C6),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_4BPC_EXT")]
    SurfaceCompressionFixedRate4Bpcext = unchecked((uint)0x96C7),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_5BPC_EXT")]
    SurfaceCompressionFixedRate5Bpcext = unchecked((uint)0x96C8),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_6BPC_EXT")]
    SurfaceCompressionFixedRate6Bpcext = unchecked((uint)0x96C9),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_7BPC_EXT")]
    SurfaceCompressionFixedRate7Bpcext = unchecked((uint)0x96CA),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_8BPC_EXT")]
    SurfaceCompressionFixedRate8Bpcext = unchecked((uint)0x96CB),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_9BPC_EXT")]
    SurfaceCompressionFixedRate9Bpcext = unchecked((uint)0x96CC),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_10BPC_EXT")]
    SurfaceCompressionFixedRate10Bpcext = unchecked((uint)0x96CD),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_11BPC_EXT")]
    SurfaceCompressionFixedRate11Bpcext = unchecked((uint)0x96CE),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_12BPC_EXT")]
    SurfaceCompressionFixedRate12Bpcext = unchecked((uint)0x96CF),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_2_10_10_10_REV_EXT")]
    UnsignedInt2X10X10X10Revext = unchecked((uint)0x8368),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_VIEW_MIN_LEVEL_EXT")]
    TextureViewMinLevelext = unchecked((uint)0x82DB),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_VIEW_NUM_LEVELS_EXT")]
    TextureViewNumLevelsext = unchecked((uint)0x82DC),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_VIEW_MIN_LAYER_EXT")]
    TextureViewMinLayerext = unchecked((uint)0x82DD),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_VIEW_NUM_LAYERS_EXT")]
    TextureViewNumLayersext = unchecked((uint)0x82DE),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNPACK_ROW_LENGTH_EXT")]
    UnpackRowLengthext = unchecked((uint)0x0CF2),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNPACK_SKIP_ROWS_EXT")]
    UnpackSkipRowsext = unchecked((uint)0x0CF3),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNPACK_SKIP_PIXELS_EXT")]
    UnpackSkipPixelsext = unchecked((uint)0x0CF4),

    [NameAffix("Suffix", "FJ", 0)]
    [NativeName("GL_GCCSO_SHADER_BINARY_FJ")]
    GccsoShaderBinaryfj = unchecked((uint)0x9260),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_AND_DOWNSAMPLE_IMG")]
    FramebufferIncompleteMultisampleAndDownsampleimg = unchecked((uint)0x913C),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_NUM_DOWNSAMPLE_SCALES_IMG")]
    NumDownsampleScalesimg = unchecked((uint)0x913D),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_DOWNSAMPLE_SCALES_IMG")]
    DownsampleScalesimg = unchecked((uint)0x913E),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SCALE_IMG")]
    FramebufferAttachmentTextureScaleimg = unchecked((uint)0x913F),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_SGX_PROGRAM_BINARY_IMG")]
    SgxProgramBinaryimg = unchecked((uint)0x9130),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_SGX_BINARY_IMG")]
    SgxBinaryimg = unchecked((uint)0x8C0A),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_COMPRESSED_RGBA_PVRTC_2BPPV2_IMG")]
    CompressedRgbaPvrtc2Bppv2Img = unchecked((uint)0x9137),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_COMPRESSED_RGBA_PVRTC_4BPPV2_IMG")]
    CompressedRgbaPvrtc4Bppv2Img = unchecked((uint)0x9138),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_CUBIC_IMG")]
    Cubicimg = unchecked((uint)0x9139),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_CUBIC_MIPMAP_NEAREST_IMG")]
    CubicMipmapNearestimg = unchecked((uint)0x913A),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_CUBIC_MIPMAP_LINEAR_IMG")]
    CubicMipmapLinearimg = unchecked((uint)0x913B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COPY_READ_BUFFER_NV")]
    CopyReadBuffernv = unchecked((uint)0x8F36),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COPY_WRITE_BUFFER_NV")]
    CopyWriteBuffernv = unchecked((uint)0x8F37),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COVERAGE_COMPONENT_NV")]
    CoverageComponentnv = unchecked((uint)0x8ED0),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COVERAGE_COMPONENT4_NV")]
    CoverageComponent4Nv = unchecked((uint)0x8ED1),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COVERAGE_ATTACHMENT_NV")]
    CoverageAttachmentnv = unchecked((uint)0x8ED2),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COVERAGE_BUFFERS_NV")]
    CoverageBuffersnv = unchecked((uint)0x8ED3),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COVERAGE_SAMPLES_NV")]
    CoverageSamplesnv = unchecked((uint)0x8ED4),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COVERAGE_ALL_FRAGMENTS_NV")]
    CoverageAllFragmentsnv = unchecked((uint)0x8ED5),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COVERAGE_EDGE_FRAGMENTS_NV")]
    CoverageEdgeFragmentsnv = unchecked((uint)0x8ED6),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COVERAGE_AUTOMATIC_NV")]
    CoverageAutomaticnv = unchecked((uint)0x8ED7),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COVERAGE_BUFFER_BIT_NV")]
    CoverageBufferBitnv = unchecked((uint)0x00008000),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DEPTH_COMPONENT16_NONLINEAR_NV")]
    DepthComponent16Nonlinearnv = unchecked((uint)0x8E2C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_DRAW_BUFFERS_NV")]
    MaxDrawBuffersnv = unchecked((uint)0x8824),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_BUFFER0_NV")]
    DrawBuffer0Nv = unchecked((uint)0x8825),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_BUFFER1_NV")]
    DrawBuffer1Nv = unchecked((uint)0x8826),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_BUFFER2_NV")]
    DrawBuffer2Nv = unchecked((uint)0x8827),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_BUFFER3_NV")]
    DrawBuffer3Nv = unchecked((uint)0x8828),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_BUFFER4_NV")]
    DrawBuffer4Nv = unchecked((uint)0x8829),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_BUFFER5_NV")]
    DrawBuffer5Nv = unchecked((uint)0x882A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_BUFFER6_NV")]
    DrawBuffer6Nv = unchecked((uint)0x882B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_BUFFER7_NV")]
    DrawBuffer7Nv = unchecked((uint)0x882C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_BUFFER8_NV")]
    DrawBuffer8Nv = unchecked((uint)0x882D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_BUFFER9_NV")]
    DrawBuffer9Nv = unchecked((uint)0x882E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_BUFFER10_NV")]
    DrawBuffer10Nv = unchecked((uint)0x882F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_BUFFER11_NV")]
    DrawBuffer11Nv = unchecked((uint)0x8830),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_BUFFER12_NV")]
    DrawBuffer12Nv = unchecked((uint)0x8831),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_BUFFER13_NV")]
    DrawBuffer13Nv = unchecked((uint)0x8832),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_BUFFER14_NV")]
    DrawBuffer14Nv = unchecked((uint)0x8833),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_BUFFER15_NV")]
    DrawBuffer15Nv = unchecked((uint)0x8834),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT0_NV")]
    ColorAttachment0Nv = unchecked((uint)0x8CE0),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT1_NV")]
    ColorAttachment1Nv = unchecked((uint)0x8CE1),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT2_NV")]
    ColorAttachment2Nv = unchecked((uint)0x8CE2),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT3_NV")]
    ColorAttachment3Nv = unchecked((uint)0x8CE3),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT4_NV")]
    ColorAttachment4Nv = unchecked((uint)0x8CE4),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT5_NV")]
    ColorAttachment5Nv = unchecked((uint)0x8CE5),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT6_NV")]
    ColorAttachment6Nv = unchecked((uint)0x8CE6),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT7_NV")]
    ColorAttachment7Nv = unchecked((uint)0x8CE7),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT8_NV")]
    ColorAttachment8Nv = unchecked((uint)0x8CE8),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT9_NV")]
    ColorAttachment9Nv = unchecked((uint)0x8CE9),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT10_NV")]
    ColorAttachment10Nv = unchecked((uint)0x8CEA),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT11_NV")]
    ColorAttachment11Nv = unchecked((uint)0x8CEB),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT12_NV")]
    ColorAttachment12Nv = unchecked((uint)0x8CEC),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT13_NV")]
    ColorAttachment13Nv = unchecked((uint)0x8CED),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT14_NV")]
    ColorAttachment14Nv = unchecked((uint)0x8CEE),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT15_NV")]
    ColorAttachment15Nv = unchecked((uint)0x8CEF),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_COLOR_ATTACHMENTS_NV")]
    MaxColorAttachmentsnv = unchecked((uint)0x8CDF),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_READ_FRAMEBUFFER_NV")]
    ReadFramebuffernv = unchecked((uint)0x8CA8),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_FRAMEBUFFER_NV")]
    DrawFramebuffernv = unchecked((uint)0x8CA9),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_FRAMEBUFFER_BINDING_NV")]
    DrawFramebufferBindingnv = unchecked((uint)0x8CA6),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_READ_FRAMEBUFFER_BINDING_NV")]
    ReadFramebufferBindingnv = unchecked((uint)0x8CAA),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RENDERBUFFER_SAMPLES_NV")]
    RenderbufferSamplesnv = unchecked((uint)0x8CAB),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_NV")]
    FramebufferIncompleteMultisamplenv = unchecked((uint)0x8D56),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_SAMPLES_NV")]
    MaxSamplesnv = unchecked((uint)0x8D57),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTEX_ATTRIB_ARRAY_DIVISOR_NV")]
    VertexAttribArrayDivisornv = unchecked((uint)0x88FE),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FLOAT_MAT2x3_NV")]
    FloatMat2X3Nv = unchecked((uint)0x8B65),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FLOAT_MAT2x4_NV")]
    FloatMat2X4Nv = unchecked((uint)0x8B66),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FLOAT_MAT3x2_NV")]
    FloatMat3X2Nv = unchecked((uint)0x8B67),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FLOAT_MAT3x4_NV")]
    FloatMat3X4Nv = unchecked((uint)0x8B68),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FLOAT_MAT4x2_NV")]
    FloatMat4X2Nv = unchecked((uint)0x8B69),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FLOAT_MAT4x3_NV")]
    FloatMat4X3Nv = unchecked((uint)0x8B6A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PACK_ROW_LENGTH_NV")]
    PackRowLengthnv = unchecked((uint)0x0D02),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PACK_SKIP_ROWS_NV")]
    PackSkipRowsnv = unchecked((uint)0x0D03),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PACK_SKIP_PIXELS_NV")]
    PackSkipPixelsnv = unchecked((uint)0x0D04),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PIXEL_PACK_BUFFER_NV")]
    PixelPackBuffernv = unchecked((uint)0x88EB),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PIXEL_UNPACK_BUFFER_NV")]
    PixelUnpackBuffernv = unchecked((uint)0x88EC),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PIXEL_PACK_BUFFER_BINDING_NV")]
    PixelPackBufferBindingnv = unchecked((uint)0x88ED),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PIXEL_UNPACK_BUFFER_BINDING_NV")]
    PixelUnpackBufferBindingnv = unchecked((uint)0x88EF),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_POLYGON_MODE_NV")]
    PolygonModenv = unchecked((uint)0x0B40),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_POLYGON_OFFSET_POINT_NV")]
    PolygonOffsetPointnv = unchecked((uint)0x2A01),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_POLYGON_OFFSET_LINE_NV")]
    PolygonOffsetLinenv = unchecked((uint)0x2A02),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_POINT_NV")]
    Pointnv = unchecked((uint)0x1B00),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_LINE_NV")]
    Linenv = unchecked((uint)0x1B01),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FILL_NV")]
    Fillnv = unchecked((uint)0x1B02),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_READ_BUFFER_NV")]
    ReadBuffernv = unchecked((uint)0x0C02),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SLUMINANCE_NV")]
    Sluminancenv = unchecked((uint)0x8C46),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SLUMINANCE_ALPHA_NV")]
    SluminanceAlphanv = unchecked((uint)0x8C44),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SRGB8_NV")]
    Srgb8Nv = unchecked((uint)0x8C41),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SLUMINANCE8_NV")]
    Sluminance8Nv = unchecked((uint)0x8C47),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SLUMINANCE8_ALPHA8_NV")]
    Sluminance8Alpha8Nv = unchecked((uint)0x8C45),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMPRESSED_SRGB_S3TC_DXT1_NV")]
    CompressedSrgbS3TcDxt1Nv = unchecked((uint)0x8C4C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_NV")]
    CompressedSrgbAlphaS3TcDxt1Nv = unchecked((uint)0x8C4D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_NV")]
    CompressedSrgbAlphaS3TcDxt3Nv = unchecked((uint)0x8C4E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_NV")]
    CompressedSrgbAlphaS3TcDxt5Nv = unchecked((uint)0x8C4F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ETC1_SRGB8_NV")]
    Etc1Srgb8Nv = unchecked((uint)0x88EE),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SAMPLER_2D_ARRAY_SHADOW_NV")]
    Sampler2DArrayShadownv = unchecked((uint)0x8DC4),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SAMPLER_CUBE_SHADOW_NV")]
    SamplerCubeShadownv = unchecked((uint)0x8DC5),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TEXTURE_BORDER_COLOR_NV")]
    TextureBorderColornv = unchecked((uint)0x1004),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CLAMP_TO_BORDER_NV")]
    ClampToBordernv = unchecked((uint)0x812D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MAX_VIEWPORTS_NV")]
    MaxViewportsnv = unchecked((uint)0x825B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIEWPORT_SUBPIXEL_BITS_NV")]
    ViewportSubpixelBitsnv = unchecked((uint)0x825C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIEWPORT_BOUNDS_RANGE_NV")]
    ViewportBoundsRangenv = unchecked((uint)0x825D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIEWPORT_INDEX_PROVOKING_VERTEX_NV")]
    ViewportIndexProvokingVertexnv = unchecked((uint)0x825F),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_ALPHA_TEST_QCOM")]
    AlphaTestqcom = unchecked((uint)0x0BC0),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_ALPHA_TEST_FUNC_QCOM")]
    AlphaTestFuncqcom = unchecked((uint)0x0BC1),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_ALPHA_TEST_REF_QCOM")]
    AlphaTestRefqcom = unchecked((uint)0x0BC2),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_BINNING_CONTROL_HINT_QCOM")]
    BinningControlHintqcom = unchecked((uint)0x8FB0),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_CPU_OPTIMIZED_QCOM")]
    CpuOptimizedqcom = unchecked((uint)0x8FB1),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_GPU_OPTIMIZED_QCOM")]
    GpuOptimizedqcom = unchecked((uint)0x8FB2),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_RENDER_DIRECT_TO_FRAMEBUFFER_QCOM")]
    RenderDirectToFramebufferqcom = unchecked((uint)0x8FB3),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_FOVEATION_ENABLE_BIT_QCOM")]
    FoveationEnableBitqcom = unchecked((uint)0x00000001),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_FOVEATION_SCALED_BIN_METHOD_BIT_QCOM")]
    FoveationScaledBinMethodBitqcom = unchecked((uint)0x00000002),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_MOTION_ESTIMATION_SEARCH_BLOCK_X_QCOM")]
    MotionEstimationSearchBlockXqcom = unchecked((uint)0x8C90),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_MOTION_ESTIMATION_SEARCH_BLOCK_Y_QCOM")]
    MotionEstimationSearchBlockYqcom = unchecked((uint)0x8C91),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_FRAMEBUFFER_FETCH_NONCOHERENT_QCOM")]
    FramebufferFetchNoncoherentqcom = unchecked((uint)0x96A2),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_SHADING_RATE_QCOM")]
    ShadingRateqcom = unchecked((uint)0x96A4),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_SHADING_RATE_PRESERVE_ASPECT_RATIO_QCOM")]
    ShadingRatePreserveAspectRatioqcom = unchecked((uint)0x96A5),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_SHADING_RATE_1X1_PIXELS_QCOM")]
    ShadingRate1X1Pixelsqcom = unchecked((uint)0x96A6),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_SHADING_RATE_1X2_PIXELS_QCOM")]
    ShadingRate1X2Pixelsqcom = unchecked((uint)0x96A7),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_SHADING_RATE_2X1_PIXELS_QCOM")]
    ShadingRate2X1Pixelsqcom = unchecked((uint)0x96A8),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_SHADING_RATE_2X2_PIXELS_QCOM")]
    ShadingRate2X2Pixelsqcom = unchecked((uint)0x96A9),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_SHADING_RATE_4X2_PIXELS_QCOM")]
    ShadingRate4X2Pixelsqcom = unchecked((uint)0x96AC),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_SHADING_RATE_4X4_PIXELS_QCOM")]
    ShadingRate4X4Pixelsqcom = unchecked((uint)0x96AE),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_TEXTURE_FOVEATED_FEATURE_BITS_QCOM")]
    TextureFoveatedFeatureBitsqcom = unchecked((uint)0x8BFB),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_TEXTURE_FOVEATED_MIN_PIXEL_DENSITY_QCOM")]
    TextureFoveatedMinPixelDensityqcom = unchecked((uint)0x8BFC),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_TEXTURE_FOVEATED_FEATURE_QUERY_QCOM")]
    TextureFoveatedFeatureQueryqcom = unchecked((uint)0x8BFD),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_TEXTURE_FOVEATED_NUM_FOCAL_POINTS_QUERY_QCOM")]
    TextureFoveatedNumFocalPointsQueryqcom = unchecked((uint)0x8BFE),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_FOVEATION_QCOM")]
    FramebufferIncompleteFoveationqcom = unchecked((uint)0x8BFF),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_TEXTURE_FOVEATED_CUTOFF_DENSITY_QCOM")]
    TextureFoveatedCutoffDensityqcom = unchecked((uint)0x96A0),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_FOVEATION_SUBSAMPLED_LAYOUT_METHOD_BIT_QCOM")]
    FoveationSubsampledLayoutMethodBitqcom = unchecked((uint)0x00000004),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_MAX_SHADER_SUBSAMPLED_IMAGE_UNITS_QCOM")]
    MaxShaderSubsampledImageUnitsqcom = unchecked((uint)0x8FA1),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_TEXTURE_LOD_BIAS_QCOM")]
    TextureLodBiasqcom = unchecked((uint)0x8C96),

    [NameAffix("Suffix", "VIV", 0)]
    [NativeName("GL_SHADER_BINARY_VIV")]
    ShaderBinaryviv = unchecked((uint)0x8FC4),
}
