// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT
{
    public D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAGS SupportedFeatureFlags;
    public D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAGS RequiredFeatureFlags;
    public D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAGS SupportedInterpolationFilters;

    [NativeTypeName("D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS[3][3]")]
    public _SupportedRestorationParams_e__FixedBuffer SupportedRestorationParams;
    public D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAGS SupportedSegmentationModes;

    [NativeTypeName("D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAGS[4]")]
    public _SupportedTxModes_e__FixedBuffer SupportedTxModes;
    public D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE SegmentationBlockSize;
    public D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES_FLAGS PostEncodeValuesFlags;
    public uint MaxTemporalLayers;
    public uint MaxSpatialLayers;

    [InlineArray(3 * 3)]
    public partial struct _SupportedRestorationParams_e__FixedBuffer
    {
        public D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS e0_0;
    }

    [InlineArray(4)]
    public partial struct _SupportedTxModes_e__FixedBuffer
    {
        public D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAGS e0;
    }
}
