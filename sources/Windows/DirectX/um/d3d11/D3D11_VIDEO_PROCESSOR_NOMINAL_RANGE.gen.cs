// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE"]/*' />
[SupportedOSPlatform("windows6.3")]
public enum D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE
{
    /// <include file='D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE.D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE_UNDEFINED"]/*' />
    D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE_UNDEFINED = 0,

    /// <include file='D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE.D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE_16_235"]/*' />
    D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE_16_235 = 1,

    /// <include file='D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE.D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE_0_255"]/*' />
    D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE_0_255 = 2,
}
