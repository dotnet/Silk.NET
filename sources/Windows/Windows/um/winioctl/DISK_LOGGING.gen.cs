// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DISK_LOGGING.xml' path='doc/member[@name="DISK_LOGGING"]/*' />
public unsafe partial struct DISK_LOGGING
{
    /// <include file='DISK_LOGGING.xml' path='doc/member[@name="DISK_LOGGING.Function"]/*' />
    public byte Function;

    /// <include file='DISK_LOGGING.xml' path='doc/member[@name="DISK_LOGGING.BufferAddress"]/*' />
    [NativeTypeName("PVOID")]
    public void* BufferAddress;

    /// <include file='DISK_LOGGING.xml' path='doc/member[@name="DISK_LOGGING.BufferSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint BufferSize;
}
