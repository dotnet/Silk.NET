// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV.Cross
{
    [NativeName("Name", "spvc_compiler_option")]
    public enum CompilerOption : int
    {
        [NativeName("Name", "SPVC_COMPILER_OPTION_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "SPVC_COMPILER_OPTION_FORCE_TEMPORARY")]
        ForceTemporary = 0x1000001,
        [NativeName("Name", "SPVC_COMPILER_OPTION_FLATTEN_MULTIDIMENSIONAL_ARRAYS")]
        FlattenMultidimensionalArrays = 0x1000002,
        [NativeName("Name", "SPVC_COMPILER_OPTION_FIXUP_DEPTH_CONVENTION")]
        FixupDepthConvention = 0x1000003,
        [NativeName("Name", "SPVC_COMPILER_OPTION_FLIP_VERTEX_Y")]
        FlipVertexY = 0x1000004,
        [NativeName("Name", "SPVC_COMPILER_OPTION_GLSL_SUPPORT_NONZERO_BASE_INSTANCE")]
        GlslSupportNonzeroBaseInstance = 0x2000005,
        [NativeName("Name", "SPVC_COMPILER_OPTION_GLSL_SEPARATE_SHADER_OBJECTS")]
        GlslSeparateShaderObjects = 0x2000006,
        [NativeName("Name", "SPVC_COMPILER_OPTION_GLSL_ENABLE_420PACK_EXTENSION")]
        GlslEnable420PackExtension = 0x2000007,
        [NativeName("Name", "SPVC_COMPILER_OPTION_GLSL_VERSION")]
        GlslVersion = 0x2000008,
        [NativeName("Name", "SPVC_COMPILER_OPTION_GLSL_ES")]
        GlslES = 0x2000009,
        [NativeName("Name", "SPVC_COMPILER_OPTION_GLSL_VULKAN_SEMANTICS")]
        GlslVulkanSemantics = 0x200000A,
        [NativeName("Name", "SPVC_COMPILER_OPTION_GLSL_ES_DEFAULT_FLOAT_PRECISION_HIGHP")]
        GlslESDefaultFloatPrecisionHighp = 0x200000B,
        [NativeName("Name", "SPVC_COMPILER_OPTION_GLSL_ES_DEFAULT_INT_PRECISION_HIGHP")]
        GlslESDefaultIntPrecisionHighp = 0x200000C,
        [NativeName("Name", "SPVC_COMPILER_OPTION_HLSL_SHADER_MODEL")]
        HlslShaderModel = 0x400000D,
        [NativeName("Name", "SPVC_COMPILER_OPTION_HLSL_POINT_SIZE_COMPAT")]
        HlslPointSizeCompat = 0x400000E,
        [NativeName("Name", "SPVC_COMPILER_OPTION_HLSL_POINT_COORD_COMPAT")]
        HlslPointCoordCompat = 0x400000F,
        [NativeName("Name", "SPVC_COMPILER_OPTION_HLSL_SUPPORT_NONZERO_BASE_VERTEX_BASE_INSTANCE")]
        HlslSupportNonzeroBaseVertexBaseInstance = 0x4000010,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_VERSION")]
        MslVersion = 0x8000011,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_TEXEL_BUFFER_TEXTURE_WIDTH")]
        MslTexelBufferTextureWidth = 0x8000012,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_AUX_BUFFER_INDEX")]
        MslAuxBufferIndex = 0x8000013,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_SWIZZLE_BUFFER_INDEX")]
        MslSwizzleBufferIndex = 0x8000013,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_INDIRECT_PARAMS_BUFFER_INDEX")]
        MslIndirectParamsBufferIndex = 0x8000014,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_SHADER_OUTPUT_BUFFER_INDEX")]
        MslShaderOutputBufferIndex = 0x8000015,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_SHADER_PATCH_OUTPUT_BUFFER_INDEX")]
        MslShaderPatchOutputBufferIndex = 0x8000016,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_SHADER_TESS_FACTOR_OUTPUT_BUFFER_INDEX")]
        MslShaderTessFactorOutputBufferIndex = 0x8000017,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_SHADER_INPUT_WORKGROUP_INDEX")]
        MslShaderInputWorkgroupIndex = 0x8000018,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_ENABLE_POINT_SIZE_BUILTIN")]
        MslEnablePointSizeBuiltin = 0x8000019,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_DISABLE_RASTERIZATION")]
        MslDisableRasterization = 0x800001A,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_CAPTURE_OUTPUT_TO_BUFFER")]
        MslCaptureOutputToBuffer = 0x800001B,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_SWIZZLE_TEXTURE_SAMPLES")]
        MslSwizzleTextureSamples = 0x800001C,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_PAD_FRAGMENT_OUTPUT_COMPONENTS")]
        MslPadFragmentOutputComponents = 0x800001D,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_TESS_DOMAIN_ORIGIN_LOWER_LEFT")]
        MslTessDomainOriginLowerLeft = 0x800001E,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_PLATFORM")]
        MslPlatform = 0x800001F,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_ARGUMENT_BUFFERS")]
        MslArgumentBuffers = 0x8000020,
        [NativeName("Name", "SPVC_COMPILER_OPTION_GLSL_EMIT_PUSH_CONSTANT_AS_UNIFORM_BUFFER")]
        GlslEmitPushConstantAsUniformBuffer = 0x2000021,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_TEXTURE_BUFFER_NATIVE")]
        MslTextureBufferNative = 0x8000022,
        [NativeName("Name", "SPVC_COMPILER_OPTION_GLSL_EMIT_UNIFORM_BUFFER_AS_PLAIN_UNIFORMS")]
        GlslEmitUniformBufferAsPlainUniforms = 0x2000023,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_BUFFER_SIZE_BUFFER_INDEX")]
        MslBufferSizeBufferIndex = 0x8000024,
        [NativeName("Name", "SPVC_COMPILER_OPTION_EMIT_LINE_DIRECTIVES")]
        EmitLineDirectives = 0x1000025,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_MULTIVIEW")]
        MslMultiview = 0x8000026,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_VIEW_MASK_BUFFER_INDEX")]
        MslViewMaskBufferIndex = 0x8000027,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_DEVICE_INDEX")]
        MslDeviceIndex = 0x8000028,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_VIEW_INDEX_FROM_DEVICE_INDEX")]
        MslViewIndexFromDeviceIndex = 0x8000029,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_DISPATCH_BASE")]
        MslDispatchBase = 0x800002A,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_DYNAMIC_OFFSETS_BUFFER_INDEX")]
        MslDynamicOffsetsBufferIndex = 0x800002B,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_TEXTURE_1D_AS_2D")]
        MslTexture1DAs2D = 0x800002C,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_ENABLE_BASE_INDEX_ZERO")]
        MslEnableBaseIndexZero = 0x800002D,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_IOS_FRAMEBUFFER_FETCH_SUBPASS")]
        MslIosFramebufferFetchSubpass = 0x800002E,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_FRAMEBUFFER_FETCH_SUBPASS")]
        MslFramebufferFetchSubpass = 0x800002E,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_INVARIANT_FP_MATH")]
        MslInvariantFPMath = 0x800002F,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_EMULATE_CUBEMAP_ARRAY")]
        MslEmulateCubemapArray = 0x8000030,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_ENABLE_DECORATION_BINDING")]
        MslEnableDecorationBinding = 0x8000031,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_FORCE_ACTIVE_ARGUMENT_BUFFER_RESOURCES")]
        MslForceActiveArgumentBufferResources = 0x8000032,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_FORCE_NATIVE_ARRAYS")]
        MslForceNativeArrays = 0x8000033,
        [NativeName("Name", "SPVC_COMPILER_OPTION_ENABLE_STORAGE_IMAGE_QUALIFIER_DEDUCTION")]
        EnableStorageImageQualifierDeduction = 0x1000034,
        [NativeName("Name", "SPVC_COMPILER_OPTION_HLSL_FORCE_STORAGE_BUFFER_AS_UAV")]
        HlslForceStorageBufferAsUav = 0x4000035,
        [NativeName("Name", "SPVC_COMPILER_OPTION_FORCE_ZERO_INITIALIZED_VARIABLES")]
        ForceZeroInitializedVariables = 0x1000036,
        [NativeName("Name", "SPVC_COMPILER_OPTION_HLSL_NONWRITABLE_UAV_TEXTURE_AS_SRV")]
        HlslNonwritableUavTextureAsSrv = 0x4000037,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_ENABLE_FRAG_OUTPUT_MASK")]
        MslEnableFragOutputMask = 0x8000038,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_ENABLE_FRAG_DEPTH_BUILTIN")]
        MslEnableFragDepthBuiltin = 0x8000039,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_ENABLE_FRAG_STENCIL_REF_BUILTIN")]
        MslEnableFragStencilRefBuiltin = 0x800003A,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_ENABLE_CLIP_DISTANCE_USER_VARYING")]
        MslEnableClipDistanceUserVarying = 0x800003B,
        [NativeName("Name", "SPVC_COMPILER_OPTION_HLSL_ENABLE_16BIT_TYPES")]
        HlslEnable16BitTypes = 0x400003C,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_MULTI_PATCH_WORKGROUP")]
        MslMultiPatchWorkgroup = 0x800003D,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_SHADER_INPUT_BUFFER_INDEX")]
        MslShaderInputBufferIndex = 0x800003E,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_SHADER_INDEX_BUFFER_INDEX")]
        MslShaderIndexBufferIndex = 0x800003F,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_VERTEX_FOR_TESSELLATION")]
        MslVertexForTessellation = 0x8000040,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_VERTEX_INDEX_TYPE")]
        MslVertexIndexType = 0x8000041,
        [NativeName("Name", "SPVC_COMPILER_OPTION_GLSL_FORCE_FLATTENED_IO_BLOCKS")]
        GlslForceFlattenedIOBlocks = 0x2000042,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_MULTIVIEW_LAYERED_RENDERING")]
        MslMultiviewLayeredRendering = 0x8000043,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_ARRAYED_SUBPASS_INPUT")]
        MslArrayedSubpassInput = 0x8000044,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_R32UI_LINEAR_TEXTURE_ALIGNMENT")]
        MslR32uiLinearTextureAlignment = 0x8000045,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_R32UI_ALIGNMENT_CONSTANT_ID")]
        MslR32uiAlignmentConstantID = 0x8000046,
        [NativeName("Name", "SPVC_COMPILER_OPTION_HLSL_FLATTEN_MATRIX_VERTEX_INPUT_SEMANTICS")]
        HlslFlattenMatrixVertexInputSemantics = 0x4000047,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_IOS_USE_SIMDGROUP_FUNCTIONS")]
        MslIosUseSimdgroupFunctions = 0x8000048,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_EMULATE_SUBGROUPS")]
        MslEmulateSubgroups = 0x8000049,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_FIXED_SUBGROUP_SIZE")]
        MslFixedSubgroupSize = 0x800004A,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_FORCE_SAMPLE_RATE_SHADING")]
        MslForceSampleRateShading = 0x800004B,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_IOS_SUPPORT_BASE_VERTEX_INSTANCE")]
        MslIosSupportBaseVertexInstance = 0x800004C,
        [NativeName("Name", "SPVC_COMPILER_OPTION_GLSL_OVR_MULTIVIEW_VIEW_COUNT")]
        GlslOvrMultiviewViewCount = 0x200004D,
        [NativeName("Name", "SPVC_COMPILER_OPTION_RELAX_NAN_CHECKS")]
        RelaxNanChecks = 0x100004E,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_RAW_BUFFER_TESE_INPUT")]
        MslRawBufferTeseInput = 0x800004F,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_SHADER_PATCH_INPUT_BUFFER_INDEX")]
        MslShaderPatchInputBufferIndex = 0x8000050,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_MANUAL_HELPER_INVOCATION_UPDATES")]
        MslManualHelperInvocationUpdates = 0x8000051,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_CHECK_DISCARDED_FRAG_STORES")]
        MslCheckDiscardedFragStores = 0x8000052,
        [NativeName("Name", "SPVC_COMPILER_OPTION_GLSL_ENABLE_ROW_MAJOR_LOAD_WORKAROUND")]
        GlslEnableRowMajorLoadWorkaround = 0x2000053,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_ARGUMENT_BUFFERS_TIER")]
        MslArgumentBuffersTier = 0x8000054,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_SAMPLE_DREF_LOD_ARRAY_AS_GRAD")]
        MslSampleDrefLodArrayAsGrad = 0x8000055,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_READWRITE_TEXTURE_FENCES")]
        MslReadwriteTextureFences = 0x8000056,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_REPLACE_RECURSIVE_INPUTS")]
        MslReplaceRecursiveInputs = 0x8000057,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_AGX_MANUAL_CUBE_GRAD_FIXUP")]
        MslAgxManualCubeGradFixup = 0x8000058,
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_FORCE_FRAGMENT_WITH_SIDE_EFFECTS_EXECUTION")]
        MslForceFragmentWithSideEffectsExecution = 0x8000059,
        [NativeName("Name", "SPVC_COMPILER_OPTION_HLSL_USE_ENTRY_POINT_NAME")]
        HlslUseEntryPointName = 0x400005A,
        [NativeName("Name", "SPVC_COMPILER_OPTION_HLSL_PRESERVE_STRUCTURED_BUFFERS")]
        HlslPreserveStructuredBuffers = 0x400005B,
        [NativeName("Name", "SPVC_COMPILER_OPTION_INT_MAX")]
        IntMax = 0x7FFFFFFF,
    }
}
