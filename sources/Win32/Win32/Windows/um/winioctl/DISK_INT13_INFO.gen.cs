// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DISK_INT13_INFO
{
    [NativeTypeName("WORD")]
    public ushort DriveSelect;

    [NativeTypeName("DWORD")]
    public uint MaxCylinders;

    [NativeTypeName("WORD")]
    public ushort SectorsPerTrack;

    [NativeTypeName("WORD")]
    public ushort MaxHeads;

    [NativeTypeName("WORD")]
    public ushort NumberDrives;
}
