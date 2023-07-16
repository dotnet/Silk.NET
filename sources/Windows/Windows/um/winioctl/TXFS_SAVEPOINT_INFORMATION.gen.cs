// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TXFS_SAVEPOINT_INFORMATION.xml' path='doc/member[@name="TXFS_SAVEPOINT_INFORMATION"]/*'/>
public partial struct TXFS_SAVEPOINT_INFORMATION
{
    /// <include file='TXFS_SAVEPOINT_INFORMATION.xml' path='doc/member[@name="TXFS_SAVEPOINT_INFORMATION.KtmTransaction"]/*'/>
    public HANDLE KtmTransaction;
    /// <include file='TXFS_SAVEPOINT_INFORMATION.xml' path='doc/member[@name="TXFS_SAVEPOINT_INFORMATION.ActionCode"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ActionCode;
    /// <include file='TXFS_SAVEPOINT_INFORMATION.xml' path='doc/member[@name="TXFS_SAVEPOINT_INFORMATION.SavepointId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SavepointId;
}