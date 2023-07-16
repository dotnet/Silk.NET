// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='PARTITION_INFORMATION.xml' path='doc/member[@name="PARTITION_INFORMATION"]/*'/>
public partial struct PARTITION_INFORMATION
{
    /// <include file='PARTITION_INFORMATION.xml' path='doc/member[@name="PARTITION_INFORMATION.StartingOffset"]/*'/>
    public LARGE_INTEGER StartingOffset;
    /// <include file='PARTITION_INFORMATION.xml' path='doc/member[@name="PARTITION_INFORMATION.PartitionLength"]/*'/>
    public LARGE_INTEGER PartitionLength;
    /// <include file='PARTITION_INFORMATION.xml' path='doc/member[@name="PARTITION_INFORMATION.HiddenSectors"]/*'/>
    [NativeTypeName("DWORD")]
    public uint HiddenSectors;
    /// <include file='PARTITION_INFORMATION.xml' path='doc/member[@name="PARTITION_INFORMATION.PartitionNumber"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PartitionNumber;
    /// <include file='PARTITION_INFORMATION.xml' path='doc/member[@name="PARTITION_INFORMATION.PartitionType"]/*'/>
    public byte PartitionType;
    /// <include file='PARTITION_INFORMATION.xml' path='doc/member[@name="PARTITION_INFORMATION.BootIndicator"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte BootIndicator;
    /// <include file='PARTITION_INFORMATION.xml' path='doc/member[@name="PARTITION_INFORMATION.RecognizedPartition"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte RecognizedPartition;
    /// <include file='PARTITION_INFORMATION.xml' path='doc/member[@name="PARTITION_INFORMATION.RewritePartition"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte RewritePartition;
}