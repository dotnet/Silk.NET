// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D3D11_TEX2D_ARRAY_SRV1.xml' path='doc/member[@name="D3D11_TEX2D_ARRAY_SRV1"]/*' />
public partial struct D3D11_TEX2D_ARRAY_SRV1
{
    /// <include file='D3D11_TEX2D_ARRAY_SRV1.xml' path='doc/member[@name="D3D11_TEX2D_ARRAY_SRV1.MostDetailedMip"]/*' />
    public uint MostDetailedMip;

    /// <include file='D3D11_TEX2D_ARRAY_SRV1.xml' path='doc/member[@name="D3D11_TEX2D_ARRAY_SRV1.MipLevels"]/*' />
    public uint MipLevels;

    /// <include file='D3D11_TEX2D_ARRAY_SRV1.xml' path='doc/member[@name="D3D11_TEX2D_ARRAY_SRV1.FirstArraySlice"]/*' />
    public uint FirstArraySlice;

    /// <include file='D3D11_TEX2D_ARRAY_SRV1.xml' path='doc/member[@name="D3D11_TEX2D_ARRAY_SRV1.ArraySize"]/*' />
    public uint ArraySize;

    /// <include file='D3D11_TEX2D_ARRAY_SRV1.xml' path='doc/member[@name="D3D11_TEX2D_ARRAY_SRV1.PlaneSlice"]/*' />
    public uint PlaneSlice;
}
