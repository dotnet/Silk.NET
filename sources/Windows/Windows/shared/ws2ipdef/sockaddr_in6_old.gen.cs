// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='sockaddr_in6_old.xml' path='doc/member[@name="sockaddr_in6_old"]/*'/>
public partial struct sockaddr_in6_old
{
    /// <include file='sockaddr_in6_old.xml' path='doc/member[@name="sockaddr_in6_old.sin6_family"]/*'/>
    public short sin6_family;
    /// <include file='sockaddr_in6_old.xml' path='doc/member[@name="sockaddr_in6_old.sin6_port"]/*'/>
    public ushort sin6_port;
    /// <include file='sockaddr_in6_old.xml' path='doc/member[@name="sockaddr_in6_old.sin6_flowinfo"]/*'/>
    [NativeTypeName("ULONG")]
    public uint sin6_flowinfo;
    /// <include file='sockaddr_in6_old.xml' path='doc/member[@name="sockaddr_in6_old.sin6_addr"]/*'/>
    public IN6_ADDR sin6_addr;
}