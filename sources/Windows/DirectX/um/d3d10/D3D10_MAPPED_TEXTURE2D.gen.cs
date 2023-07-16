// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D3D10_MAPPED_TEXTURE2D.xml' path='doc/member[@name="D3D10_MAPPED_TEXTURE2D"]/*'/>
public unsafe partial struct D3D10_MAPPED_TEXTURE2D
{
    /// <include file='D3D10_MAPPED_TEXTURE2D.xml' path='doc/member[@name="D3D10_MAPPED_TEXTURE2D.pData"]/*'/>
    public void* pData;
    /// <include file='D3D10_MAPPED_TEXTURE2D.xml' path='doc/member[@name="D3D10_MAPPED_TEXTURE2D.RowPitch"]/*'/>
    public uint RowPitch;
}