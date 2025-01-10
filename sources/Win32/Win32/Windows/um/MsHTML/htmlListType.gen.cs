// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum htmlListType
{
    htmlListTypeNotSet = 0,
    htmlListTypeLargeAlpha = 1,
    htmlListTypeSmallAlpha = 2,
    htmlListTypeLargeRoman = 3,
    htmlListTypeSmallRoman = 4,
    htmlListTypeNumbers = 5,
    htmlListTypeDisc = 6,
    htmlListTypeCircle = 7,
    htmlListTypeSquare = 8,
    htmlListType_Max = 2147483647,
}
