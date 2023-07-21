// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Gdiplus;

/// <include file='StringFormatFlags.xml' path='doc/member[@name="StringFormatFlags"]/*' />
[Flags]
public enum StringFormatFlags
{
    /// <include file='StringFormatFlags.xml' path='doc/member[@name="StringFormatFlags.StringFormatFlagsDirectionRightToLeft"]/*' />
    StringFormatFlagsDirectionRightToLeft = 0x00000001,

    /// <include file='StringFormatFlags.xml' path='doc/member[@name="StringFormatFlags.StringFormatFlagsDirectionVertical"]/*' />
    StringFormatFlagsDirectionVertical = 0x00000002,

    /// <include file='StringFormatFlags.xml' path='doc/member[@name="StringFormatFlags.StringFormatFlagsNoFitBlackBox"]/*' />
    StringFormatFlagsNoFitBlackBox = 0x00000004,

    /// <include file='StringFormatFlags.xml' path='doc/member[@name="StringFormatFlags.StringFormatFlagsDisplayFormatControl"]/*' />
    StringFormatFlagsDisplayFormatControl = 0x00000020,

    /// <include file='StringFormatFlags.xml' path='doc/member[@name="StringFormatFlags.StringFormatFlagsNoFontFallback"]/*' />
    StringFormatFlagsNoFontFallback = 0x00000400,

    /// <include file='StringFormatFlags.xml' path='doc/member[@name="StringFormatFlags.StringFormatFlagsMeasureTrailingSpaces"]/*' />
    StringFormatFlagsMeasureTrailingSpaces = 0x00000800,

    /// <include file='StringFormatFlags.xml' path='doc/member[@name="StringFormatFlags.StringFormatFlagsNoWrap"]/*' />
    StringFormatFlagsNoWrap = 0x00001000,

    /// <include file='StringFormatFlags.xml' path='doc/member[@name="StringFormatFlags.StringFormatFlagsLineLimit"]/*' />
    StringFormatFlagsLineLimit = 0x00002000,

    /// <include file='StringFormatFlags.xml' path='doc/member[@name="StringFormatFlags.StringFormatFlagsNoClip"]/*' />
    StringFormatFlagsNoClip = 0x00004000,

    /// <include file='StringFormatFlags.xml' path='doc/member[@name="StringFormatFlags.StringFormatFlagsBypassGDI"]/*' />
    StringFormatFlagsBypassGDI = unchecked((int)(0x80000000)),
}
