// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D3D11_TEXTURE_LAYOUT.xml' path='doc/member[@name="D3D11_TEXTURE_LAYOUT"]/*' />
public enum D3D11_TEXTURE_LAYOUT
{
    /// <include file='D3D11_TEXTURE_LAYOUT.xml' path='doc/member[@name="D3D11_TEXTURE_LAYOUT.D3D11_TEXTURE_LAYOUT_UNDEFINED"]/*' />
    D3D11_TEXTURE_LAYOUT_UNDEFINED = 0,

    /// <include file='D3D11_TEXTURE_LAYOUT.xml' path='doc/member[@name="D3D11_TEXTURE_LAYOUT.D3D11_TEXTURE_LAYOUT_ROW_MAJOR"]/*' />
    D3D11_TEXTURE_LAYOUT_ROW_MAJOR = 1,

    /// <include file='D3D11_TEXTURE_LAYOUT.xml' path='doc/member[@name="D3D11_TEXTURE_LAYOUT.D3D11_TEXTURE_LAYOUT_64K_STANDARD_SWIZZLE"]/*' />
    D3D11_TEXTURE_LAYOUT_64K_STANDARD_SWIZZLE = 2,
}
