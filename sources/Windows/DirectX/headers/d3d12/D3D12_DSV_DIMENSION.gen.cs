// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace Silk.NET.DirectX;

/// <include file='D3D12_DSV_DIMENSION.xml' path='doc/member[@name="D3D12_DSV_DIMENSION"]/*' />
public enum D3D12_DSV_DIMENSION
{
    /// <include file='D3D12_DSV_DIMENSION.xml' path='doc/member[@name="D3D12_DSV_DIMENSION.D3D12_DSV_DIMENSION_UNKNOWN"]/*' />
    D3D12_DSV_DIMENSION_UNKNOWN = 0,

    /// <include file='D3D12_DSV_DIMENSION.xml' path='doc/member[@name="D3D12_DSV_DIMENSION.D3D12_DSV_DIMENSION_TEXTURE1D"]/*' />
    D3D12_DSV_DIMENSION_TEXTURE1D = 1,

    /// <include file='D3D12_DSV_DIMENSION.xml' path='doc/member[@name="D3D12_DSV_DIMENSION.D3D12_DSV_DIMENSION_TEXTURE1DARRAY"]/*' />
    D3D12_DSV_DIMENSION_TEXTURE1DARRAY = 2,

    /// <include file='D3D12_DSV_DIMENSION.xml' path='doc/member[@name="D3D12_DSV_DIMENSION.D3D12_DSV_DIMENSION_TEXTURE2D"]/*' />
    D3D12_DSV_DIMENSION_TEXTURE2D = 3,

    /// <include file='D3D12_DSV_DIMENSION.xml' path='doc/member[@name="D3D12_DSV_DIMENSION.D3D12_DSV_DIMENSION_TEXTURE2DARRAY"]/*' />
    D3D12_DSV_DIMENSION_TEXTURE2DARRAY = 4,

    /// <include file='D3D12_DSV_DIMENSION.xml' path='doc/member[@name="D3D12_DSV_DIMENSION.D3D12_DSV_DIMENSION_TEXTURE2DMS"]/*' />
    D3D12_DSV_DIMENSION_TEXTURE2DMS = 5,

    /// <include file='D3D12_DSV_DIMENSION.xml' path='doc/member[@name="D3D12_DSV_DIMENSION.D3D12_DSV_DIMENSION_TEXTURE2DMSARRAY"]/*' />
    D3D12_DSV_DIMENSION_TEXTURE2DMSARRAY = 6,
}
