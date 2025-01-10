// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SCRUB_DATA_OUTPUT
{
    [NativeTypeName("DWORD")]
    public uint Size;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("DWORD")]
    public uint Status;

    [NativeTypeName("ULONGLONG")]
    public ulong ErrorFileOffset;

    [NativeTypeName("ULONGLONG")]
    public ulong ErrorLength;

    [NativeTypeName("ULONGLONG")]
    public ulong NumberOfBytesRepaired;

    [NativeTypeName("ULONGLONG")]
    public ulong NumberOfBytesFailed;

    [NativeTypeName("ULONGLONG")]
    public ulong InternalFileReference;

    [NativeTypeName("WORD")]
    public ushort ResumeContextLength;

    [NativeTypeName("WORD")]
    public ushort ParityExtentDataOffset;

    [NativeTypeName("ULONGLONG")]
    public ulong NextStartingByteOffset;

    [NativeTypeName("ULONGLONG")]
    public ulong ValidDataLength;

    [NativeTypeName("DWORD[4]")]
    public _Reserved_e__FixedBuffer Reserved;

    [NativeTypeName("ULONGLONG")]
    public ulong NumberOfMetadataBytesProcessed;

    [NativeTypeName("ULONGLONG")]
    public ulong NumberOfDataBytesProcessed;

    [NativeTypeName("ULONGLONG")]
    public ulong TotalNumberOfMetadataBytesInUse;

    [NativeTypeName("ULONGLONG")]
    public ulong TotalNumberOfDataBytesInUse;

    [NativeTypeName("ULONGLONG")]
    public ulong DataBytesSkippedDueToNoAllocation;

    [NativeTypeName("ULONGLONG")]
    public ulong DataBytesSkippedDueToInvalidRun;

    [NativeTypeName("ULONGLONG")]
    public ulong DataBytesSkippedDueToIntegrityStream;

    [NativeTypeName("ULONGLONG")]
    public ulong DataBytesSkippedDueToRegionBeingClean;

    [NativeTypeName("ULONGLONG")]
    public ulong DataBytesSkippedDueToLockConflict;

    [NativeTypeName("ULONGLONG")]
    public ulong DataBytesSkippedDueToNoScrubDataFlag;

    [NativeTypeName("ULONGLONG")]
    public ulong DataBytesSkippedDueToNoScrubNonIntegrityStreamFlag;

    [NativeTypeName("ULONGLONG")]
    public ulong DataBytesScrubbed;

    [NativeTypeName("BYTE[1040]")]
    public _ResumeContext_e__FixedBuffer ResumeContext;

    [InlineArray(4)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public uint e0;
    }

    [InlineArray(1040)]
    public partial struct _ResumeContext_e__FixedBuffer
    {
        public byte e0;
    }
}
