// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tcpmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MIB_TCPROW_W2K.xml' path='doc/member[@name="MIB_TCPROW_W2K"]/*'/>
public partial struct MIB_TCPROW_W2K
{
    /// <include file='MIB_TCPROW_W2K.xml' path='doc/member[@name="MIB_TCPROW_W2K.dwState"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwState;
    /// <include file='MIB_TCPROW_W2K.xml' path='doc/member[@name="MIB_TCPROW_W2K.dwLocalAddr"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwLocalAddr;
    /// <include file='MIB_TCPROW_W2K.xml' path='doc/member[@name="MIB_TCPROW_W2K.dwLocalPort"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwLocalPort;
    /// <include file='MIB_TCPROW_W2K.xml' path='doc/member[@name="MIB_TCPROW_W2K.dwRemoteAddr"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRemoteAddr;
    /// <include file='MIB_TCPROW_W2K.xml' path='doc/member[@name="MIB_TCPROW_W2K.dwRemotePort"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRemotePort;
}