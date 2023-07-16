// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;
/// <include file='D3D11_VIDEO_DECODER_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CAPS"]/*'/>
[Flags]
[SupportedOSPlatform("windows10.0")]
public enum D3D11_VIDEO_DECODER_CAPS
{
    /// <include file='D3D11_VIDEO_DECODER_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CAPS.D3D11_VIDEO_DECODER_CAPS_DOWNSAMPLE"]/*'/>
    D3D11_VIDEO_DECODER_CAPS_DOWNSAMPLE = 0x1,
    /// <include file='D3D11_VIDEO_DECODER_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CAPS.D3D11_VIDEO_DECODER_CAPS_NON_REAL_TIME"]/*'/>
    D3D11_VIDEO_DECODER_CAPS_NON_REAL_TIME = 0x2,
    /// <include file='D3D11_VIDEO_DECODER_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CAPS.D3D11_VIDEO_DECODER_CAPS_DOWNSAMPLE_DYNAMIC"]/*'/>
    D3D11_VIDEO_DECODER_CAPS_DOWNSAMPLE_DYNAMIC = 0x4,
    /// <include file='D3D11_VIDEO_DECODER_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CAPS.D3D11_VIDEO_DECODER_CAPS_DOWNSAMPLE_REQUIRED"]/*'/>
    D3D11_VIDEO_DECODER_CAPS_DOWNSAMPLE_REQUIRED = 0x8,
    /// <include file='D3D11_VIDEO_DECODER_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CAPS.D3D11_VIDEO_DECODER_CAPS_UNSUPPORTED"]/*'/>
    D3D11_VIDEO_DECODER_CAPS_UNSUPPORTED = 0x10,
}