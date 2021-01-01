// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [NativeName("Name", "GLenum")]
    public enum OES : int
    {
        [NativeName("Name", "GL_ETC1_RGB8_OES")]
        Etc1Rgb8Oes = 0x8D64,
        [NativeName("Name", "GL_PALETTE4_RGB8_OES")]
        Palette4Rgb8Oes = 0x8B90,
        [NativeName("Name", "GL_PALETTE4_RGBA8_OES")]
        Palette4Rgba8Oes = 0x8B91,
        [NativeName("Name", "GL_PALETTE4_R5_G6_B5_OES")]
        Palette4R5G6B5Oes = 0x8B92,
        [NativeName("Name", "GL_PALETTE4_RGBA4_OES")]
        Palette4Rgba4Oes = 0x8B93,
        [NativeName("Name", "GL_PALETTE4_RGB5_A1_OES")]
        Palette4Rgb5A1Oes = 0x8B94,
        [NativeName("Name", "GL_PALETTE8_RGB8_OES")]
        Palette8Rgb8Oes = 0x8B95,
        [NativeName("Name", "GL_PALETTE8_RGBA8_OES")]
        Palette8Rgba8Oes = 0x8B96,
        [NativeName("Name", "GL_PALETTE8_R5_G6_B5_OES")]
        Palette8R5G6B5Oes = 0x8B97,
        [NativeName("Name", "GL_PALETTE8_RGBA4_OES")]
        Palette8Rgba4Oes = 0x8B98,
        [NativeName("Name", "GL_PALETTE8_RGB5_A1_OES")]
        Palette8Rgb5A1Oes = 0x8B99,
        [NativeName("Name", "GL_DEPTH_COMPONENT24_OES")]
        DepthComponent24Oes = 0x81A6,
        [NativeName("Name", "GL_DEPTH_COMPONENT32_OES")]
        DepthComponent32Oes = 0x81A7,
        [NativeName("Name", "GL_DEPTH_COMPONENT")]
        DepthComponent = 0x1902,
        [NativeName("Name", "GL_UNSIGNED_SHORT")]
        UnsignedShort = 0x1403,
        [NativeName("Name", "GL_UNSIGNED_INT")]
        UnsignedInt = 0x1405,
        [NativeName("Name", "GL_BLEND_EQUATION_RGB")]
        BlendEquationRgb = 0x8009,
        [NativeName("Name", "GL_BLEND_EQUATION_ALPHA")]
        BlendEquationAlpha = 0x883D,
        [NativeName("Name", "GL_BLEND_SRC_RGB")]
        BlendSrcRgb = 0x80C9,
        [NativeName("Name", "GL_BLEND_SRC_ALPHA")]
        BlendSrcAlpha = 0x80CB,
        [NativeName("Name", "GL_BLEND_DST_RGB")]
        BlendDstRgb = 0x80C8,
        [NativeName("Name", "GL_BLEND_DST_ALPHA")]
        BlendDstAlpha = 0x80CA,
        [NativeName("Name", "GL_COLOR_WRITEMASK")]
        ColorWritemask = 0xC23,
        [NativeName("Name", "GL_BLEND")]
        Blend = 0xBE2,
        [NativeName("Name", "GL_FUNC_ADD")]
        FuncAdd = 0x8006,
        [NativeName("Name", "GL_FUNC_SUBTRACT")]
        FuncSubtract = 0x800A,
        [NativeName("Name", "GL_FUNC_REVERSE_SUBTRACT")]
        FuncReverseSubtract = 0x800B,
        [NativeName("Name", "GL_MIN")]
        Min = 0x8007,
        [NativeName("Name", "GL_MAX")]
        Max = 0x8008,
        [NativeName("Name", "GL_ZERO")]
        Zero = 0x0,
        [NativeName("Name", "GL_ONE")]
        One = 0x1,
        [NativeName("Name", "GL_SRC_COLOR")]
        SrcColor = 0x300,
        [NativeName("Name", "GL_ONE_MINUS_SRC_COLOR")]
        OneMinusSrcColor = 0x301,
        [NativeName("Name", "GL_DST_COLOR")]
        DstColor = 0x306,
        [NativeName("Name", "GL_ONE_MINUS_DST_COLOR")]
        OneMinusDstColor = 0x307,
        [NativeName("Name", "GL_SRC_ALPHA")]
        SrcAlpha = 0x302,
        [NativeName("Name", "GL_ONE_MINUS_SRC_ALPHA")]
        OneMinusSrcAlpha = 0x303,
        [NativeName("Name", "GL_DST_ALPHA")]
        DstAlpha = 0x304,
        [NativeName("Name", "GL_ONE_MINUS_DST_ALPHA")]
        OneMinusDstAlpha = 0x305,
        [NativeName("Name", "GL_CONSTANT_COLOR")]
        ConstantColor = 0x8001,
        [NativeName("Name", "GL_ONE_MINUS_CONSTANT_COLOR")]
        OneMinusConstantColor = 0x8002,
        [NativeName("Name", "GL_CONSTANT_ALPHA")]
        ConstantAlpha = 0x8003,
        [NativeName("Name", "GL_ONE_MINUS_CONSTANT_ALPHA")]
        OneMinusConstantAlpha = 0x8004,
        [NativeName("Name", "GL_SRC_ALPHA_SATURATE")]
        SrcAlphaSaturate = 0x308,
        [NativeName("Name", "GL_TEXTURE_EXTERNAL_OES")]
        TextureExternalOes = 0x8D65,
        [NativeName("Name", "GL_TEXTURE_BINDING_EXTERNAL_OES")]
        TextureBindingExternalOes = 0x8D67,
        [NativeName("Name", "GL_REQUIRED_TEXTURE_IMAGE_UNITS_OES")]
        RequiredTextureImageUnitsOes = 0x8D68,
        [NativeName("Name", "GL_SAMPLER_EXTERNAL_OES")]
        SamplerExternalOes = 0x8D66,
        [NativeName("Name", "GL_GEOMETRY_SHADER_OES")]
        GeometryShaderOes = 0x8DD9,
        [NativeName("Name", "GL_GEOMETRY_SHADER_BIT_OES")]
        GeometryShaderBitOes = 0x4,
        [NativeName("Name", "GL_GEOMETRY_LINKED_VERTICES_OUT_OES")]
        GeometryLinkedVerticesOutOes = 0x8916,
        [NativeName("Name", "GL_GEOMETRY_LINKED_INPUT_TYPE_OES")]
        GeometryLinkedInputTypeOes = 0x8917,
        [NativeName("Name", "GL_GEOMETRY_LINKED_OUTPUT_TYPE_OES")]
        GeometryLinkedOutputTypeOes = 0x8918,
        [NativeName("Name", "GL_GEOMETRY_SHADER_INVOCATIONS_OES")]
        GeometryShaderInvocationsOes = 0x887F,
        [NativeName("Name", "GL_LAYER_PROVOKING_VERTEX_OES")]
        LayerProvokingVertexOes = 0x825E,
        [NativeName("Name", "GL_LINES_ADJACENCY_OES")]
        LinesAdjacencyOes = 0xA,
        [NativeName("Name", "GL_LINE_STRIP_ADJACENCY_OES")]
        LineStripAdjacencyOes = 0xB,
        [NativeName("Name", "GL_TRIANGLES_ADJACENCY_OES")]
        TrianglesAdjacencyOes = 0xC,
        [NativeName("Name", "GL_TRIANGLE_STRIP_ADJACENCY_OES")]
        TriangleStripAdjacencyOes = 0xD,
        [NativeName("Name", "GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_OES")]
        MaxGeometryUniformComponentsOes = 0x8DDF,
        [NativeName("Name", "GL_MAX_GEOMETRY_UNIFORM_BLOCKS_OES")]
        MaxGeometryUniformBlocksOes = 0x8A2C,
        [NativeName("Name", "GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS_OES")]
        MaxCombinedGeometryUniformComponentsOes = 0x8A32,
        [NativeName("Name", "GL_MAX_GEOMETRY_INPUT_COMPONENTS_OES")]
        MaxGeometryInputComponentsOes = 0x9123,
        [NativeName("Name", "GL_MAX_GEOMETRY_OUTPUT_COMPONENTS_OES")]
        MaxGeometryOutputComponentsOes = 0x9124,
        [NativeName("Name", "GL_MAX_GEOMETRY_OUTPUT_VERTICES_OES")]
        MaxGeometryOutputVerticesOes = 0x8DE0,
        [NativeName("Name", "GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_OES")]
        MaxGeometryTotalOutputComponentsOes = 0x8DE1,
        [NativeName("Name", "GL_MAX_GEOMETRY_SHADER_INVOCATIONS_OES")]
        MaxGeometryShaderInvocationsOes = 0x8E5A,
        [NativeName("Name", "GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_OES")]
        MaxGeometryTextureImageUnitsOes = 0x8C29,
        [NativeName("Name", "GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS_OES")]
        MaxGeometryAtomicCounterBuffersOes = 0x92CF,
        [NativeName("Name", "GL_MAX_GEOMETRY_ATOMIC_COUNTERS_OES")]
        MaxGeometryAtomicCountersOes = 0x92D5,
        [NativeName("Name", "GL_MAX_GEOMETRY_IMAGE_UNIFORMS_OES")]
        MaxGeometryImageUniformsOes = 0x90CD,
        [NativeName("Name", "GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS_OES")]
        MaxGeometryShaderStorageBlocksOes = 0x90D7,
        [NativeName("Name", "GL_FIRST_VERTEX_CONVENTION_OES")]
        FirstVertexConventionOes = 0x8E4D,
        [NativeName("Name", "GL_LAST_VERTEX_CONVENTION_OES")]
        LastVertexConventionOes = 0x8E4E,
        [NativeName("Name", "GL_UNDEFINED_VERTEX_OES")]
        UndefinedVertexOes = 0x8260,
        [NativeName("Name", "GL_PRIMITIVES_GENERATED_OES")]
        PrimitivesGeneratedOes = 0x8C87,
        [NativeName("Name", "GL_FRAMEBUFFER_DEFAULT_LAYERS_OES")]
        FramebufferDefaultLayersOes = 0x9312,
        [NativeName("Name", "GL_MAX_FRAMEBUFFER_LAYERS_OES")]
        MaxFramebufferLayersOes = 0x9317,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_OES")]
        FramebufferIncompleteLayerTargetsOes = 0x8DA8,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_LAYERED_OES")]
        FramebufferAttachmentLayeredOes = 0x8DA7,
        [NativeName("Name", "GL_REFERENCED_BY_GEOMETRY_SHADER_OES")]
        ReferencedByGeometryShaderOes = 0x9309,
        [NativeName("Name", "GL_PROGRAM_BINARY_LENGTH_OES")]
        ProgramBinaryLengthOes = 0x8741,
        [NativeName("Name", "GL_NUM_PROGRAM_BINARY_FORMATS_OES")]
        NumProgramBinaryFormatsOes = 0x87FE,
        [NativeName("Name", "GL_PROGRAM_BINARY_FORMATS_OES")]
        ProgramBinaryFormatsOes = 0x87FF,
        [NativeName("Name", "GL_WRITE_ONLY_OES")]
        WriteOnlyOes = 0x88B9,
        [NativeName("Name", "GL_BUFFER_ACCESS_OES")]
        BufferAccessOes = 0x88BB,
        [NativeName("Name", "GL_BUFFER_MAPPED_OES")]
        BufferMappedOes = 0x88BC,
        [NativeName("Name", "GL_BUFFER_MAP_POINTER_OES")]
        BufferMapPointerOes = 0x88BD,
        [NativeName("Name", "GL_DEPTH_STENCIL_OES")]
        DepthStencilOes = 0x84F9,
        [NativeName("Name", "GL_UNSIGNED_INT_24_8_OES")]
        UnsignedInt248Oes = 0x84FA,
        [NativeName("Name", "GL_DEPTH24_STENCIL8_OES")]
        Depth24Stencil8Oes = 0x88F0,
        [NativeName("Name", "GL_PRIMITIVE_BOUNDING_BOX_OES")]
        PrimitiveBoundingBoxOes = 0x92BE,
        [NativeName("Name", "GL_ALPHA8_OES")]
        Alpha8Oes = 0x803C,
        [NativeName("Name", "GL_DEPTH_COMPONENT16_OES")]
        DepthComponent16Oes = 0x81A5,
        [NativeName("Name", "GL_LUMINANCE4_ALPHA4_OES")]
        Luminance4Alpha4Oes = 0x8043,
        [NativeName("Name", "GL_LUMINANCE8_ALPHA8_OES")]
        Luminance8Alpha8Oes = 0x8045,
        [NativeName("Name", "GL_LUMINANCE8_OES")]
        Luminance8Oes = 0x8040,
        [NativeName("Name", "GL_RGBA4_OES")]
        Rgba4Oes = 0x8056,
        [NativeName("Name", "GL_RGB5_A1_OES")]
        Rgb5A1Oes = 0x8057,
        [NativeName("Name", "GL_RGB565_OES")]
        Rgb565Oes = 0x8D62,
        [NativeName("Name", "GL_RGB8_OES")]
        Rgb8Oes = 0x8051,
        [NativeName("Name", "GL_RGBA8_OES")]
        Rgba8Oes = 0x8058,
        [NativeName("Name", "GL_RGB10_EXT")]
        Rgb10Ext = 0x8052,
        [NativeName("Name", "GL_RGB10_A2_EXT")]
        Rgb10A2Ext = 0x8059,
        [NativeName("Name", "GL_SAMPLE_SHADING_OES")]
        SampleShadingOes = 0x8C36,
        [NativeName("Name", "GL_MIN_SAMPLE_SHADING_VALUE_OES")]
        MinSampleShadingValueOes = 0x8C37,
        [NativeName("Name", "GL_MIN_FRAGMENT_INTERPOLATION_OFFSET_OES")]
        MinFragmentInterpolationOffsetOes = 0x8E5B,
        [NativeName("Name", "GL_MAX_FRAGMENT_INTERPOLATION_OFFSET_OES")]
        MaxFragmentInterpolationOffsetOes = 0x8E5C,
        [NativeName("Name", "GL_FRAGMENT_INTERPOLATION_OFFSET_BITS_OES")]
        FragmentInterpolationOffsetBitsOes = 0x8E5D,
        [NativeName("Name", "GL_FRAGMENT_SHADER_DERIVATIVE_HINT_OES")]
        FragmentShaderDerivativeHintOes = 0x8B8B,
        [NativeName("Name", "GL_STENCIL_INDEX1_OES")]
        StencilIndex1Oes = 0x8D46,
        [NativeName("Name", "GL_STENCIL_INDEX4_OES")]
        StencilIndex4Oes = 0x8D47,
        [NativeName("Name", "GL_FRAMEBUFFER_UNDEFINED_OES")]
        FramebufferUndefinedOes = 0x8219,
        [NativeName("Name", "GL_PATCHES_OES")]
        PatchesOes = 0xE,
        [NativeName("Name", "GL_PATCH_VERTICES_OES")]
        PatchVerticesOes = 0x8E72,
        [NativeName("Name", "GL_TESS_CONTROL_OUTPUT_VERTICES_OES")]
        TessControlOutputVerticesOes = 0x8E75,
        [NativeName("Name", "GL_TESS_GEN_MODE_OES")]
        TessGenModeOes = 0x8E76,
        [NativeName("Name", "GL_TESS_GEN_SPACING_OES")]
        TessGenSpacingOes = 0x8E77,
        [NativeName("Name", "GL_TESS_GEN_VERTEX_ORDER_OES")]
        TessGenVertexOrderOes = 0x8E78,
        [NativeName("Name", "GL_TESS_GEN_POINT_MODE_OES")]
        TessGenPointModeOes = 0x8E79,
        [NativeName("Name", "GL_TRIANGLES")]
        Triangles = 0x4,
        [NativeName("Name", "GL_ISOLINES_OES")]
        IsolinesOes = 0x8E7A,
        [NativeName("Name", "GL_QUADS_OES")]
        QuadsOes = 0x7,
        [NativeName("Name", "GL_EQUAL")]
        Equal = 0x202,
        [NativeName("Name", "GL_FRACTIONAL_ODD_OES")]
        FractionalOddOes = 0x8E7B,
        [NativeName("Name", "GL_FRACTIONAL_EVEN_OES")]
        FractionalEvenOes = 0x8E7C,
        [NativeName("Name", "GL_CCW")]
        Ccw = 0x901,
        [NativeName("Name", "GL_CW")]
        CW = 0x900,
        [NativeName("Name", "GL_MAX_PATCH_VERTICES_OES")]
        MaxPatchVerticesOes = 0x8E7D,
        [NativeName("Name", "GL_MAX_TESS_GEN_LEVEL_OES")]
        MaxTessGenLevelOes = 0x8E7E,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS_OES")]
        MaxTessControlUniformComponentsOes = 0x8E7F,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS_OES")]
        MaxTessEvaluationUniformComponentsOes = 0x8E80,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS_OES")]
        MaxTessControlTextureImageUnitsOes = 0x8E81,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS_OES")]
        MaxTessEvaluationTextureImageUnitsOes = 0x8E82,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS_OES")]
        MaxTessControlOutputComponentsOes = 0x8E83,
        [NativeName("Name", "GL_MAX_TESS_PATCH_COMPONENTS_OES")]
        MaxTessPatchComponentsOes = 0x8E84,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS_OES")]
        MaxTessControlTotalOutputComponentsOes = 0x8E85,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS_OES")]
        MaxTessEvaluationOutputComponentsOes = 0x8E86,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS_OES")]
        MaxTessControlUniformBlocksOes = 0x8E89,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS_OES")]
        MaxTessEvaluationUniformBlocksOes = 0x8E8A,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_INPUT_COMPONENTS_OES")]
        MaxTessControlInputComponentsOes = 0x886C,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS_OES")]
        MaxTessEvaluationInputComponentsOes = 0x886D,
        [NativeName("Name", "GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS_OES")]
        MaxCombinedTessControlUniformComponentsOes = 0x8E1E,
        [NativeName("Name", "GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS_OES")]
        MaxCombinedTessEvaluationUniformComponentsOes = 0x8E1F,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS_OES")]
        MaxTessControlAtomicCounterBuffersOes = 0x92CD,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS_OES")]
        MaxTessEvaluationAtomicCounterBuffersOes = 0x92CE,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS_OES")]
        MaxTessControlAtomicCountersOes = 0x92D3,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS_OES")]
        MaxTessEvaluationAtomicCountersOes = 0x92D4,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS_OES")]
        MaxTessControlImageUniformsOes = 0x90CB,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS_OES")]
        MaxTessEvaluationImageUniformsOes = 0x90CC,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS_OES")]
        MaxTessControlShaderStorageBlocksOes = 0x90D8,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS_OES")]
        MaxTessEvaluationShaderStorageBlocksOes = 0x90D9,
        [NativeName("Name", "GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED_OES")]
        PrimitiveRestartForPatchesSupportedOes = 0x8221,
        [NativeName("Name", "GL_IS_PER_PATCH_OES")]
        IsPerPatchOes = 0x92E7,
        [NativeName("Name", "GL_REFERENCED_BY_TESS_CONTROL_SHADER_OES")]
        ReferencedByTessControlShaderOes = 0x9307,
        [NativeName("Name", "GL_REFERENCED_BY_TESS_EVALUATION_SHADER_OES")]
        ReferencedByTessEvaluationShaderOes = 0x9308,
        [NativeName("Name", "GL_TESS_CONTROL_SHADER_OES")]
        TessControlShaderOes = 0x8E88,
        [NativeName("Name", "GL_TESS_EVALUATION_SHADER_OES")]
        TessEvaluationShaderOes = 0x8E87,
        [NativeName("Name", "GL_TESS_CONTROL_SHADER_BIT_OES")]
        TessControlShaderBitOes = 0x8,
        [NativeName("Name", "GL_TESS_EVALUATION_SHADER_BIT_OES")]
        TessEvaluationShaderBitOes = 0x10,
        [NativeName("Name", "GL_TEXTURE_WRAP_R_OES")]
        TextureWrapROes = 0x8072,
        [NativeName("Name", "GL_TEXTURE_3D_OES")]
        Texture3DOes = 0x806F,
        [NativeName("Name", "GL_TEXTURE_BINDING_3D_OES")]
        TextureBinding3DOes = 0x806A,
        [NativeName("Name", "GL_MAX_3D_TEXTURE_SIZE_OES")]
        Max3DTextureSizeOes = 0x8073,
        [NativeName("Name", "GL_SAMPLER_3D_OES")]
        Sampler3DOes = 0x8B5F,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_OES")]
        FramebufferAttachmentTexture3DZoffsetOes = 0x8CD4,
        [NativeName("Name", "GL_TEXTURE_BORDER_COLOR_OES")]
        TextureBorderColorOes = 0x1004,
        [NativeName("Name", "GL_CLAMP_TO_BORDER_OES")]
        ClampToBorderOes = 0x812D,
        [NativeName("Name", "GL_TEXTURE_BUFFER_OES")]
        TextureBufferOes = 0x8C2A,
        [NativeName("Name", "GL_TEXTURE_BUFFER_BINDING_OES")]
        TextureBufferBindingOes = 0x8C2A,
        [NativeName("Name", "GL_MAX_TEXTURE_BUFFER_SIZE_OES")]
        MaxTextureBufferSizeOes = 0x8C2B,
        [NativeName("Name", "GL_TEXTURE_BINDING_BUFFER_OES")]
        TextureBindingBufferOes = 0x8C2C,
        [NativeName("Name", "GL_TEXTURE_BUFFER_DATA_STORE_BINDING_OES")]
        TextureBufferDataStoreBindingOes = 0x8C2D,
        [NativeName("Name", "GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT_OES")]
        TextureBufferOffsetAlignmentOes = 0x919F,
        [NativeName("Name", "GL_SAMPLER_BUFFER_OES")]
        SamplerBufferOes = 0x8DC2,
        [NativeName("Name", "GL_INT_SAMPLER_BUFFER_OES")]
        IntSamplerBufferOes = 0x8DD0,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_BUFFER_OES")]
        UnsignedIntSamplerBufferOes = 0x8DD8,
        [NativeName("Name", "GL_IMAGE_BUFFER_OES")]
        ImageBufferOes = 0x9051,
        [NativeName("Name", "GL_INT_IMAGE_BUFFER_OES")]
        IntImageBufferOes = 0x905C,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_BUFFER_OES")]
        UnsignedIntImageBufferOes = 0x9067,
        [NativeName("Name", "GL_TEXTURE_BUFFER_OFFSET_OES")]
        TextureBufferOffsetOes = 0x919D,
        [NativeName("Name", "GL_TEXTURE_BUFFER_SIZE_OES")]
        TextureBufferSizeOes = 0x919E,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_4x4_KHR")]
        CompressedRgbaAstc4x4Khr = 0x93B0,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_5x4_KHR")]
        CompressedRgbaAstc5x4Khr = 0x93B1,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_5x5_KHR")]
        CompressedRgbaAstc5x5Khr = 0x93B2,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_6x5_KHR")]
        CompressedRgbaAstc6x5Khr = 0x93B3,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_6x6_KHR")]
        CompressedRgbaAstc6x6Khr = 0x93B4,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_8x5_KHR")]
        CompressedRgbaAstc8x5Khr = 0x93B5,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_8x6_KHR")]
        CompressedRgbaAstc8x6Khr = 0x93B6,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_8x8_KHR")]
        CompressedRgbaAstc8x8Khr = 0x93B7,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_10x5_KHR")]
        CompressedRgbaAstc10x5Khr = 0x93B8,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_10x6_KHR")]
        CompressedRgbaAstc10x6Khr = 0x93B9,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_10x8_KHR")]
        CompressedRgbaAstc10x8Khr = 0x93BA,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_10x10_KHR")]
        CompressedRgbaAstc10x10Khr = 0x93BB,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_12x10_KHR")]
        CompressedRgbaAstc12x10Khr = 0x93BC,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_12x12_KHR")]
        CompressedRgbaAstc12x12Khr = 0x93BD,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR")]
        CompressedSrgb8Alpha8Astc4x4Khr = 0x93D0,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4_KHR")]
        CompressedSrgb8Alpha8Astc5x4Khr = 0x93D1,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5_KHR")]
        CompressedSrgb8Alpha8Astc5x5Khr = 0x93D2,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5_KHR")]
        CompressedSrgb8Alpha8Astc6x5Khr = 0x93D3,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6_KHR")]
        CompressedSrgb8Alpha8Astc6x6Khr = 0x93D4,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x5_KHR")]
        CompressedSrgb8Alpha8Astc8x5Khr = 0x93D5,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x6_KHR")]
        CompressedSrgb8Alpha8Astc8x6Khr = 0x93D6,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x8_KHR")]
        CompressedSrgb8Alpha8Astc8x8Khr = 0x93D7,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x5_KHR")]
        CompressedSrgb8Alpha8Astc10x5Khr = 0x93D8,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x6_KHR")]
        CompressedSrgb8Alpha8Astc10x6Khr = 0x93D9,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x8_KHR")]
        CompressedSrgb8Alpha8Astc10x8Khr = 0x93DA,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x10_KHR")]
        CompressedSrgb8Alpha8Astc10x10Khr = 0x93DB,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x10_KHR")]
        CompressedSrgb8Alpha8Astc12x10Khr = 0x93DC,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x12_KHR")]
        CompressedSrgb8Alpha8Astc12x12Khr = 0x93DD,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_3x3x3_OES")]
        CompressedRgbaAstc3x3x3Oes = 0x93C0,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_4x3x3_OES")]
        CompressedRgbaAstc4x3x3Oes = 0x93C1,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_4x4x3_OES")]
        CompressedRgbaAstc4x4x3Oes = 0x93C2,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_4x4x4_OES")]
        CompressedRgbaAstc4x4x4Oes = 0x93C3,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_5x4x4_OES")]
        CompressedRgbaAstc5x4x4Oes = 0x93C4,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_5x5x4_OES")]
        CompressedRgbaAstc5x5x4Oes = 0x93C5,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_5x5x5_OES")]
        CompressedRgbaAstc5x5x5Oes = 0x93C6,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_6x5x5_OES")]
        CompressedRgbaAstc6x5x5Oes = 0x93C7,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_6x6x5_OES")]
        CompressedRgbaAstc6x6x5Oes = 0x93C8,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_6x6x6_OES")]
        CompressedRgbaAstc6x6x6Oes = 0x93C9,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_3x3x3_OES")]
        CompressedSrgb8Alpha8Astc3x3x3Oes = 0x93E0,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x3x3_OES")]
        CompressedSrgb8Alpha8Astc4x3x3Oes = 0x93E1,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x3_OES")]
        CompressedSrgb8Alpha8Astc4x4x3Oes = 0x93E2,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x4_OES")]
        CompressedSrgb8Alpha8Astc4x4x4Oes = 0x93E3,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4x4_OES")]
        CompressedSrgb8Alpha8Astc5x4x4Oes = 0x93E4,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x4_OES")]
        CompressedSrgb8Alpha8Astc5x5x4Oes = 0x93E5,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x5_OES")]
        CompressedSrgb8Alpha8Astc5x5x5Oes = 0x93E6,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5x5_OES")]
        CompressedSrgb8Alpha8Astc6x5x5Oes = 0x93E7,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x5_OES")]
        CompressedSrgb8Alpha8Astc6x6x5Oes = 0x93E8,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x6_OES")]
        CompressedSrgb8Alpha8Astc6x6x6Oes = 0x93E9,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_ARRAY_OES")]
        TextureCubeMapArrayOes = 0x9009,
        [NativeName("Name", "GL_TEXTURE_BINDING_CUBE_MAP_ARRAY_OES")]
        TextureBindingCubeMapArrayOes = 0x900A,
        [NativeName("Name", "GL_SAMPLER_CUBE_MAP_ARRAY_OES")]
        SamplerCubeMapArrayOes = 0x900C,
        [NativeName("Name", "GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW_OES")]
        SamplerCubeMapArrayShadowOes = 0x900D,
        [NativeName("Name", "GL_INT_SAMPLER_CUBE_MAP_ARRAY_OES")]
        IntSamplerCubeMapArrayOes = 0x900E,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_OES")]
        UnsignedIntSamplerCubeMapArrayOes = 0x900F,
        [NativeName("Name", "GL_IMAGE_CUBE_MAP_ARRAY_OES")]
        ImageCubeMapArrayOes = 0x9054,
        [NativeName("Name", "GL_INT_IMAGE_CUBE_MAP_ARRAY_OES")]
        IntImageCubeMapArrayOes = 0x905F,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_OES")]
        UnsignedIntImageCubeMapArrayOes = 0x906A,
        [NativeName("Name", "GL_FLOAT")]
        Float = 0x1406,
        [NativeName("Name", "GL_HALF_FLOAT_OES")]
        HalfFloatOes = 0x8D61,
        [NativeName("Name", "GL_STENCIL_INDEX_OES")]
        StencilIndexOes = 0x1901,
        [NativeName("Name", "GL_STENCIL_INDEX8_OES")]
        StencilIndex8Oes = 0x8D48,
        [NativeName("Name", "GL_TEXTURE_2D_MULTISAMPLE_ARRAY_OES")]
        Texture2DMultisampleArrayOes = 0x9102,
        [NativeName("Name", "GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY_OES")]
        TextureBinding2DMultisampleArrayOes = 0x9105,
        [NativeName("Name", "GL_SAMPLER_2D_MULTISAMPLE_ARRAY_OES")]
        Sampler2DMultisampleArrayOes = 0x910B,
        [NativeName("Name", "GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY_OES")]
        IntSampler2DMultisampleArrayOes = 0x910C,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY_OES")]
        UnsignedIntSampler2DMultisampleArrayOes = 0x910D,
        [NativeName("Name", "GL_TEXTURE_VIEW_MIN_LEVEL_OES")]
        TextureViewMinLevelOes = 0x82DB,
        [NativeName("Name", "GL_TEXTURE_VIEW_NUM_LEVELS_OES")]
        TextureViewNumLevelsOes = 0x82DC,
        [NativeName("Name", "GL_TEXTURE_VIEW_MIN_LAYER_OES")]
        TextureViewMinLayerOes = 0x82DD,
        [NativeName("Name", "GL_TEXTURE_VIEW_NUM_LAYERS_OES")]
        TextureViewNumLayersOes = 0x82DE,
        [NativeName("Name", "GL_TEXTURE_IMMUTABLE_LEVELS")]
        TextureImmutableLevels = 0x82DF,
        [NativeName("Name", "GL_VERTEX_ARRAY_BINDING_OES")]
        VertexArrayBindingOes = 0x85B5,
        [NativeName("Name", "GL_UNSIGNED_INT_10_10_10_2_OES")]
        UnsignedInt1010102Oes = 0x8DF6,
        [NativeName("Name", "GL_INT_10_10_10_2_OES")]
        Int1010102Oes = 0x8DF7,
        [NativeName("Name", "GL_SCISSOR_BOX")]
        ScissorBox = 0xC10,
        [NativeName("Name", "GL_VIEWPORT")]
        Viewport = 0xBA2,
        [NativeName("Name", "GL_DEPTH_RANGE")]
        DepthRange = 0xB70,
        [NativeName("Name", "GL_SCISSOR_TEST")]
        ScissorTest = 0xC11,
        [NativeName("Name", "GL_MAX_VIEWPORTS_OES")]
        MaxViewportsOes = 0x825B,
        [NativeName("Name", "GL_VIEWPORT_SUBPIXEL_BITS_OES")]
        ViewportSubpixelBitsOes = 0x825C,
        [NativeName("Name", "GL_VIEWPORT_BOUNDS_RANGE_OES")]
        ViewportBoundsRangeOes = 0x825D,
        [NativeName("Name", "GL_VIEWPORT_INDEX_PROVOKING_VERTEX_OES")]
        ViewportIndexProvokingVertexOes = 0x825F,
    }
}
