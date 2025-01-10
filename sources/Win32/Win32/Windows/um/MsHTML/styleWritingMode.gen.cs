// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum styleWritingMode
{
    styleWritingModeLrtb = 0,
    styleWritingModeTbrl = 1,
    styleWritingModeRltb = 2,
    styleWritingModeBtrl = 3,
    styleWritingModeNotSet = 4,
    styleWritingModeTblr = 5,
    styleWritingModeBtlr = 6,
    styleWritingModeLrbt = 7,
    styleWritingModeRlbt = 8,
    styleWritingModeLr = 9,
    styleWritingModeRl = 10,
    styleWritingModeTb = 11,
    styleWritingMode_Max = 2147483647,
}
