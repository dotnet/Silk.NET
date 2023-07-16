// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='JOBOBJECT_IO_ATTRIBUTION_STATS.xml' path='doc/member[@name="JOBOBJECT_IO_ATTRIBUTION_STATS"]/*'/>
public partial struct JOBOBJECT_IO_ATTRIBUTION_STATS
{
    /// <include file='JOBOBJECT_IO_ATTRIBUTION_STATS.xml' path='doc/member[@name="JOBOBJECT_IO_ATTRIBUTION_STATS.IoCount"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint IoCount;
    /// <include file='JOBOBJECT_IO_ATTRIBUTION_STATS.xml' path='doc/member[@name="JOBOBJECT_IO_ATTRIBUTION_STATS.TotalNonOverlappedQueueTime"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong TotalNonOverlappedQueueTime;
    /// <include file='JOBOBJECT_IO_ATTRIBUTION_STATS.xml' path='doc/member[@name="JOBOBJECT_IO_ATTRIBUTION_STATS.TotalNonOverlappedServiceTime"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong TotalNonOverlappedServiceTime;
    /// <include file='JOBOBJECT_IO_ATTRIBUTION_STATS.xml' path='doc/member[@name="JOBOBJECT_IO_ATTRIBUTION_STATS.TotalSize"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong TotalSize;
}