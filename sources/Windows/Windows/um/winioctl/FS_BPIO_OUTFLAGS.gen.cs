// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='FS_BPIO_OUTFLAGS.xml' path='doc/member[@name="FS_BPIO_OUTFLAGS"]/*' />
public enum FS_BPIO_OUTFLAGS
{
    /// <include file='FS_BPIO_OUTFLAGS.xml' path='doc/member[@name="FS_BPIO_OUTFLAGS.FSBPIO_OUTFL_None"]/*' />
    FSBPIO_OUTFL_None = 0,

    /// <include file='FS_BPIO_OUTFLAGS.xml' path='doc/member[@name="FS_BPIO_OUTFLAGS.FSBPIO_OUTFL_VOLUME_STACK_BYPASS_PAUSED"]/*' />
    FSBPIO_OUTFL_VOLUME_STACK_BYPASS_PAUSED = 0x00000001,

    /// <include file='FS_BPIO_OUTFLAGS.xml' path='doc/member[@name="FS_BPIO_OUTFLAGS.FSBPIO_OUTFL_STREAM_BYPASS_PAUSED"]/*' />
    FSBPIO_OUTFL_STREAM_BYPASS_PAUSED = 0x00000002,

    /// <include file='FS_BPIO_OUTFLAGS.xml' path='doc/member[@name="FS_BPIO_OUTFLAGS.FSBPIO_OUTFL_FILTER_ATTACH_BLOCKED"]/*' />
    FSBPIO_OUTFL_FILTER_ATTACH_BLOCKED = 0x00000004,

    /// <include file='FS_BPIO_OUTFLAGS.xml' path='doc/member[@name="FS_BPIO_OUTFLAGS.FSBPIO_OUTFL_COMPATIBLE_STORAGE_DRIVER"]/*' />
    FSBPIO_OUTFL_COMPATIBLE_STORAGE_DRIVER = 0x00000008,
}
