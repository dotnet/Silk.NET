// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='IPV6_MREQ.xml' path='doc/member[@name="IPV6_MREQ"]/*'/>
public partial struct IPV6_MREQ
{
    /// <include file='IPV6_MREQ.xml' path='doc/member[@name="IPV6_MREQ.ipv6mr_multiaddr"]/*'/>
    public IN6_ADDR ipv6mr_multiaddr;
    /// <include file='IPV6_MREQ.xml' path='doc/member[@name="IPV6_MREQ.ipv6mr_interface"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ipv6mr_interface;
}