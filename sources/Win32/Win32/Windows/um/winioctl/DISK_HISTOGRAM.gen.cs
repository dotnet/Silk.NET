// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct DISK_HISTOGRAM
{
    public LARGE_INTEGER DiskSize;
    public LARGE_INTEGER Start;
    public LARGE_INTEGER End;
    public LARGE_INTEGER Average;
    public LARGE_INTEGER AverageRead;
    public LARGE_INTEGER AverageWrite;

    [NativeTypeName("DWORD")]
    public uint Granularity;

    [NativeTypeName("DWORD")]
    public uint Size;

    [NativeTypeName("DWORD")]
    public uint ReadCount;

    [NativeTypeName("DWORD")]
    public uint WriteCount;

    [NativeTypeName("PHISTOGRAM_BUCKET")]
    public HISTOGRAM_BUCKET* Histogram;
}
