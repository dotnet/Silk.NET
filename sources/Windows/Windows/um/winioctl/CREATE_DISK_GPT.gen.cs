// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='CREATE_DISK_GPT.xml' path='doc/member[@name="CREATE_DISK_GPT"]/*' />
public partial struct CREATE_DISK_GPT
{
    /// <include file='CREATE_DISK_GPT.xml' path='doc/member[@name="CREATE_DISK_GPT.DiskId"]/*' />
    public Guid DiskId;

    /// <include file='CREATE_DISK_GPT.xml' path='doc/member[@name="CREATE_DISK_GPT.MaxPartitionCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxPartitionCount;
}
