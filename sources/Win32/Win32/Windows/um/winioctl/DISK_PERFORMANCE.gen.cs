// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DISK_PERFORMANCE
{
    public LARGE_INTEGER BytesRead;
    public LARGE_INTEGER BytesWritten;
    public LARGE_INTEGER ReadTime;
    public LARGE_INTEGER WriteTime;
    public LARGE_INTEGER IdleTime;

    [NativeTypeName("DWORD")]
    public uint ReadCount;

    [NativeTypeName("DWORD")]
    public uint WriteCount;

    [NativeTypeName("DWORD")]
    public uint QueueDepth;

    [NativeTypeName("DWORD")]
    public uint SplitCount;
    public LARGE_INTEGER QueryTime;

    [NativeTypeName("DWORD")]
    public uint StorageDeviceNumber;

    [NativeTypeName("WCHAR[8]")]
    public _StorageManagerName_e__FixedBuffer StorageManagerName;

    [InlineArray(8)]
    public partial struct _StorageManagerName_e__FixedBuffer
    {
        public ushort e0;
    }
}
