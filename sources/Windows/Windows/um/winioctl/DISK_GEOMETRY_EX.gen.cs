// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DISK_GEOMETRY_EX.xml' path='doc/member[@name="DISK_GEOMETRY_EX"]/*'/>
public unsafe partial struct DISK_GEOMETRY_EX
{
    /// <include file='DISK_GEOMETRY_EX.xml' path='doc/member[@name="DISK_GEOMETRY_EX.Geometry"]/*'/>
    public DISK_GEOMETRY Geometry;
    /// <include file='DISK_GEOMETRY_EX.xml' path='doc/member[@name="DISK_GEOMETRY_EX.DiskSize"]/*'/>
    public LARGE_INTEGER DiskSize;
    /// <include file='DISK_GEOMETRY_EX.xml' path='doc/member[@name="DISK_GEOMETRY_EX.Data"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte Data[1];
}