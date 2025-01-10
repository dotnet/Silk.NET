// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum styleVerticalAlign
{
    styleVerticalAlignAuto = 0,
    styleVerticalAlignBaseline = 1,
    styleVerticalAlignSub = 2,
    styleVerticalAlignSuper = 3,
    styleVerticalAlignTop = 4,
    styleVerticalAlignTextTop = 5,
    styleVerticalAlignMiddle = 6,
    styleVerticalAlignBottom = 7,
    styleVerticalAlignTextBottom = 8,
    styleVerticalAlignInherit = 9,
    styleVerticalAlignNotSet = 10,
    styleVerticalAlign_Max = 2147483647,
}
