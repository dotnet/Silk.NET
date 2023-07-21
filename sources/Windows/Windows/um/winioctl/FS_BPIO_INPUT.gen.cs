// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='FS_BPIO_INPUT.xml' path='doc/member[@name="FS_BPIO_INPUT"]/*' />
public partial struct FS_BPIO_INPUT
{
    /// <include file='FS_BPIO_INPUT.xml' path='doc/member[@name="FS_BPIO_INPUT.Operation"]/*' />
    public FS_BPIO_OPERATIONS Operation;

    /// <include file='FS_BPIO_INPUT.xml' path='doc/member[@name="FS_BPIO_INPUT.InFlags"]/*' />
    public FS_BPIO_INFLAGS InFlags;

    /// <include file='FS_BPIO_INPUT.xml' path='doc/member[@name="FS_BPIO_INPUT.Reserved1"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong Reserved1;

    /// <include file='FS_BPIO_INPUT.xml' path='doc/member[@name="FS_BPIO_INPUT.Reserved2"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong Reserved2;
}
