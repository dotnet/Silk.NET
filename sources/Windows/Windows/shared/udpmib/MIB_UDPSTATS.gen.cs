// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/udpmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MIB_UDPSTATS.xml' path='doc/member[@name="MIB_UDPSTATS"]/*' />
public partial struct MIB_UDPSTATS
{
    /// <include file='MIB_UDPSTATS.xml' path='doc/member[@name="MIB_UDPSTATS.dwInDatagrams"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwInDatagrams;

    /// <include file='MIB_UDPSTATS.xml' path='doc/member[@name="MIB_UDPSTATS.dwNoPorts"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwNoPorts;

    /// <include file='MIB_UDPSTATS.xml' path='doc/member[@name="MIB_UDPSTATS.dwInErrors"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwInErrors;

    /// <include file='MIB_UDPSTATS.xml' path='doc/member[@name="MIB_UDPSTATS.dwOutDatagrams"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwOutDatagrams;

    /// <include file='MIB_UDPSTATS.xml' path='doc/member[@name="MIB_UDPSTATS.dwNumAddrs"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwNumAddrs;
}
