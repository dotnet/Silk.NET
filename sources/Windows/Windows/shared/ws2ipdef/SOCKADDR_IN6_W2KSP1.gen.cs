// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SOCKADDR_IN6_W2KSP1.xml' path='doc/member[@name="SOCKADDR_IN6_W2KSP1"]/*'/>
public partial struct SOCKADDR_IN6_W2KSP1
{
    /// <include file='SOCKADDR_IN6_W2KSP1.xml' path='doc/member[@name="SOCKADDR_IN6_W2KSP1.sin6_family"]/*'/>
    public short sin6_family;
    /// <include file='SOCKADDR_IN6_W2KSP1.xml' path='doc/member[@name="SOCKADDR_IN6_W2KSP1.sin6_port"]/*'/>
    public ushort sin6_port;
    /// <include file='SOCKADDR_IN6_W2KSP1.xml' path='doc/member[@name="SOCKADDR_IN6_W2KSP1.sin6_flowinfo"]/*'/>
    [NativeTypeName("ULONG")]
    public uint sin6_flowinfo;
    /// <include file='SOCKADDR_IN6_W2KSP1.xml' path='doc/member[@name="SOCKADDR_IN6_W2KSP1.sin6_addr"]/*'/>
    [NativeTypeName("struct in6_addr")]
    public IN6_ADDR sin6_addr;
    /// <include file='SOCKADDR_IN6_W2KSP1.xml' path='doc/member[@name="SOCKADDR_IN6_W2KSP1.sin6_scope_id"]/*'/>
    [NativeTypeName("ULONG")]
    public uint sin6_scope_id;
}