// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DISK_GROW_PARTITION.xml' path='doc/member[@name="DISK_GROW_PARTITION"]/*'/>
public partial struct DISK_GROW_PARTITION
{
    /// <include file='DISK_GROW_PARTITION.xml' path='doc/member[@name="DISK_GROW_PARTITION.PartitionNumber"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PartitionNumber;
    /// <include file='DISK_GROW_PARTITION.xml' path='doc/member[@name="DISK_GROW_PARTITION.BytesToGrow"]/*'/>
    public LARGE_INTEGER BytesToGrow;
}