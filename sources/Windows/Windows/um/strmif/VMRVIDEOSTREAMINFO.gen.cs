// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.DirectX;

namespace Silk.NET.Windows;

/// <include file='VMRVIDEOSTREAMINFO.xml' path='doc/member[@name="VMRVIDEOSTREAMINFO"]/*' />
public unsafe partial struct VMRVIDEOSTREAMINFO
{
    /// <include file='VMRVIDEOSTREAMINFO.xml' path='doc/member[@name="VMRVIDEOSTREAMINFO.pddsVideoSurface"]/*' />
    [NativeTypeName("LPDIRECTDRAWSURFACE7")]
    public IDirectDrawSurface7* pddsVideoSurface;

    /// <include file='VMRVIDEOSTREAMINFO.xml' path='doc/member[@name="VMRVIDEOSTREAMINFO.dwWidth"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwWidth;

    /// <include file='VMRVIDEOSTREAMINFO.xml' path='doc/member[@name="VMRVIDEOSTREAMINFO.dwHeight"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwHeight;

    /// <include file='VMRVIDEOSTREAMINFO.xml' path='doc/member[@name="VMRVIDEOSTREAMINFO.dwStrmID"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwStrmID;

    /// <include file='VMRVIDEOSTREAMINFO.xml' path='doc/member[@name="VMRVIDEOSTREAMINFO.fAlpha"]/*' />
    public float fAlpha;

    /// <include file='VMRVIDEOSTREAMINFO.xml' path='doc/member[@name="VMRVIDEOSTREAMINFO.ddClrKey"]/*' />
    public DDCOLORKEY ddClrKey;

    /// <include file='VMRVIDEOSTREAMINFO.xml' path='doc/member[@name="VMRVIDEOSTREAMINFO.rNormal"]/*' />
    public NORMALIZEDRECT rNormal;
}
