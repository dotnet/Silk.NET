// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/nldef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IP_PREFIX_ORIGIN.xml' path='doc/member[@name="IP_PREFIX_ORIGIN"]/*' />
public enum IP_PREFIX_ORIGIN
{
    /// <include file='IP_PREFIX_ORIGIN.xml' path='doc/member[@name="IP_PREFIX_ORIGIN.IpPrefixOriginOther"]/*' />
    IpPrefixOriginOther = 0,

    /// <include file='IP_PREFIX_ORIGIN.xml' path='doc/member[@name="IP_PREFIX_ORIGIN.IpPrefixOriginManual"]/*' />
    IpPrefixOriginManual,

    /// <include file='IP_PREFIX_ORIGIN.xml' path='doc/member[@name="IP_PREFIX_ORIGIN.IpPrefixOriginWellKnown"]/*' />
    IpPrefixOriginWellKnown,

    /// <include file='IP_PREFIX_ORIGIN.xml' path='doc/member[@name="IP_PREFIX_ORIGIN.IpPrefixOriginDhcp"]/*' />
    IpPrefixOriginDhcp,

    /// <include file='IP_PREFIX_ORIGIN.xml' path='doc/member[@name="IP_PREFIX_ORIGIN.IpPrefixOriginRouterAdvertisement"]/*' />
    IpPrefixOriginRouterAdvertisement,

    /// <include file='IP_PREFIX_ORIGIN.xml' path='doc/member[@name="IP_PREFIX_ORIGIN.IpPrefixOriginUnchanged"]/*' />
    IpPrefixOriginUnchanged = 1 << 4,
}
