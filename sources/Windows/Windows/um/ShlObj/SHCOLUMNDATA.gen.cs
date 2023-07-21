// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SHCOLUMNDATA.xml' path='doc/member[@name="SHCOLUMNDATA"]/*' />
public unsafe partial struct SHCOLUMNDATA
{
    /// <include file='SHCOLUMNDATA.xml' path='doc/member[@name="SHCOLUMNDATA.dwFlags"]/*' />
    [NativeTypeName("ULONG")]
    public uint dwFlags;

    /// <include file='SHCOLUMNDATA.xml' path='doc/member[@name="SHCOLUMNDATA.dwFileAttributes"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFileAttributes;

    /// <include file='SHCOLUMNDATA.xml' path='doc/member[@name="SHCOLUMNDATA.dwReserved"]/*' />
    [NativeTypeName("ULONG")]
    public uint dwReserved;

    /// <include file='SHCOLUMNDATA.xml' path='doc/member[@name="SHCOLUMNDATA.pwszExt"]/*' />
    [NativeTypeName("WCHAR *")]
    public ushort* pwszExt;

    /// <include file='SHCOLUMNDATA.xml' path='doc/member[@name="SHCOLUMNDATA.wszFile"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public fixed ushort wszFile[260];
}
