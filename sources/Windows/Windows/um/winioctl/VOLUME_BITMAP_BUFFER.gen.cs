// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='VOLUME_BITMAP_BUFFER.xml' path='doc/member[@name="VOLUME_BITMAP_BUFFER"]/*' />
public unsafe partial struct VOLUME_BITMAP_BUFFER
{
    /// <include file='VOLUME_BITMAP_BUFFER.xml' path='doc/member[@name="VOLUME_BITMAP_BUFFER.StartingLcn"]/*' />
    public LARGE_INTEGER StartingLcn;

    /// <include file='VOLUME_BITMAP_BUFFER.xml' path='doc/member[@name="VOLUME_BITMAP_BUFFER.BitmapSize"]/*' />
    public LARGE_INTEGER BitmapSize;

    /// <include file='VOLUME_BITMAP_BUFFER.xml' path='doc/member[@name="VOLUME_BITMAP_BUFFER.Buffer"]/*' />
    [NativeTypeName("BYTE[1]")]
    public fixed byte Buffer[1];
}
