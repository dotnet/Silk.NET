// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D11_VIDEO_PROCESSOR_FORMAT_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_FORMAT_CAPS"]/*'/>
[Flags]
[SupportedOSPlatform("windows6.2")]
public enum D3D11_VIDEO_PROCESSOR_FORMAT_CAPS
{
    /// <include file='D3D11_VIDEO_PROCESSOR_FORMAT_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_FORMAT_CAPS.D3D11_VIDEO_PROCESSOR_FORMAT_CAPS_RGB_INTERLACED"]/*'/>
    D3D11_VIDEO_PROCESSOR_FORMAT_CAPS_RGB_INTERLACED = 0x1,
    /// <include file='D3D11_VIDEO_PROCESSOR_FORMAT_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_FORMAT_CAPS.D3D11_VIDEO_PROCESSOR_FORMAT_CAPS_RGB_PROCAMP"]/*'/>
    D3D11_VIDEO_PROCESSOR_FORMAT_CAPS_RGB_PROCAMP = 0x2,
    /// <include file='D3D11_VIDEO_PROCESSOR_FORMAT_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_FORMAT_CAPS.D3D11_VIDEO_PROCESSOR_FORMAT_CAPS_RGB_LUMA_KEY"]/*'/>
    D3D11_VIDEO_PROCESSOR_FORMAT_CAPS_RGB_LUMA_KEY = 0x4,
    /// <include file='D3D11_VIDEO_PROCESSOR_FORMAT_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_FORMAT_CAPS.D3D11_VIDEO_PROCESSOR_FORMAT_CAPS_PALETTE_INTERLACED"]/*'/>
    D3D11_VIDEO_PROCESSOR_FORMAT_CAPS_PALETTE_INTERLACED = 0x8,
}