// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct USN_JOURNAL_DATA_V0
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
}
