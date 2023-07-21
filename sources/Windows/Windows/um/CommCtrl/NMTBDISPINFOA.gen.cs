// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NMTBDISPINFOA.xml' path='doc/member[@name="NMTBDISPINFOA"]/*' />
public unsafe partial struct NMTBDISPINFOA
{
    /// <include file='NMTBDISPINFOA.xml' path='doc/member[@name="NMTBDISPINFOA.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMTBDISPINFOA.xml' path='doc/member[@name="NMTBDISPINFOA.dwMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMask;

    /// <include file='NMTBDISPINFOA.xml' path='doc/member[@name="NMTBDISPINFOA.idCommand"]/*' />
    public int idCommand;

    /// <include file='NMTBDISPINFOA.xml' path='doc/member[@name="NMTBDISPINFOA.lParam"]/*' />
    [NativeTypeName("DWORD_PTR")]
    public nuint lParam;

    /// <include file='NMTBDISPINFOA.xml' path='doc/member[@name="NMTBDISPINFOA.iImage"]/*' />
    public int iImage;

    /// <include file='NMTBDISPINFOA.xml' path='doc/member[@name="NMTBDISPINFOA.pszText"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* pszText;

    /// <include file='NMTBDISPINFOA.xml' path='doc/member[@name="NMTBDISPINFOA.cchText"]/*' />
    public int cchText;
}
