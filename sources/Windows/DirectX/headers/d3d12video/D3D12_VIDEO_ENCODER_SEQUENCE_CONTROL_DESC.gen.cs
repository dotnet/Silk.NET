// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC"]/*'/>
public partial struct D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC
{
    /// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC.Flags"]/*'/>
    public D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAGS Flags;
    /// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC.IntraRefreshConfig"]/*'/>
    public D3D12_VIDEO_ENCODER_INTRA_REFRESH IntraRefreshConfig;
    /// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC.RateControl"]/*'/>
    public D3D12_VIDEO_ENCODER_RATE_CONTROL RateControl;
    /// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC.PictureTargetResolution"]/*'/>
    public D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC PictureTargetResolution;
    /// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC.SelectedLayoutMode"]/*'/>
    public D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE SelectedLayoutMode;
    /// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC.FrameSubregionsLayoutData"]/*'/>
    public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA FrameSubregionsLayoutData;
    /// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC.CodecGopSequence"]/*'/>
    public D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE CodecGopSequence;
}