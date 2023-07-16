// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='IMAGE_ARCHIVE_MEMBER_HEADER.xml' path='doc/member[@name="IMAGE_ARCHIVE_MEMBER_HEADER"]/*'/>
public unsafe partial struct IMAGE_ARCHIVE_MEMBER_HEADER
{
    /// <include file='IMAGE_ARCHIVE_MEMBER_HEADER.xml' path='doc/member[@name="IMAGE_ARCHIVE_MEMBER_HEADER.Name"]/*'/>
    [NativeTypeName("BYTE[16]")]
    public fixed byte Name[16];
    /// <include file='IMAGE_ARCHIVE_MEMBER_HEADER.xml' path='doc/member[@name="IMAGE_ARCHIVE_MEMBER_HEADER.Date"]/*'/>
    [NativeTypeName("BYTE[12]")]
    public fixed byte Date[12];
    /// <include file='IMAGE_ARCHIVE_MEMBER_HEADER.xml' path='doc/member[@name="IMAGE_ARCHIVE_MEMBER_HEADER.UserID"]/*'/>
    [NativeTypeName("BYTE[6]")]
    public fixed byte UserID[6];
    /// <include file='IMAGE_ARCHIVE_MEMBER_HEADER.xml' path='doc/member[@name="IMAGE_ARCHIVE_MEMBER_HEADER.GroupID"]/*'/>
    [NativeTypeName("BYTE[6]")]
    public fixed byte GroupID[6];
    /// <include file='IMAGE_ARCHIVE_MEMBER_HEADER.xml' path='doc/member[@name="IMAGE_ARCHIVE_MEMBER_HEADER.Mode"]/*'/>
    [NativeTypeName("BYTE[8]")]
    public fixed byte Mode[8];
    /// <include file='IMAGE_ARCHIVE_MEMBER_HEADER.xml' path='doc/member[@name="IMAGE_ARCHIVE_MEMBER_HEADER.Size"]/*'/>
    [NativeTypeName("BYTE[10]")]
    public fixed byte Size[10];
    /// <include file='IMAGE_ARCHIVE_MEMBER_HEADER.xml' path='doc/member[@name="IMAGE_ARCHIVE_MEMBER_HEADER.EndHeader"]/*'/>
    [NativeTypeName("BYTE[2]")]
    public fixed byte EndHeader[2];
}