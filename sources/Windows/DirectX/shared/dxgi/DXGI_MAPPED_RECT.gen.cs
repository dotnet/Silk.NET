// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DXGI_MAPPED_RECT.xml' path='doc/member[@name="DXGI_MAPPED_RECT"]/*'/>
public unsafe partial struct DXGI_MAPPED_RECT
{
    /// <include file='DXGI_MAPPED_RECT.xml' path='doc/member[@name="DXGI_MAPPED_RECT.Pitch"]/*'/>
    public int Pitch;
    /// <include file='DXGI_MAPPED_RECT.xml' path='doc/member[@name="DXGI_MAPPED_RECT.pBits"]/*'/>
    public byte* pBits;
}