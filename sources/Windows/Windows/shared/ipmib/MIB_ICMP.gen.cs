// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MIB_ICMP.xml' path='doc/member[@name="MIB_ICMP"]/*' />
public partial struct MIB_ICMP
{
    /// <include file='MIB_ICMP.xml' path='doc/member[@name="MIB_ICMP.stats"]/*' />
    public MIBICMPINFO stats;
}
