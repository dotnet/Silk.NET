// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DROPSTRUCT.xml' path='doc/member[@name="DROPSTRUCT"]/*' />
public partial struct DROPSTRUCT
{
    /// <include file='DROPSTRUCT.xml' path='doc/member[@name="DROPSTRUCT.hwndSource"]/*' />
    public HWND hwndSource;

    /// <include file='DROPSTRUCT.xml' path='doc/member[@name="DROPSTRUCT.hwndSink"]/*' />
    public HWND hwndSink;

    /// <include file='DROPSTRUCT.xml' path='doc/member[@name="DROPSTRUCT.wFmt"]/*' />
    [NativeTypeName("DWORD")]
    public uint wFmt;

    /// <include file='DROPSTRUCT.xml' path='doc/member[@name="DROPSTRUCT.dwData"]/*' />
    [NativeTypeName("ULONG_PTR")]
    public nuint dwData;

    /// <include file='DROPSTRUCT.xml' path='doc/member[@name="DROPSTRUCT.ptDrop"]/*' />
    public POINT ptDrop;

    /// <include file='DROPSTRUCT.xml' path='doc/member[@name="DROPSTRUCT.dwControlData"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwControlData;
}
