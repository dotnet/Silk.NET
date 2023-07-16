// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D3D11_TEX2D_ARRAY_UAV.xml' path='doc/member[@name="D3D11_TEX2D_ARRAY_UAV"]/*'/>
public partial struct D3D11_TEX2D_ARRAY_UAV
{
    /// <include file='D3D11_TEX2D_ARRAY_UAV.xml' path='doc/member[@name="D3D11_TEX2D_ARRAY_UAV.MipSlice"]/*'/>
    public uint MipSlice;
    /// <include file='D3D11_TEX2D_ARRAY_UAV.xml' path='doc/member[@name="D3D11_TEX2D_ARRAY_UAV.FirstArraySlice"]/*'/>
    public uint FirstArraySlice;
    /// <include file='D3D11_TEX2D_ARRAY_UAV.xml' path='doc/member[@name="D3D11_TEX2D_ARRAY_UAV.ArraySize"]/*'/>
    public uint ArraySize;
}