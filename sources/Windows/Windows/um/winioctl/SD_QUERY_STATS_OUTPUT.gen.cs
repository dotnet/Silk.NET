// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SD_QUERY_STATS_OUTPUT.xml' path='doc/member[@name="SD_QUERY_STATS_OUTPUT"]/*' />
public partial struct SD_QUERY_STATS_OUTPUT
{
    /// <include file='SD_QUERY_STATS_OUTPUT.xml' path='doc/member[@name="SD_QUERY_STATS_OUTPUT.SdsStreamSize"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong SdsStreamSize;

    /// <include file='SD_QUERY_STATS_OUTPUT.xml' path='doc/member[@name="SD_QUERY_STATS_OUTPUT.SdsAllocationSize"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong SdsAllocationSize;

    /// <include file='SD_QUERY_STATS_OUTPUT.xml' path='doc/member[@name="SD_QUERY_STATS_OUTPUT.SiiStreamSize"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong SiiStreamSize;

    /// <include file='SD_QUERY_STATS_OUTPUT.xml' path='doc/member[@name="SD_QUERY_STATS_OUTPUT.SiiAllocationSize"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong SiiAllocationSize;

    /// <include file='SD_QUERY_STATS_OUTPUT.xml' path='doc/member[@name="SD_QUERY_STATS_OUTPUT.SdhStreamSize"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong SdhStreamSize;

    /// <include file='SD_QUERY_STATS_OUTPUT.xml' path='doc/member[@name="SD_QUERY_STATS_OUTPUT.SdhAllocationSize"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong SdhAllocationSize;

    /// <include file='SD_QUERY_STATS_OUTPUT.xml' path='doc/member[@name="SD_QUERY_STATS_OUTPUT.NumSDTotal"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong NumSDTotal;

    /// <include file='SD_QUERY_STATS_OUTPUT.xml' path='doc/member[@name="SD_QUERY_STATS_OUTPUT.NumSDUnused"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong NumSDUnused;
}
