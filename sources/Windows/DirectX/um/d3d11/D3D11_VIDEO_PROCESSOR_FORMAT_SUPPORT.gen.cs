// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;
/// <include file='D3D11_VIDEO_PROCESSOR_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_FORMAT_SUPPORT"]/*'/>
[Flags]
[SupportedOSPlatform("windows6.2")]
public enum D3D11_VIDEO_PROCESSOR_FORMAT_SUPPORT
{
    /// <include file='D3D11_VIDEO_PROCESSOR_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_FORMAT_SUPPORT.D3D11_VIDEO_PROCESSOR_FORMAT_SUPPORT_INPUT"]/*'/>
    D3D11_VIDEO_PROCESSOR_FORMAT_SUPPORT_INPUT = 0x1,
    /// <include file='D3D11_VIDEO_PROCESSOR_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_FORMAT_SUPPORT.D3D11_VIDEO_PROCESSOR_FORMAT_SUPPORT_OUTPUT"]/*'/>
    D3D11_VIDEO_PROCESSOR_FORMAT_SUPPORT_OUTPUT = 0x2,
}