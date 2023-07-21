// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/fileapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DISK_SPACE_INFORMATION.xml' path='doc/member[@name="DISK_SPACE_INFORMATION"]/*' />
public partial struct DISK_SPACE_INFORMATION
{
    /// <include file='DISK_SPACE_INFORMATION.xml' path='doc/member[@name="DISK_SPACE_INFORMATION.ActualTotalAllocationUnits"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ActualTotalAllocationUnits;

    /// <include file='DISK_SPACE_INFORMATION.xml' path='doc/member[@name="DISK_SPACE_INFORMATION.ActualAvailableAllocationUnits"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ActualAvailableAllocationUnits;

    /// <include file='DISK_SPACE_INFORMATION.xml' path='doc/member[@name="DISK_SPACE_INFORMATION.ActualPoolUnavailableAllocationUnits"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ActualPoolUnavailableAllocationUnits;

    /// <include file='DISK_SPACE_INFORMATION.xml' path='doc/member[@name="DISK_SPACE_INFORMATION.CallerTotalAllocationUnits"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong CallerTotalAllocationUnits;

    /// <include file='DISK_SPACE_INFORMATION.xml' path='doc/member[@name="DISK_SPACE_INFORMATION.CallerAvailableAllocationUnits"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong CallerAvailableAllocationUnits;

    /// <include file='DISK_SPACE_INFORMATION.xml' path='doc/member[@name="DISK_SPACE_INFORMATION.CallerPoolUnavailableAllocationUnits"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong CallerPoolUnavailableAllocationUnits;

    /// <include file='DISK_SPACE_INFORMATION.xml' path='doc/member[@name="DISK_SPACE_INFORMATION.UsedAllocationUnits"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong UsedAllocationUnits;

    /// <include file='DISK_SPACE_INFORMATION.xml' path='doc/member[@name="DISK_SPACE_INFORMATION.TotalReservedAllocationUnits"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong TotalReservedAllocationUnits;

    /// <include file='DISK_SPACE_INFORMATION.xml' path='doc/member[@name="DISK_SPACE_INFORMATION.VolumeStorageReserveAllocationUnits"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong VolumeStorageReserveAllocationUnits;

    /// <include file='DISK_SPACE_INFORMATION.xml' path='doc/member[@name="DISK_SPACE_INFORMATION.AvailableCommittedAllocationUnits"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong AvailableCommittedAllocationUnits;

    /// <include file='DISK_SPACE_INFORMATION.xml' path='doc/member[@name="DISK_SPACE_INFORMATION.PoolAvailableAllocationUnits"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong PoolAvailableAllocationUnits;

    /// <include file='DISK_SPACE_INFORMATION.xml' path='doc/member[@name="DISK_SPACE_INFORMATION.SectorsPerAllocationUnit"]/*' />
    [NativeTypeName("DWORD")]
    public uint SectorsPerAllocationUnit;

    /// <include file='DISK_SPACE_INFORMATION.xml' path='doc/member[@name="DISK_SPACE_INFORMATION.BytesPerSector"]/*' />
    [NativeTypeName("DWORD")]
    public uint BytesPerSector;
}
