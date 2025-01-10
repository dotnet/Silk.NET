// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum TextRangeUnit
{
    TextRangeUnit_Character = 0,
    TextRangeUnit_Word = 1,
    TextRangeUnit_Sentence = 2,
    TextRangeUnit_Paragraph = 3,
    TextRangeUnit_Line = 4,
    TextRangeUnit_Story = 5,
    TextRangeUnit_Screen = 6,
    TextRangeUnit_Section = 7,
    TextRangeUnit_Window = 8,
    TextRangeUnit_CharacterFormat = 9,
    TextRangeUnit_ParagraphFormat = 10,
    TextRangeUnit_Object = 11,
    TextRangeUnit_HardParagraph = 12,
    TextRangeUnit_Cluster = 13,
    TextRangeUnit_Bold = 14,
    TextRangeUnit_Italic = 15,
    TextRangeUnit_Underline = 16,
    TextRangeUnit_Strikethrough = 17,
    TextRangeUnit_ProtectedText = 18,
    TextRangeUnit_Link = 19,
    TextRangeUnit_SmallCaps = 20,
    TextRangeUnit_AllCaps = 21,
    TextRangeUnit_Hidden = 22,
    TextRangeUnit_Outline = 23,
    TextRangeUnit_Shadow = 24,
    TextRangeUnit_Imprint = 25,
    TextRangeUnit_Disabled = 26,
    TextRangeUnit_Revised = 27,
    TextRangeUnit_Subscript = 28,
    TextRangeUnit_Superscript = 29,
    TextRangeUnit_FontBound = 30,
    TextRangeUnit_LinkProtected = 31,
    TextRangeUnit_ContentLink = 32,
}
