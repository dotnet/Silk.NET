// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using Silk.NET.Windows;

namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_PROFILE_LEVEL.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_PROFILE_LEVEL"]/*' />
public partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_PROFILE_LEVEL
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_PROFILE_LEVEL.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_PROFILE_LEVEL.NodeIndex"]/*' />
    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_PROFILE_LEVEL.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_PROFILE_LEVEL.Codec"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC Codec;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_PROFILE_LEVEL.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_PROFILE_LEVEL.Profile"]/*' />
    public D3D12_VIDEO_ENCODER_PROFILE_DESC Profile;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_PROFILE_LEVEL.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_PROFILE_LEVEL.IsSupported"]/*' />
    public BOOL IsSupported;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_PROFILE_LEVEL.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_PROFILE_LEVEL.MinSupportedLevel"]/*' />
    public D3D12_VIDEO_ENCODER_LEVEL_SETTING MinSupportedLevel;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_PROFILE_LEVEL.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_PROFILE_LEVEL.MaxSupportedLevel"]/*' />
    public D3D12_VIDEO_ENCODER_LEVEL_SETTING MaxSupportedLevel;
}
