// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/fileapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DISK_SPACE_INFORMATION
{
    [NativeTypeName("ULONGLONG")]
    public ulong ActualTotalAllocationUnits;

    [NativeTypeName("ULONGLONG")]
    public ulong ActualAvailableAllocationUnits;

    [NativeTypeName("ULONGLONG")]
    public ulong ActualPoolUnavailableAllocationUnits;

    [NativeTypeName("ULONGLONG")]
    public ulong CallerTotalAllocationUnits;

    [NativeTypeName("ULONGLONG")]
    public ulong CallerAvailableAllocationUnits;

    [NativeTypeName("ULONGLONG")]
    public ulong CallerPoolUnavailableAllocationUnits;

    [NativeTypeName("ULONGLONG")]
    public ulong UsedAllocationUnits;

    [NativeTypeName("ULONGLONG")]
    public ulong TotalReservedAllocationUnits;

    [NativeTypeName("ULONGLONG")]
    public ulong VolumeStorageReserveAllocationUnits;

    [NativeTypeName("ULONGLONG")]
    public ulong AvailableCommittedAllocationUnits;

    [NativeTypeName("ULONGLONG")]
    public ulong PoolAvailableAllocationUnits;

    [NativeTypeName("DWORD")]
    public uint SectorsPerAllocationUnit;

    [NativeTypeName("DWORD")]
    public uint BytesPerSector;
}
