// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_FEATURE_VIDEO")]
    public enum FeatureVideo
    {
        [NativeName("Name", "D3D12_FEATURE_VIDEO_DECODE_SUPPORT")]
        FeatureVideoDecodeSupport = 0x0,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_DECODE_PROFILES")]
        FeatureVideoDecodeProfiles = 0x1,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_DECODE_FORMATS")]
        FeatureVideoDecodeFormats = 0x2,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_DECODE_CONVERSION_SUPPORT")]
        FeatureVideoDecodeConversionSupport = 0x3,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_PROCESS_SUPPORT")]
        FeatureVideoProcessSupport = 0x5,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_PROCESS_MAX_INPUT_STREAMS")]
        FeatureVideoProcessMaxInputStreams = 0x6,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_PROCESS_REFERENCE_INFO")]
        FeatureVideoProcessReferenceInfo = 0x7,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_DECODER_HEAP_SIZE")]
        FeatureVideoDecoderHeapSize = 0x8,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_PROCESSOR_SIZE")]
        FeatureVideoProcessorSize = 0x9,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_DECODE_PROFILE_COUNT")]
        FeatureVideoDecodeProfileCount = 0xA,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_DECODE_FORMAT_COUNT")]
        FeatureVideoDecodeFormatCount = 0xB,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_ARCHITECTURE")]
        FeatureVideoArchitecture = 0x11,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_DECODE_HISTOGRAM")]
        FeatureVideoDecodeHistogram = 0x12,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_FEATURE_AREA_SUPPORT")]
        FeatureVideoFeatureAreaSupport = 0x13,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_MOTION_ESTIMATOR")]
        FeatureVideoMotionEstimator = 0x14,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_MOTION_ESTIMATOR_SIZE")]
        FeatureVideoMotionEstimatorSize = 0x15,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_EXTENSION_COMMAND_COUNT")]
        FeatureVideoExtensionCommandCount = 0x16,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_EXTENSION_COMMANDS")]
        FeatureVideoExtensionCommands = 0x17,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_EXTENSION_COMMAND_PARAMETER_COUNT")]
        FeatureVideoExtensionCommandParameterCount = 0x18,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_EXTENSION_COMMAND_PARAMETERS")]
        FeatureVideoExtensionCommandParameters = 0x19,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_EXTENSION_COMMAND_SUPPORT")]
        FeatureVideoExtensionCommandSupport = 0x1A,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_EXTENSION_COMMAND_SIZE")]
        FeatureVideoExtensionCommandSize = 0x1B,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_DECODE_PROTECTED_RESOURCES")]
        FeatureVideoDecodeProtectedResources = 0x1C,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_PROCESS_PROTECTED_RESOURCES")]
        FeatureVideoProcessProtectedResources = 0x1D,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_MOTION_ESTIMATOR_PROTECTED_RESOURCES")]
        FeatureVideoMotionEstimatorProtectedResources = 0x1E,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_DECODER_HEAP_SIZE1")]
        FeatureVideoDecoderHeapSize1 = 0x1F,
        [NativeName("Name", "D3D12_FEATURE_VIDEO_PROCESSOR_SIZE1")]
        FeatureVideoProcessorSize1 = 0x20,
    }
}
