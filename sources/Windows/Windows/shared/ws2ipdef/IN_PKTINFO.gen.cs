// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='IN_PKTINFO.xml' path='doc/member[@name="IN_PKTINFO"]/*'/>
public partial struct IN_PKTINFO
{
    /// <include file='IN_PKTINFO.xml' path='doc/member[@name="IN_PKTINFO.ipi_addr"]/*'/>
    public IN_ADDR ipi_addr;
    /// <include file='IN_PKTINFO.xml' path='doc/member[@name="IN_PKTINFO.ipi_ifindex"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ipi_ifindex;
}