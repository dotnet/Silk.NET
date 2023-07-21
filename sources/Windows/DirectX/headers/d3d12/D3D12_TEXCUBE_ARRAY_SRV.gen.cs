// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace Silk.NET.DirectX;

/// <include file='D3D12_TEXCUBE_ARRAY_SRV.xml' path='doc/member[@name="D3D12_TEXCUBE_ARRAY_SRV"]/*' />
public partial struct D3D12_TEXCUBE_ARRAY_SRV
{
    /// <include file='D3D12_TEXCUBE_ARRAY_SRV.xml' path='doc/member[@name="D3D12_TEXCUBE_ARRAY_SRV.MostDetailedMip"]/*' />
    public uint MostDetailedMip;

    /// <include file='D3D12_TEXCUBE_ARRAY_SRV.xml' path='doc/member[@name="D3D12_TEXCUBE_ARRAY_SRV.MipLevels"]/*' />
    public uint MipLevels;

    /// <include file='D3D12_TEXCUBE_ARRAY_SRV.xml' path='doc/member[@name="D3D12_TEXCUBE_ARRAY_SRV.First2DArrayFace"]/*' />
    public uint First2DArrayFace;

    /// <include file='D3D12_TEXCUBE_ARRAY_SRV.xml' path='doc/member[@name="D3D12_TEXCUBE_ARRAY_SRV.NumCubes"]/*' />
    public uint NumCubes;

    /// <include file='D3D12_TEXCUBE_ARRAY_SRV.xml' path='doc/member[@name="D3D12_TEXCUBE_ARRAY_SRV.ResourceMinLODClamp"]/*' />
    public float ResourceMinLODClamp;
}
