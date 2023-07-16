// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DISK_CONTROLLER_NUMBER.xml' path='doc/member[@name="DISK_CONTROLLER_NUMBER"]/*'/>
public partial struct DISK_CONTROLLER_NUMBER
{
    /// <include file='DISK_CONTROLLER_NUMBER.xml' path='doc/member[@name="DISK_CONTROLLER_NUMBER.ControllerNumber"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ControllerNumber;
    /// <include file='DISK_CONTROLLER_NUMBER.xml' path='doc/member[@name="DISK_CONTROLLER_NUMBER.DiskNumber"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DiskNumber;
}