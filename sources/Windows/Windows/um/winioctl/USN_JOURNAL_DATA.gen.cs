// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='USN_JOURNAL_DATA.xml' path='doc/member[@name="USN_JOURNAL_DATA"]/*' />
public partial struct USN_JOURNAL_DATA
{
    /// <include file='USN_JOURNAL_DATA.xml' path='doc/member[@name="USN_JOURNAL_DATA.UsnJournalID"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong UsnJournalID;

    /// <include file='USN_JOURNAL_DATA.xml' path='doc/member[@name="USN_JOURNAL_DATA.FirstUsn"]/*' />
    [NativeTypeName("USN")]
    public long FirstUsn;

    /// <include file='USN_JOURNAL_DATA.xml' path='doc/member[@name="USN_JOURNAL_DATA.NextUsn"]/*' />
    [NativeTypeName("USN")]
    public long NextUsn;

    /// <include file='USN_JOURNAL_DATA.xml' path='doc/member[@name="USN_JOURNAL_DATA.LowestValidUsn"]/*' />
    [NativeTypeName("USN")]
    public long LowestValidUsn;

    /// <include file='USN_JOURNAL_DATA.xml' path='doc/member[@name="USN_JOURNAL_DATA.MaxUsn"]/*' />
    [NativeTypeName("USN")]
    public long MaxUsn;

    /// <include file='USN_JOURNAL_DATA.xml' path='doc/member[@name="USN_JOURNAL_DATA.MaximumSize"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong MaximumSize;

    /// <include file='USN_JOURNAL_DATA.xml' path='doc/member[@name="USN_JOURNAL_DATA.AllocationDelta"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong AllocationDelta;

    /// <include file='USN_JOURNAL_DATA.xml' path='doc/member[@name="USN_JOURNAL_DATA.MinSupportedMajorVersion"]/*' />
    [NativeTypeName("WORD")]
    public ushort MinSupportedMajorVersion;

    /// <include file='USN_JOURNAL_DATA.xml' path='doc/member[@name="USN_JOURNAL_DATA.MaxSupportedMajorVersion"]/*' />
    [NativeTypeName("WORD")]
    public ushort MaxSupportedMajorVersion;
}
