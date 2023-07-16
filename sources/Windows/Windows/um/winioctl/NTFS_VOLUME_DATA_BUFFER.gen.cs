// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='NTFS_VOLUME_DATA_BUFFER.xml' path='doc/member[@name="NTFS_VOLUME_DATA_BUFFER"]/*'/>
public partial struct NTFS_VOLUME_DATA_BUFFER
{
    /// <include file='NTFS_VOLUME_DATA_BUFFER.xml' path='doc/member[@name="NTFS_VOLUME_DATA_BUFFER.VolumeSerialNumber"]/*'/>
    public LARGE_INTEGER VolumeSerialNumber;
    /// <include file='NTFS_VOLUME_DATA_BUFFER.xml' path='doc/member[@name="NTFS_VOLUME_DATA_BUFFER.NumberSectors"]/*'/>
    public LARGE_INTEGER NumberSectors;
    /// <include file='NTFS_VOLUME_DATA_BUFFER.xml' path='doc/member[@name="NTFS_VOLUME_DATA_BUFFER.TotalClusters"]/*'/>
    public LARGE_INTEGER TotalClusters;
    /// <include file='NTFS_VOLUME_DATA_BUFFER.xml' path='doc/member[@name="NTFS_VOLUME_DATA_BUFFER.FreeClusters"]/*'/>
    public LARGE_INTEGER FreeClusters;
    /// <include file='NTFS_VOLUME_DATA_BUFFER.xml' path='doc/member[@name="NTFS_VOLUME_DATA_BUFFER.TotalReserved"]/*'/>
    public LARGE_INTEGER TotalReserved;
    /// <include file='NTFS_VOLUME_DATA_BUFFER.xml' path='doc/member[@name="NTFS_VOLUME_DATA_BUFFER.BytesPerSector"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BytesPerSector;
    /// <include file='NTFS_VOLUME_DATA_BUFFER.xml' path='doc/member[@name="NTFS_VOLUME_DATA_BUFFER.BytesPerCluster"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BytesPerCluster;
    /// <include file='NTFS_VOLUME_DATA_BUFFER.xml' path='doc/member[@name="NTFS_VOLUME_DATA_BUFFER.BytesPerFileRecordSegment"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BytesPerFileRecordSegment;
    /// <include file='NTFS_VOLUME_DATA_BUFFER.xml' path='doc/member[@name="NTFS_VOLUME_DATA_BUFFER.ClustersPerFileRecordSegment"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ClustersPerFileRecordSegment;
    /// <include file='NTFS_VOLUME_DATA_BUFFER.xml' path='doc/member[@name="NTFS_VOLUME_DATA_BUFFER.MftValidDataLength"]/*'/>
    public LARGE_INTEGER MftValidDataLength;
    /// <include file='NTFS_VOLUME_DATA_BUFFER.xml' path='doc/member[@name="NTFS_VOLUME_DATA_BUFFER.MftStartLcn"]/*'/>
    public LARGE_INTEGER MftStartLcn;
    /// <include file='NTFS_VOLUME_DATA_BUFFER.xml' path='doc/member[@name="NTFS_VOLUME_DATA_BUFFER.Mft2StartLcn"]/*'/>
    public LARGE_INTEGER Mft2StartLcn;
    /// <include file='NTFS_VOLUME_DATA_BUFFER.xml' path='doc/member[@name="NTFS_VOLUME_DATA_BUFFER.MftZoneStart"]/*'/>
    public LARGE_INTEGER MftZoneStart;
    /// <include file='NTFS_VOLUME_DATA_BUFFER.xml' path='doc/member[@name="NTFS_VOLUME_DATA_BUFFER.MftZoneEnd"]/*'/>
    public LARGE_INTEGER MftZoneEnd;
}