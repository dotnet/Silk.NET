// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "DISK_SPACE_INFORMATION")]
    public unsafe partial struct DiskSpaceInformation
    {
        public DiskSpaceInformation
        (
            ulong? actualTotalAllocationUnits = null,
            ulong? actualAvailableAllocationUnits = null,
            ulong? actualPoolUnavailableAllocationUnits = null,
            ulong? callerTotalAllocationUnits = null,
            ulong? callerAvailableAllocationUnits = null,
            ulong? callerPoolUnavailableAllocationUnits = null,
            ulong? usedAllocationUnits = null,
            ulong? totalReservedAllocationUnits = null,
            ulong? volumeStorageReserveAllocationUnits = null,
            ulong? availableCommittedAllocationUnits = null,
            ulong? poolAvailableAllocationUnits = null,
            int? sectorsPerAllocationUnit = null,
            int? bytesPerSector = null
        ) : this()
        {
            if (actualTotalAllocationUnits is not null)
            {
                ActualTotalAllocationUnits = actualTotalAllocationUnits.Value;
            }

            if (actualAvailableAllocationUnits is not null)
            {
                ActualAvailableAllocationUnits = actualAvailableAllocationUnits.Value;
            }

            if (actualPoolUnavailableAllocationUnits is not null)
            {
                ActualPoolUnavailableAllocationUnits = actualPoolUnavailableAllocationUnits.Value;
            }

            if (callerTotalAllocationUnits is not null)
            {
                CallerTotalAllocationUnits = callerTotalAllocationUnits.Value;
            }

            if (callerAvailableAllocationUnits is not null)
            {
                CallerAvailableAllocationUnits = callerAvailableAllocationUnits.Value;
            }

            if (callerPoolUnavailableAllocationUnits is not null)
            {
                CallerPoolUnavailableAllocationUnits = callerPoolUnavailableAllocationUnits.Value;
            }

            if (usedAllocationUnits is not null)
            {
                UsedAllocationUnits = usedAllocationUnits.Value;
            }

            if (totalReservedAllocationUnits is not null)
            {
                TotalReservedAllocationUnits = totalReservedAllocationUnits.Value;
            }

            if (volumeStorageReserveAllocationUnits is not null)
            {
                VolumeStorageReserveAllocationUnits = volumeStorageReserveAllocationUnits.Value;
            }

            if (availableCommittedAllocationUnits is not null)
            {
                AvailableCommittedAllocationUnits = availableCommittedAllocationUnits.Value;
            }

            if (poolAvailableAllocationUnits is not null)
            {
                PoolAvailableAllocationUnits = poolAvailableAllocationUnits.Value;
            }

            if (sectorsPerAllocationUnit is not null)
            {
                SectorsPerAllocationUnit = sectorsPerAllocationUnit.Value;
            }

            if (bytesPerSector is not null)
            {
                BytesPerSector = bytesPerSector.Value;
            }
        }


        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "ActualTotalAllocationUnits")]
        public ulong ActualTotalAllocationUnits;

        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "ActualAvailableAllocationUnits")]
        public ulong ActualAvailableAllocationUnits;

        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "ActualPoolUnavailableAllocationUnits")]
        public ulong ActualPoolUnavailableAllocationUnits;

        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "CallerTotalAllocationUnits")]
        public ulong CallerTotalAllocationUnits;

        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "CallerAvailableAllocationUnits")]
        public ulong CallerAvailableAllocationUnits;

        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "CallerPoolUnavailableAllocationUnits")]
        public ulong CallerPoolUnavailableAllocationUnits;

        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "UsedAllocationUnits")]
        public ulong UsedAllocationUnits;

        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "TotalReservedAllocationUnits")]
        public ulong TotalReservedAllocationUnits;

        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "VolumeStorageReserveAllocationUnits")]
        public ulong VolumeStorageReserveAllocationUnits;

        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "AvailableCommittedAllocationUnits")]
        public ulong AvailableCommittedAllocationUnits;

        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "PoolAvailableAllocationUnits")]
        public ulong PoolAvailableAllocationUnits;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "SectorsPerAllocationUnit")]
        public int SectorsPerAllocationUnit;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "BytesPerSector")]
        public int BytesPerSector;
    }
}
