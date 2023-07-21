// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MIB_IPSTATS_FORWARDING.xml' path='doc/member[@name="MIB_IPSTATS_FORWARDING"]/*' />
public enum MIB_IPSTATS_FORWARDING
{
    /// <include file='MIB_IPSTATS_FORWARDING.xml' path='doc/member[@name="MIB_IPSTATS_FORWARDING.MIB_IP_FORWARDING"]/*' />
    MIB_IP_FORWARDING = 1,

    /// <include file='MIB_IPSTATS_FORWARDING.xml' path='doc/member[@name="MIB_IPSTATS_FORWARDING.MIB_IP_NOT_FORWARDING"]/*' />
    MIB_IP_NOT_FORWARDING = 2,
}
