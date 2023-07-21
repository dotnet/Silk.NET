// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='D3D11_VIDEO_PROCESSOR_OUTPUT_RATE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_OUTPUT_RATE"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum D3D11_VIDEO_PROCESSOR_OUTPUT_RATE
{
    /// <include file='D3D11_VIDEO_PROCESSOR_OUTPUT_RATE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_OUTPUT_RATE.D3D11_VIDEO_PROCESSOR_OUTPUT_RATE_NORMAL"]/*' />
    D3D11_VIDEO_PROCESSOR_OUTPUT_RATE_NORMAL = 0,

    /// <include file='D3D11_VIDEO_PROCESSOR_OUTPUT_RATE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_OUTPUT_RATE.D3D11_VIDEO_PROCESSOR_OUTPUT_RATE_HALF"]/*' />
    D3D11_VIDEO_PROCESSOR_OUTPUT_RATE_HALF = 1,

    /// <include file='D3D11_VIDEO_PROCESSOR_OUTPUT_RATE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_OUTPUT_RATE.D3D11_VIDEO_PROCESSOR_OUTPUT_RATE_CUSTOM"]/*' />
    D3D11_VIDEO_PROCESSOR_OUTPUT_RATE_CUSTOM = 2,
}
