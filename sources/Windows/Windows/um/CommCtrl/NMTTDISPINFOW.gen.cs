// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NMTTDISPINFOW.xml' path='doc/member[@name="NMTTDISPINFOW"]/*' />
public unsafe partial struct NMTTDISPINFOW
{
    /// <include file='NMTTDISPINFOW.xml' path='doc/member[@name="NMTTDISPINFOW.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMTTDISPINFOW.xml' path='doc/member[@name="NMTTDISPINFOW.lpszText"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* lpszText;

    /// <include file='NMTTDISPINFOW.xml' path='doc/member[@name="NMTTDISPINFOW.szText"]/*' />
    [NativeTypeName("WCHAR[80]")]
    public fixed ushort szText[80];

    /// <include file='NMTTDISPINFOW.xml' path='doc/member[@name="NMTTDISPINFOW.hinst"]/*' />
    public HINSTANCE hinst;

    /// <include file='NMTTDISPINFOW.xml' path='doc/member[@name="NMTTDISPINFOW.uFlags"]/*' />
    public uint uFlags;

    /// <include file='NMTTDISPINFOW.xml' path='doc/member[@name="NMTTDISPINFOW.lParam"]/*' />
    public LPARAM lParam;
}
