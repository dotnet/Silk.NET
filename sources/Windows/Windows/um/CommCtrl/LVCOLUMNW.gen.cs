// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='LVCOLUMNW.xml' path='doc/member[@name="LVCOLUMNW"]/*' />
public unsafe partial struct LVCOLUMNW
{
    /// <include file='LVCOLUMNW.xml' path='doc/member[@name="LVCOLUMNW.mask"]/*' />
    public uint mask;

    /// <include file='LVCOLUMNW.xml' path='doc/member[@name="LVCOLUMNW.fmt"]/*' />
    public int fmt;

    /// <include file='LVCOLUMNW.xml' path='doc/member[@name="LVCOLUMNW.cx"]/*' />
    public int cx;

    /// <include file='LVCOLUMNW.xml' path='doc/member[@name="LVCOLUMNW.pszText"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pszText;

    /// <include file='LVCOLUMNW.xml' path='doc/member[@name="LVCOLUMNW.cchTextMax"]/*' />
    public int cchTextMax;

    /// <include file='LVCOLUMNW.xml' path='doc/member[@name="LVCOLUMNW.iSubItem"]/*' />
    public int iSubItem;

    /// <include file='LVCOLUMNW.xml' path='doc/member[@name="LVCOLUMNW.iImage"]/*' />
    public int iImage;

    /// <include file='LVCOLUMNW.xml' path='doc/member[@name="LVCOLUMNW.iOrder"]/*' />
    public int iOrder;

    /// <include file='LVCOLUMNW.xml' path='doc/member[@name="LVCOLUMNW.cxMin"]/*' />
    public int cxMin;

    /// <include file='LVCOLUMNW.xml' path='doc/member[@name="LVCOLUMNW.cxDefault"]/*' />
    public int cxDefault;

    /// <include file='LVCOLUMNW.xml' path='doc/member[@name="LVCOLUMNW.cxIdeal"]/*' />
    public int cxIdeal;
}
