// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tcpmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MIB_TCP6ROW2.xml' path='doc/member[@name="MIB_TCP6ROW2"]/*'/>
public partial struct MIB_TCP6ROW2
{
    /// <include file='MIB_TCP6ROW2.xml' path='doc/member[@name="MIB_TCP6ROW2.LocalAddr"]/*'/>
    public IN6_ADDR LocalAddr;
    /// <include file='MIB_TCP6ROW2.xml' path='doc/member[@name="MIB_TCP6ROW2.dwLocalScopeId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwLocalScopeId;
    /// <include file='MIB_TCP6ROW2.xml' path='doc/member[@name="MIB_TCP6ROW2.dwLocalPort"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwLocalPort;
    /// <include file='MIB_TCP6ROW2.xml' path='doc/member[@name="MIB_TCP6ROW2.RemoteAddr"]/*'/>
    public IN6_ADDR RemoteAddr;
    /// <include file='MIB_TCP6ROW2.xml' path='doc/member[@name="MIB_TCP6ROW2.dwRemoteScopeId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRemoteScopeId;
    /// <include file='MIB_TCP6ROW2.xml' path='doc/member[@name="MIB_TCP6ROW2.dwRemotePort"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRemotePort;
    /// <include file='MIB_TCP6ROW2.xml' path='doc/member[@name="MIB_TCP6ROW2.State"]/*'/>
    public MIB_TCP_STATE State;
    /// <include file='MIB_TCP6ROW2.xml' path='doc/member[@name="MIB_TCP6ROW2.dwOwningPid"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwOwningPid;
    /// <include file='MIB_TCP6ROW2.xml' path='doc/member[@name="MIB_TCP6ROW2.dwOffloadState"]/*'/>
    public TCP_CONNECTION_OFFLOAD_STATE dwOffloadState;
}