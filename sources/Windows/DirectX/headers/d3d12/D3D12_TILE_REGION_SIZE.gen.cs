// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_TILE_REGION_SIZE.xml' path='doc/member[@name="D3D12_TILE_REGION_SIZE"]/*'/>
public partial struct D3D12_TILE_REGION_SIZE
{
    /// <include file='D3D12_TILE_REGION_SIZE.xml' path='doc/member[@name="D3D12_TILE_REGION_SIZE.NumTiles"]/*'/>
    public uint NumTiles;
    /// <include file='D3D12_TILE_REGION_SIZE.xml' path='doc/member[@name="D3D12_TILE_REGION_SIZE.UseBox"]/*'/>
    public BOOL UseBox;
    /// <include file='D3D12_TILE_REGION_SIZE.xml' path='doc/member[@name="D3D12_TILE_REGION_SIZE.Width"]/*'/>
    public uint Width;
    /// <include file='D3D12_TILE_REGION_SIZE.xml' path='doc/member[@name="D3D12_TILE_REGION_SIZE.Height"]/*'/>
    [NativeTypeName("UINT16")]
    public ushort Height;
    /// <include file='D3D12_TILE_REGION_SIZE.xml' path='doc/member[@name="D3D12_TILE_REGION_SIZE.Depth"]/*'/>
    [NativeTypeName("UINT16")]
    public ushort Depth;
}