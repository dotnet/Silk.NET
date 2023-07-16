// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;
/// <include file='D3D11_VIDEO_USAGE.xml' path='doc/member[@name="D3D11_VIDEO_USAGE"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum D3D11_VIDEO_USAGE
{
    /// <include file='D3D11_VIDEO_USAGE.xml' path='doc/member[@name="D3D11_VIDEO_USAGE.D3D11_VIDEO_USAGE_PLAYBACK_NORMAL"]/*'/>
    D3D11_VIDEO_USAGE_PLAYBACK_NORMAL = 0,
    /// <include file='D3D11_VIDEO_USAGE.xml' path='doc/member[@name="D3D11_VIDEO_USAGE.D3D11_VIDEO_USAGE_OPTIMAL_SPEED"]/*'/>
    D3D11_VIDEO_USAGE_OPTIMAL_SPEED = 1,
    /// <include file='D3D11_VIDEO_USAGE.xml' path='doc/member[@name="D3D11_VIDEO_USAGE.D3D11_VIDEO_USAGE_OPTIMAL_QUALITY"]/*'/>
    D3D11_VIDEO_USAGE_OPTIMAL_QUALITY = 2,
}