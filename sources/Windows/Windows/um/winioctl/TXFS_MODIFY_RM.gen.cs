// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TXFS_MODIFY_RM.xml' path='doc/member[@name="TXFS_MODIFY_RM"]/*'/>
public partial struct TXFS_MODIFY_RM
{
    /// <include file='TXFS_MODIFY_RM.xml' path='doc/member[@name="TXFS_MODIFY_RM.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='TXFS_MODIFY_RM.xml' path='doc/member[@name="TXFS_MODIFY_RM.LogContainerCountMax"]/*'/>
    [NativeTypeName("DWORD")]
    public uint LogContainerCountMax;
    /// <include file='TXFS_MODIFY_RM.xml' path='doc/member[@name="TXFS_MODIFY_RM.LogContainerCountMin"]/*'/>
    [NativeTypeName("DWORD")]
    public uint LogContainerCountMin;
    /// <include file='TXFS_MODIFY_RM.xml' path='doc/member[@name="TXFS_MODIFY_RM.LogContainerCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint LogContainerCount;
    /// <include file='TXFS_MODIFY_RM.xml' path='doc/member[@name="TXFS_MODIFY_RM.LogGrowthIncrement"]/*'/>
    [NativeTypeName("DWORD")]
    public uint LogGrowthIncrement;
    /// <include file='TXFS_MODIFY_RM.xml' path='doc/member[@name="TXFS_MODIFY_RM.LogAutoShrinkPercentage"]/*'/>
    [NativeTypeName("DWORD")]
    public uint LogAutoShrinkPercentage;
    /// <include file='TXFS_MODIFY_RM.xml' path='doc/member[@name="TXFS_MODIFY_RM.Reserved"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong Reserved;
    /// <include file='TXFS_MODIFY_RM.xml' path='doc/member[@name="TXFS_MODIFY_RM.LoggingMode"]/*'/>
    [NativeTypeName("WORD")]
    public ushort LoggingMode;
}