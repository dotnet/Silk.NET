// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WICBitmapInterpolationMode.xml' path='doc/member[@name="WICBitmapInterpolationMode"]/*' />
public enum WICBitmapInterpolationMode
{
    /// <include file='WICBitmapInterpolationMode.xml' path='doc/member[@name="WICBitmapInterpolationMode.WICBitmapInterpolationModeNearestNeighbor"]/*' />
    WICBitmapInterpolationModeNearestNeighbor = 0,

    /// <include file='WICBitmapInterpolationMode.xml' path='doc/member[@name="WICBitmapInterpolationMode.WICBitmapInterpolationModeLinear"]/*' />
    WICBitmapInterpolationModeLinear = 0x1,

    /// <include file='WICBitmapInterpolationMode.xml' path='doc/member[@name="WICBitmapInterpolationMode.WICBitmapInterpolationModeCubic"]/*' />
    WICBitmapInterpolationModeCubic = 0x2,

    /// <include file='WICBitmapInterpolationMode.xml' path='doc/member[@name="WICBitmapInterpolationMode.WICBitmapInterpolationModeFant"]/*' />
    WICBitmapInterpolationModeFant = 0x3,

    /// <include file='WICBitmapInterpolationMode.xml' path='doc/member[@name="WICBitmapInterpolationMode.WICBitmapInterpolationModeHighQualityCubic"]/*' />
    WICBitmapInterpolationModeHighQualityCubic = 0x4,

    /// <include file='WICBitmapInterpolationMode.xml' path='doc/member[@name="WICBitmapInterpolationMode.WICBITMAPINTERPOLATIONMODE_FORCE_DWORD"]/*' />
    WICBITMAPINTERPOLATIONMODE_FORCE_DWORD = 0x7fffffff,
}
