// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.3")]
public partial struct USN_JOURNAL_DATA_V2
{
    [NativeTypeName("DWORDLONG")]
    public ulong UsnJournalID;

    [NativeTypeName("USN")]
    public long FirstUsn;

    [NativeTypeName("USN")]
    public long NextUsn;

    [NativeTypeName("USN")]
    public long LowestValidUsn;

    [NativeTypeName("USN")]
    public long MaxUsn;

    [NativeTypeName("DWORDLONG")]
    public ulong MaximumSize;

    [NativeTypeName("DWORDLONG")]
    public ulong AllocationDelta;

    [NativeTypeName("WORD")]
    public ushort MinSupportedMajorVersion;

    [NativeTypeName("WORD")]
    public ushort MaxSupportedMajorVersion;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("DWORDLONG")]
    public ulong RangeTrackChunkSize;

    [NativeTypeName("LONGLONG")]
    public long RangeTrackFileSizeThreshold;
}
