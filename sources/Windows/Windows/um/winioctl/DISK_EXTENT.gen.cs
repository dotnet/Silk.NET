// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DISK_EXTENT.xml' path='doc/member[@name="DISK_EXTENT"]/*'/>
public partial struct DISK_EXTENT
{
    /// <include file='DISK_EXTENT.xml' path='doc/member[@name="DISK_EXTENT.DiskNumber"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DiskNumber;
    /// <include file='DISK_EXTENT.xml' path='doc/member[@name="DISK_EXTENT.StartingOffset"]/*'/>
    public LARGE_INTEGER StartingOffset;
    /// <include file='DISK_EXTENT.xml' path='doc/member[@name="DISK_EXTENT.ExtentLength"]/*'/>
    public LARGE_INTEGER ExtentLength;
}