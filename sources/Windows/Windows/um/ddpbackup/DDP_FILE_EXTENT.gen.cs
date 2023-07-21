// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddpbackup.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DDP_FILE_EXTENT.xml' path='doc/member[@name="DDP_FILE_EXTENT"]/*' />
public partial struct DDP_FILE_EXTENT
{
    /// <include file='DDP_FILE_EXTENT.xml' path='doc/member[@name="DDP_FILE_EXTENT.Length"]/*' />
    [NativeTypeName("long long")]
    public long Length;

    /// <include file='DDP_FILE_EXTENT.xml' path='doc/member[@name="DDP_FILE_EXTENT.Offset"]/*' />
    [NativeTypeName("long long")]
    public long Offset;
}
