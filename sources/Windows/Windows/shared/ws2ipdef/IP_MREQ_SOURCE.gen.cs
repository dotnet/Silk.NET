// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='IP_MREQ_SOURCE.xml' path='doc/member[@name="IP_MREQ_SOURCE"]/*'/>
public partial struct IP_MREQ_SOURCE
{
    /// <include file='IP_MREQ_SOURCE.xml' path='doc/member[@name="IP_MREQ_SOURCE.imr_multiaddr"]/*'/>
    public IN_ADDR imr_multiaddr;
    /// <include file='IP_MREQ_SOURCE.xml' path='doc/member[@name="IP_MREQ_SOURCE.imr_sourceaddr"]/*'/>
    public IN_ADDR imr_sourceaddr;
    /// <include file='IP_MREQ_SOURCE.xml' path='doc/member[@name="IP_MREQ_SOURCE.imr_interface"]/*'/>
    public IN_ADDR imr_interface;
}