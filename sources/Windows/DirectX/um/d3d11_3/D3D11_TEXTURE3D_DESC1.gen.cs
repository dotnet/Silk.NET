// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D3D11_TEXTURE3D_DESC1.xml' path='doc/member[@name="D3D11_TEXTURE3D_DESC1"]/*'/>
public partial struct D3D11_TEXTURE3D_DESC1
{
    /// <include file='D3D11_TEXTURE3D_DESC1.xml' path='doc/member[@name="D3D11_TEXTURE3D_DESC1.Width"]/*'/>
    public uint Width;
    /// <include file='D3D11_TEXTURE3D_DESC1.xml' path='doc/member[@name="D3D11_TEXTURE3D_DESC1.Height"]/*'/>
    public uint Height;
    /// <include file='D3D11_TEXTURE3D_DESC1.xml' path='doc/member[@name="D3D11_TEXTURE3D_DESC1.Depth"]/*'/>
    public uint Depth;
    /// <include file='D3D11_TEXTURE3D_DESC1.xml' path='doc/member[@name="D3D11_TEXTURE3D_DESC1.MipLevels"]/*'/>
    public uint MipLevels;
    /// <include file='D3D11_TEXTURE3D_DESC1.xml' path='doc/member[@name="D3D11_TEXTURE3D_DESC1.Format"]/*'/>
    public DXGI_FORMAT Format;
    /// <include file='D3D11_TEXTURE3D_DESC1.xml' path='doc/member[@name="D3D11_TEXTURE3D_DESC1.Usage"]/*'/>
    public D3D11_USAGE Usage;
    /// <include file='D3D11_TEXTURE3D_DESC1.xml' path='doc/member[@name="D3D11_TEXTURE3D_DESC1.BindFlags"]/*'/>
    public uint BindFlags;
    /// <include file='D3D11_TEXTURE3D_DESC1.xml' path='doc/member[@name="D3D11_TEXTURE3D_DESC1.CPUAccessFlags"]/*'/>
    public uint CPUAccessFlags;
    /// <include file='D3D11_TEXTURE3D_DESC1.xml' path='doc/member[@name="D3D11_TEXTURE3D_DESC1.MiscFlags"]/*'/>
    public uint MiscFlags;
    /// <include file='D3D11_TEXTURE3D_DESC1.xml' path='doc/member[@name="D3D11_TEXTURE3D_DESC1.TextureLayout"]/*'/>
    public D3D11_TEXTURE_LAYOUT TextureLayout;
}