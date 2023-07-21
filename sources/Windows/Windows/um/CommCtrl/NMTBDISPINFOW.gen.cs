// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NMTBDISPINFOW.xml' path='doc/member[@name="NMTBDISPINFOW"]/*' />
public unsafe partial struct NMTBDISPINFOW
{
    /// <include file='NMTBDISPINFOW.xml' path='doc/member[@name="NMTBDISPINFOW.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMTBDISPINFOW.xml' path='doc/member[@name="NMTBDISPINFOW.dwMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMask;

    /// <include file='NMTBDISPINFOW.xml' path='doc/member[@name="NMTBDISPINFOW.idCommand"]/*' />
    public int idCommand;

    /// <include file='NMTBDISPINFOW.xml' path='doc/member[@name="NMTBDISPINFOW.lParam"]/*' />
    [NativeTypeName("DWORD_PTR")]
    public nuint lParam;

    /// <include file='NMTBDISPINFOW.xml' path='doc/member[@name="NMTBDISPINFOW.iImage"]/*' />
    public int iImage;

    /// <include file='NMTBDISPINFOW.xml' path='doc/member[@name="NMTBDISPINFOW.pszText"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pszText;

    /// <include file='NMTBDISPINFOW.xml' path='doc/member[@name="NMTBDISPINFOW.cchText"]/*' />
    public int cchText;
}
