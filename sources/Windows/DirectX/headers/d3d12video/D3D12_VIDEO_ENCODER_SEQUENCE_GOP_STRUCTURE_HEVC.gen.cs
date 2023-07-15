// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_HEVC"]/*'/>
public partial struct D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_HEVC
{
    /// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_HEVC.GOPLength"]/*'/>
    public uint GOPLength;
    /// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_HEVC.PPicturePeriod"]/*'/>
    public uint PPicturePeriod;
    /// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_HEVC.log2_max_pic_order_cnt_lsb_minus4"]/*'/>
    [NativeTypeName("UCHAR")]
    public byte log2_max_pic_order_cnt_lsb_minus4;
}