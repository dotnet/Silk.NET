// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='EVENTLOGRECORD.xml' path='doc/member[@name="EVENTLOGRECORD"]/*' />
public partial struct EVENTLOGRECORD
{
    /// <include file='EVENTLOGRECORD.xml' path='doc/member[@name="EVENTLOGRECORD.Length"]/*' />
    [NativeTypeName("DWORD")]
    public uint Length;

    /// <include file='EVENTLOGRECORD.xml' path='doc/member[@name="EVENTLOGRECORD.Reserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved;

    /// <include file='EVENTLOGRECORD.xml' path='doc/member[@name="EVENTLOGRECORD.RecordNumber"]/*' />
    [NativeTypeName("DWORD")]
    public uint RecordNumber;

    /// <include file='EVENTLOGRECORD.xml' path='doc/member[@name="EVENTLOGRECORD.TimeGenerated"]/*' />
    [NativeTypeName("DWORD")]
    public uint TimeGenerated;

    /// <include file='EVENTLOGRECORD.xml' path='doc/member[@name="EVENTLOGRECORD.TimeWritten"]/*' />
    [NativeTypeName("DWORD")]
    public uint TimeWritten;

    /// <include file='EVENTLOGRECORD.xml' path='doc/member[@name="EVENTLOGRECORD.EventID"]/*' />
    [NativeTypeName("DWORD")]
    public uint EventID;

    /// <include file='EVENTLOGRECORD.xml' path='doc/member[@name="EVENTLOGRECORD.EventType"]/*' />
    [NativeTypeName("WORD")]
    public ushort EventType;

    /// <include file='EVENTLOGRECORD.xml' path='doc/member[@name="EVENTLOGRECORD.NumStrings"]/*' />
    [NativeTypeName("WORD")]
    public ushort NumStrings;

    /// <include file='EVENTLOGRECORD.xml' path='doc/member[@name="EVENTLOGRECORD.EventCategory"]/*' />
    [NativeTypeName("WORD")]
    public ushort EventCategory;

    /// <include file='EVENTLOGRECORD.xml' path='doc/member[@name="EVENTLOGRECORD.ReservedFlags"]/*' />
    [NativeTypeName("WORD")]
    public ushort ReservedFlags;

    /// <include file='EVENTLOGRECORD.xml' path='doc/member[@name="EVENTLOGRECORD.ClosingRecordNumber"]/*' />
    [NativeTypeName("DWORD")]
    public uint ClosingRecordNumber;

    /// <include file='EVENTLOGRECORD.xml' path='doc/member[@name="EVENTLOGRECORD.StringOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint StringOffset;

    /// <include file='EVENTLOGRECORD.xml' path='doc/member[@name="EVENTLOGRECORD.UserSidLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint UserSidLength;

    /// <include file='EVENTLOGRECORD.xml' path='doc/member[@name="EVENTLOGRECORD.UserSidOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint UserSidOffset;

    /// <include file='EVENTLOGRECORD.xml' path='doc/member[@name="EVENTLOGRECORD.DataLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint DataLength;

    /// <include file='EVENTLOGRECORD.xml' path='doc/member[@name="EVENTLOGRECORD.DataOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint DataOffset;
}
