// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Gdiplus;

/// <include file='FontStyle.xml' path='doc/member[@name="FontStyle"]/*' />
public enum FontStyle
{
    /// <include file='FontStyle.xml' path='doc/member[@name="FontStyle.FontStyleRegular"]/*' />
    FontStyleRegular = 0,

    /// <include file='FontStyle.xml' path='doc/member[@name="FontStyle.FontStyleBold"]/*' />
    FontStyleBold = 1,

    /// <include file='FontStyle.xml' path='doc/member[@name="FontStyle.FontStyleItalic"]/*' />
    FontStyleItalic = 2,

    /// <include file='FontStyle.xml' path='doc/member[@name="FontStyle.FontStyleBoldItalic"]/*' />
    FontStyleBoldItalic = 3,

    /// <include file='FontStyle.xml' path='doc/member[@name="FontStyle.FontStyleUnderline"]/*' />
    FontStyleUnderline = 4,

    /// <include file='FontStyle.xml' path='doc/member[@name="FontStyle.FontStyleStrikeout"]/*' />
    FontStyleStrikeout = 8,
}
