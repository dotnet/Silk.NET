// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace Silk.NET.DirectX;

/// <include file='D3D12_STATIC_BORDER_COLOR.xml' path='doc/member[@name="D3D12_STATIC_BORDER_COLOR"]/*' />
public enum D3D12_STATIC_BORDER_COLOR
{
    /// <include file='D3D12_STATIC_BORDER_COLOR.xml' path='doc/member[@name="D3D12_STATIC_BORDER_COLOR.D3D12_STATIC_BORDER_COLOR_TRANSPARENT_BLACK"]/*' />
    D3D12_STATIC_BORDER_COLOR_TRANSPARENT_BLACK = 0,

    /// <include file='D3D12_STATIC_BORDER_COLOR.xml' path='doc/member[@name="D3D12_STATIC_BORDER_COLOR.D3D12_STATIC_BORDER_COLOR_OPAQUE_BLACK"]/*' />
    D3D12_STATIC_BORDER_COLOR_OPAQUE_BLACK = (D3D12_STATIC_BORDER_COLOR_TRANSPARENT_BLACK + 1),

    /// <include file='D3D12_STATIC_BORDER_COLOR.xml' path='doc/member[@name="D3D12_STATIC_BORDER_COLOR.D3D12_STATIC_BORDER_COLOR_OPAQUE_WHITE"]/*' />
    D3D12_STATIC_BORDER_COLOR_OPAQUE_WHITE = (D3D12_STATIC_BORDER_COLOR_OPAQUE_BLACK + 1),

    /// <include file='D3D12_STATIC_BORDER_COLOR.xml' path='doc/member[@name="D3D12_STATIC_BORDER_COLOR.D3D12_STATIC_BORDER_COLOR_OPAQUE_BLACK_UINT"]/*' />
    D3D12_STATIC_BORDER_COLOR_OPAQUE_BLACK_UINT = (D3D12_STATIC_BORDER_COLOR_OPAQUE_WHITE + 1),

    /// <include file='D3D12_STATIC_BORDER_COLOR.xml' path='doc/member[@name="D3D12_STATIC_BORDER_COLOR.D3D12_STATIC_BORDER_COLOR_OPAQUE_WHITE_UINT"]/*' />
    D3D12_STATIC_BORDER_COLOR_OPAQUE_WHITE_UINT = (D3D12_STATIC_BORDER_COLOR_OPAQUE_BLACK_UINT + 1),
}
