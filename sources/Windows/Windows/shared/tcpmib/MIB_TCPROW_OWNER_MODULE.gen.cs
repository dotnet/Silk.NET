// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/tcpmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MIB_TCPROW_OWNER_MODULE.xml' path='doc/member[@name="MIB_TCPROW_OWNER_MODULE"]/*' />
public unsafe partial struct MIB_TCPROW_OWNER_MODULE
{
    /// <include file='MIB_TCPROW_OWNER_MODULE.xml' path='doc/member[@name="MIB_TCPROW_OWNER_MODULE.dwState"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwState;

    /// <include file='MIB_TCPROW_OWNER_MODULE.xml' path='doc/member[@name="MIB_TCPROW_OWNER_MODULE.dwLocalAddr"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLocalAddr;

    /// <include file='MIB_TCPROW_OWNER_MODULE.xml' path='doc/member[@name="MIB_TCPROW_OWNER_MODULE.dwLocalPort"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLocalPort;

    /// <include file='MIB_TCPROW_OWNER_MODULE.xml' path='doc/member[@name="MIB_TCPROW_OWNER_MODULE.dwRemoteAddr"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRemoteAddr;

    /// <include file='MIB_TCPROW_OWNER_MODULE.xml' path='doc/member[@name="MIB_TCPROW_OWNER_MODULE.dwRemotePort"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRemotePort;

    /// <include file='MIB_TCPROW_OWNER_MODULE.xml' path='doc/member[@name="MIB_TCPROW_OWNER_MODULE.dwOwningPid"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwOwningPid;

    /// <include file='MIB_TCPROW_OWNER_MODULE.xml' path='doc/member[@name="MIB_TCPROW_OWNER_MODULE.liCreateTimestamp"]/*' />
    public LARGE_INTEGER liCreateTimestamp;

    /// <include file='MIB_TCPROW_OWNER_MODULE.xml' path='doc/member[@name="MIB_TCPROW_OWNER_MODULE.OwningModuleInfo"]/*' />
    [NativeTypeName("ULONGLONG[16]")]
    public fixed ulong OwningModuleInfo[16];
}
