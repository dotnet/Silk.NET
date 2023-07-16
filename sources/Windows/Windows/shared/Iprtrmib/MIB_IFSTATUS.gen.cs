// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/Iprtrmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MIB_IFSTATUS.xml' path='doc/member[@name="MIB_IFSTATUS"]/*'/>
public partial struct MIB_IFSTATUS
{
    /// <include file='MIB_IFSTATUS.xml' path='doc/member[@name="MIB_IFSTATUS.dwIfIndex"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwIfIndex;
    /// <include file='MIB_IFSTATUS.xml' path='doc/member[@name="MIB_IFSTATUS.dwAdminStatus"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAdminStatus;
    /// <include file='MIB_IFSTATUS.xml' path='doc/member[@name="MIB_IFSTATUS.dwOperationalStatus"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwOperationalStatus;
    /// <include file='MIB_IFSTATUS.xml' path='doc/member[@name="MIB_IFSTATUS.bMHbeatActive"]/*'/>
    public BOOL bMHbeatActive;
    /// <include file='MIB_IFSTATUS.xml' path='doc/member[@name="MIB_IFSTATUS.bMHbeatAlive"]/*'/>
    public BOOL bMHbeatAlive;
}