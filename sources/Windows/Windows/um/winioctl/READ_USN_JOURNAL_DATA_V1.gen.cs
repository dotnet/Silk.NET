// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='READ_USN_JOURNAL_DATA_V1.xml' path='doc/member[@name="READ_USN_JOURNAL_DATA_V1"]/*'/>
public partial struct READ_USN_JOURNAL_DATA_V1
{
    /// <include file='READ_USN_JOURNAL_DATA_V1.xml' path='doc/member[@name="READ_USN_JOURNAL_DATA_V1.StartUsn"]/*'/>
    [NativeTypeName("USN")]
    public long StartUsn;
    /// <include file='READ_USN_JOURNAL_DATA_V1.xml' path='doc/member[@name="READ_USN_JOURNAL_DATA_V1.ReasonMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ReasonMask;
    /// <include file='READ_USN_JOURNAL_DATA_V1.xml' path='doc/member[@name="READ_USN_JOURNAL_DATA_V1.ReturnOnlyOnClose"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ReturnOnlyOnClose;
    /// <include file='READ_USN_JOURNAL_DATA_V1.xml' path='doc/member[@name="READ_USN_JOURNAL_DATA_V1.Timeout"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong Timeout;
    /// <include file='READ_USN_JOURNAL_DATA_V1.xml' path='doc/member[@name="READ_USN_JOURNAL_DATA_V1.BytesToWaitFor"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong BytesToWaitFor;
    /// <include file='READ_USN_JOURNAL_DATA_V1.xml' path='doc/member[@name="READ_USN_JOURNAL_DATA_V1.UsnJournalID"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong UsnJournalID;
    /// <include file='READ_USN_JOURNAL_DATA_V1.xml' path='doc/member[@name="READ_USN_JOURNAL_DATA_V1.MinMajorVersion"]/*'/>
    [NativeTypeName("WORD")]
    public ushort MinMajorVersion;
    /// <include file='READ_USN_JOURNAL_DATA_V1.xml' path='doc/member[@name="READ_USN_JOURNAL_DATA_V1.MaxMajorVersion"]/*'/>
    [NativeTypeName("WORD")]
    public ushort MaxMajorVersion;
}