// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [NativeName("Name", "GLenum")]
    public enum EXT : int
    {
        [NativeName("Name", "GL_422_EXT")]
        Gl422Ext = 0x80CC,
        [NativeName("Name", "GL_422_REV_EXT")]
        Gl422RevExt = 0x80CD,
        [NativeName("Name", "GL_422_AVERAGE_EXT")]
        Gl422AverageExt = 0x80CE,
        [NativeName("Name", "GL_422_REV_AVERAGE_EXT")]
        Gl422RevAverageExt = 0x80CF,
        [NativeName("Name", "GL_ABGR_EXT")]
        AbgrExt = 0x8000,
        [NativeName("Name", "GL_BGR_EXT")]
        BgrExt = 0x80E0,
        [NativeName("Name", "GL_BGRA_EXT")]
        BgraExt = 0x80E1,
        [NativeName("Name", "GL_MAX_VERTEX_BINDABLE_UNIFORMS_EXT")]
        MaxVertexBindableUniformsExt = 0x8DE2,
        [NativeName("Name", "GL_MAX_FRAGMENT_BINDABLE_UNIFORMS_EXT")]
        MaxFragmentBindableUniformsExt = 0x8DE3,
        [NativeName("Name", "GL_MAX_GEOMETRY_BINDABLE_UNIFORMS_EXT")]
        MaxGeometryBindableUniformsExt = 0x8DE4,
        [NativeName("Name", "GL_MAX_BINDABLE_UNIFORM_SIZE_EXT")]
        MaxBindableUniformSizeExt = 0x8DED,
        [NativeName("Name", "GL_UNIFORM_BUFFER_EXT")]
        UniformBufferExt = 0x8DEE,
        [NativeName("Name", "GL_UNIFORM_BUFFER_BINDING_EXT")]
        UniformBufferBindingExt = 0x8DEF,
        [NativeName("Name", "GL_CONSTANT_COLOR_EXT")]
        ConstantColorExt = 0x8001,
        [NativeName("Name", "GL_ONE_MINUS_CONSTANT_COLOR_EXT")]
        OneMinusConstantColorExt = 0x8002,
        [NativeName("Name", "GL_CONSTANT_ALPHA_EXT")]
        ConstantAlphaExt = 0x8003,
        [NativeName("Name", "GL_ONE_MINUS_CONSTANT_ALPHA_EXT")]
        OneMinusConstantAlphaExt = 0x8004,
        [NativeName("Name", "GL_BLEND_COLOR_EXT")]
        BlendColorExt = 0x8005,
        [NativeName("Name", "GL_BLEND_EQUATION_RGB_EXT")]
        BlendEquationRgbExt = 0x8009,
        [NativeName("Name", "GL_BLEND_EQUATION_ALPHA_EXT")]
        BlendEquationAlphaExt = 0x883D,
        [NativeName("Name", "GL_BLEND_DST_RGB_EXT")]
        BlendDstRgbExt = 0x80C8,
        [NativeName("Name", "GL_BLEND_SRC_RGB_EXT")]
        BlendSrcRgbExt = 0x80C9,
        [NativeName("Name", "GL_BLEND_DST_ALPHA_EXT")]
        BlendDstAlphaExt = 0x80CA,
        [NativeName("Name", "GL_BLEND_SRC_ALPHA_EXT")]
        BlendSrcAlphaExt = 0x80CB,
        [NativeName("Name", "GL_MIN_EXT")]
        MinExt = 0x8007,
        [NativeName("Name", "GL_MAX_EXT")]
        MaxExt = 0x8008,
        [NativeName("Name", "GL_FUNC_ADD_EXT")]
        FuncAddExt = 0x8006,
        [NativeName("Name", "GL_BLEND_EQUATION_EXT")]
        BlendEquationExt = 0x8009,
        [NativeName("Name", "GL_FUNC_SUBTRACT_EXT")]
        FuncSubtractExt = 0x800A,
        [NativeName("Name", "GL_FUNC_REVERSE_SUBTRACT_EXT")]
        FuncReverseSubtractExt = 0x800B,
        [NativeName("Name", "GL_CLIP_VOLUME_CLIPPING_HINT_EXT")]
        ClipVolumeClippingHintExt = 0x80F0,
        [NativeName("Name", "GL_CMYK_EXT")]
        CmykExt = 0x800C,
        [NativeName("Name", "GL_CMYKA_EXT")]
        CmykaExt = 0x800D,
        [NativeName("Name", "GL_PACK_CMYK_HINT_EXT")]
        PackCmykHintExt = 0x800E,
        [NativeName("Name", "GL_UNPACK_CMYK_HINT_EXT")]
        UnpackCmykHintExt = 0x800F,
        [NativeName("Name", "GL_ARRAY_ELEMENT_LOCK_FIRST_EXT")]
        ArrayElementLockFirstExt = 0x81A8,
        [NativeName("Name", "GL_ARRAY_ELEMENT_LOCK_COUNT_EXT")]
        ArrayElementLockCountExt = 0x81A9,
        [NativeName("Name", "GL_CONVOLUTION_1D_EXT")]
        Convolution1DExt = 0x8010,
        [NativeName("Name", "GL_CONVOLUTION_2D_EXT")]
        Convolution2DExt = 0x8011,
        [NativeName("Name", "GL_SEPARABLE_2D_EXT")]
        Separable2DExt = 0x8012,
        [NativeName("Name", "GL_CONVOLUTION_BORDER_MODE_EXT")]
        ConvolutionBorderModeExt = 0x8013,
        [NativeName("Name", "GL_CONVOLUTION_FILTER_SCALE_EXT")]
        ConvolutionFilterScaleExt = 0x8014,
        [NativeName("Name", "GL_CONVOLUTION_FILTER_BIAS_EXT")]
        ConvolutionFilterBiasExt = 0x8015,
        [NativeName("Name", "GL_REDUCE_EXT")]
        ReduceExt = 0x8016,
        [NativeName("Name", "GL_CONVOLUTION_FORMAT_EXT")]
        ConvolutionFormatExt = 0x8017,
        [NativeName("Name", "GL_CONVOLUTION_WIDTH_EXT")]
        ConvolutionWidthExt = 0x8018,
        [NativeName("Name", "GL_CONVOLUTION_HEIGHT_EXT")]
        ConvolutionHeightExt = 0x8019,
        [NativeName("Name", "GL_MAX_CONVOLUTION_WIDTH_EXT")]
        MaxConvolutionWidthExt = 0x801A,
        [NativeName("Name", "GL_MAX_CONVOLUTION_HEIGHT_EXT")]
        MaxConvolutionHeightExt = 0x801B,
        [NativeName("Name", "GL_POST_CONVOLUTION_RED_SCALE_EXT")]
        PostConvolutionRedScaleExt = 0x801C,
        [NativeName("Name", "GL_POST_CONVOLUTION_GREEN_SCALE_EXT")]
        PostConvolutionGreenScaleExt = 0x801D,
        [NativeName("Name", "GL_POST_CONVOLUTION_BLUE_SCALE_EXT")]
        PostConvolutionBlueScaleExt = 0x801E,
        [NativeName("Name", "GL_POST_CONVOLUTION_ALPHA_SCALE_EXT")]
        PostConvolutionAlphaScaleExt = 0x801F,
        [NativeName("Name", "GL_POST_CONVOLUTION_RED_BIAS_EXT")]
        PostConvolutionRedBiasExt = 0x8020,
        [NativeName("Name", "GL_POST_CONVOLUTION_GREEN_BIAS_EXT")]
        PostConvolutionGreenBiasExt = 0x8021,
        [NativeName("Name", "GL_POST_CONVOLUTION_BLUE_BIAS_EXT")]
        PostConvolutionBlueBiasExt = 0x8022,
        [NativeName("Name", "GL_POST_CONVOLUTION_ALPHA_BIAS_EXT")]
        PostConvolutionAlphaBiasExt = 0x8023,
        [NativeName("Name", "GL_TANGENT_ARRAY_EXT")]
        TangentArrayExt = 0x8439,
        [NativeName("Name", "GL_BINORMAL_ARRAY_EXT")]
        BinormalArrayExt = 0x843A,
        [NativeName("Name", "GL_CURRENT_TANGENT_EXT")]
        CurrentTangentExt = 0x843B,
        [NativeName("Name", "GL_CURRENT_BINORMAL_EXT")]
        CurrentBinormalExt = 0x843C,
        [NativeName("Name", "GL_TANGENT_ARRAY_TYPE_EXT")]
        TangentArrayTypeExt = 0x843E,
        [NativeName("Name", "GL_TANGENT_ARRAY_STRIDE_EXT")]
        TangentArrayStrideExt = 0x843F,
        [NativeName("Name", "GL_BINORMAL_ARRAY_TYPE_EXT")]
        BinormalArrayTypeExt = 0x8440,
        [NativeName("Name", "GL_BINORMAL_ARRAY_STRIDE_EXT")]
        BinormalArrayStrideExt = 0x8441,
        [NativeName("Name", "GL_TANGENT_ARRAY_POINTER_EXT")]
        TangentArrayPointerExt = 0x8442,
        [NativeName("Name", "GL_BINORMAL_ARRAY_POINTER_EXT")]
        BinormalArrayPointerExt = 0x8443,
        [NativeName("Name", "GL_MAP1_TANGENT_EXT")]
        Map1TangentExt = 0x8444,
        [NativeName("Name", "GL_MAP2_TANGENT_EXT")]
        Map2TangentExt = 0x8445,
        [NativeName("Name", "GL_MAP1_BINORMAL_EXT")]
        Map1BinormalExt = 0x8446,
        [NativeName("Name", "GL_MAP2_BINORMAL_EXT")]
        Map2BinormalExt = 0x8447,
        [NativeName("Name", "GL_CULL_VERTEX_EXT")]
        CullVertexExt = 0x81AA,
        [NativeName("Name", "GL_CULL_VERTEX_EYE_POSITION_EXT")]
        CullVertexEyePositionExt = 0x81AB,
        [NativeName("Name", "GL_CULL_VERTEX_OBJECT_POSITION_EXT")]
        CullVertexObjectPositionExt = 0x81AC,
        [NativeName("Name", "GL_PROGRAM_PIPELINE_OBJECT_EXT")]
        ProgramPipelineObjectExt = 0x8A4F,
        [NativeName("Name", "GL_PROGRAM_OBJECT_EXT")]
        ProgramObjectExt = 0x8B40,
        [NativeName("Name", "GL_SHADER_OBJECT_EXT")]
        ShaderObjectExt = 0x8B48,
        [NativeName("Name", "GL_BUFFER_OBJECT_EXT")]
        BufferObjectExt = 0x9151,
        [NativeName("Name", "GL_QUERY_OBJECT_EXT")]
        QueryObjectExt = 0x9153,
        [NativeName("Name", "GL_VERTEX_ARRAY_OBJECT_EXT")]
        VertexArrayObjectExt = 0x9154,
        [NativeName("Name", "GL_SAMPLER")]
        Sampler = 0x82E6,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK")]
        TransformFeedback = 0x8E22,
        [NativeName("Name", "GL_DEPTH_BOUNDS_TEST_EXT")]
        DepthBoundsTestExt = 0x8890,
        [NativeName("Name", "GL_DEPTH_BOUNDS_EXT")]
        DepthBoundsExt = 0x8891,
        [NativeName("Name", "GL_PROGRAM_MATRIX_EXT")]
        ProgramMatrixExt = 0x8E2D,
        [NativeName("Name", "GL_TRANSPOSE_PROGRAM_MATRIX_EXT")]
        TransposeProgramMatrixExt = 0x8E2E,
        [NativeName("Name", "GL_PROGRAM_MATRIX_STACK_DEPTH_EXT")]
        ProgramMatrixStackDepthExt = 0x8E2F,
        [NativeName("Name", "GL_MAX_ELEMENTS_VERTICES_EXT")]
        MaxElementsVerticesExt = 0x80E8,
        [NativeName("Name", "GL_MAX_ELEMENTS_INDICES_EXT")]
        MaxElementsIndicesExt = 0x80E9,
        [NativeName("Name", "GL_FOG_COORDINATE_SOURCE_EXT")]
        FogCoordinateSourceExt = 0x8450,
        [NativeName("Name", "GL_FOG_COORDINATE_EXT")]
        FogCoordinateExt = 0x8451,
        [NativeName("Name", "GL_FRAGMENT_DEPTH_EXT")]
        FragmentDepthExt = 0x8452,
        [NativeName("Name", "GL_CURRENT_FOG_COORDINATE_EXT")]
        CurrentFogCoordinateExt = 0x8453,
        [NativeName("Name", "GL_FOG_COORDINATE_ARRAY_TYPE_EXT")]
        FogCoordinateArrayTypeExt = 0x8454,
        [NativeName("Name", "GL_FOG_COORDINATE_ARRAY_STRIDE_EXT")]
        FogCoordinateArrayStrideExt = 0x8455,
        [NativeName("Name", "GL_FOG_COORDINATE_ARRAY_POINTER_EXT")]
        FogCoordinateArrayPointerExt = 0x8456,
        [NativeName("Name", "GL_FOG_COORDINATE_ARRAY_EXT")]
        FogCoordinateArrayExt = 0x8457,
        [NativeName("Name", "GL_SHADING_RATE_1X1_PIXELS_EXT")]
        ShadingRate1X1PixelsExt = 0x96A6,
        [NativeName("Name", "GL_SHADING_RATE_1X2_PIXELS_EXT")]
        ShadingRate1X2PixelsExt = 0x96A7,
        [NativeName("Name", "GL_SHADING_RATE_2X1_PIXELS_EXT")]
        ShadingRate2X1PixelsExt = 0x96A8,
        [NativeName("Name", "GL_SHADING_RATE_2X2_PIXELS_EXT")]
        ShadingRate2X2PixelsExt = 0x96A9,
        [NativeName("Name", "GL_SHADING_RATE_1X4_PIXELS_EXT")]
        ShadingRate1X4PixelsExt = 0x96AA,
        [NativeName("Name", "GL_SHADING_RATE_4X1_PIXELS_EXT")]
        ShadingRate4X1PixelsExt = 0x96AB,
        [NativeName("Name", "GL_SHADING_RATE_4X2_PIXELS_EXT")]
        ShadingRate4X2PixelsExt = 0x96AC,
        [NativeName("Name", "GL_SHADING_RATE_2X4_PIXELS_EXT")]
        ShadingRate2X4PixelsExt = 0x96AD,
        [NativeName("Name", "GL_SHADING_RATE_4X4_PIXELS_EXT")]
        ShadingRate4X4PixelsExt = 0x96AE,
        [NativeName("Name", "GL_SHADING_RATE_EXT")]
        ShadingRateExt = 0x96D0,
        [NativeName("Name", "GL_SHADING_RATE_ATTACHMENT_EXT")]
        ShadingRateAttachmentExt = 0x96D1,
        [NativeName("Name", "GL_FRAGMENT_SHADING_RATE_COMBINER_OP_KEEP_EXT")]
        FragmentShadingRateCombinerOpKeepExt = 0x96D2,
        [NativeName("Name", "GL_FRAGMENT_SHADING_RATE_COMBINER_OP_REPLACE_EXT")]
        FragmentShadingRateCombinerOpReplaceExt = 0x96D3,
        [NativeName("Name", "GL_FRAGMENT_SHADING_RATE_COMBINER_OP_MIN_EXT")]
        FragmentShadingRateCombinerOpMinExt = 0x96D4,
        [NativeName("Name", "GL_FRAGMENT_SHADING_RATE_COMBINER_OP_MAX_EXT")]
        FragmentShadingRateCombinerOpMaxExt = 0x96D5,
        [NativeName("Name", "GL_FRAGMENT_SHADING_RATE_COMBINER_OP_MUL_EXT")]
        FragmentShadingRateCombinerOpMulExt = 0x96D6,
        [NativeName("Name", "GL_MIN_FRAGMENT_SHADING_RATE_ATTACHMENT_TEXEL_WIDTH_EXT")]
        MinFragmentShadingRateAttachmentTexelWidthExt = 0x96D7,
        [NativeName("Name", "GL_MAX_FRAGMENT_SHADING_RATE_ATTACHMENT_TEXEL_WIDTH_EXT")]
        MaxFragmentShadingRateAttachmentTexelWidthExt = 0x96D8,
        [NativeName("Name", "GL_MIN_FRAGMENT_SHADING_RATE_ATTACHMENT_TEXEL_HEIGHT_EXT")]
        MinFragmentShadingRateAttachmentTexelHeightExt = 0x96D9,
        [NativeName("Name", "GL_MAX_FRAGMENT_SHADING_RATE_ATTACHMENT_TEXEL_HEIGHT_EXT")]
        MaxFragmentShadingRateAttachmentTexelHeightExt = 0x96DA,
        [NativeName("Name", "GL_MAX_FRAGMENT_SHADING_RATE_ATTACHMENT_TEXEL_ASPECT_RATIO_EXT")]
        MaxFragmentShadingRateAttachmentTexelAspectRatioExt = 0x96DB,
        [NativeName("Name", "GL_MAX_FRAGMENT_SHADING_RATE_ATTACHMENT_LAYERS_EXT")]
        MaxFragmentShadingRateAttachmentLayersExt = 0x96DC,
        [NativeName("Name", "GL_FRAGMENT_SHADING_RATE_WITH_SHADER_DEPTH_STENCIL_WRITES_SUPPORTED_EXT")]
        FragmentShadingRateWithShaderDepthStencilWritesSupportedExt = 0x96DD,
        [NativeName("Name", "GL_FRAGMENT_SHADING_RATE_WITH_SAMPLE_MASK_SUPPORTED_EXT")]
        FragmentShadingRateWithSampleMaskSupportedExt = 0x96DE,
        [NativeName("Name", "GL_FRAGMENT_SHADING_RATE_ATTACHMENT_WITH_DEFAULT_FRAMEBUFFER_SUPPORTED_EXT")]
        FragmentShadingRateAttachmentWithDefaultFramebufferSupportedExt = 0x96DF,
        [NativeName("Name", "GL_FRAGMENT_SHADING_RATE_NON_TRIVIAL_COMBINERS_SUPPORTED_EXT")]
        FragmentShadingRateNonTrivialCombinersSupportedExt = 0x8F6F,
        [NativeName("Name", "GL_FRAGMENT_SHADING_RATE_PRIMITIVE_RATE_WITH_MULTI_VIEWPORT_SUPPORTED_EXT")]
        FragmentShadingRatePrimitiveRateWithMultiViewportSupportedExt = 0x9780,
        [NativeName("Name", "GL_READ_FRAMEBUFFER_EXT")]
        ReadFramebufferExt = 0x8CA8,
        [NativeName("Name", "GL_DRAW_FRAMEBUFFER_EXT")]
        DrawFramebufferExt = 0x8CA9,
        [NativeName("Name", "GL_DRAW_FRAMEBUFFER_BINDING_EXT")]
        DrawFramebufferBindingExt = 0x8CA6,
        [NativeName("Name", "GL_READ_FRAMEBUFFER_BINDING_EXT")]
        ReadFramebufferBindingExt = 0x8CAA,
        [NativeName("Name", "GL_RENDERBUFFER_SAMPLES_EXT")]
        RenderbufferSamplesExt = 0x8CAB,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_EXT")]
        FramebufferIncompleteMultisampleExt = 0x8D56,
        [NativeName("Name", "GL_MAX_SAMPLES_EXT")]
        MaxSamplesExt = 0x8D57,
        [NativeName("Name", "GL_SCALED_RESOLVE_FASTEST_EXT")]
        ScaledResolveFastestExt = 0x90BA,
        [NativeName("Name", "GL_SCALED_RESOLVE_NICEST_EXT")]
        ScaledResolveNicestExt = 0x90BB,
        [NativeName("Name", "GL_INVALID_FRAMEBUFFER_OPERATION_EXT")]
        InvalidFramebufferOperationExt = 0x506,
        [NativeName("Name", "GL_MAX_RENDERBUFFER_SIZE_EXT")]
        MaxRenderbufferSizeExt = 0x84E8,
        [NativeName("Name", "GL_FRAMEBUFFER_BINDING_EXT")]
        FramebufferBindingExt = 0x8CA6,
        [NativeName("Name", "GL_RENDERBUFFER_BINDING_EXT")]
        RenderbufferBindingExt = 0x8CA7,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_EXT")]
        FramebufferAttachmentObjectTypeExt = 0x8CD0,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_EXT")]
        FramebufferAttachmentObjectNameExt = 0x8CD1,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_EXT")]
        FramebufferAttachmentTextureLevelExt = 0x8CD2,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_EXT")]
        FramebufferAttachmentTextureCubeMapFaceExt = 0x8CD3,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_EXT")]
        FramebufferAttachmentTexture3DZoffsetExt = 0x8CD4,
        [NativeName("Name", "GL_FRAMEBUFFER_COMPLETE_EXT")]
        FramebufferCompleteExt = 0x8CD5,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_EXT")]
        FramebufferIncompleteAttachmentExt = 0x8CD6,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_EXT")]
        FramebufferIncompleteMissingAttachmentExt = 0x8CD7,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_EXT")]
        FramebufferIncompleteDimensionsExt = 0x8CD9,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_FORMATS_EXT")]
        FramebufferIncompleteFormatsExt = 0x8CDA,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER_EXT")]
        FramebufferIncompleteDrawBufferExt = 0x8CDB,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER_EXT")]
        FramebufferIncompleteReadBufferExt = 0x8CDC,
        [NativeName("Name", "GL_FRAMEBUFFER_UNSUPPORTED_EXT")]
        FramebufferUnsupportedExt = 0x8CDD,
        [NativeName("Name", "GL_MAX_COLOR_ATTACHMENTS_EXT")]
        MaxColorAttachmentsExt = 0x8CDF,
        [NativeName("Name", "GL_COLOR_ATTACHMENT0_EXT")]
        ColorAttachment0Ext = 0x8CE0,
        [NativeName("Name", "GL_COLOR_ATTACHMENT1_EXT")]
        ColorAttachment1Ext = 0x8CE1,
        [NativeName("Name", "GL_COLOR_ATTACHMENT2_EXT")]
        ColorAttachment2Ext = 0x8CE2,
        [NativeName("Name", "GL_COLOR_ATTACHMENT3_EXT")]
        ColorAttachment3Ext = 0x8CE3,
        [NativeName("Name", "GL_COLOR_ATTACHMENT4_EXT")]
        ColorAttachment4Ext = 0x8CE4,
        [NativeName("Name", "GL_COLOR_ATTACHMENT5_EXT")]
        ColorAttachment5Ext = 0x8CE5,
        [NativeName("Name", "GL_COLOR_ATTACHMENT6_EXT")]
        ColorAttachment6Ext = 0x8CE6,
        [NativeName("Name", "GL_COLOR_ATTACHMENT7_EXT")]
        ColorAttachment7Ext = 0x8CE7,
        [NativeName("Name", "GL_COLOR_ATTACHMENT8_EXT")]
        ColorAttachment8Ext = 0x8CE8,
        [NativeName("Name", "GL_COLOR_ATTACHMENT9_EXT")]
        ColorAttachment9Ext = 0x8CE9,
        [NativeName("Name", "GL_COLOR_ATTACHMENT10_EXT")]
        ColorAttachment10Ext = 0x8CEA,
        [NativeName("Name", "GL_COLOR_ATTACHMENT11_EXT")]
        ColorAttachment11Ext = 0x8CEB,
        [NativeName("Name", "GL_COLOR_ATTACHMENT12_EXT")]
        ColorAttachment12Ext = 0x8CEC,
        [NativeName("Name", "GL_COLOR_ATTACHMENT13_EXT")]
        ColorAttachment13Ext = 0x8CED,
        [NativeName("Name", "GL_COLOR_ATTACHMENT14_EXT")]
        ColorAttachment14Ext = 0x8CEE,
        [NativeName("Name", "GL_COLOR_ATTACHMENT15_EXT")]
        ColorAttachment15Ext = 0x8CEF,
        [NativeName("Name", "GL_DEPTH_ATTACHMENT_EXT")]
        DepthAttachmentExt = 0x8D00,
        [NativeName("Name", "GL_STENCIL_ATTACHMENT_EXT")]
        StencilAttachmentExt = 0x8D20,
        [NativeName("Name", "GL_FRAMEBUFFER_EXT")]
        FramebufferExt = 0x8D40,
        [NativeName("Name", "GL_RENDERBUFFER_EXT")]
        RenderbufferExt = 0x8D41,
        [NativeName("Name", "GL_RENDERBUFFER_WIDTH_EXT")]
        RenderbufferWidthExt = 0x8D42,
        [NativeName("Name", "GL_RENDERBUFFER_HEIGHT_EXT")]
        RenderbufferHeightExt = 0x8D43,
        [NativeName("Name", "GL_RENDERBUFFER_INTERNAL_FORMAT_EXT")]
        RenderbufferInternalFormatExt = 0x8D44,
        [NativeName("Name", "GL_STENCIL_INDEX1_EXT")]
        StencilIndex1Ext = 0x8D46,
        [NativeName("Name", "GL_STENCIL_INDEX4_EXT")]
        StencilIndex4Ext = 0x8D47,
        [NativeName("Name", "GL_STENCIL_INDEX8_EXT")]
        StencilIndex8Ext = 0x8D48,
        [NativeName("Name", "GL_STENCIL_INDEX16_EXT")]
        StencilIndex16Ext = 0x8D49,
        [NativeName("Name", "GL_RENDERBUFFER_RED_SIZE_EXT")]
        RenderbufferRedSizeExt = 0x8D50,
        [NativeName("Name", "GL_RENDERBUFFER_GREEN_SIZE_EXT")]
        RenderbufferGreenSizeExt = 0x8D51,
        [NativeName("Name", "GL_RENDERBUFFER_BLUE_SIZE_EXT")]
        RenderbufferBlueSizeExt = 0x8D52,
        [NativeName("Name", "GL_RENDERBUFFER_ALPHA_SIZE_EXT")]
        RenderbufferAlphaSizeExt = 0x8D53,
        [NativeName("Name", "GL_RENDERBUFFER_DEPTH_SIZE_EXT")]
        RenderbufferDepthSizeExt = 0x8D54,
        [NativeName("Name", "GL_RENDERBUFFER_STENCIL_SIZE_EXT")]
        RenderbufferStencilSizeExt = 0x8D55,
        [NativeName("Name", "GL_FRAMEBUFFER_SRGB_EXT")]
        FramebufferSrgbExt = 0x8DB9,
        [NativeName("Name", "GL_FRAMEBUFFER_SRGB_CAPABLE_EXT")]
        FramebufferSrgbCapableExt = 0x8DBA,
        [NativeName("Name", "GL_GEOMETRY_SHADER_EXT")]
        GeometryShaderExt = 0x8DD9,
        [NativeName("Name", "GL_GEOMETRY_VERTICES_OUT_EXT")]
        GeometryVerticesOutExt = 0x8DDA,
        [NativeName("Name", "GL_GEOMETRY_INPUT_TYPE_EXT")]
        GeometryInputTypeExt = 0x8DDB,
        [NativeName("Name", "GL_GEOMETRY_OUTPUT_TYPE_EXT")]
        GeometryOutputTypeExt = 0x8DDC,
        [NativeName("Name", "GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_EXT")]
        MaxGeometryTextureImageUnitsExt = 0x8C29,
        [NativeName("Name", "GL_MAX_GEOMETRY_VARYING_COMPONENTS_EXT")]
        MaxGeometryVaryingComponentsExt = 0x8DDD,
        [NativeName("Name", "GL_MAX_VERTEX_VARYING_COMPONENTS_EXT")]
        MaxVertexVaryingComponentsExt = 0x8DDE,
        [NativeName("Name", "GL_MAX_VARYING_COMPONENTS_EXT")]
        MaxVaryingComponentsExt = 0x8B4B,
        [NativeName("Name", "GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_EXT")]
        MaxGeometryUniformComponentsExt = 0x8DDF,
        [NativeName("Name", "GL_MAX_GEOMETRY_OUTPUT_VERTICES_EXT")]
        MaxGeometryOutputVerticesExt = 0x8DE0,
        [NativeName("Name", "GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_EXT")]
        MaxGeometryTotalOutputComponentsExt = 0x8DE1,
        [NativeName("Name", "GL_LINES_ADJACENCY_EXT")]
        LinesAdjacencyExt = 0xA,
        [NativeName("Name", "GL_LINE_STRIP_ADJACENCY_EXT")]
        LineStripAdjacencyExt = 0xB,
        [NativeName("Name", "GL_TRIANGLES_ADJACENCY_EXT")]
        TrianglesAdjacencyExt = 0xC,
        [NativeName("Name", "GL_TRIANGLE_STRIP_ADJACENCY_EXT")]
        TriangleStripAdjacencyExt = 0xD,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_EXT")]
        FramebufferIncompleteLayerTargetsExt = 0x8DA8,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_EXT")]
        FramebufferIncompleteLayerCountExt = 0x8DA9,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_LAYERED_EXT")]
        FramebufferAttachmentLayeredExt = 0x8DA7,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER_EXT")]
        FramebufferAttachmentTextureLayerExt = 0x8CD4,
        [NativeName("Name", "GL_PROGRAM_POINT_SIZE_EXT")]
        ProgramPointSizeExt = 0x8642,
        [NativeName("Name", "GL_SAMPLER_1D_ARRAY_EXT")]
        Sampler1DArrayExt = 0x8DC0,
        [NativeName("Name", "GL_SAMPLER_2D_ARRAY_EXT")]
        Sampler2DArrayExt = 0x8DC1,
        [NativeName("Name", "GL_SAMPLER_BUFFER_EXT")]
        SamplerBufferExt = 0x8DC2,
        [NativeName("Name", "GL_SAMPLER_1D_ARRAY_SHADOW_EXT")]
        Sampler1DArrayShadowExt = 0x8DC3,
        [NativeName("Name", "GL_SAMPLER_2D_ARRAY_SHADOW_EXT")]
        Sampler2DArrayShadowExt = 0x8DC4,
        [NativeName("Name", "GL_SAMPLER_CUBE_SHADOW_EXT")]
        SamplerCubeShadowExt = 0x8DC5,
        [NativeName("Name", "GL_UNSIGNED_INT_VEC2_EXT")]
        UnsignedIntVec2Ext = 0x8DC6,
        [NativeName("Name", "GL_UNSIGNED_INT_VEC3_EXT")]
        UnsignedIntVec3Ext = 0x8DC7,
        [NativeName("Name", "GL_UNSIGNED_INT_VEC4_EXT")]
        UnsignedIntVec4Ext = 0x8DC8,
        [NativeName("Name", "GL_INT_SAMPLER_1D_EXT")]
        IntSampler1DExt = 0x8DC9,
        [NativeName("Name", "GL_INT_SAMPLER_2D_EXT")]
        IntSampler2DExt = 0x8DCA,
        [NativeName("Name", "GL_INT_SAMPLER_3D_EXT")]
        IntSampler3DExt = 0x8DCB,
        [NativeName("Name", "GL_INT_SAMPLER_CUBE_EXT")]
        IntSamplerCubeExt = 0x8DCC,
        [NativeName("Name", "GL_INT_SAMPLER_2D_RECT_EXT")]
        IntSampler2DRectExt = 0x8DCD,
        [NativeName("Name", "GL_INT_SAMPLER_1D_ARRAY_EXT")]
        IntSampler1DArrayExt = 0x8DCE,
        [NativeName("Name", "GL_INT_SAMPLER_2D_ARRAY_EXT")]
        IntSampler2DArrayExt = 0x8DCF,
        [NativeName("Name", "GL_INT_SAMPLER_BUFFER_EXT")]
        IntSamplerBufferExt = 0x8DD0,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_1D_EXT")]
        UnsignedIntSampler1DExt = 0x8DD1,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_2D_EXT")]
        UnsignedIntSampler2DExt = 0x8DD2,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_3D_EXT")]
        UnsignedIntSampler3DExt = 0x8DD3,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_CUBE_EXT")]
        UnsignedIntSamplerCubeExt = 0x8DD4,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_2D_RECT_EXT")]
        UnsignedIntSampler2DRectExt = 0x8DD5,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_1D_ARRAY_EXT")]
        UnsignedIntSampler1DArrayExt = 0x8DD6,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_2D_ARRAY_EXT")]
        UnsignedIntSampler2DArrayExt = 0x8DD7,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_BUFFER_EXT")]
        UnsignedIntSamplerBufferExt = 0x8DD8,
        [NativeName("Name", "GL_MIN_PROGRAM_TEXEL_OFFSET_EXT")]
        MinProgramTexelOffsetExt = 0x8904,
        [NativeName("Name", "GL_MAX_PROGRAM_TEXEL_OFFSET_EXT")]
        MaxProgramTexelOffsetExt = 0x8905,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_INTEGER_EXT")]
        VertexAttribArrayIntegerExt = 0x88FD,
        [NativeName("Name", "GL_HISTOGRAM_EXT")]
        HistogramExt = 0x8024,
        [NativeName("Name", "GL_PROXY_HISTOGRAM_EXT")]
        ProxyHistogramExt = 0x8025,
        [NativeName("Name", "GL_HISTOGRAM_WIDTH_EXT")]
        HistogramWidthExt = 0x8026,
        [NativeName("Name", "GL_HISTOGRAM_FORMAT_EXT")]
        HistogramFormatExt = 0x8027,
        [NativeName("Name", "GL_HISTOGRAM_RED_SIZE_EXT")]
        HistogramRedSizeExt = 0x8028,
        [NativeName("Name", "GL_HISTOGRAM_GREEN_SIZE_EXT")]
        HistogramGreenSizeExt = 0x8029,
        [NativeName("Name", "GL_HISTOGRAM_BLUE_SIZE_EXT")]
        HistogramBlueSizeExt = 0x802A,
        [NativeName("Name", "GL_HISTOGRAM_ALPHA_SIZE_EXT")]
        HistogramAlphaSizeExt = 0x802B,
        [NativeName("Name", "GL_HISTOGRAM_LUMINANCE_SIZE_EXT")]
        HistogramLuminanceSizeExt = 0x802C,
        [NativeName("Name", "GL_HISTOGRAM_SINK_EXT")]
        HistogramSinkExt = 0x802D,
        [NativeName("Name", "GL_MINMAX_EXT")]
        MinmaxExt = 0x802E,
        [NativeName("Name", "GL_MINMAX_FORMAT_EXT")]
        MinmaxFormatExt = 0x802F,
        [NativeName("Name", "GL_MINMAX_SINK_EXT")]
        MinmaxSinkExt = 0x8030,
        [NativeName("Name", "GL_TABLE_TOO_LARGE_EXT")]
        TableTooLargeExt = 0x8031,
        [NativeName("Name", "GL_IUI_V2F_EXT")]
        IuiV2fExt = 0x81AD,
        [NativeName("Name", "GL_IUI_V3F_EXT")]
        IuiV3fExt = 0x81AE,
        [NativeName("Name", "GL_IUI_N3F_V2F_EXT")]
        IuiN3fV2fExt = 0x81AF,
        [NativeName("Name", "GL_IUI_N3F_V3F_EXT")]
        IuiN3fV3fExt = 0x81B0,
        [NativeName("Name", "GL_T2F_IUI_V2F_EXT")]
        T2fIuiV2fExt = 0x81B1,
        [NativeName("Name", "GL_T2F_IUI_V3F_EXT")]
        T2fIuiV3fExt = 0x81B2,
        [NativeName("Name", "GL_T2F_IUI_N3F_V2F_EXT")]
        T2fIuiN3fV2fExt = 0x81B3,
        [NativeName("Name", "GL_T2F_IUI_N3F_V3F_EXT")]
        T2fIuiN3fV3fExt = 0x81B4,
        [NativeName("Name", "GL_INDEX_TEST_EXT")]
        IndexTestExt = 0x81B5,
        [NativeName("Name", "GL_INDEX_TEST_FUNC_EXT")]
        IndexTestFuncExt = 0x81B6,
        [NativeName("Name", "GL_INDEX_TEST_REF_EXT")]
        IndexTestRefExt = 0x81B7,
        [NativeName("Name", "GL_INDEX_MATERIAL_EXT")]
        IndexMaterialExt = 0x81B8,
        [NativeName("Name", "GL_INDEX_MATERIAL_PARAMETER_EXT")]
        IndexMaterialParameterExt = 0x81B9,
        [NativeName("Name", "GL_INDEX_MATERIAL_FACE_EXT")]
        IndexMaterialFaceExt = 0x81BA,
        [NativeName("Name", "GL_FRAGMENT_MATERIAL_EXT")]
        FragmentMaterialExt = 0x8349,
        [NativeName("Name", "GL_FRAGMENT_NORMAL_EXT")]
        FragmentNormalExt = 0x834A,
        [NativeName("Name", "GL_FRAGMENT_COLOR_EXT")]
        FragmentColorExt = 0x834C,
        [NativeName("Name", "GL_ATTENUATION_EXT")]
        AttenuationExt = 0x834D,
        [NativeName("Name", "GL_SHADOW_ATTENUATION_EXT")]
        ShadowAttenuationExt = 0x834E,
        [NativeName("Name", "GL_TEXTURE_APPLICATION_MODE_EXT")]
        TextureApplicationModeExt = 0x834F,
        [NativeName("Name", "GL_TEXTURE_LIGHT_EXT")]
        TextureLightExt = 0x8350,
        [NativeName("Name", "GL_TEXTURE_MATERIAL_FACE_EXT")]
        TextureMaterialFaceExt = 0x8351,
        [NativeName("Name", "GL_TEXTURE_MATERIAL_PARAMETER_EXT")]
        TextureMaterialParameterExt = 0x8352,
        [NativeName("Name", "GL_TEXTURE_TILING_EXT")]
        TextureTilingExt = 0x9580,
        [NativeName("Name", "GL_DEDICATED_MEMORY_OBJECT_EXT")]
        DedicatedMemoryObjectExt = 0x9581,
        [NativeName("Name", "GL_PROTECTED_MEMORY_OBJECT_EXT")]
        ProtectedMemoryObjectExt = 0x959B,
        [NativeName("Name", "GL_NUM_TILING_TYPES_EXT")]
        NumTilingTypesExt = 0x9582,
        [NativeName("Name", "GL_TILING_TYPES_EXT")]
        TilingTypesExt = 0x9583,
        [NativeName("Name", "GL_OPTIMAL_TILING_EXT")]
        OptimalTilingExt = 0x9584,
        [NativeName("Name", "GL_LINEAR_TILING_EXT")]
        LinearTilingExt = 0x9585,
        [NativeName("Name", "GL_NUM_DEVICE_UUIDS_EXT")]
        NumDeviceUuidsExt = 0x9596,
        [NativeName("Name", "GL_DEVICE_UUID_EXT")]
        DeviceUuidExt = 0x9597,
        [NativeName("Name", "GL_DRIVER_UUID_EXT")]
        DriverUuidExt = 0x9598,
        [NativeName("Name", "GL_UUID_SIZE_EXT")]
        UuidSizeExt = 0x16,
        [NativeName("Name", "GL_HANDLE_TYPE_OPAQUE_FD_EXT")]
        HandleTypeOpaqueFDExt = 0x9586,
        [NativeName("Name", "GL_HANDLE_TYPE_OPAQUE_WIN32_EXT")]
        HandleTypeOpaqueWin32Ext = 0x9587,
        [NativeName("Name", "GL_HANDLE_TYPE_OPAQUE_WIN32_KMT_EXT")]
        HandleTypeOpaqueWin32KmtExt = 0x9588,
        [NativeName("Name", "GL_DEVICE_LUID_EXT")]
        DeviceLuidExt = 0x9599,
        [NativeName("Name", "GL_DEVICE_NODE_MASK_EXT")]
        DeviceNodeMaskExt = 0x959A,
        [NativeName("Name", "GL_LUID_SIZE_EXT")]
        LuidSizeExt = 0x8,
        [NativeName("Name", "GL_HANDLE_TYPE_D3D12_TILEPOOL_EXT")]
        HandleTypeD3D12TilepoolExt = 0x9589,
        [NativeName("Name", "GL_HANDLE_TYPE_D3D12_RESOURCE_EXT")]
        HandleTypeD3D12ResourceExt = 0x958A,
        [NativeName("Name", "GL_HANDLE_TYPE_D3D11_IMAGE_EXT")]
        HandleTypeD3D11ImageExt = 0x958B,
        [NativeName("Name", "GL_HANDLE_TYPE_D3D11_IMAGE_KMT_EXT")]
        HandleTypeD3D11ImageKmtExt = 0x958C,
        [NativeName("Name", "GL_MESH_SHADER_EXT")]
        MeshShaderExt = 0x9559,
        [NativeName("Name", "GL_TASK_SHADER_EXT")]
        TaskShaderExt = 0x955A,
        [NativeName("Name", "GL_MAX_MESH_UNIFORM_BLOCKS_EXT")]
        MaxMeshUniformBlocksExt = 0x8E60,
        [NativeName("Name", "GL_MAX_MESH_TEXTURE_IMAGE_UNITS_EXT")]
        MaxMeshTextureImageUnitsExt = 0x8E61,
        [NativeName("Name", "GL_MAX_MESH_IMAGE_UNIFORMS_EXT")]
        MaxMeshImageUniformsExt = 0x8E62,
        [NativeName("Name", "GL_MAX_MESH_UNIFORM_COMPONENTS_EXT")]
        MaxMeshUniformComponentsExt = 0x8E63,
        [NativeName("Name", "GL_MAX_MESH_ATOMIC_COUNTER_BUFFERS_EXT")]
        MaxMeshAtomicCounterBuffersExt = 0x8E64,
        [NativeName("Name", "GL_MAX_MESH_ATOMIC_COUNTERS_EXT")]
        MaxMeshAtomicCountersExt = 0x8E65,
        [NativeName("Name", "GL_MAX_MESH_SHADER_STORAGE_BLOCKS_EXT")]
        MaxMeshShaderStorageBlocksExt = 0x8E66,
        [NativeName("Name", "GL_MAX_COMBINED_MESH_UNIFORM_COMPONENTS_EXT")]
        MaxCombinedMeshUniformComponentsExt = 0x8E67,
        [NativeName("Name", "GL_MAX_TASK_UNIFORM_BLOCKS_EXT")]
        MaxTaskUniformBlocksExt = 0x8E68,
        [NativeName("Name", "GL_MAX_TASK_TEXTURE_IMAGE_UNITS_EXT")]
        MaxTaskTextureImageUnitsExt = 0x8E69,
        [NativeName("Name", "GL_MAX_TASK_IMAGE_UNIFORMS_EXT")]
        MaxTaskImageUniformsExt = 0x8E6A,
        [NativeName("Name", "GL_MAX_TASK_UNIFORM_COMPONENTS_EXT")]
        MaxTaskUniformComponentsExt = 0x8E6B,
        [NativeName("Name", "GL_MAX_TASK_ATOMIC_COUNTER_BUFFERS_EXT")]
        MaxTaskAtomicCounterBuffersExt = 0x8E6C,
        [NativeName("Name", "GL_MAX_TASK_ATOMIC_COUNTERS_EXT")]
        MaxTaskAtomicCountersExt = 0x8E6D,
        [NativeName("Name", "GL_MAX_TASK_SHADER_STORAGE_BLOCKS_EXT")]
        MaxTaskShaderStorageBlocksExt = 0x8E6E,
        [NativeName("Name", "GL_MAX_COMBINED_TASK_UNIFORM_COMPONENTS_EXT")]
        MaxCombinedTaskUniformComponentsExt = 0x8E6F,
        [NativeName("Name", "GL_MAX_TASK_WORK_GROUP_TOTAL_COUNT_EXT")]
        MaxTaskWorkGroupTotalCountExt = 0x9740,
        [NativeName("Name", "GL_MAX_MESH_WORK_GROUP_TOTAL_COUNT_EXT")]
        MaxMeshWorkGroupTotalCountExt = 0x9741,
        [NativeName("Name", "GL_MAX_MESH_WORK_GROUP_INVOCATIONS_EXT")]
        MaxMeshWorkGroupInvocationsExt = 0x9757,
        [NativeName("Name", "GL_MAX_TASK_WORK_GROUP_INVOCATIONS_EXT")]
        MaxTaskWorkGroupInvocationsExt = 0x9759,
        [NativeName("Name", "GL_MAX_TASK_PAYLOAD_SIZE_EXT")]
        MaxTaskPayloadSizeExt = 0x9742,
        [NativeName("Name", "GL_MAX_TASK_SHARED_MEMORY_SIZE_EXT")]
        MaxTaskSharedMemorySizeExt = 0x9743,
        [NativeName("Name", "GL_MAX_MESH_SHARED_MEMORY_SIZE_EXT")]
        MaxMeshSharedMemorySizeExt = 0x9744,
        [NativeName("Name", "GL_MAX_TASK_PAYLOAD_AND_SHARED_MEMORY_SIZE_EXT")]
        MaxTaskPayloadAndSharedMemorySizeExt = 0x9745,
        [NativeName("Name", "GL_MAX_MESH_PAYLOAD_AND_SHARED_MEMORY_SIZE_EXT")]
        MaxMeshPayloadAndSharedMemorySizeExt = 0x9746,
        [NativeName("Name", "GL_MAX_MESH_OUTPUT_MEMORY_SIZE_EXT")]
        MaxMeshOutputMemorySizeExt = 0x9747,
        [NativeName("Name", "GL_MAX_MESH_PAYLOAD_AND_OUTPUT_MEMORY_SIZE_EXT")]
        MaxMeshPayloadAndOutputMemorySizeExt = 0x9748,
        [NativeName("Name", "GL_MAX_MESH_OUTPUT_VERTICES_EXT")]
        MaxMeshOutputVerticesExt = 0x9538,
        [NativeName("Name", "GL_MAX_MESH_OUTPUT_PRIMITIVES_EXT")]
        MaxMeshOutputPrimitivesExt = 0x9756,
        [NativeName("Name", "GL_MAX_MESH_OUTPUT_COMPONENTS_EXT")]
        MaxMeshOutputComponentsExt = 0x9749,
        [NativeName("Name", "GL_MAX_MESH_OUTPUT_LAYERS_EXT")]
        MaxMeshOutputLayersExt = 0x974A,
        [NativeName("Name", "GL_MAX_MESH_MULTIVIEW_VIEW_COUNT_EXT")]
        MaxMeshMultiviewViewCountExt = 0x9557,
        [NativeName("Name", "GL_MESH_OUTPUT_PER_VERTEX_GRANULARITY_EXT")]
        MeshOutputPerVertexGranularityExt = 0x92DF,
        [NativeName("Name", "GL_MESH_OUTPUT_PER_PRIMITIVE_GRANULARITY_EXT")]
        MeshOutputPerPrimitiveGranularityExt = 0x9543,
        [NativeName("Name", "GL_MAX_PREFERRED_TASK_WORK_GROUP_INVOCATIONS_EXT")]
        MaxPreferredTaskWorkGroupInvocationsExt = 0x974B,
        [NativeName("Name", "GL_MAX_PREFERRED_MESH_WORK_GROUP_INVOCATIONS_EXT")]
        MaxPreferredMeshWorkGroupInvocationsExt = 0x974C,
        [NativeName("Name", "GL_MESH_PREFERS_LOCAL_INVOCATION_VERTEX_OUTPUT_EXT")]
        MeshPrefersLocalInvocationVertexOutputExt = 0x974D,
        [NativeName("Name", "GL_MESH_PREFERS_LOCAL_INVOCATION_PRIMITIVE_OUTPUT_EXT")]
        MeshPrefersLocalInvocationPrimitiveOutputExt = 0x974E,
        [NativeName("Name", "GL_MESH_PREFERS_COMPACT_VERTEX_OUTPUT_EXT")]
        MeshPrefersCompactVertexOutputExt = 0x974F,
        [NativeName("Name", "GL_MESH_PREFERS_COMPACT_PRIMITIVE_OUTPUT_EXT")]
        MeshPrefersCompactPrimitiveOutputExt = 0x9750,
        [NativeName("Name", "GL_MAX_TASK_WORK_GROUP_COUNT_EXT")]
        MaxTaskWorkGroupCountExt = 0x9751,
        [NativeName("Name", "GL_MAX_MESH_WORK_GROUP_COUNT_EXT")]
        MaxMeshWorkGroupCountExt = 0x9752,
        [NativeName("Name", "GL_MAX_MESH_WORK_GROUP_SIZE_EXT")]
        MaxMeshWorkGroupSizeExt = 0x9758,
        [NativeName("Name", "GL_MAX_TASK_WORK_GROUP_SIZE_EXT")]
        MaxTaskWorkGroupSizeExt = 0x975A,
        [NativeName("Name", "GL_MESH_WORK_GROUP_SIZE_EXT")]
        MeshWorkGroupSizeExt = 0x953E,
        [NativeName("Name", "GL_TASK_WORK_GROUP_SIZE_EXT")]
        TaskWorkGroupSizeExt = 0x953F,
        [NativeName("Name", "GL_MESH_VERTICES_OUT_EXT")]
        MeshVerticesOutExt = 0x9579,
        [NativeName("Name", "GL_MESH_PRIMITIVES_OUT_EXT")]
        MeshPrimitivesOutExt = 0x957A,
        [NativeName("Name", "GL_MESH_OUTPUT_TYPE_EXT")]
        MeshOutputTypeExt = 0x957B,
        [NativeName("Name", "GL_UNIFORM_BLOCK_REFERENCED_BY_MESH_SHADER_EXT")]
        UniformBlockReferencedByMeshShaderExt = 0x959C,
        [NativeName("Name", "GL_UNIFORM_BLOCK_REFERENCED_BY_TASK_SHADER_EXT")]
        UniformBlockReferencedByTaskShaderExt = 0x959D,
        [NativeName("Name", "GL_REFERENCED_BY_MESH_SHADER_EXT")]
        ReferencedByMeshShaderExt = 0x95A0,
        [NativeName("Name", "GL_REFERENCED_BY_TASK_SHADER_EXT")]
        ReferencedByTaskShaderExt = 0x95A1,
        [NativeName("Name", "GL_TASK_SHADER_INVOCATIONS_EXT")]
        TaskShaderInvocationsExt = 0x9753,
        [NativeName("Name", "GL_MESH_SHADER_INVOCATIONS_EXT")]
        MeshShaderInvocationsExt = 0x9754,
        [NativeName("Name", "GL_MESH_PRIMITIVES_GENERATED_EXT")]
        MeshPrimitivesGeneratedExt = 0x9755,
        [NativeName("Name", "GL_MESH_SHADER_BIT_EXT")]
        MeshShaderBitExt = 0x40,
        [NativeName("Name", "GL_TASK_SHADER_BIT_EXT")]
        TaskShaderBitExt = 0x80,
        [NativeName("Name", "GL_MESH_SUBROUTINE_EXT")]
        MeshSubroutineExt = 0x957C,
        [NativeName("Name", "GL_TASK_SUBROUTINE_EXT")]
        TaskSubroutineExt = 0x957D,
        [NativeName("Name", "GL_MESH_SUBROUTINE_UNIFORM_EXT")]
        MeshSubroutineUniformExt = 0x957E,
        [NativeName("Name", "GL_TASK_SUBROUTINE_UNIFORM_EXT")]
        TaskSubroutineUniformExt = 0x957F,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_MESH_SHADER_EXT")]
        AtomicCounterBufferReferencedByMeshShaderExt = 0x959E,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TASK_SHADER_EXT")]
        AtomicCounterBufferReferencedByTaskShaderExt = 0x959F,
        [NativeName("Name", "GL_MULTISAMPLE_EXT")]
        MultisampleExt = 0x809D,
        [NativeName("Name", "GL_SAMPLE_ALPHA_TO_MASK_EXT")]
        SampleAlphaToMaskExt = 0x809E,
        [NativeName("Name", "GL_SAMPLE_ALPHA_TO_ONE_EXT")]
        SampleAlphaToOneExt = 0x809F,
        [NativeName("Name", "GL_SAMPLE_MASK_EXT")]
        SampleMaskExt = 0x80A0,
        [NativeName("Name", "GL_1PASS_EXT")]
        Gl1PassExt = 0x80A1,
        [NativeName("Name", "GL_2PASS_0_EXT")]
        Gl2Pass0Ext = 0x80A2,
        [NativeName("Name", "GL_2PASS_1_EXT")]
        Gl2Pass1Ext = 0x80A3,
        [NativeName("Name", "GL_4PASS_0_EXT")]
        Gl4Pass0Ext = 0x80A4,
        [NativeName("Name", "GL_4PASS_1_EXT")]
        Gl4Pass1Ext = 0x80A5,
        [NativeName("Name", "GL_4PASS_2_EXT")]
        Gl4Pass2Ext = 0x80A6,
        [NativeName("Name", "GL_4PASS_3_EXT")]
        Gl4Pass3Ext = 0x80A7,
        [NativeName("Name", "GL_SAMPLE_BUFFERS_EXT")]
        SampleBuffersExt = 0x80A8,
        [NativeName("Name", "GL_SAMPLES_EXT")]
        SamplesExt = 0x80A9,
        [NativeName("Name", "GL_SAMPLE_MASK_VALUE_EXT")]
        SampleMaskValueExt = 0x80AA,
        [NativeName("Name", "GL_SAMPLE_MASK_INVERT_EXT")]
        SampleMaskInvertExt = 0x80AB,
        [NativeName("Name", "GL_SAMPLE_PATTERN_EXT")]
        SamplePatternExt = 0x80AC,
        [NativeName("Name", "GL_MULTISAMPLE_BIT_EXT")]
        MultisampleBitExt = 0x20000000,
        [NativeName("Name", "GL_DEPTH_STENCIL_EXT")]
        DepthStencilExt = 0x84F9,
        [NativeName("Name", "GL_UNSIGNED_INT_24_8_EXT")]
        UnsignedInt248Ext = 0x84FA,
        [NativeName("Name", "GL_DEPTH24_STENCIL8_EXT")]
        Depth24Stencil8Ext = 0x88F0,
        [NativeName("Name", "GL_TEXTURE_STENCIL_SIZE_EXT")]
        TextureStencilSizeExt = 0x88F1,
        [NativeName("Name", "GL_R11F_G11F_B10F_EXT")]
        R11fG11fB10fExt = 0x8C3A,
        [NativeName("Name", "GL_UNSIGNED_INT_10F_11F_11F_REV_EXT")]
        UnsignedInt10f11f11fRevExt = 0x8C3B,
        [NativeName("Name", "GL_RGBA_SIGNED_COMPONENTS_EXT")]
        RgbaSignedComponentsExt = 0x8C3C,
        [NativeName("Name", "GL_UNSIGNED_BYTE_3_3_2_EXT")]
        UnsignedByte332Ext = 0x8032,
        [NativeName("Name", "GL_UNSIGNED_SHORT_4_4_4_4_EXT")]
        UnsignedShort4444Ext = 0x8033,
        [NativeName("Name", "GL_UNSIGNED_SHORT_5_5_5_1_EXT")]
        UnsignedShort5551Ext = 0x8034,
        [NativeName("Name", "GL_UNSIGNED_INT_8_8_8_8_EXT")]
        UnsignedInt8888Ext = 0x8035,
        [NativeName("Name", "GL_UNSIGNED_INT_10_10_10_2_EXT")]
        UnsignedInt1010102Ext = 0x8036,
        [NativeName("Name", "GL_COLOR_INDEX1_EXT")]
        ColorIndex1Ext = 0x80E2,
        [NativeName("Name", "GL_COLOR_INDEX2_EXT")]
        ColorIndex2Ext = 0x80E3,
        [NativeName("Name", "GL_COLOR_INDEX4_EXT")]
        ColorIndex4Ext = 0x80E4,
        [NativeName("Name", "GL_COLOR_INDEX8_EXT")]
        ColorIndex8Ext = 0x80E5,
        [NativeName("Name", "GL_COLOR_INDEX12_EXT")]
        ColorIndex12Ext = 0x80E6,
        [NativeName("Name", "GL_COLOR_INDEX16_EXT")]
        ColorIndex16Ext = 0x80E7,
        [NativeName("Name", "GL_TEXTURE_INDEX_SIZE_EXT")]
        TextureIndexSizeExt = 0x80ED,
        [NativeName("Name", "GL_PIXEL_PACK_BUFFER_EXT")]
        PixelPackBufferExt = 0x88EB,
        [NativeName("Name", "GL_PIXEL_UNPACK_BUFFER_EXT")]
        PixelUnpackBufferExt = 0x88EC,
        [NativeName("Name", "GL_PIXEL_PACK_BUFFER_BINDING_EXT")]
        PixelPackBufferBindingExt = 0x88ED,
        [NativeName("Name", "GL_PIXEL_UNPACK_BUFFER_BINDING_EXT")]
        PixelUnpackBufferBindingExt = 0x88EF,
        [NativeName("Name", "GL_PIXEL_TRANSFORM_2D_EXT")]
        PixelTransform2DExt = 0x8330,
        [NativeName("Name", "GL_PIXEL_MAG_FILTER_EXT")]
        PixelMagFilterExt = 0x8331,
        [NativeName("Name", "GL_PIXEL_MIN_FILTER_EXT")]
        PixelMinFilterExt = 0x8332,
        [NativeName("Name", "GL_PIXEL_CUBIC_WEIGHT_EXT")]
        PixelCubicWeightExt = 0x8333,
        [NativeName("Name", "GL_CUBIC_EXT")]
        CubicExt = 0x8334,
        [NativeName("Name", "GL_AVERAGE_EXT")]
        AverageExt = 0x8335,
        [NativeName("Name", "GL_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT")]
        PixelTransform2DStackDepthExt = 0x8336,
        [NativeName("Name", "GL_MAX_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT")]
        MaxPixelTransform2DStackDepthExt = 0x8337,
        [NativeName("Name", "GL_PIXEL_TRANSFORM_2D_MATRIX_EXT")]
        PixelTransform2DMatrixExt = 0x8338,
        [NativeName("Name", "GL_POINT_SIZE_MIN_EXT")]
        PointSizeMinExt = 0x8126,
        [NativeName("Name", "GL_POINT_SIZE_MAX_EXT")]
        PointSizeMaxExt = 0x8127,
        [NativeName("Name", "GL_POINT_FADE_THRESHOLD_SIZE_EXT")]
        PointFadeThresholdSizeExt = 0x8128,
        [NativeName("Name", "GL_DISTANCE_ATTENUATION_EXT")]
        DistanceAttenuationExt = 0x8129,
        [NativeName("Name", "GL_POLYGON_OFFSET_EXT")]
        PolygonOffsetExt = 0x8037,
        [NativeName("Name", "GL_POLYGON_OFFSET_FACTOR_EXT")]
        PolygonOffsetFactorExt = 0x8038,
        [NativeName("Name", "GL_POLYGON_OFFSET_BIAS_EXT")]
        PolygonOffsetBiasExt = 0x8039,
        [NativeName("Name", "GL_POLYGON_OFFSET_CLAMP_EXT")]
        PolygonOffsetClampExt = 0x8E1B,
        [NativeName("Name", "GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION_EXT")]
        QuadsFollowProvokingVertexConventionExt = 0x8E4C,
        [NativeName("Name", "GL_FIRST_VERTEX_CONVENTION_EXT")]
        FirstVertexConventionExt = 0x8E4D,
        [NativeName("Name", "GL_LAST_VERTEX_CONVENTION_EXT")]
        LastVertexConventionExt = 0x8E4E,
        [NativeName("Name", "GL_PROVOKING_VERTEX_EXT")]
        ProvokingVertexExt = 0x8E4F,
        [NativeName("Name", "GL_RASTER_MULTISAMPLE_EXT")]
        RasterMultisampleExt = 0x9327,
        [NativeName("Name", "GL_RASTER_SAMPLES_EXT")]
        RasterSamplesExt = 0x9328,
        [NativeName("Name", "GL_MAX_RASTER_SAMPLES_EXT")]
        MaxRasterSamplesExt = 0x9329,
        [NativeName("Name", "GL_RASTER_FIXED_SAMPLE_LOCATIONS_EXT")]
        RasterFixedSampleLocationsExt = 0x932A,
        [NativeName("Name", "GL_MULTISAMPLE_RASTERIZATION_ALLOWED_EXT")]
        MultisampleRasterizationAllowedExt = 0x932B,
        [NativeName("Name", "GL_EFFECTIVE_RASTER_SAMPLES_EXT")]
        EffectiveRasterSamplesExt = 0x932C,
        [NativeName("Name", "GL_RESCALE_NORMAL_EXT")]
        RescaleNormalExt = 0x803A,
        [NativeName("Name", "GL_COLOR_SUM_EXT")]
        ColorSumExt = 0x8458,
        [NativeName("Name", "GL_CURRENT_SECONDARY_COLOR_EXT")]
        CurrentSecondaryColorExt = 0x8459,
        [NativeName("Name", "GL_SECONDARY_COLOR_ARRAY_SIZE_EXT")]
        SecondaryColorArraySizeExt = 0x845A,
        [NativeName("Name", "GL_SECONDARY_COLOR_ARRAY_TYPE_EXT")]
        SecondaryColorArrayTypeExt = 0x845B,
        [NativeName("Name", "GL_SECONDARY_COLOR_ARRAY_STRIDE_EXT")]
        SecondaryColorArrayStrideExt = 0x845C,
        [NativeName("Name", "GL_SECONDARY_COLOR_ARRAY_POINTER_EXT")]
        SecondaryColorArrayPointerExt = 0x845D,
        [NativeName("Name", "GL_SECONDARY_COLOR_ARRAY_EXT")]
        SecondaryColorArrayExt = 0x845E,
        [NativeName("Name", "GL_LAYOUT_GENERAL_EXT")]
        LayoutGeneralExt = 0x958D,
        [NativeName("Name", "GL_LAYOUT_COLOR_ATTACHMENT_EXT")]
        LayoutColorAttachmentExt = 0x958E,
        [NativeName("Name", "GL_LAYOUT_DEPTH_STENCIL_ATTACHMENT_EXT")]
        LayoutDepthStencilAttachmentExt = 0x958F,
        [NativeName("Name", "GL_LAYOUT_DEPTH_STENCIL_READ_ONLY_EXT")]
        LayoutDepthStencilReadOnlyExt = 0x9590,
        [NativeName("Name", "GL_LAYOUT_SHADER_READ_ONLY_EXT")]
        LayoutShaderReadOnlyExt = 0x9591,
        [NativeName("Name", "GL_LAYOUT_TRANSFER_SRC_EXT")]
        LayoutTransferSrcExt = 0x9592,
        [NativeName("Name", "GL_LAYOUT_TRANSFER_DST_EXT")]
        LayoutTransferDstExt = 0x9593,
        [NativeName("Name", "GL_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_EXT")]
        LayoutDepthReadOnlyStencilAttachmentExt = 0x9530,
        [NativeName("Name", "GL_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_EXT")]
        LayoutDepthAttachmentStencilReadOnlyExt = 0x9531,
        [NativeName("Name", "GL_HANDLE_TYPE_D3D12_FENCE_EXT")]
        HandleTypeD3D12FenceExt = 0x9594,
        [NativeName("Name", "GL_D3D12_FENCE_VALUE_EXT")]
        D3D12FenceValueExt = 0x9595,
        [NativeName("Name", "GL_ACTIVE_PROGRAM_EXT")]
        ActiveProgramExt = 0x8259,
        [NativeName("Name", "GL_LIGHT_MODEL_COLOR_CONTROL_EXT")]
        LightModelColorControlExt = 0x81F8,
        [NativeName("Name", "GL_SINGLE_COLOR_EXT")]
        SingleColorExt = 0x81F9,
        [NativeName("Name", "GL_SEPARATE_SPECULAR_COLOR_EXT")]
        SeparateSpecularColorExt = 0x81FA,
        [NativeName("Name", "GL_FRAGMENT_SHADER_DISCARDS_SAMPLES_EXT")]
        FragmentShaderDiscardsSamplesExt = 0x8A52,
        [NativeName("Name", "GL_MAX_IMAGE_UNITS_EXT")]
        MaxImageUnitsExt = 0x8F38,
        [NativeName("Name", "GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS_EXT")]
        MaxCombinedImageUnitsAndFragmentOutputsExt = 0x8F39,
        [NativeName("Name", "GL_IMAGE_BINDING_NAME_EXT")]
        ImageBindingNameExt = 0x8F3A,
        [NativeName("Name", "GL_IMAGE_BINDING_LEVEL_EXT")]
        ImageBindingLevelExt = 0x8F3B,
        [NativeName("Name", "GL_IMAGE_BINDING_LAYERED_EXT")]
        ImageBindingLayeredExt = 0x8F3C,
        [NativeName("Name", "GL_IMAGE_BINDING_LAYER_EXT")]
        ImageBindingLayerExt = 0x8F3D,
        [NativeName("Name", "GL_IMAGE_BINDING_ACCESS_EXT")]
        ImageBindingAccessExt = 0x8F3E,
        [NativeName("Name", "GL_IMAGE_1D_EXT")]
        Image1DExt = 0x904C,
        [NativeName("Name", "GL_IMAGE_2D_EXT")]
        Image2DExt = 0x904D,
        [NativeName("Name", "GL_IMAGE_3D_EXT")]
        Image3DExt = 0x904E,
        [NativeName("Name", "GL_IMAGE_2D_RECT_EXT")]
        Image2DRectExt = 0x904F,
        [NativeName("Name", "GL_IMAGE_CUBE_EXT")]
        ImageCubeExt = 0x9050,
        [NativeName("Name", "GL_IMAGE_BUFFER_EXT")]
        ImageBufferExt = 0x9051,
        [NativeName("Name", "GL_IMAGE_1D_ARRAY_EXT")]
        Image1DArrayExt = 0x9052,
        [NativeName("Name", "GL_IMAGE_2D_ARRAY_EXT")]
        Image2DArrayExt = 0x9053,
        [NativeName("Name", "GL_IMAGE_CUBE_MAP_ARRAY_EXT")]
        ImageCubeMapArrayExt = 0x9054,
        [NativeName("Name", "GL_IMAGE_2D_MULTISAMPLE_EXT")]
        Image2DMultisampleExt = 0x9055,
        [NativeName("Name", "GL_IMAGE_2D_MULTISAMPLE_ARRAY_EXT")]
        Image2DMultisampleArrayExt = 0x9056,
        [NativeName("Name", "GL_INT_IMAGE_1D_EXT")]
        IntImage1DExt = 0x9057,
        [NativeName("Name", "GL_INT_IMAGE_2D_EXT")]
        IntImage2DExt = 0x9058,
        [NativeName("Name", "GL_INT_IMAGE_3D_EXT")]
        IntImage3DExt = 0x9059,
        [NativeName("Name", "GL_INT_IMAGE_2D_RECT_EXT")]
        IntImage2DRectExt = 0x905A,
        [NativeName("Name", "GL_INT_IMAGE_CUBE_EXT")]
        IntImageCubeExt = 0x905B,
        [NativeName("Name", "GL_INT_IMAGE_BUFFER_EXT")]
        IntImageBufferExt = 0x905C,
        [NativeName("Name", "GL_INT_IMAGE_1D_ARRAY_EXT")]
        IntImage1DArrayExt = 0x905D,
        [NativeName("Name", "GL_INT_IMAGE_2D_ARRAY_EXT")]
        IntImage2DArrayExt = 0x905E,
        [NativeName("Name", "GL_INT_IMAGE_CUBE_MAP_ARRAY_EXT")]
        IntImageCubeMapArrayExt = 0x905F,
        [NativeName("Name", "GL_INT_IMAGE_2D_MULTISAMPLE_EXT")]
        IntImage2DMultisampleExt = 0x9060,
        [NativeName("Name", "GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT")]
        IntImage2DMultisampleArrayExt = 0x9061,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_1D_EXT")]
        UnsignedIntImage1DExt = 0x9062,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_2D_EXT")]
        UnsignedIntImage2DExt = 0x9063,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_3D_EXT")]
        UnsignedIntImage3DExt = 0x9064,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_2D_RECT_EXT")]
        UnsignedIntImage2DRectExt = 0x9065,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_CUBE_EXT")]
        UnsignedIntImageCubeExt = 0x9066,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_BUFFER_EXT")]
        UnsignedIntImageBufferExt = 0x9067,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_1D_ARRAY_EXT")]
        UnsignedIntImage1DArrayExt = 0x9068,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_2D_ARRAY_EXT")]
        UnsignedIntImage2DArrayExt = 0x9069,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_EXT")]
        UnsignedIntImageCubeMapArrayExt = 0x906A,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_EXT")]
        UnsignedIntImage2DMultisampleExt = 0x906B,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT")]
        UnsignedIntImage2DMultisampleArrayExt = 0x906C,
        [NativeName("Name", "GL_MAX_IMAGE_SAMPLES_EXT")]
        MaxImageSamplesExt = 0x906D,
        [NativeName("Name", "GL_IMAGE_BINDING_FORMAT_EXT")]
        ImageBindingFormatExt = 0x906E,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT_EXT")]
        VertexAttribArrayBarrierBitExt = 0x1,
        [NativeName("Name", "GL_ELEMENT_ARRAY_BARRIER_BIT_EXT")]
        ElementArrayBarrierBitExt = 0x2,
        [NativeName("Name", "GL_UNIFORM_BARRIER_BIT_EXT")]
        UniformBarrierBitExt = 0x4,
        [NativeName("Name", "GL_TEXTURE_FETCH_BARRIER_BIT_EXT")]
        TextureFetchBarrierBitExt = 0x8,
        [NativeName("Name", "GL_SHADER_IMAGE_ACCESS_BARRIER_BIT_EXT")]
        ShaderImageAccessBarrierBitExt = 0x20,
        [NativeName("Name", "GL_COMMAND_BARRIER_BIT_EXT")]
        CommandBarrierBitExt = 0x40,
        [NativeName("Name", "GL_PIXEL_BUFFER_BARRIER_BIT_EXT")]
        PixelBufferBarrierBitExt = 0x80,
        [NativeName("Name", "GL_TEXTURE_UPDATE_BARRIER_BIT_EXT")]
        TextureUpdateBarrierBitExt = 0x100,
        [NativeName("Name", "GL_BUFFER_UPDATE_BARRIER_BIT_EXT")]
        BufferUpdateBarrierBitExt = 0x200,
        [NativeName("Name", "GL_FRAMEBUFFER_BARRIER_BIT_EXT")]
        FramebufferBarrierBitExt = 0x400,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BARRIER_BIT_EXT")]
        TransformFeedbackBarrierBitExt = 0x800,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BARRIER_BIT_EXT")]
        AtomicCounterBarrierBitExt = 0x1000,
        [NativeName("Name", "GL_ALL_BARRIER_BITS_EXT")]
        AllBarrierBitsExt = unchecked((int)0xFFFFFFFF),
        [NativeName("Name", "GL_SHARED_TEXTURE_PALETTE_EXT")]
        SharedTexturePaletteExt = 0x81FB,
        [NativeName("Name", "GL_STENCIL_TAG_BITS_EXT")]
        StencilTagBitsExt = 0x88F2,
        [NativeName("Name", "GL_STENCIL_CLEAR_TAG_VALUE_EXT")]
        StencilClearTagValueExt = 0x88F3,
        [NativeName("Name", "GL_STENCIL_TEST_TWO_SIDE_EXT")]
        StencilTestTwoSideExt = 0x8910,
        [NativeName("Name", "GL_ACTIVE_STENCIL_FACE_EXT")]
        ActiveStencilFaceExt = 0x8911,
        [NativeName("Name", "GL_INCR_WRAP_EXT")]
        IncrWrapExt = 0x8507,
        [NativeName("Name", "GL_DECR_WRAP_EXT")]
        DecrWrapExt = 0x8508,
        [NativeName("Name", "GL_ALPHA4_EXT")]
        Alpha4Ext = 0x803B,
        [NativeName("Name", "GL_ALPHA8_EXT")]
        Alpha8Ext = 0x803C,
        [NativeName("Name", "GL_ALPHA12_EXT")]
        Alpha12Ext = 0x803D,
        [NativeName("Name", "GL_ALPHA16_EXT")]
        Alpha16Ext = 0x803E,
        [NativeName("Name", "GL_LUMINANCE4_EXT")]
        Luminance4Ext = 0x803F,
        [NativeName("Name", "GL_LUMINANCE8_EXT")]
        Luminance8Ext = 0x8040,
        [NativeName("Name", "GL_LUMINANCE12_EXT")]
        Luminance12Ext = 0x8041,
        [NativeName("Name", "GL_LUMINANCE16_EXT")]
        Luminance16Ext = 0x8042,
        [NativeName("Name", "GL_LUMINANCE4_ALPHA4_EXT")]
        Luminance4Alpha4Ext = 0x8043,
        [NativeName("Name", "GL_LUMINANCE6_ALPHA2_EXT")]
        Luminance6Alpha2Ext = 0x8044,
        [NativeName("Name", "GL_LUMINANCE8_ALPHA8_EXT")]
        Luminance8Alpha8Ext = 0x8045,
        [NativeName("Name", "GL_LUMINANCE12_ALPHA4_EXT")]
        Luminance12Alpha4Ext = 0x8046,
        [NativeName("Name", "GL_LUMINANCE12_ALPHA12_EXT")]
        Luminance12Alpha12Ext = 0x8047,
        [NativeName("Name", "GL_LUMINANCE16_ALPHA16_EXT")]
        Luminance16Alpha16Ext = 0x8048,
        [NativeName("Name", "GL_INTENSITY_EXT")]
        IntensityExt = 0x8049,
        [NativeName("Name", "GL_INTENSITY4_EXT")]
        Intensity4Ext = 0x804A,
        [NativeName("Name", "GL_INTENSITY8_EXT")]
        Intensity8Ext = 0x804B,
        [NativeName("Name", "GL_INTENSITY12_EXT")]
        Intensity12Ext = 0x804C,
        [NativeName("Name", "GL_INTENSITY16_EXT")]
        Intensity16Ext = 0x804D,
        [NativeName("Name", "GL_RGB2_EXT")]
        Rgb2Ext = 0x804E,
        [NativeName("Name", "GL_RGB4_EXT")]
        Rgb4Ext = 0x804F,
        [NativeName("Name", "GL_RGB5_EXT")]
        Rgb5Ext = 0x8050,
        [NativeName("Name", "GL_RGB8_EXT")]
        Rgb8Ext = 0x8051,
        [NativeName("Name", "GL_RGB10_EXT")]
        Rgb10Ext = 0x8052,
        [NativeName("Name", "GL_RGB12_EXT")]
        Rgb12Ext = 0x8053,
        [NativeName("Name", "GL_RGB16_EXT")]
        Rgb16Ext = 0x8054,
        [NativeName("Name", "GL_RGBA2_EXT")]
        Rgba2Ext = 0x8055,
        [NativeName("Name", "GL_RGBA4_EXT")]
        Rgba4Ext = 0x8056,
        [NativeName("Name", "GL_RGB5_A1_EXT")]
        Rgb5A1Ext = 0x8057,
        [NativeName("Name", "GL_RGBA8_EXT")]
        Rgba8Ext = 0x8058,
        [NativeName("Name", "GL_RGB10_A2_EXT")]
        Rgb10A2Ext = 0x8059,
        [NativeName("Name", "GL_RGBA12_EXT")]
        Rgba12Ext = 0x805A,
        [NativeName("Name", "GL_RGBA16_EXT")]
        Rgba16Ext = 0x805B,
        [NativeName("Name", "GL_TEXTURE_RED_SIZE_EXT")]
        TextureRedSizeExt = 0x805C,
        [NativeName("Name", "GL_TEXTURE_GREEN_SIZE_EXT")]
        TextureGreenSizeExt = 0x805D,
        [NativeName("Name", "GL_TEXTURE_BLUE_SIZE_EXT")]
        TextureBlueSizeExt = 0x805E,
        [NativeName("Name", "GL_TEXTURE_ALPHA_SIZE_EXT")]
        TextureAlphaSizeExt = 0x805F,
        [NativeName("Name", "GL_TEXTURE_LUMINANCE_SIZE_EXT")]
        TextureLuminanceSizeExt = 0x8060,
        [NativeName("Name", "GL_TEXTURE_INTENSITY_SIZE_EXT")]
        TextureIntensitySizeExt = 0x8061,
        [NativeName("Name", "GL_REPLACE_EXT")]
        ReplaceExt = 0x8062,
        [NativeName("Name", "GL_PROXY_TEXTURE_1D_EXT")]
        ProxyTexture1DExt = 0x8063,
        [NativeName("Name", "GL_PROXY_TEXTURE_2D_EXT")]
        ProxyTexture2DExt = 0x8064,
        [NativeName("Name", "GL_TEXTURE_TOO_LARGE_EXT")]
        TextureTooLargeExt = 0x8065,
        [NativeName("Name", "GL_PACK_SKIP_IMAGES_EXT")]
        PackSkipImagesExt = 0x806B,
        [NativeName("Name", "GL_PACK_IMAGE_HEIGHT_EXT")]
        PackImageHeightExt = 0x806C,
        [NativeName("Name", "GL_UNPACK_SKIP_IMAGES_EXT")]
        UnpackSkipImagesExt = 0x806D,
        [NativeName("Name", "GL_UNPACK_IMAGE_HEIGHT_EXT")]
        UnpackImageHeightExt = 0x806E,
        [NativeName("Name", "GL_TEXTURE_3D_EXT")]
        Texture3DExt = 0x806F,
        [NativeName("Name", "GL_PROXY_TEXTURE_3D_EXT")]
        ProxyTexture3DExt = 0x8070,
        [NativeName("Name", "GL_TEXTURE_DEPTH_EXT")]
        TextureDepthExt = 0x8071,
        [NativeName("Name", "GL_TEXTURE_WRAP_R_EXT")]
        TextureWrapRExt = 0x8072,
        [NativeName("Name", "GL_MAX_3D_TEXTURE_SIZE_EXT")]
        Max3DTextureSizeExt = 0x8073,
        [NativeName("Name", "GL_TEXTURE_1D_ARRAY_EXT")]
        Texture1DArrayExt = 0x8C18,
        [NativeName("Name", "GL_PROXY_TEXTURE_1D_ARRAY_EXT")]
        ProxyTexture1DArrayExt = 0x8C19,
        [NativeName("Name", "GL_TEXTURE_2D_ARRAY_EXT")]
        Texture2DArrayExt = 0x8C1A,
        [NativeName("Name", "GL_PROXY_TEXTURE_2D_ARRAY_EXT")]
        ProxyTexture2DArrayExt = 0x8C1B,
        [NativeName("Name", "GL_TEXTURE_BINDING_1D_ARRAY_EXT")]
        TextureBinding1DArrayExt = 0x8C1C,
        [NativeName("Name", "GL_TEXTURE_BINDING_2D_ARRAY_EXT")]
        TextureBinding2DArrayExt = 0x8C1D,
        [NativeName("Name", "GL_MAX_ARRAY_TEXTURE_LAYERS_EXT")]
        MaxArrayTextureLayersExt = 0x88FF,
        [NativeName("Name", "GL_COMPARE_REF_DEPTH_TO_TEXTURE_EXT")]
        CompareRefDepthToTextureExt = 0x884E,
        [NativeName("Name", "GL_TEXTURE_BUFFER_EXT")]
        TextureBufferExt = 0x8C2A,
        [NativeName("Name", "GL_MAX_TEXTURE_BUFFER_SIZE_EXT")]
        MaxTextureBufferSizeExt = 0x8C2B,
        [NativeName("Name", "GL_TEXTURE_BINDING_BUFFER_EXT")]
        TextureBindingBufferExt = 0x8C2C,
        [NativeName("Name", "GL_TEXTURE_BUFFER_DATA_STORE_BINDING_EXT")]
        TextureBufferDataStoreBindingExt = 0x8C2D,
        [NativeName("Name", "GL_TEXTURE_BUFFER_FORMAT_EXT")]
        TextureBufferFormatExt = 0x8C2E,
        [NativeName("Name", "GL_COMPRESSED_LUMINANCE_LATC1_EXT")]
        CompressedLuminanceLatc1Ext = 0x8C70,
        [NativeName("Name", "GL_COMPRESSED_SIGNED_LUMINANCE_LATC1_EXT")]
        CompressedSignedLuminanceLatc1Ext = 0x8C71,
        [NativeName("Name", "GL_COMPRESSED_LUMINANCE_ALPHA_LATC2_EXT")]
        CompressedLuminanceAlphaLatc2Ext = 0x8C72,
        [NativeName("Name", "GL_COMPRESSED_SIGNED_LUMINANCE_ALPHA_LATC2_EXT")]
        CompressedSignedLuminanceAlphaLatc2Ext = 0x8C73,
        [NativeName("Name", "GL_COMPRESSED_RED_RGTC1_EXT")]
        CompressedRedRgtc1Ext = 0x8DBB,
        [NativeName("Name", "GL_COMPRESSED_SIGNED_RED_RGTC1_EXT")]
        CompressedSignedRedRgtc1Ext = 0x8DBC,
        [NativeName("Name", "GL_COMPRESSED_RED_GREEN_RGTC2_EXT")]
        CompressedRedGreenRgtc2Ext = 0x8DBD,
        [NativeName("Name", "GL_COMPRESSED_SIGNED_RED_GREEN_RGTC2_EXT")]
        CompressedSignedRedGreenRgtc2Ext = 0x8DBE,
        [NativeName("Name", "GL_COMPRESSED_RGB_S3TC_DXT1_EXT")]
        CompressedRgbS3TCDxt1Ext = 0x83F0,
        [NativeName("Name", "GL_COMPRESSED_RGBA_S3TC_DXT1_EXT")]
        CompressedRgbaS3TCDxt1Ext = 0x83F1,
        [NativeName("Name", "GL_COMPRESSED_RGBA_S3TC_DXT3_EXT")]
        CompressedRgbaS3TCDxt3Ext = 0x83F2,
        [NativeName("Name", "GL_COMPRESSED_RGBA_S3TC_DXT5_EXT")]
        CompressedRgbaS3TCDxt5Ext = 0x83F3,
        [NativeName("Name", "GL_NORMAL_MAP_EXT")]
        NormalMapExt = 0x8511,
        [NativeName("Name", "GL_REFLECTION_MAP_EXT")]
        ReflectionMapExt = 0x8512,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_EXT")]
        TextureCubeMapExt = 0x8513,
        [NativeName("Name", "GL_TEXTURE_BINDING_CUBE_MAP_EXT")]
        TextureBindingCubeMapExt = 0x8514,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_POSITIVE_X_EXT")]
        TextureCubeMapPositiveXExt = 0x8515,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_NEGATIVE_X_EXT")]
        TextureCubeMapNegativeXExt = 0x8516,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_POSITIVE_Y_EXT")]
        TextureCubeMapPositiveYExt = 0x8517,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_EXT")]
        TextureCubeMapNegativeYExt = 0x8518,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_POSITIVE_Z_EXT")]
        TextureCubeMapPositiveZExt = 0x8519,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_EXT")]
        TextureCubeMapNegativeZExt = 0x851A,
        [NativeName("Name", "GL_PROXY_TEXTURE_CUBE_MAP_EXT")]
        ProxyTextureCubeMapExt = 0x851B,
        [NativeName("Name", "GL_MAX_CUBE_MAP_TEXTURE_SIZE_EXT")]
        MaxCubeMapTextureSizeExt = 0x851C,
        [NativeName("Name", "GL_COMBINE_EXT")]
        CombineExt = 0x8570,
        [NativeName("Name", "GL_COMBINE_RGB_EXT")]
        CombineRgbExt = 0x8571,
        [NativeName("Name", "GL_COMBINE_ALPHA_EXT")]
        CombineAlphaExt = 0x8572,
        [NativeName("Name", "GL_RGB_SCALE_EXT")]
        RgbScaleExt = 0x8573,
        [NativeName("Name", "GL_ADD_SIGNED_EXT")]
        AddSignedExt = 0x8574,
        [NativeName("Name", "GL_INTERPOLATE_EXT")]
        InterpolateExt = 0x8575,
        [NativeName("Name", "GL_CONSTANT_EXT")]
        ConstantExt = 0x8576,
        [NativeName("Name", "GL_PRIMARY_COLOR_EXT")]
        PrimaryColorExt = 0x8577,
        [NativeName("Name", "GL_PREVIOUS_EXT")]
        PreviousExt = 0x8578,
        [NativeName("Name", "GL_SOURCE0_RGB_EXT")]
        Source0RgbExt = 0x8580,
        [NativeName("Name", "GL_SOURCE1_RGB_EXT")]
        Source1RgbExt = 0x8581,
        [NativeName("Name", "GL_SOURCE2_RGB_EXT")]
        Source2RgbExt = 0x8582,
        [NativeName("Name", "GL_SOURCE0_ALPHA_EXT")]
        Source0AlphaExt = 0x8588,
        [NativeName("Name", "GL_SOURCE1_ALPHA_EXT")]
        Source1AlphaExt = 0x8589,
        [NativeName("Name", "GL_SOURCE2_ALPHA_EXT")]
        Source2AlphaExt = 0x858A,
        [NativeName("Name", "GL_OPERAND0_RGB_EXT")]
        Operand0RgbExt = 0x8590,
        [NativeName("Name", "GL_OPERAND1_RGB_EXT")]
        Operand1RgbExt = 0x8591,
        [NativeName("Name", "GL_OPERAND2_RGB_EXT")]
        Operand2RgbExt = 0x8592,
        [NativeName("Name", "GL_OPERAND0_ALPHA_EXT")]
        Operand0AlphaExt = 0x8598,
        [NativeName("Name", "GL_OPERAND1_ALPHA_EXT")]
        Operand1AlphaExt = 0x8599,
        [NativeName("Name", "GL_OPERAND2_ALPHA_EXT")]
        Operand2AlphaExt = 0x859A,
        [NativeName("Name", "GL_DOT3_RGB_EXT")]
        Dot3RgbExt = 0x8740,
        [NativeName("Name", "GL_DOT3_RGBA_EXT")]
        Dot3RgbaExt = 0x8741,
        [NativeName("Name", "GL_TEXTURE_MAX_ANISOTROPY_EXT")]
        TextureMaxAnisotropyExt = 0x84FE,
        [NativeName("Name", "GL_MAX_TEXTURE_MAX_ANISOTROPY_EXT")]
        MaxTextureMaxAnisotropyExt = 0x84FF,
        [NativeName("Name", "GL_TEXTURE_REDUCTION_MODE_EXT")]
        TextureReductionModeExt = 0x9366,
        [NativeName("Name", "GL_WEIGHTED_AVERAGE_EXT")]
        WeightedAverageExt = 0x9367,
        [NativeName("Name", "GL_RGBA32UI_EXT")]
        Rgba32uiExt = 0x8D70,
        [NativeName("Name", "GL_RGB32UI_EXT")]
        Rgb32uiExt = 0x8D71,
        [NativeName("Name", "GL_ALPHA32UI_EXT")]
        Alpha32uiExt = 0x8D72,
        [NativeName("Name", "GL_INTENSITY32UI_EXT")]
        Intensity32uiExt = 0x8D73,
        [NativeName("Name", "GL_LUMINANCE32UI_EXT")]
        Luminance32uiExt = 0x8D74,
        [NativeName("Name", "GL_LUMINANCE_ALPHA32UI_EXT")]
        LuminanceAlpha32uiExt = 0x8D75,
        [NativeName("Name", "GL_RGBA16UI_EXT")]
        Rgba16uiExt = 0x8D76,
        [NativeName("Name", "GL_RGB16UI_EXT")]
        Rgb16uiExt = 0x8D77,
        [NativeName("Name", "GL_ALPHA16UI_EXT")]
        Alpha16uiExt = 0x8D78,
        [NativeName("Name", "GL_INTENSITY16UI_EXT")]
        Intensity16uiExt = 0x8D79,
        [NativeName("Name", "GL_LUMINANCE16UI_EXT")]
        Luminance16uiExt = 0x8D7A,
        [NativeName("Name", "GL_LUMINANCE_ALPHA16UI_EXT")]
        LuminanceAlpha16uiExt = 0x8D7B,
        [NativeName("Name", "GL_RGBA8UI_EXT")]
        Rgba8uiExt = 0x8D7C,
        [NativeName("Name", "GL_RGB8UI_EXT")]
        Rgb8uiExt = 0x8D7D,
        [NativeName("Name", "GL_ALPHA8UI_EXT")]
        Alpha8uiExt = 0x8D7E,
        [NativeName("Name", "GL_INTENSITY8UI_EXT")]
        Intensity8uiExt = 0x8D7F,
        [NativeName("Name", "GL_LUMINANCE8UI_EXT")]
        Luminance8uiExt = 0x8D80,
        [NativeName("Name", "GL_LUMINANCE_ALPHA8UI_EXT")]
        LuminanceAlpha8uiExt = 0x8D81,
        [NativeName("Name", "GL_RGBA32I_EXT")]
        Rgba32iExt = 0x8D82,
        [NativeName("Name", "GL_RGB32I_EXT")]
        Rgb32iExt = 0x8D83,
        [NativeName("Name", "GL_ALPHA32I_EXT")]
        Alpha32iExt = 0x8D84,
        [NativeName("Name", "GL_INTENSITY32I_EXT")]
        Intensity32iExt = 0x8D85,
        [NativeName("Name", "GL_LUMINANCE32I_EXT")]
        Luminance32iExt = 0x8D86,
        [NativeName("Name", "GL_LUMINANCE_ALPHA32I_EXT")]
        LuminanceAlpha32iExt = 0x8D87,
        [NativeName("Name", "GL_RGBA16I_EXT")]
        Rgba16iExt = 0x8D88,
        [NativeName("Name", "GL_RGB16I_EXT")]
        Rgb16iExt = 0x8D89,
        [NativeName("Name", "GL_ALPHA16I_EXT")]
        Alpha16iExt = 0x8D8A,
        [NativeName("Name", "GL_INTENSITY16I_EXT")]
        Intensity16iExt = 0x8D8B,
        [NativeName("Name", "GL_LUMINANCE16I_EXT")]
        Luminance16iExt = 0x8D8C,
        [NativeName("Name", "GL_LUMINANCE_ALPHA16I_EXT")]
        LuminanceAlpha16iExt = 0x8D8D,
        [NativeName("Name", "GL_RGBA8I_EXT")]
        Rgba8iExt = 0x8D8E,
        [NativeName("Name", "GL_RGB8I_EXT")]
        Rgb8iExt = 0x8D8F,
        [NativeName("Name", "GL_ALPHA8I_EXT")]
        Alpha8iExt = 0x8D90,
        [NativeName("Name", "GL_INTENSITY8I_EXT")]
        Intensity8iExt = 0x8D91,
        [NativeName("Name", "GL_LUMINANCE8I_EXT")]
        Luminance8iExt = 0x8D92,
        [NativeName("Name", "GL_LUMINANCE_ALPHA8I_EXT")]
        LuminanceAlpha8iExt = 0x8D93,
        [NativeName("Name", "GL_RED_INTEGER_EXT")]
        RedIntegerExt = 0x8D94,
        [NativeName("Name", "GL_GREEN_INTEGER_EXT")]
        GreenIntegerExt = 0x8D95,
        [NativeName("Name", "GL_BLUE_INTEGER_EXT")]
        BlueIntegerExt = 0x8D96,
        [NativeName("Name", "GL_ALPHA_INTEGER_EXT")]
        AlphaIntegerExt = 0x8D97,
        [NativeName("Name", "GL_RGB_INTEGER_EXT")]
        RgbIntegerExt = 0x8D98,
        [NativeName("Name", "GL_RGBA_INTEGER_EXT")]
        RgbaIntegerExt = 0x8D99,
        [NativeName("Name", "GL_BGR_INTEGER_EXT")]
        BgrIntegerExt = 0x8D9A,
        [NativeName("Name", "GL_BGRA_INTEGER_EXT")]
        BgraIntegerExt = 0x8D9B,
        [NativeName("Name", "GL_LUMINANCE_INTEGER_EXT")]
        LuminanceIntegerExt = 0x8D9C,
        [NativeName("Name", "GL_LUMINANCE_ALPHA_INTEGER_EXT")]
        LuminanceAlphaIntegerExt = 0x8D9D,
        [NativeName("Name", "GL_RGBA_INTEGER_MODE_EXT")]
        RgbaIntegerModeExt = 0x8D9E,
        [NativeName("Name", "GL_MAX_TEXTURE_LOD_BIAS_EXT")]
        MaxTextureLodBiasExt = 0x84FD,
        [NativeName("Name", "GL_TEXTURE_FILTER_CONTROL_EXT")]
        TextureFilterControlExt = 0x8500,
        [NativeName("Name", "GL_TEXTURE_LOD_BIAS_EXT")]
        TextureLodBiasExt = 0x8501,
        [NativeName("Name", "GL_MIRROR_CLAMP_EXT")]
        MirrorClampExt = 0x8742,
        [NativeName("Name", "GL_MIRROR_CLAMP_TO_EDGE_EXT")]
        MirrorClampToEdgeExt = 0x8743,
        [NativeName("Name", "GL_MIRROR_CLAMP_TO_BORDER_EXT")]
        MirrorClampToBorderExt = 0x8912,
        [NativeName("Name", "GL_TEXTURE_PRIORITY_EXT")]
        TexturePriorityExt = 0x8066,
        [NativeName("Name", "GL_TEXTURE_RESIDENT_EXT")]
        TextureResidentExt = 0x8067,
        [NativeName("Name", "GL_TEXTURE_1D_BINDING_EXT")]
        Texture1DBindingExt = 0x8068,
        [NativeName("Name", "GL_TEXTURE_2D_BINDING_EXT")]
        Texture2DBindingExt = 0x8069,
        [NativeName("Name", "GL_TEXTURE_3D_BINDING_EXT")]
        Texture3DBindingExt = 0x806A,
        [NativeName("Name", "GL_PERTURB_EXT")]
        PerturbExt = 0x85AE,
        [NativeName("Name", "GL_TEXTURE_NORMAL_EXT")]
        TextureNormalExt = 0x85AF,
        [NativeName("Name", "GL_RGB9_E5_EXT")]
        Rgb9E5Ext = 0x8C3D,
        [NativeName("Name", "GL_UNSIGNED_INT_5_9_9_9_REV_EXT")]
        UnsignedInt5999RevExt = 0x8C3E,
        [NativeName("Name", "GL_TEXTURE_SHARED_SIZE_EXT")]
        TextureSharedSizeExt = 0x8C3F,
        [NativeName("Name", "GL_ALPHA_SNORM")]
        AlphaSNorm = 0x9010,
        [NativeName("Name", "GL_LUMINANCE_SNORM")]
        LuminanceSNorm = 0x9011,
        [NativeName("Name", "GL_LUMINANCE_ALPHA_SNORM")]
        LuminanceAlphaSNorm = 0x9012,
        [NativeName("Name", "GL_INTENSITY_SNORM")]
        IntensitySNorm = 0x9013,
        [NativeName("Name", "GL_ALPHA8_SNORM")]
        Alpha8SNorm = 0x9014,
        [NativeName("Name", "GL_LUMINANCE8_SNORM")]
        Luminance8SNorm = 0x9015,
        [NativeName("Name", "GL_LUMINANCE8_ALPHA8_SNORM")]
        Luminance8Alpha8SNorm = 0x9016,
        [NativeName("Name", "GL_INTENSITY8_SNORM")]
        Intensity8SNorm = 0x9017,
        [NativeName("Name", "GL_ALPHA16_SNORM")]
        Alpha16SNorm = 0x9018,
        [NativeName("Name", "GL_LUMINANCE16_SNORM")]
        Luminance16SNorm = 0x9019,
        [NativeName("Name", "GL_LUMINANCE16_ALPHA16_SNORM")]
        Luminance16Alpha16SNorm = 0x901A,
        [NativeName("Name", "GL_INTENSITY16_SNORM")]
        Intensity16SNorm = 0x901B,
        [NativeName("Name", "GL_RED_SNORM")]
        RedSNorm = 0x8F90,
        [NativeName("Name", "GL_RG_SNORM")]
        RGSNorm = 0x8F91,
        [NativeName("Name", "GL_RGB_SNORM")]
        RgbSNorm = 0x8F92,
        [NativeName("Name", "GL_RGBA_SNORM")]
        RgbaSNorm = 0x8F93,
        [NativeName("Name", "GL_R8_SNORM")]
        R8SNorm = 0x8F94,
        [NativeName("Name", "GL_RG8_SNORM")]
        RG8SNorm = 0x8F95,
        [NativeName("Name", "GL_RGB8_SNORM")]
        Rgb8SNorm = 0x8F96,
        [NativeName("Name", "GL_RGBA8_SNORM")]
        Rgba8SNorm = 0x8F97,
        [NativeName("Name", "GL_R16_SNORM")]
        R16SNorm = 0x8F98,
        [NativeName("Name", "GL_RG16_SNORM")]
        RG16SNorm = 0x8F99,
        [NativeName("Name", "GL_RGB16_SNORM")]
        Rgb16SNorm = 0x8F9A,
        [NativeName("Name", "GL_RGBA16_SNORM")]
        Rgba16SNorm = 0x8F9B,
        [NativeName("Name", "GL_SIGNED_NORMALIZED")]
        SignedNormalized = 0x8F9C,
        [NativeName("Name", "GL_SRGB_EXT")]
        SrgbExt = 0x8C40,
        [NativeName("Name", "GL_SRGB8_EXT")]
        Srgb8Ext = 0x8C41,
        [NativeName("Name", "GL_SRGB_ALPHA_EXT")]
        SrgbAlphaExt = 0x8C42,
        [NativeName("Name", "GL_SRGB8_ALPHA8_EXT")]
        Srgb8Alpha8Ext = 0x8C43,
        [NativeName("Name", "GL_SLUMINANCE_ALPHA_EXT")]
        SluminanceAlphaExt = 0x8C44,
        [NativeName("Name", "GL_SLUMINANCE8_ALPHA8_EXT")]
        Sluminance8Alpha8Ext = 0x8C45,
        [NativeName("Name", "GL_SLUMINANCE_EXT")]
        SluminanceExt = 0x8C46,
        [NativeName("Name", "GL_SLUMINANCE8_EXT")]
        Sluminance8Ext = 0x8C47,
        [NativeName("Name", "GL_COMPRESSED_SRGB_EXT")]
        CompressedSrgbExt = 0x8C48,
        [NativeName("Name", "GL_COMPRESSED_SRGB_ALPHA_EXT")]
        CompressedSrgbAlphaExt = 0x8C49,
        [NativeName("Name", "GL_COMPRESSED_SLUMINANCE_EXT")]
        CompressedSluminanceExt = 0x8C4A,
        [NativeName("Name", "GL_COMPRESSED_SLUMINANCE_ALPHA_EXT")]
        CompressedSluminanceAlphaExt = 0x8C4B,
        [NativeName("Name", "GL_COMPRESSED_SRGB_S3TC_DXT1_EXT")]
        CompressedSrgbS3TCDxt1Ext = 0x8C4C,
        [NativeName("Name", "GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT")]
        CompressedSrgbAlphaS3TCDxt1Ext = 0x8C4D,
        [NativeName("Name", "GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT")]
        CompressedSrgbAlphaS3TCDxt3Ext = 0x8C4E,
        [NativeName("Name", "GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT")]
        CompressedSrgbAlphaS3TCDxt5Ext = 0x8C4F,
        [NativeName("Name", "GL_TEXTURE_SRGB_DECODE_EXT")]
        TextureSrgbDecodeExt = 0x8A48,
        [NativeName("Name", "GL_DECODE_EXT")]
        DecodeExt = 0x8A49,
        [NativeName("Name", "GL_SKIP_DECODE_EXT")]
        SkipDecodeExt = 0x8A4A,
        [NativeName("Name", "GL_SR8_EXT")]
        SR8Ext = 0x8FBD,
        [NativeName("Name", "GL_SRG8_EXT")]
        Srg8Ext = 0x8FBE,
        [NativeName("Name", "GL_TEXTURE_IMMUTABLE_FORMAT_EXT")]
        TextureImmutableFormatExt = 0x912F,
        [NativeName("Name", "GL_RGBA32F_EXT")]
        Rgba32fExt = 0x8814,
        [NativeName("Name", "GL_RGB32F_EXT")]
        Rgb32fExt = 0x8815,
        [NativeName("Name", "GL_ALPHA32F_EXT")]
        Alpha32fExt = 0x8816,
        [NativeName("Name", "GL_LUMINANCE32F_EXT")]
        Luminance32fExt = 0x8818,
        [NativeName("Name", "GL_LUMINANCE_ALPHA32F_EXT")]
        LuminanceAlpha32fExt = 0x8819,
        [NativeName("Name", "GL_RGBA16F_EXT")]
        Rgba16fExt = 0x881A,
        [NativeName("Name", "GL_RGB16F_EXT")]
        Rgb16fExt = 0x881B,
        [NativeName("Name", "GL_ALPHA16F_EXT")]
        Alpha16fExt = 0x881C,
        [NativeName("Name", "GL_LUMINANCE16F_EXT")]
        Luminance16fExt = 0x881E,
        [NativeName("Name", "GL_LUMINANCE_ALPHA16F_EXT")]
        LuminanceAlpha16fExt = 0x881F,
        [NativeName("Name", "GL_BGRA8_EXT")]
        Bgra8Ext = 0x93A1,
        [NativeName("Name", "GL_R8_EXT")]
        R8Ext = 0x8229,
        [NativeName("Name", "GL_RG8_EXT")]
        RG8Ext = 0x822B,
        [NativeName("Name", "GL_R32F_EXT")]
        R32fExt = 0x822E,
        [NativeName("Name", "GL_RG32F_EXT")]
        RG32fExt = 0x8230,
        [NativeName("Name", "GL_R16F_EXT")]
        R16fExt = 0x822D,
        [NativeName("Name", "GL_RG16F_EXT")]
        RG16fExt = 0x822F,
        [NativeName("Name", "GL_TEXTURE_SWIZZLE_R_EXT")]
        TextureSwizzleRExt = 0x8E42,
        [NativeName("Name", "GL_TEXTURE_SWIZZLE_G_EXT")]
        TextureSwizzleGExt = 0x8E43,
        [NativeName("Name", "GL_TEXTURE_SWIZZLE_B_EXT")]
        TextureSwizzleBExt = 0x8E44,
        [NativeName("Name", "GL_TEXTURE_SWIZZLE_A_EXT")]
        TextureSwizzleAExt = 0x8E45,
        [NativeName("Name", "GL_TEXTURE_SWIZZLE_RGBA_EXT")]
        TextureSwizzleRgbaExt = 0x8E46,
        [NativeName("Name", "GL_TIME_ELAPSED_EXT")]
        TimeElapsedExt = 0x88BF,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_EXT")]
        TransformFeedbackBufferExt = 0x8C8E,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_START_EXT")]
        TransformFeedbackBufferStartExt = 0x8C84,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_SIZE_EXT")]
        TransformFeedbackBufferSizeExt = 0x8C85,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_BINDING_EXT")]
        TransformFeedbackBufferBindingExt = 0x8C8F,
        [NativeName("Name", "GL_INTERLEAVED_ATTRIBS_EXT")]
        InterleavedAttribsExt = 0x8C8C,
        [NativeName("Name", "GL_SEPARATE_ATTRIBS_EXT")]
        SeparateAttribsExt = 0x8C8D,
        [NativeName("Name", "GL_PRIMITIVES_GENERATED_EXT")]
        PrimitivesGeneratedExt = 0x8C87,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN_EXT")]
        TransformFeedbackPrimitivesWrittenExt = 0x8C88,
        [NativeName("Name", "GL_RASTERIZER_DISCARD_EXT")]
        RasterizerDiscardExt = 0x8C89,
        [NativeName("Name", "GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS_EXT")]
        MaxTransformFeedbackInterleavedComponentsExt = 0x8C8A,
        [NativeName("Name", "GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS_EXT")]
        MaxTransformFeedbackSeparateAttribsExt = 0x8C8B,
        [NativeName("Name", "GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS_EXT")]
        MaxTransformFeedbackSeparateComponentsExt = 0x8C80,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_VARYINGS_EXT")]
        TransformFeedbackVaryingsExt = 0x8C83,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_MODE_EXT")]
        TransformFeedbackBufferModeExt = 0x8C7F,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH_EXT")]
        TransformFeedbackVaryingMaxLengthExt = 0x8C76,
        [NativeName("Name", "GL_VERTEX_ARRAY_EXT")]
        VertexArrayExt = 0x8074,
        [NativeName("Name", "GL_NORMAL_ARRAY_EXT")]
        NormalArrayExt = 0x8075,
        [NativeName("Name", "GL_COLOR_ARRAY_EXT")]
        ColorArrayExt = 0x8076,
        [NativeName("Name", "GL_INDEX_ARRAY_EXT")]
        IndexArrayExt = 0x8077,
        [NativeName("Name", "GL_TEXTURE_COORD_ARRAY_EXT")]
        TextureCoordArrayExt = 0x8078,
        [NativeName("Name", "GL_EDGE_FLAG_ARRAY_EXT")]
        EdgeFlagArrayExt = 0x8079,
        [NativeName("Name", "GL_VERTEX_ARRAY_SIZE_EXT")]
        VertexArraySizeExt = 0x807A,
        [NativeName("Name", "GL_VERTEX_ARRAY_TYPE_EXT")]
        VertexArrayTypeExt = 0x807B,
        [NativeName("Name", "GL_VERTEX_ARRAY_STRIDE_EXT")]
        VertexArrayStrideExt = 0x807C,
        [NativeName("Name", "GL_VERTEX_ARRAY_COUNT_EXT")]
        VertexArrayCountExt = 0x807D,
        [NativeName("Name", "GL_NORMAL_ARRAY_TYPE_EXT")]
        NormalArrayTypeExt = 0x807E,
        [NativeName("Name", "GL_NORMAL_ARRAY_STRIDE_EXT")]
        NormalArrayStrideExt = 0x807F,
        [NativeName("Name", "GL_NORMAL_ARRAY_COUNT_EXT")]
        NormalArrayCountExt = 0x8080,
        [NativeName("Name", "GL_COLOR_ARRAY_SIZE_EXT")]
        ColorArraySizeExt = 0x8081,
        [NativeName("Name", "GL_COLOR_ARRAY_TYPE_EXT")]
        ColorArrayTypeExt = 0x8082,
        [NativeName("Name", "GL_COLOR_ARRAY_STRIDE_EXT")]
        ColorArrayStrideExt = 0x8083,
        [NativeName("Name", "GL_COLOR_ARRAY_COUNT_EXT")]
        ColorArrayCountExt = 0x8084,
        [NativeName("Name", "GL_INDEX_ARRAY_TYPE_EXT")]
        IndexArrayTypeExt = 0x8085,
        [NativeName("Name", "GL_INDEX_ARRAY_STRIDE_EXT")]
        IndexArrayStrideExt = 0x8086,
        [NativeName("Name", "GL_INDEX_ARRAY_COUNT_EXT")]
        IndexArrayCountExt = 0x8087,
        [NativeName("Name", "GL_TEXTURE_COORD_ARRAY_SIZE_EXT")]
        TextureCoordArraySizeExt = 0x8088,
        [NativeName("Name", "GL_TEXTURE_COORD_ARRAY_TYPE_EXT")]
        TextureCoordArrayTypeExt = 0x8089,
        [NativeName("Name", "GL_TEXTURE_COORD_ARRAY_STRIDE_EXT")]
        TextureCoordArrayStrideExt = 0x808A,
        [NativeName("Name", "GL_TEXTURE_COORD_ARRAY_COUNT_EXT")]
        TextureCoordArrayCountExt = 0x808B,
        [NativeName("Name", "GL_EDGE_FLAG_ARRAY_STRIDE_EXT")]
        EdgeFlagArrayStrideExt = 0x808C,
        [NativeName("Name", "GL_EDGE_FLAG_ARRAY_COUNT_EXT")]
        EdgeFlagArrayCountExt = 0x808D,
        [NativeName("Name", "GL_VERTEX_ARRAY_POINTER_EXT")]
        VertexArrayPointerExt = 0x808E,
        [NativeName("Name", "GL_NORMAL_ARRAY_POINTER_EXT")]
        NormalArrayPointerExt = 0x808F,
        [NativeName("Name", "GL_COLOR_ARRAY_POINTER_EXT")]
        ColorArrayPointerExt = 0x8090,
        [NativeName("Name", "GL_INDEX_ARRAY_POINTER_EXT")]
        IndexArrayPointerExt = 0x8091,
        [NativeName("Name", "GL_TEXTURE_COORD_ARRAY_POINTER_EXT")]
        TextureCoordArrayPointerExt = 0x8092,
        [NativeName("Name", "GL_EDGE_FLAG_ARRAY_POINTER_EXT")]
        EdgeFlagArrayPointerExt = 0x8093,
        [NativeName("Name", "GL_BGRA")]
        Bgra = 0x80E1,
        [NativeName("Name", "GL_DOUBLE")]
        Double = 0x140A,
        [NativeName("Name", "GL_DOUBLE_VEC2_EXT")]
        DoubleVec2Ext = 0x8FFC,
        [NativeName("Name", "GL_DOUBLE_VEC3_EXT")]
        DoubleVec3Ext = 0x8FFD,
        [NativeName("Name", "GL_DOUBLE_VEC4_EXT")]
        DoubleVec4Ext = 0x8FFE,
        [NativeName("Name", "GL_DOUBLE_MAT2_EXT")]
        DoubleMat2Ext = 0x8F46,
        [NativeName("Name", "GL_DOUBLE_MAT3_EXT")]
        DoubleMat3Ext = 0x8F47,
        [NativeName("Name", "GL_DOUBLE_MAT4_EXT")]
        DoubleMat4Ext = 0x8F48,
        [NativeName("Name", "GL_DOUBLE_MAT2x3_EXT")]
        DoubleMat2x3Ext = 0x8F49,
        [NativeName("Name", "GL_DOUBLE_MAT2x4_EXT")]
        DoubleMat2x4Ext = 0x8F4A,
        [NativeName("Name", "GL_DOUBLE_MAT3x2_EXT")]
        DoubleMat3x2Ext = 0x8F4B,
        [NativeName("Name", "GL_DOUBLE_MAT3x4_EXT")]
        DoubleMat3x4Ext = 0x8F4C,
        [NativeName("Name", "GL_DOUBLE_MAT4x2_EXT")]
        DoubleMat4x2Ext = 0x8F4D,
        [NativeName("Name", "GL_DOUBLE_MAT4x3_EXT")]
        DoubleMat4x3Ext = 0x8F4E,
        [NativeName("Name", "GL_VERTEX_SHADER_EXT")]
        VertexShaderExt = 0x8780,
        [NativeName("Name", "GL_VERTEX_SHADER_BINDING_EXT")]
        VertexShaderBindingExt = 0x8781,
        [NativeName("Name", "GL_OP_INDEX_EXT")]
        OpIndexExt = 0x8782,
        [NativeName("Name", "GL_OP_NEGATE_EXT")]
        OpNegateExt = 0x8783,
        [NativeName("Name", "GL_OP_DOT3_EXT")]
        OpDot3Ext = 0x8784,
        [NativeName("Name", "GL_OP_DOT4_EXT")]
        OpDot4Ext = 0x8785,
        [NativeName("Name", "GL_OP_MUL_EXT")]
        OpMulExt = 0x8786,
        [NativeName("Name", "GL_OP_ADD_EXT")]
        OpAddExt = 0x8787,
        [NativeName("Name", "GL_OP_MADD_EXT")]
        OpMaddExt = 0x8788,
        [NativeName("Name", "GL_OP_FRAC_EXT")]
        OpFracExt = 0x8789,
        [NativeName("Name", "GL_OP_MAX_EXT")]
        OpMaxExt = 0x878A,
        [NativeName("Name", "GL_OP_MIN_EXT")]
        OpMinExt = 0x878B,
        [NativeName("Name", "GL_OP_SET_GE_EXT")]
        OpSetGEExt = 0x878C,
        [NativeName("Name", "GL_OP_SET_LT_EXT")]
        OpSetLTExt = 0x878D,
        [NativeName("Name", "GL_OP_CLAMP_EXT")]
        OpClampExt = 0x878E,
        [NativeName("Name", "GL_OP_FLOOR_EXT")]
        OpFloorExt = 0x878F,
        [NativeName("Name", "GL_OP_ROUND_EXT")]
        OpRoundExt = 0x8790,
        [NativeName("Name", "GL_OP_EXP_BASE_2_EXT")]
        OpExpBase2Ext = 0x8791,
        [NativeName("Name", "GL_OP_LOG_BASE_2_EXT")]
        OpLogBase2Ext = 0x8792,
        [NativeName("Name", "GL_OP_POWER_EXT")]
        OpPowerExt = 0x8793,
        [NativeName("Name", "GL_OP_RECIP_EXT")]
        OpRecipExt = 0x8794,
        [NativeName("Name", "GL_OP_RECIP_SQRT_EXT")]
        OpRecipSqrtExt = 0x8795,
        [NativeName("Name", "GL_OP_SUB_EXT")]
        OpSubExt = 0x8796,
        [NativeName("Name", "GL_OP_CROSS_PRODUCT_EXT")]
        OpCrossProductExt = 0x8797,
        [NativeName("Name", "GL_OP_MULTIPLY_MATRIX_EXT")]
        OpMultiplyMatrixExt = 0x8798,
        [NativeName("Name", "GL_OP_MOV_EXT")]
        OpMovExt = 0x8799,
        [NativeName("Name", "GL_OUTPUT_VERTEX_EXT")]
        OutputVertexExt = 0x879A,
        [NativeName("Name", "GL_OUTPUT_COLOR0_EXT")]
        OutputColor0Ext = 0x879B,
        [NativeName("Name", "GL_OUTPUT_COLOR1_EXT")]
        OutputColor1Ext = 0x879C,
        [NativeName("Name", "GL_OUTPUT_TEXTURE_COORD0_EXT")]
        OutputTextureCoord0Ext = 0x879D,
        [NativeName("Name", "GL_OUTPUT_TEXTURE_COORD1_EXT")]
        OutputTextureCoord1Ext = 0x879E,
        [NativeName("Name", "GL_OUTPUT_TEXTURE_COORD2_EXT")]
        OutputTextureCoord2Ext = 0x879F,
        [NativeName("Name", "GL_OUTPUT_TEXTURE_COORD3_EXT")]
        OutputTextureCoord3Ext = 0x87A0,
        [NativeName("Name", "GL_OUTPUT_TEXTURE_COORD4_EXT")]
        OutputTextureCoord4Ext = 0x87A1,
        [NativeName("Name", "GL_OUTPUT_TEXTURE_COORD5_EXT")]
        OutputTextureCoord5Ext = 0x87A2,
        [NativeName("Name", "GL_OUTPUT_TEXTURE_COORD6_EXT")]
        OutputTextureCoord6Ext = 0x87A3,
        [NativeName("Name", "GL_OUTPUT_TEXTURE_COORD7_EXT")]
        OutputTextureCoord7Ext = 0x87A4,
        [NativeName("Name", "GL_OUTPUT_TEXTURE_COORD8_EXT")]
        OutputTextureCoord8Ext = 0x87A5,
        [NativeName("Name", "GL_OUTPUT_TEXTURE_COORD9_EXT")]
        OutputTextureCoord9Ext = 0x87A6,
        [NativeName("Name", "GL_OUTPUT_TEXTURE_COORD10_EXT")]
        OutputTextureCoord10Ext = 0x87A7,
        [NativeName("Name", "GL_OUTPUT_TEXTURE_COORD11_EXT")]
        OutputTextureCoord11Ext = 0x87A8,
        [NativeName("Name", "GL_OUTPUT_TEXTURE_COORD12_EXT")]
        OutputTextureCoord12Ext = 0x87A9,
        [NativeName("Name", "GL_OUTPUT_TEXTURE_COORD13_EXT")]
        OutputTextureCoord13Ext = 0x87AA,
        [NativeName("Name", "GL_OUTPUT_TEXTURE_COORD14_EXT")]
        OutputTextureCoord14Ext = 0x87AB,
        [NativeName("Name", "GL_OUTPUT_TEXTURE_COORD15_EXT")]
        OutputTextureCoord15Ext = 0x87AC,
        [NativeName("Name", "GL_OUTPUT_TEXTURE_COORD16_EXT")]
        OutputTextureCoord16Ext = 0x87AD,
        [NativeName("Name", "GL_OUTPUT_TEXTURE_COORD17_EXT")]
        OutputTextureCoord17Ext = 0x87AE,
        [NativeName("Name", "GL_OUTPUT_TEXTURE_COORD18_EXT")]
        OutputTextureCoord18Ext = 0x87AF,
        [NativeName("Name", "GL_OUTPUT_TEXTURE_COORD19_EXT")]
        OutputTextureCoord19Ext = 0x87B0,
        [NativeName("Name", "GL_OUTPUT_TEXTURE_COORD20_EXT")]
        OutputTextureCoord20Ext = 0x87B1,
        [NativeName("Name", "GL_OUTPUT_TEXTURE_COORD21_EXT")]
        OutputTextureCoord21Ext = 0x87B2,
        [NativeName("Name", "GL_OUTPUT_TEXTURE_COORD22_EXT")]
        OutputTextureCoord22Ext = 0x87B3,
        [NativeName("Name", "GL_OUTPUT_TEXTURE_COORD23_EXT")]
        OutputTextureCoord23Ext = 0x87B4,
        [NativeName("Name", "GL_OUTPUT_TEXTURE_COORD24_EXT")]
        OutputTextureCoord24Ext = 0x87B5,
        [NativeName("Name", "GL_OUTPUT_TEXTURE_COORD25_EXT")]
        OutputTextureCoord25Ext = 0x87B6,
        [NativeName("Name", "GL_OUTPUT_TEXTURE_COORD26_EXT")]
        OutputTextureCoord26Ext = 0x87B7,
        [NativeName("Name", "GL_OUTPUT_TEXTURE_COORD27_EXT")]
        OutputTextureCoord27Ext = 0x87B8,
        [NativeName("Name", "GL_OUTPUT_TEXTURE_COORD28_EXT")]
        OutputTextureCoord28Ext = 0x87B9,
        [NativeName("Name", "GL_OUTPUT_TEXTURE_COORD29_EXT")]
        OutputTextureCoord29Ext = 0x87BA,
        [NativeName("Name", "GL_OUTPUT_TEXTURE_COORD30_EXT")]
        OutputTextureCoord30Ext = 0x87BB,
        [NativeName("Name", "GL_OUTPUT_TEXTURE_COORD31_EXT")]
        OutputTextureCoord31Ext = 0x87BC,
        [NativeName("Name", "GL_OUTPUT_FOG_EXT")]
        OutputFogExt = 0x87BD,
        [NativeName("Name", "GL_SCALAR_EXT")]
        ScalarExt = 0x87BE,
        [NativeName("Name", "GL_VECTOR_EXT")]
        VectorExt = 0x87BF,
        [NativeName("Name", "GL_MATRIX_EXT")]
        MatrixExt = 0x87C0,
        [NativeName("Name", "GL_VARIANT_EXT")]
        VariantExt = 0x87C1,
        [NativeName("Name", "GL_INVARIANT_EXT")]
        InvariantExt = 0x87C2,
        [NativeName("Name", "GL_LOCAL_CONSTANT_EXT")]
        LocalConstantExt = 0x87C3,
        [NativeName("Name", "GL_LOCAL_EXT")]
        LocalExt = 0x87C4,
        [NativeName("Name", "GL_MAX_VERTEX_SHADER_INSTRUCTIONS_EXT")]
        MaxVertexShaderInstructionsExt = 0x87C5,
        [NativeName("Name", "GL_MAX_VERTEX_SHADER_VARIANTS_EXT")]
        MaxVertexShaderVariantsExt = 0x87C6,
        [NativeName("Name", "GL_MAX_VERTEX_SHADER_INVARIANTS_EXT")]
        MaxVertexShaderInvariantsExt = 0x87C7,
        [NativeName("Name", "GL_MAX_VERTEX_SHADER_LOCAL_CONSTANTS_EXT")]
        MaxVertexShaderLocalConstantsExt = 0x87C8,
        [NativeName("Name", "GL_MAX_VERTEX_SHADER_LOCALS_EXT")]
        MaxVertexShaderLocalsExt = 0x87C9,
        [NativeName("Name", "GL_MAX_OPTIMIZED_VERTEX_SHADER_INSTRUCTIONS_EXT")]
        MaxOptimizedVertexShaderInstructionsExt = 0x87CA,
        [NativeName("Name", "GL_MAX_OPTIMIZED_VERTEX_SHADER_VARIANTS_EXT")]
        MaxOptimizedVertexShaderVariantsExt = 0x87CB,
        [NativeName("Name", "GL_MAX_OPTIMIZED_VERTEX_SHADER_LOCAL_CONSTANTS_EXT")]
        MaxOptimizedVertexShaderLocalConstantsExt = 0x87CC,
        [NativeName("Name", "GL_MAX_OPTIMIZED_VERTEX_SHADER_INVARIANTS_EXT")]
        MaxOptimizedVertexShaderInvariantsExt = 0x87CD,
        [NativeName("Name", "GL_MAX_OPTIMIZED_VERTEX_SHADER_LOCALS_EXT")]
        MaxOptimizedVertexShaderLocalsExt = 0x87CE,
        [NativeName("Name", "GL_VERTEX_SHADER_INSTRUCTIONS_EXT")]
        VertexShaderInstructionsExt = 0x87CF,
        [NativeName("Name", "GL_VERTEX_SHADER_VARIANTS_EXT")]
        VertexShaderVariantsExt = 0x87D0,
        [NativeName("Name", "GL_VERTEX_SHADER_INVARIANTS_EXT")]
        VertexShaderInvariantsExt = 0x87D1,
        [NativeName("Name", "GL_VERTEX_SHADER_LOCAL_CONSTANTS_EXT")]
        VertexShaderLocalConstantsExt = 0x87D2,
        [NativeName("Name", "GL_VERTEX_SHADER_LOCALS_EXT")]
        VertexShaderLocalsExt = 0x87D3,
        [NativeName("Name", "GL_VERTEX_SHADER_OPTIMIZED_EXT")]
        VertexShaderOptimizedExt = 0x87D4,
        [NativeName("Name", "GL_X_EXT")]
        XExt = 0x87D5,
        [NativeName("Name", "GL_Y_EXT")]
        YExt = 0x87D6,
        [NativeName("Name", "GL_Z_EXT")]
        ZExt = 0x87D7,
        [NativeName("Name", "GL_W_EXT")]
        WExt = 0x87D8,
        [NativeName("Name", "GL_NEGATIVE_X_EXT")]
        NegativeXExt = 0x87D9,
        [NativeName("Name", "GL_NEGATIVE_Y_EXT")]
        NegativeYExt = 0x87DA,
        [NativeName("Name", "GL_NEGATIVE_Z_EXT")]
        NegativeZExt = 0x87DB,
        [NativeName("Name", "GL_NEGATIVE_W_EXT")]
        NegativeWExt = 0x87DC,
        [NativeName("Name", "GL_ZERO_EXT")]
        ZeroExt = 0x87DD,
        [NativeName("Name", "GL_ONE_EXT")]
        OneExt = 0x87DE,
        [NativeName("Name", "GL_NEGATIVE_ONE_EXT")]
        NegativeOneExt = 0x87DF,
        [NativeName("Name", "GL_NORMALIZED_RANGE_EXT")]
        NormalizedRangeExt = 0x87E0,
        [NativeName("Name", "GL_FULL_RANGE_EXT")]
        FullRangeExt = 0x87E1,
        [NativeName("Name", "GL_CURRENT_VERTEX_EXT")]
        CurrentVertexExt = 0x87E2,
        [NativeName("Name", "GL_MVP_MATRIX_EXT")]
        MvpMatrixExt = 0x87E3,
        [NativeName("Name", "GL_VARIANT_VALUE_EXT")]
        VariantValueExt = 0x87E4,
        [NativeName("Name", "GL_VARIANT_DATATYPE_EXT")]
        VariantDatatypeExt = 0x87E5,
        [NativeName("Name", "GL_VARIANT_ARRAY_STRIDE_EXT")]
        VariantArrayStrideExt = 0x87E6,
        [NativeName("Name", "GL_VARIANT_ARRAY_TYPE_EXT")]
        VariantArrayTypeExt = 0x87E7,
        [NativeName("Name", "GL_VARIANT_ARRAY_EXT")]
        VariantArrayExt = 0x87E8,
        [NativeName("Name", "GL_VARIANT_ARRAY_POINTER_EXT")]
        VariantArrayPointerExt = 0x87E9,
        [NativeName("Name", "GL_INVARIANT_VALUE_EXT")]
        InvariantValueExt = 0x87EA,
        [NativeName("Name", "GL_INVARIANT_DATATYPE_EXT")]
        InvariantDatatypeExt = 0x87EB,
        [NativeName("Name", "GL_LOCAL_CONSTANT_VALUE_EXT")]
        LocalConstantValueExt = 0x87EC,
        [NativeName("Name", "GL_LOCAL_CONSTANT_DATATYPE_EXT")]
        LocalConstantDatatypeExt = 0x87ED,
        [NativeName("Name", "GL_MODELVIEW0_STACK_DEPTH_EXT")]
        Modelview0StackDepthExt = 0xBA3,
        [NativeName("Name", "GL_MODELVIEW1_STACK_DEPTH_EXT")]
        Modelview1StackDepthExt = 0x8502,
        [NativeName("Name", "GL_MODELVIEW0_MATRIX_EXT")]
        Modelview0MatrixExt = 0xBA6,
        [NativeName("Name", "GL_MODELVIEW1_MATRIX_EXT")]
        Modelview1MatrixExt = 0x8506,
        [NativeName("Name", "GL_VERTEX_WEIGHTING_EXT")]
        VertexWeightingExt = 0x8509,
        [NativeName("Name", "GL_MODELVIEW0_EXT")]
        Modelview0Ext = 0x1700,
        [NativeName("Name", "GL_MODELVIEW1_EXT")]
        Modelview1Ext = 0x850A,
        [NativeName("Name", "GL_CURRENT_VERTEX_WEIGHT_EXT")]
        CurrentVertexWeightExt = 0x850B,
        [NativeName("Name", "GL_VERTEX_WEIGHT_ARRAY_EXT")]
        VertexWeightArrayExt = 0x850C,
        [NativeName("Name", "GL_VERTEX_WEIGHT_ARRAY_SIZE_EXT")]
        VertexWeightArraySizeExt = 0x850D,
        [NativeName("Name", "GL_VERTEX_WEIGHT_ARRAY_TYPE_EXT")]
        VertexWeightArrayTypeExt = 0x850E,
        [NativeName("Name", "GL_VERTEX_WEIGHT_ARRAY_STRIDE_EXT")]
        VertexWeightArrayStrideExt = 0x850F,
        [NativeName("Name", "GL_VERTEX_WEIGHT_ARRAY_POINTER_EXT")]
        VertexWeightArrayPointerExt = 0x8510,
        [NativeName("Name", "GL_INCLUSIVE_EXT")]
        InclusiveExt = 0x8F10,
        [NativeName("Name", "GL_EXCLUSIVE_EXT")]
        ExclusiveExt = 0x8F11,
        [NativeName("Name", "GL_WINDOW_RECTANGLE_EXT")]
        WindowRectangleExt = 0x8F12,
        [NativeName("Name", "GL_WINDOW_RECTANGLE_MODE_EXT")]
        WindowRectangleModeExt = 0x8F13,
        [NativeName("Name", "GL_MAX_WINDOW_RECTANGLES_EXT")]
        MaxWindowRectanglesExt = 0x8F14,
        [NativeName("Name", "GL_NUM_WINDOW_RECTANGLES_EXT")]
        NumWindowRectanglesExt = 0x8F15,
        [NativeName("Name", "GL_SYNC_X11_FENCE_EXT")]
        SyncX11FenceExt = 0x90E1,
    }
}
