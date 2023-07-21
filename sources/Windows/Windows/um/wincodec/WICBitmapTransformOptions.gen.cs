// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WICBitmapTransformOptions.xml' path='doc/member[@name="WICBitmapTransformOptions"]/*' />
public enum WICBitmapTransformOptions
{
    /// <include file='WICBitmapTransformOptions.xml' path='doc/member[@name="WICBitmapTransformOptions.WICBitmapTransformRotate0"]/*' />
    WICBitmapTransformRotate0 = 0,

    /// <include file='WICBitmapTransformOptions.xml' path='doc/member[@name="WICBitmapTransformOptions.WICBitmapTransformRotate90"]/*' />
    WICBitmapTransformRotate90 = 0x1,

    /// <include file='WICBitmapTransformOptions.xml' path='doc/member[@name="WICBitmapTransformOptions.WICBitmapTransformRotate180"]/*' />
    WICBitmapTransformRotate180 = 0x2,

    /// <include file='WICBitmapTransformOptions.xml' path='doc/member[@name="WICBitmapTransformOptions.WICBitmapTransformRotate270"]/*' />
    WICBitmapTransformRotate270 = 0x3,

    /// <include file='WICBitmapTransformOptions.xml' path='doc/member[@name="WICBitmapTransformOptions.WICBitmapTransformFlipHorizontal"]/*' />
    WICBitmapTransformFlipHorizontal = 0x8,

    /// <include file='WICBitmapTransformOptions.xml' path='doc/member[@name="WICBitmapTransformOptions.WICBitmapTransformFlipVertical"]/*' />
    WICBitmapTransformFlipVertical = 0x10,

    /// <include file='WICBitmapTransformOptions.xml' path='doc/member[@name="WICBitmapTransformOptions.WICBITMAPTRANSFORMOPTIONS_FORCE_DWORD"]/*' />
    WICBITMAPTRANSFORMOPTIONS_FORCE_DWORD = 0x7fffffff,
}
