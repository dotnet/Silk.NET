// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ifdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NET_IF_CONNECTION_TYPE.xml' path='doc/member[@name="NET_IF_CONNECTION_TYPE"]/*' />
public enum NET_IF_CONNECTION_TYPE
{
    /// <include file='NET_IF_CONNECTION_TYPE.xml' path='doc/member[@name="NET_IF_CONNECTION_TYPE.NET_IF_CONNECTION_DEDICATED"]/*' />
    NET_IF_CONNECTION_DEDICATED = 1,

    /// <include file='NET_IF_CONNECTION_TYPE.xml' path='doc/member[@name="NET_IF_CONNECTION_TYPE.NET_IF_CONNECTION_PASSIVE"]/*' />
    NET_IF_CONNECTION_PASSIVE = 2,

    /// <include file='NET_IF_CONNECTION_TYPE.xml' path='doc/member[@name="NET_IF_CONNECTION_TYPE.NET_IF_CONNECTION_DEMAND"]/*' />
    NET_IF_CONNECTION_DEMAND = 3,

    /// <include file='NET_IF_CONNECTION_TYPE.xml' path='doc/member[@name="NET_IF_CONNECTION_TYPE.NET_IF_CONNECTION_MAXIMUM"]/*' />
    NET_IF_CONNECTION_MAXIMUM = 4,
}
