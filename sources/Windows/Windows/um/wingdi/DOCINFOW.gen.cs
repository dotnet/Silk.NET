// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DOCINFOW.xml' path='doc/member[@name="DOCINFOW"]/*' />
public unsafe partial struct DOCINFOW
{
    /// <include file='DOCINFOW.xml' path='doc/member[@name="DOCINFOW.cbSize"]/*' />
    public int cbSize;

    /// <include file='DOCINFOW.xml' path='doc/member[@name="DOCINFOW.lpszDocName"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* lpszDocName;

    /// <include file='DOCINFOW.xml' path='doc/member[@name="DOCINFOW.lpszOutput"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* lpszOutput;

    /// <include file='DOCINFOW.xml' path='doc/member[@name="DOCINFOW.lpszDatatype"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* lpszDatatype;

    /// <include file='DOCINFOW.xml' path='doc/member[@name="DOCINFOW.fwType"]/*' />
    [NativeTypeName("DWORD")]
    public uint fwType;
}
