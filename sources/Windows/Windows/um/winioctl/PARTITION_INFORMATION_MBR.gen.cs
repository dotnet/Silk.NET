// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='PARTITION_INFORMATION_MBR.xml' path='doc/member[@name="PARTITION_INFORMATION_MBR"]/*'/>
public partial struct PARTITION_INFORMATION_MBR
{
    /// <include file='PARTITION_INFORMATION_MBR.xml' path='doc/member[@name="PARTITION_INFORMATION_MBR.PartitionType"]/*'/>
    public byte PartitionType;
    /// <include file='PARTITION_INFORMATION_MBR.xml' path='doc/member[@name="PARTITION_INFORMATION_MBR.BootIndicator"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte BootIndicator;
    /// <include file='PARTITION_INFORMATION_MBR.xml' path='doc/member[@name="PARTITION_INFORMATION_MBR.RecognizedPartition"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte RecognizedPartition;
    /// <include file='PARTITION_INFORMATION_MBR.xml' path='doc/member[@name="PARTITION_INFORMATION_MBR.HiddenSectors"]/*'/>
    [NativeTypeName("DWORD")]
    public uint HiddenSectors;
    /// <include file='PARTITION_INFORMATION_MBR.xml' path='doc/member[@name="PARTITION_INFORMATION_MBR.PartitionId"]/*'/>
    public Guid PartitionId;
}