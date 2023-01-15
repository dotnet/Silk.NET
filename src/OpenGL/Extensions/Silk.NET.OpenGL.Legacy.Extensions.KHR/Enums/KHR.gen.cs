// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.KHR
{
    [NativeName("Name", "GLenum")]
    public enum KHR : int
    {
        [NativeName("Name", "GL_MULTIPLY_KHR")]
        MultiplyKhr = 0x9294,
        [NativeName("Name", "GL_SCREEN_KHR")]
        ScreenKhr = 0x9295,
        [NativeName("Name", "GL_OVERLAY_KHR")]
        OverlayKhr = 0x9296,
        [NativeName("Name", "GL_DARKEN_KHR")]
        DarkenKhr = 0x9297,
        [NativeName("Name", "GL_LIGHTEN_KHR")]
        LightenKhr = 0x9298,
        [NativeName("Name", "GL_COLORDODGE_KHR")]
        ColordodgeKhr = 0x9299,
        [NativeName("Name", "GL_COLORBURN_KHR")]
        ColorburnKhr = 0x929A,
        [NativeName("Name", "GL_HARDLIGHT_KHR")]
        HardlightKhr = 0x929B,
        [NativeName("Name", "GL_SOFTLIGHT_KHR")]
        SoftlightKhr = 0x929C,
        [NativeName("Name", "GL_DIFFERENCE_KHR")]
        DifferenceKhr = 0x929E,
        [NativeName("Name", "GL_EXCLUSION_KHR")]
        ExclusionKhr = 0x92A0,
        [NativeName("Name", "GL_HSL_HUE_KHR")]
        HslHueKhr = 0x92AD,
        [NativeName("Name", "GL_HSL_SATURATION_KHR")]
        HslSaturationKhr = 0x92AE,
        [NativeName("Name", "GL_HSL_COLOR_KHR")]
        HslColorKhr = 0x92AF,
        [NativeName("Name", "GL_HSL_LUMINOSITY_KHR")]
        HslLuminosityKhr = 0x92B0,
        [NativeName("Name", "GL_BLEND_ADVANCED_COHERENT_KHR")]
        BlendAdvancedCoherentKhr = 0x9285,
        [NativeName("Name", "GL_CONTEXT_RELEASE_BEHAVIOR")]
        ContextReleaseBehavior = 0x82FB,
        [NativeName("Name", "GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH")]
        ContextReleaseBehaviorFlush = 0x82FC,
        [NativeName("Name", "GL_NONE")]
        None = 0x0,
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
        [System.Obsolete("Deprecated in version ")]
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
        [System.Obsolete("Deprecated in version ")]
        [NativeName("Name", "GL_STACK_OVERFLOW")]
        StackOverflow = 0x503,
        [System.Obsolete("Deprecated in version ")]
        [NativeName("Name", "GL_STACK_UNDERFLOW")]
        StackUnderflow = 0x504,
        [NativeName("Name", "GL_DISPLAY_LIST")]
        DisplayList = 0x82E7,
        [NativeName("Name", "GL_CONTEXT_FLAG_NO_ERROR_BIT_KHR")]
        ContextFlagNoErrorBitKhr = 0x8,
        [NativeName("Name", "GL_MAX_SHADER_COMPILER_THREADS_KHR")]
        MaxShaderCompilerThreadsKhr = 0x91B0,
        [NativeName("Name", "GL_COMPLETION_STATUS_KHR")]
        CompletionStatusKhr = 0x91B1,
        [NativeName("Name", "GL_NO_ERROR")]
        NoError = 0x0,
        [NativeName("Name", "GL_CONTEXT_ROBUST_ACCESS")]
        ContextRobustAccess = 0x90F3,
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
        [NativeName("Name", "GL_SUBGROUP_SIZE_KHR")]
        SubgroupSizeKhr = 0x9532,
        [NativeName("Name", "GL_SUBGROUP_SUPPORTED_STAGES_KHR")]
        SubgroupSupportedStagesKhr = 0x9533,
        [NativeName("Name", "GL_SUBGROUP_SUPPORTED_FEATURES_KHR")]
        SubgroupSupportedFeaturesKhr = 0x9534,
        [NativeName("Name", "GL_SUBGROUP_QUAD_ALL_STAGES_KHR")]
        SubgroupQuadAllStagesKhr = 0x9535,
        [NativeName("Name", "GL_SUBGROUP_FEATURE_BASIC_BIT_KHR")]
        SubgroupFeatureBasicBitKhr = 0x1,
        [NativeName("Name", "GL_SUBGROUP_FEATURE_VOTE_BIT_KHR")]
        SubgroupFeatureVoteBitKhr = 0x2,
        [NativeName("Name", "GL_SUBGROUP_FEATURE_ARITHMETIC_BIT_KHR")]
        SubgroupFeatureArithmeticBitKhr = 0x4,
        [NativeName("Name", "GL_SUBGROUP_FEATURE_BALLOT_BIT_KHR")]
        SubgroupFeatureBallotBitKhr = 0x8,
        [NativeName("Name", "GL_SUBGROUP_FEATURE_SHUFFLE_BIT_KHR")]
        SubgroupFeatureShuffleBitKhr = 0x10,
        [NativeName("Name", "GL_SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT_KHR")]
        SubgroupFeatureShuffleRelativeBitKhr = 0x20,
        [NativeName("Name", "GL_SUBGROUP_FEATURE_CLUSTERED_BIT_KHR")]
        SubgroupFeatureClusteredBitKhr = 0x40,
        [NativeName("Name", "GL_SUBGROUP_FEATURE_QUAD_BIT_KHR")]
        SubgroupFeatureQuadBitKhr = 0x80,
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
    }
}
