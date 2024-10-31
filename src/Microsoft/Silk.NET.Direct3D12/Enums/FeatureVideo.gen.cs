// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_FEATURE_VIDEO")]
    public enum FeatureVideo : int
    {
        [Obsolete("Deprecated in favour of \"DecodeSupport\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_DECODE_SUPPORT")]
        FeatureVideoDecodeSupport = 0x0,
        [Obsolete("Deprecated in favour of \"DecodeProfiles\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_DECODE_PROFILES")]
        FeatureVideoDecodeProfiles = 0x1,
        [Obsolete("Deprecated in favour of \"DecodeFormats\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_DECODE_FORMATS")]
        FeatureVideoDecodeFormats = 0x2,
        [Obsolete("Deprecated in favour of \"DecodeConversionSupport\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_DECODE_CONVERSION_SUPPORT")]
        FeatureVideoDecodeConversionSupport = 0x3,
        [Obsolete("Deprecated in favour of \"ProcessSupport\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_PROCESS_SUPPORT")]
        FeatureVideoProcessSupport = 0x5,
        [Obsolete("Deprecated in favour of \"ProcessMaxInputStreams\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_PROCESS_MAX_INPUT_STREAMS")]
        FeatureVideoProcessMaxInputStreams = 0x6,
        [Obsolete("Deprecated in favour of \"ProcessReferenceInfo\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_PROCESS_REFERENCE_INFO")]
        FeatureVideoProcessReferenceInfo = 0x7,
        [Obsolete("Deprecated in favour of \"DecoderHeapSize\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_DECODER_HEAP_SIZE")]
        FeatureVideoDecoderHeapSize = 0x8,
        [Obsolete("Deprecated in favour of \"ProcessorSize\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_PROCESSOR_SIZE")]
        FeatureVideoProcessorSize = 0x9,
        [Obsolete("Deprecated in favour of \"DecodeProfileCount\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_DECODE_PROFILE_COUNT")]
        FeatureVideoDecodeProfileCount = 0xA,
        [Obsolete("Deprecated in favour of \"DecodeFormatCount\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_DECODE_FORMAT_COUNT")]
        FeatureVideoDecodeFormatCount = 0xB,
        [Obsolete("Deprecated in favour of \"Architecture\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_ARCHITECTURE")]
        FeatureVideoArchitecture = 0x11,
        [Obsolete("Deprecated in favour of \"DecodeHistogram\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_DECODE_HISTOGRAM")]
        FeatureVideoDecodeHistogram = 0x12,
        [Obsolete("Deprecated in favour of \"FeatureAreaSupport\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_FEATURE_AREA_SUPPORT")]
        FeatureVideoFeatureAreaSupport = 0x13,
        [Obsolete("Deprecated in favour of \"MotionEstimator\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_MOTION_ESTIMATOR")]
        FeatureVideoMotionEstimator = 0x14,
        [Obsolete("Deprecated in favour of \"MotionEstimatorSize\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_MOTION_ESTIMATOR_SIZE")]
        FeatureVideoMotionEstimatorSize = 0x15,
        [Obsolete("Deprecated in favour of \"ExtensionCommandCount\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_EXTENSION_COMMAND_COUNT")]
        FeatureVideoExtensionCommandCount = 0x16,
        [Obsolete("Deprecated in favour of \"ExtensionCommands\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_EXTENSION_COMMANDS")]
        FeatureVideoExtensionCommands = 0x17,
        [Obsolete("Deprecated in favour of \"ExtensionCommandParameterCount\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_EXTENSION_COMMAND_PARAMETER_COUNT")]
        FeatureVideoExtensionCommandParameterCount = 0x18,
        [Obsolete("Deprecated in favour of \"ExtensionCommandParameters\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_EXTENSION_COMMAND_PARAMETERS")]
        FeatureVideoExtensionCommandParameters = 0x19,
        [Obsolete("Deprecated in favour of \"ExtensionCommandSupport\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_EXTENSION_COMMAND_SUPPORT")]
        FeatureVideoExtensionCommandSupport = 0x1A,
        [Obsolete("Deprecated in favour of \"ExtensionCommandSize\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_EXTENSION_COMMAND_SIZE")]
        FeatureVideoExtensionCommandSize = 0x1B,
        [Obsolete("Deprecated in favour of \"DecodeProtectedResources\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_DECODE_PROTECTED_RESOURCES")]
        FeatureVideoDecodeProtectedResources = 0x1C,
        [Obsolete("Deprecated in favour of \"ProcessProtectedResources\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_PROCESS_PROTECTED_RESOURCES")]
        FeatureVideoProcessProtectedResources = 0x1D,
        [Obsolete("Deprecated in favour of \"MotionEstimatorProtectedResources\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_MOTION_ESTIMATOR_PROTECTED_RESOURCES")]
        FeatureVideoMotionEstimatorProtectedResources = 0x1E,
        [Obsolete("Deprecated in favour of \"DecoderHeapSize1\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_DECODER_HEAP_SIZE1")]
        FeatureVideoDecoderHeapSize1 = 0x1F,
        [Obsolete("Deprecated in favour of \"ProcessorSize1\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_PROCESSOR_SIZE1")]
        FeatureVideoProcessorSize1 = 0x20,
        [Obsolete("Deprecated in favour of \"EncoderCodec\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_ENCODER_CODEC")]
        FeatureVideoEncoderCodec = 0x21,
        [Obsolete("Deprecated in favour of \"EncoderProfileLevel\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_ENCODER_PROFILE_LEVEL")]
        FeatureVideoEncoderProfileLevel = 0x22,
        [Obsolete("Deprecated in favour of \"EncoderOutputResolutionRatiosCount\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_ENCODER_OUTPUT_RESOLUTION_RATIOS_COUNT")]
        FeatureVideoEncoderOutputResolutionRatiosCount = 0x23,
        [Obsolete("Deprecated in favour of \"EncoderOutputResolution\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_ENCODER_OUTPUT_RESOLUTION")]
        FeatureVideoEncoderOutputResolution = 0x24,
        [Obsolete("Deprecated in favour of \"EncoderInputFormat\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_ENCODER_INPUT_FORMAT")]
        FeatureVideoEncoderInputFormat = 0x25,
        [Obsolete("Deprecated in favour of \"EncoderRateControlMode\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_ENCODER_RATE_CONTROL_MODE")]
        FeatureVideoEncoderRateControlMode = 0x26,
        [Obsolete("Deprecated in favour of \"EncoderIntraRefreshMode\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_ENCODER_INTRA_REFRESH_MODE")]
        FeatureVideoEncoderIntraRefreshMode = 0x27,
        [Obsolete("Deprecated in favour of \"EncoderFrameSubregionLayoutMode\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE")]
        FeatureVideoEncoderFrameSubregionLayoutMode = 0x28,
        [Obsolete("Deprecated in favour of \"EncoderHeapSize\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_ENCODER_HEAP_SIZE")]
        FeatureVideoEncoderHeapSize = 0x29,
        [Obsolete("Deprecated in favour of \"EncoderCodecConfigurationSupport\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT")]
        FeatureVideoEncoderCodecConfigurationSupport = 0x2A,
        [Obsolete("Deprecated in favour of \"EncoderSupport\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_ENCODER_SUPPORT")]
        FeatureVideoEncoderSupport = 0x2B,
        [Obsolete("Deprecated in favour of \"EncoderCodecPictureControlSupport\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT")]
        FeatureVideoEncoderCodecPictureControlSupport = 0x2C,
        [Obsolete("Deprecated in favour of \"EncoderResourceRequirements\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_ENCODER_RESOURCE_REQUIREMENTS")]
        FeatureVideoEncoderResourceRequirements = 0x2D,
        [Obsolete("Deprecated in favour of \"EncoderFrameSubregionLayoutConfig\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_CONFIG")]
        FeatureVideoEncoderFrameSubregionLayoutConfig = 0x2E,
        [Obsolete("Deprecated in favour of \"EncoderSupport1\"")]
        [NativeName("Name", "D3D12_FEATURE_VIDEO_ENCODER_SUPPORT1")]
        FeatureVideoEncoderSupport1 = 0x2F,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_DECODE_SUPPORT")]
        DecodeSupport = 0x0,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_DECODE_PROFILES")]
        DecodeProfiles = 0x1,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_DECODE_FORMATS")]
        DecodeFormats = 0x2,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_DECODE_CONVERSION_SUPPORT")]
        DecodeConversionSupport = 0x3,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_PROCESS_SUPPORT")]
        ProcessSupport = 0x5,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_PROCESS_MAX_INPUT_STREAMS")]
        ProcessMaxInputStreams = 0x6,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_PROCESS_REFERENCE_INFO")]
        ProcessReferenceInfo = 0x7,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_DECODER_HEAP_SIZE")]
        DecoderHeapSize = 0x8,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_PROCESSOR_SIZE")]
        ProcessorSize = 0x9,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_DECODE_PROFILE_COUNT")]
        DecodeProfileCount = 0xA,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_DECODE_FORMAT_COUNT")]
        DecodeFormatCount = 0xB,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_ARCHITECTURE")]
        Architecture = 0x11,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_DECODE_HISTOGRAM")]
        DecodeHistogram = 0x12,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_FEATURE_AREA_SUPPORT")]
        FeatureAreaSupport = 0x13,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_MOTION_ESTIMATOR")]
        MotionEstimator = 0x14,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_MOTION_ESTIMATOR_SIZE")]
        MotionEstimatorSize = 0x15,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_EXTENSION_COMMAND_COUNT")]
        ExtensionCommandCount = 0x16,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_EXTENSION_COMMANDS")]
        ExtensionCommands = 0x17,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_EXTENSION_COMMAND_PARAMETER_COUNT")]
        ExtensionCommandParameterCount = 0x18,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_EXTENSION_COMMAND_PARAMETERS")]
        ExtensionCommandParameters = 0x19,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_EXTENSION_COMMAND_SUPPORT")]
        ExtensionCommandSupport = 0x1A,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_EXTENSION_COMMAND_SIZE")]
        ExtensionCommandSize = 0x1B,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_DECODE_PROTECTED_RESOURCES")]
        DecodeProtectedResources = 0x1C,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_PROCESS_PROTECTED_RESOURCES")]
        ProcessProtectedResources = 0x1D,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_MOTION_ESTIMATOR_PROTECTED_RESOURCES")]
        MotionEstimatorProtectedResources = 0x1E,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_DECODER_HEAP_SIZE1")]
        DecoderHeapSize1 = 0x1F,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_PROCESSOR_SIZE1")]
        ProcessorSize1 = 0x20,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_ENCODER_CODEC")]
        EncoderCodec = 0x21,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_ENCODER_PROFILE_LEVEL")]
        EncoderProfileLevel = 0x22,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_ENCODER_OUTPUT_RESOLUTION_RATIOS_COUNT")]
        EncoderOutputResolutionRatiosCount = 0x23,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_ENCODER_OUTPUT_RESOLUTION")]
        EncoderOutputResolution = 0x24,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_ENCODER_INPUT_FORMAT")]
        EncoderInputFormat = 0x25,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_ENCODER_RATE_CONTROL_MODE")]
        EncoderRateControlMode = 0x26,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_ENCODER_INTRA_REFRESH_MODE")]
        EncoderIntraRefreshMode = 0x27,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE")]
        EncoderFrameSubregionLayoutMode = 0x28,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_ENCODER_HEAP_SIZE")]
        EncoderHeapSize = 0x29,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT")]
        EncoderCodecConfigurationSupport = 0x2A,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_ENCODER_SUPPORT")]
        EncoderSupport = 0x2B,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT")]
        EncoderCodecPictureControlSupport = 0x2C,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_ENCODER_RESOURCE_REQUIREMENTS")]
        EncoderResourceRequirements = 0x2D,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_CONFIG")]
        EncoderFrameSubregionLayoutConfig = 0x2E,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_ENCODER_SUPPORT1")]
        EncoderSupport1 = 0x2F,
    }
}
