// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;

namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_PROFILES.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_PROFILES"]/*'/>
public unsafe partial struct D3D12_FEATURE_DATA_VIDEO_DECODE_PROFILES
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_PROFILES.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_PROFILES.NodeIndex"]/*'/>

    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_PROFILES.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_PROFILES.ProfileCount"]/*'/>

    public uint ProfileCount;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_PROFILES.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_PROFILES.pProfiles"]/*'/>

    public Guid* pProfiles;
}
