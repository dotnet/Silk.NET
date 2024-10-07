// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;

namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_CODEC.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_CODEC"]/*'/>
public partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_CODEC
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_CODEC.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_CODEC.NodeIndex"]/*'/>

    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_CODEC.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_CODEC.Codec"]/*'/>

    public D3D12_VIDEO_ENCODER_CODEC Codec;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_CODEC.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_CODEC.IsSupported"]/*'/>

    public BOOL IsSupported;
}
