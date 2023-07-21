// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TXFS_GET_TRANSACTED_VERSION.xml' path='doc/member[@name="TXFS_GET_TRANSACTED_VERSION"]/*' />
public partial struct TXFS_GET_TRANSACTED_VERSION
{
    /// <include file='TXFS_GET_TRANSACTED_VERSION.xml' path='doc/member[@name="TXFS_GET_TRANSACTED_VERSION.ThisBaseVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint ThisBaseVersion;

    /// <include file='TXFS_GET_TRANSACTED_VERSION.xml' path='doc/member[@name="TXFS_GET_TRANSACTED_VERSION.LatestVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint LatestVersion;

    /// <include file='TXFS_GET_TRANSACTED_VERSION.xml' path='doc/member[@name="TXFS_GET_TRANSACTED_VERSION.ThisMiniVersion"]/*' />
    [NativeTypeName("WORD")]
    public ushort ThisMiniVersion;

    /// <include file='TXFS_GET_TRANSACTED_VERSION.xml' path='doc/member[@name="TXFS_GET_TRANSACTED_VERSION.FirstMiniVersion"]/*' />
    [NativeTypeName("WORD")]
    public ushort FirstMiniVersion;

    /// <include file='TXFS_GET_TRANSACTED_VERSION.xml' path='doc/member[@name="TXFS_GET_TRANSACTED_VERSION.LatestMiniVersion"]/*' />
    [NativeTypeName("WORD")]
    public ushort LatestMiniVersion;
}
