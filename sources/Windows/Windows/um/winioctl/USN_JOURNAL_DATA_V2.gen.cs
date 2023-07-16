// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='USN_JOURNAL_DATA_V2.xml' path='doc/member[@name="USN_JOURNAL_DATA_V2"]/*'/>
[SupportedOSPlatform("windows6.3")]
public partial struct USN_JOURNAL_DATA_V2
{
    /// <include file='USN_JOURNAL_DATA_V2.xml' path='doc/member[@name="USN_JOURNAL_DATA_V2.UsnJournalID"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong UsnJournalID;
    /// <include file='USN_JOURNAL_DATA_V2.xml' path='doc/member[@name="USN_JOURNAL_DATA_V2.FirstUsn"]/*'/>
    [NativeTypeName("USN")]
    public long FirstUsn;
    /// <include file='USN_JOURNAL_DATA_V2.xml' path='doc/member[@name="USN_JOURNAL_DATA_V2.NextUsn"]/*'/>
    [NativeTypeName("USN")]
    public long NextUsn;
    /// <include file='USN_JOURNAL_DATA_V2.xml' path='doc/member[@name="USN_JOURNAL_DATA_V2.LowestValidUsn"]/*'/>
    [NativeTypeName("USN")]
    public long LowestValidUsn;
    /// <include file='USN_JOURNAL_DATA_V2.xml' path='doc/member[@name="USN_JOURNAL_DATA_V2.MaxUsn"]/*'/>
    [NativeTypeName("USN")]
    public long MaxUsn;
    /// <include file='USN_JOURNAL_DATA_V2.xml' path='doc/member[@name="USN_JOURNAL_DATA_V2.MaximumSize"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong MaximumSize;
    /// <include file='USN_JOURNAL_DATA_V2.xml' path='doc/member[@name="USN_JOURNAL_DATA_V2.AllocationDelta"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong AllocationDelta;
    /// <include file='USN_JOURNAL_DATA_V2.xml' path='doc/member[@name="USN_JOURNAL_DATA_V2.MinSupportedMajorVersion"]/*'/>
    [NativeTypeName("WORD")]
    public ushort MinSupportedMajorVersion;
    /// <include file='USN_JOURNAL_DATA_V2.xml' path='doc/member[@name="USN_JOURNAL_DATA_V2.MaxSupportedMajorVersion"]/*'/>
    [NativeTypeName("WORD")]
    public ushort MaxSupportedMajorVersion;
    /// <include file='USN_JOURNAL_DATA_V2.xml' path='doc/member[@name="USN_JOURNAL_DATA_V2.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='USN_JOURNAL_DATA_V2.xml' path='doc/member[@name="USN_JOURNAL_DATA_V2.RangeTrackChunkSize"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong RangeTrackChunkSize;
    /// <include file='USN_JOURNAL_DATA_V2.xml' path='doc/member[@name="USN_JOURNAL_DATA_V2.RangeTrackFileSizeThreshold"]/*'/>
    [NativeTypeName("LONGLONG")]
    public long RangeTrackFileSizeThreshold;
}