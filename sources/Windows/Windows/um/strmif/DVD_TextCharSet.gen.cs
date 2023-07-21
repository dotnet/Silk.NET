// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DVD_TextCharSet.xml' path='doc/member[@name="DVD_TextCharSet"]/*' />
public enum DVD_TextCharSet
{
    /// <include file='DVD_TextCharSet.xml' path='doc/member[@name="DVD_TextCharSet.DVD_CharSet_Unicode"]/*' />
    DVD_CharSet_Unicode = 0,

    /// <include file='DVD_TextCharSet.xml' path='doc/member[@name="DVD_TextCharSet.DVD_CharSet_ISO646"]/*' />
    DVD_CharSet_ISO646 = 1,

    /// <include file='DVD_TextCharSet.xml' path='doc/member[@name="DVD_TextCharSet.DVD_CharSet_JIS_Roman_Kanji"]/*' />
    DVD_CharSet_JIS_Roman_Kanji = 2,

    /// <include file='DVD_TextCharSet.xml' path='doc/member[@name="DVD_TextCharSet.DVD_CharSet_ISO8859_1"]/*' />
    DVD_CharSet_ISO8859_1 = 3,

    /// <include file='DVD_TextCharSet.xml' path='doc/member[@name="DVD_TextCharSet.DVD_CharSet_ShiftJIS_Kanji_Roman_Katakana"]/*' />
    DVD_CharSet_ShiftJIS_Kanji_Roman_Katakana = 4,
}
