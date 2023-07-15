// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='USN_RECORD_V3.xml' path='doc/member[@name="USN_RECORD_V3"]/*'/>
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct USN_RECORD_V3
{
    /// <include file='USN_RECORD_V3.xml' path='doc/member[@name="USN_RECORD_V3.RecordLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint RecordLength;
    /// <include file='USN_RECORD_V3.xml' path='doc/member[@name="USN_RECORD_V3.MajorVersion"]/*'/>
    [NativeTypeName("WORD")]
    public ushort MajorVersion;
    /// <include file='USN_RECORD_V3.xml' path='doc/member[@name="USN_RECORD_V3.MinorVersion"]/*'/>
    [NativeTypeName("WORD")]
    public ushort MinorVersion;
    /// <include file='USN_RECORD_V3.xml' path='doc/member[@name="USN_RECORD_V3.FileReferenceNumber"]/*'/>
    public FILE_ID_128 FileReferenceNumber;
    /// <include file='USN_RECORD_V3.xml' path='doc/member[@name="USN_RECORD_V3.ParentFileReferenceNumber"]/*'/>
    public FILE_ID_128 ParentFileReferenceNumber;
    /// <include file='USN_RECORD_V3.xml' path='doc/member[@name="USN_RECORD_V3.Usn"]/*'/>
    [NativeTypeName("USN")]
    public long Usn;
    /// <include file='USN_RECORD_V3.xml' path='doc/member[@name="USN_RECORD_V3.TimeStamp"]/*'/>
    public LARGE_INTEGER TimeStamp;
    /// <include file='USN_RECORD_V3.xml' path='doc/member[@name="USN_RECORD_V3.Reason"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Reason;
    /// <include file='USN_RECORD_V3.xml' path='doc/member[@name="USN_RECORD_V3.SourceInfo"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SourceInfo;
    /// <include file='USN_RECORD_V3.xml' path='doc/member[@name="USN_RECORD_V3.SecurityId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SecurityId;
    /// <include file='USN_RECORD_V3.xml' path='doc/member[@name="USN_RECORD_V3.FileAttributes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint FileAttributes;
    /// <include file='USN_RECORD_V3.xml' path='doc/member[@name="USN_RECORD_V3.FileNameLength"]/*'/>
    [NativeTypeName("WORD")]
    public ushort FileNameLength;
    /// <include file='USN_RECORD_V3.xml' path='doc/member[@name="USN_RECORD_V3.FileNameOffset"]/*'/>
    [NativeTypeName("WORD")]
    public ushort FileNameOffset;
    /// <include file='USN_RECORD_V3.xml' path='doc/member[@name="USN_RECORD_V3.FileName"]/*'/>
    [NativeTypeName("WCHAR[1]")]
    public fixed ushort FileName[1];
}