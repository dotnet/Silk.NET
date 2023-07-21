// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MULTICAST_MODE_TYPE.xml' path='doc/member[@name="MULTICAST_MODE_TYPE"]/*' />
public enum MULTICAST_MODE_TYPE
{
    /// <include file='MULTICAST_MODE_TYPE.xml' path='doc/member[@name="MULTICAST_MODE_TYPE.MCAST_INCLUDE"]/*' />
    MCAST_INCLUDE = 0,

    /// <include file='MULTICAST_MODE_TYPE.xml' path='doc/member[@name="MULTICAST_MODE_TYPE.MCAST_EXCLUDE"]/*' />
    MCAST_EXCLUDE,
}
