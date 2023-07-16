// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TXFS_ROLLFORWARD_REDO_INFORMATION.xml' path='doc/member[@name="TXFS_ROLLFORWARD_REDO_INFORMATION"]/*'/>
public partial struct TXFS_ROLLFORWARD_REDO_INFORMATION
{
    /// <include file='TXFS_ROLLFORWARD_REDO_INFORMATION.xml' path='doc/member[@name="TXFS_ROLLFORWARD_REDO_INFORMATION.LastVirtualClock"]/*'/>
    public LARGE_INTEGER LastVirtualClock;
    /// <include file='TXFS_ROLLFORWARD_REDO_INFORMATION.xml' path='doc/member[@name="TXFS_ROLLFORWARD_REDO_INFORMATION.LastRedoLsn"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong LastRedoLsn;
    /// <include file='TXFS_ROLLFORWARD_REDO_INFORMATION.xml' path='doc/member[@name="TXFS_ROLLFORWARD_REDO_INFORMATION.HighestRecoveryLsn"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong HighestRecoveryLsn;
    /// <include file='TXFS_ROLLFORWARD_REDO_INFORMATION.xml' path='doc/member[@name="TXFS_ROLLFORWARD_REDO_INFORMATION.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
}