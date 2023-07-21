// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='READ_USN_JOURNAL_DATA_V0.xml' path='doc/member[@name="READ_USN_JOURNAL_DATA_V0"]/*' />
public partial struct READ_USN_JOURNAL_DATA_V0
{
    /// <include file='READ_USN_JOURNAL_DATA_V0.xml' path='doc/member[@name="READ_USN_JOURNAL_DATA_V0.StartUsn"]/*' />
    [NativeTypeName("USN")]
    public long StartUsn;

    /// <include file='READ_USN_JOURNAL_DATA_V0.xml' path='doc/member[@name="READ_USN_JOURNAL_DATA_V0.ReasonMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint ReasonMask;

    /// <include file='READ_USN_JOURNAL_DATA_V0.xml' path='doc/member[@name="READ_USN_JOURNAL_DATA_V0.ReturnOnlyOnClose"]/*' />
    [NativeTypeName("DWORD")]
    public uint ReturnOnlyOnClose;

    /// <include file='READ_USN_JOURNAL_DATA_V0.xml' path='doc/member[@name="READ_USN_JOURNAL_DATA_V0.Timeout"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong Timeout;

    /// <include file='READ_USN_JOURNAL_DATA_V0.xml' path='doc/member[@name="READ_USN_JOURNAL_DATA_V0.BytesToWaitFor"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong BytesToWaitFor;

    /// <include file='READ_USN_JOURNAL_DATA_V0.xml' path='doc/member[@name="READ_USN_JOURNAL_DATA_V0.UsnJournalID"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong UsnJournalID;
}
