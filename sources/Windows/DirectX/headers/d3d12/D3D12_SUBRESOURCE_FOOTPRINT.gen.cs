// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace Silk.NET.DirectX;

/// <include file='D3D12_SUBRESOURCE_FOOTPRINT.xml' path='doc/member[@name="D3D12_SUBRESOURCE_FOOTPRINT"]/*' />
public partial struct D3D12_SUBRESOURCE_FOOTPRINT
{
    /// <include file='D3D12_SUBRESOURCE_FOOTPRINT.xml' path='doc/member[@name="D3D12_SUBRESOURCE_FOOTPRINT.Format"]/*' />
    public DXGI_FORMAT Format;

    /// <include file='D3D12_SUBRESOURCE_FOOTPRINT.xml' path='doc/member[@name="D3D12_SUBRESOURCE_FOOTPRINT.Width"]/*' />
    public uint Width;

    /// <include file='D3D12_SUBRESOURCE_FOOTPRINT.xml' path='doc/member[@name="D3D12_SUBRESOURCE_FOOTPRINT.Height"]/*' />
    public uint Height;

    /// <include file='D3D12_SUBRESOURCE_FOOTPRINT.xml' path='doc/member[@name="D3D12_SUBRESOURCE_FOOTPRINT.Depth"]/*' />
    public uint Depth;

    /// <include file='D3D12_SUBRESOURCE_FOOTPRINT.xml' path='doc/member[@name="D3D12_SUBRESOURCE_FOOTPRINT.RowPitch"]/*' />
    public uint RowPitch;
}
