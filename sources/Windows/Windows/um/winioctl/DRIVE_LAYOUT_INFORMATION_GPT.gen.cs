// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='DRIVE_LAYOUT_INFORMATION_GPT.xml' path='doc/member[@name="DRIVE_LAYOUT_INFORMATION_GPT"]/*' />
public partial struct DRIVE_LAYOUT_INFORMATION_GPT
{
    /// <include file='DRIVE_LAYOUT_INFORMATION_GPT.xml' path='doc/member[@name="DRIVE_LAYOUT_INFORMATION_GPT.DiskId"]/*' />
    public Guid DiskId;

    /// <include file='DRIVE_LAYOUT_INFORMATION_GPT.xml' path='doc/member[@name="DRIVE_LAYOUT_INFORMATION_GPT.StartingUsableOffset"]/*' />
    public LARGE_INTEGER StartingUsableOffset;

    /// <include file='DRIVE_LAYOUT_INFORMATION_GPT.xml' path='doc/member[@name="DRIVE_LAYOUT_INFORMATION_GPT.UsableLength"]/*' />
    public LARGE_INTEGER UsableLength;

    /// <include file='DRIVE_LAYOUT_INFORMATION_GPT.xml' path='doc/member[@name="DRIVE_LAYOUT_INFORMATION_GPT.MaxPartitionCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxPartitionCount;
}
