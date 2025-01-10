// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum MarkerType
{
    MarkerType_Undefined = 0,
    MarkerType_None = 1,
    MarkerType_Bullet = 2,
    MarkerType_Arabic = 3,
    MarkerType_LowercaseEnglishLetter = 4,
    MarkerType_UppercaseEnglishLetter = 5,
    MarkerType_LowercaseRoman = 6,
    MarkerType_UppercaseRoman = 7,
    MarkerType_UnicodeSequence = 8,
    MarkerType_CircledNumber = 9,
    MarkerType_BlackCircleWingding = 10,
    MarkerType_WhiteCircleWingding = 11,
    MarkerType_ArabicWide = 12,
    MarkerType_SimplifiedChinese = 13,
    MarkerType_TraditionalChinese = 14,
    MarkerType_JapanSimplifiedChinese = 15,
    MarkerType_JapanKorea = 16,
    MarkerType_ArabicDictionary = 17,
    MarkerType_ArabicAbjad = 18,
    MarkerType_Hebrew = 19,
    MarkerType_ThaiAlphabetic = 20,
    MarkerType_ThaiNumeric = 21,
    MarkerType_DevanagariVowel = 22,
    MarkerType_DevanagariConsonant = 23,
    MarkerType_DevanagariNumeric = 24,
}
