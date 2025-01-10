// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.data.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum UnicodeGeneralCategory
{
    UnicodeGeneralCategory_UppercaseLetter = 0,
    UnicodeGeneralCategory_LowercaseLetter = 1,
    UnicodeGeneralCategory_TitlecaseLetter = 2,
    UnicodeGeneralCategory_ModifierLetter = 3,
    UnicodeGeneralCategory_OtherLetter = 4,
    UnicodeGeneralCategory_NonspacingMark = 5,
    UnicodeGeneralCategory_SpacingCombiningMark = 6,
    UnicodeGeneralCategory_EnclosingMark = 7,
    UnicodeGeneralCategory_DecimalDigitNumber = 8,
    UnicodeGeneralCategory_LetterNumber = 9,
    UnicodeGeneralCategory_OtherNumber = 10,
    UnicodeGeneralCategory_SpaceSeparator = 11,
    UnicodeGeneralCategory_LineSeparator = 12,
    UnicodeGeneralCategory_ParagraphSeparator = 13,
    UnicodeGeneralCategory_Control = 14,
    UnicodeGeneralCategory_Format = 15,
    UnicodeGeneralCategory_Surrogate = 16,
    UnicodeGeneralCategory_PrivateUse = 17,
    UnicodeGeneralCategory_ConnectorPunctuation = 18,
    UnicodeGeneralCategory_DashPunctuation = 19,
    UnicodeGeneralCategory_OpenPunctuation = 20,
    UnicodeGeneralCategory_ClosePunctuation = 21,
    UnicodeGeneralCategory_InitialQuotePunctuation = 22,
    UnicodeGeneralCategory_FinalQuotePunctuation = 23,
    UnicodeGeneralCategory_OtherPunctuation = 24,
    UnicodeGeneralCategory_MathSymbol = 25,
    UnicodeGeneralCategory_CurrencySymbol = 26,
    UnicodeGeneralCategory_ModifierSymbol = 27,
    UnicodeGeneralCategory_OtherSymbol = 28,
    UnicodeGeneralCategory_NotAssigned = 29,
}
