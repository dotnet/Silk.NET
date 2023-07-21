// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NMLVEMPTYMARKUP.xml' path='doc/member[@name="NMLVEMPTYMARKUP"]/*' />
public unsafe partial struct NMLVEMPTYMARKUP
{
    /// <include file='NMLVEMPTYMARKUP.xml' path='doc/member[@name="NMLVEMPTYMARKUP.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMLVEMPTYMARKUP.xml' path='doc/member[@name="NMLVEMPTYMARKUP.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='NMLVEMPTYMARKUP.xml' path='doc/member[@name="NMLVEMPTYMARKUP.szMarkup"]/*' />
    [NativeTypeName("WCHAR[2084]")]
    public fixed ushort szMarkup[2084];
}
