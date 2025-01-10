// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DISK_EX_INT13_INFO
{
    [NativeTypeName("WORD")]
    public ushort ExBufferSize;

    [NativeTypeName("WORD")]
    public ushort ExFlags;

    [NativeTypeName("DWORD")]
    public uint ExCylinders;

    [NativeTypeName("DWORD")]
    public uint ExHeads;

    [NativeTypeName("DWORD")]
    public uint ExSectorsPerTrack;

    [NativeTypeName("DWORD64")]
    public ulong ExSectorsPerDrive;

    [NativeTypeName("WORD")]
    public ushort ExSectorSize;

    [NativeTypeName("WORD")]
    public ushort ExReserved;
}
