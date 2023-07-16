// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT"]/*'/>
public unsafe partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT.NodeIndex"]/*'/>
    public uint NodeIndex;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT.Codec"]/*'/>
    public D3D12_VIDEO_ENCODER_CODEC Codec;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT.InputFormat"]/*'/>
    public DXGI_FORMAT InputFormat;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT.CodecConfiguration"]/*'/>
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION CodecConfiguration;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT.CodecGopSequence"]/*'/>
    public D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE CodecGopSequence;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT.RateControl"]/*'/>
    public D3D12_VIDEO_ENCODER_RATE_CONTROL RateControl;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT.IntraRefresh"]/*'/>
    public D3D12_VIDEO_ENCODER_INTRA_REFRESH_MODE IntraRefresh;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT.SubregionFrameEncoding"]/*'/>
    public D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE SubregionFrameEncoding;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT.ResolutionsListCount"]/*'/>
    public uint ResolutionsListCount;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT.pResolutionList"]/*'/>
    [NativeTypeName("const D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC *")]
    public D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC* pResolutionList;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT.MaxReferenceFramesInDPB"]/*'/>
    public uint MaxReferenceFramesInDPB;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT.ValidationFlags"]/*'/>
    public D3D12_VIDEO_ENCODER_VALIDATION_FLAGS ValidationFlags;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT.SupportFlags"]/*'/>
    public D3D12_VIDEO_ENCODER_SUPPORT_FLAGS SupportFlags;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT.SuggestedProfile"]/*'/>
    public D3D12_VIDEO_ENCODER_PROFILE_DESC SuggestedProfile;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT.SuggestedLevel"]/*'/>
    public D3D12_VIDEO_ENCODER_LEVEL_SETTING SuggestedLevel;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT.pResolutionDependentSupport"]/*'/>
    public D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_LIMITS* pResolutionDependentSupport;
}