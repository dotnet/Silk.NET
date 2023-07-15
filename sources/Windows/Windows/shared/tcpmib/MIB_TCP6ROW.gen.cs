// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tcpmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MIB_TCP6ROW.xml' path='doc/member[@name="MIB_TCP6ROW"]/*'/>
public partial struct MIB_TCP6ROW
{
    /// <include file='MIB_TCP6ROW.xml' path='doc/member[@name="MIB_TCP6ROW.State"]/*'/>
    public MIB_TCP_STATE State;
    /// <include file='MIB_TCP6ROW.xml' path='doc/member[@name="MIB_TCP6ROW.LocalAddr"]/*'/>
    public IN6_ADDR LocalAddr;
    /// <include file='MIB_TCP6ROW.xml' path='doc/member[@name="MIB_TCP6ROW.dwLocalScopeId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwLocalScopeId;
    /// <include file='MIB_TCP6ROW.xml' path='doc/member[@name="MIB_TCP6ROW.dwLocalPort"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwLocalPort;
    /// <include file='MIB_TCP6ROW.xml' path='doc/member[@name="MIB_TCP6ROW.RemoteAddr"]/*'/>
    public IN6_ADDR RemoteAddr;
    /// <include file='MIB_TCP6ROW.xml' path='doc/member[@name="MIB_TCP6ROW.dwRemoteScopeId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRemoteScopeId;
    /// <include file='MIB_TCP6ROW.xml' path='doc/member[@name="MIB_TCP6ROW.dwRemotePort"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRemotePort;
}