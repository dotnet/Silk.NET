// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264"]/*'/>
public partial struct D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264
{
    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264.SupportFlags"]/*'/>
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAGS SupportFlags;
    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264.DisableDeblockingFilterSupportedModes"]/*'/>
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_FLAGS DisableDeblockingFilterSupportedModes;
}