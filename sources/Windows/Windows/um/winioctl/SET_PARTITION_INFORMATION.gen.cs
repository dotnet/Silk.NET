// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SET_PARTITION_INFORMATION.xml' path='doc/member[@name="SET_PARTITION_INFORMATION"]/*'/>
public partial struct SET_PARTITION_INFORMATION
{
    /// <include file='SET_PARTITION_INFORMATION.xml' path='doc/member[@name="SET_PARTITION_INFORMATION.PartitionType"]/*'/>
    public byte PartitionType;
}