// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IN6_PKTINFO.xml' path='doc/member[@name="IN6_PKTINFO"]/*' />
public partial struct IN6_PKTINFO
{
    /// <include file='IN6_PKTINFO.xml' path='doc/member[@name="IN6_PKTINFO.ipi6_addr"]/*' />
    public IN6_ADDR ipi6_addr;

    /// <include file='IN6_PKTINFO.xml' path='doc/member[@name="IN6_PKTINFO.ipi6_ifindex"]/*' />
    [NativeTypeName("ULONG")]
    public uint ipi6_ifindex;
}
