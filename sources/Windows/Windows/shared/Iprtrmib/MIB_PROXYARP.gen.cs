// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/Iprtrmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MIB_PROXYARP.xml' path='doc/member[@name="MIB_PROXYARP"]/*' />
public partial struct MIB_PROXYARP
{
    /// <include file='MIB_PROXYARP.xml' path='doc/member[@name="MIB_PROXYARP.dwAddress"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAddress;

    /// <include file='MIB_PROXYARP.xml' path='doc/member[@name="MIB_PROXYARP.dwMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMask;

    /// <include file='MIB_PROXYARP.xml' path='doc/member[@name="MIB_PROXYARP.dwIfIndex"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwIfIndex;
}
