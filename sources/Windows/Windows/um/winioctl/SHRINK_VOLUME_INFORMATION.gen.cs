// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SHRINK_VOLUME_INFORMATION.xml' path='doc/member[@name="SHRINK_VOLUME_INFORMATION"]/*' />
public partial struct SHRINK_VOLUME_INFORMATION
{
    /// <include file='SHRINK_VOLUME_INFORMATION.xml' path='doc/member[@name="SHRINK_VOLUME_INFORMATION.ShrinkRequestType"]/*' />
    public SHRINK_VOLUME_REQUEST_TYPES ShrinkRequestType;

    /// <include file='SHRINK_VOLUME_INFORMATION.xml' path='doc/member[@name="SHRINK_VOLUME_INFORMATION.Flags"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong Flags;

    /// <include file='SHRINK_VOLUME_INFORMATION.xml' path='doc/member[@name="SHRINK_VOLUME_INFORMATION.NewNumberOfSectors"]/*' />
    [NativeTypeName("LONGLONG")]
    public long NewNumberOfSectors;
}
