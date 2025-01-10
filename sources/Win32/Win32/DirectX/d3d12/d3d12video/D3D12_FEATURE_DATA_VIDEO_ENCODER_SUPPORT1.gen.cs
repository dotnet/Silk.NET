// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1
{
    public uint NodeIndex;
    public D3D12_VIDEO_ENCODER_CODEC Codec;
    public DXGI_FORMAT InputFormat;
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION CodecConfiguration;
    public D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE CodecGopSequence;
    public D3D12_VIDEO_ENCODER_RATE_CONTROL RateControl;
    public D3D12_VIDEO_ENCODER_INTRA_REFRESH_MODE IntraRefresh;
    public D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE SubregionFrameEncoding;
    public uint ResolutionsListCount;

    [NativeTypeName("const D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC *")]
    public D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC* pResolutionList;
    public uint MaxReferenceFramesInDPB;
    public D3D12_VIDEO_ENCODER_VALIDATION_FLAGS ValidationFlags;
    public D3D12_VIDEO_ENCODER_SUPPORT_FLAGS SupportFlags;
    public D3D12_VIDEO_ENCODER_PROFILE_DESC SuggestedProfile;
    public D3D12_VIDEO_ENCODER_LEVEL_SETTING SuggestedLevel;
    public D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_LIMITS* pResolutionDependentSupport;
    public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA SubregionFrameEncodingData;
    public uint MaxQualityVsSpeed;
}
