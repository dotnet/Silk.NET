// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC"]/*' />
public partial struct D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC
{
    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC.SupportFlags"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAGS SupportFlags;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC.MinLumaCodingUnitSize"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE MinLumaCodingUnitSize;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC.MaxLumaCodingUnitSize"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE MaxLumaCodingUnitSize;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC.MinLumaTransformUnitSize"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE MinLumaTransformUnitSize;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC.MaxLumaTransformUnitSize"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE MaxLumaTransformUnitSize;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC.max_transform_hierarchy_depth_inter"]/*' />
    [NativeTypeName("UCHAR")]
    public byte max_transform_hierarchy_depth_inter;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC.max_transform_hierarchy_depth_intra"]/*' />
    [NativeTypeName("UCHAR")]
    public byte max_transform_hierarchy_depth_intra;
}
