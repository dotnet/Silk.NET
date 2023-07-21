// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusimaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Gdiplus;

/// <include file='ImageFlags.xml' path='doc/member[@name="ImageFlags"]/*' />
[Flags]
public enum ImageFlags
{
    /// <include file='ImageFlags.xml' path='doc/member[@name="ImageFlags.ImageFlagsNone"]/*' />
    ImageFlagsNone = 0,

    /// <include file='ImageFlags.xml' path='doc/member[@name="ImageFlags.ImageFlagsScalable"]/*' />
    ImageFlagsScalable = 0x0001,

    /// <include file='ImageFlags.xml' path='doc/member[@name="ImageFlags.ImageFlagsHasAlpha"]/*' />
    ImageFlagsHasAlpha = 0x0002,

    /// <include file='ImageFlags.xml' path='doc/member[@name="ImageFlags.ImageFlagsHasTranslucent"]/*' />
    ImageFlagsHasTranslucent = 0x0004,

    /// <include file='ImageFlags.xml' path='doc/member[@name="ImageFlags.ImageFlagsPartiallyScalable"]/*' />
    ImageFlagsPartiallyScalable = 0x0008,

    /// <include file='ImageFlags.xml' path='doc/member[@name="ImageFlags.ImageFlagsColorSpaceRGB"]/*' />
    ImageFlagsColorSpaceRGB = 0x0010,

    /// <include file='ImageFlags.xml' path='doc/member[@name="ImageFlags.ImageFlagsColorSpaceCMYK"]/*' />
    ImageFlagsColorSpaceCMYK = 0x0020,

    /// <include file='ImageFlags.xml' path='doc/member[@name="ImageFlags.ImageFlagsColorSpaceGRAY"]/*' />
    ImageFlagsColorSpaceGRAY = 0x0040,

    /// <include file='ImageFlags.xml' path='doc/member[@name="ImageFlags.ImageFlagsColorSpaceYCBCR"]/*' />
    ImageFlagsColorSpaceYCBCR = 0x0080,

    /// <include file='ImageFlags.xml' path='doc/member[@name="ImageFlags.ImageFlagsColorSpaceYCCK"]/*' />
    ImageFlagsColorSpaceYCCK = 0x0100,

    /// <include file='ImageFlags.xml' path='doc/member[@name="ImageFlags.ImageFlagsHasRealDPI"]/*' />
    ImageFlagsHasRealDPI = 0x1000,

    /// <include file='ImageFlags.xml' path='doc/member[@name="ImageFlags.ImageFlagsHasRealPixelSize"]/*' />
    ImageFlagsHasRealPixelSize = 0x2000,

    /// <include file='ImageFlags.xml' path='doc/member[@name="ImageFlags.ImageFlagsReadOnly"]/*' />
    ImageFlagsReadOnly = 0x00010000,

    /// <include file='ImageFlags.xml' path='doc/member[@name="ImageFlags.ImageFlagsCaching"]/*' />
    ImageFlagsCaching = 0x00020000,
}
