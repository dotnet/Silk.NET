// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DISK_PERFORMANCE.xml' path='doc/member[@name="DISK_PERFORMANCE"]/*'/>
public unsafe partial struct DISK_PERFORMANCE
{
    /// <include file='DISK_PERFORMANCE.xml' path='doc/member[@name="DISK_PERFORMANCE.BytesRead"]/*'/>
    public LARGE_INTEGER BytesRead;
    /// <include file='DISK_PERFORMANCE.xml' path='doc/member[@name="DISK_PERFORMANCE.BytesWritten"]/*'/>
    public LARGE_INTEGER BytesWritten;
    /// <include file='DISK_PERFORMANCE.xml' path='doc/member[@name="DISK_PERFORMANCE.ReadTime"]/*'/>
    public LARGE_INTEGER ReadTime;
    /// <include file='DISK_PERFORMANCE.xml' path='doc/member[@name="DISK_PERFORMANCE.WriteTime"]/*'/>
    public LARGE_INTEGER WriteTime;
    /// <include file='DISK_PERFORMANCE.xml' path='doc/member[@name="DISK_PERFORMANCE.IdleTime"]/*'/>
    public LARGE_INTEGER IdleTime;
    /// <include file='DISK_PERFORMANCE.xml' path='doc/member[@name="DISK_PERFORMANCE.ReadCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ReadCount;
    /// <include file='DISK_PERFORMANCE.xml' path='doc/member[@name="DISK_PERFORMANCE.WriteCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint WriteCount;
    /// <include file='DISK_PERFORMANCE.xml' path='doc/member[@name="DISK_PERFORMANCE.QueueDepth"]/*'/>
    [NativeTypeName("DWORD")]
    public uint QueueDepth;
    /// <include file='DISK_PERFORMANCE.xml' path='doc/member[@name="DISK_PERFORMANCE.SplitCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SplitCount;
    /// <include file='DISK_PERFORMANCE.xml' path='doc/member[@name="DISK_PERFORMANCE.QueryTime"]/*'/>
    public LARGE_INTEGER QueryTime;
    /// <include file='DISK_PERFORMANCE.xml' path='doc/member[@name="DISK_PERFORMANCE.StorageDeviceNumber"]/*'/>
    [NativeTypeName("DWORD")]
    public uint StorageDeviceNumber;
    /// <include file='DISK_PERFORMANCE.xml' path='doc/member[@name="DISK_PERFORMANCE.StorageManagerName"]/*'/>
    [NativeTypeName("WCHAR[8]")]
    public fixed ushort StorageManagerName[8];
}