// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='LVINSERTMARK.xml' path='doc/member[@name="LVINSERTMARK"]/*' />
public partial struct LVINSERTMARK
{
    /// <include file='LVINSERTMARK.xml' path='doc/member[@name="LVINSERTMARK.cbSize"]/*' />
    public uint cbSize;

    /// <include file='LVINSERTMARK.xml' path='doc/member[@name="LVINSERTMARK.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='LVINSERTMARK.xml' path='doc/member[@name="LVINSERTMARK.iItem"]/*' />
    public int iItem;

    /// <include file='LVINSERTMARK.xml' path='doc/member[@name="LVINSERTMARK.dwReserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwReserved;
}
