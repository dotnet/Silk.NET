// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DISK_EX_INT13_INFO.xml' path='doc/member[@name="DISK_EX_INT13_INFO"]/*'/>
public partial struct DISK_EX_INT13_INFO
{
    /// <include file='DISK_EX_INT13_INFO.xml' path='doc/member[@name="DISK_EX_INT13_INFO.ExBufferSize"]/*'/>
    [NativeTypeName("WORD")]
    public ushort ExBufferSize;
    /// <include file='DISK_EX_INT13_INFO.xml' path='doc/member[@name="DISK_EX_INT13_INFO.ExFlags"]/*'/>
    [NativeTypeName("WORD")]
    public ushort ExFlags;
    /// <include file='DISK_EX_INT13_INFO.xml' path='doc/member[@name="DISK_EX_INT13_INFO.ExCylinders"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ExCylinders;
    /// <include file='DISK_EX_INT13_INFO.xml' path='doc/member[@name="DISK_EX_INT13_INFO.ExHeads"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ExHeads;
    /// <include file='DISK_EX_INT13_INFO.xml' path='doc/member[@name="DISK_EX_INT13_INFO.ExSectorsPerTrack"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ExSectorsPerTrack;
    /// <include file='DISK_EX_INT13_INFO.xml' path='doc/member[@name="DISK_EX_INT13_INFO.ExSectorsPerDrive"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong ExSectorsPerDrive;
    /// <include file='DISK_EX_INT13_INFO.xml' path='doc/member[@name="DISK_EX_INT13_INFO.ExSectorSize"]/*'/>
    [NativeTypeName("WORD")]
    public ushort ExSectorSize;
    /// <include file='DISK_EX_INT13_INFO.xml' path='doc/member[@name="DISK_EX_INT13_INFO.ExReserved"]/*'/>
    [NativeTypeName("WORD")]
    public ushort ExReserved;
}