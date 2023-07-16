// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DISK_INT13_INFO.xml' path='doc/member[@name="DISK_INT13_INFO"]/*'/>
public partial struct DISK_INT13_INFO
{
    /// <include file='DISK_INT13_INFO.xml' path='doc/member[@name="DISK_INT13_INFO.DriveSelect"]/*'/>
    [NativeTypeName("WORD")]
    public ushort DriveSelect;
    /// <include file='DISK_INT13_INFO.xml' path='doc/member[@name="DISK_INT13_INFO.MaxCylinders"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MaxCylinders;
    /// <include file='DISK_INT13_INFO.xml' path='doc/member[@name="DISK_INT13_INFO.SectorsPerTrack"]/*'/>
    [NativeTypeName("WORD")]
    public ushort SectorsPerTrack;
    /// <include file='DISK_INT13_INFO.xml' path='doc/member[@name="DISK_INT13_INFO.MaxHeads"]/*'/>
    [NativeTypeName("WORD")]
    public ushort MaxHeads;
    /// <include file='DISK_INT13_INFO.xml' path='doc/member[@name="DISK_INT13_INFO.NumberDrives"]/*'/>
    [NativeTypeName("WORD")]
    public ushort NumberDrives;
}