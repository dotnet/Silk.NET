// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D3D11_STANDARD_MULTISAMPLE_QUALITY_LEVELS.xml' path='doc/member[@name="D3D11_STANDARD_MULTISAMPLE_QUALITY_LEVELS"]/*' />
public enum D3D11_STANDARD_MULTISAMPLE_QUALITY_LEVELS
{
    /// <include file='D3D11_STANDARD_MULTISAMPLE_QUALITY_LEVELS.xml' path='doc/member[@name="D3D11_STANDARD_MULTISAMPLE_QUALITY_LEVELS.D3D11_STANDARD_MULTISAMPLE_PATTERN"]/*' />
    D3D11_STANDARD_MULTISAMPLE_PATTERN = unchecked((int)(0xffffffff)),

    /// <include file='D3D11_STANDARD_MULTISAMPLE_QUALITY_LEVELS.xml' path='doc/member[@name="D3D11_STANDARD_MULTISAMPLE_QUALITY_LEVELS.D3D11_CENTER_MULTISAMPLE_PATTERN"]/*' />
    D3D11_CENTER_MULTISAMPLE_PATTERN = unchecked((int)(0xfffffffe)),
}
