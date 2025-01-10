// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct NTFS_EXTENDED_VOLUME_DATA
{
    [NativeTypeName("DWORD")]
    public uint ByteCount;

    [NativeTypeName("WORD")]
    public ushort MajorVersion;

    [NativeTypeName("WORD")]
    public ushort MinorVersion;

    [NativeTypeName("DWORD")]
    public uint BytesPerPhysicalSector;

    [NativeTypeName("WORD")]
    public ushort LfsMajorVersion;

    [NativeTypeName("WORD")]
    public ushort LfsMinorVersion;

    [NativeTypeName("DWORD")]
    public uint MaxDeviceTrimExtentCount;

    [NativeTypeName("DWORD")]
    public uint MaxDeviceTrimByteCount;

    [NativeTypeName("DWORD")]
    public uint MaxVolumeTrimExtentCount;

    [NativeTypeName("DWORD")]
    public uint MaxVolumeTrimByteCount;
}
