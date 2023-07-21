// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DISK_GEOMETRY.xml' path='doc/member[@name="DISK_GEOMETRY"]/*' />
public partial struct DISK_GEOMETRY
{
    /// <include file='DISK_GEOMETRY.xml' path='doc/member[@name="DISK_GEOMETRY.Cylinders"]/*' />
    public LARGE_INTEGER Cylinders;

    /// <include file='DISK_GEOMETRY.xml' path='doc/member[@name="DISK_GEOMETRY.MediaType"]/*' />
    public MEDIA_TYPE MediaType;

    /// <include file='DISK_GEOMETRY.xml' path='doc/member[@name="DISK_GEOMETRY.TracksPerCylinder"]/*' />
    [NativeTypeName("DWORD")]
    public uint TracksPerCylinder;

    /// <include file='DISK_GEOMETRY.xml' path='doc/member[@name="DISK_GEOMETRY.SectorsPerTrack"]/*' />
    [NativeTypeName("DWORD")]
    public uint SectorsPerTrack;

    /// <include file='DISK_GEOMETRY.xml' path='doc/member[@name="DISK_GEOMETRY.BytesPerSector"]/*' />
    [NativeTypeName("DWORD")]
    public uint BytesPerSector;
}
