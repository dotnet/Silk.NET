// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_H264"]/*'/>
public partial struct D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_H264
{
    /// <include file='D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_H264.MaxL0ReferencesForP"]/*'/>
    public uint MaxL0ReferencesForP;
    /// <include file='D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_H264.MaxL0ReferencesForB"]/*'/>
    public uint MaxL0ReferencesForB;
    /// <include file='D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_H264.MaxL1ReferencesForB"]/*'/>
    public uint MaxL1ReferencesForB;
    /// <include file='D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_H264.MaxLongTermReferences"]/*'/>
    public uint MaxLongTermReferences;
    /// <include file='D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_H264.MaxDPBCapacity"]/*'/>
    public uint MaxDPBCapacity;
}