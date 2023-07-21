// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.DirectX;

namespace Silk.NET.Windows;

/// <include file='VMRALPHABITMAP.xml' path='doc/member[@name="VMRALPHABITMAP"]/*' />
public unsafe partial struct VMRALPHABITMAP
{
    /// <include file='VMRALPHABITMAP.xml' path='doc/member[@name="VMRALPHABITMAP.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='VMRALPHABITMAP.xml' path='doc/member[@name="VMRALPHABITMAP.hdc"]/*' />
    public HDC hdc;

    /// <include file='VMRALPHABITMAP.xml' path='doc/member[@name="VMRALPHABITMAP.pDDS"]/*' />
    [NativeTypeName("LPDIRECTDRAWSURFACE7")]
    public IDirectDrawSurface7* pDDS;

    /// <include file='VMRALPHABITMAP.xml' path='doc/member[@name="VMRALPHABITMAP.rSrc"]/*' />
    public RECT rSrc;

    /// <include file='VMRALPHABITMAP.xml' path='doc/member[@name="VMRALPHABITMAP.rDest"]/*' />
    public NORMALIZEDRECT rDest;

    /// <include file='VMRALPHABITMAP.xml' path='doc/member[@name="VMRALPHABITMAP.fAlpha"]/*' />
    public float fAlpha;

    /// <include file='VMRALPHABITMAP.xml' path='doc/member[@name="VMRALPHABITMAP.clrSrcKey"]/*' />
    public COLORREF clrSrcKey;
}
