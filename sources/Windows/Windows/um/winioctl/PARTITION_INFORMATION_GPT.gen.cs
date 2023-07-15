// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='PARTITION_INFORMATION_GPT.xml' path='doc/member[@name="PARTITION_INFORMATION_GPT"]/*'/>
public unsafe partial struct PARTITION_INFORMATION_GPT
{
    /// <include file='PARTITION_INFORMATION_GPT.xml' path='doc/member[@name="PARTITION_INFORMATION_GPT.PartitionType"]/*'/>
    public Guid PartitionType;
    /// <include file='PARTITION_INFORMATION_GPT.xml' path='doc/member[@name="PARTITION_INFORMATION_GPT.PartitionId"]/*'/>
    public Guid PartitionId;
    /// <include file='PARTITION_INFORMATION_GPT.xml' path='doc/member[@name="PARTITION_INFORMATION_GPT.Attributes"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong Attributes;
    /// <include file='PARTITION_INFORMATION_GPT.xml' path='doc/member[@name="PARTITION_INFORMATION_GPT.Name"]/*'/>
    [NativeTypeName("WCHAR[36]")]
    public fixed ushort Name[36];
}