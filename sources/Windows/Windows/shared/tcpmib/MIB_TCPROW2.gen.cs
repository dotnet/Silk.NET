// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tcpmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MIB_TCPROW2.xml' path='doc/member[@name="MIB_TCPROW2"]/*'/>
public partial struct MIB_TCPROW2
{
    /// <include file='MIB_TCPROW2.xml' path='doc/member[@name="MIB_TCPROW2.dwState"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwState;
    /// <include file='MIB_TCPROW2.xml' path='doc/member[@name="MIB_TCPROW2.dwLocalAddr"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwLocalAddr;
    /// <include file='MIB_TCPROW2.xml' path='doc/member[@name="MIB_TCPROW2.dwLocalPort"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwLocalPort;
    /// <include file='MIB_TCPROW2.xml' path='doc/member[@name="MIB_TCPROW2.dwRemoteAddr"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRemoteAddr;
    /// <include file='MIB_TCPROW2.xml' path='doc/member[@name="MIB_TCPROW2.dwRemotePort"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRemotePort;
    /// <include file='MIB_TCPROW2.xml' path='doc/member[@name="MIB_TCPROW2.dwOwningPid"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwOwningPid;
    /// <include file='MIB_TCPROW2.xml' path='doc/member[@name="MIB_TCPROW2.dwOffloadState"]/*'/>
    public TCP_CONNECTION_OFFLOAD_STATE dwOffloadState;
}