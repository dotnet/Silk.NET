// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NMTBGETINFOTIPW.xml' path='doc/member[@name="NMTBGETINFOTIPW"]/*' />
public unsafe partial struct NMTBGETINFOTIPW
{
    /// <include file='NMTBGETINFOTIPW.xml' path='doc/member[@name="NMTBGETINFOTIPW.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMTBGETINFOTIPW.xml' path='doc/member[@name="NMTBGETINFOTIPW.pszText"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pszText;

    /// <include file='NMTBGETINFOTIPW.xml' path='doc/member[@name="NMTBGETINFOTIPW.cchTextMax"]/*' />
    public int cchTextMax;

    /// <include file='NMTBGETINFOTIPW.xml' path='doc/member[@name="NMTBGETINFOTIPW.iItem"]/*' />
    public int iItem;

    /// <include file='NMTBGETINFOTIPW.xml' path='doc/member[@name="NMTBGETINFOTIPW.lParam"]/*' />
    public LPARAM lParam;
}
