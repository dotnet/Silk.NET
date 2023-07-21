// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TXFS_START_RM_INFORMATION.xml' path='doc/member[@name="TXFS_START_RM_INFORMATION"]/*' />
public unsafe partial struct TXFS_START_RM_INFORMATION
{
    /// <include file='TXFS_START_RM_INFORMATION.xml' path='doc/member[@name="TXFS_START_RM_INFORMATION.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='TXFS_START_RM_INFORMATION.xml' path='doc/member[@name="TXFS_START_RM_INFORMATION.LogContainerSize"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong LogContainerSize;

    /// <include file='TXFS_START_RM_INFORMATION.xml' path='doc/member[@name="TXFS_START_RM_INFORMATION.LogContainerCountMin"]/*' />
    [NativeTypeName("DWORD")]
    public uint LogContainerCountMin;

    /// <include file='TXFS_START_RM_INFORMATION.xml' path='doc/member[@name="TXFS_START_RM_INFORMATION.LogContainerCountMax"]/*' />
    [NativeTypeName("DWORD")]
    public uint LogContainerCountMax;

    /// <include file='TXFS_START_RM_INFORMATION.xml' path='doc/member[@name="TXFS_START_RM_INFORMATION.LogGrowthIncrement"]/*' />
    [NativeTypeName("DWORD")]
    public uint LogGrowthIncrement;

    /// <include file='TXFS_START_RM_INFORMATION.xml' path='doc/member[@name="TXFS_START_RM_INFORMATION.LogAutoShrinkPercentage"]/*' />
    [NativeTypeName("DWORD")]
    public uint LogAutoShrinkPercentage;

    /// <include file='TXFS_START_RM_INFORMATION.xml' path='doc/member[@name="TXFS_START_RM_INFORMATION.TmLogPathOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint TmLogPathOffset;

    /// <include file='TXFS_START_RM_INFORMATION.xml' path='doc/member[@name="TXFS_START_RM_INFORMATION.TmLogPathLength"]/*' />
    [NativeTypeName("WORD")]
    public ushort TmLogPathLength;

    /// <include file='TXFS_START_RM_INFORMATION.xml' path='doc/member[@name="TXFS_START_RM_INFORMATION.LoggingMode"]/*' />
    [NativeTypeName("WORD")]
    public ushort LoggingMode;

    /// <include file='TXFS_START_RM_INFORMATION.xml' path='doc/member[@name="TXFS_START_RM_INFORMATION.LogPathLength"]/*' />
    [NativeTypeName("WORD")]
    public ushort LogPathLength;

    /// <include file='TXFS_START_RM_INFORMATION.xml' path='doc/member[@name="TXFS_START_RM_INFORMATION.Reserved"]/*' />
    [NativeTypeName("WORD")]
    public ushort Reserved;

    /// <include file='TXFS_START_RM_INFORMATION.xml' path='doc/member[@name="TXFS_START_RM_INFORMATION.LogPath"]/*' />
    [NativeTypeName("WCHAR[1]")]
    public fixed ushort LogPath[1];
}
