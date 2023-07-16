// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='FILE_LAYOUT_INFO_ENTRY.xml' path='doc/member[@name="FILE_LAYOUT_INFO_ENTRY"]/*'/>
public partial struct FILE_LAYOUT_INFO_ENTRY
{
    /// <include file='FILE_LAYOUT_INFO_ENTRY.xml' path='doc/member[@name="FILE_LAYOUT_INFO_ENTRY.BasicInformation"]/*'/>
    [NativeTypeName("__AnonymousRecord_winioctl_L15187_C5")]
    public _BasicInformation_e__Struct BasicInformation;
    /// <include file='FILE_LAYOUT_INFO_ENTRY.xml' path='doc/member[@name="FILE_LAYOUT_INFO_ENTRY.OwnerId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint OwnerId;
    /// <include file='FILE_LAYOUT_INFO_ENTRY.xml' path='doc/member[@name="FILE_LAYOUT_INFO_ENTRY.SecurityId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SecurityId;
    /// <include file='FILE_LAYOUT_INFO_ENTRY.xml' path='doc/member[@name="FILE_LAYOUT_INFO_ENTRY.Usn"]/*'/>
    [NativeTypeName("USN")]
    public long Usn;
    /// <include file='FILE_LAYOUT_INFO_ENTRY.xml' path='doc/member[@name="FILE_LAYOUT_INFO_ENTRY.StorageReserveId"]/*'/>
    public STORAGE_RESERVE_ID StorageReserveId;
    /// <include file='_BasicInformation_e__Struct.xml' path='doc/member[@name="_BasicInformation_e__Struct"]/*'/>
    public partial struct _BasicInformation_e__Struct
    {
        /// <include file='_BasicInformation_e__Struct.xml' path='doc/member[@name="_BasicInformation_e__Struct.CreationTime"]/*'/>
        public LARGE_INTEGER CreationTime;
        /// <include file='_BasicInformation_e__Struct.xml' path='doc/member[@name="_BasicInformation_e__Struct.LastAccessTime"]/*'/>
        public LARGE_INTEGER LastAccessTime;
        /// <include file='_BasicInformation_e__Struct.xml' path='doc/member[@name="_BasicInformation_e__Struct.LastWriteTime"]/*'/>
        public LARGE_INTEGER LastWriteTime;
        /// <include file='_BasicInformation_e__Struct.xml' path='doc/member[@name="_BasicInformation_e__Struct.ChangeTime"]/*'/>
        public LARGE_INTEGER ChangeTime;
        /// <include file='_BasicInformation_e__Struct.xml' path='doc/member[@name="_BasicInformation_e__Struct.FileAttributes"]/*'/>
        [NativeTypeName("DWORD")]
        public uint FileAttributes;
    }
}