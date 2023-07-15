// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC"]/*'/>
public enum D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC
{
    /// <include file='D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC.D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC_I_FRAME"]/*'/>
    D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC_I_FRAME = 0,
    /// <include file='D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC.D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC_P_FRAME"]/*'/>
    D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC_P_FRAME = 1,
    /// <include file='D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC.D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC_B_FRAME"]/*'/>
    D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC_B_FRAME = 2,
    /// <include file='D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC.D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC_IDR_FRAME"]/*'/>
    D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC_IDR_FRAME = 3,
}