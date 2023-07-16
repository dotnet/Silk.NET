// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;
/// <include file='D3D11_SUBRESOURCE_TILING.xml' path='doc/member[@name="D3D11_SUBRESOURCE_TILING"]/*'/>
[SupportedOSPlatform("windows6.3")]
public partial struct D3D11_SUBRESOURCE_TILING
{
    /// <include file='D3D11_SUBRESOURCE_TILING.xml' path='doc/member[@name="D3D11_SUBRESOURCE_TILING.WidthInTiles"]/*'/>
    public uint WidthInTiles;
    /// <include file='D3D11_SUBRESOURCE_TILING.xml' path='doc/member[@name="D3D11_SUBRESOURCE_TILING.HeightInTiles"]/*'/>
    [NativeTypeName("UINT16")]
    public ushort HeightInTiles;
    /// <include file='D3D11_SUBRESOURCE_TILING.xml' path='doc/member[@name="D3D11_SUBRESOURCE_TILING.DepthInTiles"]/*'/>
    [NativeTypeName("UINT16")]
    public ushort DepthInTiles;
    /// <include file='D3D11_SUBRESOURCE_TILING.xml' path='doc/member[@name="D3D11_SUBRESOURCE_TILING.StartTileIndexInOverallResource"]/*'/>
    public uint StartTileIndexInOverallResource;
}