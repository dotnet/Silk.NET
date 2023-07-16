// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;
/// <include file='D3D11_PACKED_MIP_DESC.xml' path='doc/member[@name="D3D11_PACKED_MIP_DESC"]/*'/>
[SupportedOSPlatform("windows6.3")]
public partial struct D3D11_PACKED_MIP_DESC
{
    /// <include file='D3D11_PACKED_MIP_DESC.xml' path='doc/member[@name="D3D11_PACKED_MIP_DESC.NumStandardMips"]/*'/>
    [NativeTypeName("UINT8")]
    public byte NumStandardMips;
    /// <include file='D3D11_PACKED_MIP_DESC.xml' path='doc/member[@name="D3D11_PACKED_MIP_DESC.NumPackedMips"]/*'/>
    [NativeTypeName("UINT8")]
    public byte NumPackedMips;
    /// <include file='D3D11_PACKED_MIP_DESC.xml' path='doc/member[@name="D3D11_PACKED_MIP_DESC.NumTilesForPackedMips"]/*'/>
    public uint NumTilesForPackedMips;
    /// <include file='D3D11_PACKED_MIP_DESC.xml' path='doc/member[@name="D3D11_PACKED_MIP_DESC.StartTileIndexInOverallResource"]/*'/>
    public uint StartTileIndexInOverallResource;
}