// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DVD_TextCharSet
{
    DVD_CharSet_Unicode = 0,
    DVD_CharSet_ISO646 = 1,
    DVD_CharSet_JIS_Roman_Kanji = 2,
    DVD_CharSet_ISO8859_1 = 3,
    DVD_CharSet_ShiftJIS_Kanji_Roman_Katakana = 4,
}
