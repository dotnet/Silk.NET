// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MIB_IPNET_TYPE.xml' path='doc/member[@name="MIB_IPNET_TYPE"]/*' />
public enum MIB_IPNET_TYPE
{
    /// <include file='MIB_IPNET_TYPE.xml' path='doc/member[@name="MIB_IPNET_TYPE.MIB_IPNET_TYPE_OTHER"]/*' />
    MIB_IPNET_TYPE_OTHER = 1,

    /// <include file='MIB_IPNET_TYPE.xml' path='doc/member[@name="MIB_IPNET_TYPE.MIB_IPNET_TYPE_INVALID"]/*' />
    MIB_IPNET_TYPE_INVALID = 2,

    /// <include file='MIB_IPNET_TYPE.xml' path='doc/member[@name="MIB_IPNET_TYPE.MIB_IPNET_TYPE_DYNAMIC"]/*' />
    MIB_IPNET_TYPE_DYNAMIC = 3,

    /// <include file='MIB_IPNET_TYPE.xml' path='doc/member[@name="MIB_IPNET_TYPE.MIB_IPNET_TYPE_STATIC"]/*' />
    MIB_IPNET_TYPE_STATIC = 4,
}
