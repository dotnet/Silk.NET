// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='SOCKADDR_INET.xml' path='doc/member[@name="SOCKADDR_INET"]/*'/>
[StructLayout(LayoutKind.Explicit)]
public partial struct SOCKADDR_INET
{
    /// <include file='SOCKADDR_INET.xml' path='doc/member[@name="SOCKADDR_INET.Ipv4"]/*'/>
    [FieldOffset(0)]
    public SOCKADDR_IN Ipv4;
    /// <include file='SOCKADDR_INET.xml' path='doc/member[@name="SOCKADDR_INET.Ipv6"]/*'/>
    [FieldOffset(0)]
    public SOCKADDR_IN6 Ipv6;
    /// <include file='SOCKADDR_INET.xml' path='doc/member[@name="SOCKADDR_INET.si_family"]/*'/>
    [FieldOffset(0)]
    [NativeTypeName("ADDRESS_FAMILY")]
    public ushort si_family;
}