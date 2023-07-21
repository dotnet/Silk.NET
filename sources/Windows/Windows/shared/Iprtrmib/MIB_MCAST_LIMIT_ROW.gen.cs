// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/Iprtrmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MIB_MCAST_LIMIT_ROW.xml' path='doc/member[@name="MIB_MCAST_LIMIT_ROW"]/*' />
public partial struct MIB_MCAST_LIMIT_ROW
{
    /// <include file='MIB_MCAST_LIMIT_ROW.xml' path='doc/member[@name="MIB_MCAST_LIMIT_ROW.dwTtl"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwTtl;

    /// <include file='MIB_MCAST_LIMIT_ROW.xml' path='doc/member[@name="MIB_MCAST_LIMIT_ROW.dwRateLimit"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRateLimit;
}
