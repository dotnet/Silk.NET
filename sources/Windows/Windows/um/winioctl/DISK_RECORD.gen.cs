// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DISK_RECORD.xml' path='doc/member[@name="DISK_RECORD"]/*'/>
public unsafe partial struct DISK_RECORD
{
    /// <include file='DISK_RECORD.xml' path='doc/member[@name="DISK_RECORD.ByteOffset"]/*'/>
    public LARGE_INTEGER ByteOffset;
    /// <include file='DISK_RECORD.xml' path='doc/member[@name="DISK_RECORD.StartTime"]/*'/>
    public LARGE_INTEGER StartTime;
    /// <include file='DISK_RECORD.xml' path='doc/member[@name="DISK_RECORD.EndTime"]/*'/>
    public LARGE_INTEGER EndTime;
    /// <include file='DISK_RECORD.xml' path='doc/member[@name="DISK_RECORD.VirtualAddress"]/*'/>
    [NativeTypeName("PVOID")]
    public void* VirtualAddress;
    /// <include file='DISK_RECORD.xml' path='doc/member[@name="DISK_RECORD.NumberOfBytes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumberOfBytes;
    /// <include file='DISK_RECORD.xml' path='doc/member[@name="DISK_RECORD.DeviceNumber"]/*'/>
    public byte DeviceNumber;
    /// <include file='DISK_RECORD.xml' path='doc/member[@name="DISK_RECORD.ReadRequest"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte ReadRequest;
}