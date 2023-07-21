// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnetwk.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NETRESOURCEA.xml' path='doc/member[@name="NETRESOURCEA"]/*' />
public unsafe partial struct NETRESOURCEA
{
    /// <include file='NETRESOURCEA.xml' path='doc/member[@name="NETRESOURCEA.dwScope"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwScope;

    /// <include file='NETRESOURCEA.xml' path='doc/member[@name="NETRESOURCEA.dwType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwType;

    /// <include file='NETRESOURCEA.xml' path='doc/member[@name="NETRESOURCEA.dwDisplayType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDisplayType;

    /// <include file='NETRESOURCEA.xml' path='doc/member[@name="NETRESOURCEA.dwUsage"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwUsage;

    /// <include file='NETRESOURCEA.xml' path='doc/member[@name="NETRESOURCEA.lpLocalName"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* lpLocalName;

    /// <include file='NETRESOURCEA.xml' path='doc/member[@name="NETRESOURCEA.lpRemoteName"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* lpRemoteName;

    /// <include file='NETRESOURCEA.xml' path='doc/member[@name="NETRESOURCEA.lpComment"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* lpComment;

    /// <include file='NETRESOURCEA.xml' path='doc/member[@name="NETRESOURCEA.lpProvider"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* lpProvider;
}
