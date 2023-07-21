// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DISK_HISTOGRAM.xml' path='doc/member[@name="DISK_HISTOGRAM"]/*' />
public unsafe partial struct DISK_HISTOGRAM
{
    /// <include file='DISK_HISTOGRAM.xml' path='doc/member[@name="DISK_HISTOGRAM.DiskSize"]/*' />
    public LARGE_INTEGER DiskSize;

    /// <include file='DISK_HISTOGRAM.xml' path='doc/member[@name="DISK_HISTOGRAM.Start"]/*' />
    public LARGE_INTEGER Start;

    /// <include file='DISK_HISTOGRAM.xml' path='doc/member[@name="DISK_HISTOGRAM.End"]/*' />
    public LARGE_INTEGER End;

    /// <include file='DISK_HISTOGRAM.xml' path='doc/member[@name="DISK_HISTOGRAM.Average"]/*' />
    public LARGE_INTEGER Average;

    /// <include file='DISK_HISTOGRAM.xml' path='doc/member[@name="DISK_HISTOGRAM.AverageRead"]/*' />
    public LARGE_INTEGER AverageRead;

    /// <include file='DISK_HISTOGRAM.xml' path='doc/member[@name="DISK_HISTOGRAM.AverageWrite"]/*' />
    public LARGE_INTEGER AverageWrite;

    /// <include file='DISK_HISTOGRAM.xml' path='doc/member[@name="DISK_HISTOGRAM.Granularity"]/*' />
    [NativeTypeName("DWORD")]
    public uint Granularity;

    /// <include file='DISK_HISTOGRAM.xml' path='doc/member[@name="DISK_HISTOGRAM.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='DISK_HISTOGRAM.xml' path='doc/member[@name="DISK_HISTOGRAM.ReadCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint ReadCount;

    /// <include file='DISK_HISTOGRAM.xml' path='doc/member[@name="DISK_HISTOGRAM.WriteCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint WriteCount;

    /// <include file='DISK_HISTOGRAM.xml' path='doc/member[@name="DISK_HISTOGRAM.Histogram"]/*' />
    [NativeTypeName("PHISTOGRAM_BUCKET")]
    public HISTOGRAM_BUCKET* Histogram;
}
