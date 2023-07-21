// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WICBitmapLockFlags.xml' path='doc/member[@name="WICBitmapLockFlags"]/*' />
public enum WICBitmapLockFlags
{
    /// <include file='WICBitmapLockFlags.xml' path='doc/member[@name="WICBitmapLockFlags.WICBitmapLockRead"]/*' />
    WICBitmapLockRead = 0x1,

    /// <include file='WICBitmapLockFlags.xml' path='doc/member[@name="WICBitmapLockFlags.WICBitmapLockWrite"]/*' />
    WICBitmapLockWrite = 0x2,

    /// <include file='WICBitmapLockFlags.xml' path='doc/member[@name="WICBitmapLockFlags.WICBITMAPLOCKFLAGS_FORCE_DWORD"]/*' />
    WICBITMAPLOCKFLAGS_FORCE_DWORD = 0x7fffffff,
}
