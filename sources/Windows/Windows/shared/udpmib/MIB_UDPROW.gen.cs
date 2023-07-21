// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/udpmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MIB_UDPROW.xml' path='doc/member[@name="MIB_UDPROW"]/*' />
public partial struct MIB_UDPROW
{
    /// <include file='MIB_UDPROW.xml' path='doc/member[@name="MIB_UDPROW.dwLocalAddr"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLocalAddr;

    /// <include file='MIB_UDPROW.xml' path='doc/member[@name="MIB_UDPROW.dwLocalPort"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLocalPort;
}
