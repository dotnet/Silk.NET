// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_H264"]/*'/>
public partial struct D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_H264
{
    /// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_H264.GOPLength"]/*'/>
    public uint GOPLength;
    /// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_H264.PPicturePeriod"]/*'/>
    public uint PPicturePeriod;
    /// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_H264.pic_order_cnt_type"]/*'/>
    [NativeTypeName("UCHAR")]
    public byte pic_order_cnt_type;
    /// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_H264.log2_max_frame_num_minus4"]/*'/>
    [NativeTypeName("UCHAR")]
    public byte log2_max_frame_num_minus4;
    /// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_H264.log2_max_pic_order_cnt_lsb_minus4"]/*'/>
    [NativeTypeName("UCHAR")]
    public byte log2_max_pic_order_cnt_lsb_minus4;
}