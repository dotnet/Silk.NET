// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D3D11_BUFFEREX_SRV.xml' path='doc/member[@name="D3D11_BUFFEREX_SRV"]/*'/>
public partial struct D3D11_BUFFEREX_SRV
{
    /// <include file='D3D11_BUFFEREX_SRV.xml' path='doc/member[@name="D3D11_BUFFEREX_SRV.FirstElement"]/*'/>
    public uint FirstElement;
    /// <include file='D3D11_BUFFEREX_SRV.xml' path='doc/member[@name="D3D11_BUFFEREX_SRV.NumElements"]/*'/>
    public uint NumElements;
    /// <include file='D3D11_BUFFEREX_SRV.xml' path='doc/member[@name="D3D11_BUFFEREX_SRV.Flags"]/*'/>
    public uint Flags;
}