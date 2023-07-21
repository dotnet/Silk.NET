// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='FS_BPIO_INFLAGS.xml' path='doc/member[@name="FS_BPIO_INFLAGS"]/*' />
public enum FS_BPIO_INFLAGS
{
    /// <include file='FS_BPIO_INFLAGS.xml' path='doc/member[@name="FS_BPIO_INFLAGS.FSBPIO_INFL_None"]/*' />
    FSBPIO_INFL_None = 0,

    /// <include file='FS_BPIO_INFLAGS.xml' path='doc/member[@name="FS_BPIO_INFLAGS.FSBPIO_INFL_SKIP_STORAGE_STACK_QUERY"]/*' />
    FSBPIO_INFL_SKIP_STORAGE_STACK_QUERY = 1,
}
