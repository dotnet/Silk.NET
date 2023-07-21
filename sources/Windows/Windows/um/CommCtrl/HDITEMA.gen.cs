// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='HDITEMA.xml' path='doc/member[@name="HDITEMA"]/*' />
public unsafe partial struct HDITEMA
{
    /// <include file='HDITEMA.xml' path='doc/member[@name="HDITEMA.mask"]/*' />
    public uint mask;

    /// <include file='HDITEMA.xml' path='doc/member[@name="HDITEMA.cxy"]/*' />
    public int cxy;

    /// <include file='HDITEMA.xml' path='doc/member[@name="HDITEMA.pszText"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* pszText;

    /// <include file='HDITEMA.xml' path='doc/member[@name="HDITEMA.hbm"]/*' />
    public HBITMAP hbm;

    /// <include file='HDITEMA.xml' path='doc/member[@name="HDITEMA.cchTextMax"]/*' />
    public int cchTextMax;

    /// <include file='HDITEMA.xml' path='doc/member[@name="HDITEMA.fmt"]/*' />
    public int fmt;

    /// <include file='HDITEMA.xml' path='doc/member[@name="HDITEMA.lParam"]/*' />
    public LPARAM lParam;

    /// <include file='HDITEMA.xml' path='doc/member[@name="HDITEMA.iImage"]/*' />
    public int iImage;

    /// <include file='HDITEMA.xml' path='doc/member[@name="HDITEMA.iOrder"]/*' />
    public int iOrder;

    /// <include file='HDITEMA.xml' path='doc/member[@name="HDITEMA.type"]/*' />
    public uint type;

    /// <include file='HDITEMA.xml' path='doc/member[@name="HDITEMA.pvFilter"]/*' />
    public void* pvFilter;

    /// <include file='HDITEMA.xml' path='doc/member[@name="HDITEMA.state"]/*' />
    public uint state;
}
