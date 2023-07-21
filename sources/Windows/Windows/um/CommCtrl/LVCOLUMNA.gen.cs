// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='LVCOLUMNA.xml' path='doc/member[@name="LVCOLUMNA"]/*' />
public unsafe partial struct LVCOLUMNA
{
    /// <include file='LVCOLUMNA.xml' path='doc/member[@name="LVCOLUMNA.mask"]/*' />
    public uint mask;

    /// <include file='LVCOLUMNA.xml' path='doc/member[@name="LVCOLUMNA.fmt"]/*' />
    public int fmt;

    /// <include file='LVCOLUMNA.xml' path='doc/member[@name="LVCOLUMNA.cx"]/*' />
    public int cx;

    /// <include file='LVCOLUMNA.xml' path='doc/member[@name="LVCOLUMNA.pszText"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* pszText;

    /// <include file='LVCOLUMNA.xml' path='doc/member[@name="LVCOLUMNA.cchTextMax"]/*' />
    public int cchTextMax;

    /// <include file='LVCOLUMNA.xml' path='doc/member[@name="LVCOLUMNA.iSubItem"]/*' />
    public int iSubItem;

    /// <include file='LVCOLUMNA.xml' path='doc/member[@name="LVCOLUMNA.iImage"]/*' />
    public int iImage;

    /// <include file='LVCOLUMNA.xml' path='doc/member[@name="LVCOLUMNA.iOrder"]/*' />
    public int iOrder;

    /// <include file='LVCOLUMNA.xml' path='doc/member[@name="LVCOLUMNA.cxMin"]/*' />
    public int cxMin;

    /// <include file='LVCOLUMNA.xml' path='doc/member[@name="LVCOLUMNA.cxDefault"]/*' />
    public int cxDefault;

    /// <include file='LVCOLUMNA.xml' path='doc/member[@name="LVCOLUMNA.cxIdeal"]/*' />
    public int cxIdeal;
}
