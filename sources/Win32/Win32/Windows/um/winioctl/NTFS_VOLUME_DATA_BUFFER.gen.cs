// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct NTFS_VOLUME_DATA_BUFFER
{
    public LARGE_INTEGER VolumeSerialNumber;
    public LARGE_INTEGER NumberSectors;
    public LARGE_INTEGER TotalClusters;
    public LARGE_INTEGER FreeClusters;
    public LARGE_INTEGER TotalReserved;

    [NativeTypeName("DWORD")]
    public uint BytesPerSector;

    [NativeTypeName("DWORD")]
    public uint BytesPerCluster;

    [NativeTypeName("DWORD")]
    public uint BytesPerFileRecordSegment;

    [NativeTypeName("DWORD")]
    public uint ClustersPerFileRecordSegment;
    public LARGE_INTEGER MftValidDataLength;
    public LARGE_INTEGER MftStartLcn;
    public LARGE_INTEGER Mft2StartLcn;
    public LARGE_INTEGER MftZoneStart;
    public LARGE_INTEGER MftZoneEnd;
}
