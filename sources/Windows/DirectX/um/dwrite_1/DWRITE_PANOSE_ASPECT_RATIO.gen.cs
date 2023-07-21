// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='DWRITE_PANOSE_ASPECT_RATIO.xml' path='doc/member[@name="DWRITE_PANOSE_ASPECT_RATIO"]/*' />
public enum DWRITE_PANOSE_ASPECT_RATIO
{
    /// <include file='DWRITE_PANOSE_ASPECT_RATIO.xml' path='doc/member[@name="DWRITE_PANOSE_ASPECT_RATIO.DWRITE_PANOSE_ASPECT_RATIO_ANY"]/*' />
    DWRITE_PANOSE_ASPECT_RATIO_ANY = 0,

    /// <include file='DWRITE_PANOSE_ASPECT_RATIO.xml' path='doc/member[@name="DWRITE_PANOSE_ASPECT_RATIO.DWRITE_PANOSE_ASPECT_RATIO_NO_FIT"]/*' />
    DWRITE_PANOSE_ASPECT_RATIO_NO_FIT = 1,

    /// <include file='DWRITE_PANOSE_ASPECT_RATIO.xml' path='doc/member[@name="DWRITE_PANOSE_ASPECT_RATIO.DWRITE_PANOSE_ASPECT_RATIO_VERY_CONDENSED"]/*' />
    DWRITE_PANOSE_ASPECT_RATIO_VERY_CONDENSED = 2,

    /// <include file='DWRITE_PANOSE_ASPECT_RATIO.xml' path='doc/member[@name="DWRITE_PANOSE_ASPECT_RATIO.DWRITE_PANOSE_ASPECT_RATIO_CONDENSED"]/*' />
    DWRITE_PANOSE_ASPECT_RATIO_CONDENSED = 3,

    /// <include file='DWRITE_PANOSE_ASPECT_RATIO.xml' path='doc/member[@name="DWRITE_PANOSE_ASPECT_RATIO.DWRITE_PANOSE_ASPECT_RATIO_NORMAL"]/*' />
    DWRITE_PANOSE_ASPECT_RATIO_NORMAL = 4,

    /// <include file='DWRITE_PANOSE_ASPECT_RATIO.xml' path='doc/member[@name="DWRITE_PANOSE_ASPECT_RATIO.DWRITE_PANOSE_ASPECT_RATIO_EXPANDED"]/*' />
    DWRITE_PANOSE_ASPECT_RATIO_EXPANDED = 5,

    /// <include file='DWRITE_PANOSE_ASPECT_RATIO.xml' path='doc/member[@name="DWRITE_PANOSE_ASPECT_RATIO.DWRITE_PANOSE_ASPECT_RATIO_VERY_EXPANDED"]/*' />
    DWRITE_PANOSE_ASPECT_RATIO_VERY_EXPANDED = 6,
}
