// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace Silk.NET.DirectX;

/// <include file='D3D12_PACKED_MIP_INFO.xml' path='doc/member[@name="D3D12_PACKED_MIP_INFO"]/*' />
public partial struct D3D12_PACKED_MIP_INFO
{
    /// <include file='D3D12_PACKED_MIP_INFO.xml' path='doc/member[@name="D3D12_PACKED_MIP_INFO.NumStandardMips"]/*' />
    [NativeTypeName("UINT8")]
    public byte NumStandardMips;

    /// <include file='D3D12_PACKED_MIP_INFO.xml' path='doc/member[@name="D3D12_PACKED_MIP_INFO.NumPackedMips"]/*' />
    [NativeTypeName("UINT8")]
    public byte NumPackedMips;

    /// <include file='D3D12_PACKED_MIP_INFO.xml' path='doc/member[@name="D3D12_PACKED_MIP_INFO.NumTilesForPackedMips"]/*' />
    public uint NumTilesForPackedMips;

    /// <include file='D3D12_PACKED_MIP_INFO.xml' path='doc/member[@name="D3D12_PACKED_MIP_INFO.StartTileIndexInOverallResource"]/*' />
    public uint StartTileIndexInOverallResource;
}
