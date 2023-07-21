// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IN_PKTINFO_EX.xml' path='doc/member[@name="IN_PKTINFO_EX"]/*' />
public partial struct IN_PKTINFO_EX
{
    /// <include file='IN_PKTINFO_EX.xml' path='doc/member[@name="IN_PKTINFO_EX.pkt_info"]/*' />
    public IN_PKTINFO pkt_info;

    /// <include file='IN_PKTINFO_EX.xml' path='doc/member[@name="IN_PKTINFO_EX.scope_id"]/*' />
    public SCOPE_ID scope_id;
}
