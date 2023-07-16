// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D3D11_BUFFER_DESC.xml' path='doc/member[@name="D3D11_BUFFER_DESC"]/*'/>
public partial struct D3D11_BUFFER_DESC
{
    /// <include file='D3D11_BUFFER_DESC.xml' path='doc/member[@name="D3D11_BUFFER_DESC.ByteWidth"]/*'/>
    public uint ByteWidth;
    /// <include file='D3D11_BUFFER_DESC.xml' path='doc/member[@name="D3D11_BUFFER_DESC.Usage"]/*'/>
    public D3D11_USAGE Usage;
    /// <include file='D3D11_BUFFER_DESC.xml' path='doc/member[@name="D3D11_BUFFER_DESC.BindFlags"]/*'/>
    public uint BindFlags;
    /// <include file='D3D11_BUFFER_DESC.xml' path='doc/member[@name="D3D11_BUFFER_DESC.CPUAccessFlags"]/*'/>
    public uint CPUAccessFlags;
    /// <include file='D3D11_BUFFER_DESC.xml' path='doc/member[@name="D3D11_BUFFER_DESC.MiscFlags"]/*'/>
    public uint MiscFlags;
    /// <include file='D3D11_BUFFER_DESC.xml' path='doc/member[@name="D3D11_BUFFER_DESC.StructureByteStride"]/*'/>
    public uint StructureByteStride;
}