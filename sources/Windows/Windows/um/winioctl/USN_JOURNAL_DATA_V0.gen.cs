// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='USN_JOURNAL_DATA_V0.xml' path='doc/member[@name="USN_JOURNAL_DATA_V0"]/*'/>
public partial struct USN_JOURNAL_DATA_V0
{
    /// <include file='USN_JOURNAL_DATA_V0.xml' path='doc/member[@name="USN_JOURNAL_DATA_V0.UsnJournalID"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong UsnJournalID;
    /// <include file='USN_JOURNAL_DATA_V0.xml' path='doc/member[@name="USN_JOURNAL_DATA_V0.FirstUsn"]/*'/>
    [NativeTypeName("USN")]
    public long FirstUsn;
    /// <include file='USN_JOURNAL_DATA_V0.xml' path='doc/member[@name="USN_JOURNAL_DATA_V0.NextUsn"]/*'/>
    [NativeTypeName("USN")]
    public long NextUsn;
    /// <include file='USN_JOURNAL_DATA_V0.xml' path='doc/member[@name="USN_JOURNAL_DATA_V0.LowestValidUsn"]/*'/>
    [NativeTypeName("USN")]
    public long LowestValidUsn;
    /// <include file='USN_JOURNAL_DATA_V0.xml' path='doc/member[@name="USN_JOURNAL_DATA_V0.MaxUsn"]/*'/>
    [NativeTypeName("USN")]
    public long MaxUsn;
    /// <include file='USN_JOURNAL_DATA_V0.xml' path='doc/member[@name="USN_JOURNAL_DATA_V0.MaximumSize"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong MaximumSize;
    /// <include file='USN_JOURNAL_DATA_V0.xml' path='doc/member[@name="USN_JOURNAL_DATA_V0.AllocationDelta"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong AllocationDelta;
}