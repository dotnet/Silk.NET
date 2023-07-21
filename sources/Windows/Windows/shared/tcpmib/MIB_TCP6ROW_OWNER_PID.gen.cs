// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/tcpmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MIB_TCP6ROW_OWNER_PID.xml' path='doc/member[@name="MIB_TCP6ROW_OWNER_PID"]/*' />
public unsafe partial struct MIB_TCP6ROW_OWNER_PID
{
    /// <include file='MIB_TCP6ROW_OWNER_PID.xml' path='doc/member[@name="MIB_TCP6ROW_OWNER_PID.ucLocalAddr"]/*' />
    [NativeTypeName("UCHAR[16]")]
    public fixed byte ucLocalAddr[16];

    /// <include file='MIB_TCP6ROW_OWNER_PID.xml' path='doc/member[@name="MIB_TCP6ROW_OWNER_PID.dwLocalScopeId"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLocalScopeId;

    /// <include file='MIB_TCP6ROW_OWNER_PID.xml' path='doc/member[@name="MIB_TCP6ROW_OWNER_PID.dwLocalPort"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLocalPort;

    /// <include file='MIB_TCP6ROW_OWNER_PID.xml' path='doc/member[@name="MIB_TCP6ROW_OWNER_PID.ucRemoteAddr"]/*' />
    [NativeTypeName("UCHAR[16]")]
    public fixed byte ucRemoteAddr[16];

    /// <include file='MIB_TCP6ROW_OWNER_PID.xml' path='doc/member[@name="MIB_TCP6ROW_OWNER_PID.dwRemoteScopeId"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRemoteScopeId;

    /// <include file='MIB_TCP6ROW_OWNER_PID.xml' path='doc/member[@name="MIB_TCP6ROW_OWNER_PID.dwRemotePort"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRemotePort;

    /// <include file='MIB_TCP6ROW_OWNER_PID.xml' path='doc/member[@name="MIB_TCP6ROW_OWNER_PID.dwState"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwState;

    /// <include file='MIB_TCP6ROW_OWNER_PID.xml' path='doc/member[@name="MIB_TCP6ROW_OWNER_PID.dwOwningPid"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwOwningPid;
}
