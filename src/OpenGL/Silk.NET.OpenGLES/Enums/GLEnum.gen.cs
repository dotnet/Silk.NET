// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "GLenum")]
    public enum GLEnum : int
    {
        [NativeName("Name", "GL_DEPTH_BUFFER_BIT")]
        DepthBufferBit = 0x100,
        [NativeName("Name", "GL_STENCIL_BUFFER_BIT")]
        StencilBufferBit = 0x400,
        [NativeName("Name", "GL_COLOR_BUFFER_BIT")]
        ColorBufferBit = 0x4000,
        [NativeName("Name", "GL_FALSE")]
        False = 0x0,
        [NativeName("Name", "GL_TRUE")]
        True = 0x1,
        [NativeName("Name", "GL_POINTS")]
        Points = 0x0,
        [NativeName("Name", "GL_LINES")]
        Lines = 0x1,
        [NativeName("Name", "GL_LINE_LOOP")]
        LineLoop = 0x2,
        [NativeName("Name", "GL_LINE_STRIP")]
        LineStrip = 0x3,
        [NativeName("Name", "GL_TRIANGLES")]
        Triangles = 0x4,
        [NativeName("Name", "GL_TRIANGLE_STRIP")]
        TriangleStrip = 0x5,
        [NativeName("Name", "GL_TRIANGLE_FAN")]
        TriangleFan = 0x6,
        [NativeName("Name", "GL_ZERO")]
        Zero = 0x0,
        [NativeName("Name", "GL_ONE")]
        One = 0x1,
        [NativeName("Name", "GL_SRC_COLOR")]
        SrcColor = 0x300,
        [NativeName("Name", "GL_ONE_MINUS_SRC_COLOR")]
        OneMinusSrcColor = 0x301,
        [NativeName("Name", "GL_SRC_ALPHA")]
        SrcAlpha = 0x302,
        [NativeName("Name", "GL_ONE_MINUS_SRC_ALPHA")]
        OneMinusSrcAlpha = 0x303,
        [NativeName("Name", "GL_DST_ALPHA")]
        DstAlpha = 0x304,
        [NativeName("Name", "GL_ONE_MINUS_DST_ALPHA")]
        OneMinusDstAlpha = 0x305,
        [NativeName("Name", "GL_DST_COLOR")]
        DstColor = 0x306,
        [NativeName("Name", "GL_ONE_MINUS_DST_COLOR")]
        OneMinusDstColor = 0x307,
        [NativeName("Name", "GL_SRC_ALPHA_SATURATE")]
        SrcAlphaSaturate = 0x308,
        [NativeName("Name", "GL_FUNC_ADD")]
        FuncAdd = 0x8006,
        [NativeName("Name", "GL_BLEND_EQUATION")]
        BlendEquation = 0x8009,
        [NativeName("Name", "GL_BLEND_EQUATION_RGB")]
        BlendEquationRgb = 0x8009,
        [NativeName("Name", "GL_BLEND_EQUATION_ALPHA")]
        BlendEquationAlpha = 0x883D,
        [NativeName("Name", "GL_FUNC_SUBTRACT")]
        FuncSubtract = 0x800A,
        [NativeName("Name", "GL_FUNC_REVERSE_SUBTRACT")]
        FuncReverseSubtract = 0x800B,
        [NativeName("Name", "GL_BLEND_DST_RGB")]
        BlendDstRgb = 0x80C8,
        [NativeName("Name", "GL_BLEND_SRC_RGB")]
        BlendSrcRgb = 0x80C9,
        [NativeName("Name", "GL_BLEND_DST_ALPHA")]
        BlendDstAlpha = 0x80CA,
        [NativeName("Name", "GL_BLEND_SRC_ALPHA")]
        BlendSrcAlpha = 0x80CB,
        [NativeName("Name", "GL_CONSTANT_COLOR")]
        ConstantColor = 0x8001,
        [NativeName("Name", "GL_ONE_MINUS_CONSTANT_COLOR")]
        OneMinusConstantColor = 0x8002,
        [NativeName("Name", "GL_CONSTANT_ALPHA")]
        ConstantAlpha = 0x8003,
        [NativeName("Name", "GL_ONE_MINUS_CONSTANT_ALPHA")]
        OneMinusConstantAlpha = 0x8004,
        [NativeName("Name", "GL_BLEND_COLOR")]
        BlendColor = 0x8005,
        [NativeName("Name", "GL_ARRAY_BUFFER")]
        ArrayBuffer = 0x8892,
        [NativeName("Name", "GL_ELEMENT_ARRAY_BUFFER")]
        ElementArrayBuffer = 0x8893,
        [NativeName("Name", "GL_ARRAY_BUFFER_BINDING")]
        ArrayBufferBinding = 0x8894,
        [NativeName("Name", "GL_ELEMENT_ARRAY_BUFFER_BINDING")]
        ElementArrayBufferBinding = 0x8895,
        [NativeName("Name", "GL_STREAM_DRAW")]
        StreamDraw = 0x88E0,
        [NativeName("Name", "GL_STATIC_DRAW")]
        StaticDraw = 0x88E4,
        [NativeName("Name", "GL_DYNAMIC_DRAW")]
        DynamicDraw = 0x88E8,
        [NativeName("Name", "GL_BUFFER_SIZE")]
        BufferSize = 0x8764,
        [NativeName("Name", "GL_BUFFER_USAGE")]
        BufferUsage = 0x8765,
        [NativeName("Name", "GL_CURRENT_VERTEX_ATTRIB")]
        CurrentVertexAttrib = 0x8626,
        [NativeName("Name", "GL_FRONT")]
        Front = 0x404,
        [NativeName("Name", "GL_BACK")]
        Back = 0x405,
        [NativeName("Name", "GL_FRONT_AND_BACK")]
        FrontAndBack = 0x408,
        [NativeName("Name", "GL_TEXTURE_2D")]
        Texture2D = 0xDE1,
        [NativeName("Name", "GL_CULL_FACE")]
        CullFace = 0xB44,
        [NativeName("Name", "GL_BLEND")]
        Blend = 0xBE2,
        [NativeName("Name", "GL_DITHER")]
        Dither = 0xBD0,
        [NativeName("Name", "GL_STENCIL_TEST")]
        StencilTest = 0xB90,
        [NativeName("Name", "GL_DEPTH_TEST")]
        DepthTest = 0xB71,
        [NativeName("Name", "GL_SCISSOR_TEST")]
        ScissorTest = 0xC11,
        [NativeName("Name", "GL_POLYGON_OFFSET_FILL")]
        PolygonOffsetFill = 0x8037,
        [NativeName("Name", "GL_SAMPLE_ALPHA_TO_COVERAGE")]
        SampleAlphaToCoverage = 0x809E,
        [NativeName("Name", "GL_SAMPLE_COVERAGE")]
        SampleCoverage = 0x80A0,
        [NativeName("Name", "GL_NO_ERROR")]
        NoError = 0x0,
        [NativeName("Name", "GL_INVALID_ENUM")]
        InvalidEnum = 0x500,
        [NativeName("Name", "GL_INVALID_VALUE")]
        InvalidValue = 0x501,
        [NativeName("Name", "GL_INVALID_OPERATION")]
        InvalidOperation = 0x502,
        [NativeName("Name", "GL_OUT_OF_MEMORY")]
        OutOfMemory = 0x505,
        [NativeName("Name", "GL_CW")]
        CW = 0x900,
        [NativeName("Name", "GL_CCW")]
        Ccw = 0x901,
        [NativeName("Name", "GL_LINE_WIDTH")]
        LineWidth = 0xB21,
        [System.Obsolete("Deprecated in version 2.0")]
        [NativeName("Name", "GL_ALIASED_POINT_SIZE_RANGE")]
        AliasedPointSizeRange = 0x846D,
        [NativeName("Name", "GL_ALIASED_LINE_WIDTH_RANGE")]
        AliasedLineWidthRange = 0x846E,
        [NativeName("Name", "GL_CULL_FACE_MODE")]
        CullFaceMode = 0xB45,
        [NativeName("Name", "GL_FRONT_FACE")]
        FrontFace = 0xB46,
        [NativeName("Name", "GL_DEPTH_RANGE")]
        DepthRange = 0xB70,
        [NativeName("Name", "GL_DEPTH_WRITEMASK")]
        DepthWritemask = 0xB72,
        [NativeName("Name", "GL_DEPTH_CLEAR_VALUE")]
        DepthClearValue = 0xB73,
        [NativeName("Name", "GL_DEPTH_FUNC")]
        DepthFunc = 0xB74,
        [NativeName("Name", "GL_STENCIL_CLEAR_VALUE")]
        StencilClearValue = 0xB91,
        [NativeName("Name", "GL_STENCIL_FUNC")]
        StencilFunc = 0xB92,
        [NativeName("Name", "GL_STENCIL_FAIL")]
        StencilFail = 0xB94,
        [NativeName("Name", "GL_STENCIL_PASS_DEPTH_FAIL")]
        StencilPassDepthFail = 0xB95,
        [NativeName("Name", "GL_STENCIL_PASS_DEPTH_PASS")]
        StencilPassDepthPass = 0xB96,
        [NativeName("Name", "GL_STENCIL_REF")]
        StencilRef = 0xB97,
        [NativeName("Name", "GL_STENCIL_VALUE_MASK")]
        StencilValueMask = 0xB93,
        [NativeName("Name", "GL_STENCIL_WRITEMASK")]
        StencilWritemask = 0xB98,
        [NativeName("Name", "GL_STENCIL_BACK_FUNC")]
        StencilBackFunc = 0x8800,
        [NativeName("Name", "GL_STENCIL_BACK_FAIL")]
        StencilBackFail = 0x8801,
        [NativeName("Name", "GL_STENCIL_BACK_PASS_DEPTH_FAIL")]
        StencilBackPassDepthFail = 0x8802,
        [NativeName("Name", "GL_STENCIL_BACK_PASS_DEPTH_PASS")]
        StencilBackPassDepthPass = 0x8803,
        [NativeName("Name", "GL_STENCIL_BACK_REF")]
        StencilBackRef = 0x8CA3,
        [NativeName("Name", "GL_STENCIL_BACK_VALUE_MASK")]
        StencilBackValueMask = 0x8CA4,
        [NativeName("Name", "GL_STENCIL_BACK_WRITEMASK")]
        StencilBackWritemask = 0x8CA5,
        [NativeName("Name", "GL_VIEWPORT")]
        Viewport = 0xBA2,
        [NativeName("Name", "GL_SCISSOR_BOX")]
        ScissorBox = 0xC10,
        [NativeName("Name", "GL_COLOR_CLEAR_VALUE")]
        ColorClearValue = 0xC22,
        [NativeName("Name", "GL_COLOR_WRITEMASK")]
        ColorWritemask = 0xC23,
        [NativeName("Name", "GL_UNPACK_ALIGNMENT")]
        UnpackAlignment = 0xCF5,
        [NativeName("Name", "GL_PACK_ALIGNMENT")]
        PackAlignment = 0xD05,
        [NativeName("Name", "GL_MAX_TEXTURE_SIZE")]
        MaxTextureSize = 0xD33,
        [NativeName("Name", "GL_MAX_VIEWPORT_DIMS")]
        MaxViewportDims = 0xD3A,
        [NativeName("Name", "GL_SUBPIXEL_BITS")]
        SubpixelBits = 0xD50,
        [System.Obsolete("Deprecated in version 2.0")]
        [NativeName("Name", "GL_RED_BITS")]
        RedBits = 0xD52,
        [System.Obsolete("Deprecated in version 2.0")]
        [NativeName("Name", "GL_GREEN_BITS")]
        GreenBits = 0xD53,
        [System.Obsolete("Deprecated in version 2.0")]
        [NativeName("Name", "GL_BLUE_BITS")]
        BlueBits = 0xD54,
        [System.Obsolete("Deprecated in version 2.0")]
        [NativeName("Name", "GL_ALPHA_BITS")]
        AlphaBits = 0xD55,
        [System.Obsolete("Deprecated in version 2.0")]
        [NativeName("Name", "GL_DEPTH_BITS")]
        DepthBits = 0xD56,
        [System.Obsolete("Deprecated in version 2.0")]
        [NativeName("Name", "GL_STENCIL_BITS")]
        StencilBits = 0xD57,
        [NativeName("Name", "GL_POLYGON_OFFSET_UNITS")]
        PolygonOffsetUnits = 0x2A00,
        [NativeName("Name", "GL_POLYGON_OFFSET_FACTOR")]
        PolygonOffsetFactor = 0x8038,
        [NativeName("Name", "GL_TEXTURE_BINDING_2D")]
        TextureBinding2D = 0x8069,
        [NativeName("Name", "GL_SAMPLE_BUFFERS")]
        SampleBuffers = 0x80A8,
        [NativeName("Name", "GL_SAMPLES")]
        Samples = 0x80A9,
        [NativeName("Name", "GL_SAMPLE_COVERAGE_VALUE")]
        SampleCoverageValue = 0x80AA,
        [NativeName("Name", "GL_SAMPLE_COVERAGE_INVERT")]
        SampleCoverageInvert = 0x80AB,
        [NativeName("Name", "GL_NUM_COMPRESSED_TEXTURE_FORMATS")]
        NumCompressedTextureFormats = 0x86A2,
        [NativeName("Name", "GL_COMPRESSED_TEXTURE_FORMATS")]
        CompressedTextureFormats = 0x86A3,
        [NativeName("Name", "GL_DONT_CARE")]
        DontCare = 0x1100,
        [NativeName("Name", "GL_FASTEST")]
        Fastest = 0x1101,
        [NativeName("Name", "GL_NICEST")]
        Nicest = 0x1102,
        [System.Obsolete("Deprecated in version 2.0")]
        [NativeName("Name", "GL_GENERATE_MIPMAP_HINT")]
        GenerateMipmapHint = 0x8192,
        [NativeName("Name", "GL_BYTE")]
        Byte = 0x1400,
        [NativeName("Name", "GL_UNSIGNED_BYTE")]
        UnsignedByte = 0x1401,
        [NativeName("Name", "GL_SHORT")]
        Short = 0x1402,
        [NativeName("Name", "GL_UNSIGNED_SHORT")]
        UnsignedShort = 0x1403,
        [NativeName("Name", "GL_INT")]
        Int = 0x1404,
        [NativeName("Name", "GL_UNSIGNED_INT")]
        UnsignedInt = 0x1405,
        [NativeName("Name", "GL_FLOAT")]
        Float = 0x1406,
        [NativeName("Name", "GL_FIXED")]
        Fixed = 0x140C,
        [NativeName("Name", "GL_DEPTH_COMPONENT")]
        DepthComponent = 0x1902,
        [NativeName("Name", "GL_ALPHA")]
        Alpha = 0x1906,
        [NativeName("Name", "GL_RGB")]
        Rgb = 0x1907,
        [NativeName("Name", "GL_RGBA")]
        Rgba = 0x1908,
        [System.Obsolete("Deprecated in version 2.0")]
        [NativeName("Name", "GL_LUMINANCE")]
        Luminance = 0x1909,
        [System.Obsolete("Deprecated in version 2.0")]
        [NativeName("Name", "GL_LUMINANCE_ALPHA")]
        LuminanceAlpha = 0x190A,
        [NativeName("Name", "GL_UNSIGNED_SHORT_4_4_4_4")]
        UnsignedShort4444 = 0x8033,
        [NativeName("Name", "GL_UNSIGNED_SHORT_5_5_5_1")]
        UnsignedShort5551 = 0x8034,
        [NativeName("Name", "GL_UNSIGNED_SHORT_5_6_5")]
        UnsignedShort565 = 0x8363,
        [NativeName("Name", "GL_FRAGMENT_SHADER")]
        FragmentShader = 0x8B30,
        [NativeName("Name", "GL_VERTEX_SHADER")]
        VertexShader = 0x8B31,
        [NativeName("Name", "GL_MAX_VERTEX_ATTRIBS")]
        MaxVertexAttribs = 0x8869,
        [NativeName("Name", "GL_MAX_VERTEX_UNIFORM_VECTORS")]
        MaxVertexUniformVectors = 0x8DFB,
        [NativeName("Name", "GL_MAX_VARYING_VECTORS")]
        MaxVaryingVectors = 0x8DFC,
        [NativeName("Name", "GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS")]
        MaxCombinedTextureImageUnits = 0x8B4D,
        [NativeName("Name", "GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS")]
        MaxVertexTextureImageUnits = 0x8B4C,
        [NativeName("Name", "GL_MAX_TEXTURE_IMAGE_UNITS")]
        MaxTextureImageUnits = 0x8872,
        [NativeName("Name", "GL_MAX_FRAGMENT_UNIFORM_VECTORS")]
        MaxFragmentUniformVectors = 0x8DFD,
        [NativeName("Name", "GL_SHADER_TYPE")]
        ShaderType = 0x8B4F,
        [NativeName("Name", "GL_DELETE_STATUS")]
        DeleteStatus = 0x8B80,
        [NativeName("Name", "GL_LINK_STATUS")]
        LinkStatus = 0x8B82,
        [NativeName("Name", "GL_VALIDATE_STATUS")]
        ValidateStatus = 0x8B83,
        [NativeName("Name", "GL_ATTACHED_SHADERS")]
        AttachedShaders = 0x8B85,
        [NativeName("Name", "GL_ACTIVE_UNIFORMS")]
        ActiveUniforms = 0x8B86,
        [NativeName("Name", "GL_ACTIVE_UNIFORM_MAX_LENGTH")]
        ActiveUniformMaxLength = 0x8B87,
        [NativeName("Name", "GL_ACTIVE_ATTRIBUTES")]
        ActiveAttributes = 0x8B89,
        [NativeName("Name", "GL_ACTIVE_ATTRIBUTE_MAX_LENGTH")]
        ActiveAttributeMaxLength = 0x8B8A,
        [NativeName("Name", "GL_SHADING_LANGUAGE_VERSION")]
        ShadingLanguageVersion = 0x8B8C,
        [NativeName("Name", "GL_CURRENT_PROGRAM")]
        CurrentProgram = 0x8B8D,
        [NativeName("Name", "GL_NEVER")]
        Never = 0x200,
        [NativeName("Name", "GL_LESS")]
        Less = 0x201,
        [NativeName("Name", "GL_EQUAL")]
        Equal = 0x202,
        [NativeName("Name", "GL_LEQUAL")]
        Lequal = 0x203,
        [NativeName("Name", "GL_GREATER")]
        Greater = 0x204,
        [NativeName("Name", "GL_NOTEQUAL")]
        Notequal = 0x205,
        [NativeName("Name", "GL_GEQUAL")]
        Gequal = 0x206,
        [NativeName("Name", "GL_ALWAYS")]
        Always = 0x207,
        [NativeName("Name", "GL_KEEP")]
        Keep = 0x1E00,
        [NativeName("Name", "GL_REPLACE")]
        Replace = 0x1E01,
        [NativeName("Name", "GL_INCR")]
        Incr = 0x1E02,
        [NativeName("Name", "GL_DECR")]
        Decr = 0x1E03,
        [NativeName("Name", "GL_INVERT")]
        Invert = 0x150A,
        [NativeName("Name", "GL_INCR_WRAP")]
        IncrWrap = 0x8507,
        [NativeName("Name", "GL_DECR_WRAP")]
        DecrWrap = 0x8508,
        [NativeName("Name", "GL_VENDOR")]
        Vendor = 0x1F00,
        [NativeName("Name", "GL_RENDERER")]
        Renderer = 0x1F01,
        [NativeName("Name", "GL_VERSION")]
        Version = 0x1F02,
        [NativeName("Name", "GL_EXTENSIONS")]
        Extensions = 0x1F03,
        [NativeName("Name", "GL_NEAREST")]
        Nearest = 0x2600,
        [NativeName("Name", "GL_LINEAR")]
        Linear = 0x2601,
        [NativeName("Name", "GL_NEAREST_MIPMAP_NEAREST")]
        NearestMipmapNearest = 0x2700,
        [NativeName("Name", "GL_LINEAR_MIPMAP_NEAREST")]
        LinearMipmapNearest = 0x2701,
        [NativeName("Name", "GL_NEAREST_MIPMAP_LINEAR")]
        NearestMipmapLinear = 0x2702,
        [NativeName("Name", "GL_LINEAR_MIPMAP_LINEAR")]
        LinearMipmapLinear = 0x2703,
        [NativeName("Name", "GL_TEXTURE_MAG_FILTER")]
        TextureMagFilter = 0x2800,
        [NativeName("Name", "GL_TEXTURE_MIN_FILTER")]
        TextureMinFilter = 0x2801,
        [NativeName("Name", "GL_TEXTURE_WRAP_S")]
        TextureWrapS = 0x2802,
        [NativeName("Name", "GL_TEXTURE_WRAP_T")]
        TextureWrapT = 0x2803,
        [NativeName("Name", "GL_TEXTURE")]
        Texture = 0x1702,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP")]
        TextureCubeMap = 0x8513,
        [NativeName("Name", "GL_TEXTURE_BINDING_CUBE_MAP")]
        TextureBindingCubeMap = 0x8514,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_POSITIVE_X")]
        TextureCubeMapPositiveX = 0x8515,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_NEGATIVE_X")]
        TextureCubeMapNegativeX = 0x8516,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_POSITIVE_Y")]
        TextureCubeMapPositiveY = 0x8517,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_NEGATIVE_Y")]
        TextureCubeMapNegativeY = 0x8518,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_POSITIVE_Z")]
        TextureCubeMapPositiveZ = 0x8519,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_NEGATIVE_Z")]
        TextureCubeMapNegativeZ = 0x851A,
        [NativeName("Name", "GL_MAX_CUBE_MAP_TEXTURE_SIZE")]
        MaxCubeMapTextureSize = 0x851C,
        [NativeName("Name", "GL_TEXTURE0")]
        Texture0 = 0x84C0,
        [NativeName("Name", "GL_TEXTURE1")]
        Texture1 = 0x84C1,
        [NativeName("Name", "GL_TEXTURE2")]
        Texture2 = 0x84C2,
        [NativeName("Name", "GL_TEXTURE3")]
        Texture3 = 0x84C3,
        [NativeName("Name", "GL_TEXTURE4")]
        Texture4 = 0x84C4,
        [NativeName("Name", "GL_TEXTURE5")]
        Texture5 = 0x84C5,
        [NativeName("Name", "GL_TEXTURE6")]
        Texture6 = 0x84C6,
        [NativeName("Name", "GL_TEXTURE7")]
        Texture7 = 0x84C7,
        [NativeName("Name", "GL_TEXTURE8")]
        Texture8 = 0x84C8,
        [NativeName("Name", "GL_TEXTURE9")]
        Texture9 = 0x84C9,
        [NativeName("Name", "GL_TEXTURE10")]
        Texture10 = 0x84CA,
        [NativeName("Name", "GL_TEXTURE11")]
        Texture11 = 0x84CB,
        [NativeName("Name", "GL_TEXTURE12")]
        Texture12 = 0x84CC,
        [NativeName("Name", "GL_TEXTURE13")]
        Texture13 = 0x84CD,
        [NativeName("Name", "GL_TEXTURE14")]
        Texture14 = 0x84CE,
        [NativeName("Name", "GL_TEXTURE15")]
        Texture15 = 0x84CF,
        [NativeName("Name", "GL_TEXTURE16")]
        Texture16 = 0x84D0,
        [NativeName("Name", "GL_TEXTURE17")]
        Texture17 = 0x84D1,
        [NativeName("Name", "GL_TEXTURE18")]
        Texture18 = 0x84D2,
        [NativeName("Name", "GL_TEXTURE19")]
        Texture19 = 0x84D3,
        [NativeName("Name", "GL_TEXTURE20")]
        Texture20 = 0x84D4,
        [NativeName("Name", "GL_TEXTURE21")]
        Texture21 = 0x84D5,
        [NativeName("Name", "GL_TEXTURE22")]
        Texture22 = 0x84D6,
        [NativeName("Name", "GL_TEXTURE23")]
        Texture23 = 0x84D7,
        [NativeName("Name", "GL_TEXTURE24")]
        Texture24 = 0x84D8,
        [NativeName("Name", "GL_TEXTURE25")]
        Texture25 = 0x84D9,
        [NativeName("Name", "GL_TEXTURE26")]
        Texture26 = 0x84DA,
        [NativeName("Name", "GL_TEXTURE27")]
        Texture27 = 0x84DB,
        [NativeName("Name", "GL_TEXTURE28")]
        Texture28 = 0x84DC,
        [NativeName("Name", "GL_TEXTURE29")]
        Texture29 = 0x84DD,
        [NativeName("Name", "GL_TEXTURE30")]
        Texture30 = 0x84DE,
        [NativeName("Name", "GL_TEXTURE31")]
        Texture31 = 0x84DF,
        [NativeName("Name", "GL_ACTIVE_TEXTURE")]
        ActiveTexture = 0x84E0,
        [NativeName("Name", "GL_REPEAT")]
        Repeat = 0x2901,
        [NativeName("Name", "GL_CLAMP_TO_EDGE")]
        ClampToEdge = 0x812F,
        [NativeName("Name", "GL_MIRRORED_REPEAT")]
        MirroredRepeat = 0x8370,
        [NativeName("Name", "GL_FLOAT_VEC2")]
        FloatVec2 = 0x8B50,
        [NativeName("Name", "GL_FLOAT_VEC3")]
        FloatVec3 = 0x8B51,
        [NativeName("Name", "GL_FLOAT_VEC4")]
        FloatVec4 = 0x8B52,
        [NativeName("Name", "GL_INT_VEC2")]
        IntVec2 = 0x8B53,
        [NativeName("Name", "GL_INT_VEC3")]
        IntVec3 = 0x8B54,
        [NativeName("Name", "GL_INT_VEC4")]
        IntVec4 = 0x8B55,
        [NativeName("Name", "GL_BOOL")]
        Bool = 0x8B56,
        [NativeName("Name", "GL_BOOL_VEC2")]
        BoolVec2 = 0x8B57,
        [NativeName("Name", "GL_BOOL_VEC3")]
        BoolVec3 = 0x8B58,
        [NativeName("Name", "GL_BOOL_VEC4")]
        BoolVec4 = 0x8B59,
        [NativeName("Name", "GL_FLOAT_MAT2")]
        FloatMat2 = 0x8B5A,
        [NativeName("Name", "GL_FLOAT_MAT3")]
        FloatMat3 = 0x8B5B,
        [NativeName("Name", "GL_FLOAT_MAT4")]
        FloatMat4 = 0x8B5C,
        [NativeName("Name", "GL_SAMPLER_2D")]
        Sampler2D = 0x8B5E,
        [NativeName("Name", "GL_SAMPLER_CUBE")]
        SamplerCube = 0x8B60,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_ENABLED")]
        VertexAttribArrayEnabled = 0x8622,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_SIZE")]
        VertexAttribArraySize = 0x8623,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_STRIDE")]
        VertexAttribArrayStride = 0x8624,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_TYPE")]
        VertexAttribArrayType = 0x8625,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_NORMALIZED")]
        VertexAttribArrayNormalized = 0x886A,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_POINTER")]
        VertexAttribArrayPointer = 0x8645,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING")]
        VertexAttribArrayBufferBinding = 0x889F,
        [NativeName("Name", "GL_IMPLEMENTATION_COLOR_READ_TYPE")]
        ImplementationColorReadType = 0x8B9A,
        [NativeName("Name", "GL_IMPLEMENTATION_COLOR_READ_FORMAT")]
        ImplementationColorReadFormat = 0x8B9B,
        [NativeName("Name", "GL_COMPILE_STATUS")]
        CompileStatus = 0x8B81,
        [NativeName("Name", "GL_INFO_LOG_LENGTH")]
        InfoLogLength = 0x8B84,
        [NativeName("Name", "GL_SHADER_SOURCE_LENGTH")]
        ShaderSourceLength = 0x8B88,
        [NativeName("Name", "GL_SHADER_COMPILER")]
        ShaderCompiler = 0x8DFA,
        [NativeName("Name", "GL_SHADER_BINARY_FORMATS")]
        ShaderBinaryFormats = 0x8DF8,
        [NativeName("Name", "GL_NUM_SHADER_BINARY_FORMATS")]
        NumShaderBinaryFormats = 0x8DF9,
        [NativeName("Name", "GL_LOW_FLOAT")]
        LowFloat = 0x8DF0,
        [NativeName("Name", "GL_MEDIUM_FLOAT")]
        MediumFloat = 0x8DF1,
        [NativeName("Name", "GL_HIGH_FLOAT")]
        HighFloat = 0x8DF2,
        [NativeName("Name", "GL_LOW_INT")]
        LowInt = 0x8DF3,
        [NativeName("Name", "GL_MEDIUM_INT")]
        MediumInt = 0x8DF4,
        [NativeName("Name", "GL_HIGH_INT")]
        HighInt = 0x8DF5,
        [NativeName("Name", "GL_FRAMEBUFFER")]
        Framebuffer = 0x8D40,
        [NativeName("Name", "GL_RENDERBUFFER")]
        Renderbuffer = 0x8D41,
        [NativeName("Name", "GL_RGBA4")]
        Rgba4 = 0x8056,
        [NativeName("Name", "GL_RGB5_A1")]
        Rgb5A1 = 0x8057,
        [NativeName("Name", "GL_RGB565")]
        Rgb565 = 0x8D62,
        [NativeName("Name", "GL_DEPTH_COMPONENT16")]
        DepthComponent16 = 0x81A5,
        [NativeName("Name", "GL_STENCIL_INDEX8")]
        StencilIndex8 = 0x8D48,
        [NativeName("Name", "GL_RENDERBUFFER_WIDTH")]
        RenderbufferWidth = 0x8D42,
        [NativeName("Name", "GL_RENDERBUFFER_HEIGHT")]
        RenderbufferHeight = 0x8D43,
        [NativeName("Name", "GL_RENDERBUFFER_INTERNAL_FORMAT")]
        RenderbufferInternalFormat = 0x8D44,
        [NativeName("Name", "GL_RENDERBUFFER_RED_SIZE")]
        RenderbufferRedSize = 0x8D50,
        [NativeName("Name", "GL_RENDERBUFFER_GREEN_SIZE")]
        RenderbufferGreenSize = 0x8D51,
        [NativeName("Name", "GL_RENDERBUFFER_BLUE_SIZE")]
        RenderbufferBlueSize = 0x8D52,
        [NativeName("Name", "GL_RENDERBUFFER_ALPHA_SIZE")]
        RenderbufferAlphaSize = 0x8D53,
        [NativeName("Name", "GL_RENDERBUFFER_DEPTH_SIZE")]
        RenderbufferDepthSize = 0x8D54,
        [NativeName("Name", "GL_RENDERBUFFER_STENCIL_SIZE")]
        RenderbufferStencilSize = 0x8D55,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE")]
        FramebufferAttachmentObjectType = 0x8CD0,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME")]
        FramebufferAttachmentObjectName = 0x8CD1,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL")]
        FramebufferAttachmentTextureLevel = 0x8CD2,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE")]
        FramebufferAttachmentTextureCubeMapFace = 0x8CD3,
        [NativeName("Name", "GL_COLOR_ATTACHMENT0")]
        ColorAttachment0 = 0x8CE0,
        [NativeName("Name", "GL_DEPTH_ATTACHMENT")]
        DepthAttachment = 0x8D00,
        [NativeName("Name", "GL_STENCIL_ATTACHMENT")]
        StencilAttachment = 0x8D20,
        [NativeName("Name", "GL_NONE")]
        None = 0x0,
        [NativeName("Name", "GL_FRAMEBUFFER_COMPLETE")]
        FramebufferComplete = 0x8CD5,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT")]
        FramebufferIncompleteAttachment = 0x8CD6,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT")]
        FramebufferIncompleteMissingAttachment = 0x8CD7,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS")]
        FramebufferIncompleteDimensions = 0x8CD9,
        [NativeName("Name", "GL_FRAMEBUFFER_UNSUPPORTED")]
        FramebufferUnsupported = 0x8CDD,
        [NativeName("Name", "GL_FRAMEBUFFER_BINDING")]
        FramebufferBinding = 0x8CA6,
        [NativeName("Name", "GL_RENDERBUFFER_BINDING")]
        RenderbufferBinding = 0x8CA7,
        [NativeName("Name", "GL_MAX_RENDERBUFFER_SIZE")]
        MaxRenderbufferSize = 0x84E8,
        [NativeName("Name", "GL_INVALID_FRAMEBUFFER_OPERATION")]
        InvalidFramebufferOperation = 0x506,
        [NativeName("Name", "GL_READ_BUFFER")]
        ReadBuffer = 0xC02,
        [NativeName("Name", "GL_UNPACK_ROW_LENGTH")]
        UnpackRowLength = 0xCF2,
        [NativeName("Name", "GL_UNPACK_SKIP_ROWS")]
        UnpackSkipRows = 0xCF3,
        [NativeName("Name", "GL_UNPACK_SKIP_PIXELS")]
        UnpackSkipPixels = 0xCF4,
        [NativeName("Name", "GL_PACK_ROW_LENGTH")]
        PackRowLength = 0xD02,
        [NativeName("Name", "GL_PACK_SKIP_ROWS")]
        PackSkipRows = 0xD03,
        [NativeName("Name", "GL_PACK_SKIP_PIXELS")]
        PackSkipPixels = 0xD04,
        [NativeName("Name", "GL_COLOR")]
        Color = 0x1800,
        [NativeName("Name", "GL_DEPTH")]
        Depth = 0x1801,
        [NativeName("Name", "GL_STENCIL")]
        Stencil = 0x1802,
        [NativeName("Name", "GL_RED")]
        Red = 0x1903,
        [NativeName("Name", "GL_RGB8")]
        Rgb8 = 0x8051,
        [NativeName("Name", "GL_RGBA8")]
        Rgba8 = 0x8058,
        [NativeName("Name", "GL_RGB10_A2")]
        Rgb10A2 = 0x8059,
        [NativeName("Name", "GL_TEXTURE_BINDING_3D")]
        TextureBinding3D = 0x806A,
        [NativeName("Name", "GL_UNPACK_SKIP_IMAGES")]
        UnpackSkipImages = 0x806D,
        [NativeName("Name", "GL_UNPACK_IMAGE_HEIGHT")]
        UnpackImageHeight = 0x806E,
        [NativeName("Name", "GL_TEXTURE_3D")]
        Texture3D = 0x806F,
        [NativeName("Name", "GL_TEXTURE_WRAP_R")]
        TextureWrapR = 0x8072,
        [NativeName("Name", "GL_MAX_3D_TEXTURE_SIZE")]
        Max3DTextureSize = 0x8073,
        [NativeName("Name", "GL_UNSIGNED_INT_2_10_10_10_REV")]
        UnsignedInt2101010Rev = 0x8368,
        [NativeName("Name", "GL_MAX_ELEMENTS_VERTICES")]
        MaxElementsVertices = 0x80E8,
        [NativeName("Name", "GL_MAX_ELEMENTS_INDICES")]
        MaxElementsIndices = 0x80E9,
        [NativeName("Name", "GL_TEXTURE_MIN_LOD")]
        TextureMinLod = 0x813A,
        [NativeName("Name", "GL_TEXTURE_MAX_LOD")]
        TextureMaxLod = 0x813B,
        [NativeName("Name", "GL_TEXTURE_BASE_LEVEL")]
        TextureBaseLevel = 0x813C,
        [NativeName("Name", "GL_TEXTURE_MAX_LEVEL")]
        TextureMaxLevel = 0x813D,
        [NativeName("Name", "GL_MIN")]
        Min = 0x8007,
        [NativeName("Name", "GL_MAX")]
        Max = 0x8008,
        [NativeName("Name", "GL_DEPTH_COMPONENT24")]
        DepthComponent24 = 0x81A6,
        [NativeName("Name", "GL_MAX_TEXTURE_LOD_BIAS")]
        MaxTextureLodBias = 0x84FD,
        [NativeName("Name", "GL_TEXTURE_COMPARE_MODE")]
        TextureCompareMode = 0x884C,
        [NativeName("Name", "GL_TEXTURE_COMPARE_FUNC")]
        TextureCompareFunc = 0x884D,
        [NativeName("Name", "GL_CURRENT_QUERY")]
        CurrentQuery = 0x8865,
        [NativeName("Name", "GL_QUERY_RESULT")]
        QueryResult = 0x8866,
        [NativeName("Name", "GL_QUERY_RESULT_AVAILABLE")]
        QueryResultAvailable = 0x8867,
        [NativeName("Name", "GL_BUFFER_MAPPED")]
        BufferMapped = 0x88BC,
        [NativeName("Name", "GL_BUFFER_MAP_POINTER")]
        BufferMapPointer = 0x88BD,
        [NativeName("Name", "GL_STREAM_READ")]
        StreamRead = 0x88E1,
        [NativeName("Name", "GL_STREAM_COPY")]
        StreamCopy = 0x88E2,
        [NativeName("Name", "GL_STATIC_READ")]
        StaticRead = 0x88E5,
        [NativeName("Name", "GL_STATIC_COPY")]
        StaticCopy = 0x88E6,
        [NativeName("Name", "GL_DYNAMIC_READ")]
        DynamicRead = 0x88E9,
        [NativeName("Name", "GL_DYNAMIC_COPY")]
        DynamicCopy = 0x88EA,
        [NativeName("Name", "GL_MAX_DRAW_BUFFERS")]
        MaxDrawBuffers = 0x8824,
        [NativeName("Name", "GL_DRAW_BUFFER0")]
        DrawBuffer0 = 0x8825,
        [NativeName("Name", "GL_DRAW_BUFFER1")]
        DrawBuffer1 = 0x8826,
        [NativeName("Name", "GL_DRAW_BUFFER2")]
        DrawBuffer2 = 0x8827,
        [NativeName("Name", "GL_DRAW_BUFFER3")]
        DrawBuffer3 = 0x8828,
        [NativeName("Name", "GL_DRAW_BUFFER4")]
        DrawBuffer4 = 0x8829,
        [NativeName("Name", "GL_DRAW_BUFFER5")]
        DrawBuffer5 = 0x882A,
        [NativeName("Name", "GL_DRAW_BUFFER6")]
        DrawBuffer6 = 0x882B,
        [NativeName("Name", "GL_DRAW_BUFFER7")]
        DrawBuffer7 = 0x882C,
        [NativeName("Name", "GL_DRAW_BUFFER8")]
        DrawBuffer8 = 0x882D,
        [NativeName("Name", "GL_DRAW_BUFFER9")]
        DrawBuffer9 = 0x882E,
        [NativeName("Name", "GL_DRAW_BUFFER10")]
        DrawBuffer10 = 0x882F,
        [NativeName("Name", "GL_DRAW_BUFFER11")]
        DrawBuffer11 = 0x8830,
        [NativeName("Name", "GL_DRAW_BUFFER12")]
        DrawBuffer12 = 0x8831,
        [NativeName("Name", "GL_DRAW_BUFFER13")]
        DrawBuffer13 = 0x8832,
        [NativeName("Name", "GL_DRAW_BUFFER14")]
        DrawBuffer14 = 0x8833,
        [NativeName("Name", "GL_DRAW_BUFFER15")]
        DrawBuffer15 = 0x8834,
        [NativeName("Name", "GL_MAX_FRAGMENT_UNIFORM_COMPONENTS")]
        MaxFragmentUniformComponents = 0x8B49,
        [NativeName("Name", "GL_MAX_VERTEX_UNIFORM_COMPONENTS")]
        MaxVertexUniformComponents = 0x8B4A,
        [NativeName("Name", "GL_SAMPLER_3D")]
        Sampler3D = 0x8B5F,
        [NativeName("Name", "GL_SAMPLER_2D_SHADOW")]
        Sampler2DShadow = 0x8B62,
        [NativeName("Name", "GL_FRAGMENT_SHADER_DERIVATIVE_HINT")]
        FragmentShaderDerivativeHint = 0x8B8B,
        [NativeName("Name", "GL_PIXEL_PACK_BUFFER")]
        PixelPackBuffer = 0x88EB,
        [NativeName("Name", "GL_PIXEL_UNPACK_BUFFER")]
        PixelUnpackBuffer = 0x88EC,
        [NativeName("Name", "GL_PIXEL_PACK_BUFFER_BINDING")]
        PixelPackBufferBinding = 0x88ED,
        [NativeName("Name", "GL_PIXEL_UNPACK_BUFFER_BINDING")]
        PixelUnpackBufferBinding = 0x88EF,
        [NativeName("Name", "GL_FLOAT_MAT2x3")]
        FloatMat2x3 = 0x8B65,
        [NativeName("Name", "GL_FLOAT_MAT2x4")]
        FloatMat2x4 = 0x8B66,
        [NativeName("Name", "GL_FLOAT_MAT3x2")]
        FloatMat3x2 = 0x8B67,
        [NativeName("Name", "GL_FLOAT_MAT3x4")]
        FloatMat3x4 = 0x8B68,
        [NativeName("Name", "GL_FLOAT_MAT4x2")]
        FloatMat4x2 = 0x8B69,
        [NativeName("Name", "GL_FLOAT_MAT4x3")]
        FloatMat4x3 = 0x8B6A,
        [NativeName("Name", "GL_SRGB")]
        Srgb = 0x8C40,
        [NativeName("Name", "GL_SRGB8")]
        Srgb8 = 0x8C41,
        [NativeName("Name", "GL_SRGB8_ALPHA8")]
        Srgb8Alpha8 = 0x8C43,
        [NativeName("Name", "GL_COMPARE_REF_TO_TEXTURE")]
        CompareRefToTexture = 0x884E,
        [NativeName("Name", "GL_MAJOR_VERSION")]
        MajorVersion = 0x821B,
        [NativeName("Name", "GL_MINOR_VERSION")]
        MinorVersion = 0x821C,
        [NativeName("Name", "GL_NUM_EXTENSIONS")]
        NumExtensions = 0x821D,
        [NativeName("Name", "GL_RGBA32F")]
        Rgba32f = 0x8814,
        [NativeName("Name", "GL_RGB32F")]
        Rgb32f = 0x8815,
        [NativeName("Name", "GL_RGBA16F")]
        Rgba16f = 0x881A,
        [NativeName("Name", "GL_RGB16F")]
        Rgb16f = 0x881B,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_INTEGER")]
        VertexAttribArrayInteger = 0x88FD,
        [NativeName("Name", "GL_MAX_ARRAY_TEXTURE_LAYERS")]
        MaxArrayTextureLayers = 0x88FF,
        [NativeName("Name", "GL_MIN_PROGRAM_TEXEL_OFFSET")]
        MinProgramTexelOffset = 0x8904,
        [NativeName("Name", "GL_MAX_PROGRAM_TEXEL_OFFSET")]
        MaxProgramTexelOffset = 0x8905,
        [NativeName("Name", "GL_MAX_VARYING_COMPONENTS")]
        MaxVaryingComponents = 0x8B4B,
        [NativeName("Name", "GL_TEXTURE_2D_ARRAY")]
        Texture2DArray = 0x8C1A,
        [NativeName("Name", "GL_TEXTURE_BINDING_2D_ARRAY")]
        TextureBinding2DArray = 0x8C1D,
        [NativeName("Name", "GL_R11F_G11F_B10F")]
        R11fG11fB10f = 0x8C3A,
        [NativeName("Name", "GL_UNSIGNED_INT_10F_11F_11F_REV")]
        UnsignedInt10f11f11fRev = 0x8C3B,
        [NativeName("Name", "GL_RGB9_E5")]
        Rgb9E5 = 0x8C3D,
        [NativeName("Name", "GL_UNSIGNED_INT_5_9_9_9_REV")]
        UnsignedInt5999Rev = 0x8C3E,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH")]
        TransformFeedbackVaryingMaxLength = 0x8C76,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_MODE")]
        TransformFeedbackBufferMode = 0x8C7F,
        [NativeName("Name", "GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS")]
        MaxTransformFeedbackSeparateComponents = 0x8C80,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_VARYINGS")]
        TransformFeedbackVaryings = 0x8C83,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_START")]
        TransformFeedbackBufferStart = 0x8C84,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_SIZE")]
        TransformFeedbackBufferSize = 0x8C85,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN")]
        TransformFeedbackPrimitivesWritten = 0x8C88,
        [NativeName("Name", "GL_RASTERIZER_DISCARD")]
        RasterizerDiscard = 0x8C89,
        [NativeName("Name", "GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS")]
        MaxTransformFeedbackInterleavedComponents = 0x8C8A,
        [NativeName("Name", "GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS")]
        MaxTransformFeedbackSeparateAttribs = 0x8C8B,
        [NativeName("Name", "GL_INTERLEAVED_ATTRIBS")]
        InterleavedAttribs = 0x8C8C,
        [NativeName("Name", "GL_SEPARATE_ATTRIBS")]
        SeparateAttribs = 0x8C8D,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER")]
        TransformFeedbackBuffer = 0x8C8E,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_BINDING")]
        TransformFeedbackBufferBinding = 0x8C8F,
        [NativeName("Name", "GL_RGBA32UI")]
        Rgba32ui = 0x8D70,
        [NativeName("Name", "GL_RGB32UI")]
        Rgb32ui = 0x8D71,
        [NativeName("Name", "GL_RGBA16UI")]
        Rgba16ui = 0x8D76,
        [NativeName("Name", "GL_RGB16UI")]
        Rgb16ui = 0x8D77,
        [NativeName("Name", "GL_RGBA8UI")]
        Rgba8ui = 0x8D7C,
        [NativeName("Name", "GL_RGB8UI")]
        Rgb8ui = 0x8D7D,
        [NativeName("Name", "GL_RGBA32I")]
        Rgba32i = 0x8D82,
        [NativeName("Name", "GL_RGB32I")]
        Rgb32i = 0x8D83,
        [NativeName("Name", "GL_RGBA16I")]
        Rgba16i = 0x8D88,
        [NativeName("Name", "GL_RGB16I")]
        Rgb16i = 0x8D89,
        [NativeName("Name", "GL_RGBA8I")]
        Rgba8i = 0x8D8E,
        [NativeName("Name", "GL_RGB8I")]
        Rgb8i = 0x8D8F,
        [NativeName("Name", "GL_RED_INTEGER")]
        RedInteger = 0x8D94,
        [NativeName("Name", "GL_RGB_INTEGER")]
        RgbInteger = 0x8D98,
        [NativeName("Name", "GL_RGBA_INTEGER")]
        RgbaInteger = 0x8D99,
        [NativeName("Name", "GL_SAMPLER_2D_ARRAY")]
        Sampler2DArray = 0x8DC1,
        [NativeName("Name", "GL_SAMPLER_2D_ARRAY_SHADOW")]
        Sampler2DArrayShadow = 0x8DC4,
        [NativeName("Name", "GL_SAMPLER_CUBE_SHADOW")]
        SamplerCubeShadow = 0x8DC5,
        [NativeName("Name", "GL_UNSIGNED_INT_VEC2")]
        UnsignedIntVec2 = 0x8DC6,
        [NativeName("Name", "GL_UNSIGNED_INT_VEC3")]
        UnsignedIntVec3 = 0x8DC7,
        [NativeName("Name", "GL_UNSIGNED_INT_VEC4")]
        UnsignedIntVec4 = 0x8DC8,
        [NativeName("Name", "GL_INT_SAMPLER_2D")]
        IntSampler2D = 0x8DCA,
        [NativeName("Name", "GL_INT_SAMPLER_3D")]
        IntSampler3D = 0x8DCB,
        [NativeName("Name", "GL_INT_SAMPLER_CUBE")]
        IntSamplerCube = 0x8DCC,
        [NativeName("Name", "GL_INT_SAMPLER_2D_ARRAY")]
        IntSampler2DArray = 0x8DCF,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_2D")]
        UnsignedIntSampler2D = 0x8DD2,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_3D")]
        UnsignedIntSampler3D = 0x8DD3,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_CUBE")]
        UnsignedIntSamplerCube = 0x8DD4,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_2D_ARRAY")]
        UnsignedIntSampler2DArray = 0x8DD7,
        [NativeName("Name", "GL_BUFFER_ACCESS_FLAGS")]
        BufferAccessFlags = 0x911F,
        [NativeName("Name", "GL_BUFFER_MAP_LENGTH")]
        BufferMapLength = 0x9120,
        [NativeName("Name", "GL_BUFFER_MAP_OFFSET")]
        BufferMapOffset = 0x9121,
        [NativeName("Name", "GL_DEPTH_COMPONENT32F")]
        DepthComponent32f = 0x8CAC,
        [NativeName("Name", "GL_DEPTH32F_STENCIL8")]
        Depth32fStencil8 = 0x8CAD,
        [NativeName("Name", "GL_FLOAT_32_UNSIGNED_INT_24_8_REV")]
        Float32UnsignedInt248Rev = 0x8DAD,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING")]
        FramebufferAttachmentColorEncoding = 0x8210,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE")]
        FramebufferAttachmentComponentType = 0x8211,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE")]
        FramebufferAttachmentRedSize = 0x8212,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE")]
        FramebufferAttachmentGreenSize = 0x8213,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE")]
        FramebufferAttachmentBlueSize = 0x8214,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE")]
        FramebufferAttachmentAlphaSize = 0x8215,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE")]
        FramebufferAttachmentDepthSize = 0x8216,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE")]
        FramebufferAttachmentStencilSize = 0x8217,
        [NativeName("Name", "GL_FRAMEBUFFER_DEFAULT")]
        FramebufferDefault = 0x8218,
        [NativeName("Name", "GL_FRAMEBUFFER_UNDEFINED")]
        FramebufferUndefined = 0x8219,
        [NativeName("Name", "GL_DEPTH_STENCIL_ATTACHMENT")]
        DepthStencilAttachment = 0x821A,
        [NativeName("Name", "GL_DEPTH_STENCIL")]
        DepthStencil = 0x84F9,
        [NativeName("Name", "GL_UNSIGNED_INT_24_8")]
        UnsignedInt248 = 0x84FA,
        [NativeName("Name", "GL_DEPTH24_STENCIL8")]
        Depth24Stencil8 = 0x88F0,
        [NativeName("Name", "GL_UNSIGNED_NORMALIZED")]
        UnsignedNormalized = 0x8C17,
        [NativeName("Name", "GL_DRAW_FRAMEBUFFER_BINDING")]
        DrawFramebufferBinding = 0x8CA6,
        [NativeName("Name", "GL_READ_FRAMEBUFFER")]
        ReadFramebuffer = 0x8CA8,
        [NativeName("Name", "GL_DRAW_FRAMEBUFFER")]
        DrawFramebuffer = 0x8CA9,
        [NativeName("Name", "GL_READ_FRAMEBUFFER_BINDING")]
        ReadFramebufferBinding = 0x8CAA,
        [NativeName("Name", "GL_RENDERBUFFER_SAMPLES")]
        RenderbufferSamples = 0x8CAB,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER")]
        FramebufferAttachmentTextureLayer = 0x8CD4,
        [NativeName("Name", "GL_MAX_COLOR_ATTACHMENTS")]
        MaxColorAttachments = 0x8CDF,
        [NativeName("Name", "GL_COLOR_ATTACHMENT1")]
        ColorAttachment1 = 0x8CE1,
        [NativeName("Name", "GL_COLOR_ATTACHMENT2")]
        ColorAttachment2 = 0x8CE2,
        [NativeName("Name", "GL_COLOR_ATTACHMENT3")]
        ColorAttachment3 = 0x8CE3,
        [NativeName("Name", "GL_COLOR_ATTACHMENT4")]
        ColorAttachment4 = 0x8CE4,
        [NativeName("Name", "GL_COLOR_ATTACHMENT5")]
        ColorAttachment5 = 0x8CE5,
        [NativeName("Name", "GL_COLOR_ATTACHMENT6")]
        ColorAttachment6 = 0x8CE6,
        [NativeName("Name", "GL_COLOR_ATTACHMENT7")]
        ColorAttachment7 = 0x8CE7,
        [NativeName("Name", "GL_COLOR_ATTACHMENT8")]
        ColorAttachment8 = 0x8CE8,
        [NativeName("Name", "GL_COLOR_ATTACHMENT9")]
        ColorAttachment9 = 0x8CE9,
        [NativeName("Name", "GL_COLOR_ATTACHMENT10")]
        ColorAttachment10 = 0x8CEA,
        [NativeName("Name", "GL_COLOR_ATTACHMENT11")]
        ColorAttachment11 = 0x8CEB,
        [NativeName("Name", "GL_COLOR_ATTACHMENT12")]
        ColorAttachment12 = 0x8CEC,
        [NativeName("Name", "GL_COLOR_ATTACHMENT13")]
        ColorAttachment13 = 0x8CED,
        [NativeName("Name", "GL_COLOR_ATTACHMENT14")]
        ColorAttachment14 = 0x8CEE,
        [NativeName("Name", "GL_COLOR_ATTACHMENT15")]
        ColorAttachment15 = 0x8CEF,
        [NativeName("Name", "GL_COLOR_ATTACHMENT16")]
        ColorAttachment16 = 0x8CF0,
        [NativeName("Name", "GL_COLOR_ATTACHMENT17")]
        ColorAttachment17 = 0x8CF1,
        [NativeName("Name", "GL_COLOR_ATTACHMENT18")]
        ColorAttachment18 = 0x8CF2,
        [NativeName("Name", "GL_COLOR_ATTACHMENT19")]
        ColorAttachment19 = 0x8CF3,
        [NativeName("Name", "GL_COLOR_ATTACHMENT20")]
        ColorAttachment20 = 0x8CF4,
        [NativeName("Name", "GL_COLOR_ATTACHMENT21")]
        ColorAttachment21 = 0x8CF5,
        [NativeName("Name", "GL_COLOR_ATTACHMENT22")]
        ColorAttachment22 = 0x8CF6,
        [NativeName("Name", "GL_COLOR_ATTACHMENT23")]
        ColorAttachment23 = 0x8CF7,
        [NativeName("Name", "GL_COLOR_ATTACHMENT24")]
        ColorAttachment24 = 0x8CF8,
        [NativeName("Name", "GL_COLOR_ATTACHMENT25")]
        ColorAttachment25 = 0x8CF9,
        [NativeName("Name", "GL_COLOR_ATTACHMENT26")]
        ColorAttachment26 = 0x8CFA,
        [NativeName("Name", "GL_COLOR_ATTACHMENT27")]
        ColorAttachment27 = 0x8CFB,
        [NativeName("Name", "GL_COLOR_ATTACHMENT28")]
        ColorAttachment28 = 0x8CFC,
        [NativeName("Name", "GL_COLOR_ATTACHMENT29")]
        ColorAttachment29 = 0x8CFD,
        [NativeName("Name", "GL_COLOR_ATTACHMENT30")]
        ColorAttachment30 = 0x8CFE,
        [NativeName("Name", "GL_COLOR_ATTACHMENT31")]
        ColorAttachment31 = 0x8CFF,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE")]
        FramebufferIncompleteMultisample = 0x8D56,
        [NativeName("Name", "GL_MAX_SAMPLES")]
        MaxSamples = 0x8D57,
        [NativeName("Name", "GL_HALF_FLOAT")]
        HalfFloat = 0x140B,
        [NativeName("Name", "GL_MAP_READ_BIT")]
        MapReadBit = 0x1,
        [NativeName("Name", "GL_MAP_WRITE_BIT")]
        MapWriteBit = 0x2,
        [NativeName("Name", "GL_MAP_INVALIDATE_RANGE_BIT")]
        MapInvalidateRangeBit = 0x4,
        [NativeName("Name", "GL_MAP_INVALIDATE_BUFFER_BIT")]
        MapInvalidateBufferBit = 0x8,
        [NativeName("Name", "GL_MAP_FLUSH_EXPLICIT_BIT")]
        MapFlushExplicitBit = 0x10,
        [NativeName("Name", "GL_MAP_UNSYNCHRONIZED_BIT")]
        MapUnsynchronizedBit = 0x20,
        [NativeName("Name", "GL_RG")]
        RG = 0x8227,
        [NativeName("Name", "GL_RG_INTEGER")]
        RGInteger = 0x8228,
        [NativeName("Name", "GL_R8")]
        R8 = 0x8229,
        [NativeName("Name", "GL_RG8")]
        RG8 = 0x822B,
        [NativeName("Name", "GL_R16F")]
        R16f = 0x822D,
        [NativeName("Name", "GL_R32F")]
        R32f = 0x822E,
        [NativeName("Name", "GL_RG16F")]
        RG16f = 0x822F,
        [NativeName("Name", "GL_RG32F")]
        RG32f = 0x8230,
        [NativeName("Name", "GL_R8I")]
        R8i = 0x8231,
        [NativeName("Name", "GL_R8UI")]
        R8ui = 0x8232,
        [NativeName("Name", "GL_R16I")]
        R16i = 0x8233,
        [NativeName("Name", "GL_R16UI")]
        R16ui = 0x8234,
        [NativeName("Name", "GL_R32I")]
        R32i = 0x8235,
        [NativeName("Name", "GL_R32UI")]
        R32ui = 0x8236,
        [NativeName("Name", "GL_RG8I")]
        RG8i = 0x8237,
        [NativeName("Name", "GL_RG8UI")]
        RG8ui = 0x8238,
        [NativeName("Name", "GL_RG16I")]
        RG16i = 0x8239,
        [NativeName("Name", "GL_RG16UI")]
        RG16ui = 0x823A,
        [NativeName("Name", "GL_RG32I")]
        RG32i = 0x823B,
        [NativeName("Name", "GL_RG32UI")]
        RG32ui = 0x823C,
        [NativeName("Name", "GL_VERTEX_ARRAY_BINDING")]
        VertexArrayBinding = 0x85B5,
        [NativeName("Name", "GL_R8_SNORM")]
        R8SNorm = 0x8F94,
        [NativeName("Name", "GL_RG8_SNORM")]
        RG8SNorm = 0x8F95,
        [NativeName("Name", "GL_RGB8_SNORM")]
        Rgb8SNorm = 0x8F96,
        [NativeName("Name", "GL_RGBA8_SNORM")]
        Rgba8SNorm = 0x8F97,
        [NativeName("Name", "GL_SIGNED_NORMALIZED")]
        SignedNormalized = 0x8F9C,
        [NativeName("Name", "GL_PRIMITIVE_RESTART_FIXED_INDEX")]
        PrimitiveRestartFixedIndex = 0x8D69,
        [NativeName("Name", "GL_COPY_READ_BUFFER")]
        CopyReadBuffer = 0x8F36,
        [NativeName("Name", "GL_COPY_WRITE_BUFFER")]
        CopyWriteBuffer = 0x8F37,
        [NativeName("Name", "GL_COPY_READ_BUFFER_BINDING")]
        CopyReadBufferBinding = 0x8F36,
        [NativeName("Name", "GL_COPY_WRITE_BUFFER_BINDING")]
        CopyWriteBufferBinding = 0x8F37,
        [NativeName("Name", "GL_UNIFORM_BUFFER")]
        UniformBuffer = 0x8A11,
        [NativeName("Name", "GL_UNIFORM_BUFFER_BINDING")]
        UniformBufferBinding = 0x8A28,
        [NativeName("Name", "GL_UNIFORM_BUFFER_START")]
        UniformBufferStart = 0x8A29,
        [NativeName("Name", "GL_UNIFORM_BUFFER_SIZE")]
        UniformBufferSize = 0x8A2A,
        [NativeName("Name", "GL_MAX_VERTEX_UNIFORM_BLOCKS")]
        MaxVertexUniformBlocks = 0x8A2B,
        [NativeName("Name", "GL_MAX_FRAGMENT_UNIFORM_BLOCKS")]
        MaxFragmentUniformBlocks = 0x8A2D,
        [NativeName("Name", "GL_MAX_COMBINED_UNIFORM_BLOCKS")]
        MaxCombinedUniformBlocks = 0x8A2E,
        [NativeName("Name", "GL_MAX_UNIFORM_BUFFER_BINDINGS")]
        MaxUniformBufferBindings = 0x8A2F,
        [NativeName("Name", "GL_MAX_UNIFORM_BLOCK_SIZE")]
        MaxUniformBlockSize = 0x8A30,
        [NativeName("Name", "GL_MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS")]
        MaxCombinedVertexUniformComponents = 0x8A31,
        [NativeName("Name", "GL_MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS")]
        MaxCombinedFragmentUniformComponents = 0x8A33,
        [NativeName("Name", "GL_UNIFORM_BUFFER_OFFSET_ALIGNMENT")]
        UniformBufferOffsetAlignment = 0x8A34,
        [NativeName("Name", "GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH")]
        ActiveUniformBlockMaxNameLength = 0x8A35,
        [NativeName("Name", "GL_ACTIVE_UNIFORM_BLOCKS")]
        ActiveUniformBlocks = 0x8A36,
        [NativeName("Name", "GL_UNIFORM_TYPE")]
        UniformType = 0x8A37,
        [NativeName("Name", "GL_UNIFORM_SIZE")]
        UniformSize = 0x8A38,
        [NativeName("Name", "GL_UNIFORM_NAME_LENGTH")]
        UniformNameLength = 0x8A39,
        [NativeName("Name", "GL_UNIFORM_BLOCK_INDEX")]
        UniformBlockIndex = 0x8A3A,
        [NativeName("Name", "GL_UNIFORM_OFFSET")]
        UniformOffset = 0x8A3B,
        [NativeName("Name", "GL_UNIFORM_ARRAY_STRIDE")]
        UniformArrayStride = 0x8A3C,
        [NativeName("Name", "GL_UNIFORM_MATRIX_STRIDE")]
        UniformMatrixStride = 0x8A3D,
        [NativeName("Name", "GL_UNIFORM_IS_ROW_MAJOR")]
        UniformIsRowMajor = 0x8A3E,
        [NativeName("Name", "GL_UNIFORM_BLOCK_BINDING")]
        UniformBlockBinding = 0x8A3F,
        [NativeName("Name", "GL_UNIFORM_BLOCK_DATA_SIZE")]
        UniformBlockDataSize = 0x8A40,
        [NativeName("Name", "GL_UNIFORM_BLOCK_NAME_LENGTH")]
        UniformBlockNameLength = 0x8A41,
        [NativeName("Name", "GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS")]
        UniformBlockActiveUniforms = 0x8A42,
        [NativeName("Name", "GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES")]
        UniformBlockActiveUniformIndices = 0x8A43,
        [NativeName("Name", "GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER")]
        UniformBlockReferencedByVertexShader = 0x8A44,
        [NativeName("Name", "GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER")]
        UniformBlockReferencedByFragmentShader = 0x8A46,
        [NativeName("Name", "GL_INVALID_INDEX")]
        InvalidIndex = unchecked((int)0xFFFFFFFF),
        [NativeName("Name", "GL_MAX_VERTEX_OUTPUT_COMPONENTS")]
        MaxVertexOutputComponents = 0x9122,
        [NativeName("Name", "GL_MAX_FRAGMENT_INPUT_COMPONENTS")]
        MaxFragmentInputComponents = 0x9125,
        [NativeName("Name", "GL_MAX_SERVER_WAIT_TIMEOUT")]
        MaxServerWaitTimeout = 0x9111,
        [NativeName("Name", "GL_OBJECT_TYPE")]
        ObjectType = 0x9112,
        [NativeName("Name", "GL_SYNC_CONDITION")]
        SyncCondition = 0x9113,
        [NativeName("Name", "GL_SYNC_STATUS")]
        SyncStatus = 0x9114,
        [NativeName("Name", "GL_SYNC_FLAGS")]
        SyncFlags = 0x9115,
        [NativeName("Name", "GL_SYNC_FENCE")]
        SyncFence = 0x9116,
        [NativeName("Name", "GL_SYNC_GPU_COMMANDS_COMPLETE")]
        SyncGpuCommandsComplete = 0x9117,
        [NativeName("Name", "GL_UNSIGNALED")]
        Unsignaled = 0x9118,
        [NativeName("Name", "GL_SIGNALED")]
        Signaled = 0x9119,
        [NativeName("Name", "GL_ALREADY_SIGNALED")]
        AlreadySignaled = 0x911A,
        [NativeName("Name", "GL_TIMEOUT_EXPIRED")]
        TimeoutExpired = 0x911B,
        [NativeName("Name", "GL_CONDITION_SATISFIED")]
        ConditionSatisfied = 0x911C,
        [NativeName("Name", "GL_WAIT_FAILED")]
        WaitFailed = 0x911D,
        [NativeName("Name", "GL_SYNC_FLUSH_COMMANDS_BIT")]
        SyncFlushCommandsBit = 0x1,
        [NativeName("Name", "GL_TIMEOUT_IGNORED")]
        TimeoutIgnored = unchecked((int)0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_DIVISOR")]
        VertexAttribArrayDivisor = 0x88FE,
        [NativeName("Name", "GL_ANY_SAMPLES_PASSED")]
        AnySamplesPassed = 0x8C2F,
        [NativeName("Name", "GL_ANY_SAMPLES_PASSED_CONSERVATIVE")]
        AnySamplesPassedConservative = 0x8D6A,
        [NativeName("Name", "GL_SAMPLER_BINDING")]
        SamplerBinding = 0x8919,
        [NativeName("Name", "GL_RGB10_A2UI")]
        Rgb10A2ui = 0x906F,
        [NativeName("Name", "GL_TEXTURE_SWIZZLE_R")]
        TextureSwizzleR = 0x8E42,
        [NativeName("Name", "GL_TEXTURE_SWIZZLE_G")]
        TextureSwizzleG = 0x8E43,
        [NativeName("Name", "GL_TEXTURE_SWIZZLE_B")]
        TextureSwizzleB = 0x8E44,
        [NativeName("Name", "GL_TEXTURE_SWIZZLE_A")]
        TextureSwizzleA = 0x8E45,
        [NativeName("Name", "GL_GREEN")]
        Green = 0x1904,
        [NativeName("Name", "GL_BLUE")]
        Blue = 0x1905,
        [NativeName("Name", "GL_INT_2_10_10_10_REV")]
        Int2101010Rev = 0x8D9F,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK")]
        TransformFeedback = 0x8E22,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_PAUSED")]
        TransformFeedbackPaused = 0x8E23,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_ACTIVE")]
        TransformFeedbackActive = 0x8E24,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BINDING")]
        TransformFeedbackBinding = 0x8E25,
        [NativeName("Name", "GL_PROGRAM_BINARY_RETRIEVABLE_HINT")]
        ProgramBinaryRetrievableHint = 0x8257,
        [NativeName("Name", "GL_PROGRAM_BINARY_LENGTH")]
        ProgramBinaryLength = 0x8741,
        [NativeName("Name", "GL_NUM_PROGRAM_BINARY_FORMATS")]
        NumProgramBinaryFormats = 0x87FE,
        [NativeName("Name", "GL_PROGRAM_BINARY_FORMATS")]
        ProgramBinaryFormats = 0x87FF,
        [NativeName("Name", "GL_COMPRESSED_R11_EAC")]
        CompressedR11Eac = 0x9270,
        [NativeName("Name", "GL_COMPRESSED_SIGNED_R11_EAC")]
        CompressedSignedR11Eac = 0x9271,
        [NativeName("Name", "GL_COMPRESSED_RG11_EAC")]
        CompressedRG11Eac = 0x9272,
        [NativeName("Name", "GL_COMPRESSED_SIGNED_RG11_EAC")]
        CompressedSignedRG11Eac = 0x9273,
        [NativeName("Name", "GL_COMPRESSED_RGB8_ETC2")]
        CompressedRgb8Etc2 = 0x9274,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ETC2")]
        CompressedSrgb8Etc2 = 0x9275,
        [NativeName("Name", "GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2")]
        CompressedRgb8PunchthroughAlpha1Etc2 = 0x9276,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2")]
        CompressedSrgb8PunchthroughAlpha1Etc2 = 0x9277,
        [NativeName("Name", "GL_COMPRESSED_RGBA8_ETC2_EAC")]
        CompressedRgba8Etc2Eac = 0x9278,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC")]
        CompressedSrgb8Alpha8Etc2Eac = 0x9279,
        [NativeName("Name", "GL_TEXTURE_IMMUTABLE_FORMAT")]
        TextureImmutableFormat = 0x912F,
        [NativeName("Name", "GL_MAX_ELEMENT_INDEX")]
        MaxElementIndex = 0x8D6B,
        [NativeName("Name", "GL_NUM_SAMPLE_COUNTS")]
        NumSampleCounts = 0x9380,
        [NativeName("Name", "GL_TEXTURE_IMMUTABLE_LEVELS")]
        TextureImmutableLevels = 0x82DF,
        [NativeName("Name", "GL_COMPUTE_SHADER")]
        ComputeShader = 0x91B9,
        [NativeName("Name", "GL_MAX_COMPUTE_UNIFORM_BLOCKS")]
        MaxComputeUniformBlocks = 0x91BB,
        [NativeName("Name", "GL_MAX_COMPUTE_TEXTURE_IMAGE_UNITS")]
        MaxComputeTextureImageUnits = 0x91BC,
        [NativeName("Name", "GL_MAX_COMPUTE_IMAGE_UNIFORMS")]
        MaxComputeImageUniforms = 0x91BD,
        [NativeName("Name", "GL_MAX_COMPUTE_SHARED_MEMORY_SIZE")]
        MaxComputeSharedMemorySize = 0x8262,
        [NativeName("Name", "GL_MAX_COMPUTE_UNIFORM_COMPONENTS")]
        MaxComputeUniformComponents = 0x8263,
        [NativeName("Name", "GL_MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS")]
        MaxComputeAtomicCounterBuffers = 0x8264,
        [NativeName("Name", "GL_MAX_COMPUTE_ATOMIC_COUNTERS")]
        MaxComputeAtomicCounters = 0x8265,
        [NativeName("Name", "GL_MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS")]
        MaxCombinedComputeUniformComponents = 0x8266,
        [NativeName("Name", "GL_MAX_COMPUTE_WORK_GROUP_INVOCATIONS")]
        MaxComputeWorkGroupInvocations = 0x90EB,
        [NativeName("Name", "GL_MAX_COMPUTE_WORK_GROUP_COUNT")]
        MaxComputeWorkGroupCount = 0x91BE,
        [NativeName("Name", "GL_MAX_COMPUTE_WORK_GROUP_SIZE")]
        MaxComputeWorkGroupSize = 0x91BF,
        [NativeName("Name", "GL_COMPUTE_WORK_GROUP_SIZE")]
        ComputeWorkGroupSize = 0x8267,
        [NativeName("Name", "GL_DISPATCH_INDIRECT_BUFFER")]
        DispatchIndirectBuffer = 0x90EE,
        [NativeName("Name", "GL_DISPATCH_INDIRECT_BUFFER_BINDING")]
        DispatchIndirectBufferBinding = 0x90EF,
        [NativeName("Name", "GL_COMPUTE_SHADER_BIT")]
        ComputeShaderBit = 0x20,
        [NativeName("Name", "GL_DRAW_INDIRECT_BUFFER")]
        DrawIndirectBuffer = 0x8F3F,
        [NativeName("Name", "GL_DRAW_INDIRECT_BUFFER_BINDING")]
        DrawIndirectBufferBinding = 0x8F43,
        [NativeName("Name", "GL_MAX_UNIFORM_LOCATIONS")]
        MaxUniformLocations = 0x826E,
        [NativeName("Name", "GL_FRAMEBUFFER_DEFAULT_WIDTH")]
        FramebufferDefaultWidth = 0x9310,
        [NativeName("Name", "GL_FRAMEBUFFER_DEFAULT_HEIGHT")]
        FramebufferDefaultHeight = 0x9311,
        [NativeName("Name", "GL_FRAMEBUFFER_DEFAULT_SAMPLES")]
        FramebufferDefaultSamples = 0x9313,
        [NativeName("Name", "GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS")]
        FramebufferDefaultFixedSampleLocations = 0x9314,
        [NativeName("Name", "GL_MAX_FRAMEBUFFER_WIDTH")]
        MaxFramebufferWidth = 0x9315,
        [NativeName("Name", "GL_MAX_FRAMEBUFFER_HEIGHT")]
        MaxFramebufferHeight = 0x9316,
        [NativeName("Name", "GL_MAX_FRAMEBUFFER_SAMPLES")]
        MaxFramebufferSamples = 0x9318,
        [NativeName("Name", "GL_UNIFORM")]
        Uniform = 0x92E1,
        [NativeName("Name", "GL_UNIFORM_BLOCK")]
        UniformBlock = 0x92E2,
        [NativeName("Name", "GL_PROGRAM_INPUT")]
        ProgramInput = 0x92E3,
        [NativeName("Name", "GL_PROGRAM_OUTPUT")]
        ProgramOutput = 0x92E4,
        [NativeName("Name", "GL_BUFFER_VARIABLE")]
        BufferVariable = 0x92E5,
        [NativeName("Name", "GL_SHADER_STORAGE_BLOCK")]
        ShaderStorageBlock = 0x92E6,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER")]
        AtomicCounterBuffer = 0x92C0,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_VARYING")]
        TransformFeedbackVarying = 0x92F4,
        [NativeName("Name", "GL_ACTIVE_RESOURCES")]
        ActiveResources = 0x92F5,
        [NativeName("Name", "GL_MAX_NAME_LENGTH")]
        MaxNameLength = 0x92F6,
        [NativeName("Name", "GL_MAX_NUM_ACTIVE_VARIABLES")]
        MaxNumActiveVariables = 0x92F7,
        [NativeName("Name", "GL_NAME_LENGTH")]
        NameLength = 0x92F9,
        [NativeName("Name", "GL_TYPE")]
        Type = 0x92FA,
        [NativeName("Name", "GL_ARRAY_SIZE")]
        ArraySize = 0x92FB,
        [NativeName("Name", "GL_OFFSET")]
        Offset = 0x92FC,
        [NativeName("Name", "GL_BLOCK_INDEX")]
        BlockIndex = 0x92FD,
        [NativeName("Name", "GL_ARRAY_STRIDE")]
        ArrayStride = 0x92FE,
        [NativeName("Name", "GL_MATRIX_STRIDE")]
        MatrixStride = 0x92FF,
        [NativeName("Name", "GL_IS_ROW_MAJOR")]
        IsRowMajor = 0x9300,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_INDEX")]
        AtomicCounterBufferIndex = 0x9301,
        [NativeName("Name", "GL_BUFFER_BINDING")]
        BufferBinding = 0x9302,
        [NativeName("Name", "GL_BUFFER_DATA_SIZE")]
        BufferDataSize = 0x9303,
        [NativeName("Name", "GL_NUM_ACTIVE_VARIABLES")]
        NumActiveVariables = 0x9304,
        [NativeName("Name", "GL_ACTIVE_VARIABLES")]
        ActiveVariables = 0x9305,
        [NativeName("Name", "GL_REFERENCED_BY_VERTEX_SHADER")]
        ReferencedByVertexShader = 0x9306,
        [NativeName("Name", "GL_REFERENCED_BY_FRAGMENT_SHADER")]
        ReferencedByFragmentShader = 0x930A,
        [NativeName("Name", "GL_REFERENCED_BY_COMPUTE_SHADER")]
        ReferencedByComputeShader = 0x930B,
        [NativeName("Name", "GL_TOP_LEVEL_ARRAY_SIZE")]
        TopLevelArraySize = 0x930C,
        [NativeName("Name", "GL_TOP_LEVEL_ARRAY_STRIDE")]
        TopLevelArrayStride = 0x930D,
        [NativeName("Name", "GL_LOCATION")]
        Location = 0x930E,
        [NativeName("Name", "GL_VERTEX_SHADER_BIT")]
        VertexShaderBit = 0x1,
        [NativeName("Name", "GL_FRAGMENT_SHADER_BIT")]
        FragmentShaderBit = 0x2,
        [NativeName("Name", "GL_ALL_SHADER_BITS")]
        AllShaderBits = unchecked((int)0xFFFFFFFF),
        [NativeName("Name", "GL_PROGRAM_SEPARABLE")]
        ProgramSeparable = 0x8258,
        [NativeName("Name", "GL_ACTIVE_PROGRAM")]
        ActiveProgram = 0x8259,
        [NativeName("Name", "GL_PROGRAM_PIPELINE_BINDING")]
        ProgramPipelineBinding = 0x825A,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_BINDING")]
        AtomicCounterBufferBinding = 0x92C1,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_START")]
        AtomicCounterBufferStart = 0x92C2,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_SIZE")]
        AtomicCounterBufferSize = 0x92C3,
        [NativeName("Name", "GL_MAX_VERTEX_ATOMIC_COUNTER_BUFFERS")]
        MaxVertexAtomicCounterBuffers = 0x92CC,
        [NativeName("Name", "GL_MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS")]
        MaxFragmentAtomicCounterBuffers = 0x92D0,
        [NativeName("Name", "GL_MAX_COMBINED_ATOMIC_COUNTER_BUFFERS")]
        MaxCombinedAtomicCounterBuffers = 0x92D1,
        [NativeName("Name", "GL_MAX_VERTEX_ATOMIC_COUNTERS")]
        MaxVertexAtomicCounters = 0x92D2,
        [NativeName("Name", "GL_MAX_FRAGMENT_ATOMIC_COUNTERS")]
        MaxFragmentAtomicCounters = 0x92D6,
        [NativeName("Name", "GL_MAX_COMBINED_ATOMIC_COUNTERS")]
        MaxCombinedAtomicCounters = 0x92D7,
        [NativeName("Name", "GL_MAX_ATOMIC_COUNTER_BUFFER_SIZE")]
        MaxAtomicCounterBufferSize = 0x92D8,
        [NativeName("Name", "GL_MAX_ATOMIC_COUNTER_BUFFER_BINDINGS")]
        MaxAtomicCounterBufferBindings = 0x92DC,
        [NativeName("Name", "GL_ACTIVE_ATOMIC_COUNTER_BUFFERS")]
        ActiveAtomicCounterBuffers = 0x92D9,
        [NativeName("Name", "GL_UNSIGNED_INT_ATOMIC_COUNTER")]
        UnsignedIntAtomicCounter = 0x92DB,
        [NativeName("Name", "GL_MAX_IMAGE_UNITS")]
        MaxImageUnits = 0x8F38,
        [NativeName("Name", "GL_MAX_VERTEX_IMAGE_UNIFORMS")]
        MaxVertexImageUniforms = 0x90CA,
        [NativeName("Name", "GL_MAX_FRAGMENT_IMAGE_UNIFORMS")]
        MaxFragmentImageUniforms = 0x90CE,
        [NativeName("Name", "GL_MAX_COMBINED_IMAGE_UNIFORMS")]
        MaxCombinedImageUniforms = 0x90CF,
        [NativeName("Name", "GL_IMAGE_BINDING_NAME")]
        ImageBindingName = 0x8F3A,
        [NativeName("Name", "GL_IMAGE_BINDING_LEVEL")]
        ImageBindingLevel = 0x8F3B,
        [NativeName("Name", "GL_IMAGE_BINDING_LAYERED")]
        ImageBindingLayered = 0x8F3C,
        [NativeName("Name", "GL_IMAGE_BINDING_LAYER")]
        ImageBindingLayer = 0x8F3D,
        [NativeName("Name", "GL_IMAGE_BINDING_ACCESS")]
        ImageBindingAccess = 0x8F3E,
        [NativeName("Name", "GL_IMAGE_BINDING_FORMAT")]
        ImageBindingFormat = 0x906E,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT")]
        VertexAttribArrayBarrierBit = 0x1,
        [NativeName("Name", "GL_ELEMENT_ARRAY_BARRIER_BIT")]
        ElementArrayBarrierBit = 0x2,
        [NativeName("Name", "GL_UNIFORM_BARRIER_BIT")]
        UniformBarrierBit = 0x4,
        [NativeName("Name", "GL_TEXTURE_FETCH_BARRIER_BIT")]
        TextureFetchBarrierBit = 0x8,
        [NativeName("Name", "GL_SHADER_IMAGE_ACCESS_BARRIER_BIT")]
        ShaderImageAccessBarrierBit = 0x20,
        [NativeName("Name", "GL_COMMAND_BARRIER_BIT")]
        CommandBarrierBit = 0x40,
        [NativeName("Name", "GL_PIXEL_BUFFER_BARRIER_BIT")]
        PixelBufferBarrierBit = 0x80,
        [NativeName("Name", "GL_TEXTURE_UPDATE_BARRIER_BIT")]
        TextureUpdateBarrierBit = 0x100,
        [NativeName("Name", "GL_BUFFER_UPDATE_BARRIER_BIT")]
        BufferUpdateBarrierBit = 0x200,
        [NativeName("Name", "GL_FRAMEBUFFER_BARRIER_BIT")]
        FramebufferBarrierBit = 0x400,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BARRIER_BIT")]
        TransformFeedbackBarrierBit = 0x800,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BARRIER_BIT")]
        AtomicCounterBarrierBit = 0x1000,
        [NativeName("Name", "GL_ALL_BARRIER_BITS")]
        AllBarrierBits = unchecked((int)0xFFFFFFFF),
        [NativeName("Name", "GL_IMAGE_2D")]
        Image2D = 0x904D,
        [NativeName("Name", "GL_IMAGE_3D")]
        Image3D = 0x904E,
        [NativeName("Name", "GL_IMAGE_CUBE")]
        ImageCube = 0x9050,
        [NativeName("Name", "GL_IMAGE_2D_ARRAY")]
        Image2DArray = 0x9053,
        [NativeName("Name", "GL_INT_IMAGE_2D")]
        IntImage2D = 0x9058,
        [NativeName("Name", "GL_INT_IMAGE_3D")]
        IntImage3D = 0x9059,
        [NativeName("Name", "GL_INT_IMAGE_CUBE")]
        IntImageCube = 0x905B,
        [NativeName("Name", "GL_INT_IMAGE_2D_ARRAY")]
        IntImage2DArray = 0x905E,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_2D")]
        UnsignedIntImage2D = 0x9063,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_3D")]
        UnsignedIntImage3D = 0x9064,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_CUBE")]
        UnsignedIntImageCube = 0x9066,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_2D_ARRAY")]
        UnsignedIntImage2DArray = 0x9069,
        [NativeName("Name", "GL_IMAGE_FORMAT_COMPATIBILITY_TYPE")]
        ImageFormatCompatibilityType = 0x90C7,
        [NativeName("Name", "GL_IMAGE_FORMAT_COMPATIBILITY_BY_SIZE")]
        ImageFormatCompatibilityBySize = 0x90C8,
        [NativeName("Name", "GL_IMAGE_FORMAT_COMPATIBILITY_BY_CLASS")]
        ImageFormatCompatibilityByClass = 0x90C9,
        [NativeName("Name", "GL_READ_ONLY")]
        ReadOnly = 0x88B8,
        [NativeName("Name", "GL_WRITE_ONLY")]
        WriteOnly = 0x88B9,
        [NativeName("Name", "GL_READ_WRITE")]
        ReadWrite = 0x88BA,
        [NativeName("Name", "GL_SHADER_STORAGE_BUFFER")]
        ShaderStorageBuffer = 0x90D2,
        [NativeName("Name", "GL_SHADER_STORAGE_BUFFER_BINDING")]
        ShaderStorageBufferBinding = 0x90D3,
        [NativeName("Name", "GL_SHADER_STORAGE_BUFFER_START")]
        ShaderStorageBufferStart = 0x90D4,
        [NativeName("Name", "GL_SHADER_STORAGE_BUFFER_SIZE")]
        ShaderStorageBufferSize = 0x90D5,
        [NativeName("Name", "GL_MAX_VERTEX_SHADER_STORAGE_BLOCKS")]
        MaxVertexShaderStorageBlocks = 0x90D6,
        [NativeName("Name", "GL_MAX_FRAGMENT_SHADER_STORAGE_BLOCKS")]
        MaxFragmentShaderStorageBlocks = 0x90DA,
        [NativeName("Name", "GL_MAX_COMPUTE_SHADER_STORAGE_BLOCKS")]
        MaxComputeShaderStorageBlocks = 0x90DB,
        [NativeName("Name", "GL_MAX_COMBINED_SHADER_STORAGE_BLOCKS")]
        MaxCombinedShaderStorageBlocks = 0x90DC,
        [NativeName("Name", "GL_MAX_SHADER_STORAGE_BUFFER_BINDINGS")]
        MaxShaderStorageBufferBindings = 0x90DD,
        [NativeName("Name", "GL_MAX_SHADER_STORAGE_BLOCK_SIZE")]
        MaxShaderStorageBlockSize = 0x90DE,
        [NativeName("Name", "GL_SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT")]
        ShaderStorageBufferOffsetAlignment = 0x90DF,
        [NativeName("Name", "GL_SHADER_STORAGE_BARRIER_BIT")]
        ShaderStorageBarrierBit = 0x2000,
        [NativeName("Name", "GL_MAX_COMBINED_SHADER_OUTPUT_RESOURCES")]
        MaxCombinedShaderOutputResources = 0x8F39,
        [NativeName("Name", "GL_DEPTH_STENCIL_TEXTURE_MODE")]
        DepthStencilTextureMode = 0x90EA,
        [NativeName("Name", "GL_STENCIL_INDEX")]
        StencilIndex = 0x1901,
        [NativeName("Name", "GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET")]
        MinProgramTextureGatherOffset = 0x8E5E,
        [NativeName("Name", "GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET")]
        MaxProgramTextureGatherOffset = 0x8E5F,
        [NativeName("Name", "GL_SAMPLE_POSITION")]
        SamplePosition = 0x8E50,
        [NativeName("Name", "GL_SAMPLE_MASK")]
        SampleMask = 0x8E51,
        [NativeName("Name", "GL_SAMPLE_MASK_VALUE")]
        SampleMaskValue = 0x8E52,
        [NativeName("Name", "GL_TEXTURE_2D_MULTISAMPLE")]
        Texture2DMultisample = 0x9100,
        [NativeName("Name", "GL_MAX_SAMPLE_MASK_WORDS")]
        MaxSampleMaskWords = 0x8E59,
        [NativeName("Name", "GL_MAX_COLOR_TEXTURE_SAMPLES")]
        MaxColorTextureSamples = 0x910E,
        [NativeName("Name", "GL_MAX_DEPTH_TEXTURE_SAMPLES")]
        MaxDepthTextureSamples = 0x910F,
        [NativeName("Name", "GL_MAX_INTEGER_SAMPLES")]
        MaxIntegerSamples = 0x9110,
        [NativeName("Name", "GL_TEXTURE_BINDING_2D_MULTISAMPLE")]
        TextureBinding2DMultisample = 0x9104,
        [NativeName("Name", "GL_TEXTURE_SAMPLES")]
        TextureSamples = 0x9106,
        [NativeName("Name", "GL_TEXTURE_FIXED_SAMPLE_LOCATIONS")]
        TextureFixedSampleLocations = 0x9107,
        [NativeName("Name", "GL_TEXTURE_WIDTH")]
        TextureWidth = 0x1000,
        [NativeName("Name", "GL_TEXTURE_HEIGHT")]
        TextureHeight = 0x1001,
        [NativeName("Name", "GL_TEXTURE_DEPTH")]
        TextureDepth = 0x8071,
        [NativeName("Name", "GL_TEXTURE_INTERNAL_FORMAT")]
        TextureInternalFormat = 0x1003,
        [NativeName("Name", "GL_TEXTURE_RED_SIZE")]
        TextureRedSize = 0x805C,
        [NativeName("Name", "GL_TEXTURE_GREEN_SIZE")]
        TextureGreenSize = 0x805D,
        [NativeName("Name", "GL_TEXTURE_BLUE_SIZE")]
        TextureBlueSize = 0x805E,
        [NativeName("Name", "GL_TEXTURE_ALPHA_SIZE")]
        TextureAlphaSize = 0x805F,
        [NativeName("Name", "GL_TEXTURE_DEPTH_SIZE")]
        TextureDepthSize = 0x884A,
        [NativeName("Name", "GL_TEXTURE_STENCIL_SIZE")]
        TextureStencilSize = 0x88F1,
        [NativeName("Name", "GL_TEXTURE_SHARED_SIZE")]
        TextureSharedSize = 0x8C3F,
        [NativeName("Name", "GL_TEXTURE_RED_TYPE")]
        TextureRedType = 0x8C10,
        [NativeName("Name", "GL_TEXTURE_GREEN_TYPE")]
        TextureGreenType = 0x8C11,
        [NativeName("Name", "GL_TEXTURE_BLUE_TYPE")]
        TextureBlueType = 0x8C12,
        [NativeName("Name", "GL_TEXTURE_ALPHA_TYPE")]
        TextureAlphaType = 0x8C13,
        [NativeName("Name", "GL_TEXTURE_DEPTH_TYPE")]
        TextureDepthType = 0x8C16,
        [NativeName("Name", "GL_TEXTURE_COMPRESSED")]
        TextureCompressed = 0x86A1,
        [NativeName("Name", "GL_SAMPLER_2D_MULTISAMPLE")]
        Sampler2DMultisample = 0x9108,
        [NativeName("Name", "GL_INT_SAMPLER_2D_MULTISAMPLE")]
        IntSampler2DMultisample = 0x9109,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE")]
        UnsignedIntSampler2DMultisample = 0x910A,
        [NativeName("Name", "GL_VERTEX_ATTRIB_BINDING")]
        VertexAttribBinding = 0x82D4,
        [NativeName("Name", "GL_VERTEX_ATTRIB_RELATIVE_OFFSET")]
        VertexAttribRelativeOffset = 0x82D5,
        [NativeName("Name", "GL_VERTEX_BINDING_DIVISOR")]
        VertexBindingDivisor = 0x82D6,
        [NativeName("Name", "GL_VERTEX_BINDING_OFFSET")]
        VertexBindingOffset = 0x82D7,
        [NativeName("Name", "GL_VERTEX_BINDING_STRIDE")]
        VertexBindingStride = 0x82D8,
        [NativeName("Name", "GL_VERTEX_BINDING_BUFFER")]
        VertexBindingBuffer = 0x8F4F,
        [NativeName("Name", "GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET")]
        MaxVertexAttribRelativeOffset = 0x82D9,
        [NativeName("Name", "GL_MAX_VERTEX_ATTRIB_BINDINGS")]
        MaxVertexAttribBindings = 0x82DA,
        [NativeName("Name", "GL_MAX_VERTEX_ATTRIB_STRIDE")]
        MaxVertexAttribStride = 0x82E5,
        [NativeName("Name", "GL_MULTISAMPLE_LINE_WIDTH_RANGE")]
        MultisampleLineWidthRange = 0x9381,
        [NativeName("Name", "GL_MULTISAMPLE_LINE_WIDTH_GRANULARITY")]
        MultisampleLineWidthGranularity = 0x9382,
        [NativeName("Name", "GL_MULTIPLY")]
        Multiply = 0x9294,
        [NativeName("Name", "GL_SCREEN")]
        Screen = 0x9295,
        [NativeName("Name", "GL_OVERLAY")]
        Overlay = 0x9296,
        [NativeName("Name", "GL_DARKEN")]
        Darken = 0x9297,
        [NativeName("Name", "GL_LIGHTEN")]
        Lighten = 0x9298,
        [NativeName("Name", "GL_COLORDODGE")]
        Colordodge = 0x9299,
        [NativeName("Name", "GL_COLORBURN")]
        Colorburn = 0x929A,
        [NativeName("Name", "GL_HARDLIGHT")]
        Hardlight = 0x929B,
        [NativeName("Name", "GL_SOFTLIGHT")]
        Softlight = 0x929C,
        [NativeName("Name", "GL_DIFFERENCE")]
        Difference = 0x929E,
        [NativeName("Name", "GL_EXCLUSION")]
        Exclusion = 0x92A0,
        [NativeName("Name", "GL_HSL_HUE")]
        HslHue = 0x92AD,
        [NativeName("Name", "GL_HSL_SATURATION")]
        HslSaturation = 0x92AE,
        [NativeName("Name", "GL_HSL_COLOR")]
        HslColor = 0x92AF,
        [NativeName("Name", "GL_HSL_LUMINOSITY")]
        HslLuminosity = 0x92B0,
        [NativeName("Name", "GL_DEBUG_OUTPUT_SYNCHRONOUS")]
        DebugOutputSynchronous = 0x8242,
        [NativeName("Name", "GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH")]
        DebugNextLoggedMessageLength = 0x8243,
        [NativeName("Name", "GL_DEBUG_CALLBACK_FUNCTION")]
        DebugCallbackFunction = 0x8244,
        [NativeName("Name", "GL_DEBUG_CALLBACK_USER_PARAM")]
        DebugCallbackUserParam = 0x8245,
        [NativeName("Name", "GL_DEBUG_SOURCE_API")]
        DebugSourceApi = 0x8246,
        [NativeName("Name", "GL_DEBUG_SOURCE_WINDOW_SYSTEM")]
        DebugSourceWindowSystem = 0x8247,
        [NativeName("Name", "GL_DEBUG_SOURCE_SHADER_COMPILER")]
        DebugSourceShaderCompiler = 0x8248,
        [NativeName("Name", "GL_DEBUG_SOURCE_THIRD_PARTY")]
        DebugSourceThirdParty = 0x8249,
        [NativeName("Name", "GL_DEBUG_SOURCE_APPLICATION")]
        DebugSourceApplication = 0x824A,
        [NativeName("Name", "GL_DEBUG_SOURCE_OTHER")]
        DebugSourceOther = 0x824B,
        [NativeName("Name", "GL_DEBUG_TYPE_ERROR")]
        DebugTypeError = 0x824C,
        [NativeName("Name", "GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR")]
        DebugTypeDeprecatedBehavior = 0x824D,
        [NativeName("Name", "GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR")]
        DebugTypeUndefinedBehavior = 0x824E,
        [NativeName("Name", "GL_DEBUG_TYPE_PORTABILITY")]
        DebugTypePortability = 0x824F,
        [NativeName("Name", "GL_DEBUG_TYPE_PERFORMANCE")]
        DebugTypePerformance = 0x8250,
        [NativeName("Name", "GL_DEBUG_TYPE_OTHER")]
        DebugTypeOther = 0x8251,
        [NativeName("Name", "GL_DEBUG_TYPE_MARKER")]
        DebugTypeMarker = 0x8268,
        [NativeName("Name", "GL_DEBUG_TYPE_PUSH_GROUP")]
        DebugTypePushGroup = 0x8269,
        [NativeName("Name", "GL_DEBUG_TYPE_POP_GROUP")]
        DebugTypePopGroup = 0x826A,
        [NativeName("Name", "GL_DEBUG_SEVERITY_NOTIFICATION")]
        DebugSeverityNotification = 0x826B,
        [NativeName("Name", "GL_MAX_DEBUG_GROUP_STACK_DEPTH")]
        MaxDebugGroupStackDepth = 0x826C,
        [NativeName("Name", "GL_DEBUG_GROUP_STACK_DEPTH")]
        DebugGroupStackDepth = 0x826D,
        [NativeName("Name", "GL_BUFFER")]
        Buffer = 0x82E0,
        [NativeName("Name", "GL_SHADER")]
        Shader = 0x82E1,
        [NativeName("Name", "GL_PROGRAM")]
        Program = 0x82E2,
        [NativeName("Name", "GL_VERTEX_ARRAY")]
        VertexArray = 0x8074,
        [NativeName("Name", "GL_QUERY")]
        Query = 0x82E3,
        [NativeName("Name", "GL_PROGRAM_PIPELINE")]
        ProgramPipeline = 0x82E4,
        [NativeName("Name", "GL_SAMPLER")]
        Sampler = 0x82E6,
        [NativeName("Name", "GL_MAX_LABEL_LENGTH")]
        MaxLabelLength = 0x82E8,
        [NativeName("Name", "GL_MAX_DEBUG_MESSAGE_LENGTH")]
        MaxDebugMessageLength = 0x9143,
        [NativeName("Name", "GL_MAX_DEBUG_LOGGED_MESSAGES")]
        MaxDebugLoggedMessages = 0x9144,
        [NativeName("Name", "GL_DEBUG_LOGGED_MESSAGES")]
        DebugLoggedMessages = 0x9145,
        [NativeName("Name", "GL_DEBUG_SEVERITY_HIGH")]
        DebugSeverityHigh = 0x9146,
        [NativeName("Name", "GL_DEBUG_SEVERITY_MEDIUM")]
        DebugSeverityMedium = 0x9147,
        [NativeName("Name", "GL_DEBUG_SEVERITY_LOW")]
        DebugSeverityLow = 0x9148,
        [NativeName("Name", "GL_DEBUG_OUTPUT")]
        DebugOutput = 0x92E0,
        [NativeName("Name", "GL_CONTEXT_FLAG_DEBUG_BIT")]
        ContextFlagDebugBit = 0x2,
        [NativeName("Name", "GL_STACK_OVERFLOW")]
        StackOverflow = 0x503,
        [NativeName("Name", "GL_STACK_UNDERFLOW")]
        StackUnderflow = 0x504,
        [NativeName("Name", "GL_GEOMETRY_SHADER")]
        GeometryShader = 0x8DD9,
        [NativeName("Name", "GL_GEOMETRY_SHADER_BIT")]
        GeometryShaderBit = 0x4,
        [NativeName("Name", "GL_GEOMETRY_VERTICES_OUT")]
        GeometryVerticesOut = 0x8916,
        [NativeName("Name", "GL_GEOMETRY_INPUT_TYPE")]
        GeometryInputType = 0x8917,
        [NativeName("Name", "GL_GEOMETRY_OUTPUT_TYPE")]
        GeometryOutputType = 0x8918,
        [NativeName("Name", "GL_GEOMETRY_SHADER_INVOCATIONS")]
        GeometryShaderInvocations = 0x887F,
        [NativeName("Name", "GL_LAYER_PROVOKING_VERTEX")]
        LayerProvokingVertex = 0x825E,
        [NativeName("Name", "GL_LINES_ADJACENCY")]
        LinesAdjacency = 0xA,
        [NativeName("Name", "GL_LINE_STRIP_ADJACENCY")]
        LineStripAdjacency = 0xB,
        [NativeName("Name", "GL_TRIANGLES_ADJACENCY")]
        TrianglesAdjacency = 0xC,
        [NativeName("Name", "GL_TRIANGLE_STRIP_ADJACENCY")]
        TriangleStripAdjacency = 0xD,
        [NativeName("Name", "GL_MAX_GEOMETRY_UNIFORM_COMPONENTS")]
        MaxGeometryUniformComponents = 0x8DDF,
        [NativeName("Name", "GL_MAX_GEOMETRY_UNIFORM_BLOCKS")]
        MaxGeometryUniformBlocks = 0x8A2C,
        [NativeName("Name", "GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS")]
        MaxCombinedGeometryUniformComponents = 0x8A32,
        [NativeName("Name", "GL_MAX_GEOMETRY_INPUT_COMPONENTS")]
        MaxGeometryInputComponents = 0x9123,
        [NativeName("Name", "GL_MAX_GEOMETRY_OUTPUT_COMPONENTS")]
        MaxGeometryOutputComponents = 0x9124,
        [NativeName("Name", "GL_MAX_GEOMETRY_OUTPUT_VERTICES")]
        MaxGeometryOutputVertices = 0x8DE0,
        [NativeName("Name", "GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS")]
        MaxGeometryTotalOutputComponents = 0x8DE1,
        [NativeName("Name", "GL_MAX_GEOMETRY_SHADER_INVOCATIONS")]
        MaxGeometryShaderInvocations = 0x8E5A,
        [NativeName("Name", "GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS")]
        MaxGeometryTextureImageUnits = 0x8C29,
        [NativeName("Name", "GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS")]
        MaxGeometryAtomicCounterBuffers = 0x92CF,
        [NativeName("Name", "GL_MAX_GEOMETRY_ATOMIC_COUNTERS")]
        MaxGeometryAtomicCounters = 0x92D5,
        [NativeName("Name", "GL_MAX_GEOMETRY_IMAGE_UNIFORMS")]
        MaxGeometryImageUniforms = 0x90CD,
        [NativeName("Name", "GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS")]
        MaxGeometryShaderStorageBlocks = 0x90D7,
        [NativeName("Name", "GL_FIRST_VERTEX_CONVENTION")]
        FirstVertexConvention = 0x8E4D,
        [NativeName("Name", "GL_LAST_VERTEX_CONVENTION")]
        LastVertexConvention = 0x8E4E,
        [NativeName("Name", "GL_UNDEFINED_VERTEX")]
        UndefinedVertex = 0x8260,
        [NativeName("Name", "GL_PRIMITIVES_GENERATED")]
        PrimitivesGenerated = 0x8C87,
        [NativeName("Name", "GL_FRAMEBUFFER_DEFAULT_LAYERS")]
        FramebufferDefaultLayers = 0x9312,
        [NativeName("Name", "GL_MAX_FRAMEBUFFER_LAYERS")]
        MaxFramebufferLayers = 0x9317,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS")]
        FramebufferIncompleteLayerTargets = 0x8DA8,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_LAYERED")]
        FramebufferAttachmentLayered = 0x8DA7,
        [NativeName("Name", "GL_REFERENCED_BY_GEOMETRY_SHADER")]
        ReferencedByGeometryShader = 0x9309,
        [NativeName("Name", "GL_PRIMITIVE_BOUNDING_BOX")]
        PrimitiveBoundingBox = 0x92BE,
        [NativeName("Name", "GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT")]
        ContextFlagRobustAccessBit = 0x4,
        [NativeName("Name", "GL_CONTEXT_FLAGS")]
        ContextFlags = 0x821E,
        [NativeName("Name", "GL_LOSE_CONTEXT_ON_RESET")]
        LoseContextOnReset = 0x8252,
        [NativeName("Name", "GL_GUILTY_CONTEXT_RESET")]
        GuiltyContextReset = 0x8253,
        [NativeName("Name", "GL_INNOCENT_CONTEXT_RESET")]
        InnocentContextReset = 0x8254,
        [NativeName("Name", "GL_UNKNOWN_CONTEXT_RESET")]
        UnknownContextReset = 0x8255,
        [NativeName("Name", "GL_RESET_NOTIFICATION_STRATEGY")]
        ResetNotificationStrategy = 0x8256,
        [NativeName("Name", "GL_NO_RESET_NOTIFICATION")]
        NoResetNotification = 0x8261,
        [NativeName("Name", "GL_CONTEXT_LOST")]
        ContextLost = 0x507,
        [NativeName("Name", "GL_SAMPLE_SHADING")]
        SampleShading = 0x8C36,
        [NativeName("Name", "GL_MIN_SAMPLE_SHADING_VALUE")]
        MinSampleShadingValue = 0x8C37,
        [NativeName("Name", "GL_MIN_FRAGMENT_INTERPOLATION_OFFSET")]
        MinFragmentInterpolationOffset = 0x8E5B,
        [NativeName("Name", "GL_MAX_FRAGMENT_INTERPOLATION_OFFSET")]
        MaxFragmentInterpolationOffset = 0x8E5C,
        [NativeName("Name", "GL_FRAGMENT_INTERPOLATION_OFFSET_BITS")]
        FragmentInterpolationOffsetBits = 0x8E5D,
        [NativeName("Name", "GL_PATCHES")]
        Patches = 0xE,
        [NativeName("Name", "GL_PATCH_VERTICES")]
        PatchVertices = 0x8E72,
        [NativeName("Name", "GL_TESS_CONTROL_OUTPUT_VERTICES")]
        TessControlOutputVertices = 0x8E75,
        [NativeName("Name", "GL_TESS_GEN_MODE")]
        TessGenMode = 0x8E76,
        [NativeName("Name", "GL_TESS_GEN_SPACING")]
        TessGenSpacing = 0x8E77,
        [NativeName("Name", "GL_TESS_GEN_VERTEX_ORDER")]
        TessGenVertexOrder = 0x8E78,
        [NativeName("Name", "GL_TESS_GEN_POINT_MODE")]
        TessGenPointMode = 0x8E79,
        [NativeName("Name", "GL_ISOLINES")]
        Isolines = 0x8E7A,
        [NativeName("Name", "GL_QUADS")]
        Quads = 0x7,
        [NativeName("Name", "GL_FRACTIONAL_ODD")]
        FractionalOdd = 0x8E7B,
        [NativeName("Name", "GL_FRACTIONAL_EVEN")]
        FractionalEven = 0x8E7C,
        [NativeName("Name", "GL_MAX_PATCH_VERTICES")]
        MaxPatchVertices = 0x8E7D,
        [NativeName("Name", "GL_MAX_TESS_GEN_LEVEL")]
        MaxTessGenLevel = 0x8E7E,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS")]
        MaxTessControlUniformComponents = 0x8E7F,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS")]
        MaxTessEvaluationUniformComponents = 0x8E80,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS")]
        MaxTessControlTextureImageUnits = 0x8E81,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS")]
        MaxTessEvaluationTextureImageUnits = 0x8E82,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS")]
        MaxTessControlOutputComponents = 0x8E83,
        [NativeName("Name", "GL_MAX_TESS_PATCH_COMPONENTS")]
        MaxTessPatchComponents = 0x8E84,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS")]
        MaxTessControlTotalOutputComponents = 0x8E85,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS")]
        MaxTessEvaluationOutputComponents = 0x8E86,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS")]
        MaxTessControlUniformBlocks = 0x8E89,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS")]
        MaxTessEvaluationUniformBlocks = 0x8E8A,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_INPUT_COMPONENTS")]
        MaxTessControlInputComponents = 0x886C,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS")]
        MaxTessEvaluationInputComponents = 0x886D,
        [NativeName("Name", "GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS")]
        MaxCombinedTessControlUniformComponents = 0x8E1E,
        [NativeName("Name", "GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS")]
        MaxCombinedTessEvaluationUniformComponents = 0x8E1F,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS")]
        MaxTessControlAtomicCounterBuffers = 0x92CD,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS")]
        MaxTessEvaluationAtomicCounterBuffers = 0x92CE,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS")]
        MaxTessControlAtomicCounters = 0x92D3,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS")]
        MaxTessEvaluationAtomicCounters = 0x92D4,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS")]
        MaxTessControlImageUniforms = 0x90CB,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS")]
        MaxTessEvaluationImageUniforms = 0x90CC,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS")]
        MaxTessControlShaderStorageBlocks = 0x90D8,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS")]
        MaxTessEvaluationShaderStorageBlocks = 0x90D9,
        [NativeName("Name", "GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED")]
        PrimitiveRestartForPatchesSupported = 0x8221,
        [NativeName("Name", "GL_IS_PER_PATCH")]
        IsPerPatch = 0x92E7,
        [NativeName("Name", "GL_REFERENCED_BY_TESS_CONTROL_SHADER")]
        ReferencedByTessControlShader = 0x9307,
        [NativeName("Name", "GL_REFERENCED_BY_TESS_EVALUATION_SHADER")]
        ReferencedByTessEvaluationShader = 0x9308,
        [NativeName("Name", "GL_TESS_CONTROL_SHADER")]
        TessControlShader = 0x8E88,
        [NativeName("Name", "GL_TESS_EVALUATION_SHADER")]
        TessEvaluationShader = 0x8E87,
        [NativeName("Name", "GL_TESS_CONTROL_SHADER_BIT")]
        TessControlShaderBit = 0x8,
        [NativeName("Name", "GL_TESS_EVALUATION_SHADER_BIT")]
        TessEvaluationShaderBit = 0x10,
        [NativeName("Name", "GL_TEXTURE_BORDER_COLOR")]
        TextureBorderColor = 0x1004,
        [NativeName("Name", "GL_CLAMP_TO_BORDER")]
        ClampToBorder = 0x812D,
        [NativeName("Name", "GL_TEXTURE_BUFFER")]
        TextureBuffer = 0x8C2A,
        [NativeName("Name", "GL_TEXTURE_BUFFER_BINDING")]
        TextureBufferBinding = 0x8C2A,
        [NativeName("Name", "GL_MAX_TEXTURE_BUFFER_SIZE")]
        MaxTextureBufferSize = 0x8C2B,
        [NativeName("Name", "GL_TEXTURE_BINDING_BUFFER")]
        TextureBindingBuffer = 0x8C2C,
        [NativeName("Name", "GL_TEXTURE_BUFFER_DATA_STORE_BINDING")]
        TextureBufferDataStoreBinding = 0x8C2D,
        [NativeName("Name", "GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT")]
        TextureBufferOffsetAlignment = 0x919F,
        [NativeName("Name", "GL_SAMPLER_BUFFER")]
        SamplerBuffer = 0x8DC2,
        [NativeName("Name", "GL_INT_SAMPLER_BUFFER")]
        IntSamplerBuffer = 0x8DD0,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_BUFFER")]
        UnsignedIntSamplerBuffer = 0x8DD8,
        [NativeName("Name", "GL_IMAGE_BUFFER")]
        ImageBuffer = 0x9051,
        [NativeName("Name", "GL_INT_IMAGE_BUFFER")]
        IntImageBuffer = 0x905C,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_BUFFER")]
        UnsignedIntImageBuffer = 0x9067,
        [NativeName("Name", "GL_TEXTURE_BUFFER_OFFSET")]
        TextureBufferOffset = 0x919D,
        [NativeName("Name", "GL_TEXTURE_BUFFER_SIZE")]
        TextureBufferSize = 0x919E,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_4x4")]
        CompressedRgbaAstc4x4 = 0x93B0,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_5x4")]
        CompressedRgbaAstc5x4 = 0x93B1,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_5x5")]
        CompressedRgbaAstc5x5 = 0x93B2,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_6x5")]
        CompressedRgbaAstc6x5 = 0x93B3,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_6x6")]
        CompressedRgbaAstc6x6 = 0x93B4,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_8x5")]
        CompressedRgbaAstc8x5 = 0x93B5,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_8x6")]
        CompressedRgbaAstc8x6 = 0x93B6,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_8x8")]
        CompressedRgbaAstc8x8 = 0x93B7,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_10x5")]
        CompressedRgbaAstc10x5 = 0x93B8,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_10x6")]
        CompressedRgbaAstc10x6 = 0x93B9,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_10x8")]
        CompressedRgbaAstc10x8 = 0x93BA,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_10x10")]
        CompressedRgbaAstc10x10 = 0x93BB,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_12x10")]
        CompressedRgbaAstc12x10 = 0x93BC,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_12x12")]
        CompressedRgbaAstc12x12 = 0x93BD,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4")]
        CompressedSrgb8Alpha8Astc4x4 = 0x93D0,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4")]
        CompressedSrgb8Alpha8Astc5x4 = 0x93D1,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5")]
        CompressedSrgb8Alpha8Astc5x5 = 0x93D2,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5")]
        CompressedSrgb8Alpha8Astc6x5 = 0x93D3,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6")]
        CompressedSrgb8Alpha8Astc6x6 = 0x93D4,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x5")]
        CompressedSrgb8Alpha8Astc8x5 = 0x93D5,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x6")]
        CompressedSrgb8Alpha8Astc8x6 = 0x93D6,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x8")]
        CompressedSrgb8Alpha8Astc8x8 = 0x93D7,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x5")]
        CompressedSrgb8Alpha8Astc10x5 = 0x93D8,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x6")]
        CompressedSrgb8Alpha8Astc10x6 = 0x93D9,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x8")]
        CompressedSrgb8Alpha8Astc10x8 = 0x93DA,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x10")]
        CompressedSrgb8Alpha8Astc10x10 = 0x93DB,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x10")]
        CompressedSrgb8Alpha8Astc12x10 = 0x93DC,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x12")]
        CompressedSrgb8Alpha8Astc12x12 = 0x93DD,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_ARRAY")]
        TextureCubeMapArray = 0x9009,
        [NativeName("Name", "GL_TEXTURE_BINDING_CUBE_MAP_ARRAY")]
        TextureBindingCubeMapArray = 0x900A,
        [NativeName("Name", "GL_SAMPLER_CUBE_MAP_ARRAY")]
        SamplerCubeMapArray = 0x900C,
        [NativeName("Name", "GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW")]
        SamplerCubeMapArrayShadow = 0x900D,
        [NativeName("Name", "GL_INT_SAMPLER_CUBE_MAP_ARRAY")]
        IntSamplerCubeMapArray = 0x900E,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY")]
        UnsignedIntSamplerCubeMapArray = 0x900F,
        [NativeName("Name", "GL_IMAGE_CUBE_MAP_ARRAY")]
        ImageCubeMapArray = 0x9054,
        [NativeName("Name", "GL_INT_IMAGE_CUBE_MAP_ARRAY")]
        IntImageCubeMapArray = 0x905F,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY")]
        UnsignedIntImageCubeMapArray = 0x906A,
        [NativeName("Name", "GL_TEXTURE_2D_MULTISAMPLE_ARRAY")]
        Texture2DMultisampleArray = 0x9102,
        [NativeName("Name", "GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY")]
        TextureBinding2DMultisampleArray = 0x9105,
        [NativeName("Name", "GL_SAMPLER_2D_MULTISAMPLE_ARRAY")]
        Sampler2DMultisampleArray = 0x910B,
        [NativeName("Name", "GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY")]
        IntSampler2DMultisampleArray = 0x910C,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY")]
        UnsignedIntSampler2DMultisampleArray = 0x910D,
    }
}
