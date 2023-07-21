// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WICPngChrmProperties.xml' path='doc/member[@name="WICPngChrmProperties"]/*' />
public enum WICPngChrmProperties
{
    /// <include file='WICPngChrmProperties.xml' path='doc/member[@name="WICPngChrmProperties.WICPngChrmWhitePointX"]/*' />
    WICPngChrmWhitePointX = 0x1,

    /// <include file='WICPngChrmProperties.xml' path='doc/member[@name="WICPngChrmProperties.WICPngChrmWhitePointY"]/*' />
    WICPngChrmWhitePointY = 0x2,

    /// <include file='WICPngChrmProperties.xml' path='doc/member[@name="WICPngChrmProperties.WICPngChrmRedX"]/*' />
    WICPngChrmRedX = 0x3,

    /// <include file='WICPngChrmProperties.xml' path='doc/member[@name="WICPngChrmProperties.WICPngChrmRedY"]/*' />
    WICPngChrmRedY = 0x4,

    /// <include file='WICPngChrmProperties.xml' path='doc/member[@name="WICPngChrmProperties.WICPngChrmGreenX"]/*' />
    WICPngChrmGreenX = 0x5,

    /// <include file='WICPngChrmProperties.xml' path='doc/member[@name="WICPngChrmProperties.WICPngChrmGreenY"]/*' />
    WICPngChrmGreenY = 0x6,

    /// <include file='WICPngChrmProperties.xml' path='doc/member[@name="WICPngChrmProperties.WICPngChrmBlueX"]/*' />
    WICPngChrmBlueX = 0x7,

    /// <include file='WICPngChrmProperties.xml' path='doc/member[@name="WICPngChrmProperties.WICPngChrmBlueY"]/*' />
    WICPngChrmBlueY = 0x8,

    /// <include file='WICPngChrmProperties.xml' path='doc/member[@name="WICPngChrmProperties.WICPngChrmProperties_FORCE_DWORD"]/*' />
    WICPngChrmProperties_FORCE_DWORD = 0x7fffffff,
}
