// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    [NativeName("Name", "GLenum")]
    public enum AMD : int
    {
        [NativeName("Name", "GL_FACTOR_MIN_AMD")]
        FactorMinAmd = 0x901C,
        [NativeName("Name", "GL_FACTOR_MAX_AMD")]
        FactorMaxAmd = 0x901D,
        [NativeName("Name", "GL_MAX_DEBUG_MESSAGE_LENGTH_AMD")]
        MaxDebugMessageLengthAmd = 0x9143,
        [NativeName("Name", "GL_MAX_DEBUG_LOGGED_MESSAGES_AMD")]
        MaxDebugLoggedMessagesAmd = 0x9144,
        [NativeName("Name", "GL_DEBUG_LOGGED_MESSAGES_AMD")]
        DebugLoggedMessagesAmd = 0x9145,
        [NativeName("Name", "GL_DEBUG_SEVERITY_HIGH_AMD")]
        DebugSeverityHighAmd = 0x9146,
        [NativeName("Name", "GL_DEBUG_SEVERITY_MEDIUM_AMD")]
        DebugSeverityMediumAmd = 0x9147,
        [NativeName("Name", "GL_DEBUG_SEVERITY_LOW_AMD")]
        DebugSeverityLowAmd = 0x9148,
        [NativeName("Name", "GL_DEBUG_CATEGORY_API_ERROR_AMD")]
        DebugCategoryApiErrorAmd = 0x9149,
        [NativeName("Name", "GL_DEBUG_CATEGORY_WINDOW_SYSTEM_AMD")]
        DebugCategoryWindowSystemAmd = 0x914A,
        [NativeName("Name", "GL_DEBUG_CATEGORY_DEPRECATION_AMD")]
        DebugCategoryDeprecationAmd = 0x914B,
        [NativeName("Name", "GL_DEBUG_CATEGORY_UNDEFINED_BEHAVIOR_AMD")]
        DebugCategoryUndefinedBehaviorAmd = 0x914C,
        [NativeName("Name", "GL_DEBUG_CATEGORY_PERFORMANCE_AMD")]
        DebugCategoryPerformanceAmd = 0x914D,
        [NativeName("Name", "GL_DEBUG_CATEGORY_SHADER_COMPILER_AMD")]
        DebugCategoryShaderCompilerAmd = 0x914E,
        [NativeName("Name", "GL_DEBUG_CATEGORY_APPLICATION_AMD")]
        DebugCategoryApplicationAmd = 0x914F,
        [NativeName("Name", "GL_DEBUG_CATEGORY_OTHER_AMD")]
        DebugCategoryOtherAmd = 0x9150,
        [NativeName("Name", "GL_DEPTH_CLAMP_NEAR_AMD")]
        DepthClampNearAmd = 0x901E,
        [NativeName("Name", "GL_DEPTH_CLAMP_FAR_AMD")]
        DepthClampFarAmd = 0x901F,
        [NativeName("Name", "GL_RENDERBUFFER_STORAGE_SAMPLES_AMD")]
        RenderbufferStorageSamplesAmd = 0x91B2,
        [NativeName("Name", "GL_MAX_COLOR_FRAMEBUFFER_SAMPLES_AMD")]
        MaxColorFramebufferSamplesAmd = 0x91B3,
        [NativeName("Name", "GL_MAX_COLOR_FRAMEBUFFER_STORAGE_SAMPLES_AMD")]
        MaxColorFramebufferStorageSamplesAmd = 0x91B4,
        [NativeName("Name", "GL_MAX_DEPTH_STENCIL_FRAMEBUFFER_SAMPLES_AMD")]
        MaxDepthStencilFramebufferSamplesAmd = 0x91B5,
        [NativeName("Name", "GL_NUM_SUPPORTED_MULTISAMPLE_MODES_AMD")]
        NumSupportedMultisampleModesAmd = 0x91B6,
        [NativeName("Name", "GL_SUPPORTED_MULTISAMPLE_MODES_AMD")]
        SupportedMultisampleModesAmd = 0x91B7,
        [NativeName("Name", "GL_SUBSAMPLE_DISTANCE_AMD")]
        SubsampleDistanceAmd = 0x883F,
        [NativeName("Name", "GL_PIXELS_PER_SAMPLE_PATTERN_X_AMD")]
        PixelsPerSamplePatternXAmd = 0x91AE,
        [NativeName("Name", "GL_PIXELS_PER_SAMPLE_PATTERN_Y_AMD")]
        PixelsPerSamplePatternYAmd = 0x91AF,
        [NativeName("Name", "GL_ALL_PIXELS_AMD")]
        AllPixelsAmd = unchecked((int)0xFFFFFFFF),
        [NativeName("Name", "GL_FLOAT16_NV")]
        Float16NV = 0x8FF8,
        [NativeName("Name", "GL_FLOAT16_VEC2_NV")]
        Float16Vec2NV = 0x8FF9,
        [NativeName("Name", "GL_FLOAT16_VEC3_NV")]
        Float16Vec3NV = 0x8FFA,
        [NativeName("Name", "GL_FLOAT16_VEC4_NV")]
        Float16Vec4NV = 0x8FFB,
        [NativeName("Name", "GL_FLOAT16_MAT2_AMD")]
        Float16Mat2Amd = 0x91C5,
        [NativeName("Name", "GL_FLOAT16_MAT3_AMD")]
        Float16Mat3Amd = 0x91C6,
        [NativeName("Name", "GL_FLOAT16_MAT4_AMD")]
        Float16Mat4Amd = 0x91C7,
        [NativeName("Name", "GL_FLOAT16_MAT2x3_AMD")]
        Float16Mat2x3Amd = 0x91C8,
        [NativeName("Name", "GL_FLOAT16_MAT2x4_AMD")]
        Float16Mat2x4Amd = 0x91C9,
        [NativeName("Name", "GL_FLOAT16_MAT3x2_AMD")]
        Float16Mat3x2Amd = 0x91CA,
        [NativeName("Name", "GL_FLOAT16_MAT3x4_AMD")]
        Float16Mat3x4Amd = 0x91CB,
        [NativeName("Name", "GL_FLOAT16_MAT4x2_AMD")]
        Float16Mat4x2Amd = 0x91CC,
        [NativeName("Name", "GL_FLOAT16_MAT4x3_AMD")]
        Float16Mat4x3Amd = 0x91CD,
        [NativeName("Name", "GL_INT64_NV")]
        Int64NV = 0x140E,
        [NativeName("Name", "GL_UNSIGNED_INT64_NV")]
        UnsignedInt64NV = 0x140F,
        [NativeName("Name", "GL_INT8_NV")]
        Int8NV = 0x8FE0,
        [NativeName("Name", "GL_INT8_VEC2_NV")]
        Int8Vec2NV = 0x8FE1,
        [NativeName("Name", "GL_INT8_VEC3_NV")]
        Int8Vec3NV = 0x8FE2,
        [NativeName("Name", "GL_INT8_VEC4_NV")]
        Int8Vec4NV = 0x8FE3,
        [NativeName("Name", "GL_INT16_NV")]
        Int16NV = 0x8FE4,
        [NativeName("Name", "GL_INT16_VEC2_NV")]
        Int16Vec2NV = 0x8FE5,
        [NativeName("Name", "GL_INT16_VEC3_NV")]
        Int16Vec3NV = 0x8FE6,
        [NativeName("Name", "GL_INT16_VEC4_NV")]
        Int16Vec4NV = 0x8FE7,
        [NativeName("Name", "GL_INT64_VEC2_NV")]
        Int64Vec2NV = 0x8FE9,
        [NativeName("Name", "GL_INT64_VEC3_NV")]
        Int64Vec3NV = 0x8FEA,
        [NativeName("Name", "GL_INT64_VEC4_NV")]
        Int64Vec4NV = 0x8FEB,
        [NativeName("Name", "GL_UNSIGNED_INT8_NV")]
        UnsignedInt8NV = 0x8FEC,
        [NativeName("Name", "GL_UNSIGNED_INT8_VEC2_NV")]
        UnsignedInt8Vec2NV = 0x8FED,
        [NativeName("Name", "GL_UNSIGNED_INT8_VEC3_NV")]
        UnsignedInt8Vec3NV = 0x8FEE,
        [NativeName("Name", "GL_UNSIGNED_INT8_VEC4_NV")]
        UnsignedInt8Vec4NV = 0x8FEF,
        [NativeName("Name", "GL_UNSIGNED_INT16_NV")]
        UnsignedInt16NV = 0x8FF0,
        [NativeName("Name", "GL_UNSIGNED_INT16_VEC2_NV")]
        UnsignedInt16Vec2NV = 0x8FF1,
        [NativeName("Name", "GL_UNSIGNED_INT16_VEC3_NV")]
        UnsignedInt16Vec3NV = 0x8FF2,
        [NativeName("Name", "GL_UNSIGNED_INT16_VEC4_NV")]
        UnsignedInt16Vec4NV = 0x8FF3,
        [NativeName("Name", "GL_UNSIGNED_INT64_VEC2_NV")]
        UnsignedInt64Vec2NV = 0x8FF5,
        [NativeName("Name", "GL_UNSIGNED_INT64_VEC3_NV")]
        UnsignedInt64Vec3NV = 0x8FF6,
        [NativeName("Name", "GL_UNSIGNED_INT64_VEC4_NV")]
        UnsignedInt64Vec4NV = 0x8FF7,
        [NativeName("Name", "GL_VERTEX_ELEMENT_SWIZZLE_AMD")]
        VertexElementSwizzleAmd = 0x91A4,
        [NativeName("Name", "GL_VERTEX_ID_SWIZZLE_AMD")]
        VertexIDSwizzleAmd = 0x91A5,
        [NativeName("Name", "GL_RED")]
        Red = 0x1903,
        [NativeName("Name", "GL_GREEN")]
        Green = 0x1904,
        [NativeName("Name", "GL_BLUE")]
        Blue = 0x1905,
        [NativeName("Name", "GL_ALPHA")]
        Alpha = 0x1906,
        [NativeName("Name", "GL_RG8UI")]
        RG8ui = 0x8238,
        [NativeName("Name", "GL_RG16UI")]
        RG16ui = 0x823A,
        [NativeName("Name", "GL_RGBA8UI")]
        Rgba8ui = 0x8D7C,
        [NativeName("Name", "GL_DATA_BUFFER_AMD")]
        DataBufferAmd = 0x9151,
        [NativeName("Name", "GL_PERFORMANCE_MONITOR_AMD")]
        PerformanceMonitorAmd = 0x9152,
        [NativeName("Name", "GL_QUERY_OBJECT_AMD")]
        QueryObjectAmd = 0x9153,
        [NativeName("Name", "GL_VERTEX_ARRAY_OBJECT_AMD")]
        VertexArrayObjectAmd = 0x9154,
        [NativeName("Name", "GL_SAMPLER_OBJECT_AMD")]
        SamplerObjectAmd = 0x9155,
        [NativeName("Name", "GL_OCCLUSION_QUERY_EVENT_MASK_AMD")]
        OcclusionQueryEventMaskAmd = 0x874F,
        [NativeName("Name", "GL_QUERY_DEPTH_PASS_EVENT_BIT_AMD")]
        QueryDepthPassEventBitAmd = 0x1,
        [NativeName("Name", "GL_QUERY_DEPTH_FAIL_EVENT_BIT_AMD")]
        QueryDepthFailEventBitAmd = 0x2,
        [NativeName("Name", "GL_QUERY_STENCIL_FAIL_EVENT_BIT_AMD")]
        QueryStencilFailEventBitAmd = 0x4,
        [NativeName("Name", "GL_QUERY_DEPTH_BOUNDS_FAIL_EVENT_BIT_AMD")]
        QueryDepthBoundsFailEventBitAmd = 0x8,
        [NativeName("Name", "GL_QUERY_ALL_EVENT_BITS_AMD")]
        QueryAllEventBitsAmd = unchecked((int)0xFFFFFFFF),
        [NativeName("Name", "GL_COUNTER_TYPE_AMD")]
        CounterTypeAmd = 0x8BC0,
        [NativeName("Name", "GL_COUNTER_RANGE_AMD")]
        CounterRangeAmd = 0x8BC1,
        [NativeName("Name", "GL_UNSIGNED_INT64_AMD")]
        UnsignedInt64Amd = 0x8BC2,
        [NativeName("Name", "GL_PERCENTAGE_AMD")]
        PercentageAmd = 0x8BC3,
        [NativeName("Name", "GL_PERFMON_RESULT_AVAILABLE_AMD")]
        PerfmonResultAvailableAmd = 0x8BC4,
        [NativeName("Name", "GL_PERFMON_RESULT_SIZE_AMD")]
        PerfmonResultSizeAmd = 0x8BC5,
        [NativeName("Name", "GL_PERFMON_RESULT_AMD")]
        PerfmonResultAmd = 0x8BC6,
        [NativeName("Name", "GL_EXTERNAL_VIRTUAL_MEMORY_BUFFER_AMD")]
        ExternalVirtualMemoryBufferAmd = 0x9160,
        [NativeName("Name", "GL_QUERY_BUFFER_AMD")]
        QueryBufferAmd = 0x9192,
        [NativeName("Name", "GL_QUERY_BUFFER_BINDING_AMD")]
        QueryBufferBindingAmd = 0x9193,
        [NativeName("Name", "GL_QUERY_RESULT_NO_WAIT_AMD")]
        QueryResultNoWaitAmd = 0x9194,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_SEAMLESS")]
        TextureCubeMapSeamless = 0x884F,
        [NativeName("Name", "GL_VIRTUAL_PAGE_SIZE_X_AMD")]
        VirtualPageSizeXAmd = 0x9195,
        [NativeName("Name", "GL_VIRTUAL_PAGE_SIZE_Y_AMD")]
        VirtualPageSizeYAmd = 0x9196,
        [NativeName("Name", "GL_VIRTUAL_PAGE_SIZE_Z_AMD")]
        VirtualPageSizeZAmd = 0x9197,
        [NativeName("Name", "GL_MAX_SPARSE_TEXTURE_SIZE_AMD")]
        MaxSparseTextureSizeAmd = 0x9198,
        [NativeName("Name", "GL_MAX_SPARSE_3D_TEXTURE_SIZE_AMD")]
        MaxSparse3DTextureSizeAmd = 0x9199,
        [NativeName("Name", "GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS")]
        MaxSparseArrayTextureLayers = 0x919A,
        [NativeName("Name", "GL_MIN_SPARSE_LEVEL_AMD")]
        MinSparseLevelAmd = 0x919B,
        [NativeName("Name", "GL_MIN_LOD_WARNING_AMD")]
        MinLodWarningAmd = 0x919C,
        [NativeName("Name", "GL_TEXTURE_STORAGE_SPARSE_BIT_AMD")]
        TextureStorageSparseBitAmd = 0x1,
        [NativeName("Name", "GL_SET_AMD")]
        SetAmd = 0x874A,
        [NativeName("Name", "GL_REPLACE_VALUE_AMD")]
        ReplaceValueAmd = 0x874B,
        [NativeName("Name", "GL_STENCIL_OP_VALUE_AMD")]
        StencilOpValueAmd = 0x874C,
        [NativeName("Name", "GL_STENCIL_BACK_OP_VALUE_AMD")]
        StencilBackOpValueAmd = 0x874D,
        [NativeName("Name", "GL_STREAM_RASTERIZATION_AMD")]
        StreamRasterizationAmd = 0x91A0,
        [NativeName("Name", "GL_SAMPLER_BUFFER_AMD")]
        SamplerBufferAmd = 0x9001,
        [NativeName("Name", "GL_INT_SAMPLER_BUFFER_AMD")]
        IntSamplerBufferAmd = 0x9002,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_BUFFER_AMD")]
        UnsignedIntSamplerBufferAmd = 0x9003,
        [NativeName("Name", "GL_TESSELLATION_MODE_AMD")]
        TessellationModeAmd = 0x9004,
        [NativeName("Name", "GL_TESSELLATION_FACTOR_AMD")]
        TessellationFactorAmd = 0x9005,
        [NativeName("Name", "GL_DISCRETE_AMD")]
        DiscreteAmd = 0x9006,
        [NativeName("Name", "GL_CONTINUOUS_AMD")]
        ContinuousAmd = 0x9007,
    }
}
