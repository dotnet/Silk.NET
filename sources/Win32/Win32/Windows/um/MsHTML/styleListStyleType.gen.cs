// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum styleListStyleType
{
    styleListStyleTypeNotSet = 0,
    styleListStyleTypeDisc = 1,
    styleListStyleTypeCircle = 2,
    styleListStyleTypeSquare = 3,
    styleListStyleTypeDecimal = 4,
    styleListStyleTypeLowerRoman = 5,
    styleListStyleTypeUpperRoman = 6,
    styleListStyleTypeLowerAlpha = 7,
    styleListStyleTypeUpperAlpha = 8,
    styleListStyleTypeNone = 9,
    styleListStyleTypeDecimalLeadingZero = 10,
    styleListStyleTypeGeorgian = 11,
    styleListStyleTypeArmenian = 12,
    styleListStyleTypeUpperLatin = 13,
    styleListStyleTypeLowerLatin = 14,
    styleListStyleTypeUpperGreek = 15,
    styleListStyleTypeLowerGreek = 16,
    styleListStyleType_Max = 2147483647,
}
