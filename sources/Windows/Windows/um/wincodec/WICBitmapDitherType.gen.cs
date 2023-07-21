// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WICBitmapDitherType.xml' path='doc/member[@name="WICBitmapDitherType"]/*' />
public enum WICBitmapDitherType
{
    /// <include file='WICBitmapDitherType.xml' path='doc/member[@name="WICBitmapDitherType.WICBitmapDitherTypeNone"]/*' />
    WICBitmapDitherTypeNone = 0,

    /// <include file='WICBitmapDitherType.xml' path='doc/member[@name="WICBitmapDitherType.WICBitmapDitherTypeSolid"]/*' />
    WICBitmapDitherTypeSolid = 0,

    /// <include file='WICBitmapDitherType.xml' path='doc/member[@name="WICBitmapDitherType.WICBitmapDitherTypeOrdered4x4"]/*' />
    WICBitmapDitherTypeOrdered4x4 = 0x1,

    /// <include file='WICBitmapDitherType.xml' path='doc/member[@name="WICBitmapDitherType.WICBitmapDitherTypeOrdered8x8"]/*' />
    WICBitmapDitherTypeOrdered8x8 = 0x2,

    /// <include file='WICBitmapDitherType.xml' path='doc/member[@name="WICBitmapDitherType.WICBitmapDitherTypeOrdered16x16"]/*' />
    WICBitmapDitherTypeOrdered16x16 = 0x3,

    /// <include file='WICBitmapDitherType.xml' path='doc/member[@name="WICBitmapDitherType.WICBitmapDitherTypeSpiral4x4"]/*' />
    WICBitmapDitherTypeSpiral4x4 = 0x4,

    /// <include file='WICBitmapDitherType.xml' path='doc/member[@name="WICBitmapDitherType.WICBitmapDitherTypeSpiral8x8"]/*' />
    WICBitmapDitherTypeSpiral8x8 = 0x5,

    /// <include file='WICBitmapDitherType.xml' path='doc/member[@name="WICBitmapDitherType.WICBitmapDitherTypeDualSpiral4x4"]/*' />
    WICBitmapDitherTypeDualSpiral4x4 = 0x6,

    /// <include file='WICBitmapDitherType.xml' path='doc/member[@name="WICBitmapDitherType.WICBitmapDitherTypeDualSpiral8x8"]/*' />
    WICBitmapDitherTypeDualSpiral8x8 = 0x7,

    /// <include file='WICBitmapDitherType.xml' path='doc/member[@name="WICBitmapDitherType.WICBitmapDitherTypeErrorDiffusion"]/*' />
    WICBitmapDitherTypeErrorDiffusion = 0x8,

    /// <include file='WICBitmapDitherType.xml' path='doc/member[@name="WICBitmapDitherType.WICBITMAPDITHERTYPE_FORCE_DWORD"]/*' />
    WICBITMAPDITHERTYPE_FORCE_DWORD = 0x7fffffff,
}
