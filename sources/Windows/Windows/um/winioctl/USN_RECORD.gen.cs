// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='USN_RECORD.xml' path='doc/member[@name="USN_RECORD"]/*' />
public unsafe partial struct USN_RECORD
{
    /// <include file='USN_RECORD.xml' path='doc/member[@name="USN_RECORD.RecordLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint RecordLength;

    /// <include file='USN_RECORD.xml' path='doc/member[@name="USN_RECORD.MajorVersion"]/*' />
    [NativeTypeName("WORD")]
    public ushort MajorVersion;

    /// <include file='USN_RECORD.xml' path='doc/member[@name="USN_RECORD.MinorVersion"]/*' />
    [NativeTypeName("WORD")]
    public ushort MinorVersion;

    /// <include file='USN_RECORD.xml' path='doc/member[@name="USN_RECORD.FileReferenceNumber"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong FileReferenceNumber;

    /// <include file='USN_RECORD.xml' path='doc/member[@name="USN_RECORD.ParentFileReferenceNumber"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong ParentFileReferenceNumber;

    /// <include file='USN_RECORD.xml' path='doc/member[@name="USN_RECORD.Usn"]/*' />
    [NativeTypeName("USN")]
    public long Usn;

    /// <include file='USN_RECORD.xml' path='doc/member[@name="USN_RECORD.TimeStamp"]/*' />
    public LARGE_INTEGER TimeStamp;

    /// <include file='USN_RECORD.xml' path='doc/member[@name="USN_RECORD.Reason"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reason;

    /// <include file='USN_RECORD.xml' path='doc/member[@name="USN_RECORD.SourceInfo"]/*' />
    [NativeTypeName("DWORD")]
    public uint SourceInfo;

    /// <include file='USN_RECORD.xml' path='doc/member[@name="USN_RECORD.SecurityId"]/*' />
    [NativeTypeName("DWORD")]
    public uint SecurityId;

    /// <include file='USN_RECORD.xml' path='doc/member[@name="USN_RECORD.FileAttributes"]/*' />
    [NativeTypeName("DWORD")]
    public uint FileAttributes;

    /// <include file='USN_RECORD.xml' path='doc/member[@name="USN_RECORD.FileNameLength"]/*' />
    [NativeTypeName("WORD")]
    public ushort FileNameLength;

    /// <include file='USN_RECORD.xml' path='doc/member[@name="USN_RECORD.FileNameOffset"]/*' />
    [NativeTypeName("WORD")]
    public ushort FileNameOffset;

    /// <include file='USN_RECORD.xml' path='doc/member[@name="USN_RECORD.FileName"]/*' />
    [NativeTypeName("WCHAR[1]")]
    public fixed ushort FileName[1];
}
