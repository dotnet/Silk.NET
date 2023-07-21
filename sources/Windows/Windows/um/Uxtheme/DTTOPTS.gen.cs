// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DTTOPTS.xml' path='doc/member[@name="DTTOPTS"]/*' />
public unsafe partial struct DTTOPTS
{
    /// <include file='DTTOPTS.xml' path='doc/member[@name="DTTOPTS.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='DTTOPTS.xml' path='doc/member[@name="DTTOPTS.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='DTTOPTS.xml' path='doc/member[@name="DTTOPTS.crText"]/*' />
    public COLORREF crText;

    /// <include file='DTTOPTS.xml' path='doc/member[@name="DTTOPTS.crBorder"]/*' />
    public COLORREF crBorder;

    /// <include file='DTTOPTS.xml' path='doc/member[@name="DTTOPTS.crShadow"]/*' />
    public COLORREF crShadow;

    /// <include file='DTTOPTS.xml' path='doc/member[@name="DTTOPTS.iTextShadowType"]/*' />
    public int iTextShadowType;

    /// <include file='DTTOPTS.xml' path='doc/member[@name="DTTOPTS.ptShadowOffset"]/*' />
    public POINT ptShadowOffset;

    /// <include file='DTTOPTS.xml' path='doc/member[@name="DTTOPTS.iBorderSize"]/*' />
    public int iBorderSize;

    /// <include file='DTTOPTS.xml' path='doc/member[@name="DTTOPTS.iFontPropId"]/*' />
    public int iFontPropId;

    /// <include file='DTTOPTS.xml' path='doc/member[@name="DTTOPTS.iColorPropId"]/*' />
    public int iColorPropId;

    /// <include file='DTTOPTS.xml' path='doc/member[@name="DTTOPTS.iStateId"]/*' />
    public int iStateId;

    /// <include file='DTTOPTS.xml' path='doc/member[@name="DTTOPTS.fApplyOverlay"]/*' />
    public BOOL fApplyOverlay;

    /// <include file='DTTOPTS.xml' path='doc/member[@name="DTTOPTS.iGlowSize"]/*' />
    public int iGlowSize;

    /// <include file='DTTOPTS.xml' path='doc/member[@name="DTTOPTS.pfnDrawTextCallback"]/*' />
    [NativeTypeName("DTT_CALLBACK_PROC")]
    public delegate* unmanaged<HDC, ushort*, int, RECT*, uint, LPARAM, int> pfnDrawTextCallback;

    /// <include file='DTTOPTS.xml' path='doc/member[@name="DTTOPTS.lParam"]/*' />
    public LPARAM lParam;
}
