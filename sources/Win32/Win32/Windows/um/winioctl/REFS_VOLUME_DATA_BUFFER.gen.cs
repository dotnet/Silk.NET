// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct REFS_VOLUME_DATA_BUFFER
{
    [NativeTypeName("DWORD")]
    public uint ByteCount;

    [NativeTypeName("DWORD")]
    public uint MajorVersion;

    [NativeTypeName("DWORD")]
    public uint MinorVersion;

    [NativeTypeName("DWORD")]
    public uint BytesPerPhysicalSector;
    public LARGE_INTEGER VolumeSerialNumber;
    public LARGE_INTEGER NumberSectors;
    public LARGE_INTEGER TotalClusters;
    public LARGE_INTEGER FreeClusters;
    public LARGE_INTEGER TotalReserved;

    [NativeTypeName("DWORD")]
    public uint BytesPerSector;

    [NativeTypeName("DWORD")]
    public uint BytesPerCluster;
    public LARGE_INTEGER MaximumSizeOfResidentFile;

    [NativeTypeName("WORD")]
    public ushort FastTierDataFillRatio;

    [NativeTypeName("WORD")]
    public ushort SlowTierDataFillRatio;

    [NativeTypeName("DWORD")]
    public uint DestagesFastTierToSlowTierRate;

    [NativeTypeName("WORD")]
    public ushort MetadataChecksumType;

    [NativeTypeName("BYTE[6]")]
    public _Reserved0_e__FixedBuffer Reserved0;

    [NativeTypeName("DWORD")]
    public uint DriverMajorVersion;

    [NativeTypeName("DWORD")]
    public uint DriverMinorVersion;

    [NativeTypeName("LARGE_INTEGER[7]")]
    public _Reserved_e__FixedBuffer Reserved;

    [InlineArray(6)]
    public partial struct _Reserved0_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(7)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public LARGE_INTEGER e0;
    }
}
