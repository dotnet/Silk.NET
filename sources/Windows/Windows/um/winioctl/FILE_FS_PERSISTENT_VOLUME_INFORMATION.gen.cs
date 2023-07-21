// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='FILE_FS_PERSISTENT_VOLUME_INFORMATION.xml' path='doc/member[@name="FILE_FS_PERSISTENT_VOLUME_INFORMATION"]/*' />
public partial struct FILE_FS_PERSISTENT_VOLUME_INFORMATION
{
    /// <include file='FILE_FS_PERSISTENT_VOLUME_INFORMATION.xml' path='doc/member[@name="FILE_FS_PERSISTENT_VOLUME_INFORMATION.VolumeFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint VolumeFlags;

    /// <include file='FILE_FS_PERSISTENT_VOLUME_INFORMATION.xml' path='doc/member[@name="FILE_FS_PERSISTENT_VOLUME_INFORMATION.FlagMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint FlagMask;

    /// <include file='FILE_FS_PERSISTENT_VOLUME_INFORMATION.xml' path='doc/member[@name="FILE_FS_PERSISTENT_VOLUME_INFORMATION.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='FILE_FS_PERSISTENT_VOLUME_INFORMATION.xml' path='doc/member[@name="FILE_FS_PERSISTENT_VOLUME_INFORMATION.Reserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved;
}
