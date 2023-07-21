// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MIBICMPSTATS_EX_XPSP1.xml' path='doc/member[@name="MIBICMPSTATS_EX_XPSP1"]/*' />
public unsafe partial struct MIBICMPSTATS_EX_XPSP1
{
    /// <include file='MIBICMPSTATS_EX_XPSP1.xml' path='doc/member[@name="MIBICMPSTATS_EX_XPSP1.dwMsgs"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMsgs;

    /// <include file='MIBICMPSTATS_EX_XPSP1.xml' path='doc/member[@name="MIBICMPSTATS_EX_XPSP1.dwErrors"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwErrors;

    /// <include file='MIBICMPSTATS_EX_XPSP1.xml' path='doc/member[@name="MIBICMPSTATS_EX_XPSP1.rgdwTypeCount"]/*' />
    [NativeTypeName("DWORD[256]")]
    public fixed uint rgdwTypeCount[256];
}
