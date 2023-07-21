// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TXFS_WRITE_BACKUP_INFORMATION.xml' path='doc/member[@name="TXFS_WRITE_BACKUP_INFORMATION"]/*' />
public unsafe partial struct TXFS_WRITE_BACKUP_INFORMATION
{
    /// <include file='TXFS_WRITE_BACKUP_INFORMATION.xml' path='doc/member[@name="TXFS_WRITE_BACKUP_INFORMATION.Buffer"]/*' />
    [NativeTypeName("BYTE[1]")]
    public fixed byte Buffer[1];
}
