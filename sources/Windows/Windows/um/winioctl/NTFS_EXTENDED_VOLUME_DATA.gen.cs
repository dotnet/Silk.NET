// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NTFS_EXTENDED_VOLUME_DATA.xml' path='doc/member[@name="NTFS_EXTENDED_VOLUME_DATA"]/*'/>
public partial struct NTFS_EXTENDED_VOLUME_DATA
{
    /// <include file='NTFS_EXTENDED_VOLUME_DATA.xml' path='doc/member[@name="NTFS_EXTENDED_VOLUME_DATA.ByteCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ByteCount;
    /// <include file='NTFS_EXTENDED_VOLUME_DATA.xml' path='doc/member[@name="NTFS_EXTENDED_VOLUME_DATA.MajorVersion"]/*'/>
    [NativeTypeName("WORD")]
    public ushort MajorVersion;
    /// <include file='NTFS_EXTENDED_VOLUME_DATA.xml' path='doc/member[@name="NTFS_EXTENDED_VOLUME_DATA.MinorVersion"]/*'/>
    [NativeTypeName("WORD")]
    public ushort MinorVersion;
    /// <include file='NTFS_EXTENDED_VOLUME_DATA.xml' path='doc/member[@name="NTFS_EXTENDED_VOLUME_DATA.BytesPerPhysicalSector"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BytesPerPhysicalSector;
    /// <include file='NTFS_EXTENDED_VOLUME_DATA.xml' path='doc/member[@name="NTFS_EXTENDED_VOLUME_DATA.LfsMajorVersion"]/*'/>
    [NativeTypeName("WORD")]
    public ushort LfsMajorVersion;
    /// <include file='NTFS_EXTENDED_VOLUME_DATA.xml' path='doc/member[@name="NTFS_EXTENDED_VOLUME_DATA.LfsMinorVersion"]/*'/>
    [NativeTypeName("WORD")]
    public ushort LfsMinorVersion;
    /// <include file='NTFS_EXTENDED_VOLUME_DATA.xml' path='doc/member[@name="NTFS_EXTENDED_VOLUME_DATA.MaxDeviceTrimExtentCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MaxDeviceTrimExtentCount;
    /// <include file='NTFS_EXTENDED_VOLUME_DATA.xml' path='doc/member[@name="NTFS_EXTENDED_VOLUME_DATA.MaxDeviceTrimByteCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MaxDeviceTrimByteCount;
    /// <include file='NTFS_EXTENDED_VOLUME_DATA.xml' path='doc/member[@name="NTFS_EXTENDED_VOLUME_DATA.MaxVolumeTrimExtentCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MaxVolumeTrimExtentCount;
    /// <include file='NTFS_EXTENDED_VOLUME_DATA.xml' path='doc/member[@name="NTFS_EXTENDED_VOLUME_DATA.MaxVolumeTrimByteCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MaxVolumeTrimByteCount;
}